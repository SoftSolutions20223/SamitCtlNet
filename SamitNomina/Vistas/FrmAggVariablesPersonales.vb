Imports SamitCtlNet
Imports DevExpress.Utils
Imports System.ComponentModel
Imports DevExpress.XtraEditors.Controls
Imports SamitNominaLogic
Imports Newtonsoft.Json.Linq

Public Class FrmAggVariablesPersonales
    Dim dt As DataTable
    Dim Buscando As Boolean = False
    Dim Actualizando As Boolean = False
    Dim SecVariablesp As String = ""
    Dim NomVariable As String = ""
    Dim EsPredeterminado As Boolean = False
    Dim secReg As Integer = 0
    Dim FormularioAbierto As Boolean = False
    Dim HDevExpre As New HelperDevExpress
    Dim HNomina As New HelperNomina
    Dim VariablePersonal As New VariablesPersonales
    Public Property P_FormularioAbierto() As Boolean
        Get
            Return FormularioAbierto
        End Get
        Set(value As Boolean)
            FormularioAbierto = value
        End Set
    End Property

    Private Sub FrmAggVariablesPersonales_Load(sender As Object, e As EventArgs) Handles Me.Load
        AcomodaForm()
        txtNoBuscando()
        CreaGrilla()
        LlenaGrillaVariablesP()
        txtNombreVariable.Focus()
        txtNombreVariable.MensajedeAyuda = "Digite el nombre de la variable personal. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
        txtNombreVariable.MaximoAncho = AnchoCampoSql(ObjetoApiNomina, "VariablesPersonales", "NomVariable")
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


    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarCampos()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtNombreVariable.ValordelControl <> "" Then
            If txtValorMaximo.ValordelControl <> "" Then
                If TxtValDefecto.ValordelControl <> "" Then
                    Dim sec As Integer = 0
                    If Actualizando Then sec = secReg
                    If GuardaDatos(sec, SecVariablesp, txtNombreVariable.ValordelControl, grbVigente.SelectedIndex.ToString(), txtValorMaximo.ValordelControl, TxtValDefecto.ValordelControl,
                               Actualizando) Then
                        HNomina.ModNomFormulas(NomVariable, txtNombreVariable.ValordelControl)
                        HDevExpre.mensajeExitoso("Información Guardada exitosamente")
                        LlenaGrillaVariablesP()
                        LimpiarCampos()
                    Else
                        HDevExpre.MensagedeError("Error al guardar los datos!")
                    End If
                Else
                    HDevExpre.MensagedeError("El campo valor por defecto no puede estar vacío!")
                    TxtValDefecto.Focus()
                End If
            Else
                HDevExpre.MensagedeError("El campo valor maximo no puede estar vacío!")
                txtValorMaximo.Focus()
                Exit Sub
            End If
        Else
            HDevExpre.MensagedeError("El campo nombre no puede estar vacío!")
            txtNombreVariable.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub gvVariablesP_DoubleClick(sender As Object, e As EventArgs) Handles gvVariablesP.DoubleClick
        CargarDatos()
    End Sub

    Private Sub gvVariablesP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles gvVariablesP.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            CargarDatos()
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        EliminaVariablesPersonales()
    End Sub
    Private Sub FrmAggVariablesPersonales_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = ChrW(Keys.Escape) Then
            Me.Close()
        End If
    End Sub

#End Region



#Region "Procedimientos y Funciones"
    Private Sub AcomodaForm()
        Try
            btnGuardar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Guardar)
            btnEliminar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Eliminar)
            btnSalir.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.SalirAtras)
            btnLimpiar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Limpiar)
            grbVigente.SelectedIndex = 1

            txtCodDian.ConsultaSQL = String.Format("SELECT * FROM {0}..CodigosDian")
            txtCodDian.RefrescarDatos()
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "AcomodaForm Agrega Variables Personales!")
        End Try
    End Sub
    Private Sub CreaGrilla()
        Try
            gvVariablesP.Columns.Clear()

            HDevExpre.CreaColumnasG(gvVariablesP, "Sec", "Sec", False, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 0, 0)
            HDevExpre.CreaColumnasG(gvVariablesP, "CodDian", "Codigo Dian", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 15, gbxPrincipal.Width)
            HDevExpre.CreaColumnasG(gvVariablesP, "NomVariable", "Nombre", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 40, gbxPrincipal.Width)
            HDevExpre.CreaColumnasG(gvVariablesP, "ValorMaximo", "Valor Maximo", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 20, gbxPrincipal.Width)
            HDevExpre.CreaColumnasG(gvVariablesP, "ValorDefecto", "Valor Defecto", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 20, gbxPrincipal.Width)
            HDevExpre.CreaColumnasG(gvVariablesP, "Vigente", "Vigente", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 20, gbxPrincipal.Width)
            HDevExpre.CreaColumnasG(gvVariablesP, "EsPredeterminado", "Es Predeterminado", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 20, gbxPrincipal.Width)
            gvVariablesP.OptionsView.ShowFooter = True
            gvVariablesP.Appearance.HeaderPanel.Font = New Font("Trebuchet MS", 11.0!, FontStyle.Bold)
            gvVariablesP.Columns(3).Summary.Add(DevExpress.Data.SummaryItemType.Count, "", "{0}  Registros")
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "Crea Grilla")
        End Try
    End Sub
    Private Sub LlenaGrillaVariablesP()
        Try
            Dim sql As String = "SELECT CodDian,Sec,NomVariable,ValorMaximo,ValorDefecto,case Vigente " +
                                " WHEN '1' then 'Si' when '0' then 'No' end As Vigente,case EsPredeterminado WHEN '1' then 'Si' when '0' then 'No' end As EsPredeterminado FROM VariablesPersonales "
            dt = SMT_AbrirTabla(ObjetoApiNomina, sql)
            If dt.Rows.Count > 0 Then
                gcVariablesP.DataSource = dt
            Else
                HDevExpre.mensajeExitoso("No se registra ninga variable personal, podemos empezar ingresandolos!..")
                gcVariablesP.DataSource = Nothing
            End If

        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "LlenaGrillaVariablesP")
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
        gcVariablesP.DataSource = dv
    End Sub

    Private Sub LimpiarCampos()
        SecVariablesp = ""
        Actualizando = False
        NomVariable = ""
        EsPredeterminado = False
        secReg = 0
        txtCodDian.ValordelControl = ""
        txtNombreVariable.ValordelControl = ""
        txtValorMaximo.ValordelControl = "0"
        TxtValDefecto.ValordelControl = "0"
        Buscando = False
        grbVigente.SelectedIndex = 1
        txtNoBuscando()
        gcVariablesP.DataSource = dt
        txtNombreVariable.Focus()
    End Sub

    Private Function ValidaNombres(Sec As String, Nombre As String, EstaActualizando As Boolean) As Boolean
        If Not EstaActualizando Then
            If HNomina.ValidaNombresR(txtNombreVariable.ValordelControl) Then
                Return True
            Else
                HDevExpre.MensagedeError("Ya existe un registro con este nombre (Los Conceptos,Variables Generales,Variables Personales y Bases no pueden coincidir en el nombre)!..")
                Return False
            End If
        Else
            Dim sql As String = "Select Consul.Nombre,Consul.tipo,Consul.Sec From(  " +
" Select NomBase As Nombre,'B' as tipo,Sec as Sec From BasesConceptos" +
" Union Select NomConcepto As Nombre,'C' as tipo,Sec as Sec From ConceptosNomina " +
" Union Select NomVariable As Nombre, 'VG' as tipo,Sec as Sec From VariablesGenerales " +
" Union Select NomVariable As Nombre, 'VP' as tipo,Sec as Sec From VariablesPersonales" +
" Union Select NomConcepto As Nombre, 'CP' as tipo,Sec as Sec From ConceptosPersonales" +
        " Union Select 'HorasMes' As Nombre,'VPP' As tipo, '0' as Sec " +
        " Union Select 'Asignacion' As Nombre,'VPP' As tipo, '0' as Sec " +
        " Union Select 'RentaExenta' As Nombre,'VPP' As tipo, '0' as Sec " +
        " Union Select 'DescuentosPorNomina' As Nombre,'VPP' As tipo, '0' as Sec " +
        " Union Select 'SalarioPromedioPeriodo' As Nombre,'VPP' As tipo, '0' as Sec " +
        " Union Select 'SalarioPromedioMensualAnual' As Nombre,'VPP' As tipo, '0' as Sec " +
        " Union Select 'SalarioPromedioMensualSemestral' As Nombre,'VPP' As tipo, '0' as Sec " +
        " Union Select 'NetoAPagar' As Nombre,'VPP' As tipo, '0' as Sec " +
        " Union Select 'TotalPagadoMes' As Nombre,'VPP' As tipo, '0' as Sec " +
        " Union Select 'TotalIngresos' As Nombre,'VPP' As tipo, '0' as Sec " +
        " Union Select 'TotalDeducciones' As Nombre,'VPP' As tipo, '0' as Sec " +
" ) as Consul Where Consul.Nombre ='" + txtNombreVariable.ValordelControl + "'"
            Dim dt As DataTable = SMT_AbrirTabla(ObjetoApiNomina, sql)
            If dt.Rows.Count > 1 Then
                HDevExpre.MensagedeError("Ya existe un registro con este nombre (Los Conceptos,Variables Generales,Variables Personales y Bases no pueden coincidir en el nombre)!..")
                Return False

            ElseIf dt.Rows.Count = 1 Then
                If dt.Rows(0)("tipo").ToString <> "VP" Then
                    HDevExpre.MensagedeError("Ya existe un registro con este nombre (Los Conceptos,Variables Generales,Variables Personales y Bases no pueden coincidir en el nombre)!..")
                    Return False

                ElseIf dt.Rows(0)("tipo").ToString = "VP" And dt.Rows(0)("Sec").ToString <> Sec Then
                    HDevExpre.MensagedeError("Ya existe un registro con este nombre (Los Conceptos,Variables Generales,Variables Personales y Bases no pueden coincidir en el nombre)!..")
                    Return False
                End If
            End If
        End If
        Return True
    End Function

    Private Function GuardaDatos(Sec As Integer, SecVariable As String, NomVariable As String, Vigente As String, ValorMaximo As String, ValorDefecto As String, EstaActualizando As Boolean) As Boolean
        Try
            VariablePersonal = New VariablesPersonales
            VariablePersonal.NomVariable = txtNombreVariable.ValordelControl
            VariablePersonal.Sec = Sec
            VariablePersonal.Vigente = grbVigente.SelectedIndex.ToString()
            VariablePersonal.ValorMaximo = txtValorMaximo.ValordelControl
            VariablePersonal.ValorDefecto = TxtValDefecto.ValordelControl
            Dim RegVariablePersonal As New ServiceVariablesPersonales
            Dim registro As JArray
            If RegVariablePersonal.ValidarCampos(VariablePersonal) Then
                registro = RegVariablePersonal.UpsertVariablesPersonal(VariablePersonal)
            End If
            If registro.Count > 0 Then
                Return True
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "Guardando Variables Personales")
            Return False
        End Try
    End Function
    Private Sub CargarDatos()
        Try
            SecVariablesp = gvVariablesP.GetFocusedRowCellValue("Sec").ToString
            secReg = gvVariablesP.GetFocusedRowCellValue("Sec").ToString
            NomVariable = gvVariablesP.GetFocusedRowCellValue("NomVariable").ToString
            txtCodDian.ValordelControl = gvVariablesP.GetFocusedRowCellValue("CodDian").ToString
            EsPredeterminado = IIf(gvVariablesP.GetFocusedRowCellValue("EsPredeterminado").ToString = "Si", True, False)
            txtNombreVariable.ValordelControl = gvVariablesP.GetFocusedRowCellValue("NomVariable").ToString
            txtValorMaximo.ValordelControl = gvVariablesP.GetFocusedRowCellValue("ValorMaximo").ToString
            TxtValDefecto.ValordelControl = gvVariablesP.GetFocusedRowCellValue("ValorDefecto").ToString
            If gvVariablesP.GetFocusedRowCellValue("Vigente").ToString = "Si" Then
                grbVigente.SelectedIndex = 1
            Else
                grbVigente.SelectedIndex = 0
            End If
            Actualizando = True
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "Cargar datos Variables Personales")
        End Try
    End Sub
    Private Sub EliminaVariablesPersonales()
        If Not Actualizando Or secReg = 0 Then
            HDevExpre.MensagedeError("No ha cargado ninguna entidad para ser eliminada.")
            Exit Sub
        End If
        If HDevExpre.MsgSamit(String.Format("Seguro que desea eliminar item seleccionado [{0}]", txtNombreVariable.ValordelControl), MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.OK Then
            VariablePersonal = New VariablesPersonales
            VariablePersonal.Sec = secReg

            Dim RegVariablePersonal As New ServiceVariablesPersonales
            Dim registro As JArray
            registro = RegVariablePersonal.EliminarVariablesPersonal(VariablePersonal)

            LimpiarCampos()
            LlenaGrillaVariablesP()
            HDevExpre.MensagedeError("Error al eiminar la variable personal!")
        End If
    End Sub
#End Region


    'Public Function ModificaFormulas(NomVar As String, NuevoNomVar As String) As Boolean
    '    Dim sql As String = "Select Formula From ConfigConceptos WHERE Formula LIKE '%" + NomVar + "%'"
    '    Dim dt As DataTable = SMT_AbrirTabla(ObjetoApiNomina, sql)
    '    If dt.Rows.Count > 0 Then
    '        If SMT_EjcutarComandoSqlBool(ObjetoApiNomina, String.Format("UPDATE ConfigConceptos SET Formula = REPLACE(SUBSTRING(Formula, 1, DATALENGTH(Formula)),'[" + NomVar + "]', '[" + NuevoNomVar + "]')")) > 0 Then

    '        Else
    '            Return False
    '        End If
    '    End If

    '    sql = "Select ValMaxDescuento From ConceptosPersonales WHERE ValMaxDescuento LIKE '%" + NomVar + "%'"
    '    dt = SMT_AbrirTabla(ObjetoApiNomina, sql)
    '    If dt.Rows.Count > 0 Then
    '        If SMT_EjcutarComandoSqlBool(ObjetoApiNomina, String.Format("UPDATE ConceptosPersonales SET ValMaxDescuento = REPLACE(SUBSTRING(ValMaxDescuento, 1, DATALENGTH(ValMaxDescuento)),'[" + NomVar + "]', '[" + NuevoNomVar + "]')")) > 0 Then
    '        Else
    '            Return False
    '        End If
    '    End If

    '    sql = "Select Formula From BasesConceptos WHERE Formula LIKE '%" + NomVar + "%'"
    '    dt = SMT_AbrirTabla(ObjetoApiNomina, sql)
    '    If dt.Rows.Count > 0 Then
    '        If SMT_EjcutarComandoSqlBool(ObjetoApiNomina, String.Format("UPDATE BasesConceptos SET Formula = REPLACE(SUBSTRING(Formula, 1, DATALENGTH(Formula)),'[" + NomVar + "]', '[" + NuevoNomVar + "]')")) > 0 Then
    '        Else
    '            Return False
    '        End If
    '    End If

    '    sql = "Select ValorMaxDescontar From Plantillas WHERE ValorMaxDescontar LIKE '%" + NomVar + "%'"
    '    dt = SMT_AbrirTabla(ObjetoApiNomina, sql)
    '    If dt.Rows.Count > 0 Then
    '        If SMT_EjcutarComandoSqlBool(ObjetoApiNomina, String.Format("UPDATE Plantillas SET ValorMaxDescontar = REPLACE(SUBSTRING(ValorMaxDescontar, 1, DATALENGTH(ValorMaxDescontar)),'[" + NomVar + "]', '[" + NuevoNomVar + "]')")) > 0 Then
    '        Else
    '            Return False
    '        End If
    '    End If

    '    sql = "Select Formula From TiposContratos_ConceptosNomina WHERE Formula LIKE '%" + NomVar + "%'"
    '    dt = SMT_AbrirTabla(ObjetoApiNomina, sql)
    '    If dt.Rows.Count > 0 Then
    '        If SMT_EjcutarComandoSqlBool(ObjetoApiNomina, String.Format("UPDATE TiposContratos_ConceptosNomina SET Formula = REPLACE(SUBSTRING(Formula, 1, DATALENGTH(Formula)),'[" + NomVar + "]', '[" + NuevoNomVar + "]')")) > 0 Then
    '        Else
    '            Return False
    '        End If
    '    End If

    '    sql = "Select Formula From ConfigProvisiones WHERE Formula LIKE '%" + NomVar + "%'"
    '    dt = SMT_AbrirTabla(ObjetoApiNomina, sql)
    '    If dt.Rows.Count > 0 Then
    '        If SMT_EjcutarComandoSqlBool(ObjetoApiNomina, String.Format("UPDATE ConfigProvisiones SET Formula = REPLACE(SUBSTRING(Formula, 1, DATALENGTH(Formula)),'[" + NomVar + "]', '[" + NuevoNomVar + "]')")) > 0 Then
    '        Else
    '            Return False
    '        End If
    '    End If

    '    Return True
    'End Function

    Private Sub FrmAggVariablesPersonales_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        LimpiarCampos()
        Buscando = False
        txtNoBuscando()
    End Sub

    Private Sub grbVigente_Enter(sender As Object, e As EventArgs) Handles grbVigente.Enter
        HDevExpre.EntraControlRadioGroup(grbVigente, lblVigente)
        FrmPrincipal.MensajeDeAyuda.Caption = "(ENTER,ABJ)=Avanzar;(ESC,ARB)=AtrasSeleccione si la variable personal se encuentra vigente. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
    End Sub

    Private Sub grbVigente_Leave(sender As Object, e As EventArgs) Handles grbVigente.Leave
        HDevExpre.SaleControlRadioGroup(grbVigente, lblVigente)
        FrmPrincipal.MensajeDeAyuda.Caption = ""
    End Sub

    Private Sub grbVigente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles grbVigente.KeyPress
        HDevExpre.AvanzaConEnter(e)
    End Sub

    Private Sub btnSalir_KeyPress(sender As Object, e As KeyPressEventArgs) Handles btnSalir.KeyPress, btnLimpiar.KeyPress, btnGuardar.KeyPress, btnEliminar.KeyPress
        HDevExpre.AtrasConScape(e)
    End Sub
End Class