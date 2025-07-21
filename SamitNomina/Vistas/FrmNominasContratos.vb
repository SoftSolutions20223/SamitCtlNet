Imports SamitCtlNet
Imports DevExpress.Utils
Imports System.ComponentModel
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns
Imports System.Transactions
Imports DevExpress.XtraGrid
Imports DevExpress.XtraEditors
Imports DevExpress.XtraVerticalGrid
Imports DevExpress.XtraVerticalGrid.Rows
Imports DevExpress.XtraEditors.Repository
Imports System.Data.SqlClient
Imports SamitNominaLogic

Public Class FrmNominasContratos

    Dim lkEdit As New RepositoryItemLookUpEdit
    Dim FormularioAbierto As Boolean = False
    Dim secReg As Integer = 0
    Dim HDevExpre As New HelperDevExpress
    Dim HNomina As New HelperNomina
    Dim NominaContrato As New Contratos
    Public Property P_FormularioAbierto() As Boolean
        Get
            Return FormularioAbierto
        End Get
        Set(value As Boolean)
            FormularioAbierto = value
        End Set
    End Property
    Private Sub AsignaScriptAcontroles()
        Try
            Dim consultas() = {"SELECT Sec AS Codigo,NomNomina As Descripcion FROM  Nominas",
                "Select C.IdContrato As Codigo,'Cc:'+CONVERT(VARCHAR,E.Identificacion) +'    Empleado:'+RTRIM(LTRIM(RTRIM(LTRIM(E.PNombre)) + ' ' + " +
" RTRIM(LTRIM(E.SNombre)) + ' ' +  RTRIM(LTRIM(E.PApellido)) + ' ' + RTRIM(LTRIM(E.SApellido)))) As Descripcion " +
" From  Contratos C INNER JOIN  Empleados E ON C.Empleado = E.Sec WHERE C.Nomina is Null Or C.Nomina=0"
                }
            Dim Datos = SMT_GetDataset(ObjetoApiNomina, consultas)
            txtNominas.DatosDefecto = Datos.Tables(0)

            txtContratos.DatosDefecto = Datos.Tables(1)
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "AsignaScriptAcontroles")
        End Try
    End Sub

    Private Sub CreaGrillaNominasContratos()
        Dim coloor As System.Drawing.Color = Color.White
        gvNominasContratos.Columns.Clear()
        CreaColumnas(gvNominasContratos, "CodContrato", "Contra", False, False, "", coloor, False)
        CreaColumnas(gvNominasContratos, "IdContrato", "Contrato", True, False, "", coloor, False)
        CreaColumnas(gvNominasContratos, "IdentificacionEmple", "Identificación Empleado", True, False, "", coloor, False)
        CreaColumnas(gvNominasContratos, "NomEmple", "Nombre Empleado", True, False, "", coloor, False)
        CreaColumnas(gvNominasContratos, "SecNomina", "Nomina", True, True, "", coloor, False)
        gvNominasContratos.Appearance.HeaderPanel.Font = New Font("Trebuchet MS", 11.0!, FontStyle.Bold)
        gvNominasContratos.OptionsView.ShowGroupPanel = False
        gvNominasContratos.OptionsCustomization.AllowSort = False
        gvNominasContratos.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.CellFocus
        gvNominasContratos.Appearance.Row.Font = New Font("Tahoma", 10.6, System.Drawing.FontStyle.Regular)
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
            If Editar Then
                .ColumnEdit = lkEdit
            End If
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

    Private Sub AcomodaForm()
        Try
            btnGuardar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Guardar)
            btnAgregar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Agregar)
            btnSalir.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.SalirAtras)
            btnEliminar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Eliminar)
            btnLimpiar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Limpiar)
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "AcomodaForm Agrega Tipo de Contrato!")
        End Try
    End Sub

    Private Sub LlenaGrillaNominasContratos()
        Try

            Dim consultas() = {"Select E.Identificacion As IdentificacionEmple, RTRIM(LTRIM(RTRIM(LTRIM(E.PNombre)) + ' ' + " +
 " RTRIM(LTRIM(E.SNombre)) + ' ' +  RTRIM(LTRIM(E.PApellido)) + ' ' + RTRIM(LTRIM(E.SApellido)))) As NomEmple,N.Sec As SecNomina," +
 " N.NomNomina As NomNomina,C.CodContrato as CodContrato,C.IdContrato as IdContrato From Contratos C INNER JOIN Empleados E ON E.Sec = C.Empleado " +
   " INNER Join" +
" Nominas N ON C.Nomina = N.Sec Where N.Sec = '" + txtNominas.ValordelControl + "'",
"SELECT Sec AS Codigo, NomNomina As Descripcion FROM Nominas"
                }
            Dim Datos = SMT_GetDataset(ObjetoApiNomina, consultas)
            Dim dt As New DataTable
            dt = Datos.Tables(0)
            gcNominasContratos.DataSource = dt

            dt = Datos.Tables(1)
            If dt.Rows.Count > 0 Then

                lkEdit.DataSource = dt
                lkEdit.ValueMember = "Codigo"
                lkEdit.DisplayMember = "Descripcion"
                lkEdit.PopulateColumns()
                lkEdit.Columns(0).Visible = False
            End If

        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "LlenaGrillaNominasContratos")
        End Try
    End Sub

    Private Sub FrmNominasContratos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AsignaScriptAcontroles()
        CreaGrillaNominasContratos()
        AcomodaForm()
        txtNominas.Focus()
        txtNominas.MensajedeAyuda = "Seleccione la nómina a la cual desea agregarle el contrato. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras, (F5,DER)=Buscar"
        txtContratos.MensajedeAyuda = "Seleccione el contrato que desea asignarle a la nómina. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras, (F5,DER)=Buscar"
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub txtNominas_Leave(sender As Object, e As EventArgs) Handles txtNominas.Leave
        LlenaGrillaNominasContratos()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If txtContratos.ValordelControl <> "" And txtContratos.DescripciondelControl <> "No Se Encontraron Registros" And txtContratos.DescripciondelControl <> "" Then
            If txtNominas.ValordelControl <> "" And txtNominas.DescripciondelControl <> "No Se Encontraron Registros" And txtNominas.DescripciondelControl <> "" Then
                Dim Tbla As DataTable = CType(gcNominasContratos.DataSource, DataTable)
                If Tbla.Rows.Count > 0 Then
                    For incre As Integer = 0 To Tbla.Rows.Count - 1
                        If CInt(Tbla.Rows(incre)("IdContrato")) = CInt(Convert.ToInt32(txtContratos.ValordelControl)) Then
                            HDevExpre.MensagedeError("Este contrato ya se encuentra agregado..!")
                            Exit Sub
                        End If
                    Next
                End If

                Dim dt As New DataTable
                Dim sql As String = "Select E.Identificacion As IdentificacionEmple, RTRIM(LTRIM(RTRIM(LTRIM(E.PNombre)) + ' ' + " +
    " RTRIM(LTRIM(E.SNombre)) + ' ' +  RTRIM(LTRIM(E.PApellido)) + ' ' + RTRIM(LTRIM(E.SApellido)))) As NomEmple From Contratos C INNER JOIN Empleados E ON E.Sec = C.Empleado " +
    " Where C.IdContrato = '" + txtContratos.ValordelControl + "'"

                dt = SMT_AbrirTabla(ObjetoApiNomina, sql)

                Dim NuevaFila As DataRow = Tbla.NewRow()
                NuevaFila("IdContrato") = txtContratos.ValordelControl
                NuevaFila("IdentificacionEmple") = dt.Rows(0)("IdentificacionEmple")
                NuevaFila("NomEmple") = dt.Rows(0)("NomEmple")
                NuevaFila("NomNomina") = txtNominas.DescripciondelControl
                NuevaFila("SecNomina") = txtNominas.ValordelControl
                Tbla.Rows.Add(NuevaFila)
                Tbla.AcceptChanges()
                gcNominasContratos.DataSource = Tbla
                txtContratos.ValordelControl = ""
            Else
                HDevExpre.MensagedeError("El campo Nomina no puede estar vacio ni contener valores invalidos..!")
            End If

        Else
            HDevExpre.MensagedeError("El campo Contratos no puede estar vacio ni contener valores invalidos..!")
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarCampos()
    End Sub

    Private Sub LimpiarCampos()
        txtNominas.ValordelControl = ""
        txtContratos.ValordelControl = ""
        gcNominasContratos.DataSource = Nothing
        LlenaGrillaNominasContratos()
        txtNominas.Focus()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            Dim Tbla As DataTable = CType(gcNominasContratos.DataSource, DataTable)

            If Tbla Is Nothing OrElse Tbla.Rows.Count = 0 Then
                Exit Sub
            End If

            ' Obtener valores del registro seleccionado
            Dim idContrato As String = gvNominasContratos.GetFocusedRowCellValue("IdContrato")?.ToString()
            Dim secNomina As String = gvNominasContratos.GetFocusedRowCellValue("SecNomina")?.ToString()

            If String.IsNullOrEmpty(idContrato) Then
                HDevExpre.MensagedeError("No se ha seleccionado un contrato válido")
                Exit Sub
            End If

            If HDevExpre.MsgSamit("Seguro que desea eliminar este contrato de esta nomina?",
                             MessageBoxButtons.OKCancel,
                             MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.OK Then

                ' Verificar que la relación existe
                If ExisteDato("Contratos",
                         String.Format("IdContrato='{0}' AND Nomina='{1}'", idContrato, secNomina),
                         ObjetoApiNomina) Then

                    ' Crear el request para desasignar (NULL)
                    Dim request As New AsignarNominaContratoRequest(idContrato, Nothing)

                    ' Ejecutar procedimiento almacenado
                    Dim resp = SMT_EjecutaProcedimientos(ObjetoApiNomina, "SP_AsignarNominaContrato", request.ToJObject())
                    Dim response = resp.ToObject(Of AsignarNominaContratoResponse)()

                    ' Procesar respuesta
                    If response.EsExitoso Then
                        ' Remover de la grilla local
                        Tbla.Rows.Remove(Tbla.Rows(gvNominasContratos.FocusedRowHandle))
                        gcNominasContratos.DataSource = Tbla

                        ' Mensaje opcional (el procedimiento ya incluye información en response.Mensaje)
                        Console.WriteLine(response.Mensaje)

                        ' Refrescar controles si es necesario
                        AsignaScriptAcontroles()
                    Else
                        HDevExpre.MensagedeError($"Error al desasignar la nómina: {response.Mensaje}")
                    End If
                Else
                    ' Si no existe la relación, solo remover de la grilla local
                    Tbla.Rows.Remove(Tbla.Rows(gvNominasContratos.FocusedRowHandle))
                    gcNominasContratos.DataSource = Tbla
                    AsignaScriptAcontroles()
                End If
            End If

        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "btnEliminar_Click")
        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim Tbla As DataTable = CType(gcNominasContratos.DataSource, DataTable)

            If Tbla Is Nothing OrElse Tbla.Rows.Count = 0 Then
                HDevExpre.MensagedeError("No hay datos para guardar")
                Exit Sub
            End If

            ' Crear el request para procesamiento masivo
            Dim request As New AsignarNominasContratosMasivoRequest()

            ' Agregar todas las asignaciones
            For Each row As DataRow In Tbla.Rows
                Dim idContrato As String = row("IdContrato")?.ToString()
                Dim secNomina As Integer = 0

                If Not String.IsNullOrEmpty(idContrato) AndAlso
               Integer.TryParse(row("SecNomina")?.ToString(), secNomina) Then
                    request.AgregarAsignacion(idContrato, secNomina)
                End If
            Next

            ' Validar que hay asignaciones para procesar
            If request.Asignaciones.Count = 0 Then
                HDevExpre.MensagedeError("No hay asignaciones válidas para procesar")
                Exit Sub
            End If

            ' Ejecutar procedimiento almacenado
            Dim resp = SMT_EjecutaProcedimientos(ObjetoApiNomina,
                                           "SP_AsignarNominasContratosMasivo",
                                           request.ToJObject())
            Dim response = resp.ToObject(Of AsignarNominasContratosMasivoResponse)()

            ' Procesar respuesta
            If response.EsExitoso Then
                LlenaGrillaNominasContratos()
                HDevExpre.mensajeExitoso(response.Mensaje)
                AsignaScriptAcontroles()
                LimpiarCampos()

            ElseIf response.EsParcial Then
                ' Mostrar detalles de errores
                Dim mensajeDetalle As New System.Text.StringBuilder()
                mensajeDetalle.AppendLine(response.Mensaje)
                mensajeDetalle.AppendLine()
                mensajeDetalle.AppendLine("Detalles de errores:")

                For Each detalle In response.Detalles.Where(Function(d) d.Estado = "ERROR")
                    mensajeDetalle.AppendLine($"- Contrato {detalle.IdContrato}: {detalle.Mensaje}")
                Next

                HDevExpre.MensagedeError(mensajeDetalle.ToString())

                ' Refrescar para mostrar solo los que sí se guardaron
                LlenaGrillaNominasContratos()

            Else
                HDevExpre.MensagedeError(response.Mensaje)
            End If

        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "btnGuardar_Click")
        End Try
    End Sub

    Private Function GuardaDatos(Contrato As String, nomina As String) As Boolean
        Try
            ' Convertir nomina a Integer nullable
            Dim secNomina As Integer? = Nothing
            If Not String.IsNullOrEmpty(nomina) Then
                secNomina = CInt(nomina)
            End If

            ' Crear el request
            Dim request As New AsignarNominaContratoRequest(Contrato, secNomina)

            ' Ejecutar procedimiento almacenado
            Dim resp = SMT_EjecutaProcedimientos(ObjetoApiNomina, "SP_AsignarNominaContrato", request.ToJObject())
            Dim response = resp.ToObject(Of AsignarNominaContratoResponse)()

            ' Procesar respuesta
            If response.EsExitoso Then
                ' Log opcional
                Console.WriteLine(response.Mensaje)
                Return True
            Else
                ' Log del error
                Console.WriteLine($"Error: {response.Mensaje}")
                Return False
            End If

        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "GuardaDatos")
            Return False
        End Try
    End Function

    Private Sub FrmNominasContratos_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        LimpiarCampos()
    End Sub

    Private Sub txtContratos_Leave(sender As Object, e As EventArgs) Handles txtContratos.Leave
        If txtContratos.ValordelControl = "" Or txtContratos.DescripciondelControl = "No Se Encontraron Registros" Or txtContratos.DescripciondelControl = "" Then
            btnGuardar.Focus()
        Else
            btnAgregar.Focus()
        End If
    End Sub

    Private Sub btnLimpiar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles btnSalir.KeyPress, btnLimpiar.KeyPress, btnGuardar.KeyPress, btnEliminar.KeyPress, btnAgregar.KeyPress
        HDevExpre.AtrasConScape(e)
    End Sub

    Private Sub txtContratos_Enter(sender As Object, e As EventArgs) Handles txtContratos.Enter
        txtContratos.RefrescarDatos()
    End Sub

    Private Sub txtNominas_Load(sender As Object, e As EventArgs) Handles txtNominas.Load

    End Sub

    Private Sub gvNominasContratos_ValidatingEditor(sender As Object, e As BaseContainerValidateEditorEventArgs) Handles gvNominasContratos.ValidatingEditor
        Dim dt As New DataTable
        Dim sql As String = "Select NLC.Contrato As Contrato" +
        " From NominaLiquidaContratos NLC " +
        " Inner Join NominaLiquida NL ON NLC.NominaLiquida = NL.Sec Where NLC.Contrato='" + gvNominasContratos.GetFocusedRowCellValue("CodContrato").ToString + "' And NL.EsBorrador =1  " +
        " Group by NLC.Contrato" +
        " Union" +
        " Select NLC.Contrato As Contrato" +
        " From NominaLiquidaExtraordinariaContratos NLC " +
        " Inner Join NominaLiquidaExtraordinaria NL ON NLC.NominaLiquidaExtraordinaria = NL.Sec Where NLC.Contrato='" + gvNominasContratos.GetFocusedRowCellValue("CodContrato").ToString + "' And NL.EsBorrador =1  " +
        " Group by NLC.Contrato" +
        " union" +
        " Select NLC.Contrato As Contrato" +
        " From ContratosLiquidados_Contratos NLC " +
        " Inner Join ContratosLiquidados NL ON NLC.NominaLiquida = NL.Sec Where NLC.Contrato='" + gvNominasContratos.GetFocusedRowCellValue("CodContrato").ToString + "' And NL.EsBorrador =1  " +
        " Group by NLC.Contrato"
        dt = SMT_AbrirTabla(ObjetoApiNomina, sql)
        If dt.Rows.Count > 0 Then
            e.ErrorText = "Este contrato tiene liquidaciones pendientes, no es posible cambiar la nomina!.."
            e.Valid = False
        End If

    End Sub

    Private Sub txtContratos_Load(sender As Object, e As EventArgs) Handles txtContratos.Load

    End Sub
End Class