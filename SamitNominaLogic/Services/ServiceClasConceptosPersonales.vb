Imports Newtonsoft.Json.Linq

Public Class ServiceClasConceptosPersonales
    Public ListaErrores As New List(Of String)

    Public Function ValidarCampos(ClasConceptoP As ClasConceptosPersonales) As Boolean
        ListaErrores.Clear() ' Limpiar errores anteriores

        If String.IsNullOrWhiteSpace(ClasConceptoP.Nom) Then
            ListaErrores.Add("El campo Nombre no puede estar vacío!..")
        ElseIf IsNothing(ClasConceptoP.Vigente) Then
            ListaErrores.Add("El campo Vigente no puede estar vacío!..")
        End If

        If ListaErrores.Count > 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function UpsertClasConceptosNomina(ClasConceptoP As ClasConceptosPersonales) As DynamicUpsertResponseDto
        Dim Peticion As New ParametrosApi()

        Dim fila As New JObject
        fila("Nom") = ClasConceptoP.Nom
        fila("Sec") = ClasConceptoP.Sec
        fila("Vigente") = ClasConceptoP.Vigente
        fila("NivelP") = ClasConceptoP.NivelP

        Dim datos As New JArray()
        datos.Add(fila)

        ' Hacer la petición con el JArray como segundo parámetro
        Dim res = Peticion.PostParametros("ClasConceptosPersonales", datos)

        Return res
    End Function

    Public Function EliminarClasConceptosNomina(ConceptosNominas As ClasConceptosPersonales) As JArray
        Dim Peticion As New ParametrosApi()

        ' Crear el objeto tipo JObject con los datos del banco
        Dim fila As New JObject()
        fila("Nom") = ConceptosNominas.Nom
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
