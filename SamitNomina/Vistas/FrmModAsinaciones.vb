Imports SamitCtlNet
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraEditors.Repository
Imports System.Data.SqlClient

Public Class FrmModAsinaciones

    Dim FormularioAbierto As Boolean = False
    Dim Datos As New SamitCtlNet.SamitCtlNet
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

            txtCargos.ConsultaSQL = String.Format("SELECT SecCargo AS Codigo,Denominacion As Descripcion FROM  cargos")
            txtDependencia.ConsultaSQL = String.Format("SELECT Sec AS Codigo,NomDependencia As Descripcion FROM  Dependencias where Vigente = 1")
            Dim Empresa As Integer = Datos.Seguridad.DatosDeLaEmpresa.NumEmpresa
            txtOficina.ConsultaSQL = String.Format("SELECT NumOficina AS Codigo,NomOficina As Descripcion FROM SEGURIDAD..Oficinas WHERE Estado='V' AND NumEmpresa={0}", Empresa.ToString)
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "AsignaScriptAcontroles")
        End Try
    End Sub

    Private Sub CreaGrillaAsignaciones()
        Dim coloor As System.Drawing.Color = Color.White
        gvAsignaciones.Columns.Clear()
        HDevExpre.CreaColumnasG(gvAsignaciones, "IdContrato", "Contrato", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 10, gbxPrincipal.Width)
        HDevExpre.CreaColumnasG(gvAsignaciones, "CodContrato", "Contrato", False, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 0, 0)
        HDevExpre.CreaColumnasG(gvAsignaciones, "Valor", "Valor", False, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 0, 0)
        HDevExpre.CreaColumnasG(gvAsignaciones, "IdentificacionEmple", "Identificación Empleado", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 20, gbxPrincipal.Width)
        HDevExpre.CreaColumnasG(gvAsignaciones, "NomEmple", "Nombre Empleado", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 50, gbxPrincipal.Width)
        HDevExpre.CreaColumnasG(gvAsignaciones, "Asignacion", "Asignacion Salarial", True, True, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 20, gbxPrincipal.Width)
        gvAsignaciones.Appearance.HeaderPanel.Font = New Font("Trebuchet MS", 11.0!, FontStyle.Bold)
    End Sub

    Private Sub CreaGrillaAsignacionesCargos()
        Dim coloor As System.Drawing.Color = Color.White
        gvAsignaciones.Columns.Clear()
        HDevExpre.CreaColumnasG(gvAsignaciones, "CodCargo", "Codigo", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 15, gbxPrincipal.Width)
        HDevExpre.CreaColumnasG(gvAsignaciones, "SecCargo", "Sec", False, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 0, 0)
        HDevExpre.CreaColumnasG(gvAsignaciones, "Valor", "Valor", False, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 0, 0)
        HDevExpre.CreaColumnasG(gvAsignaciones, "Denominacion", "Cargo", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 35, gbxPrincipal.Width)
        HDevExpre.CreaColumnasG(gvAsignaciones, "Asignacion", "Asignacion Salarial", True, True, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 50, gbxPrincipal.Width)
        gvAsignaciones.Appearance.HeaderPanel.Font = New Font("Trebuchet MS", 11.0!, FontStyle.Bold)

    End Sub

    Private Sub CreaColumnas(Grid As GridView, Nombre As String, Titulo As String, Visible As Boolean, Editar As Boolean, formula As String, colores As System.Drawing.Color, numerico As Boolean, Porcentaje_Width As Single, TamañoPadre As Single)
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
            btnGuardar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Guardar)
            btnSalir.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.SalirAtras)
            btnLimpiar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Limpiar)
            btnBuscar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Buscar)
            grbTipoConversion.SelectedIndex = 0
            grbTipoMod.SelectedIndex = 0
            txtvalor.ValordelControl = "0"
            Timer1.Enabled = True
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "AcomodaForm Modificar Asignaciones!")
        End Try
    End Sub

    Private Sub LlenaGrillaAsignaciones(Parametros As String)
        Try
            Dim dt As New DataTable
            Dim sql As String = "Select E.Identificacion As IdentificacionEmple, RTRIM(LTRIM(RTRIM(LTRIM(E.PNombre)) + ' ' + " +
            " RTRIM(LTRIM(E.SNombre)) + ' ' +  RTRIM(LTRIM(E.PApellido)) + ' ' + RTRIM(LTRIM(E.SApellido)))) As NomEmple," +
            " C.CodContrato as CodContrato,C.IdContrato as IdContrato,C.Asignacion as Asignacion,C.Asignacion as Valor From Contratos C " +
            " INNER JOIN Empleados E ON E.IdEmpleado = C.Empleado INNER JOIN Contrato_Cargos CC ON C.CargoActual = CC.SecCargos " + Parametros

            dt = SMT_AbrirTabla(ObjetoApiNomina, sql)
            gcAsignaciones.DataSource = dt

        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "LlenaGrillaNominasContratos")
        End Try
    End Sub

    Private Sub LlenaGrillaAsignacionesCargos()
        Try
            Dim dt As New DataTable
            Dim sql As String = "Select Consul.Fecha,CA.Asignacion As Asignacion,CA.Asignacion As Valor, C.SecCargo as SecCargo, C.CodCargo as CodCargo, " +
"C.Denominacion as Denominacion From " +
" cargos C Inner join (Select Max(Fecha) As Fecha,Cargo as Cargo " +
" From Cargo_Asignaciones Group by Cargo) as Consul  ON Consul.Cargo = C.SecCargo " +
" INNER JOIN Cargo_Asignaciones CA ON Consul.Cargo = CA.Cargo And Consul.Fecha = CA.Fecha "

            dt = SMT_AbrirTabla(ObjetoApiNomina, sql)
            gcAsignaciones.DataSource = dt

        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "LlenaGrillaAsignacionesCargos")
        End Try
    End Sub

    Private Sub AsignaMsgAcontroles()
        Try
            txtOficina.MensajedeAyuda = "Seleccione la oficina como parámetro de busqueda.  (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras, (F5,DER)=Buscar"
            txtDependencia.MensajedeAyuda = "Seleccione la dependencia como parámetro de busqueda.  (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras, (F5,DER)=Buscar"
            txtCargos.MensajedeAyuda = "Seleccione el cargo como parámetro de busqueda.  (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras, (F5,DER)=Buscar"
            txtvalor.MensajedeAyuda = "Digite el valor que desea aumentar o disminuir el salario.  (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "AsignaMsgAcontroles")
        End Try
    End Sub

    Private Sub FrmAggAsignaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AsignaScriptAcontroles()
        CreaGrillaAsignaciones()
        AcomodaForm()
        txtOficina.Focus()
        AsignaMsgAcontroles()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarCampos()
        grbTipoMod.SelectedIndex = 0
    End Sub

    Private Sub LimpiarCampos()
        txtOficina.ValordelControl = ""
        txtCargos.ValordelControl = ""
        txtvalor.ValordelControl = ""
        txtDependencia.ValordelControl = ""
        Dim tab As DataTable = CType(gcAsignaciones.DataSource, DataTable)
        If tab Is Nothing Then
        Else
            tab.Rows.Clear()
        End If
        grbTipoConversion.SelectedIndex = 0
        txtOficina.Focus()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim Tbla As DataTable = CType(gcAsignaciones.DataSource, DataTable)
            If Tbla Is Nothing Then
                HDevExpre.MensagedeError("No se han encontrado registros!..")
            Else
                If Tbla.Rows.Count > 0 Then
                    For incre As Integer = 0 To Tbla.Rows.Count - 1
                        Dim Valor As Decimal = CDec(Tbla.Rows(incre)("Asignacion"))
                        If Valor < 0 Then
                            HDevExpre.MensagedeError("Se han encontrado valores negativos en la tabla, por favor verificar!..")
                            Exit Sub
                        End If
                        If grbTipoMod.SelectedIndex = 0 Then
                            Dim fecha As DateTime
                            If Not GuardaDatos(Tbla.Rows(incre)("IdContrato").ToString, Tbla.Rows(incre)("Asignacion").ToString, "", fecha) Then
                                Exit Sub
                            End If
                        Else
                            If Not GuardaDatos("", Tbla.Rows(incre)("Asignacion").ToString, Tbla.Rows(incre)("SecCargo").ToString, CDate(Tbla.Rows(incre)("Fecha"))) Then
                                Exit Sub
                            End If
                        End If

                    Next
                    HDevExpre.mensajeExitoso("Datos guardados exitosamente!..")
                    AsignaScriptAcontroles()
                    LimpiarCampos()
                Else
                    HDevExpre.MensagedeError("No se han encontrado registros!..")
                End If
            End If

        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "btnGuardar_Click")
        End Try
    End Sub

    Private Function GuardaDatos(Contrato As String, Asignacion As String, Cargo As String, fecha As DateTime) As Boolean
        Try
            Dim GenSql As New SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL
            Dim GenSql2 As New SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL
            Dim Tab As String = ""
            If grbTipoMod.SelectedIndex = 0 Then
                GenSql.PasoConexionTabla(ObjetoApiNomina, "Contratos")
                GenSql.PasoValores("Asignacion", Asignacion, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            Else
                GenSql.PasoConexionTabla(ObjetoApiNomina, "Contratos")
                GenSql2.PasoConexionTabla(ObjetoApiNomina, "Cargo_Asignaciones")
                GenSql.PasoValores("Asignacion", Asignacion, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
                GenSql2.PasoValores("Asignacion", Asignacion, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            End If
            If grbTipoMod.SelectedIndex = 0 Then
                If GenSql.EjecutarComandoNET(SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.SQLGenera.Actualizacion, String.Format("IdContrato={0}", Contrato)) Then
                    Return True
                Else : Return False
                End If
            Else
                If GenSql2.EjecutarComandoNET(SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.SQLGenera.Actualizacion, String.Format("Cargo={0} And Fecha='{1:dd/MM/yyyy}'", Cargo, fecha)) Then
                    Dim sql As String = "UPDATE C SET C.Asignacion=@nom From Contratos C INNER JOIN Contrato_Cargos CC ON C.CargoActual = CC.SecCargos Where C.UsaAsginaCargo=1 And CC.Cargo =" + Cargo
                    'Dim cmd As SqlCommand = New SqlCommand(sql, ObjetoApiNomina)
                    'cmd.Parameters.AddWithValue("@nom", Asignacion)
                    'Dim cant As Integer = cmd.ExecuteNonQuery()
                    'If cant < 0 Then
                    '    Return False
                    'Else
                    '    Return True
                    'End If
                Else : Return False
                End If
            End If

        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub FrmNominasContratos_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        LimpiarCampos()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If grbTipoMod.SelectedIndex = 0 Then


            Dim sql As String = ""
            Dim validaparametros As Boolean = False
            If txtOficina.ValordelControl <> "" And txtOficina.DescripciondelControl <> "No Se Encontraron Registros" And txtOficina.DescripciondelControl <> "" Or txtCargos.ValordelControl <> "" And txtCargos.DescripciondelControl <> "No Se Encontraron Registros" And txtCargos.DescripciondelControl <> "" Or txtDependencia.ValordelControl <> "" And txtDependencia.DescripciondelControl <> "No Se Encontraron Registros" And txtDependencia.DescripciondelControl <> "" Then
                sql = "Where C.UsaAsginaCargo=0 "

                If txtOficina.ValordelControl <> "" And txtOficina.DescripciondelControl <> "No Se Encontraron Registros" And txtOficina.DescripciondelControl <> "" Then
                    If Not validaparametros Then
                        sql = sql + " And C.Oficina=" + txtOficina.ValordelControl
                        validaparametros = True
                    Else
                        sql = sql + " And C.Oficina=" + txtOficina.ValordelControl
                    End If
                End If

                If txtCargos.ValordelControl <> "" And txtCargos.DescripciondelControl <> "No Se Encontraron Registros" And txtCargos.DescripciondelControl <> "" Then
                    If Not validaparametros Then
                        validaparametros = True
                        sql = sql + " And CC.Cargo=" + txtCargos.ValordelControl
                    Else
                        sql = sql + " And CC.Cargo=" + txtCargos.ValordelControl
                    End If
                End If

                If txtDependencia.ValordelControl <> "" And txtDependencia.DescripciondelControl <> "No Se Encontraron Registros" And txtDependencia.DescripciondelControl <> "" Then
                    If Not validaparametros Then
                        validaparametros = True
                        sql = sql + " And C.Dependencia=" + txtDependencia.ValordelControl
                    Else
                        sql = sql + " And C.Dependencia=" + txtDependencia.ValordelControl
                    End If
                End If
            Else
                HDevExpre.MensagedeError("Parametros de busqueda incorrectos!..")
            End If
            LlenaGrillaAsignaciones(sql)
        Else
            LlenaGrillaAsignacionesCargos()
        End If

    End Sub

    Private Sub gvAsignaciones_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvAsignaciones.CellValueChanged
        If e.Column.Name = "Asignacion" Then
            Dim Tbla As DataTable = CType(gcAsignaciones.DataSource, DataTable)
            For incre As Integer = 0 To Tbla.Rows.Count - 1
                If grbTipoMod.SelectedIndex = 0 Then
                    If Tbla.Rows(incre)("CodContrato").ToString = gvAsignaciones.GetFocusedRowCellValue("CodContrato").ToString Then
                        Tbla.Rows(incre)("Valor") = e.Value
                    End If
                Else
                    If Tbla.Rows(incre)("SecCargo").ToString = gvAsignaciones.GetFocusedRowCellValue("SecCargo").ToString Then
                        Tbla.Rows(incre)("Valor") = e.Value
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If txtvalor.ValordelControl <> "" Then
            Dim Tbla As DataTable = CType(gcAsignaciones.DataSource, DataTable)
            Dim Valor As Decimal = 0
            If IsNothing(Tbla) Then
            Else
                If Tbla.Rows.Count > 0 Then
                    For incre As Integer = 0 To Tbla.Rows.Count - 1
                        Valor = CDec(Tbla.Rows(incre)("Valor"))
                        If grbTipoConversion.SelectedIndex = 0 Then
                            Valor = Valor + Convert.ToDecimal(txtvalor.ValordelControl)
                            Tbla.Rows(incre)("Asignacion") = Valor
                        Else
                            Valor = (Valor * Convert.ToDecimal(txtvalor.ValordelControl)) / 100 + Valor
                            Tbla.Rows(incre)("Asignacion") = Valor
                        End If
                    Next
                End If
            End If
        End If
    End Sub

    Private Sub txtvalor_Enter(sender As Object, e As EventArgs) Handles txtvalor.Enter

    End Sub

    Private Sub txtvalor_Leave(sender As Object, e As EventArgs) Handles txtvalor.Leave

        If txtvalor.ValordelControl = "" Then
            txtvalor.ValordelControl = "0"
        End If
    End Sub



    Private Sub grbTipoConversion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles grbTipoConversion.SelectedIndexChanged
        Dim Tbla As DataTable = CType(gcAsignaciones.DataSource, DataTable)
        Dim Valor As Decimal = 0
        If Tbla Is Nothing Then
        Else
            If Tbla.Rows.Count > 0 Then
                For incre As Integer = 0 To Tbla.Rows.Count - 1
                    Valor = CDec(Tbla.Rows(incre)("Valor"))
                    If grbTipoConversion.SelectedIndex = 0 Then
                        Valor = Valor + Convert.ToDecimal(txtvalor.ValordelControl)
                        Tbla.Rows(incre)("Asignacion") = Valor
                    Else
                        Valor = (Valor * Convert.ToDecimal(txtvalor.ValordelControl)) / 100 + Valor
                        Tbla.Rows(incre)("Asignacion") = Valor
                    End If
                Next
            End If
        End If
    End Sub

    Private Sub grbTipoConversion_Enter(sender As Object, e As EventArgs) Handles grbTipoConversion.Enter
        HDevExpre.EntraControlRadioGroup(grbTipoConversion, tamañoLetraRG:=grbTipoConversion.Font.Size)
        FrmPrincipal.MensajeDeAyuda.Caption = "Seleccione si el valor será calculado por valor o por porcentaje.  (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
    End Sub
    Private Sub grbTipoConversion_Leave(sender As Object, e As EventArgs) Handles grbTipoConversion.Leave
        HDevExpre.SaleControlRadioGroup(grbTipoConversion, tamañoLetraRG:=grbTipoConversion.Font.Size)
        FrmPrincipal.MensajeDeAyuda.Caption = ""
    End Sub

    Private Sub grbTipoMod_Enter(sender As Object, e As EventArgs) Handles grbTipoMod.Enter
        HDevExpre.EntraControlRadioGroup(grbTipoMod, tamañoLetraRG:=grbTipoMod.Font.Size)
        FrmPrincipal.MensajeDeAyuda.Caption = "Seleccione el tipo de modificacion que desea realizar.  (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
    End Sub
    Private Sub grbTipoMod_Leave(sender As Object, e As EventArgs) Handles grbTipoMod.Leave
        HDevExpre.SaleControlRadioGroup(grbTipoMod, tamañoLetraRG:=grbTipoMod.Font.Size)
        FrmPrincipal.MensajeDeAyuda.Caption = ""
    End Sub

    Private Sub grbTipoMod_KeyPress(sender As Object, e As KeyPressEventArgs) Handles grbTipoMod.KeyPress
        HDevExpre.AvanzaConEnter(e)
    End Sub
    Private Sub grbTipoConversion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles grbTipoConversion.KeyPress
        HDevExpre.AvanzaConEnter(e)
    End Sub

    Private Sub grbTipoMod_SelectedIndexChanged(sender As Object, e As EventArgs) Handles grbTipoMod.SelectedIndexChanged
        If grbTipoMod.SelectedIndex = 0 Then
            LimpiarCampos()
            CreaGrillaAsignaciones()
            txtOficina.Enabled = True
            txtDependencia.Enabled = True
            txtCargos.Enabled = True
        Else
            LimpiarCampos()
            CreaGrillaAsignacionesCargos()
            txtOficina.Enabled = False
            txtDependencia.Enabled = False
            txtCargos.Enabled = False
        End If
    End Sub

    Private Sub btnBuscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles btnSalir.KeyPress, btnLimpiar.KeyPress, btnGuardar.KeyPress, btnBuscar.KeyPress
        HDevExpre.AtrasConScape(e)
    End Sub
End Class