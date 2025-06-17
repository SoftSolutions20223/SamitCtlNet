Imports SamitCtlNet
Imports DevExpress.Utils
Imports System.ComponentModel
Imports DevExpress.XtraEditors.Controls
Imports SamitNominaLogic
Imports Newtonsoft.Json.Linq

Public Class FrmAggCentroCosto

    Dim dt As DataTable
    Dim Buscando As Boolean = False
    Dim Actualizando As Boolean = False

    Dim CodCentroCosto As String = ""
    Dim secReg As Integer = 0
    Dim FormularioAbierto As Boolean = False
    Dim HDevExpre As New HelperDevExpress
    Dim HNomina As New HelperNomina
    Dim CentroCostos As New CT_CentroCostos
    Public Property P_FormularioAbierto() As Boolean
        Get
            Return FormularioAbierto
        End Get
        Set(value As Boolean)
            FormularioAbierto = value
        End Set
    End Property

    Private Sub FrmAggCentroCosto_Load(sender As Object, e As EventArgs) Handles Me.Load
        FrmPrincipal.MensajeDeAyuda.Caption = ""
        FrmPrincipal.MensajeDeAyuda.Refresh()
        AcomodaForm()
        txtNoBuscando()
        CreaGrilla()
        LlenaGrillaCentroCosto()
        txtNombreCentrodeCosto.MensajedeAyuda = "Digite el nombre del centro de costo que desea agregar.(ENTER,TAB,ABJ)=Avanzar"
        txtResponsable.MensajedeAyuda = "Número de identificacion del responsable del Centro de Costo. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
        txtNombreCentrodeCosto.MaximoAncho = AnchoCampoSql(ObjetoApiNomina, "CT_CentroCostos", "Nom_CentroCosto")
    End Sub

#Region "Eventos Controles"
    Private Sub txtBusqueda_EditValueChanged(sender As Object, e As EventArgs) Handles txtBusqueda.EditValueChanged
        Dim buscando As Boolean = Me.Buscando
        If buscando Then
            FiltrarDatos(txtBusqueda.Text)
        End If
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
    End Sub

    Public Function ValidarCampos() As Boolean
        Dim res As Boolean = False
        If txtNombreCentrodeCosto.ValordelControl = "" Then
            HDevExpre.MensagedeError("El campo Nombre no puede estar vacío!..")
            txtNombreCentrodeCosto.Focus()
            res = False
        ElseIf txtResponsable.ValordelControl = "" Then
            HDevExpre.MensagedeError("El campo Responsable no puede estar vacío!..")
            txtResponsable.Focus()
            res = False

        ElseIf grbUsolimitado.SelectedIndex = 1 And dteFechaIniLimite.Text = "" Then
            HDevExpre.MensagedeError("El campo Fecha Inicio no puede estar vacío!..")
            dteFechaIniLimite.Focus()
            res = False

        ElseIf grbUsolimitado.SelectedIndex = 1 And dteFechaFinLimite.Text = "" Then
            HDevExpre.MensagedeError("El campo Fecha Fin no puede estar vacío!..")
            dteFechaIniLimite.Focus()
            res = False
        ElseIf dteFechaFinLimite.DateTime < dteFechaIniLimite.DateTime Then
            HDevExpre.MensagedeError("La fecha de inicio no puede ser superior a la fecha de finalización!..")
            dteFechaIniLimite.Focus()
            Return False
        Else
            res = True

        End If
        Return res
    End Function
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If ValidarCampos() Then
            Dim sec As Integer = 0
            If Actualizando Then sec = secReg


            If GuardaDatos(sec) Then
                HDevExpre.mensajeExitoso("Información Guardada exitosamente")
                LlenaGrillaCentroCosto()
                LimpiarCampos()
            Else
                HDevExpre.MensagedeError("Error al guardar los datos!")
            End If
        Else
            Exit Sub
        End If
    End Sub

    Private Sub gvCentroCosto_DoubleClick(sender As Object, e As EventArgs) Handles gvCentroCosto.DoubleClick
        CargarDatos()
    End Sub

    Private Sub gvCentroCosto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles gvCentroCosto.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            CargarDatos()
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        EliminaCentroCosto(CodCentroCosto)
    End Sub
    Private Sub FrmAggCentroCosto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = ChrW(Keys.Escape) Then
            Me.Close()
        End If
    End Sub

#End Region
#Region "Procedimientos y Funciones"
    Private Sub AcomodaForm()
        Try
            btnGuardar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Guardar)
            btnEliminar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Eliminar)
            btnSalir.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.SalirAtras)
            btnLimpiar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Limpiar)
            grbVigente.SelectedIndex = 1
            grbUsolimitado.SelectedIndex = 0
            dteFechaIniLimite.Enabled = False
            dteFechaFinLimite.Enabled = False
            txtNombreCentrodeCosto.Select()

        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "AcomodaForm Agrega Centro de Costo!")
        End Try
    End Sub
    Private Sub CreaGrilla()
        Try
            gvCentroCosto.Columns.Clear()
            HDevExpre.CreaColumnasG(gvCentroCosto, "Sec", "Sec", False, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 0, 0)
            HDevExpre.CreaColumnasG(gvCentroCosto, "Nom_CentroCosto", "Nombre", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 20, gbxPrincipal.Width)
            HDevExpre.CreaColumnasG(gvCentroCosto, "Responsable", "Responsable", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 20, gbxPrincipal.Width)
            HDevExpre.CreaColumnasG(gvCentroCosto, "Estado", "Vigente", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 10, gbxPrincipal.Width)
            HDevExpre.CreaColumnasG(gvCentroCosto, "LimitaUso", "Limita Uso", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 10, gbxPrincipal.Width)
            HDevExpre.CreaColumnasG(gvCentroCosto, "FechaIniLimite", "Fecha de inicio", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 20, gbxPrincipal.Width)
            HDevExpre.CreaColumnasG(gvCentroCosto, "FechaFinLimite", "Fecha limite", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 20, gbxPrincipal.Width)
            gvCentroCosto.OptionsView.ShowFooter = True
            gvCentroCosto.Appearance.HeaderPanel.Font = New Font("Trebuchet MS", 11.0!, FontStyle.Bold)
            gvCentroCosto.Columns(6).Summary.Add(DevExpress.Data.SummaryItemType.Count, "", "{0}  Registros")

        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "Crea Grilla CentrosdeCosto")
        End Try
    End Sub
    Private Sub LlenaGrillaCentroCosto()
        Try
            Dim sql As String = "SELECT CC.Sec,CC.Nom_CentroCosto,CC.Responsable, case CC.Estado " +
                                " WHEN '1' then 'Si' when '0' then 'No' end As Estado, " +
                                " case CC.LimitaUso" +
                                " WHEN 'True' then 'Si' when 'False' then 'No' end As LimitaUso," +
                                " CC.FechaIniLimite,CC.FechaFinLimite FROM CT_CentroCostos CC"
            dt = SMT_AbrirTabla(ObjetoApiNomina, sql)
            If dt.Rows.Count > 0 Then
                gcCentroCosto.DataSource = dt
            Else
                HDevExpre.mensajeExitoso("No se registra ningún Centro de Costo, podemos empezar ingresandolos!..")
                gcCentroCosto.DataSource = Nothing
            End If

        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "LlenaGrillaCentroCosto")
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
        gcCentroCosto.DataSource = dv
    End Sub

    Private Sub LimpiarCampos()
        CodCentroCosto = ""
        Actualizando = False
        txtNombreCentrodeCosto.ValordelControl = ""
        txtResponsable.ValordelControl = ""
        grbVigente.SelectedIndex = 1
        grbUsolimitado.SelectedIndex = 0
        dteFechaIniLimite.Text = ""
        dteFechaFinLimite.Text = ""
        Buscando = False
        txtNoBuscando()
        gcCentroCosto.DataSource = dt
        txtNombreCentrodeCosto.Focus()
    End Sub
    Private Function GuardaDatos(Sec As Integer) As Boolean
        Dim Fecha_ini, Fecha_Fin As String
        Dim limitauso As Boolean
        Try
            If grbUsolimitado.SelectedIndex = 1 Then
                limitauso = True
                Fecha_ini = dteFechaIniLimite.DateTime.ToString("dd/MM/yyyy")
                Fecha_Fin = dteFechaFinLimite.DateTime.ToString("dd/MM/yyyy")
            Else
                limitauso = False
                Fecha_ini = "1900-02-09 00:00:00.000"
                Fecha_Fin = "1900-02-09 00:00:00.000"
            End If
            If CodCentroCosto = "" Then
                CodCentroCosto = "0"
            End If
            CentroCostos = New CT_CentroCostos
            CentroCostos.Nom_CentroCosto = txtNombreCentrodeCosto.ValordelControl
            CentroCostos.Sec = CodCentroCosto
            CentroCostos.Responsable = txtResponsable.ValordelControl
            CentroCostos.FechaIniLimite = Fecha_ini
            CentroCostos.FechaFinLimite = Fecha_Fin
            CentroCostos.LimitaUso = limitauso
            CentroCostos.Estado = grbVigente.SelectedIndex.ToString


            Dim RegCentroCostos As New ServiceCentroCostos
            Dim registro As DynamicUpsertResponseDto
            If RegCentroCostos.ValidarCampos(CentroCostos) Then
                registro = RegCentroCostos.UpsertCentroCosto(CentroCostos)
            End If
            If registro.ErrorCount < 1 Then
                Return True
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "Guardando Centro de Costo")
            Return False
        End Try
    End Function
    Private Sub CargarDatos()
        Try
            Dim Vigente As String = ""
            Dim LimitaUso As String = ""
            Dim FechaIniLi As String = gvCentroCosto.GetFocusedRowCellValue("FechaIniLimite").ToString
            Dim FechaFinli As String = gvCentroCosto.GetFocusedRowCellValue("FechaFinLimite").ToString
            CodCentroCosto = gvCentroCosto.GetFocusedRowCellValue("Sec").ToString
            txtNombreCentrodeCosto.ValordelControl = gvCentroCosto.GetFocusedRowCellValue("Nom_CentroCosto").ToString
            txtResponsable.ValordelControl = gvCentroCosto.GetFocusedRowCellValue("Responsable").ToString
            Vigente = gvCentroCosto.GetFocusedRowCellValue("Estado").ToString
            LimitaUso = gvCentroCosto.GetFocusedRowCellValue("LimitaUso").ToString
            dteFechaIniLimite.Text = FechaIniLi.Substring(0, 10)
            dteFechaFinLimite.Text = FechaFinli.Substring(0, 10)
            If Vigente = "Si" Then
                grbVigente.SelectedIndex = 1
            Else
                grbVigente.SelectedIndex = 0
            End If
            If LimitaUso = "Si" Then
                grbUsolimitado.SelectedIndex = 1
            Else
                grbUsolimitado.SelectedIndex = 0
            End If
            Actualizando = True
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "Cargar datos Centro de Costos")
        End Try
    End Sub
    Private Sub EliminaCentroCosto(IdCod_CentroCosto As String)
        If Not Actualizando Or secReg = 0 Then
            HDevExpre.MensagedeError("No ha cargado ninguna entidad para ser eliminada.")
            Exit Sub
        End If

        If HDevExpre.MsgSamit(String.Format("Seguro que desea eliminar item seleccionado [{0}]", txtNombreCentrodeCosto.ValordelControl), MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.OK Then
            CentroCostos = New CT_CentroCostos
            CentroCostos.Sec = secReg

            Dim RegCentroCostos As New ServiceCentroCostos
            Dim registro As JArray
            registro = RegCentroCostos.EliminarCentroCosto(CentroCostos)
            LimpiarCampos()
            LlenaGrillaCentroCosto()
        Else
            HDevExpre.MensagedeError("Error al eiminar el Centro de Costo!")

        End If
    End Sub
#End Region


    Private Sub FrmAggCentroCosto_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        LimpiarCampos()
        Buscando = False
        txtNoBuscando()
    End Sub

    Private Sub grbUsolimitado_Leave(sender As Object, e As EventArgs) Handles grbUsolimitado.Leave
        HDevExpre.SaleControlRadioGroup(grbUsolimitado, lblUsoLimitado)
        FrmPrincipal.MensajeDeAyuda.Caption = ""
        FrmPrincipal.MensajeDeAyuda.Refresh()
    End Sub



    Private Sub grbUsolimitado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles grbUsolimitado.SelectedIndexChanged
        If grbUsolimitado.SelectedIndex = 1 Then
            dteFechaIniLimite.Enabled = True
            dteFechaFinLimite.Enabled = True
        Else
            dteFechaIniLimite.Enabled = False
            dteFechaFinLimite.Enabled = False
        End If
    End Sub

    Private Sub dteFechaFinLimite_Leave(sender As Object, e As EventArgs) Handles dteFechaFinLimite.Leave
        HDevExpre.SaleControlDateEditDEV(dteFechaFinLimite, lblFechaFinLimite)
        FrmPrincipal.MensajeDeAyuda.Caption = ""
        FrmPrincipal.MensajeDeAyuda.Refresh()
        'btnGuardar.Focus()
    End Sub

    Private Sub grbVigente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles grbVigente.KeyPress, grbUsolimitado.KeyPress, dteFechaIniLimite.KeyPress, dteFechaFinLimite.KeyPress
        HDevExpre.AvanzaConEnter(e)
    End Sub

    Private Sub grbUsolimitado_Enter(sender As Object, e As EventArgs) Handles grbUsolimitado.Enter
        HDevExpre.EntraControlRadioGroup(grbUsolimitado, lblUsoLimitado)
        FrmPrincipal.MensajeDeAyuda.Caption = "El Centro de Costo tiene un limite de uso?. (ENTER)=Avanzar;(ESC,ARB)=Atras"
        FrmPrincipal.MensajeDeAyuda.Refresh()
    End Sub

    Private Sub grbVigente_Enter(sender As Object, e As EventArgs) Handles grbVigente.Enter
        HDevExpre.EntraControlRadioGroup(grbVigente, lblVigente)
        FrmPrincipal.MensajeDeAyuda.Caption = "Estado del Centro de Costo. (ENTER)=Avanzar;(ESC,ARB)=Atras"
        FrmPrincipal.MensajeDeAyuda.Refresh()
    End Sub

    Private Sub dteFechaIniLimite_Enter(sender As Object, e As EventArgs) Handles dteFechaIniLimite.Enter
        HDevExpre.EntraControlDateEditDEV(dteFechaIniLimite, lblFechaIniLimite)
        FrmPrincipal.MensajeDeAyuda.Caption = "Fecha de inicio del limite de uso del Centro de Costo. (ENTER)=Avanzar;(ESC,ARB)=Atras"
        FrmPrincipal.MensajeDeAyuda.Refresh()
    End Sub

    Private Sub dteFechaFinLimite_Enter(sender As Object, e As EventArgs) Handles dteFechaFinLimite.Enter
        HDevExpre.EntraControlDateEditDEV(dteFechaFinLimite, lblFechaFinLimite)
        FrmPrincipal.MensajeDeAyuda.Caption = "Fecha de finalizacion del limite de uso del Centro de Costo. (ENTER)=Avanzar;(ESC,ARB)=Atras"
        FrmPrincipal.MensajeDeAyuda.Refresh()
    End Sub

    Private Sub dteFechaIniLimite_Leave(sender As Object, e As EventArgs) Handles dteFechaIniLimite.Leave
        HDevExpre.SaleControlDateEditDEV(dteFechaIniLimite, lblFechaIniLimite)
        FrmPrincipal.MensajeDeAyuda.Caption = ""
        FrmPrincipal.MensajeDeAyuda.Refresh()
    End Sub

    Private Sub grbVigente_Leave(sender As Object, e As EventArgs) Handles grbVigente.Leave
        HDevExpre.SaleControlRadioGroup(grbVigente, lblVigente)
        FrmPrincipal.MensajeDeAyuda.Caption = ""
        FrmPrincipal.MensajeDeAyuda.Refresh()
    End Sub

    Private Sub txtResponsable_Leave(sender As Object, e As EventArgs) Handles txtResponsable.Leave
        'If grbUsolimitado.Focus Then
        '    'Dim send As New Object
        '    'Dim evento As New EventArgs
        '    'grbUsolimitado_Click(send, evento)
        'End If
    End Sub

    Private Sub grbUsolimitado_Click(sender As Object, e As EventArgs) Handles grbUsolimitado.Click
        FrmPrincipal.MensajeDeAyuda.Caption = "El Centro de Costo tiene un limite de uso?. (ENTER)=Avanzar;(ESC,ARB)=Atras"
        FrmPrincipal.MensajeDeAyuda.Refresh()
    End Sub

    Private Sub btnSalir_KeyPress(sender As Object, e As KeyPressEventArgs) Handles btnSalir.KeyPress, btnLimpiar.KeyPress, btnGuardar.KeyPress, btnEliminar.KeyPress
        HDevExpre.AtrasConScape(e)
    End Sub
End Class