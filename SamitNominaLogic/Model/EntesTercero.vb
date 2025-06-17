Imports System.ComponentModel.DataAnnotations

Public Class EntesTercero
    Public Property Sec As Integer

    <Required>
    Public Property Empleado As Integer

    <Required>
    <DisplayFormat(DataFormatString:="{0:dd/MM/yyyy HH:mm:ss}", ApplyFormatInEditMode:=True)>
    Public Property FechaRegistro As Date

    <DisplayFormat(DataFormatString:="{0:dd/MM/yyyy HH:mm:ss}", ApplyFormatInEditMode:=True)>
    Public Property FechaRetiro As Date?

    <Required>
    Public Property Retirado As Boolean

    <MaxLength(250)>
    Public Property CausadeRetiro As String

    Public Property SecEntesSSAP As Integer?

End Class