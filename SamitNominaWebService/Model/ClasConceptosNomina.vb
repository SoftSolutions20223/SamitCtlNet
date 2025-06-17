Imports SamitDatabase

<SqlTable(Nombre:="ClasConceptosNomina", BaseDatos:=DatabasesSamit.NominaFull, Version:=1)>
Public Class ClasConceptosNomina
    <SqlColumn(Nombre:="Sec", LlavePrimaria:=True, TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property Sec As Integer
    <SqlColumn(Nombre:="Nom", TipoDato:=SqlType.VarChar, LargoColumna:=200)>
    Public Property Nom As String
    <SqlColumn(Nombre:="Vigente", TipoDato:=SqlType.VarChar, LargoColumna:=1)>
    Public Property Vigente As String
End Class

