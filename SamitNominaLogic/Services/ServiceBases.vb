Imports Newtonsoft.Json.Linq

Public Class ServiceBases
    Public ListaErrores As New List(Of String)

    Public Function ValidarCampos(Bases As BasesConceptos) As Boolean
        ListaErrores.Clear() ' Limpiar errores anteriores

        If String.IsNullOrWhiteSpace(Bases.NomBase) Then
            ListaErrores.Add("El nombre de base no puede estar vacío!")
        ElseIf IsNothing(Bases.Vigente) Then
            ListaErrores.Add("El campo vigente no puede estar vacío!")
        ElseIf String.IsNullOrWhiteSpace(Bases.Formula) Then
            ListaErrores.Add("El campo formula no puede estar vacío!")
        End If

        If ListaErrores.Count > 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function UpsertBase(Bases As BasesConceptos) As JArray
        Dim Peticion As New ParametrosApi()

        Dim fila As New JObject
        fila("NomBase") = Bases.NomBase
        fila("Sec") = Bases.Sec
        fila("Vigente") = Bases.Vigente
        fila("Formula") = Bases.Formula

        Dim datos As New JArray()
        datos.Add(fila)

        ' Hacer la petición con el JArray como segundo parámetro
        Peticion.PostParametros("Bases", datos)

        Return datos
    End Function

    Public Function EliminarBase(Bases As BasesConceptos) As JArray
        Dim Peticion As New ParametrosApi()

        ' Crear el objeto tipo JObject con los datos del banco
        Dim fila As New JObject()
        fila("NomBase") = Bases.NomBase
        fila("Sec") = Bases.Sec
        fila("Vigente") = Bases.Vigente
        fila("Formula") = Bases.Sec
        fila("Eliminado") = 1
        ' Agrega aquí más campos si es necesario

        ' Crear el JArray y añadir la fila
        Dim datos As New JArray()
        datos.Add(fila)
        ' Hacer la petición con el JArray como segundo parámetro
        'Peticion.DeleteParametros("Bases", datos)
    End Function
End Class
