Public Class ContratoLiquidaDTO
    Public Property SecContratoLiquida As Integer
    Public Property CodContrato As String
    Public Property NominaLiquida As Integer
    Public Property Total As Decimal
    Public Property HorasMes As Decimal
    Public Property CargoActual As Integer
    Public Property Asignacion As Decimal
    Public Property TotalIngresos As Decimal
    Public Property TotalDeducciones As Decimal
    Public Property TotalProvisiones As Decimal
    Public Property TotalDescuentosNomina As Decimal
    Public Property TotalPagadoAlMes As Decimal
    Public Property RentaExenta As Decimal

    ' Listas de conceptos y variables
    Public Property Conceptos As List(Of ConceptoLiquidaDTO)
    Public Property Variables As List(Of VariableLiquidaDTO)

    Public Sub New()
        Conceptos = New List(Of ConceptoLiquidaDTO)
        Variables = New List(Of VariableLiquidaDTO)
    End Sub
End Class