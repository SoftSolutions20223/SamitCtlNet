Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Imports System.Diagnostics
Imports System.Threading
Partial Public Class Loading
    Inherits Form
    Public Shared trasparente As Boolean
    Public Shared message As String = "Cargando..."
    <StructLayout(LayoutKind.Sequential)> _
    Public Structure Margins
        Public cxLeftWidth As Integer
        Public cxRightWidth As Integer
        Public cyTopHeight As Integer
        Public cyButtomheight As Integer
    End Structure
    <DllImport("dwmapi.dll")> _
    Public Shared Function DwmExtendFrameIntoClientArea(hWnd As IntPtr, ByRef pMarinset As Margins) As Integer
    End Function
    Private Sub Form1_Load(sender As Object, e As EventArgs)
        BackColor = System.Drawing.Color.Black
        Dim margins As New Margins()
        margins.cxLeftWidth = -1
        margins.cxRightWidth = -1
        margins.cyTopHeight = -1
        margins.cyButtomheight = -1
        'set all the four value -1 to apply glass effect to the whole window
        'set your own value to make specific part of the window glassy.
        Dim hwnd As IntPtr = Me.Handle
        Dim result As Integer = DwmExtendFrameIntoClientArea(hwnd, margins)
    End Sub
    Public Sub New()
        InitializeComponent()
        Try
            trasparente = False
            lbtexto.Text = message
            Dim contador As New System.Windows.Forms.Timer()
            contador.Interval = 20
            contador.Enabled = True
            AddHandler contador.Tick, AddressOf contador_Tick
            If trasparente Then
                AddHandler Load, AddressOf Form1_Load
            Else
                lbtexto.ForeColor = Color.Black
            End If

            pbximage.Image = My.Resources.Logos.loader_w
            Me.TopMost = True
        Catch
        End Try
    End Sub
    Private Sub contador_Tick(sender As Object, e As EventArgs)
        lbtexto.Text = message
    End Sub
    'Delegate for cross thread call to close
    Private Delegate Sub CloseDelegate()

    'The type of form to be displayed as the splash screen.
    Private Shared splashForm As Loading

    Public Shared Sub ShowSplashScreen()
        ' Make sure it is only launched once.
        If splashForm IsNot Nothing Then
            Return
        End If
        Dim thread As New Thread(New ThreadStart(AddressOf Loading.ShowForm))
        thread.IsBackground = True
        thread.SetApartmentState(ApartmentState.STA)
        thread.Start()
    End Sub

    Private Shared Sub ShowForm()
        splashForm = New Loading()
        Application.Run(splashForm)
    End Sub

    Shared intentos As Integer = 0
    Public Shared Sub CloseForm()
        Try
            If splashForm IsNot Nothing Then
                splashForm.Invoke(New CloseDelegate(AddressOf Loading.CloseFormInternal))
            End If
        Catch
            If intentos > 10 Then
                intentos = 0
                Exit Sub
            End If
            CloseForm()
        End Try
    End Sub
    Private Shared Sub CloseFormInternal()
        Try
            If splashForm IsNot Nothing Then
                splashForm.Close()
                splashForm = Nothing
            End If
        Catch
        End Try
    End Sub

    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.pbximage = New System.Windows.Forms.PictureBox()
        Me.lbtexto = New System.Windows.Forms.Label()
        CType(Me.pbximage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbximage
        '
        Me.pbximage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbximage.Location = New System.Drawing.Point(9, 8)
        Me.pbximage.Margin = New System.Windows.Forms.Padding(0)
        Me.pbximage.Name = "pbximage"
        Me.pbximage.Size = New System.Drawing.Size(222, 21)
        Me.pbximage.TabIndex = 14
        Me.pbximage.TabStop = False
        Me.pbximage.UseWaitCursor = True
        '
        'lbtexto
        '
        Me.lbtexto.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.lbtexto.ForeColor = System.Drawing.Color.White
        Me.lbtexto.Location = New System.Drawing.Point(12, 29)
        Me.lbtexto.Name = "lbtexto"
        Me.lbtexto.Size = New System.Drawing.Size(219, 17)
        Me.lbtexto.TabIndex = 15
        Me.lbtexto.Text = "Loading..."
        Me.lbtexto.UseWaitCursor = True
        '
        'Loading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(241, 50)
        Me.ControlBox = False
        Me.Controls.Add(Me.lbtexto)
        Me.Controls.Add(Me.pbximage)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "Loading"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Por Favor Espere"
        Me.TopMost = True
        Me.UseWaitCursor = True
        CType(Me.pbximage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private pbximage As System.Windows.Forms.PictureBox
    Public lbtexto As System.Windows.Forms.Label

#End Region
End Class