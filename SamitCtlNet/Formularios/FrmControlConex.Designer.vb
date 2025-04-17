<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmControlConex
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmControlConex))
        Me.Smt_Imagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.SuspendLayout()
        '
        'Smt_Imagenes
        '
        Me.Smt_Imagenes.ImageStream = CType(resources.GetObject("Smt_Imagenes.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.Smt_Imagenes.TransparentColor = System.Drawing.Color.Transparent
        Me.Smt_Imagenes.Images.SetKeyName(0, "connect.png")
        Me.Smt_Imagenes.Images.SetKeyName(1, "disconnect.png")
        Me.Smt_Imagenes.Images.SetKeyName(2, "YES01A.ICO")
        Me.Smt_Imagenes.Images.SetKeyName(3, "NO01E.ICO")
        Me.Smt_Imagenes.Images.SetKeyName(4, "server_key.png")
        Me.Smt_Imagenes.Images.SetKeyName(5, "Smt_Salir.jpg")
        Me.Smt_Imagenes.Images.SetKeyName(6, "SamitIcono16x16.ico")
        Me.Smt_Imagenes.Images.SetKeyName(7, "SamitIcono32x32.ico")
        Me.Smt_Imagenes.Images.SetKeyName(8, "money_bag.png")
        '
        'FrmControlConex
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Name = "FrmControlConex"
        Me.Text = "FrmControlConex"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Smt_Imagenes As System.Windows.Forms.ImageList
End Class
