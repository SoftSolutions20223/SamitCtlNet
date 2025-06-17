Imports Newtonsoft.Json.Linq

Public Class ServiceConfigConceptosPro
    Public ListaErrores As New List(Of String)

    Public Function ValidarCampos(ConfigConceptoPro As ConfigProvisiones) As Boolean
        ListaErrores.Clear() ' Limpiar errores anteriores

        If String.IsNullOrWhiteSpace(ConfigConceptoPro.Nomina) Then
            ListaErrores.Add("El campo Nomina no puede estar vacío!..")
        ElseIf IsNothing(ConfigConceptoPro.SemestresLiquida) Then
            ListaErrores.Add("El campo PeriodosLiquida no puede estar vacío!..")
        ElseIf String.IsNullOrWhiteSpace(ConfigConceptoPro.Formula) Then
            ListaErrores.Add("El campo Formula no puede estar vacío!..")
        ElseIf String.IsNullOrWhiteSpace(ConfigConceptoPro.Concepto) Then
            ListaErrores.Add("El campo Concepto no puede estar vacío!..")
        ElseIf String.IsNullOrWhiteSpace(ConfigConceptoPro.CuentaContable) Then
            ListaErrores.Add("El campo CuentaContable no puede estar vacío!..")
        End If

        If ListaErrores.Count > 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function UpsertConfigConceptoPro(ConfigConceptoPro As ConfigProvisiones) As JArray
        Dim Peticion As New ParametrosApi()

        Dim fila As New JObject
        fila("Nomina") = ConfigConceptoPro.Nomina
        fila("Sec") = ConfigConceptoPro.Sec
        fila("Concepto") = ConfigConceptoPro.Concepto
        fila("Formula") = ConfigConceptoPro.Formula
        fila("SemestresLiquida") = ConfigConceptoPro.SemestresLiquida
        fila("CuentaContable") = ConfigConceptoPro.CuentaContable

        Dim datos As New JArray()
        datos.Add(fila)

        ' Hacer la petición con el JArray como segundo parámetro
        Peticion.PostParametros("ConfigConceptoPro", datos)

        Return datos
    End Function

    Public Function EliminarConfigConcepto(ConfigConceptoPro As ConfigProvisiones) As JArray
        Dim Peticion As New ParametrosApi()

        ' Crear el objeto tipo JObject con los datos del banco
        Dim fila As New JObject()
        fila("Nomina") = ConfigConceptoPro.Nomina
        fila("Sec") = ConfigConceptoPro.Sec
        fila("Concepto") = ConfigConceptoPro.Concepto
        fila("Formula") = ConfigConceptoPro.Formula
        fila("SemestresLiquida") = ConfigConceptoPro.SemestresLiquida
        fila("CuentaContable") = ConfigConceptoPro.CuentaContable
        fila("Eliminado") = 1
        ' Agrega aquí más campos si es necesario

        ' Crear el JArray y añadir la fila
        Dim datos As New JArray()
        datos.Add(fila)
        ' Hacer la petición con el JArray como segundo parámetro
        'Peticion.DeleteParametros("ConfigConceptoPro", datos)
    End Function
End Class
