Imports System.ComponentModel
Imports DevExpress.XtraEditors.Controls
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.Utils

Public Class SamitTexto
#Region "Variables"
    Private WithEvents Texto As DevExpress.XtraEditors.TextEdit
    Private _AnchoLbl As Integer
    Private _TextoLabel As String
    Private _ValorInicia As String
    Private _MaximoAncho As Integer
    Private _TextodelControl As String
    Private _ValordelControl As String
    Private _FormatoNumero As String
    Private _TipodeDatos As TipodeDato
    Private _SoloNumeros As Boolean
    Private _ValorMinimo As Decimal
    Private _ValorMaximo As Decimal
    Private _MaxAncholabel As Long
    Private _TipoBusqueda As TipoBusqueda
    Private _AlineacionTitulo As AlinearTexto
    Private _ValorPredeterminado As String
    Private _TieneError As Boolean = False
    Private _EsObligatorio As Boolean
    Private _DatoInvalido As Boolean
    Private _EstaVacio As Boolean
    Private _MensajedeAyuda As String
    Private _SoloLectura As Boolean
    Private _AltodelControl As Integer = 30
    Private _ColordeFondo As Color = Color.Aqua
#End Region
#Region "Propiedades"
    'Propiedades de tiempo de ejecucion
    <Category("SamitPropiedades")>
    Public Property TieneErrorControl As Boolean
        Get
            Return _TieneError
        End Get
        Set(ByVal Valor As Boolean)
            _TieneError = Valor
            If _TieneError = True Then
                Texto.BorderStyle = BorderStyles.Simple
                Texto.Properties.Appearance.BorderColor = Color.Red
            Else
                Texto.BorderStyle = BorderStyles.Default
            End If
        End Set
    End Property
    <Category("SamitPropiedades")>
    Public Property ColordeFondo As Color
        Get
            Return _ColordeFondo
        End Get
        Set(ByVal Valor As Color)
            _ColordeFondo = Valor
            Texto.Properties.AppearanceFocused.BackColor = _ColordeFondo
        End Set
    End Property
    <Category("SamitPropiedades")>
    Public Property AltodelControl As Integer
        Get
            Return _AltodelControl
        End Get
        Set(ByVal Valor As Integer)
            _AltodelControl = Valor
            Me.Height = _AltodelControl
        End Set
    End Property
    <Category("SamitPropiedades")>
    Public Property SoloLectura As Boolean
        Get
            Return _SoloLectura
        End Get
        Set(ByVal Valor As Boolean)
            _SoloLectura = Valor
            Texto.ReadOnly = _SoloLectura

        End Set
    End Property
    <Category("SamitPropiedades")>
    Public Property MensajedeAyuda As String
        Get
            Return _MensajedeAyuda
        End Get
        Set(ByVal Valor As String)
            _MensajedeAyuda = Valor
            Dim Stip As New SuperToolTipSetupArgs
            Stip.Title.Text = "SAMIT SQL " & vbCrLf & "Mensaje del sistema"
            Stip.Title.ImageAlign = ToolTipImageAlignment.Default
            Stip.Title.Image = My.Resources.LogoSamit3
            Stip.Contents.Text = _MensajedeAyuda
            Texto.SuperTip.Setup(Stip)
        End Set
    End Property
    'Propiedades de Diseñador
    <Category("SamitPropiedades")>
    Public Property EsObligatorio As Boolean
        Get
            Return _EsObligatorio
        End Get
        Set(ByVal Valor As Boolean)
            _EsObligatorio = Valor

            If _EsObligatorio Then
                Texto.Properties.Appearance.BackColor = Color.LightYellow
            Else
                Texto.Properties.Appearance.BackColor = Color.White
            End If
        End Set
    End Property
    <Category("SamitPropiedades")>
   <Description("Establece y Devuelve el Valor Mínimo cuando tipo de dato es Númerico")>
    Public Property ValorMinimo As Decimal
        Get
            Return _ValorMinimo
        End Get
        Set(ByVal Valor As Decimal)
            _ValorMinimo = Valor
            TipodeDatos = Me._TipodeDatos
        End Set
    End Property
    <Category("SamitPropiedades")>
       <Description("Establece y Devuelve el Valor Máximo cuando tipo de dato es Númerico")>
    Public Property ValorMaximo As Decimal
        Get
            Return _ValorMaximo
        End Get
        Set(ByVal Valor As Decimal)
            _ValorMaximo = Valor
            TipodeDatos = Me._TipodeDatos
        End Set
    End Property

    <Category("SamitPropiedades")>
    Public Property TipodeDatos As TipodeDato
        Get
            Return _TipodeDatos
        End Get
        Set(ByVal Valor As TipodeDato)
            _TipodeDatos = Valor

            If _TipodeDatos = TipodeDato.Numeros Then
                Me.Texto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
                Me.Texto.Properties.Mask.EditMask = "n0"
            ElseIf _TipodeDatos = TipodeDato.NumerosSinFormato Then
                Me.Texto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
                Me.Texto.Properties.Mask.EditMask = "d"
                Me.Texto.Properties.Mask.UseMaskAsDisplayFormat = True
            ElseIf _TipodeDatos = TipodeDato.NumerosCon_2_Decimales Then
                Me.Texto.Properties.Mask.EditMask = "n2"
                Me.Texto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            ElseIf _TipodeDatos = TipodeDato.NumerosCon_4_Decimales Then
                Me.Texto.Properties.Mask.EditMask = "n4"
                Me.Texto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            ElseIf _TipodeDatos = TipodeDato.Moneda Then
                Me.Texto.Properties.Mask.EditMask = "c0"
                Me.Texto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            ElseIf _TipodeDatos = TipodeDato.MonedaConDEcimales Then
                Me.Texto.Properties.Mask.EditMask = "c2"
                Me.Texto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            ElseIf _TipodeDatos = TipodeDato.Cadena Then
                Me.Texto.Properties.Mask.EditMask = "[a-zA-Z0-9\ñ\Ñ' '_#]*"
                'Me.TextEdit1.Properties.Mask.EditMask = "L*"
                Me.Texto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
            ElseIf _TipodeDatos = TipodeDato.CadenaMayuscula Then
                Me.Texto.Properties.Mask.EditMask = "[A-Z0-9\Ñ' '_#]*"
                Me.Texto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
            End If
            Me.Texto.Properties.Mask.UseMaskAsDisplayFormat = True
        End Set
    End Property
    <Category("SamitPropiedades")>
<Description("Tipo de Letra del Control")>
    Public Property TipodeLetra As Font
        Set(ByVal Valor As Font)
            Texto.Font = Valor
            Titulo.Font = Valor
        End Set
        Get
            Return Texto.Font
        End Get
    End Property
    <Category("SamitPropiedades")>
    Public Property SoloNumeros As Boolean
        Get
            Return _SoloNumeros
        End Get
        Set(ByVal Valor As Boolean)
            _SoloNumeros = Valor
        End Set
    End Property

    <Category("SamitPropiedades")>
    Public Property FormatoNumero As String
        Get
            Return _FormatoNumero
        End Get
        Set(ByVal Valor As String)
            _FormatoNumero = Valor
        End Set
    End Property
    <Category("SamitPropiedades")>
    Public Property AlineacionTexto As AlinearTexto
        Get
            Dim alinea As AlinearTexto
            If Texto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center Then
                alinea = AlinearTexto.Centro
            ElseIf Texto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far Then
                alinea = AlinearTexto.Derecha
            Else
                alinea = AlinearTexto.Izquierda
            End If
            Return alinea
        End Get
        Set(ByVal Valor As AlinearTexto)
            Select Case Valor
                Case AlinearTexto.Izquierda
                    Texto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
                    Texto.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
                Case AlinearTexto.Centro
                    Texto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    Texto.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                Case AlinearTexto.Derecha
                    Texto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                    Texto.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            End Select
        End Set
    End Property
    <Category("SamitPropiedades")>
    Public Property AlineacionTitulo As AlinearTexto
        Get
            Return _AlineacionTitulo
        End Get
        Set(ByVal Valor As AlinearTexto)
            _AlineacionTitulo = Valor
            Select Case _AlineacionTitulo
                Case AlinearTexto.Izquierda
                    Titulo.TextAlign = ContentAlignment.MiddleLeft
                Case AlinearTexto.Centro
                    Titulo.TextAlign = ContentAlignment.MiddleCenter
                Case AlinearTexto.Derecha
                    Titulo.TextAlign = ContentAlignment.MiddleRight
            End Select
        End Set
    End Property
    <Category("SamitPropiedades")>
    <Description("Establece y Devuelve el Valor del Texto Digitado")>
    Public Property TextodelControl As String
        Get
            _TextodelControl = Texto.Text
            Return _TextodelControl
        End Get
        Set(ByVal ValorTxt As String)
            _TextodelControl = ValorTxt
            Texto.Text = _TextodelControl
        End Set
    End Property
    <Category("SamitPropiedades")>
    <Description("Establece y Devuelve el Valor del Texto Digitado")>
    Public Property ValordelControl As String
        Get
            _ValordelControl = Texto.EditValue
            Return _ValordelControl
        End Get
        Set(ByVal ValorTxt As String)
            _ValordelControl = ValorTxt
            Texto.EditValue = _ValordelControl
        End Set
    End Property
    <Category("SamitPropiedades")>
    <Description("Ancho Maximo Texto a Ingresar")>
    Public Property MaximoAncho As Integer
        Get
            Return _MaximoAncho
        End Get
        Set(ByVal Valor As Integer)
            _MaximoAncho = Valor
            Texto.Properties.MaxLength = _MaximoAncho
        End Set
    End Property
    <Category("SamitPropiedades")>
    Public Property AnchoLabel As Integer
        Get
            Return _AnchoLbl
        End Get
        Set(ByVal Valor As Integer)
            _AnchoLbl = Valor
            If _AnchoLbl <= 0 Then _AnchoLbl = 200
            GrpLabel.Width = _AnchoLbl
            SamitBusq_Resize(Nothing, Nothing)
        End Set
    End Property
    <Category("SamitPropiedades")>
    Public Property TextoLabel As String
        Get
            _TextoLabel = Titulo.Text
            Return _TextoLabel
        End Get
        Set(ByVal Valor As String)
            _TextoLabel = Valor
            Titulo.Text = _TextoLabel
            Titulo.AutoSize = True
            Titulo.Font = New System.Drawing.Font(Titulo.Font, FontStyle.Bold)
            _MaxAncholabel = Titulo.Width
            Titulo.Font = New System.Drawing.Font(Titulo.Font, FontStyle.Regular)
            Titulo.AutoSize = False
            Titulo.Width = _MaxAncholabel
            ' TextEdit1.Text = IIf(TextEdit1.Text = "entre", "", "entre")
            Texto.Left = Titulo.Width + 5
            ' Me.Width = Texto.Left + Texto.Width + 5
        End Set
    End Property
    <Category("SamitPropiedades")>
    Public Property ValorPredeterminado As String
        Get
            Return _ValorPredeterminado
        End Get
        Set(ByVal Valor As String)
            _ValorPredeterminado = Valor
        End Set
    End Property
#End Region
#Region "Eventos Propios"
    Public Event MyKeyDownEvent(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    Public Event EntraControl(ByVal sender As System.Object, e As EventArgs)
    Public Event SaleControl(ByVal sender As System.Object, e As EventArgs)
    Public Event PresionaTecla(ByVal sender As System.Object, e As KeyEventArgs)
    Public Event PresionaKey(sender As Object, e As KeyPressEventArgs)
#End Region
#Region "Metodos"
    Public Sub ValidarSamitTxt()
    End Sub
    Public Sub New()
        InitializeComponent()
        AnchoLabel = 200
        AlineacionTitulo = AlinearTexto.Izquierda
        AlineacionTexto = AlinearTexto.Izquierda
    End Sub
    Public Sub EntraralControl()
        Me.Focus()
    End Sub
#End Region
#Region "Eventos Desencadenados"
    Private Sub SamitTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Texto.KeyPress
        RaiseEvent PresionaKey(sender, e)
        If _SoloNumeros Then
            PremiteSoloNumerosConPunto(e)

        End If
    End Sub
    Private Sub SamitTxt_SaleControl(sender As Object, e As EventArgs) Handles Texto.LostFocus
        RaiseEvent SaleControl(sender, e)
    End Sub
    Private Sub SamitTxt_EntraControl(sender As Object, e As EventArgs) Handles Texto.GotFocus
        RaiseEvent EntraControl(sender, e)
    End Sub
    Private Sub SamitTxt_PresionaTecla(sender As Object, e As KeyEventArgs) Handles Texto.KeyDown
        RaiseEvent PresionaTecla(sender, e)
    End Sub
    Private Sub TextEdit1_KeyDown(sender As Object, e As KeyEventArgs) Handles Texto.KeyDown
        On Error Resume Next
        Select Case e.KeyCode
            Case Keys.Escape, Keys.Up
                SendKeys.Send("+{TAB}")
                'e.SuppressKeyPress = True
                Exit Sub
            Case Keys.Down
                SendKeys.Send("{TAB}")
                'e.SuppressKeyPress = True
                Exit Sub
        End Select
        RaiseEvent MyKeyDownEvent(Me, e)
    End Sub

    Private Sub TextEdit1_LostFocus(sender As Object, e As EventArgs) Handles Texto.LostFocus
        'On Error Resume Next

        If _TieneError Then
            Texto.BorderStyle = BorderStyles.Simple
            Texto.Properties.Appearance.BorderColor = Color.Red
        Else
            Texto.BorderStyle = BorderStyles.Default
        End If
        'TextEdit1.BorderStyle = BorderStyles.Default
        Titulo.Font = New System.Drawing.Font(Titulo.Font.Name, Titulo.Font.Size, FontStyle.Regular)
        'TextEdit1.Left = Label.Left + Label.Width + 5
        'Me.Width = TextEdit1.Left + TextEdit1.Width + 5    
        Try
            If MiBarraEstado.GetType Is GetType(System.Windows.Forms.ToolStripStatusLabel) Then
                MiBarraEstado.Text = ""
            ElseIf MiBarraEstado.GetType Is GetType(DevExpress.XtraBars.Ribbon.RibbonStatusBar) Then
                MiBarraEstado.caption = ""
            ElseIf MiBarraEstado.GetType Is GetType(DevExpress.XtraBars.BarStaticItem) Then
                MiBarraEstado.caption = ""
            End If
        Catch ex As Exception
            'MensajedeError(ex.Message)
        End Try
        RevisarInvalido()
    End Sub
    Private Sub RevisarInvalido()
        If _DatoInvalido Then
            ValordelControl = Nothing
        Else
            TieneErrorControl = False
        End If

        If String.IsNullOrEmpty(ValordelControl) Then
            _EstaVacio = True
        Else
            _EstaVacio = False
        End If

        If _EsObligatorio And _EstaVacio Then
            TieneErrorControl = True
        Else
            TieneErrorControl = False
        End If
    End Sub

    Private Sub TextEdit1_GotFocus(sender As Object, e As EventArgs) Handles Texto.GotFocus

        Texto.SelectAll()
        Texto.BorderStyle = BorderStyles.Style3D
        If ColorDeFondoEntraControl <> Color.Black Then
            Texto.Properties.AppearanceFocused.BackColor = ColorDeFondoEntraControl
        End If
        Texto.Properties.AppearanceFocused.Font = Titulo.Font
        Titulo.Font = New System.Drawing.Font(Titulo.Font.Name, Titulo.Font.Size, FontStyle.Bold)
        _TieneError = False
        Try
            If MiBarraEstado.GetType Is GetType(System.Windows.Forms.ToolStripStatusLabel) Then
                MiBarraEstado.Text = _MensajedeAyuda
            ElseIf MiBarraEstado.GetType Is GetType(DevExpress.XtraBars.Ribbon.RibbonStatusBar) Then
                MiBarraEstado.caption = _MensajedeAyuda
            ElseIf MiBarraEstado.GetType Is GetType(DevExpress.XtraBars.BarStaticItem) Then
                MiBarraEstado.caption = _MensajedeAyuda
            End If
        Catch ex As Exception
            'MensajedeError(ex.Message)
        End Try

    End Sub
    Private Sub TextEdit1_Validating(sender As Object, e As CancelEventArgs) Handles Texto.Validating
        ' On Error Resume Next
        If (_ValorMinimo <> 0 Or _ValorMaximo <> 0) And (_ValorMinimo <= _ValorMaximo) And (_TipodeDatos <> TipodeDato.Cadena And _TipodeDatos <> TipodeDato.CadenaMayuscula) Then
            If ValordelControl < _ValorMinimo Or ValordelControl > _ValorMaximo Then
                Texto.Focus()
                Texto.SuperTip.Items.Add("Debe digitar Valores entre " & Format(_ValorMinimo, "n2") & " Y " & Format(_ValorMaximo, "n2"))
                'Windows.Forms.Cursor.Position = New Point(TextEdit1.PointToScreen(0, 0))
                'Windows.Forms.Cursor.Position = New Point(TextEdit1.Site, TextEdit1.Location.Y)
            End If
        End If
    End Sub
    Private Sub SamitBusq_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Try
            GrpLabel.Width = AnchoLabel
        Catch ex As Exception
        End Try
        Try
            'Me.Height = 30
        Catch ex As Exception
        End Try
        Try
            Dim tamaño As Integer = _AnchoLbl + 100
            If Me.Width <= tamaño Then
                Me.Width = tamaño
            End If
        Catch ex As Exception
        End Try
    End Sub
#End Region


    Private Sub Texto_Spin(sender As Object, e As SpinEventArgs) Handles Texto.Spin
        e.Handled = True
    End Sub


End Class
