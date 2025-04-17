<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRolEmpresa
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
        Me.TxtEmpresa = New DevExpress.XtraEditors.TextEdit()
        Me.LblEmpresa = New System.Windows.Forms.Label()
        Me.LblOficina = New System.Windows.Forms.Label()
        Me.TxtOficina = New DevExpress.XtraEditors.TextEdit()
        Me.DescEmpresa = New System.Windows.Forms.Label()
        Me.DescOficina = New System.Windows.Forms.Label()
        Me.GridRol = New DevExpress.XtraGrid.GridControl()
        Me.Gvrol = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Cancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.Aceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.FechaIngeso = New DevExpress.XtraEditors.DateEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.TxtEmpresa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtOficina.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridRol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gvrol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FechaIngeso.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FechaIngeso.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtEmpresa
        '
        Me.TxtEmpresa.EditValue = ""
        Me.TxtEmpresa.EnterMoveNextControl = True
        Me.TxtEmpresa.Location = New System.Drawing.Point(93, 6)
        Me.TxtEmpresa.Name = "TxtEmpresa"
        Me.TxtEmpresa.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEmpresa.Properties.Appearance.Options.UseFont = True
        Me.TxtEmpresa.Properties.Appearance.Options.UseTextOptions = True
        Me.TxtEmpresa.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TxtEmpresa.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtEmpresa.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Black
        Me.TxtEmpresa.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEmpresa.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TxtEmpresa.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.TxtEmpresa.Properties.AppearanceFocused.Options.UseFont = True
        Me.TxtEmpresa.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.TxtEmpresa.Size = New System.Drawing.Size(60, 26)
        Me.TxtEmpresa.TabIndex = 0
        '
        'LblEmpresa
        '
        Me.LblEmpresa.AutoSize = True
        Me.LblEmpresa.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEmpresa.Location = New System.Drawing.Point(6, 9)
        Me.LblEmpresa.Name = "LblEmpresa"
        Me.LblEmpresa.Size = New System.Drawing.Size(81, 18)
        Me.LblEmpresa.TabIndex = 1
        Me.LblEmpresa.Text = "Empresa :"
        '
        'LblOficina
        '
        Me.LblOficina.AutoSize = True
        Me.LblOficina.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblOficina.Location = New System.Drawing.Point(16, 63)
        Me.LblOficina.Name = "LblOficina"
        Me.LblOficina.Size = New System.Drawing.Size(71, 18)
        Me.LblOficina.TabIndex = 2
        Me.LblOficina.Text = "Oficina :"
        '
        'TxtOficina
        '
        Me.TxtOficina.EditValue = ""
        Me.TxtOficina.EnterMoveNextControl = True
        Me.TxtOficina.Location = New System.Drawing.Point(93, 60)
        Me.TxtOficina.Name = "TxtOficina"
        Me.TxtOficina.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOficina.Properties.Appearance.Options.UseFont = True
        Me.TxtOficina.Properties.Appearance.Options.UseTextOptions = True
        Me.TxtOficina.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TxtOficina.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtOficina.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Black
        Me.TxtOficina.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOficina.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TxtOficina.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.TxtOficina.Properties.AppearanceFocused.Options.UseFont = True
        Me.TxtOficina.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.TxtOficina.Size = New System.Drawing.Size(60, 26)
        Me.TxtOficina.TabIndex = 1
        '
        'DescEmpresa
        '
        Me.DescEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DescEmpresa.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescEmpresa.ForeColor = System.Drawing.Color.Maroon
        Me.DescEmpresa.Location = New System.Drawing.Point(159, 6)
        Me.DescEmpresa.Name = "DescEmpresa"
        Me.DescEmpresa.Size = New System.Drawing.Size(369, 48)
        Me.DescEmpresa.TabIndex = 4
        '
        'DescOficina
        '
        Me.DescOficina.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DescOficina.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescOficina.ForeColor = System.Drawing.Color.Maroon
        Me.DescOficina.Location = New System.Drawing.Point(159, 60)
        Me.DescOficina.Name = "DescOficina"
        Me.DescOficina.Size = New System.Drawing.Size(369, 24)
        Me.DescOficina.TabIndex = 5
        '
        'GridRol
        '
        Me.GridRol.Location = New System.Drawing.Point(9, 87)
        Me.GridRol.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.GridRol.MainView = Me.Gvrol
        Me.GridRol.Name = "GridRol"
        Me.GridRol.Size = New System.Drawing.Size(519, 137)
        Me.GridRol.TabIndex = 6
        Me.GridRol.TabStop = False
        Me.GridRol.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.Gvrol})
        '
        'Gvrol
        '
        Me.Gvrol.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Gvrol.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Gvrol.Appearance.FocusedRow.BorderColor = System.Drawing.Color.Black
        Me.Gvrol.Appearance.FocusedRow.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Gvrol.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Maroon
        Me.Gvrol.Appearance.FocusedRow.Options.UseBackColor = True
        Me.Gvrol.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.Gvrol.Appearance.FocusedRow.Options.UseFont = True
        Me.Gvrol.Appearance.FocusedRow.Options.UseForeColor = True
        Me.Gvrol.Appearance.FocusedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Gvrol.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Gvrol.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Gvrol.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Gvrol.Appearance.Row.ForeColor = System.Drawing.Color.Maroon
        Me.Gvrol.Appearance.Row.Options.UseBackColor = True
        Me.Gvrol.Appearance.Row.Options.UseFont = True
        Me.Gvrol.Appearance.Row.Options.UseForeColor = True
        Me.Gvrol.Appearance.SelectedRow.BackColor = System.Drawing.Color.Black
        Me.Gvrol.Appearance.SelectedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Gvrol.Appearance.SelectedRow.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Gvrol.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.Gvrol.Appearance.SelectedRow.Options.UseBackColor = True
        Me.Gvrol.Appearance.SelectedRow.Options.UseFont = True
        Me.Gvrol.Appearance.SelectedRow.Options.UseForeColor = True
        Me.Gvrol.Appearance.SelectedRow.Options.UseTextOptions = True
        Me.Gvrol.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.Gvrol.GridControl = Me.GridRol
        Me.Gvrol.Name = "Gvrol"
        Me.Gvrol.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.Gvrol.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.Gvrol.OptionsCustomization.AllowFilter = False
        Me.Gvrol.OptionsView.EnableAppearanceEvenRow = True
        Me.Gvrol.OptionsView.EnableAppearanceOddRow = True
        Me.Gvrol.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.Gvrol.OptionsView.ShowGroupPanel = False
        '
        'Cancelar
        '
        Me.Cancelar.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancelar.Appearance.Options.UseFont = True
        Me.Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancelar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.Cancelar.Location = New System.Drawing.Point(418, 229)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.Size = New System.Drawing.Size(95, 26)
        Me.Cancelar.TabIndex = 4
        Me.Cancelar.Text = "Cancelar"
        '
        'Aceptar
        '
        Me.Aceptar.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Aceptar.Appearance.Options.UseFont = True
        Me.Aceptar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.Aceptar.Location = New System.Drawing.Point(297, 229)
        Me.Aceptar.Name = "Aceptar"
        Me.Aceptar.Size = New System.Drawing.Size(103, 26)
        Me.Aceptar.TabIndex = 3
        Me.Aceptar.Text = "Aceptar"
        '
        'FechaIngeso
        '
        Me.FechaIngeso.EditValue = Nothing
        Me.FechaIngeso.EnterMoveNextControl = True
        Me.FechaIngeso.Location = New System.Drawing.Point(144, 230)
        Me.FechaIngeso.Name = "FechaIngeso"
        Me.FechaIngeso.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaIngeso.Properties.Appearance.Options.UseFont = True
        Me.FechaIngeso.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FechaIngeso.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FechaIngeso.Size = New System.Drawing.Size(136, 24)
        Me.FechaIngeso.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 232)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 18)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Fecha Ingreso :"
        '
        'FrmRolEmpresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 263)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FechaIngeso)
        Me.Controls.Add(Me.Aceptar)
        Me.Controls.Add(Me.Cancelar)
        Me.Controls.Add(Me.GridRol)
        Me.Controls.Add(Me.DescOficina)
        Me.Controls.Add(Me.DescEmpresa)
        Me.Controls.Add(Me.TxtOficina)
        Me.Controls.Add(Me.LblOficina)
        Me.Controls.Add(Me.LblEmpresa)
        Me.Controls.Add(Me.TxtEmpresa)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmRolEmpresa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Roles de usuario por Empresa"
        CType(Me.TxtEmpresa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtOficina.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridRol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gvrol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FechaIngeso.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FechaIngeso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtEmpresa As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LblEmpresa As System.Windows.Forms.Label
    Friend WithEvents LblOficina As System.Windows.Forms.Label
    Friend WithEvents TxtOficina As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DescEmpresa As System.Windows.Forms.Label
    Friend WithEvents DescOficina As System.Windows.Forms.Label
    Friend WithEvents GridRol As DevExpress.XtraGrid.GridControl
    Friend WithEvents Cancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Aceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents FechaIngeso As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Gvrol As DevExpress.XtraGrid.Views.Grid.GridView
End Class
