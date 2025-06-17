Imports SamitDatabase

<SqlTable(Nombre:="Contratos_CentroCostos", BaseDatos:=DatabasesSamit.NominaFull, Version:=1)>
Public Class Contratos_CentroCostos
    <SqlColumn(Nombre:="Sec", LlavePrimaria:=True, TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property Sec As Integer
    <SqlColumn(Nombre:="Contrato", TipoDato:=SqlType.Int)>
    Public Property Contrato As Integer?
    <SqlColumn(Nombre:="CentroCosto", TipoDato:=SqlType.Int)>
    Public Property CentroCosto As Integer?
    <SqlColumn(Nombre:="Porcentaje", TipoDato:=SqlType.Decimal, LargoColumna:=18, PrecisionColumna:=1)>
    Public Property Porcentaje As Decimal?
End Class