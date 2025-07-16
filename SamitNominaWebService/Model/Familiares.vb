Imports SamitDatabase

<SqlTable(Nombre:="Familiares", BaseDatos:=DatabasesSamit.NominaFull, Version:=1)>
Public Class Familiares
    <SqlColumn(Nombre:="Sec", LlavePrimaria:=True, TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property Sec As Integer
    <SqlColumn(Nombre:="TipoIdentificacion", TipoDato:=SqlType.VarChar, LargoColumna:=4, AceptaNull:=False)>
    Public Property TipoIdentificacion As String
    <SqlColumn(Nombre:="Identificacion", TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property Identificacion As Integer
    <SqlColumn(Nombre:="Nombre", TipoDato:=SqlType.VarChar, LargoColumna:=200)>
    Public Property Nombre As String
    <SqlColumn(Nombre:="FechaNacimiento", TipoDato:=SqlType.DateTime)>
    Public Property FechaNacimiento As Date?
    <SqlColumn(Nombre:="Ocupacion", TipoDato:=SqlType.VarChar, LargoColumna:=50)>
    Public Property Ocupacion As String
    <SqlColumn(Nombre:="EmpresaWk", TipoDato:=SqlType.VarChar, LargoColumna:=50)>
    Public Property EmpresaWk As String
    <SqlColumn(Nombre:="CargoActual", TipoDato:=SqlType.VarChar, LargoColumna:=50)>
    Public Property CargoActual As String
    <SqlColumn(Nombre:="Telefonos", TipoDato:=SqlType.VarChar, LargoColumna:=50)>
    Public Property Telefonos As String
    <SqlColumn(Nombre:="Celular", TipoDato:=SqlType.VarChar, LargoColumna:=50)>
    Public Property Celular As String
    <SqlColumn(Nombre:="Direccion", TipoDato:=SqlType.VarChar, LargoColumna:=50)>
    Public Property Direccion As String
    <SqlColumn(Nombre:="Ciudad", TipoDato:=SqlType.VarChar, LargoColumna:=50, AceptaNull:=False)>
    Public Property Ciudad As String
End Class
