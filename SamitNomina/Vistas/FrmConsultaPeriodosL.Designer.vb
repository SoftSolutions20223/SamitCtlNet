<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmConsultaPeriodosL
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConsultaPeriodosL))
        Me.gcLiquidaNomina = New DevExpress.XtraGrid.GridControl()
        Me.gvLiquidaNomina = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.vgIngresosDeducciones = New DevExpress.XtraVerticalGrid.VGridControl()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.PanelControl10 = New DevExpress.XtraEditors.PanelControl()
        Me.vgProviciones = New DevExpress.XtraVerticalGrid.VGridControl()
        Me.PanelControl11 = New DevExpress.XtraEditors.PanelControl()
        Me.vgDescPorNomina = New DevExpress.XtraVerticalGrid.VGridControl()
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.pMenuImprimir = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.btnImpDetallado = New DevExpress.XtraBars.BarButtonItem()
        Me.btnImpBasica = New DevExpress.XtraBars.BarButtonItem()
        Me.btnImpTotalesXperiodo = New DevExpress.XtraBars.BarButtonItem()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.btnImpDesprendible = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnExcell = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.gcLiquidaNomina, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvLiquidaNomina, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vgIngresosDeducciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me.PanelControl10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl10.SuspendLayout()
        CType(Me.vgProviciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl11.SuspendLayout()
        CType(Me.vgDescPorNomina, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.pMenuImprimir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gcLiquidaNomina
        '
        Me.gcLiquidaNomina.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcLiquidaNomina.Location = New System.Drawing.Point(0, 0)
        Me.gcLiquidaNomina.MainView = Me.gvLiquidaNomina
        Me.gcLiquidaNomina.Name = "gcLiquidaNomina"
        Me.gcLiquidaNomina.Size = New System.Drawing.Size(1008, 341)
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
        'vgIngresosDeducciones
        '
        Me.vgIngresosDeducciones.Cursor = System.Windows.Forms.Cursors.Default
        Me.vgIngresosDeducciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.vgIngresosDeducciones.Location = New System.Drawing.Point(0, 0)
        Me.vgIngresosDeducciones.Name = "vgIngresosDeducciones"
        Me.vgIngresosDeducciones.Size = New System.Drawing.Size(331, 246)
        Me.vgIngresosDeducciones.TabIndex = 0
        Me.vgIngresosDeducciones.TabStop = False
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(6, 12)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.gcLiquidaNomina)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.TableLayoutPanel4)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1008, 610)
        Me.SplitContainerControl1.SplitterPosition = 341
        Me.SplitContainerControl1.TabIndex = 102
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel4.ColumnCount = 3
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.Controls.Add(Me.PanelControl10, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.PanelControl11, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.vgDescPorNomina, 2, 0)
        Me.TableLayoutPanel4.ForeColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(-1, 7)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(1011, 252)
        Me.TableLayoutPanel4.TabIndex = 3
        '
        'PanelControl10
        '
        Me.PanelControl10.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl10.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl10.Controls.Add(Me.vgProviciones)
        Me.PanelControl10.Location = New System.Drawing.Point(340, 3)
        Me.PanelControl10.Name = "PanelControl10"
        Me.PanelControl10.Size = New System.Drawing.Size(331, 246)
        Me.PanelControl10.TabIndex = 1
        '
        'vgProviciones
        '
        Me.vgProviciones.Cursor = System.Windows.Forms.Cursors.Default
        Me.vgProviciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.vgProviciones.Location = New System.Drawing.Point(0, 0)
        Me.vgProviciones.Name = "vgProviciones"
        Me.vgProviciones.Size = New System.Drawing.Size(331, 246)
        Me.vgProviciones.TabIndex = 1
        Me.vgProviciones.TabStop = False
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
        Me.PanelControl11.Size = New System.Drawing.Size(331, 246)
        Me.PanelControl11.TabIndex = 0
        '
        'vgDescPorNomina
        '
        Me.vgDescPorNomina.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.vgDescPorNomina.Cursor = System.Windows.Forms.Cursors.Default
        Me.vgDescPorNomina.Location = New System.Drawing.Point(677, 3)
        Me.vgDescPorNomina.Name = "vgDescPorNomina"
        Me.vgDescPorNomina.Size = New System.Drawing.Size(331, 246)
        Me.vgDescPorNomina.TabIndex = 2
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(5, 77)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(78, 45)
        Me.btnSalir.TabIndex = 2
        Me.btnSalir.Text = "Salir"
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.GroupControl1.CaptionImageOptions.Padding = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.GroupControl1.Controls.Add(Me.BtnExcell)
        Me.GroupControl1.Controls.Add(Me.btnSalir)
        Me.GroupControl1.Location = New System.Drawing.Point(1021, 6)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(88, 606)
        Me.GroupControl1.TabIndex = 2
        Me.GroupControl1.Text = "Opciones"
        '
        'pMenuImprimir
        '
        Me.pMenuImprimir.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnImpDetallado), New DevExpress.XtraBars.LinkPersistInfo(Me.btnImpBasica), New DevExpress.XtraBars.LinkPersistInfo(Me.btnImpTotalesXperiodo)})
        Me.pMenuImprimir.Manager = Me.BarManager1
        Me.pMenuImprimir.MenuDrawMode = DevExpress.XtraBars.MenuDrawMode.SmallImagesText
        Me.pMenuImprimir.Name = "pMenuImprimir"
        '
        'btnImpDetallado
        '
        Me.btnImpDetallado.Caption = "Inf. Detallada"
        Me.btnImpDetallado.Id = 1
        Me.btnImpDetallado.ImageOptions.LargeImage = CType(resources.GetObject("btnImpDetallado.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnImpDetallado.Name = "btnImpDetallado"
        '
        'btnImpBasica
        '
        Me.btnImpBasica.Caption = "Inf. Básica"
        Me.btnImpBasica.Id = 2
        Me.btnImpBasica.ImageOptions.LargeImage = CType(resources.GetObject("btnImpBasica.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnImpBasica.Name = "btnImpBasica"
        '
        'btnImpTotalesXperiodo
        '
        Me.btnImpTotalesXperiodo.Caption = "Totes x periodo"
        Me.btnImpTotalesXperiodo.Id = 3
        Me.btnImpTotalesXperiodo.ImageOptions.LargeImage = CType(resources.GetObject("btnImpTotalesXperiodo.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnImpTotalesXperiodo.Name = "btnImpTotalesXperiodo"
        '
        'BarManager1
        '
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnImpDesprendible, Me.btnImpDetallado, Me.btnImpBasica, Me.btnImpTotalesXperiodo})
        Me.BarManager1.MaxItemId = 4
        Me.BarManager1.ShowCloseButton = True
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1115, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 623)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1115, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 623)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1115, 0)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 623)
        '
        'btnImpDesprendible
        '
        Me.btnImpDesprendible.Caption = "Desprendible"
        Me.btnImpDesprendible.Id = 0
        Me.btnImpDesprendible.ImageOptions.LargeImage = CType(resources.GetObject("btnImpDesprendible.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnImpDesprendible.Name = "btnImpDesprendible"
        '
        'BtnExcell
        '
        Me.BtnExcell.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnExcell.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.BtnExcell.Appearance.Options.UseFont = True
        Me.BtnExcell.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnExcell.Location = New System.Drawing.Point(4, 26)
        Me.BtnExcell.Name = "BtnExcell"
        Me.BtnExcell.Size = New System.Drawing.Size(78, 45)
        Me.BtnExcell.TabIndex = 1
        Me.BtnExcell.Text = "Excell"
        '
        'FrmConsultaPeriodosL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1115, 623)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "FrmConsultaPeriodosL"
        Me.Text = "Consultar Periodos Liquidados"
        CType(Me.gcLiquidaNomina, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvLiquidaNomina, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vgIngresosDeducciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        CType(Me.PanelControl10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl10.ResumeLayout(False)
        CType(Me.vgProviciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl11.ResumeLayout(False)
        CType(Me.vgDescPorNomina, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.pMenuImprimir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gcLiquidaNomina As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvLiquidaNomina As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents vgIngresosDeducciones As DevExpress.XtraVerticalGrid.VGridControl
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents vgProviciones As DevExpress.XtraVerticalGrid.VGridControl
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PanelControl10 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl11 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents vgDescPorNomina As DevExpress.XtraVerticalGrid.VGridControl
    Friend WithEvents pMenuImprimir As DevExpress.XtraBars.PopupMenu
    Friend WithEvents btnImpDesprendible As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnImpDetallado As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnImpBasica As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnImpTotalesXperiodo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BtnExcell As DevExpress.XtraEditors.SimpleButton
End Class
