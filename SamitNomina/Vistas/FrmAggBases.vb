Imports SamitCtlNet
Imports DevExpress.Utils
Imports System.ComponentModel
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraEditors.Controls
Imports SamitNominaLogic
Imports Newtonsoft.Json.Linq

Public Class FrmAggBases
    Dim dt As DataTable
    Dim Buscando As Boolean = False
    Dim Actualizando As Boolean = False
    Dim secReg As Integer = 0
    Dim Sec_Bases As String = ""
    Dim Nom_Base As String = ""

    Dim FormularioAbierto As Boolean = False
    Dim HDevExpre As New HelperDevExpress
    Dim HNomina As New HelperNomina
    Dim Bases As New BasesConceptos
    Public Property P_FormularioAbierto() As Boolean
        Get
            Return FormularioAbierto
        End Get
        Set(value As Boolean)
            FormularioAbierto = value
        End Set
    End Property


    Private Sub FrmAggBases_Load(sender As Object, e As EventArgs) Handles Me.Load
        AcomodaForm()
        txtNoBuscando()
        Creagrillahorizontal()
        CreaGrilla()
        LlenaGrillaBases()
        txtNombreBase.MensajedeAyuda = "Digite el nombre de la base que desea insertar. (ENTER,TAB)=Avanzar"
        txtFormula.MensajedeAyuda = "Digite la formula de la Base que se esta registrando o modificando. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
        txtNombreBase.MaximoAncho = AnchoCampoSql(ObjetoApiNomina, "BasesConceptos", "NomBase")
        txtFormula.MaximoAncho = AnchoCampoSql(ObjetoApiNomina, "BasesConceptos", "Formula")
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
        If ValidaCampos() Then
            Dim sec As Integer = 0
            If Actualizando Then sec = secReg
            If GuardaDatos(sec, txtNombreBase.ValordelControl, txtFormula.ValordelControl, grbVigente.SelectedIndex.ToString(),
                       Actualizando) Then
                HNomina.ModNomFormulas(Nom_Base, txtNombreBase.ValordelControl)
                HDevExpre.mensajeExitoso("Información Guardada exitosamente")
                LlenaGrillaBases()
                Creagrillahorizontal()
                LimpiarCampos()
            Else
                HDevExpre.MensagedeError("Error al guardar los datos!")
            End If
        Else
            Exit Sub
        End If
    End Sub

    Public Function ValidaCampos() As Boolean
        If txtNombreBase.ValordelControl = "" Then
            HDevExpre.MensagedeError("El campo nombre no puede estar vacío!..")
            txtNombreBase.Focus()
            Return False
        ElseIf txtFormula.ValordelControl = "" Then
            HDevExpre.MensagedeError("El campo formula no puede estar vacío!..")
            txtFormula.Focus()
            Return False
        ElseIf Not ValidaFormula() Then
            HDevExpre.MensagedeError("La formula de este concepto depende de él mismo!..")
            Return False
        Else
            Return True
        End If

    End Function

    Private Sub gvBases_DoubleClick(sender As Object, e As EventArgs) Handles gvBases.DoubleClick
        CargarDatos()
    End Sub

    Private Sub gvBases_KeyPress(sender As Object, e As KeyPressEventArgs) Handles gvBases.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            CargarDatos()
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If Not Actualizando Or Sec_Bases = "" Then
            HDevExpre.MensagedeError("Debe seleccionar el item que desea editar o eliminar, selecciona con doble clic!")
            Exit Sub
        End If
        EliminaBases(Sec_Bases, Nom_Base)
    End Sub
    Private Sub FrmAggBases_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
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
            btnAbrirFormula.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Formula)
            grbVigente.SelectedIndex = 1

        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "AcomodaForm Agrega Bases!")
        End Try
    End Sub
    Private Sub CreaGrilla()
        Try
            gvBases.Columns.Clear()
            HDevExpre.CreaColumnasG(gvBases, "Sec", "Sec", False, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 0, 0)
            HDevExpre.CreaColumnasG(gvBases, "NomBase", "Nombre", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 50, gbxPrincipal.Width)
            HDevExpre.CreaColumnasG(gvBases, "Formula", "Formula", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 25, gbxPrincipal.Width)
            HDevExpre.CreaColumnasG(gvBases, "Vigente", "Vigente", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 25, gbxPrincipal.Width)
            gvBases.OptionsView.ShowFooter = True
            gvBases.Appearance.HeaderPanel.Font = New Font("Trebuchet MS", 11.0!, FontStyle.Bold)
            gvBases.Columns(3).Summary.Add(DevExpress.Data.SummaryItemType.Count, "", "{0}  Registros")
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "Crea Grilla")
        End Try
    End Sub
    Private Sub LlenaGrillaBases()
        Try
            Dim sql As String = "SELECT Sec,NomBase,Formula,case Vigente " +
                                " WHEN '1' then 'Si' when '0' then 'No' end As Vigente FROM BasesConceptos "
            dt = SMT_AbrirTabla(ObjetoApiNomina, sql)
            If dt.Rows.Count > 0 Then
                gcBases.DataSource = dt
            Else
                HDevExpre.mensajeExitoso("No se registra ninga base, podemos empezar ingresandolas!..")
                gcBases.DataSource = Nothing
            End If

        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "LlenaGrillaBases")
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
        gcBases.DataSource = dv
    End Sub

    Private Sub LimpiarCampos()
        secReg = 0
        Nom_Base = ""
        Actualizando = False
        txtNombreBase.ValordelControl = ""
        txtFormula.ValordelControl = ""
        grbVigente.SelectedIndex = 1
        Buscando = False
        txtNoBuscando()
        gcBases.DataSource = dt
        txtNombreBase.Focus()
        Try
            gvVariables.Columns(gvVariables.Columns.Count - 1).UnboundExpression = ""
        Catch ex As Exception

        End Try

    End Sub

    'Public Function ModificaFormulas(NomBase As String, NuevoNomBase As String) As Boolean
    '    Dim sql As String = "Select Formula From ConfigConceptos WHERE Formula LIKE '%" + NomBase + "%'"
    '    Dim dt As DataTable = SMT_AbrirTabla(ObjetoApiNomina, sql)
    '    If dt.Rows.Count > 0 Then
    '        If SMT_EjcutarComandoSqlBool(ObjetoApiNomina, String.Format("UPDATE ConfigConceptos SET Formula = REPLACE(SUBSTRING(Formula, 1, DATALENGTH(Formula)),'[" + NomBase + "]', '[" + NuevoNomBase + "]')")) > 0 Then

    '        Else
    '            Return False
    '        End If
    '    End If

    '    sql = "Select ValMaxDescuento From ConceptosPersonales WHERE ValMaxDescuento LIKE '%" + NomBase + "%'"
    '    dt = SMT_AbrirTabla(ObjetoApiNomina, sql)
    '    If dt.Rows.Count > 0 Then
    '        If SMT_EjcutarComandoSqlBool(ObjetoApiNomina, String.Format("UPDATE ConceptosPersonales SET ValMaxDescuento = REPLACE(SUBSTRING(ValMaxDescuento, 1, DATALENGTH(ValMaxDescuento)),'[" + NomBase + "]', '[" + NuevoNomBase + "]')")) > 0 Then
    '        Else
    '            Return False
    '        End If
    '    End If

    '    sql = "Select Formula From BasesConceptos WHERE Formula LIKE '%" + NomBase + "%'"
    '    dt = SMT_AbrirTabla(ObjetoApiNomina, sql)
    '    If dt.Rows.Count > 0 Then
    '        If SMT_EjcutarComandoSqlBool(ObjetoApiNomina, String.Format("UPDATE BasesConceptos SET Formula = REPLACE(SUBSTRING(Formula, 1, DATALENGTH(Formula)),'[" + NomBase + "]', '[" + NuevoNomBase + "]')")) > 0 Then
    '        Else
    '            Return False
    '        End If
    '    End If

    '    sql = "Select ValorMaxDescontar From Plantillas WHERE ValorMaxDescontar LIKE '%" + NomBase + "%'"
    '    dt = SMT_AbrirTabla(ObjetoApiNomina, sql)
    '    If dt.Rows.Count > 0 Then
    '        If SMT_EjcutarComandoSqlBool(ObjetoApiNomina, String.Format("UPDATE Plantillas SET ValorMaxDescontar = REPLACE(SUBSTRING(ValorMaxDescontar, 1, DATALENGTH(ValorMaxDescontar)),'[" + NomBase + "]', '[" + NuevoNomBase + "]')")) > 0 Then
    '        Else
    '            Return False
    '        End If
    '    End If

    '    sql = "Select Formula From TiposContratos_ConceptosNomina WHERE Formula LIKE '%" + NomBase + "%'"
    '    dt = SMT_AbrirTabla(ObjetoApiNomina, sql)
    '    If dt.Rows.Count > 0 Then
    '        If SMT_EjcutarComandoSqlBool(ObjetoApiNomina, String.Format("UPDATE TiposContratos_ConceptosNomina SET Formula = REPLACE(SUBSTRING(Formula, 1, DATALENGTH(Formula)),'[" + NomBase + "]', '[" + NuevoNomBase + "]')")) > 0 Then
    '        Else
    '            Return False
    '        End If
    '    End If

    '    sql = "Select Formula From ConfigProvisiones WHERE Formula LIKE '%" + NomBase + "%'"
    '    dt = SMT_AbrirTabla(ObjetoApiNomina, sql)
    '    If dt.Rows.Count > 0 Then
    '        If SMT_EjcutarComandoSqlBool(ObjetoApiNomina, String.Format("UPDATE ConfigProvisiones SET Formula = REPLACE(SUBSTRING(Formula, 1, DATALENGTH(Formula)),'[" + NomBase + "]', '[" + NuevoNomBase + "]')")) > 0 Then
    '        Else
    '            Return False
    '        End If
    '    End If

    '    Return True
    'End Function

    Private Function ValidaNombres(Sec As String, Nombre As String, EstaActualizando As Boolean) As Boolean
        If Not EstaActualizando Then
            If HNomina.ValidaNombresR(txtNombreBase.ValordelControl) Then
                Return True
            Else
                HDevExpre.MensagedeError("Ya existe un registro con este nombre (Los Conceptos,Variables Generales,Variables Personales y Bases no pueden coincidir en el nombre)!..")
                Return False
            End If
        Else
            Dim sql As String = "Select Consul.Nombre,Consul.tipo,Consul.Sec From(  " +
" Select NomBase As Nombre,'B' as tipo,Sec as Sec From BasesConceptos" +
" Union Select NomConcepto As Nombre, 'C' as tipo,Sec as Sec From ConceptosNomina " +
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
" ) as Consul Where Consul.Nombre ='" + txtNombreBase.ValordelControl + "'"
            Dim dt As DataTable = SMT_AbrirTabla(ObjetoApiNomina, sql)
            If dt.Rows.Count > 1 Then
                HDevExpre.MensagedeError("Ya existe un registro con este nombre (Los Conceptos,Variables Generales,Variables Personales y Bases no pueden coincidir en el nombre)!..")
                Return False

            ElseIf dt.Rows.Count = 1 Then
                If dt.Rows(0)("tipo").ToString <> "B" Then
                    HDevExpre.MensagedeError("Ya existe un registro con este nombre (Los Conceptos,Variables Generales,Variables Personales y Bases no pueden coincidir en el nombre)!..")
                    Return False

                ElseIf dt.Rows(0)("tipo").ToString = "B" And dt.Rows(0)("Sec").ToString <> Sec Then
                    HDevExpre.MensagedeError("Ya existe un registro con este nombre (Los Conceptos,Variables Generales,Variables Personales y Bases no pueden coincidir en el nombre)!..")
                    Return False
                End If
            End If
        End If
        Return True
    End Function

    Private Function GuardaDatos(Sec As Integer, NomBase As String, Formula As String, Vigente As String, EstaActualizando As Boolean) As Boolean
        Try
            Bases = New BasesConceptos
            Bases.NomBase = txtNombreBase.ValordelControl
            Bases.Sec = Sec
            Bases.Vigente = grbVigente.SelectedIndex.ToString()
            Bases.Formula = txtFormula.ValordelControl
            Dim RegBases As New ServiceBases
            Dim registro As JArray
            If RegBases.ValidarCampos(Bases) Then
                registro = RegBases.UpsertBase(Bases)
            End If
            If registro.Count > 0 Then
                Return True
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "Guardando Bases")
            Return False
        End Try
    End Function
    Private Sub CargarDatos()
        Try
            Sec_Bases = gvBases.GetFocusedRowCellValue("Sec").ToString
            Nom_Base = gvBases.GetFocusedRowCellValue("NomBase").ToString
            txtNombreBase.ValordelControl = gvBases.GetFocusedRowCellValue("NomBase").ToString
            txtFormula.ValordelControl = gvBases.GetFocusedRowCellValue("Formula").ToString
            If gvBases.GetFocusedRowCellValue("Vigente").ToString = "Si" Then
                grbVigente.SelectedIndex = 1
            Else
                grbVigente.SelectedIndex = 0
            End If
            Actualizando = True
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "Cargar datos de las Bases")
        End Try
    End Sub



    Private Sub EliminaBases(SecVar As String, nomBase As String)
        If Not Actualizando Or secReg = 0 Then
            HDevExpre.MensagedeError("No ha cargado ninguna entidad para ser eliminada.")
            Exit Sub
        End If
        If HDevExpre.MsgSamit(String.Format("Seguro que desea eliminar item seleccionado [{0}]", txtNombreBase.ValordelControl), MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.OK Then
            Bases = New BasesConceptos
            Bases.Sec = secReg

            Dim RegBases As New ServiceBases
            Dim registro As JArray
            registro = RegBases.EliminarBase(Bases)

            LlenaGrillaBases()
            LimpiarCampos()
        End If

    End Sub
#End Region

    Private Sub FrmAggBases_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        LimpiarCampos()
        Buscando = False
        txtNoBuscando()
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
        CreaColumnas(gvVariables, "SalarioPromedioPeriodo", "SalarioPromedioPeriodo", True, True, "", Color.FromArgb(&HFF, &HE3, &HDB), True)
        dt.Columns.Add("SalarioPromedioPeriodo", GetType(Decimal))
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
        sql = "select NomVariable as Nombre from VariablesPersonales"
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

    Public Function ValidaFormula() As Boolean
        Dim NoDepende As Boolean = False
        Dim value As String = txtFormula.ValordelControl
        Dim valueConsulta As String = ""
        Dim Columna As String = ""
        Dim ColumnaConsulta As String = ""
        Dim Inicio As Integer = 0
        Dim Fin As Integer = 0
        Dim dt As New DataTable
        For incre As Integer = 0 To value.Length - 1
            If value.Substring(incre, 1) = "[" Then
                Inicio = incre
            End If
            If value.Substring(incre, 1) = "]" Then
                Fin = incre
                Columna = value.Substring(Inicio + 1, Fin - Inicio - 1)
                If Columna = txtNombreBase.ValordelControl Then
                    Return False
                Else
                    dt = SMT_AbrirTabla(ObjetoApiNomina, "Select Formula From BasesConceptos Where NomBase='" + Columna + "'")
                    If dt.Rows.Count > 0 Then
                        valueConsulta = dt.Rows(0)("Formula").ToString
                        For inc As Integer = 0 To valueConsulta.Length - 1
                            If valueConsulta.Substring(inc, 1) = "[" Then
                                Inicio = inc
                            End If
                            If valueConsulta.Substring(inc, 1) = "]" Then
                                Fin = inc
                                ColumnaConsulta = valueConsulta.Substring(Inicio + 1, Fin - Inicio - 1)
                                If ColumnaConsulta = txtNombreBase.ValordelControl Then
                                    Return False
                                End If
                            End If
                        Next
                    End If

                    dt = SMT_AbrirTabla(ObjetoApiNomina, "Select Formula From ConceptosNomina Where NomConcepto='" + Columna + "'")
                    If dt.Rows.Count > 0 Then
                        valueConsulta = dt.Rows(0)("Formula").ToString
                        For inc As Integer = 0 To valueConsulta.Length - 1
                            If valueConsulta.Substring(inc, 1) = "[" Then
                                Inicio = inc
                            End If
                            If valueConsulta.Substring(inc, 1) = "]" Then
                                Fin = inc
                                ColumnaConsulta = valueConsulta.Substring(Inicio + 1, Fin - Inicio - 1)
                                If ColumnaConsulta = txtNombreBase.ValordelControl Then
                                    Return False
                                End If
                            End If
                        Next
                    End If
                End If
            End If
        Next
        Return True
    End Function

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
    Private Sub grbVigente_Enter(sender As Object, e As EventArgs) Handles grbVigente.Enter
        HDevExpre.EntraControlRadioGroup(grbVigente, lblVigente, grbVigente.Font.Size, lblVigente.Font.Size)
        FrmPrincipal.MensajeDeAyuda.Refresh()
        FrmPrincipal.MensajeDeAyuda.Caption = "Estado de la Base. (ENTER)=Avanzar;(ESC,ARB)=Atras"
    End Sub

    Private Sub grbVigente_Leave(sender As Object, e As EventArgs) Handles grbVigente.Leave
        HDevExpre.SaleControlRadioGroup(grbVigente, lblVigente, grbVigente.Font.Size, lblVigente.Font.Size)
        FrmPrincipal.MensajeDeAyuda.Caption = ""
        FrmPrincipal.MensajeDeAyuda.Refresh()
    End Sub
    Private Sub grbVigente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles grbVigente.KeyPress
        HDevExpre.AvanzaConEnter(e)
    End Sub

    Private Sub grbVigente_Click(sender As Object, e As EventArgs) Handles grbVigente.Click
        FrmPrincipal.MensajeDeAyuda.Caption = "Estado de la Base. (ENTER)=Avanzar;(ESC,ARB)=Atras"
        FrmPrincipal.MensajeDeAyuda.Refresh()
    End Sub

    Private Sub txtFormula_Leave(sender As Object, e As EventArgs) Handles txtFormula.Leave
        'If grbVigente.Focus Then
        '    Dim send As New Object
        '    Dim evento As New EventArgs
        '    grbVigente_Click(send, evento)
        'End If
    End Sub

    Private Sub btnSalir_KeyPress(sender As Object, e As KeyPressEventArgs) Handles btnSalir.KeyPress, btnLimpiar.KeyPress, btnGuardar.KeyPress, btnEliminar.KeyPress
        HDevExpre.AtrasConScape(e)
    End Sub
End Class