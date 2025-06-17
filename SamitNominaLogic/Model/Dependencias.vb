Imports System.ComponentModel.DataAnnotations

Public Class Dependencias
    Public Property Sec As Integer

    <MaxLength(100)>
    Public Property NomDependencia As String

    <MaxLength(1)>
    Public Property Vigente As String

End Class