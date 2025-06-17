<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAggValExentos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAggValExentos))
        Me.gbxPrincipal = New DevExpress.XtraEditors.GroupControl()
        Me.grbTipoValor = New DevExpress.XtraEditors.RadioGroup()
        Me.SeparatorControl2 = New DevExpress.XtraEditors.SeparatorControl()
        Me.lblVigente = New DevExpress.XtraEditors.LabelControl()
        Me.grbVigente = New DevExpress.XtraEditors.RadioGroup()
        Me.txtBusqueda = New DevExpress.XtraEditors.TextEdit()
        Me.txtNombre = New SamitCtlNet.SamitTexto()
        Me.gcValorExento = New DevExpress.XtraGrid.GridControl()
        Me.gvValorExento = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEliminar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnLimpiar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.gbxPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxPrincipal.SuspendLayout()
        CType(Me.grbTipoValor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeparatorControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grbVigente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBusqueda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcValorExento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvValorExento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.gbxPrincipal.Controls.Add(Me.grbTipoValor)
        Me.gbxPrincipal.Controls.Add(Me.SeparatorControl2)
        Me.gbxPrincipal.Controls.Add(Me.lblVigente)
        Me.gbxPrincipal.Controls.Add(Me.grbVigente)
        Me.gbxPrincipal.Controls.Add(Me.txtBusqueda)
        Me.gbxPrincipal.Controls.Add(Me.txtNombre)
        Me.gbxPrincipal.Controls.Add(Me.gcValorExento)
        Me.gbxPrincipal.Location = New System.Drawing.Point(7, 5)
        Me.gbxPrincipal.Name = "gbxPrincipal"
        Me.gbxPrincipal.Size = New System.Drawing.Size(733, 599)
        Me.gbxPrincipal.TabIndex = 3
        Me.gbxPrincipal.Text = "Datos del Valor Exento"
        '
        'grbTipoValor
        '
        Me.grbTipoValor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grbTipoValor.EditValue = False
        Me.grbTipoValor.Location = New System.Drawing.Point(539, 29)
        Me.grbTipoValor.Name = "grbTipoValor"
        Me.grbTipoValor.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.grbTipoValor.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.grbTipoValor.Properties.Appearance.Options.UseBackColor = True
        Me.grbTipoValor.Properties.Appearance.Options.UseFont = True
        Me.grbTipoValor.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.grbTipoValor.Properties.Columns = 2
        Me.grbTipoValor.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.grbTipoValor.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "Valor"), New DevExpress.XtraEditors.Controls.RadioGroupItem(True, "Porcentaje")})
        Me.grbTipoValor.Size = New System.Drawing.Size(190, 20)
        Me.grbTipoValor.TabIndex = 2
        '
        'SeparatorControl2
        '
        Me.SeparatorControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SeparatorControl2.Location = New System.Drawing.Point(3, 83)
        Me.SeparatorControl2.Name = "SeparatorControl2"
        Me.SeparatorControl2.Padding = New System.Windows.Forms.Padding(0)
        Me.SeparatorControl2.Size = New System.Drawing.Size(727, 3)
        Me.SeparatorControl2.TabIndex = 103
        Me.SeparatorControl2.TabStop = False
        '
        'lblVigente
        '
        Me.lblVigente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblVigente.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lblVigente.Appearance.Options.UseFont = True
        Me.lblVigente.Appearance.Options.UseTextOptions = True
        Me.lblVigente.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblVigente.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblVigente.Location = New System.Drawing.Point(539, 56)
        Me.lblVigente.Name = "lblVigente"
        Me.lblVigente.Padding = New System.Windows.Forms.Padding(2)
        Me.lblVigente.Size = New System.Drawing.Size(92, 26)
        Me.lblVigente.TabIndex = 96
        Me.lblVigente.Text = "Vigente :"
        '
        'grbVigente
        '
        Me.grbVigente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grbVigente.Location = New System.Drawing.Point(637, 60)
        Me.grbVigente.Name = "grbVigente"
        Me.grbVigente.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.grbVigente.Properties.Appearance.Options.UseBackColor = True
        Me.grbVigente.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.grbVigente.Properties.Columns = 2
        Me.grbVigente.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.grbVigente.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "NO"), New DevExpress.XtraEditors.Controls.RadioGroupItem(True, "SI")})
        Me.grbVigente.Size = New System.Drawing.Size(96, 20)
        Me.grbVigente.TabIndex = 3
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBusqueda.Location = New System.Drawing.Point(2, 89)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.txtBusqueda.Properties.Appearance.Options.UseFont = True
        Me.txtBusqueda.Size = New System.Drawing.Size(729, 24)
        Me.txtBusqueda.TabIndex = 9
        Me.txtBusqueda.TabStop = False
        '
        'txtNombre
        '
        Me.txtNombre.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtNombre.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtNombre.AltodelControl = 30
        Me.txtNombre.AnchoLabel = 100
        Me.txtNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombre.AutoSize = True
        Me.txtNombre.BackColor = System.Drawing.Color.Transparent
        Me.txtNombre.ColordeFondo = System.Drawing.Color.Transparent
        Me.txtNombre.EsObligatorio = False
        Me.txtNombre.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.FormatoNumero = Nothing
        Me.txtNombre.Location = New System.Drawing.Point(4, 26)
        Me.txtNombre.MaximoAncho = 0
        Me.txtNombre.MensajedeAyuda = ""
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(529, 30)
        Me.txtNombre.SoloLectura = False
        Me.txtNombre.SoloNumeros = False
        Me.txtNombre.TabIndex = 1
        Me.txtNombre.TextodelControl = ""
        Me.txtNombre.TextoLabel = "Nombre  :"
        Me.txtNombre.TieneErrorControl = False
        Me.txtNombre.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtNombre.TipodeLetra = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtNombre.ValordelControl = Nothing
        Me.txtNombre.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.ValorPredeterminado = Nothing
        '
        'gcValorExento
        '
        Me.gcValorExento.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcValorExento.Location = New System.Drawing.Point(0, 116)
        Me.gcValorExento.MainView = Me.gvValorExento
        Me.gcValorExento.Name = "gcValorExento"
        Me.gcValorExento.Size = New System.Drawing.Size(733, 483)
        Me.gcValorExento.TabIndex = 10
        Me.gcValorExento.TabStop = False
        Me.gcValorExento.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvValorExento})
        '
        'gvValorExento
        '
        Me.gvValorExento.GridControl = Me.gcValorExento
        Me.gvValorExento.Name = "gvValorExento"
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
        Me.GroupControl1.Controls.Add(Me.btnEliminar)
        Me.GroupControl1.Controls.Add(Me.btnLimpiar)
        Me.GroupControl1.Controls.Add(Me.btnGuardar)
        Me.GroupControl1.Location = New System.Drawing.Point(746, 5)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(88, 597)
        Me.GroupControl1.TabIndex = 4
        Me.GroupControl1.Text = "Opciones"
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(7, 132)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(74, 30)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "Salir"
        '
        'btnEliminar
        '
        Me.btnEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(7, 96)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(74, 30)
        Me.btnEliminar.TabIndex = 3
        Me.btnEliminar.Text = "Eliminar"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLimpiar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnLimpiar.Appearance.Options.UseFont = True
        Me.btnLimpiar.Location = New System.Drawing.Point(7, 60)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(74, 30)
        Me.btnLimpiar.TabIndex = 2
        Me.btnLimpiar.Text = "Limpiar"
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Location = New System.Drawing.Point(7, 24)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(74, 30)
        Me.btnGuardar.TabIndex = 1
        Me.btnGuardar.Text = "Guardar"
        '
        'FrmAggValExentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(840, 610)
        Me.Controls.Add(Me.gbxPrincipal)
        Me.Controls.Add(Me.GroupControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmAggValExentos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Valores Exentos"
        CType(Me.gbxPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxPrincipal.ResumeLayout(False)
        Me.gbxPrincipal.PerformLayout()
        CType(Me.grbTipoValor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeparatorControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grbVigente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBusqueda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcValorExento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvValorExento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbxPrincipal As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SeparatorControl2 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents lblVigente As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grbVigente As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents txtBusqueda As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNombre As SamitCtlNet.SamitTexto
    Friend WithEvents gcValorExento As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvValorExento As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnLimpiar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grbTipoValor As DevExpress.XtraEditors.RadioGroup
End Class
