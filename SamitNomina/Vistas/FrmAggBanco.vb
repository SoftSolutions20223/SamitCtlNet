Imports SamitCtlNet
Imports Newtonsoft.Json.Linq
Imports SamitNominaLogic

Public Class FrmAggBanco
    Dim EstaActualizando As Boolean = False
    Dim secReg As Integer = 0

    Dim FormularioAbierto As Boolean = False
    Dim HDevExpre As New HelperDevExpress
    Dim HNomina As New HelperNomina
    Dim Banco As New Bancos
    Public Property P_FormularioAbierto() As Boolean
        Get
            Return FormularioAbierto
        End Get
        Set(value As Boolean)
            FormularioAbierto = value
        End Set
    End Property

    Private Sub FrmAggBanco_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AcomodaForm()
        CreaGrilla()
        LlenaGrilla()
        txtNombre.MensajedeAyuda = "Digite el nombre del banco que desea agregar. (ENTER,TAB)=Avanzar"
        txtNombre.MaximoAncho = AnchoCampoSql(ObjetoApiNomina, "CAT_Bancos", "Nombre")
    End Sub
#Region "Eventos controles"
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try

            Dim sec As Integer = 0
            If EstaActualizando Then sec = secReg
            If GuardarBanco(sec) Then
                LlenaGrilla()
                If EstaActualizando Then HDevExpre.mensajeExitoso("Información actualizada correctamente!") Else HDevExpre.mensajeExitoso("Información guardada correctamente!")
                LimpiarCampos()
            End If

        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "btnGuardar_Click")
        End Try
    End Sub

    Private Sub gvBancoes_DoubleClick(sender As Object, e As EventArgs) Handles gvBancos.DoubleClick
        Try
            Dim fila As String = HDevExpre.ValidaDobleClicSobreFila(gvBancos)
            If fila <> "" Then
                CargarDatos(CInt(fila))
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub grbVigente_Enter(sender As Object, e As EventArgs) Handles rgVigente.Enter
        HDevExpre.EntraControlRadioGroup(rgVigente, lblVigente, rgVigente.Font.Size, lblVigente.Font.Size)
        FrmPrincipal.MensajeDeAyuda.Caption = "Estado del Banco. (ENTER)=Avanzar;(ESC,ARB)=Atras"
        FrmPrincipal.MensajeDeAyuda.Refresh()
    End Sub

    Private Sub rgVigente_Leave(sender As Object, e As EventArgs) Handles rgVigente.Leave
        HDevExpre.SaleControlRadioGroup(rgVigente, lblVigente, rgVigente.Font.Size, lblVigente.Font.Size)
        FrmPrincipal.MensajeDeAyuda.Caption = ""
        FrmPrincipal.MensajeDeAyuda.Refresh()
    End Sub
    Private Sub rgVigente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rgVigente.KeyPress
        HDevExpre.AvanzaConEnter(e)
    End Sub
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If Not EstaActualizando Or secReg = 0 Then
                HDevExpre.MensagedeError("No ha cargado ningun banco para ser eliminado.")
                Exit Sub
            End If

            If HDevExpre.MsgSamit("Seguro que desea eliminar el banco seleccionado?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.OK Then
                ' Crear el request usando EliminarBancoRequest (coherente con el proyecto)
                Dim request As New EliminarBancoRequest(secReg)

                ' Ejecutar el procedimiento almacenado
                Dim resp = SMT_EjecutaProcedimientos(ObjetoApiNomina, "SP_EliminarBanco", request.ToJObject())
                Dim response = resp.ToObject(Of DynamicDeleteResponse)()

                ' Procesar respuesta
                If response.EsExitoso Then
                    ' Éxito - limpiar y recargar
                    HDevExpre.mensajeExitoso(response.Mensaje)
                    LimpiarCampos()
                    LlenaGrilla()

                ElseIf response.EsAdvertencia Then
                    ' Advertencia (no existe o no seleccionado)
                    HDevExpre.MensagedeError(response.Mensaje)

                Else ' Es Error
                    ' Error (asociado a empleados u otro problema)
                    HDevExpre.MensagedeError(response.Mensaje)
                End If
            End If

        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "btnEliminar_Click")
        End Try
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarCampos()
    End Sub

    Private Sub FrmAggBanco_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        LimpiarCampos()
    End Sub

#End Region
#Region "Funciones y procedimientos"
    Private Sub AcomodaForm()
        Try
            btnGuardar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Guardar)
            btnEliminar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Eliminar)
            btnLimpiar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Limpiar)
            btnSalir.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.SalirCuadroConX)
            txtNombre.Focus()
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "FrmAggBanco_Load")
        End Try
    End Sub
    Private Sub CreaGrilla()
        Try
            gvBancos.Columns.Clear()
            HDevExpre.CreaColumnasG(gvBancos, "Sec", "Sec", False, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 0, 0)
            HDevExpre.CreaColumnasG(gvBancos, "Nombre", "Nombre", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 80, gbxPrincipal.Width)
            HDevExpre.CreaColumnasG(gvBancos, "Vigente", "Vigente", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 20, gbxPrincipal.Width)
            gvBancos.OptionsView.ShowFooter = True
            gvBancos.Appearance.HeaderPanel.Font = New Font("Trebuchet MS", 11.0!, FontStyle.Bold)
            gvBancos.Columns(2).Summary.Add(DevExpress.Data.SummaryItemType.Count, "", "{0}  Registros")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LlenaGrilla()
        Try
            Dim dt As DataTable = SMT_AbrirTabla(ObjetoApiNomina, "SELECT Sec,Nombre, CAST(CASE WHEN Vigente=1 THEN 'Si' WHEN Vigente=0 THEN 'No' END AS VARCHAR) AS Vigente FROM CAT_Bancos  ")
            gcBancos.DataSource = dt
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "LlenaGrilla")
        End Try
    End Sub
    Private Function ValidaCampos() As Boolean
        If txtNombre.ValordelControl = "" Then
            HDevExpre.MensagedeError("Por favor seleccione el tipo de banco.")
            txtNombre.Focus()
            Return False
        ElseIf rgVigente.SelectedIndex = -1 Then
            HDevExpre.MensagedeError("Por favor seleccione si el banco esta vigente.")
            rgVigente.Focus()
            Return False
        Else
            Return True
        End If
    End Function

    Private Function GuardarBanco(Sec As Integer) As Boolean
        Try

            Banco = New Bancos
            Banco.Nombre = txtNombre.ValordelControl
            Banco.Sec = Sec
            Banco.Vigente = CBool(rgVigente.SelectedIndex)
            Dim RegBanco As New ServiceBancos
            Dim registro As DynamicUpsertResponseDto
            If RegBanco.ValidarCampos(Banco) Then
                registro = RegBanco.UpsertBancos(Banco)
            End If
            If registro.ErrorCount < 1 Then
                Return True
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "GuardarBanco")
            Return False
        End Try
    End Function
    Private Sub LimpiarCampos()
        txtNombre.ValordelControl = ""
        EstaActualizando = False
        secReg = 0
        txtNombre.Focus()
    End Sub

    Private Sub CargarDatos(numFila As Integer)
        Try
            rgVigente.SelectedIndex = 0
            txtNombre.ValordelControl = gvBancos.GetDataRow(numFila)("Nombre").ToString
            If gvBancos.GetDataRow(numFila)("Vigente").ToString = "Si" Then rgVigente.SelectedIndex = 1
            secReg = CInt(gvBancos.GetDataRow(numFila)("Sec"))
            txtNombre.Focus()
            EstaActualizando = True
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "CargarDatos")
        End Try
    End Sub

#End Region


    Private Sub txtNombre_Leave(sender As Object, e As EventArgs) Handles txtNombre.Leave
        'If rgVigente.Focus Then
        '    Dim send As New Object
        '    Dim evento As New EventArgs
        '    rgVigente_Click(send, evento)
        'End If
    End Sub

    Private Sub rgVigente_Click(sender As Object, e As EventArgs) Handles rgVigente.Click
        FrmPrincipal.MensajeDeAyuda.Caption = "Estado del Banco. (ENTER)=Avanzar;(ESC,ARB)=Atras"
        FrmPrincipal.MensajeDeAyuda.Refresh()
    End Sub

    Private Sub btnSalir_KeyPress(sender As Object, e As KeyPressEventArgs) Handles btnSalir.KeyPress, btnLimpiar.KeyPress, btnGuardar.KeyPress, btnEliminar.KeyPress
        HDevExpre.AtrasConScape(e)
    End Sub
End Class