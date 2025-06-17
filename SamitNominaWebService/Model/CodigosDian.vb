Imports SamitDatabase

<SqlTable(Nombre:="CodigosDian", BaseDatos:=DatabasesSamit.NominaFull, Version:=1)>
Public Class CodigosDian
    <SqlColumn(Nombre:="Sec", TipoDato:=SqlType.Int)>
    Public Property Sec As Integer?
    <SqlColumn(Nombre:="Codigo", LlavePrimaria:=True, TipoDato:=SqlType.VarChar, LargoColumna:=10, AceptaNull:=False)>
    Public Property Codigo As String
    <SqlColumn(Nombre:="Descripcion", TipoDato:=SqlType.VarChar, LargoColumna:=2000)>
    Public Property Descripcion As String
End Class
