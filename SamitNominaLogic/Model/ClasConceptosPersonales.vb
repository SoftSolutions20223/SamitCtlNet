Imports System.ComponentModel.DataAnnotations

Public Class ClasConceptosPersonales
    Public Property Sec As Integer

    <MaxLength(200)>
    Public Property Nom As String

    <MaxLength(1)>
    Public Property Vigente As String

    Public Property NivelP As Integer?
End Class