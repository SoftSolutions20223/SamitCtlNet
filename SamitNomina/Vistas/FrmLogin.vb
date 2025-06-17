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

    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles btnIniciarSesion.Click
        Dim wait As New ClEspera
        wait.Mostrar()
        wait.Descripcion = "Cargando..."
        btnIniciarSesion.Enabled = False
        Try


            Dim usuario = txbUsuario.Text
            Dim clave = txbClave.Text

            Dim servidor = "localhost"
            Dim sqlInstance = "SAMITCLOUD"
            Dim terminal = "terminal"
            Dim sysUser = "sysUser"

            btnIniciarSesion.Enabled = False
            Dim params = Await _loginController.GetParametrosInicioSesion(
                usuario:=usuario,
                clave:=clave,
                servidor:=servidor,
                sqlInstance:=sqlInstance,
                terminal:=terminal,
                sysuser:=sysUser
            )

            ' TODO: debe el usuario poder elegir empresa, oficina y rol
            Dim empresa = params.ObjetoRes.Empresas.First()
            Dim oficina = empresa.Oficinas.First()
            Dim Oficinas = empresa.Oficinas.ToList()
            ObjetosNomina.Oficinas = New DataTable
            ObjetosNomina.Oficinas.Columns.Add("Codigo", GetType(Integer))
            ObjetosNomina.Oficinas.Columns.Add("Descripcion", GetType(String))
            For Each ofi In Oficinas
                Dim fila = ObjetosNomina.Oficinas.NewRow
                fila("Codigo") = ofi.Codigo
                fila("Descripcion") = ofi.Nombre
                ObjetosNomina.Oficinas.Rows.Add(fila)
            Next
            Dim rol = oficina.Roles.First()

            Dim token = Await _loginController.IniciarSesion(
                usuario:=usuario,
                clave:=clave,
                request:=New RequestToken With {
                    .Empresa = empresa.Codigo,
                    .Oficina = oficina.Codigo,
                    .Rol = rol.Codigo,
                    .FechaTrabajo = DateTime.Now,
                    .Servidor = servidor,
                    .SqlInstancia = sqlInstance,
                    .Terminal = terminal,
                    .UsuarioSys = sysUser
                }
            )
            btnIniciarSesion.Enabled = True

            Dim Existebd = Await _loginController.Validabd()

            ObjetosNomina.Conectar(token.ObjetoRes)

            'If token.Resultado = ApiEstado.OK Then
            '    Dim resBancos = SMT_AbrirTabla(ApiClient.Instance, "select 'hola'")

            '    'If resBancos.Resultado = SamitCore.ApiEstado.OK Then
            '    '    Dim listaBancos = resBancos.ObjetoRes
            '    'Else
            '    '    MessageBox.Show(resBancos.DetalleTexto())
            '    'End If
            'End If
            wait.Terminar()
            btnIniciarSesion.Enabled = True
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            wait.Terminar()
            btnIniciarSesion.Enabled = True
        End Try
    End Sub



End Class
