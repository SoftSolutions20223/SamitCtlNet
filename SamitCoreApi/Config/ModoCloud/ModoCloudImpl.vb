Public Class ModoCloudImpl
    Implements IModoCloud

    ReadOnly AppConfig As IAppConfiguration

    Public Sub New()
        AppConfig = New AppConfigurationImpl()
    End Sub

    Public Function EsModoCloud(instancia As String) As Boolean Implements IModoCloud.EsModoCloud
        Dim modoCloud = Convert.ToInt32(AppConfig.ModoCloud)
        Return modoCloud = 1 And instancia.ToUpper() = "SAMITCLOUD"
    End Function

End Class
