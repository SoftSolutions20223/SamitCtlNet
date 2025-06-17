<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultaLiquidaciones
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConsultaLiquidaciones))
        Me.grbTipoConsul = New DevExpress.XtraEditors.RadioGroup()
        Me.gcPrincipal = New DevExpress.XtraEditors.GroupControl()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.txtTipoContrato = New SamitCtlNet.SamitBusq()
        Me.txtNominas = New SamitCtlNet.SamitBusq()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.txtAño = New SamitCtlNet.SamitTexto()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.txtOficina = New SamitCtlNet.SamitBusq()
        Me.gcLiquidaciones = New DevExpress.XtraGrid.GridControl()
        Me.gvLiquidaciones = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gbxOpciones = New DevExpress.XtraEditors.GroupControl()
        Me.menuImprimir = New DevExpress.XtraEditors.DropDownButton()
        Me.pMenuImprimir = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.btnImpDetallado = New DevExpress.XtraBars.BarButtonItem()
        Me.btnImpBasica = New DevExpress.XtraBars.BarButtonItem()
        Me.btnImpTotalesXperiodo = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.btnImpDesprendible = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAnular = New DevExpress.XtraEditors.SimpleButton()
        Me.btnContabilizar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDetalles = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.btnBuscar = New DevExpress.XtraEditors.SimpleButton()
        Me.bntEnviarDian = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.grbTipoConsul.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gcPrincipal.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.gcLiquidaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvLiquidaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gbxOpciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxOpciones.SuspendLayout()
        CType(Me.pMenuImprimir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grbTipoConsul
        '
        Me.grbTipoConsul.EditValue = False
        Me.grbTipoConsul.Location = New System.Drawing.Point(3, 20)
        Me.grbTipoConsul.Name = "grbTipoConsul"
        Me.grbTipoConsul.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.grbTipoConsul.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.grbTipoConsul.Properties.Appearance.Options.UseBackColor = True
        Me.grbTipoConsul.Properties.Appearance.Options.UseFont = True
        Me.grbTipoConsul.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.grbTipoConsul.Properties.Columns = 4
        Me.grbTipoConsul.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.grbTipoConsul.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "Periodos Liquidados"), New DevExpress.XtraEditors.Controls.RadioGroupItem(True, "Semestres Liquidados"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Liquidaciones Extraordinarias"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Liquidaciones de Contratos")})
        Me.grbTipoConsul.Size = New System.Drawing.Size(809, 34)
        Me.grbTipoConsul.TabIndex = 7
        '
        'gcPrincipal
        '
        Me.gcPrincipal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcPrincipal.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.gcPrincipal.AppearanceCaption.Options.UseFont = True
        Me.gcPrincipal.Controls.Add(Me.TableLayoutPanel2)
        Me.gcPrincipal.Controls.Add(Me.grbTipoConsul)
        Me.gcPrincipal.Location = New System.Drawing.Point(5, 9)
        Me.gcPrincipal.Name = "gcPrincipal"
        Me.gcPrincipal.Size = New System.Drawing.Size(1208, 97)
        Me.gcPrincipal.TabIndex = 8
        Me.gcPrincipal.Text = "Parámetros busqueda"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.PanelControl4, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.PanelControl2, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.PanelControl3, 1, 0)
        Me.TableLayoutPanel2.ForeColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(5, 52)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1196, 38)
        Me.TableLayoutPanel2.TabIndex = 8
        '
        'PanelControl4
        '
        Me.PanelControl4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl4.Controls.Add(Me.txtTipoContrato)
        Me.PanelControl4.Controls.Add(Me.txtNominas)
        Me.PanelControl4.Location = New System.Drawing.Point(720, 3)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(473, 32)
        Me.PanelControl4.TabIndex = 3
        '
        'txtTipoContrato
        '
        Me.txtTipoContrato.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtTipoContrato.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtTipoContrato.AltodelControl = 30
        Me.txtTipoContrato.AnchoLabel = 110
        Me.txtTipoContrato.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTipoContrato.AnchoTxt = 50
        Me.txtTipoContrato.AutoCargarDatos = True
        Me.txtTipoContrato.AutoSize = True
        Me.txtTipoContrato.BackColor = System.Drawing.Color.Transparent
        Me.txtTipoContrato.ColorFondo = System.Drawing.Color.Transparent
        Me.txtTipoContrato.CondicionValida = ""
        Me.txtTipoContrato.Conexion = SamitCtlNet.ConexionSAMIT.ConexModulo
        Me.txtTipoContrato.ConsultaSQL = Nothing
        Me.txtTipoContrato.EsObligatorio = False
        Me.txtTipoContrato.FormatoNumero = Nothing
        Me.txtTipoContrato.Location = New System.Drawing.Point(3, 2)
        Me.txtTipoContrato.MaximoAncho = 0
        Me.txtTipoContrato.MensajedeAyuda = Nothing
        Me.txtTipoContrato.Name = "txtTipoContrato"
        Me.txtTipoContrato.Size = New System.Drawing.Size(467, 30)
        Me.txtTipoContrato.SoloLectura = False
        Me.txtTipoContrato.SoloNumeros = True
        Me.txtTipoContrato.TabIndex = 3
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
        'txtNominas
        '
        Me.txtNominas.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtNominas.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtNominas.AltodelControl = 30
        Me.txtNominas.AnchoLabel = 85
        Me.txtNominas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNominas.AnchoTxt = 50
        Me.txtNominas.AutoCargarDatos = True
        Me.txtNominas.AutoSize = True
        Me.txtNominas.BackColor = System.Drawing.Color.Transparent
        Me.txtNominas.ColorFondo = System.Drawing.Color.Transparent
        Me.txtNominas.CondicionValida = ""
        Me.txtNominas.Conexion = SamitCtlNet.ConexionSAMIT.ConexModulo
        Me.txtNominas.ConsultaSQL = Nothing
        Me.txtNominas.EsObligatorio = False
        Me.txtNominas.FormatoNumero = Nothing
        Me.txtNominas.Location = New System.Drawing.Point(3, 2)
        Me.txtNominas.MaximoAncho = 0
        Me.txtNominas.MensajedeAyuda = Nothing
        Me.txtNominas.Name = "txtNominas"
        Me.txtNominas.Size = New System.Drawing.Size(467, 30)
        Me.txtNominas.SoloLectura = False
        Me.txtNominas.SoloNumeros = True
        Me.txtNominas.TabIndex = 4
        Me.txtNominas.TextodelControl = ""
        Me.txtNominas.TextoLabel = "Nominas :"
        Me.txtNominas.TieneErrorControl = False
        Me.txtNominas.TipoBusqueda = SamitCtlNet.ModGeneral.TipoBusqueda.Ninguna
        Me.txtNominas.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtNominas.TipodeLetra = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNominas.ValordelControl = ""
        Me.txtNominas.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNominas.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNominas.ValorPredeterminado = Nothing
        '
        'PanelControl2
        '
        Me.PanelControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Controls.Add(Me.txtAño)
        Me.PanelControl2.Location = New System.Drawing.Point(3, 3)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(233, 32)
        Me.PanelControl2.TabIndex = 1
        '
        'txtAño
        '
        Me.txtAño.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtAño.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtAño.AltodelControl = 30
        Me.txtAño.AnchoLabel = 70
        Me.txtAño.AutoSize = True
        Me.txtAño.BackColor = System.Drawing.Color.Transparent
        Me.txtAño.ColordeFondo = System.Drawing.Color.Transparent
        Me.txtAño.EsObligatorio = False
        Me.txtAño.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAño.FormatoNumero = Nothing
        Me.txtAño.Location = New System.Drawing.Point(3, 1)
        Me.txtAño.MaximoAncho = 0
        Me.txtAño.MensajedeAyuda = ""
        Me.txtAño.Name = "txtAño"
        Me.txtAño.Size = New System.Drawing.Size(195, 30)
        Me.txtAño.SoloLectura = False
        Me.txtAño.SoloNumeros = False
        Me.txtAño.TabIndex = 1
        Me.txtAño.TextodelControl = ""
        Me.txtAño.TextoLabel = "Año :"
        Me.txtAño.TieneErrorControl = False
        Me.txtAño.TipodeDatos = SamitCtlNet.TipodeDato.Numeros
        Me.txtAño.TipodeLetra = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAño.ValordelControl = Nothing
        Me.txtAño.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtAño.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtAño.ValorPredeterminado = Nothing
        '
        'PanelControl3
        '
        Me.PanelControl3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl3.Controls.Add(Me.txtOficina)
        Me.PanelControl3.Location = New System.Drawing.Point(242, 3)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(472, 32)
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
        Me.txtOficina.Size = New System.Drawing.Size(466, 30)
        Me.txtOficina.SoloLectura = False
        Me.txtOficina.SoloNumeros = True
        Me.txtOficina.TabIndex = 2
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
        'gcLiquidaciones
        '
        Me.gcLiquidaciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcLiquidaciones.Location = New System.Drawing.Point(5, 112)
        Me.gcLiquidaciones.MainView = Me.gvLiquidaciones
        Me.gcLiquidaciones.Name = "gcLiquidaciones"
        Me.gcLiquidaciones.Size = New System.Drawing.Size(1208, 544)
        Me.gcLiquidaciones.TabIndex = 9
        Me.gcLiquidaciones.TabStop = False
        Me.gcLiquidaciones.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvLiquidaciones})
        '
        'gvLiquidaciones
        '
        Me.gvLiquidaciones.GridControl = Me.gcLiquidaciones
        Me.gvLiquidaciones.Name = "gvLiquidaciones"
        Me.gvLiquidaciones.OptionsView.ShowGroupPanel = False
        '
        'gbxOpciones
        '
        Me.gbxOpciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxOpciones.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.gbxOpciones.AppearanceCaption.Options.UseFont = True
        Me.gbxOpciones.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.gbxOpciones.CaptionImageOptions.Padding = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.gbxOpciones.Controls.Add(Me.bntEnviarDian)
        Me.gbxOpciones.Controls.Add(Me.menuImprimir)
        Me.gbxOpciones.Controls.Add(Me.btnAnular)
        Me.gbxOpciones.Controls.Add(Me.btnContabilizar)
        Me.gbxOpciones.Controls.Add(Me.btnDetalles)
        Me.gbxOpciones.Controls.Add(Me.btnSalir)
        Me.gbxOpciones.Controls.Add(Me.btnBuscar)
        Me.gbxOpciones.Location = New System.Drawing.Point(1220, 9)
        Me.gbxOpciones.Name = "gbxOpciones"
        Me.gbxOpciones.Size = New System.Drawing.Size(88, 647)
        Me.gbxOpciones.TabIndex = 10
        Me.gbxOpciones.Text = "Opciones"
        '
        'menuImprimir
        '
        Me.menuImprimir.DropDownControl = Me.pMenuImprimir
        Me.menuImprimir.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.menuImprimir.Location = New System.Drawing.Point(7, 294)
        Me.menuImprimir.MenuManager = Me.BarManager1
        Me.menuImprimir.Name = "menuImprimir"
        Me.BarManager1.SetPopupContextMenu(Me.menuImprimir, Me.pMenuImprimir)
        Me.menuImprimir.Size = New System.Drawing.Size(74, 48)
        Me.menuImprimir.TabIndex = 5
        Me.menuImprimir.Text = "Imprimir"
        '
        'pMenuImprimir
        '
        Me.pMenuImprimir.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnImpDetallado), New DevExpress.XtraBars.LinkPersistInfo(Me.btnImpBasica), New DevExpress.XtraBars.LinkPersistInfo(Me.btnImpTotalesXperiodo), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1)})
        Me.pMenuImprimir.Manager = Me.BarManager1
        Me.pMenuImprimir.MenuDrawMode = DevExpress.XtraBars.MenuDrawMode.SmallImagesText
        Me.pMenuImprimir.Name = "pMenuImprimir"
        '
        'btnImpDetallado
        '
        Me.btnImpDetallado.Caption = "Inf. Detallada"
        Me.btnImpDetallado.Id = 1
        Me.btnImpDetallado.ImageOptions.Image = CType(resources.GetObject("btnImpDetallado.ImageOptions.Image"), System.Drawing.Image)
        Me.btnImpDetallado.ImageOptions.LargeImage = CType(resources.GetObject("btnImpDetallado.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnImpDetallado.Name = "btnImpDetallado"
        '
        'btnImpBasica
        '
        Me.btnImpBasica.Caption = "Inf. Básica"
        Me.btnImpBasica.Id = 2
        Me.btnImpBasica.ImageOptions.Image = CType(resources.GetObject("btnImpBasica.ImageOptions.Image"), System.Drawing.Image)
        Me.btnImpBasica.ImageOptions.LargeImage = CType(resources.GetObject("btnImpBasica.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnImpBasica.Name = "btnImpBasica"
        '
        'btnImpTotalesXperiodo
        '
        Me.btnImpTotalesXperiodo.Caption = "Totales x periodo"
        Me.btnImpTotalesXperiodo.Id = 3
        Me.btnImpTotalesXperiodo.ImageOptions.Image = CType(resources.GetObject("btnImpTotalesXperiodo.ImageOptions.Image"), System.Drawing.Image)
        Me.btnImpTotalesXperiodo.ImageOptions.LargeImage = CType(resources.GetObject("btnImpTotalesXperiodo.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnImpTotalesXperiodo.Name = "btnImpTotalesXperiodo"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Totales x concepto"
        Me.BarButtonItem1.Id = 4
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarManager1
        '
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnImpDesprendible, Me.btnImpDetallado, Me.btnImpBasica, Me.btnImpTotalesXperiodo, Me.BarButtonItem1})
        Me.BarManager1.MaxItemId = 5
        Me.BarManager1.ShowCloseButton = True
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1312, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 660)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1312, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 660)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1312, 0)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 660)
        '
        'btnImpDesprendible
        '
        Me.btnImpDesprendible.Caption = "Desprendible"
        Me.btnImpDesprendible.Id = 0
        Me.btnImpDesprendible.ImageOptions.Image = CType(resources.GetObject("btnImpDesprendible.ImageOptions.Image"), System.Drawing.Image)
        Me.btnImpDesprendible.ImageOptions.LargeImage = CType(resources.GetObject("btnImpDesprendible.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnImpDesprendible.Name = "btnImpDesprendible"
        '
        'btnAnular
        '
        Me.btnAnular.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnAnular.Appearance.Options.UseFont = True
        Me.btnAnular.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnAnular.Location = New System.Drawing.Point(7, 240)
        Me.btnAnular.Name = "btnAnular"
        Me.btnAnular.Size = New System.Drawing.Size(74, 48)
        Me.btnAnular.TabIndex = 4
        Me.btnAnular.Text = "Anular"
        '
        'btnContabilizar
        '
        Me.btnContabilizar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnContabilizar.Appearance.Options.UseFont = True
        Me.btnContabilizar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnContabilizar.Location = New System.Drawing.Point(7, 132)
        Me.btnContabilizar.Name = "btnContabilizar"
        Me.btnContabilizar.Size = New System.Drawing.Size(74, 48)
        Me.btnContabilizar.TabIndex = 3
        Me.btnContabilizar.Text = "Contabilizar"
        '
        'btnDetalles
        '
        Me.btnDetalles.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnDetalles.Appearance.Options.UseFont = True
        Me.btnDetalles.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnDetalles.Location = New System.Drawing.Point(7, 78)
        Me.btnDetalles.Name = "btnDetalles"
        Me.btnDetalles.Size = New System.Drawing.Size(74, 48)
        Me.btnDetalles.TabIndex = 2
        Me.btnDetalles.Text = "Detalles"
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(7, 349)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(74, 48)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "Salir"
        '
        'btnBuscar
        '
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnBuscar.Location = New System.Drawing.Point(7, 24)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(74, 48)
        Me.btnBuscar.TabIndex = 1
        Me.btnBuscar.Text = "Buscar"
        '
        'bntEnviarDian
        '
        Me.bntEnviarDian.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.bntEnviarDian.Appearance.Options.UseFont = True
        Me.bntEnviarDian.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.bntEnviarDian.Location = New System.Drawing.Point(7, 186)
        Me.bntEnviarDian.Name = "bntEnviarDian"
        Me.bntEnviarDian.Size = New System.Drawing.Size(74, 48)
        Me.bntEnviarDian.TabIndex = 7
        Me.bntEnviarDian.Text = "Enviar Dian"
        '
        'FrmConsultaLiquidaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1312, 660)
        Me.Controls.Add(Me.gbxOpciones)
        Me.Controls.Add(Me.gcLiquidaciones)
        Me.Controls.Add(Me.gcPrincipal)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.IconOptions.Icon = CType(resources.GetObject("FrmConsultaLiquidaciones.IconOptions.Icon"), System.Drawing.Icon)
        Me.Name = "FrmConsultaLiquidaciones"
        Me.Text = "Consultar Liquidaciones"
        CType(Me.grbTipoConsul.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gcPrincipal.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        Me.PanelControl4.PerformLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.PanelControl3.PerformLayout()
        CType(Me.gcLiquidaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvLiquidaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gbxOpciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxOpciones.ResumeLayout(False)
        CType(Me.pMenuImprimir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grbTipoConsul As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents gcPrincipal As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtNominas As SamitCtlNet.SamitBusq
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtAño As SamitCtlNet.SamitTexto
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtOficina As SamitCtlNet.SamitBusq
    Friend WithEvents gcLiquidaciones As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvLiquidaciones As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gbxOpciones As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAnular As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnContabilizar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDetalles As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtTipoContrato As SamitCtlNet.SamitBusq
    Friend WithEvents menuImprimir As DevExpress.XtraEditors.DropDownButton
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents btnImpDesprendible As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnImpDetallado As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnImpBasica As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnImpTotalesXperiodo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents pMenuImprimir As DevExpress.XtraBars.PopupMenu
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bntEnviarDian As DevExpress.XtraEditors.SimpleButton
End Class
