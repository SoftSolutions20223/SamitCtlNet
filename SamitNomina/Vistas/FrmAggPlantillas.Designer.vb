<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAggPlantillas
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
        Dim ColumnDefinition1 As DevExpress.XtraLayout.ColumnDefinition = New DevExpress.XtraLayout.ColumnDefinition()
        Dim ColumnDefinition2 As DevExpress.XtraLayout.ColumnDefinition = New DevExpress.XtraLayout.ColumnDefinition()
        Dim RowDefinition1 As DevExpress.XtraLayout.RowDefinition = New DevExpress.XtraLayout.RowDefinition()
        Dim RowDefinition2 As DevExpress.XtraLayout.RowDefinition = New DevExpress.XtraLayout.RowDefinition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAggPlantillas))
        Me.gbxConceptos = New DevExpress.XtraEditors.GroupControl()
        Me.btnAggConceptos = New DevExpress.XtraEditors.SimpleButton()
        Me.txtConceptos = New SamitCtlNet.SamitBusq()
        Me.btnEliminarConcepto = New DevExpress.XtraEditors.SimpleButton()
        Me.gcConceptos = New DevExpress.XtraGrid.GridControl()
        Me.gvConceptos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gbxPlantillas = New DevExpress.XtraEditors.GroupControl()
        Me.btnCargarPlantilla = New DevExpress.XtraEditors.SimpleButton()
        Me.lblUsaPlantillaBase = New DevExpress.XtraEditors.LabelControl()
        Me.SeparatorControl1 = New DevExpress.XtraEditors.SeparatorControl()
        Me.lblVigente = New DevExpress.XtraEditors.LabelControl()
        Me.grbVigente = New DevExpress.XtraEditors.RadioGroup()
        Me.gcPlantillas = New DevExpress.XtraGrid.GridControl()
        Me.gvPlantillas = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtBusqueda = New DevExpress.XtraEditors.TextEdit()
        Me.txtNombre = New SamitCtlNet.SamitTexto()
        Me.txtPlantillaBase = New SamitCtlNet.SamitBusq()
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEliminar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnLimpiar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.gcConceptosProvision = New DevExpress.XtraEditors.GroupControl()
        Me.btnAggConceptosProv = New DevExpress.XtraEditors.SimpleButton()
        Me.txtConceptosPlantProv = New SamitCtlNet.SamitBusq()
        Me.btnEliminarConceptoProv = New DevExpress.XtraEditors.SimpleButton()
        Me.gcConceptosPlantProvision = New DevExpress.XtraGrid.GridControl()
        Me.gvConceptosProvision = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.gbxConceptos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxConceptos.SuspendLayout()
        CType(Me.gcConceptos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvConceptos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gbxPlantillas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxPlantillas.SuspendLayout()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grbVigente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcPlantillas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvPlantillas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBusqueda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.gcConceptosProvision, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gcConceptosProvision.SuspendLayout()
        CType(Me.gcConceptosPlantProvision, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvConceptosProvision, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbxConceptos
        '
        Me.gbxConceptos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxConceptos.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.gbxConceptos.AppearanceCaption.Options.UseFont = True
        Me.gbxConceptos.Controls.Add(Me.btnAggConceptos)
        Me.gbxConceptos.Controls.Add(Me.txtConceptos)
        Me.gbxConceptos.Controls.Add(Me.btnEliminarConcepto)
        Me.gbxConceptos.Controls.Add(Me.gcConceptos)
        Me.gbxConceptos.Location = New System.Drawing.Point(482, 2)
        Me.gbxConceptos.Name = "gbxConceptos"
        Me.gbxConceptos.Size = New System.Drawing.Size(476, 249)
        Me.gbxConceptos.TabIndex = 2
        Me.gbxConceptos.Text = "Conceptos del perfil"
        '
        'btnAggConceptos
        '
        Me.btnAggConceptos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAggConceptos.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnAggConceptos.Appearance.Options.UseFont = True
        Me.btnAggConceptos.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnAggConceptos.Location = New System.Drawing.Point(385, 27)
        Me.btnAggConceptos.Name = "btnAggConceptos"
        Me.btnAggConceptos.Size = New System.Drawing.Size(40, 26)
        Me.btnAggConceptos.TabIndex = 2
        '
        'txtConceptos
        '
        Me.txtConceptos.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtConceptos.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtConceptos.AltodelControl = 30
        Me.txtConceptos.AnchoLabel = 100
        Me.txtConceptos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtConceptos.AnchoTxt = 80
        Me.txtConceptos.AutoCargarDatos = True
        Me.txtConceptos.AutoSize = True
        Me.txtConceptos.BackColor = System.Drawing.Color.Transparent
        Me.txtConceptos.ColorFondo = System.Drawing.Color.Transparent
        Me.txtConceptos.CondicionValida = ""
        Me.txtConceptos.Conexion = SamitCtlNet.ConexionSAMIT.ConexModulo
        Me.txtConceptos.ConsultaSQL = Nothing
        Me.txtConceptos.EsObligatorio = False
        Me.txtConceptos.FormatoNumero = Nothing
        Me.txtConceptos.Location = New System.Drawing.Point(5, 24)
        Me.txtConceptos.MaximoAncho = 0
        Me.txtConceptos.MensajedeAyuda = Nothing
        Me.txtConceptos.Name = "txtConceptos"
        Me.txtConceptos.Size = New System.Drawing.Size(374, 30)
        Me.txtConceptos.SoloLectura = False
        Me.txtConceptos.SoloNumeros = True
        Me.txtConceptos.TabIndex = 1
        Me.txtConceptos.TextodelControl = ""
        Me.txtConceptos.TextoLabel = "Conceptos :"
        Me.txtConceptos.TieneErrorControl = False
        Me.txtConceptos.TipoBusqueda = SamitCtlNet.ModGeneral.TipoBusqueda.Ninguna
        Me.txtConceptos.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtConceptos.TipodeLetra = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConceptos.ValordelControl = ""
        Me.txtConceptos.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtConceptos.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtConceptos.ValorPredeterminado = Nothing
        '
        'btnEliminarConcepto
        '
        Me.btnEliminarConcepto.AllowFocus = False
        Me.btnEliminarConcepto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminarConcepto.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnEliminarConcepto.Appearance.Options.UseFont = True
        Me.btnEliminarConcepto.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnEliminarConcepto.Location = New System.Drawing.Point(431, 27)
        Me.btnEliminarConcepto.Name = "btnEliminarConcepto"
        Me.btnEliminarConcepto.Size = New System.Drawing.Size(40, 26)
        Me.btnEliminarConcepto.TabIndex = 3
        '
        'gcConceptos
        '
        Me.gcConceptos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcConceptos.Location = New System.Drawing.Point(0, 59)
        Me.gcConceptos.MainView = Me.gvConceptos
        Me.gcConceptos.Name = "gcConceptos"
        Me.gcConceptos.Size = New System.Drawing.Size(476, 190)
        Me.gcConceptos.TabIndex = 3
        Me.gcConceptos.TabStop = False
        Me.gcConceptos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvConceptos})
        '
        'gvConceptos
        '
        Me.gvConceptos.GridControl = Me.gcConceptos
        Me.gvConceptos.Name = "gvConceptos"
        Me.gvConceptos.OptionsView.ShowGroupPanel = False
        '
        'gbxPlantillas
        '
        Me.gbxPlantillas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxPlantillas.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.gbxPlantillas.AppearanceCaption.Options.UseFont = True
        Me.gbxPlantillas.Controls.Add(Me.btnCargarPlantilla)
        Me.gbxPlantillas.Controls.Add(Me.lblUsaPlantillaBase)
        Me.gbxPlantillas.Controls.Add(Me.SeparatorControl1)
        Me.gbxPlantillas.Controls.Add(Me.lblVigente)
        Me.gbxPlantillas.Controls.Add(Me.grbVigente)
        Me.gbxPlantillas.Controls.Add(Me.gcPlantillas)
        Me.gbxPlantillas.Controls.Add(Me.txtBusqueda)
        Me.gbxPlantillas.Controls.Add(Me.txtNombre)
        Me.gbxPlantillas.Controls.Add(Me.txtPlantillaBase)
        Me.gbxPlantillas.Location = New System.Drawing.Point(2, 2)
        Me.gbxPlantillas.Name = "gbxPlantillas"
        Me.gbxPlantillas.Size = New System.Drawing.Size(476, 502)
        Me.gbxPlantillas.TabIndex = 0
        Me.gbxPlantillas.Text = "Información Perfil"
        '
        'btnCargarPlantilla
        '
        Me.btnCargarPlantilla.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnCargarPlantilla.Appearance.Options.UseFont = True
        Me.btnCargarPlantilla.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnCargarPlantilla.Location = New System.Drawing.Point(282, 54)
        Me.btnCargarPlantilla.Name = "btnCargarPlantilla"
        Me.btnCargarPlantilla.Size = New System.Drawing.Size(130, 26)
        Me.btnCargarPlantilla.TabIndex = 105
        Me.btnCargarPlantilla.Text = "Cargar Plantilla"
        '
        'lblUsaPlantillaBase
        '
        Me.lblUsaPlantillaBase.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lblUsaPlantillaBase.Appearance.Options.UseFont = True
        Me.lblUsaPlantillaBase.Appearance.Options.UseTextOptions = True
        Me.lblUsaPlantillaBase.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblUsaPlantillaBase.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblUsaPlantillaBase.Location = New System.Drawing.Point(198, 53)
        Me.lblUsaPlantillaBase.Name = "lblUsaPlantillaBase"
        Me.lblUsaPlantillaBase.Padding = New System.Windows.Forms.Padding(2)
        Me.lblUsaPlantillaBase.Size = New System.Drawing.Size(78, 26)
        Me.lblUsaPlantillaBase.TabIndex = 104
        Me.lblUsaPlantillaBase.Text = "Plant. Base :"
        '
        'SeparatorControl1
        '
        Me.SeparatorControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SeparatorControl1.Location = New System.Drawing.Point(3, 84)
        Me.SeparatorControl1.Name = "SeparatorControl1"
        Me.SeparatorControl1.Padding = New System.Windows.Forms.Padding(0)
        Me.SeparatorControl1.Size = New System.Drawing.Size(470, 3)
        Me.SeparatorControl1.TabIndex = 102
        '
        'lblVigente
        '
        Me.lblVigente.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lblVigente.Appearance.Options.UseFont = True
        Me.lblVigente.Appearance.Options.UseTextOptions = True
        Me.lblVigente.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblVigente.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblVigente.Location = New System.Drawing.Point(6, 53)
        Me.lblVigente.Name = "lblVigente"
        Me.lblVigente.Padding = New System.Windows.Forms.Padding(2)
        Me.lblVigente.Size = New System.Drawing.Size(85, 26)
        Me.lblVigente.TabIndex = 100
        Me.lblVigente.Text = "Vigente :"
        '
        'grbVigente
        '
        Me.grbVigente.EditValue = True
        Me.grbVigente.Location = New System.Drawing.Point(97, 54)
        Me.grbVigente.Name = "grbVigente"
        Me.grbVigente.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.grbVigente.Properties.Appearance.Options.UseBackColor = True
        Me.grbVigente.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.grbVigente.Properties.Columns = 2
        Me.grbVigente.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.grbVigente.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "NO"), New DevExpress.XtraEditors.Controls.RadioGroupItem(True, "SI")})
        Me.grbVigente.Size = New System.Drawing.Size(91, 25)
        Me.grbVigente.TabIndex = 2
        '
        'gcPlantillas
        '
        Me.gcPlantillas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcPlantillas.Location = New System.Drawing.Point(1, 120)
        Me.gcPlantillas.MainView = Me.gvPlantillas
        Me.gcPlantillas.Name = "gcPlantillas"
        Me.gcPlantillas.Size = New System.Drawing.Size(475, 382)
        Me.gcPlantillas.TabIndex = 0
        Me.gcPlantillas.TabStop = False
        Me.gcPlantillas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvPlantillas})
        '
        'gvPlantillas
        '
        Me.gvPlantillas.GridControl = Me.gcPlantillas
        Me.gvPlantillas.Name = "gvPlantillas"
        Me.gvPlantillas.OptionsView.ShowGroupPanel = False
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBusqueda.Location = New System.Drawing.Point(1, 90)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.txtBusqueda.Properties.Appearance.Options.UseFont = True
        Me.txtBusqueda.Size = New System.Drawing.Size(475, 24)
        Me.txtBusqueda.TabIndex = 0
        Me.txtBusqueda.TabStop = False
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
        Me.txtNombre.Location = New System.Drawing.Point(5, 25)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtNombre.MaximoAncho = 0
        Me.txtNombre.MensajedeAyuda = "Digite la denominación del cargo que desea registrar o actualizar. (ENTER,ABJ)=Av" &
    "anzar"
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(467, 30)
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
        'txtPlantillaBase
        '
        Me.txtPlantillaBase.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtPlantillaBase.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtPlantillaBase.AltodelControl = 30
        Me.txtPlantillaBase.AnchoLabel = 100
        Me.txtPlantillaBase.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPlantillaBase.AnchoTxt = 80
        Me.txtPlantillaBase.AutoCargarDatos = True
        Me.txtPlantillaBase.AutoSize = True
        Me.txtPlantillaBase.BackColor = System.Drawing.Color.Transparent
        Me.txtPlantillaBase.ColorFondo = System.Drawing.Color.Transparent
        Me.txtPlantillaBase.CondicionValida = ""
        Me.txtPlantillaBase.Conexion = SamitCtlNet.ConexionSAMIT.ConexModulo
        Me.txtPlantillaBase.ConsultaSQL = Nothing
        Me.txtPlantillaBase.EsObligatorio = False
        Me.txtPlantillaBase.FormatoNumero = Nothing
        Me.txtPlantillaBase.Location = New System.Drawing.Point(-3, 122)
        Me.txtPlantillaBase.MaximoAncho = 0
        Me.txtPlantillaBase.MensajedeAyuda = Nothing
        Me.txtPlantillaBase.Name = "txtPlantillaBase"
        Me.txtPlantillaBase.Size = New System.Drawing.Size(331, 30)
        Me.txtPlantillaBase.SoloLectura = False
        Me.txtPlantillaBase.SoloNumeros = True
        Me.txtPlantillaBase.TabIndex = 106
        Me.txtPlantillaBase.TextodelControl = ""
        Me.txtPlantillaBase.TextoLabel = "Conceptos :"
        Me.txtPlantillaBase.TieneErrorControl = False
        Me.txtPlantillaBase.TipoBusqueda = SamitCtlNet.ModGeneral.TipoBusqueda.Ninguna
        Me.txtPlantillaBase.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtPlantillaBase.TipodeLetra = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlantillaBase.ValordelControl = ""
        Me.txtPlantillaBase.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPlantillaBase.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPlantillaBase.ValorPredeterminado = Nothing
        Me.txtPlantillaBase.Visible = False
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(7, 132)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(74, 30)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "Salir"
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(7, 96)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(74, 30)
        Me.btnEliminar.TabIndex = 3
        Me.btnEliminar.Text = "Eliminar"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnLimpiar.Appearance.Options.UseFont = True
        Me.btnLimpiar.Location = New System.Drawing.Point(7, 60)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(74, 30)
        Me.btnLimpiar.TabIndex = 2
        Me.btnLimpiar.Text = "Limpiar"
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Location = New System.Drawing.Point(7, 24)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(74, 30)
        Me.btnGuardar.TabIndex = 1
        Me.btnGuardar.Text = "Guardar"
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
        Me.GroupControl1.Controls.Add(Me.btnGuardar)
        Me.GroupControl1.Controls.Add(Me.btnEliminar)
        Me.GroupControl1.Controls.Add(Me.btnLimpiar)
        Me.GroupControl1.Location = New System.Drawing.Point(970, 6)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(88, 504)
        Me.GroupControl1.TabIndex = 3
        Me.GroupControl1.TabStop = True
        Me.GroupControl1.Text = "Opciones"
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LayoutControl2.Controls.Add(Me.gcConceptosProvision)
        Me.LayoutControl2.Controls.Add(Me.gbxConceptos)
        Me.LayoutControl2.Controls.Add(Me.gbxPlantillas)
        Me.LayoutControl2.Location = New System.Drawing.Point(5, 5)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.OptionsView.UseDefaultDragAndDropRendering = False
        Me.LayoutControl2.Root = Me.LayoutControlGroup2
        Me.LayoutControl2.Size = New System.Drawing.Size(960, 506)
        Me.LayoutControl2.TabIndex = 95
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'gcConceptosProvision
        '
        Me.gcConceptosProvision.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.gcConceptosProvision.AppearanceCaption.Options.UseFont = True
        Me.gcConceptosProvision.Controls.Add(Me.btnAggConceptosProv)
        Me.gcConceptosProvision.Controls.Add(Me.txtConceptosPlantProv)
        Me.gcConceptosProvision.Controls.Add(Me.btnEliminarConceptoProv)
        Me.gcConceptosProvision.Controls.Add(Me.gcConceptosPlantProvision)
        Me.gcConceptosProvision.Location = New System.Drawing.Point(482, 255)
        Me.gcConceptosProvision.Name = "gcConceptosProvision"
        Me.gcConceptosProvision.Size = New System.Drawing.Size(476, 249)
        Me.gcConceptosProvision.TabIndex = 4
        Me.gcConceptosProvision.Text = "Conceptos de provision del perfil"
        '
        'btnAggConceptosProv
        '
        Me.btnAggConceptosProv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAggConceptosProv.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnAggConceptosProv.Appearance.Options.UseFont = True
        Me.btnAggConceptosProv.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnAggConceptosProv.Location = New System.Drawing.Point(385, 28)
        Me.btnAggConceptosProv.Name = "btnAggConceptosProv"
        Me.btnAggConceptosProv.Size = New System.Drawing.Size(40, 26)
        Me.btnAggConceptosProv.TabIndex = 5
        '
        'txtConceptosPlantProv
        '
        Me.txtConceptosPlantProv.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtConceptosPlantProv.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtConceptosPlantProv.AltodelControl = 30
        Me.txtConceptosPlantProv.AnchoLabel = 100
        Me.txtConceptosPlantProv.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtConceptosPlantProv.AnchoTxt = 80
        Me.txtConceptosPlantProv.AutoCargarDatos = True
        Me.txtConceptosPlantProv.AutoSize = True
        Me.txtConceptosPlantProv.BackColor = System.Drawing.Color.Transparent
        Me.txtConceptosPlantProv.ColorFondo = System.Drawing.Color.Transparent
        Me.txtConceptosPlantProv.CondicionValida = ""
        Me.txtConceptosPlantProv.Conexion = SamitCtlNet.ConexionSAMIT.ConexModulo
        Me.txtConceptosPlantProv.ConsultaSQL = Nothing
        Me.txtConceptosPlantProv.EsObligatorio = False
        Me.txtConceptosPlantProv.FormatoNumero = Nothing
        Me.txtConceptosPlantProv.Location = New System.Drawing.Point(5, 25)
        Me.txtConceptosPlantProv.MaximoAncho = 0
        Me.txtConceptosPlantProv.MensajedeAyuda = Nothing
        Me.txtConceptosPlantProv.Name = "txtConceptosPlantProv"
        Me.txtConceptosPlantProv.Size = New System.Drawing.Size(374, 30)
        Me.txtConceptosPlantProv.SoloLectura = False
        Me.txtConceptosPlantProv.SoloNumeros = True
        Me.txtConceptosPlantProv.TabIndex = 4
        Me.txtConceptosPlantProv.TextodelControl = ""
        Me.txtConceptosPlantProv.TextoLabel = "Conceptos :"
        Me.txtConceptosPlantProv.TieneErrorControl = False
        Me.txtConceptosPlantProv.TipoBusqueda = SamitCtlNet.ModGeneral.TipoBusqueda.Ninguna
        Me.txtConceptosPlantProv.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtConceptosPlantProv.TipodeLetra = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConceptosPlantProv.ValordelControl = ""
        Me.txtConceptosPlantProv.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtConceptosPlantProv.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtConceptosPlantProv.ValorPredeterminado = Nothing
        '
        'btnEliminarConceptoProv
        '
        Me.btnEliminarConceptoProv.AllowFocus = False
        Me.btnEliminarConceptoProv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminarConceptoProv.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnEliminarConceptoProv.Appearance.Options.UseFont = True
        Me.btnEliminarConceptoProv.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnEliminarConceptoProv.Location = New System.Drawing.Point(431, 28)
        Me.btnEliminarConceptoProv.Name = "btnEliminarConceptoProv"
        Me.btnEliminarConceptoProv.Size = New System.Drawing.Size(40, 26)
        Me.btnEliminarConceptoProv.TabIndex = 6
        '
        'gcConceptosPlantProvision
        '
        Me.gcConceptosPlantProvision.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcConceptosPlantProvision.Location = New System.Drawing.Point(0, 60)
        Me.gcConceptosPlantProvision.MainView = Me.gvConceptosProvision
        Me.gcConceptosPlantProvision.Name = "gcConceptosPlantProvision"
        Me.gcConceptosPlantProvision.Size = New System.Drawing.Size(476, 189)
        Me.gcConceptosPlantProvision.TabIndex = 7
        Me.gcConceptosPlantProvision.TabStop = False
        Me.gcConceptosPlantProvision.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvConceptosProvision})
        '
        'gvConceptosProvision
        '
        Me.gvConceptosProvision.GridControl = Me.gcConceptosPlantProvision
        Me.gvConceptosProvision.Name = "gvConceptosProvision"
        Me.gvConceptosProvision.OptionsView.ShowGroupPanel = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3})
        Me.LayoutControlGroup2.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        ColumnDefinition1.SizeType = System.Windows.Forms.SizeType.Percent
        ColumnDefinition1.Width = 50.0R
        ColumnDefinition2.SizeType = System.Windows.Forms.SizeType.Percent
        ColumnDefinition2.Width = 50.0R
        Me.LayoutControlGroup2.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(New DevExpress.XtraLayout.ColumnDefinition() {ColumnDefinition1, ColumnDefinition2})
        RowDefinition1.Height = 50.0R
        RowDefinition1.SizeType = System.Windows.Forms.SizeType.Percent
        RowDefinition2.Height = 50.0R
        RowDefinition2.SizeType = System.Windows.Forms.SizeType.Percent
        Me.LayoutControlGroup2.OptionsTableLayoutGroup.RowDefinitions.AddRange(New DevExpress.XtraLayout.RowDefinition() {RowDefinition1, RowDefinition2})
        Me.LayoutControlGroup2.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(960, 506)
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.gbxPlantillas
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.OptionsTableLayoutItem.RowSpan = 2
        Me.LayoutControlItem1.Size = New System.Drawing.Size(480, 506)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.gbxConceptos
        Me.LayoutControlItem2.Location = New System.Drawing.Point(480, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.OptionsTableLayoutItem.ColumnIndex = 1
        Me.LayoutControlItem2.Size = New System.Drawing.Size(480, 253)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.gcConceptosProvision
        Me.LayoutControlItem3.Location = New System.Drawing.Point(480, 253)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.OptionsTableLayoutItem.ColumnIndex = 1
        Me.LayoutControlItem3.OptionsTableLayoutItem.RowIndex = 1
        Me.LayoutControlItem3.Size = New System.Drawing.Size(480, 253)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'FrmAggPlantillas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1064, 518)
        Me.Controls.Add(Me.LayoutControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.IconOptions.Icon = CType(resources.GetObject("FrmAggPlantillas.IconOptions.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(885, 545)
        Me.Name = "FrmAggPlantillas"
        Me.Text = "Perfil de Conceptos"
        CType(Me.gbxConceptos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxConceptos.ResumeLayout(False)
        Me.gbxConceptos.PerformLayout()
        CType(Me.gcConceptos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvConceptos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gbxPlantillas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxPlantillas.ResumeLayout(False)
        Me.gbxPlantillas.PerformLayout()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grbVigente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcPlantillas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvPlantillas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBusqueda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.gcConceptosProvision, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gcConceptosProvision.ResumeLayout(False)
        Me.gcConceptosProvision.PerformLayout()
        CType(Me.gcConceptosPlantProvision, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvConceptosProvision, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbxConceptos As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnEliminarConcepto As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gcConceptos As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvConceptos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gbxPlantillas As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblVigente As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grbVigente As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents gcPlantillas As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvPlantillas As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtBusqueda As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNombre As SamitCtlNet.SamitTexto
    Friend WithEvents txtConceptos As SamitCtlNet.SamitBusq
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnLimpiar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SeparatorControl1 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents btnAggConceptos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblUsaPlantillaBase As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnCargarPlantilla As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtPlantillaBase As SamitCtlNet.SamitBusq
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents gcConceptosProvision As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents btnAggConceptosProv As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtConceptosPlantProv As SamitCtlNet.SamitBusq
    Friend WithEvents btnEliminarConceptoProv As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gcConceptosPlantProvision As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvConceptosProvision As DevExpress.XtraGrid.Views.Grid.GridView
End Class
