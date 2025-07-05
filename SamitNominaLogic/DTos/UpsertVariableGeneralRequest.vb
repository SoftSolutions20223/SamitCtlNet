Imports Newtonsoft.Json.Linq

Public Class UpsertVariableGeneralRequest
    Public Property Sec As Integer
    Public Property NomVariable As String
    Public Property NomVariableAnterior As String
    Public Property CodDian As String
    Public Property Vigente As String
    Public Property Usuario As String
    Public Property Terminal As String
    Public Property Detalles As New List(Of DetalleVariableDTO)

    ''' <summary>
    ''' Convierte el request a JObject para enviar al procedimiento almacenado
    ''' </summary>
    Public Function ToJObject() As JObject
        Dim json As New JObject()
        json("Sec") = Sec
        json("NomVariable") = NomVariable
        json("NomVariableAnterior") = If(String.IsNullOrEmpty(NomVariableAnterior), Nothing, NomVariableAnterior)
        json("CodDian") = If(String.IsNullOrEmpty(CodDian), Nothing, CodDian)
        json("Vigente") = Vigente
        json("Usuario") = Usuario
        json("Terminal") = Terminal

        ' Agregar detalles
        If Detalles IsNot Nothing AndAlso Detalles.Count > 0 Then
            Dim detallesArray As New JArray()
            For Each detalle In Detalles
                Dim detalleJson As New JObject()
                detalleJson("Sec") = detalle.Sec
                detalleJson("Variable") = detalle.Variable
                detalleJson("Fecha") = detalle.Fecha.ToString("dd/MM/yyyy")
                detalleJson("Valor") = detalle.Valor
                detallesArray.Add(detalleJson)
            Next
            json("Detalles") = detallesArray
        End If

        Return json
    End Function
End Class