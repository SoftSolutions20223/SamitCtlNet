<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class RptDetallesConceptos
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
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.lblTituloFijo = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblTitulo = New DevExpress.XtraReports.UI.XRLabel()
        Me.tablaCabecera1 = New DevExpress.XtraReports.UI.XRTable()
        Me.f1Cab1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.lblNomEmp = New DevExpress.XtraReports.UI.XRTableCell()
        Me.f2Cab1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.lblNitEmp = New DevExpress.XtraReports.UI.XRTableCell()
        Me.f3Cab1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.lblOficina = New DevExpress.XtraReports.UI.XRTableCell()
        Me.f4Cab1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.LblDireccionEmpresa = New DevExpress.XtraReports.UI.XRTableCell()
        Me.pcbImg = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.Fecha = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.lblsigpag = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblpaginas = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblUsuario = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblpc = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblversionsamit = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.xrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.tablaFamiliares = New DevExpress.XtraReports.UI.XRTable()
        Me.Fila1FM = New DevExpress.XtraReports.UI.XRTableRow()
        Me.lblNumContrato = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lblNombres = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lblBase = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lblTotal = New DevExpress.XtraReports.UI.XRTableCell()
        Me.drDatosInforme = New DevExpress.XtraReports.UI.DetailReportBand()
        Me.dbDatos = New DevExpress.XtraReports.UI.DetailBand()
        Me.ghAgrupadoXTipoConcepto = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.lblNomConcepto = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblnombre1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.rhInformeAgrupado = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.lblTitleTotal = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblTitleNombres = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblTitleNumContrato = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblTitleBase = New DevExpress.XtraReports.UI.XRLabel()
        Me.gfAgrupadoXTipoConcepto = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow9 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.lblTitleTotalPagar = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lblTotalPagar = New DevExpress.XtraReports.UI.XRTableCell()
        CType(Me.tablaCabecera1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tablaFamiliares, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Dpi = 254.0!
        Me.Detail.Expanded = False
        Me.Detail.HeightF = 44.96!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
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
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lblTituloFijo, Me.lblTitulo, Me.tablaCabecera1, Me.pcbImg})
        Me.ReportHeader.Dpi = 254.0!
        Me.ReportHeader.HeightF = 380.4739!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'lblTituloFijo
        '
        Me.lblTituloFijo.Dpi = 254.0!
        Me.lblTituloFijo.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloFijo.LocationFloat = New DevExpress.Utils.PointFloat(12.5!, 304.5331!)
        Me.lblTituloFijo.Name = "lblTituloFijo"
        Me.lblTituloFijo.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.lblTituloFijo.SizeF = New System.Drawing.SizeF(1997.0!, 57.42004!)
        Me.lblTituloFijo.StylePriority.UseFont = False
        Me.lblTituloFijo.StylePriority.UseTextAlignment = False
        Me.lblTituloFijo.Text = "Informe Concepto"
        Me.lblTituloFijo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'lblTitulo
        '
        Me.lblTitulo.Dpi = 254.0!
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.LocationFloat = New DevExpress.Utils.PointFloat(12.5!, 222.6997!)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.lblTitulo.SizeF = New System.Drawing.SizeF(1997.0!, 58.42004!)
        Me.lblTitulo.StylePriority.UseFont = False
        Me.lblTitulo.StylePriority.UseTextAlignment = False
        Me.lblTitulo.Text = "Nóminas {0} del periodo comprendido entre {0} y {0}"
        Me.lblTitulo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'tablaCabecera1
        '
        Me.tablaCabecera1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.tablaCabecera1.Dpi = 254.0!
        Me.tablaCabecera1.LocationFloat = New DevExpress.Utils.PointFloat(279.0!, 11.12501!)
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
        'pcbImg
        '
        Me.pcbImg.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.pcbImg.Dpi = 254.0!
        Me.pcbImg.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.MiddleCenter
        Me.pcbImg.LocationFloat = New DevExpress.Utils.PointFloat(25.00001!, 11.12501!)
        Me.pcbImg.Name = "pcbImg"
        Me.pcbImg.SizeF = New System.Drawing.SizeF(254.0!, 200.0!)
        Me.pcbImg.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze
        Me.pcbImg.StylePriority.UseBorders = False
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Fecha, Me.lblsigpag, Me.lblpaginas, Me.lblUsuario, Me.lblpc, Me.lblversionsamit, Me.xrPageInfo1, Me.xrPageInfo2})
        Me.PageFooter.Dpi = 254.0!
        Me.PageFooter.HeightF = 50.27083!
        Me.PageFooter.Name = "PageFooter"
        '
        'Fecha
        '
        Me.Fecha.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.Fecha.BorderWidth = 0.5!
        Me.Fecha.Dpi = 254.0!
        Me.Fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha.Format = "{0:MMM-dd-yyyy hh:mm tt}"
        Me.Fecha.LocationFloat = New DevExpress.Utils.PointFloat(10.99994!, 0.0!)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.Fecha.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.Fecha.SizeF = New System.Drawing.SizeF(329.0795!, 36.23166!)
        Me.Fecha.StylePriority.UseBorders = False
        Me.Fecha.StylePriority.UseBorderWidth = False
        Me.Fecha.StylePriority.UseFont = False
        '
        'lblsigpag
        '
        Me.lblsigpag.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.lblsigpag.BorderWidth = 0.5!
        Me.lblsigpag.Dpi = 254.0!
        Me.lblsigpag.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsigpag.LocationFloat = New DevExpress.Utils.PointFloat(1912.253!, 0.0!)
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
        'lblpaginas
        '
        Me.lblpaginas.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.lblpaginas.BorderWidth = 0.5!
        Me.lblpaginas.Dpi = 254.0!
        Me.lblpaginas.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpaginas.LocationFloat = New DevExpress.Utils.PointFloat(1676.88!, 0.0!)
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
        'lblUsuario
        '
        Me.lblUsuario.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.lblUsuario.BorderWidth = 0.5!
        Me.lblUsuario.Dpi = 254.0!
        Me.lblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.LocationFloat = New DevExpress.Utils.PointFloat(340.0796!, 0.0!)
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
        'lblpc
        '
        Me.lblpc.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.lblpc.BorderWidth = 0.5!
        Me.lblpc.Dpi = 254.0!
        Me.lblpc.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpc.LocationFloat = New DevExpress.Utils.PointFloat(706.803!, 0.0!)
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
        'lblversionsamit
        '
        Me.lblversionsamit.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.lblversionsamit.BorderWidth = 0.5!
        Me.lblversionsamit.Dpi = 254.0!
        Me.lblversionsamit.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblversionsamit.LocationFloat = New DevExpress.Utils.PointFloat(1130.413!, 0.0!)
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
        'xrPageInfo1
        '
        Me.xrPageInfo1.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.xrPageInfo1.BorderWidth = 0.5!
        Me.xrPageInfo1.Dpi = 254.0!
        Me.xrPageInfo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(1852.885!, 0.0!)
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
        'xrPageInfo2
        '
        Me.xrPageInfo2.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.xrPageInfo2.BorderWidth = 0.5!
        Me.xrPageInfo2.Dpi = 254.0!
        Me.xrPageInfo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(1955.529!, 0.0!)
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
        'tablaFamiliares
        '
        Me.tablaFamiliares.BorderWidth = 0.5!
        Me.tablaFamiliares.Dpi = 254.0!
        Me.tablaFamiliares.LocationFloat = New DevExpress.Utils.PointFloat(10.99993!, 0.0!)
        Me.tablaFamiliares.Name = "tablaFamiliares"
        Me.tablaFamiliares.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 254.0!)
        Me.tablaFamiliares.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.Fila1FM})
        Me.tablaFamiliares.SizeF = New System.Drawing.SizeF(1997.0!, 41.96!)
        Me.tablaFamiliares.StylePriority.UseBorderWidth = False
        Me.tablaFamiliares.StylePriority.UsePadding = False
        '
        'Fila1FM
        '
        Me.Fila1FM.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.lblNumContrato, Me.lblNombres, Me.lblBase, Me.lblTotal})
        Me.Fila1FM.Dpi = 254.0!
        Me.Fila1FM.Name = "Fila1FM"
        Me.Fila1FM.Weight = 1.0R
        '
        'lblNumContrato
        '
        Me.lblNumContrato.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblNumContrato.CanGrow = False
        Me.lblNumContrato.Dpi = 254.0!
        Me.lblNumContrato.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumContrato.Name = "lblNumContrato"
        Me.lblNumContrato.StylePriority.UseBorders = False
        Me.lblNumContrato.StylePriority.UseFont = False
        Me.lblNumContrato.StylePriority.UseTextAlignment = False
        Me.lblNumContrato.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.lblNumContrato.Weight = 0.50163176858010428R
        '
        'lblNombres
        '
        Me.lblNombres.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblNombres.Dpi = 254.0!
        Me.lblNombres.Font = New System.Drawing.Font("Times New Roman", 8.75!)
        Me.lblNombres.Name = "lblNombres"
        Me.lblNombres.StylePriority.UseBorders = False
        Me.lblNombres.StylePriority.UseFont = False
        Me.lblNombres.Text = "Nombres"
        Me.lblNombres.Weight = 3.2217063820779361R
        '
        'lblBase
        '
        Me.lblBase.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblBase.Dpi = 254.0!
        Me.lblBase.Font = New System.Drawing.Font("Times New Roman", 8.75!)
        Me.lblBase.Name = "lblBase"
        Me.lblBase.StylePriority.UseBorders = False
        Me.lblBase.StylePriority.UseFont = False
        Me.lblBase.Weight = 0.67050858172132743R
        '
        'lblTotal
        '
        Me.lblTotal.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblTotal.Dpi = 254.0!
        Me.lblTotal.Font = New System.Drawing.Font("Arial Narrow", 9.0!)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.StylePriority.UseBorders = False
        Me.lblTotal.StylePriority.UseFont = False
        Me.lblTotal.StylePriority.UseTextAlignment = False
        Me.lblTotal.Text = "$ 0,00"
        Me.lblTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.lblTotal.Weight = 1.0892936507655282R
        '
        'drDatosInforme
        '
        Me.drDatosInforme.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.dbDatos, Me.ghAgrupadoXTipoConcepto, Me.rhInformeAgrupado, Me.gfAgrupadoXTipoConcepto})
        Me.drDatosInforme.Dpi = 254.0!
        Me.drDatosInforme.Level = 0
        Me.drDatosInforme.Name = "drDatosInforme"
        '
        'dbDatos
        '
        Me.dbDatos.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.tablaFamiliares})
        Me.dbDatos.Dpi = 254.0!
        Me.dbDatos.HeightF = 41.96!
        Me.dbDatos.Name = "dbDatos"
        '
        'ghAgrupadoXTipoConcepto
        '
        Me.ghAgrupadoXTipoConcepto.BackColor = System.Drawing.Color.DarkGray
        Me.ghAgrupadoXTipoConcepto.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lblNomConcepto, Me.lblnombre1})
        Me.ghAgrupadoXTipoConcepto.Dpi = 254.0!
        Me.ghAgrupadoXTipoConcepto.HeightF = 63.83066!
        Me.ghAgrupadoXTipoConcepto.Name = "ghAgrupadoXTipoConcepto"
        Me.ghAgrupadoXTipoConcepto.StylePriority.UseBackColor = False
        '
        'lblNomConcepto
        '
        Me.lblNomConcepto.CanGrow = False
        Me.lblNomConcepto.Dpi = 254.0!
        Me.lblNomConcepto.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomConcepto.LocationFloat = New DevExpress.Utils.PointFloat(41.3457!, 8.999979!)
        Me.lblNomConcepto.Name = "lblNomConcepto"
        Me.lblNomConcepto.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.lblNomConcepto.SizeF = New System.Drawing.SizeF(298.7337!, 43.3917!)
        Me.lblNomConcepto.StylePriority.UseFont = False
        Me.lblNomConcepto.StylePriority.UseTextAlignment = False
        Me.lblNomConcepto.Text = "Concepto : "
        Me.lblNomConcepto.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'lblnombre1
        '
        Me.lblnombre1.CanGrow = False
        Me.lblnombre1.Dpi = 254.0!
        Me.lblnombre1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombre1.LocationFloat = New DevExpress.Utils.PointFloat(340.0796!, 8.999979!)
        Me.lblnombre1.Name = "lblnombre1"
        Me.lblnombre1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.lblnombre1.SizeF = New System.Drawing.SizeF(1669.421!, 43.3917!)
        Me.lblnombre1.StylePriority.UseFont = False
        Me.lblnombre1.StylePriority.UseTextAlignment = False
        Me.lblnombre1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'rhInformeAgrupado
        '
        Me.rhInformeAgrupado.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lblTitleTotal, Me.lblTitleNombres, Me.lblTitleNumContrato, Me.lblTitleBase})
        Me.rhInformeAgrupado.Dpi = 254.0!
        Me.rhInformeAgrupado.HeightF = 43.0!
        Me.rhInformeAgrupado.Name = "rhInformeAgrupado"
        '
        'lblTitleTotal
        '
        Me.lblTitleTotal.BackColor = System.Drawing.Color.LightGray
        Me.lblTitleTotal.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblTitleTotal.BorderWidth = 0.5!
        Me.lblTitleTotal.Dpi = 254.0!
        Me.lblTitleTotal.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleTotal.LocationFloat = New DevExpress.Utils.PointFloat(1611.271!, 0.0!)
        Me.lblTitleTotal.Name = "lblTitleTotal"
        Me.lblTitleTotal.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 254.0!)
        Me.lblTitleTotal.SizeF = New System.Drawing.SizeF(396.7291!, 43.0!)
        Me.lblTitleTotal.StylePriority.UseBackColor = False
        Me.lblTitleTotal.StylePriority.UseBorders = False
        Me.lblTitleTotal.StylePriority.UseBorderWidth = False
        Me.lblTitleTotal.StylePriority.UseFont = False
        Me.lblTitleTotal.StylePriority.UsePadding = False
        Me.lblTitleTotal.StylePriority.UseTextAlignment = False
        Me.lblTitleTotal.Text = "Total"
        Me.lblTitleTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'lblTitleNombres
        '
        Me.lblTitleNombres.BackColor = System.Drawing.Color.LightGray
        Me.lblTitleNombres.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblTitleNombres.BorderWidth = 0.5!
        Me.lblTitleNombres.Dpi = 254.0!
        Me.lblTitleNombres.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleNombres.LocationFloat = New DevExpress.Utils.PointFloat(193.6979!, 0.0!)
        Me.lblTitleNombres.Name = "lblTitleNombres"
        Me.lblTitleNombres.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 254.0!)
        Me.lblTitleNombres.SizeF = New System.Drawing.SizeF(1173.369!, 42.99993!)
        Me.lblTitleNombres.StylePriority.UseBackColor = False
        Me.lblTitleNombres.StylePriority.UseBorders = False
        Me.lblTitleNombres.StylePriority.UseBorderWidth = False
        Me.lblTitleNombres.StylePriority.UseFont = False
        Me.lblTitleNombres.StylePriority.UsePadding = False
        Me.lblTitleNombres.StylePriority.UseTextAlignment = False
        Me.lblTitleNombres.Text = "Empleado"
        Me.lblTitleNombres.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'lblTitleNumContrato
        '
        Me.lblTitleNumContrato.BackColor = System.Drawing.Color.LightGray
        Me.lblTitleNumContrato.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblTitleNumContrato.BorderWidth = 0.5!
        Me.lblTitleNumContrato.Dpi = 254.0!
        Me.lblTitleNumContrato.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleNumContrato.LocationFloat = New DevExpress.Utils.PointFloat(11.0!, 0.0!)
        Me.lblTitleNumContrato.Name = "lblTitleNumContrato"
        Me.lblTitleNumContrato.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 254.0!)
        Me.lblTitleNumContrato.SizeF = New System.Drawing.SizeF(182.6979!, 42.99993!)
        Me.lblTitleNumContrato.StylePriority.UseBackColor = False
        Me.lblTitleNumContrato.StylePriority.UseBorders = False
        Me.lblTitleNumContrato.StylePriority.UseBorderWidth = False
        Me.lblTitleNumContrato.StylePriority.UseFont = False
        Me.lblTitleNumContrato.StylePriority.UsePadding = False
        Me.lblTitleNumContrato.StylePriority.UseTextAlignment = False
        Me.lblTitleNumContrato.Text = "Contrato"
        Me.lblTitleNumContrato.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'lblTitleBase
        '
        Me.lblTitleBase.BackColor = System.Drawing.Color.LightGray
        Me.lblTitleBase.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblTitleBase.BorderWidth = 0.5!
        Me.lblTitleBase.Dpi = 254.0!
        Me.lblTitleBase.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleBase.LocationFloat = New DevExpress.Utils.PointFloat(1367.067!, 0.0!)
        Me.lblTitleBase.Name = "lblTitleBase"
        Me.lblTitleBase.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 254.0!)
        Me.lblTitleBase.SizeF = New System.Drawing.SizeF(244.2045!, 43.0!)
        Me.lblTitleBase.StylePriority.UseBackColor = False
        Me.lblTitleBase.StylePriority.UseBorders = False
        Me.lblTitleBase.StylePriority.UseBorderWidth = False
        Me.lblTitleBase.StylePriority.UseFont = False
        Me.lblTitleBase.StylePriority.UsePadding = False
        Me.lblTitleBase.StylePriority.UseTextAlignment = False
        Me.lblTitleBase.Text = "Base"
        Me.lblTitleBase.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'gfAgrupadoXTipoConcepto
        '
        Me.gfAgrupadoXTipoConcepto.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable2})
        Me.gfAgrupadoXTipoConcepto.Dpi = 254.0!
        Me.gfAgrupadoXTipoConcepto.HeightF = 34.12!
        Me.gfAgrupadoXTipoConcepto.Name = "gfAgrupadoXTipoConcepto"
        '
        'XrTable2
        '
        Me.XrTable2.BorderWidth = 0.5!
        Me.XrTable2.Dpi = 254.0!
        Me.XrTable2.LocationFloat = New DevExpress.Utils.PointFloat(984.2201!, 0.0!)
        Me.XrTable2.Name = "XrTable2"
        Me.XrTable2.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 254.0!)
        Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow9})
        Me.XrTable2.SizeF = New System.Drawing.SizeF(1025.28!, 34.12!)
        Me.XrTable2.StylePriority.UseBorderWidth = False
        Me.XrTable2.StylePriority.UsePadding = False
        '
        'XrTableRow9
        '
        Me.XrTableRow9.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.lblTitleTotalPagar, Me.lblTotalPagar})
        Me.XrTableRow9.Dpi = 254.0!
        Me.XrTableRow9.Name = "XrTableRow9"
        Me.XrTableRow9.Weight = 1.0R
        '
        'lblTitleTotalPagar
        '
        Me.lblTitleTotalPagar.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.lblTitleTotalPagar.CanGrow = False
        Me.lblTitleTotalPagar.Dpi = 254.0!
        Me.lblTitleTotalPagar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleTotalPagar.Name = "lblTitleTotalPagar"
        Me.lblTitleTotalPagar.StylePriority.UseBorders = False
        Me.lblTitleTotalPagar.StylePriority.UseFont = False
        Me.lblTitleTotalPagar.StylePriority.UseTextAlignment = False
        Me.lblTitleTotalPagar.Text = "TOTAL POR : "
        Me.lblTitleTotalPagar.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.lblTitleTotalPagar.Weight = 0.645252301705859R
        '
        'lblTotalPagar
        '
        Me.lblTotalPagar.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblTotalPagar.Dpi = 254.0!
        Me.lblTotalPagar.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.lblTotalPagar.Name = "lblTotalPagar"
        Me.lblTotalPagar.StylePriority.UseBorders = False
        Me.lblTotalPagar.StylePriority.UseFont = False
        Me.lblTotalPagar.StylePriority.UseTextAlignment = False
        Me.lblTotalPagar.Text = "$ 0,00"
        Me.lblTotalPagar.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.lblTotalPagar.Weight = 0.40978870422015512R
        '
        'RptDetallesConceptos
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.PageFooter, Me.drDatosInforme})
        Me.Dpi = 254.0!
        Me.Margins = New System.Drawing.Printing.Margins(70, 70, 50, 35)
        Me.PageHeight = 1397
        Me.PageWidth = 2159
        Me.PaperKind = System.Drawing.Printing.PaperKind.Custom
        Me.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.Version = "15.2"
        CType(Me.tablaCabecera1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tablaFamiliares, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents tablaCabecera1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents f1Cab1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents lblNomEmp As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents f2Cab1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents lblNitEmp As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents f3Cab1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents lblOficina As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents f4Cab1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents LblDireccionEmpresa As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents pcbImg As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents Fecha As DevExpress.XtraReports.UI.XRPageInfo
    Private WithEvents lblsigpag As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents lblpaginas As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblUsuario As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblpc As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblversionsamit As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Private WithEvents xrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents tablaFamiliares As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents Fila1FM As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents lblNumContrato As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblNombres As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblTotal As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblTitulo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblBase As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents drDatosInforme As DevExpress.XtraReports.UI.DetailReportBand
    Friend WithEvents dbDatos As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents ghAgrupadoXTipoConcepto As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents rhInformeAgrupado As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents lblTitleTotal As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblTitleNombres As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblTitleNumContrato As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblTitleBase As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblNomConcepto As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblnombre1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents gfAgrupadoXTipoConcepto As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow9 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents lblTitleTotalPagar As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblTotalPagar As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblTituloFijo As DevExpress.XtraReports.UI.XRLabel
End Class
