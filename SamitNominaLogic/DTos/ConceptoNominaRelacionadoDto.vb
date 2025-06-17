Public Class ConceptoNominaRelacionadoDto
    Public Property Sec As Integer
    Public Property Concepto As Integer
    Public Property NomConcepto As String
    Public Property Formula As String
    Public Property BaseCalculo As String
    Public Property SeLiquida As Boolean
    Public Property CuentaContable As String

    ' Método para convertir a la clase del modelo
    Public Function ToTipoContratoConceptoNomina(codTipoContrato As Integer) As TiposContratos_ConceptosNomina
        Return New TiposContratos_ConceptosNomina With {
            .Sec = Sec,
            .Concepto = Concepto,
            .TipoContrato = codTipoContrato,
            .Formula = Formula,
            .BaseCalculo = BaseCalculo,
            .SeLiquida = SeLiquida,
            .CuentaContable = CuentaContable
        }
    End Function
End Class
