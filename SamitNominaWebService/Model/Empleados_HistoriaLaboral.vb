Imports SamitDatabase

<SqlTable(Nombre:="Empleados_HistoriaLaboral", BaseDatos:=DatabasesSamit.NominaFull, Version:=1)>
Public Class Empleados_HistoriaLaboral
    <SqlColumn(Nombre:="Sec", LlavePrimaria:=True, TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property Sec As Integer
    <SqlColumn(Nombre:="Empleado", TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property Empleado As Integer
    <SqlColumn(Nombre:="Empresa", TipoDato:=SqlType.VarChar, LargoColumna:=100)>
    Public Property Empresa As String
    <SqlColumn(Nombre:="Cargo", TipoDato:=SqlType.VarChar, LargoColumna:=200)>
    Public Property Cargo As String
    <SqlColumn(Nombre:="FechaIngreso", TipoDato:=SqlType.DateTime)>
    Public Property FechaIngreso As Date?
    <SqlColumn(Nombre:="FechaRetiro", TipoDato:=SqlType.DateTime)>
    Public Property FechaRetiro As Date?
    <SqlColumn(Nombre:="TelEmpresa", TipoDato:=SqlType.VarChar, LargoColumna:=20)>
    Public Property TelEmpresa As String
    <SqlColumn(Nombre:="Direccion", TipoDato:=SqlType.VarChar, LargoColumna:=50)>
    Public Property Direccion As String
    <SqlColumn(Nombre:="JefeInmediato", TipoDato:=SqlType.VarChar, LargoColumna:=50)>
    Public Property JefeInmediato As String
    <SqlColumn(Nombre:="ImgDocumento", TipoDato:=SqlType.Image)>
    Public Property ImgDocumento As Byte()
End Class