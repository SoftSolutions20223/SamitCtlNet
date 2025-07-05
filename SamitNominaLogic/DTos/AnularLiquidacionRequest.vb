Public Class AnularLiquidacionRequest
    Public Property SecLiquidacion As Integer
    Public Property TipoLiquidacion As String ' P, S, E, C

    ' Constructor
    Public Sub New()
    End Sub

    Public Sub New(secLiquidacion As Integer, tipoLiquidacion As String)
        Me.SecLiquidacion = secLiquidacion
        Me.TipoLiquidacion = tipoLiquidacion
    End Sub

    ' Método para convertir a JObject para el procedimiento almacenado
    Public Function ToJObject() As Newtonsoft.Json.Linq.JObject
        Dim json As New Newtonsoft.Json.Linq.JObject()

        json("SecLiquidacion") = SecLiquidacion
        json("TipoLiquidacion") = TipoLiquidacion

        Return json
    End Function
End Class