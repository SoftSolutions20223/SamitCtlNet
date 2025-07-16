Imports System.ComponentModel.DataAnnotations

Public Class Empleados_HistoriaLaboral
    Public Property Sec As Integer

    <Required>
    Public Property Empleado As Integer

    <MaxLength(100)>
    Public Property Empresa As String

    <MaxLength(200)>
    Public Property Cargo As String

    <DisplayFormat(DataFormatString:="{0:dd/MM/yyyy HH:mm:ss}", ApplyFormatInEditMode:=True)>
    Public Property FechaIngreso As Date?

    <DisplayFormat(DataFormatString:="{0:dd/MM/yyyy HH:mm:ss}", ApplyFormatInEditMode:=True)>
    Public Property FechaRetiro As Date?

    <MaxLength(20)>
    Public Property TelEmpresa As String

    <MaxLength(50)>
    Public Property Direccion As String

    <MaxLength(50)>
    Public Property JefeInmediato As String

    Public Property ImgDocumento As String

End Class