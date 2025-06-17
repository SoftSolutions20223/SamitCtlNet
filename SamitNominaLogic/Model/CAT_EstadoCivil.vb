Imports System.ComponentModel.DataAnnotations

Public Class CAT_EstadoCivil
    Public Property Sec As Integer?

    <Required>
    Public Property IdEstado As Byte

    <Required(AllowEmptyStrings:=False)>
    <MaxLength(50)>
    Public Property NomEstado As String

    <Required>
    Public Property Vigente As Boolean
End Class
