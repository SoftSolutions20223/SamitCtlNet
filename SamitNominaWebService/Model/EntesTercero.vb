Imports SamitDatabase

<SqlTable(Nombre:="EntesTercero", BaseDatos:=DatabasesSamit.NominaFull, Version:=1)>
Public Class EntesTercero
    <SqlColumn(Nombre:="Sec", LlavePrimaria:=True, TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property Sec As Integer
    <SqlColumn(Nombre:="Empleado", TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property Empleado As Integer
    <SqlColumn(Nombre:="FechaRegistro", TipoDato:=SqlType.DateTime, AceptaNull:=False)>
    Public Property FechaRegistro As Date
    <SqlColumn(Nombre:="FechaRetiro", TipoDato:=SqlType.DateTime)>
    Public Property FechaRetiro As Date?
    <SqlColumn(Nombre:="Retirado", TipoDato:=SqlType.Bit, AceptaNull:=False)>
    Public Property Retirado As Boolean
    <SqlColumn(Nombre:="CausadeRetiro", TipoDato:=SqlType.VarChar, LargoColumna:=250)>
    Public Property CausadeRetiro As String
    <SqlColumn(Nombre:="SecEntesSSAP", TipoDato:=SqlType.Int)>
    Public Property SecEntesSSAP As Integer?
End Class