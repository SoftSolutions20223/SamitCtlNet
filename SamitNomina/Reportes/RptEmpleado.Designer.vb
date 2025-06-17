<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class RptEmpleado
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
        Me.dbDatosBasicos = New DevExpress.XtraReports.UI.DetailBand()
        Me.lblTitleDatosBasicos = New DevExpress.XtraReports.UI.XRLabel()
        Me.lineAbjDatosBasicos = New DevExpress.XtraReports.UI.XRLine()
        Me.lineDerDatosBasicos = New DevExpress.XtraReports.UI.XRLine()
        Me.TablaDatosBasicos = New DevExpress.XtraReports.UI.XRTable()
        Me.fila1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.lblTitlePapellido = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lblTitleSapellido = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lblTitleNombres = New DevExpress.XtraReports.UI.XRTableCell()
        Me.fila2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.lblPApellido = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lblSApellido = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lblNombres = New DevExpress.XtraReports.UI.XRTableCell()
        Me.fila3 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.lblTitleDocuemntoId = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lblTitleSexo = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lblTitleEstCivil = New DevExpress.XtraReports.UI.XRTableCell()
        Me.fila4 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.lblTitleTipoDoc = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lblTipoDoc = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lblTitleNumDoc = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lblNumDoc = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lblSexo = New DevExpress.XtraReports.UI.XRTableCell()
        Me.ckbFemenino = New DevExpress.XtraReports.UI.XRCheckBox()
        Me.ckbMasculino = New DevExpress.XtraReports.UI.XRCheckBox()
        Me.lblEstCivil = New DevExpress.XtraReports.UI.XRTableCell()
        Me.fila5 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.lblTitleLibretaMilitar = New DevExpress.XtraReports.UI.XRTableCell()
        Me.fila6 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.lblLibPrimera = New DevExpress.XtraReports.UI.XRTableCell()
        Me.ckbLibPrimera = New DevExpress.XtraReports.UI.XRCheckBox()
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.ckbLibSegunda = New DevExpress.XtraReports.UI.XRCheckBox()
        Me.lblLibSegunda = New DevExpress.XtraReports.UI.XRTableCell()
        Me.ckbNoLibreta = New DevExpress.XtraReports.UI.XRCheckBox()
        Me.lblTitleNumLibreta = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lblNumLibreta = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lblTitleDM = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lblDM = New DevExpress.XtraReports.UI.XRTableCell()
        Me.fila7 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.lblTitleCelular = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lblTitleTelefoonos = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lblTitleCorreo = New DevExpress.XtraReports.UI.XRTableCell()
        Me.fila8 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.lblCelular = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lblTelefonos = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lblCorreo = New DevExpress.XtraReports.UI.XRTableCell()
        Me.fila9 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.lblTitleFechaLugarNac = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lblDireccionResidencia = New DevExpress.XtraReports.UI.XRTableCell()
        Me.fila10 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.lblTitleFechaNac = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lblFechaNac = New DevExpress.XtraReports.UI.XRTableCell()
        Me.LblDireccionEmpleado = New DevExpress.XtraReports.UI.XRTableCell()
        Me.fila11 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.lblTitlePaisNac = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lblPaisNac = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lblTitlePaisResidencia = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lblPaisResidencia = New DevExpress.XtraReports.UI.XRTableCell()
        Me.fila12 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.lblTitleDepNac = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lblDepNac = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lblTitleDepResidencia = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lblDepResidencia = New DevExpress.XtraReports.UI.XRTableCell()
        Me.fila13 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.lblTitleMuniNac = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lblMuniNac = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lblTitleMuniResidencia = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lblMuniResidencia = New DevExpress.XtraReports.UI.XRTableCell()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
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
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.lblTituloInforme = New DevExpress.XtraReports.UI.XRLabel()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.xrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.xrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.lbversionsamit = New DevExpress.XtraReports.UI.XRLabel()
        Me.lbpc = New DevExpress.XtraReports.UI.XRLabel()
        Me.lbreviso = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblpaginas = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblsigpag = New DevExpress.XtraReports.UI.XRLabel()
        Me.Fecha = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrControlStyle1 = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.drInfAcademica = New DevExpress.XtraReports.UI.DetailReportBand()
        Me.dbInfAcademica = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.drEducacionNoformal = New DevExpress.XtraReports.UI.DetailReportBand()
        Me.dbEducacionNoFormal = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.lblNivelEF = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lblDescripcionEF = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lblInstitucionEF = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lblFechaTermancionEF = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lblDuracionEF = New DevExpress.XtraReports.UI.XRTableCell()
        Me.rhEducacionNoFormal = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.lblTitleNivelEF = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblTitleDuracionEF = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblTitleFechaTerminoEF = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblTitleInstitucionEF = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblTitleDescripcionEF = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.drExpLaboral = New DevExpress.XtraReports.UI.DetailReportBand()
        Me.dbExpLaboral = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.drFamiliares = New DevExpress.XtraReports.UI.DetailReportBand()
        Me.dbFamiliares = New DevExpress.XtraReports.UI.DetailBand()
        Me.tablaFamiliares = New DevExpress.XtraReports.UI.XRTable()
        Me.Fila1FM = New DevExpress.XtraReports.UI.XRTableRow()
        Me.lblTipoDocFM = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lblDocFamiliar = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lblNombreFamiliar = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lblParentesco = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lblFechaNacFamiliar = New DevExpress.XtraReports.UI.XRTableCell()
        Me.rhFamiliares = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.lblTiuloFamiliares = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblTitleDocFamiliarFM = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblTitleNomFamiliarFM = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblTitleParentescoFM = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblTitleFecNacFM = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblTitleTipoDocFM = New DevExpress.XtraReports.UI.XRLabel()
        Me.drAfiliaciones = New DevExpress.XtraReports.UI.DetailReportBand()
        Me.dbAfiliaciones = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.lblEntidad = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lblFecRegistroAF = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lblRetiradoAF = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lblFecRetiroAF = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lblCausaRetiroAF = New DevExpress.XtraReports.UI.XRTableCell()
        Me.rhAfiliaciones = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.lblTitleEntidadAF = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblTitleCausaRetiro = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblTitleFechaRetiro = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblTitleRetirado = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblTitleFechaRegistro = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblTituloAfiliaciones = New DevExpress.XtraReports.UI.XRLabel()
        CType(Me.TablaDatosBasicos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tablaCabecera1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tablaFamiliares, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'dbDatosBasicos
        '
        Me.dbDatosBasicos.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lblTitleDatosBasicos, Me.lineAbjDatosBasicos, Me.lineDerDatosBasicos, Me.TablaDatosBasicos})
        Me.dbDatosBasicos.Dpi = 254.0!
        Me.dbDatosBasicos.HeightF = 904.4016!
        Me.dbDatosBasicos.Name = "dbDatosBasicos"
        Me.dbDatosBasicos.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.dbDatosBasicos.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'lblTitleDatosBasicos
        '
        Me.lblTitleDatosBasicos.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblTitleDatosBasicos.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.lblTitleDatosBasicos.BorderWidth = 0.5!
        Me.lblTitleDatosBasicos.Dpi = 254.0!
        Me.lblTitleDatosBasicos.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleDatosBasicos.LocationFloat = New DevExpress.Utils.PointFloat(24.99998!, 22.0!)
        Me.lblTitleDatosBasicos.Name = "lblTitleDatosBasicos"
        Me.lblTitleDatosBasicos.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 5, 254.0!)
        Me.lblTitleDatosBasicos.SizeF = New System.Drawing.SizeF(1909.0!, 65.0!)
        Me.lblTitleDatosBasicos.StylePriority.UseBackColor = False
        Me.lblTitleDatosBasicos.StylePriority.UseBorders = False
        Me.lblTitleDatosBasicos.StylePriority.UseBorderWidth = False
        Me.lblTitleDatosBasicos.StylePriority.UseFont = False
        Me.lblTitleDatosBasicos.StylePriority.UsePadding = False
        Me.lblTitleDatosBasicos.StylePriority.UseTextAlignment = False
        Me.lblTitleDatosBasicos.Text = "1. Datos Básicos"
        Me.lblTitleDatosBasicos.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'lineAbjDatosBasicos
        '
        Me.lineAbjDatosBasicos.BorderWidth = 0.0!
        Me.lineAbjDatosBasicos.Dpi = 254.0!
        Me.lineAbjDatosBasicos.LineWidth = 10
        Me.lineAbjDatosBasicos.LocationFloat = New DevExpress.Utils.PointFloat(39.25516!, 838.4166!)
        Me.lineAbjDatosBasicos.Name = "lineAbjDatosBasicos"
        Me.lineAbjDatosBasicos.SizeF = New System.Drawing.SizeF(1894.745!, 10.00006!)
        Me.lineAbjDatosBasicos.StylePriority.UseBorderWidth = False
        '
        'lineDerDatosBasicos
        '
        Me.lineDerDatosBasicos.BorderWidth = 0.0!
        Me.lineDerDatosBasicos.Dpi = 254.0!
        Me.lineDerDatosBasicos.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical
        Me.lineDerDatosBasicos.LineWidth = 10
        Me.lineDerDatosBasicos.LocationFloat = New DevExpress.Utils.PointFloat(1934.0!, 98.20991!)
        Me.lineDerDatosBasicos.Name = "lineDerDatosBasicos"
        Me.lineDerDatosBasicos.SizeF = New System.Drawing.SizeF(10.0!, 750.2067!)
        Me.lineDerDatosBasicos.StylePriority.UseBorderWidth = False
        '
        'TablaDatosBasicos
        '
        Me.TablaDatosBasicos.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TablaDatosBasicos.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.TablaDatosBasicos.BorderWidth = 0.5!
        Me.TablaDatosBasicos.Dpi = 254.0!
        Me.TablaDatosBasicos.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TablaDatosBasicos.LocationFloat = New DevExpress.Utils.PointFloat(25.00001!, 87.0!)
        Me.TablaDatosBasicos.Name = "TablaDatosBasicos"
        Me.TablaDatosBasicos.Padding = New DevExpress.XtraPrinting.PaddingInfo(12, 5, 5, 5, 254.0!)
        Me.TablaDatosBasicos.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.fila1, Me.fila2, Me.fila3, Me.fila4, Me.fila5, Me.fila6, Me.fila7, Me.fila8, Me.fila9, Me.fila10, Me.fila11, Me.fila12, Me.fila13})
        Me.TablaDatosBasicos.SizeF = New System.Drawing.SizeF(1909.0!, 751.4167!)
        Me.TablaDatosBasicos.StylePriority.UseBackColor = False
        Me.TablaDatosBasicos.StylePriority.UseBorders = False
        Me.TablaDatosBasicos.StylePriority.UseBorderWidth = False
        Me.TablaDatosBasicos.StylePriority.UseFont = False
        Me.TablaDatosBasicos.StylePriority.UsePadding = False
        Me.TablaDatosBasicos.StylePriority.UseTextAlignment = False
        Me.TablaDatosBasicos.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify
        '
        'fila1
        '
        Me.fila1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.lblTitlePapellido, Me.lblTitleSapellido, Me.lblTitleNombres})
        Me.fila1.Dpi = 254.0!
        Me.fila1.Name = "fila1"
        Me.fila1.Weight = 1.0R
        '
        'lblTitlePapellido
        '
        Me.lblTitlePapellido.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.lblTitlePapellido.Dpi = 254.0!
        Me.lblTitlePapellido.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitlePapellido.Name = "lblTitlePapellido"
        Me.lblTitlePapellido.StylePriority.UseBorders = False
        Me.lblTitlePapellido.StylePriority.UseFont = False
        Me.lblTitlePapellido.Text = "PRIMER APELLIDO"
        Me.lblTitlePapellido.Weight = 0.7071765934221298R
        '
        'lblTitleSapellido
        '
        Me.lblTitleSapellido.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.lblTitleSapellido.Dpi = 254.0!
        Me.lblTitleSapellido.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleSapellido.Name = "lblTitleSapellido"
        Me.lblTitleSapellido.StylePriority.UseBorders = False
        Me.lblTitleSapellido.StylePriority.UseFont = False
        Me.lblTitleSapellido.Text = "SEGUNDO APELLIDO"
        Me.lblTitleSapellido.Weight = 0.70717659342213R
        '
        'lblTitleNombres
        '
        Me.lblTitleNombres.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.lblTitleNombres.Dpi = 254.0!
        Me.lblTitleNombres.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleNombres.Name = "lblTitleNombres"
        Me.lblTitleNombres.StylePriority.UseBorders = False
        Me.lblTitleNombres.StylePriority.UseFont = False
        Me.lblTitleNombres.Text = "NOMBRES"
        Me.lblTitleNombres.Weight = 1.5856468131557404R
        '
        'fila2
        '
        Me.fila2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.lblPApellido, Me.lblSApellido, Me.lblNombres})
        Me.fila2.Dpi = 254.0!
        Me.fila2.Name = "fila2"
        Me.fila2.Weight = 1.0R
        '
        'lblPApellido
        '
        Me.lblPApellido.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblPApellido.CanGrow = False
        Me.lblPApellido.Dpi = 254.0!
        Me.lblPApellido.Name = "lblPApellido"
        Me.lblPApellido.StylePriority.UseBorders = False
        Me.lblPApellido.Text = "Vargas"
        Me.lblPApellido.Weight = 0.70717649750516776R
        '
        'lblSApellido
        '
        Me.lblSApellido.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblSApellido.CanGrow = False
        Me.lblSApellido.Dpi = 254.0!
        Me.lblSApellido.Name = "lblSApellido"
        Me.lblSApellido.StylePriority.UseBorders = False
        Me.lblSApellido.Text = "Mahecha"
        Me.lblSApellido.Weight = 0.70717654546364894R
        '
        'lblNombres
        '
        Me.lblNombres.CanGrow = False
        Me.lblNombres.Dpi = 254.0!
        Me.lblNombres.Name = "lblNombres"
        Me.lblNombres.Text = "Arlington"
        Me.lblNombres.Weight = 1.5856469570311833R
        '
        'fila3
        '
        Me.fila3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.lblTitleDocuemntoId, Me.lblTitleSexo, Me.lblTitleEstCivil})
        Me.fila3.Dpi = 254.0!
        Me.fila3.Name = "fila3"
        Me.fila3.Weight = 1.0R
        '
        'lblTitleDocuemntoId
        '
        Me.lblTitleDocuemntoId.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.lblTitleDocuemntoId.Dpi = 254.0!
        Me.lblTitleDocuemntoId.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleDocuemntoId.Name = "lblTitleDocuemntoId"
        Me.lblTitleDocuemntoId.StylePriority.UseBorders = False
        Me.lblTitleDocuemntoId.StylePriority.UseFont = False
        Me.lblTitleDocuemntoId.Text = "DOCUMENTO DE IDENTIFICACION"
        Me.lblTitleDocuemntoId.Weight = 1.7609024494442476R
        '
        'lblTitleSexo
        '
        Me.lblTitleSexo.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.lblTitleSexo.Dpi = 254.0!
        Me.lblTitleSexo.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleSexo.Name = "lblTitleSexo"
        Me.lblTitleSexo.StylePriority.UseBorders = False
        Me.lblTitleSexo.StylePriority.UseFont = False
        Me.lblTitleSexo.Text = "SEXO"
        Me.lblTitleSexo.Weight = 0.33888802314949484R
        '
        'lblTitleEstCivil
        '
        Me.lblTitleEstCivil.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.lblTitleEstCivil.Dpi = 254.0!
        Me.lblTitleEstCivil.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleEstCivil.Name = "lblTitleEstCivil"
        Me.lblTitleEstCivil.StylePriority.UseBorders = False
        Me.lblTitleEstCivil.StylePriority.UseFont = False
        Me.lblTitleEstCivil.Text = "ESTADO CIVIL"
        Me.lblTitleEstCivil.Weight = 0.90020952740625759R
        '
        'fila4
        '
        Me.fila4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.lblTitleTipoDoc, Me.lblTipoDoc, Me.lblTitleNumDoc, Me.lblNumDoc, Me.lblSexo, Me.lblEstCivil})
        Me.fila4.Dpi = 254.0!
        Me.fila4.Name = "fila4"
        Me.fila4.Weight = 1.0R
        '
        'lblTitleTipoDoc
        '
        Me.lblTitleTipoDoc.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblTitleTipoDoc.Dpi = 254.0!
        Me.lblTitleTipoDoc.Name = "lblTitleTipoDoc"
        Me.lblTitleTipoDoc.StylePriority.UseBorders = False
        Me.lblTitleTipoDoc.Text = "Tipo :"
        Me.lblTitleTipoDoc.Weight = 0.19116676957490941R
        '
        'lblTipoDoc
        '
        Me.lblTipoDoc.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.lblTipoDoc.CanGrow = False
        Me.lblTipoDoc.Dpi = 254.0!
        Me.lblTipoDoc.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoDoc.Name = "lblTipoDoc"
        Me.lblTipoDoc.StylePriority.UseBorders = False
        Me.lblTipoDoc.StylePriority.UseFont = False
        Me.lblTipoDoc.StylePriority.UseTextAlignment = False
        Me.lblTipoDoc.Text = "CC"
        Me.lblTipoDoc.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.lblTipoDoc.Weight = 0.17027902867706146R
        '
        'lblTitleNumDoc
        '
        Me.lblTitleNumDoc.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.lblTitleNumDoc.Dpi = 254.0!
        Me.lblTitleNumDoc.Name = "lblTitleNumDoc"
        Me.lblTitleNumDoc.StylePriority.UseBorders = False
        Me.lblTitleNumDoc.Text = "Número : "
        Me.lblTitleNumDoc.Weight = 0.26715549201021294R
        '
        'lblNumDoc
        '
        Me.lblNumDoc.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.lblNumDoc.CanGrow = False
        Me.lblNumDoc.Dpi = 254.0!
        Me.lblNumDoc.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumDoc.Name = "lblNumDoc"
        Me.lblNumDoc.StylePriority.UseBorders = False
        Me.lblNumDoc.StylePriority.UseFont = False
        Me.lblNumDoc.Text = "1117521997"
        Me.lblNumDoc.Weight = 1.1323011591820635R
        '
        'lblSexo
        '
        Me.lblSexo.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblSexo.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.ckbFemenino, Me.ckbMasculino})
        Me.lblSexo.Dpi = 254.0!
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.StylePriority.UseBorders = False
        Me.lblSexo.Weight = 0.33888802314949479R
        '
        'ckbFemenino
        '
        Me.ckbFemenino.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.ckbFemenino.Dpi = 254.0!
        Me.ckbFemenino.LocationFloat = New DevExpress.Utils.PointFloat(5.0!, 4.000008!)
        Me.ckbFemenino.Name = "ckbFemenino"
        Me.ckbFemenino.SizeF = New System.Drawing.SizeF(90.0!, 48.0!)
        Me.ckbFemenino.StylePriority.UseBorders = False
        Me.ckbFemenino.StylePriority.UseTextAlignment = False
        Me.ckbFemenino.Text = "F"
        Me.ckbFemenino.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        '
        'ckbMasculino
        '
        Me.ckbMasculino.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.ckbMasculino.Dpi = 254.0!
        Me.ckbMasculino.LocationFloat = New DevExpress.Utils.PointFloat(111.5416!, 4.000008!)
        Me.ckbMasculino.Name = "ckbMasculino"
        Me.ckbMasculino.SizeF = New System.Drawing.SizeF(90.0!, 48.0!)
        Me.ckbMasculino.StylePriority.UseBorders = False
        Me.ckbMasculino.StylePriority.UseTextAlignment = False
        Me.ckbMasculino.Text = "M"
        Me.ckbMasculino.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        '
        'lblEstCivil
        '
        Me.lblEstCivil.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblEstCivil.CanGrow = False
        Me.lblEstCivil.Dpi = 254.0!
        Me.lblEstCivil.Name = "lblEstCivil"
        Me.lblEstCivil.StylePriority.UseBorders = False
        Me.lblEstCivil.Text = "Union Libre"
        Me.lblEstCivil.Weight = 0.90020952740625759R
        '
        'fila5
        '
        Me.fila5.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.lblTitleLibretaMilitar})
        Me.fila5.Dpi = 254.0!
        Me.fila5.Name = "fila5"
        Me.fila5.Weight = 1.0R
        '
        'lblTitleLibretaMilitar
        '
        Me.lblTitleLibretaMilitar.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.lblTitleLibretaMilitar.Dpi = 254.0!
        Me.lblTitleLibretaMilitar.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleLibretaMilitar.Name = "lblTitleLibretaMilitar"
        Me.lblTitleLibretaMilitar.StylePriority.UseBorders = False
        Me.lblTitleLibretaMilitar.StylePriority.UseFont = False
        Me.lblTitleLibretaMilitar.Text = "LIBRETA MILITAR"
        Me.lblTitleLibretaMilitar.Weight = 3.0R
        '
        'fila6
        '
        Me.fila6.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.lblLibPrimera, Me.XrTableCell1, Me.lblLibSegunda, Me.lblTitleNumLibreta, Me.lblNumLibreta, Me.lblTitleDM, Me.lblDM})
        Me.fila6.Dpi = 254.0!
        Me.fila6.Name = "fila6"
        Me.fila6.Weight = 1.0R
        '
        'lblLibPrimera
        '
        Me.lblLibPrimera.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblLibPrimera.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.ckbLibPrimera})
        Me.lblLibPrimera.Dpi = 254.0!
        Me.lblLibPrimera.Name = "lblLibPrimera"
        Me.lblLibPrimera.StylePriority.UseBorders = False
        Me.lblLibPrimera.Weight = 0.46596361025562061R
        '
        'ckbLibPrimera
        '
        Me.ckbLibPrimera.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.ckbLibPrimera.Dpi = 254.0!
        Me.ckbLibPrimera.LocationFloat = New DevExpress.Utils.PointFloat(3.99999!, 4.000061!)
        Me.ckbLibPrimera.Name = "ckbLibPrimera"
        Me.ckbLibPrimera.SizeF = New System.Drawing.SizeF(284.596!, 50.0!)
        Me.ckbLibPrimera.StylePriority.UseBorders = False
        Me.ckbLibPrimera.StylePriority.UseTextAlignment = False
        Me.ckbLibPrimera.Text = "Primera Clase"
        Me.ckbLibPrimera.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrTableCell1
        '
        Me.XrTableCell1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrTableCell1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.ckbLibSegunda})
        Me.XrTableCell1.Dpi = 254.0!
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.StylePriority.UseBorders = False
        Me.XrTableCell1.Text = "XrTableCell1"
        Me.XrTableCell1.Weight = 0.463414848789787R
        '
        'ckbLibSegunda
        '
        Me.ckbLibSegunda.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.ckbLibSegunda.Dpi = 254.0!
        Me.ckbLibSegunda.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.ckbLibSegunda.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 4.000031!)
        Me.ckbLibSegunda.Name = "ckbLibSegunda"
        Me.ckbLibSegunda.Padding = New DevExpress.XtraPrinting.PaddingInfo(13, 0, 3, 0, 254.0!)
        Me.ckbLibSegunda.SizeF = New System.Drawing.SizeF(288.8505!, 50.0!)
        Me.ckbLibSegunda.StylePriority.UseBorders = False
        Me.ckbLibSegunda.StylePriority.UseFont = False
        Me.ckbLibSegunda.StylePriority.UsePadding = False
        Me.ckbLibSegunda.StylePriority.UseTextAlignment = False
        Me.ckbLibSegunda.Text = "Segunda Clase"
        Me.ckbLibSegunda.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.ckbLibSegunda.TextTrimming = System.Drawing.StringTrimming.None
        '
        'lblLibSegunda
        '
        Me.lblLibSegunda.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.lblLibSegunda.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.ckbNoLibreta})
        Me.lblLibSegunda.Dpi = 254.0!
        Me.lblLibSegunda.Name = "lblLibSegunda"
        Me.lblLibSegunda.StylePriority.UseBorders = False
        Me.lblLibSegunda.Weight = 0.58990879543834285R
        '
        'ckbNoLibreta
        '
        Me.ckbNoLibreta.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.ckbNoLibreta.Dpi = 254.0!
        Me.ckbNoLibreta.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 4.000031!)
        Me.ckbNoLibreta.Name = "ckbNoLibreta"
        Me.ckbNoLibreta.SizeF = New System.Drawing.SizeF(375.3787!, 50.0!)
        Me.ckbNoLibreta.StylePriority.UseBorders = False
        Me.ckbNoLibreta.Text = "No Tiene/No Aplica"
        '
        'lblTitleNumLibreta
        '
        Me.lblTitleNumLibreta.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.lblTitleNumLibreta.Dpi = 254.0!
        Me.lblTitleNumLibreta.Name = "lblTitleNumLibreta"
        Me.lblTitleNumLibreta.StylePriority.UseBorders = False
        Me.lblTitleNumLibreta.StylePriority.UseTextAlignment = False
        Me.lblTitleNumLibreta.Text = "N° :"
        Me.lblTitleNumLibreta.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.lblTitleNumLibreta.Weight = 0.14044248301006867R
        '
        'lblNumLibreta
        '
        Me.lblNumLibreta.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.lblNumLibreta.CanGrow = False
        Me.lblNumLibreta.Dpi = 254.0!
        Me.lblNumLibreta.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumLibreta.Name = "lblNumLibreta"
        Me.lblNumLibreta.StylePriority.UseBorders = False
        Me.lblNumLibreta.StylePriority.UseFont = False
        Me.lblNumLibreta.StylePriority.UseTextAlignment = False
        Me.lblNumLibreta.Text = "25124212121"
        Me.lblNumLibreta.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify
        Me.lblNumLibreta.Weight = 0.469232955891562R
        '
        'lblTitleDM
        '
        Me.lblTitleDM.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.lblTitleDM.Dpi = 254.0!
        Me.lblTitleDM.Name = "lblTitleDM"
        Me.lblTitleDM.StylePriority.UseBorders = False
        Me.lblTitleDM.StylePriority.UseTextAlignment = False
        Me.lblTitleDM.Text = "DM :"
        Me.lblTitleDM.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.lblTitleDM.Weight = 0.15369733591277496R
        '
        'lblDM
        '
        Me.lblDM.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblDM.CanGrow = False
        Me.lblDM.Dpi = 254.0!
        Me.lblDM.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDM.Name = "lblDM"
        Me.lblDM.StylePriority.UseBorders = False
        Me.lblDM.StylePriority.UseFont = False
        Me.lblDM.Text = "Numero XVI"
        Me.lblDM.Weight = 0.7173399707018443R
        '
        'fila7
        '
        Me.fila7.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.lblTitleCelular, Me.lblTitleTelefoonos, Me.lblTitleCorreo})
        Me.fila7.Dpi = 254.0!
        Me.fila7.Name = "fila7"
        Me.fila7.Weight = 1.0R
        '
        'lblTitleCelular
        '
        Me.lblTitleCelular.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.lblTitleCelular.Dpi = 254.0!
        Me.lblTitleCelular.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleCelular.Name = "lblTitleCelular"
        Me.lblTitleCelular.StylePriority.UseBorders = False
        Me.lblTitleCelular.StylePriority.UseFont = False
        Me.lblTitleCelular.Text = "CELULAR"
        Me.lblTitleCelular.Weight = 0.62860137019298556R
        '
        'lblTitleTelefoonos
        '
        Me.lblTitleTelefoonos.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.lblTitleTelefoonos.Dpi = 254.0!
        Me.lblTitleTelefoonos.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleTelefoonos.Name = "lblTitleTelefoonos"
        Me.lblTitleTelefoonos.StylePriority.UseBorders = False
        Me.lblTitleTelefoonos.StylePriority.UseFont = False
        Me.lblTitleTelefoonos.Text = "TELEFONOS"
        Me.lblTitleTelefoonos.Weight = 0.62860137019298556R
        '
        'lblTitleCorreo
        '
        Me.lblTitleCorreo.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.lblTitleCorreo.Dpi = 254.0!
        Me.lblTitleCorreo.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleCorreo.Name = "lblTitleCorreo"
        Me.lblTitleCorreo.StylePriority.UseBorders = False
        Me.lblTitleCorreo.StylePriority.UseFont = False
        Me.lblTitleCorreo.Text = "CORREO ELECTRONICO"
        Me.lblTitleCorreo.Weight = 1.7427972596140289R
        '
        'fila8
        '
        Me.fila8.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.lblCelular, Me.lblTelefonos, Me.lblCorreo})
        Me.fila8.Dpi = 254.0!
        Me.fila8.Name = "fila8"
        Me.fila8.Weight = 1.0R
        '
        'lblCelular
        '
        Me.lblCelular.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblCelular.CanGrow = False
        Me.lblCelular.Dpi = 254.0!
        Me.lblCelular.Name = "lblCelular"
        Me.lblCelular.StylePriority.UseBorders = False
        Me.lblCelular.Text = "3132565700"
        Me.lblCelular.Weight = 0.62860137019298556R
        '
        'lblTelefonos
        '
        Me.lblTelefonos.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblTelefonos.CanGrow = False
        Me.lblTelefonos.Dpi = 254.0!
        Me.lblTelefonos.Name = "lblTelefonos"
        Me.lblTelefonos.StylePriority.UseBorders = False
        Me.lblTelefonos.Text = "4346805-4368598"
        Me.lblTelefonos.Weight = 0.62860137019298556R
        '
        'lblCorreo
        '
        Me.lblCorreo.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblCorreo.CanGrow = False
        Me.lblCorreo.Dpi = 254.0!
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.StylePriority.UseBorders = False
        Me.lblCorreo.Text = "arlington.vargas4@gmail.com"
        Me.lblCorreo.Weight = 1.7427972596140289R
        '
        'fila9
        '
        Me.fila9.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.lblTitleFechaLugarNac, Me.lblDireccionResidencia})
        Me.fila9.Dpi = 254.0!
        Me.fila9.Name = "fila9"
        Me.fila9.Weight = 1.0R
        '
        'lblTitleFechaLugarNac
        '
        Me.lblTitleFechaLugarNac.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblTitleFechaLugarNac.Dpi = 254.0!
        Me.lblTitleFechaLugarNac.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleFechaLugarNac.Name = "lblTitleFechaLugarNac"
        Me.lblTitleFechaLugarNac.StylePriority.UseBorders = False
        Me.lblTitleFechaLugarNac.StylePriority.UseFont = False
        Me.lblTitleFechaLugarNac.Text = "FECHA Y LUGAR DE NACIMIENTO"
        Me.lblTitleFechaLugarNac.Weight = 1.4992143121919348R
        '
        'lblDireccionResidencia
        '
        Me.lblDireccionResidencia.Dpi = 254.0!
        Me.lblDireccionResidencia.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccionResidencia.Name = "lblDireccionResidencia"
        Me.lblDireccionResidencia.StylePriority.UseFont = False
        Me.lblDireccionResidencia.Text = "DIRECCION DE RESIDENCIA"
        Me.lblDireccionResidencia.Weight = 1.5007856878080652R
        '
        'fila10
        '
        Me.fila10.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.lblTitleFechaNac, Me.lblFechaNac, Me.LblDireccionEmpleado})
        Me.fila10.Dpi = 254.0!
        Me.fila10.Name = "fila10"
        Me.fila10.Weight = 1.0R
        '
        'lblTitleFechaNac
        '
        Me.lblTitleFechaNac.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblTitleFechaNac.Dpi = 254.0!
        Me.lblTitleFechaNac.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleFechaNac.Name = "lblTitleFechaNac"
        Me.lblTitleFechaNac.StylePriority.UseBorders = False
        Me.lblTitleFechaNac.StylePriority.UseFont = False
        Me.lblTitleFechaNac.Text = "Fecha"
        Me.lblTitleFechaNac.Weight = 0.38501836681933016R
        '
        'lblFechaNac
        '
        Me.lblFechaNac.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblFechaNac.Dpi = 254.0!
        Me.lblFechaNac.Name = "lblFechaNac"
        Me.lblFechaNac.StylePriority.UseBorders = False
        Me.lblFechaNac.Text = "11 Dic 1991"
        Me.lblFechaNac.Weight = 1.1141959453726045R
        '
        'LblDireccionEmpleado
        '
        Me.LblDireccionEmpleado.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.LblDireccionEmpleado.CanGrow = False
        Me.LblDireccionEmpleado.Dpi = 254.0!
        Me.LblDireccionEmpleado.Name = "LblDireccionEmpleado"
        Me.LblDireccionEmpleado.StylePriority.UseBorders = False
        Me.LblDireccionEmpleado.Text = "CALLE 2 D NUMERO 11 A 03"
        Me.LblDireccionEmpleado.Weight = 1.5007856878080652R
        '
        'fila11
        '
        Me.fila11.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.lblTitlePaisNac, Me.lblPaisNac, Me.lblTitlePaisResidencia, Me.lblPaisResidencia})
        Me.fila11.Dpi = 254.0!
        Me.fila11.Name = "fila11"
        Me.fila11.Weight = 1.0R
        '
        'lblTitlePaisNac
        '
        Me.lblTitlePaisNac.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblTitlePaisNac.Dpi = 254.0!
        Me.lblTitlePaisNac.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitlePaisNac.Name = "lblTitlePaisNac"
        Me.lblTitlePaisNac.StylePriority.UseBorders = False
        Me.lblTitlePaisNac.StylePriority.UseFont = False
        Me.lblTitlePaisNac.Text = "Pais"
        Me.lblTitlePaisNac.Weight = 0.38501836681933022R
        '
        'lblPaisNac
        '
        Me.lblPaisNac.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblPaisNac.CanGrow = False
        Me.lblPaisNac.Dpi = 254.0!
        Me.lblPaisNac.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaisNac.Name = "lblPaisNac"
        Me.lblPaisNac.StylePriority.UseBorders = False
        Me.lblPaisNac.StylePriority.UseFont = False
        Me.lblPaisNac.Text = "Colombia"
        Me.lblPaisNac.Weight = 1.1141959453726047R
        '
        'lblTitlePaisResidencia
        '
        Me.lblTitlePaisResidencia.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblTitlePaisResidencia.Dpi = 254.0!
        Me.lblTitlePaisResidencia.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitlePaisResidencia.Name = "lblTitlePaisResidencia"
        Me.lblTitlePaisResidencia.StylePriority.UseBorders = False
        Me.lblTitlePaisResidencia.StylePriority.UseFont = False
        Me.lblTitlePaisResidencia.Text = "Pais"
        Me.lblTitlePaisResidencia.Weight = 0.38501835083316982R
        '
        'lblPaisResidencia
        '
        Me.lblPaisResidencia.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblPaisResidencia.CanGrow = False
        Me.lblPaisResidencia.Dpi = 254.0!
        Me.lblPaisResidencia.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaisResidencia.Name = "lblPaisResidencia"
        Me.lblPaisResidencia.StylePriority.UseBorders = False
        Me.lblPaisResidencia.StylePriority.UseFont = False
        Me.lblPaisResidencia.Text = "Colombia"
        Me.lblPaisResidencia.Weight = 1.1157673369748955R
        '
        'fila12
        '
        Me.fila12.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.lblTitleDepNac, Me.lblDepNac, Me.lblTitleDepResidencia, Me.lblDepResidencia})
        Me.fila12.Dpi = 254.0!
        Me.fila12.Name = "fila12"
        Me.fila12.Weight = 1.0R
        '
        'lblTitleDepNac
        '
        Me.lblTitleDepNac.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblTitleDepNac.Dpi = 254.0!
        Me.lblTitleDepNac.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleDepNac.Name = "lblTitleDepNac"
        Me.lblTitleDepNac.StylePriority.UseBorders = False
        Me.lblTitleDepNac.StylePriority.UseFont = False
        Me.lblTitleDepNac.Text = "Departamento"
        Me.lblTitleDepNac.Weight = 0.38501836681933027R
        '
        'lblDepNac
        '
        Me.lblDepNac.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblDepNac.CanGrow = False
        Me.lblDepNac.Dpi = 254.0!
        Me.lblDepNac.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepNac.Name = "lblDepNac"
        Me.lblDepNac.StylePriority.UseBorders = False
        Me.lblDepNac.StylePriority.UseFont = False
        Me.lblDepNac.Text = "Huila"
        Me.lblDepNac.Weight = 1.1141959453726047R
        '
        'lblTitleDepResidencia
        '
        Me.lblTitleDepResidencia.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblTitleDepResidencia.Dpi = 254.0!
        Me.lblTitleDepResidencia.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleDepResidencia.Name = "lblTitleDepResidencia"
        Me.lblTitleDepResidencia.StylePriority.UseBorders = False
        Me.lblTitleDepResidencia.StylePriority.UseFont = False
        Me.lblTitleDepResidencia.Text = "Departamento"
        Me.lblTitleDepResidencia.Weight = 0.38501835083316982R
        '
        'lblDepResidencia
        '
        Me.lblDepResidencia.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblDepResidencia.CanGrow = False
        Me.lblDepResidencia.Dpi = 254.0!
        Me.lblDepResidencia.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepResidencia.Name = "lblDepResidencia"
        Me.lblDepResidencia.StylePriority.UseBorders = False
        Me.lblDepResidencia.StylePriority.UseFont = False
        Me.lblDepResidencia.Text = "Caquetá"
        Me.lblDepResidencia.Weight = 1.1157673369748955R
        '
        'fila13
        '
        Me.fila13.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.lblTitleMuniNac, Me.lblMuniNac, Me.lblTitleMuniResidencia, Me.lblMuniResidencia})
        Me.fila13.Dpi = 254.0!
        Me.fila13.Name = "fila13"
        Me.fila13.Weight = 1.0R
        '
        'lblTitleMuniNac
        '
        Me.lblTitleMuniNac.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblTitleMuniNac.Dpi = 254.0!
        Me.lblTitleMuniNac.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleMuniNac.Name = "lblTitleMuniNac"
        Me.lblTitleMuniNac.StylePriority.UseBorders = False
        Me.lblTitleMuniNac.StylePriority.UseFont = False
        Me.lblTitleMuniNac.Text = "Municipio"
        Me.lblTitleMuniNac.Weight = 0.38501836681933016R
        '
        'lblMuniNac
        '
        Me.lblMuniNac.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblMuniNac.CanGrow = False
        Me.lblMuniNac.Dpi = 254.0!
        Me.lblMuniNac.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMuniNac.Name = "lblMuniNac"
        Me.lblMuniNac.StylePriority.UseBorders = False
        Me.lblMuniNac.StylePriority.UseFont = False
        Me.lblMuniNac.Text = "Oporapa"
        Me.lblMuniNac.Weight = 1.1141959453726045R
        '
        'lblTitleMuniResidencia
        '
        Me.lblTitleMuniResidencia.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblTitleMuniResidencia.Dpi = 254.0!
        Me.lblTitleMuniResidencia.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleMuniResidencia.Name = "lblTitleMuniResidencia"
        Me.lblTitleMuniResidencia.StylePriority.UseBorders = False
        Me.lblTitleMuniResidencia.StylePriority.UseFont = False
        Me.lblTitleMuniResidencia.Text = "Minicipio"
        Me.lblTitleMuniResidencia.Weight = 0.38501835083316982R
        '
        'lblMuniResidencia
        '
        Me.lblMuniResidencia.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblMuniResidencia.CanGrow = False
        Me.lblMuniResidencia.Dpi = 254.0!
        Me.lblMuniResidencia.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMuniResidencia.Name = "lblMuniResidencia"
        Me.lblMuniResidencia.StylePriority.UseBorders = False
        Me.lblMuniResidencia.StylePriority.UseFont = False
        Me.lblMuniResidencia.Text = "Florencia"
        Me.lblMuniResidencia.Weight = 1.1157673369748955R
        '
        'TopMargin
        '
        Me.TopMargin.Dpi = 254.0!
        Me.TopMargin.HeightF = 150.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.Dpi = 254.0!
        Me.BottomMargin.HeightF = 100.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.tablaCabecera1, Me.pcbImg})
        Me.ReportHeader.Dpi = 254.0!
        Me.ReportHeader.HeightF = 200.0!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'tablaCabecera1
        '
        Me.tablaCabecera1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.tablaCabecera1.Dpi = 254.0!
        Me.tablaCabecera1.LocationFloat = New DevExpress.Utils.PointFloat(254.0!, 0.0!)
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
        Me.pcbImg.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.pcbImg.Name = "pcbImg"
        Me.pcbImg.SizeF = New System.Drawing.SizeF(254.0!, 200.0!)
        Me.pcbImg.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze
        Me.pcbImg.StylePriority.UseBorders = False
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lblTituloInforme})
        Me.PageHeader.Dpi = 254.0!
        Me.PageHeader.HeightF = 91.45835!
        Me.PageHeader.Name = "PageHeader"
        '
        'lblTituloInforme
        '
        Me.lblTituloInforme.BackColor = System.Drawing.Color.Gainsboro
        Me.lblTituloInforme.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblTituloInforme.Dpi = 254.0!
        Me.lblTituloInforme.Font = New System.Drawing.Font("Segoe UI Symbol", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblTituloInforme.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.lblTituloInforme.Name = "lblTituloInforme"
        Me.lblTituloInforme.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 5, 254.0!)
        Me.lblTituloInforme.SizeF = New System.Drawing.SizeF(1958.729!, 65.0!)
        Me.lblTituloInforme.StylePriority.UseBackColor = False
        Me.lblTituloInforme.StylePriority.UseBorders = False
        Me.lblTituloInforme.StylePriority.UseFont = False
        Me.lblTituloInforme.StylePriority.UsePadding = False
        Me.lblTituloInforme.StylePriority.UseTextAlignment = False
        Me.lblTituloInforme.Text = "Informe Empleado Arlington Vargas Mahecha | Documento 1117521997"
        Me.lblTituloInforme.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrPageInfo2, Me.xrPageInfo1, Me.lbversionsamit, Me.lbpc, Me.lbreviso, Me.lblpaginas, Me.lblsigpag, Me.Fecha})
        Me.PageFooter.Dpi = 254.0!
        Me.PageFooter.HeightF = 36.23166!
        Me.PageFooter.Name = "PageFooter"
        '
        'xrPageInfo2
        '
        Me.xrPageInfo2.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.xrPageInfo2.BorderWidth = 0.5!
        Me.xrPageInfo2.Dpi = 254.0!
        Me.xrPageInfo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(1906.258!, 0.0!)
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
        Me.xrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(1803.613!, 0.0!)
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
        'lbversionsamit
        '
        Me.lbversionsamit.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.lbversionsamit.BorderWidth = 0.5!
        Me.lbversionsamit.Dpi = 254.0!
        Me.lbversionsamit.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbversionsamit.LocationFloat = New DevExpress.Utils.PointFloat(1081.141!, 0.0!)
        Me.lbversionsamit.Name = "lbversionsamit"
        Me.lbversionsamit.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.lbversionsamit.SizeF = New System.Drawing.SizeF(546.4667!, 34.85252!)
        Me.lbversionsamit.StylePriority.UseBorders = False
        Me.lbversionsamit.StylePriority.UseBorderWidth = False
        Me.lbversionsamit.StylePriority.UseFont = False
        Me.lbversionsamit.StylePriority.UseTextAlignment = False
        Me.lbversionsamit.Text = "lbversionsamit"
        Me.lbversionsamit.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'lbpc
        '
        Me.lbpc.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.lbpc.BorderWidth = 0.5!
        Me.lbpc.Dpi = 254.0!
        Me.lbpc.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbpc.LocationFloat = New DevExpress.Utils.PointFloat(706.355!, 0.0!)
        Me.lbpc.Name = "lbpc"
        Me.lbpc.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.lbpc.SizeF = New System.Drawing.SizeF(374.7863!, 34.85242!)
        Me.lbpc.StylePriority.UseBorders = False
        Me.lbpc.StylePriority.UseBorderWidth = False
        Me.lbpc.StylePriority.UseFont = False
        Me.lbpc.StylePriority.UseTextAlignment = False
        Me.lbpc.Text = "lbpc"
        Me.lbpc.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'lbreviso
        '
        Me.lbreviso.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.lbreviso.BorderWidth = 0.5!
        Me.lbreviso.Dpi = 254.0!
        Me.lbreviso.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbreviso.LocationFloat = New DevExpress.Utils.PointFloat(339.6314!, 0.0!)
        Me.lbreviso.Name = "lbreviso"
        Me.lbreviso.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.lbreviso.SizeF = New System.Drawing.SizeF(366.7236!, 34.85242!)
        Me.lbreviso.StylePriority.UseBorders = False
        Me.lbreviso.StylePriority.UseBorderWidth = False
        Me.lbreviso.StylePriority.UseFont = False
        Me.lbreviso.StylePriority.UseTextAlignment = False
        Me.lbreviso.Text = "lbreviso"
        Me.lbreviso.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'lblpaginas
        '
        Me.lblpaginas.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.lblpaginas.BorderWidth = 0.5!
        Me.lblpaginas.Dpi = 254.0!
        Me.lblpaginas.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpaginas.LocationFloat = New DevExpress.Utils.PointFloat(1627.608!, 0.0!)
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
        Me.lblsigpag.LocationFloat = New DevExpress.Utils.PointFloat(1862.981!, 0.0!)
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
        Me.Fecha.LocationFloat = New DevExpress.Utils.PointFloat(0.270813!, 0.0!)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.Fecha.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.Fecha.SizeF = New System.Drawing.SizeF(339.3605!, 36.23166!)
        Me.Fecha.StylePriority.UseBorders = False
        Me.Fecha.StylePriority.UseBorderWidth = False
        Me.Fecha.StylePriority.UseFont = False
        '
        'XrControlStyle1
        '
        Me.XrControlStyle1.Name = "XrControlStyle1"
        Me.XrControlStyle1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        '
        'drInfAcademica
        '
        Me.drInfAcademica.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.dbInfAcademica})
        Me.drInfAcademica.Dpi = 254.0!
        Me.drInfAcademica.Expanded = False
        Me.drInfAcademica.Level = 0
        Me.drInfAcademica.Name = "drInfAcademica"
        '
        'dbInfAcademica
        '
        Me.dbInfAcademica.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel1})
        Me.dbInfAcademica.Dpi = 254.0!
        Me.dbInfAcademica.HeightF = 461.6848!
        Me.dbInfAcademica.Name = "dbInfAcademica"
        '
        'XrLabel1
        '
        Me.XrLabel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.XrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel1.BorderWidth = 0.5!
        Me.XrLabel1.Dpi = 254.0!
        Me.XrLabel1.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(25.0!, 0.0!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 5, 254.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(1909.0!, 65.0!)
        Me.XrLabel1.StylePriority.UseBackColor = False
        Me.XrLabel1.StylePriority.UseBorders = False
        Me.XrLabel1.StylePriority.UseBorderWidth = False
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UsePadding = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "Información Académica"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'drEducacionNoformal
        '
        Me.drEducacionNoformal.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.dbEducacionNoFormal, Me.rhEducacionNoFormal})
        Me.drEducacionNoformal.Dpi = 254.0!
        Me.drEducacionNoformal.Expanded = False
        Me.drEducacionNoformal.Level = 1
        Me.drEducacionNoformal.Name = "drEducacionNoformal"
        '
        'dbEducacionNoFormal
        '
        Me.dbEducacionNoFormal.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable1})
        Me.dbEducacionNoFormal.Dpi = 254.0!
        Me.dbEducacionNoFormal.HeightF = 44.95654!
        Me.dbEducacionNoFormal.Name = "dbEducacionNoFormal"
        '
        'XrTable1
        '
        Me.XrTable1.BorderWidth = 0.5!
        Me.XrTable1.Dpi = 254.0!
        Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(25.00003!, 0.0!)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 254.0!)
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
        Me.XrTable1.SizeF = New System.Drawing.SizeF(1909.0!, 44.95654!)
        Me.XrTable1.StylePriority.UseBorderWidth = False
        Me.XrTable1.StylePriority.UsePadding = False
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.lblNivelEF, Me.lblDescripcionEF, Me.lblInstitucionEF, Me.lblFechaTermancionEF, Me.lblDuracionEF})
        Me.XrTableRow1.Dpi = 254.0!
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Weight = 1.0R
        '
        'lblNivelEF
        '
        Me.lblNivelEF.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblNivelEF.Dpi = 254.0!
        Me.lblNivelEF.Name = "lblNivelEF"
        Me.lblNivelEF.StylePriority.UseBorders = False
        Me.lblNivelEF.Text = "lblNivelEF"
        Me.lblNivelEF.Weight = 0.44195397714042917R
        '
        'lblDescripcionEF
        '
        Me.lblDescripcionEF.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblDescripcionEF.Dpi = 254.0!
        Me.lblDescripcionEF.Name = "lblDescripcionEF"
        Me.lblDescripcionEF.StylePriority.UseBorders = False
        Me.lblDescripcionEF.Text = "lblDescripcionEF"
        Me.lblDescripcionEF.Weight = 0.9638870499251575R
        '
        'lblInstitucionEF
        '
        Me.lblInstitucionEF.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblInstitucionEF.Dpi = 254.0!
        Me.lblInstitucionEF.Name = "lblInstitucionEF"
        Me.lblInstitucionEF.StylePriority.UseBorders = False
        Me.lblInstitucionEF.Text = "lblInstitucionEF"
        Me.lblInstitucionEF.Weight = 0.88374690805058376R
        '
        'lblFechaTermancionEF
        '
        Me.lblFechaTermancionEF.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblFechaTermancionEF.Dpi = 254.0!
        Me.lblFechaTermancionEF.Name = "lblFechaTermancionEF"
        Me.lblFechaTermancionEF.StylePriority.UseBorders = False
        Me.lblFechaTermancionEF.Text = "lblFechaTermancionEF"
        Me.lblFechaTermancionEF.Weight = 0.350534342697167R
        '
        'lblDuracionEF
        '
        Me.lblDuracionEF.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblDuracionEF.Dpi = 254.0!
        Me.lblDuracionEF.Name = "lblDuracionEF"
        Me.lblDuracionEF.StylePriority.UseBorders = False
        Me.lblDuracionEF.Text = "lblDuracionEF"
        Me.lblDuracionEF.Weight = 0.2833081839825804R
        '
        'rhEducacionNoFormal
        '
        Me.rhEducacionNoFormal.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lblTitleNivelEF, Me.lblTitleDuracionEF, Me.lblTitleFechaTerminoEF, Me.lblTitleInstitucionEF, Me.lblTitleDescripcionEF, Me.XrLabel2})
        Me.rhEducacionNoFormal.Dpi = 254.0!
        Me.rhEducacionNoFormal.HeightF = 148.5!
        Me.rhEducacionNoFormal.Name = "rhEducacionNoFormal"
        '
        'lblTitleNivelEF
        '
        Me.lblTitleNivelEF.BackColor = System.Drawing.Color.LightGray
        Me.lblTitleNivelEF.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblTitleNivelEF.BorderWidth = 0.5!
        Me.lblTitleNivelEF.Dpi = 254.0!
        Me.lblTitleNivelEF.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleNivelEF.LocationFloat = New DevExpress.Utils.PointFloat(25.00001!, 105.5!)
        Me.lblTitleNivelEF.Name = "lblTitleNivelEF"
        Me.lblTitleNivelEF.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 254.0!)
        Me.lblTitleNivelEF.SizeF = New System.Drawing.SizeF(288.596!, 42.99998!)
        Me.lblTitleNivelEF.StylePriority.UseBackColor = False
        Me.lblTitleNivelEF.StylePriority.UseBorders = False
        Me.lblTitleNivelEF.StylePriority.UseBorderWidth = False
        Me.lblTitleNivelEF.StylePriority.UseFont = False
        Me.lblTitleNivelEF.StylePriority.UsePadding = False
        Me.lblTitleNivelEF.Text = "Nivel"
        '
        'lblTitleDuracionEF
        '
        Me.lblTitleDuracionEF.BackColor = System.Drawing.Color.LightGray
        Me.lblTitleDuracionEF.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblTitleDuracionEF.BorderWidth = 0.5!
        Me.lblTitleDuracionEF.Dpi = 254.0!
        Me.lblTitleDuracionEF.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleDuracionEF.LocationFloat = New DevExpress.Utils.PointFloat(1749.0!, 105.5!)
        Me.lblTitleDuracionEF.Name = "lblTitleDuracionEF"
        Me.lblTitleDuracionEF.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 254.0!)
        Me.lblTitleDuracionEF.SizeF = New System.Drawing.SizeF(185.0001!, 43.00002!)
        Me.lblTitleDuracionEF.StylePriority.UseBackColor = False
        Me.lblTitleDuracionEF.StylePriority.UseBorders = False
        Me.lblTitleDuracionEF.StylePriority.UseBorderWidth = False
        Me.lblTitleDuracionEF.StylePriority.UseFont = False
        Me.lblTitleDuracionEF.StylePriority.UsePadding = False
        Me.lblTitleDuracionEF.Text = "Duración"
        '
        'lblTitleFechaTerminoEF
        '
        Me.lblTitleFechaTerminoEF.BackColor = System.Drawing.Color.LightGray
        Me.lblTitleFechaTerminoEF.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblTitleFechaTerminoEF.BorderWidth = 0.5!
        Me.lblTitleFechaTerminoEF.Dpi = 254.0!
        Me.lblTitleFechaTerminoEF.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleFechaTerminoEF.LocationFloat = New DevExpress.Utils.PointFloat(1520.101!, 105.5!)
        Me.lblTitleFechaTerminoEF.Name = "lblTitleFechaTerminoEF"
        Me.lblTitleFechaTerminoEF.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 254.0!)
        Me.lblTitleFechaTerminoEF.SizeF = New System.Drawing.SizeF(228.8988!, 43.0!)
        Me.lblTitleFechaTerminoEF.StylePriority.UseBackColor = False
        Me.lblTitleFechaTerminoEF.StylePriority.UseBorders = False
        Me.lblTitleFechaTerminoEF.StylePriority.UseBorderWidth = False
        Me.lblTitleFechaTerminoEF.StylePriority.UseFont = False
        Me.lblTitleFechaTerminoEF.StylePriority.UsePadding = False
        Me.lblTitleFechaTerminoEF.Text = "Fecha Termino"
        '
        'lblTitleInstitucionEF
        '
        Me.lblTitleInstitucionEF.BackColor = System.Drawing.Color.LightGray
        Me.lblTitleInstitucionEF.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblTitleInstitucionEF.BorderWidth = 0.5!
        Me.lblTitleInstitucionEF.Dpi = 254.0!
        Me.lblTitleInstitucionEF.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleInstitucionEF.LocationFloat = New DevExpress.Utils.PointFloat(943.0145!, 105.5!)
        Me.lblTitleInstitucionEF.Name = "lblTitleInstitucionEF"
        Me.lblTitleInstitucionEF.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 254.0!)
        Me.lblTitleInstitucionEF.SizeF = New System.Drawing.SizeF(577.0862!, 43.00002!)
        Me.lblTitleInstitucionEF.StylePriority.UseBackColor = False
        Me.lblTitleInstitucionEF.StylePriority.UseBorders = False
        Me.lblTitleInstitucionEF.StylePriority.UseBorderWidth = False
        Me.lblTitleInstitucionEF.StylePriority.UseFont = False
        Me.lblTitleInstitucionEF.StylePriority.UsePadding = False
        Me.lblTitleInstitucionEF.Text = "Institución"
        '
        'lblTitleDescripcionEF
        '
        Me.lblTitleDescripcionEF.BackColor = System.Drawing.Color.LightGray
        Me.lblTitleDescripcionEF.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblTitleDescripcionEF.BorderWidth = 0.5!
        Me.lblTitleDescripcionEF.Dpi = 254.0!
        Me.lblTitleDescripcionEF.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleDescripcionEF.LocationFloat = New DevExpress.Utils.PointFloat(313.5959!, 105.5!)
        Me.lblTitleDescripcionEF.Name = "lblTitleDescripcionEF"
        Me.lblTitleDescripcionEF.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 254.0!)
        Me.lblTitleDescripcionEF.SizeF = New System.Drawing.SizeF(629.4187!, 42.99998!)
        Me.lblTitleDescripcionEF.StylePriority.UseBackColor = False
        Me.lblTitleDescripcionEF.StylePriority.UseBorders = False
        Me.lblTitleDescripcionEF.StylePriority.UseBorderWidth = False
        Me.lblTitleDescripcionEF.StylePriority.UseFont = False
        Me.lblTitleDescripcionEF.StylePriority.UsePadding = False
        Me.lblTitleDescripcionEF.Text = "Descripción "
        '
        'XrLabel2
        '
        Me.XrLabel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.XrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel2.BorderWidth = 0.5!
        Me.XrLabel2.Dpi = 254.0!
        Me.XrLabel2.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(25.0!, 25.0!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 5, 254.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(1909.0!, 65.0!)
        Me.XrLabel2.StylePriority.UseBackColor = False
        Me.XrLabel2.StylePriority.UseBorders = False
        Me.XrLabel2.StylePriority.UseBorderWidth = False
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UsePadding = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "Educación No Formal"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'drExpLaboral
        '
        Me.drExpLaboral.BackColor = System.Drawing.Color.Transparent
        Me.drExpLaboral.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.dbExpLaboral})
        Me.drExpLaboral.Dpi = 254.0!
        Me.drExpLaboral.Expanded = False
        Me.drExpLaboral.Level = 2
        Me.drExpLaboral.Name = "drExpLaboral"
        '
        'dbExpLaboral
        '
        Me.dbExpLaboral.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel3})
        Me.dbExpLaboral.Dpi = 254.0!
        Me.dbExpLaboral.HeightF = 519.2869!
        Me.dbExpLaboral.Name = "dbExpLaboral"
        '
        'XrLabel3
        '
        Me.XrLabel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.XrLabel3.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel3.BorderWidth = 0.5!
        Me.XrLabel3.Dpi = 254.0!
        Me.XrLabel3.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(19.99994!, 57.0!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 5, 254.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(1909.0!, 65.0!)
        Me.XrLabel3.StylePriority.UseBackColor = False
        Me.XrLabel3.StylePriority.UseBorders = False
        Me.XrLabel3.StylePriority.UseBorderWidth = False
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UsePadding = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "Experiencia Laboral"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'drFamiliares
        '
        Me.drFamiliares.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.dbFamiliares, Me.rhFamiliares})
        Me.drFamiliares.Dpi = 254.0!
        Me.drFamiliares.Level = 3
        Me.drFamiliares.Name = "drFamiliares"
        '
        'dbFamiliares
        '
        Me.dbFamiliares.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.tablaFamiliares})
        Me.dbFamiliares.Dpi = 254.0!
        Me.dbFamiliares.HeightF = 44.95654!
        Me.dbFamiliares.Name = "dbFamiliares"
        '
        'tablaFamiliares
        '
        Me.tablaFamiliares.BorderWidth = 0.5!
        Me.tablaFamiliares.Dpi = 254.0!
        Me.tablaFamiliares.LocationFloat = New DevExpress.Utils.PointFloat(24.99997!, 0.0!)
        Me.tablaFamiliares.Name = "tablaFamiliares"
        Me.tablaFamiliares.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 254.0!)
        Me.tablaFamiliares.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.Fila1FM})
        Me.tablaFamiliares.SizeF = New System.Drawing.SizeF(1909.0!, 44.95654!)
        Me.tablaFamiliares.StylePriority.UseBorderWidth = False
        Me.tablaFamiliares.StylePriority.UsePadding = False
        '
        'Fila1FM
        '
        Me.Fila1FM.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.lblTipoDocFM, Me.lblDocFamiliar, Me.lblNombreFamiliar, Me.lblParentesco, Me.lblFechaNacFamiliar})
        Me.Fila1FM.Dpi = 254.0!
        Me.Fila1FM.Name = "Fila1FM"
        Me.Fila1FM.Weight = 1.0R
        '
        'lblTipoDocFM
        '
        Me.lblTipoDocFM.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblTipoDocFM.CanGrow = False
        Me.lblTipoDocFM.Dpi = 254.0!
        Me.lblTipoDocFM.Name = "lblTipoDocFM"
        Me.lblTipoDocFM.StylePriority.UseBorders = False
        Me.lblTipoDocFM.StylePriority.UseTextAlignment = False
        Me.lblTipoDocFM.Text = "CC"
        Me.lblTipoDocFM.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.lblTipoDocFM.Weight = 0.257194296702852R
        '
        'lblDocFamiliar
        '
        Me.lblDocFamiliar.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblDocFamiliar.CanGrow = False
        Me.lblDocFamiliar.Dpi = 254.0!
        Me.lblDocFamiliar.Name = "lblDocFamiliar"
        Me.lblDocFamiliar.StylePriority.UseBorders = False
        Me.lblDocFamiliar.Text = "1117521997"
        Me.lblDocFamiliar.Weight = 0.46558224573215284R
        '
        'lblNombreFamiliar
        '
        Me.lblNombreFamiliar.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblNombreFamiliar.CanGrow = False
        Me.lblNombreFamiliar.Dpi = 254.0!
        Me.lblNombreFamiliar.Name = "lblNombreFamiliar"
        Me.lblNombreFamiliar.StylePriority.UseBorders = False
        Me.lblNombreFamiliar.Text = "Arlington Vargas Mahecha"
        Me.lblNombreFamiliar.Weight = 1.2180205240114583R
        '
        'lblParentesco
        '
        Me.lblParentesco.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblParentesco.CanGrow = False
        Me.lblParentesco.Dpi = 254.0!
        Me.lblParentesco.Name = "lblParentesco"
        Me.lblParentesco.StylePriority.UseBorders = False
        Me.lblParentesco.Text = "Hermano"
        Me.lblParentesco.Weight = 0.55394460961428038R
        '
        'lblFechaNacFamiliar
        '
        Me.lblFechaNacFamiliar.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblFechaNacFamiliar.CanGrow = False
        Me.lblFechaNacFamiliar.Dpi = 254.0!
        Me.lblFechaNacFamiliar.Name = "lblFechaNacFamiliar"
        Me.lblFechaNacFamiliar.StylePriority.UseBorders = False
        Me.lblFechaNacFamiliar.Text = "11/dic/1991"
        Me.lblFechaNacFamiliar.Weight = 0.42868887885241197R
        '
        'rhFamiliares
        '
        Me.rhFamiliares.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lblTiuloFamiliares, Me.lblTitleDocFamiliarFM, Me.lblTitleNomFamiliarFM, Me.lblTitleParentescoFM, Me.lblTitleFecNacFM, Me.lblTitleTipoDocFM})
        Me.rhFamiliares.Dpi = 254.0!
        Me.rhFamiliares.HeightF = 163.75!
        Me.rhFamiliares.Name = "rhFamiliares"
        '
        'lblTiuloFamiliares
        '
        Me.lblTiuloFamiliares.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblTiuloFamiliares.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.lblTiuloFamiliares.BorderWidth = 0.5!
        Me.lblTiuloFamiliares.Dpi = 254.0!
        Me.lblTiuloFamiliares.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTiuloFamiliares.LocationFloat = New DevExpress.Utils.PointFloat(25.0!, 32.24999!)
        Me.lblTiuloFamiliares.Name = "lblTiuloFamiliares"
        Me.lblTiuloFamiliares.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 5, 254.0!)
        Me.lblTiuloFamiliares.SizeF = New System.Drawing.SizeF(1909.0!, 65.0!)
        Me.lblTiuloFamiliares.StylePriority.UseBackColor = False
        Me.lblTiuloFamiliares.StylePriority.UseBorders = False
        Me.lblTiuloFamiliares.StylePriority.UseBorderWidth = False
        Me.lblTiuloFamiliares.StylePriority.UseFont = False
        Me.lblTiuloFamiliares.StylePriority.UsePadding = False
        Me.lblTiuloFamiliares.StylePriority.UseTextAlignment = False
        Me.lblTiuloFamiliares.Text = "Familiares"
        Me.lblTiuloFamiliares.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'lblTitleDocFamiliarFM
        '
        Me.lblTitleDocFamiliarFM.BackColor = System.Drawing.Color.LightGray
        Me.lblTitleDocFamiliarFM.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblTitleDocFamiliarFM.BorderWidth = 0.5!
        Me.lblTitleDocFamiliarFM.Dpi = 254.0!
        Me.lblTitleDocFamiliarFM.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleDocFamiliarFM.LocationFloat = New DevExpress.Utils.PointFloat(192.9478!, 120.75!)
        Me.lblTitleDocFamiliarFM.Name = "lblTitleDocFamiliarFM"
        Me.lblTitleDocFamiliarFM.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 254.0!)
        Me.lblTitleDocFamiliarFM.SizeF = New System.Drawing.SizeF(304.0251!, 42.99998!)
        Me.lblTitleDocFamiliarFM.StylePriority.UseBackColor = False
        Me.lblTitleDocFamiliarFM.StylePriority.UseBorders = False
        Me.lblTitleDocFamiliarFM.StylePriority.UseBorderWidth = False
        Me.lblTitleDocFamiliarFM.StylePriority.UseFont = False
        Me.lblTitleDocFamiliarFM.StylePriority.UsePadding = False
        Me.lblTitleDocFamiliarFM.Text = "Documento"
        '
        'lblTitleNomFamiliarFM
        '
        Me.lblTitleNomFamiliarFM.BackColor = System.Drawing.Color.LightGray
        Me.lblTitleNomFamiliarFM.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblTitleNomFamiliarFM.BorderWidth = 0.5!
        Me.lblTitleNomFamiliarFM.Dpi = 254.0!
        Me.lblTitleNomFamiliarFM.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleNomFamiliarFM.LocationFloat = New DevExpress.Utils.PointFloat(496.973!, 120.75!)
        Me.lblTitleNomFamiliarFM.Name = "lblTitleNomFamiliarFM"
        Me.lblTitleNomFamiliarFM.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 254.0!)
        Me.lblTitleNomFamiliarFM.SizeF = New System.Drawing.SizeF(795.3675!, 43.00002!)
        Me.lblTitleNomFamiliarFM.StylePriority.UseBackColor = False
        Me.lblTitleNomFamiliarFM.StylePriority.UseBorders = False
        Me.lblTitleNomFamiliarFM.StylePriority.UseBorderWidth = False
        Me.lblTitleNomFamiliarFM.StylePriority.UseFont = False
        Me.lblTitleNomFamiliarFM.StylePriority.UsePadding = False
        Me.lblTitleNomFamiliarFM.Text = "Nombre Completo"
        '
        'lblTitleParentescoFM
        '
        Me.lblTitleParentescoFM.BackColor = System.Drawing.Color.LightGray
        Me.lblTitleParentescoFM.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblTitleParentescoFM.BorderWidth = 0.5!
        Me.lblTitleParentescoFM.Dpi = 254.0!
        Me.lblTitleParentescoFM.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleParentescoFM.LocationFloat = New DevExpress.Utils.PointFloat(1292.34!, 120.75!)
        Me.lblTitleParentescoFM.Name = "lblTitleParentescoFM"
        Me.lblTitleParentescoFM.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 254.0!)
        Me.lblTitleParentescoFM.SizeF = New System.Drawing.SizeF(361.7257!, 43.0!)
        Me.lblTitleParentescoFM.StylePriority.UseBackColor = False
        Me.lblTitleParentescoFM.StylePriority.UseBorders = False
        Me.lblTitleParentescoFM.StylePriority.UseBorderWidth = False
        Me.lblTitleParentescoFM.StylePriority.UseFont = False
        Me.lblTitleParentescoFM.StylePriority.UsePadding = False
        Me.lblTitleParentescoFM.Text = "Parentesco"
        '
        'lblTitleFecNacFM
        '
        Me.lblTitleFecNacFM.BackColor = System.Drawing.Color.LightGray
        Me.lblTitleFecNacFM.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblTitleFecNacFM.BorderWidth = 0.5!
        Me.lblTitleFecNacFM.Dpi = 254.0!
        Me.lblTitleFecNacFM.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleFecNacFM.LocationFloat = New DevExpress.Utils.PointFloat(1654.066!, 120.75!)
        Me.lblTitleFecNacFM.Name = "lblTitleFecNacFM"
        Me.lblTitleFecNacFM.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 254.0!)
        Me.lblTitleFecNacFM.SizeF = New System.Drawing.SizeF(279.934!, 43.0!)
        Me.lblTitleFecNacFM.StylePriority.UseBackColor = False
        Me.lblTitleFecNacFM.StylePriority.UseBorders = False
        Me.lblTitleFecNacFM.StylePriority.UseBorderWidth = False
        Me.lblTitleFecNacFM.StylePriority.UseFont = False
        Me.lblTitleFecNacFM.StylePriority.UsePadding = False
        Me.lblTitleFecNacFM.Text = "Fecha Nac."
        '
        'lblTitleTipoDocFM
        '
        Me.lblTitleTipoDocFM.BackColor = System.Drawing.Color.LightGray
        Me.lblTitleTipoDocFM.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblTitleTipoDocFM.BorderWidth = 0.5!
        Me.lblTitleTipoDocFM.Dpi = 254.0!
        Me.lblTitleTipoDocFM.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleTipoDocFM.LocationFloat = New DevExpress.Utils.PointFloat(25.00002!, 120.75!)
        Me.lblTitleTipoDocFM.Name = "lblTitleTipoDocFM"
        Me.lblTitleTipoDocFM.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 254.0!)
        Me.lblTitleTipoDocFM.SizeF = New System.Drawing.SizeF(167.9478!, 42.99998!)
        Me.lblTitleTipoDocFM.StylePriority.UseBackColor = False
        Me.lblTitleTipoDocFM.StylePriority.UseBorders = False
        Me.lblTitleTipoDocFM.StylePriority.UseBorderWidth = False
        Me.lblTitleTipoDocFM.StylePriority.UseFont = False
        Me.lblTitleTipoDocFM.StylePriority.UsePadding = False
        Me.lblTitleTipoDocFM.Text = "Tipo Doc."
        '
        'drAfiliaciones
        '
        Me.drAfiliaciones.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.dbAfiliaciones, Me.rhAfiliaciones})
        Me.drAfiliaciones.Dpi = 254.0!
        Me.drAfiliaciones.Expanded = False
        Me.drAfiliaciones.Level = 4
        Me.drAfiliaciones.Name = "drAfiliaciones"
        '
        'dbAfiliaciones
        '
        Me.dbAfiliaciones.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable2})
        Me.dbAfiliaciones.Dpi = 254.0!
        Me.dbAfiliaciones.HeightF = 44.95654!
        Me.dbAfiliaciones.Name = "dbAfiliaciones"
        '
        'XrTable2
        '
        Me.XrTable2.BorderWidth = 0.5!
        Me.XrTable2.Dpi = 254.0!
        Me.XrTable2.LocationFloat = New DevExpress.Utils.PointFloat(25.0!, 0.0!)
        Me.XrTable2.Name = "XrTable2"
        Me.XrTable2.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 254.0!)
        Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow2})
        Me.XrTable2.SizeF = New System.Drawing.SizeF(1909.0!, 44.95654!)
        Me.XrTable2.StylePriority.UseBorderWidth = False
        Me.XrTable2.StylePriority.UsePadding = False
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.lblEntidad, Me.lblFecRegistroAF, Me.lblRetiradoAF, Me.lblFecRetiroAF, Me.lblCausaRetiroAF})
        Me.XrTableRow2.Dpi = 254.0!
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Weight = 1.0R
        '
        'lblEntidad
        '
        Me.lblEntidad.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblEntidad.CanGrow = False
        Me.lblEntidad.Dpi = 254.0!
        Me.lblEntidad.Name = "lblEntidad"
        Me.lblEntidad.StylePriority.UseBorders = False
        Me.lblEntidad.Text = "LA NUEVA EPS"
        Me.lblEntidad.Weight = 1.0667358153066659R
        '
        'lblFecRegistroAF
        '
        Me.lblFecRegistroAF.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblFecRegistroAF.CanGrow = False
        Me.lblFecRegistroAF.Dpi = 254.0!
        Me.lblFecRegistroAF.Name = "lblFecRegistroAF"
        Me.lblFecRegistroAF.StylePriority.UseBorders = False
        Me.lblFecRegistroAF.Text = "10/oct/2016"
        Me.lblFecRegistroAF.Weight = 0.28790209184913218R
        '
        'lblRetiradoAF
        '
        Me.lblRetiradoAF.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblRetiradoAF.CanGrow = False
        Me.lblRetiradoAF.Dpi = 254.0!
        Me.lblRetiradoAF.Name = "lblRetiradoAF"
        Me.lblRetiradoAF.StylePriority.UseBorders = False
        Me.lblRetiradoAF.StylePriority.UseTextAlignment = False
        Me.lblRetiradoAF.Text = "NO"
        Me.lblRetiradoAF.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.lblRetiradoAF.Weight = 0.1981950928956297R
        '
        'lblFecRetiroAF
        '
        Me.lblFecRetiroAF.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblFecRetiroAF.CanGrow = False
        Me.lblFecRetiroAF.Dpi = 254.0!
        Me.lblFecRetiroAF.Name = "lblFecRetiroAF"
        Me.lblFecRetiroAF.StylePriority.UseBorders = False
        Me.lblFecRetiroAF.Text = "10/oct/2016"
        Me.lblFecRetiroAF.Weight = 0.28330797544523911R
        '
        'lblCausaRetiroAF
        '
        Me.lblCausaRetiroAF.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblCausaRetiroAF.CanGrow = False
        Me.lblCausaRetiroAF.Dpi = 254.0!
        Me.lblCausaRetiroAF.Name = "lblCausaRetiroAF"
        Me.lblCausaRetiroAF.StylePriority.UseBorders = False
        Me.lblCausaRetiroAF.Text = "Ninguna"
        Me.lblCausaRetiroAF.Weight = 1.0872895794164885R
        '
        'rhAfiliaciones
        '
        Me.rhAfiliaciones.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lblTitleEntidadAF, Me.lblTitleCausaRetiro, Me.lblTitleFechaRetiro, Me.lblTitleRetirado, Me.lblTitleFechaRegistro, Me.lblTituloAfiliaciones})
        Me.rhAfiliaciones.Dpi = 254.0!
        Me.rhAfiliaciones.HeightF = 160.75!
        Me.rhAfiliaciones.Name = "rhAfiliaciones"
        '
        'lblTitleEntidadAF
        '
        Me.lblTitleEntidadAF.BackColor = System.Drawing.Color.LightGray
        Me.lblTitleEntidadAF.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblTitleEntidadAF.BorderWidth = 0.5!
        Me.lblTitleEntidadAF.Dpi = 254.0!
        Me.lblTitleEntidadAF.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleEntidadAF.LocationFloat = New DevExpress.Utils.PointFloat(25.00002!, 117.75!)
        Me.lblTitleEntidadAF.Name = "lblTitleEntidadAF"
        Me.lblTitleEntidadAF.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 254.0!)
        Me.lblTitleEntidadAF.SizeF = New System.Drawing.SizeF(696.5784!, 42.99998!)
        Me.lblTitleEntidadAF.StylePriority.UseBackColor = False
        Me.lblTitleEntidadAF.StylePriority.UseBorders = False
        Me.lblTitleEntidadAF.StylePriority.UseBorderWidth = False
        Me.lblTitleEntidadAF.StylePriority.UseFont = False
        Me.lblTitleEntidadAF.StylePriority.UsePadding = False
        Me.lblTitleEntidadAF.Text = "Entidad"
        '
        'lblTitleCausaRetiro
        '
        Me.lblTitleCausaRetiro.BackColor = System.Drawing.Color.LightGray
        Me.lblTitleCausaRetiro.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblTitleCausaRetiro.BorderWidth = 0.5!
        Me.lblTitleCausaRetiro.Dpi = 254.0!
        Me.lblTitleCausaRetiro.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleCausaRetiro.LocationFloat = New DevExpress.Utils.PointFloat(1224.0!, 117.75!)
        Me.lblTitleCausaRetiro.Name = "lblTitleCausaRetiro"
        Me.lblTitleCausaRetiro.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 254.0!)
        Me.lblTitleCausaRetiro.SizeF = New System.Drawing.SizeF(709.9999!, 42.99998!)
        Me.lblTitleCausaRetiro.StylePriority.UseBackColor = False
        Me.lblTitleCausaRetiro.StylePriority.UseBorders = False
        Me.lblTitleCausaRetiro.StylePriority.UseBorderWidth = False
        Me.lblTitleCausaRetiro.StylePriority.UseFont = False
        Me.lblTitleCausaRetiro.StylePriority.UsePadding = False
        Me.lblTitleCausaRetiro.Text = "Causa de Retiro"
        '
        'lblTitleFechaRetiro
        '
        Me.lblTitleFechaRetiro.BackColor = System.Drawing.Color.LightGray
        Me.lblTitleFechaRetiro.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblTitleFechaRetiro.BorderWidth = 0.5!
        Me.lblTitleFechaRetiro.Dpi = 254.0!
        Me.lblTitleFechaRetiro.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleFechaRetiro.LocationFloat = New DevExpress.Utils.PointFloat(1039.0!, 117.75!)
        Me.lblTitleFechaRetiro.Name = "lblTitleFechaRetiro"
        Me.lblTitleFechaRetiro.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 254.0!)
        Me.lblTitleFechaRetiro.SizeF = New System.Drawing.SizeF(185.0!, 43.0!)
        Me.lblTitleFechaRetiro.StylePriority.UseBackColor = False
        Me.lblTitleFechaRetiro.StylePriority.UseBorders = False
        Me.lblTitleFechaRetiro.StylePriority.UseBorderWidth = False
        Me.lblTitleFechaRetiro.StylePriority.UseFont = False
        Me.lblTitleFechaRetiro.StylePriority.UsePadding = False
        Me.lblTitleFechaRetiro.Text = "Fec. Retiro"
        '
        'lblTitleRetirado
        '
        Me.lblTitleRetirado.BackColor = System.Drawing.Color.LightGray
        Me.lblTitleRetirado.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblTitleRetirado.BorderWidth = 0.5!
        Me.lblTitleRetirado.Dpi = 254.0!
        Me.lblTitleRetirado.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleRetirado.LocationFloat = New DevExpress.Utils.PointFloat(909.5784!, 117.75!)
        Me.lblTitleRetirado.Name = "lblTitleRetirado"
        Me.lblTitleRetirado.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 254.0!)
        Me.lblTitleRetirado.SizeF = New System.Drawing.SizeF(129.4216!, 43.00002!)
        Me.lblTitleRetirado.StylePriority.UseBackColor = False
        Me.lblTitleRetirado.StylePriority.UseBorders = False
        Me.lblTitleRetirado.StylePriority.UseBorderWidth = False
        Me.lblTitleRetirado.StylePriority.UseFont = False
        Me.lblTitleRetirado.StylePriority.UsePadding = False
        Me.lblTitleRetirado.Text = "Retirado"
        '
        'lblTitleFechaRegistro
        '
        Me.lblTitleFechaRegistro.BackColor = System.Drawing.Color.LightGray
        Me.lblTitleFechaRegistro.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblTitleFechaRegistro.BorderWidth = 0.5!
        Me.lblTitleFechaRegistro.Dpi = 254.0!
        Me.lblTitleFechaRegistro.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleFechaRegistro.LocationFloat = New DevExpress.Utils.PointFloat(721.5784!, 117.75!)
        Me.lblTitleFechaRegistro.Name = "lblTitleFechaRegistro"
        Me.lblTitleFechaRegistro.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 254.0!)
        Me.lblTitleFechaRegistro.SizeF = New System.Drawing.SizeF(188.0!, 42.99998!)
        Me.lblTitleFechaRegistro.StylePriority.UseBackColor = False
        Me.lblTitleFechaRegistro.StylePriority.UseBorders = False
        Me.lblTitleFechaRegistro.StylePriority.UseBorderWidth = False
        Me.lblTitleFechaRegistro.StylePriority.UseFont = False
        Me.lblTitleFechaRegistro.StylePriority.UsePadding = False
        Me.lblTitleFechaRegistro.Text = "Fec. Registro"
        '
        'lblTituloAfiliaciones
        '
        Me.lblTituloAfiliaciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblTituloAfiliaciones.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.lblTituloAfiliaciones.BorderWidth = 0.5!
        Me.lblTituloAfiliaciones.Dpi = 254.0!
        Me.lblTituloAfiliaciones.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloAfiliaciones.LocationFloat = New DevExpress.Utils.PointFloat(25.0!, 29.24998!)
        Me.lblTituloAfiliaciones.Name = "lblTituloAfiliaciones"
        Me.lblTituloAfiliaciones.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 5, 254.0!)
        Me.lblTituloAfiliaciones.SizeF = New System.Drawing.SizeF(1909.0!, 65.0!)
        Me.lblTituloAfiliaciones.StylePriority.UseBackColor = False
        Me.lblTituloAfiliaciones.StylePriority.UseBorders = False
        Me.lblTituloAfiliaciones.StylePriority.UseBorderWidth = False
        Me.lblTituloAfiliaciones.StylePriority.UseFont = False
        Me.lblTituloAfiliaciones.StylePriority.UsePadding = False
        Me.lblTituloAfiliaciones.StylePriority.UseTextAlignment = False
        Me.lblTituloAfiliaciones.Text = "Afiliaciones"
        Me.lblTituloAfiliaciones.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'RptEmpleado
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.dbDatosBasicos, Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.PageHeader, Me.PageFooter, Me.drInfAcademica, Me.drEducacionNoformal, Me.drExpLaboral, Me.drFamiliares, Me.drAfiliaciones})
        Me.Dpi = 254.0!
        Me.Margins = New System.Drawing.Printing.Margins(100, 100, 150, 100)
        Me.PageHeight = 2794
        Me.PageWidth = 2159
        Me.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.XrControlStyle1})
        Me.Version = "15.2"
        CType(Me.TablaDatosBasicos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tablaCabecera1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tablaFamiliares, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents dbDatosBasicos As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
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
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents lblTituloInforme As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Private WithEvents xrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
    Private WithEvents xrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents lbversionsamit As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lbpc As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lbreviso As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents lblpaginas As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents lblsigpag As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Fecha As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrControlStyle1 As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents TablaDatosBasicos As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents fila1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents lblTitlePapellido As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblTitleSapellido As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblTitleNombres As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents fila2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents lblPApellido As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblSApellido As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblNombres As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents fila3 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents lblTitleDocuemntoId As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblTitleSexo As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblTitleEstCivil As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents fila4 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents lblTipoDoc As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblTitleNumDoc As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblNumDoc As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblSexo As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblEstCivil As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents fila5 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents lblTitleLibretaMilitar As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents fila6 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents lblLibPrimera As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblLibSegunda As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents ckbLibSegunda As DevExpress.XtraReports.UI.XRCheckBox
    Friend WithEvents lblTitleNumLibreta As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblNumLibreta As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblTitleDM As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblDM As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents fila7 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents lblTitleCelular As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblTitleTelefoonos As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblTitleCorreo As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents fila8 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents lblCelular As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblTelefonos As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblCorreo As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents fila9 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents lblTitleFechaLugarNac As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblDireccionResidencia As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents fila10 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents lblTitleFechaNac As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblFechaNac As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents LblDireccionEmpleado As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents fila11 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents lblTitlePaisNac As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblPaisNac As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblTitlePaisResidencia As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblPaisResidencia As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents fila12 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents lblTitleDepNac As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblDepNac As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblTitleDepResidencia As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblDepResidencia As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents fila13 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents lblTitleMuniNac As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblMuniNac As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblTitleMuniResidencia As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblMuniResidencia As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblTitleTipoDoc As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents ckbFemenino As DevExpress.XtraReports.UI.XRCheckBox
    Friend WithEvents ckbMasculino As DevExpress.XtraReports.UI.XRCheckBox
    Friend WithEvents ckbLibPrimera As DevExpress.XtraReports.UI.XRCheckBox
    Friend WithEvents lineAbjDatosBasicos As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents lineDerDatosBasicos As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents lblTitleDatosBasicos As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents ckbNoLibreta As DevExpress.XtraReports.UI.XRCheckBox
    Friend WithEvents drInfAcademica As DevExpress.XtraReports.UI.DetailReportBand
    Friend WithEvents dbInfAcademica As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents drEducacionNoformal As DevExpress.XtraReports.UI.DetailReportBand
    Friend WithEvents dbEducacionNoFormal As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents rhEducacionNoFormal As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents lblTitleNivelEF As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblTitleDuracionEF As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblTitleFechaTerminoEF As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblTitleInstitucionEF As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblTitleDescripcionEF As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents lblNivelEF As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblDescripcionEF As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblInstitucionEF As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblFechaTermancionEF As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblDuracionEF As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents drExpLaboral As DevExpress.XtraReports.UI.DetailReportBand
    Friend WithEvents dbExpLaboral As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents drFamiliares As DevExpress.XtraReports.UI.DetailReportBand
    Friend WithEvents dbFamiliares As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents tablaFamiliares As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents Fila1FM As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents lblTipoDocFM As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblDocFamiliar As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblNombreFamiliar As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblParentesco As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblFechaNacFamiliar As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents rhFamiliares As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents lblTiuloFamiliares As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblTitleDocFamiliarFM As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblTitleNomFamiliarFM As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblTitleParentescoFM As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblTitleFecNacFM As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblTitleTipoDocFM As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents drAfiliaciones As DevExpress.XtraReports.UI.DetailReportBand
    Friend WithEvents dbAfiliaciones As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents rhAfiliaciones As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents lblEntidad As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblFecRegistroAF As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblRetiradoAF As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblFecRetiroAF As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblCausaRetiroAF As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblTitleEntidadAF As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblTitleCausaRetiro As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblTitleFechaRetiro As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblTitleRetirado As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblTitleFechaRegistro As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblTituloAfiliaciones As DevExpress.XtraReports.UI.XRLabel
End Class
