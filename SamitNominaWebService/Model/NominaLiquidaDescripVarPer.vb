Imports SamitDatabase

<SqlTable(Nombre:="NominaLiquidaDescripVarPer", BaseDatos:=DatabasesSamit.NominaFull, Version:=1)>
Public Class NominaLiquidaDescripVarPer
    <SqlColumn(Nombre:="Sec", LlavePrimaria:=True, TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property Sec As Integer
    <SqlColumn(Nombre:="FechaHoraInicio", TipoDato:=SqlType.DateTime)>
    Public Property FechaHoraInicio As Date?
    <SqlColumn(Nombre:="FechaHoraFin", TipoDato:=SqlType.DateTime)>
    Public Property FechaHoraFin As Date?
    <SqlColumn(Nombre:="Cantidad", TipoDato:=SqlType.Int)>
    Public Property Cantidad As Integer?
    <SqlColumn(Nombre:="CodVarP", TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property CodVarP As Integer
    <SqlColumn(Nombre:="TipoDesc", TipoDato:=SqlType.VarChar, LargoColumna:=10)>
    Public Property TipoDesc As String
End Class