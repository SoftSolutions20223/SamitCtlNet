Imports System.ComponentModel.DataAnnotations

Public Class VariablesGenerales
    Public Property Sec As Integer

    <MaxLength(200)>
    Public Property NomVariable As String

    <MaxLength(1)>
    Public Property Vigente As String

    <MaxLength(200)>
    Public Property Descripcion As String

    Public Property EsPredeterminado As Boolean?

    <MaxLength(20)>
    Public Property CodDian As String

End Class