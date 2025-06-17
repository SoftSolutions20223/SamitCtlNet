<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmContbLiquidaciones
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmContbLiquidaciones))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.BtnExcell = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.gcConceptosCont = New DevExpress.XtraGrid.GridControl()
        Me.gvConceptos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtComentario = New DevExpress.XtraEditors.MemoEdit()
        Me.lblComentarios = New DevExpress.XtraEditors.LabelControl()
        Me.txtOficina = New SamitCtlNet.SamitBusq()
        Me.lblFecha = New DevExpress.XtraEditors.LabelControl()
        Me.dteFecha = New DevExpress.XtraEditors.DateEdit()
        Me.txtTipoComprobante = New SamitCtlNet.SamitBusq()
        Me.lblNumDoc = New DevExpress.XtraEditors.LabelControl()
        Me.lblSecCom = New DevExpress.XtraEditors.LabelControl()
        Me.txtCodComp = New SamitCtlNet.SamitBusq()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.gcTerceros = New DevExpress.XtraGrid.GridControl()
        Me.gvTerceros = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.grbVista = New DevExpress.XtraEditors.RadioGroup()
        Me.txtFormadePago = New SamitCtlNet.SamitBusq()
        Me.btnAnular = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.gcConceptosCont, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvConceptos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtComentario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcTerceros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvTerceros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grbVista.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.GroupControl1.CaptionImageOptions.Padding = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.GroupControl1.Controls.Add(Me.btnAnular)
        Me.GroupControl1.Controls.Add(Me.BtnExcell)
        Me.GroupControl1.Controls.Add(Me.btnAceptar)
        Me.GroupControl1.Controls.Add(Me.btnCancelar)
        Me.GroupControl1.Location = New System.Drawing.Point(1141, 4)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(88, 565)
        Me.GroupControl1.TabIndex = 110
        Me.GroupControl1.Text = "Opciones"
        '
        'BtnExcell
        '
        Me.BtnExcell.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnExcell.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.BtnExcell.Appearance.Options.UseFont = True
        Me.BtnExcell.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnExcell.Location = New System.Drawing.Point(5, 79)
        Me.BtnExcell.Name = "BtnExcell"
        Me.BtnExcell.Size = New System.Drawing.Size(78, 45)
        Me.BtnExcell.TabIndex = 7
        Me.BtnExcell.Text = "Excell"
        '
        'btnAceptar
        '
        Me.btnAceptar.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnAceptar.Appearance.Options.UseFont = True
        Me.btnAceptar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnAceptar.Location = New System.Drawing.Point(5, 28)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(78, 45)
        Me.btnAceptar.TabIndex = 6
        Me.btnAceptar.Text = "Aceptar"
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnCancelar.Appearance.Options.UseFont = True
        Me.btnCancelar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnCancelar.Location = New System.Drawing.Point(5, 181)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(78, 45)
        Me.btnCancelar.TabIndex = 9
        Me.btnCancelar.Text = "Cancelar"
        '
        'gcConceptosCont
        '
        Me.gcConceptosCont.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcConceptosCont.Location = New System.Drawing.Point(6, 171)
        Me.gcConceptosCont.MainView = Me.gvConceptos
        Me.gcConceptosCont.Name = "gcConceptosCont"
        Me.gcConceptosCont.Size = New System.Drawing.Size(1129, 398)
        Me.gcConceptosCont.TabIndex = 109
        Me.gcConceptosCont.TabStop = False
        Me.gcConceptosCont.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvConceptos})
        '
        'gvConceptos
        '
        Me.gvConceptos.GridControl = Me.gcConceptosCont
        Me.gvConceptos.Name = "gvConceptos"
        Me.gvConceptos.OptionsFilter.ShowAllTableValuesInFilterPopup = True
        Me.gvConceptos.OptionsFilter.UseNewCustomFilterDialog = True
        Me.gvConceptos.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways
        Me.gvConceptos.OptionsView.ShowGroupPanel = False
        '
        'txtComentario
        '
        Me.txtComentario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtComentario.Location = New System.Drawing.Point(6, 126)
        Me.txtComentario.Name = "txtComentario"
        Me.txtComentario.Size = New System.Drawing.Size(1129, 40)
        Me.txtComentario.TabIndex = 5
        '
        'lblComentarios
        '
        Me.lblComentarios.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lblComentarios.Appearance.Options.UseFont = True
        Me.lblComentarios.Appearance.Options.UseTextOptions = True
        Me.lblComentarios.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.lblComentarios.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblComentarios.Location = New System.Drawing.Point(6, 103)
        Me.lblComentarios.Name = "lblComentarios"
        Me.lblComentarios.Padding = New System.Windows.Forms.Padding(2)
        Me.lblComentarios.Size = New System.Drawing.Size(135, 18)
        Me.lblComentarios.TabIndex = 112
        Me.lblComentarios.Text = "Comentario General :"
        '
        'txtOficina
        '
        Me.txtOficina.AlineacionTexto = SamitCtlNet.AlinearTexto.Centro
        Me.txtOficina.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtOficina.AltodelControl = 30
        Me.txtOficina.AnchoLabel = 70
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
        Me.txtOficina.Location = New System.Drawing.Point(250, 2)
        Me.txtOficina.MaximoAncho = 0
        Me.txtOficina.MensajedeAyuda = Nothing
        Me.txtOficina.Name = "txtOficina"
        Me.txtOficina.Size = New System.Drawing.Size(448, 30)
        Me.txtOficina.SoloLectura = False
        Me.txtOficina.SoloNumeros = True
        Me.txtOficina.TabIndex = 1
        Me.txtOficina.TextodelControl = ""
        Me.txtOficina.TextoLabel = "Oficina :"
        Me.txtOficina.TieneErrorControl = False
        Me.txtOficina.TipoBusqueda = SamitCtlNet.ModGeneral.TipoBusqueda.Ninguna
        Me.txtOficina.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtOficina.TipodeLetra = New System.Drawing.Font("Arial", 9.0!)
        Me.txtOficina.ValordelControl = ""
        Me.txtOficina.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtOficina.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtOficina.ValorPredeterminado = Nothing
        '
        'lblFecha
        '
        Me.lblFecha.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Appearance.Options.UseFont = True
        Me.lblFecha.Appearance.Options.UseTextOptions = True
        Me.lblFecha.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblFecha.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblFecha.Location = New System.Drawing.Point(33, 2)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Padding = New System.Windows.Forms.Padding(2)
        Me.lblFecha.Size = New System.Drawing.Size(55, 26)
        Me.lblFecha.TabIndex = 115
        Me.lblFecha.Text = "Fecha :"
        '
        'dteFecha
        '
        Me.dteFecha.EditValue = Nothing
        Me.dteFecha.Location = New System.Drawing.Point(94, 5)
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
        Me.dteFecha.Size = New System.Drawing.Size(105, 20)
        Me.dteFecha.TabIndex = 0
        Me.dteFecha.TabStop = False
        '
        'txtTipoComprobante
        '
        Me.txtTipoComprobante.AlineacionTexto = SamitCtlNet.AlinearTexto.Centro
        Me.txtTipoComprobante.AlineacionTitulo = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtTipoComprobante.AltodelControl = 30
        Me.txtTipoComprobante.AnchoLabel = 80
        Me.txtTipoComprobante.AnchoTxt = 50
        Me.txtTipoComprobante.AutoCargarDatos = True
        Me.txtTipoComprobante.AutoSize = True
        Me.txtTipoComprobante.BackColor = System.Drawing.Color.Transparent
        Me.txtTipoComprobante.ColorFondo = System.Drawing.Color.Transparent
        Me.txtTipoComprobante.CondicionValida = ""
        Me.txtTipoComprobante.Conexion = SamitCtlNet.ConexionSAMIT.ConexModulo
        Me.txtTipoComprobante.ConsultaSQL = Nothing
        Me.txtTipoComprobante.EsObligatorio = False
        Me.txtTipoComprobante.FormatoNumero = Nothing
        Me.txtTipoComprobante.Location = New System.Drawing.Point(714, 2)
        Me.txtTipoComprobante.MaximoAncho = 0
        Me.txtTipoComprobante.MensajedeAyuda = Nothing
        Me.txtTipoComprobante.Name = "txtTipoComprobante"
        Me.txtTipoComprobante.Size = New System.Drawing.Size(400, 30)
        Me.txtTipoComprobante.SoloLectura = False
        Me.txtTipoComprobante.SoloNumeros = True
        Me.txtTipoComprobante.TabIndex = 2
        Me.txtTipoComprobante.TextodelControl = ""
        Me.txtTipoComprobante.TextoLabel = "Tipo Comp:"
        Me.txtTipoComprobante.TieneErrorControl = False
        Me.txtTipoComprobante.TipoBusqueda = SamitCtlNet.ModGeneral.TipoBusqueda.Ninguna
        Me.txtTipoComprobante.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtTipoComprobante.TipodeLetra = New System.Drawing.Font("Arial", 9.0!)
        Me.txtTipoComprobante.ValordelControl = ""
        Me.txtTipoComprobante.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTipoComprobante.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTipoComprobante.ValorPredeterminado = Nothing
        '
        'lblNumDoc
        '
        Me.lblNumDoc.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lblNumDoc.Appearance.Options.UseFont = True
        Me.lblNumDoc.Appearance.Options.UseTextOptions = True
        Me.lblNumDoc.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.lblNumDoc.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblNumDoc.Location = New System.Drawing.Point(854, 38)
        Me.lblNumDoc.Name = "lblNumDoc"
        Me.lblNumDoc.Padding = New System.Windows.Forms.Padding(2)
        Me.lblNumDoc.Size = New System.Drawing.Size(126, 18)
        Me.lblNumDoc.TabIndex = 117
        Me.lblNumDoc.Text = "Numero Documento :"
        Me.lblNumDoc.Visible = False
        '
        'lblSecCom
        '
        Me.lblSecCom.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblSecCom.Appearance.Options.UseFont = True
        Me.lblSecCom.Appearance.Options.UseTextOptions = True
        Me.lblSecCom.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.lblSecCom.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblSecCom.Location = New System.Drawing.Point(986, 38)
        Me.lblSecCom.Name = "lblSecCom"
        Me.lblSecCom.Padding = New System.Windows.Forms.Padding(2)
        Me.lblSecCom.Size = New System.Drawing.Size(125, 18)
        Me.lblSecCom.TabIndex = 118
        Me.lblSecCom.Text = "0"
        Me.lblSecCom.Visible = False
        '
        'txtCodComp
        '
        Me.txtCodComp.AlineacionTexto = SamitCtlNet.AlinearTexto.Centro
        Me.txtCodComp.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtCodComp.AltodelControl = 30
        Me.txtCodComp.AnchoLabel = 80
        Me.txtCodComp.AnchoTxt = 50
        Me.txtCodComp.AutoCargarDatos = True
        Me.txtCodComp.AutoSize = True
        Me.txtCodComp.BackColor = System.Drawing.Color.Transparent
        Me.txtCodComp.ColorFondo = System.Drawing.Color.Transparent
        Me.txtCodComp.CondicionValida = ""
        Me.txtCodComp.Conexion = SamitCtlNet.ConexionSAMIT.ConexModulo
        Me.txtCodComp.ConsultaSQL = Nothing
        Me.txtCodComp.EsObligatorio = False
        Me.txtCodComp.FormatoNumero = Nothing
        Me.txtCodComp.Location = New System.Drawing.Point(12, 38)
        Me.txtCodComp.MaximoAncho = 0
        Me.txtCodComp.MensajedeAyuda = Nothing
        Me.txtCodComp.Name = "txtCodComp"
        Me.txtCodComp.Size = New System.Drawing.Size(429, 30)
        Me.txtCodComp.SoloLectura = False
        Me.txtCodComp.SoloNumeros = True
        Me.txtCodComp.TabIndex = 3
        Me.txtCodComp.TextodelControl = ""
        Me.txtCodComp.TextoLabel = "Cod Comp:"
        Me.txtCodComp.TieneErrorControl = False
        Me.txtCodComp.TipoBusqueda = SamitCtlNet.ModGeneral.TipoBusqueda.Ninguna
        Me.txtCodComp.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtCodComp.TipodeLetra = New System.Drawing.Font("Arial", 9.0!)
        Me.txtCodComp.ValordelControl = ""
        Me.txtCodComp.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCodComp.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCodComp.ValorPredeterminado = Nothing
        '
        'Timer1
        '
        Me.Timer1.Interval = 200
        '
        'gcTerceros
        '
        Me.gcTerceros.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcTerceros.Location = New System.Drawing.Point(6, 171)
        Me.gcTerceros.MainView = Me.gvTerceros
        Me.gcTerceros.Name = "gcTerceros"
        Me.gcTerceros.Size = New System.Drawing.Size(1129, 398)
        Me.gcTerceros.TabIndex = 119
        Me.gcTerceros.TabStop = False
        Me.gcTerceros.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvTerceros})
        '
        'gvTerceros
        '
        Me.gvTerceros.GridControl = Me.gcTerceros
        Me.gvTerceros.Name = "gvTerceros"
        Me.gvTerceros.OptionsFilter.ShowAllTableValuesInFilterPopup = True
        Me.gvTerceros.OptionsFilter.UseNewCustomFilterDialog = True
        Me.gvTerceros.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways
        Me.gvTerceros.OptionsView.ShowGroupPanel = False
        '
        'grbVista
        '
        Me.grbVista.EditValue = False
        Me.grbVista.Location = New System.Drawing.Point(487, 42)
        Me.grbVista.Name = "grbVista"
        Me.grbVista.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.grbVista.Properties.Appearance.Options.UseBackColor = True
        Me.grbVista.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.grbVista.Properties.Columns = 2
        Me.grbVista.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.grbVista.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "Terceros"), New DevExpress.XtraEditors.Controls.RadioGroupItem(True, "Movimientos")})
        Me.grbVista.Size = New System.Drawing.Size(174, 25)
        Me.grbVista.TabIndex = 120
        '
        'txtFormadePago
        '
        Me.txtFormadePago.AlineacionTexto = SamitCtlNet.AlinearTexto.Centro
        Me.txtFormadePago.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtFormadePago.AltodelControl = 30
        Me.txtFormadePago.AnchoLabel = 90
        Me.txtFormadePago.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFormadePago.AnchoTxt = 50
        Me.txtFormadePago.AutoCargarDatos = True
        Me.txtFormadePago.AutoSize = True
        Me.txtFormadePago.BackColor = System.Drawing.Color.Transparent
        Me.txtFormadePago.ColorFondo = System.Drawing.Color.Transparent
        Me.txtFormadePago.CondicionValida = ""
        Me.txtFormadePago.Conexion = SamitCtlNet.ConexionSAMIT.ConexModulo
        Me.txtFormadePago.ConsultaSQL = Nothing
        Me.txtFormadePago.EsObligatorio = False
        Me.txtFormadePago.FormatoNumero = Nothing
        Me.txtFormadePago.Location = New System.Drawing.Point(2, 72)
        Me.txtFormadePago.MaximoAncho = 0
        Me.txtFormadePago.MensajedeAyuda = Nothing
        Me.txtFormadePago.Name = "txtFormadePago"
        Me.txtFormadePago.Size = New System.Drawing.Size(475, 30)
        Me.txtFormadePago.SoloLectura = False
        Me.txtFormadePago.SoloNumeros = True
        Me.txtFormadePago.TabIndex = 121
        Me.txtFormadePago.TextodelControl = ""
        Me.txtFormadePago.TextoLabel = "Forma Pago :"
        Me.txtFormadePago.TieneErrorControl = False
        Me.txtFormadePago.TipoBusqueda = SamitCtlNet.ModGeneral.TipoBusqueda.Ninguna
        Me.txtFormadePago.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtFormadePago.TipodeLetra = New System.Drawing.Font("Arial", 9.0!)
        Me.txtFormadePago.ValordelControl = ""
        Me.txtFormadePago.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtFormadePago.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtFormadePago.ValorPredeterminado = Nothing
        '
        'btnAnular
        '
        Me.btnAnular.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnAnular.Appearance.Options.UseFont = True
        Me.btnAnular.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnAnular.Location = New System.Drawing.Point(5, 130)
        Me.btnAnular.Name = "btnAnular"
        Me.btnAnular.Size = New System.Drawing.Size(78, 45)
        Me.btnAnular.TabIndex = 8
        Me.btnAnular.Text = "Anular"
        '
        'FrmContbLiquidaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1234, 572)
        Me.Controls.Add(Me.txtFormadePago)
        Me.Controls.Add(Me.grbVista)
        Me.Controls.Add(Me.gcTerceros)
        Me.Controls.Add(Me.txtCodComp)
        Me.Controls.Add(Me.lblSecCom)
        Me.Controls.Add(Me.lblNumDoc)
        Me.Controls.Add(Me.txtTipoComprobante)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.dteFecha)
        Me.Controls.Add(Me.txtOficina)
        Me.Controls.Add(Me.lblComentarios)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.gcConceptosCont)
        Me.Controls.Add(Me.txtComentario)
        Me.IconOptions.Icon = CType(resources.GetObject("FrmContbLiquidaciones.IconOptions.Icon"), System.Drawing.Icon)
        Me.Name = "FrmContbLiquidaciones"
        Me.Text = "Contabilizar Liquidacion"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.gcConceptosCont, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvConceptos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtComentario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcTerceros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvTerceros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grbVista.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gcConceptosCont As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvConceptos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtComentario As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents lblComentarios As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtOficina As SamitCtlNet.SamitBusq
    Friend WithEvents lblFecha As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dteFecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtTipoComprobante As SamitCtlNet.SamitBusq
    Friend WithEvents lblNumDoc As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblSecCom As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCodComp As SamitCtlNet.SamitBusq
    Friend WithEvents BtnExcell As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents gcTerceros As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvTerceros As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents grbVista As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents txtFormadePago As SamitCtlNet.SamitBusq
    Friend WithEvents btnAnular As DevExpress.XtraEditors.SimpleButton
End Class
