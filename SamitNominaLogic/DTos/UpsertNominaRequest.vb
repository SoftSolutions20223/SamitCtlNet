Public Class UpsertNominaRequest
    Public Property Nomina As Nominas
    Public Property Usuario As String
    Public Property Terminal As String

    ' Constructor
    Public Sub New()
        Nomina = New Nominas()
        Terminal = Environment.MachineName
    End Sub

    ' Método para convertir a JObject para el procedimiento almacenado
    Public Function ToJObject() As Newtonsoft.Json.Linq.JObject
        Dim json As New Newtonsoft.Json.Linq.JObject()

        ' Datos de la nómina
        json("Sec") = If(Nomina?.Sec, 0)
        json("NomNomina") = Nomina?.NomNomina
        json("FormaLiquida") = Nomina?.FormaLiquida
        json("Fecha") = If(Nomina?.Fecha.HasValue, Nomina.Fecha.Value.ToString("dd/MM/yyyy"), Nothing)
        json("Oficina") = Nomina?.Oficina
        json("Usuario") = Usuario
        json("Terminal") = Terminal

        Return json
    End Function

    ' Método auxiliar para obtener el JSON como string
    Public Function ToJsonString() As String
        Return ToJObject().ToString(Newtonsoft.Json.Formatting.None)
    End Function
End Class