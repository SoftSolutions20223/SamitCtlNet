Imports System.ComponentModel.DataAnnotations

Public Class CodigosDian
    Public Property Sec As Integer

    <Required(AllowEmptyStrings:=False)>
    <MaxLength(10)>
    Public Property Codigo As String

    <MaxLength(2000)>
    Public Property Descripcion As String
End Class
