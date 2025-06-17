Imports Newtonsoft.Json.Linq

Public Class ServiceEstadoCivil
    Public ListaErrores As New List(Of String)

    Public Function ValidarCampos(EstadoCivil As CAT_EstadoCivil) As Boolean
        ListaErrores.Clear() ' Limpiar errores anteriores

        If String.IsNullOrWhiteSpace(EstadoCivil.NomEstado) Then
            ListaErrores.Add("El campo del nombre de estado civil no puede estar vacío")
        ElseIf IsNothing(EstadoCivil.Vigente) Then
            ListaErrores.Add("El campo vigente no puede estar vacío")
        ElseIf IsNothing(EstadoCivil.IdEstado) Then
            ListaErrores.Add("El campo del id estado no puede estar vacío")
        End If

        If ListaErrores.Count > 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function UpsertEstadoCivil(EstadoCivil As CAT_EstadoCivil) As JArray
        Dim Peticion As New ParametrosApi()

        Dim fila As New JObject
        fila("NomEstado") = EstadoCivil.NomEstado
        fila("Sec") = EstadoCivil.Sec
        fila("Vigente") = EstadoCivil.Vigente
        fila("IdEstado") = EstadoCivil.IdEstado

        Dim datos As New JArray()
        datos.Add(fila)

        ' Hacer la petición con el JArray como segundo parámetro
        Peticion.PostParametros("EstadoCivil", datos)

        Return datos
    End Function

    Public Function EliminarEstadoCivil(EstadoCivil As CAT_EstadoCivil) As JArray
        Dim Peticion As New ParametrosApi()

        ' Crear el objeto tipo JObject con los datos del banco
        Dim fila As New JObject()
        fila("NomEstado") = EstadoCivil.NomEstado
        fila("Sec") = EstadoCivil.Sec
        fila("Vigente") = EstadoCivil.Vigente
        fila("IdEstado") = EstadoCivil.IdEstado
        fila("Eliminado") = 1
        ' Agrega aquí más campos si es necesario

        ' Crear el JArray y añadir la fila
        Dim datos As New JArray()
        datos.Add(fila)
        ' Hacer la petición con el JArray como segundo parámetro
        'Peticion.DeleteParametros("EstadoCivil", datos)
    End Function
End Class
