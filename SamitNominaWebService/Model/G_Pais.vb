Imports SamitDatabase

<SqlTable(Nombre:="G_Pais", BaseDatos:=DatabasesSamit.NominaFull, Version:=1)>
Public Class G_Pais
    <SqlColumn(Nombre:="Sec", LlavePrimaria:=True, TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property Sec As Integer
    <SqlColumn(Nombre:="NomPais", TipoDato:=SqlType.VarChar, LargoColumna:=100, AceptaNull:=False)>
    Public Property NomPais As String
    <SqlColumn(Nombre:="CodIso", TipoDato:=SqlType.VarChar, LargoColumna:=3, AceptaNull:=False)>
    Public Property CodIso As String
End Class