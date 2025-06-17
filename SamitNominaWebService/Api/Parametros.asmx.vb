Imports System.ComponentModel
Imports System.Web.Script.Services
Imports System.Web.Services
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports SamitCoreApi
Imports SamitDatabase

<System.Web.Script.Services.ScriptService()>
<System.Web.Services.WebService(Namespace:="http://tempuri.org/")>
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.None)>
<ToolboxItem(False)>
Public Class Parametros
    Inherits System.Web.Services.WebService

    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Sub SqlGet()
        Dim paramsDefinition = New With {
            .sql = ""
        }
        Dim res As New ApiResponse

        Try

            Dim requestData = ApiHelper.AuthBearerRequestWithParams(Context, paramsDefinition)
            If requestData.AuthSuccess Then
                Dim data = requestData.Data
                Dim auth = requestData.Auth

                Dim token = auth.KeyToken
                token.Servidor = "LAPTOP-3JUTLUGJ\SAMIT"
                Dim conexion = New ConexionSQL(token.Servidor, token.BaseDatosNominaFull)
                Dim tabla = conexion.SqlQuery(requestData.Data.sql)
                conexion.CerrarConexion()
                If Not IsNothing(tabla) Then
                    If tabla.Rows.Count <= 0 Then
                        tabla.Columns.Add("NoContieneDatos", GetType(String))
                        Dim fila As DataRow = tabla.NewRow()
                        fila("NoContieneDatos") = "No"
                        tabla.Rows.Add(fila)
                    End If
                End If

                res.ObjetoRes = tabla
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
    Public Sub SqlGetMultiple()
        Dim paramsDefinition = New With {
        .sqlQueries = New String() {}  ' Array de consultas SQL
    }
        Dim res As New ApiResponse
        Try
            Dim requestData = ApiHelper.AuthBearerRequestWithParams(Context, paramsDefinition)
            If requestData.AuthSuccess Then
                Dim data = requestData.Data
                Dim auth = requestData.Auth
                Dim token = auth.KeyToken
                token.Servidor = "LAPTOP-3JUTLUGJ\SAMIT"

                Dim conexion = New ConexionSQL(token.Servidor, token.BaseDatosNominaFull)
                Dim ServParams As New ServiceParametros
                Dim dataset = ServParams.CallDatasets(token, requestData.Data.sqlQueries)

                ' Procesar cada tabla del dataset
                If Not IsNothing(dataset) Then
                    For Each tabla As DataTable In dataset.Tables
                        If tabla.Rows.Count <= 0 Then
                            tabla.Columns.Add("NoContieneDatos", GetType(String))
                            Dim fila As DataRow = tabla.NewRow()
                            fila("NoContieneDatos") = "No"
                            tabla.Rows.Add(fila)
                        End If
                    Next
                End If

                res.ObjetoRes = dataset
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
    Public Sub SqlProcedures()
        Dim paramsDefinition = New With {
                .Procedimiento = "",
                .Datos = New JObject
            }
        Dim res As New ApiResponse

        Try

            Dim requestData = ApiHelper.AuthBearerRequestWithParams(Context, paramsDefinition)
            If requestData.AuthSuccess Then
                Dim data = requestData.Data
                Dim auth = requestData.Auth

                Dim token = auth.KeyToken
                token.Servidor = "LAPTOP-3JUTLUGJ\SAMIT"
                Dim conexion = New ConexionSQL(token.Servidor, token.BaseDatosNominaFull)
                Dim ServParams As New ServiceParametros
                Dim resUpsert = ServParams.CallProcedures(token, data.Datos, data.Procedimiento)
                conexion.CerrarConexion()

                res.ObjetoRes = resUpsert
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
    Public Sub PostParametros()

        Dim paramsDefinition = New With {
            .Tabla = "",
            .Datos = New JArray
        }
        Dim res As New ApiResponse

        Try

            Dim requestData = ApiHelper.AuthBearerRequestWithParams(Context, paramsDefinition)
            If requestData.AuthSuccess Then
                Dim data = requestData.Data
                Dim auth = requestData.Auth

                Dim token = auth.KeyToken
                token.Servidor = "LAPTOP-3JUTLUGJ\SAMIT"
                Dim conexion = New ConexionSQL(token.Servidor, token.BaseDatosNominaFull)
                Dim ServParams As New ServiceParametros
                Dim resUpsert = ServParams.UpsertParametros(token, data.Datos, data.Tabla)
                conexion.CerrarConexion()

                res.ObjetoRes = resUpsert
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

End Class