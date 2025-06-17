Imports System.ComponentModel.DataAnnotations

Public Class Contrato_Cargos
    Public Property Sec As Integer

    <Required>
    Public Property Contrato As Integer

    <Required>
    Public Property Cargo As Integer

    <Required>
    <DisplayFormat(DataFormatString:="{0:dd/MM/yyyy HH:mm:ss}", ApplyFormatInEditMode:=True)>
    Public Property FechaInicio As Date

    <DisplayFormat(DataFormatString:="{0:dd/MM/yyyy HH:mm:ss}", ApplyFormatInEditMode:=True)>
    Public Property FechaFin As Date?

    <MaxLength(20)>
    Public Property UsrRegistra As String

    <DisplayFormat(DataFormatString:="{0:dd/MM/yyyy HH:mm:ss}", ApplyFormatInEditMode:=True)>
    Public Property FechaRegistro As Date?

    <MaxLength(50)>
    Public Property TerminalRegistra As String
End Class