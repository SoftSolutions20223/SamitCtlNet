Imports SamitDatabase

<SqlTable(Nombre:="ConceptosNomina", BaseDatos:=DatabasesSamit.NominaFull, Version:=1)>
Public Class ConceptosNomina
    <SqlColumn(Nombre:="Sec", LlavePrimaria:=True, TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property Sec As Integer
    <SqlColumn(Nombre:="NomConcepto", TipoDato:=SqlType.VarChar, LargoColumna:=200)>
    Public Property NomConcepto As String
    <SqlColumn(Nombre:="Vigente", TipoDato:=SqlType.VarChar, LargoColumna:=1)>
    Public Property Vigente As String
    <SqlColumn(Nombre:="Formula", TipoDato:=SqlType.VarChar, LargoColumna:=200)>
    Public Property Formula As String
    <SqlColumn(Nombre:="Tipo", TipoDato:=SqlType.Int)>
    Public Property Tipo As Integer?
    <SqlColumn(Nombre:="PeriodosLiquida", TipoDato:=SqlType.VarChar, LargoColumna:=20)>
    Public Property PeriodosLiquida As String
    <SqlColumn(Nombre:="Base", TipoDato:=SqlType.VarChar, LargoColumna:=200)>
    Public Property Base As String
    <SqlColumn(Nombre:="Redondea", TipoDato:=SqlType.Int)>
    Public Property Redondea As Integer?
    <SqlColumn(Nombre:="Fondo", TipoDato:=SqlType.Int)>
    Public Property Fondo As Integer?
    <SqlColumn(Nombre:="Clasificacion", TipoDato:=SqlType.Int)>
    Public Property Clasificacion As Integer?
    <SqlColumn(Nombre:="EsRetencion", TipoDato:=SqlType.Bit)>
    Public Property EsRetencion As Boolean?
    <SqlColumn(Nombre:="EsPredeterminado", TipoDato:=SqlType.Bit)>
    Public Property EsPredeterminado As Boolean?
    <SqlColumn(Nombre:="CodDian", TipoDato:=SqlType.VarChar, LargoColumna:=20)>
    Public Property CodDian As String
    <SqlColumn(Nombre:="Orden", TipoDato:=SqlType.Int)>
    Public Property Orden As Integer?
End Class