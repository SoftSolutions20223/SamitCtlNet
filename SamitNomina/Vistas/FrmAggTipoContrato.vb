Imports SamitCtlNet
Imports DevExpress.Utils
Imports System.ComponentModel
Imports DevExpress.XtraEditors.Controls
Imports SamitNominaLogic
Imports Newtonsoft.Json.Linq

Public Class FrmAggTipoContrato
    Dim dt As DataTable
    Dim Conceptos As DataTable
    Dim Buscando As Boolean = False
    Dim Actualizando As Boolean = False
    Dim CodTipoContrato As String = ""
    Dim secReg As Integer = 0
    Dim FormularioAbierto As Boolean = False
    Dim HDevExpre As New HelperDevExpress
    Dim HNomina As New HelperNomina
    Dim TipoContratos As New CAT_TipoContratos
    Public Property P_FormularioAbierto() As Boolean
        Get
            Return FormularioAbierto
        End Get
        Set(value As Boolean)
            FormularioAbierto = value
        End Set
    End Property

    Private Sub FrmAggTipoContrato_Load(sender As Object, e As EventArgs) Handles Me.Load
        AcomodaForm()
        txtNoBuscando()
        CreaGrilla()
        LlenaGrillaTipoContratos()
        txtNombreTipoContrato.Focus()
        txtNombreTipoContrato.MensajedeAyuda = "Digite el nombre del tipo de contrato. (ENTER,TAB)=Avanzar;"
        txtNombreTipoContrato.MaximoAncho = AnchoCampoSql(ObjetoApiNomina, "CAT_TipoContratos", "NomTipo")
    End Sub
    Private Sub FrmAggTipoContrato_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
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
    Private Sub txtNombreTipoContrato_SaleControl(sender As Object, e As EventArgs) Handles txtNombreTipoContrato.SaleControl
        'btnGuardar.Focus()
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

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            ' 1) Validar campos requeridos
            If txtNombreTipoContrato.ValordelControl = "" Then
                HDevExpre.MensagedeError("El campo nombre no puede estar vacío!")
                txtNombreTipoContrato.Focus()
                Exit Sub
            End If

            ' 2) Crear el objeto TipoContrato
            Dim tipoContrato As New CAT_TipoContratos With {
            .Sec = If(Actualizando, secReg, 0),
            .NomTipo = txtNombreTipoContrato.ValordelControl
        }

            ' 3) Crear el request
            Dim request As New UpsertTipoContratoRequest With {
            .TipoContrato = tipoContrato,
            .Usuario = ObjetosNomina.Datos.Smt_Usuario,
            .Terminal = ObjetosNomina.Datos.Smt_NombreTerminal
        }

            ' 4) Ejecutar procedimiento almacenado
            Dim resp = SMT_EjecutaProcedimientos(ObjetoApiNomina, "SP_UpsertTipoContrato", request.ToJObject())
            Dim response = resp.ToObject(Of UpsertTipoContratoResponse)()

            ' 5) Procesar respuesta
            If response.EsExitoso Then
                ' Mostrar mensaje de éxito con información adicional
                Dim mensaje = "Información guardada exitosamente!"

                ' Si es una inserción nueva, mostrar cuántos conceptos se asociaron
                If Not Actualizando AndAlso response.TipoContrato?.ConceptosAsociados > 0 Then
                    mensaje &= $" Se asociaron automáticamente {response.TipoContrato.ConceptosAsociados} conceptos de nómina."
                End If

                ' Si hay conceptos relacionados, mostrar el total
                If response.TipoContrato?.TotalConceptosRelacionados > 0 Then
                    mensaje &= $" Total de conceptos relacionados: {response.TipoContrato.TotalConceptosRelacionados}"
                End If

                HDevExpre.mensajeExitoso(mensaje)

                ' 6) Refrescar UI
                LlenaGrillaTipoContratos()
                LimpiarCampos()

                ' Si necesitas actualizar alguna grilla de conceptos relacionados
                ' puedes usar los datos de response.TipoContrato.ConceptosNomina

            Else
                ' Mostrar error
                HDevExpre.MensagedeError($"Error al guardar los datos: {response.Mensaje}")

                ' Log adicional si hay código de error
                If response.CodigoError.HasValue Then
                    Console.WriteLine($"Código de error SQL: {response.CodigoError.Value}")
                End If
            End If

        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "btnGuardar_Click/TipoContratos")
        End Try
    End Sub

    Private Sub gvTipoContrato_DoubleClick(sender As Object, e As EventArgs) Handles gvTipoContrato.DoubleClick
        CargarDatos()
    End Sub

    Private Sub gvTipoContrato_KeyPress(sender As Object, e As KeyPressEventArgs) Handles gvTipoContrato.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            CargarDatos()
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        EliminaTipoContrato(CodTipoContrato)
    End Sub
    Private Sub FrmAggTipoContrato_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = ChrW(Keys.Escape) Then
            Me.Close()
        End If
    End Sub

#End Region
#Region "Procedimientos y Funciones"
    Private Sub AcomodaForm()
        Try

            Dim Sql = "Select Sec From ConceptosNomina"
            Conceptos = SMT_AbrirTabla(ObjetoApiNomina, Sql)

            btnGuardar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Guardar)
            btnEliminar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Eliminar)
            btnSalir.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.SalirAtras)
            btnLimpiar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Limpiar)


        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "AcomodaForm Agrega Tipo de Contrato!")
        End Try
    End Sub
    Private Sub CreaGrilla()
        Try
            gvTipoContrato.Columns.Clear()
            HDevExpre.CreaColumnasG(gvTipoContrato, "Sec", "Sec", False, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 0, 0)
            HDevExpre.CreaColumnasG(gvTipoContrato, "NomTipo", "Nombre", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 100, gbxPrincipal.Width)
            gvTipoContrato.OptionsView.ShowFooter = True
            gvTipoContrato.Appearance.HeaderPanel.Font = New Font("Trebuchet MS", 11.0!, FontStyle.Bold)
            gvTipoContrato.Columns(1).Summary.Add(DevExpress.Data.SummaryItemType.Count, "", "{0}  Registros")
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "Crea Grilla Tipo de Contratos")
        End Try
    End Sub
    Private Sub LlenaGrillaTipoContratos()
        Try
            Dim sql As String = "SELECT CP.* FROM CAT_TipoContratos CP"
            dt = SMT_AbrirTabla(ObjetoApiNomina, sql)
            If dt.Rows.Count > 0 Then
                gcTipoContrato.DataSource = dt
            Else
                HDevExpre.mensajeExitoso("No se registra ningún Tipo de Contrato, podemos empezar ingresandolos!..")
                gcTipoContrato.DataSource = Nothing
            End If

        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "LlenaGrillaTipoContratos")
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
        gcTipoContrato.DataSource = dv
    End Sub

    Private Sub LimpiarCampos()
        CodTipoContrato = ""
        Actualizando = False
        txtNombreTipoContrato.ValordelControl = ""
        Buscando = False
        txtNoBuscando()
        secReg = 0
        gcTipoContrato.DataSource = dt
        txtNombreTipoContrato.Focus()
    End Sub
    Private Function GuardaDatos(Sec As Integer) As Boolean
        Try
            TipoContratos = New CAT_TipoContratos
            TipoContratos.NomTipo = txtNombreTipoContrato.ValordelControl
            TipoContratos.Sec = Sec
            Dim RegTipoContrato As New ServiceTipoContrato
            Dim registro As DynamicUpsertResponseDto
            If RegTipoContrato.ValidarCampos(TipoContratos) Then
                registro = RegTipoContrato.UpsertTipoContrato(TipoContratos)
            End If
            If registro.ErrorCount < 1 Then
                Return True
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "Guardando Tipo de Contrato")
            Return False
        End Try
    End Function
    Private Sub CargarDatos()
        Try
            CodTipoContrato = gvTipoContrato.GetFocusedRowCellValue("Sec").ToString
            If CodTipoContrato <> "" Then
                secReg = CInt(CodTipoContrato)
            End If
            txtNombreTipoContrato.ValordelControl = gvTipoContrato.GetFocusedRowCellValue("NomTipo").ToString
            Actualizando = True
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "Cargar datos tipos de contratos")
        End Try
    End Sub
    Private Sub EliminaTipoContrato(idCodTipoCont As String)
        Try
            If Not Actualizando Or secReg = 0 Then
                HDevExpre.MensagedeError("No ha cargado ninguna entidad para ser eliminada.")
                Exit Sub
            End If

            If HDevExpre.MsgSamit(String.Format("Seguro que desea eliminar item seleccionado [{0}]", txtNombreTipoContrato.ValordelControl), MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.OK Then
                ' Crear el request usando EliminarTipoContratoRequest
                Dim request As New EliminarTipoContratoRequest(CInt(idCodTipoCont))

                ' Ejecutar el procedimiento almacenado
                Dim resp = SMT_EjecutaProcedimientos(ObjetoApiNomina, "SP_EliminarTipoContrato", request.ToJObject())
                Dim response = resp.ToObject(Of DynamicDeleteResponse)()

                ' Procesar respuesta
                If response.EsExitoso Then
                    ' Éxito - limpiar y recargar
                    LimpiarCampos()
                    LlenaGrillaTipoContratos()
                    HDevExpre.mensajeExitoso("Tipo de contrato eliminado correctamente!.")

                ElseIf response.EsAdvertencia Then
                    ' Advertencia (no existe o no seleccionado)
                    HDevExpre.MensagedeError(response.Mensaje)

                Else ' Es Error
                    ' Error (asociado a contratos u otro problema)
                    HDevExpre.MensagedeError(response.Mensaje)
                End If
            End If

        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "EliminaTipoContrato")
        End Try
    End Sub
#End Region


    Private Sub btnSalir_KeyPress(sender As Object, e As KeyPressEventArgs) Handles btnSalir.KeyPress, btnLimpiar.KeyPress, btnGuardar.KeyPress, btnEliminar.KeyPress
        HDevExpre.AtrasConScape(e)
    End Sub
End Class