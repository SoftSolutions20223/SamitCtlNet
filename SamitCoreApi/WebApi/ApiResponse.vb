Imports Newtonsoft.Json
Imports SamitCore

Public Class ApiResponse

    ''' <summary>
    ''' - OK
    ''' - ERROR
    ''' </summary>
    ''' <returns></returns>
    Public Property Estado As String
    Public ReadOnly Property Detalle As List(Of String) = New List(Of String)
    Public Property DatosComprimidos As Boolean = False

    <JsonConverter(GetType(PlainJsonStringConverter))>
    Public Property ObjetoRes As Object

    <JsonConverter(GetType(PlainJsonStringConverter))>
    Public Property ObjetoValidacion As Object

    <JsonIgnore>
    Public Property ObjetoDetalle As String

    Public Property TipoFacturador As String

    Public Sub New()
    End Sub

    Public Sub New(estado As String, detalle As String)
        Me.Estado = estado
        Me.Detalle.Add(detalle)
    End Sub

    Public Sub New(estado As String)
        Me.Estado = estado
    End Sub

    Public Sub AgregarDetalle(texto As String, Optional objeto As String = Nothing)
        Dim objetoTexto = Nothing
        If Not String.IsNullOrWhiteSpace(ObjetoDetalle) Then
            objetoTexto = ObjetoDetalle
        End If
        If Not String.IsNullOrWhiteSpace(objeto) Then
            objetoTexto = objeto
        End If

        Dim detalleTexto = If(Not IsNothing(objetoTexto), "[" & objetoTexto & "] ", "") & texto
        Detalle.Add(detalleTexto)
    End Sub

    Public Function DetalleTexto() As String
        Dim res = ""
        For Each texto As String In Detalle
            res += " - " & texto & vbCrLf
        Next
        Return res
    End Function

    Public Shared Function ComprimirDatos(datos As String) As String
        Dim Comprimido = CompressString(datos)
        Dim base64 = Convert.ToBase64String(Comprimido, 0, Comprimido.Length)
        Return base64
    End Function

End Class



Public Class PlainJsonStringConverter
    Inherits JsonConverter

    Public Overrides Function CanConvert(ByVal objectType As Type) As Boolean
        Return objectType = GetType(String)
    End Function

    Public Overrides Function ReadJson(ByVal reader As JsonReader, ByVal objectType As Type, ByVal existingValue As Object, ByVal serializer As JsonSerializer) As Object
        Return reader.Value
    End Function

    Public Overrides Sub WriteJson(ByVal writer As JsonWriter, ByVal value As Object, ByVal serializer As JsonSerializer)
        If TypeOf value Is String Then
            writer.WriteRawValue(CStr(value))
        Else
            writer.WriteRawValue(JsonConvert.SerializeObject(value))
        End If
    End Sub
End Class