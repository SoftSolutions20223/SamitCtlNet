Public Class ConceptoLiquidaDTO
    Public Property SecConcepto As Integer?
    Public Property SecConceptoP As Integer?  ' Para conceptos personales
    Public Property SecConceptoP2 As Integer? ' Para descuentos
    Public Property NomConcepto As String
    Public Property Valor As Decimal
    Public Property Base As Decimal
    Public Property NomBase As String
    Public Property EsDescuento As Boolean
    Public Property Cuota As Integer?
    Public Property ActualizaExistente As Boolean ' Para saber si es UPDATE o INSERT
End Class