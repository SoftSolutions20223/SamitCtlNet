Imports Newtonsoft.Json.Linq

Public Class ServicePlantaCargos
    Public ListaErrores As New List(Of String)

    Public Function ValidarCampos(PlantaCargo As PlantadeCargos) As Boolean
        ListaErrores.Clear() ' Limpiar errores anteriores

        If String.IsNullOrWhiteSpace(PlantaCargo.Oficina) Then
            ListaErrores.Add("El campo nombre no puede estar vacío!..")
        ElseIf String.IsNullOrWhiteSpace(PlantaCargo.Cargo) Then
            ListaErrores.Add("El campo vigente no puede estar vacío!..")
        End If

        If ListaErrores.Count > 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function UpsertPlantaCargos(PlantaCargo As PlantadeCargos) As DynamicUpsertResponseDto
        Dim Peticion As New ParametrosApi()

        Dim fila As New JObject
        fila("Oficina") = PlantaCargo.Oficina
        fila("Sec") = PlantaCargo.Sec
        fila("Cargo") = PlantaCargo.Cargo
        fila("NumCargos") = PlantaCargo.NumCargos

        Dim datos As New JArray()
        datos.Add(fila)

        ' Hacer la petición con el JArray como segundo parámetro
        Dim res = Peticion.PostParametros("PlantadeCargos", datos)

        Return res
    End Function

    Public Function EliminarPlantaCargos(PlantaCargo As PlantadeCargos) As JArray
        Dim Peticion As New ParametrosApi()

        ' Crear el objeto tipo JObject con los datos del banco
        Dim fila As New JObject()
        fila("Oficina") = PlantaCargo.Oficina
        fila("Sec") = PlantaCargo.Sec
        fila("Cargo") = PlantaCargo.Cargo
        fila("NumCargos") = PlantaCargo.NumCargos
        fila("Eliminado") = 1
        ' Agrega aquí más campos si es necesario

        ' Crear el JArray y añadir la fila
        Dim datos As New JArray()
        datos.Add(fila)
        ' Hacer la petición con el JArray como segundo parámetro
        'Peticion.DeleteParametros("PlantaCargo", datos)
    End Function
End Class
