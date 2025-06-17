<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCatLicenciaConduccion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCatLicenciaConduccion))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnLimpiar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEliminar = New DevExpress.XtraEditors.SimpleButton()
        Me.gbxPrincipal = New DevExpress.XtraEditors.GroupControl()
        Me.txtIdClase = New SamitCtlNet.SamitTexto()
        Me.SeparatorControl1 = New DevExpress.XtraEditors.SeparatorControl()
        Me.lblVigente = New DevExpress.XtraEditors.LabelControl()
        Me.rgVigente = New DevExpress.XtraEditors.RadioGroup()
        Me.txtNombre = New SamitCtlNet.SamitTexto()
        Me.gcCatLicencia = New DevExpress.XtraGrid.GridControl()
        Me.gvCatLicencia = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.gbxPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxPrincipal.SuspendLayout()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgVigente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcCatLicencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvCatLicencia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.GroupControl1.CaptionImagePadding = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.GroupControl1.Controls.Add(Me.btnSalir)
        Me.GroupControl1.Controls.Add(Me.btnGuardar)
        Me.GroupControl1.Controls.Add(Me.btnLimpiar)
        Me.GroupControl1.Controls.Add(Me.btnEliminar)
        Me.GroupControl1.Location = New System.Drawing.Point(596, 9)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(88, 555)
        Me.GroupControl1.TabIndex = 13
        Me.GroupControl1.TabStop = True
        Me.GroupControl1.Text = "Opciones"
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(7, 132)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(74, 30)
        Me.btnSalir.TabIndex = 7
        Me.btnSalir.Text = "Salir"
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Location = New System.Drawing.Point(7, 24)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(74, 30)
        Me.btnGuardar.TabIndex = 4
        Me.btnGuardar.Text = "Guardar"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnLimpiar.Appearance.Options.UseFont = True
        Me.btnLimpiar.Location = New System.Drawing.Point(7, 60)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(74, 30)
        Me.btnLimpiar.TabIndex = 5
        Me.btnLimpiar.Text = "Limpiar"
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(7, 96)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(74, 30)
        Me.btnEliminar.TabIndex = 6
        Me.btnEliminar.Text = "Eliminar"
        '
        'gbxPrincipal
        '
        Me.gbxPrincipal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxPrincipal.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.gbxPrincipal.AppearanceCaption.Options.UseFont = True
        Me.gbxPrincipal.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.gbxPrincipal.CaptionImagePadding = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.gbxPrincipal.Controls.Add(Me.txtIdClase)
        Me.gbxPrincipal.Controls.Add(Me.SeparatorControl1)
        Me.gbxPrincipal.Controls.Add(Me.lblVigente)
        Me.gbxPrincipal.Controls.Add(Me.rgVigente)
        Me.gbxPrincipal.Controls.Add(Me.txtNombre)
        Me.gbxPrincipal.Controls.Add(Me.gcCatLicencia)
        Me.gbxPrincipal.Location = New System.Drawing.Point(8, 9)
        Me.gbxPrincipal.Name = "gbxPrincipal"
        Me.gbxPrincipal.Size = New System.Drawing.Size(582, 553)
        Me.gbxPrincipal.TabIndex = 12
        Me.gbxPrincipal.TabStop = True
        Me.gbxPrincipal.Text = "Información"
        '
        'txtIdClase
        '
        Me.txtIdClase.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtIdClase.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtIdClase.AltodelControl = 30
        Me.txtIdClase.AnchoLabel = 110
        Me.txtIdClase.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtIdClase.AutoSize = True
        Me.txtIdClase.BackColor = System.Drawing.Color.Transparent
        Me.txtIdClase.ColordeFondo = System.Drawing.Color.Transparent
        Me.txtIdClase.EsObligatorio = False
        Me.txtIdClase.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdClase.FormatoNumero = Nothing
        Me.txtIdClase.Location = New System.Drawing.Point(5, 55)
        Me.txtIdClase.MaximoAncho = 0
        Me.txtIdClase.MensajedeAyuda = Nothing
        Me.txtIdClase.Name = "txtIdClase"
        Me.txtIdClase.Size = New System.Drawing.Size(393, 30)
        Me.txtIdClase.SoloLectura = False
        Me.txtIdClase.SoloNumeros = False
        Me.txtIdClase.TabIndex = 2
        Me.txtIdClase.TextodelControl = ""
        Me.txtIdClase.TextoLabel = "ID Clase :"
        Me.txtIdClase.TieneErrorControl = False
        Me.txtIdClase.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtIdClase.TipodeLetra = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtIdClase.ValordelControl = Nothing
        Me.txtIdClase.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtIdClase.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtIdClase.ValorPredeterminado = Nothing
        '
        'SeparatorControl1
        '
        Me.SeparatorControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SeparatorControl1.Location = New System.Drawing.Point(4, 87)
        Me.SeparatorControl1.Name = "SeparatorControl1"
        Me.SeparatorControl1.Padding = New System.Windows.Forms.Padding(0)
        Me.SeparatorControl1.Size = New System.Drawing.Size(571, 3)
        Me.SeparatorControl1.TabIndex = 72
        Me.SeparatorControl1.TabStop = False
        '
        'lblVigente
        '
        Me.lblVigente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblVigente.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lblVigente.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblVigente.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblVigente.Location = New System.Drawing.Point(404, 55)
        Me.lblVigente.Name = "lblVigente"
        Me.lblVigente.Padding = New System.Windows.Forms.Padding(2)
        Me.lblVigente.Size = New System.Drawing.Size(79, 26)
        Me.lblVigente.TabIndex = 71
        Me.lblVigente.Text = "Vigente :"
        '
        'rgVigente
        '
        Me.rgVigente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rgVigente.EditValue = True
        Me.rgVigente.Location = New System.Drawing.Point(489, 57)
        Me.rgVigente.Name = "rgVigente"
        Me.rgVigente.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.rgVigente.Properties.Appearance.Options.UseBackColor = True
        Me.rgVigente.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.rgVigente.Properties.Columns = 2
        Me.rgVigente.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.rgVigente.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "NO"), New DevExpress.XtraEditors.Controls.RadioGroupItem(True, "SI")})
        Me.rgVigente.Size = New System.Drawing.Size(82, 24)
        Me.rgVigente.TabIndex = 3
        '
        'txtNombre
        '
        Me.txtNombre.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtNombre.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtNombre.AltodelControl = 30
        Me.txtNombre.AnchoLabel = 110
        Me.txtNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombre.AutoSize = True
        Me.txtNombre.BackColor = System.Drawing.Color.Transparent
        Me.txtNombre.ColordeFondo = System.Drawing.Color.Transparent
        Me.txtNombre.EsObligatorio = False
        Me.txtNombre.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.FormatoNumero = Nothing
        Me.txtNombre.Location = New System.Drawing.Point(5, 25)
        Me.txtNombre.MaximoAncho = 0
        Me.txtNombre.MensajedeAyuda = Nothing
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(570, 30)
        Me.txtNombre.SoloLectura = False
        Me.txtNombre.SoloNumeros = False
        Me.txtNombre.TabIndex = 1
        Me.txtNombre.TextodelControl = ""
        Me.txtNombre.TextoLabel = "Nombre :"
        Me.txtNombre.TieneErrorControl = False
        Me.txtNombre.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtNombre.TipodeLetra = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtNombre.ValordelControl = Nothing
        Me.txtNombre.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.ValorPredeterminado = Nothing
        '
        'gcCatLicencia
        '
        Me.gcCatLicencia.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcCatLicencia.Location = New System.Drawing.Point(2, 96)
        Me.gcCatLicencia.MainView = Me.gvCatLicencia
        Me.gcCatLicencia.Name = "gcCatLicencia"
        Me.gcCatLicencia.Size = New System.Drawing.Size(578, 455)
        Me.gcCatLicencia.TabIndex = 0
        Me.gcCatLicencia.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvCatLicencia})
        '
        'gvCatLicencia
        '
        Me.gvCatLicencia.GridControl = Me.gcCatLicencia
        Me.gvCatLicencia.Name = "gvCatLicencia"
        '
        'FrmCatLicenciaConduccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 573)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.gbxPrincipal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmCatLicenciaConduccion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Categoría Licencia de Conducción"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.gbxPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxPrincipal.ResumeLayout(False)
        Me.gbxPrincipal.PerformLayout()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgVigente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcCatLicencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvCatLicencia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnLimpiar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gbxPrincipal As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SeparatorControl1 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents lblVigente As DevExpress.XtraEditors.LabelControl
    Friend WithEvents rgVigente As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents txtNombre As SamitCtlNet.SamitTexto
    Friend WithEvents gcCatLicencia As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvCatLicencia As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtIdClase As SamitCtlNet.SamitTexto
End Class
