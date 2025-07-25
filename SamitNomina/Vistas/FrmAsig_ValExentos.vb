﻿Imports SamitCtlNet
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraEditors.Repository
Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Controls
Imports SamitNominaLogic

Public Class FrmAsig_ValExentos

    Public Datos As New SamitCtlNet.SamitCtlNet
    Dim lkEdit As New RepositoryItemLookUpEdit
    Dim FormularioAbierto As Boolean = False
    Dim Contrato As String = ""
    Dim CodContrato As String = ""
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
            Dim consultas() As String = {"SELECT Sec as Codigo, Nom as Nombre From ValoresExentos", "Select C.IdContrato as Codigo,CONVERT(varchar(20), E.Identificacion) +': '+RTRIM(LTRIM(RTRIM(LTRIM(E.PNombre)) + ' ' + " +
" RTRIM(LTRIM(E.SNombre)) + ' ' +  RTRIM(LTRIM(E.PApellido)) + ' ' + " +
" RTRIM(LTRIM(E.SApellido)))) As Descripcion FROM Contratos C INNER JOIN Empleados E ON C.Empleado = E.Sec"
}

            Dim Datos = SMT_GetDataset(ObjetoApiNomina, consultas)
            txtValorExento.DatosDefecto = Datos.Tables(0)
            txtContratos.DatosDefecto = Datos.Tables(1)

        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "AsignaScriptAcontroles")
        End Try
    End Sub

    Private Sub CreaGrillaValoresExentos()
        Dim coloor As System.Drawing.Color = Color.White
        gvValoresExentos.Columns.Clear()
        CreaColumnas(gvValoresExentos, "SecValExento", "SecValExento", False, False, "", coloor, False, 0, 0, False)
        CreaColumnas(gvValoresExentos, "Sec", "Sec", False, False, "", coloor, False, 0, 0, False)
        CreaColumnas(gvValoresExentos, "ValorExento", "Valor Exento", True, False, "", coloor, False, 10, gcValoresExentos.Width, False)
        CreaColumnas(gvValoresExentos, "Valor", "Valor", True, True, "", coloor, True, 0, gcValoresExentos.Width, False)
        CreaColumnas(gvValoresExentos, "Vigente", "Vigente", True, False, "", coloor, False, 0, gcValoresExentos.Width, True)
        gvValoresExentos.Appearance.HeaderPanel.Font = New Font("Trebuchet MS", 11.0!, FontStyle.Bold)
        Dim classResize As New ClaseResize
        classResize.Resizagrid(gvValoresExentos)
    End Sub

    Private Sub CreaColumnas(Grid As GridView, Nombre As String, Titulo As String, Visible As Boolean, Editar As Boolean, formula As String, colores As System.Drawing.Color, numerico As Boolean, Porcentaje_Width As Single, TamañoPadre As Single, lke As Boolean)
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
            If lke Then
                .ColumnEdit = lkEdit
                .OptionsColumn.AllowEdit = True
                .OptionsColumn.AllowFocus = True
                .AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
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

    Private Sub AcomodaForm()
        Try
            btnSalir.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.SalirAtras)
            btnLimpiar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Limpiar)
            btnAgregar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Agregar)
            btnEliminar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Eliminar)
            grbVigente.SelectedIndex = 1
            lkEdit.AllowFocused = True
            lkEdit.SearchMode = SearchMode.AutoFilter
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "AcomodaForm Agrega Valores Exentos!")
        End Try
    End Sub

    Private Sub LlenaGrillaValoresExentos()
        Try
            If txtContratos.ValordelControl <> "" Then
                Contrato = txtContratos.ValordelControl
            Else
                Contrato = "0"
            End If
            Dim dt As New DataTable
            Dim sql As String = "Select AVE.Sec As Sec,AVE.Valor As Valor,AVE.ValorExento As SecValExento,VE.Nom As ValorExento,case AVE.Vigente WHEN '1' then 'Si' when '0' then 'No' end As Vigente " +
"From Asig_ValoresExentos AVE INNER JOIN ValoresExentos VE ON AVE.ValorExento = VE.Sec " +
"INNER JOIN Contratos C ON AVE.Contrato = C.CodContrato Where C.IdContrato =" + Contrato

            dt = SMT_AbrirTabla(ObjetoApiNomina, sql)
            gcValoresExentos.DataSource = dt
            If Contrato <> "" And Contrato <> "0" Then
                CodContrato = SMT_AbrirTabla(ObjetoApiNomina, "SELECT CodContrato AS Codigo FROM Contratos Where IdContrato ='" + Contrato + "'").Rows(0)(0).ToString
            End If

            Dim item As New DataTable
            item.Columns.Add("Codigo", GetType(String))
            item.Columns.Add("Descripcion", GetType(String))

            Dim NuevaFila As DataRow = item.NewRow()
            NuevaFila("Codigo") = "No"
            NuevaFila("Descripcion") = "No"
            item.Rows.Add(NuevaFila)
            item.AcceptChanges()

            Dim NuevaFila2 As DataRow = item.NewRow()
            NuevaFila2("Codigo") = "Si"
            NuevaFila2("Descripcion") = "Si"
            item.Rows.Add(NuevaFila2)
            item.AcceptChanges()

            lkEdit.DataSource = item
            lkEdit.ValueMember = "Codigo"
            lkEdit.DisplayMember = "Descripcion"
            lkEdit.PopulateColumns()
            lkEdit.Columns(0).Visible = False


        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "LlenaGrillaAsigValExentos")
        End Try
    End Sub

    Private Sub FrmAggValoresExentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AsignaScriptAcontroles()
        CreaGrillaValoresExentos()
        AcomodaForm()
        LlenaGrillaValoresExentos()
        txtContratos.Focus()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarCampos()
    End Sub

    Private Sub LimpiarCampos()
        txtContratos.ValordelControl = ""
        txtValorExento.ValordelControl = ""
        txtValor.ValordelControl = "0"
        gcValoresExentos.DataSource = Nothing
        LlenaGrillaValoresExentos()
        txtContratos.Focus()
        Contrato = ""
        CodContrato = ""
        grbVigente.SelectedIndex = 1
    End Sub

    Private Sub FrmNominasContratos_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        LimpiarCampos()
    End Sub

    Private Sub gvValoresExentos_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvValoresExentos.CellValueChanged
        Dim Vigente As String = gvValoresExentos.GetFocusedRowCellValue("Vigente").ToString
        If Vigente = "No" Then
            Vigente = "0"
        Else
            Vigente = "1"
        End If
        GuardarDatos(gvValoresExentos.GetFocusedRowCellValue("Sec").ToString, gvValoresExentos.GetFocusedRowCellValue("Valor").ToString, gvValoresExentos.GetFocusedRowCellValue("SecValExento").ToString, Vigente)
    End Sub

    Private Sub btnLimpiar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles btnSalir.KeyPress, btnLimpiar.KeyPress
        HDevExpre.AtrasConScape(e)
    End Sub

    Public Function ValidarCampos() As Boolean

        If txtValorExento.ValordelControl = "" Or txtValorExento.DescripciondelControl = "No Se Encontraron Registros" Or txtValorExento.DescripciondelControl = "" Then
            HDevExpre.MensagedeError("El campo Valor Exento no puede estar vacío ni tener valores invalidos!..")
            txtValorExento.Focus()
            Return False
        ElseIf txtValor.ValordelControl = "" Then
            HDevExpre.MensagedeError("El campo Valor no puede estar vacío!..")
            txtValor.Focus()
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub btnAgg_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If ValidarCampos() Then
            Dim Tbla As DataTable = CType(gcValoresExentos.DataSource, DataTable)
            If Tbla.Rows.Count > 0 Then

                For incre As Integer = 0 To Tbla.Rows.Count - 1
                    If CInt(Tbla.Rows(incre)("SecValExento")) = CInt(Convert.ToInt32(txtValorExento.ValordelControl)) Then
                        HDevExpre.MensagedeError("Este Valor Exento ya se encuentra agregado..!")
                        Exit Sub
                    End If
                Next
            End If
            Dim NuevaFila As DataRow = Tbla.NewRow()

            If GuardarDatos("0", txtValor.ValordelControl, txtValorExento.ValordelControl, grbVigente.SelectedIndex.ToString) Then
                LlenaGrillaValoresExentos()
                txtValorExento.ValordelControl = ""
                txtValor.ValordelControl = ""
                grbVigente.SelectedIndex = 1
                txtValorExento.Focus()
            End If
        End If
    End Sub

    Public Function GuardarDatos(Sec As String, valor As String, valorExento As String, Vigente As String) As Boolean
        Try
            Dim ValExento As New Asig_ValoresExentos
            ValExento.Contrato = CodContrato
            ValExento.Sec = CInt(Sec)
            ValExento.Vigente = Vigente
            ValExento.ValorExento = valorExento
            ValExento.Valor = valor
            Dim RegValExento As New ServiceAsig_ValoresExentos
            Dim registro As DynamicUpsertResponseDto
            If RegValExento.ValidarCampos(ValExento) Then
                registro = RegValExento.UpsertValExento(ValExento)
            End If
            If registro.ErrorCount < 1 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub grbVigente_Enter(sender As Object, e As EventArgs) Handles grbVigente.Enter
        HDevExpre.EntraControlRadioGroup(grbVigente, lblVigente, grbVigente.Font.Size, lblVigente.Font.Size)
        FrmPrincipal.MensajeDeAyuda.Refresh()
        FrmPrincipal.MensajeDeAyuda.Caption = "Estado del Valor Exento. (ENTER)=Avanzar;(ESC,ARB)=Atras"
    End Sub

    Private Sub grbVigente_Leave(sender As Object, e As EventArgs) Handles grbVigente.Leave
        HDevExpre.SaleControlRadioGroup(grbVigente, lblVigente, grbVigente.Font.Size, lblVigente.Font.Size)
        FrmPrincipal.MensajeDeAyuda.Caption = ""
        FrmPrincipal.MensajeDeAyuda.Refresh()
    End Sub
    Private Sub grbVigente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles grbVigente.KeyPress
        HDevExpre.AvanzaConEnter(e)
    End Sub

    Private Sub grbVigente_Click(sender As Object, e As EventArgs) Handles grbVigente.Click
        FrmPrincipal.MensajeDeAyuda.Caption = "Estado del Valor Exento. (ENTER)=Avanzar;(ESC,ARB)=Atras"
        FrmPrincipal.MensajeDeAyuda.Refresh()
    End Sub

    Private Sub txtContratos_Leave(sender As Object, e As EventArgs) Handles txtContratos.Leave
        If txtContratos.ValordelControl = "" Or txtContratos.DescripciondelControl = "No Se Encontraron Registros" Or txtContratos.DescripciondelControl = "" Then
            txtContratos.Focus()
        Else
            LlenaGrillaValoresExentos()
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            Dim Tbla As DataTable = CType(gcValoresExentos.DataSource, DataTable)
            If Tbla.Rows.Count > 0 Then
                If HDevExpre.MsgSamit("Seguro que desea quitar el Valor Exento seleccionado?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.OK Then
                    Dim codigo As String = gvValoresExentos.GetFocusedRowCellValue("Sec").ToString
                    Dim request As New DynamicDeleteRequest With {
                            .Tabla = "Asig_ValoresExentos",
                            .Codigo = CInt(codigo)
                        }
                    ' Ejecutar el procedimiento almacenado
                    Dim resp = SMT_EjecutaProcedimientos(ObjetoApiNomina, "SP_DynamicDelete", request.ToJObject())
                    Dim response = resp.ToObject(Of DynamicDeleteResponse)()

                    ' Procesar respuesta
                    If response.EsExitoso Then
                        Tbla.Rows.Remove(Tbla.Rows(gvValoresExentos.FocusedRowHandle))
                        gcValoresExentos.DataSource = Tbla
                    ElseIf response.EsAdvertencia Then
                        HDevExpre.MensagedeError("Error al eiminar la ValorExento!")
                    Else ' Es Error
                        HDevExpre.MensagedeError("Error al eiminar la ValorExento!")
                    End If

                End If
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "btnEliminar_Click")
        End Try
    End Sub


    Private Sub gvValoresExentos_ValidatingEditor(sender As Object, e As BaseContainerValidateEditorEventArgs) Handles gvValoresExentos.ValidatingEditor
        Dim asf As String = ""
    End Sub
End Class