Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.Utils
Imports System.Drawing
Imports System.Windows.Forms


Public Class FrmServidores
    Dim IndiceMod As Long
    Dim EstaModificando As Boolean = False
    Public SrvSeleccionado As String
    Private Sub FrmServidores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtServidor.Properties.BorderStyle = BorderStyles.Style3D
        TxtServidor.Properties.AppearanceFocused.BackColor = Color.Aquamarine
        TxtServidor.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 12.0F, FontStyle.Bold)
        TxtServidor.Properties.AppearanceFocused.BorderColor = Color.Black
        TxtServidor.Properties.Buttons.Clear()
        TxtServidor.Properties.Buttons.Add(New EditorButton(ButtonPredefines.Glyph, "", -1, True, True, False, HorzAlignment.Default, My.Resources.Add_16x16, Nothing, Nothing, Nothing))
        TxtServidor.Properties.Buttons.Add(New EditorButton(ButtonPredefines.Glyph, "", -1, True, True, False, HorzAlignment.Default, My.Resources.Cancel_16x16, Nothing, Nothing, Nothing))
        TxtServidor.Properties.Buttons.Add(New EditorButton(ButtonPredefines.Glyph, "", -1, True, True, False, HorzAlignment.Default, My.Resources.Apply_16x16, Nothing, Nothing, Nothing))
        Me.Text = "Servidores Del Sistema SAMIT SQL"
        Cargar_Servidores()

    End Sub
    Private Sub Cargar_Servidores()
        Dim Servidores(,) As String, intSettings As Integer
        Try
            Servidores = GetAllSettings("SamitSQL", "Servers")
            'limpiar servidores
            LstServidores.Items.Clear()
            If IsNothing(Servidores) Then Exit Sub
            For intSettings = LBound(Servidores, 1) To UBound(Servidores, 1)
                'Servers.AddItem(Servidores(intSettings, 1))
                LstServidores.Items.Add(Servidores(intSettings, 1))
            Next intSettings

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub TxtServidor_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles TxtServidor.ButtonClick
        Select Case e.Button.Index
            Case 0 ' Agregar
                If TxtServidor.Text.Trim <> "" Then
                    GuardarServidor(TxtServidor.Text.Trim, LstServidores.Items.Count + 1)
                    Cargar_Servidores()
                    TxtServidor.Text = ""
                End If

            Case 1 ' Eliminar
                If EstaModificando Then
                    Quitar_Servidor()
                End If
                TxtServidor.Text = ""
                TxtServidor.Focus()
                EstaModificando = False
            Case 2 ' Aceptar
                TxtServidor.Text = LstServidores.Text
                Me.Hide()
        End Select
    End Sub
    Private Sub GuardarServidor(ByVal NewServidor As String, Indice As Integer)
        On Error GoTo ControlError
        Dim Servidores As Object, intSettings As Integer, ExisteServidor As Boolean = False
        If TxtServidor.Text.Trim = "" Then Exit Sub
        Servidores = GetAllSettings("SamitSQL", "Servers")
        If Not IsNothing(Servidores) Then
            If UBound(Servidores) > 0 Then
                For intSettings = LBound(Servidores, 1) To UBound(Servidores, 1)
                    If Servidores(intSettings, 1) = NewServidor Then
                        ExisteServidor = True
                        Exit For
                    End If
                Next intSettings
            End If
        End If
        If Not ExisteServidor Then
            SaveSetting("SamitSQL", "Servers", "Servidor" & Indice, NewServidor)
        End If
        Exit Sub
ControlError:
        MensajedeError()
    End Sub

    Private Function IsEmpty(Servidores As Object) As Boolean
        Throw New NotImplementedException
    End Function


    Public Sub Quitar_Servidor()
        On Error GoTo ControlError
        Dim X As Integer
        LstServidores.Items.RemoveAt(IndiceMod)
        DeleteSetting("SamitSQL", "Servers")
        For X = 0 To LstServidores.Items.Count - 1
            SaveSetting("SamitSQL", "Servers", "Servidor" & X, LstServidores.Items(X).ToString())
        Next X
        Cargar_Servidores()
        Exit Sub
ControlError:
        MensajedeError()
    End Sub

    Private Sub LstServidores_Click(sender As Object, e As EventArgs) Handles LstServidores.Click
        IndiceMod = LstServidores.SelectedIndex
        TxtServidor.Text = LstServidores.Text
        EstaModificando = True
        SrvSeleccionado = TxtServidor.Text
    End Sub

    Private Sub LstServidores_DoubleClick(sender As Object, e As EventArgs) Handles LstServidores.DoubleClick
        TxtServidor.Text = LstServidores.Text
        SrvSeleccionado = TxtServidor.Text
        Me.Hide()
    End Sub

    Private Sub Cancelar_Click(sender As Object, e As EventArgs) Handles Cancelar.Click
        TxtServidor.Text = ""
        Me.Hide()
    End Sub

    Private Sub TxtServidor_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtServidor.KeyDown
        If e.KeyCode = Keys.Enter Then
            If TxtServidor.Text.Trim <> "" Then
                GuardarServidor(TxtServidor.Text.Trim, LstServidores.Items.Count + 1)
                Cargar_Servidores()
                TxtServidor.Text = ""
            End If

        End If
    End Sub

End Class