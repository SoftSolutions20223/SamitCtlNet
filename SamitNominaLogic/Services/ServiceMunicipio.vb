Imports Newtonsoft.Json.Linq

Public Class ServiceMunicipio
    Public ListaErrores As New List(Of String)

    Public Function ValidarCampos(Municipios As G_Municipio) As Boolean
        ListaErrores.Clear() ' Limpiar errores anteriores

        If String.IsNullOrWhiteSpace(Municipios.NombreMunicipio) Then
            ListaErrores.Add("El campo del nombre de municipio no puede estar vacío")
        ElseIf IsNothing(Municipios.Departamento) Then
            ListaErrores.Add("Por favor seleccione el departamento!")
        ElseIf IsNothing(Municipios.IdMunicipio) Then
            ListaErrores.Add("El id del municipio no puede estar vacío!")
        ElseIf IsNothing(Municipios.Sec) Then
            ListaErrores.Add("El código del municipio no puede estar vacío")
        End If

        If ListaErrores.Count > 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function UpsertMunicipio(Municipios As G_Municipio) As JArray
        Dim Peticion As New ParametrosApi()

        Dim fila As New JObject
        fila("NombreMunicipio") = Municipios.NombreMunicipio
        fila("Sec") = Municipios.Sec
        fila("Departamento") = Municipios.Departamento
        fila("IdMunicipio") = Municipios.IdMunicipio
        fila("CodMunicipio") = Municipios.Sec

        Dim datos As New JArray()
        datos.Add(fila)

        ' Hacer la petición con el JArray como segundo parámetro
        Peticion.PostParametros("Municipios", datos)

        Return datos
    End Function

    Public Function EliminarMunicipio(Municipios As G_Municipio) As JArray
        Dim Peticion As New ParametrosApi()

        ' Crear el objeto tipo JObject con los datos del banco
        Dim fila As New JObject()
        fila("NombreMunicipio") = Municipios.NombreMunicipio
        fila("Sec") = Municipios.Sec
        fila("Departamento") = Municipios.Departamento
        fila("IdMunicipio") = Municipios.IdMunicipio
        fila("CodMunicipio") = Municipios.Sec
        fila("Eliminado") = 1
        ' Agrega aquí más campos si es necesario

        ' Crear el JArray y añadir la fila
        Dim datos As New JArray()
        datos.Add(fila)
        ' Hacer la petición con el JArray como segundo parámetro
        'Peticion.DeleteParametros("Municipios", datos)
    End Function
End Class
