﻿Imports SamitDatabase

<SqlTable(Nombre:="ContratosLiquidados_Conceptos", BaseDatos:=DatabasesSamit.NominaFull, Version:=1)>
Public Class ContratosLiquidados_Conceptos
    <SqlColumn(Nombre:="Sec", LlavePrimaria:=True, TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property Sec As Integer
    <SqlColumn(Nombre:="LiquidaContrato", TipoDato:=SqlType.Int)>
    Public Property LiquidaContrato As Integer?
    <SqlColumn(Nombre:="Valor", TipoDato:=SqlType.Money)>
    Public Property Valor As Decimal?
    <SqlColumn(Nombre:="Base", TipoDato:=SqlType.Money)>
    Public Property Base As Decimal?
    <SqlColumn(Nombre:="NomConcepto", TipoDato:=SqlType.VarChar, LargoColumna:=200)>
    Public Property NomConcepto As String
    <SqlColumn(Nombre:="SecConcepto", TipoDato:=SqlType.Int)>
    Public Property SecConcepto As Integer?
    <SqlColumn(Nombre:="NomBase", TipoDato:=SqlType.VarChar, LargoColumna:=200)>
    Public Property NomBase As String
    <SqlColumn(Nombre:="SecConceptoP", TipoDato:=SqlType.Int)>
    Public Property SecConceptoP As Integer?
    <SqlColumn(Nombre:="SecConceptoP2", TipoDato:=SqlType.Int)>
    Public Property SecConceptoP2 As Integer?
End Class