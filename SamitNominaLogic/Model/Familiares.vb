Imports System.ComponentModel.DataAnnotations

Public Class Familiares
    Public Property Sec As Integer

    <Required(AllowEmptyStrings:=False)>
    <MaxLength(4)>
    Public Property TipoIdentificacion As String

    <Required>
    Public Property Identificacion As Integer

    <MaxLength(200)>
    Public Property Nombre As String

    <DisplayFormat(DataFormatString:="{0:dd/MM/yyyy HH:mm:ss}", ApplyFormatInEditMode:=True)>
    Public Property FechaNacimiento As Date?

    <MaxLength(50)>
    Public Property Ocupacion As String

    <MaxLength(50)>
    Public Property EmpresaWk As String

    <MaxLength(50)>
    Public Property CargoActual As String

    <MaxLength(50)>
    Public Property Telefonos As String

    <MaxLength(50)>
    Public Property Celular As String

    <MaxLength(50)>
    Public Property Direccion As String

    <Required(AllowEmptyStrings:=False)>
    <MaxLength(50)>
    Public Property Ciudad As String

End Class