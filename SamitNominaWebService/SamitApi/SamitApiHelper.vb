Imports SamitCore

Public Class SamitApiHelper

    ReadOnly AppConfiguration As SamitCoreApi.IAppConfiguration
    ReadOnly ApiInstance As Api

    Public Sub New()
        AppConfiguration = New SamitCoreApi.AppConfigurationImpl()
        ApiInstance = New Api(AppConfiguration.SamitApiUrl, 0)
    End Sub

    Private Function GetSecurityPath()
        Return $"/Seguridad/ApiSeguridad.asmx"
    End Function

    Public Function GetParametrosUsuario(usuario As String, clave As String, servidor As String, sqlInstance As String, terminal As String, sysuser As String) As ApiResponseClient(Of Object)
        Dim userPass = ClientAuthHelper.GetUserPassEncoded(usuario, clave)
        Dim auth = $"Basic {userPass}"
        Dim request = New With {
            .servidor = servidor,
            .sqlInstancia = sqlInstance,
            .terminal = terminal,
            .sysuser = sysuser
        }

        Dim url = $"{GetSecurityPath()}/GetParametrosUsuario"
        Dim resApi = ApiInstance.ApiPOST(Of Object)(url, request, auth)
        Return resApi
    End Function

    Public Function AutenticarConServidor(usuario As String, clave As String, datosSesion As RequestToken) As ApiResponseClient(Of Object)
        Dim userPass = ClientAuthHelper.GetUserPassEncoded(usuario, clave)
        Dim auth = $"Basic {userPass}"

        Dim url = $"{GetSecurityPath()}/GetToken"
        Dim resApi = ApiInstance.ApiPOST(Of Object)(url, datosSesion, auth)
        Return resApi
    End Function

End Class
