Public Class EliminarBancoRequest
    Public Property Codigo As Integer

    ' Constructor vacío
    Public Sub New()
    End Sub

    ' Constructor con parámetro
    Public Sub New(codigo As Integer)
        Me.Codigo = codigo
    End Sub

    ' Método para convertir a JObject para el procedimiento almacenado
    Public Function ToJObject() As Newtonsoft.Json.Linq.JObject
        Dim json As New Newtonsoft.Json.Linq.JObject()
        json("Codigo") = Codigo
        Return json
    End Function

    ' Método auxiliar para obtener el JSON como string
    Public Function ToJsonString() As String
        Return ToJObject().ToString(Newtonsoft.Json.Formatting.None)
    End Function
End Class