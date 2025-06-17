<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPerfilesCta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPerfilesCta))
        Me.gbxPrincipal = New DevExpress.XtraEditors.GroupControl()
        Me.lblVigente = New DevExpress.XtraEditors.LabelControl()
        Me.grbVigente = New DevExpress.XtraEditors.RadioGroup()
        Me.FormadePago = New SamitCtlNet.SamitBusq()
        Me.gcPerfilesCta = New DevExpress.XtraGrid.GridControl()
        Me.gvPerfilesCta = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btnCargarPerfil = New DevExpress.XtraEditors.SimpleButton()
        Me.lblUsaPlantillaBase = New DevExpress.XtraEditors.LabelControl()
        Me.txtNombre = New SamitCtlNet.SamitTexto()
        Me.lblTipoConcepto = New DevExpress.XtraEditors.LabelControl()
        Me.grbTipoConcepto = New DevExpress.XtraEditors.RadioGroup()
        Me.gcConceptos = New DevExpress.XtraGrid.GridControl()
        Me.gvConceptos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btnLimpiar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.gbxConceptos = New DevExpress.XtraEditors.GroupControl()
        Me.btnConfigurarMovs = New DevExpress.XtraEditors.SimpleButton()
        Me.pnlBotones = New DevExpress.XtraEditors.PanelControl()
        Me.txtPerfiles = New SamitCtlNet.SamitBusq()
        CType(Me.gbxPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxPrincipal.SuspendLayout()
        CType(Me.grbVigente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcPerfilesCta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvPerfilesCta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grbTipoConcepto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcConceptos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvConceptos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gbxConceptos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxConceptos.SuspendLayout()
        CType(Me.pnlBotones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBotones.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxPrincipal
        '
        Me.gbxPrincipal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbxPrincipal.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.gbxPrincipal.AppearanceCaption.Options.UseFont = True
        Me.gbxPrincipal.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.gbxPrincipal.CaptionImageOptions.Padding = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.gbxPrincipal.Controls.Add(Me.txtPerfiles)
        Me.gbxPrincipal.Controls.Add(Me.lblVigente)
        Me.gbxPrincipal.Controls.Add(Me.grbVigente)
        Me.gbxPrincipal.Controls.Add(Me.FormadePago)
        Me.gbxPrincipal.Controls.Add(Me.gcPerfilesCta)
        Me.gbxPrincipal.Controls.Add(Me.btnCargarPerfil)
        Me.gbxPrincipal.Controls.Add(Me.lblUsaPlantillaBase)
        Me.gbxPrincipal.Controls.Add(Me.txtNombre)
        Me.gbxPrincipal.Location = New System.Drawing.Point(5, 4)
        Me.gbxPrincipal.Name = "gbxPrincipal"
        Me.gbxPrincipal.Size = New System.Drawing.Size(624, 491)
        Me.gbxPrincipal.TabIndex = 1
        '
        'lblVigente
        '
        Me.lblVigente.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lblVigente.Appearance.Options.UseFont = True
        Me.lblVigente.Appearance.Options.UseTextOptions = True
        Me.lblVigente.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblVigente.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblVigente.Location = New System.Drawing.Point(1, 88)
        Me.lblVigente.Name = "lblVigente"
        Me.lblVigente.Padding = New System.Windows.Forms.Padding(2)
        Me.lblVigente.Size = New System.Drawing.Size(85, 26)
        Me.lblVigente.TabIndex = 112
        Me.lblVigente.Text = "Vigente :"
        '
        'grbVigente
        '
        Me.grbVigente.EditValue = True
        Me.grbVigente.Location = New System.Drawing.Point(94, 89)
        Me.grbVigente.Name = "grbVigente"
        Me.grbVigente.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.grbVigente.Properties.Appearance.Options.UseBackColor = True
        Me.grbVigente.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.grbVigente.Properties.Columns = 2
        Me.grbVigente.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.grbVigente.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "NO"), New DevExpress.XtraEditors.Controls.RadioGroupItem(True, "SI")})
        Me.grbVigente.Size = New System.Drawing.Size(91, 25)
        Me.grbVigente.TabIndex = 3
        '
        'FormadePago
        '
        Me.FormadePago.AlineacionTexto = SamitCtlNet.AlinearTexto.Centro
        Me.FormadePago.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.FormadePago.AltodelControl = 30
        Me.FormadePago.AnchoLabel = 90
        Me.FormadePago.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FormadePago.AnchoTxt = 50
        Me.FormadePago.AutoCargarDatos = True
        Me.FormadePago.AutoSize = True
        Me.FormadePago.BackColor = System.Drawing.Color.Transparent
        Me.FormadePago.ColorFondo = System.Drawing.Color.Transparent
        Me.FormadePago.CondicionValida = ""
        Me.FormadePago.Conexion = SamitCtlNet.ConexionSAMIT.ConexModulo
        Me.FormadePago.ConsultaSQL = Nothing
        Me.FormadePago.EsObligatorio = False
        Me.FormadePago.FormatoNumero = Nothing
        Me.FormadePago.Location = New System.Drawing.Point(0, 52)
        Me.FormadePago.MaximoAncho = 0
        Me.FormadePago.MensajedeAyuda = Nothing
        Me.FormadePago.Name = "FormadePago"
        Me.FormadePago.Size = New System.Drawing.Size(617, 30)
        Me.FormadePago.SoloLectura = False
        Me.FormadePago.SoloNumeros = True
        Me.FormadePago.TabIndex = 2
        Me.FormadePago.TextodelControl = ""
        Me.FormadePago.TextoLabel = "Forma Pago :"
        Me.FormadePago.TieneErrorControl = False
        Me.FormadePago.TipoBusqueda = SamitCtlNet.ModGeneral.TipoBusqueda.Ninguna
        Me.FormadePago.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.FormadePago.TipodeLetra = New System.Drawing.Font("Arial", 9.0!)
        Me.FormadePago.ValordelControl = ""
        Me.FormadePago.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.FormadePago.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.FormadePago.ValorPredeterminado = Nothing
        '
        'gcPerfilesCta
        '
        Me.gcPerfilesCta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcPerfilesCta.Location = New System.Drawing.Point(0, 129)
        Me.gcPerfilesCta.MainView = Me.gvPerfilesCta
        Me.gcPerfilesCta.Name = "gcPerfilesCta"
        Me.gcPerfilesCta.Size = New System.Drawing.Size(624, 362)
        Me.gcPerfilesCta.TabIndex = 109
        Me.gcPerfilesCta.TabStop = False
        Me.gcPerfilesCta.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvPerfilesCta})
        '
        'gvPerfilesCta
        '
        Me.gvPerfilesCta.GridControl = Me.gcPerfilesCta
        Me.gvPerfilesCta.Name = "gvPerfilesCta"
        Me.gvPerfilesCta.OptionsView.ShowGroupPanel = False
        '
        'btnCargarPerfil
        '
        Me.btnCargarPerfil.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnCargarPerfil.Appearance.Options.UseFont = True
        Me.btnCargarPerfil.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnCargarPerfil.Location = New System.Drawing.Point(297, 89)
        Me.btnCargarPerfil.Name = "btnCargarPerfil"
        Me.btnCargarPerfil.Size = New System.Drawing.Size(130, 26)
        Me.btnCargarPerfil.TabIndex = 108
        Me.btnCargarPerfil.TabStop = False
        Me.btnCargarPerfil.Text = "Cargar Perfil"
        '
        'lblUsaPlantillaBase
        '
        Me.lblUsaPlantillaBase.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lblUsaPlantillaBase.Appearance.Options.UseFont = True
        Me.lblUsaPlantillaBase.Appearance.Options.UseTextOptions = True
        Me.lblUsaPlantillaBase.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblUsaPlantillaBase.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblUsaPlantillaBase.Location = New System.Drawing.Point(213, 88)
        Me.lblUsaPlantillaBase.Name = "lblUsaPlantillaBase"
        Me.lblUsaPlantillaBase.Padding = New System.Windows.Forms.Padding(2)
        Me.lblUsaPlantillaBase.Size = New System.Drawing.Size(78, 26)
        Me.lblUsaPlantillaBase.TabIndex = 107
        Me.lblUsaPlantillaBase.Text = "Perfil. Base :"
        '
        'txtNombre
        '
        Me.txtNombre.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtNombre.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtNombre.AltodelControl = 30
        Me.txtNombre.AnchoLabel = 90
        Me.txtNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombre.AutoSize = True
        Me.txtNombre.BackColor = System.Drawing.Color.Transparent
        Me.txtNombre.ColordeFondo = System.Drawing.Color.Transparent
        Me.txtNombre.EsObligatorio = False
        Me.txtNombre.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.txtNombre.FormatoNumero = Nothing
        Me.txtNombre.Location = New System.Drawing.Point(0, 25)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtNombre.MaximoAncho = 0
        Me.txtNombre.MensajedeAyuda = "Digite la denominación del cargo que desea registrar o actualizar. (ENTER,ABJ)=Av" &
    "anzar"
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(618, 30)
        Me.txtNombre.SoloLectura = False
        Me.txtNombre.SoloNumeros = False
        Me.txtNombre.TabIndex = 1
        Me.txtNombre.TextodelControl = ""
        Me.txtNombre.TextoLabel = "Nombre :"
        Me.txtNombre.TieneErrorControl = False
        Me.txtNombre.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtNombre.TipodeLetra = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ValordelControl = Nothing
        Me.txtNombre.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.ValorPredeterminado = Nothing
        '
        'lblTipoConcepto
        '
        Me.lblTipoConcepto.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lblTipoConcepto.Appearance.Options.UseFont = True
        Me.lblTipoConcepto.Appearance.Options.UseTextOptions = True
        Me.lblTipoConcepto.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblTipoConcepto.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblTipoConcepto.Location = New System.Drawing.Point(-7, 32)
        Me.lblTipoConcepto.Name = "lblTipoConcepto"
        Me.lblTipoConcepto.Padding = New System.Windows.Forms.Padding(2)
        Me.lblTipoConcepto.Size = New System.Drawing.Size(129, 26)
        Me.lblTipoConcepto.TabIndex = 72
        Me.lblTipoConcepto.Text = "Tipo Conceptos :"
        '
        'grbTipoConcepto
        '
        Me.grbTipoConcepto.EditValue = False
        Me.grbTipoConcepto.Location = New System.Drawing.Point(128, 35)
        Me.grbTipoConcepto.Name = "grbTipoConcepto"
        Me.grbTipoConcepto.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.grbTipoConcepto.Properties.Appearance.Options.UseBackColor = True
        Me.grbTipoConcepto.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.grbTipoConcepto.Properties.Columns = 3
        Me.grbTipoConcepto.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.grbTipoConcepto.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "Ingresos"), New DevExpress.XtraEditors.Controls.RadioGroupItem(True, "Provisiones"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Deducciones")})
        Me.grbTipoConcepto.Size = New System.Drawing.Size(275, 20)
        Me.grbTipoConcepto.TabIndex = 4
        '
        'gcConceptos
        '
        Me.gcConceptos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcConceptos.Location = New System.Drawing.Point(0, 64)
        Me.gcConceptos.MainView = Me.gvConceptos
        Me.gcConceptos.Name = "gcConceptos"
        Me.gcConceptos.Size = New System.Drawing.Size(634, 428)
        Me.gcConceptos.TabIndex = 0
        Me.gcConceptos.TabStop = False
        Me.gcConceptos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvConceptos})
        '
        'gvConceptos
        '
        Me.gvConceptos.GridControl = Me.gcConceptos
        Me.gvConceptos.Name = "gvConceptos"
        Me.gvConceptos.OptionsView.ShowGroupPanel = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLimpiar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnLimpiar.Appearance.Options.UseFont = True
        Me.btnLimpiar.Location = New System.Drawing.Point(1115, 12)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(74, 38)
        Me.btnLimpiar.TabIndex = 6
        Me.btnLimpiar.Text = "Limpiar"
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(1195, 12)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(74, 38)
        Me.btnSalir.TabIndex = 7
        Me.btnSalir.Text = "Salir"
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Location = New System.Drawing.Point(1035, 12)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(74, 38)
        Me.btnGuardar.TabIndex = 5
        Me.btnGuardar.Text = "Guardar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'gbxConceptos
        '
        Me.gbxConceptos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxConceptos.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.gbxConceptos.AppearanceCaption.Options.UseFont = True
        Me.gbxConceptos.Controls.Add(Me.btnConfigurarMovs)
        Me.gbxConceptos.Controls.Add(Me.gcConceptos)
        Me.gbxConceptos.Controls.Add(Me.grbTipoConcepto)
        Me.gbxConceptos.Controls.Add(Me.lblTipoConcepto)
        Me.gbxConceptos.Location = New System.Drawing.Point(635, 4)
        Me.gbxConceptos.Name = "gbxConceptos"
        Me.gbxConceptos.Size = New System.Drawing.Size(634, 492)
        Me.gbxConceptos.TabIndex = 2
        Me.gbxConceptos.Text = "Conceptos del perfil"
        '
        'btnConfigurarMovs
        '
        Me.btnConfigurarMovs.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnConfigurarMovs.Appearance.Options.UseFont = True
        Me.btnConfigurarMovs.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnConfigurarMovs.Location = New System.Drawing.Point(430, 30)
        Me.btnConfigurarMovs.Name = "btnConfigurarMovs"
        Me.btnConfigurarMovs.Size = New System.Drawing.Size(130, 26)
        Me.btnConfigurarMovs.TabIndex = 109
        Me.btnConfigurarMovs.TabStop = False
        Me.btnConfigurarMovs.Text = "Configurar"
        '
        'pnlBotones
        '
        Me.pnlBotones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlBotones.Controls.Add(Me.btnLimpiar)
        Me.pnlBotones.Controls.Add(Me.btnSalir)
        Me.pnlBotones.Controls.Add(Me.btnGuardar)
        Me.pnlBotones.Location = New System.Drawing.Point(-3, 502)
        Me.pnlBotones.Name = "pnlBotones"
        Me.pnlBotones.Size = New System.Drawing.Size(1276, 62)
        Me.pnlBotones.TabIndex = 3
        '
        'txtPerfiles
        '
        Me.txtPerfiles.AlineacionTexto = SamitCtlNet.AlinearTexto.Centro
        Me.txtPerfiles.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtPerfiles.AltodelControl = 30
        Me.txtPerfiles.AnchoLabel = 90
        Me.txtPerfiles.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPerfiles.AnchoTxt = 50
        Me.txtPerfiles.AutoCargarDatos = True
        Me.txtPerfiles.AutoSize = True
        Me.txtPerfiles.BackColor = System.Drawing.Color.Transparent
        Me.txtPerfiles.ColorFondo = System.Drawing.Color.Transparent
        Me.txtPerfiles.CondicionValida = ""
        Me.txtPerfiles.Conexion = SamitCtlNet.ConexionSAMIT.ConexModulo
        Me.txtPerfiles.ConsultaSQL = Nothing
        Me.txtPerfiles.EsObligatorio = False
        Me.txtPerfiles.FormatoNumero = Nothing
        Me.txtPerfiles.Location = New System.Drawing.Point(849, 152)
        Me.txtPerfiles.MaximoAncho = 0
        Me.txtPerfiles.MensajedeAyuda = Nothing
        Me.txtPerfiles.Name = "txtPerfiles"
        Me.txtPerfiles.Size = New System.Drawing.Size(252, 30)
        Me.txtPerfiles.SoloLectura = False
        Me.txtPerfiles.SoloNumeros = True
        Me.txtPerfiles.TabIndex = 4
        Me.txtPerfiles.TextodelControl = ""
        Me.txtPerfiles.TextoLabel = "Forma Pago :"
        Me.txtPerfiles.TieneErrorControl = False
        Me.txtPerfiles.TipoBusqueda = SamitCtlNet.ModGeneral.TipoBusqueda.Ninguna
        Me.txtPerfiles.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtPerfiles.TipodeLetra = New System.Drawing.Font("Arial", 9.0!)
        Me.txtPerfiles.ValordelControl = ""
        Me.txtPerfiles.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPerfiles.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPerfiles.ValorPredeterminado = Nothing
        '
        'FrmPerfilesCta
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1274, 563)
        Me.Controls.Add(Me.pnlBotones)
        Me.Controls.Add(Me.gbxConceptos)
        Me.Controls.Add(Me.gbxPrincipal)
        Me.IconOptions.Icon = CType(resources.GetObject("FrmPerfilesCta.IconOptions.Icon"), System.Drawing.Icon)
        Me.Name = "FrmPerfilesCta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Perfil De Cuentas Contables"
        CType(Me.gbxPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxPrincipal.ResumeLayout(False)
        Me.gbxPrincipal.PerformLayout()
        CType(Me.grbVigente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcPerfilesCta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvPerfilesCta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grbTipoConcepto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcConceptos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvConceptos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gbxConceptos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxConceptos.ResumeLayout(False)
        CType(Me.pnlBotones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBotones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbxPrincipal As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gcConceptos As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvConceptos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnLimpiar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grbTipoConcepto As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents lblTipoConcepto As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnCargarPerfil As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblUsaPlantillaBase As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNombre As SamitCtlNet.SamitTexto
    Friend WithEvents gbxConceptos As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gcPerfilesCta As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvPerfilesCta As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents pnlBotones As DevExpress.XtraEditors.PanelControl
    Friend WithEvents FormadePago As SamitCtlNet.SamitBusq
    Friend WithEvents lblVigente As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grbVigente As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents btnConfigurarMovs As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtPerfiles As SamitCtlNet.SamitBusq
End Class
