<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCargo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCargo))
        Me.gbxCargo = New DevExpress.XtraEditors.GroupControl()
        Me.SeparatorControl1 = New DevExpress.XtraEditors.SeparatorControl()
        Me.gcCargos = New DevExpress.XtraGrid.GridControl()
        Me.gvCargos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtCodCargoC = New SamitCtlNet.SamitTexto()
        Me.txtBusqueda = New DevExpress.XtraEditors.TextEdit()
        Me.txtDescripCargo = New DevExpress.XtraEditors.MemoEdit()
        Me.txtDenominacion = New SamitCtlNet.SamitTexto()
        Me.lblDescripCargo = New DevExpress.XtraEditors.LabelControl()
        Me.gbxFunciones = New DevExpress.XtraEditors.GroupControl()
        Me.btnAggFunc = New DevExpress.XtraEditors.SimpleButton()
        Me.txtFunciones = New SamitCtlNet.SamitBusq()
        Me.EliminarFun = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAggFunciones = New DevExpress.XtraEditors.SimpleButton()
        Me.gcFunciones = New DevExpress.XtraGrid.GridControl()
        Me.gvFuncionesCargo = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.pnlBotones = New DevExpress.XtraEditors.PanelControl()
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEliminar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnLimpiar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.gbxAsignaciones = New DevExpress.XtraEditors.GroupControl()
        Me.btnAggAsignacion = New DevExpress.XtraEditors.SimpleButton()
        Me.lblFecha = New DevExpress.XtraEditors.LabelControl()
        Me.dteFecha = New DevExpress.XtraEditors.DateEdit()
        Me.EliminarAsig = New DevExpress.XtraEditors.SimpleButton()
        Me.gcAsignaciones = New DevExpress.XtraGrid.GridControl()
        Me.gvAsignacionesCargo = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtAsignaciones = New SamitCtlNet.SamitTexto()
        Me.TlpCargos = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.gbxCargo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxCargo.SuspendLayout()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcCargos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvCargos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBusqueda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripCargo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gbxFunciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxFunciones.SuspendLayout()
        CType(Me.gcFunciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvFuncionesCargo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlBotones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBotones.SuspendLayout()
        CType(Me.gbxAsignaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxAsignaciones.SuspendLayout()
        CType(Me.dteFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcAsignaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvAsignacionesCargo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TlpCargos.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxCargo
        '
        Me.gbxCargo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxCargo.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.gbxCargo.AppearanceCaption.Options.UseFont = True
        Me.gbxCargo.Controls.Add(Me.SeparatorControl1)
        Me.gbxCargo.Controls.Add(Me.gcCargos)
        Me.gbxCargo.Controls.Add(Me.txtCodCargoC)
        Me.gbxCargo.Controls.Add(Me.txtBusqueda)
        Me.gbxCargo.Controls.Add(Me.txtDescripCargo)
        Me.gbxCargo.Controls.Add(Me.txtDenominacion)
        Me.gbxCargo.Controls.Add(Me.lblDescripCargo)
        Me.gbxCargo.Location = New System.Drawing.Point(3, 3)
        Me.gbxCargo.Name = "gbxCargo"
        Me.gbxCargo.Size = New System.Drawing.Size(485, 485)
        Me.gbxCargo.TabIndex = 1
        Me.gbxCargo.Text = "Datos del Cargo"
        '
        'SeparatorControl1
        '
        Me.SeparatorControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SeparatorControl1.Location = New System.Drawing.Point(4, 102)
        Me.SeparatorControl1.Name = "SeparatorControl1"
        Me.SeparatorControl1.Padding = New System.Windows.Forms.Padding(0)
        Me.SeparatorControl1.Size = New System.Drawing.Size(480, 3)
        Me.SeparatorControl1.TabIndex = 100
        '
        'gcCargos
        '
        Me.gcCargos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcCargos.Location = New System.Drawing.Point(1, 135)
        Me.gcCargos.MainView = Me.gvCargos
        Me.gcCargos.Name = "gcCargos"
        Me.gcCargos.Size = New System.Drawing.Size(484, 348)
        Me.gcCargos.TabIndex = 0
        Me.gcCargos.TabStop = False
        Me.gcCargos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvCargos})
        '
        'gvCargos
        '
        Me.gvCargos.GridControl = Me.gcCargos
        Me.gvCargos.Name = "gvCargos"
        Me.gvCargos.OptionsView.ShowGroupPanel = False
        '
        'txtCodCargoC
        '
        Me.txtCodCargoC.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtCodCargoC.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtCodCargoC.AltodelControl = 30
        Me.txtCodCargoC.AnchoLabel = 70
        Me.txtCodCargoC.AutoSize = True
        Me.txtCodCargoC.BackColor = System.Drawing.Color.Transparent
        Me.txtCodCargoC.ColordeFondo = System.Drawing.Color.Transparent
        Me.txtCodCargoC.EsObligatorio = False
        Me.txtCodCargoC.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.txtCodCargoC.FormatoNumero = Nothing
        Me.txtCodCargoC.Location = New System.Drawing.Point(30, 27)
        Me.txtCodCargoC.MaximoAncho = 0
        Me.txtCodCargoC.MensajedeAyuda = ""
        Me.txtCodCargoC.Name = "txtCodCargoC"
        Me.txtCodCargoC.Size = New System.Drawing.Size(170, 30)
        Me.txtCodCargoC.SoloLectura = False
        Me.txtCodCargoC.SoloNumeros = False
        Me.txtCodCargoC.TabIndex = 1
        Me.txtCodCargoC.TextodelControl = ""
        Me.txtCodCargoC.TextoLabel = "Codigo :"
        Me.txtCodCargoC.TieneErrorControl = False
        Me.txtCodCargoC.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtCodCargoC.TipodeLetra = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodCargoC.ValordelControl = Nothing
        Me.txtCodCargoC.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCodCargoC.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCodCargoC.ValorPredeterminado = Nothing
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBusqueda.Location = New System.Drawing.Point(0, 108)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.txtBusqueda.Properties.Appearance.Options.UseFont = True
        Me.txtBusqueda.Size = New System.Drawing.Size(484, 24)
        Me.txtBusqueda.TabIndex = 0
        Me.txtBusqueda.TabStop = False
        '
        'txtDescripCargo
        '
        Me.txtDescripCargo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescripCargo.Location = New System.Drawing.Point(103, 60)
        Me.txtDescripCargo.Name = "txtDescripCargo"
        Me.txtDescripCargo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.txtDescripCargo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.txtDescripCargo.Properties.Appearance.Options.UseFont = True
        Me.txtDescripCargo.Properties.Appearance.Options.UseForeColor = True
        Me.txtDescripCargo.Size = New System.Drawing.Size(373, 40)
        Me.txtDescripCargo.TabIndex = 3
        '
        'txtDenominacion
        '
        Me.txtDenominacion.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtDenominacion.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtDenominacion.AltodelControl = 30
        Me.txtDenominacion.AnchoLabel = 90
        Me.txtDenominacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDenominacion.AutoSize = True
        Me.txtDenominacion.BackColor = System.Drawing.Color.Transparent
        Me.txtDenominacion.ColordeFondo = System.Drawing.Color.Transparent
        Me.txtDenominacion.EsObligatorio = False
        Me.txtDenominacion.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.txtDenominacion.FormatoNumero = Nothing
        Me.txtDenominacion.Location = New System.Drawing.Point(189, 27)
        Me.txtDenominacion.MaximoAncho = 0
        Me.txtDenominacion.MensajedeAyuda = ""
        Me.txtDenominacion.Name = "txtDenominacion"
        Me.txtDenominacion.Size = New System.Drawing.Size(291, 30)
        Me.txtDenominacion.SoloLectura = False
        Me.txtDenominacion.SoloNumeros = False
        Me.txtDenominacion.TabIndex = 2
        Me.txtDenominacion.TextodelControl = ""
        Me.txtDenominacion.TextoLabel = "Nombre :"
        Me.txtDenominacion.TieneErrorControl = False
        Me.txtDenominacion.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtDenominacion.TipodeLetra = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDenominacion.ValordelControl = Nothing
        Me.txtDenominacion.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDenominacion.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDenominacion.ValorPredeterminado = Nothing
        '
        'lblDescripCargo
        '
        Me.lblDescripCargo.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lblDescripCargo.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.lblDescripCargo.Appearance.Options.UseFont = True
        Me.lblDescripCargo.Appearance.Options.UseForeColor = True
        Me.lblDescripCargo.Appearance.Options.UseTextOptions = True
        Me.lblDescripCargo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblDescripCargo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblDescripCargo.Location = New System.Drawing.Point(6, 57)
        Me.lblDescripCargo.Margin = New System.Windows.Forms.Padding(9, 3, 3, 3)
        Me.lblDescripCargo.Name = "lblDescripCargo"
        Me.lblDescripCargo.Padding = New System.Windows.Forms.Padding(2)
        Me.lblDescripCargo.Size = New System.Drawing.Size(91, 21)
        Me.lblDescripCargo.TabIndex = 86
        Me.lblDescripCargo.Text = "Descripción :"
        '
        'gbxFunciones
        '
        Me.gbxFunciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxFunciones.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.gbxFunciones.AppearanceCaption.Options.UseFont = True
        Me.gbxFunciones.Controls.Add(Me.btnAggFunc)
        Me.gbxFunciones.Controls.Add(Me.txtFunciones)
        Me.gbxFunciones.Controls.Add(Me.EliminarFun)
        Me.gbxFunciones.Controls.Add(Me.btnAggFunciones)
        Me.gbxFunciones.Controls.Add(Me.gcFunciones)
        Me.gbxFunciones.Location = New System.Drawing.Point(3, 3)
        Me.gbxFunciones.Name = "gbxFunciones"
        Me.gbxFunciones.Size = New System.Drawing.Size(479, 236)
        Me.gbxFunciones.TabIndex = 1
        Me.gbxFunciones.Text = "Datos de la función que desempeña"
        '
        'btnAggFunc
        '
        Me.btnAggFunc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAggFunc.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnAggFunc.Appearance.Options.UseFont = True
        Me.btnAggFunc.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnAggFunc.Location = New System.Drawing.Point(387, 27)
        Me.btnAggFunc.Name = "btnAggFunc"
        Me.btnAggFunc.Size = New System.Drawing.Size(40, 26)
        Me.btnAggFunc.TabIndex = 2
        '
        'txtFunciones
        '
        Me.txtFunciones.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtFunciones.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtFunciones.AltodelControl = 31
        Me.txtFunciones.AnchoLabel = 95
        Me.txtFunciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFunciones.AnchoTxt = 80
        Me.txtFunciones.AutoCargarDatos = True
        Me.txtFunciones.AutoSize = True
        Me.txtFunciones.BackColor = System.Drawing.Color.Transparent
        Me.txtFunciones.ColorFondo = System.Drawing.Color.Transparent
        Me.txtFunciones.CondicionValida = ""
        Me.txtFunciones.Conexion = SamitCtlNet.ConexionSAMIT.ConexModulo
        Me.txtFunciones.ConsultaSQL = Nothing
        Me.txtFunciones.DatosDefecto = Nothing
        Me.txtFunciones.EsObligatorio = False
        Me.txtFunciones.FormatoNumero = Nothing
        Me.txtFunciones.ListaColumnas = Nothing
        Me.txtFunciones.Location = New System.Drawing.Point(10, 24)
        Me.txtFunciones.MaximoAncho = 0
        Me.txtFunciones.MensajedeAyuda = Nothing
        Me.txtFunciones.Name = "txtFunciones"
        Me.txtFunciones.Size = New System.Drawing.Size(325, 31)
        Me.txtFunciones.SoloLectura = False
        Me.txtFunciones.SoloNumeros = True
        Me.txtFunciones.TabIndex = 1
        Me.txtFunciones.TextodelControl = ""
        Me.txtFunciones.TextoLabel = "Funciones :"
        Me.txtFunciones.TieneErrorControl = False
        Me.txtFunciones.TipoBusqueda = SamitCtlNet.ModGeneral.TipoBusqueda.Ninguna
        Me.txtFunciones.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtFunciones.TipodeLetra = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFunciones.ValordelControl = ""
        Me.txtFunciones.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtFunciones.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtFunciones.ValorPredeterminado = Nothing
        '
        'EliminarFun
        '
        Me.EliminarFun.AllowFocus = False
        Me.EliminarFun.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EliminarFun.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.EliminarFun.Appearance.Options.UseFont = True
        Me.EliminarFun.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.EliminarFun.Location = New System.Drawing.Point(433, 27)
        Me.EliminarFun.Name = "EliminarFun"
        Me.EliminarFun.Size = New System.Drawing.Size(40, 26)
        Me.EliminarFun.TabIndex = 3
        '
        'btnAggFunciones
        '
        Me.btnAggFunciones.AllowFocus = False
        Me.btnAggFunciones.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAggFunciones.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnAggFunciones.Appearance.Options.UseFont = True
        Me.btnAggFunciones.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnAggFunciones.Location = New System.Drawing.Point(341, 27)
        Me.btnAggFunciones.Name = "btnAggFunciones"
        Me.btnAggFunciones.Size = New System.Drawing.Size(40, 26)
        Me.btnAggFunciones.TabIndex = 108
        Me.btnAggFunciones.TabStop = False
        '
        'gcFunciones
        '
        Me.gcFunciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcFunciones.Location = New System.Drawing.Point(0, 59)
        Me.gcFunciones.MainView = Me.gvFuncionesCargo
        Me.gcFunciones.Name = "gcFunciones"
        Me.gcFunciones.Size = New System.Drawing.Size(479, 176)
        Me.gcFunciones.TabIndex = 89
        Me.gcFunciones.TabStop = False
        Me.gcFunciones.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvFuncionesCargo})
        '
        'gvFuncionesCargo
        '
        Me.gvFuncionesCargo.GridControl = Me.gcFunciones
        Me.gvFuncionesCargo.Name = "gvFuncionesCargo"
        Me.gvFuncionesCargo.OptionsView.ShowGroupPanel = False
        '
        'pnlBotones
        '
        Me.pnlBotones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlBotones.Controls.Add(Me.btnSalir)
        Me.pnlBotones.Controls.Add(Me.btnEliminar)
        Me.pnlBotones.Controls.Add(Me.btnLimpiar)
        Me.pnlBotones.Controls.Add(Me.btnGuardar)
        Me.pnlBotones.Location = New System.Drawing.Point(8, 494)
        Me.pnlBotones.Name = "pnlBotones"
        Me.pnlBotones.Size = New System.Drawing.Size(973, 58)
        Me.pnlBotones.TabIndex = 2
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(881, 8)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(82, 39)
        Me.btnSalir.TabIndex = 14
        Me.btnSalir.Text = "Salir"
        '
        'btnEliminar
        '
        Me.btnEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(793, 8)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(82, 39)
        Me.btnEliminar.TabIndex = 13
        Me.btnEliminar.Text = "Eliminar"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLimpiar.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnLimpiar.Appearance.Options.UseFont = True
        Me.btnLimpiar.Location = New System.Drawing.Point(705, 8)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(82, 39)
        Me.btnLimpiar.TabIndex = 12
        Me.btnLimpiar.Text = "Limpiar"
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Location = New System.Drawing.Point(617, 8)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(82, 39)
        Me.btnGuardar.TabIndex = 11
        Me.btnGuardar.Text = "Guardar"
        '
        'gbxAsignaciones
        '
        Me.gbxAsignaciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxAsignaciones.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.gbxAsignaciones.AppearanceCaption.Options.UseFont = True
        Me.gbxAsignaciones.Controls.Add(Me.btnAggAsignacion)
        Me.gbxAsignaciones.Controls.Add(Me.lblFecha)
        Me.gbxAsignaciones.Controls.Add(Me.dteFecha)
        Me.gbxAsignaciones.Controls.Add(Me.EliminarAsig)
        Me.gbxAsignaciones.Controls.Add(Me.gcAsignaciones)
        Me.gbxAsignaciones.Controls.Add(Me.txtAsignaciones)
        Me.gbxAsignaciones.Location = New System.Drawing.Point(3, 245)
        Me.gbxAsignaciones.Name = "gbxAsignaciones"
        Me.gbxAsignaciones.Size = New System.Drawing.Size(479, 237)
        Me.gbxAsignaciones.TabIndex = 3
        Me.gbxAsignaciones.Text = "Asignación Salarial"
        '
        'btnAggAsignacion
        '
        Me.btnAggAsignacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAggAsignacion.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnAggAsignacion.Appearance.Options.UseFont = True
        Me.btnAggAsignacion.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnAggAsignacion.Location = New System.Drawing.Point(387, 26)
        Me.btnAggAsignacion.Name = "btnAggAsignacion"
        Me.btnAggAsignacion.Size = New System.Drawing.Size(40, 26)
        Me.btnAggAsignacion.TabIndex = 3
        '
        'lblFecha
        '
        Me.lblFecha.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Appearance.Options.UseFont = True
        Me.lblFecha.Appearance.Options.UseTextOptions = True
        Me.lblFecha.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblFecha.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblFecha.Location = New System.Drawing.Point(10, 26)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Padding = New System.Windows.Forms.Padding(2)
        Me.lblFecha.Size = New System.Drawing.Size(70, 26)
        Me.lblFecha.TabIndex = 117
        Me.lblFecha.Text = "Fecha :"
        '
        'dteFecha
        '
        Me.dteFecha.EditValue = Nothing
        Me.dteFecha.Location = New System.Drawing.Point(85, 29)
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
        Me.dteFecha.Size = New System.Drawing.Size(91, 20)
        Me.dteFecha.TabIndex = 1
        '
        'EliminarAsig
        '
        Me.EliminarAsig.AllowFocus = False
        Me.EliminarAsig.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EliminarAsig.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.EliminarAsig.Appearance.Options.UseFont = True
        Me.EliminarAsig.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.EliminarAsig.Location = New System.Drawing.Point(433, 26)
        Me.EliminarAsig.Name = "EliminarAsig"
        Me.EliminarAsig.Size = New System.Drawing.Size(40, 26)
        Me.EliminarAsig.TabIndex = 4
        '
        'gcAsignaciones
        '
        Me.gcAsignaciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcAsignaciones.Location = New System.Drawing.Point(0, 60)
        Me.gcAsignaciones.MainView = Me.gvAsignacionesCargo
        Me.gcAsignaciones.Name = "gcAsignaciones"
        Me.gcAsignaciones.Size = New System.Drawing.Size(479, 177)
        Me.gcAsignaciones.TabIndex = 3
        Me.gcAsignaciones.TabStop = False
        Me.gcAsignaciones.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvAsignacionesCargo})
        '
        'gvAsignacionesCargo
        '
        Me.gvAsignacionesCargo.GridControl = Me.gcAsignaciones
        Me.gvAsignacionesCargo.Name = "gvAsignacionesCargo"
        Me.gvAsignacionesCargo.OptionsView.ShowGroupPanel = False
        '
        'txtAsignaciones
        '
        Me.txtAsignaciones.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtAsignaciones.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtAsignaciones.AltodelControl = 30
        Me.txtAsignaciones.AnchoLabel = 90
        Me.txtAsignaciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAsignaciones.AutoSize = True
        Me.txtAsignaciones.BackColor = System.Drawing.Color.Transparent
        Me.txtAsignaciones.ColordeFondo = System.Drawing.Color.Transparent
        Me.txtAsignaciones.EsObligatorio = False
        Me.txtAsignaciones.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAsignaciones.FormatoNumero = Nothing
        Me.txtAsignaciones.Location = New System.Drawing.Point(182, 26)
        Me.txtAsignaciones.MaximoAncho = 0
        Me.txtAsignaciones.MensajedeAyuda = ""
        Me.txtAsignaciones.Name = "txtAsignaciones"
        Me.txtAsignaciones.Size = New System.Drawing.Size(199, 30)
        Me.txtAsignaciones.SoloLectura = False
        Me.txtAsignaciones.SoloNumeros = False
        Me.txtAsignaciones.TabIndex = 2
        Me.txtAsignaciones.TextodelControl = ""
        Me.txtAsignaciones.TextoLabel = "Asignación :"
        Me.txtAsignaciones.TieneErrorControl = False
        Me.txtAsignaciones.TipodeDatos = SamitCtlNet.TipodeDato.MonedaConDecimales
        Me.txtAsignaciones.TipodeLetra = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAsignaciones.ValordelControl = Nothing
        Me.txtAsignaciones.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtAsignaciones.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtAsignaciones.ValorPredeterminado = Nothing
        '
        'TlpCargos
        '
        Me.TlpCargos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TlpCargos.ColumnCount = 2
        Me.TlpCargos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TlpCargos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TlpCargos.Controls.Add(Me.TableLayoutPanel2, 1, 0)
        Me.TlpCargos.Controls.Add(Me.gbxCargo, 0, 0)
        Me.TlpCargos.Location = New System.Drawing.Point(5, 3)
        Me.TlpCargos.Name = "TlpCargos"
        Me.TlpCargos.RowCount = 1
        Me.TlpCargos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TlpCargos.Size = New System.Drawing.Size(982, 491)
        Me.TlpCargos.TabIndex = 1
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.gbxFunciones, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.gbxAsignaciones, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(494, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(485, 485)
        Me.TableLayoutPanel2.TabIndex = 88
        '
        'FrmCargo
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(988, 553)
        Me.Controls.Add(Me.TlpCargos)
        Me.Controls.Add(Me.pnlBotones)
        Me.IconOptions.Icon = CType(resources.GetObject("FrmCargo.IconOptions.Icon"), System.Drawing.Icon)
        Me.Name = "FrmCargo"
        Me.Text = "Cargos"
        CType(Me.gbxCargo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxCargo.ResumeLayout(False)
        Me.gbxCargo.PerformLayout()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcCargos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvCargos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBusqueda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripCargo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gbxFunciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxFunciones.ResumeLayout(False)
        Me.gbxFunciones.PerformLayout()
        CType(Me.gcFunciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvFuncionesCargo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlBotones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBotones.ResumeLayout(False)
        CType(Me.gbxAsignaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxAsignaciones.ResumeLayout(False)
        Me.gbxAsignaciones.PerformLayout()
        CType(Me.dteFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcAsignaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvAsignacionesCargo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TlpCargos.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gcCargos As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvCargos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents pnlBotones As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnLimpiar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtBusqueda As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gbxCargo As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtCodCargoC As SamitCtlNet.SamitTexto
    Friend WithEvents txtDenominacion As SamitCtlNet.SamitTexto
    Friend WithEvents txtDescripCargo As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents gbxFunciones As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gcFunciones As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvFuncionesCargo As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gbxAsignaciones As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gcAsignaciones As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvAsignacionesCargo As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtAsignaciones As SamitCtlNet.SamitTexto
    Friend WithEvents TlpCargos As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnAggFunciones As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents EliminarFun As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents EliminarAsig As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblFecha As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dteFecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtFunciones As SamitCtlNet.SamitBusq
    Friend WithEvents lblDescripCargo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SeparatorControl1 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents btnAggFunc As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAggAsignacion As DevExpress.XtraEditors.SimpleButton
End Class
