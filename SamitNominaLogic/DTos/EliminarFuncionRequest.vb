Public Class EliminarFuncionRequest
    Public Property SecFuncion As Integer

    ' Constructor vacío
    Public Sub New()
    End Sub

    ' Constructor con parámetro
    Public Sub New(secFuncion As Integer)
        Me.SecFuncion = secFuncion
    End Sub

    ' Método para convertir a JObject para el procedimiento almacenado
    Public Function ToJObject() As Newtonsoft.Json.Linq.JObject
        Dim json As New Newtonsoft.Json.Linq.JObject()
        json("SecFuncion") = SecFuncion
        Return json
    End Function

    ' Método auxiliar para obtener el JSON como string
    Public Function ToJsonString() As String
        Return ToJObject().ToString(Newtonsoft.Json.Formatting.None)
    End Function
End Class