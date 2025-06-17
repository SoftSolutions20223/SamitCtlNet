Imports Newtonsoft.Json.Linq

Public Class ServiceFunciones
    Public ListaErrores As New List(Of String)

    Public Function ValidarCampos(Funcion As Funciones) As Boolean
        ListaErrores.Clear() ' Limpiar errores anteriores

        If String.IsNullOrWhiteSpace(Funcion.DetalleFuncion) Then
            ListaErrores.Add("El campo nombre no puede estar vacío!..")
        End If

        If ListaErrores.Count > 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function UpsertFunciones(Funcion As Funciones) As DynamicUpsertResponseDto
        Dim Peticion As New ParametrosApi()

        Dim fila As New JObject
        fila("DetalleFuncion") = Funcion.DetalleFuncion
        fila("Sec") = Funcion.Sec

        Dim datos As New JArray()
        datos.Add(fila)

        ' Hacer la petición con el JArray como segundo parámetro
        Dim res = Peticion.PostParametros("Funciones", datos)

        Return res
    End Function

    Public Function EliminarFunciones(Funcion As Funciones) As JArray
        Dim Peticion As New ParametrosApi()

        ' Crear el objeto tipo JObject con los datos del banco
        Dim fila As New JObject()
        fila("NombreEntidad") = Funcion.DetalleFuncion
        fila("Sec") = Funcion.Sec
        fila("Eliminado") = 1
        ' Agrega aquí más campos si es necesario

        ' Crear el JArray y añadir la fila
        Dim datos As New JArray()
        datos.Add(fila)
        ' Hacer la petición con el JArray como segundo parámetro
        'Peticion.DeleteParametros("Funcion", datos)
    End Function
End Class
