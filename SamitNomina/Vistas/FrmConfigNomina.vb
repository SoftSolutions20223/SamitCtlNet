Imports SamitCtlNet
Imports SamitCtlNet.SamitCtlNet
Imports DevExpress.Utils
Imports System.ComponentModel
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns
Imports System.Transactions
Imports DevExpress.XtraGrid
Imports DevExpress.XtraEditors
Imports DevExpress.XtraVerticalGrid
Imports DevExpress.XtraVerticalGrid.Rows
Imports DevExpress.XtraEditors.Repository
Imports System.Data.SqlClient
Public Class FrmConfigNomina

    Public Datos As New SamitCtlNet.SamitCtlNet
    Dim lkEdit As New RepositoryItemSearchLookUpEdit
    Dim lkEdit2 As New RepositoryItemSearchLookUpEdit
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
    Private Sub AsignaScriptAcontroles()
        Try
            txtOficina.DatosDefecto = ObjetosNomina.Oficinas
            txtOficina.RefrescarDatos()

        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "AsignaScriptAcontroles")
        End Try
    End Sub

    Private Sub CreaGrillaNominasContratos()
        Dim coloor As System.Drawing.Color = Color.White
        gvNominasConceptos.Columns.Clear()
        If grbTipoConcepto.SelectedIndex = 0 Then
            CreaColumnas(gvNominasConceptos, "SecConcepto", "SecConcepto", False, False, "", coloor, False, False)
            CreaColumnas(gvNominasConceptos, "NomConcepto", "Concepto", True, False, "", coloor, False, False)
            CreaColumnas(gvNominasConceptos, "CuentaContable", "Cuenta Contable", True, True, "", coloor, False, False)
        ElseIf grbTipoConcepto.SelectedIndex = 1 Then
            CreaColumnas(gvNominasConceptos, "SecConcepto", "SecConcepto", False, False, "", coloor, False, False)
            CreaColumnas(gvNominasConceptos, "NomConcepto", "Concepto", True, False, "", coloor, False, False)
            CreaColumnas(gvNominasConceptos, "CuentaContable", "Cuenta Contable", True, True, "", coloor, False, False)
            CreaColumnas(gvNominasConceptos, "ContraPartida", "Contra Partida", True, True, "", coloor, False, False)
        Else
            CreaColumnas(gvNominasConceptos, "SecConcepto", "SecConcepto", False, False, "", coloor, False, False)
            CreaColumnas(gvNominasConceptos, "NomConcepto", "Concepto", True, False, "", coloor, False, False)
            CreaColumnas(gvNominasConceptos, "CuentaContable", "Cuenta Contable", True, True, "", coloor, False, False)
            CreaColumnas(gvNominasConceptos, "CodConceptoR", "Concepto Retencion", True, False, "", coloor, False, True)
        End If
        gvNominasConceptos.Appearance.HeaderPanel.Font = New Font("Trebuchet MS", 11.0!, FontStyle.Bold)

    End Sub

    Private Sub CreaColumnas(Grid As GridView, Nombre As String, Titulo As String, Visible As Boolean, Editar As Boolean, formula As String, colores As System.Drawing.Color, numerico As Boolean, lke2 As Boolean)
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
            End If
            If numerico = True Then
                .UnboundType = DevExpress.Data.UnboundColumnType.Decimal
                .DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                .DisplayFormat.FormatString = "c2"
            End If
            .AppearanceCell.Options.UseBackColor = True
            .AppearanceCell.BackColor = colores
            .OptionsColumn.AllowSize = True
            .OptionsColumn.AllowMove = True
            .OptionsColumn.AllowEdit = Editar
            .OptionsColumn.AllowIncrementalSearch = True
            If Editar Then

                .ColumnEdit = lkEdit
                .OptionsColumn.AllowEdit = True
                .OptionsColumn.AllowFocus = True

                .AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            ElseIf lke2 Then
                .ColumnEdit = lkEdit2
                .OptionsColumn.AllowEdit = True
                .OptionsColumn.AllowFocus = True
                .AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Else
                .OptionsColumn.AllowEdit = False
                .OptionsColumn.AllowFocus = False
                .AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            End If

            .OptionsFilter.AllowFilter = False
            .Visible = Visible
            .AppearanceHeader.Options.UseTextOptions = True
            .AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            .AppearanceCell.Options.UseTextOptions = True
        End With
        Grid.OptionsCustomization.AllowSort = False
        Grid.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.CellFocus
        Grid.Columns.Add(gc)
    End Sub

    Private Sub AcomodaForm()
        Try
            btnGuardar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Guardar)
            btnSalir.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.SalirAtras)
            btnLimpiar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Limpiar)
            lkEdit.AllowFocused = True
            grbTipoConcepto.SelectedIndex = 0
            Dim classResize As New ClaseResize
            classResize.Resizagrid(gvNominasConceptos)

        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "AcomodaForm Agrega Tipo de Contrato!")
        End Try
    End Sub

    Private Sub LlenaGrillaNominasContratos()
        Try
            If txtNomina.ValordelControl = "" Or txtNomina.DescripciondelControl = "No Se Encontraron Registros" Or txtNomina.DescripciondelControl = "" Then
                Return
            End If

            Dim TipoConcepto As String = ""
            Dim Orden As String = "ORDER BY N.NomNomina ASC"
            Dim sqlPrincipal As String = ""

            ' Determinar la consulta principal según el tipo de concepto
            Select Case grbTipoConcepto.SelectedIndex
                Case 0 ' Ingresos
                    TipoConcepto = "'Ingresos'"
                    sqlPrincipal = "SELECT N.NomNomina, N.Sec AS SecNomina, C.NomConcepto, C.Sec AS SecConcepto, " &
                              "CC.CuentaContable, CC.Sec AS SecConfig " &
                              "FROM ConfigConceptos CC " &
                              "INNER JOIN Nominas N ON CC.Nomina = N.Sec " &
                              "INNER JOIN ConceptosNomina C ON CC.Concepto = C.Sec " &
                              "INNER JOIN TiposConceptosNomina TCN ON C.Tipo = TCN.Sec " &
                              "WHERE CC.Nomina = " & txtNomina.ValordelControl & " AND TCN.NomTipo = " & TipoConcepto & " " & Orden

                Case 1 ' Provisiones
                    TipoConcepto = "'Provisiones'"
                    sqlPrincipal = "SELECT N.NomNomina, N.Sec AS SecNomina, C.NomConcepto, C.Sec AS SecConcepto, " &
                              "CC.CuentaContable, CC.Sec AS SecConfig, CC.ContraPartida " &
                              "FROM ConfigConceptos CC " &
                              "INNER JOIN Nominas N ON CC.Nomina = N.Sec " &
                              "INNER JOIN ConceptosNomina C ON CC.Concepto = C.Sec " &
                              "INNER JOIN TiposConceptosNomina TCN ON C.Tipo = TCN.Sec " &
                              "WHERE CC.Nomina = " & txtNomina.ValordelControl & " AND TCN.NomTipo = " & TipoConcepto & " " & Orden

                Case 2 ' Deducciones
                    sqlPrincipal = "SELECT CC.ConceptoR, N.NomNomina, N.Sec AS SecNomina, C.NomConcepto, " &
                              "C.Sec AS SecConcepto, CC.CuentaContable, CC.Sec AS SecConfig " &
                              "FROM ConfigConceptos CC " &
                              "INNER JOIN Nominas N ON CC.Nomina = N.Sec " &
                              "INNER JOIN ConceptosNomina C ON CC.Concepto = C.Sec " &
                              "INNER JOIN TiposConceptosNomina TCN ON C.Tipo = TCN.Sec " &
                              "WHERE CC.Nomina = " & txtNomina.ValordelControl & " AND TCN.NomTipo = 'Deducciones' " &
                              "AND (C.Fondo IS NULL OR C.Fondo = 0)"
            End Select

            ' Preparar array de consultas
            Dim consultas() As String = {
            sqlPrincipal,
            "SELECT Oficina FROM Nominas WHERE Sec = " & txtNomina.ValordelControl,
            "SELECT CodCuenta AS Codigo, CodCuenta + '-' + NomCuenta AS Descripcion " &
            "FROM CT_PlandeCuentas WHERE EsdeMovimiento = 1 AND Estado = 'V'",
            "SELECT CodConcepto AS Codigo, CAST(CodConcepto AS VARCHAR(5)) + '-' + NomConcepto AS Descripcion " &
            "FROM E" & Datos.Seguridad.DatosDeLaEmpresa.NumEmpresa.ToString("000") & Year(Datos.Smt_FechaDeTrabajo()).ToString & "..CT_RetConceptos"
        }

            ' Ejecutar todas las consultas en un solo llamado
            Dim dsResultados As DataSet = SMT_GetDataset(ObjetoApiNomina, consultas)

            ' Procesar resultados
            If dsResultados IsNot Nothing AndAlso dsResultados.Tables.Count >= 4 Then
                ' Tabla principal de conceptos
                Dim dtConceptos As DataTable = dsResultados.Tables(0)

                ' Para deducciones, agregar columna adicional y procesar ConceptoR
                If grbTipoConcepto.SelectedIndex = 2 Then
                    dtConceptos.Columns.Add("CodConceptoR", GetType(String))

                    ' Si hay conceptos de retención, hacer una sola consulta adicional
                    Dim conceptosR As New List(Of String)
                    For Each row As DataRow In dtConceptos.Rows
                        If row("ConceptoR") IsNot DBNull.Value AndAlso row("ConceptoR").ToString() <> "" AndAlso row("ConceptoR").ToString() <> "0" Then
                            conceptosR.Add(row("ConceptoR").ToString())
                        End If
                    Next

                    If conceptosR.Count > 0 Then
                        Dim sqlRetenciones As String = "SELECT CodConcepto, SecConcepto FROM E" &
                                                  Datos.Seguridad.DatosDeLaEmpresa.NumEmpresa.ToString("000") &
                                                  Year(Datos.Smt_FechaDeTrabajo()).ToString &
                                                  "..CT_RetConceptos WHERE CodConcepto IN (" & String.Join(",", conceptosR) & ")"

                        Dim dtRetenciones As DataTable = SMT_AbrirTabla(ObjetoApiNomina, sqlRetenciones)

                        ' Crear diccionario para búsqueda rápida
                        Dim dictRetenciones As New Dictionary(Of String, String)
                        For Each row As DataRow In dtRetenciones.Rows
                            dictRetenciones(row("CodConcepto").ToString()) = row("SecConcepto").ToString()
                        Next

                        ' Actualizar la columna CodConceptoR
                        For Each row As DataRow In dtConceptos.Rows
                            If row("ConceptoR") IsNot DBNull.Value AndAlso dictRetenciones.ContainsKey(row("ConceptoR").ToString()) Then
                                row("CodConceptoR") = dictRetenciones(row("ConceptoR").ToString())
                            End If
                        Next
                    End If
                End If

                ' Asignar DataSource
                gcNominasConceptos.DataSource = dtConceptos

                ' Asignar oficina
                If dsResultados.Tables(1).Rows.Count > 0 Then
                    txtOficina.ValordelControl = dsResultados.Tables(1).Rows(0)("Oficina").ToString()
                End If

                ' Configurar plan de cuentas
                If dsResultados.Tables(2).Rows.Count > 0 Then
                    lkEdit.DataSource = dsResultados.Tables(2)
                    lkEdit.ValueMember = "Codigo"
                    lkEdit.DisplayMember = "Descripcion"
                End If

                ' Configurar conceptos de retención
                If dsResultados.Tables(3).Rows.Count > 0 Then
                    lkEdit2.DataSource = dsResultados.Tables(3)
                    lkEdit2.ValueMember = "Codigo"
                    lkEdit2.DisplayMember = "Descripcion"
                End If
            End If

        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "LlenaGrillaNominasContratos")
        End Try
    End Sub

    Private Sub FrmConfigNomina_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AsignaScriptAcontroles()
        CreaGrillaNominasContratos()
        AcomodaForm()
        txtNomina.Focus()
        txtNomina.MensajedeAyuda = "Seleccione la nómina la cual desea configurar. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras, (F5,DER)=Buscar"
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub txtNominas_Leave(sender As Object, e As EventArgs) Handles txtNomina.Leave
        LlenaGrillaNominasContratos()
        If gvNominasConceptos.RowCount > 0 Then
            gcNominasConceptos.Focus()
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarCampos()
    End Sub

    Private Sub LimpiarCampos()
        txtNomina.ValordelControl = ""
        txtOficina.ValordelControl = ""
        grbTipoConcepto.SelectedIndex = 0
        gcNominasConceptos.DataSource = Nothing
        LlenaGrillaNominasContratos()
        txtNomina.Focus()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim Tbla As DataTable = CType(gcNominasConceptos.DataSource, DataTable)
            If Tbla.Rows.Count > 0 Then
                For incre As Integer = 0 To Tbla.Rows.Count - 1
                    Dim ConceptoR As String = ""
                    Dim ContraPartida As String = ""
                    If grbTipoConcepto.SelectedIndex = 2 Then
                        If Tbla.Rows(incre)("CodConceptoR").ToString <> "" Then
                            Dim Sec As String = SMT_AbrirTabla(ObjetoApiNomina, "Select SecConcepto From E" + Datos.Seguridad.DatosDeLaEmpresa.NumEmpresa.ToString("000") + Year(Datos.Smt_FechaDeTrabajo()).ToString + "..CT_RetConceptos Where CodConcepto=" + Tbla.Rows(incre)("CodConceptoR").ToString).Rows(0)(0).ToString
                            Tbla.Rows(incre)("ConceptoR") = Sec
                            ConceptoR = Tbla.Rows(incre)("ConceptoR").ToString
                        End If
                    End If

                    If grbTipoConcepto.SelectedIndex = 1 Then
                        If Tbla.Rows(incre)("ContraPartida").ToString <> "" Then
                            ContraPartida = Tbla.Rows(incre)("ContraPartida").ToString
                        End If
                    End If
                    If Not GuardaDatos(txtNomina.ValordelControl, Tbla.Rows(incre)("SecConcepto").ToString, Tbla.Rows(incre)("CuentaContable").ToString, ConceptoR, ContraPartida) Then
                        Exit Sub
                    End If
                Next
                LlenaGrillaNominasContratos()
                HDevExpre.mensajeExitoso("Datos guardados exitosamente!..")
                LimpiarCampos()
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "btnGuardar_Click")
        End Try

    End Sub

    Private Function GuardaDatos(Nomina As String, Concepto As String, CuentaContable As String, ConceptoR As String, ContraPartida As String) As Boolean
        Try
            Dim GenSql As New SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL
            GenSql.PasoConexionTabla(ObjetoApiNomina, "ConfigConceptos")
            GenSql.PasoValores("Nomina", Nomina, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            GenSql.PasoValores("Concepto", Concepto, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            GenSql.PasoValores("CuentaContable", CuentaContable, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            If grbTipoConcepto.SelectedIndex = 2 Then
                GenSql.PasoValores("ConceptoR", ConceptoR, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            End If
            If grbTipoConcepto.SelectedIndex = 1 Then
                GenSql.PasoValores("ContraPartida", ContraPartida, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            End If
            If GenSql.EjecutarComandoNET(SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.SQLGenera.Actualizacion, String.Format("Nomina={0} And Concepto={1}", Nomina, Concepto)) Then
                Return True
            Else : Return False
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "Guardando ConfigNomina")
            Return False
        End Try
    End Function

    Private Sub FrmNominasContratos_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        LimpiarCampos()
    End Sub

    Private Sub grbTipoConcepto_Enter(sender As Object, e As EventArgs) Handles grbTipoConcepto.Enter
        HDevExpre.EntraControlRadioGroup(grbTipoConcepto, lblTipoConcepto, grbTipoConcepto.Font.Size, lblTipoConcepto.Font.Size)
        FrmPrincipal.MensajeDeAyuda.Caption = "Tipo de conceptos a consultar. (ENTER)=Avanzar;(ESC,ARB)=Atras"
        FrmPrincipal.MensajeDeAyuda.Refresh()
    End Sub

    Private Sub grbTipoConcepto_Leave(sender As Object, e As EventArgs) Handles grbTipoConcepto.Leave
        HDevExpre.SaleControlRadioGroup(grbTipoConcepto, lblTipoConcepto, grbTipoConcepto.Font.Size, lblTipoConcepto.Font.Size)
        FrmPrincipal.MensajeDeAyuda.Caption = ""
        FrmPrincipal.MensajeDeAyuda.Refresh()
    End Sub
    Private Sub rgVigente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles grbTipoConcepto.KeyPress
        HDevExpre.AvanzaConEnter(e)
    End Sub

    Private Sub grbTipoConcepto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles grbTipoConcepto.SelectedIndexChanged
        CreaGrillaNominasContratos()
        LlenaGrillaNominasContratos()
    End Sub

    Private Sub gvNominasConceptos_InvalidRowException(sender As Object, e As Views.Base.InvalidRowExceptionEventArgs) Handles gvNominasConceptos.InvalidRowException
        e.WindowCaption = "Mensaje SAMIT SQL"
        e.ErrorText = "Este Concepto no es una retencion..!"
    End Sub

    Private Sub gvNominasConceptos_ValidateRow(sender As Object, e As Views.Base.ValidateRowEventArgs) Handles gvNominasConceptos.ValidateRow
        Dim Tb As DataTable
        Dim NUM As String = gvNominasConceptos.GetFocusedRowCellValue("SecConcepto").ToString
        If grbTipoConcepto.SelectedIndex = 2 Then
            Tb = SMT_AbrirTabla(ObjetoApiNomina, "Select EsRetencion From ConceptosNomina Where Sec=" + NUM)
            Dim Sec As String = Tb.Rows(0)(0).ToString
            If Sec = "True" Then

            Else
                If gvNominasConceptos.GetFocusedRowCellValue("CodConceptoR").ToString <> "" Then
                    'e.ErrorText = "Este Concepto no es una retencion..!"
                    e.Valid = False
                End If
            End If
        End If


    End Sub

    Private Sub gvNominasConceptos_ValidatingEditor(sender As Object, e As BaseContainerValidateEditorEventArgs) Handles gvNominasConceptos.ValidatingEditor
        'Dim Tb As DataTable
        'If gvNominasConceptos.FocusedColumn.Name = "CodConceptoR" Then
        '    Dim NUM As String = gvNominasConceptos.GetFocusedRowCellValue("SecConcepto").ToString
        '    Tb = SMT_AbrirTabla(ObjetoApiNomina, "Select EsRetencion From ConceptosNomina Where Sec=" + NUM)
        '    Dim Sec As String = Tb.Rows(0)(0).ToString
        '    If Sec = "True" Then

        '    Else
        '        If gvNominasConceptos.GetFocusedRowCellValue("CodConceptoR").ToString <> "" Then
        '            e.ErrorText = "Este Concepto no es una retencion..!"
        '            e.Valid = False
        '        End If

        '    End If
        'End If
    End Sub


    Private Sub txtOficina_Leave(sender As Object, e As EventArgs) Handles txtOficina.Leave
        txtNomina.ConsultaSQL = String.Format("SELECT SecNomina AS Codigo,NomNomina As Descripcion FROM  Nominas Where Oficina=" + txtOficina.ValordelControl)
        txtNomina.RefrescarDatos()
    End Sub

    Private Sub txtNomina_Enter(sender As Object, e As EventArgs) Handles txtNomina.Enter
        Dim dt As New DataTable
        gcNominasConceptos.DataSource = dt
        If txtOficina.ValordelControl = "" Then
            txtOficina.Focus()
        End If
    End Sub

    Private Sub txtOficina_Enter(sender As Object, e As EventArgs) Handles txtOficina.Enter
        txtNomina.ValordelControl = ""
        Dim dt As New DataTable
        gcNominasConceptos.DataSource = dt
    End Sub
End Class