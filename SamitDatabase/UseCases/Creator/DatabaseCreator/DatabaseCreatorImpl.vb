Imports System.IO
Imports SamitCoreApi

Public Class DatabaseCreatorImpl
    Implements IDatabaseCreator

    ReadOnly DatabaseVersion As IDatabaseVersion
    ReadOnly GetModoCloud As IModoCloud
    ReadOnly ModelBuilder As IModelBuilder
    ReadOnly DatabaseObjects As IDatabaseObjects

    Public Sub New(_databaseObjects As IDatabaseObjects)
        DatabaseVersion = New DatabaseVersionImpl()
        GetModoCloud = New ModoCloudImpl()
        ModelBuilder = New ModelBuilderFromClass()
        DatabaseObjects = _databaseObjects
    End Sub

    Public Function CrearBaseDatosNueva(token As TokenData, baseDatos As SqlDatabase, Optional conParametrosIniciales As Boolean = False) As ApiResponse Implements IDatabaseCreator.CrearBaseDatosNueva
        Dim res = New ApiResponse

        If Not String.IsNullOrWhiteSpace(baseDatos.Nombre) Then
            If Not Database.ExisteBaseDatos(baseDatos.Nombre, token.Servidor) Then
                Dim ruta As String = ""
                Try
                    Dim conexMaster = New ConexionSQL(token.Servidor, "master")
                    If baseDatos.TipoBaseDatos <> DatabasesSamit.Seguridad Then
                        Dim ComandoRuta = conexMaster.SqlQuery($"SELECT name, filename FROM master..sysdatabases WHERE name LIKE '{token.BaseDatosSeguridad}'")
                        If ComandoRuta.Rows.Count > 0 Then
                            Dim RutaTrae = ComandoRuta.Rows(0).Item(1).ToString
                            Dim partes = RutaTrae.Split("\")
                            Array.Resize(partes, partes.Count - 1)
                            ruta = String.Join("\", partes) & "\"
                        End If
                    End If

                    Dim comandoCreaDB = GetComandoCreateDatabase(baseDatos, ruta)
                    conexMaster.SqlQuerySingle(comandoCreaDB)
                    conexMaster.CerrarConexion()

                    If Database.ExisteBaseDatos(baseDatos.Nombre, token.Servidor) Then
                        Dim esCloud = GetModoCloud.EsModoCloud(token.Instancia)
                        Dim creador = New DatabaseCreatorScriptsImpl(token, baseDatos.Nombre, baseDatos.TipoBaseDatos, _databaseObjects:=DatabaseObjects, esCloud:=esCloud)
                        creador.GenerarComandoCrearDB(esCloud:=esCloud)

                        Dim conexionActual = New ConexionSQL(token.Servidor, baseDatos.Nombre)
                        For Each comando In creador.ListadoComandosSQL
                            Dim resComando = conexionActual.SqlQuerySingle(comando, incluirDMY:=False)
                            If resComando <> "si" And resComando <> "no" Then
                                res.Estado = "ERROR"
                                res.AgregarDetalle(resComando)
                            End If
                        Next

                        'Inserta los datos de inicio en la tablas
                        'TODO: Mejorar la forma de pasar los parametros iniciales
                        'If conParametrosIniciales Then
                        '    Dim comandoParametrosIniciales = If(baseDatos.Nombre.Contains("GENERAL"), GetSqlParametrosInicialesGeneral(), GetSqlParametrosIniciales())
                        '    Dim resParametros = conexionActual.SqlQuerySingle(comandoParametrosIniciales, incluirDMY:=True)
                        '    If resParametros <> "si" And resParametros <> "no" Then
                        '        res.Estado = "ERROR"
                        '        res.AgregarDetalle(resParametros)
                        '    End If
                        'End If

                        conexionActual.CerrarConexion()

                        DatabaseVersion.GuardarVersionTodasTablas(token.Servidor, baseDatos.TipoBaseDatos, baseDatos.Nombre)

                        If res.Estado <> "ERROR" Then
                            res.Estado = "OK"
                        End If

                    Else
                        res.Estado = "ERROR"
                        res.AgregarDetalle("CrearBaseDatosNueva: No se logró verificar que la base de datos nueva se creara correctamente.")
                    End If

                Catch ex As Exception
                    res.Estado = "ERROR"
                    res.AgregarDetalle($"CrearBaseDatosNueva: error critico. {ex.Message}")
                End Try

                If res.Estado <> "OK" Then
                    BorrarBaseDatos(token.Servidor, baseDatos)
                    res.AgregarDetalle("La base datos nueva no se confirmo.")
                End If
            Else
                res.Estado = "OK"
                res.AgregarDetalle($"La base de datos '{baseDatos.Nombre}' ya existe en el servidor '{token.Servidor}'.")
            End If
        Else
            res.Estado = "ERROR"
            res.AgregarDetalle("CrearBaseDatosNueva: No se proporciono nombre de la nueva base de datos.")
        End If

        Return res
    End Function

    Public Function CrearBaseDatosAñoNueva(token As TokenData, empresa As Integer, año As Integer, conParametrosIniciales As Boolean) As ApiResponse Implements IDatabaseCreator.CrearBaseDatosAñoNueva
        Dim res = New ApiResponse

        Dim baseDatos As New SqlDatabase With {
            .Nombre = GetNombreBaseDatosAño(empresa, año),
            .TipoBaseDatos = DatabasesSamit.Año
        }

        Dim resCreaDB = CrearBaseDatosNueva(token, baseDatos, conParametrosIniciales)
        If resCreaDB.Estado = "OK" Then
            res.Estado = "OK"
        Else
            res = resCreaDB
        End If

        Return res
    End Function

    Public Function CrearBaseDatosGeneralNueva(token As TokenData, empresa As Integer, conParametrosIniciales As Boolean) As ApiResponse Implements IDatabaseCreator.CrearBaseDatosGeneralNueva
        Dim res = New ApiResponse

        Dim baseDatos As New SqlDatabase With {
            .Nombre = GetNombreBaseDatosGeneral(empresa),
            .TipoBaseDatos = DatabasesSamit.General
        }

        Dim resCreaDB = CrearBaseDatosNueva(token, baseDatos, conParametrosIniciales)
        If resCreaDB.Estado = "OK" Then
            res.Estado = "OK"
        Else
            res = resCreaDB
        End If

        Return res
    End Function

    Public Function ActualizarBaseDatosSiNecesario(token As TokenData, baseDatos As SqlDatabase, Optional revalidarCampos As Boolean = False, Optional EsCloud As Boolean = False) As ApiResponse Implements IDatabaseCreator.ActualizarBaseDatosSiNecesario
        Dim res As New ApiResponse

        If revalidarCampos Then
            DatabaseVersion.LimpiarTablaVersiones(token.Servidor, baseDatos.Nombre)
        End If

        Dim ListaTablas = GetListaTablasClases(baseDatos.TipoBaseDatos)
        ListaTablas = RemoveNoCloudTables(listaTablas:=ListaTablas, esCloud:=EsCloud, tipoDb:=baseDatos.TipoBaseDatos)
        Dim versiones = DatabaseVersion.GetListaVersiones(token.Servidor, baseDatos.Nombre)

        Dim cantActualizo = 0
        Dim conexionActual = New ConexionSQL(token.Servidor, baseDatos.Nombre)
        For Each tabla In ListaTablas
            Dim versionActual = -1
            Dim listaAct = versiones.Where(Function(v) v.Nombre = baseDatos.Nombre & "." & tabla.Nombre).ToList()
            If listaAct.Count > 0 Then
                versionActual = listaAct(0).Version
            End If
            If versionActual < tabla.Version Then
                cantActualizo += 1
                Dim creador = New DatabaseCreatorScriptsImpl(token, baseDatos.Nombre, baseDatos.TipoBaseDatos, tabla)
                creador.GenerarComandoActualizaDB(tabla)
                For Each comando In creador.ListadoComandosSQL
                    Dim resComando = conexionActual.SqlQuerySingle(comando, incluirDMY:=False)
                    If resComando <> "si" And resComando <> "no" Then
                        'res.Estado = "ERROR"
                        res.AgregarDetalle(resComando)
                    End If
                Next
                DatabaseVersion.GuardarVersionBaseDatos(token.Servidor, baseDatos.Nombre, tabla.Version, tabla.Nombre)
            End If
        Next

        'Intenta actualizar los objetos de la base de datos
        'Siempre se actualiza los procedimientos
        Dim creadorObjects = New DatabaseCreatorScriptsImpl(token, baseDatos.Nombre, baseDatos.TipoBaseDatos, _databaseObjects:=DatabaseObjects)
        creadorObjects.GenerarActualizarObjetosBaseDatos()
        For Each comando In creadorObjects.ListadoComandosSQL
            Dim resComando = conexionActual.SqlQuerySingle(comando, incluirDMY:=False)
            If resComando <> "si" And resComando <> "no" Then
                'res.Estado = "ERROR"
                res.AgregarDetalle(resComando)
            End If
        Next
        DatabaseVersion.GuardarVersionBaseDatos(token.Servidor, baseDatos.Nombre, 0, "DatabaseObjects")
        conexionActual.CerrarConexion()

        If revalidarCampos Then
            RehacerTodasLlavesForaneas(token, baseDatos)
        End If

        res.Estado = "OK"
        Return res
    End Function

    Private Sub RehacerTodasLlavesForaneas(token As TokenData, baseDatos As SqlDatabase)
        Dim res As New ApiResponse

        Dim ListaTablas = GetListaTablasClases(baseDatos.TipoBaseDatos)
        Dim conexionActual = New ConexionSQL(token.Servidor, baseDatos.Nombre)

        Dim comandoElimina =
            $"
                SELECT 'ALTER TABLE [' + X.table_name + '] DROP CONSTRAINT [' + X.foreign_key_name + '];' FROM 
                (
                SELECT   
                    f.name AS foreign_key_name  
                   ,OBJECT_NAME(f.parent_object_id) AS table_name  
                   ,COL_NAME(fc.parent_object_id, fc.parent_column_id) AS constraint_column_name  
                   ,OBJECT_NAME (f.referenced_object_id) AS referenced_object  
                   ,COL_NAME(fc.referenced_object_id, fc.referenced_column_id) AS referenced_column_name  
                   ,is_disabled  
                   ,delete_referential_action_desc  
                   ,update_referential_action_desc  
                FROM sys.foreign_keys AS f  
                INNER JOIN sys.foreign_key_columns AS fc   
                   ON f.object_id = fc.constraint_object_id   
                ) AS X
            "
        Dim tablaElimina = conexionActual.SqlQuery(comandoElimina)
        For Each filaElimina In tablaElimina.Rows
            conexionActual.SqlQuerySingle(filaElimina(0), incluirDMY:=False)
        Next

        For Each tabla In ListaTablas
            Dim creador = New DatabaseCreatorScriptsImpl(token, baseDatos.Nombre, baseDatos.TipoBaseDatos, tabla)
            creador.GenerarComandoActualizaLlavesForaneas(tabla)
            For Each comando In creador.ListadoComandosSQL
                Dim resComando = conexionActual.SqlQuerySingle(comando, incluirDMY:=False)
                If resComando <> "si" And resComando <> "no" Then
                    'res.Estado = "ERROR"
                    res.AgregarDetalle(resComando)
                End If
            Next
        Next

        conexionActual.CerrarConexion()
        res.Estado = "OK"
    End Sub

    Public Function ActualizaTablaBaseDatos(token As TokenData, baseDatos As SqlDatabase, NombreTabla As String) As ApiResponse Implements IDatabaseCreator.ActualizaTablaBaseDatos
        Dim res As New ApiResponse

        Dim conexionActual = New ConexionSQL(token.Servidor, baseDatos.Nombre)
        Dim cantActualizo = 0

        Try
            Dim ListaTablas = GetListaTablasClases(baseDatos.TipoBaseDatos)
            Dim versiones = DatabaseVersion.GetListaVersiones(token.Servidor, baseDatos.Nombre)
            If ListaTablas.Count > 0 Then
                Dim BusquedaTabla = ListaTablas.Where(Function(t) t.Nombre.ToLower() = NombreTabla.ToLower()).ToList()
                If BusquedaTabla.Count > 0 Then
                    Dim tabla = BusquedaTabla(0)
                    Dim versionActual = 0
                    Dim listaAct = versiones.Where(Function(v) v.Nombre = baseDatos.Nombre & "." & tabla.Nombre).ToList()
                    If listaAct.Count > 0 Then
                        versionActual = listaAct(0).Version
                    End If
                    If versionActual < tabla.Version Then
                        cantActualizo += 1
                        Dim creador = New DatabaseCreatorScriptsImpl(token, baseDatos.Nombre, baseDatos.TipoBaseDatos, tabla)
                        creador.GenerarComandoActualizaDB(tabla)
                        For Each comando In creador.ListadoComandosSQL
                            Dim resComando = conexionActual.SqlQuerySingle(comando, incluirDMY:=False)
                            If resComando <> "si" And resComando <> "no" Then
                                'res.Estado = "ERROR"
                                res.AgregarDetalle(resComando)
                            End If
                        Next
                        DatabaseVersion.GuardarVersionBaseDatos(token.Servidor, baseDatos.Nombre, tabla.Version, tabla.Nombre)
                    End If
                Else
                    res.Estado = "ERROR"
                    res.AgregarDetalle($"No se encontro la tabla {NombreTabla}")
                    Return res
                End If
            Else
                res.Estado = "ERROR"
                res.AgregarDetalle($"No se encontraron tablas")
                Return res
            End If
        Catch ex As Exception
            res.Estado = "ERROR"
            res.AgregarDetalle(ex.Message)
            Return res
        End Try

        'Intenta actualizar los objetos de la base de datos
        'Siempre se actualiza los procedimientos
        Dim creadorObjects = New DatabaseCreatorScriptsImpl(token, baseDatos.Nombre, baseDatos.TipoBaseDatos, _databaseObjects:=DatabaseObjects)
        creadorObjects.GenerarActualizarObjetosBaseDatos()
        For Each comando In creadorObjects.ListadoComandosSQL
            Dim resComando = conexionActual.SqlQuerySingle(comando, incluirDMY:=False)
            If resComando <> "si" And resComando <> "no" Then
                'res.Estado = "ERROR"
                res.AgregarDetalle(resComando)
            End If
        Next
        DatabaseVersion.GuardarVersionBaseDatos(token.Servidor, baseDatos.Nombre, 0, "DatabaseObjects")
        conexionActual.CerrarConexion()

        res.Estado = "OK"
        Return res
    End Function

    Private Function CrearEmpresaConBak(tempToken As TokenData, RutaBackup As String, NombreBaseDatosNueva As String) As ApiResponse
        Dim res As New ApiResponse
        Dim conexion = New ConexionSQL(tempToken.Servidor, tempToken.BaseDatosSeguridad)
        Dim SQL, Ruta As String

        If Not File.Exists(RutaBackup) Then
            res.Estado = "ERROR"
            res.AgregarDetalle($"No existe el Archivo de Backup {RutaBackup}")
        End If

        If res.Estado <> "ERROR" Then
            SQL = $"SELECT name, filename FROM master..sysdatabases WHERE name LIKE '{tempToken.BaseDatosAño}'"
            conexion.CambiarBaseDatos("master")
            Dim existe = conexion.SqlQuery(SQL)
            If existe.Rows.Count <= 0 Then
                res.Estado = "ERROR"
                res.AgregarDetalle($"No se encontro la base de datos")
                Return res
            End If

            If Not Database.ExisteBaseDatos(conexion, NombreBaseDatosNueva) Then
                Try
                    Ruta = existe(0)("FileName")
                    Ruta = Left(Ruta, InStr(1, Ruta, GetNombreBaseDatosAño(tempToken.Empresa, tempToken.FechaTrabajo.Year)) - 2)
                    Dim MiRutaCreaBd, MiRutaCrealog As String
                    Dim NomLogicoDat As String = ""
                    Dim NomLogicoLog As String = ""
                    MiRutaCreaBd = $"{Ruta}\{NombreBaseDatosNueva}.mdf"
                    MiRutaCrealog = $"{Ruta}\{NombreBaseDatosNueva}.ldf"

                    SQL = $"CREATE DATABASE {NombreBaseDatosNueva} ON" & vbCrLf &
                          $"(NAME = {NombreBaseDatosNueva}_dat, FILENAME = '{MiRutaCreaBd}')" & vbCrLf &
                           "LOG ON " & vbCrLf &
                          $"(NAME = {NombreBaseDatosNueva}_log, FILENAME = '{MiRutaCrealog}')"
                    Dim resCreaBaseDatos = conexion.SqlQuerySingle(SQL)
                    If resCreaBaseDatos = "si" Then
                        SQL = $"ALTER DATABASE {NombreBaseDatosNueva} COLLATE SQL_Latin1_General_CP1_CI_AS"
                        conexion.SqlQuerySingle(SQL)

                        Dim RestoreLog = conexion.SqlQuery($"RESTORE FILELISTONLY FROM DISK = '{RutaBackup}'")
                        For Each row As DataRow In RestoreLog.Rows
                            If row("Type") = "D" Then
                                NomLogicoDat = row("LogicalName")
                            End If
                            If row("Type") = "L" Then
                                NomLogicoLog = row("LogicalName")
                            End If
                        Next row

                        If RestoreLog.Rows.Count > 0 Then
                            SQL = $"RESTORE DATABASE {NombreBaseDatosNueva} FROM DISK = '{RutaBackup}'" & vbCrLf &
                              "WITH REPLACE, " & vbCrLf &
                              $"Move '{NomLogicoDat}' TO '{MiRutaCreaBd}'," & vbCrLf &
                              $"Move '{NomLogicoLog}' TO '{MiRutaCrealog}'"

                            Dim restoreRes = conexion.SqlQuerySingle(SQL)
                            If restoreRes = "si" Then
                                Dim version = conexion.SqlQuery("SELECT SERVERPROPERTY('productversion') as version")
                                If version.Rows.Count > 0 Then
                                    If Trim(Left(version(0)(0), InStr(1, version(0)(0), ".") - 1)) <> "8" Then
                                        SQL = $"ALTER DATABASE {NombreBaseDatosNueva} SET COMPATIBILITY_LEVEL = 80"
                                        conexion.SqlQuerySingle(SQL)
                                    End If
                                End If

                                conexion.CambiarBaseDatos(NombreBaseDatosNueva)
                                Dim BDActual = conexion.SqlQuery("select name, filename from sys.sysfiles ")
                                For Each row As DataRow In BDActual.Rows
                                    If UCase(Right(row("FileName"), 3)) = "MDF" Then
                                        SQL = $"ALTER DATABASE {NombreBaseDatosNueva} MODIFY FILE (NAME = '{row("name")}', NEWNAME = '{NombreBaseDatosNueva}_dat')"
                                    End If
                                    If UCase(Right(row("FileName"), 3)) = "LDF" Then
                                        SQL = $"ALTER DATABASE {NombreBaseDatosNueva} MODIFY FILE (NAME = '{row("name")}', NEWNAME = '{NombreBaseDatosNueva}_log')"
                                    End If
                                    Dim CambiaLogicalName = conexion.SqlQuerySingle(SQL)
                                Next row


                            Else
                                res.Estado = "ERROR"
                                res.AgregarDetalle($"No se pudo restaurar la base de datos para la empresa a crear {NombreBaseDatosNueva}: {restoreRes}")
                            End If
                        Else

                        End If
                    Else

                    End If

                Catch ex As Exception
                    res.Estado = "ERROR"
                    res.AgregarDetalle(ex.Message)
                End Try

                conexion.CerrarConexion()
            End If
        End If

        Return res
    End Function

    Private Function GetListaTablasClases(Optional database As DatabasesSamit = Nothing) As List(Of SqlTable)
        Return ModelBuilder.GetDatabaseModel(database)
    End Function

    Private Function GetComandoCreateDatabase(baseDatos As SqlDatabase, Optional RutaCrea As String = Nothing) As String
        Dim comando = ""

        If Not String.IsNullOrWhiteSpace(baseDatos.Nombre) Then
            comando += "CREATE DATABASE " & baseDatos.Nombre
            If Not String.IsNullOrWhiteSpace(RutaCrea) Then
                comando += $" ON (NAME = {baseDatos.Nombre}_dat,FILENAME = '{RutaCrea}\{baseDatos.Nombre}.mdf')
                            LOG ON 
                            (NAME = {baseDatos.Nombre}_log,FILENAME = '{RutaCrea}\{baseDatos.Nombre}.ldf' )"
            End If
        Else
            Throw New Exception("No se proporciono nombre de la base de datos.")
        End If

        Return comando
    End Function

    Private Sub BorrarBaseDatos(servidorSql As String, baseDatos As SqlDatabase)
        Dim conexMaster = New ConexionSQL(servidorSql, "master")
        Dim comandoBorraDB = $"
            ALTER DATABASE {baseDatos.Nombre} 
            SET SINGLE_USER 
            WITH ROLLBACK IMMEDIATE;

            DROP DATABASE {baseDatos.Nombre} 
        "
        conexMaster.SqlQuerySingle(comandoBorraDB)
        conexMaster.CerrarConexion()
    End Sub

End Class
