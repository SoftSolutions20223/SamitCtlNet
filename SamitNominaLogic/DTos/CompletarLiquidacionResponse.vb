Public Class CompletarLiquidacionResponse
    Public Property EsExitoso As Boolean
    Public Property Mensaje As String
    Public Property ContratosProcesados As Integer
    Public Property ConceptosGuardados As Integer
    Public Property CodigoError As Integer?

    Public Sub New()
        EsExitoso = False
        Mensaje = ""
        ContratosProcesados = 0
        ConceptosGuardados = 0
    End Sub
End Class