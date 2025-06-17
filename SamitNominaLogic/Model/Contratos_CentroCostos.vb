Imports System.ComponentModel.DataAnnotations

Public Class Contratos_CentroCostos
    Public Property Sec As Integer

    Public Property Contrato As Integer?

    Public Property CentroCosto As Integer?

    <Range(-1.0E+17, 1.0E+17)>
    <DisplayFormat(DataFormatString:="{0:c2}", ApplyFormatInEditMode:=True)>
    Public Property Porcentaje As Decimal?
End Class