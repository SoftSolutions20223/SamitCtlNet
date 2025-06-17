Imports System.ComponentModel.DataAnnotations

Public Class NominaLiquidaSemestresVariables
    Public Property Sec As Integer

    <Required>
    Public Property SecLiquidaContrato As Integer

    <Required>
    Public Property Variable As Integer

    <Required>
    Public Property Cantidad As Decimal

End Class