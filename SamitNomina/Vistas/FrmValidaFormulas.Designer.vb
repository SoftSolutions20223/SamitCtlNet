<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmValidaFormulas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmValidaFormulas))
        Me.gcLiquidaNomina = New DevExpress.XtraGrid.GridControl()
        Me.gvLiquidaNomina = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.lblfechaini = New DevExpress.XtraEditors.LabelControl()
        CType(Me.gcLiquidaNomina, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvLiquidaNomina, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gcLiquidaNomina
        '
        Me.gcLiquidaNomina.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcLiquidaNomina.Location = New System.Drawing.Point(-1, 8)
        Me.gcLiquidaNomina.MainView = Me.gvLiquidaNomina
        Me.gcLiquidaNomina.Name = "gcLiquidaNomina"
        Me.gcLiquidaNomina.Size = New System.Drawing.Size(1269, 425)
        Me.gcLiquidaNomina.TabIndex = 1
        Me.gcLiquidaNomina.TabStop = False
        Me.gcLiquidaNomina.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvLiquidaNomina})
        '
        'gvLiquidaNomina
        '
        Me.gvLiquidaNomina.GridControl = Me.gcLiquidaNomina
        Me.gvLiquidaNomina.Name = "gvLiquidaNomina"
        Me.gvLiquidaNomina.OptionsView.ShowGroupPanel = False
        '
        'lblfechaini
        '
        Me.lblfechaini.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblfechaini.Appearance.Font = New System.Drawing.Font("Tahoma", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfechaini.Appearance.Options.UseFont = True
        Me.lblfechaini.Appearance.Options.UseTextOptions = True
        Me.lblfechaini.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.lblfechaini.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblfechaini.Location = New System.Drawing.Point(-1, 436)
        Me.lblfechaini.Name = "lblfechaini"
        Me.lblfechaini.Padding = New System.Windows.Forms.Padding(2)
        Me.lblfechaini.Size = New System.Drawing.Size(1269, 52)
        Me.lblfechaini.TabIndex = 130
        Me.lblfechaini.Text = "Resultado: 0"
        '
        'FrmValidaFormulas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1268, 491)
        Me.Controls.Add(Me.lblfechaini)
        Me.Controls.Add(Me.gcLiquidaNomina)
        Me.IconOptions.Image = CType(resources.GetObject("FrmValidaFormulas.IconOptions.Image"), System.Drawing.Image)
        Me.IconOptions.LargeImage = CType(resources.GetObject("FrmValidaFormulas.IconOptions.LargeImage"), System.Drawing.Image)
        Me.Name = "FrmValidaFormulas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Validar Formula"
        CType(Me.gcLiquidaNomina, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvLiquidaNomina, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gcLiquidaNomina As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvLiquidaNomina As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lblfechaini As DevExpress.XtraEditors.LabelControl
End Class
