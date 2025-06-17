Imports Newtonsoft.Json.Linq

Public Class ServiceTipoContrato
    Public ListaErrores As New List(Of String)

    Public Function ValidarCampos(TipoContratos As CAT_TipoContratos) As Boolean
        ListaErrores.Clear() ' Limpiar errores anteriores

        If String.IsNullOrWhiteSpace(TipoContratos.NomTipo) Then
            ListaErrores.Add("El campo nombre no puede estar vacío!..")
        End If

        If ListaErrores.Count > 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function UpsertTipoContrato(TipoContratos As CAT_TipoContratos) As DynamicUpsertResponseDto
        Dim Peticion As New ParametrosApi()

        Dim fila As New JObject
        fila("NomNomina") = TipoContratos.NomTipo
        fila("Sec") = TipoContratos.Sec

        Dim datos As New JArray()
        datos.Add(fila)

        ' Hacer la petición con el JArray como segundo parámetro
        Dim res = Peticion.PostParametros("CAT_TipoContratos", datos)

        Return res
    End Function

    Public Function EliminarTipoContrato(TipoContratos As CAT_TipoContratos) As JArray
        Dim Peticion As New ParametrosApi()

        ' Crear el objeto tipo JObject con los datos del banco
        Dim fila As New JObject()
        fila("NomNomina") = TipoContratos.NomTipo
        fila("Sec") = TipoContratos.Sec
        fila("Eliminado") = 1
        ' Agrega aquí más campos si es necesario

        ' Crear el JArray y añadir la fila
        Dim datos As New JArray()
        datos.Add(fila)
        ' Hacer la petición con el JArray como segundo parámetro
        'Peticion.DeleteParametros("TipoContratos", datos)
    End Function
End Class
