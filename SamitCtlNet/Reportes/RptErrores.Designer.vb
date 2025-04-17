<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class RptErrores
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
        Me.Linea = New DevExpress.XtraReports.UI.XRLabel()
        Me.DescError = New DevExpress.XtraReports.UI.XRLabel()
        Me.Referencia = New DevExpress.XtraReports.UI.XRLabel()
        Me.Sec = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.LogoImg = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.NombreEmpresa = New DevExpress.XtraReports.UI.XRLabel()
        Me.Nit = New DevExpress.XtraReports.UI.XRLabel()
        Me.Titulo = New DevExpress.XtraReports.UI.XRLabel()
        Me.ProcesoNombre = New DevExpress.XtraReports.UI.XRLabel()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.LblTerminal = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.LblUsuario = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Linea, Me.DescError, Me.Referencia, Me.Sec})
        Me.Detail.HeightF = 18.75!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'Linea
        '
        Me.Linea.Font = New System.Drawing.Font("Times New Roman", 8.0!)
        Me.Linea.LocationFloat = New DevExpress.Utils.PointFloat(40.625!, 0.0!)
        Me.Linea.Name = "Linea"
        Me.Linea.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Linea.SizeF = New System.Drawing.SizeF(40.625!, 15.70833!)
        Me.Linea.StylePriority.UseFont = False
        Me.Linea.StylePriority.UseTextAlignment = False
        Me.Linea.Text = "Linea"
        Me.Linea.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'DescError
        '
        Me.DescError.LocationFloat = New DevExpress.Utils.PointFloat(221.875!, 0.0!)
        Me.DescError.Name = "DescError"
        Me.DescError.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.DescError.SizeF = New System.Drawing.SizeF(580.1249!, 15.70833!)
        Me.DescError.StylePriority.UseTextAlignment = False
        Me.DescError.Text = "Descripcion Error"
        Me.DescError.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Referencia
        '
        Me.Referencia.LocationFloat = New DevExpress.Utils.PointFloat(81.25002!, 0.0!)
        Me.Referencia.Name = "Referencia"
        Me.Referencia.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Referencia.SizeF = New System.Drawing.SizeF(140.625!, 15.70833!)
        Me.Referencia.StylePriority.UseTextAlignment = False
        Me.Referencia.Text = "Referencia"
        Me.Referencia.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Sec
        '
        Me.Sec.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.Sec.Name = "Sec"
        Me.Sec.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Sec.SizeF = New System.Drawing.SizeF(40.625!, 15.70833!)
        Me.Sec.StylePriority.UseTextAlignment = False
        Me.Sec.Text = "Sec"
        Me.Sec.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 8.708365!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 21.08339!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.LogoImg, Me.NombreEmpresa, Me.Nit, Me.Titulo, Me.ProcesoNombre})
        Me.ReportHeader.HeightF = 84.375!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'LogoImg
        '
        Me.LogoImg.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.LogoImg.Name = "LogoImg"
        Me.LogoImg.SizeF = New System.Drawing.SizeF(100.0!, 79.54169!)
        Me.LogoImg.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'NombreEmpresa
        '
        Me.NombreEmpresa.LocationFloat = New DevExpress.Utils.PointFloat(99.99989!, 0.0!)
        Me.NombreEmpresa.Name = "NombreEmpresa"
        Me.NombreEmpresa.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.NombreEmpresa.SizeF = New System.Drawing.SizeF(702.0001!, 21.75!)
        Me.NombreEmpresa.Text = "NombreEmpresa"
        '
        'Nit
        '
        Me.Nit.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.Nit.LocationFloat = New DevExpress.Utils.PointFloat(99.99984!, 21.75001!)
        Me.Nit.Name = "Nit"
        Me.Nit.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Nit.SizeF = New System.Drawing.SizeF(702.0001!, 16.75!)
        Me.Nit.StylePriority.UseFont = False
        Me.Nit.Text = "NombreEmpresa"
        '
        'Titulo
        '
        Me.Titulo.LocationFloat = New DevExpress.Utils.PointFloat(99.99989!, 42.5!)
        Me.Titulo.Name = "Titulo"
        Me.Titulo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Titulo.SizeF = New System.Drawing.SizeF(702.0001!, 16.75!)
        Me.Titulo.StylePriority.UseTextAlignment = False
        Me.Titulo.Text = "LISTADO DE ERRORES"
        Me.Titulo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'ProcesoNombre
        '
        Me.ProcesoNombre.LocationFloat = New DevExpress.Utils.PointFloat(99.99989!, 62.7917!)
        Me.ProcesoNombre.Name = "ProcesoNombre"
        Me.ProcesoNombre.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.ProcesoNombre.SizeF = New System.Drawing.SizeF(702.0001!, 16.75!)
        Me.ProcesoNombre.StylePriority.UseTextAlignment = False
        Me.ProcesoNombre.Text = "NOMBRE PROCESO"
        Me.ProcesoNombre.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'PageHeader
        '
        Me.PageHeader.BackColor = System.Drawing.Color.Black
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel7, Me.XrLabel3, Me.XrLabel2, Me.XrLabel1})
        Me.PageHeader.ForeColor = System.Drawing.Color.White
        Me.PageHeader.HeightF = 13.62502!
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.StylePriority.UseBackColor = False
        Me.PageHeader.StylePriority.UseForeColor = False
        '
        'XrLabel7
        '
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(41.62499!, 0.0!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(40.625!, 13.0!)
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        Me.XrLabel7.Text = "Linea"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel3
        '
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(221.875!, 0.0!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(580.1248!, 13.0!)
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "Descripción Larga del Error"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel2
        '
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(82.24998!, 0.0!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(138.4167!, 13.0!)
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "Referencia"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel1
        '
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(1.0!, 0.0!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(40.625!, 13.0!)
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "Sec"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine1, Me.XrPageInfo2, Me.LblTerminal, Me.XrLabel6, Me.LblUsuario, Me.XrLabel5, Me.XrPageInfo1, Me.XrLabel4})
        Me.PageFooter.HeightF = 20.74998!
        Me.PageFooter.Name = "PageFooter"
        '
        'XrLine1
        '
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(802.0833!, 2.0!)
        '
        'XrPageInfo2
        '
        Me.XrPageInfo2.Format = "Página {0} de {1}"
        Me.XrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(701.9999!, 2.0!)
        Me.XrPageInfo2.Name = "XrPageInfo2"
        Me.XrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo2.SizeF = New System.Drawing.SizeF(100.0!, 15.70833!)
        '
        'LblTerminal
        '
        Me.LblTerminal.LocationFloat = New DevExpress.Utils.PointFloat(541.6667!, 2.0!)
        Me.LblTerminal.Name = "LblTerminal"
        Me.LblTerminal.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.LblTerminal.SizeF = New System.Drawing.SizeF(160.3332!, 15.70833!)
        Me.LblTerminal.StylePriority.UseTextAlignment = False
        Me.LblTerminal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel6
        '
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(473.9583!, 2.0!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(67.70834!, 15.70833!)
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.Text = "Terminal : "
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'LblUsuario
        '
        Me.LblUsuario.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsuario.LocationFloat = New DevExpress.Utils.PointFloat(371.8749!, 2.0!)
        Me.LblUsuario.Name = "LblUsuario"
        Me.LblUsuario.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.LblUsuario.SizeF = New System.Drawing.SizeF(102.0834!, 15.70833!)
        Me.LblUsuario.StylePriority.UseFont = False
        Me.LblUsuario.StylePriority.UseTextAlignment = False
        Me.LblUsuario.Text = "Sec"
        Me.LblUsuario.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel5
        '
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(304.1666!, 2.0!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(67.70834!, 15.70833!)
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "Usuario: "
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.Format = "{0:d 'de' MMMM 'de' yyyy HH:mm}"
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(85.41666!, 2.0!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(218.75!, 15.70833!)
        '
        'XrLabel4
        '
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 2.0!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(85.41666!, 15.70833!)
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "Procesado el :"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'RptErrores
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.PageHeader, Me.PageFooter})
        Me.Margins = New System.Drawing.Printing.Margins(24, 24, 9, 21)
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.Version = "15.2"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents Sec As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents DescError As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Referencia As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents LogoImg As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents NombreEmpresa As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Nit As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Titulo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ProcesoNombre As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents LblUsuario As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents LblTerminal As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents Linea As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
End Class
