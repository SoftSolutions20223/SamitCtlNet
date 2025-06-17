Imports SamitDatabase

<SqlTable(Nombre:="Empleados_RegFot", BaseDatos:=DatabasesSamit.NominaFull, Version:=1)>
Public Class Empleados_RegFot
    <SqlColumn(Nombre:="Sec", LlavePrimaria:=True, TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property Sec As Integer
    <SqlColumn(Nombre:="IdEmpleado", LlavePrimaria:=True, TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property IdEmpleado As Integer
    <SqlColumn(Nombre:="Item", LlavePrimaria:=True, TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property Item As Integer
    <SqlColumn(Nombre:="Tipo", LlavePrimaria:=True, TipoDato:=SqlType.TinyInt, AceptaNull:=False)>
    Public Property Tipo As Byte
    <SqlColumn(Nombre:="SecTipo", LlavePrimaria:=True, TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property SecTipo As Integer
    <SqlColumn(Nombre:="Foto", TipoDato:=SqlType.NVarChar)>
    Public Property Foto As String()
    <SqlColumn(Nombre:="Predeterminada", TipoDato:=SqlType.Bit)>
    Public Property Predeterminada As Boolean?
    <SqlColumn(Nombre:="Descripcion", TipoDato:=SqlType.VarChar, LargoColumna:=250)>
    Public Property Descripcion As String
End Class