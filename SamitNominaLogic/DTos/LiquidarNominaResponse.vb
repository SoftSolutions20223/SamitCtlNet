Public Class LiquidarNominaResponse
    Public Property Estado As String
    Public Property Operacion As String
    Public Property Mensaje As String
    Public Property SecNominaLiquidada As Integer?
    Public Property ContratosLiquidados As Integer
    Public Property ConceptosLiquidados As Integer
    Public Property VariablesLiquidadas As Integer
    Public Property CodigoError As Integer?
    Public Property FechaHoraServidor As DateTime

    Public ReadOnly Property EsExitoso As Boolean
        Get
            Return Estado = "SUCCESS"
        End Get
    End Property
End Class