<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAggTituloProfesion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAggTituloProfesion))
        Me.gbxPrincipal = New DevExpress.XtraEditors.GroupControl()
        Me.txtBusqueda = New DevExpress.XtraEditors.TextEdit()
        Me.SeparatorControl1 = New DevExpress.XtraEditors.SeparatorControl()
        Me.lblVigente = New DevExpress.XtraEditors.LabelControl()
        Me.rgVigente = New DevExpress.XtraEditors.RadioGroup()
        Me.lblNivelEducativo = New DevExpress.XtraEditors.LabelControl()
        Me.lkeNivelEducativo = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtProfesion = New SamitCtlNet.SamitTexto()
        Me.gcProfesiones = New DevExpress.XtraGrid.GridControl()
        Me.gvProfesiones = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btnLimpiar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEliminar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.btnCargarPlano = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.gbxPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxPrincipal.SuspendLayout()
        CType(Me.txtBusqueda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgVigente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkeNivelEducativo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcProfesiones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvProfesiones, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.gbxPrincipal.Controls.Add(Me.txtBusqueda)
        Me.gbxPrincipal.Controls.Add(Me.SeparatorControl1)
        Me.gbxPrincipal.Controls.Add(Me.lblVigente)
        Me.gbxPrincipal.Controls.Add(Me.rgVigente)
        Me.gbxPrincipal.Controls.Add(Me.lblNivelEducativo)
        Me.gbxPrincipal.Controls.Add(Me.lkeNivelEducativo)
        Me.gbxPrincipal.Controls.Add(Me.txtProfesion)
        Me.gbxPrincipal.Controls.Add(Me.gcProfesiones)
        Me.gbxPrincipal.Location = New System.Drawing.Point(8, 10)
        Me.gbxPrincipal.Name = "gbxPrincipal"
        Me.gbxPrincipal.Size = New System.Drawing.Size(581, 553)
        Me.gbxPrincipal.TabIndex = 1
        Me.gbxPrincipal.TabStop = True
        Me.gbxPrincipal.Text = "Agrega Profesión"
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBusqueda.Location = New System.Drawing.Point(2, 92)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.txtBusqueda.Properties.Appearance.Options.UseFont = True
        Me.txtBusqueda.Size = New System.Drawing.Size(576, 24)
        Me.txtBusqueda.TabIndex = 90
        '
        'SeparatorControl1
        '
        Me.SeparatorControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SeparatorControl1.Location = New System.Drawing.Point(4, 83)
        Me.SeparatorControl1.Name = "SeparatorControl1"
        Me.SeparatorControl1.Padding = New System.Windows.Forms.Padding(0)
        Me.SeparatorControl1.Size = New System.Drawing.Size(571, 3)
        Me.SeparatorControl1.TabIndex = 81
        Me.SeparatorControl1.TabStop = False
        '
        'lblVigente
        '
        Me.lblVigente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblVigente.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lblVigente.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblVigente.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblVigente.Location = New System.Drawing.Point(395, 51)
        Me.lblVigente.Name = "lblVigente"
        Me.lblVigente.Padding = New System.Windows.Forms.Padding(2)
        Me.lblVigente.Size = New System.Drawing.Size(85, 26)
        Me.lblVigente.TabIndex = 73
        Me.lblVigente.Text = "Vigente :"
        '
        'rgVigente
        '
        Me.rgVigente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rgVigente.Location = New System.Drawing.Point(487, 54)
        Me.rgVigente.Name = "rgVigente"
        Me.rgVigente.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.rgVigente.Properties.Appearance.Options.UseBackColor = True
        Me.rgVigente.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.rgVigente.Properties.Columns = 2
        Me.rgVigente.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.rgVigente.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "NO"), New DevExpress.XtraEditors.Controls.RadioGroupItem(True, "SI")})
        Me.rgVigente.Size = New System.Drawing.Size(82, 23)
        Me.rgVigente.TabIndex = 3
        '
        'lblNivelEducativo
        '
        Me.lblNivelEducativo.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lblNivelEducativo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblNivelEducativo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblNivelEducativo.Location = New System.Drawing.Point(5, 25)
        Me.lblNivelEducativo.Name = "lblNivelEducativo"
        Me.lblNivelEducativo.Padding = New System.Windows.Forms.Padding(2)
        Me.lblNivelEducativo.Size = New System.Drawing.Size(108, 26)
        Me.lblNivelEducativo.TabIndex = 37
        Me.lblNivelEducativo.Text = "Nivel Educativo :"
        '
        'lkeNivelEducativo
        '
        Me.lkeNivelEducativo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lkeNivelEducativo.Location = New System.Drawing.Point(118, 29)
        Me.lkeNivelEducativo.Name = "lkeNivelEducativo"
        Me.lkeNivelEducativo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeNivelEducativo.Properties.Appearance.Options.UseFont = True
        Me.lkeNivelEducativo.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeNivelEducativo.Properties.AppearanceDisabled.Options.UseFont = True
        Me.lkeNivelEducativo.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeNivelEducativo.Properties.AppearanceDropDown.Options.UseFont = True
        Me.lkeNivelEducativo.Properties.AppearanceDropDownHeader.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeNivelEducativo.Properties.AppearanceDropDownHeader.Options.UseFont = True
        Me.lkeNivelEducativo.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeNivelEducativo.Properties.AppearanceFocused.Options.UseFont = True
        Me.lkeNivelEducativo.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeNivelEducativo.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.lkeNivelEducativo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkeNivelEducativo.Properties.CloseUpKey = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.Right)
        Me.lkeNivelEducativo.Properties.NullText = "Seleccione..."
        Me.lkeNivelEducativo.Properties.ShowFooter = False
        Me.lkeNivelEducativo.Properties.ShowHeader = False
        Me.lkeNivelEducativo.Size = New System.Drawing.Size(451, 20)
        Me.lkeNivelEducativo.TabIndex = 1
        '
        'txtProfesion
        '
        Me.txtProfesion.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtProfesion.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtProfesion.AltodelControl = 30
        Me.txtProfesion.AnchoLabel = 110
        Me.txtProfesion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtProfesion.AutoSize = True
        Me.txtProfesion.BackColor = System.Drawing.Color.Transparent
        Me.txtProfesion.ColordeFondo = System.Drawing.Color.Transparent
        Me.txtProfesion.EsObligatorio = False
        Me.txtProfesion.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProfesion.FormatoNumero = Nothing
        Me.txtProfesion.Location = New System.Drawing.Point(5, 52)
        Me.txtProfesion.MaximoAncho = 0
        Me.txtProfesion.MensajedeAyuda = Nothing
        Me.txtProfesion.Name = "txtProfesion"
        Me.txtProfesion.Size = New System.Drawing.Size(375, 30)
        Me.txtProfesion.SoloLectura = False
        Me.txtProfesion.SoloNumeros = False
        Me.txtProfesion.TabIndex = 2
        Me.txtProfesion.TextodelControl = ""
        Me.txtProfesion.TextoLabel = "Profesión  :"
        Me.txtProfesion.TieneErrorControl = False
        Me.txtProfesion.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtProfesion.TipodeLetra = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtProfesion.ValordelControl = Nothing
        Me.txtProfesion.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtProfesion.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtProfesion.ValorPredeterminado = Nothing
        '
        'gcProfesiones
        '
        Me.gcProfesiones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcProfesiones.Location = New System.Drawing.Point(2, 122)
        Me.gcProfesiones.MainView = Me.gvProfesiones
        Me.gcProfesiones.Name = "gcProfesiones"
        Me.gcProfesiones.Size = New System.Drawing.Size(577, 429)
        Me.gcProfesiones.TabIndex = 10
        Me.gcProfesiones.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvProfesiones})
        '
        'gvProfesiones
        '
        Me.gvProfesiones.GridControl = Me.gcProfesiones
        Me.gvProfesiones.Name = "gvProfesiones"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnLimpiar.Appearance.Options.UseFont = True
        Me.btnLimpiar.Location = New System.Drawing.Point(5, 60)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(74, 30)
        Me.btnLimpiar.TabIndex = 5
        Me.btnLimpiar.Text = "Limpiar"
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Location = New System.Drawing.Point(5, 24)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(74, 30)
        Me.btnGuardar.TabIndex = 4
        Me.btnGuardar.Text = "Guardar"
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(5, 96)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(74, 30)
        Me.btnEliminar.TabIndex = 6
        Me.btnEliminar.Text = "Eliminar"
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(5, 177)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(74, 30)
        Me.btnSalir.TabIndex = 7
        Me.btnSalir.Text = "Salir"
        '
        'GroupControl2
        '
        Me.GroupControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.GroupControl2.CaptionImagePadding = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.GroupControl2.Controls.Add(Me.btnCargarPlano)
        Me.GroupControl2.Controls.Add(Me.btnSalir)
        Me.GroupControl2.Controls.Add(Me.btnGuardar)
        Me.GroupControl2.Controls.Add(Me.btnLimpiar)
        Me.GroupControl2.Controls.Add(Me.btnEliminar)
        Me.GroupControl2.Location = New System.Drawing.Point(595, 10)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(88, 553)
        Me.GroupControl2.TabIndex = 13
        Me.GroupControl2.TabStop = True
        Me.GroupControl2.Text = "Opciones"
        '
        'btnCargarPlano
        '
        Me.btnCargarPlano.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnCargarPlano.Appearance.Options.UseFont = True
        Me.btnCargarPlano.Location = New System.Drawing.Point(5, 132)
        Me.btnCargarPlano.Name = "btnCargarPlano"
        Me.btnCargarPlano.Size = New System.Drawing.Size(74, 39)
        Me.btnCargarPlano.TabIndex = 8
        Me.btnCargarPlano.Text = "Cargar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Plano"
        '
        'FrmAggTituloProfesion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 573)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.gbxPrincipal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "FrmAggTituloProfesion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Titulos Profesionales"
        CType(Me.gbxPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxPrincipal.ResumeLayout(False)
        Me.gbxPrincipal.PerformLayout()
        CType(Me.txtBusqueda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgVigente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkeNivelEducativo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcProfesiones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvProfesiones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbxPrincipal As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gcProfesiones As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvProfesiones As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtProfesion As SamitCtlNet.SamitTexto
    Friend WithEvents lblNivelEducativo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkeNivelEducativo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblVigente As DevExpress.XtraEditors.LabelControl
    Friend WithEvents rgVigente As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents btnLimpiar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SeparatorControl1 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents txtBusqueda As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnCargarPlano As DevExpress.XtraEditors.SimpleButton
End Class
