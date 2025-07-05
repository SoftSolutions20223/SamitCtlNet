Imports System.ComponentModel.DataAnnotations

Public Class NominaLiquidaConceptos
    Public Property Sec As Integer

    <Required>
    Public Property LiquidaContrato As Integer

    <Required>
    Public Property Valor As Decimal

    <Required>
    Public Property Base As Decimal

    <Required(AllowEmptyStrings:=False)>
    <MaxLength(200)>
    Public Property NomConcepto As String

    Public Property SecConcepto As Integer?

    <MaxLength(200)>
    Public Property NomBase As String

    Public Property SecConceptoP As Integer?

    Public Property SecConceptoP2 As Integer?
    Public Property Cuota As Integer?

End Class