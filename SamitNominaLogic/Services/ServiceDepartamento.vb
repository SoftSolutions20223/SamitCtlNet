Imports Newtonsoft.Json.Linq

Public Class ServiceDepartamento
    Public ListaErrores As New List(Of String)

    Public Function ValidarCampos(Departamentos As G_Departamento) As Boolean
        ListaErrores.Clear() ' Limpiar errores anteriores

        If String.IsNullOrWhiteSpace(Departamentos.NomDpto) Then
            ListaErrores.Add("El campo nombre de departamento no puede estar vacío")
        ElseIf IsNothing(Departamentos.Pais) Then
            ListaErrores.Add("El campo pais no puede estar vacío")
        ElseIf IsNothing(Departamentos.Sec) Then
            ListaErrores.Add("El campo del codigo de departamento no puede estar vacío")
        End If

        If ListaErrores.Count > 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function UpsertDepartamento(Departamentos As G_Departamento) As JArray
        Dim Peticion As New ParametrosApi()

        Dim fila As New JObject
        fila("NomDpto") = Departamentos.NomDpto
        fila("Sec") = Departamentos.Sec
        fila("Pais") = Departamentos.Pais
        fila("CodDpto") = Departamentos.Sec

        Dim datos As New JArray()
        datos.Add(fila)

        ' Hacer la petición con el JArray como segundo parámetro
        Peticion.PostParametros("Departamentos", datos)

        Return datos
    End Function

    Public Function EliminarDepartamento(Departamentos As G_Departamento) As JArray
        Dim Peticion As New ParametrosApi()

        ' Crear el objeto tipo JObject con los datos del banco
        Dim fila As New JObject()
        fila("NomDpto") = Departamentos.NomDpto
        fila("Sec") = Departamentos.Sec
        fila("Pais") = Departamentos.Pais
        fila("CodDpto") = Departamentos.Sec
        fila("Eliminado") = 1
        ' Agrega aquí más campos si es necesario

        ' Crear el JArray y añadir la fila
        Dim datos As New JArray()
        datos.Add(fila)
        ' Hacer la petición con el JArray como segundo parámetro
        'Peticion.DeleteParametros("Departamentos", datos)
    End Function
End Class
