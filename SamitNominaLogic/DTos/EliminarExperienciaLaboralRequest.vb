Public Class EliminarExperienciaLaboralRequest
    Public Property IdRegExpLaboral As Integer
    Public Property IdEmpleado As Integer

    ' Constructor

    ' Constructor con parámetros
    Public Sub New(idRegExpLaboral As Integer, idEmpleado As Integer)
        Me.IdRegExpLaboral = idRegExpLaboral
        Me.IdEmpleado = idEmpleado
    End Sub

    ' Método para convertir a JObject para el procedimiento almacenado
    Public Function ToJObject() As Newtonsoft.Json.Linq.JObject
        Dim json As New Newtonsoft.Json.Linq.JObject()

        json("IdRegExpLaboral") = IdRegExpLaboral
        json("IdEmpleado") = IdEmpleado

        Return json
    End Function

    ' Método auxiliar para obtener el JSON como string
    Public Function ToJsonString() As String
        Return ToJObject().ToString(Newtonsoft.Json.Formatting.None)
    End Function
End Class