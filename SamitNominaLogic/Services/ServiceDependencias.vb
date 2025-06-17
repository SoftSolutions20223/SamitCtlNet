Imports Newtonsoft.Json.Linq

Public Class ServiceDependencias
    Public ListaErrores As New List(Of String)

    Public Function ValidarCampos(Dependecia As Dependencias) As Boolean
        ListaErrores.Clear() ' Limpiar errores anteriores

        If String.IsNullOrWhiteSpace(Dependecia.NomDependencia) Then
            ListaErrores.Add("El campo nombre no puede estar vacío!..")
        ElseIf IsNothing(Dependecia.Vigente) Then
            ListaErrores.Add("El campo Vigente no puede estar vacío!..")
        End If

        If ListaErrores.Count > 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function UpsertDependencia(Dependencia As Dependencias) As DynamicUpsertResponseDto
        Dim Peticion As New ParametrosApi()

        Dim fila As New JObject
        fila("NomDependencia") = Dependencia.NomDependencia
        fila("Sec") = Dependencia.Sec
        fila("Vigente") = Dependencia.Vigente

        Dim datos As New JArray()
        datos.Add(fila)

        ' Hacer la petición con el JArray como segundo parámetro
        Dim res = Peticion.PostParametros("Dependencias", datos)
        'Dim rs = res.Results(0).Record.ToString()
        Return res
    End Function

    Public Function EliminarDependencia(Dependencia As Dependencias) As JArray
        Dim Peticion As New ParametrosApi()

        ' Crear el objeto tipo JObject con los datos del banco
        Dim fila As New JObject()
        fila("NomConcepto") = Dependencia.NomDependencia
        fila("Sec") = Dependencia.Sec
        fila("Vigente") = Dependencia.Vigente
        fila("Eliminado") = 1
        ' Agrega aquí más campos si es necesario

        ' Crear el JArray y añadir la fila
        Dim datos As New JArray()
        datos.Add(fila)
        ' Hacer la petición con el JArray como segundo parámetro
        'Peticion.DeleteParametros("Dependencia", datos)
    End Function
End Class
