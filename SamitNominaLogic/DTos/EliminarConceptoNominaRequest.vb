﻿Public Class EliminarConceptoNominaRequest
    Public Property Sec As Integer
    Public Property ValidarFormulas As Boolean

    ' Constructor sin parámetros
    Public Sub New()
        ValidarFormulas = True ' Por defecto valida las fórmulas
    End Sub

    ' Constructor con parámetros
    Public Sub New(sec As Integer, Optional validarFormulas As Boolean = True)
        Me.Sec = sec
        Me.ValidarFormulas = validarFormulas
    End Sub

    ' Método para convertir a JObject para el procedimiento almacenado
    Public Function ToJObject() As Newtonsoft.Json.Linq.JObject
        Dim json As New Newtonsoft.Json.Linq.JObject()

        json("Sec") = Sec
        json("ValidarFormulas") = ValidarFormulas

        Return json
    End Function

    ' Método auxiliar para obtener el JSON como string
    Public Function ToJsonString() As String
        Return ToJObject().ToString(Newtonsoft.Json.Formatting.None)
    End Function
End Class