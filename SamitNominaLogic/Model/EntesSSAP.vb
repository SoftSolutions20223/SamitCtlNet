Imports System.ComponentModel.DataAnnotations

Public Class EntesSSAP
    Public Property Sec As Integer

    <Required>
    Public Property TipoEnte As Integer

    <Required>
    Public Property CodEnte As Integer

    Public Property Nit As Long?

    <MaxLength(100)>
    Public Property NombreEntidad As String

    <Required(AllowEmptyStrings:=False)>
    <MaxLength(1)>
    Public Property Estado As String

    <Required(AllowEmptyStrings:=False)>
    <MaxLength(10)>
    Public Property CuentaPasivo As String

End Class