Imports Newtonsoft.Json
Imports SamitCore

Public Class SecurityHelper

    Public Shared Function GetKeyFromHeader(headerAuthorization As String, tipoRequerido As String) As ApiAutentication
        SetCulture()
        Dim credencial As New ApiAutentication

        If Not String.IsNullOrWhiteSpace(headerAuthorization) Then
            Dim headerSplited = headerAuthorization.Split(" ")
            If headerSplited.Length = 2 Then

                If headerSplited(0) = tipoRequerido Then
                    Dim keysBase64 = headerSplited(1)
                    Dim keys As String = Nothing
                    Try
                        Dim data() As Byte = System.Convert.FromBase64String(keysBase64)
                        keys = System.Text.ASCIIEncoding.ASCII.GetString(data)
                    Catch ex As Exception
                        credencial.Resultado.Estado = "ERROR"
                        credencial.Resultado.AgregarDetalle("Las credenciales del header 'Authorization' no son un texto Base64 valido.")
                    End Try

                    If Not IsNothing(keys) Then
                        Select Case headerSplited(0)
                            Case "Basic"

                                Dim UserKey = New Credenciales
                                Dim partes = keys.Split(":")
                                If partes.Length = 2 Then
                                    UserKey.Usuario = partes(0)
                                    UserKey.Clave = partes(1)

                                    credencial.Tipo = "USER"
                                    credencial.KeyUser = UserKey
                                    credencial.Resultado.Estado = "OK"
                                Else
                                    credencial.Resultado.Estado = "ERROR"
                                    credencial.Resultado.AgregarDetalle("Las credenciales del header 'Authorization' deben estan en formato 'usuario:clave'.")
                                End If

                            Case "Bearer"

                                Dim Token = New TokenData

                                Try
                                    Token = ResolveToken(keys)
                                    credencial.Tipo = "TOKEN"
                                    credencial.KeyToken = Token
                                    credencial.Resultado.Estado = "OK"
                                Catch ex As Exception
                                    credencial.Resultado.Estado = "ERROR"
                                    credencial.Resultado.AgregarDetalle("INTERNAL: " & ex.Message)
                                End Try

                        End Select
                    Else
                        credencial.Resultado.Estado = "ERROR"
                        credencial.Resultado.AgregarDetalle("No se envio ninguna key valida.")
                    End If

                Else
                    credencial.Resultado.Estado = "ERROR"
                    credencial.Resultado.AgregarDetalle("El header 'Authorization' debe ser del tipo '" & tipoRequerido & "'.")
                End If

            Else
                credencial.Resultado.Estado = "ERROR"
                credencial.Resultado.AgregarDetalle("El header 'Authorization' no cumple con los estandares.")
            End If
        Else
            credencial.Resultado.Estado = "ERROR"
            credencial.Resultado.AgregarDetalle("No se envio el header 'Authorization'.")
        End If

        Return credencial
    End Function

    Public Shared Function ResolveToken(tokenEncoded As String) As TokenData
        Dim token = New TokenData

        Dim tokenDecoded = New CryptData().Decrypt(tokenEncoded)
        token = JsonConvert.DeserializeObject(Of TokenData)(tokenDecoded)

        If token.CodSesion = 0 And token.Terminal = "WEBSTORE" Then
            token.FechaTrabajo = DateTime.Now
        End If

        Return token
    End Function

End Class
