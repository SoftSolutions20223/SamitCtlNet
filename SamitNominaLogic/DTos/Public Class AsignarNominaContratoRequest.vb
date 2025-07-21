Public Class AsignarNominaContratoRequest
    Public Property IdContrato As String
    Public Property SecNomina As Integer?

    ' Constructor sin parámetros
    Public Sub New()
    End Sub

    ' Constructor con parámetros
    Public Sub New(idContrato As String, secNomina As Integer?)
        Me.IdContrato = idContrato
        Me.SecNomina = secNomina
    End Sub

    ' Método para convertir a JObject para el procedimiento almacenado
    Public Function ToJObject() As Newtonsoft.Json.Linq.JObject
        Dim json As New Newtonsoft.Json.Linq.JObject()

        json("IdContrato") = IdContrato

        ' Manejar el caso de NULL para SecNomina
        If SecNomina.HasValue Then
            json("SecNomina") = SecNomina.Value
        Else
            json("SecNomina") = Nothing
        End If

        Return json
    End Function

    ' Método auxiliar para obtener el JSON como string
    Public Function ToJsonString() As String
        Return ToJObject().ToString(Newtonsoft.Json.Formatting.None)
    End Function
End Class