Imports SamitDatabase

<SqlTable(Nombre:="Plantillas", BaseDatos:=DatabasesSamit.NominaFull, Version:=1)>
Public Class Plantillas
    <SqlColumn(Nombre:="Sec", LlavePrimaria:=True, TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property Sec As Integer
    <SqlColumn(Nombre:="NomPlantilla", TipoDato:=SqlType.VarChar, LargoColumna:=50)>
    Public Property NomPlantilla As String
    <SqlColumn(Nombre:="Vigente", TipoDato:=SqlType.VarChar, LargoColumna:=1)>
    Public Property Vigente As String
    <SqlColumn(Nombre:="ValorMaxDescontar", TipoDato:=SqlType.VarChar, LargoColumna:=2000)>
    Public Property ValorMaxDescontar As String
End Class