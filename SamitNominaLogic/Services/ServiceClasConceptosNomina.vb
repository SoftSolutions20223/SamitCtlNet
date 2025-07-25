﻿Imports Newtonsoft.Json.Linq

Public Class ServiceClasConceptosNomina
    Public ListaErrores As New List(Of String)

    Public Function ValidarCampos(ClasConceptoNominas As ClasConceptosNomina) As Boolean
        ListaErrores.Clear() ' Limpiar errores anteriores

        If String.IsNullOrWhiteSpace(ClasConceptoNominas.Nom) Then
            ListaErrores.Add("El campo Nombre no puede estar vacío!..")
        ElseIf IsNothing(ClasConceptoNominas.Vigente) Then
            ListaErrores.Add("El campo Vigente no puede estar vacío!..")
        End If

        If ListaErrores.Count > 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function UpsertClasConceptosNomina(ClasConceptoNominas As ClasConceptosNomina) As DynamicUpsertResponseDto
        Dim Peticion As New ParametrosApi()

        Dim fila As New JObject
        fila("Nom") = ClasConceptoNominas.Nom
        fila("Sec") = ClasConceptoNominas.Sec
        fila("Vigente") = ClasConceptoNominas.Vigente

        Dim datos As New JArray()
        datos.Add(fila)

        ' Hacer la petición con el JArray como segundo parámetro
        Dim res = Peticion.PostParametros("ClasConceptosNomina", datos)

        Return res
    End Function

    Public Function EliminarClasConceptosNomina(ClasConceptoNominas As ClasConceptosNomina) As JArray
        Dim Peticion As New ParametrosApi()

        ' Crear el objeto tipo JObject con los datos del banco
        Dim fila As New JObject()
        fila("Nom") = ClasConceptoNominas.Nom
        fila("Sec") = ClasConceptoNominas.Sec
        fila("Vigente") = ClasConceptoNominas.Vigente
        fila("Eliminado") = 1
        ' Agrega aquí más campos si es necesario

        ' Crear el JArray y añadir la fila
        Dim datos As New JArray()
        datos.Add(fila)
        ' Hacer la petición con el JArray como segundo parámetro
        'Peticion.DeleteParametros("ConceptosNominas", datos)
    End Function
End Class
