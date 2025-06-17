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

            txtNominas.ConsultaSQL = String.Format("SELECT SecNomina AS Codigo,NomNomina As Descripcion FROM  Nominas")

            txtContratos.ConsultaSQL = String.Format("Select C.IdContrato As Codigo,'Cc:'+CONVERT(VARCHAR,E.Identificacion) +'    Empleado:'+RTRIM(LTRIM(RTRIM(LTRIM(E.PNombre)) + ' ' + " +
" RTRIM(LTRIM(E.SNombre)) + ' ' +  RTRIM(LTRIM(E.PApellido)) + ' ' + RTRIM(LTRIM(E.SApellido)))) As Descripcion " +
" From  Contratos C INNER JOIN  Empleados E ON C.Empleado = E.IdEmpleado WHERE C.Nomina is Null Or C.Nomina=0")
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
            Dim dt As New DataTable
            Dim sql As String = "Select E.Identificacion As IdentificacionEmple, RTRIM(LTRIM(RTRIM(LTRIM(E.PNombre)) + ' ' + " +
 " RTRIM(LTRIM(E.SNombre)) + ' ' +  RTRIM(LTRIM(E.PApellido)) + ' ' + RTRIM(LTRIM(E.SApellido)))) As NomEmple,N.SecNomina As SecNomina," +
 " N.NomNomina As NomNomina,C.CodContrato as CodContrato,C.IdContrato as IdContrato From Contratos C INNER JOIN Empleados E ON E.IdEmpleado = C.Empleado " +
   " INNER Join" +
" Nominas N ON C.Nomina = N.SecNomina Where N.SecNomina = '" + txtNominas.ValordelControl + "'"
            'And" +
            '" C.CodContrato Not In (" +
            '" Select Consul.Contrato From (" +
            '" Select NLC.Contrato As Contrato" +'
            '" From NominaLiquidaContratos NLC " +
            '" Inner Join NominaLiquida NL ON NLC.NominaLiquida = NL.Sec Where NL.EsBorrador =1  " +
            '" Group by NLC.Contrato" +
            '" Union" +
            '" Select NLC.Contrato As Contrato" +
            '" From NominaLiquidaExtraordinariaContratos NLC " +
            '" Inner Join NominaLiquidaExtraordinaria NL ON NLC.NominaLiquidaExtraordinaria = NL.Sec Where NL.EsBorrador =1  " +
            '" Group by NLC.Contrato" +
            '" union" +
            '" Select NLC.Contrato As Contrato" +
            '" From ContratosLiquidados_Contratos NLC " +
            '" Inner Join ContratosLiquidados NL ON NLC.NominaLiquida = NL.Sec Where NL.EsBorrador =1  " +
            '" Group by NLC.Contrato ) AS Consul )"

            dt = SMT_AbrirTabla(ObjetoApiNomina, sql)
            gcNominasContratos.DataSource = dt

            'If txtNominas.DescripciondelControl <> "No Se Encontraron Registros" Or txtNominas.DescripciondelControl <> "" Then
            '    txtContratos.Enabled = True
            '    txtContratos.Focus()

            'Else
            '    txtContratos.Enabled = False
            '    txtContratos.ValordelControl = ""
            'End If

            sql = "SELECT SecNomina AS Codigo,NomNomina AS Descripcion FROM Nominas"
            dt = SMT_AbrirTabla(ObjetoApiNomina, sql)

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
" RTRIM(LTRIM(E.SNombre)) + ' ' +  RTRIM(LTRIM(E.PApellido)) + ' ' + RTRIM(LTRIM(E.SApellido)))) As NomEmple From Contratos C INNER JOIN Empleados E ON E.IdEmpleado = C.Empleado " +
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
        Dim Tbla As DataTable = CType(gcNominasContratos.DataSource, DataTable)
        If Tbla.Rows.Count > 0 Then
            If HDevExpre.MsgSamit("Seguro que desea eliminar este contrato de esta nomina?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.OK Then

                If ExisteDato("Contratos", String.Format("IdContrato='{0}' AND Nomina='{1}' ", gvNominasContratos.GetFocusedRowCellValue("IdContrato").ToString, gvNominasContratos.GetFocusedRowCellValue("SecNomina").ToString), ObjetoApiNomina) Then
                    Dim sql As String = "UPDATE Contratos SET Nomina=@nom Where IdContrato=" + gvNominasContratos.GetFocusedRowCellValue("IdContrato").ToString
                    'Dim cmd As SqlCommand = New SqlCommand(sql, ObjetoApiNomina)
                    'cmd.Parameters.AddWithValue("@nom", System.DBNull.Value)
                    'Dim cant As Integer = cmd.ExecuteNonQuery()
                    'If cant > 0 Then
                    '    Tbla.Rows.Remove(Tbla.Rows(gvNominasContratos.FocusedRowHandle))
                    '    gcNominasContratos.DataSource = Tbla
                    '    Exit Sub
                    'End If

                End If
                Try
                Catch ex As Exception
                    HDevExpre.msgError(ex, ex.Message, "btnEliminar_Click")
                End Try

                Tbla.Rows.Remove(Tbla.Rows(gvNominasContratos.FocusedRowHandle))
                gcNominasContratos.DataSource = Tbla
                AsignaScriptAcontroles()
            End If
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim Tbla As DataTable = CType(gcNominasContratos.DataSource, DataTable)
            If Tbla.Rows.Count > 0 Then
                For incre As Integer = 0 To Tbla.Rows.Count - 1
                    If Not GuardaDatos(Tbla.Rows(incre)("IdContrato").ToString, Tbla.Rows(incre)("SecNomina").ToString) Then
                        Exit Sub
                    End If
                Next
                LlenaGrillaNominasContratos()
                HDevExpre.mensajeExitoso("Datos guardados exitosamente!..")
                AsignaScriptAcontroles()
                LimpiarCampos()
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "btnGuardar_Click")
        End Try

    End Sub

    Private Function GuardaDatos(Contrato As String, nomina As String) As Boolean
        Try
            Dim sql As String = "UPDATE Contratos SET Nomina=@nom Where IdContrato=" + Contrato
            'Dim cmd As SqlCommand = New SqlCommand(sql, ObjetoApiNomina)
            'cmd.Parameters.AddWithValue("@nom", nomina)
            'Dim cant As Integer = cmd.ExecuteNonQuery()
            'If cant > 0 Then

            '    Return True
            'Else
            '    Return False
            'End If

        Catch ex As Exception
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