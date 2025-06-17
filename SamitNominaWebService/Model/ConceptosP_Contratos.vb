Imports SamitDatabase

<SqlTable(Nombre:="ConceptosP_Contratos", BaseDatos:=DatabasesSamit.NominaFull, Version:=1)>
Public Class ConceptosP_Contratos
    <SqlColumn(Nombre:="Sec", LlavePrimaria:=True, TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property Sec As Integer
    <SqlColumn(Nombre:="Contrato", TipoDato:=SqlType.Int)>
    Public Property Contrato As Integer?
    <SqlColumn(Nombre:="Concepto", TipoDato:=SqlType.Int)>
    Public Property Concepto As Integer?
    <SqlColumn(Nombre:="TotalDescontar", TipoDato:=SqlType.Money)>
    Public Property TotalDescontar As Decimal?
    <SqlColumn(Nombre:="DescontarPeriodo", TipoDato:=SqlType.Money)>
    Public Property DescontarPeriodo As Decimal?
    <SqlColumn(Nombre:="TotalDescontado", TipoDato:=SqlType.Money)>
    Public Property TotalDescontado As Decimal?
    <SqlColumn(Nombre:="FechaInicio", TipoDato:=SqlType.Date)>
    Public Property FechaInicio As Date?
    <SqlColumn(Nombre:="FechaFin", TipoDato:=SqlType.Date)>
    Public Property FechaFin As Date?
    <SqlColumn(Nombre:="Vigente", TipoDato:=SqlType.VarChar, LargoColumna:=1)>
    Public Property Vigente As String
    <SqlColumn(Nombre:="NumCuotas", TipoDato:=SqlType.Int)>
    Public Property NumCuotas As Integer?
    <SqlColumn(Nombre:="CuotaInicial", TipoDato:=SqlType.Int)>
    Public Property CuotaInicial As Integer?
    <SqlColumn(Nombre:="CuotaFinal", TipoDato:=SqlType.Int)>
    Public Property CuotaFinal As Integer?
    <SqlColumn(Nombre:="CuotaActual", TipoDato:=SqlType.Int)>
    Public Property CuotaActual As Integer?
    <SqlColumn(Nombre:="AplicaLiquidaPeriodos", TipoDato:=SqlType.Bit)>
    Public Property AplicaLiquidaPeriodos As Boolean?
    <SqlColumn(Nombre:="AplicaLiquidaSemestres", TipoDato:=SqlType.Bit)>
    Public Property AplicaLiquidaSemestres As Boolean?
    <SqlColumn(Nombre:="AplicaLiquidaExtraordinarias", TipoDato:=SqlType.Bit)>
    Public Property AplicaLiquidaExtraordinarias As Boolean?
    <SqlColumn(Nombre:="AplicaLiquidaContratos", TipoDato:=SqlType.Bit)>
    Public Property AplicaLiquidaContratos As Boolean?
    <SqlColumn(Nombre:="CtaContable", TipoDato:=SqlType.VarChar, LargoColumna:=20)>
    Public Property CtaContable As String
    <SqlColumn(Nombre:="DocContable", TipoDato:=SqlType.VarChar, LargoColumna:=20)>
    Public Property DocContable As String
End Class