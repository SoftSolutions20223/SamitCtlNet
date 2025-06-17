Imports SamitCtlNet
Public Class FrmMunicipios
    Dim estaActualizando As Boolean = False
    Dim _codMunicipio As String = ""
    Dim HDevExpre As New HelperDevExpress
    Dim HNomina As New HelperNomina
    Private Sub FrmDpto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            btnGuardar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Guardar)
            btnEliminar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Eliminar)
            btnSalir.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.SalirCuadroConX)
            btnLimpiar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Limpiar)
            txtDpto.ConsultaSQL = String.Format("SELECT CodDpto AS Codigo, NomDpto AS Descripcion FROM {0}..G_Departamento", ObjetoApiNomina)
            txtNombre.MaximoAncho = 50
            txtIdMuni.MaximoAncho = 6
            txtCodMuni.MaximoAncho = 3
            txtDpto.MensajedeAyuda = "Seleccione el departamento al cual pertenece el municipio. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras; (F5,DER)=Avanzar"
            txtNombre.MensajedeAyuda = "Digite el nombre del municipio. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atra"
            txtIdMuni.MensajedeAyuda = "Digite el ID del municipio que desea insertar. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
            txtCodMuni.MensajedeAyuda = "Digite el Código del municipio que desea insertar. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
            txtNombre.MaximoAncho = AnchoCampoSql(ObjetoApiNomina, "G_Municipio", "NombreMunicipio")
            txtIdMuni.MaximoAncho = AnchoCampoSql(ObjetoApiNomina, "G_Municipio", "IdMunicipio")
            txtCodMuni.MaximoAncho = AnchoCampoSql(ObjetoApiNomina, "G_Municipio", "CodMunicipio")
            CreaGrilla()
            LlenaGrilla()
            txtDpto.Focus()
            txtDpto.Select()
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "load")
        End Try
    End Sub

#Region "Eventos Controles"

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If txtDpto.ValordelControl = "" Then
                HDevExpre.MensagedeError("Por favor seleccione el departamento!")
                txtDpto.Focus()
                Exit Sub
            ElseIf txtNombre.ValordelControl = "" Then
                HDevExpre.MensagedeError("El nombre del municipio no puede estar vacío!")
                txtNombre.Focus()
                Exit Sub
            ElseIf txtIdMuni.ValordelControl = "" Then
                HDevExpre.MensagedeError("El id del municipio no puede estar vacío!")
                txtIdMuni.Focus()
                Exit Sub
            ElseIf txtCodMuni.ValordelControl = "" Then
                HDevExpre.MensagedeError("El código del municipio no puede estar vacío!")
                txtCodMuni.Focus()
                Exit Sub
            End If
            If GuardaRegistro(txtDpto.ValordelControl, txtCodMuni.ValordelControl, txtNombre.ValordelControl, txtIdMuni.ValordelControl, estaActualizando) Then
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
            If gvMunicipio.Columns.Count = 0 Then Exit Sub
            'Distribuye los anchos de columnas en el gv de los productos de la receta
            gvMunicipio.Columns("NomDpto").Width = CInt((39 * (gbxPrincipal.Width - 20)) / 100)
            gvMunicipio.Columns("IdMunicipio").Width = CInt((10 * (gbxPrincipal.Width - 20)) / 100)
            gvMunicipio.Columns("CodMunicipio").Width = CInt((10 * (gbxPrincipal.Width - 20)) / 100)
            gvMunicipio.Columns("NombreMunicipio").Width = CInt((39 * (gbxPrincipal.Width - 20)) / 100)
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "gbxPrincipal_SizeChanged")
        End Try
    End Sub

    Private Sub gvCatLicencia_DoubleClick(sender As Object, e As EventArgs) Handles gvMunicipio.DoubleClick
        Try
            Dim fila As String = HDevExpre.ValidaDobleClicSobreFila(gvMunicipio)
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
            gvMunicipio.Columns.Clear()
            HDevExpre.CreaColumnasG(gvMunicipio, "Departamento", "Departamento", False, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 0, 0)
            HDevExpre.CreaColumnasG(gvMunicipio, "NomDpto", "Nombre Departamento", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 39, gbxPrincipal.Width)
            HDevExpre.CreaColumnasG(gvMunicipio, "IdMunicipio", "ID Municipio", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 10, gbxPrincipal.Width)
            HDevExpre.CreaColumnasG(gvMunicipio, "CodMunicipio", "Código Municipio", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 10, gbxPrincipal.Width)
            HDevExpre.CreaColumnasG(gvMunicipio, "NombreMunicipio", "Nombre Municipio ", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 39, gbxPrincipal.Width)
            gvMunicipio.Appearance.HeaderPanel.Font = New Font("Trebuchet MS", 11.0!, FontStyle.Bold)
            gvMunicipio.Columns(gvMunicipio.Columns.Count - 1).Summary.Add(DevExpress.Data.SummaryItemType.Count, "", "{0}  Registros")
            gvMunicipio.OptionsView.ShowFooter = True
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "CreaGrilla")
        End Try
    End Sub

    Private Sub LlenaGrilla()
        Try
            Dim sql As String = "SELECT MN.*, DP.NomDpto FROM G_Municipio MN INNER JOIN G_Departamento DP ON MN.Departamento = DP.CodDpto"
            Dim dt As DataTable = SMT_AbrirTabla(ObjetoApiNomina, sql)
            gcMunicipio.DataSource = dt
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "LlenaGrilla")
        End Try
    End Sub

    Private Function GuardaRegistro(Departamento As String, CodMunicipio As String, NombreMunicipio As String, IdMunicipio As String, Actualizando As Boolean) As Boolean
        Try
            Dim GenSql As New SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL
            GenSql.PasoConexionTabla(ObjetoApiNomina, "G_Municipio")
            GenSql.PasoValores("Departamento", Departamento, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            GenSql.PasoValores("CodMunicipio", CodMunicipio, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            GenSql.PasoValores("NombreMunicipio", NombreMunicipio, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            If Not Actualizando Then
                GenSql.PasoValores("IdMunicipio", IdMunicipio, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
                If Not GenSql.EjecutarComandoNET(SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.SQLGenera.Insercion, "") Then Return False
            Else
                If Not GenSql.EjecutarComandoNET(SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.SQLGenera.Actualizacion, String.Format("IdMunicipio='{0}'", IdMunicipio)) Then Return False
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
            txtDpto.ValordelControl = ""
            txtCodMuni.ValordelControl = ""
            txtIdMuni.ValordelControl = ""
            _codMunicipio = ""
            estaActualizando = False
            txtDpto.Focus()
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "LimpiarCampos")
        End Try
    End Sub

    Private Sub CargarDatos(numFila As Integer)
        Try
            If numFila < 0 Then Exit Sub
            txtDpto.ValordelControl = gvMunicipio.GetDataRow(numFila)("Departamento").ToString
            txtNombre.ValordelControl = gvMunicipio.GetDataRow(numFila)("NombreMunicipio").ToString
            txtCodMuni.ValordelControl = gvMunicipio.GetDataRow(numFila)("CodMunicipio").ToString
            txtIdMuni.ValordelControl = gvMunicipio.GetDataRow(numFila)("IdMunicipio").ToString
            _codMunicipio = gvMunicipio.GetDataRow(numFila)("IdMunicipio").ToString
            estaActualizando = True
            txtDpto.Focus()
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "CargarDatos")
        End Try
    End Sub
    Private Sub EliminaRegisto()
        Try
            If Not estaActualizando Then Exit Sub
            If Not ValidaSiCatEstaEnEmpleado() Then Exit Sub
            If HDevExpre.MsgSamit("Seguro que desea eliminar el registro seleccionado?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.OK Then
                SMT_EjcutarComandoSql(ObjetoApiNomina, String.Format("DELETE FROM G_Municipio WHERE IdMunicipio = '{0}'", _codMunicipio), 0)
                LlenaGrilla()
                LimpiarCampos()
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "EliminaRegisto")
        End Try
    End Sub
    Private Function ValidaSiCatEstaEnEmpleado() As Boolean
        Try
            Dim sql As String = String.Format("SELECT SUM(Z.R) AS Resultado,Z.Asociado FROM ( " +
            " SELECT COUNT(*) AS R,CAST(CASE WHEN COUNT(*)>1 THEN 'Empleados' ELSE 'Empleado' END AS VARCHAR) AS Asociado " +
            " FROM Empleados WHERE MunicipioNacimiento = '{0}' OR Municipio = '{0}' OR LugarExpDoc = '{0}'" +
            " UNION ALL" +
            " SELECT COUNT(*) AS R,CAST(CASE WHEN COUNT(*)>1 THEN 'Familiares' ELSE 'Familiar' END AS VARCHAR) AS Asociado FROM Familiares FM WHERE FM.Ciudad = '{0}'" +
            " UNION ALL" +
            " SELECT COUNT(*) AS R,CAST(CASE WHEN COUNT(*)>1 THEN 'Títulos Profesionales' ELSE 'Título Profesional' END AS VARCHAR) AS Asociado " +
            " FROM Empleados_Educacion EE WHERE EE.LugarTitulo = '{0}') AS Z " +
            " GROUP BY Z.Asociado HAVING SUM(Z.R)>0", _codMunicipio)
            Dim dt As DataTable = SMT_AbrirTabla(ObjetoApiNomina, sql)
            Dim msg As String = ""
            If dt.Rows.Count > 0 Then
                For Each fila As DataRow In dt.Rows
                    If msg <> "" Then msg += ", "
                    msg += String.Format("{0} {1}", fila("Resultado"), fila("Asociado"))
                Next
                HDevExpre.MensagedeError(String.Format("El municipio seleccionado se encuentra asociado a {0}, imposible eliminar.", msg))
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