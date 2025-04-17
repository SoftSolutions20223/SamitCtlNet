<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBuscaComp
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
        Me.GridComp = New System.Windows.Forms.DataGridView()
        Me.LblOficina = New System.Windows.Forms.Label()
        Me.TxtOficina = New System.Windows.Forms.TextBox()
        Me.LblDescOficina = New System.Windows.Forms.Label()
        Me.BtnEscoger = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        CType(Me.GridComp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridComp
        '
        Me.GridComp.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.GridComp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridComp.Location = New System.Drawing.Point(0, 28)
        Me.GridComp.Name = "GridComp"
        Me.GridComp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridComp.Size = New System.Drawing.Size(505, 232)
        Me.GridComp.TabIndex = 0
        '
        'LblOficina
        '
        Me.LblOficina.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblOficina.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LblOficina.Location = New System.Drawing.Point(-2, 4)
        Me.LblOficina.Name = "LblOficina"
        Me.LblOficina.Size = New System.Drawing.Size(81, 20)
        Me.LblOficina.TabIndex = 1
        Me.LblOficina.Text = "Oficina :"
        Me.LblOficina.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtOficina
        '
        Me.TxtOficina.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtOficina.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOficina.Location = New System.Drawing.Point(84, 4)
        Me.TxtOficina.Name = "TxtOficina"
        Me.TxtOficina.Size = New System.Drawing.Size(32, 22)
        Me.TxtOficina.TabIndex = 2
        Me.TxtOficina.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblDescOficina
        '
        Me.LblDescOficina.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblDescOficina.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDescOficina.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LblDescOficina.Location = New System.Drawing.Point(122, 4)
        Me.LblDescOficina.Name = "LblDescOficina"
        Me.LblDescOficina.Size = New System.Drawing.Size(383, 22)
        Me.LblDescOficina.TabIndex = 3
        Me.LblDescOficina.Text = "Oficina : "
        Me.LblDescOficina.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnEscoger
        '
        Me.BtnEscoger.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEscoger.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEscoger.Location = New System.Drawing.Point(265, 266)
        Me.BtnEscoger.Name = "BtnEscoger"
        Me.BtnEscoger.Size = New System.Drawing.Size(117, 41)
        Me.BtnEscoger.TabIndex = 4
        Me.BtnEscoger.Text = "&Escoger"
        Me.BtnEscoger.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEscoger.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSalir.Location = New System.Drawing.Point(388, 266)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(117, 41)
        Me.BtnSalir.TabIndex = 5
        Me.BtnSalir.Text = "&Salir"
        Me.BtnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'FrmBuscaComp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(506, 308)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnEscoger)
        Me.Controls.Add(Me.LblDescOficina)
        Me.Controls.Add(Me.TxtOficina)
        Me.Controls.Add(Me.LblOficina)
        Me.Controls.Add(Me.GridComp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FrmBuscaComp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de Comprobantes Parametrizados"
        CType(Me.GridComp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GridComp As System.Windows.Forms.DataGridView
    Friend WithEvents LblOficina As System.Windows.Forms.Label
    Friend WithEvents TxtOficina As System.Windows.Forms.TextBox
    Friend WithEvents LblDescOficina As System.Windows.Forms.Label
    Friend WithEvents BtnEscoger As System.Windows.Forms.Button
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
End Class
