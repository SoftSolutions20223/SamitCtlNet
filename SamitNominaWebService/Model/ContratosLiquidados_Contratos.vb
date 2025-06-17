Imports SamitDatabase

<SqlTable(Nombre:="ContratosLiquidados_Contratos", BaseDatos:=DatabasesSamit.NominaFull, Version:=1)>
Public Class ContratosLiquidados_Contratos
    <SqlColumn(Nombre:="Sec", LlavePrimaria:=True, TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property Sec As Integer
    <SqlColumn(Nombre:="Contrato", TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property Contrato As Integer
    <SqlColumn(Nombre:="NominaLiquida", TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property NominaLiquida As Integer
    <SqlColumn(Nombre:="Total", TipoDato:=SqlType.Money, AceptaNull:=False)>
    Public Property Total As Decimal
    <SqlColumn(Nombre:="CargoActual", TipoDato:=SqlType.Int)>
    Public Property CargoActual As Integer?
    <SqlColumn(Nombre:="TotalIngresos", TipoDato:=SqlType.Money)>
    Public Property TotalIngresos As Decimal?
    <SqlColumn(Nombre:="TotalDeducciones", TipoDato:=SqlType.Money)>
    Public Property TotalDeducciones As Decimal?
    <SqlColumn(Nombre:="TotalDescuentosNomina", TipoDato:=SqlType.Money)>
    Public Property TotalDescuentosNomina As Decimal?
    <SqlColumn(Nombre:="Contabilizada", TipoDato:=SqlType.Bit)>
    Public Property Contabilizada As Boolean?
    <SqlColumn(Nombre:="FormaDePago", TipoDato:=SqlType.VarChar, LargoColumna:=20)>
    Public Property FormaDePago As String
    <SqlColumn(Nombre:="DocContable", TipoDato:=SqlType.VarChar, LargoColumna:=50)>
    Public Property DocContable As String
    <SqlColumn(Nombre:="EstadoCont", TipoDato:=SqlType.VarChar, LargoColumna:=50)>
    Public Property EstadoCont As String
End Class

