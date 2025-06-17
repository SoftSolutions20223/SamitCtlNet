Imports SamitCtlNet
Imports DevExpress.Utils
Imports System.ComponentModel
Imports DevExpress.XtraEditors.Controls
Imports SamitNominaLogic
Imports Newtonsoft.Json.Linq

Public Class FrmAggClasConceptosNomina
    Dim dt As DataTable
    Dim Buscando As Boolean = False
    Dim Actualizando As Boolean = False
    Dim SecClasConceptos As String = ""
    Dim secReg As Integer = 0
    Dim FormularioAbierto As Boolean = False
    Dim HDevExpre As New HelperDevExpress
    Dim HNomina As New HelperNomina
    Dim ConceptosNominas As New ConceptosNomina
    Public Property P_FormularioAbierto() As Boolean
        Get
            Return FormularioAbierto
        End Get
        Set(value As Boolean)
            FormularioAbierto = value
        End Set
    End Property
    Private Sub FrmAggClasConceptosNomina_Load(sender As Object, e As EventArgs) Handles Me.Load
        AcomodaForm()
        txtNoBuscando()
        CreaGrilla()
        LlenaGrillaClasConceptos()
        txtNombreClas.MensajedeAyuda = "Digite el nombre de la clasifiación que desea insertar.(ENTER,TAB)=Avanzar"
        txtNombreClas.MaximoAncho = AnchoCampoSql(ObjetoApiNomina, "ClasConceptosNomina", "Nom")
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
        If txtNombreClas.ValordelControl <> "" Then
            Dim sec As Integer = 0
            If Actualizando Then sec = secReg
            If GuardaDatos(sec, SecClasConceptos, txtNombreClas.ValordelControl, grbVigente.SelectedIndex.ToString(),
                       Actualizando) Then
                HDevExpre.mensajeExitoso("Información Guardada exitosamente")
                LlenaGrillaClasConceptos()
                LimpiarCampos()
            Else
                HDevExpre.MensagedeError("Error al guardar los datos!")
            End If
        Else
            HDevExpre.MensagedeError("El campo nombre no puede estar vacío!")
            txtNombreClas.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub gvClasConceptos_DoubleClick(sender As Object, e As EventArgs) Handles gvClasConceptos.DoubleClick
        CargarDatos()
    End Sub

    Private Sub gvClasConceptos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles gvClasConceptos.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            CargarDatos()
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        EliminaClasConceptosNomina(SecClasConceptos)
    End Sub
    Private Sub FrmAggClasConceptos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
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
            HDevExpre.msgError(ex, ex.Message, "AcomodaForm Agrega Clasificación de Conceptos!")
        End Try
    End Sub

    Private Sub CreaGrilla()
        Try
            gvClasConceptos.Columns.Clear()
            HDevExpre.CreaColumnasG(gvClasConceptos, "Sec", "Sec", False, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 0, 0)
            HDevExpre.CreaColumnasG(gvClasConceptos, "Nom", "Nombre", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 80, gbxPrincipal.Width)
            HDevExpre.CreaColumnasG(gvClasConceptos, "Vigente", "Vigente", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 20, gbxPrincipal.Width)
            gvClasConceptos.OptionsView.ShowFooter = True
            gvClasConceptos.Appearance.HeaderPanel.Font = New Font("Trebuchet MS", 11.0!, FontStyle.Bold)
            gvClasConceptos.Columns(2).Summary.Add(DevExpress.Data.SummaryItemType.Count, "", "{0}  Registros")
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "Crea Grilla")
        End Try
    End Sub
    Private Sub LlenaGrillaClasConceptos()
        Try
            Dim sql As String = "SELECT Sec,Nom,case Vigente " +
                                " WHEN '1' then 'Si' when '0' then 'No' end As Vigente FROM ClasConceptosNomina "
            dt = SMT_AbrirTabla(ObjetoApiNomina, sql)
            If dt.Rows.Count > 0 Then
                gcClasConceptos.DataSource = dt
            Else
                HDevExpre.mensajeExitoso("No se registra ninguna clasificación de conceptos, podemos empezar ingresandolas!..")
                gcClasConceptos.DataSource = Nothing
            End If

        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "LlenaGrillaTipoConceptos")
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
        gcClasConceptos.DataSource = dv
    End Sub

    Private Sub LimpiarCampos()
        SecClasConceptos = ""
        Actualizando = False
        txtNombreClas.ValordelControl = ""
        Buscando = False
        secReg = 0
        grbVigente.SelectedIndex = 1
        txtNoBuscando()
        gcClasConceptos.DataSource = dt
        txtNombreClas.Focus()
    End Sub
    Private Function GuardaDatos(Sec As Integer, SecTipo As String, NomVariable As String, Vigente As String, EstaActualizando As Boolean) As Boolean
        Try
            ConceptosNominas = New ConceptosNomina
            ConceptosNominas.NomConcepto = txtNombreClas.ValordelControl
            ConceptosNominas.Sec = Sec
            ConceptosNominas.Vigente = grbVigente.SelectedIndex.ToString()

            Dim RegConceptoNomina As New ServiceClasConceptosNomina
            Dim registro As JArray
            If RegConceptoNomina.ValidarCampos(ConceptosNominas) Then
                registro = RegConceptoNomina.UpsertClasConceptosNomina(ConceptosNominas)
            End If
            If registro.Count > 0 Then
                Return True
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "GuardaDatos")
            Return False
        End Try
    End Function
    Private Sub CargarDatos()
        Try
            SecClasConceptos = gvClasConceptos.GetFocusedRowCellValue("Sec").ToString
            txtNombreClas.ValordelControl = gvClasConceptos.GetFocusedRowCellValue("Nom").ToString
            If gvClasConceptos.GetFocusedRowCellValue("Vigente").ToString = "Si" Then
                grbVigente.SelectedIndex = 1
            Else
                grbVigente.SelectedIndex = 0
            End If
            Actualizando = True
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "CargarDatos")
        End Try
    End Sub
    Private Sub EliminaClasConceptosNomina(SecTipo As String)
        If Not Actualizando Or secReg = 0 Then
            HDevExpre.MensagedeError("No ha cargado ninguna entidad para ser eliminada.")
            Exit Sub
        End If
        If HDevExpre.MsgSamit(String.Format("Seguro que desea eliminar item seleccionado [{0}]", txtNombreClas.ValordelControl), MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.OK Then
            ConceptosNominas = New ConceptosNomina
            ConceptosNominas.Sec = secReg

            Dim RegConceptoNomina As New ServiceClasConceptosNomina
            Dim registro As JArray
            registro = RegConceptoNomina.EliminarClasConceptosNomina(ConceptosNominas)

            LimpiarCampos()
            LlenaGrillaClasConceptos()
        Else
            HDevExpre.MensagedeError("Error al eiminar la clasificación de conceptos!")
        End If
    End Sub
#End Region


    Private Sub FrmAggClasConceptos_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        LimpiarCampos()
        Buscando = False
        txtNoBuscando()
    End Sub

    Private Sub grbVigente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles grbVigente.KeyPress
        HDevExpre.AvanzaConEnter(e)
    End Sub

    Private Sub grbVigente_Enter(sender As Object, e As EventArgs) Handles grbVigente.Enter
        HDevExpre.EntraControlRadioGroup(grbVigente, lblVigente)
    End Sub

    Private Sub grbVigente_Leave(sender As Object, e As EventArgs) Handles grbVigente.Leave
        HDevExpre.SaleControlRadioGroup(grbVigente, lblVigente)
    End Sub

    Private Sub btnGuardar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles btnSalir.KeyPress, btnLimpiar.KeyPress, btnGuardar.KeyPress, btnEliminar.KeyPress
        HDevExpre.AtrasConScape(e)
    End Sub
End Class