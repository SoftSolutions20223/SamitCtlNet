Imports System.ComponentModel.DataAnnotations

Public Class ClasConceptosNomina
    Public Property Sec As Integer

    <MaxLength(200)>
    Public Property Nom As String

    <MaxLength(1)>
    Public Property Vigente As String
End Class