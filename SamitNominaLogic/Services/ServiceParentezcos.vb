Imports Newtonsoft.Json.Linq

Public Class ServiceParentezcos
    Public ListaErrores As New List(Of String)

    Public Function ValidarCampos(Parentescos As CAT_Parentesco) As Boolean
        ListaErrores.Clear() ' Limpiar errores anteriores

        If String.IsNullOrWhiteSpace(Parentescos.NomParentesco) Then
            ListaErrores.Add("El campo nombre no puede estar vacío")
        ElseIf IsNothing(Parentescos.Estado) Then
            ListaErrores.Add("El campo del estado no puede estar vacío")
        End If

        If ListaErrores.Count > 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function UpsertParentesco(Parentescos As CAT_Parentesco) As JArray
        Dim Peticion As New ParametrosApi()

        Dim fila As New JObject
        fila("NomParentesco") = Parentescos.NomParentesco
        fila("Sec") = Parentescos.Sec
        fila("Estado") = Parentescos.Estado

        Dim datos As New JArray()
        datos.Add(fila)

        ' Hacer la petición con el JArray como segundo parámetro
        Peticion.PostParametros("Parentescos", datos)

        Return datos
    End Function

    Public Function EliminarParesntesco(Parentescos As CAT_Parentesco) As JArray
        Dim Peticion As New ParametrosApi()

        ' Crear el objeto tipo JObject con los datos del banco
        Dim fila As New JObject()
        fila("NomParentesco") = Parentescos.NomParentesco
        fila("Sec") = Parentescos.Sec
        fila("Estado") = Parentescos.Estado
        fila("Eliminado") = 1
        ' Agrega aquí más campos si es necesario

        ' Crear el JArray y añadir la fila
        Dim datos As New JArray()
        datos.Add(fila)
        ' Hacer la petición con el JArray como segundo parámetro
        'Peticion.DeleteParametros("Parentescos", datos)
    End Function
End Class
