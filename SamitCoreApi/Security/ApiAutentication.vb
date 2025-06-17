Imports Newtonsoft.Json

Public Class ApiAutentication

    ''' <summary>
    ''' - USER
    ''' - TOKEN
    ''' </summary>
    ''' <returns></returns>
    Public Property Tipo As String

    Public Property KeyUser As Credenciales
    Public Property KeyToken As TokenData

    <JsonIgnore>
    Public Property Resultado As New ApiResponse

End Class

Public Class Credenciales

    Public Property Usuario As String
    Public Property Clave As String

    <JsonIgnore>
    Public Property Resultado As New ApiResponse

End Class