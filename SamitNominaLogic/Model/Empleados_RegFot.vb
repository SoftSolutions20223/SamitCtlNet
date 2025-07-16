Imports System.ComponentModel.DataAnnotations

Public Class Empleados_RegFot
    Public Property Sec As Integer

    <Required>
    Public Property IdEmpleado As Integer

    <Required>
    Public Property Item As Integer

    <Required>
    Public Property Tipo As Integer

    <Required>
    Public Property SecTipo As Integer

    Public Property Foto As String

    Public Property Predeterminada As Boolean?

    <MaxLength(250)>
    Public Property Descripcion As String

End Class