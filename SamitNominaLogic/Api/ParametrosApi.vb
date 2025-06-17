Imports Newtonsoft.Json.Linq
Imports SamitCore

Public Class ParametrosApi

    Shared ReadOnly ApiPath = "/Api/Parametros.asmx"

    Public Shared Async Function GetParametros(Clase As Object, ParametrosBusqueda As JArray) As Task(Of ApiResponseClient(Of JArray))

        Dim url = $"{ApiPath}/GetParametros"
        Dim resApi = Await ApiClient.Instance.ApiPostAsync(Of JArray)(url, ParametrosBusqueda)

        If IsNothing(resApi) Then
            resApi = New ApiResponseClient With {.Estado = "ERROR"}
            resApi.Detalle.Add("La respuesta del servidor no contiene datos.")
        End If

        Return resApi
    End Function

    Public Shared Async Function SqlGet(sql As String) As Task(Of ApiResponseClient(Of DataTable))

        Dim url = $"{ApiPath}/SqlGet"
        Dim resApi = Await ApiClient.Instance.ApiPostAsync(Of DataTable)(url, New Oficina())

        If IsNothing(resApi) Then
            resApi = New ApiResponseClient With {.Estado = "ERROR"}
            resApi.Detalle.Add("La respuesta del servidor no contiene datos.")
        End If

        Return resApi
    End Function

    Public Shared Function PostParametros(NombreClase As String, ListaRegistros As JArray) As DynamicUpsertResponseDto
        Dim paramsDefinition = New With {
            .Tabla = NombreClase,
            .Datos = ListaRegistros
        }
        Dim url = $"{ApiPath}/PostParametros"
        Dim resApi = ApiClient.Instance.ApiPOST(Of JObject)(url, paramsDefinition)

        If IsNothing(resApi) Then
            resApi = New ApiResponseClient With {.Estado = "ERROR"}
            resApi.Detalle.Add("La respuesta del servidor no contiene datos.")
        End If
        Dim instancia As DynamicUpsertResponseDto = resApi.ObjetoRes.ToObject(Of DynamicUpsertResponseDto)()
        Return instancia
    End Function

End Class
