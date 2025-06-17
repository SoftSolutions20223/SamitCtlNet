Public Class UpsertLiquidacionNominaResponse
    Public Property Estado As String
    Public Property Operacion As String
    Public Property Mensaje As String
    Public Property FechaHoraServidor As DateTime
    Public Property CodigoError As Integer?
    Public Property SecNominaLiquida As Integer
    Public Property ContratosCreados As Integer
    Public Property ContratosActualizados As Integer
    Public Property VariablesCreadas As Integer
    Public Property DatosEnviados As Object

    Public ReadOnly Property EsExitoso As Boolean
        Get
            Return Estado = "SUCCESS"
        End Get
    End Property
End Class
