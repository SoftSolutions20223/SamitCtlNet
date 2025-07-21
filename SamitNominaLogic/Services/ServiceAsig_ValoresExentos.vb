Imports Newtonsoft.Json.Linq

Public Class ServiceAsig_ValoresExentos
    Public ListaErrores As New List(Of String)
    Public Function ValidarCampos(ValExento As Asig_ValoresExentos) As Boolean
        ListaErrores.Clear() ' Limpiar errores anteriores

        If String.IsNullOrWhiteSpace(ValExento.Contrato) Then
            ListaErrores.Add("El campo contrato no puede estar vacío!..")
        ElseIf IsNothing(ValExento.ValorExento) Then
            ListaErrores.Add("El campo valor exento no puede estar vacío!..")
        ElseIf IsNothing(ValExento.Vigente) Then
            ListaErrores.Add("El campo vigente no puede estar vacío!..")
        End If

        If ListaErrores.Count > 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function UpsertValExento(ValExento As Asig_ValoresExentos) As DynamicUpsertResponseDto
        Dim Peticion As New ParametrosApi()

        Dim fila As New JObject
        fila("Sec") = ValExento.Sec
        fila("Contrato") = ValExento.Contrato
        fila("Valor") = ValExento.Valor
        fila("ValorExento") = ValExento.ValorExento
        fila("Vigente") = ValExento.Vigente

        Dim datos As New JArray()
        datos.Add(fila)

        ' Hacer la petición con el JArray como segundo parámetro
        Dim res = Peticion.PostParametros("Asig_ValoresExentos", datos)

        Return res
    End Function

End Class
