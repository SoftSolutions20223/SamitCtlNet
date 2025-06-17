Imports SamitDatabase

<SqlTable(Nombre:="CAT_Bancos", BaseDatos:=DatabasesSamit.NominaFull, Version:=1)>
Public Class CAT_Bancos

    <SqlColumn(Nombre:="Sec", TipoDato:=SqlType.Int, LlavePrimaria:=True, AceptaNull:=False)>
    Public Property Sec As String

    <SqlColumn(Nombre:="Nombre", TipoDato:=SqlType.VarChar, LargoColumna:=250)>
    Public Property Nombre As String

    <SqlColumn(Nombre:="Vigente", TipoDato:=SqlType.Bit, AceptaNull:=False)>
    Public Property Vigente As Boolean

End Class

