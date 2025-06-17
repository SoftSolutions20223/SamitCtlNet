Imports SamitDatabase

<SqlTable(Nombre:="ValoresExentos", BaseDatos:=DatabasesSamit.NominaFull, Version:=1)>
Public Class ValoresExentos
    <SqlColumn(Nombre:="Sec", LlavePrimaria:=True, TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property Sec As Integer
    <SqlColumn(Nombre:="Nom", TipoDato:=SqlType.VarChar, LargoColumna:=200)>
    Public Property Nom As String
    <SqlColumn(Nombre:="Vigente", TipoDato:=SqlType.Bit)>
    Public Property Vigente As Boolean?
    <SqlColumn(Nombre:="TipoValor", TipoDato:=SqlType.Char, LargoColumna:=1)>
    Public Property TipoValor As String
End Class
