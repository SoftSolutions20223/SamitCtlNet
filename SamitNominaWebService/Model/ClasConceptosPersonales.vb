Imports SamitDatabase

<SqlTable(Nombre:="ClasConceptosPersonales", BaseDatos:=DatabasesSamit.NominaFull, Version:=1)>
Public Class ClasConceptosPersonales
    <SqlColumn(Nombre:="Sec", LlavePrimaria:=True, TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property Sec As Integer
    <SqlColumn(Nombre:="Nom", TipoDato:=SqlType.VarChar, LargoColumna:=200)>
    Public Property Nom As String
    <SqlColumn(Nombre:="Vigente", TipoDato:=SqlType.VarChar, LargoColumna:=1)>
    Public Property Vigente As String
    <SqlColumn(Nombre:="NivelP", TipoDato:=SqlType.Int)>
    Public Property NivelP As Integer?
End Class
