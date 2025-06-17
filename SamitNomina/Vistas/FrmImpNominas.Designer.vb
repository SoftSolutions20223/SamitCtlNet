<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmImpNominas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmImpNominas))
        Me.gbxOpciones = New DevExpress.XtraEditors.GroupControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.gcRes = New DevExpress.XtraGrid.GridControl()
        Me.gvRes = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.vgIngresosDeducciones = New DevExpress.XtraVerticalGrid.VGridControl()
        CType(Me.gbxOpciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxOpciones.SuspendLayout()
        CType(Me.gcRes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvRes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vgIngresosDeducciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbxOpciones
        '
        Me.gbxOpciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxOpciones.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.gbxOpciones.AppearanceCaption.Options.UseFont = True
        Me.gbxOpciones.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.gbxOpciones.CaptionImageOptions.Padding = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.gbxOpciones.Controls.Add(Me.SimpleButton1)
        Me.gbxOpciones.Controls.Add(Me.btnImprimir)
        Me.gbxOpciones.Controls.Add(Me.btnSalir)
        Me.gbxOpciones.Location = New System.Drawing.Point(1363, 8)
        Me.gbxOpciones.Name = "gbxOpciones"
        Me.gbxOpciones.Size = New System.Drawing.Size(88, 577)
        Me.gbxOpciones.TabIndex = 3
        Me.gbxOpciones.Text = "Opciones"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.SimpleButton1.Location = New System.Drawing.Point(7, 82)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(74, 52)
        Me.SimpleButton1.TabIndex = 5
        Me.SimpleButton1.Text = "Ver tabla"
        '
        'btnImprimir
        '
        Me.btnImprimir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.Appearance.Options.UseFont = True
        Me.btnImprimir.ImageOptions.Image = CType(resources.GetObject("btnImprimir.ImageOptions.Image"), System.Drawing.Image)
        Me.btnImprimir.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnImprimir.Location = New System.Drawing.Point(7, 24)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(74, 52)
        Me.btnImprimir.TabIndex = 4
        Me.btnImprimir.Text = "Imprimir" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Desprendible"
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(7, 140)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(74, 46)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "Salir"
        '
        'gcRes
        '
        Me.gcRes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gcRes.Location = New System.Drawing.Point(7, 8)
        Me.gcRes.MainView = Me.gvRes
        Me.gcRes.Name = "gcRes"
        Me.gcRes.Size = New System.Drawing.Size(693, 577)
        Me.gcRes.TabIndex = 12
        Me.gcRes.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvRes})
        '
        'gvRes
        '
        Me.gvRes.GridControl = Me.gcRes
        Me.gvRes.Name = "gvRes"
        '
        'vgIngresosDeducciones
        '
        Me.vgIngresosDeducciones.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip
        Me.vgIngresosDeducciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.vgIngresosDeducciones.Cursor = System.Windows.Forms.Cursors.Default
        Me.vgIngresosDeducciones.Location = New System.Drawing.Point(706, 8)
        Me.vgIngresosDeducciones.Name = "vgIngresosDeducciones"
        Me.vgIngresosDeducciones.OptionsBehavior.SmartExpand = False
        Me.vgIngresosDeducciones.Size = New System.Drawing.Size(651, 577)
        Me.vgIngresosDeducciones.TabIndex = 13
        '
        'FrmImpNominas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1459, 593)
        Me.Controls.Add(Me.vgIngresosDeducciones)
        Me.Controls.Add(Me.gcRes)
        Me.Controls.Add(Me.gbxOpciones)
        Me.IconOptions.Icon = CType(resources.GetObject("FrmImpNominas.IconOptions.Icon"), System.Drawing.Icon)
        Me.Name = "FrmImpNominas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Imprimir Nóminas"
        CType(Me.gbxOpciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxOpciones.ResumeLayout(False)
        CType(Me.gcRes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvRes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vgIngresosDeducciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbxOpciones As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gcRes As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvRes As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents vgIngresosDeducciones As DevExpress.XtraVerticalGrid.VGridControl
    Friend WithEvents btnImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
End Class
