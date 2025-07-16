Public Class DynamicDeleteResponse
    Public Property Estado As String
    Public Property Mensaje As String
    Public Property Tabla As String
    Public Property Codigo As Integer
    Public Property RegistrosEliminados As Integer
    Public Property FechaHora As DateTime

    ' Propiedades calculadas para facilitar el uso
    Public ReadOnly Property EsExitoso As Boolean
        Get
            Return Estado = "SUCCESS"
        End Get
    End Property

    Public ReadOnly Property EsAdvertencia As Boolean
        Get
            Return Estado = "WARNING"
        End Get
    End Property

    Public ReadOnly Property EsError As Boolean
        Get
            Return Estado = "ERROR"
        End Get
    End Property

    ' Constructor
    Public Sub New()
    End Sub
End Class