Imports System.ComponentModel.DataAnnotations

Public Class VariablesPersonales
    Public Property Sec As Integer

    <MaxLength(200)>
    Public Property NomVariable As String

    <MaxLength(1)>
    Public Property Vigente As String

    Public Property ValorMaximo As Decimal?

    Public Property ValorDefecto As Decimal?

    Public Property EsPredeterminado As Boolean?

    <MaxLength(20)>
    Public Property CodDian As String

End Class