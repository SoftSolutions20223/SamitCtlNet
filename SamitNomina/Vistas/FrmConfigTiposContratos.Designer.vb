<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConfigTiposContratos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConfigTiposContratos))
        Me.gbxPrincipal = New DevExpress.XtraEditors.GroupControl()
        Me.txtTipoContrato = New SamitCtlNet.SamitBusq()
        Me.gcVariables = New DevExpress.XtraGrid.GridControl()
        Me.gvVariables = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcConfigTiposContratos = New DevExpress.XtraGrid.GridControl()
        Me.gvConfigTiposContratos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.btnLimpiar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.gbxPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxPrincipal.SuspendLayout()
        CType(Me.gcVariables, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvVariables, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcConfigTiposContratos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvConfigTiposContratos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
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
        Me.gbxPrincipal.Controls.Add(Me.txtTipoContrato)
        Me.gbxPrincipal.Controls.Add(Me.gcVariables)
        Me.gbxPrincipal.Controls.Add(Me.gcConfigTiposContratos)
        Me.gbxPrincipal.Location = New System.Drawing.Point(8, 5)
        Me.gbxPrincipal.Name = "gbxPrincipal"
        Me.gbxPrincipal.Size = New System.Drawing.Size(882, 592)
        Me.gbxPrincipal.TabIndex = 1
        '
        'txtTipoContrato
        '
        Me.txtTipoContrato.AlineacionTexto = SamitCtlNet.AlinearTexto.Centro
        Me.txtTipoContrato.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtTipoContrato.AltodelControl = 30
        Me.txtTipoContrato.AnchoLabel = 120
        Me.txtTipoContrato.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTipoContrato.AnchoTxt = 80
        Me.txtTipoContrato.AutoCargarDatos = True
        Me.txtTipoContrato.AutoSize = True
        Me.txtTipoContrato.BackColor = System.Drawing.Color.Transparent
        Me.txtTipoContrato.ColorFondo = System.Drawing.Color.Transparent
        Me.txtTipoContrato.CondicionValida = ""
        Me.txtTipoContrato.Conexion = SamitCtlNet.ConexionSAMIT.ConexModulo
        Me.txtTipoContrato.ConsultaSQL = Nothing
        Me.txtTipoContrato.EsObligatorio = False
        Me.txtTipoContrato.FormatoNumero = Nothing
        Me.txtTipoContrato.Location = New System.Drawing.Point(3, 26)
        Me.txtTipoContrato.MaximoAncho = 0
        Me.txtTipoContrato.MensajedeAyuda = Nothing
        Me.txtTipoContrato.Name = "txtTipoContrato"
        Me.txtTipoContrato.Size = New System.Drawing.Size(874, 30)
        Me.txtTipoContrato.SoloLectura = False
        Me.txtTipoContrato.SoloNumeros = True
        Me.txtTipoContrato.TabIndex = 1
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
        'gcVariables
        '
        Me.gcVariables.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcVariables.Location = New System.Drawing.Point(5, 131)
        Me.gcVariables.MainView = Me.gvVariables
        Me.gcVariables.Name = "gcVariables"
        Me.gcVariables.Size = New System.Drawing.Size(873, 306)
        Me.gcVariables.TabIndex = 2
        Me.gcVariables.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvVariables})
        Me.gcVariables.Visible = False
        '
        'gvVariables
        '
        Me.gvVariables.GridControl = Me.gcVariables
        Me.gvVariables.Name = "gvVariables"
        '
        'gcConfigTiposContratos
        '
        Me.gcConfigTiposContratos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcConfigTiposContratos.Location = New System.Drawing.Point(0, 62)
        Me.gcConfigTiposContratos.MainView = Me.gvConfigTiposContratos
        Me.gcConfigTiposContratos.Name = "gcConfigTiposContratos"
        Me.gcConfigTiposContratos.Size = New System.Drawing.Size(882, 529)
        Me.gcConfigTiposContratos.TabIndex = 1
        Me.gcConfigTiposContratos.TabStop = False
        Me.gcConfigTiposContratos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvConfigTiposContratos})
        '
        'gvConfigTiposContratos
        '
        Me.gvConfigTiposContratos.GridControl = Me.gcConfigTiposContratos
        Me.gvConfigTiposContratos.Name = "gvConfigTiposContratos"
        '
        'GroupControl2
        '
        Me.GroupControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.GroupControl2.CaptionImagePadding = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.GroupControl2.Controls.Add(Me.btnLimpiar)
        Me.GroupControl2.Controls.Add(Me.btnSalir)
        Me.GroupControl2.Controls.Add(Me.btnGuardar)
        Me.GroupControl2.Location = New System.Drawing.Point(897, 6)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(88, 592)
        Me.GroupControl2.TabIndex = 2
        Me.GroupControl2.Text = "Opciones"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLimpiar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnLimpiar.Appearance.Options.UseFont = True
        Me.btnLimpiar.Location = New System.Drawing.Point(7, 72)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(74, 30)
        Me.btnLimpiar.TabIndex = 2
        Me.btnLimpiar.Text = "Limpiar"
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(7, 110)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(74, 30)
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.Text = "Salir"
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Location = New System.Drawing.Point(7, 27)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(74, 38)
        Me.btnGuardar.TabIndex = 1
        Me.btnGuardar.Text = "Guardar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'FrmConfigTiposContratos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(990, 602)
        Me.Controls.Add(Me.gbxPrincipal)
        Me.Controls.Add(Me.GroupControl2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmConfigTiposContratos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Config Tipos Contratos"
        CType(Me.gbxPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxPrincipal.ResumeLayout(False)
        Me.gbxPrincipal.PerformLayout()
        CType(Me.gcVariables, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvVariables, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcConfigTiposContratos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvConfigTiposContratos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbxPrincipal As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gcVariables As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvVariables As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gcConfigTiposContratos As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvConfigTiposContratos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnLimpiar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtTipoContrato As SamitCtlNet.SamitBusq
End Class
