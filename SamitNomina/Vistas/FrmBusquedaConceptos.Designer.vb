<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBusquedaConceptos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBusquedaConceptos))
        Me.txtNomina = New SamitCtlNet.SamitBusq()
        Me.txtConcepto = New SamitCtlNet.SamitBusq()
        Me.SeparatorControl6 = New DevExpress.XtraEditors.SeparatorControl()
        Me.btnAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.SeparatorControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNomina
        '
        Me.txtNomina.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtNomina.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtNomina.AltodelControl = 30
        Me.txtNomina.AnchoLabel = 100
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
        Me.txtNomina.Location = New System.Drawing.Point(1, 10)
        Me.txtNomina.MaximoAncho = 0
        Me.txtNomina.MensajedeAyuda = ""
        Me.txtNomina.Name = "txtNomina"
        Me.txtNomina.Size = New System.Drawing.Size(478, 30)
        Me.txtNomina.SoloLectura = False
        Me.txtNomina.SoloNumeros = False
        Me.txtNomina.TabIndex = 1
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
        'txtConcepto
        '
        Me.txtConcepto.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtConcepto.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtConcepto.AltodelControl = 30
        Me.txtConcepto.AnchoLabel = 100
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
        Me.txtConcepto.Location = New System.Drawing.Point(1, 40)
        Me.txtConcepto.MaximoAncho = 0
        Me.txtConcepto.MensajedeAyuda = ""
        Me.txtConcepto.Name = "txtConcepto"
        Me.txtConcepto.Size = New System.Drawing.Size(478, 30)
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
        'SeparatorControl6
        '
        Me.SeparatorControl6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SeparatorControl6.Location = New System.Drawing.Point(17, 77)
        Me.SeparatorControl6.Name = "SeparatorControl6"
        Me.SeparatorControl6.Padding = New System.Windows.Forms.Padding(0)
        Me.SeparatorControl6.Size = New System.Drawing.Size(450, 3)
        Me.SeparatorControl6.TabIndex = 100
        Me.SeparatorControl6.TabStop = False
        '
        'btnAceptar
        '
        Me.btnAceptar.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnAceptar.Appearance.Options.UseFont = True
        Me.btnAceptar.Location = New System.Drawing.Point(248, 85)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(90, 30)
        Me.btnAceptar.TabIndex = 3
        Me.btnAceptar.Text = "Aceptar"
        '
        'btnCancelar
        '
        Me.btnCancelar.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnCancelar.Appearance.Options.UseFont = True
        Me.btnCancelar.Location = New System.Drawing.Point(143, 85)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(90, 30)
        Me.btnCancelar.TabIndex = 4
        Me.btnCancelar.Text = "Cancelar"
        '
        'FrmBusquedaConceptos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 124)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.SeparatorControl6)
        Me.Controls.Add(Me.txtNomina)
        Me.Controls.Add(Me.txtConcepto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmBusquedaConceptos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Concepto"
        CType(Me.SeparatorControl6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNomina As SamitCtlNet.SamitBusq
    Friend WithEvents txtConcepto As SamitCtlNet.SamitBusq
    Friend WithEvents SeparatorControl6 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents btnAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
End Class
