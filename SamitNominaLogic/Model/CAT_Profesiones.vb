Imports System.ComponentModel.DataAnnotations

Public Class CAT_Profesiones
    Public Property Sec As Integer

    <Required(AllowEmptyStrings:=False)>
    Public Property NomProfesion As String

    <Required>
    Public Property Vigente As Boolean

    Public Property IdNivelEducativo As Integer?
End Class