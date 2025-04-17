<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmImpresion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmImpresion))
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Me.lvimpresoras = New System.Windows.Forms.ListView()
        Me.img_printers = New System.Windows.Forms.ImageList(Me.components)
        Me.lvpapeles = New System.Windows.Forms.ListView()
        Me.img_paper = New System.Windows.Forms.ImageList(Me.components)
        Me.btncancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnver = New DevExpress.XtraEditors.SimpleButton()
        Me.btnimprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.lvorientacion = New System.Windows.Forms.ListView()
        Me.img_fit = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lvimpresoras
        '
        Me.lvimpresoras.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lvimpresoras.AutoArrange = False
        Me.lvimpresoras.GridLines = True
        Me.lvimpresoras.LargeImageList = Me.img_printers
        Me.lvimpresoras.Location = New System.Drawing.Point(12, 25)
        Me.lvimpresoras.Name = "lvimpresoras"
        Me.lvimpresoras.Size = New System.Drawing.Size(134, 311)
        Me.lvimpresoras.TabIndex = 0
        Me.lvimpresoras.UseCompatibleStateImageBehavior = False
        '
        'img_printers
        '
        Me.img_printers.ImageStream = CType(resources.GetObject("img_printers.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.img_printers.TransparentColor = System.Drawing.Color.Transparent
        Me.img_printers.Images.SetKeyName(0, "printer.png")
        Me.img_printers.Images.SetKeyName(1, "printer_select.png")
        '
        'lvpapeles
        '
        Me.lvpapeles.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lvpapeles.AutoArrange = False
        Me.lvpapeles.GridLines = True
        Me.lvpapeles.LargeImageList = Me.img_paper
        Me.lvpapeles.Location = New System.Drawing.Point(152, 25)
        Me.lvpapeles.Name = "lvpapeles"
        Me.lvpapeles.Size = New System.Drawing.Size(100, 311)
        Me.lvpapeles.TabIndex = 1
        Me.lvpapeles.UseCompatibleStateImageBehavior = False
        '
        'img_paper
        '
        Me.img_paper.ImageStream = CType(resources.GetObject("img_paper.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.img_paper.TransparentColor = System.Drawing.Color.Transparent
        Me.img_paper.Images.SetKeyName(0, "page_white_legal.png")
        Me.img_paper.Images.SetKeyName(1, "page_white_text.png")
        Me.img_paper.Images.SetKeyName(2, "page_white_text_width.png")
        '
        'btncancelar
        '
        Me.btncancelar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btncancelar.Appearance.Options.UseTextOptions = True
        Me.btncancelar.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.btncancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btncancelar.Image = CType(resources.GetObject("btncancelar.Image"), System.Drawing.Image)
        Me.btncancelar.Location = New System.Drawing.Point(364, 139)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(104, 60)
        ToolTipTitleItem1.Text = "Cancelar Impresion"
        ToolTipItem1.Appearance.Options.UseImage = True
        ToolTipItem1.LeftIndent = 6
        ToolTipItem1.Text = "Cierra este dialogo de impresion."
        SuperToolTip1.Items.Add(ToolTipTitleItem1)
        SuperToolTip1.Items.Add(ToolTipItem1)
        Me.btncancelar.SuperTip = SuperToolTip1
        Me.btncancelar.TabIndex = 2
        Me.btncancelar.Text = "Cancelar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Impresion" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(ESC)"
        '
        'btnver
        '
        Me.btnver.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnver.Appearance.Options.UseTextOptions = True
        Me.btnver.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.btnver.Image = CType(resources.GetObject("btnver.Image"), System.Drawing.Image)
        Me.btnver.Location = New System.Drawing.Point(364, 73)
        Me.btnver.Name = "btnver"
        Me.btnver.Size = New System.Drawing.Size(104, 60)
        Me.btnver.TabIndex = 3
        Me.btnver.Text = "Vista Previa" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(F5)"
        '
        'btnimprimir
        '
        Me.btnimprimir.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnimprimir.Appearance.Options.UseTextOptions = True
        Me.btnimprimir.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.btnimprimir.Image = CType(resources.GetObject("btnimprimir.Image"), System.Drawing.Image)
        Me.btnimprimir.Location = New System.Drawing.Point(364, 7)
        Me.btnimprimir.Name = "btnimprimir"
        Me.btnimprimir.Size = New System.Drawing.Size(104, 60)
        Me.btnimprimir.TabIndex = 4
        Me.btnimprimir.Text = "Imprimir" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(F4)"
        '
        'lvorientacion
        '
        Me.lvorientacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lvorientacion.AutoArrange = False
        Me.lvorientacion.GridLines = True
        Me.lvorientacion.LargeImageList = Me.img_fit
        Me.lvorientacion.Location = New System.Drawing.Point(258, 25)
        Me.lvorientacion.Name = "lvorientacion"
        Me.lvorientacion.Size = New System.Drawing.Size(100, 174)
        Me.lvorientacion.TabIndex = 5
        Me.lvorientacion.UseCompatibleStateImageBehavior = False
        '
        'img_fit
        '
        Me.img_fit.ImageStream = CType(resources.GetObject("img_fit.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.img_fit.TransparentColor = System.Drawing.Color.Transparent
        Me.img_fit.Images.SetKeyName(0, "document_image_hor.png")
        Me.img_fit.Images.SetKeyName(1, "document_image_ver.png")
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox1.Location = New System.Drawing.Point(258, 210)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(210, 131)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opciones"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cantidad de copias:"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(6, 43)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(198, 20)
        Me.NumericUpDown1.TabIndex = 0
        Me.NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Impresoras:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(149, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Tamaño Papel:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(255, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Orientacion:"
        '
        'FrmImpresion
        '
        Me.AcceptButton = Me.btnimprimir
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btncancelar
        Me.ClientSize = New System.Drawing.Size(480, 348)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lvorientacion)
        Me.Controls.Add(Me.btnimprimir)
        Me.Controls.Add(Me.btnver)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.lvpapeles)
        Me.Controls.Add(Me.lvimpresoras)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(496, 387)
        Me.MinimizeBox = False
        Me.Name = "FrmImpresion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Imprimendo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lvimpresoras As System.Windows.Forms.ListView
    Friend WithEvents img_printers As System.Windows.Forms.ImageList
    Friend WithEvents lvpapeles As System.Windows.Forms.ListView
    Friend WithEvents img_paper As System.Windows.Forms.ImageList
    Friend WithEvents btncancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnver As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnimprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lvorientacion As System.Windows.Forms.ListView
    Friend WithEvents img_fit As System.Windows.Forms.ImageList
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
