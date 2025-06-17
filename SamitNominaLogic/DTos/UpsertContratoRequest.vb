Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class UpsertContratoRequest
    ' Datos del contrato principal
    Public Property Contrato As Contratos

    ' Identificación del empleado (para búsqueda)
    Public Property IdentificacionEmpleado As Long

    ' Datos adicionales para el procedimiento
    Public Property Usuario As String
    Public Property Terminal As String

    ' Listas relacionadas
    Public Property CentrosCosto As List(Of Contratos_CentroCostos)
    Public Property Cargos As List(Of Contrato_Cargos)

    Public Sub New()
        Contrato = New Contratos()
        CentrosCosto = New List(Of Contratos_CentroCostos)()
        Cargos = New List(Of Contrato_Cargos)()
        Terminal = Environment.MachineName
    End Sub


    ' En UpsertContratoRequest.vb
    Public Function ToJObject() As JObject
        ' Crear objeto anónimo con fechas en formato dd/MM/yyyy
        Dim jsonObject = New With {
        .Sec = Contrato.Sec,
        .Oficina = Contrato.Oficina,
        .CodContrato = Contrato.CodContrato,
        .IdentificacionEmpleado = IdentificacionEmpleado,
        .TipoContrato = Contrato.TipoContrato,
        .HorasMes = Contrato.HorasMes,
        .FechaInicio = Contrato.FechaInicio?.ToString("dd/MM/yyyy HH:mm:ss"),
        .FechaFin = Contrato.FechaFin?.ToString("dd/MM/yyyy HH:mm:ss"),
        .Dependencia = Contrato.Dependencia,
        .Plantilla = Contrato.Plantilla,
        .PerfilCuentas = Contrato.PerfilCuentas,
        .Nomina = Contrato.Nomina,
        .Asignacion = Contrato.Asignacion,
        .IdContrato = Contrato.IdContrato,
        .AsignacionCargo = Contrato.AsignacionCargo,
        .UsaAsginaCargo = Contrato.UsaAsginaCargo,
        .TipoTrabajador = Contrato.TipoTrabajador,
        .SubTipoTrabajador = Contrato.SubTipoTrabajador,
        .SalarioIntegral = Contrato.SalarioIntegral,
        .Usuario = Usuario,
        .Terminal = Terminal,
        .CentrosCosto = CentrosCosto.Select(Function(cc) New With {
            .CentroCosto = cc.CentroCosto,
            .Porcentaje = cc.Porcentaje
        }).ToList(),
        .Cargos = Cargos.Select(Function(c) New With {
            .Cargo = c.Cargo,
            .FechaInicio = c.FechaInicio.ToString("dd/MM/yyyy HH:mm:ss"),
            .FechaFin = c.FechaFin?.ToString("dd/MM/yyyy HH:mm:ss")
        }).ToList()
    }

        Return JObject.FromObject(jsonObject)
    End Function

    ''' <summary>
    ''' Método auxiliar para obtener el JSON como string si se necesita
    ''' </summary>
    Public Function ToJsonString() As String
        Return ToJObject().ToString(Formatting.None)
    End Function
End Class
