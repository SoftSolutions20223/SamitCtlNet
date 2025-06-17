Imports SamitDatabase

<SqlTable(Nombre:="Empleados", BaseDatos:=DatabasesSamit.NominaFull, Version:=1)>
Public Class Empleados
    <SqlColumn(Nombre:="Sec", LlavePrimaria:=True, TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property Sec As Integer
    <SqlColumn(Nombre:="TipoIdentificacion", TipoDato:=SqlType.VarChar, LargoColumna:=4, AceptaNull:=False)>
    Public Property TipoIdentificacion As String
    <SqlColumn(Nombre:="Identificacion", TipoDato:=SqlType.BigInt, AceptaNull:=False)>
    Public Property Identificacion As Long
    <SqlColumn(Nombre:="Dv", TipoDato:=SqlType.VarChar, LargoColumna:=1)>
    Public Property Dv As String
    <SqlColumn(Nombre:="PApellido", TipoDato:=SqlType.VarChar, LargoColumna:=50, AceptaNull:=False)>
    Public Property PApellido As String
    <SqlColumn(Nombre:="SApellido", TipoDato:=SqlType.VarChar, LargoColumna:=50)>
    Public Property SApellido As String
    <SqlColumn(Nombre:="PNombre", TipoDato:=SqlType.VarChar, LargoColumna:=50)>
    Public Property PNombre As String
    <SqlColumn(Nombre:="SNombre", TipoDato:=SqlType.VarChar, LargoColumna:=50)>
    Public Property SNombre As String
    <SqlColumn(Nombre:="Genero", TipoDato:=SqlType.VarChar, LargoColumna:=1)>
    Public Property Genero As String
    <SqlColumn(Nombre:="FechaNacimiento", TipoDato:=SqlType.DateTime)>
    Public Property FechaNacimiento As Date?
    <SqlColumn(Nombre:="MunicipioNacimiento", TipoDato:=SqlType.VarChar, LargoColumna:=6)>
    Public Property MunicipioNacimiento As String
    <SqlColumn(Nombre:="FechaExpDoc", TipoDato:=SqlType.DateTime)>
    Public Property FechaExpDoc As Date?
    <SqlColumn(Nombre:="LugarExpDoc", TipoDato:=SqlType.VarChar, LargoColumna:=6)>
    Public Property LugarExpDoc As String
    <SqlColumn(Nombre:="Direccion", TipoDato:=SqlType.VarChar, LargoColumna:=150)>
    Public Property Direccion As String
    <SqlColumn(Nombre:="Barrio", TipoDato:=SqlType.VarChar, LargoColumna:=50)>
    Public Property Barrio As String
    <SqlColumn(Nombre:="Municipio", TipoDato:=SqlType.VarChar, LargoColumna:=6)>
    Public Property Municipio As String
    <SqlColumn(Nombre:="Email1", TipoDato:=SqlType.VarChar, LargoColumna:=50)>
    Public Property Email1 As String
    <SqlColumn(Nombre:="Email2", TipoDato:=SqlType.VarChar, LargoColumna:=50)>
    Public Property Email2 As String
    <SqlColumn(Nombre:="Profesion", TipoDato:=SqlType.Int)>
    Public Property Profesion As Integer?
    <SqlColumn(Nombre:="PersonasaCargo", TipoDato:=SqlType.Int)>
    Public Property PersonasaCargo As Integer?
    <SqlColumn(Nombre:="EstadoCivil", TipoDato:=SqlType.TinyInt)>
    Public Property EstadoCivil As Byte?
    <SqlColumn(Nombre:="Tel1", TipoDato:=SqlType.VarChar, LargoColumna:=25)>
    Public Property Tel1 As String
    <SqlColumn(Nombre:="Tel2", TipoDato:=SqlType.VarChar, LargoColumna:=25)>
    Public Property Tel2 As String
    <SqlColumn(Nombre:="NumCelular", TipoDato:=SqlType.VarChar, LargoColumna:=25)>
    Public Property NumCelular As String
    <SqlColumn(Nombre:="WebPage", TipoDato:=SqlType.VarChar, LargoColumna:=100)>
    Public Property WebPage As String
    <SqlColumn(Nombre:="LicConduccion", TipoDato:=SqlType.VarChar, LargoColumna:=50)>
    Public Property LicConduccion As String
    <SqlColumn(Nombre:="LicCategoria", TipoDato:=SqlType.VarChar, LargoColumna:=10)>
    Public Property LicCategoria As String
    <SqlColumn(Nombre:="ClaseLib", TipoDato:=SqlType.Int)>
    Public Property ClaseLib As Integer?
    <SqlColumn(Nombre:="NumLib", TipoDato:=SqlType.VarChar, LargoColumna:=20)>
    Public Property NumLib As String
    <SqlColumn(Nombre:="DistritoLib", TipoDato:=SqlType.VarChar, LargoColumna:=20)>
    Public Property DistritoLib As String
    <SqlColumn(Nombre:="Foto", TipoDato:=SqlType.NVarChar)>
    Public Property Foto As String
    <SqlColumn(Nombre:="Comentario", TipoDato:=SqlType.VarChar, LargoColumna:=250)>
    Public Property Comentario As String
    <SqlColumn(Nombre:="ActividadEco", TipoDato:=SqlType.VarChar, LargoColumna:=6)>
    Public Property ActividadEco As String
    <SqlColumn(Nombre:="FechaIngreso", TipoDato:=SqlType.DateTime)>
    Public Property FechaIngreso As Date?
    <SqlColumn(Nombre:="FechaGen", TipoDato:=SqlType.DateTime)>
    Public Property FechaGen As Date?
    <SqlColumn(Nombre:="UsrGen", TipoDato:=SqlType.VarChar, LargoColumna:=20)>
    Public Property UsrGen As String
    <SqlColumn(Nombre:="FechaMod", TipoDato:=SqlType.DateTime)>
    Public Property FechaMod As Date?
    <SqlColumn(Nombre:="UsrMod", TipoDato:=SqlType.VarChar, LargoColumna:=20)>
    Public Property UsrMod As String
    <SqlColumn(Nombre:="Pensionado", TipoDato:=SqlType.Bit)>
    Public Property Pensionado As Boolean?
    <SqlColumn(Nombre:="codBanco", TipoDato:=SqlType.Int)>
    Public Property codBanco As Integer?
    <SqlColumn(Nombre:="NumCuenta", TipoDato:=SqlType.VarChar, LargoColumna:=80)>
    Public Property NumCuenta As String
    <SqlColumn(Nombre:="TipoCuenta", TipoDato:=SqlType.Int)>
    Public Property TipoCuenta As Integer?
End Class
