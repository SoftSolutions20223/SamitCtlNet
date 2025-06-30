Public Class GuardarBorradorNominaRequest
    Public Property SecNominaLiquida As Integer
    Public Property SecPeriodo As Integer
    Public Property EsBorrador As Boolean
    Public Property EstaLiquidando As Boolean
    Public Property Usuario As String
    Public Property Terminal As String
    Public Property Contratos As List(Of ContratoLiquidaDTO)

    Public Sub New()
        Contratos = New List(Of ContratoLiquidaDTO)
    End Sub

    Public Function ToJObject() As Newtonsoft.Json.Linq.JObject
        Return Newtonsoft.Json.Linq.JObject.FromObject(Me)
    End Function
End Class