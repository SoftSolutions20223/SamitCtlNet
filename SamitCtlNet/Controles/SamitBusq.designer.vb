Option Explicit On
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Collections.Generic
Imports System.Drawing
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.Utils
Imports DevExpress.XtraEditors.DXErrorProvider

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SamitBusq
    Inherits System.Windows.Forms.UserControl
    'UserControl1 reemplaza a Dispose para limpiar la lista de componentes.
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
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SamitBusq))
        Dim ColumnDefinition1 As DevExpress.XtraLayout.ColumnDefinition = New DevExpress.XtraLayout.ColumnDefinition()
        Dim ColumnDefinition2 As DevExpress.XtraLayout.ColumnDefinition = New DevExpress.XtraLayout.ColumnDefinition()
        Dim ColumnDefinition3 As DevExpress.XtraLayout.ColumnDefinition = New DevExpress.XtraLayout.ColumnDefinition()
        Dim ColumnDefinition4 As DevExpress.XtraLayout.ColumnDefinition = New DevExpress.XtraLayout.ColumnDefinition()
        Dim RowDefinition1 As DevExpress.XtraLayout.RowDefinition = New DevExpress.XtraLayout.RowDefinition()
        Me.Texto = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.Titulo = New System.Windows.Forms.Label()
        Me.Descripcion = New System.Windows.Forms.Label()
        Me.Boton = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.GrpBoton = New DevExpress.XtraLayout.LayoutControlItem()
        Me.GrpTexto = New DevExpress.XtraLayout.LayoutControlItem()
        Me.GrpDescripcion = New DevExpress.XtraLayout.LayoutControlItem()
        Me.GrpLabel = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.Texto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrpBoton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrpTexto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrpDescripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrpLabel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Texto
        '
        Me.Texto.EditValue = ""
        Me.Texto.EnterMoveNextControl = True
        Me.Texto.Location = New System.Drawing.Point(135, 3)
        Me.Texto.Name = "Texto"
        Me.Texto.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Texto.Properties.Appearance.Options.UseFont = True
        Me.Texto.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Texto.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.Texto.Properties.AppearanceFocused.BackColor = System.Drawing.Color.Aqua
        Me.Texto.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Texto.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Black
        Me.Texto.Properties.AppearanceFocused.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Texto.Properties.AppearanceFocused.FontStyleDelta = System.Drawing.FontStyle.Bold
        Me.Texto.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Maroon
        Me.Texto.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.Texto.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.Texto.Properties.AppearanceFocused.Options.UseFont = True
        Me.Texto.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.Texto.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Texto.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.Texto.Size = New System.Drawing.Size(128, 22)
        Me.Texto.StyleController = Me.LayoutControl1
        ToolTipTitleItem1.Text = "SAMIT SQL"
        SuperToolTip1.Items.Add(ToolTipTitleItem1)
        Me.Texto.SuperTip = SuperToolTip1
        Me.Texto.TabIndex = 0
        '
        'LayoutControl1
        '
        Me.LayoutControl1.BackColor = System.Drawing.Color.Transparent
        Me.LayoutControl1.Controls.Add(Me.Titulo)
        Me.LayoutControl1.Controls.Add(Me.Descripcion)
        Me.LayoutControl1.Controls.Add(Me.Boton)
        Me.LayoutControl1.Controls.Add(Me.Texto)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(219, 248, 714, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(530, 28)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'Titulo
        '
        Me.Titulo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Titulo.Location = New System.Drawing.Point(3, 3)
        Me.Titulo.Name = "Titulo"
        Me.Titulo.Size = New System.Drawing.Size(128, 22)
        Me.Titulo.TabIndex = 6
        Me.Titulo.Text = "Titulo del Control :"
        Me.Titulo.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Descripcion
        '
        Me.Descripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Descripcion.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Descripcion.Location = New System.Drawing.Point(297, 3)
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.Size = New System.Drawing.Size(230, 22)
        Me.Descripcion.TabIndex = 5
        '
        'Boton
        '
        Me.Boton.Image = CType(resources.GetObject("Boton.Image"), System.Drawing.Image)
        Me.Boton.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.Boton.Location = New System.Drawing.Point(267, 3)
        Me.Boton.Name = "Boton"
        Me.Boton.Size = New System.Drawing.Size(26, 22)
        Me.Boton.StyleController = Me.LayoutControl1
        Me.Boton.TabIndex = 4
        Me.Boton.TabStop = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.GrpBoton, Me.GrpTexto, Me.GrpDescripcion, Me.GrpLabel})
        Me.LayoutControlGroup1.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        ColumnDefinition1.SizeType = System.Windows.Forms.SizeType.AutoSize
        ColumnDefinition1.Width = 132.0R
        ColumnDefinition2.SizeType = System.Windows.Forms.SizeType.AutoSize
        ColumnDefinition2.Width = 132.0R
        ColumnDefinition3.SizeType = System.Windows.Forms.SizeType.Absolute
        ColumnDefinition3.Width = 30.0R
        ColumnDefinition4.SizeType = System.Windows.Forms.SizeType.AutoSize
        ColumnDefinition4.Width = 234.0R
        Me.LayoutControlGroup1.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(New DevExpress.XtraLayout.ColumnDefinition() {ColumnDefinition1, ColumnDefinition2, ColumnDefinition3, ColumnDefinition4})
        RowDefinition1.Height = 100.0R
        RowDefinition1.SizeType = System.Windows.Forms.SizeType.Percent
        Me.LayoutControlGroup1.OptionsTableLayoutGroup.RowDefinitions.AddRange(New DevExpress.XtraLayout.RowDefinition() {RowDefinition1})
        Me.LayoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1)
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(530, 28)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'GrpBoton
        '
        Me.GrpBoton.Control = Me.Boton
        Me.GrpBoton.Location = New System.Drawing.Point(264, 0)
        Me.GrpBoton.Name = "GrpBoton"
        Me.GrpBoton.OptionsTableLayoutItem.ColumnIndex = 2
        Me.GrpBoton.Size = New System.Drawing.Size(30, 26)
        Me.GrpBoton.TextSize = New System.Drawing.Size(0, 0)
        Me.GrpBoton.TextVisible = False
        '
        'GrpTexto
        '
        Me.GrpTexto.Control = Me.Texto
        Me.GrpTexto.Location = New System.Drawing.Point(132, 0)
        Me.GrpTexto.Name = "GrpTexto"
        Me.GrpTexto.OptionsTableLayoutItem.ColumnIndex = 1
        Me.GrpTexto.Size = New System.Drawing.Size(132, 26)
        Me.GrpTexto.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.SupportHorzAlignment
        Me.GrpTexto.TextSize = New System.Drawing.Size(0, 0)
        Me.GrpTexto.TextVisible = False
        '
        'GrpDescripcion
        '
        Me.GrpDescripcion.Control = Me.Descripcion
        Me.GrpDescripcion.Location = New System.Drawing.Point(294, 0)
        Me.GrpDescripcion.MinSize = New System.Drawing.Size(24, 24)
        Me.GrpDescripcion.Name = "GrpDescripcion"
        Me.GrpDescripcion.OptionsTableLayoutItem.ColumnIndex = 3
        Me.GrpDescripcion.Size = New System.Drawing.Size(234, 26)
        Me.GrpDescripcion.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.GrpDescripcion.TextSize = New System.Drawing.Size(0, 0)
        Me.GrpDescripcion.TextVisible = False
        '
        'GrpLabel
        '
        Me.GrpLabel.Control = Me.Titulo
        Me.GrpLabel.Location = New System.Drawing.Point(0, 0)
        Me.GrpLabel.Name = "GrpLabel"
        Me.GrpLabel.Size = New System.Drawing.Size(132, 26)
        Me.GrpLabel.TextSize = New System.Drawing.Size(0, 0)
        Me.GrpLabel.TextVisible = False
        '
        'SamitBusq
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "SamitBusq"
        Me.Size = New System.Drawing.Size(530, 28)
        CType(Me.Texto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrpBoton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrpTexto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrpDescripcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrpLabel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Descripcion As System.Windows.Forms.Label
    Friend WithEvents Boton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents GrpTexto As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GrpBoton As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GrpDescripcion As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Titulo As System.Windows.Forms.Label
    Friend WithEvents GrpLabel As DevExpress.XtraLayout.LayoutControlItem
End Class
