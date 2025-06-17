Imports System.Configuration

Public Class ConfigReader
    Public Shared Function GetConfigValue(key As String, Optional defaultValue As String = "") As String
        Try
            Dim value As String = ConfigurationManager.AppSettings(key)

            If String.IsNullOrEmpty(value) Then
                Return defaultValue
            End If

            Return value

        Catch ex As Exception
            MessageBox.Show($"Error reading configuration: {ex.Message}")
            Return defaultValue
        End Try
    End Function
End Class