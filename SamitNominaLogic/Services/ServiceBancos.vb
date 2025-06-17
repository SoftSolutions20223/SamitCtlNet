Imports Newtonsoft.Json.Linq

Public Class ServiceBancos
    Public ListaErrores As New List(Of String)

    ' Función para validar campos
    Public Function ValidarCampos(Banco As Bancos) As Boolean
        ListaErrores.Clear() ' Limpiar errores anteriores

        ' Validar que el nombre no esté vacío ni sea null
        If String.IsNullOrWhiteSpace(Banco.Nombre) Then
            ListaErrores.Add("El campo nombre no puede estar vacío")
        ElseIf IsNothing(Banco.Vigente) Then
            ListaErrores.Add("El campo vigente no puede estar vacío")
        End If
        ' Retornar false si hay errores
        If ListaErrores.Count > 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function UpsertBancos(Banco As Bancos) As DynamicUpsertResponseDto
        Dim Peticion As New ParametrosApi()

        ' Crear el objeto tipo JObject con los datos del banco
        Dim fila As New JObject()
        fila("Nombre") = Banco.Nombre
        fila("Sec") = Banco.Sec
        fila("Vigente") = Banco.Vigente
        ' Agrega aquí más campos si es necesario

        ' Crear el JArray y añadir la fila
        Dim datos As New JArray()
        datos.Add(fila)

        ' Hacer la petición con el JArray como segundo parámetro
        Dim RES = Peticion.PostParametros("CAT_Bancos", datos)

        ' Retornar el JArray por si se quiere usar después
        Return RES
    End Function

    Public Function EliminarBancos(Banco As Bancos) As JArray
        Dim Peticion As New ParametrosApi()

        ' Crear el objeto tipo JObject con los datos del banco
        Dim fila As New JObject()
        fila("Nombre") = Banco.Nombre
        fila("Sec") = Banco.Sec
        fila("Vigente") = Banco.Vigente
        fila("Eliminado") = 1
        ' Agrega aquí más campos si es necesario

        ' Crear el JArray y añadir la fila
        Dim datos As New JArray()
        datos.Add(fila)
        ' Hacer la petición con el JArray como segundo parámetro
        'Peticion.DeleteParametros("Bancos", datos)
    End Function

End Class
