Imports SamitDatabase

<SqlTable(Nombre:="Nominas", BaseDatos:=DatabasesSamit.NominaFull, Version:=1)>
Public Class Nominas
    <SqlColumn(Nombre:="Sec", LlavePrimaria:=True, TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property Sec As Integer
    <SqlColumn(Nombre:="NomNomina", TipoDato:=SqlType.VarChar, LargoColumna:=50)>
    Public Property NomNomina As String
    <SqlColumn(Nombre:="FormaLiquida", TipoDato:=SqlType.Int)>
    Public Property FormaLiquida As Integer?
    <SqlColumn(Nombre:="Fecha", TipoDato:=SqlType.Date)>
    Public Property Fecha As Date?
    <SqlColumn(Nombre:="Oficina", TipoDato:=SqlType.Int)>
    Public Property Oficina As Integer?
End Class
