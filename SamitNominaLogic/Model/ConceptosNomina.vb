Imports System.ComponentModel.DataAnnotations

Public Class ConceptosNomina
    Public Property Sec As Integer

    <MaxLength(200)>
    Public Property NomConcepto As String

    <MaxLength(1)>
    Public Property Vigente As String

    <MaxLength(200)>
    Public Property Formula As String

    Public Property Tipo As Integer?

    <MaxLength(20)>
    Public Property PeriodosLiquida As String

    <MaxLength(200)>
    Public Property Base As String

    Public Property Redondea As Integer?

    Public Property Fondo As Integer?

    Public Property Clasificacion As Integer?

    Public Property EsRetencion As Boolean?

    Public Property EsPredeterminado As Boolean?

    <MaxLength(20)>
    Public Property CodDian As String

    Public Property Orden As Integer?
End Class