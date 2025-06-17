Imports System.ComponentModel.DataAnnotations

Public Class NominaLiquidadaContratos
    Public Property Sec As Integer

    <Required>
    Public Property Contrato As Integer

    <Required>
    Public Property NominaLiquidada As Integer

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

    <MaxLength(200)>
    Public Property Cufe As String

    <MaxLength(500)>
    Public Property Estado As String

    <MaxLength(200)>
    Public Property DoceId As String

    Public Property Contabilizada As Boolean?

    <MaxLength(20)>
    Public Property FormaDePago As String

    <MaxLength(50)>
    Public Property DocContable As String

    <MaxLength(50)>
    Public Property EstadoCont As String

End Class