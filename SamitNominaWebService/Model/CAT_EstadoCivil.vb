Imports SamitDatabase

<SqlTable(Nombre:="CAT_EstadoCivil", BaseDatos:=DatabasesSamit.NominaFull, Version:=1)>
Public Class CAT_EstadoCivil
    <SqlColumn(Nombre:="Sec", LlavePrimaria:=True, TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property Sec As Integer
    <SqlColumn(Nombre:="NomEstado", TipoDato:=SqlType.VarChar, LargoColumna:=50, AceptaNull:=False)>
    Public Property NomEstado As String
    <SqlColumn(Nombre:="Vigente", TipoDato:=SqlType.Bit, AceptaNull:=False)>
    Public Property Vigente As Boolean
End Class