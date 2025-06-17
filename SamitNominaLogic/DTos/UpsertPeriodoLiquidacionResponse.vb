Public Class UpsertPeriodoLiquidacionResponse
    Public Property Estado As String
    Public Property Operacion As String
    Public Property Mensaje As String
    Public Property FechaHoraServidor As DateTime
    Public Property CodigoError As Integer?
    Public Property Nomina As Integer
    Public Property Año As Short
    Public Property TotalPeriodos As Integer
    Public Property TotalSemestres As Integer
    Public Property Periodos As List(Of PeriodosLiquidacion)
    Public Property Semestres As List(Of SemestresLiquidacion)
    Public Property DatosEnviados As Object

    Public ReadOnly Property EsExitoso As Boolean
        Get
            Return Estado = "SUCCESS"
        End Get
    End Property

    Public Sub New()
        Periodos = New List(Of PeriodosLiquidacion)()
        Semestres = New List(Of SemestresLiquidacion)()
    End Sub
End Class