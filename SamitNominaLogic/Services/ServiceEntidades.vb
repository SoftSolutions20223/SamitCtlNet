Imports Newtonsoft.Json.Linq

Public Class ServiceEntidades
    Public ListaErrores As New List(Of String)

    Public Function ValidarCampos(Entidades As EntesSSAP) As Boolean
        ListaErrores.Clear() ' Limpiar errores anteriores

        If String.IsNullOrWhiteSpace(Entidades.NombreEntidad) Then
            ListaErrores.Add("El campo nombre no puede estar vacío!..")
        ElseIf String.IsNullOrWhiteSpace(Entidades.TipoEnte) Then
            ListaErrores.Add("El campo Vigente no puede estar vacío!..")
        ElseIf IsNothing(Entidades.Estado) Then
            ListaErrores.Add("El campo Estado no puede estar vacío")
        ElseIf String.IsNullOrWhiteSpace(Entidades.Nit) Then
            ListaErrores.Add("El campo Nit no puede estar vacío ")
        End If

        If ListaErrores.Count > 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function UpsertEntidad(Entidades As EntesSSAP) As JArray
        Dim Peticion As New ParametrosApi()

        Dim fila As New JObject
        fila("NombreEntidad") = Entidades.NombreEntidad
        fila("Sec") = Entidades.Sec
        fila("TipoEnte") = Entidades.TipoEnte
        fila("Nit") = Entidades.Nit
        fila("Estado") = Entidades.Estado

        Dim datos As New JArray()
        datos.Add(fila)

        ' Hacer la petición con el JArray como segundo parámetro
        Peticion.PostParametros("Entidades", datos)

        Return datos
    End Function

    Public Function EliminarEntidad(Entidades As EntesSSAP) As JArray
        Dim Peticion As New ParametrosApi()

        ' Crear el objeto tipo JObject con los datos del banco
        Dim fila As New JObject()
        fila("NombreEntidad") = Entidades.NombreEntidad
        fila("Sec") = Entidades.Sec
        fila("TipoEnte") = Entidades.TipoEnte
        fila("Nit") = Entidades.Nit
        fila("Estado") = Entidades.Estado
        fila("Eliminado") = 1
        ' Agrega aquí más campos si es necesario

        ' Crear el JArray y añadir la fila
        Dim datos As New JArray()
        datos.Add(fila)
        ' Hacer la petición con el JArray como segundo parámetro
        'Peticion.DeleteParametros("Entidades", datos)
    End Function
End Class
