Public Class EliminarDescuentoContratoRequest
    Public Property SecDescuento As Integer

    ' Constructor sin parámetros
    Public Sub New()
    End Sub

    ' Constructor con parámetro
    Public Sub New(secDescuento As Integer)
        Me.SecDescuento = secDescuento
    End Sub

    ' Método para convertir a JObject para el procedimiento almacenado
    Public Function ToJObject() As Newtonsoft.Json.Linq.JObject
        Dim json As New Newtonsoft.Json.Linq.JObject()

        json("SecDescuento") = SecDescuento

        Return json
    End Function

    ' Método auxiliar para obtener el JSON como string si se necesita
    Public Function ToJsonString() As String
        Return ToJObject().ToString(Newtonsoft.Json.Formatting.None)
    End Function
End Class