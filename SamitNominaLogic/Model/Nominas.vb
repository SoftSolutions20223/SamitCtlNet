Imports System.ComponentModel.DataAnnotations

Public Class Nominas
    Public Property Sec As Integer

    <MaxLength(50)>
    Public Property NomNomina As String

    Public Property FormaLiquida As Integer?

    <DisplayFormat(DataFormatString:="{0:dd/MM/yyyy HH:mm:ss}", ApplyFormatInEditMode:=True)>
    Public Property Fecha As Date?

    Public Property Oficina As Integer?

End Class