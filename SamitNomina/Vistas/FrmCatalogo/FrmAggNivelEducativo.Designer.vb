<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAggNivelEducativo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAggNivelEducativo))
        Me.gbxPrincipal = New DevExpress.XtraEditors.GroupControl()
        Me.txtBusqueda = New DevExpress.XtraEditors.TextEdit()
        Me.SeparatorControl1 = New DevExpress.XtraEditors.SeparatorControl()
        Me.lblVigente = New DevExpress.XtraEditors.LabelControl()
        Me.lblEsFormal = New DevExpress.XtraEditors.LabelControl()
        Me.grbEducacionFormal = New DevExpress.XtraEditors.RadioGroup()
        Me.grbVigente = New DevExpress.XtraEditors.RadioGroup()
        Me.txtNombreNivel = New SamitCtlNet.SamitTexto()
        Me.gcNivelEducativo = New DevExpress.XtraGrid.GridControl()
        Me.gvNivelEducativo = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btnLimpiar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEliminar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        CType(Me.gbxPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxPrincipal.SuspendLayout()
        CType(Me.txtBusqueda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grbEducacionFormal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grbVigente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcNivelEducativo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvNivelEducativo, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.gbxPrincipal.Controls.Add(Me.txtBusqueda)
        Me.gbxPrincipal.Controls.Add(Me.SeparatorControl1)
        Me.gbxPrincipal.Controls.Add(Me.lblVigente)
        Me.gbxPrincipal.Controls.Add(Me.lblEsFormal)
        Me.gbxPrincipal.Controls.Add(Me.grbEducacionFormal)
        Me.gbxPrincipal.Controls.Add(Me.grbVigente)
        Me.gbxPrincipal.Controls.Add(Me.txtNombreNivel)
        Me.gbxPrincipal.Controls.Add(Me.gcNivelEducativo)
        Me.gbxPrincipal.Location = New System.Drawing.Point(8, 8)
        Me.gbxPrincipal.Name = "gbxPrincipal"
        Me.gbxPrincipal.Size = New System.Drawing.Size(582, 553)
        Me.gbxPrincipal.TabIndex = 0
        Me.gbxPrincipal.TabStop = True
        Me.gbxPrincipal.Text = "Datos del Nivel Educativo"
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBusqueda.Location = New System.Drawing.Point(2, 90)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.txtBusqueda.Properties.Appearance.Options.UseFont = True
        Me.txtBusqueda.Size = New System.Drawing.Size(578, 24)
        Me.txtBusqueda.TabIndex = 91
        '
        'SeparatorControl1
        '
        Me.SeparatorControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SeparatorControl1.Location = New System.Drawing.Point(4, 82)
        Me.SeparatorControl1.Name = "SeparatorControl1"
        Me.SeparatorControl1.Padding = New System.Windows.Forms.Padding(0)
        Me.SeparatorControl1.Size = New System.Drawing.Size(571, 3)
        Me.SeparatorControl1.TabIndex = 72
        Me.SeparatorControl1.TabStop = False
        '
        'lblVigente
        '
        Me.lblVigente.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lblVigente.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblVigente.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblVigente.Location = New System.Drawing.Point(214, 52)
        Me.lblVigente.Name = "lblVigente"
        Me.lblVigente.Padding = New System.Windows.Forms.Padding(2)
        Me.lblVigente.Size = New System.Drawing.Size(87, 26)
        Me.lblVigente.TabIndex = 71
        Me.lblVigente.Text = "Vigente :"
        '
        'lblEsFormal
        '
        Me.lblEsFormal.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lblEsFormal.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblEsFormal.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblEsFormal.Location = New System.Drawing.Point(29, 52)
        Me.lblEsFormal.Name = "lblEsFormal"
        Me.lblEsFormal.Padding = New System.Windows.Forms.Padding(2)
        Me.lblEsFormal.Size = New System.Drawing.Size(82, 26)
        Me.lblEsFormal.TabIndex = 70
        Me.lblEsFormal.Text = "Formal :"
        '
        'grbEducacionFormal
        '
        Me.grbEducacionFormal.Location = New System.Drawing.Point(117, 56)
        Me.grbEducacionFormal.Name = "grbEducacionFormal"
        Me.grbEducacionFormal.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.grbEducacionFormal.Properties.Appearance.Options.UseBackColor = True
        Me.grbEducacionFormal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.grbEducacionFormal.Properties.Columns = 2
        Me.grbEducacionFormal.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.grbEducacionFormal.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "NO"), New DevExpress.XtraEditors.Controls.RadioGroupItem(True, "SI")})
        Me.grbEducacionFormal.Size = New System.Drawing.Size(91, 20)
        Me.grbEducacionFormal.TabIndex = 2
        '
        'grbVigente
        '
        Me.grbVigente.Location = New System.Drawing.Point(307, 56)
        Me.grbVigente.Name = "grbVigente"
        Me.grbVigente.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.grbVigente.Properties.Appearance.Options.UseBackColor = True
        Me.grbVigente.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.grbVigente.Properties.Columns = 2
        Me.grbVigente.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.grbVigente.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "NO"), New DevExpress.XtraEditors.Controls.RadioGroupItem(True, "SI")})
        Me.grbVigente.Size = New System.Drawing.Size(91, 20)
        Me.grbVigente.TabIndex = 3
        '
        'txtNombreNivel
        '
        Me.txtNombreNivel.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtNombreNivel.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtNombreNivel.AltodelControl = 30
        Me.txtNombreNivel.AnchoLabel = 110
        Me.txtNombreNivel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombreNivel.AutoSize = True
        Me.txtNombreNivel.BackColor = System.Drawing.Color.Transparent
        Me.txtNombreNivel.ColordeFondo = System.Drawing.Color.Transparent
        Me.txtNombreNivel.EsObligatorio = False
        Me.txtNombreNivel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreNivel.FormatoNumero = Nothing
        Me.txtNombreNivel.Location = New System.Drawing.Point(5, 25)
        Me.txtNombreNivel.MaximoAncho = 0
        Me.txtNombreNivel.MensajedeAyuda = Nothing
        Me.txtNombreNivel.Name = "txtNombreNivel"
        Me.txtNombreNivel.Size = New System.Drawing.Size(569, 30)
        Me.txtNombreNivel.SoloLectura = False
        Me.txtNombreNivel.SoloNumeros = False
        Me.txtNombreNivel.TabIndex = 1
        Me.txtNombreNivel.TextodelControl = ""
        Me.txtNombreNivel.TextoLabel = "Nombre Nivel :"
        Me.txtNombreNivel.TieneErrorControl = False
        Me.txtNombreNivel.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtNombreNivel.TipodeLetra = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtNombreNivel.ValordelControl = Nothing
        Me.txtNombreNivel.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombreNivel.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombreNivel.ValorPredeterminado = Nothing
        '
        'gcNivelEducativo
        '
        Me.gcNivelEducativo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcNivelEducativo.Location = New System.Drawing.Point(2, 120)
        Me.gcNivelEducativo.MainView = Me.gvNivelEducativo
        Me.gcNivelEducativo.Name = "gcNivelEducativo"
        Me.gcNivelEducativo.Size = New System.Drawing.Size(578, 431)
        Me.gcNivelEducativo.TabIndex = 0
        Me.gcNivelEducativo.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvNivelEducativo})
        '
        'gvNivelEducativo
        '
        Me.gvNivelEducativo.GridControl = Me.gcNivelEducativo
        Me.gvNivelEducativo.Name = "gvNivelEducativo"
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
        Me.GroupControl1.Location = New System.Drawing.Point(596, 8)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(88, 555)
        Me.GroupControl1.TabIndex = 4
        Me.GroupControl1.TabStop = True
        Me.GroupControl1.Text = "Opciones"
        '
        'FrmAggNivelEducativo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 573)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.gbxPrincipal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "FrmAggNivelEducativo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Niveles Educativos"
        CType(Me.gbxPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxPrincipal.ResumeLayout(False)
        Me.gbxPrincipal.PerformLayout()
        CType(Me.txtBusqueda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grbEducacionFormal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grbVigente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcNivelEducativo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvNivelEducativo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbxPrincipal As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gcNivelEducativo As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvNivelEducativo As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtNombreNivel As SamitCtlNet.SamitTexto
    Friend WithEvents grbEducacionFormal As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents grbVigente As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents lblVigente As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblEsFormal As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SeparatorControl1 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnLimpiar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtBusqueda As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
End Class
