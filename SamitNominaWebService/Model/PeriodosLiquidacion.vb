Imports SamitDatabase

<SqlTable(Nombre:="PeriodosLiquidacion", BaseDatos:=DatabasesSamit.NominaFull, Version:=1)>
Public Class PeriodosLiquidacion
    <SqlColumn(Nombre:="Sec", LlavePrimaria:=True, TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property Sec As Integer
    <SqlColumn(Nombre:="Descripcion", TipoDato:=SqlType.VarChar, LargoColumna:=50)>
    Public Property Descripcion As String
    <SqlColumn(Nombre:="FechaInicio", TipoDato:=SqlType.Date)>
    Public Property FechaInicio As Date?
    <SqlColumn(Nombre:="FechaFin", TipoDato:=SqlType.Date)>
    Public Property FechaFin As Date?
    <SqlColumn(Nombre:="Estado", TipoDato:=SqlType.VarChar, LargoColumna:=1)>
    Public Property Estado As String
    <SqlColumn(Nombre:="Nomina", TipoDato:=SqlType.Int)>
    Public Property Nomina As Integer?
    <SqlColumn(Nombre:="Año", TipoDato:=SqlType.Int)>
    Public Property Año As Integer?
    <SqlColumn(Nombre:="PeriodoMes", TipoDato:=SqlType.Int)>
    Public Property PeriodoMes As Integer?
    <SqlColumn(Nombre:="NumPeriodoNom", TipoDato:=SqlType.Int)>
    Public Property NumPeriodoNom As Integer?
    <SqlColumn(Nombre:="CodPeriodo", TipoDato:=SqlType.Int)>
    Public Property CodPeriodo As Integer?
    <SqlColumn(Nombre:="NumMes", TipoDato:=SqlType.Int)>
    Public Property NumMes As Integer?
    <SqlColumn(Nombre:="Semestre", TipoDato:=SqlType.Int)>
    Public Property Semestre As Integer?
End Class