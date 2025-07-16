Imports Newtonsoft.Json.Linq

Public Class UpsertDescripVarPerResponse
    Public Property Estado As String
    Public Property Operacion As String
    Public Property Mensaje As String
    Public Property FechaHoraServidor As DateTime
    Public Property DetalleVariable As DetalleVarPDTO

    ' Para errores
    Public Property CodigoError As Integer?
    Public Property DatosEnviados As JObject

    ' Propiedades calculadas
    Public ReadOnly Property EsExitoso As Boolean
        Get
            Return Estado = "SUCCESS"
        End Get
    End Property
End Class