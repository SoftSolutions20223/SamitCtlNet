Imports SamitDatabase

<SqlTable(Nombre:="NominaLiquidaVariables", BaseDatos:=DatabasesSamit.NominaFull, Version:=1)>
Public Class NominaLiquidaVariables
    <SqlColumn(Nombre:="Sec", LlavePrimaria:=True, TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property Sec As Integer
    <SqlColumn(Nombre:="SecLiquidaContrato", LlavePrimaria:=True, TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property SecLiquidaContrato As Integer
    <SqlColumn(Nombre:="Variable", LlavePrimaria:=True, TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property Variable As Integer
    <SqlColumn(Nombre:="Cantidad", TipoDato:=SqlType.Money, AceptaNull:=False)>
    Public Property Cantidad As Decimal
End Class