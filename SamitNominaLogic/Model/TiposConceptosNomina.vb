Imports System.ComponentModel.DataAnnotations

Public Class TiposConceptosNomina
    Public Property Sec As Integer

    <MaxLength(200)>
    Public Property NomTipo As String

    <MaxLength(1)>
    Public Property Vigente As String

End Class