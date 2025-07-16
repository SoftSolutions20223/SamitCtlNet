Public Class DynamicDeleteRequest
    Public Property Tabla As String
    Public Property Codigo As Integer
    Public Property CampoId As String


    ' Constructor
    Public Sub New()
        CampoId = "Sec" ' Por defecto usa Sec como campo ID
    End Sub

    ' Constructor con parámetros básicos
    Public Sub New(tabla As String, codigo As Integer)
        Me.New()
        Me.Tabla = tabla
        Me.Codigo = codigo
    End Sub

    ' Constructor completo
    Public Sub New(tabla As String, codigo As Integer, campoId As String)
        Me.New()
        Me.Tabla = tabla
        Me.Codigo = codigo
        If Not String.IsNullOrEmpty(campoId) Then
            Me.CampoId = campoId
        End If
    End Sub

    ' Método para convertir a JObject para el procedimiento almacenado
    Public Function ToJObject() As Newtonsoft.Json.Linq.JObject
        Dim json As New Newtonsoft.Json.Linq.JObject()

        json("Tabla") = Tabla
        json("Codigo") = Codigo
        json("CampoId") = CampoId

        Return json
    End Function

    ' Método auxiliar para obtener el JSON como string
    Public Function ToJsonString() As String
        Return ToJObject().ToString(Newtonsoft.Json.Formatting.None)
    End Function
End Class