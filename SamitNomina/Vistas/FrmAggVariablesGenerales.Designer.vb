<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAggVariablesGenerales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAggVariablesGenerales))
        Me.TlpVariablesG = New System.Windows.Forms.TableLayoutPanel()
        Me.gbxDetallesVariablesG = New DevExpress.XtraEditors.GroupControl()
        Me.btnAggDetalles = New DevExpress.XtraEditors.SimpleButton()
        Me.SeparatorControl2 = New DevExpress.XtraEditors.SeparatorControl()
        Me.lblFecha = New DevExpress.XtraEditors.LabelControl()
        Me.dteFecha = New DevExpress.XtraEditors.DateEdit()
        Me.EliminarDetalle = New DevExpress.XtraEditors.SimpleButton()
        Me.gcDetalleVariablesG = New DevExpress.XtraGrid.GridControl()
        Me.gvDetalleVariableG = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtValor = New SamitCtlNet.SamitTexto()
        Me.gbxVariablesG = New DevExpress.XtraEditors.GroupControl()
        Me.SeparatorControl1 = New DevExpress.XtraEditors.SeparatorControl()
        Me.lblVigente = New DevExpress.XtraEditors.LabelControl()
        Me.grbVigente = New DevExpress.XtraEditors.RadioGroup()
        Me.gcVariablesG = New DevExpress.XtraGrid.GridControl()
        Me.gvVariablesG = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtBusqueda = New DevExpress.XtraEditors.TextEdit()
        Me.txtNombre = New SamitCtlNet.SamitTexto()
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEliminar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnLimpiar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.txtCodDian = New SamitCtlNet.SamitBusq()
        Me.TlpVariablesG.SuspendLayout()
        CType(Me.gbxDetallesVariablesG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxDetallesVariablesG.SuspendLayout()
        CType(Me.SeparatorControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcDetalleVariablesG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvDetalleVariableG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gbxVariablesG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxVariablesG.SuspendLayout()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grbVigente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcVariablesG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvVariablesG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBusqueda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TlpVariablesG
        '
        Me.TlpVariablesG.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TlpVariablesG.ColumnCount = 2
        Me.TlpVariablesG.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TlpVariablesG.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TlpVariablesG.Controls.Add(Me.gbxDetallesVariablesG, 0, 0)
        Me.TlpVariablesG.Controls.Add(Me.gbxVariablesG, 0, 0)
        Me.TlpVariablesG.Location = New System.Drawing.Point(5, 9)
        Me.TlpVariablesG.Name = "TlpVariablesG"
        Me.TlpVariablesG.RowCount = 1
        Me.TlpVariablesG.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TlpVariablesG.Size = New System.Drawing.Size(896, 543)
        Me.TlpVariablesG.TabIndex = 91
        '
        'gbxDetallesVariablesG
        '
        Me.gbxDetallesVariablesG.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxDetallesVariablesG.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.gbxDetallesVariablesG.AppearanceCaption.Options.UseFont = True
        Me.gbxDetallesVariablesG.Controls.Add(Me.btnAggDetalles)
        Me.gbxDetallesVariablesG.Controls.Add(Me.SeparatorControl2)
        Me.gbxDetallesVariablesG.Controls.Add(Me.lblFecha)
        Me.gbxDetallesVariablesG.Controls.Add(Me.dteFecha)
        Me.gbxDetallesVariablesG.Controls.Add(Me.EliminarDetalle)
        Me.gbxDetallesVariablesG.Controls.Add(Me.gcDetalleVariablesG)
        Me.gbxDetallesVariablesG.Controls.Add(Me.txtValor)
        Me.gbxDetallesVariablesG.Location = New System.Drawing.Point(451, 3)
        Me.gbxDetallesVariablesG.Name = "gbxDetallesVariablesG"
        Me.gbxDetallesVariablesG.Size = New System.Drawing.Size(442, 537)
        Me.gbxDetallesVariablesG.TabIndex = 1
        Me.gbxDetallesVariablesG.Text = "Detalles"
        '
        'btnAggDetalles
        '
        Me.btnAggDetalles.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAggDetalles.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnAggDetalles.Appearance.Options.UseFont = True
        Me.btnAggDetalles.Location = New System.Drawing.Point(283, 65)
        Me.btnAggDetalles.Name = "btnAggDetalles"
        Me.btnAggDetalles.Size = New System.Drawing.Size(74, 25)
        Me.btnAggDetalles.TabIndex = 3
        Me.btnAggDetalles.Text = "Agregar"
        '
        'SeparatorControl2
        '
        Me.SeparatorControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SeparatorControl2.Location = New System.Drawing.Point(3, 58)
        Me.SeparatorControl2.Name = "SeparatorControl2"
        Me.SeparatorControl2.Padding = New System.Windows.Forms.Padding(0)
        Me.SeparatorControl2.Size = New System.Drawing.Size(437, 3)
        Me.SeparatorControl2.TabIndex = 118
        '
        'lblFecha
        '
        Me.lblFecha.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Appearance.Options.UseFont = True
        Me.lblFecha.Appearance.Options.UseTextOptions = True
        Me.lblFecha.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblFecha.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblFecha.Location = New System.Drawing.Point(13, 26)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Padding = New System.Windows.Forms.Padding(2)
        Me.lblFecha.Size = New System.Drawing.Size(70, 26)
        Me.lblFecha.TabIndex = 117
        Me.lblFecha.Text = "Fecha :"
        '
        'dteFecha
        '
        Me.dteFecha.EditValue = Nothing
        Me.dteFecha.Location = New System.Drawing.Point(87, 29)
        Me.dteFecha.Name = "dteFecha"
        Me.dteFecha.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.dteFecha.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.dteFecha.Properties.Appearance.Options.UseBackColor = True
        Me.dteFecha.Properties.Appearance.Options.UseFont = True
        Me.dteFecha.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.dteFecha.Properties.AppearanceDropDown.Options.UseFont = True
        Me.dteFecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteFecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteFecha.Properties.CloseUpKey = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.Right)
        Me.dteFecha.Size = New System.Drawing.Size(100, 20)
        Me.dteFecha.TabIndex = 1
        '
        'EliminarDetalle
        '
        Me.EliminarDetalle.AllowFocus = False
        Me.EliminarDetalle.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EliminarDetalle.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.EliminarDetalle.Appearance.Options.UseFont = True
        Me.EliminarDetalle.Location = New System.Drawing.Point(363, 65)
        Me.EliminarDetalle.Name = "EliminarDetalle"
        Me.EliminarDetalle.Size = New System.Drawing.Size(74, 25)
        Me.EliminarDetalle.TabIndex = 4
        Me.EliminarDetalle.Text = "Quitar"
        '
        'gcDetalleVariablesG
        '
        Me.gcDetalleVariablesG.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcDetalleVariablesG.Location = New System.Drawing.Point(0, 95)
        Me.gcDetalleVariablesG.MainView = Me.gvDetalleVariableG
        Me.gcDetalleVariablesG.Name = "gcDetalleVariablesG"
        Me.gcDetalleVariablesG.Size = New System.Drawing.Size(442, 442)
        Me.gcDetalleVariablesG.TabIndex = 10
        Me.gcDetalleVariablesG.TabStop = False
        Me.gcDetalleVariablesG.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvDetalleVariableG})
        '
        'gvDetalleVariableG
        '
        Me.gvDetalleVariableG.GridControl = Me.gcDetalleVariablesG
        Me.gvDetalleVariableG.Name = "gvDetalleVariableG"
        Me.gvDetalleVariableG.OptionsView.ShowGroupPanel = False
        '
        'txtValor
        '
        Me.txtValor.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtValor.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtValor.AltodelControl = 30
        Me.txtValor.AnchoLabel = 80
        Me.txtValor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtValor.AutoSize = True
        Me.txtValor.BackColor = System.Drawing.Color.Transparent
        Me.txtValor.ColordeFondo = System.Drawing.Color.Transparent
        Me.txtValor.EsObligatorio = False
        Me.txtValor.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValor.FormatoNumero = Nothing
        Me.txtValor.Location = New System.Drawing.Point(193, 26)
        Me.txtValor.MaximoAncho = 0
        Me.txtValor.MensajedeAyuda = "Asignación. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(246, 30)
        Me.txtValor.SoloLectura = False
        Me.txtValor.SoloNumeros = False
        Me.txtValor.TabIndex = 2
        Me.txtValor.TextodelControl = ""
        Me.txtValor.TextoLabel = "Valor :"
        Me.txtValor.TieneErrorControl = False
        Me.txtValor.TipodeDatos = SamitCtlNet.TipodeDato.NumerosCon_4_Decimales
        Me.txtValor.TipodeLetra = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValor.ValordelControl = Nothing
        Me.txtValor.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtValor.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtValor.ValorPredeterminado = Nothing
        '
        'gbxVariablesG
        '
        Me.gbxVariablesG.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxVariablesG.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.gbxVariablesG.AppearanceCaption.Options.UseFont = True
        Me.gbxVariablesG.Controls.Add(Me.txtCodDian)
        Me.gbxVariablesG.Controls.Add(Me.SeparatorControl1)
        Me.gbxVariablesG.Controls.Add(Me.lblVigente)
        Me.gbxVariablesG.Controls.Add(Me.grbVigente)
        Me.gbxVariablesG.Controls.Add(Me.gcVariablesG)
        Me.gbxVariablesG.Controls.Add(Me.txtBusqueda)
        Me.gbxVariablesG.Controls.Add(Me.txtNombre)
        Me.gbxVariablesG.Location = New System.Drawing.Point(3, 3)
        Me.gbxVariablesG.Name = "gbxVariablesG"
        Me.gbxVariablesG.Size = New System.Drawing.Size(442, 537)
        Me.gbxVariablesG.TabIndex = 0
        Me.gbxVariablesG.Text = "Valores Generales"
        '
        'SeparatorControl1
        '
        Me.SeparatorControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SeparatorControl1.Location = New System.Drawing.Point(1, 113)
        Me.SeparatorControl1.Name = "SeparatorControl1"
        Me.SeparatorControl1.Padding = New System.Windows.Forms.Padding(0)
        Me.SeparatorControl1.Size = New System.Drawing.Size(437, 3)
        Me.SeparatorControl1.TabIndex = 101
        '
        'lblVigente
        '
        Me.lblVigente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblVigente.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lblVigente.Appearance.Options.UseFont = True
        Me.lblVigente.Appearance.Options.UseTextOptions = True
        Me.lblVigente.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblVigente.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblVigente.Location = New System.Drawing.Point(270, 88)
        Me.lblVigente.Name = "lblVigente"
        Me.lblVigente.Padding = New System.Windows.Forms.Padding(2)
        Me.lblVigente.Size = New System.Drawing.Size(71, 26)
        Me.lblVigente.TabIndex = 100
        Me.lblVigente.Text = "Vigente :"
        '
        'grbVigente
        '
        Me.grbVigente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grbVigente.Location = New System.Drawing.Point(346, 91)
        Me.grbVigente.Name = "grbVigente"
        Me.grbVigente.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.grbVigente.Properties.Appearance.Options.UseBackColor = True
        Me.grbVigente.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.grbVigente.Properties.Columns = 2
        Me.grbVigente.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.grbVigente.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "NO"), New DevExpress.XtraEditors.Controls.RadioGroupItem(True, "SI")})
        Me.grbVigente.Size = New System.Drawing.Size(91, 20)
        Me.grbVigente.TabIndex = 4
        '
        'gcVariablesG
        '
        Me.gcVariablesG.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcVariablesG.Location = New System.Drawing.Point(1, 146)
        Me.gcVariablesG.MainView = Me.gvVariablesG
        Me.gcVariablesG.Name = "gcVariablesG"
        Me.gcVariablesG.Size = New System.Drawing.Size(441, 387)
        Me.gcVariablesG.TabIndex = 0
        Me.gcVariablesG.TabStop = False
        Me.gcVariablesG.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvVariablesG})
        '
        'gvVariablesG
        '
        Me.gvVariablesG.GridControl = Me.gcVariablesG
        Me.gvVariablesG.Name = "gvVariablesG"
        Me.gvVariablesG.OptionsView.ShowGroupPanel = False
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBusqueda.Location = New System.Drawing.Point(2, 120)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.txtBusqueda.Properties.Appearance.Options.UseFont = True
        Me.txtBusqueda.Size = New System.Drawing.Size(438, 24)
        Me.txtBusqueda.TabIndex = 0
        Me.txtBusqueda.TabStop = False
        '
        'txtNombre
        '
        Me.txtNombre.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtNombre.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtNombre.AltodelControl = 30
        Me.txtNombre.AnchoLabel = 100
        Me.txtNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombre.AutoSize = True
        Me.txtNombre.BackColor = System.Drawing.Color.Transparent
        Me.txtNombre.ColordeFondo = System.Drawing.Color.Transparent
        Me.txtNombre.EsObligatorio = False
        Me.txtNombre.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.txtNombre.FormatoNumero = Nothing
        Me.txtNombre.Location = New System.Drawing.Point(5, 26)
        Me.txtNombre.MaximoAncho = 0
        Me.txtNombre.MensajedeAyuda = "Digite la denominación del cargo que desea registrar o actualizar. (ENTER,ABJ)=Av" &
    "anzar"
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(432, 30)
        Me.txtNombre.SoloLectura = False
        Me.txtNombre.SoloNumeros = False
        Me.txtNombre.TabIndex = 2
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
        'GroupControl2
        '
        Me.GroupControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.GroupControl2.CaptionImageOptions.Padding = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.GroupControl2.Controls.Add(Me.btnGuardar)
        Me.GroupControl2.Controls.Add(Me.btnLimpiar)
        Me.GroupControl2.Controls.Add(Me.btnEliminar)
        Me.GroupControl2.Controls.Add(Me.btnSalir)
        Me.GroupControl2.Location = New System.Drawing.Point(904, 12)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(88, 536)
        Me.GroupControl2.TabIndex = 2
        Me.GroupControl2.TabStop = True
        Me.GroupControl2.Text = "Opciones"
        '
        'txtCodDian
        '
        Me.txtCodDian.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtCodDian.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtCodDian.AltodelControl = 30
        Me.txtCodDian.AnchoLabel = 102
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
        Me.txtCodDian.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtCodDian.FormatoNumero = Nothing
        Me.txtCodDian.Location = New System.Drawing.Point(4, 56)
        Me.txtCodDian.MaximoAncho = 0
        Me.txtCodDian.MensajedeAyuda = ""
        Me.txtCodDian.Name = "txtCodDian"
        Me.txtCodDian.Size = New System.Drawing.Size(433, 30)
        Me.txtCodDian.SoloLectura = False
        Me.txtCodDian.SoloNumeros = True
        Me.txtCodDian.TabIndex = 2
        Me.txtCodDian.TextodelControl = ""
        Me.txtCodDian.TextoLabel = "Codigo Dian :"
        Me.txtCodDian.TieneErrorControl = False
        Me.txtCodDian.TipoBusqueda = SamitCtlNet.ModGeneral.TipoBusqueda.Ninguna
        Me.txtCodDian.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtCodDian.TipodeLetra = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtCodDian.ValordelControl = ""
        Me.txtCodDian.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCodDian.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCodDian.ValorPredeterminado = Nothing
        '
        'FrmAggVariablesGenerales
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1002, 558)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.TlpVariablesG)
        Me.IconOptions.Icon = CType(resources.GetObject("FrmAggVariablesGenerales.IconOptions.Icon"), System.Drawing.Icon)
        Me.Name = "FrmAggVariablesGenerales"
        Me.Text = "Valores Generales"
        Me.TlpVariablesG.ResumeLayout(False)
        CType(Me.gbxDetallesVariablesG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxDetallesVariablesG.ResumeLayout(False)
        Me.gbxDetallesVariablesG.PerformLayout()
        CType(Me.SeparatorControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcDetalleVariablesG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvDetalleVariableG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gbxVariablesG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxVariablesG.ResumeLayout(False)
        Me.gbxVariablesG.PerformLayout()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grbVigente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcVariablesG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvVariablesG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBusqueda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TlpVariablesG As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents gbxVariablesG As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gcVariablesG As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvVariablesG As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtBusqueda As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNombre As SamitCtlNet.SamitTexto
    Friend WithEvents gbxDetallesVariablesG As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblFecha As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dteFecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents EliminarDetalle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gcDetalleVariablesG As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvDetalleVariableG As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtValor As SamitCtlNet.SamitTexto
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnLimpiar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblVigente As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grbVigente As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SeparatorControl2 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents SeparatorControl1 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents btnAggDetalles As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtCodDian As SamitCtlNet.SamitBusq
End Class
