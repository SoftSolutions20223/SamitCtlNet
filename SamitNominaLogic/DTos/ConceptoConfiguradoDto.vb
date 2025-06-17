Public Class ConceptoConfiguradoDto
    Public Property Sec As Integer
    Public Property Concepto As Short?
    Public Property NomConcepto As String
    Public Property Formula As String
    Public Property PeriodosLiquida As String
    Public Property CuentaContable As String
    Public Property ContraPartida As String

    ' Método para convertir a la clase del modelo
    Public Function ToConfigConceptos(nominaSec As Integer) As ConfigConceptos
        Return New ConfigConceptos With {
            .Sec = Sec,
            .Nomina = nominaSec,
            .Concepto = Concepto,
            .Formula = Formula,
            .PeriodosLiquida = PeriodosLiquida,
            .CuentaContable = CuentaContable,
            .ContraPartida = ContraPartida
        }
    End Function
End Class