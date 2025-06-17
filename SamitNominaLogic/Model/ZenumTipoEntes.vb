Imports System.ComponentModel.DataAnnotations

Public Class ZenumTipoEntes
    Public Property Sec As Integer?

    <Required>
    Public Property CodTipoEnte As Integer

    <Required(AllowEmptyStrings:=False)>
    <MaxLength(50)>
    Public Property NomTipoEnte As String

End Class
