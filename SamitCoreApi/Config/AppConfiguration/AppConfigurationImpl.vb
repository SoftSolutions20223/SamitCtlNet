Public Class AppConfigurationImpl
    Implements IAppConfiguration

    Private Function GetSetting(key As String)
        Return System.Configuration.ConfigurationManager.AppSettings(key)
    End Function

    Public ReadOnly Property AppAssemblyName As String Implements IAppConfiguration.AppAssemblyName
        Get
            Return GetSetting("appAssemblyName")
        End Get
    End Property

    Public ReadOnly Property SqlDefaultServer As String Implements IAppConfiguration.SqlDefaultServer
        Get
            Return GetSetting("sqlDefaultServer")
        End Get
    End Property

    Public ReadOnly Property SqlDatabase As String Implements IAppConfiguration.SqlDatabase
        Get
            Return GetSetting("sqlDatabase")
        End Get
    End Property

    Public ReadOnly Property SqlUser As String Implements IAppConfiguration.SqlUser
        Get
            Return GetSetting("sqlUser")
        End Get
    End Property

    Public ReadOnly Property SqlPass As String Implements IAppConfiguration.SqlPass
        Get
            Return GetSetting("sqlPass")
        End Get
    End Property

    Public ReadOnly Property ModoCloud As String Implements IAppConfiguration.ModoCloud
        Get
            Return GetSetting("ModoCloud")
        End Get
    End Property

    Public ReadOnly Property SamitApiUrl As String Implements IAppConfiguration.SamitApiUrl
        Get
            Return GetSetting("samitApiUrl")
        End Get
    End Property

End Class
