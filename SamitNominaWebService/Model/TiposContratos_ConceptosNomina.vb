Imports SamitDatabase

<SqlTable(Nombre:="TiposContratos_ConceptosNomina", BaseDatos:=DatabasesSamit.NominaFull, Version:=1)>
Public Class TiposContratos_ConceptosNomina
    <SqlColumn(Nombre:="Sec", LlavePrimaria:=True, TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property Sec As Integer
    <SqlColumn(Nombre:="Concepto", TipoDato:=SqlType.Int)>
    Public Property Concepto As Integer?
    <SqlColumn(Nombre:="TipoContrato", TipoDato:=SqlType.Int)>
    Public Property TipoContrato As Integer?
    <SqlColumn(Nombre:="Formula", TipoDato:=SqlType.VarChar, LargoColumna:=2000)>
    Public Property Formula As String
    <SqlColumn(Nombre:="BaseCalculo", TipoDato:=SqlType.VarChar, LargoColumna:=200)>
    Public Property BaseCalculo As String
    <SqlColumn(Nombre:="SeLiquida", TipoDato:=SqlType.Bit)>
    Public Property SeLiquida As Boolean?
    <SqlColumn(Nombre:="CuentaContable", TipoDato:=SqlType.VarChar, LargoColumna:=20)>
    Public Property CuentaContable As String
End Class