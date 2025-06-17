Imports Newtonsoft.Json.Linq

Public Class ServiceCargos
    Public Property ListaErrores As New List(Of String)

    ''' <summary>
    ''' Valida los datos de un Cargo.
    ''' </summary>
    Public Function ValidarCargo(c As Cargos) As Boolean
        ListaErrores.Clear()
        If c.Sec <= 0 Then ListaErrores.Add("El campo Sec debe ser mayor que cero.")
        If String.IsNullOrWhiteSpace(c.CodCargo) Then
            ListaErrores.Add("El campo CodCargo es obligatorio.")
        ElseIf c.CodCargo.Length > 20 Then
            ListaErrores.Add("CodCargo no puede exceder 20 caracteres.")
        End If
        If String.IsNullOrWhiteSpace(c.Denominacion) Then
            ListaErrores.Add("El campo Denominacion es obligatorio.")
        ElseIf c.Denominacion.Length > 100 Then
            ListaErrores.Add("Denominacion no puede exceder 100 caracteres.")
        End If
        If String.IsNullOrWhiteSpace(c.Descripcion) Then
            ListaErrores.Add("El campo Descripcion es obligatorio.")
        ElseIf c.Descripcion.Length > 1000 Then
            ListaErrores.Add("Descripcion no puede exceder 1000 caracteres.")
        End If
        Return (ListaErrores.Count = 0)
    End Function

    ''' <summary>
    ''' Inserta o actualiza un Cargo.
    ''' </summary>
    Public Function UpsertCargo(c As Cargos) As JArray
        If Not ValidarCargo(c) Then Return Nothing
        Dim fila As New JObject From {
            {"Sec", c.Sec},
            {"CodCargo", c.CodCargo},
            {"Denominacion", c.Denominacion},
            {"Descripcion", c.Descripcion}
        }
        Dim datos As New JArray() From {fila}
        Dim peticion As New ParametrosApi()
        peticion.PostParametros("Cargos", datos)
        Return datos
    End Function

    ''' <summary>
    ''' Valida los datos de una Función de Cargo.
    ''' </summary>
    Public Function ValidarFuncionCargo(f As Cargo_Funciones) As Boolean
        ListaErrores.Clear()
        If f.Sec <= 0 Then ListaErrores.Add("El campo Sec debe ser mayor que cero.")
        If f.Cargo <= 0 Then ListaErrores.Add("El campo Cargo es obligatorio.")
        ' CodFuncion opcional
        Return (ListaErrores.Count = 0)
    End Function

    ''' <summary>
    ''' Inserta o actualiza una Función de Cargo.
    ''' </summary>
    Public Function UpsertFuncionCargo(f As Cargo_Funciones) As JArray
        If Not ValidarFuncionCargo(f) Then Return Nothing
        Dim fila As New JObject From {
            {"Sec", f.Sec},
            {"Cargo", f.Cargo},
            {"CodFuncion", f.CodFuncion}
        }
        Dim datos As New JArray() From {fila}
        Dim peticion As New ParametrosApi()
        peticion.PostParametros("Cargo_Funciones", datos)
        Return datos
    End Function

    ''' <summary>
    ''' Valida los datos de una Asignacion de Cargo.
    ''' </summary>
    Public Function ValidarAsignacionCargo(a As Cargo_Asignaciones) As Boolean
        ListaErrores.Clear()
        If a.Sec <= 0 Then ListaErrores.Add("El campo Sec debe ser mayor que cero.")
        If a.Cargo <= 0 Then ListaErrores.Add("El campo Cargo es obligatorio.")
        ' Asignacion opcional
        Return (ListaErrores.Count = 0)
    End Function

    ''' <summary>
    ''' Inserta o actualiza una Asignación de Cargo.
    ''' </summary>
    Public Function UpsertAsignacionCargo(a As Cargo_Asignaciones) As JArray
        If Not ValidarAsignacionCargo(a) Then Return Nothing
        Dim fila As New JObject From {
            {"Sec", a.Sec},
            {"Fecha", a.Fecha.ToString("yyyy-MM-ddTHH:mm:ss")},
            {"Cargo", a.Cargo},
            {"Asignacion", If(a.Asignacion.HasValue, JToken.FromObject(a.Asignacion.Value), JValue.CreateNull())}
        }
        Dim datos As New JArray() From {fila}
        Dim peticion As New ParametrosApi()
        peticion.PostParametros("Cargo_Asignaciones", datos)
        Return datos
    End Function
End Class
