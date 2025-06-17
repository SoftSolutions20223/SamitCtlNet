Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class UpsertPeriodoLiquidacionRequest
    ' Datos principales
    Public Property Nomina As Integer


    Public Property Año As Short
    Public Property ReemplazarExistentes As Boolean

    ' Datos de control
    Public Property Usuario As String
    Public Property Terminal As String

    ' Listas de periodos y semestres
    Public Property Periodos As List(Of PeriodosLiquidacion)
    Public Property Semestres As List(Of SemestresLiquidacion)

    Public Sub New()
        Periodos = New List(Of PeriodosLiquidacion)()
        Semestres = New List(Of SemestresLiquidacion)()
        Terminal = Environment.MachineName
        ReemplazarExistentes = False
    End Sub

    ''' <summary>
    ''' Convierte a JObject para el procedimiento almacenado
    ''' </summary>
    Public Function ToJObject() As JObject
        Dim json As New JObject()

        ' Datos principales
        json("Nomina") = Nomina
        json("Año") = Año
        json("ReemplazarExistentes") = ReemplazarExistentes
        json("Usuario") = Usuario
        json("Terminal") = Terminal

        ' Array de periodos
        Dim jPeriodos As New JArray()
        For Each periodo In Periodos
            Dim jPeriodo As New JObject()
            jPeriodo("Descripcion") = periodo.Descripcion
            jPeriodo("FechaInicio") = periodo.FechaInicio?.ToString("dd/MM/yyyy")
            jPeriodo("FechaFin") = periodo.FechaFin?.ToString("dd/MM/yyyy")
            jPeriodo("Estado") = periodo.Estado
            jPeriodo("PeriodoMes") = periodo.PeriodoMes
            jPeriodo("NumPeriodoNom") = periodo.NumPeriodoNom
            jPeriodo("CodPeriodo") = periodo.CodPeriodo
            jPeriodo("NumMes") = periodo.NumMes
            jPeriodo("Semestre") = periodo.Semestre
            jPeriodos.Add(jPeriodo)
        Next
        json("Periodos") = jPeriodos

        ' Array de semestres
        Dim jSemestres As New JArray()
        For Each semestre In Semestres
            Dim jSem As New JObject()
            jSem("Semestre") = semestre.Semestre
            jSem("FechaInicio") = semestre.FechaInicio?.ToString("dd/MM/yyyy")
            jSem("FechaFin") = semestre.FechaFin?.ToString("dd/MM/yyyy")
            jSem("Estado") = semestre.Estado
            jSemestres.Add(jSem)
        Next
        json("Semestres") = jSemestres

        Return json
    End Function
End Class