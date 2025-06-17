<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGenPeriodosLiquidacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGenPeriodosLiquidacion))
        Me.gbxPrincipal = New DevExpress.XtraEditors.GroupControl()
        Me.dteFechaDesde = New DevExpress.XtraEditors.DateEdit()
        Me.lblAño = New DevExpress.XtraEditors.LabelControl()
        Me.btnGenerar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.SeparatorControl1 = New DevExpress.XtraEditors.SeparatorControl()
        Me.btnLimpiar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.txtNomina = New SamitCtlNet.SamitBusq()
        Me.gcPeriodos = New DevExpress.XtraGrid.GridControl()
        Me.gvPeriodos = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.gbxPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxPrincipal.SuspendLayout()
        CType(Me.dteFechaDesde.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFechaDesde.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcPeriodos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvPeriodos, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.gbxPrincipal.Controls.Add(Me.dteFechaDesde)
        Me.gbxPrincipal.Controls.Add(Me.lblAño)
        Me.gbxPrincipal.Controls.Add(Me.btnGenerar)
        Me.gbxPrincipal.Controls.Add(Me.btnSalir)
        Me.gbxPrincipal.Controls.Add(Me.SeparatorControl1)
        Me.gbxPrincipal.Controls.Add(Me.btnLimpiar)
        Me.gbxPrincipal.Controls.Add(Me.btnGuardar)
        Me.gbxPrincipal.Controls.Add(Me.txtNomina)
        Me.gbxPrincipal.Controls.Add(Me.gcPeriodos)
        Me.gbxPrincipal.Location = New System.Drawing.Point(9, 11)
        Me.gbxPrincipal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbxPrincipal.Name = "gbxPrincipal"
        Me.gbxPrincipal.Size = New System.Drawing.Size(640, 716)
        Me.gbxPrincipal.TabIndex = 13
        Me.gbxPrincipal.TabStop = True
        '
        'dteFechaDesde
        '
        Me.dteFechaDesde.EditValue = Nothing
        Me.dteFechaDesde.Location = New System.Drawing.Point(138, 81)
        Me.dteFechaDesde.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dteFechaDesde.Name = "dteFechaDesde"
        Me.dteFechaDesde.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteFechaDesde.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteFechaDesde.Size = New System.Drawing.Size(112, 22)
        Me.dteFechaDesde.TabIndex = 2
        '
        'lblAño
        '
        Me.lblAño.Appearance.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.lblAño.Appearance.Options.UseFont = True
        Me.lblAño.Appearance.Options.UseTextOptions = True
        Me.lblAño.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblAño.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblAño.Location = New System.Drawing.Point(1, 79)
        Me.lblAño.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblAño.Name = "lblAño"
        Me.lblAño.Size = New System.Drawing.Size(127, 27)
        Me.lblAño.TabIndex = 1
        Me.lblAño.Text = "Fecha desde :"
        '
        'btnGenerar
        '
        Me.btnGenerar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnGenerar.Appearance.Options.UseFont = True
        Me.btnGenerar.Location = New System.Drawing.Point(254, 74)
        Me.btnGenerar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(97, 37)
        Me.btnGenerar.TabIndex = 3
        Me.btnGenerar.Text = "Generar"
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(545, 74)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(86, 37)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "Salir"
        '
        'SeparatorControl1
        '
        Me.SeparatorControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SeparatorControl1.Location = New System.Drawing.Point(7, 123)
        Me.SeparatorControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SeparatorControl1.Name = "SeparatorControl1"
        Me.SeparatorControl1.Padding = New System.Windows.Forms.Padding(0)
        Me.SeparatorControl1.Size = New System.Drawing.Size(628, 4)
        Me.SeparatorControl1.TabIndex = 126
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnLimpiar.Appearance.Options.UseFont = True
        Me.btnLimpiar.Location = New System.Drawing.Point(451, 74)
        Me.btnLimpiar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(86, 37)
        Me.btnLimpiar.TabIndex = 5
        Me.btnLimpiar.Text = "Limpiar"
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Location = New System.Drawing.Point(358, 74)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(86, 37)
        Me.btnGuardar.TabIndex = 4
        Me.btnGuardar.Text = "Guardar"
        '
        'txtNomina
        '
        Me.txtNomina.AlineacionTexto = SamitCtlNet.AlinearTexto.Centro
        Me.txtNomina.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtNomina.AltodelControl = 30
        Me.txtNomina.AnchoLabel = 110
        Me.txtNomina.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNomina.AnchoTxt = 100
        Me.txtNomina.AutoCargarDatos = True
        Me.txtNomina.AutoSize = True
        Me.txtNomina.BackColor = System.Drawing.Color.Transparent
        Me.txtNomina.ColorFondo = System.Drawing.Color.Transparent
        Me.txtNomina.CondicionValida = ""
        Me.txtNomina.Conexion = SamitCtlNet.ConexionSAMIT.ConexModulo
        Me.txtNomina.ConsultaSQL = Nothing
        Me.txtNomina.DatosDefecto = Nothing
        Me.txtNomina.EsObligatorio = False
        Me.txtNomina.FormatoNumero = Nothing
        Me.txtNomina.ListaColumnas = Nothing
        Me.txtNomina.Location = New System.Drawing.Point(25, 33)
        Me.txtNomina.Margin = New System.Windows.Forms.Padding(5)
        Me.txtNomina.MaximoAncho = 0
        Me.txtNomina.MensajedeAyuda = Nothing
        Me.txtNomina.Name = "txtNomina"
        Me.txtNomina.Size = New System.Drawing.Size(610, 37)
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
        'gcPeriodos
        '
        Me.gcPeriodos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcPeriodos.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gcPeriodos.Location = New System.Drawing.Point(1, 134)
        Me.gcPeriodos.MainView = Me.gvPeriodos
        Me.gcPeriodos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gcPeriodos.Name = "gcPeriodos"
        Me.gcPeriodos.Size = New System.Drawing.Size(638, 581)
        Me.gcPeriodos.TabIndex = 0
        Me.gcPeriodos.TabStop = False
        Me.gcPeriodos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvPeriodos})
        '
        'gvPeriodos
        '
        Me.gvPeriodos.DetailHeight = 431
        Me.gvPeriodos.GridControl = Me.gcPeriodos
        Me.gvPeriodos.Name = "gvPeriodos"
        '
        'FrmGenPeriodosLiquidacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(658, 736)
        Me.Controls.Add(Me.gbxPrincipal)
        Me.IconOptions.Icon = CType(resources.GetObject("FrmGenPeriodosLiquidacion.IconOptions.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmGenPeriodosLiquidacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gen Periodos Liquidación"
        CType(Me.gbxPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxPrincipal.ResumeLayout(False)
        Me.gbxPrincipal.PerformLayout()
        CType(Me.dteFechaDesde.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFechaDesde.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcPeriodos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvPeriodos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbxPrincipal As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SeparatorControl1 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents txtNomina As SamitCtlNet.SamitBusq
    Friend WithEvents gcPeriodos As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvPeriodos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnLimpiar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGenerar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblAño As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dteFechaDesde As DevExpress.XtraEditors.DateEdit
End Class
