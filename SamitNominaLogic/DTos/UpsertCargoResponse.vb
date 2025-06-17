Public Class UpsertCargoResponse
    Public Property Estado As String
    Public Property Operacion As String
    Public Property Mensaje As String
    Public Property FechaHoraServidor As DateTime
    Public Property CodigoError As Integer?
    Public Property Cargo As CargoResponseDto

    Public ReadOnly Property EsExitoso As Boolean
        Get
            Return Estado = "SUCCESS"
        End Get
    End Property
End Class
