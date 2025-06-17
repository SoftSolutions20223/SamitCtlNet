Imports SamitDatabase

<SqlTable(Nombre:="CAT_NivelEducativo", BaseDatos:=DatabasesSamit.NominaFull, Version:=1)>
Public Class CAT_NivelEducativo
    <SqlColumn(Nombre:="Sec", LlavePrimaria:=True, TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property Sec As Integer
    <SqlColumn(Nombre:="NomNivel", TipoDato:=SqlType.VarChar, LargoColumna:=50, AceptaNull:=False)>
    Public Property NomNivel As String
    <SqlColumn(Nombre:="Vigente", TipoDato:=SqlType.Bit, AceptaNull:=False)>
    Public Property Vigente As Boolean
    <SqlColumn(Nombre:="EsFormal", TipoDato:=SqlType.Bit, AceptaNull:=False)>
    Public Property EsFormal As Boolean
End Class