Public Class EliminarEmpleadoRequest
    Public Property SecEmpleado As Integer

    ' Constructor con parámetro
    Public Sub New(secEmpleado As Integer)
        Me.SecEmpleado = secEmpleado
    End Sub

    ' Método para convertir a JObject para el procedimiento almacenado
    Public Function ToJObject() As Newtonsoft.Json.Linq.JObject
        Dim json As New Newtonsoft.Json.Linq.JObject()

        json("SecEmpleado") = SecEmpleado

        Return json
    End Function

    ' Método auxiliar para obtener el JSON como string
    Public Function ToJsonString() As String
        Return ToJObject().ToString(Newtonsoft.Json.Formatting.None)
    End Function
End Class