Imports SamitCtlNet
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraEditors.Repository
Imports System.Data.SqlClient

Public Class FrmConfigTiposContratos

    Dim lkEdit As New RepositoryItemLookUpEdit
    Dim lkEdit2 As New RepositoryItemLookUpEdit
    Dim Ckedeit As New RepositoryItemCheckEdit
    Dim TipoContrato As String
    Dim HDevExpre As New HelperDevExpress
    Dim HNomina As New HelperNomina

    Private Sub AcomodaForm()
        Try
            btnGuardar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Guardar)
            btnLimpiar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Limpiar)
            btnSalir.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.SalirCuadroConX)
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, " AcomodaForm Plantillas")
        End Try
    End Sub

    Private Sub AsignaScriptAcontroles()
        Try
            txtTipoContrato.ConsultaSQL = String.Format("SELECT CodTipo AS Codigo,NomTipo As Descripcion FROM  CAT_TipoContratos")

        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "AsignaScriptAcontroles")
        End Try
    End Sub

    Private Sub LlenaGrilla(Parametro As String)
        Try
            Dim sql As String = "Select C.NomConcepto AS NomConcepto,C.Sec AS SecConcepto,TC.NomTipo AS NomTipo," +
" TC.CodTipo as SecTipo,LC.BaseCalculo,LC.Formula,LC.Sec as SecConfig,LC.SeLiquida As SeLiquida,LC.CuentaContable As CuentaContable " +
" From TiposContratos_ConceptosNomina LC INNER JOIN ConceptosNomina C On LC.Concepto = C.Sec " +
" INNER JOIN CAT_TipoContratos TC ON LC.TipoContrato = TC.CodTipo WHERE LC.TipoContrato=" + Parametro
            Dim dt As DataTable = SMT_AbrirTabla(ObjetoApiNomina, sql)
            gcConfigTiposContratos.DataSource = dt

            sql = "Select ROW_NUMBER() OVER(ORDER BY Nombre ASC) AS Codigo, Consul.Nombre From( " +
                                                     " Select NomBase As Nombre From BasesConceptos Union " +
                                                     " Select NomConcepto As Nombre From ConceptosNomina Union " +
                                                     " Select NomVariable As Nombre From VariablesGenerales Union " +
                                                     " Select NomVariable As Nombre From VariablesPersonales Union " +
                                                     " Select 'Asignacion' As Nombre Union " +
                                                     " Select 'HorasMes' As Nombre Union " +
                                                     " Select 'TotalPagadoMes' As Nombre Union " +
                                                     " Select 'RentaExenta' As Nombre Union " +
                                                      " Select 'SalarioPromedioMensualAnual' As Nombre Union " +
                                                      " Select 'SalarioPromedioMensualSemestral' As Nombre Union " +
                                                      " Select 'NetoAPagar' As Nombre Union " +
                                                      " Select 'TotalIngresos' As Nombre Union " +
                                                      " Select 'TotalDeducciones' As Nombre Union " +
                                                     " Select 'DescuentosPorNomina' As Nombre) as Consul "
            dt = SMT_AbrirTabla(ObjetoApiNomina, sql)
            If dt.Rows.Count > 0 Then
                lkEdit.DataSource = dt
                lkEdit.ValueMember = "Codigo"
                lkEdit.DisplayMember = "Nombre"
                lkEdit.PopulateColumns()
                lkEdit.Columns(0).Visible = False
            End If

            sql = "SELECT CodCuenta AS Codigo,CodCuenta+'-'+NomCuenta AS Descripcion " &
                           " FROM CT_PlandeCuentas WHERE EsdeMovimiento=1 AND Estado='V'"
            dt = SMT_AbrirTabla(ObjetoApiNomina, sql)

            If dt.Rows.Count > 0 Then

                lkEdit2.DataSource = dt
                lkEdit2.ValueMember = "Codigo"
                lkEdit2.DisplayMember = "Descripcion"
                lkEdit2.PopulateColumns()
                lkEdit2.Columns(0).Visible = False
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "LlenaGrilla")
        End Try
    End Sub

    Private Sub CreaGrillaConfigTiposContratos()
        Dim coloor As System.Drawing.Color = Color.White
        gvConfigTiposContratos.Columns.Clear()
        CreaColumnas(gvConfigTiposContratos, "SecConfig", "SecConfig", False, False, "", coloor, False, 0, gcConfigTiposContratos.Width, False, False, False, False)
        CreaColumnas(gvConfigTiposContratos, "NomConcepto", "Concepto", True, False, "", coloor, False, 40, gcConfigTiposContratos.Width, False, False, False, False)
        CreaColumnas(gvConfigTiposContratos, "Formula", "Formula", True, False, "", coloor, False, 25, gcConfigTiposContratos.Width, False, False, True, False)
        CreaColumnas(gvConfigTiposContratos, "BaseCalculo", "Base de Calculo", True, True, "", coloor, False, 25, gcConfigTiposContratos.Width, False, True, True, False)
        CreaColumnas(gvConfigTiposContratos, "SeLiquida", "Liquidar", True, True, "", coloor, False, 10, gcConfigTiposContratos.Width, True, False, True, False)
        CreaColumnas(gvConfigTiposContratos, "CuentaContable", "Cuenta Contable", True, True, "", coloor, False, 25, gcConfigTiposContratos.Width, False, False, True, True)
        gvConfigTiposContratos.Appearance.HeaderPanel.Font = New Font("Trebuchet MS", 11.0!, FontStyle.Bold)
        gvConfigTiposContratos.Appearance.ViewCaption.Options.UseTextOptions = True
        gvConfigTiposContratos.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        gvConfigTiposContratos.Appearance.ViewCaption.ForeColor = Color.Blue

        Dim classResize As New ClaseResize
        classResize.Resizagrid(gvConfigTiposContratos)
    End Sub

    Private Sub CreaColumnas(Grid As GridView, Nombre As String, Titulo As String, Visible As Boolean, Editar As Boolean, formula As String, colores As System.Drawing.Color, numerico As Boolean, Porcentaje_Width As Single, TamañoPadre As Single, Escheck As Boolean, eslke As Boolean, focus As Boolean, eslke2 As Boolean)
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
            If eslke Then
                .ColumnEdit = lkEdit
                .OptionsColumn.AllowEdit = True
                .OptionsColumn.AllowFocus = True
                .AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            End If
            If Escheck Then
                .ColumnEdit = Ckedeit
                .OptionsColumn.AllowEdit = True
                .OptionsColumn.AllowFocus = True
                .AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            End If
            If eslke2 Then
                .ColumnEdit = lkEdit2
                .OptionsColumn.AllowEdit = True
                .OptionsColumn.AllowFocus = True
                .AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            End If
            If focus Then
                .OptionsColumn.AllowFocus = True
            End If
            .OptionsFilter.AllowFilter = False
            .Visible = Visible
            .AppearanceHeader.Options.UseTextOptions = True
            .AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            .AppearanceCell.Options.UseTextOptions = True

        End With
        Grid.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.CellFocus
        Grid.Columns.Add(gc)
    End Sub

    Private Sub FrmConfigTiposContratos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AsignaScriptAcontroles()
        AcomodaForm()
        CreaGrillaConfigTiposContratos()
        Creagrillahorizontal()
    End Sub

    Private Sub gvConfigTiposContratos_DoubleClick(sender As Object, e As EventArgs) Handles gvConfigTiposContratos.DoubleClick
        If gvConfigTiposContratos.FocusedColumn.Name = "Formula" Then
            gvVariables.Columns(gvVariables.Columns.Count - 1).UnboundExpression = gvConfigTiposContratos.GetFocusedRowCellValue("Formula").ToString
            gvVariables.ShowUnboundExpressionEditor(gvVariables.Columns(gvVariables.Columns.Count - 1))
            gvConfigTiposContratos.SetFocusedRowCellValue("Formula", gvVariables.Columns(gvVariables.Columns.Count - 1).UnboundExpression)

            If HDevExpre.MsgSamit(String.Format("Desea validar la formula?"), MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.OK Then
                Dim classResize As New ClaseResize
                classResize.Resizamodales(FrmValidaFormulas, 70, 25)
                FrmValidaFormulas.Formula = IIf(IsNothing(gvConfigTiposContratos.GetFocusedRowCellValue("Formula").ToString), "", gvConfigTiposContratos.GetFocusedRowCellValue("Formula").ToString)
                FrmValidaFormulas.Show()
                FrmValidaFormulas.BringToFront()
            End If

        End If
    End Sub

    Private Sub Creagrillahorizontal()
        gvVariables.Columns.Clear()
        Dim sql As String
        Dim filas As New DataTable
        Dim NuevaFila As DataRow = filas.NewRow()
        Dim dt As DataTable = New DataTable
        Dim coloor As System.Drawing.Color = Color.White

        'Variables predeterminadas
        CreaColumnas(gvVariables, "Asignacion", "Asignacion", True, True, "", Color.FromArgb(&HFF, &HE3, &HDB), True, 0, 0, False, False, False, False)
        dt.Columns.Add("Asignacion", GetType(Decimal))
        CreaColumnas(gvVariables, "HorasMes", "HorasMes", True, True, "", Color.FromArgb(&HFF, &HE3, &HDB), True, 0, 0, False, False, False, False)
        dt.Columns.Add("HorasMes", GetType(Decimal))
        CreaColumnas(gvVariables, "TotalPagadoMes", "TotalPagadoMes", True, True, "", Color.FromArgb(&HFF, &HE3, &HDB), True, 0, 0, False, False, False, False)
        dt.Columns.Add("TotalPagadoMes", GetType(Decimal))
        CreaColumnas(gvVariables, "RentaExenta", "RentaExenta", True, True, "", Color.FromArgb(&HFF, &HE3, &HDB), True, 0, 0, False, False, False, False)
        dt.Columns.Add("RentaExenta", GetType(Decimal))
        CreaColumnas(gvVariables, "DescuentosPorNomina", "DescuentosPorNomina", True, True, "", Color.FromArgb(&HFF, &HE3, &HDB), True, 0, 0, False, False, False, False)
        dt.Columns.Add("DescuentosPorNomina", GetType(Decimal))
        CreaColumnas(gvVariables, "SalarioPromedioPeriodo", "SalarioPromedioPeriodo", True, True, "", Color.FromArgb(&HFF, &HE3, &HDB), True, 0, 0, False, False, False, False)
        dt.Columns.Add("SalarioPromedioPeriodo", GetType(Decimal))
        CreaColumnas(gvVariables, "SalarioPromedioMensualAnual", "SalarioPromedioMensualAnual", True, True, "", Color.FromArgb(&HFF, &HE3, &HDB), True, 0, 0, False, False, False, False)
        dt.Columns.Add("SalarioPromedioMensualAnual", GetType(Decimal))
        CreaColumnas(gvVariables, "SalarioPromedioMensualSemestral", "SalarioPromedioMensualSemestral", True, True, "", Color.FromArgb(&HFF, &HE3, &HDB), True, 0, 0, False, False, False, False)
        dt.Columns.Add("SalarioPromedioMensualSemestral", GetType(Decimal))

        'Variables Generales
        sql = "SELECT VG.NomVariable AS Nombre,MAX(VGD.Fecha) AS Fecha,VG.Sec AS Variable " &
              "FROM DetallesVariablesGenerales VGD INNER JOIN " &
              "VariablesGenerales VG ON VGD.Variable = vG.Sec " &
              "group by VG.NomVariable,VG.Sec"
        Dim Columnas As DataTable = SMT_AbrirTabla(ObjetoApiNomina, sql)
        If Columnas.Rows.Count > 0 Then
            For incre As Integer = 0 To Columnas.Rows.Count - 1
                Dim fecha As DateTime = CDate(Columnas.Rows(incre)("Fecha"))
                Dim fecha_s As String = fecha.ToString("dd/MM/yyyy")
                sql = "SELECT VG.NomVariable AS Nombre " &
"FROM DetallesVariablesGenerales VGD " &
"INNER JOIN VariablesGenerales VG ON VGD.Variable = vG.Sec " &
"WHERE Variable ='" + Columnas.Rows(incre)("Variable").ToString + "' AND VGD.Fecha = '" + fecha_s + "' "

                Dim ArmaColumnas As DataTable = SMT_AbrirTabla(ObjetoApiNomina, sql)
                If ArmaColumnas.Rows.Count > 0 Then
                    Dim ColorColumna As System.Drawing.Color = Color.FromArgb(&HB1, &HF3, &HDA)
                    dt.Columns.Add(ArmaColumnas.Rows(0)("Nombre").ToString, GetType(Decimal))
                    CreaColumnas(gvVariables, ArmaColumnas.Rows(0)("Nombre").ToString, ArmaColumnas.Rows(0)("Nombre").ToString, True, False, "", ColorColumna, True, 0, 0, False, False, False, False)
                End If
            Next
        End If

        'Variables Personales
        sql = "select NomVariable as Nombre from VariablesPersonales"
        Columnas = SMT_AbrirTabla(ObjetoApiNomina, sql)
        If Columnas.Rows.Count > 0 Then
            For incre As Integer = 0 To Columnas.Rows.Count - 1
                Dim sasf As System.Drawing.Color = Color.FromArgb(&HFF, &HE3, &HDB)
                dt.Columns.Add(Columnas.Rows(incre)("Nombre").ToString, GetType(Decimal))
                dt.Columns(incre).AllowDBNull = False
                CreaColumnas(gvVariables, Columnas.Rows(incre)("Nombre").ToString, Columnas.Rows(incre)("Nombre").ToString, True, True, "", sasf, True, 0, 0, False, False, False, False)
            Next
        End If

        'Bases
        sql = "select NomBase as Nombre from BasesConceptos"
        Columnas = SMT_AbrirTabla(ObjetoApiNomina, sql)
        If Columnas.Rows.Count > 0 Then
            For incre As Integer = 0 To Columnas.Rows.Count - 1
                Dim sasf As System.Drawing.Color = Color.FromArgb(&HFF, &HE3, &HDB)
                dt.Columns.Add(Columnas.Rows(incre)("Nombre").ToString, GetType(Decimal))
                dt.Columns(incre).AllowDBNull = False
                CreaColumnas(gvVariables, Columnas.Rows(incre)("Nombre").ToString, Columnas.Rows(incre)("Nombre").ToString, True, True, "", sasf, True, 0, 0, False, False, False, False)
            Next
        End If

        'Conceptos
        sql = "select NomConcepto as Nombre from ConceptosNomina"
        Columnas = SMT_AbrirTabla(ObjetoApiNomina, sql)
        If Columnas.Rows.Count > 0 Then
            For incre As Integer = 0 To Columnas.Rows.Count - 1
                Dim sasf As System.Drawing.Color = Color.FromArgb(&HFF, &HE3, &HDB)
                dt.Columns.Add(Columnas.Rows(incre)("Nombre").ToString, GetType(Decimal))
                dt.Columns(incre).AllowDBNull = False
                CreaColumnas(gvVariables, Columnas.Rows(incre)("Nombre").ToString, Columnas.Rows(incre)("Nombre").ToString, True, True, "", sasf, True, 0, 0, False, False, False, False)
            Next
        End If


        Try
            gcVariables.DataSource = dt
        Catch ex As Exception
            Dim asfds As String = ex.Data.ToString
        End Try
        CreaColumnas(gvVariables, "formu", "formu", True, True, "", Color.FromArgb(&HFF, &HE3, &HDB), True, 0, 0, False, False, False, False)
    End Sub

    Private Sub LimpiarCampos()
        txtTipoContrato.ValordelControl = ""
        TipoContrato = ""
        gcConfigTiposContratos.DataSource = Nothing
        LlenaGrilla("0")
        txtTipoContrato.Focus()
    End Sub
    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarCampos()
    End Sub

    Private Sub gvConfigTiposContratos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles gvConfigTiposContratos.KeyPress
        If gvConfigTiposContratos.FocusedColumn.Name = "Formula" Then
            If e.KeyChar = Convert.ToChar(13) Then
                gvVariables.Columns(gvVariables.Columns.Count - 1).UnboundExpression = gvConfigTiposContratos.GetFocusedRowCellValue("Formula").ToString
                gvVariables.ShowUnboundExpressionEditor(gvVariables.Columns(gvVariables.Columns.Count - 1))
                gvConfigTiposContratos.SetFocusedRowCellValue("Formula", gvVariables.Columns(gvVariables.Columns.Count - 1).UnboundExpression)

                If HDevExpre.MsgSamit(String.Format("Desea validar la formula?"), MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.OK Then
                    Dim classResize As New ClaseResize
                    classResize.Resizamodales(FrmValidaFormulas, 70, 25)
                    FrmValidaFormulas.Formula = gvConfigTiposContratos.GetFocusedRowCellValue("Formula").ToString
                    FrmValidaFormulas.Show()
                    FrmValidaFormulas.BringToFront()
                End If
            End If
        End If
    End Sub

    Private Sub FrmConfigTiposContratos_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        LimpiarCampos()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            btnGuardar.Focus()
            If gvConfigTiposContratos.RowCount > 0 Then
                Dim Tbla As DataTable = CType(gcConfigTiposContratos.DataSource, DataTable)
                If Tbla.Rows.Count > 0 Then
                    For incre As Integer = 0 To Tbla.Rows.Count - 1
                        If Not GuardaDatos(TipoContrato, Tbla.Rows(incre)("SecConcepto").ToString, Tbla.Rows(incre)("Formula").ToString, Tbla.Rows(incre)("BaseCalculo").ToString, CBool(Tbla.Rows(incre)("SeLiquida")), Tbla.Rows(incre)("CuentaContable").ToString) Then
                            Exit Sub
                        End If
                    Next
                    LlenaGrilla("0")
                    HDevExpre.mensajeExitoso("Datos guardados exitosamente!..")
                    LimpiarCampos()
                End If
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "btnGuardar_Click")
        End Try
    End Sub

    Private Function GuardaDatos(TipoContrato As String, Concepto As String, Formula As String, BaseCalculo As String, SeLiquida As Boolean, CuentaContable As String) As Boolean
        Try
            Dim GenSql As New SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL
            Dim SecConfig As String = ""
            GenSql.PasoConexionTabla(ObjetoApiNomina, "TiposContratos_ConceptosNomina")
            GenSql.PasoValores("TipoContrato", TipoContrato, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            GenSql.PasoValores("Concepto", Concepto, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            GenSql.PasoValores("Formula", Formula, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            GenSql.PasoValores("BaseCalculo", BaseCalculo, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            GenSql.PasoValores("CuentaContable", CuentaContable, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            If SeLiquida Then
                GenSql.PasoValores("SeLiquida", "1", SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            Else
                GenSql.PasoValores("SeLiquida", "0", SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            End If
            If GenSql.EjecutarComandoNET(SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.SQLGenera.Actualizacion, String.Format("TipoContrato={0} And Concepto={1}", TipoContrato, Concepto)) Then
                Return True
            Else : Return False
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "Guardando ConfigTiposContratos")
            Return False
        End Try
    End Function

    Private Sub txtTipoContrato_PresionaTecla(sender As Object, e As KeyEventArgs) Handles txtTipoContrato.PresionaTecla
        If e.KeyCode = 13 Then

            If txtTipoContrato.ValordelControl = "" Or txtTipoContrato.DescripciondelControl = "No Se Encontraron Registros" Or txtTipoContrato.DescripciondelControl = "" Then

            Else
                TipoContrato = txtTipoContrato.ValordelControl
                LlenaGrilla(txtTipoContrato.ValordelControl)
            End If
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub FrmConfigTiposContratos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If TipoContrato <> "" Then
            If HDevExpre.MsgSamit("Se están modificando datos, Seguro que desea cerrar el formulario?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Cancel Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub btnLimpiar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles btnSalir.KeyPress, btnLimpiar.KeyPress, btnGuardar.KeyPress
        HDevExpre.AtrasConScape(e)
    End Sub
End Class