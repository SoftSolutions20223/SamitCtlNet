
Imports SamitDatabase

<SqlTable(Nombre:="NominaLiquida", BaseDatos:=DatabasesSamit.NominaFull, Version:=1)>
Public Class NominaLiquida
    <SqlColumn(Nombre:="Sec", LlavePrimaria:=True, TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property Sec As Integer
    <SqlColumn(Nombre:="Periodo", TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property Periodo As Integer
    <SqlColumn(Nombre:="EsBorrador", TipoDato:=SqlType.Bit, AceptaNull:=False)>
    Public Property EsBorrador As Boolean
    <SqlColumn(Nombre:="OfiNomina", TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property OfiNomina As Integer
    <SqlColumn(Nombre:="OfiRegistra", TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property OfiRegistra As Integer
    <SqlColumn(Nombre:="UsuCrea", TipoDato:=SqlType.VarChar, LargoColumna:=20, AceptaNull:=False)>
    Public Property UsuCrea As String
    <SqlColumn(Nombre:="UsuMod", TipoDato:=SqlType.VarChar, LargoColumna:=20)>
    Public Property UsuMod As String
    <SqlColumn(Nombre:="FechaCrea", TipoDato:=SqlType.DateTime, AceptaNull:=False)>
    Public Property FechaCrea As Date
    <SqlColumn(Nombre:="FechaMod", TipoDato:=SqlType.DateTime)>
    Public Property FechaMod As Date?
    <SqlColumn(Nombre:="TerminalCrea", TipoDato:=SqlType.VarChar, LargoColumna:=50, AceptaNull:=False)>
    Public Property TerminalCrea As String
    <SqlColumn(Nombre:="TerminalMod", TipoDato:=SqlType.VarChar, LargoColumna:=50)>
    Public Property TerminalMod As String
    <SqlColumn(Nombre:="FechaSys", TipoDato:=SqlType.DateTime, AceptaNull:=False)>
    Public Property FechaSys As Date
End Class