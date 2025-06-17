Imports SamitDatabase

<SqlTable(Nombre:="CT_CentroCostos", BaseDatos:=DatabasesSamit.NominaFull, Version:=1)>
Public Class CT_CentroCostos
    <SqlColumn(Nombre:="Sec", LlavePrimaria:=True, TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property Sec As Integer
    <SqlColumn(Nombre:="Nom_CentroCosto", TipoDato:=SqlType.VarChar, LargoColumna:=30, AceptaNull:=False)>
    Public Property Nom_CentroCosto As String
    <SqlColumn(Nombre:="Responsable", TipoDato:=SqlType.BigInt, AceptaNull:=False)>
    Public Property Responsable As Long
    <SqlColumn(Nombre:="Estado", TipoDato:=SqlType.VarChar, LargoColumna:=1, AceptaNull:=False)>
    Public Property Estado As String
    <SqlColumn(Nombre:="LimitaUso", TipoDato:=SqlType.Bit)>
    Public Property LimitaUso As Boolean?
    <SqlColumn(Nombre:="FechaIniLimite", TipoDato:=SqlType.DateTime)>
    Public Property FechaIniLimite As Date?
    <SqlColumn(Nombre:="FechaFinLimite", TipoDato:=SqlType.DateTime)>
    Public Property FechaFinLimite As Date?
End Class
