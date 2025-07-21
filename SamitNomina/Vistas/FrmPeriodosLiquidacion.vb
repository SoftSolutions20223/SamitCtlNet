Imports SamitCtlNet
Imports DevExpress.Utils
Imports System.ComponentModel
Imports DevExpress.XtraEditors.Controls
Imports SamitNominaLogic
Imports Newtonsoft.Json.Linq

Public Class FrmPeriodosLiquidacion
    Dim dt As DataTable
    Dim Datos As New SamitCtlNet.SamitCtlNet
    Dim DatosSeg As New SamitCtlNet.Clseguridad
    Dim Buscando As Boolean = False
    Dim secReg As Integer = 0
    Dim SecNominaLiqui As String = ""
    Dim Actualizando As Boolean = False
    Dim FormularioAbierto As Boolean = False
    Dim HDevExpre As New HelperDevExpress
    Dim HNomina As New HelperNomina
    Dim PeriodoLiquidacion As New PeriodosLiquidacion
    Public Property P_FormularioAbierto() As Boolean
        Get
            Return FormularioAbierto
        End Get
        Set(value As Boolean)
            FormularioAbierto = value
        End Set
    End Property

#Region "Eventos Controles"
    Private Sub txtBusqueda_EditValueChanged(sender As Object, e As EventArgs) Handles txtBusqueda.EditValueChanged
        Dim buscando As Boolean = Me.Buscando
        If buscando Then
            FiltrarDatos(txtBusqueda.Text)
        End If
    End Sub

    Private Sub AsignaScriptAcontroles()
        Try
            txtNomina.ConsultaSQL = String.Format("SELECT Sec AS Codigo,NomNomina As Descripcion FROM  Nominas")
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "AsignaScriptAcontroles")
        End Try
    End Sub

    Private Sub txtBusqueda_Enter(sender As Object, e As EventArgs) Handles txtBusqueda.Enter
        If Not Buscando Then
            txtBusqueda.Text = ""
            Buscando = True
            txtBuscando()
        End If
    End Sub

    Private Sub txtBusqueda_Leave(sender As Object, e As EventArgs) Handles txtBusqueda.Leave
        If txtBusqueda.Text = "" Then
            Buscando = False
            txtNoBuscando()
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub


    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarCampos()
        txtNomina.ValordelControl = ""
    End Sub

    Public Function ValidarCampos() As Boolean
        If txtNomina.ValordelControl = "" Then
            HDevExpre.MensagedeError("El campo Nomina no puede estar vacío!..")
            txtNomina.Focus()
            Return False
        ElseIf dteAño.ValordelControl = "" Then
            HDevExpre.MensagedeError("El campo Año no puede estar vacío!..")
            txtNomina.Focus()
            Return False
        ElseIf dteFechaIni.Text = "" Then
            HDevExpre.MensagedeError("El campo fecha inicio no puede estar vacío!..")
            dteFechaIni.Focus()
            Return False
        ElseIf dteFechaFin.Text = "" Then
            HDevExpre.MensagedeError("El campo fecha fin no puede estar vacío!..")
            dteFechaFin.Focus()
            Return False
        ElseIf dteFechaFin.DateTime < dteFechaIni.DateTime Then
            HDevExpre.MensagedeError("La fecha de inicio no puede ser superior a la fecha de finalización!..")
            dteFechaFin.Focus()
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Not Actualizando Then Exit Sub
        If ValidarCampos() Then
            Dim sec As Integer = 0
            If Actualizando Then sec = secReg
            If GuardaDatos(sec) Then
                HDevExpre.mensajeExitoso("Información Guardada exitosamente")
                Actualizando = False
                dteFechaIni.Text = ""
                dteFechaFin.Text = ""
                dteFechaIni.Enabled = False
                dteFechaFin.Enabled = False
                btnConsultar_Click(sender, e)
                gvPeriodos.Focus()
            Else
                HDevExpre.MensagedeError("Error al guardar los datos!")
            End If
        Else
            txtNomina.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub gvNominas_DoubleClick(sender As Object, e As EventArgs) Handles gvPeriodos.DoubleClick
        CargarDatos()
    End Sub

    Private Sub gvNominas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles gvPeriodos.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            CargarDatos()
        End If
    End Sub

    Private Sub FrmAggNominas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = ChrW(Keys.Escape) Then
            Me.Close()
        End If
    End Sub

#End Region



#Region "Procedimientos y Funciones"
    Private Sub AcomodaForm()
        Try
            btnGuardar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Guardar)
            btnSalir.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.SalirAtras)
            btnLimpiar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Limpiar)
            btnConsultar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.ConsultarEmpleado)
            'dteAño.EditValue = CUShort(CDate(FechaSys.ToString).Year).ToString
            dteAño.ValordelControl = CUShort(CDate(Datos.Smt_FechaDelServidor).Year).ToString
            dteFechaIni.Enabled = False
            dteFechaFin.Enabled = False
            dteFechaIni.EditValue = Datos.Smt_FechaDeTrabajo
            dteFechaFin.EditValue = Datos.Smt_FechaDeTrabajo
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "AcomodaForm Agrega NominaLiquida!")
        End Try
    End Sub
    Private Sub CreaGrilla()
        Try
            gvPeriodos.Columns.Clear()
            HDevExpre.CreaColumnasG(gvPeriodos, "Sec", "Sec", False, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 0, 0)
            HDevExpre.CreaColumnasG(gvPeriodos, "Descripcion", "Descripcion", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 40, gbxPrincipal.Width)
            HDevExpre.CreaColumnasG(gvPeriodos, "FechaInicio", "Fecha Inicio", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 17, gbxPrincipal.Width)
            HDevExpre.CreaColumnasG(gvPeriodos, "FechaFin", "Fecha Fin", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 17, gbxPrincipal.Width)
            HDevExpre.CreaColumnasG(gvPeriodos, "Estado", "Estado", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 7, gbxPrincipal.Width)
            HDevExpre.CreaColumnasG(gvPeriodos, "Nomina", "Nomina", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 10, gbxPrincipal.Width)
            HDevExpre.CreaColumnasG(gvPeriodos, "Año", "Año", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 7, gbxPrincipal.Width)
            gvPeriodos.OptionsView.ShowFooter = True
            gvPeriodos.Appearance.HeaderPanel.Font = New Font("Trebuchet MS", 11.0!, FontStyle.Bold)
            gvPeriodos.Columns(5).Summary.Add(DevExpress.Data.SummaryItemType.Count, "", "{0}  Registros")
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "Crea Grilla NominasLiquida")
        End Try
    End Sub

    Private Sub LlenaGrillaNominaLiquida()
        Try
            If txtNomina.DescripciondelControl <> "No Se Encontraron Registros" And txtNomina.DescripciondelControl <> "" And txtNomina.ValordelControl <> "" Then
                'Dim sql As String = "SELECT * FROM NominaLiquida Where Nomina=" + txtNomina.ValordelControl
                'dt = SMT_AbrirTabla(ObjetoApiNomina, sql)
                'gcPeriodos.DataSource = dt
            Else
                LimpiarCampos()
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "LlenaGrillaNominaLiquida")
        End Try
    End Sub

    Private Sub txtNoBuscando()
        txtBusqueda.Text = "Digite cualquier parametro de Busqueda"
        txtBusqueda.Font = New Font("Trebuchet MS", 10.25F, FontStyle.Italic)
        txtBusqueda.BackColor = Color.LemonChiffon
        txtBusqueda.ForeColor = Color.Gray
        txtBusqueda.BorderStyle = BorderStyles.Simple
    End Sub
    Private Sub txtBuscando()
        txtBusqueda.Font = New Font("Trebuchet MS", 10.25F, FontStyle.Bold)
        txtBusqueda.BackColor = ColorTranslator.FromHtml("#B9FFF9")
        txtBusqueda.ForeColor = Color.DarkRed
    End Sub
    Private Sub FiltrarDatos(filtro As String)
        'Inicio de la tarea en segundo plano
        Dim SubTask As BackgroundWorker = New BackgroundWorker()
        AddHandler SubTask.DoWork, AddressOf ProcesFiltrarDatos
        AddHandler SubTask.RunWorkerCompleted, AddressOf MostrarResultadoFiltro
        SubTask.RunWorkerAsync(filtro)
        'Fin Tarea segundo plano
    End Sub
    Private Sub ProcesFiltrarDatos(sender As Object, e As DoWorkEventArgs)
        Dim dv As New DataView(dt)
        dv.RowFilter = Grilla.CrearFiltro(dt, e.Argument.ToString)
        e.Result = dv
    End Sub
    Private Sub MostrarResultadoFiltro(sender As Object, e As RunWorkerCompletedEventArgs)
        Dim dv As DataView = CType(e.Result, DataView)
        gcPeriodos.DataSource = dv
    End Sub

    Private Sub LimpiarCampos()
        SecNominaLiqui = ""
        dteFechaIni.Text = ""
        dteFechaFin.Text = ""
        secReg = 0
        dteFechaIni.Enabled = False
        dteFechaFin.Enabled = False
        dteAño.ValordelControl = CUShort(CDate(DatosSeg.FechadelServidor.ToString).Year).ToString
        Buscando = False
        txtNoBuscando()
        gcPeriodos.DataSource = dt
        txtNomina.Focus()
    End Sub
    Private Function GuardaDatos(Sec As Integer) As Boolean
        Try
            If SecNominaLiqui <> "" Then
                Sec = CInt(SecNominaLiqui)
            End If
            Dim Descrip = gvPeriodos.GetFocusedRowCellValue("Descripcion").ToString
            Dim str = Descrip.Split("(")
            Dim FechaI As String = dteFechaIni.DateTime.ToString("dd/MM/yyyy")
            Dim FechaF As String = dteFechaFin.DateTime.ToString("dd/MM/yyyy")
            Descrip = str(0) + "(" + FechaI + " - " + FechaF + ")"
            PeriodoLiquidacion = New PeriodosLiquidacion
            PeriodoLiquidacion.Nomina = txtNomina.ValordelControl()
            PeriodoLiquidacion.Sec = Sec
            PeriodoLiquidacion.FechaInicio = dteFechaIni.Text
            PeriodoLiquidacion.FechaFin = dteFechaFin.Text
            PeriodoLiquidacion.Descripcion = Descrip
            Dim RegPeriodoLiquidacion As New ServicePeriodosLiquidacion
            Dim registro As DynamicUpsertResponseDto
            If RegPeriodoLiquidacion.ValidarCampos(PeriodoLiquidacion) Then
                registro = RegPeriodoLiquidacion.UpsertPeriodoLiquidacion(PeriodoLiquidacion)
            End If
            If registro.ErrorCount < 1 Then
                Return True
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "Guardando NominasLiquida")
            Return False
        End Try
    End Function
    Private Sub CargarDatos()
        Try
            SecNominaLiqui = gvPeriodos.GetFocusedRowCellValue("Sec").ToString
            dteAño.ValordelControl = gvPeriodos.GetFocusedRowCellValue("Año").ToString
            dteFechaIni.EditValue = CDate(gvPeriodos.GetFocusedRowCellValue("FechaInicio"))
            dteFechaFin.EditValue = CDate(gvPeriodos.GetFocusedRowCellValue("FechaFin"))
            Actualizando = True
            dteFechaIni.Enabled = True
            dteFechaFin.Enabled = True
            dteFechaIni.Focus()
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "Cargar datos NominasLiquida")
        End Try
    End Sub

#End Region

    Private Sub FrmAggPeriodosLiquidacion_Load(sender As Object, e As EventArgs) Handles Me.Load
        AcomodaForm()
        txtNoBuscando()
        CreaGrilla()
        AsignaScriptAcontroles()
        txtNomina.Focus()
        txtNomina.MensajedeAyuda = "Seleccione la nómina de la cual desea obtener los periodos.  (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras, (F5,DER)=Buscar"
    End Sub
    Private Sub FrmAggPeriodosLiquidacion_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Buscando = False
        txtNoBuscando()
        LimpiarCampos()
    End Sub

    Private Sub txtNomina_Leave(sender As Object, e As EventArgs) Handles txtNomina.Leave
        LlenaGrillaNominaLiquida()
    End Sub

    Private Sub dteFechaIni_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dteFechaIni.KeyPress, dteFechaFin.KeyPress
        HDevExpre.AvanzaConEnter(e)
    End Sub

    Private Sub dteFechaIni_Enter(sender As Object, e As EventArgs) Handles dteFechaIni.Enter
        HDevExpre.EntraControlDateEditDEV(dteFechaIni, lblFechaIni)
        FrmPrincipal.MensajeDeAyuda.Caption = "Digite la fecha desde la cual inicia el periodo de liquidación. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
    End Sub

    Private Sub dteFechaIni_Leave(sender As Object, e As EventArgs) Handles dteFechaIni.Leave
        HDevExpre.SaleControlDateEditDEV(dteFechaIni, lblFechaIni)
        FrmPrincipal.MensajeDeAyuda.Caption = ""
    End Sub

    Private Sub dteFechaFin_Enter(sender As Object, e As EventArgs) Handles dteFechaFin.Enter
        HDevExpre.EntraControlDateEditDEV(dteFechaFin, lblFechaFin)
        FrmPrincipal.MensajeDeAyuda.Caption = "Digite la fecha hasta cuando finaliza el periodo de liquidación. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
    End Sub

    Private Sub dteFechaFin_Leave(sender As Object, e As EventArgs) Handles dteFechaFin.Leave
        HDevExpre.SaleControlDateEditDEV(dteFechaFin, lblFechaFin)
        btnGuardar.Focus()
        FrmPrincipal.MensajeDeAyuda.Caption = ""
    End Sub

    'Private Sub grbEstado_Enter(sender As Object, e As EventArgs)
    '    EntraControlRadioGroup(grbEstado, lblEstado)
    'End Sub

    'Private Sub grbEstado_Leave(sender As Object, e As EventArgs)
    '    SaleControlRadioGroup(grbEstado, lblEstado)
    'End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Try
            Actualizando = False
            If Not ValidaCamposBusqueda() Then Exit Sub
            Dim sql As String = String.Format("SELECT * FROM PeriodosLiquidacion WHERE Nomina={0} AND Año = {1}",
                                              txtNomina.ValordelControl, dteAño.ValordelControl)
            Dim dtPeridos As DataTable = SMT_AbrirTabla(ObjetoApiNomina, sql)
            If dtPeridos.Rows.Count = 0 Then
                HDevExpre.mensajeExitoso("No se encontraron registros :(")
                Exit Sub
            End If
            gcPeriodos.DataSource = dtPeridos
            dteFechaIni.Enabled = False
            dteFechaFin.Enabled = False
            dteFechaIni.Text = ""
            dteFechaFin.Text = ""
        Catch ex As Exception

        End Try
    End Sub

    Private Function ValidaCamposBusqueda() As Boolean
        Try
            If txtNomina.ValordelControl = "" Then
                HDevExpre.MensagedeError("Debe seleccionar una nomina para realizar la consulta.")
                txtNomina.Focus()
                Return False
            ElseIf dteAño.ValordelControl = "" Then
                HDevExpre.MensagedeError("Debe digitqar una año para realizar la consulta.")
                dteAño.Focus()
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "ValidaCamposBusqueda")
            Return False
        End Try
    End Function


    'Private Sub grbEstado_KeyPress(sender As Object, e As KeyPressEventArgs)
    '    If e.KeyChar = Convert.ToChar(Keys.Enter) Then
    '        btnConsultar.Focus()
    '    End If
    '    If e.KeyChar = ChrW(Keys.Escape) Then
    '        dteFechaFin.Focus()
    '    End If
    'End Sub


    Private Sub btnConsultar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles btnSalir.KeyPress, btnLimpiar.KeyPress, btnGuardar.KeyPress, btnConsultar.KeyPress
        HDevExpre.AtrasConScape(e)
    End Sub
End Class