<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPeriodosLiquidacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPeriodosLiquidacion))
        Me.gbxPrincipal = New DevExpress.XtraEditors.GroupControl()
        Me.dteAño = New SamitCtlNet.SamitTexto()
        Me.SeparatorControl1 = New DevExpress.XtraEditors.SeparatorControl()
        Me.lblFechaFin = New DevExpress.XtraEditors.LabelControl()
        Me.dteFechaFin = New DevExpress.XtraEditors.DateEdit()
        Me.txtNomina = New SamitCtlNet.SamitBusq()
        Me.lblFechaIni = New DevExpress.XtraEditors.LabelControl()
        Me.dteFechaIni = New DevExpress.XtraEditors.DateEdit()
        Me.txtBusqueda = New DevExpress.XtraEditors.TextEdit()
        Me.gcPeriodos = New DevExpress.XtraGrid.GridControl()
        Me.gvPeriodos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btnLimpiar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.btnConsultar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.gbxPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxPrincipal.SuspendLayout()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFechaFin.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFechaFin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFechaIni.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFechaIni.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBusqueda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcPeriodos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvPeriodos, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.gbxPrincipal.CaptionImagePadding = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.gbxPrincipal.Controls.Add(Me.dteAño)
        Me.gbxPrincipal.Controls.Add(Me.SeparatorControl1)
        Me.gbxPrincipal.Controls.Add(Me.lblFechaFin)
        Me.gbxPrincipal.Controls.Add(Me.dteFechaFin)
        Me.gbxPrincipal.Controls.Add(Me.txtNomina)
        Me.gbxPrincipal.Controls.Add(Me.lblFechaIni)
        Me.gbxPrincipal.Controls.Add(Me.dteFechaIni)
        Me.gbxPrincipal.Controls.Add(Me.txtBusqueda)
        Me.gbxPrincipal.Controls.Add(Me.gcPeriodos)
        Me.gbxPrincipal.Location = New System.Drawing.Point(8, 8)
        Me.gbxPrincipal.Name = "gbxPrincipal"
        Me.gbxPrincipal.Size = New System.Drawing.Size(582, 555)
        Me.gbxPrincipal.TabIndex = 0
        Me.gbxPrincipal.TabStop = True
        Me.gbxPrincipal.Text = "Datos del Periodo"
        '
        'dteAño
        '
        Me.dteAño.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.dteAño.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.dteAño.AltodelControl = 30
        Me.dteAño.AnchoLabel = 50
        Me.dteAño.AutoSize = True
        Me.dteAño.BackColor = System.Drawing.Color.Transparent
        Me.dteAño.ColordeFondo = System.Drawing.Color.Transparent
        Me.dteAño.EsObligatorio = False
        Me.dteAño.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dteAño.FormatoNumero = Nothing
        Me.dteAño.Location = New System.Drawing.Point(54, 61)
        Me.dteAño.MaximoAncho = 0
        Me.dteAño.MensajedeAyuda = ""
        Me.dteAño.Name = "dteAño"
        Me.dteAño.Size = New System.Drawing.Size(150, 30)
        Me.dteAño.SoloLectura = False
        Me.dteAño.SoloNumeros = False
        Me.dteAño.TabIndex = 2
        Me.dteAño.TextodelControl = ""
        Me.dteAño.TextoLabel = "Año :"
        Me.dteAño.TieneErrorControl = False
        Me.dteAño.TipodeDatos = SamitCtlNet.TipodeDato.Numeros
        Me.dteAño.TipodeLetra = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dteAño.ValordelControl = Nothing
        Me.dteAño.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.dteAño.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.dteAño.ValorPredeterminado = Nothing
        '
        'SeparatorControl1
        '
        Me.SeparatorControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SeparatorControl1.Location = New System.Drawing.Point(6, 98)
        Me.SeparatorControl1.Name = "SeparatorControl1"
        Me.SeparatorControl1.Padding = New System.Windows.Forms.Padding(0)
        Me.SeparatorControl1.Size = New System.Drawing.Size(571, 3)
        Me.SeparatorControl1.TabIndex = 126
        Me.SeparatorControl1.TabStop = False
        '
        'lblFechaFin
        '
        Me.lblFechaFin.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaFin.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblFechaFin.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblFechaFin.Location = New System.Drawing.Point(378, 61)
        Me.lblFechaFin.Name = "lblFechaFin"
        Me.lblFechaFin.Padding = New System.Windows.Forms.Padding(2)
        Me.lblFechaFin.Size = New System.Drawing.Size(68, 26)
        Me.lblFechaFin.TabIndex = 122
        Me.lblFechaFin.Text = "Hasta :"
        '
        'dteFechaFin
        '
        Me.dteFechaFin.EditValue = Nothing
        Me.dteFechaFin.Location = New System.Drawing.Point(453, 64)
        Me.dteFechaFin.Name = "dteFechaFin"
        Me.dteFechaFin.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.dteFechaFin.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.dteFechaFin.Properties.Appearance.Options.UseBackColor = True
        Me.dteFechaFin.Properties.Appearance.Options.UseFont = True
        Me.dteFechaFin.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.dteFechaFin.Properties.AppearanceDropDown.Options.UseFont = True
        Me.dteFechaFin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteFechaFin.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteFechaFin.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Classic
        Me.dteFechaFin.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.dteFechaFin.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.dteFechaFin.Properties.MaxValue = New Date(2999, 12, 31, 0, 0, 0, 0)
        Me.dteFechaFin.Properties.MinValue = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.dteFechaFin.Properties.NullDate = New Date(2017, 7, 29, 0, 0, 0, 0)
        Me.dteFechaFin.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[False]
        Me.dteFechaFin.Size = New System.Drawing.Size(94, 20)
        Me.dteFechaFin.TabIndex = 4
        '
        'txtNomina
        '
        Me.txtNomina.AlineacionTexto = SamitCtlNet.AlinearTexto.Centro
        Me.txtNomina.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtNomina.AltodelControl = 30
        Me.txtNomina.AnchoLabel = 100
        Me.txtNomina.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNomina.AnchoTxt = 68
        Me.txtNomina.AutoCargarDatos = True
        Me.txtNomina.AutoSize = True
        Me.txtNomina.BackColor = System.Drawing.Color.Transparent
        Me.txtNomina.ColorFondo = System.Drawing.Color.Transparent
        Me.txtNomina.CondicionValida = ""
        Me.txtNomina.Conexion = SamitCtlNet.ConexionSAMIT.ConexModulo
        Me.txtNomina.ConsultaSQL = Nothing
        Me.txtNomina.EsObligatorio = False
        Me.txtNomina.FormatoNumero = Nothing
        Me.txtNomina.Location = New System.Drawing.Point(4, 27)
        Me.txtNomina.MaximoAncho = 0
        Me.txtNomina.MensajedeAyuda = Nothing
        Me.txtNomina.Name = "txtNomina"
        Me.txtNomina.Size = New System.Drawing.Size(573, 30)
        Me.txtNomina.SoloLectura = False
        Me.txtNomina.SoloNumeros = True
        Me.txtNomina.TabIndex = 1
        Me.txtNomina.TextodelControl = ""
        Me.txtNomina.TextoLabel = "Nomina :"
        Me.txtNomina.TieneErrorControl = False
        Me.txtNomina.TipoBusqueda = SamitCtlNet.ModGeneral.TipoBusqueda.Ninguna
        Me.txtNomina.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtNomina.TipodeLetra = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomina.ValordelControl = ""
        Me.txtNomina.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNomina.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNomina.ValorPredeterminado = Nothing
        '
        'lblFechaIni
        '
        Me.lblFechaIni.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaIni.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblFechaIni.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblFechaIni.Location = New System.Drawing.Point(203, 62)
        Me.lblFechaIni.Name = "lblFechaIni"
        Me.lblFechaIni.Padding = New System.Windows.Forms.Padding(2)
        Me.lblFechaIni.Size = New System.Drawing.Size(68, 26)
        Me.lblFechaIni.TabIndex = 119
        Me.lblFechaIni.Text = "Desde :"
        '
        'dteFechaIni
        '
        Me.dteFechaIni.EditValue = Nothing
        Me.dteFechaIni.Location = New System.Drawing.Point(278, 65)
        Me.dteFechaIni.Name = "dteFechaIni"
        Me.dteFechaIni.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.dteFechaIni.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.dteFechaIni.Properties.Appearance.Options.UseBackColor = True
        Me.dteFechaIni.Properties.Appearance.Options.UseFont = True
        Me.dteFechaIni.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.dteFechaIni.Properties.AppearanceDropDown.Options.UseFont = True
        Me.dteFechaIni.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteFechaIni.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteFechaIni.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Classic
        Me.dteFechaIni.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.dteFechaIni.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dteFechaIni.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.dteFechaIni.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dteFechaIni.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.dteFechaIni.Properties.MaxValue = New Date(2999, 12, 31, 0, 0, 0, 0)
        Me.dteFechaIni.Properties.MinValue = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.dteFechaIni.Properties.NullDate = New Date(2017, 7, 29, 16, 11, 32, 416)
        Me.dteFechaIni.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[False]
        Me.dteFechaIni.Size = New System.Drawing.Size(95, 20)
        Me.dteFechaIni.TabIndex = 3
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBusqueda.Location = New System.Drawing.Point(2, 107)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.txtBusqueda.Properties.Appearance.Options.UseFont = True
        Me.txtBusqueda.Size = New System.Drawing.Size(578, 24)
        Me.txtBusqueda.TabIndex = 100
        Me.txtBusqueda.TabStop = False
        '
        'gcPeriodos
        '
        Me.gcPeriodos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcPeriodos.Location = New System.Drawing.Point(1, 135)
        Me.gcPeriodos.MainView = Me.gvPeriodos
        Me.gcPeriodos.Name = "gcPeriodos"
        Me.gcPeriodos.Size = New System.Drawing.Size(580, 418)
        Me.gcPeriodos.TabIndex = 0
        Me.gcPeriodos.TabStop = False
        Me.gcPeriodos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvPeriodos})
        '
        'gvPeriodos
        '
        Me.gvPeriodos.GridControl = Me.gcPeriodos
        Me.gvPeriodos.Name = "gvPeriodos"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLimpiar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnLimpiar.Appearance.Options.UseFont = True
        Me.btnLimpiar.Location = New System.Drawing.Point(7, 96)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(74, 30)
        Me.btnLimpiar.TabIndex = 3
        Me.btnLimpiar.Text = "Limpiar"
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(7, 132)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(74, 30)
        Me.btnSalir.TabIndex = 7
        Me.btnSalir.Text = "Salir"
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.GroupControl1.CaptionImagePadding = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.GroupControl1.Controls.Add(Me.btnConsultar)
        Me.GroupControl1.Controls.Add(Me.btnSalir)
        Me.GroupControl1.Controls.Add(Me.btnLimpiar)
        Me.GroupControl1.Controls.Add(Me.btnGuardar)
        Me.GroupControl1.Location = New System.Drawing.Point(596, 8)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(88, 555)
        Me.GroupControl1.TabIndex = 5
        Me.GroupControl1.TabStop = True
        Me.GroupControl1.Text = "Opciones"
        '
        'btnConsultar
        '
        Me.btnConsultar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnConsultar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnConsultar.Appearance.Options.UseFont = True
        Me.btnConsultar.Location = New System.Drawing.Point(7, 24)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(74, 30)
        Me.btnConsultar.TabIndex = 1
        Me.btnConsultar.Text = "Buscar"
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Location = New System.Drawing.Point(7, 60)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(74, 30)
        Me.btnGuardar.TabIndex = 2
        Me.btnGuardar.Text = "Guardar"
        '
        'FrmPeriodosLiquidacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 573)
        Me.Controls.Add(Me.gbxPrincipal)
        Me.Controls.Add(Me.GroupControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmPeriodosLiquidacion"
        Me.Text = "Periodos de Liquidación"
        CType(Me.gbxPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxPrincipal.ResumeLayout(False)
        Me.gbxPrincipal.PerformLayout()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFechaFin.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFechaFin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFechaIni.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFechaIni.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBusqueda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcPeriodos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvPeriodos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbxPrincipal As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblFechaFin As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dteFechaFin As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtNomina As SamitCtlNet.SamitBusq
    Friend WithEvents lblFechaIni As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dteFechaIni As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtBusqueda As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnLimpiar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gcPeriodos As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvPeriodos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SeparatorControl1 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents btnConsultar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dteAño As SamitCtlNet.SamitTexto
End Class
