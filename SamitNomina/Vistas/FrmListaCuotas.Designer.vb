<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListaCuotas
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmListaCuotas))
        Me.gcListaC = New DevExpress.XtraGrid.GridControl()
        Me.gvListaC = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.gcListaC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvListaC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gcListaC
        '
        Me.gcListaC.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcListaC.Location = New System.Drawing.Point(2, 0)
        Me.gcListaC.MainView = Me.gvListaC
        Me.gcListaC.Name = "gcListaC"
        Me.gcListaC.Size = New System.Drawing.Size(754, 422)
        Me.gcListaC.TabIndex = 10
        Me.gcListaC.TabStop = False
        Me.gcListaC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvListaC})
        '
        'gvListaC
        '
        Me.gvListaC.GridControl = Me.gcListaC
        Me.gvListaC.Name = "gvListaC"
        Me.gvListaC.OptionsView.ShowGroupPanel = False
        '
        'FrmListaCuotas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(758, 424)
        Me.Controls.Add(Me.gcListaC)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmListaCuotas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista Cuotas"
        CType(Me.gcListaC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvListaC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gcListaC As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvListaC As DevExpress.XtraGrid.Views.Grid.GridView
End Class
