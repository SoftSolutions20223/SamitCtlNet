Imports SamitDatabase

<SqlTable(Nombre:="ConceptosProvisionesPlantillas", BaseDatos:=DatabasesSamit.NominaFull, Version:=1)>
Public Class ConceptosProvisionesPlantillas
    <SqlColumn(Nombre:="Sec", LlavePrimaria:=True, TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property Sec As Integer?
    <SqlColumn(Nombre:="Plantilla", LlavePrimaria:=True, TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property Plantilla As Integer
    <SqlColumn(Nombre:="Concepto", LlavePrimaria:=True, TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property Concepto As Integer
End Class