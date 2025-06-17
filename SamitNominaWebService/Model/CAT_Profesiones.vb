Imports SamitDatabase

<SqlTable(Nombre:="CAT_Profesiones", BaseDatos:=DatabasesSamit.NominaFull, Version:=1)>
Public Class CAT_Profesiones
    <SqlColumn(Nombre:="Sec", LlavePrimaria:=True, TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property Sec As Integer
    <SqlColumn(Nombre:="NomProfesion", TipoDato:=SqlType.VarChar, LargoColumna:=-1, AceptaNull:=False)>
    Public Property NomProfesion As String
    <SqlColumn(Nombre:="Vigente", TipoDato:=SqlType.Bit, AceptaNull:=False)>
    Public Property Vigente As Boolean
    <SqlColumn(Nombre:="IdNivelEducativo", TipoDato:=SqlType.Int)>
    Public Property IdNivelEducativo As Integer?
End Class