Imports Newtonsoft.Json.Linq

Public Class ServiceVariablesPersonales
    Public ListaErrores As New List(Of String)

    Public Function ValidarCampos(VariablePersonal As VariablesPersonales) As Boolean
        ListaErrores.Clear() ' Limpiar errores anteriores

        If String.IsNullOrWhiteSpace(VariablePersonal.NomVariable) Then
            ListaErrores.Add("El campo nombre no puede estar vacío!..")
        ElseIf IsNothing(VariablePersonal.Vigente) Then
            ListaErrores.Add("El campo vigente no puede estar vacío!..")
        ElseIf String.IsNullOrWhiteSpace(VariablePersonal.ValorMaximo) Then
            ListaErrores.Add("El campo Valor maximo no puede estar vacío!..")
        End If

        If ListaErrores.Count > 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function UpsertVariablesPersonal(VariablePersonal As VariablesPersonales) As JArray
        Dim Peticion As New ParametrosApi()

        Dim fila As New JObject
        fila("Nom") = VariablePersonal.NomVariable
        fila("Sec") = VariablePersonal.Sec
        fila("Vigente") = VariablePersonal.Vigente
        fila("ValorMaximo") = VariablePersonal.ValorMaximo
        fila("ValorDefecto") = VariablePersonal.ValorDefecto

        Dim datos As New JArray()
        datos.Add(fila)

        ' Hacer la petición con el JArray como segundo parámetro
        Peticion.PostParametros("VariablePersonal", datos)

        Return datos
    End Function

    Public Function EliminarVariablesPersonal(VariablePersonal As VariablesPersonales) As JArray
        Dim Peticion As New ParametrosApi()

        ' Crear el objeto tipo JObject con los datos del banco
        Dim fila As New JObject()
        fila("Nom") = VariablePersonal.NomVariable
        fila("Sec") = VariablePersonal.Sec
        fila("Vigente") = VariablePersonal.Vigente
        fila("ValorMaximo") = VariablePersonal.ValorMaximo
        fila("ValorDefecto") = VariablePersonal.ValorDefecto
        fila("Eliminado") = 1
        ' Agrega aquí más campos si es necesario

        ' Crear el JArray y añadir la fila
        Dim datos As New JArray()
        datos.Add(fila)
        ' Hacer la petición con el JArray como segundo parámetro
        'Peticion.DeleteParametros("VariablePersonal", datos)
    End Function
End Class
