<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConfigConceptosPro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConfigConceptosPro))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.btnBuscar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.btnLimpiar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.gbxPrincipal = New DevExpress.XtraEditors.GroupControl()
        Me.btnAbrirFormula = New DevExpress.XtraEditors.SimpleButton()
        Me.txtNomina = New SamitCtlNet.SamitBusq()
        Me.gcVariables = New DevExpress.XtraGrid.GridControl()
        Me.gvVariables = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtBusqueda = New DevExpress.XtraEditors.TextEdit()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.ckeSemestre1 = New DevExpress.XtraEditors.CheckEdit()
        Me.ckeSemestre2 = New DevExpress.XtraEditors.CheckEdit()
        Me.txtCtaContable = New SamitCtlNet.SamitBusq()
        Me.txtFormula = New SamitCtlNet.SamitTexto()
        Me.SeparatorControl6 = New DevExpress.XtraEditors.SeparatorControl()
        Me.txtConcepto = New SamitCtlNet.SamitBusq()
        Me.gcConfigConceptos = New DevExpress.XtraGrid.GridControl()
        Me.gvConfigConceptos = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.gbxPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxPrincipal.SuspendLayout()
        CType(Me.gcVariables, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvVariables, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBusqueda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.ckeSemestre1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckeSemestre2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeparatorControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcConfigConceptos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvConfigConceptos, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GroupControl1.Controls.Add(Me.btnBuscar)
        Me.GroupControl1.Controls.Add(Me.btnSalir)
        Me.GroupControl1.Controls.Add(Me.btnLimpiar)
        Me.GroupControl1.Controls.Add(Me.btnGuardar)
        Me.GroupControl1.Location = New System.Drawing.Point(839, 6)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(88, 567)
        Me.GroupControl1.TabIndex = 4
        Me.GroupControl1.Text = "Opciones"
        '
        'btnBuscar
        '
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Location = New System.Drawing.Point(7, 27)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(74, 30)
        Me.btnBuscar.TabIndex = 5
        Me.btnBuscar.Text = "Buscar"
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(7, 135)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(74, 30)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "Salir"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnLimpiar.Appearance.Options.UseFont = True
        Me.btnLimpiar.Location = New System.Drawing.Point(7, 99)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(74, 30)
        Me.btnLimpiar.TabIndex = 3
        Me.btnLimpiar.Text = "Limpiar"
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Location = New System.Drawing.Point(7, 63)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(74, 30)
        Me.btnGuardar.TabIndex = 2
        Me.btnGuardar.Text = "Guardar"
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
        Me.gbxPrincipal.Controls.Add(Me.txtNomina)
        Me.gbxPrincipal.Controls.Add(Me.gcVariables)
        Me.gbxPrincipal.Controls.Add(Me.txtBusqueda)
        Me.gbxPrincipal.Controls.Add(Me.GroupControl2)
        Me.gbxPrincipal.Controls.Add(Me.txtCtaContable)
        Me.gbxPrincipal.Controls.Add(Me.txtFormula)
        Me.gbxPrincipal.Controls.Add(Me.SeparatorControl6)
        Me.gbxPrincipal.Controls.Add(Me.txtConcepto)
        Me.gbxPrincipal.Controls.Add(Me.gcConfigConceptos)
        Me.gbxPrincipal.Location = New System.Drawing.Point(7, 6)
        Me.gbxPrincipal.Name = "gbxPrincipal"
        Me.gbxPrincipal.Size = New System.Drawing.Size(825, 569)
        Me.gbxPrincipal.TabIndex = 3
        Me.gbxPrincipal.TabStop = True
        Me.gbxPrincipal.Text = "Datos del Concepto"
        '
        'btnAbrirFormula
        '
        Me.btnAbrirFormula.AllowFocus = False
        Me.btnAbrirFormula.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAbrirFormula.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnAbrirFormula.Appearance.Options.UseFont = True
        Me.btnAbrirFormula.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnAbrirFormula.Location = New System.Drawing.Point(497, 93)
        Me.btnAbrirFormula.Name = "btnAbrirFormula"
        Me.btnAbrirFormula.Size = New System.Drawing.Size(34, 25)
        Me.btnAbrirFormula.TabIndex = 105
        Me.btnAbrirFormula.TabStop = False
        '
        'txtNomina
        '
        Me.txtNomina.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtNomina.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtNomina.AltodelControl = 30
        Me.txtNomina.AnchoLabel = 120
        Me.txtNomina.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNomina.AnchoTxt = 120
        Me.txtNomina.AutoCargarDatos = True
        Me.txtNomina.AutoSize = True
        Me.txtNomina.BackColor = System.Drawing.Color.Transparent
        Me.txtNomina.ColorFondo = System.Drawing.Color.Transparent
        Me.txtNomina.CondicionValida = ""
        Me.txtNomina.Conexion = SamitCtlNet.ConexionSAMIT.ConexModulo
        Me.txtNomina.ConsultaSQL = ""
        Me.txtNomina.EsObligatorio = False
        Me.txtNomina.FormatoNumero = Nothing
        Me.txtNomina.Location = New System.Drawing.Point(5, 27)
        Me.txtNomina.MaximoAncho = 0
        Me.txtNomina.MensajedeAyuda = ""
        Me.txtNomina.Name = "txtNomina"
        Me.txtNomina.Size = New System.Drawing.Size(815, 30)
        Me.txtNomina.SoloLectura = False
        Me.txtNomina.SoloNumeros = False
        Me.txtNomina.TabIndex = 104
        Me.txtNomina.TextodelControl = ""
        Me.txtNomina.TextoLabel = "Nomina :"
        Me.txtNomina.TieneErrorControl = False
        Me.txtNomina.TipoBusqueda = SamitCtlNet.ModGeneral.TipoBusqueda.Ninguna
        Me.txtNomina.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtNomina.TipodeLetra = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomina.ValordelControl = ""
        Me.txtNomina.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNomina.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNomina.ValorPredeterminado = Nothing
        '
        'gcVariables
        '
        Me.gcVariables.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcVariables.Location = New System.Drawing.Point(2, 236)
        Me.gcVariables.MainView = Me.gvVariables
        Me.gcVariables.Name = "gcVariables"
        Me.gcVariables.Size = New System.Drawing.Size(819, 279)
        Me.gcVariables.TabIndex = 103
        Me.gcVariables.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvVariables})
        Me.gcVariables.Visible = False
        '
        'gvVariables
        '
        Me.gvVariables.GridControl = Me.gcVariables
        Me.gvVariables.Name = "gvVariables"
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBusqueda.Location = New System.Drawing.Point(4, 166)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.txtBusqueda.Properties.Appearance.Options.UseFont = True
        Me.txtBusqueda.Size = New System.Drawing.Size(818, 24)
        Me.txtBusqueda.TabIndex = 102
        Me.txtBusqueda.TabStop = False
        '
        'GroupControl2
        '
        Me.GroupControl2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.Controls.Add(Me.ckeSemestre1)
        Me.GroupControl2.Controls.Add(Me.ckeSemestre2)
        Me.GroupControl2.Location = New System.Drawing.Point(540, 95)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.ScrollBarSmallChange = 4
        Me.GroupControl2.Size = New System.Drawing.Size(278, 57)
        Me.GroupControl2.TabIndex = 101
        Me.GroupControl2.Text = "Semestres del año a liquidar :"
        '
        'ckeSemestre1
        '
        Me.ckeSemestre1.Location = New System.Drawing.Point(14, 28)
        Me.ckeSemestre1.Name = "ckeSemestre1"
        Me.ckeSemestre1.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckeSemestre1.Properties.Appearance.Options.UseFont = True
        Me.ckeSemestre1.Properties.Caption = "Semestre 1"
        Me.ckeSemestre1.Size = New System.Drawing.Size(90, 19)
        Me.ckeSemestre1.TabIndex = 1
        '
        'ckeSemestre2
        '
        Me.ckeSemestre2.Location = New System.Drawing.Point(110, 28)
        Me.ckeSemestre2.Name = "ckeSemestre2"
        Me.ckeSemestre2.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckeSemestre2.Properties.Appearance.Options.UseFont = True
        Me.ckeSemestre2.Properties.Caption = "Semestre 2"
        Me.ckeSemestre2.Size = New System.Drawing.Size(96, 19)
        Me.ckeSemestre2.TabIndex = 2
        '
        'txtCtaContable
        '
        Me.txtCtaContable.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtCtaContable.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtCtaContable.AltodelControl = 30
        Me.txtCtaContable.AnchoLabel = 120
        Me.txtCtaContable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCtaContable.AnchoTxt = 80
        Me.txtCtaContable.AutoCargarDatos = True
        Me.txtCtaContable.AutoSize = True
        Me.txtCtaContable.BackColor = System.Drawing.Color.Transparent
        Me.txtCtaContable.ColorFondo = System.Drawing.Color.Transparent
        Me.txtCtaContable.CondicionValida = ""
        Me.txtCtaContable.Conexion = SamitCtlNet.ConexionSAMIT.ConexModulo
        Me.txtCtaContable.ConsultaSQL = Nothing
        Me.txtCtaContable.EsObligatorio = False
        Me.txtCtaContable.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtCtaContable.FormatoNumero = Nothing
        Me.txtCtaContable.Location = New System.Drawing.Point(6, 122)
        Me.txtCtaContable.MaximoAncho = 0
        Me.txtCtaContable.MensajedeAyuda = ""
        Me.txtCtaContable.Name = "txtCtaContable"
        Me.txtCtaContable.Size = New System.Drawing.Size(528, 30)
        Me.txtCtaContable.SoloLectura = False
        Me.txtCtaContable.SoloNumeros = True
        Me.txtCtaContable.TabIndex = 5
        Me.txtCtaContable.TextodelControl = ""
        Me.txtCtaContable.TextoLabel = "Cta Contable :"
        Me.txtCtaContable.TieneErrorControl = False
        Me.txtCtaContable.TipoBusqueda = SamitCtlNet.ModGeneral.TipoBusqueda.Ninguna
        Me.txtCtaContable.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtCtaContable.TipodeLetra = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtCtaContable.ValordelControl = ""
        Me.txtCtaContable.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCtaContable.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCtaContable.ValorPredeterminado = Nothing
        '
        'txtFormula
        '
        Me.txtFormula.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtFormula.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtFormula.AltodelControl = 30
        Me.txtFormula.AnchoLabel = 120
        Me.txtFormula.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFormula.AutoSize = True
        Me.txtFormula.BackColor = System.Drawing.Color.Transparent
        Me.txtFormula.ColordeFondo = System.Drawing.Color.Transparent
        Me.txtFormula.EsObligatorio = False
        Me.txtFormula.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFormula.FormatoNumero = Nothing
        Me.txtFormula.Location = New System.Drawing.Point(5, 92)
        Me.txtFormula.MaximoAncho = 0
        Me.txtFormula.MensajedeAyuda = ""
        Me.txtFormula.Name = "txtFormula"
        Me.txtFormula.Size = New System.Drawing.Size(489, 30)
        Me.txtFormula.SoloLectura = False
        Me.txtFormula.SoloNumeros = False
        Me.txtFormula.TabIndex = 3
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
        'SeparatorControl6
        '
        Me.SeparatorControl6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SeparatorControl6.Location = New System.Drawing.Point(5, 160)
        Me.SeparatorControl6.Name = "SeparatorControl6"
        Me.SeparatorControl6.Padding = New System.Windows.Forms.Padding(0)
        Me.SeparatorControl6.Size = New System.Drawing.Size(818, 3)
        Me.SeparatorControl6.TabIndex = 95
        Me.SeparatorControl6.TabStop = False
        '
        'txtConcepto
        '
        Me.txtConcepto.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtConcepto.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtConcepto.AltodelControl = 30
        Me.txtConcepto.AnchoLabel = 120
        Me.txtConcepto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtConcepto.AnchoTxt = 120
        Me.txtConcepto.AutoCargarDatos = True
        Me.txtConcepto.AutoSize = True
        Me.txtConcepto.BackColor = System.Drawing.Color.Transparent
        Me.txtConcepto.ColorFondo = System.Drawing.Color.Transparent
        Me.txtConcepto.CondicionValida = ""
        Me.txtConcepto.Conexion = SamitCtlNet.ConexionSAMIT.ConexModulo
        Me.txtConcepto.ConsultaSQL = Nothing
        Me.txtConcepto.EsObligatorio = False
        Me.txtConcepto.FormatoNumero = Nothing
        Me.txtConcepto.Location = New System.Drawing.Point(6, 59)
        Me.txtConcepto.MaximoAncho = 0
        Me.txtConcepto.MensajedeAyuda = ""
        Me.txtConcepto.Name = "txtConcepto"
        Me.txtConcepto.Size = New System.Drawing.Size(814, 30)
        Me.txtConcepto.SoloLectura = False
        Me.txtConcepto.SoloNumeros = False
        Me.txtConcepto.TabIndex = 2
        Me.txtConcepto.TextodelControl = ""
        Me.txtConcepto.TextoLabel = "Concepto :"
        Me.txtConcepto.TieneErrorControl = False
        Me.txtConcepto.TipoBusqueda = SamitCtlNet.ModGeneral.TipoBusqueda.Ninguna
        Me.txtConcepto.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtConcepto.TipodeLetra = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConcepto.ValordelControl = ""
        Me.txtConcepto.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtConcepto.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtConcepto.ValorPredeterminado = Nothing
        '
        'gcConfigConceptos
        '
        Me.gcConfigConceptos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcConfigConceptos.Location = New System.Drawing.Point(2, 194)
        Me.gcConfigConceptos.MainView = Me.gvConfigConceptos
        Me.gcConfigConceptos.Name = "gcConfigConceptos"
        Me.gcConfigConceptos.Size = New System.Drawing.Size(821, 373)
        Me.gcConfigConceptos.TabIndex = 1
        Me.gcConfigConceptos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvConfigConceptos})
        '
        'gvConfigConceptos
        '
        Me.gvConfigConceptos.GridControl = Me.gcConfigConceptos
        Me.gvConfigConceptos.Name = "gvConfigConceptos"
        '
        'FrmConfigConceptosPro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(934, 580)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.gbxPrincipal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmConfigConceptosPro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Config Liquida Semestres"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.gbxPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxPrincipal.ResumeLayout(False)
        Me.gbxPrincipal.PerformLayout()
        CType(Me.gcVariables, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvVariables, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBusqueda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.ckeSemestre1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckeSemestre2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeparatorControl6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcConfigConceptos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvConfigConceptos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnLimpiar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gbxPrincipal As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gcVariables As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvVariables As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtBusqueda As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents ckeSemestre1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ckeSemestre2 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtCtaContable As SamitCtlNet.SamitBusq
    Friend WithEvents txtFormula As SamitCtlNet.SamitTexto
    Friend WithEvents SeparatorControl6 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents txtConcepto As SamitCtlNet.SamitBusq
    Friend WithEvents gcConfigConceptos As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvConfigConceptos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtNomina As SamitCtlNet.SamitBusq
    Friend WithEvents btnBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAbrirFormula As DevExpress.XtraEditors.SimpleButton
End Class
