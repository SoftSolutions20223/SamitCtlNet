Imports Newtonsoft.Json.Linq
Imports SamitNominaWebService

Public Class ServiceNovedades
    Public ListaErrores As New List(Of String)

    'Public Function ValidarCampos(Novedades As NominaLiquida) As Boolean
    '    ListaErrores.Clear() ' Limpiar errores anteriores

    '    If String.IsNullOrWhiteSpace(Novedades.Periodo) Then
    '        ListaErrores.Add("El campo periodo no puede estar vacío!..")
    '    ElseIf String.IsNullOrWhiteSpace(Novedades.OfiNomina) Then
    '        ListaErrores.Add("El campo Nomina no puede estar vacío!..")
    '    End If

    '    If ListaErrores.Count > 0 Then
    '        Return False
    '    Else
    '        Return True
    '    End If
    'End Function

    'Public Function UpsertNovedades(Novedades As NominaLiquida) As JArray
    '    Dim Peticion As New ParametrosApi()

    '    Dim fila As New JObject
    '    fila("Periodo") = Novedades.Periodo
    '    fila("Sec") = Novedades.Sec
    '    fila("FechaCrea") = Novedades.FechaCrea
    '    fila("FechaMod") = Novedades.FechaMod
    '    fila("OfiNomina") = Novedades.OfiNomina
    '    fila("OfiRegistra") = Novedades.OfiRegistra
    '    fila("TerminalCrea") = Novedades.TerminalCrea
    '    fila("EsBorrador") = Novedades.EsBorrador
    '    fila("TerminalMod") = Novedades.TerminalMod
    '    fila("UsuCrea") = Novedades.UsuCrea
    '    fila("UsuMod") = Novedades.UsuMod

    '    Dim datos As New JArray()
    '    datos.Add(fila)

    '    ' Hacer la petición con el JArray como segundo parámetro
    '    Peticion.PostParametros("Novedades", datos)

    '    Return datos
    'End Function

    'Public Function EliminarNovedades(Novedades As NominaLiquida) As JArray
    '    Dim Peticion As New ParametrosApi()

    '    ' Crear el objeto tipo JObject con los datos del banco
    '    Dim fila As New JObject()
    '    fila("Periodo") = Novedades.Periodo
    '    fila("Sec") = Novedades.Sec
    '    fila("FechaCrea") = Novedades.FechaCrea
    '    fila("FechaMod") = Novedades.FechaMod
    '    fila("OfiNomina") = Novedades.OfiNomina
    '    fila("OfiRegistra") = Novedades.OfiRegistra
    '    fila("TerminalCrea") = Novedades.TerminalCrea
    '    fila("EsBorrador") = Novedades.EsBorrador
    '    fila("TerminalMod") = Novedades.TerminalMod
    '    fila("UsuCrea") = Novedades.UsuCrea
    '    fila("UsuMod") = Novedades.UsuMod
    '    fila("Eliminado") = 1
    '    ' Agrega aquí más campos si es necesario

    '    ' Crear el JArray y añadir la fila
    '    Dim datos As New JArray()
    '    datos.Add(fila)
    '    ' Hacer la petición con el JArray como segundo parámetro
    '    'Peticion.DeleteParametros("Novedades", datos)
    'End Function
End Class
