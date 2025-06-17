Imports System.ComponentModel.DataAnnotations

Public Class CAT_NivelEducativo
    <Required>
    Public Property Sec As Integer?

    <Required(AllowEmptyStrings:=False)>
    <MaxLength(50)>
    Public Property NomNivel As String

    <Required>
    Public Property Vigente As Boolean

    <Required>
    Public Property EsFormal As Boolean
End Class
