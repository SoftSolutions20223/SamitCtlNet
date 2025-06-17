Imports System.ComponentModel.DataAnnotations

Public Class CT_CentroCostos
    Public Property Sec As Integer?

    <Required(AllowEmptyStrings:=False)>
    <MaxLength(30)>
    Public Property Nom_CentroCosto As String

    <Required>
    Public Property Responsable As Long

    <Required(AllowEmptyStrings:=False)>
    <MaxLength(1)>
    Public Property Estado As String

    Public Property LimitaUso As Boolean?

    <DisplayFormat(DataFormatString:="{0:dd/MM/yyyy HH:mm:ss}", ApplyFormatInEditMode:=True)>
    Public Property FechaIniLimite As Date?

    <DisplayFormat(DataFormatString:="{0:dd/MM/yyyy HH:mm:ss}", ApplyFormatInEditMode:=True)>
    Public Property FechaFinLimite As Date?

End Class