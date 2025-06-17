<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAggEntidad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAggEntidad))
        Me.gbxPrincipal = New DevExpress.XtraEditors.GroupControl()
        Me.txtNombre = New SamitCtlNet.SamitTexto()
        Me.txtNit = New SamitCtlNet.SamitTexto()
        Me.SeparatorControl6 = New DevExpress.XtraEditors.SeparatorControl()
        Me.txtTipoEntidad = New SamitCtlNet.SamitBusq()
        Me.txtCtaPasivo = New SamitCtlNet.SamitBusq()
        Me.lblVigente = New DevExpress.XtraEditors.LabelControl()
        Me.grbVigente = New DevExpress.XtraEditors.RadioGroup()
        Me.gcEntidades = New DevExpress.XtraGrid.GridControl()
        Me.gvEntidades = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btnLimpiar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEliminar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        CType(Me.gbxPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxPrincipal.SuspendLayout()
        CType(Me.SeparatorControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grbVigente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcEntidades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvEntidades, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.gbxPrincipal.Controls.Add(Me.txtNombre)
        Me.gbxPrincipal.Controls.Add(Me.txtNit)
        Me.gbxPrincipal.Controls.Add(Me.SeparatorControl6)
        Me.gbxPrincipal.Controls.Add(Me.txtTipoEntidad)
        Me.gbxPrincipal.Controls.Add(Me.txtCtaPasivo)
        Me.gbxPrincipal.Controls.Add(Me.lblVigente)
        Me.gbxPrincipal.Controls.Add(Me.grbVigente)
        Me.gbxPrincipal.Controls.Add(Me.gcEntidades)
        Me.gbxPrincipal.Location = New System.Drawing.Point(7, 7)
        Me.gbxPrincipal.Name = "gbxPrincipal"
        Me.gbxPrincipal.Size = New System.Drawing.Size(628, 556)
        Me.gbxPrincipal.TabIndex = 1
        Me.gbxPrincipal.TabStop = True
        Me.gbxPrincipal.Text = "Datos de la Entidad"
        '
        'txtNombre
        '
        Me.txtNombre.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtNombre.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtNombre.AltodelControl = 30
        Me.txtNombre.AnchoLabel = 90
        Me.txtNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombre.AutoSize = True
        Me.txtNombre.BackColor = System.Drawing.Color.Transparent
        Me.txtNombre.ColordeFondo = System.Drawing.Color.Transparent
        Me.txtNombre.EsObligatorio = False
        Me.txtNombre.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.FormatoNumero = Nothing
        Me.txtNombre.Location = New System.Drawing.Point(254, 88)
        Me.txtNombre.MaximoAncho = 0
        Me.txtNombre.MensajedeAyuda = ""
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(205, 30)
        Me.txtNombre.SoloLectura = False
        Me.txtNombre.SoloNumeros = False
        Me.txtNombre.TabIndex = 4
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
        'txtNit
        '
        Me.txtNit.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtNit.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtNit.AltodelControl = 30
        Me.txtNit.AnchoLabel = 120
        Me.txtNit.AutoSize = True
        Me.txtNit.BackColor = System.Drawing.Color.Transparent
        Me.txtNit.ColordeFondo = System.Drawing.Color.Transparent
        Me.txtNit.EsObligatorio = False
        Me.txtNit.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNit.FormatoNumero = Nothing
        Me.txtNit.Location = New System.Drawing.Point(6, 86)
        Me.txtNit.MaximoAncho = 0
        Me.txtNit.MensajedeAyuda = ""
        Me.txtNit.Name = "txtNit"
        Me.txtNit.Size = New System.Drawing.Size(242, 30)
        Me.txtNit.SoloLectura = False
        Me.txtNit.SoloNumeros = False
        Me.txtNit.TabIndex = 3
        Me.txtNit.TextodelControl = ""
        Me.txtNit.TextoLabel = "Nit :"
        Me.txtNit.TieneErrorControl = False
        Me.txtNit.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtNit.TipodeLetra = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNit.ValordelControl = Nothing
        Me.txtNit.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNit.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNit.ValorPredeterminado = Nothing
        '
        'SeparatorControl6
        '
        Me.SeparatorControl6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SeparatorControl6.Location = New System.Drawing.Point(5, 120)
        Me.SeparatorControl6.Name = "SeparatorControl6"
        Me.SeparatorControl6.Padding = New System.Windows.Forms.Padding(0)
        Me.SeparatorControl6.Size = New System.Drawing.Size(621, 3)
        Me.SeparatorControl6.TabIndex = 95
        '
        'txtTipoEntidad
        '
        Me.txtTipoEntidad.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtTipoEntidad.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtTipoEntidad.AltodelControl = 30
        Me.txtTipoEntidad.AnchoLabel = 120
        Me.txtTipoEntidad.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTipoEntidad.AnchoTxt = 120
        Me.txtTipoEntidad.AutoCargarDatos = True
        Me.txtTipoEntidad.AutoSize = True
        Me.txtTipoEntidad.BackColor = System.Drawing.Color.Transparent
        Me.txtTipoEntidad.ColorFondo = System.Drawing.Color.Transparent
        Me.txtTipoEntidad.CondicionValida = ""
        Me.txtTipoEntidad.Conexion = SamitCtlNet.ConexionSAMIT.ConexModulo
        Me.txtTipoEntidad.ConsultaSQL = ""
        Me.txtTipoEntidad.DatosDefecto = Nothing
        Me.txtTipoEntidad.EsObligatorio = False
        Me.txtTipoEntidad.FormatoNumero = Nothing
        Me.txtTipoEntidad.ListaColumnas = Nothing
        Me.txtTipoEntidad.Location = New System.Drawing.Point(6, 24)
        Me.txtTipoEntidad.MaximoAncho = 0
        Me.txtTipoEntidad.MensajedeAyuda = ""
        Me.txtTipoEntidad.Name = "txtTipoEntidad"
        Me.txtTipoEntidad.Size = New System.Drawing.Size(617, 30)
        Me.txtTipoEntidad.SoloLectura = False
        Me.txtTipoEntidad.SoloNumeros = False
        Me.txtTipoEntidad.TabIndex = 1
        Me.txtTipoEntidad.TextodelControl = ""
        Me.txtTipoEntidad.TextoLabel = "Tipo Entidad :"
        Me.txtTipoEntidad.TieneErrorControl = False
        Me.txtTipoEntidad.TipoBusqueda = SamitCtlNet.ModGeneral.TipoBusqueda.Ninguna
        Me.txtTipoEntidad.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtTipoEntidad.TipodeLetra = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoEntidad.ValordelControl = ""
        Me.txtTipoEntidad.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTipoEntidad.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTipoEntidad.ValorPredeterminado = Nothing
        '
        'txtCtaPasivo
        '
        Me.txtCtaPasivo.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtCtaPasivo.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtCtaPasivo.AltodelControl = 30
        Me.txtCtaPasivo.AnchoLabel = 120
        Me.txtCtaPasivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCtaPasivo.AnchoTxt = 120
        Me.txtCtaPasivo.AutoCargarDatos = True
        Me.txtCtaPasivo.AutoSize = True
        Me.txtCtaPasivo.BackColor = System.Drawing.Color.Transparent
        Me.txtCtaPasivo.ColorFondo = System.Drawing.Color.Transparent
        Me.txtCtaPasivo.CondicionValida = ""
        Me.txtCtaPasivo.Conexion = SamitCtlNet.ConexionSAMIT.ConexModulo
        Me.txtCtaPasivo.ConsultaSQL = Nothing
        Me.txtCtaPasivo.DatosDefecto = Nothing
        Me.txtCtaPasivo.EsObligatorio = False
        Me.txtCtaPasivo.FormatoNumero = Nothing
        Me.txtCtaPasivo.ListaColumnas = Nothing
        Me.txtCtaPasivo.Location = New System.Drawing.Point(6, 54)
        Me.txtCtaPasivo.MaximoAncho = 0
        Me.txtCtaPasivo.MensajedeAyuda = ""
        Me.txtCtaPasivo.Name = "txtCtaPasivo"
        Me.txtCtaPasivo.Size = New System.Drawing.Size(617, 30)
        Me.txtCtaPasivo.SoloLectura = False
        Me.txtCtaPasivo.SoloNumeros = False
        Me.txtCtaPasivo.TabIndex = 2
        Me.txtCtaPasivo.TextodelControl = ""
        Me.txtCtaPasivo.TextoLabel = "Cta. Pasivo :"
        Me.txtCtaPasivo.TieneErrorControl = False
        Me.txtCtaPasivo.TipoBusqueda = SamitCtlNet.ModGeneral.TipoBusqueda.Ninguna
        Me.txtCtaPasivo.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtCtaPasivo.TipodeLetra = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCtaPasivo.ValordelControl = ""
        Me.txtCtaPasivo.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCtaPasivo.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCtaPasivo.ValorPredeterminado = Nothing
        '
        'lblVigente
        '
        Me.lblVigente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblVigente.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lblVigente.Appearance.Options.UseFont = True
        Me.lblVigente.Appearance.Options.UseTextOptions = True
        Me.lblVigente.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblVigente.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblVigente.Location = New System.Drawing.Point(460, 87)
        Me.lblVigente.Name = "lblVigente"
        Me.lblVigente.Padding = New System.Windows.Forms.Padding(2)
        Me.lblVigente.Size = New System.Drawing.Size(67, 26)
        Me.lblVigente.TabIndex = 71
        Me.lblVigente.Text = "Vigente :"
        '
        'grbVigente
        '
        Me.grbVigente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grbVigente.EditValue = True
        Me.grbVigente.Location = New System.Drawing.Point(533, 91)
        Me.grbVigente.Name = "grbVigente"
        Me.grbVigente.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.grbVigente.Properties.Appearance.Options.UseBackColor = True
        Me.grbVigente.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.grbVigente.Properties.Columns = 2
        Me.grbVigente.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.grbVigente.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "NO"), New DevExpress.XtraEditors.Controls.RadioGroupItem(True, "SI")})
        Me.grbVigente.Size = New System.Drawing.Size(90, 20)
        Me.grbVigente.TabIndex = 5
        '
        'gcEntidades
        '
        Me.gcEntidades.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcEntidades.Location = New System.Drawing.Point(2, 129)
        Me.gcEntidades.MainView = Me.gvEntidades
        Me.gcEntidades.Name = "gcEntidades"
        Me.gcEntidades.Size = New System.Drawing.Size(624, 425)
        Me.gcEntidades.TabIndex = 10
        Me.gcEntidades.TabStop = False
        Me.gcEntidades.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvEntidades})
        '
        'gvEntidades
        '
        Me.gvEntidades.GridControl = Me.gcEntidades
        Me.gvEntidades.Name = "gvEntidades"
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
        Me.GroupControl1.Location = New System.Drawing.Point(640, 7)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(88, 556)
        Me.GroupControl1.TabIndex = 2
        Me.GroupControl1.Text = "Opciones"
        '
        'FrmAggEntidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(735, 573)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.gbxPrincipal)
        Me.IconOptions.Icon = CType(resources.GetObject("FrmAggEntidad.IconOptions.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(737, 600)
        Me.Name = "FrmAggEntidad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Entidades"
        CType(Me.gbxPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxPrincipal.ResumeLayout(False)
        Me.gbxPrincipal.PerformLayout()
        CType(Me.SeparatorControl6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grbVigente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcEntidades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvEntidades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbxPrincipal As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnLimpiar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblVigente As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grbVigente As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents gcEntidades As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvEntidades As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtTipoEntidad As SamitCtlNet.SamitBusq
    Friend WithEvents txtCtaPasivo As SamitCtlNet.SamitBusq
    Friend WithEvents SeparatorControl6 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtNit As SamitCtlNet.SamitTexto
    Friend WithEvents txtNombre As SamitCtlNet.SamitTexto
End Class
