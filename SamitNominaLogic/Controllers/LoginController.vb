Imports Newtonsoft.Json
Imports SamitCore

Public Class LoginController

    Public Async Function GetParametrosInicioSesion(usuario As String, clave As String, servidor As String, sqlInstance As String, terminal As String, sysuser As String) As Task(Of ApiResponseClient(Of ResponseParametros))

        Dim result = Await SecurityApi.GetParametrosUsuario(
            usuario:=usuario,
            clave:=clave,
            servidor:=servidor,
            sqlInstance:=sqlInstance,
            terminal:=terminal,
            sysuser:=sysuser
        )
        Return result
    End Function

    Public Async Function IniciarSesion(usuario As String, clave As String, request As RequestToken) As Task(Of ApiResponseClient(Of ResponseToken))

        Dim result = Await SecurityApi.GetToken(
            usuario:=usuario,
            clave:=clave,
            request:=request
        )

        If result.Resultado = ApiEstado.OK Then
            ApiClient.Instance.SetToken(result.ObjetoRes.Token)
        End If

        Return result
    End Function

    Public Async Function Validabd() As Task(Of Boolean)
        Dim result = Await SecurityApi.ValidaBd()
        Return result
    End Function

End Class
