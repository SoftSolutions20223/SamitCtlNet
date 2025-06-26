Public Class EliminarBorradorNominaResponse
    Public Property Estado As String
    Public Property Operacion As String
    Public Property Mensaje As String
    Public Property SecNominaLiquida As Integer?
    Public Property CodigoError As Integer?
    Public Property FechaHoraServidor As DateTime

    ''' <summary>
    ''' Indica si la operación fue exitosa
    ''' </summary>
    Public ReadOnly Property EsExitoso As Boolean
        Get
            Return Estado = "SUCCESS"
        End Get
    End Property
End Class