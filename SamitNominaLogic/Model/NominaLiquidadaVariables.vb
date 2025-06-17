Imports System.ComponentModel.DataAnnotations

Public Class NominaLiquidadaVariables
    Public Property Sec As Integer

    <Required>
    Public Property SecLiquidadaContrato As Integer

    <Required>
    Public Property Variable As Integer

    <Required>
    Public Property Cantidad As Decimal

End Class