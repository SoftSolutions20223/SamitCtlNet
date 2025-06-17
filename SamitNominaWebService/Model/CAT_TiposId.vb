Imports SamitDatabase

<SqlTable(Nombre:="CAT_TiposId", BaseDatos:=DatabasesSamit.NominaFull, Version:=1)>
Public Class CAT_TiposId
    <SqlColumn(Nombre:="Sec", TipoDato:=SqlType.Int)>
    Public Property Sec As Integer?
    <SqlColumn(Nombre:="TipoIdentificacion", LlavePrimaria:=True, TipoDato:=SqlType.VarChar, LargoColumna:=4, AceptaNull:=False)>
    Public Property TipoIdentificacion As String
    <SqlColumn(Nombre:="NomTipo", TipoDato:=SqlType.VarChar, LargoColumna:=50, AceptaNull:=False)>
    Public Property NomTipo As String
    <SqlColumn(Nombre:="UsaEmpleados", TipoDato:=SqlType.Bit, AceptaNull:=False)>
    Public Property UsaEmpleados As Boolean
    <SqlColumn(Nombre:="UsaParientes", TipoDato:=SqlType.Bit, AceptaNull:=False)>
    Public Property UsaParientes As Boolean
    <SqlColumn(Nombre:="Codigo", TipoDato:=SqlType.VarChar, LargoColumna:=50, AceptaNull:=False)>
    Public Property Codigo As String
End Class
