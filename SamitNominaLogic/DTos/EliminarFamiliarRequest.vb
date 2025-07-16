Public Class EliminarFamiliarRequest
    Public Property SecRegistro As Integer
    Public Property IdEmpleado As Integer



    ' Constructor con parámetros
    Public Sub New(secRegistro As Integer, idEmpleado As Integer)
        Me.SecRegistro = secRegistro
        Me.IdEmpleado = idEmpleado
    End Sub

    ' Método para convertir a JObject para el procedimiento almacenado
    Public Function ToJObject() As Newtonsoft.Json.Linq.JObject
        Dim json As New Newtonsoft.Json.Linq.JObject()

        json("SecRegistro") = SecRegistro
        json("IdEmpleado") = IdEmpleado

        Return json
    End Function

    ' Método auxiliar para obtener el JSON como string
    Public Function ToJsonString() As String
        Return ToJObject().ToString(Newtonsoft.Json.Formatting.None)
    End Function
End Class