Imports System.Data.SqlClient
Imports SamitCtlNet
Imports System.Windows.Forms
Imports Microsoft.VisualBasic

Public Class FrmRolEmpresa
    Public NumUsuario As String
    Private YaBusco As Boolean = False
    Private EstaConsultando As Boolean = False
    Private Sub FrmRolEmpresa_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        TxtEmpresa.Focus()
        BuscarRoles()


    End Sub
    Private Sub FrmRolEmpresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        On Error Resume Next
        Me.Icon = My.Resources.SamitIcono
        Aceptar.Image = My.Resources.Apply_16x16
        Cancelar.Image = My.Resources.Cancel_16x16
        SMT_MapeaGrid(Gvrol)
        TxtEmpresa.Text = Dll.RegistroSAMIT.Empresa_Ingreso
        TxtOficina.Text = Dll.RegistroSAMIT.Oficina_Ingreso

        FechaIngeso.EditValue = CDate(Dll.RegistroSAMIT.FechaUltimo_Ingreso)
        BuscarEmpresa(False)
        YaBusco = False
        BuscarOficina(False)
        'BuscarRoles()

        FechaIngeso.EditValue = DateTime.Now
        FechaIngeso.ReadOnly = False
    End Sub
    Private Sub SMT_MapeaGrid(GridVista As DevExpress.XtraGrid.Views.Grid.GridView)
        Try
            'Mostrar Titulo del Grid
            GridVista.OptionsView.ShowViewCaption = True
            GridVista.ViewCaption = "Roles del Usuario (" & SMTLogin & ") en la empresa y Oficina"

            GridVista.ActiveFilterEnabled = False
            GridVista.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False
            GridVista.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False
            GridVista.OptionsBehavior.Editable = False
            GridVista.OptionsBehavior.ReadOnly = True

            GridVista.OptionsSelection.EnableAppearanceFocusedRow = True

            ' Opciones de Manejo x Usuaerio Final
            GridVista.OptionsCustomization.AllowRowSizing = False
            GridVista.OptionsCustomization.AllowColumnResizing = False
            GridVista.OptionsCustomization.AllowColumnMoving = False
            GridVista.OptionsCustomization.AllowFilter = False
            GridVista.OptionsCustomization.AllowSort = False
            ' Opciones de Vista del Grid
            GridVista.OptionsView.ShowGroupPanel = False
            GridVista.OptionsView.ShowAutoFilterRow = False
            GridVista.OptionsView.ColumnAutoWidth = False

            GridVista.OptionsMenu.ShowAutoFilterRowItem = False
            GridVista.OptionsMenu.ShowGroupSortSummaryItems = False
            GridVista.OptionsMenu.EnableColumnMenu = False
            GridVista.OptionsMenu.EnableGroupPanelMenu = False
            SMT_AgregarColumnaGrid(GvRol)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub BuscarRoles()
        On Error Resume Next
        Dim Tb As DataTable
        Dim TxtSql As String
        Aceptar.Enabled = False
        If TxtOficina.Text.Trim = "" Or TxtEmpresa.Text.Trim = "" Then
            GridRol.DataSource = Nothing
            Exit Sub
        End If
        TxtSql = " select ur.NumeroRol as Numero,RO.Nombre as NombreRol   from UsuarioRol UR inner join Roles RO on UR.NumeroRol = RO.NumeroRol  " & _
                 " Where UR.Estado = 'V' AND NumeroUsuario =" & GUsuario.Numero & " AND Ur.empresa =" & TxtEmpresa.Text & " AND Oficina = " & TxtOficina.Text
        If SMTConex.State = ConnectionState.Closed Then
            MsgBox("Conexion Cerrada")
            Me.Close()
            Exit Sub
        End If

        Tb = SMT_AbrirRecordSet(SMTConex, TxtSql)
        GridRol.DataSource = Tb
        If GvRol.RowCount > 0 Then Aceptar.Enabled = True
        Tb.Dispose()

    End Sub

    Private Sub SMT_AgregarColumnaGrid(GVista As DevExpress.XtraGrid.Views.Grid.GridView)
        Dim Col As DevExpress.XtraGrid.Columns.GridColumn = New DevExpress.XtraGrid.Columns.GridColumn
        GVista.Columns.Clear()

        Col.Name = "Numero"
        Col.Caption = "Codigo"
        Col.FieldName = "Numero"
        Col.VisibleIndex = 1
        'Col.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Col.Visible = True
        Col.Width = 60
        Col.OptionsColumn.ReadOnly = True
        Col.OptionsColumn.AllowEdit = False
        Col.OptionsColumn.AllowFocus = False
        Col.AppearanceCell.Options.UseTextOptions = True
        Col.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Col.OptionsColumn.ReadOnly = True
        GVista.Columns.Add(Col)

        Dim Col2 As New DevExpress.XtraGrid.Columns.GridColumn

        Col2.Name = "Descripcion"
        Col2.Caption = "Descripción de los Roles"
        Col2.FieldName = "NombreRol"
        'Col.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Col2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Col2.Visible = True
        Col2.Width = 430
        Col2.OptionsColumn.AllowEdit = False
        Col2.OptionsColumn.AllowFocus = False
        GVista.Columns.Add(Col2)
    End Sub

    Private Sub TxtEmpresa_GotFocus(sender As Object, e As EventArgs) Handles TxtEmpresa.GotFocus
        YaBusco = False
    End Sub

    Private Sub TxtEmpresa_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtEmpresa.KeyDown
        Select Case e.KeyCode
            Case Keys.Right, Keys.F5
                BuscarEmpresa(True)
            Case Keys.Enter

        End Select
    End Sub

    Private Sub TxtEmpresa_Leave(sender As Object, e As EventArgs) Handles TxtEmpresa.Leave
        If Not EstaConsultando Then
            BuscarEmpresa()
            BuscarRoles()
        End If

    End Sub

    Private Sub TxtOficina_GotFocus(sender As Object, e As EventArgs) Handles TxtOficina.GotFocus
        YaBusco = False
    End Sub

    Private Sub TxtOficina_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtOficina.KeyDown
        Select Case e.KeyCode
            Case Keys.Right, Keys.F5
                BuscarOficina(True)
            Case Keys.Enter
                'If DescOficina.Text = "" Then TxtOficina.Text = ""
        End Select
    End Sub


    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles Cancelar.Click
        Me.Hide()
    End Sub

    Private Sub BuscarEmpresa(Optional F5 As Boolean = False)
        On Error Resume Next
        If YaBusco Then Exit Sub

        SMT_BuscarRapido(SMTConex, "Select NumEmpresa as Codigo, NomEmpresa as Valor FROM Empresas Where UPPER(Estado)='V'",
        IIf(TxtEmpresa.Text.Trim <> "", " AND NumEmpresa = " & TxtEmpresa.Text, ""), TxtEmpresa, DescEmpresa, True, F5, "Busqueda Rapida de Empresas")

    End Sub
    Private Sub BuscarOficina(Optional F5 As Boolean = False)
        Try
            If YaBusco Then Exit Sub
            If TxtEmpresa.Text.Trim <> "" Then
                SMT_BuscarRapido(SMTConex, "Select NumOficina as Codigo, NomOficina as Valor FROM oficinas Where NumEmpresa = " & TxtEmpresa.Text.Trim & " AND UPPER(Estado)='V'",
                IIf(TxtOficina.Text.Trim <> "", " AND NumOficina = " & TxtOficina.Text, ""), TxtOficina, DescOficina, True, F5, "Busqueda Rapida de Oficinas de la Empresa")
            End If
        Catch ex As Exception

        End Try


    End Sub
    Private Sub SMT_BuscarRapido(Conexion As SqlConnection, SqlBusca As String, SqlCond As String, TxtObj As Object, LblDesc As Object, Optional CargarForm As Boolean = True, Optional PresionoF5 As Boolean = False, Optional Mensaje As String = "Busqueda Rapida")
        Dim Tb As DataTable, FrmBusqRapida As New FrmBusqRapida
        FrmBusqRapida.Text = Mensaje
        Try
            If Not PresionoF5 Then
                Tb = SMT_AbrirRecordSet(Conexion, SqlBusca & " " & SqlCond)
                If Tb.Rows.Count = 1 Then
                    Dim Fila As DataRow = Tb.Rows(0)
                    If TxtObj.text = "" Then TxtObj.text = Fila("Codigo")
                    LblDesc.text = Fila("Valor")
                    YaBusco = True
                ElseIf Tb.Rows.Count > 1 And TxtObj.text = "" Then
                    EstaConsultando = True
                    FrmBusqRapida.Tabla = Tb
                    FrmBusqRapida.ShowDialog()
                    EstaConsultando = False
                    If Not FrmBusqRapida.SiCancelo Then
                        TxtObj.Text = FrmBusqRapida.CodigoDevuelvo
                        LblDesc.Text = FrmBusqRapida.ValorDevuelvo
                    End If
                    FrmBusqRapida.Close()
                    TxtObj.focus()
                    YaBusco = True
                Else
                    Tb = SMT_AbrirRecordSet(Conexion, SqlBusca)
                    If Tb.Rows.Count > 0 Then
                        FrmBusqRapida.Tabla = Tb
                        FrmBusqRapida.ShowDialog()
                        If Not FrmBusqRapida.SiCancelo Then
                            TxtObj.Text = FrmBusqRapida.CodigoDevuelvo
                            LblDesc.Text = FrmBusqRapida.ValorDevuelvo
                        End If
                        FrmBusqRapida.Close()
                        If LblDesc.text = "" Then TxtObj.focus()
                    End If
                End If
            Else
                Tb = SMT_AbrirRecordSet(Conexion, SqlBusca)
                If Tb.Rows.Count > 0 Then
                    FrmBusqRapida.Tabla = Tb
                    FrmBusqRapida.ShowDialog()
                    If Not FrmBusqRapida.SiCancelo Then
                        TxtObj.Text = FrmBusqRapida.CodigoDevuelvo
                        LblDesc.Text = FrmBusqRapida.ValorDevuelvo
                    End If
                    FrmBusqRapida.Close()
                    If LblDesc.text = "" Then TxtObj.focus()
                End If
            End If
            If LblDesc.text = "" Then TxtObj.text = ""
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub Aceptar_Click(sender As Object, e As EventArgs) Handles Aceptar.Click
        Dim NomBD As String = "E" & Format(CInt(TxtEmpresa.Text.Trim), "000") & Format(Year(FechaIngeso.EditValue), "0000")
        Dim Espera As New ClEspera
        Try
            If Not ExisteBd(NomBD) Then
                MsgBox("La Base de Datos " & NomBD.ToString.ToUpper & " No Existe " & vbCrLf & "Verifique Número de Empresa y Año de Ingreso")
                GoTo Salir
            End If
            Me.Hide()
            Espera.Mostrar("", "Iniciando Conexion Samit SQL")
            CadConex = "Data Source=" & SMTConex.DataSource & ";Initial Catalog=" & NomBD & ";user id = sa; password = " & VGPaswdBD_Mod
            SMTConexMod.ConnectionString = CadConex
            SMTConexMod.Open()
            If SMTConexMod.State = ConnectionState.Open Then
                Espera.Descripcion = "Conexión Establecida Ok"
                HayConexionConSRV = True
                Dll.RegistroSAMIT.UsuarioIngresa = SMTLogin
                Dll.RegistroSAMIT.Empresa_Ingreso = TxtEmpresa.Text
                Dll.RegistroSAMIT.Oficina_Ingreso = TxtOficina.Text
                Dll.RegistroSAMIT.FechaUltimo_Ingreso = FechaIngeso.DateTime.ToString("dd/MM/yyyy")
                VgEmpresa = Convert.ToInt32(TxtEmpresa.Text)
                VgOficina = Convert.ToInt32(TxtOficina.Text)
                VgLoginUsuario = SMTLogin
                VgNumeroRolIngreso = Gvrol.GetFocusedRowCellValue("Numero").ToString
                VgNombreRolIngreso = Gvrol.GetFocusedRowCellValue("NombreRol").ToString
                GUsuario.RolIngreso = VgNumeroRolIngreso
                Dll.Seguridad.FechadeTrabajo = CDate(FechaIngeso.EditValue)
                Dll.SmtConexion = SMTConex
                Try
                    Dll.SmtConexionMod = SMTConexMod
                Catch ex As Exception
                End Try
                FechaW = FechaIngeso.EditValue
                BdTrabajo = NomBD
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
Salir:
        Me.Close()
        Espera.Terminar()
    End Sub

    Private Sub TxtEmpresa_EditValueChanged(sender As Object, e As EventArgs) Handles TxtEmpresa.EditValueChanged
        DescEmpresa.Text = ""
        TxtOficina.Text = ""
        YaBusco = False
    End Sub

    Private Sub TxtOficina_EditValueChanged(sender As Object, e As EventArgs) Handles TxtOficina.EditValueChanged
        DescOficina.Text = ""
    End Sub

    Private Sub GridRol_Click(sender As Object, e As EventArgs) Handles GridRol.Click
        'MsgBox(Gvrol.FocusedRowHandle)
    End Sub

    Private Sub TxtOficina_LostFocus(sender As Object, e As EventArgs) Handles TxtOficina.LostFocus
        On Error Resume Next
        If Not EstaConsultando Then
            If TxtOficina.Text = "" Or DescOficina.Text = "" Then BuscarOficina()
            BuscarRoles()
        End If

    End Sub

    Private Sub FechaIngeso_EditValueChanged(sender As Object, e As EventArgs) Handles FechaIngeso.EditValueChanged

    End Sub

    Private Sub FechaIngeso_KeyDown(sender As Object, e As KeyEventArgs) Handles FechaIngeso.KeyDown
        If e.KeyCode = Keys.F12 Then
            FechaIngeso.ReadOnly = False
        End If
    End Sub
End Class