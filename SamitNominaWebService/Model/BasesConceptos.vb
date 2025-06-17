Imports SamitDatabase

<SqlTable(Nombre:="BasesConceptos", BaseDatos:=DatabasesSamit.NominaFull, Version:=1)>
Public Class BasesConceptos
    <SqlColumn(Nombre:="Sec", LlavePrimaria:=True, TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property Sec As Integer
    <SqlColumn(Nombre:="NomBase", TipoDato:=SqlType.VarChar, LargoColumna:=200)>
    Public Property NomBase As String
    <SqlColumn(Nombre:="Vigente", TipoDato:=SqlType.VarChar, LargoColumna:=1)>
    Public Property Vigente As String
    <SqlColumn(Nombre:="Formula", TipoDato:=SqlType.VarChar, LargoColumna:=200)>
    Public Property Formula As String
End Class