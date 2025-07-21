Public Class EliminarConceptoPersonalRequest
    Public Property SecConcepto As Integer

    ' Constructor con parámetro
    Public Sub New(secConcepto As Integer)
        Me.SecConcepto = secConcepto
    End Sub

    ' Constructor sin parámetros (necesario para deserialización)
    Public Sub New()
    End Sub

    ' Método para convertir a JObject para el procedimiento almacenado
    Public Function ToJObject() As Newtonsoft.Json.Linq.JObject
        Dim json As New Newtonsoft.Json.Linq.JObject()

        json("SecConcepto") = SecConcepto

        Return json
    End Function

    ' Método auxiliar para obtener el JSON como string
    Public Function ToJsonString() As String
        Return ToJObject().ToString(Newtonsoft.Json.Formatting.None)
    End Function
End Class