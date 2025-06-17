Imports System.ComponentModel.DataAnnotations

Public Class Empleados_Educacion
    Public Property Sec As Integer

    <Required>
    Public Property Empleado As Integer

    <Required>
    Public Property NivelEstudio As Integer

    <Required>
    <DisplayFormat(DataFormatString:="{0:dd/MM/yyyy HH:mm:ss}", ApplyFormatInEditMode:=True)>
    Public Property FechaGrado As Date

    <Required>
    Public Property Duracion As Integer

    Public Property TipoTiempo As Integer?

    Public Property IdTituloObtenido As Integer?

    <MaxLength(100)>
    Public Property NombreInstitucion As String

    <MaxLength(15)>
    Public Property MatriculaProfesional As String

    <MaxLength(6)>
    Public Property LugarTitulo As String

End Class