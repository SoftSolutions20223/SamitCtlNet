Imports System.ComponentModel.DataAnnotations

Public Class CAT_TiposId
    Public Property Sec As Integer?

    <Required(AllowEmptyStrings:=False)>
    <MaxLength(4)>
    Public Property TipoIdentificacion As String

    <Required(AllowEmptyStrings:=False)>
    <MaxLength(50)>
    Public Property NomTipo As String

    <Required>
    Public Property UsaEmpleados As Boolean

    <Required>
    Public Property UsaParientes As Boolean

    <Required(AllowEmptyStrings:=False)>
    <MaxLength(50)>
    Public Property Codigo As String
End Class
