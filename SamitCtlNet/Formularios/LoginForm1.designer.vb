<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class LoginForm1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents LblUsuario As System.Windows.Forms.Label
    Friend WithEvents LblPassword As System.Windows.Forms.Label
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm1))
        Me.LblUsuario = New System.Windows.Forms.Label()
        Me.LblPassword = New System.Windows.Forms.Label()
        Me.OK = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtUsuario = New DevExpress.XtraEditors.TextEdit()
        Me.TxtContraseña = New DevExpress.XtraEditors.TextEdit()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.BotonSrv = New DevExpress.XtraEditors.ButtonEdit()
        CType(Me.TxtUsuario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtContraseña.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BotonSrv.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblUsuario
        '
        Me.LblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsuario.Location = New System.Drawing.Point(2, 61)
        Me.LblUsuario.Name = "LblUsuario"
        Me.LblUsuario.Size = New System.Drawing.Size(142, 22)
        Me.LblUsuario.TabIndex = 0
        Me.LblUsuario.Text = "&Usuario : "
        Me.LblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblPassword
        '
        Me.LblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPassword.Location = New System.Drawing.Point(6, 99)
        Me.LblPassword.Name = "LblPassword"
        Me.LblPassword.Size = New System.Drawing.Size(139, 22)
        Me.LblPassword.TabIndex = 2
        Me.LblPassword.Text = "&Contraseña : "
        Me.LblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'OK
        '
        Me.OK.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK.Location = New System.Drawing.Point(86, 159)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(140, 40)
        Me.OK.TabIndex = 1
        Me.OK.Text = "&Aceptar"
        Me.OK.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Cancel
        '
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.Location = New System.Drawing.Point(251, 159)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(140, 40)
        Me.Cancel.TabIndex = 2
        Me.Cancel.Text = "&Cancelar"
        Me.Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 23)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "&Servidor : "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtUsuario
        '
        Me.TxtUsuario.Location = New System.Drawing.Point(152, 61)
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.TxtUsuario.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUsuario.Properties.Appearance.Options.UseFont = True
        Me.TxtUsuario.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TxtUsuario.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtUsuario.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.TxtUsuario.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.TxtUsuario.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtUsuario.Properties.AppearanceFocused.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtUsuario.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUsuario.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TxtUsuario.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.TxtUsuario.Properties.AppearanceFocused.Options.UseFont = True
        Me.TxtUsuario.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.TxtUsuario.Properties.HideSelection = False
        Me.TxtUsuario.Properties.ValidateOnEnterKey = True
        Me.TxtUsuario.Size = New System.Drawing.Size(161, 24)
        Me.TxtUsuario.TabIndex = 4
        '
        'TxtContraseña
        '
        Me.TxtContraseña.Location = New System.Drawing.Point(152, 99)
        Me.TxtContraseña.Name = "TxtContraseña"
        Me.TxtContraseña.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.TxtContraseña.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtContraseña.Properties.Appearance.Options.UseFont = True
        Me.TxtContraseña.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TxtContraseña.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtContraseña.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.TxtContraseña.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.TxtContraseña.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtContraseña.Properties.AppearanceFocused.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtContraseña.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtContraseña.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TxtContraseña.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.TxtContraseña.Properties.AppearanceFocused.Options.UseFont = True
        Me.TxtContraseña.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.TxtContraseña.Properties.HideSelection = False
        Me.TxtContraseña.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtContraseña.Properties.ValidateOnEnterKey = True
        Me.TxtContraseña.Size = New System.Drawing.Size(161, 24)
        Me.TxtContraseña.TabIndex = 0
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.BackColor = System.Drawing.Color.Transparent
        Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
        Me.LogoPictureBox.InitialImage = CType(resources.GetObject("LogoPictureBox.InitialImage"), System.Drawing.Image)
        Me.LogoPictureBox.Location = New System.Drawing.Point(336, 51)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(114, 88)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoPictureBox.TabIndex = 0
        Me.LogoPictureBox.TabStop = False
        '
        'BotonSrv
        '
        Me.BotonSrv.Location = New System.Drawing.Point(152, 16)
        Me.BotonSrv.Name = "BotonSrv"
        Me.BotonSrv.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BotonSrv.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonSrv.Properties.Appearance.ForeColor = System.Drawing.Color.Maroon
        Me.BotonSrv.Properties.Appearance.Options.UseBackColor = True
        Me.BotonSrv.Properties.Appearance.Options.UseFont = True
        Me.BotonSrv.Properties.Appearance.Options.UseForeColor = True
        Me.BotonSrv.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.BotonSrv.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.BotonSrv.Size = New System.Drawing.Size(299, 26)
        Me.BotonSrv.TabIndex = 3
        Me.BotonSrv.ToolTip = "Digite el Servidor o Selecciones Uno"
        Me.BotonSrv.ToolTipTitle = "Ayuda en Linea SAMIT SQL"
        '
        'LoginForm1
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(475, 214)
        Me.Controls.Add(Me.BotonSrv)
        Me.Controls.Add(Me.TxtContraseña)
        Me.Controls.Add(Me.TxtUsuario)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.LblPassword)
        Me.Controls.Add(Me.LblUsuario)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LoginForm1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Conexion SAMIT SQL "
        Me.TopMost = True
        CType(Me.TxtUsuario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtContraseña.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BotonSrv.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtUsuario As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtContraseña As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BotonSrv As DevExpress.XtraEditors.ButtonEdit

End Class
