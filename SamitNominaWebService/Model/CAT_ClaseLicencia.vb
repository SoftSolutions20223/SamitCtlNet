Imports SamitDatabase

<SqlTable(Nombre:="CAT_ClaseLicencia", BaseDatos:=DatabasesSamit.NominaFull, Version:=1)>
Public Class CAT_ClaseLicencia
    <SqlColumn(Nombre:="Sec", TipoDato:=SqlType.Int)>
    Public Property Sec As Integer?
    <SqlColumn(Nombre:="idClase", LlavePrimaria:=True, TipoDato:=SqlType.VarChar, LargoColumna:=10, AceptaNull:=False)>
    Public Property idClase As String
    <SqlColumn(Nombre:="NomClase", TipoDato:=SqlType.VarChar, LargoColumna:=350)>
    Public Property NomClase As String
    <SqlColumn(Nombre:="Vigente", TipoDato:=SqlType.Bit)>
    Public Property Vigente As Boolean?
End Class
