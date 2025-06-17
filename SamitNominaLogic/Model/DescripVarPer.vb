Imports System.ComponentModel.DataAnnotations

Public Class DescripVarPer
    Public Property Sec As Integer

    <DisplayFormat(DataFormatString:="{0:dd/MM/yyyy HH:mm:ss}", ApplyFormatInEditMode:=True)>
    Public Property FechaHoraInicio As Date?

    <DisplayFormat(DataFormatString:="{0:dd/MM/yyyy HH:mm:ss}", ApplyFormatInEditMode:=True)>
    Public Property FechaHoraFin As Date?

    Public Property Cantidad As Integer?

    <Required>
    Public Property CodVarP As Integer

    <MaxLength(10)>
    Public Property TipoDesc As String

    <MaxLength(200)>
    Public Property NomTipo As String

End Class