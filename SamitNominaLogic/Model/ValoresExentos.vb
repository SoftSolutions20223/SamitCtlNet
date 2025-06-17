Imports System.ComponentModel.DataAnnotations

Public Class ValoresExentos
    Public Property Sec As Integer

    <MaxLength(200)>
    Public Property Nom As String

    Public Property Vigente As Boolean?

    <MaxLength(1)>
    Public Property TipoValor As String

End Class