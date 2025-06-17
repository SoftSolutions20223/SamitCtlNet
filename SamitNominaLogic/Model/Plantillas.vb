Imports System.ComponentModel.DataAnnotations

Public Class Plantillas
    Public Property Sec As Integer

    <MaxLength(50)>
    Public Property NomPlantilla As String

    <MaxLength(1)>
    Public Property Vigente As String

    <MaxLength(2000)>
    Public Property ValorMaxDescontar As String

End Class