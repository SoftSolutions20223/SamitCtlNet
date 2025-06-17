Imports System.ComponentModel.DataAnnotations

Public Class NominaLiquidada
    Public Property Sec As Integer

    <Required>
    Public Property Periodo As Integer

    <Required>
    Public Property OfiNomina As Integer

    <Required>
    Public Property OfiRegistra As Integer

    <Required(AllowEmptyStrings:=False)>
    <MaxLength(20)>
    Public Property UsuCrea As String

    <Required>
    <DisplayFormat(DataFormatString:="{0:dd/MM/yyyy HH:mm:ss}", ApplyFormatInEditMode:=True)>
    Public Property FechaCrea As Date

    <Required(AllowEmptyStrings:=False)>
    <MaxLength(50)>
    Public Property TerminalCrea As String

    <Required>
    <DisplayFormat(DataFormatString:="{0:dd/MM/yyyy HH:mm:ss}", ApplyFormatInEditMode:=True)>
    Public Property FechaSys As Date

    <MaxLength(10)>
    Public Property Estado As String

    Public Property Contabilizada As Boolean?

    <MaxLength(20)>
    Public Property FormaDePago As String

    <MaxLength(50)>
    Public Property DocContable As String

End Class