Public Class AsignarNominaContratoResponse
    Public Property Estado As String
    Public Property Mensaje As String
    Public Property IdContrato As String
    Public Property SecNomina As Integer?
    Public Property NombreEmpleado As String
    Public Property NombreNomina As String
    Public Property RegistrosAfectados As Integer
    Public Property FechaHora As DateTime

    ' Propiedades calculadas para facilitar el uso
    Public ReadOnly Property EsExitoso As Boolean
        Get
            Return Estado = "SUCCESS"
        End Get
    End Property

    Public ReadOnly Property EsError As Boolean
        Get
            Return Estado = "ERROR"
        End Get
    End Property
End Class