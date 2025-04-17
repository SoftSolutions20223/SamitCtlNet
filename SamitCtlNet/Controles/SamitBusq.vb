Imports System.ComponentModel
Imports DevExpress.XtraEditors.Controls
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Columns

Public Enum TipodeDato
    Ninguno
    Numeros
    NumerosCon_2_Decimales
    NumerosCon_4_Decimales
    NumerosSinFormato
    Moneda
    MonedaConDecimales
    Cadena
    CadenaMayuscula
End Enum
Public Enum AlinearTexto
    Centro
    Izquierda
    Derecha
End Enum
Public Enum ConexionSAMIT
    ConexModulo
    ConexSeguridad
End Enum
Public Class SamitBusq
#Region "Variables"
    Private WithEvents Texto As DevExpress.XtraEditors.TextEdit
    Private _AnchoTxt As Integer
    Private _AnchoLbl As Integer
    Private _TextoLabel As String
    Private _ValorInicia As String
    Private _MaximoAncho As Integer
    Private _TextodelControl As String
    Private _ListaColumnas As List(Of GridColumn)
    Private _ValordelControl As String
    Private _FormatoNumero As String
    Private _CondicionValida As String = ""
    Private _TipodeDatos As TipodeDato
    Private _SoloNumeros As Boolean
    Private _ValorMinimo As Decimal
    Private _ValorMaximo As Decimal
    Private _MaxAncholabel As Long
    Private _ConsultaSQL As String
    Private _TipoBusqueda As TipoBusqueda
    Private _AlineacionTitulo As AlinearTexto
    Private _Datos As DataTable
    Private _DatosDefecto As DataTable
    Private _AutoCargarDatos As Boolean
    Private _DatosCargados As Boolean
    Private _ValorPredeterminado As String
    'Public Shared Conection As SqlConnection
    Private _TieneError As Boolean = False
    Private _EsObligatorio As Boolean
    Private _DatoInvalido As Boolean
    Private _EstaVacio As Boolean
    Private _TerminoCargaDeDatos As Boolean = False
    Private _PendienteAbrirBusqueda As Boolean
    Private _Mensajecargando As String
    Private _PendienteRevisarInvalido As Boolean
    Private _HayUnsoloRegistro As Boolean = False
    Private _PresionoF5 As Boolean = False
    Private _ConexSAMIT As ConexionSAMIT
    Private _MensajedeAyuda As String
    Private _SoloLectura As Boolean
    Private _AltodelControl As Integer = 30
    Private _ColordeFondo As Color = Color.Aqua
    Private _IndiceTab As Integer


#End Region
#Region "Propiedades"
    'Propiedades de tiempo de ejecucion
    <Category("SamitPropiedades")>
    <Description("Es el Mensaje de ayuda del tooltiptext a mostrar en el control")>
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
    <Category("SamitPropiedades")>
    <Description("Altura del Control")>
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
    <Description("Coloca el Control en Modo SoloLectura o ReadOnly (No Permite Cambios)")>
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
    <Description("Devuelve y Establece el Borde en ROJO si tiene Error el Control")>
    Public Property TieneErrorControl As Boolean
        Get
            Return _TieneError
        End Get
        Set(ByVal Valor As Boolean)
            _TieneError = Valor

            If _TieneError = True And Not _PresionoF5 Then
                Texto.BorderStyle = BorderStyles.Simple
                Texto.Properties.Appearance.BorderColor = Color.Red
            Else
                Texto.BorderStyle = BorderStyles.Default
            End If
        End Set
    End Property
    'Propiedades de Diseñador
    <Category("SamitPropiedades")>
    <Description("Esta Propiedad NO HACE NADA Por el Momento")>
    Public Property CondicionValida As String
        Get
            Return _CondicionValida
        End Get
        Set(ByVal Valor As String)
            _CondicionValida = Valor
        End Set
    End Property
    <Category("SamitPropiedades")>
    Public Property EsObligatorio As Boolean
        Get
            Return _EsObligatorio
        End Get
        Set(ByVal Valor As Boolean)
            _EsObligatorio = Valor
        End Set
    End Property

    <Category("SamitPropiedades")>
    Public Property ListaColumnas As List(Of GridColumn)
        Get
            Return _ListaColumnas
        End Get
        Set(ByVal Valor As List(Of GridColumn))
            _ListaColumnas = Valor
        End Set
    End Property

    <Category("SamitPropiedades")>
    <Description("Establece y Devuelve la consulta que ejecutara el formulario de Busqueda, Debe Tener solo 2 Campos: 'Codigo' y 'Descripcion'")>
    Public Property ConsultaSQL As String
        Get
            Return _ConsultaSQL
        End Get
        Set(ByVal Valor As String)
            _ConsultaSQL = Valor
        End Set
    End Property
    <Category("SamitPropiedades")>
    Public Property TipoBusqueda As TipoBusqueda
        Get
            Return _TipoBusqueda
        End Get
        Set(ByVal Valor As TipoBusqueda)
            _TipoBusqueda = Valor
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
    <Description("Establece y Devuelve la Conexion a Utilizar")>
    Public Property Conexion As ConexionSAMIT
        Get
            Return _ConexSAMIT
        End Get
        Set(ByVal Valor As ConexionSAMIT)
            _ConexSAMIT = Valor

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
                Me.Texto.Properties.Mask.EditMask = "#,###,###,###,###"
            ElseIf _TipodeDatos = TipodeDato.NumerosSinFormato Then
                Me.Texto.Properties.Mask.EditMask = ""
                Me.Texto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
                Me.Texto.Properties.Mask.UseMaskAsDisplayFormat = False
            ElseIf _TipodeDatos = TipodeDato.NumerosCon_2_Decimales Then
                Me.Texto.Properties.Mask.EditMask = "n2"
                Me.Texto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            ElseIf _TipodeDatos = TipodeDato.NumerosCon_4_Decimales Then
                Me.Texto.Properties.Mask.EditMask = "n4"
                Me.Texto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            ElseIf _TipodeDatos = TipodeDato.Moneda Then
                Me.Texto.Properties.Mask.EditMask = "c0"
                Me.Texto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            ElseIf _TipodeDatos = TipodeDato.MonedaConDecimales Then
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
                    Titulo.TextAlign = ContentAlignment.TopLeft
                Case AlinearTexto.Centro
                    Titulo.TextAlign = ContentAlignment.TopCenter
                Case AlinearTexto.Derecha
                    Titulo.TextAlign = ContentAlignment.TopRight
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
            Texto.EditValue = ""
            _ValordelControl = ValorTxt
            Texto.EditValue = _ValordelControl
        End Set
    End Property
    <Category("SamitPropiedades")>
    <Description("Devuelve la Descipción de la Busqueda")>
    Public ReadOnly Property DescripciondelControl As String
        Get
            Return Descripcion.Text
        End Get
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
    <Description("Tipo de Letra del Control")>
    Public Property TipodeLetra As Font
        Set(ByVal Valor As Font)
            Texto.Font = Valor
            Titulo.Font = Valor
            Descripcion.Font = Valor
        End Set
        Get
            Return Texto.Font
        End Get
    End Property
    <Category("SamitPropiedades")>
    <Description("Color del fondo del TextEdit")>
    Public Property ColorFondo As Color
        Set(ByVal Valor As Color)
            _ColordeFondo = Valor
            Texto.Properties.AppearanceFocused.BackColor = _ColordeFondo
        End Set
        Get
            Return _ColordeFondo
        End Get
    End Property
    <Category("SamitPropiedades")>
    Public Property AnchoTxt As Integer
        Get
            Return _AnchoTxt
        End Get
        Set(ByVal Valor As Integer)
            _AnchoTxt = Valor
            If _AnchoTxt <= 0 Then _AnchoTxt = 200
            GrpLabel.Width = _AnchoLbl
            GrpTexto.Width = _AnchoTxt
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
            GrpTexto.Width = _AnchoTxt
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
    Public Property AutoCargarDatos As Boolean
        Get
            Return _AutoCargarDatos
        End Get
        Set(ByVal Valor As Boolean)
            _AutoCargarDatos = Valor
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

    <Category("SamitPropiedades")>
    Public Property DatosDefecto As DataTable
        Get
            Return _DatosDefecto
        End Get
        Set(ByVal Valor As DataTable)
            _DatosDefecto = Valor
        End Set
    End Property
#End Region
#Region "Eventos Propios"
    Public Event MyKeyDownEvent(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    Public Event EntraControl(ByVal sender As System.Object, e As EventArgs)
    Public Event SaleControl(ByVal sender As System.Object, e As EventArgs)
    Public Event PresionaTecla(ByVal sender As System.Object, e As KeyEventArgs)
#End Region
#Region "Metodos"
    Public Sub ValidarSamitTxt()
    End Sub
    Public Sub RefrescarDatos()
        ProcesCargarDatos()
    End Sub
    Public Sub New()
        InitializeComponent()
        AnchoLabel = 200
        AnchoTxt = 200
        Me.Height = _AltodelControl
    End Sub
    Private Sub ProcesCargarDatos()
        Dim comando As String = _ConsultaSQL

        If _TipoBusqueda = Global.SamitCtlNet.TipoBusqueda.Ninguna Then
            comando = _ConsultaSQL
        Else
            comando = BusquedaSamit.DefineComando(_TipoBusqueda)
        End If

        Dim datos As New DataTable

        If Not IsNothing(_DatosDefecto) Then
            datos = _DatosDefecto
        Else
            datos = Consultar(comando, True)
        End If

        If datos.Rows.Count = 1 And _EsObligatorio Then
            Texto.Text = datos.Rows(0)(0)
            Descripcion.Text = datos.Rows(0)(1)
            _DatosCargados = True
            _Datos = datos
        ElseIf datos.Rows.Count = 0 Then
            Descripcion.Text = "No Se Encontraron Registros"
            _Datos = Nothing
        ElseIf datos.Rows.Count > 0 Then
            'Descripcion.Text = ""
            Descripcion.Text = "Registros Encontrados " + FormatNumber(datos.Rows.Count, 0)
            _DatosCargados = True
            _Datos = datos
        End If
    End Sub
    Private Sub MostrarResultadoCarga(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs)
        On Error GoTo CtlErr
        _Datos = CType(e.Result, DataTable)
        'TextodelControl = Texto.Tag
        'If TextodelControl = _Mensajecargando Then
        '    TextodelControl = ""
        'End If
        Texto.Enabled = True
        Boton.Enabled = True
        LayoutControl1.Controls.Remove(progreso)
        LayoutControl1.Controls.Add(Descripcion)
        If Not IsNothing(_ValorPredeterminado) Then
            'Texto.Text = _ValorPredeterminado
        End If
        Texto_EditValueChanged(Nothing, Nothing)
        If _PendienteAbrirBusqueda Then
            _PendienteAbrirBusqueda = False
            AbrirBusqueda()
        End If
        If _PendienteRevisarInvalido Then
            _PendienteRevisarInvalido = False
            RevisarInvalido()
        End If
        SiObligatoriohayUnSoloRegistro()

        Exit Sub
CtlErr:
        MensajedeError("MostrarResultadoCarga")

    End Sub
    Dim numeroAleatorio As New Random()
    Dim progreso As ProgressBar = New ProgressBar With {.Style = ProgressBarStyle.Marquee, .MarqueeAnimationSpeed = numeroAleatorio.Next(20, 100)}

    Private Sub AbrirBusqueda()
        On Error GoTo CtlErr
        Dim filtro As String
        If IsNothing(ValordelControl) Then
            filtro = ""
        Else
            filtro = ValordelControl
        End If
        If IsNothing(_Datos) Then
            Exit Sub
        End If
        Dim buscar As BusquedaSamit, Tb As New DataTable, MiFiltro As String = "convert ( " + _Datos.Columns(0).ColumnName + ",'System.String') like '" + filtro + "%'"

        If filtro <> "" Then
            Dim Dv As DataView = New DataView(_Datos, MiFiltro, "", DataViewRowState.CurrentRows)
            Tb = Dv.ToTable
        Else
            Tb = _Datos
        End If
        If _PresionoF5 Then
            RefrescarDatos()
        End If
        buscar = New BusquedaSamit(_TipoBusqueda, ConsultaSQL:=_ConsultaSQL, DatosPrecargados:=Tb, Conexion:=IIf(_ConexSAMIT = ConexionSAMIT.ConexModulo, SMTConexMod, SMTConex), ListaColumns:=ListaColumnas)

        If buscar.ShowDialog() = DialogResult.OK Then
            Texto.Text = buscar.ValorSeleccionado
            Descripcion.Text = buscar.ValorAlternativoDevuelto

            Application.DoEvents()
            buscar = Nothing
            Texto.Select(0, Texto.Text.Length)
        Else
            Texto.Focus()
            Texto.SelectAll()
        End If
        Exit Sub
CtlErr:
        MensajedeError("AbrirBusqueda")
    End Sub
    Public Function Consultar(SQL As String, Optional esSubConsulta As Boolean = False) As DataTable
        Dim Conec As SqlConnection
        If _ConexSAMIT = ConexionSAMIT.ConexModulo Then
            Conec = SMTConexMod
        Else
            Conec = SMTConex
        End If
        If Not Conec.State = ConnectionState.Open Then Return Nothing

        Dim tabla As New DataTable()
        Try
            If esSubConsulta Then
                Try
                    tabla = SMT_AbrirTabla(Conec, SQL)
                Catch ex As Exception
                End Try
            End If
            'datos.Fill(tabla)
            Return tabla
        Catch e As Exception
            MensajedeError(e.Message)
            Return Nothing
        Finally
        End Try

    End Function
#End Region
#Region "Eventos Desencadenados"

    Private Sub SamitBusq_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        _TieneError = False
        Texto.BorderStyle = BorderStyles.Default
        Texto.
            Properties.Appearance.BorderColor = Color.Black
        If Not IsNothing(_ValorPredeterminado) Then
            If _ValorPredeterminado <> "" Then TextodelControl = _ValorPredeterminado
        End If

    End Sub

    Private Sub Texto_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles Texto.HelpRequested

    End Sub

    Private Sub Texto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Texto.KeyPress
        If _SoloNumeros Then
            PremiteSoloNumeros(e)
        End If

    End Sub

    Private Sub SamitTxt_EntraControl(sender As Object, e As EventArgs) Handles Texto.GotFocus
        RaiseEvent EntraControl(sender, e)
    End Sub
    Private Sub SamitTxt_PresionaTecla(sender As Object, e As EventArgs) Handles Texto.KeyDown
        RaiseEvent PresionaTecla(sender, e)
    End Sub
    Private Sub Boton_Click(sender As Object, e As EventArgs) Handles Boton.Click
        Texto.Focus()
        AbrirBusqueda()
        Texto.Focus()
    End Sub

    Private Sub Texto_LostFocus(sender As Object, e As EventArgs) Handles Texto.LostFocus
        If _PresionoF5 Then Exit Sub

        SiObligatoriohayUnSoloRegistro()

        RevisarInvalido()
        If _ValorPredeterminado <> "" Then
            If ValordelControl = "" Then ValordelControl = _ValorPredeterminado
        End If
        If _TieneError Then
            Texto.BorderStyle = BorderStyles.Simple
            Texto.Properties.Appearance.BorderColor = Color.Red
        Else
            Texto.BorderStyle = BorderStyles.Default
            Texto.Properties.Appearance.BorderColor = Color.Black
        End If
        Titulo.Font = New System.Drawing.Font(Titulo.Font.Name, Titulo.Font.Size, FontStyle.Regular)
        If Not IsNothing(MiBarraEstado) Then
            If MiBarraEstado.GetType Is GetType(System.Windows.Forms.ToolStripStatusLabel) Then
                MiBarraEstado.Text = ""
            ElseIf MiBarraEstado.GetType Is GetType(DevExpress.XtraBars.Ribbon.RibbonStatusBar) Then
                MiBarraEstado.caption = ""
            ElseIf MiBarraEstado.GetType Is GetType(DevExpress.XtraBars.BarStaticItem) Then
                MiBarraEstado.caption = ""
            End If
        End If
        RaiseEvent SaleControl(sender, e)
    End Sub
    Private Sub RevisarInvalido()

        If _DatosCargados Then
            _TieneError = False
            If _DatoInvalido Then
                ValordelControl = Nothing
                Descripcion.Text = Nothing
            Else
                TieneErrorControl = False
            End If

            If ValordelControl = "" Then
                _EstaVacio = True
            Else
                _EstaVacio = False
            End If

            If ValordelControl = "" Then
                _EstaVacio = True
            Else
                _EstaVacio = False
            End If

            If _EsObligatorio And _EstaVacio Then
                TieneErrorControl = True
            Else
                TieneErrorControl = False
            End If
        End If
    End Sub

    Private Sub Texto_GotFocus(sender As Object, e As EventArgs) Handles Texto.GotFocus
        On Error Resume Next
        If _PresionoF5 Then
            _PresionoF5 = False
            Exit Sub
        End If

        If Not _DatosCargados Then
            ProcesCargarDatos()
        End If
        SiObligatoriohayUnSoloRegistro()
        If ColorDeFondoEntraControl <> Color.Black Then
            Texto.Properties.AppearanceFocused.BackColor = ColorDeFondoEntraControl
        End If
        Texto.BorderStyle = BorderStyles.Style3D
        Titulo.Font = New System.Drawing.Font(Titulo.Font.Name, Titulo.Font.Size, FontStyle.Bold)
        _TieneError = False
        If Not IsNothing(MiBarraEstado) Then
            If MiBarraEstado.GetType Is GetType(System.Windows.Forms.ToolStripStatusLabel) Then
                MiBarraEstado.Text = _MensajedeAyuda
            ElseIf MiBarraEstado.GetType Is GetType(DevExpress.XtraBars.Ribbon.RibbonStatusBar) Then
                MiBarraEstado.caption = _MensajedeAyuda
            ElseIf MiBarraEstado.GetType Is GetType(DevExpress.XtraBars.BarStaticItem) Then
                MiBarraEstado.caption = _MensajedeAyuda
            End If
        End If
        Texto.SelectAll()
    End Sub
    Private Sub Texto_Validating(sender As Object, e As CancelEventArgs) Handles Texto.Validating
        On Error Resume Next
        If _PresionoF5 Then Exit Sub
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
            GrpTexto.Width = AnchoTxt
        Catch ex As Exception
        End Try
        Try
            'Me.Height = 30
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Texto_KeyDown(sender As Object, e As KeyEventArgs) Handles Texto.KeyDown
        RaiseEvent PresionaTecla(Me, e)

        Select Case e.KeyData
            Case Keys.Right
                _PresionoF5 = True
                AbrirBusqueda()
                _PresionoF5 = False
            Case Keys.F5
                _PresionoF5 = True
                AbrirBusqueda()
                _PresionoF5 = False
            Case Keys.Escape, Keys.Up
                SendKeys.Send("+{TAB}")
                e.SuppressKeyPress = True
            Case Keys.Down
                SendKeys.Send("{TAB}")
                e.SuppressKeyPress = True
                Exit Sub
        End Select

    End Sub
    Private Sub Texto_EditValueChanged(sender As Object, e As EventArgs) Handles Texto.EditValueChanged
        Dim encontrado As Boolean = True
        _TieneError = False
        Descripcion.Text = ""
        Try
            If Not _DatosCargados Then
                ProcesCargarDatos()
            End If
            If Not IsNothing(_Datos) Then
                If _Datos.Rows.Count > 0 Then
                    If ValordelControl <> "" Then
                        encontrado = False
                        For Each fila As DataRow In _Datos.Rows
                            If fila(0).ToString().ToUpper = ValordelControl.ToUpper Then
                                Descripcion.Text = fila(1).ToString()
                                encontrado = True
                                _DatoInvalido = False
                                Exit For
                            End If
                        Next
                        If Not encontrado Then
                            If ValordelControl.ToString() = "" Then
                                Descripcion.Text = ""
                                _EstaVacio = True
                            Else
                                Descripcion.Text = "No Encontrado" & IIf(Not TipoBusqueda = Global.SamitCtlNet.TipoBusqueda.Ninguna, " (" & TipoBusqueda.ToString() & ")", "")
                                _DatoInvalido = True
                                _EstaVacio = False
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
        If Not encontrado Then ValordelControl = "" : _TieneError = True
    End Sub
    Private Function SiObligatoriohayUnSoloRegistro() As Boolean
        On Error GoTo CtlErr
        If Not IsNothing(_Datos) Then
            If _Datos.Rows.Count = 1 And Texto.Text.Trim = "" And _EsObligatorio Then
                _HayUnsoloRegistro = True
                Texto.Text = _Datos.Rows(0)(0)
                Descripcion.Text = _Datos.Rows(0)(1)
                Boton.Enabled = True
            ElseIf Not IsNothing(_ValorPredeterminado) Then
                If _ValorPredeterminado.Trim() <> "" Then Texto_EditValueChanged(Nothing, Nothing)
            ElseIf _Datos.Rows.Count > 1 Then
                If _EsObligatorio And Texto.Text.Trim = "" Then
                    Texto.Text = _Datos.Rows(0)(0)
                    Descripcion.Text = _Datos.Rows(0)(1)
                End If
            End If
        ElseIf IsNothing(_Datos) And _EsObligatorio Then
            _TieneError = True
        End If
        Return _HayUnsoloRegistro
        Exit Function
CtlErr:
        MensajedeError("Calculando Primer Dato u obligatorio")
    End Function

#End Region

    Private Sub Texto_Spin(sender As Object, e As SpinEventArgs) Handles Texto.Spin
        e.Handled = True
    End Sub
End Class
