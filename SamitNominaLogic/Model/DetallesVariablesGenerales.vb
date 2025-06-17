Imports System.ComponentModel.DataAnnotations

Public Class DetallesVariablesGenerales
    Public Property Sec As Integer

    Public Property Variable As Integer?

    Public Property Valor As Decimal?

    <DisplayFormat(DataFormatString:="{0:dd/MM/yyyy HH:mm:ss}", ApplyFormatInEditMode:=True)>
    Public Property Fecha As Date?

End Class