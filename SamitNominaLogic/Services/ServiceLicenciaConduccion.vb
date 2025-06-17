Imports Newtonsoft.Json.Linq

Public Class ServiceLicenciaConduccion
    Public ListaErrores As New List(Of String)

    Public Function ValidarCampos(LicenciaConduccion As CAT_ClaseLicencia) As Boolean
        ListaErrores.Clear() ' Limpiar errores anteriores

        If String.IsNullOrWhiteSpace(LicenciaConduccion.NomClase) Then
            ListaErrores.Add("El campo nombre no puede estar vacío")
        ElseIf IsNothing(LicenciaConduccion.Vigente) Then
            ListaErrores.Add("El campo vigente no puede estar vacío")
        End If

        If ListaErrores.Count > 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function UpsertLicenciaConduccion(LicenciaConduccion As CAT_ClaseLicencia) As JArray
        Dim Peticion As New ParametrosApi()

        Dim fila As New JObject
        fila("NomClase") = LicenciaConduccion.NomClase
        fila("Sec") = LicenciaConduccion.Sec
        fila("Vigente") = LicenciaConduccion.Vigente
        fila("idClase") = LicenciaConduccion.idClase

        Dim datos As New JArray()
        datos.Add(fila)

        ' Hacer la petición con el JArray como segundo parámetro
        Peticion.PostParametros("LicenciaConduccion", datos)

        Return datos
    End Function
    Public Function EliminarLicenciaConduccion(LicenciaConduccion As CAT_ClaseLicencia) As JArray
        Dim Peticion As New ParametrosApi()

        ' Crear el objeto tipo JObject con los datos del banco
        Dim fila As New JObject()
        fila("NomClase") = LicenciaConduccion.NomClase
        fila("Sec") = LicenciaConduccion.Sec
        fila("Vigente") = LicenciaConduccion.Vigente
        fila("idClase") = LicenciaConduccion.idClase
        fila("Eliminado") = 1
        ' Agrega aquí más campos si es necesario

        ' Crear el JArray y añadir la fila
        Dim datos As New JArray()
        datos.Add(fila)
        ' Hacer la petición con el JArray como segundo parámetro
        'Peticion.DeleteParametros("LicenciaConduccion", datos)
    End Function
End Class
