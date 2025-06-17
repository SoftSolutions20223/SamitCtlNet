<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAggVariablesPersonales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAggVariablesPersonales))
        Me.gbxPrincipal = New DevExpress.XtraEditors.GroupControl()
        Me.TxtValDefecto = New SamitCtlNet.SamitTexto()
        Me.txtValorMaximo = New SamitCtlNet.SamitTexto()
        Me.SeparatorControl1 = New DevExpress.XtraEditors.SeparatorControl()
        Me.lblVigente = New DevExpress.XtraEditors.LabelControl()
        Me.grbVigente = New DevExpress.XtraEditors.RadioGroup()
        Me.txtBusqueda = New DevExpress.XtraEditors.TextEdit()
        Me.txtNombreVariable = New SamitCtlNet.SamitTexto()
        Me.gcVariablesP = New DevExpress.XtraGrid.GridControl()
        Me.gvVariablesP = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btnLimpiar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEliminar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.txtCodDian = New SamitCtlNet.SamitBusq()
        CType(Me.gbxPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxPrincipal.SuspendLayout()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grbVigente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBusqueda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcVariablesP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvVariablesP, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.gbxPrincipal.CaptionImageOptions.Padding = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.gbxPrincipal.Controls.Add(Me.txtCodDian)
        Me.gbxPrincipal.Controls.Add(Me.TxtValDefecto)
        Me.gbxPrincipal.Controls.Add(Me.txtValorMaximo)
        Me.gbxPrincipal.Controls.Add(Me.SeparatorControl1)
        Me.gbxPrincipal.Controls.Add(Me.lblVigente)
        Me.gbxPrincipal.Controls.Add(Me.grbVigente)
        Me.gbxPrincipal.Controls.Add(Me.txtBusqueda)
        Me.gbxPrincipal.Controls.Add(Me.txtNombreVariable)
        Me.gbxPrincipal.Controls.Add(Me.gcVariablesP)
        Me.gbxPrincipal.Location = New System.Drawing.Point(8, 10)
        Me.gbxPrincipal.Name = "gbxPrincipal"
        Me.gbxPrincipal.Size = New System.Drawing.Size(815, 566)
        Me.gbxPrincipal.TabIndex = 0
        Me.gbxPrincipal.TabStop = True
        Me.gbxPrincipal.Text = "Datos Valores Personales"
        '
        'TxtValDefecto
        '
        Me.TxtValDefecto.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.TxtValDefecto.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.TxtValDefecto.AltodelControl = 30
        Me.TxtValDefecto.AnchoLabel = 120
        Me.TxtValDefecto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtValDefecto.AutoSize = True
        Me.TxtValDefecto.BackColor = System.Drawing.Color.Transparent
        Me.TxtValDefecto.ColordeFondo = System.Drawing.Color.Transparent
        Me.TxtValDefecto.EsObligatorio = False
        Me.TxtValDefecto.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtValDefecto.FormatoNumero = Nothing
        Me.TxtValDefecto.Location = New System.Drawing.Point(7, 87)
        Me.TxtValDefecto.MaximoAncho = 0
        Me.TxtValDefecto.MensajedeAyuda = Nothing
        Me.TxtValDefecto.Name = "TxtValDefecto"
        Me.TxtValDefecto.Size = New System.Drawing.Size(803, 30)
        Me.TxtValDefecto.SoloLectura = False
        Me.TxtValDefecto.SoloNumeros = False
        Me.TxtValDefecto.TabIndex = 3
        Me.TxtValDefecto.TextodelControl = ""
        Me.TxtValDefecto.TextoLabel = "Valor por Defecto  :"
        Me.TxtValDefecto.TieneErrorControl = False
        Me.TxtValDefecto.TipodeDatos = SamitCtlNet.TipodeDato.NumerosCon_2_Decimales
        Me.TxtValDefecto.TipodeLetra = New System.Drawing.Font("Tahoma", 9.0!)
        Me.TxtValDefecto.ValordelControl = Nothing
        Me.TxtValDefecto.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.TxtValDefecto.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.TxtValDefecto.ValorPredeterminado = Nothing
        '
        'txtValorMaximo
        '
        Me.txtValorMaximo.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtValorMaximo.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtValorMaximo.AltodelControl = 30
        Me.txtValorMaximo.AnchoLabel = 120
        Me.txtValorMaximo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtValorMaximo.AutoSize = True
        Me.txtValorMaximo.BackColor = System.Drawing.Color.Transparent
        Me.txtValorMaximo.ColordeFondo = System.Drawing.Color.Transparent
        Me.txtValorMaximo.EsObligatorio = False
        Me.txtValorMaximo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorMaximo.FormatoNumero = Nothing
        Me.txtValorMaximo.Location = New System.Drawing.Point(7, 56)
        Me.txtValorMaximo.MaximoAncho = 0
        Me.txtValorMaximo.MensajedeAyuda = Nothing
        Me.txtValorMaximo.Name = "txtValorMaximo"
        Me.txtValorMaximo.Size = New System.Drawing.Size(803, 30)
        Me.txtValorMaximo.SoloLectura = False
        Me.txtValorMaximo.SoloNumeros = False
        Me.txtValorMaximo.TabIndex = 2
        Me.txtValorMaximo.TextodelControl = ""
        Me.txtValorMaximo.TextoLabel = "Valor Maximo  :"
        Me.txtValorMaximo.TieneErrorControl = False
        Me.txtValorMaximo.TipodeDatos = SamitCtlNet.TipodeDato.NumerosCon_2_Decimales
        Me.txtValorMaximo.TipodeLetra = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtValorMaximo.ValordelControl = Nothing
        Me.txtValorMaximo.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtValorMaximo.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtValorMaximo.ValorPredeterminado = Nothing
        '
        'SeparatorControl1
        '
        Me.SeparatorControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SeparatorControl1.Location = New System.Drawing.Point(5, 173)
        Me.SeparatorControl1.Name = "SeparatorControl1"
        Me.SeparatorControl1.Padding = New System.Windows.Forms.Padding(0)
        Me.SeparatorControl1.Size = New System.Drawing.Size(805, 3)
        Me.SeparatorControl1.TabIndex = 99
        '
        'lblVigente
        '
        Me.lblVigente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblVigente.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lblVigente.Appearance.Options.UseFont = True
        Me.lblVigente.Appearance.Options.UseTextOptions = True
        Me.lblVigente.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblVigente.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblVigente.Location = New System.Drawing.Point(630, 147)
        Me.lblVigente.Name = "lblVigente"
        Me.lblVigente.Padding = New System.Windows.Forms.Padding(2)
        Me.lblVigente.Size = New System.Drawing.Size(83, 26)
        Me.lblVigente.TabIndex = 98
        Me.lblVigente.Text = "Vigente :"
        '
        'grbVigente
        '
        Me.grbVigente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grbVigente.Location = New System.Drawing.Point(719, 151)
        Me.grbVigente.Name = "grbVigente"
        Me.grbVigente.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.grbVigente.Properties.Appearance.Options.UseBackColor = True
        Me.grbVigente.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.grbVigente.Properties.Columns = 2
        Me.grbVigente.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.grbVigente.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "NO"), New DevExpress.XtraEditors.Controls.RadioGroupItem(True, "SI")})
        Me.grbVigente.Size = New System.Drawing.Size(91, 20)
        Me.grbVigente.TabIndex = 5
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBusqueda.Location = New System.Drawing.Point(2, 180)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.txtBusqueda.Properties.Appearance.Options.UseFont = True
        Me.txtBusqueda.Size = New System.Drawing.Size(810, 24)
        Me.txtBusqueda.TabIndex = 91
        Me.txtBusqueda.TabStop = False
        '
        'txtNombreVariable
        '
        Me.txtNombreVariable.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtNombreVariable.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtNombreVariable.AltodelControl = 30
        Me.txtNombreVariable.AnchoLabel = 120
        Me.txtNombreVariable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombreVariable.AutoSize = True
        Me.txtNombreVariable.BackColor = System.Drawing.Color.Transparent
        Me.txtNombreVariable.ColordeFondo = System.Drawing.Color.Transparent
        Me.txtNombreVariable.EsObligatorio = False
        Me.txtNombreVariable.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreVariable.FormatoNumero = Nothing
        Me.txtNombreVariable.Location = New System.Drawing.Point(6, 26)
        Me.txtNombreVariable.MaximoAncho = 0
        Me.txtNombreVariable.MensajedeAyuda = Nothing
        Me.txtNombreVariable.Name = "txtNombreVariable"
        Me.txtNombreVariable.Size = New System.Drawing.Size(804, 30)
        Me.txtNombreVariable.SoloLectura = False
        Me.txtNombreVariable.SoloNumeros = False
        Me.txtNombreVariable.TabIndex = 1
        Me.txtNombreVariable.TextodelControl = ""
        Me.txtNombreVariable.TextoLabel = "Nombre  :"
        Me.txtNombreVariable.TieneErrorControl = False
        Me.txtNombreVariable.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtNombreVariable.TipodeLetra = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtNombreVariable.ValordelControl = Nothing
        Me.txtNombreVariable.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombreVariable.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombreVariable.ValorPredeterminado = Nothing
        '
        'gcVariablesP
        '
        Me.gcVariablesP.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcVariablesP.Location = New System.Drawing.Point(0, 206)
        Me.gcVariablesP.MainView = Me.gvVariablesP
        Me.gcVariablesP.Name = "gcVariablesP"
        Me.gcVariablesP.Size = New System.Drawing.Size(815, 360)
        Me.gcVariablesP.TabIndex = 0
        Me.gcVariablesP.TabStop = False
        Me.gcVariablesP.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvVariablesP})
        '
        'gvVariablesP
        '
        Me.gvVariablesP.GridControl = Me.gcVariablesP
        Me.gvVariablesP.Name = "gvVariablesP"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnLimpiar.Appearance.Options.UseFont = True
        Me.btnLimpiar.Location = New System.Drawing.Point(7, 60)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(74, 30)
        Me.btnLimpiar.TabIndex = 4
        Me.btnLimpiar.Text = "Limpiar"
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Location = New System.Drawing.Point(7, 24)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(74, 30)
        Me.btnGuardar.TabIndex = 3
        Me.btnGuardar.Text = "Guardar"
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(7, 96)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(74, 30)
        Me.btnEliminar.TabIndex = 5
        Me.btnEliminar.Text = "Eliminar"
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(7, 132)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(74, 30)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "Salir"
        '
        'GroupControl2
        '
        Me.GroupControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.GroupControl2.CaptionImageOptions.Padding = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.GroupControl2.Controls.Add(Me.btnSalir)
        Me.GroupControl2.Controls.Add(Me.btnEliminar)
        Me.GroupControl2.Controls.Add(Me.btnLimpiar)
        Me.GroupControl2.Controls.Add(Me.btnGuardar)
        Me.GroupControl2.Location = New System.Drawing.Point(829, 10)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(88, 566)
        Me.GroupControl2.TabIndex = 14
        Me.GroupControl2.TabStop = True
        Me.GroupControl2.Text = "Opciones"
        '
        'txtCodDian
        '
        Me.txtCodDian.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtCodDian.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtCodDian.AltodelControl = 30
        Me.txtCodDian.AnchoLabel = 120
        Me.txtCodDian.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCodDian.AnchoTxt = 80
        Me.txtCodDian.AutoCargarDatos = True
        Me.txtCodDian.AutoSize = True
        Me.txtCodDian.BackColor = System.Drawing.Color.Transparent
        Me.txtCodDian.ColorFondo = System.Drawing.Color.Transparent
        Me.txtCodDian.CondicionValida = ""
        Me.txtCodDian.Conexion = SamitCtlNet.ConexionSAMIT.ConexModulo
        Me.txtCodDian.ConsultaSQL = Nothing
        Me.txtCodDian.EsObligatorio = False
        Me.txtCodDian.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtCodDian.FormatoNumero = Nothing
        Me.txtCodDian.Location = New System.Drawing.Point(7, 117)
        Me.txtCodDian.MaximoAncho = 0
        Me.txtCodDian.MensajedeAyuda = ""
        Me.txtCodDian.Name = "txtCodDian"
        Me.txtCodDian.Size = New System.Drawing.Size(803, 30)
        Me.txtCodDian.SoloLectura = False
        Me.txtCodDian.SoloNumeros = True
        Me.txtCodDian.TabIndex = 4
        Me.txtCodDian.TextodelControl = ""
        Me.txtCodDian.TextoLabel = "Codigo Dian :"
        Me.txtCodDian.TieneErrorControl = False
        Me.txtCodDian.TipoBusqueda = SamitCtlNet.ModGeneral.TipoBusqueda.Ninguna
        Me.txtCodDian.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtCodDian.TipodeLetra = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtCodDian.ValordelControl = ""
        Me.txtCodDian.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCodDian.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCodDian.ValorPredeterminado = Nothing
        '
        'FrmAggVariablesPersonales
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(928, 591)
        Me.Controls.Add(Me.gbxPrincipal)
        Me.Controls.Add(Me.GroupControl2)
        Me.IconOptions.Icon = CType(resources.GetObject("FrmAggVariablesPersonales.IconOptions.Icon"), System.Drawing.Icon)
        Me.Name = "FrmAggVariablesPersonales"
        Me.Text = "Valores Personales"
        CType(Me.gbxPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxPrincipal.ResumeLayout(False)
        Me.gbxPrincipal.PerformLayout()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grbVigente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBusqueda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcVariablesP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvVariablesP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbxPrincipal As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblVigente As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grbVigente As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents txtBusqueda As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnLimpiar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtNombreVariable As SamitCtlNet.SamitTexto
    Friend WithEvents gcVariablesP As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvVariablesP As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SeparatorControl1 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents txtValorMaximo As SamitCtlNet.SamitTexto
    Friend WithEvents TxtValDefecto As SamitCtlNet.SamitTexto
    Friend WithEvents txtCodDian As SamitCtlNet.SamitBusq
End Class
