Imports System.ComponentModel.DataAnnotations

Public Class ConfigConceptos
    Public Property Sec As Integer

    Public Property Nomina As Integer?

    Public Property Concepto As Integer?

    <MaxLength(2000)>
    Public Property Formula As String

    <MaxLength(20)>
    Public Property PeriodosLiquida As String

    <MaxLength(20)>
    Public Property CuentaContable As String

    Public Property ConceptoR As Integer?

    <MaxLength(20)>
    Public Property ContraPartida As String
End Class