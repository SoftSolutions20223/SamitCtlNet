Imports System.ComponentModel.DataAnnotations

Public Class Empleados

    Public Property Sec As Integer

    <Required(AllowEmptyStrings:=False)>
    <MaxLength(4)>
    Public Property TipoIdentificacion As String

    <Required>
    Public Property Identificacion As Long

    <MaxLength(1)>
    Public Property Dv As String

    <Required(AllowEmptyStrings:=False)>
    <MaxLength(50)>
    Public Property PApellido As String

    <MaxLength(50)>
    Public Property SApellido As String

    <MaxLength(50)>
    Public Property PNombre As String

    <MaxLength(50)>
    Public Property SNombre As String

    <MaxLength(1)>
    Public Property Genero As String

    <DisplayFormat(DataFormatString:="{0:dd/MM/yyyy HH:mm:ss}", ApplyFormatInEditMode:=True)>
    Public Property FechaNacimiento As Date?

    <MaxLength(6)>
    Public Property MunicipioNacimiento As String

    <DisplayFormat(DataFormatString:="{0:dd/MM/yyyy HH:mm:ss}", ApplyFormatInEditMode:=True)>
    Public Property FechaExpDoc As Date?

    <MaxLength(6)>
    Public Property LugarExpDoc As String

    <MaxLength(150)>
    Public Property Direccion As String

    <MaxLength(50)>
    Public Property Barrio As String

    <MaxLength(6)>
    Public Property Municipio As String

    <MaxLength(50)>
    Public Property Email1 As String

    <MaxLength(50)>
    Public Property Email2 As String

    Public Property Profesion As Integer?

    Public Property PersonasaCargo As Integer?

    Public Property EstadoCivil As Byte?

    <MaxLength(25)>
    Public Property Tel1 As String

    <MaxLength(25)>
    Public Property Tel2 As String

    <MaxLength(25)>
    Public Property NumCelular As String

    <MaxLength(100)>
    Public Property WebPage As String

    <MaxLength(50)>
    Public Property LicConduccion As String

    <MaxLength(10)>
    Public Property LicCategoria As String

    Public Property ClaseLib As Integer?

    <MaxLength(20)>
    Public Property NumLib As String

    <MaxLength(20)>
    Public Property DistritoLib As String

    Public Property Foto As String

    <MaxLength(250)>
    Public Property Comentario As String

    <MaxLength(6)>
    Public Property ActividadEco As String

    <DisplayFormat(DataFormatString:="{0:dd/MM/yyyy HH:mm:ss}", ApplyFormatInEditMode:=True)>
    Public Property FechaIngreso As Date?

    <DisplayFormat(DataFormatString:="{0:dd/MM/yyyy HH:mm:ss}", ApplyFormatInEditMode:=True)>
    Public Property FechaGen As Date?

    <MaxLength(20)>
    Public Property UsrGen As String

    <DisplayFormat(DataFormatString:="{0:dd/MM/yyyy HH:mm:ss}", ApplyFormatInEditMode:=True)>
    Public Property FechaMod As Date?

    <MaxLength(20)>
    Public Property UsrMod As String

    Public Property Pensionado As Boolean?

    Public Property codBanco As Integer?

    <MaxLength(80)>
    Public Property NumCuenta As String

    Public Property TipoCuenta As Integer?

End Class
