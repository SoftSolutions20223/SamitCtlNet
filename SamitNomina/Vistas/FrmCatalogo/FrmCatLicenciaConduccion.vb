Imports SamitCtlNet
Public Class FrmCatLicenciaConduccion
    Dim estaActualizando As Boolean = False
    Dim _idClase As String = ""
    Dim HDevExpre As New HelperDevExpress
    Dim HNomina As New HelperNomina
    Private Sub FrmCatLicenciaConduccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            rgVigente.SelectedIndex = 1
            btnGuardar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Guardar)
            btnEliminar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Eliminar)
            btnSalir.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.SalirCuadroConX)
            btnLimpiar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Limpiar)
            txtNombre.MaximoAncho = 350
            txtIdClase.MaximoAncho = 10
            CreaGrilla()
            LlenaGrilla()
            txtNombre.Focus()
            txtNombre.Select()
            txtNombre.MensajedeAyuda = "Digite el nombre de la categoria de licencia de conducción. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
            txtIdClase.MensajedeAyuda = "Digite el ID de la categoria de licencia de conducción. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
            txtNombre.MaximoAncho = AnchoCampoSql(ObjetoApiNomina, "CAT_ClaseLicencia", "NomClase")
            txtIdClase.MaximoAncho = AnchoCampoSql(ObjetoApiNomina, "CAT_ClaseLicencia", "idClase")
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "load")
        End Try
    End Sub

#Region "Eventos Controles"

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If txtNombre.ValordelControl = "" Then
                HDevExpre.MensagedeError("El nombre de la categoria no puede estar vacío!")
                txtNombre.Focus()
                Exit Sub
            ElseIf txtIdClase.ValordelControl = "" Then
                HDevExpre.MensagedeError("El ID de la categoria no puede estar vacío!")
                txtIdClase.Focus()
                Exit Sub
            End If
            If GuardaRegistro(txtIdClase.ValordelControl, txtNombre.ValordelControl, CBool(rgVigente.SelectedIndex), estaActualizando) Then
                LlenaGrilla()
                If estaActualizando Then HDevExpre.mensajeExitoso("Información actualizada correctamente!") Else HDevExpre.mensajeExitoso("Información guardada correctamente!")
                LimpiarCampos()
                End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "btnGuardar_Click")
        End Try
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarCampos()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        EliminaRegisto()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub


    Private Sub gbxPrincipal_SizeChanged(sender As Object, e As EventArgs) Handles gbxPrincipal.SizeChanged
        Try
            If gvCatLicencia.Columns.Count = 0 Then Exit Sub
            'Distribuye los anchos de columnas en el gv de los productos de la receta
            gvCatLicencia.Columns("idClase").Width = CInt((20 * (gbxPrincipal.Width - 20)) / 100)
            gvCatLicencia.Columns("NomClase").Width = CInt((58 * (gbxPrincipal.Width - 20)) / 100)
            gvCatLicencia.Columns("Vigente").Width = CInt((20 * (gbxPrincipal.Width - 20)) / 100)
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "gbxPrincipal_SizeChanged")
        End Try
    End Sub

    Private Sub gvCatLicencia_DoubleClick(sender As Object, e As EventArgs) Handles gvCatLicencia.DoubleClick
        Try
            Dim fila As String = HDevExpre.ValidaDobleClicSobreFila(gvCatLicencia)
            If fila <> "" Then
                CargarDatos(CInt(fila))
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub rgVigente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rgVigente.KeyPress
        HDevExpre.AvanzaConEnter(e)
    End Sub
    Private Sub rgVigente_Enter(sender As Object, e As EventArgs) Handles rgVigente.Enter
        HDevExpre.EntraControlRadioGroup(rgVigente, lblVigente, lblVigente.Font.Size)
    End Sub

    Private Sub rgVigente_Leave(sender As Object, e As EventArgs) Handles rgVigente.Leave
        HDevExpre.SaleControlRadioGroup(rgVigente, lblVigente, lblVigente.Font.Size)
    End Sub
#End Region

#Region "Funciones y procedimientos"

    Private Sub CreaGrilla()
        Try
            gvCatLicencia.Columns.Clear()

            HDevExpre.CreaColumnasG(gvCatLicencia, "idClase", "Id Clase", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 20, gbxPrincipal.Width)
            HDevExpre.CreaColumnasG(gvCatLicencia, "NomClase", "Nombre", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 58, gbxPrincipal.Width)
            HDevExpre.CreaColumnasG(gvCatLicencia, "Vigente", "Vigente", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 20, gbxPrincipal.Width)
            gvCatLicencia.Appearance.HeaderPanel.Font = New Font("Trebuchet MS", 11.0!, FontStyle.Bold)
            gvCatLicencia.Columns(gvCatLicencia.Columns.Count - 1).Summary.Add(DevExpress.Data.SummaryItemType.Count, "", "{0}  Registros")
            gvCatLicencia.OptionsView.ShowFooter = True
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "CreaGrilla")
        End Try
    End Sub

    Private Sub LlenaGrilla()
        Try
            Dim sql As String = "SELECT * FROM CAT_ClaseLicencia"
            Dim dt As DataTable = SMT_AbrirTabla(ObjetoApiNomina, sql)
            gcCatLicencia.DataSource = dt
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "LlenaGrilla")
        End Try
    End Sub

    Private Function GuardaRegistro(idClase As String, NomClase As String, Vigente As Boolean, Actualizando As Boolean) As Boolean
        Try
            Dim GenSql As New SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL
            GenSql.PasoConexionTabla(ObjetoApiNomina, "CAT_ClaseLicencia")
            GenSql.PasoValores("NomClase", NomClase, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            GenSql.PasoValores("Vigente", Vigente.ToString, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            If Not Actualizando Then
                GenSql.PasoValores("idClase", idClase, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
                If Not GenSql.EjecutarComandoNET(SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.SQLGenera.Insercion, "") Then Return False
            Else
                If Not GenSql.EjecutarComandoNET(SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.SQLGenera.Actualizacion, String.Format("idClase='{0}'", idClase)) Then Return False
            End If
            Return True
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "GuardaRegistro")
            Return False
        End Try
    End Function

    Private Sub LimpiarCampos()
        Try
            txtNombre.ValordelControl = ""
            txtIdClase.ValordelControl = ""
            rgVigente.SelectedIndex = 1
            _idClase = ""
            estaActualizando = False
            txtNombre.Focus()
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "LimpiarCampos")
        End Try
    End Sub

    Private Sub CargarDatos(numFila As Integer)
        Try
            If numFila < 0 Then Exit Sub
            txtNombre.ValordelControl = gvCatLicencia.GetDataRow(numFila)("NomClase").ToString
            txtIdClase.ValordelControl = gvCatLicencia.GetDataRow(numFila)("idClase").ToString
            If CBool(gvCatLicencia.GetDataRow(numFila)("Vigente")) Then rgVigente.SelectedIndex = 1 Else rgVigente.SelectedIndex = 0
            _idClase = gvCatLicencia.GetDataRow(numFila)("idClase").ToString
            estaActualizando = True
            txtNombre.Focus()
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "CargarDatos")
        End Try
    End Sub
    Private Sub EliminaRegisto()
        Try
            If Not estaActualizando Then Exit Sub
            If Not ValidaSiCatEstaEnEmpleado() Then Exit Sub
            If HDevExpre.MsgSamit("Seguro que desea eliminar el registro seleccionado?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.OK Then
                SMT_EjcutarComandoSql(ObjetoApiNomina, String.Format("DELETE FROM CAT_ClaseLicencia WHERE idClase='{0}'", _idClase), 0)
                LlenaGrilla()
                LimpiarCampos()
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "EliminaRegisto")
        End Try
    End Sub
    Private Function ValidaSiCatEstaEnEmpleado() As Boolean
        Try
            Dim dt As DataTable = SMT_AbrirTabla(ObjetoApiNomina, String.Format("SELECT * FROM Empleados WHERE LicCategoria ='{0}'", _idClase))
            If dt.Rows.Count > 0 Then
                HDevExpre.MensagedeError("La categoría seleccionada se encuentra asociada a un empleado, imposible eliminar.")
                Return False
            Else : Return True
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "ValidaSiCatEstaEnEmpleado")
            Return False
        End Try
    End Function
#End Region

End Class