Imports System.ComponentModel.DataAnnotations

Public Class BasesConceptos
    Public Property Sec As Integer

    <MaxLength(200)>
    Public Property NomBase As String

    <MaxLength(1)>
    Public Property Vigente As String

    <MaxLength(200)>
    Public Property Formula As String
End Class
