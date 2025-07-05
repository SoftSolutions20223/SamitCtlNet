Imports Newtonsoft.Json.Linq

Public Class ServiceConceptosP_Contratos
    Public ListaErrores As New List(Of String)

    Public Function ValidarCampos(ConceptoContrato As ConceptosP_Contratos) As Boolean
        ListaErrores.Clear() ' Limpiar errores anteriores

        If String.IsNullOrWhiteSpace(ConceptoContrato.Contrato) Then
            ListaErrores.Add("El campo Contrato no puede estar vacío!..")
        ElseIf String.IsNullOrWhiteSpace(ConceptoContrato.Concepto) Then
            ListaErrores.Add("El campo Concepto no puede estar vacío!..")
        ElseIf IsNothing(ConceptoContrato.Vigente) Then
            ListaErrores.Add("El campo Vigente no puede estar vacío!..")
        ElseIf String.IsNullOrWhiteSpace(ConceptoContrato.TotalDescontar) Then
            ListaErrores.Add("El campo Total a Descontar no puede estar vacío!..")
        ElseIf String.IsNullOrWhiteSpace(ConceptoContrato.NumCuotas) Then
            ListaErrores.Add("El campo Número de Cuotas no puede estar vacío!..")
        End If

        If ListaErrores.Count > 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function UpsertConceptosP_Contratos(ConceptoContrato As ConceptosP_Contratos) As DynamicUpsertResponseDto
        Dim Peticion As New ParametrosApi()
        Dim fila As New JObject

        fila("Sec") = ConceptoContrato.Sec
        fila("Contrato") = ConceptoContrato.Contrato
        fila("Concepto") = ConceptoContrato.Concepto
        fila("TotalDescontar") = ConceptoContrato.TotalDescontar
        fila("DescontarPeriodo") = ConceptoContrato.DescontarPeriodo
        fila("TotalDescontado") = ConceptoContrato.TotalDescontado
        fila("FechaInicio") = ConceptoContrato.FechaInicio
        fila("FechaFin") = ConceptoContrato.FechaFin
        fila("Vigente") = ConceptoContrato.Vigente
        fila("NumCuotas") = ConceptoContrato.NumCuotas
        fila("CuotaInicial") = ConceptoContrato.CuotaInicial
        fila("CuotaFinal") = ConceptoContrato.CuotaFinal
        fila("CuotaActual") = ConceptoContrato.CuotaActual
        fila("AplicaLiquidaPeriodos") = ConceptoContrato.AplicaLiquidaPeriodos
        fila("AplicaLiquidaSemestres") = ConceptoContrato.AplicaLiquidaSemestres
        fila("AplicaLiquidaExtraordinarias") = ConceptoContrato.AplicaLiquidaExtraordinarias
        fila("AplicaLiquidaContratos") = ConceptoContrato.AplicaLiquidaContratos
        fila("CtaContable") = ConceptoContrato.CtaContable
        fila("DocContable") = ConceptoContrato.DocContable

        Dim datos As New JArray()
        datos.Add(fila)

        ' Hacer la petición con el JArray como segundo parámetro
        Dim res = Peticion.PostParametros("ConceptosP_Contratos", datos)
        Return res
    End Function

    Public Function EliminarConceptosP_Contratos(ConceptoContrato As ConceptosP_Contratos) As JArray
        Dim Peticion As New ParametrosApi()

        ' Crear el objeto tipo JObject con los datos
        Dim fila As New JObject()
        fila("Sec") = ConceptoContrato.Sec
        fila("Contrato") = ConceptoContrato.Contrato
        fila("Concepto") = ConceptoContrato.Concepto
        fila("TotalDescontar") = ConceptoContrato.TotalDescontar
        fila("DescontarPeriodo") = ConceptoContrato.DescontarPeriodo
        fila("TotalDescontado") = ConceptoContrato.TotalDescontado
        fila("FechaInicio") = ConceptoContrato.FechaInicio
        fila("FechaFin") = ConceptoContrato.FechaFin
        fila("Vigente") = ConceptoContrato.Vigente
        fila("NumCuotas") = ConceptoContrato.NumCuotas
        fila("CuotaInicial") = ConceptoContrato.CuotaInicial
        fila("CuotaFinal") = ConceptoContrato.CuotaFinal
        fila("CuotaActual") = ConceptoContrato.CuotaActual
        fila("AplicaLiquidaPeriodos") = ConceptoContrato.AplicaLiquidaPeriodos
        fila("AplicaLiquidaSemestres") = ConceptoContrato.AplicaLiquidaSemestres
        fila("AplicaLiquidaExtraordinarias") = ConceptoContrato.AplicaLiquidaExtraordinarias
        fila("AplicaLiquidaContratos") = ConceptoContrato.AplicaLiquidaContratos
        fila("CtaContable") = ConceptoContrato.CtaContable
        fila("DocContable") = ConceptoContrato.DocContable
        fila("Eliminado") = 1

        ' Crear el JArray y añadir la fila
        Dim datos As New JArray()
        datos.Add(fila)

        ' Hacer la petición con el JArray como segundo parámetro
        'Peticion.DeleteParametros("ConceptosP_Contratos", datos)
    End Function
End Class