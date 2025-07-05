Public Class LiquidarNominaRequest
    Public Property SecNominaLiquida As Integer

    Public Function ToJObject() As Newtonsoft.Json.Linq.JObject
        Dim json As New Newtonsoft.Json.Linq.JObject()
        json("SecNominaLiquida") = SecNominaLiquida
        Return json
    End Function
End Class