Imports SamitDatabase

<SqlTable(Nombre:="CAT_Genero", BaseDatos:=DatabasesSamit.NominaFull, Version:=1)>
Public Class CAT_Genero
    <SqlColumn(Nombre:="idgenero", LlavePrimaria:=True, TipoDato:=SqlType.Int, LargoColumna:=3, AceptaNull:=False)>
    Public Property idgenero As String
    <SqlColumn(Nombre:="nomgenero", TipoDato:=SqlType.VarChar, LargoColumna:=50)>
    Public Property nomgenero As String
    <SqlColumn(Nombre:="vigente", TipoDato:=SqlType.Bit)>
    Public Property vigente As Boolean?
End Class