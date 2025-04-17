Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.IO
Imports System.Drawing
Imports System.Windows.Forms


Public Module FormatoSMT
    Friend VGRetorno As Long
    Friend VGNumModulo As Integer
    Public SMTConex As New SqlConnection
    Public Property SMTConexMod As New SqlConnection
    Public SMTLogin As String = ""
    Public SMTServidor As String = ""
    Public SMTNumUsuario As Integer = 0
    Public VGRutaBD_Seg = "Seguridad"
    Public VGPaswdBD_Seg As String = "2121121512"
    Public VGPaswdBD_Mod As String = "2121121512"
    Friend CadConex As String = "Data Source=rodrigo-pc\samit;Initial Catalog=E0012012;user id = sa; password = 2121121512"
    Public SmtConExcell As System.Data.OleDb.OleDbConnection
    Public RegistroSamit As New ClregistroSamit
    Public Sub SMT_HabilitaBotonRibbon(ByVal Ribbonobj As RibbonControl, ByVal NombreBoton As String, ByVal Habilitado As Boolean)
        On Error Resume Next
        Dim ItemBoton As New BarButtonItem

        ItemBoton = Ribbonobj.Items(NombreBoton)
        ItemBoton.Enabled = Habilitado

    End Sub
    Public Sub SMT_VisiblePaginaRibbon(ByVal Ribbonobj As RibbonControl, ByVal NumPagina As Integer, ByVal Habilitado As Boolean)
        Dim ItemPagina As New RibbonPage
        Try
            ItemPagina = Ribbonobj.Pages.Item(NumPagina)
            ItemPagina.Visible = Habilitado
        Catch ex As Exception
            MsgBox("Pagina " & NumPagina & " No Existe o no Fue posible cambiar el estado")
        End Try

    End Sub
    Public Function NombredelModulo(Modulo As Integer) As String
        On Error Resume Next
        Dim TB As DataTable
        NombredelModulo = ""
        TB = SMT_AbrirRecordSet(SMTConex, "Select Descripcion from Productos Where NumProducto =" & Modulo.ToString)
        If TB.Rows.Count = 1 Then
            NombredelModulo = TB(0)("Descripcion")
        End If
    End Function
    Public Sub SMT_DeshabilitaGruposPagina(ByVal Ribbonobj As RibbonControl, ByVal Pagina As Integer, ByVal Habilitado As Boolean)
        Dim SmtItem As New RibbonPageGroup

        Try
            For Each SmtItem In Ribbonobj.Pages.Item(1).Groups
                SmtItem.Visible = False
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub SMT_MapeaGrid(ByRef Grid As GridView)
        On Error Resume Next
        Grid.OptionsView.ShowAutoFilterRow = True 'Mostrar Fila de Filtro automatico
        Grid.OptionsView.ShowFooter = True 'Mostrar Pie de Grid
        Grid.OptionsView.ShowGroupPanel = False 'Mostra Pabel de Grupo
        Grid.OptionsView.ColumnAutoWidth = False 'Columnas Automaticas
        Grid.NewItemRowText = "Presione Click para agregar nueva Fila"
        Grid.OptionsView.NewItemRowPosition = NewItemRowPosition.None   'Posicion fila para insertar
        Grid.OptionsBehavior.AllowAddRows = False
        Grid.OptionsBehavior.AllowDeleteRows = False
        Grid.OptionsBehavior.Editable = False
        Grid.Columns(0).Width = 60
        Grid.Columns(1).Width = 180
        Grid.Columns(2).Width = 60
        SMT_MapeaGridTotales(Grid, 0, DevExpress.Data.SummaryItemType.Count, "")

    End Sub
    Public Sub SMT_MapeaGridContab(ByRef Grid As GridView)
        'On Error Resume Next


        Grid.OptionsView.ShowAutoFilterRow = True 'Mostrar Fila de Filtro automatico
        Grid.OptionsView.ShowFooter = True 'Mostrar Pie de Grid
        Grid.OptionsView.ShowGroupPanel = False 'Mostra Pabel de Grupo
        Grid.OptionsView.ColumnAutoWidth = True 'Columnas Automaticas
        Grid.NewItemRowText = "Presione Click para agregar nueva Fila"
        Grid.OptionsView.NewItemRowPosition = NewItemRowPosition.Top 'Posicion fila para insertar
        Grid.OptionsBehavior.AllowAddRows = True
        Grid.OptionsBehavior.AllowDeleteRows = False
        Grid.OptionsBehavior.Editable = True
        'Grid.Columns(0).Width = 60
        'Grid.Columns(1).Width = 180
        'Grid.Columns(2).Width = 60
        SMT_MapeaGridTotales(Grid, 0, DevExpress.Data.SummaryItemType.Count, "")
        SMT_MapeaGridColumnaLookUpEdit(Grid)
        'SMT_MapeaGridColumnaLookUpEdit1(Grid)
        SMT_MapeaGridColumnaCombo(Grid, "CtaDeprecia", _
        "Select CodCuenta,NomCuenta ,Estado from ct_plandeCuentas Where esdemovimiento = 1 ANd Estado = 'V'", "CodCuenta", "NomCuenta")
        SMT_MapeaGridColumnaCombo(Grid, "CtaAlmacen", _
        "Select CodCuenta,NomCuenta ,Estado from ct_plandeCuentas Where esdemovimiento = 1 ANd Estado = 'V'", "CodCuenta", "NomCuenta")
    End Sub
    Public Sub SMT_MapeaGridColumnaLookUpEdit(ByRef Grid As GridView)
        On Error Resume Next
        Dim Col As GridColumn = Grid.Columns("CtaActivo"), SQL As String, chk As New RepositoryItemGridLookUpEdit

        Col.Caption = "CtaActivo"
        Col.ColumnEdit = New RepositoryItemGridLookUpEdit
        Col.Visible = True
        SQL = "Select CodCuenta,NomCuenta from ct_plandeCuentas Where esdemovimiento = 1 ANd Estado = 'V'"
        chk = Col.ColumnEdit

        chk.View.OptionsView.ColumnAutoWidth = True

        chk.View.OptionsView.ShowAutoFilterRow = True
        chk.DisplayMember = "NomCuenta"
        chk.ValueMember = "CodCuenta"

        chk.NullText = ""
        chk.DataSource = SMT_AbrirRecordSet(SMTConexMod, SQL)
        'chk.View.BestFitColumns()


    End Sub
    Public Sub SMT_MapeaGridColumnaCombo(ByRef Grid As GridView, Columna As String, SQLbusca As String, ColValor As String, ColMuestra As String)
        On Error Resume Next
        Dim Col As GridColumn = Grid.Columns(Columna), SQL As String, chk As New RepositoryItemGridLookUpEdit
        Dim col1 As GridColumn = New GridColumn()
        col1.VisibleIndex = 0
        col1.Caption = "Codigo"
        col1.FieldName = "CodCuenta"
        col1.Width = 400
        col1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        col1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        col1.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        col1.SummaryItem.DisplayFormat = "Cant={0:n0}"

        Dim col2 As GridColumn = New GridColumn()
        col2.VisibleIndex = 1
        col2.Caption = "Nombre Cuenta"
        col2.FieldName = "NomCuenta"
        col2.Width = 1200

        Dim col3 As GridColumn = New GridColumn()
        col3.VisibleIndex = 2
        col3.Caption = "Est"
        col3.FieldName = "Estado"
        col3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        col3.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        col3.Width = 200

        Col.Caption = Columna
        Col.ColumnEdit = New RepositoryItemGridLookUpEdit
        Col.Visible = True
        'SQL = "Select CodCuenta,NomCuenta,Estado from ct_plandeCuentas Where esdemovimiento = 1 ANd Estado = 'V'"
        chk = Col.ColumnEdit
        chk.View.OptionsView.ShowFooter = True
        chk.PopupFormSize = New System.Drawing.Size(400, 340)
        chk.DisplayMember = ColMuestra
        chk.ValueMember = ColValor
        chk.View.OptionsBehavior.AutoPopulateColumns = False
        chk.View.OptionsView.ColumnAutoWidth = True
        chk.DataSource = SMT_AbrirRecordSet(SMTConexMod, SQLbusca)
        chk.View.Columns.Clear()
        chk.View.Columns.Add(col1)
        chk.View.Columns.Add(col2)
        chk.View.Columns.Add(col3)

        chk.View.OptionsView.ShowColumnHeaders = True
        'chk.PopupSizeable = True
        'chk.View.Columns(0).Width = 150
        'chk.View.Columns(1).Width = 2600
        'chk.View.Columns(2).Width = 200
        ' chk.View.OptionsView.ShowAutoFilterRow = True

        'chk.NullText = ""
        ' MsgBox(chk.View.Columns.Count)
        'chk.PopupBorderStyle = PopupBorderStyles.Style3D




    End Sub
    Public Sub SMT_MapeaGridColumnaLookUpEdit1(ByRef Grid As GridView)
        'On Error Resume Next
        Dim Col As GridColumn = Grid.Columns("GrupoAct"), SQL As String, chk As New RepositoryItemGridLookUpEdit

        Col.Caption = "GrupoAct"
        Col.ColumnEdit = New RepositoryItemGridLookUpEdit
        Col.Visible = True
        Col.Width = 100
        SQL = "Select Codigo, Descripcion from AC_GrupoActivo Where Vigente= 1"
        chk = Col.ColumnEdit
        chk.View.OptionsView.ColumnAutoWidth = True
        chk.View.Columns("Descripcion").Width = 1000
        chk.View.Columns("Codigo").Width = 200
        'chk.View.Columns("Codigo").Visible = False
        chk.View.OptionsView.ShowAutoFilterRow = True
        chk.DisplayMember = "Descripcion"
        chk.ValueMember = "Codigo"
        chk.NullText = ""
        chk.DataSource = SMT_AbrirRecordSet(SMTConexMod, SQL)

    End Sub
    
    Public Sub SMT_MapeaGridTotales(ByRef Grid As GridView, ByVal NumCol As Integer, ByVal Operacion As DevExpress.Data.SummaryItemType, ByVal Formato As String)
        On Error Resume Next
        Grid.Columns(NumCol).SummaryItem.SummaryType = Operacion
        If Formato.Trim = "" Then Formato = "Total: {0:n0}"
        Grid.Columns(NumCol).SummaryItem.DisplayFormat = Formato

    End Sub

    Public Sub SMT_OcultarVerPaginaRibbon(ByVal Ribbonobj As RibbonControl, ByVal Pagina As String, ByVal VerPAgina As Boolean)

        Try
            For Each itempagina As RibbonPage In Ribbonobj.Pages
                If itempagina.Name.ToUpper = Pagina.ToUpper Then
                    itempagina.Visible = VerPAgina
                End If
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Function SmtCarpetaTemporal() As String
        SmtCarpetaTemporal = System.IO.Path.GetTempPath()
    End Function


    Public Function ExisteTipoComp(CodigoCom As String) As Boolean
        On Error GoTo Err_ExisteTipoComp
        Dim Tbl As DataTable
        Dim TxtSQL As String = "Select IdTC From CT_ComTipo where IdTC='" & CodigoCom & "'"
        Tbl = SMT_AbrirRecordSet(SMTConexMod, TxtSQL)
        If Tbl.Rows.Count = 1 Then Return True
        Tbl.Dispose()
        Tbl = Nothing

Exit_ExisteTipoComp:
        Return False
        Exit Function
Err_ExisteTipoComp:
        MensajedeError()
        Resume Exit_ExisteTipoComp
    End Function
    Public Function Nombre_Oficina(Oficina As Byte) As String
        Nombre_Oficina = TraerDatoSQL("Select NomOficina from Oficinas Where NumEmpresa=" & VgEmpresa & " AND NumOficina=" & VgOficina, SMTConex, "NomOficina")
    End Function
End Module

