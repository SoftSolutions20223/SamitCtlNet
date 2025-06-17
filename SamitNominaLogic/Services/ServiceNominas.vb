Imports Newtonsoft.Json.Linq

Public Class ServiceNominas
    Public ListaErrores As New List(Of String)

    Public Function ValidarCampos(Nomina As Nominas) As Boolean
        ListaErrores.Clear() ' Limpiar errores anteriores

        If String.IsNullOrWhiteSpace(Nomina.NomNomina) Then
            ListaErrores.Add("El campo nombre no puede estar vacío!..")
        ElseIf String.IsNullOrWhiteSpace(Nomina.Oficina) Then
            ListaErrores.Add("El campo Oficina no puede estar vacío!..")
        End If

        If ListaErrores.Count > 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function UpsertNomina(Nomina As Nominas) As JArray
        Dim Peticion As New ParametrosApi()

        Dim fila As New JObject
        fila("NomNomina") = Nomina.NomNomina
        fila("Sec") = Nomina.Sec
        fila("FormaLiquida") = Nomina.FormaLiquida
        fila("Fecha") = Nomina.Fecha

        Dim datos As New JArray()
        datos.Add(fila)

        ' Hacer la petición con el JArray como segundo parámetro
        Peticion.PostParametros("Nomina", datos)

        Return datos
    End Function

    Public Function EliminarNomina(Nomina As Nominas) As JArray
        Dim Peticion As New ParametrosApi()

        ' Crear el objeto tipo JObject con los datos del banco
        Dim fila As New JObject()
        fila("NomNomina") = Nomina.NomNomina
        fila("Sec") = Nomina.Sec
        fila("FormaLiquida") = Nomina.FormaLiquida
        fila("Fecha") = Nomina.Fecha
        fila("Eliminado") = 1
        ' Agrega aquí más campos si es necesario

        ' Crear el JArray y añadir la fila
        Dim datos As New JArray()
        datos.Add(fila)
        ' Hacer la petición con el JArray como segundo parámetro
        'Peticion.DeleteParametros("Nomina", datos)
    End Function
End Class
