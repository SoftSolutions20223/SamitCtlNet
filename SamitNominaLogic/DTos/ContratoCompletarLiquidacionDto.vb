Public Class ContratoCompletarLiquidacionDto
    Public Property SecNominaLiquidaContrato As Integer
    Public Property CodContrato As Integer
    Public Property Total As Decimal
    Public Property TotalIngresos As Decimal
    Public Property TotalDeducciones As Decimal
    Public Property TotalProvisiones As Decimal
    Public Property TotalDescuentosNomina As Decimal
    Public Property TotalFondos As Decimal
    Public Property Comentario As String
    Public Property HorasMes As Integer
    Public Property CargoActual As Integer
    Public Property Asignacion As Decimal

    ' Listas de conceptos
    Public Property ConceptosID As List(Of ConceptoLiquidacionDto) ' Ingresos y Deducciones
    Public Property ConceptosP As List(Of ConceptoLiquidacionDto)  ' Provisiones
    Public Property ConceptosDPN As List(Of ConceptoLiquidacionDto) ' Descuentos por Nómina

    Public Sub New()
        ConceptosID = New List(Of ConceptoLiquidacionDto)()
        ConceptosP = New List(Of ConceptoLiquidacionDto)()
        ConceptosDPN = New List(Of ConceptoLiquidacionDto)()
    End Sub
End Class