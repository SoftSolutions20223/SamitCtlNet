Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class UpsertErrorDto
    ''' <summary>
    ''' ID de la fila que generó el error
    ''' </summary>
    Public Property RowId As Integer

    ''' <summary>
    ''' Código de error
    ''' </summary>
    Public Property ErrorCode As Integer

    ''' <summary>
    ''' Campo que generó el error (si aplica)
    ''' </summary>
    Public Property Field As String

    ''' <summary>
    ''' Mensaje de error
    ''' </summary>
    Public Property ErrorMessage As String

    ''' <summary>
    ''' Datos originales que generaron el error (como string JSON)
    ''' </summary>
    Public Property OriginalData As String

    ''' <summary>
    ''' Convierte el string JSON de OriginalData a un objeto de tipo específico
    ''' </summary>
    Public Function GetOriginalData(Of T)() As T
        If String.IsNullOrEmpty(OriginalData) Then
            Return Nothing
        End If

        Try
            Return JsonConvert.DeserializeObject(Of T)(OriginalData)
        Catch ex As Exception
            ' Si ocurre un error al deserializar, manejar apropiadamente según tu aplicación
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' Convierte el string JSON de OriginalData a un JObject para manipulación dinámica
    ''' </summary>
    Public Function GetOriginalDataAsJObject() As JObject
        If String.IsNullOrEmpty(OriginalData) Then
            Return Nothing
        End If

        Try
            Return JObject.Parse(OriginalData)
        Catch ex As Exception
            ' Si ocurre un error al deserializar, manejar apropiadamente
            Return Nothing
        End Try
    End Function
End Class