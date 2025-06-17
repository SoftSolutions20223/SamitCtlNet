Imports SamitDatabase

<SqlTable(Nombre:="NominaLiquidadaConceptos", BaseDatos:=DatabasesSamit.NominaFull, Version:=1)>
Public Class NominaLiquidadaConceptos
    <SqlColumn(Nombre:="Sec", LlavePrimaria:=True, TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property Sec As Integer
    <SqlColumn(Nombre:="LiquidadaContrato", TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property LiquidadaContrato As Integer
    <SqlColumn(Nombre:="Valor", TipoDato:=SqlType.Money, AceptaNull:=False)>
    Public Property Valor As Decimal
    <SqlColumn(Nombre:="Base", TipoDato:=SqlType.Money, AceptaNull:=False)>
    Public Property Base As Decimal
    <SqlColumn(Nombre:="NomConcepto", TipoDato:=SqlType.VarChar, LargoColumna:=200, AceptaNull:=False)>
    Public Property NomConcepto As String
    <SqlColumn(Nombre:="SecConcepto", TipoDato:=SqlType.Int)>
    Public Property SecConcepto As Integer?
    <SqlColumn(Nombre:="NomBase", TipoDato:=SqlType.VarChar, LargoColumna:=200)>
    Public Property NomBase As String
    <SqlColumn(Nombre:="SecConceptoP", TipoDato:=SqlType.Int)>
    Public Property SecConceptoP As Integer?
    <SqlColumn(Nombre:="SecConceptoP2", TipoDato:=SqlType.Int)>
    Public Property SecConceptoP2 As Integer?
    <SqlColumn(Nombre:="Cuota", TipoDato:=SqlType.Int)>
    Public Property Cuota As Integer?
End Class