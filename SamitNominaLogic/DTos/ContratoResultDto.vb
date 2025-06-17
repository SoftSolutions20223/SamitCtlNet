Public Class ContratoResultDto
    Public Property Sec As Integer
    Public Property CodContrato As Integer
    Public Property Empleado As Integer
    Public Property IdentificacionEmpleado As Long
    Public Property NombreEmpleado As String
    Public Property FechaInicio As DateTime
    Public Property FechaFin As DateTime?
    Public Property Asignacion As Decimal
    Public Property CargoActual As Integer?
    Public Property CentrosCosto As List(Of CentroCostoResultDto)
    Public Property Cargos As List(Of CargoResultDto)

    Public Sub New()
        CentrosCosto = New List(Of CentroCostoResultDto)()
        Cargos = New List(Of CargoResultDto)()
    End Sub

    ' Método para convertir a las clases del modelo
    Public Function ToContrato() As Contratos
        Return New Contratos With {
            .Sec = Sec,
            .CodContrato = CodContrato,
            .Empleado = Empleado,
            .FechaInicio = FechaInicio,
            .FechaFin = FechaFin,
            .Asignacion = Asignacion,
            .CargoActual = CargoActual
        }
    End Function

    Public Function ToCentrosCosto() As List(Of Contratos_CentroCostos)
        Return CentrosCosto.Select(Function(cc) New Contratos_CentroCostos With {
            .Sec = cc.Sec,
            .Contrato = Sec,
            .CentroCosto = cc.CentroCosto,
            .Porcentaje = cc.Porcentaje
        }).ToList()
    End Function

    Public Function ToCargos() As List(Of Contrato_Cargos)
        Return Cargos.Select(Function(c) New Contrato_Cargos With {
            .Sec = c.Sec,
            .Contrato = Sec,
            .Cargo = c.Cargo,
            .FechaInicio = c.FechaInicio,
            .FechaFin = c.FechaFin
        }).ToList()
    End Function
End Class
