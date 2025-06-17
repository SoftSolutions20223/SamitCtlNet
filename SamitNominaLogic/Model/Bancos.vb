Imports System.ComponentModel.DataAnnotations

Public Class Bancos

    Public Property Sec As Integer
    <Required(AllowEmptyStrings:=False)>
    <MaxLength(250)>
    Public Property Nombre As String
    <Required>
    Public Property Vigente As Boolean
End Class
