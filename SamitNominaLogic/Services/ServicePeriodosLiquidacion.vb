Imports Newtonsoft.Json.Linq

Public Class ServicePeriodosLiquidacion
    Public ListaErrores As New List(Of String)

    Public Function ValidarCampos(PeriodoLiquidacion As PeriodosLiquidacion) As Boolean
        ListaErrores.Clear() ' Limpiar errores anteriores

        If String.IsNullOrWhiteSpace(PeriodoLiquidacion.Nomina) Then
            ListaErrores.Add("El campo nombre no puede estar vacío!..")
        End If

        If ListaErrores.Count > 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function UpsertPeriodoLiquidacion(PeriodoLiquidacion As PeriodosLiquidacion) As DynamicUpsertResponseDto
        Dim Peticion As New ParametrosApi()

        Dim fila As New JObject
        fila("Nomina") = PeriodoLiquidacion.Nomina
        fila("Sec") = PeriodoLiquidacion.Sec
        fila("Estado") = PeriodoLiquidacion.Estado
        fila("Semestre") = PeriodoLiquidacion.Semestre
        fila("FechaInicio") = PeriodoLiquidacion.FechaInicio
        fila("FechaFin") = PeriodoLiquidacion.FechaFin

        Dim datos As New JArray()
        datos.Add(fila)

        ' Hacer la petición con el JArray como segundo parámetro
        Dim res = Peticion.PostParametros("PeriodosLiquidacion", datos)

        Return res
    End Function
End Class
