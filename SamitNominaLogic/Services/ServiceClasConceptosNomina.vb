Imports Newtonsoft.Json.Linq

Public Class ServiceClasConceptosNomina
    Public ListaErrores As New List(Of String)

    Public Function ValidarCampos(ConceptosNominas As ConceptosNomina) As Boolean
        ListaErrores.Clear() ' Limpiar errores anteriores

        If String.IsNullOrWhiteSpace(ConceptosNominas.NomConcepto) Then
            ListaErrores.Add("El campo Nombre no puede estar vacío!..")
        ElseIf IsNothing(ConceptosNominas.Vigente) Then
            ListaErrores.Add("El campo Vigente no puede estar vacío!..")
        End If

        If ListaErrores.Count > 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function UpsertClasConceptosNomina(ConceptosNominas As ConceptosNomina) As JArray
        Dim Peticion As New ParametrosApi()

        Dim fila As New JObject
        fila("NomConcepto") = ConceptosNominas.NomConcepto
        fila("Sec") = ConceptosNominas.Sec
        fila("Vigente") = ConceptosNominas.Vigente

        Dim datos As New JArray()
        datos.Add(fila)

        ' Hacer la petición con el JArray como segundo parámetro
        Peticion.PostParametros("ConceptosNominas", datos)

        Return datos
    End Function

    Public Function EliminarClasConceptosNomina(ConceptosNominas As ConceptosNomina) As JArray
        Dim Peticion As New ParametrosApi()

        ' Crear el objeto tipo JObject con los datos del banco
        Dim fila As New JObject()
        fila("NomConcepto") = ConceptosNominas.NomConcepto
        fila("Sec") = ConceptosNominas.Sec
        fila("Vigente") = ConceptosNominas.Vigente
        fila("Eliminado") = 1
        ' Agrega aquí más campos si es necesario

        ' Crear el JArray y añadir la fila
        Dim datos As New JArray()
        datos.Add(fila)
        ' Hacer la petición con el JArray como segundo parámetro
        'Peticion.DeleteParametros("ConceptosNominas", datos)
    End Function
End Class
