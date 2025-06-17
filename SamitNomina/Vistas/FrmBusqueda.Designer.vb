<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBusqueda
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBusqueda))
        Me.lblBusqueda = New DevExpress.XtraEditors.LabelControl()
        Me.gcBusqueda = New DevExpress.XtraGrid.GridControl()
        Me.gvBusqueda = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.gcBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblBusqueda
        '
        Me.lblBusqueda.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.lblBusqueda.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBusqueda.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.lblBusqueda.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblBusqueda.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.lblBusqueda.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblBusqueda.Location = New System.Drawing.Point(5, 5)
        Me.lblBusqueda.Name = "lblBusqueda"
        Me.lblBusqueda.Padding = New System.Windows.Forms.Padding(5)
        Me.lblBusqueda.Size = New System.Drawing.Size(634, 35)
        Me.lblBusqueda.TabIndex = 0
        Me.lblBusqueda.Text = "Digite cualquier parametro de busqueda"
        '
        'gcBusqueda
        '
        Me.gcBusqueda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcBusqueda.Location = New System.Drawing.Point(5, 40)
        Me.gcBusqueda.MainView = Me.gvBusqueda
        Me.gcBusqueda.Name = "gcBusqueda"
        Me.gcBusqueda.Size = New System.Drawing.Size(634, 545)
        Me.gcBusqueda.TabIndex = 1
        Me.gcBusqueda.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvBusqueda})
        '
        'gvBusqueda
        '
        Me.gvBusqueda.GridControl = Me.gcBusqueda
        Me.gvBusqueda.Name = "gvBusqueda"
        '
        'FrmBusqueda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 590)
        Me.Controls.Add(Me.gcBusqueda)
        Me.Controls.Add(Me.lblBusqueda)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(652, 617)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(652, 617)
        Me.Name = "FrmBusqueda"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda"
        CType(Me.gcBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblBusqueda As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gcBusqueda As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvBusqueda As DevExpress.XtraGrid.Views.Grid.GridView
End Class
