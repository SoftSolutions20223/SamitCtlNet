Imports System.ComponentModel.DataAnnotations

Public Class NominaLiquidaExtraordinariaVariables
    Public Property Sec As Integer

    <Required>
    Public Property SecLiquidaContrato As Integer

    <Required>
    Public Property Variable As Integer

    <Required>
    Public Property Cantidad As Decimal

End Class