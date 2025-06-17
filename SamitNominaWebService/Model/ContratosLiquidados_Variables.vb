Imports SamitDatabase

<SqlTable(Nombre:="ContratosLiquidados_Variables", BaseDatos:=DatabasesSamit.NominaFull, Version:=1)>
Public Class ContratosLiquidados_Variables
    <SqlColumn(Nombre:="Sec", LlavePrimaria:=True, TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property Sec As Integer
    <SqlColumn(Nombre:="SecLiquidaContrato", TipoDato:=SqlType.Int)>
    Public Property SecLiquidaContrato As Integer?
    <SqlColumn(Nombre:="Variable", TipoDato:=SqlType.Int)>
    Public Property Variable As Integer?
    <SqlColumn(Nombre:="Cantidad", TipoDato:=SqlType.Money)>
    Public Property Cantidad As Decimal?
End Class