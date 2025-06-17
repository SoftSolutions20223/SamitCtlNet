Imports System.IO
Imports System.Net
Imports Newtonsoft.Json

Public Class Api
    Public Shared Property UrlServidor As String
    Public Shared Property Token As String
    Public Shared Property TimeoutSegundos As Integer

    Public Shared Function GetHttpPrefix() As String
        If Debugger.IsAttached Then
            Return "http://"
        Else
            Return "https://"
        End If
    End Function

    Public Shared ReadOnly Property HttpUrlServidor
        Get
            Dim uri = UrlServidor
            If Not uri.Contains("http") Then
                uri = $"{GetHttpPrefix()}{uri}"
            End If
            Return uri
        End Get
    End Property

    Public Shared Sub InicializarApi(urlServidor As String)
        urlServidor.Replace("\", "/")
        Api.UrlServidor = urlServidor
    End Sub

    Public Shared Async Function ApiPostAsync(Of T)(
                                    urlPart As String,
                                    Optional body As Object = "{}",
                                    Optional auth As String = Nothing,
                                    Optional comprimir As Boolean = False
                                    ) As Task(Of ApiResponse(Of T))
        Return Await Task.Run(Function() ApiPOST(Of T)(urlPart, body, auth, comprimir))
    End Function

    Public Shared Function ApiPOST(Of T)(
                                  urlPart As String,
                                  Optional body As Object = "{}",
                                  Optional auth As String = Nothing,
                                  Optional comprimir As Boolean = False
                                  ) As ApiResponse(Of T)
        Dim url = UrlServidor & urlPart
        Dim bodyJson = ""

        Try
            If TypeOf body Is String Then
                bodyJson = body
            Else
                bodyJson = JsonConvert.SerializeObject(body)
            End If

            If IsNothing(auth) Then
                auth = "Bearer " & Token
            End If

            Dim resText = NativePOST(url, bodyJson, auth, compressHeader:=comprimir)
            Dim resApi = JsonConvert.DeserializeObject(Of ApiResponse(Of Object))(resText)

            If resApi.DatosComprimidos Then
                resApi.ObjetoRes = ApiResponse.DescomprimirDatos(resApi.ObjetoRes.ToString())
            End If

            Dim data = resApi.ObjetoRes
            If IsNothing(data) Then
                Return ApiResponse(Of T).From(resApi)
            End If

            If GetType(T) = GetType(Object) Then
                Return ApiResponse(Of T).From(resApi, data:=data)
            End If

            Return ApiResponse(Of T).From(resApi, json:=data.ToString())
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        Return Nothing
    End Function

    Public Shared UsarUrlRandom As Boolean = True
    Public Shared Function RandomUrl(uri) As String
        If UsarUrlRandom Then
            If uri.Contains("?") Then
                uri += "&"
            Else
                uri += "?"
            End If
            uri += "rn=" & (New Random()).Next(10000, 99999)
        End If
        Return uri
    End Function

    Public Shared Function NativePOST(ByVal uri As String, ByVal data As String, auth As String, compressHeader As Boolean) As String

        If Not uri.Contains("http") Then
            uri = $"{GetHttpPrefix()}{uri}"
        End If
        uri = RandomUrl(uri)
        Dim request As HttpWebRequest = CType(WebRequest.Create(uri), HttpWebRequest)
        Try
            request.Proxy = Nothing
            request.AutomaticDecompression = DecompressionMethods.GZip Or DecompressionMethods.Deflate
            request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:47.0) Gecko/20100101 Firefox/47.0"
            request.Method = "POST"
            request.ContentType = "application/json"
            request.Headers.Add("authorization", auth)
            If compressHeader Then
                request.Headers.Add("compress", "1")
            End If
            Dim MiUri As New Uri(uri)
            Dim misp = ServicePointManager.FindServicePoint(MiUri)

            If TimeoutSegundos > 0 Then
                request.Timeout = TimeoutSegundos * 1000
            ElseIf TimeoutSegundos = System.Threading.Timeout.Infinite Then
                request.Timeout = TimeoutSegundos
            End If
        Catch ex As Exception

        End Try


        Try
            Using streamWriter = New StreamWriter(request.GetRequestStream())
                Dim json As String = data
                streamWriter.Write(json)
                streamWriter.Flush()
                streamWriter.Close()
            End Using
            Using response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)

                Using stream As Stream = response.GetResponseStream()

                    Using reader As StreamReader = New StreamReader(stream)
                        Dim Resp = reader.ReadToEnd()
                        Return Resp
                    End Using
                End Using
            End Using

        Catch ex As WebException
#Disable Warning BC40000 ' Type or member is obsolete
            Dim resError = New ApiResponse With {.Estado = "ERROR"}
#Enable Warning BC40000 ' Type or member is obsolete
            resError.Detalle.Add("ERRORLOCAL: " & ex.Message)
            Return JsonConvert.SerializeObject(resError)
        End Try
    End Function

    Public Shared Function NativeGET(ByVal uri As String) As String
        If Not uri.Contains("http") Then
            uri = $"{GetHttpPrefix()}{uri}"
        End If
        uri = RandomUrl(uri)

        Dim request As HttpWebRequest = CType(WebRequest.Create(uri), HttpWebRequest)
        request.AutomaticDecompression = DecompressionMethods.GZip Or DecompressionMethods.Deflate
        request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:47.0) Gecko/20100101 Firefox/47.0"
        request.Method = "GET"

        If TimeoutSegundos > 0 Then
            request.Timeout = TimeoutSegundos * 1000
        ElseIf TimeoutSegundos = System.Threading.Timeout.Infinite Then
            request.Timeout = TimeoutSegundos
        End If

        Try
            Using response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
                Using stream As Stream = response.GetResponseStream()

                    Using reader As StreamReader = New StreamReader(stream)
                        Dim res = reader.ReadToEnd()
                        Return res
                    End Using
                End Using
            End Using
        Catch ex As WebException
#Disable Warning BC40000 ' Type or member is obsolete
            Dim resError = New ApiResponse With {.Estado = "ERROR"}
#Enable Warning BC40000 ' Type or member is obsolete
            resError.Detalle.Add("ERRORLOCAL: " & ex.Message)
            Return JsonConvert.SerializeObject(resError)
        End Try
    End Function

End Class
