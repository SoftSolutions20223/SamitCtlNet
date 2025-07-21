Public Class AsignarNominasContratosMasivoRequest
    Public Property Asignaciones As List(Of AsignacionNominaContrato)

    ' Constructor
    Public Sub New()
        Asignaciones = New List(Of AsignacionNominaContrato)()
    End Sub

    ' Agregar asignación
    Public Sub AgregarAsignacion(idContrato As String, secNomina As Integer)
        Asignaciones.Add(New AsignacionNominaContrato With {
            .IdContrato = idContrato,
            .SecNomina = secNomina
        })
    End Sub

    ' Método para convertir a JObject
    Public Function ToJObject() As Newtonsoft.Json.Linq.JObject
        Dim json As New Newtonsoft.Json.Linq.JObject()
        Dim jArray As New Newtonsoft.Json.Linq.JArray()

        For Each asignacion In Asignaciones
            Dim item As New Newtonsoft.Json.Linq.JObject()
            item("IdContrato") = asignacion.IdContrato
            item("SecNomina") = asignacion.SecNomina
            jArray.Add(item)
        Next

        json("Asignaciones") = jArray
        Return json
    End Function
End Class

' Clase auxiliar para cada asignación
Public Class AsignacionNominaContrato
    Public Property IdContrato As String
    Public Property SecNomina As Integer
End Class