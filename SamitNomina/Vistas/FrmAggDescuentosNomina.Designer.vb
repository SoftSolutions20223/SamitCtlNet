<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAggDescuentosNomina
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAggDescuentosNomina))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEliminar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnLimpiar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.gbxPrincipal = New DevExpress.XtraEditors.GroupControl()
        Me.btnListaCuotas = New DevExpress.XtraEditors.SimpleButton()
        Me.ckeLiqPeriodos = New DevExpress.XtraEditors.CheckEdit()
        Me.lblAplicaLiquidaciones = New DevExpress.XtraEditors.LabelControl()
        Me.ckeLiqSemestres = New DevExpress.XtraEditors.CheckEdit()
        Me.ckeLiqExtraordinarias = New DevExpress.XtraEditors.CheckEdit()
        Me.txtCuotaActual = New SamitCtlNet.SamitTexto()
        Me.txtCuotaFinal = New SamitCtlNet.SamitTexto()
        Me.txtCuotaInicial = New SamitCtlNet.SamitTexto()
        Me.txtNumCuotas = New SamitCtlNet.SamitTexto()
        Me.txtDocContable = New SamitCtlNet.SamitTexto()
        Me.txtCtaContable = New SamitCtlNet.SamitBusq()
        Me.lblVigente = New DevExpress.XtraEditors.LabelControl()
        Me.grbVigente = New DevExpress.XtraEditors.RadioGroup()
        Me.lblFechaFinCc = New DevExpress.XtraEditors.LabelControl()
        Me.dteFechaFinC = New DevExpress.XtraEditors.DateEdit()
        Me.lblFechaIniCc = New DevExpress.XtraEditors.LabelControl()
        Me.dteFechaIniC = New DevExpress.XtraEditors.DateEdit()
        Me.txtConcepto = New SamitCtlNet.SamitBusq()
        Me.txtTotalDescontado = New SamitCtlNet.SamitTexto()
        Me.txtDescuentoPeriodo = New SamitCtlNet.SamitTexto()
        Me.txtTotalDescontar = New SamitCtlNet.SamitTexto()
        Me.txtContrato = New SamitCtlNet.SamitBusq()
        Me.SeparatorControl6 = New DevExpress.XtraEditors.SeparatorControl()
        Me.gcDescuentos = New DevExpress.XtraGrid.GridControl()
        Me.gvDescuentos = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.gbxPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxPrincipal.SuspendLayout()
        CType(Me.ckeLiqPeriodos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckeLiqSemestres.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckeLiqExtraordinarias.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grbVigente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFechaFinC.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFechaFinC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFechaIniC.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFechaIniC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeparatorControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcDescuentos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvDescuentos, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GroupControl1.Controls.Add(Me.btnEliminar)
        Me.GroupControl1.Controls.Add(Me.btnLimpiar)
        Me.GroupControl1.Controls.Add(Me.btnGuardar)
        Me.GroupControl1.Location = New System.Drawing.Point(1125, 6)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(88, 624)
        Me.GroupControl1.TabIndex = 2
        Me.GroupControl1.Text = "Opciones"
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
        'gbxPrincipal
        '
        Me.gbxPrincipal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxPrincipal.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.gbxPrincipal.AppearanceCaption.Options.UseFont = True
        Me.gbxPrincipal.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.gbxPrincipal.CaptionImagePadding = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.gbxPrincipal.Controls.Add(Me.btnListaCuotas)
        Me.gbxPrincipal.Controls.Add(Me.ckeLiqPeriodos)
        Me.gbxPrincipal.Controls.Add(Me.lblAplicaLiquidaciones)
        Me.gbxPrincipal.Controls.Add(Me.ckeLiqSemestres)
        Me.gbxPrincipal.Controls.Add(Me.ckeLiqExtraordinarias)
        Me.gbxPrincipal.Controls.Add(Me.txtCuotaActual)
        Me.gbxPrincipal.Controls.Add(Me.txtCuotaFinal)
        Me.gbxPrincipal.Controls.Add(Me.txtCuotaInicial)
        Me.gbxPrincipal.Controls.Add(Me.txtNumCuotas)
        Me.gbxPrincipal.Controls.Add(Me.txtDocContable)
        Me.gbxPrincipal.Controls.Add(Me.txtCtaContable)
        Me.gbxPrincipal.Controls.Add(Me.lblVigente)
        Me.gbxPrincipal.Controls.Add(Me.grbVigente)
        Me.gbxPrincipal.Controls.Add(Me.lblFechaFinCc)
        Me.gbxPrincipal.Controls.Add(Me.dteFechaFinC)
        Me.gbxPrincipal.Controls.Add(Me.lblFechaIniCc)
        Me.gbxPrincipal.Controls.Add(Me.dteFechaIniC)
        Me.gbxPrincipal.Controls.Add(Me.txtConcepto)
        Me.gbxPrincipal.Controls.Add(Me.txtTotalDescontado)
        Me.gbxPrincipal.Controls.Add(Me.txtDescuentoPeriodo)
        Me.gbxPrincipal.Controls.Add(Me.txtTotalDescontar)
        Me.gbxPrincipal.Controls.Add(Me.txtContrato)
        Me.gbxPrincipal.Controls.Add(Me.SeparatorControl6)
        Me.gbxPrincipal.Controls.Add(Me.gcDescuentos)
        Me.gbxPrincipal.Location = New System.Drawing.Point(9, 6)
        Me.gbxPrincipal.Name = "gbxPrincipal"
        Me.gbxPrincipal.Size = New System.Drawing.Size(1109, 625)
        Me.gbxPrincipal.TabIndex = 1
        Me.gbxPrincipal.TabStop = True
        '
        'btnListaCuotas
        '
        Me.btnListaCuotas.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnListaCuotas.Appearance.Options.UseFont = True
        Me.btnListaCuotas.Location = New System.Drawing.Point(928, 115)
        Me.btnListaCuotas.Name = "btnListaCuotas"
        Me.btnListaCuotas.Size = New System.Drawing.Size(93, 30)
        Me.btnListaCuotas.TabIndex = 112
        Me.btnListaCuotas.Text = "Lista Cuotas"
        '
        'ckeLiqPeriodos
        '
        Me.ckeLiqPeriodos.Location = New System.Drawing.Point(159, 239)
        Me.ckeLiqPeriodos.Name = "ckeLiqPeriodos"
        Me.ckeLiqPeriodos.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckeLiqPeriodos.Properties.Appearance.Options.UseFont = True
        Me.ckeLiqPeriodos.Properties.Caption = "Liquidacion de Periodos"
        Me.ckeLiqPeriodos.Size = New System.Drawing.Size(174, 19)
        Me.ckeLiqPeriodos.TabIndex = 12
        '
        'lblAplicaLiquidaciones
        '
        Me.lblAplicaLiquidaciones.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lblAplicaLiquidaciones.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblAplicaLiquidaciones.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblAplicaLiquidaciones.Location = New System.Drawing.Point(20, 234)
        Me.lblAplicaLiquidaciones.Name = "lblAplicaLiquidaciones"
        Me.lblAplicaLiquidaciones.Padding = New System.Windows.Forms.Padding(2)
        Me.lblAplicaLiquidaciones.Size = New System.Drawing.Size(137, 26)
        Me.lblAplicaLiquidaciones.TabIndex = 111
        Me.lblAplicaLiquidaciones.Text = "Aplica Para : "
        '
        'ckeLiqSemestres
        '
        Me.ckeLiqSemestres.Location = New System.Drawing.Point(340, 239)
        Me.ckeLiqSemestres.Name = "ckeLiqSemestres"
        Me.ckeLiqSemestres.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckeLiqSemestres.Properties.Appearance.Options.UseFont = True
        Me.ckeLiqSemestres.Properties.Caption = "Liquidacion de Semestres"
        Me.ckeLiqSemestres.Size = New System.Drawing.Size(184, 19)
        Me.ckeLiqSemestres.TabIndex = 13
        '
        'ckeLiqExtraordinarias
        '
        Me.ckeLiqExtraordinarias.Location = New System.Drawing.Point(532, 239)
        Me.ckeLiqExtraordinarias.Name = "ckeLiqExtraordinarias"
        Me.ckeLiqExtraordinarias.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckeLiqExtraordinarias.Properties.Appearance.Options.UseFont = True
        Me.ckeLiqExtraordinarias.Properties.Caption = "Liquidaciones Extraordinarias"
        Me.ckeLiqExtraordinarias.Size = New System.Drawing.Size(198, 19)
        Me.ckeLiqExtraordinarias.TabIndex = 14
        '
        'txtCuotaActual
        '
        Me.txtCuotaActual.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtCuotaActual.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtCuotaActual.AltodelControl = 30
        Me.txtCuotaActual.AnchoLabel = 100
        Me.txtCuotaActual.AutoSize = True
        Me.txtCuotaActual.BackColor = System.Drawing.Color.Transparent
        Me.txtCuotaActual.ColordeFondo = System.Drawing.Color.Transparent
        Me.txtCuotaActual.EsObligatorio = False
        Me.txtCuotaActual.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuotaActual.FormatoNumero = Nothing
        Me.txtCuotaActual.Location = New System.Drawing.Point(706, 116)
        Me.txtCuotaActual.MaximoAncho = 0
        Me.txtCuotaActual.MensajedeAyuda = "Asignación. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
        Me.txtCuotaActual.Name = "txtCuotaActual"
        Me.txtCuotaActual.Size = New System.Drawing.Size(216, 30)
        Me.txtCuotaActual.SoloLectura = False
        Me.txtCuotaActual.SoloNumeros = False
        Me.txtCuotaActual.TabIndex = 7
        Me.txtCuotaActual.TextodelControl = ""
        Me.txtCuotaActual.TextoLabel = "Cuota Actual :"
        Me.txtCuotaActual.TieneErrorControl = False
        Me.txtCuotaActual.TipodeDatos = SamitCtlNet.TipodeDato.Numeros
        Me.txtCuotaActual.TipodeLetra = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuotaActual.ValordelControl = Nothing
        Me.txtCuotaActual.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCuotaActual.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCuotaActual.ValorPredeterminado = Nothing
        '
        'txtCuotaFinal
        '
        Me.txtCuotaFinal.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtCuotaFinal.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtCuotaFinal.AltodelControl = 30
        Me.txtCuotaFinal.AnchoLabel = 100
        Me.txtCuotaFinal.AutoSize = True
        Me.txtCuotaFinal.BackColor = System.Drawing.Color.Transparent
        Me.txtCuotaFinal.ColordeFondo = System.Drawing.Color.Transparent
        Me.txtCuotaFinal.EsObligatorio = False
        Me.txtCuotaFinal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuotaFinal.FormatoNumero = Nothing
        Me.txtCuotaFinal.Location = New System.Drawing.Point(484, 116)
        Me.txtCuotaFinal.MaximoAncho = 0
        Me.txtCuotaFinal.MensajedeAyuda = "Asignación. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
        Me.txtCuotaFinal.Name = "txtCuotaFinal"
        Me.txtCuotaFinal.Size = New System.Drawing.Size(216, 30)
        Me.txtCuotaFinal.SoloLectura = False
        Me.txtCuotaFinal.SoloNumeros = False
        Me.txtCuotaFinal.TabIndex = 6
        Me.txtCuotaFinal.TextodelControl = ""
        Me.txtCuotaFinal.TextoLabel = "Cuota Final :"
        Me.txtCuotaFinal.TieneErrorControl = False
        Me.txtCuotaFinal.TipodeDatos = SamitCtlNet.TipodeDato.Numeros
        Me.txtCuotaFinal.TipodeLetra = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuotaFinal.ValordelControl = Nothing
        Me.txtCuotaFinal.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCuotaFinal.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCuotaFinal.ValorPredeterminado = Nothing
        '
        'txtCuotaInicial
        '
        Me.txtCuotaInicial.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtCuotaInicial.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtCuotaInicial.AltodelControl = 30
        Me.txtCuotaInicial.AnchoLabel = 100
        Me.txtCuotaInicial.AutoSize = True
        Me.txtCuotaInicial.BackColor = System.Drawing.Color.Transparent
        Me.txtCuotaInicial.ColordeFondo = System.Drawing.Color.Transparent
        Me.txtCuotaInicial.EsObligatorio = False
        Me.txtCuotaInicial.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuotaInicial.FormatoNumero = Nothing
        Me.txtCuotaInicial.Location = New System.Drawing.Point(265, 116)
        Me.txtCuotaInicial.MaximoAncho = 0
        Me.txtCuotaInicial.MensajedeAyuda = "Asignación. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
        Me.txtCuotaInicial.Name = "txtCuotaInicial"
        Me.txtCuotaInicial.Size = New System.Drawing.Size(213, 30)
        Me.txtCuotaInicial.SoloLectura = False
        Me.txtCuotaInicial.SoloNumeros = False
        Me.txtCuotaInicial.TabIndex = 5
        Me.txtCuotaInicial.TextodelControl = ""
        Me.txtCuotaInicial.TextoLabel = "Cuota Inicial :"
        Me.txtCuotaInicial.TieneErrorControl = False
        Me.txtCuotaInicial.TipodeDatos = SamitCtlNet.TipodeDato.Numeros
        Me.txtCuotaInicial.TipodeLetra = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuotaInicial.ValordelControl = Nothing
        Me.txtCuotaInicial.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCuotaInicial.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCuotaInicial.ValorPredeterminado = Nothing
        '
        'txtNumCuotas
        '
        Me.txtNumCuotas.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtNumCuotas.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtNumCuotas.AltodelControl = 30
        Me.txtNumCuotas.AnchoLabel = 110
        Me.txtNumCuotas.AutoSize = True
        Me.txtNumCuotas.BackColor = System.Drawing.Color.Transparent
        Me.txtNumCuotas.ColordeFondo = System.Drawing.Color.Transparent
        Me.txtNumCuotas.EsObligatorio = False
        Me.txtNumCuotas.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumCuotas.FormatoNumero = Nothing
        Me.txtNumCuotas.Location = New System.Drawing.Point(45, 116)
        Me.txtNumCuotas.MaximoAncho = 0
        Me.txtNumCuotas.MensajedeAyuda = "Asignación. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
        Me.txtNumCuotas.Name = "txtNumCuotas"
        Me.txtNumCuotas.Size = New System.Drawing.Size(214, 30)
        Me.txtNumCuotas.SoloLectura = False
        Me.txtNumCuotas.SoloNumeros = False
        Me.txtNumCuotas.TabIndex = 4
        Me.txtNumCuotas.TextodelControl = ""
        Me.txtNumCuotas.TextoLabel = "Numero Cuotas :"
        Me.txtNumCuotas.TieneErrorControl = False
        Me.txtNumCuotas.TipodeDatos = SamitCtlNet.TipodeDato.Numeros
        Me.txtNumCuotas.TipodeLetra = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumCuotas.ValordelControl = Nothing
        Me.txtNumCuotas.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumCuotas.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumCuotas.ValorPredeterminado = Nothing
        '
        'txtDocContable
        '
        Me.txtDocContable.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtDocContable.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtDocContable.AltodelControl = 30
        Me.txtDocContable.AnchoLabel = 110
        Me.txtDocContable.AutoSize = True
        Me.txtDocContable.BackColor = System.Drawing.Color.Transparent
        Me.txtDocContable.ColordeFondo = System.Drawing.Color.Transparent
        Me.txtDocContable.EsObligatorio = False
        Me.txtDocContable.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocContable.FormatoNumero = Nothing
        Me.txtDocContable.Location = New System.Drawing.Point(46, 206)
        Me.txtDocContable.MaximoAncho = 0
        Me.txtDocContable.MensajedeAyuda = "Asignación. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
        Me.txtDocContable.Name = "txtDocContable"
        Me.txtDocContable.Size = New System.Drawing.Size(261, 30)
        Me.txtDocContable.SoloLectura = False
        Me.txtDocContable.SoloNumeros = False
        Me.txtDocContable.TabIndex = 10
        Me.txtDocContable.TextodelControl = ""
        Me.txtDocContable.TextoLabel = "Doc Contable :"
        Me.txtDocContable.TieneErrorControl = False
        Me.txtDocContable.TipodeDatos = SamitCtlNet.TipodeDato.Cadena
        Me.txtDocContable.TipodeLetra = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocContable.ValordelControl = Nothing
        Me.txtDocContable.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDocContable.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDocContable.ValorPredeterminado = Nothing
        '
        'txtCtaContable
        '
        Me.txtCtaContable.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtCtaContable.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtCtaContable.AltodelControl = 30
        Me.txtCtaContable.AnchoLabel = 100
        Me.txtCtaContable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCtaContable.AnchoTxt = 80
        Me.txtCtaContable.AutoCargarDatos = True
        Me.txtCtaContable.AutoSize = True
        Me.txtCtaContable.BackColor = System.Drawing.Color.Transparent
        Me.txtCtaContable.ColorFondo = System.Drawing.Color.Transparent
        Me.txtCtaContable.CondicionValida = ""
        Me.txtCtaContable.Conexion = SamitCtlNet.ConexionSAMIT.ConexModulo
        Me.txtCtaContable.ConsultaSQL = Nothing
        Me.txtCtaContable.EsObligatorio = False
        Me.txtCtaContable.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtCtaContable.FormatoNumero = Nothing
        Me.txtCtaContable.Location = New System.Drawing.Point(313, 206)
        Me.txtCtaContable.MaximoAncho = 0
        Me.txtCtaContable.MensajedeAyuda = ""
        Me.txtCtaContable.Name = "txtCtaContable"
        Me.txtCtaContable.Size = New System.Drawing.Size(791, 30)
        Me.txtCtaContable.SoloLectura = False
        Me.txtCtaContable.SoloNumeros = True
        Me.txtCtaContable.TabIndex = 11
        Me.txtCtaContable.TextodelControl = ""
        Me.txtCtaContable.TextoLabel = "Cta Contable :"
        Me.txtCtaContable.TieneErrorControl = False
        Me.txtCtaContable.TipoBusqueda = SamitCtlNet.ModGeneral.TipoBusqueda.Ninguna
        Me.txtCtaContable.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtCtaContable.TipodeLetra = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtCtaContable.ValordelControl = ""
        Me.txtCtaContable.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCtaContable.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCtaContable.ValorPredeterminado = Nothing
        '
        'lblVigente
        '
        Me.lblVigente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblVigente.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lblVigente.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblVigente.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblVigente.Location = New System.Drawing.Point(927, 268)
        Me.lblVigente.Name = "lblVigente"
        Me.lblVigente.Padding = New System.Windows.Forms.Padding(2)
        Me.lblVigente.Size = New System.Drawing.Size(72, 25)
        Me.lblVigente.TabIndex = 109
        Me.lblVigente.Text = "Vigente :"
        '
        'grbVigente
        '
        Me.grbVigente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grbVigente.EditValue = True
        Me.grbVigente.Location = New System.Drawing.Point(1005, 270)
        Me.grbVigente.Name = "grbVigente"
        Me.grbVigente.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.grbVigente.Properties.Appearance.Options.UseBackColor = True
        Me.grbVigente.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.grbVigente.Properties.Columns = 2
        Me.grbVigente.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.grbVigente.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "NO"), New DevExpress.XtraEditors.Controls.RadioGroupItem(True, "SI")})
        Me.grbVigente.Size = New System.Drawing.Size(91, 23)
        Me.grbVigente.TabIndex = 18
        '
        'lblFechaFinCc
        '
        Me.lblFechaFinCc.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaFinCc.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblFechaFinCc.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblFechaFinCc.Location = New System.Drawing.Point(292, 265)
        Me.lblFechaFinCc.Name = "lblFechaFinCc"
        Me.lblFechaFinCc.Padding = New System.Windows.Forms.Padding(2)
        Me.lblFechaFinCc.Size = New System.Drawing.Size(75, 26)
        Me.lblFechaFinCc.TabIndex = 107
        Me.lblFechaFinCc.Text = "Fecha Fin :"
        '
        'dteFechaFinC
        '
        Me.dteFechaFinC.EditValue = Nothing
        Me.dteFechaFinC.Location = New System.Drawing.Point(374, 269)
        Me.dteFechaFinC.Name = "dteFechaFinC"
        Me.dteFechaFinC.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.dteFechaFinC.Properties.Appearance.Options.UseFont = True
        Me.dteFechaFinC.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.dteFechaFinC.Properties.AppearanceDropDown.Options.UseFont = True
        Me.dteFechaFinC.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteFechaFinC.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteFechaFinC.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.dteFechaFinC.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dteFechaFinC.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.dteFechaFinC.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dteFechaFinC.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.dteFechaFinC.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.dteFechaFinC.Size = New System.Drawing.Size(116, 20)
        Me.dteFechaFinC.TabIndex = 17
        '
        'lblFechaIniCc
        '
        Me.lblFechaIniCc.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaIniCc.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblFechaIniCc.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblFechaIniCc.Location = New System.Drawing.Point(47, 265)
        Me.lblFechaIniCc.Name = "lblFechaIniCc"
        Me.lblFechaIniCc.Padding = New System.Windows.Forms.Padding(2)
        Me.lblFechaIniCc.Size = New System.Drawing.Size(106, 26)
        Me.lblFechaIniCc.TabIndex = 106
        Me.lblFechaIniCc.Text = "Fecha Inicio :"
        '
        'dteFechaIniC
        '
        Me.dteFechaIniC.EditValue = Nothing
        Me.dteFechaIniC.Location = New System.Drawing.Point(160, 269)
        Me.dteFechaIniC.Name = "dteFechaIniC"
        Me.dteFechaIniC.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.dteFechaIniC.Properties.Appearance.Options.UseFont = True
        Me.dteFechaIniC.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.dteFechaIniC.Properties.AppearanceDropDown.Options.UseFont = True
        Me.dteFechaIniC.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteFechaIniC.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteFechaIniC.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.dteFechaIniC.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dteFechaIniC.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.dteFechaIniC.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dteFechaIniC.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.dteFechaIniC.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.dteFechaIniC.Size = New System.Drawing.Size(106, 20)
        Me.dteFechaIniC.TabIndex = 16
        '
        'txtConcepto
        '
        Me.txtConcepto.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtConcepto.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtConcepto.AltodelControl = 30
        Me.txtConcepto.AnchoLabel = 150
        Me.txtConcepto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtConcepto.AnchoTxt = 80
        Me.txtConcepto.AutoCargarDatos = True
        Me.txtConcepto.AutoSize = True
        Me.txtConcepto.BackColor = System.Drawing.Color.Transparent
        Me.txtConcepto.ColorFondo = System.Drawing.Color.Transparent
        Me.txtConcepto.CondicionValida = ""
        Me.txtConcepto.Conexion = SamitCtlNet.ConexionSAMIT.ConexModulo
        Me.txtConcepto.ConsultaSQL = Nothing
        Me.txtConcepto.EsObligatorio = False
        Me.txtConcepto.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.txtConcepto.FormatoNumero = Nothing
        Me.txtConcepto.Location = New System.Drawing.Point(5, 58)
        Me.txtConcepto.MaximoAncho = 0
        Me.txtConcepto.MensajedeAyuda = ""
        Me.txtConcepto.Name = "txtConcepto"
        Me.txtConcepto.Size = New System.Drawing.Size(1099, 30)
        Me.txtConcepto.SoloLectura = False
        Me.txtConcepto.SoloNumeros = True
        Me.txtConcepto.TabIndex = 2
        Me.txtConcepto.TextodelControl = ""
        Me.txtConcepto.TextoLabel = "Concepto :"
        Me.txtConcepto.TieneErrorControl = False
        Me.txtConcepto.TipoBusqueda = SamitCtlNet.ModGeneral.TipoBusqueda.Ninguna
        Me.txtConcepto.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtConcepto.TipodeLetra = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtConcepto.ValordelControl = ""
        Me.txtConcepto.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtConcepto.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtConcepto.ValorPredeterminado = Nothing
        '
        'txtTotalDescontado
        '
        Me.txtTotalDescontado.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtTotalDescontado.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtTotalDescontado.AltodelControl = 30
        Me.txtTotalDescontado.AnchoLabel = 150
        Me.txtTotalDescontado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalDescontado.AutoSize = True
        Me.txtTotalDescontado.BackColor = System.Drawing.Color.Transparent
        Me.txtTotalDescontado.ColordeFondo = System.Drawing.Color.Transparent
        Me.txtTotalDescontado.EsObligatorio = False
        Me.txtTotalDescontado.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalDescontado.FormatoNumero = Nothing
        Me.txtTotalDescontado.Location = New System.Drawing.Point(5, 175)
        Me.txtTotalDescontado.MaximoAncho = 0
        Me.txtTotalDescontado.MensajedeAyuda = "Asignación. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
        Me.txtTotalDescontado.Name = "txtTotalDescontado"
        Me.txtTotalDescontado.Size = New System.Drawing.Size(1099, 30)
        Me.txtTotalDescontado.SoloLectura = False
        Me.txtTotalDescontado.SoloNumeros = False
        Me.txtTotalDescontado.TabIndex = 9
        Me.txtTotalDescontado.TextodelControl = ""
        Me.txtTotalDescontado.TextoLabel = "Total Descontado :"
        Me.txtTotalDescontado.TieneErrorControl = False
        Me.txtTotalDescontado.TipodeDatos = SamitCtlNet.TipodeDato.MonedaConDecimales
        Me.txtTotalDescontado.TipodeLetra = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalDescontado.ValordelControl = Nothing
        Me.txtTotalDescontado.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTotalDescontado.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTotalDescontado.ValorPredeterminado = Nothing
        '
        'txtDescuentoPeriodo
        '
        Me.txtDescuentoPeriodo.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtDescuentoPeriodo.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtDescuentoPeriodo.AltodelControl = 30
        Me.txtDescuentoPeriodo.AnchoLabel = 150
        Me.txtDescuentoPeriodo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescuentoPeriodo.AutoSize = True
        Me.txtDescuentoPeriodo.BackColor = System.Drawing.Color.Transparent
        Me.txtDescuentoPeriodo.ColordeFondo = System.Drawing.Color.Transparent
        Me.txtDescuentoPeriodo.EsObligatorio = False
        Me.txtDescuentoPeriodo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescuentoPeriodo.FormatoNumero = Nothing
        Me.txtDescuentoPeriodo.Location = New System.Drawing.Point(5, 144)
        Me.txtDescuentoPeriodo.MaximoAncho = 0
        Me.txtDescuentoPeriodo.MensajedeAyuda = "Asignación. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
        Me.txtDescuentoPeriodo.Name = "txtDescuentoPeriodo"
        Me.txtDescuentoPeriodo.Size = New System.Drawing.Size(1099, 30)
        Me.txtDescuentoPeriodo.SoloLectura = False
        Me.txtDescuentoPeriodo.SoloNumeros = False
        Me.txtDescuentoPeriodo.TabIndex = 8
        Me.txtDescuentoPeriodo.TextodelControl = ""
        Me.txtDescuentoPeriodo.TextoLabel = "Valor Cuota :"
        Me.txtDescuentoPeriodo.TieneErrorControl = False
        Me.txtDescuentoPeriodo.TipodeDatos = SamitCtlNet.TipodeDato.MonedaConDecimales
        Me.txtDescuentoPeriodo.TipodeLetra = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescuentoPeriodo.ValordelControl = Nothing
        Me.txtDescuentoPeriodo.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDescuentoPeriodo.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDescuentoPeriodo.ValorPredeterminado = Nothing
        '
        'txtTotalDescontar
        '
        Me.txtTotalDescontar.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtTotalDescontar.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtTotalDescontar.AltodelControl = 30
        Me.txtTotalDescontar.AnchoLabel = 150
        Me.txtTotalDescontar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalDescontar.AutoSize = True
        Me.txtTotalDescontar.BackColor = System.Drawing.Color.Transparent
        Me.txtTotalDescontar.ColordeFondo = System.Drawing.Color.Transparent
        Me.txtTotalDescontar.EsObligatorio = False
        Me.txtTotalDescontar.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalDescontar.FormatoNumero = Nothing
        Me.txtTotalDescontar.Location = New System.Drawing.Point(5, 89)
        Me.txtTotalDescontar.MaximoAncho = 0
        Me.txtTotalDescontar.MensajedeAyuda = "Monto Total a Descontar. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
        Me.txtTotalDescontar.Name = "txtTotalDescontar"
        Me.txtTotalDescontar.Size = New System.Drawing.Size(1099, 30)
        Me.txtTotalDescontar.SoloLectura = False
        Me.txtTotalDescontar.SoloNumeros = False
        Me.txtTotalDescontar.TabIndex = 3
        Me.txtTotalDescontar.TextodelControl = ""
        Me.txtTotalDescontar.TextoLabel = "Total a Descontar :"
        Me.txtTotalDescontar.TieneErrorControl = False
        Me.txtTotalDescontar.TipodeDatos = SamitCtlNet.TipodeDato.MonedaConDecimales
        Me.txtTotalDescontar.TipodeLetra = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalDescontar.ValordelControl = Nothing
        Me.txtTotalDescontar.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTotalDescontar.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTotalDescontar.ValorPredeterminado = Nothing
        '
        'txtContrato
        '
        Me.txtContrato.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtContrato.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtContrato.AltodelControl = 30
        Me.txtContrato.AnchoLabel = 150
        Me.txtContrato.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtContrato.AnchoTxt = 80
        Me.txtContrato.AutoCargarDatos = True
        Me.txtContrato.AutoSize = True
        Me.txtContrato.BackColor = System.Drawing.Color.Transparent
        Me.txtContrato.ColorFondo = System.Drawing.Color.Transparent
        Me.txtContrato.CondicionValida = ""
        Me.txtContrato.Conexion = SamitCtlNet.ConexionSAMIT.ConexModulo
        Me.txtContrato.ConsultaSQL = Nothing
        Me.txtContrato.EsObligatorio = False
        Me.txtContrato.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.txtContrato.FormatoNumero = Nothing
        Me.txtContrato.Location = New System.Drawing.Point(5, 26)
        Me.txtContrato.MaximoAncho = 0
        Me.txtContrato.MensajedeAyuda = ""
        Me.txtContrato.Name = "txtContrato"
        Me.txtContrato.Size = New System.Drawing.Size(1099, 30)
        Me.txtContrato.SoloLectura = False
        Me.txtContrato.SoloNumeros = True
        Me.txtContrato.TabIndex = 1
        Me.txtContrato.TextodelControl = ""
        Me.txtContrato.TextoLabel = "Contrato :"
        Me.txtContrato.TieneErrorControl = False
        Me.txtContrato.TipoBusqueda = SamitCtlNet.ModGeneral.TipoBusqueda.Ninguna
        Me.txtContrato.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtContrato.TipodeLetra = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtContrato.ValordelControl = ""
        Me.txtContrato.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtContrato.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtContrato.ValorPredeterminado = Nothing
        '
        'SeparatorControl6
        '
        Me.SeparatorControl6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SeparatorControl6.Location = New System.Drawing.Point(8, 294)
        Me.SeparatorControl6.Name = "SeparatorControl6"
        Me.SeparatorControl6.Padding = New System.Windows.Forms.Padding(0)
        Me.SeparatorControl6.Size = New System.Drawing.Size(1096, 10)
        Me.SeparatorControl6.TabIndex = 96
        Me.SeparatorControl6.TabStop = False
        '
        'gcDescuentos
        '
        Me.gcDescuentos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcDescuentos.Location = New System.Drawing.Point(0, 304)
        Me.gcDescuentos.MainView = Me.gvDescuentos
        Me.gcDescuentos.Name = "gcDescuentos"
        Me.gcDescuentos.Size = New System.Drawing.Size(1109, 320)
        Me.gcDescuentos.TabIndex = 93
        Me.gcDescuentos.TabStop = False
        Me.gcDescuentos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvDescuentos})
        '
        'gvDescuentos
        '
        Me.gvDescuentos.GridControl = Me.gcDescuentos
        Me.gvDescuentos.Name = "gvDescuentos"
        '
        'FrmAggDescuentosNomina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1221, 635)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.gbxPrincipal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmAggDescuentosNomina"
        Me.Text = "Descuentos Por Nomina"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.gbxPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxPrincipal.ResumeLayout(False)
        Me.gbxPrincipal.PerformLayout()
        CType(Me.ckeLiqPeriodos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckeLiqSemestres.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckeLiqExtraordinarias.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grbVigente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFechaFinC.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFechaFinC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFechaIniC.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFechaIniC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeparatorControl6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcDescuentos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvDescuentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnLimpiar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gbxPrincipal As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SeparatorControl6 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents gcDescuentos As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvDescuentos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtContrato As SamitCtlNet.SamitBusq
    Friend WithEvents txtConcepto As SamitCtlNet.SamitBusq
    Friend WithEvents txtTotalDescontado As SamitCtlNet.SamitTexto
    Friend WithEvents txtDescuentoPeriodo As SamitCtlNet.SamitTexto
    Friend WithEvents txtTotalDescontar As SamitCtlNet.SamitTexto
    Friend WithEvents lblFechaFinCc As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dteFechaFinC As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lblFechaIniCc As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dteFechaIniC As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lblVigente As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grbVigente As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents txtCuotaFinal As SamitCtlNet.SamitTexto
    Friend WithEvents txtCuotaInicial As SamitCtlNet.SamitTexto
    Friend WithEvents txtNumCuotas As SamitCtlNet.SamitTexto
    Friend WithEvents txtDocContable As SamitCtlNet.SamitTexto
    Friend WithEvents txtCtaContable As SamitCtlNet.SamitBusq
    Friend WithEvents txtCuotaActual As SamitCtlNet.SamitTexto
    Friend WithEvents ckeLiqPeriodos As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lblAplicaLiquidaciones As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ckeLiqSemestres As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ckeLiqExtraordinarias As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents btnListaCuotas As DevExpress.XtraEditors.SimpleButton
End Class
