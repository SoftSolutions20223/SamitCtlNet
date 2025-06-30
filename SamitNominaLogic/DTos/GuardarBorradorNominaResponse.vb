Public Class GuardarBorradorNominaResponse
    Public Property Estado As String
    Public Property Operacion As String
    Public Property Mensaje As String
    Public Property SecNominaLiquida As Integer?
    Public Property ContratosGuardados As Integer
    Public Property ConceptosGuardados As Integer
    Public Property VariablesGuardadas As Integer
    Public Property CodigoError As Integer?
    Public Property FechaHoraServidor As DateTime

    Public ReadOnly Property EsExitoso As Boolean
        Get
            Return Estado = "SUCCESS"
        End Get
    End Property
End Class