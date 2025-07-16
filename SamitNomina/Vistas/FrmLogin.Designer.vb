<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnIniciarSesion = New System.Windows.Forms.Button()
        Me.txbUsuario = New System.Windows.Forms.TextBox()
        Me.txbClave = New System.Windows.Forms.TextBox()
        Me.lblUsuario = New DevExpress.XtraEditors.LabelControl()
        Me.lblContrasena = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.btnContinuar = New System.Windows.Forms.Button()
        Me.txtRoles = New SamitCtlNet.SamitBusq()
        Me.txtOficinas = New SamitCtlNet.SamitBusq()
        Me.txtEmpresas = New SamitCtlNet.SamitBusq()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnIniciarSesion
        '
        Me.btnIniciarSesion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnIniciarSesion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIniciarSesion.Location = New System.Drawing.Point(6, 130)
        Me.btnIniciarSesion.Margin = New System.Windows.Forms.Padding(4)
        Me.btnIniciarSesion.Name = "btnIniciarSesion"
        Me.btnIniciarSesion.Size = New System.Drawing.Size(717, 81)
        Me.btnIniciarSesion.TabIndex = 3
        Me.btnIniciarSesion.Text = "Iniciar Sesion"
        Me.btnIniciarSesion.UseVisualStyleBackColor = True
        '
        'txbUsuario
        '
        Me.txbUsuario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txbUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbUsuario.Location = New System.Drawing.Point(143, 46)
        Me.txbUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.txbUsuario.Name = "txbUsuario"
        Me.txbUsuario.Size = New System.Drawing.Size(581, 34)
        Me.txbUsuario.TabIndex = 1
        Me.txbUsuario.Text = "test"
        '
        'txbClave
        '
        Me.txbClave.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txbClave.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbClave.Location = New System.Drawing.Point(143, 89)
        Me.txbClave.Margin = New System.Windows.Forms.Padding(4)
        Me.txbClave.Name = "txbClave"
        Me.txbClave.Size = New System.Drawing.Size(582, 34)
        Me.txbClave.TabIndex = 2
        Me.txbClave.Text = "1234"
        Me.txbClave.UseSystemPasswordChar = True
        '
        'lblUsuario
        '
        Me.lblUsuario.Appearance.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.Appearance.Options.UseFont = True
        Me.lblUsuario.Appearance.Options.UseTextOptions = True
        Me.lblUsuario.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lblUsuario.Location = New System.Drawing.Point(46, 46)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(90, 28)
        Me.lblUsuario.TabIndex = 3
        Me.lblUsuario.Text = "Usuario :"
        '
        'lblContrasena
        '
        Me.lblContrasena.Appearance.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContrasena.Appearance.Options.UseFont = True
        Me.lblContrasena.Appearance.Options.UseTextOptions = True
        Me.lblContrasena.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.lblContrasena.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lblContrasena.Location = New System.Drawing.Point(7, 92)
        Me.lblContrasena.Name = "lblContrasena"
        Me.lblContrasena.Size = New System.Drawing.Size(129, 28)
        Me.lblContrasena.TabIndex = 4
        Me.lblContrasena.Text = "Contraseña :"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.txbClave)
        Me.PanelControl1.Controls.Add(Me.btnIniciarSesion)
        Me.PanelControl1.Controls.Add(Me.lblContrasena)
        Me.PanelControl1.Controls.Add(Me.txbUsuario)
        Me.PanelControl1.Controls.Add(Me.lblUsuario)
        Me.PanelControl1.Location = New System.Drawing.Point(8, 11)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(731, 218)
        Me.PanelControl1.TabIndex = 5
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseTextOptions = True
        Me.LabelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl1.Location = New System.Drawing.Point(309, 5)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(110, 28)
        Me.LabelControl1.TabIndex = 5
        Me.LabelControl1.Text = "Bienvenido"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.btnContinuar)
        Me.PanelControl2.Controls.Add(Me.txtRoles)
        Me.PanelControl2.Controls.Add(Me.txtOficinas)
        Me.PanelControl2.Controls.Add(Me.txtEmpresas)
        Me.PanelControl2.Location = New System.Drawing.Point(8, 9)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(731, 218)
        Me.PanelControl2.TabIndex = 7
        '
        'btnContinuar
        '
        Me.btnContinuar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnContinuar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContinuar.Location = New System.Drawing.Point(7, 131)
        Me.btnContinuar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnContinuar.Name = "btnContinuar"
        Me.btnContinuar.Size = New System.Drawing.Size(717, 81)
        Me.btnContinuar.TabIndex = 7
        Me.btnContinuar.Text = "Continuar"
        Me.btnContinuar.UseVisualStyleBackColor = True
        '
        'txtRoles
        '
        Me.txtRoles.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtRoles.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtRoles.AltodelControl = 30
        Me.txtRoles.AnchoLabel = 120
        Me.txtRoles.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRoles.AnchoTxt = 80
        Me.txtRoles.AutoCargarDatos = True
        Me.txtRoles.AutoSize = True
        Me.txtRoles.BackColor = System.Drawing.Color.Transparent
        Me.txtRoles.ColorFondo = System.Drawing.Color.Transparent
        Me.txtRoles.CondicionValida = ""
        Me.txtRoles.Conexion = SamitCtlNet.ConexionSAMIT.ConexModulo
        Me.txtRoles.ConsultaSQL = Nothing
        Me.txtRoles.DatosDefecto = Nothing
        Me.txtRoles.EsObligatorio = False
        Me.txtRoles.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtRoles.FormatoNumero = Nothing
        Me.txtRoles.ListaColumnas = Nothing
        Me.txtRoles.Location = New System.Drawing.Point(6, 91)
        Me.txtRoles.Margin = New System.Windows.Forms.Padding(5)
        Me.txtRoles.MaximoAncho = 0
        Me.txtRoles.MensajedeAyuda = ""
        Me.txtRoles.Name = "txtRoles"
        Me.txtRoles.Size = New System.Drawing.Size(716, 37)
        Me.txtRoles.SoloLectura = False
        Me.txtRoles.SoloNumeros = True
        Me.txtRoles.TabIndex = 6
        Me.txtRoles.TextodelControl = ""
        Me.txtRoles.TextoLabel = "Roles :"
        Me.txtRoles.TieneErrorControl = False
        Me.txtRoles.TipoBusqueda = SamitCtlNet.ModGeneral.TipoBusqueda.Ninguna
        Me.txtRoles.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtRoles.TipodeLetra = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtRoles.ValordelControl = ""
        Me.txtRoles.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtRoles.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtRoles.ValorPredeterminado = Nothing
        '
        'txtOficinas
        '
        Me.txtOficinas.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtOficinas.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtOficinas.AltodelControl = 30
        Me.txtOficinas.AnchoLabel = 120
        Me.txtOficinas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOficinas.AnchoTxt = 80
        Me.txtOficinas.AutoCargarDatos = True
        Me.txtOficinas.AutoSize = True
        Me.txtOficinas.BackColor = System.Drawing.Color.Transparent
        Me.txtOficinas.ColorFondo = System.Drawing.Color.Transparent
        Me.txtOficinas.CondicionValida = ""
        Me.txtOficinas.Conexion = SamitCtlNet.ConexionSAMIT.ConexModulo
        Me.txtOficinas.ConsultaSQL = Nothing
        Me.txtOficinas.DatosDefecto = Nothing
        Me.txtOficinas.EsObligatorio = False
        Me.txtOficinas.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtOficinas.FormatoNumero = Nothing
        Me.txtOficinas.ListaColumnas = Nothing
        Me.txtOficinas.Location = New System.Drawing.Point(7, 49)
        Me.txtOficinas.Margin = New System.Windows.Forms.Padding(5)
        Me.txtOficinas.MaximoAncho = 0
        Me.txtOficinas.MensajedeAyuda = ""
        Me.txtOficinas.Name = "txtOficinas"
        Me.txtOficinas.Size = New System.Drawing.Size(716, 37)
        Me.txtOficinas.SoloLectura = False
        Me.txtOficinas.SoloNumeros = True
        Me.txtOficinas.TabIndex = 5
        Me.txtOficinas.TextodelControl = ""
        Me.txtOficinas.TextoLabel = "Oficinas :"
        Me.txtOficinas.TieneErrorControl = False
        Me.txtOficinas.TipoBusqueda = SamitCtlNet.ModGeneral.TipoBusqueda.Ninguna
        Me.txtOficinas.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtOficinas.TipodeLetra = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtOficinas.ValordelControl = ""
        Me.txtOficinas.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtOficinas.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtOficinas.ValorPredeterminado = Nothing
        '
        'txtEmpresas
        '
        Me.txtEmpresas.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtEmpresas.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtEmpresas.AltodelControl = 30
        Me.txtEmpresas.AnchoLabel = 120
        Me.txtEmpresas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEmpresas.AnchoTxt = 80
        Me.txtEmpresas.AutoCargarDatos = True
        Me.txtEmpresas.AutoSize = True
        Me.txtEmpresas.BackColor = System.Drawing.Color.Transparent
        Me.txtEmpresas.ColorFondo = System.Drawing.Color.Transparent
        Me.txtEmpresas.CondicionValida = ""
        Me.txtEmpresas.Conexion = SamitCtlNet.ConexionSAMIT.ConexModulo
        Me.txtEmpresas.ConsultaSQL = Nothing
        Me.txtEmpresas.DatosDefecto = Nothing
        Me.txtEmpresas.EsObligatorio = False
        Me.txtEmpresas.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtEmpresas.FormatoNumero = Nothing
        Me.txtEmpresas.ListaColumnas = Nothing
        Me.txtEmpresas.Location = New System.Drawing.Point(7, 7)
        Me.txtEmpresas.Margin = New System.Windows.Forms.Padding(5)
        Me.txtEmpresas.MaximoAncho = 0
        Me.txtEmpresas.MensajedeAyuda = ""
        Me.txtEmpresas.Name = "txtEmpresas"
        Me.txtEmpresas.Size = New System.Drawing.Size(716, 37)
        Me.txtEmpresas.SoloLectura = False
        Me.txtEmpresas.SoloNumeros = True
        Me.txtEmpresas.TabIndex = 4
        Me.txtEmpresas.TextodelControl = ""
        Me.txtEmpresas.TextoLabel = "Empresas :"
        Me.txtEmpresas.TieneErrorControl = False
        Me.txtEmpresas.TipoBusqueda = SamitCtlNet.ModGeneral.TipoBusqueda.Ninguna
        Me.txtEmpresas.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtEmpresas.TipodeLetra = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtEmpresas.ValordelControl = ""
        Me.txtEmpresas.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtEmpresas.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtEmpresas.ValorPredeterminado = Nothing
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(746, 236)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximumSize = New System.Drawing.Size(764, 283)
        Me.Name = "FrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Iniciar Sesion"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnIniciarSesion As Button
    Friend WithEvents txbUsuario As TextBox
    Friend WithEvents txbClave As TextBox
    Friend WithEvents lblUsuario As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblContrasena As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnContinuar As Button
    Friend WithEvents txtRoles As SamitCtlNet.SamitBusq
    Friend WithEvents txtOficinas As SamitCtlNet.SamitBusq
    Friend WithEvents txtEmpresas As SamitCtlNet.SamitBusq
End Class
