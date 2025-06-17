Public Class RptTotalesXperiodo

    Private Sub lblTitleTotalPagar_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles lblTitleTotalPagar.BeforePrint
        If lblnombre1.Text <> "" Then lblTitleTotalPagar.Text = String.Format("Total por {0} :", lblnombre1.Text)
    End Sub
End Class