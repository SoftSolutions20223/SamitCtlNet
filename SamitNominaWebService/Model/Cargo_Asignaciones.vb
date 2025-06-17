Imports SamitDatabase

<SqlTable(Nombre:="Cargo_Asignaciones", BaseDatos:=DatabasesSamit.NominaFull, Version:=1)>
Public Class Cargo_Asignaciones
    <SqlColumn(Nombre:="Sec", TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property Sec As Integer
    <SqlColumn(Nombre:="Fecha", LlavePrimaria:=True, TipoDato:=SqlType.Date, AceptaNull:=False)>
    Public Property Fecha As Date
    <SqlColumn(Nombre:="Cargo", LlavePrimaria:=True, TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property Cargo As Integer
    <SqlColumn(Nombre:="Asignacion", TipoDato:=SqlType.Money)>
    Public Property Asignacion As Decimal?
End Class