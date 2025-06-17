Imports SamitCtlNet
Imports DevExpress.Utils
Imports System.ComponentModel

Public Class FrmAggNivelEducativo
    Dim CodNivel As String = ""
    Dim Actualizando As Boolean = False
    Dim dt As DataTable
    Dim Buscando As Boolean = False
    Dim HDevExpre As New HelperDevExpress
    Dim HNomina As New HelperNomina
    Dim FormularioAbierto As Boolean = False
    Public Property P_FormularioAbierto() As Boolean
        Get
            Return FormularioAbierto
        End Get
        Set(value As Boolean)
            FormularioAbierto = value
        End Set
    End Property

    Private Sub FrmAggNivelEducativo_Load(sender As Object, e As EventArgs) Handles Me.Load
        AcomodaForm()
        CreaGrilla()
        txtNoBuscando()
        LlenaGrillaNivelesEdu()
        txtNombreNivel.Select()
        txtNombreNivel.Focus()
        txtNombreNivel.MensajedeAyuda = "Digite el nombre del nivel educativo. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
        txtNombreNivel.MaximoAncho = AnchoCampoSql(ObjetoApiNomina, "CAT_NivelEducativo", "NomNivel")
    End Sub

    Private Sub FrmAggNivelEducativo_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        LimpiarCampos()
        Buscando = False
        txtNoBuscando()
    End Sub

#Region "Eventos controles"
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub gvNivelEducativo_DoubleClick(sender As Object, e As EventArgs) Handles gvNivelEducativo.DoubleClick
        CargaDatos()
    End Sub

    Private Sub gbxPrincipal_SizeChanged(sender As Object, e As EventArgs) Handles gbxPrincipal.SizeChanged
        If gvNivelEducativo.Columns.Count = 0 Then Exit Sub
        'Distribuye los anchos de columnas en el gv de los productos de la receta
        gvNivelEducativo.Columns("NomNivel").Width = CInt((79 * (gbxPrincipal.Width - 20)) / 100)
        gvNivelEducativo.Columns("Vigente").Width = CInt((10 * (gbxPrincipal.Width - 20)) / 100)
        gvNivelEducativo.Columns("EsFormal").Width = CInt((10 * (gbxPrincipal.Width - 20)) / 100)
    End Sub
    Private Sub gvNivelEducativo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles gvNivelEducativo.KeyPress
        Try
            If gvNivelEducativo.RowCount > 0 Then
                If e.KeyChar = ChrW(Keys.Enter) Then
                    CargaDatos()
                End If
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "gvNivelEducativo_KeyPress")
        End Try
    End Sub


    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarCampos()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtNombreNivel.ValordelControl = "" Then
            HDevExpre.MensagedeError("El campo nombre del nivel no puede estar vacío!")
            txtNombreNivel.Focus()
            Exit Sub
        Else
            If GuardarDatos(Me.CodNivel, txtNombreNivel.ValordelControl, grbVigente.SelectedIndex.ToString,
                        grbEducacionFormal.SelectedIndex.ToString, Actualizando) Then
                HDevExpre.mensajeExitoso("Datos Guardados exitosamente!")
                LimpiarCampos()
                LlenaGrillaNivelesEdu()
            Else : HDevExpre.MensagedeError("Error al guardar los datos")
            End If
        End If
    End Sub


    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        EliminarNivelEdu(CodNivel)
    End Sub


    Private Sub FrmAggNivelEducativo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = ChrW(Keys.Escape) Then
            Me.Close()
        End If
    End Sub


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

#End Region
#Region "Procedimientos y Funciones"
    Private Sub AcomodaForm()
        Try
            btnGuardar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Guardar)
            btnEliminar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Eliminar)
            btnSalir.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.SalirCuadroConX)
            btnLimpiar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Limpiar)
            grbEducacionFormal.SelectedIndex = 1
            grbVigente.SelectedIndex = 1
            txtNombreNivel.MaximoAncho = 50
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "AcomodaForm Agrega nivel educativo!")
        End Try
    End Sub
    Private Sub CreaGrilla()
        Try
            gvNivelEducativo.Columns.Clear()

            HDevExpre.CreaColumnasG(gvNivelEducativo, "IdNivel", "IdNivel", False, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 0, 0)
            HDevExpre.CreaColumnasG(gvNivelEducativo, "NomNivel", "Nombre", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 79, gbxPrincipal.Width)
            HDevExpre.CreaColumnasG(gvNivelEducativo, "Vigente", "Vigente", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 10, gbxPrincipal.Width)
            HDevExpre.CreaColumnasG(gvNivelEducativo, "EsFormal", "Formal", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 10, gbxPrincipal.Width)
            gvNivelEducativo.OptionsView.ShowFooter = True
            gvNivelEducativo.Appearance.HeaderPanel.Font = New Font("Trebuchet MS", 11.0!, FontStyle.Bold)
            gvNivelEducativo.Columns(2).ColumnEdit = gvNivelEducativo.Columns(2).View.GridControl.RepositoryItems.Add("TextEdit")
            gvNivelEducativo.Columns(2).DisplayFormat.Format = New FormatoBooleanGrilla("SI", "NO")
            gvNivelEducativo.Columns(3).ColumnEdit = gvNivelEducativo.Columns(2).View.GridControl.RepositoryItems.Add("TextEdit")
            gvNivelEducativo.Columns(3).DisplayFormat.Format = New FormatoBooleanGrilla("SI", "NO")
            gvNivelEducativo.Columns(3).Summary.Add(DevExpress.Data.SummaryItemType.Count, "", "{0}  Registros")
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "Crea Grilla Niveles educativos")
        End Try
    End Sub
    Private Sub LlenaGrillaNivelesEdu()
        Try
            Dim sql As String = "SELECT * FROM CAT_NivelEducativo"
            dt = SMT_AbrirTabla(ObjetoApiNomina, sql)
            If dt.Rows.Count > 0 Then
                gcNivelEducativo.DataSource = dt
            Else
                HDevExpre.mensajeExitoso("No se registra ningún Nivel educativo, podemos empezar ingresandolos!..")
            End If

        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "LlenaGrillaNivelesEdu")
        End Try
    End Sub
    Private Sub CargaDatos()
        Try
            Dim Vig, Formal As Boolean
            txtNombreNivel.ValordelControl = gvNivelEducativo.GetFocusedRowCellValue("NomNivel").ToString
            CodNivel = gvNivelEducativo.GetFocusedRowCellValue("IdNivel").ToString
            Vig = CType(gvNivelEducativo.GetFocusedRowCellValue("Vigente"), Boolean)
            Formal = CType(gvNivelEducativo.GetFocusedRowCellValue("EsFormal"), Boolean)
            If Vig Then
                grbVigente.SelectedIndex = 1
            Else
                grbVigente.SelectedIndex = 0
            End If
            If Formal Then
                grbEducacionFormal.SelectedIndex = 1
            Else
                grbEducacionFormal.SelectedIndex = 0
            End If
            Actualizando = True
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "CargaDatosBasicos")
        End Try
    End Sub
    Private Sub LimpiarCampos()
        txtNombreNivel.ValordelControl = ""
        grbEducacionFormal.SelectedIndex = 1
        grbVigente.SelectedIndex = 1
        Actualizando = False
        txtNombreNivel.Focus()
    End Sub

    Private Function GuardarDatos(IdNivel As String, NomNivel As String, Vigente As String, EsFormal As String, EstaActualizando As Boolean) As Boolean
        Try
            Dim GenSql As New SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL
            GenSql.PasoConexionTabla(ObjetoApiNomina, "CAT_NivelEducativo")
            GenSql.PasoValores("NomNivel", NomNivel, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            GenSql.PasoValores("Vigente", Vigente, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            GenSql.PasoValores("EsFormal", EsFormal, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            If Not EstaActualizando Then
                IdNivel = SMT_AbrirTabla(ObjetoApiNomina, "SELECT ISNULL( MAX (IdNivel),0)+1 AS Codigo FROM  CAT_NivelEducativo").Rows(0)(0).ToString
                GenSql.PasoValores("IdNivel", IdNivel, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
                If GenSql.EjecutarComandoNET(SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.SQLGenera.Insercion, "") Then
                    Return True
                Else : Return False
                End If
            Else
                If GenSql.EjecutarComandoNET(SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.SQLGenera.Actualizacion, String.Format(" IdNivel={0}", IdNivel)) Then
                    Return True
                Else : Return False
                End If
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "Guarda datos Nivel educativo!")
            Return False
        End Try
    End Function

    Private Sub txtNoBuscando()
        txtBusqueda.Text = "Digite cualquier parametro de Busqueda"
        txtBusqueda.Font = New Font("Trebuchet MS", 10.25F, FontStyle.Italic)
        txtBusqueda.BackColor = Color.LemonChiffon
        txtBusqueda.ForeColor = Color.Gray
        txtBusqueda.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
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
        gcNivelEducativo.DataSource = dv
    End Sub

    Private Sub EliminarNivelEdu(IdNivel As String)
        Try
            If Not Actualizando Or CodNivel <> "" Then
                HDevExpre.MensagedeError("Debe seleccionar el item que desea editar o eliminar, selecciona con doble clic!")
                Exit Sub
            Else
                Dim dt As DataTable = SMT_AbrirTabla(ObjetoApiNomina, String.Format("SELECT * FROM CAT_Profesiones WHERE IdNivelEducativo={0}", CodNivel))
                If dt.Rows.Count > 0 Then
                    HDevExpre.MensagedeError("El Nivel edcativo que desea eliminar se encuentra asociado a una Profesion y no es posible eliminar!")
                    Exit Sub
                End If
                If HDevExpre.MsgSamit("Seguro que desea eliminar el nivel seleccionado", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.OK Then
                    If SMT_EjcutarComandoSqlBool(ObjetoApiNomina, String.Format("DELETE FROM CAT_NivelEducativo WHERE IdNivel={0}", IdNivel)) > 0 Then
                        LimpiarCampos()
                        LlenaGrillaNivelesEdu()
                    Else
                        HDevExpre.MensagedeError("Error al eiminar el nivel educativo!")
                    End If
                End If
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "EliminarNivelEdu")
        End Try
    End Sub
#End Region




    Private Sub grbEducacionFormal_Enter(sender As Object, e As EventArgs) Handles grbEducacionFormal.Enter
        HDevExpre.EntraControlRadioGroup(grbEducacionFormal, lblEsFormal, grbEducacionFormal.Font.Size, lblEsFormal.Font.Size)
        FrmPrincipal.MensajeDeAyuda.Caption = "Seleccione si el nivel educativo que desea agregar es formal o no. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
    End Sub

    Private Sub grbEducacionFormal_Leave(sender As Object, e As EventArgs) Handles grbEducacionFormal.Leave
        HDevExpre.SaleControlRadioGroup(grbEducacionFormal, lblEsFormal, grbEducacionFormal.Font.Size, lblEsFormal.Font.Size)
        FrmPrincipal.MensajeDeAyuda.Caption = ""
    End Sub

    Private Sub grbVigente_Enter(sender As Object, e As EventArgs) Handles grbVigente.Enter
        HDevExpre.EntraControlRadioGroup(grbVigente, lblVigente, grbVigente.Font.Size, lblVigente.Font.Size)
        FrmPrincipal.MensajeDeAyuda.Caption = "Seleccione si el nivel educativo que desea agregar esta vigente o no. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
    End Sub

    Private Sub grbVigente_Leave(sender As Object, e As EventArgs) Handles grbVigente.Leave
        HDevExpre.SaleControlRadioGroup(grbVigente, lblVigente, grbVigente.Font.Size, lblVigente.Font.Size)
        FrmPrincipal.MensajeDeAyuda.Caption = ""
    End Sub

    Private Sub grbEducacionFormal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles grbVigente.KeyPress, grbEducacionFormal.KeyPress
        HDevExpre.AvanzaConEnter(e)
    End Sub
End Class