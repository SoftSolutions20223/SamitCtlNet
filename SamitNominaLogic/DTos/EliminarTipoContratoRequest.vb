Public Class EliminarTipoContratoRequest
    Public Property CodTipoContrato As Integer

    ' Constructor vacío
    Public Sub New()
    End Sub

    ' Constructor con parámetro
    Public Sub New(codTipoContrato As Integer)
        Me.CodTipoContrato = codTipoContrato
    End Sub

    ' Método para convertir a JObject para el procedimiento almacenado
    Public Function ToJObject() As Newtonsoft.Json.Linq.JObject
        Dim json As New Newtonsoft.Json.Linq.JObject()
        json("CodTipoContrato") = CodTipoContrato
        Return json
    End Function

    ' Método auxiliar para obtener el JSON como string
    Public Function ToJsonString() As String
        Return ToJObject().ToString(Newtonsoft.Json.Formatting.None)
    End Function
End Class