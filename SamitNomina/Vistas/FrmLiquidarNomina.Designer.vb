<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLiquidarNomina
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLiquidarNomina))
        Me.gcLiquidaNomina = New DevExpress.XtraGrid.GridControl()
        Me.gvLiquidaNomina = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.vgIngresosDeducciones = New DevExpress.XtraVerticalGrid.VGridControl()
        Me.gcPrincipal = New DevExpress.XtraEditors.GroupControl()
        Me.txtAño = New SamitCtlNet.SamitTexto()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.PanelControl7 = New DevExpress.XtraEditors.PanelControl()
        Me.txtPeriodos = New SamitCtlNet.SamitBusq()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.txtNominas = New SamitCtlNet.SamitBusq()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.txtOficina = New SamitCtlNet.SamitBusq()
        Me.btnBuscar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnBorradores = New DevExpress.XtraEditors.SimpleButton()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.PanelControl10 = New DevExpress.XtraEditors.PanelControl()
        Me.vgProviciones = New DevExpress.XtraVerticalGrid.VGridControl()
        Me.PanelControl11 = New DevExpress.XtraEditors.PanelControl()
        Me.vgDescPorNomina = New DevExpress.XtraVerticalGrid.VGridControl()
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.btnLimpiar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnLiquidar = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.BtnExcell = New DevExpress.XtraEditors.SimpleButton()
        Me.menuImprimir = New DevExpress.XtraEditors.DropDownButton()
        Me.pMenuImprimir = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.btnImpDetallado = New DevExpress.XtraBars.BarButtonItem()
        Me.btnImpBasica = New DevExpress.XtraBars.BarButtonItem()
        Me.btnImpTotalesXperiodo = New DevExpress.XtraBars.BarButtonItem()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.btnImpDesprendible = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEliminarBorrador = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.gcLiquidaNomina, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvLiquidaNomina, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vgIngresosDeducciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gcPrincipal.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.PanelControl7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl7.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me.PanelControl10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl10.SuspendLayout()
        CType(Me.vgProviciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl11.SuspendLayout()
        CType(Me.vgDescPorNomina, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.pMenuImprimir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gcLiquidaNomina
        '
        Me.gcLiquidaNomina.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcLiquidaNomina.Location = New System.Drawing.Point(0, 0)
        Me.gcLiquidaNomina.MainView = Me.gvLiquidaNomina
        Me.gcLiquidaNomina.Name = "gcLiquidaNomina"
        Me.gcLiquidaNomina.Size = New System.Drawing.Size(1008, 293)
        Me.gcLiquidaNomina.TabIndex = 0
        Me.gcLiquidaNomina.TabStop = False
        Me.gcLiquidaNomina.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvLiquidaNomina})
        '
        'gvLiquidaNomina
        '
        Me.gvLiquidaNomina.GridControl = Me.gcLiquidaNomina
        Me.gvLiquidaNomina.Name = "gvLiquidaNomina"
        Me.gvLiquidaNomina.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.gvLiquidaNomina.OptionsView.ShowGroupPanel = False
        '
        'vgIngresosDeducciones
        '
        Me.vgIngresosDeducciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.vgIngresosDeducciones.Location = New System.Drawing.Point(0, 0)
        Me.vgIngresosDeducciones.Name = "vgIngresosDeducciones"
        Me.vgIngresosDeducciones.Size = New System.Drawing.Size(331, 193)
        Me.vgIngresosDeducciones.TabIndex = 0
        Me.vgIngresosDeducciones.TabStop = False
        '
        'gcPrincipal
        '
        Me.gcPrincipal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcPrincipal.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.gcPrincipal.AppearanceCaption.Options.UseFont = True
        Me.gcPrincipal.Controls.Add(Me.txtAño)
        Me.gcPrincipal.Controls.Add(Me.TableLayoutPanel3)
        Me.gcPrincipal.Controls.Add(Me.TableLayoutPanel2)
        Me.gcPrincipal.Location = New System.Drawing.Point(8, 6)
        Me.gcPrincipal.Name = "gcPrincipal"
        Me.gcPrincipal.Size = New System.Drawing.Size(1009, 101)
        Me.gcPrincipal.TabIndex = 1
        Me.gcPrincipal.Text = "Parámetros busqueda"
        '
        'txtAño
        '
        Me.txtAño.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtAño.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtAño.AltodelControl = 30
        Me.txtAño.AnchoLabel = 80
        Me.txtAño.AutoSize = True
        Me.txtAño.BackColor = System.Drawing.Color.Transparent
        Me.txtAño.ColordeFondo = System.Drawing.Color.Transparent
        Me.txtAño.EsObligatorio = False
        Me.txtAño.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAño.FormatoNumero = Nothing
        Me.txtAño.Location = New System.Drawing.Point(6, 27)
        Me.txtAño.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtAño.MaximoAncho = 0
        Me.txtAño.MensajedeAyuda = ""
        Me.txtAño.Name = "txtAño"
        Me.txtAño.Size = New System.Drawing.Size(180, 30)
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
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.86567!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.13433!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.PanelControl7, 0, 0)
        Me.TableLayoutPanel3.ForeColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(2, 59)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1005, 38)
        Me.TableLayoutPanel3.TabIndex = 2
        '
        'PanelControl7
        '
        Me.PanelControl7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl7.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl7.Controls.Add(Me.txtPeriodos)
        Me.PanelControl7.Location = New System.Drawing.Point(3, 3)
        Me.PanelControl7.Name = "PanelControl7"
        Me.PanelControl7.Size = New System.Drawing.Size(665, 32)
        Me.PanelControl7.TabIndex = 0
        '
        'txtPeriodos
        '
        Me.txtPeriodos.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtPeriodos.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtPeriodos.AltodelControl = 30
        Me.txtPeriodos.AnchoLabel = 80
        Me.txtPeriodos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPeriodos.AnchoTxt = 98
        Me.txtPeriodos.AutoCargarDatos = True
        Me.txtPeriodos.AutoSize = True
        Me.txtPeriodos.BackColor = System.Drawing.Color.Transparent
        Me.txtPeriodos.ColorFondo = System.Drawing.Color.Transparent
        Me.txtPeriodos.CondicionValida = ""
        Me.txtPeriodos.Conexion = SamitCtlNet.ConexionSAMIT.ConexModulo
        Me.txtPeriodos.ConsultaSQL = Nothing
        Me.txtPeriodos.DatosDefecto = Nothing
        Me.txtPeriodos.EsObligatorio = False
        Me.txtPeriodos.FormatoNumero = Nothing
        Me.txtPeriodos.ListaColumnas = Nothing
        Me.txtPeriodos.Location = New System.Drawing.Point(1, 1)
        Me.txtPeriodos.MaximoAncho = 0
        Me.txtPeriodos.MensajedeAyuda = Nothing
        Me.txtPeriodos.Name = "txtPeriodos"
        Me.txtPeriodos.Size = New System.Drawing.Size(446, 30)
        Me.txtPeriodos.SoloLectura = False
        Me.txtPeriodos.SoloNumeros = True
        Me.txtPeriodos.TabIndex = 1
        Me.txtPeriodos.TextodelControl = ""
        Me.txtPeriodos.TextoLabel = "Periodo :"
        Me.txtPeriodos.TieneErrorControl = False
        Me.txtPeriodos.TipoBusqueda = SamitCtlNet.ModGeneral.TipoBusqueda.Ninguna
        Me.txtPeriodos.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtPeriodos.TipodeLetra = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPeriodos.ValordelControl = ""
        Me.txtPeriodos.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPeriodos.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPeriodos.ValorPredeterminado = Nothing
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.PanelControl4, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.PanelControl3, 0, 0)
        Me.TableLayoutPanel2.ForeColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(215, 23)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(789, 38)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'PanelControl4
        '
        Me.PanelControl4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl4.Controls.Add(Me.txtNominas)
        Me.PanelControl4.Location = New System.Drawing.Point(318, 3)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(309, 32)
        Me.PanelControl4.TabIndex = 3
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
        Me.txtNominas.DatosDefecto = Nothing
        Me.txtNominas.EsObligatorio = False
        Me.txtNominas.FormatoNumero = Nothing
        Me.txtNominas.ListaColumnas = Nothing
        Me.txtNominas.Location = New System.Drawing.Point(3, -2)
        Me.txtNominas.MaximoAncho = 0
        Me.txtNominas.MensajedeAyuda = Nothing
        Me.txtNominas.Name = "txtNominas"
        Me.txtNominas.Size = New System.Drawing.Size(303, 30)
        Me.txtNominas.SoloLectura = False
        Me.txtNominas.SoloNumeros = True
        Me.txtNominas.TabIndex = 1
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
        'PanelControl3
        '
        Me.PanelControl3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl3.Controls.Add(Me.txtOficina)
        Me.PanelControl3.Location = New System.Drawing.Point(3, 3)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(309, 32)
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
        Me.txtOficina.DatosDefecto = Nothing
        Me.txtOficina.EsObligatorio = False
        Me.txtOficina.FormatoNumero = Nothing
        Me.txtOficina.ListaColumnas = Nothing
        Me.txtOficina.Location = New System.Drawing.Point(3, 1)
        Me.txtOficina.MaximoAncho = 0
        Me.txtOficina.MensajedeAyuda = Nothing
        Me.txtOficina.Name = "txtOficina"
        Me.txtOficina.Size = New System.Drawing.Size(303, 30)
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
        'btnBuscar
        '
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnBuscar.Location = New System.Drawing.Point(5, 24)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(78, 45)
        Me.btnBuscar.TabIndex = 1
        Me.btnBuscar.Text = "Buscar"
        '
        'btnBorradores
        '
        Me.btnBorradores.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnBorradores.Appearance.Options.UseFont = True
        Me.btnBorradores.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnBorradores.Location = New System.Drawing.Point(5, 75)
        Me.btnBorradores.Name = "btnBorradores"
        Me.btnBorradores.Size = New System.Drawing.Size(78, 45)
        Me.btnBorradores.TabIndex = 2
        Me.btnBorradores.Text = "Borradores"
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(6, 113)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.gcLiquidaNomina)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.TableLayoutPanel4)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1008, 509)
        Me.SplitContainerControl1.SplitterPosition = 293
        Me.SplitContainerControl1.TabIndex = 102
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel4.ColumnCount = 3
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.Controls.Add(Me.PanelControl10, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.PanelControl11, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.vgDescPorNomina, 2, 0)
        Me.TableLayoutPanel4.ForeColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(-1, 7)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(1011, 199)
        Me.TableLayoutPanel4.TabIndex = 3
        '
        'PanelControl10
        '
        Me.PanelControl10.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl10.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl10.Controls.Add(Me.vgProviciones)
        Me.PanelControl10.Location = New System.Drawing.Point(340, 3)
        Me.PanelControl10.Name = "PanelControl10"
        Me.PanelControl10.Size = New System.Drawing.Size(331, 193)
        Me.PanelControl10.TabIndex = 1
        '
        'vgProviciones
        '
        Me.vgProviciones.Cursor = System.Windows.Forms.Cursors.Default
        Me.vgProviciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.vgProviciones.Location = New System.Drawing.Point(0, 0)
        Me.vgProviciones.Name = "vgProviciones"
        Me.vgProviciones.Size = New System.Drawing.Size(331, 193)
        Me.vgProviciones.TabIndex = 1
        Me.vgProviciones.TabStop = False
        '
        'PanelControl11
        '
        Me.PanelControl11.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl11.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl11.Controls.Add(Me.vgIngresosDeducciones)
        Me.PanelControl11.Location = New System.Drawing.Point(3, 3)
        Me.PanelControl11.Name = "PanelControl11"
        Me.PanelControl11.Size = New System.Drawing.Size(331, 193)
        Me.PanelControl11.TabIndex = 0
        '
        'vgDescPorNomina
        '
        Me.vgDescPorNomina.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.vgDescPorNomina.Cursor = System.Windows.Forms.Cursors.Default
        Me.vgDescPorNomina.Location = New System.Drawing.Point(677, 3)
        Me.vgDescPorNomina.Name = "vgDescPorNomina"
        Me.vgDescPorNomina.Size = New System.Drawing.Size(331, 193)
        Me.vgDescPorNomina.TabIndex = 2
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(5, 396)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(78, 45)
        Me.btnSalir.TabIndex = 9
        Me.btnSalir.Text = "Salir"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLimpiar.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnLimpiar.Appearance.Options.UseFont = True
        Me.btnLimpiar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnLimpiar.Location = New System.Drawing.Point(5, 345)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(78, 45)
        Me.btnLimpiar.TabIndex = 8
        Me.btnLimpiar.Text = "Limpiar"
        '
        'btnLiquidar
        '
        Me.btnLiquidar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLiquidar.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnLiquidar.Appearance.Options.UseFont = True
        Me.btnLiquidar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnLiquidar.Location = New System.Drawing.Point(5, 125)
        Me.btnLiquidar.Name = "btnLiquidar"
        Me.btnLiquidar.Size = New System.Drawing.Size(78, 45)
        Me.btnLiquidar.TabIndex = 4
        Me.btnLiquidar.Text = "Liquidar"
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.GroupControl1.CaptionImageOptions.Padding = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.GroupControl1.Controls.Add(Me.BtnExcell)
        Me.GroupControl1.Controls.Add(Me.menuImprimir)
        Me.GroupControl1.Controls.Add(Me.btnEliminarBorrador)
        Me.GroupControl1.Controls.Add(Me.btnSalir)
        Me.GroupControl1.Controls.Add(Me.btnBorradores)
        Me.GroupControl1.Controls.Add(Me.btnLimpiar)
        Me.GroupControl1.Controls.Add(Me.btnBuscar)
        Me.GroupControl1.Controls.Add(Me.btnLiquidar)
        Me.GroupControl1.Location = New System.Drawing.Point(1021, 6)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(88, 606)
        Me.GroupControl1.TabIndex = 2
        Me.GroupControl1.Text = "Opciones"
        '
        'BtnExcell
        '
        Me.BtnExcell.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnExcell.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.BtnExcell.Appearance.Options.UseFont = True
        Me.BtnExcell.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnExcell.Location = New System.Drawing.Point(5, 227)
        Me.BtnExcell.Name = "BtnExcell"
        Me.BtnExcell.Size = New System.Drawing.Size(78, 45)
        Me.BtnExcell.TabIndex = 6
        Me.BtnExcell.Text = "Excell"
        '
        'menuImprimir
        '
        Me.menuImprimir.DropDownControl = Me.pMenuImprimir
        Me.menuImprimir.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.menuImprimir.Location = New System.Drawing.Point(5, 176)
        Me.menuImprimir.MenuManager = Me.BarManager1
        Me.menuImprimir.Name = "menuImprimir"
        Me.BarManager1.SetPopupContextMenu(Me.menuImprimir, Me.pMenuImprimir)
        Me.menuImprimir.Size = New System.Drawing.Size(78, 45)
        Me.menuImprimir.TabIndex = 5
        Me.menuImprimir.Text = "Imprimir"
        '
        'pMenuImprimir
        '
        Me.pMenuImprimir.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnImpDetallado), New DevExpress.XtraBars.LinkPersistInfo(Me.btnImpBasica), New DevExpress.XtraBars.LinkPersistInfo(Me.btnImpTotalesXperiodo)})
        Me.pMenuImprimir.Manager = Me.BarManager1
        Me.pMenuImprimir.MenuDrawMode = DevExpress.XtraBars.MenuDrawMode.SmallImagesText
        Me.pMenuImprimir.Name = "pMenuImprimir"
        '
        'btnImpDetallado
        '
        Me.btnImpDetallado.Caption = "Inf. Detallada"
        Me.btnImpDetallado.Id = 1
        Me.btnImpDetallado.ImageOptions.LargeImage = CType(resources.GetObject("btnImpDetallado.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnImpDetallado.Name = "btnImpDetallado"
        '
        'btnImpBasica
        '
        Me.btnImpBasica.Caption = "Inf. Básica"
        Me.btnImpBasica.Id = 2
        Me.btnImpBasica.ImageOptions.LargeImage = CType(resources.GetObject("btnImpBasica.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnImpBasica.Name = "btnImpBasica"
        '
        'btnImpTotalesXperiodo
        '
        Me.btnImpTotalesXperiodo.Caption = "Totes x periodo"
        Me.btnImpTotalesXperiodo.Id = 3
        Me.btnImpTotalesXperiodo.ImageOptions.LargeImage = CType(resources.GetObject("btnImpTotalesXperiodo.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnImpTotalesXperiodo.Name = "btnImpTotalesXperiodo"
        '
        'BarManager1
        '
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnImpDesprendible, Me.btnImpDetallado, Me.btnImpBasica, Me.btnImpTotalesXperiodo})
        Me.BarManager1.MaxItemId = 4
        Me.BarManager1.ShowCloseButton = True
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1115, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 623)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1115, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 623)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1115, 0)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 623)
        '
        'btnImpDesprendible
        '
        Me.btnImpDesprendible.Caption = "Desprendible"
        Me.btnImpDesprendible.Id = 0
        Me.btnImpDesprendible.ImageOptions.LargeImage = CType(resources.GetObject("btnImpDesprendible.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnImpDesprendible.Name = "btnImpDesprendible"
        '
        'btnEliminarBorrador
        '
        Me.btnEliminarBorrador.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminarBorrador.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnEliminarBorrador.Appearance.Options.UseFont = True
        Me.btnEliminarBorrador.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnEliminarBorrador.Location = New System.Drawing.Point(5, 277)
        Me.btnEliminarBorrador.Name = "btnEliminarBorrador"
        Me.btnEliminarBorrador.Size = New System.Drawing.Size(78, 62)
        Me.btnEliminarBorrador.TabIndex = 7
        Me.btnEliminarBorrador.Text = "Eliminar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Borrador"
        '
        'FrmLiquidarNomina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1115, 623)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.gcPrincipal)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.IconOptions.Icon = CType(resources.GetObject("FrmLiquidarNomina.IconOptions.Icon"), System.Drawing.Icon)
        Me.Name = "FrmLiquidarNomina"
        Me.Text = "Liquidar Periodos"
        CType(Me.gcLiquidaNomina, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvLiquidaNomina, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vgIngresosDeducciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gcPrincipal.ResumeLayout(False)
        Me.gcPrincipal.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        CType(Me.PanelControl7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl7.ResumeLayout(False)
        Me.PanelControl7.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        Me.PanelControl4.PerformLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.PanelControl3.PerformLayout()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        CType(Me.PanelControl10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl10.ResumeLayout(False)
        CType(Me.vgProviciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl11.ResumeLayout(False)
        CType(Me.vgDescPorNomina, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.pMenuImprimir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gcLiquidaNomina As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvLiquidaNomina As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents vgIngresosDeducciones As DevExpress.XtraVerticalGrid.VGridControl
    Friend WithEvents gcPrincipal As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PanelControl7 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtPeriodos As SamitCtlNet.SamitBusq
    Friend WithEvents txtAño As SamitCtlNet.SamitTexto
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnLimpiar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnLiquidar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents vgProviciones As DevExpress.XtraVerticalGrid.VGridControl
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PanelControl10 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl11 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnBorradores As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtOficina As SamitCtlNet.SamitBusq
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtNominas As SamitCtlNet.SamitBusq
    Friend WithEvents btnBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents vgDescPorNomina As DevExpress.XtraVerticalGrid.VGridControl
    Friend WithEvents btnEliminarBorrador As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents menuImprimir As DevExpress.XtraEditors.DropDownButton
    Friend WithEvents pMenuImprimir As DevExpress.XtraBars.PopupMenu
    Friend WithEvents btnImpDesprendible As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnImpDetallado As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnImpBasica As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnImpTotalesXperiodo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BtnExcell As DevExpress.XtraEditors.SimpleButton
End Class
