Imports System.ComponentModel.DataAnnotations

Public Class CAT_TipoContratos
    Public Property Sec As Integer

    <Required(AllowEmptyStrings:=False)>
    <MaxLength(50)>
    Public Property NomTipo As String
End Class