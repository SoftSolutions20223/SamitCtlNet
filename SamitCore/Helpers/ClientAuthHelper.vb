Public Class ClientAuthHelper

    Public Shared Function GetUserPassEncoded(usuario As String, clave As String) As String
        Dim userPass = usuario & ":" & clave
        Dim data As Byte() = System.Text.ASCIIEncoding.ASCII.GetBytes(userPass)
        Dim userEncoded = System.Convert.ToBase64String(data)
        Return userEncoded
    End Function

End Class
