Imports System.ComponentModel.DataAnnotations

Public Class CAT_Parentesco
    Public Property Sec As Integer

    <Required(AllowEmptyStrings:=False)>
    <MaxLength(50)>
    Public Property NomParentesco As String

    Public Property Estado As Integer?
End Class