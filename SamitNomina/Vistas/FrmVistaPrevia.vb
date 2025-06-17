Public Class FrmVistaPrevia 
    Public Sub New(documento As Object)
        InitializeComponent()
        Me.Vista.DocumentSource = documento
        Vista.ExecCommand(DevExpress.XtraPrinting.PrintingSystemCommand.ZoomToWholePage)
    End Sub

    Private Sub Vista_Load(sender As Object, e As EventArgs) Handles Vista.Load

    End Sub
End Class