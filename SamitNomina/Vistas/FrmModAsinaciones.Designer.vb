<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModAsinaciones
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmModAsinaciones))
        Me.gbxPrincipal = New DevExpress.XtraEditors.GroupControl()
        Me.grbTipoMod = New DevExpress.XtraEditors.RadioGroup()
        Me.txtDependencia = New SamitCtlNet.SamitBusq()
        Me.grbTipoConversion = New DevExpress.XtraEditors.RadioGroup()
        Me.txtvalor = New SamitCtlNet.SamitTexto()
        Me.txtCargos = New SamitCtlNet.SamitBusq()
        Me.txtOficina = New SamitCtlNet.SamitBusq()
        Me.gcAsignaciones = New DevExpress.XtraGrid.GridControl()
        Me.gvAsignaciones = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.btnBuscar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnLimpiar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.gbxPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxPrincipal.SuspendLayout()
        CType(Me.grbTipoMod.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grbTipoConversion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcAsignaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvAsignaciones, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.gbxPrincipal.Controls.Add(Me.grbTipoMod)
        Me.gbxPrincipal.Controls.Add(Me.txtDependencia)
        Me.gbxPrincipal.Controls.Add(Me.grbTipoConversion)
        Me.gbxPrincipal.Controls.Add(Me.txtvalor)
        Me.gbxPrincipal.Controls.Add(Me.txtCargos)
        Me.gbxPrincipal.Controls.Add(Me.txtOficina)
        Me.gbxPrincipal.Controls.Add(Me.gcAsignaciones)
        Me.gbxPrincipal.Location = New System.Drawing.Point(8, 8)
        Me.gbxPrincipal.Name = "gbxPrincipal"
        Me.gbxPrincipal.Size = New System.Drawing.Size(554, 561)
        Me.gbxPrincipal.TabIndex = 1
        '
        'grbTipoMod
        '
        Me.grbTipoMod.EditValue = False
        Me.grbTipoMod.Location = New System.Drawing.Point(189, 27)
        Me.grbTipoMod.Name = "grbTipoMod"
        Me.grbTipoMod.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.grbTipoMod.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.grbTipoMod.Properties.Appearance.Options.UseBackColor = True
        Me.grbTipoMod.Properties.Appearance.Options.UseFont = True
        Me.grbTipoMod.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.grbTipoMod.Properties.Columns = 2
        Me.grbTipoMod.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.grbTipoMod.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "Por tercero"), New DevExpress.XtraEditors.Controls.RadioGroupItem(True, "Por cargo")})
        Me.grbTipoMod.Size = New System.Drawing.Size(190, 20)
        Me.grbTipoMod.TabIndex = 0
        '
        'txtDependencia
        '
        Me.txtDependencia.AlineacionTexto = SamitCtlNet.AlinearTexto.Centro
        Me.txtDependencia.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtDependencia.AltodelControl = 30
        Me.txtDependencia.AnchoLabel = 110
        Me.txtDependencia.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDependencia.AnchoTxt = 80
        Me.txtDependencia.AutoCargarDatos = True
        Me.txtDependencia.AutoSize = True
        Me.txtDependencia.BackColor = System.Drawing.Color.Transparent
        Me.txtDependencia.ColorFondo = System.Drawing.Color.Transparent
        Me.txtDependencia.CondicionValida = ""
        Me.txtDependencia.Conexion = SamitCtlNet.ConexionSAMIT.ConexModulo
        Me.txtDependencia.ConsultaSQL = Nothing
        Me.txtDependencia.EsObligatorio = False
        Me.txtDependencia.FormatoNumero = Nothing
        Me.txtDependencia.Location = New System.Drawing.Point(4, 84)
        Me.txtDependencia.MaximoAncho = 0
        Me.txtDependencia.MensajedeAyuda = Nothing
        Me.txtDependencia.Name = "txtDependencia"
        Me.txtDependencia.Size = New System.Drawing.Size(542, 30)
        Me.txtDependencia.SoloLectura = False
        Me.txtDependencia.SoloNumeros = True
        Me.txtDependencia.TabIndex = 2
        Me.txtDependencia.TextodelControl = ""
        Me.txtDependencia.TextoLabel = "Dependencia :"
        Me.txtDependencia.TieneErrorControl = False
        Me.txtDependencia.TipoBusqueda = SamitCtlNet.ModGeneral.TipoBusqueda.Ninguna
        Me.txtDependencia.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtDependencia.TipodeLetra = New System.Drawing.Font("Arial", 9.0!)
        Me.txtDependencia.ValordelControl = ""
        Me.txtDependencia.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDependencia.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDependencia.ValorPredeterminado = Nothing
        '
        'grbTipoConversion
        '
        Me.grbTipoConversion.EditValue = False
        Me.grbTipoConversion.Location = New System.Drawing.Point(248, 153)
        Me.grbTipoConversion.Name = "grbTipoConversion"
        Me.grbTipoConversion.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.grbTipoConversion.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.grbTipoConversion.Properties.Appearance.Options.UseBackColor = True
        Me.grbTipoConversion.Properties.Appearance.Options.UseFont = True
        Me.grbTipoConversion.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.grbTipoConversion.Properties.Columns = 2
        Me.grbTipoConversion.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.grbTipoConversion.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "Valor"), New DevExpress.XtraEditors.Controls.RadioGroupItem(True, "Porcentaje")})
        Me.grbTipoConversion.Size = New System.Drawing.Size(166, 20)
        Me.grbTipoConversion.TabIndex = 5
        '
        'txtvalor
        '
        Me.txtvalor.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtvalor.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtvalor.AltodelControl = 30
        Me.txtvalor.AnchoLabel = 110
        Me.txtvalor.AutoSize = True
        Me.txtvalor.BackColor = System.Drawing.Color.Transparent
        Me.txtvalor.ColordeFondo = System.Drawing.Color.Transparent
        Me.txtvalor.EsObligatorio = False
        Me.txtvalor.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtvalor.FormatoNumero = Nothing
        Me.txtvalor.Location = New System.Drawing.Point(4, 150)
        Me.txtvalor.MaximoAncho = 0
        Me.txtvalor.MensajedeAyuda = "Asignación. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
        Me.txtvalor.Name = "txtvalor"
        Me.txtvalor.Size = New System.Drawing.Size(227, 30)
        Me.txtvalor.SoloLectura = False
        Me.txtvalor.SoloNumeros = False
        Me.txtvalor.TabIndex = 4
        Me.txtvalor.TextodelControl = ""
        Me.txtvalor.TextoLabel = "Valor :"
        Me.txtvalor.TieneErrorControl = False
        Me.txtvalor.TipodeDatos = SamitCtlNet.TipodeDato.NumerosCon_2_Decimales
        Me.txtvalor.TipodeLetra = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtvalor.ValordelControl = Nothing
        Me.txtvalor.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtvalor.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtvalor.ValorPredeterminado = Nothing
        '
        'txtCargos
        '
        Me.txtCargos.AlineacionTexto = SamitCtlNet.AlinearTexto.Centro
        Me.txtCargos.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtCargos.AltodelControl = 30
        Me.txtCargos.AnchoLabel = 110
        Me.txtCargos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCargos.AnchoTxt = 80
        Me.txtCargos.AutoCargarDatos = True
        Me.txtCargos.AutoSize = True
        Me.txtCargos.BackColor = System.Drawing.Color.Transparent
        Me.txtCargos.ColorFondo = System.Drawing.Color.Transparent
        Me.txtCargos.CondicionValida = ""
        Me.txtCargos.Conexion = SamitCtlNet.ConexionSAMIT.ConexModulo
        Me.txtCargos.ConsultaSQL = Nothing
        Me.txtCargos.EsObligatorio = False
        Me.txtCargos.FormatoNumero = Nothing
        Me.txtCargos.Location = New System.Drawing.Point(5, 117)
        Me.txtCargos.MaximoAncho = 0
        Me.txtCargos.MensajedeAyuda = Nothing
        Me.txtCargos.Name = "txtCargos"
        Me.txtCargos.Size = New System.Drawing.Size(541, 30)
        Me.txtCargos.SoloLectura = False
        Me.txtCargos.SoloNumeros = False
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
        'txtOficina
        '
        Me.txtOficina.AlineacionTexto = SamitCtlNet.AlinearTexto.Centro
        Me.txtOficina.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtOficina.AltodelControl = 30
        Me.txtOficina.AnchoLabel = 110
        Me.txtOficina.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOficina.AnchoTxt = 80
        Me.txtOficina.AutoCargarDatos = True
        Me.txtOficina.AutoSize = True
        Me.txtOficina.BackColor = System.Drawing.Color.Transparent
        Me.txtOficina.ColorFondo = System.Drawing.Color.Transparent
        Me.txtOficina.CondicionValida = ""
        Me.txtOficina.Conexion = SamitCtlNet.ConexionSAMIT.ConexModulo
        Me.txtOficina.ConsultaSQL = Nothing
        Me.txtOficina.EsObligatorio = False
        Me.txtOficina.FormatoNumero = Nothing
        Me.txtOficina.Location = New System.Drawing.Point(5, 52)
        Me.txtOficina.MaximoAncho = 0
        Me.txtOficina.MensajedeAyuda = Nothing
        Me.txtOficina.Name = "txtOficina"
        Me.txtOficina.Size = New System.Drawing.Size(541, 30)
        Me.txtOficina.SoloLectura = False
        Me.txtOficina.SoloNumeros = True
        Me.txtOficina.TabIndex = 1
        Me.txtOficina.TextodelControl = ""
        Me.txtOficina.TextoLabel = "Oficinas :"
        Me.txtOficina.TieneErrorControl = False
        Me.txtOficina.TipoBusqueda = SamitCtlNet.ModGeneral.TipoBusqueda.Ninguna
        Me.txtOficina.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtOficina.TipodeLetra = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOficina.ValordelControl = ""
        Me.txtOficina.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtOficina.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtOficina.ValorPredeterminado = Nothing
        '
        'gcAsignaciones
        '
        Me.gcAsignaciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcAsignaciones.Location = New System.Drawing.Point(0, 198)
        Me.gcAsignaciones.MainView = Me.gvAsignaciones
        Me.gcAsignaciones.Name = "gcAsignaciones"
        Me.gcAsignaciones.Size = New System.Drawing.Size(554, 363)
        Me.gcAsignaciones.TabIndex = 0
        Me.gcAsignaciones.TabStop = False
        Me.gcAsignaciones.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvAsignaciones})
        '
        'gvAsignaciones
        '
        Me.gvAsignaciones.GridControl = Me.gcAsignaciones
        Me.gvAsignaciones.Name = "gvAsignaciones"
        Me.gvAsignaciones.OptionsView.ShowGroupPanel = False
        '
        'GroupControl2
        '
        Me.GroupControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.GroupControl2.CaptionImagePadding = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.GroupControl2.Controls.Add(Me.btnBuscar)
        Me.GroupControl2.Controls.Add(Me.btnLimpiar)
        Me.GroupControl2.Controls.Add(Me.btnSalir)
        Me.GroupControl2.Controls.Add(Me.btnGuardar)
        Me.GroupControl2.Location = New System.Drawing.Point(568, 9)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(88, 561)
        Me.GroupControl2.TabIndex = 2
        Me.GroupControl2.Text = "Opciones"
        '
        'btnBuscar
        '
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Location = New System.Drawing.Point(7, 26)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(74, 39)
        Me.btnBuscar.TabIndex = 1
        Me.btnBuscar.Text = "Buscar"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.AllowFocus = False
        Me.btnLimpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLimpiar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnLimpiar.Appearance.Options.UseFont = True
        Me.btnLimpiar.Location = New System.Drawing.Point(7, 116)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(74, 30)
        Me.btnLimpiar.TabIndex = 3
        Me.btnLimpiar.Text = "Limpiar"
        '
        'btnSalir
        '
        Me.btnSalir.AllowFocus = False
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(7, 154)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(74, 30)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "Salir"
        '
        'btnGuardar
        '
        Me.btnGuardar.AllowFocus = False
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Location = New System.Drawing.Point(7, 71)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(74, 38)
        Me.btnGuardar.TabIndex = 2
        Me.btnGuardar.Text = "Guardar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Timer1
        '
        '
        'FrmModAsinaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(664, 578)
        Me.Controls.Add(Me.gbxPrincipal)
        Me.Controls.Add(Me.GroupControl2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmModAsinaciones"
        Me.Text = "Mod Asignaciones Salariales"
        CType(Me.gbxPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxPrincipal.ResumeLayout(False)
        Me.gbxPrincipal.PerformLayout()
        CType(Me.grbTipoMod.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grbTipoConversion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcAsignaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvAsignaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbxPrincipal As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtCargos As SamitCtlNet.SamitBusq
    Friend WithEvents txtOficina As SamitCtlNet.SamitBusq
    Friend WithEvents gcAsignaciones As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvAsignaciones As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnLimpiar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents grbTipoConversion As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents txtvalor As SamitCtlNet.SamitTexto
    Friend WithEvents txtDependencia As SamitCtlNet.SamitBusq
    Friend WithEvents grbTipoMod As DevExpress.XtraEditors.RadioGroup
End Class
