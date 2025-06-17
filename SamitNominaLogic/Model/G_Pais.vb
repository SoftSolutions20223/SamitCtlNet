Imports System.ComponentModel.DataAnnotations

Public Class G_Pais
    Public Property Sec As Integer

    <Required(AllowEmptyStrings:=False)>
    <MaxLength(100)>
    Public Property NomPais As String

    <Required(AllowEmptyStrings:=False)>
    <MaxLength(3)>
    Public Property CodIso As String

End Class