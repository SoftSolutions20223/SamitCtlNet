Imports System.ComponentModel.DataAnnotations

Public Class NominaLiquidaSemestres
    Public Property Sec As Integer

    <Required>
    Public Property Semestre As Integer

    <Required>
    Public Property OfiNomina As Integer

    <Required>
    Public Property OfiRegistra As Integer

    <Required(AllowEmptyStrings:=False)>
    <MaxLength(20)>
    Public Property UsuCrea As String

    <MaxLength(20)>
    Public Property UsuMod As String

    <Required>
    <DisplayFormat(DataFormatString:="{0:dd/MM/yyyy HH:mm:ss}", ApplyFormatInEditMode:=True)>
    Public Property FechaCrea As Date

    <DisplayFormat(DataFormatString:="{0:dd/MM/yyyy HH:mm:ss}", ApplyFormatInEditMode:=True)>
    Public Property FechaMod As Date?

    <Required(AllowEmptyStrings:=False)>
    <MaxLength(50)>
    Public Property TerminalCrea As String

    <MaxLength(50)>
    Public Property TerminalMod As String

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