Option Strict Off
Imports SamitCtlNet
Imports System.ComponentModel
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Columns
Imports System.Transactions
Imports DevExpress.XtraGrid.Views.Grid
Imports SamitCtlNet.SamitCtlNet
Imports SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL
Imports SamitNominaLogic

Public Class FrmAggPlantillas
    Dim HDevExpre As New HelperDevExpress
    Dim HNomina As New HelperNomina
    Dim FormularioAbierto As Boolean = False
    Dim dtos As DataTable
    Dim Buscando As Boolean = False
    Dim ActualizandoDatosBasicos As Boolean = False
    'Dim txtPlantillaBase As New SamitBusq

    'Propiedades
    Dim VSecPlantillas As String
    Public Property Sec_Plantillas() As String
        Get
            Return VSecPlantillas
        End Get
        Set(value As String)
            VSecPlantillas = value
        End Set
    End Property


    Public Property P_FormularioAbierto() As Boolean
        Get
            Return FormularioAbierto
        End Get
        Set(value As Boolean)
            FormularioAbierto = value
        End Set
    End Property


    Private Sub AcomodaForm()
        Try
            btnGuardar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Guardar)
            btnLimpiar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Limpiar)
            btnEliminar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.EliminarGris)
            btnSalir.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.SalirCuadroConX)
            btnAggConceptos.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.AgregarItem)
            btnEliminarConcepto.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.EliminarItem)
            btnAggConceptosProv.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.AgregarItem)
            btnEliminarConceptoProv.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.EliminarItem)

            btnAggConceptos.SuperTip = HDevExpre.SMT_AsignaSupertToolTip("Agregar el concepto a la plantilla seleccionada.")
            btnEliminarConcepto.SuperTip = HDevExpre.SMT_AsignaSupertToolTip("Eliminar el concepto de la plantilla seleccionada.")
            btnAggConceptosProv.SuperTip = HDevExpre.SMT_AsignaSupertToolTip("Agregar el concepto provisionado a la plantilla seleccionada.")
            btnEliminarConceptoProv.SuperTip = HDevExpre.SMT_AsignaSupertToolTip("Eliminar el concepto provisionado de la plantilla seleccionada.")


            grbVigente.SelectedIndex = 1
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, " AcomodaForm Plantillas")
        End Try
    End Sub


    Private Sub FrmAggPlantillas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            AcomodaForm()
            Sec_Plantillas = "0"
            CreaGrillaPlantillas()
            CreaGrillaConceptosPlantillas()
            CreaGrillaConceptosPlantillasProv()
            LlenaGrillaPlantillas()
            LlenaGrillaConceptos(Sec_Plantillas)
            LlenaGrillaConceptosProv(Sec_Plantillas)
            txtNoBuscando()
            AsignaScriptAcontroles()
            txtNombre.Select()
            txtNombre.MensajedeAyuda = "Digite el nombre de la plantilla que desea agregar. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
            txtConceptos.MensajedeAyuda = "Seleccion el concepto que desea agregar a la plantilla.(ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras, (F5,DER)=Buscar"
            'txtPlantillaBase.MensajedeAyuda = "Seleccione la plantilla de la cual desea copiar información.(ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras, (F5,DER)=Buscar"
            txtNombre.MaximoAncho = AnchoCampoSql(ObjetoApiNomina, "Plantillas", "NomPlantilla")
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, " Load Plantillas")
        End Try
    End Sub


    Private Sub AsignaScriptAcontroles()
        Try
            txtPlantillaBase.ConsultaSQL = String.Format("SELECT Sec AS Codigo,NomPlantilla AS Descripcion FROM  Plantillas")
            txtPlantillaBase.RefrescarDatos()
            txtConceptos.ConsultaSQL = String.Format("SELECT Sec AS Codigo,NomConcepto As Descripcion FROM  ConceptosNomina")
            txtConceptos.RefrescarDatos()
            txtConceptosPlantProv.ConsultaSQL = String.Format("SELECT Sec AS Codigo,NomConcepto As Descripcion FROM  ConceptosNomina")
            txtConceptosPlantProv.RefrescarDatos()
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "AsignaScriptAcontroles")
        End Try
    End Sub


#Region "EfectosControles"
    'CONTROLES DATOS BASICOS


    'FIN CONTROLES BASICOS

    'CONTROLES FUNCIONES DEL CARGO
    'FIN CONTROLES FUNCIONES DEL CARGO

    'INICIA CONTROLES ASIGNACIONES DEL CARGO

    'FIN CONTROLES ASIGNACIONES DEL CARGO
#End Region


#Region "Botones Principales"
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            ' 1) Validar campos básicos
            If Not ValidaCamposDatosBasicos() Then
                Exit Sub
            End If

            ' 2) Crear el objeto plantilla principal
            Dim plantilla As New Plantillas With {
            .Sec = If(ActualizandoDatosBasicos, CInt(Sec_Plantillas), 0),
            .NomPlantilla = txtNombre.ValordelControl,
            .Vigente = grbVigente.SelectedIndex.ToString(),
            .ValorMaxDescontar = Nothing ' Ajustar según tu lógica
        }

            ' 3) Crear el request principal
            Dim request As New UpsertPlantillaRequest With {
            .Plantilla = plantilla,
            .Usuario = ObjetosNomina.Datos.Smt_Usuario,
            .Terminal = ObjetosNomina.Datos.Smt_NombreTerminal
        }

            ' 4) Agregar conceptos de nómina
            Dim dtConcep As DataTable = DirectCast(gcConceptos.DataSource, DataTable)
            If dtConcep IsNot Nothing AndAlso dtConcep.Rows.Count > 0 Then
                For i As Integer = 0 To dtConcep.Rows.Count - 1
                    Dim concepto As New ConceptoPlantillaDto With {
                    .Concepto = CInt(dtConcep.Rows(i)("SecConcepto")),
                    .NomConcepto = dtConcep.Rows(i)("Concepto").ToString()
                }
                    request.Conceptos.Add(concepto)
                Next
            End If

            ' 5) Agregar conceptos de provisión
            Dim dtConcepProv As DataTable = DirectCast(gcConceptosPlantProvision.DataSource, DataTable)
            If dtConcepProv IsNot Nothing AndAlso dtConcepProv.Rows.Count > 0 Then
                For i As Integer = 0 To dtConcepProv.Rows.Count - 1
                    Dim conceptoProv As New ConceptoProvisionPlantillaDto With {
                    .Concepto = CInt(dtConcepProv.Rows(i)("SecConcepto")),
                    .NomConcepto = dtConcepProv.Rows(i)("Concepto").ToString()
                }
                    request.ConceptosProvisiones.Add(conceptoProv)
                Next
            End If

            ' 6) Ejecutar procedimiento almacenado
            ActualizandoDatosBasicos = True

            Dim resp = SMT_EjecutaProcedimientos(ObjetoApiNomina, "SP_UpsertPlantilla", request.ToJObject())
            Dim response = resp.ToObject(Of UpsertPlantillaResponse)()

            ' 7) Procesar respuesta
            If response.EsExitoso Then
                ActualizandoDatosBasicos = False

                ' Mostrar mensaje de éxito
                Dim mensaje = "Datos guardados exitosamente!.."
                If response.Plantilla?.ContratosAfectados > 0 Then
                    mensaje &= $" Esta plantilla está asociada a {response.Plantilla.ContratosAfectados} contratos."
                End If

                HDevExpre.mensajeExitoso(mensaje)

                ' Refrescar UI
                LimpiarTodosCampos()
                LlenaGrillaPlantillas()
                LlenaGrillaConceptos(Sec_Plantillas)
                LlenaGrillaConceptosProv(Sec_Plantillas)

            Else
                ActualizandoDatosBasicos = False

                ' Mostrar error
                HDevExpre.MensagedeError($"Error al guardar la plantilla: {response.Mensaje}")

                ' Log adicional si hay código de error
                If response.CodigoError.HasValue Then
                    Console.WriteLine($"Código de error SQL: {response.CodigoError.Value}")
                End If
            End If

        Catch ex As Exception
            ActualizandoDatosBasicos = False
            HDevExpre.msgError(ex, ex.Message, "btnGuardar_Click/Plantillas")
        End Try
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarTodosCampos()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If ActualizandoDatosBasicos Then
                If HDevExpre.MsgSamit("Seguro que desea eliminar esta plantilla con todos sus conceptos?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Cancel Then
                    Exit Sub
                End If

                ' Crear request para el procedimiento almacenado
                Dim request As New EliminarPlantillaRequest(CInt(Sec_Plantillas))

                ' Ejecutar el procedimiento almacenado usando SMT_EjecutaProcedimientos
                Dim resp = SMT_EjecutaProcedimientos(ObjetoApiNomina, "SP_EliminarPlantilla", request.ToJObject())

                ' Usar DynamicDeleteResponse existente
                Dim response = resp.ToObject(Of DynamicDeleteResponse)()

                ' Procesar respuesta
                If response.EsExitoso Then
                    LimpiarTodosCampos()
                    HDevExpre.mensajeExitoso("Datos eliminados exitosamente!..")

                    ' Refrescar grillas
                    LlenaGrillaPlantillas()

                ElseIf response.EsAdvertencia Then
                    HDevExpre.MensagedeError(response.Mensaje)

                Else ' Es Error
                    HDevExpre.MensagedeError(response.Mensaje)
                End If
            Else
                MensajedeError("Seleccione la plantilla a eliminar")
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "btnEliminar_Click")
        End Try
    End Sub
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
#End Region

#Region "Funciones y Procedimientos --> Datos Básicos"

    Public Function ValidaCamposDatosBasicos() As Boolean
        Dim res As Boolean = False
        If txtNombre.ValordelControl = "" Then
            HDevExpre.MensagedeError("El campo Nombre no puede estar vacío!..")
            txtNombre.Focus()
            res = False
        Else
            res = True
        End If
        Return res
    End Function
    Public Sub LimpiarTodosCampos()
        'Limpia todos los campos de texto
        txtNombre.ValordelControl = ""
        txtConceptos.ValordelControl = ""
        txtPlantillaBase.ValordelControl = ""
        'grbUsarPlantillaBase.SelectedIndex = 0
        txtNoBuscando()
        'Limpia variables para validar acutalizaciones
        ActualizandoDatosBasicos = False
        'Limpia propiedades
        Sec_Plantillas = "0"
        'Limpia todas las grillas
        gcConceptos.DataSource = Nothing
        txtPlantillaBase.RefrescarDatos()
        LlenaGrillaPlantillas()
        LlenaGrillaConceptos(Sec_Plantillas)
        LlenaGrillaConceptosProv(Sec_Plantillas)
        txtNombre.Focus()
        grbVigente.SelectedIndex = 1
    End Sub
    Private Sub CargarDatos()
        Try
            Dim sql As String = String.Format("SELECT * FROM Plantillas WHERE Sec='{0}'", gvPlantillas.GetFocusedRowCellValue("Sec").ToString)
            Dim dt As DataTable = SMT_AbrirTabla(ObjetoApiNomina, sql)

            Dim Fila As DataRow = dt.Rows(0)
            txtNombre.ValordelControl = Fila("NomPlantilla").ToString
            Sec_Plantillas = Fila("Sec").ToString
            grbVigente.SelectedIndex = Convert.ToInt32(Fila("Vigente").ToString)
            LlenaGrillaConceptos(Sec_Plantillas)
            LlenaGrillaConceptosProv(Sec_Plantillas)
            ActualizandoDatosBasicos = True
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "  CargarDatos")
        End Try
    End Sub

    Private Sub LlenaGrillaPlantillas()
        Try
            Dim sql As String = "SELECT Sec,NomPlantilla, case Vigente " +
                                " WHEN '1' then 'Si' when '0' then 'No' end As Vigente " +
                                " FROM Plantillas "
            Dim dt As DataTable = SMT_AbrirTabla(ObjetoApiNomina, sql)
            dt = SMT_AbrirTabla(ObjetoApiNomina, sql)
            gcPlantillas.DataSource = dt
            dtos = dt
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "LlenaGrillaPlantillas")
        End Try
    End Sub

    Private Sub gvPlantillas_DoubleClick(sender As Object, e As EventArgs) Handles gvPlantillas.DoubleClick
        CargarDatos()
    End Sub

    Private Sub gvPlantillas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles gvPlantillas.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            CargarDatos()
        End If
    End Sub

    Private Sub CreaColumnas(Grid As GridView, Nombre As String, Titulo As String, Visible As Boolean, Porcentaje_Width As Single, TamañoPadre As Single, Editar As Boolean, numerico As Boolean)
        Dim gc As New GridColumn
        With gc
            .FieldName = Nombre
            .Name = Nombre
            .Caption = Titulo
            If numerico = True Then
                .UnboundType = DevExpress.Data.UnboundColumnType.Decimal
                .DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                .DisplayFormat.FormatString = "c2"
            End If
            .OptionsColumn.AllowSize = True
            .OptionsColumn.AllowMove = True
            .OptionsColumn.AllowEdit = Editar
            .OptionsColumn.AllowFocus = True
            .OptionsFilter.AllowFilter = False
            .Visible = Visible
            .Width = (Porcentaje_Width * (TamañoPadre - 20)) / 100
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
    Private Sub CreaGrillaPlantillas()
        gvPlantillas.Columns.Clear()
        HDevExpre.CreaColumnasG(gvPlantillas, "Sec", "Sec", False, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 0, 0)
        HDevExpre.CreaColumnasG(gvPlantillas, "NomPlantilla", "Nombre", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 70, gbxPlantillas.Width)
        HDevExpre.CreaColumnasG(gvPlantillas, "Vigente", "Vigente", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 30, gbxPlantillas.Width)
        gvPlantillas.Appearance.HeaderPanel.Font = New Font("Trebuchet MS", 11.0!, FontStyle.Bold)
        Dim classResize As New ClaseResize

    End Sub

    Private Function GuardaDatosBasicos() As Boolean
        If ValidaCamposDatosBasicos() Then
            Try
                Dim GenSql_tabPlantillas As New ClGeneraSqlDLL
                GenSql_tabPlantillas.PasoConexionTabla(ObjetoApiNomina, "Plantillas")
                GenSql_tabPlantillas.PasoValores("NomPlantilla", txtNombre.ValordelControl, TipoDatoActualizaSQL.Cadena)
                GenSql_tabPlantillas.PasoValores("Vigente", grbVigente.SelectedIndex.ToString, TipoDatoActualizaSQL.Cadena)

                If Not ActualizandoDatosBasicos Then
                    GenSql_tabPlantillas.PasoValores("Sec", SMT_AbrirTabla(ObjetoApiNomina, "SELECT ISNULL( MAX (Sec),0)+1 AS Codigo FROM Plantillas").Rows(0)(0).ToString, TipoDatoActualizaSQL.Cadena)
                    If GenSql_tabPlantillas.EjecutarComandoNET(SQLGenera.Insercion, "") Then
                        Sec_Plantillas = SMT_AbrirTabla(ObjetoApiNomina, "SELECT ISNULL( MAX (Sec),0) AS Codigo FROM Plantillas").Rows(0)(0).ToString
                        Return True
                    Else : Return False
                    End If
                Else
                    If GenSql_tabPlantillas.EjecutarComandoNET(SQLGenera.Actualizacion, String.Format("Sec='{0}'", Sec_Plantillas)) Then
                        Return True
                    Else : Return False
                    End If
                End If
            Catch ex As Exception
                HDevExpre.msgError(ex, ex.Message, "GuardaDatosBasicos")
                Return False
            End Try
        Else
            Return False
        End If

    End Function

#End Region
#Region "Funciones y Procedimientos --> Plantillas"

    Private Sub CreaGrillaConceptosPlantillas()
        gvConceptos.Columns.Clear()
        HDevExpre.CreaColumnasG(gvConceptos, "SecConcepto", "SecConcepto", False, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 0, 0)
        HDevExpre.CreaColumnasG(gvConceptos, "Concepto", "Concepto", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 100, gbxConceptos.Width)

        gvConceptos.Appearance.HeaderPanel.Font = New Font("Trebuchet MS", 11.0!, FontStyle.Bold)
        Dim classResize As New ClaseResize

    End Sub

    Private Sub CreaGrillaConceptosPlantillasProv()
        gvConceptosProvision.Columns.Clear()
        HDevExpre.CreaColumnasG(gvConceptosProvision, "SecConcepto", "SecConcepto", False, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 0, 0)
        HDevExpre.CreaColumnasG(gvConceptosProvision, "Concepto", "Concepto", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 70, gbxConceptos.Width)

        gvConceptosProvision.Appearance.HeaderPanel.Font = New Font("Trebuchet MS", 11.0!, FontStyle.Bold)
        Dim classResize As New ClaseResize

    End Sub

    Private Sub LlenaGrillaConceptos(Plantilla As String)
        Try
            Dim sql As String = String.Format("SELECT P.NomPlantilla as Plantilla,C.NomConcepto as Concepto,CP.Concepto as SecConcepto,CP.Plantilla as SecPlantilla FROM ConceptosPlantillas CP INNER JOIN Plantillas P ON P.Sec = CP.Plantilla INNER JOIN ConceptosNomina C On C.Sec = CP.Concepto " &
                                             " WHERE Plantilla='{0}'", Plantilla)
            Dim dt As DataTable = SMT_AbrirTabla(ObjetoApiNomina, sql)
            gcConceptos.DataSource = dt
            sql = "SELECT P.NomPlantilla as Plantilla,C.NomConcepto as Concepto,CP.Concepto as SecConcepto," +
                " CP.Plantilla as SecPlantilla FROM ConceptosProvisionesPlantillas CP " +
                " INNER JOIN Plantillas P ON P.Sec = CP.Plantilla INNER JOIN ConceptosNomina C On C.Sec = CP.Concepto " &
                " WHERE Plantilla=" + Plantilla
            dt = SMT_AbrirTabla(ObjetoApiNomina, sql)
            gcConceptosPlantProvision.DataSource = dt
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "LlenaGrillaConceptos")
        End Try
    End Sub

    Private Sub LlenaGrillaConceptosProv(Plantilla As String)
        Try
            'Dim sql As String = String.Format("SELECT P.NomPlantilla as Plantilla,C.NomConcepto as Concepto,CP.Concepto as SecConcepto," +
            '                                  " CP.Plantilla as SecPlantilla FROM ConceptosProvisionesPlantillas CP " +
            '                                  " INNER JOIN Plantillas P ON P.SecPlantilla = CP.Plantilla INNER JOIN ConceptosNomina C On C.Sec = CP.Concepto " & _
            '                                  " WHERE Plantilla='{0}'", Plantilla)
            'Dim dt As DataTable = SMT_AbrirTabla(ObjetoApiNomina, sql)
            'gcConceptosPlantProvision.DataSource = dt
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "LlenaGrillaConceptos")
        End Try
    End Sub

    Private Function ValidaCamposConceptos() As Boolean
        If txtConceptos.ValordelControl = "" Or txtConceptos.DescripciondelControl = "No Se Encontraron Registros" Or txtConceptos.DescripciondelControl = "" Then
            HDevExpre.MensagedeError("El campo Conceptos no puede estar vacío o contener valores invalidos!..")
            txtConceptos.Focus()
            Return False
        Else
            Return True
        End If
    End Function

    Private Function ValidaCamposConceptosProv() As Boolean
        If txtConceptosPlantProv.ValordelControl = "" Or txtConceptosPlantProv.DescripciondelControl = "No Se Encontraron Registros" Or txtConceptosPlantProv.DescripciondelControl = "" Then
            HDevExpre.MensagedeError("El campo Conceptos no puede estar vacío o contener valores invalidos!..")
            txtConceptos.Focus()
            Return False
        Else
            Return True
        End If
    End Function

    Private Function GuardaConceptosPlantillas(SecPlantilla As String, Concepto As String) As Boolean
        Try
            Dim GenSql_tabConceptosPlantillas As New ClGeneraSqlDLL
            GenSql_tabConceptosPlantillas.PasoConexionTabla(ObjetoApiNomina, "ConceptosPlantillas")
            GenSql_tabConceptosPlantillas.PasoValores("Plantilla", SecPlantilla, TipoDatoActualizaSQL.Cadena)
            GenSql_tabConceptosPlantillas.PasoValores("Concepto", Concepto, TipoDatoActualizaSQL.Cadena)

            If GenSql_tabConceptosPlantillas.EjecutarComandoNET(SQLGenera.Insercion, "") Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "GuardaConceptosPlantillas")
            Return False
        End Try
    End Function
    Private Function GuardaConceptosPlantillasProv(SecPlantilla As String, Concepto As String) As Boolean
        Try
            Dim GenSql_tabConceptosPlantillas As New ClGeneraSqlDLL
            GenSql_tabConceptosPlantillas.PasoConexionTabla(ObjetoApiNomina, "ConceptosProvisionesPlantillas")
            GenSql_tabConceptosPlantillas.PasoValores("Plantilla", SecPlantilla, TipoDatoActualizaSQL.Cadena)
            GenSql_tabConceptosPlantillas.PasoValores("Concepto", Concepto, TipoDatoActualizaSQL.Cadena)

            If GenSql_tabConceptosPlantillas.EjecutarComandoNET(SQLGenera.Insercion, "") Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "GuardaConceptosPlantillas")
            Return False
        End Try
    End Function
#End Region




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
    Private Sub txtBuscando()
        txtBusqueda.Font = New Font("Trebuchet MS", 10.25F, FontStyle.Bold)
        txtBusqueda.BackColor = ColorTranslator.FromHtml("#B9FFF9")
        txtBusqueda.ForeColor = Color.DarkRed
    End Sub

    Private Sub txtNoBuscando()
        txtBusqueda.Text = "Digite cualquier parametro de Busqueda"
        txtBusqueda.Font = New Font("Trebuchet MS", 10.25F, FontStyle.Italic)
        txtBusqueda.BackColor = Color.LemonChiffon
        txtBusqueda.ForeColor = Color.Gray
        txtBusqueda.BorderStyle = BorderStyles.Simple
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
        Dim dv As New DataView(dtos)
        dv.RowFilter = Grilla.CrearFiltro(dtos, e.Argument.ToString)
        e.Result = dv
    End Sub
    Private Sub MostrarResultadoFiltro(sender As Object, e As RunWorkerCompletedEventArgs)
        Dim dv As DataView = CType(e.Result, DataView)
        gcPlantillas.DataSource = dv
    End Sub

    Private Sub LimpiarCamposConceptos()
        Try
            txtConceptos.ValordelControl = ""
            txtConceptos.Focus()
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "LimpiarCamposConceptos")
        End Try
    End Sub
    Private Sub LimpiarCamposConceptosProv()
        Try
            txtConceptosPlantProv.ValordelControl = ""
            txtConceptosPlantProv.Focus()
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "LimpiarCamposConceptos")
        End Try
    End Sub

    Private Sub EliminarDetalle_Click(sender As Object, e As EventArgs) Handles btnEliminarConcepto.Click
        Dim Tbla As DataTable = CType(gcConceptos.DataSource, DataTable)
        If Tbla.Rows.Count > 0 Then
            Tbla.Rows.Remove(Tbla.Rows(gvConceptos.FocusedRowHandle))
            gcConceptos.DataSource = Tbla
        End If

    End Sub

    Private Sub TlpPlantillas_SizeChanged(sender As Object, e As EventArgs)
        CreaGrillaConceptosPlantillas()
        CreaGrillaConceptosPlantillasProv()
        CreaGrillaPlantillas()
        If gvPlantillas.RowCount = 0 Then
            LlenaGrillaPlantillas()
        End If
    End Sub

    Private Sub FrmAggPlantillas_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        LimpiarTodosCampos()
        Buscando = False
        txtNoBuscando()
    End Sub

    Private Sub FrmAggPlantillas_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If ActualizandoDatosBasicos Then
            If HDevExpre.MsgSamit("Se están modificando datos, Seguro que desea cerrar el formulario?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Cancel Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub gvConceptos_KeyDown(sender As Object, e As KeyEventArgs) Handles gvConceptos.KeyDown
        If e.KeyCode = 46 Then
            Dim Tbla As DataTable = CType(gcConceptos.DataSource, DataTable)
            If Tbla.Rows.Count > 0 Then
                Tbla.Rows.Remove(Tbla.Rows(gvConceptos.FocusedRowHandle))
                gcConceptos.DataSource = Tbla
            End If
        End If
    End Sub

    Private Sub txtConceptos_Leave(sender As Object, e As EventArgs) Handles txtConceptos.Leave
        btnAggConceptos.Focus()
    End Sub

    Private Sub btnAggConceptos_Click(sender As Object, e As EventArgs) Handles btnAggConceptos.Click
        If ValidaCamposConceptos() Then
            Dim Tbla As DataTable = CType(gcConceptos.DataSource, DataTable)
            If Tbla.Rows.Count > 0 Then

                For incre As Integer = 0 To Tbla.Rows.Count - 1
                    If Tbla.Rows(incre)("SecConcepto") = txtConceptos.ValordelControl Then
                        HDevExpre.MensagedeError("Ya se encuentra agregado este concepto..!")
                        Exit Sub
                    End If
                Next
            End If
            Dim NuevaFila As DataRow = Tbla.NewRow()
            NuevaFila("SecConcepto") = txtConceptos.ValordelControl
            NuevaFila("Concepto") = txtConceptos.DescripciondelControl
            Tbla.Rows.Add(NuevaFila)
            Tbla.AcceptChanges()
            gcConceptos.DataSource = Tbla
            LimpiarCamposConceptos()
        End If
    End Sub

    Private Sub grbVigente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles grbVigente.KeyPress
        HDevExpre.AvanzaConEnter(e)
    End Sub

    Private Sub grbVigente_Enter(sender As Object, e As EventArgs) Handles grbVigente.Enter
        HDevExpre.EntraControlRadioGroup(grbVigente, lblVigente)
    End Sub

    Private Sub grbVigente_Leave(sender As Object, e As EventArgs) Handles grbVigente.Leave
        HDevExpre.SaleControlRadioGroup(grbVigente, lblVigente)
    End Sub

    Private Sub grbUsarPlantillaBase_SelectedIndexChanged(sender As Object, e As EventArgs)
        'If grbUsarPlantillaBase.SelectedIndex = 0 Then
        '    txtPlantillaBase.Enabled = False
        'Else : txtPlantillaBase.Enabled = True
        'End If
    End Sub

    Private Sub grbUsarPlantillaBase_Enter(sender As Object, e As EventArgs)
        'EntraControlRadioGroup(grbUsarPlantillaBase, lblUsaPlantillaBase)
        'FrmPrincipal.MensajeDeAyuda.Caption = "Seleccione si desea utilizar información de una plantilla existente. (ENTER,TAB,ABJ)=Avanzar; (ESC,ARB)=Atras"
    End Sub

    Private Sub grbUsarPlantillaBase_Leave(sender As Object, e As EventArgs)
        'SaleControlRadioGroup(grbUsarPlantillaBase, lblUsaPlantillaBase)
        'FrmPrincipal.MensajeDeAyuda.Caption = ""
    End Sub

    Private Sub txtPlantillaBase_Leave(sender As Object, e As EventArgs) Handles txtPlantillaBase.Leave
        If txtPlantillaBase.ValordelControl = "" Then Exit Sub
        LlenaGrillaConceptos(txtPlantillaBase.ValordelControl)
        LlenaGrillaConceptosProv(txtPlantillaBase.ValordelControl)
    End Sub

    Private Sub btnCargarPlantilla_Click(sender As Object, e As EventArgs) Handles btnCargarPlantilla.Click
        txtPlantillaBase.Visible = True

        txtPlantillaBase.Focus()
        SendKeys.SendWait("{RIGHT}")
        'LlenaGrillaConceptos(txtPlantillaBase.ValordelControl)
        txtPlantillaBase.Visible = False

    End Sub

    Private Sub btnAggConceptosProv_Click(sender As Object, e As EventArgs) Handles btnAggConceptosProv.Click
        Try

            If ValidaCamposConceptosProv() Then
                Dim Tbla As DataTable = CType(gcConceptosPlantProvision.DataSource, DataTable)
                If Tbla.Rows.Count > 0 Then

                    For incre As Integer = 0 To Tbla.Rows.Count - 1
                        If Tbla.Rows(incre)("SecConcepto") = txtConceptosPlantProv.ValordelControl Then
                            HDevExpre.MensagedeError("Ya se encuentra agregado este concepto..!")
                            Exit Sub
                        End If
                    Next
                End If
                Dim NuevaFila As DataRow = Tbla.NewRow()
                NuevaFila("SecConcepto") = txtConceptosPlantProv.ValordelControl
                NuevaFila("Concepto") = txtConceptosPlantProv.DescripciondelControl
                Tbla.Rows.Add(NuevaFila)
                Tbla.AcceptChanges()
                gcConceptosPlantProvision.DataSource = Tbla
                LimpiarCamposConceptosProv()
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnEliminarConceptoProv_Click(sender As Object, e As EventArgs) Handles btnEliminarConceptoProv.Click
        Dim Tbla As DataTable = CType(gcConceptosPlantProvision.DataSource, DataTable)
        If Tbla.Rows.Count > 0 Then
            Tbla.Rows.Remove(Tbla.Rows(Me.gvConceptosProvision.FocusedRowHandle))
            Me.gcConceptosPlantProvision.DataSource = Tbla
        End If
    End Sub


    Private Sub btnSalir_KeyPress(sender As Object, e As KeyPressEventArgs) Handles btnSalir.KeyPress, btnLimpiar.KeyPress, btnGuardar.KeyPress, btnEliminar.KeyPress, btnCargarPlantilla.KeyPress, btnAggConceptosProv.KeyPress, btnAggConceptos.KeyPress
        HDevExpre.AtrasConScape(e)
    End Sub


End Class