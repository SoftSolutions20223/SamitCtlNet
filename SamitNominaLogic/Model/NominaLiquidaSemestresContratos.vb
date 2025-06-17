Imports System.ComponentModel.DataAnnotations

Public Class NominaLiquidaSemestresContratos
    Public Property Sec As Integer

    <Required>
    Public Property Contrato As Integer

    <Required>
    Public Property NominaLiquidaSemestres As Integer

    <Required>
    Public Property Total As Decimal

    Public Property CargoActual As Integer?

    Public Property TotalIngresos As Decimal?

    Public Property TotalDeducciones As Decimal?

    Public Property TotalDescuentosNomina As Decimal?

    Public Property Contabilizada As Boolean?

    <MaxLength(20)>
    Public Property FormaDePago As String

    <MaxLength(50)>
    Public Property DocContable As String

    <MaxLength(50)>
    Public Property EstadoCont As String

End Class
