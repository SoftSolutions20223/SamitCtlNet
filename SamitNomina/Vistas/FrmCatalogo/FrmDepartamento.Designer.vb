<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDepartamento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDepartamento))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnLimpiar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEliminar = New DevExpress.XtraEditors.SimpleButton()
        Me.gbxPrincipal = New DevExpress.XtraEditors.GroupControl()
        Me.txtPais = New SamitCtlNet.SamitBusq()
        Me.txtNombre = New SamitCtlNet.SamitTexto()
        Me.txtCodDpto = New SamitCtlNet.SamitTexto()
        Me.SeparatorControl1 = New DevExpress.XtraEditors.SeparatorControl()
        Me.gcDpto = New DevExpress.XtraGrid.GridControl()
        Me.gvDpto = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.gbxPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxPrincipal.SuspendLayout()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcDpto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvDpto, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GroupControl1.TabIndex = 4
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
        Me.gbxPrincipal.CaptionImagePadding = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.gbxPrincipal.Controls.Add(Me.txtPais)
        Me.gbxPrincipal.Controls.Add(Me.txtNombre)
        Me.gbxPrincipal.Controls.Add(Me.txtCodDpto)
        Me.gbxPrincipal.Controls.Add(Me.SeparatorControl1)
        Me.gbxPrincipal.Controls.Add(Me.gcDpto)
        Me.gbxPrincipal.Location = New System.Drawing.Point(8, 9)
        Me.gbxPrincipal.Name = "gbxPrincipal"
        Me.gbxPrincipal.Size = New System.Drawing.Size(582, 553)
        Me.gbxPrincipal.TabIndex = 1
        Me.gbxPrincipal.TabStop = True
        Me.gbxPrincipal.Text = "Información"
        '
        'txtPais
        '
        Me.txtPais.AlineacionTexto = SamitCtlNet.AlinearTexto.Centro
        Me.txtPais.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtPais.AltodelControl = 30
        Me.txtPais.AnchoLabel = 110
        Me.txtPais.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPais.AnchoTxt = 95
        Me.txtPais.AutoCargarDatos = True
        Me.txtPais.AutoSize = True
        Me.txtPais.BackColor = System.Drawing.Color.Transparent
        Me.txtPais.ColorFondo = System.Drawing.Color.Transparent
        Me.txtPais.CondicionValida = ""
        Me.txtPais.Conexion = SamitCtlNet.ConexionSAMIT.ConexSeguridad
        Me.txtPais.ConsultaSQL = ""
        Me.txtPais.EsObligatorio = False
        Me.txtPais.FormatoNumero = Nothing
        Me.txtPais.Location = New System.Drawing.Point(4, 20)
        Me.txtPais.MaximoAncho = 0
        Me.txtPais.MensajedeAyuda = Nothing
        Me.txtPais.Name = "txtPais"
        Me.txtPais.Size = New System.Drawing.Size(571, 30)
        Me.txtPais.SoloLectura = False
        Me.txtPais.SoloNumeros = False
        Me.txtPais.TabIndex = 1
        Me.txtPais.TextodelControl = ""
        Me.txtPais.TextoLabel = "País :"
        Me.txtPais.TieneErrorControl = False
        Me.txtPais.TipoBusqueda = SamitCtlNet.ModGeneral.TipoBusqueda.Ninguna
        Me.txtPais.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtPais.TipodeLetra = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPais.ValordelControl = ""
        Me.txtPais.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPais.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPais.ValorPredeterminado = Nothing
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
        Me.txtNombre.Location = New System.Drawing.Point(247, 51)
        Me.txtNombre.MaximoAncho = 0
        Me.txtNombre.MensajedeAyuda = Nothing
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(328, 30)
        Me.txtNombre.SoloLectura = False
        Me.txtNombre.SoloNumeros = False
        Me.txtNombre.TabIndex = 3
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
        'txtCodDpto
        '
        Me.txtCodDpto.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtCodDpto.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtCodDpto.AltodelControl = 30
        Me.txtCodDpto.AnchoLabel = 110
        Me.txtCodDpto.AutoSize = True
        Me.txtCodDpto.BackColor = System.Drawing.Color.Transparent
        Me.txtCodDpto.ColordeFondo = System.Drawing.Color.Transparent
        Me.txtCodDpto.EsObligatorio = False
        Me.txtCodDpto.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodDpto.FormatoNumero = Nothing
        Me.txtCodDpto.Location = New System.Drawing.Point(4, 51)
        Me.txtCodDpto.MaximoAncho = 0
        Me.txtCodDpto.MensajedeAyuda = Nothing
        Me.txtCodDpto.Name = "txtCodDpto"
        Me.txtCodDpto.Size = New System.Drawing.Size(237, 30)
        Me.txtCodDpto.SoloLectura = False
        Me.txtCodDpto.SoloNumeros = False
        Me.txtCodDpto.TabIndex = 2
        Me.txtCodDpto.TextodelControl = ""
        Me.txtCodDpto.TextoLabel = "Código Dpto :"
        Me.txtCodDpto.TieneErrorControl = False
        Me.txtCodDpto.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtCodDpto.TipodeLetra = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtCodDpto.ValordelControl = Nothing
        Me.txtCodDpto.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCodDpto.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCodDpto.ValorPredeterminado = Nothing
        '
        'SeparatorControl1
        '
        Me.SeparatorControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SeparatorControl1.Location = New System.Drawing.Point(4, 87)
        Me.SeparatorControl1.Name = "SeparatorControl1"
        Me.SeparatorControl1.Padding = New System.Windows.Forms.Padding(0)
        Me.SeparatorControl1.Size = New System.Drawing.Size(571, 3)
        Me.SeparatorControl1.TabIndex = 72
        Me.SeparatorControl1.TabStop = False
        '
        'gcDpto
        '
        Me.gcDpto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcDpto.Location = New System.Drawing.Point(2, 96)
        Me.gcDpto.MainView = Me.gvDpto
        Me.gcDpto.Name = "gcDpto"
        Me.gcDpto.Size = New System.Drawing.Size(578, 455)
        Me.gcDpto.TabIndex = 0
        Me.gcDpto.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvDpto})
        '
        'gvDpto
        '
        Me.gvDpto.GridControl = Me.gcDpto
        Me.gvDpto.Name = "gvDpto"
        '
        'FrmDepartamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 573)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.gbxPrincipal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmDepartamento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Departamentos"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.gbxPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxPrincipal.ResumeLayout(False)
        Me.gbxPrincipal.PerformLayout()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcDpto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvDpto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnLimpiar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gbxPrincipal As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtNombre As SamitCtlNet.SamitTexto
    Friend WithEvents txtCodDpto As SamitCtlNet.SamitTexto
    Friend WithEvents SeparatorControl1 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents gcDpto As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvDpto As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtPais As SamitCtlNet.SamitBusq
End Class
