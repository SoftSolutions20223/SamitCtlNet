Imports SamitDatabase

<SqlTable(Nombre:="G_Departamento", BaseDatos:=DatabasesSamit.NominaFull, Version:=1)>
Public Class G_Departamento
    <SqlColumn(Nombre:="Sec", LlavePrimaria:=True, TipoDato:=SqlType.Int, AceptaNull:=False, IdentityInicio:=1, IdentityAumento:=1)>
    Public Property Sec As Integer?
    <SqlColumn(Nombre:="Pais", TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property Pais As Integer
    <SqlColumn(Nombre:="NomDpto", TipoDato:=SqlType.VarChar, LargoColumna:=100, AceptaNull:=False)>
    Public Property NomDpto As String
End Class