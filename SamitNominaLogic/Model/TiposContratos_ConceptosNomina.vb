Imports System.ComponentModel.DataAnnotations

Public Class TiposContratos_ConceptosNomina
    Public Property Sec As Integer

    Public Property Concepto As Integer?

    Public Property TipoContrato As Integer?

    <MaxLength(2000)>
    Public Property Formula As String

    <MaxLength(200)>
    Public Property BaseCalculo As String

    Public Property SeLiquida As Boolean?

    <MaxLength(20)>
    Public Property CuentaContable As String

End Class