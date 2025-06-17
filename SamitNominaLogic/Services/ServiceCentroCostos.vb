Imports Newtonsoft.Json.Linq

Public Class ServiceCentroCostos
    Public ListaErrores As New List(Of String)

    Public Function ValidarCampos(CentroCostos As CT_CentroCostos) As Boolean
        ListaErrores.Clear() ' Limpiar errores anteriores

        If String.IsNullOrWhiteSpace(CentroCostos.Nom_CentroCosto) Then
            ListaErrores.Add("El campo Nombre no puede estar vacío!..")
        ElseIf String.IsNullOrWhiteSpace(CentroCostos.Responsable) Then
            ListaErrores.Add("El campo Responsable no puede estar vacío!..")
        ElseIf String.IsNullOrWhiteSpace(CentroCostos.FechaIniLimite) Then
            ListaErrores.Add("El campo Fecha Inicio no puede estar vacío!..")
        ElseIf String.IsNullOrWhiteSpace(CentroCostos.FechaFinLimite) Then
            ListaErrores.Add("El campo Fecha Fin no puede estar vacío!..")
        ElseIf IsNothing(CentroCostos.LimitaUso) Then
            ListaErrores.Add("El campo Uso Limitado no puede estar vacío!..")
        End If

        If ListaErrores.Count > 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function UpsertCentroCosto(CentroCostos As CT_CentroCostos) As DynamicUpsertResponseDto
        Dim Peticion As New ParametrosApi()

        Dim fila As New JObject
        fila("Nom_CentroCosto") = CentroCostos.Nom_CentroCosto
        fila("Sec") = CentroCostos.Sec
        fila("Responsable") = CentroCostos.Responsable
        fila("FechaIniLimite") = CentroCostos.FechaIniLimite
        fila("FechaFinLimite") = CentroCostos.FechaFinLimite
        fila("Estado") = CentroCostos.Estado

        Dim datos As New JArray()
        datos.Add(fila)

        ' Hacer la petición con el JArray como segundo parámetro
        Dim res = Peticion.PostParametros("CT_CentroCostos", datos)

        Return res
    End Function

    Public Function EliminarCentroCosto(CentroCostos As CT_CentroCostos) As JArray
        Dim Peticion As New ParametrosApi()

        ' Crear el objeto tipo JObject con los datos del banco
        Dim fila As New JObject()
        fila("Nom_CentroCosto") = CentroCostos.Nom_CentroCosto
        fila("Sec") = CentroCostos.Sec
        fila("Responsable") = CentroCostos.Responsable
        fila("FechaIniLimite") = CentroCostos.FechaIniLimite
        fila("FechaFinLimite") = CentroCostos.FechaFinLimite
        fila("Estado") = CentroCostos.Estado
        fila("Eliminado") = 1
        ' Agrega aquí más campos si es necesario

        ' Crear el JArray y añadir la fila
        Dim datos As New JArray()
        datos.Add(fila)
        ' Hacer la petición con el JArray como segundo parámetro
        'Peticion.DeleteParametros("CentroCostos", datos)
    End Function
End Class
