Imports SamitCtlNet
Imports DevExpress.Utils
Imports System.ComponentModel
Imports DevExpress.XtraEditors.Controls
Imports SamitNominaLogic
Imports Newtonsoft.Json.Linq

Public Class FrmAggDependencia
    Dim dt As DataTable
    Dim Buscando As Boolean = False
    Dim Actualizando As Boolean = False
    Dim SecDependencia As String = ""
    Dim secReg As Integer = 0
    Dim FormularioAbierto As Boolean = False
    Dim HDevExpre As New HelperDevExpress
    Dim HNomina As New HelperNomina
    Dim Dependencia As New Dependencias
    Public Property P_FormularioAbierto() As Boolean
        Get
            Return FormularioAbierto
        End Get
        Set(value As Boolean)
            FormularioAbierto = value
        End Set
    End Property

    Private Sub FrmAggDependencia_Load(sender As Object, e As EventArgs) Handles Me.Load
        AcomodaForm()
        txtNoBuscando()
        CreaGrilla()
        LlenaGrillaDependencias()
        txtNombreDependencia.Focus()
        txtNombreDependencia.MensajedeAyuda = "Digite el nombre de la Dependencia. (ENTER,ABJ)=Avanzar"
        txtNombreDependencia.MaximoAncho = AnchoCampoSql(ObjetoApiNomina, "Dependencias", "NomDependencia")
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


    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtNombreDependencia.ValordelControl <> "" Then
            If GuardaDatos(secReg) Then
                HDevExpre.mensajeExitoso("Información Guardada exitosamente")
                LlenaGrillaDependencias()
                LimpiarCampos()
            Else
                HDevExpre.MensagedeError("Error al guardar los datos!")
            End If
        Else
            HDevExpre.MensagedeError("El campo nombre no puede estar vacío!")
            txtNombreDependencia.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub gvDependencia_DoubleClick(sender As Object, e As EventArgs) Handles gvDependencia.DoubleClick
        CargarDatos()
    End Sub

    Private Sub gvDependencia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles gvDependencia.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            CargarDatos()
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        EliminaDependencia(SecDependencia)
    End Sub
    Private Sub FrmAggDependencia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
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

        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "AcomodaForm Agrega Dependencia!")
        End Try
    End Sub
    Private Sub CreaGrilla()
        Try
            gvDependencia.Columns.Clear()

            HDevExpre.CreaColumnasG(gvDependencia, "Sec", "Sec", False, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 0, 0)
            HDevExpre.CreaColumnasG(gvDependencia, "NomDependencia", "Nombre", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 70, gbxPrincipal.Width)
            HDevExpre.CreaColumnasG(gvDependencia, "Vigente", "Vigente", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 30, gbxPrincipal.Width)
            gvDependencia.OptionsView.ShowFooter = True
            gvDependencia.Appearance.HeaderPanel.Font = New Font("Trebuchet MS", 11.0!, FontStyle.Bold)
            gvDependencia.Columns(2).Summary.Add(DevExpress.Data.SummaryItemType.Count, "", "{0}  Registros")
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "Crea Grilla Dependencias")
        End Try
    End Sub
    Private Sub LlenaGrillaDependencias()
        Try
            Dim sql As String = "SELECT Sec,NomDependencia,case Vigente " +
                                " WHEN '1' then 'Si' when '0' then 'No' end As Vigente FROM Dependencias "
            dt = SMT_AbrirTabla(ObjetoApiNomina, sql)
            If dt.Rows.Count > 0 Then
                gcDependencia.DataSource = dt
            Else
                HDevExpre.mensajeExitoso("No se registra ninguna Dependencia, podemos empezar ingresandolas!..")
                gcDependencia.DataSource = Nothing
            End If

        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "LlenaGrillaDependencias")
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
        gcDependencia.DataSource = dv
    End Sub

    Private Sub LimpiarCampos()
        SecDependencia = ""
        secReg = 0
        Actualizando = False
        txtNombreDependencia.ValordelControl = ""
        Buscando = False
        grbVigente.SelectedIndex = 1
        txtNoBuscando()
        gcDependencia.DataSource = dt
        txtNombreDependencia.Focus()
    End Sub
    Private Function GuardaDatos(Sec As Integer) As Boolean
        Try
            Dependencia = New Dependencias
            Dependencia.NomDependencia = txtNombreDependencia.ValordelControl
            Dependencia.Sec = Sec
            Dependencia.Vigente = grbVigente.SelectedIndex.ToString()

            Dim RegDependencia As New ServiceDependencias
            Dim registro As DynamicUpsertResponseDto
            If RegDependencia.ValidarCampos(Dependencia) Then
                registro = RegDependencia.UpsertDependencia(Dependencia)
            End If
            If registro.ErrorCount < 1 Then
                Return True
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "Guardando Dependencia")
            Return False
        End Try
    End Function
    Private Sub CargarDatos()
        Try
            SecDependencia = gvDependencia.GetFocusedRowCellValue("Sec").ToString
            If SecDependencia <> "" Then
                secReg = CInt(SecDependencia)
            End If
            txtNombreDependencia.ValordelControl = gvDependencia.GetFocusedRowCellValue("NomDependencia").ToString
            If gvDependencia.GetFocusedRowCellValue("Vigente").ToString = "Si" Then
                grbVigente.SelectedIndex = 1
            Else
                grbVigente.SelectedIndex = 0
            End If

            Actualizando = True
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "Cargar datos Dependencias")
        End Try
    End Sub
    Private Sub EliminaDependencia(Sec_Dependencia As String)
        If Not Actualizando Or secReg = 0 Then
            HDevExpre.MensagedeError("No ha cargado ninguna entidad para ser eliminada.")
            Exit Sub
        End If
        If HDevExpre.MsgSamit(String.Format("Seguro que desea eliminar el item seleccionado [{0}]", txtNombreDependencia.ValordelControl), MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.OK Then
            Dependencia = New Dependencias
            Dependencia.Sec = secReg

            Dim RegDependencia As New ServiceDependencias
            Dim registro As JArray
            registro = RegDependencia.EliminarDependencia(Dependencia)
            LimpiarCampos()
            LlenaGrillaDependencias()
        Else
            HDevExpre.MensagedeError("Error al eiminar la Dependencia!")
        End If
    End Sub
#End Region


    Private Sub FrmAggDependencia_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        LimpiarCampos()
        Buscando = False
        txtNoBuscando()
    End Sub


    Private Sub grbVigente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles grbVigente.KeyPress
        HDevExpre.AvanzaConEnter(e)
    End Sub

    Private Sub grbVigente_Enter(sender As Object, e As EventArgs) Handles grbVigente.Enter
        HDevExpre.EntraControlRadioGroup(grbVigente, lblVigente)
        FrmPrincipal.MensajeDeAyuda.Caption = "Estado de la Dependencia. (ENTER)=Avanzar;(ESC,ARB)=Atras"
        FrmPrincipal.MensajeDeAyuda.Refresh()
    End Sub

    Private Sub grbVigente_Leave(sender As Object, e As EventArgs) Handles grbVigente.Leave
        HDevExpre.SaleControlRadioGroup(grbVigente, lblVigente)
        FrmPrincipal.MensajeDeAyuda.Caption = ""
        FrmPrincipal.MensajeDeAyuda.Refresh()
    End Sub

    Private Sub grbVigente_Click(sender As Object, e As EventArgs) Handles grbVigente.Click
        FrmPrincipal.MensajeDeAyuda.Caption = "Estado de la Dependencia. (ENTER)=Avanzar;(ESC,ARB)=Atras"
        FrmPrincipal.MensajeDeAyuda.Refresh()
    End Sub

    Private Sub txtNombreDependencia_Leave(sender As Object, e As EventArgs) Handles txtNombreDependencia.Leave
        'If grbVigente.Focus Then
        '    Dim send As New Object
        '    Dim evento As New EventArgs
        '    grbVigente_Click(send, evento)
        'End If
    End Sub

    Private Sub btnSalir_KeyPress(sender As Object, e As KeyPressEventArgs) Handles btnSalir.KeyPress, btnLimpiar.KeyPress, btnGuardar.KeyPress, btnEliminar.KeyPress
        HDevExpre.AtrasConScape(e)
    End Sub
End Class