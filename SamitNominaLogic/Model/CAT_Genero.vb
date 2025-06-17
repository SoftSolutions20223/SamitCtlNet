Imports System.ComponentModel.DataAnnotations

Public Class CAT_Genero
    <Required(AllowEmptyStrings:=False)>
    Public Property idgenero As String

    <MaxLength(50)>
    Public Property nomgenero As String

    Public Property vigente As Boolean?
End Class
