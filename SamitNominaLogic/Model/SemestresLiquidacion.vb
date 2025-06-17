Imports System.ComponentModel.DataAnnotations
Imports Newtonsoft.Json

Public Class SemestresLiquidacion
    Public Property Sec As Integer

    Public Property Semestre As Integer?

    Public Property Año As Integer?

    <DisplayFormat(DataFormatString:="{0:dd/MM/yyyy HH:mm:ss}", ApplyFormatInEditMode:=True)>
    Public Property FechaInicio As Date?

    <DisplayFormat(DataFormatString:="{0:dd/MM/yyyy HH:mm:ss}", ApplyFormatInEditMode:=True)>
    Public Property FechaFin As Date?

    <MaxLength(1)>
    Public Property Estado As String

    Public Property Nomina As Integer?

End Class