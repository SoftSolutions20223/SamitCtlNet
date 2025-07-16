Imports System.IO
Imports Newtonsoft.Json.Linq
Imports SamitCore
Imports SamitCoreApi
Imports SamitNominaLogic
Imports SamitCtlNet

Public Class FrmLogin

    ReadOnly _loginController As New LoginController()
    Dim HDevExpre As New HelperDevExpress
    Public Sub New()
        InitializeComponent()
    End Sub

    Dim servidor = "localhost"
    Dim sqlInstance = "SAMITCLOUD"
    Dim terminal = "terminal"
    Dim sysUser = "sysUser"
    Dim empresaslist As List(Of ResponseParamEmpresa)
    Dim oficinaslist As List(Of ResponseParamOficina)
    Dim roleslist As List(Of ResponseParamRol)
    Dim Empresa As New ResponseParamEmpresa
    Dim Oficina As New ResponseParamOficina
    Dim Rol As New ResponseParamRol
    Dim DtEmpresas As New DataTable
    Dim DtOficinas As New DataTable
    Dim DtRoles As New DataTable

    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles btnIniciarSesion.Click
        Dim wait As New ClEspera
        wait.Mostrar()
        wait.Descripcion = "Cargando..."
        btnIniciarSesion.Enabled = False
        Try
            Dim usuario = txbUsuario.Text
            Dim clave = txbClave.Text
            btnIniciarSesion.Enabled = False
            Dim params = Await _loginController.GetParametrosInicioSesion(
                usuario:=usuario,
                clave:=clave,
                servidor:=servidor,
                sqlInstance:=sqlInstance,
                terminal:=terminal,
                sysuser:=sysUser
            )
            DtEmpresas = New DataTable
            DtEmpresas.Columns.Add("Codigo", GetType(Integer))
            DtEmpresas.Columns.Add("Descripcion", GetType(String))
            If IsNothing(params.ObjetoRes.Empresas) Then
                MsgBox("Verifique la conección a internet!.")
                Exit Sub
            End If
            empresaslist = params.ObjetoRes.Empresas.ToList()

            For Each Emp In empresaslist
                Dim fila = DtEmpresas.NewRow
                fila("Codigo") = Emp.Codigo
                fila("Descripcion") = Emp.Nombre
                DtEmpresas.Rows.Add(fila)
            Next
            txtEmpresas.DatosDefecto = DtEmpresas
            ' TODO: debe el usuario poder elegir empresa, oficina y rol

            PanelControl2.Visible = True
            PanelControl1.Visible = False
            txtEmpresas.Focus()
            wait.Terminar()
        Catch ex As Exception
            MsgBox(ex.Message)
            wait.Terminar()
            btnIniciarSesion.Enabled = True
            PanelControl1.Visible = True
            PanelControl2.Visible = False
        End Try
    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PanelControl1.Visible = True
        PanelControl2.Visible = False
        btnIniciarSesion.Enabled = True
        btnContinuar.Enabled = True
        txtEmpresas.ValordelControl = ""
        txtOficinas.ValordelControl = ""
        txtRoles.ValordelControl = ""
        txbUsuario.Focus()
    End Sub

    Private Sub txtEmpresas_Leave(sender As Object, e As EventArgs) Handles txtEmpresas.Leave
        If txtEmpresas.ValordelControl <> "" Then
            For Each Fila In empresaslist
                If Fila.Codigo = CInt(txtEmpresas.ValordelControl) Then
                    DtOficinas = New DataTable
                    DtOficinas.Columns.Add("Codigo", GetType(Integer))
                    DtOficinas.Columns.Add("Descripcion", GetType(String))
                    oficinaslist = Fila.Oficinas
                    For Each ofi In oficinaslist
                        Dim fila2 = DtOficinas.NewRow
                        fila2("Codigo") = ofi.Codigo
                        fila2("Descripcion") = ofi.Nombre
                        DtOficinas.Rows.Add(fila2)
                    Next
                    Empresa = Fila
                    txtOficinas.Enabled = True
                    txtOficinas.DatosDefecto = DtOficinas
                End If
            Next
        End If
    End Sub

    Private Sub txtOficinas_Leave(sender As Object, e As EventArgs) Handles txtOficinas.Leave
        If txtOficinas.ValordelControl <> "" Then
            For Each Fila In oficinaslist
                If Fila.Codigo = CInt(txtOficinas.ValordelControl) Then
                    DtRoles = New DataTable
                    DtRoles.Columns.Add("Codigo", GetType(Integer))
                    DtRoles.Columns.Add("Descripcion", GetType(String))
                    roleslist = Fila.Roles
                    For Each ofi In roleslist
                        Dim fila2 = DtRoles.NewRow
                        fila2("Codigo") = ofi.Codigo
                        fila2("Descripcion") = ofi.Nombre
                        DtRoles.Rows.Add(fila2)
                    Next
                    Oficina = Fila
                    txtRoles.Enabled = True
                    txtRoles.DatosDefecto = DtRoles
                End If
            Next
        End If
    End Sub


    Private Async Sub btnContinuar_Click(sender As Object, e As EventArgs) Handles btnContinuar.Click
        If txtEmpresas.ValordelControl <> "" And txtOficinas.ValordelControl <> "" And txtRoles.ValordelControl <> "" Then
            Dim wait As New ClEspera
            wait.Mostrar()
            wait.Descripcion = "Cargando..."
            btnContinuar.Enabled = False
            Try

                Dim usuario = txbUsuario.Text
                Dim clave = txbClave.Text
                Dim token = Await _loginController.IniciarSesion(
                        usuario:=usuario,
                        clave:=clave,
                        request:=New RequestToken With {
                            .Empresa = Empresa.Codigo,
                            .Oficina = Oficina.Codigo,
                            .Rol = Rol.Codigo,
                            .FechaTrabajo = DateTime.Now,
                            .Servidor = servidor,
                            .SqlInstancia = sqlInstance,
                            .Terminal = terminal,
                            .UsuarioSys = sysUser
                        }
                    )
                btnIniciarSesion.Enabled = True

                Dim Existebd = Await _loginController.Validabd()
                ObjetosNomina.Oficinas = DtOficinas
                ObjetosNomina.Conectar(token.ObjetoRes)
                btnIniciarSesion.Enabled = True
                wait.Terminar()
                btnContinuar.Enabled = True
                Me.Close()

            Catch ex As Exception
                btnContinuar.Enabled = True
                MsgBox(ex.Message)
                wait.Terminar()
            End Try
        End If

    End Sub

    Private Sub txtRoles_Leave(sender As Object, e As EventArgs) Handles txtRoles.Leave
        If txtRoles.ValordelControl <> "" Then
            For Each Fila In roleslist
                If Fila.Codigo = CInt(txtRoles.ValordelControl) Then
                    Rol = Fila
                    btnContinuar.Enabled = True
                End If
            Next
        End If
    End Sub
End Class
