Imports SamitCtlNet
Public Class FrmEstadoCivil
    Dim estaActualizando As Boolean = False
    Dim _idEstado As UShort = 0
    Dim HDevExpre As New HelperDevExpress
    Dim HNomina As New HelperNomina
    Private Sub FrmEstadoCivil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            btnGuardar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Guardar)
            btnEliminar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Eliminar)
            btnSalir.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.SalirCuadroConX)
            btnLimpiar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Limpiar)
            txtNombre.MaximoAncho = 50
            CreaGrilla()
            LlenaGrilla()
            txtNombre.Focus()
            txtNombre.Select()
            txtNombre.MensajedeAyuda = "Digite el nombre del estado civil. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
            txtNombre.MaximoAncho = AnchoCampoSql(ObjetoApiNomina, "CAT_EstadoCivil", "NomEstado")
        Catch ex As Exception
           HDevExpre.msgError(ex, ex.Message, "load")
        End Try
    End Sub

#Region "Eventos controles"
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If txtNombre.ValordelControl = "" Then
               HDevExpre.MensagedeError("El nombre de la categoria no puede estar vacío!")
                txtNombre.Focus()
                Exit Sub
            End If
            If GuardaRegistro(_idEstado, txtNombre.ValordelControl, CBool(rgVigente.SelectedIndex), estaActualizando) Then
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
            If gvEstadoCivil.Columns.Count = 0 Then Exit Sub
            'Distribuye los anchos de columnas en el gv de los productos de la receta
            gvEstadoCivil.Columns("NomEstado").Width = CInt((70 * (gbxPrincipal.Width - 20)) / 100)
            gvEstadoCivil.Columns("Vigente").Width = CInt((28 * (gbxPrincipal.Width - 20)) / 100)
        Catch ex As Exception
           HDevExpre.msgError(ex, ex.Message, "gbxPrincipal_SizeChanged")
        End Try
    End Sub

    Private Sub gvEstadoCivil_DoubleClick(sender As Object, e As EventArgs) Handles gvEstadoCivil.DoubleClick
        Try
            Dim fila As String = HDevExpre.ValidaDobleClicSobreFila(gvEstadoCivil)
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
        FrmPrincipal.MensajeDeAyuda.Caption = "Seleccione si el estado civil se encuentra vigente. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
    End Sub

    Private Sub rgVigente_Leave(sender As Object, e As EventArgs) Handles rgVigente.Leave
        HDevExpre.SaleControlRadioGroup(rgVigente, lblVigente, lblVigente.Font.Size)
        FrmPrincipal.MensajeDeAyuda.Caption = ""
    End Sub

#End Region

#Region "Funciones y procedimientos"
    Private Sub CreaGrilla()
        Try
            gvEstadoCivil.Columns.Clear()

            HDevExpre.CreaColumnasG(gvEstadoCivil, "idEstado", "", False, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 0, 0)
            HDevExpre.CreaColumnasG(gvEstadoCivil, "NomEstado", "Nombre", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 70, gbxPrincipal.Width)
            HDevExpre.CreaColumnasG(gvEstadoCivil, "Vigente", "Vigente", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 28, gbxPrincipal.Width)
            gvEstadoCivil.Appearance.HeaderPanel.Font = New Font("Trebuchet MS", 11.0!, FontStyle.Bold)
            gvEstadoCivil.Columns(gvEstadoCivil.Columns.Count - 1).Summary.Add(DevExpress.Data.SummaryItemType.Count, "", "{0}  Registros")
            gvEstadoCivil.OptionsView.ShowFooter = True
        Catch ex As Exception
           HDevExpre.msgError(ex, ex.Message, "CreaGrilla")
        End Try
    End Sub

    Private Sub LlenaGrilla()
        Try
            Dim sql As String = "SELECT * FROM CAT_EstadoCivil"
            Dim dt As DataTable = SMT_AbrirTabla(ObjetoApiNomina, sql)
            gcEstadoCivil.DataSource = dt
        Catch ex As Exception
           HDevExpre.msgError(ex, ex.Message, "LlenaGrilla")
        End Try
    End Sub

    Private Function GuardaRegistro(idEstado As Single, NomEstado As String, Vigente As Boolean, Actualizando As Boolean) As Boolean
        Try
            Dim GenSql As New SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL
            If Not Actualizando Then
                Dim dt As DataTable = SMT_AbrirTabla(ObjetoApiNomina, "SELECT ISNULL( MAX (IdEstado),0)+1 AS Codigo FROM  CAT_EstadoCivil")
                If dt.Rows.Count > 0 Then
                    idEstado = CInt(dt.Rows(0)(0))
                Else : Return False
                End If
            End If
            GenSql.PasoConexionTabla(ObjetoApiNomina, "CAT_EstadoCivil")
            GenSql.PasoValores("NomEstado", NomEstado, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            GenSql.PasoValores("Vigente", Vigente.ToString, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            If Not Actualizando Then
                GenSql.PasoValores("idEstado", idEstado.ToString, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
                If Not GenSql.EjecutarComandoNET(SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.SQLGenera.Insercion, "") Then Return False
            Else
                If Not GenSql.EjecutarComandoNET(SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.SQLGenera.Actualizacion, "idEstado=" & idEstado) Then Return False
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
            rgVigente.SelectedIndex = 1
            _idEstado = 0
            estaActualizando = False
            txtNombre.Focus()
        Catch ex As Exception
           HDevExpre.msgError(ex, ex.Message, "LimpiarCampos")
        End Try
    End Sub

    Private Sub CargarDatos(numFila As Integer)
        Try
            If numFila < 0 Then Exit Sub
            txtNombre.ValordelControl = gvEstadoCivil.GetDataRow(numFila)("NomEstado").ToString
            _idEstado = CUShort(gvEstadoCivil.GetDataRow(numFila)("IdEstado"))
            If CBool(gvEstadoCivil.GetDataRow(numFila)("Vigente")) Then rgVigente.SelectedIndex = 1 Else rgVigente.SelectedIndex = 0
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
                SMT_EjcutarComandoSql(ObjetoApiNomina, "DELETE FROM CAT_EstadoCivil WHERE IdEstado = " & _idEstado, 0)
                LlenaGrilla()
                LimpiarCampos()
            End If
        Catch ex As Exception
           HDevExpre.msgError(ex, ex.Message, "EliminaRegisto")
        End Try
    End Sub
    Private Function ValidaSiCatEstaEnEmpleado() As Boolean
        Try
            Dim dt As DataTable = SMT_AbrirTabla(ObjetoApiNomina, "SELECT * FROM Empleados WHERE EstadoCivil = " & _idEstado)
            If dt.Rows.Count > 0 Then
               HDevExpre.MensagedeError("El estado civil seleccionado se encuentra asociado a un empleado, imposible eliminar.")
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