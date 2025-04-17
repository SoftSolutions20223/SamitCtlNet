<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBusqRapida
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
        Me.GridBusca = New DevExpress.XtraGrid.GridControl()
        Me.GvBusca = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Codigo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Valor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LblFiltro = New System.Windows.Forms.Label()
        CType(Me.GridBusca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GvBusca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridBusca
        '
        Me.GridBusca.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GridBusca.Location = New System.Drawing.Point(0, 28)
        Me.GridBusca.MainView = Me.GvBusca
        Me.GridBusca.Name = "GridBusca"
        Me.GridBusca.Size = New System.Drawing.Size(543, 239)
        Me.GridBusca.TabIndex = 0
        Me.GridBusca.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GvBusca})
        '
        'GvBusca
        '
        Me.GvBusca.ActiveFilterEnabled = False
        Me.GvBusca.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GvBusca.Appearance.FocusedRow.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GvBusca.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Maroon
        Me.GvBusca.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GvBusca.Appearance.FocusedRow.Options.UseFont = True
        Me.GvBusca.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GvBusca.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.GvBusca.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Codigo, Me.Valor})
        Me.GvBusca.GridControl = Me.GridBusca
        Me.GvBusca.Name = "GvBusca"
        Me.GvBusca.OptionsBehavior.Editable = False
        Me.GvBusca.OptionsCustomization.AllowFilter = False
        Me.GvBusca.OptionsFilter.AllowColumnMRUFilterList = False
        Me.GvBusca.OptionsFilter.AllowFilterEditor = False
        Me.GvBusca.OptionsFilter.AllowFilterIncrementalSearch = False
        Me.GvBusca.OptionsFilter.AllowMRUFilterList = False
        Me.GvBusca.OptionsFilter.AllowMultiSelectInCheckedFilterPopup = False
        Me.GvBusca.OptionsFind.AllowFindPanel = False
        Me.GvBusca.OptionsFind.HighlightFindResults = False
        Me.GvBusca.OptionsFind.ShowClearButton = False
        Me.GvBusca.OptionsFind.ShowCloseButton = False
        Me.GvBusca.OptionsFind.ShowFindButton = False
        Me.GvBusca.OptionsMenu.EnableColumnMenu = False
        Me.GvBusca.OptionsMenu.ShowAddNewSummaryItem = DevExpress.Utils.DefaultBoolean.[False]
        Me.GvBusca.OptionsMenu.ShowSplitItem = False
        Me.GvBusca.OptionsSelection.UseIndicatorForSelection = False
        Me.GvBusca.OptionsView.AutoCalcPreviewLineCount = True
        Me.GvBusca.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GvBusca.OptionsView.ShowGroupPanel = False
        '
        'Codigo
        '
        Me.Codigo.AppearanceCell.Options.UseTextOptions = True
        Me.Codigo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Codigo.Caption = "Codigo "
        Me.Codigo.FieldName = "Codigo"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.OptionsColumn.AllowEdit = False
        Me.Codigo.OptionsColumn.AllowFocus = False
        Me.Codigo.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.Codigo.OptionsColumn.AllowIncrementalSearch = False
        Me.Codigo.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.Codigo.OptionsColumn.AllowMove = False
        Me.Codigo.OptionsColumn.AllowShowHide = False
        Me.Codigo.OptionsColumn.AllowSize = False
        Me.Codigo.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.Codigo.OptionsColumn.FixedWidth = True
        Me.Codigo.OptionsColumn.ReadOnly = True
        Me.Codigo.OptionsColumn.ShowInExpressionEditor = False
        Me.Codigo.OptionsColumn.TabStop = False
        Me.Codigo.Visible = True
        Me.Codigo.VisibleIndex = 0
        Me.Codigo.Width = 115
        '
        'Valor
        '
        Me.Valor.Caption = "Descripción"
        Me.Valor.FieldName = "Valor"
        Me.Valor.Name = "Valor"
        Me.Valor.OptionsColumn.AllowEdit = False
        Me.Valor.OptionsColumn.AllowFocus = False
        Me.Valor.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.Valor.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.Valor.OptionsColumn.AllowMove = False
        Me.Valor.OptionsColumn.AllowSize = False
        Me.Valor.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.Valor.OptionsColumn.FixedWidth = True
        Me.Valor.OptionsColumn.ReadOnly = True
        Me.Valor.OptionsFilter.AllowAutoFilter = False
        Me.Valor.OptionsFilter.AllowFilter = False
        Me.Valor.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.[False]
        Me.Valor.Visible = True
        Me.Valor.VisibleIndex = 1
        '
        'LblFiltro
        '
        Me.LblFiltro.BackColor = System.Drawing.Color.White
        Me.LblFiltro.Dock = System.Windows.Forms.DockStyle.Top
        Me.LblFiltro.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFiltro.Location = New System.Drawing.Point(0, 0)
        Me.LblFiltro.Name = "LblFiltro"
        Me.LblFiltro.Size = New System.Drawing.Size(543, 26)
        Me.LblFiltro.TabIndex = 1
        '
        'FrmBusqRapida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(543, 267)
        Me.Controls.Add(Me.LblFiltro)
        Me.Controls.Add(Me.GridBusca)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Name = "FrmBusqRapida"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda Rapida"
        CType(Me.GridBusca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GvBusca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridBusca As DevExpress.XtraGrid.GridControl
    Friend WithEvents GvBusca As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Codigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Valor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LblFiltro As System.Windows.Forms.Label
End Class
