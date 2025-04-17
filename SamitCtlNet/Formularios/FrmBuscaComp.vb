Option Explicit On
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Public Class FrmBuscaComp
    Public TipoPredeterminado As String, Ofic As Byte = 0, Todas As Boolean, TotalReg As Integer
    Public Cancel As Boolean, Tipos As String, IdTipoS As Byte, NomIdS As String
    Public FormatoDocumento As ClFunciones.TiposdeDocumentos, Indico_un_TipoEspecifico As Boolean, EstadoMuestra As String
    Public Property Total_Registros_Consultados() As Integer
        Get
            Total_Registros_Consultados = TotalReg
        End Get
        Set(value As Integer)

        End Set
    End Property
    Public Property Cancelo() As Boolean
        Get
            Cancelo = Cancel
        End Get
        Set(value As Boolean)

        End Set
    End Property
    Public Property TipoSeleccionado() As String
        Get
            TipoSeleccionado = Tipos
        End Get
        Set(value As String)

        End Set
    End Property
    Public Property Nom_IdComp_Seleccionado() As String
        Get
            Nom_IdComp_Seleccionado = NomIdS
        End Get
        Set(value As String)

        End Set
    End Property
    Public Property IdComp_Seleccionado() As Byte
        Get
            IdComp_Seleccionado = IdTipoS
        End Get
        Set(value As Byte)

        End Set
    End Property


    Public Property FormatoAsignado() As ClFunciones.TiposdeDocumentos
        Get
            FormatoAsignado = FormatoDocumento
        End Get
        Set(value As ClFunciones.TiposdeDocumentos)
            Indico_un_TipoEspecifico = True
            FormatoDocumento = value
        End Set
    End Property
    Public Property Oficina As Byte
        Get
            Oficina = Ofic

        End Get
        Set(value As Byte)
            Ofic = value
            If Ofic = VgOficina Then
                TxtOficina.Text = DatosEmp.OficinaIngreso.NumOficina
                LblDescOficina.Text = DatosEmp.OficinaIngreso.NombreOficina
            ElseIf Ofic = 0 Then
                TxtOficina.Text = "T"
                LblDescOficina.Text = "Todas las Oficinas"
            ElseIf Ofic > 0 Then
                TxtOficina.Text = Ofic.ToString
                LblDescOficina.Text = Nombre_Oficina(Ofic)
            End If

        End Set
    End Property
    Public Property Estado_Mostrar As String
        Get
            Estado_Mostrar = EstadoMuestra
        End Get
        Set(value As String)
            EstadoMuestra = value
        End Set
    End Property
    Public Property TipoComprobante() As String
        Get
            TipoComprobante = TipoPredeterminado
        End Get
        Set(value As String)
            If ExisteTipoComp(value) Then TipoPredeterminado = value
        End Set
    End Property
    Public Property Todas_Las_Oficinas() As Boolean
        Get
            Todas_Las_Oficinas = Todas
        End Get
        Set(value As Boolean)
            Todas = value
        End Set
    End Property

    Private Sub MapearDataGrid(ByRef Grid As DataGridView)
        Grid.AutoGenerateColumns = False
        Grid.AllowUserToAddRows = False
        Grid.RowHeadersVisible = False

        Agregar_Columna_DataGridView(Grid, "TipoComp", "Tipo", 50, GetType(System.Int32), DataGridViewContentAlignment.MiddleCenter, , , DataGridViewAutoSizeColumnMode.ColumnHeader)
        Agregar_Columna_DataGridView(Grid, "IdComp", "Codigo", 50, GetType(System.Int32), DataGridViewContentAlignment.MiddleCenter, , , DataGridViewAutoSizeColumnMode.ColumnHeader)
        Agregar_Columna_DataGridView(Grid, "DesComp", "Nombre", 330, GetType(System.String), DataGridViewContentAlignment.MiddleLeft, , , DataGridViewAutoSizeColumnMode.None)
        Agregar_Columna_DataGridView(Grid, "Estado", "Estado", 100, GetType(System.String), DataGridViewContentAlignment.MiddleCenter, , , DataGridViewAutoSizeColumnMode.Fill)

    End Sub
    Private Sub Agregar_Columna_DataGridView(ByRef Grid As DataGridView, NombreColumna As String, TituloColumna As String, AnchoColumna As Integer, TipoDato As System.Type, _
                                             AlineacionContenido As System.Windows.Forms.DataGridViewContentAlignment, Optional SoloLectura As Boolean = True, Optional Visible As Boolean = True, Optional AnchoAuto As System.Windows.Forms.DataGridViewAutoSizeColumnMode = DataGridViewAutoSizeColumnMode.None)

        Dim Columna = New DataGridViewColumn, Celda As New DataGridViewTextBoxCell
        Try
            With Columna
                .CellTemplate = Celda
                .HeaderText = TituloColumna
                .Name = NombreColumna
                .DataPropertyName = NombreColumna
                .Width = AnchoColumna
                .ReadOnly = SoloLectura
                .ValueType = TipoDato
                .Visible = Visible
                .AutoSizeMode = AnchoAuto
                .DefaultCellStyle.Alignment = AlineacionContenido
            End With

            Grid.Columns.Add(Columna)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
    Public Sub Cargar_Comprobantes()
        Dim TxtSQL As String = "", R As New DataTable
        TxtSQL = "SELECT TipoComp, IdComp, OfiComp,DesComp, Estado From Ct_Comprobantes INNER JOIN CT_ComTipo ON idTC = TipoComp   " & _
                 IIf(EstadoMuestra <> "", "Where Estado = '" & EstadoMuestra & "' ", "Where Estado Like '%'")
        If Not Todas Then
            TxtSQL = TxtSQL & " AND OfiComp=" & Ofic & " "
        End If
        If TipoPredeterminado <> "" Then
            TxtSQL = TxtSQL & " AND TipoComp = '" & TipoPredeterminado & "'"
        End If
        If Indico_un_TipoEspecifico Then
            TxtSQL = TxtSQL & " AND NumFormato = " & FormatoDocumento
        End If
        R = SMT_AbrirRecordSet(SMTConexMod, TxtSQL)
        If R.Rows.Count > 0 Then
            TotalReg = R.Rows.Count
            MapearDataGrid(GridComp)
            GridComp.DataSource = R
        End If
        R.Dispose()
        R = Nothing
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()

    End Sub

    Private Sub FrmBuscaComp_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        GridComp.Focus()
    End Sub

    Private Sub FrmBuscaComp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BtnEscoger.Image = Global.SamitCtlNet.My.Resources.Resources.Apply_32x32
        Me.BtnSalir.Image = Global.SamitCtlNet.My.Resources.Resources.Cancel_32x32
    End Sub

    Private Sub BtnEscoger_Click(sender As Object, e As EventArgs) Handles BtnEscoger.Click
        On Error Resume Next
        Cancel = False
        If GridComp.SelectedRows.Count > 0 Then
            With GridComp
                Tipos = .Rows(.CurrentCell.RowIndex).Cells(0).Value
                IdTipoS = .Rows(.CurrentCell.RowIndex).Cells(1).Value
                NomIdS = .Rows(.CurrentCell.RowIndex).Cells(2).Value
            End With
        Else
            Cancel = True
        End If
        Me.Hide()
    End Sub

    Private Sub GridComp_DoubleClick(sender As Object, e As EventArgs) Handles GridComp.DoubleClick
        BtnEscoger.PerformClick()

    End Sub

    Private Sub GridComp_KeyDown(sender As Object, e As KeyEventArgs) Handles GridComp.KeyDown
        On Error Resume Next
        Select Case e.KeyCode
            Case Keys.Enter
                BtnEscoger.PerformClick()
            Case Keys.Escape
                BtnSalir.PerformClick()
        End Select
    End Sub
End Class