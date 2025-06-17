Imports SamitCtlNet
Imports DevExpress.XtraEditors
Imports System.ComponentModel

Public Class FrmBusqueda
    Dim TxtDev As TextEdit
    Dim TxtSam As SamitTexto
    Dim Formu As String
    Dim dtBusqueda As DataTable
    Dim CopyDt As DataTable
    Dim FormularioAbierto As Boolean = False
    Dim HDevExpre As New HelperDevExpress
    Dim HNomina As New HelperNomina
    Public Property P_FormularioAbierto() As Boolean
        Get
            Return FormularioAbierto
        End Get
        Set(value As Boolean)
            FormularioAbierto = value
        End Set
    End Property
    ''' <summary>
    ''' Busqueda rapida
    ''' </summary>
    ''' <param name="Consulta">Consulta sql que llena la grilla, OJO --> solo dos campos Codigo y Descripcion ;)</param>
    ''' <param name="TituloCodigo">Titulo que desea que aparezca en la grilla para la columna Codigo</param>
    ''' <param name="TituloDescripcion">Titulo que desea que aparezca en la grilla para la columna Descripcion</param>
    ''' <remarks></remarks>
    Public Sub New(Consulta As String, TituloGrid As String, Optional txt As TextEdit = Nothing, Optional text As SamitTexto = Nothing, Optional TituloCodigo As String = "Código", Optional TituloDescripcion As String = "Descripción", Optional Formulario As String = "")
        InitializeComponent()
        If IsNothing(text) = False Then
            TxtSam = text
            TxtDev = Nothing
        End If
        If IsNothing(txt) = False Then
            TxtSam = Nothing
            TxtDev = txt
        End If
        If Formulario <> "" Then
            Formu = Formulario
        End If
        gvBusqueda.Columns.Clear()

        'GrillaDevExpress.CrearGrilla(gvBusqueda, True, False, "Lista " + TituloGrid)
        HDevExpre.CreaColumnasG(gvBusqueda, "Codigo", TituloCodigo, True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 23, lblBusqueda.Width)
        HDevExpre.CreaColumnasG(gvBusqueda, "Descripcion", TituloDescripcion, True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 75, lblBusqueda.Width)
        gvBusqueda.OptionsView.ShowFooter = True
        gvBusqueda.Appearance.HeaderPanel.Font = New Font("Tahoma", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        gvBusqueda.Appearance.ViewCaption.Font = New Font("Tahoma", 11.0F, FontStyle.Bold, GraphicsUnit.Point)
        gvBusqueda.Appearance.FocusedRow.BackColor = ColorTranslator.FromHtml("#B9FFF9")
        gvBusqueda.Columns(1).Summary.Add(DevExpress.Data.SummaryItemType.Count, "", "{0}  Registros")
        Dim dtBusqueda As DataTable = SMT_AbrirTabla(ObjetoApiNomina, Consulta)
        CopyDt = dtBusqueda.Clone
        Dim sec As Integer = 0
        Dim row As DataRow
        If dtBusqueda.Rows.Count > 0 Then
            While True
                If sec > dtBusqueda.Rows.Count - 1 Then
                    Exit While
                End If
                row = CopyDt.NewRow
                row("Codigo") = dtBusqueda.Rows(sec)("Codigo")
                row("Descripcion") = StrConv(dtBusqueda.Rows(sec)("Descripcion").ToString, VbStrConv.ProperCase)
                CopyDt.Rows.Add(row)
                CopyDt.AcceptChanges()
                sec += 1
            End While
            gcBusqueda.DataSource = CopyDt
        End If
        FormatoLabelNoBuscando()
    End Sub
    Private Sub FrmBusqueda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        Try
            FormatoLabelBuscando()
            If e.KeyChar = ChrW(Keys.Back) Then
                If lblBusqueda.Text.Length > 0 Then lblBusqueda.Text = Mid(lblBusqueda.Text, 1, lblBusqueda.Text.Length - 1)
                lblBusqueda_TextChanged(sender, e)
            Else
                If e.KeyChar = ChrW(Keys.Space) Then
                    lblBusqueda.Text = lblBusqueda.Text & " "
                Else
                    lblBusqueda.Text = lblBusqueda.Text & e.KeyChar.ToString
                End If
            End If
            If e.KeyChar = ChrW(Keys.Enter) And gvBusqueda.RowCount > 0 Then SeleccionaItem()
            If lblBusqueda.Text = "" Then FormatoLabelNoBuscando()
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "FrmBusqueda_KeyPress")
        End Try
    End Sub


    Private Sub FormatoLabelBuscando()
        If lblBusqueda.Text = "Digite cualquier parametro de busqueda" Then
            lblBusqueda.Text = ""
            lblBusqueda.Font = New Font("Segoe UI Symbol", 12.0F, FontStyle.Bold)
            lblBusqueda.BackColor = ColorTranslator.FromHtml("#B9FFF9")
            lblBusqueda.ForeColor = Color.DarkRed
        End If
    End Sub
    Private Sub FormatoLabelNoBuscando()
        lblBusqueda.Text = "Digite cualquier parametro de busqueda"
        lblBusqueda.BackColor = System.Drawing.Color.LemonChiffon
        lblBusqueda.Font = New System.Drawing.Font("Trebuchet MS", 12.0F, System.Drawing.FontStyle.Italic)
        lblBusqueda.Appearance.ForeColor = System.Drawing.Color.Gray
        gcBusqueda.DataSource = CopyDt
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
        Dim dv As New DataView(CopyDt)
        dv.RowFilter = Grilla.CrearFiltro(CopyDt, e.Argument.ToString)
        e.Result = dv
    End Sub
    Private Sub MostrarResultadoFiltro(sender As Object, e As RunWorkerCompletedEventArgs)
        Dim dv As DataView = CType(e.Result, DataView)
        gcBusqueda.DataSource = dv
    End Sub

    Private Sub FrmBusqueda_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        HDevExpre.SalirConEsc(e, Me)
    End Sub

    Private Sub lblBusqueda_TextChanged(sender As Object, e As EventArgs) Handles lblBusqueda.TextChanged
        If lblBusqueda.Text <> "Digite cualquier parametro de busqueda" Then FiltrarDatos(lblBusqueda.Text)
    End Sub
    Private Sub SeleccionaItem()
        If IsNothing(TxtSam) = False Then
            TxtSam.ValordelControl = gvBusqueda.GetFocusedRowCellValue("Descripcion").ToString
            TxtSam.Focus()
        End If
        If IsNothing(TxtDev) = False Then
            TxtDev.Text = gvBusqueda.GetFocusedRowCellValue("Codigo").ToString
            TxtDev.Select()
        End If
        If Formu = "Novedades" Then
            Dim evento As New EventArgs
            Dim eventokey As New KeyPressEventArgs(Convert.ToChar(13))
            Dim Objeto As New Object
            Dim sql As String = "Select P.Año As Año,P.Nomina As Nomina,P.CodPeriodo As Periodo,NL.OfiNomina As Oficina " +
                " From NominaLiquida NL INNER JOIN PeriodosLiquidacion P ON NL.Periodo = P.Sec  Where NL.Sec=" + gvBusqueda.GetFocusedRowCellValue("Codigo").ToString
            Dim dt As DataTable = SMT_AbrirTabla(ObjetoApiNomina, sql)
            FrmAggNovedades.txtOficina.RefrescarDatos()
            FrmAggNovedades.txtOficina.ValordelControl = dt.Rows(0)("Oficina").ToString
            FrmAggNovedades.txtOficina_Leave(Objeto, evento)
            FrmAggNovedades.txtNominas.RefrescarDatos()
            FrmAggNovedades.txtNominas.ValordelControl = dt.Rows(0)("Nomina").ToString
            FrmAggNovedades.txtNominas_Leave(Objeto, evento)
            FrmAggNovedades.txtAño.ValordelControl = dt.Rows(0)("Año").ToString
            FrmAggNovedades.txtAño_Leave(Objeto, evento)
            FrmAggNovedades.txtPeriodos.RefrescarDatos()
            FrmAggNovedades.txtPeriodos.ValordelControl = dt.Rows(0)("Periodo").ToString
            FrmAggNovedades.btnBuscar_Click(Objeto, evento)
        End If
        If Formu = "LiquidarNomina" Then
            Dim evento As New EventArgs
            Dim Objeto As New Object
            Dim sql As String = "Select P.Año As Año,P.Nomina As Nomina,P.CodPeriodo As Periodo,NL.OfiNomina As Oficina " +
                " From NominaLiquida NL INNER JOIN PeriodosLiquidacion P ON NL.Periodo = P.Sec  Where NL.Sec=" + gvBusqueda.GetFocusedRowCellValue("Codigo").ToString
            Dim dt As DataTable = SMT_AbrirTabla(ObjetoApiNomina, sql)
            FrmLiquidarNomina.txtOficina.RefrescarDatos()
            FrmLiquidarNomina.txtOficina.ValordelControl = dt.Rows(0)("Oficina").ToString
            FrmLiquidarNomina.txtOficina_Leave(Objeto, evento)
            FrmLiquidarNomina.txtNominas.RefrescarDatos()
            FrmLiquidarNomina.txtNominas.ValordelControl = dt.Rows(0)("Nomina").ToString
            FrmLiquidarNomina.txtNominas_Leave(Objeto, evento)
            FrmLiquidarNomina.txtAño.ValordelControl = dt.Rows(0)("Año").ToString
            FrmLiquidarNomina.txtAño_Leave(Objeto, evento)
            FrmLiquidarNomina.txtPeriodos.RefrescarDatos()
            FrmLiquidarNomina.txtPeriodos.ValordelControl = dt.Rows(0)("Periodo").ToString
            FrmLiquidarNomina.btnBuscar_Click(Objeto, evento)
        End If
        If Formu = "LiquidarNominaExtraordinaria" Then
            FrmLiquidacionExtraordinaria.ConsultarLiquidacion(gvBusqueda.GetFocusedRowCellValue("Codigo").ToString, "")
        End If
        If Formu = "LiquidarContratos" Then
            FrmLiquidarContratos.ConsultarLiquidacion(gvBusqueda.GetFocusedRowCellValue("Codigo").ToString, "")
        End If
        Me.Close()
    End Sub

    Private Sub gvBusqueda_DoubleClick(sender As Object, e As EventArgs) Handles gvBusqueda.DoubleClick
        If gvBusqueda.RowCount > 0 Then SeleccionaItem()
    End Sub

    Private Sub FrmBusqueda_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        If gvBusqueda.Columns.Count = 0 Then Exit Sub
        'Distribuye los anchos de columnas en el gv de los productos de la receta
        gvBusqueda.Columns(0).Width = CInt((23 * (lblBusqueda.Width - 20)) / 100)
        gvBusqueda.Columns(1).Width = CInt((75 * (lblBusqueda.Width - 20)) / 100)
    End Sub

    Private Sub gcBusqueda_Click(sender As Object, e As EventArgs) Handles gcBusqueda.Click

    End Sub
End Class