Imports SamitCtlNet
Public Class FrmDepartamento
    Dim estaActualizando As Boolean = False
    Dim _codDepartamento As String = ""
    Dim HDevExpre As New HelperDevExpress
    Dim HNomina As New HelperNomina
    Private Sub FrmDpto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            btnGuardar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Guardar)
            btnEliminar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Eliminar)
            btnSalir.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.SalirCuadroConX)
            btnLimpiar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Limpiar)
            txtPais.ConsultaSQL = String.Format("SELECT CodPais AS Codigo, NomPais AS Descripcion FROM G_Pais", ObjetoApiNomina)
            txtCodDpto.MaximoAncho = 3
            txtNombre.MaximoAncho = 100
            CreaGrilla()
            LlenaGrilla()
            txtPais.Focus()
            txtPais.Select()
            txtPais.MensajedeAyuda = "Seleccione el país al cual pertenece el departamento. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras; (F5,DER)=Buscar"
            txtCodDpto.MensajedeAyuda = "Digite el código del departamento. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
            txtNombre.MensajedeAyuda = "Digite el nombre del departamento. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
            txtCodDpto.MaximoAncho = AnchoCampoSql(ObjetoApiNomina, "G_Departamento", "CodDpto")
            txtNombre.MaximoAncho = AnchoCampoSql(ObjetoApiNomina, "G_Departamento", "NomDpto")
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "load")
        End Try
    End Sub

#Region "Eventos controles"

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If txtPais.ValordelControl = "" Then
                HDevExpre.MensagedeError("El país no puede estar vacío!")
                txtPais.Focus()
                Exit Sub
            ElseIf txtCodDpto.ValordelControl = "" Then
                HDevExpre.MensagedeError("El código del departamento no puede estar vacío!")
                txtCodDpto.Focus()
                Exit Sub
            ElseIf txtNombre.ValordelControl = "" Then
                HDevExpre.MensagedeError("El nombre del departamento no puede estar vacío!")
                txtNombre.Focus()
                Exit Sub
            End If
            If GuardaRegistro(txtPais.ValordelControl, txtNombre.ValordelControl, txtCodDpto.ValordelControl, estaActualizando) Then
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
            If gvDpto.Columns.Count = 0 Then Exit Sub
            'Distribuye los anchos de columnas en el gv de los productos de la receta
            gvDpto.Columns("NomPais").Width = CInt((40 * (gbxPrincipal.Width - 20)) / 100)
            gvDpto.Columns("CodDpto").Width = CInt((18 * (gbxPrincipal.Width - 20)) / 100)
            gvDpto.Columns("NomDpto").Width = CInt((40 * (gbxPrincipal.Width - 20)) / 100)
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "gbxPrincipal_SizeChanged")
        End Try
    End Sub

    Private Sub gvCatLicencia_DoubleClick(sender As Object, e As EventArgs) Handles gvDpto.DoubleClick
        Try
            Dim fila As String = HDevExpre.ValidaDobleClicSobreFila(gvDpto)
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
            gvDpto.Columns.Clear()

            HDevExpre.CreaColumnasG(gvDpto, "Pais", "", False, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 0, 0)
            HDevExpre.CreaColumnasG(gvDpto, "NomPais", "Pais ", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 40, gbxPrincipal.Width)
            HDevExpre.CreaColumnasG(gvDpto, "CodDpto", "Código Departamento", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 18, gbxPrincipal.Width)
            HDevExpre.CreaColumnasG(gvDpto, "NomDpto", "Nombre Departamento", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 40, gbxPrincipal.Width)
            gvDpto.Appearance.HeaderPanel.Font = New Font("Trebuchet MS", 11.0!, FontStyle.Bold)
            gvDpto.Columns(gvDpto.Columns.Count - 1).Summary.Add(DevExpress.Data.SummaryItemType.Count, "", "{0}  Registros")
            gvDpto.OptionsView.ShowFooter = True
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "CreaGrilla")
        End Try
    End Sub

    Private Sub LlenaGrilla()
        Try
            Dim sql As String = "SELECT DP.*,NomPais FROM G_Departamento DP" +
                                " INNER JOIN G_Pais PS ON DP.Pais = PS.CodPais"
            Dim dt As DataTable = SMT_AbrirTabla(ObjetoApiNomina, sql)
            gcDpto.DataSource = dt
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "LlenaGrilla")
        End Try
    End Sub

    Private Function GuardaRegistro(Pais As String, NomDpto As String, CodDpto As String, Actualizando As Boolean) As Boolean
        Try
            Dim GenSql As New SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL
            GenSql.PasoConexionTabla(ObjetoApiNomina, "G_Departamento")
            GenSql.PasoValores("Pais", Pais, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            GenSql.PasoValores("NomDpto", NomDpto, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            If Not Actualizando Then
                GenSql.PasoValores("CodDpto", CodDpto, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
                If Not GenSql.EjecutarComandoNET(SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.SQLGenera.Insercion, "") Then Return False
            Else
                If Not GenSql.EjecutarComandoNET(SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.SQLGenera.Actualizacion, String.Format("CodDpto='{0}'", CodDpto)) Then Return False
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
            txtPais.ValordelControl = ""
            txtCodDpto.ValordelControl = ""
            _codDepartamento = ""
            estaActualizando = False
            txtPais.Focus()
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "LimpiarCampos")
        End Try
    End Sub

    Private Sub CargarDatos(numFila As Integer)
        Try
            If numFila < 0 Then Exit Sub
            txtPais.ValordelControl = gvDpto.GetDataRow(numFila)("Pais").ToString
            txtCodDpto.ValordelControl = gvDpto.GetDataRow(numFila)("CodDpto").ToString
            txtNombre.ValordelControl = gvDpto.GetDataRow(numFila)("NomDpto").ToString
            _codDepartamento = gvDpto.GetDataRow(numFila)("CodDpto").ToString
            estaActualizando = True
            txtPais.Focus()
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "CargarDatos")
        End Try
    End Sub
    Private Sub EliminaRegisto()
        Try
            If Not estaActualizando Then Exit Sub
            If Not ValidaSiCatEstaEnEmpleado() Then Exit Sub
            If HDevExpre.MsgSamit("Seguro que desea eliminar el registro seleccionado?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.OK Then
                SMT_EjcutarComandoSql(ObjetoApiNomina, String.Format("DELETE FROM G_Departamento WHERE CodDpto = '{0}'", _codDepartamento), 0)
                LlenaGrilla()
                LimpiarCampos()
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "EliminaRegisto")
        End Try
    End Sub
    Private Function ValidaSiCatEstaEnEmpleado() As Boolean
        Try
            Dim dt As DataTable = SMT_AbrirTabla(ObjetoApiNomina, String.Format("SELECT * FROM G_Municipio WHERE Departamento = '{0}'", _codDepartamento))
            If dt.Rows.Count > 0 Then
                HDevExpre.MensagedeError("El departamento seleccionado se encuentra asociada a uno o mas municipios, imposible eliminar.")
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