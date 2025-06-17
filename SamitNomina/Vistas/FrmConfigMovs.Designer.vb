<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmConfigMovs
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConfigMovs))
        Me.ckeEmpleado = New DevExpress.XtraEditors.CheckEdit()
        Me.lblTerMov = New DevExpress.XtraEditors.LabelControl()
        Me.ckeEntidad = New DevExpress.XtraEditors.CheckEdit()
        Me.ckeSegSocial = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.ckePrestSociales = New DevExpress.XtraEditors.CheckEdit()
        Me.ckeAporParafiscales = New DevExpress.XtraEditors.CheckEdit()
        Me.ckeNomina = New DevExpress.XtraEditors.CheckEdit()
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAceptar = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.ckeEmpleado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckeEntidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckeSegSocial.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckePrestSociales.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckeAporParafiscales.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckeNomina.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ckeEmpleado
        '
        Me.ckeEmpleado.Location = New System.Drawing.Point(215, 44)
        Me.ckeEmpleado.Name = "ckeEmpleado"
        Me.ckeEmpleado.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckeEmpleado.Properties.Appearance.Options.UseFont = True
        Me.ckeEmpleado.Properties.Caption = "Empleado"
        Me.ckeEmpleado.Size = New System.Drawing.Size(88, 20)
        Me.ckeEmpleado.TabIndex = 10
        '
        'lblTerMov
        '
        Me.lblTerMov.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lblTerMov.Appearance.Options.UseFont = True
        Me.lblTerMov.Appearance.Options.UseTextOptions = True
        Me.lblTerMov.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblTerMov.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblTerMov.Location = New System.Drawing.Point(223, 12)
        Me.lblTerMov.Name = "lblTerMov"
        Me.lblTerMov.Padding = New System.Windows.Forms.Padding(2)
        Me.lblTerMov.Size = New System.Drawing.Size(166, 26)
        Me.lblTerMov.TabIndex = 9
        Me.lblTerMov.Text = "Tercero del Movimiento :"
        '
        'ckeEntidad
        '
        Me.ckeEntidad.Location = New System.Drawing.Point(306, 45)
        Me.ckeEntidad.Name = "ckeEntidad"
        Me.ckeEntidad.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckeEntidad.Properties.Appearance.Options.UseFont = True
        Me.ckeEntidad.Properties.Caption = "Entidad Afiliada"
        Me.ckeEntidad.Size = New System.Drawing.Size(124, 20)
        Me.ckeEntidad.TabIndex = 11
        '
        'ckeSegSocial
        '
        Me.ckeSegSocial.Location = New System.Drawing.Point(64, 126)
        Me.ckeSegSocial.Name = "ckeSegSocial"
        Me.ckeSegSocial.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckeSegSocial.Properties.Appearance.Options.UseFont = True
        Me.ckeSegSocial.Properties.Caption = "Seguridad Social"
        Me.ckeSegSocial.Size = New System.Drawing.Size(130, 20)
        Me.ckeSegSocial.TabIndex = 13
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseTextOptions = True
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Location = New System.Drawing.Point(218, 93)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Padding = New System.Windows.Forms.Padding(2)
        Me.LabelControl1.Size = New System.Drawing.Size(166, 26)
        Me.LabelControl1.TabIndex = 12
        Me.LabelControl1.Text = "Clasificacion Concepto :"
        '
        'ckePrestSociales
        '
        Me.ckePrestSociales.Location = New System.Drawing.Point(195, 125)
        Me.ckePrestSociales.Name = "ckePrestSociales"
        Me.ckePrestSociales.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckePrestSociales.Properties.Appearance.Options.UseFont = True
        Me.ckePrestSociales.Properties.Caption = "Prestaciones Sociales"
        Me.ckePrestSociales.Size = New System.Drawing.Size(161, 20)
        Me.ckePrestSociales.TabIndex = 14
        '
        'ckeAporParafiscales
        '
        Me.ckeAporParafiscales.Location = New System.Drawing.Point(356, 125)
        Me.ckeAporParafiscales.Name = "ckeAporParafiscales"
        Me.ckeAporParafiscales.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckeAporParafiscales.Properties.Appearance.Options.UseFont = True
        Me.ckeAporParafiscales.Properties.Caption = "Aportes Parafiscales"
        Me.ckeAporParafiscales.Size = New System.Drawing.Size(141, 20)
        Me.ckeAporParafiscales.TabIndex = 15
        '
        'ckeNomina
        '
        Me.ckeNomina.Location = New System.Drawing.Point(503, 125)
        Me.ckeNomina.Name = "ckeNomina"
        Me.ckeNomina.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckeNomina.Properties.Appearance.Options.UseFont = True
        Me.ckeNomina.Properties.Caption = "Nomina"
        Me.ckeNomina.Size = New System.Drawing.Size(112, 20)
        Me.ckeNomina.TabIndex = 16
        '
        'btnCancelar
        '
        Me.btnCancelar.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnCancelar.Appearance.Options.UseFont = True
        Me.btnCancelar.Location = New System.Drawing.Point(210, 175)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(90, 30)
        Me.btnCancelar.TabIndex = 104
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnAceptar
        '
        Me.btnAceptar.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnAceptar.Appearance.Options.UseFont = True
        Me.btnAceptar.Location = New System.Drawing.Point(315, 175)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(90, 30)
        Me.btnAceptar.TabIndex = 103
        Me.btnAceptar.Text = "Aceptar"
        '
        'FrmConfigMovs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(635, 227)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.ckeNomina)
        Me.Controls.Add(Me.ckeAporParafiscales)
        Me.Controls.Add(Me.ckeSegSocial)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.ckePrestSociales)
        Me.Controls.Add(Me.ckeEmpleado)
        Me.Controls.Add(Me.lblTerMov)
        Me.Controls.Add(Me.ckeEntidad)
        Me.IconOptions.Icon = CType(resources.GetObject("FrmConfigMovs.IconOptions.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(637, 259)
        Me.MinimumSize = New System.Drawing.Size(637, 259)
        Me.Name = "FrmConfigMovs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configurar Terceros del Movimiento"
        CType(Me.ckeEmpleado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckeEntidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckeSegSocial.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckePrestSociales.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckeAporParafiscales.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckeNomina.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ckeEmpleado As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lblTerMov As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ckeEntidad As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ckeSegSocial As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ckePrestSociales As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ckeAporParafiscales As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ckeNomina As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAceptar As DevExpress.XtraEditors.SimpleButton
End Class
