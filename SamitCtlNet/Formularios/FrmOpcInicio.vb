Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.Utils
Imports DevExpress.XtraVerticalGrid
Imports DevExpress.XtraVerticalGrid.Rows
Imports System.Windows.Forms
Imports SamitCtlNet
Imports System.Drawing


Public Class FrmOpcInicio

    Private Sub FrmOpcInicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BotonSalir.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Default
        BotonSalir.Glyph = FrmConex.Smt_Imagenes.Images(5)
        MapeaGridVertical(Grid)
    End Sub

    Private Sub MapeaGridVertical(Grid As DevExpress.XtraVerticalGrid.VGridControl)

        Dim rowCat As New CategoryRow

        Grid.Rows.Add(rowCat)
        ' modifying the height 
        rowCat.Height = 20
        rowCat.Name = "Inicio"

        rowCat.Properties.Caption = "Opciones de Conexión"
        ' changing the row style 
        rowCat.Appearance.BackColor = Color.Yellow
        rowCat.Appearance.BackColor2 = Color.Gold
        rowCat.Appearance.Font = New Font("Tahoma", 10, FontStyle.Bold)
        Dim Row As New EditorRow
        rowCat.ChildRows.Add(Row)
        Row.Name = "servidor"
        Row.Appearance.BackColor = Color.AliceBlue
        Row.Appearance.BackColor2 = Color.Yellow
        Row.Properties.Value = Dll.RegistroSAMIT.Servidor



        Row.Properties.ReadOnly = False
        Row.Properties.Caption = "SERVIDOR"
        Row.Properties.RowEdit = Grid.RepositoryItems.Item(0)
        Row = New EditorRow("Empresa")
        rowCat.ChildRows.Add(Row)
        Row.Name = "Empresa"
        Row.Appearance.BackColor = Color.YellowGreen
        Row.Appearance.BackColor2 = Color.Yellow
        Row.Properties.Value = Dll.RegistroSAMIT.Empresa_Ingreso
        Row.Properties.ReadOnly = False
        Row.Properties.Caption = "EMPRESA"
        Row.Properties.Format.FormatType = FormatType.Numeric
        Row.Properties.Format.FormatString = "c0"

        Row = New EditorRow("Oficina")
        rowCat.ChildRows.Add(Row)
        Row.Name = "Oficina"
        Row.Appearance.BackColor = Color.FromArgb(227, 240, 255)
        Row.Appearance.BackColor2 = Color.Yellow
        Row.Properties.Value = Dll.RegistroSAMIT.Oficina_Ingreso
        Row.Properties.ReadOnly = False
        Row.Properties.Caption = "OFICINA"

        Row = New EditorRow("ImprimeLogo")
        rowCat.ChildRows.Add(Row)
        Row.Name = "ImprimeLogo"
        Row.Appearance.BackColor = Color.FromArgb(227, 240, 255)
        Row.Appearance.BackColor2 = Color.Yellow
        Row.Properties.Value = IIf(Dll.RegistroSAMIT.Imprime_Logo = "1", True, False)
        Row.Properties.ReadOnly = False
        Row.Properties.Caption = "IMPRIME_LOGO"
        Row.Properties.RowEdit = Grid.RepositoryItems.Item(1)

        Row = New EditorRow("RutaInformes")
        rowCat.ChildRows.Add(Row)
        Row.Name = "RutaInformes"
        Row.Appearance.BackColor = Color.FromArgb(227, 240, 255)
        Row.Appearance.BackColor2 = Color.Yellow
        Row.Properties.Value = Dll.RegistroSAMIT.Ruta_Informes
        Row.Properties.ReadOnly = False
        Row.Properties.Caption = "RUTA INFORMES"
        Row.Properties.RowEdit = Grid.RepositoryItems.Item(0)

        rowCat = New CategoryRow
        Grid.Rows.Add(rowCat)
        ' modifying the height 
        rowCat.Height = 20
        rowCat.Name = "INVENTARIO"

        rowCat.Properties.Caption = "Opciones de Inventario"
        ' changing the row style 
        rowCat.Appearance.BackColor = Color.Aquamarine
        'rowCat.Appearance.BackColor2 = Color.Aquamarine
        rowCat.Appearance.Font = New Font("Tahoma", 10, FontStyle.Bold)
        Dim RowInv As New EditorRow
        RowInv = New EditorRow("PuertoPos")
        rowCat.ChildRows.Add(RowInv)
        RowInv.Name = "PuertoPos"
        RowInv.Appearance.BackColor = Color.Aquamarine
        RowInv.Appearance.BackColor2 = Color.Aquamarine
        RowInv.Properties.Value = Dll.RegistroSAMIT.Puerto_Pos
        RowInv.Properties.ReadOnly = False
        RowInv.Properties.Caption = "PuertoPos"
        RowInv.Properties.RowEdit = Grid.RepositoryItems.Item(2)
        Dim Tbpos As New DataTable
        Tbpos.Columns.Add("Puerto")
        Tbpos.Rows.Add("LPT1:")
        Tbpos.Rows.Add("LPT2:")
        Tbpos.Rows.Add("LPT3:")
        Tbpos.Rows.Add("LPT4:")
        LookUpEdit.DataSource = Tbpos
        LookUpEdit.DisplayMember = "Puerto"
        LookUpEdit.ValueMember = "Puerto"

        RowInv = New EditorRow("ImpPosTermica")
        rowCat.ChildRows.Add(RowInv)
        RowInv.Name = "ImpPosTermica"
        RowInv.Appearance.BackColor = Color.Aquamarine
        RowInv.Appearance.BackColor2 = Color.Aquamarine
        RowInv.Properties.Value = IIf(ClregistroSamit.Inventario.ImpPosTermica = 1, True, False)
        RowInv.Properties.ReadOnly = False
        RowInv.Properties.Caption = "ImpPosTermica"
        RowInv.Properties.RowEdit = Grid.RepositoryItems.Item(1)

        RowInv = New EditorRow("NombrePosTermica")
        rowCat.ChildRows.Add(RowInv)
        RowInv.Name = "NombrePosTermica"
        RowInv.Appearance.BackColor = Color.Aquamarine
        RowInv.Appearance.BackColor2 = Color.Aquamarine
        RowInv.Properties.Value = IIf(ClregistroSamit.Inventario.ImpPosTermica = 1, True, False)
        RowInv.Properties.ReadOnly = False
        RowInv.Properties.Caption = "NombrePosTermica"
        RowInv.Properties.RowEdit = Grid.RepositoryItems.Item(3)
        Dim TbImp As New DataTable
        TbImp.Columns.Add("Impresora")
        For Each VLprinter As String In System.Drawing.Printing.PrinterSettings.InstalledPrinters
            TbImp.Rows.Add(VLprinter)
        Next
        CmbImpresora.DataSource = TbImp
        CmbImpresora.DisplayMember = "Impresora"
        CmbImpresora.ValueMember = "Impresora"
        RowInv.Properties.Value = ClregistroSamit.Inventario.NombrePosTermica

        rowCat = New CategoryRow
        Grid.Rows.Add(rowCat)
        ' modifying the height 
        rowCat.Height = 20
        rowCat.Name = "Parquedero"
        rowCat.Properties.Caption = "Opciones de Parqueadero"
        ' changing the row style 
        rowCat.Appearance.BackColor = Color.Aquamarine
        'rowCat.Appearance.BackColor2 = Color.Aquamarine
        rowCat.Appearance.Font = New Font("Tahoma", 10, FontStyle.Bold)
        Dim RowPQ As New EditorRow
        RowPQ = New EditorRow("Habilita Vista Previa")
        rowCat.ChildRows.Add(RowPQ)
        RowPQ.Name = "VistaPrevia"
        RowPQ.Appearance.BackColor = Color.Aquamarine
        RowPQ.Appearance.BackColor2 = Color.Aquamarine
        RowPQ.Properties.Value = IIf(Dll.RegistroSAMIT.PQ_VistaPrevia = "1", True, False)
        RowPQ.Properties.ReadOnly = False
        RowPQ.Properties.Caption = "Habilita Vista Previa"
        'RowPQ.Properties.RowEdit = Grid.RepositoryItems.Item(4)
        Dim Item As RepositoryItemLookUpEdit = New RepositoryItemLookUpEdit
        Item.Name = "PQpapel"
        Grid.RepositoryItems.Add(Item)
        Dim RowPQPapel As New EditorRow
        RowPQPapel = New EditorRow("Tamaño Papel")
        rowCat.ChildRows.Add(RowPQPapel)
        RowPQPapel.Name = "Papelpos"
        RowPQPapel.Appearance.BackColor = Color.Aquamarine
        RowPQPapel.Appearance.BackColor2 = Color.Aquamarine
        RowPQPapel.Properties.Value = IIf(Dll.RegistroSAMIT.PQ_TamañoPapel = "0", "Tamaño Pequeño 58 mm", "Tamaño Grande 75 mm")
        RowPQPapel.Properties.ReadOnly = False
        RowPQPapel.Properties.Caption = "Tamaño Papel Impr. Pos"
        RowPQPapel.Properties.RowEdit = Grid.RepositoryItems.Item("PQpapel")
        Dim Tbpapel As New DataTable
        Tbpapel.Columns.Add("Papel")
        Tbpapel.Rows.Add("Tamaño Pequeño 58 mm")
        Tbpapel.Rows.Add("Tamaño Grande 75 mm")
        Item.DataSource = Tbpapel
        Item.DisplayMember = "Papel"
        Item.ValueMember = "Papel"
        AddHandler Item.EditValueChanged, AddressOf Cambio_Papel_PQ
    End Sub
    Private Sub Cambio_Papel_PQ()
        Dim Valor As String = "1"
        If Grid.EditingValue = "Tamaño Pequeño 58 mm" Then
            Valor = "0"
        End If
        Dll.RegistroSAMIT.PQ_TamañoPapel = Valor
    End Sub
    Private Sub BotonSalir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BotonSalir.ItemClick
        Me.Close()
    End Sub

    Private Sub ButtonEdit_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles ButtonEdit.ButtonClick
        Dim Frm As New FrmServidores

        Select Case Grid.FocusedRow.Name.ToUpper
            Case "SERVIDOR"
                Try
                    Frm.ShowDialog()
                    If Frm.SrvSeleccionado <> "" Then
                        Grid.EditingValue = Frm.SrvSeleccionado
                        Dll.RegistroSAMIT.Servidor = Frm.SrvSeleccionado

                    End If
                    Frm.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Case "RUTAINFORMES"
                If BuscarRuta.ShowDialog = Windows.Forms.DialogResult.OK Then
                    'MsgBox(BuscarRuta.SelectedPath)
                    Grid.EditingValue = BuscarRuta.SelectedPath
                    Dll.RegistroSAMIT.Ruta_Informes = BuscarRuta.SelectedPath

                End If
        End Select
    End Sub

    Private Sub LookUpEdit_EditValueChanged(sender As Object, e As EventArgs) Handles LookUpEdit.EditValueChanged
        Select Case Grid.FocusedRow.Name.ToUpper
            Case "PUERTOPOS"
                'Grid.FocusedRow.Properties.Value = LookUpEdit.EditValue
                Dll.RegistroSAMIT.Puerto_Pos = Grid.EditingValue
        End Select
    End Sub

    Private Sub Grid_CellValueChanged(sender As Object, e As Events.CellValueChangedEventArgs) Handles Grid.CellValueChanged

    End Sub

    Private Sub ChkEdit_CheckedChanged(sender As Object, e As EventArgs) Handles ChkEdit.CheckedChanged
        Select Case Grid.FocusedRow.Name.ToUpper
            Case "IMPPOSTERMICA"
                'MsgBox(Grid.EditingValue)
                ClregistroSamit.Inventario.ImpPosTermica = IIf(Grid.EditingValue, "1", "0")
            Case "IMPRIMELOGO"
                Dll.RegistroSAMIT.Imprime_Logo = IIf(Grid.EditingValue, "1", "0")
        End Select
    End Sub

    Private Sub CmbImpresora_EditValueChanged(sender As Object, e As EventArgs) Handles CmbImpresora.EditValueChanged
        ClregistroSamit.Inventario.NombrePosTermica = Grid.EditingValue
    End Sub
End Class