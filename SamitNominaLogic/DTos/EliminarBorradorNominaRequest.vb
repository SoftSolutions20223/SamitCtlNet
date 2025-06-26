Imports Newtonsoft.Json.Linq

Public Class EliminarBorradorNominaRequest
    Public Property SecNominaLiquida As Integer
    Public Property Usuario As String
    Public Property Terminal As String

    Public Sub New()
        Terminal = Environment.MachineName
    End Sub

    ''' <summary>
    ''' Convierte a JObject para el procedimiento almacenado
    ''' </summary>
    Public Function ToJObject() As JObject
        Dim json As New JObject()
        json("SecNominaLiquida") = SecNominaLiquida
        json("Usuario") = Usuario
        json("Terminal") = Terminal
        Return json
    End Function
End Class