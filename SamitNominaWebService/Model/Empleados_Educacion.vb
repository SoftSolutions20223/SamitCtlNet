Imports SamitDatabase

<SqlTable(Nombre:="Empleados_Educacion", BaseDatos:=DatabasesSamit.NominaFull, Version:=1)>
Public Class Empleados_Educacion
    <SqlColumn(Nombre:="Sec", LlavePrimaria:=True, TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property Sec As Integer
    <SqlColumn(Nombre:="Empleado", TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property Empleado As Integer
    <SqlColumn(Nombre:="NivelEstudio", TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property NivelEstudio As Integer
    <SqlColumn(Nombre:="FechaGrado", TipoDato:=SqlType.DateTime, AceptaNull:=False)>
    Public Property FechaGrado As Date
    <SqlColumn(Nombre:="Duracion", TipoDato:=SqlType.Int, AceptaNull:=False)>
    Public Property Duracion As Integer
    <SqlColumn(Nombre:="TipoTiempo", TipoDato:=SqlType.Int)>
    Public Property TipoTiempo As Integer?
    <SqlColumn(Nombre:="IdTituloObtenido", TipoDato:=SqlType.Int)>
    Public Property IdTituloObtenido As Integer?
    <SqlColumn(Nombre:="NombreInstitucion", TipoDato:=SqlType.VarChar, LargoColumna:=100)>
    Public Property NombreInstitucion As String
    <SqlColumn(Nombre:="MatriculaProfesional", TipoDato:=SqlType.VarChar, LargoColumna:=15)>
    Public Property MatriculaProfesional As String
    <SqlColumn(Nombre:="LugarTitulo", TipoDato:=SqlType.VarChar, LargoColumna:=6)>
    Public Property LugarTitulo As String
End Class