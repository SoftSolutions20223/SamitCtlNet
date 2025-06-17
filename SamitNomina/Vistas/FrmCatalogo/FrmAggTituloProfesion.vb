Imports SamitCtlNet
Imports DevExpress.Utils
Imports System.ComponentModel
Imports DevExpress.XtraEditors.Controls

Public Class FrmAggTituloProfesion
    Dim dt As DataTable
    Dim Buscando As Boolean = False
    Dim Actualizando As Boolean = False
    Dim CodProfesion As String = ""
    Dim FormularioAbierto As Boolean = False
    Dim HDevExpre As New HelperDevExpress
    Dim HNomina As New HelperNomina
    Public Property P_FormularioAbierto() As Boolean
        Get
            Return FormularioAbierto
        End Get
        Set(value As Boolean)
            FormularioAbierto = value
        End Set
    End Property

    Private Sub FrmAggTituloProfesion_Load(sender As Object, e As EventArgs) Handles Me.Load
        AcomodaForm()
        txtNoBuscando()
        CreaGrilla()
        LlenaGrillaProfesiones()
        LlenaLkeNivelesEducativos()
        lkeNivelEducativo.Select()
        txtProfesion.MensajedeAyuda = "Digite el nombre de la profesión que desea insertar. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
        'txtProfesion.MaximoAncho = AnchoCampoSql(ObjetoApiNomina, "CAT_Profesiones", "NomProfesion")
    End Sub
    Private Sub FrmAggTituloProfesion_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        LimpiarCampos()
        Buscando = False
        txtNoBuscando()
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

    Private Sub lkeNivelEducativo_Enter(sender As Object, e As EventArgs) Handles lkeNivelEducativo.Enter
        HDevExpre.EntraControlLkeDEV(lkeNivelEducativo, lblNivelEducativo)
        FrmPrincipal.MensajeDeAyuda.Caption = "Seleccione el nivel educativo que desea agregar. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
    End Sub

    Private Sub grbVigente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rgVigente.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Or e.KeyChar = Convert.ToChar(Keys.Tab) Then
            btnGuardar.Focus()
        End If
        If e.KeyChar = ChrW(Keys.Escape) Then
            btnGuardar.Focus()
        End If
    End Sub

    Private Sub lkeNivelEducativo_Leave(sender As Object, e As EventArgs) Handles lkeNivelEducativo.Leave
        HDevExpre.SaleControlLkeDEV(lkeNivelEducativo, lblNivelEducativo)
        FrmPrincipal.MensajeDeAyuda.Caption = ""
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarCampos()
    End Sub

    Private Sub btnCargarPlano_Click(sender As Object, e As EventArgs) Handles btnCargarPlano.Click
        Try
            Dim fName As String = ""
            Dim OpenFileDialog1 As New OpenFileDialog
            OpenFileDialog1.InitialDirectory = "c:\temp\"
            OpenFileDialog1.Filter = "CSV files (*.csv)|*.CSV"
            OpenFileDialog1.FilterIndex = 2
            OpenFileDialog1.RestoreDirectory = True
            If (OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK) Then
                fName = OpenFileDialog1.FileName
            End If

            'Me.TextBox1.Text = fName

            Dim fila As String = ""
            Dim campos() As String
            If System.IO.File.Exists(fName) = True Then
                Dim wait As New ClEspera
                wait.Mostrar()
                wait.Descripcion = "Cargando información..."
                Dim lector As New System.IO.StreamReader(fName, System.Text.Encoding.Default)
                Dim sql As String = "SELECT ISNULL( MAX (IdProfesion),0)+1 AS Codigo FROM  CAT_Profesiones"
                Dim dt As DataTable = SMT_AbrirTabla(ObjetoApiNomina, sql)
                Dim sec As Integer = 0
                If dt.Rows.Count = 0 Then
                    HDevExpre.MensagedeError("Lo sentimos, ha ocurrido un error al consultar el ultimo secuencial!")
                    Exit Sub
                Else : sec = CInt(dt.Rows(0)(0))
                End If
                sec -= 1
                Do While lector.Peek() <> -1
                    sec += 1
                    fila = lector.ReadLine()
                    campos = Split(fila, ";")
                    dt = SMT_AbrirTabla(ObjetoApiNomina, String.Format("SELECT * FROM CAT_Profesiones WHERE NomProfesion = '{0}'", campos(0).ToString))
                    If dt.Rows.Count = 0 Then
                        sql = String.Format("INSERT CAT_Profesiones ([IdProfesion], [NomProfesion], [Vigente], [IdNivelEducativo]) VALUES ({0},'{1}',{2},{3})", sec, campos(0), campos(1), campos(2))
                        SMT_EjcutarComandoSql(ObjetoApiNomina, sql, 0)
                    End If
                Loop
                LlenaGrillaProfesiones()
                txtProfesion.Focus()
                wait.Terminar()
            Else

                MsgBox("File Does Not Exist")

            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "btnCargarPlano_Click")
        End Try
    End Sub

    Private Sub gbxPrincipal_SizeChanged(sender As Object, e As EventArgs) Handles gbxPrincipal.SizeChanged
        If gvProfesiones.Columns.Count = 0 Then Exit Sub
        'Distribuye los anchos de columnas en el gv de los productos de la receta
        gvProfesiones.Columns("NomProfesion").Width = CInt((40 * (gbxPrincipal.Width - 20)) / 100)
        gvProfesiones.Columns("Vigente").Width = CInt((18 * (gbxPrincipal.Width - 20)) / 100)
        gvProfesiones.Columns("NomNivel").Width = CInt((40 * (gbxPrincipal.Width - 20)) / 100)
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtProfesion.ValordelControl <> "" Then
            If GuardaDatos(CodProfesion, txtProfesion.ValordelControl,
                       rgVigente.SelectedIndex.ToString,
                       lkeNivelEducativo.EditValue.ToString,
                       Actualizando) Then
                LlenaGrillaProfesiones()
                LimpiarCampos()
                HDevExpre.mensajeExitoso("Información Guardada exitosamente")
            Else
                HDevExpre.MensagedeError("Error al guardar los datos!")
            End If
        Else
            HDevExpre.MensagedeError("El campo profesión no puede estar vacío!")
            txtProfesion.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub gvProfesiones_DoubleClick(sender As Object, e As EventArgs) Handles gvProfesiones.DoubleClick
        CargarDatos()
    End Sub

    Private Sub gvProfesiones_KeyPress(sender As Object, e As KeyPressEventArgs) Handles gvProfesiones.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            CargarDatos()
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        EliminaProfesion(CodProfesion)
    End Sub
    Private Sub FrmAggTituloProfesion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = ChrW(Keys.Escape) Then
            Me.Close()
        End If
    End Sub

    Private Sub lkeNivelEducativo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles lkeNivelEducativo.KeyPress
        HDevExpre.AvanzaConEnter(e)
    End Sub

    Private Sub grbVigente_Enter(sender As Object, e As EventArgs) Handles rgVigente.Enter
        HDevExpre.EntraControlRadioGroup(rgVigente, lblVigente, rgVigente.Font.Size, lblVigente.Font.Size)
        FrmPrincipal.MensajeDeAyuda.Caption = "Seleccione si la profesión se encuentra vigente o no. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
    End Sub

    Private Sub rgVigente_Leave(sender As Object, e As EventArgs) Handles rgVigente.Leave
        HDevExpre.SaleControlRadioGroup(rgVigente, lblVigente, rgVigente.Font.Size, lblVigente.Font.Size)
        FrmPrincipal.MensajeDeAyuda.Caption = ""
    End Sub
#End Region
#Region "Procedimientos y Funciones"
    Private Sub AcomodaForm()
        Try
            btnGuardar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Guardar)
            btnEliminar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Eliminar)
            btnSalir.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.SalirCuadroConX)
            btnLimpiar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Limpiar)
            btnCargarPlano.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.CargarCVS)
            rgVigente.SelectedIndex = 1

        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "AcomodaForm Agrega Profesion!")
        End Try
    End Sub
    Private Sub CreaGrilla()
        Try
            gvProfesiones.Columns.Clear()

            HDevExpre.CreaColumnasG(gvProfesiones, "IdProfesion", "IdProfesion", False, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 0, 0)
            HDevExpre.CreaColumnasG(gvProfesiones, "NomProfesion", "Nombre", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 40, gbxPrincipal.Width)
            HDevExpre.CreaColumnasG(gvProfesiones, "Vigente", "Vigente", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 18, gbxPrincipal.Width)
            HDevExpre.CreaColumnasG(gvProfesiones, "IdNivelEducativo", "", False, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 0, 0)
            HDevExpre.CreaColumnasG(gvProfesiones, "NomNivel", "Nivel Educativo", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 40, gbxPrincipal.Width)
            gvProfesiones.OptionsView.ShowFooter = True
            gvProfesiones.Appearance.HeaderPanel.Font = New Font("Trebuchet MS", 11.0!, FontStyle.Bold)
            gvProfesiones.Columns(2).ColumnEdit = gvProfesiones.Columns(2).View.GridControl.RepositoryItems.Add("TextEdit")
            gvProfesiones.Columns(2).DisplayFormat.Format = New FormatoBooleanGrilla("SI", "NO")
            gvProfesiones.Columns(4).Summary.Add(DevExpress.Data.SummaryItemType.Count, "", "{0}  Registros")
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "Crea Grilla Profesiones")
        End Try
    End Sub
    Private Sub LlenaGrillaProfesiones()
        Try
            Dim sql As String = "SELECT CP.*,NE.NomNivel FROM CAT_Profesiones CP" &
            " INNER JOIN CAT_NivelEducativo NE ON CP.IdNivelEducativo=NE.Sec"
            dt = SMT_AbrirTabla(ObjetoApiNomina, sql)
            If dt.Rows.Count > 0 Then
                gcProfesiones.DataSource = dt
            Else
                HDevExpre.mensajeExitoso("No se registra ninguna profesión, podemos empezar ingresandolas!..")
            End If

        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "LlenaGrillaNivelesEdu")
        End Try
    End Sub
    Private Sub LlenaLkeNivelesEducativos()
        Try
            Dim sql As String = "SELECT NV.Sec AS Codigo, NV.NomNivel AS Descripcion FROM CAT_NivelEducativo NV WHERE NV.Vigente=1"
            HDevExpre.LlenaLkeConDt(lkeNivelEducativo, sql, "Descripcion", "Codigo")

        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "LlenaLkeNivelesEducativos")
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
        gcProfesiones.DataSource = dv
    End Sub

    Private Sub LimpiarCampos()
        CodProfesion = ""
        Actualizando = False
        lkeNivelEducativo.ItemIndex = 0
        txtProfesion.ValordelControl = ""
        rgVigente.SelectedIndex = 1
        Buscando = False
        txtNoBuscando()
        gcProfesiones.DataSource = dt
        lkeNivelEducativo.Focus()
    End Sub
    Private Function GuardaDatos(IdProfesion As String, NomProfesion As String, Vigente As String, IdNivelEducativo As String, EstaActualizando As Boolean) As Boolean
        Try
            Dim GenSql As New SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL
            GenSql.PasoConexionTabla(ObjetoApiNomina, "CAT_Profesiones")
            GenSql.PasoValores("NomProfesion", NomProfesion, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            GenSql.PasoValores("Vigente", Vigente, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            GenSql.PasoValores("IdNivelEducativo", IdNivelEducativo, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            If Not EstaActualizando Then
                IdProfesion = SMT_AbrirTabla(ObjetoApiNomina, "SELECT ISNULL( MAX (IdProfesion),0)+1 AS Codigo FROM  CAT_Profesiones").Rows(0)(0).ToString
                GenSql.PasoValores("IdProfesion", IdProfesion, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
                If GenSql.EjecutarComandoNET(SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.SQLGenera.Insercion, "") Then
                    Return True
                Else : Return False
                End If
            Else
                If GenSql.EjecutarComandoNET(SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.SQLGenera.Actualizacion, String.Format("IdProfesion={0}", IdProfesion)) Then
                    Return True
                Else : Return False
                End If
            End If

        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "Guardando profesion")
            Return False
        End Try
    End Function
    Private Sub CargarDatos()
        Try
            Dim Vigente As Boolean = False
            CodProfesion = gvProfesiones.GetFocusedRowCellValue("IdProfesion").ToString
            lkeNivelEducativo.EditValue = gvProfesiones.GetFocusedRowCellValue("IdNivelEducativo")
            txtProfesion.ValordelControl = gvProfesiones.GetFocusedRowCellValue("NomProfesion").ToString
            Vigente = CType(gvProfesiones.GetFocusedRowCellValue("Vigente"), Boolean)
            If Vigente Then
                rgVigente.SelectedIndex = 1
            Else
                rgVigente.SelectedIndex = 0
            End If
            Actualizando = True
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "Cargar datos profesion")
        End Try
    End Sub
    Private Sub EliminaProfesion(IdProfesion As String)
        If Not Actualizando Or CodProfesion = "" Then
            HDevExpre.MensagedeError("Debe seleccionar el item que desea editar o eliminar, selecciona con doble clic!")
            Exit Sub
        Else
            Dim dt As DataTable = SMT_AbrirTabla(ObjetoApiNomina, String.Format("SELECT * FROM Empleados EM WHERE Profesion={0}", IdProfesion))
            If dt.Rows.Count > 0 Then
                HDevExpre.MensagedeError("La profesión que desea eliminar se encuentra asociada a un empleado y no es posible continuar!")
                Exit Sub
            End If
            dt = SMT_AbrirTabla(ObjetoApiNomina, String.Format("SELECT * FROM Empleados_Educacion EP WHERE EP.IdTituloObtenido={0}", IdProfesion))
            If dt.Rows.Count > 0 Then
                HDevExpre.MensagedeError("La profesión que desea eliminar se encuentra asociada la información académica de un empleado y no es posible continuar!")
                Exit Sub
            End If
            If HDevExpre.MsgSamit(String.Format("Seguro que desea eliminar item seleccionado [{0}]", txtProfesion.ValordelControl), MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.OK Then
                If SMT_EjcutarComandoSqlBool(ObjetoApiNomina, String.Format("DELETE FROM CAT_Profesiones WHERE IdProfesion={0}", IdProfesion)) > 0 Then
                    LimpiarCampos()
                    LlenaGrillaProfesiones()
                Else
                    HDevExpre.MensagedeError("Error al eiminar la profesión!")
                End If
            End If
        End If
    End Sub
#End Region


End Class


