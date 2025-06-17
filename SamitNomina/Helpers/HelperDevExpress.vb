Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports SamitNomina.HelperNomina
Imports SamitCtlNet
Imports System.Data.SqlClient

Public Class HelperDevExpress


    Public Memo As New RepositoryItemMemoExEdit
    Dim FormError As XtraForm

    Public Sub MensagedeError(Mensaje As String, Optional Titulo As String = "")
        XtraMessageBox.Show(Mensaje, CType(IIf(Titulo <> "", Titulo, "Mensaje de SAMIT SQL"), String), MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    '---------------------------------------------------------------------------------------------------
    Public Sub msgError(ex As Exception, Exepcion As String, Ubicación As String)
        Dim frm As New XtraForm
        Dim lblTitleError As LabelControl = New LabelControl()
        Dim lblUbicacion As LabelControl = New LabelControl()
        Dim btnAceptar As SimpleButton = New SimpleButton()
        Dim txtError As MemoEdit = New MemoEdit()
        Dim SeparatorControl1 As SeparatorControl = New SeparatorControl()
        Dim pcbIcon As PictureEdit = New PictureEdit()
        Dim trace = New System.Diagnostics.StackTrace(ex, True)
        Dim line As String = Microsoft.VisualBasic.Right(trace.ToString, 6)
        If Not IsNumeric(line) Then line = "Overload errors :("
        lblTitleError.Appearance.Font = New Font("Tahoma", 10.0!, FontStyle.Bold)
        lblTitleError.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        lblTitleError.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        lblTitleError.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        lblTitleError.Location = New Point(85, 7)
        lblTitleError.Name = "lblTitleError"
        lblTitleError.Size = New Size(55, 26)
        lblTitleError.TabIndex = 0
        lblTitleError.Text = "Error :"

        'lblUbicacion
        lblUbicacion.Anchor = CType(((AnchorStyles.Bottom Or AnchorStyles.Left) _
            Or AnchorStyles.Right), AnchorStyles)
        lblUbicacion.Appearance.Font = New Font("Consolas", 9.0!, FontStyle.Regular)
        lblUbicacion.AutoSizeMode = LabelAutoSizeMode.None
        lblUbicacion.BorderStyle = BorderStyles.NoBorder
        lblUbicacion.Location = New Point(62, 68)
        lblUbicacion.Padding = New Padding(2)
        lblUbicacion.Size = New Size(429, 22)
        lblUbicacion.Text = String.Format("Ubicación : {0}  Linea : {1}", Ubicación, line)

        'btnAceptar
        btnAceptar.Anchor = CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles)
        btnAceptar.Appearance.Font = New Font("Consolas", 8.25!, FontStyle.Regular)
        btnAceptar.Appearance.Options.UseFont = True
        btnAceptar.Location = New Point(400, 86)
        btnAceptar.Size = New Size(84, 27)
        btnAceptar.Text = "Aceptar"
        btnAceptar.TabIndex = 1

        'txtError
        txtError.Anchor = CType((((AnchorStyles.Top Or AnchorStyles.Bottom) _
            Or AnchorStyles.Left) _
            Or AnchorStyles.Right), AnchorStyles)
        txtError.Location = New Point(146, 14)
        txtError.Properties.Appearance.BackColor = ColorTranslator.FromHtml("#EBECEF")
        txtError.Properties.Appearance.Font = New Font("Consolas", 8.25!, FontStyle.Regular)
        txtError.Properties.Appearance.Options.UseBackColor = True
        txtError.Properties.Appearance.Options.UseFont = True
        txtError.Properties.BorderStyle = BorderStyles.NoBorder
        txtError.Properties.ReadOnly = True
        txtError.Size = New Size(345, 44)
        txtError.Text = Exepcion

        'SeparatorControl1
        SeparatorControl1.Anchor = CType(((AnchorStyles.Bottom Or AnchorStyles.Left) _
            Or AnchorStyles.Right), AnchorStyles)
        SeparatorControl1.Location = New Point(6, 67)
        SeparatorControl1.Padding = New Padding(0)
        SeparatorControl1.Size = New Size(485, 3)
        SeparatorControl1.TabStop = False

        'pcbIcon
        pcbIcon.Location = New Point(12, 14)
        pcbIcon.Properties.Appearance.BackColor = Color.Transparent
        pcbIcon.Properties.Appearance.Options.UseBackColor = True
        pcbIcon.Properties.BorderStyle = BorderStyles.NoBorder
        pcbIcon.Properties.ShowCameraMenuItem = CameraMenuItemVisibility.Auto
        pcbIcon.Size = New Size(44, 44)
        pcbIcon.Image = Bitmap.FromHicon(SystemIcons.Error.Handle)

        'msgError
        frm.ClientSize = New Size(496, 127)
        frm.Controls.Add(pcbIcon)
        frm.Controls.Add(SeparatorControl1)
        frm.Controls.Add(txtError)
        frm.Controls.Add(btnAceptar)
        frm.Controls.Add(lblUbicacion)
        frm.Controls.Add(lblTitleError)
        frm.MinimizeBox = False
        frm.ShowIcon = False
        frm.MinimumSize = New Size(504, 135)
        frm.Name = "msgError"
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.Text = "Mensaje SAMIT SQL :("
        AddHandler btnAceptar.Click, AddressOf btnAceptar_Click
        FormError = frm
        frm.ShowDialog()
    End Sub

    Public Sub LlenaLkeConDt(cbx As LookUpEdit, sql As String, DisplayM As String, ValueM As String)
        Try
            Dim dt As New DataTable
            dt = SMT_AbrirTabla(ObjetoApiNomina, sql)
            If dt.Rows.Count > 0 Then
                With cbx
                    .Properties.DataSource = dt
                    .Properties.DisplayMember = DisplayM ' Determinar el texto que aparecera
                    .Properties.ValueMember = ValueM ' Determinar el codigo que tiene cada opcion del cbx
                    .Properties.PopulateColumns()
                    .Properties.Columns(0).Visible = False
                    .ItemIndex = 0
                End With
                If dt.Rows.Count < 10 Then cbx.Properties.DropDownRows = dt.Rows.Count
            End If

        Catch ex As Exception
            'msgError(ex, ex.Message, " Llenando lookUpEdit-->Function")
        End Try
    End Sub

    Public Sub Cargalke(CodMuni As String, ByRef lkeDpto As LookUpEdit, ByRef lkePais As LookUpEdit)
        Try
            Dim sql As String
            Dim dt As DataTable
            Dim DepNac, PaisNac As DataRow
            sql = String.Format("SELECT MN.Departamento as Codigo FROM G_Municipio MN WHERE MN.IdMunicipio={0}", CodMuni)
            dt = SMT_AbrirTabla(ObjetoApiNomina, sql)
            If dt.Rows.Count > 0 Then
                DepNac = dt.Rows(0)
                sql = String.Format("SELECT TOP 1 DP.Pais as Codigo FROM G_Departamento DP WHERE DP.Sec={0}", DepNac(0).ToString)
                dt = SMT_AbrirTabla(ObjetoApiNomina, sql)
                If dt.Rows.Count > 0 Then
                    PaisNac = dt.Rows(0)
                    lkePais.EditValue = AsignarCampo(PaisNac, "Codigo")
                    lkeDpto.EditValue = AsignarCampo(DepNac, "Codigo")
                End If
            Else
                lkePais.ItemIndex = 0
                lkeDpto.ItemIndex = 0
            End If

        Catch ex As Exception
            msgError(ex, ex.Message, "CargaMesYaño")
        End Try
    End Sub
    Public Function TraeDepartamentoConMunicipio(CodMuni As String, CodigoTrueNombreFalse As Boolean) As String
        Try
            Dim sql As String
            If CodigoTrueNombreFalse Then
                sql = String.Format("SELECT MN.Departamento FROM G_Municipio MN WHERE MN.IdMunicipio={0}", CodMuni)
            Else
                sql = String.Format("SELECT DP.NomDpto FROM G_Municipio MN " &
                                    " INNER JOIN G_Departamento DP ON DP.CodDpto=MN.Departamento" &
                                    " WHERE MN.IdMunicipio={0}", CodMuni)
            End If

            Dim dt = SMT_AbrirTabla(ObjetoApiNomina, sql)
            If dt.Rows.Count > 0 Then
                Return dt.Rows(0)(0).ToString
            Else
                Return ""
            End If
        Catch ex As Exception
            msgError(ex, ex.Message, "TraeDepartamentoConMunicipio")
            Return ""
        End Try
    End Function
    Public Function TraePaisConDepartamento(CodDep As String, CodigoTrueNombreFalse As Boolean) As String
        Try
            Dim sql As String
            If CodigoTrueNombreFalse Then
                sql = String.Format("SELECT TOP 1 DP.Pais FROM G_Departamento DP WHERE DP.CodDpto={0}", CodDep)
            Else
                sql = String.Format("SELECT TOP 1 PS.NomPais FROM G_Departamento DP" &
                                    " INNER JOIN G_Pais PS ON PS.CodPais= DP.Pais" &
                                    " WHERE DP.CodDpto={0}", CodDep)
            End If

            Dim dt = SMT_AbrirTabla(ObjetoApiNomina, sql)
            If dt.Rows.Count > 0 Then
                Return dt.Rows(0)(0).ToString
            Else
                Return ""
            End If
        Catch ex As Exception
            msgError(ex, ex.Message, "TraePaisConDepartamento")
            Return ""
        End Try
    End Function

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs)
        FormError.Close()
    End Sub
    '--------------------------------------------------------------------------------------------------------
    Public Function MsgSamit(Mensaje As String, Botones As MessageBoxButtons, Icono As MessageBoxIcon,
                             Optional Titulo As String = "") As DialogResult
        MsgSamit = XtraMessageBox.Show(Mensaje, CType(IIf(Titulo <> "", Titulo, "Mensaje de SAMIT SQL"), String),
                                       Botones, Icono)
    End Function

    '---------------------------------------------------------------------------------------------------------
    Public Sub mensajeExitoso(Mensaje As String, Optional Titulo As String = "")
        XtraMessageBox.Show(Mensaje, CType(IIf(Titulo <> "", Titulo, "Mensaje de SAMIT SQL"), String), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    '----------------------------------------------------------------------------------------------------------
    Public Sub EntraControlDev(Optional txt As TextEdit = Nothing, Optional lbl As LabelControl = Nothing, Optional memo As MemoEdit = Nothing)
        If IsNothing(txt) = False Then
            txt.BackColor = ColorTranslator.FromHtml("#B9FFF9")
            Dim fuente As Single = txt.Font.Size
            txt.Font = New Font("Tahoma", fuente, System.Drawing.FontStyle.Bold)
            txt.ForeColor = Color.Maroon
            txt.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
            txt.Properties.Appearance.BorderColor = Color.Black
            txt.Properties.Appearance.Options.UseBorderColor = True
            txt.SelectAll()
        End If

        If IsNothing(lbl) = False Then
            Dim fuente As Single = lbl.Font.Size
            lbl.Font = New Font("Tahoma", fuente, System.Drawing.FontStyle.Bold)
        End If
        If Not IsNothing(memo) Then
            memo.BackColor = ColorTranslator.FromHtml("#B9FFF9")
            Dim fuente As Single = memo.Font.Size
            memo.Font = New Font("Tahoma", fuente, System.Drawing.FontStyle.Bold)
            memo.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
            memo.ForeColor = Color.Maroon
            memo.Properties.Appearance.BorderColor = Color.Black
            memo.Properties.Appearance.Options.UseBorderColor = True
            memo.SelectAll()
        End If
    End Sub

    '----------------------------------------------------------------------------------------------------------
    Public Sub SaleControlDev(Optional txt As TextEdit = Nothing, Optional lbl As LabelControl = Nothing, Optional memo As MemoEdit = Nothing)
        Try

            If IsNothing(txt) = False Then
                txt.BackColor = Color.White
                Dim fuente As Single = txt.Font.Size
                txt.Font = New Font("Tahoma", fuente, System.Drawing.FontStyle.Regular)
                txt.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default
                txt.ForeColor = Color.FromArgb(&H23, &H22, &H2D)
                txt.Properties.Appearance.BorderColor = Color.White
                txt.Properties.Appearance.Options.UseBorderColor = False
            End If

            If IsNothing(lbl) = False Then
                Dim fuente As Single = lbl.Font.Size
                lbl.Font = New Font("Tahoma", fuente, System.Drawing.FontStyle.Regular)
            End If
            If Not IsNothing(memo) Then
                memo.BackColor = Color.White
                Dim fuente As Single = memo.Font.Size
                memo.Font = New Font("Tahoma", fuente, System.Drawing.FontStyle.Regular)
                memo.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default
                memo.ForeColor = Color.FromArgb(&H23, &H22, &H2D)
                memo.Properties.Appearance.BorderColor = Color.White
                memo.Properties.Appearance.Options.UseBorderColor = False
            End If

        Catch ex As Exception
            msgError(ex, ex.Message, "SaleControlDev")
        End Try
    End Sub
    '---------------------------------------------------------------------------------------------------------
    Public Sub CreaColumnasG(Grid As GridView, Nombre As String, Titulo As String, Visible As Boolean, Editar As Boolean, formula As String, colores As System.Drawing.Color, numerico As Boolean,
                              Moneda As Boolean, Porcentaje_Width As Single, TamañoPadre As Single, Optional Alineacion As DevExpress.Utils.HorzAlignment = DevExpress.Utils.HorzAlignment.Near, Optional TituloGrid As Boolean = False, Optional TextCaption As String = "", Optional EsImagen As Boolean = False, Optional GridCont As GridControl = Nothing, Optional EsFecha As Boolean = False, Optional FormatoFecha As String = "dd/MM/yyyy", Optional FormatoNumero As String = "n0", Optional FormatoMoneda As String = "c2", Optional WidthFijo As Boolean = False, Optional colorFocusFila As System.Drawing.Color = Nothing, Optional ColorLetraFocus As System.Drawing.Color = Nothing, Optional UsaColorFilaFocus As Boolean = False, Optional Combo As RepositoryItemLookUpEdit = Nothing, Optional PermiteFiltro As Boolean = False, Optional UsaColorColumna As Boolean = True, Optional isfixed As Boolean = False, Optional PermiteOrdenar As Boolean = False, Optional ComboBusq As RepositoryItemSearchLookUpEdit = Nothing)
        Dim ImgGrid As New RepositoryItemPictureEdit
        If EsImagen Then
            ImgGrid = TryCast(GridCont.RepositoryItems.Add("PictureEdit"), RepositoryItemPictureEdit)
            ImgGrid.SizeMode = PictureSizeMode.Zoom
            ImgGrid.NullText = " "
        End If
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
                .DisplayFormat.FormatString = FormatoNumero
            End If
            If Moneda Then
                .UnboundType = DevExpress.Data.UnboundColumnType.Decimal
                .DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                .DisplayFormat.FormatString = FormatoMoneda
                '.UnboundType = DevExpress.Data.UnboundColumnType.Decimal
                '.DisplayFormat.FormatString = VGFormatoMoneda
                .AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default
            End If
            If EsFecha Then
                .UnboundType = DevExpress.Data.UnboundColumnType.DateTime
                .DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
                .DisplayFormat.FormatString = FormatoFecha
            End If
            If WidthFijo Then
                .Width = CInt(Porcentaje_Width)
            Else
                If Porcentaje_Width > 0 Then
                    .Width = CInt((Porcentaje_Width * (TamañoPadre - 20)) / 100)
                End If
            End If
            .AppearanceCell.Options.UseBackColor = True
            .AppearanceCell.BackColor = colores
            .OptionsColumn.AllowSize = True
            .OptionsColumn.AllowMove = True
            If Editar Then
                .OptionsColumn.AllowEdit = True
                .OptionsColumn.AllowFocus = True

            Else
                .OptionsColumn.AllowEdit = False
                .OptionsColumn.AllowFocus = False
            End If
            '.AppearanceCell.TextOptions.HAlignment = Alineacion
            .OptionsFilter.AllowFilter = False
            .Visible = Visible
            .AppearanceHeader.Options.UseTextOptions = True
            .AppearanceHeader.TextOptions.HAlignment = Alineacion
            .AppearanceCell.Options.UseTextOptions = True
            If EsImagen Then
                .ColumnEdit = ImgGrid
            End If
            If Not IsNothing(Combo) Then
                .ColumnEdit = Combo
            End If
            If Not IsNothing(ComboBusq) Then
                .ColumnEdit = ComboBusq
            End If
            If isfixed Then
                .Fixed = Columns.FixedStyle.Left
            End If
            If PermiteFiltro Then
                .OptionsFilter.AllowFilter = True
            End If
            If PermiteOrdenar Then
                .OptionsColumn.AllowSort = DefaultBoolean.True
            End If
        End With
        Grid.OptionsView.ShowGroupPanel = False
        Grid.OptionsCustomization.AllowSort = False

        Grid.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.CellFocus
        Grid.Appearance.Row.Font = New Font("Tahoma", 10.6, System.Drawing.FontStyle.Regular)
        Grid.Columns.Add(gc)
        If TituloGrid Then
            Grid.ViewCaption = TextCaption
            Grid.OptionsView.ShowViewCaption = True
            Dim dFont = Grid.Appearance.ViewCaption.Font
            Grid.Appearance.ViewCaption.Font = New Font(dFont.FontFamily, 14)
        End If
        If EsImagen Then
            GridCont.RepositoryItems.Add(ImgGrid)
        End If
        If WidthFijo Then
            Grid.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto
            Grid.OptionsView.ColumnAutoWidth = False
        End If

    End Sub

    '----------------------------------------------------------------------------------------------------------
    Public Sub EntraControlDateEditDEV(dte As DateEdit, Optional lbl As LabelControl = Nothing)
        Try

            dte.BackColor = ColorTranslator.FromHtml("#B9FFF9")
            dte.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
            dte.Properties.Appearance.BorderColor = Color.Black
            If IsNothing(lbl) = False Then
                lbl.Font = New Font(lbl.Font.FontFamily, lbl.Font.Size, System.Drawing.FontStyle.Bold)
            End If

        Catch ex As Exception

        End Try
    End Sub

    '-------------------------------------------------------------------------------------------------------------
    Public Sub SaleControlDateEditDEV(dte As DateEdit, Optional lbl As LabelControl = Nothing)
        dte.BackColor = Color.White
        dte.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default
        dte.Properties.Appearance.BorderColor = Color.White
        If IsNothing(lbl) = False Then
            Dim fuente As Single = lbl.Font.Size
            lbl.Font = New Font(lbl.Font.FontFamily, lbl.Font.Size, System.Drawing.FontStyle.Regular)
        End If
    End Sub
    '-------------------------------------------------------------------------------------------------------------
    Public Sub EntraControlCbxDEV(cbx As ComboBoxEdit, Optional lbl As LabelControl = Nothing)
        cbx.BackColor = ColorTranslator.FromHtml("#B9FFF9")
        Dim fuente As Single = cbx.Font.Size
        cbx.Font = New Font("Tahoma", fuente, System.Drawing.FontStyle.Bold)
        cbx.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        cbx.Properties.Appearance.BorderColor = Color.Black
        cbx.ForeColor = Color.Black
        cbx.SelectionLength = cbx.Text.Length
        cbx.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        If IsNothing(lbl) = False Then
            Dim fuente2 As Single = lbl.Font.Size
            lbl.Font = New Font("Tahoma", fuente2, System.Drawing.FontStyle.Bold)
        End If
    End Sub
    '-------------------------------------------------------------------------------------------------------------
    Public Sub SaleControlCbxDEV(cbx As ComboBoxEdit, Optional lbl As LabelControl = Nothing)
        cbx.BackColor = Color.White
        Dim fuente As Single = cbx.Font.Size
        cbx.Font = New Font("Tahoma", fuente, System.Drawing.FontStyle.Regular)
        cbx.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default
        cbx.Properties.Appearance.BorderColor = Color.White
        cbx.ForeColor = Color.Black
        If IsNothing(lbl) = False Then
            Dim fuente2 As Single = lbl.Font.Size
            lbl.Font = New Font("Tahoma", fuente2, System.Drawing.FontStyle.Regular)
        End If
    End Sub
    '-------------------------------------------------------------------------------------------------------------
    Public Function ValidaDobleClicSobreFila(ByVal view As GridView) As String
        Try
            Dim pt As Point = view.GridControl.PointToClient(Control.MousePosition)
            Dim info As GridHitInfo = view.CalcHitInfo(pt)
            If info.InRow OrElse info.InRowCell Then
                Return info.RowHandle.ToString()
            Else
                Return ""
            End If

        Catch ex As Exception
            msgError(ex, ex.Message, "ValidaDobleClicSobreFila")
            Return ""
        End Try
    End Function
    '-------------------------------------------------------------------------------------------------------
    Public Sub EntraControNumericDownDEV(nd As DevExpress.XtraEditors.SpinEdit, Optional lbl As DevExpress.XtraEditors.LabelControl = Nothing)
        nd.BackColor = ColorTranslator.FromHtml("#B9FFF9")
        Dim fuente As Single = nd.Font.Size
        nd.Font = New Font("Tahoma", fuente, System.Drawing.FontStyle.Bold)
        nd.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        nd.Properties.Appearance.BorderColor = Color.Black
        nd.Properties.Appearance.Options.UseBorderColor = True
        nd.SelectAll()
        If Not lbl Is Nothing Then
            Dim fuente2 As Single = lbl.Font.Size
            lbl.Font = New Font("Tahoma", fuente2, System.Drawing.FontStyle.Bold)
        End If
    End Sub
    '--------------------------------------------------------------------------------------------------------
    Public Sub SaleControlNumercDownDEV(nd As DevExpress.XtraEditors.SpinEdit, Optional lbl As DevExpress.XtraEditors.LabelControl = Nothing)
        nd.BackColor = Color.White
        Dim fuente As Single = nd.Font.Size
        nd.Font = New Font("Tahoma", fuente, System.Drawing.FontStyle.Regular)
        nd.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default
        nd.Properties.Appearance.BorderColor = Color.White
        nd.Properties.Appearance.Options.UseBorderColor = False
        If Not lbl Is Nothing Then
            Dim fuente2 As Single = lbl.Font.Size
            lbl.Font = New Font("Tahoma", fuente2, System.Drawing.FontStyle.Regular)
        End If
    End Sub
    '---------------------------------------------------------------------------------------------------------
    Public Sub EntraControlRadioGroup(ByRef rg As RadioGroup, Optional ByRef lbl As LabelControl = Nothing,
                                    Optional tamañoLetraRG As Single = 10.0F, Optional tamañoLetraLBL As Single = 9.25F)
        Try
            rg.BackColor = ColorTranslator.FromHtml("#B9FFF9")
            rg.Font = New Font("Segoe UI", tamañoLetraRG, System.Drawing.FontStyle.Bold)
            'If Not IsNothing(lbl) Then lbl.Font = New Font("Segoe UI", tamañoLetraLBL, System.Drawing.FontStyle.Bold)
            If Not IsNothing(lbl) Then lbl.Font = New Font(lbl.Font.FontFamily, lbl.Font.Size, System.Drawing.FontStyle.Bold)
        Catch ex As Exception
            msgError(ex, ex.Message, "EntraControlRadioGroup")
        End Try

    End Sub
    '---------------------------------------------------------------------------------------------------------
    Public Sub SaleControlRadioGroup(ByRef rg As RadioGroup, Optional ByRef lbl As LabelControl = Nothing,
                                  Optional tamañoLetraRG As Single = 10.0F, Optional tamañoLetraLBL As Single = 9.25F)
        Try
            rg.BackColor = Color.Transparent
            rg.Font = New Font("Segoe UI", tamañoLetraRG, System.Drawing.FontStyle.Regular)
            'If Not IsNothing(lbl) Then lbl.Font = New Font("Segoe UI", tamañoLetraLBL, System.Drawing.FontStyle.Regular)
            If Not IsNothing(lbl) Then lbl.Font = New Font(lbl.Font.FontFamily, lbl.Font.Size, System.Drawing.FontStyle.Regular)
        Catch ex As Exception
            msgError(ex, ex.Message, "EntraControlRadioGroup")
        End Try

    End Sub
    '----------------------------------------------------------------------------------------------------------
    Public Sub SalirConEsc(e As KeyEventArgs, form As XtraForm)
        If e.KeyCode = Keys.Escape Then
            form.Close()
        End If
    End Sub
    '----------------------------------------------------------------------------------------------------------
    Public Sub EntraControlLkeDEV(cbx As LookUpEdit, Optional lbl As LabelControl = Nothing)
        cbx.BackColor = ColorTranslator.FromHtml("#B9FFF9")
        Dim fuente As Single = cbx.Font.Size
        cbx.Font = New Font("Tahoma", fuente, System.Drawing.FontStyle.Bold)
        cbx.BorderStyle = BorderStyles.HotFlat
        cbx.Properties.Appearance.BorderColor = Color.Black
        cbx.ForeColor = Color.Black
        cbx.SelectionLength = cbx.Text.Length
        cbx.Properties.TextEditStyle = TextEditStyles.DisableTextEditor
        If IsNothing(lbl) = False Then
            Dim fuente2 As Single = lbl.Font.Size
            lbl.Font = New Font("Tahoma", fuente2, System.Drawing.FontStyle.Bold)
        End If
    End Sub
    '--------------------------------------------------------------------------------------------------------
    Public Sub SaleControlLkeDEV(cbx As LookUpEdit, Optional lbl As LabelControl = Nothing)
        cbx.BackColor = Color.White
        Dim fuente As Single = cbx.Font.Size
        cbx.Font = New Font("Tahoma", fuente, System.Drawing.FontStyle.Regular)
        cbx.BorderStyle = BorderStyles.Default
        cbx.Properties.Appearance.BorderColor = Color.White
        cbx.ForeColor = Color.Black
        If IsNothing(lbl) = False Then
            Dim fuente2 As Single = lbl.Font.Size
            lbl.Font = New Font("Tahoma", fuente2, System.Drawing.FontStyle.Regular)
        End If
    End Sub
    '--------------------------------------------------------------------------------------------------------
    Public Function SMT_AsignaSupertToolTip(Mensje As String, Optional Titulo As String = "") As DevExpress.Utils.SuperToolTip
        Try
            Dim stt As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
            ' Create an object to initialize the SuperToolTip.
            Dim infStt As DevExpress.Utils.SuperToolTipSetupArgs = New DevExpress.Utils.SuperToolTipSetupArgs
            infStt.Title.Text = IIf(Titulo <> "", Titulo, "Mensaje SAMIT Sql")
            infStt.Contents.Text = Mensje
            infStt.Title.Appearance.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
            infStt.Contents.Appearance.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular)

            infStt.Contents.Image = Imagen_boton16X16(ImagenesSamit16X16.IconSamit)
            stt.MaxWidth = 250
            stt.Setup(infStt)
            Return stt
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Enum ImagenesSamit32X32
        Conectar = 0
        Desconectar = 1
        Agregar = 2
        GuardarTodo = 3
        BuacarEmpleado = 4
        Empleados = 5
        Contratos = 6
        AsignarNominas = 7
        Cargos = 8
        OpcionesNomina = 9
        Novedades = 10
        Liquidar = 11
        Salir = 12
        Imprimir = 13
        PlantaCargos = 14

        Empleados2 = 15
        Configurar = 16
        Conceptos = 17
        Contratos2 = 18
    End Enum
    Public Function Imagen_boton32X32(NumImg As ImagenesSamit32X32) As Image
        Imagen_boton32X32 = FrmPrincipal.ImagenesSMT32X32.Images(NumImg)
    End Function
    Public Enum ImagenesSamit16X16
        'Icons Generales
        Opciones = 0
        Empleados = 1
        CambiaFecha = 2
        CambiaClave = 3
        ConsultarEmpleado = 4
        Editar = 5
        Eliminar = 6
        IconSamit = 7
        'Fin icons Generales

        'Icons tabs de forms
        'Empleados
        DatosBasicosEmleados = 8
        Afiliaciones = 9
        Familiares = 10
        ExperienciaLaboral = 11
        InformacionAcademica = 12

        'Icons para CRUD
        Guardar = 13
        Limpiar = 14
        EliminarGris = 17
        SalirCuadroConX = 18
        'Fin icons para CRUD


        CargarImagen = 15
        AmpliarImagenes = 16
        Agregar = 19
        SalirAtras = 20
        Imagen = 21
        Imprimir = 22
        Aplicar = 23
        CargarCertificado = 24
        Conectar = 25
        Desconectar = 26
        OpcionesEmpleados = 27
        Telefono = 28
        GenerarPeriodos = 29
        Aceptar = 39
        Cancelar = 40

        FuncionesCargo = 30
        AsignacionesCargo = 31
        CargosContrato = 32
        DatosBasicosCargos = 33
        DatosBasicosContratos = 34
        Buscar = 35
        GuardaBorrador = 36
        LiquidaNomina = 37
        CargarCVS = 38

        NuevoRegistro = 41
        AgregarItem = 42
        EliminarItem = 43
        FlechaArriba = 44
        FlechaAbajo = 45
        Formula = 46
        Detalle = 47
        Contabilizar = 48
        Anular = 49
        Excell_XlsX = 50
        Excell_Xls = 51
        Lista = 52
        AgregarRound = 53
        Dinero = 54
        Excento = 55
        Descuento = 56
        EditaPersona = 57
        ConceptosNomina = 58
        ConceptosPersonales = 59
        PerfilConceptos = 60
        Excel = 61
        ExcelSave = 62
        ImportaEmpleado = 63
        GeneraPeriodos = 64
        BuscarPeriodos = 65
        LiquidarPerdiodos = 66
        Liquidarextraordinaria = 67
        LiquidarContrato = 68
        LiquidarSemestres = 69
        Subir = 70
        Lupa = 71
        Liquidaciones = 72
        ConfigLiquidaciones = 73
        FormulasLiquidaciones = 74
        TabsCatalogo = 75
        Bancos = 76
        Entidades = 77
        TipoContra = 78
        Dependencias = 79
        Formulas = 80
        PCargos = 81

    End Enum

    Public Function Imagen_boton16X16(NumImg As ImagenesSamit16X16) As Image
        Imagen_boton16X16 = FrmPrincipal.ImagenesSMT16X16.Images(NumImg)
    End Function

    Public Sub AvanzaConEnter(e As KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
        If e.KeyChar = ChrW(Keys.Escape) Then
            e.Handled = True
            SendKeys.Send("+{TAB}")
        End If
    End Sub
    '-------------------------------------------------------------------------------------------------------
    Public Sub AtrasConScape(e As KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Escape) Then
            e.Handled = True
            SendKeys.Send("+{TAB}")
        End If
    End Sub
    '--------------------------------------------------------------------------------------------------------
    Public Sub AvanzarAtrasControl(e As KeyEventArgs)
        Try
            If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If
            If e.KeyCode = Keys.Up Or e.KeyCode = Keys.Escape Then
                e.Handled = True
                SendKeys.Send("+{TAB}")
            End If
        Catch ex As Exception
            msgError(ex, ex.Message, "AvanzarAtrasControl")
        End Try
    End Sub
    '---------------------------------------------------------------------------------------------------------
    Public Function EstaCargadoFormulario(NombreForma As String) As Boolean
        For Each Mifrm As Form In Application.OpenForms
            If Mifrm.Name.Equals(NombreForma) Then
                EstaCargadoFormulario = True
                Mifrm.BringToFront()
            End If
        Next
        Return EstaCargadoFormulario
    End Function
End Class

