Imports Newtonsoft.Json.Linq

Public Class ServiceNivelEducativo
    Public ListaErrores As New List(Of String)

    Public Function ValidarCampos(NivelEducativo As CAT_NivelEducativo) As Boolean
        ListaErrores.Clear() ' Limpiar errores anteriores

        If String.IsNullOrWhiteSpace(NivelEducativo.NomNivel) Then
            ListaErrores.Add("El campo nombre no puede estar vacío")
        ElseIf IsNothing(NivelEducativo.Vigente) Then
            ListaErrores.Add("El campo vigente no puede estar vacío")
        End If

        If ListaErrores.Count > 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function UpsertNivelEducativo(NivelEducativo As CAT_NivelEducativo) As JArray
        Dim Peticion As New ParametrosApi()

        Dim fila As New JObject
        fila("NomNivel") = NivelEducativo.NomNivel
        fila("Sec") = NivelEducativo.Sec
        fila("Vigente") = NivelEducativo.Vigente
        fila("EsFormal") = NivelEducativo.EsFormal

        Dim datos As New JArray()
        datos.Add(fila)

        ' Hacer la petición con el JArray como segundo parámetro
        Peticion.PostParametros("NivelEducativo", datos)

        Return datos
    End Function

    Public Function EliminarNivelEducativo(NivelEducativo As CAT_NivelEducativo) As JArray
        Dim Peticion As New ParametrosApi()

        Dim fila As New JObject
        fila("NomNivel") = NivelEducativo.NomNivel
        fila("Sec") = NivelEducativo.Sec
        fila("Vigente") = NivelEducativo.Vigente
        fila("EsFormal") = NivelEducativo.EsFormal
        fila("Eliminado") = 1

        Dim datos As New JArray()
        datos.Add(fila)

        ' Hacer la petición con el JArray como segundo parámetro
        'Peticion.DeleteParametros("NivelEducativo", datos)
    End Function
End Class
