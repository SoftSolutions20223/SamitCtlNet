Imports SamitDatabase

<SqlTable(Nombre:="VariablesGenerales", BaseDatos:=DatabasesSamit.NominaFull, Version:=1)>
Public Class VariablesGenerales
    <SqlColumn(Nombre:="Sec", LlavePrimaria:=True, TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property Sec As Integer
    <SqlColumn(Nombre:="NomVariable", TipoDato:=SqlType.VarChar, LargoColumna:=200)>
    Public Property NomVariable As String
    <SqlColumn(Nombre:="Vigente", TipoDato:=SqlType.VarChar, LargoColumna:=1)>
    Public Property Vigente As String
    <SqlColumn(Nombre:="Descripcion", TipoDato:=SqlType.VarChar, LargoColumna:=200)>
    Public Property Descripcion As String
    <SqlColumn(Nombre:="EsPredeterminado", TipoDato:=SqlType.Bit)>
    Public Property EsPredeterminado As Boolean?
    <SqlColumn(Nombre:="CodDian", TipoDato:=SqlType.VarChar, LargoColumna:=20)>
    Public Property CodDian As String
End Class
