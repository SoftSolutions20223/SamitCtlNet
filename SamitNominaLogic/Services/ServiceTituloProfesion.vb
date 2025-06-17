Imports Newtonsoft.Json.Linq

Public Class ServiceTituloProfesion
    Public ListaErrores As New List(Of String)

    Public Function ValidarCampos(TituloProfesion As CAT_Profesiones) As Boolean
        ListaErrores.Clear() ' Limpiar errores anteriores

        If String.IsNullOrWhiteSpace(TituloProfesion.NomProfesion) Then
            ListaErrores.Add("El campo nombre no puede estar vacío")
        ElseIf IsNothing(TituloProfesion.Vigente) Then
            ListaErrores.Add("El campo vigente no puede estar vacío")
        End If

        If ListaErrores.Count > 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function UpsertTituloProfesion(TituloProfesion As CAT_Profesiones) As JArray
        Dim Peticion As New ParametrosApi()

        Dim fila As New JObject
        fila("NomProfesion") = TituloProfesion.NomProfesion
        fila("Sec") = TituloProfesion.Sec
        fila("Vigente") = TituloProfesion.Vigente
        fila("IdNivelEducativo") = TituloProfesion.IdNivelEducativo

        Dim datos As New JArray()
        datos.Add(fila)

        ' Hacer la petición con el JArray como segundo parámetro
        Peticion.PostParametros("TituloProfesion", datos)

        Return datos
    End Function

    Public Function EliminarTituloProfesion(TituloProfesion As CAT_Profesiones) As JArray
        Dim Peticion As New ParametrosApi()

        ' Crear el objeto tipo JObject con los datos del banco
        Dim fila As New JObject()
        fila("NomProfesion") = TituloProfesion.NomProfesion
        fila("Sec") = TituloProfesion.Sec
        fila("Vigente") = TituloProfesion.Vigente
        fila("IdNivelEducativo") = TituloProfesion.IdNivelEducativo
        fila("Eliminado") = 1
        ' Agrega aquí más campos si es necesario

        ' Crear el JArray y añadir la fila
        Dim datos As New JArray()
        datos.Add(fila)
        ' Hacer la petición con el JArray como segundo parámetro
        'Peticion.DeleteParametros("TituloProfesion", datos)
    End Function
End Class
