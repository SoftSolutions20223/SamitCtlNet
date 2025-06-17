Imports Newtonsoft.Json.Linq

Public Class ServiceNominasContratos
    Public ListaErrores As New List(Of String)

    Public Function ValidarCampos(NominaContrato As Contratos) As Boolean
        ListaErrores.Clear() ' Limpiar errores anteriores

        If String.IsNullOrWhiteSpace(NominaContrato.Nomina) Then
            ListaErrores.Add("El campo Nomina no puede estar vacío!..")
        ElseIf String.IsNullOrWhiteSpace(NominaContrato.IdContrato) Then
            ListaErrores.Add("El campo IdContrato no puede estar vacío!..")
        End If

        If ListaErrores.Count > 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function UpsertNominaContrato(NominaContrato As Contratos) As JArray
        Dim Peticion As New ParametrosApi()

        Dim fila As New JObject
        fila("Nomina") = NominaContrato.Nomina
        fila("Sec") = NominaContrato.Sec
        fila("IdContrato") = NominaContrato.IdContrato

        Dim datos As New JArray()
        datos.Add(fila)

        ' Hacer la petición con el JArray como segundo parámetro
        Peticion.PostParametros("NominaContrato", datos)

        Return datos
    End Function

    Public Function EliminarNominaContrato(NominaContrato As Contratos) As JArray
        Dim Peticion As New ParametrosApi()

        ' Crear el objeto tipo JObject con los datos del banco
        Dim fila As New JObject()
        fila("Nomina") = NominaContrato.Nomina
        fila("Sec") = NominaContrato.Sec
        fila("IdContrato") = NominaContrato.IdContrato
        fila("Eliminado") = 1
        ' Agrega aquí más campos si es necesario

        ' Crear el JArray y añadir la fila
        Dim datos As New JArray()
        datos.Add(fila)
        ' Hacer la petición con el JArray como segundo parámetro
        'Peticion.DeleteParametros("NominaContrato", datos)
    End Function
End Class
