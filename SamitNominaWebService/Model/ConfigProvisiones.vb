Imports SamitDatabase

<SqlTable(Nombre:="ConfigProvisiones", BaseDatos:=DatabasesSamit.NominaFull, Version:=1)>
Public Class ConfigProvisiones
    <SqlColumn(Nombre:="Sec", LlavePrimaria:=True, TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property Sec As Integer
    <SqlColumn(Nombre:="Concepto", TipoDato:=SqlType.Int)>
    Public Property Concepto As Integer?
    <SqlColumn(Nombre:="Formula", TipoDato:=SqlType.VarChar, LargoColumna:=2000)>
    Public Property Formula As String
    <SqlColumn(Nombre:="SemestresLiquida", TipoDato:=SqlType.VarChar, LargoColumna:=20)>
    Public Property SemestresLiquida As String
    <SqlColumn(Nombre:="CuentaContable", TipoDato:=SqlType.VarChar, LargoColumna:=20)>
    Public Property CuentaContable As String
    <SqlColumn(Nombre:="Nomina", TipoDato:=SqlType.Int)>
    Public Property Nomina As Integer?
End Class