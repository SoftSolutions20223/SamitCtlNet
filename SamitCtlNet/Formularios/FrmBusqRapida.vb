Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Imports System.Windows.Forms
Imports System.Drawing

Public Class FrmBusqRapida
    Private TxtSql As String
    Private TxtCond As String
    Private Tb1 As DataTable
    Public ValorDevuelvo As String = ""
    Public CodigoDevuelvo As String = ""
    Public Tabla As DataTable
    Public SiCancelo As Boolean = False
    Private Sub FrmBusqRapida_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Return
                ValorDevuelvo = GvBusca.GetFocusedRowCellValue("Valor")
                CodigoDevuelvo = GvBusca.GetFocusedRowCellValue("Codigo")
                Me.Hide()
            Case Keys.Escape
                SiCancelo = True
                Me.Hide()
        End Select
    End Sub

    Private Sub FrmBusqRapida_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = ChrW(Keys.Back) Then
            If LblFiltro.Text.Length > 0 Then LblFiltro.Text = Mid(LblFiltro.Text, 1, LblFiltro.Text.Length - 1)
        Else
            If e.KeyChar = ChrW(Keys.Space) Then
                LblFiltro.Text = LblFiltro.Text & " "
            Else
                LblFiltro.Text = LblFiltro.Text & e.KeyChar.ToString
            End If

        End If
    End Sub

    Private Sub FrmBusqRapida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SMT_MapeaGrid(GvBusca)
        GvBusca.Columns(0).Width = 60
        GvBusca.Columns(1).Width = 450
        If Tabla.Rows.Count > 0 Then
            GridBusca.DataSource = Tabla
        End If
    End Sub
    Private Sub SMT_MapeaGrid(GridVista As DevExpress.XtraGrid.Views.Grid.GridView)
        Try
            'Mostrar Titulo del Grid
            GridVista.OptionsView.ShowViewCaption = True
            GridVista.ViewCaption = "Resultados de la Busqueda"

            GridVista.ActiveFilterEnabled = False
            GridVista.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False
            GridVista.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False
            GridVista.OptionsBehavior.Editable = False

            GridVista.OptionsSelection.EnableAppearanceFocusedRow = True

            ' Opciones de Manejo x Usuario Final
            GridVista.OptionsCustomization.AllowRowSizing = False
            GridVista.OptionsCustomization.AllowColumnResizing = False
            GridVista.OptionsCustomization.AllowColumnMoving = False
            GridVista.OptionsCustomization.AllowFilter = False
            GridVista.OptionsCustomization.AllowSort = False

            ' Opciones de Vista del Grid
            GridVista.OptionsView.ShowGroupPanel = False
            GridVista.OptionsView.ShowAutoFilterRow = False
            GridVista.OptionsView.ColumnAutoWidth = False
            GridVista.OptionsView.ShowFooter = False
            'Panel Inferior de Filtro
            GridVista.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never


            GridVista.OptionsMenu.ShowAutoFilterRowItem = False
            GridVista.OptionsMenu.ShowGroupSortSummaryItems = False
            GridVista.OptionsMenu.EnableColumnMenu = False
            GridVista.OptionsMenu.EnableGroupPanelMenu = False
            GridVista.OptionsMenu.ShowGroupSortSummaryItems = False
            ' Manejo de Colores

            GridVista.Appearance.FocusedRow.BackColor = Color.Aquamarine
            GridVista.Appearance.FocusedRow.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            GridVista.Appearance.FocusedRow.ForeColor = Color.Maroon
            GridVista.Appearance.FocusedRow.Options.UseTextOptions = False

            GridVista.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            GridVista.Columns(0).OptionsColumn.AllowEdit = False
            GridVista.Columns(0).OptionsColumn.AllowFocus = False
            GridVista.Columns(0).OptionsColumn.ReadOnly = True
            'GridVista.Columns(0)
            GridVista.Columns(1).OptionsColumn.AllowEdit = False
            GridVista.Columns(1).OptionsColumn.AllowFocus = False


            'SMT_AgregarColumnaGrid(GvRol)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub LblFiltro_TextChanged(sender As Object, e As EventArgs) Handles LblFiltro.TextChanged
        Dim Filtro As String = ""
        Dim Filas() As DataRow

        If LblFiltro.Text.Length > 0 Then
            Filtro = "[Valor] like '%" & LblFiltro.Text.Trim & "%'"
        End If
        Try
            Filas = Tabla.Select(Filtro)
            Tb1 = Tabla.Clone
            Dim I As Integer
            For I = 0 To Filas.GetUpperBound(0)
                Tb1.ImportRow(Filas(I))
            Next

            GridBusca.DataSource = Tb1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub GvBusca_DoubleClick(sender As Object, e As EventArgs) Handles GvBusca.DoubleClick
        ValorDevuelvo = GvBusca.GetFocusedRowCellValue("Valor")
        CodigoDevuelvo = GvBusca.GetFocusedRowCellValue("Codigo")
        Me.Hide()
    End Sub

End Class