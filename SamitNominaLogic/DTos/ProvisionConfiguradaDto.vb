Public Class ProvisionConfiguradaDto
    Public Property Sec As Integer
    Public Property Concepto As Short?
    Public Property NomConcepto As String
    Public Property Formula As String
    Public Property SemestresLiquida As String
    Public Property CuentaContable As String

    ' Método para convertir a la clase del modelo
    Public Function ToConfigProvisiones(nominaSec As Integer) As ConfigProvisiones
        Return New ConfigProvisiones With {
            .Sec = Sec,
            .Concepto = Concepto,
            .Formula = Formula,
            .SemestresLiquida = SemestresLiquida,
            .CuentaContable = CuentaContable,
            .Nomina = nominaSec
        }
    End Function
End Class