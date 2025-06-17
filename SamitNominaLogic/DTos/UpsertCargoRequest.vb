Public Class UpsertCargoRequest
    Public Property Cargo As Cargos
    Public Property Usuario As String
    Public Property Terminal As String
    Public Property Funciones As New List(Of CargoFuncionDto)
    Public Property Asignaciones As New List(Of CargoAsignacionDto)

    ' Método para convertir a JObject para el procedimiento almacenado
    Public Function ToJObject() As Newtonsoft.Json.Linq.JObject
        Dim json As New Newtonsoft.Json.Linq.JObject()

        ' Datos del cargo
        json("Sec") = If(Cargo?.Sec, 0)
        json("CodCargo") = Cargo?.CodCargo
        json("Denominacion") = Cargo?.Denominacion
        json("Descripcion") = Cargo?.Descripcion
        json("Usuario") = Usuario
        json("Terminal") = Terminal

        ' Array de funciones
        Dim jFunciones As New Newtonsoft.Json.Linq.JArray()
        For Each funcion In Funciones
            Dim jFunc As New Newtonsoft.Json.Linq.JObject()
            jFunc("CodFuncion") = funcion.CodFuncion
            jFunciones.Add(jFunc)
        Next
        json("Funciones") = jFunciones

        ' Array de asignaciones
        Dim jAsignaciones As New Newtonsoft.Json.Linq.JArray()
        For Each asignacion In Asignaciones
            Dim jAsig As New Newtonsoft.Json.Linq.JObject()
            jAsig("Fecha") = asignacion.Fecha.ToString("dd/MM/yyyy")
            jAsig("Asignacion") = asignacion.Asignacion
            jAsignaciones.Add(jAsig)
        Next
        json("Asignaciones") = jAsignaciones

        Return json
    End Function
End Class
