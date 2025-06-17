<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAggCentroCosto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAggCentroCosto))
        Me.gbxPrincipal = New DevExpress.XtraEditors.GroupControl()
        Me.dteFechaFinLimite = New DevExpress.XtraEditors.DateEdit()
        Me.SeparatorControl1 = New DevExpress.XtraEditors.SeparatorControl()
        Me.dteFechaIniLimite = New DevExpress.XtraEditors.DateEdit()
        Me.lblUsoLimitado = New DevExpress.XtraEditors.LabelControl()
        Me.grbUsolimitado = New DevExpress.XtraEditors.RadioGroup()
        Me.lblVigente = New DevExpress.XtraEditors.LabelControl()
        Me.grbVigente = New DevExpress.XtraEditors.RadioGroup()
        Me.txtResponsable = New SamitCtlNet.SamitTexto()
        Me.txtBusqueda = New DevExpress.XtraEditors.TextEdit()
        Me.txtNombreCentrodeCosto = New SamitCtlNet.SamitTexto()
        Me.gcCentroCosto = New DevExpress.XtraGrid.GridControl()
        Me.gvCentroCosto = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.lblFechaFinLimite = New DevExpress.XtraEditors.LabelControl()
        Me.lblFechaIniLimite = New DevExpress.XtraEditors.LabelControl()
        Me.btnLimpiar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEliminar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        CType(Me.gbxPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxPrincipal.SuspendLayout()
        CType(Me.dteFechaFinLimite.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFechaFinLimite.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFechaIniLimite.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFechaIniLimite.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grbUsolimitado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grbVigente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBusqueda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcCentroCosto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvCentroCosto, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.gbxPrincipal.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.gbxPrincipal.CaptionImageOptions.Padding = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.gbxPrincipal.Controls.Add(Me.dteFechaFinLimite)
        Me.gbxPrincipal.Controls.Add(Me.SeparatorControl1)
        Me.gbxPrincipal.Controls.Add(Me.dteFechaIniLimite)
        Me.gbxPrincipal.Controls.Add(Me.lblUsoLimitado)
        Me.gbxPrincipal.Controls.Add(Me.grbUsolimitado)
        Me.gbxPrincipal.Controls.Add(Me.lblVigente)
        Me.gbxPrincipal.Controls.Add(Me.grbVigente)
        Me.gbxPrincipal.Controls.Add(Me.txtResponsable)
        Me.gbxPrincipal.Controls.Add(Me.txtBusqueda)
        Me.gbxPrincipal.Controls.Add(Me.txtNombreCentrodeCosto)
        Me.gbxPrincipal.Controls.Add(Me.gcCentroCosto)
        Me.gbxPrincipal.Controls.Add(Me.lblFechaFinLimite)
        Me.gbxPrincipal.Controls.Add(Me.lblFechaIniLimite)
        Me.gbxPrincipal.Location = New System.Drawing.Point(8, 9)
        Me.gbxPrincipal.Name = "gbxPrincipal"
        Me.gbxPrincipal.Size = New System.Drawing.Size(583, 551)
        Me.gbxPrincipal.TabIndex = 0
        Me.gbxPrincipal.TabStop = True
        Me.gbxPrincipal.Text = "Datos del Centro de Costo"
        '
        'dteFechaFinLimite
        '
        Me.dteFechaFinLimite.EditValue = Nothing
        Me.dteFechaFinLimite.Location = New System.Drawing.Point(311, 106)
        Me.dteFechaFinLimite.Name = "dteFechaFinLimite"
        Me.dteFechaFinLimite.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.dteFechaFinLimite.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.dteFechaFinLimite.Properties.Appearance.Options.UseBackColor = True
        Me.dteFechaFinLimite.Properties.Appearance.Options.UseFont = True
        Me.dteFechaFinLimite.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.dteFechaFinLimite.Properties.AppearanceDropDown.Options.UseFont = True
        Me.dteFechaFinLimite.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteFechaFinLimite.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteFechaFinLimite.Properties.CloseUpKey = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.Right)
        Me.dteFechaFinLimite.Size = New System.Drawing.Size(114, 20)
        Me.dteFechaFinLimite.TabIndex = 6
        '
        'SeparatorControl1
        '
        Me.SeparatorControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SeparatorControl1.Location = New System.Drawing.Point(2, 133)
        Me.SeparatorControl1.Name = "SeparatorControl1"
        Me.SeparatorControl1.Padding = New System.Windows.Forms.Padding(0)
        Me.SeparatorControl1.Size = New System.Drawing.Size(576, 3)
        Me.SeparatorControl1.TabIndex = 101
        '
        'dteFechaIniLimite
        '
        Me.dteFechaIniLimite.EditValue = Nothing
        Me.dteFechaIniLimite.Location = New System.Drawing.Point(311, 83)
        Me.dteFechaIniLimite.Name = "dteFechaIniLimite"
        Me.dteFechaIniLimite.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.dteFechaIniLimite.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.dteFechaIniLimite.Properties.Appearance.Options.UseBackColor = True
        Me.dteFechaIniLimite.Properties.Appearance.Options.UseFont = True
        Me.dteFechaIniLimite.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.dteFechaIniLimite.Properties.AppearanceDropDown.Options.UseFont = True
        Me.dteFechaIniLimite.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteFechaIniLimite.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteFechaIniLimite.Properties.CloseUpKey = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.Right)
        Me.dteFechaIniLimite.Size = New System.Drawing.Size(114, 20)
        Me.dteFechaIniLimite.TabIndex = 5
        '
        'lblUsoLimitado
        '
        Me.lblUsoLimitado.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lblUsoLimitado.Appearance.Options.UseFont = True
        Me.lblUsoLimitado.Appearance.Options.UseTextOptions = True
        Me.lblUsoLimitado.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblUsoLimitado.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblUsoLimitado.Location = New System.Drawing.Point(-15, 80)
        Me.lblUsoLimitado.Name = "lblUsoLimitado"
        Me.lblUsoLimitado.Padding = New System.Windows.Forms.Padding(2)
        Me.lblUsoLimitado.Size = New System.Drawing.Size(121, 26)
        Me.lblUsoLimitado.TabIndex = 96
        Me.lblUsoLimitado.Text = "Uso Limitado :"
        '
        'grbUsolimitado
        '
        Me.grbUsolimitado.Location = New System.Drawing.Point(114, 82)
        Me.grbUsolimitado.Name = "grbUsolimitado"
        Me.grbUsolimitado.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.grbUsolimitado.Properties.Appearance.Options.UseBackColor = True
        Me.grbUsolimitado.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.grbUsolimitado.Properties.Columns = 2
        Me.grbUsolimitado.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.grbUsolimitado.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "NO"), New DevExpress.XtraEditors.Controls.RadioGroupItem(True, "SI")})
        Me.grbUsolimitado.Size = New System.Drawing.Size(91, 20)
        Me.grbUsolimitado.TabIndex = 3
        '
        'lblVigente
        '
        Me.lblVigente.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lblVigente.Appearance.Options.UseFont = True
        Me.lblVigente.Appearance.Options.UseTextOptions = True
        Me.lblVigente.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblVigente.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblVigente.Location = New System.Drawing.Point(6, 105)
        Me.lblVigente.Name = "lblVigente"
        Me.lblVigente.Padding = New System.Windows.Forms.Padding(2)
        Me.lblVigente.Size = New System.Drawing.Size(99, 26)
        Me.lblVigente.TabIndex = 94
        Me.lblVigente.Text = "Vigente :"
        '
        'grbVigente
        '
        Me.grbVigente.Location = New System.Drawing.Point(114, 109)
        Me.grbVigente.Name = "grbVigente"
        Me.grbVigente.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.grbVigente.Properties.Appearance.Options.UseBackColor = True
        Me.grbVigente.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.grbVigente.Properties.Columns = 2
        Me.grbVigente.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.grbVigente.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "NO"), New DevExpress.XtraEditors.Controls.RadioGroupItem(True, "SI")})
        Me.grbVigente.Size = New System.Drawing.Size(91, 20)
        Me.grbVigente.TabIndex = 4
        '
        'txtResponsable
        '
        Me.txtResponsable.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtResponsable.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtResponsable.AltodelControl = 30
        Me.txtResponsable.AnchoLabel = 110
        Me.txtResponsable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtResponsable.AutoSize = True
        Me.txtResponsable.BackColor = System.Drawing.Color.Transparent
        Me.txtResponsable.ColordeFondo = System.Drawing.Color.Transparent
        Me.txtResponsable.EsObligatorio = False
        Me.txtResponsable.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResponsable.FormatoNumero = Nothing
        Me.txtResponsable.Location = New System.Drawing.Point(-1, 54)
        Me.txtResponsable.MaximoAncho = 0
        Me.txtResponsable.MensajedeAyuda = ""
        Me.txtResponsable.Name = "txtResponsable"
        Me.txtResponsable.Size = New System.Drawing.Size(580, 30)
        Me.txtResponsable.SoloLectura = False
        Me.txtResponsable.SoloNumeros = True
        Me.txtResponsable.TabIndex = 2
        Me.txtResponsable.TextodelControl = ""
        Me.txtResponsable.TextoLabel = "Responsable :"
        Me.txtResponsable.TieneErrorControl = False
        Me.txtResponsable.TipodeDatos = SamitCtlNet.TipodeDato.Numeros
        Me.txtResponsable.TipodeLetra = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtResponsable.ValordelControl = Nothing
        Me.txtResponsable.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtResponsable.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtResponsable.ValorPredeterminado = Nothing
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBusqueda.Location = New System.Drawing.Point(2, 141)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.txtBusqueda.Properties.Appearance.Options.UseFont = True
        Me.txtBusqueda.Size = New System.Drawing.Size(579, 24)
        Me.txtBusqueda.TabIndex = 7
        Me.txtBusqueda.TabStop = False
        '
        'txtNombreCentrodeCosto
        '
        Me.txtNombreCentrodeCosto.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtNombreCentrodeCosto.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtNombreCentrodeCosto.AltodelControl = 30
        Me.txtNombreCentrodeCosto.AnchoLabel = 100
        Me.txtNombreCentrodeCosto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombreCentrodeCosto.AutoSize = True
        Me.txtNombreCentrodeCosto.BackColor = System.Drawing.Color.Transparent
        Me.txtNombreCentrodeCosto.ColordeFondo = System.Drawing.Color.Transparent
        Me.txtNombreCentrodeCosto.EsObligatorio = False
        Me.txtNombreCentrodeCosto.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreCentrodeCosto.FormatoNumero = Nothing
        Me.txtNombreCentrodeCosto.Location = New System.Drawing.Point(9, 26)
        Me.txtNombreCentrodeCosto.MaximoAncho = 0
        Me.txtNombreCentrodeCosto.MensajedeAyuda = ""
        Me.txtNombreCentrodeCosto.Name = "txtNombreCentrodeCosto"
        Me.txtNombreCentrodeCosto.Size = New System.Drawing.Size(570, 30)
        Me.txtNombreCentrodeCosto.SoloLectura = False
        Me.txtNombreCentrodeCosto.SoloNumeros = False
        Me.txtNombreCentrodeCosto.TabIndex = 1
        Me.txtNombreCentrodeCosto.TextodelControl = ""
        Me.txtNombreCentrodeCosto.TextoLabel = "Nombre :"
        Me.txtNombreCentrodeCosto.TieneErrorControl = False
        Me.txtNombreCentrodeCosto.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtNombreCentrodeCosto.TipodeLetra = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtNombreCentrodeCosto.ValordelControl = Nothing
        Me.txtNombreCentrodeCosto.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombreCentrodeCosto.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombreCentrodeCosto.ValorPredeterminado = Nothing
        '
        'gcCentroCosto
        '
        Me.gcCentroCosto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcCentroCosto.Location = New System.Drawing.Point(0, 168)
        Me.gcCentroCosto.MainView = Me.gvCentroCosto
        Me.gcCentroCosto.Name = "gcCentroCosto"
        Me.gcCentroCosto.Size = New System.Drawing.Size(583, 383)
        Me.gcCentroCosto.TabIndex = 10
        Me.gcCentroCosto.TabStop = False
        Me.gcCentroCosto.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvCentroCosto})
        '
        'gvCentroCosto
        '
        Me.gvCentroCosto.GridControl = Me.gcCentroCosto
        Me.gvCentroCosto.Name = "gvCentroCosto"
        '
        'lblFechaFinLimite
        '
        Me.lblFechaFinLimite.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaFinLimite.Appearance.Options.UseFont = True
        Me.lblFechaFinLimite.Appearance.Options.UseTextOptions = True
        Me.lblFechaFinLimite.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblFechaFinLimite.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblFechaFinLimite.Location = New System.Drawing.Point(218, 103)
        Me.lblFechaFinLimite.Name = "lblFechaFinLimite"
        Me.lblFechaFinLimite.Padding = New System.Windows.Forms.Padding(2)
        Me.lblFechaFinLimite.Size = New System.Drawing.Size(85, 26)
        Me.lblFechaFinLimite.TabIndex = 100
        Me.lblFechaFinLimite.Text = "Fecha Fin :"
        '
        'lblFechaIniLimite
        '
        Me.lblFechaIniLimite.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaIniLimite.Appearance.Options.UseFont = True
        Me.lblFechaIniLimite.Appearance.Options.UseTextOptions = True
        Me.lblFechaIniLimite.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblFechaIniLimite.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblFechaIniLimite.Location = New System.Drawing.Point(190, 79)
        Me.lblFechaIniLimite.Name = "lblFechaIniLimite"
        Me.lblFechaIniLimite.Padding = New System.Windows.Forms.Padding(2)
        Me.lblFechaIniLimite.Size = New System.Drawing.Size(113, 26)
        Me.lblFechaIniLimite.TabIndex = 98
        Me.lblFechaIniLimite.Text = "Fecha Inicio :"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnLimpiar.Appearance.Options.UseFont = True
        Me.btnLimpiar.Location = New System.Drawing.Point(7, 61)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(74, 30)
        Me.btnLimpiar.TabIndex = 2
        Me.btnLimpiar.Text = "Limpiar"
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Location = New System.Drawing.Point(7, 25)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(74, 30)
        Me.btnGuardar.TabIndex = 1
        Me.btnGuardar.Text = "Guardar"
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(7, 97)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(74, 30)
        Me.btnEliminar.TabIndex = 3
        Me.btnEliminar.Text = "Eliminar"
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(7, 133)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(74, 30)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "Salir"
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.GroupControl1.CaptionImageOptions.Padding = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.GroupControl1.Controls.Add(Me.btnSalir)
        Me.GroupControl1.Controls.Add(Me.btnEliminar)
        Me.GroupControl1.Controls.Add(Me.btnLimpiar)
        Me.GroupControl1.Controls.Add(Me.btnGuardar)
        Me.GroupControl1.Location = New System.Drawing.Point(595, 9)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(88, 551)
        Me.GroupControl1.TabIndex = 1
        Me.GroupControl1.TabStop = True
        Me.GroupControl1.Text = "Opciones"
        '
        'FrmAggCentroCosto
        '
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 573)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.gbxPrincipal)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None
        Me.IconOptions.Icon = CType(resources.GetObject("FrmAggCentroCosto.IconOptions.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(551, 564)
        Me.Name = "FrmAggCentroCosto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Centros de Costos"
        CType(Me.gbxPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxPrincipal.ResumeLayout(False)
        Me.gbxPrincipal.PerformLayout()
        CType(Me.dteFechaFinLimite.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFechaFinLimite.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFechaIniLimite.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFechaIniLimite.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grbUsolimitado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grbVigente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBusqueda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcCentroCosto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvCentroCosto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbxPrincipal As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtBusqueda As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnLimpiar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtNombreCentrodeCosto As SamitCtlNet.SamitTexto
    Friend WithEvents gcCentroCosto As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvCentroCosto As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtResponsable As SamitCtlNet.SamitTexto
    Friend WithEvents lblUsoLimitado As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grbUsolimitado As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents lblVigente As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grbVigente As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents lblFechaFinLimite As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblFechaIniLimite As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dteFechaIniLimite As DevExpress.XtraEditors.DateEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SeparatorControl1 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents dteFechaFinLimite As DevExpress.XtraEditors.DateEdit
End Class
