Public Class ModificarAsignacionesMasivoRequest
    Public Property TipoModificacion As Integer ' 0 = Por Contrato, 1 = Por Cargo
    Public Property Modificaciones As List(Of ModificacionAsignacion)

    ' Constructor
    Public Sub New()
        Modificaciones = New List(Of ModificacionAsignacion)()
    End Sub

    ' Constructor con tipo
    Public Sub New(tipoModificacion As Integer)
        Me.TipoModificacion = tipoModificacion
        Modificaciones = New List(Of ModificacionAsignacion)()
    End Sub

    ' Agregar modificación por contrato
    Public Sub AgregarModificacionContrato(idContrato As String, asignacion As Decimal)
        Modificaciones.Add(New ModificacionAsignacion With {
            .IdContrato = idContrato,
            .Asignacion = asignacion
        })
    End Sub

    ' Agregar modificación por cargo
    Public Sub AgregarModificacionCargo(secCargo As Integer, asignacion As Decimal, fecha As DateTime)
        Modificaciones.Add(New ModificacionAsignacion With {
            .SecCargo = secCargo,
            .Asignacion = asignacion,
            .Fecha = fecha
        })
    End Sub

    ' Método para convertir a JObject
    Public Function ToJObject() As Newtonsoft.Json.Linq.JObject
        Dim json As New Newtonsoft.Json.Linq.JObject()
        json("TipoModificacion") = TipoModificacion

        Dim jArray As New Newtonsoft.Json.Linq.JArray()
        For Each Modi In Modificaciones
            Dim item As New Newtonsoft.Json.Linq.JObject()

            If TipoModificacion = 0 Then
                item("IdContrato") = Modi.IdContrato
                item("Asignacion") = Modi.Asignacion
            Else
                item("SecCargo") = Modi.SecCargo
                item("Asignacion") = Modi.Asignacion
                item("Fecha") = Modi.Fecha?.ToString("yyyy-MM-dd")
            End If

            jArray.Add(item)
        Next

        json("Modificaciones") = jArray
        Return json
    End Function
End Class

' Clase para cada modificación
Public Class ModificacionAsignacion
    Public Property IdContrato As String
    Public Property SecCargo As Integer?
    Public Property Asignacion As Decimal
    Public Property Fecha As DateTime?
End Class