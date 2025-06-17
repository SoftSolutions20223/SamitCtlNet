<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAggConceptosNomina
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAggConceptosNomina))
        Me.gbxPrincipal = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.btnAbajo = New DevExpress.XtraEditors.SimpleButton()
        Me.btnArriba = New DevExpress.XtraEditors.SimpleButton()
        Me.ckeRedonAlaCentena = New DevExpress.XtraEditors.CheckEdit()
        Me.txtCodDian = New SamitCtlNet.SamitBusq()
        Me.btnAddClasifiacion = New DevExpress.XtraEditors.SimpleButton()
        Me.ckeEsRetencion = New DevExpress.XtraEditors.CheckEdit()
        Me.ckeRedonAlPeso = New DevExpress.XtraEditors.CheckEdit()
        Me.lblRedondear = New DevExpress.XtraEditors.LabelControl()
        Me.ckeRedonAlaDecena = New DevExpress.XtraEditors.CheckEdit()
        Me.txtBaseCalculo = New SamitCtlNet.SamitBusq()
        Me.ckeRedonAlMil = New DevExpress.XtraEditors.CheckEdit()
        Me.lblMsg = New DevExpress.XtraEditors.LabelControl()
        Me.txtClasificacion = New SamitCtlNet.SamitBusq()
        Me.ckeEsFondo = New DevExpress.XtraEditors.CheckEdit()
        Me.txtTipoFondo = New SamitCtlNet.SamitBusq()
        Me.SeparatorControl1 = New DevExpress.XtraEditors.SeparatorControl()
        Me.txtTipo = New SamitCtlNet.SamitBusq()
        Me.lblVigente = New DevExpress.XtraEditors.LabelControl()
        Me.grbVigente = New DevExpress.XtraEditors.RadioGroup()
        Me.gcConceptos = New DevExpress.XtraGrid.GridControl()
        Me.gvConceptos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcVariables = New DevExpress.XtraGrid.GridControl()
        Me.gvVariables = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtBusqueda = New DevExpress.XtraEditors.TextEdit()
        Me.txtNombre = New SamitCtlNet.SamitTexto()
        Me.btnLimpiar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEliminar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        CType(Me.gbxPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxPrincipal.SuspendLayout()
        CType(Me.ckeRedonAlaCentena.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckeEsRetencion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckeRedonAlPeso.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckeRedonAlaDecena.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckeRedonAlMil.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckeEsFondo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grbVigente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcConceptos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvConceptos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcVariables, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvVariables, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBusqueda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.gbxPrincipal.Controls.Add(Me.LabelControl1)
        Me.gbxPrincipal.Controls.Add(Me.btnAbajo)
        Me.gbxPrincipal.Controls.Add(Me.btnArriba)
        Me.gbxPrincipal.Controls.Add(Me.ckeRedonAlaCentena)
        Me.gbxPrincipal.Controls.Add(Me.txtCodDian)
        Me.gbxPrincipal.Controls.Add(Me.btnAddClasifiacion)
        Me.gbxPrincipal.Controls.Add(Me.ckeEsRetencion)
        Me.gbxPrincipal.Controls.Add(Me.ckeRedonAlPeso)
        Me.gbxPrincipal.Controls.Add(Me.lblRedondear)
        Me.gbxPrincipal.Controls.Add(Me.ckeRedonAlaDecena)
        Me.gbxPrincipal.Controls.Add(Me.txtBaseCalculo)
        Me.gbxPrincipal.Controls.Add(Me.ckeRedonAlMil)
        Me.gbxPrincipal.Controls.Add(Me.lblMsg)
        Me.gbxPrincipal.Controls.Add(Me.txtClasificacion)
        Me.gbxPrincipal.Controls.Add(Me.ckeEsFondo)
        Me.gbxPrincipal.Controls.Add(Me.txtTipoFondo)
        Me.gbxPrincipal.Controls.Add(Me.SeparatorControl1)
        Me.gbxPrincipal.Controls.Add(Me.txtTipo)
        Me.gbxPrincipal.Controls.Add(Me.lblVigente)
        Me.gbxPrincipal.Controls.Add(Me.grbVigente)
        Me.gbxPrincipal.Controls.Add(Me.gcConceptos)
        Me.gbxPrincipal.Controls.Add(Me.gcVariables)
        Me.gbxPrincipal.Controls.Add(Me.txtBusqueda)
        Me.gbxPrincipal.Controls.Add(Me.txtNombre)
        Me.gbxPrincipal.Location = New System.Drawing.Point(7, 7)
        Me.gbxPrincipal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbxPrincipal.Name = "gbxPrincipal"
        Me.gbxPrincipal.Size = New System.Drawing.Size(1023, 736)
        Me.gbxPrincipal.TabIndex = 0
        Me.gbxPrincipal.TabStop = True
        Me.gbxPrincipal.Text = "Datos del Concepto"
        '
        'LabelControl1
        '
        Me.LabelControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseTextOptions = True
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Location = New System.Drawing.Point(964, 384)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Padding = New System.Windows.Forms.Padding(2)
        Me.LabelControl1.Size = New System.Drawing.Size(56, 32)
        Me.LabelControl1.TabIndex = 126
        Me.LabelControl1.Text = "Orden :"
        '
        'btnAbajo
        '
        Me.btnAbajo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAbajo.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnAbajo.Appearance.Options.UseFont = True
        Me.btnAbajo.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnAbajo.Location = New System.Drawing.Point(979, 468)
        Me.btnAbajo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAbajo.Name = "btnAbajo"
        Me.btnAbajo.Size = New System.Drawing.Size(30, 37)
        Me.btnAbajo.TabIndex = 125
        '
        'btnArriba
        '
        Me.btnArriba.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnArriba.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnArriba.Appearance.Options.UseFont = True
        Me.btnArriba.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnArriba.Location = New System.Drawing.Point(979, 423)
        Me.btnArriba.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnArriba.Name = "btnArriba"
        Me.btnArriba.Size = New System.Drawing.Size(30, 37)
        Me.btnArriba.TabIndex = 124
        '
        'ckeRedonAlaCentena
        '
        Me.ckeRedonAlaCentena.Location = New System.Drawing.Point(359, 107)
        Me.ckeRedonAlaCentena.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ckeRedonAlaCentena.Name = "ckeRedonAlaCentena"
        Me.ckeRedonAlaCentena.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckeRedonAlaCentena.Properties.Appearance.Options.UseFont = True
        Me.ckeRedonAlaCentena.Properties.Caption = "A la Centena"
        Me.ckeRedonAlaCentena.Size = New System.Drawing.Size(111, 24)
        Me.ckeRedonAlaCentena.TabIndex = 7
        '
        'txtCodDian
        '
        Me.txtCodDian.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtCodDian.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtCodDian.AltodelControl = 30
        Me.txtCodDian.AnchoLabel = 120
        Me.txtCodDian.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCodDian.AnchoTxt = 80
        Me.txtCodDian.AutoCargarDatos = True
        Me.txtCodDian.AutoSize = True
        Me.txtCodDian.BackColor = System.Drawing.Color.Transparent
        Me.txtCodDian.ColorFondo = System.Drawing.Color.Transparent
        Me.txtCodDian.CondicionValida = ""
        Me.txtCodDian.Conexion = SamitCtlNet.ConexionSAMIT.ConexModulo
        Me.txtCodDian.ConsultaSQL = Nothing
        Me.txtCodDian.DatosDefecto = Nothing
        Me.txtCodDian.EsObligatorio = False
        Me.txtCodDian.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtCodDian.FormatoNumero = Nothing
        Me.txtCodDian.ListaColumnas = Nothing
        Me.txtCodDian.Location = New System.Drawing.Point(218, 246)
        Me.txtCodDian.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtCodDian.MaximoAncho = 0
        Me.txtCodDian.MensajedeAyuda = ""
        Me.txtCodDian.Name = "txtCodDian"
        Me.txtCodDian.Size = New System.Drawing.Size(802, 37)
        Me.txtCodDian.SoloLectura = False
        Me.txtCodDian.SoloNumeros = True
        Me.txtCodDian.TabIndex = 13
        Me.txtCodDian.TextodelControl = ""
        Me.txtCodDian.TextoLabel = "Codigo Dian :"
        Me.txtCodDian.TieneErrorControl = False
        Me.txtCodDian.TipoBusqueda = SamitCtlNet.ModGeneral.TipoBusqueda.Ninguna
        Me.txtCodDian.TipodeDatos = SamitCtlNet.TipodeDato.Cadena
        Me.txtCodDian.TipodeLetra = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtCodDian.ValordelControl = ""
        Me.txtCodDian.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCodDian.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCodDian.ValorPredeterminado = Nothing
        '
        'btnAddClasifiacion
        '
        Me.btnAddClasifiacion.AllowFocus = False
        Me.btnAddClasifiacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddClasifiacion.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnAddClasifiacion.Appearance.Options.UseFont = True
        Me.btnAddClasifiacion.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnAddClasifiacion.Location = New System.Drawing.Point(979, 176)
        Me.btnAddClasifiacion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAddClasifiacion.Name = "btnAddClasifiacion"
        Me.btnAddClasifiacion.Size = New System.Drawing.Size(40, 31)
        Me.btnAddClasifiacion.TabIndex = 104
        Me.btnAddClasifiacion.TabStop = False
        '
        'ckeEsRetencion
        '
        Me.ckeEsRetencion.Location = New System.Drawing.Point(30, 249)
        Me.ckeEsRetencion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ckeEsRetencion.Name = "ckeEsRetencion"
        Me.ckeEsRetencion.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ckeEsRetencion.Properties.Appearance.Options.UseFont = True
        Me.ckeEsRetencion.Properties.Caption = "  :  Es Retencion "
        Me.ckeEsRetencion.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ckeEsRetencion.Size = New System.Drawing.Size(166, 24)
        Me.ckeEsRetencion.TabIndex = 13
        '
        'ckeRedonAlPeso
        '
        Me.ckeRedonAlPeso.Location = New System.Drawing.Point(170, 107)
        Me.ckeRedonAlPeso.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ckeRedonAlPeso.Name = "ckeRedonAlPeso"
        Me.ckeRedonAlPeso.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckeRedonAlPeso.Properties.Appearance.Options.UseFont = True
        Me.ckeRedonAlPeso.Properties.Caption = "Al Peso"
        Me.ckeRedonAlPeso.Size = New System.Drawing.Size(73, 24)
        Me.ckeRedonAlPeso.TabIndex = 5
        '
        'lblRedondear
        '
        Me.lblRedondear.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lblRedondear.Appearance.Options.UseFont = True
        Me.lblRedondear.Appearance.Options.UseTextOptions = True
        Me.lblRedondear.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblRedondear.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblRedondear.Location = New System.Drawing.Point(3, 101)
        Me.lblRedondear.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblRedondear.Name = "lblRedondear"
        Me.lblRedondear.Padding = New System.Windows.Forms.Padding(2)
        Me.lblRedondear.Size = New System.Drawing.Size(160, 32)
        Me.lblRedondear.TabIndex = 4
        Me.lblRedondear.Text = "Redondear :"
        '
        'ckeRedonAlaDecena
        '
        Me.ckeRedonAlaDecena.Location = New System.Drawing.Point(251, 107)
        Me.ckeRedonAlaDecena.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ckeRedonAlaDecena.Name = "ckeRedonAlaDecena"
        Me.ckeRedonAlaDecena.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckeRedonAlaDecena.Properties.Appearance.Options.UseFont = True
        Me.ckeRedonAlaDecena.Properties.Caption = "A la Decena"
        Me.ckeRedonAlaDecena.Size = New System.Drawing.Size(99, 24)
        Me.ckeRedonAlaDecena.TabIndex = 6
        '
        'txtBaseCalculo
        '
        Me.txtBaseCalculo.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtBaseCalculo.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtBaseCalculo.AltodelControl = 30
        Me.txtBaseCalculo.AnchoLabel = 140
        Me.txtBaseCalculo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBaseCalculo.AnchoTxt = 80
        Me.txtBaseCalculo.AutoCargarDatos = True
        Me.txtBaseCalculo.AutoSize = True
        Me.txtBaseCalculo.BackColor = System.Drawing.Color.Transparent
        Me.txtBaseCalculo.ColorFondo = System.Drawing.Color.Transparent
        Me.txtBaseCalculo.CondicionValida = ""
        Me.txtBaseCalculo.Conexion = SamitCtlNet.ConexionSAMIT.ConexModulo
        Me.txtBaseCalculo.ConsultaSQL = Nothing
        Me.txtBaseCalculo.DatosDefecto = Nothing
        Me.txtBaseCalculo.EsObligatorio = False
        Me.txtBaseCalculo.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.txtBaseCalculo.FormatoNumero = Nothing
        Me.txtBaseCalculo.ListaColumnas = Nothing
        Me.txtBaseCalculo.Location = New System.Drawing.Point(3, 68)
        Me.txtBaseCalculo.Margin = New System.Windows.Forms.Padding(5)
        Me.txtBaseCalculo.MaximoAncho = 0
        Me.txtBaseCalculo.MensajedeAyuda = ""
        Me.txtBaseCalculo.Name = "txtBaseCalculo"
        Me.txtBaseCalculo.Size = New System.Drawing.Size(1014, 37)
        Me.txtBaseCalculo.SoloLectura = False
        Me.txtBaseCalculo.SoloNumeros = True
        Me.txtBaseCalculo.TabIndex = 3
        Me.txtBaseCalculo.TextodelControl = ""
        Me.txtBaseCalculo.TextoLabel = "Base Calculo :"
        Me.txtBaseCalculo.TieneErrorControl = False
        Me.txtBaseCalculo.TipoBusqueda = SamitCtlNet.ModGeneral.TipoBusqueda.Ninguna
        Me.txtBaseCalculo.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtBaseCalculo.TipodeLetra = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtBaseCalculo.ValordelControl = ""
        Me.txtBaseCalculo.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtBaseCalculo.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtBaseCalculo.ValorPredeterminado = Nothing
        '
        'ckeRedonAlMil
        '
        Me.ckeRedonAlMil.Location = New System.Drawing.Point(477, 107)
        Me.ckeRedonAlMil.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ckeRedonAlMil.Name = "ckeRedonAlMil"
        Me.ckeRedonAlMil.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckeRedonAlMil.Properties.Appearance.Options.UseFont = True
        Me.ckeRedonAlMil.Properties.Caption = "Al Mil"
        Me.ckeRedonAlMil.Size = New System.Drawing.Size(62, 24)
        Me.ckeRedonAlMil.TabIndex = 8
        '
        'lblMsg
        '
        Me.lblMsg.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMsg.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsg.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.lblMsg.Appearance.Options.UseFont = True
        Me.lblMsg.Appearance.Options.UseForeColor = True
        Me.lblMsg.Appearance.Options.UseTextOptions = True
        Me.lblMsg.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblMsg.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblMsg.Location = New System.Drawing.Point(371, 320)
        Me.lblMsg.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Padding = New System.Windows.Forms.Padding(2)
        Me.lblMsg.Size = New System.Drawing.Size(642, 23)
        Me.lblMsg.TabIndex = 103
        Me.lblMsg.Text = "El concepto se encuentra asociado a un borrador y no es posible cambiar el estado" &
    ""
        '
        'txtClasificacion
        '
        Me.txtClasificacion.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtClasificacion.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtClasificacion.AltodelControl = 30
        Me.txtClasificacion.AnchoLabel = 140
        Me.txtClasificacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtClasificacion.AnchoTxt = 80
        Me.txtClasificacion.AutoCargarDatos = True
        Me.txtClasificacion.AutoSize = True
        Me.txtClasificacion.BackColor = System.Drawing.Color.Transparent
        Me.txtClasificacion.ColorFondo = System.Drawing.Color.Transparent
        Me.txtClasificacion.CondicionValida = ""
        Me.txtClasificacion.Conexion = SamitCtlNet.ConexionSAMIT.ConexModulo
        Me.txtClasificacion.ConsultaSQL = Nothing
        Me.txtClasificacion.DatosDefecto = Nothing
        Me.txtClasificacion.EsObligatorio = False
        Me.txtClasificacion.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.txtClasificacion.FormatoNumero = Nothing
        Me.txtClasificacion.ListaColumnas = Nothing
        Me.txtClasificacion.Location = New System.Drawing.Point(3, 174)
        Me.txtClasificacion.Margin = New System.Windows.Forms.Padding(5)
        Me.txtClasificacion.MaximoAncho = 0
        Me.txtClasificacion.MensajedeAyuda = ""
        Me.txtClasificacion.Name = "txtClasificacion"
        Me.txtClasificacion.Size = New System.Drawing.Size(974, 37)
        Me.txtClasificacion.SoloLectura = False
        Me.txtClasificacion.SoloNumeros = True
        Me.txtClasificacion.TabIndex = 10
        Me.txtClasificacion.TextodelControl = ""
        Me.txtClasificacion.TextoLabel = "Clasificación :"
        Me.txtClasificacion.TieneErrorControl = False
        Me.txtClasificacion.TipoBusqueda = SamitCtlNet.ModGeneral.TipoBusqueda.Ninguna
        Me.txtClasificacion.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtClasificacion.TipodeLetra = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtClasificacion.ValordelControl = ""
        Me.txtClasificacion.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtClasificacion.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtClasificacion.ValorPredeterminado = Nothing
        '
        'ckeEsFondo
        '
        Me.ckeEsFondo.Location = New System.Drawing.Point(29, 214)
        Me.ckeEsFondo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ckeEsFondo.Name = "ckeEsFondo"
        Me.ckeEsFondo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ckeEsFondo.Properties.Appearance.Options.UseFont = True
        Me.ckeEsFondo.Properties.Caption = "  :  Es Fondo "
        Me.ckeEsFondo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ckeEsFondo.Size = New System.Drawing.Size(166, 24)
        Me.ckeEsFondo.TabIndex = 11
        '
        'txtTipoFondo
        '
        Me.txtTipoFondo.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtTipoFondo.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtTipoFondo.AltodelControl = 30
        Me.txtTipoFondo.AnchoLabel = 95
        Me.txtTipoFondo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTipoFondo.AnchoTxt = 80
        Me.txtTipoFondo.AutoCargarDatos = True
        Me.txtTipoFondo.AutoSize = True
        Me.txtTipoFondo.BackColor = System.Drawing.Color.Transparent
        Me.txtTipoFondo.ColorFondo = System.Drawing.Color.Transparent
        Me.txtTipoFondo.CondicionValida = ""
        Me.txtTipoFondo.Conexion = SamitCtlNet.ConexionSAMIT.ConexModulo
        Me.txtTipoFondo.ConsultaSQL = Nothing
        Me.txtTipoFondo.DatosDefecto = Nothing
        Me.txtTipoFondo.EsObligatorio = False
        Me.txtTipoFondo.FormatoNumero = Nothing
        Me.txtTipoFondo.ListaColumnas = Nothing
        Me.txtTipoFondo.Location = New System.Drawing.Point(228, 212)
        Me.txtTipoFondo.Margin = New System.Windows.Forms.Padding(5)
        Me.txtTipoFondo.MaximoAncho = 0
        Me.txtTipoFondo.MensajedeAyuda = ""
        Me.txtTipoFondo.Name = "txtTipoFondo"
        Me.txtTipoFondo.Size = New System.Drawing.Size(791, 37)
        Me.txtTipoFondo.SoloLectura = False
        Me.txtTipoFondo.SoloNumeros = True
        Me.txtTipoFondo.TabIndex = 12
        Me.txtTipoFondo.TextodelControl = ""
        Me.txtTipoFondo.TextoLabel = "Tipo Fondo :"
        Me.txtTipoFondo.TieneErrorControl = False
        Me.txtTipoFondo.TipoBusqueda = SamitCtlNet.ModGeneral.TipoBusqueda.Ninguna
        Me.txtTipoFondo.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtTipoFondo.TipodeLetra = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtTipoFondo.ValordelControl = ""
        Me.txtTipoFondo.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTipoFondo.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTipoFondo.ValorPredeterminado = Nothing
        '
        'SeparatorControl1
        '
        Me.SeparatorControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SeparatorControl1.Location = New System.Drawing.Point(2, 345)
        Me.SeparatorControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SeparatorControl1.Name = "SeparatorControl1"
        Me.SeparatorControl1.Padding = New System.Windows.Forms.Padding(0)
        Me.SeparatorControl1.Size = New System.Drawing.Size(1020, 4)
        Me.SeparatorControl1.TabIndex = 102
        '
        'txtTipo
        '
        Me.txtTipo.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtTipo.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtTipo.AltodelControl = 30
        Me.txtTipo.AnchoLabel = 140
        Me.txtTipo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTipo.AnchoTxt = 80
        Me.txtTipo.AutoCargarDatos = True
        Me.txtTipo.AutoSize = True
        Me.txtTipo.BackColor = System.Drawing.Color.Transparent
        Me.txtTipo.ColorFondo = System.Drawing.Color.Transparent
        Me.txtTipo.CondicionValida = ""
        Me.txtTipo.Conexion = SamitCtlNet.ConexionSAMIT.ConexModulo
        Me.txtTipo.ConsultaSQL = Nothing
        Me.txtTipo.DatosDefecto = Nothing
        Me.txtTipo.EsObligatorio = False
        Me.txtTipo.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtTipo.FormatoNumero = Nothing
        Me.txtTipo.ListaColumnas = Nothing
        Me.txtTipo.Location = New System.Drawing.Point(3, 137)
        Me.txtTipo.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtTipo.MaximoAncho = 0
        Me.txtTipo.MensajedeAyuda = ""
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Size = New System.Drawing.Size(1014, 37)
        Me.txtTipo.SoloLectura = False
        Me.txtTipo.SoloNumeros = True
        Me.txtTipo.TabIndex = 9
        Me.txtTipo.TextodelControl = ""
        Me.txtTipo.TextoLabel = "Tipo Concepto :"
        Me.txtTipo.TieneErrorControl = False
        Me.txtTipo.TipoBusqueda = SamitCtlNet.ModGeneral.TipoBusqueda.Ninguna
        Me.txtTipo.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtTipo.TipodeLetra = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtTipo.ValordelControl = ""
        Me.txtTipo.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTipo.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTipo.ValorPredeterminado = Nothing
        '
        'lblVigente
        '
        Me.lblVigente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblVigente.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lblVigente.Appearance.Options.UseFont = True
        Me.lblVigente.Appearance.Options.UseTextOptions = True
        Me.lblVigente.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblVigente.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblVigente.Location = New System.Drawing.Point(784, 290)
        Me.lblVigente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblVigente.Name = "lblVigente"
        Me.lblVigente.Padding = New System.Windows.Forms.Padding(2)
        Me.lblVigente.Size = New System.Drawing.Size(119, 32)
        Me.lblVigente.TabIndex = 13
        Me.lblVigente.Text = "Vigente :"
        '
        'grbVigente
        '
        Me.grbVigente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grbVigente.Location = New System.Drawing.Point(904, 293)
        Me.grbVigente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grbVigente.Name = "grbVigente"
        Me.grbVigente.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.grbVigente.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.grbVigente.Properties.Appearance.Options.UseBackColor = True
        Me.grbVigente.Properties.Appearance.Options.UseFont = True
        Me.grbVigente.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.grbVigente.Properties.Columns = 2
        Me.grbVigente.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.grbVigente.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "NO"), New DevExpress.XtraEditors.Controls.RadioGroupItem(True, "SI")})
        Me.grbVigente.Size = New System.Drawing.Size(112, 25)
        Me.grbVigente.TabIndex = 16
        '
        'gcConceptos
        '
        Me.gcConceptos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcConceptos.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gcConceptos.Location = New System.Drawing.Point(2, 384)
        Me.gcConceptos.MainView = Me.gvConceptos
        Me.gcConceptos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gcConceptos.Name = "gcConceptos"
        Me.gcConceptos.Size = New System.Drawing.Size(958, 352)
        Me.gcConceptos.TabIndex = 15
        Me.gcConceptos.TabStop = False
        Me.gcConceptos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvConceptos})
        '
        'gvConceptos
        '
        Me.gvConceptos.DetailHeight = 431
        Me.gvConceptos.GridControl = Me.gcConceptos
        Me.gvConceptos.Name = "gvConceptos"
        '
        'gcVariables
        '
        Me.gcVariables.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcVariables.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gcVariables.Location = New System.Drawing.Point(15, 393)
        Me.gcVariables.MainView = Me.gvVariables
        Me.gcVariables.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gcVariables.Name = "gcVariables"
        Me.gcVariables.Size = New System.Drawing.Size(945, 300)
        Me.gcVariables.TabIndex = 0
        Me.gcVariables.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvVariables})
        Me.gcVariables.Visible = False
        '
        'gvVariables
        '
        Me.gvVariables.DetailHeight = 431
        Me.gvVariables.GridControl = Me.gcVariables
        Me.gvVariables.Name = "gvVariables"
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBusqueda.Location = New System.Drawing.Point(3, 351)
        Me.txtBusqueda.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.txtBusqueda.Properties.Appearance.Options.UseFont = True
        Me.txtBusqueda.Size = New System.Drawing.Size(1016, 28)
        Me.txtBusqueda.TabIndex = 91
        Me.txtBusqueda.TabStop = False
        '
        'txtNombre
        '
        Me.txtNombre.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtNombre.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtNombre.AltodelControl = 30
        Me.txtNombre.AnchoLabel = 140
        Me.txtNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombre.AutoSize = True
        Me.txtNombre.BackColor = System.Drawing.Color.Transparent
        Me.txtNombre.ColordeFondo = System.Drawing.Color.Transparent
        Me.txtNombre.EsObligatorio = False
        Me.txtNombre.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.FormatoNumero = Nothing
        Me.txtNombre.Location = New System.Drawing.Point(2, 32)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtNombre.MaximoAncho = 0
        Me.txtNombre.MensajedeAyuda = ""
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(1016, 37)
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
        'btnLimpiar
        '
        Me.btnLimpiar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnLimpiar.Appearance.Options.UseFont = True
        Me.btnLimpiar.Location = New System.Drawing.Point(8, 74)
        Me.btnLimpiar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(86, 37)
        Me.btnLimpiar.TabIndex = 6
        Me.btnLimpiar.Text = "Limpiar"
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Location = New System.Drawing.Point(8, 30)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(86, 37)
        Me.btnGuardar.TabIndex = 5
        Me.btnGuardar.Text = "Guardar"
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(8, 118)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(86, 37)
        Me.btnEliminar.TabIndex = 7
        Me.btnEliminar.Text = "Eliminar"
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(8, 162)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(86, 37)
        Me.btnSalir.TabIndex = 8
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
        Me.GroupControl1.Location = New System.Drawing.Point(1037, 7)
        Me.GroupControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(103, 736)
        Me.GroupControl1.TabIndex = 7
        Me.GroupControl1.Text = "Opciones"
        '
        'FrmAggConceptosNomina
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1149, 753)
        Me.Controls.Add(Me.gbxPrincipal)
        Me.Controls.Add(Me.GroupControl1)
        Me.IconOptions.Icon = CType(resources.GetObject("FrmAggConceptosNomina.IconOptions.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmAggConceptosNomina"
        Me.Text = "Conceptos de Nomina"
        CType(Me.gbxPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxPrincipal.ResumeLayout(False)
        Me.gbxPrincipal.PerformLayout()
        CType(Me.ckeRedonAlaCentena.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckeEsRetencion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckeRedonAlPeso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckeRedonAlaDecena.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckeRedonAlMil.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckeEsFondo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grbVigente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcConceptos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvConceptos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcVariables, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvVariables, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBusqueda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbxPrincipal As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grbVigente As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents gcConceptos As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvConceptos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gcVariables As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvVariables As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtBusqueda As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnLimpiar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtNombre As SamitCtlNet.SamitTexto
    Friend WithEvents txtTipo As SamitCtlNet.SamitBusq
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SeparatorControl1 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents lblVigente As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTipoFondo As SamitCtlNet.SamitBusq
    Friend WithEvents ckeRedonAlMil As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ckeRedonAlaDecena As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ckeRedonAlPeso As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lblRedondear As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ckeEsFondo As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtClasificacion As SamitCtlNet.SamitBusq
    Friend WithEvents lblMsg As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtBaseCalculo As SamitCtlNet.SamitBusq
    Friend WithEvents ckeEsRetencion As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents btnAddClasifiacion As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtCodDian As SamitCtlNet.SamitBusq
    Friend WithEvents ckeRedonAlaCentena As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents btnAbajo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnArriba As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
End Class
