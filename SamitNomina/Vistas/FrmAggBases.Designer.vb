<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAggBases
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAggBases))
        Me.gbxPrincipal = New DevExpress.XtraEditors.GroupControl()
        Me.btnAbrirFormula = New DevExpress.XtraEditors.SimpleButton()
        Me.lblVigente = New DevExpress.XtraEditors.LabelControl()
        Me.grbVigente = New DevExpress.XtraEditors.RadioGroup()
        Me.SeparatorControl6 = New DevExpress.XtraEditors.SeparatorControl()
        Me.gcBases = New DevExpress.XtraGrid.GridControl()
        Me.gvBases = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcVariables = New DevExpress.XtraGrid.GridControl()
        Me.gvVariables = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtFormula = New SamitCtlNet.SamitTexto()
        Me.txtBusqueda = New DevExpress.XtraEditors.TextEdit()
        Me.txtNombreBase = New SamitCtlNet.SamitTexto()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEliminar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnLimpiar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.gbxPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxPrincipal.SuspendLayout()
        CType(Me.grbVigente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeparatorControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcBases, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvBases, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcVariables, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvVariables, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBusqueda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.gbxPrincipal.Controls.Add(Me.btnAbrirFormula)
        Me.gbxPrincipal.Controls.Add(Me.lblVigente)
        Me.gbxPrincipal.Controls.Add(Me.grbVigente)
        Me.gbxPrincipal.Controls.Add(Me.SeparatorControl6)
        Me.gbxPrincipal.Controls.Add(Me.gcBases)
        Me.gbxPrincipal.Controls.Add(Me.gcVariables)
        Me.gbxPrincipal.Controls.Add(Me.txtFormula)
        Me.gbxPrincipal.Controls.Add(Me.txtBusqueda)
        Me.gbxPrincipal.Controls.Add(Me.txtNombreBase)
        Me.gbxPrincipal.Location = New System.Drawing.Point(6, 9)
        Me.gbxPrincipal.Name = "gbxPrincipal"
        Me.gbxPrincipal.Size = New System.Drawing.Size(597, 571)
        Me.gbxPrincipal.TabIndex = 1
        Me.gbxPrincipal.TabStop = True
        Me.gbxPrincipal.Text = "Agrega Bases"
        '
        'btnAbrirFormula
        '
        Me.btnAbrirFormula.AllowFocus = False
        Me.btnAbrirFormula.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAbrirFormula.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnAbrirFormula.Appearance.Options.UseFont = True
        Me.btnAbrirFormula.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnAbrirFormula.Location = New System.Drawing.Point(362, 52)
        Me.btnAbrirFormula.Name = "btnAbrirFormula"
        Me.btnAbrirFormula.Size = New System.Drawing.Size(34, 25)
        Me.btnAbrirFormula.TabIndex = 85
        Me.btnAbrirFormula.TabStop = False
        '
        'lblVigente
        '
        Me.lblVigente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblVigente.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lblVigente.Appearance.Options.UseFont = True
        Me.lblVigente.Appearance.Options.UseTextOptions = True
        Me.lblVigente.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblVigente.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblVigente.Location = New System.Drawing.Point(402, 52)
        Me.lblVigente.Name = "lblVigente"
        Me.lblVigente.Padding = New System.Windows.Forms.Padding(2)
        Me.lblVigente.Size = New System.Drawing.Size(91, 25)
        Me.lblVigente.TabIndex = 98
        Me.lblVigente.Text = "Vigente :"
        '
        'grbVigente
        '
        Me.grbVigente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grbVigente.EditValue = True
        Me.grbVigente.Location = New System.Drawing.Point(499, 55)
        Me.grbVigente.Name = "grbVigente"
        Me.grbVigente.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.grbVigente.Properties.Appearance.Options.UseBackColor = True
        Me.grbVigente.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.grbVigente.Properties.Columns = 2
        Me.grbVigente.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.grbVigente.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "NO"), New DevExpress.XtraEditors.Controls.RadioGroupItem(True, "SI")})
        Me.grbVigente.Size = New System.Drawing.Size(91, 23)
        Me.grbVigente.TabIndex = 97
        '
        'SeparatorControl6
        '
        Me.SeparatorControl6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SeparatorControl6.Location = New System.Drawing.Point(8, 84)
        Me.SeparatorControl6.Name = "SeparatorControl6"
        Me.SeparatorControl6.Padding = New System.Windows.Forms.Padding(0)
        Me.SeparatorControl6.Size = New System.Drawing.Size(584, 3)
        Me.SeparatorControl6.TabIndex = 96
        Me.SeparatorControl6.TabStop = False
        '
        'gcBases
        '
        Me.gcBases.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcBases.Location = New System.Drawing.Point(5, 120)
        Me.gcBases.MainView = Me.gvBases
        Me.gcBases.Name = "gcBases"
        Me.gcBases.Size = New System.Drawing.Size(588, 450)
        Me.gcBases.TabIndex = 93
        Me.gcBases.TabStop = False
        Me.gcBases.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvBases})
        '
        'gvBases
        '
        Me.gvBases.GridControl = Me.gcBases
        Me.gvBases.Name = "gvBases"
        '
        'gcVariables
        '
        Me.gcVariables.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcVariables.Location = New System.Drawing.Point(5, 120)
        Me.gcVariables.MainView = Me.gvVariables
        Me.gcVariables.Name = "gcVariables"
        Me.gcVariables.Size = New System.Drawing.Size(588, 450)
        Me.gcVariables.TabIndex = 0
        Me.gcVariables.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvVariables})
        Me.gcVariables.Visible = False
        '
        'gvVariables
        '
        Me.gvVariables.GridControl = Me.gcVariables
        Me.gvVariables.Name = "gvVariables"
        '
        'txtFormula
        '
        Me.txtFormula.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtFormula.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtFormula.AltodelControl = 30
        Me.txtFormula.AnchoLabel = 100
        Me.txtFormula.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFormula.AutoSize = True
        Me.txtFormula.BackColor = System.Drawing.Color.Transparent
        Me.txtFormula.ColordeFondo = System.Drawing.Color.Transparent
        Me.txtFormula.EsObligatorio = False
        Me.txtFormula.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFormula.FormatoNumero = Nothing
        Me.txtFormula.Location = New System.Drawing.Point(8, 52)
        Me.txtFormula.MaximoAncho = 0
        Me.txtFormula.MensajedeAyuda = ""
        Me.txtFormula.Name = "txtFormula"
        Me.txtFormula.Size = New System.Drawing.Size(348, 30)
        Me.txtFormula.SoloLectura = False
        Me.txtFormula.SoloNumeros = False
        Me.txtFormula.TabIndex = 2
        Me.txtFormula.TextodelControl = ""
        Me.txtFormula.TextoLabel = "Formula  :"
        Me.txtFormula.TieneErrorControl = False
        Me.txtFormula.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtFormula.TipodeLetra = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtFormula.ValordelControl = Nothing
        Me.txtFormula.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtFormula.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtFormula.ValorPredeterminado = Nothing
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBusqueda.Location = New System.Drawing.Point(5, 90)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.txtBusqueda.Properties.Appearance.Options.UseFont = True
        Me.txtBusqueda.Size = New System.Drawing.Size(587, 24)
        Me.txtBusqueda.TabIndex = 91
        Me.txtBusqueda.TabStop = False
        '
        'txtNombreBase
        '
        Me.txtNombreBase.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtNombreBase.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtNombreBase.AltodelControl = 30
        Me.txtNombreBase.AnchoLabel = 100
        Me.txtNombreBase.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombreBase.AutoSize = True
        Me.txtNombreBase.BackColor = System.Drawing.Color.Transparent
        Me.txtNombreBase.ColordeFondo = System.Drawing.Color.Transparent
        Me.txtNombreBase.EsObligatorio = False
        Me.txtNombreBase.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreBase.FormatoNumero = Nothing
        Me.txtNombreBase.Location = New System.Drawing.Point(8, 24)
        Me.txtNombreBase.MaximoAncho = 0
        Me.txtNombreBase.MensajedeAyuda = ""
        Me.txtNombreBase.Name = "txtNombreBase"
        Me.txtNombreBase.Size = New System.Drawing.Size(585, 30)
        Me.txtNombreBase.SoloLectura = False
        Me.txtNombreBase.SoloNumeros = False
        Me.txtNombreBase.TabIndex = 1
        Me.txtNombreBase.TextodelControl = ""
        Me.txtNombreBase.TextoLabel = "Nombre  :"
        Me.txtNombreBase.TieneErrorControl = False
        Me.txtNombreBase.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtNombreBase.TipodeLetra = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtNombreBase.ValordelControl = Nothing
        Me.txtNombreBase.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombreBase.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombreBase.ValorPredeterminado = Nothing
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
        Me.GroupControl1.Controls.Add(Me.btnEliminar)
        Me.GroupControl1.Controls.Add(Me.btnLimpiar)
        Me.GroupControl1.Controls.Add(Me.btnGuardar)
        Me.GroupControl1.Location = New System.Drawing.Point(609, 9)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(88, 570)
        Me.GroupControl1.TabIndex = 3
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
        'FrmAggBases
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(702, 586)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.gbxPrincipal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmAggBases"
        Me.Text = "Bases de Calculo"
        CType(Me.gbxPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxPrincipal.ResumeLayout(False)
        Me.gbxPrincipal.PerformLayout()
        CType(Me.grbVigente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeparatorControl6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcBases, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvBases, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcVariables, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvVariables, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBusqueda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbxPrincipal As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gcBases As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvBases As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gcVariables As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvVariables As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtFormula As SamitCtlNet.SamitTexto
    Friend WithEvents txtBusqueda As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNombreBase As SamitCtlNet.SamitTexto
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnLimpiar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SeparatorControl6 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents lblVigente As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grbVigente As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents btnAbrirFormula As DevExpress.XtraEditors.SimpleButton
End Class
