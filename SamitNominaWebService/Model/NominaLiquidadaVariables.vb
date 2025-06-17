Imports SamitDatabase

<SqlTable(Nombre:="NominaLiquidadaVariables", BaseDatos:=DatabasesSamit.NominaFull, Version:=1)>
Public Class NominaLiquidadaVariables
    <SqlColumn(Nombre:="Sec", TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property Sec As Integer
    <SqlColumn(Nombre:="SecLiquidadaContrato", LlavePrimaria:=True, TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property SecLiquidadaContrato As Integer
    <SqlColumn(Nombre:="Variable", LlavePrimaria:=True, TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property Variable As Integer
    <SqlColumn(Nombre:="Cantidad", TipoDato:=SqlType.Money, AceptaNull:=False)>
    Public Property Cantidad As Decimal
End Class