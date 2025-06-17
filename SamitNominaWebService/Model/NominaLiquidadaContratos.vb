Imports SamitDatabase

<SqlTable(Nombre:="NominaLiquidadaContratos", BaseDatos:=DatabasesSamit.NominaFull, Version:=1)>
Public Class NominaLiquidadaContratos
    <SqlColumn(Nombre:="Sec", LlavePrimaria:=True, TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property Sec As Integer
    <SqlColumn(Nombre:="Contrato", TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property Contrato As Integer
    <SqlColumn(Nombre:="NominaLiquidada", TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property NominaLiquidada As Integer
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
    <SqlColumn(Nombre:="Cufe", TipoDato:=SqlType.VarChar, LargoColumna:=200)>
    Public Property Cufe As String
    <SqlColumn(Nombre:="Estado", TipoDato:=SqlType.VarChar, LargoColumna:=500)>
    Public Property Estado As String
    <SqlColumn(Nombre:="DoceId", TipoDato:=SqlType.VarChar, LargoColumna:=200)>
    Public Property DoceId As String
    <SqlColumn(Nombre:="Contabilizada", TipoDato:=SqlType.Bit)>
    Public Property Contabilizada As Boolean?
    <SqlColumn(Nombre:="FormaDePago", TipoDato:=SqlType.VarChar, LargoColumna:=20)>
    Public Property FormaDePago As String
    <SqlColumn(Nombre:="DocContable", TipoDato:=SqlType.VarChar, LargoColumna:=50)>
    Public Property DocContable As String
    <SqlColumn(Nombre:="EstadoCont", TipoDato:=SqlType.VarChar, LargoColumna:=50)>
    Public Property EstadoCont As String
End Class