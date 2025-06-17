Imports SamitDatabase

<SqlTable(Nombre:="Contratos", BaseDatos:=DatabasesSamit.NominaFull, Version:=1)>
Public Class Contratos
    <SqlColumn(Nombre:="Sec", TipoDato:=SqlType.Int)>
    Public Property Sec As Integer?
    <SqlColumn(Nombre:="Oficina", TipoDato:=SqlType.Int)>
    Public Property Oficina As Integer?
    <SqlColumn(Nombre:="CodContrato", LlavePrimaria:=True, TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property CodContrato As Integer
    <SqlColumn(Nombre:="Empleado", TipoDato:=SqlType.Int)>
    Public Property Empleado As Integer?
    <SqlColumn(Nombre:="TipoContrato", TipoDato:=SqlType.Int)>
    Public Property TipoContrato As Integer?
    <SqlColumn(Nombre:="HorasMes", TipoDato:=SqlType.Int)>
    Public Property HorasMes As Integer?
    <SqlColumn(Nombre:="FechaInicio", TipoDato:=SqlType.DateTime)>
    Public Property FechaInicio As Date?
    <SqlColumn(Nombre:="FechaFin", TipoDato:=SqlType.DateTime)>
    Public Property FechaFin As Date?
    <SqlColumn(Nombre:="Dependencia", TipoDato:=SqlType.Int)>
    Public Property Dependencia As Integer?
    <SqlColumn(Nombre:="Aprendiz", TipoDato:=SqlType.Bit)>
    Public Property Aprendiz As Boolean?
    <SqlColumn(Nombre:="Terminado", TipoDato:=SqlType.Bit)>
    Public Property Terminado As Boolean?
    <SqlColumn(Nombre:="Plantilla", TipoDato:=SqlType.Int)>
    Public Property Plantilla As Integer?
    <SqlColumn(Nombre:="Nomina", TipoDato:=SqlType.Int)>
    Public Property Nomina As Integer?
    <SqlColumn(Nombre:="CargoActual", TipoDato:=SqlType.Int)>
    Public Property CargoActual As Integer?
    <SqlColumn(Nombre:="Asignacion", TipoDato:=SqlType.Money)>
    Public Property Asignacion As Decimal?
    <SqlColumn(Nombre:="IdContrato", TipoDato:=SqlType.VarChar, LargoColumna:=50)>
    Public Property IdContrato As String
    <SqlColumn(Nombre:="ValorExento", TipoDato:=SqlType.Money)>
    Public Property ValorExento As Decimal?
    <SqlColumn(Nombre:="AsignacionCargo", TipoDato:=SqlType.VarChar, LargoColumna:=1)>
    Public Property AsignacionCargo As String
    <SqlColumn(Nombre:="FechaLiquidacion", TipoDato:=SqlType.Date)>
    Public Property FechaLiquidacion As Date?
    <SqlColumn(Nombre:="UsaAsginaCargo", TipoDato:=SqlType.Bit)>
    Public Property UsaAsginaCargo As Boolean?
    <SqlColumn(Nombre:="TipoTrabajador", TipoDato:=SqlType.VarChar, LargoColumna:=10)>
    Public Property TipoTrabajador As String
    <SqlColumn(Nombre:="SubTipoTrabajador", TipoDato:=SqlType.VarChar, LargoColumna:=10)>
    Public Property SubTipoTrabajador As String
    <SqlColumn(Nombre:="SalarioIntegral", TipoDato:=SqlType.VarChar, LargoColumna:=10)>
    Public Property SalarioIntegral As String
    <SqlColumn(Nombre:="PerfilCuentas", TipoDato:=SqlType.Int)>
    Public Property PerfilCuentas As Integer?
End Class