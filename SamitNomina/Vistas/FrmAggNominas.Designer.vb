<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAggNominas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAggNominas))
        Me.gbxPrincipal = New DevExpress.XtraEditors.GroupControl()
        Me.btnCargarNomina = New DevExpress.XtraEditors.SimpleButton()
        Me.lblUsaPlantillaBase = New DevExpress.XtraEditors.LabelControl()
        Me.txtNominas = New SamitCtlNet.SamitBusq()
        Me.cke30dias = New DevExpress.XtraEditors.CheckEdit()
        Me.cke15dias = New DevExpress.XtraEditors.CheckEdit()
        Me.lblPeriodoLiquida = New DevExpress.XtraEditors.LabelControl()
        Me.cke10dias = New DevExpress.XtraEditors.CheckEdit()
        Me.SeparatorControl6 = New DevExpress.XtraEditors.SeparatorControl()
        Me.txtOficina = New SamitCtlNet.SamitBusq()
        Me.lblFecha = New DevExpress.XtraEditors.LabelControl()
        Me.dteFecha = New DevExpress.XtraEditors.DateEdit()
        Me.txtBusqueda = New DevExpress.XtraEditors.TextEdit()
        Me.txtNombreNomina = New SamitCtlNet.SamitTexto()
        Me.gcNominas = New DevExpress.XtraGrid.GridControl()
        Me.gvNominas = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btnLimpiar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEliminar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        CType(Me.gbxPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxPrincipal.SuspendLayout()
        CType(Me.cke30dias.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cke15dias.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cke10dias.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeparatorControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBusqueda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcNominas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvNominas, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.gbxPrincipal.CaptionImageOptions.Padding = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.gbxPrincipal.Controls.Add(Me.btnCargarNomina)
        Me.gbxPrincipal.Controls.Add(Me.lblUsaPlantillaBase)
        Me.gbxPrincipal.Controls.Add(Me.cke30dias)
        Me.gbxPrincipal.Controls.Add(Me.gcNominas)
        Me.gbxPrincipal.Controls.Add(Me.cke15dias)
        Me.gbxPrincipal.Controls.Add(Me.lblPeriodoLiquida)
        Me.gbxPrincipal.Controls.Add(Me.cke10dias)
        Me.gbxPrincipal.Controls.Add(Me.SeparatorControl6)
        Me.gbxPrincipal.Controls.Add(Me.txtOficina)
        Me.gbxPrincipal.Controls.Add(Me.lblFecha)
        Me.gbxPrincipal.Controls.Add(Me.dteFecha)
        Me.gbxPrincipal.Controls.Add(Me.txtBusqueda)
        Me.gbxPrincipal.Controls.Add(Me.txtNombreNomina)
        Me.gbxPrincipal.Location = New System.Drawing.Point(8, 10)
        Me.gbxPrincipal.Name = "gbxPrincipal"
        Me.gbxPrincipal.Size = New System.Drawing.Size(581, 553)
        Me.gbxPrincipal.TabIndex = 0
        Me.gbxPrincipal.TabStop = True
        Me.gbxPrincipal.Text = "Datos de la Nomina"
        '
        'btnCargarNomina
        '
        Me.btnCargarNomina.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnCargarNomina.Appearance.Options.UseFont = True
        Me.btnCargarNomina.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnCargarNomina.Location = New System.Drawing.Point(135, 144)
        Me.btnCargarNomina.Name = "btnCargarNomina"
        Me.btnCargarNomina.Size = New System.Drawing.Size(130, 26)
        Me.btnCargarNomina.TabIndex = 128
        Me.btnCargarNomina.Text = "Cargar Plantilla"
        '
        'lblUsaPlantillaBase
        '
        Me.lblUsaPlantillaBase.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lblUsaPlantillaBase.Appearance.Options.UseFont = True
        Me.lblUsaPlantillaBase.Appearance.Options.UseTextOptions = True
        Me.lblUsaPlantillaBase.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblUsaPlantillaBase.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblUsaPlantillaBase.Location = New System.Drawing.Point(20, 143)
        Me.lblUsaPlantillaBase.Name = "lblUsaPlantillaBase"
        Me.lblUsaPlantillaBase.Padding = New System.Windows.Forms.Padding(2)
        Me.lblUsaPlantillaBase.Size = New System.Drawing.Size(108, 26)
        Me.lblUsaPlantillaBase.TabIndex = 127
        Me.lblUsaPlantillaBase.Text = "Nomina Base :"
        '
        'txtNominas
        '
        Me.txtNominas.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtNominas.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtNominas.AltodelControl = 30
        Me.txtNominas.AnchoLabel = 130
        Me.txtNominas.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtNominas.AnchoTxt = 80
        Me.txtNominas.AutoCargarDatos = True
        Me.txtNominas.AutoSize = True
        Me.txtNominas.BackColor = System.Drawing.Color.Transparent
        Me.txtNominas.ColorFondo = System.Drawing.Color.Transparent
        Me.txtNominas.CondicionValida = ""
        Me.txtNominas.Conexion = SamitCtlNet.ConexionSAMIT.ConexModulo
        Me.txtNominas.ConsultaSQL = Nothing
        Me.txtNominas.EsObligatorio = False
        Me.txtNominas.FormatoNumero = Nothing
        Me.txtNominas.Location = New System.Drawing.Point(11, 329)
        Me.txtNominas.MaximoAncho = 0
        Me.txtNominas.MensajedeAyuda = Nothing
        Me.txtNominas.Name = "txtNominas"
        Me.txtNominas.Size = New System.Drawing.Size(573, 30)
        Me.txtNominas.SoloLectura = False
        Me.txtNominas.SoloNumeros = True
        Me.txtNominas.TabIndex = 126
        Me.txtNominas.TextodelControl = ""
        Me.txtNominas.TextoLabel = "nominas"
        Me.txtNominas.TieneErrorControl = False
        Me.txtNominas.TipoBusqueda = SamitCtlNet.ModGeneral.TipoBusqueda.Ninguna
        Me.txtNominas.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtNominas.TipodeLetra = New System.Drawing.Font("Arial", 9.0!)
        Me.txtNominas.ValordelControl = ""
        Me.txtNominas.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNominas.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNominas.ValorPredeterminado = Nothing
        Me.txtNominas.Visible = False
        '
        'cke30dias
        '
        Me.cke30dias.Location = New System.Drawing.Point(289, 56)
        Me.cke30dias.Name = "cke30dias"
        Me.cke30dias.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cke30dias.Properties.Appearance.Options.UseFont = True
        Me.cke30dias.Properties.Caption = "30 dias"
        Me.cke30dias.Size = New System.Drawing.Size(75, 20)
        Me.cke30dias.TabIndex = 4
        '
        'cke15dias
        '
        Me.cke15dias.Location = New System.Drawing.Point(212, 56)
        Me.cke15dias.Name = "cke15dias"
        Me.cke15dias.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cke15dias.Properties.Appearance.Options.UseFont = True
        Me.cke15dias.Properties.Caption = "15 dias"
        Me.cke15dias.Size = New System.Drawing.Size(75, 20)
        Me.cke15dias.TabIndex = 3
        '
        'lblPeriodoLiquida
        '
        Me.lblPeriodoLiquida.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lblPeriodoLiquida.Appearance.Options.UseFont = True
        Me.lblPeriodoLiquida.Appearance.Options.UseTextOptions = True
        Me.lblPeriodoLiquida.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblPeriodoLiquida.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblPeriodoLiquida.Location = New System.Drawing.Point(2, 52)
        Me.lblPeriodoLiquida.Name = "lblPeriodoLiquida"
        Me.lblPeriodoLiquida.Padding = New System.Windows.Forms.Padding(2)
        Me.lblPeriodoLiquida.Size = New System.Drawing.Size(127, 26)
        Me.lblPeriodoLiquida.TabIndex = 125
        Me.lblPeriodoLiquida.Text = "Periodos liquidacion  :"
        '
        'cke10dias
        '
        Me.cke10dias.Location = New System.Drawing.Point(135, 56)
        Me.cke10dias.Name = "cke10dias"
        Me.cke10dias.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cke10dias.Properties.Appearance.Options.UseFont = True
        Me.cke10dias.Properties.Caption = "10 dias"
        Me.cke10dias.Size = New System.Drawing.Size(75, 20)
        Me.cke10dias.TabIndex = 2
        '
        'SeparatorControl6
        '
        Me.SeparatorControl6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SeparatorControl6.Location = New System.Drawing.Point(2, 174)
        Me.SeparatorControl6.Name = "SeparatorControl6"
        Me.SeparatorControl6.Padding = New System.Windows.Forms.Padding(0)
        Me.SeparatorControl6.Size = New System.Drawing.Size(576, 3)
        Me.SeparatorControl6.TabIndex = 121
        '
        'txtOficina
        '
        Me.txtOficina.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtOficina.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtOficina.AltodelControl = 30
        Me.txtOficina.AnchoLabel = 130
        Me.txtOficina.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOficina.AnchoTxt = 80
        Me.txtOficina.AutoCargarDatos = True
        Me.txtOficina.AutoSize = True
        Me.txtOficina.BackColor = System.Drawing.Color.Transparent
        Me.txtOficina.ColorFondo = System.Drawing.Color.Transparent
        Me.txtOficina.CondicionValida = ""
        Me.txtOficina.Conexion = SamitCtlNet.ConexionSAMIT.ConexModulo
        Me.txtOficina.ConsultaSQL = Nothing
        Me.txtOficina.EsObligatorio = False
        Me.txtOficina.FormatoNumero = Nothing
        Me.txtOficina.Location = New System.Drawing.Point(2, 110)
        Me.txtOficina.MaximoAncho = 0
        Me.txtOficina.MensajedeAyuda = Nothing
        Me.txtOficina.Name = "txtOficina"
        Me.txtOficina.Size = New System.Drawing.Size(573, 30)
        Me.txtOficina.SoloLectura = False
        Me.txtOficina.SoloNumeros = True
        Me.txtOficina.TabIndex = 6
        Me.txtOficina.TextodelControl = ""
        Me.txtOficina.TextoLabel = "Oficina  :"
        Me.txtOficina.TieneErrorControl = False
        Me.txtOficina.TipoBusqueda = SamitCtlNet.ModGeneral.TipoBusqueda.Ninguna
        Me.txtOficina.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtOficina.TipodeLetra = New System.Drawing.Font("Arial", 9.0!)
        Me.txtOficina.ValordelControl = ""
        Me.txtOficina.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtOficina.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtOficina.ValorPredeterminado = Nothing
        '
        'lblFecha
        '
        Me.lblFecha.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Appearance.Options.UseFont = True
        Me.lblFecha.Appearance.Options.UseTextOptions = True
        Me.lblFecha.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblFecha.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblFecha.Location = New System.Drawing.Point(59, 81)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Padding = New System.Windows.Forms.Padding(2)
        Me.lblFecha.Size = New System.Drawing.Size(70, 26)
        Me.lblFecha.TabIndex = 119
        Me.lblFecha.Text = "Fecha  :"
        '
        'dteFecha
        '
        Me.dteFecha.EditValue = Nothing
        Me.dteFecha.Location = New System.Drawing.Point(135, 84)
        Me.dteFecha.Name = "dteFecha"
        Me.dteFecha.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.dteFecha.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.dteFecha.Properties.Appearance.Options.UseBackColor = True
        Me.dteFecha.Properties.Appearance.Options.UseFont = True
        Me.dteFecha.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.dteFecha.Properties.AppearanceDropDown.Options.UseFont = True
        Me.dteFecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteFecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteFecha.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Classic
        Me.dteFecha.Properties.CloseUpKey = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.Right)
        Me.dteFecha.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[False]
        Me.dteFecha.Size = New System.Drawing.Size(169, 20)
        Me.dteFecha.TabIndex = 5
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBusqueda.Location = New System.Drawing.Point(2, 183)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.txtBusqueda.Properties.Appearance.Options.UseFont = True
        Me.txtBusqueda.Size = New System.Drawing.Size(577, 24)
        Me.txtBusqueda.TabIndex = 100
        Me.txtBusqueda.TabStop = False
        '
        'txtNombreNomina
        '
        Me.txtNombreNomina.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtNombreNomina.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtNombreNomina.AltodelControl = 30
        Me.txtNombreNomina.AnchoLabel = 130
        Me.txtNombreNomina.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombreNomina.AutoSize = True
        Me.txtNombreNomina.BackColor = System.Drawing.Color.Transparent
        Me.txtNombreNomina.ColordeFondo = System.Drawing.Color.Transparent
        Me.txtNombreNomina.EsObligatorio = False
        Me.txtNombreNomina.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreNomina.FormatoNumero = Nothing
        Me.txtNombreNomina.Location = New System.Drawing.Point(2, 24)
        Me.txtNombreNomina.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtNombreNomina.MaximoAncho = 0
        Me.txtNombreNomina.MensajedeAyuda = Nothing
        Me.txtNombreNomina.Name = "txtNombreNomina"
        Me.txtNombreNomina.Size = New System.Drawing.Size(575, 30)
        Me.txtNombreNomina.SoloLectura = False
        Me.txtNombreNomina.SoloNumeros = False
        Me.txtNombreNomina.TabIndex = 1
        Me.txtNombreNomina.TextodelControl = ""
        Me.txtNombreNomina.TextoLabel = "Nombre  :"
        Me.txtNombreNomina.TieneErrorControl = False
        Me.txtNombreNomina.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtNombreNomina.TipodeLetra = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtNombreNomina.ValordelControl = Nothing
        Me.txtNombreNomina.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombreNomina.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombreNomina.ValorPredeterminado = Nothing
        '
        'gcNominas
        '
        Me.gcNominas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcNominas.Location = New System.Drawing.Point(0, 210)
        Me.gcNominas.MainView = Me.gvNominas
        Me.gcNominas.Name = "gcNominas"
        Me.gcNominas.Size = New System.Drawing.Size(581, 344)
        Me.gcNominas.TabIndex = 0
        Me.gcNominas.TabStop = False
        Me.gcNominas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvNominas})
        '
        'gvNominas
        '
        Me.gvNominas.GridControl = Me.gcNominas
        Me.gvNominas.Name = "gvNominas"
        '
        'btnLimpiar
        '
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
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Location = New System.Drawing.Point(7, 24)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(74, 30)
        Me.btnGuardar.TabIndex = 1
        Me.btnGuardar.Text = "Guardar"
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(7, 96)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(74, 30)
        Me.btnEliminar.TabIndex = 3
        Me.btnEliminar.Text = "Eliminar"
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(7, 132)
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
        Me.GroupControl1.Location = New System.Drawing.Point(595, 10)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(88, 553)
        Me.GroupControl1.TabIndex = 7
        Me.GroupControl1.TabStop = True
        Me.GroupControl1.Text = "Opciones"
        '
        'FrmAggNominas
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 573)
        Me.Controls.Add(Me.gbxPrincipal)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.txtNominas)
        Me.IconOptions.Icon = CType(resources.GetObject("FrmAggNominas.IconOptions.Icon"), System.Drawing.Icon)
        Me.Name = "FrmAggNominas"
        Me.Text = "Nominas"
        CType(Me.gbxPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxPrincipal.ResumeLayout(False)
        Me.gbxPrincipal.PerformLayout()
        CType(Me.cke30dias.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cke15dias.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cke10dias.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeparatorControl6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBusqueda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcNominas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvNominas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbxPrincipal As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtBusqueda As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnLimpiar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtNombreNomina As SamitCtlNet.SamitTexto
    Friend WithEvents gcNominas As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvNominas As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lblFecha As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dteFecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtOficina As SamitCtlNet.SamitBusq
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SeparatorControl6 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents cke30dias As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cke15dias As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lblPeriodoLiquida As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cke10dias As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtNominas As SamitCtlNet.SamitBusq
    Friend WithEvents btnCargarNomina As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblUsaPlantillaBase As DevExpress.XtraEditors.LabelControl
End Class
