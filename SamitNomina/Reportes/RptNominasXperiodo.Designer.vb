<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class RptNominasXperiodo
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.tablaFamiliares = New DevExpress.XtraReports.UI.XRTable()
        Me.Fila1FM = New DevExpress.XtraReports.UI.XRTableRow()
        Me.lblNumContra = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lblDocEmp = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lblNombres = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lblIngresos = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lblDeducciones = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lblNetoApagar = New DevExpress.XtraReports.UI.XRTableCell()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.lblTituloFijo = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblTitulo = New DevExpress.XtraReports.UI.XRLabel()
        Me.pcbImg = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.tablaCabecera1 = New DevExpress.XtraReports.UI.XRTable()
        Me.f1Cab1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.lblNomEmp = New DevExpress.XtraReports.UI.XRTableCell()
        Me.f2Cab1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.lblNitEmp = New DevExpress.XtraReports.UI.XRTableCell()
        Me.f3Cab1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.lblOficina = New DevExpress.XtraReports.UI.XRTableCell()
        Me.f4Cab1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.LblDireccionEmpresa = New DevExpress.XtraReports.UI.XRTableCell()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.lblTitleNumContra = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblTitleNetoApagar = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblTitleIngresos = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblTitleNombres = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblTitleDeducciones = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblTitleDocEmp = New DevExpress.XtraReports.UI.XRLabel()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.xrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.xrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.lblversionsamit = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblpc = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblUsuario = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblpaginas = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblsigpag = New DevExpress.XtraReports.UI.XRLabel()
        Me.Fecha = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.lblTotales = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrTable3 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.lblTitleSumNetoPagar = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lblSumNetoPagar = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.lblTitleTotalDeducciones = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lblTotalDeducciones = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow8 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.lblTitleTotalIngreso = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lblTotalIngresos = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lblTitleDescuentos = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblDescuentos = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.lblTitleTotalDescuentos = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lblTotalDescuentos = New DevExpress.XtraReports.UI.XRTableCell()
        CType(Me.tablaFamiliares, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tablaCabecera1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.tablaFamiliares})
        Me.Detail.Dpi = 254.0!
        Me.Detail.HeightF = 36.95654!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'tablaFamiliares
        '
        Me.tablaFamiliares.BorderWidth = 0.5!
        Me.tablaFamiliares.Dpi = 254.0!
        Me.tablaFamiliares.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.tablaFamiliares.Name = "tablaFamiliares"
        Me.tablaFamiliares.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 254.0!)
        Me.tablaFamiliares.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.Fila1FM})
        Me.tablaFamiliares.SizeF = New System.Drawing.SizeF(2007.551!, 36.95654!)
        Me.tablaFamiliares.StylePriority.UseBorderWidth = False
        Me.tablaFamiliares.StylePriority.UsePadding = False
        '
        'Fila1FM
        '
        Me.Fila1FM.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.lblNumContra, Me.lblDocEmp, Me.lblNombres, Me.lblIngresos, Me.lblDeducciones, Me.lblDescuentos, Me.lblNetoApagar})
        Me.Fila1FM.Dpi = 254.0!
        Me.Fila1FM.Name = "Fila1FM"
        Me.Fila1FM.Weight = 1.0R
        '
        'lblNumContra
        '
        Me.lblNumContra.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblNumContra.CanGrow = False
        Me.lblNumContra.Dpi = 254.0!
        Me.lblNumContra.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumContra.Name = "lblNumContra"
        Me.lblNumContra.StylePriority.UseBorders = False
        Me.lblNumContra.StylePriority.UseFont = False
        Me.lblNumContra.StylePriority.UseTextAlignment = False
        Me.lblNumContra.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.lblNumContra.Weight = 0.5126939047485144R
        '
        'lblDocEmp
        '
        Me.lblDocEmp.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblDocEmp.CanGrow = False
        Me.lblDocEmp.Dpi = 254.0!
        Me.lblDocEmp.Font = New System.Drawing.Font("Times New Roman", 8.75!)
        Me.lblDocEmp.Name = "lblDocEmp"
        Me.lblDocEmp.StylePriority.UseBorders = False
        Me.lblDocEmp.StylePriority.UseFont = False
        Me.lblDocEmp.StylePriority.UseTextAlignment = False
        Me.lblDocEmp.Text = "999,999,999,999"
        Me.lblDocEmp.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.lblDocEmp.Weight = 0.59032388278138215R
        '
        'lblNombres
        '
        Me.lblNombres.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblNombres.Dpi = 254.0!
        Me.lblNombres.Font = New System.Drawing.Font("Times New Roman", 8.75!)
        Me.lblNombres.Multiline = True
        Me.lblNombres.Name = "lblNombres"
        Me.lblNombres.StylePriority.UseBorders = False
        Me.lblNombres.StylePriority.UseFont = False
        Me.lblNombres.StylePriority.UseTextAlignment = False
        Me.lblNombres.Text = "Nombres"
        Me.lblNombres.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.lblNombres.Weight = 1.6272728176740796R
        '
        'lblIngresos
        '
        Me.lblIngresos.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblIngresos.Dpi = 254.0!
        Me.lblIngresos.Font = New System.Drawing.Font("Arial Narrow", 9.0!)
        Me.lblIngresos.Name = "lblIngresos"
        Me.lblIngresos.StylePriority.UseBorders = False
        Me.lblIngresos.StylePriority.UseFont = False
        Me.lblIngresos.StylePriority.UseTextAlignment = False
        Me.lblIngresos.Text = "$ 0,00"
        Me.lblIngresos.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.lblIngresos.Weight = 0.68524377885280474R
        '
        'lblDeducciones
        '
        Me.lblDeducciones.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblDeducciones.CanGrow = False
        Me.lblDeducciones.Dpi = 254.0!
        Me.lblDeducciones.Font = New System.Drawing.Font("Arial Narrow", 9.0!)
        Me.lblDeducciones.Name = "lblDeducciones"
        Me.lblDeducciones.StylePriority.UseBorders = False
        Me.lblDeducciones.StylePriority.UseFont = False
        Me.lblDeducciones.StylePriority.UseTextAlignment = False
        Me.lblDeducciones.Text = "- $ 0,00"
        Me.lblDeducciones.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.lblDeducciones.Weight = 0.630191173450872R
        '
        'lblNetoApagar
        '
        Me.lblNetoApagar.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblNetoApagar.Dpi = 254.0!
        Me.lblNetoApagar.Font = New System.Drawing.Font("Arial Narrow", 9.0!)
        Me.lblNetoApagar.Name = "lblNetoApagar"
        Me.lblNetoApagar.StylePriority.UseBorders = False
        Me.lblNetoApagar.StylePriority.UseFont = False
        Me.lblNetoApagar.StylePriority.UseTextAlignment = False
        Me.lblNetoApagar.Text = "$ 0,00"
        Me.lblNetoApagar.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.lblNetoApagar.Weight = 0.63018810602630448R
        '
        'TopMargin
        '
        Me.TopMargin.Dpi = 254.0!
        Me.TopMargin.HeightF = 50.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.Dpi = 254.0!
        Me.BottomMargin.HeightF = 35.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lblTituloFijo, Me.lblTitulo, Me.pcbImg, Me.tablaCabecera1})
        Me.ReportHeader.Dpi = 254.0!
        Me.ReportHeader.HeightF = 338.0867!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'lblTituloFijo
        '
        Me.lblTituloFijo.Dpi = 254.0!
        Me.lblTituloFijo.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloFijo.LocationFloat = New DevExpress.Utils.PointFloat(10.55225!, 207.0!)
        Me.lblTituloFijo.Name = "lblTituloFijo"
        Me.lblTituloFijo.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.lblTituloFijo.SizeF = New System.Drawing.SizeF(1997.0!, 57.42004!)
        Me.lblTituloFijo.StylePriority.UseFont = False
        Me.lblTituloFijo.StylePriority.UseTextAlignment = False
        Me.lblTituloFijo.Text = "Informe de Totales por empleado"
        Me.lblTituloFijo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'lblTitulo
        '
        Me.lblTitulo.Dpi = 254.0!
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.LocationFloat = New DevExpress.Utils.PointFloat(10.55194!, 279.6667!)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.lblTitulo.SizeF = New System.Drawing.SizeF(1997.0!, 58.42004!)
        Me.lblTitulo.StylePriority.UseFont = False
        Me.lblTitulo.StylePriority.UseTextAlignment = False
        Me.lblTitulo.Text = "Nóminas {0} del periodo comprendido entre {0} y {0}"
        Me.lblTitulo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'pcbImg
        '
        Me.pcbImg.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.pcbImg.Dpi = 254.0!
        Me.pcbImg.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.MiddleCenter
        Me.pcbImg.LocationFloat = New DevExpress.Utils.PointFloat(10.55194!, 0.0!)
        Me.pcbImg.Name = "pcbImg"
        Me.pcbImg.SizeF = New System.Drawing.SizeF(254.0!, 200.0!)
        Me.pcbImg.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze
        Me.pcbImg.StylePriority.UseBorders = False
        '
        'tablaCabecera1
        '
        Me.tablaCabecera1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.tablaCabecera1.Dpi = 254.0!
        Me.tablaCabecera1.LocationFloat = New DevExpress.Utils.PointFloat(264.5519!, 0.0!)
        Me.tablaCabecera1.Name = "tablaCabecera1"
        Me.tablaCabecera1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.f1Cab1, Me.f2Cab1, Me.f3Cab1, Me.f4Cab1})
        Me.tablaCabecera1.SizeF = New System.Drawing.SizeF(1441.026!, 200.0!)
        Me.tablaCabecera1.StylePriority.UseBorders = False
        '
        'f1Cab1
        '
        Me.f1Cab1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.lblNomEmp})
        Me.f1Cab1.Dpi = 254.0!
        Me.f1Cab1.Name = "f1Cab1"
        Me.f1Cab1.Weight = 1.0R
        '
        'lblNomEmp
        '
        Me.lblNomEmp.Dpi = 254.0!
        Me.lblNomEmp.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lblNomEmp.Name = "lblNomEmp"
        Me.lblNomEmp.StylePriority.UseFont = False
        Me.lblNomEmp.StylePriority.UseTextAlignment = False
        Me.lblNomEmp.Text = "Nombre de la empresa"
        Me.lblNomEmp.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.lblNomEmp.Weight = 2.2655169500143568R
        '
        'f2Cab1
        '
        Me.f2Cab1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.lblNitEmp})
        Me.f2Cab1.Dpi = 254.0!
        Me.f2Cab1.Name = "f2Cab1"
        Me.f2Cab1.Weight = 1.0R
        '
        'lblNitEmp
        '
        Me.lblNitEmp.Dpi = 254.0!
        Me.lblNitEmp.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNitEmp.Name = "lblNitEmp"
        Me.lblNitEmp.StylePriority.UseFont = False
        Me.lblNitEmp.StylePriority.UseTextAlignment = False
        Me.lblNitEmp.Text = "Nit"
        Me.lblNitEmp.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.lblNitEmp.Weight = 2.2655169500143568R
        '
        'f3Cab1
        '
        Me.f3Cab1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.lblOficina})
        Me.f3Cab1.Dpi = 254.0!
        Me.f3Cab1.Name = "f3Cab1"
        Me.f3Cab1.Weight = 1.0R
        '
        'lblOficina
        '
        Me.lblOficina.Dpi = 254.0!
        Me.lblOficina.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOficina.Name = "lblOficina"
        Me.lblOficina.StylePriority.UseFont = False
        Me.lblOficina.StylePriority.UseTextAlignment = False
        Me.lblOficina.Text = "Oficina"
        Me.lblOficina.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.lblOficina.Weight = 2.2655169500143568R
        '
        'f4Cab1
        '
        Me.f4Cab1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.LblDireccionEmpresa})
        Me.f4Cab1.Dpi = 254.0!
        Me.f4Cab1.Name = "f4Cab1"
        Me.f4Cab1.Weight = 1.0R
        '
        'LblDireccionEmpresa
        '
        Me.LblDireccionEmpresa.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.LblDireccionEmpresa.Dpi = 254.0!
        Me.LblDireccionEmpresa.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDireccionEmpresa.Name = "LblDireccionEmpresa"
        Me.LblDireccionEmpresa.StylePriority.UseBorders = False
        Me.LblDireccionEmpresa.StylePriority.UseFont = False
        Me.LblDireccionEmpresa.StylePriority.UseTextAlignment = False
        Me.LblDireccionEmpresa.Text = "Direccion y telefonos"
        Me.LblDireccionEmpresa.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.LblDireccionEmpresa.Weight = 2.2655169500143568R
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lblTitleDescuentos, Me.lblTitleNumContra, Me.lblTitleNetoApagar, Me.lblTitleIngresos, Me.lblTitleNombres, Me.lblTitleDeducciones, Me.lblTitleDocEmp})
        Me.PageHeader.Dpi = 254.0!
        Me.PageHeader.HeightF = 68.00001!
        Me.PageHeader.Name = "PageHeader"
        '
        'lblTitleNumContra
        '
        Me.lblTitleNumContra.BackColor = System.Drawing.Color.LightGray
        Me.lblTitleNumContra.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblTitleNumContra.BorderWidth = 0.5!
        Me.lblTitleNumContra.Dpi = 254.0!
        Me.lblTitleNumContra.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleNumContra.LocationFloat = New DevExpress.Utils.PointFloat(10.55194!, 25.00001!)
        Me.lblTitleNumContra.Name = "lblTitleNumContra"
        Me.lblTitleNumContra.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 254.0!)
        Me.lblTitleNumContra.SizeF = New System.Drawing.SizeF(193.9764!, 43.0!)
        Me.lblTitleNumContra.StylePriority.UseBackColor = False
        Me.lblTitleNumContra.StylePriority.UseBorders = False
        Me.lblTitleNumContra.StylePriority.UseBorderWidth = False
        Me.lblTitleNumContra.StylePriority.UseFont = False
        Me.lblTitleNumContra.StylePriority.UsePadding = False
        Me.lblTitleNumContra.StylePriority.UseTextAlignment = False
        Me.lblTitleNumContra.Text = "# Contrato"
        Me.lblTitleNumContra.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'lblTitleNetoApagar
        '
        Me.lblTitleNetoApagar.BackColor = System.Drawing.Color.LightGray
        Me.lblTitleNetoApagar.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblTitleNetoApagar.BorderWidth = 0.5!
        Me.lblTitleNetoApagar.Dpi = 254.0!
        Me.lblTitleNetoApagar.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleNetoApagar.LocationFloat = New DevExpress.Utils.PointFloat(1769.121!, 24.99998!)
        Me.lblTitleNetoApagar.Name = "lblTitleNetoApagar"
        Me.lblTitleNetoApagar.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 254.0!)
        Me.lblTitleNetoApagar.SizeF = New System.Drawing.SizeF(238.4313!, 43.0!)
        Me.lblTitleNetoApagar.StylePriority.UseBackColor = False
        Me.lblTitleNetoApagar.StylePriority.UseBorders = False
        Me.lblTitleNetoApagar.StylePriority.UseBorderWidth = False
        Me.lblTitleNetoApagar.StylePriority.UseFont = False
        Me.lblTitleNetoApagar.StylePriority.UsePadding = False
        Me.lblTitleNetoApagar.StylePriority.UseTextAlignment = False
        Me.lblTitleNetoApagar.Text = "Neto a Pagar"
        Me.lblTitleNetoApagar.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'lblTitleIngresos
        '
        Me.lblTitleIngresos.BackColor = System.Drawing.Color.LightGray
        Me.lblTitleIngresos.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblTitleIngresos.BorderWidth = 0.5!
        Me.lblTitleIngresos.Dpi = 254.0!
        Me.lblTitleIngresos.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleIngresos.LocationFloat = New DevExpress.Utils.PointFloat(1053.827!, 25.0!)
        Me.lblTitleIngresos.Name = "lblTitleIngresos"
        Me.lblTitleIngresos.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 254.0!)
        Me.lblTitleIngresos.SizeF = New System.Drawing.SizeF(238.431!, 43.0!)
        Me.lblTitleIngresos.StylePriority.UseBackColor = False
        Me.lblTitleIngresos.StylePriority.UseBorders = False
        Me.lblTitleIngresos.StylePriority.UseBorderWidth = False
        Me.lblTitleIngresos.StylePriority.UseFont = False
        Me.lblTitleIngresos.StylePriority.UsePadding = False
        Me.lblTitleIngresos.StylePriority.UseTextAlignment = False
        Me.lblTitleIngresos.Text = "Ingresos"
        Me.lblTitleIngresos.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'lblTitleNombres
        '
        Me.lblTitleNombres.BackColor = System.Drawing.Color.LightGray
        Me.lblTitleNombres.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblTitleNombres.BorderWidth = 0.5!
        Me.lblTitleNombres.Dpi = 254.0!
        Me.lblTitleNombres.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleNombres.LocationFloat = New DevExpress.Utils.PointFloat(427.8759!, 25.00001!)
        Me.lblTitleNombres.Name = "lblTitleNombres"
        Me.lblTitleNombres.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 254.0!)
        Me.lblTitleNombres.SizeF = New System.Drawing.SizeF(625.9514!, 42.99997!)
        Me.lblTitleNombres.StylePriority.UseBackColor = False
        Me.lblTitleNombres.StylePriority.UseBorders = False
        Me.lblTitleNombres.StylePriority.UseBorderWidth = False
        Me.lblTitleNombres.StylePriority.UseFont = False
        Me.lblTitleNombres.StylePriority.UsePadding = False
        Me.lblTitleNombres.StylePriority.UseTextAlignment = False
        Me.lblTitleNombres.Text = "Nombres"
        Me.lblTitleNombres.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'lblTitleDeducciones
        '
        Me.lblTitleDeducciones.BackColor = System.Drawing.Color.LightGray
        Me.lblTitleDeducciones.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblTitleDeducciones.BorderWidth = 0.5!
        Me.lblTitleDeducciones.Dpi = 254.0!
        Me.lblTitleDeducciones.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleDeducciones.LocationFloat = New DevExpress.Utils.PointFloat(1292.259!, 25.00001!)
        Me.lblTitleDeducciones.Name = "lblTitleDeducciones"
        Me.lblTitleDeducciones.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 254.0!)
        Me.lblTitleDeducciones.SizeF = New System.Drawing.SizeF(238.4303!, 43.0!)
        Me.lblTitleDeducciones.StylePriority.UseBackColor = False
        Me.lblTitleDeducciones.StylePriority.UseBorders = False
        Me.lblTitleDeducciones.StylePriority.UseBorderWidth = False
        Me.lblTitleDeducciones.StylePriority.UseFont = False
        Me.lblTitleDeducciones.StylePriority.UsePadding = False
        Me.lblTitleDeducciones.StylePriority.UseTextAlignment = False
        Me.lblTitleDeducciones.Text = "Deducciones"
        Me.lblTitleDeducciones.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'lblTitleDocEmp
        '
        Me.lblTitleDocEmp.BackColor = System.Drawing.Color.LightGray
        Me.lblTitleDocEmp.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblTitleDocEmp.BorderWidth = 0.5!
        Me.lblTitleDocEmp.Dpi = 254.0!
        Me.lblTitleDocEmp.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleDocEmp.LocationFloat = New DevExpress.Utils.PointFloat(204.5283!, 25.00001!)
        Me.lblTitleDocEmp.Name = "lblTitleDocEmp"
        Me.lblTitleDocEmp.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 254.0!)
        Me.lblTitleDocEmp.SizeF = New System.Drawing.SizeF(223.3475!, 42.99997!)
        Me.lblTitleDocEmp.StylePriority.UseBackColor = False
        Me.lblTitleDocEmp.StylePriority.UseBorders = False
        Me.lblTitleDocEmp.StylePriority.UseBorderWidth = False
        Me.lblTitleDocEmp.StylePriority.UseFont = False
        Me.lblTitleDocEmp.StylePriority.UsePadding = False
        Me.lblTitleDocEmp.StylePriority.UseTextAlignment = False
        Me.lblTitleDocEmp.Text = "Doc. Empleado"
        Me.lblTitleDocEmp.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrPageInfo2, Me.xrPageInfo1, Me.lblversionsamit, Me.lblpc, Me.lblUsuario, Me.lblpaginas, Me.lblsigpag, Me.Fecha})
        Me.PageFooter.Dpi = 254.0!
        Me.PageFooter.HeightF = 52.10664!
        Me.PageFooter.Name = "PageFooter"
        '
        'xrPageInfo2
        '
        Me.xrPageInfo2.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.xrPageInfo2.BorderWidth = 0.5!
        Me.xrPageInfo2.Dpi = 254.0!
        Me.xrPageInfo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(1955.081!, 0.0!)
        Me.xrPageInfo2.Name = "xrPageInfo2"
        Me.xrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.xrPageInfo2.PageInfo = DevExpress.XtraPrinting.PageInfo.Total
        Me.xrPageInfo2.SizeF = New System.Drawing.SizeF(52.47095!, 34.86086!)
        Me.xrPageInfo2.StylePriority.UseBorders = False
        Me.xrPageInfo2.StylePriority.UseBorderWidth = False
        Me.xrPageInfo2.StylePriority.UseFont = False
        Me.xrPageInfo2.StylePriority.UseTextAlignment = False
        Me.xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'xrPageInfo1
        '
        Me.xrPageInfo1.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.xrPageInfo1.BorderWidth = 0.5!
        Me.xrPageInfo1.Dpi = 254.0!
        Me.xrPageInfo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(1852.437!, 0.0!)
        Me.xrPageInfo1.Name = "xrPageInfo1"
        Me.xrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.Number
        Me.xrPageInfo1.SizeF = New System.Drawing.SizeF(59.36804!, 34.86086!)
        Me.xrPageInfo1.StylePriority.UseBorders = False
        Me.xrPageInfo1.StylePriority.UseBorderWidth = False
        Me.xrPageInfo1.StylePriority.UseFont = False
        Me.xrPageInfo1.StylePriority.UseTextAlignment = False
        Me.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'lblversionsamit
        '
        Me.lblversionsamit.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.lblversionsamit.BorderWidth = 0.5!
        Me.lblversionsamit.Dpi = 254.0!
        Me.lblversionsamit.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblversionsamit.LocationFloat = New DevExpress.Utils.PointFloat(1129.965!, 0.0!)
        Me.lblversionsamit.Name = "lblversionsamit"
        Me.lblversionsamit.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.lblversionsamit.SizeF = New System.Drawing.SizeF(546.4667!, 34.85252!)
        Me.lblversionsamit.StylePriority.UseBorders = False
        Me.lblversionsamit.StylePriority.UseBorderWidth = False
        Me.lblversionsamit.StylePriority.UseFont = False
        Me.lblversionsamit.StylePriority.UseTextAlignment = False
        Me.lblversionsamit.Text = "lblversionsamit"
        Me.lblversionsamit.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'lblpc
        '
        Me.lblpc.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.lblpc.BorderWidth = 0.5!
        Me.lblpc.Dpi = 254.0!
        Me.lblpc.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpc.LocationFloat = New DevExpress.Utils.PointFloat(706.355!, 0.0!)
        Me.lblpc.Name = "lblpc"
        Me.lblpc.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.lblpc.SizeF = New System.Drawing.SizeF(423.6105!, 34.85242!)
        Me.lblpc.StylePriority.UseBorders = False
        Me.lblpc.StylePriority.UseBorderWidth = False
        Me.lblpc.StylePriority.UseFont = False
        Me.lblpc.StylePriority.UseTextAlignment = False
        Me.lblpc.Text = "lblpc"
        Me.lblpc.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'lblUsuario
        '
        Me.lblUsuario.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.lblUsuario.BorderWidth = 0.5!
        Me.lblUsuario.Dpi = 254.0!
        Me.lblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.LocationFloat = New DevExpress.Utils.PointFloat(339.6316!, 0.0!)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.lblUsuario.SizeF = New System.Drawing.SizeF(366.7236!, 34.85242!)
        Me.lblUsuario.StylePriority.UseBorders = False
        Me.lblUsuario.StylePriority.UseBorderWidth = False
        Me.lblUsuario.StylePriority.UseFont = False
        Me.lblUsuario.StylePriority.UseTextAlignment = False
        Me.lblUsuario.Text = "lblUsuario"
        Me.lblUsuario.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'lblpaginas
        '
        Me.lblpaginas.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.lblpaginas.BorderWidth = 0.5!
        Me.lblpaginas.Dpi = 254.0!
        Me.lblpaginas.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpaginas.LocationFloat = New DevExpress.Utils.PointFloat(1676.432!, 0.0!)
        Me.lblpaginas.Name = "lblpaginas"
        Me.lblpaginas.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.lblpaginas.SizeF = New System.Drawing.SizeF(176.0044!, 34.83543!)
        Me.lblpaginas.StylePriority.UseBorders = False
        Me.lblpaginas.StylePriority.UseBorderWidth = False
        Me.lblpaginas.StylePriority.UseFont = False
        Me.lblpaginas.StylePriority.UseTextAlignment = False
        Me.lblpaginas.Text = "Pagina"
        Me.lblpaginas.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'lblsigpag
        '
        Me.lblsigpag.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.lblsigpag.BorderWidth = 0.5!
        Me.lblsigpag.Dpi = 254.0!
        Me.lblsigpag.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsigpag.LocationFloat = New DevExpress.Utils.PointFloat(1911.805!, 0.0!)
        Me.lblsigpag.Name = "lblsigpag"
        Me.lblsigpag.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.lblsigpag.SizeF = New System.Drawing.SizeF(43.27625!, 34.81844!)
        Me.lblsigpag.StylePriority.UseBorders = False
        Me.lblsigpag.StylePriority.UseBorderWidth = False
        Me.lblsigpag.StylePriority.UseFont = False
        Me.lblsigpag.StylePriority.UseTextAlignment = False
        Me.lblsigpag.Text = "de"
        Me.lblsigpag.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'Fecha
        '
        Me.Fecha.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.Fecha.BorderWidth = 0.5!
        Me.Fecha.Dpi = 254.0!
        Me.Fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha.Format = "{0:MMM-dd-yyyy hh:mm tt}"
        Me.Fecha.LocationFloat = New DevExpress.Utils.PointFloat(10.55194!, 0.0!)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.Fecha.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.Fecha.SizeF = New System.Drawing.SizeF(329.0795!, 36.23166!)
        Me.Fecha.StylePriority.UseBorders = False
        Me.Fecha.StylePriority.UseBorderWidth = False
        Me.Fecha.StylePriority.UseFont = False
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lblTotales, Me.XrTable3, Me.XrTable2, Me.XrTable1})
        Me.ReportFooter.Dpi = 254.0!
        Me.ReportFooter.HeightF = 250.8261!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'lblTotales
        '
        Me.lblTotales.BackColor = System.Drawing.Color.LightGray
        Me.lblTotales.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblTotales.BorderWidth = 0.5!
        Me.lblTotales.Dpi = 254.0!
        Me.lblTotales.Font = New System.Drawing.Font("Segoe UI Semibold", 10.25!, System.Drawing.FontStyle.Bold)
        Me.lblTotales.LocationFloat = New DevExpress.Utils.PointFloat(1053.422!, 0.0!)
        Me.lblTotales.Name = "lblTotales"
        Me.lblTotales.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 254.0!)
        Me.lblTotales.SizeF = New System.Drawing.SizeF(954.1288!, 43.0!)
        Me.lblTotales.StylePriority.UseBackColor = False
        Me.lblTotales.StylePriority.UseBorders = False
        Me.lblTotales.StylePriority.UseBorderWidth = False
        Me.lblTotales.StylePriority.UseFont = False
        Me.lblTotales.StylePriority.UsePadding = False
        Me.lblTotales.StylePriority.UseTextAlignment = False
        Me.lblTotales.Text = "TOTALES"
        Me.lblTotales.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTable3
        '
        Me.XrTable3.BorderWidth = 0.5!
        Me.XrTable3.Dpi = 254.0!
        Me.XrTable3.LocationFloat = New DevExpress.Utils.PointFloat(1053.421!, 198.8696!)
        Me.XrTable3.Name = "XrTable3"
        Me.XrTable3.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 254.0!)
        Me.XrTable3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow2})
        Me.XrTable3.SizeF = New System.Drawing.SizeF(954.1298!, 51.95653!)
        Me.XrTable3.StylePriority.UseBorderWidth = False
        Me.XrTable3.StylePriority.UsePadding = False
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.lblTitleSumNetoPagar, Me.lblSumNetoPagar})
        Me.XrTableRow2.Dpi = 254.0!
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Weight = 1.0R
        '
        'lblTitleSumNetoPagar
        '
        Me.lblTitleSumNetoPagar.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.lblTitleSumNetoPagar.CanGrow = False
        Me.lblTitleSumNetoPagar.Dpi = 254.0!
        Me.lblTitleSumNetoPagar.Font = New System.Drawing.Font("Segoe UI Semibold", 10.25!, System.Drawing.FontStyle.Bold)
        Me.lblTitleSumNetoPagar.Name = "lblTitleSumNetoPagar"
        Me.lblTitleSumNetoPagar.StylePriority.UseBorders = False
        Me.lblTitleSumNetoPagar.StylePriority.UseFont = False
        Me.lblTitleSumNetoPagar.StylePriority.UseTextAlignment = False
        Me.lblTitleSumNetoPagar.Text = "Neto a Pagar : "
        Me.lblTitleSumNetoPagar.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.lblTitleSumNetoPagar.Weight = 0.542524739820098R
        '
        'lblSumNetoPagar
        '
        Me.lblSumNetoPagar.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblSumNetoPagar.CanGrow = False
        Me.lblSumNetoPagar.Dpi = 254.0!
        Me.lblSumNetoPagar.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSumNetoPagar.Name = "lblSumNetoPagar"
        Me.lblSumNetoPagar.StylePriority.UseBorders = False
        Me.lblSumNetoPagar.StylePriority.UseFont = False
        Me.lblSumNetoPagar.StylePriority.UseTextAlignment = False
        Me.lblSumNetoPagar.Text = "$ 0,00"
        Me.lblSumNetoPagar.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.lblSumNetoPagar.Weight = 0.5425253311797037R
        '
        'XrTable2
        '
        Me.XrTable2.BorderWidth = 0.5!
        Me.XrTable2.Dpi = 254.0!
        Me.XrTable2.LocationFloat = New DevExpress.Utils.PointFloat(1053.422!, 94.95651!)
        Me.XrTable2.Name = "XrTable2"
        Me.XrTable2.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 254.0!)
        Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1, Me.XrTableRow3})
        Me.XrTable2.SizeF = New System.Drawing.SizeF(954.1298!, 103.9131!)
        Me.XrTable2.StylePriority.UseBorderWidth = False
        Me.XrTable2.StylePriority.UsePadding = False
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.lblTitleTotalDeducciones, Me.lblTotalDeducciones})
        Me.XrTableRow1.Dpi = 254.0!
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Weight = 1.0R
        '
        'lblTitleTotalDeducciones
        '
        Me.lblTitleTotalDeducciones.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.lblTitleTotalDeducciones.CanGrow = False
        Me.lblTitleTotalDeducciones.Dpi = 254.0!
        Me.lblTitleTotalDeducciones.Font = New System.Drawing.Font("Segoe UI Semibold", 10.25!, System.Drawing.FontStyle.Bold)
        Me.lblTitleTotalDeducciones.Name = "lblTitleTotalDeducciones"
        Me.lblTitleTotalDeducciones.StylePriority.UseBorders = False
        Me.lblTitleTotalDeducciones.StylePriority.UseFont = False
        Me.lblTitleTotalDeducciones.StylePriority.UseTextAlignment = False
        Me.lblTitleTotalDeducciones.Text = "Deducciones : "
        Me.lblTitleTotalDeducciones.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.lblTitleTotalDeducciones.Weight = 0.542524739820098R
        '
        'lblTotalDeducciones
        '
        Me.lblTotalDeducciones.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblTotalDeducciones.CanGrow = False
        Me.lblTotalDeducciones.Dpi = 254.0!
        Me.lblTotalDeducciones.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalDeducciones.Name = "lblTotalDeducciones"
        Me.lblTotalDeducciones.StylePriority.UseBorders = False
        Me.lblTotalDeducciones.StylePriority.UseFont = False
        Me.lblTotalDeducciones.StylePriority.UseTextAlignment = False
        Me.lblTotalDeducciones.Text = "$ 0,00"
        Me.lblTotalDeducciones.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.lblTotalDeducciones.Weight = 0.5425253311797037R
        '
        'XrTable1
        '
        Me.XrTable1.BorderWidth = 0.5!
        Me.XrTable1.Dpi = 254.0!
        Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(1053.422!, 42.99997!)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 254.0!)
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow8})
        Me.XrTable1.SizeF = New System.Drawing.SizeF(954.1298!, 51.95656!)
        Me.XrTable1.StylePriority.UseBorderWidth = False
        Me.XrTable1.StylePriority.UsePadding = False
        '
        'XrTableRow8
        '
        Me.XrTableRow8.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.lblTitleTotalIngreso, Me.lblTotalIngresos})
        Me.XrTableRow8.Dpi = 254.0!
        Me.XrTableRow8.Name = "XrTableRow8"
        Me.XrTableRow8.Weight = 1.0R
        '
        'lblTitleTotalIngreso
        '
        Me.lblTitleTotalIngreso.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.lblTitleTotalIngreso.CanGrow = False
        Me.lblTitleTotalIngreso.Dpi = 254.0!
        Me.lblTitleTotalIngreso.Font = New System.Drawing.Font("Segoe UI Semibold", 10.25!, System.Drawing.FontStyle.Bold)
        Me.lblTitleTotalIngreso.Name = "lblTitleTotalIngreso"
        Me.lblTitleTotalIngreso.StylePriority.UseBorders = False
        Me.lblTitleTotalIngreso.StylePriority.UseFont = False
        Me.lblTitleTotalIngreso.StylePriority.UseTextAlignment = False
        Me.lblTitleTotalIngreso.Text = "Ingresos : "
        Me.lblTitleTotalIngreso.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.lblTitleTotalIngreso.Weight = 0.542524739820098R
        '
        'lblTotalIngresos
        '
        Me.lblTotalIngresos.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblTotalIngresos.CanGrow = False
        Me.lblTotalIngresos.Dpi = 254.0!
        Me.lblTotalIngresos.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalIngresos.Name = "lblTotalIngresos"
        Me.lblTotalIngresos.StylePriority.UseBorders = False
        Me.lblTotalIngresos.StylePriority.UseFont = False
        Me.lblTotalIngresos.StylePriority.UseTextAlignment = False
        Me.lblTotalIngresos.Text = "$ 0,00"
        Me.lblTotalIngresos.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.lblTotalIngresos.Weight = 0.5425253311797037R
        '
        'lblTitleDescuentos
        '
        Me.lblTitleDescuentos.BackColor = System.Drawing.Color.LightGray
        Me.lblTitleDescuentos.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblTitleDescuentos.BorderWidth = 0.5!
        Me.lblTitleDescuentos.Dpi = 254.0!
        Me.lblTitleDescuentos.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitleDescuentos.LocationFloat = New DevExpress.Utils.PointFloat(1530.69!, 25.00001!)
        Me.lblTitleDescuentos.Name = "lblTitleDescuentos"
        Me.lblTitleDescuentos.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 254.0!)
        Me.lblTitleDescuentos.SizeF = New System.Drawing.SizeF(238.4303!, 43.0!)
        Me.lblTitleDescuentos.StylePriority.UseBackColor = False
        Me.lblTitleDescuentos.StylePriority.UseBorders = False
        Me.lblTitleDescuentos.StylePriority.UseBorderWidth = False
        Me.lblTitleDescuentos.StylePriority.UseFont = False
        Me.lblTitleDescuentos.StylePriority.UsePadding = False
        Me.lblTitleDescuentos.StylePriority.UseTextAlignment = False
        Me.lblTitleDescuentos.Text = "Descuentos"
        Me.lblTitleDescuentos.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'lblDescuentos
        '
        Me.lblDescuentos.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblDescuentos.CanGrow = False
        Me.lblDescuentos.Dpi = 254.0!
        Me.lblDescuentos.Font = New System.Drawing.Font("Arial Narrow", 9.0!)
        Me.lblDescuentos.Name = "lblDescuentos"
        Me.lblDescuentos.StylePriority.UseBorders = False
        Me.lblDescuentos.StylePriority.UseFont = False
        Me.lblDescuentos.StylePriority.UseTextAlignment = False
        Me.lblDescuentos.Text = "- $ 0,00"
        Me.lblDescuentos.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.lblDescuentos.Weight = 0.630191897056722R
        '
        'XrTableRow3
        '
        Me.XrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.lblTitleTotalDescuentos, Me.lblTotalDescuentos})
        Me.XrTableRow3.Dpi = 254.0!
        Me.XrTableRow3.Name = "XrTableRow3"
        Me.XrTableRow3.Weight = 1.0R
        '
        'lblTitleTotalDescuentos
        '
        Me.lblTitleTotalDescuentos.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.lblTitleTotalDescuentos.Dpi = 254.0!
        Me.lblTitleTotalDescuentos.Font = New System.Drawing.Font("Segoe UI Semibold", 10.25!, System.Drawing.FontStyle.Bold)
        Me.lblTitleTotalDescuentos.Name = "lblTitleTotalDescuentos"
        Me.lblTitleTotalDescuentos.StylePriority.UseBorders = False
        Me.lblTitleTotalDescuentos.StylePriority.UseFont = False
        Me.lblTitleTotalDescuentos.StylePriority.UseTextAlignment = False
        Me.lblTitleTotalDescuentos.Text = "Descuentos : "
        Me.lblTitleTotalDescuentos.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.lblTitleTotalDescuentos.Weight = 0.542524739820098R
        '
        'lblTotalDescuentos
        '
        Me.lblTotalDescuentos.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblTotalDescuentos.Dpi = 254.0!
        Me.lblTotalDescuentos.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalDescuentos.Name = "lblTotalDescuentos"
        Me.lblTotalDescuentos.StylePriority.UseBorders = False
        Me.lblTotalDescuentos.StylePriority.UseFont = False
        Me.lblTotalDescuentos.StylePriority.UseTextAlignment = False
        Me.lblTotalDescuentos.Text = "$ 0,00"
        Me.lblTotalDescuentos.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.lblTotalDescuentos.Weight = 0.5425253311797037R
        '
        'RptNominasXperiodo
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.PageHeader, Me.PageFooter, Me.ReportFooter})
        Me.Dpi = 254.0!
        Me.Margins = New System.Drawing.Printing.Margins(70, 70, 50, 35)
        Me.PageHeight = 1397
        Me.PageWidth = 2159
        Me.PaperKind = System.Drawing.Printing.PaperKind.Custom
        Me.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.Version = "15.2"
        CType(Me.tablaFamiliares, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tablaCabecera1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Private WithEvents xrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
    Private WithEvents xrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents lblversionsamit As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblpc As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblUsuario As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents lblpaginas As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents lblsigpag As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Fecha As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents pcbImg As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents tablaCabecera1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents f1Cab1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents lblNomEmp As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents f2Cab1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents lblNitEmp As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents f3Cab1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents lblOficina As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents f4Cab1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents LblDireccionEmpresa As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblTitleIngresos As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblTitleNombres As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblTitleDocEmp As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblTitleDeducciones As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblTitulo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents tablaFamiliares As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents Fila1FM As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents lblNumContra As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblDocEmp As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblDeducciones As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblNetoApagar As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow8 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents lblTitleTotalIngreso As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblTotalIngresos As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblNombres As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblTitleNetoApagar As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblTitleNumContra As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents lblTitleTotalDeducciones As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblTotalDeducciones As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblTotales As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblTituloFijo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblIngresos As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable3 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents lblTitleSumNetoPagar As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblSumNetoPagar As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblDescuentos As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblTitleDescuentos As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTableRow3 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents lblTitleTotalDescuentos As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblTotalDescuentos As DevExpress.XtraReports.UI.XRTableCell
End Class
