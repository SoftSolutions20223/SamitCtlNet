Imports System.IO
Imports System.Text
Imports System.Web
Imports Newtonsoft.Json

Public Class ApiHelper

    Private Shared Function AuthBearerRequest(contexto As HttpContext) As ApiAutentication
        Dim headerAuthorization = contexto.Request.Headers.Get("Authorization")
        Dim credenciales = SecurityHelper.GetKeyFromHeader(headerAuthorization, "Bearer")
        Return credenciales
    End Function

    Public Shared Function AuthBearerRequestEmptyParams(contexto As HttpContext) As ParamsData(Of String)
        Dim auth = AuthBearerRequest(contexto)

        Dim result = New ParamsData(Of String) With {
            .Auth = auth,
            .Data = Nothing
        }
        Return result
    End Function

    Public Shared Function AuthBearerRequestWithParams(Of T)(contexto As HttpContext, definition As T) As ParamsData(Of T)
        Dim auth = AuthBearerRequest(contexto)
        Dim bodyJson = GetBody(contexto)
        Dim data = JsonConvert.DeserializeAnonymousType(bodyJson, definition)

        Dim result = New ParamsData(Of T) With {
            .Auth = auth,
            .Data = data
        }
        Return result
    End Function

    Private Shared Function AuthBasicRequest(contexto As HttpContext) As ApiAutentication
        Dim headerAuthorization = contexto.Request.Headers.Get("Authorization")
        Dim credenciales = SecurityHelper.GetKeyFromHeader(headerAuthorization, "Basic")
        Return credenciales
    End Function

    Public Shared Function AuthBasicRequestWithParams(Of T)(contexto As HttpContext, definition As T) As ParamsData(Of T)
        Dim auth = AuthBasicRequest(contexto)
        Dim bodyJson = GetBody(contexto)
        Dim data = JsonConvert.DeserializeAnonymousType(bodyJson, definition)

        Dim result = New ParamsData(Of T) With {
            .Auth = auth,
            .Data = data
        }
        Return result
    End Function

    Public Shared Function AuthBasicRequestWithParams(Of T)(contexto As HttpContext) As ParamsData(Of T)
        Dim auth = AuthBasicRequest(contexto)
        Dim bodyJson = GetBody(contexto)
        Dim data = JsonConvert.DeserializeObject(Of T)(bodyJson)

        Dim result = New ParamsData(Of T) With {
            .Auth = auth,
            .Data = data
        }
        Return result
    End Function

    Public Shared Sub WriteError(contexto As HttpContext, errorMessage As String)
        Dim res As New ApiResponse

    End Sub

    Public Shared Sub WriteResponse(contexto As HttpContext, Respuesta As String)
        Dim headerCompress = contexto.Request.Headers.Get("compress")
        If headerCompress = "1" Then
            Dim maxCaracteres = 20000
            Dim tamañoRespuesta = Respuesta.Length
            If tamañoRespuesta > maxCaracteres Then
                Try
                    Dim res As ApiResponse = JsonConvert.DeserializeObject(Of ApiResponse)(Respuesta)
                    Dim jsonData = JsonConvert.SerializeObject(res.ObjetoRes)
                    res.ObjetoRes = ApiResponse.ComprimirDatos(jsonData)
                    res.DatosComprimidos = True
                    Respuesta = JsonConvert.SerializeObject(res)
                Catch ex As Exception
                    ex.ToString()
                End Try
            End If
        End If

        SamitCore.SetCulture()

        contexto.Response.Clear()
        contexto.Response.ContentType = "application/json"
        'contexto.Response.AddHeader("content-length", Respuesta.Length.ToString())
        contexto.Response.Flush()
        contexto.Response.Write(Respuesta)
        contexto.Response.End()
    End Sub

    Public Shared Function GetBody(contexto As HttpContext) As String
        SamitCore.SetCulture()

        Dim res As String = ""
        Using stream = New MemoryStream()
            Dim request = contexto.Request
            request.InputStream.Seek(0, SeekOrigin.Begin)
            request.InputStream.CopyTo(stream)
            res = Encoding.UTF8.GetString(stream.ToArray())
        End Using
        If String.IsNullOrWhiteSpace(res) Then
            res = "{}"
        End If
        Return res
    End Function


End Class
