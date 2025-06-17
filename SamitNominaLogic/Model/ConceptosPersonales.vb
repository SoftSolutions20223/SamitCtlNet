Imports System.ComponentModel.DataAnnotations

Public Class ConceptosPersonales
    Public Property Sec As Integer

    <MaxLength(200)>
    Public Property NomConcepto As String

    <MaxLength(1)>
    Public Property Vigente As String

    Public Property Clasificacion As Integer?

    <MaxLength(20)>
    Public Property PeriodosLiquida As String

    <MaxLength(2000)>
    Public Property ValMaxDescuento As String

    Public Property EsPredeterminado As Boolean?

    <MaxLength(20)>
    Public Property CodDian As String
End Class