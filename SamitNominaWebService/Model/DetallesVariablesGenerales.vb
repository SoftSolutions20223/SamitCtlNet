Imports SamitDatabase

<SqlTable(Nombre:="DetallesVariablesGenerales", BaseDatos:=DatabasesSamit.NominaFull, Version:=1)>
Public Class DetallesVariablesGenerales
    <SqlColumn(Nombre:="Sec", LlavePrimaria:=True, TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property Sec As Integer
    <SqlColumn(Nombre:="Variable", TipoDato:=SqlType.Int)>
    Public Property Variable As Integer?
    <SqlColumn(Nombre:="Valor", TipoDato:=SqlType.Money)>
    Public Property Valor As Decimal?
    <SqlColumn(Nombre:="Fecha", TipoDato:=SqlType.Date)>
    Public Property Fecha As Date?
End Class