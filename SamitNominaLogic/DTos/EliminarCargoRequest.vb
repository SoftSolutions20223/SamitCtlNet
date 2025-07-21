Public Class EliminarCargoRequest
    Public Property SecCargo As Integer

    ' Constructor vacío
    Public Sub New()
    End Sub

    ' Constructor con parámetro
    Public Sub New(secCargo As Integer)
        Me.SecCargo = secCargo
    End Sub

    ' Método para convertir a JObject para el procedimiento almacenado
    Public Function ToJObject() As Newtonsoft.Json.Linq.JObject
        Dim json As New Newtonsoft.Json.Linq.JObject()
        json("SecCargo") = SecCargo
        Return json
    End Function

    ' Método auxiliar para obtener el JSON como string
    Public Function ToJsonString() As String
        Return ToJObject().ToString(Newtonsoft.Json.Formatting.None)
    End Function
End Class