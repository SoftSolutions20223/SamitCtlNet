Imports DevExpress.XtraBars.Ribbon

Public Class HelperEmpleado
    Public Enum TiposDeImagenes
        Empleado = 0
        Familiares = 1
        Estduios = 2
        ExperienciaLaboral = 3
        Afiliaciones = 4
    End Enum
    Public Sub CreaImprimeInfAcademica(RPT As RptEmpleado,
                                      UbiTablaEnY As Single,
                                      UbiLineaDerY As Single,
                                      UbiLineaAbjY As Single,
                                      NivelEducativo As String,
                                      Titulo As String,
                                      InstitucionObtTitulo As String,
                                      MatProfesional As String,
                                      Duracion As String,
                                      FechaTermino As String,
                                      Pais As String,
                                      Depto As String,
                                      Municipio As String)

        Dim lineInfAcademicaAbj As New DevExpress.XtraReports.UI.XRLine
        Dim lineInfAcademicaDer As New DevExpress.XtraReports.UI.XRLine
        Dim XrTable1 As New DevExpress.XtraReports.UI.XRTable
        Dim XrTableRow1 As New DevExpress.XtraReports.UI.XRTableRow
        Dim XrTableRow2 As New DevExpress.XtraReports.UI.XRTableRow
        Dim XrTableRow3 As New DevExpress.XtraReports.UI.XRTableRow
        Dim XrTableRow4 As New DevExpress.XtraReports.UI.XRTableRow
        Dim XrTableRow5 As New DevExpress.XtraReports.UI.XRTableRow
        Dim XrTableRow6 As New DevExpress.XtraReports.UI.XRTableRow
        Dim lblTitleNivelEducativo As New DevExpress.XtraReports.UI.XRTableCell
        Dim lblTitleTituloObtenido As New DevExpress.XtraReports.UI.XRTableCell
        Dim lblNivelEducativo As New DevExpress.XtraReports.UI.XRTableCell
        Dim lblTituloObtenido As New DevExpress.XtraReports.UI.XRTableCell
        Dim lblTitleLugarObtuvoTitulo As New DevExpress.XtraReports.UI.XRTableCell
        Dim lblPaisObtTitulo As New DevExpress.XtraReports.UI.XRTableCell
        Dim lblTitleMatProfesional As New DevExpress.XtraReports.UI.XRTableCell
        Dim lblTitleFechaTermino As New DevExpress.XtraReports.UI.XRTableCell
        Dim lblTitleDepObtTitulo As New DevExpress.XtraReports.UI.XRTableCell
        Dim lblDepObtTitulo As New DevExpress.XtraReports.UI.XRTableCell
        Dim lblMatProfesional As New DevExpress.XtraReports.UI.XRTableCell
        Dim lblFechaTermino As New DevExpress.XtraReports.UI.XRTableCell
        Dim lblTitleMuniObtTitulo As New DevExpress.XtraReports.UI.XRTableCell
        Dim lblMuniObtTitulo As New DevExpress.XtraReports.UI.XRTableCell
        Dim lblTitleNombreInstitucion As New DevExpress.XtraReports.UI.XRTableCell
        Dim lblNombreInstitucion As New DevExpress.XtraReports.UI.XRTableCell
        Dim lblTitlePaisObtTitulo As New DevExpress.XtraReports.UI.XRTableCell
        Dim lblTitleDuracion As New DevExpress.XtraReports.UI.XRTableCell
        Dim lblDuracion As New DevExpress.XtraReports.UI.XRTableCell

        RPT.dbInfAcademica.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {lineInfAcademicaAbj, lineInfAcademicaDer, XrTable1})

        'TABLA
        XrTable1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        XrTable1.BorderWidth = 0.5!
        XrTable1.Dpi = 254.0!
        XrTable1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(25, UbiTablaEnY)
        XrTable1.Padding = New DevExpress.XtraPrinting.PaddingInfo(12, 5, 5, 5, 254.0!)
        XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {XrTableRow1, XrTableRow2, XrTableRow3, XrTableRow4, XrTableRow5, XrTableRow6})
        XrTable1.SizeF = New System.Drawing.SizeF(1909.0!, 335.0!)
        XrTable1.StylePriority.UseBorders = False
        XrTable1.StylePriority.UseBorderWidth = False
        XrTable1.StylePriority.UseFont = False
        XrTable1.StylePriority.UsePadding = False
        XrTable1.StylePriority.UseTextAlignment = False
        XrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify
        XrTable1.BackColor = Color.WhiteSmoke

        XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {lblTitleNivelEducativo, lblTitleTituloObtenido})
        XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {lblNivelEducativo, lblTituloObtenido})
        XrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {lblTitleNombreInstitucion, lblTitleLugarObtuvoTitulo})
        XrTableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {lblNombreInstitucion, lblTitlePaisObtTitulo, lblPaisObtTitulo})
        XrTableRow5.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {lblTitleMatProfesional, lblTitleDuracion, lblTitleFechaTermino, lblTitleDepObtTitulo, lblDepObtTitulo})
        XrTableRow6.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {lblMatProfesional, lblDuracion, lblFechaTermino, lblTitleMuniObtTitulo, lblMuniObtTitulo})


        'lblTitleNivelEducativo
        lblTitleNivelEducativo.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        lblTitleNivelEducativo.Dpi = 254.0!
        lblTitleNivelEducativo.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblTitleNivelEducativo.StylePriority.UseBorders = False
        lblTitleNivelEducativo.StylePriority.UseFont = False
        lblTitleNivelEducativo.Text = "NIVEL EDUCATIVO"
        lblTitleNivelEducativo.Weight = 0.7071765934221298R

        'lblTitleTituloObtenido
        lblTitleTituloObtenido.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        lblTitleTituloObtenido.Dpi = 254.0!
        lblTitleTituloObtenido.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblTitleTituloObtenido.StylePriority.UseBorders = False
        lblTitleTituloObtenido.StylePriority.UseFont = False
        lblTitleTituloObtenido.Text = "TITULO OBTENIDO"
        lblTitleTituloObtenido.Weight = 2.2928234065778703R


        'lblNivelEducativo
        lblNivelEducativo.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        lblNivelEducativo.CanGrow = False
        lblNivelEducativo.Dpi = 254.0!
        lblNivelEducativo.Padding = New DevExpress.XtraPrinting.PaddingInfo(13, 5, 2, 5, 254.0!)
        lblNivelEducativo.StylePriority.UseBorders = False
        lblNivelEducativo.StylePriority.UsePadding = False
        lblNivelEducativo.StylePriority.UseTextAlignment = False
        lblNivelEducativo.Text = StrConv(NivelEducativo, VbStrConv.ProperCase)
        lblNivelEducativo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        lblNivelEducativo.Weight = 0.70717649750516776R

        'lblTituloObtenido
        lblTituloObtenido.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        lblTituloObtenido.CanGrow = False
        lblTituloObtenido.Dpi = 254.0!
        lblTituloObtenido.Padding = New DevExpress.XtraPrinting.PaddingInfo(13, 5, 2, 3, 254.0!)
        lblTituloObtenido.StylePriority.UseBorders = False
        lblTituloObtenido.StylePriority.UsePadding = False
        lblTituloObtenido.StylePriority.UseTextAlignment = False
        lblTituloObtenido.Text = StrConv(Titulo, VbStrConv.ProperCase)
        lblTituloObtenido.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        lblTituloObtenido.Weight = 2.2928235024948322R


        'lblTitleNombreInstitucion
        lblTitleNombreInstitucion.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        lblTitleNombreInstitucion.Dpi = 254.0!
        lblTitleNombreInstitucion.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblTitleNombreInstitucion.StylePriority.UseBorders = False
        lblTitleNombreInstitucion.StylePriority.UseFont = False
        lblTitleNombreInstitucion.Text = "NOMBRE DE LA INSTITUCION"
        lblTitleNombreInstitucion.Weight = 1.7687599989436347R

        'lblTitleLugarObtuvoTitulo
        lblTitleLugarObtuvoTitulo.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        lblTitleLugarObtuvoTitulo.Dpi = 254.0!
        lblTitleLugarObtuvoTitulo.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblTitleLugarObtuvoTitulo.StylePriority.UseBorders = False
        lblTitleLugarObtuvoTitulo.StylePriority.UseFont = False
        lblTitleLugarObtuvoTitulo.Text = "LUGAR DONDE OBTUVO EL TITULO"
        lblTitleLugarObtuvoTitulo.Weight = 1.2312400010563653R

        'lblNombreInstitucion
        lblNombreInstitucion.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        lblNombreInstitucion.CanGrow = False
        lblNombreInstitucion.Dpi = 254.0!
        lblNombreInstitucion.Padding = New DevExpress.XtraPrinting.PaddingInfo(13, 5, 2, 5, 254.0!)
        lblNombreInstitucion.StylePriority.UseBorders = False
        lblNombreInstitucion.StylePriority.UsePadding = False
        lblNombreInstitucion.StylePriority.UseTextAlignment = False
        lblNombreInstitucion.Text = StrConv(InstitucionObtTitulo, VbStrConv.ProperCase)
        lblNombreInstitucion.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        lblNombreInstitucion.Weight = 1.7687599989436345R

        'lblTitlePaisObtTitulo
        lblTitlePaisObtTitulo.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        lblTitlePaisObtTitulo.Dpi = 254.0!
        lblTitlePaisObtTitulo.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblTitlePaisObtTitulo.Padding = New DevExpress.XtraPrinting.PaddingInfo(13, 5, 2, 5, 254.0!)
        lblTitlePaisObtTitulo.StylePriority.UseBorders = False
        lblTitlePaisObtTitulo.StylePriority.UseFont = False
        lblTitlePaisObtTitulo.StylePriority.UsePadding = False
        lblTitlePaisObtTitulo.StylePriority.UseTextAlignment = False
        lblTitlePaisObtTitulo.Text = "Pais"
        lblTitlePaisObtTitulo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        lblTitlePaisObtTitulo.Weight = 0.41742352077021067R

        'lblPaisObtTitulo
        lblPaisObtTitulo.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        lblPaisObtTitulo.CanGrow = False
        lblPaisObtTitulo.Dpi = 254.0!
        lblPaisObtTitulo.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblPaisObtTitulo.Padding = New DevExpress.XtraPrinting.PaddingInfo(13, 5, 2, 5, 254.0!)
        lblPaisObtTitulo.StylePriority.UseBorders = False
        lblPaisObtTitulo.StylePriority.UseFont = False
        lblPaisObtTitulo.StylePriority.UsePadding = False
        lblPaisObtTitulo.StylePriority.UseTextAlignment = False
        lblPaisObtTitulo.Text = StrConv(Pais, VbStrConv.ProperCase)
        lblPaisObtTitulo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        lblPaisObtTitulo.Weight = 0.81381648028615494R

        'lblTitleMatProfesional
        lblTitleMatProfesional.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        lblTitleMatProfesional.Dpi = 254.0!
        lblTitleMatProfesional.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblTitleMatProfesional.StylePriority.UseBorders = False
        lblTitleMatProfesional.StylePriority.UseFont = False
        lblTitleMatProfesional.Text = "MATRICULA PROFESIONAL"
        lblTitleMatProfesional.Weight = 0.70717653747056874R

        'lblTitleDuracion
        lblTitleDuracion.Borders = DevExpress.XtraPrinting.BorderSide.Left
        lblTitleDuracion.Dpi = 254.0!
        lblTitleDuracion.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblTitleDuracion.StylePriority.UseBorders = False
        lblTitleDuracion.StylePriority.UseFont = False
        lblTitleDuracion.Text = "DURACION"
        lblTitleDuracion.Weight = 0.53079171475037268R

        'lblTitleFechaTermino
        lblTitleFechaTermino.Borders = DevExpress.XtraPrinting.BorderSide.Left
        lblTitleFechaTermino.Dpi = 254.0!
        lblTitleFechaTermino.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblTitleFechaTermino.StylePriority.UseBorders = False
        lblTitleFechaTermino.StylePriority.UseFont = False
        lblTitleFechaTermino.Text = "FECHA TERMINO"
        lblTitleFechaTermino.Weight = 0.53079171475037268R

        'lblTitleDepObtTitulo
        lblTitleDepObtTitulo.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        lblTitleDepObtTitulo.Dpi = 254.0!
        lblTitleDepObtTitulo.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblTitleDepObtTitulo.Padding = New DevExpress.XtraPrinting.PaddingInfo(13, 5, 2, 5, 254.0!)
        lblTitleDepObtTitulo.StylePriority.UseBorders = False
        lblTitleDepObtTitulo.StylePriority.UseFont = False
        lblTitleDepObtTitulo.StylePriority.UsePadding = False
        lblTitleDepObtTitulo.StylePriority.UseTextAlignment = False
        lblTitleDepObtTitulo.Text = "Departamento"
        lblTitleDepObtTitulo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        lblTitleDepObtTitulo.Weight = 0.41742312910928242R

        'lblDepObtTitulo
        lblDepObtTitulo.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        lblDepObtTitulo.CanGrow = False
        lblDepObtTitulo.Dpi = 254.0!
        lblDepObtTitulo.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblDepObtTitulo.Padding = New DevExpress.XtraPrinting.PaddingInfo(13, 5, 2, 5, 254.0!)
        lblDepObtTitulo.StylePriority.UseBorders = False
        lblDepObtTitulo.StylePriority.UseFont = False
        lblDepObtTitulo.StylePriority.UsePadding = False
        lblDepObtTitulo.StylePriority.UseTextAlignment = False
        lblDepObtTitulo.Text = StrConv(Depto, VbStrConv.ProperCase)
        lblDepObtTitulo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        lblDepObtTitulo.Weight = 0.81381690391940376R


        'lblMatProfesional
        lblMatProfesional.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        lblMatProfesional.CanGrow = False
        lblMatProfesional.Dpi = 254.0!
        lblMatProfesional.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblMatProfesional.Padding = New DevExpress.XtraPrinting.PaddingInfo(13, 5, 2, 5, 254.0!)
        lblMatProfesional.StylePriority.UseBorders = False
        lblMatProfesional.StylePriority.UseFont = False
        lblMatProfesional.StylePriority.UsePadding = False
        lblMatProfesional.StylePriority.UseTextAlignment = False
        lblMatProfesional.Text = MatProfesional
        lblMatProfesional.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        lblMatProfesional.Weight = 0.70717653747056874R

        'lblDuracion
        lblDuracion.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        lblDuracion.CanGrow = False
        lblDuracion.Dpi = 254.0!
        lblDuracion.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblDuracion.Padding = New DevExpress.XtraPrinting.PaddingInfo(13, 5, 2, 5, 254.0!)
        lblDuracion.StylePriority.UseBorders = False
        lblDuracion.StylePriority.UseFont = False
        lblDuracion.StylePriority.UsePadding = False
        lblDuracion.StylePriority.UseTextAlignment = False
        lblDuracion.Text = Duracion
        lblDuracion.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        lblDuracion.Weight = 0.53079171475037268R

        'lblFechaTermino
        lblFechaTermino.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        lblFechaTermino.CanGrow = False
        lblFechaTermino.Dpi = 254.0!
        lblFechaTermino.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblFechaTermino.Padding = New DevExpress.XtraPrinting.PaddingInfo(13, 5, 2, 5, 254.0!)
        lblFechaTermino.StylePriority.UseBorders = False
        lblFechaTermino.StylePriority.UseFont = False
        lblFechaTermino.StylePriority.UsePadding = False
        lblFechaTermino.StylePriority.UseTextAlignment = False
        lblFechaTermino.Text = FechaTermino
        lblFechaTermino.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        lblFechaTermino.Weight = 0.53079171475037268R

        'lblTitleMuniObtTitulo
        lblTitleMuniObtTitulo.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        lblTitleMuniObtTitulo.Dpi = 254.0!
        lblTitleMuniObtTitulo.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblTitleMuniObtTitulo.Padding = New DevExpress.XtraPrinting.PaddingInfo(13, 5, 2, 5, 254.0!)
        lblTitleMuniObtTitulo.StylePriority.UseBorders = False
        lblTitleMuniObtTitulo.StylePriority.UseFont = False
        lblTitleMuniObtTitulo.StylePriority.UsePadding = False
        lblTitleMuniObtTitulo.StylePriority.UseTextAlignment = False
        lblTitleMuniObtTitulo.Text = "Minicipio"
        lblTitleMuniObtTitulo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        lblTitleMuniObtTitulo.Weight = 0.41742332094320644R

        'lblMuniObtTitulo
        lblMuniObtTitulo.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        lblMuniObtTitulo.CanGrow = False
        lblMuniObtTitulo.Dpi = 254.0!
        lblMuniObtTitulo.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblMuniObtTitulo.Padding = New DevExpress.XtraPrinting.PaddingInfo(13, 5, 2, 5, 254.0!)
        lblMuniObtTitulo.StylePriority.UseBorders = False
        lblMuniObtTitulo.StylePriority.UseFont = False
        lblMuniObtTitulo.StylePriority.UsePadding = False
        lblMuniObtTitulo.StylePriority.UseTextAlignment = False
        lblMuniObtTitulo.Text = StrConv(Municipio, VbStrConv.ProperCase)
        lblMuniObtTitulo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        lblMuniObtTitulo.Weight = 0.81381671208547979R

        'LINEA DERECHA
        lineInfAcademicaDer.BorderWidth = 0.0!
        lineInfAcademicaDer.Dpi = 254.0!
        lineInfAcademicaDer.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical
        lineInfAcademicaDer.LineWidth = 10
        lineInfAcademicaDer.LocationFloat = New DevExpress.Utils.PointFloat(1934, UbiLineaDerY)
        lineInfAcademicaDer.SizeF = New System.Drawing.SizeF(10.00012!, 331.4227!)
        lineInfAcademicaDer.StylePriority.UseBorderWidth = False

        'LINEA INFERIOR
        lineInfAcademicaAbj.BorderWidth = 0.0!
        lineInfAcademicaAbj.Dpi = 254.0!
        lineInfAcademicaAbj.LineWidth = 10
        lineInfAcademicaAbj.LocationFloat = New DevExpress.Utils.PointFloat(39.26, UbiLineaAbjY)
        lineInfAcademicaAbj.SizeF = New System.Drawing.SizeF(1904.745!, 10.00006!)
        lineInfAcademicaAbj.StylePriority.UseBorderWidth = False
    End Sub

    Public Sub CreaImprimeExperienciaLaboral(RPT As RptEmpleado,
                                             UbiTablaY As Single,
                                             UbiLineaDerEnY As Single,
                                             UbiLineaAbjEnY As Single,
                                             Empresa As String,
                                             Cargo As String,
                                             FechaIni As String,
                                             FechaFin As String,
                                             Telefonos As String,
                                             Direccion As String,
                                             Jefe As String)

        Dim tablaExpLaboral = New DevExpress.XtraReports.UI.XRTable()
        Dim Fila1EL = New DevExpress.XtraReports.UI.XRTableRow()
        Dim Fila2EL = New DevExpress.XtraReports.UI.XRTableRow()
        Dim Fila3EL = New DevExpress.XtraReports.UI.XRTableRow()
        Dim Fila4EL = New DevExpress.XtraReports.UI.XRTableRow()
        Dim Fila5EL = New DevExpress.XtraReports.UI.XRTableRow()
        Dim Fila6EL = New DevExpress.XtraReports.UI.XRTableRow()
        Dim LineaExpLaboralAbj = New DevExpress.XtraReports.UI.XRLine()
        Dim LineaExpLaboralDer = New DevExpress.XtraReports.UI.XRLine()
        Dim lblTitleEmpresaEL = New DevExpress.XtraReports.UI.XRTableCell()
        Dim lblTitleCargoEL = New DevExpress.XtraReports.UI.XRTableCell()
        Dim lblEmpresaEL = New DevExpress.XtraReports.UI.XRTableCell()
        Dim lblCargoEL = New DevExpress.XtraReports.UI.XRTableCell()
        Dim lblTitleFecIniEL = New DevExpress.XtraReports.UI.XRTableCell()
        Dim lblTitleTelsEmpEL = New DevExpress.XtraReports.UI.XRTableCell()
        Dim lblFecIniEL = New DevExpress.XtraReports.UI.XRTableCell()
        Dim lblFecFinEL = New DevExpress.XtraReports.UI.XRTableCell()
        Dim lblTelsEmpEL = New DevExpress.XtraReports.UI.XRTableCell()
        Dim lblTitleDirEmpEL = New DevExpress.XtraReports.UI.XRTableCell()
        Dim lblTitleJefeEL = New DevExpress.XtraReports.UI.XRTableCell()
        Dim lblDirEmpEL = New DevExpress.XtraReports.UI.XRTableCell()
        Dim lblJefeEL = New DevExpress.XtraReports.UI.XRTableCell()
        Dim lblTitleFecFinEL = New DevExpress.XtraReports.UI.XRTableCell()

        RPT.dbExpLaboral.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {tablaExpLaboral, LineaExpLaboralAbj, LineaExpLaboralDer})


        'TABLA
        tablaExpLaboral.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        tablaExpLaboral.BorderWidth = 0.5!
        tablaExpLaboral.Dpi = 254.0!
        tablaExpLaboral.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        tablaExpLaboral.LocationFloat = New DevExpress.Utils.PointFloat(25.0!, UbiTablaY)
        tablaExpLaboral.Padding = New DevExpress.XtraPrinting.PaddingInfo(12, 5, 5, 5, 254.0!)
        tablaExpLaboral.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Fila1EL, Fila2EL, Fila3EL, Fila4EL, Fila5EL, Fila6EL})
        tablaExpLaboral.SizeF = New System.Drawing.SizeF(1909.0!, 335.0!)
        tablaExpLaboral.StylePriority.UseBorders = False
        tablaExpLaboral.StylePriority.UseBorderWidth = False
        tablaExpLaboral.StylePriority.UseFont = False
        tablaExpLaboral.StylePriority.UsePadding = False
        tablaExpLaboral.StylePriority.UseTextAlignment = False
        tablaExpLaboral.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify
        tablaExpLaboral.BackColor = Color.WhiteSmoke

        'FILAS
        Fila1EL.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {lblTitleEmpresaEL, lblTitleCargoEL})
        Fila2EL.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {lblEmpresaEL, lblCargoEL})
        Fila3EL.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {lblTitleFecIniEL, lblTitleFecFinEL, lblTitleTelsEmpEL})
        Fila4EL.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {lblFecIniEL, lblFecFinEL, lblTelsEmpEL})
        Fila5EL.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {lblTitleDirEmpEL, lblTitleJefeEL})
        Fila6EL.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {lblDirEmpEL, lblJefeEL})

        'lblTitleEmpresaEL
        lblTitleEmpresaEL.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        lblTitleEmpresaEL.Dpi = 254.0!
        lblTitleEmpresaEL.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblTitleEmpresaEL.StylePriority.UseBorders = False
        lblTitleEmpresaEL.StylePriority.UseFont = False
        lblTitleEmpresaEL.Text = "EMPRESA"
        lblTitleEmpresaEL.Weight = 1.3551214319644784R

        'lblTitleCargoEL
        lblTitleCargoEL.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        lblTitleCargoEL.Dpi = 254.0!
        lblTitleCargoEL.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblTitleCargoEL.StylePriority.UseBorders = False
        lblTitleCargoEL.StylePriority.UseFont = False
        lblTitleCargoEL.Text = "CARGO"
        lblTitleCargoEL.Weight = 1.6448785680355218R

        'lblEmpresaEL
        lblEmpresaEL.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        lblEmpresaEL.CanGrow = False
        lblEmpresaEL.Dpi = 254.0!
        lblEmpresaEL.Padding = New DevExpress.XtraPrinting.PaddingInfo(13, 5, 2, 5, 254.0!)
        lblEmpresaEL.StylePriority.UseBorders = False
        lblEmpresaEL.StylePriority.UsePadding = False
        lblEmpresaEL.StylePriority.UseTextAlignment = False
        lblEmpresaEL.Text = Empresa
        lblEmpresaEL.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        lblEmpresaEL.Weight = 1.3551214319644722R

        'lblCargoEL
        lblCargoEL.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        lblCargoEL.CanGrow = False
        lblCargoEL.Dpi = 254.0!
        lblCargoEL.Padding = New DevExpress.XtraPrinting.PaddingInfo(13, 5, 2, 3, 254.0!)
        lblCargoEL.StylePriority.UseBorders = False
        lblCargoEL.StylePriority.UsePadding = False
        lblCargoEL.StylePriority.UseTextAlignment = False
        lblCargoEL.Text = Cargo
        lblCargoEL.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        lblCargoEL.Weight = 1.6448785680355278R

        'lblTitleFecIniEL
        lblTitleFecIniEL.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        lblTitleFecIniEL.Dpi = 254.0!
        lblTitleFecIniEL.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblTitleFecIniEL.StylePriority.UseBorders = False
        lblTitleFecIniEL.StylePriority.UseFont = False
        lblTitleFecIniEL.Text = "FECHA INICIO"
        lblTitleFecIniEL.Weight = 0.53431117485993584R

        'lblTitleTelsEmpEL
        lblTitleTelsEmpEL.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        lblTitleTelsEmpEL.Dpi = 254.0!
        lblTitleTelsEmpEL.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblTitleTelsEmpEL.StylePriority.UseBorders = False
        lblTitleTelsEmpEL.StylePriority.UseFont = False
        lblTitleTelsEmpEL.Text = "TELEFONOS"
        lblTitleTelsEmpEL.Weight = 1.9313776760587698R

        'lblFecIniEL
        lblFecIniEL.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        lblFecIniEL.CanGrow = False
        lblFecIniEL.Dpi = 254.0!
        lblFecIniEL.Padding = New DevExpress.XtraPrinting.PaddingInfo(13, 5, 2, 5, 254.0!)
        lblFecIniEL.StylePriority.UseBorders = False
        lblFecIniEL.StylePriority.UsePadding = False
        lblFecIniEL.StylePriority.UseTextAlignment = False
        lblFecIniEL.Text = FechaIni
        lblFecIniEL.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        lblFecIniEL.Weight = 0.53431117485993562R

        'lblFecFinEL
        lblFecFinEL.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        lblFecFinEL.Dpi = 254.0!
        lblFecFinEL.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        lblFecFinEL.Padding = New DevExpress.XtraPrinting.PaddingInfo(13, 5, 2, 5, 254.0!)
        lblFecFinEL.StylePriority.UseBorders = False
        lblFecFinEL.StylePriority.UseFont = False
        lblFecFinEL.StylePriority.UsePadding = False
        lblFecFinEL.StylePriority.UseTextAlignment = False
        lblFecFinEL.Text = FechaFin
        lblFecFinEL.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        lblFecFinEL.Weight = 0.53431113640769268R

        'lblTelsEmpEL
        lblTelsEmpEL.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        lblTelsEmpEL.CanGrow = False
        lblTelsEmpEL.Dpi = 254.0!
        lblTelsEmpEL.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblTelsEmpEL.Padding = New DevExpress.XtraPrinting.PaddingInfo(13, 5, 2, 5, 254.0!)
        lblTelsEmpEL.StylePriority.UseBorders = False
        lblTelsEmpEL.StylePriority.UseFont = False
        lblTelsEmpEL.StylePriority.UsePadding = False
        lblTelsEmpEL.StylePriority.UseTextAlignment = False
        lblTelsEmpEL.Text = Telefonos
        lblTelsEmpEL.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        lblTelsEmpEL.Weight = 1.9313776887323719R

        'lblTitleDirEmpEL
        lblTitleDirEmpEL.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        lblTitleDirEmpEL.Dpi = 254.0!
        lblTitleDirEmpEL.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblTitleDirEmpEL.StylePriority.UseBorders = False
        lblTitleDirEmpEL.StylePriority.UseFont = False
        lblTitleDirEmpEL.Text = "DIRECCION"
        lblTitleDirEmpEL.Weight = 1.6675868778811238R

        'lblTitleJefeEL
        lblTitleJefeEL.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        lblTitleJefeEL.CanGrow = False
        lblTitleJefeEL.Dpi = 254.0!
        lblTitleJefeEL.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblTitleJefeEL.Padding = New DevExpress.XtraPrinting.PaddingInfo(13, 5, 2, 5, 254.0!)
        lblTitleJefeEL.StylePriority.UseBorders = False
        lblTitleJefeEL.StylePriority.UseFont = False
        lblTitleJefeEL.StylePriority.UsePadding = False
        lblTitleJefeEL.StylePriority.UseTextAlignment = False
        lblTitleJefeEL.Text = "JEFE INMEDIATO"
        lblTitleJefeEL.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        lblTitleJefeEL.Weight = 1.3324131221188762R

        'lblDirEmpEL
        lblDirEmpEL.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        lblDirEmpEL.CanGrow = False
        lblDirEmpEL.Dpi = 254.0!
        lblDirEmpEL.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblDirEmpEL.Padding = New DevExpress.XtraPrinting.PaddingInfo(13, 5, 2, 5, 254.0!)
        lblDirEmpEL.StylePriority.UseBorders = False
        lblDirEmpEL.StylePriority.UseFont = False
        lblDirEmpEL.StylePriority.UsePadding = False
        lblDirEmpEL.StylePriority.UseTextAlignment = False
        lblDirEmpEL.Text = Direccion
        lblDirEmpEL.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        lblDirEmpEL.Weight = 1.6675868778811238R

        'lblJefeEL
        lblJefeEL.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        lblJefeEL.Dpi = 254.0!
        lblJefeEL.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblJefeEL.Padding = New DevExpress.XtraPrinting.PaddingInfo(13, 5, 2, 5, 254.0!)
        lblJefeEL.StylePriority.UseBorders = False
        lblJefeEL.StylePriority.UseFont = False
        lblJefeEL.StylePriority.UsePadding = False
        lblJefeEL.StylePriority.UseTextAlignment = False
        lblJefeEL.Text = Jefe
        lblJefeEL.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        lblJefeEL.Weight = 1.3324131221188762R

        'LineaExpLaboralAbj
        LineaExpLaboralAbj.BorderWidth = 0.0!
        LineaExpLaboralAbj.Dpi = 254.0!
        LineaExpLaboralAbj.LineWidth = 10
        LineaExpLaboralAbj.LocationFloat = New DevExpress.Utils.PointFloat(39.255!, UbiLineaAbjEnY)
        LineaExpLaboralAbj.SizeF = New System.Drawing.SizeF(1904.745!, 10.00006!)
        LineaExpLaboralAbj.StylePriority.UseBorderWidth = False

        'LineaExpLaboralDer
        LineaExpLaboralDer.BorderWidth = 0.0!
        LineaExpLaboralDer.Dpi = 254.0!
        LineaExpLaboralDer.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical
        LineaExpLaboralDer.LineWidth = 10
        LineaExpLaboralDer.LocationFloat = New DevExpress.Utils.PointFloat(1934.0!, UbiLineaDerEnY)
        LineaExpLaboralDer.SizeF = New System.Drawing.SizeF(10.0!, 331.4228!)
        LineaExpLaboralDer.StylePriority.UseBorderWidth = False

        'lblTitleFecFinEL
        lblTitleFecFinEL.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        lblTitleFecFinEL.Dpi = 254.0!
        lblTitleFecFinEL.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblTitleFecFinEL.StylePriority.UseBorders = False
        lblTitleFecFinEL.StylePriority.UseFont = False
        lblTitleFecFinEL.Text = "FECHA FIN"
        lblTitleFecFinEL.Weight = 0.5343111490812944R
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="Galeria">GalleryItemGroup en la cual se cargara la imagen</param>
    ''' <param name="img">Imagen a cargar...</param>
    ''' <remarks></remarks>
    Public Sub CargarImagenAgaleria(Galeria As GalleryItemGroup, ByRef img As Image)
        Try
            Dim NomImg = "Imagen " & Galeria.Items.Count + 1
            Galeria.Items.Add(New GalleryItem(img, NomImg, ""))
        Catch ex As Exception
            Dim HDevExpre As New HelperDevExpress
            HDevExpre.msgError(ex, ex.Message, "CargarImagenAgaleria")
        End Try
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="Galeria">GalleryItemGroup del cual se hará la eliminacion, OJO es solo del GalleryItemGroup no de la BD, solo hasta que guarde ;)</param>
    ''' <param name="Actualizando">Deteremina si esta actualizando algun registro</param>
    ''' <remarks></remarks>
    Public Sub EliminaImagenDeGaleria(Galeria As GalleryItemGroup, Actualizando As Boolean)
        Try
            If Actualizando Then
                Galeria.Items.Remove(Galeria.GetCheckedItems.Item(0))
            Else
                Dim HDevExpre As New HelperDevExpress
                HDevExpre.MensagedeError("Para quitar la imagen debe estar editando la Información!")
            End If

        Catch ex As Exception
            Dim HDevExpre As New HelperDevExpress
            HDevExpre.msgError(ex, ex.Message, "EliminaImagenDeGaleria")
        End Try
    End Sub
End Class
