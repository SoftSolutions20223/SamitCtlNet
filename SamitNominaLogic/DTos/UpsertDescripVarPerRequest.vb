Imports Newtonsoft.Json.Linq

Public Class UpsertDescripVarPerRequest
    ' Propiedades principales
    Public Property Sec As Integer
    Public Property FechaHoraInicio As DateTime
    Public Property FechaHoraFin As DateTime
    Public Property Cantidad As Integer
    Public Property CodVarP As Integer
    Public Property TipoDesc As String
    Public Property NomTipo As String

    ' Propiedades de control
    Public Property Usuario As String
    Public Property Terminal As String

    Public Sub New()
        Terminal = Environment.MachineName
        Sec = 0 ' Por defecto para inserción
    End Sub

    Public Function ToJObject() As JObject
        Dim json As New JObject()

        json("Sec") = Sec
        json("FechaHoraInicio") = FechaHoraInicio.ToString("dd/MM/yyyy HH:mm:ss")
        json("FechaHoraFin") = FechaHoraFin.ToString("dd/MM/yyyy HH:mm:ss")
        json("Cantidad") = Cantidad
        json("CodVarP") = CodVarP
        json("Usuario") = Usuario
        json("Terminal") = Terminal

        ' Campos opcionales (solo para incapacidades)
        If Not String.IsNullOrWhiteSpace(TipoDesc) Then
            json("TipoDesc") = TipoDesc
        End If

        If Not String.IsNullOrWhiteSpace(NomTipo) Then
            json("NomTipo") = NomTipo
        End If

        Return json
    End Function
End Class