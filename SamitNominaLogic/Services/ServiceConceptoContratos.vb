Imports Newtonsoft.Json.Linq

Public Class ServiceConceptoContratos
    Public ListaErrores As New List(Of String)

    Public Function ValidarCampos(ConceptosContratos As ConceptosPersonales) As Boolean
        ListaErrores.Clear() ' Limpiar errores anteriores

        If String.IsNullOrWhiteSpace(ConceptosContratos.NomConcepto) Then
            ListaErrores.Add("El campo Nombre no puede estar vacío!..")
        ElseIf IsNothing(ConceptosContratos.Vigente) Then
            ListaErrores.Add("El campo Vigente no puede estar vacío!..")
        ElseIf String.IsNullOrWhiteSpace(ConceptosContratos.Clasificacion) Then
            ListaErrores.Add("El campo clasificacion no puede estar vacío o contener valores invalidos!..")
        ElseIf String.IsNullOrWhiteSpace(ConceptosContratos.ValMaxDescuento) Then
            ListaErrores.Add("El campo maximo a descontar no puede estar vacío!..")
        ElseIf String.IsNullOrWhiteSpace(ConceptosContratos.PeriodosLiquida) Then
            ListaErrores.Add("Tiene que selecionar al menos un periodo del mes a liquidar!..")
        End If

        If ListaErrores.Count > 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function UpsertConceptosContratos(ConceptosContratos As ConceptosPersonales) As DynamicUpsertResponseDto
        Dim Peticion As New ParametrosApi()

        Dim fila As New JObject
        fila("NomConcepto") = ConceptosContratos.NomConcepto
        fila("Sec") = ConceptosContratos.Sec
        fila("Vigente") = ConceptosContratos.Vigente
        fila("Clasificacion") = ConceptosContratos.Clasificacion
        fila("ValMaxDescuento") = ConceptosContratos.ValMaxDescuento
        fila("PeriodosLiquida") = ConceptosContratos.PeriodosLiquida
        fila("CodDian") = ConceptosContratos.CodDian

        Dim datos As New JArray()
        datos.Add(fila)

        ' Hacer la petición con el JArray como segundo parámetro
        Dim res = Peticion.PostParametros("ConceptosPersonales", datos)

        Return res
    End Function

    Public Function EliminarConceptosContratos(ConceptosContratos As ConceptosPersonales) As JArray
        Dim Peticion As New ParametrosApi()

        ' Crear el objeto tipo JObject con los datos del banco
        Dim fila As New JObject()
        fila("NomConcepto") = ConceptosContratos.NomConcepto
        fila("Sec") = ConceptosContratos.Sec
        fila("Vigente") = ConceptosContratos.Vigente
        fila("Clasificacion") = ConceptosContratos.Clasificacion
        fila("ValMaxDescuento") = ConceptosContratos.ValMaxDescuento
        fila("PeriodosLiquida") = ConceptosContratos.PeriodosLiquida
        fila("Eliminado") = 1
        ' Agrega aquí más campos si es necesario

        ' Crear el JArray y añadir la fila
        Dim datos As New JArray()
        datos.Add(fila)
        ' Hacer la petición con el JArray como segundo parámetro
        'Peticion.DeleteParametros("ConceptosContratos", datos)
    End Function
End Class
