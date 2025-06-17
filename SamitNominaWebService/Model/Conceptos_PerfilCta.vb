Imports SamitDatabase

<SqlTable(Nombre:="Conceptos_PerfilCta", BaseDatos:=DatabasesSamit.NominaFull, Version:=1)>
Public Class Conceptos_PerfilCta
    <SqlColumn(Nombre:="Sec", LlavePrimaria:=True, TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property Sec As Integer
    <SqlColumn(Nombre:="Concepto", TipoDato:=SqlType.Int)>
    Public Property Concepto As Integer?
    <SqlColumn(Nombre:="CuentaContable", TipoDato:=SqlType.VarChar, LargoColumna:=20)>
    Public Property CuentaContable As String
    <SqlColumn(Nombre:="ConceptoR", TipoDato:=SqlType.Int)>
    Public Property ConceptoR As Integer?
    <SqlColumn(Nombre:="ContraPartida", TipoDato:=SqlType.VarChar, LargoColumna:=20)>
    Public Property ContraPartida As String
    <SqlColumn(Nombre:="PerfilCta", TipoDato:=SqlType.Int)>
    Public Property PerfilCta As Integer?
    <SqlColumn(Nombre:="Naturaleza", TipoDato:=SqlType.VarChar, LargoColumna:=1)>
    Public Property Naturaleza As String
End Class