Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns
Imports SamitCtlNet
Imports DevExpress.XtraEditors.Controls
Imports System.Transactions
Imports DevExpress.XtraGrid
Imports DevExpress.XtraEditors
Imports DevExpress.XtraVerticalGrid
Imports DevExpress.XtraVerticalGrid.Rows
Imports DevExpress.XtraEditors.Repository
Imports SamitNomina.HelperNomina
Imports SamitNominaLogic

Public Class FrmConsultaLiquidaciones

    Public Datos As New SamitCtlNet.SamitCtlNet
    Dim Nomina As String = ""
    Dim TipoContrato As String = ""
    Dim Descripcion As String = ""
    Dim TipoConsultaImp As TipoDeLiquidacionImprime
    Dim NominaTipoCont As String = ""
    Dim clImprimir As ClaseImprimir
    Dim HDevExpre As New HelperDevExpress
    Dim HNomina As New HelperNomina
    Private Sub AcomodaForm()
        Try
            btnBuscar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Buscar)
            btnSalir.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.SalirCuadroConX)
            menuImprimir.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Imprimir)
            btnDetalles.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Detalle)
            btnAnular.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Anular)
            btnContabilizar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Contabilizar)
            bntEnviarDian.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Subir)
            grbTipoConsul.SelectedIndex = 0
            TipoConsultaImp = TipoDeLiquidacionImprime.Ordinaria
            txtTipoContrato.Visible = False
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, " AcomodaForm Contrato")
        End Try
    End Sub
    Public Sub txtOficina_Leave(sender As Object, e As EventArgs) Handles txtOficina.Leave
        If txtOficina.ValordelControl <> "" And txtOficina.DescripciondelControl <> "No Se Encontraron Registros" And txtOficina.DescripciondelControl <> "" Then
            txtNominas.ValordelControl = ""
            txtNominas.ConsultaSQL = String.Format("SELECT Sec AS Codigo,NomNomina As Descripcion FROM  Nominas Where Oficina=" + txtOficina.ValordelControl)
            txtNominas.RefrescarDatos()
        End If
    End Sub

    Public Function ValidaCampos() As Boolean
        If grbTipoConsul.SelectedIndex = 3 Then
            If txtOficina.ValordelControl = "" Or txtOficina.DescripciondelControl = "No Se Encontraron Registros" Or txtOficina.DescripciondelControl = "" Then
                HDevExpre.MensagedeError("El campo Oficina no puede estar vacío o contener valores invalidos!..")
                txtOficina.Focus()
                Return False
            ElseIf txtTipoContrato.ValordelControl = "" Or txtTipoContrato.DescripciondelControl = "No Se Encontraron Registros" Or txtTipoContrato.DescripciondelControl = "" Then
                HDevExpre.MensagedeError("El campo Tipo Contrato no puede estar vacío o contener valores invalidos!..")
                txtTipoContrato.Focus()
                Return False
            Else : Return True
            End If
        Else
            If txtOficina.ValordelControl = "" Then
                HDevExpre.MensagedeError("El campo Oficina no puede estar vacío o contener valores invalidos!..")
                txtOficina.Focus()
                Return False
            ElseIf txtNominas.ValordelControl = "" Then
                HDevExpre.MensagedeError("El campo Nominas no puede estar vacío o contener valores invalidos!..")
                txtNominas.Focus()
                Return False
            Else : Return True
            End If
        End If
    End Function

    Private Sub AsignaScriptAcontroles()
        Try
            txtTipoContrato.ConsultaSQL = String.Format("SELECT Sec AS Codigo,NomTipo As Descripcion FROM  CAT_TipoContratos")
            Dim Empresa As Integer = Datos.Seguridad.DatosDeLaEmpresa.NumEmpresa
            txtOficina.DatosDefecto = ObjetosNomina.Oficinas
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "AsignaScriptAcontroles")
        End Try
    End Sub

    Private Sub CreaColumnas(Grid As GridView, Nombre As String, Titulo As String, Visible As Boolean, Editar As Boolean, formula As String, colores As System.Drawing.Color, numerico As Boolean, Porcentaje_Width As Single, TamañoPadre As Single, EsMemo As Boolean)
        Dim gc As New GridColumn
        With gc
            .FieldName = Nombre
            .Name = Nombre
            .Caption = Titulo
            If formula <> "" Then
                .UnboundExpression = formula
                .ShowUnboundExpressionMenu = True
            Else
                .ShowUnboundExpressionMenu = False
                .GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom
            End If
            If numerico = True Then
                .UnboundType = DevExpress.Data.UnboundColumnType.Decimal
                .DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                .DisplayFormat.FormatString = "c2"
            End If
            If Porcentaje_Width > 0 Then
                .Width = CInt((Porcentaje_Width * (TamañoPadre - 20)) / 100)
            End If
            .AppearanceCell.Options.UseBackColor = True
            .AppearanceCell.BackColor = colores
            .OptionsColumn.AllowSize = True
            .OptionsColumn.AllowMove = True
            If Editar Then
                .OptionsColumn.AllowEdit = True
                .OptionsColumn.AllowFocus = True
                .AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Else
                .OptionsColumn.AllowEdit = False
                .OptionsColumn.AllowFocus = False
                .AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            End If
            .OptionsFilter.AllowFilter = False
            .Visible = Visible
            .AppearanceHeader.Options.UseTextOptions = True
            .AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            .AppearanceCell.Options.UseTextOptions = True
        End With
        Grid.OptionsCustomization.AllowSort = False
        Grid.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.CellFocus
        Grid.Columns.Add(gc)
    End Sub
    Private Sub Creagrillahorizontal()
        gvLiquidaciones.Columns.Clear()
        Dim coloor As System.Drawing.Color = Color.White
        HDevExpre.CreaColumnasG(gvLiquidaciones, "Sec", "Codigo", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 3, gcLiquidaciones.Width)

        If grbTipoConsul.SelectedIndex = 3 Then
            HDevExpre.CreaColumnasG(gvLiquidaciones, "TipoContrato", "Tipo de Contrato", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 10, gcLiquidaciones.Width)
        Else
            HDevExpre.CreaColumnasG(gvLiquidaciones, "NumNomina", "Num Nomina", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 5, gcLiquidaciones.Width)
            HDevExpre.CreaColumnasG(gvLiquidaciones, "Nomina", "Nombre Nomina", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 10, gcLiquidaciones.Width)
        End If
        If grbTipoConsul.SelectedIndex = 0 Then
            HDevExpre.CreaColumnasG(gvLiquidaciones, "Periodo", "Periodo", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 20, gcLiquidaciones.Width)
            HDevExpre.CreaColumnasG(gvLiquidaciones, "CodPeriodo", "Codigo Periodo", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 10, gcLiquidaciones.Width)
        ElseIf grbTipoConsul.SelectedIndex = 1 Then
            HDevExpre.CreaColumnasG(gvLiquidaciones, "Semestre", "Semestre", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 20, gcLiquidaciones.Width)
        End If
        HDevExpre.CreaColumnasG(gvLiquidaciones, "Fecha", "Fecha", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 10, gcLiquidaciones.Width)
        HDevExpre.CreaColumnasG(gvLiquidaciones, "Estado", "Estado", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 10, gcLiquidaciones.Width)
        HDevExpre.CreaColumnasG(gvLiquidaciones, "Contabilizada", "Contabilizada", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 10, gcLiquidaciones.Width)
        HDevExpre.CreaColumnasG(gvLiquidaciones, "DocContable", "Doc Contable", False, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 7, gcLiquidaciones.Width)
        HDevExpre.CreaColumnasG(gvLiquidaciones, "DocumentoContable", "Doc Contable", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 7, gcLiquidaciones.Width)
        gvLiquidaciones.OptionsView.ShowFooter = True
        gvLiquidaciones.Appearance.HeaderPanel.Font = New Font("Trebuchet MS", 11.0!, FontStyle.Bold)
        gvLiquidaciones.Columns(0).Summary.Add(DevExpress.Data.SummaryItemType.Count, "", "{0}  Registros")
    End Sub
    Private Sub LlenaGrilla()
        Try
            Dim sql As String = ""
            If grbTipoConsul.SelectedIndex = 0 Then
                sql = "Select NL.Sec as Sec,P.PeriodoMes,N.FormaLiquida,P.Descripcion As Periodo,N.NomNomina As Nomina,convert(date ,NL.FechaCrea) As Fecha,P.CodPeriodo,P.Nomina as NumNomina,case NL.Estado WHEN 'A' then 'Anulada' when 'P' then 'Pendiente' when 'L' then 'Liquidada' end As Estado,isnull(Contabilizada,0) as Contabilizada,DocContable " &
" FROM  NominaLiquidada NL INNER JOIN PeriodosLiquidacion P ON NL.Periodo = P.Sec " +
"INNER JOIN Nominas N ON P.Nomina = N.Sec Where NL.OfiNomina='" + txtOficina.ValordelControl + "' And P.Nomina='" + txtNominas.ValordelControl + "' And P.Año='" + txtAño.ValordelControl + "'"
            ElseIf grbTipoConsul.SelectedIndex = 1 Then
                sql = "Select NL.Sec as Sec,'Semestre entre '+Cast(P.FechaInicio as varchar)+' y '+Cast(P.FechaFin as varchar) As Semestre,P.Nomina As NumNomina,N.NomNomina As Nomina,convert(date ,NL.FechaCrea) As Fecha,case NL.Estado WHEN 'A' then 'Anulada' when 'P' then 'Pendiente' when 'L' then 'Liquidada' end As Estado,isnull(Contabilizada,0) as Contabilizada,DocContable " &
" From NominaLiquidaSemestres NL INNER JOIN SemestresLiquidacion P ON NL.Semestre = P.Sec " +
"INNER JOIN Nominas N ON P.Nomina = N.Sec Where NL.OfiNomina='" + txtOficina.ValordelControl + "' And P.Nomina='" + txtNominas.ValordelControl + "' And P.Año='" + txtAño.ValordelControl + "'"
            ElseIf grbTipoConsul.SelectedIndex = 2 Then
                sql = "Select NL.Sec as Sec,N.NomNomina As Nomina,N.Sec As NumNomina,convert(date ,NL.FechaCrea) As Fecha,case NL.Estado WHEN 'A' then 'Anulada' when 'P' then 'Pendiente' when 'L' then 'Liquidada' end As Estado,isnull(Contabilizada,0) as Contabilizada,DocContable " &
" From NominaLiquidaExtraordinaria NL INNER JOIN Nominas N ON NL.Nomina = N.Sec Where NL.OfiNomina ='" + txtOficina.ValordelControl + "' And NL.Nomina='" + txtNominas.ValordelControl + "' And DATEPART(year, NL.FechaCrea)='" + txtAño.ValordelControl + "'"
            ElseIf grbTipoConsul.SelectedIndex = 3 Then
                sql = "Select NL.Sec as Sec,N.NomTipo As TipoContrato,convert(date ,NL.FechaCrea) As Fecha,case NL.Estado WHEN 'A' then 'Anulada' when 'P' then 'Pendiente' when 'L' then 'Liquidada' end As Estado,isnull(Contabilizada,0) as Contabilizada,DocContable " &
" From ContratosLiquidados NL INNER JOIN CAT_TipoContratos N ON NL.TipoContrato = N.CodTipo " +
"Where NL.OfiNomina ='" + txtOficina.ValordelControl + "' And NL.TipoContrato='" + txtTipoContrato.ValordelControl + "' And DATEPART(year, NL.FechaCrea)='" + txtAño.ValordelControl + "'"
            End If
            Dim dt As DataTable = SMT_AbrirTabla(ObjetoApiNomina, sql)
            gcLiquidaciones.DataSource = dt
            If dt.Rows.Count = 0 Then
                HDevExpre.MensagedeError("No se encontraron registros..!")
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "LlenaGrilla")
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If ValidaCampos() Then
            Creagrillahorizontal()
            LlenaGrilla()
            Nomina = txtNominas.ValordelControl
            TipoContrato = txtTipoContrato.ValordelControl
        End If
    End Sub

    Private Sub grbTipoConsul_SelectedIndexChanged(sender As Object, e As EventArgs) Handles grbTipoConsul.SelectedIndexChanged
        If grbTipoConsul.SelectedIndex = 3 Then
            txtTipoContrato.Visible = True
            txtNominas.Enabled = False
        Else
            txtNominas.Enabled = True
            txtTipoContrato.Visible = False
        End If
        Dim datos As DataTable = CType(gcLiquidaciones.DataSource, DataTable)

        If grbTipoConsul.SelectedIndex = 0 Then
            TipoConsultaImp = TipoDeLiquidacionImprime.Ordinaria
        ElseIf grbTipoConsul.SelectedIndex = 1 Then
            TipoConsultaImp = TipoDeLiquidacionImprime.Semestre
        ElseIf grbTipoConsul.SelectedIndex = 2 Then
            TipoConsultaImp = TipoDeLiquidacionImprime.Extraordinaria
        ElseIf grbTipoConsul.SelectedIndex = 3 Then
            TipoConsultaImp = TipoDeLiquidacionImprime.LiquidaContratos
            NominaTipoCont = TipoContrato
        End If
        If gvLiquidaciones.RowCount > 0 Then
            datos.Rows.Clear()
        End If
        Creagrillahorizontal()

    End Sub

    Private Sub FrmConsultaLiquidaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'txtAño.ValordelControl = Year(Traer_FechaDelServidor()).ToString
        txtAño.ValordelControl = Datos.Smt_FechaDeTrabajo.Year.ToString
        txtOficina.Select()
        AcomodaForm()
        AsignaScriptAcontroles()
    End Sub

    Private Sub grbTipoConsul_Enter(sender As Object, e As EventArgs) Handles grbTipoConsul.Enter
        HDevExpre.EntraControlRadioGroup(grbTipoConsul, , grbTipoConsul.Font.Size, )
        FrmPrincipal.MensajeDeAyuda.Refresh()
        FrmPrincipal.MensajeDeAyuda.Caption = "Estado de la Base. (ENTER)=Avanzar;(ESC,ARB)=Atras"
    End Sub

    Private Sub grbTipoConsul_Leave(sender As Object, e As EventArgs) Handles grbTipoConsul.Leave
        HDevExpre.SaleControlRadioGroup(grbTipoConsul, , grbTipoConsul.Font.Size, )
        FrmPrincipal.MensajeDeAyuda.Caption = ""
        FrmPrincipal.MensajeDeAyuda.Refresh()
    End Sub

    Private Sub btnDetalles_Click(sender As Object, e As EventArgs) Handles btnDetalles.Click
        Dim titulo As String = ""
        If gvLiquidaciones.RowCount > 0 Then
            NominaTipoCont = txtNominas.ValordelControl
            If grbTipoConsul.SelectedIndex = 0 Then
                TipoConsultaImp = TipoDeLiquidacionImprime.Ordinaria
                Descripcion = gvLiquidaciones.GetFocusedRowCellValue("Sec").ToString
                titulo = "Liquidacion " + gvLiquidaciones.GetFocusedRowCellValue("Periodo").ToString
            ElseIf grbTipoConsul.SelectedIndex = 1 Then
                TipoConsultaImp = TipoDeLiquidacionImprime.Semestre
                Descripcion = gvLiquidaciones.GetFocusedRowCellValue("Sec").ToString
                titulo = "Liquidacion " + gvLiquidaciones.GetFocusedRowCellValue("Semestre").ToString
            ElseIf grbTipoConsul.SelectedIndex = 2 Then
                TipoConsultaImp = TipoDeLiquidacionImprime.Extraordinaria
                Descripcion = ""
                titulo = "Liquidacion extraordinaria " + gvLiquidaciones.GetFocusedRowCellValue("Nomina").ToString
            ElseIf grbTipoConsul.SelectedIndex = 3 Then
                TipoConsultaImp = TipoDeLiquidacionImprime.LiquidaContratos
                Descripcion = ""
                titulo = "Liquidacion de contratos"
                NominaTipoCont = TipoContrato
            End If
            Dim FechaL As String = gvLiquidaciones.GetFocusedRowCellValue("Fecha").ToString
            FechaL = FechaL.Substring(0, 10)
            If HDevExpre.EstaCargadoFormulario("FrmImpNominas") Then Exit Sub
            Dim Frm As New FrmImpNominas(CInt(gvLiquidaciones.GetFocusedRowCellValue("Sec")), TipoConsultaImp, CInt(NominaTipoCont), Descripcion, titulo, FechaL)
            If grbTipoConsul.SelectedIndex = 0 Then
                Frm.CodNomina = gvLiquidaciones.GetFocusedRowCellValue("NumNomina").ToString
                Frm.SimpleButton1.Enabled = True
            Else
                Frm.SimpleButton1.Enabled = False
            End If

            Frm.MdiParent = FrmPrincipal
            Frm.Show()
        End If
    End Sub


    Private Sub btnImpBasica_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnImpBasica.ItemClick
        Try
            Dim titulo As String = ""
            If gvLiquidaciones.RowCount = 0 Then Exit Sub
            Dim sql As String = "SELECT EM.Identificacion, CT.IdContrato,RTRIM(LTRIM(RTRIM(LTRIM(EM.PNombre)) + ' ' +  " +
                " RTRIM(LTRIM(EM.SNombre)) + ' ' +  RTRIM(LTRIM(EM.PApellido)) + ' ' +  RTRIM(LTRIM(EM.SApellido)))) As Nombres, " +
                " ISNULL(EM.NumCuenta,'Sin # Cuenta definido')+' | '+ISNULL(BC.Nombre,' Sin Banco Definido') As Banco," +
                " NCT.TotalIngresos,NCT.TotalDeducciones,NCT.TotalProvisiones,NCT.TotalDescuentosNomina, (NCT.TotalIngresos - NCT.TotalDeducciones - NCT.TotalDescuentosNomina) AS NetoApagar" +
                " FROM NominaLiquidadaContratos NCT" +
                " INNER JOIN NominaLiquidada NL ON NCT.NominaLiquidada = NL.Sec" +
                " INNER JOIN Contratos CT ON NCT.Contrato = CT.CodContrato" +
                " INNER JOIN Empleados EM ON CT.Empleado = EM.IdEmpleado " +
                " LEFT JOIN CAT_Bancos BC ON EM.codBanco = BC.Sec " +
                " WHERE NL.Sec =" & CInt(gvLiquidaciones.GetFocusedRowCellValue("Sec")) ' + gvRes.GetFocusedRowCellValue("Codigo").ToString
            Try
                If grbTipoConsul.SelectedIndex = 0 Then
                    titulo = "Liquidacion " + gvLiquidaciones.GetFocusedRowCellValue("Periodo").ToString
                ElseIf grbTipoConsul.SelectedIndex = 1 Then
                    titulo = "Liquidacion " + gvLiquidaciones.GetFocusedRowCellValue("Semestre").ToString
                ElseIf grbTipoConsul.SelectedIndex = 2 Then

                ElseIf grbTipoConsul.SelectedIndex = 3 Then

                End If
            Catch

            End Try
            If TipoConsultaImp = TipoDeLiquidacionImprime.Extraordinaria Then
                sql = "SELECT EM.Identificacion, CT.IdContrato,RTRIM(LTRIM(RTRIM(LTRIM(EM.PNombre)) + ' ' +  " +
               " RTRIM(LTRIM(EM.SNombre)) + ' ' +  RTRIM(LTRIM(EM.PApellido)) + ' ' +  RTRIM(LTRIM(EM.SApellido)))) As Nombres, " +
               " ISNULL(EM.NumCuenta,'Sin # Cuenta definido')+' | '+ISNULL(BC.Nombre,' Sin Banco Definido') As Banco," +
               " NCT.TotalIngresos,NCT.TotalDeducciones,NCT.Total as TotalProvisiones,NCT.TotalDescuentosNomina, (NCT.TotalIngresos - NCT.TotalDeducciones - NCT.TotalDescuentosNomina) AS NetoApagar" +
               " FROM NominaLiquidaExtraordinariaContratos NCT" +
               " INNER JOIN NominaLiquidaExtraordinaria NL ON NCT.NominaLiquidaExtraordinaria = NL.Sec" +
               " INNER JOIN Contratos CT ON NCT.Contrato = CT.CodContrato" +
               " INNER JOIN Empleados EM ON CT.Empleado = EM.IdEmpleado " +
               " LEFT JOIN CAT_Bancos BC ON EM.codBanco = BC.Sec " +
               " WHERE NL.Sec =" & CInt(gvLiquidaciones.GetFocusedRowCellValue("Sec"))
                Dim FechaL As String = gvLiquidaciones.GetFocusedRowCellValue("Fecha").ToString
                FechaL = FechaL.Substring(0, 10)
                titulo = "Liquidacion extraordinaria " + gvLiquidaciones.GetFocusedRowCellValue("Nomina").ToString + " " + FechaL
            ElseIf TipoConsultaImp = TipoDeLiquidacionImprime.Semestre Then
                sql = "SELECT EM.Identificacion, CT.IdContrato,RTRIM(LTRIM(RTRIM(LTRIM(EM.PNombre)) + ' ' +  " +
                " RTRIM(LTRIM(EM.SNombre)) + ' ' +  RTRIM(LTRIM(EM.PApellido)) + ' ' +  RTRIM(LTRIM(EM.SApellido)))) As Nombres, " +
                " ISNULL(EM.NumCuenta,'Sin # Cuenta definido')+' | '+ISNULL(BC.Nombre,' Sin Banco Definido') As Banco," +
                " NCT.TotalIngresos,NCT.TotalDeducciones,NCT.Total as TotalProvisiones,NCT.TotalDescuentosNomina, (NCT.TotalIngresos - NCT.TotalDeducciones - NCT.TotalDescuentosNomina) AS NetoApagar" +
                " FROM NominaLiquidaSemestresContratos NCT" +
                " INNER JOIN NominaLiquidaSemestres NL ON NCT.NominaLiquidaSemestres = NL.Sec" +
                " INNER JOIN Contratos CT ON NCT.Contrato = CT.CodContrato" +
                " INNER JOIN Empleados EM ON CT.Empleado = EM.IdEmpleado " +
                " LEFT JOIN CAT_Bancos BC ON EM.codBanco = BC.Sec " +
                " WHERE NL.Sec =" & CInt(gvLiquidaciones.GetFocusedRowCellValue("Sec"))
                titulo = "Liquidacion " + gvLiquidaciones.GetFocusedRowCellValue("Semestre").ToString
            ElseIf TipoConsultaImp = TipoDeLiquidacionImprime.LiquidaContratos Then
                sql = "SELECT EM.Identificacion, CT.IdContrato,RTRIM(LTRIM(RTRIM(LTRIM(EM.PNombre)) + ' ' +  " +
               " RTRIM(LTRIM(EM.SNombre)) + ' ' +  RTRIM(LTRIM(EM.PApellido)) + ' ' +  RTRIM(LTRIM(EM.SApellido)))) As Nombres, " +
               " ISNULL(EM.NumCuenta,'Sin # Cuenta definido')+' | '+ISNULL(BC.Nombre,' Sin Banco Definido') As Banco," +
               " NCT.TotalIngresos,NCT.TotalDeducciones,NCT.Total as TotalProvisiones, (NCT.TotalIngresos - NCT.TotalDeducciones) AS NetoApagar" +
               " FROM ContratosLiquidados_Contratos NCT" +
               " INNER JOIN ContratosLiquidados NL ON NCT.NominaLiquida = NL.Sec" +
               " INNER JOIN Contratos CT ON NCT.Contrato = CT.CodContrato" +
               " INNER JOIN Empleados EM ON CT.Empleado = EM.IdEmpleado " +
               " LEFT JOIN CAT_Bancos BC ON EM.codBanco = BC.Sec " +
               " WHERE NL.Sec =" & CInt(gvLiquidaciones.GetFocusedRowCellValue("Sec"))
                Dim FechaL As String = gvLiquidaciones.GetFocusedRowCellValue("Fecha").ToString
                FechaL = FechaL.Substring(0, 10)
                titulo = "Liquidacion de contratos" + gvLiquidaciones.GetFocusedRowCellValue("Nomina").ToString + " " + FechaL
            End If


            clImprimir.ImprimeXperiodo(sql, CInt(gvLiquidaciones.GetFocusedRowCellValue("Sec")), "", CInt(Nomina), Descripcion, False, titulo)
            'clImprimir.ImprimeXperiodo(sql, CInt(gvRes.GetFocusedRowCellValue("Codigo")), gvRes.GetFocusedRowCellValue("Descripcion").ToString,
            '                           SecNomina, DesNomina, False)
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "btnImpBasica_ItemClick")
        End Try
    End Sub

    Private Sub btnImpDetallado_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnImpDetallado.ItemClick
        Try
            Dim Descripcion As String = ""
            Dim NominaTipoCont As String = Nomina
            Dim titulo As String = ""
            If gvLiquidaciones.RowCount = 0 Then Exit Sub
            'SQL PARA NOMINAS EN FIRME
            Dim sql As String = String.Format("SELECT EM.Identificacion,CAST(CAST(EM.Identificacion AS VARCHAR) +' | '+ RTRIM(LTRIM(RTRIM(LTRIM(EM.PNombre)) + ' ' +  " +
            " RTRIM(LTRIM(EM.SNombre)) + ' ' +  RTRIM(LTRIM(EM.PApellido)) + ' ' + RTRIM(LTRIM(EM.SApellido)))) AS VARCHAR) AS Nombres,   " +
            " CP.Sec AS SecConcep,CP.NomConcepto, NLC.Valor, CP.Tipo, TP.NomTipo,CT.IdContrato  " +
            " FROM NominaLiquidadaConceptos NLC  " +
            " INNER JOIN NominaLiquidadaContratos NCT ON NLC.LiquidadaContrato = NCT.Sec  " +
            " INNER JOIN NominaLiquidada NL ON NCT.NominaLiquidada = NL.Sec  " +
            " INNER JOIN Contratos CT ON NCT.Contrato = CT.CodContrato  " +
            " INNER JOIN ConceptosNomina CP ON NLC.SecConcepto = CP.Sec  " +
            " INNER JOIN TiposConceptosNomina TP ON CP.Tipo = TP.Sec  " +
            " INNER JOIN Empleados EM ON CT.Empleado = EM.IdEmpleado  " +
            " WHERE NL.Sec = {0} AND NLC.Valor > 0 " +
            " UNION" +
            " SELECT EM.Identificacion,CAST(CAST(EM.Identificacion AS VARCHAR) +' | '+ RTRIM(LTRIM(RTRIM(LTRIM(EM.PNombre)) + ' ' +  " +
            " RTRIM(LTRIM(EM.SNombre)) + ' ' +  RTRIM(LTRIM(EM.PApellido)) + ' ' + RTRIM(LTRIM(EM.SApellido)))) AS VARCHAR) AS Nombres,   " +
            " CP.Sec AS SecConcep,CP.NomConcepto, NLC.Valor, '0' as Tipo, 'Descuento' as NomTipo,CT.IdContrato  " +
            " FROM NominaLiquidadaConceptos NLC " +
            " INNER JOIN NominaLiquidadaContratos NCT ON NLC.LiquidadaContrato = NCT.Sec " +
            " INNER JOIN NominaLiquidada NL ON NCT.NominaLiquidada = NL.Sec " +
            " INNER JOIN Contratos CT ON NCT.Contrato = CT.CodContrato " +
            " INNER JOIN PeriodosLiquidacion PL ON NL.Periodo = PL.Sec" +
            " INNER JOIN Empleados EM ON CT.Empleado = EM.IdEmpleado  " +
            " INNER JOIN ConceptosPersonales CP ON NLC.SecConceptoP = CP.Sec" +
            " WHERE NL.Sec = {0} AND NLC.Valor > 0", CInt(gvLiquidaciones.GetFocusedRowCellValue("Sec"))) 'gvRes.GetFocusedRowCellValue("Codigo"))
            Try
                If grbTipoConsul.SelectedIndex = 0 Then
                    titulo = "Liquidacion " + gvLiquidaciones.GetFocusedRowCellValue("Periodo").ToString
                ElseIf grbTipoConsul.SelectedIndex = 1 Then
                    titulo = "Liquidacion " + gvLiquidaciones.GetFocusedRowCellValue("Semestre").ToString
                ElseIf grbTipoConsul.SelectedIndex = 2 Then

                ElseIf grbTipoConsul.SelectedIndex = 3 Then

                End If

            Catch

            End Try
            If TipoConsultaImp = TipoDeLiquidacionImprime.Extraordinaria Then
                sql = String.Format("SELECT EM.Identificacion,CAST(CAST(EM.Identificacion AS VARCHAR) +' | '+ RTRIM(LTRIM(RTRIM(LTRIM(EM.PNombre)) + ' ' +  " +
                " RTRIM(LTRIM(EM.SNombre)) + ' ' +  RTRIM(LTRIM(EM.PApellido)) + ' ' + RTRIM(LTRIM(EM.SApellido)))) AS VARCHAR) AS Nombres,   " +
                " CP.Sec AS SecConcep,CP.NomConcepto, NLC.Valor, CP.Tipo, CAST(CASE WHEN TP.NomTipo = 'Provisiones' THEN 'Ingresos' ELSE TP.NomTipo END AS VARCHAR) AS NomTipo,CT.IdContrato  " +
                " FROM NominaLiquidaExtraordinariaConceptos NLC  " +
                " INNER JOIN NominaLiquidaExtraordinariaContratos NCT ON NLC.LiquidaContrato = NCT.Sec  " +
                " INNER JOIN NominaLiquidaExtraordinaria NL ON NCT.NominaLiquidaExtraordinaria = NL.Sec  " +
                " INNER JOIN Contratos CT ON NCT.Contrato = CT.CodContrato  " +
                " INNER JOIN ConceptosNomina CP ON NLC.SecConcepto = CP.Sec  " +
                " INNER JOIN TiposConceptosNomina TP ON CP.Tipo = TP.Sec  " +
                " INNER JOIN Empleados EM ON CT.Empleado = EM.IdEmpleado  " +
                " WHERE NL.Sec = {0} AND NLC.Valor > 0" +
                            " UNION" +
            " SELECT EM.Identificacion,CAST(CAST(EM.Identificacion AS VARCHAR) +' | '+ RTRIM(LTRIM(RTRIM(LTRIM(EM.PNombre)) + ' ' +  " +
            " RTRIM(LTRIM(EM.SNombre)) + ' ' +  RTRIM(LTRIM(EM.PApellido)) + ' ' + RTRIM(LTRIM(EM.SApellido)))) AS VARCHAR) AS Nombres,   " +
            " CP.Sec AS SecConcep,CP.NomConcepto, NLC.Valor, '0' as Tipo, 'Descuento' as NomTipo,CT.IdContrato  " +
                " FROM NominaLiquidaExtraordinariaConceptos NLC  " +
                " INNER JOIN NominaLiquidaExtraordinariaContratos NCT ON NLC.LiquidaContrato = NCT.Sec  " +
                " INNER JOIN NominaLiquidaExtraordinaria NL ON NCT.NominaLiquidaExtraordinaria = NL.Sec  " +
            " INNER JOIN Contratos CT ON NCT.Contrato = CT.CodContrato " +
            " INNER JOIN Empleados EM ON CT.Empleado = EM.IdEmpleado  " +
            " INNER JOIN ConceptosPersonales CP ON NLC.SecConceptoP = CP.Sec" +
            " WHERE NL.Sec = {0} AND NLC.Valor > 0", CInt(gvLiquidaciones.GetFocusedRowCellValue("Sec")))
                Dim FechaL As String = gvLiquidaciones.GetFocusedRowCellValue("Fecha").ToString
                FechaL = FechaL.Substring(0, 10)
                titulo = "Liquidacion extraordinaria " + gvLiquidaciones.GetFocusedRowCellValue("Nomina").ToString + " " + FechaL
            ElseIf TipoConsultaImp = TipoDeLiquidacionImprime.Semestre Then
                sql = String.Format("SELECT EM.Identificacion,CAST(CAST(EM.Identificacion AS VARCHAR) +' | '+ RTRIM(LTRIM(RTRIM(LTRIM(EM.PNombre)) + ' ' +  " +
              " RTRIM(LTRIM(EM.SNombre)) + ' ' +  RTRIM(LTRIM(EM.PApellido)) + ' ' + RTRIM(LTRIM(EM.SApellido)))) AS VARCHAR) AS Nombres,   " +
              " CP.Sec AS SecConcep,CP.NomConcepto, NLC.Valor, CP.Tipo, CAST(CASE WHEN TP.NomTipo = 'Provisiones' THEN 'Ingresos' ELSE TP.NomTipo END AS VARCHAR) AS NomTipo,CT.IdContrato  " +
              " FROM NominaLiquidaSemestresConceptos NLC  " +
              " INNER JOIN NominaLiquidaSemestresContratos NCT ON NLC.LiquidaContrato = NCT.Sec  " +
              " INNER JOIN NominaLiquidaSemestres NL ON NCT.NominaLiquidaSemestres = NL.Sec  " +
              " INNER JOIN Contratos CT ON NCT.Contrato = CT.CodContrato  " +
              " INNER JOIN ConceptosNomina CP ON NLC.SecConcepto = CP.Sec  " +
              " INNER JOIN TiposConceptosNomina TP ON CP.Tipo = TP.Sec  " +
              " INNER JOIN Empleados EM ON CT.Empleado = EM.IdEmpleado  " +
              " WHERE NL.Sec = {0} AND NLC.Valor > 0 " +
                " UNION" +
            " SELECT EM.Identificacion,CAST(CAST(EM.Identificacion AS VARCHAR) +' | '+ RTRIM(LTRIM(RTRIM(LTRIM(EM.PNombre)) + ' ' +  " +
            " RTRIM(LTRIM(EM.SNombre)) + ' ' +  RTRIM(LTRIM(EM.PApellido)) + ' ' + RTRIM(LTRIM(EM.SApellido)))) AS VARCHAR) AS Nombres,   " +
            " CP.Sec AS SecConcep,CP.NomConcepto, NLC.Valor, '0' as Tipo, 'Descuento' as NomTipo,CT.IdContrato  " +
              " FROM NominaLiquidaSemestresConceptos NLC  " +
              " INNER JOIN NominaLiquidaSemestresContratos NCT ON NLC.LiquidaContrato = NCT.Sec  " +
              " INNER JOIN NominaLiquidaSemestres NL ON NCT.NominaLiquidaSemestres = NL.Sec  " +
            " INNER JOIN Contratos CT ON NCT.Contrato = CT.CodContrato " +
            " INNER JOIN Empleados EM ON CT.Empleado = EM.IdEmpleado  " +
            " INNER JOIN ConceptosPersonales CP ON NLC.SecConceptoP = CP.Sec" +
            " WHERE NL.Sec = {0} AND NLC.Valor > 0", CInt(gvLiquidaciones.GetFocusedRowCellValue("Sec")))
                titulo = "Liquidacion " + gvLiquidaciones.GetFocusedRowCellValue("Semestre").ToString
            ElseIf TipoConsultaImp = TipoDeLiquidacionImprime.LiquidaContratos Then
                sql = String.Format("SELECT EM.Identificacion,CAST(CAST(EM.Identificacion AS VARCHAR) +' | '+ RTRIM(LTRIM(RTRIM(LTRIM(EM.PNombre)) + ' ' +  " +
                " RTRIM(LTRIM(EM.SNombre)) + ' ' +  RTRIM(LTRIM(EM.PApellido)) + ' ' + RTRIM(LTRIM(EM.SApellido)))) AS VARCHAR) AS Nombres,   " +
                " CP.Sec AS SecConcep,CP.NomConcepto, NLC.Valor, CP.Tipo, CAST(CASE WHEN TP.NomTipo = 'Provisiones' THEN 'Ingresos' ELSE TP.NomTipo END AS VARCHAR) AS NomTipo,CT.IdContrato  " +
                " FROM ContratosLiquidados_Conceptos NLC  " +
                " INNER JOIN ContratosLiquidados_Contratos NCT ON NLC.LiquidaContrato = NCT.Sec  " +
                " INNER JOIN ContratosLiquidados NL ON NCT.NominaLiquida = NL.Sec  " +
                " INNER JOIN Contratos CT ON NCT.Contrato = CT.CodContrato  " +
                " INNER JOIN ConceptosNomina CP ON NLC.SecConcepto = CP.Sec  " +
                " INNER JOIN TiposConceptosNomina TP ON CP.Tipo = TP.Sec  " +
                " INNER JOIN Empleados EM ON CT.Empleado = EM.IdEmpleado  " +
                " WHERE NL.Sec = {0} AND NLC.Valor > 0 ORDER BY Identificacion", CInt(gvLiquidaciones.GetFocusedRowCellValue("Sec")))
                Dim FechaL As String = gvLiquidaciones.GetFocusedRowCellValue("Fecha").ToString
                FechaL = FechaL.Substring(0, 10)
                titulo = "Liquidacion de contratos" + gvLiquidaciones.GetFocusedRowCellValue("Nomina").ToString + " " + FechaL
            End If
            clImprimir.ImprimeXperiodoDetalle(sql, CInt(gvLiquidaciones.GetFocusedRowCellValue("Sec")), "", CInt(NominaTipoCont), Descripcion, False, titulo)
            'clImprimir.ImprimeXperiodoDetalle(sql, CInt(gvRes.GetFocusedRowCellValue("Codigo")),
            '                                  gvRes.GetFocusedRowCellValue("Descripcion").ToString,
            '                                  SecNomina, DesNomina, False)
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "btnImpDetallado_ItemClick")
        End Try
    End Sub


    Private Sub btnImpTotalesXperiodo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnImpTotalesXperiodo.ItemClick
        Try
            Dim Descripcion As String = ""
            Dim NominaTipoCont As String = Nomina
            Dim titulo As String = ""
            If gvLiquidaciones.RowCount = 0 Then Exit Sub
            Dim sql As String = String.Format("SELECT CP.Sec AS SecConcep,CP.NomConcepto, " +
                 " SUM(NLC.Base) AS Base,NLC.NomBase,CP.Tipo,Case TP.NomTipo when 'Ingresos' then '1-Ingresos' When 'Deducciones' then '2-Deducciones' when 'Provisiones' then '4-Provisiones' end As NomTipo,SUM(NLC.Valor) AS Valor " +
                 " FROM NominaLiquidadaConceptos NLC " +
                 " INNER JOIN NominaLiquidadaContratos NCT ON NLC.LiquidadaContrato = NCT.Sec " +
                 " INNER JOIN NominaLiquidada NL ON NCT.NominaLiquidada = NL.Sec " +
                 " INNER JOIN ConceptosNomina CP ON NLC.SecConcepto = CP.Sec " +
                 " INNER JOIN TiposConceptosNomina TP ON CP.Tipo = TP.Sec WHERE NL.Sec = {0} " +
                 " GROUP BY CP.Sec,CP.NomConcepto,CP.Tipo,TP.NomTipo,NLC.NomBase HAVING SUM(NLC.Valor)>0" +
                 " Union" +
                 " SELECT CP.Sec AS SecConcep,CP.NomConcepto, " +
                 " SUM(NLC.Base) AS Base,NLC.NomBase,'0' As Tipo,'3-Descuentos' As NomTipo,SUM(NLC.Valor) AS Valor " +
                 " FROM NominaLiquidadaConceptos NLC " +
                 " INNER JOIN NominaLiquidadaContratos NCT ON NLC.LiquidadaContrato = NCT.Sec " +
                 " INNER JOIN NominaLiquidada NL ON NCT.NominaLiquidada = NL.Sec " +
                 " INNER JOIN ConceptosPersonales CP ON NLC.SecConceptoP = CP.Sec " +
                 " WHERE NL.Sec = {0} " +
                 " GROUP BY CP.Sec,CP.NomConcepto,NLC.NomBase HAVING SUM(NLC.Valor)>0", CInt(gvLiquidaciones.GetFocusedRowCellValue("Sec"))) ' gvRes.GetFocusedRowCellValue("Codigo"))
            Try
                If grbTipoConsul.SelectedIndex = 0 Then
                    titulo = "Liquidacion " + gvLiquidaciones.GetFocusedRowCellValue("Periodo").ToString
                ElseIf grbTipoConsul.SelectedIndex = 1 Then
                    titulo = "Liquidacion " + gvLiquidaciones.GetFocusedRowCellValue("Semestre").ToString
                ElseIf grbTipoConsul.SelectedIndex = 2 Then

                ElseIf grbTipoConsul.SelectedIndex = 3 Then

                End If
            Catch

            End Try

            If TipoConsultaImp = TipoDeLiquidacionImprime.Extraordinaria Then
                sql = String.Format("SELECT CP.Sec AS SecConcep,CP.NomConcepto, " +
                " SUM(NLC.Base) AS Base,NLC.NomBase,CP.Tipo,Case TP.NomTipo when 'Ingresos' then '1-Ingresos' When 'Deducciones' then '2-Deducciones' when 'Provisiones' then '1-Ingresos' end As NomTipo,SUM(NLC.Valor) AS Valor " +
                " FROM NominaLiquidaExtraordinariaConceptos NLC " +
                " INNER JOIN NominaLiquidaExtraordinariaContratos NCT ON NLC.LiquidaContrato = NCT.Sec " +
                " INNER JOIN NominaLiquidaExtraordinaria NL ON NCT.NominaLiquidaExtraordinaria = NL.Sec " +
                " INNER JOIN ConceptosNomina CP ON NLC.SecConcepto = CP.Sec " +
                " INNER JOIN TiposConceptosNomina TP ON CP.Tipo = TP.Sec WHERE NL.Sec = {0} " +
                " GROUP BY CP.Sec,CP.NomConcepto,CP.Tipo,TP.NomTipo,NLC.NomBase HAVING SUM(NLC.Valor)>0" +
                 " Union" +
                 " SELECT CP.Sec AS SecConcep,CP.NomConcepto, " +
                 " SUM(NLC.Base) AS Base,NLC.NomBase,'0' As Tipo,'3-Descuentos' As NomTipo,SUM(NLC.Valor) AS Valor " +
                " FROM NominaLiquidaExtraordinariaConceptos NLC " +
                " INNER JOIN NominaLiquidaExtraordinariaContratos NCT ON NLC.LiquidaContrato = NCT.Sec " +
                " INNER JOIN NominaLiquidaExtraordinaria NL ON NCT.NominaLiquidaExtraordinaria = NL.Sec " +
                 " INNER JOIN ConceptosPersonales CP ON NLC.SecConceptoP = CP.Sec " +
                 " WHERE NL.Sec = {0} " +
                 " GROUP BY CP.Sec,CP.NomConcepto,NLC.NomBase HAVING SUM(NLC.Valor)>0", CInt(gvLiquidaciones.GetFocusedRowCellValue("Sec")))
                Dim FechaL As String = gvLiquidaciones.GetFocusedRowCellValue("Fecha").ToString
                FechaL = FechaL.Substring(0, 10)
                titulo = "Liquidacion extraordinaria " + gvLiquidaciones.GetFocusedRowCellValue("Nomina").ToString + " " + FechaL
            ElseIf TipoConsultaImp = TipoDeLiquidacionImprime.Semestre Then
                sql = String.Format("SELECT CP.Sec AS SecConcep,CP.NomConcepto, " +
" SUM(NLC.Base) AS Base,NLC.NomBase,CP.Tipo,Case TP.NomTipo when 'Ingresos' then '1-Ingresos' When 'Deducciones' then '2-Deducciones' when 'Provisiones' then '1-Ingresos' end As NomTipo,SUM(NLC.Valor) AS Valor " +
                " FROM NominaLiquidaSemestresConceptos NLC " +
                " INNER JOIN NominaLiquidaSemestresContratos NCT ON NLC.LiquidaContrato = NCT.Sec " +
                " INNER JOIN NominaLiquidaSemestres NL ON NCT.NominaLiquidaSemestres = NL.Sec " +
                " INNER JOIN ConceptosNomina CP ON NLC.SecConcepto = CP.Sec " +
                " INNER JOIN TiposConceptosNomina TP ON CP.Tipo = TP.Sec WHERE NL.Sec = {0} " +
                " GROUP BY CP.Sec,CP.NomConcepto,CP.Tipo,TP.NomTipo,NLC.NomBase HAVING SUM(NLC.Valor)>0" +
                 " Union" +
                 " SELECT CP.Sec AS SecConcep,CP.NomConcepto, " +
                 " SUM(NLC.Base) AS Base,NLC.NomBase,'0' As Tipo,'3-Descuentos' As NomTipo,SUM(NLC.Valor) AS Valor " +
                " FROM NominaLiquidaSemestresConceptos NLC " +
                " INNER JOIN NominaLiquidaSemestresContratos NCT ON NLC.LiquidaContrato = NCT.Sec " +
                " INNER JOIN NominaLiquidaSemestres NL ON NCT.NominaLiquidaSemestres = NL.Sec " +
                 " INNER JOIN ConceptosPersonales CP ON NLC.SecConceptoP = CP.Sec " +
                 " WHERE NL.Sec = {0} " +
                 " GROUP BY CP.Sec,CP.NomConcepto,NLC.NomBase HAVING SUM(NLC.Valor)>0", CInt(gvLiquidaciones.GetFocusedRowCellValue("Sec")))
                titulo = "Liquidacion " + gvLiquidaciones.GetFocusedRowCellValue("Semestre").ToString
            ElseIf TipoConsultaImp = TipoDeLiquidacionImprime.LiquidaContratos Then
                sql = String.Format("SELECT CP.Sec AS SecConcep,CP.NomConcepto, " +
                " SUM(NLC.Base) AS Base,NLC.NomBase,CP.Tipo, CAST(CASE WHEN TP.NomTipo = 'Provisiones' THEN 'Ingresos' ELSE TP.NomTipo END AS VARCHAR) AS NomTipo,SUM(NLC.Valor) AS Valor " +
                " FROM ContratosLiquidados_Conceptos NLC " +
                " INNER JOIN ContratosLiquidados_Contratos NCT ON NLC.LiquidaContrato = NCT.Sec " +
                " INNER JOIN ContratosLiquidados NL ON NCT.NominaLiquida = NL.Sec " +
                " INNER JOIN ConceptosNomina CP ON NLC.SecConcepto = CP.Sec " +
                " INNER JOIN TiposConceptosNomina TP ON CP.Tipo = TP.Sec WHERE NL.Sec = {0} " +
                " GROUP BY CP.Sec,CP.NomConcepto,CP.Tipo,TP.NomTipo,NLC.NomBase HAVING SUM(NLC.Valor)>0", CInt(gvLiquidaciones.GetFocusedRowCellValue("Sec")))
                Dim FechaL As String = gvLiquidaciones.GetFocusedRowCellValue("Fecha").ToString
                FechaL = FechaL.Substring(0, 10)
                titulo = "Liquidacion de contratos" + gvLiquidaciones.GetFocusedRowCellValue("Nomina").ToString + " " + FechaL
            End If

            clImprimir.ImprimeTotalesXperiodoDetalle(sql, CInt(gvLiquidaciones.GetFocusedRowCellValue("Sec")), "", CInt(NominaTipoCont), Descripcion, False, titulo)
            'clImprimir.ImprimeTotalesXperiodoDetalle(sql, CInt(gvRes.GetFocusedRowCellValue("Codigo")), gvRes.GetFocusedRowCellValue("Descripcion").ToString,
            '                                         SecNomina, DesNomina, False)
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "btnImpTotalesXperiodo_ItemClick")
        End Try
    End Sub

    Private Sub btnContabilizar_Click(sender As Object, e As EventArgs) Handles btnContabilizar.Click
        If Not ValidaCamposContabiliza() Then
            Exit Sub
        End If
        Dim TipoLiq As String = ""
        If gvLiquidaciones.RowCount > 0 Then
            NominaTipoCont = txtNominas.ValordelControl
            If grbTipoConsul.SelectedIndex = 0 Then
                TipoConsultaImp = TipoDeLiquidacionImprime.Ordinaria
                Descripcion = gvLiquidaciones.GetFocusedRowCellValue("Sec").ToString
                TipoLiq = "P"
            ElseIf grbTipoConsul.SelectedIndex = 1 Then
                TipoConsultaImp = TipoDeLiquidacionImprime.Semestre
                Descripcion = gvLiquidaciones.GetFocusedRowCellValue("Sec").ToString
                TipoLiq = "S"
            ElseIf grbTipoConsul.SelectedIndex = 2 Then
                TipoConsultaImp = TipoDeLiquidacionImprime.Extraordinaria
                TipoLiq = "E"
            ElseIf grbTipoConsul.SelectedIndex = 3 Then
                TipoConsultaImp = TipoDeLiquidacionImprime.LiquidaContratos
                NominaTipoCont = TipoContrato
                TipoLiq = "C"
            End If
            Dim Frm As New FrmContbLiquidaciones()
            Dim classResize As New ClaseResize

            classResize.Resizamodales(Frm, 90, 80)
            Frm.PAño = txtAño.ValordelControl
            Frm.PSecLiquidacion = gvLiquidaciones.GetFocusedRowCellValue("Sec").ToString
            Frm.PTipoLiquida = TipoLiq
            Frm.PSecNomina = NominaTipoCont
            Frm.ShowDialog()
            Frm.BringToFront()
        End If
    End Sub

    Private Sub menuImprimir_KeyPress(sender As Object, e As KeyPressEventArgs) Handles menuImprimir.KeyPress, btnSalir.KeyPress, btnDetalles.KeyPress, btnContabilizar.KeyPress, btnBuscar.KeyPress, btnAnular.KeyPress
        HDevExpre.AtrasConScape(e)
    End Sub

    Private Sub grbTipoConsul_KeyPress(sender As Object, e As KeyPressEventArgs) Handles grbTipoConsul.KeyPress
        HDevExpre.AvanzaConEnter(e)
    End Sub

    Public Function AnulaLiquidaSemestres(Conexion As Object, SecLiquidacion As String) As Boolean
        Dim GenSql As New SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL
        Dim GenSql2 As New SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL
        GenSql.PasoConexionTabla(Conexion, "NominaLiquidaSemestres")
        GenSql2.PasoConexionTabla(Conexion, "SemestresLiquidacion")
        Dim SecSemestre As String = SMT_AbrirTabla(ObjetoApiNomina, "SELECT Semestre AS Codigo FROM NominaLiquidaSemestres Where Sec =" + SecLiquidacion).Rows(0)(0).ToString
        GenSql2.PasoValores("Estado", "P", SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
        GenSql.PasoValores("Estado", "A", SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)

        If GenSql.EjecutarComandoNET(SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.SQLGenera.Actualizacion, String.Format("Sec={0} ", SecLiquidacion)) Then
            If GenSql2.EjecutarComandoNET(SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.SQLGenera.Actualizacion, String.Format("Sec={0} ", SecSemestre)) Then
                Return True
            Else
                Return False
            End If
        Else Return False
        End If
    End Function


    Public Function AnulaLiquidaExtraordinaria(Conexion As Object, SecLiquidacion As String) As Boolean
        Dim GenSql As New SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL
        GenSql.PasoConexionTabla(Conexion, "NominaLiquidaExtraordinaria")
        GenSql.PasoValores("Estado", "A", SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
        If GenSql.EjecutarComandoNET(SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.SQLGenera.Actualizacion, String.Format("Sec={0} ", SecLiquidacion)) Then
            Return True
        Else Return False
        End If
    End Function

    Public Function RecorreDescuentos(Conexion As Object, SecLiquidacion As String, Tipo As String) As Boolean
        Dim Descuentos As New DataTable
        If Tipo = "P" Then
            Descuentos = SMT_AbrirTabla(ObjetoApiNomina, "Select NLCC.SecConceptoP2,NLCC.Valor,NLCC.Cuota,CP.NomConcepto,C.IdContrato From NominaLiquidadaConceptos NLCC INNER JOIN ConceptosPersonales CP ON NLCC.SecConceptoP = CP.Sec INNER JOIN NominaLiquidadaContratos NLC On NLCC.LiquidadaContrato = NLC.Sec INNER JOIN Contratos C ON NLC.Contrato= C.CodContrato Where NLC.NominaLiquidada ='" + SecLiquidacion + "' And NLCC.SecConceptoP2 <> ''")
        End If

        If Tipo = "S" Then
            Descuentos = SMT_AbrirTabla(ObjetoApiNomina, "Select NLCC.SecConceptoP2,NLCC.Valor,NLCC.Cuota,CP.NomConcepto,C.IdContrato From NominaLiquidaSemestresConceptos NLCC INNER JOIN ConceptosPersonales CP ON NLCC.SecConceptoP = CP.Sec INNER JOIN NominaLiquidaSemestresContratos NLC On NLCC.LiquidaContrato = NLC.Sec INNER JOIN Contratos C ON NLC.Contrato= C.CodContrato Where NLC.NominaLiquidaSemestres ='" + SecLiquidacion + "' And NLCC.SecConceptoP2 <> ''")

        End If

        If Tipo = "E" Then
            Descuentos = SMT_AbrirTabla(ObjetoApiNomina, "Select NLCC.SecConceptoP2,NLCC.Valor,NLCC.Cuota,CP.NomConcepto,C.IdContrato From NominaLiquidaExtraordinariaConceptos NLCC INNER JOIN ConceptosPersonales CP ON NLCC.SecConceptoP = CP.Sec INNER JOIN NominaLiquidaExtraordinariaContratos NLC On NLCC.LiquidaContrato = NLC.Sec INNER JOIN Contratos C ON NLC.Contrato= C.CodContrato Where NLC.NominaLiquidaExtraordinaria ='" + SecLiquidacion + "' And NLCC.SecConceptoP2 <> ''")

        End If
        If Descuentos.Rows.Count > 0 Then
            If Descuentos.Rows.Count = 1 Then
                Dim str As String = "Select Isnull(Max(Tb.Num),0) As Cuota From " +
" (Select NLC.Cuota As Num From NominaLiquidadaConceptos NLC Inner Join NominaLiquidadaContratos NLDC On NLC.LiquidadaContrato = NLDC.Sec Inner Join NominaLiquidada NL ON NLDC.NominaLiquidada = NL.Sec Where NL.Estado <>'A' And NLC.SecConceptoP2=" + Descuentos.Rows(0)("SecConceptoP2").ToString +
" Union " +
" Select NLC.Cuota As Num From NominaLiquidaExtraordinariaConceptos NLC Inner Join NominaLiquidaExtraordinariaContratos NLDC On NLC.LiquidaContrato = NLDC.Sec Inner Join NominaLiquidaExtraordinaria NL ON NLDC.NominaLiquidaExtraordinaria = NL.Sec Where NL.Estado <>'A' And NLC.SecConceptoP2=" + Descuentos.Rows(0)("SecConceptoP2").ToString +
" Union " +
" Select NLC.Cuota As Num From NominaLiquidaSemestresConceptos NLC Inner Join NominaLiquidaSemestresContratos NLDC On NLC.LiquidaContrato = NLDC.Sec Inner Join NominaLiquidaSemestres NL ON NLDC.NominaLiquidaSemestres = NL.Sec Where NL.Estado <>'A' And NLC.SecConceptoP2=" + Descuentos.Rows(0)("SecConceptoP2").ToString +
" ) As Tb"
                Dim CuotaD As Integer = CInt(SMT_AbrirTabla(ObjetoApiNomina, str).Rows(0)(0))
                Dim CuotaC As Integer = CInt(Descuentos.Rows(0)("Cuota"))

                If CuotaD <> CuotaC Then
                    HDevExpre.MensagedeError("El Concepto Personal " + Descuentos.Rows(0)("NomConcepto").ToString + " aplicado al Contrato " + Descuentos.Rows(0)("IdContrato").ToString + " se ha efectuado en liquidaciones posteriores, no es posible continuar!..")
                    Return False
                End If

                If Not RestaDescuentos(Conexion, Descuentos.Rows(0)("Valor").ToString, Descuentos.Rows(0)("SecConceptoP2").ToString) Then
                    Return False
                End If
            Else
                For incre As Integer = 0 To Descuentos.Rows.Count - 1

                    Dim srt As String = "Select Isnull(Max(Tb.Num),0) As Cuota From " +
" (Select NLC.Cuota As Num From NominaLiquidadaConceptos NLC Inner Join NominaLiquidadaContratos NLDC On NLC.LiquidadaContrato = NLDC.Sec Inner Join NominaLiquidada NL ON NLDC.NominaLiquidada = NL.Sec Where NL.Estado <>'A' And NLC.SecConceptoP2=" + Descuentos.Rows(incre)("SecConceptoP2").ToString +
" Union " +
" Select NLC.Cuota As Num From NominaLiquidaExtraordinariaConceptos NLC Inner Join NominaLiquidaExtraordinariaContratos NLDC On NLC.LiquidaContrato = NLDC.Sec Inner Join NominaLiquidaExtraordinaria NL ON NLDC.NominaLiquidaExtraordinaria = NL.Sec Where NL.Estado <>'A' And NLC.SecConceptoP2=" + Descuentos.Rows(incre)("SecConceptoP2").ToString +
" Union " +
" Select NLC.Cuota As Num From NominaLiquidaSemestresConceptos NLC Inner Join NominaLiquidaSemestresContratos NLDC On NLC.LiquidaContrato = NLDC.Sec Inner Join NominaLiquidaSemestres NL ON NLDC.NominaLiquidaSemestres = NL.Sec Where NL.Estado <>'A' And NLC.SecConceptoP2=" + Descuentos.Rows(incre)("SecConceptoP2").ToString +
" ) As Tb"
                    Dim CuotaD As Integer = CInt(SMT_AbrirTabla(ObjetoApiNomina, srt).Rows(0)(0))
                    Dim CuotaC As Integer = CInt(Descuentos.Rows(incre)("Cuota"))

                    If CuotaD <> CuotaC Then
                        HDevExpre.MensagedeError("El Concepto Personal " + Descuentos.Rows(incre)("NomConcepto").ToString + " aplicado al Contrato " + Descuentos.Rows(incre)("IdContrato").ToString + " se ha efectuado en liquidaciones posteriores, no es posible continuar!..")
                        Return False
                    End If

                    If Not RestaDescuentos(Conexion, Descuentos.Rows(incre)("Valor").ToString, Descuentos.Rows(incre)("SecConceptoP2").ToString) Then
                        Return False
                    End If
                Next
            End If

        End If
        Return True
    End Function

    Public Function RestaDescuentos(Conexion As Object, Valor As String, SecDescuento As String) As Boolean
        Dim InfoDescuento As DataTable = SMT_AbrirTabla(ObjetoApiNomina, "Select Isnull(CuotaActual,0) Cuota,TotalDescontado From ConceptosP_Contratos where Sec=" + SecDescuento)
        Dim Cuota As Integer = CInt(InfoDescuento.Rows(0)("Cuota"))
        Cuota = Cuota - 1
        Dim Valor1 As Decimal = CDec(InfoDescuento.Rows(0)("TotalDescontado"))
        Valor1 = Valor1 - CDec(Valor)
        Dim GenSql As New SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL
        GenSql.PasoConexionTabla(Conexion, "ConceptosP_Contratos")
        GenSql.PasoValores("TotalDescontado", Valor1.ToString, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
        GenSql.PasoValores("CuotaActual", Cuota.ToString, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
        If GenSql.EjecutarComandoNET(SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.SQLGenera.Actualizacion, String.Format("Sec={0} ", SecDescuento)) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function AnulaLiquidaContratos(Conexion As Object, SecLiquidacion As String) As Boolean
        Dim GenSql As New SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL
        Dim GenSql2 As New SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL
        GenSql.PasoConexionTabla(Conexion, "ContratosLiquidados")
        GenSql2.PasoConexionTabla(Conexion, "Contratos")
        Dim Contratoss As DataTable = SMT_AbrirTabla(ObjetoApiNomina, "Select Contrato From ContratosLiquidados_Contratos Where NominaLiquida=" + SecLiquidacion)
        GenSql2.PasoValores("Terminado", "0", SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
        GenSql.PasoValores("Estado", "A", SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)

        If GenSql.EjecutarComandoNET(SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.SQLGenera.Actualizacion, String.Format("Sec={0} ", SecLiquidacion)) Then
            For incre As Integer = 0 To Contratoss.Rows.Count - 1
                If GenSql2.EjecutarComandoNET(SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.SQLGenera.Actualizacion, String.Format("CodContrato={0} ", Contratoss.Rows(incre)("Contrato").ToString)) Then

                Else
                    Return False
                End If
            Next
            Return True
        Else Return False
        End If
    End Function


    Public Function AnulaLiquidaPeriodos(Conexion As Object, SecLiquidacion As String) As Boolean
        Dim GenSql As New SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL
        Dim GenSql2 As New SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL
        GenSql.PasoConexionTabla(Conexion, "NominaLiquidada")
        GenSql2.PasoConexionTabla(Conexion, "PeriodosLiquidacion")
        Dim SecPeriodo As String = SMT_AbrirTabla(ObjetoApiNomina, "SELECT Periodo AS Codigo FROM NominaLiquidada Where Sec =" + SecLiquidacion).Rows(0)(0).ToString
        GenSql2.PasoValores("Estado", "P", SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
        GenSql.PasoValores("Estado", "A", SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)

        If GenSql.EjecutarComandoNET(SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.SQLGenera.Actualizacion, String.Format("Sec={0} ", SecLiquidacion)) Then
            If GenSql2.EjecutarComandoNET(SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.SQLGenera.Actualizacion, String.Format("Sec={0} ", SecPeriodo)) Then
                Return True
            Else
                Return False
            End If
        Else Return False
        End If
    End Function

    Public Function ValidaCamposAnula() As Boolean
        If Not gvLiquidaciones.RowCount > 0 Then
            HDevExpre.MensagedeError("No hay liquidaciones que anular..!")
            Return False
        ElseIf gvLiquidaciones.GetFocusedRowCellValue("Estado").ToString = "Anulada" Then
            HDevExpre.MensagedeError("Esta Liquidación ya se encuentra anulada..!")
            Return False
        Else
            Return True
        End If
    End Function

    Public Function ValidaCamposContabiliza() As Boolean
        If Not gvLiquidaciones.RowCount > 0 Then
            HDevExpre.MensagedeError("No hay liquidaciones que contabilizar..!")
            Return False
        ElseIf gvLiquidaciones.GetFocusedRowCellValue("Estado").ToString = "Anulada" Then
            HDevExpre.MensagedeError("Esta Liquidación se encuentra anulada..!")
            Return False
        Else
            Return True
        End If
    End Function


    Private Sub btnAnular_Click(sender As Object, e As EventArgs) Handles btnAnular.Click

        Dim wait As New ClEspera

        Try
            ' Validar que se pueda anular
            If Not ValidaCamposAnula() Then
                Exit Sub
            End If

            ' Determinar tipo de liquidación
            Dim tipoLiquidacion As String = ""
            Dim mensajeConfirmacion As String = ""

            Select Case grbTipoConsul.SelectedIndex
                Case 0 ' Periodos
                    tipoLiquidacion = "P"
                    mensajeConfirmacion = "Seguro que desea anular esta liquidación de periodos?"
                Case 1 ' Semestres
                    tipoLiquidacion = "S"
                    mensajeConfirmacion = "Seguro que desea anular esta liquidación de semestres?"
                Case 2 ' Extraordinaria
                    tipoLiquidacion = "E"
                    mensajeConfirmacion = "Seguro que desea anular esta liquidación extraordinaria?"
                Case 3 ' Contratos
                    tipoLiquidacion = "C"
                    mensajeConfirmacion = "Seguro que desea anular esta liquidación de contratos?"
            End Select

            ' Confirmar con el usuario
            If HDevExpre.MsgSamit(mensajeConfirmacion, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.OK Then
                ' Mostrar mensaje de espera
                wait.Mostrar()
                wait.Descripcion = "Anulando..."

                ' Crear el request
                Dim request As New AnularLiquidacionRequest With {
                .SecLiquidacion = CInt(gvLiquidaciones.GetFocusedRowCellValue("Sec")),
                .TipoLiquidacion = tipoLiquidacion
            }

                ' Ejecutar procedimiento almacenado
                Dim resp = SMT_EjecutaProcedimientos(ObjetoApiNomina, "SP_AnularLiquidacion", request.ToJObject())
                Dim response = resp.ToObject(Of AnularLiquidacionResponse)()

                ' Procesar respuesta
                wait.Terminar()

                If response.EsExitoso Then
                    ' Mostrar mensaje de éxito
                    HDevExpre.mensajeExitoso(response.Mensaje)

                    ' Refrescar la grilla
                    LlenaGrilla()
                Else
                    ' Mostrar mensaje de error
                    HDevExpre.MensagedeError(response.Mensaje)

                    ' Log adicional si hay código de error
                    If response.CodigoError.HasValue Then
                        Console.WriteLine($"Código de error SQL: {response.CodigoError.Value}")
                    End If
                End If
            End If

        Catch ex As Exception
            wait.Terminar()
            HDevExpre.MensagedeError(ex.Message)
        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub



    Private Sub menuImprimir_Click(sender As Object, e As EventArgs) Handles menuImprimir.Click

    End Sub

    Private Sub btnImpXConceptos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Try
            Dim Descripcion As String = ""
            Dim NominaTipoCont As String = Nomina
            Dim titulo As String = ""
            If gvLiquidaciones.RowCount = 0 Then Exit Sub
            'SQL PARA NOMINAS EN FIRME
            Dim sql As String = String.Format("SELECT EM.Identificacion,CAST(CAST(EM.Identificacion AS VARCHAR) +' | '+ RTRIM(LTRIM(RTRIM(LTRIM(EM.PNombre)) + ' ' +  " +
            " RTRIM(LTRIM(EM.SNombre)) + ' ' +  RTRIM(LTRIM(EM.PApellido)) + ' ' + RTRIM(LTRIM(EM.SApellido)))) AS VARCHAR) AS Nombres,   " +
            " CP.Sec AS SecConcep,CP.NomConcepto, NLC.Valor, CP.Tipo, TP.NomTipo,CT.IdContrato  " +
            " FROM NominaLiquidadaConceptos NLC  " +
            " INNER JOIN NominaLiquidadaContratos NCT ON NLC.LiquidadaContrato = NCT.Sec  " +
            " INNER JOIN NominaLiquidada NL ON NCT.NominaLiquidada = NL.Sec  " +
            " INNER JOIN Contratos CT ON NCT.Contrato = CT.CodContrato  " +
            " INNER JOIN ConceptosNomina CP ON NLC.SecConcepto = CP.Sec  " +
            " INNER JOIN TiposConceptosNomina TP ON CP.Tipo = TP.Sec  " +
            " INNER JOIN Empleados EM ON CT.Empleado = EM.IdEmpleado  " +
            " WHERE NL.Sec = {0} AND NLC.Valor > 0 " +
            " UNION" +
            " SELECT EM.Identificacion,CAST(CAST(EM.Identificacion AS VARCHAR) +' | '+ RTRIM(LTRIM(RTRIM(LTRIM(EM.PNombre)) + ' ' +  " +
            " RTRIM(LTRIM(EM.SNombre)) + ' ' +  RTRIM(LTRIM(EM.PApellido)) + ' ' + RTRIM(LTRIM(EM.SApellido)))) AS VARCHAR) AS Nombres,   " +
            " CP.Sec AS SecConcep,CP.NomConcepto, NLC.Valor, '0' as Tipo, 'Descuento' as NomTipo,CT.IdContrato  " +
            " FROM NominaLiquidadaConceptos NLC " +
            " INNER JOIN NominaLiquidadaContratos NCT ON NLC.LiquidadaContrato = NCT.Sec " +
            " INNER JOIN NominaLiquidada NL ON NCT.NominaLiquidada = NL.Sec " +
            " INNER JOIN Contratos CT ON NCT.Contrato = CT.CodContrato " +
            " INNER JOIN PeriodosLiquidacion PL ON NL.Periodo = PL.Sec" +
            " INNER JOIN Empleados EM ON CT.Empleado = EM.IdEmpleado  " +
            " INNER JOIN ConceptosPersonales CP ON NLC.SecConceptoP = CP.Sec" +
            " WHERE NL.Sec = {0} AND NLC.Valor > 0", CInt(gvLiquidaciones.GetFocusedRowCellValue("Sec"))) 'gvRes.GetFocusedRowCellValue("Codigo"))
            Try
                If grbTipoConsul.SelectedIndex = 0 Then
                    titulo = "Liquidacion " + gvLiquidaciones.GetFocusedRowCellValue("Periodo").ToString
                ElseIf grbTipoConsul.SelectedIndex = 1 Then
                    titulo = "Liquidacion " + gvLiquidaciones.GetFocusedRowCellValue("Semestre").ToString
                ElseIf grbTipoConsul.SelectedIndex = 2 Then

                ElseIf grbTipoConsul.SelectedIndex = 3 Then

                End If
            Catch

            End Try
            If TipoConsultaImp = TipoDeLiquidacionImprime.Extraordinaria Then
                sql = String.Format("SELECT EM.Identificacion,CAST(CAST(EM.Identificacion AS VARCHAR) +' | '+ RTRIM(LTRIM(RTRIM(LTRIM(EM.PNombre)) + ' ' +  " +
                " RTRIM(LTRIM(EM.SNombre)) + ' ' +  RTRIM(LTRIM(EM.PApellido)) + ' ' + RTRIM(LTRIM(EM.SApellido)))) AS VARCHAR) AS Nombres,   " +
                " CP.Sec AS SecConcep,CP.NomConcepto, NLC.Valor, CP.Tipo, CAST(CASE WHEN TP.NomTipo = 'Provisiones' THEN 'Ingresos' ELSE TP.NomTipo END AS VARCHAR) AS NomTipo,CT.IdContrato  " +
                " FROM NominaLiquidaExtraordinariaConceptos NLC  " +
                " INNER JOIN NominaLiquidaExtraordinariaContratos NCT ON NLC.LiquidaContrato = NCT.Sec  " +
                " INNER JOIN NominaLiquidaExtraordinaria NL ON NCT.NominaLiquidaExtraordinaria = NL.Sec  " +
                " INNER JOIN Contratos CT ON NCT.Contrato = CT.CodContrato  " +
                " INNER JOIN ConceptosNomina CP ON NLC.SecConcepto = CP.Sec  " +
                " INNER JOIN TiposConceptosNomina TP ON CP.Tipo = TP.Sec  " +
                " INNER JOIN Empleados EM ON CT.Empleado = EM.IdEmpleado  " +
                " WHERE NL.Sec = {0} AND NLC.Valor > 0" +
                            " UNION" +
            " SELECT EM.Identificacion,CAST(CAST(EM.Identificacion AS VARCHAR) +' | '+ RTRIM(LTRIM(RTRIM(LTRIM(EM.PNombre)) + ' ' +  " +
            " RTRIM(LTRIM(EM.SNombre)) + ' ' +  RTRIM(LTRIM(EM.PApellido)) + ' ' + RTRIM(LTRIM(EM.SApellido)))) AS VARCHAR) AS Nombres,   " +
            " CP.Sec AS SecConcep,CP.NomConcepto, NLC.Valor, '0' as Tipo, 'Descuento' as NomTipo,CT.IdContrato  " +
                " FROM NominaLiquidaExtraordinariaConceptos NLC  " +
                " INNER JOIN NominaLiquidaExtraordinariaContratos NCT ON NLC.LiquidaContrato = NCT.Sec  " +
                " INNER JOIN NominaLiquidaExtraordinaria NL ON NCT.NominaLiquidaExtraordinaria = NL.Sec  " +
            " INNER JOIN Contratos CT ON NCT.Contrato = CT.CodContrato " +
            " INNER JOIN Empleados EM ON CT.Empleado = EM.IdEmpleado  " +
            " INNER JOIN ConceptosPersonales CP ON NLC.SecConceptoP = CP.Sec" +
            " WHERE NL.Sec = {0} AND NLC.Valor > 0", CInt(gvLiquidaciones.GetFocusedRowCellValue("Sec")))
                Dim FechaL As String = gvLiquidaciones.GetFocusedRowCellValue("Fecha").ToString
                FechaL = FechaL.Substring(0, 10)
                titulo = "Liquidacion extraordinaria " + gvLiquidaciones.GetFocusedRowCellValue("Nomina").ToString + " " + FechaL
            ElseIf TipoConsultaImp = TipoDeLiquidacionImprime.Semestre Then
                sql = String.Format("SELECT EM.Identificacion,CAST(CAST(EM.Identificacion AS VARCHAR) +' | '+ RTRIM(LTRIM(RTRIM(LTRIM(EM.PNombre)) + ' ' +  " +
              " RTRIM(LTRIM(EM.SNombre)) + ' ' +  RTRIM(LTRIM(EM.PApellido)) + ' ' + RTRIM(LTRIM(EM.SApellido)))) AS VARCHAR) AS Nombres,   " +
              " CP.Sec AS SecConcep,CP.NomConcepto, NLC.Valor, CP.Tipo, CAST(CASE WHEN TP.NomTipo = 'Provisiones' THEN 'Ingresos' ELSE TP.NomTipo END AS VARCHAR) AS NomTipo,CT.IdContrato  " +
              " FROM NominaLiquidaSemestresConceptos NLC  " +
              " INNER JOIN NominaLiquidaSemestresContratos NCT ON NLC.LiquidaContrato = NCT.Sec  " +
              " INNER JOIN NominaLiquidaSemestres NL ON NCT.NominaLiquidaSemestres = NL.Sec  " +
              " INNER JOIN Contratos CT ON NCT.Contrato = CT.CodContrato  " +
              " INNER JOIN ConceptosNomina CP ON NLC.SecConcepto = CP.Sec  " +
              " INNER JOIN TiposConceptosNomina TP ON CP.Tipo = TP.Sec  " +
              " INNER JOIN Empleados EM ON CT.Empleado = EM.IdEmpleado  " +
              " WHERE NL.Sec = {0} AND NLC.Valor > 0 " +
                " UNION" +
            " SELECT EM.Identificacion,CAST(CAST(EM.Identificacion AS VARCHAR) +' | '+ RTRIM(LTRIM(RTRIM(LTRIM(EM.PNombre)) + ' ' +  " +
            " RTRIM(LTRIM(EM.SNombre)) + ' ' +  RTRIM(LTRIM(EM.PApellido)) + ' ' + RTRIM(LTRIM(EM.SApellido)))) AS VARCHAR) AS Nombres,   " +
            " CP.Sec AS SecConcep,CP.NomConcepto, NLC.Valor, '0' as Tipo, 'Descuento' as NomTipo,CT.IdContrato  " +
              " FROM NominaLiquidaSemestresConceptos NLC  " +
              " INNER JOIN NominaLiquidaSemestresContratos NCT ON NLC.LiquidaContrato = NCT.Sec  " +
              " INNER JOIN NominaLiquidaSemestres NL ON NCT.NominaLiquidaSemestres = NL.Sec  " +
            " INNER JOIN Contratos CT ON NCT.Contrato = CT.CodContrato " +
            " INNER JOIN Empleados EM ON CT.Empleado = EM.IdEmpleado  " +
            " INNER JOIN ConceptosPersonales CP ON NLC.SecConceptoP = CP.Sec" +
            " WHERE NL.Sec = {0} AND NLC.Valor > 0", CInt(gvLiquidaciones.GetFocusedRowCellValue("Sec")))
                titulo = "Liquidacion " + gvLiquidaciones.GetFocusedRowCellValue("Semestre").ToString
            ElseIf TipoConsultaImp = TipoDeLiquidacionImprime.LiquidaContratos Then
                sql = String.Format("SELECT EM.Identificacion,CAST(CAST(EM.Identificacion AS VARCHAR) +' | '+ RTRIM(LTRIM(RTRIM(LTRIM(EM.PNombre)) + ' ' +  " +
                " RTRIM(LTRIM(EM.SNombre)) + ' ' +  RTRIM(LTRIM(EM.PApellido)) + ' ' + RTRIM(LTRIM(EM.SApellido)))) AS VARCHAR) AS Nombres,   " +
                " CP.Sec AS SecConcep,CP.NomConcepto, NLC.Valor, CP.Tipo, CAST(CASE WHEN TP.NomTipo = 'Provisiones' THEN 'Ingresos' ELSE TP.NomTipo END AS VARCHAR) AS NomTipo,CT.IdContrato  " +
                " FROM ContratosLiquidados_Conceptos NLC  " +
                " INNER JOIN ContratosLiquidados_Contratos NCT ON NLC.LiquidaContrato = NCT.Sec  " +
                " INNER JOIN ContratosLiquidados NL ON NCT.NominaLiquida = NL.Sec  " +
                " INNER JOIN Contratos CT ON NCT.Contrato = CT.CodContrato  " +
                " INNER JOIN ConceptosNomina CP ON NLC.SecConcepto = CP.Sec  " +
                " INNER JOIN TiposConceptosNomina TP ON CP.Tipo = TP.Sec  " +
                " INNER JOIN Empleados EM ON CT.Empleado = EM.IdEmpleado  " +
                " WHERE NL.Sec = {0} AND NLC.Valor > 0 ORDER BY Identificacion", CInt(gvLiquidaciones.GetFocusedRowCellValue("Sec")))
                Dim FechaL As String = gvLiquidaciones.GetFocusedRowCellValue("Fecha").ToString
                FechaL = FechaL.Substring(0, 10)
                titulo = "Liquidacion de contratos" + gvLiquidaciones.GetFocusedRowCellValue("Nomina").ToString + " " + FechaL
            End If
            clImprimir.ImprimeTotalesXConceptos(sql, CInt(gvLiquidaciones.GetFocusedRowCellValue("Sec")), "", CInt(NominaTipoCont), Descripcion, False, titulo)
            'clImprimir.ImprimeXperiodoDetalle(sql, CInt(gvRes.GetFocusedRowCellValue("Codigo")),
            '                                  gvRes.GetFocusedRowCellValue("Descripcion").ToString,
            '                                  SecNomina, DesNomina, False)
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "btnImpDetallado_ItemClick")
        End Try
    End Sub

    Private Sub bntEnviarDian_Click(sender As Object, e As EventArgs) Handles bntEnviarDian.Click

        If grbTipoConsul.SelectedIndex = 0 Then
            If gvLiquidaciones.GetFocusedRowCellValue("Estado").ToString = "Anulada" Then
                HDevExpre.MensagedeError("Esta Liquidación se encuentra anulada..!")
                Exit Sub
            End If
            If gvLiquidaciones.GetFocusedRowCellValue("FormaLiquida").ToString = "10" Then
                If gvLiquidaciones.GetFocusedRowCellValue("PeriodoMes").ToString <> "3" Then
                    HDevExpre.MensagedeError("Solo puede ser enviado el ultimo periodo del mes..!")
                    Exit Sub
                End If
            End If
            If gvLiquidaciones.GetFocusedRowCellValue("FormaLiquida").ToString = "15" Then
                If gvLiquidaciones.GetFocusedRowCellValue("PeriodoMes").ToString <> "2" Then
                    HDevExpre.MensagedeError("Solo puede ser enviado el ultimo periodo del mes..!")
                    Exit Sub
                End If
            End If
            If gvLiquidaciones.RowCount > 0 Then
                Dim Frm As New FrmEnviarDian()
                If HDevExpre.EstaCargadoFormulario("FrmEnviarDian") Then Exit Sub
                Frm.SecConsulta = gvLiquidaciones.GetFocusedRowCellValue("Sec").ToString
                Frm.Descrip = "Liquidacion " + gvLiquidaciones.GetFocusedRowCellValue("Periodo").ToString
                Frm.MdiParent = FrmPrincipal
                Frm.Show()
                'Frm.ShowDialog()
                'Frm.BringToFront()

            End If
        Else
            HDevExpre.MensagedeError("Esta opcion solo esta disponible, para liquidaciones de periodos..!")
        End If
    End Sub
End Class