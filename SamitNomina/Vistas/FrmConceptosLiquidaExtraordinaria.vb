Imports SamitCtlNet
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraEditors.Repository
Imports System.Data.SqlClient

Public Class FrmConceptosLiquidaExtraordinaria
    Dim Formu As String
    Dim Ckedeit As New RepositoryItemCheckEdit
    Dim Nomina As String
    Dim Conceptos As New DataTable
    Dim ConceptosEnviar As New DataTable
    Dim HDevExpre As New HelperDevExpress
    Dim HNomina As New HelperNomina

    Public Property Fomulario() As String
        Get
            Return Formu
        End Get
        Set(value As String)
            Formu = value
        End Set
    End Property

    Public Property P_Nomina() As String
        Get
            Return Nomina
        End Get
        Set(value As String)
            Nomina = value
        End Set
    End Property
    Private Sub AcomodaForm()
        Try
            MyBase.Text = Formu
            btnAceptar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Aceptar)
            btnCancelar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Cancelar)
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, " AcomodaForm")
        End Try
    End Sub

    Private Function ValidaCampos() As Boolean
        Dim Tbla As DataTable = CType(gcContratos.DataSource, DataTable)
        Dim SelectConcepto As Boolean = False
        If Tbla.Rows.Count > 0 Then
            For incre As Integer = 0 To Tbla.Rows.Count - 1
                If Convert.ToBoolean(Tbla.Rows(incre)("Liquidar Concepto")) = True Then
                    SelectConcepto = True
                End If
            Next
        End If
        If Not SelectConcepto Then
            HDevExpre.MensagedeError("Debe seleccionar al menos un concepto para continuar!..")
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub LlenaGrilla()
        Try
            Dim sql As String = "Select C.NomConcepto AS Nombre,C.Sec As Sec,CL.Nom As Clasificacion,CC.Formula,Case TCN.NomTipo WHEN 'Provisiones' then 'Ingresos' when 'Ingresos' then 'Ingresos' when 'Deducciones' then 'Deducciones' end As Tipo,C.Base As Base " +
" From ConceptosNomina C Inner join ClasConceptosNomina CL ON C.Clasificacion = CL.Sec " +
"Inner join ConfigConceptos CC ON C.Sec = CC.Concepto Inner Join TiposConceptosNomina TCN ON C.Tipo = TCN.Sec Where cc.Nomina =" + Nomina

            Dim dt As DataTable = SMT_AbrirTabla(ObjetoApiNomina, sql)
            Conceptos = dt.Copy
            ConceptosEnviar = dt.Copy
            dt.Columns.Add("Liquidar Concepto", GetType(Boolean))
            If dt.Rows.Count > 0 Then
                For incre As Integer = 0 To dt.Rows.Count - 1
                    dt.Rows(incre)("Liquidar Concepto") = "False"
                Next
            End If
            gcContratos.DataSource = dt
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "LlenaGrilla")
        End Try
    End Sub

    Private Sub CreaGrillaConfigTiposContratos()
        Dim coloor As System.Drawing.Color = Color.White
        gvContratos.Columns.Clear()
        CreaColumnas(gvContratos, "Sec", "Sec", False, False, "", coloor, False, 0, gcContratos.Width, False, False, False)
        CreaColumnas(gvContratos, "Nombre", "Concepto", True, False, "", coloor, False, 40, gcContratos.Width, False, False, False)
        CreaColumnas(gvContratos, "Clasificacion", "Clasificacion", True, False, "", coloor, False, 40, gcContratos.Width, False, False, False)
        CreaColumnas(gvContratos, "Liquidar Concepto", "Liquidar Concepto", True, True, "", coloor, False, 60, gcContratos.Width, True, False, True)
        gvContratos.Appearance.HeaderPanel.Font = New Font("Trebuchet MS", 11.0!, FontStyle.Bold)
        gvContratos.Appearance.ViewCaption.Options.UseTextOptions = True
        gvContratos.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        gvContratos.Appearance.ViewCaption.ForeColor = Color.Blue
        Dim classResize As New ClaseResize
        classResize.Resizagrid(gvContratos)
    End Sub

    Private Sub CreaColumnas(Grid As GridView, Nombre As String, Titulo As String, Visible As Boolean, Editar As Boolean, formula As String, colores As System.Drawing.Color, numerico As Boolean, Porcentaje_Width As Single, TamañoPadre As Single, Escheck As Boolean, eslke As Boolean, focus As Boolean)
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
            If Escheck Then
                .ColumnEdit = Ckedeit
                .OptionsColumn.AllowEdit = True
                .OptionsColumn.AllowFocus = True
                .AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            End If
            If focus Then
                .OptionsColumn.AllowFocus = True
            End If
            .OptionsFilter.AllowFilter = False
            .Visible = Visible
            .AppearanceHeader.Options.UseTextOptions = True
            .AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            .AppearanceCell.Options.UseTextOptions = True

        End With
        Grid.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.CellFocus
        Grid.Columns.Add(gc)
    End Sub

    Private Sub FrmConfigTiposContratos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AcomodaForm()
        CreaGrillaConfigTiposContratos()
        LlenaGrilla()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            If ValidaCampos() Then
                Dim Tbla As DataTable = CType(gcContratos.DataSource, DataTable)
                ConceptosEnviar.Rows.Clear()
                For incre As Integer = 0 To Tbla.Rows.Count - 1
                    If Convert.ToBoolean(Tbla.Rows(incre)("Liquidar Concepto")) = True Then
                        ConceptosEnviar.ImportRow(Tbla.Rows(incre))
                    End If
                Next
                FrmLiquidacionExtraordinaria.ObtieneConceptos(ConceptosEnviar)
                FrmConsultaLiquidaExtraordinarias.P_Continua = True
                MyBase.Close()
                Formu = ""
            Else
                FrmConsultaLiquidaExtraordinarias.P_Continua = False
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "btnGuardar_Click")
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        FrmConsultaLiquidaExtraordinarias.P_Continua = False
        Me.Close()
        Formu = ""
    End Sub

End Class