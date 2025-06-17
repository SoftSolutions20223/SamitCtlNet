Imports System.ComponentModel.DataAnnotations

Public Class G_Departamento
    Public Property Sec As Integer

    <Required>
    Public Property Pais As Integer

    <Required(AllowEmptyStrings:=False)>
    <MaxLength(100)>
    Public Property NomDpto As String

End Class