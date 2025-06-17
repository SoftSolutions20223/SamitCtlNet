<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAggDesDetallesVar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAggDesDetallesVar))
        Me.gbxPrincipal = New DevExpress.XtraEditors.GroupControl()
        Me.txtTipoIncapacidad = New SamitCtlNet.SamitBusq()
        Me.txtCantidad = New SamitCtlNet.SamitTexto()
        Me.lblFechaFin = New DevExpress.XtraEditors.LabelControl()
        Me.dteFechaFin = New DevExpress.XtraEditors.DateEdit()
        Me.lblFechaIni = New DevExpress.XtraEditors.LabelControl()
        Me.dteFechaIni = New DevExpress.XtraEditors.DateEdit()
        Me.SeparatorControl6 = New DevExpress.XtraEditors.SeparatorControl()
        Me.gcDetalles = New DevExpress.XtraGrid.GridControl()
        Me.gvDetalles = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEliminar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnLimpiar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.gbxPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxPrincipal.SuspendLayout()
        CType(Me.dteFechaFin.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFechaFin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFechaIni.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFechaIni.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeparatorControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcDetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvDetalles, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.gbxPrincipal.CaptionImageOptions.Padding = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.gbxPrincipal.Controls.Add(Me.txtTipoIncapacidad)
        Me.gbxPrincipal.Controls.Add(Me.txtCantidad)
        Me.gbxPrincipal.Controls.Add(Me.lblFechaFin)
        Me.gbxPrincipal.Controls.Add(Me.dteFechaFin)
        Me.gbxPrincipal.Controls.Add(Me.lblFechaIni)
        Me.gbxPrincipal.Controls.Add(Me.dteFechaIni)
        Me.gbxPrincipal.Controls.Add(Me.SeparatorControl6)
        Me.gbxPrincipal.Controls.Add(Me.gcDetalles)
        Me.gbxPrincipal.Location = New System.Drawing.Point(6, 9)
        Me.gbxPrincipal.Name = "gbxPrincipal"
        Me.gbxPrincipal.Size = New System.Drawing.Size(687, 536)
        Me.gbxPrincipal.TabIndex = 2
        Me.gbxPrincipal.TabStop = True
        Me.gbxPrincipal.Text = "Agrega Detalles"
        '
        'txtTipoIncapacidad
        '
        Me.txtTipoIncapacidad.AlineacionTexto = SamitCtlNet.AlinearTexto.Centro
        Me.txtTipoIncapacidad.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtTipoIncapacidad.AltodelControl = 30
        Me.txtTipoIncapacidad.AnchoLabel = 120
        Me.txtTipoIncapacidad.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTipoIncapacidad.AnchoTxt = 95
        Me.txtTipoIncapacidad.AutoCargarDatos = True
        Me.txtTipoIncapacidad.AutoSize = True
        Me.txtTipoIncapacidad.BackColor = System.Drawing.Color.Transparent
        Me.txtTipoIncapacidad.ColorFondo = System.Drawing.Color.Transparent
        Me.txtTipoIncapacidad.CondicionValida = ""
        Me.txtTipoIncapacidad.Conexion = SamitCtlNet.ConexionSAMIT.ConexSeguridad
        Me.txtTipoIncapacidad.ConsultaSQL = ""
        Me.txtTipoIncapacidad.EsObligatorio = False
        Me.txtTipoIncapacidad.FormatoNumero = Nothing
        Me.txtTipoIncapacidad.Location = New System.Drawing.Point(8, 26)
        Me.txtTipoIncapacidad.MaximoAncho = 0
        Me.txtTipoIncapacidad.MensajedeAyuda = Nothing
        Me.txtTipoIncapacidad.Name = "txtTipoIncapacidad"
        Me.txtTipoIncapacidad.Size = New System.Drawing.Size(673, 30)
        Me.txtTipoIncapacidad.SoloLectura = False
        Me.txtTipoIncapacidad.SoloNumeros = False
        Me.txtTipoIncapacidad.TabIndex = 1
        Me.txtTipoIncapacidad.TextodelControl = ""
        Me.txtTipoIncapacidad.TextoLabel = "Tipo Incapacidad :"
        Me.txtTipoIncapacidad.TieneErrorControl = False
        Me.txtTipoIncapacidad.TipoBusqueda = SamitCtlNet.ModGeneral.TipoBusqueda.Ninguna
        Me.txtTipoIncapacidad.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtTipoIncapacidad.TipodeLetra = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoIncapacidad.ValordelControl = ""
        Me.txtTipoIncapacidad.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTipoIncapacidad.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTipoIncapacidad.ValorPredeterminado = Nothing
        '
        'txtCantidad
        '
        Me.txtCantidad.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtCantidad.AlineacionTitulo = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtCantidad.AltodelControl = 30
        Me.txtCantidad.AnchoLabel = 70
        Me.txtCantidad.AutoSize = True
        Me.txtCantidad.BackColor = System.Drawing.Color.Transparent
        Me.txtCantidad.ColordeFondo = System.Drawing.Color.Transparent
        Me.txtCantidad.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtCantidad.EsObligatorio = False
        Me.txtCantidad.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.FormatoNumero = Nothing
        Me.txtCantidad.Location = New System.Drawing.Point(59, 108)
        Me.txtCantidad.MaximoAncho = 0
        Me.txtCantidad.MensajedeAyuda = ""
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(201, 30)
        Me.txtCantidad.SoloLectura = False
        Me.txtCantidad.SoloNumeros = False
        Me.txtCantidad.TabIndex = 4
        Me.txtCantidad.TextodelControl = ""
        Me.txtCantidad.TextoLabel = "Cantidad :"
        Me.txtCantidad.TieneErrorControl = False
        Me.txtCantidad.TipodeDatos = SamitCtlNet.TipodeDato.Numeros
        Me.txtCantidad.TipodeLetra = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtCantidad.ValordelControl = Nothing
        Me.txtCantidad.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCantidad.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCantidad.ValorPredeterminado = Nothing
        '
        'lblFechaFin
        '
        Me.lblFechaFin.Location = New System.Drawing.Point(104, 86)
        Me.lblFechaFin.Name = "lblFechaFin"
        Me.lblFechaFin.Size = New System.Drawing.Size(18, 13)
        Me.lblFechaFin.TabIndex = 100
        Me.lblFechaFin.Text = "Fin:"
        '
        'dteFechaFin
        '
        Me.dteFechaFin.EditValue = Nothing
        Me.dteFechaFin.Location = New System.Drawing.Point(131, 83)
        Me.dteFechaFin.Name = "dteFechaFin"
        Me.dteFechaFin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteFechaFin.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteFechaFin.Properties.DisplayFormat.FormatString = "dd/MM/yyyy:hh:mm:ss"
        Me.dteFechaFin.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dteFechaFin.Properties.EditFormat.FormatString = "dd/MM/yyyy:hh:mm:ss"
        Me.dteFechaFin.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dteFechaFin.Properties.Mask.EditMask = "G"
        Me.dteFechaFin.Size = New System.Drawing.Size(317, 20)
        Me.dteFechaFin.TabIndex = 3
        '
        'lblFechaIni
        '
        Me.lblFechaIni.Location = New System.Drawing.Point(93, 60)
        Me.lblFechaIni.Name = "lblFechaIni"
        Me.lblFechaIni.Size = New System.Drawing.Size(29, 13)
        Me.lblFechaIni.TabIndex = 98
        Me.lblFechaIni.Text = "Inicio:"
        '
        'dteFechaIni
        '
        Me.dteFechaIni.EditValue = Nothing
        Me.dteFechaIni.Location = New System.Drawing.Point(131, 57)
        Me.dteFechaIni.Name = "dteFechaIni"
        Me.dteFechaIni.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteFechaIni.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteFechaIni.Properties.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
        Me.dteFechaIni.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dteFechaIni.Properties.EditFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
        Me.dteFechaIni.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dteFechaIni.Properties.Mask.EditMask = "G"
        Me.dteFechaIni.Size = New System.Drawing.Size(317, 20)
        Me.dteFechaIni.TabIndex = 2
        '
        'SeparatorControl6
        '
        Me.SeparatorControl6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SeparatorControl6.Location = New System.Drawing.Point(7, 140)
        Me.SeparatorControl6.Name = "SeparatorControl6"
        Me.SeparatorControl6.Padding = New System.Windows.Forms.Padding(0)
        Me.SeparatorControl6.Size = New System.Drawing.Size(674, 3)
        Me.SeparatorControl6.TabIndex = 96
        '
        'gcDetalles
        '
        Me.gcDetalles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcDetalles.Location = New System.Drawing.Point(1, 144)
        Me.gcDetalles.MainView = Me.gvDetalles
        Me.gcDetalles.Name = "gcDetalles"
        Me.gcDetalles.Size = New System.Drawing.Size(685, 389)
        Me.gcDetalles.TabIndex = 93
        Me.gcDetalles.TabStop = False
        Me.gcDetalles.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvDetalles})
        '
        'gvDetalles
        '
        Me.gvDetalles.GridControl = Me.gcDetalles
        Me.gvDetalles.Name = "gvDetalles"
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
        Me.GroupControl1.Controls.Add(Me.btnEliminar)
        Me.GroupControl1.Controls.Add(Me.btnLimpiar)
        Me.GroupControl1.Controls.Add(Me.btnGuardar)
        Me.GroupControl1.Location = New System.Drawing.Point(699, 9)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(88, 537)
        Me.GroupControl1.TabIndex = 4
        Me.GroupControl1.Text = "Opciones"
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(7, 132)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(74, 30)
        Me.btnSalir.TabIndex = 7
        Me.btnSalir.Text = "Salir"
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(7, 96)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(74, 30)
        Me.btnEliminar.TabIndex = 6
        Me.btnEliminar.Text = "Eliminar"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnLimpiar.Appearance.Options.UseFont = True
        Me.btnLimpiar.Location = New System.Drawing.Point(7, 60)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(74, 30)
        Me.btnLimpiar.TabIndex = 5
        Me.btnLimpiar.Text = "Limpiar"
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Location = New System.Drawing.Point(7, 24)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(74, 30)
        Me.btnGuardar.TabIndex = 4
        Me.btnGuardar.Text = "Guardar"
        '
        'FrmAggDesDetallesVar
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 553)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.gbxPrincipal)
        Me.IconOptions.LargeImage = CType(resources.GetObject("FrmAggDesDetallesVar.IconOptions.LargeImage"), System.Drawing.Image)
        Me.Name = "FrmAggDesDetallesVar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalles Conceptos Nomina"
        CType(Me.gbxPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxPrincipal.ResumeLayout(False)
        Me.gbxPrincipal.PerformLayout()
        CType(Me.dteFechaFin.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFechaFin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFechaIni.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFechaIni.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeparatorControl6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcDetalles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvDetalles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbxPrincipal As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SeparatorControl6 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents gcDetalles As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvDetalles As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnLimpiar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblFechaFin As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dteFechaFin As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lblFechaIni As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dteFechaIni As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtCantidad As SamitCtlNet.SamitTexto
    Friend WithEvents txtTipoIncapacidad As SamitCtlNet.SamitBusq
End Class
