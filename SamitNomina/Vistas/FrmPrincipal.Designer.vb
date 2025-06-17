Partial Public Class FrmPrincipal
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
        Me.components = New System.ComponentModel.Container()
        Dim SuperToolTip7 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem7 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrincipal))
        Dim ToolTipItem7 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip8 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem8 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem8 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Me.rcPrincipal = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.ControladorDeBarra = New DevExpress.XtraBars.BarAndDockingController(Me.components)
        Me.btnConexion = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCambiaFecha = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCambiaClave = New DevExpress.XtraBars.BarButtonItem()
        Me.msjEmpresa = New DevExpress.XtraBars.BarStaticItem()
        Me.NumEmpresa = New DevExpress.XtraBars.BarStaticItem()
        Me.msjOficina = New DevExpress.XtraBars.BarStaticItem()
        Me.NumOficina = New DevExpress.XtraBars.BarStaticItem()
        Me.FechaTrabajo = New DevExpress.XtraBars.BarStaticItem()
        Me.MensajeDeAyuda = New DevExpress.XtraBars.BarStaticItem()
        Me.btnNuevoEmpleado = New DevExpress.XtraBars.BarButtonItem()
        Me.btnConexionMenu = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCambiaFechaMenu = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCambiaClaveMenu = New DevExpress.XtraBars.BarButtonItem()
        Me.btnNuevoEmpMenu = New DevExpress.XtraBars.BarButtonItem()
        Me.SkinRibbonGalleryBarItem1 = New DevExpress.XtraBars.SkinRibbonGalleryBarItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem8 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem9 = New DevExpress.XtraBars.BarButtonItem()
        Me.btnValGenerales = New DevExpress.XtraBars.BarButtonItem()
        Me.btnValPersonales = New DevExpress.XtraBars.BarButtonItem()
        Me.btnTipoConceptos = New DevExpress.XtraBars.BarButtonItem()
        Me.btnConceptos = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPlantillas = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPeriodos = New DevExpress.XtraBars.BarButtonItem()
        Me.btnBases = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSalir = New DevExpress.XtraBars.BarButtonItem()
        Me.btnTiposContratos = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCentroCostos = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDependencias = New DevExpress.XtraBars.BarButtonItem()
        Me.bsiPeriodosLiquidacion = New DevExpress.XtraBars.BarSubItem()
        Me.btnGenPeriodos = New DevExpress.XtraBars.BarButtonItem()
        Me.btnNuevaNomina = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEntidades = New DevExpress.XtraBars.BarButtonItem()
        Me.btaggbases = New DevExpress.XtraBars.BarButtonItem()
        Me.btnProfesiones = New DevExpress.XtraBars.BarButtonItem()
        Me.menuTablasCatalogo = New DevExpress.XtraBars.BarSubItem()
        Me.btnClaseLicencia = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDepartamentos = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEstadoCivil = New DevExpress.XtraBars.BarButtonItem()
        Me.btnMunicipios = New DevExpress.XtraBars.BarButtonItem()
        Me.btnNivelEducativo = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPaises = New DevExpress.XtraBars.BarButtonItem()
        Me.btnParentezco = New DevExpress.XtraBars.BarButtonItem()
        Me.btnTiposId = New DevExpress.XtraBars.BarButtonItem()
        Me.btnConceptosPersonales = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem()
        Me.btnClasConceptosNomina = New DevExpress.XtraBars.BarButtonItem()
        Me.btnClasConceptosPersonales = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDescuentosNomina = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAggValExentos = New DevExpress.XtraBars.BarButtonItem()
        Me.btnValMaxDescuento = New DevExpress.XtraBars.BarButtonItem()
        Me.btnModAsignaciones = New DevExpress.XtraBars.BarButtonItem()
        Me.menuEmpleado = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem48 = New DevExpress.XtraBars.BarButtonItem()
        Me.btcConfigConceptos = New DevExpress.XtraBars.BarButtonItem()
        Me.btnConfigNominas = New DevExpress.XtraBars.BarButtonItem()
        Me.btcConfigTipoContratos = New DevExpress.XtraBars.BarButtonItem()
        Me.btnConfigPrestacionesS = New DevExpress.XtraBars.BarButtonItem()
        Me.btnLiquidarProvisiones = New DevExpress.XtraBars.BarButtonItem()
        Me.btnLiquidacionExtraor = New DevExpress.XtraBars.BarButtonItem()
        Me.btnLiquidarContrato = New DevExpress.XtraBars.BarButtonItem()
        Me.btnContratos = New DevExpress.XtraBars.BarSubItem()
        Me.btnAggContratos = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAsigValoresExentos = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAsigDescuentos = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAsigNominas = New DevExpress.XtraBars.BarButtonItem()
        Me.btnModAsignaSalariales = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCargos = New DevExpress.XtraBars.BarSubItem()
        Me.btnAggCargo = New DevExpress.XtraBars.BarButtonItem()
        Me.btnFunciones = New DevExpress.XtraBars.BarButtonItem()
        Me.btnNominas = New DevExpress.XtraBars.BarSubItem()
        Me.btnAggNominas = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem8 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem45 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem46 = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSubOtrosContratos = New DevExpress.XtraBars.BarSubItem()
        Me.bntTiposContratos = New DevExpress.XtraBars.BarButtonItem()
        Me.bntDependencia = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCentrosCostos = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem13 = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSubNomina = New DevExpress.XtraBars.BarSubItem()
        Me.btnConfigNomina = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem10 = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSubConceptos = New DevExpress.XtraBars.BarSubItem()
        Me.btnSubValoresCalculo = New DevExpress.XtraBars.BarSubItem()
        Me.btnValoresPersonales = New DevExpress.XtraBars.BarButtonItem()
        Me.btnValoresGenerales = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAggBases = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSubConceptosNom = New DevExpress.XtraBars.BarSubItem()
        Me.btnConceptosNomina = New DevExpress.XtraBars.BarButtonItem()
        Me.btnClasiConcepNom = New DevExpress.XtraBars.BarButtonItem()
        Me.CofigConcepNomina = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSubConceptosPersonales = New DevExpress.XtraBars.BarSubItem()
        Me.btnConceptosPersona = New DevExpress.XtraBars.BarButtonItem()
        Me.btnClasiConcepPersonales = New DevExpress.XtraBars.BarButtonItem()
        Me.btnConceptosNom = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem11 = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSubPerfilConceptos = New DevExpress.XtraBars.BarSubItem()
        Me.btnPerfilConceptos = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAsigValorMaximo = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSubLiquidaciones = New DevExpress.XtraBars.BarSubItem()
        Me.btnSubLiquidacionPeriodos = New DevExpress.XtraBars.BarSubItem()
        Me.btnNovedades = New DevExpress.XtraBars.BarButtonItem()
        Me.btnLiquidarPeriodo = New DevExpress.XtraBars.BarButtonItem()
        Me.btnConfigurarLiquidaPeriodos = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSubLiquidacionPrestaciones = New DevExpress.XtraBars.BarSubItem()
        Me.bntLiquidarPrestaciones = New DevExpress.XtraBars.BarButtonItem()
        Me.btnConfigLiquidaPrestaciones = New DevExpress.XtraBars.BarButtonItem()
        Me.btnLiquidacionExtraordinaria = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSubLiquidaContratos = New DevExpress.XtraBars.BarSubItem()
        Me.btnLiquidarContratos = New DevExpress.XtraBars.BarButtonItem()
        Me.btnConfigLiquidacion = New DevExpress.XtraBars.BarButtonItem()
        Me.btnConsultarLiquidacion = New DevExpress.XtraBars.BarButtonItem()
        Me.btnBancos = New DevExpress.XtraBars.BarButtonItem()
        Me.b = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem12 = New DevExpress.XtraBars.BarButtonItem()
        Me.btnConfiguracion = New DevExpress.XtraBars.BarSubItem()
        Me.BarSubItem2 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem21 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem22 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem23 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem24 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem25 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem26 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem27 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem28 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem14 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem15 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem3 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem31 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem32 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem44 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem17 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem18 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem19 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem29 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem4 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem34 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem35 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem39 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem43 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem16 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem20 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem30 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem33 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem36 = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiLiquidaciones = New DevExpress.XtraBars.BarButtonItem()
        Me.bsiConceptos = New DevExpress.XtraBars.BarSubItem()
        Me.BarSubItem5 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem38 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem7 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem47 = New DevExpress.XtraBars.BarButtonItem()
        Me.bsiLiquidaciones = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem37 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem6 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem42 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem40 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem41 = New DevExpress.XtraBars.BarButtonItem()
        Me.PaginaInicio = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.rpgConexion = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgEmpleados = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgContratos = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgConceptos = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgNomina = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgLiquidaciones = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgConfig = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgSalir = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.ImagenesSMT16X16 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.ImagenesSMT32X32 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.TabManagerPrincipal = New DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.rcPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ControladorDeBarra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImagenesSMT16X16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImagenesSMT32X32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabManagerPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rcPrincipal
        '
        Me.rcPrincipal.Controller = Me.ControladorDeBarra
        Me.rcPrincipal.ExpandCollapseItem.Id = 0
        Me.rcPrincipal.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.rcPrincipal.ExpandCollapseItem, Me.rcPrincipal.SearchEditItem, Me.btnConexion, Me.btnCambiaFecha, Me.btnCambiaClave, Me.msjEmpresa, Me.NumEmpresa, Me.msjOficina, Me.NumOficina, Me.FechaTrabajo, Me.MensajeDeAyuda, Me.btnNuevoEmpleado, Me.btnConexionMenu, Me.btnCambiaFechaMenu, Me.btnCambiaClaveMenu, Me.btnNuevoEmpMenu, Me.SkinRibbonGalleryBarItem1, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem5, Me.BarButtonItem6, Me.BarButtonItem7, Me.BarButtonItem1, Me.BarButtonItem8, Me.BarButtonItem9, Me.btnValGenerales, Me.btnValPersonales, Me.btnTipoConceptos, Me.btnConceptos, Me.btnPlantillas, Me.btnPeriodos, Me.btnBases, Me.btnSalir, Me.btnTiposContratos, Me.btnCentroCostos, Me.btnDependencias, Me.bsiPeriodosLiquidacion, Me.btnGenPeriodos, Me.btnNuevaNomina, Me.btnEntidades, Me.btaggbases, Me.btnProfesiones, Me.menuTablasCatalogo, Me.btnNivelEducativo, Me.btnClaseLicencia, Me.btnEstadoCivil, Me.btnTiposId, Me.btnParentezco, Me.btnPaises, Me.btnDepartamentos, Me.btnMunicipios, Me.btnConceptosPersonales, Me.BarSubItem1, Me.btnClasConceptosNomina, Me.btnClasConceptosPersonales, Me.btnDescuentosNomina, Me.btnAggValExentos, Me.btnValMaxDescuento, Me.btnModAsignaciones, Me.menuEmpleado, Me.BarButtonItem2, Me.btcConfigConceptos, Me.btnConfigNominas, Me.btcConfigTipoContratos, Me.btnConfigPrestacionesS, Me.btnLiquidarProvisiones, Me.btnLiquidacionExtraor, Me.btnLiquidarContrato, Me.btnContratos, Me.btnCargos, Me.btnNominas, Me.btnAggContratos, Me.btnModAsignaSalariales, Me.btnAsigValoresExentos, Me.btnAsigDescuentos, Me.btnAsigNominas, Me.btnSubOtrosContratos, Me.bntTiposContratos, Me.bntDependencia, Me.btnCentrosCostos, Me.btnAggCargo, Me.btnFunciones, Me.btnSubNomina, Me.btnAggNominas, Me.btnConfigNomina, Me.BarButtonItem10, Me.btnSubConceptos, Me.btnSubValoresCalculo, Me.btnValoresPersonales, Me.btnValoresGenerales, Me.btnAggBases, Me.btnConceptosNom, Me.btnSubConceptosNom, Me.btnConceptosNomina, Me.btnClasiConcepNom, Me.btnSubConceptosPersonales, Me.btnConceptosPersona, Me.btnClasiConcepPersonales, Me.BarButtonItem11, Me.btnSubPerfilConceptos, Me.btnPerfilConceptos, Me.btnAsigValorMaximo, Me.btnSubLiquidaciones, Me.btnSubLiquidacionPeriodos, Me.btnNovedades, Me.btnLiquidarPeriodo, Me.btnConfigurarLiquidaPeriodos, Me.btnSubLiquidacionPrestaciones, Me.bntLiquidarPrestaciones, Me.btnConfigLiquidaPrestaciones, Me.btnLiquidacionExtraordinaria, Me.btnSubLiquidaContratos, Me.btnLiquidarContratos, Me.btnConfigLiquidacion, Me.btnConsultarLiquidacion, Me.btnBancos, Me.b, Me.BarButtonItem12, Me.CofigConcepNomina, Me.BarButtonItem13, Me.btnConfiguracion, Me.BarSubItem2, Me.BarButtonItem14, Me.BarButtonItem15, Me.BarButtonItem16, Me.BarSubItem3, Me.BarButtonItem17, Me.BarButtonItem18, Me.BarButtonItem19, Me.BarButtonItem20, Me.BarButtonItem21, Me.BarButtonItem22, Me.BarButtonItem23, Me.BarButtonItem24, Me.BarButtonItem25, Me.BarButtonItem26, Me.BarButtonItem27, Me.BarButtonItem28, Me.BarButtonItem29, Me.BarButtonItem30, Me.BarButtonItem31, Me.BarButtonItem32, Me.BarButtonItem33, Me.BarSubItem4, Me.BarButtonItem34, Me.BarButtonItem35, Me.BarButtonItem36, Me.bbiLiquidaciones, Me.bsiConceptos, Me.bsiLiquidaciones, Me.BarSubItem5, Me.BarButtonItem37, Me.BarSubItem6, Me.BarButtonItem38, Me.BarButtonItem39, Me.BarSubItem7, Me.BarButtonItem40, Me.BarButtonItem41, Me.BarButtonItem42, Me.BarButtonItem43, Me.BarButtonItem44, Me.BarSubItem8, Me.BarButtonItem45, Me.BarButtonItem46, Me.BarButtonItem47, Me.BarButtonItem48})
        Me.rcPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.rcPrincipal.MaxItemId = 198
        Me.rcPrincipal.Name = "rcPrincipal"
        Me.rcPrincipal.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.PaginaInicio})
        Me.rcPrincipal.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013
        Me.rcPrincipal.ShowItemCaptionsInQAT = True
        Me.rcPrincipal.ShowToolbarCustomizeItem = False
        Me.rcPrincipal.Size = New System.Drawing.Size(1021, 163)
        Me.rcPrincipal.StatusBar = Me.RibbonStatusBar1
        Me.rcPrincipal.Toolbar.ShowCustomizeItem = False
        Me.rcPrincipal.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'ControladorDeBarra
        '
        Me.ControladorDeBarra.AppearancesRibbon.PageGroupCaption.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ControladorDeBarra.AppearancesRibbon.PageGroupCaption.Options.UseFont = True
        Me.ControladorDeBarra.PropertiesBar.AllowLinkLighting = False
        '
        'btnConexion
        '
        Me.btnConexion.Caption = "Conectar"
        Me.btnConexion.Id = 7
        Me.btnConexion.ItemAppearance.Disabled.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnConexion.ItemAppearance.Disabled.Options.UseFont = True
        Me.btnConexion.ItemAppearance.Hovered.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnConexion.ItemAppearance.Hovered.Options.UseFont = True
        Me.btnConexion.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnConexion.ItemAppearance.Normal.Options.UseFont = True
        Me.btnConexion.ItemAppearance.Pressed.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnConexion.ItemAppearance.Pressed.Options.UseFont = True
        Me.btnConexion.Name = "btnConexion"
        Me.btnConexion.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
            Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        ToolTipTitleItem7.Appearance.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        ToolTipTitleItem7.Appearance.Options.UseImage = True
        ToolTipTitleItem7.ImageOptions.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        ToolTipTitleItem7.Text = "Mensaje SAMIT Sql"
        ToolTipItem7.LeftIndent = 6
        ToolTipItem7.Text = "Iniciar conexión"
        SuperToolTip7.Items.Add(ToolTipTitleItem7)
        SuperToolTip7.Items.Add(ToolTipItem7)
        Me.btnConexion.SuperTip = SuperToolTip7
        '
        'btnCambiaFecha
        '
        Me.btnCambiaFecha.Caption = "Cambiar Fecha"
        Me.btnCambiaFecha.Id = 8
        Me.btnCambiaFecha.ImageOptions.LargeImage = CType(resources.GetObject("btnCambiaFecha.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnCambiaFecha.ItemAppearance.Disabled.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnCambiaFecha.ItemAppearance.Disabled.Options.UseFont = True
        Me.btnCambiaFecha.ItemAppearance.Hovered.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnCambiaFecha.ItemAppearance.Hovered.Options.UseFont = True
        Me.btnCambiaFecha.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnCambiaFecha.ItemAppearance.Normal.Options.UseFont = True
        Me.btnCambiaFecha.ItemAppearance.Pressed.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnCambiaFecha.ItemAppearance.Pressed.Options.UseFont = True
        Me.btnCambiaFecha.Name = "btnCambiaFecha"
        Me.btnCambiaFecha.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
        '
        'btnCambiaClave
        '
        Me.btnCambiaClave.Caption = "Cambiar Clave"
        Me.btnCambiaClave.Id = 9
        Me.btnCambiaClave.ImageOptions.LargeImage = CType(resources.GetObject("btnCambiaClave.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnCambiaClave.ItemAppearance.Disabled.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnCambiaClave.ItemAppearance.Disabled.Options.UseFont = True
        Me.btnCambiaClave.ItemAppearance.Hovered.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnCambiaClave.ItemAppearance.Hovered.Options.UseFont = True
        Me.btnCambiaClave.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnCambiaClave.ItemAppearance.Normal.Options.UseFont = True
        Me.btnCambiaClave.ItemAppearance.Pressed.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnCambiaClave.ItemAppearance.Pressed.Options.UseFont = True
        Me.btnCambiaClave.Name = "btnCambiaClave"
        Me.btnCambiaClave.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
        '
        'msjEmpresa
        '
        Me.msjEmpresa.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.msjEmpresa.Caption = "EMP"
        Me.msjEmpresa.Id = 11
        Me.msjEmpresa.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.msjEmpresa.ItemAppearance.Normal.Options.UseFont = True
        Me.msjEmpresa.Name = "msjEmpresa"
        '
        'NumEmpresa
        '
        Me.NumEmpresa.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.NumEmpresa.Caption = "0"
        Me.NumEmpresa.Id = 12
        Me.NumEmpresa.ItemAppearance.Disabled.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.NumEmpresa.ItemAppearance.Disabled.Options.UseFont = True
        Me.NumEmpresa.ItemAppearance.Hovered.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.NumEmpresa.ItemAppearance.Hovered.Options.UseFont = True
        Me.NumEmpresa.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.NumEmpresa.ItemAppearance.Normal.Options.UseFont = True
        Me.NumEmpresa.ItemAppearance.Pressed.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.NumEmpresa.ItemAppearance.Pressed.Options.UseFont = True
        Me.NumEmpresa.Name = "NumEmpresa"
        '
        'msjOficina
        '
        Me.msjOficina.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.msjOficina.Caption = "Oficina"
        Me.msjOficina.Id = 13
        Me.msjOficina.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.msjOficina.ItemAppearance.Normal.Options.UseFont = True
        Me.msjOficina.Name = "msjOficina"
        '
        'NumOficina
        '
        Me.NumOficina.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.NumOficina.Caption = "0"
        Me.NumOficina.Id = 14
        Me.NumOficina.ItemAppearance.Disabled.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.NumOficina.ItemAppearance.Disabled.Options.UseFont = True
        Me.NumOficina.ItemAppearance.Hovered.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.NumOficina.ItemAppearance.Hovered.Options.UseFont = True
        Me.NumOficina.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.NumOficina.ItemAppearance.Normal.Options.UseFont = True
        Me.NumOficina.ItemAppearance.Pressed.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumOficina.ItemAppearance.Pressed.Options.UseFont = True
        Me.NumOficina.Name = "NumOficina"
        '
        'FechaTrabajo
        '
        Me.FechaTrabajo.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.FechaTrabajo.Caption = "dd/MMM/yyyy"
        Me.FechaTrabajo.Id = 15
        Me.FechaTrabajo.Name = "FechaTrabajo"
        '
        'MensajeDeAyuda
        '
        Me.MensajeDeAyuda.AutoSize = DevExpress.XtraBars.BarStaticItemSize.Spring
        Me.MensajeDeAyuda.Caption = "MensajeDeAyuda"
        Me.MensajeDeAyuda.Id = 16
        Me.MensajeDeAyuda.ItemAppearance.Disabled.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.MensajeDeAyuda.ItemAppearance.Disabled.Options.UseFont = True
        Me.MensajeDeAyuda.ItemAppearance.Hovered.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.MensajeDeAyuda.ItemAppearance.Hovered.Options.UseFont = True
        Me.MensajeDeAyuda.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.MensajeDeAyuda.ItemAppearance.Normal.Options.UseFont = True
        Me.MensajeDeAyuda.ItemAppearance.Pressed.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.MensajeDeAyuda.ItemAppearance.Pressed.Options.UseFont = True
        Me.MensajeDeAyuda.Name = "MensajeDeAyuda"
        '
        'btnNuevoEmpleado
        '
        Me.btnNuevoEmpleado.Caption = "Agregar/Editar"
        Me.btnNuevoEmpleado.Id = 17
        Me.btnNuevoEmpleado.ItemAppearance.Disabled.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnNuevoEmpleado.ItemAppearance.Disabled.Options.UseFont = True
        Me.btnNuevoEmpleado.ItemAppearance.Hovered.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnNuevoEmpleado.ItemAppearance.Hovered.Options.UseFont = True
        Me.btnNuevoEmpleado.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnNuevoEmpleado.ItemAppearance.Normal.Options.UseFont = True
        Me.btnNuevoEmpleado.ItemAppearance.Pressed.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnNuevoEmpleado.ItemAppearance.Pressed.Options.UseFont = True
        Me.btnNuevoEmpleado.Name = "btnNuevoEmpleado"
        Me.btnNuevoEmpleado.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
            Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        '
        'btnConexionMenu
        '
        Me.btnConexionMenu.Caption = "Conectar"
        Me.btnConexionMenu.Id = 32
        Me.btnConexionMenu.ItemAppearance.Disabled.Font = New System.Drawing.Font("Trebuchet MS", 9.0!)
        Me.btnConexionMenu.ItemAppearance.Disabled.Options.UseFont = True
        Me.btnConexionMenu.ItemAppearance.Hovered.Font = New System.Drawing.Font("Trebuchet MS", 9.0!)
        Me.btnConexionMenu.ItemAppearance.Hovered.Options.UseFont = True
        Me.btnConexionMenu.ItemAppearance.Normal.Font = New System.Drawing.Font("Trebuchet MS", 9.0!)
        Me.btnConexionMenu.ItemAppearance.Normal.Options.UseFont = True
        Me.btnConexionMenu.ItemAppearance.Pressed.Font = New System.Drawing.Font("Trebuchet MS", 9.0!)
        Me.btnConexionMenu.ItemAppearance.Pressed.Options.UseFont = True
        Me.btnConexionMenu.Name = "btnConexionMenu"
        '
        'btnCambiaFechaMenu
        '
        Me.btnCambiaFechaMenu.Caption = "Cambiar Fecha"
        Me.btnCambiaFechaMenu.Id = 33
        Me.btnCambiaFechaMenu.ItemAppearance.Disabled.Font = New System.Drawing.Font("Trebuchet MS", 9.0!)
        Me.btnCambiaFechaMenu.ItemAppearance.Disabled.Options.UseFont = True
        Me.btnCambiaFechaMenu.ItemAppearance.Hovered.Font = New System.Drawing.Font("Trebuchet MS", 9.0!)
        Me.btnCambiaFechaMenu.ItemAppearance.Hovered.Options.UseFont = True
        Me.btnCambiaFechaMenu.ItemAppearance.Normal.Font = New System.Drawing.Font("Trebuchet MS", 9.0!)
        Me.btnCambiaFechaMenu.ItemAppearance.Normal.Options.UseFont = True
        Me.btnCambiaFechaMenu.ItemAppearance.Pressed.Font = New System.Drawing.Font("Trebuchet MS", 9.0!)
        Me.btnCambiaFechaMenu.ItemAppearance.Pressed.Options.UseFont = True
        Me.btnCambiaFechaMenu.Name = "btnCambiaFechaMenu"
        '
        'btnCambiaClaveMenu
        '
        Me.btnCambiaClaveMenu.Caption = "Cambiar Clave"
        Me.btnCambiaClaveMenu.Id = 34
        Me.btnCambiaClaveMenu.ItemAppearance.Disabled.Font = New System.Drawing.Font("Trebuchet MS", 9.0!)
        Me.btnCambiaClaveMenu.ItemAppearance.Disabled.Options.UseFont = True
        Me.btnCambiaClaveMenu.ItemAppearance.Hovered.Font = New System.Drawing.Font("Trebuchet MS", 9.0!)
        Me.btnCambiaClaveMenu.ItemAppearance.Hovered.Options.UseFont = True
        Me.btnCambiaClaveMenu.ItemAppearance.Normal.Font = New System.Drawing.Font("Trebuchet MS", 9.0!)
        Me.btnCambiaClaveMenu.ItemAppearance.Normal.Options.UseFont = True
        Me.btnCambiaClaveMenu.ItemAppearance.Pressed.Font = New System.Drawing.Font("Trebuchet MS", 9.0!)
        Me.btnCambiaClaveMenu.ItemAppearance.Pressed.Options.UseFont = True
        Me.btnCambiaClaveMenu.Name = "btnCambiaClaveMenu"
        '
        'btnNuevoEmpMenu
        '
        Me.btnNuevoEmpMenu.Caption = "Nuevo/Editar/Consultar"
        Me.btnNuevoEmpMenu.Id = 35
        Me.btnNuevoEmpMenu.ItemAppearance.Disabled.Font = New System.Drawing.Font("Trebuchet MS", 9.0!)
        Me.btnNuevoEmpMenu.ItemAppearance.Disabled.Options.UseFont = True
        Me.btnNuevoEmpMenu.ItemAppearance.Hovered.Font = New System.Drawing.Font("Trebuchet MS", 9.0!)
        Me.btnNuevoEmpMenu.ItemAppearance.Hovered.Options.UseFont = True
        Me.btnNuevoEmpMenu.ItemAppearance.Normal.Font = New System.Drawing.Font("Trebuchet MS", 9.0!)
        Me.btnNuevoEmpMenu.ItemAppearance.Normal.Options.UseFont = True
        Me.btnNuevoEmpMenu.ItemAppearance.Pressed.Font = New System.Drawing.Font("Trebuchet MS", 9.0!)
        Me.btnNuevoEmpMenu.ItemAppearance.Pressed.Options.UseFont = True
        Me.btnNuevoEmpMenu.Name = "btnNuevoEmpMenu"
        '
        'SkinRibbonGalleryBarItem1
        '
        Me.SkinRibbonGalleryBarItem1.Caption = "SkinRibbonGalleryBarItem1"
        Me.SkinRibbonGalleryBarItem1.Id = 39
        Me.SkinRibbonGalleryBarItem1.Name = "SkinRibbonGalleryBarItem1"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Valores Generales"
        Me.BarButtonItem3.Id = 40
        Me.BarButtonItem3.ItemAppearance.Disabled.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.BarButtonItem3.ItemAppearance.Disabled.Options.UseFont = True
        Me.BarButtonItem3.ItemAppearance.Hovered.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.BarButtonItem3.ItemAppearance.Hovered.Options.UseFont = True
        Me.BarButtonItem3.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.BarButtonItem3.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem3.ItemAppearance.Pressed.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.BarButtonItem3.ItemAppearance.Pressed.Options.UseFont = True
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Valores Personales"
        Me.BarButtonItem4.Id = 41
        Me.BarButtonItem4.ItemAppearance.Disabled.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.BarButtonItem4.ItemAppearance.Disabled.Options.UseFont = True
        Me.BarButtonItem4.ItemAppearance.Hovered.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.BarButtonItem4.ItemAppearance.Hovered.Options.UseFont = True
        Me.BarButtonItem4.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.BarButtonItem4.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem4.ItemAppearance.Pressed.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.BarButtonItem4.ItemAppearance.Pressed.Options.UseFont = True
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Bases"
        Me.BarButtonItem5.Id = 42
        Me.BarButtonItem5.ItemAppearance.Disabled.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.BarButtonItem5.ItemAppearance.Disabled.Options.UseFont = True
        Me.BarButtonItem5.ItemAppearance.Hovered.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.BarButtonItem5.ItemAppearance.Hovered.Options.UseFont = True
        Me.BarButtonItem5.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.BarButtonItem5.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem5.ItemAppearance.Pressed.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.BarButtonItem5.ItemAppearance.Pressed.Options.UseFont = True
        Me.BarButtonItem5.Name = "BarButtonItem5"
        Me.BarButtonItem5.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "Tipos Conceptos"
        Me.BarButtonItem6.Id = 43
        Me.BarButtonItem6.ItemAppearance.Disabled.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.BarButtonItem6.ItemAppearance.Disabled.Options.UseFont = True
        Me.BarButtonItem6.ItemAppearance.Hovered.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.BarButtonItem6.ItemAppearance.Hovered.Options.UseFont = True
        Me.BarButtonItem6.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.BarButtonItem6.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem6.ItemAppearance.Pressed.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.BarButtonItem6.ItemAppearance.Pressed.Options.UseFont = True
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "Conceptos"
        Me.BarButtonItem7.Id = 44
        Me.BarButtonItem7.ItemAppearance.Disabled.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.BarButtonItem7.ItemAppearance.Disabled.Options.UseFont = True
        Me.BarButtonItem7.ItemAppearance.Hovered.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.BarButtonItem7.ItemAppearance.Hovered.Options.UseFont = True
        Me.BarButtonItem7.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.BarButtonItem7.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem7.ItemAppearance.Pressed.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.BarButtonItem7.ItemAppearance.Pressed.Options.UseFont = True
        Me.BarButtonItem7.Name = "BarButtonItem7"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Nominas"
        Me.BarButtonItem1.Id = 45
        Me.BarButtonItem1.ItemAppearance.Disabled.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.BarButtonItem1.ItemAppearance.Disabled.Options.UseFont = True
        Me.BarButtonItem1.ItemAppearance.Hovered.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.BarButtonItem1.ItemAppearance.Hovered.Options.UseFont = True
        Me.BarButtonItem1.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.BarButtonItem1.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem1.ItemAppearance.Pressed.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.BarButtonItem1.ItemAppearance.Pressed.Options.UseFont = True
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem8
        '
        Me.BarButtonItem8.Caption = "Periodos"
        Me.BarButtonItem8.Id = 46
        Me.BarButtonItem8.ItemAppearance.Disabled.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.BarButtonItem8.ItemAppearance.Disabled.Options.UseFont = True
        Me.BarButtonItem8.ItemAppearance.Hovered.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.BarButtonItem8.ItemAppearance.Hovered.Options.UseFont = True
        Me.BarButtonItem8.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.BarButtonItem8.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem8.ItemAppearance.Pressed.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.BarButtonItem8.ItemAppearance.Pressed.Options.UseFont = True
        Me.BarButtonItem8.Name = "BarButtonItem8"
        '
        'BarButtonItem9
        '
        Me.BarButtonItem9.Caption = "Plantillas"
        Me.BarButtonItem9.Id = 47
        Me.BarButtonItem9.ItemAppearance.Disabled.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.BarButtonItem9.ItemAppearance.Disabled.Options.UseFont = True
        Me.BarButtonItem9.ItemAppearance.Hovered.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.BarButtonItem9.ItemAppearance.Hovered.Options.UseFont = True
        Me.BarButtonItem9.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.BarButtonItem9.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem9.ItemAppearance.Pressed.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.BarButtonItem9.ItemAppearance.Pressed.Options.UseFont = True
        Me.BarButtonItem9.Name = "BarButtonItem9"
        '
        'btnValGenerales
        '
        Me.btnValGenerales.Caption = "Valores Generales"
        Me.btnValGenerales.Id = 52
        Me.btnValGenerales.ItemAppearance.Disabled.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnValGenerales.ItemAppearance.Disabled.Options.UseFont = True
        Me.btnValGenerales.ItemAppearance.Hovered.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnValGenerales.ItemAppearance.Hovered.Options.UseFont = True
        Me.btnValGenerales.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnValGenerales.ItemAppearance.Normal.Options.UseFont = True
        Me.btnValGenerales.ItemAppearance.Pressed.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnValGenerales.ItemAppearance.Pressed.Options.UseFont = True
        Me.btnValGenerales.Name = "btnValGenerales"
        '
        'btnValPersonales
        '
        Me.btnValPersonales.Caption = "Valores Personales"
        Me.btnValPersonales.Id = 53
        Me.btnValPersonales.ItemAppearance.Disabled.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnValPersonales.ItemAppearance.Disabled.Options.UseFont = True
        Me.btnValPersonales.ItemAppearance.Hovered.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnValPersonales.ItemAppearance.Hovered.Options.UseFont = True
        Me.btnValPersonales.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnValPersonales.ItemAppearance.Normal.Options.UseFont = True
        Me.btnValPersonales.ItemAppearance.Pressed.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnValPersonales.ItemAppearance.Pressed.Options.UseFont = True
        Me.btnValPersonales.Name = "btnValPersonales"
        '
        'btnTipoConceptos
        '
        Me.btnTipoConceptos.Caption = "Tipos de Conceptos"
        Me.btnTipoConceptos.Id = 54
        Me.btnTipoConceptos.ItemAppearance.Disabled.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnTipoConceptos.ItemAppearance.Disabled.Options.UseFont = True
        Me.btnTipoConceptos.ItemAppearance.Hovered.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnTipoConceptos.ItemAppearance.Hovered.Options.UseFont = True
        Me.btnTipoConceptos.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnTipoConceptos.ItemAppearance.Normal.Options.UseFont = True
        Me.btnTipoConceptos.ItemAppearance.Pressed.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnTipoConceptos.ItemAppearance.Pressed.Options.UseFont = True
        Me.btnTipoConceptos.Name = "btnTipoConceptos"
        '
        'btnConceptos
        '
        Me.btnConceptos.Caption = "Conceptos"
        Me.btnConceptos.Id = 55
        Me.btnConceptos.ItemAppearance.Disabled.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnConceptos.ItemAppearance.Disabled.Options.UseFont = True
        Me.btnConceptos.ItemAppearance.Hovered.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnConceptos.ItemAppearance.Hovered.Options.UseFont = True
        Me.btnConceptos.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnConceptos.ItemAppearance.Normal.Options.UseFont = True
        Me.btnConceptos.ItemAppearance.Pressed.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnConceptos.ItemAppearance.Pressed.Options.UseFont = True
        Me.btnConceptos.Name = "btnConceptos"
        '
        'btnPlantillas
        '
        Me.btnPlantillas.Caption = "Plantillas"
        Me.btnPlantillas.Id = 56
        Me.btnPlantillas.ItemAppearance.Disabled.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnPlantillas.ItemAppearance.Disabled.Options.UseFont = True
        Me.btnPlantillas.ItemAppearance.Hovered.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnPlantillas.ItemAppearance.Hovered.Options.UseFont = True
        Me.btnPlantillas.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnPlantillas.ItemAppearance.Normal.Options.UseFont = True
        Me.btnPlantillas.ItemAppearance.Pressed.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnPlantillas.ItemAppearance.Pressed.Options.UseFont = True
        Me.btnPlantillas.Name = "btnPlantillas"
        '
        'btnPeriodos
        '
        Me.btnPeriodos.Caption = "Periodos Existentes"
        Me.btnPeriodos.Id = 57
        Me.btnPeriodos.ItemAppearance.Disabled.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnPeriodos.ItemAppearance.Disabled.Options.UseFont = True
        Me.btnPeriodos.ItemAppearance.Hovered.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnPeriodos.ItemAppearance.Hovered.Options.UseFont = True
        Me.btnPeriodos.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnPeriodos.ItemAppearance.Normal.Options.UseFont = True
        Me.btnPeriodos.ItemAppearance.Pressed.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnPeriodos.ItemAppearance.Pressed.Options.UseFont = True
        Me.btnPeriodos.Name = "btnPeriodos"
        '
        'btnBases
        '
        Me.btnBases.Caption = "Bases"
        Me.btnBases.Id = 58
        Me.btnBases.ItemAppearance.Disabled.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnBases.ItemAppearance.Disabled.Options.UseFont = True
        Me.btnBases.ItemAppearance.Hovered.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnBases.ItemAppearance.Hovered.Options.UseFont = True
        Me.btnBases.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnBases.ItemAppearance.Normal.Options.UseFont = True
        Me.btnBases.ItemAppearance.Pressed.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnBases.ItemAppearance.Pressed.Options.UseFont = True
        Me.btnBases.Name = "btnBases"
        '
        'btnSalir
        '
        Me.btnSalir.Caption = "Salir"
        Me.btnSalir.Id = 59
        Me.btnSalir.ItemAppearance.Disabled.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnSalir.ItemAppearance.Disabled.Options.UseFont = True
        Me.btnSalir.ItemAppearance.Hovered.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnSalir.ItemAppearance.Hovered.Options.UseFont = True
        Me.btnSalir.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnSalir.ItemAppearance.Normal.Options.UseFont = True
        Me.btnSalir.ItemAppearance.Pressed.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnSalir.ItemAppearance.Pressed.Options.UseFont = True
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
            Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        '
        'btnTiposContratos
        '
        Me.btnTiposContratos.Caption = "Tipos de Contratos"
        Me.btnTiposContratos.Id = 60
        Me.btnTiposContratos.ItemAppearance.Disabled.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnTiposContratos.ItemAppearance.Disabled.Options.UseFont = True
        Me.btnTiposContratos.ItemAppearance.Hovered.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnTiposContratos.ItemAppearance.Hovered.Options.UseFont = True
        Me.btnTiposContratos.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnTiposContratos.ItemAppearance.Normal.Options.UseFont = True
        Me.btnTiposContratos.ItemAppearance.Pressed.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnTiposContratos.ItemAppearance.Pressed.Options.UseFont = True
        Me.btnTiposContratos.Name = "btnTiposContratos"
        '
        'btnCentroCostos
        '
        Me.btnCentroCostos.Caption = "Centros de Costo"
        Me.btnCentroCostos.Id = 61
        Me.btnCentroCostos.ItemAppearance.Disabled.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnCentroCostos.ItemAppearance.Disabled.Options.UseFont = True
        Me.btnCentroCostos.ItemAppearance.Hovered.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnCentroCostos.ItemAppearance.Hovered.Options.UseFont = True
        Me.btnCentroCostos.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnCentroCostos.ItemAppearance.Normal.Options.UseFont = True
        Me.btnCentroCostos.ItemAppearance.Pressed.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnCentroCostos.ItemAppearance.Pressed.Options.UseFont = True
        Me.btnCentroCostos.Name = "btnCentroCostos"
        '
        'btnDependencias
        '
        Me.btnDependencias.Caption = "Dependencias"
        Me.btnDependencias.Id = 62
        Me.btnDependencias.ItemAppearance.Disabled.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnDependencias.ItemAppearance.Disabled.Options.UseFont = True
        Me.btnDependencias.ItemAppearance.Hovered.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnDependencias.ItemAppearance.Hovered.Options.UseFont = True
        Me.btnDependencias.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnDependencias.ItemAppearance.Normal.Options.UseFont = True
        Me.btnDependencias.ItemAppearance.Pressed.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnDependencias.ItemAppearance.Pressed.Options.UseFont = True
        Me.btnDependencias.Name = "btnDependencias"
        '
        'bsiPeriodosLiquidacion
        '
        Me.bsiPeriodosLiquidacion.Caption = "Periodos de Liquidación"
        Me.bsiPeriodosLiquidacion.Id = 63
        Me.bsiPeriodosLiquidacion.ItemAppearance.Disabled.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.bsiPeriodosLiquidacion.ItemAppearance.Disabled.Options.UseFont = True
        Me.bsiPeriodosLiquidacion.ItemAppearance.Hovered.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.bsiPeriodosLiquidacion.ItemAppearance.Hovered.Options.UseFont = True
        Me.bsiPeriodosLiquidacion.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.bsiPeriodosLiquidacion.ItemAppearance.Normal.Options.UseFont = True
        Me.bsiPeriodosLiquidacion.ItemAppearance.Pressed.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.bsiPeriodosLiquidacion.ItemAppearance.Pressed.Options.UseFont = True
        Me.bsiPeriodosLiquidacion.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnGenPeriodos), New DevExpress.XtraBars.LinkPersistInfo(Me.btnPeriodos)})
        Me.bsiPeriodosLiquidacion.Name = "bsiPeriodosLiquidacion"
        '
        'btnGenPeriodos
        '
        Me.btnGenPeriodos.Caption = "Generar Periodos"
        Me.btnGenPeriodos.Id = 64
        Me.btnGenPeriodos.ItemAppearance.Disabled.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnGenPeriodos.ItemAppearance.Disabled.Options.UseFont = True
        Me.btnGenPeriodos.ItemAppearance.Hovered.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnGenPeriodos.ItemAppearance.Hovered.Options.UseFont = True
        Me.btnGenPeriodos.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnGenPeriodos.ItemAppearance.Normal.Options.UseFont = True
        Me.btnGenPeriodos.ItemAppearance.Pressed.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnGenPeriodos.ItemAppearance.Pressed.Options.UseFont = True
        Me.btnGenPeriodos.Name = "btnGenPeriodos"
        '
        'btnNuevaNomina
        '
        Me.btnNuevaNomina.Caption = "Nominas"
        Me.btnNuevaNomina.Id = 66
        Me.btnNuevaNomina.ItemAppearance.Disabled.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnNuevaNomina.ItemAppearance.Disabled.Options.UseFont = True
        Me.btnNuevaNomina.ItemAppearance.Hovered.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnNuevaNomina.ItemAppearance.Hovered.Options.UseFont = True
        Me.btnNuevaNomina.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnNuevaNomina.ItemAppearance.Normal.Options.UseFont = True
        Me.btnNuevaNomina.ItemAppearance.Pressed.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnNuevaNomina.ItemAppearance.Pressed.Options.UseFont = True
        Me.btnNuevaNomina.Name = "btnNuevaNomina"
        '
        'btnEntidades
        '
        Me.btnEntidades.Caption = "Entidades"
        Me.btnEntidades.Id = 67
        Me.btnEntidades.ItemAppearance.Disabled.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnEntidades.ItemAppearance.Disabled.Options.UseFont = True
        Me.btnEntidades.ItemAppearance.Hovered.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnEntidades.ItemAppearance.Hovered.Options.UseFont = True
        Me.btnEntidades.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnEntidades.ItemAppearance.Normal.Options.UseFont = True
        Me.btnEntidades.ItemAppearance.Pressed.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnEntidades.ItemAppearance.Pressed.Options.UseFont = True
        Me.btnEntidades.Name = "btnEntidades"
        '
        'btaggbases
        '
        Me.btaggbases.Caption = "Bases"
        Me.btaggbases.Id = 69
        Me.btaggbases.ItemAppearance.Disabled.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btaggbases.ItemAppearance.Disabled.Options.UseFont = True
        Me.btaggbases.ItemAppearance.Hovered.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btaggbases.ItemAppearance.Hovered.Options.UseFont = True
        Me.btaggbases.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btaggbases.ItemAppearance.Normal.Options.UseFont = True
        Me.btaggbases.ItemAppearance.Pressed.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btaggbases.ItemAppearance.Pressed.Options.UseFont = True
        Me.btaggbases.Name = "btaggbases"
        '
        'btnProfesiones
        '
        Me.btnProfesiones.Caption = "Profesiones"
        Me.btnProfesiones.Id = 70
        Me.btnProfesiones.ItemAppearance.Disabled.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnProfesiones.ItemAppearance.Disabled.Options.UseFont = True
        Me.btnProfesiones.ItemAppearance.Hovered.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnProfesiones.ItemAppearance.Hovered.Options.UseFont = True
        Me.btnProfesiones.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnProfesiones.ItemAppearance.Normal.Options.UseFont = True
        Me.btnProfesiones.ItemAppearance.Pressed.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnProfesiones.ItemAppearance.Pressed.Options.UseFont = True
        Me.btnProfesiones.Name = "btnProfesiones"
        '
        'menuTablasCatalogo
        '
        Me.menuTablasCatalogo.Caption = "Tablas de Catálogo"
        Me.menuTablasCatalogo.Id = 71
        Me.menuTablasCatalogo.ItemAppearance.Disabled.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.menuTablasCatalogo.ItemAppearance.Disabled.Options.UseFont = True
        Me.menuTablasCatalogo.ItemAppearance.Hovered.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.menuTablasCatalogo.ItemAppearance.Hovered.Options.UseFont = True
        Me.menuTablasCatalogo.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.menuTablasCatalogo.ItemAppearance.Normal.Options.UseFont = True
        Me.menuTablasCatalogo.ItemAppearance.Pressed.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.menuTablasCatalogo.ItemAppearance.Pressed.Options.UseFont = True
        Me.menuTablasCatalogo.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnClaseLicencia), New DevExpress.XtraBars.LinkPersistInfo(Me.btnDepartamentos), New DevExpress.XtraBars.LinkPersistInfo(Me.btnEstadoCivil), New DevExpress.XtraBars.LinkPersistInfo(Me.btnMunicipios), New DevExpress.XtraBars.LinkPersistInfo(Me.btnNivelEducativo), New DevExpress.XtraBars.LinkPersistInfo(Me.btnPaises), New DevExpress.XtraBars.LinkPersistInfo(Me.btnParentezco), New DevExpress.XtraBars.LinkPersistInfo(Me.btnProfesiones), New DevExpress.XtraBars.LinkPersistInfo(Me.btnTiposId)})
        Me.menuTablasCatalogo.Name = "menuTablasCatalogo"
        '
        'btnClaseLicencia
        '
        Me.btnClaseLicencia.Caption = "Clase Licencia de Conducción"
        Me.btnClaseLicencia.Id = 73
        Me.btnClaseLicencia.ItemAppearance.Disabled.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnClaseLicencia.ItemAppearance.Disabled.Options.UseFont = True
        Me.btnClaseLicencia.ItemAppearance.Hovered.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnClaseLicencia.ItemAppearance.Hovered.Options.UseFont = True
        Me.btnClaseLicencia.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnClaseLicencia.ItemAppearance.Normal.Options.UseFont = True
        Me.btnClaseLicencia.ItemAppearance.Pressed.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnClaseLicencia.ItemAppearance.Pressed.Options.UseFont = True
        Me.btnClaseLicencia.Name = "btnClaseLicencia"
        '
        'btnDepartamentos
        '
        Me.btnDepartamentos.Caption = "Departamentos"
        Me.btnDepartamentos.Id = 78
        Me.btnDepartamentos.ItemAppearance.Disabled.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnDepartamentos.ItemAppearance.Disabled.Options.UseFont = True
        Me.btnDepartamentos.ItemAppearance.Hovered.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnDepartamentos.ItemAppearance.Hovered.Options.UseFont = True
        Me.btnDepartamentos.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnDepartamentos.ItemAppearance.Normal.Options.UseFont = True
        Me.btnDepartamentos.ItemAppearance.Pressed.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnDepartamentos.ItemAppearance.Pressed.Options.UseFont = True
        Me.btnDepartamentos.Name = "btnDepartamentos"
        '
        'btnEstadoCivil
        '
        Me.btnEstadoCivil.Caption = "Estado Civil"
        Me.btnEstadoCivil.Id = 74
        Me.btnEstadoCivil.ItemAppearance.Disabled.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnEstadoCivil.ItemAppearance.Disabled.Options.UseFont = True
        Me.btnEstadoCivil.ItemAppearance.Hovered.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnEstadoCivil.ItemAppearance.Hovered.Options.UseFont = True
        Me.btnEstadoCivil.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnEstadoCivil.ItemAppearance.Normal.Options.UseFont = True
        Me.btnEstadoCivil.ItemAppearance.Pressed.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnEstadoCivil.ItemAppearance.Pressed.Options.UseFont = True
        Me.btnEstadoCivil.Name = "btnEstadoCivil"
        '
        'btnMunicipios
        '
        Me.btnMunicipios.Caption = "Municipios"
        Me.btnMunicipios.Id = 79
        Me.btnMunicipios.ItemAppearance.Disabled.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnMunicipios.ItemAppearance.Disabled.Options.UseFont = True
        Me.btnMunicipios.ItemAppearance.Hovered.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnMunicipios.ItemAppearance.Hovered.Options.UseFont = True
        Me.btnMunicipios.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnMunicipios.ItemAppearance.Normal.Options.UseFont = True
        Me.btnMunicipios.ItemAppearance.Pressed.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnMunicipios.ItemAppearance.Pressed.Options.UseFont = True
        Me.btnMunicipios.Name = "btnMunicipios"
        '
        'btnNivelEducativo
        '
        Me.btnNivelEducativo.Caption = "Nivel Educativo"
        Me.btnNivelEducativo.Id = 72
        Me.btnNivelEducativo.ItemAppearance.Disabled.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnNivelEducativo.ItemAppearance.Disabled.Options.UseFont = True
        Me.btnNivelEducativo.ItemAppearance.Hovered.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnNivelEducativo.ItemAppearance.Hovered.Options.UseFont = True
        Me.btnNivelEducativo.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnNivelEducativo.ItemAppearance.Normal.Options.UseFont = True
        Me.btnNivelEducativo.ItemAppearance.Pressed.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnNivelEducativo.ItemAppearance.Pressed.Options.UseFont = True
        Me.btnNivelEducativo.Name = "btnNivelEducativo"
        '
        'btnPaises
        '
        Me.btnPaises.Caption = "Paises"
        Me.btnPaises.Id = 77
        Me.btnPaises.ItemAppearance.Disabled.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnPaises.ItemAppearance.Disabled.Options.UseFont = True
        Me.btnPaises.ItemAppearance.Hovered.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnPaises.ItemAppearance.Hovered.Options.UseFont = True
        Me.btnPaises.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnPaises.ItemAppearance.Normal.Options.UseFont = True
        Me.btnPaises.ItemAppearance.Pressed.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnPaises.ItemAppearance.Pressed.Options.UseFont = True
        Me.btnPaises.Name = "btnPaises"
        '
        'btnParentezco
        '
        Me.btnParentezco.Caption = "Parentezco"
        Me.btnParentezco.Id = 76
        Me.btnParentezco.ItemAppearance.Disabled.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnParentezco.ItemAppearance.Disabled.Options.UseFont = True
        Me.btnParentezco.ItemAppearance.Hovered.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnParentezco.ItemAppearance.Hovered.Options.UseFont = True
        Me.btnParentezco.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnParentezco.ItemAppearance.Normal.Options.UseFont = True
        Me.btnParentezco.ItemAppearance.Pressed.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnParentezco.ItemAppearance.Pressed.Options.UseFont = True
        Me.btnParentezco.Name = "btnParentezco"
        '
        'btnTiposId
        '
        Me.btnTiposId.Caption = "Tipos de documento de Identidad"
        Me.btnTiposId.Id = 75
        Me.btnTiposId.ItemAppearance.Disabled.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnTiposId.ItemAppearance.Disabled.Options.UseFont = True
        Me.btnTiposId.ItemAppearance.Hovered.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnTiposId.ItemAppearance.Hovered.Options.UseFont = True
        Me.btnTiposId.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnTiposId.ItemAppearance.Normal.Options.UseFont = True
        Me.btnTiposId.ItemAppearance.Pressed.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnTiposId.ItemAppearance.Pressed.Options.UseFont = True
        Me.btnTiposId.Name = "btnTiposId"
        '
        'btnConceptosPersonales
        '
        Me.btnConceptosPersonales.Caption = "Conceptos Personales"
        Me.btnConceptosPersonales.Id = 80
        Me.btnConceptosPersonales.Name = "btnConceptosPersonales"
        '
        'BarSubItem1
        '
        Me.BarSubItem1.Caption = "BarSubItem1"
        Me.BarSubItem1.Id = 81
        Me.BarSubItem1.Name = "BarSubItem1"
        '
        'btnClasConceptosNomina
        '
        Me.btnClasConceptosNomina.Caption = "Clasificación de Conceptos"
        Me.btnClasConceptosNomina.Id = 82
        Me.btnClasConceptosNomina.Name = "btnClasConceptosNomina"
        '
        'btnClasConceptosPersonales
        '
        Me.btnClasConceptosPersonales.Caption = "Clasificación de Conceptos Personales"
        Me.btnClasConceptosPersonales.Id = 83
        Me.btnClasConceptosPersonales.Name = "btnClasConceptosPersonales"
        '
        'btnDescuentosNomina
        '
        Me.btnDescuentosNomina.Caption = "Asignar Descuentos"
        Me.btnDescuentosNomina.Id = 84
        Me.btnDescuentosNomina.Name = "btnDescuentosNomina"
        '
        'btnAggValExentos
        '
        Me.btnAggValExentos.Caption = "Asignar Valores Exentos"
        Me.btnAggValExentos.Id = 85
        Me.btnAggValExentos.Name = "btnAggValExentos"
        '
        'btnValMaxDescuento
        '
        Me.btnValMaxDescuento.Caption = "Asignar Valor Maximo a Descontar"
        Me.btnValMaxDescuento.Id = 86
        Me.btnValMaxDescuento.Name = "btnValMaxDescuento"
        '
        'btnModAsignaciones
        '
        Me.btnModAsignaciones.Caption = "Modificar Asignaciones Salariales"
        Me.btnModAsignaciones.Id = 87
        Me.btnModAsignaciones.Name = "btnModAsignaciones"
        '
        'menuEmpleado
        '
        Me.menuEmpleado.Caption = "Empleados"
        Me.menuEmpleado.Id = 88
        Me.menuEmpleado.ItemAppearance.Disabled.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.menuEmpleado.ItemAppearance.Disabled.Options.UseFont = True
        Me.menuEmpleado.ItemAppearance.Hovered.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.menuEmpleado.ItemAppearance.Hovered.Options.UseFont = True
        Me.menuEmpleado.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.menuEmpleado.ItemAppearance.Normal.Options.UseFont = True
        Me.menuEmpleado.ItemAppearance.Pressed.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.menuEmpleado.ItemAppearance.Pressed.Options.UseFont = True
        Me.menuEmpleado.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnNuevoEmpleado), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem48)})
        Me.menuEmpleado.Name = "menuEmpleado"
        Me.menuEmpleado.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
            Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Listar Empleados"
        Me.BarButtonItem2.Id = 89
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem48
        '
        Me.BarButtonItem48.Caption = "Importar Empleados"
        Me.BarButtonItem48.Id = 197
        Me.BarButtonItem48.Name = "BarButtonItem48"
        '
        'btcConfigConceptos
        '
        Me.btcConfigConceptos.Caption = "Configurar Conceptos"
        Me.btcConfigConceptos.Id = 91
        Me.btcConfigConceptos.Name = "btcConfigConceptos"
        '
        'btnConfigNominas
        '
        Me.btnConfigNominas.Caption = "Configurar Nominas"
        Me.btnConfigNominas.Id = 92
        Me.btnConfigNominas.Name = "btnConfigNominas"
        '
        'btcConfigTipoContratos
        '
        Me.btcConfigTipoContratos.Caption = "Configurar Liquidacion de Tipos de Contratos"
        Me.btcConfigTipoContratos.Id = 93
        Me.btcConfigTipoContratos.Name = "btcConfigTipoContratos"
        '
        'btnConfigPrestacionesS
        '
        Me.btnConfigPrestacionesS.Caption = "Configurar Prestaciones Sociales y Otros"
        Me.btnConfigPrestacionesS.Id = 94
        Me.btnConfigPrestacionesS.Name = "btnConfigPrestacionesS"
        '
        'btnLiquidarProvisiones
        '
        Me.btnLiquidarProvisiones.Caption = "Liquidar Provisiones"
        Me.btnLiquidarProvisiones.Id = 95
        Me.btnLiquidarProvisiones.Name = "btnLiquidarProvisiones"
        '
        'btnLiquidacionExtraor
        '
        Me.btnLiquidacionExtraor.Caption = "Liquidaciones Extraordinarias"
        Me.btnLiquidacionExtraor.Id = 96
        Me.btnLiquidacionExtraor.Name = "btnLiquidacionExtraor"
        '
        'btnLiquidarContrato
        '
        Me.btnLiquidarContrato.Caption = "Liquidar Contratos"
        Me.btnLiquidarContrato.Id = 97
        Me.btnLiquidarContrato.Name = "btnLiquidarContrato"
        '
        'btnContratos
        '
        Me.btnContratos.Caption = "Contratos"
        Me.btnContratos.Id = 99
        Me.btnContratos.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnAggContratos), New DevExpress.XtraBars.LinkPersistInfo(Me.btnAsigValoresExentos), New DevExpress.XtraBars.LinkPersistInfo(Me.btnAsigDescuentos), New DevExpress.XtraBars.LinkPersistInfo(Me.btnAsigNominas), New DevExpress.XtraBars.LinkPersistInfo(Me.btnModAsignaSalariales)})
        Me.btnContratos.Name = "btnContratos"
        Me.btnContratos.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
            Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        '
        'btnAggContratos
        '
        Me.btnAggContratos.Caption = "Agregar/Editar Contrato"
        Me.btnAggContratos.Id = 102
        Me.btnAggContratos.Name = "btnAggContratos"
        '
        'btnAsigValoresExentos
        '
        Me.btnAsigValoresExentos.Caption = "Asignar Valores Exentos"
        Me.btnAsigValoresExentos.Id = 104
        Me.btnAsigValoresExentos.Name = "btnAsigValoresExentos"
        '
        'btnAsigDescuentos
        '
        Me.btnAsigDescuentos.Caption = "Asignar Descuentos Por Nomina"
        Me.btnAsigDescuentos.Id = 105
        Me.btnAsigDescuentos.Name = "btnAsigDescuentos"
        '
        'btnAsigNominas
        '
        Me.btnAsigNominas.Caption = "Asignar Nominas"
        Me.btnAsigNominas.Id = 106
        Me.btnAsigNominas.Name = "btnAsigNominas"
        '
        'btnModAsignaSalariales
        '
        Me.btnModAsignaSalariales.Caption = "Modificar Asignaciones Salariales"
        Me.btnModAsignaSalariales.Id = 103
        Me.btnModAsignaSalariales.Name = "btnModAsignaSalariales"
        '
        'btnCargos
        '
        Me.btnCargos.Caption = "Cargos"
        Me.btnCargos.Id = 100
        Me.btnCargos.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnAggCargo), New DevExpress.XtraBars.LinkPersistInfo(Me.btnFunciones)})
        Me.btnCargos.Name = "btnCargos"
        Me.btnCargos.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
            Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        '
        'btnAggCargo
        '
        Me.btnAggCargo.Caption = "Agregar/Editar Cargo"
        Me.btnAggCargo.Id = 111
        Me.btnAggCargo.Name = "btnAggCargo"
        '
        'btnFunciones
        '
        Me.btnFunciones.Caption = "Funciones"
        Me.btnFunciones.Id = 112
        Me.btnFunciones.Name = "btnFunciones"
        '
        'btnNominas
        '
        Me.btnNominas.Caption = "Nominas"
        Me.btnNominas.Id = 101
        Me.btnNominas.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnAggNominas), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem8)})
        Me.btnNominas.Name = "btnNominas"
        Me.btnNominas.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
            Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        ToolTipTitleItem8.Text = "Creación de Nóminas"
        ToolTipItem8.LeftIndent = 6
        ToolTipItem8.Text = "Se crean nóminas para asociar los contratos a ellas y liquidarlas por aparte con " &
    "parametros diferentes"
        SuperToolTip8.Items.Add(ToolTipTitleItem8)
        SuperToolTip8.Items.Add(ToolTipItem8)
        Me.btnNominas.SuperTip = SuperToolTip8
        '
        'btnAggNominas
        '
        Me.btnAggNominas.Caption = "Agregar/Editar"
        Me.btnAggNominas.Id = 115
        Me.btnAggNominas.ImageOptions.LargeImage = CType(resources.GetObject("btnAggNominas.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnAggNominas.Name = "btnAggNominas"
        '
        'BarSubItem8
        '
        Me.BarSubItem8.Caption = "Periodos Liquidacion"
        Me.BarSubItem8.Id = 193
        Me.BarSubItem8.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem45), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem46)})
        Me.BarSubItem8.Name = "BarSubItem8"
        '
        'BarButtonItem45
        '
        Me.BarButtonItem45.Caption = "Generar"
        Me.BarButtonItem45.Id = 194
        Me.BarButtonItem45.Name = "BarButtonItem45"
        '
        'BarButtonItem46
        '
        Me.BarButtonItem46.Caption = "Consultar/Editar"
        Me.BarButtonItem46.Id = 195
        Me.BarButtonItem46.Name = "BarButtonItem46"
        '
        'btnSubOtrosContratos
        '
        Me.btnSubOtrosContratos.Caption = "Otros"
        Me.btnSubOtrosContratos.Id = 107
        Me.btnSubOtrosContratos.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bntTiposContratos), New DevExpress.XtraBars.LinkPersistInfo(Me.bntDependencia), New DevExpress.XtraBars.LinkPersistInfo(Me.btnCentrosCostos), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem13)})
        Me.btnSubOtrosContratos.Name = "btnSubOtrosContratos"
        '
        'bntTiposContratos
        '
        Me.bntTiposContratos.Caption = "Tipos de Contratos"
        Me.bntTiposContratos.Id = 108
        Me.bntTiposContratos.Name = "bntTiposContratos"
        '
        'bntDependencia
        '
        Me.bntDependencia.Caption = "Dependencias"
        Me.bntDependencia.Id = 109
        Me.bntDependencia.Name = "bntDependencia"
        '
        'btnCentrosCostos
        '
        Me.btnCentrosCostos.Caption = "Centros de Costo"
        Me.btnCentrosCostos.Id = 110
        Me.btnCentrosCostos.Name = "btnCentrosCostos"
        '
        'BarButtonItem13
        '
        Me.BarButtonItem13.Caption = "Cargos"
        Me.BarButtonItem13.Id = 151
        Me.BarButtonItem13.Name = "BarButtonItem13"
        '
        'btnSubNomina
        '
        Me.btnSubNomina.Caption = "Nominas"
        Me.btnSubNomina.Id = 114
        Me.btnSubNomina.Name = "btnSubNomina"
        '
        'btnConfigNomina
        '
        Me.btnConfigNomina.Caption = "Configurar Cuentas"
        Me.btnConfigNomina.Id = 116
        Me.btnConfigNomina.Name = "btnConfigNomina"
        '
        'BarButtonItem10
        '
        Me.BarButtonItem10.Caption = "Conceptos"
        Me.BarButtonItem10.Id = 117
        Me.BarButtonItem10.Name = "BarButtonItem10"
        '
        'btnSubConceptos
        '
        Me.btnSubConceptos.Caption = "Conceptos"
        Me.btnSubConceptos.Id = 118
        Me.btnSubConceptos.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnSubValoresCalculo), New DevExpress.XtraBars.LinkPersistInfo(Me.btnAggBases), New DevExpress.XtraBars.LinkPersistInfo(Me.btnSubConceptosNom), New DevExpress.XtraBars.LinkPersistInfo(Me.btnSubConceptosPersonales)})
        Me.btnSubConceptos.Name = "btnSubConceptos"
        '
        'btnSubValoresCalculo
        '
        Me.btnSubValoresCalculo.Caption = "Valores de Calculo"
        Me.btnSubValoresCalculo.Id = 119
        Me.btnSubValoresCalculo.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnValoresPersonales), New DevExpress.XtraBars.LinkPersistInfo(Me.btnValoresGenerales)})
        Me.btnSubValoresCalculo.Name = "btnSubValoresCalculo"
        '
        'btnValoresPersonales
        '
        Me.btnValoresPersonales.Caption = "Valores Personales"
        Me.btnValoresPersonales.Id = 120
        Me.btnValoresPersonales.Name = "btnValoresPersonales"
        '
        'btnValoresGenerales
        '
        Me.btnValoresGenerales.Caption = "Valores Generales"
        Me.btnValoresGenerales.Id = 121
        Me.btnValoresGenerales.Name = "btnValoresGenerales"
        '
        'btnAggBases
        '
        Me.btnAggBases.Caption = "Bases"
        Me.btnAggBases.Id = 122
        Me.btnAggBases.Name = "btnAggBases"
        '
        'btnSubConceptosNom
        '
        Me.btnSubConceptosNom.Caption = "Conceptos Nomina"
        Me.btnSubConceptosNom.Id = 124
        Me.btnSubConceptosNom.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnConceptosNomina), New DevExpress.XtraBars.LinkPersistInfo(Me.btnClasiConcepNom), New DevExpress.XtraBars.LinkPersistInfo(Me.CofigConcepNomina)})
        Me.btnSubConceptosNom.Name = "btnSubConceptosNom"
        '
        'btnConceptosNomina
        '
        Me.btnConceptosNomina.Caption = "Agregar/Editar"
        Me.btnConceptosNomina.Id = 125
        Me.btnConceptosNomina.Name = "btnConceptosNomina"
        '
        'btnClasiConcepNom
        '
        Me.btnClasiConcepNom.Caption = "Clasificacion"
        Me.btnClasiConcepNom.Id = 126
        Me.btnClasiConcepNom.Name = "btnClasiConcepNom"
        '
        'CofigConcepNomina
        '
        Me.CofigConcepNomina.Caption = "Configurar"
        Me.CofigConcepNomina.Id = 150
        Me.CofigConcepNomina.Name = "CofigConcepNomina"
        '
        'btnSubConceptosPersonales
        '
        Me.btnSubConceptosPersonales.Caption = "Conceptos Personales"
        Me.btnSubConceptosPersonales.Id = 127
        Me.btnSubConceptosPersonales.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnConceptosPersona), New DevExpress.XtraBars.LinkPersistInfo(Me.btnClasiConcepPersonales)})
        Me.btnSubConceptosPersonales.Name = "btnSubConceptosPersonales"
        '
        'btnConceptosPersona
        '
        Me.btnConceptosPersona.Caption = "Agregar/Editar"
        Me.btnConceptosPersona.Id = 128
        Me.btnConceptosPersona.Name = "btnConceptosPersona"
        '
        'btnClasiConcepPersonales
        '
        Me.btnClasiConcepPersonales.Caption = "Clasificacion"
        Me.btnClasiConcepPersonales.Id = 129
        Me.btnClasiConcepPersonales.Name = "btnClasiConcepPersonales"
        '
        'btnConceptosNom
        '
        Me.btnConceptosNom.Caption = "Conceptos Nomina"
        Me.btnConceptosNom.Id = 123
        Me.btnConceptosNom.Name = "btnConceptosNom"
        '
        'BarButtonItem11
        '
        Me.BarButtonItem11.Caption = "Perfil de Conceptos"
        Me.BarButtonItem11.Id = 130
        Me.BarButtonItem11.Name = "BarButtonItem11"
        '
        'btnSubPerfilConceptos
        '
        Me.btnSubPerfilConceptos.Caption = "Perfil de Conceptos"
        Me.btnSubPerfilConceptos.Id = 131
        Me.btnSubPerfilConceptos.Name = "btnSubPerfilConceptos"
        '
        'btnPerfilConceptos
        '
        Me.btnPerfilConceptos.Caption = "Agregar/Editar"
        Me.btnPerfilConceptos.Id = 132
        Me.btnPerfilConceptos.Name = "btnPerfilConceptos"
        '
        'btnAsigValorMaximo
        '
        Me.btnAsigValorMaximo.Caption = "Asignar Valores Maximos a Descontar"
        Me.btnAsigValorMaximo.Id = 133
        Me.btnAsigValorMaximo.Name = "btnAsigValorMaximo"
        '
        'btnSubLiquidaciones
        '
        Me.btnSubLiquidaciones.Caption = "Liquidaciones"
        Me.btnSubLiquidaciones.Id = 134
        Me.btnSubLiquidaciones.Name = "btnSubLiquidaciones"
        '
        'btnSubLiquidacionPeriodos
        '
        Me.btnSubLiquidacionPeriodos.Caption = "Liquidacion de Periodos"
        Me.btnSubLiquidacionPeriodos.Id = 135
        Me.btnSubLiquidacionPeriodos.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnLiquidarPeriodo), New DevExpress.XtraBars.LinkPersistInfo(Me.btnConfigurarLiquidaPeriodos), New DevExpress.XtraBars.LinkPersistInfo(Me.btnConfigNomina)})
        Me.btnSubLiquidacionPeriodos.Name = "btnSubLiquidacionPeriodos"
        '
        'btnNovedades
        '
        Me.btnNovedades.Caption = "Novedades"
        Me.btnNovedades.Id = 136
        Me.btnNovedades.Name = "btnNovedades"
        '
        'btnLiquidarPeriodo
        '
        Me.btnLiquidarPeriodo.Caption = "Liquidar Periodo"
        Me.btnLiquidarPeriodo.Id = 137
        Me.btnLiquidarPeriodo.Name = "btnLiquidarPeriodo"
        '
        'btnConfigurarLiquidaPeriodos
        '
        Me.btnConfigurarLiquidaPeriodos.Caption = "Configurar Formulas"
        Me.btnConfigurarLiquidaPeriodos.Id = 138
        Me.btnConfigurarLiquidaPeriodos.Name = "btnConfigurarLiquidaPeriodos"
        '
        'btnSubLiquidacionPrestaciones
        '
        Me.btnSubLiquidacionPrestaciones.Caption = "Liquidacion de Semestres"
        Me.btnSubLiquidacionPrestaciones.Id = 139
        Me.btnSubLiquidacionPrestaciones.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bntLiquidarPrestaciones), New DevExpress.XtraBars.LinkPersistInfo(Me.btnConfigLiquidaPrestaciones)})
        Me.btnSubLiquidacionPrestaciones.Name = "btnSubLiquidacionPrestaciones"
        '
        'bntLiquidarPrestaciones
        '
        Me.bntLiquidarPrestaciones.Caption = "Liquidar"
        Me.bntLiquidarPrestaciones.Id = 140
        Me.bntLiquidarPrestaciones.Name = "bntLiquidarPrestaciones"
        '
        'btnConfigLiquidaPrestaciones
        '
        Me.btnConfigLiquidaPrestaciones.Caption = "Configurar Liquidacion"
        Me.btnConfigLiquidaPrestaciones.Id = 141
        Me.btnConfigLiquidaPrestaciones.Name = "btnConfigLiquidaPrestaciones"
        '
        'btnLiquidacionExtraordinaria
        '
        Me.btnLiquidacionExtraordinaria.Caption = "Liquidacion Extraordinaria"
        Me.btnLiquidacionExtraordinaria.Id = 142
        Me.btnLiquidacionExtraordinaria.Name = "btnLiquidacionExtraordinaria"
        '
        'btnSubLiquidaContratos
        '
        Me.btnSubLiquidaContratos.Caption = "Liquidacion de Contratos"
        Me.btnSubLiquidaContratos.Id = 143
        Me.btnSubLiquidaContratos.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnLiquidarContratos), New DevExpress.XtraBars.LinkPersistInfo(Me.btnConfigLiquidacion)})
        Me.btnSubLiquidaContratos.Name = "btnSubLiquidaContratos"
        '
        'btnLiquidarContratos
        '
        Me.btnLiquidarContratos.Caption = "Liquidar Contrato"
        Me.btnLiquidarContratos.Id = 144
        Me.btnLiquidarContratos.Name = "btnLiquidarContratos"
        '
        'btnConfigLiquidacion
        '
        Me.btnConfigLiquidacion.Caption = "Configurar Liquidacion"
        Me.btnConfigLiquidacion.Id = 145
        Me.btnConfigLiquidacion.Name = "btnConfigLiquidacion"
        '
        'btnConsultarLiquidacion
        '
        Me.btnConsultarLiquidacion.Caption = "Consultar Liquidaciones"
        Me.btnConsultarLiquidacion.Id = 146
        Me.btnConsultarLiquidacion.Name = "btnConsultarLiquidacion"
        '
        'btnBancos
        '
        Me.btnBancos.Caption = "Bancos"
        Me.btnBancos.Id = 147
        Me.btnBancos.Name = "btnBancos"
        '
        'b
        '
        Me.b.Caption = "Prueba"
        Me.b.Id = 148
        Me.b.Name = "b"
        '
        'BarButtonItem12
        '
        Me.BarButtonItem12.Caption = "Valores Exentos"
        Me.BarButtonItem12.Id = 149
        Me.BarButtonItem12.Name = "BarButtonItem12"
        '
        'btnConfiguracion
        '
        Me.btnConfiguracion.Caption = "Configurar"
        Me.btnConfiguracion.Id = 152
        Me.btnConfiguracion.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem14), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem15), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem3), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem17), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem18), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem19), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem29), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem4), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem39), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem43), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem12)})
        Me.btnConfiguracion.Name = "btnConfiguracion"
        Me.btnConfiguracion.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
            Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        '
        'BarSubItem2
        '
        Me.BarSubItem2.Caption = "Tablas de Catalogo"
        Me.BarSubItem2.Id = 153
        Me.BarSubItem2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem21), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem22), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem23), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem24), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem25), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem26), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem27), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem28)})
        Me.BarSubItem2.Name = "BarSubItem2"
        '
        'BarButtonItem21
        '
        Me.BarButtonItem21.Caption = "Nivel Educativo"
        Me.BarButtonItem21.Id = 162
        Me.BarButtonItem21.Name = "BarButtonItem21"
        '
        'BarButtonItem22
        '
        Me.BarButtonItem22.Caption = "Titulo Profesion"
        Me.BarButtonItem22.Id = 163
        Me.BarButtonItem22.Name = "BarButtonItem22"
        '
        'BarButtonItem23
        '
        Me.BarButtonItem23.Caption = "Clase Licencia Conduccion"
        Me.BarButtonItem23.Id = 164
        Me.BarButtonItem23.Name = "BarButtonItem23"
        '
        'BarButtonItem24
        '
        Me.BarButtonItem24.Caption = "Estado Civil"
        Me.BarButtonItem24.Id = 165
        Me.BarButtonItem24.Name = "BarButtonItem24"
        '
        'BarButtonItem25
        '
        Me.BarButtonItem25.Caption = "Parentesco"
        Me.BarButtonItem25.Id = 166
        Me.BarButtonItem25.Name = "BarButtonItem25"
        '
        'BarButtonItem26
        '
        Me.BarButtonItem26.Caption = "Departamento"
        Me.BarButtonItem26.Id = 167
        Me.BarButtonItem26.Name = "BarButtonItem26"
        '
        'BarButtonItem27
        '
        Me.BarButtonItem27.Caption = "Pais"
        Me.BarButtonItem27.Id = 168
        Me.BarButtonItem27.Name = "BarButtonItem27"
        '
        'BarButtonItem28
        '
        Me.BarButtonItem28.Caption = "Tipo Documento Identidad"
        Me.BarButtonItem28.Id = 169
        Me.BarButtonItem28.Name = "BarButtonItem28"
        '
        'BarButtonItem14
        '
        Me.BarButtonItem14.Caption = "Bancos"
        Me.BarButtonItem14.Id = 154
        Me.BarButtonItem14.Name = "BarButtonItem14"
        '
        'BarButtonItem15
        '
        Me.BarButtonItem15.Caption = "Entidades"
        Me.BarButtonItem15.Id = 155
        Me.BarButtonItem15.Name = "BarButtonItem15"
        '
        'BarSubItem3
        '
        Me.BarSubItem3.Caption = "Cargos"
        Me.BarSubItem3.Id = 157
        Me.BarSubItem3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem31), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem32), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem44)})
        Me.BarSubItem3.Name = "BarSubItem3"
        '
        'BarButtonItem31
        '
        Me.BarButtonItem31.Caption = "Agregar/Editar"
        Me.BarButtonItem31.Id = 172
        Me.BarButtonItem31.Name = "BarButtonItem31"
        '
        'BarButtonItem32
        '
        Me.BarButtonItem32.Caption = "Funciones"
        Me.BarButtonItem32.Id = 173
        Me.BarButtonItem32.Name = "BarButtonItem32"
        '
        'BarButtonItem44
        '
        Me.BarButtonItem44.Caption = "Planta de Cargos"
        Me.BarButtonItem44.Id = 192
        Me.BarButtonItem44.Name = "BarButtonItem44"
        '
        'BarButtonItem17
        '
        Me.BarButtonItem17.Caption = "Tipos Contratos"
        Me.BarButtonItem17.Id = 158
        Me.BarButtonItem17.Name = "BarButtonItem17"
        '
        'BarButtonItem18
        '
        Me.BarButtonItem18.Caption = "Dependencias"
        Me.BarButtonItem18.Id = 159
        Me.BarButtonItem18.Name = "BarButtonItem18"
        '
        'BarButtonItem19
        '
        Me.BarButtonItem19.Caption = "Centros de Costo"
        Me.BarButtonItem19.Id = 160
        Me.BarButtonItem19.Name = "BarButtonItem19"
        '
        'BarButtonItem29
        '
        Me.BarButtonItem29.Caption = "Bases de Calculo"
        Me.BarButtonItem29.Id = 170
        Me.BarButtonItem29.Name = "BarButtonItem29"
        '
        'BarSubItem4
        '
        Me.BarSubItem4.Caption = "Valores de Calculo"
        Me.BarSubItem4.Id = 175
        Me.BarSubItem4.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem34), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem35)})
        Me.BarSubItem4.Name = "BarSubItem4"
        '
        'BarButtonItem34
        '
        Me.BarButtonItem34.Caption = "Valores Generales"
        Me.BarButtonItem34.Id = 176
        Me.BarButtonItem34.Name = "BarButtonItem34"
        '
        'BarButtonItem35
        '
        Me.BarButtonItem35.Caption = "Valores Personales"
        Me.BarButtonItem35.Id = 177
        Me.BarButtonItem35.Name = "BarButtonItem35"
        '
        'BarButtonItem39
        '
        Me.BarButtonItem39.Caption = "Clasificación Conceptos Nomina"
        Me.BarButtonItem39.Id = 186
        Me.BarButtonItem39.Name = "BarButtonItem39"
        '
        'BarButtonItem43
        '
        Me.BarButtonItem43.Caption = "Clasificación Conceptos Personales"
        Me.BarButtonItem43.Id = 191
        Me.BarButtonItem43.Name = "BarButtonItem43"
        '
        'BarButtonItem16
        '
        Me.BarButtonItem16.Caption = "BarButtonItem16"
        Me.BarButtonItem16.Id = 156
        Me.BarButtonItem16.Name = "BarButtonItem16"
        '
        'BarButtonItem20
        '
        Me.BarButtonItem20.Id = 161
        Me.BarButtonItem20.Name = "BarButtonItem20"
        '
        'BarButtonItem30
        '
        Me.BarButtonItem30.Caption = "Valores de Calculo"
        Me.BarButtonItem30.Id = 171
        Me.BarButtonItem30.Name = "BarButtonItem30"
        '
        'BarButtonItem33
        '
        Me.BarButtonItem33.Caption = "BarButtonItem33"
        Me.BarButtonItem33.Id = 174
        Me.BarButtonItem33.Name = "BarButtonItem33"
        '
        'BarButtonItem36
        '
        Me.BarButtonItem36.Caption = "Conceptos"
        Me.BarButtonItem36.Id = 178
        Me.BarButtonItem36.Name = "BarButtonItem36"
        Me.BarButtonItem36.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
            Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        '
        'bbiLiquidaciones
        '
        Me.bbiLiquidaciones.Caption = "Liquidaciones"
        Me.bbiLiquidaciones.Id = 179
        Me.bbiLiquidaciones.Name = "bbiLiquidaciones"
        Me.bbiLiquidaciones.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
            Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        '
        'bsiConceptos
        '
        Me.bsiConceptos.Caption = "Conceptos"
        Me.bsiConceptos.Id = 180
        Me.bsiConceptos.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem5), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem47)})
        Me.bsiConceptos.Name = "bsiConceptos"
        Me.bsiConceptos.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
            Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        '
        'BarSubItem5
        '
        Me.BarSubItem5.Caption = "Conceptos Nomina"
        Me.BarSubItem5.Id = 182
        Me.BarSubItem5.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem38), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem7)})
        Me.BarSubItem5.Name = "BarSubItem5"
        '
        'BarButtonItem38
        '
        Me.BarButtonItem38.Caption = "Agregar/Editar"
        Me.BarButtonItem38.Id = 185
        Me.BarButtonItem38.Name = "BarButtonItem38"
        '
        'BarSubItem7
        '
        Me.BarSubItem7.Caption = "Perfil Conceptos"
        Me.BarSubItem7.Id = 187
        Me.BarSubItem7.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnPerfilConceptos), New DevExpress.XtraBars.LinkPersistInfo(Me.btnAsigValorMaximo)})
        Me.BarSubItem7.Name = "BarSubItem7"
        '
        'BarButtonItem47
        '
        Me.BarButtonItem47.Caption = "Conceptos Personales"
        Me.BarButtonItem47.Id = 196
        Me.BarButtonItem47.Name = "BarButtonItem47"
        '
        'bsiLiquidaciones
        '
        Me.bsiLiquidaciones.Caption = "Liquidaciones"
        Me.bsiLiquidaciones.Id = 181
        Me.bsiLiquidaciones.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnSubLiquidacionPeriodos), New DevExpress.XtraBars.LinkPersistInfo(Me.btnSubLiquidacionPrestaciones), New DevExpress.XtraBars.LinkPersistInfo(Me.btnLiquidacionExtraordinaria), New DevExpress.XtraBars.LinkPersistInfo(Me.btnSubLiquidaContratos), New DevExpress.XtraBars.LinkPersistInfo(Me.btnConsultarLiquidacion)})
        Me.bsiLiquidaciones.Name = "bsiLiquidaciones"
        Me.bsiLiquidaciones.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
            Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        '
        'BarButtonItem37
        '
        Me.BarButtonItem37.Caption = "BarButtonItem37"
        Me.BarButtonItem37.Id = 183
        Me.BarButtonItem37.Name = "BarButtonItem37"
        '
        'BarSubItem6
        '
        Me.BarSubItem6.Caption = "Conceptos Personales"
        Me.BarSubItem6.Id = 184
        Me.BarSubItem6.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem42)})
        Me.BarSubItem6.Name = "BarSubItem6"
        '
        'BarButtonItem42
        '
        Me.BarButtonItem42.Caption = "Agregar/Editar"
        Me.BarButtonItem42.Id = 190
        Me.BarButtonItem42.Name = "BarButtonItem42"
        '
        'BarButtonItem40
        '
        Me.BarButtonItem40.Caption = "Agregar/Editar"
        Me.BarButtonItem40.Id = 188
        Me.BarButtonItem40.Name = "BarButtonItem40"
        '
        'BarButtonItem41
        '
        Me.BarButtonItem41.Caption = "Asignar Valores Maximos a Descontar"
        Me.BarButtonItem41.Id = 189
        Me.BarButtonItem41.Name = "BarButtonItem41"
        '
        'PaginaInicio
        '
        Me.PaginaInicio.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.PaginaInicio.Appearance.Options.UseFont = True
        Me.PaginaInicio.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpgConexion, Me.rpgEmpleados, Me.rpgContratos, Me.rpgConceptos, Me.rpgNomina, Me.rpgLiquidaciones, Me.rpgConfig, Me.RibbonPageGroup3, Me.rpgSalir})
        Me.PaginaInicio.Name = "PaginaInicio"
        Me.PaginaInicio.Text = "Inicio"
        '
        'rpgConexion
        '
        Me.rpgConexion.AllowTextClipping = False
        Me.rpgConexion.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
        Me.rpgConexion.ItemLinks.Add(Me.btnConexion, True)
        Me.rpgConexion.Name = "rpgConexion"
        Me.rpgConexion.Text = "Conexión"
        '
        'rpgEmpleados
        '
        Me.rpgEmpleados.AllowTextClipping = False
        Me.rpgEmpleados.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
        Me.rpgEmpleados.ItemLinks.Add(Me.menuEmpleado)
        Me.rpgEmpleados.Name = "rpgEmpleados"
        '
        'rpgContratos
        '
        Me.rpgContratos.AllowTextClipping = False
        Me.rpgContratos.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
        Me.rpgContratos.ItemLinks.Add(Me.btnContratos)
        Me.rpgContratos.Name = "rpgContratos"
        '
        'rpgConceptos
        '
        Me.rpgConceptos.AllowTextClipping = False
        Me.rpgConceptos.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
        Me.rpgConceptos.ItemLinks.Add(Me.bsiConceptos)
        Me.rpgConceptos.Name = "rpgConceptos"
        '
        'rpgNomina
        '
        Me.rpgNomina.AllowTextClipping = False
        Me.rpgNomina.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
        Me.rpgNomina.ItemLinks.Add(Me.btnNominas)
        Me.rpgNomina.Name = "rpgNomina"
        '
        'rpgLiquidaciones
        '
        Me.rpgLiquidaciones.AllowTextClipping = False
        Me.rpgLiquidaciones.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
        Me.rpgLiquidaciones.ItemLinks.Add(Me.bsiLiquidaciones)
        Me.rpgLiquidaciones.Name = "rpgLiquidaciones"
        '
        'rpgConfig
        '
        Me.rpgConfig.AllowTextClipping = False
        Me.rpgConfig.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
        Me.rpgConfig.ItemLinks.Add(Me.btnConfiguracion)
        Me.rpgConfig.Name = "rpgConfig"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.AllowTextClipping = False
        Me.RibbonPageGroup3.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonPageGroup3.ItemLinks.Add(Me.SkinRibbonGalleryBarItem1)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.Text = "Skins"
        '
        'rpgSalir
        '
        Me.rpgSalir.AllowTextClipping = False
        Me.rpgSalir.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
        Me.rpgSalir.ItemLinks.Add(Me.btnSalir)
        Me.rpgSalir.Name = "rpgSalir"
        '
        'RibbonStatusBar1
        '
        Me.RibbonStatusBar1.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.RibbonStatusBar1.ItemLinks.Add(Me.msjEmpresa, True)
        Me.RibbonStatusBar1.ItemLinks.Add(Me.NumEmpresa, True)
        Me.RibbonStatusBar1.ItemLinks.Add(Me.msjOficina, True)
        Me.RibbonStatusBar1.ItemLinks.Add(Me.NumOficina, True)
        Me.RibbonStatusBar1.ItemLinks.Add(Me.FechaTrabajo, True)
        Me.RibbonStatusBar1.ItemLinks.Add(Me.MensajeDeAyuda, True)
        Me.RibbonStatusBar1.Location = New System.Drawing.Point(0, 697)
        Me.RibbonStatusBar1.Name = "RibbonStatusBar1"
        Me.RibbonStatusBar1.Ribbon = Me.rcPrincipal
        Me.RibbonStatusBar1.Size = New System.Drawing.Size(1021, 24)
        '
        'ImagenesSMT16X16
        '
        Me.ImagenesSMT16X16.ImageStream = CType(resources.GetObject("ImagenesSMT16X16.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.ImagenesSMT16X16.InsertGalleryImage("properties_16x16.png", "office2013/setup/properties_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/setup/properties_16x16.png"), 0)
        Me.ImagenesSMT16X16.Images.SetKeyName(0, "properties_16x16.png")
        Me.ImagenesSMT16X16.InsertGalleryImage("usergroup_16x16.png", "office2013/people/usergroup_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/people/usergroup_16x16.png"), 1)
        Me.ImagenesSMT16X16.Images.SetKeyName(1, "usergroup_16x16.png")
        Me.ImagenesSMT16X16.InsertGalleryImage("printstartdate_16x16.png", "devav/actions/printstartdate_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("devav/actions/printstartdate_16x16.png"), 2)
        Me.ImagenesSMT16X16.Images.SetKeyName(2, "printstartdate_16x16.png")
        Me.ImagenesSMT16X16.InsertGalleryImage("chartyaxissettings_16x16.png", "office2013/chart/chartyaxissettings_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/chart/chartyaxissettings_16x16.png"), 3)
        Me.ImagenesSMT16X16.Images.SetKeyName(3, "chartyaxissettings_16x16.png")
        Me.ImagenesSMT16X16.InsertGalleryImage("findcustomers_16x16.png", "office2013/find/findcustomers_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/find/findcustomers_16x16.png"), 4)
        Me.ImagenesSMT16X16.Images.SetKeyName(4, "findcustomers_16x16.png")
        Me.ImagenesSMT16X16.InsertGalleryImage("edit_16x16.png", "office2013/edit/edit_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/edit/edit_16x16.png"), 5)
        Me.ImagenesSMT16X16.Images.SetKeyName(5, "edit_16x16.png")
        Me.ImagenesSMT16X16.InsertGalleryImage("cancel_16x16.png", "office2013/actions/cancel_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/actions/cancel_16x16.png"), 6)
        Me.ImagenesSMT16X16.Images.SetKeyName(6, "cancel_16x16.png")
        Me.ImagenesSMT16X16.Images.SetKeyName(7, "Icon Sin fondo16.png")
        Me.ImagenesSMT16X16.InsertGalleryImage("card_16x16.png", "devav/view/card_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("devav/view/card_16x16.png"), 8)
        Me.ImagenesSMT16X16.Images.SetKeyName(8, "card_16x16.png")
        Me.ImagenesSMT16X16.InsertGalleryImage("showtestreport_16x16.png", "office2013/programming/showtestreport_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/programming/showtestreport_16x16.png"), 9)
        Me.ImagenesSMT16X16.Images.SetKeyName(9, "showtestreport_16x16.png")
        Me.ImagenesSMT16X16.InsertGalleryImage("team_16x16.png", "office2013/people/team_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/people/team_16x16.png"), 10)
        Me.ImagenesSMT16X16.Images.SetKeyName(10, "team_16x16.png")
        Me.ImagenesSMT16X16.InsertGalleryImage("ide_16x16.png", "office2013/programming/ide_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/programming/ide_16x16.png"), 11)
        Me.ImagenesSMT16X16.Images.SetKeyName(11, "ide_16x16.png")
        Me.ImagenesSMT16X16.InsertGalleryImage("doctor_16x16.png", "devav/people/doctor_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("devav/people/doctor_16x16.png"), 12)
        Me.ImagenesSMT16X16.Images.SetKeyName(12, "doctor_16x16.png")
        Me.ImagenesSMT16X16.InsertGalleryImage("save_16x16.png", "devav/actions/save_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("devav/actions/save_16x16.png"), 13)
        Me.ImagenesSMT16X16.Images.SetKeyName(13, "save_16x16.png")
        Me.ImagenesSMT16X16.InsertGalleryImage("clear_16x16.png", "office2013/actions/clear_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/actions/clear_16x16.png"), 14)
        Me.ImagenesSMT16X16.Images.SetKeyName(14, "clear_16x16.png")
        Me.ImagenesSMT16X16.InsertGalleryImage("importimage_16x16.png", "office2013/actions/importimage_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/actions/importimage_16x16.png"), 15)
        Me.ImagenesSMT16X16.Images.SetKeyName(15, "importimage_16x16.png")
        Me.ImagenesSMT16X16.InsertGalleryImage("show_16x16.png", "office2013/actions/show_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/actions/show_16x16.png"), 16)
        Me.ImagenesSMT16X16.Images.SetKeyName(16, "show_16x16.png")
        Me.ImagenesSMT16X16.InsertGalleryImage("delete_16x16.png", "devav/actions/delete_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("devav/actions/delete_16x16.png"), 17)
        Me.ImagenesSMT16X16.Images.SetKeyName(17, "delete_16x16.png")
        Me.ImagenesSMT16X16.InsertGalleryImage("close_16x16.png", "office2013/actions/close_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/actions/close_16x16.png"), 18)
        Me.ImagenesSMT16X16.Images.SetKeyName(18, "close_16x16.png")
        Me.ImagenesSMT16X16.InsertGalleryImage("add_16x16.png", "office2013/actions/add_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/actions/add_16x16.png"), 19)
        Me.ImagenesSMT16X16.Images.SetKeyName(19, "add_16x16.png")
        Me.ImagenesSMT16X16.InsertGalleryImage("resetchanges_16x16.png", "devav/actions/resetchanges_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("devav/actions/resetchanges_16x16.png"), 20)
        Me.ImagenesSMT16X16.Images.SetKeyName(20, "resetchanges_16x16.png")
        Me.ImagenesSMT16X16.InsertGalleryImage("image_16x16.png", "office2013/content/image_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/content/image_16x16.png"), 21)
        Me.ImagenesSMT16X16.Images.SetKeyName(21, "image_16x16.png")
        Me.ImagenesSMT16X16.InsertGalleryImage("print_16x16.png", "devav/actions/print_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("devav/actions/print_16x16.png"), 22)
        Me.ImagenesSMT16X16.Images.SetKeyName(22, "print_16x16.png")
        Me.ImagenesSMT16X16.InsertGalleryImage("apply_16x16.png", "office2013/actions/apply_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/actions/apply_16x16.png"), 23)
        Me.ImagenesSMT16X16.Images.SetKeyName(23, "apply_16x16.png")
        Me.ImagenesSMT16X16.InsertGalleryImage("article_16x16.png", "office2013/support/article_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/support/article_16x16.png"), 24)
        Me.ImagenesSMT16X16.Images.SetKeyName(24, "article_16x16.png")
        Me.ImagenesSMT16X16.InsertGalleryImage("printsortasc_16x16.png", "devav/actions/printsortasc_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("devav/actions/printsortasc_16x16.png"), 25)
        Me.ImagenesSMT16X16.Images.SetKeyName(25, "printsortasc_16x16.png")
        Me.ImagenesSMT16X16.InsertGalleryImage("printsortdesc_16x16.png", "devav/actions/printsortdesc_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("devav/actions/printsortdesc_16x16.png"), 26)
        Me.ImagenesSMT16X16.Images.SetKeyName(26, "printsortdesc_16x16.png")
        Me.ImagenesSMT16X16.InsertGalleryImage("customeremployees_16x16.png", "devav/people/customeremployees_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("devav/people/customeremployees_16x16.png"), 27)
        Me.ImagenesSMT16X16.Images.SetKeyName(27, "customeremployees_16x16.png")
        Me.ImagenesSMT16X16.InsertGalleryImage("phone2_16x16.png", "devav/contacts/phone2_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("devav/contacts/phone2_16x16.png"), 28)
        Me.ImagenesSMT16X16.Images.SetKeyName(28, "phone2_16x16.png")
        Me.ImagenesSMT16X16.InsertGalleryImage("specificationsummary_16x16.png", "devav/print/specificationsummary_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("devav/print/specificationsummary_16x16.png"), 29)
        Me.ImagenesSMT16X16.Images.SetKeyName(29, "specificationsummary_16x16.png")
        Me.ImagenesSMT16X16.InsertGalleryImage("salesinvoice_16x16.png", "devav/sales/salesinvoice_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("devav/sales/salesinvoice_16x16.png"), 30)
        Me.ImagenesSMT16X16.Images.SetKeyName(30, "salesinvoice_16x16.png")
        Me.ImagenesSMT16X16.InsertGalleryImage("pagesetup_16x16.png", "office2013/setup/pagesetup_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/setup/pagesetup_16x16.png"), 31)
        Me.ImagenesSMT16X16.Images.SetKeyName(31, "pagesetup_16x16.png")
        Me.ImagenesSMT16X16.InsertGalleryImage("profilereport_16x16.png", "devav/print/profilereport_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("devav/print/profilereport_16x16.png"), 32)
        Me.ImagenesSMT16X16.Images.SetKeyName(32, "profilereport_16x16.png")
        Me.ImagenesSMT16X16.InsertGalleryImage("newitem_16x16.png", "devav/actions/newitem_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("devav/actions/newitem_16x16.png"), 33)
        Me.ImagenesSMT16X16.Images.SetKeyName(33, "newitem_16x16.png")
        Me.ImagenesSMT16X16.InsertGalleryImage("wizard_16x16.png", "office2013/miscellaneous/wizard_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/miscellaneous/wizard_16x16.png"), 34)
        Me.ImagenesSMT16X16.Images.SetKeyName(34, "wizard_16x16.png")
        Me.ImagenesSMT16X16.InsertGalleryImage("search_16x16.png", "devav/actions/search_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("devav/actions/search_16x16.png"), 35)
        Me.ImagenesSMT16X16.Images.SetKeyName(35, "search_16x16.png")
        Me.ImagenesSMT16X16.InsertGalleryImage("saveas_16x16.png", "devav/actions/saveas_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("devav/actions/saveas_16x16.png"), 36)
        Me.ImagenesSMT16X16.Images.SetKeyName(36, "saveas_16x16.png")
        Me.ImagenesSMT16X16.InsertGalleryImage("issue_16x16.png", "office2013/support/issue_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/support/issue_16x16.png"), 37)
        Me.ImagenesSMT16X16.Images.SetKeyName(37, "issue_16x16.png")
        Me.ImagenesSMT16X16.InsertGalleryImage("exporttocsv_16x16.png", "office2013/export/exporttocsv_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/export/exporttocsv_16x16.png"), 38)
        Me.ImagenesSMT16X16.Images.SetKeyName(38, "exporttocsv_16x16.png")
        Me.ImagenesSMT16X16.InsertGalleryImage("apply_16x16.png", "images/actions/apply_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/apply_16x16.png"), 39)
        Me.ImagenesSMT16X16.Images.SetKeyName(39, "apply_16x16.png")
        Me.ImagenesSMT16X16.InsertGalleryImage("cancel_16x16.png", "images/actions/cancel_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/cancel_16x16.png"), 40)
        Me.ImagenesSMT16X16.Images.SetKeyName(40, "cancel_16x16.png")
        Me.ImagenesSMT16X16.InsertGalleryImage("newtask_16x16.png", "office2013/tasks/newtask_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/tasks/newtask_16x16.png"), 41)
        Me.ImagenesSMT16X16.Images.SetKeyName(41, "newtask_16x16.png")
        Me.ImagenesSMT16X16.InsertGalleryImage("additem_16x16.png", "office2013/actions/additem_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/actions/additem_16x16.png"), 42)
        Me.ImagenesSMT16X16.Images.SetKeyName(42, "additem_16x16.png")
        Me.ImagenesSMT16X16.InsertGalleryImage("deletelist_16x16.png", "office2013/actions/deletelist_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/actions/deletelist_16x16.png"), 43)
        Me.ImagenesSMT16X16.Images.SetKeyName(43, "deletelist_16x16.png")
        Me.ImagenesSMT16X16.InsertGalleryImage("moveup_16x16.png", "images/arrows/moveup_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/arrows/moveup_16x16.png"), 44)
        Me.ImagenesSMT16X16.Images.SetKeyName(44, "moveup_16x16.png")
        Me.ImagenesSMT16X16.InsertGalleryImage("movedown_16x16.png", "images/arrows/movedown_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/arrows/movedown_16x16.png"), 45)
        Me.ImagenesSMT16X16.Images.SetKeyName(45, "movedown_16x16.png")
        Me.ImagenesSMT16X16.InsertGalleryImage("summary_16x16.png", "grayscaleimages/data/summary_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("grayscaleimages/data/summary_16x16.png"), 46)
        Me.ImagenesSMT16X16.Images.SetKeyName(46, "summary_16x16.png")
        Me.ImagenesSMT16X16.InsertGalleryImage("productcomparisons_16x16.png", "devav/actions/productcomparisons_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("devav/actions/productcomparisons_16x16.png"), 47)
        Me.ImagenesSMT16X16.Images.SetKeyName(47, "productcomparisons_16x16.png")
        Me.ImagenesSMT16X16.InsertGalleryImage("pivot_16x16.png", "office2013/grid/pivot_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/grid/pivot_16x16.png"), 48)
        Me.ImagenesSMT16X16.Images.SetKeyName(48, "pivot_16x16.png")
        Me.ImagenesSMT16X16.InsertGalleryImage("errorbarsnone_16x16.png", "images/analysis/errorbarsnone_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/analysis/errorbarsnone_16x16.png"), 49)
        Me.ImagenesSMT16X16.Images.SetKeyName(49, "errorbarsnone_16x16.png")
        Me.ImagenesSMT16X16.InsertGalleryImage("Excell_1.png", "images/export/exporttoxlsx_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/export/exporttoxlsx_16x16.png"), 50)
        Me.ImagenesSMT16X16.Images.SetKeyName(50, "Excell_1.png")
        Me.ImagenesSMT16X16.InsertGalleryImage("Excell_2.png", "images/export/exporttoxls_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/export/exporttoxls_16x16.png"), 51)
        Me.ImagenesSMT16X16.Images.SetKeyName(51, "Excell_2.png")
        Me.ImagenesSMT16X16.InsertGalleryImage("list_16x16.png", "devav/layout/list_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("devav/layout/list_16x16.png"), 52)
        Me.ImagenesSMT16X16.Images.SetKeyName(52, "list_16x16.png")
        Me.ImagenesSMT16X16.InsertGalleryImage("add_16x16.png", "images/actions/add_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/add_16x16.png"), 53)
        Me.ImagenesSMT16X16.Images.SetKeyName(53, "add_16x16.png")
        Me.ImagenesSMT16X16.InsertGalleryImage("currency_16x16.png", "office2013/miscellaneous/currency_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/miscellaneous/currency_16x16.png"), 54)
        Me.ImagenesSMT16X16.Images.SetKeyName(54, "currency_16x16.png")
        Me.ImagenesSMT16X16.InsertGalleryImage("costanalysis_16x16.png", "devav/actions/costanalysis_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("devav/actions/costanalysis_16x16.png"), 55)
        Me.ImagenesSMT16X16.Images.SetKeyName(55, "costanalysis_16x16.png")
        Me.ImagenesSMT16X16.InsertGalleryImage("deletefooter_16x16.png", "office2013/reports/deletefooter_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/reports/deletefooter_16x16.png"), 56)
        Me.ImagenesSMT16X16.Images.SetKeyName(56, "deletefooter_16x16.png")
        Me.ImagenesSMT16X16.InsertGalleryImage("editcontact_16x16.png", "office2013/mail/editcontact_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/mail/editcontact_16x16.png"), 57)
        Me.ImagenesSMT16X16.Images.SetKeyName(57, "editcontact_16x16.png")
        Me.ImagenesSMT16X16.InsertGalleryImage("botask_16x16.png", "images/business%20objects/botask_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/business%20objects/botask_16x16.png"), 58)
        Me.ImagenesSMT16X16.Images.SetKeyName(58, "botask_16x16.png")
        Me.ImagenesSMT16X16.InsertGalleryImage("boresume_16x16.png", "images/business%20objects/boresume_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/business%20objects/boresume_16x16.png"), 59)
        Me.ImagenesSMT16X16.Images.SetKeyName(59, "boresume_16x16.png")
        Me.ImagenesSMT16X16.InsertGalleryImage("showproduct_16x16.png", "devav/actions/showproduct_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("devav/actions/showproduct_16x16.png"), 60)
        Me.ImagenesSMT16X16.Images.SetKeyName(60, "showproduct_16x16.png")
        Me.ImagenesSMT16X16.Images.SetKeyName(61, "exporttoxls_16x16.png")
        Me.ImagenesSMT16X16.Images.SetKeyName(62, "sendxlsx_16x16.png")
        Me.ImagenesSMT16X16.Images.SetKeyName(63, "assigntome_16x16.png")
        Me.ImagenesSMT16X16.Images.SetKeyName(64, "sortgroupheader_16x16.png")
        Me.ImagenesSMT16X16.Images.SetKeyName(65, "functionslookupandreference_16x16.png")
        Me.ImagenesSMT16X16.Images.SetKeyName(66, "formatnumbershortdate_16x16.png")
        Me.ImagenesSMT16X16.Images.SetKeyName(67, "calendar_16x16.png")
        Me.ImagenesSMT16X16.Images.SetKeyName(68, "groupbydate_16x16.png")
        Me.ImagenesSMT16X16.Images.SetKeyName(69, "printduedate_16x16.png")
        Me.ImagenesSMT16X16.Images.SetKeyName(70, "publish_16x16.png")
        Me.ImagenesSMT16X16.Images.SetKeyName(71, "search_16x16.png")
        Me.ImagenesSMT16X16.Images.SetKeyName(72, "allowuserstoeditranges_16x16.png")
        Me.ImagenesSMT16X16.Images.SetKeyName(73, "customizegrid_16x16.png")
        Me.ImagenesSMT16X16.Images.SetKeyName(74, "pivot_16x16.png")
        Me.ImagenesSMT16X16.InsertGalleryImage("sortbyinvoice_16x16.png", "devav/actions/sortbyinvoice_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("devav/actions/sortbyinvoice_16x16.png"), 75)
        Me.ImagenesSMT16X16.Images.SetKeyName(75, "sortbyinvoice_16x16.png")
        Me.ImagenesSMT16X16.InsertGalleryImage("financial_16x16.png", "images/function%20library/financial_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/function%20library/financial_16x16.png"), 76)
        Me.ImagenesSMT16X16.Images.SetKeyName(76, "financial_16x16.png")
        Me.ImagenesSMT16X16.InsertGalleryImage("usergroup_16x16.png", "images/people/usergroup_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/people/usergroup_16x16.png"), 77)
        Me.ImagenesSMT16X16.Images.SetKeyName(77, "usergroup_16x16.png")
        Me.ImagenesSMT16X16.InsertGalleryImage("boresume_16x16.png", "images/business%20objects/boresume_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/business%20objects/boresume_16x16.png"), 78)
        Me.ImagenesSMT16X16.Images.SetKeyName(78, "boresume_16x16.png")
        Me.ImagenesSMT16X16.InsertGalleryImage("documentmap_16x16.png", "office2013/navigation/documentmap_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/navigation/documentmap_16x16.png"), 79)
        Me.ImagenesSMT16X16.Images.SetKeyName(79, "documentmap_16x16.png")
        Me.ImagenesSMT16X16.InsertGalleryImage("addcalculatedfield_16x16.png", "images/math/addcalculatedfield_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/math/addcalculatedfield_16x16.png"), 80)
        Me.ImagenesSMT16X16.Images.SetKeyName(80, "addcalculatedfield_16x16.png")
        Me.ImagenesSMT16X16.InsertGalleryImage("publicfix_16x16.png", "office2013/people/publicfix_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/people/publicfix_16x16.png"), 81)
        Me.ImagenesSMT16X16.Images.SetKeyName(81, "publicfix_16x16.png")
        '
        'ImagenesSMT32X32
        '
        Me.ImagenesSMT32X32.ImageSize = New System.Drawing.Size(32, 32)
        Me.ImagenesSMT32X32.ImageStream = CType(resources.GetObject("ImagenesSMT32X32.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.ImagenesSMT32X32.InsertGalleryImage("printsortasc_32x32.png", "devav/actions/printsortasc_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("devav/actions/printsortasc_32x32.png"), 0)
        Me.ImagenesSMT32X32.Images.SetKeyName(0, "printsortasc_32x32.png")
        Me.ImagenesSMT32X32.InsertGalleryImage("printsortdesc_32x32.png", "devav/actions/printsortdesc_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("devav/actions/printsortdesc_32x32.png"), 1)
        Me.ImagenesSMT32X32.Images.SetKeyName(1, "printsortdesc_32x32.png")
        Me.ImagenesSMT32X32.InsertGalleryImage("add_32x32.png", "office2013/actions/add_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/actions/add_32x32.png"), 2)
        Me.ImagenesSMT32X32.Images.SetKeyName(2, "add_32x32.png")
        Me.ImagenesSMT32X32.InsertGalleryImage("saveall_32x32.png", "office2013/save/saveall_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/save/saveall_32x32.png"), 3)
        Me.ImagenesSMT32X32.Images.SetKeyName(3, "saveall_32x32.png")
        Me.ImagenesSMT32X32.InsertGalleryImage("findcustomers_32x32.png", "office2013/find/findcustomers_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/find/findcustomers_32x32.png"), 4)
        Me.ImagenesSMT32X32.Images.SetKeyName(4, "findcustomers_32x32.png")
        Me.ImagenesSMT32X32.InsertGalleryImage("employees_32x32.png", "devav/view/employees_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("devav/view/employees_32x32.png"), 5)
        Me.ImagenesSMT32X32.Images.SetKeyName(5, "employees_32x32.png")
        Me.ImagenesSMT32X32.InsertGalleryImage("printincludeevaluations_32x32.png", "devav/actions/printincludeevaluations_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("devav/actions/printincludeevaluations_32x32.png"), 6)
        Me.ImagenesSMT32X32.Images.SetKeyName(6, "printincludeevaluations_32x32.png")
        Me.ImagenesSMT32X32.InsertGalleryImage("addgroupfooter_32x32.png", "office2013/reports/addgroupfooter_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/reports/addgroupfooter_32x32.png"), 7)
        Me.ImagenesSMT32X32.Images.SetKeyName(7, "addgroupfooter_32x32.png")
        Me.ImagenesSMT32X32.InsertGalleryImage("publicfix_32x32.png", "office2013/people/publicfix_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/people/publicfix_32x32.png"), 8)
        Me.ImagenesSMT32X32.Images.SetKeyName(8, "publicfix_32x32.png")
        Me.ImagenesSMT32X32.InsertGalleryImage("pagesetup_32x32.png", "office2013/setup/pagesetup_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/setup/pagesetup_32x32.png"), 9)
        Me.ImagenesSMT32X32.Images.SetKeyName(9, "pagesetup_32x32.png")
        Me.ImagenesSMT32X32.InsertGalleryImage("newitem_32x32.png", "devav/actions/newitem_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("devav/actions/newitem_32x32.png"), 10)
        Me.ImagenesSMT32X32.Images.SetKeyName(10, "newitem_32x32.png")
        Me.ImagenesSMT32X32.InsertGalleryImage("today_32x32.png", "office2013/scheduling/today_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/scheduling/today_32x32.png"), 11)
        Me.ImagenesSMT32X32.Images.SetKeyName(11, "today_32x32.png")
        Me.ImagenesSMT32X32.InsertGalleryImage("close_32x32.png", "devav/actions/close_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("devav/actions/close_32x32.png"), 12)
        Me.ImagenesSMT32X32.Images.SetKeyName(12, "close_32x32.png")
        Me.ImagenesSMT32X32.InsertGalleryImage("contactdirectory_32x32.png", "devav/print/contactdirectory_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("devav/print/contactdirectory_32x32.png"), 13)
        Me.ImagenesSMT32X32.Images.SetKeyName(13, "contactdirectory_32x32.png")
        Me.ImagenesSMT32X32.InsertGalleryImage("version_32x32.png", "office2013/support/version_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/support/version_32x32.png"), 14)
        Me.ImagenesSMT32X32.Images.SetKeyName(14, "version_32x32.png")
        Me.ImagenesSMT32X32.InsertGalleryImage("team_32x32.png", "office2013/people/team_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/people/team_32x32.png"), 15)
        Me.ImagenesSMT32X32.Images.SetKeyName(15, "team_32x32.png")
        Me.ImagenesSMT32X32.InsertGalleryImage("properties_32x32.png", "office2013/setup/properties_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/setup/properties_32x32.png"), 16)
        Me.ImagenesSMT32X32.Images.SetKeyName(16, "properties_32x32.png")
        Me.ImagenesSMT32X32.InsertGalleryImage("edittask_32x32.png", "office2013/tasks/edittask_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/tasks/edittask_32x32.png"), 17)
        Me.ImagenesSMT32X32.Images.SetKeyName(17, "edittask_32x32.png")
        Me.ImagenesSMT32X32.InsertGalleryImage("card_32x32.png", "devav/view/card_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("devav/view/card_32x32.png"), 18)
        Me.ImagenesSMT32X32.Images.SetKeyName(18, "card_32x32.png")
        '
        'TabManagerPrincipal
        '
        Me.TabManagerPrincipal.AppearancePage.Header.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.TabManagerPrincipal.AppearancePage.Header.Options.UseFont = True
        Me.TabManagerPrincipal.AppearancePage.HeaderActive.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.TabManagerPrincipal.AppearancePage.HeaderActive.Options.UseFont = True
        Me.TabManagerPrincipal.AppearancePage.HeaderDisabled.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.TabManagerPrincipal.AppearancePage.HeaderDisabled.Options.UseFont = True
        Me.TabManagerPrincipal.AppearancePage.HeaderHotTracked.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.TabManagerPrincipal.AppearancePage.HeaderHotTracked.Options.UseFont = True
        Me.TabManagerPrincipal.AppearancePage.PageClient.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.TabManagerPrincipal.AppearancePage.PageClient.Options.UseFont = True
        Me.TabManagerPrincipal.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InActiveTabPageHeader
        Me.TabManagerPrincipal.Controller = Me.ControladorDeBarra
        Me.TabManagerPrincipal.MdiParent = Me
        Me.TabManagerPrincipal.ShowHeaderFocus = DevExpress.Utils.DefaultBoolean.[True]
        Me.TabManagerPrincipal.ShowToolTips = DevExpress.Utils.DefaultBoolean.[True]
        Me.TabManagerPrincipal.TabPageWidth = 250
        Me.TabManagerPrincipal.UseFormIconAsPageImage = DevExpress.Utils.DefaultBoolean.[True]
        '
        'Timer1
        '
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch
        Me.BackgroundImageStore = CType(resources.GetObject("$this.BackgroundImageStore"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1021, 721)
        Me.Controls.Add(Me.RibbonStatusBar1)
        Me.Controls.Add(Me.rcPrincipal)
        Me.IconOptions.Icon = CType(resources.GetObject("FrmPrincipal.IconOptions.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.KeyPreview = True
        Me.Name = "FrmPrincipal"
        Me.Ribbon = Me.rcPrincipal
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.StatusBar = Me.RibbonStatusBar1
        Me.Text = "Nómina | SAMIT Sql"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.rcPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ControladorDeBarra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImagenesSMT16X16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImagenesSMT32X32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabManagerPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rcPrincipal As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents PaginaInicio As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents btnConexion As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCambiaFecha As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCambiaClave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpgConexion As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents ControladorDeBarra As DevExpress.XtraBars.BarAndDockingController
    Friend WithEvents ImagenesSMT32X32 As DevExpress.Utils.ImageCollection
    Friend WithEvents TabManagerPrincipal As DevExpress.XtraTabbedMdi.XtraTabbedMdiManager
    Friend WithEvents msjEmpresa As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents NumEmpresa As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents msjOficina As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents NumOficina As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents FechaTrabajo As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents MensajeDeAyuda As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents btnNuevoEmpleado As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnConexionMenu As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCambiaFechaMenu As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCambiaClaveMenu As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnNuevoEmpMenu As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpgContratos As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents SkinRibbonGalleryBarItem1 As DevExpress.XtraBars.SkinRibbonGalleryBarItem
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rpgNomina As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem8 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem9 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnValGenerales As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnValPersonales As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnTipoConceptos As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnConceptos As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPlantillas As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPeriodos As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnBases As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSalir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpgSalir As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnTiposContratos As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCentroCostos As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDependencias As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bsiPeriodosLiquidacion As DevExpress.XtraBars.BarSubItem
    Friend WithEvents btnGenPeriodos As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnNuevaNomina As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEntidades As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btaggbases As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnProfesiones As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents menuTablasCatalogo As DevExpress.XtraBars.BarSubItem
    Friend WithEvents btnNivelEducativo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnClaseLicencia As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEstadoCivil As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnTiposId As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnParentezco As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPaises As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDepartamentos As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnMunicipios As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnConceptosPersonales As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnClasConceptosNomina As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnClasConceptosPersonales As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents btnDescuentosNomina As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAggValExentos As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnValMaxDescuento As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnModAsignaciones As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents menuEmpleado As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btcConfigConceptos As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnConfigNominas As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btcConfigTipoContratos As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnConfigPrestacionesS As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnLiquidarProvisiones As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnLiquidacionExtraor As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnLiquidarContrato As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnContratos As DevExpress.XtraBars.BarSubItem
    Friend WithEvents btnAggContratos As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAsigValoresExentos As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAsigDescuentos As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAsigNominas As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnModAsignaSalariales As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSubOtrosContratos As DevExpress.XtraBars.BarSubItem
    Friend WithEvents bntTiposContratos As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bntDependencia As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCentrosCostos As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCargos As DevExpress.XtraBars.BarSubItem
    Friend WithEvents btnAggCargo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnFunciones As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnNominas As DevExpress.XtraBars.BarSubItem
    Friend WithEvents btnSubNomina As DevExpress.XtraBars.BarSubItem
    Friend WithEvents btnAggNominas As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnConfigNomina As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSubConceptos As DevExpress.XtraBars.BarSubItem
    Friend WithEvents btnSubValoresCalculo As DevExpress.XtraBars.BarSubItem
    Friend WithEvents btnValoresPersonales As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnValoresGenerales As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAggBases As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSubConceptosNom As DevExpress.XtraBars.BarSubItem
    Friend WithEvents btnConceptosNomina As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnClasiConcepNom As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSubConceptosPersonales As DevExpress.XtraBars.BarSubItem
    Friend WithEvents btnConceptosPersona As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnClasiConcepPersonales As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSubPerfilConceptos As DevExpress.XtraBars.BarSubItem
    Friend WithEvents btnPerfilConceptos As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAsigValorMaximo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSubLiquidaciones As DevExpress.XtraBars.BarSubItem
    Friend WithEvents btnSubLiquidacionPeriodos As DevExpress.XtraBars.BarSubItem
    Friend WithEvents btnNovedades As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnLiquidarPeriodo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnConfigurarLiquidaPeriodos As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSubLiquidacionPrestaciones As DevExpress.XtraBars.BarSubItem
    Friend WithEvents bntLiquidarPrestaciones As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnConfigLiquidaPrestaciones As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnLiquidacionExtraordinaria As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSubLiquidaContratos As DevExpress.XtraBars.BarSubItem
    Friend WithEvents btnLiquidarContratos As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnConfigLiquidacion As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem10 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnConceptosNom As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem11 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnConsultarLiquidacion As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnBancos As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents b As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem12 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents CofigConcepNomina As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem13 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpgConfig As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnConfiguracion As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarSubItem2 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarButtonItem14 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem15 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarSubItem3 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarButtonItem16 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem20 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem17 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem18 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem19 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem21 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem22 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem23 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem24 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem25 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem26 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem27 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem28 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem31 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem32 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem29 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarSubItem4 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarButtonItem34 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem35 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem30 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem33 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem36 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiLiquidaciones As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bsiConceptos As DevExpress.XtraBars.BarSubItem
    Friend WithEvents bsiLiquidaciones As DevExpress.XtraBars.BarSubItem
    Friend WithEvents rpgConceptos As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rpgLiquidaciones As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem44 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarSubItem5 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarButtonItem38 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem39 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarSubItem7 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarButtonItem40 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem41 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarSubItem6 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarButtonItem42 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem43 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem37 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarSubItem8 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarButtonItem45 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem46 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem47 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpgEmpleados As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Public WithEvents ImagenesSMT16X16 As DevExpress.Utils.ImageCollection
    Friend WithEvents BarButtonItem48 As DevExpress.XtraBars.BarButtonItem
    'Friend WithEvents btnGuardaDatosBasicos As DevExpress.XtraBars.BarButtonItem
    'Friend WithEvents btnCargaFotoDatosBasicos As DevExpress.XtraBars.BarButtonItem
    'Friend WithEvents btnBuscarEmp As DevExpress.XtraBars.BarButtonItem
    'Friend WithEvents btnLimpiaDatosBasicos As DevExpress.XtraBars.BarButtonItem
    'Friend WithEvents btnAggExpLab As DevExpress.XtraBars.BarButtonItem
    'Friend WithEvents btnCargaCertExpLab As DevExpress.XtraBars.BarButtonItem
    'Friend WithEvents btnAmpliaCertExpLab As DevExpress.XtraBars.BarButtonItem
    'Friend WithEvents btnEliminaExpEmp As DevExpress.XtraBars.BarButtonItem
    'Friend WithEvents btnEditarExpEmp As DevExpress.XtraBars.BarButtonItem
    'Friend WithEvents btnLimpiarExpLab As DevExpress.XtraBars.BarButtonItem

#End Region

End Class
