Imports SamitDatabase

<SqlTable(Nombre:="Contrato_Cargos", BaseDatos:=DatabasesSamit.NominaFull, Version:=1)>
Public Class Contrato_Cargos
    <SqlColumn(Nombre:="Sec", LlavePrimaria:=True, TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property Sec As Integer
    <SqlColumn(Nombre:="Contrato", TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property Contrato As Integer
    <SqlColumn(Nombre:="Cargo", TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property Cargo As Integer
    <SqlColumn(Nombre:="FechaInicio", TipoDato:=SqlType.SmallDateTime, AceptaNull:=False)>
    Public Property FechaInicio As Date
    <SqlColumn(Nombre:="FechaFin", TipoDato:=SqlType.SmallDateTime)>
    Public Property FechaFin As Date?
    <SqlColumn(Nombre:="UsrRegistra", TipoDato:=SqlType.VarChar, LargoColumna:=20)>
    Public Property UsrRegistra As String
    <SqlColumn(Nombre:="FechaRegistro", TipoDato:=SqlType.SmallDateTime)>
    Public Property FechaRegistro As Date?
    <SqlColumn(Nombre:="TerminalRegistra", TipoDato:=SqlType.VarChar, LargoColumna:=50)>
    Public Property TerminalRegistra As String
End Class