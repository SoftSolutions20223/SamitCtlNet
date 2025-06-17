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
        Me.SuspendLayout()
        '
        'btnIniciarSesion
        '
        Me.btnIniciarSesion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnIniciarSesion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIniciarSesion.Location = New System.Drawing.Point(14, 100)
        Me.btnIniciarSesion.Margin = New System.Windows.Forms.Padding(4)
        Me.btnIniciarSesion.Name = "btnIniciarSesion"
        Me.btnIniciarSesion.Size = New System.Drawing.Size(614, 81)
        Me.btnIniciarSesion.TabIndex = 0
        Me.btnIniciarSesion.Text = "Iniciar Sesion"
        Me.btnIniciarSesion.UseVisualStyleBackColor = True
        '
        'txbUsuario
        '
        Me.txbUsuario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txbUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbUsuario.Location = New System.Drawing.Point(148, 15)
        Me.txbUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.txbUsuario.Name = "txbUsuario"
        Me.txbUsuario.Size = New System.Drawing.Size(479, 34)
        Me.txbUsuario.TabIndex = 1
        Me.txbUsuario.Text = "test"
        '
        'txbClave
        '
        Me.txbClave.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txbClave.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbClave.Location = New System.Drawing.Point(148, 58)
        Me.txbClave.Margin = New System.Windows.Forms.Padding(4)
        Me.txbClave.Name = "txbClave"
        Me.txbClave.Size = New System.Drawing.Size(480, 34)
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
        Me.lblUsuario.Location = New System.Drawing.Point(51, 15)
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
        Me.lblContrasena.Location = New System.Drawing.Point(12, 61)
        Me.lblContrasena.Name = "lblContrasena"
        Me.lblContrasena.Size = New System.Drawing.Size(129, 28)
        Me.lblContrasena.TabIndex = 4
        Me.lblContrasena.Text = "Contraseña :"
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(643, 193)
        Me.Controls.Add(Me.lblContrasena)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.txbClave)
        Me.Controls.Add(Me.txbUsuario)
        Me.Controls.Add(Me.btnIniciarSesion)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnIniciarSesion As Button
    Friend WithEvents txbUsuario As TextBox
    Friend WithEvents txbClave As TextBox
    Friend WithEvents lblUsuario As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblContrasena As DevExpress.XtraEditors.LabelControl
End Class
