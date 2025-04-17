Public Class FrmVisor 

    Private Sub FrmVisor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VisorSamit.AutoZoom = True
        VisorSamit.ExecCommand(DevExpress.XtraPrinting.PrintingSystemCommand.ZoomToWholePage)
    End Sub
End Class