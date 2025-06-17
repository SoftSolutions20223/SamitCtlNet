Imports System.ComponentModel.DataAnnotations

Public Class ConceptosP_Contratos
    Public Property Sec As Integer

    Public Property Contrato As Integer?

    Public Property Concepto As Integer?

    Public Property TotalDescontar As Decimal?

    Public Property DescontarPeriodo As Decimal?

    Public Property TotalDescontado As Decimal?

    <DisplayFormat(DataFormatString:="{0:dd/MM/yyyy HH:mm:ss}", ApplyFormatInEditMode:=True)>
    Public Property FechaInicio As Date?

    <DisplayFormat(DataFormatString:="{0:dd/MM/yyyy HH:mm:ss}", ApplyFormatInEditMode:=True)>
    Public Property FechaFin As Date?

    <MaxLength(1)>
    Public Property Vigente As String

    Public Property NumCuotas As Integer?

    Public Property CuotaInicial As Integer?

    Public Property CuotaFinal As Integer?

    Public Property CuotaActual As Integer?

    Public Property AplicaLiquidaPeriodos As Boolean?

    Public Property AplicaLiquidaSemestres As Boolean?

    Public Property AplicaLiquidaExtraordinarias As Boolean?

    Public Property AplicaLiquidaContratos As Boolean?

    <MaxLength(20)>
    Public Property CtaContable As String

    <MaxLength(20)>
    Public Property DocContable As String
End Class