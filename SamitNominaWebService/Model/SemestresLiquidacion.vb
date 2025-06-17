Imports SamitDatabase

<SqlTable(Nombre:="SemestresLiquidacion", BaseDatos:=DatabasesSamit.NominaFull, Version:=1)>
Public Class SemestresLiquidacion
    <SqlColumn(Nombre:="Sec", LlavePrimaria:=True, TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property Sec As Integer
    <SqlColumn(Nombre:="Semestre", TipoDato:=SqlType.Int)>
    Public Property Semestre As Integer?
    <SqlColumn(Nombre:="Año", TipoDato:=SqlType.Int)>
    Public Property Año As Integer?
    <SqlColumn(Nombre:="FechaInicio", TipoDato:=SqlType.Date)>
    Public Property FechaInicio As Date?
    <SqlColumn(Nombre:="FechaFin", TipoDato:=SqlType.Date)>
    Public Property FechaFin As Date?
    <SqlColumn(Nombre:="Estado", TipoDato:=SqlType.VarChar, LargoColumna:=1)>
    Public Property Estado As String
    <SqlColumn(Nombre:="Nomina", TipoDato:=SqlType.Int)>
    Public Property Nomina As Integer?
End Class