Imports SamitDatabase

<SqlTable(Nombre:="CAT_TipoContratos", BaseDatos:=DatabasesSamit.NominaFull, Version:=1)>
Public Class CAT_TipoContratos
    <SqlColumn(Nombre:="Sec", LlavePrimaria:=True, TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property Sec As Integer
    <SqlColumn(Nombre:="NomTipo", TipoDato:=SqlType.VarChar, LargoColumna:=50, AceptaNull:=False)>
    Public Property NomTipo As String
End Class
