Imports Newtonsoft.Json.Linq

Public Class ServiceTipoDocumentos
    Public ListaErrores As New List(Of String)

    Public Function ValidarCampos(TipoDocumentos As CAT_TiposId) As Boolean
        ListaErrores.Clear() ' Limpiar errores anteriores

        If String.IsNullOrWhiteSpace(TipoDocumentos.NomTipo) Then
            ListaErrores.Add("El nombre del tipo de documento no puede estar vacío!")
        ElseIf IsNothing(TipoDocumentos.TipoIdentificacion) Then
            ListaErrores.Add("El ID del tipo de documento no puede estar vacío!")
        End If

        If ListaErrores.Count > 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function UpsertTipoDoc(TipoDocumentos As CAT_TiposId) As JArray
        Dim Peticion As New ParametrosApi()

        Dim fila As New JObject
        fila("NomTipo") = TipoDocumentos.NomTipo
        fila("Sec") = TipoDocumentos.Sec
        fila("TipoIdentificacion") = TipoDocumentos.TipoIdentificacion
        fila("UsaEmpleados") = TipoDocumentos.UsaEmpleados
        fila("UsaEmpleados") = TipoDocumentos.UsaParientes

        Dim datos As New JArray()
        datos.Add(fila)

        ' Hacer la petición con el JArray como segundo parámetro
        Peticion.PostParametros("TipoDocumentos", datos)

        Return datos
    End Function

    Public Function EliminarTipoDoc(TipoDocumentos As CAT_TiposId) As JArray
        Dim Peticion As New ParametrosApi()

        ' Crear el objeto tipo JObject con los datos del banco
        Dim fila As New JObject()
        fila("NomTipo") = TipoDocumentos.NomTipo
        fila("Sec") = TipoDocumentos.Sec
        fila("TipoIdentificacion") = TipoDocumentos.TipoIdentificacion
        fila("UsaEmpleados") = TipoDocumentos.UsaEmpleados
        fila("UsaEmpleados") = TipoDocumentos.UsaParientes
        fila("Eliminado") = 1
        ' Agrega aquí más campos si es necesario

        ' Crear el JArray y añadir la fila
        Dim datos As New JArray()
        datos.Add(fila)
        ' Hacer la petición con el JArray como segundo parámetro
        'Peticion.DeleteParametros("TipoDocumentos", datos)
    End Function
End Class
