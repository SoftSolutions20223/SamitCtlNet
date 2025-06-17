<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmContratosALiquidar
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
        Me.gcPrincipal = New DevExpress.XtraEditors.GroupControl()
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.SeparatorControl6 = New DevExpress.XtraEditors.SeparatorControl()
        Me.txtContratos = New SamitCtlNet.SamitBusq()
        Me.tplParametros = New System.Windows.Forms.TableLayoutPanel()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.txtDependencia = New SamitCtlNet.SamitBusq()
        Me.PanelControl5 = New DevExpress.XtraEditors.PanelControl()
        Me.txtTipoContrato = New SamitCtlNet.SamitBusq()
        Me.PanelControl9 = New DevExpress.XtraEditors.PanelControl()
        Me.txtCargos = New SamitCtlNet.SamitBusq()
        Me.tplDatosBasicos = New System.Windows.Forms.TableLayoutPanel()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.rgTipoLiquida = New DevExpress.XtraEditors.RadioGroup()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.lblFechaIniCc = New DevExpress.XtraEditors.LabelControl()
        Me.dteFecha = New DevExpress.XtraEditors.DateEdit()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.txtOficina = New SamitCtlNet.SamitBusq()
        CType(Me.gcPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gcPrincipal.SuspendLayout()
        CType(Me.SeparatorControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tplParametros.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl5.SuspendLayout()
        CType(Me.PanelControl9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl9.SuspendLayout()
        Me.tplDatosBasicos.SuspendLayout()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.rgTipoLiquida.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.dteFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        Me.SuspendLayout()
        '
        'gcPrincipal
        '
        Me.gcPrincipal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcPrincipal.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.gcPrincipal.AppearanceCaption.Options.UseFont = True
        Me.gcPrincipal.Controls.Add(Me.btnCancelar)
        Me.gcPrincipal.Controls.Add(Me.btnAceptar)
        Me.gcPrincipal.Controls.Add(Me.SeparatorControl6)
        Me.gcPrincipal.Controls.Add(Me.txtContratos)
        Me.gcPrincipal.Controls.Add(Me.tplParametros)
        Me.gcPrincipal.Controls.Add(Me.tplDatosBasicos)
        Me.gcPrincipal.Location = New System.Drawing.Point(5, 4)
        Me.gcPrincipal.Name = "gcPrincipal"
        Me.gcPrincipal.Size = New System.Drawing.Size(1115, 145)
        Me.gcPrincipal.TabIndex = 3
        Me.gcPrincipal.Text = "Parámetros"
        '
        'btnCancelar
        '
        Me.btnCancelar.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnCancelar.Appearance.Options.UseFont = True
        Me.btnCancelar.Location = New System.Drawing.Point(458, 109)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(90, 30)
        Me.btnCancelar.TabIndex = 102
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnAceptar
        '
        Me.btnAceptar.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnAceptar.Appearance.Options.UseFont = True
        Me.btnAceptar.Location = New System.Drawing.Point(563, 109)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(90, 30)
        Me.btnAceptar.TabIndex = 101
        Me.btnAceptar.Text = "Aceptar"
        '
        'SeparatorControl6
        '
        Me.SeparatorControl6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SeparatorControl6.Location = New System.Drawing.Point(7, 101)
        Me.SeparatorControl6.Name = "SeparatorControl6"
        Me.SeparatorControl6.Padding = New System.Windows.Forms.Padding(0)
        Me.SeparatorControl6.Size = New System.Drawing.Size(1100, 3)
        Me.SeparatorControl6.TabIndex = 103
        Me.SeparatorControl6.TabStop = False
        '
        'txtContratos
        '
        Me.txtContratos.AlineacionTexto = SamitCtlNet.AlinearTexto.Centro
        Me.txtContratos.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtContratos.AltodelControl = 30
        Me.txtContratos.AnchoLabel = 125
        Me.txtContratos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtContratos.AnchoTxt = 100
        Me.txtContratos.AutoCargarDatos = True
        Me.txtContratos.AutoSize = True
        Me.txtContratos.BackColor = System.Drawing.Color.Transparent
        Me.txtContratos.ColorFondo = System.Drawing.Color.Transparent
        Me.txtContratos.CondicionValida = ""
        Me.txtContratos.Conexion = SamitCtlNet.ConexionSAMIT.ConexModulo
        Me.txtContratos.ConsultaSQL = Nothing
        Me.txtContratos.EsObligatorio = False
        Me.txtContratos.FormatoNumero = Nothing
        Me.txtContratos.Location = New System.Drawing.Point(-17, 63)
        Me.txtContratos.MaximoAncho = 0
        Me.txtContratos.MensajedeAyuda = Nothing
        Me.txtContratos.Name = "txtContratos"
        Me.txtContratos.Size = New System.Drawing.Size(527, 30)
        Me.txtContratos.SoloLectura = False
        Me.txtContratos.SoloNumeros = True
        Me.txtContratos.TabIndex = 4
        Me.txtContratos.TextodelControl = ""
        Me.txtContratos.TextoLabel = "Contrato :"
        Me.txtContratos.TieneErrorControl = False
        Me.txtContratos.TipoBusqueda = SamitCtlNet.ModGeneral.TipoBusqueda.Ninguna
        Me.txtContratos.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtContratos.TipodeLetra = New System.Drawing.Font("Arial", 9.0!)
        Me.txtContratos.ValordelControl = ""
        Me.txtContratos.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtContratos.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtContratos.ValorPredeterminado = Nothing
        '
        'tplParametros
        '
        Me.tplParametros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tplParametros.BackColor = System.Drawing.Color.Transparent
        Me.tplParametros.ColumnCount = 3
        Me.tplParametros.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tplParametros.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tplParametros.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tplParametros.Controls.Add(Me.PanelControl1, 1, 0)
        Me.tplParametros.Controls.Add(Me.PanelControl5, 0, 0)
        Me.tplParametros.Controls.Add(Me.PanelControl9, 2, 0)
        Me.tplParametros.ForeColor = System.Drawing.Color.Transparent
        Me.tplParametros.Location = New System.Drawing.Point(2, 59)
        Me.tplParametros.Name = "tplParametros"
        Me.tplParametros.RowCount = 1
        Me.tplParametros.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tplParametros.Size = New System.Drawing.Size(1111, 38)
        Me.tplParametros.TabIndex = 3
        '
        'PanelControl1
        '
        Me.PanelControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.txtDependencia)
        Me.PanelControl1.Location = New System.Drawing.Point(373, 3)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(364, 32)
        Me.PanelControl1.TabIndex = 1
        '
        'txtDependencia
        '
        Me.txtDependencia.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtDependencia.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtDependencia.AltodelControl = 30
        Me.txtDependencia.AnchoLabel = 100
        Me.txtDependencia.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDependencia.AnchoTxt = 60
        Me.txtDependencia.AutoCargarDatos = True
        Me.txtDependencia.AutoSize = True
        Me.txtDependencia.BackColor = System.Drawing.Color.Transparent
        Me.txtDependencia.ColorFondo = System.Drawing.Color.Transparent
        Me.txtDependencia.CondicionValida = ""
        Me.txtDependencia.Conexion = SamitCtlNet.ConexionSAMIT.ConexModulo
        Me.txtDependencia.ConsultaSQL = Nothing
        Me.txtDependencia.EsObligatorio = False
        Me.txtDependencia.FormatoNumero = Nothing
        Me.txtDependencia.Location = New System.Drawing.Point(4, 1)
        Me.txtDependencia.MaximoAncho = 0
        Me.txtDependencia.MensajedeAyuda = Nothing
        Me.txtDependencia.Name = "txtDependencia"
        Me.txtDependencia.Size = New System.Drawing.Size(358, 30)
        Me.txtDependencia.SoloLectura = False
        Me.txtDependencia.SoloNumeros = True
        Me.txtDependencia.TabIndex = 1
        Me.txtDependencia.TextodelControl = ""
        Me.txtDependencia.TextoLabel = "Dependencia :"
        Me.txtDependencia.TieneErrorControl = False
        Me.txtDependencia.TipoBusqueda = SamitCtlNet.ModGeneral.TipoBusqueda.Ninguna
        Me.txtDependencia.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtDependencia.TipodeLetra = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDependencia.ValordelControl = ""
        Me.txtDependencia.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDependencia.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDependencia.ValorPredeterminado = Nothing
        '
        'PanelControl5
        '
        Me.PanelControl5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl5.Controls.Add(Me.txtTipoContrato)
        Me.PanelControl5.Location = New System.Drawing.Point(3, 3)
        Me.PanelControl5.Name = "PanelControl5"
        Me.PanelControl5.Size = New System.Drawing.Size(364, 32)
        Me.PanelControl5.TabIndex = 0
        '
        'txtTipoContrato
        '
        Me.txtTipoContrato.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtTipoContrato.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtTipoContrato.AltodelControl = 30
        Me.txtTipoContrato.AnchoLabel = 100
        Me.txtTipoContrato.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTipoContrato.AnchoTxt = 60
        Me.txtTipoContrato.AutoCargarDatos = True
        Me.txtTipoContrato.AutoSize = True
        Me.txtTipoContrato.BackColor = System.Drawing.Color.Transparent
        Me.txtTipoContrato.ColorFondo = System.Drawing.Color.Transparent
        Me.txtTipoContrato.CondicionValida = ""
        Me.txtTipoContrato.Conexion = SamitCtlNet.ConexionSAMIT.ConexModulo
        Me.txtTipoContrato.ConsultaSQL = Nothing
        Me.txtTipoContrato.EsObligatorio = False
        Me.txtTipoContrato.FormatoNumero = Nothing
        Me.txtTipoContrato.Location = New System.Drawing.Point(3, 1)
        Me.txtTipoContrato.MaximoAncho = 0
        Me.txtTipoContrato.MensajedeAyuda = Nothing
        Me.txtTipoContrato.Name = "txtTipoContrato"
        Me.txtTipoContrato.Size = New System.Drawing.Size(358, 30)
        Me.txtTipoContrato.SoloLectura = False
        Me.txtTipoContrato.SoloNumeros = True
        Me.txtTipoContrato.TabIndex = 1
        Me.txtTipoContrato.TextodelControl = ""
        Me.txtTipoContrato.TextoLabel = "Tipo Contrato :"
        Me.txtTipoContrato.TieneErrorControl = False
        Me.txtTipoContrato.TipoBusqueda = SamitCtlNet.ModGeneral.TipoBusqueda.Ninguna
        Me.txtTipoContrato.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtTipoContrato.TipodeLetra = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoContrato.ValordelControl = ""
        Me.txtTipoContrato.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTipoContrato.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTipoContrato.ValorPredeterminado = Nothing
        '
        'PanelControl9
        '
        Me.PanelControl9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl9.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl9.Controls.Add(Me.txtCargos)
        Me.PanelControl9.Location = New System.Drawing.Point(743, 3)
        Me.PanelControl9.Name = "PanelControl9"
        Me.PanelControl9.Size = New System.Drawing.Size(365, 32)
        Me.PanelControl9.TabIndex = 2
        '
        'txtCargos
        '
        Me.txtCargos.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtCargos.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtCargos.AltodelControl = 30
        Me.txtCargos.AnchoLabel = 100
        Me.txtCargos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCargos.AnchoTxt = 60
        Me.txtCargos.AutoCargarDatos = True
        Me.txtCargos.AutoSize = True
        Me.txtCargos.BackColor = System.Drawing.Color.Transparent
        Me.txtCargos.ColorFondo = System.Drawing.Color.Transparent
        Me.txtCargos.CondicionValida = ""
        Me.txtCargos.Conexion = SamitCtlNet.ConexionSAMIT.ConexModulo
        Me.txtCargos.ConsultaSQL = Nothing
        Me.txtCargos.EsObligatorio = False
        Me.txtCargos.FormatoNumero = Nothing
        Me.txtCargos.Location = New System.Drawing.Point(3, 1)
        Me.txtCargos.MaximoAncho = 0
        Me.txtCargos.MensajedeAyuda = Nothing
        Me.txtCargos.Name = "txtCargos"
        Me.txtCargos.Size = New System.Drawing.Size(359, 30)
        Me.txtCargos.SoloLectura = False
        Me.txtCargos.SoloNumeros = True
        Me.txtCargos.TabIndex = 1
        Me.txtCargos.TextodelControl = ""
        Me.txtCargos.TextoLabel = "Cargos :"
        Me.txtCargos.TieneErrorControl = False
        Me.txtCargos.TipoBusqueda = SamitCtlNet.ModGeneral.TipoBusqueda.Ninguna
        Me.txtCargos.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtCargos.TipodeLetra = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCargos.ValordelControl = ""
        Me.txtCargos.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCargos.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCargos.ValorPredeterminado = Nothing
        '
        'tplDatosBasicos
        '
        Me.tplDatosBasicos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tplDatosBasicos.BackColor = System.Drawing.Color.Transparent
        Me.tplDatosBasicos.ColumnCount = 3
        Me.tplDatosBasicos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tplDatosBasicos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tplDatosBasicos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tplDatosBasicos.Controls.Add(Me.PanelControl4, 2, 0)
        Me.tplDatosBasicos.Controls.Add(Me.PanelControl2, 0, 0)
        Me.tplDatosBasicos.Controls.Add(Me.PanelControl3, 1, 0)
        Me.tplDatosBasicos.ForeColor = System.Drawing.Color.Transparent
        Me.tplDatosBasicos.Location = New System.Drawing.Point(2, 23)
        Me.tplDatosBasicos.Name = "tplDatosBasicos"
        Me.tplDatosBasicos.RowCount = 1
        Me.tplDatosBasicos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tplDatosBasicos.Size = New System.Drawing.Size(1111, 38)
        Me.tplDatosBasicos.TabIndex = 1
        '
        'PanelControl4
        '
        Me.PanelControl4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl4.Controls.Add(Me.rgTipoLiquida)
        Me.PanelControl4.Location = New System.Drawing.Point(743, 3)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(365, 32)
        Me.PanelControl4.TabIndex = 3
        '
        'rgTipoLiquida
        '
        Me.rgTipoLiquida.Location = New System.Drawing.Point(5, 2)
        Me.rgTipoLiquida.Name = "rgTipoLiquida"
        Me.rgTipoLiquida.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.rgTipoLiquida.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.rgTipoLiquida.Properties.Appearance.Options.UseBackColor = True
        Me.rgTipoLiquida.Properties.Appearance.Options.UseFont = True
        Me.rgTipoLiquida.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.rgTipoLiquida.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Liquidar por tercero"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Liquidar por tip.contrato")})
        Me.rgTipoLiquida.Size = New System.Drawing.Size(344, 29)
        Me.rgTipoLiquida.TabIndex = 2
        '
        'PanelControl2
        '
        Me.PanelControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Controls.Add(Me.lblFechaIniCc)
        Me.PanelControl2.Controls.Add(Me.dteFecha)
        Me.PanelControl2.Location = New System.Drawing.Point(3, 3)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(364, 32)
        Me.PanelControl2.TabIndex = 1
        '
        'lblFechaIniCc
        '
        Me.lblFechaIniCc.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaIniCc.Appearance.Options.UseFont = True
        Me.lblFechaIniCc.Appearance.Options.UseTextOptions = True
        Me.lblFechaIniCc.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblFechaIniCc.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblFechaIniCc.Location = New System.Drawing.Point(-7, 3)
        Me.lblFechaIniCc.Name = "lblFechaIniCc"
        Me.lblFechaIniCc.Padding = New System.Windows.Forms.Padding(2)
        Me.lblFechaIniCc.Size = New System.Drawing.Size(106, 26)
        Me.lblFechaIniCc.TabIndex = 97
        Me.lblFechaIniCc.Text = "Fecha :"
        '
        'dteFecha
        '
        Me.dteFecha.EditValue = Nothing
        Me.dteFecha.Location = New System.Drawing.Point(106, 6)
        Me.dteFecha.Name = "dteFecha"
        Me.dteFecha.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.dteFecha.Properties.Appearance.Options.UseFont = True
        Me.dteFecha.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.dteFecha.Properties.AppearanceDropDown.Options.UseFont = True
        Me.dteFecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteFecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteFecha.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.dteFecha.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dteFecha.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.dteFecha.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dteFecha.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.dteFecha.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.dteFecha.Size = New System.Drawing.Size(131, 20)
        Me.dteFecha.TabIndex = 96
        '
        'PanelControl3
        '
        Me.PanelControl3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl3.Controls.Add(Me.txtOficina)
        Me.PanelControl3.Location = New System.Drawing.Point(373, 3)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(364, 32)
        Me.PanelControl3.TabIndex = 2
        '
        'txtOficina
        '
        Me.txtOficina.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtOficina.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtOficina.AltodelControl = 30
        Me.txtOficina.AnchoLabel = 100
        Me.txtOficina.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOficina.AnchoTxt = 50
        Me.txtOficina.AutoCargarDatos = True
        Me.txtOficina.AutoSize = True
        Me.txtOficina.BackColor = System.Drawing.Color.Transparent
        Me.txtOficina.ColorFondo = System.Drawing.Color.Transparent
        Me.txtOficina.CondicionValida = ""
        Me.txtOficina.Conexion = SamitCtlNet.ConexionSAMIT.ConexModulo
        Me.txtOficina.ConsultaSQL = Nothing
        Me.txtOficina.EsObligatorio = False
        Me.txtOficina.FormatoNumero = Nothing
        Me.txtOficina.Location = New System.Drawing.Point(3, 2)
        Me.txtOficina.MaximoAncho = 0
        Me.txtOficina.MensajedeAyuda = Nothing
        Me.txtOficina.Name = "txtOficina"
        Me.txtOficina.Size = New System.Drawing.Size(358, 30)
        Me.txtOficina.SoloLectura = False
        Me.txtOficina.SoloNumeros = True
        Me.txtOficina.TabIndex = 1
        Me.txtOficina.TextodelControl = ""
        Me.txtOficina.TextoLabel = "Oficina :"
        Me.txtOficina.TieneErrorControl = False
        Me.txtOficina.TipoBusqueda = SamitCtlNet.ModGeneral.TipoBusqueda.Ninguna
        Me.txtOficina.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtOficina.TipodeLetra = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOficina.ValordelControl = ""
        Me.txtOficina.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtOficina.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtOficina.ValorPredeterminado = Nothing
        '
        'FrmContratosALiquidar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1125, 152)
        Me.Controls.Add(Me.gcPrincipal)
        Me.Name = "FrmContratosALiquidar"
        Me.Text = "FrmContratosALiquidar"
        CType(Me.gcPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gcPrincipal.ResumeLayout(False)
        Me.gcPrincipal.PerformLayout()
        CType(Me.SeparatorControl6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tplParametros.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl5.ResumeLayout(False)
        Me.PanelControl5.PerformLayout()
        CType(Me.PanelControl9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl9.ResumeLayout(False)
        Me.PanelControl9.PerformLayout()
        Me.tplDatosBasicos.ResumeLayout(False)
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        CType(Me.rgTipoLiquida.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.dteFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.PanelControl3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gcPrincipal As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SeparatorControl6 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents txtContratos As SamitCtlNet.SamitBusq
    Friend WithEvents tplParametros As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtDependencia As SamitCtlNet.SamitBusq
    Friend WithEvents PanelControl5 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtTipoContrato As SamitCtlNet.SamitBusq
    Friend WithEvents PanelControl9 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtCargos As SamitCtlNet.SamitBusq
    Friend WithEvents tplDatosBasicos As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents rgTipoLiquida As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblFechaIniCc As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dteFecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtOficina As SamitCtlNet.SamitBusq
End Class
