Imports System.ComponentModel
Imports System.IO
Imports System.Reflection
Imports System.Security.Claims
Imports System.Web.Script.Services
Imports System.Web.Services
Imports Newtonsoft.Json
Imports SamitCore
Imports SamitCoreApi
Imports SamitDatabase

<System.Web.Script.Services.ScriptService()>
<System.Web.Services.WebService(Namespace:="http://tempuri.org/")>
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.None)>
<ToolboxItem(False)>
Public Class Security
    Inherits System.Web.Services.WebService

    Public Function GetResourceTextByName(name As String) As String
        Dim res As String = Nothing
        Dim asem = Assembly.GetExecutingAssembly()
        Dim resourceName = asem.GetManifestResourceNames().Single(Function(str) str.EndsWith(name))
        If Not String.IsNullOrWhiteSpace(resourceName) Then
            Using stream As Stream = asem.GetManifestResourceStream(resourceName)
                Using reader As StreamReader = New StreamReader(stream, System.Text.Encoding.UTF8, False)
                    Dim result As String = reader.ReadToEnd()
                    'result = result.Replace("ï»¿", "")
                    res = result
                End Using
            End Using
        End If
        Return res
    End Function

    Private Function GetSqlSettings(token As TokenData) As SqlSettings
        Dim settings As New SqlSettings With
        {
            .Servidor = token.Servidor,
            .Usuario = token.Usuario,
            .Clave = token.Clave,
            .Database = New SqlDatabase With
            {
                .Nombre = token.BaseDatosNominaFull,
                .TipoBaseDatos = DatabasesSamit.NominaFull
            }
        }
        Return settings
    End Function

    Private Function ExisteBaseDatos(settings As SqlSettings)
        Return True
    End Function

    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Sub CreaOActualizaBaseDatos()
        Dim res As New ApiResponse

        Try
            Dim requestData = ApiHelper.AuthBearerRequestEmptyParams(Context)
            If requestData.AuthSuccess Then
                Dim data = requestData.Data
                Dim auth = requestData.Auth

                Dim settings = GetSqlSettings(auth.KeyToken)
                Dim existeDB = ExisteBaseDatos(settings)

                settings.Servidor = "LAPTOP-3JUTLUGJ\SAMIT"
                settings.Usuario = "sa"
                settings.Clave = "2121121512"
                Dim database = New DatabaseCreatorImpl(New DatabaseObjectsNomina)

                If existeDB Then
                    database.ActualizarBaseDatosSiNecesario(settings)

                    Dim tablas As String() = {
    "CAT_Bancos",
    "CAT_ClaseLicencia",
    "ClasConceptosNomina",
    "CAT_TipoContratos",
    "CAT_TiposId",
    "ConceptosNomina",
    "VariablesGenerales",
    "DetallesVariablesGenerales",
    "VariablesPersonales",
    "ZenumTipoEntes",
    "TiposConceptosNomina",
    "CAT_Parentesco",
    "CAT_NivelEducativo",
    "CAT_Genero",
    "CAT_EstadoCivil",
    "CAT_ClaseLibreta",
    "CAT_Profesiones",
    "G_Pais",
    "CT_PlandeCuentas",
    "G_Departamento",
    "G_Municipio",
    "CodigosDian"
}


                    Dim tpl As String = "
IF OBJECT_ID('dbo.{0}','U') IS NOT NULL
   AND NOT EXISTS(SELECT 1 FROM dbo.{0})
BEGIN
    {1}
END
"
                    Dim p As New ParametrosNomina()
                    Dim conexion = New ConexionSQL(settings.Servidor, settings.Database.Nombre)
                    For Each tabla As String In tablas

                        Dim accionSql As String
                        Select Case tabla
                            Case "CAT_Bancos"
                                accionSql = p.sqlBancos

                            Case "CAT_ClaseLicencia"
                                accionSql = p.sqlClaseLicencia

                            Case "ClasConceptosNomina"
                                accionSql = p.sqlClasConceptosNomina

                            Case "CAT_TipoContratos"
                                accionSql = p.sqlTipoContratos

                            Case "CAT_TiposId"
                                accionSql = p.sqlTiposId

                            Case "ConceptosNomina"
                                accionSql = p.sqlConceptosNomina

                            Case "VariablesGenerales"
                                accionSql = p.sqlVariablesGenerales

                            Case "VariablesPersonales"
                                accionSql = p.sqlVariablesPersonales

                            Case "ZenumTipoEntes"
                                accionSql = p.sqlZenumTipoEntes

                            Case "TiposConceptosNomina"
                                accionSql = p.sqlTiposConceptosNomina

                            Case "CAT_Parentesco"
                                accionSql = p.sqlCatParentesco

                            Case "CAT_NivelEducativo"
                                accionSql = p.sqlCatNivelEducativo

                            Case "CAT_Genero"
                                accionSql = p.sqlCatGenero

                            Case "CAT_EstadoCivil"
                                accionSql = p.sqlCatEstadoCivil

                            Case "CAT_ClaseLibreta"
                                accionSql = p.sqlCatClaseLibreta

                            Case "G_Pais"
                                accionSql = p.sqlGPais

                            Case "CT_PlandeCuentas"
                                accionSql = p.sqlCt_Plandecuentas

                            Case "G_Municipio"
                                accionSql = p.sqlGMunicipio

                            Case "G_Departamento"
                                accionSql = p.sqlG_Departamento

                            Case "CAT_Profesiones"
                                accionSql = p.sqlProfesiones

                            Case "CodigosDian"
                                accionSql = p.sqlCodigosDian

                            Case Else
                                accionSql = "-- No hay definición de SQL para " & tabla
                        End Select

                        'If accionSql = p.sqlCatGenero Then
                        '    Dim algo = ""
                        'End If


                        Dim sqlToRun As String = String.Format(tpl, tabla, accionSql)
                        Dim resinserts = conexion.SqlQuerySingleRows(sqlToRun)
                    Next
                    conexion.CerrarConexion()
                Else
                    Dim resbd = database.CrearBaseDatosNueva(settings)

                    Dim conexion = New ConexionSQL(settings.Servidor, settings.Database.Nombre)
                    Dim tabla = conexion.SqlQuery("SELECT COUNT(*) AS TotalTablas,CASE WHEN COUNT(*) > 0 THEN 'Tiene tablas' ELSE 'No tiene tablas' END AS Estado FROM sys.tables;")
                    If tabla.Rows(0)(1).ToString.Contains("No") Then
                        database.ActualizarBaseDatosSiNecesario(settings)
                    End If

                    Dim tablas As String() = {
    "CAT_Bancos",
    "CAT_ClaseLicencia",
    "ClasConceptosNomina",
    "CAT_TipoContratos",
    "CAT_TiposId",
    "ConceptosNomina",
    "VariablesGenerales",
    "DetallesVariablesGenerales",
    "VariablesPersonales",
    "ZenumTipoEntes",
    "TiposConceptosNomina",
    "CAT_Parentesco",
    "CAT_NivelEducativo",
    "CAT_Genero",
    "CAT_EstadoCivil",
    "CAT_ClaseLibreta",
    "CAT_Profesiones",
    "G_Pais",
    "CT_PlandeCuentas",
    "G_Departamento",
    "G_Municipio",
    "CodigosDian"
}


                    Dim tpl As String = "
IF OBJECT_ID('dbo.{0}','U') IS NOT NULL
   AND NOT EXISTS(SELECT 1 FROM dbo.{0})
BEGIN
    {1}
END
"
                    Dim p As New ParametrosNomina()
                    For Each tabl As String In tablas

                        Dim accionSql As String
                        Select Case tabl
                            Case "CAT_Bancos"
                                accionSql = p.sqlBancos

                            Case "CAT_ClaseLicencia"
                                accionSql = p.sqlClaseLicencia

                            Case "ClasConceptosNomina"
                                accionSql = p.sqlClasConceptosNomina

                            Case "CAT_TipoContratos"
                                accionSql = p.sqlTipoContratos

                            Case "CAT_TiposId"
                                accionSql = p.sqlTiposId

                            Case "ConceptosNomina"
                                accionSql = p.sqlConceptosNomina

                            Case "VariablesGenerales"
                                accionSql = p.sqlVariablesGenerales

                            Case "VariablesPersonales"
                                accionSql = p.sqlVariablesPersonales

                            Case "ZenumTipoEntes"
                                accionSql = p.sqlZenumTipoEntes

                            Case "TiposConceptosNomina"
                                accionSql = p.sqlTiposConceptosNomina

                            Case "CAT_Parentesco"
                                accionSql = p.sqlCatParentesco

                            Case "CAT_NivelEducativo"
                                accionSql = p.sqlCatNivelEducativo

                            Case "CAT_Genero"
                                accionSql = p.sqlCatGenero

                            Case "CAT_EstadoCivil"
                                accionSql = p.sqlCatEstadoCivil

                            Case "CAT_ClaseLibreta"
                                accionSql = p.sqlCatClaseLibreta

                            Case "CAT_Profesiones"
                                accionSql = p.sqlProfesiones

                            Case "G_Pais"
                                accionSql = p.sqlGPais

                            Case "CT_PlandeCuentas"
                                accionSql = p.sqlCt_Plandecuentas

                            Case "G_Municipio"
                                accionSql = p.sqlGMunicipio

                            Case "G_Departamento"
                                accionSql = p.sqlG_Departamento

                            Case "CodigosDian"
                                accionSql = p.sqlCodigosDian


                            Case Else
                                accionSql = "-- No hay definición de SQL para " & tabl
                        End Select


                        Dim sqlToRun As String = String.Format(tpl, tabla, accionSql)

                        Dim resinserts = conexion.SqlQuerySingleRows(sqlToRun)

                    Next
                    conexion.CerrarConexion()
                    'Dim Parametros = GetResourceTextByName("parametrosIniciales.sql")
                    ' Ejecuta el comando
                End If

                res.Estado = "OK"
            Else
                res = requestData.Auth.Resultado
            End If
        Catch ex As Exception
            res.Estado = "ERROR"
            res.AgregarDetalle("INTERNAL: " & ex.Message)
        End Try

        ApiHelper.WriteResponse(Context, JsonConvert.SerializeObject(res))
    End Sub

    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Sub GetParametrosUsuario()
        Dim paramsDefinition = New With {
            .servidor = "",
            .sqlInstancia = "",
            .terminal = "",
            .sysuser = ""
        }
        Dim res As New ApiResponse

        'UpdateDatabase()

        Try
            Dim requestData = ApiHelper.AuthBasicRequestWithParams(Context, paramsDefinition)
            If requestData.AuthSuccess Then
                Dim auth = requestData.Auth
                Dim data = requestData.Data

                Dim samitApi As New SamitApiHelper
                Dim resApi = samitApi.GetParametrosUsuario(
                    usuario:=auth.KeyUser.Usuario,
                    clave:=auth.KeyUser.Clave,
                    servidor:=data.servidor,
                    sqlInstance:=data.sqlInstancia,
                    terminal:=data.terminal,
                    sysuser:=data.sysuser
                )

                res.Estado = resApi.Estado
                res.Detalle.AddRange(resApi.Detalle)
                res.ObjetoRes = resApi.ObjetoRes
            End If
        Catch ex As Exception
            res.Estado = "ERROR"
            res.AgregarDetalle("INTERNAL: " & ex.Message)
        End Try

        ApiHelper.WriteResponse(Context, JsonConvert.SerializeObject(res))
    End Sub

    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Sub GetToken()
        Dim res As New ApiResponse

        Try
            Dim requestData = ApiHelper.AuthBasicRequestWithParams(Of SamitCore.RequestToken)(Context)
            If requestData.AuthSuccess Then
                Dim auth = requestData.Auth
                Dim data = requestData.Data

                Dim samitApi As New SamitApiHelper
                Dim resApi = samitApi.AutenticarConServidor(
                    usuario:=auth.KeyUser.Usuario,
                    clave:=auth.KeyUser.Clave,
                    datosSesion:=data
                )

                res.Estado = resApi.Estado
                res.Detalle.AddRange(resApi.Detalle)
                res.ObjetoRes = resApi.ObjetoRes
            End If
        Catch ex As Exception
            res.Estado = "ERROR"
            res.AgregarDetalle("INTERNAL: " & ex.Message)
        End Try

        ApiHelper.WriteResponse(Context, JsonConvert.SerializeObject(res))
    End Sub

End Class