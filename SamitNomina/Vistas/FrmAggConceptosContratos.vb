Imports SamitCtlNet
Imports DevExpress.Utils
Imports System.ComponentModel
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraEditors.Controls
Imports System.Data.SqlClient
Imports SamitNominaLogic
Imports Newtonsoft.Json.Linq

Public Class FrmAggConceptosContratos
    Dim dt As DataTable
    Dim Buscando As Boolean = False
    Dim Actualizando As Boolean = False
    Dim Sec_Concepto As String = ""
    Dim Datos As New SamitCtlNet.SamitCtlNet
    Dim secReg As Integer = 0

    Dim FormularioAbierto As Boolean = False
    Dim HDevExpre As New HelperDevExpress
    Dim HNomina As New HelperNomina
    Dim ConceptosContratos As New ConceptosPersonales
    Public Property P_FormularioAbierto() As Boolean
        Get
            Return FormularioAbierto
        End Get
        Set(value As Boolean)
            FormularioAbierto = value
        End Set
    End Property

    Private Sub FrmAggConceptosNomina_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AcomodaForm()
        LimpiarCampos()
        txtNoBuscando()
        Creagrillahorizontal()
        CreaGrilla()
        LlenaGrillaConceptos()
        AsignaScriptAcontroles()
        txtNombre.Focus()
        AsignaMsgAcontroles()
        txtNombre.MaximoAncho = AnchoCampoSql(ObjetoApiNomina, "ConceptosPersonales", "NomConcepto")
    End Sub

#Region "Eventos Controles"
    Private Sub txtBusqueda_EditValueChanged(sender As Object, e As EventArgs) Handles txtBusqueda.EditValueChanged
        Dim buscando As Boolean = Me.Buscando
        If buscando Then
            FiltrarDatos(txtBusqueda.Text)
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

    Public Function ValidaCampos() As Boolean
        If txtNombre.ValordelControl = "" Then
            HDevExpre.MensagedeError("El campo nombre no puede estar vacío!..")
            txtNombre.Focus()
            Return False
        ElseIf txtClasificacion.ValordelControl <> "" And txtClasificacion.DescripciondelControl = "No Se Encontraron Registros" Or txtClasificacion.ValordelControl <> "" And txtClasificacion.DescripciondelControl = "" Or txtClasificacion.ValordelControl = "" Then
            HDevExpre.MensagedeError("El campo tipo concepto no puede estar vacío o contener valores invalidos!..")
            txtClasificacion.Focus()
            Return False
        ElseIf txtMaximoDescuento.ValordelControl = "" Then
            HDevExpre.MensagedeError("El campo maximo a descontar no puede estar vacío!..")
            txtMaximoDescuento.Focus()
            Return False
        ElseIf ckePeriodo1.Checked = False And ckePeriodo2.Checked = False And ckePeriodo3.Checked = False Then
            HDevExpre.MensagedeError("Tiene que selecionar al menos un periodo del mes a liquidar!..")
            ckePeriodo1.Focus()
            Return False
        Else
            Return True
        End If
    End Function

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
            If GuardaDatos(sec, Sec_Concepto, txtNombre.ValordelControl, grbVigente.SelectedIndex.ToString(), txtClasificacion.ValordelControl, Periodos, txtMaximoDescuento.ValordelControl, txtCodDian.ValordelControl,
                       Actualizando) Then
                HDevExpre.mensajeExitoso("Información Guardada exitosamente")
                LlenaGrillaConceptos()
                Creagrillahorizontal()
                LimpiarCampos()
            Else
                HDevExpre.MensagedeError("Error al guardar los datos!")
            End If
        Else
            Exit Sub
        End If
    End Sub

    Private Sub gvConceptos_DoubleClick(sender As Object, e As EventArgs) Handles gvConceptos.DoubleClick
        CargarDatos()
    End Sub

    Private Sub gvConceptos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles gvConceptos.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            CargarDatos()
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If Not Actualizando Or Sec_Concepto = "" Then
            HDevExpre.MensagedeError("Debe seleccionar el item que desea editar o eliminar, selecciona con doble clic!")
            Exit Sub
        End If
        EliminaConceptos(Sec_Concepto)
    End Sub
    Private Sub FrmAggConceptosNomina_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
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
            HDevExpre.msgError(ex, ex.Message, "AcomodaForm Agrega Conceptos!")
        End Try
    End Sub

    Private Sub AsignaScriptAcontroles()
        Try
            txtClasificacion.ConsultaSQL = String.Format("SELECT Sec AS Codigo,Nom As Descripcion FROM  ClasConceptosPersonales")
            txtCodDian.ConsultaSQL = String.Format("SELECT * FROM  CodigosDian")
            txtCodDian.RefrescarDatos()
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "AsignaScriptAcontroles")
        End Try
    End Sub
    Private Sub CreaGrilla()
        Try
            gvConceptos.Columns.Clear()
            HDevExpre.CreaColumnasG(gvConceptos, "Sec", "Sec", False, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 0, 0)
            HDevExpre.CreaColumnasG(gvConceptos, "NomConcepto", "Nombre", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 30, gbxPrincipal.Width)
            HDevExpre.CreaColumnasG(gvConceptos, "Clasificacion", "Clasificacion", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 20, gbxPrincipal.Width)
            HDevExpre.CreaColumnasG(gvConceptos, "Descuento", "Maximo a descontar", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 30, gbxPrincipal.Width)
            HDevExpre.CreaColumnasG(gvConceptos, "PeriodosLiquida", "Periodos de liquidacion", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 10, gbxPrincipal.Width)
            HDevExpre.CreaColumnasG(gvConceptos, "Vigente", "Vigente", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 10, gbxPrincipal.Width)
            HDevExpre.CreaColumnasG(gvConceptos, "CodDian", "Codigo Dian", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 20, gbxPrincipal.Width)
            gvConceptos.OptionsView.ShowFooter = True
            gvConceptos.Appearance.HeaderPanel.Font = New Font("Trebuchet MS", 11.0!, FontStyle.Bold)
            gvConceptos.Columns(5).Summary.Add(DevExpress.Data.SummaryItemType.Count, "", "{0}  Registros")
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "Crea Grilla")
        End Try
    End Sub
    Private Sub LlenaGrillaConceptos()
        Try
            Dim sql As String = " SELECT CP.CodDian,CP.Sec,CP.NomConcepto,CP.PeriodosLiquida,CP.ValMaxDescuento as Descuento," +
                                " case CP.Vigente  WHEN '1' then 'Si' when '0' then 'No' end As Vigente,CCP.Nom As Clasificacion, " +
                                " CCP.Sec as SecClasificacion FROM ConceptosPersonales CP " +
                                " INNER JOIN ClasConceptosPersonales CCP on CP.Clasificacion = CCP.Sec "
            dt = SMT_AbrirTabla(ObjetoApiNomina, sql)
            If dt.Rows.Count > 0 Then
                gcConceptos.DataSource = dt
            Else
                HDevExpre.mensajeExitoso("No se registra ningun concepto, podemos empezar ingresandolos!..")
                gcConceptos.DataSource = Nothing
            End If

        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "LlenaGrillaConceptos")
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
        gcConceptos.DataSource = dv
    End Sub

    Private Sub LimpiarCampos()
        Sec_Concepto = ""
        Actualizando = False
        txtNombre.ValordelControl = ""
        txtCodDian.ValordelControl = ""
        ckePeriodo1.Checked = True
        grbVigente.SelectedIndex = 1
        ckePeriodo2.Checked = False
        ckePeriodo3.Checked = False
        txtClasificacion.ValordelControl = ""
        txtMaximoDescuento.ValordelControl = ""
        grbVigente.ReadOnly = False
        Buscando = False
        txtNoBuscando()
        gcConceptos.DataSource = dt
        txtNombre.Focus()
        Try
            gvVariables.Columns(gvVariables.Columns.Count - 1).UnboundExpression = ""
        Catch ex As Exception
        End Try
    End Sub

    Private Function ValidaNombres(Sec As String, Nombre As String, EstaActualizando As Boolean) As Boolean
        If Not EstaActualizando Then
            If HNomina.ValidaNombresR(txtNombre.ValordelControl) Then
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
" ) as Consul Where Consul.Nombre ='" + txtNombre.ValordelControl + "'"
            Dim dt As DataTable = SMT_AbrirTabla(ObjetoApiNomina, sql)
            If dt.Rows.Count > 1 Then
                HDevExpre.MensagedeError("Ya existe un registro con este nombre (Los Conceptos,Variables Generales,Variables Personales y Bases no pueden coincidir en el nombre)!..")
                Return False

            ElseIf dt.Rows.Count = 1 Then
                If dt.Rows(0)("tipo").ToString <> "CP" Then
                    HDevExpre.MensagedeError("Ya existe un registro con este nombre (Los Conceptos,Variables Generales,Variables Personales y Bases no pueden coincidir en el nombre)!..")
                    Return False

                ElseIf dt.Rows(0)("tipo").ToString = "CP" And dt.Rows(0)("Sec").ToString <> Sec Then
                    HDevExpre.MensagedeError("Ya existe un registro con este nombre (Los Conceptos,Variables Generales,Variables Personales y Bases no pueden coincidir en el nombre)!..")
                    Return False
                End If
            End If
        End If
        Return True
    End Function

    Private Function GuardaDatos(Sec As Integer, SecConceptos As String, NomConcepto As String, Vigente As String, Clasificacion As String, PeriodoLiquida As String, MaximoDescuento As String, CodDian As String, EstaActualizando As Boolean) As Boolean
        Try
            ConceptosContratos = New ConceptosPersonales
            ConceptosContratos.NomConcepto = txtNombre.ValordelControl
            ConceptosContratos.Sec = Sec
            ConceptosContratos.Vigente = grbVigente.SelectedIndex.ToString()
            ConceptosContratos.ValMaxDescuento = txtMaximoDescuento.ValordelControl
            ConceptosContratos.Clasificacion = txtClasificacion.ValordelControl
            ConceptosContratos.CodDian = txtCodDian.ValordelControl

            Dim RegConceptoContratos As New ServiceConceptoContratos
            Dim registro As JArray
            If RegConceptoContratos.ValidarCampos(ConceptosContratos) Then
                registro = RegConceptoContratos.UpsertConceptosContratos(ConceptosContratos)
            End If
            If registro.Count > 0 Then
                Return True
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "Guardando Conceptos")
            Return False
        End Try
    End Function
    Private Sub CargarDatos()
        Try
            grbVigente.ReadOnly = False
            Sec_Concepto = gvConceptos.GetFocusedRowCellValue("Sec").ToString
            txtNombre.ValordelControl = gvConceptos.GetFocusedRowCellValue("NomConcepto").ToString
            txtCodDian.ValordelControl = gvConceptos.GetFocusedRowCellValue("CodDian").ToString
            If gvConceptos.GetFocusedRowCellValue("PeriodosLiquida").ToString = "1" Then
                ckePeriodo1.Checked = True
                ckePeriodo2.Checked = False
                ckePeriodo3.Checked = False
            ElseIf gvConceptos.GetFocusedRowCellValue("PeriodosLiquida").ToString = "2" Then
                ckePeriodo1.Checked = False
                ckePeriodo2.Checked = True
                ckePeriodo3.Checked = False
            ElseIf gvConceptos.GetFocusedRowCellValue("PeriodosLiquida").ToString = "3" Then
                ckePeriodo3.Checked = True
                ckePeriodo1.Checked = False
                ckePeriodo2.Checked = False
            ElseIf gvConceptos.GetFocusedRowCellValue("PeriodosLiquida").ToString = "1,2" Then
                ckePeriodo1.Checked = True
                ckePeriodo2.Checked = True
                ckePeriodo3.Checked = False
            ElseIf gvConceptos.GetFocusedRowCellValue("PeriodosLiquida").ToString = "1,3" Then
                ckePeriodo1.Checked = True
                ckePeriodo3.Checked = True
                ckePeriodo2.Checked = False
            ElseIf gvConceptos.GetFocusedRowCellValue("PeriodosLiquida").ToString = "1,2,3" Then
                ckePeriodo1.Checked = True
                ckePeriodo2.Checked = True
                ckePeriodo3.Checked = True
            ElseIf gvConceptos.GetFocusedRowCellValue("PeriodosLiquida").ToString = "2,3" Then
                ckePeriodo2.Checked = True
                ckePeriodo3.Checked = True
                ckePeriodo1.Checked = False
            Else
                ckePeriodo2.Checked = False
                ckePeriodo3.Checked = False
                ckePeriodo1.Checked = False
            End If
            txtClasificacion.ValordelControl = gvConceptos.GetFocusedRowCellValue("SecClasificacion").ToString
            txtMaximoDescuento.ValordelControl = gvConceptos.GetFocusedRowCellValue("Descuento").ToString
            If gvConceptos.GetFocusedRowCellValue("Vigente").ToString = "Si" Then
                grbVigente.SelectedIndex = 1
            Else
                grbVigente.SelectedIndex = 0
            End If

            Dim sql As String = "SELECT * FROM NominaLiquidaConceptos WHERE SecConcepto = " + Sec_Concepto
            Dim dt As DataTable = SMT_AbrirTabla(ObjetoApiNomina, sql)
            If dt.Rows.Count > 0 Then
                grbVigente.ReadOnly = True
            End If
            Actualizando = True
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "Cargar datos de los Conceptos")
        End Try
    End Sub
    Private Sub EliminaConceptos(SecVar As String)
        Try
            If Not Actualizando Or secReg = 0 Then
                HDevExpre.MensagedeError("No ha cargado ninguna entidad para ser eliminada.")
                Exit Sub
            End If
            If HDevExpre.MsgSamit(String.Format("Seguro que desea eliminar item seleccionado [{0}]", txtNombre.ValordelControl), MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.OK Then
                ConceptosContratos = New ConceptosPersonales
                ConceptosContratos.Sec = secReg

                Dim RegConceptoContrato As New ServiceConceptoContratos
                Dim registro As JArray
                registro = RegConceptoContrato.EliminarConceptosContratos(ConceptosContratos)
                LimpiarCampos()
                LlenaGrillaConceptos()
            Else
                HDevExpre.MensagedeError("Error al eiminar el concepto!")
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "EliminaConceptos")
        End Try
    End Sub
#End Region


    Private Sub FrmAggConceptosNomina_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        LimpiarCampos()
        Buscando = False
        txtNoBuscando()
    End Sub

    Private Sub AsignaMsgAcontroles()
        Try
            txtNombre.MensajedeAyuda = "Digite el nombre del Concepto. (ENTER,ABJ)=Avanzar"
            txtMaximoDescuento.MensajedeAyuda = "Digite el Valor maximo a descontar del Concepto que se esta registrando o modificando . (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
            txtClasificacion.MensajedeAyuda = "Seleccione el tipo del concepto.  (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "AsignaMssAcontroles")
        End Try
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
        CreaColumnas(gvVariables, "NetoAPagar", "NetoAPagar", True, True, "", Color.FromArgb(&HFF, &HE3, &HDB), True)
        dt.Columns.Add("NetoAPagar", GetType(Decimal))
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

    Private Sub grbVigente_Enter(sender As Object, e As EventArgs) Handles grbVigente.Enter
        HDevExpre.EntraControlRadioGroup(grbVigente, lblVigente)
        FrmPrincipal.MensajeDeAyuda.Caption = "Estado del Concepto. (ENTER)=Avanzar;(ESC,ARB)=Atras"
        FrmPrincipal.MensajeDeAyuda.Refresh()
    End Sub

    Private Sub grbVigente_Leave(sender As Object, e As EventArgs) Handles grbVigente.Leave
        HDevExpre.SaleControlRadioGroup(grbVigente, lblVigente)
        FrmPrincipal.MensajeDeAyuda.Caption = ""
        FrmPrincipal.MensajeDeAyuda.Refresh()
    End Sub

    Private Sub grbVigente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles grbVigente.KeyPress, ckePeriodo3.KeyPress, ckePeriodo2.KeyPress, ckePeriodo1.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            btnGuardar.Focus()
        End If
        If e.KeyChar = ChrW(Keys.Escape) Then
            ckePeriodo1.Focus()
        End If
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

    Private Sub ckeRedonAlPeso_Click(sender As Object, e As EventArgs)
        FrmPrincipal.MensajeDeAyuda.Caption = "A que desea redondear el valor de este concepto?. (ENTER)=Avanzar;(ESC,ARB)=Atras"
        FrmPrincipal.MensajeDeAyuda.Refresh()
    End Sub

    Private Sub grbVigente_Click(sender As Object, e As EventArgs) Handles grbVigente.Click
        FrmPrincipal.MensajeDeAyuda.Caption = "Estado del Concepto. (ENTER)=Avanzar;(ESC,ARB)=Atras"
        FrmPrincipal.MensajeDeAyuda.Refresh()
    End Sub


    Private Sub txtMaximoDescuento_Enter(sender As Object, e As EventArgs) Handles txtMaximoDescuento.Enter
        gvVariables.Columns(gvVariables.Columns.Count - 1).UnboundExpression = txtMaximoDescuento.ValordelControl
        gvVariables.ShowUnboundExpressionEditor(gvVariables.Columns(gvVariables.Columns.Count - 1))
        txtMaximoDescuento.ValordelControl = gvVariables.Columns(gvVariables.Columns.Count - 1).UnboundExpression
        If txtMaximoDescuento.ValordelControl <> "" Then
            If HDevExpre.MsgSamit(String.Format("Desea validar la formula?"), MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.OK Then
                Dim classResize As New ClaseResize
                classResize.Resizamodales(FrmValidaFormulas, 70, 25)
                FrmValidaFormulas.Formula = txtMaximoDescuento.ValordelControl
                FrmValidaFormulas.Show()
                FrmValidaFormulas.BringToFront()
            End If
        End If
    End Sub
    Private Sub btnAbrirFormula_Click(sender As Object, e As EventArgs) Handles btnAbrirFormula.Click
        gvVariables.Columns(gvVariables.Columns.Count - 1).UnboundExpression = txtMaximoDescuento.ValordelControl
        gvVariables.ShowUnboundExpressionEditor(gvVariables.Columns(gvVariables.Columns.Count - 1))
        txtMaximoDescuento.ValordelControl = gvVariables.Columns(gvVariables.Columns.Count - 1).UnboundExpression
        If txtMaximoDescuento.ValordelControl <> "" Then
            If HDevExpre.MsgSamit(String.Format("Desea validar la formula?"), MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.OK Then
                Dim classResize As New ClaseResize
                classResize.Resizamodales(FrmValidaFormulas, 70, 25)
                FrmValidaFormulas.Formula = txtMaximoDescuento.ValordelControl
                FrmValidaFormulas.Show()
                FrmValidaFormulas.BringToFront()
            End If
        End If
    End Sub

    Private Sub btnSalir_KeyPress(sender As Object, e As KeyPressEventArgs) Handles btnSalir.KeyPress, btnLimpiar.KeyPress, btnGuardar.KeyPress, btnEliminar.KeyPress
        HDevExpre.AtrasConScape(e)
    End Sub
End Class