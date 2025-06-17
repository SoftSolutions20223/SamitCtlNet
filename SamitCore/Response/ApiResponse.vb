Imports Newtonsoft.Json

Public Class ApiResponse

    '<Obsolete("Usar la propiedad Resultado en su lugar.")>
    Public Property Estado As String
    Public Property Detalle As List(Of String) = New List(Of String)
    Public Property ObjetoValidacion As Object
    Public Property DatosComprimidos As Boolean

    Public Function DetalleTexto() As String
        Dim res = ""
        For Each texto As String In Detalle
            res += " - " & texto & vbCrLf
        Next
        Return res
    End Function

    Public ReadOnly Property Resultado As ApiEstado
        Get
            Select Case Estado
                Case "OK"
                    Return ApiEstado.OK
                Case "ERROR"
                    Return ApiEstado.ERROR
            End Select
            Return Nothing
        End Get
    End Property

    Public Function GetReporteError() As List(Of ReporteError)
        Dim res As New List(Of ReporteError)
        For Each det In Detalle
            res.Add(New ReporteError With {.TextoError = det})
        Next
        Return res
    End Function

    Public Shared Function DescomprimirDatos(data As String) As String
        Dim base64 = Convert.FromBase64String(data)
        Dim descomprimir = DecompressString(base64)
        Return descomprimir
    End Function

End Class

Public Class ApiResponse(Of TObject)
    Inherits ApiResponse

    Public Property ObjetoRes As TObject

    Public Sub New()
    End Sub

    Public Shared Function From(response As ApiResponse) As ApiResponse(Of TObject)
        Return New ApiResponse(Of TObject) With {
            .Estado = response.Estado,
            .Detalle = response.Detalle
        }
    End Function

    Public Shared Function From(response As ApiResponse, json As String) As ApiResponse(Of TObject)
        Return New ApiResponse(Of TObject) With {
            .Estado = response.Estado,
            .Detalle = response.Detalle,
            .ObjetoRes = JsonConvert.DeserializeObject(Of TObject)(json)
        }
    End Function

    Public Shared Function From(response As ApiResponse, data As Object) As ApiResponse(Of TObject)
        Return New ApiResponse(Of TObject) With {
            .Estado = response.Estado,
            .Detalle = response.Detalle,
            .ObjetoRes = data
        }
    End Function

End Class

Public Enum ApiEstado
    [OK]
    [ERROR]
End Enum

Public Class ReporteError

    Public Property Objeto As String
    Public Property TextoError As String

End Class
