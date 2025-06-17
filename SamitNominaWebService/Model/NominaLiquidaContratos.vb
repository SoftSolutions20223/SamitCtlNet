Imports SamitDatabase

<SqlTable(Nombre:="NominaLiquidaContratos", BaseDatos:=DatabasesSamit.NominaFull, Version:=1)>
Public Class NominaLiquidaContratos
    <SqlColumn(Nombre:="Sec", LlavePrimaria:=True, TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property Sec As Integer
    <SqlColumn(Nombre:="Contrato", TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property Contrato As Integer
    <SqlColumn(Nombre:="NominaLiquida", TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property NominaLiquida As Integer
    <SqlColumn(Nombre:="Total", TipoDato:=SqlType.Money, AceptaNull:=False)>
    Public Property Total As Decimal
    <SqlColumn(Nombre:="HorasMes", TipoDato:=SqlType.Int)>
    Public Property HorasMes As Integer?
    <SqlColumn(Nombre:="CargoActual", TipoDato:=SqlType.Int)>
    Public Property CargoActual As Integer?
    <SqlColumn(Nombre:="Asignacion", TipoDato:=SqlType.Money)>
    Public Property Asignacion As Decimal?
    <SqlColumn(Nombre:="TotalProvisiones", TipoDato:=SqlType.Money)>
    Public Property TotalProvisiones As Decimal?
    <SqlColumn(Nombre:="TotalFondos", TipoDato:=SqlType.Money)>
    Public Property TotalFondos As Decimal?
    <SqlColumn(Nombre:="TotalIngresos", TipoDato:=SqlType.Money)>
    Public Property TotalIngresos As Decimal?
    <SqlColumn(Nombre:="TotalDeducciones", TipoDato:=SqlType.Money)>
    Public Property TotalDeducciones As Decimal?
    <SqlColumn(Nombre:="Comentario", TipoDato:=SqlType.VarChar, LargoColumna:=2000)>
    Public Property Comentario As String
    <SqlColumn(Nombre:="TotalDescuentosNomina", TipoDato:=SqlType.Money)>
    Public Property TotalDescuentosNomina As Decimal?
End Class