Imports SamitCtlNet
Imports DevExpress.Utils
Imports System.ComponentModel
Imports DevExpress.XtraEditors.Controls
Imports SamitNominaLogic
Imports Newtonsoft.Json.Linq

Public Class FrmAggFunciones
    Dim dt As DataTable
    Dim Buscando As Boolean = False
    Dim Actualizando As Boolean = False
    Dim SecFuncion As String = ""
    Dim secReg As Integer = 0
    Dim FormularioAbierto As Boolean = False
    Dim HDevExpre As New HelperDevExpress
    Dim HNomina As New HelperNomina
    Dim Funcion As New Funciones
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
        txtNombreFunciones.MensajedeAyuda = "Digite el nombre de las función que desea agregar. (Funciones de los empleados). (ENTER,TAB,ABJ)=Avanzar;(ARB,ESC)=Atras"
        txtNombreFunciones.MaximoAncho = AnchoCampoSql(ObjetoApiNomina, "Funciones", "DetalleFuncion")
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
        If txtNombreFunciones.ValordelControl <> "" Then
            If GuardaDatos(secReg) Then
                HDevExpre.mensajeExitoso("Información Guardada exitosamente")
                LlenaGrillaDependencias()
                LimpiarCampos()
            Else
                HDevExpre.MensagedeError("Error al guardar los datos!")
            End If
        Else
            HDevExpre.MensagedeError("El campo Nombre no puede estar vacío!")
            txtNombreFunciones.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub gvFunciones_DoubleClick(sender As Object, e As EventArgs) Handles gvFunciones.DoubleClick
        CargarDatos()
    End Sub

    Private Sub gvFunciones_KeyPress(sender As Object, e As KeyPressEventArgs) Handles gvFunciones.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            CargarDatos()
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        EliminaFunciones(SecFuncion)
    End Sub
    Private Sub FrmAggFunciones_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
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

        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "AcomodaForm Agrega Dependencia!")
        End Try
    End Sub
    Private Sub CreaGrilla()
        Try
            gvFunciones.Columns.Clear()

            HDevExpre.CreaColumnasG(gvFunciones, "Sec", "Sec", False, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 0, 0)
            HDevExpre.CreaColumnasG(gvFunciones, "DetalleFuncion", "Nombre", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 100, gbxPrincipal.Width)
            gvFunciones.OptionsView.ShowFooter = True
            gvFunciones.Appearance.HeaderPanel.Font = New Font("Trebuchet MS", 11.0!, FontStyle.Bold)
            gvFunciones.Columns(1).Summary.Add(DevExpress.Data.SummaryItemType.Count, "", "{0}  Registros")
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "CreaGrillaFunciones")
        End Try
    End Sub
    Private Sub LlenaGrillaDependencias()
        Try
            Dim sql As String = "SELECT Sec,DetalleFuncion FROM Funciones"
            dt = SMT_AbrirTabla(ObjetoApiNomina, sql)
            If dt.Rows.Count > 0 Then
                gcFunciones.DataSource = dt
            Else
                HDevExpre.mensajeExitoso("No se registra ninguna Función, podemos empezar ingresandolas!..")
                gcFunciones.DataSource = Nothing
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
        gcFunciones.DataSource = dv
    End Sub

    Private Sub LimpiarCampos()
        SecFuncion = ""
        Actualizando = False
        txtNombreFunciones.ValordelControl = ""
        Buscando = False
        secReg = 0
        txtNoBuscando()
        gcFunciones.DataSource = dt
        txtNombreFunciones.Focus()
    End Sub
    Private Function GuardaDatos(Sec As Integer) As Boolean
        Try
            Funcion = New Funciones
            Funcion.DetalleFuncion = txtNombreFunciones.ValordelControl
            Funcion.Sec = Sec
            Dim RegFunciones As New ServiceFunciones
            Dim registro As DynamicUpsertResponseDto
            If RegFunciones.ValidarCampos(Funcion) Then
                registro = RegFunciones.UpsertFunciones(Funcion)
            End If
            If registro.ErrorCount < 1 Then
                Return True
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "Guardando Función")
            Return False
        End Try
    End Function
    Private Sub CargarDatos()
        Try
            SecFuncion = gvFunciones.GetFocusedRowCellValue("Sec").ToString
            secReg = CType(SecFuncion, Integer)
            txtNombreFunciones.ValordelControl = gvFunciones.GetFocusedRowCellValue("DetalleFuncion").ToString
            Actualizando = True
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "CargardatosFunciones")
        End Try
    End Sub
    Private Sub EliminaFunciones(Sec_Funcion As String)
        If Not Actualizando Or secReg = 0 Then
            HDevExpre.MensagedeError("No ha cargado ninguna entidad para ser eliminada.")
            Exit Sub
        End If
        If HDevExpre.MsgSamit(String.Format("Seguro que desea eliminar el item seleccionado [{0}]", txtNombreFunciones.ValordelControl), MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.OK Then
            Funcion = New Funciones
            Funcion.Sec = secReg

            Dim RegFunciones As New ServiceFunciones
            Dim registro As JArray
            registro = RegFunciones.EliminarFunciones(Funcion)
            LimpiarCampos()
            LlenaGrillaDependencias()
        Else
            HDevExpre.MensagedeError("Error al eiminar la Función!")
        End If
    End Sub
#End Region


    Private Sub FrmAggDependencia_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        LimpiarCampos()
        Buscando = False
        txtNoBuscando()
    End Sub

    Private Sub btnSalir_KeyPress(sender As Object, e As KeyPressEventArgs) Handles btnSalir.KeyPress, btnLimpiar.KeyPress, btnGuardar.KeyPress, btnEliminar.KeyPress
        HDevExpre.AtrasConScape(e)
    End Sub
End Class