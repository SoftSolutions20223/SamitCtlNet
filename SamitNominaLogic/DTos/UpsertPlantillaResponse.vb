Public Class UpsertPlantillaResponse
    Public Property Estado As String
    Public Property Operacion As String
    Public Property Mensaje As String
    Public Property FechaHoraServidor As DateTime
    Public Property CodigoError As Integer?
    Public Property Plantilla As PlantillaResponseDto
    Public Property DatosEnviados As Object

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
