Public Class RptNominasXperiodoDetalle
    Private Sub lblNetoPagar_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles lblNetoPagar.BeforePrint
        Try

            Dim ing As Decimal = Convert.ToInt32(lblTotlaIngresos.Summary.GetResult())
            Dim deduc As Decimal = Convert.ToInt32(lblTotalDeducciones.Summary.GetResult())
            Dim Desc As Decimal = Convert.ToInt32(LblTotalDecuentos.Summary.GetResult())
            lblNetoPagar.Text = (ing - deduc - Desc).ToString("c2")

        Catch ex As Exception

        End Try
    End Sub
End Class