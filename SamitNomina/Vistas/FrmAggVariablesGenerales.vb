﻿Option Strict Off
Imports SamitCtlNet
Imports System.ComponentModel
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Columns
Imports System.Transactions
Imports DevExpress.XtraGrid.Views.Grid
Imports SamitCtlNet.SamitCtlNet
Imports SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL
Imports SamitNominaLogic

Public Class FrmAggVariablesGenerales

    Dim FormularioAbierto As Boolean = False
    Dim dtos As DataTable
    Dim Buscando As Boolean = False
    Dim ActualizandoDatosBasicos As Boolean = False
    Dim NomVar As String = ""
    Dim EsPredeterminado As Boolean = False
    Dim HDevExpre As New HelperDevExpress
    Dim HNomina As New HelperNomina

    'Propiedades
    Dim VSecVariable As String
    Public Property Sec_Variable() As String
        Get
            Return VSecVariable
        End Get
        Set(value As String)
            VSecVariable = value
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
            btnAggDetalles.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Agregar)
            EliminarDetalle.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.EliminarGris)
            grbVigente.SelectedIndex = 1

            txtCodDian.ConsultaSQL = String.Format("SELECT Codigo,Descripcion FROM CodigosDian")
            txtCodDian.RefrescarDatos()
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, " AcomodaForm Cargo")
        End Try
    End Sub

    Private Sub FrmAggVariablesGenerales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            AcomodaForm()
            Sec_Variable = "0"
            LlenaGrillaVariablesG()
            LlenaGrillaDetalleVariables(Sec_Variable)
            txtNoBuscando()
            txtNombre.Select()
            txtNombre.MensajedeAyuda = ""
            txtValor.MensajedeAyuda = ""
            txtNombre.MaximoAncho = AnchoCampoSql(ObjetoApiNomina, "VariablesGenerales", "NomVariable")
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, " Load Cargos")
        End Try
    End Sub





#Region "EfectosControles"
    'CONTROLES DATOS BASICOS

    Private Sub TlpVariablesG_SizeChanged(sender As Object, e As EventArgs) Handles TlpVariablesG.SizeChanged
        CreaGrillaVariablesG()
        CreaGrillaDetalleVariablesG()
        If gvVariablesG.RowCount = 0 Then
            LlenaGrillaVariablesG()
        End If
    End Sub

    Private Sub btnSalir_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Down) Then

        End If
    End Sub
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

            If Sec_Variable = "" Then
                Sec_Variable = "0"
            End If

            ' 2) Determinar si es actualización
            Dim isUpdate = (ActualizandoDatosBasicos AndAlso CInt(Sec_Variable) > 0)

            ' 3) Crear el request
            Dim request As New UpsertVariableGeneralRequest With {
            .Sec = CInt(Sec_Variable),
            .NomVariable = txtNombre.ValordelControl,
            .NomVariableAnterior = If(isUpdate, NomVar, Nothing),
            .CodDian = txtCodDian.ValordelControl,
            .Vigente = grbVigente.SelectedIndex.ToString(),
            .Usuario = ObjetosNomina.Datos.Smt_Usuario,
            .Terminal = ObjetosNomina.Datos.Smt_NombreTerminal
        }

            ' 4) Agregar detalles desde la grilla
            Dim dtDetalles As DataTable = DirectCast(gcDetalleVariablesG.DataSource, DataTable)
            If dtDetalles IsNot Nothing AndAlso dtDetalles.Rows.Count > 0 Then
                For i As Integer = 0 To dtDetalles.Rows.Count - 1
                    Dim detalle As New DetalleVariableDTO With {
                    .Sec = CInt(If(IsDBNull(dtDetalles.Rows(i)("Sec")), 0, dtDetalles.Rows(i)("Sec"))),
                    .Variable = CInt(If(IsDBNull(dtDetalles.Rows(i)("Variable")), 0, dtDetalles.Rows(i)("Variable"))),
                    .Fecha = CDate(dtDetalles.Rows(i)("Fecha")),
                    .Valor = CDec(dtDetalles.Rows(i)("Valor"))
                }
                    request.Detalles.Add(detalle)
                Next
            End If

            ' 5) Ejecutar procedimiento almacenado
            Dim resp = SMT_EjecutaProcedimientos(ObjetoApiNomina, "SP_UpsertVariablesGenerales", request.ToJObject())
            Dim response = resp.ToObject(Of UpsertVariableGeneralResponse)()

            ' 6) Procesar respuesta
            If response.EsExitoso Then
                ' Actualizar Sec_Variable si fue inserción
                If Not isUpdate AndAlso response.Variable IsNot Nothing Then
                    Sec_Variable = response.Variable.Sec.ToString()
                End If

                ' Mostrar mensaje de éxito con información adicional
                Dim mensaje = "Datos guardados exitosamente!.."

                ' Agregar información sobre detalles si aplica
                If response.Variable IsNot Nothing Then
                    If response.Variable.DetallesInsertados > 0 Then
                        mensaje &= vbCrLf & $"• Se agregaron {response.Variable.DetallesInsertados} detalles"
                    End If

                    If response.Variable.FormulasActualizadas > 0 Then
                        mensaje &= vbCrLf & $"• Se actualizaron {response.Variable.FormulasActualizadas} fórmulas"
                    End If
                End If

                HDevExpre.mensajeExitoso(mensaje)

                ' Limpiar y refrescar
                LimpiarTodosCampos()
                LlenaGrillaVariablesG()
                LlenaGrillaDetalleVariables(Sec_Variable)

            Else
                ' Mostrar error
                HDevExpre.MensagedeError($"Error al guardar: {response.Mensaje}")

                ' Log adicional si hay código de error
                If response.CodigoError.HasValue Then
                    Console.WriteLine($"Código de error SQL: {response.CodigoError.Value}")
                End If
            End If

        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "btnGuardar_Click/VariablesGenerales")
        End Try
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarTodosCampos()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If EsPredeterminado Then
            HDevExpre.MensagedeError("Lo sentimos, las variables predeterminadas no pueden ser eliminadas.")
            Exit Sub
        End If
        If Not HNomina.ValidaEnFormulas(NomVar) Then
            Exit Sub
        End If
        'Using trans As New TransactionScope
        Try
            If ActualizandoDatosBasicos Then

                If HDevExpre.MsgSamit("Seguro que desea eliminar esta Variable con todos sus detalles?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.OK Then
                    Dim sql = ""
                    If ExisteDato("DetallesVariablesGenerales", " Variable=" + Sec_Variable, ObjetoApiNomina) Then
                        sql = "DELETE FROM DetallesVariablesGenerales WHERE Variable=" + Sec_Variable
                        If SMT_EjcutarComandoSqlBool(ObjetoApiNomina, sql) < 0 Then
                            Exit Sub
                        End If
                    End If
                    sql = "DELETE FROM VariablesGenerales WHERE Sec=" + Sec_Variable
                    If SMT_EjcutarComandoSqlBool(ObjetoApiNomina, sql) < 0 Then
                        Exit Sub
                    End If
                End If

            Else
                MensajedeError("Seleccione la variable a eliminar")
                Exit Sub
            End If
            'trans.Complete()
            LimpiarTodosCampos()
            HDevExpre.mensajeExitoso("Datos eliminados exitosamente!..")
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "btnEliminar_Click")
        End Try
        'End Using

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
        txtCodDian.ValordelControl = ""
        txtValor.ValordelControl = ""
        dteFecha.Text = ""
        NomVar = ""
        EsPredeterminado = False
        txtNoBuscando()
        'Limpia variables para validar acutalizaciones
        ActualizandoDatosBasicos = False
        'Limpia propiedades
        Sec_Variable = "0"
        'Limpia todas las grillas
        gcDetalleVariablesG.DataSource = Nothing
        LlenaGrillaVariablesG()
        LlenaGrillaDetalleVariables(Sec_Variable)
        txtNombre.Focus()
        grbVigente.SelectedIndex = 1
    End Sub
    Private Sub CargarDatos(Cargo As String)
        Try
            Dim sql As String = String.Format("SELECT * FROM VariablesGenerales WHERE Sec='{0}'", gvVariablesG.GetFocusedRowCellValue("Sec").ToString)
            Dim dt As DataTable = SMT_AbrirTabla(ObjetoApiNomina, sql)

            Dim Fila As DataRow = dt.Rows(0)
            Dim Vigente As String = Fila("Vigente").ToString
            NomVar = Fila("NomVariable").ToString
            EsPredeterminado = IIf(IsDBNull(Fila("EsPredeterminado")), False, Fila("EsPredeterminado"))
            txtNombre.ValordelControl = Fila("NomVariable").ToString
            txtCodDian.ValordelControl = Fila("CodDian").ToString
            Sec_Variable = Fila("Sec").ToString
            grbVigente.SelectedIndex = Convert.ToInt32(Fila("Vigente").ToString)
            LlenaGrillaDetalleVariables(Sec_Variable)
            ActualizandoDatosBasicos = True
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "  CargarDatosCargos")
        End Try
    End Sub

    Private Sub LlenaGrillaVariablesG()
        Try
            Dim sql As String = "SELECT VG.CodDian,VG.Sec,VG.NomVariable, case VG.Vigente " +
                                " WHEN '1' then 'Si' when '0' then 'No' end As Vigente,case VG.EsPredeterminado WHEN '1' then 'Si' when '0' then 'No' end As EsPredeterminado " +
                                " FROM VariablesGenerales VG"
            Dim dt As DataTable = SMT_AbrirTabla(ObjetoApiNomina, sql)
            dt = SMT_AbrirTabla(ObjetoApiNomina, sql)
            gcVariablesG.DataSource = dt
            dtos = dt
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "LlenaGrillaVariablesG")
        End Try
    End Sub

    Private Sub gcVariablesG_DoubleClick(sender As Object, e As EventArgs) Handles gcVariablesG.DoubleClick
        CargarDatos(gvVariablesG.GetFocusedRowCellValue("Sec").ToString)
    End Sub

    Private Sub gcVariablesG_KeyPress(sender As Object, e As KeyPressEventArgs) Handles gcVariablesG.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            CargarDatos(gvVariablesG.GetFocusedRowCellValue("Sec").ToString)
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
                .DisplayFormat.FormatString = "n4"
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
    Private Sub CreaGrillaVariablesG()
        gvVariablesG.Columns.Clear()
        HDevExpre.CreaColumnasG(gvVariablesG, "Sec", "Sec", False, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 0, 0)
        HDevExpre.CreaColumnasG(gvVariablesG, "CodDian", "Codigo Dian", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 30, gbxVariablesG.Width)
        HDevExpre.CreaColumnasG(gvVariablesG, "NomVariable", "Nombre", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 70, gbxVariablesG.Width)
        HDevExpre.CreaColumnasG(gvVariablesG, "Vigente", "Vigente", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 30, gbxVariablesG.Width)
        HDevExpre.CreaColumnasG(gvVariablesG, "EsPredeterminado", "Es Predeterminado", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 30, gbxVariablesG.Width)
        gvVariablesG.Appearance.HeaderPanel.Font = New Font("Trebuchet MS", 11.0!, FontStyle.Bold)

    End Sub

#End Region
#Region "Funciones y Procedimientos --> DetallesVariablesGenerales"

    Private Sub CreaGrillaDetalleVariablesG()
        gvDetalleVariableG.Columns.Clear()
        CreaColumnas(gvDetalleVariableG, "Valor", "Valor", True, 50, gbxDetallesVariablesG.Width, True, True)
        CreaColumnas(gvDetalleVariableG, "Fecha", "Fecha", True, 50, gbxDetallesVariablesG.Width, True, False)
        gvDetalleVariableG.Appearance.HeaderPanel.Font = New Font("Trebuchet MS", 11.0!, FontStyle.Bold)
        Dim classResize As New ClaseResize
        classResize.Resizagrid(gvDetalleVariableG)
    End Sub

    Private Sub LlenaGrillaDetalleVariables(Variable As String)
        Try
            Dim sql As String = String.Format("SELECT * FROM DetallesVariablesGenerales " & _
                                             " WHERE Variable='{0}'", Variable)
            Dim dt As DataTable = SMT_AbrirTabla(ObjetoApiNomina, sql)
            For incre As Integer = 0 To dt.Columns.Count - 1
                dt.Columns(incre).AllowDBNull = False
            Next
            gcDetalleVariablesG.DataSource = dt
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "LlenaGrillaDetalleVariables")
        End Try
    End Sub

    Private Function ValidaCamposDetallesVariablesG() As Boolean
        If txtValor.ValordelControl = "" Then
            HDevExpre.MensagedeError("El Campo Valor no puede estar vacio!..")
            Return False
        ElseIf dteFecha.Text = "" Then
            HDevExpre.MensagedeError("El Campo Fecha no puede estar vacio!..")
            Return False
        Else
            Return True
        End If
    End Function

    Private Function GuardaDetallesVariables(SecVariable As String, Fecha As String, Valor As String) As Boolean
        Try

            Dim GenSql_tabDetallesVariablesG As New ClGeneraSqlDLL
            GenSql_tabDetallesVariablesG.PasoConexionTabla(ObjetoApiNomina, "DetallesVariablesGenerales")
            GenSql_tabDetallesVariablesG.PasoValores("Variable", SecVariable, TipoDatoActualizaSQL.Cadena)
            GenSql_tabDetallesVariablesG.PasoValores("Valor", Valor, TipoDatoActualizaSQL.Cadena)
            GenSql_tabDetallesVariablesG.PasoValores("Fecha", Fecha, TipoDatoActualizaSQL.Cadena)
            GenSql_tabDetallesVariablesG.PasoValores("Sec", SMT_AbrirTabla(ObjetoApiNomina, "SELECT ISNULL( MAX (Sec),0)+1 AS Codigo FROM DetallesVariablesGenerales").Rows(0)(0).ToString, TipoDatoActualizaSQL.Cadena)


            If GenSql_tabDetallesVariablesG.EjecutarComandoNET(SQLGenera.Insercion, "") Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "GuardaDetallesVariables")
            Return False
        End Try
    End Function
#End Region


    Private Sub txtFecha_KeyDown(sender As Object, e As KeyEventArgs)
        Dim Texto As String = dteFecha.Text
        If Texto.Length <= 4 Then
            e.Handled = True
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
            HDevExpre.EntraControlDev(txtBusqueda, , )
        End If
    End Sub

    Private Sub txtBusqueda_Leave(sender As Object, e As EventArgs) Handles txtBusqueda.Leave
        If txtBusqueda.Text = "" Then
            Buscando = False
            txtNoBuscando()
        End If
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
        gcVariablesG.DataSource = dv
    End Sub

    Private Sub LimpiarCamposAsignaciones()
        Try
            dteFecha.Text = ""
            txtValor.ValordelControl = ""
            dteFecha.Focus()
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "LimpiarCamposAsignaciones")
        End Try
    End Sub

    Private Sub EliminarDetalle_Click(sender As Object, e As EventArgs) Handles EliminarDetalle.Click
        Dim Tbla As DataTable = CType(gcDetalleVariablesG.DataSource, DataTable)
        If Tbla.Rows.Count > 0 Then
            Tbla.Rows.Remove(Tbla.Rows(gvDetalleVariableG.FocusedRowHandle))
            gcDetalleVariablesG.DataSource = Tbla
        End If

    End Sub

    Private Sub FrmAggVariablesGenerales_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        LimpiarTodosCampos()
    End Sub

    Private Sub FrmAggVariablesGenerales_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If ActualizandoDatosBasicos Then
            If HDevExpre.MsgSamit("Se están modificando datos, Seguro que desea cerrar el formulario?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Cancel Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub gvDetalleVariableG_KeyDown(sender As Object, e As KeyEventArgs) Handles gvDetalleVariableG.KeyDown
        If e.KeyCode = 46 Then
            Dim Tbla As DataTable = CType(gcDetalleVariablesG.DataSource, DataTable)
            If Tbla.Rows.Count > 0 Then
                Tbla.Rows.Remove(Tbla.Rows(gvDetalleVariableG.FocusedRowHandle))
                gcDetalleVariablesG.DataSource = Tbla
            End If
        End If
    End Sub


    Private Sub btnAggDetalles_Click(sender As Object, e As EventArgs) Handles btnAggDetalles.Click
        If ValidaCamposDetallesVariablesG() Then
            Dim Tbla As DataTable = CType(gcDetalleVariablesG.DataSource, DataTable)
            If Tbla.Rows.Count > 0 Then

                For incre As Integer = 0 To Tbla.Rows.Count - 1
                    If Tbla.Rows(incre)("Fecha") = dteFecha.Text Then
                        HDevExpre.MensagedeError("Ya se encuentra un detalle agregado con esta fecha..!")
                        Exit Sub
                    End If
                Next
            End If
            Dim NuevaFila As DataRow = Tbla.NewRow()
            NuevaFila("Fecha") = dteFecha.Text
            NuevaFila("Valor") = txtValor.ValordelControl
            NuevaFila("Sec") = 0
            NuevaFila("Variable") = 0
            Tbla.Rows.Add(NuevaFila)
            Tbla.AcceptChanges()
            gcDetalleVariablesG.DataSource = Tbla
            LimpiarCamposAsignaciones()
        End If
    End Sub

    Private Sub grbVigente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles grbVigente.KeyPress
        HDevExpre.AvanzaConEnter(e)
    End Sub

    Private Sub grbVigente_Enter(sender As Object, e As EventArgs) Handles grbVigente.Enter
        HDevExpre.EntraControlRadioGroup(grbVigente, lblVigente)
        FrmPrincipal.MensajeDeAyuda.Caption = "Seleccione si la variable esta vigente o no. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
    End Sub

    Private Sub grbVigente_Leave(sender As Object, e As EventArgs) Handles grbVigente.Leave
        HDevExpre.SaleControlRadioGroup(grbVigente, lblVigente)
    End Sub

    Private Sub dteFecha_Enter(sender As Object, e As EventArgs) Handles dteFecha.Enter
        HDevExpre.EntraControlDateEditDEV(dteFecha, lblFecha)
        FrmPrincipal.MensajeDeAyuda.Caption = "Seleccione la fecha desde cuendo aplicará el valor a la variable. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
    End Sub

    Private Sub dteFecha_Leave(sender As Object, e As EventArgs) Handles dteFecha.Leave
        FrmPrincipal.MensajeDeAyuda.Caption = ""
        HDevExpre.SaleControlDateEditDEV(dteFecha, lblFecha)
    End Sub


    Private Sub dteFecha_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dteFecha.KeyPress
        HDevExpre.AvanzaConEnter(e)
    End Sub

    Private Sub btnGuardar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles btnSalir.KeyPress, btnLimpiar.KeyPress, btnGuardar.KeyPress, btnEliminar.KeyPress, btnAggDetalles.KeyPress
        HDevExpre.AtrasConScape(e)
    End Sub
End Class