Imports System.Data.SqlClient

Public Class FuncionesSql
    Public Function SqlConsultaMultiple(consultas() As String, ByRef conec As SqlConnection) As DataSet
        Dim dataset As New DataSet()
        Try
            For i As Integer = 0 To consultas.Length - 1
                Dim sql As String = "set dateformat dmy; " & consultas(i)
                Dim comando As New SqlCommand(sql, conec)
                Dim datos As New SqlDataAdapter(comando)
                Dim tabla As New DataTable($"Tabla{i}")
                Try
                    datos.Fill(tabla)
                    dataset.Tables.Add(tabla)
                Catch e As Exception

                Finally
                    comando.Dispose()
                    datos.Dispose()
                End Try
            Next
        Catch e As Exception
            Return Nothing
        Finally

        End Try
        Return dataset
    End Function
End Class
