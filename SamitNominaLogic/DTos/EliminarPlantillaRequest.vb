Public Class EliminarPlantillaRequest
    Public Property SecPlantilla As Integer

    ' Constructor con parámetro
    Public Sub New(secPlantilla As Integer)
        Me.SecPlantilla = secPlantilla
    End Sub

    ' Método para convertir a JObject para el procedimiento almacenado
    Public Function ToJObject() As Newtonsoft.Json.Linq.JObject
        Dim json As New Newtonsoft.Json.Linq.JObject()
        json("SecPlantilla") = SecPlantilla
        Return json
    End Function
End Class