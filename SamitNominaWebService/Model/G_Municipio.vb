Imports SamitDatabase

<SqlTable(Nombre:="G_Municipio", BaseDatos:=DatabasesSamit.NominaFull, Version:=1)>
Public Class G_Municipio
    <SqlColumn(Nombre:="Sec", TipoDato:=SqlType.Int)>
    Public Property Sec As Integer?
    <SqlColumn(Nombre:="Departamento", TipoDato:=SqlType.VarChar, LargoColumna:=3, AceptaNull:=False)>
    Public Property Departamento As String
    <SqlColumn(Nombre:="IdMunicipio", LlavePrimaria:=True, TipoDato:=SqlType.VarChar, LargoColumna:=6, AceptaNull:=False)>
    Public Property IdMunicipio As String
    <SqlColumn(Nombre:="NombreMunicipio", TipoDato:=SqlType.VarChar, LargoColumna:=50)>
    Public Property NombreMunicipio As String
End Class