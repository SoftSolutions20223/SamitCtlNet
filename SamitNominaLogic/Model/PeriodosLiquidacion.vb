Imports System.ComponentModel.DataAnnotations
Imports Newtonsoft.Json

Public Class PeriodosLiquidacion
    Public Property Sec As Integer

    <MaxLength(50)>
    Public Property Descripcion As String

    <DisplayFormat(DataFormatString:="{0:dd/MM/yyyy HH:mm:ss}", ApplyFormatInEditMode:=True)>
    Public Property FechaInicio As Date?

    <DisplayFormat(DataFormatString:="{0:dd/MM/yyyy HH:mm:ss}", ApplyFormatInEditMode:=True)>
    Public Property FechaFin As Date?

    <MaxLength(1)>
    Public Property Estado As String

    Public Property Nomina As Integer?


    Public Property Año As Integer

    Public Property PeriodoMes As Integer?

    Public Property NumPeriodoNom As Integer?

    Public Property CodPeriodo As Integer?

    Public Property NumMes As Integer?

    Public Property Semestre As Integer?

End Class