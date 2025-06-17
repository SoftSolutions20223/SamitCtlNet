Imports Newtonsoft.Json.Linq

Public Class ServiceContratos
    Public Property ListaErrores As New List(Of String)

    ''' <summary>
    ''' Valida campos esenciales de Contratos.
    ''' </summary>
    Public Function ValidarContrato(c As Contratos) As Boolean
        ListaErrores.Clear()
        If c.CodContrato <= 0 Then ListaErrores.Add("El campo CodContrato es obligatorio.")
        If Not c.Empleado.HasValue Then ListaErrores.Add("El campo Empleado es obligatorio.")
        If Not c.FechaInicio.HasValue Then ListaErrores.Add("El campo FechaInicio es obligatorio.")
        ' Agrega más validaciones según sea necesario
        Return (ListaErrores.Count = 0)
    End Function

    ''' <summary>
    ''' Inserta o actualiza un Contrato.
    ''' </summary>
    Public Function UpsertContrato(c As Contratos) As JArray
        If Not ValidarContrato(c) Then Return Nothing
        Dim fila As New JObject From {
            {"Sec", If(c.Sec.HasValue, c.Sec.Value, CType(Nothing, Object))},
            {"Oficina", If(c.Oficina.HasValue, c.Oficina.Value, CType(Nothing, Object))},
            {"CodContrato", c.CodContrato},
            {"Empleado", If(c.Empleado.HasValue, c.Empleado.Value, CType(Nothing, Object))},
            {"TipoContrato", If(c.TipoContrato.HasValue, c.TipoContrato.Value, CType(Nothing, Object))},
            {"HorasMes", If(c.HorasMes.HasValue, c.HorasMes.Value, CType(Nothing, Object))},
            {"FechaInicio", If(c.FechaInicio.HasValue, c.FechaInicio.Value.ToString("yyyy-MM-ddTHH:mm:ss"), CType(Nothing, Object))},
            {"FechaFin", If(c.FechaFin.HasValue, c.FechaFin.Value.ToString("yyyy-MM-ddTHH:mm:ss"), CType(Nothing, Object))},
            {"Dependencia", If(c.Dependencia.HasValue, c.Dependencia.Value, CType(Nothing, Object))},
            {"Aprendiz", If(c.Aprendiz.HasValue, c.Aprendiz.Value, CType(Nothing, Object))},
            {"Terminado", If(c.Terminado.HasValue, c.Terminado.Value, CType(Nothing, Object))},
            {"Plantilla", If(c.Plantilla.HasValue, c.Plantilla.Value, CType(Nothing, Object))},
            {"Nomina", If(c.Nomina.HasValue, c.Nomina.Value, CType(Nothing, Object))},
            {"CargoActual", If(c.CargoActual.HasValue, c.CargoActual.Value, CType(Nothing, Object))},
            {"Asignacion", If(c.Asignacion.HasValue, JToken.FromObject(c.Asignacion.Value), JValue.CreateNull())},
            {"IdContrato", If(c.IdContrato, "")},
            {"ValorExento", If(c.ValorExento.HasValue, JToken.FromObject(c.ValorExento.Value), JValue.CreateNull())},
            {"AsignacionCargo", If(c.AsignacionCargo, "")},
            {"FechaLiquidacion", If(c.FechaLiquidacion.HasValue, c.FechaLiquidacion.Value.ToString("yyyy-MM-ddTHH:mm:ss"), CType(Nothing, Object))},
            {"UsaAsginaCargo", If(c.UsaAsginaCargo.HasValue, c.UsaAsginaCargo.Value, CType(Nothing, Object))},
            {"TipoTrabajador", If(c.TipoTrabajador, "")},
            {"SubTipoTrabajador", If(c.SubTipoTrabajador, "")},
            {"SalarioIntegral", If(c.SalarioIntegral, "")},
            {"PerfilCuentas", If(c.PerfilCuentas.HasValue, c.PerfilCuentas.Value, CType(Nothing, Object))}
        }
        Dim datos As New JArray() From {fila}
        Dim peticion As New ParametrosApi()
        peticion.PostParametros("Contratos", datos)
        Return datos
    End Function

    ''' <summary>
    ''' Valida los campos de Contrato_Cargos.
    ''' </summary>
    Public Function ValidarContratoCargos(cc As Contrato_Cargos) As Boolean
        ListaErrores.Clear()
        If cc.Contrato <= 0 Then ListaErrores.Add("El campo Contrato es obligatorio.")
        If cc.Cargo <= 0 Then ListaErrores.Add("El campo Cargo es obligatorio.")
        If cc.FechaInicio = Date.MinValue Then ListaErrores.Add("El campo FechaInicio es obligatorio.")
        Return (ListaErrores.Count = 0)
    End Function

    ''' <summary>
    ''' Inserta o actualiza un Contrato_Cargos.
    ''' </summary>
    ''' <summary>
    ''' Inserta o actualiza un Contrato_Cargos.
    ''' </summary>
    Public Function UpsertContratoCargos(cc As Contrato_Cargos) As JArray
        If Not ValidarContratoCargos(cc) Then Return Nothing
        Dim fila As New JObject From {
            {"Sec", cc.Sec},
            {"Contrato", cc.Contrato},
            {"Cargo", cc.Cargo},
            {"FechaInicio", cc.FechaInicio.ToString("yyyy-MM-ddTHH:mm:ss")},
            {"FechaFin", If(cc.FechaFin.HasValue, cc.FechaFin.Value.ToString("yyyy-MM-ddTHH:mm:ss"), CType(Nothing, Object))},
            {"UsrRegistra", If(cc.UsrRegistra, "")},
            {"FechaRegistro", If(cc.FechaRegistro.HasValue, cc.FechaRegistro.Value.ToString("yyyy-MM-ddTHH:mm:ss"), CType(Nothing, Object))},
            {"TerminalRegistra", If(cc.TerminalRegistra, "")}
        }
        Dim datos As New JArray() From {fila}
        Dim peticion As New ParametrosApi()
        peticion.PostParametros("Contrato_Cargos", datos)
        Return datos
    End Function

    ''' <summary>
    ''' Valida los campos de Contratos_CentroCostos.
    ''' </summary>
    ''' <summary>
    ''' Valida los campos de Contratos_CentroCostos.
    ''' </summary>
    Public Function ValidarCentroCostos(cc As Contratos_CentroCostos) As Boolean
        ListaErrores.Clear()
        If Not cc.Contrato.HasValue OrElse cc.Contrato.Value <= 0 Then
            ListaErrores.Add("El campo Contrato es obligatorio.")
        End If
        If Not cc.CentroCosto.HasValue OrElse cc.CentroCosto.Value <= 0 Then
            ListaErrores.Add("El campo CentroCosto es obligatorio.")
        End If
        Return (ListaErrores.Count = 0)
    End Function

    ''' <summary>
    ''' Inserta o actualiza un Contratos_CentroCostos.
    ''' </summary>
    Public Function UpsertCentroCostos(cc As Contratos_CentroCostos) As JArray
        If Not ValidarCentroCostos(cc) Then Return Nothing
        Dim fila As New JObject From {
            {"Sec", cc.Sec},
            {"Contrato", cc.Contrato},
            {"CentroCosto", cc.CentroCosto},
            {"Porcentaje", If(cc.Porcentaje.HasValue, JToken.FromObject(cc.Porcentaje.Value), JValue.CreateNull())}
        }
        Dim datos As New JArray() From {fila}
        Dim peticion As New ParametrosApi()
        peticion.PostParametros("Contratos_CentroCostos", datos)
        Return datos
    End Function
End Class
