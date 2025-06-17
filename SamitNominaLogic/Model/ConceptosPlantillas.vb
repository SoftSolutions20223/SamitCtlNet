Imports System.ComponentModel.DataAnnotations

Public Class ConceptosPlantillas
    Public Property Sec As Integer?

    <Required>
    Public Property Plantilla As Integer

    <Required>
    Public Property Concepto As Integer
End Class
