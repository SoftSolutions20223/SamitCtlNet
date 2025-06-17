Imports SamitDatabase

<SqlTable(Nombre:="CAT_Parentesco", BaseDatos:=DatabasesSamit.NominaFull, Version:=1)>
Public Class CAT_Parentesco
    <SqlColumn(Nombre:="Sec", LlavePrimaria:=True, TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property Sec As Integer
    <SqlColumn(Nombre:="NomParentesco", TipoDato:=SqlType.VarChar, LargoColumna:=50, AceptaNull:=False)>
    Public Property NomParentesco As String
    <SqlColumn(Nombre:="Estado", TipoDato:=SqlType.Int)>
    Public Property Estado As Integer?
End Class