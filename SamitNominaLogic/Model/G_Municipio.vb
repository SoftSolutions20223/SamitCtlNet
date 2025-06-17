Imports System.ComponentModel.DataAnnotations

Public Class G_Municipio
    Public Property Sec As Integer

    <Required(AllowEmptyStrings:=False)>
    <MaxLength(3)>
    Public Property Departamento As String

    <Required(AllowEmptyStrings:=False)>
    <MaxLength(6)>
    Public Property IdMunicipio As String

    <MaxLength(50)>
    Public Property NombreMunicipio As String

End Class
