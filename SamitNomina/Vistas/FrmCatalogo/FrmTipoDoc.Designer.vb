<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTipoDoc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTipoDoc))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnLimpiar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEliminar = New DevExpress.XtraEditors.SimpleButton()
        Me.gbxPrincipal = New DevExpress.XtraEditors.GroupControl()
        Me.lblUsaPariente = New DevExpress.XtraEditors.LabelControl()
        Me.rgUsaParientes = New DevExpress.XtraEditors.RadioGroup()
        Me.lblUsaEmpleado = New DevExpress.XtraEditors.LabelControl()
        Me.rgUsaEmpleados = New DevExpress.XtraEditors.RadioGroup()
        Me.txtNombre = New SamitCtlNet.SamitTexto()
        Me.SeparatorControl1 = New DevExpress.XtraEditors.SeparatorControl()
        Me.txtIdTipoDoc = New SamitCtlNet.SamitTexto()
        Me.gcEstadoCivil = New DevExpress.XtraGrid.GridControl()
        Me.gvEstadoCivil = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.gbxPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxPrincipal.SuspendLayout()
        CType(Me.rgUsaParientes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgUsaEmpleados.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcEstadoCivil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvEstadoCivil, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GroupControl1.TabIndex = 17
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
        Me.gbxPrincipal.Controls.Add(Me.lblUsaPariente)
        Me.gbxPrincipal.Controls.Add(Me.rgUsaParientes)
        Me.gbxPrincipal.Controls.Add(Me.lblUsaEmpleado)
        Me.gbxPrincipal.Controls.Add(Me.rgUsaEmpleados)
        Me.gbxPrincipal.Controls.Add(Me.txtNombre)
        Me.gbxPrincipal.Controls.Add(Me.SeparatorControl1)
        Me.gbxPrincipal.Controls.Add(Me.txtIdTipoDoc)
        Me.gbxPrincipal.Controls.Add(Me.gcEstadoCivil)
        Me.gbxPrincipal.Location = New System.Drawing.Point(8, 9)
        Me.gbxPrincipal.Name = "gbxPrincipal"
        Me.gbxPrincipal.Size = New System.Drawing.Size(582, 553)
        Me.gbxPrincipal.TabIndex = 16
        Me.gbxPrincipal.TabStop = True
        Me.gbxPrincipal.Text = "Información"
        '
        'lblUsaPariente
        '
        Me.lblUsaPariente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUsaPariente.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lblUsaPariente.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblUsaPariente.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblUsaPariente.Location = New System.Drawing.Point(363, 56)
        Me.lblUsaPariente.Name = "lblUsaPariente"
        Me.lblUsaPariente.Padding = New System.Windows.Forms.Padding(2)
        Me.lblUsaPariente.Size = New System.Drawing.Size(117, 26)
        Me.lblUsaPariente.TabIndex = 77
        Me.lblUsaPariente.Text = "Para Parientes :"
        '
        'rgUsaParientes
        '
        Me.rgUsaParientes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rgUsaParientes.EditValue = True
        Me.rgUsaParientes.Location = New System.Drawing.Point(486, 58)
        Me.rgUsaParientes.Name = "rgUsaParientes"
        Me.rgUsaParientes.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.rgUsaParientes.Properties.Appearance.Options.UseBackColor = True
        Me.rgUsaParientes.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.rgUsaParientes.Properties.Columns = 2
        Me.rgUsaParientes.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.rgUsaParientes.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "NO"), New DevExpress.XtraEditors.Controls.RadioGroupItem(True, "SI")})
        Me.rgUsaParientes.Size = New System.Drawing.Size(90, 23)
        Me.rgUsaParientes.TabIndex = 4
        '
        'lblUsaEmpleado
        '
        Me.lblUsaEmpleado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUsaEmpleado.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lblUsaEmpleado.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblUsaEmpleado.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblUsaEmpleado.Location = New System.Drawing.Point(363, 26)
        Me.lblUsaEmpleado.Name = "lblUsaEmpleado"
        Me.lblUsaEmpleado.Padding = New System.Windows.Forms.Padding(2)
        Me.lblUsaEmpleado.Size = New System.Drawing.Size(117, 26)
        Me.lblUsaEmpleado.TabIndex = 75
        Me.lblUsaEmpleado.Text = "Para Empleados :"
        '
        'rgUsaEmpleados
        '
        Me.rgUsaEmpleados.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rgUsaEmpleados.EditValue = True
        Me.rgUsaEmpleados.Location = New System.Drawing.Point(486, 28)
        Me.rgUsaEmpleados.Name = "rgUsaEmpleados"
        Me.rgUsaEmpleados.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.rgUsaEmpleados.Properties.Appearance.Options.UseBackColor = True
        Me.rgUsaEmpleados.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.rgUsaEmpleados.Properties.Columns = 2
        Me.rgUsaEmpleados.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.rgUsaEmpleados.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "NO"), New DevExpress.XtraEditors.Controls.RadioGroupItem(True, "SI")})
        Me.rgUsaEmpleados.Size = New System.Drawing.Size(90, 23)
        Me.rgUsaEmpleados.TabIndex = 3
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
        Me.txtNombre.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.FormatoNumero = Nothing
        Me.txtNombre.Location = New System.Drawing.Point(5, 57)
        Me.txtNombre.MaximoAncho = 0
        Me.txtNombre.MensajedeAyuda = Nothing
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(352, 30)
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
        'SeparatorControl1
        '
        Me.SeparatorControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SeparatorControl1.Location = New System.Drawing.Point(4, 88)
        Me.SeparatorControl1.Name = "SeparatorControl1"
        Me.SeparatorControl1.Padding = New System.Windows.Forms.Padding(0)
        Me.SeparatorControl1.Size = New System.Drawing.Size(571, 3)
        Me.SeparatorControl1.TabIndex = 72
        Me.SeparatorControl1.TabStop = False
        '
        'txtIdTipoDoc
        '
        Me.txtIdTipoDoc.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtIdTipoDoc.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtIdTipoDoc.AltodelControl = 30
        Me.txtIdTipoDoc.AnchoLabel = 90
        Me.txtIdTipoDoc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtIdTipoDoc.AutoSize = True
        Me.txtIdTipoDoc.BackColor = System.Drawing.Color.Transparent
        Me.txtIdTipoDoc.ColordeFondo = System.Drawing.Color.Transparent
        Me.txtIdTipoDoc.EsObligatorio = False
        Me.txtIdTipoDoc.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdTipoDoc.FormatoNumero = Nothing
        Me.txtIdTipoDoc.Location = New System.Drawing.Point(5, 25)
        Me.txtIdTipoDoc.MaximoAncho = 0
        Me.txtIdTipoDoc.MensajedeAyuda = Nothing
        Me.txtIdTipoDoc.Name = "txtIdTipoDoc"
        Me.txtIdTipoDoc.Size = New System.Drawing.Size(352, 30)
        Me.txtIdTipoDoc.SoloLectura = False
        Me.txtIdTipoDoc.SoloNumeros = False
        Me.txtIdTipoDoc.TabIndex = 1
        Me.txtIdTipoDoc.TextodelControl = ""
        Me.txtIdTipoDoc.TextoLabel = "ID :"
        Me.txtIdTipoDoc.TieneErrorControl = False
        Me.txtIdTipoDoc.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtIdTipoDoc.TipodeLetra = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtIdTipoDoc.ValordelControl = Nothing
        Me.txtIdTipoDoc.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtIdTipoDoc.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtIdTipoDoc.ValorPredeterminado = Nothing
        '
        'gcEstadoCivil
        '
        Me.gcEstadoCivil.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcEstadoCivil.Location = New System.Drawing.Point(2, 97)
        Me.gcEstadoCivil.MainView = Me.gvEstadoCivil
        Me.gcEstadoCivil.Name = "gcEstadoCivil"
        Me.gcEstadoCivil.Size = New System.Drawing.Size(578, 454)
        Me.gcEstadoCivil.TabIndex = 0
        Me.gcEstadoCivil.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvEstadoCivil})
        '
        'gvEstadoCivil
        '
        Me.gvEstadoCivil.GridControl = Me.gcEstadoCivil
        Me.gvEstadoCivil.Name = "gvEstadoCivil"
        '
        'FrmTipoDoc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 573)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.gbxPrincipal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmTipoDoc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tipos de documento"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.gbxPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxPrincipal.ResumeLayout(False)
        Me.gbxPrincipal.PerformLayout()
        CType(Me.rgUsaParientes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgUsaEmpleados.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcEstadoCivil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvEstadoCivil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnLimpiar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gbxPrincipal As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SeparatorControl1 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents txtIdTipoDoc As SamitCtlNet.SamitTexto
    Friend WithEvents gcEstadoCivil As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvEstadoCivil As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lblUsaPariente As DevExpress.XtraEditors.LabelControl
    Friend WithEvents rgUsaParientes As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents lblUsaEmpleado As DevExpress.XtraEditors.LabelControl
    Friend WithEvents rgUsaEmpleados As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents txtNombre As SamitCtlNet.SamitTexto
End Class
