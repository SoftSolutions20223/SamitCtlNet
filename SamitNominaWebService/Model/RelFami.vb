Imports SamitDatabase

<SqlTable(Nombre:="RelFami", BaseDatos:=DatabasesSamit.NominaFull, Version:=1)>
Public Class RelFami
    <SqlColumn(Nombre:="Sec", LlavePrimaria:=True, TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property Sec As Integer?
    <SqlColumn(Nombre:="empleado", LlavePrimaria:=True, TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property empleado As Integer
    <SqlColumn(Nombre:="familiar", LlavePrimaria:=True, TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property familiar As Integer
    <SqlColumn(Nombre:="parentesco", TipoDato:=SqlType.TinyInt)>
    Public Property parentesco As Byte?
End Class