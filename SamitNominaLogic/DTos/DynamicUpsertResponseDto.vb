Imports Newtonsoft.Json

Public Class DynamicUpsertResponseDto
    ''' <summary>
    ''' Identificador único de la solicitud
    ''' </summary>
    Public Property RequestId As Guid

    ''' <summary>
    ''' Tiempo de ejecución en milisegundos
    ''' </summary>
    Public Property ExecutionTimeMs As Integer

    ''' <summary>
    ''' Total de registros procesados en el JSON de entrada
    ''' </summary>
    Public Property TotalRecords As Integer

    ''' <summary>
    ''' Cantidad de registros procesados exitosamente
    ''' </summary>
    Public Property ProcessedCount As Integer

    ''' <summary>
    ''' Cantidad de errores encontrados
    ''' </summary>
    Public Property ErrorCount As Integer

    ''' <summary>
    ''' Cantidad de registros insertados
    ''' </summary>
    Public Property InsertCount As Integer

    ''' <summary>
    ''' Cantidad de registros actualizados
    ''' </summary>
    Public Property UpdateCount As Integer

    ''' <summary>
    ''' Lista de resultados de operaciones exitosas
    ''' </summary>
    Public Property Results As List(Of UpsertResultItemDto)

    ''' <summary>
    ''' Lista de errores ocurridos durante el procesamiento
    ''' </summary>
    Public Property Errors As List(Of UpsertErrorDto)

    ''' <summary>
    ''' Indica si los resultados fueron truncados por exceder el límite máximo
    ''' </summary>
    Public Property ResultsTruncated As Boolean

    ''' <summary>
    ''' Convierte un JSON a objeto DynamicUpsertResponseDto
    ''' </summary>
    Public Shared Function FromJson(json As String) As DynamicUpsertResponseDto
        Return JsonConvert.DeserializeObject(Of DynamicUpsertResponseDto)(json, New JsonSerializerSettings With {
            .NullValueHandling = NullValueHandling.Ignore
        })
    End Function
End Class