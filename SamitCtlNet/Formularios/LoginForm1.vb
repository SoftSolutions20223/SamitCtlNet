Imports Microsoft.Win32
Imports SamitCtlNet.SamitCtlNet
Imports System.Drawing
Imports Microsoft.VisualBasic
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.Utils
Imports System.Data.SqlClient
Imports SamitCtlNet.Clseguridad
Imports System.Windows.Forms

Public Class LoginForm1
    Public SiConecto As Boolean
    Private Intentos As Short
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        SiConecto = False
        If SMTConex.State = ConnectionState.Open Then
            MsgBox("Ya Existe una Conexion Abierta a SAMIT SQL", vbCritical, "Mensaje de SAMIT SQL")
            SiConecto = True
            Exit Sub
        End If
        If String.IsNullOrEmpty(TxtUsuario.Text.Trim) Then
            MsgBox("Debe Ingresar un usuario", vbCritical)
            TxtUsuario.Focus()
            Exit Sub
        End If
        If String.IsNullOrEmpty(TxtContraseña.Text.Trim) Then
            MsgBox("Debe Ingresar una Contraseña", vbCritical)
            TxtContraseña.Focus()
            Exit Sub
        End If
        SMTServidor = BotonSrv.Text
        Try
            CadConex = "Data Source=" & BotonSrv.Text & ";Initial Catalog=master" & ";user id = sa; password = " & VGPaswdBD_Seg
            SMTConex.ConnectionString = CadConex
            SMTConex.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Try
            If SMTConex.State = ConnectionState.Open Then
                Dim R As Int16
                SMT_EjcutarComandoSql(SMTConex, "Set dateformat dmy", R)
                SMTLogin = TxtUsuario.Text.Trim
                GUsuario.Login = SMTLogin
                GUsuario.PWD = TxtContraseña.Text
                InicioConexion_Control = True
                If Not ExisteBd(VGRutaBD_Seg) Then
                    MsgBox("No existe la Base Datos de Control", vbCritical)
                    Exit Sub
                End If
                SMT_EjcutarComandoSql(SMTConex, "USE " & VGRutaBD_Seg, VGRetorno)
                If Not Puede_Ingresar_al_Sistema() Then
                    If SMTConex.State = ConnectionState.Open Then SMTConex.Close()
                    GUsuario.PWD = ""
                    GUsuario.Login = ""
                    InicioConexion_Control = False
                    SiConecto = False
                    If Intentos = 4 Then
                        MsgBox("Ya agoto los intentos de ingresar al sistema.. ", vbCritical)
                        SMTConex.Close()
                        Me.Hide()
                    Else
                        Intentos = Intentos + 1
                        Actualizar_Titulo()
                        TxtContraseña.Text = ""
                        TxtContraseña.Focus()
                        Exit Sub
                    End If
                End If
                'SMT_EjcutarComandoSQL(SMTConex, "USE " & VGRutaBD_Seg, VGRetorno)
                'If SMTConex.Database = UCase(VGRutaBD_Seg) Then

                '    If Not SMT_ExisteUsuario(SMTConex, TxtUsuario.Text.Trim, TxtContraseña.Text.Trim) Then
                '        GUsuario.Login = ""
                '        GUsuario.PWD = ""
                '        SMTConex.Close()
                '        Exit Sub
                '    End If
                '    SiConecto = True
                'Else
                '    MsgBox("ERROR en Conexion", vbCritical)

                'End If
            Else
                MsgBox("ERROR en Conexion", vbCritical)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Me.Hide()
    End Sub
    Public Sub Actualizar_Titulo()
        Me.Text = "Ingreso al Sistema.     Intento " & Intentos & " de 4"
    End Sub
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub
    Private Function SMT_ExisteUsuario(Conex As SqlClient.SqlConnection, Login As String, Clave As String) As Boolean
        Dim TxtSQL As String, Tb As DataTable
        SMT_ExisteUsuario = False
        TxtSQL = "Select * from Usuarios Where login = '" & Login & "' and upper(Estado) = 'V'"
        Tb = SMT_AbrirRecordSet(Conex, TxtSQL)

        If Tb.Rows.Count > 0 Then
            If Not Tb(0)("Clave").ToString = Clave Then
                MsgBox("Contraseña No Valida", vbCritical)
                Exit Function
            End If
            SMTNumUsuario = Tb(0)("NumUsuario")
            SMT_ExisteUsuario = True

        Else
            MsgBox("No Existe el Usuario o No esta Vigente", vbCritical)
        End If

        Tb.Dispose()
    End Function

    Private Sub LoginForm1_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        TxtContraseña.Text = ""
        If TxtUsuario.Text <> "" Then
            TxtContraseña.Focus()
        Else
            TxtUsuario.Focus()
        End If
    End Sub


    Private Sub LoginForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Txt As New TextEdit, MisSrv As List(Of String)
        Dim Coleccion As AutoCompleteStringCollection = New AutoCompleteStringCollection
        MisSrv = RegistroSamit.Lista_Servidores_Samit


        VgUsuarioWindows = Environment.UserName
        VgNombreTerminalUsuario = Environment.MachineName
        OK.Image = My.Resources.Apply_32x32
        OK.ImageAlign = ContentAlignment.MiddleLeft
        Cancel.Image = My.Resources.Cancel_32x32
        Cancel.ImageAlign = ContentAlignment.MiddleLeft

        Intentos = 1
        Actualizar_Titulo()
        TxtUsuario.Text = RegistroSamit.UsuarioIngresa

        BotonSrv.Properties.BorderStyle = BorderStyles.Style3D
        BotonSrv.Properties.AppearanceFocused.BackColor = Color.Aquamarine
        BotonSrv.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 13.0F, FontStyle.Bold)
        BotonSrv.Properties.AppearanceFocused.BorderColor = Color.Black
        BotonSrv.Properties.Buttons.Clear()
        BotonSrv.Properties.Buttons.Add(New EditorButton(ButtonPredefines.Glyph, "", -1, True, True, False, HorzAlignment.Default, My.Resources.Zoom_16x16, Nothing, Nothing, Nothing))
        BotonSrv.Text = RegistroSamit.Servidor
        Coleccion.AddRange(MisSrv.ToArray)
        BotonSrv.MaskBox.AutoCompleteCustomSource = Coleccion
        BotonSrv.MaskBox.AutoCompleteSource = AutoCompleteSource.CustomSource
        BotonSrv.MaskBox.AutoCompleteMode = AutoCompleteMode.Suggest

        'BotonSrv.Properties.Buttons(0).Image = My.Resources.Zoom_16x16
        'Controls.Add(BotonSrv)
        'Cargar_Servidores()
    End Sub

    Private Sub LoginForm1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If TxtUsuario.Text <> "" Then
            TxtContraseña.Focus()
        Else
            TxtUsuario.Focus()
        End If
    End Sub

    Private Sub BotonSrv_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles BotonSrv.ButtonClick
        On Error Resume Next
        Dim FrmServidores As New FrmServidores
        If e.Button.Index = 0 Then
            FrmServidores.ShowDialog(Me)
            If FrmServidores.TxtServidor.Text.Trim <> "" Then
                BotonSrv.Text = FrmServidores.TxtServidor.Text.Trim
                SaveSetting("SamitSQL", "Inicio", "Servidor", BotonSrv.Text)
            End If
            FrmServidores.Close()
        End If
    End Sub

    Private Sub TxtUsuario_Enter(sender As Object, e As EventArgs) Handles TxtUsuario.Enter
        TxtUsuario.BorderStyle = BorderStyles.Style3D
        LblUsuario.Font = New System.Drawing.Font("Tahoma", 13.0F, FontStyle.Bold)
        TxtUsuario.SelectionStart = 0
        TxtUsuario.SelectionLength = TxtUsuario.Text.Length
    End Sub

    Private Sub TxtUsuario_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs) Handles TxtUsuario.KeyDown
        ControlTeclas(e.KeyCode)
    End Sub

    Private Sub TxtUsuario_Leave(sender As Object, e As EventArgs) Handles TxtUsuario.Leave
        TxtUsuario.BorderStyle = BorderStyles.Default
        LblUsuario.Font = New System.Drawing.Font("Tahoma", 12.0F, FontStyle.Regular)
    End Sub

    Private Sub TxtContraseña_Enter(sender As Object, e As EventArgs) Handles TxtContraseña.Enter
        TxtContraseña.BorderStyle = BorderStyles.Style3D
        LblPassword.Font = New System.Drawing.Font("Tahoma", 13.0F, FontStyle.Bold)
        TxtContraseña.SelectionStart = 0
        TxtContraseña.SelectionLength = TxtUsuario.Text.Length
    End Sub

    Private Sub TxtContraseña_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs) Handles TxtContraseña.KeyDown
        ControlTeclas(e.KeyCode)
    End Sub

    Private Sub TxtContraseña_Leave(sender As Object, e As System.EventArgs) Handles TxtContraseña.Leave
        TxtContraseña.BorderStyle = BorderStyles.Default
        LblPassword.Font = New System.Drawing.Font("Tahoma", 12.0F, FontStyle.Regular)
    End Sub


    Private Sub BotonSrv_Enter(sender As Object, e As EventArgs) Handles BotonSrv.Enter
        BotonSrv.Font = New System.Drawing.Font("Tahoma", 13.0F, FontStyle.Bold)
        Label1.Font = New System.Drawing.Font("Tahoma", 13.0F, FontStyle.Bold)
        BotonSrv.SelectionStart = 0
        BotonSrv.SelectionLength = BotonSrv.Text.Length
    End Sub

    Private Sub BotonSrv_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs) Handles BotonSrv.KeyDown
        ControlTeclas(e.KeyCode)
    End Sub

    Private Sub BotonSrv_Leave(sender As Object, e As EventArgs) Handles BotonSrv.Leave
        BotonSrv.Font = New System.Drawing.Font("Tahoma", 13.0F, FontStyle.Regular)
        Label1.Font = New System.Drawing.Font("Tahoma", 12.0F, FontStyle.Regular)
    End Sub

    Private Sub OK_Enter(sender As Object, e As EventArgs) Handles OK.Enter
        EntraBoton(DirectCast(sender, System.Windows.Forms.Button))
    End Sub

    Private Sub OK_Leave(sender As Object, e As EventArgs) Handles OK.Leave
        SaleBoton(DirectCast(sender, System.Windows.Forms.Button))
    End Sub
    Private Sub Cancel_Enter(sender As Object, e As EventArgs) Handles Cancel.Enter
        EntraBoton(DirectCast(sender, System.Windows.Forms.Button))
    End Sub

    Private Sub Cancel_Leave(sender As Object, e As EventArgs) Handles Cancel.Leave
        SaleBoton(DirectCast(sender, System.Windows.Forms.Button))
    End Sub

End Class
