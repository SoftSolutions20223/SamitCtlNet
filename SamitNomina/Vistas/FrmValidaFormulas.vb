Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraEditors.Repository

Public Class FrmValidaFormulas

    Public Memo As New RepositoryItemMemoExEdit
    Public Formula As String = ""

    Private Sub FrmValidaFormulas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cols = Columnas()
        Dim dt2 As New DataTable
        Dim sasf As System.Drawing.Color = Color.FromArgb(&HB1, &HF3, &HDA)
        For incre As Integer = 0 To cols.Rows.Count - 1
            CreaColumnas(gvLiquidaNomina, cols.Rows(incre)("Nombre").ToString, cols.Rows(incre)("Nombre").ToString, True, True, "", sasf, True, 0, 0, False)
            dt2.Columns.Add(cols.Rows(incre)("Nombre").ToString, GetType(Decimal))
        Next
        CreaColumnas(gvLiquidaNomina, "ResultadoForm", "ResultadoForm", False, False, Formula, sasf, True, 0, 0, False)
        dt2.Rows.Add()
        For Each columnas As DataColumn In dt2.Columns
            dt2.Rows(0)(columnas.ColumnName) = 0
        Next
        gvLiquidaNomina.Appearance.Row.Font = New Font("Tahoma", 14.6, System.Drawing.FontStyle.Regular)
        gvLiquidaNomina.Appearance.HeaderPanel.Font = New Font("Tahoma", 16.6, System.Drawing.FontStyle.Regular)
        gcLiquidaNomina.DataSource = dt2
    End Sub

    Public Function Columnas() As DataTable

        Dim dtcolmuns As New DataTable
        dtcolmuns.Columns.Add("Nombre", GetType(String))
        Dim CantColumns As Integer = 0
        Dim Inicio As Integer = 0
        Dim Fin As Integer = 0
        For i As Integer = 0 To Formula.Length - 1
            If Formula.Substring(i, 1) = "[" Then
                CantColumns = CantColumns + 1
            End If
        Next
        Dim Pocisiones(CantColumns, 2) As String
        For i As Integer = 0 To Formula.Length - 1
            If Formula.Substring(i, 1) = "[" Then
                Inicio = i
            End If
            If Formula.Substring(i, 1) = "]" Then
                Fin = i
            End If
            If Fin > 0 Then
                Dim columna = Formula.Substring(Inicio + 1, Fin - Inicio - 1)
                dtcolmuns.Rows.Add(columna)
                Inicio = 0
                Fin = 0
            End If
        Next
        Return dtcolmuns
    End Function

    Private Sub GridView1_CellValueChanged(sender As Object, e As Views.Base.CellValueChangedEventArgs) Handles gvLiquidaNomina.CellValueChanged
        Dim num = CDec(IIf(gvLiquidaNomina.GetRowCellValue(0, "ResultadoForm").ToString = "", 0, gvLiquidaNomina.GetRowCellValue(0, "ResultadoForm").ToString))
        lblfechaini.Text = "Resultado: " + num.ToString("N2")
    End Sub


    Private Sub CreaColumnas(Grid As GridView, Nombre As String, Titulo As String, Visible As Boolean, Editar As Boolean, formula As String, colores As System.Drawing.Color, numerico As Boolean, Porcentaje_Width As Single, TamañoPadre As Single, EsMemo As Boolean, Optional isfixed As Boolean = False)
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
                .GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom
            End If
            If numerico = True Then
                .UnboundType = DevExpress.Data.UnboundColumnType.Decimal
                .DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                .DisplayFormat.FormatString = "c2"
            End If
            If Porcentaje_Width > 0 Then
                .Width = CInt((Porcentaje_Width * (TamañoPadre - 20)) / 100)
            End If
            If isfixed Then
                .Fixed = Columns.FixedStyle.Left
            End If
            .AppearanceCell.Options.UseBackColor = True
            .AppearanceCell.BackColor = colores
            .OptionsColumn.AllowSize = True
            .OptionsColumn.AllowMove = True
            If Editar Then
                .OptionsColumn.AllowEdit = True
                .OptionsColumn.AllowFocus = True
                .AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Else
                .OptionsColumn.AllowEdit = False
                .OptionsColumn.AllowFocus = False
                .AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            End If
            If EsMemo Then
                .ColumnEdit = Memo
            End If
            .OptionsFilter.AllowFilter = False
            .Visible = Visible
            .AppearanceHeader.Options.UseTextOptions = True
            .AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            .AppearanceCell.Options.UseTextOptions = True
        End With
        Grid.OptionsCustomization.AllowSort = False
        Grid.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.CellFocus
        Grid.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto
        Grid.OptionsView.ColumnAutoWidth = True
        Grid.Columns.Add(gc)
    End Sub


    Private Sub gvLiquidaNomina_CustomUnboundColumnData(sender As Object, e As Views.Base.CustomColumnDataEventArgs) Handles gvLiquidaNomina.CustomUnboundColumnData
        Dim nomcol As String = e.Column.ToString
        Dim cadena As String = ""
    End Sub

    Private Sub gcLiquidaNomina_Click(sender As Object, e As EventArgs) Handles gcLiquidaNomina.Click

    End Sub
End Class