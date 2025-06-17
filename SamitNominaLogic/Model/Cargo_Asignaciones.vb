Imports System.ComponentModel.DataAnnotations

Public Class Cargo_Asignaciones

    Public Property Sec As Integer

    <Required>
    <DisplayFormat(DataFormatString:="{0:dd/MM/yyyy HH:mm:ss}", ApplyFormatInEditMode:=True)>
    Public Property Fecha As Date

    <Required>
    Public Property Cargo As Integer

    Public Property Asignacion As Decimal?
End Class
