Imports SamitDatabase

<SqlTable(Nombre:="VariablesPersonales", BaseDatos:=DatabasesSamit.NominaFull, Version:=1)>
Public Class VariablesPersonales
    <SqlColumn(Nombre:="Sec", LlavePrimaria:=True, TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property Sec As Integer
    <SqlColumn(Nombre:="NomVariable", TipoDato:=SqlType.VarChar, LargoColumna:=200)>
    Public Property NomVariable As String
    <SqlColumn(Nombre:="Vigente", TipoDato:=SqlType.VarChar, LargoColumna:=1)>
    Public Property Vigente As String
    <SqlColumn(Nombre:="ValorMaximo", TipoDato:=SqlType.Money)>
    Public Property ValorMaximo As Decimal?
    <SqlColumn(Nombre:="ValorDefecto", TipoDato:=SqlType.Money)>
    Public Property ValorDefecto As Decimal?
    <SqlColumn(Nombre:="EsPredeterminado", TipoDato:=SqlType.Bit)>
    Public Property EsPredeterminado As Boolean?
    <SqlColumn(Nombre:="CodDian", TipoDato:=SqlType.VarChar, LargoColumna:=20)>
    Public Property CodDian As String
End Class