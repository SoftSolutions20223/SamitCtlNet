Imports Newtonsoft.Json.Linq
Imports SamitCtlNet
Imports SamitNominaLogic

Public Class FrmAggDesDetallesVar
    Public CodVar As String
    Public CantHoras As Integer
    Public TextCaption As String
    Dim Sec_Detalle As String = ""
    Dim secReg As Integer = 0
    Public Tipo As String = ""
    Dim HDevExpre As New HelperDevExpress
    Dim HNomina As New HelperNomina
    Dim DetallesVar As New DescripVarPer
    Private Sub FrmAggDesDetallesVar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Tipo = "HoraFecha" Then
            dteFechaIni.Properties.EditFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
            dteFechaIni.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            dteFechaIni.Properties.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
            dteFechaIni.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            dteFechaFin.Properties.EditFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
            dteFechaFin.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            dteFechaFin.Properties.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
            dteFechaFin.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            txtTipoIncapacidad.Visible = False
        ElseIf Tipo = "Incapacidad" Then
            dteFechaIni.Properties.EditFormat.FormatString = "dd/MM/yyyy"
            dteFechaIni.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            dteFechaIni.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
            dteFechaIni.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            dteFechaFin.Properties.EditFormat.FormatString = "dd/MM/yyyy"
            dteFechaFin.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            dteFechaFin.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
            dteFechaFin.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            txtTipoIncapacidad.Visible = True
            txtTipoIncapacidad.ConsultaSQL = String.Format("Select '1' As Codigo, 'Común' As Descripcion Union 
Select '2' As Codigo, 'Profesional' As Descripcion Union 
Select '3' As Codigo, 'Laboral' As Descripcion")
        Else
            dteFechaIni.Properties.EditFormat.FormatString = "dd/MM/yyyy"
            dteFechaIni.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            dteFechaIni.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
            dteFechaIni.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            dteFechaFin.Properties.EditFormat.FormatString = "dd/MM/yyyy"
            dteFechaFin.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            dteFechaFin.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
            dteFechaFin.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            txtTipoIncapacidad.Visible = False
        End If
        btnGuardar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Guardar)
        btnEliminar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Eliminar)
        btnSalir.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.SalirAtras)
        btnLimpiar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Limpiar)
        CreaGrilla()
        LlenaGrillaDetalles()
    End Sub

    Private Sub LlenaGrillaDetalles()
        Try
            Dim sql As String = "SELECT * from DescripVarPer where CodVarP=" + CodVar.ToString
            Dim dt = SMT_AbrirTabla(ObjetoApiNomina, sql)
            If dt.Rows.Count > 0 Then
                gcDetalles.DataSource = dt
            Else
                gcDetalles.DataSource = Nothing
            End If

        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "LlenaGrillaDetalles")
        End Try
    End Sub

    Private Function ValidaCampos() As Boolean
        Dim fecha1 As DateTime = dteFechaIni.DateTime
        Dim fecha2 As DateTime = dteFechaFin.DateTime
        Dim CantHorasR = fecha2 - fecha1
        Dim cantDiasR = DateDiff(DateInterval.Day, CDate(fecha1), fecha2) + 1
        Dim txtcatdias = CInt(txtCantidad.ValordelControl)
        Dim txtcanthoras As TimeSpan = New TimeSpan(CInt(txtCantidad.ValordelControl), 0, 0)
        If Tipo = "Incapacidad" Then
            If txtTipoIncapacidad.ValordelControl = "" Or txtTipoIncapacidad.DescripciondelControl = "No Se Encontraron Registros" Or txtTipoIncapacidad.DescripciondelControl = "" Then
                HDevExpre.MensagedeError("El campo Empleado no puede estar vacío o contener valores invalidos!..")
                txtTipoIncapacidad.Focus()
                Return False
            End If
        End If
        If Tipo = "HoraFecha" Then
            If txtcanthoras > CantHorasR Or txtcanthoras < CantHorasR Then
                HDevExpre.MensagedeError("La cantidad no coincide con la diferencia de horas entre las dos fechas!..")
                txtCantidad.Focus()
                Return False
            End If
        Else
            If txtcatdias > cantDiasR Or txtcatdias < cantDiasR Then
                HDevExpre.MensagedeError("La cantidad no coincide con la diferencia de dias entre las dos fechas!..")
                txtCantidad.Focus()
                Return False
            End If
        End If
        If dteFechaIni.Text = "" Then
            HDevExpre.MensagedeError("El campo Fecha-Hora Inicio no puede estar vacío!..")
            dteFechaIni.Focus()
            Return False
        ElseIf dteFechaFin.Text = "" Then
            HDevExpre.MensagedeError("El campo Fecha-Hora Fin no puede estar vacío!..")
            dteFechaFin.Focus()
            Return False
        ElseIf txtCantidad.ValordelControl = "" Or txtCantidad.ValordelControl = "0" Then
            HDevExpre.MensagedeError("El campo cantidad no puede estar vacío o ser menor que 1!..")
            txtCantidad.Focus()
            Return False
        ElseIf dteFechaFin.DateTime < dteFechaIni.DateTime Then
            HDevExpre.MensagedeError("La fecha-hora de inicio no puede ser superior a la fecha-hora de finalización!..")
            dteFechaFin.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub CreaGrilla()
        Try
            gvDetalles.Columns.Clear()
            Dim color As System.Drawing.Color = Color.FromArgb(&HCC, &HFF, &HCC)
            If Tipo = "Incapacidad" Then
                HDevExpre.CreaColumnasG(gvDetalles, "NomTipo", "Tipo", True, False, "", Color.FromArgb(204, 255, 204), False, False, 25, gcDetalles.Width, DevExpress.Utils.HorzAlignment.Near, False, "", False, Nothing, False, "dd/MM/yyyy", "#,##0.####", "#,##0.##", False, color, color, False, Nothing, True, False)
                HDevExpre.CreaColumnasG(gvDetalles, "FechaHoraInicio", "Fecha Inicio", True, False, "", Color.FromArgb(204, 255, 204), False, False, 25, gcDetalles.Width, DevExpress.Utils.HorzAlignment.Near, False, "", False, Nothing, True, "dd/MM/yyyy", "#,##0.####", "#,##0.##", False, Color.Blue, Color.White, True, Nothing, True, False)
                HDevExpre.CreaColumnasG(gvDetalles, "FechaHoraFin", "Fecha Fin", True, False, "", Color.FromArgb(204, 255, 204), False, False, 25, gcDetalles.Width, DevExpress.Utils.HorzAlignment.Near, False, "", False, Nothing, True, "dd/MM/yyyy", "#,##0.####", "#,##0.##", False, Color.Blue, Color.White, True, Nothing, True, False)
                HDevExpre.CreaColumnasG(gvDetalles, "Cantidad", "Cantidad", True, False, "", Color.FromArgb(204, 255, 204), True, False, 20, gcDetalles.Width, DevExpress.Utils.HorzAlignment.Near, False, "", False, Nothing, False, "dd/MM/yyyy", "#,##0.####", "#,##0.##", False, color, color, False, Nothing, True, False)
            End If
            If Tipo = "Otra" Then
                HDevExpre.CreaColumnasG(gvDetalles, "FechaHoraInicio", "Fecha Inicio", True, False, "", Color.FromArgb(204, 255, 204), False, False, 40, gcDetalles.Width, DevExpress.Utils.HorzAlignment.Near, False, "", False, Nothing, True, "dd/MM/yyyy", "#,##0.####", "#,##0.##", False, Color.Blue, Color.White, True, Nothing, True, False)
                HDevExpre.CreaColumnasG(gvDetalles, "FechaHoraFin", "Fecha Fin", True, False, "", Color.FromArgb(204, 255, 204), False, False, 40, gcDetalles.Width, DevExpress.Utils.HorzAlignment.Near, False, "", False, Nothing, True, "dd/MM/yyyy", "#,##0.####", "#,##0.##", False, Color.Blue, Color.White, True, Nothing, True, False)
                HDevExpre.CreaColumnasG(gvDetalles, "Cantidad", "Cantidad", True, False, "", Color.FromArgb(204, 255, 204), True, False, 20, gcDetalles.Width, DevExpress.Utils.HorzAlignment.Near, False, "", False, Nothing, False, "dd/MM/yyyy", "#,##0.####", "#,##0.##", False, color, color, False, Nothing, True, False)
            End If
            If Tipo = "HoraFecha" Then
                HDevExpre.CreaColumnasG(gvDetalles, "FechaHoraInicio", "Fecha-Hora Inicio", True, False, "", Color.FromArgb(204, 255, 204), False, False, 40, gcDetalles.Width, DevExpress.Utils.HorzAlignment.Near, False, "", False, Nothing, True, "dd/MM/yyyy HH:mm:ss", "#,##0.####", "#,##0.##", False, Color.Blue, Color.White, True, Nothing, True, False)
                HDevExpre.CreaColumnasG(gvDetalles, "FechaHoraFin", "Fecha-Hora Fin", True, False, "", Color.FromArgb(204, 255, 204), False, False, 40, gcDetalles.Width, DevExpress.Utils.HorzAlignment.Near, False, "", False, Nothing, True, "dd/MM/yyyy HH:mm:ss", "#,##0.####", "#,##0.##", False, Color.Blue, Color.White, True, Nothing, True, False)
                HDevExpre.CreaColumnasG(gvDetalles, "Cantidad", "Cantidad", True, False, "", Color.FromArgb(204, 255, 204), True, False, 20, gcDetalles.Width, DevExpress.Utils.HorzAlignment.Near, False, "", False, Nothing, False, "dd/MM/yyyy", "#,##0.####", "#,##0.##", False, color, color, False, Nothing, True, False)
            End If
            gvDetalles.ViewCaption = TextCaption
            gvDetalles.OptionsView.ShowViewCaption = True
            Dim dFont = gvDetalles.Appearance.ViewCaption.Font
            gvDetalles.Appearance.ViewCaption.Font = New Font(dFont.FontFamily, 12)
            Dim color2 As System.Drawing.Color = Color.Blue
            gvDetalles.Appearance.ViewCaption.BackColor = color2
            gvDetalles.OptionsView.ShowFooter = True
            gvDetalles.Appearance.HeaderPanel.Font = New Font("Trebuchet MS", 11.0!, FontStyle.Bold)
            gvDetalles.Columns(2).Summary.Add(DevExpress.Data.SummaryItemType.Count, "", "{0}")
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "Crea Grilla")
        End Try
    End Sub
    Private Function GuardaDatos(fechaini As DateTime, fechafin As DateTime, cantidad As String, TipoDes As String, NomTipo As String) As Boolean
        Try
            Dim GenSql As New SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL
            GenSql.PasoConexionTabla(ObjetoApiNomina, "DescripVarPer")
            GenSql.PasoValores("FechaHoraInicio", fechaini.ToString("dd/MM/yyyy HH:mm:ss"), SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            GenSql.PasoValores("FechaHoraFin", fechafin.ToString("dd/MM/yyyy HH:mm:ss"), SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            GenSql.PasoValores("Cantidad", cantidad, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            GenSql.PasoValores("CodVarP", CodVar, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            If Tipo = "Incapacidad" Then
                GenSql.PasoValores("TipoDesc", TipoDes, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
                GenSql.PasoValores("NomTipo", NomTipo, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            End If

            Dim SecDetalles = SMT_AbrirTabla(ObjetoApiNomina, "SELECT ISNULL( MAX (Sec),0)+1 AS Codigo FROM  DescripVarPer").Rows(0)(0).ToString
            GenSql.PasoValores("Sec", SecDetalles, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            If GenSql.EjecutarComandoNET(SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.SQLGenera.Insercion, "") Then
                Return True
            Else : Return False
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "Guardando Detalles")
            Return False
        End Try
    End Function
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If ValidaCampos() Then
            If GuardaDatos(Convert.ToDateTime(dteFechaIni.EditValue), Convert.ToDateTime(dteFechaFin.EditValue), txtCantidad.ValordelControl, txtTipoIncapacidad.ValordelControl, txtTipoIncapacidad.DescripciondelControl) Then
                HDevExpre.mensajeExitoso("Información Guardada exitosamente")
                LlenaGrillaDetalles()
                txtTipoIncapacidad.ValordelControl = ""
                txtCantidad.ValordelControl = "0"
                dteFechaFin.Text = ""
                dteFechaIni.Text = ""
                Sec_Detalle = ""
            End If
        End If
    End Sub

    Private Sub FrmAggDesDetallesVar_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        If gvDetalles.RowCount > 0 Then
            Dim cant As Integer = 0
            Dim dt As DataTable = CType(gcDetalles.DataSource, DataTable)
            For i As Integer = 0 To dt.Rows.Count - 1
                cant = cant + CInt(dt.Rows(i)("Cantidad").ToString)
            Next
            CantHoras = cant
        Else
            CantHoras = 0
        End If
    End Sub

    Private Sub gvDetalles_DoubleClick(sender As Object, e As EventArgs) Handles gvDetalles.Click
        Try
            If gvDetalles.RowCount > 0 Then
                Sec_Detalle = gvDetalles.GetFocusedRowCellValue("Sec").ToString
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "Cargar Detalle")
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If gvDetalles.RowCount <= 0 Then
                HDevExpre.MensagedeError("No hay detalles que eliminar!..")
            ElseIf Sec_Detalle = "" Then
                HDevExpre.MensagedeError("No ha seleccionado ningun detalle!..")
            Else
                SMT_EjcutarComandoSql(ObjetoApiNomina, "DELETE FROM DescripVarPer WHERE Sec=" + Sec_Detalle, 0)

                Sec_Detalle = ""
                LlenaGrillaDetalles()
                HDevExpre.mensajeExitoso("Detalle eliminado!..")
            End If
        Catch ex As Exception
            HDevExpre.MensagedeError("No ha sido posible eliminar este detalle!..")
        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtCantidad.ValordelControl = "0"
        dteFechaFin.Text = ""
        dteFechaIni.Text = ""
        Sec_Detalle = ""
    End Sub

    Private Sub AvanzarAtrasControl_KeyDown(sender As Object, e As KeyEventArgs) Handles dteFechaIni.KeyDown, dteFechaFin.KeyDown

    End Sub

    Private Sub dteFechaIniC_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dteFechaIni.KeyPress, dteFechaFin.KeyPress
        HDevExpre.AvanzaConEnter(e)
    End Sub

    Private Sub dteFechaIni_Enter(sender As Object, e As EventArgs) Handles dteFechaIni.Enter
        HDevExpre.EntraControlDateEditDEV(dteFechaIni, lblFechaIni)
        FrmPrincipal.MensajeDeAyuda.Caption = "Digite la fecha-hora del inicio. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
    End Sub

    Private Sub dteFechaIni_Leave(sender As Object, e As EventArgs) Handles dteFechaIni.Leave
        HDevExpre.SaleControlDateEditDEV(dteFechaIni, lblFechaIni)
        FrmPrincipal.MensajeDeAyuda.Caption = ""
    End Sub

    Private Sub dteFechaFin_Enter(sender As Object, e As EventArgs) Handles dteFechaFin.Enter
        HDevExpre.EntraControlDateEditDEV(dteFechaFin, lblFechaFin)
        FrmPrincipal.MensajeDeAyuda.Caption = "Digite la fecha-hora de finalización. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
    End Sub

    Private Sub dteFechaFin_Leave(sender As Object, e As EventArgs) Handles dteFechaFin.Leave
        HDevExpre.SaleControlDateEditDEV(dteFechaFin, lblFechaFin)
    End Sub


End Class