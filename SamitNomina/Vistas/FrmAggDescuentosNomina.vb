Imports SamitCtlNet
Imports DevExpress.Utils
Imports System.ComponentModel
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraEditors.Controls
Imports System.Data.SqlClient


Public Class FrmAggDescuentosNomina

    Dim dt As DataTable
    Dim Actualizando As Boolean = False
    Dim Sec_DescuentoNomina As String = ""
    Dim Cod_Contrato As String = ""
    Dim Datos As New SamitCtlNet.SamitCtlNet

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

    Private Sub FrmAggDescuentosNomina_Load(sender As Object, e As EventArgs) Handles Me.Load
        AsignaScriptAcontroles()
        AcomodaForm()
        CreaGrilla()
        AsignaMsgAcontroles()
    End Sub



#Region "Eventos Controles"

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub


    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarCampos()
    End Sub
    Private Sub grbVigente_Enter(sender As Object, e As EventArgs) Handles grbVigente.Enter
        HDevExpre.EntraControlRadioGroup(grbVigente, lblVigente, grbVigente.Font.Size, lblVigente.Font.Size)
        FrmPrincipal.MensajeDeAyuda.Refresh()
        FrmPrincipal.MensajeDeAyuda.Caption = "Estado del descuento. (ENTER)=Avanzar;(ESC,ARB)=Atras"
    End Sub

    Private Sub grbVigente_Leave(sender As Object, e As EventArgs) Handles grbVigente.Leave
        HDevExpre.SaleControlRadioGroup(grbVigente, lblVigente, grbVigente.Font.Size, lblVigente.Font.Size)
        FrmPrincipal.MensajeDeAyuda.Caption = ""
        FrmPrincipal.MensajeDeAyuda.Refresh()
    End Sub
    Private Sub grbVigente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles grbVigente.KeyPress, dteFechaIniC.KeyPress, dteFechaFinC.KeyPress
        HDevExpre.AvanzaConEnter(e)
    End Sub
    Private Sub FrmAggDescuentosNomina_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        LimpiarCampos()
    End Sub
    Private Sub grbVigente_Click(sender As Object, e As EventArgs) Handles grbVigente.Click
        FrmPrincipal.MensajeDeAyuda.Caption = "Seleccione el estado del descuento. (ENTER)=Avanzar;(ESC,ARB)=Atras"
        FrmPrincipal.MensajeDeAyuda.Refresh()
    End Sub

    Private Sub txtContrato_Leave(sender As Object, e As EventArgs) Handles txtContrato.Leave
        If txtContrato.ValordelControl = "" Or txtContrato.DescripciondelControl = "No Se Encontraron Registros" Or txtContrato.DescripciondelControl = "" Then

        Else
            Cod_Contrato = SMT_AbrirTabla(ObjetoApiNomina, "SELECT CodContrato AS Codigo FROM Contratos Where IdContrato =" + txtContrato.ValordelControl).Rows(0)(0).ToString
            LlenaGrillaDescuentos()
        End If
    End Sub

    Private Sub txtContrato_Enter(sender As Object, e As EventArgs) Handles txtContrato.Enter
        LimpiarCampos()
    End Sub

    Private Sub dteFechaIniC_Enter(sender As Object, e As EventArgs) Handles dteFechaIniC.Enter
        HDevExpre.EntraControlDateEditDEV(dteFechaIniC, lblFechaIniCc)
        FrmPrincipal.MensajeDeAyuda.Caption = "Fecha desde que aplica el descuento. (ENTER)=Avanzar;(ESC,ARB)=Atras"
    End Sub

    Private Sub dteFechaIniC_Leave(sender As Object, e As EventArgs) Handles dteFechaIniC.Leave
        HDevExpre.SaleControlDateEditDEV(dteFechaIniC, lblFechaIniCc)
        FrmPrincipal.MensajeDeAyuda.Caption = ""
    End Sub

    Private Sub dteFechaFinC_Enter(sender As Object, e As EventArgs) Handles dteFechaFinC.Enter
        HDevExpre.EntraControlDateEditDEV(dteFechaFinC, lblFechaFinCc)
        FrmPrincipal.MensajeDeAyuda.Caption = "Fecha hasta que aplica el descuento. (ENTER)=Avanzar;(ESC,ARB)=Atras"
    End Sub

    Private Sub dteFechaFinC_Leave(sender As Object, e As EventArgs) Handles dteFechaFinC.Leave
        HDevExpre.SaleControlDateEditDEV(dteFechaFinC, lblFechaFinCc)
        FrmPrincipal.MensajeDeAyuda.Caption = ""
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If ValidaCampos() Then
            Dim Descontado As String = txtTotalDescontado.ValordelControl
            Dim LiqP As String = ""
            Dim LiqS As String = ""
            Dim LiqE As String = ""
            Dim LiqC As String = ""
            If ckeLiqPeriodos.Checked Then
                LiqP = "1"
            Else
                LiqP = "0"
            End If
            If ckeLiqSemestres.Checked Then
                LiqS = "1"
            Else
                LiqS = "0"
            End If
            If ckeLiqExtraordinarias.Checked Then
                LiqE = "1"
            Else
                LiqE = "0"
            End If
            'If ckeLiqContratos.Checked Then
            '    LiqC = "1"
            'Else
            '    LiqC = "0"
            'End If
            If Descontado = "" Then
                Descontado = "0"
            End If
             If GuardaDatos(Sec_DescuentoNomina, Cod_Contrato, txtConcepto.ValordelControl, grbVigente.SelectedIndex.ToString, txtTotalDescontar.ValordelControl, txtDescuentoPeriodo.ValordelControl, Descontado, dteFechaIniC.DateTime, dteFechaFinC.DateTime,
                     txtNumCuotas.ValordelControl, txtCuotaInicial.ValordelControl, txtCuotaFinal.ValordelControl, txtCtaContable.ValordelControl, txtDocContable.ValordelControl, txtCuotaActual.ValordelControl, LiqP, LiqS, LiqE, LiqC, Actualizando) Then
                HDevExpre.mensajeExitoso("Información Guardada exitosamente")
                LimpiarCampos()
            Else
                HDevExpre.MensagedeError("Error al guardar los datos!")
            End If
        Else
            Exit Sub
        End If
    End Sub

    Public Function ValidaCampos() As Boolean
        txtCuotaActual.ValordelControl = IIf(txtCuotaActual.ValordelControl = "", "0", txtCuotaActual.ValordelControl)
        txtCuotaFinal.ValordelControl = IIf(txtCuotaFinal.ValordelControl = "", "0", txtCuotaFinal.ValordelControl)
        txtCuotaInicial.ValordelControl = IIf(txtCuotaInicial.ValordelControl = "", "0", txtCuotaInicial.ValordelControl)
        txtNumCuotas.ValordelControl = IIf(txtNumCuotas.ValordelControl = "", "0", txtNumCuotas.ValordelControl)

        txtTotalDescontar.ValordelControl = IIf(txtTotalDescontar.ValordelControl = "", "0", txtTotalDescontar.ValordelControl)
        txtTotalDescontado.ValordelControl = IIf(txtTotalDescontado.ValordelControl = "", "0", txtTotalDescontado.ValordelControl)
        txtDescuentoPeriodo.ValordelControl = IIf(txtDescuentoPeriodo.ValordelControl = "", "0", txtDescuentoPeriodo.ValordelControl)

        Dim NumC As Integer = CInt(txtNumCuotas.ValordelControl)
        Dim NumI As Integer = CInt(txtCuotaInicial.ValordelControl)
        Dim NumF As Integer = CInt(txtCuotaFinal.ValordelControl)
        Dim NumA As Integer = CInt(txtCuotaActual.ValordelControl)

        Dim ValT As Decimal = CDec(txtTotalDescontar.ValordelControl)
        Dim ValD As Decimal = CDec(txtTotalDescontado.ValordelControl)
        Dim ValC As Decimal = CDec(txtDescuentoPeriodo.ValordelControl)

        If txtContrato.ValordelControl = "" Or txtContrato.DescripciondelControl = "No Se Encontraron Registros" Or txtContrato.DescripciondelControl = "" Then
            HDevExpre.MensagedeError("El campo Contrato no puede estar vacío!..")
            txtContrato.Focus()
            Return False
        ElseIf txtConcepto.ValordelControl <> "" And txtConcepto.DescripciondelControl = "No Se Encontraron Registros" Or txtConcepto.ValordelControl <> "" And txtConcepto.DescripciondelControl = "" Or txtConcepto.ValordelControl = "" Then
            HDevExpre.MensagedeError("El campo Concepto no puede contener valores invalidos!..")
            txtConcepto.Focus()
            Return False
        ElseIf dteFechaFinC.DateTime < dteFechaIniC.DateTime Then
            HDevExpre.MensagedeError("La fecha de inicio del Descuento no puede ser superior a la fecha de finalización!..")
            dteFechaFinC.Focus()
            Return False
        ElseIf txtDescuentoPeriodo.ValordelControl = "" Or txtDescuentoPeriodo.ValordelControl = "0" Then
            HDevExpre.MensagedeError("El campo Valor Cuota no puede ser igual a 0!..")
            txtDescuentoPeriodo.Focus()
            Return False
        ElseIf txtNumCuotas.ValordelControl = "" Or txtNumCuotas.ValordelControl = "0" Then
            HDevExpre.MensagedeError("El campo Numero Cuotas no puede ser igual a 0!..")
            txtNumCuotas.Focus()
            Return False
        ElseIf txtCuotaInicial.ValordelControl = "" Or txtCuotaInicial.ValordelControl = "0" Then
            HDevExpre.MensagedeError("El campo Numero Cuota Inicial no puede ser igual a 0!..")
            txtCuotaInicial.Focus()
            Return False
        ElseIf txtCuotaFinal.ValordelControl = "" Or txtCuotaFinal.ValordelControl = "0" Then
            HDevExpre.MensagedeError("El campo Numero Cuota Final no puede ser igual a 0!..")
            txtCuotaFinal.Focus()
            Return False
        ElseIf txtCuotaActual.ValordelControl = "" Or txtCuotaActual.ValordelControl = "0" Then
            HDevExpre.MensagedeError("El campo Numero Cuota Actual no puede ser igual a 0!..")
            txtCuotaActual.Focus()
            Return False
        ElseIf NumC < NumF Then
            HDevExpre.MensagedeError("La cuota final no puede ser mayor al numero de cuotas!..")
            txtCuotaActual.Focus()
            Return False
        ElseIf NumC < NumA Then
            HDevExpre.MensagedeError("La cuota inicial no puede ser mayor al numero de cuotas!..")
            txtCuotaActual.Focus()
            Return False
        ElseIf ValT < ValD Then
            HDevExpre.MensagedeError("El total descontado no puede ser mayor al total a descontar!..")
            txtCuotaActual.Focus()
            Return False
        ElseIf ValT < ValC Then
            HDevExpre.MensagedeError("El valor de la cuota no puede ser mayor al total a descontar!..")
            txtCuotaActual.Focus()
            Return False
        ElseIf txtDocContable.ValordelControl = "" Then
            HDevExpre.MensagedeError("El campo Doc Contable no puede estar vacío!..")
            txtDocContable.Focus()
            Return False
        ElseIf ckeLiqExtraordinarias.Checked = False And ckeLiqPeriodos.Checked = False And ckeLiqSemestres.Checked = False Then
            HDevExpre.MensagedeError("Tiene que seleccionar al menos un tipo de liquidación donde aplicará este descuento!..")
            ckeLiqPeriodos.Focus()
            Return False
        ElseIf txtCtaContable.ValordelControl <> "" And txtCtaContable.DescripciondelControl = "No Se Encontraron Registros" Or txtCtaContable.ValordelControl <> "" And txtCtaContable.DescripciondelControl = "" Then
            HDevExpre.MensagedeError("El campo Cuenta Contable no puede contener valores invalidos!..")
            txtCtaContable.Focus()
            Return False
        ElseIf dteFechaIniC.Text = "" Then
            HDevExpre.MensagedeError("El campo Fecha Inicio no puede estar vacío!..")
            dteFechaIniC.Focus()
            Return False
        ElseIf dteFechaFinC.Text = "" Then
            HDevExpre.MensagedeError("El campo Fecha Fin no puede estar vacío!..")
            dteFechaFinC.Focus()
            Return False
        ElseIf ExisteDato("ConceptosP_Contratos", "Contrato=" + Cod_Contrato + " And Concepto=" + txtConcepto.ValordelControl + " And Vigente='1'", ObjetoApiNomina) And Not Actualizando Then
            HDevExpre.MensagedeError("El contrato cuenta con un descuento vigente del mismo concepto!..")
            txtConcepto.Focus()
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub gvDescuentos_DoubleClick(sender As Object, e As EventArgs) Handles gvDescuentos.DoubleClick
        CargarDatos()
    End Sub

    Private Sub gvDescuentos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles gvDescuentos.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            CargarDatos()
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        EliminaDescuentos()
    End Sub
    Private Sub FrmAggDescuentosNomina_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = ChrW(Keys.Escape) Then
            Me.Close()
        End If
    End Sub

#End Region
#Region "Procedimientos y Funciones"
    Private Sub AcomodaForm()
        Try
            btnGuardar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Guardar)
            btnEliminar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Eliminar)
            btnSalir.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.SalirAtras)
            btnLimpiar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Limpiar)
            btnListaCuotas.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.GenerarPeriodos)
            'ckeLiqContratos.Checked = False
            ckeLiqExtraordinarias.Checked = False
            ckeLiqSemestres.Checked = False
            ckeLiqPeriodos.Checked = True
            txtCuotaActual.Enabled = False
            grbVigente.SelectedIndex = 1
            txtContrato.Select()
            btnListaCuotas.Enabled = False
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "AcomodaForm Agrega Descuentos!")
        End Try
    End Sub

    Private Sub AsignaScriptAcontroles()
        Try

            txtConcepto.ConsultaSQL = String.Format("SELECT Sec AS Codigo,NomConcepto As Descripcion FROM  ConceptosPersonales")
            txtConcepto.RefrescarDatos()
            txtContrato.ConsultaSQL = String.Format("Select C.IdContrato As Codigo,'Cc:'+CONVERT(VARCHAR,E.Identificacion) +'    Empleado:'+RTRIM(LTRIM(RTRIM(LTRIM(E.PNombre)) + ' ' + " +
            " RTRIM(LTRIM(E.SNombre)) + ' ' +  RTRIM(LTRIM(E.PApellido)) + ' ' + RTRIM(LTRIM(E.SApellido)))) As Descripcion " +
            " From  Contratos C INNER JOIN  Empleados E ON C.Empleado = E.IdEmpleado ")
            txtContrato.RefrescarDatos()
            txtCtaContable.ConsultaSQL = "SELECT CodCuenta AS Codigo, NomCuenta AS Descripcion " & _
                           " FROM CT_PlandeCuentas WHERE EsdeMovimiento=1 AND Estado='V' AND Detalla = 'P'"
            txtCtaContable.RefrescarDatos()
            txtCtaContable.MensajedeAyuda = "Digite o Seleccione repsionando (F5) la Cuenta x Pagar"
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "AsignaScriptAcontroles")
        End Try
    End Sub
    Private Sub CreaGrilla()
        Try
            gvDescuentos.Columns.Clear()

            HDevExpre.CreaColumnasG(gvDescuentos, "Sec", "Sec", False, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 0, 0)
            HDevExpre.CreaColumnasG(gvDescuentos, "AplicaLiquidaPeriodos", "AplicaLiquidaPeriodos", False, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 0, 0)
            HDevExpre.CreaColumnasG(gvDescuentos, "AplicaLiquidaSemestres", "AplicaLiquidaSemestres", False, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 0, 0)
            HDevExpre.CreaColumnasG(gvDescuentos, "AplicaLiquidaExtraordinarias", "AplicaLiquidaExtraordinarias", False, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 0, 0)
            HDevExpre.CreaColumnasG(gvDescuentos, "AplicaLiquidaContratos", "AplicaLiquidaContratos", False, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 0, 0)
            HDevExpre.CreaColumnasG(gvDescuentos, "IdContrato", "Contrato", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 5, gbxPrincipal.Width)
            HDevExpre.CreaColumnasG(gvDescuentos, "NomEmple", "Empleado", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 14, gbxPrincipal.Width)
            HDevExpre.CreaColumnasG(gvDescuentos, "NomConcepto", "Concepto", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 14, gbxPrincipal.Width)
            HDevExpre.CreaColumnasG(gvDescuentos, "TotalDescontar", "Total a Descontar", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 8, gbxPrincipal.Width)
            HDevExpre.CreaColumnasG(gvDescuentos, "NumCuotas", "Num Cuotas", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 5, gbxPrincipal.Width)
            HDevExpre.CreaColumnasG(gvDescuentos, "CuotaInicial", "Cuota Inicial", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 7, gbxPrincipal.Width)
            HDevExpre.CreaColumnasG(gvDescuentos, "CuotaFinal", "Cuota Final", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 6, gbxPrincipal.Width)
            HDevExpre.CreaColumnasG(gvDescuentos, "CuotaActual", "Cuota Actual", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 6, gbxPrincipal.Width)
            HDevExpre.CreaColumnasG(gvDescuentos, "DescontarPeriodo", "Descontar por Periodo", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 5, gbxPrincipal.Width)
            HDevExpre.CreaColumnasG(gvDescuentos, "TotalDescontado", "Total Descontado", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 5, gbxPrincipal.Width)
            HDevExpre.CreaColumnasG(gvDescuentos, "DocContable", "Doc Contable", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 5, gbxPrincipal.Width)
            HDevExpre.CreaColumnasG(gvDescuentos, "CtaContable", "Cta Contable", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 5, gbxPrincipal.Width)
            HDevExpre.CreaColumnasG(gvDescuentos, "FechaInicio", "Fecha Inicio", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 5, gbxPrincipal.Width)
            HDevExpre.CreaColumnasG(gvDescuentos, "FechaFin", "Fecha Fin", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 5, gbxPrincipal.Width)
            HDevExpre.CreaColumnasG(gvDescuentos, "Vigente", "Vigente", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 5, gbxPrincipal.Width)
            gvDescuentos.OptionsView.ShowFooter = True
            gvDescuentos.Appearance.HeaderPanel.Font = New Font("Trebuchet MS", 11.0!, FontStyle.Bold)
            gvDescuentos.Columns(5).Summary.Add(DevExpress.Data.SummaryItemType.Count, "", "{0}  Registros")
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "Crea Grilla")
        End Try
    End Sub
    Private Sub LlenaGrillaDescuentos()
        Try
            Dim sql As String = "SELECT DC.AplicaLiquidaContratos,DC.AplicaLiquidaExtraordinarias,DC.AplicaLiquidaSemestres,DC.AplicaLiquidaPeriodos,DC.CuotaActual,DC.NumCuotas,DC.CuotaInicial,DC.CuotaFinal,DC.CtaContable,DC.DocContable,DC.Sec As Sec,RTRIM(LTRIM(RTRIM(LTRIM(E.PNombre)) + ' ' +  " +
                                " RTRIM(LTRIM(E.SNombre)) + ' ' +  RTRIM(LTRIM(E.PApellido)) + ' ' + RTRIM(LTRIM(E.SApellido)))) As NomEmple, " +
                                "C.IdContrato As IdContrato,C.CodContrato As CodContrato,CP.NomConcepto As NomConcepto,CP.Sec As SecConcepto," +
                                "DC.TotalDescontar As TotalDescontar,DC.DescontarPeriodo As DescontarPeriodo,DC.TotalDescontado As TotalDescontado," +
                                "DC.FechaInicio As FechaInicio,DC.FechaFin As FechaFin,case DC.Vigente " +
                                " WHEN '1' then 'Si' when '0' then 'No' end As Vigente FROM ConceptosP_Contratos DC Inner join Contratos C On DC.Contrato = C.CodContrato " +
                                "Inner join ConceptosPersonales CP ON DC.Concepto = CP.Sec Inner join Empleados E ON C.Empleado = E.IdEmpleado Where DC.Contrato=" + Cod_Contrato
            dt = SMT_AbrirTabla(ObjetoApiNomina, sql)
            If dt.Rows.Count > 0 Then
                gcDescuentos.DataSource = dt
            Else
                gcDescuentos.DataSource = Nothing
            End If

        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "LlenaGrillaDescuentos")
        End Try
    End Sub

    Private Sub LimpiarCampos()
        Sec_DescuentoNomina = ""
        Cod_Contrato = ""
        Actualizando = False
        txtContrato.ValordelControl = ""
        txtConcepto.ValordelControl = ""
        txtTotalDescontar.ValordelControl = ""
        txtTotalDescontado.ValordelControl = ""
        txtDescuentoPeriodo.ValordelControl = ""
        txtNumCuotas.ValordelControl = ""
        txtCuotaInicial.ValordelControl = ""
        txtCuotaFinal.ValordelControl = ""
        txtCuotaActual.ValordelControl = ""
        txtDocContable.ValordelControl = ""
        txtCtaContable.ValordelControl = ""
        dteFechaIniC.Text = ""
        dteFechaFinC.Text = ""
        txtCuotaInicial.Enabled = True
        txtTotalDescontado.Enabled = True
        'ckeLiqContratos.Checked = False
        ckeLiqExtraordinarias.Checked = False
        ckeLiqSemestres.Checked = False
        ckeLiqPeriodos.Checked = True
        grbVigente.SelectedIndex = 1
        LlenaGrillaDescuentos()
        txtContrato.Focus()
    End Sub
    Private Function GuardaDatos(SecDescuento As String, Contrato As String, Concepto As String, Vigente As String, TotalADescontar As String, DescontarPeriodo As String, TotalDescontado As String, FechaIni As DateTime, FechaFin As DateTime, NumCuotas As String, CuotaInicial As String, CuotaFinal As String, CtaContable As String, DocContable As String, CuotaActual As String, AplicaP As String, AplicaS As String, AplicaE As String, AplicaC As String, EstaActualizando As Boolean) As Boolean
        Try
            Dim GenSql As New SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL
            GenSql.PasoConexionTabla(ObjetoApiNomina, "ConceptosP_Contratos")
            GenSql.PasoValores("Contrato", Contrato, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            GenSql.PasoValores("Concepto", Concepto, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            GenSql.PasoValores("TotalDescontar", TotalADescontar, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            GenSql.PasoValores("DescontarPeriodo", DescontarPeriodo, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            GenSql.PasoValores("TotalDescontado", TotalDescontado, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            GenSql.PasoValores("FechaInicio", FechaIni.ToString("dd/MM/yyyy"), SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            GenSql.PasoValores("FechaFin", FechaFin.ToString("dd/MM/yyyy"), SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            GenSql.PasoValores("Vigente", Vigente, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            GenSql.PasoValores("NumCuotas", NumCuotas, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            GenSql.PasoValores("CuotaInicial", CuotaInicial, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            GenSql.PasoValores("CuotaFinal", CuotaFinal, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            GenSql.PasoValores("CuotaActual", CuotaActual, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            GenSql.PasoValores("AplicaLiquidaPeriodos", AplicaP, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            GenSql.PasoValores("AplicaLiquidaSemestres", AplicaS, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            GenSql.PasoValores("AplicaLiquidaExtraordinarias", AplicaE, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            GenSql.PasoValores("AplicaLiquidaContratos", "0", SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            GenSql.PasoValores("CtaContable", CtaContable, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            GenSql.PasoValores("DocContable", DocContable, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            If Not EstaActualizando Then
                SecDescuento = SMT_AbrirTabla(ObjetoApiNomina, "SELECT ISNULL( MAX (Sec),0)+1 AS Codigo FROM  ConceptosP_Contratos").Rows(0)(0).ToString
                GenSql.PasoValores("Sec", SecDescuento, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
                If GenSql.EjecutarComandoNET(SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.SQLGenera.Insercion, "") Then
                    Return True
                Else : Return False
                End If
            Else
                If GenSql.EjecutarComandoNET(SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.SQLGenera.Actualizacion, String.Format("Sec={0}", SecDescuento)) Then
                    Return True
                Else : Return False
                End If
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "Guardando DescuentoPorNomina")
            Return False
        End Try
    End Function
    Private Sub CargarDatos()
        Try
            Dim Sql = "Select IsNull(SUM(Tb.Num),0) As NuM From " +
"(Select Count(NLC.Sec) As Num From NominaLiquidadaConceptos NLC Inner Join NominaLiquidadaContratos NLDC On NLC.LiquidadaContrato = NLDC.Sec Inner Join NominaLiquidada NL ON NLDC.NominaLiquidada = NL.Sec Where NL.Estado <>'A' And NLC.SecConceptoP2=" + gvDescuentos.GetFocusedRowCellValue("Sec").ToString + " And NLDC.Contrato =" + Cod_Contrato +
" Union " +
" Select Count(NLC.Sec) As Num From NominaLiquidaExtraordinariaConceptos NLC Inner Join NominaLiquidaExtraordinariaContratos NLDC On NLC.LiquidaContrato = NLDC.Sec Inner Join NominaLiquidaExtraordinaria NL ON NLDC.NominaLiquidaExtraordinaria = NL.Sec Where NL.Estado <>'A' And NLC.SecConceptoP2=" + gvDescuentos.GetFocusedRowCellValue("Sec").ToString + " And NLDC.Contrato =" + Cod_Contrato +
" Union " +
" Select Count(NLC.Sec) As Num From NominaLiquidaSemestresConceptos NLC Inner Join NominaLiquidaSemestresContratos NLDC On NLC.LiquidaContrato = NLDC.Sec Inner Join NominaLiquidaSemestres NL ON NLDC.NominaLiquidaSemestres = NL.Sec Where NL.Estado <>'A' And NLC.SecConceptoP2=" + gvDescuentos.GetFocusedRowCellValue("Sec").ToString + " And NLDC.Contrato =" + Cod_Contrato +
" ) As Tb"
            Dim Registros As Integer = CInt(SMT_AbrirTabla(ObjetoApiNomina, Sql).Rows(0)(0))
            If Registros > 0 Then
                btnListaCuotas.Enabled = True
                txtCuotaInicial.Enabled = False
                txtTotalDescontado.Enabled = False
            Else
                btnListaCuotas.Enabled = False
                txtCuotaInicial.Enabled = True
                txtTotalDescontado.Enabled = True
            End If
            Sec_DescuentoNomina = gvDescuentos.GetFocusedRowCellValue("Sec").ToString
            txtConcepto.ValordelControl = gvDescuentos.GetFocusedRowCellValue("SecConcepto").ToString
            txtTotalDescontar.ValordelControl = gvDescuentos.GetFocusedRowCellValue("TotalDescontar").ToString
            txtDescuentoPeriodo.ValordelControl = gvDescuentos.GetFocusedRowCellValue("DescontarPeriodo").ToString
            txtTotalDescontado.ValordelControl = gvDescuentos.GetFocusedRowCellValue("TotalDescontado").ToString
            txtNumCuotas.ValordelControl = gvDescuentos.GetFocusedRowCellValue("NumCuotas").ToString
            txtCuotaInicial.ValordelControl = gvDescuentos.GetFocusedRowCellValue("CuotaInicial").ToString
            txtCuotaFinal.ValordelControl = gvDescuentos.GetFocusedRowCellValue("CuotaFinal").ToString
            txtCuotaActual.ValordelControl = gvDescuentos.GetFocusedRowCellValue("CuotaActual").ToString
            txtCtaContable.ValordelControl = gvDescuentos.GetFocusedRowCellValue("CtaContable").ToString
            txtDocContable.ValordelControl = gvDescuentos.GetFocusedRowCellValue("DocContable").ToString
            dteFechaIniC.EditValue = gvDescuentos.GetFocusedRowCellValue("FechaInicio")
            dteFechaFinC.EditValue = gvDescuentos.GetFocusedRowCellValue("FechaFin")
            If gvDescuentos.GetFocusedRowCellValue("Vigente").ToString = "Si" Then
                grbVigente.SelectedIndex = 1
            Else
                grbVigente.SelectedIndex = 0
            End If
            If gvDescuentos.GetFocusedRowCellValue("AplicaLiquidaPeriodos").ToString = "True" Then
                ckeLiqPeriodos.Checked = True
            Else
                ckeLiqPeriodos.Checked = False
            End If
            If gvDescuentos.GetFocusedRowCellValue("AplicaLiquidaSemestres").ToString = "True" Then
                ckeLiqSemestres.Checked = True
            Else
                ckeLiqSemestres.Checked = False
            End If
            If gvDescuentos.GetFocusedRowCellValue("AplicaLiquidaExtraordinarias").ToString = "True" Then
                ckeLiqExtraordinarias.Checked = True
            Else
                ckeLiqExtraordinarias.Checked = False
            End If
            'If gvDescuentos.GetFocusedRowCellValue("AplicaLiquidaContratos").ToString = "True" Then
            '    ckeLiqContratos.Checked = True
            'Else
            '    ckeLiqContratos.Checked = False
            'End If
            Actualizando = True
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "Cargar datos")
        End Try
    End Sub
    Private Sub EliminaDescuentos()
        If Not Actualizando Or Sec_DescuentoNomina = "" Then
            HDevExpre.MensagedeError("Debe seleccionar el item que desea editar o eliminar, selecciona con doble clic!")
            Exit Sub
        Else

            If HDevExpre.MsgSamit(String.Format("Seguro que desea eliminar este descuento al contrato [{0}]", Cod_Contrato), MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.OK Then
                If ExisteDato("NominaLiquidaConceptos", "SecConceptoP2=" + Sec_DescuentoNomina, ObjetoApiNomina) Then
                    HDevExpre.MensagedeError("Este descuento se esta aplicando a una liquidacion de periodos, por lo tanto no puede ser eliminado!..")
                    Exit Sub
                End If

                If ExisteDato("NominaLiquidadaConceptos", "SecConceptoP2=" + Sec_DescuentoNomina, ObjetoApiNomina) Then
                    HDevExpre.MensagedeError("Este descuento ya ha sido aplicado en una liquidacion, no puede ser eliminado!..")
                    Exit Sub
                End If

                If ExisteDato("NominaLiquidaExtraordinariaConceptos", "SecConceptoP2=" + Sec_DescuentoNomina, ObjetoApiNomina) Then
                    HDevExpre.MensagedeError("Este descuento ya ha sido aplicado en una liquidacion, no puede ser eliminado!..")
                    Exit Sub
                End If

                If ExisteDato("NominaLiquidaSemestresConceptos", "SecConceptoP2=" + Sec_DescuentoNomina, ObjetoApiNomina) Then
                    HDevExpre.MensagedeError("Este descuento ya ha sido aplicado en una liquidacion, no puede ser eliminado!..")
                    Exit Sub
                End If

                If SMT_EjcutarComandoSqlBool(ObjetoApiNomina, String.Format("DELETE FROM ConceptosP_Contratos WHERE Sec={0}", Sec_DescuentoNomina)) > 0 Then
                    LimpiarCampos()
                Else
                    HDevExpre.MensagedeError("Error al eiminar el descuento!")
                End If
            End If
        End If
    End Sub
    Private Sub AsignaMsgAcontroles()
        Try
            txtContrato.MensajedeAyuda = "Seleccione el contrato. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
            txtConcepto.MensajedeAyuda = "Seleccione le concepto.  (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
            txtTotalDescontar.MensajedeAyuda = "Digite el valor total a descontar.  (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
            txtDescuentoPeriodo.MensajedeAyuda = "Digite el valor a descontar por periodo. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
            txtTotalDescontado.MensajedeAyuda = "Digite el total descontado. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"

        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "AsignaMsgAcontroles")
        End Try
    End Sub
#End Region

    Private Sub ckeLiqContratos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ckeLiqExtraordinarias.KeyPress, ckeLiqPeriodos.KeyPress, ckeLiqSemestres.KeyPress
        HDevExpre.AvanzaConEnter(e)
    End Sub

    Private Sub ckeLiqContratos_Enter(sender As Object, e As EventArgs) Handles ckeLiqExtraordinarias.Enter, ckeLiqPeriodos.Enter, ckeLiqSemestres.Enter
        Try
            Dim ck As DevExpress.XtraEditors.CheckEdit = CType(sender, DevExpress.XtraEditors.CheckEdit)
            ck.Font = New Font(ck.Font.FontFamily, ck.Font.Size, FontStyle.Bold)
            ck.BorderStyle = BorderStyles.HotFlat
            ck.BackColor = Datos.ColordeFondoTxtFoco
            FrmPrincipal.MensajeDeAyuda.Caption = "Para que liquidaciones aplica este descuento?. (ENTER)=Avanzar;(ESC,ARB)=Atras"
            FrmPrincipal.MensajeDeAyuda.Refresh()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ckeLiqContratos_Leave(sender As Object, e As EventArgs) Handles ckeLiqExtraordinarias.Leave, ckeLiqPeriodos.Leave, ckeLiqSemestres.Leave
        Try
            Dim ck As DevExpress.XtraEditors.CheckEdit = CType(sender, DevExpress.XtraEditors.CheckEdit)
            ck.Font = New Font(ck.Font.FontFamily, ck.Font.Size, FontStyle.Regular)
            ck.BorderStyle = BorderStyles.Default
            ck.BackColor = Color.Transparent
            FrmPrincipal.MensajeDeAyuda.Caption = ""
            FrmPrincipal.MensajeDeAyuda.Refresh()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSalir_KeyPress(sender As Object, e As KeyPressEventArgs) Handles btnSalir.KeyPress, btnLimpiar.KeyPress, btnGuardar.KeyPress, btnEliminar.KeyPress
        HDevExpre.AtrasConScape(e)
    End Sub


    Private Sub txtCuotaInicial_Leave(sender As Object, e As EventArgs) Handles txtCuotaInicial.Leave
        txtCuotaActual.ValordelControl = txtCuotaInicial.ValordelControl
    End Sub

    Private Sub btnListaCuotas_Click(sender As Object, e As EventArgs) Handles btnListaCuotas.Click

        Dim sql As String = " Select NL.Sec As Codigo, 'Liquidacion de periodos' As TipoLiquidacion, NLC.Cuota As NumCuota From NominaLiquidadaConceptos NLC Inner Join NominaLiquidadaContratos NLDC On NLC.LiquidadaContrato = NLDC.Sec Inner Join NominaLiquidada NL ON NLDC.NominaLiquidada = NL.Sec Where NL.Estado <>'A' And NLC.SecConceptoP2=" + Sec_DescuentoNomina +
      "  Union " +
" Select NL.Sec As Codigo,'Liquidacion de semestres' As TipoLiquidacion, NLC.Cuota As NumCuota From NominaLiquidaExtraordinariaConceptos NLC Inner Join NominaLiquidaExtraordinariaContratos NLDC On NLC.LiquidaContrato = NLDC.Sec Inner Join NominaLiquidaExtraordinaria NL ON NLDC.NominaLiquidaExtraordinaria = NL.Sec Where NL.Estado <>'A' And NLC.SecConceptoP2=" + Sec_DescuentoNomina +
      "  Union " +
" Select NL.Sec As Codigo,'Liquidacion extraordinaria' As TipoLiquidacion, NLC.Cuota As NumCuota From NominaLiquidaSemestresConceptos NLC Inner Join NominaLiquidaSemestresContratos NLDC On NLC.LiquidaContrato = NLDC.Sec Inner Join NominaLiquidaSemestres NL ON NLDC.NominaLiquidaSemestres = NL.Sec Where NL.Estado <>'A' And NLC.SecConceptoP2=" + Sec_DescuentoNomina
        Dim Frm As New FrmListaCuotas()
        Dim classResize As New ClaseResize
        classResize.Resizamodales(Frm, 60, 60)
        Frm.PStrConsulta = sql
        Frm.ShowDialog()
        Frm.BringToFront()
    End Sub

    Private Sub txtTotalDescontar_Load(sender As Object, e As EventArgs) Handles txtTotalDescontar.Load

    End Sub
End Class