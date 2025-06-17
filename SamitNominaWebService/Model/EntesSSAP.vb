Imports SamitDatabase

<SqlTable(Nombre:="EntesSSAP", BaseDatos:=DatabasesSamit.NominaFull, Version:=1)>
Public Class EntesSSAP
    <SqlColumn(Nombre:="Sec", LlavePrimaria:=True, TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property Sec As Integer
    <SqlColumn(Nombre:="TipoEnte", LlavePrimaria:=True, TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property TipoEnte As Integer
    <SqlColumn(Nombre:="Nit", TipoDato:=SqlType.BigInt)>
    Public Property Nit As Long?
    <SqlColumn(Nombre:="NombreEntidad", TipoDato:=SqlType.VarChar, LargoColumna:=100)>
    Public Property NombreEntidad As String
    <SqlColumn(Nombre:="Estado", TipoDato:=SqlType.VarChar, LargoColumna:=1, AceptaNull:=False)>
    Public Property Estado As String
    <SqlColumn(Nombre:="CuentaPasivo", TipoDato:=SqlType.VarChar, LargoColumna:=10, AceptaNull:=False)>
    Public Property CuentaPasivo As String
End Class