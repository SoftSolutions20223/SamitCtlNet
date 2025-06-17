Imports SamitCtlNet
Public Class FrmTipoDoc
    Dim estaActualizando As Boolean = False
    Dim _idTipoDoc As String = ""
    Dim HDevExpre As New HelperDevExpress
    Dim HNomina As New HelperNomina
    Private Sub FrmTipoDoc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            btnGuardar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Guardar)
            btnEliminar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Eliminar)
            btnSalir.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.SalirCuadroConX)
            btnLimpiar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Limpiar)
            txtNombre.MaximoAncho = 50
            txtIdTipoDoc.MaximoAncho = 4
            CreaGrilla()
            LlenaGrilla()
            txtIdTipoDoc.Focus()
            txtIdTipoDoc.Select()
            txtIdTipoDoc.MensajedeAyuda = "Digite el ID del tipo de documento. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras;"
            txtNombre.MensajedeAyuda = "Digite el nombre del tipo de documento. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras;"
            txtIdTipoDoc.MaximoAncho = AnchoCampoSql(ObjetoApiNomina, "CAT_TiposId", "TipoIdentificacion")
            txtNombre.MaximoAncho = AnchoCampoSql(ObjetoApiNomina, "CAT_TiposId", "NomTipo")
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "load")
        End Try
    End Sub
#Region "Eventos Controles"
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If txtIdTipoDoc.ValordelControl = "" Then
                HDevExpre.MensagedeError("El ID del tipo de documento no puede estar vacío!")
                txtIdTipoDoc.Focus()
                Exit Sub
            ElseIf txtNombre.ValordelControl = "" Then
                HDevExpre.MensagedeError("El nombre del tipo de documento no puede estar vacío!")
                txtNombre.Focus()
                Exit Sub

            End If
            If GuardaRegistro(txtIdTipoDoc.ValordelControl, txtNombre.ValordelControl, CBool(rgUsaEmpleados.SelectedIndex), CBool(rgUsaParientes.SelectedIndex), estaActualizando) Then
                LlenaGrilla()
                If estaActualizando Then HDevExpre.mensajeExitoso("Información actualizada correctamente!") Else HDevExpre.mensajeExitoso("Información guardada correctamente!")
                LimpiarCampos()
                End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "btnGuardar_Click")
        End Try
    End Sub

    Private Sub rgUsaEmpleados_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rgUsaParientes.KeyPress, rgUsaEmpleados.KeyPress
        HDevExpre.AvanzaConEnter(e)
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
            If gvEstadoCivil.Columns.Count = 0 Then Exit Sub
            'Distribuye los anchos de columnas en el gv de los productos de la receta
            gvEstadoCivil.Columns("TipoIdentificacion").Width = CInt((15 * (gbxPrincipal.Width - 20)) / 100)
            gvEstadoCivil.Columns("NomTipo").Width = CInt((63 * (gbxPrincipal.Width - 20)) / 100)
            gvEstadoCivil.Columns("UsaEmpleados").Width = CInt((10 * (gbxPrincipal.Width - 20)) / 100)
            gvEstadoCivil.Columns("UsaParientes").Width = CInt((10 * (gbxPrincipal.Width - 20)) / 100)
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "gbxPrincipal_SizeChanged")
        End Try
    End Sub

    Private Sub gvCatLicencia_DoubleClick(sender As Object, e As EventArgs) Handles gvEstadoCivil.DoubleClick
        Try
            Dim fila As String = HDevExpre.ValidaDobleClicSobreFila(gvEstadoCivil)
            If fila <> "" Then
                CargarDatos(CInt(fila))
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub rgVigente_KeyPress(sender As Object, e As KeyPressEventArgs)
        HDevExpre.AvanzaConEnter(e)
    End Sub

    Private Sub rgUsaEmpleados_Enter(sender As Object, e As EventArgs) Handles rgUsaEmpleados.Enter
        HDevExpre.EntraControlRadioGroup(rgUsaEmpleados, lblUsaEmpleado, lblUsaEmpleado.Font.Size)
        FrmPrincipal.MensajeDeAyuda.Caption = "Seleccione si el tipo de documento será utilizado por empleados. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras;"
    End Sub

    Private Sub rgUsaEmpleados_Leave(sender As Object, e As EventArgs) Handles rgUsaEmpleados.Leave
        HDevExpre.SaleControlRadioGroup(rgUsaEmpleados, lblUsaEmpleado, lblUsaEmpleado.Font.Size)
        FrmPrincipal.MensajeDeAyuda.Caption = ""
    End Sub

    Private Sub rgUsaParientes_Enter(sender As Object, e As EventArgs) Handles rgUsaParientes.Enter
        HDevExpre.EntraControlRadioGroup(rgUsaParientes, lblUsaPariente, lblUsaPariente.Font.Size)
        FrmPrincipal.MensajeDeAyuda.Caption = "Seleccione si el tipo de documento será utilizado por parientes de los empleados. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras;"
    End Sub

    Private Sub rgUsaParientes_Leave(sender As Object, e As EventArgs) Handles rgUsaParientes.Leave
        HDevExpre.SaleControlRadioGroup(rgUsaParientes, lblUsaPariente, lblUsaPariente.Font.Size)
        FrmPrincipal.MensajeDeAyuda.Caption = ""
    End Sub

#End Region
#Region "Funciones y procedimientos"
    Private Sub CreaGrilla()
        Try
            gvEstadoCivil.Columns.Clear()

            HDevExpre.CreaColumnasG(gvEstadoCivil, "TipoIdentificacion", "Tipo ID", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 15, gbxPrincipal.Width)
            HDevExpre.CreaColumnasG(gvEstadoCivil, "NomTipo", "Nombre", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 50, gbxPrincipal.Width)
            HDevExpre.CreaColumnasG(gvEstadoCivil, "UsaEmpleados", "Para empleados", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 17, gbxPrincipal.Width)
            HDevExpre.CreaColumnasG(gvEstadoCivil, "UsaParientes", "Para parientes", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 16, gbxPrincipal.Width)
            gvEstadoCivil.Appearance.HeaderPanel.Font = New Font("Trebuchet MS", 11.0!, FontStyle.Bold)
            gvEstadoCivil.Columns(gvEstadoCivil.Columns.Count - 1).Summary.Add(DevExpress.Data.SummaryItemType.Count, "", "{0}  Registros")
            gvEstadoCivil.OptionsView.ShowFooter = True
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "CreaGrilla")
        End Try
    End Sub

    Private Sub LlenaGrilla()
        Try
            Dim sql As String = "SELECT * FROM CAT_TiposId"
            Dim dt As DataTable = SMT_AbrirTabla(ObjetoApiNomina, sql)
            gcEstadoCivil.DataSource = dt
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "LlenaGrilla")
        End Try
    End Sub

    Private Function GuardaRegistro(TipoIdentificacion As String, NomTipo As String, UsaEmpleados As Boolean, UsaParientes As Boolean, Actualizando As Boolean) As Boolean
        Try
            Dim GenSql As New SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL
            GenSql.PasoConexionTabla(ObjetoApiNomina, "CAT_TiposId")
            GenSql.PasoValores("NomTipo", NomTipo, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            GenSql.PasoValores("UsaEmpleados", UsaEmpleados.ToString, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            GenSql.PasoValores("UsaParientes", UsaParientes.ToString, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            If Not Actualizando Then
                GenSql.PasoValores("TipoIdentificacion", TipoIdentificacion, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
                If Not GenSql.EjecutarComandoNET(SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.SQLGenera.Insercion, "") Then Return False
            Else
                If Not GenSql.EjecutarComandoNET(SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.SQLGenera.Actualizacion, String.Format("TipoIdentificacion='{0}'", TipoIdentificacion)) Then Return False
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
            txtIdTipoDoc.ValordelControl = ""
            rgUsaEmpleados.SelectedIndex = 1
            rgUsaParientes.SelectedIndex = 1
            _idTipoDoc = ""
            estaActualizando = False
            txtNombre.Focus()
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "LimpiarCampos")
        End Try
    End Sub

    Private Sub CargarDatos(numFila As Integer)
        Try
            If numFila < 0 Then Exit Sub
            txtNombre.ValordelControl = gvEstadoCivil.GetDataRow(numFila)("NomTipo").ToString
            txtIdTipoDoc.ValordelControl = gvEstadoCivil.GetDataRow(numFila)("TipoIdentificacion").ToString
            If CBool(gvEstadoCivil.GetDataRow(numFila)("UsaEmpleados")) Then rgUsaEmpleados.SelectedIndex = 1 Else rgUsaEmpleados.SelectedIndex = 0
            If CBool(gvEstadoCivil.GetDataRow(numFila)("UsaParientes")) Then rgUsaParientes.SelectedIndex = 1 Else rgUsaParientes.SelectedIndex = 0
            _idTipoDoc = gvEstadoCivil.GetDataRow(numFila)("TipoIdentificacion").ToString
            estaActualizando = True
            txtIdTipoDoc.Focus()
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "CargarDatos")
        End Try
    End Sub
    Private Sub EliminaRegisto()
        Try
            If Not estaActualizando Then Exit Sub
            If Not ValidaSiCatEstaEnEmpleado() Then Exit Sub
            If HDevExpre.MsgSamit("Seguro que desea eliminar el registro seleccionado?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.OK Then
                SMT_EjcutarComandoSql(ObjetoApiNomina, String.Format("DELETE FROM CAT_TiposId WHERE TipoIdentificacion = '{0}'", _idTipoDoc), 0)
                LlenaGrilla()
                LimpiarCampos()
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "EliminaRegisto")
        End Try
    End Sub
    Private Function ValidaSiCatEstaEnEmpleado() As Boolean
        Try
            Dim dt As DataTable = SMT_AbrirTabla(ObjetoApiNomina, String.Format("SELECT * FROM Empleados WHERE TipoIdentificacion = '{0}'", _idTipoDoc))
            If dt.Rows.Count > 0 Then
                HDevExpre.MensagedeError("El tipo de documento seleccionada se encuentra asociado a un empleado, imposible eliminar.")
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