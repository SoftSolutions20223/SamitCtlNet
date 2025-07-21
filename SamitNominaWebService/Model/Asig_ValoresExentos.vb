Imports SamitDatabase

<SqlTable(Nombre:="Asig_ValoresExentos", BaseDatos:=DatabasesSamit.NominaFull, Version:=1)>
Public Class Asig_ValoresExentos
    <SqlColumn(Nombre:="Sec", LlavePrimaria:=True, TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property Sec As Integer
    <SqlColumn(Nombre:="Contrato", TipoDato:=SqlType.Int)>
    Public Property Contrato As Integer?
    <SqlColumn(Nombre:="Valor", TipoDato:=SqlType.Money)>
    Public Property Valor As Decimal?
    <SqlColumn(Nombre:="ValorExento", TipoDato:=SqlType.Int)>
    Public Property ValorExento As Integer?
    <SqlColumn(Nombre:="Certificado", TipoDato:=SqlType.NVarChar)>
    Public Property Certificado As String
    <SqlColumn(Nombre:="Vigente", TipoDato:=SqlType.Bit)>
    Public Property Vigente As Boolean?
End Class