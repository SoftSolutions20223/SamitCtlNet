Imports Newtonsoft.Json.Linq

Public Class ServiceDesDetalleVar
    Public ListaErrores As New List(Of String)

    Public Function ValidarCampos(DesDetalleVar As DescripVarPer) As Boolean
        ListaErrores.Clear() ' Limpiar errores anteriores

        If String.IsNullOrWhiteSpace(DesDetalleVar.NomTipo) Then
            ListaErrores.Add("El campo nombre no puede estar vacío!..")
        ElseIf IsNothing(DesDetalleVar.NomTipo) Then
            ListaErrores.Add("El campo Vigente no puede estar vacío!..")
        ElseIf String.IsNullOrWhiteSpace(DesDetalleVar.Cantidad) Then
            ListaErrores.Add("El campo clasificacion no puede estar vacío o contener valores invalidos!..")
        End If

        If ListaErrores.Count > 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function UpsertDesDetalleVar(DesDetalleVar As DescripVarPer) As JArray
        Dim Peticion As New ParametrosApi()

        Dim fila As New JObject
        fila("NomTipo") = DesDetalleVar.NomTipo
        fila("Sec") = DesDetalleVar.Sec
        fila("Cantidad") = DesDetalleVar.Cantidad
        fila("FechaHoraInicio") = DesDetalleVar.FechaHoraInicio
        fila("FechaHoraFin") = DesDetalleVar.FechaHoraFin
        fila("TipoDesc") = DesDetalleVar.TipoDesc

        Dim datos As New JArray()
        datos.Add(fila)

        ' Hacer la petición con el JArray como segundo parámetro
        Peticion.PostParametros("DesDetalleVar", datos)

        Return datos
    End Function

    Public Function EliminarDesDetalleVar(DesDetalleVar As DescripVarPer) As JArray
        Dim Peticion As New ParametrosApi()

        ' Crear el objeto tipo JObject con los datos del banco
        Dim fila As New JObject()
        fila("NomTipo") = DesDetalleVar.NomTipo
        fila("Sec") = DesDetalleVar.Sec
        fila("Cantidad") = DesDetalleVar.Cantidad
        fila("FechaHoraInicio") = DesDetalleVar.FechaHoraInicio
        fila("FechaHoraFin") = DesDetalleVar.FechaHoraFin
        fila("TipoDesc") = DesDetalleVar.TipoDesc
        fila("Eliminado") = 1
        ' Agrega aquí más campos si es necesario

        ' Crear el JArray y añadir la fila
        Dim datos As New JArray()
        datos.Add(fila)
        ' Hacer la petición con el JArray como segundo parámetro
        'Peticion.DeleteParametros("DesDetalleVar", datos)
    End Function
End Class
