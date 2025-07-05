Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class UpsertVariableGeneralResponse
    Public Property Estado As String

    Public Property Operacion As String

    Public Property Mensaje As String

    Public Property FechaHoraServidor As DateTime

    Public Property Variable As VariableGeneralDto

    Public Property CodigoError As Integer?

    Public Property DatosEnviados As JObject

    ''' <summary>
    ''' Indica si la operación fue exitosa
    ''' </summary>
    <JsonIgnore>
    Public ReadOnly Property EsExitoso As Boolean
        Get
            Return Estado = "SUCCESS"
        End Get
    End Property
End Class