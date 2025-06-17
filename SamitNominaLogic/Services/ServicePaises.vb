Imports Newtonsoft.Json.Linq

Public Class ServicePaises
    Public ListaErrores As New List(Of String)

    Public Function ValidarCampos(Paises As G_Pais) As Boolean
        ListaErrores.Clear() ' Limpiar errores anteriores

        If String.IsNullOrWhiteSpace(Paises.NomPais) Then
            ListaErrores.Add("El campo nombre de pais no puede estar vacío")
        ElseIf IsNothing(Paises.CodIso) Then
            ListaErrores.Add("El campo del Iso no puede estar vacío")
        End If

        If ListaErrores.Count > 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function UpsertPais(Paises As G_Pais) As JArray
        Dim Peticion As New ParametrosApi()

        Dim fila As New JObject
        fila("NomPais") = Paises.NomPais
        fila("Sec") = Paises.Sec
        fila("CodIso") = Paises.CodIso

        Dim datos As New JArray()
        datos.Add(fila)

        ' Hacer la petición con el JArray como segundo parámetro
        Peticion.PostParametros("Paises", datos)

        Return datos
    End Function

    Public Function EliminarPais(Paises As G_Pais) As JArray
        Dim Peticion As New ParametrosApi()

        ' Crear el objeto tipo JObject con los datos del banco
        Dim fila As New JObject()
        fila("NomPais") = Paises.NomPais
        fila("Sec") = Paises.Sec
        fila("CodIso") = Paises.CodIso
        fila("Eliminado") = 1
        ' Agrega aquí más campos si es necesario

        ' Crear el JArray y añadir la fila
        Dim datos As New JArray()
        datos.Add(fila)
        ' Hacer la petición con el JArray como segundo parámetro
        'Peticion.DeleteParametros("Paises", datos)
    End Function
End Class
