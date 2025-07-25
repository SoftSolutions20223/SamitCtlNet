﻿Imports Newtonsoft.Json.Linq

Public Class ServiceValExentos
    Public ListaErrores As New List(Of String)

    Public Function ValidarCampos(ValExento As ValoresExentos) As Boolean
        ListaErrores.Clear() ' Limpiar errores anteriores

        If String.IsNullOrWhiteSpace(ValExento.Nom) Then
            ListaErrores.Add("El campo nombre no puede estar vacío!..")
        ElseIf IsNothing(ValExento.Vigente) Then
            ListaErrores.Add("El campo vigente no puede estar vacío!..")
        End If

        If ListaErrores.Count > 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function UpsertValExento(ValExento As ValoresExentos) As DynamicUpsertResponseDto
        Dim Peticion As New ParametrosApi()

        Dim fila As New JObject
        fila("Nom") = ValExento.Nom
        fila("Sec") = ValExento.Sec
        fila("Vigente") = ValExento.Vigente
        fila("TipoValor") = ValExento.TipoValor

        Dim datos As New JArray()
        datos.Add(fila)

        ' Hacer la petición con el JArray como segundo parámetro
        Dim res = Peticion.PostParametros("ValoresExentos", datos)

        Return res
    End Function

End Class
