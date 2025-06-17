Imports System.ComponentModel.DataAnnotations

Public Class Cargos
    Public Property Sec As Integer

    <Required(AllowEmptyStrings:=False)>
    <MaxLength(20)>
    Public Property CodCargo As String

    <Required(AllowEmptyStrings:=False)>
    <MaxLength(100)>
    Public Property Denominacion As String

    <Required(AllowEmptyStrings:=False)>
    <MaxLength(1000)>
    Public Property Descripcion As String
End Class
