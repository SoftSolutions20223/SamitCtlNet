<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLiquidarPrestacionesSocialesyOtros
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLiquidarPrestacionesSocialesyOtros))
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.btnLimpiar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnBuscar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnLiquidar = New DevExpress.XtraEditors.SimpleButton()
        Me.gcPrincipal = New DevExpress.XtraEditors.GroupControl()
        Me.txtAño = New SamitCtlNet.SamitTexto()
        Me.txtNominas = New SamitCtlNet.SamitBusq()
        Me.txtSemestre = New SamitCtlNet.SamitBusq()
        Me.txtOficina = New SamitCtlNet.SamitBusq()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.gcLiquidaNomina = New DevExpress.XtraGrid.GridControl()
        Me.gvLiquidaNomina = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.vgDescPorNomina = New DevExpress.XtraVerticalGrid.VGridControl()
        Me.PanelControl11 = New DevExpress.XtraEditors.PanelControl()
        Me.vgIngresosDeducciones = New DevExpress.XtraVerticalGrid.VGridControl()
        Me.gbxOpciones = New DevExpress.XtraEditors.GroupControl()
        CType(Me.gcPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gcPrincipal.SuspendLayout()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.gcLiquidaNomina, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvLiquidaNomina, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me.vgDescPorNomina, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl11.SuspendLayout()
        CType(Me.vgIngresosDeducciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gbxOpciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxOpciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(7, 184)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(74, 46)
        Me.btnSalir.TabIndex = 8
        Me.btnSalir.Text = "Salir"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLimpiar.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnLimpiar.Appearance.Options.UseFont = True
        Me.btnLimpiar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnLimpiar.Location = New System.Drawing.Point(7, 131)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(74, 46)
        Me.btnLimpiar.TabIndex = 7
        Me.btnLimpiar.Text = "Limpiar"
        '
        'btnBuscar
        '
        Me.btnBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnBuscar.Location = New System.Drawing.Point(7, 26)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(74, 46)
        Me.btnBuscar.TabIndex = 5
        Me.btnBuscar.Text = "Buscar"
        '
        'btnLiquidar
        '
        Me.btnLiquidar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLiquidar.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnLiquidar.Appearance.Options.UseFont = True
        Me.btnLiquidar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnLiquidar.Location = New System.Drawing.Point(7, 78)
        Me.btnLiquidar.Name = "btnLiquidar"
        Me.btnLiquidar.Size = New System.Drawing.Size(74, 46)
        Me.btnLiquidar.TabIndex = 6
        Me.btnLiquidar.Text = "Liquidar"
        '
        'gcPrincipal
        '
        Me.gcPrincipal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcPrincipal.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.gcPrincipal.AppearanceCaption.Options.UseFont = True
        Me.gcPrincipal.Controls.Add(Me.txtAño)
        Me.gcPrincipal.Controls.Add(Me.txtNominas)
        Me.gcPrincipal.Controls.Add(Me.txtSemestre)
        Me.gcPrincipal.Controls.Add(Me.txtOficina)
        Me.gcPrincipal.Location = New System.Drawing.Point(6, 4)
        Me.gcPrincipal.Name = "gcPrincipal"
        Me.gcPrincipal.Size = New System.Drawing.Size(1064, 88)
        Me.gcPrincipal.TabIndex = 103
        Me.gcPrincipal.Text = "Parámetros busqueda"
        '
        'txtAño
        '
        Me.txtAño.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtAño.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtAño.AltodelControl = 30
        Me.txtAño.AnchoLabel = 85
        Me.txtAño.AutoSize = True
        Me.txtAño.BackColor = System.Drawing.Color.Transparent
        Me.txtAño.ColordeFondo = System.Drawing.Color.Transparent
        Me.txtAño.EsObligatorio = False
        Me.txtAño.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAño.FormatoNumero = Nothing
        Me.txtAño.Location = New System.Drawing.Point(6, 24)
        Me.txtAño.MaximoAncho = 0
        Me.txtAño.MensajedeAyuda = ""
        Me.txtAño.Name = "txtAño"
        Me.txtAño.Size = New System.Drawing.Size(187, 30)
        Me.txtAño.SoloLectura = False
        Me.txtAño.SoloNumeros = False
        Me.txtAño.TabIndex = 1
        Me.txtAño.TextodelControl = ""
        Me.txtAño.TextoLabel = "Año :"
        Me.txtAño.TieneErrorControl = False
        Me.txtAño.TipodeDatos = SamitCtlNet.TipodeDato.Numeros
        Me.txtAño.TipodeLetra = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAño.ValordelControl = Nothing
        Me.txtAño.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtAño.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtAño.ValorPredeterminado = Nothing
        '
        'txtNominas
        '
        Me.txtNominas.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtNominas.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtNominas.AltodelControl = 30
        Me.txtNominas.AnchoLabel = 85
        Me.txtNominas.AnchoTxt = 50
        Me.txtNominas.AutoCargarDatos = True
        Me.txtNominas.AutoSize = True
        Me.txtNominas.BackColor = System.Drawing.Color.Transparent
        Me.txtNominas.ColorFondo = System.Drawing.Color.Transparent
        Me.txtNominas.CondicionValida = ""
        Me.txtNominas.Conexion = SamitCtlNet.ConexionSAMIT.ConexModulo
        Me.txtNominas.ConsultaSQL = Nothing
        Me.txtNominas.EsObligatorio = False
        Me.txtNominas.FormatoNumero = Nothing
        Me.txtNominas.Location = New System.Drawing.Point(8, 53)
        Me.txtNominas.MaximoAncho = 0
        Me.txtNominas.MensajedeAyuda = Nothing
        Me.txtNominas.Name = "txtNominas"
        Me.txtNominas.Size = New System.Drawing.Size(340, 30)
        Me.txtNominas.SoloLectura = False
        Me.txtNominas.SoloNumeros = True
        Me.txtNominas.TabIndex = 3
        Me.txtNominas.TextodelControl = ""
        Me.txtNominas.TextoLabel = "Nominas :"
        Me.txtNominas.TieneErrorControl = False
        Me.txtNominas.TipoBusqueda = SamitCtlNet.ModGeneral.TipoBusqueda.Ninguna
        Me.txtNominas.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtNominas.TipodeLetra = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNominas.ValordelControl = ""
        Me.txtNominas.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNominas.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNominas.ValorPredeterminado = Nothing
        '
        'txtSemestre
        '
        Me.txtSemestre.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtSemestre.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtSemestre.AltodelControl = 30
        Me.txtSemestre.AnchoLabel = 85
        Me.txtSemestre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSemestre.AnchoTxt = 70
        Me.txtSemestre.AutoCargarDatos = True
        Me.txtSemestre.AutoSize = True
        Me.txtSemestre.BackColor = System.Drawing.Color.Transparent
        Me.txtSemestre.ColorFondo = System.Drawing.Color.Transparent
        Me.txtSemestre.CondicionValida = ""
        Me.txtSemestre.Conexion = SamitCtlNet.ConexionSAMIT.ConexModulo
        Me.txtSemestre.ConsultaSQL = Nothing
        Me.txtSemestre.EsObligatorio = False
        Me.txtSemestre.FormatoNumero = Nothing
        Me.txtSemestre.Location = New System.Drawing.Point(354, 53)
        Me.txtSemestre.MaximoAncho = 0
        Me.txtSemestre.MensajedeAyuda = Nothing
        Me.txtSemestre.Name = "txtSemestre"
        Me.txtSemestre.Size = New System.Drawing.Size(705, 30)
        Me.txtSemestre.SoloLectura = False
        Me.txtSemestre.SoloNumeros = True
        Me.txtSemestre.TabIndex = 4
        Me.txtSemestre.TextodelControl = ""
        Me.txtSemestre.TextoLabel = "Semestre :"
        Me.txtSemestre.TieneErrorControl = False
        Me.txtSemestre.TipoBusqueda = SamitCtlNet.ModGeneral.TipoBusqueda.Ninguna
        Me.txtSemestre.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtSemestre.TipodeLetra = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSemestre.ValordelControl = ""
        Me.txtSemestre.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtSemestre.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtSemestre.ValorPredeterminado = Nothing
        '
        'txtOficina
        '
        Me.txtOficina.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtOficina.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtOficina.AltodelControl = 30
        Me.txtOficina.AnchoLabel = 80
        Me.txtOficina.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOficina.AnchoTxt = 70
        Me.txtOficina.AutoCargarDatos = True
        Me.txtOficina.AutoSize = True
        Me.txtOficina.BackColor = System.Drawing.Color.Transparent
        Me.txtOficina.ColorFondo = System.Drawing.Color.Transparent
        Me.txtOficina.CondicionValida = ""
        Me.txtOficina.Conexion = SamitCtlNet.ConexionSAMIT.ConexModulo
        Me.txtOficina.ConsultaSQL = Nothing
        Me.txtOficina.EsObligatorio = False
        Me.txtOficina.FormatoNumero = Nothing
        Me.txtOficina.Location = New System.Drawing.Point(197, 23)
        Me.txtOficina.MaximoAncho = 0
        Me.txtOficina.MensajedeAyuda = Nothing
        Me.txtOficina.Name = "txtOficina"
        Me.txtOficina.Size = New System.Drawing.Size(862, 30)
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
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(6, 98)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.gcLiquidaNomina)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.TableLayoutPanel4)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1064, 588)
        Me.SplitContainerControl1.SplitterPosition = 293
        Me.SplitContainerControl1.TabIndex = 105
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'gcLiquidaNomina
        '
        Me.gcLiquidaNomina.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcLiquidaNomina.Location = New System.Drawing.Point(0, 0)
        Me.gcLiquidaNomina.MainView = Me.gvLiquidaNomina
        Me.gcLiquidaNomina.Name = "gcLiquidaNomina"
        Me.gcLiquidaNomina.Size = New System.Drawing.Size(1064, 293)
        Me.gcLiquidaNomina.TabIndex = 0
        Me.gcLiquidaNomina.TabStop = False
        Me.gcLiquidaNomina.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvLiquidaNomina})
        '
        'gvLiquidaNomina
        '
        Me.gvLiquidaNomina.GridControl = Me.gcLiquidaNomina
        Me.gvLiquidaNomina.Name = "gvLiquidaNomina"
        Me.gvLiquidaNomina.OptionsView.ShowGroupPanel = False
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.vgDescPorNomina, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.PanelControl11, 0, 0)
        Me.TableLayoutPanel4.ForeColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(-1, 7)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(1067, 278)
        Me.TableLayoutPanel4.TabIndex = 3
        '
        'vgDescPorNomina
        '
        Me.vgDescPorNomina.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.vgDescPorNomina.Location = New System.Drawing.Point(536, 3)
        Me.vgDescPorNomina.Name = "vgDescPorNomina"
        Me.vgDescPorNomina.OptionsMenu.EnableContextMenu = False
        Me.vgDescPorNomina.Size = New System.Drawing.Size(528, 272)
        Me.vgDescPorNomina.TabIndex = 4
        '
        'PanelControl11
        '
        Me.PanelControl11.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl11.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl11.Controls.Add(Me.vgIngresosDeducciones)
        Me.PanelControl11.Location = New System.Drawing.Point(3, 0)
        Me.PanelControl11.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.PanelControl11.Name = "PanelControl11"
        Me.PanelControl11.Size = New System.Drawing.Size(527, 275)
        Me.PanelControl11.TabIndex = 0
        '
        'vgIngresosDeducciones
        '
        Me.vgIngresosDeducciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.vgIngresosDeducciones.Location = New System.Drawing.Point(0, 0)
        Me.vgIngresosDeducciones.Name = "vgIngresosDeducciones"
        Me.vgIngresosDeducciones.OptionsMenu.EnableContextMenu = False
        Me.vgIngresosDeducciones.Size = New System.Drawing.Size(527, 275)
        Me.vgIngresosDeducciones.TabIndex = 0
        Me.vgIngresosDeducciones.TabStop = False
        '
        'gbxOpciones
        '
        Me.gbxOpciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxOpciones.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.gbxOpciones.AppearanceCaption.Options.UseFont = True
        Me.gbxOpciones.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.gbxOpciones.CaptionImagePadding = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.gbxOpciones.Controls.Add(Me.btnSalir)
        Me.gbxOpciones.Controls.Add(Me.btnBuscar)
        Me.gbxOpciones.Controls.Add(Me.btnLiquidar)
        Me.gbxOpciones.Controls.Add(Me.btnLimpiar)
        Me.gbxOpciones.Location = New System.Drawing.Point(1076, 4)
        Me.gbxOpciones.Name = "gbxOpciones"
        Me.gbxOpciones.Size = New System.Drawing.Size(88, 682)
        Me.gbxOpciones.TabIndex = 106
        Me.gbxOpciones.Text = "Opciones"
        '
        'FrmLiquidarPrestacionesSocialesyOtros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1169, 690)
        Me.Controls.Add(Me.gbxOpciones)
        Me.Controls.Add(Me.gcPrincipal)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmLiquidarPrestacionesSocialesyOtros"
        Me.Text = "Liquidar Semestre"
        CType(Me.gcPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gcPrincipal.ResumeLayout(False)
        Me.gcPrincipal.PerformLayout()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.gcLiquidaNomina, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvLiquidaNomina, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel4.ResumeLayout(False)
        CType(Me.vgDescPorNomina, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl11.ResumeLayout(False)
        CType(Me.vgIngresosDeducciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gbxOpciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxOpciones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnLimpiar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnLiquidar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gcPrincipal As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtNominas As SamitCtlNet.SamitBusq
    Friend WithEvents txtAño As SamitCtlNet.SamitTexto
    Friend WithEvents txtOficina As SamitCtlNet.SamitBusq
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents gcLiquidaNomina As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvLiquidaNomina As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PanelControl11 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents vgIngresosDeducciones As DevExpress.XtraVerticalGrid.VGridControl
    Friend WithEvents txtSemestre As SamitCtlNet.SamitBusq
    Friend WithEvents gbxOpciones As DevExpress.XtraEditors.GroupControl
    Friend WithEvents vgDescPorNomina As DevExpress.XtraVerticalGrid.VGridControl
End Class
