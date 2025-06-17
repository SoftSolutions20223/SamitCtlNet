Imports System.ComponentModel.DataAnnotations

Public Class Conceptos_PerfilCta
    Public Property Sec As Integer

    Public Property Concepto As Integer?

    <MaxLength(20)>
    Public Property CuentaContable As String

    Public Property ConceptoR As Integer?

    <MaxLength(20)>
    Public Property ContraPartida As String

    Public Property PerfilCta As Integer?

    <MaxLength(1)>
    Public Property Naturaleza As String
End Class