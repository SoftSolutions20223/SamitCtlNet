Imports SamitCoreApi

Public Class DatabaseCreatorScriptsImpl
    Implements IDatabaseCreatorScripts

    Public Property Token As TokenData
    Public Property NombreBaseDatos As String
    Public Property TipoBaseDatos As DatabasesSamit

    Public Property ListadoComandosSQL As New List(Of String)
    Public Property ListaTablas As New List(Of SqlTable)
    Public Property ListaTablasBaseDatos As New List(Of SqlTable)

    Dim consecutivoConstarint = 0

    ReadOnly ModelBuilder As IModelBuilder
    ReadOnly ModelBuilderSqlEngine As IModelBuilder
    ReadOnly DatabaseObjects As IDatabaseObjects

    Public Sub New(tokenData As TokenData, baseDatos As String, tipo As DatabasesSamit, _databaseObjects As IDatabaseObjects, Optional tabla As SqlTable = Nothing, Optional esCloud As Boolean = False)
        Dim conexion As New ConexionSQL(tokenData.Servidor, baseDatos)

        ModelBuilder = New ModelBuilderFromClass()
        ModelBuilderSqlEngine = New ModelBuilderFromSqlEngine(_conexion:=conexion)
        DatabaseObjects = _databaseObjects

        Token = tokenData
        NombreBaseDatos = baseDatos
        TipoBaseDatos = tipo
        If IsNothing(tabla) Then
            ListaTablas = ModelBuilder.GetDatabaseModel(TipoBaseDatos)
            ListaTablas = RemoveNoCloudTables(listaTablas:=ListaTablas, esCloud:=esCloud, tipoDb:=tipo)
        Else
            ListaTablas = {tabla}.ToList()
        End If
    End Sub

    Public Sub GenerarComandoCrearDB(Optional esCloud As Boolean = False) Implements IDatabaseCreatorScripts.GenerarComandoCrearDB
        ListaTablasBaseDatos = ListaTablas
        For Each tabla As SqlTable In ListaTablas
            GenerarComandoCreaTabla(tabla)
        Next
        'Crear las llaves foraneas de las tablas
        For Each tabla As SqlTable In ListaTablas
            If ListaTablasBaseDatos.Where(Function(t) t.Nombre.ToLower() = tabla.Nombre.ToLower()).Count > 0 Then
                GenerarComandoActualizaLlavesForaneas(tabla:=tabla, esCloud:=esCloud)
            End If
        Next
        'Crear los indices personalizados de las tablas
        For Each tabla As SqlTable In ListaTablas
            GenerarComandoActualizaIndices(tabla)
        Next
        GenerarActualizarObjetosBaseDatos()
    End Sub

    Public Sub GenerarComandoActualizaDB(Optional tablaOp As SqlTable = Nothing) Implements IDatabaseCreatorScripts.GenerarComandoActualizaDB
        ListaTablasBaseDatos = ModelBuilderSqlEngine.GetDatabaseModel(TipoBaseDatos, tablaOp)

        'Agrega comandos adicionales a ejecutar en la base de datos o tabla individual
        ListadoComandosSQL.AddRange(GetComandosAdicionalesActualizaDb())
        If Not IsNothing(tablaOp) Then
            ListadoComandosSQL.AddRange(GetComandosAdicionalesActualizaTabla(tabla:=tablaOp))
        End If

        'Actualizar las tablas de la base de datos
        For Each tabla As SqlTable In ListaTablas
            If ListaTablasBaseDatos.Where(Function(t) t.Nombre.ToLower() = tabla.Nombre.ToLower()).Count > 0 Then
                GenerarComandoActualizaTabla(tabla)
            Else
                GenerarComandoCreaTabla(tabla)
            End If
        Next

        'Crear las llaves primarias de las tablas
        For Each tabla As SqlTable In ListaTablas
            Dim pasarTabla = True
            If Not Token.ManejaActivos And tabla.Nombre.ToUpper().StartsWith("AC") Then
                pasarTabla = False
            End If
            If pasarTabla Then
                If ListaTablasBaseDatos.Where(Function(t) t.Nombre.ToLower() = tabla.Nombre.ToLower()).Count > 0 Then
                    GenerarComandoActualizaLlavesPrimarias(tabla)
                End If
            End If
        Next

        'Crear las llaves foraneas de las tablas
        For Each tabla As SqlTable In ListaTablas
            Dim pasarTabla = True
            If Not Token.ManejaActivos And tabla.Nombre.ToUpper().StartsWith("AC") Then
                pasarTabla = False
            End If
            If pasarTabla Then
                If ListaTablasBaseDatos.Where(Function(t) t.Nombre.ToLower() = tabla.Nombre.ToLower()).Count > 0 Then
                    GenerarComandoActualizaLlavesForaneas(tabla)
                End If
            End If
        Next

        'Crear los contraint unicos de las tablas
        For Each tabla As SqlTable In ListaTablas
            GenerarComandoActualizaConstraints(tabla)
        Next

        'Crear los indices personalizados de las tablas
        For Each tabla As SqlTable In ListaTablas
            GenerarComandoActualizaIndices(tabla)
        Next

        'Actualiza los procedimientos almacenados, funciones, desencadenadores y vistas
        If IsNothing(tablaOp) Then
            GenerarActualizarObjetosBaseDatos()
        End If
    End Sub

    Private Sub GenerarComandoCreaTabla(tabla As SqlTable)
        Dim comando = GetComandoCreateTable(tabla)
        ListadoComandosSQL.Add(comando)
    End Sub

    Private Sub GenerarComandoActualizaTabla(tabla As SqlTable)
        Dim pasarTabla = True
        If Not Token.ManejaActivos And tabla.Nombre.ToUpper().StartsWith("AC") Then
            pasarTabla = False
        End If
        If pasarTabla Then
            Dim tablaBaseDatos As SqlTable = ListaTablasBaseDatos.First(Function(t) t.Nombre.ToLower() = tabla.Nombre.ToLower())

            If Not IsNothing(tablaBaseDatos) Then
                If tabla.ListaColumnas.Where(Function(c) c.LlavePrimaria).Count <> tablaBaseDatos.ListaColumnas.Where(Function(c) c.LlavePrimaria).Count Then
                    ListadoComandosSQL.Insert(0,
                        $"
                		    declare @sql nvarchar(max) = (
						        select 
                                    'alter table ' + quotename(object_name(kc.parent_object_id)) +
                                        'drop constraint '+ quotename(object_name(kc.object_id)) + ';'
                                from sys.key_constraints kc
                                inner join sys.objects o
                                on kc.parent_object_id = o.object_id
                                where kc.type = 'PK' and o.type = 'U'
	                            and o.name = '{tabla.Nombre}'
                                and o.name not in ('dtproperties','sysdiagrams')  -- not true user tables
                                order by QUOTENAME(OBJECT_SCHEMA_NAME(kc.parent_object_id))
    		                            ,QUOTENAME(OBJECT_NAME(kc.parent_object_id))
                                            for xml path('')
                            );
                            exec sp_executesql @sql;
                        "
                 )
                End If
            End If

            For Each columna As SqlColumn In tabla.ListaColumnas
                Dim columnaBaseDatos As SqlColumn = Nothing
                Try
                    columnaBaseDatos = tablaBaseDatos.ListaColumnas.First(Function(c) c.Nombre.ToLower() = columna.Nombre.ToLower())
                Catch ex As Exception
                End Try
                If IsNothing(columnaBaseDatos) Then
                    'Si la columna no esta en la base de datos, la creamos
                    GenerarComandoCreaColumna(columna, tabla)
                Else
                    'Si la columna ya se encuentra, la modificamos
                    GenerarComandoActualizaColumna(columna, tabla, columnaBaseDatos)
                End If
            Next
        End If
    End Sub

    Private Sub GenerarComandoCreaColumna(columna As SqlColumn, tabla As SqlTable)
        Dim tipoColumna = columna.GetTipoColumna(False)

        Dim comando As String =
            "
                ALTER TABLE [" & tabla.Nombre & "] 
                ADD [" & columna.Nombre & "] "
        If Not String.IsNullOrWhiteSpace(columna.ColumnaCalculada) Then
            comando += " AS " & columna.ColumnaCalculada
        Else
            comando += tipoColumna
        End If

        'If columna.Unique Then
        '    comando += " UNIQUE "
        'End If
        comando += ";"
        ListadoComandosSQL.Add(comando)

        If Not IsNothing(columna.ValorDefecto) Then
            Dim comandoActualizar As String =
            "
                UPDATE [" & tabla.Nombre & "] 
                SET [" & columna.Nombre & "] = '" & columna.ValorDefecto & "'
                WHERE [" & columna.Nombre & "] IS NULL;"

            ListadoComandosSQL.Add(comandoActualizar)
        End If

    End Sub

    Private Sub GenerarComandoActualizaColumna(columna As SqlColumn, tabla As SqlTable, columnaBaseDatos As SqlColumn)
        Dim tipoColumna = columna.GetTipoColumna(True)

        If ((columna.LargoColumna <> 0) And (columna.LargoColumna <> columnaBaseDatos.LargoColumna)) Or
            (columna.AceptaNull <> columnaBaseDatos.AceptaNull) Or
            (IsNothing(columna.ValorDefecto) <> IsNothing(columnaBaseDatos.ValorDefecto)) Then


            If Not IsNothing(columnaBaseDatos.ValorDefecto) Or Not IsNothing(columna.ValorDefecto) Then
                'Borrar los valores por defecto
                Dim comandoBorraDefault = GenerarComandoBorrarDefaultConstraintTablaColumna(tabla.Nombre, columna.Nombre, consecutivoConstarint)
                consecutivoConstarint += 1
                ListadoComandosSQL.Add(comandoBorraDefault)

                If columna.TipoDato = columnaBaseDatos.TipoDato Then
                    Dim textoDefecto = GetTextoValorDefectoColumna(columna)
                    Dim comandoUpdateDefault =
                                $"
                                    UPDATE {tabla.Nombre} 
                                    SET {columna.Nombre} = {textoDefecto} 
                                    WHERE {columna.Nombre} IS NULL;
                                "
                    ListadoComandosSQL.Add(comandoUpdateDefault)
                End If

            End If

            'Si la columna esta marcada como IDENTITY no se puede modificar
            If Not columna.Identity Then
                Dim comandoAlterColumn As String =
                    "
                        ALTER TABLE [" & tabla.Nombre & "] 
                        ALTER COLUMN [" & columna.Nombre & "] " & tipoColumna & ";
                    "
                ListadoComandosSQL.Add(comandoAlterColumn)
            End If

            If Not IsNothing(columna.ValorDefecto) Then
                'Vuelve y agrega los valores por defecto
                Dim textoDefecto = GetTextoValorDefectoColumna(columna)
                Dim comandoDefault =
                        $"
                            ALTER TABLE [{tabla.Nombre}] 
                            ADD CONSTRAINT DF_{tabla.Nombre}_{columna.Nombre}
                            DEFAULT ({textoDefecto}) FOR [{columna.Nombre}];
                        "
                ListadoComandosSQL.Add(comandoDefault)
            End If

        End If
    End Sub

    Private Function GetTextoValorDefectoColumna(columna As SqlColumn) As String
        Dim textoDefecto = ""
        If columna.ValorDefectoIsExpression Then
            textoDefecto = columna.ValorDefecto
        Else
            textoDefecto = $"'{columna.ValorDefecto}'"
        End If
        Return textoDefecto
    End Function

    Private Sub GenerarComandoActualizaLlavesPrimarias(tabla As SqlTable)
        Dim llavesPrimarias = tabla.ListaColumnas.Where(Function(c) c.LlavePrimaria = True).ToList()
        Dim comando = ""
        If llavesPrimarias.Count > 0 Then
            comando +=
                        "
                            ALTER TABLE [" & tabla.Nombre & "] 
                            ADD CONSTRAINT [PKA_" & tabla.Nombre & "] PRIMARY KEY CLUSTERED ( "
            For Each campo As SqlColumn In llavesPrimarias
                comando += vbCrLf & vbTab & vbTab & "[" & campo.Nombre & "] ASC"
                If llavesPrimarias.IndexOf(campo) < llavesPrimarias.Count - 1 Then
                    comando += ", "
                End If
            Next
            comando += vbCrLf & vbTab & ")"
            ListadoComandosSQL.Add(comando)
        End If
    End Sub

    Public Sub GenerarComandoActualizaLlavesForaneas(tabla As SqlTable, Optional esCloud As Boolean = False) Implements IDatabaseCreatorScripts.GenerarComandoActualizaLlavesForaneas
        For Each columna In tabla.ListaColumnas
            If Not String.IsNullOrWhiteSpace(columna.ForaneaTabla) AndAlso Not String.IsNullOrWhiteSpace(columna.ForaneaColumna) Then
                Dim valido = True
                Dim tablaBaseDatos As SqlTable = Nothing
                Try
                    tablaBaseDatos = ListaTablasBaseDatos.First(Function(t) t.Nombre.ToLower() = columna.ForaneaTabla.ToLower())
                Catch ex As Exception
                End Try
                Dim columnaBaseDatos As SqlColumn = Nothing

                If Not IsNothing(tablaBaseDatos) Then
                    If tablaBaseDatos.ListaColumnas.Where(Function(c) c.LlavePrimaria).Count > 1 Then
                        valido = False
                    End If
                    Try
                        columnaBaseDatos = tablaBaseDatos.ListaColumnas.First(Function(c) c.Nombre.ToLower() = columna.ForaneaColumna.ToLower())
                    Catch ex As Exception
                    End Try
                End If

                If Not IsNothing(columnaBaseDatos) Then
                    If columna.TipoDato <> columnaBaseDatos.TipoDato Then
                        valido = False
                    End If
                End If

                If Not esCloud AndAlso (columna.ForaneaTabla = "ClienteSamit" OrElse columna.ForaneaTabla = "UsuariosClienteSamit") Then
                    valido = False
                End If

                If valido Then
                    Dim alterForeign As String =
                     $"
                            ALTER TABLE [{tabla.Nombre}] 
                            ADD CONSTRAINT [FK_{tabla.Nombre}_{columna.ForaneaTabla}_{columna.Nombre}]
                            FOREIGN KEY([{columna.Nombre}]) REFERENCES [{columna.ForaneaTabla}]([{columna.ForaneaColumna}]); 
                        "
                    ListadoComandosSQL.Add(alterForeign)
                End If
            End If
        Next
    End Sub

    Private Sub GenerarComandoActualizaConstraints(tabla As SqlTable)
        Dim cantUnique = tabla.ListaColumnas.Where(Function(c) c.Unique = True).Count()
        If cantUnique > 0 Then
            Dim columnasUnique = ""
            Dim listaUnique = tabla.ListaColumnas.Where(Function(c) c.Unique = True).ToList()
            For Each campo As SqlColumn In listaUnique
                columnasUnique += "[" & campo.Nombre & "]"
                If listaUnique.IndexOf(campo) < listaUnique.Count - 1 Then
                    columnasUnique += ", "
                End If
            Next
            Dim alterUnique As String = $"
                ALTER TABLE {tabla.Nombre} 
                ADD CONSTRAINT [UC_{tabla.Nombre}]
                UNIQUE ({columnasUnique}); 
            "
            ListadoComandosSQL.Add(alterUnique)
        End If
    End Sub

    Private Sub GenerarComandoActualizaIndices(tabla As SqlTable)
        If Not IsNothing(tabla.ListaIndices) Then
            For Each indice In tabla.ListaIndices
                Dim columnasIndice = ""
                If Not IsNothing(indice.Columnas) Then
                    For Each columna In indice.Columnas
                        Dim nombreColumna = ""
                        Dim ordenColumna = "ASC"
                        If columna.Contains("|") Then
                            Dim parametros = columna.Split("|")
                            nombreColumna = parametros(0)
                            If parametros.Length > 1 Then
                                ordenColumna = parametros(1)
                            End If
                        Else
                            nombreColumna = columna
                        End If
                        columnasIndice += $"[{nombreColumna}] {ordenColumna}"
                        columnasIndice += ","
                    Next
                    columnasIndice = columnasIndice.Trim(",")
                End If

                Dim columnasIndiceInclude = ""
                If Not IsNothing(indice.ColumnasInclude) Then
                    For Each columna In indice.ColumnasInclude
                        Dim nombreColumna = columna
                        columnasIndiceInclude += $"[{nombreColumna}]"
                        columnasIndiceInclude += ","
                    Next
                    columnasIndiceInclude = columnasIndiceInclude.Trim(",")
                End If

                If Not String.IsNullOrWhiteSpace(columnasIndice) And Not String.IsNullOrWhiteSpace(indice.Nombre) Then
                    Dim definicionClustered = If(indice.TipoIndex = IndexType.Clustered, "CLUSTERED", "NONCLUSTERED")
                    Dim definicionUnique = If(indice.Unique, "UNIQUE", "")
                    Dim definicionInclude = If(Not String.IsNullOrWhiteSpace(columnasIndiceInclude), $"INCLUDE({columnasIndiceInclude})", "")

                    Dim createIndex As String = $"
                            CREATE {definicionUnique} {definicionClustered} INDEX [{indice.Nombre}] ON [{tabla.Esquema}].[{tabla.Nombre}]
                            (
                                {columnasIndice}
                            ) {definicionInclude} ON [PRIMARY]
                        "
                    ListadoComandosSQL.Add(createIndex)
                End If
            Next
        End If
    End Sub

    Public Sub GenerarActualizarObjetosBaseDatos() Implements IDatabaseCreatorScripts.GenerarActualizarObjetosBaseDatos
        Dim scripts = DatabaseObjects.GetDatabaseObjectsScripts(tipoBaseDatos:=TipoBaseDatos)

        InternalGenerateObjet(scripts.Vistas)
        InternalGenerateObjet(scripts.Funciones)
        InternalGenerateObjet(scripts.Procedimientos)
        InternalGenerateObjet(scripts.Desencadenadores)
    End Sub

    Private Sub InternalGenerateObjet(listaObjetos As List(Of SqlScript))
        For Each objeto In listaObjetos
            If Not String.IsNullOrWhiteSpace(objeto.Nombre) Then
                Dim comandoElimina As String = ""
                comandoElimina += "IF (SELECT COUNT(*) FROM sysobjects WHERE (name = '" & objeto.Nombre & "')) > 0" & vbCrLf
                comandoElimina += "    DROP " & objeto.Tipo & " [dbo].[" & objeto.Nombre & "]"
                ListadoComandosSQL.Add(comandoElimina)

                Dim comandoCrea = objeto.Data.Replace("[TipoAccion]", "CREATE ")
                ListadoComandosSQL.Add(comandoCrea)
            End If
        Next
    End Sub


    Public Function GetComandoCreateTable(tabla As SqlTable) As String
        Dim comando = ""

        If Not String.IsNullOrWhiteSpace(tabla.Nombre) Then
            Dim cantUnique = tabla.ListaColumnas.Where(Function(c) c.Unique = True).Count()
            comando += "CREATE TABLE [" & tabla.Esquema & "].[" & tabla.Nombre & "] ( "
            For Each campo As SqlColumn In tabla.ListaColumnas
                Dim tipoColumna = campo.GetTipoColumna(False)
                comando += vbCrLf & vbTab & "[" & campo.Nombre & "] "
                If Not String.IsNullOrWhiteSpace(campo.ColumnaCalculada) Then
                    comando += " AS " & campo.ColumnaCalculada
                Else
                    comando += tipoColumna
                End If
                If campo.Unique Then
                    If cantUnique = 1 Then
                        comando += " UNIQUE "
                    End If
                End If
                If tabla.ListaColumnas.IndexOf(campo) < tabla.ListaColumnas.Count - 1 Then
                    comando += ", "
                End If
            Next

            If cantUnique > 1 Then
                Dim listaUnique = tabla.ListaColumnas.Where(Function(c) c.Unique = True).ToList()
                comando += ", " & vbCrLf & vbTab & "CONSTRAINT [UC_" & tabla.Nombre & "] UNIQUE ( "
                For Each campo As SqlColumn In listaUnique
                    comando += "[" & campo.Nombre & "]"
                    If listaUnique.IndexOf(campo) < listaUnique.Count - 1 Then
                        comando += ", "
                    End If
                Next
                comando += ")"
            End If

            Dim llavesPrimarias = tabla.ListaColumnas.Where(Function(c) c.LlavePrimaria = True).ToList()
            If llavesPrimarias.Count > 0 Then
                comando += ", " & vbCrLf & vbTab & "CONSTRAINT [PKA_" & tabla.Nombre & "] PRIMARY KEY CLUSTERED ( "
                For Each campo As SqlColumn In llavesPrimarias
                    comando += vbCrLf & vbTab & vbTab & "[" & campo.Nombre & "] ASC"
                    If llavesPrimarias.IndexOf(campo) < llavesPrimarias.Count - 1 Then
                        comando += ", "
                    End If
                Next
                comando += vbCrLf & vbTab & ") WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) "
            End If
            comando += vbCrLf & ");"
        Else
            Throw New Exception("No se proporciono nombre de la tabla.")
        End If

        Return comando
    End Function

    Public Function GenerarComandoBorrarDefaultConstraintTablaColumna(nombreTabla As String, nombreColumna As String, consecutivo As Integer) As String
        Dim comando =
            "
                DECLARE @ConstraintName_" & consecutivo & " nvarchar(200)
                SELECT 
	                @ConstraintName_" & consecutivo & " = sys.default_constraints.name
                FROM sys.all_columns 
	                INNER JOIN sys.tables ON sys.all_columns.object_id = sys.tables.object_id 
	                INNER JOIN sys.schemas ON sys.tables.schema_id = sys.schemas.schema_id 
	                INNER JOIN sys.default_constraints ON sys.all_columns.default_object_id = sys.default_constraints.object_id
                WHERE
	                (sys.schemas.name = 'dbo') AND 
	                (sys.tables.name = '{0}') AND 
	                (sys.all_columns.name = '{1}') AND 
	                (sys.default_constraints.type = 'D')

                IF @ConstraintName_" & consecutivo & " IS NOT NULL 
	                EXEC('ALTER TABLE {0} DROP CONSTRAINT ' + @ConstraintName_" & consecutivo & ")
            "
        comando = String.Format(comando, nombreTabla, nombreColumna)
        Return comando
    End Function

End Class
