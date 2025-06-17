Imports System.IO
Imports System.IO.Compression

Public Module StringHelper

    Public Function CompressString(ByVal text As String) As Byte()
        Dim textAsBytes As Byte() = System.Text.Encoding.UTF8.GetBytes(text)
        Dim memory As New MemoryStream()
        Dim gzip As New GZipStream(memory, CompressionMode.Compress)
        gzip.Write(textAsBytes, 0, textAsBytes.Length)
        gzip.Close()

        Return memory.ToArray()
    End Function

    Public Function DecompressString(ByVal data As Byte()) As String
        Dim compressed As New MemoryStream(data, False)
        Dim gzip As New GZipStream(compressed, CompressionMode.Decompress)
        Dim readr As New StreamReader(gzip)
        Dim result As String = readr.ReadToEnd()
        gzip.Close()

        Return result
    End Function

End Module
