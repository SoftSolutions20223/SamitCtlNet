Public Class AnularLiquidacionResponse
    Public Property Estado As String
    Public Property Operacion As String
    Public Property Mensaje As String
    Public Property FechaHoraServidor As DateTime
    Public Property SecLiquidacion As Integer?
    Public Property TipoLiquidacion As String
    Public Property TipoDescripcion As String
    Public Property CodigoError As Integer?
    Public Property DatosEnviados As Newtonsoft.Json.Linq.JObject

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