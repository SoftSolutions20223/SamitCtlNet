<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPlantaCargos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPlantaCargos))
        Me.txtOficina = New SamitCtlNet.SamitBusq()
        Me.txtCargos = New SamitCtlNet.SamitBusq()
        Me.gcPlantaCargos = New DevExpress.XtraGrid.GridControl()
        Me.gvPlantaCargos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ndCantidad = New DevExpress.XtraEditors.SpinEdit()
        Me.lblCantidad = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.btnLimpiar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEliminar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.gcPlantaCargos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvPlantaCargos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ndCantidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtOficina
        '
        Me.txtOficina.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtOficina.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtOficina.AltodelControl = 30
        Me.txtOficina.AnchoLabel = 90
        Me.txtOficina.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOficina.AnchoTxt = 60
        Me.txtOficina.AutoCargarDatos = True
        Me.txtOficina.AutoSize = True
        Me.txtOficina.BackColor = System.Drawing.Color.Transparent
        Me.txtOficina.ColorFondo = System.Drawing.Color.Transparent
        Me.txtOficina.CondicionValida = ""
        Me.txtOficina.Conexion = SamitCtlNet.ConexionSAMIT.ConexModulo
        Me.txtOficina.ConsultaSQL = Nothing
        Me.txtOficina.EsObligatorio = False
        Me.txtOficina.FormatoNumero = Nothing
        Me.txtOficina.Location = New System.Drawing.Point(12, 12)
        Me.txtOficina.MaximoAncho = 0
        Me.txtOficina.MensajedeAyuda = Nothing
        Me.txtOficina.Name = "txtOficina"
        Me.txtOficina.Size = New System.Drawing.Size(773, 30)
        Me.txtOficina.SoloLectura = False
        Me.txtOficina.SoloNumeros = True
        Me.txtOficina.TabIndex = 2
        Me.txtOficina.TextodelControl = ""
        Me.txtOficina.TextoLabel = "Oficina :"
        Me.txtOficina.TieneErrorControl = False
        Me.txtOficina.TipoBusqueda = SamitCtlNet.ModGeneral.TipoBusqueda.Ninguna
        Me.txtOficina.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtOficina.TipodeLetra = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOficina.ValordelControl = ""
        Me.txtOficina.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtOficina.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtOficina.ValorPredeterminado = Nothing
        '
        'txtCargos
        '
        Me.txtCargos.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtCargos.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtCargos.AltodelControl = 30
        Me.txtCargos.AnchoLabel = 90
        Me.txtCargos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCargos.AnchoTxt = 60
        Me.txtCargos.AutoCargarDatos = True
        Me.txtCargos.AutoSize = True
        Me.txtCargos.BackColor = System.Drawing.Color.Transparent
        Me.txtCargos.ColorFondo = System.Drawing.Color.Transparent
        Me.txtCargos.CondicionValida = ""
        Me.txtCargos.Conexion = SamitCtlNet.ConexionSAMIT.ConexModulo
        Me.txtCargos.ConsultaSQL = Nothing
        Me.txtCargos.EsObligatorio = False
        Me.txtCargos.FormatoNumero = Nothing
        Me.txtCargos.Location = New System.Drawing.Point(12, 48)
        Me.txtCargos.MaximoAncho = 0
        Me.txtCargos.MensajedeAyuda = Nothing
        Me.txtCargos.Name = "txtCargos"
        Me.txtCargos.Size = New System.Drawing.Size(624, 30)
        Me.txtCargos.SoloLectura = False
        Me.txtCargos.SoloNumeros = True
        Me.txtCargos.TabIndex = 3
        Me.txtCargos.TextodelControl = ""
        Me.txtCargos.TextoLabel = "Cargos :"
        Me.txtCargos.TieneErrorControl = False
        Me.txtCargos.TipoBusqueda = SamitCtlNet.ModGeneral.TipoBusqueda.Ninguna
        Me.txtCargos.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtCargos.TipodeLetra = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCargos.ValordelControl = ""
        Me.txtCargos.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCargos.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCargos.ValorPredeterminado = Nothing
        '
        'gcPlantaCargos
        '
        Me.gcPlantaCargos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcPlantaCargos.Location = New System.Drawing.Point(12, 82)
        Me.gcPlantaCargos.MainView = Me.gvPlantaCargos
        Me.gcPlantaCargos.Name = "gcPlantaCargos"
        Me.gcPlantaCargos.Size = New System.Drawing.Size(770, 487)
        Me.gcPlantaCargos.TabIndex = 16
        Me.gcPlantaCargos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvPlantaCargos})
        '
        'gvPlantaCargos
        '
        Me.gvPlantaCargos.GridControl = Me.gcPlantaCargos
        Me.gvPlantaCargos.Name = "gvPlantaCargos"
        '
        'ndCantidad
        '
        Me.ndCantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ndCantidad.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ndCantidad.Location = New System.Drawing.Point(730, 52)
        Me.ndCantidad.Name = "ndCantidad"
        Me.ndCantidad.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.ndCantidad.Properties.Appearance.Options.UseFont = True
        Me.ndCantidad.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ndCantidad.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ndCantidad.Size = New System.Drawing.Size(52, 24)
        Me.ndCantidad.TabIndex = 52
        '
        'lblCantidad
        '
        Me.lblCantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCantidad.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lblCantidad.Appearance.Options.UseFont = True
        Me.lblCantidad.Appearance.Options.UseTextOptions = True
        Me.lblCantidad.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblCantidad.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lblCantidad.Location = New System.Drawing.Point(642, 55)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Padding = New System.Windows.Forms.Padding(2)
        Me.lblCantidad.Size = New System.Drawing.Size(82, 18)
        Me.lblCantidad.TabIndex = 53
        Me.lblCantidad.Text = "Cantidad :"
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
        Me.GroupControl2.Controls.Add(Me.btnEliminar)
        Me.GroupControl2.Controls.Add(Me.btnGuardar)
        Me.GroupControl2.Location = New System.Drawing.Point(789, 14)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(88, 555)
        Me.GroupControl2.TabIndex = 54
        Me.GroupControl2.Text = "Opciones"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLimpiar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnLimpiar.Appearance.Options.UseFont = True
        Me.btnLimpiar.Location = New System.Drawing.Point(7, 109)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(74, 35)
        Me.btnLimpiar.TabIndex = 4
        Me.btnLimpiar.Text = "Limpiar"
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(7, 150)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(74, 35)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "Salir"
        '
        'btnEliminar
        '
        Me.btnEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(7, 68)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(74, 35)
        Me.btnEliminar.TabIndex = 3
        Me.btnEliminar.Text = "Eliminar"
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Location = New System.Drawing.Point(7, 27)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(74, 35)
        Me.btnGuardar.TabIndex = 2
        Me.btnGuardar.Text = "Guardar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'FrmPlantaCargos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(889, 581)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.ndCantidad)
        Me.Controls.Add(Me.lblCantidad)
        Me.Controls.Add(Me.gcPlantaCargos)
        Me.Controls.Add(Me.txtCargos)
        Me.Controls.Add(Me.txtOficina)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmPlantaCargos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Planta de Cargos"
        CType(Me.gcPlantaCargos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvPlantaCargos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ndCantidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtOficina As SamitCtlNet.SamitBusq
    Friend WithEvents txtCargos As SamitCtlNet.SamitBusq
    Friend WithEvents gcPlantaCargos As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvPlantaCargos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ndCantidad As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents lblCantidad As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnLimpiar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
End Class
