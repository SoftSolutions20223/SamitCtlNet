Imports Newtonsoft.Json.Linq

Public Class ServiceConfigConceptos
    Public ListaErrores As New List(Of String)

    Public Function ValidarCampos(ConfigConcepto As ConfigConceptos) As Boolean
        ListaErrores.Clear() ' Limpiar errores anteriores

        If String.IsNullOrWhiteSpace(ConfigConcepto.Nomina) Then
            ListaErrores.Add("El campo Nomina no puede estar vacío!..")
        ElseIf IsNothing(ConfigConcepto.PeriodosLiquida) Then
            ListaErrores.Add("El campo PeriodosLiquida no puede estar vacío!..")
        ElseIf String.IsNullOrWhiteSpace(ConfigConcepto.Formula) Then
            ListaErrores.Add("El campo Formula no puede estar vacío!..")
        ElseIf String.IsNullOrWhiteSpace(ConfigConcepto.Concepto) Then
            ListaErrores.Add("El campo Concepto no puede estar vacío!..")
        End If

        If ListaErrores.Count > 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function UpsertConfigConcepto(ConfigConcepto As ConfigConceptos) As JArray
        Dim Peticion As New ParametrosApi()

        Dim fila As New JObject
        fila("Nomina") = ConfigConcepto.Nomina
        fila("Sec") = ConfigConcepto.Sec
        fila("Concepto") = ConfigConcepto.Concepto
        fila("Formula") = ConfigConcepto.Formula
        fila("PeriodosLiquida") = ConfigConcepto.PeriodosLiquida

        Dim datos As New JArray()
        datos.Add(fila)

        ' Hacer la petición con el JArray como segundo parámetro
        Peticion.PostParametros("ConfigConcepto", datos)

        Return datos
    End Function

    Public Function EliminarConfigConcepto(ConfigConcepto As ConfigConceptos) As JArray
        Dim Peticion As New ParametrosApi()

        ' Crear el objeto tipo JObject con los datos del banco
        Dim fila As New JObject()
        fila("Nomina") = ConfigConcepto.Nomina
        fila("Sec") = ConfigConcepto.Sec
        fila("Concepto") = ConfigConcepto.Concepto
        fila("Formula") = ConfigConcepto.Formula
        fila("PeriodosLiquida") = ConfigConcepto.PeriodosLiquida
        fila("Eliminado") = 1
        ' Agrega aquí más campos si es necesario

        ' Crear el JArray y añadir la fila
        Dim datos As New JArray()
        datos.Add(fila)
        ' Hacer la petición con el JArray como segundo parámetro
        'Peticion.DeleteParametros("ConfigConcepto", datos)
    End Function
End Class
