Imports SamitDatabase

<SqlTable(Nombre:="TiposConceptosNomina", BaseDatos:=DatabasesSamit.NominaFull, Version:=1)>
Public Class TiposConceptosNomina
    <SqlColumn(Nombre:="Sec", LlavePrimaria:=True, TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property Sec As Integer
    <SqlColumn(Nombre:="NomTipo", TipoDato:=SqlType.VarChar, LargoColumna:=200)>
    Public Property NomTipo As String
    <SqlColumn(Nombre:="Vigente", TipoDato:=SqlType.VarChar, LargoColumna:=1)>
    Public Property Vigente As String
End Class