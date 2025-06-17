Imports System.ComponentModel.DataAnnotations

Public Class Contratos
    Public Property Sec As Integer?

    Public Property Oficina As Integer?

    <Required>
    Public Property CodContrato As Integer

    Public Property Empleado As Integer?

    Public Property TipoContrato As Integer?

    Public Property HorasMes As Integer?

    <DisplayFormat(DataFormatString:="{0:dd/MM/yyyy HH:mm:ss}", ApplyFormatInEditMode:=True)>
    Public Property FechaInicio As Date?

    <DisplayFormat(DataFormatString:="{0:dd/MM/yyyy HH:mm:ss}", ApplyFormatInEditMode:=True)>
    Public Property FechaFin As Date?

    Public Property Dependencia As Integer?

    Public Property Aprendiz As Boolean?

    Public Property Terminado As Boolean?

    Public Property Plantilla As Integer?

    Public Property Nomina As Integer?

    Public Property CargoActual As Integer?

    Public Property Asignacion As Decimal?

    <MaxLength(50)>
    Public Property IdContrato As String

    Public Property ValorExento As Decimal?

    <MaxLength(1)>
    Public Property AsignacionCargo As String

    <DisplayFormat(DataFormatString:="{0:dd/MM/yyyy HH:mm:ss}", ApplyFormatInEditMode:=True)>
    Public Property FechaLiquidacion As Date?

    Public Property UsaAsginaCargo As Boolean?

    <MaxLength(10)>
    Public Property TipoTrabajador As String

    <MaxLength(10)>
    Public Property SubTipoTrabajador As String

    <MaxLength(10)>
    Public Property SalarioIntegral As String

    Public Property PerfilCuentas As Integer?
End Class
