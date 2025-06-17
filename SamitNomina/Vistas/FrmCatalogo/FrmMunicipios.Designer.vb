<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMunicipios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMunicipios))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnLimpiar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEliminar = New DevExpress.XtraEditors.SimpleButton()
        Me.gbxPrincipal = New DevExpress.XtraEditors.GroupControl()
        Me.txtCodMuni = New SamitCtlNet.SamitTexto()
        Me.txtDpto = New SamitCtlNet.SamitBusq()
        Me.txtNombre = New SamitCtlNet.SamitTexto()
        Me.txtIdMuni = New SamitCtlNet.SamitTexto()
        Me.SeparatorControl1 = New DevExpress.XtraEditors.SeparatorControl()
        Me.gcMunicipio = New DevExpress.XtraGrid.GridControl()
        Me.gvMunicipio = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.gbxPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxPrincipal.SuspendLayout()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcMunicipio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvMunicipio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.GroupControl1.CaptionImagePadding = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.GroupControl1.Controls.Add(Me.btnSalir)
        Me.GroupControl1.Controls.Add(Me.btnGuardar)
        Me.GroupControl1.Controls.Add(Me.btnLimpiar)
        Me.GroupControl1.Controls.Add(Me.btnEliminar)
        Me.GroupControl1.Location = New System.Drawing.Point(596, 9)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(88, 555)
        Me.GroupControl1.TabIndex = 5
        Me.GroupControl1.TabStop = True
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
        'gbxPrincipal
        '
        Me.gbxPrincipal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxPrincipal.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.gbxPrincipal.AppearanceCaption.Options.UseFont = True
        Me.gbxPrincipal.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.gbxPrincipal.CaptionImagePadding = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.gbxPrincipal.Controls.Add(Me.txtCodMuni)
        Me.gbxPrincipal.Controls.Add(Me.txtDpto)
        Me.gbxPrincipal.Controls.Add(Me.txtNombre)
        Me.gbxPrincipal.Controls.Add(Me.txtIdMuni)
        Me.gbxPrincipal.Controls.Add(Me.SeparatorControl1)
        Me.gbxPrincipal.Controls.Add(Me.gcMunicipio)
        Me.gbxPrincipal.Location = New System.Drawing.Point(8, 9)
        Me.gbxPrincipal.Name = "gbxPrincipal"
        Me.gbxPrincipal.Size = New System.Drawing.Size(582, 553)
        Me.gbxPrincipal.TabIndex = 1
        Me.gbxPrincipal.TabStop = True
        Me.gbxPrincipal.Text = "Información"
        '
        'txtCodMuni
        '
        Me.txtCodMuni.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtCodMuni.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtCodMuni.AltodelControl = 30
        Me.txtCodMuni.AnchoLabel = 110
        Me.txtCodMuni.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCodMuni.AutoSize = True
        Me.txtCodMuni.BackColor = System.Drawing.Color.Transparent
        Me.txtCodMuni.ColordeFondo = System.Drawing.Color.Transparent
        Me.txtCodMuni.EsObligatorio = False
        Me.txtCodMuni.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodMuni.FormatoNumero = Nothing
        Me.txtCodMuni.Location = New System.Drawing.Point(297, 81)
        Me.txtCodMuni.MaximoAncho = 0
        Me.txtCodMuni.MensajedeAyuda = Nothing
        Me.txtCodMuni.Name = "txtCodMuni"
        Me.txtCodMuni.Size = New System.Drawing.Size(278, 30)
        Me.txtCodMuni.SoloLectura = False
        Me.txtCodMuni.SoloNumeros = False
        Me.txtCodMuni.TabIndex = 4
        Me.txtCodMuni.TextodelControl = ""
        Me.txtCodMuni.TextoLabel = "Código Municipio :"
        Me.txtCodMuni.TieneErrorControl = False
        Me.txtCodMuni.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtCodMuni.TipodeLetra = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtCodMuni.ValordelControl = Nothing
        Me.txtCodMuni.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCodMuni.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCodMuni.ValorPredeterminado = Nothing
        '
        'txtDpto
        '
        Me.txtDpto.AlineacionTexto = SamitCtlNet.AlinearTexto.Centro
        Me.txtDpto.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtDpto.AltodelControl = 30
        Me.txtDpto.AnchoLabel = 110
        Me.txtDpto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDpto.AnchoTxt = 95
        Me.txtDpto.AutoCargarDatos = True
        Me.txtDpto.AutoSize = True
        Me.txtDpto.BackColor = System.Drawing.Color.Transparent
        Me.txtDpto.ColorFondo = System.Drawing.Color.Transparent
        Me.txtDpto.CondicionValida = ""
        Me.txtDpto.Conexion = SamitCtlNet.ConexionSAMIT.ConexSeguridad
        Me.txtDpto.ConsultaSQL = ""
        Me.txtDpto.EsObligatorio = False
        Me.txtDpto.FormatoNumero = Nothing
        Me.txtDpto.Location = New System.Drawing.Point(4, 21)
        Me.txtDpto.MaximoAncho = 0
        Me.txtDpto.MensajedeAyuda = Nothing
        Me.txtDpto.Name = "txtDpto"
        Me.txtDpto.Size = New System.Drawing.Size(571, 30)
        Me.txtDpto.SoloLectura = False
        Me.txtDpto.SoloNumeros = False
        Me.txtDpto.TabIndex = 1
        Me.txtDpto.TextodelControl = ""
        Me.txtDpto.TextoLabel = "Departamento :"
        Me.txtDpto.TieneErrorControl = False
        Me.txtDpto.TipoBusqueda = SamitCtlNet.ModGeneral.TipoBusqueda.Ninguna
        Me.txtDpto.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtDpto.TipodeLetra = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDpto.ValordelControl = ""
        Me.txtDpto.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDpto.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDpto.ValorPredeterminado = Nothing
        '
        'txtNombre
        '
        Me.txtNombre.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtNombre.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtNombre.AltodelControl = 30
        Me.txtNombre.AnchoLabel = 110
        Me.txtNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombre.AutoSize = True
        Me.txtNombre.BackColor = System.Drawing.Color.Transparent
        Me.txtNombre.ColordeFondo = System.Drawing.Color.Transparent
        Me.txtNombre.EsObligatorio = False
        Me.txtNombre.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.FormatoNumero = Nothing
        Me.txtNombre.Location = New System.Drawing.Point(4, 51)
        Me.txtNombre.MaximoAncho = 0
        Me.txtNombre.MensajedeAyuda = Nothing
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(571, 30)
        Me.txtNombre.SoloLectura = False
        Me.txtNombre.SoloNumeros = False
        Me.txtNombre.TabIndex = 2
        Me.txtNombre.TextodelControl = ""
        Me.txtNombre.TextoLabel = "Nombre :"
        Me.txtNombre.TieneErrorControl = False
        Me.txtNombre.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtNombre.TipodeLetra = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtNombre.ValordelControl = Nothing
        Me.txtNombre.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.ValorPredeterminado = Nothing
        '
        'txtIdMuni
        '
        Me.txtIdMuni.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtIdMuni.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtIdMuni.AltodelControl = 30
        Me.txtIdMuni.AnchoLabel = 110
        Me.txtIdMuni.AutoSize = True
        Me.txtIdMuni.BackColor = System.Drawing.Color.Transparent
        Me.txtIdMuni.ColordeFondo = System.Drawing.Color.Transparent
        Me.txtIdMuni.EsObligatorio = False
        Me.txtIdMuni.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdMuni.FormatoNumero = Nothing
        Me.txtIdMuni.Location = New System.Drawing.Point(4, 81)
        Me.txtIdMuni.MaximoAncho = 0
        Me.txtIdMuni.MensajedeAyuda = Nothing
        Me.txtIdMuni.Name = "txtIdMuni"
        Me.txtIdMuni.Size = New System.Drawing.Size(278, 30)
        Me.txtIdMuni.SoloLectura = False
        Me.txtIdMuni.SoloNumeros = False
        Me.txtIdMuni.TabIndex = 3
        Me.txtIdMuni.TextodelControl = ""
        Me.txtIdMuni.TextoLabel = "ID Muncipio :"
        Me.txtIdMuni.TieneErrorControl = False
        Me.txtIdMuni.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtIdMuni.TipodeLetra = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtIdMuni.ValordelControl = Nothing
        Me.txtIdMuni.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtIdMuni.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtIdMuni.ValorPredeterminado = Nothing
        '
        'SeparatorControl1
        '
        Me.SeparatorControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SeparatorControl1.Location = New System.Drawing.Point(4, 117)
        Me.SeparatorControl1.Name = "SeparatorControl1"
        Me.SeparatorControl1.Padding = New System.Windows.Forms.Padding(0)
        Me.SeparatorControl1.Size = New System.Drawing.Size(571, 3)
        Me.SeparatorControl1.TabIndex = 1
        Me.SeparatorControl1.TabStop = False
        '
        'gcMunicipio
        '
        Me.gcMunicipio.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcMunicipio.Location = New System.Drawing.Point(2, 126)
        Me.gcMunicipio.MainView = Me.gvMunicipio
        Me.gcMunicipio.Name = "gcMunicipio"
        Me.gcMunicipio.Size = New System.Drawing.Size(578, 425)
        Me.gcMunicipio.TabIndex = 0
        Me.gcMunicipio.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvMunicipio})
        '
        'gvMunicipio
        '
        Me.gvMunicipio.GridControl = Me.gcMunicipio
        Me.gvMunicipio.Name = "gvMunicipio"
        '
        'FrmMunicipios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 573)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.gbxPrincipal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmMunicipios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Municipios"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.gbxPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxPrincipal.ResumeLayout(False)
        Me.gbxPrincipal.PerformLayout()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcMunicipio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvMunicipio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnLimpiar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gbxPrincipal As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtDpto As SamitCtlNet.SamitBusq
    Friend WithEvents txtNombre As SamitCtlNet.SamitTexto
    Friend WithEvents txtIdMuni As SamitCtlNet.SamitTexto
    Friend WithEvents SeparatorControl1 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents gcMunicipio As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvMunicipio As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtCodMuni As SamitCtlNet.SamitTexto
End Class
