Imports System.ComponentModel.DataAnnotations

Public Class CAT_ClaseLicencia
    Public Property Sec As Integer?

    <Required(AllowEmptyStrings:=False)>
    <MaxLength(10)>
    Public Property idClase As String

    <MaxLength(350)>
    Public Property NomClase As String

    Public Property Vigente As Boolean?
End Class
