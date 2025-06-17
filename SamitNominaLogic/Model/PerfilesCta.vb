Imports System.ComponentModel.DataAnnotations

Public Class PerfilesCta
    Public Property Sec As Integer

    <MaxLength(50)>
    Public Property NomPerfilCta As String

    <MaxLength(1)>
    Public Property Vigente As String

    <MaxLength(10)>
    Public Property FormaPago As String

    Public Property MovsTercerosIngresos As Boolean?

    Public Property MovsTercerosProvisiones As Boolean?

    Public Property MovsTercerosDeducciones As Boolean?

    Public Property MovsEntidadesIngresos As Boolean?

    Public Property MovsEntidadesProvisiones As Boolean?

    Public Property MovsEntidadesDeducciones As Boolean?

    Public Property MovsEntSeguridadSIngresos As Boolean?

    Public Property MovsEntSeguridadSProvisiones As Boolean?

    Public Property MovsEntSeguridadSDeducciones As Boolean?

    Public Property MovsEntPrestSIngresos As Boolean?

    Public Property MovsEntPrestSProvisiones As Boolean?

    Public Property MovsEntPrestSDeducciones As Boolean?

    Public Property MovsEntAportesParaIngresos As Boolean?

    Public Property MovsEntAportesParaProvisiones As Boolean?

    Public Property MovsEntAportesParaDeducciones As Boolean?

    Public Property MovsEntNominaIngresos As Boolean?

    Public Property MovsEntNominaProvisiones As Boolean?

    Public Property MovsEntNominaDeducciones As Boolean?

End Class