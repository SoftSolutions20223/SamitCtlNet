Imports SamitCtlNet
Imports DevExpress.Utils
Imports System.ComponentModel
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraEditors.Controls
Imports System.Data.SqlClient
Imports SamitNominaLogic
Imports Newtonsoft.Json.Linq

Public Class FrmAggConceptosNomina
    Dim dt As DataTable
    Dim Bases As DataTable
    Dim Nominas As DataTable
    Dim TiposContratos As DataTable
    Dim Buscando As Boolean = False
    Dim Actualizando As Boolean = False
    Dim Sec_Concepto As String = ""
    Dim NomConcepto As String = ""
    Dim EsPredeterminado As Boolean = False
    Dim Datos As New SamitCtlNet.SamitCtlNet
    Dim secReg As Integer = 0
    Dim FormularioAbierto As Boolean = False
    Dim HDevExpre As New HelperDevExpress
    Dim HNomina As New HelperNomina
    Dim ConceptosNominas As New ConceptosNomina
    Public Property P_FormularioAbierto() As Boolean
        Get
            Return FormularioAbierto
        End Get
        Set(value As Boolean)
            FormularioAbierto = value
        End Set
    End Property

    Private Sub FrmAggConceptosNomina_Load(sender As Object, e As EventArgs) Handles Me.Load
        AcomodaForm()
        LimpiarCampos()
        txtNoBuscando()
        Creagrillahorizontal()
        CreaGrilla()
        LlenaGrillaConceptos()
        AsignaScriptAcontroles()
        RefrescaDatos()
        txtNombre.Focus()
        AsignaMsgAcontroles()
        txtNombre.MaximoAncho = AnchoCampoSql(ObjetoApiNomina, "ConceptosNomina", "NomConcepto")
        txtBaseCalculo.MaximoAncho = AnchoCampoSql(ObjetoApiNomina, "ConceptosNomina", "Base")
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

    Public Function ValidaCampos() As Boolean
        If txtNombre.ValordelControl = "" Then
            HDevExpre.MensagedeError("El campo nombre no puede estar vacío!..")
            txtNombre.Focus()
            Return False
        ElseIf txtTipo.ValordelControl <> "" And txtTipo.DescripciondelControl = "No Se Encontraron Registros" Or txtTipo.ValordelControl <> "" And txtTipo.DescripciondelControl = "" Or txtTipo.ValordelControl = "" Then
            HDevExpre.MensagedeError("El campo tipo concepto no puede estar vacío o contener valores invalidos!..")
            txtTipo.Focus()
            Return False
        ElseIf txtClasificacion.ValordelControl <> "" And txtClasificacion.DescripciondelControl = "No Se Encontraron Registros" Or txtClasificacion.ValordelControl <> "" And txtClasificacion.DescripciondelControl = "" Or txtClasificacion.ValordelControl = "" Then
            HDevExpre.MensagedeError("El campo clasificacion no puede estar vacío o contener valores invalidos!..")
            txtClasificacion.Focus()
            Return False
        ElseIf txtBaseCalculo.ValordelControl = "" Then
            HDevExpre.MensagedeError("El campo base de calculo no puede estar vacío!..")
            txtBaseCalculo.Focus()
            Return False
        ElseIf ckeEsFondo.Checked And txtTipoFondo.ValordelControl = "" Or ckeEsFondo.Checked And txtTipoFondo.ValordelControl <> "" And txtTipoFondo.DescripciondelControl = "No Se Encontraron Registros" Or txtTipoFondo.ValordelControl <> "" And txtTipoFondo.DescripciondelControl = "" Then
            HDevExpre.MensagedeError("El campo tipo fondo no puede estar vacío o contener valores invalidos!..")
            Return False
        ElseIf txtTipo.ValordelControl <> "2" And ckeEsRetencion.Checked Then
            HDevExpre.MensagedeError("Solo los conceptos de tipo deduccion pueden ser marcados como retencion!..")
            txtTipo.Focus()
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If Not ValidaCampos() Then
                Exit Sub
            End If

            ' Determinar redondeo
            Dim redondeo As Integer? = Nothing
            If ckeRedonAlPeso.Checked Then redondeo = 1
            If ckeRedonAlaDecena.Checked Then redondeo = 10
            If ckeRedonAlaCentena.Checked Then redondeo = 100
            If ckeRedonAlMil.Checked Then redondeo = 1000

            ' Crear el concepto
            Dim concepto As New ConceptosNomina With {
            .Sec = If(Actualizando, Sec_Concepto, 0),
            .NomConcepto = txtNombre.ValordelControl,
            .Vigente = grbVigente.SelectedIndex.ToString(),
            .Formula = Nothing, ' Se configura después
            .Tipo = If(String.IsNullOrEmpty(txtTipo.ValordelControl), Nothing, CInt(txtTipo.ValordelControl)),
            .PeriodosLiquida = Nothing, ' Se configura después
            .Base = txtBaseCalculo.DescripciondelControl,
            .Redondea = redondeo,
            .Fondo = If(String.IsNullOrEmpty(txtTipoFondo.ValordelControl), Nothing, CInt(txtTipoFondo.ValordelControl)),
            .Clasificacion = If(String.IsNullOrEmpty(txtClasificacion.ValordelControl), Nothing, CInt(txtClasificacion.ValordelControl)),
            .EsRetencion = ckeEsRetencion.Checked,
            .EsPredeterminado = False,
            .CodDian = txtCodDian.ValordelControl,
            .Orden = Nothing
        }

            ' Crear el request
            Dim request As New UpsertConceptoNominaRequest With {
            .ConceptoNomina = concepto,
            .Usuario = ObjetosNomina.Datos.Smt_Usuario,
            .Terminal = ObjetosNomina.Datos.Smt_NombreTerminal
        }

            ' Ejecutar procedimiento
            Dim resp = SMT_EjecutaProcedimientos(ObjetoApiNomina, "SP_UpsertConceptosNomina", request.ToJObject())
            Dim response = resp.ToObject(Of UpsertConceptoNominaResponse)()

            ' Procesar respuesta
            If response.EsExitoso Then
                Dim mensaje = "Concepto guardado exitosamente!"
                If response.ConceptoNomina IsNot Nothing Then
                    mensaje &= $" Se configuró en {response.ConceptoNomina.TotalNominasConfiguradas} nóminas"
                    mensaje &= $" y {response.ConceptoNomina.TotalTiposContratoConfigurados} tipos de contrato."
                End If

                HDevExpre.mensajeExitoso(mensaje)

                ' Refrescar UI
                LlenaGrillaConceptos()
                Creagrillahorizontal()
                LimpiarCampos()
            Else
                HDevExpre.MensagedeError($"Error al guardar el concepto: {response.Mensaje}")
            End If

        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "btnGuardar_Click/ConceptosNomina")
        End Try
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
            btnAddClasifiacion.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Agregar)
            btnArriba.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.FlechaArriba)
            btnAbajo.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.FlechaAbajo)
            grbVigente.SelectedIndex = 1
            txtTipoFondo.Enabled = False
            ckeRedonAlPeso.Checked = True
            ckeRedonAlaDecena.Checked = False
            ckeRedonAlMil.Checked = False
            ckeEsFondo.Checked = False
            ckeRedonAlaCentena.Checked = False
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "AcomodaForm Agrega Conceptos!")
        End Try
    End Sub

    Private Async Sub AsignaScriptAcontroles()
        Try
            txtTipoFondo.ConsultaSQL = String.Format("SELECT CodTipoEnte AS Codigo, NomTipoEnte AS Descripcion FROM  ZenumTipoEntes")
            txtBaseCalculo.ConsultaSQL = String.Format("Select ROW_NUMBER() OVER(ORDER BY Nombre ASC) AS Codigo, Consul.Nombre From( " +
                                                      " Select NomBase As Nombre From  BasesConceptos Union " +
                                                      " Select NomConcepto As Nombre From  ConceptosNomina Union " +
                                                      " Select NomVariable As Nombre From  VariablesGenerales Union " +
                                                      " Select NomVariable As Nombre From  VariablesPersonales Union " +
                                                      " Select 'Asignacion' As Nombre Union " +
                                                      " Select 'HorasMes' As Nombre Union " +
                                                      " Select 'TotalPagadoMes' As Nombre Union " +
                                                      " Select 'RentaExenta' As Nombre Union " +
                                                      " Select 'SalarioPromedioMensualAnual' As Nombre Union " +
                                                      " Select 'SalarioPromedioMensualSemestral' As Nombre Union " +
                                                      " Select 'NetoAPagar' As Nombre Union " +
                                                      " Select 'TotalIngresos' As Nombre Union " +
                                                      " Select 'TotalDeducciones' As Nombre Union " +
                                                      " Select 'DescuentosPorNomina' As Nombre) as Consul ")

            txtTipo.ConsultaSQL = String.Format("SELECT Sec AS Codigo,NomTipo As Descripcion FROM  TiposConceptosNomina")
            txtClasificacion.ConsultaSQL = String.Format("SELECT Sec AS Codigo,Nom As Descripcion FROM  ClasConceptosNomina")
            Dim sql As String = "Select Sec From Nominas "
            Nominas = SMT_AbrirTabla(ObjetoApiNomina, sql)
            sql = "Select Sec From CAT_TipoContratos"
            TiposContratos = SMT_AbrirTabla(ObjetoApiNomina, sql)

            txtCodDian.ConsultaSQL = String.Format("SELECT Codigo,Descripcion FROM  CodigosDian")
            txtCodDian.RefrescarDatos()
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "AsignaScriptAcontroles")
        End Try
    End Sub

    Private Sub RefrescaDatos()
        Dim sql As String = "Select ROW_NUMBER() OVER(ORDER BY Nombre ASC) AS Codigo, Consul.Nombre From( " +
                                                     " Select NomBase As Nombre From BasesConceptos Union " +
                                                     " Select NomConcepto As Nombre From ConceptosNomina Union " +
                                                     " Select NomVariable As Nombre From VariablesGenerales Union " +
                                                     " Select NomVariable As Nombre From VariablesPersonales Union " +
                                                     " Select 'Asignacion' As Nombre Union " +
                                                     " Select 'HorasMes' As Nombre Union " +
                                                     " Select 'TotalPagadoMes' As Nombre Union " +
                                                     " Select 'RentaExenta' As Nombre Union " +
                                                      " Select 'SalarioPromedioMensualAnual' As Nombre Union " +
                                                      " Select 'SalarioPromedioMensualSemestral' As Nombre Union " +
                                                      " Select 'NetoAPagar' As Nombre Union " +
                                                      " Select 'TotalIngresos' As Nombre Union " +
                                                      " Select 'TotalDeducciones' As Nombre Union " +
                                                     " Select 'DescuentosPorNomina' As Nombre) as Consul "

        Bases = SMT_AbrirTabla(ObjetoApiNomina, sql)
        txtTipoFondo.RefrescarDatos()
        txtBaseCalculo.RefrescarDatos()
        txtTipo.RefrescarDatos()
        txtClasificacion.RefrescarDatos()
    End Sub
    Private Sub CreaGrilla()
        Try
            gvConceptos.Columns.Clear()

            HDevExpre.CreaColumnasG(gvConceptos, "Sec", "Sec", False, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 0, 0)
            HDevExpre.CreaColumnasG(gvConceptos, "CodDian", "Codigo Dian", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 10, gbxPrincipal.Width)
            HDevExpre.CreaColumnasG(gvConceptos, "NomConcepto", "Nombre", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 25, gbxPrincipal.Width)
            HDevExpre.CreaColumnasG(gvConceptos, "Tipo", "Tipo", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 14, gbxPrincipal.Width)
            HDevExpre.CreaColumnasG(gvConceptos, "Clasificacion", "Clasificacion", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 15, gbxPrincipal.Width)
            HDevExpre.CreaColumnasG(gvConceptos, "Base", "Base Calculo", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 15, gbxPrincipal.Width)
            HDevExpre.CreaColumnasG(gvConceptos, "Redondea", "Redondea", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 8, gbxPrincipal.Width)
            HDevExpre.CreaColumnasG(gvConceptos, "Fondo", "Fondo", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 15, gbxPrincipal.Width)
            HDevExpre.CreaColumnasG(gvConceptos, "EsRetencion", "Es Retencion", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 8, gbxPrincipal.Width)
            HDevExpre.CreaColumnasG(gvConceptos, "EsPredeterminado", "Es Predeterminado", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 8, gbxPrincipal.Width)
            HDevExpre.CreaColumnasG(gvConceptos, "Vigente", "Vigente", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 5, gbxPrincipal.Width)
            gvConceptos.OptionsView.ShowFooter = True
            gvConceptos.Appearance.HeaderPanel.Font = New Font("Trebuchet MS", 11.0!, FontStyle.Bold)
            gvConceptos.Columns(10).Summary.Add(DevExpress.Data.SummaryItemType.Count, "", "{0}  Registros")
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "Crea Grilla")
        End Try
    End Sub
    Private Sub LlenaGrillaConceptos()
        Try
            Dim sql As String = "SELECT CN.Orden,CN.CodDian,CN.Sec,CN.NomConcepto,CN.Base,CN.Redondea,CN.Fondo as SecFondo,F.NomTipoEnte as Fondo,CL.Nom As Clasificacion,CL.Sec As SecClasificacion,case CN.Vigente " +
                                " WHEN '1' then 'Si' when '0' then 'No' end As Vigente,Case CN.EsRetencion WHEN '1' Then 'Si' WHEN '0' Then 'No' end as EsRetencion,Case CN.EsPredeterminado WHEN '1' Then 'Si' WHEN '0' Then 'No' end as EsPredeterminado,TCN.NomTipo As Tipo,TCN.Sec as SecTipo FROM ConceptosNomina CN INNER JOIN TiposConceptosNomina TCN on CN.Tipo = TCN.Sec LEFT JOIN ZenumTipoEntes F ON CN.Fondo = F.CodTipoEnte INNER JOIN ClasConceptosNomina CL ON CN.Clasificacion = CL.Sec order by orden asc"
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

    Public Sub LimpiarCampos()
        Sec_Concepto = ""
        NomConcepto = ""
        EsPredeterminado = False
        Actualizando = False
        txtNombre.ValordelControl = ""
        txtCodDian.ValordelControl = ""
        grbVigente.SelectedIndex = 1
        txtTipo.ValordelControl = ""
        txtClasificacion.ValordelControl = ""
        txtTipoFondo.ValordelControl = ""
        txtTipoFondo.Enabled = False
        ckeRedonAlPeso.Checked = True
        ckeRedonAlaDecena.Checked = False
        ckeRedonAlMil.Checked = False
        ckeEsFondo.Checked = False
        txtBaseCalculo.ValordelControl = ""
        lblMsg.Visible = False
        grbVigente.ReadOnly = False
        lblMsg.Visible = False
        ckeEsFondo.Checked = False
        ckeEsFondo.Enabled = True
        ckeEsRetencion.Checked = False
        ckeEsRetencion.Enabled = True
        ckeRedonAlaCentena.Checked = False
        Buscando = False
        txtNoBuscando()
        gcConceptos.DataSource = dt
        txtNombre.Focus()
        RefrescaDatos()
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
                If dt.Rows(0)("tipo").ToString <> "C" Then
                    HDevExpre.MensagedeError("Ya existe un registro con este nombre (Los Conceptos,Variables Generales,Variables Personales y Bases no pueden coincidir en el nombre)!..")
                    Return False

                ElseIf dt.Rows(0)("tipo").ToString = "C" And dt.Rows(0)("Sec").ToString <> Sec Then
                    HDevExpre.MensagedeError("Ya existe un registro con este nombre (Los Conceptos,Variables Generales,Variables Personales y Bases no pueden coincidir en el nombre)!..")
                    Return False
                End If
            End If
            Return True
        End If

    End Function

    Private Function GuardaDatos(Sec As Integer, SecConceptos As String, NomConcepto As String, Vigente As String, Tipo As String, Base As String, Redondea As String, Fondo As String, Clasificacion As String, EsRetencion As String, EstaActualizando As Boolean, CodDian As String) As Boolean
        Try
            ConceptosNominas = New ConceptosNomina
            ConceptosNominas.NomConcepto = txtNombre.ValordelControl
            ConceptosNominas.Sec = Sec
            ConceptosNominas.Vigente = grbVigente.SelectedIndex.ToString()
            ConceptosNominas.Base = txtBaseCalculo.DescripciondelControl
            ConceptosNominas.Clasificacion = txtClasificacion.ValordelControl
            ConceptosNominas.CodDian = txtCodDian.ValordelControl

            Dim RegConceptoNomina As New ServiceConceptosNominas
            Dim registro As JArray
            If RegConceptoNomina.ValidarCampos(ConceptosNominas) Then
                registro = RegConceptoNomina.UpsertConceptosNominas(ConceptosNominas)
            End If
            If registro.Count > 0 Then
                Return True
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "Guardando Conceptos")
            Return False
        End Try
    End Function

    Private Function GuardaConceptosNomina(SecConceptos As String, SecNomina As String, ConfiguraProvisiones As Boolean) As Boolean
        Dim GenSql As New SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL
        Dim SecConfig As String = ""
        If Not ConfiguraProvisiones Then
            GenSql.PasoConexionTabla(ObjetoApiNomina, "ConfigConceptos")
            SecConfig = SMT_AbrirTabla(ObjetoApiNomina, "SELECT ISNULL( MAX (Sec),0)+1 AS Codigo FROM  ConfigConceptos").Rows(0)(0).ToString
        Else
            GenSql.PasoConexionTabla(ObjetoApiNomina, "ConfigProvisiones")
            SecConfig = SMT_AbrirTabla(ObjetoApiNomina, "SELECT ISNULL( MAX (Sec),0)+1 AS Codigo FROM  ConfigProvisiones").Rows(0)(0).ToString
        End If
        GenSql.PasoValores("Nomina", SecNomina, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
        GenSql.PasoValores("Concepto", SecConceptos, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
        GenSql.PasoValores("Sec", SecConfig, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
        If GenSql.EjecutarComandoNET(SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.SQLGenera.Insercion, "") Then
            Return True
        Else : Return False
        End If
    End Function

    Private Function GuardaConceptos_TiposContratos(SecConceptos As String, SecTipo As String) As Boolean
        Dim GenSql As New SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL
        Dim SecConfig As String = ""
        GenSql.PasoConexionTabla(ObjetoApiNomina, "TiposContratos_ConceptosNomina")
        SecConfig = SMT_AbrirTabla(ObjetoApiNomina, "SELECT ISNULL( MAX (Sec),0)+1 AS Codigo FROM  TiposContratos_ConceptosNomina").Rows(0)(0).ToString
        GenSql.PasoValores("TipoContrato", SecTipo, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
        GenSql.PasoValores("Concepto", SecConceptos, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
        GenSql.PasoValores("SeLiquida", "0", SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
        GenSql.PasoValores("Sec", SecConfig, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
        If GenSql.EjecutarComandoNET(SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.SQLGenera.Insercion, "") Then
            Return True
        Else : Return False
        End If
    End Function

    Private Sub CargarDatos()
        Try
            grbVigente.ReadOnly = False
            lblMsg.Visible = False
            Sec_Concepto = gvConceptos.GetFocusedRowCellValue("Sec").ToString
            NomConcepto = gvConceptos.GetFocusedRowCellValue("NomConcepto").ToString
            EsPredeterminado = If(gvConceptos.GetFocusedRowCellValue("EsPredeterminado").ToString = "Si", True, False)
            txtCodDian.ValordelControl = gvConceptos.GetFocusedRowCellValue("CodDian").ToString
            txtNombre.ValordelControl = gvConceptos.GetFocusedRowCellValue("NomConcepto").ToString
            txtTipo.ValordelControl = gvConceptos.GetFocusedRowCellValue("SecTipo").ToString
            txtClasificacion.ValordelControl = gvConceptos.GetFocusedRowCellValue("SecClasificacion").ToString
            For incre As Integer = 0 To Bases.Rows.Count - 1
                If Bases.Rows(incre)("Nombre").ToString = gvConceptos.GetFocusedRowCellValue("Base").ToString Then
                    txtBaseCalculo.ValordelControl = Bases.Rows(incre)("Codigo").ToString
                End If
            Next
            If gvConceptos.GetFocusedRowCellValue("EsRetencion").ToString = "Si" Then
                ckeEsRetencion.Checked = True
            Else
                ckeEsRetencion.Checked = False
            End If
            If gvConceptos.GetFocusedRowCellValue("Vigente").ToString = "Si" Then
                grbVigente.SelectedIndex = 1
            Else
                grbVigente.SelectedIndex = 0
            End If
            If gvConceptos.GetFocusedRowCellValue("Fondo").ToString = "" Then
                ckeEsFondo.Checked = False
                txtTipoFondo.ValordelControl = ""
            Else
                ckeEsFondo.Checked = True
                txtTipoFondo.ValordelControl = gvConceptos.GetFocusedRowCellValue("SecFondo").ToString
            End If

            If gvConceptos.GetFocusedRowCellValue("Redondea").ToString = "1" Then
                ckeRedonAlPeso.Checked = True
                ckeRedonAlaDecena.Checked = False
                ckeRedonAlMil.Checked = False
                ckeRedonAlaCentena.Checked = False
            ElseIf gvConceptos.GetFocusedRowCellValue("Redondea").ToString = "10" Then
                ckeRedonAlPeso.Checked = False
                ckeRedonAlaDecena.Checked = True
                ckeRedonAlMil.Checked = False
                ckeRedonAlaCentena.Checked = False
            ElseIf gvConceptos.GetFocusedRowCellValue("Redondea").ToString = "100" Then
                ckeRedonAlPeso.Checked = False
                ckeRedonAlaDecena.Checked = False
                ckeRedonAlMil.Checked = False
                ckeRedonAlaCentena.Checked = True
            ElseIf gvConceptos.GetFocusedRowCellValue("Redondea").ToString = "1000" Then
                ckeRedonAlPeso.Checked = False
                ckeRedonAlaDecena.Checked = False
                ckeRedonAlaCentena.Checked = False
                ckeRedonAlMil.Checked = True
            End If

            EsRetencionoFondo()
            Dim sql As String = "SELECT * FROM NominaLiquidaConceptos WHERE SecConcepto = " + Sec_Concepto
            Dim dt As DataTable = SMT_AbrirTabla(ObjetoApiNomina, sql)
            If dt.Rows.Count > 0 Then
                lblMsg.Visible = True
                grbVigente.ReadOnly = True
            End If
            Actualizando = True
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "Cargar datos de los Conceptos")
        End Try
    End Sub
    Private Sub EliminaConceptos(Sec As String)
        Try
            ' Verificar primero si es predeterminado localmente
            If EsPredeterminado Then
                HDevExpre.MensagedeError("Lo sentimos, los conceptos predeterminados no pueden ser eliminados.")
                Exit Sub
            End If

            ' Confirmar con el usuario
            If HDevExpre.MsgSamit(String.Format("Seguro que desea eliminar item seleccionado [{0}]", txtNombre.ValordelControl),
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.OK Then

                ' Crear el request
                Dim request As New EliminarConceptoNominaRequest(CInt(Sec), True) ' False porque ya validamos las fórmulas

                ' Ejecutar procedimiento almacenado
                Dim resp = SMT_EjecutaProcedimientos(ObjetoApiNomina, "SP_EliminarConceptoNomina", request.ToJObject())
                Dim response = resp.ToObject(Of DynamicDeleteResponse)()

                ' Procesar respuesta
                If response IsNot Nothing Then
                    If response.EsExitoso Then
                        LimpiarCampos()
                        LlenaGrillaConceptos()
                        ' Mensaje opcional
                        HDevExpre.mensajeExitoso($"Concepto eliminado. {response.RegistrosEliminados} registros afectados.")
                    Else
                        HDevExpre.MensagedeError(response.Mensaje)
                    End If
                Else
                    HDevExpre.MensagedeError("Error al procesar la respuesta del servidor")
                End If
            End If

        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "EliminaConceptos")
        End Try
    End Sub
#End Region


    Private Sub FrmAggConceptosNomina_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        LimpiarCampos()
        Buscando = False
        txtNoBuscando()
    End Sub

    Private Sub AsignaMsgAcontroles()
        Try
            txtNombre.MensajedeAyuda = "Digite el nombre del Concepto. (ENTER,ABJ)=Avanzar"
            txtBaseCalculo.MensajedeAyuda = "Digite la Base de calculo del Concepto que se esta registrando o modificando . (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
            txtTipo.MensajedeAyuda = "Seleccione el tipo del concepto.  (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
            txtClasificacion.MensajedeAyuda = "Seleccione el tipo del clasificación.  (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
            txtTipoFondo.MensajedeAyuda = "Seleccione a que tipo de fondo pertenece este concepto? .  (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "AsignaMsgAcontroles")
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

    Private Sub grbVigente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles grbVigente.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            btnGuardar.Focus()
        End If
        If e.KeyChar = ChrW(Keys.Escape) Then
            'ckePeriodo1.Focus()
        End If
    End Sub

    Private Sub ckePeriodo1_Enter(sender As Object, e As EventArgs)
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

    Private Sub ckeRedonAlPeso_Enter(sender As Object, e As EventArgs) Handles ckeRedonAlPeso.Enter, ckeRedonAlaDecena.Enter, ckeRedonAlMil.Enter, ckeRedonAlaCentena.Enter
        Try
            Dim ck As DevExpress.XtraEditors.CheckEdit = CType(sender, DevExpress.XtraEditors.CheckEdit)
            ck.Font = New Font(ck.Font.FontFamily, ck.Font.Size, FontStyle.Bold)
            ck.BorderStyle = BorderStyles.HotFlat
            ck.BackColor = Datos.ColordeFondoTxtFoco
            FrmPrincipal.MensajeDeAyuda.Caption = "A que desea redondear el valor de este concepto?. (ENTER)=Avanzar;(ESC,ARB)=Atras"
            FrmPrincipal.MensajeDeAyuda.Refresh()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ckeRedonAlPeso_Leave(sender As Object, e As EventArgs) Handles ckeRedonAlPeso.Leave, ckeRedonAlaDecena.Leave, ckeRedonAlMil.Leave, ckeEsFondo.Leave, ckeEsRetencion.Leave, ckeRedonAlaCentena.Leave
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

    Private Sub ckeRedonAlPeso_CheckedChanged(sender As Object, e As EventArgs) Handles ckeRedonAlPeso.CheckedChanged
        If ckeRedonAlPeso.Checked Then
            ckeRedonAlaDecena.Checked = False
            ckeRedonAlMil.Checked = False
            ckeRedonAlaCentena.Checked = False
        ElseIf ckeRedonAlaCentena.Checked = False And ckeRedonAlPeso.Checked = False And ckeRedonAlaDecena.Checked = False And ckeRedonAlMil.Checked = False Then
            ckeRedonAlPeso.Checked = True
        End If
    End Sub

    Private Sub ckeRedonAlaDecena_CheckedChanged(sender As Object, e As EventArgs) Handles ckeRedonAlaDecena.CheckedChanged
        If ckeRedonAlaDecena.Checked Then
            ckeRedonAlPeso.Checked = False
            ckeRedonAlMil.Checked = False
            ckeRedonAlaCentena.Checked = False
        ElseIf ckeRedonAlaCentena.Checked = False And ckeRedonAlPeso.Checked = False And ckeRedonAlaDecena.Checked = False And ckeRedonAlMil.Checked = False Then
            ckeRedonAlaDecena.Checked = True
        End If

    End Sub

    Private Sub ckeRedonAlMil_CheckedChanged(sender As Object, e As EventArgs) Handles ckeRedonAlMil.CheckedChanged
        If ckeRedonAlMil.Checked Then
            ckeRedonAlaDecena.Checked = False
            ckeRedonAlPeso.Checked = False
            ckeRedonAlaCentena.Checked = False
        ElseIf ckeRedonAlaCentena.Checked = False And ckeRedonAlPeso.Checked = False And ckeRedonAlaDecena.Checked = False And ckeRedonAlMil.Checked = False Then
            ckeRedonAlMil.Checked = True
        End If
    End Sub

    Private Sub ckeRedonAlaCentena_CheckedChanged(sender As Object, e As EventArgs) Handles ckeRedonAlaCentena.CheckedChanged
        If ckeRedonAlaCentena.Checked Then
            ckeRedonAlaDecena.Checked = False
            ckeRedonAlPeso.Checked = False
            ckeRedonAlMil.Checked = False
        ElseIf ckeRedonAlPeso.Checked = False And ckeRedonAlaDecena.Checked = False And ckeRedonAlMil.Checked = False And ckeRedonAlaCentena.Checked = False Then
            ckeRedonAlaCentena.Checked = True
        End If
    End Sub


    Private Sub ckeEsFondo_CheckedChanged(sender As Object, e As EventArgs) Handles ckeEsFondo.CheckedChanged
        If ckeEsFondo.Checked Then
            txtTipoFondo.Enabled = True
        Else
            txtTipoFondo.ValordelControl = ""
            txtTipoFondo.Enabled = False
        End If
        EsRetencionoFondo()
    End Sub

    Private Sub ckeRedonAlPeso_Click(sender As Object, e As EventArgs) Handles ckeRedonAlPeso.Click, ckeRedonAlMil.Click, ckeRedonAlaDecena.Click
        FrmPrincipal.MensajeDeAyuda.Caption = "A que desea redondear el valor de este concepto?. (ENTER)=Avanzar;(ESC,ARB)=Atras"
        FrmPrincipal.MensajeDeAyuda.Refresh()
    End Sub

    Private Sub ckeEsFondo_Click(sender As Object, e As EventArgs) Handles ckeEsFondo.Click
        FrmPrincipal.MensajeDeAyuda.Caption = "El concepto que esta registrando o modificando, pertenece a un fondo?. (ENTER)=Avanzar;(ESC,ARB)=Atras"
        FrmPrincipal.MensajeDeAyuda.Refresh()
    End Sub

    Private Sub txtTipo_Leave(sender As Object, e As EventArgs) Handles txtClasificacion.Leave
        If ckeEsFondo.Focus Then
            Dim send As New Object
            Dim evento As New EventArgs
            ckeEsFondo_Click(send, evento)
        End If
    End Sub

    Private Sub ckeEsFondo_Enter(sender As Object, e As EventArgs) Handles ckeEsFondo.Enter
        Dim ck As DevExpress.XtraEditors.CheckEdit = CType(sender, DevExpress.XtraEditors.CheckEdit)
        ck.Font = New Font(ck.Font.FontFamily, ck.Font.Size, FontStyle.Bold)
        ck.BorderStyle = BorderStyles.HotFlat
        ck.BackColor = Datos.ColordeFondoTxtFoco
        FrmPrincipal.MensajeDeAyuda.Caption = "El concepto que esta registrando o modificando, pertenece a un fondo?. (ENTER)=Avanzar;(ESC,ARB)=Atras"
        FrmPrincipal.MensajeDeAyuda.Refresh()
    End Sub

    Private Sub ckeEsRetencion_Enter(sender As Object, e As EventArgs) Handles ckeEsRetencion.Enter
        Dim ck As DevExpress.XtraEditors.CheckEdit = CType(sender, DevExpress.XtraEditors.CheckEdit)
        ck.Font = New Font(ck.Font.FontFamily, ck.Font.Size, FontStyle.Bold)
        ck.BorderStyle = BorderStyles.HotFlat
        ck.BackColor = Datos.ColordeFondoTxtFoco
        FrmPrincipal.MensajeDeAyuda.Caption = "El concepto que esta registrando o modificando, es una retencion?. (ENTER)=Avanzar;(ESC,ARB)=Atras"
        FrmPrincipal.MensajeDeAyuda.Refresh()
    End Sub

    Private Sub grbVigente_Click(sender As Object, e As EventArgs) Handles grbVigente.Click
        FrmPrincipal.MensajeDeAyuda.Caption = "Estado del Concepto. (ENTER)=Avanzar;(ESC,ARB)=Atras"
        FrmPrincipal.MensajeDeAyuda.Refresh()
    End Sub

    Private Sub txtTipoFondo_Leave(sender As Object, e As EventArgs) Handles txtTipoFondo.Leave
        If grbVigente.Focus Then
            Dim send As New Object
            Dim evento As New EventArgs
            grbVigente_Click(send, evento)
        End If
    End Sub

    Private Sub EsRetencionoFondo()
        If ckeEsFondo.Checked Then
            ckeEsRetencion.Checked = False
            ckeEsRetencion.Enabled = False
            ckeEsFondo.Enabled = True

        ElseIf ckeEsRetencion.Checked Then
            ckeEsFondo.Checked = False
            ckeEsFondo.Enabled = False
            ckeEsRetencion.Enabled = True
        Else
            ckeEsFondo.Checked = False
            ckeEsFondo.Enabled = True
            ckeEsRetencion.Checked = False
            ckeEsRetencion.Enabled = True
        End If
    End Sub

    Private Sub ckeRedonAlPeso_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ckeRedonAlPeso.KeyPress, ckeRedonAlMil.KeyPress, ckeRedonAlaDecena.KeyPress, ckeEsFondo.KeyPress, ckeEsRetencion.KeyPress
        HDevExpre.AvanzaConEnter(e)
    End Sub

    Private Sub ckeEsRetencion_CheckedChanged(sender As Object, e As EventArgs) Handles ckeEsRetencion.CheckedChanged
        EsRetencionoFondo()
    End Sub

    Private Sub btnAddClasifiacion_Click(sender As Object, e As EventArgs) Handles btnAddClasifiacion.Click
        Dim classResize As New ClaseResize
        Dim Frm As New FrmAggClasConceptosNomina
        classResize.Resizamodales(Frm, 80, 70)
        Frm.ShowDialog()
        Frm.BringToFront()
    End Sub

    Private Sub btnArriba_Click(sender As Object, e As EventArgs) Handles btnArriba.Click
        If gvConceptos.RowCount > 0 Then
            Dim OrdenAbajo As String = gvConceptos.GetFocusedRowCellValue("Orden").ToString
            If OrdenAbajo <> "1" Then
                Dim index As Integer = gvConceptos.FocusedRowHandle - 1
                Dim OrdenArriba As Integer = CInt(gvConceptos.GetRowCellValue(gvConceptos.FocusedRowHandle - 1, "Orden"))
                Dim SecArriba As Integer = CInt(gvConceptos.GetRowCellValue(gvConceptos.FocusedRowHandle - 1, "Sec"))
                Dim SecAbajo As Integer = CInt(gvConceptos.GetRowCellValue(gvConceptos.FocusedRowHandle, "Sec"))
                SMT_EjcutarComandoSql(ObjetoApiNomina, "Update ConceptosNomina set Orden=" + OrdenArriba.ToString + " where Sec=" + SecAbajo.ToString, 0)
                SMT_EjcutarComandoSql(ObjetoApiNomina, "Update ConceptosNomina set Orden=" + OrdenAbajo.ToString + " where Sec=" + SecArriba.ToString, 0)
                LimpiarCampos()
                LlenaGrillaConceptos()
                gcConceptos.Focus()
                gvConceptos.FocusedRowHandle = index
            End If
        End If
    End Sub

    Private Sub btnAbajo_Click(sender As Object, e As EventArgs) Handles btnAbajo.Click
        If gvConceptos.RowCount > 0 Then
            Dim OrdenAbajo As String = gvConceptos.GetFocusedRowCellValue("Orden").ToString
            If gvConceptos.FocusedRowHandle <> gvConceptos.RowCount - 1 Then
                Dim index As Integer = gvConceptos.FocusedRowHandle + 1
                Dim OrdenArriba As Integer = CInt(gvConceptos.GetRowCellValue(gvConceptos.FocusedRowHandle + 1, "Orden"))
                Dim SecArriba As Integer = CInt(gvConceptos.GetRowCellValue(gvConceptos.FocusedRowHandle + 1, "Sec"))
                Dim SecAbajo As Integer = CInt(gvConceptos.GetRowCellValue(gvConceptos.FocusedRowHandle, "Sec"))
                SMT_EjcutarComandoSql(ObjetoApiNomina, "Update ConceptosNomina set Orden=" + OrdenArriba.ToString + " where Sec=" + SecAbajo.ToString, 0)
                SMT_EjcutarComandoSql(ObjetoApiNomina, "Update ConceptosNomina set Orden=" + OrdenAbajo.ToString + " where Sec=" + SecArriba.ToString, 0)
                LimpiarCampos()
                LlenaGrillaConceptos()
                gcConceptos.Focus()
                gvConceptos.FocusedRowHandle = index

            End If
        End If
    End Sub
End Class