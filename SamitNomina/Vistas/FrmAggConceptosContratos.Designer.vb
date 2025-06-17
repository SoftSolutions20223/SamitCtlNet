<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAggConceptosContratos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAggConceptosContratos))
        Me.gbxPrincipal = New DevExpress.XtraEditors.GroupControl()
        Me.btnAbrirFormula = New DevExpress.XtraEditors.SimpleButton()
        Me.txtMaximoDescuento = New SamitCtlNet.SamitTexto()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.ckePeriodo1 = New DevExpress.XtraEditors.CheckEdit()
        Me.ckePeriodo2 = New DevExpress.XtraEditors.CheckEdit()
        Me.ckePeriodo3 = New DevExpress.XtraEditors.CheckEdit()
        Me.SeparatorControl1 = New DevExpress.XtraEditors.SeparatorControl()
        Me.txtClasificacion = New SamitCtlNet.SamitBusq()
        Me.lblVigente = New DevExpress.XtraEditors.LabelControl()
        Me.grbVigente = New DevExpress.XtraEditors.RadioGroup()
        Me.gcConceptos = New DevExpress.XtraGrid.GridControl()
        Me.gvConceptos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcVariables = New DevExpress.XtraGrid.GridControl()
        Me.gvVariables = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtBusqueda = New DevExpress.XtraEditors.TextEdit()
        Me.txtNombre = New SamitCtlNet.SamitTexto()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEliminar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnLimpiar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.txtCodDian = New SamitCtlNet.SamitBusq()
        CType(Me.gbxPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxPrincipal.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.ckePeriodo1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckePeriodo2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckePeriodo3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.gbxPrincipal.Controls.Add(Me.txtCodDian)
        Me.gbxPrincipal.Controls.Add(Me.btnAbrirFormula)
        Me.gbxPrincipal.Controls.Add(Me.txtMaximoDescuento)
        Me.gbxPrincipal.Controls.Add(Me.GroupControl2)
        Me.gbxPrincipal.Controls.Add(Me.SeparatorControl1)
        Me.gbxPrincipal.Controls.Add(Me.txtClasificacion)
        Me.gbxPrincipal.Controls.Add(Me.lblVigente)
        Me.gbxPrincipal.Controls.Add(Me.grbVigente)
        Me.gbxPrincipal.Controls.Add(Me.gcConceptos)
        Me.gbxPrincipal.Controls.Add(Me.gcVariables)
        Me.gbxPrincipal.Controls.Add(Me.txtBusqueda)
        Me.gbxPrincipal.Controls.Add(Me.txtNombre)
        Me.gbxPrincipal.Location = New System.Drawing.Point(7, 6)
        Me.gbxPrincipal.Name = "gbxPrincipal"
        Me.gbxPrincipal.Size = New System.Drawing.Size(823, 606)
        Me.gbxPrincipal.TabIndex = 8
        Me.gbxPrincipal.TabStop = True
        Me.gbxPrincipal.Text = "Datos del Concepto Personal"
        '
        'btnAbrirFormula
        '
        Me.btnAbrirFormula.AllowFocus = False
        Me.btnAbrirFormula.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAbrirFormula.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnAbrirFormula.Appearance.Options.UseFont = True
        Me.btnAbrirFormula.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnAbrirFormula.Location = New System.Drawing.Point(782, 57)
        Me.btnAbrirFormula.Name = "btnAbrirFormula"
        Me.btnAbrirFormula.Size = New System.Drawing.Size(34, 25)
        Me.btnAbrirFormula.TabIndex = 103
        Me.btnAbrirFormula.TabStop = False
        '
        'txtMaximoDescuento
        '
        Me.txtMaximoDescuento.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtMaximoDescuento.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtMaximoDescuento.AltodelControl = 30
        Me.txtMaximoDescuento.AnchoLabel = 140
        Me.txtMaximoDescuento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMaximoDescuento.AutoSize = True
        Me.txtMaximoDescuento.BackColor = System.Drawing.Color.Transparent
        Me.txtMaximoDescuento.ColordeFondo = System.Drawing.Color.Transparent
        Me.txtMaximoDescuento.EsObligatorio = False
        Me.txtMaximoDescuento.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaximoDescuento.FormatoNumero = Nothing
        Me.txtMaximoDescuento.Location = New System.Drawing.Point(3, 56)
        Me.txtMaximoDescuento.MaximoAncho = 0
        Me.txtMaximoDescuento.MensajedeAyuda = ""
        Me.txtMaximoDescuento.Name = "txtMaximoDescuento"
        Me.txtMaximoDescuento.Size = New System.Drawing.Size(776, 30)
        Me.txtMaximoDescuento.SoloLectura = False
        Me.txtMaximoDescuento.SoloNumeros = False
        Me.txtMaximoDescuento.TabIndex = 2
        Me.txtMaximoDescuento.TextodelControl = ""
        Me.txtMaximoDescuento.TextoLabel = "Máximo a Descontar  :"
        Me.txtMaximoDescuento.TieneErrorControl = False
        Me.txtMaximoDescuento.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtMaximoDescuento.TipodeLetra = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtMaximoDescuento.ValordelControl = Nothing
        Me.txtMaximoDescuento.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtMaximoDescuento.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtMaximoDescuento.ValorPredeterminado = Nothing
        '
        'GroupControl2
        '
        Me.GroupControl2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.Controls.Add(Me.ckePeriodo1)
        Me.GroupControl2.Controls.Add(Me.ckePeriodo2)
        Me.GroupControl2.Controls.Add(Me.ckePeriodo3)
        Me.GroupControl2.Location = New System.Drawing.Point(537, 120)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(278, 57)
        Me.GroupControl2.TabIndex = 8
        Me.GroupControl2.TabStop = True
        Me.GroupControl2.Text = "Periodos del mes a liquidar :"
        '
        'ckePeriodo1
        '
        Me.ckePeriodo1.Location = New System.Drawing.Point(5, 28)
        Me.ckePeriodo1.Name = "ckePeriodo1"
        Me.ckePeriodo1.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckePeriodo1.Properties.Appearance.Options.UseFont = True
        Me.ckePeriodo1.Properties.Caption = "Periodo 1"
        Me.ckePeriodo1.Size = New System.Drawing.Size(85, 20)
        Me.ckePeriodo1.TabIndex = 1
        '
        'ckePeriodo2
        '
        Me.ckePeriodo2.Location = New System.Drawing.Point(98, 28)
        Me.ckePeriodo2.Name = "ckePeriodo2"
        Me.ckePeriodo2.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckePeriodo2.Properties.Appearance.Options.UseFont = True
        Me.ckePeriodo2.Properties.Caption = "Periodo 2"
        Me.ckePeriodo2.Size = New System.Drawing.Size(85, 20)
        Me.ckePeriodo2.TabIndex = 2
        '
        'ckePeriodo3
        '
        Me.ckePeriodo3.Location = New System.Drawing.Point(193, 28)
        Me.ckePeriodo3.Name = "ckePeriodo3"
        Me.ckePeriodo3.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckePeriodo3.Properties.Appearance.Options.UseFont = True
        Me.ckePeriodo3.Properties.Caption = "Periodo 3"
        Me.ckePeriodo3.Size = New System.Drawing.Size(85, 20)
        Me.ckePeriodo3.TabIndex = 3
        '
        'SeparatorControl1
        '
        Me.SeparatorControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SeparatorControl1.Location = New System.Drawing.Point(2, 179)
        Me.SeparatorControl1.Name = "SeparatorControl1"
        Me.SeparatorControl1.Padding = New System.Windows.Forms.Padding(0)
        Me.SeparatorControl1.Size = New System.Drawing.Size(820, 3)
        Me.SeparatorControl1.TabIndex = 102
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
        Me.txtClasificacion.EsObligatorio = False
        Me.txtClasificacion.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.txtClasificacion.FormatoNumero = Nothing
        Me.txtClasificacion.Location = New System.Drawing.Point(3, 86)
        Me.txtClasificacion.MaximoAncho = 0
        Me.txtClasificacion.MensajedeAyuda = ""
        Me.txtClasificacion.Name = "txtClasificacion"
        Me.txtClasificacion.Size = New System.Drawing.Size(812, 30)
        Me.txtClasificacion.SoloLectura = False
        Me.txtClasificacion.SoloNumeros = True
        Me.txtClasificacion.TabIndex = 3
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
        'lblVigente
        '
        Me.lblVigente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblVigente.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lblVigente.Appearance.Options.UseFont = True
        Me.lblVigente.Appearance.Options.UseTextOptions = True
        Me.lblVigente.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblVigente.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblVigente.Location = New System.Drawing.Point(337, 150)
        Me.lblVigente.Name = "lblVigente"
        Me.lblVigente.Padding = New System.Windows.Forms.Padding(2)
        Me.lblVigente.Size = New System.Drawing.Size(102, 26)
        Me.lblVigente.TabIndex = 100
        Me.lblVigente.Text = "Vigente :"
        '
        'grbVigente
        '
        Me.grbVigente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grbVigente.Location = New System.Drawing.Point(437, 153)
        Me.grbVigente.Name = "grbVigente"
        Me.grbVigente.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.grbVigente.Properties.Appearance.Options.UseBackColor = True
        Me.grbVigente.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.grbVigente.Properties.Columns = 2
        Me.grbVigente.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.grbVigente.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "NO"), New DevExpress.XtraEditors.Controls.RadioGroupItem(True, "SI")})
        Me.grbVigente.Size = New System.Drawing.Size(91, 20)
        Me.grbVigente.TabIndex = 6
        '
        'gcConceptos
        '
        Me.gcConceptos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcConceptos.Location = New System.Drawing.Point(2, 214)
        Me.gcConceptos.MainView = Me.gvConceptos
        Me.gcConceptos.Name = "gcConceptos"
        Me.gcConceptos.Size = New System.Drawing.Size(820, 390)
        Me.gcConceptos.TabIndex = 10
        Me.gcConceptos.TabStop = False
        Me.gcConceptos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvConceptos})
        '
        'gvConceptos
        '
        Me.gvConceptos.GridControl = Me.gcConceptos
        Me.gvConceptos.Name = "gvConceptos"
        '
        'gcVariables
        '
        Me.gcVariables.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcVariables.Location = New System.Drawing.Point(0, 319)
        Me.gcVariables.MainView = Me.gvVariables
        Me.gcVariables.Name = "gcVariables"
        Me.gcVariables.Size = New System.Drawing.Size(825, 287)
        Me.gcVariables.TabIndex = 0
        Me.gcVariables.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvVariables})
        Me.gcVariables.Visible = False
        '
        'gvVariables
        '
        Me.gvVariables.GridControl = Me.gcVariables
        Me.gvVariables.Name = "gvVariables"
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBusqueda.Location = New System.Drawing.Point(3, 184)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.txtBusqueda.Properties.Appearance.Options.UseFont = True
        Me.txtBusqueda.Size = New System.Drawing.Size(817, 24)
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
        Me.txtNombre.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtNombre.FormatoNumero = Nothing
        Me.txtNombre.Location = New System.Drawing.Point(2, 26)
        Me.txtNombre.MaximoAncho = 0
        Me.txtNombre.MensajedeAyuda = ""
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(817, 30)
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
        Me.GroupControl1.Location = New System.Drawing.Point(836, 5)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(88, 606)
        Me.GroupControl1.TabIndex = 9
        Me.GroupControl1.Text = "Opciones"
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(7, 132)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(74, 30)
        Me.btnSalir.TabIndex = 8
        Me.btnSalir.Text = "Salir"
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(7, 96)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(74, 30)
        Me.btnEliminar.TabIndex = 7
        Me.btnEliminar.Text = "Eliminar"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnLimpiar.Appearance.Options.UseFont = True
        Me.btnLimpiar.Location = New System.Drawing.Point(7, 60)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(74, 30)
        Me.btnLimpiar.TabIndex = 6
        Me.btnLimpiar.Text = "Limpiar"
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Location = New System.Drawing.Point(7, 24)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(74, 30)
        Me.btnGuardar.TabIndex = 5
        Me.btnGuardar.Text = "Guardar"
        '
        'txtCodDian
        '
        Me.txtCodDian.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtCodDian.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtCodDian.AltodelControl = 30
        Me.txtCodDian.AnchoLabel = 140
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
        Me.txtCodDian.EsObligatorio = False
        Me.txtCodDian.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.txtCodDian.FormatoNumero = Nothing
        Me.txtCodDian.Location = New System.Drawing.Point(2, 118)
        Me.txtCodDian.MaximoAncho = 0
        Me.txtCodDian.MensajedeAyuda = ""
        Me.txtCodDian.Name = "txtCodDian"
        Me.txtCodDian.Size = New System.Drawing.Size(529, 30)
        Me.txtCodDian.SoloLectura = False
        Me.txtCodDian.SoloNumeros = True
        Me.txtCodDian.TabIndex = 4
        Me.txtCodDian.TextodelControl = ""
        Me.txtCodDian.TextoLabel = "CodDian :"
        Me.txtCodDian.TieneErrorControl = False
        Me.txtCodDian.TipoBusqueda = SamitCtlNet.ModGeneral.TipoBusqueda.Ninguna
        Me.txtCodDian.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtCodDian.TipodeLetra = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtCodDian.ValordelControl = ""
        Me.txtCodDian.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCodDian.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCodDian.ValorPredeterminado = Nothing
        '
        'FrmAggConceptosContratos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(929, 615)
        Me.Controls.Add(Me.gbxPrincipal)
        Me.Controls.Add(Me.GroupControl1)
        Me.IconOptions.Icon = CType(resources.GetObject("FrmAggConceptosContratos.IconOptions.Icon"), System.Drawing.Icon)
        Me.Name = "FrmAggConceptosContratos"
        Me.Text = "Conceptos Personales"
        CType(Me.gbxPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxPrincipal.ResumeLayout(False)
        Me.gbxPrincipal.PerformLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.ckePeriodo1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckePeriodo2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckePeriodo3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents ckePeriodo1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ckePeriodo2 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ckePeriodo3 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents SeparatorControl1 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents txtClasificacion As SamitCtlNet.SamitBusq
    Friend WithEvents lblVigente As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grbVigente As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents gcConceptos As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvConceptos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gcVariables As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvVariables As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtBusqueda As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNombre As SamitCtlNet.SamitTexto
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnLimpiar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtMaximoDescuento As SamitCtlNet.SamitTexto
    Friend WithEvents btnAbrirFormula As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtCodDian As SamitCtlNet.SamitBusq
End Class
