Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraEditors.Repository
Imports System.Drawing
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid

Public Class GrillaDevExpress
    Public Shared Sub CrearGrilla(ByRef Vista As GridView, mostrarTitulo As Boolean, activarFiltro As Boolean, Optional tituloGrilla As String = "", Optional PermiteAgrupamiento As Boolean = False, _
                                  Optional PermiteResizeColumnas As Boolean = True, Optional PermiteMoverColumnas As Boolean = False, Optional AnchoColumnaAuto As Boolean = False, _
                                 Optional MostrarPiedeGrid As Boolean = False)
        Vista.Columns.Clear()
        Vista.OptionsView.ShowViewCaption = mostrarTitulo
        If mostrarTitulo Then
            Vista.ViewCaption = tituloGrilla
        End If

        Vista.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Vista.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Vista.OptionsBehavior.Editable = False
        Vista.OptionsSelection.EnableAppearanceFocusedRow = True
        'Opciones de Vista del Grid   
        'Vista.OptionsView.ColumnAutoWidth = True
        Vista.OptionsView.ColumnAutoWidth = AnchoColumnaAuto
        Vista.OptionsView.ShowFooter = MostrarPiedeGrid
        ' ' Manejo de Colores                                                                                                                                                             
        Vista.Appearance.FocusedRow.BackColor = System.Drawing.Color.Aquamarine
        Vista.Appearance.FocusedRow.Font = New System.Drawing.Font("Tahoma", 11.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Vista.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Maroon
        Vista.Appearance.FocusedRow.Options.UseTextOptions = False
        Vista.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 11.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        Vista.ActiveFilterEnabled = activarFiltro
        Vista.OptionsView.ShowAutoFilterRow = activarFiltro
        ''Panel Inferior de Filtro                                                                                                                                                       
        Vista.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
        Vista.OptionsMenu.ShowAutoFilterRowItem = activarFiltro
        Vista.OptionsMenu.ShowGroupSortSummaryItems = activarFiltro
        Vista.OptionsMenu.EnableColumnMenu = activarFiltro
        Vista.OptionsMenu.EnableGroupPanelMenu = activarFiltro
        Vista.OptionsMenu.ShowGroupSortSummaryItems = activarFiltro
        Vista.OptionsCustomization.AllowFilter = activarFiltro
        Vista.OptionsCustomization.AllowSort = activarFiltro

        Vista.OptionsCustomization.AllowGroup = PermiteAgrupamiento
        Vista.OptionsView.ShowGroupedColumns = PermiteAgrupamiento
        Vista.OptionsMenu.EnableGroupPanelMenu = PermiteAgrupamiento
        Vista.OptionsView.ShowGroupPanel = PermiteAgrupamiento

        ' Opciones de Manejo x Usuario Final                                                                                                                                            
        Vista.OptionsCustomization.AllowRowSizing = False
        Vista.OptionsCustomization.AllowColumnResizing = PermiteResizeColumnas
        Vista.OptionsCustomization.AllowColumnMoving = PermiteMoverColumnas

    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="nombre">Nombre de la columna del datasource</param>
    ''' <param name="titulo">Titulo del encabezado de columna</param>
    ''' <returns></returns>
    Public Shared Function CrearColumna(nombre As String, titulo As String, Optional tipo As FormatType = FormatType.None, Optional formato As String = "", Optional visible As Boolean = True, Optional autoAncho As Boolean = False,
        Optional anchoColumna As Integer = 100, Optional soloLectura As Boolean = True, Optional permiteEditar As Boolean = False, Optional permiteFoco As Boolean = False, Optional alineacionEncabezado As HorzAlignment = HorzAlignment.Center, Optional alineacion As AlinearTexto = AlinearTexto.Izquierda) As GridColumn
        Dim Columna As New GridColumn()
        'Columna.Name = InlineAssignHelper(Columna.FieldName, nombre)
        Columna.Name = nombre
        Columna.FieldName = nombre
        Columna.Caption = titulo
        Columna.DisplayFormat.FormatType = tipo
        Columna.DisplayFormat.FormatString = formato
        Columna.Visible = visible
        Columna.OptionsColumn.ReadOnly = soloLectura
        Columna.OptionsColumn.AllowEdit = permiteEditar
        Columna.OptionsColumn.AllowFocus = permiteFoco
        Columna.OptionsColumn.AllowSize = True ' Permite cambiar ancho columnas
        'Columna.OptionsColumn.FixedWidth = False
        'Columna.AppearanceCell.Options.UseTextOptions = True

        Select Case alineacion
            Case AlinearTexto.Izquierda
                Columna.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Near
            Case AlinearTexto.Centro
                Columna.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center
            Case AlinearTexto.Derecha
                Columna.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Far
            Case Else
                Columna.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Default
        End Select

        Columna.AppearanceHeader.Options.UseTextOptions = True
        Columna.AppearanceHeader.TextOptions.HAlignment = alineacionEncabezado
        Columna.OptionsColumn.AllowGroup = DefaultBoolean.True
        If Not autoAncho Then
            Columna.Width = anchoColumna
            'Columna.OptionsColumn.FixedWidth = True
            'Columna.MaxWidth = anchoColumna
        Else
            Columna.BestFit()
        End If

        Return Columna
    End Function

    Public Shared Sub CreaColumnasG(Grid As GridView, Nombre As String, Titulo As String, Visible As Boolean, Editar As Boolean, formula As String, colores As System.Drawing.Color, numerico As Boolean,
                             Moneda As Boolean, Ancho As Single, AnchoFijo As Boolean, TamañoPadre As Single, Optional Alineacion As DevExpress.Utils.HorzAlignment = DevExpress.Utils.HorzAlignment.Near,
                                    Optional TituloGrid As Boolean = False, Optional TextCaption As String = "", Optional EsImagen As Boolean = False, Optional GridCont As GridControl = Nothing, Optional EsFecha As Boolean = False,
                                    Optional FormatoFecha As String = "", Optional autoheight As Boolean = False, Optional autowidth As Boolean = False, Optional filterColumn As Boolean = False, Optional agrupar As Boolean = False)
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
                .DisplayFormat.FormatString = "#,##0.####"
            End If
            If Moneda Then
                .UnboundType = DevExpress.Data.UnboundColumnType.Decimal
                .DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                .DisplayFormat.FormatString = "#,##0.##"
                '.UnboundType = DevExpress.Data.UnboundColumnType.Decimal
                '.DisplayFormat.FormatString = VGFormatoMoneda
                '.AppearanceCell.TextOptions.HAlignment = Alineacion
            End If
            If EsFecha Then
                .UnboundType = DevExpress.Data.UnboundColumnType.DateTime
                .DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
                .DisplayFormat.FormatString = FormatoFecha
            End If
            If Ancho > 0 Then
                If AnchoFijo Then
                    .Width = Ancho
                Else
                    .Width = CInt((Ancho * (TamañoPadre - 20)) / 100)
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
            .AppearanceCell.TextOptions.HAlignment = Alineacion
            '.OptionsFilter.AllowFilter = False
            .Visible = Visible
            .AppearanceHeader.Options.UseTextOptions = True
            .AppearanceHeader.TextOptions.HAlignment = Alineacion
            .AppearanceCell.Options.UseTextOptions = True
            If EsImagen Then
                .ColumnEdit = ImgGrid
            End If
            If autoheight Then
                Dim Rme As RepositoryItemMemoEdit = New RepositoryItemMemoEdit()
                Rme.WordWrap = True
                .ColumnEdit = Rme
            End If
            If autowidth Then
                .OptionsColumn.FixedWidth = True
            End If
        End With
        Grid.OptionsView.ShowGroupPanel = False
        Grid.OptionsCustomization.AllowSort = True
        If filterColumn Then
            Grid.OptionsMenu.ShowAutoFilterRowItem = True
            Grid.OptionsView.ShowAutoFilterRow = True
            'gc.OptionsFilter.AutoFilterCondition = AutoFilterCondition.Contains

        End If

        If agrupar Then
            gc.Group()
        End If

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
    End Sub
    Public Shared Sub ColumnaAgregarTotal(Col As GridColumn, Tipo As DevExpress.Data.SummaryItemType, Optional Formato As String = "")
        Col.Summary.Add(Tipo, Col.Name, Formato)
        'Col.SummaryItem.DisplayFormat = Formato
    End Sub

    Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, value As T) As T
        target = value
        Return value
    End Function
End Class
