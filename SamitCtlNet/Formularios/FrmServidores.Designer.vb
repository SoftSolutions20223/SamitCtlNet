<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmServidores
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
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmServidores))
        Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Me.TxtServidor = New DevExpress.XtraEditors.ButtonEdit()
        Me.LstServidores = New DevExpress.XtraEditors.ListBoxControl()
        Me.Cancelar = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.TxtServidor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LstServidores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtServidor
        '
        Me.TxtServidor.Dock = System.Windows.Forms.DockStyle.Top
        Me.TxtServidor.Location = New System.Drawing.Point(0, 0)
        Me.TxtServidor.Name = "TxtServidor"
        Me.TxtServidor.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtServidor.Properties.Appearance.Options.UseFont = True
        Me.TxtServidor.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.TxtServidor.Size = New System.Drawing.Size(593, 26)
        ToolTipTitleItem1.Appearance.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        ToolTipTitleItem1.Appearance.Options.UseImage = True
        ToolTipTitleItem1.Image = CType(resources.GetObject("ToolTipTitleItem1.Image"), System.Drawing.Image)
        ToolTipTitleItem1.Text = "SAMIT SQL"
        ToolTipItem1.LeftIndent = 6
        ToolTipItem1.Text = "Digite el Nombre del Servidor para agregar o Seleccione de la Lista para Cambiar " & _
    "el Servidor"
        SuperToolTip1.Items.Add(ToolTipTitleItem1)
        SuperToolTip1.Items.Add(ToolTipItem1)
        Me.TxtServidor.SuperTip = SuperToolTip1
        Me.TxtServidor.TabIndex = 0
        '
        'LstServidores
        '
        Me.LstServidores.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LstServidores.Appearance.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstServidores.Appearance.ForeColor = System.Drawing.Color.Maroon
        Me.LstServidores.Appearance.Options.UseBackColor = True
        Me.LstServidores.Appearance.Options.UseFont = True
        Me.LstServidores.Appearance.Options.UseForeColor = True
        Me.LstServidores.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LstServidores.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned
        Me.LstServidores.Location = New System.Drawing.Point(0, 32)
        Me.LstServidores.MultiColumn = True
        Me.LstServidores.Name = "LstServidores"
        Me.LstServidores.Size = New System.Drawing.Size(593, 247)
        Me.LstServidores.TabIndex = 1
        '
        'Cancelar
        '
        Me.Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancelar.Location = New System.Drawing.Point(0, 179)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.Size = New System.Drawing.Size(57, 31)
        Me.Cancelar.TabIndex = 2
        Me.Cancelar.Text = "Cancelar"
        '
        'FrmServidores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancelar
        Me.ClientSize = New System.Drawing.Size(593, 279)
        Me.Controls.Add(Me.LstServidores)
        Me.Controls.Add(Me.TxtServidor)
        Me.Controls.Add(Me.Cancelar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmServidores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmServidores"
        CType(Me.TxtServidor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LstServidores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TxtServidor As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LstServidores As DevExpress.XtraEditors.ListBoxControl
    Friend WithEvents Cancelar As DevExpress.XtraEditors.SimpleButton
End Class
