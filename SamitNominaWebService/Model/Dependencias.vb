Imports SamitDatabase

<SqlTable(Nombre:="Dependencias", BaseDatos:=DatabasesSamit.NominaFull, Version:=1)>
Public Class Dependencias
    <SqlColumn(Nombre:="Sec", LlavePrimaria:=True, TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property Sec As Integer
    <SqlColumn(Nombre:="NomDependencia", TipoDato:=SqlType.VarChar, LargoColumna:=100)>
    Public Property NomDependencia As String
    <SqlColumn(Nombre:="Vigente", TipoDato:=SqlType.VarChar, LargoColumna:=1)>
    Public Property Vigente As String
End Class
