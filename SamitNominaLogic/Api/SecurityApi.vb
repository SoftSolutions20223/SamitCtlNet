Imports Newtonsoft.Json
Imports SamitCore

Public Class SecurityApi

    Shared ReadOnly ApiPath = "/Api/Security.asmx"

    Public Shared Async Function GetParametrosUsuario(
                                               usuario As String,
                                               clave As String,
                                               servidor As String,
                                               sqlInstance As String,
                                               terminal As String,
                                               sysuser As String
                                               ) As Task(Of ApiResponseClient(Of ResponseParametros))
        Dim auth = "Basic " & ClientAuthHelper.GetUserPassEncoded(usuario, clave)
        Dim request = New RequestParametros With {
            .Servidor = servidor,
            .SqlInstancia = sqlInstance,
            .terminal = terminal,
            .sysuser = sysuser
        }

        Dim url = $"{ApiPath}/GetParametrosUsuario"
        Dim resApi = Await ApiClient.Instance.ApiPostAsync(Of ResponseParametros)(url, request, auth)

        If IsNothing(resApi) Then
            resApi = New ApiResponseClient With {.Estado = "ERROR"}
            resApi.Detalle.Add("La respuesta del servidor no contiene datos.")
        End If

        Return resApi
    End Function

    Public Shared Async Function GetToken(usuario As String, clave As String, request As RequestToken) As Task(Of ApiResponseClient(Of ResponseToken))
        Dim auth = "Basic " & ClientAuthHelper.GetUserPassEncoded(usuario, clave)

        Dim url = $"{ApiPath}/GetToken"
        Dim resApi = Await ApiClient.Instance.ApiPostAsync(Of ResponseToken)(url, request, auth)

        If IsNothing(resApi) Then
            resApi = New ApiResponseClient With {.Estado = "ERROR"}
            resApi.Detalle.Add("La respuesta del servidor no contiene datos.")
        End If

        Return resApi
    End Function

    Public Shared Async Function ValidaBd() As Task(Of Boolean)

        Dim url = $"{ApiPath}/CreaOActualizaBaseDatos"
        Dim resApi = Await ApiClient.Instance.ApiPostAsync(Of Boolean)(url)

        If IsNothing(resApi) Then
            resApi = New ApiResponseClient With {.Estado = "ERROR"}
            resApi.Detalle.Add("La respuesta del servidor no contiene datos.")
        End If

        Return resApi.ObjetoRes
    End Function

End Class
