Imports SamitDatabase

<SqlTable(Nombre:="NominaLiquidaExtraordinaria", BaseDatos:=DatabasesSamit.NominaFull, Version:=1)>
Public Class NominaLiquidaExtraordinaria
    <SqlColumn(Nombre:="Sec", LlavePrimaria:=True, TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property Sec As Integer
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
    <SqlColumn(Nombre:="Estado", TipoDato:=SqlType.VarChar, LargoColumna:=10)>
    Public Property Estado As String
    <SqlColumn(Nombre:="ParametrosB", TipoDato:=SqlType.VarChar, LargoColumna:=100)>
    Public Property ParametrosB As String
    <SqlColumn(Nombre:="Conceptos", TipoDato:=SqlType.VarChar, LargoColumna:=2000)>
    Public Property Conceptos As String
    <SqlColumn(Nombre:="EsBorrador", TipoDato:=SqlType.Bit)>
    Public Property EsBorrador As Boolean?
    <SqlColumn(Nombre:="Nomina", TipoDato:=SqlType.Int)>
    Public Property Nomina As Integer?
    <SqlColumn(Nombre:="Contabilizada", TipoDato:=SqlType.Bit)>
    Public Property Contabilizada As Boolean?
    <SqlColumn(Nombre:="FormaDePago", TipoDato:=SqlType.VarChar, LargoColumna:=20)>
    Public Property FormaDePago As String
    <SqlColumn(Nombre:="DocContable", TipoDato:=SqlType.VarChar, LargoColumna:=50)>
    Public Property DocContable As String
End Class
