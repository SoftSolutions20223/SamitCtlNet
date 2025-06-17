Imports SamitDatabase

<SqlTable(Nombre:="PlantadeCargos", BaseDatos:=DatabasesSamit.NominaFull, Version:=1)>
Public Class PlantadeCargos
    <SqlColumn(Nombre:="Sec", TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property Sec As Integer
    <SqlColumn(Nombre:="Oficina", LlavePrimaria:=True, TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property Oficina As Integer
    <SqlColumn(Nombre:="Cargo", LlavePrimaria:=True, TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property Cargo As Integer
    <SqlColumn(Nombre:="NumCargos", TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property NumCargos As Integer
End Class