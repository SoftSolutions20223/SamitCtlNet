Imports SamitDatabase

<SqlTable(Nombre:="Cargo_Funciones", BaseDatos:=DatabasesSamit.NominaFull, Version:=1)>
Public Class Cargo_Funciones
    <SqlColumn(Nombre:="Sec", TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property Sec As Integer
    <SqlColumn(Nombre:="Cargo", LlavePrimaria:=True, TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property Cargo As Integer
    <SqlColumn(Nombre:="CodFuncion", LlavePrimaria:=True, TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property CodFuncion As Integer
End Class