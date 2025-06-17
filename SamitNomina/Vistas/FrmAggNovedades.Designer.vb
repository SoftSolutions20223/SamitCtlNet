<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAggNovedades
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAggNovedades))
        Me.AgregarNovedades = New DevExpress.XtraEditors.GroupControl()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.txtNominas = New SamitCtlNet.SamitBusq()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.txtAño = New SamitCtlNet.SamitTexto()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.txtOficina = New SamitCtlNet.SamitBusq()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.PanelControl6 = New DevExpress.XtraEditors.PanelControl()
        Me.txtDependencia = New SamitCtlNet.SamitBusq()
        Me.PanelControl7 = New DevExpress.XtraEditors.PanelControl()
        Me.txtPeriodos = New SamitCtlNet.SamitBusq()
        Me.PanelControl8 = New DevExpress.XtraEditors.PanelControl()
        Me.txtCargos = New SamitCtlNet.SamitBusq()
        Me.btnBorradores = New DevExpress.XtraEditors.SimpleButton()
        Me.gcNovedades = New DevExpress.XtraGrid.GridControl()
        Me.gvNovedades = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.btnLimpiar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.btnEliminarBorrador = New DevExpress.XtraEditors.SimpleButton()
        Me.btnBuscar = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.AgregarNovedades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AgregarNovedades.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.PanelControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl6.SuspendLayout()
        CType(Me.PanelControl7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl7.SuspendLayout()
        CType(Me.PanelControl8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl8.SuspendLayout()
        CType(Me.gcNovedades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvNovedades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'AgregarNovedades
        '
        Me.AgregarNovedades.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AgregarNovedades.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.AgregarNovedades.AppearanceCaption.Options.UseFont = True
        Me.AgregarNovedades.Controls.Add(Me.TableLayoutPanel2)
        Me.AgregarNovedades.Controls.Add(Me.TableLayoutPanel3)
        Me.AgregarNovedades.Location = New System.Drawing.Point(6, 6)
        Me.AgregarNovedades.Name = "AgregarNovedades"
        Me.AgregarNovedades.Size = New System.Drawing.Size(1010, 93)
        Me.AgregarNovedades.TabIndex = 1
        Me.AgregarNovedades.Text = "Agregar Novedades"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.Controls.Add(Me.PanelControl4, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.PanelControl2, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.PanelControl3, 1, 0)
        Me.TableLayoutPanel2.ForeColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 19)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1006, 39)
        Me.TableLayoutPanel2.TabIndex = 4
        '
        'PanelControl4
        '
        Me.PanelControl4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl4.Controls.Add(Me.txtNominas)
        Me.PanelControl4.Location = New System.Drawing.Point(673, 3)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(330, 32)
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
        Me.txtNominas.EsObligatorio = False
        Me.txtNominas.FormatoNumero = Nothing
        Me.txtNominas.Location = New System.Drawing.Point(6, 1)
        Me.txtNominas.MaximoAncho = 0
        Me.txtNominas.MensajedeAyuda = Nothing
        Me.txtNominas.Name = "txtNominas"
        Me.txtNominas.Size = New System.Drawing.Size(321, 30)
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
        'PanelControl2
        '
        Me.PanelControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Controls.Add(Me.txtAño)
        Me.PanelControl2.Location = New System.Drawing.Point(3, 3)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(329, 32)
        Me.PanelControl2.TabIndex = 1
        '
        'txtAño
        '
        Me.txtAño.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtAño.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtAño.AltodelControl = 30
        Me.txtAño.AnchoLabel = 120
        Me.txtAño.AutoSize = True
        Me.txtAño.BackColor = System.Drawing.Color.Transparent
        Me.txtAño.ColordeFondo = System.Drawing.Color.Transparent
        Me.txtAño.EsObligatorio = False
        Me.txtAño.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAño.FormatoNumero = Nothing
        Me.txtAño.Location = New System.Drawing.Point(-30, 4)
        Me.txtAño.MaximoAncho = 0
        Me.txtAño.MensajedeAyuda = ""
        Me.txtAño.Name = "txtAño"
        Me.txtAño.Size = New System.Drawing.Size(220, 30)
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
        Me.PanelControl3.Location = New System.Drawing.Point(338, 3)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(329, 32)
        Me.PanelControl3.TabIndex = 2
        '
        'txtOficina
        '
        Me.txtOficina.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtOficina.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtOficina.AltodelControl = 30
        Me.txtOficina.AnchoLabel = 85
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
        Me.txtOficina.Location = New System.Drawing.Point(21, 1)
        Me.txtOficina.MaximoAncho = 0
        Me.txtOficina.MensajedeAyuda = Nothing
        Me.txtOficina.Name = "txtOficina"
        Me.txtOficina.Size = New System.Drawing.Size(305, 30)
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
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.Controls.Add(Me.PanelControl6, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.PanelControl7, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.PanelControl8, 2, 0)
        Me.TableLayoutPanel3.ForeColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 53)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1006, 39)
        Me.TableLayoutPanel3.TabIndex = 5
        '
        'PanelControl6
        '
        Me.PanelControl6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl6.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl6.Controls.Add(Me.txtDependencia)
        Me.PanelControl6.Location = New System.Drawing.Point(338, 3)
        Me.PanelControl6.Name = "PanelControl6"
        Me.PanelControl6.Size = New System.Drawing.Size(329, 32)
        Me.PanelControl6.TabIndex = 1
        '
        'txtDependencia
        '
        Me.txtDependencia.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtDependencia.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtDependencia.AltodelControl = 30
        Me.txtDependencia.AnchoLabel = 120
        Me.txtDependencia.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDependencia.AnchoTxt = 50
        Me.txtDependencia.AutoCargarDatos = True
        Me.txtDependencia.AutoSize = True
        Me.txtDependencia.BackColor = System.Drawing.Color.Transparent
        Me.txtDependencia.ColorFondo = System.Drawing.Color.Transparent
        Me.txtDependencia.CondicionValida = ""
        Me.txtDependencia.Conexion = SamitCtlNet.ConexionSAMIT.ConexModulo
        Me.txtDependencia.ConsultaSQL = Nothing
        Me.txtDependencia.EsObligatorio = False
        Me.txtDependencia.FormatoNumero = Nothing
        Me.txtDependencia.Location = New System.Drawing.Point(-14, 2)
        Me.txtDependencia.MaximoAncho = 0
        Me.txtDependencia.MensajedeAyuda = Nothing
        Me.txtDependencia.Name = "txtDependencia"
        Me.txtDependencia.Size = New System.Drawing.Size(340, 29)
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
        'PanelControl7
        '
        Me.PanelControl7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl7.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl7.Controls.Add(Me.txtPeriodos)
        Me.PanelControl7.Location = New System.Drawing.Point(3, 3)
        Me.PanelControl7.Name = "PanelControl7"
        Me.PanelControl7.Size = New System.Drawing.Size(329, 32)
        Me.PanelControl7.TabIndex = 0
        '
        'txtPeriodos
        '
        Me.txtPeriodos.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtPeriodos.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtPeriodos.AltodelControl = 30
        Me.txtPeriodos.AnchoLabel = 85
        Me.txtPeriodos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPeriodos.AnchoTxt = 100
        Me.txtPeriodos.AutoCargarDatos = True
        Me.txtPeriodos.AutoSize = True
        Me.txtPeriodos.BackColor = System.Drawing.Color.Transparent
        Me.txtPeriodos.ColorFondo = System.Drawing.Color.Transparent
        Me.txtPeriodos.CondicionValida = ""
        Me.txtPeriodos.Conexion = SamitCtlNet.ConexionSAMIT.ConexModulo
        Me.txtPeriodos.ConsultaSQL = Nothing
        Me.txtPeriodos.EsObligatorio = False
        Me.txtPeriodos.FormatoNumero = Nothing
        Me.txtPeriodos.Location = New System.Drawing.Point(4, 2)
        Me.txtPeriodos.MaximoAncho = 0
        Me.txtPeriodos.MensajedeAyuda = Nothing
        Me.txtPeriodos.Name = "txtPeriodos"
        Me.txtPeriodos.Size = New System.Drawing.Size(321, 29)
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
        'PanelControl8
        '
        Me.PanelControl8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl8.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl8.Controls.Add(Me.txtCargos)
        Me.PanelControl8.Location = New System.Drawing.Point(673, 3)
        Me.PanelControl8.Name = "PanelControl8"
        Me.PanelControl8.Size = New System.Drawing.Size(330, 32)
        Me.PanelControl8.TabIndex = 2
        '
        'txtCargos
        '
        Me.txtCargos.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtCargos.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtCargos.AltodelControl = 30
        Me.txtCargos.AnchoLabel = 85
        Me.txtCargos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCargos.AnchoTxt = 50
        Me.txtCargos.AutoCargarDatos = True
        Me.txtCargos.AutoSize = True
        Me.txtCargos.BackColor = System.Drawing.Color.Transparent
        Me.txtCargos.ColorFondo = System.Drawing.Color.Transparent
        Me.txtCargos.CondicionValida = ""
        Me.txtCargos.Conexion = SamitCtlNet.ConexionSAMIT.ConexModulo
        Me.txtCargos.ConsultaSQL = Nothing
        Me.txtCargos.EsObligatorio = False
        Me.txtCargos.FormatoNumero = Nothing
        Me.txtCargos.Location = New System.Drawing.Point(6, 1)
        Me.txtCargos.MaximoAncho = 0
        Me.txtCargos.MensajedeAyuda = Nothing
        Me.txtCargos.Name = "txtCargos"
        Me.txtCargos.Size = New System.Drawing.Size(323, 30)
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
        'btnBorradores
        '
        Me.btnBorradores.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnBorradores.Appearance.Options.UseFont = True
        Me.btnBorradores.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnBorradores.Location = New System.Drawing.Point(5, 75)
        Me.btnBorradores.Name = "btnBorradores"
        Me.btnBorradores.Size = New System.Drawing.Size(78, 45)
        Me.btnBorradores.TabIndex = 2
        Me.btnBorradores.Text = "Borradores"
        '
        'gcNovedades
        '
        Me.gcNovedades.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcNovedades.Location = New System.Drawing.Point(6, 104)
        Me.gcNovedades.MainView = Me.gvNovedades
        Me.gcNovedades.Name = "gcNovedades"
        Me.gcNovedades.Size = New System.Drawing.Size(1010, 511)
        Me.gcNovedades.TabIndex = 1
        Me.gcNovedades.TabStop = False
        Me.gcNovedades.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvNovedades})
        '
        'gvNovedades
        '
        Me.gvNovedades.GridControl = Me.gcNovedades
        Me.gvNovedades.Name = "gvNovedades"
        Me.gvNovedades.OptionsView.ShowGroupPanel = False
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(5, 296)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(78, 45)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "Salir"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLimpiar.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnLimpiar.Appearance.Options.UseFont = True
        Me.btnLimpiar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnLimpiar.Location = New System.Drawing.Point(5, 245)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(78, 45)
        Me.btnLimpiar.TabIndex = 5
        Me.btnLimpiar.Text = "Limpiar"
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnGuardar.Location = New System.Drawing.Point(5, 126)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(78, 45)
        Me.btnGuardar.TabIndex = 3
        Me.btnGuardar.Text = "Guardar"
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.GroupControl1.CaptionImagePadding = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.GroupControl1.Controls.Add(Me.btnEliminarBorrador)
        Me.GroupControl1.Controls.Add(Me.btnBuscar)
        Me.GroupControl1.Controls.Add(Me.btnBorradores)
        Me.GroupControl1.Controls.Add(Me.btnSalir)
        Me.GroupControl1.Controls.Add(Me.btnGuardar)
        Me.GroupControl1.Controls.Add(Me.btnLimpiar)
        Me.GroupControl1.Location = New System.Drawing.Point(1020, 6)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(88, 609)
        Me.GroupControl1.TabIndex = 2
        Me.GroupControl1.Text = "Opciones"
        '
        'btnEliminarBorrador
        '
        Me.btnEliminarBorrador.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminarBorrador.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnEliminarBorrador.Appearance.Options.UseFont = True
        Me.btnEliminarBorrador.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnEliminarBorrador.Location = New System.Drawing.Point(5, 177)
        Me.btnEliminarBorrador.Name = "btnEliminarBorrador"
        Me.btnEliminarBorrador.Size = New System.Drawing.Size(78, 62)
        Me.btnEliminarBorrador.TabIndex = 4
        Me.btnEliminarBorrador.Text = "Eliminar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Borrador"
        '
        'btnBuscar
        '
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnBuscar.Location = New System.Drawing.Point(5, 25)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(78, 45)
        Me.btnBuscar.TabIndex = 1
        Me.btnBuscar.Text = "Buscar"
        '
        'FrmAggNovedades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1115, 623)
        Me.Controls.Add(Me.gcNovedades)
        Me.Controls.Add(Me.AgregarNovedades)
        Me.Controls.Add(Me.GroupControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmAggNovedades"
        Me.Text = "Agregar Novedades"
        CType(Me.AgregarNovedades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AgregarNovedades.ResumeLayout(False)
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
        Me.TableLayoutPanel3.ResumeLayout(False)
        CType(Me.PanelControl6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl6.ResumeLayout(False)
        Me.PanelControl6.PerformLayout()
        CType(Me.PanelControl7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl7.ResumeLayout(False)
        Me.PanelControl7.PerformLayout()
        CType(Me.PanelControl8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl8.ResumeLayout(False)
        Me.PanelControl8.PerformLayout()
        CType(Me.gcNovedades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvNovedades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AgregarNovedades As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gcNovedades As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvNovedades As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnLimpiar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtAño As SamitCtlNet.SamitTexto
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PanelControl6 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtPeriodos As SamitCtlNet.SamitBusq
    Friend WithEvents PanelControl7 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtCargos As SamitCtlNet.SamitBusq
    Friend WithEvents PanelControl8 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnBorradores As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtDependencia As SamitCtlNet.SamitBusq
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtOficina As SamitCtlNet.SamitBusq
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtNominas As SamitCtlNet.SamitBusq
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEliminarBorrador As DevExpress.XtraEditors.SimpleButton
End Class
