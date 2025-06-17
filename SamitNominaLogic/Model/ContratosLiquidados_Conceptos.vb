Imports System.ComponentModel.DataAnnotations

Public Class ContratosLiquidados_Conceptos
    Public Property Sec As Integer

    Public Property LiquidaContrato As Integer?

    Public Property Valor As Decimal?

    Public Property Base As Decimal?

    <MaxLength(200)>
    Public Property NomConcepto As String

    Public Property SecConcepto As Integer?

    <MaxLength(200)>
    Public Property NomBase As String

    Public Property SecConceptoP As Integer?

    Public Property SecConceptoP2 As Integer?
End Class