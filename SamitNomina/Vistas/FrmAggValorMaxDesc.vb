Imports SamitCtlNet
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraEditors.Repository
Imports System.Data.SqlClient

Public Class FrmAggValorMaxDesc

    Dim FormularioAbierto As Boolean = False
    Dim HDevExpre As New HelperDevExpress
    Dim HNomina As New HelperNomina
    Public Property P_FormularioAbierto() As Boolean
        Get
            Return FormularioAbierto
        End Get
        Set(value As Boolean)
            FormularioAbierto = value
        End Set
    End Property
    'Private Sub AsignaScriptAcontroles()
    '    Try

    '        txtCargos.ConsultaSQL = String.Format("SELECT SecCargo AS Codigo,Denominacion As Descripcion FROM {0}..cargos")
    '        Dim Empresa As Integer = Datos.Seguridad.DatosDeLaEmpresa.NumEmpresa
    '        txtOficina.ConsultaSQL = String.Format("SELECT NumOficina AS Codigo,NomOficina As Descripcion FROM SEGURIDAD..Oficinas WHERE Estado='V' AND NumEmpresa={0}", Empresa.ToString)
    '    Catch ex As Exception
    '       HDevExpre.msgError(ex, ex.Message, "AsignaScriptAcontroles")
    '    End Try
    'End Sub

    Private Sub CreaGrillaValorMaxDescontar()
        Dim coloor As System.Drawing.Color = Color.White
        gvValMaxDescuento.Columns.Clear()
        HDevExpre.CreaColumnasG(gvValMaxDescuento, "SecPlantilla", "SecPlantilla", False, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 0, 0)
        HDevExpre.CreaColumnasG(gvValMaxDescuento, "NomPlantilla", "Plantilla", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 40, gcValMaxDescuento.Width)
        HDevExpre.CreaColumnasG(gvValMaxDescuento, "ValorMaxDescontar", "Maximo a Descontar Por Nomina", True, True, "", Color.FromArgb(&HCC, &HFF, &HCC), True, True, 60, gbxPrincipal.Width)
        gvValMaxDescuento.Appearance.HeaderPanel.Font = New Font("Trebuchet MS", 11.0!, FontStyle.Bold)
        gvValMaxDescuento.Appearance.ViewCaption.Options.UseTextOptions = True
        gvValMaxDescuento.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        gvValMaxDescuento.Appearance.ViewCaption.ForeColor = Color.Blue
        gvValMaxDescuento.ViewCaption = "Hola"


    End Sub

    Private Sub CreaColumnas(Grid As GridView, Nombre As String, Titulo As String, Visible As Boolean, Editar As Boolean, formula As String, colores As System.Drawing.Color, numerico As Boolean, Porcentaje_Width As Single, TamañoPadre As Single)
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
        Grid.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.CellFocus
        Grid.Columns.Add(gc)
    End Sub

    Private Sub AcomodaForm()
        Try
            btnGuardar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Guardar)
            btnSalir.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.SalirAtras)
            btnLimpiar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Limpiar)
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "AcomodaForm Agrega Valor Maximo a Descontar!")
        End Try
    End Sub

    Private Sub LlenaGrillaValorMaxDescontar(Parametros As String)
        Try
            Dim dt As New DataTable
            Dim sql As String = "Select SecPlantilla,NomPlantilla,ValorMaxDescontar From Plantillas "

            dt = SMT_AbrirTabla(ObjetoApiNomina, sql)
            gcValMaxDescuento.DataSource = dt

        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "LlenaGrillaNominasContratos")
        End Try
    End Sub

    Private Sub FrmAggValorMaxDescontar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'AsignaScriptAcontroles()
        CreaGrillaValorMaxDescontar()
        Creagrillahorizontal()
        AcomodaForm()
        LlenaGrillaValorMaxDescontar("")
        'txtOficina.Focus()
        'txtOficina.MensajedeAyuda = "Seleccione la oficina sobre la cual desea trabajar. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras, (F5,DER)=Buscar"
        'txtCargos.MensajedeAyuda = "Seleccione el cargo sobre el cual desea trabajar. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras, (F5,DER)=Buscar"
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarCampos()
    End Sub

    Private Sub LimpiarCampos()
        'txtOficina.ValordelControl = ""
        'txtCargos.ValordelControl = ""
        gcValMaxDescuento.DataSource = Nothing
        LlenaGrillaValorMaxDescontar("")
        ''txtOficina.Focus()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim Tbla As DataTable = CType(gcValMaxDescuento.DataSource, DataTable)
            If Tbla.Rows.Count > 0 Then
                For incre As Integer = 0 To Tbla.Rows.Count - 1
                    If Not GuardaDatos(Tbla.Rows(incre)("SecPlantilla").ToString, Tbla.Rows(incre)("ValorMaxDescontar").ToString) Then
                        Exit Sub
                    End If
                Next
                LlenaGrillaValorMaxDescontar("")
                HDevExpre.mensajeExitoso("Datos guardados exitosamente!..")
                'AsignaScriptAcontroles()
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "btnGuardar_Click")
        End Try
    End Sub

    Private Function GuardaDatos(Contrato As String, nomina As String) As Boolean
        Try
            Dim sql As String = "UPDATE Plantillas SET ValorMaxDescontar=@nom Where SecPlantilla=" + Contrato
            ' Dim cmd As SqlCommand = New SqlCommand(sql, ObjetoApiNomina)
            'cmd.Parameters.AddWithValue("@nom", nomina)
            'Dim cant As Integer = cmd.ExecuteNonQuery()
            'If cant > 0 Then

            '    Return True
            'Else
            '    Return False
            'End If

        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub Creagrillahorizontal()
        gvVariables.Columns.Clear()
        Dim sql As String
        Dim filas As New DataTable
        Dim NuevaFila As DataRow = filas.NewRow()
        Dim dt As DataTable = New DataTable
        Dim coloor As System.Drawing.Color = Color.White

        'Variables predeterminadas
        CreaColumnas(gvVariables, "Asignacion", "Asignacion", True, True, "", Color.FromArgb(&HFF, &HE3, &HDB), True, 0, 0)
        dt.Columns.Add("Asignacion", GetType(Decimal))
        CreaColumnas(gvVariables, "HorasMes", "HorasMes", True, True, "", Color.FromArgb(&HFF, &HE3, &HDB), True, 0, 0)
        dt.Columns.Add("HorasMes", GetType(Decimal))
        CreaColumnas(gvVariables, "TotalPagadoMes", "TotalPagadoMes", True, True, "", Color.FromArgb(&HFF, &HE3, &HDB), True, 0, 0)
        dt.Columns.Add("TotalPagadoMes", GetType(Decimal))
        CreaColumnas(gvVariables, "RentaExenta", "RentaExenta", True, True, "", Color.FromArgb(&HFF, &HE3, &HDB), True, 0, 0)
        dt.Columns.Add("RentaExenta", GetType(Decimal))
        CreaColumnas(gvVariables, "DescuentosPorNomina", "DescuentosPorNomina", True, True, "", Color.FromArgb(&HFF, &HE3, &HDB), True, 0, 0)
        dt.Columns.Add("DescuentosPorNomina", GetType(Decimal))
        CreaColumnas(gvVariables, "NetoAPagar", "NetoAPagar", True, True, "", Color.FromArgb(&HFF, &HE3, &HDB), True, 0, 0)
        dt.Columns.Add("NetoAPagar", GetType(Decimal))
        CreaColumnas(gvVariables, "SalarioPromedioPeriodo", "SalarioPromedioPeriodo", True, True, "", Color.FromArgb(&HFF, &HE3, &HDB), True, 0, 0)
        dt.Columns.Add("SalarioPromedioPeriodo", GetType(Decimal))
        CreaColumnas(gvVariables, "SalarioPromedioMensualAnual", "SalarioPromedioMensualAnual", True, True, "", Color.FromArgb(&HFF, &HE3, &HDB), True, 0, 0)
        dt.Columns.Add("SalarioPromedioMensualAnual", GetType(Decimal))
        CreaColumnas(gvVariables, "SalarioPromedioMensualSemestral", "SalarioPromedioMensualSemestral", True, True, "", Color.FromArgb(&HFF, &HE3, &HDB), True, 0, 0)
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
                    CreaColumnas(gvVariables, ArmaColumnas.Rows(0)("Nombre").ToString, ArmaColumnas.Rows(0)("Nombre").ToString, True, False, "", ColorColumna, True, 0, 0)
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
                CreaColumnas(gvVariables, Columnas.Rows(incre)("Nombre").ToString, Columnas.Rows(incre)("Nombre").ToString, True, True, "", sasf, True, 0, 0)
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
                CreaColumnas(gvVariables, Columnas.Rows(incre)("Nombre").ToString, Columnas.Rows(incre)("Nombre").ToString, True, True, "", sasf, True, 0, 0)
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
                CreaColumnas(gvVariables, Columnas.Rows(incre)("Nombre").ToString, Columnas.Rows(incre)("Nombre").ToString, True, True, "", sasf, True, 0, 0)
            Next
        End If


        Try
            gcVariables.DataSource = dt
        Catch ex As Exception
            Dim asfds As String = ex.Data.ToString
        End Try
        CreaColumnas(gvVariables, "formu", "formu", True, True, "", Color.FromArgb(&HFF, &HE3, &HDB), True, 0, 0)
    End Sub

    Private Sub FrmNominasContratos_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        LimpiarCampos()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs)
        'Dim sql As String = ""
        'If txtOficina.ValordelControl <> "" And txtOficina.DescripciondelControl <> "No Se Encontraron Registros" And txtOficina.DescripciondelControl <> "" And txtCargos.ValordelControl <> "" And txtCargos.DescripciondelControl <> "No Se Encontraron Registros" And txtCargos.DescripciondelControl <> "" Then
        '    sql = "Where C.Oficina=" + txtOficina.ValordelControl + " And CC.Cargo=" + txtCargos.ValordelControl
        'ElseIf txtOficina.ValordelControl <> "" And txtOficina.DescripciondelControl <> "No Se Encontraron Registros" And txtOficina.DescripciondelControl <> "" Then
        '    sql = "Where C.Oficina=" + txtOficina.ValordelControl
        'ElseIf txtCargos.ValordelControl <> "" And txtCargos.DescripciondelControl <> "No Se Encontraron Registros" And txtCargos.DescripciondelControl <> "" Then
        '    sql = "Where CC.Cargo=" + txtCargos.ValordelControl
        'Else
        '   HDevExpre.MensagedeError("Parametros de busqueda incorrectos!..")
        'End If
        'LlenaGrillaValorMaxDescontar(sql)
    End Sub

    Private Sub gvValMaxDescuento_ShownEditor(sender As Object, e As EventArgs) Handles gvValMaxDescuento.ShownEditor
        gvVariables.Columns(gvVariables.Columns.Count - 1).UnboundExpression = gvValMaxDescuento.GetFocusedRowCellValue("ValorMaxDescontar").ToString
        gvVariables.ShowUnboundExpressionEditor(gvVariables.Columns(gvVariables.Columns.Count - 1))
        gvValMaxDescuento.SetFocusedRowCellValue("ValorMaxDescontar", gvVariables.Columns(gvVariables.Columns.Count - 1).UnboundExpression)

        If HDevExpre.MsgSamit(String.Format("Desea validar la formula?"), MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.OK Then
            Dim classResize As New ClaseResize
            classResize.Resizamodales(FrmValidaFormulas, 70, 25)
            FrmValidaFormulas.Formula = gvValMaxDescuento.GetFocusedRowCellValue("ValorMaxDescontar").ToString
            FrmValidaFormulas.Show()
            FrmValidaFormulas.BringToFront()
        End If

    End Sub
End Class