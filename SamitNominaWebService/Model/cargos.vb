Imports SamitDatabase

<SqlTable(Nombre:="Cargos", BaseDatos:=DatabasesSamit.NominaFull, Version:=1)>
Public Class cargos
    <SqlColumn(Nombre:="Sec", LlavePrimaria:=True, TipoDato:=SqlType.Int, AceptaNull:=False, Identity:=True, IdentityInicio:=1, IdentityAumento:=1)>
    Public Property Sec As Integer
    <SqlColumn(Nombre:="CodCargo", TipoDato:=SqlType.VarChar, LargoColumna:=20, AceptaNull:=False)>
    Public Property CodCargo As String
    <SqlColumn(Nombre:="Denominacion", TipoDato:=SqlType.VarChar, LargoColumna:=100, AceptaNull:=False)>
    Public Property Denominacion As String
    <SqlColumn(Nombre:="Descripcion", TipoDato:=SqlType.VarChar, LargoColumna:=1000, AceptaNull:=False)>
    Public Property Descripcion As String
End Class