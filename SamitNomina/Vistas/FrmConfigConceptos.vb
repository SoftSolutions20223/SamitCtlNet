Imports SamitCtlNet
Imports DevExpress.Utils
Imports System.ComponentModel
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraEditors.Controls
Imports System.Data.SqlClient
Imports SamitNominaLogic
Imports Newtonsoft.Json.Linq

Public Class FrmConfigConceptos

    Public Datos As New SamitCtlNet.SamitCtlNet
    Dim dt As DataTable
    Dim Actualizando As Boolean = False
    Dim Sec_Configuracion As String = ""
    Dim Buscando As Boolean = False
    Dim Consulto As Boolean = False
    Dim secReg As Integer = 0
    Dim FormularioAbierto As Boolean = False
    Dim HDevExpre As New HelperDevExpress
    Dim HNomina As New HelperNomina
    Dim ConfigConcepto As New ConfigConceptos
    Public Property P_FormularioAbierto() As Boolean
        Get
            Return FormularioAbierto
        End Get
        Set(value As Boolean)
            FormularioAbierto = value
        End Set
    End Property

    Public Property P_Consulto() As Boolean
        Get
            Return Consulto
        End Get
        Set(value As Boolean)
            Consulto = value
        End Set
    End Property

    Private Sub FrmAggVariablesPersonales_Load(sender As Object, e As EventArgs) Handles Me.Load
        AsignaScriptAcontroles()
        AcomodaForm()
        Creagrillahorizontal()
        CreaGrilla()
        LlenaGrillaConfigConceptos("")
        AsignaMsgAcontroles()
        gcConfigConceptos.Focus()
    End Sub



#Region "Eventos Controles"

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub


    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarCampos()
    End Sub

    Private Sub FrmAggConfigConceptos_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        LimpiarCampos()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If ValidaCampos() Then
            Dim Periodos As String = ""
            If ckePeriodo1.Checked = True And ckePeriodo2.Checked = False And ckePeriodo3.Checked = False Then
                Periodos = "1"

            ElseIf ckePeriodo2.Checked = True And ckePeriodo1.Checked = False And ckePeriodo3.Checked = False Then
                Periodos = "2"

            ElseIf ckePeriodo3.Checked = True And ckePeriodo2.Checked = False And ckePeriodo1.Checked = False Then
                Periodos = "3"

            ElseIf ckePeriodo1.Checked = True And ckePeriodo2.Checked = True And ckePeriodo3.Checked = False Then
                Periodos = "1,2"

            ElseIf ckePeriodo1.Checked = True And ckePeriodo3.Checked = True And ckePeriodo2.Checked = False Then
                Periodos = "1,3"

            ElseIf ckePeriodo1.Checked = True And ckePeriodo3.Checked = True And ckePeriodo2.Checked = True Then
                Periodos = "1,2,3"
            ElseIf ckePeriodo1.Checked = False And ckePeriodo3.Checked = True And ckePeriodo2.Checked = True Then
                Periodos = "2,3"
            End If
            Dim sec As Integer = 0
            If GuardaDatos(sec, Sec_Configuracion, txtNomina.ValordelControl, txtConcepto.ValordelControl, txtFormula.ValordelControl, Periodos) Then
                HDevExpre.mensajeExitoso("Información Guardada exitosamente")
                LimpiarCampos()
            Else
                HDevExpre.MensagedeError("Error al guardar los datos!")
            End If
        Else
            Exit Sub
        End If
    End Sub

    Public Function ValidaCampos() As Boolean
        If txtFormula.ValordelControl = "" Then
            HDevExpre.MensagedeError("El campo formula no puede estar vacío!..")
            txtFormula.Focus()
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub gvConfigConceptos_DoubleClick(sender As Object, e As EventArgs) Handles gvConfigConceptos.DoubleClick
        CargarDatos()
    End Sub

    Private Sub gvConfigConceptos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles gvConfigConceptos.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            CargarDatos()
        End If
    End Sub

    Private Sub FrmConfigConceptos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = ChrW(Keys.Escape) Then
            Me.Close()
        End If
    End Sub

#End Region
#Region "Procedimientos y Funciones"
    Private Sub AcomodaForm()
        Try
            btnGuardar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Guardar)
            btnSalir.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.SalirAtras)
            btnLimpiar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Limpiar)
            btnBuscar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Buscar)
            btnAbrirFormula.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Formula)
            ckePeriodo1.Checked = True
            ckePeriodo2.Checked = False
            ckePeriodo3.Checked = False

            txtConcepto.Enabled = False
            txtNomina.Enabled = False
            gcConfigConceptos.Focus()
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "AcomodaForm ConfiguraConceptos!")
        End Try
    End Sub

    Private Sub AsignaScriptAcontroles()
        Try
            txtConcepto.ConsultaSQL = String.Format("SELECT Sec AS Codigo,NomConcepto As Descripcion FROM {0}..ConceptosNomina")
            txtConcepto.RefrescarDatos()
            txtNomina.ConsultaSQL = String.Format("SELECT SecNomina AS Codigo,NomNomina As Descripcion FROM {0}..Nominas ")
            txtNomina.RefrescarDatos()

        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "AsignaScriptAcontroles")
        End Try
    End Sub
    Private Sub CreaGrilla()
        Try
            gvConfigConceptos.Columns.Clear()
            HDevExpre.CreaColumnasG(gvConfigConceptos, "SecConfig", "SecConfig", False, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 0, 0)
            HDevExpre.CreaColumnasG(gvConfigConceptos, "NomNomina", "Nomina", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 25, gbxPrincipal.Width)
            HDevExpre.CreaColumnasG(gvConfigConceptos, "NomConcepto", "Concepto", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 30, gbxPrincipal.Width)
            HDevExpre.CreaColumnasG(gvConfigConceptos, "Formula", "Formula", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 20, gbxPrincipal.Width)
            HDevExpre.CreaColumnasG(gvConfigConceptos, "PeriodosLiquida", "Periodos de liquidacion", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 10, gbxPrincipal.Width)
            HDevExpre.CreaColumnasG(gvConfigConceptos, "CuentaContable", "Cuenta Contable", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 15, gbxPrincipal.Width)
            gvConfigConceptos.OptionsView.ShowFooter = True
            gvConfigConceptos.Appearance.HeaderPanel.Font = New Font("Trebuchet MS", 11.0!, FontStyle.Bold)
            gvConfigConceptos.Columns(5).Summary.Add(DevExpress.Data.SummaryItemType.Count, "", "{0}  Registros")
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "CreaGrilla")
        End Try
    End Sub
    Public Sub LlenaGrillaConfigConceptos(Parametros As String)
        Try
            Dim Orden As String = "order by N.NomNomina ASC"
            Dim sql As String = "Select N.NomNomina,N.SecNomina,C.NomConcepto,C.Sec as SecConcepto,CC.Formula,CC.PeriodosLiquida,CC.CuentaContable,CC.Sec as SecConfig " +
" From ConfigConceptos CC INNER JOIN Nominas N ON CC.Nomina = N.SecNomina " +
" INNER JOIN ConceptosNomina C ON CC.Concepto = C.Sec " + Parametros + " " + Orden

            dt = SMT_AbrirTabla(ObjetoApiNomina, sql)
            If dt.Rows.Count > 0 Then
                gcConfigConceptos.DataSource = dt
            Else
                gcConfigConceptos.DataSource = Nothing
            End If

        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "LlenaGrillaConfigConceptos")
        End Try
    End Sub

    Public Sub LimpiarCampos()
        Sec_Configuracion = ""
        txtConcepto.ValordelControl = ""
        txtFormula.ValordelControl = ""

        txtNomina.ValordelControl = ""
        Buscando = False
        txtNoBuscando()
        ckePeriodo1.Checked = True
        ckePeriodo2.Checked = False
        ckePeriodo3.Checked = False
        LlenaGrillaConfigConceptos("")
        gcConfigConceptos.Focus()
    End Sub
    Private Function GuardaDatos(Sec As Integer, SecConfig As String, Nomina As String, Concepto As String, Formula As String, PeriodosLiquida As String) As Boolean
        Try
            ConfigConcepto = New ConfigConceptos
            ConfigConcepto.Nomina = txtNomina.ValordelControl
            ConfigConcepto.Sec = Sec
            ConfigConcepto.Formula = txtFormula.ValordelControl
            ConfigConcepto.Concepto = txtConcepto.ValordelControl
            Dim RegConfigConcepto As New ServiceConfigConceptos
            Dim registro As JArray
            If RegConfigConcepto.ValidarCampos(ConfigConcepto) Then
                registro = RegConfigConcepto.UpsertConfigConcepto(ConfigConcepto)
            End If
            If registro.Count > 0 Then
                Return True
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "Guardando ConfigConceptos")
            Return False
        End Try
    End Function
    Private Sub CargarDatos()
        Try
            Sec_Configuracion = gvConfigConceptos.GetFocusedRowCellValue("SecConfig").ToString
            txtNomina.ValordelControl = gvConfigConceptos.GetFocusedRowCellValue("SecNomina").ToString
            txtConcepto.ValordelControl = gvConfigConceptos.GetFocusedRowCellValue("SecConcepto").ToString
            txtFormula.ValordelControl = gvConfigConceptos.GetFocusedRowCellValue("Formula").ToString

            If gvConfigConceptos.GetFocusedRowCellValue("PeriodosLiquida").ToString = "1" Then
                ckePeriodo1.Checked = True
                ckePeriodo2.Checked = False
                ckePeriodo3.Checked = False
            ElseIf gvConfigConceptos.GetFocusedRowCellValue("PeriodosLiquida").ToString = "2" Then
                ckePeriodo1.Checked = False
                ckePeriodo2.Checked = True
                ckePeriodo3.Checked = False
            ElseIf gvConfigConceptos.GetFocusedRowCellValue("PeriodosLiquida").ToString = "3" Then
                ckePeriodo3.Checked = True
                ckePeriodo1.Checked = False
                ckePeriodo2.Checked = False
            ElseIf gvConfigConceptos.GetFocusedRowCellValue("PeriodosLiquida").ToString = "1,2" Then
                ckePeriodo1.Checked = True
                ckePeriodo2.Checked = True
                ckePeriodo3.Checked = False
            ElseIf gvConfigConceptos.GetFocusedRowCellValue("PeriodosLiquida").ToString = "1,3" Then
                ckePeriodo1.Checked = True
                ckePeriodo3.Checked = True
                ckePeriodo2.Checked = False
            ElseIf gvConfigConceptos.GetFocusedRowCellValue("PeriodosLiquida").ToString = "1,2,3" Then
                ckePeriodo1.Checked = True
                ckePeriodo2.Checked = True
                ckePeriodo3.Checked = True
            ElseIf gvConfigConceptos.GetFocusedRowCellValue("PeriodosLiquida").ToString = "2,3" Then
                ckePeriodo2.Checked = True
                ckePeriodo3.Checked = True
                ckePeriodo1.Checked = False
            Else
                ckePeriodo2.Checked = False
                ckePeriodo3.Checked = False
                ckePeriodo1.Checked = False
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "Cargar datos")
        End Try
    End Sub

    Private Sub AsignaMsgAcontroles()
        Try
            txtFormula.MensajedeAyuda = "Digite la formula del Concepto que se esta registrando o modificando. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "AsignaMsgAcontroles")
        End Try
    End Sub

    Private Sub ckePeriodo1_Enter(sender As Object, e As EventArgs) Handles ckePeriodo1.Enter, ckePeriodo2.Enter, ckePeriodo3.Enter
        Try
            Dim ck As DevExpress.XtraEditors.CheckEdit = CType(sender, DevExpress.XtraEditors.CheckEdit)
            ck.Font = New Font(ck.Font.FontFamily, ck.Font.Size, FontStyle.Bold)
            ck.BorderStyle = BorderStyles.HotFlat
            ck.BackColor = Datos.ColordeFondoTxtFoco
            FrmPrincipal.MensajeDeAyuda.Caption = "En que periodos del mes desea liquidar este concepto?. (ENTER)=Avanzar;(ESC,ARB)=Atras"
            FrmPrincipal.MensajeDeAyuda.Refresh()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub ckePeriodo1_CheckedChanged(sender As Object, e As EventArgs) Handles ckePeriodo1.CheckedChanged
        If ckePeriodo1.Checked = False And ckePeriodo2.Checked = False And ckePeriodo3.Checked = False Then
            ckePeriodo1.Checked = True
        End If
    End Sub

    Private Sub ckePeriodo2_CheckedChanged(sender As Object, e As EventArgs) Handles ckePeriodo2.CheckedChanged
        If ckePeriodo1.Checked = False And ckePeriodo2.Checked = False And ckePeriodo3.Checked = False Then
            ckePeriodo2.Checked = True
        End If
    End Sub

    Private Sub ckePeriodo3_CheckedChanged(sender As Object, e As EventArgs) Handles ckePeriodo3.CheckedChanged
        If ckePeriodo1.Checked = False And ckePeriodo2.Checked = False And ckePeriodo3.Checked = False Then
            ckePeriodo3.Checked = True
        End If
    End Sub
    Private Sub ckePeriodo1_Leave(sender As Object, e As EventArgs) Handles ckePeriodo1.Leave, ckePeriodo2.Leave, ckePeriodo3.Leave
        Try
            Dim ck As DevExpress.XtraEditors.CheckEdit = CType(sender, DevExpress.XtraEditors.CheckEdit)
            ck.Font = New Font(ck.Font.FontFamily, ck.Font.Size, FontStyle.Regular)
            ck.BorderStyle = BorderStyles.Default
            ck.BackColor = Color.Transparent
            FrmPrincipal.MensajeDeAyuda.Caption = ""
            FrmPrincipal.MensajeDeAyuda.Refresh()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ckePeriodo1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ckePeriodo3.KeyPress, ckePeriodo2.KeyPress, ckePeriodo1.KeyPress
        HDevExpre.AvanzaConEnter(e)
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
        gcConfigConceptos.DataSource = dv
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

    Private Sub CreaColumnas(Grid As GridView, Nombre As String, Titulo As String, Visible As Boolean, Editar As Boolean, formula As String, colores As System.Drawing.Color, numerico As Boolean)
        Dim gc As New GridColumn
        With gc
            .FieldName = Nombre
            .Name = Nombre
            .Caption = Titulo
            If formula <> "" Then
                .UnboundExpression = formula
                .ShowUnboundExpressionMenu = True
            Else
                .ShowUnboundExpressionMenu = False
            End If
            If numerico = True Then
                .UnboundType = DevExpress.Data.UnboundColumnType.Decimal
                .DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                .DisplayFormat.FormatString = "c2"
            End If
            .AppearanceCell.Options.UseBackColor = True
            .AppearanceCell.BackColor = colores
            .OptionsColumn.AllowSize = True
            .OptionsColumn.AllowMove = True
            .OptionsColumn.AllowEdit = Editar
            .OptionsColumn.AllowFocus = True
            .OptionsFilter.AllowFilter = False
            .Visible = Visible

            .AppearanceHeader.Options.UseTextOptions = True
            .AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        End With
        Grid.OptionsSelection.EnableAppearanceFocusedCell = False
        Grid.OptionsSelection.EnableAppearanceFocusedRow = True
        Grid.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
        Grid.Appearance.FocusedRow.Font = New Font("Tahoma", Grid.Appearance.Row.Font.Size, System.Drawing.FontStyle.Bold)
        Grid.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Grid.Columns.Add(gc)
    End Sub

    Private Sub Creagrillahorizontal()
        gvVariables.Columns.Clear()
        Dim sql As String
        Dim filas As New DataTable
        Dim NuevaFila As DataRow = filas.NewRow()
        Dim dt As DataTable = New DataTable
        Dim coloor As System.Drawing.Color = Color.White

        'Variables predeterminadas
        CreaColumnas(gvVariables, "Asignacion", "Asignacion", True, True, "", Color.FromArgb(&HFF, &HE3, &HDB), True)
        dt.Columns.Add("Asignacion", GetType(Decimal))
        CreaColumnas(gvVariables, "HorasMes", "HorasMes", True, True, "", Color.FromArgb(&HFF, &HE3, &HDB), True)
        dt.Columns.Add("HorasMes", GetType(Decimal))
        CreaColumnas(gvVariables, "TotalPagadoMes", "TotalPagadoMes", True, True, "", Color.FromArgb(&HFF, &HE3, &HDB), True)
        dt.Columns.Add("TotalPagadoMes", GetType(Decimal))
        CreaColumnas(gvVariables, "RentaExenta", "RentaExenta", True, True, "", Color.FromArgb(&HFF, &HE3, &HDB), True)
        dt.Columns.Add("RentaExenta", GetType(Decimal))
        CreaColumnas(gvVariables, "DescuentosPorNomina", "DescuentosPorNomina", True, True, "", Color.FromArgb(&HFF, &HE3, &HDB), True)
        dt.Columns.Add("DescuentosPorNomina", GetType(Decimal))
        CreaColumnas(gvVariables, "SalarioPromedioMensualAnual", "SalarioPromedioMensualAnual", True, True, "", Color.FromArgb(&HFF, &HE3, &HDB), True)
        dt.Columns.Add("SalarioPromedioMensualAnual", GetType(Decimal))
        CreaColumnas(gvVariables, "SalarioPromedioMensualSemestral", "SalarioPromedioMensualSemestral", True, True, "", Color.FromArgb(&HFF, &HE3, &HDB), True)
        dt.Columns.Add("SalarioPromedioMensualSemestral", GetType(Decimal))
        'Variables Generales
        sql = "SELECT VG.NomVariable AS Nombre,MAX(VGD.Fecha) AS Fecha,VG.Sec AS Variable " &
              "FROM DetallesVariablesGenerales VGD INNER JOIN " &
              "VariablesGenerales VG ON VGD.Variable = vG.Sec " &
              "group by VG.NomVariable,VG.Sec"
        Dim Columnas As DataTable = SMT_AbrirTabla(ObjetoApiNomina, sql)
        If Columnas.Rows.Count > 0 Then
            For incre As Integer = 0 To Columnas.Rows.Count - 1
                Dim fecha As DateTime = CDate(Columnas.Rows(incre)("Fecha"))
                Dim fecha_s As String = fecha.ToString("dd/MM/yyyy")
                sql = "SELECT VG.NomVariable AS Nombre " &
"FROM DetallesVariablesGenerales VGD " &
"INNER JOIN VariablesGenerales VG ON VGD.Variable = vG.Sec " &
"WHERE Variable ='" + Columnas.Rows(incre)("Variable").ToString + "' AND VGD.Fecha = '" + fecha_s + "' "

                Dim ArmaColumnas As DataTable = SMT_AbrirTabla(ObjetoApiNomina, sql)
                If ArmaColumnas.Rows.Count > 0 Then
                    Dim ColorColumna As System.Drawing.Color = Color.FromArgb(&HB1, &HF3, &HDA)
                    dt.Columns.Add(ArmaColumnas.Rows(0)("Nombre").ToString, GetType(Decimal))
                    CreaColumnas(gvVariables, ArmaColumnas.Rows(0)("Nombre").ToString, ArmaColumnas.Rows(0)("Nombre").ToString, True, False, "", ColorColumna, True)
                End If
            Next
        End If

        'Variables Personales
        sql = "select NomVariable as Nombre from VariablesPersonales where EsPredeterminado = 1 OR (vigente = 1 AND EsPredeterminado = 0)"
        Columnas = SMT_AbrirTabla(ObjetoApiNomina, sql)
        If Columnas.Rows.Count > 0 Then
            For incre As Integer = 0 To Columnas.Rows.Count - 1
                Dim sasf As System.Drawing.Color = Color.FromArgb(&HFF, &HE3, &HDB)
                dt.Columns.Add(Columnas.Rows(incre)("Nombre").ToString, GetType(Decimal))
                dt.Columns(incre).AllowDBNull = False
                CreaColumnas(gvVariables, Columnas.Rows(incre)("Nombre").ToString, Columnas.Rows(incre)("Nombre").ToString, True, True, "", sasf, True)
            Next
        End If

        'Bases
        sql = "select NomBase as Nombre from BasesConceptos"
        Columnas = SMT_AbrirTabla(ObjetoApiNomina, sql)
        If Columnas.Rows.Count > 0 Then
            For incre As Integer = 0 To Columnas.Rows.Count - 1
                Dim sasf As System.Drawing.Color = Color.FromArgb(&HFF, &HE3, &HDB)
                dt.Columns.Add(Columnas.Rows(incre)("Nombre").ToString, GetType(Decimal))
                dt.Columns(incre).AllowDBNull = False
                CreaColumnas(gvVariables, Columnas.Rows(incre)("Nombre").ToString, Columnas.Rows(incre)("Nombre").ToString, True, True, "", sasf, True)
            Next
        End If

        'Conceptos
        sql = "select NomConcepto as Nombre from ConceptosNomina"
        Columnas = SMT_AbrirTabla(ObjetoApiNomina, sql)
        If Columnas.Rows.Count > 0 Then
            For incre As Integer = 0 To Columnas.Rows.Count - 1
                Dim sasf As System.Drawing.Color = Color.FromArgb(&HFF, &HE3, &HDB)
                dt.Columns.Add(Columnas.Rows(incre)("Nombre").ToString, GetType(Decimal))
                dt.Columns(incre).AllowDBNull = False
                CreaColumnas(gvVariables, Columnas.Rows(incre)("Nombre").ToString, Columnas.Rows(incre)("Nombre").ToString, True, True, "", sasf, True)
            Next
        End If


        Try
            gcVariables.DataSource = dt
        Catch ex As Exception
            Dim asfds As String = ex.Data.ToString
        End Try
        CreaColumnas(gvVariables, "formu", "formu", True, True, "", Color.FromArgb(&HFF, &HE3, &HDB), True)
    End Sub

    Private Sub txtFormula_Enter(sender As Object, e As EventArgs) Handles txtFormula.Enter
        gvVariables.Columns(gvVariables.Columns.Count - 1).UnboundExpression = txtFormula.ValordelControl
        gvVariables.ShowUnboundExpressionEditor(gvVariables.Columns(gvVariables.Columns.Count - 1))
        txtFormula.ValordelControl = gvVariables.Columns(gvVariables.Columns.Count - 1).UnboundExpression
        If txtFormula.ValordelControl <> "" Then
            If HDevExpre.MsgSamit(String.Format("Desea validar la formula?"), MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.OK Then
                Dim classResize As New ClaseResize
                classResize.Resizamodales(FrmValidaFormulas, 70, 25)
                FrmValidaFormulas.Formula = txtFormula.ValordelControl
                FrmValidaFormulas.Show()
                FrmValidaFormulas.BringToFront()
            End If
        End If
    End Sub
    Private Sub btnAbrirFormula_Click(sender As Object, e As EventArgs) Handles btnAbrirFormula.Click
        gvVariables.Columns(gvVariables.Columns.Count - 1).UnboundExpression = txtFormula.ValordelControl
        gvVariables.ShowUnboundExpressionEditor(gvVariables.Columns(gvVariables.Columns.Count - 1))
        txtFormula.ValordelControl = gvVariables.Columns(gvVariables.Columns.Count - 1).UnboundExpression
        If txtFormula.ValordelControl <> "" Then
            If HDevExpre.MsgSamit(String.Format("Desea validar la formula?"), MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.OK Then
                Dim classResize As New ClaseResize
                classResize.Resizamodales(FrmValidaFormulas, 70, 25)
                FrmValidaFormulas.Formula = txtFormula.ValordelControl
                FrmValidaFormulas.Show()
                FrmValidaFormulas.BringToFront()
            End If
        End If
    End Sub
#End Region

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        FrmBusquedaConceptos.Fomulario = "FrmConfigConceptos"
        FrmBusquedaConceptos.ShowDialog()
        FrmBusquedaConceptos.BringToFront()
        If P_Consulto Then
            gcConfigConceptos.Focus()
            P_Consulto = False
        End If
    End Sub

End Class