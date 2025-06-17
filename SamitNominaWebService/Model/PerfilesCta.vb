Imports SamitDatabase

<SqlTable(Nombre:="PerfilesCta", BaseDatos:=DatabasesSamit.NominaFull, Version:=1)>
Public Class PerfilesCta
    <SqlColumn(Nombre:="Sec", LlavePrimaria:=True, TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property Sec As Integer
    <SqlColumn(Nombre:="NomPerfilCta", TipoDato:=SqlType.VarChar, LargoColumna:=50)>
    Public Property NomPerfilCta As String
    <SqlColumn(Nombre:="Vigente", TipoDato:=SqlType.VarChar, LargoColumna:=1)>
    Public Property Vigente As String
    <SqlColumn(Nombre:="FormaPago", TipoDato:=SqlType.VarChar, LargoColumna:=10)>
    Public Property FormaPago As String
    <SqlColumn(Nombre:="MovsTercerosIngresos", TipoDato:=SqlType.Bit)>
    Public Property MovsTercerosIngresos As Boolean?
    <SqlColumn(Nombre:="MovsTercerosProvisiones", TipoDato:=SqlType.Bit)>
    Public Property MovsTercerosProvisiones As Boolean?
    <SqlColumn(Nombre:="MovsTercerosDeducciones", TipoDato:=SqlType.Bit)>
    Public Property MovsTercerosDeducciones As Boolean?
    <SqlColumn(Nombre:="MovsEntidadesIngresos", TipoDato:=SqlType.Bit)>
    Public Property MovsEntidadesIngresos As Boolean?
    <SqlColumn(Nombre:="MovsEntidadesProvisiones", TipoDato:=SqlType.Bit)>
    Public Property MovsEntidadesProvisiones As Boolean?
    <SqlColumn(Nombre:="MovsEntidadesDeducciones", TipoDato:=SqlType.Bit)>
    Public Property MovsEntidadesDeducciones As Boolean?
    <SqlColumn(Nombre:="MovsEntSeguridadSIngresos", TipoDato:=SqlType.Bit)>
    Public Property MovsEntSeguridadSIngresos As Boolean?
    <SqlColumn(Nombre:="MovsEntSeguridadSProvisiones", TipoDato:=SqlType.Bit)>
    Public Property MovsEntSeguridadSProvisiones As Boolean?
    <SqlColumn(Nombre:="MovsEntSeguridadSDeducciones", TipoDato:=SqlType.Bit)>
    Public Property MovsEntSeguridadSDeducciones As Boolean?
    <SqlColumn(Nombre:="MovsEntPrestSIngresos", TipoDato:=SqlType.Bit)>
    Public Property MovsEntPrestSIngresos As Boolean?
    <SqlColumn(Nombre:="MovsEntPrestSProvisiones", TipoDato:=SqlType.Bit)>
    Public Property MovsEntPrestSProvisiones As Boolean?
    <SqlColumn(Nombre:="MovsEntPrestSDeducciones", TipoDato:=SqlType.Bit)>
    Public Property MovsEntPrestSDeducciones As Boolean?
    <SqlColumn(Nombre:="MovsEntAportesParaIngresos", TipoDato:=SqlType.Bit)>
    Public Property MovsEntAportesParaIngresos As Boolean?
    <SqlColumn(Nombre:="MovsEntAportesParaProvisiones", TipoDato:=SqlType.Bit)>
    Public Property MovsEntAportesParaProvisiones As Boolean?
    <SqlColumn(Nombre:="MovsEntAportesParaDeducciones", TipoDato:=SqlType.Bit)>
    Public Property MovsEntAportesParaDeducciones As Boolean?
    <SqlColumn(Nombre:="MovsEntNominaIngresos", TipoDato:=SqlType.Bit)>
    Public Property MovsEntNominaIngresos As Boolean?
    <SqlColumn(Nombre:="MovsEntNominaProvisiones", TipoDato:=SqlType.Bit)>
    Public Property MovsEntNominaProvisiones As Boolean?
    <SqlColumn(Nombre:="MovsEntNominaDeducciones", TipoDato:=SqlType.Bit)>
    Public Property MovsEntNominaDeducciones As Boolean?
End Class