Imports SamitCtlNet
Public Class FrmContratosALiquidar

    Public Datos As New SamitCtlNet.SamitCtlNet
    Dim Formu As String
    Dim Continua As Boolean
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
    Public Property P_Continua() As Boolean
        Get
            Return Continua
        End Get
        Set(value As Boolean)
            Continua = value
        End Set
    End Property

    Private Sub AsignaScriptAcontroles()
        Try
            txtContratos.ConsultaSQL = String.Format(" SELECT Identificacion AS Codigo,RTRIM(LTRIM(RTRIM(LTRIM(PNombre)) + ' ' + " +
" RTRIM(LTRIM(SNombre)) + ' ' +  RTRIM(LTRIM(PApellido)) + ' ' + " +
" RTRIM(LTRIM(SApellido)))) As Descripcion FROM  Empleados")
            txtContratos.RefrescarDatos()
            txtDependencia.ConsultaSQL = String.Format("SELECT Sec AS Codigo,NomDependencia As Descripcion FROM  Dependencias where Vigente = 1")
            txtDependencia.RefrescarDatos()
            txtCargos.ConsultaSQL = String.Format("SELECT SecCargo AS Codigo,Denominacion As Descripcion FROM  cargos")
            txtCargos.RefrescarDatos()
            txtTipoContrato.ConsultaSQL = String.Format("SELECT CodTipo AS Codigo,NomTipo As Descripcion FROM  CAT_TipoContratos")
            txtTipoContrato.RefrescarDatos()
            Dim Empresa As Integer = Datos.Seguridad.DatosDeLaEmpresa.NumEmpresa
            txtOficina.ConsultaSQL = String.Format("SELECT NumOficina AS Codigo,NomOficina As Descripcion FROM SEGURIDAD..Oficinas WHERE Estado='V' AND NumEmpresa={0}", Empresa.ToString)
            txtOficina.RefrescarDatos()
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "AsignaScriptAcontroles")
        End Try
    End Sub

    Private Sub AcomodaForm()
        Try
            MyBase.Text = Formu
            btnAceptar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Aceptar)
            btnCancelar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Cancelar)
            rgTipoLiquida.SelectedIndex = 0
            tplParametros.Visible = False
            txtContratos.Visible = True
            dteFecha.EditValue = Datos.Smt_FechaDelServidor
            txtOficina.Select()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub LimpiarCampos()
        dteFecha.EditValue = Datos.Smt_FechaDelServidor
        rgTipoLiquida.SelectedIndex = 0
        tplParametros.Visible = False
        txtContratos.Visible = True
        txtCargos.ValordelControl = ""
        txtContratos.ValordelControl = ""
        txtDependencia.ValordelControl = ""
        txtTipoContrato.ValordelControl = ""
        txtOficina.ValordelControl = ""
    End Sub

    Public Sub txtOficina_Leave(sender As Object, e As EventArgs) Handles txtOficina.Leave
        If txtOficina.ValordelControl <> "" And txtOficina.DescripciondelControl <> "No Se Encontraron Registros" And txtOficina.DescripciondelControl <> "" Then
            txtContratos.ValordelControl = ""
            txtContratos.ConsultaSQL = String.Format("Select C.IdContrato As Codigo,'Cc:'+CONVERT(VARCHAR,E.Identificacion) +'    Empleado:'+RTRIM(LTRIM(RTRIM(LTRIM(E.PNombre)) + ' ' + " +
" RTRIM(LTRIM(E.SNombre)) + ' ' +  RTRIM(LTRIM(E.PApellido)) + ' ' + RTRIM(LTRIM(E.SApellido)))) As Descripcion " +
" From  Contratos C INNER JOIN  Empleados E ON C.Empleado = E.IdEmpleado WHERE C.Terminado=0 And C.Oficina=" + txtOficina.ValordelControl)
            txtContratos.RefrescarDatos()
        End If
    End Sub

    Public Function ValidaCampos() As Boolean
        If rgTipoLiquida.SelectedIndex = 0 Then
            If txtOficina.ValordelControl = "" Or txtOficina.DescripciondelControl = "No Se Encontraron Registros" Or txtOficina.DescripciondelControl = "" Then
                HDevExpre.MensagedeError("El campo Oficina no puede estar vacío o contener valores invalidos!..")
                txtOficina.Focus()
                Return False
            ElseIf txtContratos.ValordelControl = "" Or txtContratos.DescripciondelControl = "No Se Encontraron Registros" Or txtContratos.DescripciondelControl = "" Then
                HDevExpre.MensagedeError("El campo Contrato no puede estar vacío o contener valores invalidos!..")
                txtContratos.Focus()
                Return False
            Else : Return True
            End If
        Else
            If txtOficina.ValordelControl = "" Or txtOficina.DescripciondelControl = "No Se Encontraron Registros" Or txtOficina.DescripciondelControl = "" Then
                HDevExpre.MensagedeError("El campo Oficina no puede estar vacío o contener valores invalidos!..")
                txtOficina.Focus()
                Return False
            ElseIf txtTipoContrato.ValordelControl = "" Or txtTipoContrato.DescripciondelControl = "No Se Encontraron Registros" Or txtTipoContrato.DescripciondelControl = "" Then
                HDevExpre.MensagedeError("El campo Tipo Contrato no puede estar vacío o contener valores invalidos!..")
                txtTipoContrato.Focus()
                Return False
            Else : Return True
            End If
        End If
    End Function

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If ValidaCampos() Then
            Dim sql As String = ""
            Dim SecTipoContrato As String = ""
            If rgTipoLiquida.SelectedIndex = 0 Then
                If txtContratos.ValordelControl <> "" And txtContratos.DescripciondelControl <> "No Se Encontraron Registros" And txtContratos.DescripciondelControl <> "" Then
                    sql = sql + " C.IdContrato='" + txtContratos.ValordelControl + "'"
                ElseIf txtContratos.ValordelControl <> "" And txtContratos.DescripciondelControl = "No Se Encontraron Registros" Or txtContratos.ValordelControl <> "" And txtContratos.DescripciondelControl = "" Then
                    HDevExpre.MensagedeError("Parametros incorrectos!..")
                    Exit Sub
                End If
                Dim TipoContrato As String = SMT_AbrirTabla(ObjetoApiNomina, "SELECT TipoContrato AS Codigo FROM Contratos Where IdContrato='" + txtContratos.ValordelControl + "'").Rows(0)(0).ToString
                SecTipoContrato = TipoContrato
            Else
                If txtOficina.ValordelControl <> "" And txtOficina.DescripciondelControl <> "No Se Encontraron Registros" And txtOficina.DescripciondelControl <> "" Or txtTipoContrato.ValordelControl <> "" And txtTipoContrato.DescripciondelControl <> "No Se Encontraron Registros" And txtTipoContrato.DescripciondelControl <> "" Or txtDependencia.ValordelControl <> "" And txtDependencia.DescripciondelControl <> "No Se Encontraron Registros" And txtDependencia.DescripciondelControl <> "" Or txtCargos.ValordelControl <> "" And txtCargos.DescripciondelControl <> "No Se Encontraron Registros" And txtCargos.DescripciondelControl <> "" Then
                    sql = " C.Terminado=0 And C.TipoContrato=" + txtTipoContrato.ValordelControl
                    If txtDependencia.ValordelControl <> "" And txtDependencia.DescripciondelControl <> "No Se Encontraron Registros" And txtDependencia.DescripciondelControl <> "" Then
                        sql = sql + " And C.Dependencia=" + txtDependencia.ValordelControl
                    ElseIf txtDependencia.ValordelControl <> "" And txtDependencia.DescripciondelControl = "No Se Encontraron Registros" Or txtDependencia.ValordelControl <> "" And txtDependencia.DescripciondelControl = "" Then
                        HDevExpre.MensagedeError("Parametros incorrectos!..")
                        Exit Sub
                    End If

                    If txtCargos.ValordelControl <> "" And txtCargos.DescripciondelControl <> "No Se Encontraron Registros" And txtCargos.DescripciondelControl <> "" Then
                        sql = sql + " And CC.Cargo=" + txtCargos.ValordelControl
                    ElseIf txtCargos.ValordelControl <> "" And txtCargos.DescripciondelControl = "No Se Encontraron Registros" Or txtCargos.ValordelControl <> "" And txtCargos.DescripciondelControl = "" Then
                        HDevExpre.MensagedeError("Parametros incorrectos!..")
                        Exit Sub
                    End If
                End If
                SecTipoContrato = txtTipoContrato.ValordelControl
            End If
            FrmLiquidarContratos.P_Fecha = dteFecha.DateTime
            FrmLiquidarContratos.P_TipoContrato = SecTipoContrato
            FrmLiquidarContratos.P_Oficina = txtOficina.ValordelControl
            FrmLiquidarContratos.ConsultarLiquidacion("", sql)
            LimpiarCampos()
            MyBase.Close()
        End If
    End Sub

    Private Sub txtCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        LimpiarCampos()
        MyBase.Close()
    End Sub

    Private Sub FmrConsultaLiquidaExtraordinarias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AsignaScriptAcontroles()
        AcomodaForm()
    End Sub

    Private Sub FmrConsultaLiquidaExtraordinarias_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Formu = ""
        LimpiarCampos()
    End Sub

    Private Sub rgTipoLiquida_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rgTipoLiquida.SelectedIndexChanged
        If rgTipoLiquida.SelectedIndex = 0 Then
            tplParametros.Visible = False
            txtContratos.Visible = True
        Else
            tplParametros.Visible = True
            txtContratos.Visible = False
        End If
    End Sub

    Private Sub rgTipoLiquida_Enter(sender As Object, e As EventArgs) Handles rgTipoLiquida.Enter
        HDevExpre.EntraControlRadioGroup(rgTipoLiquida, , rgTipoLiquida.Font.Size, )
        FrmPrincipal.MensajeDeAyuda.Refresh()
        FrmPrincipal.MensajeDeAyuda.Caption = "Tipo de liquidacion a realizar. (ENTER)=Avanzar;(ESC,ARB)=Atras"
    End Sub

    Private Sub rgTipoLiquida_Leave(sender As Object, e As EventArgs) Handles rgTipoLiquida.Leave
        HDevExpre.SaleControlRadioGroup(rgTipoLiquida, , rgTipoLiquida.Font.Size, )
        FrmPrincipal.MensajeDeAyuda.Caption = ""
        FrmPrincipal.MensajeDeAyuda.Refresh()
    End Sub
    Private Sub rgTipoLiquida_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rgTipoLiquida.KeyPress
        HDevExpre.AvanzaConEnter(e)
    End Sub

    Private Sub rgTipoLiquida_Click(sender As Object, e As EventArgs) Handles rgTipoLiquida.Click
        FrmPrincipal.MensajeDeAyuda.Caption = "Tipo de liquidacion a realizar. (ENTER)=Avanzar;(ESC,ARB)=Atras"
        FrmPrincipal.MensajeDeAyuda.Refresh()
    End Sub

End Class