Imports Newtonsoft.Json.Linq

Public Class ServiceConceptosNominas
    Public ListaErrores As New List(Of String)

    Public Function ValidarCampos(ConceptosNominas As ConceptosNomina) As Boolean
        ListaErrores.Clear() ' Limpiar errores anteriores

        If String.IsNullOrWhiteSpace(ConceptosNominas.NomConcepto) Then
            ListaErrores.Add("El campo nombre no puede estar vacío!..")
        ElseIf IsNothing(ConceptosNominas.Vigente) Then
            ListaErrores.Add("El campo Vigente no puede estar vacío!..")
        ElseIf String.IsNullOrWhiteSpace(ConceptosNominas.Clasificacion) Then
            ListaErrores.Add("El campo clasificacion no puede estar vacío o contener valores invalidos!..")
        ElseIf String.IsNullOrWhiteSpace(ConceptosNominas.Base) Then
            ListaErrores.Add("El campo maximo a descontar no puede estar vacío!..")
        ElseIf String.IsNullOrWhiteSpace(ConceptosNominas.Fondo) Then
            ListaErrores.Add("El campo base no puede estar vacío o contener valores invalidos!..")
        ElseIf String.IsNullOrWhiteSpace(ConceptosNominas.CodDian) Then
            ListaErrores.Add("El campo codigo Dian no puede estar vacío")
        End If

        If ListaErrores.Count > 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function UpsertConceptosNominas(ConceptosNominas As ConceptosNomina) As JArray
        Dim Peticion As New ParametrosApi()

        Dim fila As New JObject
        fila("NomConcepto") = ConceptosNominas.NomConcepto
        fila("Sec") = ConceptosNominas.Sec
        fila("Vigente") = ConceptosNominas.Vigente
        fila("Clasificacion") = ConceptosNominas.Clasificacion
        fila("Base") = ConceptosNominas.Base
        fila("CodDian") = ConceptosNominas.CodDian

        Dim datos As New JArray()
        datos.Add(fila)

        ' Hacer la petición con el JArray como segundo parámetro
        Peticion.PostParametros("ConceptosNominas", datos)

        Return datos
    End Function

    Public Function EliminarConceptosNominas(ConceptosNominas As ConceptosNomina) As JArray
        Dim Peticion As New ParametrosApi()

        ' Crear el objeto tipo JObject con los datos del banco
        Dim fila As New JObject()
        fila("NomConcepto") = ConceptosNominas.NomConcepto
        fila("Sec") = ConceptosNominas.Sec
        fila("Vigente") = ConceptosNominas.Vigente
        fila("Clasificacion") = ConceptosNominas.Clasificacion
        fila("Base") = ConceptosNominas.Base
        fila("CodDian") = ConceptosNominas.CodDian
        fila("Eliminado") = 1
        ' Agrega aquí más campos si es necesario

        ' Crear el JArray y añadir la fila
        Dim datos As New JArray()
        datos.Add(fila)
        ' Hacer la petición con el JArray como segundo parámetro
        'Peticion.DeleteParametros("ConceptosNominas", datos)
    End Function
End Class
