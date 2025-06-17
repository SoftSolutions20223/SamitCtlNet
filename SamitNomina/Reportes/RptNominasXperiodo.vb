Public Class RptNominasXperiodo
    Dim HDevExpre As New HelperDevExpress
    Private Sub lblNombres_AfterPrint(sender As Object, e As EventArgs) Handles lblNombres.AfterPrint
        Try
            Dim d As String = lblNombres.Text.Replace("concat", ";")
            Dim c() = d.Split(";"c)
            'lblNombres.Text = c(0) + vbNewLine + c(1)

        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "lblNombres_EvaluateBinding")
        End Try
    End Sub

    Private Sub lblNombres_EvaluateBinding(sender As Object, e As DevExpress.XtraReports.UI.BindingEventArgs) Handles lblNombres.EvaluateBinding
        Try
            'Dim d As String = e.Value.ToString.Replace("concat", ";")
            'Dim c() = d.Split(";"c)
            'e.Value = c(0) + vbNewLine + c(1)
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "lblNombres_EvaluateBinding")
        End Try
    End Sub
End Class