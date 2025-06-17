<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLiquidarContratos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLiquidarContratos))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.btnEliminar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnNuevaLiquidacion = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.btnLimpiar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnBuscar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnLiquidar = New DevExpress.XtraEditors.SimpleButton()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.gcLiquidaNomina = New DevExpress.XtraGrid.GridControl()
        Me.gvLiquidaNomina = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.PanelControl11 = New DevExpress.XtraEditors.PanelControl()
        Me.vgIngresosDeducciones = New DevExpress.XtraVerticalGrid.VGridControl()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.gcLiquidaNomina, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvLiquidaNomina, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me.PanelControl11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl11.SuspendLayout()
        CType(Me.vgIngresosDeducciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.GroupControl1.CaptionImagePadding = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.GroupControl1.Controls.Add(Me.btnEliminar)
        Me.GroupControl1.Controls.Add(Me.btnNuevaLiquidacion)
        Me.GroupControl1.Controls.Add(Me.btnSalir)
        Me.GroupControl1.Controls.Add(Me.btnLimpiar)
        Me.GroupControl1.Controls.Add(Me.btnBuscar)
        Me.GroupControl1.Controls.Add(Me.btnLiquidar)
        Me.GroupControl1.Location = New System.Drawing.Point(1021, 3)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(88, 606)
        Me.GroupControl1.TabIndex = 109
        Me.GroupControl1.Text = "Opciones"
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnEliminar.Location = New System.Drawing.Point(5, 176)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(78, 45)
        Me.btnEliminar.TabIndex = 4
        Me.btnEliminar.Text = "Eliminar"
        '
        'btnNuevaLiquidacion
        '
        Me.btnNuevaLiquidacion.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnNuevaLiquidacion.Appearance.Options.UseFont = True
        Me.btnNuevaLiquidacion.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnNuevaLiquidacion.Location = New System.Drawing.Point(5, 26)
        Me.btnNuevaLiquidacion.Name = "btnNuevaLiquidacion"
        Me.btnNuevaLiquidacion.Size = New System.Drawing.Size(78, 45)
        Me.btnNuevaLiquidacion.TabIndex = 1
        Me.btnNuevaLiquidacion.Text = "Nueva"
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(5, 276)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(78, 45)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "Salir"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLimpiar.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnLimpiar.Appearance.Options.UseFont = True
        Me.btnLimpiar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnLimpiar.Location = New System.Drawing.Point(5, 226)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(78, 45)
        Me.btnLimpiar.TabIndex = 5
        Me.btnLimpiar.Text = "Limpiar"
        '
        'btnBuscar
        '
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnBuscar.Location = New System.Drawing.Point(5, 76)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(78, 45)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Buscar"
        '
        'btnLiquidar
        '
        Me.btnLiquidar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLiquidar.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnLiquidar.Appearance.Options.UseFont = True
        Me.btnLiquidar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnLiquidar.Location = New System.Drawing.Point(5, 126)
        Me.btnLiquidar.Name = "btnLiquidar"
        Me.btnLiquidar.Size = New System.Drawing.Size(78, 45)
        Me.btnLiquidar.TabIndex = 3
        Me.btnLiquidar.Text = "Liquidar"
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(6, 3)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.gcLiquidaNomina)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.TableLayoutPanel4)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1008, 616)
        Me.SplitContainerControl1.SplitterPosition = 293
        Me.SplitContainerControl1.TabIndex = 110
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'gcLiquidaNomina
        '
        Me.gcLiquidaNomina.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcLiquidaNomina.Location = New System.Drawing.Point(0, 0)
        Me.gcLiquidaNomina.MainView = Me.gvLiquidaNomina
        Me.gcLiquidaNomina.Name = "gcLiquidaNomina"
        Me.gcLiquidaNomina.Size = New System.Drawing.Size(1008, 293)
        Me.gcLiquidaNomina.TabIndex = 0
        Me.gcLiquidaNomina.TabStop = False
        Me.gcLiquidaNomina.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvLiquidaNomina})
        '
        'gvLiquidaNomina
        '
        Me.gvLiquidaNomina.GridControl = Me.gcLiquidaNomina
        Me.gvLiquidaNomina.Name = "gvLiquidaNomina"
        Me.gvLiquidaNomina.OptionsView.ShowGroupPanel = False
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.PanelControl11, 0, 0)
        Me.TableLayoutPanel4.ForeColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(-1, 7)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(1011, 306)
        Me.TableLayoutPanel4.TabIndex = 3
        '
        'PanelControl11
        '
        Me.PanelControl11.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl11.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl11.Controls.Add(Me.vgIngresosDeducciones)
        Me.PanelControl11.Location = New System.Drawing.Point(3, 3)
        Me.PanelControl11.Name = "PanelControl11"
        Me.PanelControl11.Size = New System.Drawing.Size(1005, 300)
        Me.PanelControl11.TabIndex = 0
        '
        'vgIngresosDeducciones
        '
        Me.vgIngresosDeducciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.vgIngresosDeducciones.Location = New System.Drawing.Point(0, 0)
        Me.vgIngresosDeducciones.Name = "vgIngresosDeducciones"
        Me.vgIngresosDeducciones.OptionsMenu.EnableContextMenu = False
        Me.vgIngresosDeducciones.Size = New System.Drawing.Size(1005, 300)
        Me.vgIngresosDeducciones.TabIndex = 0
        Me.vgIngresosDeducciones.TabStop = False
        '
        'FrmLiquidarContratos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1115, 623)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmLiquidarContratos"
        Me.Text = "Liquidar Contratos"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.gcLiquidaNomina, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvLiquidaNomina, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel4.ResumeLayout(False)
        CType(Me.PanelControl11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl11.ResumeLayout(False)
        CType(Me.vgIngresosDeducciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnNuevaLiquidacion As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnLimpiar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnLiquidar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents gcLiquidaNomina As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvLiquidaNomina As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PanelControl11 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents vgIngresosDeducciones As DevExpress.XtraVerticalGrid.VGridControl
End Class
