Imports SamitDatabase

<SqlTable(Nombre:="Funciones", BaseDatos:=DatabasesSamit.NominaFull, Version:=1)>
Public Class Funciones
    <SqlColumn(Nombre:="Sec", LlavePrimaria:=True, TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property Sec As Integer
    <SqlColumn(Nombre:="DetalleFuncion", TipoDato:=SqlType.VarChar, LargoColumna:=1000)>
    Public Property DetalleFuncion As String
End Class
