<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAsig_ValExentos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAsig_ValExentos))
        Me.gbxPrincipal = New DevExpress.XtraEditors.GroupControl()
        Me.lblVigente = New DevExpress.XtraEditors.LabelControl()
        Me.grbVigente = New DevExpress.XtraEditors.RadioGroup()
        Me.txtValor = New SamitCtlNet.SamitTexto()
        Me.btnAgregar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEliminar = New DevExpress.XtraEditors.SimpleButton()
        Me.txtValorExento = New SamitCtlNet.SamitBusq()
        Me.txtContratos = New SamitCtlNet.SamitBusq()
        Me.gcValoresExentos = New DevExpress.XtraGrid.GridControl()
        Me.gvValoresExentos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.btnLimpiar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.gbxPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxPrincipal.SuspendLayout()
        CType(Me.grbVigente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcValoresExentos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvValoresExentos, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.gbxPrincipal.Controls.Add(Me.lblVigente)
        Me.gbxPrincipal.Controls.Add(Me.grbVigente)
        Me.gbxPrincipal.Controls.Add(Me.txtValor)
        Me.gbxPrincipal.Controls.Add(Me.btnAgregar)
        Me.gbxPrincipal.Controls.Add(Me.btnEliminar)
        Me.gbxPrincipal.Controls.Add(Me.txtValorExento)
        Me.gbxPrincipal.Controls.Add(Me.txtContratos)
        Me.gbxPrincipal.Controls.Add(Me.gcValoresExentos)
        Me.gbxPrincipal.Location = New System.Drawing.Point(8, 8)
        Me.gbxPrincipal.Name = "gbxPrincipal"
        Me.gbxPrincipal.Size = New System.Drawing.Size(794, 561)
        Me.gbxPrincipal.TabIndex = 3
        '
        'lblVigente
        '
        Me.lblVigente.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lblVigente.Appearance.Options.UseFont = True
        Me.lblVigente.Appearance.Options.UseTextOptions = True
        Me.lblVigente.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblVigente.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblVigente.Location = New System.Drawing.Point(11, 120)
        Me.lblVigente.Name = "lblVigente"
        Me.lblVigente.Padding = New System.Windows.Forms.Padding(2)
        Me.lblVigente.Size = New System.Drawing.Size(92, 26)
        Me.lblVigente.TabIndex = 99
        Me.lblVigente.Text = "Vigente :"
        '
        'grbVigente
        '
        Me.grbVigente.Location = New System.Drawing.Point(106, 123)
        Me.grbVigente.Name = "grbVigente"
        Me.grbVigente.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.grbVigente.Properties.Appearance.Options.UseBackColor = True
        Me.grbVigente.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.grbVigente.Properties.Columns = 2
        Me.grbVigente.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.grbVigente.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "NO"), New DevExpress.XtraEditors.Controls.RadioGroupItem(True, "SI")})
        Me.grbVigente.Size = New System.Drawing.Size(96, 20)
        Me.grbVigente.TabIndex = 4
        '
        'txtValor
        '
        Me.txtValor.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtValor.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtValor.AltodelControl = 30
        Me.txtValor.AnchoLabel = 105
        Me.txtValor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtValor.AutoSize = True
        Me.txtValor.BackColor = System.Drawing.Color.Transparent
        Me.txtValor.ColordeFondo = System.Drawing.Color.Transparent
        Me.txtValor.EsObligatorio = False
        Me.txtValor.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValor.FormatoNumero = Nothing
        Me.txtValor.Location = New System.Drawing.Point(0, 90)
        Me.txtValor.MaximoAncho = 0
        Me.txtValor.MensajedeAyuda = ""
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(786, 30)
        Me.txtValor.SoloLectura = False
        Me.txtValor.SoloNumeros = False
        Me.txtValor.TabIndex = 3
        Me.txtValor.TextodelControl = ""
        Me.txtValor.TextoLabel = "Valor :"
        Me.txtValor.TieneErrorControl = False
        Me.txtValor.TipodeDatos = SamitCtlNet.TipodeDato.NumerosCon_2_Decimales
        Me.txtValor.TipodeLetra = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtValor.ValordelControl = Nothing
        Me.txtValor.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtValor.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtValor.ValorPredeterminado = Nothing
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregar.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnAgregar.Appearance.Options.UseFont = True
        Me.btnAgregar.Location = New System.Drawing.Point(629, 123)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(74, 25)
        Me.btnAgregar.TabIndex = 5
        Me.btnAgregar.Text = "Agregar"
        '
        'btnEliminar
        '
        Me.btnEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(709, 123)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(74, 25)
        Me.btnEliminar.TabIndex = 6
        Me.btnEliminar.Text = "Quitar"
        '
        'txtValorExento
        '
        Me.txtValorExento.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtValorExento.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtValorExento.AltodelControl = 30
        Me.txtValorExento.AnchoLabel = 100
        Me.txtValorExento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtValorExento.AnchoTxt = 80
        Me.txtValorExento.AutoCargarDatos = True
        Me.txtValorExento.AutoSize = True
        Me.txtValorExento.BackColor = System.Drawing.Color.Transparent
        Me.txtValorExento.ColorFondo = System.Drawing.Color.Transparent
        Me.txtValorExento.CondicionValida = ""
        Me.txtValorExento.Conexion = SamitCtlNet.ConexionSAMIT.ConexModulo
        Me.txtValorExento.ConsultaSQL = Nothing
        Me.txtValorExento.EsObligatorio = False
        Me.txtValorExento.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtValorExento.FormatoNumero = Nothing
        Me.txtValorExento.Location = New System.Drawing.Point(5, 57)
        Me.txtValorExento.MaximoAncho = 0
        Me.txtValorExento.MensajedeAyuda = Nothing
        Me.txtValorExento.Name = "txtValorExento"
        Me.txtValorExento.Size = New System.Drawing.Size(781, 30)
        Me.txtValorExento.SoloLectura = False
        Me.txtValorExento.SoloNumeros = False
        Me.txtValorExento.TabIndex = 2
        Me.txtValorExento.TextodelControl = ""
        Me.txtValorExento.TextoLabel = "Valor Exento :"
        Me.txtValorExento.TieneErrorControl = False
        Me.txtValorExento.TipoBusqueda = SamitCtlNet.ModGeneral.TipoBusqueda.Ninguna
        Me.txtValorExento.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtValorExento.TipodeLetra = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorExento.ValordelControl = ""
        Me.txtValorExento.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtValorExento.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtValorExento.ValorPredeterminado = Nothing
        '
        'txtContratos
        '
        Me.txtContratos.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtContratos.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtContratos.AltodelControl = 30
        Me.txtContratos.AnchoLabel = 100
        Me.txtContratos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtContratos.AnchoTxt = 80
        Me.txtContratos.AutoCargarDatos = True
        Me.txtContratos.AutoSize = True
        Me.txtContratos.BackColor = System.Drawing.Color.Transparent
        Me.txtContratos.ColorFondo = System.Drawing.Color.Transparent
        Me.txtContratos.CondicionValida = ""
        Me.txtContratos.Conexion = SamitCtlNet.ConexionSAMIT.ConexModulo
        Me.txtContratos.ConsultaSQL = Nothing
        Me.txtContratos.EsObligatorio = False
        Me.txtContratos.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtContratos.FormatoNumero = Nothing
        Me.txtContratos.Location = New System.Drawing.Point(5, 24)
        Me.txtContratos.MaximoAncho = 0
        Me.txtContratos.MensajedeAyuda = Nothing
        Me.txtContratos.Name = "txtContratos"
        Me.txtContratos.Size = New System.Drawing.Size(781, 30)
        Me.txtContratos.SoloLectura = False
        Me.txtContratos.SoloNumeros = True
        Me.txtContratos.TabIndex = 1
        Me.txtContratos.TextodelControl = ""
        Me.txtContratos.TextoLabel = "Contrato :"
        Me.txtContratos.TieneErrorControl = False
        Me.txtContratos.TipoBusqueda = SamitCtlNet.ModGeneral.TipoBusqueda.Ninguna
        Me.txtContratos.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtContratos.TipodeLetra = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContratos.ValordelControl = ""
        Me.txtContratos.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtContratos.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtContratos.ValorPredeterminado = Nothing
        '
        'gcValoresExentos
        '
        Me.gcValoresExentos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcValoresExentos.Location = New System.Drawing.Point(0, 153)
        Me.gcValoresExentos.MainView = Me.gvValoresExentos
        Me.gcValoresExentos.Name = "gcValoresExentos"
        Me.gcValoresExentos.Size = New System.Drawing.Size(794, 408)
        Me.gcValoresExentos.TabIndex = 0
        Me.gcValoresExentos.TabStop = False
        Me.gcValoresExentos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvValoresExentos})
        '
        'gvValoresExentos
        '
        Me.gvValoresExentos.GridControl = Me.gcValoresExentos
        Me.gvValoresExentos.Name = "gvValoresExentos"
        Me.gvValoresExentos.OptionsView.ShowGroupPanel = False
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
        Me.GroupControl2.Location = New System.Drawing.Point(808, 9)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(88, 561)
        Me.GroupControl2.TabIndex = 4
        Me.GroupControl2.Text = "Opciones"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLimpiar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnLimpiar.Appearance.Options.UseFont = True
        Me.btnLimpiar.Location = New System.Drawing.Point(7, 27)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(74, 30)
        Me.btnLimpiar.TabIndex = 4
        Me.btnLimpiar.Text = "Limpiar"
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(7, 65)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(74, 30)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "Salir"
        '
        'FrmAsig_ValExentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(904, 578)
        Me.Controls.Add(Me.gbxPrincipal)
        Me.Controls.Add(Me.GroupControl2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmAsig_ValExentos"
        Me.Text = "Agregar Valores Exentos"
        CType(Me.gbxPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxPrincipal.ResumeLayout(False)
        Me.gbxPrincipal.PerformLayout()
        CType(Me.grbVigente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcValoresExentos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvValoresExentos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbxPrincipal As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtValorExento As SamitCtlNet.SamitBusq
    Friend WithEvents txtContratos As SamitCtlNet.SamitBusq
    Friend WithEvents gcValoresExentos As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvValoresExentos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnLimpiar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAgregar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblVigente As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grbVigente As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents txtValor As SamitCtlNet.SamitTexto
End Class
