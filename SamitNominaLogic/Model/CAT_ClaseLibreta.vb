Imports System.ComponentModel.DataAnnotations

Public Class CAT_ClaseLibreta
    Public Property Sec As Integer

    <Required(AllowEmptyStrings:=False)>
    <MaxLength(50)>
    Public Property NomClaseLib As String

    <Required>
    Public Property Vigente As Boolean
End Class