Imports Newtonsoft.Json.Linq
Imports SamitCtlNet
Imports SamitNominaLogic

Public Class FrmAggEntidad
    Dim EstaActualizando As Boolean = False
    Dim secReg As Integer = 0
    Dim HDevExpre As New HelperDevExpress
    Dim HNomina As New HelperNomina
    Dim Entidades As New EntesSSAP
    Private Sub FrmAggEntidad_Load(sender As Object, e As EventArgs) Handles Me.Load
        AcomodaForm()
        CreaGrilla()
        LlenaGrilla()
        txtTipoEntidad.MensajedeAyuda = "Selecione el tipo de Entidad. (ENTER,ABJ)=Avanzar"
        txtCtaPasivo.MensajedeAyuda = "Seleccione la cuenta Pasivo. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
        txtNit.MensajedeAyuda = "Digite el Nit de la Entidad. (ENTER,TAB,ABJ)=Avanzar;(ARB,ESC)=Atras"
        txtNombre.MensajedeAyuda = "Digite el nombre de la Entidad. (ENTER,TAB,ABJ)=Avanzar;(ARB,ESC)=Atras"
        txtNombre.MaximoAncho = AnchoCampoSql(ObjetoApiNomina, "EntesSSAP", "NombreEntidad")
    End Sub

    Dim FormularioAbierto As Boolean = False
    Public Property P_FormularioAbierto() As Boolean
        Get
            Return FormularioAbierto
        End Get
        Set(value As Boolean)
            FormularioAbierto = value
        End Set
    End Property

    Private Sub AcomodaForm()
        Try

            txtTipoEntidad.ConsultaSQL = String.Format("SELECT CodTipoEnte AS Codigo, NomTipoEnte AS Descripcion FROM ZenumTipoEntes")
            txtCtaPasivo.ConsultaSQL = "SELECT CodCuenta AS Codigo, NomCuenta AS Descripcion " &
                                       " FROM CT_PlandeCuentas WHERE EsdeMovimiento=1 AND Estado='V'"

            btnGuardar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Guardar)
            btnEliminar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Eliminar)
            btnLimpiar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Limpiar)
            btnSalir.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.SalirCuadroConX)
            grbVigente.SelectedIndex = 1
            txtTipoEntidad.Focus()
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "FrmAggEntidad_Load")
        End Try
    End Sub
    Private Sub CreaGrilla()
        Try
            gvEntidades.Columns.Clear()

            HDevExpre.CreaColumnasG(gvEntidades, "Sec", "Sec", False, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 0, 0)
            HDevExpre.CreaColumnasG(gvEntidades, "TipoEnte", "TipoEnte", False, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 0, 0)
            HDevExpre.CreaColumnasG(gvEntidades, "Nit", "Nit. ", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 20, gbxPrincipal.Width)
            HDevExpre.CreaColumnasG(gvEntidades, "NombreEntidad", "Nombre", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 40, gbxPrincipal.Width)
            HDevExpre.CreaColumnasG(gvEntidades, "Estado", "Activo", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 18, gbxPrincipal.Width)
            HDevExpre.CreaColumnasG(gvEntidades, "CuentaPasivo", "Cuenta Pasivo", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 20, gbxPrincipal.Width)
            gvEntidades.OptionsView.ShowFooter = True
            gvEntidades.Appearance.HeaderPanel.Font = New Font("Trebuchet MS", 11.0!, FontStyle.Bold)
            gvEntidades.Columns(6).Summary.Add(DevExpress.Data.SummaryItemType.Count, "", "{0}  Registros")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LlenaGrilla()
        Try
            Dim dt As DataTable = SMT_AbrirTabla(ObjetoApiNomina, "SELECT Sec,TipoEnte,Sec,Nit,NombreEntidad, CAST(CASE WHEN Estado='A' THEN 'Si' " +
                                                 " WHEN Estado='I' THEN 'No' END AS VARCHAR) AS Estado,CuentaPasivo FROM EntesSSAP ")
            gcEntidades.DataSource = dt
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "LlenaGrilla")
        End Try
    End Sub
    Private Function ValidaCampos() As Boolean
        If txtTipoEntidad.ValordelControl = "" Then
            HDevExpre.MensagedeError("Por favor seleccione el tipo de entidad.")
            txtTipoEntidad.Focus()
            Return False
        ElseIf txtCtaPasivo.ValordelControl = "" Then
            HDevExpre.MensagedeError("Por favor seleccione la cuenta pasivo.")
            txtCtaPasivo.Focus()
            Return False
        ElseIf txtNit.ValordelControl = "" Then
            HDevExpre.MensagedeError("Por favor digite el nit de la empresa.")
            txtNit.Focus()
            Return False
        ElseIf txtNombre.ValordelControl = "" Then
            HDevExpre.MensagedeError("Por favor digite el nombre de la empresa.")
            txtNombre.Focus()
            Return False
        ElseIf grbVigente.SelectedIndex = -1 Then
            HDevExpre.MensagedeError("Por favor seleccione si la estidad esta vigente.")
            grbVigente.Focus()
            Return False
        Else
            Return True
        End If
    End Function

    Private Function GuardarEntidad(TipoEnte As Integer, CodEnte As Integer, nit As String, NombreEntidad As String,
                                    Estado As String, CuentaPasivo As String) As Boolean
        Try
            Entidades = New EntesSSAP
            Entidades.NombreEntidad = NombreEntidad
            Entidades.Sec = CodEnte
            Entidades.Nit = nit
            Entidades.TipoEnte = TipoEnte
            Entidades.CuentaPasivo = CuentaPasivo
            Entidades.Estado = Estado
            Dim RegEntidades As New ServiceEntidades
            Dim registro As DynamicUpsertResponseDto
            If RegEntidades.ValidarCampos(Entidades) Then
                registro = RegEntidades.UpsertEntidad(Entidades)
            End If
            If registro.ErrorCount < 1 Then
                Return True
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "GuardarEntidad")
            Return False
        End Try
    End Function
    Private Sub LimpiarCampos()
        txtTipoEntidad.ValordelControl = ""
        txtNombre.ValordelControl = ""
        txtNit.ValordelControl = ""
        txtCtaPasivo.ValordelControl = ""
        grbVigente.SelectedIndex = 1
        txtCtaPasivo.TieneErrorControl = False
        EstaActualizando = False
        secReg = 0
        txtTipoEntidad.Focus()
    End Sub

    Private Sub CargarDatos(numFila As Integer)
        Try
            grbVigente.SelectedIndex = 0
            txtTipoEntidad.ValordelControl = gvEntidades.GetDataRow(numFila)("TipoEnte").ToString
            txtCtaPasivo.ValordelControl = gvEntidades.GetDataRow(numFila)("CuentaPasivo").ToString
            txtNit.ValordelControl = gvEntidades.GetDataRow(numFila)("Nit").ToString
            txtNombre.ValordelControl = gvEntidades.GetDataRow(numFila)("NombreEntidad").ToString
            If gvEntidades.GetDataRow(numFila)("Estado").ToString = "Si" Then grbVigente.SelectedIndex = 1
            secReg = CInt(gvEntidades.GetDataRow(numFila)("Sec"))
            txtCtaPasivo.RefrescarDatos()
            txtTipoEntidad.Focus()
            EstaActualizando = True
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "CargarDatos")
        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If ValidaCampos() Then
                Dim codEnte As Integer
                Dim vig As Char = "I"c
                codEnte = CInt(secReg)
                If grbVigente.SelectedIndex = 1 Then vig = "A"c
                If GuardarEntidad(CInt(txtTipoEntidad.ValordelControl), codEnte, txtNit.ValordelControl,
                                  txtNombre.ValordelControl, vig.ToString, txtCtaPasivo.ValordelControl) Then
                    LlenaGrilla()
                    If EstaActualizando Then HDevExpre.mensajeExitoso("Información actualizada correctamente!") Else HDevExpre.mensajeExitoso("Información guardada correctamente!")
                    LimpiarCampos()
                End If
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "btnGuardar_Click")
        End Try
    End Sub

    Private Sub grbVigente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles grbVigente.KeyPress
        HDevExpre.AvanzaConEnter(e)
    End Sub

    Private Sub grbVigente_Enter(sender As Object, e As EventArgs) Handles grbVigente.Enter
        HDevExpre.EntraControlRadioGroup(grbVigente, lblVigente)
        FrmPrincipal.MensajeDeAyuda.Caption = " Seleccione si la entidad se encuenta vigente. (ENTER,TAB,ABJ)=Avanzar;(ARB,ESC)=Atras"
    End Sub

    Private Sub grbVigente_Leave(sender As Object, e As EventArgs) Handles grbVigente.Leave
        HDevExpre.SaleControlRadioGroup(grbVigente, lblVigente)
    End Sub

    Private Sub gvEntidades_DoubleClick(sender As Object, e As EventArgs) Handles gvEntidades.DoubleClick
        Try
            Dim fila As String = HDevExpre.ValidaDobleClicSobreFila(gvEntidades)
            If fila <> "" Then
                CargarDatos(CInt(fila))
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If Not EstaActualizando Or secReg = 0 Then
                HDevExpre.MensagedeError("No ha cargado ninguna entidad para ser eliminada.")
                Exit Sub
            End If
            If HDevExpre.MsgSamit("Seguro que desea eliminar la entidad seleccionada?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.OK Then
                Entidades = New EntesSSAP
                Entidades.Sec = secReg

                Dim RegEntidades As New ServiceEntidades
                Dim registro As JArray
                registro = RegEntidades.EliminarEntidad(Entidades)
                LimpiarCampos()
                LlenaGrilla()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarCampos()
    End Sub

    Private Sub FrmAggEntidad_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        LimpiarCampos()
    End Sub

    Private Sub btnSalir_KeyPress(sender As Object, e As KeyPressEventArgs) Handles btnSalir.KeyPress, btnLimpiar.KeyPress, btnGuardar.KeyPress, btnEliminar.KeyPress
        HDevExpre.AtrasConScape(e)
    End Sub


End Class