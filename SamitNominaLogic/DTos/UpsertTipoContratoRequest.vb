Public Class UpsertTipoContratoRequest
    Public Property TipoContrato As CAT_TipoContratos
    Public Property Usuario As String
    Public Property Terminal As String

    Public Sub New()
        TipoContrato = New CAT_TipoContratos()
        Terminal = Environment.MachineName
    End Sub

    ' Método para convertir a JObject para el procedimiento almacenado
    Public Function ToJObject() As Newtonsoft.Json.Linq.JObject
        Dim json As New Newtonsoft.Json.Linq.JObject()

        ' Datos del tipo de contrato
        json("Sec") = If(TipoContrato?.Sec, 0)
        json("NomTipo") = TipoContrato?.NomTipo
        json("Usuario") = Usuario
        json("Terminal") = Terminal

        Return json
    End Function

    ' Método auxiliar para obtener el JSON como string si se necesita
    Public Function ToJsonString() As String
        Return ToJObject().ToString(Newtonsoft.Json.Formatting.None)
    End Function
End Class
