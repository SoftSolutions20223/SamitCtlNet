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
Imports SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL
Public Class FrmPerfilesCta

    Dim lkEdit As New RepositoryItemSearchLookUpEdit
    Dim lkEdit2 As New RepositoryItemSearchLookUpEdit
    Dim lkEdit2Nats As New RepositoryItemLookUpEdit
    Dim Datos As New SamitCtlNet.SamitCtlNet
    Dim FormularioAbierto As Boolean = False
    Dim secperfil As String
    Dim Actualizando As Boolean = False
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
            FormadePago.ConsultaSQL = "Select Cod_Fp as Codigo,Nombre_FP as Descripcion from ct_FormaPAgo"
            FormadePago.RefrescarDatos()
            txtPerfiles.ConsultaSQL = String.Format("SELECT Sec AS Codigo,NomPerfilCta As Descripcion FROM  PerfilesCta")
            txtPerfiles.RefrescarDatos()
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "AsignaScriptAcontroles")
        End Try
    End Sub

    Private Sub CreaGrillaConceptos()
        Dim coloor As System.Drawing.Color = Color.White
        gvConceptos.Columns.Clear()
        If grbTipoConcepto.SelectedIndex = 0 Then
            CreaColumnas(gvConceptos, "SecConcepto", "SecConcepto", False, False, "", coloor, False, False, False)
            CreaColumnas(gvConceptos, "NomConcepto", "Concepto", True, False, "", coloor, False, False, False)
            CreaColumnas(gvConceptos, "Naturaleza", "Nat Cuenta", True, False, "", coloor, False, False, True)
            CreaColumnas(gvConceptos, "CuentaContable", "Cuenta Contable", True, True, "", coloor, False, False, False)
        ElseIf grbTipoConcepto.SelectedIndex = 1 Then
            CreaColumnas(gvConceptos, "SecConcepto", "SecConcepto", False, False, "", coloor, False, False, False)
            CreaColumnas(gvConceptos, "NomConcepto", "Concepto", True, False, "", coloor, False, False, False)
            CreaColumnas(gvConceptos, "Naturaleza", "Nat Cuenta", True, False, "", coloor, False, False, True)
            CreaColumnas(gvConceptos, "CuentaContable", "Cuenta Contable", True, True, "", coloor, False, False, False)
            CreaColumnas(gvConceptos, "ContraPartida", "Contra Partida", True, True, "", coloor, False, False, False)
        Else
            CreaColumnas(gvConceptos, "SecConcepto", "SecConcepto", False, False, "", coloor, False, False, False)
            CreaColumnas(gvConceptos, "NomConcepto", "Concepto", True, False, "", coloor, False, False, False)
            CreaColumnas(gvConceptos, "Naturaleza", "Nat Cuenta", True, False, "", coloor, False, False, True)
            CreaColumnas(gvConceptos, "CuentaContable", "Cuenta Contable", True, True, "", coloor, False, False, False)
            CreaColumnas(gvConceptos, "CodConceptoR", "Concepto Retencion", True, False, "", coloor, False, True, False)
        End If
        gvConceptos.Appearance.HeaderPanel.Font = New Font("Trebuchet MS", 11.0!, FontStyle.Bold)

    End Sub

    Private Sub CreaGrillaPerfilesCta()
        Dim coloor As System.Drawing.Color = Color.White
        gvPerfilesCta.Columns.Clear()
        CreaColumnas(gvPerfilesCta, "Sec", "Sec", False, False, "", coloor, False, False, False)
        CreaColumnas(gvPerfilesCta, "NomPerfilCta", "Nombre", True, False, "", coloor, False, False, False)
        CreaColumnas(gvPerfilesCta, "FormaPago", "Forma Pago", True, False, "", coloor, False, False, False)
        CreaColumnas(gvPerfilesCta, "VigenteT", "Vigente", True, False, "", coloor, False, False, False)

        gvPerfilesCta.Appearance.HeaderPanel.Font = New Font("Trebuchet MS", 11.0!, FontStyle.Bold)

    End Sub

    Private Sub CreaColumnas(Grid As GridView, Nombre As String, Titulo As String, Visible As Boolean, Editar As Boolean, formula As String, colores As System.Drawing.Color, numerico As Boolean, lke2 As Boolean, lke3 As Boolean)
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
            ElseIf lke3 Then
                .ColumnEdit = lkEdit2Nats
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
            grbVigente.SelectedIndex = 1
            Dim classResize As New ClaseResize
            classResize.Resizagrid(gvConceptos)

        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "AcomodaForm Agrega Tipo de Contrato!")
        End Try
    End Sub

    Private Sub gvPerfilesCta_DoubleClick(sender As Object, e As EventArgs) Handles gvPerfilesCta.DoubleClick
        CargarDatos()
    End Sub

    Private Sub CargarDatos()
        Try
            Dim sql As String = String.Format("SELECT * FROM PerfilesCta WHERE sec='{0}'", gvPerfilesCta.GetFocusedRowCellValue("Sec").ToString)
            Dim dt As DataTable = SMT_AbrirTabla(ObjetoApiNomina, sql)

            Dim Fila As DataRow = dt.Rows(0)
            txtNombre.ValordelControl = Fila("NomPerfilCta").ToString
            FormadePago.ValordelControl = Fila("FormaPago").ToString
            secperfil = Fila("sec").ToString
            Actualizando = True
            grbVigente.SelectedIndex = Convert.ToInt32(Fila("Vigente").ToString)
            LlenaGrillaConceptosCta()
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "  CargarDatos")
        End Try
    End Sub

    Private Sub LlenaGrillaConceptosCta()
        Try

            Dim dt As New DataTable
            Dim TipoConcepto As String = ""
            Dim sql As String = ""
            If Actualizando Then


                If grbTipoConcepto.SelectedIndex = 0 Then
                    TipoConcepto = "'Ingresos'"
                    sql = "Select CC.Naturaleza, C.NomConcepto,C.Sec as SecConcepto,CC.CuentaContable,CC.Sec as SecPerfilConcepto " +
       " From Conceptos_PerfilCta CC " +
       " RIGHT JOIN ConceptosNomina C ON CC.Concepto = C.Sec INNER JOIN TiposConceptosNomina TCN ON C.Tipo = TCN.Sec Where CC.PerfilCta=" + secperfil + " And TCN.NomTipo=" + TipoConcepto

                    dt = SMT_AbrirTabla(ObjetoApiNomina, sql)
                    gcConceptos.DataSource = dt

                ElseIf grbTipoConcepto.SelectedIndex = 1 Then
                    TipoConcepto = "'Provisiones'"
                    sql = "Select CC.Naturaleza, C.NomConcepto,C.Sec as SecConcepto,CC.CuentaContable,CC.Sec as SecPerfilConcepto,CC.ContraPartida " +
                              " From Conceptos_PerfilCta CC " +
                              " RIGHT JOIN ConceptosNomina C ON CC.Concepto = C.Sec INNER JOIN TiposConceptosNomina TCN ON C.Tipo = TCN.Sec " +
                              " Where CC.PerfilCta=" + secperfil + " And TCN.NomTipo=" + TipoConcepto
                    dt = SMT_AbrirTabla(ObjetoApiNomina, sql)
                    gcConceptos.DataSource = dt

                ElseIf grbTipoConcepto.SelectedIndex = 2 Then
                    TipoConcepto = "'Deducciones' And Fondo is Null Or Fondo=''"
                    sql = "Select CC.Naturaleza, CC.ConceptoR,C.NomConcepto,C.Sec as SecConcepto,CC.CuentaContable,CC.Sec as SecPerfilConcepto " +
                              "From Conceptos_PerfilCta CC " +
                              "RIGHT JOIN ConceptosNomina C ON CC.Concepto = C.Sec " +
                              "INNER JOIN TiposConceptosNomina TCN ON C.Tipo = TCN.Sec " +
                              "Where CC.PerfilCta=" + secperfil + " And TCN.NomTipo='Deducciones' "
                    '"And isnull(Fondo,0) =0 "
                    '"Union " +
                    '"Select CC.ConceptoR,N.NomNomina,N.SecNomina,C.NomConcepto,C.Sec as SecConcepto,CC.CuentaContable,CC.Sec as SecConfig  " +
                    '"From ConfigConceptos CC INNER JOIN Nominas N ON CC.Nomina = N.SecNomina  " +
                    '"INNER JOIN ConceptosNomina C ON CC.Concepto = C.Sec " +
                    '"INNER JOIN TiposConceptosNomina TCN ON C.Tipo = TCN.Sec " +
                    '"Where CC.Nomina=" + txtNomina.ValordelControl + " And TCN.NomTipo='Deducciones' " +
                    '"And Fondo='' order by N.NomNomina ASC "

                    dt = SMT_AbrirTabla(ObjetoApiNomina, sql)
                    dt.Columns.Add("CodConceptoR", GetType(String))
                    For incre As Integer = 0 To dt.Rows.Count - 1
                        If dt.Rows(incre)("ConceptoR").ToString <> "" And dt.Rows(incre)("ConceptoR").ToString <> "0" Then
                            Dim Consul As String = "Select SecConcepto From E" + Datos.Seguridad.DatosDeLaEmpresa.NumEmpresa.ToString("000") + Year(Datos.Smt_FechaDeTrabajo()).ToString + "..CT_RetConceptos Where CodConcepto=" + dt.Rows(incre)("ConceptoR").ToString
                            Dim Sec As String = SMT_AbrirTabla(ObjetoApiNomina, "Select SecConcepto From E" + Datos.Seguridad.DatosDeLaEmpresa.NumEmpresa.ToString("000") + Year(Datos.Smt_FechaDeTrabajo()).ToString + "..CT_RetConceptos Where CodConcepto=" + dt.Rows(incre)("ConceptoR").ToString).Rows(0)(0).ToString
                            dt.Rows(incre)("CodConceptoR") = Sec
                        End If
                    Next
                    gcConceptos.DataSource = dt

                End If

            Else

                If grbTipoConcepto.SelectedIndex = 0 Then
                    TipoConcepto = "'Ingresos'"
                    sql = "Select '' as Naturaleza, C.NomConcepto,C.Sec as SecConcepto,'' as CuentaContable " +
       " From ConceptosNomina C INNER JOIN TiposConceptosNomina TCN ON C.Tipo = TCN.Sec Where TCN.NomTipo=" + TipoConcepto

                    dt = SMT_AbrirTabla(ObjetoApiNomina, sql)
                    gcConceptos.DataSource = dt

                ElseIf grbTipoConcepto.SelectedIndex = 1 Then
                    TipoConcepto = "'Provisiones'"
                    sql = "Select '' as Naturaleza, C.NomConcepto,C.Sec as SecConcepto,'' as CuentaContable,'' as ContraPartida " +
                              " From ConceptosNomina C INNER JOIN TiposConceptosNomina TCN ON C.Tipo = TCN.Sec " +
                              " Where TCN.NomTipo=" + TipoConcepto
                    dt = SMT_AbrirTabla(ObjetoApiNomina, sql)
                    gcConceptos.DataSource = dt

                ElseIf grbTipoConcepto.SelectedIndex = 2 Then
                    TipoConcepto = "'Deducciones' And Fondo is Null Or Fondo=''"
                    sql = "Select '' as Naturaleza, '' as ConceptoR,C.NomConcepto,C.Sec as SecConcepto,'' as CuentaContable " +
                              "From ConceptosNomina C " +
                              "INNER JOIN TiposConceptosNomina TCN ON C.Tipo = TCN.Sec " +
                              "Where TCN.NomTipo='Deducciones' "
                    '"And isnull(Fondo,0) =0 "
                    '"Union " +
                    '"Select CC.ConceptoR,N.NomNomina,N.SecNomina,C.NomConcepto,C.Sec as SecConcepto,CC.CuentaContable,CC.Sec as SecConfig  " +
                    '"From ConfigConceptos CC INNER JOIN Nominas N ON CC.Nomina = N.SecNomina  " +
                    '"INNER JOIN ConceptosNomina C ON CC.Concepto = C.Sec " +
                    '"INNER JOIN TiposConceptosNomina TCN ON C.Tipo = TCN.Sec " +
                    '"Where CC.Nomina=" + txtNomina.ValordelControl + " And TCN.NomTipo='Deducciones' " +
                    '"And Fondo='' order by N.NomNomina ASC "

                    dt = SMT_AbrirTabla(ObjetoApiNomina, sql)
                    dt.Columns.Add("CodConceptoR", GetType(String))
                    For incre As Integer = 0 To dt.Rows.Count - 1
                        If dt.Rows(incre)("ConceptoR").ToString <> "" And dt.Rows(incre)("ConceptoR").ToString <> "0" Then
                            Dim Consul As String = "Select SecConcepto From E" + Datos.Seguridad.DatosDeLaEmpresa.NumEmpresa.ToString("000") + Year(Datos.Smt_FechaDeTrabajo()).ToString + "..CT_RetConceptos Where CodConcepto=" + dt.Rows(incre)("ConceptoR").ToString
                            Dim Sec As String = SMT_AbrirTabla(ObjetoApiNomina, "Select SecConcepto From E" + Datos.Seguridad.DatosDeLaEmpresa.NumEmpresa.ToString("000") + Year(Datos.Smt_FechaDeTrabajo()).ToString + "..CT_RetConceptos Where CodConcepto=" + dt.Rows(incre)("ConceptoR").ToString).Rows(0)(0).ToString
                            dt.Rows(incre)("CodConceptoR") = Sec
                        End If
                    Next
                    gcConceptos.DataSource = dt

                End If

            End If

            sql = "SELECT CodCuenta AS Codigo,CodCuenta+'-'+NomCuenta AS Descripcion " &
                                           " FROM CT_PlandeCuentas WHERE EsdeMovimiento=1 AND Estado='V'"
            dt = SMT_AbrirTabla(ObjetoApiNomina, sql)

            If dt.Rows.Count > 0 Then

                lkEdit.DataSource = dt
                lkEdit.ValueMember = "Codigo"
                lkEdit.DisplayMember = "Descripcion"

                'lkEdit.PopulateColumns()
                'lkEdit.Columns(0).Visible = False
            End If


            sql = "Select CodConcepto As Codigo, CAST(CodConcepto AS varchar(5))+'-'+NomConcepto As Descripcion From E" + Datos.Seguridad.DatosDeLaEmpresa.NumEmpresa.ToString("000") + Year(Datos.Smt_FechaDeTrabajo()).ToString + "..CT_RetConceptos"
            dt = SMT_AbrirTabla(ObjetoApiNomina, sql)

            If dt.Rows.Count > 0 Then

                lkEdit2.DataSource = dt
                lkEdit2.ValueMember = "Codigo"
                lkEdit2.DisplayMember = "Descripcion"
                'lkEdit2.PopulateColumns()
                'lkEdit2.Columns(0).Visible = False
            End If


            dt = New DataTable
            dt.Columns.Add("Codigo", GetType(String))
            dt.Columns.Add("Descripcion", GetType(String))

            dt.Rows.Add("C", "C")
            dt.Rows.Add("D", "D")
            dt.AcceptChanges()

            If dt.Rows.Count > 0 Then

                lkEdit2Nats.DataSource = dt
                lkEdit2Nats.ValueMember = "Codigo"
                lkEdit2Nats.DisplayMember = "Descripcion"
            End If


        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "LlenaGrillaNominasContratos")
        End Try
    End Sub

    Private Sub LlenaGrillaPefilesCta()
        Try

            Dim dt As New DataTable
            Dim TipoConcepto As String = ""
            Dim sql = "Select *,case Vigente WHEN '1' then 'Si' when '0' then 'No' end As VigenteT from PerfilesCta"

            dt = SMT_AbrirTabla(ObjetoApiNomina, sql)
            gcPerfilesCta.DataSource = dt
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "LlenaGrillaPefilesCta")
        End Try
    End Sub

    Private Sub FrmPerfilesCta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AsignaScriptAcontroles()
        CreaGrillaPerfilesCta()
        CreaGrillaConceptos()
        LlenaGrillaPefilesCta()
        LlenaGrillaConceptosCta()
        AcomodaForm()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarCampos()
    End Sub

    Private Sub LimpiarCampos()
        txtNombre.ValordelControl = ""
        FormadePago.ValordelControl = ""
        grbTipoConcepto.SelectedIndex = 0
        gcConceptos.DataSource = Nothing
        grbVigente.SelectedIndex = 1
        secperfil = ""
        Actualizando = False
        CreaGrillaConceptos()
        LlenaGrillaPefilesCta()
        LlenaGrillaConceptosCta()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try

            If GuardaDatosPerfiles(txtNombre.ValordelControl, FormadePago.ValordelControl) Then
                CreaGrillaConceptos()
                Dim Tbla As DataTable = CType(gcConceptos.DataSource, DataTable)
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
                        If Not ExisteDato("Conceptos_PerfilCta", String.Format("PerfilCta='{0}' And Concepto='{1}'", secperfil, Tbla.Rows(incre)("SecConcepto").ToString), ObjetoApiNomina) Then
                            If Not GuardaDatosConceptos(Tbla.Rows(incre)("SecConcepto").ToString, Tbla.Rows(incre)("CuentaContable").ToString, ConceptoR, ContraPartida, Tbla.Rows(incre)("Naturaleza").ToString, False) Then
                                Exit Sub
                            End If
                        Else
                            If Not GuardaDatosConceptos(Tbla.Rows(incre)("SecConcepto").ToString, Tbla.Rows(incre)("CuentaContable").ToString, ConceptoR, ContraPartida, Tbla.Rows(incre)("Naturaleza").ToString, True) Then
                                Exit Sub
                            End If
                        End If
                    Next
                    LlenaGrillaPefilesCta()
                    HDevExpre.mensajeExitoso("Datos guardados exitosamente!..")
                    LimpiarCampos()
                End If
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "btnGuardar_Click")
        End Try

    End Sub

    Public Function ValidaCamposDatosBasicos() As Boolean
        Dim res As Boolean = False
        If txtNombre.ValordelControl = "" Then
            HDevExpre.MensagedeError("El campo Nombre no puede estar vacío!..")
            txtNombre.Focus()
            res = False
        ElseIf FormadePago.ValordelControl = "" Then
            HDevExpre.MensagedeError("El campo Forma de Pago no puede estar vacío!..")
            txtNombre.Focus()
        Else
            res = True
        End If
        Return res
    End Function

    Private Function GuardaDatosPerfiles(Nombre As String, FormaPago As String) As Boolean
        If ValidaCamposDatosBasicos() Then
            Try
                Dim GenSql_tabPlantillas As New ClGeneraSqlDLL
                GenSql_tabPlantillas.PasoConexionTabla(ObjetoApiNomina, "PerfilesCta")
                GenSql_tabPlantillas.PasoValores("NomPerfilCta", Nombre, TipoDatoActualizaSQL.Cadena)
                GenSql_tabPlantillas.PasoValores("FormaPago", FormaPago, TipoDatoActualizaSQL.Cadena)
                GenSql_tabPlantillas.PasoValores("Vigente", grbVigente.SelectedIndex.ToString, TipoDatoActualizaSQL.Cadena)

                If Not Actualizando Then
                    GenSql_tabPlantillas.PasoValores("Sec", SMT_AbrirTabla(ObjetoApiNomina, "SELECT ISNULL( MAX (Sec),0)+1 AS Codigo FROM PerfilesCta").Rows(0)(0).ToString, TipoDatoActualizaSQL.Cadena)
                    GenSql_tabPlantillas.PasoValores("MovsTercerosIngresos", "1", TipoDatoActualizaSQL.Cadena)
                    GenSql_tabPlantillas.PasoValores("MovsTercerosProvisiones", "1", TipoDatoActualizaSQL.Cadena)
                    GenSql_tabPlantillas.PasoValores("MovsTercerosDeducciones", "1", TipoDatoActualizaSQL.Cadena)
                    GenSql_tabPlantillas.PasoValores("MovsEntidadesIngresos", "0", TipoDatoActualizaSQL.Cadena)
                    GenSql_tabPlantillas.PasoValores("MovsEntidadesProvisiones", "0", TipoDatoActualizaSQL.Cadena)
                    GenSql_tabPlantillas.PasoValores("MovsEntidadesDeducciones", "0", TipoDatoActualizaSQL.Cadena)
                    GenSql_tabPlantillas.PasoValores("MovsEntSeguridadSIngresos", "0", TipoDatoActualizaSQL.Cadena)
                    GenSql_tabPlantillas.PasoValores("MovsEntSeguridadSProvisiones", "0", TipoDatoActualizaSQL.Cadena)
                    GenSql_tabPlantillas.PasoValores("MovsEntSeguridadSDeducciones", "0", TipoDatoActualizaSQL.Cadena)
                    GenSql_tabPlantillas.PasoValores("MovsEntPrestSIngresos", "0", TipoDatoActualizaSQL.Cadena)
                    GenSql_tabPlantillas.PasoValores("MovsEntPrestSProvisiones", "0", TipoDatoActualizaSQL.Cadena)
                    GenSql_tabPlantillas.PasoValores("MovsEntPrestSDeducciones", "0", TipoDatoActualizaSQL.Cadena)
                    GenSql_tabPlantillas.PasoValores("MovsEntAportesParaIngresos", "0", TipoDatoActualizaSQL.Cadena)
                    GenSql_tabPlantillas.PasoValores("MovsEntAportesParaProvisiones", "0", TipoDatoActualizaSQL.Cadena)
                    GenSql_tabPlantillas.PasoValores("MovsEntAportesParaDeducciones", "0", TipoDatoActualizaSQL.Cadena)
                    GenSql_tabPlantillas.PasoValores("MovsEntNominaIngresos", "0", TipoDatoActualizaSQL.Cadena)
                    GenSql_tabPlantillas.PasoValores("MovsEntNominaProvisiones", "0", TipoDatoActualizaSQL.Cadena)
                    GenSql_tabPlantillas.PasoValores("MovsEntNominaDeducciones", "0", TipoDatoActualizaSQL.Cadena)
                    If GenSql_tabPlantillas.EjecutarComandoNET(SQLGenera.Insercion, "") Then
                        secperfil = SMT_AbrirTabla(ObjetoApiNomina, "SELECT ISNULL( MAX (Sec),0) AS Codigo FROM PerfilesCta").Rows(0)(0).ToString
                        Dim Conceptos As DataTable = SMT_AbrirTabla(ObjetoApiNomina, "Select Sec From ConceptosNomina Where Vigente=1")
                        If Conceptos.Rows.Count > 0 Then
                            For incre As Integer = 0 To Conceptos.Rows.Count - 1
                                If Not ExisteDato("Conceptos_PerfilCta", String.Format("PerfilCta='{0}' And Concepto='{1}'", secperfil, Conceptos.Rows(incre)("Sec").ToString), ObjetoApiNomina) Then
                                    GuardaDatosConceptos(Conceptos.Rows(incre)("Sec").ToString, "", "", "", "", False)
                                End If
                            Next
                        End If
                        Return True
                    Else : Return False
                    End If
                Else
                    If GenSql_tabPlantillas.EjecutarComandoNET(SQLGenera.Actualizacion, String.Format("Sec='{0}'", secperfil)) Then
                        Return True
                    Else : Return False
                    End If
                End If
            Catch ex As Exception
                HDevExpre.msgError(ex, ex.Message, "GuardaDatosPerfiles")
                Return False
            End Try
        Else
            Return False
        End If
    End Function

    Private Sub grbVigente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles grbVigente.KeyPress
        HDevExpre.AvanzaConEnter(e)
    End Sub

    Private Sub grbVigente_Enter(sender As Object, e As EventArgs) Handles grbVigente.Enter
        HDevExpre.EntraControlRadioGroup(grbVigente, lblVigente)
    End Sub

    Private Sub grbVigente_Leave(sender As Object, e As EventArgs) Handles grbVigente.Leave
        HDevExpre.SaleControlRadioGroup(grbVigente, lblVigente)
    End Sub

    Private Function GuardaDatosConceptos(Concepto As String, CuentaContable As String, ConceptoR As String, ContraPartida As String, Naturaleza As String, ActualizandoConcepto As Boolean) As Boolean
        Try
            Dim GenSql As New SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL
            GenSql.PasoConexionTabla(ObjetoApiNomina, "Conceptos_PerfilCta")
            GenSql.PasoValores("CuentaContable", CuentaContable, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            GenSql.PasoValores("Naturaleza", Naturaleza, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            If grbTipoConcepto.SelectedIndex = 2 Then
                GenSql.PasoValores("ConceptoR", ConceptoR, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            End If
            If grbTipoConcepto.SelectedIndex = 1 Then
                GenSql.PasoValores("ContraPartida", ContraPartida, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            End If
            If ActualizandoConcepto Then
                If GenSql.EjecutarComandoNET(SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.SQLGenera.Actualizacion, String.Format("PerfilCta={0} and Concepto={1}", secperfil, Concepto)) Then
                    Return True
                Else : Return False
                End If
            Else
                GenSql.PasoValores("Concepto", Concepto, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
                GenSql.PasoValores("PerfilCta", secperfil, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
                GenSql.PasoValores("Sec", SMT_AbrirTabla(ObjetoApiNomina, "SELECT ISNULL( MAX (Sec),0)+1 AS Codigo FROM Conceptos_PerfilCta").Rows(0)(0).ToString, TipoDatoActualizaSQL.Cadena)
                If GenSql.EjecutarComandoNET(SQLGenera.Insercion, "") Then
                    Return True
                Else
                    Return False
                End If
            End If

        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "GuardaDatosConceptos")
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
        CreaGrillaConceptos()
        LlenaGrillaConceptosCta()

    End Sub

    Private Sub gvNominasConceptos_InvalidRowException(sender As Object, e As Views.Base.InvalidRowExceptionEventArgs) Handles gvConceptos.InvalidRowException
        e.WindowCaption = "Mensaje SAMIT SQL"
        e.ErrorText = "Este Concepto no es una retencion..!"
    End Sub

    Private Sub gvNominasConceptos_ValidateRow(sender As Object, e As Views.Base.ValidateRowEventArgs) Handles gvConceptos.ValidateRow
        Dim Tb As DataTable
        Dim NUM As String = gvConceptos.GetFocusedRowCellValue("SecConcepto").ToString
        If grbTipoConcepto.SelectedIndex = 2 Then
            Tb = SMT_AbrirTabla(ObjetoApiNomina, "Select EsRetencion From ConceptosNomina Where Sec=" + NUM)
            Dim Sec As String = Tb.Rows(0)(0).ToString
            If Sec = "True" Then

            Else
                If gvConceptos.GetFocusedRowCellValue("CodConceptoR").ToString <> "" Then
                    'e.ErrorText = "Este Concepto no es una retencion..!"
                    e.Valid = False
                End If
            End If
        End If


    End Sub

    Private Sub gvNominasConceptos_ValidatingEditor(sender As Object, e As BaseContainerValidateEditorEventArgs) Handles gvConceptos.ValidatingEditor
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



    Private Sub gvConceptos_CellValueChanged(sender As Object, e As Views.Base.CellValueChangedEventArgs) Handles gvConceptos.CellValueChanged
        If Actualizando Then


            Dim ConceptoR As String = ""
            Dim ContraPartida As String = ""
            Dim Tbla As DataTable = CType(gcConceptos.DataSource, DataTable)
            If grbTipoConcepto.SelectedIndex = 2 Then
                If Tbla.Rows(e.RowHandle)("CodConceptoR").ToString <> "" Then
                    Dim Sec As String = SMT_AbrirTabla(ObjetoApiNomina, "Select SecConcepto From E" + Datos.Seguridad.DatosDeLaEmpresa.NumEmpresa.ToString("000") + Year(Datos.Smt_FechaDeTrabajo()).ToString + "..CT_RetConceptos Where CodConcepto=" + Tbla.Rows(e.RowHandle)("CodConceptoR").ToString).Rows(0)(0).ToString
                    Tbla.Rows(e.RowHandle)("ConceptoR") = Sec
                    ConceptoR = Tbla.Rows(e.RowHandle)("ConceptoR").ToString
                End If
            End If

            If grbTipoConcepto.SelectedIndex = 1 Then
                If Tbla.Rows(e.RowHandle)("ContraPartida").ToString <> "" Then
                    ContraPartida = Tbla.Rows(e.RowHandle)("ContraPartida").ToString
                End If
            End If
            If Not ExisteDato("Conceptos_PerfilCta", String.Format("PerfilCta='{0}' And Concepto='{1}'", secperfil, Tbla.Rows(e.RowHandle)("SecConcepto").ToString), ObjetoApiNomina) Then
                If Not GuardaDatosConceptos(Tbla.Rows(e.RowHandle)("SecConcepto").ToString, Tbla.Rows(e.RowHandle)("CuentaContable").ToString, ConceptoR, ContraPartida, Tbla.Rows(e.RowHandle)("Naturaleza").ToString, False) Then
                    Exit Sub
                End If
            Else
                If Not GuardaDatosConceptos(Tbla.Rows(e.RowHandle)("SecConcepto").ToString, Tbla.Rows(e.RowHandle)("CuentaContable").ToString, ConceptoR, ContraPartida, Tbla.Rows(e.RowHandle)("Naturaleza").ToString, True) Then
                    Exit Sub
                End If
            End If
        End If
    End Sub

    Private Sub btnCargarPlantilla_Click(sender As Object, e As EventArgs) Handles btnCargarPerfil.Click
        If secperfil <> "" Then
            HDevExpre.MensagedeError("No debe estar seleccionado ningun perfil existente para continuar!")
            Exit Sub
        End If
        If txtNombre.ValordelControl.Trim() = "" Then
            HDevExpre.MensagedeError("El campo Nombre no puede estar vacío!..")
            txtNombre.Focus()
            Exit Sub
        End If

        txtPerfiles.Visible = True

        txtPerfiles.Focus()
        SendKeys.SendWait("{RIGHT}")

        txtPerfiles.Visible = False
    End Sub


    Private Sub txtPlantillaBase_Leave(sender As Object, e As EventArgs) Handles txtPerfiles.Leave
        If txtPerfiles.ValordelControl = "" Then Exit Sub

        Dim Sec = SMT_AbrirTabla(ObjetoApiNomina, "SELECT ISNULL( MAX (Sec),0)+1 AS Codigo FROM  PerfilesCta").Rows(0)(0).ToString
        Dim txtSQL = "Insert into PerfilesCta (sec,NomPerfilCta,Vigente,FormaPago,MovsTercerosIngresos,MovsTercerosProvisiones,MovsTercerosDeducciones,MovsEntidadesIngresos,MovsEntidadesProvisiones,MovsEntidadesDeducciones,MovsEntSeguridadSIngresos,MovsEntSeguridadSProvisiones,MovsEntSeguridadSDeducciones,MovsEntPrestSIngresos,MovsEntPrestSProvisiones,MovsEntPrestSDeducciones,MovsEntAportesParaIngresos,MovsEntAportesParaProvisiones,MovsEntAportesParaDeducciones,MovsEntNominaIngresos,MovsEntNominaProvisiones,MovsEntNominaDeducciones)  
select " + Sec + " as Sec, '" + txtNombre.ValordelControl + "' as NomPerfilCta, Vigente,FormaPago,MovsTercerosIngresos,MovsTercerosProvisiones,MovsTercerosDeducciones,MovsEntidadesIngresos,MovsEntidadesProvisiones,MovsEntidadesDeducciones,MovsEntSeguridadSIngresos,MovsEntSeguridadSProvisiones,MovsEntSeguridadSDeducciones,MovsEntPrestSIngresos,MovsEntPrestSProvisiones,MovsEntPrestSDeducciones,MovsEntAportesParaIngresos,MovsEntAportesParaProvisiones,MovsEntAportesParaDeducciones,MovsEntNominaIngresos,MovsEntNominaProvisiones,MovsEntNominaDeducciones from PerfilesCta where Sec=" + txtPerfiles.ValordelControl
        SMT_EjcutarComandoSql(ObjetoApiNomina, txtSQL, 0)

        txtSQL = "Insert into Conceptos_PerfilCta (Sec,Concepto,CuentaContable,ConceptoR,ContraPartida,PerfilCta,Naturaleza)
Select CC2.maxfila + CC2.fila as Sec, CC.Concepto, CC.CuentaContable, CC.ConceptoR, CC.ContraPartida," + Sec + " as PerfilCta, CC.Naturaleza From Conceptos_PerfilCta CC inner Join
(Select Sec,PerfilCta,Concepto, (select ISNULL( MAX (Sec),0) from Conceptos_PerfilCta) as maxfila, ROW_NUMBER() OVER(ORDER BY sec) AS fila FROM Conceptos_PerfilCta) as CC2 on CC.Sec = CC2.Sec
Where CC.PerfilCta =" + txtPerfiles.ValordelControl
        SMT_EjcutarComandoSql(ObjetoApiNomina, txtSQL, 0)

        LlenaGrillaPefilesCta()
        HDevExpre.mensajeExitoso("Datos guardados exitosamente!..")
        LimpiarCampos()
    End Sub


    Private Sub btnConfigurarMovs_Click(sender As Object, e As EventArgs) Handles btnConfigurarMovs.Click
        If Actualizando Then
            FrmConfigMovs.SecPerfil = secperfil
            If grbTipoConcepto.SelectedIndex = 0 Then
                FrmConfigMovs.TipoConcepto = "Ingresos"
            ElseIf grbTipoConcepto.SelectedIndex = 1 Then
                FrmConfigMovs.TipoConcepto = "Provisiones"
            ElseIf grbTipoConcepto.SelectedIndex = 2 Then
                FrmConfigMovs.TipoConcepto = "Deducciones"
            End If
            FrmConfigMovs.ShowDialog()
            FrmConfigMovs.BringToFront()
        Else
            MsgBox("Debe seleccionar un perfil ya creado!")
        End If

    End Sub
End Class