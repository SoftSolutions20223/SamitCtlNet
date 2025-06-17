Imports System.ComponentModel.DataAnnotations

Public Class NominaLiquidaContratos
    Public Property Sec As Integer

    <Required>
    Public Property Contrato As Integer

    <Required>
    Public Property NominaLiquida As Integer

    <Required>
    Public Property Total As Decimal

    Public Property HorasMes As Integer?

    Public Property CargoActual As Integer?

    Public Property Asignacion As Decimal?

    Public Property TotalProvisiones As Decimal?

    Public Property TotalFondos As Decimal?

    Public Property TotalIngresos As Decimal?

    Public Property TotalDeducciones As Decimal?

    <MaxLength(2000)>
    Public Property Comentario As String

    Public Property TotalDescuentosNomina As Decimal?

End Class