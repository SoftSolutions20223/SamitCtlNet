Imports SamitDatabase

<SqlTable(Nombre:="ZenumTipoEntes", BaseDatos:=DatabasesSamit.NominaFull, Version:=1)>
Public Class ZenumTipoEntes
    <SqlColumn(Nombre:="Sec", TipoDato:=SqlType.Int)>
    Public Property Sec As Integer?
    <SqlColumn(Nombre:="CodTipoEnte", LlavePrimaria:=True, TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property CodTipoEnte As Integer
    <SqlColumn(Nombre:="NomTipoEnte", TipoDato:=SqlType.VarChar, LargoColumna:=50, AceptaNull:=False)>
    Public Property NomTipoEnte As String
End Class