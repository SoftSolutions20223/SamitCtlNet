<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmContrato
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmContrato))
        Me.TlpCargos = New System.Windows.Forms.TableLayoutPanel()
        Me.gbxInfBasicaContratos = New DevExpress.XtraEditors.GroupControl()
        Me.txtPerfilCta = New SamitCtlNet.SamitBusq()
        Me.cbxSubTipoTrabajador = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.lblSubTipoTrabajador = New DevExpress.XtraEditors.LabelControl()
        Me.cbxSalarioIntegral = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.lblSalarioIntegral = New DevExpress.XtraEditors.LabelControl()
        Me.txtTipoTrabajador = New SamitCtlNet.SamitBusq()
        Me.cbxTipoCodigo = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.lblUsaCodigo = New DevExpress.XtraEditors.LabelControl()
        Me.cbxAsignacion = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.lblAsignacion = New DevExpress.XtraEditors.LabelControl()
        Me.lblFechaIniC = New DevExpress.XtraEditors.LabelControl()
        Me.dteFechaIniC = New DevExpress.XtraEditors.DateEdit()
        Me.txtAsignaciones = New SamitCtlNet.SamitTexto()
        Me.txtHorasMes = New SamitCtlNet.SamitTexto()
        Me.dteFechaFinC = New DevExpress.XtraEditors.DateEdit()
        Me.lblFechaFinC = New DevExpress.XtraEditors.LabelControl()
        Me.txtCodContrato = New SamitCtlNet.SamitTexto()
        Me.txtNominas = New SamitCtlNet.SamitBusq()
        Me.txtPlantillas = New SamitCtlNet.SamitBusq()
        Me.txtOficina = New SamitCtlNet.SamitBusq()
        Me.txtDependencia = New SamitCtlNet.SamitBusq()
        Me.txtTipoContrato = New SamitCtlNet.SamitBusq()
        Me.gcContratos = New DevExpress.XtraGrid.GridControl()
        Me.gvContratos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btnAddDependencia = New DevExpress.XtraEditors.SimpleButton()
        Me.txtEmpleado = New SamitCtlNet.SamitBusq()
        Me.btnAddTipoContrato = New DevExpress.XtraEditors.SimpleButton()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.gbxInfBasicaCentroC = New DevExpress.XtraEditors.GroupControl()
        Me.BtnConsultaTerCC = New DevExpress.XtraEditors.SimpleButton()
        Me.txtCentroCostos = New SamitCtlNet.SamitBusq()
        Me.btnAggCentroCosto = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEliminarCentroCosto = New DevExpress.XtraEditors.SimpleButton()
        Me.gcCentrosCosto = New DevExpress.XtraGrid.GridControl()
        Me.gvCentrosCosto = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btnAddCentroCosto = New DevExpress.XtraEditors.SimpleButton()
        Me.txtPorcentaje = New SamitCtlNet.SamitTexto()
        Me.gbxInfBasicaCargosContrato = New DevExpress.XtraEditors.GroupControl()
        Me.txtCargos = New SamitCtlNet.SamitBusq()
        Me.btnAggCargosContrato = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEliminarCargosContrato = New DevExpress.XtraEditors.SimpleButton()
        Me.gcCargosContratos = New DevExpress.XtraGrid.GridControl()
        Me.gvCargosContrato = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.lblFechaFinCc = New DevExpress.XtraEditors.LabelControl()
        Me.dteFechaFinCc = New DevExpress.XtraEditors.DateEdit()
        Me.lblFechaIniCc = New DevExpress.XtraEditors.LabelControl()
        Me.dteFechaIniCc = New DevExpress.XtraEditors.DateEdit()
        Me.pnlBotones = New DevExpress.XtraEditors.PanelControl()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEliminar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnLimpiar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TlpCargos.SuspendLayout()
        CType(Me.gbxInfBasicaContratos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxInfBasicaContratos.SuspendLayout()
        CType(Me.cbxSubTipoTrabajador.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxSalarioIntegral.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxTipoCodigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxAsignacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFechaIniC.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFechaIniC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFechaFinC.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFechaFinC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcContratos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvContratos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.gbxInfBasicaCentroC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxInfBasicaCentroC.SuspendLayout()
        CType(Me.gcCentrosCosto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvCentrosCosto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gbxInfBasicaCargosContrato, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxInfBasicaCargosContrato.SuspendLayout()
        CType(Me.gcCargosContratos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvCargosContrato, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFechaFinCc.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFechaFinCc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFechaIniCc.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFechaIniCc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlBotones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBotones.SuspendLayout()
        Me.SuspendLayout()
        '
        'TlpCargos
        '
        Me.TlpCargos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TlpCargos.ColumnCount = 2
        Me.TlpCargos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TlpCargos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TlpCargos.Controls.Add(Me.gbxInfBasicaContratos, 0, 0)
        Me.TlpCargos.Controls.Add(Me.TableLayoutPanel2, 1, 0)
        Me.TlpCargos.Location = New System.Drawing.Point(0, 0)
        Me.TlpCargos.Name = "TlpCargos"
        Me.TlpCargos.RowCount = 1
        Me.TlpCargos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TlpCargos.Size = New System.Drawing.Size(1277, 572)
        Me.TlpCargos.TabIndex = 91
        '
        'gbxInfBasicaContratos
        '
        Me.gbxInfBasicaContratos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxInfBasicaContratos.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.gbxInfBasicaContratos.AppearanceCaption.Options.UseFont = True
        Me.gbxInfBasicaContratos.Controls.Add(Me.txtPerfilCta)
        Me.gbxInfBasicaContratos.Controls.Add(Me.cbxSubTipoTrabajador)
        Me.gbxInfBasicaContratos.Controls.Add(Me.lblSubTipoTrabajador)
        Me.gbxInfBasicaContratos.Controls.Add(Me.cbxSalarioIntegral)
        Me.gbxInfBasicaContratos.Controls.Add(Me.lblSalarioIntegral)
        Me.gbxInfBasicaContratos.Controls.Add(Me.txtTipoTrabajador)
        Me.gbxInfBasicaContratos.Controls.Add(Me.cbxTipoCodigo)
        Me.gbxInfBasicaContratos.Controls.Add(Me.lblUsaCodigo)
        Me.gbxInfBasicaContratos.Controls.Add(Me.cbxAsignacion)
        Me.gbxInfBasicaContratos.Controls.Add(Me.lblAsignacion)
        Me.gbxInfBasicaContratos.Controls.Add(Me.lblFechaIniC)
        Me.gbxInfBasicaContratos.Controls.Add(Me.dteFechaIniC)
        Me.gbxInfBasicaContratos.Controls.Add(Me.txtAsignaciones)
        Me.gbxInfBasicaContratos.Controls.Add(Me.txtHorasMes)
        Me.gbxInfBasicaContratos.Controls.Add(Me.dteFechaFinC)
        Me.gbxInfBasicaContratos.Controls.Add(Me.lblFechaFinC)
        Me.gbxInfBasicaContratos.Controls.Add(Me.txtCodContrato)
        Me.gbxInfBasicaContratos.Controls.Add(Me.txtNominas)
        Me.gbxInfBasicaContratos.Controls.Add(Me.txtPlantillas)
        Me.gbxInfBasicaContratos.Controls.Add(Me.txtOficina)
        Me.gbxInfBasicaContratos.Controls.Add(Me.txtDependencia)
        Me.gbxInfBasicaContratos.Controls.Add(Me.txtTipoContrato)
        Me.gbxInfBasicaContratos.Controls.Add(Me.gcContratos)
        Me.gbxInfBasicaContratos.Controls.Add(Me.btnAddDependencia)
        Me.gbxInfBasicaContratos.Controls.Add(Me.txtEmpleado)
        Me.gbxInfBasicaContratos.Controls.Add(Me.btnAddTipoContrato)
        Me.gbxInfBasicaContratos.Location = New System.Drawing.Point(5, 6)
        Me.gbxInfBasicaContratos.Margin = New System.Windows.Forms.Padding(5, 6, 0, 5)
        Me.gbxInfBasicaContratos.Name = "gbxInfBasicaContratos"
        Me.gbxInfBasicaContratos.Size = New System.Drawing.Size(633, 561)
        Me.gbxInfBasicaContratos.TabIndex = 0
        Me.gbxInfBasicaContratos.Text = "Contratos"
        '
        'txtPerfilCta
        '
        Me.txtPerfilCta.AlineacionTexto = SamitCtlNet.AlinearTexto.Centro
        Me.txtPerfilCta.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtPerfilCta.AltodelControl = 30
        Me.txtPerfilCta.AnchoLabel = 125
        Me.txtPerfilCta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPerfilCta.AnchoTxt = 120
        Me.txtPerfilCta.AutoCargarDatos = True
        Me.txtPerfilCta.AutoSize = True
        Me.txtPerfilCta.BackColor = System.Drawing.Color.Transparent
        Me.txtPerfilCta.ColorFondo = System.Drawing.Color.Transparent
        Me.txtPerfilCta.CondicionValida = ""
        Me.txtPerfilCta.Conexion = SamitCtlNet.ConexionSAMIT.ConexModulo
        Me.txtPerfilCta.ConsultaSQL = Nothing
        Me.txtPerfilCta.DatosDefecto = Nothing
        Me.txtPerfilCta.EsObligatorio = False
        Me.txtPerfilCta.FormatoNumero = Nothing
        Me.txtPerfilCta.ListaColumnas = Nothing
        Me.txtPerfilCta.Location = New System.Drawing.Point(5, 232)
        Me.txtPerfilCta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPerfilCta.MaximoAncho = 0
        Me.txtPerfilCta.MensajedeAyuda = Nothing
        Me.txtPerfilCta.Name = "txtPerfilCta"
        Me.txtPerfilCta.Size = New System.Drawing.Size(625, 30)
        Me.txtPerfilCta.SoloLectura = False
        Me.txtPerfilCta.SoloNumeros = True
        Me.txtPerfilCta.TabIndex = 8
        Me.txtPerfilCta.TextodelControl = ""
        Me.txtPerfilCta.TextoLabel = "Perfil Cuentas :"
        Me.txtPerfilCta.TieneErrorControl = False
        Me.txtPerfilCta.TipoBusqueda = SamitCtlNet.ModGeneral.TipoBusqueda.Ninguna
        Me.txtPerfilCta.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtPerfilCta.TipodeLetra = New System.Drawing.Font("Arial", 9.0!)
        Me.txtPerfilCta.ValordelControl = ""
        Me.txtPerfilCta.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPerfilCta.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPerfilCta.ValorPredeterminado = Nothing
        '
        'cbxSubTipoTrabajador
        '
        Me.cbxSubTipoTrabajador.EditValue = "No Aplica"
        Me.cbxSubTipoTrabajador.Location = New System.Drawing.Point(133, 383)
        Me.cbxSubTipoTrabajador.Name = "cbxSubTipoTrabajador"
        Me.cbxSubTipoTrabajador.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cbxSubTipoTrabajador.Properties.Appearance.Options.UseFont = True
        Me.cbxSubTipoTrabajador.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbxSubTipoTrabajador.Properties.Items.AddRange(New Object() {"No Aplica", "Dependiente pensionado por vejez activo"})
        Me.cbxSubTipoTrabajador.Size = New System.Drawing.Size(115, 24)
        Me.cbxSubTipoTrabajador.TabIndex = 17
        '
        'lblSubTipoTrabajador
        '
        Me.lblSubTipoTrabajador.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTipoTrabajador.Appearance.Options.UseFont = True
        Me.lblSubTipoTrabajador.Appearance.Options.UseTextOptions = True
        Me.lblSubTipoTrabajador.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblSubTipoTrabajador.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblSubTipoTrabajador.Location = New System.Drawing.Point(0, 380)
        Me.lblSubTipoTrabajador.Margin = New System.Windows.Forms.Padding(0)
        Me.lblSubTipoTrabajador.Name = "lblSubTipoTrabajador"
        Me.lblSubTipoTrabajador.Padding = New System.Windows.Forms.Padding(2)
        Me.lblSubTipoTrabajador.Size = New System.Drawing.Size(127, 26)
        Me.lblSubTipoTrabajador.TabIndex = 100
        Me.lblSubTipoTrabajador.Text = "SubTipo Trabajador :"
        '
        'cbxSalarioIntegral
        '
        Me.cbxSalarioIntegral.EditValue = "No"
        Me.cbxSalarioIntegral.Location = New System.Drawing.Point(133, 355)
        Me.cbxSalarioIntegral.Name = "cbxSalarioIntegral"
        Me.cbxSalarioIntegral.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cbxSalarioIntegral.Properties.Appearance.Options.UseFont = True
        Me.cbxSalarioIntegral.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbxSalarioIntegral.Properties.Items.AddRange(New Object() {"No", "Si"})
        Me.cbxSalarioIntegral.Size = New System.Drawing.Size(115, 24)
        Me.cbxSalarioIntegral.TabIndex = 16
        '
        'lblSalarioIntegral
        '
        Me.lblSalarioIntegral.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalarioIntegral.Appearance.Options.UseFont = True
        Me.lblSalarioIntegral.Appearance.Options.UseTextOptions = True
        Me.lblSalarioIntegral.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblSalarioIntegral.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblSalarioIntegral.Location = New System.Drawing.Point(5, 352)
        Me.lblSalarioIntegral.Margin = New System.Windows.Forms.Padding(0)
        Me.lblSalarioIntegral.Name = "lblSalarioIntegral"
        Me.lblSalarioIntegral.Padding = New System.Windows.Forms.Padding(2)
        Me.lblSalarioIntegral.Size = New System.Drawing.Size(122, 26)
        Me.lblSalarioIntegral.TabIndex = 98
        Me.lblSalarioIntegral.Text = "Salario Integral :"
        '
        'txtTipoTrabajador
        '
        Me.txtTipoTrabajador.AlineacionTexto = SamitCtlNet.AlinearTexto.Centro
        Me.txtTipoTrabajador.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtTipoTrabajador.AltodelControl = 30
        Me.txtTipoTrabajador.AnchoLabel = 125
        Me.txtTipoTrabajador.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTipoTrabajador.AnchoTxt = 120
        Me.txtTipoTrabajador.AutoCargarDatos = True
        Me.txtTipoTrabajador.AutoSize = True
        Me.txtTipoTrabajador.BackColor = System.Drawing.Color.Transparent
        Me.txtTipoTrabajador.ColorFondo = System.Drawing.Color.Transparent
        Me.txtTipoTrabajador.CondicionValida = ""
        Me.txtTipoTrabajador.Conexion = SamitCtlNet.ConexionSAMIT.ConexModulo
        Me.txtTipoTrabajador.ConsultaSQL = Nothing
        Me.txtTipoTrabajador.DatosDefecto = Nothing
        Me.txtTipoTrabajador.EsObligatorio = False
        Me.txtTipoTrabajador.FormatoNumero = Nothing
        Me.txtTipoTrabajador.ListaColumnas = Nothing
        Me.txtTipoTrabajador.Location = New System.Drawing.Point(5, 83)
        Me.txtTipoTrabajador.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTipoTrabajador.MaximoAncho = 0
        Me.txtTipoTrabajador.MensajedeAyuda = Nothing
        Me.txtTipoTrabajador.Name = "txtTipoTrabajador"
        Me.txtTipoTrabajador.Size = New System.Drawing.Size(581, 30)
        Me.txtTipoTrabajador.SoloLectura = False
        Me.txtTipoTrabajador.SoloNumeros = True
        Me.txtTipoTrabajador.TabIndex = 3
        Me.txtTipoTrabajador.TextodelControl = ""
        Me.txtTipoTrabajador.TextoLabel = "Tipo Trabajador :"
        Me.txtTipoTrabajador.TieneErrorControl = False
        Me.txtTipoTrabajador.TipoBusqueda = SamitCtlNet.ModGeneral.TipoBusqueda.Ninguna
        Me.txtTipoTrabajador.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtTipoTrabajador.TipodeLetra = New System.Drawing.Font("Arial", 9.0!)
        Me.txtTipoTrabajador.ValordelControl = ""
        Me.txtTipoTrabajador.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTipoTrabajador.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTipoTrabajador.ValorPredeterminado = Nothing
        '
        'cbxTipoCodigo
        '
        Me.cbxTipoCodigo.EditValue = "Usa Código"
        Me.cbxTipoCodigo.Location = New System.Drawing.Point(132, 327)
        Me.cbxTipoCodigo.Name = "cbxTipoCodigo"
        Me.cbxTipoCodigo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cbxTipoCodigo.Properties.Appearance.Options.UseFont = True
        Me.cbxTipoCodigo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbxTipoCodigo.Properties.Items.AddRange(New Object() {"Usa Código", "Usa Secuencial"})
        Me.cbxTipoCodigo.Size = New System.Drawing.Size(115, 24)
        Me.cbxTipoCodigo.TabIndex = 14
        '
        'lblUsaCodigo
        '
        Me.lblUsaCodigo.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsaCodigo.Appearance.Options.UseFont = True
        Me.lblUsaCodigo.Appearance.Options.UseTextOptions = True
        Me.lblUsaCodigo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblUsaCodigo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblUsaCodigo.Location = New System.Drawing.Point(4, 324)
        Me.lblUsaCodigo.Margin = New System.Windows.Forms.Padding(0)
        Me.lblUsaCodigo.Name = "lblUsaCodigo"
        Me.lblUsaCodigo.Padding = New System.Windows.Forms.Padding(2)
        Me.lblUsaCodigo.Size = New System.Drawing.Size(122, 26)
        Me.lblUsaCodigo.TabIndex = 94
        Me.lblUsaCodigo.Text = "Codigo Contrato :"
        '
        'cbxAsignacion
        '
        Me.cbxAsignacion.EditValue = "Manual"
        Me.cbxAsignacion.Location = New System.Drawing.Point(132, 298)
        Me.cbxAsignacion.Name = "cbxAsignacion"
        Me.cbxAsignacion.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cbxAsignacion.Properties.Appearance.Options.UseFont = True
        Me.cbxAsignacion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbxAsignacion.Properties.Items.AddRange(New Object() {"Manual", "Según el Cargo"})
        Me.cbxAsignacion.Size = New System.Drawing.Size(115, 24)
        Me.cbxAsignacion.TabIndex = 12
        '
        'lblAsignacion
        '
        Me.lblAsignacion.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAsignacion.Appearance.Options.UseFont = True
        Me.lblAsignacion.Appearance.Options.UseTextOptions = True
        Me.lblAsignacion.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblAsignacion.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblAsignacion.Location = New System.Drawing.Point(19, 295)
        Me.lblAsignacion.Margin = New System.Windows.Forms.Padding(0)
        Me.lblAsignacion.Name = "lblAsignacion"
        Me.lblAsignacion.Padding = New System.Windows.Forms.Padding(2)
        Me.lblAsignacion.Size = New System.Drawing.Size(108, 26)
        Me.lblAsignacion.TabIndex = 92
        Me.lblAsignacion.Text = "Asignacion :"
        '
        'lblFechaIniC
        '
        Me.lblFechaIniC.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaIniC.Appearance.Options.UseFont = True
        Me.lblFechaIniC.Appearance.Options.UseTextOptions = True
        Me.lblFechaIniC.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblFechaIniC.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblFechaIniC.Location = New System.Drawing.Point(11, 266)
        Me.lblFechaIniC.Margin = New System.Windows.Forms.Padding(0)
        Me.lblFechaIniC.Name = "lblFechaIniC"
        Me.lblFechaIniC.Padding = New System.Windows.Forms.Padding(2)
        Me.lblFechaIniC.Size = New System.Drawing.Size(120, 26)
        Me.lblFechaIniC.TabIndex = 81
        Me.lblFechaIniC.Text = "Desde : "
        '
        'dteFechaIniC
        '
        Me.dteFechaIniC.EditValue = Nothing
        Me.dteFechaIniC.Location = New System.Drawing.Point(132, 269)
        Me.dteFechaIniC.Name = "dteFechaIniC"
        Me.dteFechaIniC.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.dteFechaIniC.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.dteFechaIniC.Properties.Appearance.Options.UseBackColor = True
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
        Me.dteFechaIniC.Size = New System.Drawing.Size(115, 24)
        Me.dteFechaIniC.TabIndex = 9
        '
        'txtAsignaciones
        '
        Me.txtAsignaciones.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtAsignaciones.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtAsignaciones.AltodelControl = 30
        Me.txtAsignaciones.AnchoLabel = 65
        Me.txtAsignaciones.AutoSize = True
        Me.txtAsignaciones.BackColor = System.Drawing.Color.Transparent
        Me.txtAsignaciones.ColordeFondo = System.Drawing.Color.Transparent
        Me.txtAsignaciones.EsObligatorio = False
        Me.txtAsignaciones.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAsignaciones.FormatoNumero = Nothing
        Me.txtAsignaciones.Location = New System.Drawing.Point(264, 294)
        Me.txtAsignaciones.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtAsignaciones.MaximoAncho = 0
        Me.txtAsignaciones.MensajedeAyuda = "Asignación. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
        Me.txtAsignaciones.Name = "txtAsignaciones"
        Me.txtAsignaciones.Size = New System.Drawing.Size(179, 30)
        Me.txtAsignaciones.SoloLectura = False
        Me.txtAsignaciones.SoloNumeros = False
        Me.txtAsignaciones.TabIndex = 13
        Me.txtAsignaciones.TextodelControl = ""
        Me.txtAsignaciones.TextoLabel = "Valor :"
        Me.txtAsignaciones.TieneErrorControl = False
        Me.txtAsignaciones.TipodeDatos = SamitCtlNet.TipodeDato.MonedaConDecimales
        Me.txtAsignaciones.TipodeLetra = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAsignaciones.ValordelControl = Nothing
        Me.txtAsignaciones.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtAsignaciones.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtAsignaciones.ValorPredeterminado = Nothing
        '
        'txtHorasMes
        '
        Me.txtHorasMes.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtHorasMes.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtHorasMes.AltodelControl = 30
        Me.txtHorasMes.AnchoLabel = 85
        Me.txtHorasMes.AutoSize = True
        Me.txtHorasMes.BackColor = System.Drawing.Color.Transparent
        Me.txtHorasMes.ColordeFondo = System.Drawing.Color.Transparent
        Me.txtHorasMes.EsObligatorio = False
        Me.txtHorasMes.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHorasMes.FormatoNumero = Nothing
        Me.txtHorasMes.Location = New System.Drawing.Point(445, 263)
        Me.txtHorasMes.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtHorasMes.MaximoAncho = 0
        Me.txtHorasMes.MensajedeAyuda = "Asignación. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
        Me.txtHorasMes.Name = "txtHorasMes"
        Me.txtHorasMes.Size = New System.Drawing.Size(185, 30)
        Me.txtHorasMes.SoloLectura = False
        Me.txtHorasMes.SoloNumeros = False
        Me.txtHorasMes.TabIndex = 11
        Me.txtHorasMes.TextodelControl = ""
        Me.txtHorasMes.TextoLabel = "Horas Mes :"
        Me.txtHorasMes.TieneErrorControl = False
        Me.txtHorasMes.TipodeDatos = SamitCtlNet.TipodeDato.Numeros
        Me.txtHorasMes.TipodeLetra = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHorasMes.ValordelControl = Nothing
        Me.txtHorasMes.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtHorasMes.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtHorasMes.ValorPredeterminado = Nothing
        '
        'dteFechaFinC
        '
        Me.dteFechaFinC.EditValue = Nothing
        Me.dteFechaFinC.Location = New System.Drawing.Point(332, 269)
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
        Me.dteFechaFinC.Size = New System.Drawing.Size(109, 24)
        Me.dteFechaFinC.TabIndex = 10
        '
        'lblFechaFinC
        '
        Me.lblFechaFinC.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaFinC.Appearance.Options.UseFont = True
        Me.lblFechaFinC.Appearance.Options.UseTextOptions = True
        Me.lblFechaFinC.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblFechaFinC.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblFechaFinC.Location = New System.Drawing.Point(261, 265)
        Me.lblFechaFinC.Margin = New System.Windows.Forms.Padding(0)
        Me.lblFechaFinC.Name = "lblFechaFinC"
        Me.lblFechaFinC.Padding = New System.Windows.Forms.Padding(2)
        Me.lblFechaFinC.Size = New System.Drawing.Size(65, 26)
        Me.lblFechaFinC.TabIndex = 83
        Me.lblFechaFinC.Text = "Hasta :"
        '
        'txtCodContrato
        '
        Me.txtCodContrato.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtCodContrato.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtCodContrato.AltodelControl = 30
        Me.txtCodContrato.AnchoLabel = 65
        Me.txtCodContrato.AutoSize = True
        Me.txtCodContrato.BackColor = System.Drawing.Color.Transparent
        Me.txtCodContrato.ColordeFondo = System.Drawing.Color.Transparent
        Me.txtCodContrato.EsObligatorio = False
        Me.txtCodContrato.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.txtCodContrato.FormatoNumero = Nothing
        Me.txtCodContrato.Location = New System.Drawing.Point(265, 324)
        Me.txtCodContrato.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtCodContrato.MaximoAncho = 0
        Me.txtCodContrato.MensajedeAyuda = "Codigo del contrato. (ENTER,ABJ)=Avanzar"
        Me.txtCodContrato.Name = "txtCodContrato"
        Me.txtCodContrato.Size = New System.Drawing.Size(178, 30)
        Me.txtCodContrato.SoloLectura = False
        Me.txtCodContrato.SoloNumeros = False
        Me.txtCodContrato.TabIndex = 15
        Me.txtCodContrato.TextodelControl = ""
        Me.txtCodContrato.TextoLabel = "Código :"
        Me.txtCodContrato.TieneErrorControl = False
        Me.txtCodContrato.TipodeDatos = SamitCtlNet.TipodeDato.NumerosSinFormato
        Me.txtCodContrato.TipodeLetra = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodContrato.ValordelControl = Nothing
        Me.txtCodContrato.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCodContrato.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCodContrato.ValorPredeterminado = Nothing
        '
        'txtNominas
        '
        Me.txtNominas.AlineacionTexto = SamitCtlNet.AlinearTexto.Centro
        Me.txtNominas.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtNominas.AltodelControl = 30
        Me.txtNominas.AnchoLabel = 125
        Me.txtNominas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNominas.AnchoTxt = 120
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
        Me.txtNominas.Location = New System.Drawing.Point(5, 171)
        Me.txtNominas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNominas.MaximoAncho = 0
        Me.txtNominas.MensajedeAyuda = Nothing
        Me.txtNominas.Name = "txtNominas"
        Me.txtNominas.Size = New System.Drawing.Size(625, 30)
        Me.txtNominas.SoloLectura = False
        Me.txtNominas.SoloNumeros = True
        Me.txtNominas.TabIndex = 6
        Me.txtNominas.TextodelControl = ""
        Me.txtNominas.TextoLabel = "Nominas :"
        Me.txtNominas.TieneErrorControl = False
        Me.txtNominas.TipoBusqueda = SamitCtlNet.ModGeneral.TipoBusqueda.Ninguna
        Me.txtNominas.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtNominas.TipodeLetra = New System.Drawing.Font("Arial", 9.0!)
        Me.txtNominas.ValordelControl = ""
        Me.txtNominas.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNominas.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNominas.ValorPredeterminado = Nothing
        '
        'txtPlantillas
        '
        Me.txtPlantillas.AlineacionTexto = SamitCtlNet.AlinearTexto.Centro
        Me.txtPlantillas.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtPlantillas.AltodelControl = 30
        Me.txtPlantillas.AnchoLabel = 125
        Me.txtPlantillas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPlantillas.AnchoTxt = 120
        Me.txtPlantillas.AutoCargarDatos = True
        Me.txtPlantillas.AutoSize = True
        Me.txtPlantillas.BackColor = System.Drawing.Color.Transparent
        Me.txtPlantillas.ColorFondo = System.Drawing.Color.Transparent
        Me.txtPlantillas.CondicionValida = ""
        Me.txtPlantillas.Conexion = SamitCtlNet.ConexionSAMIT.ConexModulo
        Me.txtPlantillas.ConsultaSQL = Nothing
        Me.txtPlantillas.DatosDefecto = Nothing
        Me.txtPlantillas.EsObligatorio = False
        Me.txtPlantillas.FormatoNumero = Nothing
        Me.txtPlantillas.ListaColumnas = Nothing
        Me.txtPlantillas.Location = New System.Drawing.Point(5, 201)
        Me.txtPlantillas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPlantillas.MaximoAncho = 0
        Me.txtPlantillas.MensajedeAyuda = Nothing
        Me.txtPlantillas.Name = "txtPlantillas"
        Me.txtPlantillas.Size = New System.Drawing.Size(625, 30)
        Me.txtPlantillas.SoloLectura = False
        Me.txtPlantillas.SoloNumeros = True
        Me.txtPlantillas.TabIndex = 7
        Me.txtPlantillas.TextodelControl = ""
        Me.txtPlantillas.TextoLabel = "Perfil Conceptos :"
        Me.txtPlantillas.TieneErrorControl = False
        Me.txtPlantillas.TipoBusqueda = SamitCtlNet.ModGeneral.TipoBusqueda.Ninguna
        Me.txtPlantillas.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtPlantillas.TipodeLetra = New System.Drawing.Font("Arial", 9.0!)
        Me.txtPlantillas.ValordelControl = ""
        Me.txtPlantillas.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPlantillas.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPlantillas.ValorPredeterminado = Nothing
        '
        'txtOficina
        '
        Me.txtOficina.AlineacionTexto = SamitCtlNet.AlinearTexto.Centro
        Me.txtOficina.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtOficina.AltodelControl = 30
        Me.txtOficina.AnchoLabel = 125
        Me.txtOficina.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOficina.AnchoTxt = 120
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
        Me.txtOficina.Location = New System.Drawing.Point(5, 141)
        Me.txtOficina.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtOficina.MaximoAncho = 0
        Me.txtOficina.MensajedeAyuda = Nothing
        Me.txtOficina.Name = "txtOficina"
        Me.txtOficina.Size = New System.Drawing.Size(624, 30)
        Me.txtOficina.SoloLectura = False
        Me.txtOficina.SoloNumeros = True
        Me.txtOficina.TabIndex = 5
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
        'txtDependencia
        '
        Me.txtDependencia.AlineacionTexto = SamitCtlNet.AlinearTexto.Centro
        Me.txtDependencia.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtDependencia.AltodelControl = 30
        Me.txtDependencia.AnchoLabel = 125
        Me.txtDependencia.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDependencia.AnchoTxt = 120
        Me.txtDependencia.AutoCargarDatos = True
        Me.txtDependencia.AutoSize = True
        Me.txtDependencia.BackColor = System.Drawing.Color.Transparent
        Me.txtDependencia.ColorFondo = System.Drawing.Color.Transparent
        Me.txtDependencia.CondicionValida = ""
        Me.txtDependencia.Conexion = SamitCtlNet.ConexionSAMIT.ConexModulo
        Me.txtDependencia.ConsultaSQL = Nothing
        Me.txtDependencia.DatosDefecto = Nothing
        Me.txtDependencia.EsObligatorio = False
        Me.txtDependencia.FormatoNumero = Nothing
        Me.txtDependencia.ListaColumnas = Nothing
        Me.txtDependencia.Location = New System.Drawing.Point(5, 111)
        Me.txtDependencia.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDependencia.MaximoAncho = 0
        Me.txtDependencia.MensajedeAyuda = Nothing
        Me.txtDependencia.Name = "txtDependencia"
        Me.txtDependencia.Size = New System.Drawing.Size(582, 30)
        Me.txtDependencia.SoloLectura = False
        Me.txtDependencia.SoloNumeros = True
        Me.txtDependencia.TabIndex = 4
        Me.txtDependencia.TextodelControl = ""
        Me.txtDependencia.TextoLabel = "Dependencia :"
        Me.txtDependencia.TieneErrorControl = False
        Me.txtDependencia.TipoBusqueda = SamitCtlNet.ModGeneral.TipoBusqueda.Ninguna
        Me.txtDependencia.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtDependencia.TipodeLetra = New System.Drawing.Font("Arial", 9.0!)
        Me.txtDependencia.ValordelControl = ""
        Me.txtDependencia.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDependencia.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDependencia.ValorPredeterminado = Nothing
        '
        'txtTipoContrato
        '
        Me.txtTipoContrato.AlineacionTexto = SamitCtlNet.AlinearTexto.Centro
        Me.txtTipoContrato.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtTipoContrato.AltodelControl = 30
        Me.txtTipoContrato.AnchoLabel = 125
        Me.txtTipoContrato.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTipoContrato.AnchoTxt = 120
        Me.txtTipoContrato.AutoCargarDatos = True
        Me.txtTipoContrato.AutoSize = True
        Me.txtTipoContrato.BackColor = System.Drawing.Color.Transparent
        Me.txtTipoContrato.ColorFondo = System.Drawing.Color.Transparent
        Me.txtTipoContrato.CondicionValida = ""
        Me.txtTipoContrato.Conexion = SamitCtlNet.ConexionSAMIT.ConexModulo
        Me.txtTipoContrato.ConsultaSQL = Nothing
        Me.txtTipoContrato.DatosDefecto = Nothing
        Me.txtTipoContrato.EsObligatorio = False
        Me.txtTipoContrato.FormatoNumero = Nothing
        Me.txtTipoContrato.ListaColumnas = Nothing
        Me.txtTipoContrato.Location = New System.Drawing.Point(5, 54)
        Me.txtTipoContrato.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTipoContrato.MaximoAncho = 0
        Me.txtTipoContrato.MensajedeAyuda = Nothing
        Me.txtTipoContrato.Name = "txtTipoContrato"
        Me.txtTipoContrato.Size = New System.Drawing.Size(582, 30)
        Me.txtTipoContrato.SoloLectura = False
        Me.txtTipoContrato.SoloNumeros = True
        Me.txtTipoContrato.TabIndex = 2
        Me.txtTipoContrato.TextodelControl = ""
        Me.txtTipoContrato.TextoLabel = "Tipo Contrato :"
        Me.txtTipoContrato.TieneErrorControl = False
        Me.txtTipoContrato.TipoBusqueda = SamitCtlNet.ModGeneral.TipoBusqueda.Ninguna
        Me.txtTipoContrato.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtTipoContrato.TipodeLetra = New System.Drawing.Font("Arial", 9.0!)
        Me.txtTipoContrato.ValordelControl = ""
        Me.txtTipoContrato.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTipoContrato.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTipoContrato.ValorPredeterminado = Nothing
        '
        'gcContratos
        '
        Me.gcContratos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcContratos.Location = New System.Drawing.Point(0, 411)
        Me.gcContratos.MainView = Me.gvContratos
        Me.gcContratos.Name = "gcContratos"
        Me.gcContratos.Size = New System.Drawing.Size(633, 142)
        Me.gcContratos.TabIndex = 15
        Me.gcContratos.TabStop = False
        Me.gcContratos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvContratos})
        '
        'gvContratos
        '
        Me.gvContratos.GridControl = Me.gcContratos
        Me.gvContratos.Name = "gvContratos"
        Me.gvContratos.OptionsView.ShowGroupPanel = False
        '
        'btnAddDependencia
        '
        Me.btnAddDependencia.AllowFocus = False
        Me.btnAddDependencia.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddDependencia.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnAddDependencia.Appearance.Options.UseFont = True
        Me.btnAddDependencia.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnAddDependencia.Location = New System.Drawing.Point(592, 113)
        Me.btnAddDependencia.Name = "btnAddDependencia"
        Me.btnAddDependencia.Size = New System.Drawing.Size(34, 25)
        Me.btnAddDependencia.TabIndex = 86
        Me.btnAddDependencia.TabStop = False
        '
        'txtEmpleado
        '
        Me.txtEmpleado.AlineacionTexto = SamitCtlNet.AlinearTexto.Centro
        Me.txtEmpleado.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtEmpleado.AltodelControl = 30
        Me.txtEmpleado.AnchoLabel = 125
        Me.txtEmpleado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEmpleado.AnchoTxt = 120
        Me.txtEmpleado.AutoCargarDatos = True
        Me.txtEmpleado.AutoSize = True
        Me.txtEmpleado.BackColor = System.Drawing.Color.Transparent
        Me.txtEmpleado.ColorFondo = System.Drawing.Color.Transparent
        Me.txtEmpleado.CondicionValida = ""
        Me.txtEmpleado.Conexion = SamitCtlNet.ConexionSAMIT.ConexModulo
        Me.txtEmpleado.ConsultaSQL = Nothing
        Me.txtEmpleado.DatosDefecto = Nothing
        Me.txtEmpleado.EsObligatorio = False
        Me.txtEmpleado.FormatoNumero = Nothing
        Me.txtEmpleado.ListaColumnas = Nothing
        Me.txtEmpleado.Location = New System.Drawing.Point(5, 24)
        Me.txtEmpleado.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtEmpleado.MaximoAncho = 0
        Me.txtEmpleado.MensajedeAyuda = Nothing
        Me.txtEmpleado.Name = "txtEmpleado"
        Me.txtEmpleado.Size = New System.Drawing.Size(624, 30)
        Me.txtEmpleado.SoloLectura = False
        Me.txtEmpleado.SoloNumeros = True
        Me.txtEmpleado.TabIndex = 1
        Me.txtEmpleado.TextodelControl = ""
        Me.txtEmpleado.TextoLabel = "Empleado :"
        Me.txtEmpleado.TieneErrorControl = False
        Me.txtEmpleado.TipoBusqueda = SamitCtlNet.ModGeneral.TipoBusqueda.Ninguna
        Me.txtEmpleado.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtEmpleado.TipodeLetra = New System.Drawing.Font("Arial", 9.0!)
        Me.txtEmpleado.ValordelControl = ""
        Me.txtEmpleado.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtEmpleado.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtEmpleado.ValorPredeterminado = Nothing
        '
        'btnAddTipoContrato
        '
        Me.btnAddTipoContrato.AllowFocus = False
        Me.btnAddTipoContrato.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddTipoContrato.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnAddTipoContrato.Appearance.Options.UseFont = True
        Me.btnAddTipoContrato.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnAddTipoContrato.Location = New System.Drawing.Point(592, 58)
        Me.btnAddTipoContrato.Name = "btnAddTipoContrato"
        Me.btnAddTipoContrato.Size = New System.Drawing.Size(34, 25)
        Me.btnAddTipoContrato.TabIndex = 84
        Me.btnAddTipoContrato.TabStop = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.gbxInfBasicaCentroC, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.gbxInfBasicaCargosContrato, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(641, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(633, 566)
        Me.TableLayoutPanel2.TabIndex = 88
        '
        'gbxInfBasicaCentroC
        '
        Me.gbxInfBasicaCentroC.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxInfBasicaCentroC.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.gbxInfBasicaCentroC.Appearance.Options.UseBackColor = True
        Me.gbxInfBasicaCentroC.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.gbxInfBasicaCentroC.AppearanceCaption.Options.UseFont = True
        Me.gbxInfBasicaCentroC.Controls.Add(Me.BtnConsultaTerCC)
        Me.gbxInfBasicaCentroC.Controls.Add(Me.txtCentroCostos)
        Me.gbxInfBasicaCentroC.Controls.Add(Me.btnAggCentroCosto)
        Me.gbxInfBasicaCentroC.Controls.Add(Me.btnEliminarCentroCosto)
        Me.gbxInfBasicaCentroC.Controls.Add(Me.gcCentrosCosto)
        Me.gbxInfBasicaCentroC.Controls.Add(Me.btnAddCentroCosto)
        Me.gbxInfBasicaCentroC.Controls.Add(Me.txtPorcentaje)
        Me.gbxInfBasicaCentroC.Location = New System.Drawing.Point(3, 286)
        Me.gbxInfBasicaCentroC.Name = "gbxInfBasicaCentroC"
        Me.gbxInfBasicaCentroC.Size = New System.Drawing.Size(627, 277)
        Me.gbxInfBasicaCentroC.TabIndex = 88
        Me.gbxInfBasicaCentroC.Text = "Centros de Costos"
        '
        'BtnConsultaTerCC
        '
        Me.BtnConsultaTerCC.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnConsultaTerCC.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.BtnConsultaTerCC.Appearance.Options.UseFont = True
        Me.BtnConsultaTerCC.Location = New System.Drawing.Point(281, 56)
        Me.BtnConsultaTerCC.Name = "BtnConsultaTerCC"
        Me.BtnConsultaTerCC.Size = New System.Drawing.Size(180, 25)
        Me.BtnConsultaTerCC.TabIndex = 101
        Me.BtnConsultaTerCC.Text = "Consultar Terceros sin CC"
        '
        'txtCentroCostos
        '
        Me.txtCentroCostos.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtCentroCostos.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtCentroCostos.AltodelControl = 30
        Me.txtCentroCostos.AnchoLabel = 110
        Me.txtCentroCostos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCentroCostos.AnchoTxt = 80
        Me.txtCentroCostos.AutoCargarDatos = True
        Me.txtCentroCostos.AutoSize = True
        Me.txtCentroCostos.BackColor = System.Drawing.Color.Transparent
        Me.txtCentroCostos.ColorFondo = System.Drawing.Color.Transparent
        Me.txtCentroCostos.CondicionValida = ""
        Me.txtCentroCostos.Conexion = SamitCtlNet.ConexionSAMIT.ConexModulo
        Me.txtCentroCostos.ConsultaSQL = Nothing
        Me.txtCentroCostos.DatosDefecto = Nothing
        Me.txtCentroCostos.EsObligatorio = False
        Me.txtCentroCostos.FormatoNumero = Nothing
        Me.txtCentroCostos.ListaColumnas = Nothing
        Me.txtCentroCostos.Location = New System.Drawing.Point(4, 24)
        Me.txtCentroCostos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCentroCostos.MaximoAncho = 0
        Me.txtCentroCostos.MensajedeAyuda = Nothing
        Me.txtCentroCostos.Name = "txtCentroCostos"
        Me.txtCentroCostos.Size = New System.Drawing.Size(577, 30)
        Me.txtCentroCostos.SoloLectura = False
        Me.txtCentroCostos.SoloNumeros = True
        Me.txtCentroCostos.TabIndex = 1
        Me.txtCentroCostos.TextodelControl = ""
        Me.txtCentroCostos.TextoLabel = "Centros :"
        Me.txtCentroCostos.TieneErrorControl = False
        Me.txtCentroCostos.TipoBusqueda = SamitCtlNet.ModGeneral.TipoBusqueda.Ninguna
        Me.txtCentroCostos.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtCentroCostos.TipodeLetra = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCentroCostos.ValordelControl = ""
        Me.txtCentroCostos.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCentroCostos.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCentroCostos.ValorPredeterminado = Nothing
        '
        'btnAggCentroCosto
        '
        Me.btnAggCentroCosto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAggCentroCosto.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnAggCentroCosto.Appearance.Options.UseFont = True
        Me.btnAggCentroCosto.Location = New System.Drawing.Point(467, 56)
        Me.btnAggCentroCosto.Name = "btnAggCentroCosto"
        Me.btnAggCentroCosto.Size = New System.Drawing.Size(74, 25)
        Me.btnAggCentroCosto.TabIndex = 3
        Me.btnAggCentroCosto.Text = "Agregar"
        '
        'btnEliminarCentroCosto
        '
        Me.btnEliminarCentroCosto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminarCentroCosto.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnEliminarCentroCosto.Appearance.Options.UseFont = True
        Me.btnEliminarCentroCosto.Location = New System.Drawing.Point(547, 56)
        Me.btnEliminarCentroCosto.Name = "btnEliminarCentroCosto"
        Me.btnEliminarCentroCosto.Size = New System.Drawing.Size(74, 25)
        Me.btnEliminarCentroCosto.TabIndex = 4
        Me.btnEliminarCentroCosto.Text = "Quitar"
        '
        'gcCentrosCosto
        '
        Me.gcCentrosCosto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcCentrosCosto.Location = New System.Drawing.Point(0, 86)
        Me.gcCentrosCosto.MainView = Me.gvCentrosCosto
        Me.gcCentrosCosto.Name = "gcCentrosCosto"
        Me.gcCentrosCosto.Size = New System.Drawing.Size(627, 190)
        Me.gcCentrosCosto.TabIndex = 15
        Me.gcCentrosCosto.TabStop = False
        Me.gcCentrosCosto.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvCentrosCosto})
        '
        'gvCentrosCosto
        '
        Me.gvCentrosCosto.GridControl = Me.gcCentrosCosto
        Me.gvCentrosCosto.Name = "gvCentrosCosto"
        Me.gvCentrosCosto.OptionsView.ShowGroupPanel = False
        '
        'btnAddCentroCosto
        '
        Me.btnAddCentroCosto.AllowFocus = False
        Me.btnAddCentroCosto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddCentroCosto.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnAddCentroCosto.Appearance.Options.UseFont = True
        Me.btnAddCentroCosto.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnAddCentroCosto.Location = New System.Drawing.Point(587, 26)
        Me.btnAddCentroCosto.Name = "btnAddCentroCosto"
        Me.btnAddCentroCosto.Size = New System.Drawing.Size(34, 25)
        Me.btnAddCentroCosto.TabIndex = 100
        Me.btnAddCentroCosto.TabStop = False
        '
        'txtPorcentaje
        '
        Me.txtPorcentaje.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtPorcentaje.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtPorcentaje.AltodelControl = 30
        Me.txtPorcentaje.AnchoLabel = 110
        Me.txtPorcentaje.AutoSize = True
        Me.txtPorcentaje.BackColor = System.Drawing.Color.Transparent
        Me.txtPorcentaje.ColordeFondo = System.Drawing.Color.Transparent
        Me.txtPorcentaje.EsObligatorio = False
        Me.txtPorcentaje.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPorcentaje.FormatoNumero = Nothing
        Me.txtPorcentaje.Location = New System.Drawing.Point(4, 56)
        Me.txtPorcentaje.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtPorcentaje.MaximoAncho = 0
        Me.txtPorcentaje.MensajedeAyuda = "Codigo del cargo. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
        Me.txtPorcentaje.Name = "txtPorcentaje"
        Me.txtPorcentaje.Size = New System.Drawing.Size(222, 30)
        Me.txtPorcentaje.SoloLectura = False
        Me.txtPorcentaje.SoloNumeros = False
        Me.txtPorcentaje.TabIndex = 2
        Me.txtPorcentaje.TextodelControl = ""
        Me.txtPorcentaje.TextoLabel = "Porcentaje :"
        Me.txtPorcentaje.TieneErrorControl = False
        Me.txtPorcentaje.TipodeDatos = SamitCtlNet.TipodeDato.NumerosCon_2_Decimales
        Me.txtPorcentaje.TipodeLetra = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPorcentaje.ValordelControl = Nothing
        Me.txtPorcentaje.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPorcentaje.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPorcentaje.ValorPredeterminado = Nothing
        '
        'gbxInfBasicaCargosContrato
        '
        Me.gbxInfBasicaCargosContrato.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxInfBasicaCargosContrato.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.gbxInfBasicaCargosContrato.Appearance.Options.UseBackColor = True
        Me.gbxInfBasicaCargosContrato.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.gbxInfBasicaCargosContrato.AppearanceCaption.Options.UseFont = True
        Me.gbxInfBasicaCargosContrato.Controls.Add(Me.txtCargos)
        Me.gbxInfBasicaCargosContrato.Controls.Add(Me.btnAggCargosContrato)
        Me.gbxInfBasicaCargosContrato.Controls.Add(Me.btnEliminarCargosContrato)
        Me.gbxInfBasicaCargosContrato.Controls.Add(Me.gcCargosContratos)
        Me.gbxInfBasicaCargosContrato.Controls.Add(Me.lblFechaFinCc)
        Me.gbxInfBasicaCargosContrato.Controls.Add(Me.dteFechaFinCc)
        Me.gbxInfBasicaCargosContrato.Controls.Add(Me.lblFechaIniCc)
        Me.gbxInfBasicaCargosContrato.Controls.Add(Me.dteFechaIniCc)
        Me.gbxInfBasicaCargosContrato.Location = New System.Drawing.Point(3, 3)
        Me.gbxInfBasicaCargosContrato.Name = "gbxInfBasicaCargosContrato"
        Me.gbxInfBasicaCargosContrato.Size = New System.Drawing.Size(627, 277)
        Me.gbxInfBasicaCargosContrato.TabIndex = 86
        Me.gbxInfBasicaCargosContrato.Text = "Cargos del Contrato"
        '
        'txtCargos
        '
        Me.txtCargos.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtCargos.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtCargos.AltodelControl = 30
        Me.txtCargos.AnchoLabel = 110
        Me.txtCargos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCargos.AnchoTxt = 80
        Me.txtCargos.AutoCargarDatos = True
        Me.txtCargos.AutoSize = True
        Me.txtCargos.BackColor = System.Drawing.Color.Transparent
        Me.txtCargos.ColorFondo = System.Drawing.Color.Transparent
        Me.txtCargos.CondicionValida = ""
        Me.txtCargos.Conexion = SamitCtlNet.ConexionSAMIT.ConexModulo
        Me.txtCargos.ConsultaSQL = Nothing
        Me.txtCargos.DatosDefecto = Nothing
        Me.txtCargos.EsObligatorio = False
        Me.txtCargos.FormatoNumero = Nothing
        Me.txtCargos.ListaColumnas = Nothing
        Me.txtCargos.Location = New System.Drawing.Point(4, 23)
        Me.txtCargos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCargos.MaximoAncho = 0
        Me.txtCargos.MensajedeAyuda = Nothing
        Me.txtCargos.Name = "txtCargos"
        Me.txtCargos.Size = New System.Drawing.Size(620, 30)
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
        'btnAggCargosContrato
        '
        Me.btnAggCargosContrato.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAggCargosContrato.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnAggCargosContrato.Appearance.Options.UseFont = True
        Me.btnAggCargosContrato.Location = New System.Drawing.Point(469, 56)
        Me.btnAggCargosContrato.Name = "btnAggCargosContrato"
        Me.btnAggCargosContrato.Size = New System.Drawing.Size(74, 25)
        Me.btnAggCargosContrato.TabIndex = 4
        Me.btnAggCargosContrato.Text = "Agregar"
        '
        'btnEliminarCargosContrato
        '
        Me.btnEliminarCargosContrato.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminarCargosContrato.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnEliminarCargosContrato.Appearance.Options.UseFont = True
        Me.btnEliminarCargosContrato.Location = New System.Drawing.Point(549, 56)
        Me.btnEliminarCargosContrato.Name = "btnEliminarCargosContrato"
        Me.btnEliminarCargosContrato.Size = New System.Drawing.Size(74, 25)
        Me.btnEliminarCargosContrato.TabIndex = 5
        Me.btnEliminarCargosContrato.Text = "Quitar"
        '
        'gcCargosContratos
        '
        Me.gcCargosContratos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcCargosContratos.Location = New System.Drawing.Point(0, 86)
        Me.gcCargosContratos.MainView = Me.gvCargosContrato
        Me.gcCargosContratos.Name = "gcCargosContratos"
        Me.gcCargosContratos.Size = New System.Drawing.Size(627, 190)
        Me.gcCargosContratos.TabIndex = 15
        Me.gcCargosContratos.TabStop = False
        Me.gcCargosContratos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvCargosContrato})
        '
        'gvCargosContrato
        '
        Me.gvCargosContrato.GridControl = Me.gcCargosContratos
        Me.gvCargosContrato.Name = "gvCargosContrato"
        Me.gvCargosContrato.OptionsView.ShowGroupPanel = False
        '
        'lblFechaFinCc
        '
        Me.lblFechaFinCc.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaFinCc.Appearance.Options.UseFont = True
        Me.lblFechaFinCc.Appearance.Options.UseTextOptions = True
        Me.lblFechaFinCc.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblFechaFinCc.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblFechaFinCc.Location = New System.Drawing.Point(227, 54)
        Me.lblFechaFinCc.Name = "lblFechaFinCc"
        Me.lblFechaFinCc.Padding = New System.Windows.Forms.Padding(2)
        Me.lblFechaFinCc.Size = New System.Drawing.Size(80, 26)
        Me.lblFechaFinCc.TabIndex = 97
        Me.lblFechaFinCc.Text = "Fecha Fin :"
        '
        'dteFechaFinCc
        '
        Me.dteFechaFinCc.EditValue = Nothing
        Me.dteFechaFinCc.Location = New System.Drawing.Point(317, 57)
        Me.dteFechaFinCc.Name = "dteFechaFinCc"
        Me.dteFechaFinCc.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.dteFechaFinCc.Properties.Appearance.Options.UseFont = True
        Me.dteFechaFinCc.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.dteFechaFinCc.Properties.AppearanceDropDown.Options.UseFont = True
        Me.dteFechaFinCc.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteFechaFinCc.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteFechaFinCc.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.dteFechaFinCc.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dteFechaFinCc.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.dteFechaFinCc.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dteFechaFinCc.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.dteFechaFinCc.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.dteFechaFinCc.Size = New System.Drawing.Size(116, 24)
        Me.dteFechaFinCc.TabIndex = 3
        '
        'lblFechaIniCc
        '
        Me.lblFechaIniCc.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaIniCc.Appearance.Options.UseFont = True
        Me.lblFechaIniCc.Appearance.Options.UseTextOptions = True
        Me.lblFechaIniCc.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblFechaIniCc.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblFechaIniCc.Location = New System.Drawing.Point(4, 54)
        Me.lblFechaIniCc.Name = "lblFechaIniCc"
        Me.lblFechaIniCc.Padding = New System.Windows.Forms.Padding(2)
        Me.lblFechaIniCc.Size = New System.Drawing.Size(106, 26)
        Me.lblFechaIniCc.TabIndex = 95
        Me.lblFechaIniCc.Text = "Fecha Inicio :"
        '
        'dteFechaIniCc
        '
        Me.dteFechaIniCc.EditValue = Nothing
        Me.dteFechaIniCc.Location = New System.Drawing.Point(118, 57)
        Me.dteFechaIniCc.Name = "dteFechaIniCc"
        Me.dteFechaIniCc.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.dteFechaIniCc.Properties.Appearance.Options.UseFont = True
        Me.dteFechaIniCc.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.dteFechaIniCc.Properties.AppearanceDropDown.Options.UseFont = True
        Me.dteFechaIniCc.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteFechaIniCc.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteFechaIniCc.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.dteFechaIniCc.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dteFechaIniCc.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.dteFechaIniCc.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dteFechaIniCc.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.dteFechaIniCc.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.dteFechaIniCc.Size = New System.Drawing.Size(105, 24)
        Me.dteFechaIniCc.TabIndex = 2
        '
        'pnlBotones
        '
        Me.pnlBotones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlBotones.Controls.Add(Me.Label1)
        Me.pnlBotones.Controls.Add(Me.btnSalir)
        Me.pnlBotones.Controls.Add(Me.btnEliminar)
        Me.pnlBotones.Controls.Add(Me.btnLimpiar)
        Me.pnlBotones.Controls.Add(Me.btnGuardar)
        Me.pnlBotones.Location = New System.Drawing.Point(1, 572)
        Me.pnlBotones.Name = "pnlBotones"
        Me.pnlBotones.Size = New System.Drawing.Size(1276, 56)
        Me.pnlBotones.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(6, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(657, 18)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Hay liquidaciones pendientes en este contrato, por lo tanto no es posible modific" &
    "ar algunos campos."
        Me.Label1.Visible = False
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(924, 9)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(82, 39)
        Me.btnSalir.TabIndex = 19
        Me.btnSalir.Text = "Salir"
        '
        'btnEliminar
        '
        Me.btnEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(1012, 9)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(82, 39)
        Me.btnEliminar.TabIndex = 18
        Me.btnEliminar.Text = "Eliminar"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLimpiar.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnLimpiar.Appearance.Options.UseFont = True
        Me.btnLimpiar.Location = New System.Drawing.Point(1099, 9)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(82, 39)
        Me.btnLimpiar.TabIndex = 17
        Me.btnLimpiar.Text = "Limpiar"
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Location = New System.Drawing.Point(1187, 9)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(82, 39)
        Me.btnGuardar.TabIndex = 16
        Me.btnGuardar.Text = "Guardar"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'FrmContrato
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1278, 629)
        Me.Controls.Add(Me.TlpCargos)
        Me.Controls.Add(Me.pnlBotones)
        Me.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.IconOptions.Icon = CType(resources.GetObject("FrmContrato.IconOptions.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "FrmContrato"
        Me.Text = "Contratos"
        Me.TlpCargos.ResumeLayout(False)
        CType(Me.gbxInfBasicaContratos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxInfBasicaContratos.ResumeLayout(False)
        Me.gbxInfBasicaContratos.PerformLayout()
        CType(Me.cbxSubTipoTrabajador.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxSalarioIntegral.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxTipoCodigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxAsignacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFechaIniC.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFechaIniC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFechaFinC.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFechaFinC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcContratos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvContratos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.gbxInfBasicaCentroC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxInfBasicaCentroC.ResumeLayout(False)
        Me.gbxInfBasicaCentroC.PerformLayout()
        CType(Me.gcCentrosCosto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvCentrosCosto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gbxInfBasicaCargosContrato, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxInfBasicaCargosContrato.ResumeLayout(False)
        Me.gbxInfBasicaCargosContrato.PerformLayout()
        CType(Me.gcCargosContratos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvCargosContrato, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFechaFinCc.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFechaFinCc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFechaIniCc.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFechaIniCc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlBotones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBotones.ResumeLayout(False)
        Me.pnlBotones.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlBotones As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnLimpiar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblFechaFinC As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dteFechaFinC As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lblFechaIniC As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dteFechaIniC As DevExpress.XtraEditors.DateEdit
    Friend WithEvents gcContratos As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvContratos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gbxInfBasicaContratos As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gbxInfBasicaCargosContrato As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblFechaFinCc As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dteFechaFinCc As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lblFechaIniCc As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dteFechaIniCc As DevExpress.XtraEditors.DateEdit
    Friend WithEvents gcCargosContratos As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvCargosContrato As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnAddDependencia As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAddTipoContrato As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gcCentrosCosto As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvCentrosCosto As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gbxInfBasicaCentroC As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtPorcentaje As SamitCtlNet.SamitTexto
    Friend WithEvents btnAddCentroCosto As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TlpCargos As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnAggCargosContrato As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEliminarCargosContrato As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAggCentroCosto As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEliminarCentroCosto As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtEmpleado As SamitCtlNet.SamitBusq
    Friend WithEvents txtOficina As SamitCtlNet.SamitBusq
    Friend WithEvents txtDependencia As SamitCtlNet.SamitBusq
    Friend WithEvents txtTipoContrato As SamitCtlNet.SamitBusq
    Friend WithEvents txtCentroCostos As SamitCtlNet.SamitBusq
    Friend WithEvents txtCargos As SamitCtlNet.SamitBusq
    Friend WithEvents txtPlantillas As SamitCtlNet.SamitBusq
    Friend WithEvents txtNominas As SamitCtlNet.SamitBusq
    Friend WithEvents txtAsignaciones As SamitCtlNet.SamitTexto
    Friend WithEvents txtHorasMes As SamitCtlNet.SamitTexto
    Friend WithEvents txtCodContrato As SamitCtlNet.SamitTexto
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents cbxAsignacion As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lblAsignacion As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbxTipoCodigo As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lblUsaCodigo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbxSubTipoTrabajador As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lblSubTipoTrabajador As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbxSalarioIntegral As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lblSalarioIntegral As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTipoTrabajador As SamitCtlNet.SamitBusq
    Friend WithEvents BtnConsultaTerCC As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtPerfilCta As SamitCtlNet.SamitBusq
End Class
