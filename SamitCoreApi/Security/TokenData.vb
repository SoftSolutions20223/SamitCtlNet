Imports Newtonsoft.Json

Public Class TokenData

    Public Property CodSesion As Integer

    Public Property Servidor As String
    Public Property Usuario As String
    Public Property Clave As String
    Public Property Empresa As Integer
    Public Property Oficina As Integer
    Public Property Rol As Integer
    Public Property Terminal As String
    Public Property FechaTrabajo As Date

    Public Property FechaCrea As DateTime
    Public Property FechaVence As DateTime

    Public Property ManejaInventario As Boolean = True
    Public Property ManejaVehiculos As Boolean = True
    Public Property ManejaActivos As Boolean = False
    Public Property EsClienteCloud As Boolean = False

    <JsonIgnore>
    Public ReadOnly Property AñoTrabajo As Integer
        Get
            Return FechaTrabajo.Year
        End Get
    End Property

    <JsonIgnore>
    Public ReadOnly Property BaseDatosAño As String
        Get
            Return GetNombreBaseDatosAño(Empresa, AñoTrabajo)
        End Get
    End Property

    <JsonIgnore>
    Public ReadOnly Property BaseDatosGeneral As String
        Get
            Return GetNombreBaseDatosGeneral(Empresa)
        End Get
    End Property

    <JsonIgnore>
    Public ReadOnly Property BaseDatosSeguridad As String
        Get
            Return GetNombreBaseDatosSeguridad()
        End Get
    End Property

    <JsonIgnore>
    Public ReadOnly Property BaseDatosNomina As String
        Get
            Return GetNombreBaseDatosNomina(Empresa)
        End Get
    End Property

    <JsonIgnore>
    Public ReadOnly Property BaseDatosNominaFull As String
        Get
            Return GetNombreBaseDatosNominaFull(Empresa)
        End Get
    End Property

    <JsonIgnore>
    Public ReadOnly Property BaseDatosPedidos As String
        Get
            Return GetNombreBaseDatosPedidos(Empresa)
        End Get
    End Property

    <JsonIgnore>
    Public ReadOnly Property Instancia As String
        Get
            Dim instacia = Servidor
            If instacia.Contains("\") Then instacia = instacia.Split("\")(1)
            Return instacia
        End Get
    End Property

End Class
