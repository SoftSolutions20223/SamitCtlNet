Imports SamitCtlNet
Public Class FrmPais
    Dim estaActualizando As Boolean = False
    Dim _codPais As String = ""
    Dim HDevExpre As New HelperDevExpress
    Dim HNomina As New HelperNomina
    Private Sub FrmPais_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            btnGuardar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Guardar)
            btnEliminar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Eliminar)
            btnSalir.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.SalirCuadroConX)
            btnLimpiar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Limpiar)
            txtCodIso.MaximoAncho = 3
            txtNombre.MaximoAncho = 100
            txtCodIso.MaximoAncho = 3
            CreaGrilla()
            LlenaGrilla()
            txtNombre.Focus()
            txtNombre.Select()
            txtNombre.MensajedeAyuda = "Digite el nombre del país que desea insertar. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
            txtCodPais.MensajedeAyuda = "Digite el código del país que desea insertar. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
            txtCodIso.MensajedeAyuda = "Digite el código ISO del país que desea insertar. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
            txtNombre.MaximoAncho = AnchoCampoSql(ObjetoApiNomina, "G_Pais", "NomPais")
            txtCodPais.MaximoAncho = AnchoCampoSql(ObjetoApiNomina, "G_Pais", "CodPais")
            txtCodIso.MaximoAncho = AnchoCampoSql(ObjetoApiNomina, "G_Pais", "CodIso")
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "load")
        End Try
    End Sub
#Region "Eventos controles"
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If txtNombre.ValordelControl = "" Then
                HDevExpre.MensagedeError("El nombre del país no puede estar vacío!")
                txtNombre.Focus()
                Exit Sub
            ElseIf txtCodPais.ValordelControl = "" Then
                HDevExpre.MensagedeError("El código del país no puede estar vacío!")
                txtCodPais.Focus()
                Exit Sub
            ElseIf txtCodIso.ValordelControl = "" Then
                HDevExpre.MensagedeError("El código ISO no puede estar vacío!")
                txtCodIso.Focus()
                Exit Sub
            End If
            If GuardaRegistro(txtCodPais.ValordelControl, txtNombre.ValordelControl, txtCodIso.ValordelControl, estaActualizando) Then
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
            If gvPaises.Columns.Count = 0 Then Exit Sub
            'Distribuye los anchos de columnas en el gv de los productos de la receta
            gvPaises.Columns("idClase").Width = CInt((20 * (gbxPrincipal.Width - 20)) / 100)
            gvPaises.Columns("NomClase").Width = CInt((58 * (gbxPrincipal.Width - 20)) / 100)
            gvPaises.Columns("Vigente").Width = CInt((20 * (gbxPrincipal.Width - 20)) / 100)
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "gbxPrincipal_SizeChanged")
        End Try
    End Sub

    Private Sub gvCatLicencia_DoubleClick(sender As Object, e As EventArgs) Handles gvPaises.DoubleClick
        Try
            Dim fila As String = HDevExpre.ValidaDobleClicSobreFila(gvPaises)
            If fila <> "" Then
                CargarDatos(CInt(fila))
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Funciones y procedimientos"
    Private Sub CreaGrilla()
        Try
            gvPaises.Columns.Clear()

            HDevExpre.CreaColumnasG(gvPaises, "CodPais", "Código de pais", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 20, gbxPrincipal.Width)
            HDevExpre.CreaColumnasG(gvPaises, "NomPais", "Nombre ", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 58, gbxPrincipal.Width)
            HDevExpre.CreaColumnasG(gvPaises, "CodIso", "Código ISO", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 20, gbxPrincipal.Width)
            gvPaises.Appearance.HeaderPanel.Font = New Font("Trebuchet MS", 11.0!, FontStyle.Bold)
            gvPaises.Columns(gvPaises.Columns.Count - 1).Summary.Add(DevExpress.Data.SummaryItemType.Count, "", "{0}  Registros")
            gvPaises.OptionsView.ShowFooter = True
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "CreaGrilla")
        End Try
    End Sub

    Private Sub LlenaGrilla()
        Try
            Dim sql As String = "SELECT * FROM G_Pais"
            Dim dt As DataTable = SMT_AbrirTabla(ObjetoApiNomina, sql)
            gcPaises.DataSource = dt
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "LlenaGrilla")
        End Try
    End Sub

    Private Function GuardaRegistro(CodPais As String, NomPais As String, CodIso As String, Actualizando As Boolean) As Boolean
        Try
            Dim GenSql As New SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL
            GenSql.PasoConexionTabla(ObjetoApiNomina, "G_Pais")
            GenSql.PasoValores("CodIso", CodIso, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            GenSql.PasoValores("NomPais", NomPais, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            If Not Actualizando Then
                GenSql.PasoValores("CodPais", CodPais, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
                If Not GenSql.EjecutarComandoNET(SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.SQLGenera.Insercion, "") Then Return False
            Else
                If Not GenSql.EjecutarComandoNET(SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.SQLGenera.Actualizacion, String.Format("CodPais='{0}'", CodPais)) Then Return False
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
            txtCodPais.ValordelControl = ""
            txtCodIso.ValordelControl = ""
            _codPais = ""
            estaActualizando = False
            txtNombre.Focus()
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "LimpiarCampos")
        End Try
    End Sub

    Private Sub CargarDatos(numFila As Integer)
        Try
            If numFila < 0 Then Exit Sub
            txtNombre.ValordelControl = gvPaises.GetDataRow(numFila)("NomPais").ToString
            txtCodPais.ValordelControl = gvPaises.GetDataRow(numFila)("CodPais").ToString
            txtCodIso.ValordelControl = gvPaises.GetDataRow(numFila)("CodIso").ToString
            _codPais = gvPaises.GetDataRow(numFila)("CodPais").ToString
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
                SMT_EjcutarComandoSql(ObjetoApiNomina, String.Format("DELETE FROM G_Pais WHERE CodPais = '{0}'", _codPais), 0)
                LlenaGrilla()
                LimpiarCampos()
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "EliminaRegisto")
        End Try
    End Sub
    Private Function ValidaSiCatEstaEnEmpleado() As Boolean
        Try
            Dim dt As DataTable = SMT_AbrirTabla(ObjetoApiNomina, String.Format("SELECT * FROM G_Departamento WHERE Pais = '{0}'", _codPais))
            If dt.Rows.Count > 0 Then
                HDevExpre.MensagedeError("El país seleccionado se encuentra asociada a uno o mas departamentos, imposible eliminar.")
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