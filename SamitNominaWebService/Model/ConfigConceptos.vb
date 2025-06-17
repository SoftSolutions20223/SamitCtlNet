Imports SamitDatabase

<SqlTable(Nombre:="ConfigConceptos", BaseDatos:=DatabasesSamit.NominaFull, Version:=1)>
Public Class ConfigConceptos
    <SqlColumn(Nombre:="Sec", LlavePrimaria:=True, TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property Sec As Integer
    <SqlColumn(Nombre:="Nomina", TipoDato:=SqlType.Int)>
    Public Property Nomina As Integer?
    <SqlColumn(Nombre:="Concepto", TipoDato:=SqlType.Int)>
    Public Property Concepto As Integer?
    <SqlColumn(Nombre:="Formula", TipoDato:=SqlType.VarChar, LargoColumna:=2000)>
    Public Property Formula As String
    <SqlColumn(Nombre:="PeriodosLiquida", TipoDato:=SqlType.VarChar, LargoColumna:=20)>
    Public Property PeriodosLiquida As String
    <SqlColumn(Nombre:="CuentaContable", TipoDato:=SqlType.VarChar, LargoColumna:=20)>
    Public Property CuentaContable As String
    <SqlColumn(Nombre:="ConceptoR", TipoDato:=SqlType.Int)>
    Public Property ConceptoR As Integer?
    <SqlColumn(Nombre:="ContraPartida", TipoDato:=SqlType.VarChar, LargoColumna:=20)>
    Public Property ContraPartida As String
End Class