Imports Newtonsoft.Json.Linq

Public Class UpsertResultItemDto
    ''' <summary>
    ''' ID de la fila en el procesamiento
    ''' </summary>
    Public Property RowId As Integer

    ''' <summary>
    ''' Tipo de operación (INSERT/UPDATE)
    ''' </summary>
    Public Property Operation As String

    ''' <summary>
    ''' ID del registro en la base de datos
    ''' </summary>
    Public Property Sec As Integer

    ''' <summary>
    ''' Fecha y hora UTC de la solicitud
    ''' </summary>
    Public Property RequestTimeUTC As DateTime

    ''' <summary>
    ''' Datos del registro (estructura dinámica)
    ''' </summary>
    Public Property Record As JObject

    ''' <summary>
    ''' Convierte el Record a un tipo específico
    ''' </summary>
    Public Function GetRecord(Of T)() As T
        If Record Is Nothing Then
            Return Nothing
        End If
        Return Record.ToObject(Of T)()
    End Function
End Class