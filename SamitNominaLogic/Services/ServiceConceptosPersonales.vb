Imports Newtonsoft.Json.Linq

Public Class ServiceConceptosPersonales
    Public ListaErrores As New List(Of String)

    Public Function ValidarCampos(ConceptosPersonal As ConceptosPersonales) As Boolean
        ListaErrores.Clear() ' Limpiar errores anteriores

        If String.IsNullOrWhiteSpace(ConceptosPersonal.NomConcepto) Then
            ListaErrores.Add("El campo Nombre no puede estar vacío!..")
        ElseIf IsNothing(ConceptosPersonal.Vigente) Then
            ListaErrores.Add("El campo Vigente no puede estar vacío!..")
        End If

        If ListaErrores.Count > 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function UpsertConceptosPersonal(ConceptosPersonal As ConceptosPersonales) As JArray
        Dim Peticion As New ParametrosApi()

        Dim fila As New JObject
        fila("NomConcepto") = ConceptosPersonal.NomConcepto
        fila("Sec") = ConceptosPersonal.Sec
        fila("Vigente") = ConceptosPersonal.Vigente

        Dim datos As New JArray()
        datos.Add(fila)

        ' Hacer la petición con el JArray como segundo parámetro
        Peticion.PostParametros("ConceptosPersonal", datos)

        Return datos
    End Function

    Public Function EliminarConceptosPersonal(ConceptosPersonal As ConceptosPersonales) As JArray
        Dim Peticion As New ParametrosApi()

        ' Crear el objeto tipo JObject con los datos del banco
        Dim fila As New JObject()
        fila("NomConcepto") = ConceptosPersonal.NomConcepto
        fila("Sec") = ConceptosPersonal.Sec
        fila("Vigente") = ConceptosPersonal.Vigente
        fila("Eliminado") = 1
        ' Agrega aquí más campos si es necesario

        ' Crear el JArray y añadir la fila
        Dim datos As New JArray()
        datos.Add(fila)
        ' Hacer la petición con el JArray como segundo parámetro
        'Peticion.DeleteParametros("ConceptosPersonal", datos)
    End Function
End Class
