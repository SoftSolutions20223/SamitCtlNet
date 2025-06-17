Imports System.ComponentModel.DataAnnotations

Public Class ConfigProvisiones
    Public Property Sec As Integer

    Public Property Concepto As Integer?

    <MaxLength(2000)>
    Public Property Formula As String

    <MaxLength(20)>
    Public Property SemestresLiquida As String

    <MaxLength(20)>
    Public Property CuentaContable As String

    Public Property Nomina As Integer?

End Class