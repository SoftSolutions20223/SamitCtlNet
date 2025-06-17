Imports SamitDatabase

<SqlTable(Nombre:="ConceptosPersonales", BaseDatos:=DatabasesSamit.NominaFull, Version:=1)>
Public Class ConceptosPersonales
    <SqlColumn(Nombre:="Sec", LlavePrimaria:=True, TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property Sec As Integer
    <SqlColumn(Nombre:="NomConcepto", TipoDato:=SqlType.VarChar, LargoColumna:=200)>
    Public Property NomConcepto As String
    <SqlColumn(Nombre:="Vigente", TipoDato:=SqlType.VarChar, LargoColumna:=1)>
    Public Property Vigente As String
    <SqlColumn(Nombre:="Clasificacion", TipoDato:=SqlType.Int)>
    Public Property Clasificacion As Integer?
    <SqlColumn(Nombre:="PeriodosLiquida", TipoDato:=SqlType.VarChar, LargoColumna:=20)>
    Public Property PeriodosLiquida As String
    <SqlColumn(Nombre:="ValMaxDescuento", TipoDato:=SqlType.VarChar, LargoColumna:=2000)>
    Public Property ValMaxDescuento As String
    <SqlColumn(Nombre:="EsPredeterminado", TipoDato:=SqlType.Bit)>
    Public Property EsPredeterminado As Boolean?
    <SqlColumn(Nombre:="CodDian", TipoDato:=SqlType.VarChar, LargoColumna:=20)>
    Public Property CodDian As String
End Class