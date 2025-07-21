Imports SamitCtlNet
Imports DevExpress.Utils
Imports System.ComponentModel
Imports DevExpress.XtraEditors.Controls
Imports SamitNominaLogic
Imports Newtonsoft.Json.Linq

Public Class FrmAggValExentos
    Dim dt As DataTable
    Dim Buscando As Boolean = False
    Dim Actualizando As Boolean = False
    Dim SecValorExento As String = ""
    Dim secReg As Integer = 0
    Dim FormularioAbierto As Boolean = False
    Dim HDevExpre As New HelperDevExpress
    Dim HNomina As New HelperNomina
    Dim ValExento As New ValoresExentos
    Public Property P_FormularioAbierto() As Boolean
        Get
            Return FormularioAbierto
        End Get
        Set(value As Boolean)
            FormularioAbierto = value
        End Set
    End Property

    Private Sub FrmAggValorExento_Load(sender As Object, e As EventArgs) Handles Me.Load
        AcomodaForm()
        txtNoBuscando()
        CreaGrilla()
        LlenaGrillaValorExentos()
        txtNombre.Focus()
        txtNombre.MensajedeAyuda = "Digite el nombre del Valor Exento. (ENTER,ABJ)=Avanzar"
        txtNombre.MaximoAncho = AnchoCampoSql(ObjetoApiNomina, "ValoresExentos", "Nom")
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
        If txtNombre.ValordelControl <> "" Then
            Dim TipoVal As String = ""
            If grbTipoValor.SelectedIndex = 1 Then
                TipoVal = "P"
            Else
                TipoVal = "F"
            End If
            Dim sec As Integer = 0
            If SecValorExento = "" Then SecValorExento = "0"
            If GuardaDatos(SecValorExento, txtNombre.ValordelControl, grbVigente.SelectedIndex.ToString(), TipoVal) Then
                HDevExpre.mensajeExitoso("Información Guardada exitosamente")
                LlenaGrillaValorExentos()
                LimpiarCampos()
            Else
                HDevExpre.MensagedeError("Error al guardar los datos!")
            End If
        Else
            HDevExpre.MensagedeError("El campo nombre no puede estar vacío!")
            txtNombre.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub gvValorExento_DoubleClick(sender As Object, e As EventArgs) Handles gvValorExento.DoubleClick
        CargarDatos()
    End Sub

    Private Sub gvValorExento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles gvValorExento.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            CargarDatos()
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        EliminaValorExento(SecValorExento)
    End Sub
    Private Sub FrmAggValorExento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
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
            grbTipoValor.SelectedIndex = 1

        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "AcomodaForm Agrega ValorExento!")
        End Try
    End Sub
    Private Sub CreaGrilla()
        Try
            gvValorExento.Columns.Clear()

            HDevExpre.CreaColumnasG(gvValorExento, "Sec", "Sec", False, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 0, 0)
            HDevExpre.CreaColumnasG(gvValorExento, "Nom", "Nombre", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 50, gbxPrincipal.Width)
            HDevExpre.CreaColumnasG(gvValorExento, "TipoValor", "Tipo Valor", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 25, gbxPrincipal.Width)
            HDevExpre.CreaColumnasG(gvValorExento, "Vigente", "Vigente", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 23, gbxPrincipal.Width)
            gvValorExento.OptionsView.ShowFooter = True
            gvValorExento.Appearance.HeaderPanel.Font = New Font("Trebuchet MS", 11.0!, FontStyle.Bold)
            gvValorExento.Columns(2).Summary.Add(DevExpress.Data.SummaryItemType.Count, "", "{0}  Registros")
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "Crea Grilla ValoresExentos")
        End Try
    End Sub
    Private Sub LlenaGrillaValorExentos()
        Try
            Dim sql As String = "SELECT Sec,Nom,case Vigente " +
                                " WHEN '1' then 'Si' when '0' then 'No' end As Vigente,case TipoValor WHEN 'F' then 'Valor Fijo' when 'P' then 'Porcentaje' end As TipoValor FROM ValoresExentos "
            dt = SMT_AbrirTabla(ObjetoApiNomina, sql)
            If dt.Rows.Count > 0 Then
                gcValorExento.DataSource = dt
            Else
                HDevExpre.mensajeExitoso("No se registra ningun Valor Exento, podemos empezar ingresandolos!..")
                gcValorExento.DataSource = Nothing
            End If

        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "LlenaGrillaValoresExentos")
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
        gcValorExento.DataSource = dv
    End Sub

    Private Sub LimpiarCampos()
        SecValorExento = ""
        Actualizando = False
        txtNombre.ValordelControl = ""
        Buscando = False
        grbVigente.SelectedIndex = 1
        grbTipoValor.SelectedIndex = 1
        secReg = 0
        txtNoBuscando()
        gcValorExento.DataSource = dt
        txtNombre.Focus()
    End Sub
    Private Function GuardaDatos(Sec_ValorExento As String, Nom_ValorExento As String, Vigente As String, TipoValor As String) As Boolean
        Try
            ValExento = New ValoresExentos
            ValExento.Nom = Nom_ValorExento
            ValExento.Sec = Sec_ValorExento
            ValExento.Vigente = Vigente
            ValExento.TipoValor = TipoValor
            Dim RegValExento As New ServiceValExentos
            Dim registro As DynamicUpsertResponseDto
            If RegValExento.ValidarCampos(ValExento) Then
                registro = RegValExento.UpsertValExento(ValExento)
            End If
            If registro.ErrorCount < 1 Then
                Return True
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "Guardando ValoresExento")
            Return False
        End Try
    End Function
    Private Sub CargarDatos()
        Try
            SecValorExento = gvValorExento.GetFocusedRowCellValue("Sec").ToString
            txtNombre.ValordelControl = gvValorExento.GetFocusedRowCellValue("Nom").ToString
            If gvValorExento.GetFocusedRowCellValue("Vigente").ToString = "Si" Then
                grbVigente.SelectedIndex = 1
            Else
                grbVigente.SelectedIndex = 0
            End If

            If gvValorExento.GetFocusedRowCellValue("TipoValor").ToString = "Porcentaje" Then
                grbTipoValor.SelectedIndex = 1
            Else
                grbTipoValor.SelectedIndex = 0
            End If

            Actualizando = True
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "Cargar datos ValoresExentos")
        End Try
    End Sub
    Private Sub EliminaValorExento(Sec_ValorExento As String)
        If Not Actualizando Or SecValorExento = "0" Then
            HDevExpre.MensagedeError("No ha cargado ningun valor exento para ser eliminado.")
            Exit Sub
        End If
        If HDevExpre.MsgSamit(String.Format("Seguro que desea eliminar el item seleccionado [{0}]", txtNombre.ValordelControl), MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.OK Then
            If ExisteDato("Asig_ValoresExentos", "ValorExento ='" + SecValorExento + "'", ObjetoApiNomina) Then
                HDevExpre.MensagedeError("Este valor exento ya ha sido asignado!")
            Else
                Dim request As New DynamicDeleteRequest With {
                            .Tabla = "ValoresExentos",
                            .Codigo = CInt(SecValorExento)
                        }
                ' Ejecutar el procedimiento almacenado
                Dim resp = SMT_EjecutaProcedimientos(ObjetoApiNomina, "SP_DynamicDelete", request.ToJObject())
                Dim response = resp.ToObject(Of DynamicDeleteResponse)()

                ' Procesar respuesta
                If response.EsExitoso Then
                    HDevExpre.mensajeExitoso("Valor exento eliminado correctamente!")

                    LimpiarCampos()
                    LlenaGrillaValorExentos()
                ElseIf response.EsAdvertencia Then
                    HDevExpre.MensagedeError("Error al eiminar la ValorExento!")
                Else ' Es Error
                    HDevExpre.MensagedeError("Error al eiminar la ValorExento!")
                End If
            End If

        Else
            HDevExpre.MensagedeError("Error al eiminar la ValorExento!")
        End If
    End Sub
#End Region


    Private Sub FrmAggValorExento_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        LimpiarCampos()
        Buscando = False
        txtNoBuscando()
    End Sub


    Private Sub grbVigente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles grbVigente.KeyPress, grbTipoValor.KeyPress
        HDevExpre.AvanzaConEnter(e)
    End Sub

    Private Sub grbgrbTipoValor_Enter(sender As Object, e As EventArgs) Handles grbTipoValor.Enter
        HDevExpre.EntraControlRadioGroup(grbTipoValor, )
        FrmPrincipal.MensajeDeAyuda.Caption = "Tipo de Valor (Valor Fijo, Porcentaje). (ENTER)=Avanzar;(ESC,ARB)=Atras"
        FrmPrincipal.MensajeDeAyuda.Refresh()
    End Sub

    Private Sub grbgrbTipoValor_Leave(sender As Object, e As EventArgs) Handles grbTipoValor.Leave
        HDevExpre.SaleControlRadioGroup(grbTipoValor, )
        FrmPrincipal.MensajeDeAyuda.Caption = ""
        FrmPrincipal.MensajeDeAyuda.Refresh()
    End Sub

    Private Sub grbgrbTipoValor_Click(sender As Object, e As EventArgs) Handles grbTipoValor.Click
        FrmPrincipal.MensajeDeAyuda.Caption = "Tipo de Valor (Valor Fijo, Porcentaje). (ENTER)=Avanzar;(ESC,ARB)=Atras"
        FrmPrincipal.MensajeDeAyuda.Refresh()
    End Sub

    Private Sub grbVigente_Enter(sender As Object, e As EventArgs) Handles grbVigente.Enter
        HDevExpre.EntraControlRadioGroup(grbVigente, lblVigente)
        FrmPrincipal.MensajeDeAyuda.Caption = "Estado del Valor Exento. (ENTER)=Avanzar;(ESC,ARB)=Atras"
        FrmPrincipal.MensajeDeAyuda.Refresh()
    End Sub

    Private Sub grbVigente_Leave(sender As Object, e As EventArgs) Handles grbVigente.Leave
        HDevExpre.SaleControlRadioGroup(grbVigente, lblVigente)
        FrmPrincipal.MensajeDeAyuda.Caption = ""
        FrmPrincipal.MensajeDeAyuda.Refresh()
    End Sub

    Private Sub grbVigente_Click(sender As Object, e As EventArgs) Handles grbVigente.Click
        FrmPrincipal.MensajeDeAyuda.Caption = "Estado del Valor Exento. (ENTER)=Avanzar;(ESC,ARB)=Atras"
        FrmPrincipal.MensajeDeAyuda.Refresh()
    End Sub

    Private Sub btnSalir_KeyPress(sender As Object, e As KeyPressEventArgs) Handles btnSalir.KeyPress, btnLimpiar.KeyPress, btnGuardar.KeyPress, btnEliminar.KeyPress
        HDevExpre.AtrasConScape(e)
    End Sub
End Class