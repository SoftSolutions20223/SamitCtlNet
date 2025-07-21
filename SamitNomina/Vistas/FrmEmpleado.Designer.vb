<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEmpleado
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ColumnDefinition1 As DevExpress.XtraLayout.ColumnDefinition = New DevExpress.XtraLayout.ColumnDefinition()
        Dim ColumnDefinition2 As DevExpress.XtraLayout.ColumnDefinition = New DevExpress.XtraLayout.ColumnDefinition()
        Dim ColumnDefinition3 As DevExpress.XtraLayout.ColumnDefinition = New DevExpress.XtraLayout.ColumnDefinition()
        Dim RowDefinition1 As DevExpress.XtraLayout.RowDefinition = New DevExpress.XtraLayout.RowDefinition()
        Dim RowDefinition2 As DevExpress.XtraLayout.RowDefinition = New DevExpress.XtraLayout.RowDefinition()
        Dim RowDefinition3 As DevExpress.XtraLayout.RowDefinition = New DevExpress.XtraLayout.RowDefinition()
        Dim RowDefinition4 As DevExpress.XtraLayout.RowDefinition = New DevExpress.XtraLayout.RowDefinition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEmpleado))
        Me.tcEmpleados = New DevExpress.XtraTab.XtraTabControl()
        Me.tpDatosBasicos = New DevExpress.XtraTab.XtraTabPage()
        Me.lcPrincipalDatosBasicos = New DevExpress.XtraLayout.LayoutControl()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtClaseLicencia = New SamitCtlNet.SamitBusq()
        Me.lblClaseLibreta = New DevExpress.XtraEditors.LabelControl()
        Me.lkeClaseLibreta = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtNumLicencia = New SamitCtlNet.SamitTexto()
        Me.lblComentarios = New DevExpress.XtraEditors.LabelControl()
        Me.txtComentario = New DevExpress.XtraEditors.MemoEdit()
        Me.BarManagerMenu = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.btnQuitarImageGaleria = New DevExpress.XtraBars.BarButtonItem()
        Me.lcExpDocNacEmpleado = New DevExpress.XtraLayout.LayoutControl()
        Me.gbxLugarNacimiento = New DevExpress.XtraEditors.GroupControl()
        Me.lkePaisNacimiento = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblMuniNac = New DevExpress.XtraEditors.LabelControl()
        Me.lkeMuniNacimiento = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblPaisNac = New DevExpress.XtraEditors.LabelControl()
        Me.lblDepNac = New DevExpress.XtraEditors.LabelControl()
        Me.lkeDepNacimiento = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblFechaNac = New DevExpress.XtraEditors.LabelControl()
        Me.dteFechaNacimiento = New DevExpress.XtraEditors.DateEdit()
        Me.gbxExpDocumento = New DevExpress.XtraEditors.GroupControl()
        Me.lblFechaExpDoc = New DevExpress.XtraEditors.LabelControl()
        Me.dteFechaExpDocumento = New DevExpress.XtraEditors.DateEdit()
        Me.lkePaisExpDocumento = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblMuniExpDoc = New DevExpress.XtraEditors.LabelControl()
        Me.lkeMuniExpDocumento = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblPaisExpDoc = New DevExpress.XtraEditors.LabelControl()
        Me.lblDepExpDoc = New DevExpress.XtraEditors.LabelControl()
        Me.lkeDepExpDocumento = New DevExpress.XtraEditors.LookUpEdit()
        Me.lcgExpDocNacEmpleado = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.lciExpDocEmp = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciLugarNacEmp = New DevExpress.XtraLayout.LayoutControlItem()
        Me.gbxLugarResidencia = New DevExpress.XtraEditors.GroupControl()
        Me.lkePaisResidencia = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblMuniResidencia = New DevExpress.XtraEditors.LabelControl()
        Me.lkeMuniResidencia = New DevExpress.XtraEditors.LookUpEdit()
        Me.lkeDepResidencia = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblPaisResidencia = New DevExpress.XtraEditors.LabelControl()
        Me.lblDepResidencia = New DevExpress.XtraEditors.LabelControl()
        Me.txtDireccion = New SamitCtlNet.SamitTexto()
        Me.txtBarrio = New SamitCtlNet.SamitTexto()
        Me.txtDistritoMil = New SamitCtlNet.SamitTexto()
        Me.gbxImgFotoEmpleado = New DevExpress.XtraEditors.GroupControl()
        Me.pcbFotografiaEmpleado = New DevExpress.XtraEditors.PictureEdit()
        Me.txtNumLibreta = New SamitCtlNet.SamitTexto()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblDocEmpleado = New DevExpress.XtraEditors.LabelControl()
        Me.txtDigitoV = New DevExpress.XtraEditors.TextEdit()
        Me.txtDocEmpleado = New DevExpress.XtraEditors.TextEdit()
        Me.lblDigitoVer = New DevExpress.XtraEditors.LabelControl()
        Me.btnBuscarEmp = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lcDatos = New DevExpress.XtraLayout.LayoutControl()
        Me.txtPrimerNombre = New SamitCtlNet.SamitTexto()
        Me.txtSegNombre = New SamitCtlNet.SamitTexto()
        Me.txtPrimerApell = New SamitCtlNet.SamitTexto()
        Me.txtSegApell = New SamitCtlNet.SamitTexto()
        Me.txtTel1 = New SamitCtlNet.SamitTexto()
        Me.txtTel2 = New SamitCtlNet.SamitTexto()
        Me.txtCelular = New SamitCtlNet.SamitTexto()
        Me.ndPersonaAcargo = New DevExpress.XtraEditors.SpinEdit()
        Me.lblPersonasAcargo = New DevExpress.XtraEditors.LabelControl()
        Me.lcgDatos = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.lciTxtPnombre = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciTxtSnombre = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciTxtPapellido = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciSapellido = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciTxtTel1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciTxtTel2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciTxtCel = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciNdPerAcargo = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciLblPersonasAcargo = New DevExpress.XtraLayout.LayoutControlItem()
        Me.grTipoCuenta = New DevExpress.XtraEditors.RadioGroup()
        Me.txtTipoDoc = New SamitCtlNet.SamitBusq()
        Me.txtEstadoCivil = New SamitCtlNet.SamitBusq()
        Me.txtWebPage = New SamitCtlNet.SamitTexto()
        Me.txtProfesion = New SamitCtlNet.SamitBusq()
        Me.txtEmail1 = New SamitCtlNet.SamitTexto()
        Me.txtEmail2 = New SamitCtlNet.SamitTexto()
        Me.txtGenero = New SamitCtlNet.SamitBusq()
        Me.txtBanco = New SamitCtlNet.SamitBusq()
        Me.txtNumCuenta = New SamitCtlNet.SamitTexto()
        Me.lcgPrincipalDatosBasicos = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.lciNumDocDVbtnBuscar = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciDatosBasicosIzq = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciDatsoBasicosDer = New DevExpress.XtraLayout.LayoutControlItem()
        Me.tpAfiliaciones = New DevExpress.XtraTab.XtraTabPage()
        Me.gbxImagenesAfiliacion = New DevExpress.XtraEditors.GroupControl()
        Me.GalleryControlAfiliaciones = New DevExpress.XtraBars.Ribbon.GalleryControl()
        Me.GalleryControlClient3 = New DevExpress.XtraBars.Ribbon.GalleryControlClient()
        Me.gbxInfAfiliaciones = New DevExpress.XtraEditors.GroupControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.txtCausaRetiroEntidad = New DevExpress.XtraEditors.MemoEdit()
        Me.txtEntidad = New SamitCtlNet.SamitBusq()
        Me.txtTipoEntidad = New SamitCtlNet.SamitBusq()
        Me.lblFechaRegistroEmpEntidad = New DevExpress.XtraEditors.LabelControl()
        Me.dteFechaRegistroEmpEntidad = New DevExpress.XtraEditors.DateEdit()
        Me.lblEmpRetiradoEntidad = New DevExpress.XtraEditors.LabelControl()
        Me.rgbEmpRetiradoEntidad = New DevExpress.XtraEditors.RadioGroup()
        Me.gbxGrillaAfiliaciones = New DevExpress.XtraEditors.GroupControl()
        Me.gcAfiliaciones = New DevExpress.XtraGrid.GridControl()
        Me.gvAfilicaciones = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.tpFamiliares = New DevExpress.XtraTab.XtraTabPage()
        Me.gbxImgFamiliar = New DevExpress.XtraEditors.GroupControl()
        Me.pcbImgFamiliar = New DevExpress.XtraEditors.PictureEdit()
        Me.gbxGrillaFamiliares = New DevExpress.XtraEditors.GroupControl()
        Me.gcFamiliares = New DevExpress.XtraGrid.GridControl()
        Me.gvFamiliares = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gbxInfFamiliar = New DevExpress.XtraEditors.GroupControl()
        Me.lkeParentescoFamiliar = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtDirEmpTrabajaFamiliar = New SamitCtlNet.SamitTexto()
        Me.txtTelsEmpTrabajaFamiliar = New SamitCtlNet.SamitTexto()
        Me.txtCelFamiliar = New SamitCtlNet.SamitTexto()
        Me.txtCargoFamiliar = New SamitCtlNet.SamitTexto()
        Me.txtEmpresaTrabajaFamiliar = New SamitCtlNet.SamitTexto()
        Me.txtOcupacionFamiliar = New SamitCtlNet.SamitTexto()
        Me.lkeTipoDocFamiliar = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblParentescoFamiliar = New DevExpress.XtraEditors.LabelControl()
        Me.lblFecNacFamiliar = New DevExpress.XtraEditors.LabelControl()
        Me.dteFecNacFamiliar = New DevExpress.XtraEditors.DateEdit()
        Me.lblTipoDocFamiliar = New DevExpress.XtraEditors.LabelControl()
        Me.gbxUbicacionEmpTrabajaEmpleado = New DevExpress.XtraEditors.GroupControl()
        Me.lkePaisEmpTrabajaFamiliar = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblMuniEmpTrabajaFamiliar = New DevExpress.XtraEditors.LabelControl()
        Me.lkeMuniEmpTrabajaFamiliar = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblPaisEmpTrabajaFamiliar = New DevExpress.XtraEditors.LabelControl()
        Me.lblDepEmpTrabajaFamiliar = New DevExpress.XtraEditors.LabelControl()
        Me.lkeDepEmpTrabajaFamiliar = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtDocFamiliar = New SamitCtlNet.SamitTexto()
        Me.txtNombreFamiliar = New SamitCtlNet.SamitTexto()
        Me.tpExpLaboral = New DevExpress.XtraTab.XtraTabPage()
        Me.gbxCertExpLab = New DevExpress.XtraEditors.GroupControl()
        Me.GalleryControlExpLaboral = New DevExpress.XtraBars.Ribbon.GalleryControl()
        Me.GalleryControlClient1 = New DevExpress.XtraBars.Ribbon.GalleryControlClient()
        Me.gbxGrillaExpLab = New DevExpress.XtraEditors.GroupControl()
        Me.gcExpLaboral = New DevExpress.XtraGrid.GridControl()
        Me.gvExpLaboral = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gbxInfBasicaExpLab = New DevExpress.XtraEditors.GroupControl()
        Me.SeparatorControl1 = New DevExpress.XtraEditors.SeparatorControl()
        Me.lblFechaRetiroExpLab = New DevExpress.XtraEditors.LabelControl()
        Me.dteFecRetiroExpLab = New DevExpress.XtraEditors.DateEdit()
        Me.lblFechaIngresoExpLab = New DevExpress.XtraEditors.LabelControl()
        Me.dteFecIngresoExpLab = New DevExpress.XtraEditors.DateEdit()
        Me.txtEmpresaExpLab = New SamitCtlNet.SamitTexto()
        Me.txtTelEmpExpLab = New SamitCtlNet.SamitTexto()
        Me.txtCargoExpLab = New SamitCtlNet.SamitTexto()
        Me.txtJefeExplab = New SamitCtlNet.SamitTexto()
        Me.txtDirEmpExpLab = New SamitCtlNet.SamitTexto()
        Me.tpInfAcademica = New DevExpress.XtraTab.XtraTabPage()
        Me.gbxCertEstudios = New DevExpress.XtraEditors.GroupControl()
        Me.GalleryControlEstudios = New DevExpress.XtraBars.Ribbon.GalleryControl()
        Me.GalleryControlClient2 = New DevExpress.XtraBars.Ribbon.GalleryControlClient()
        Me.gbxGrillaInfAcademica = New DevExpress.XtraEditors.GroupControl()
        Me.gcEstudios = New DevExpress.XtraGrid.GridControl()
        Me.gvEstudios = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gbxInfBasicaEstudios = New DevExpress.XtraEditors.GroupControl()
        Me.cbxTipoTiempo = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.ndDuracion = New DevExpress.XtraEditors.SpinEdit()
        Me.lblDuracion = New DevExpress.XtraEditors.LabelControl()
        Me.lblTipoEducacion = New DevExpress.XtraEditors.LabelControl()
        Me.lkeNivelEducativo = New DevExpress.XtraEditors.LookUpEdit()
        Me.grbTipoEducacion = New DevExpress.XtraEditors.RadioGroup()
        Me.btnAddTitulo = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAddNivelEducativo = New DevExpress.XtraEditors.SimpleButton()
        Me.lblTituloObtenido = New DevExpress.XtraEditors.LabelControl()
        Me.lkeTituloObtenido = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblNivelEducativo = New DevExpress.XtraEditors.LabelControl()
        Me.gbxLugarObtTitulo = New DevExpress.XtraEditors.GroupControl()
        Me.lkePaisObtTitulo = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblMuniObtTitulo = New DevExpress.XtraEditors.LabelControl()
        Me.lkeMuniObtTitulo = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblPaisObtTitulo = New DevExpress.XtraEditors.LabelControl()
        Me.lblDepObtTitulo = New DevExpress.XtraEditors.LabelControl()
        Me.lkeDepObtTitulo = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblFechaGrado = New DevExpress.XtraEditors.LabelControl()
        Me.dteFechaGrado = New DevExpress.XtraEditors.DateEdit()
        Me.txtInstitucionObtTitulo = New SamitCtlNet.SamitTexto()
        Me.txtMatriculaProfesional = New SamitCtlNet.SamitTexto()
        Me.MenuGaleriaImagenes = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.btnImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEliminar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAmpliaImagenes = New DevExpress.XtraEditors.SimpleButton()
        Me.btnLimpiar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.gbxOpciones = New DevExpress.XtraEditors.GroupControl()
        CType(Me.tcEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tcEmpleados.SuspendLayout()
        Me.tpDatosBasicos.SuspendLayout()
        CType(Me.lcPrincipalDatosBasicos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lcPrincipalDatosBasicos.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.lkeClaseLibreta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtComentario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManagerMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcExpDocNacEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lcExpDocNacEmpleado.SuspendLayout()
        CType(Me.gbxLugarNacimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxLugarNacimiento.SuspendLayout()
        CType(Me.lkePaisNacimiento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkeMuniNacimiento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkeDepNacimiento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFechaNacimiento.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFechaNacimiento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gbxExpDocumento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxExpDocumento.SuspendLayout()
        CType(Me.dteFechaExpDocumento.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFechaExpDocumento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkePaisExpDocumento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkeMuniExpDocumento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkeDepExpDocumento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcgExpDocNacEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciExpDocEmp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciLugarNacEmp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gbxLugarResidencia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxLugarResidencia.SuspendLayout()
        CType(Me.lkePaisResidencia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkeMuniResidencia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkeDepResidencia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gbxImgFotoEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxImgFotoEmpleado.SuspendLayout()
        CType(Me.pcbFotografiaEmpleado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.txtDigitoV.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDocEmpleado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.lcDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lcDatos.SuspendLayout()
        CType(Me.ndPersonaAcargo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcgDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciTxtPnombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciTxtSnombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciTxtPapellido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciSapellido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciTxtTel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciTxtTel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciTxtCel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciNdPerAcargo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciLblPersonasAcargo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grTipoCuenta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcgPrincipalDatosBasicos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciNumDocDVbtnBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciDatosBasicosIzq, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciDatsoBasicosDer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpAfiliaciones.SuspendLayout()
        CType(Me.gbxImagenesAfiliacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxImagenesAfiliacion.SuspendLayout()
        CType(Me.GalleryControlAfiliaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GalleryControlAfiliaciones.SuspendLayout()
        CType(Me.gbxInfAfiliaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxInfAfiliaciones.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtCausaRetiroEntidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFechaRegistroEmpEntidad.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFechaRegistroEmpEntidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgbEmpRetiradoEntidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gbxGrillaAfiliaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxGrillaAfiliaciones.SuspendLayout()
        CType(Me.gcAfiliaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvAfilicaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpFamiliares.SuspendLayout()
        CType(Me.gbxImgFamiliar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxImgFamiliar.SuspendLayout()
        CType(Me.pcbImgFamiliar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gbxGrillaFamiliares, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxGrillaFamiliares.SuspendLayout()
        CType(Me.gcFamiliares, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvFamiliares, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gbxInfFamiliar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxInfFamiliar.SuspendLayout()
        CType(Me.lkeParentescoFamiliar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkeTipoDocFamiliar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFecNacFamiliar.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFecNacFamiliar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gbxUbicacionEmpTrabajaEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxUbicacionEmpTrabajaEmpleado.SuspendLayout()
        CType(Me.lkePaisEmpTrabajaFamiliar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkeMuniEmpTrabajaFamiliar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkeDepEmpTrabajaFamiliar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpExpLaboral.SuspendLayout()
        CType(Me.gbxCertExpLab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxCertExpLab.SuspendLayout()
        CType(Me.GalleryControlExpLaboral, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GalleryControlExpLaboral.SuspendLayout()
        CType(Me.gbxGrillaExpLab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxGrillaExpLab.SuspendLayout()
        CType(Me.gcExpLaboral, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvExpLaboral, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gbxInfBasicaExpLab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxInfBasicaExpLab.SuspendLayout()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFecRetiroExpLab.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFecRetiroExpLab.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFecIngresoExpLab.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFecIngresoExpLab.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpInfAcademica.SuspendLayout()
        CType(Me.gbxCertEstudios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxCertEstudios.SuspendLayout()
        CType(Me.GalleryControlEstudios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GalleryControlEstudios.SuspendLayout()
        CType(Me.gbxGrillaInfAcademica, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxGrillaInfAcademica.SuspendLayout()
        CType(Me.gcEstudios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvEstudios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gbxInfBasicaEstudios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxInfBasicaEstudios.SuspendLayout()
        CType(Me.cbxTipoTiempo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ndDuracion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkeNivelEducativo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grbTipoEducacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkeTituloObtenido.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gbxLugarObtTitulo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxLugarObtTitulo.SuspendLayout()
        CType(Me.lkePaisObtTitulo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkeMuniObtTitulo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkeDepObtTitulo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFechaGrado.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFechaGrado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuGaleriaImagenes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gbxOpciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxOpciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'tcEmpleados
        '
        Me.tcEmpleados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tcEmpleados.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.tcEmpleados.Appearance.Options.UseFont = True
        Me.tcEmpleados.AppearancePage.Header.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.tcEmpleados.AppearancePage.Header.Options.UseFont = True
        Me.tcEmpleados.AppearancePage.HeaderActive.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcEmpleados.AppearancePage.HeaderActive.Options.UseFont = True
        Me.tcEmpleados.AppearancePage.HeaderDisabled.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.tcEmpleados.AppearancePage.HeaderDisabled.Options.UseFont = True
        Me.tcEmpleados.AppearancePage.HeaderHotTracked.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.tcEmpleados.AppearancePage.HeaderHotTracked.Options.UseFont = True
        Me.tcEmpleados.AppearancePage.PageClient.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.tcEmpleados.AppearancePage.PageClient.Options.UseFont = True
        Me.tcEmpleados.HeaderAutoFill = DevExpress.Utils.DefaultBoolean.[True]
        Me.tcEmpleados.Location = New System.Drawing.Point(14, 15)
        Me.tcEmpleados.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tcEmpleados.Name = "tcEmpleados"
        Me.tcEmpleados.SelectedTabPage = Me.tpDatosBasicos
        Me.tcEmpleados.Size = New System.Drawing.Size(1092, 598)
        Me.tcEmpleados.TabIndex = 0
        Me.tcEmpleados.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tpDatosBasicos, Me.tpAfiliaciones, Me.tpFamiliares, Me.tpExpLaboral, Me.tpInfAcademica})
        '
        'tpDatosBasicos
        '
        Me.tpDatosBasicos.AllowTouchScroll = True
        Me.tpDatosBasicos.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.tpDatosBasicos.Appearance.Header.Options.UseFont = True
        Me.tpDatosBasicos.Appearance.HeaderActive.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.tpDatosBasicos.Appearance.HeaderActive.Options.UseFont = True
        Me.tpDatosBasicos.Appearance.HeaderDisabled.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.tpDatosBasicos.Appearance.HeaderDisabled.Options.UseFont = True
        Me.tpDatosBasicos.Appearance.HeaderHotTracked.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.tpDatosBasicos.Appearance.HeaderHotTracked.Options.UseFont = True
        Me.tpDatosBasicos.Appearance.PageClient.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.tpDatosBasicos.Appearance.PageClient.Options.UseFont = True
        Me.tpDatosBasicos.AutoScroll = True
        Me.tpDatosBasicos.Controls.Add(Me.lcPrincipalDatosBasicos)
        Me.tpDatosBasicos.ImageOptions.Padding = New System.Windows.Forms.Padding(2)
        Me.tpDatosBasicos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tpDatosBasicos.Name = "tpDatosBasicos"
        Me.tpDatosBasicos.Size = New System.Drawing.Size(1090, 566)
        Me.tpDatosBasicos.Text = "&Datos Básicos"
        '
        'lcPrincipalDatosBasicos
        '
        Me.lcPrincipalDatosBasicos.Controls.Add(Me.Panel2)
        Me.lcPrincipalDatosBasicos.Controls.Add(Me.Panel3)
        Me.lcPrincipalDatosBasicos.Controls.Add(Me.Panel1)
        Me.lcPrincipalDatosBasicos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lcPrincipalDatosBasicos.Location = New System.Drawing.Point(0, 0)
        Me.lcPrincipalDatosBasicos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lcPrincipalDatosBasicos.Name = "lcPrincipalDatosBasicos"
        Me.lcPrincipalDatosBasicos.OptionsFocus.EnableAutoTabOrder = False
        Me.lcPrincipalDatosBasicos.OptionsView.UseDefaultDragAndDropRendering = False
        Me.lcPrincipalDatosBasicos.Root = Me.lcgPrincipalDatosBasicos
        Me.lcPrincipalDatosBasicos.Size = New System.Drawing.Size(1090, 566)
        Me.lcPrincipalDatosBasicos.TabIndex = 80
        Me.lcPrincipalDatosBasicos.Text = "LayoutControl1"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.txtClaseLicencia)
        Me.Panel2.Controls.Add(Me.lblClaseLibreta)
        Me.Panel2.Controls.Add(Me.lkeClaseLibreta)
        Me.Panel2.Controls.Add(Me.txtNumLicencia)
        Me.Panel2.Controls.Add(Me.lblComentarios)
        Me.Panel2.Controls.Add(Me.txtComentario)
        Me.Panel2.Controls.Add(Me.lcExpDocNacEmpleado)
        Me.Panel2.Controls.Add(Me.gbxLugarResidencia)
        Me.Panel2.Controls.Add(Me.txtDistritoMil)
        Me.Panel2.Controls.Add(Me.gbxImgFotoEmpleado)
        Me.Panel2.Controls.Add(Me.txtNumLibreta)
        Me.Panel2.Location = New System.Drawing.Point(531, 2)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(557, 558)
        Me.Panel2.TabIndex = 79
        '
        'txtClaseLicencia
        '
        Me.txtClaseLicencia.AlineacionTexto = SamitCtlNet.AlinearTexto.Centro
        Me.txtClaseLicencia.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtClaseLicencia.AltodelControl = 30
        Me.txtClaseLicencia.AnchoLabel = 120
        Me.txtClaseLicencia.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtClaseLicencia.AnchoTxt = 95
        Me.txtClaseLicencia.AutoCargarDatos = True
        Me.txtClaseLicencia.AutoSize = True
        Me.txtClaseLicencia.BackColor = System.Drawing.Color.Transparent
        Me.txtClaseLicencia.ColorFondo = System.Drawing.Color.Transparent
        Me.txtClaseLicencia.CondicionValida = ""
        Me.txtClaseLicencia.Conexion = SamitCtlNet.ConexionSAMIT.ConexSeguridad
        Me.txtClaseLicencia.ConsultaSQL = ""
        Me.txtClaseLicencia.DatosDefecto = Nothing
        Me.txtClaseLicencia.EsObligatorio = False
        Me.txtClaseLicencia.FormatoNumero = Nothing
        Me.txtClaseLicencia.ListaColumnas = Nothing
        Me.txtClaseLicencia.Location = New System.Drawing.Point(0, 388)
        Me.txtClaseLicencia.Margin = New System.Windows.Forms.Padding(5)
        Me.txtClaseLicencia.MaximoAncho = 0
        Me.txtClaseLicencia.MensajedeAyuda = Nothing
        Me.txtClaseLicencia.Name = "txtClaseLicencia"
        Me.txtClaseLicencia.Size = New System.Drawing.Size(555, 37)
        Me.txtClaseLicencia.SoloLectura = False
        Me.txtClaseLicencia.SoloNumeros = False
        Me.txtClaseLicencia.TabIndex = 4
        Me.txtClaseLicencia.TextodelControl = ""
        Me.txtClaseLicencia.TextoLabel = "Clase Licencia :"
        Me.txtClaseLicencia.TieneErrorControl = False
        Me.txtClaseLicencia.TipoBusqueda = SamitCtlNet.ModGeneral.TipoBusqueda.Ninguna
        Me.txtClaseLicencia.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtClaseLicencia.TipodeLetra = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClaseLicencia.ValordelControl = ""
        Me.txtClaseLicencia.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtClaseLicencia.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtClaseLicencia.ValorPredeterminado = Nothing
        '
        'lblClaseLibreta
        '
        Me.lblClaseLibreta.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lblClaseLibreta.Appearance.Options.UseFont = True
        Me.lblClaseLibreta.Appearance.Options.UseTextOptions = True
        Me.lblClaseLibreta.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblClaseLibreta.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblClaseLibreta.Location = New System.Drawing.Point(296, 425)
        Me.lblClaseLibreta.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblClaseLibreta.Name = "lblClaseLibreta"
        Me.lblClaseLibreta.Padding = New System.Windows.Forms.Padding(2)
        Me.lblClaseLibreta.Size = New System.Drawing.Size(110, 32)
        Me.lblClaseLibreta.TabIndex = 75
        Me.lblClaseLibreta.Text = "Clase Libreta :"
        '
        'lkeClaseLibreta
        '
        Me.lkeClaseLibreta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lkeClaseLibreta.Location = New System.Drawing.Point(414, 428)
        Me.lkeClaseLibreta.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lkeClaseLibreta.Name = "lkeClaseLibreta"
        Me.lkeClaseLibreta.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeClaseLibreta.Properties.Appearance.Options.UseFont = True
        Me.lkeClaseLibreta.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeClaseLibreta.Properties.AppearanceDisabled.Options.UseFont = True
        Me.lkeClaseLibreta.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeClaseLibreta.Properties.AppearanceDropDown.Options.UseFont = True
        Me.lkeClaseLibreta.Properties.AppearanceDropDownHeader.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeClaseLibreta.Properties.AppearanceDropDownHeader.Options.UseFont = True
        Me.lkeClaseLibreta.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeClaseLibreta.Properties.AppearanceFocused.Options.UseFont = True
        Me.lkeClaseLibreta.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeClaseLibreta.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.lkeClaseLibreta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkeClaseLibreta.Properties.CloseUpKey = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.Right)
        Me.lkeClaseLibreta.Properties.NullText = "Seleccione..."
        Me.lkeClaseLibreta.Properties.ShowFooter = False
        Me.lkeClaseLibreta.Properties.ShowHeader = False
        Me.lkeClaseLibreta.Size = New System.Drawing.Size(140, 24)
        Me.lkeClaseLibreta.TabIndex = 6
        '
        'txtNumLicencia
        '
        Me.txtNumLicencia.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtNumLicencia.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtNumLicencia.AltodelControl = 30
        Me.txtNumLicencia.AnchoLabel = 120
        Me.txtNumLicencia.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNumLicencia.AutoSize = True
        Me.txtNumLicencia.BackColor = System.Drawing.Color.Transparent
        Me.txtNumLicencia.ColordeFondo = System.Drawing.Color.Transparent
        Me.txtNumLicencia.EsObligatorio = False
        Me.txtNumLicencia.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumLicencia.FormatoNumero = Nothing
        Me.txtNumLicencia.Location = New System.Drawing.Point(0, 353)
        Me.txtNumLicencia.Margin = New System.Windows.Forms.Padding(5)
        Me.txtNumLicencia.MaximoAncho = 0
        Me.txtNumLicencia.MensajedeAyuda = Nothing
        Me.txtNumLicencia.Name = "txtNumLicencia"
        Me.txtNumLicencia.Size = New System.Drawing.Size(562, 37)
        Me.txtNumLicencia.SoloLectura = False
        Me.txtNumLicencia.SoloNumeros = False
        Me.txtNumLicencia.TabIndex = 3
        Me.txtNumLicencia.TextodelControl = ""
        Me.txtNumLicencia.TextoLabel = "Num. Licencia :"
        Me.txtNumLicencia.TieneErrorControl = False
        Me.txtNumLicencia.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtNumLicencia.TipodeLetra = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumLicencia.ValordelControl = Nothing
        Me.txtNumLicencia.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumLicencia.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumLicencia.ValorPredeterminado = Nothing
        '
        'lblComentarios
        '
        Me.lblComentarios.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lblComentarios.Appearance.Options.UseFont = True
        Me.lblComentarios.Appearance.Options.UseTextOptions = True
        Me.lblComentarios.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblComentarios.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblComentarios.Location = New System.Drawing.Point(7, 497)
        Me.lblComentarios.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblComentarios.Name = "lblComentarios"
        Me.lblComentarios.Padding = New System.Windows.Forms.Padding(2)
        Me.lblComentarios.Size = New System.Drawing.Size(127, 22)
        Me.lblComentarios.TabIndex = 74
        Me.lblComentarios.Text = "Comentario :"
        '
        'txtComentario
        '
        Me.txtComentario.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtComentario.Location = New System.Drawing.Point(143, 498)
        Me.txtComentario.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtComentario.MenuManager = Me.BarManagerMenu
        Me.txtComentario.Name = "txtComentario"
        Me.txtComentario.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.txtComentario.Properties.Appearance.Options.UseFont = True
        Me.txtComentario.Size = New System.Drawing.Size(414, 52)
        Me.txtComentario.TabIndex = 8
        '
        'BarManagerMenu
        '
        Me.BarManagerMenu.DockControls.Add(Me.barDockControlTop)
        Me.BarManagerMenu.DockControls.Add(Me.barDockControlBottom)
        Me.BarManagerMenu.DockControls.Add(Me.barDockControlLeft)
        Me.BarManagerMenu.DockControls.Add(Me.barDockControlRight)
        Me.BarManagerMenu.Form = Me
        Me.BarManagerMenu.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnQuitarImageGaleria})
        Me.BarManagerMenu.MaxItemId = 1
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManagerMenu
        Me.barDockControlTop.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.barDockControlTop.Size = New System.Drawing.Size(1227, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 624)
        Me.barDockControlBottom.Manager = Me.BarManagerMenu
        Me.barDockControlBottom.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1227, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.BarManagerMenu
        Me.barDockControlLeft.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 624)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1227, 0)
        Me.barDockControlRight.Manager = Me.BarManagerMenu
        Me.barDockControlRight.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 624)
        '
        'btnQuitarImageGaleria
        '
        Me.btnQuitarImageGaleria.Caption = "Eliminar"
        Me.btnQuitarImageGaleria.Id = 0
        Me.btnQuitarImageGaleria.ImageOptions.Image = CType(resources.GetObject("btnQuitarImageGaleria.ImageOptions.Image"), System.Drawing.Image)
        Me.btnQuitarImageGaleria.ImageOptions.LargeImage = CType(resources.GetObject("btnQuitarImageGaleria.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnQuitarImageGaleria.ItemAppearance.Disabled.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnQuitarImageGaleria.ItemAppearance.Disabled.Options.UseFont = True
        Me.btnQuitarImageGaleria.ItemAppearance.Hovered.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnQuitarImageGaleria.ItemAppearance.Hovered.Options.UseFont = True
        Me.btnQuitarImageGaleria.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnQuitarImageGaleria.ItemAppearance.Normal.Options.UseFont = True
        Me.btnQuitarImageGaleria.ItemAppearance.Pressed.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.btnQuitarImageGaleria.ItemAppearance.Pressed.Options.UseFont = True
        Me.btnQuitarImageGaleria.Name = "btnQuitarImageGaleria"
        '
        'lcExpDocNacEmpleado
        '
        Me.lcExpDocNacEmpleado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lcExpDocNacEmpleado.Controls.Add(Me.gbxLugarNacimiento)
        Me.lcExpDocNacEmpleado.Controls.Add(Me.gbxExpDocumento)
        Me.lcExpDocNacEmpleado.Location = New System.Drawing.Point(1, 192)
        Me.lcExpDocNacEmpleado.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lcExpDocNacEmpleado.Name = "lcExpDocNacEmpleado"
        Me.lcExpDocNacEmpleado.OptionsFocus.EnableAutoTabOrder = False
        Me.lcExpDocNacEmpleado.OptionsView.UseDefaultDragAndDropRendering = False
        Me.lcExpDocNacEmpleado.Root = Me.lcgExpDocNacEmpleado
        Me.lcExpDocNacEmpleado.Size = New System.Drawing.Size(565, 156)
        Me.lcExpDocNacEmpleado.TabIndex = 2
        Me.lcExpDocNacEmpleado.Text = "LayoutControl2"
        '
        'gbxLugarNacimiento
        '
        Me.gbxLugarNacimiento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxLugarNacimiento.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.gbxLugarNacimiento.AppearanceCaption.Options.UseFont = True
        Me.gbxLugarNacimiento.Controls.Add(Me.lkePaisNacimiento)
        Me.gbxLugarNacimiento.Controls.Add(Me.lblMuniNac)
        Me.gbxLugarNacimiento.Controls.Add(Me.lkeMuniNacimiento)
        Me.gbxLugarNacimiento.Controls.Add(Me.lblPaisNac)
        Me.gbxLugarNacimiento.Controls.Add(Me.lblDepNac)
        Me.gbxLugarNacimiento.Controls.Add(Me.lkeDepNacimiento)
        Me.gbxLugarNacimiento.Controls.Add(Me.lblFechaNac)
        Me.gbxLugarNacimiento.Controls.Add(Me.dteFechaNacimiento)
        Me.gbxLugarNacimiento.Location = New System.Drawing.Point(284, 2)
        Me.gbxLugarNacimiento.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbxLugarNacimiento.Name = "gbxLugarNacimiento"
        Me.gbxLugarNacimiento.Padding = New System.Windows.Forms.Padding(6)
        Me.gbxLugarNacimiento.Size = New System.Drawing.Size(279, 152)
        Me.gbxLugarNacimiento.TabIndex = 2
        Me.gbxLugarNacimiento.Text = "Lugar de Nacimiento"
        '
        'lkePaisNacimiento
        '
        Me.lkePaisNacimiento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lkePaisNacimiento.Location = New System.Drawing.Point(138, 32)
        Me.lkePaisNacimiento.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lkePaisNacimiento.Name = "lkePaisNacimiento"
        Me.lkePaisNacimiento.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkePaisNacimiento.Properties.Appearance.Options.UseFont = True
        Me.lkePaisNacimiento.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkePaisNacimiento.Properties.AppearanceDisabled.Options.UseFont = True
        Me.lkePaisNacimiento.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkePaisNacimiento.Properties.AppearanceDropDown.Options.UseFont = True
        Me.lkePaisNacimiento.Properties.AppearanceDropDownHeader.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkePaisNacimiento.Properties.AppearanceDropDownHeader.Options.UseFont = True
        Me.lkePaisNacimiento.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkePaisNacimiento.Properties.AppearanceFocused.Options.UseFont = True
        Me.lkePaisNacimiento.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkePaisNacimiento.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.lkePaisNacimiento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkePaisNacimiento.Properties.CloseUpKey = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.Right)
        Me.lkePaisNacimiento.Properties.NullText = "Seleccione..."
        Me.lkePaisNacimiento.Properties.ShowFooter = False
        Me.lkePaisNacimiento.Properties.ShowHeader = False
        Me.lkePaisNacimiento.Size = New System.Drawing.Size(136, 24)
        Me.lkePaisNacimiento.TabIndex = 33
        '
        'lblMuniNac
        '
        Me.lblMuniNac.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lblMuniNac.Appearance.Options.UseFont = True
        Me.lblMuniNac.Appearance.Options.UseTextOptions = True
        Me.lblMuniNac.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblMuniNac.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblMuniNac.Location = New System.Drawing.Point(3, 87)
        Me.lblMuniNac.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblMuniNac.Name = "lblMuniNac"
        Me.lblMuniNac.Padding = New System.Windows.Forms.Padding(2)
        Me.lblMuniNac.Size = New System.Drawing.Size(127, 32)
        Me.lblMuniNac.TabIndex = 23
        Me.lblMuniNac.Text = "Municipio :"
        '
        'lkeMuniNacimiento
        '
        Me.lkeMuniNacimiento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lkeMuniNacimiento.Location = New System.Drawing.Point(138, 91)
        Me.lkeMuniNacimiento.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lkeMuniNacimiento.Name = "lkeMuniNacimiento"
        Me.lkeMuniNacimiento.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeMuniNacimiento.Properties.Appearance.Options.UseFont = True
        Me.lkeMuniNacimiento.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeMuniNacimiento.Properties.AppearanceDisabled.Options.UseFont = True
        Me.lkeMuniNacimiento.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeMuniNacimiento.Properties.AppearanceDropDown.Options.UseFont = True
        Me.lkeMuniNacimiento.Properties.AppearanceDropDownHeader.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeMuniNacimiento.Properties.AppearanceDropDownHeader.Options.UseFont = True
        Me.lkeMuniNacimiento.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeMuniNacimiento.Properties.AppearanceFocused.Options.UseFont = True
        Me.lkeMuniNacimiento.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeMuniNacimiento.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.lkeMuniNacimiento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkeMuniNacimiento.Properties.CloseUpKey = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.Right)
        Me.lkeMuniNacimiento.Properties.NullText = "Seleccione..."
        Me.lkeMuniNacimiento.Properties.ShowFooter = False
        Me.lkeMuniNacimiento.Properties.ShowHeader = False
        Me.lkeMuniNacimiento.Size = New System.Drawing.Size(136, 24)
        Me.lkeMuniNacimiento.TabIndex = 35
        '
        'lblPaisNac
        '
        Me.lblPaisNac.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lblPaisNac.Appearance.Options.UseFont = True
        Me.lblPaisNac.Appearance.Options.UseTextOptions = True
        Me.lblPaisNac.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblPaisNac.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblPaisNac.Location = New System.Drawing.Point(3, 28)
        Me.lblPaisNac.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblPaisNac.Name = "lblPaisNac"
        Me.lblPaisNac.Padding = New System.Windows.Forms.Padding(2)
        Me.lblPaisNac.Size = New System.Drawing.Size(127, 32)
        Me.lblPaisNac.TabIndex = 25
        Me.lblPaisNac.Text = "Pais :"
        '
        'lblDepNac
        '
        Me.lblDepNac.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lblDepNac.Appearance.Options.UseFont = True
        Me.lblDepNac.Appearance.Options.UseTextOptions = True
        Me.lblDepNac.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblDepNac.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblDepNac.Location = New System.Drawing.Point(3, 58)
        Me.lblDepNac.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblDepNac.Name = "lblDepNac"
        Me.lblDepNac.Padding = New System.Windows.Forms.Padding(2)
        Me.lblDepNac.Size = New System.Drawing.Size(127, 32)
        Me.lblDepNac.TabIndex = 27
        Me.lblDepNac.Text = "Departamento :"
        '
        'lkeDepNacimiento
        '
        Me.lkeDepNacimiento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lkeDepNacimiento.Location = New System.Drawing.Point(138, 62)
        Me.lkeDepNacimiento.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lkeDepNacimiento.Name = "lkeDepNacimiento"
        Me.lkeDepNacimiento.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeDepNacimiento.Properties.Appearance.Options.UseFont = True
        Me.lkeDepNacimiento.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeDepNacimiento.Properties.AppearanceDisabled.Options.UseFont = True
        Me.lkeDepNacimiento.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeDepNacimiento.Properties.AppearanceDropDown.Options.UseFont = True
        Me.lkeDepNacimiento.Properties.AppearanceDropDownHeader.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeDepNacimiento.Properties.AppearanceDropDownHeader.Options.UseFont = True
        Me.lkeDepNacimiento.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeDepNacimiento.Properties.AppearanceFocused.Options.UseFont = True
        Me.lkeDepNacimiento.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeDepNacimiento.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.lkeDepNacimiento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkeDepNacimiento.Properties.CloseUpKey = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.Right)
        Me.lkeDepNacimiento.Properties.NullText = "Seleccione..."
        Me.lkeDepNacimiento.Properties.ShowFooter = False
        Me.lkeDepNacimiento.Properties.ShowHeader = False
        Me.lkeDepNacimiento.Size = New System.Drawing.Size(136, 24)
        Me.lkeDepNacimiento.TabIndex = 34
        '
        'lblFechaNac
        '
        Me.lblFechaNac.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lblFechaNac.Appearance.Options.UseFont = True
        Me.lblFechaNac.Appearance.Options.UseTextOptions = True
        Me.lblFechaNac.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblFechaNac.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblFechaNac.Location = New System.Drawing.Point(3, 116)
        Me.lblFechaNac.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblFechaNac.Name = "lblFechaNac"
        Me.lblFechaNac.Padding = New System.Windows.Forms.Padding(2)
        Me.lblFechaNac.Size = New System.Drawing.Size(127, 32)
        Me.lblFechaNac.TabIndex = 21
        Me.lblFechaNac.Text = "Fecha :"
        '
        'dteFechaNacimiento
        '
        Me.dteFechaNacimiento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dteFechaNacimiento.EditValue = Nothing
        Me.dteFechaNacimiento.Location = New System.Drawing.Point(138, 121)
        Me.dteFechaNacimiento.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dteFechaNacimiento.Name = "dteFechaNacimiento"
        Me.dteFechaNacimiento.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.dteFechaNacimiento.Properties.Appearance.Options.UseFont = True
        Me.dteFechaNacimiento.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.dteFechaNacimiento.Properties.AppearanceDropDown.Options.UseFont = True
        Me.dteFechaNacimiento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteFechaNacimiento.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteFechaNacimiento.Size = New System.Drawing.Size(136, 24)
        Me.dteFechaNacimiento.TabIndex = 36
        '
        'gbxExpDocumento
        '
        Me.gbxExpDocumento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxExpDocumento.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.gbxExpDocumento.AppearanceCaption.Options.UseFont = True
        Me.gbxExpDocumento.Controls.Add(Me.lblFechaExpDoc)
        Me.gbxExpDocumento.Controls.Add(Me.dteFechaExpDocumento)
        Me.gbxExpDocumento.Controls.Add(Me.lkePaisExpDocumento)
        Me.gbxExpDocumento.Controls.Add(Me.lblMuniExpDoc)
        Me.gbxExpDocumento.Controls.Add(Me.lkeMuniExpDocumento)
        Me.gbxExpDocumento.Controls.Add(Me.lblPaisExpDoc)
        Me.gbxExpDocumento.Controls.Add(Me.lblDepExpDoc)
        Me.gbxExpDocumento.Controls.Add(Me.lkeDepExpDocumento)
        Me.gbxExpDocumento.Location = New System.Drawing.Point(2, 2)
        Me.gbxExpDocumento.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbxExpDocumento.Name = "gbxExpDocumento"
        Me.gbxExpDocumento.Padding = New System.Windows.Forms.Padding(6)
        Me.gbxExpDocumento.Size = New System.Drawing.Size(278, 152)
        Me.gbxExpDocumento.TabIndex = 1
        Me.gbxExpDocumento.Text = "Expedición de Documento"
        '
        'lblFechaExpDoc
        '
        Me.lblFechaExpDoc.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lblFechaExpDoc.Appearance.Options.UseFont = True
        Me.lblFechaExpDoc.Appearance.Options.UseTextOptions = True
        Me.lblFechaExpDoc.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblFechaExpDoc.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblFechaExpDoc.Location = New System.Drawing.Point(6, 117)
        Me.lblFechaExpDoc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblFechaExpDoc.Name = "lblFechaExpDoc"
        Me.lblFechaExpDoc.Padding = New System.Windows.Forms.Padding(2)
        Me.lblFechaExpDoc.Size = New System.Drawing.Size(127, 32)
        Me.lblFechaExpDoc.TabIndex = 8
        Me.lblFechaExpDoc.Text = "Fecha :"
        '
        'dteFechaExpDocumento
        '
        Me.dteFechaExpDocumento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dteFechaExpDocumento.EditValue = Nothing
        Me.dteFechaExpDocumento.Location = New System.Drawing.Point(141, 122)
        Me.dteFechaExpDocumento.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dteFechaExpDocumento.Name = "dteFechaExpDocumento"
        Me.dteFechaExpDocumento.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.dteFechaExpDocumento.Properties.Appearance.Options.UseFont = True
        Me.dteFechaExpDocumento.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.dteFechaExpDocumento.Properties.AppearanceDropDown.Options.UseFont = True
        Me.dteFechaExpDocumento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteFechaExpDocumento.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteFechaExpDocumento.Size = New System.Drawing.Size(132, 24)
        Me.dteFechaExpDocumento.TabIndex = 12
        '
        'lkePaisExpDocumento
        '
        Me.lkePaisExpDocumento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lkePaisExpDocumento.Location = New System.Drawing.Point(141, 33)
        Me.lkePaisExpDocumento.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lkePaisExpDocumento.Name = "lkePaisExpDocumento"
        Me.lkePaisExpDocumento.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkePaisExpDocumento.Properties.Appearance.Options.UseFont = True
        Me.lkePaisExpDocumento.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkePaisExpDocumento.Properties.AppearanceDisabled.Options.UseFont = True
        Me.lkePaisExpDocumento.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkePaisExpDocumento.Properties.AppearanceDropDown.Options.UseFont = True
        Me.lkePaisExpDocumento.Properties.AppearanceDropDownHeader.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkePaisExpDocumento.Properties.AppearanceDropDownHeader.Options.UseFont = True
        Me.lkePaisExpDocumento.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkePaisExpDocumento.Properties.AppearanceFocused.Options.UseFont = True
        Me.lkePaisExpDocumento.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkePaisExpDocumento.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.lkePaisExpDocumento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkePaisExpDocumento.Properties.CloseUpKey = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.Right)
        Me.lkePaisExpDocumento.Properties.NullText = "Seleccione..."
        Me.lkePaisExpDocumento.Properties.ShowFooter = False
        Me.lkePaisExpDocumento.Properties.ShowHeader = False
        Me.lkePaisExpDocumento.Size = New System.Drawing.Size(132, 24)
        Me.lkePaisExpDocumento.TabIndex = 9
        '
        'lblMuniExpDoc
        '
        Me.lblMuniExpDoc.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lblMuniExpDoc.Appearance.Options.UseFont = True
        Me.lblMuniExpDoc.Appearance.Options.UseTextOptions = True
        Me.lblMuniExpDoc.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblMuniExpDoc.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblMuniExpDoc.Location = New System.Drawing.Point(6, 89)
        Me.lblMuniExpDoc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblMuniExpDoc.Name = "lblMuniExpDoc"
        Me.lblMuniExpDoc.Padding = New System.Windows.Forms.Padding(2)
        Me.lblMuniExpDoc.Size = New System.Drawing.Size(127, 32)
        Me.lblMuniExpDoc.TabIndex = 7
        Me.lblMuniExpDoc.Text = "Municipio :"
        '
        'lkeMuniExpDocumento
        '
        Me.lkeMuniExpDocumento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lkeMuniExpDocumento.Location = New System.Drawing.Point(141, 92)
        Me.lkeMuniExpDocumento.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lkeMuniExpDocumento.Name = "lkeMuniExpDocumento"
        Me.lkeMuniExpDocumento.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeMuniExpDocumento.Properties.Appearance.Options.UseFont = True
        Me.lkeMuniExpDocumento.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeMuniExpDocumento.Properties.AppearanceDisabled.Options.UseFont = True
        Me.lkeMuniExpDocumento.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeMuniExpDocumento.Properties.AppearanceDropDown.Options.UseFont = True
        Me.lkeMuniExpDocumento.Properties.AppearanceDropDownHeader.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeMuniExpDocumento.Properties.AppearanceDropDownHeader.Options.UseFont = True
        Me.lkeMuniExpDocumento.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeMuniExpDocumento.Properties.AppearanceFocused.Options.UseFont = True
        Me.lkeMuniExpDocumento.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeMuniExpDocumento.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.lkeMuniExpDocumento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkeMuniExpDocumento.Properties.CloseUpKey = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.Right)
        Me.lkeMuniExpDocumento.Properties.NullText = "Seleccione..."
        Me.lkeMuniExpDocumento.Properties.ShowFooter = False
        Me.lkeMuniExpDocumento.Properties.ShowHeader = False
        Me.lkeMuniExpDocumento.Size = New System.Drawing.Size(132, 24)
        Me.lkeMuniExpDocumento.TabIndex = 11
        '
        'lblPaisExpDoc
        '
        Me.lblPaisExpDoc.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lblPaisExpDoc.Appearance.Options.UseFont = True
        Me.lblPaisExpDoc.Appearance.Options.UseTextOptions = True
        Me.lblPaisExpDoc.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblPaisExpDoc.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblPaisExpDoc.Location = New System.Drawing.Point(6, 30)
        Me.lblPaisExpDoc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblPaisExpDoc.Name = "lblPaisExpDoc"
        Me.lblPaisExpDoc.Padding = New System.Windows.Forms.Padding(2)
        Me.lblPaisExpDoc.Size = New System.Drawing.Size(127, 32)
        Me.lblPaisExpDoc.TabIndex = 5
        Me.lblPaisExpDoc.Text = "Pais :"
        '
        'lblDepExpDoc
        '
        Me.lblDepExpDoc.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lblDepExpDoc.Appearance.Options.UseFont = True
        Me.lblDepExpDoc.Appearance.Options.UseTextOptions = True
        Me.lblDepExpDoc.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblDepExpDoc.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblDepExpDoc.Location = New System.Drawing.Point(6, 59)
        Me.lblDepExpDoc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblDepExpDoc.Name = "lblDepExpDoc"
        Me.lblDepExpDoc.Padding = New System.Windows.Forms.Padding(2)
        Me.lblDepExpDoc.Size = New System.Drawing.Size(127, 32)
        Me.lblDepExpDoc.TabIndex = 6
        Me.lblDepExpDoc.Text = "Departamento :"
        '
        'lkeDepExpDocumento
        '
        Me.lkeDepExpDocumento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lkeDepExpDocumento.Location = New System.Drawing.Point(141, 63)
        Me.lkeDepExpDocumento.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lkeDepExpDocumento.Name = "lkeDepExpDocumento"
        Me.lkeDepExpDocumento.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeDepExpDocumento.Properties.Appearance.Options.UseFont = True
        Me.lkeDepExpDocumento.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeDepExpDocumento.Properties.AppearanceDisabled.Options.UseFont = True
        Me.lkeDepExpDocumento.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeDepExpDocumento.Properties.AppearanceDropDown.Options.UseFont = True
        Me.lkeDepExpDocumento.Properties.AppearanceDropDownHeader.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeDepExpDocumento.Properties.AppearanceDropDownHeader.Options.UseFont = True
        Me.lkeDepExpDocumento.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeDepExpDocumento.Properties.AppearanceFocused.Options.UseFont = True
        Me.lkeDepExpDocumento.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeDepExpDocumento.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.lkeDepExpDocumento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkeDepExpDocumento.Properties.CloseUpKey = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.Right)
        Me.lkeDepExpDocumento.Properties.NullText = "Seleccione..."
        Me.lkeDepExpDocumento.Properties.ShowFooter = False
        Me.lkeDepExpDocumento.Properties.ShowHeader = False
        Me.lkeDepExpDocumento.Size = New System.Drawing.Size(132, 24)
        Me.lkeDepExpDocumento.TabIndex = 10
        '
        'lcgExpDocNacEmpleado
        '
        Me.lcgExpDocNacEmpleado.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.lcgExpDocNacEmpleado.GroupBordersVisible = False
        Me.lcgExpDocNacEmpleado.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lciExpDocEmp, Me.lciLugarNacEmp})
        Me.lcgExpDocNacEmpleado.Name = "lcgExpDocNacEmpleado"
        Me.lcgExpDocNacEmpleado.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.lcgExpDocNacEmpleado.Size = New System.Drawing.Size(565, 156)
        Me.lcgExpDocNacEmpleado.TextVisible = False
        '
        'lciExpDocEmp
        '
        Me.lciExpDocEmp.Control = Me.gbxExpDocumento
        Me.lciExpDocEmp.Location = New System.Drawing.Point(0, 0)
        Me.lciExpDocEmp.Name = "lciExpDocEmp"
        Me.lciExpDocEmp.Size = New System.Drawing.Size(282, 156)
        Me.lciExpDocEmp.TextSize = New System.Drawing.Size(0, 0)
        Me.lciExpDocEmp.TextVisible = False
        '
        'lciLugarNacEmp
        '
        Me.lciLugarNacEmp.Control = Me.gbxLugarNacimiento
        Me.lciLugarNacEmp.Location = New System.Drawing.Point(282, 0)
        Me.lciLugarNacEmp.Name = "lciLugarNacEmp"
        Me.lciLugarNacEmp.Size = New System.Drawing.Size(283, 156)
        Me.lciLugarNacEmp.TextSize = New System.Drawing.Size(0, 0)
        Me.lciLugarNacEmp.TextVisible = False
        '
        'gbxLugarResidencia
        '
        Me.gbxLugarResidencia.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxLugarResidencia.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.gbxLugarResidencia.AppearanceCaption.Options.UseFont = True
        Me.gbxLugarResidencia.Controls.Add(Me.lkePaisResidencia)
        Me.gbxLugarResidencia.Controls.Add(Me.lblMuniResidencia)
        Me.gbxLugarResidencia.Controls.Add(Me.lkeMuniResidencia)
        Me.gbxLugarResidencia.Controls.Add(Me.lkeDepResidencia)
        Me.gbxLugarResidencia.Controls.Add(Me.lblPaisResidencia)
        Me.gbxLugarResidencia.Controls.Add(Me.lblDepResidencia)
        Me.gbxLugarResidencia.Controls.Add(Me.txtDireccion)
        Me.gbxLugarResidencia.Controls.Add(Me.txtBarrio)
        Me.gbxLugarResidencia.Location = New System.Drawing.Point(3, 4)
        Me.gbxLugarResidencia.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbxLugarResidencia.Name = "gbxLugarResidencia"
        Me.gbxLugarResidencia.Padding = New System.Windows.Forms.Padding(6)
        Me.gbxLugarResidencia.Size = New System.Drawing.Size(395, 186)
        Me.gbxLugarResidencia.TabIndex = 1
        Me.gbxLugarResidencia.Text = "Lugar de Residencia"
        '
        'lkePaisResidencia
        '
        Me.lkePaisResidencia.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lkePaisResidencia.Location = New System.Drawing.Point(150, 33)
        Me.lkePaisResidencia.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lkePaisResidencia.Name = "lkePaisResidencia"
        Me.lkePaisResidencia.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkePaisResidencia.Properties.Appearance.Options.UseFont = True
        Me.lkePaisResidencia.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkePaisResidencia.Properties.AppearanceDisabled.Options.UseFont = True
        Me.lkePaisResidencia.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkePaisResidencia.Properties.AppearanceDropDown.Options.UseFont = True
        Me.lkePaisResidencia.Properties.AppearanceDropDownHeader.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkePaisResidencia.Properties.AppearanceDropDownHeader.Options.UseFont = True
        Me.lkePaisResidencia.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkePaisResidencia.Properties.AppearanceFocused.Options.UseFont = True
        Me.lkePaisResidencia.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkePaisResidencia.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.lkePaisResidencia.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkePaisResidencia.Properties.CloseUpKey = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.Right)
        Me.lkePaisResidencia.Properties.NullText = "Seleccione..."
        Me.lkePaisResidencia.Properties.ShowFooter = False
        Me.lkePaisResidencia.Properties.ShowHeader = False
        Me.lkePaisResidencia.Size = New System.Drawing.Size(236, 24)
        Me.lkePaisResidencia.TabIndex = 4
        '
        'lblMuniResidencia
        '
        Me.lblMuniResidencia.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lblMuniResidencia.Appearance.Options.UseFont = True
        Me.lblMuniResidencia.Appearance.Options.UseTextOptions = True
        Me.lblMuniResidencia.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblMuniResidencia.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblMuniResidencia.Location = New System.Drawing.Point(12, 85)
        Me.lblMuniResidencia.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblMuniResidencia.Name = "lblMuniResidencia"
        Me.lblMuniResidencia.Padding = New System.Windows.Forms.Padding(2)
        Me.lblMuniResidencia.Size = New System.Drawing.Size(132, 32)
        Me.lblMuniResidencia.TabIndex = 3
        Me.lblMuniResidencia.Text = "Municipio :"
        '
        'lkeMuniResidencia
        '
        Me.lkeMuniResidencia.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lkeMuniResidencia.Location = New System.Drawing.Point(150, 92)
        Me.lkeMuniResidencia.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lkeMuniResidencia.Name = "lkeMuniResidencia"
        Me.lkeMuniResidencia.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeMuniResidencia.Properties.Appearance.Options.UseFont = True
        Me.lkeMuniResidencia.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeMuniResidencia.Properties.AppearanceDisabled.Options.UseFont = True
        Me.lkeMuniResidencia.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeMuniResidencia.Properties.AppearanceDropDown.Options.UseFont = True
        Me.lkeMuniResidencia.Properties.AppearanceDropDownHeader.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeMuniResidencia.Properties.AppearanceDropDownHeader.Options.UseFont = True
        Me.lkeMuniResidencia.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeMuniResidencia.Properties.AppearanceFocused.Options.UseFont = True
        Me.lkeMuniResidencia.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeMuniResidencia.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.lkeMuniResidencia.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkeMuniResidencia.Properties.CloseUpKey = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.Right)
        Me.lkeMuniResidencia.Properties.NullText = "Seleccione..."
        Me.lkeMuniResidencia.Properties.ShowFooter = False
        Me.lkeMuniResidencia.Properties.ShowHeader = False
        Me.lkeMuniResidencia.Size = New System.Drawing.Size(236, 24)
        Me.lkeMuniResidencia.TabIndex = 6
        '
        'lkeDepResidencia
        '
        Me.lkeDepResidencia.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lkeDepResidencia.Location = New System.Drawing.Point(150, 63)
        Me.lkeDepResidencia.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lkeDepResidencia.Name = "lkeDepResidencia"
        Me.lkeDepResidencia.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeDepResidencia.Properties.Appearance.Options.UseFont = True
        Me.lkeDepResidencia.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeDepResidencia.Properties.AppearanceDisabled.Options.UseFont = True
        Me.lkeDepResidencia.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeDepResidencia.Properties.AppearanceDropDown.Options.UseFont = True
        Me.lkeDepResidencia.Properties.AppearanceDropDownHeader.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeDepResidencia.Properties.AppearanceDropDownHeader.Options.UseFont = True
        Me.lkeDepResidencia.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeDepResidencia.Properties.AppearanceFocused.Options.UseFont = True
        Me.lkeDepResidencia.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeDepResidencia.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.lkeDepResidencia.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkeDepResidencia.Properties.CloseUpKey = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.Right)
        Me.lkeDepResidencia.Properties.NullText = "Seleccione..."
        Me.lkeDepResidencia.Properties.ShowFooter = False
        Me.lkeDepResidencia.Properties.ShowHeader = False
        Me.lkeDepResidencia.Size = New System.Drawing.Size(236, 24)
        Me.lkeDepResidencia.TabIndex = 5
        '
        'lblPaisResidencia
        '
        Me.lblPaisResidencia.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lblPaisResidencia.Appearance.Options.UseFont = True
        Me.lblPaisResidencia.Appearance.Options.UseTextOptions = True
        Me.lblPaisResidencia.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblPaisResidencia.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblPaisResidencia.Location = New System.Drawing.Point(12, 26)
        Me.lblPaisResidencia.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblPaisResidencia.Name = "lblPaisResidencia"
        Me.lblPaisResidencia.Padding = New System.Windows.Forms.Padding(2)
        Me.lblPaisResidencia.Size = New System.Drawing.Size(132, 32)
        Me.lblPaisResidencia.TabIndex = 1
        Me.lblPaisResidencia.Text = "Pais :"
        '
        'lblDepResidencia
        '
        Me.lblDepResidencia.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lblDepResidencia.Appearance.Options.UseFont = True
        Me.lblDepResidencia.Appearance.Options.UseTextOptions = True
        Me.lblDepResidencia.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblDepResidencia.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblDepResidencia.Location = New System.Drawing.Point(12, 55)
        Me.lblDepResidencia.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblDepResidencia.Name = "lblDepResidencia"
        Me.lblDepResidencia.Padding = New System.Windows.Forms.Padding(2)
        Me.lblDepResidencia.Size = New System.Drawing.Size(132, 32)
        Me.lblDepResidencia.TabIndex = 2
        Me.lblDepResidencia.Text = "Departamento :"
        '
        'txtDireccion
        '
        Me.txtDireccion.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtDireccion.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtDireccion.AltodelControl = 30
        Me.txtDireccion.AnchoLabel = 125
        Me.txtDireccion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDireccion.AutoSize = True
        Me.txtDireccion.BackColor = System.Drawing.Color.Transparent
        Me.txtDireccion.ColordeFondo = System.Drawing.Color.Transparent
        Me.txtDireccion.EsObligatorio = False
        Me.txtDireccion.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.FormatoNumero = Nothing
        Me.txtDireccion.Location = New System.Drawing.Point(2, 153)
        Me.txtDireccion.Margin = New System.Windows.Forms.Padding(5)
        Me.txtDireccion.MaximoAncho = 0
        Me.txtDireccion.MensajedeAyuda = ""
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(388, 37)
        Me.txtDireccion.SoloLectura = False
        Me.txtDireccion.SoloNumeros = False
        Me.txtDireccion.TabIndex = 8
        Me.txtDireccion.TextodelControl = ""
        Me.txtDireccion.TextoLabel = "Dirección :"
        Me.txtDireccion.TieneErrorControl = False
        Me.txtDireccion.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtDireccion.TipodeLetra = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.ValordelControl = Nothing
        Me.txtDireccion.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDireccion.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDireccion.ValorPredeterminado = Nothing
        '
        'txtBarrio
        '
        Me.txtBarrio.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtBarrio.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtBarrio.AltodelControl = 30
        Me.txtBarrio.AnchoLabel = 125
        Me.txtBarrio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBarrio.AutoSize = True
        Me.txtBarrio.BackColor = System.Drawing.Color.Transparent
        Me.txtBarrio.ColordeFondo = System.Drawing.Color.Transparent
        Me.txtBarrio.EsObligatorio = False
        Me.txtBarrio.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBarrio.FormatoNumero = Nothing
        Me.txtBarrio.Location = New System.Drawing.Point(2, 121)
        Me.txtBarrio.Margin = New System.Windows.Forms.Padding(5)
        Me.txtBarrio.MaximoAncho = 0
        Me.txtBarrio.MensajedeAyuda = ""
        Me.txtBarrio.Name = "txtBarrio"
        Me.txtBarrio.Size = New System.Drawing.Size(388, 37)
        Me.txtBarrio.SoloLectura = False
        Me.txtBarrio.SoloNumeros = False
        Me.txtBarrio.TabIndex = 7
        Me.txtBarrio.TextodelControl = ""
        Me.txtBarrio.TextoLabel = "Barrio :"
        Me.txtBarrio.TieneErrorControl = False
        Me.txtBarrio.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtBarrio.TipodeLetra = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBarrio.ValordelControl = Nothing
        Me.txtBarrio.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtBarrio.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtBarrio.ValorPredeterminado = Nothing
        '
        'txtDistritoMil
        '
        Me.txtDistritoMil.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtDistritoMil.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtDistritoMil.AltodelControl = 30
        Me.txtDistritoMil.AnchoLabel = 120
        Me.txtDistritoMil.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDistritoMil.AutoSize = True
        Me.txtDistritoMil.ColordeFondo = System.Drawing.Color.Transparent
        Me.txtDistritoMil.EsObligatorio = False
        Me.txtDistritoMil.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDistritoMil.FormatoNumero = Nothing
        Me.txtDistritoMil.Location = New System.Drawing.Point(0, 457)
        Me.txtDistritoMil.Margin = New System.Windows.Forms.Padding(5)
        Me.txtDistritoMil.MaximoAncho = 0
        Me.txtDistritoMil.MensajedeAyuda = Nothing
        Me.txtDistritoMil.Name = "txtDistritoMil"
        Me.txtDistritoMil.Size = New System.Drawing.Size(561, 37)
        Me.txtDistritoMil.SoloLectura = False
        Me.txtDistritoMil.SoloNumeros = False
        Me.txtDistritoMil.TabIndex = 7
        Me.txtDistritoMil.TextodelControl = ""
        Me.txtDistritoMil.TextoLabel = "DM :"
        Me.txtDistritoMil.TieneErrorControl = False
        Me.txtDistritoMil.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtDistritoMil.TipodeLetra = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDistritoMil.ValordelControl = Nothing
        Me.txtDistritoMil.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDistritoMil.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDistritoMil.ValorPredeterminado = Nothing
        '
        'gbxImgFotoEmpleado
        '
        Me.gbxImgFotoEmpleado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxImgFotoEmpleado.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.gbxImgFotoEmpleado.AppearanceCaption.Options.UseFont = True
        Me.gbxImgFotoEmpleado.AppearanceCaption.Options.UseTextOptions = True
        Me.gbxImgFotoEmpleado.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gbxImgFotoEmpleado.Controls.Add(Me.pcbFotografiaEmpleado)
        Me.gbxImgFotoEmpleado.Location = New System.Drawing.Point(403, 2)
        Me.gbxImgFotoEmpleado.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbxImgFotoEmpleado.Name = "gbxImgFotoEmpleado"
        Me.gbxImgFotoEmpleado.Size = New System.Drawing.Size(161, 187)
        Me.gbxImgFotoEmpleado.TabIndex = 71
        Me.gbxImgFotoEmpleado.Text = "Fotografía"
        '
        'pcbFotografiaEmpleado
        '
        Me.pcbFotografiaEmpleado.Cursor = System.Windows.Forms.Cursors.Default
        Me.pcbFotografiaEmpleado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pcbFotografiaEmpleado.Location = New System.Drawing.Point(2, 28)
        Me.pcbFotografiaEmpleado.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pcbFotografiaEmpleado.Name = "pcbFotografiaEmpleado"
        Me.pcbFotografiaEmpleado.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pcbFotografiaEmpleado.Properties.ReadOnly = True
        Me.pcbFotografiaEmpleado.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.pcbFotografiaEmpleado.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.pcbFotografiaEmpleado.Size = New System.Drawing.Size(157, 157)
        Me.pcbFotografiaEmpleado.TabIndex = 44
        '
        'txtNumLibreta
        '
        Me.txtNumLibreta.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtNumLibreta.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtNumLibreta.AltodelControl = 30
        Me.txtNumLibreta.AnchoLabel = 120
        Me.txtNumLibreta.AutoSize = True
        Me.txtNumLibreta.ColordeFondo = System.Drawing.Color.Transparent
        Me.txtNumLibreta.EsObligatorio = False
        Me.txtNumLibreta.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumLibreta.FormatoNumero = Nothing
        Me.txtNumLibreta.Location = New System.Drawing.Point(0, 425)
        Me.txtNumLibreta.Margin = New System.Windows.Forms.Padding(5)
        Me.txtNumLibreta.MaximoAncho = 0
        Me.txtNumLibreta.MensajedeAyuda = Nothing
        Me.txtNumLibreta.Name = "txtNumLibreta"
        Me.txtNumLibreta.Size = New System.Drawing.Size(289, 37)
        Me.txtNumLibreta.SoloLectura = False
        Me.txtNumLibreta.SoloNumeros = False
        Me.txtNumLibreta.TabIndex = 5
        Me.txtNumLibreta.TextodelControl = ""
        Me.txtNumLibreta.TextoLabel = "Num. Libreta :"
        Me.txtNumLibreta.TieneErrorControl = False
        Me.txtNumLibreta.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtNumLibreta.TipodeLetra = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumLibreta.ValordelControl = Nothing
        Me.txtNumLibreta.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumLibreta.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumLibreta.ValorPredeterminado = Nothing
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.lblDocEmpleado)
        Me.Panel3.Controls.Add(Me.txtDigitoV)
        Me.Panel3.Controls.Add(Me.txtDocEmpleado)
        Me.Panel3.Controls.Add(Me.lblDigitoVer)
        Me.Panel3.Controls.Add(Me.btnBuscarEmp)
        Me.Panel3.Location = New System.Drawing.Point(2, 2)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(525, 48)
        Me.Panel3.TabIndex = 1
        '
        'lblDocEmpleado
        '
        Me.lblDocEmpleado.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lblDocEmpleado.Appearance.Options.UseFont = True
        Me.lblDocEmpleado.Appearance.Options.UseTextOptions = True
        Me.lblDocEmpleado.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblDocEmpleado.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblDocEmpleado.Location = New System.Drawing.Point(3, 12)
        Me.lblDocEmpleado.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblDocEmpleado.Name = "lblDocEmpleado"
        Me.lblDocEmpleado.Padding = New System.Windows.Forms.Padding(2)
        Me.lblDocEmpleado.Size = New System.Drawing.Size(135, 26)
        Me.lblDocEmpleado.TabIndex = 5
        Me.lblDocEmpleado.Text = "N° Documento :"
        '
        'txtDigitoV
        '
        Me.txtDigitoV.Location = New System.Drawing.Point(331, 11)
        Me.txtDigitoV.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDigitoV.Name = "txtDigitoV"
        Me.txtDigitoV.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.txtDigitoV.Properties.Appearance.Options.UseFont = True
        Me.txtDigitoV.Size = New System.Drawing.Size(61, 24)
        Me.txtDigitoV.TabIndex = 2
        '
        'txtDocEmpleado
        '
        Me.txtDocEmpleado.Location = New System.Drawing.Point(146, 11)
        Me.txtDocEmpleado.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDocEmpleado.Name = "txtDocEmpleado"
        Me.txtDocEmpleado.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.txtDocEmpleado.Properties.Appearance.Options.UseFont = True
        Me.txtDocEmpleado.Size = New System.Drawing.Size(132, 24)
        Me.txtDocEmpleado.TabIndex = 1
        '
        'lblDigitoVer
        '
        Me.lblDigitoVer.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lblDigitoVer.Appearance.Options.UseFont = True
        Me.lblDigitoVer.Appearance.Options.UseTextOptions = True
        Me.lblDigitoVer.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblDigitoVer.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblDigitoVer.Location = New System.Drawing.Point(292, 7)
        Me.lblDigitoVer.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblDigitoVer.Name = "lblDigitoVer"
        Me.lblDigitoVer.Padding = New System.Windows.Forms.Padding(2)
        Me.lblDigitoVer.Size = New System.Drawing.Size(34, 32)
        Me.lblDigitoVer.TabIndex = 10
        Me.lblDigitoVer.Text = "DV :"
        '
        'btnBuscarEmp
        '
        Me.btnBuscarEmp.AllowFocus = False
        Me.btnBuscarEmp.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarEmp.Appearance.Options.UseFont = True
        Me.btnBuscarEmp.ImageOptions.Image = CType(resources.GetObject("btnBuscarEmp.ImageOptions.Image"), System.Drawing.Image)
        Me.btnBuscarEmp.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnBuscarEmp.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnBuscarEmp.Location = New System.Drawing.Point(399, 2)
        Me.btnBuscarEmp.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnBuscarEmp.Name = "btnBuscarEmp"
        Me.btnBuscarEmp.Size = New System.Drawing.Size(128, 42)
        Me.btnBuscarEmp.TabIndex = 66
        Me.btnBuscarEmp.Text = "Buscar"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.lcDatos)
        Me.Panel1.Controls.Add(Me.grTipoCuenta)
        Me.Panel1.Controls.Add(Me.txtTipoDoc)
        Me.Panel1.Controls.Add(Me.txtEstadoCivil)
        Me.Panel1.Controls.Add(Me.txtWebPage)
        Me.Panel1.Controls.Add(Me.txtProfesion)
        Me.Panel1.Controls.Add(Me.txtEmail1)
        Me.Panel1.Controls.Add(Me.txtEmail2)
        Me.Panel1.Controls.Add(Me.txtGenero)
        Me.Panel1.Controls.Add(Me.txtBanco)
        Me.Panel1.Controls.Add(Me.txtNumCuenta)
        Me.Panel1.Location = New System.Drawing.Point(2, 54)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(525, 507)
        Me.Panel1.TabIndex = 78
        '
        'lcDatos
        '
        Me.lcDatos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lcDatos.Controls.Add(Me.txtPrimerNombre)
        Me.lcDatos.Controls.Add(Me.txtSegNombre)
        Me.lcDatos.Controls.Add(Me.txtPrimerApell)
        Me.lcDatos.Controls.Add(Me.txtSegApell)
        Me.lcDatos.Controls.Add(Me.txtTel1)
        Me.lcDatos.Controls.Add(Me.txtTel2)
        Me.lcDatos.Controls.Add(Me.txtCelular)
        Me.lcDatos.Controls.Add(Me.ndPersonaAcargo)
        Me.lcDatos.Controls.Add(Me.lblPersonasAcargo)
        Me.lcDatos.Location = New System.Drawing.Point(3, 37)
        Me.lcDatos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lcDatos.Name = "lcDatos"
        Me.lcDatos.OptionsView.UseDefaultDragAndDropRendering = False
        Me.lcDatos.Root = Me.lcgDatos
        Me.lcDatos.Size = New System.Drawing.Size(528, 151)
        Me.lcDatos.TabIndex = 2
        Me.lcDatos.Text = "LayoutControl1"
        '
        'txtPrimerNombre
        '
        Me.txtPrimerNombre.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtPrimerNombre.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtPrimerNombre.AltodelControl = 30
        Me.txtPrimerNombre.AnchoLabel = 120
        Me.txtPrimerNombre.ColordeFondo = System.Drawing.Color.Transparent
        Me.txtPrimerNombre.EsObligatorio = False
        Me.txtPrimerNombre.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrimerNombre.FormatoNumero = Nothing
        Me.txtPrimerNombre.Location = New System.Drawing.Point(0, 0)
        Me.txtPrimerNombre.Margin = New System.Windows.Forms.Padding(5)
        Me.txtPrimerNombre.MaximoAncho = 0
        Me.txtPrimerNombre.MensajedeAyuda = ""
        Me.txtPrimerNombre.Name = "txtPrimerNombre"
        Me.txtPrimerNombre.Size = New System.Drawing.Size(264, 37)
        Me.txtPrimerNombre.SoloLectura = False
        Me.txtPrimerNombre.SoloNumeros = False
        Me.txtPrimerNombre.TabIndex = 1
        Me.txtPrimerNombre.TextodelControl = ""
        Me.txtPrimerNombre.TextoLabel = "Primer Nombre :"
        Me.txtPrimerNombre.TieneErrorControl = False
        Me.txtPrimerNombre.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtPrimerNombre.TipodeLetra = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrimerNombre.ValordelControl = Nothing
        Me.txtPrimerNombre.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPrimerNombre.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPrimerNombre.ValorPredeterminado = Nothing
        '
        'txtSegNombre
        '
        Me.txtSegNombre.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtSegNombre.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtSegNombre.AltodelControl = 30
        Me.txtSegNombre.AnchoLabel = 120
        Me.txtSegNombre.ColordeFondo = System.Drawing.Color.Transparent
        Me.txtSegNombre.EsObligatorio = False
        Me.txtSegNombre.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSegNombre.FormatoNumero = Nothing
        Me.txtSegNombre.Location = New System.Drawing.Point(264, 0)
        Me.txtSegNombre.Margin = New System.Windows.Forms.Padding(5)
        Me.txtSegNombre.MaximoAncho = 0
        Me.txtSegNombre.MensajedeAyuda = ""
        Me.txtSegNombre.Name = "txtSegNombre"
        Me.txtSegNombre.Size = New System.Drawing.Size(264, 37)
        Me.txtSegNombre.SoloLectura = False
        Me.txtSegNombre.SoloNumeros = False
        Me.txtSegNombre.TabIndex = 2
        Me.txtSegNombre.TextodelControl = ""
        Me.txtSegNombre.TextoLabel = "Seg. Nombre :"
        Me.txtSegNombre.TieneErrorControl = False
        Me.txtSegNombre.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtSegNombre.TipodeLetra = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSegNombre.ValordelControl = Nothing
        Me.txtSegNombre.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtSegNombre.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtSegNombre.ValorPredeterminado = Nothing
        '
        'txtPrimerApell
        '
        Me.txtPrimerApell.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtPrimerApell.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtPrimerApell.AltodelControl = 30
        Me.txtPrimerApell.AnchoLabel = 120
        Me.txtPrimerApell.ColordeFondo = System.Drawing.Color.Transparent
        Me.txtPrimerApell.EsObligatorio = False
        Me.txtPrimerApell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrimerApell.FormatoNumero = Nothing
        Me.txtPrimerApell.Location = New System.Drawing.Point(0, 37)
        Me.txtPrimerApell.Margin = New System.Windows.Forms.Padding(5)
        Me.txtPrimerApell.MaximoAncho = 0
        Me.txtPrimerApell.MensajedeAyuda = ""
        Me.txtPrimerApell.Name = "txtPrimerApell"
        Me.txtPrimerApell.Size = New System.Drawing.Size(264, 37)
        Me.txtPrimerApell.SoloLectura = False
        Me.txtPrimerApell.SoloNumeros = False
        Me.txtPrimerApell.TabIndex = 3
        Me.txtPrimerApell.TextodelControl = ""
        Me.txtPrimerApell.TextoLabel = "Primer Apellido :"
        Me.txtPrimerApell.TieneErrorControl = False
        Me.txtPrimerApell.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtPrimerApell.TipodeLetra = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrimerApell.ValordelControl = Nothing
        Me.txtPrimerApell.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPrimerApell.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPrimerApell.ValorPredeterminado = Nothing
        '
        'txtSegApell
        '
        Me.txtSegApell.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtSegApell.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtSegApell.AltodelControl = 30
        Me.txtSegApell.AnchoLabel = 120
        Me.txtSegApell.ColordeFondo = System.Drawing.Color.Transparent
        Me.txtSegApell.EsObligatorio = False
        Me.txtSegApell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSegApell.FormatoNumero = Nothing
        Me.txtSegApell.Location = New System.Drawing.Point(264, 37)
        Me.txtSegApell.Margin = New System.Windows.Forms.Padding(5)
        Me.txtSegApell.MaximoAncho = 0
        Me.txtSegApell.MensajedeAyuda = ""
        Me.txtSegApell.Name = "txtSegApell"
        Me.txtSegApell.Size = New System.Drawing.Size(264, 37)
        Me.txtSegApell.SoloLectura = False
        Me.txtSegApell.SoloNumeros = False
        Me.txtSegApell.TabIndex = 4
        Me.txtSegApell.TextodelControl = ""
        Me.txtSegApell.TextoLabel = "Seg. Apellido :"
        Me.txtSegApell.TieneErrorControl = False
        Me.txtSegApell.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtSegApell.TipodeLetra = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSegApell.ValordelControl = Nothing
        Me.txtSegApell.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtSegApell.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtSegApell.ValorPredeterminado = Nothing
        '
        'txtTel1
        '
        Me.txtTel1.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtTel1.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtTel1.AltodelControl = 30
        Me.txtTel1.AnchoLabel = 120
        Me.txtTel1.ColordeFondo = System.Drawing.Color.Transparent
        Me.txtTel1.EsObligatorio = False
        Me.txtTel1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTel1.FormatoNumero = Nothing
        Me.txtTel1.Location = New System.Drawing.Point(0, 74)
        Me.txtTel1.Margin = New System.Windows.Forms.Padding(5)
        Me.txtTel1.MaximoAncho = 0
        Me.txtTel1.MensajedeAyuda = ""
        Me.txtTel1.Name = "txtTel1"
        Me.txtTel1.Size = New System.Drawing.Size(264, 37)
        Me.txtTel1.SoloLectura = False
        Me.txtTel1.SoloNumeros = False
        Me.txtTel1.TabIndex = 5
        Me.txtTel1.TextodelControl = ""
        Me.txtTel1.TextoLabel = "Teléfono 1 :"
        Me.txtTel1.TieneErrorControl = False
        Me.txtTel1.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtTel1.TipodeLetra = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTel1.ValordelControl = Nothing
        Me.txtTel1.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTel1.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTel1.ValorPredeterminado = Nothing
        '
        'txtTel2
        '
        Me.txtTel2.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtTel2.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtTel2.AltodelControl = 30
        Me.txtTel2.AnchoLabel = 120
        Me.txtTel2.ColordeFondo = System.Drawing.Color.Transparent
        Me.txtTel2.EsObligatorio = False
        Me.txtTel2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTel2.FormatoNumero = Nothing
        Me.txtTel2.Location = New System.Drawing.Point(264, 74)
        Me.txtTel2.Margin = New System.Windows.Forms.Padding(5)
        Me.txtTel2.MaximoAncho = 0
        Me.txtTel2.MensajedeAyuda = ""
        Me.txtTel2.Name = "txtTel2"
        Me.txtTel2.Size = New System.Drawing.Size(264, 37)
        Me.txtTel2.SoloLectura = False
        Me.txtTel2.SoloNumeros = False
        Me.txtTel2.TabIndex = 6
        Me.txtTel2.TextodelControl = ""
        Me.txtTel2.TextoLabel = "Teléfono 2 :"
        Me.txtTel2.TieneErrorControl = False
        Me.txtTel2.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtTel2.TipodeLetra = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTel2.ValordelControl = Nothing
        Me.txtTel2.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTel2.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTel2.ValorPredeterminado = Nothing
        '
        'txtCelular
        '
        Me.txtCelular.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtCelular.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtCelular.AltodelControl = 30
        Me.txtCelular.AnchoLabel = 120
        Me.txtCelular.ColordeFondo = System.Drawing.Color.Transparent
        Me.txtCelular.EsObligatorio = False
        Me.txtCelular.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCelular.FormatoNumero = Nothing
        Me.txtCelular.Location = New System.Drawing.Point(0, 111)
        Me.txtCelular.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCelular.MaximoAncho = 0
        Me.txtCelular.MensajedeAyuda = ""
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(264, 40)
        Me.txtCelular.SoloLectura = False
        Me.txtCelular.SoloNumeros = False
        Me.txtCelular.TabIndex = 7
        Me.txtCelular.TextodelControl = ""
        Me.txtCelular.TextoLabel = "Celular :"
        Me.txtCelular.TieneErrorControl = False
        Me.txtCelular.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtCelular.TipodeLetra = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCelular.ValordelControl = Nothing
        Me.txtCelular.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCelular.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCelular.ValorPredeterminado = Nothing
        '
        'ndPersonaAcargo
        '
        Me.ndPersonaAcargo.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ndPersonaAcargo.Location = New System.Drawing.Point(398, 117)
        Me.ndPersonaAcargo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ndPersonaAcargo.Name = "ndPersonaAcargo"
        Me.ndPersonaAcargo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.ndPersonaAcargo.Properties.Appearance.Options.UseFont = True
        Me.ndPersonaAcargo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ndPersonaAcargo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ndPersonaAcargo.Size = New System.Drawing.Size(124, 24)
        Me.ndPersonaAcargo.StyleController = Me.lcDatos
        Me.ndPersonaAcargo.TabIndex = 8
        '
        'lblPersonasAcargo
        '
        Me.lblPersonasAcargo.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lblPersonasAcargo.Appearance.Options.UseFont = True
        Me.lblPersonasAcargo.Appearance.Options.UseTextOptions = True
        Me.lblPersonasAcargo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblPersonasAcargo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lblPersonasAcargo.Location = New System.Drawing.Point(266, 113)
        Me.lblPersonasAcargo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblPersonasAcargo.Name = "lblPersonasAcargo"
        Me.lblPersonasAcargo.Padding = New System.Windows.Forms.Padding(2)
        Me.lblPersonasAcargo.Size = New System.Drawing.Size(128, 36)
        Me.lblPersonasAcargo.StyleController = Me.lcDatos
        Me.lblPersonasAcargo.TabIndex = 51
        Me.lblPersonasAcargo.Text = "Personas a Cargo :"
        '
        'lcgDatos
        '
        Me.lcgDatos.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.lcgDatos.GroupBordersVisible = False
        Me.lcgDatos.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lciTxtPnombre, Me.lciTxtSnombre, Me.lciTxtPapellido, Me.lciSapellido, Me.lciTxtTel1, Me.lciTxtTel2, Me.lciTxtCel, Me.lciNdPerAcargo, Me.lciLblPersonasAcargo})
        Me.lcgDatos.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table
        Me.lcgDatos.Name = "lcgDatos"
        ColumnDefinition1.SizeType = System.Windows.Forms.SizeType.Percent
        ColumnDefinition1.Width = 50.0R
        ColumnDefinition2.SizeType = System.Windows.Forms.SizeType.Percent
        ColumnDefinition2.Width = 25.0R
        ColumnDefinition3.SizeType = System.Windows.Forms.SizeType.Percent
        ColumnDefinition3.Width = 25.0R
        Me.lcgDatos.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(New DevExpress.XtraLayout.ColumnDefinition() {ColumnDefinition1, ColumnDefinition2, ColumnDefinition3})
        RowDefinition1.Height = 37.0R
        RowDefinition1.SizeType = System.Windows.Forms.SizeType.Absolute
        RowDefinition2.Height = 37.0R
        RowDefinition2.SizeType = System.Windows.Forms.SizeType.Absolute
        RowDefinition3.Height = 37.0R
        RowDefinition3.SizeType = System.Windows.Forms.SizeType.Absolute
        RowDefinition4.Height = 37.0R
        RowDefinition4.SizeType = System.Windows.Forms.SizeType.Absolute
        Me.lcgDatos.OptionsTableLayoutGroup.RowDefinitions.AddRange(New DevExpress.XtraLayout.RowDefinition() {RowDefinition1, RowDefinition2, RowDefinition3, RowDefinition4})
        Me.lcgDatos.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.lcgDatos.Size = New System.Drawing.Size(528, 151)
        Me.lcgDatos.TextVisible = False
        '
        'lciTxtPnombre
        '
        Me.lciTxtPnombre.Control = Me.txtPrimerNombre
        Me.lciTxtPnombre.Location = New System.Drawing.Point(0, 0)
        Me.lciTxtPnombre.Name = "lciTxtPnombre"
        Me.lciTxtPnombre.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.lciTxtPnombre.Size = New System.Drawing.Size(264, 37)
        Me.lciTxtPnombre.TextSize = New System.Drawing.Size(0, 0)
        Me.lciTxtPnombre.TextVisible = False
        '
        'lciTxtSnombre
        '
        Me.lciTxtSnombre.Control = Me.txtSegNombre
        Me.lciTxtSnombre.Location = New System.Drawing.Point(264, 0)
        Me.lciTxtSnombre.Name = "lciTxtSnombre"
        Me.lciTxtSnombre.OptionsTableLayoutItem.ColumnIndex = 1
        Me.lciTxtSnombre.OptionsTableLayoutItem.ColumnSpan = 2
        Me.lciTxtSnombre.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.lciTxtSnombre.Size = New System.Drawing.Size(264, 37)
        Me.lciTxtSnombre.TextSize = New System.Drawing.Size(0, 0)
        Me.lciTxtSnombre.TextVisible = False
        '
        'lciTxtPapellido
        '
        Me.lciTxtPapellido.Control = Me.txtPrimerApell
        Me.lciTxtPapellido.Location = New System.Drawing.Point(0, 37)
        Me.lciTxtPapellido.Name = "lciTxtPapellido"
        Me.lciTxtPapellido.OptionsTableLayoutItem.RowIndex = 1
        Me.lciTxtPapellido.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.lciTxtPapellido.Size = New System.Drawing.Size(264, 37)
        Me.lciTxtPapellido.TextSize = New System.Drawing.Size(0, 0)
        Me.lciTxtPapellido.TextVisible = False
        '
        'lciSapellido
        '
        Me.lciSapellido.Control = Me.txtSegApell
        Me.lciSapellido.Location = New System.Drawing.Point(264, 37)
        Me.lciSapellido.Name = "lciSapellido"
        Me.lciSapellido.OptionsTableLayoutItem.ColumnIndex = 1
        Me.lciSapellido.OptionsTableLayoutItem.ColumnSpan = 2
        Me.lciSapellido.OptionsTableLayoutItem.RowIndex = 1
        Me.lciSapellido.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.lciSapellido.Size = New System.Drawing.Size(264, 37)
        Me.lciSapellido.TextSize = New System.Drawing.Size(0, 0)
        Me.lciSapellido.TextVisible = False
        '
        'lciTxtTel1
        '
        Me.lciTxtTel1.Control = Me.txtTel1
        Me.lciTxtTel1.Location = New System.Drawing.Point(0, 74)
        Me.lciTxtTel1.Name = "lciTxtTel1"
        Me.lciTxtTel1.OptionsTableLayoutItem.RowIndex = 2
        Me.lciTxtTel1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.lciTxtTel1.Size = New System.Drawing.Size(264, 37)
        Me.lciTxtTel1.TextSize = New System.Drawing.Size(0, 0)
        Me.lciTxtTel1.TextVisible = False
        '
        'lciTxtTel2
        '
        Me.lciTxtTel2.Control = Me.txtTel2
        Me.lciTxtTel2.Location = New System.Drawing.Point(264, 74)
        Me.lciTxtTel2.Name = "lciTxtTel2"
        Me.lciTxtTel2.OptionsTableLayoutItem.ColumnIndex = 1
        Me.lciTxtTel2.OptionsTableLayoutItem.ColumnSpan = 2
        Me.lciTxtTel2.OptionsTableLayoutItem.RowIndex = 2
        Me.lciTxtTel2.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.lciTxtTel2.Size = New System.Drawing.Size(264, 37)
        Me.lciTxtTel2.TextSize = New System.Drawing.Size(0, 0)
        Me.lciTxtTel2.TextVisible = False
        '
        'lciTxtCel
        '
        Me.lciTxtCel.Control = Me.txtCelular
        Me.lciTxtCel.Location = New System.Drawing.Point(0, 111)
        Me.lciTxtCel.Name = "lciTxtCel"
        Me.lciTxtCel.OptionsTableLayoutItem.RowIndex = 3
        Me.lciTxtCel.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.lciTxtCel.Size = New System.Drawing.Size(264, 40)
        Me.lciTxtCel.TextSize = New System.Drawing.Size(0, 0)
        Me.lciTxtCel.TextVisible = False
        '
        'lciNdPerAcargo
        '
        Me.lciNdPerAcargo.Control = Me.ndPersonaAcargo
        Me.lciNdPerAcargo.Location = New System.Drawing.Point(396, 111)
        Me.lciNdPerAcargo.Name = "lciNdPerAcargo"
        Me.lciNdPerAcargo.OptionsTableLayoutItem.ColumnIndex = 2
        Me.lciNdPerAcargo.OptionsTableLayoutItem.RowIndex = 3
        Me.lciNdPerAcargo.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 6, 6, 0)
        Me.lciNdPerAcargo.Size = New System.Drawing.Size(132, 40)
        Me.lciNdPerAcargo.TextSize = New System.Drawing.Size(0, 0)
        Me.lciNdPerAcargo.TextVisible = False
        '
        'lciLblPersonasAcargo
        '
        Me.lciLblPersonasAcargo.Control = Me.lblPersonasAcargo
        Me.lciLblPersonasAcargo.Location = New System.Drawing.Point(264, 111)
        Me.lciLblPersonasAcargo.Name = "lciLblPersonasAcargo"
        Me.lciLblPersonasAcargo.OptionsTableLayoutItem.ColumnIndex = 1
        Me.lciLblPersonasAcargo.OptionsTableLayoutItem.RowIndex = 3
        Me.lciLblPersonasAcargo.Size = New System.Drawing.Size(132, 40)
        Me.lciLblPersonasAcargo.TextSize = New System.Drawing.Size(0, 0)
        Me.lciLblPersonasAcargo.TextVisible = False
        '
        'grTipoCuenta
        '
        Me.grTipoCuenta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grTipoCuenta.EditValue = CType(0, Byte)
        Me.grTipoCuenta.Location = New System.Drawing.Point(287, 335)
        Me.grTipoCuenta.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grTipoCuenta.Name = "grTipoCuenta"
        Me.grTipoCuenta.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.grTipoCuenta.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.grTipoCuenta.Properties.Appearance.Options.UseBackColor = True
        Me.grTipoCuenta.Properties.Appearance.Options.UseFont = True
        Me.grTipoCuenta.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.grTipoCuenta.Properties.Columns = 3
        Me.grTipoCuenta.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.grTipoCuenta.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(0, Byte), "N/A"), New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(1, Byte), "Ahorro"), New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(2, Byte), "Corriente")})
        Me.grTipoCuenta.Size = New System.Drawing.Size(232, 32)
        Me.grTipoCuenta.TabIndex = 8
        '
        'txtTipoDoc
        '
        Me.txtTipoDoc.AlineacionTexto = SamitCtlNet.AlinearTexto.Centro
        Me.txtTipoDoc.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtTipoDoc.AltodelControl = 30
        Me.txtTipoDoc.AnchoLabel = 120
        Me.txtTipoDoc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTipoDoc.AnchoTxt = 95
        Me.txtTipoDoc.AutoCargarDatos = True
        Me.txtTipoDoc.AutoSize = True
        Me.txtTipoDoc.BackColor = System.Drawing.Color.Transparent
        Me.txtTipoDoc.ColorFondo = System.Drawing.Color.Transparent
        Me.txtTipoDoc.CondicionValida = ""
        Me.txtTipoDoc.Conexion = SamitCtlNet.ConexionSAMIT.ConexSeguridad
        Me.txtTipoDoc.ConsultaSQL = ""
        Me.txtTipoDoc.DatosDefecto = Nothing
        Me.txtTipoDoc.EsObligatorio = False
        Me.txtTipoDoc.FormatoNumero = Nothing
        Me.txtTipoDoc.ListaColumnas = Nothing
        Me.txtTipoDoc.Location = New System.Drawing.Point(3, 1)
        Me.txtTipoDoc.Margin = New System.Windows.Forms.Padding(5)
        Me.txtTipoDoc.MaximoAncho = 0
        Me.txtTipoDoc.MensajedeAyuda = Nothing
        Me.txtTipoDoc.Name = "txtTipoDoc"
        Me.txtTipoDoc.Size = New System.Drawing.Size(528, 37)
        Me.txtTipoDoc.SoloLectura = False
        Me.txtTipoDoc.SoloNumeros = False
        Me.txtTipoDoc.TabIndex = 1
        Me.txtTipoDoc.TextodelControl = ""
        Me.txtTipoDoc.TextoLabel = "Tipo Doc :"
        Me.txtTipoDoc.TieneErrorControl = False
        Me.txtTipoDoc.TipoBusqueda = SamitCtlNet.ModGeneral.TipoBusqueda.Ninguna
        Me.txtTipoDoc.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtTipoDoc.TipodeLetra = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoDoc.ValordelControl = ""
        Me.txtTipoDoc.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTipoDoc.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTipoDoc.ValorPredeterminado = Nothing
        '
        'txtEstadoCivil
        '
        Me.txtEstadoCivil.AlineacionTexto = SamitCtlNet.AlinearTexto.Centro
        Me.txtEstadoCivil.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtEstadoCivil.AltodelControl = 30
        Me.txtEstadoCivil.AnchoLabel = 120
        Me.txtEstadoCivil.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEstadoCivil.AnchoTxt = 95
        Me.txtEstadoCivil.AutoCargarDatos = True
        Me.txtEstadoCivil.AutoSize = True
        Me.txtEstadoCivil.BackColor = System.Drawing.Color.Transparent
        Me.txtEstadoCivil.ColorFondo = System.Drawing.Color.Transparent
        Me.txtEstadoCivil.CondicionValida = ""
        Me.txtEstadoCivil.Conexion = SamitCtlNet.ConexionSAMIT.ConexSeguridad
        Me.txtEstadoCivil.ConsultaSQL = ""
        Me.txtEstadoCivil.DatosDefecto = Nothing
        Me.txtEstadoCivil.EsObligatorio = False
        Me.txtEstadoCivil.FormatoNumero = Nothing
        Me.txtEstadoCivil.ListaColumnas = Nothing
        Me.txtEstadoCivil.Location = New System.Drawing.Point(3, 443)
        Me.txtEstadoCivil.Margin = New System.Windows.Forms.Padding(5)
        Me.txtEstadoCivil.MaximoAncho = 0
        Me.txtEstadoCivil.MensajedeAyuda = Nothing
        Me.txtEstadoCivil.Name = "txtEstadoCivil"
        Me.txtEstadoCivil.Size = New System.Drawing.Size(517, 37)
        Me.txtEstadoCivil.SoloLectura = False
        Me.txtEstadoCivil.SoloNumeros = False
        Me.txtEstadoCivil.TabIndex = 11
        Me.txtEstadoCivil.TextodelControl = ""
        Me.txtEstadoCivil.TextoLabel = "Est. Civil :"
        Me.txtEstadoCivil.TieneErrorControl = False
        Me.txtEstadoCivil.TipoBusqueda = SamitCtlNet.ModGeneral.TipoBusqueda.Ninguna
        Me.txtEstadoCivil.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtEstadoCivil.TipodeLetra = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstadoCivil.ValordelControl = ""
        Me.txtEstadoCivil.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtEstadoCivil.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtEstadoCivil.ValorPredeterminado = Nothing
        '
        'txtWebPage
        '
        Me.txtWebPage.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtWebPage.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtWebPage.AltodelControl = 30
        Me.txtWebPage.AnchoLabel = 120
        Me.txtWebPage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtWebPage.AutoSize = True
        Me.txtWebPage.ColordeFondo = System.Drawing.Color.Transparent
        Me.txtWebPage.EsObligatorio = False
        Me.txtWebPage.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWebPage.FormatoNumero = Nothing
        Me.txtWebPage.Location = New System.Drawing.Point(3, 190)
        Me.txtWebPage.Margin = New System.Windows.Forms.Padding(5)
        Me.txtWebPage.MaximoAncho = 0
        Me.txtWebPage.MensajedeAyuda = ""
        Me.txtWebPage.Name = "txtWebPage"
        Me.txtWebPage.Size = New System.Drawing.Size(526, 37)
        Me.txtWebPage.SoloLectura = False
        Me.txtWebPage.SoloNumeros = False
        Me.txtWebPage.TabIndex = 3
        Me.txtWebPage.TextodelControl = ""
        Me.txtWebPage.TextoLabel = "WebPage :"
        Me.txtWebPage.TieneErrorControl = False
        Me.txtWebPage.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtWebPage.TipodeLetra = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWebPage.ValordelControl = Nothing
        Me.txtWebPage.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtWebPage.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtWebPage.ValorPredeterminado = Nothing
        '
        'txtProfesion
        '
        Me.txtProfesion.AlineacionTexto = SamitCtlNet.AlinearTexto.Centro
        Me.txtProfesion.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtProfesion.AltodelControl = 30
        Me.txtProfesion.AnchoLabel = 120
        Me.txtProfesion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtProfesion.AnchoTxt = 95
        Me.txtProfesion.AutoCargarDatos = True
        Me.txtProfesion.AutoSize = True
        Me.txtProfesion.BackColor = System.Drawing.Color.Transparent
        Me.txtProfesion.ColorFondo = System.Drawing.Color.Transparent
        Me.txtProfesion.CondicionValida = ""
        Me.txtProfesion.Conexion = SamitCtlNet.ConexionSAMIT.ConexSeguridad
        Me.txtProfesion.ConsultaSQL = ""
        Me.txtProfesion.DatosDefecto = Nothing
        Me.txtProfesion.EsObligatorio = False
        Me.txtProfesion.FormatoNumero = Nothing
        Me.txtProfesion.ListaColumnas = Nothing
        Me.txtProfesion.Location = New System.Drawing.Point(3, 404)
        Me.txtProfesion.Margin = New System.Windows.Forms.Padding(5)
        Me.txtProfesion.MaximoAncho = 0
        Me.txtProfesion.MensajedeAyuda = Nothing
        Me.txtProfesion.Name = "txtProfesion"
        Me.txtProfesion.Size = New System.Drawing.Size(516, 37)
        Me.txtProfesion.SoloLectura = False
        Me.txtProfesion.SoloNumeros = False
        Me.txtProfesion.TabIndex = 10
        Me.txtProfesion.TextodelControl = ""
        Me.txtProfesion.TextoLabel = "Profesión :"
        Me.txtProfesion.TieneErrorControl = False
        Me.txtProfesion.TipoBusqueda = SamitCtlNet.ModGeneral.TipoBusqueda.Ninguna
        Me.txtProfesion.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtProfesion.TipodeLetra = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProfesion.ValordelControl = ""
        Me.txtProfesion.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtProfesion.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtProfesion.ValorPredeterminado = Nothing
        '
        'txtEmail1
        '
        Me.txtEmail1.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtEmail1.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtEmail1.AltodelControl = 30
        Me.txtEmail1.AnchoLabel = 120
        Me.txtEmail1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEmail1.AutoSize = True
        Me.txtEmail1.ColordeFondo = System.Drawing.Color.Transparent
        Me.txtEmail1.EsObligatorio = False
        Me.txtEmail1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail1.FormatoNumero = Nothing
        Me.txtEmail1.Location = New System.Drawing.Point(3, 224)
        Me.txtEmail1.Margin = New System.Windows.Forms.Padding(5)
        Me.txtEmail1.MaximoAncho = 0
        Me.txtEmail1.MensajedeAyuda = ""
        Me.txtEmail1.Name = "txtEmail1"
        Me.txtEmail1.Size = New System.Drawing.Size(526, 37)
        Me.txtEmail1.SoloLectura = False
        Me.txtEmail1.SoloNumeros = False
        Me.txtEmail1.TabIndex = 4
        Me.txtEmail1.TextodelControl = ""
        Me.txtEmail1.TextoLabel = "Email 1 :"
        Me.txtEmail1.TieneErrorControl = False
        Me.txtEmail1.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtEmail1.TipodeLetra = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail1.ValordelControl = Nothing
        Me.txtEmail1.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtEmail1.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtEmail1.ValorPredeterminado = Nothing
        '
        'txtEmail2
        '
        Me.txtEmail2.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtEmail2.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtEmail2.AltodelControl = 30
        Me.txtEmail2.AnchoLabel = 120
        Me.txtEmail2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEmail2.AutoSize = True
        Me.txtEmail2.ColordeFondo = System.Drawing.Color.Transparent
        Me.txtEmail2.EsObligatorio = False
        Me.txtEmail2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail2.FormatoNumero = Nothing
        Me.txtEmail2.Location = New System.Drawing.Point(3, 260)
        Me.txtEmail2.Margin = New System.Windows.Forms.Padding(5)
        Me.txtEmail2.MaximoAncho = 0
        Me.txtEmail2.MensajedeAyuda = "Correo electrónico 2 del empleado. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
        Me.txtEmail2.Name = "txtEmail2"
        Me.txtEmail2.Size = New System.Drawing.Size(526, 37)
        Me.txtEmail2.SoloLectura = False
        Me.txtEmail2.SoloNumeros = False
        Me.txtEmail2.TabIndex = 5
        Me.txtEmail2.TextodelControl = ""
        Me.txtEmail2.TextoLabel = "Email 2 :"
        Me.txtEmail2.TieneErrorControl = False
        Me.txtEmail2.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtEmail2.TipodeLetra = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail2.ValordelControl = Nothing
        Me.txtEmail2.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtEmail2.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtEmail2.ValorPredeterminado = Nothing
        '
        'txtGenero
        '
        Me.txtGenero.AlineacionTexto = SamitCtlNet.AlinearTexto.Centro
        Me.txtGenero.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtGenero.AltodelControl = 30
        Me.txtGenero.AnchoLabel = 120
        Me.txtGenero.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtGenero.AnchoTxt = 95
        Me.txtGenero.AutoCargarDatos = True
        Me.txtGenero.AutoSize = True
        Me.txtGenero.BackColor = System.Drawing.Color.Transparent
        Me.txtGenero.ColorFondo = System.Drawing.Color.Transparent
        Me.txtGenero.CondicionValida = ""
        Me.txtGenero.Conexion = SamitCtlNet.ConexionSAMIT.ConexSeguridad
        Me.txtGenero.ConsultaSQL = ""
        Me.txtGenero.DatosDefecto = Nothing
        Me.txtGenero.EsObligatorio = False
        Me.txtGenero.FormatoNumero = Nothing
        Me.txtGenero.ListaColumnas = Nothing
        Me.txtGenero.Location = New System.Drawing.Point(3, 368)
        Me.txtGenero.Margin = New System.Windows.Forms.Padding(5)
        Me.txtGenero.MaximoAncho = 0
        Me.txtGenero.MensajedeAyuda = Nothing
        Me.txtGenero.Name = "txtGenero"
        Me.txtGenero.Size = New System.Drawing.Size(516, 37)
        Me.txtGenero.SoloLectura = False
        Me.txtGenero.SoloNumeros = False
        Me.txtGenero.TabIndex = 9
        Me.txtGenero.TextodelControl = ""
        Me.txtGenero.TextoLabel = "Genero :"
        Me.txtGenero.TieneErrorControl = False
        Me.txtGenero.TipoBusqueda = SamitCtlNet.ModGeneral.TipoBusqueda.Ninguna
        Me.txtGenero.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtGenero.TipodeLetra = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGenero.ValordelControl = ""
        Me.txtGenero.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtGenero.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtGenero.ValorPredeterminado = Nothing
        '
        'txtBanco
        '
        Me.txtBanco.AlineacionTexto = SamitCtlNet.AlinearTexto.Centro
        Me.txtBanco.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtBanco.AltodelControl = 30
        Me.txtBanco.AnchoLabel = 120
        Me.txtBanco.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBanco.AnchoTxt = 95
        Me.txtBanco.AutoCargarDatos = True
        Me.txtBanco.AutoSize = True
        Me.txtBanco.BackColor = System.Drawing.Color.Transparent
        Me.txtBanco.ColorFondo = System.Drawing.Color.Transparent
        Me.txtBanco.CondicionValida = ""
        Me.txtBanco.Conexion = SamitCtlNet.ConexionSAMIT.ConexModulo
        Me.txtBanco.ConsultaSQL = ""
        Me.txtBanco.DatosDefecto = Nothing
        Me.txtBanco.EsObligatorio = False
        Me.txtBanco.FormatoNumero = Nothing
        Me.txtBanco.ListaColumnas = Nothing
        Me.txtBanco.Location = New System.Drawing.Point(3, 295)
        Me.txtBanco.Margin = New System.Windows.Forms.Padding(5)
        Me.txtBanco.MaximoAncho = 0
        Me.txtBanco.MensajedeAyuda = Nothing
        Me.txtBanco.Name = "txtBanco"
        Me.txtBanco.Size = New System.Drawing.Size(517, 37)
        Me.txtBanco.SoloLectura = False
        Me.txtBanco.SoloNumeros = False
        Me.txtBanco.TabIndex = 6
        Me.txtBanco.TextodelControl = ""
        Me.txtBanco.TextoLabel = "Banco :"
        Me.txtBanco.TieneErrorControl = False
        Me.txtBanco.TipoBusqueda = SamitCtlNet.ModGeneral.TipoBusqueda.Ninguna
        Me.txtBanco.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtBanco.TipodeLetra = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBanco.ValordelControl = ""
        Me.txtBanco.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtBanco.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtBanco.ValorPredeterminado = Nothing
        '
        'txtNumCuenta
        '
        Me.txtNumCuenta.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtNumCuenta.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtNumCuenta.AltodelControl = 30
        Me.txtNumCuenta.AnchoLabel = 120
        Me.txtNumCuenta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNumCuenta.AutoSize = True
        Me.txtNumCuenta.ColordeFondo = System.Drawing.Color.Transparent
        Me.txtNumCuenta.EsObligatorio = False
        Me.txtNumCuenta.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumCuenta.FormatoNumero = Nothing
        Me.txtNumCuenta.Location = New System.Drawing.Point(3, 335)
        Me.txtNumCuenta.Margin = New System.Windows.Forms.Padding(5)
        Me.txtNumCuenta.MaximoAncho = 0
        Me.txtNumCuenta.MensajedeAyuda = ""
        Me.txtNumCuenta.Name = "txtNumCuenta"
        Me.txtNumCuenta.Size = New System.Drawing.Size(276, 37)
        Me.txtNumCuenta.SoloLectura = False
        Me.txtNumCuenta.SoloNumeros = False
        Me.txtNumCuenta.TabIndex = 7
        Me.txtNumCuenta.TextodelControl = ""
        Me.txtNumCuenta.TextoLabel = "Num. Cuenta :"
        Me.txtNumCuenta.TieneErrorControl = False
        Me.txtNumCuenta.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtNumCuenta.TipodeLetra = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumCuenta.ValordelControl = Nothing
        Me.txtNumCuenta.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumCuenta.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumCuenta.ValorPredeterminado = Nothing
        '
        'lcgPrincipalDatosBasicos
        '
        Me.lcgPrincipalDatosBasicos.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.lcgPrincipalDatosBasicos.GroupBordersVisible = False
        Me.lcgPrincipalDatosBasicos.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lciNumDocDVbtnBuscar, Me.lciDatosBasicosIzq, Me.lciDatsoBasicosDer})
        Me.lcgPrincipalDatosBasicos.Name = "lcgPrincipalDatosBasicos"
        Me.lcgPrincipalDatosBasicos.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.lcgPrincipalDatosBasicos.Size = New System.Drawing.Size(1090, 566)
        Me.lcgPrincipalDatosBasicos.TextVisible = False
        '
        'lciNumDocDVbtnBuscar
        '
        Me.lciNumDocDVbtnBuscar.Control = Me.Panel3
        Me.lciNumDocDVbtnBuscar.Location = New System.Drawing.Point(0, 0)
        Me.lciNumDocDVbtnBuscar.MaxSize = New System.Drawing.Size(0, 52)
        Me.lciNumDocDVbtnBuscar.MinSize = New System.Drawing.Size(121, 52)
        Me.lciNumDocDVbtnBuscar.Name = "lciNumDocDVbtnBuscar"
        Me.lciNumDocDVbtnBuscar.Size = New System.Drawing.Size(529, 52)
        Me.lciNumDocDVbtnBuscar.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.lciNumDocDVbtnBuscar.TextSize = New System.Drawing.Size(0, 0)
        Me.lciNumDocDVbtnBuscar.TextVisible = False
        '
        'lciDatosBasicosIzq
        '
        Me.lciDatosBasicosIzq.Control = Me.Panel1
        Me.lciDatosBasicosIzq.Location = New System.Drawing.Point(0, 52)
        Me.lciDatosBasicosIzq.MaxSize = New System.Drawing.Size(0, 511)
        Me.lciDatosBasicosIzq.MinSize = New System.Drawing.Size(121, 511)
        Me.lciDatosBasicosIzq.Name = "lciDatosBasicosIzq"
        Me.lciDatosBasicosIzq.Size = New System.Drawing.Size(529, 514)
        Me.lciDatosBasicosIzq.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.lciDatosBasicosIzq.TextSize = New System.Drawing.Size(0, 0)
        Me.lciDatosBasicosIzq.TextVisible = False
        '
        'lciDatsoBasicosDer
        '
        Me.lciDatsoBasicosDer.Control = Me.Panel2
        Me.lciDatsoBasicosDer.Location = New System.Drawing.Point(529, 0)
        Me.lciDatsoBasicosDer.MaxSize = New System.Drawing.Size(0, 562)
        Me.lciDatsoBasicosDer.MinSize = New System.Drawing.Size(121, 562)
        Me.lciDatsoBasicosDer.Name = "lciDatsoBasicosDer"
        Me.lciDatsoBasicosDer.Size = New System.Drawing.Size(561, 566)
        Me.lciDatsoBasicosDer.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.lciDatsoBasicosDer.TextSize = New System.Drawing.Size(0, 0)
        Me.lciDatsoBasicosDer.TextVisible = False
        '
        'tpAfiliaciones
        '
        Me.tpAfiliaciones.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.tpAfiliaciones.Appearance.Header.Options.UseFont = True
        Me.tpAfiliaciones.Appearance.HeaderActive.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.tpAfiliaciones.Appearance.HeaderActive.Options.UseFont = True
        Me.tpAfiliaciones.Appearance.HeaderDisabled.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.tpAfiliaciones.Appearance.HeaderDisabled.Options.UseFont = True
        Me.tpAfiliaciones.Appearance.HeaderHotTracked.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.tpAfiliaciones.Appearance.HeaderHotTracked.Options.UseFont = True
        Me.tpAfiliaciones.Appearance.PageClient.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.tpAfiliaciones.Appearance.PageClient.Options.UseFont = True
        Me.tpAfiliaciones.Controls.Add(Me.gbxImagenesAfiliacion)
        Me.tpAfiliaciones.Controls.Add(Me.gbxInfAfiliaciones)
        Me.tpAfiliaciones.Controls.Add(Me.gbxGrillaAfiliaciones)
        Me.tpAfiliaciones.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tpAfiliaciones.Name = "tpAfiliaciones"
        Me.tpAfiliaciones.Size = New System.Drawing.Size(1090, 566)
        Me.tpAfiliaciones.Text = "&Afiliaciones"
        '
        'gbxImagenesAfiliacion
        '
        Me.gbxImagenesAfiliacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxImagenesAfiliacion.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.gbxImagenesAfiliacion.AppearanceCaption.Options.UseFont = True
        Me.gbxImagenesAfiliacion.Controls.Add(Me.GalleryControlAfiliaciones)
        Me.gbxImagenesAfiliacion.Location = New System.Drawing.Point(896, 10)
        Me.gbxImagenesAfiliacion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbxImagenesAfiliacion.Name = "gbxImagenesAfiliacion"
        Me.gbxImagenesAfiliacion.Size = New System.Drawing.Size(184, 549)
        Me.gbxImagenesAfiliacion.TabIndex = 21
        Me.gbxImagenesAfiliacion.Text = "Imagenes"
        '
        'GalleryControlAfiliaciones
        '
        Me.GalleryControlAfiliaciones.Controls.Add(Me.GalleryControlClient3)
        Me.GalleryControlAfiliaciones.Dock = System.Windows.Forms.DockStyle.Fill
        '
        '
        '
        Me.GalleryControlAfiliaciones.Gallery.ColumnCount = 1
        Me.GalleryControlAfiliaciones.Location = New System.Drawing.Point(2, 28)
        Me.GalleryControlAfiliaciones.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GalleryControlAfiliaciones.Name = "GalleryControlAfiliaciones"
        Me.GalleryControlAfiliaciones.Size = New System.Drawing.Size(180, 519)
        Me.GalleryControlAfiliaciones.TabIndex = 11
        Me.GalleryControlAfiliaciones.Text = "GalleryControl1"
        '
        'GalleryControlClient3
        '
        Me.GalleryControlClient3.GalleryControl = Me.GalleryControlAfiliaciones
        Me.GalleryControlClient3.Location = New System.Drawing.Point(2, 2)
        Me.GalleryControlClient3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GalleryControlClient3.Size = New System.Drawing.Size(155, 515)
        '
        'gbxInfAfiliaciones
        '
        Me.gbxInfAfiliaciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxInfAfiliaciones.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.gbxInfAfiliaciones.AppearanceCaption.Options.UseFont = True
        Me.gbxInfAfiliaciones.Controls.Add(Me.GroupControl1)
        Me.gbxInfAfiliaciones.Controls.Add(Me.txtEntidad)
        Me.gbxInfAfiliaciones.Controls.Add(Me.txtTipoEntidad)
        Me.gbxInfAfiliaciones.Controls.Add(Me.lblFechaRegistroEmpEntidad)
        Me.gbxInfAfiliaciones.Controls.Add(Me.dteFechaRegistroEmpEntidad)
        Me.gbxInfAfiliaciones.Controls.Add(Me.lblEmpRetiradoEntidad)
        Me.gbxInfAfiliaciones.Controls.Add(Me.rgbEmpRetiradoEntidad)
        Me.gbxInfAfiliaciones.Location = New System.Drawing.Point(9, 10)
        Me.gbxInfAfiliaciones.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbxInfAfiliaciones.Name = "gbxInfAfiliaciones"
        Me.gbxInfAfiliaciones.Size = New System.Drawing.Size(882, 146)
        Me.gbxInfAfiliaciones.TabIndex = 20
        Me.gbxInfAfiliaciones.Text = "Información Basica"
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.Controls.Add(Me.txtCausaRetiroEntidad)
        Me.GroupControl1.Location = New System.Drawing.Point(533, 32)
        Me.GroupControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(343, 108)
        Me.GroupControl1.TabIndex = 5
        Me.GroupControl1.Text = "Causa de Retiro "
        '
        'txtCausaRetiroEntidad
        '
        Me.txtCausaRetiroEntidad.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCausaRetiroEntidad.Location = New System.Drawing.Point(2, 28)
        Me.txtCausaRetiroEntidad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCausaRetiroEntidad.MenuManager = Me.BarManagerMenu
        Me.txtCausaRetiroEntidad.Name = "txtCausaRetiroEntidad"
        Me.txtCausaRetiroEntidad.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.txtCausaRetiroEntidad.Properties.Appearance.Options.UseFont = True
        Me.txtCausaRetiroEntidad.Size = New System.Drawing.Size(339, 78)
        Me.txtCausaRetiroEntidad.TabIndex = 3
        '
        'txtEntidad
        '
        Me.txtEntidad.AlineacionTexto = SamitCtlNet.AlinearTexto.Centro
        Me.txtEntidad.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtEntidad.AltodelControl = 30
        Me.txtEntidad.AnchoLabel = 120
        Me.txtEntidad.AnchoTxt = 80
        Me.txtEntidad.AutoCargarDatos = True
        Me.txtEntidad.AutoSize = True
        Me.txtEntidad.BackColor = System.Drawing.Color.Transparent
        Me.txtEntidad.ColorFondo = System.Drawing.Color.Transparent
        Me.txtEntidad.CondicionValida = ""
        Me.txtEntidad.Conexion = SamitCtlNet.ConexionSAMIT.ConexModulo
        Me.txtEntidad.ConsultaSQL = ""
        Me.txtEntidad.DatosDefecto = Nothing
        Me.txtEntidad.EsObligatorio = False
        Me.txtEntidad.FormatoNumero = Nothing
        Me.txtEntidad.ListaColumnas = Nothing
        Me.txtEntidad.Location = New System.Drawing.Point(2, 69)
        Me.txtEntidad.Margin = New System.Windows.Forms.Padding(5)
        Me.txtEntidad.MaximoAncho = 0
        Me.txtEntidad.MensajedeAyuda = Nothing
        Me.txtEntidad.Name = "txtEntidad"
        Me.txtEntidad.Size = New System.Drawing.Size(524, 37)
        Me.txtEntidad.SoloLectura = False
        Me.txtEntidad.SoloNumeros = False
        Me.txtEntidad.TabIndex = 2
        Me.txtEntidad.TextodelControl = ""
        Me.txtEntidad.TextoLabel = "Entidad :"
        Me.txtEntidad.TieneErrorControl = False
        Me.txtEntidad.TipoBusqueda = SamitCtlNet.ModGeneral.TipoBusqueda.Ninguna
        Me.txtEntidad.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtEntidad.TipodeLetra = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEntidad.ValordelControl = ""
        Me.txtEntidad.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtEntidad.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtEntidad.ValorPredeterminado = Nothing
        '
        'txtTipoEntidad
        '
        Me.txtTipoEntidad.AlineacionTexto = SamitCtlNet.AlinearTexto.Centro
        Me.txtTipoEntidad.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtTipoEntidad.AltodelControl = 30
        Me.txtTipoEntidad.AnchoLabel = 120
        Me.txtTipoEntidad.AnchoTxt = 80
        Me.txtTipoEntidad.AutoCargarDatos = True
        Me.txtTipoEntidad.AutoSize = True
        Me.txtTipoEntidad.BackColor = System.Drawing.Color.Transparent
        Me.txtTipoEntidad.ColorFondo = System.Drawing.Color.Transparent
        Me.txtTipoEntidad.CondicionValida = ""
        Me.txtTipoEntidad.Conexion = SamitCtlNet.ConexionSAMIT.ConexModulo
        Me.txtTipoEntidad.ConsultaSQL = ""
        Me.txtTipoEntidad.DatosDefecto = Nothing
        Me.txtTipoEntidad.EsObligatorio = False
        Me.txtTipoEntidad.FormatoNumero = Nothing
        Me.txtTipoEntidad.ListaColumnas = Nothing
        Me.txtTipoEntidad.Location = New System.Drawing.Point(2, 31)
        Me.txtTipoEntidad.Margin = New System.Windows.Forms.Padding(5)
        Me.txtTipoEntidad.MaximoAncho = 0
        Me.txtTipoEntidad.MensajedeAyuda = Nothing
        Me.txtTipoEntidad.Name = "txtTipoEntidad"
        Me.txtTipoEntidad.Size = New System.Drawing.Size(524, 37)
        Me.txtTipoEntidad.SoloLectura = False
        Me.txtTipoEntidad.SoloNumeros = False
        Me.txtTipoEntidad.TabIndex = 1
        Me.txtTipoEntidad.TextodelControl = ""
        Me.txtTipoEntidad.TextoLabel = "Tipo Entidad :"
        Me.txtTipoEntidad.TieneErrorControl = False
        Me.txtTipoEntidad.TipoBusqueda = SamitCtlNet.ModGeneral.TipoBusqueda.Ninguna
        Me.txtTipoEntidad.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtTipoEntidad.TipodeLetra = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoEntidad.ValordelControl = ""
        Me.txtTipoEntidad.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTipoEntidad.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTipoEntidad.ValorPredeterminado = Nothing
        '
        'lblFechaRegistroEmpEntidad
        '
        Me.lblFechaRegistroEmpEntidad.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaRegistroEmpEntidad.Appearance.Options.UseFont = True
        Me.lblFechaRegistroEmpEntidad.Appearance.Options.UseTextOptions = True
        Me.lblFechaRegistroEmpEntidad.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblFechaRegistroEmpEntidad.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblFechaRegistroEmpEntidad.Location = New System.Drawing.Point(5, 107)
        Me.lblFechaRegistroEmpEntidad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblFechaRegistroEmpEntidad.Name = "lblFechaRegistroEmpEntidad"
        Me.lblFechaRegistroEmpEntidad.Padding = New System.Windows.Forms.Padding(2)
        Me.lblFechaRegistroEmpEntidad.Size = New System.Drawing.Size(132, 32)
        Me.lblFechaRegistroEmpEntidad.TabIndex = 77
        Me.lblFechaRegistroEmpEntidad.Text = "Fecha Registro :"
        '
        'dteFechaRegistroEmpEntidad
        '
        Me.dteFechaRegistroEmpEntidad.EditValue = Nothing
        Me.dteFechaRegistroEmpEntidad.Location = New System.Drawing.Point(143, 113)
        Me.dteFechaRegistroEmpEntidad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dteFechaRegistroEmpEntidad.Name = "dteFechaRegistroEmpEntidad"
        Me.dteFechaRegistroEmpEntidad.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.dteFechaRegistroEmpEntidad.Properties.Appearance.Options.UseFont = True
        Me.dteFechaRegistroEmpEntidad.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.dteFechaRegistroEmpEntidad.Properties.AppearanceDropDown.Options.UseFont = True
        Me.dteFechaRegistroEmpEntidad.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteFechaRegistroEmpEntidad.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteFechaRegistroEmpEntidad.Properties.CloseUpKey = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.Right)
        Me.dteFechaRegistroEmpEntidad.Size = New System.Drawing.Size(127, 24)
        Me.dteFechaRegistroEmpEntidad.TabIndex = 3
        '
        'lblEmpRetiradoEntidad
        '
        Me.lblEmpRetiradoEntidad.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lblEmpRetiradoEntidad.Appearance.Options.UseFont = True
        Me.lblEmpRetiradoEntidad.Appearance.Options.UseTextOptions = True
        Me.lblEmpRetiradoEntidad.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblEmpRetiradoEntidad.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblEmpRetiradoEntidad.Location = New System.Drawing.Point(278, 108)
        Me.lblEmpRetiradoEntidad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblEmpRetiradoEntidad.Name = "lblEmpRetiradoEntidad"
        Me.lblEmpRetiradoEntidad.Padding = New System.Windows.Forms.Padding(2)
        Me.lblEmpRetiradoEntidad.Size = New System.Drawing.Size(127, 32)
        Me.lblEmpRetiradoEntidad.TabIndex = 75
        Me.lblEmpRetiradoEntidad.Text = "Rertirado :"
        '
        'rgbEmpRetiradoEntidad
        '
        Me.rgbEmpRetiradoEntidad.EditValue = False
        Me.rgbEmpRetiradoEntidad.Location = New System.Drawing.Point(412, 111)
        Me.rgbEmpRetiradoEntidad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rgbEmpRetiradoEntidad.Name = "rgbEmpRetiradoEntidad"
        Me.rgbEmpRetiradoEntidad.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.rgbEmpRetiradoEntidad.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.rgbEmpRetiradoEntidad.Properties.Appearance.Options.UseBackColor = True
        Me.rgbEmpRetiradoEntidad.Properties.Appearance.Options.UseFont = True
        Me.rgbEmpRetiradoEntidad.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.rgbEmpRetiradoEntidad.Properties.Columns = 2
        Me.rgbEmpRetiradoEntidad.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.rgbEmpRetiradoEntidad.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "NO"), New DevExpress.XtraEditors.Controls.RadioGroupItem(True, "SI")})
        Me.rgbEmpRetiradoEntidad.Size = New System.Drawing.Size(111, 28)
        Me.rgbEmpRetiradoEntidad.TabIndex = 4
        '
        'gbxGrillaAfiliaciones
        '
        Me.gbxGrillaAfiliaciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxGrillaAfiliaciones.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.gbxGrillaAfiliaciones.AppearanceCaption.Options.UseFont = True
        Me.gbxGrillaAfiliaciones.Controls.Add(Me.gcAfiliaciones)
        Me.gbxGrillaAfiliaciones.Location = New System.Drawing.Point(9, 164)
        Me.gbxGrillaAfiliaciones.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbxGrillaAfiliaciones.Name = "gbxGrillaAfiliaciones"
        Me.gbxGrillaAfiliaciones.Size = New System.Drawing.Size(882, 395)
        Me.gbxGrillaAfiliaciones.TabIndex = 19
        Me.gbxGrillaAfiliaciones.Text = "Afiliaciones del Empleado"
        '
        'gcAfiliaciones
        '
        Me.gcAfiliaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcAfiliaciones.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gcAfiliaciones.Location = New System.Drawing.Point(2, 28)
        Me.gcAfiliaciones.MainView = Me.gvAfilicaciones
        Me.gcAfiliaciones.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gcAfiliaciones.Name = "gcAfiliaciones"
        Me.gcAfiliaciones.Size = New System.Drawing.Size(878, 365)
        Me.gcAfiliaciones.TabIndex = 0
        Me.gcAfiliaciones.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvAfilicaciones})
        '
        'gvAfilicaciones
        '
        Me.gvAfilicaciones.DetailHeight = 431
        Me.gvAfilicaciones.GridControl = Me.gcAfiliaciones
        Me.gvAfilicaciones.Name = "gvAfilicaciones"
        '
        'tpFamiliares
        '
        Me.tpFamiliares.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.tpFamiliares.Appearance.Header.Options.UseFont = True
        Me.tpFamiliares.Appearance.HeaderActive.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.tpFamiliares.Appearance.HeaderActive.Options.UseFont = True
        Me.tpFamiliares.Appearance.HeaderDisabled.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.tpFamiliares.Appearance.HeaderDisabled.Options.UseFont = True
        Me.tpFamiliares.Appearance.HeaderHotTracked.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.tpFamiliares.Appearance.HeaderHotTracked.Options.UseFont = True
        Me.tpFamiliares.Appearance.PageClient.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.tpFamiliares.Appearance.PageClient.Options.UseFont = True
        Me.tpFamiliares.Controls.Add(Me.gbxImgFamiliar)
        Me.tpFamiliares.Controls.Add(Me.gbxGrillaFamiliares)
        Me.tpFamiliares.Controls.Add(Me.gbxInfFamiliar)
        Me.tpFamiliares.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tpFamiliares.Name = "tpFamiliares"
        Me.tpFamiliares.Size = New System.Drawing.Size(1090, 566)
        Me.tpFamiliares.Text = "&Familiares"
        '
        'gbxImgFamiliar
        '
        Me.gbxImgFamiliar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxImgFamiliar.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.gbxImgFamiliar.AppearanceCaption.Options.UseFont = True
        Me.gbxImgFamiliar.AppearanceCaption.Options.UseTextOptions = True
        Me.gbxImgFamiliar.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gbxImgFamiliar.Controls.Add(Me.pcbImgFamiliar)
        Me.gbxImgFamiliar.Location = New System.Drawing.Point(895, 10)
        Me.gbxImgFamiliar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbxImgFamiliar.Name = "gbxImgFamiliar"
        Me.gbxImgFamiliar.Size = New System.Drawing.Size(188, 238)
        Me.gbxImgFamiliar.TabIndex = 3
        Me.gbxImgFamiliar.Text = "Fotografía"
        '
        'pcbImgFamiliar
        '
        Me.pcbImgFamiliar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pcbImgFamiliar.Location = New System.Drawing.Point(2, 28)
        Me.pcbImgFamiliar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pcbImgFamiliar.MenuManager = Me.BarManagerMenu
        Me.pcbImgFamiliar.Name = "pcbImgFamiliar"
        Me.pcbImgFamiliar.Properties.ReadOnly = True
        Me.pcbImgFamiliar.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.pcbImgFamiliar.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.pcbImgFamiliar.Size = New System.Drawing.Size(184, 208)
        Me.pcbImgFamiliar.TabIndex = 0
        '
        'gbxGrillaFamiliares
        '
        Me.gbxGrillaFamiliares.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxGrillaFamiliares.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.gbxGrillaFamiliares.AppearanceCaption.Options.UseFont = True
        Me.gbxGrillaFamiliares.Controls.Add(Me.gcFamiliares)
        Me.gbxGrillaFamiliares.Location = New System.Drawing.Point(9, 252)
        Me.gbxGrillaFamiliares.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbxGrillaFamiliares.Name = "gbxGrillaFamiliares"
        Me.gbxGrillaFamiliares.Size = New System.Drawing.Size(1076, 462)
        Me.gbxGrillaFamiliares.TabIndex = 4
        Me.gbxGrillaFamiliares.Text = "Listado de Familiares"
        '
        'gcFamiliares
        '
        Me.gcFamiliares.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcFamiliares.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gcFamiliares.Location = New System.Drawing.Point(2, 28)
        Me.gcFamiliares.MainView = Me.gvFamiliares
        Me.gcFamiliares.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gcFamiliares.Name = "gcFamiliares"
        Me.gcFamiliares.Size = New System.Drawing.Size(1072, 432)
        Me.gcFamiliares.TabIndex = 0
        Me.gcFamiliares.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvFamiliares})
        '
        'gvFamiliares
        '
        Me.gvFamiliares.DetailHeight = 431
        Me.gvFamiliares.GridControl = Me.gcFamiliares
        Me.gvFamiliares.Name = "gvFamiliares"
        '
        'gbxInfFamiliar
        '
        Me.gbxInfFamiliar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxInfFamiliar.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.gbxInfFamiliar.AppearanceCaption.Options.UseFont = True
        Me.gbxInfFamiliar.Controls.Add(Me.lkeParentescoFamiliar)
        Me.gbxInfFamiliar.Controls.Add(Me.txtDirEmpTrabajaFamiliar)
        Me.gbxInfFamiliar.Controls.Add(Me.txtTelsEmpTrabajaFamiliar)
        Me.gbxInfFamiliar.Controls.Add(Me.txtCelFamiliar)
        Me.gbxInfFamiliar.Controls.Add(Me.txtCargoFamiliar)
        Me.gbxInfFamiliar.Controls.Add(Me.txtEmpresaTrabajaFamiliar)
        Me.gbxInfFamiliar.Controls.Add(Me.txtOcupacionFamiliar)
        Me.gbxInfFamiliar.Controls.Add(Me.lkeTipoDocFamiliar)
        Me.gbxInfFamiliar.Controls.Add(Me.lblParentescoFamiliar)
        Me.gbxInfFamiliar.Controls.Add(Me.lblFecNacFamiliar)
        Me.gbxInfFamiliar.Controls.Add(Me.dteFecNacFamiliar)
        Me.gbxInfFamiliar.Controls.Add(Me.lblTipoDocFamiliar)
        Me.gbxInfFamiliar.Controls.Add(Me.gbxUbicacionEmpTrabajaEmpleado)
        Me.gbxInfFamiliar.Controls.Add(Me.txtDocFamiliar)
        Me.gbxInfFamiliar.Controls.Add(Me.txtNombreFamiliar)
        Me.gbxInfFamiliar.Location = New System.Drawing.Point(9, 10)
        Me.gbxInfFamiliar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbxInfFamiliar.Name = "gbxInfFamiliar"
        Me.gbxInfFamiliar.Size = New System.Drawing.Size(881, 238)
        Me.gbxInfFamiliar.TabIndex = 1
        Me.gbxInfFamiliar.Text = "Información Basica"
        '
        'lkeParentescoFamiliar
        '
        Me.lkeParentescoFamiliar.Location = New System.Drawing.Point(149, 71)
        Me.lkeParentescoFamiliar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lkeParentescoFamiliar.Name = "lkeParentescoFamiliar"
        Me.lkeParentescoFamiliar.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.lkeParentescoFamiliar.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeParentescoFamiliar.Properties.Appearance.Options.UseFont = True
        Me.lkeParentescoFamiliar.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeParentescoFamiliar.Properties.AppearanceDisabled.Options.UseFont = True
        Me.lkeParentescoFamiliar.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeParentescoFamiliar.Properties.AppearanceDropDown.Options.UseFont = True
        Me.lkeParentescoFamiliar.Properties.AppearanceDropDownHeader.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeParentescoFamiliar.Properties.AppearanceDropDownHeader.Options.UseFont = True
        Me.lkeParentescoFamiliar.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeParentescoFamiliar.Properties.AppearanceFocused.Options.UseFont = True
        Me.lkeParentescoFamiliar.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeParentescoFamiliar.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.lkeParentescoFamiliar.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkeParentescoFamiliar.Properties.CloseUpKey = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.Right)
        Me.lkeParentescoFamiliar.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "Codigo", 23, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Descripcion", 23, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.lkeParentescoFamiliar.Properties.NullText = "Seleccione..."
        Me.lkeParentescoFamiliar.Properties.ShowFooter = False
        Me.lkeParentescoFamiliar.Properties.ShowHeader = False
        Me.lkeParentescoFamiliar.Size = New System.Drawing.Size(161, 24)
        Me.lkeParentescoFamiliar.TabIndex = 3
        '
        'txtDirEmpTrabajaFamiliar
        '
        Me.txtDirEmpTrabajaFamiliar.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtDirEmpTrabajaFamiliar.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtDirEmpTrabajaFamiliar.AltodelControl = 30
        Me.txtDirEmpTrabajaFamiliar.AnchoLabel = 120
        Me.txtDirEmpTrabajaFamiliar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDirEmpTrabajaFamiliar.AutoSize = True
        Me.txtDirEmpTrabajaFamiliar.ColordeFondo = System.Drawing.Color.Transparent
        Me.txtDirEmpTrabajaFamiliar.EsObligatorio = False
        Me.txtDirEmpTrabajaFamiliar.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDirEmpTrabajaFamiliar.FormatoNumero = Nothing
        Me.txtDirEmpTrabajaFamiliar.Location = New System.Drawing.Point(584, 63)
        Me.txtDirEmpTrabajaFamiliar.Margin = New System.Windows.Forms.Padding(5)
        Me.txtDirEmpTrabajaFamiliar.MaximoAncho = 0
        Me.txtDirEmpTrabajaFamiliar.MensajedeAyuda = "Digite la dirección de la empresa en la cual labora el empleado. (ENTER,TAB,ABJ)=" &
    "Avanzar;(ARB,ESC)=Atras"
        Me.txtDirEmpTrabajaFamiliar.Name = "txtDirEmpTrabajaFamiliar"
        Me.txtDirEmpTrabajaFamiliar.Size = New System.Drawing.Size(288, 37)
        Me.txtDirEmpTrabajaFamiliar.SoloLectura = False
        Me.txtDirEmpTrabajaFamiliar.SoloNumeros = False
        Me.txtDirEmpTrabajaFamiliar.TabIndex = 11
        Me.txtDirEmpTrabajaFamiliar.TextodelControl = ""
        Me.txtDirEmpTrabajaFamiliar.TextoLabel = "Dirección :"
        Me.txtDirEmpTrabajaFamiliar.TieneErrorControl = False
        Me.txtDirEmpTrabajaFamiliar.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtDirEmpTrabajaFamiliar.TipodeLetra = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDirEmpTrabajaFamiliar.ValordelControl = Nothing
        Me.txtDirEmpTrabajaFamiliar.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDirEmpTrabajaFamiliar.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDirEmpTrabajaFamiliar.ValorPredeterminado = Nothing
        '
        'txtTelsEmpTrabajaFamiliar
        '
        Me.txtTelsEmpTrabajaFamiliar.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtTelsEmpTrabajaFamiliar.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtTelsEmpTrabajaFamiliar.AltodelControl = 30
        Me.txtTelsEmpTrabajaFamiliar.AnchoLabel = 120
        Me.txtTelsEmpTrabajaFamiliar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTelsEmpTrabajaFamiliar.AutoSize = True
        Me.txtTelsEmpTrabajaFamiliar.ColordeFondo = System.Drawing.Color.Transparent
        Me.txtTelsEmpTrabajaFamiliar.EsObligatorio = False
        Me.txtTelsEmpTrabajaFamiliar.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelsEmpTrabajaFamiliar.FormatoNumero = Nothing
        Me.txtTelsEmpTrabajaFamiliar.Location = New System.Drawing.Point(584, 30)
        Me.txtTelsEmpTrabajaFamiliar.Margin = New System.Windows.Forms.Padding(5)
        Me.txtTelsEmpTrabajaFamiliar.MaximoAncho = 0
        Me.txtTelsEmpTrabajaFamiliar.MensajedeAyuda = "Digite los teléfonos de contacto de la empresa en la que labora el familiar. (ENT" &
    "ER,TAB,ABJ)=Avanzar;(ARB,ESC)=Atras"
        Me.txtTelsEmpTrabajaFamiliar.Name = "txtTelsEmpTrabajaFamiliar"
        Me.txtTelsEmpTrabajaFamiliar.Size = New System.Drawing.Size(288, 37)
        Me.txtTelsEmpTrabajaFamiliar.SoloLectura = False
        Me.txtTelsEmpTrabajaFamiliar.SoloNumeros = False
        Me.txtTelsEmpTrabajaFamiliar.TabIndex = 10
        Me.txtTelsEmpTrabajaFamiliar.TextodelControl = ""
        Me.txtTelsEmpTrabajaFamiliar.TextoLabel = "Teléfonos :"
        Me.txtTelsEmpTrabajaFamiliar.TieneErrorControl = False
        Me.txtTelsEmpTrabajaFamiliar.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtTelsEmpTrabajaFamiliar.TipodeLetra = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelsEmpTrabajaFamiliar.ValordelControl = Nothing
        Me.txtTelsEmpTrabajaFamiliar.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTelsEmpTrabajaFamiliar.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTelsEmpTrabajaFamiliar.ValorPredeterminado = Nothing
        '
        'txtCelFamiliar
        '
        Me.txtCelFamiliar.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtCelFamiliar.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtCelFamiliar.AltodelControl = 30
        Me.txtCelFamiliar.AnchoLabel = 100
        Me.txtCelFamiliar.AutoSize = True
        Me.txtCelFamiliar.ColordeFondo = System.Drawing.Color.Transparent
        Me.txtCelFamiliar.EsObligatorio = False
        Me.txtCelFamiliar.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCelFamiliar.FormatoNumero = Nothing
        Me.txtCelFamiliar.Location = New System.Drawing.Point(28, 133)
        Me.txtCelFamiliar.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCelFamiliar.MaximoAncho = 0
        Me.txtCelFamiliar.MensajedeAyuda = "Digite el número de celular del Familiar. (ENTER,TAB,ABJ)=Avanzar;(ARB,ESC)=Atras" &
    ""
        Me.txtCelFamiliar.Name = "txtCelFamiliar"
        Me.txtCelFamiliar.Size = New System.Drawing.Size(286, 37)
        Me.txtCelFamiliar.SoloLectura = False
        Me.txtCelFamiliar.SoloNumeros = False
        Me.txtCelFamiliar.TabIndex = 6
        Me.txtCelFamiliar.TextodelControl = ""
        Me.txtCelFamiliar.TextoLabel = "Celular :"
        Me.txtCelFamiliar.TieneErrorControl = False
        Me.txtCelFamiliar.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtCelFamiliar.TipodeLetra = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCelFamiliar.ValordelControl = Nothing
        Me.txtCelFamiliar.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCelFamiliar.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCelFamiliar.ValorPredeterminado = Nothing
        '
        'txtCargoFamiliar
        '
        Me.txtCargoFamiliar.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtCargoFamiliar.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtCargoFamiliar.AltodelControl = 30
        Me.txtCargoFamiliar.AnchoLabel = 100
        Me.txtCargoFamiliar.AutoSize = True
        Me.txtCargoFamiliar.ColordeFondo = System.Drawing.Color.Transparent
        Me.txtCargoFamiliar.EsObligatorio = False
        Me.txtCargoFamiliar.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCargoFamiliar.FormatoNumero = Nothing
        Me.txtCargoFamiliar.Location = New System.Drawing.Point(28, 199)
        Me.txtCargoFamiliar.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCargoFamiliar.MaximoAncho = 0
        Me.txtCargoFamiliar.MensajedeAyuda = "Digite el cargo que desempeña el familiar en su trabajo. (ENTER,TAB,ABJ)=Avanzar;" &
    "(ARB,ESC)=Atras"
        Me.txtCargoFamiliar.Name = "txtCargoFamiliar"
        Me.txtCargoFamiliar.Size = New System.Drawing.Size(553, 37)
        Me.txtCargoFamiliar.SoloLectura = False
        Me.txtCargoFamiliar.SoloNumeros = False
        Me.txtCargoFamiliar.TabIndex = 9
        Me.txtCargoFamiliar.TextodelControl = ""
        Me.txtCargoFamiliar.TextoLabel = "Cargo :"
        Me.txtCargoFamiliar.TieneErrorControl = False
        Me.txtCargoFamiliar.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtCargoFamiliar.TipodeLetra = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCargoFamiliar.ValordelControl = Nothing
        Me.txtCargoFamiliar.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCargoFamiliar.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCargoFamiliar.ValorPredeterminado = Nothing
        '
        'txtEmpresaTrabajaFamiliar
        '
        Me.txtEmpresaTrabajaFamiliar.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtEmpresaTrabajaFamiliar.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtEmpresaTrabajaFamiliar.AltodelControl = 30
        Me.txtEmpresaTrabajaFamiliar.AnchoLabel = 100
        Me.txtEmpresaTrabajaFamiliar.AutoSize = True
        Me.txtEmpresaTrabajaFamiliar.ColordeFondo = System.Drawing.Color.Transparent
        Me.txtEmpresaTrabajaFamiliar.EsObligatorio = False
        Me.txtEmpresaTrabajaFamiliar.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpresaTrabajaFamiliar.FormatoNumero = Nothing
        Me.txtEmpresaTrabajaFamiliar.Location = New System.Drawing.Point(27, 167)
        Me.txtEmpresaTrabajaFamiliar.Margin = New System.Windows.Forms.Padding(5)
        Me.txtEmpresaTrabajaFamiliar.MaximoAncho = 0
        Me.txtEmpresaTrabajaFamiliar.MensajedeAyuda = "Digite el nombre de la empresa en la que labora el familia. (ENTER,TAB,ABJ)=Avanz" &
    "ar;(ARB,ESC)=Atras"
        Me.txtEmpresaTrabajaFamiliar.Name = "txtEmpresaTrabajaFamiliar"
        Me.txtEmpresaTrabajaFamiliar.Size = New System.Drawing.Size(553, 37)
        Me.txtEmpresaTrabajaFamiliar.SoloLectura = False
        Me.txtEmpresaTrabajaFamiliar.SoloNumeros = False
        Me.txtEmpresaTrabajaFamiliar.TabIndex = 8
        Me.txtEmpresaTrabajaFamiliar.TextodelControl = ""
        Me.txtEmpresaTrabajaFamiliar.TextoLabel = "Empresa :"
        Me.txtEmpresaTrabajaFamiliar.TieneErrorControl = False
        Me.txtEmpresaTrabajaFamiliar.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtEmpresaTrabajaFamiliar.TipodeLetra = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpresaTrabajaFamiliar.ValordelControl = Nothing
        Me.txtEmpresaTrabajaFamiliar.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtEmpresaTrabajaFamiliar.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtEmpresaTrabajaFamiliar.ValorPredeterminado = Nothing
        '
        'txtOcupacionFamiliar
        '
        Me.txtOcupacionFamiliar.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtOcupacionFamiliar.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtOcupacionFamiliar.AltodelControl = 30
        Me.txtOcupacionFamiliar.AnchoLabel = 90
        Me.txtOcupacionFamiliar.AutoSize = True
        Me.txtOcupacionFamiliar.ColordeFondo = System.Drawing.Color.Transparent
        Me.txtOcupacionFamiliar.EsObligatorio = False
        Me.txtOcupacionFamiliar.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOcupacionFamiliar.FormatoNumero = Nothing
        Me.txtOcupacionFamiliar.Location = New System.Drawing.Point(317, 134)
        Me.txtOcupacionFamiliar.Margin = New System.Windows.Forms.Padding(5)
        Me.txtOcupacionFamiliar.MaximoAncho = 0
        Me.txtOcupacionFamiliar.MensajedeAyuda = "Digite la ocupación del Familiar. (ENTER,TAB,ABJ)=Avanzar;(ARB,ESC)=Atras"
        Me.txtOcupacionFamiliar.Name = "txtOcupacionFamiliar"
        Me.txtOcupacionFamiliar.Size = New System.Drawing.Size(264, 37)
        Me.txtOcupacionFamiliar.SoloLectura = False
        Me.txtOcupacionFamiliar.SoloNumeros = False
        Me.txtOcupacionFamiliar.TabIndex = 7
        Me.txtOcupacionFamiliar.TextodelControl = ""
        Me.txtOcupacionFamiliar.TextoLabel = "Ocupación :"
        Me.txtOcupacionFamiliar.TieneErrorControl = False
        Me.txtOcupacionFamiliar.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtOcupacionFamiliar.TipodeLetra = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtOcupacionFamiliar.ValordelControl = Nothing
        Me.txtOcupacionFamiliar.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtOcupacionFamiliar.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtOcupacionFamiliar.ValorPredeterminado = Nothing
        '
        'lkeTipoDocFamiliar
        '
        Me.lkeTipoDocFamiliar.Location = New System.Drawing.Point(149, 38)
        Me.lkeTipoDocFamiliar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lkeTipoDocFamiliar.Name = "lkeTipoDocFamiliar"
        Me.lkeTipoDocFamiliar.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.lkeTipoDocFamiliar.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeTipoDocFamiliar.Properties.Appearance.Options.UseFont = True
        Me.lkeTipoDocFamiliar.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeTipoDocFamiliar.Properties.AppearanceDisabled.Options.UseFont = True
        Me.lkeTipoDocFamiliar.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeTipoDocFamiliar.Properties.AppearanceDropDown.Options.UseFont = True
        Me.lkeTipoDocFamiliar.Properties.AppearanceDropDownHeader.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeTipoDocFamiliar.Properties.AppearanceDropDownHeader.Options.UseFont = True
        Me.lkeTipoDocFamiliar.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeTipoDocFamiliar.Properties.AppearanceFocused.Options.UseFont = True
        Me.lkeTipoDocFamiliar.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeTipoDocFamiliar.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.lkeTipoDocFamiliar.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkeTipoDocFamiliar.Properties.CloseUpKey = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.Right)
        Me.lkeTipoDocFamiliar.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "Codigo", 23, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Descripcion", 23, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.lkeTipoDocFamiliar.Properties.NullText = "Seleccione..."
        Me.lkeTipoDocFamiliar.Properties.ShowFooter = False
        Me.lkeTipoDocFamiliar.Properties.ShowHeader = False
        Me.lkeTipoDocFamiliar.Size = New System.Drawing.Size(161, 24)
        Me.lkeTipoDocFamiliar.TabIndex = 1
        '
        'lblParentescoFamiliar
        '
        Me.lblParentescoFamiliar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lblParentescoFamiliar.Appearance.Options.UseFont = True
        Me.lblParentescoFamiliar.Appearance.Options.UseTextOptions = True
        Me.lblParentescoFamiliar.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblParentescoFamiliar.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblParentescoFamiliar.Location = New System.Drawing.Point(7, 69)
        Me.lblParentescoFamiliar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblParentescoFamiliar.Name = "lblParentescoFamiliar"
        Me.lblParentescoFamiliar.Padding = New System.Windows.Forms.Padding(2)
        Me.lblParentescoFamiliar.Size = New System.Drawing.Size(135, 32)
        Me.lblParentescoFamiliar.TabIndex = 27
        Me.lblParentescoFamiliar.Text = "Parentesco :"
        '
        'lblFecNacFamiliar
        '
        Me.lblFecNacFamiliar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecNacFamiliar.Appearance.Options.UseFont = True
        Me.lblFecNacFamiliar.Appearance.Options.UseTextOptions = True
        Me.lblFecNacFamiliar.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblFecNacFamiliar.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblFecNacFamiliar.Location = New System.Drawing.Point(311, 65)
        Me.lblFecNacFamiliar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblFecNacFamiliar.Name = "lblFecNacFamiliar"
        Me.lblFecNacFamiliar.Padding = New System.Windows.Forms.Padding(2)
        Me.lblFecNacFamiliar.Size = New System.Drawing.Size(107, 32)
        Me.lblFecNacFamiliar.TabIndex = 21
        Me.lblFecNacFamiliar.Text = "Fecha Nac. :"
        '
        'dteFecNacFamiliar
        '
        Me.dteFecNacFamiliar.EditValue = Nothing
        Me.dteFecNacFamiliar.Location = New System.Drawing.Point(426, 69)
        Me.dteFecNacFamiliar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dteFecNacFamiliar.Name = "dteFecNacFamiliar"
        Me.dteFecNacFamiliar.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.dteFecNacFamiliar.Properties.Appearance.Options.UseFont = True
        Me.dteFecNacFamiliar.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.dteFecNacFamiliar.Properties.AppearanceDropDown.Options.UseFont = True
        Me.dteFecNacFamiliar.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteFecNacFamiliar.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteFecNacFamiliar.Size = New System.Drawing.Size(152, 24)
        Me.dteFecNacFamiliar.TabIndex = 4
        '
        'lblTipoDocFamiliar
        '
        Me.lblTipoDocFamiliar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lblTipoDocFamiliar.Appearance.Options.UseFont = True
        Me.lblTipoDocFamiliar.Appearance.Options.UseTextOptions = True
        Me.lblTipoDocFamiliar.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblTipoDocFamiliar.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblTipoDocFamiliar.Location = New System.Drawing.Point(7, 34)
        Me.lblTipoDocFamiliar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblTipoDocFamiliar.Name = "lblTipoDocFamiliar"
        Me.lblTipoDocFamiliar.Padding = New System.Windows.Forms.Padding(2)
        Me.lblTipoDocFamiliar.Size = New System.Drawing.Size(135, 32)
        Me.lblTipoDocFamiliar.TabIndex = 25
        Me.lblTipoDocFamiliar.Text = "Tipo Documento :"
        '
        'gbxUbicacionEmpTrabajaEmpleado
        '
        Me.gbxUbicacionEmpTrabajaEmpleado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxUbicacionEmpTrabajaEmpleado.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.gbxUbicacionEmpTrabajaEmpleado.AppearanceCaption.Options.UseFont = True
        Me.gbxUbicacionEmpTrabajaEmpleado.Controls.Add(Me.lkePaisEmpTrabajaFamiliar)
        Me.gbxUbicacionEmpTrabajaEmpleado.Controls.Add(Me.lblMuniEmpTrabajaFamiliar)
        Me.gbxUbicacionEmpTrabajaEmpleado.Controls.Add(Me.lkeMuniEmpTrabajaFamiliar)
        Me.gbxUbicacionEmpTrabajaEmpleado.Controls.Add(Me.lblPaisEmpTrabajaFamiliar)
        Me.gbxUbicacionEmpTrabajaEmpleado.Controls.Add(Me.lblDepEmpTrabajaFamiliar)
        Me.gbxUbicacionEmpTrabajaEmpleado.Controls.Add(Me.lkeDepEmpTrabajaFamiliar)
        Me.gbxUbicacionEmpTrabajaEmpleado.Location = New System.Drawing.Point(584, 107)
        Me.gbxUbicacionEmpTrabajaEmpleado.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbxUbicacionEmpTrabajaEmpleado.Name = "gbxUbicacionEmpTrabajaEmpleado"
        Me.gbxUbicacionEmpTrabajaEmpleado.Padding = New System.Windows.Forms.Padding(6)
        Me.gbxUbicacionEmpTrabajaEmpleado.Size = New System.Drawing.Size(290, 123)
        Me.gbxUbicacionEmpTrabajaEmpleado.TabIndex = 70
        Me.gbxUbicacionEmpTrabajaEmpleado.Text = "Ubicación Empresa Labora"
        '
        'lkePaisEmpTrabajaFamiliar
        '
        Me.lkePaisEmpTrabajaFamiliar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lkePaisEmpTrabajaFamiliar.Location = New System.Drawing.Point(142, 32)
        Me.lkePaisEmpTrabajaFamiliar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lkePaisEmpTrabajaFamiliar.Name = "lkePaisEmpTrabajaFamiliar"
        Me.lkePaisEmpTrabajaFamiliar.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkePaisEmpTrabajaFamiliar.Properties.Appearance.Options.UseFont = True
        Me.lkePaisEmpTrabajaFamiliar.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkePaisEmpTrabajaFamiliar.Properties.AppearanceDisabled.Options.UseFont = True
        Me.lkePaisEmpTrabajaFamiliar.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkePaisEmpTrabajaFamiliar.Properties.AppearanceDropDown.Options.UseFont = True
        Me.lkePaisEmpTrabajaFamiliar.Properties.AppearanceDropDownHeader.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkePaisEmpTrabajaFamiliar.Properties.AppearanceDropDownHeader.Options.UseFont = True
        Me.lkePaisEmpTrabajaFamiliar.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkePaisEmpTrabajaFamiliar.Properties.AppearanceFocused.Options.UseFont = True
        Me.lkePaisEmpTrabajaFamiliar.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkePaisEmpTrabajaFamiliar.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.lkePaisEmpTrabajaFamiliar.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkePaisEmpTrabajaFamiliar.Properties.CloseUpKey = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.Right)
        Me.lkePaisEmpTrabajaFamiliar.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "Codigo", 23, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Descripcion", 23, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.lkePaisEmpTrabajaFamiliar.Properties.NullText = "Seleccione..."
        Me.lkePaisEmpTrabajaFamiliar.Size = New System.Drawing.Size(142, 24)
        Me.lkePaisEmpTrabajaFamiliar.TabIndex = 12
        '
        'lblMuniEmpTrabajaFamiliar
        '
        Me.lblMuniEmpTrabajaFamiliar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lblMuniEmpTrabajaFamiliar.Appearance.Options.UseFont = True
        Me.lblMuniEmpTrabajaFamiliar.Appearance.Options.UseTextOptions = True
        Me.lblMuniEmpTrabajaFamiliar.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblMuniEmpTrabajaFamiliar.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblMuniEmpTrabajaFamiliar.Location = New System.Drawing.Point(12, 87)
        Me.lblMuniEmpTrabajaFamiliar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblMuniEmpTrabajaFamiliar.Name = "lblMuniEmpTrabajaFamiliar"
        Me.lblMuniEmpTrabajaFamiliar.Padding = New System.Windows.Forms.Padding(2)
        Me.lblMuniEmpTrabajaFamiliar.Size = New System.Drawing.Size(124, 32)
        Me.lblMuniEmpTrabajaFamiliar.TabIndex = 23
        Me.lblMuniEmpTrabajaFamiliar.Text = "Municipio :"
        '
        'lkeMuniEmpTrabajaFamiliar
        '
        Me.lkeMuniEmpTrabajaFamiliar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lkeMuniEmpTrabajaFamiliar.Location = New System.Drawing.Point(142, 91)
        Me.lkeMuniEmpTrabajaFamiliar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lkeMuniEmpTrabajaFamiliar.Name = "lkeMuniEmpTrabajaFamiliar"
        Me.lkeMuniEmpTrabajaFamiliar.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeMuniEmpTrabajaFamiliar.Properties.Appearance.Options.UseFont = True
        Me.lkeMuniEmpTrabajaFamiliar.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeMuniEmpTrabajaFamiliar.Properties.AppearanceDisabled.Options.UseFont = True
        Me.lkeMuniEmpTrabajaFamiliar.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeMuniEmpTrabajaFamiliar.Properties.AppearanceDropDown.Options.UseFont = True
        Me.lkeMuniEmpTrabajaFamiliar.Properties.AppearanceDropDownHeader.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeMuniEmpTrabajaFamiliar.Properties.AppearanceDropDownHeader.Options.UseFont = True
        Me.lkeMuniEmpTrabajaFamiliar.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeMuniEmpTrabajaFamiliar.Properties.AppearanceFocused.Options.UseFont = True
        Me.lkeMuniEmpTrabajaFamiliar.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeMuniEmpTrabajaFamiliar.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.lkeMuniEmpTrabajaFamiliar.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkeMuniEmpTrabajaFamiliar.Properties.CloseUpKey = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.Right)
        Me.lkeMuniEmpTrabajaFamiliar.Properties.NullText = "Seleccione..."
        Me.lkeMuniEmpTrabajaFamiliar.Size = New System.Drawing.Size(142, 24)
        Me.lkeMuniEmpTrabajaFamiliar.TabIndex = 14
        '
        'lblPaisEmpTrabajaFamiliar
        '
        Me.lblPaisEmpTrabajaFamiliar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lblPaisEmpTrabajaFamiliar.Appearance.Options.UseFont = True
        Me.lblPaisEmpTrabajaFamiliar.Appearance.Options.UseTextOptions = True
        Me.lblPaisEmpTrabajaFamiliar.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblPaisEmpTrabajaFamiliar.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblPaisEmpTrabajaFamiliar.Location = New System.Drawing.Point(12, 28)
        Me.lblPaisEmpTrabajaFamiliar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblPaisEmpTrabajaFamiliar.Name = "lblPaisEmpTrabajaFamiliar"
        Me.lblPaisEmpTrabajaFamiliar.Padding = New System.Windows.Forms.Padding(2)
        Me.lblPaisEmpTrabajaFamiliar.Size = New System.Drawing.Size(125, 32)
        Me.lblPaisEmpTrabajaFamiliar.TabIndex = 25
        Me.lblPaisEmpTrabajaFamiliar.Text = "Pais :"
        '
        'lblDepEmpTrabajaFamiliar
        '
        Me.lblDepEmpTrabajaFamiliar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lblDepEmpTrabajaFamiliar.Appearance.Options.UseFont = True
        Me.lblDepEmpTrabajaFamiliar.Appearance.Options.UseTextOptions = True
        Me.lblDepEmpTrabajaFamiliar.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblDepEmpTrabajaFamiliar.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblDepEmpTrabajaFamiliar.Location = New System.Drawing.Point(7, 58)
        Me.lblDepEmpTrabajaFamiliar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblDepEmpTrabajaFamiliar.Name = "lblDepEmpTrabajaFamiliar"
        Me.lblDepEmpTrabajaFamiliar.Padding = New System.Windows.Forms.Padding(2)
        Me.lblDepEmpTrabajaFamiliar.Size = New System.Drawing.Size(129, 32)
        Me.lblDepEmpTrabajaFamiliar.TabIndex = 27
        Me.lblDepEmpTrabajaFamiliar.Text = "Departamento :"
        '
        'lkeDepEmpTrabajaFamiliar
        '
        Me.lkeDepEmpTrabajaFamiliar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lkeDepEmpTrabajaFamiliar.Location = New System.Drawing.Point(142, 62)
        Me.lkeDepEmpTrabajaFamiliar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lkeDepEmpTrabajaFamiliar.Name = "lkeDepEmpTrabajaFamiliar"
        Me.lkeDepEmpTrabajaFamiliar.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeDepEmpTrabajaFamiliar.Properties.Appearance.Options.UseFont = True
        Me.lkeDepEmpTrabajaFamiliar.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeDepEmpTrabajaFamiliar.Properties.AppearanceDisabled.Options.UseFont = True
        Me.lkeDepEmpTrabajaFamiliar.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeDepEmpTrabajaFamiliar.Properties.AppearanceDropDown.Options.UseFont = True
        Me.lkeDepEmpTrabajaFamiliar.Properties.AppearanceDropDownHeader.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeDepEmpTrabajaFamiliar.Properties.AppearanceDropDownHeader.Options.UseFont = True
        Me.lkeDepEmpTrabajaFamiliar.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeDepEmpTrabajaFamiliar.Properties.AppearanceFocused.Options.UseFont = True
        Me.lkeDepEmpTrabajaFamiliar.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeDepEmpTrabajaFamiliar.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.lkeDepEmpTrabajaFamiliar.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkeDepEmpTrabajaFamiliar.Properties.CloseUpKey = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.Right)
        Me.lkeDepEmpTrabajaFamiliar.Properties.NullText = "Seleccione..."
        Me.lkeDepEmpTrabajaFamiliar.Size = New System.Drawing.Size(142, 24)
        Me.lkeDepEmpTrabajaFamiliar.TabIndex = 13
        '
        'txtDocFamiliar
        '
        Me.txtDocFamiliar.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtDocFamiliar.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtDocFamiliar.AltodelControl = 30
        Me.txtDocFamiliar.AnchoLabel = 95
        Me.txtDocFamiliar.AutoSize = True
        Me.txtDocFamiliar.ColordeFondo = System.Drawing.Color.Transparent
        Me.txtDocFamiliar.EsObligatorio = False
        Me.txtDocFamiliar.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocFamiliar.FormatoNumero = Nothing
        Me.txtDocFamiliar.Location = New System.Drawing.Point(313, 32)
        Me.txtDocFamiliar.Margin = New System.Windows.Forms.Padding(5)
        Me.txtDocFamiliar.MaximoAncho = 0
        Me.txtDocFamiliar.MensajedeAyuda = "Digite el número de documento del Familiar. (ENTER,TAB,ABJ)=Avanzar;(ARB,ESC)=Atr" &
    "as"
        Me.txtDocFamiliar.Name = "txtDocFamiliar"
        Me.txtDocFamiliar.Size = New System.Drawing.Size(268, 37)
        Me.txtDocFamiliar.SoloLectura = False
        Me.txtDocFamiliar.SoloNumeros = False
        Me.txtDocFamiliar.TabIndex = 2
        Me.txtDocFamiliar.TextodelControl = ""
        Me.txtDocFamiliar.TextoLabel = "Documento :"
        Me.txtDocFamiliar.TieneErrorControl = False
        Me.txtDocFamiliar.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtDocFamiliar.TipodeLetra = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocFamiliar.ValordelControl = Nothing
        Me.txtDocFamiliar.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDocFamiliar.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDocFamiliar.ValorPredeterminado = Nothing
        '
        'txtNombreFamiliar
        '
        Me.txtNombreFamiliar.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtNombreFamiliar.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtNombreFamiliar.AltodelControl = 30
        Me.txtNombreFamiliar.AnchoLabel = 100
        Me.txtNombreFamiliar.AutoSize = True
        Me.txtNombreFamiliar.ColordeFondo = System.Drawing.Color.Transparent
        Me.txtNombreFamiliar.EsObligatorio = False
        Me.txtNombreFamiliar.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreFamiliar.FormatoNumero = Nothing
        Me.txtNombreFamiliar.Location = New System.Drawing.Point(28, 100)
        Me.txtNombreFamiliar.Margin = New System.Windows.Forms.Padding(5)
        Me.txtNombreFamiliar.MaximoAncho = 0
        Me.txtNombreFamiliar.MensajedeAyuda = "Digite el nombre completo del Familiar. (ENTER,TAB,ABJ)=Avanzar;(ARB,ESC)=Atras"
        Me.txtNombreFamiliar.Name = "txtNombreFamiliar"
        Me.txtNombreFamiliar.Size = New System.Drawing.Size(553, 37)
        Me.txtNombreFamiliar.SoloLectura = False
        Me.txtNombreFamiliar.SoloNumeros = False
        Me.txtNombreFamiliar.TabIndex = 5
        Me.txtNombreFamiliar.TextodelControl = ""
        Me.txtNombreFamiliar.TextoLabel = "Nombre :"
        Me.txtNombreFamiliar.TieneErrorControl = False
        Me.txtNombreFamiliar.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtNombreFamiliar.TipodeLetra = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreFamiliar.ValordelControl = Nothing
        Me.txtNombreFamiliar.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombreFamiliar.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombreFamiliar.ValorPredeterminado = Nothing
        '
        'tpExpLaboral
        '
        Me.tpExpLaboral.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.tpExpLaboral.Appearance.Header.Options.UseFont = True
        Me.tpExpLaboral.Appearance.HeaderActive.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.tpExpLaboral.Appearance.HeaderActive.Options.UseFont = True
        Me.tpExpLaboral.Appearance.HeaderDisabled.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.tpExpLaboral.Appearance.HeaderDisabled.Options.UseFont = True
        Me.tpExpLaboral.Appearance.HeaderHotTracked.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.tpExpLaboral.Appearance.HeaderHotTracked.Options.UseFont = True
        Me.tpExpLaboral.Appearance.PageClient.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.tpExpLaboral.Appearance.PageClient.Options.UseFont = True
        Me.tpExpLaboral.Controls.Add(Me.gbxCertExpLab)
        Me.tpExpLaboral.Controls.Add(Me.gbxGrillaExpLab)
        Me.tpExpLaboral.Controls.Add(Me.gbxInfBasicaExpLab)
        Me.tpExpLaboral.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tpExpLaboral.Name = "tpExpLaboral"
        Me.tpExpLaboral.Padding = New System.Windows.Forms.Padding(6)
        Me.tpExpLaboral.Size = New System.Drawing.Size(1090, 566)
        Me.tpExpLaboral.Text = "&Experiencia Laboral"
        '
        'gbxCertExpLab
        '
        Me.gbxCertExpLab.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxCertExpLab.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.gbxCertExpLab.AppearanceCaption.Options.UseFont = True
        Me.gbxCertExpLab.Controls.Add(Me.GalleryControlExpLaboral)
        Me.gbxCertExpLab.Location = New System.Drawing.Point(901, 10)
        Me.gbxCertExpLab.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbxCertExpLab.Name = "gbxCertExpLab"
        Me.gbxCertExpLab.Size = New System.Drawing.Size(184, 831)
        Me.gbxCertExpLab.TabIndex = 14
        Me.gbxCertExpLab.Text = "Certificados"
        '
        'GalleryControlExpLaboral
        '
        Me.GalleryControlExpLaboral.Controls.Add(Me.GalleryControlClient1)
        Me.GalleryControlExpLaboral.Dock = System.Windows.Forms.DockStyle.Fill
        '
        '
        '
        Me.GalleryControlExpLaboral.Gallery.ColumnCount = 1
        Me.GalleryControlExpLaboral.Location = New System.Drawing.Point(2, 28)
        Me.GalleryControlExpLaboral.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GalleryControlExpLaboral.Name = "GalleryControlExpLaboral"
        Me.GalleryControlExpLaboral.Size = New System.Drawing.Size(180, 801)
        Me.GalleryControlExpLaboral.TabIndex = 11
        Me.GalleryControlExpLaboral.Text = "GalleryControl1"
        '
        'GalleryControlClient1
        '
        Me.GalleryControlClient1.GalleryControl = Me.GalleryControlExpLaboral
        Me.GalleryControlClient1.Location = New System.Drawing.Point(2, 2)
        Me.GalleryControlClient1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GalleryControlClient1.Size = New System.Drawing.Size(155, 797)
        '
        'gbxGrillaExpLab
        '
        Me.gbxGrillaExpLab.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxGrillaExpLab.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.gbxGrillaExpLab.AppearanceCaption.Options.UseFont = True
        Me.gbxGrillaExpLab.Controls.Add(Me.gcExpLaboral)
        Me.gbxGrillaExpLab.Location = New System.Drawing.Point(9, 192)
        Me.gbxGrillaExpLab.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbxGrillaExpLab.Name = "gbxGrillaExpLab"
        Me.gbxGrillaExpLab.Size = New System.Drawing.Size(887, 649)
        Me.gbxGrillaExpLab.TabIndex = 13
        Me.gbxGrillaExpLab.Text = "Lista Experiencia laboral"
        '
        'gcExpLaboral
        '
        Me.gcExpLaboral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcExpLaboral.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gcExpLaboral.Location = New System.Drawing.Point(2, 28)
        Me.gcExpLaboral.MainView = Me.gvExpLaboral
        Me.gcExpLaboral.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gcExpLaboral.Name = "gcExpLaboral"
        Me.gcExpLaboral.Size = New System.Drawing.Size(883, 619)
        Me.gcExpLaboral.TabIndex = 0
        Me.gcExpLaboral.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvExpLaboral})
        '
        'gvExpLaboral
        '
        Me.gvExpLaboral.DetailHeight = 431
        Me.gvExpLaboral.GridControl = Me.gcExpLaboral
        Me.gvExpLaboral.Name = "gvExpLaboral"
        '
        'gbxInfBasicaExpLab
        '
        Me.gbxInfBasicaExpLab.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxInfBasicaExpLab.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.gbxInfBasicaExpLab.AppearanceCaption.Options.UseFont = True
        Me.gbxInfBasicaExpLab.Controls.Add(Me.SeparatorControl1)
        Me.gbxInfBasicaExpLab.Controls.Add(Me.lblFechaRetiroExpLab)
        Me.gbxInfBasicaExpLab.Controls.Add(Me.dteFecRetiroExpLab)
        Me.gbxInfBasicaExpLab.Controls.Add(Me.lblFechaIngresoExpLab)
        Me.gbxInfBasicaExpLab.Controls.Add(Me.dteFecIngresoExpLab)
        Me.gbxInfBasicaExpLab.Controls.Add(Me.txtEmpresaExpLab)
        Me.gbxInfBasicaExpLab.Controls.Add(Me.txtTelEmpExpLab)
        Me.gbxInfBasicaExpLab.Controls.Add(Me.txtCargoExpLab)
        Me.gbxInfBasicaExpLab.Controls.Add(Me.txtJefeExplab)
        Me.gbxInfBasicaExpLab.Controls.Add(Me.txtDirEmpExpLab)
        Me.gbxInfBasicaExpLab.Location = New System.Drawing.Point(9, 10)
        Me.gbxInfBasicaExpLab.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbxInfBasicaExpLab.Name = "gbxInfBasicaExpLab"
        Me.gbxInfBasicaExpLab.Size = New System.Drawing.Size(887, 175)
        Me.gbxInfBasicaExpLab.TabIndex = 12
        Me.gbxInfBasicaExpLab.Text = "Información Basica"
        '
        'SeparatorControl1
        '
        Me.SeparatorControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SeparatorControl1.LineOrientation = System.Windows.Forms.Orientation.Vertical
        Me.SeparatorControl1.Location = New System.Drawing.Point(576, 28)
        Me.SeparatorControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SeparatorControl1.Name = "SeparatorControl1"
        Me.SeparatorControl1.Padding = New System.Windows.Forms.Padding(0)
        Me.SeparatorControl1.Size = New System.Drawing.Size(16, 137)
        Me.SeparatorControl1.TabIndex = 40
        '
        'lblFechaRetiroExpLab
        '
        Me.lblFechaRetiroExpLab.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFechaRetiroExpLab.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lblFechaRetiroExpLab.Appearance.Options.UseFont = True
        Me.lblFechaRetiroExpLab.Appearance.Options.UseTextOptions = True
        Me.lblFechaRetiroExpLab.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblFechaRetiroExpLab.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblFechaRetiroExpLab.Location = New System.Drawing.Point(588, 100)
        Me.lblFechaRetiroExpLab.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblFechaRetiroExpLab.Name = "lblFechaRetiroExpLab"
        Me.lblFechaRetiroExpLab.Padding = New System.Windows.Forms.Padding(2)
        Me.lblFechaRetiroExpLab.Size = New System.Drawing.Size(118, 32)
        Me.lblFechaRetiroExpLab.TabIndex = 39
        Me.lblFechaRetiroExpLab.Text = "Fecha Retiro :"
        '
        'dteFecRetiroExpLab
        '
        Me.dteFecRetiroExpLab.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dteFecRetiroExpLab.EditValue = Nothing
        Me.dteFecRetiroExpLab.Location = New System.Drawing.Point(713, 103)
        Me.dteFecRetiroExpLab.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dteFecRetiroExpLab.Name = "dteFecRetiroExpLab"
        Me.dteFecRetiroExpLab.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.dteFecRetiroExpLab.Properties.Appearance.Options.UseFont = True
        Me.dteFecRetiroExpLab.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.dteFecRetiroExpLab.Properties.AppearanceDropDown.Options.UseFont = True
        Me.dteFecRetiroExpLab.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteFecRetiroExpLab.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteFecRetiroExpLab.Size = New System.Drawing.Size(163, 24)
        Me.dteFecRetiroExpLab.TabIndex = 7
        '
        'lblFechaIngresoExpLab
        '
        Me.lblFechaIngresoExpLab.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFechaIngresoExpLab.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lblFechaIngresoExpLab.Appearance.Options.UseFont = True
        Me.lblFechaIngresoExpLab.Appearance.Options.UseTextOptions = True
        Me.lblFechaIngresoExpLab.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblFechaIngresoExpLab.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblFechaIngresoExpLab.Location = New System.Drawing.Point(589, 66)
        Me.lblFechaIngresoExpLab.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblFechaIngresoExpLab.Name = "lblFechaIngresoExpLab"
        Me.lblFechaIngresoExpLab.Padding = New System.Windows.Forms.Padding(2)
        Me.lblFechaIngresoExpLab.Size = New System.Drawing.Size(118, 32)
        Me.lblFechaIngresoExpLab.TabIndex = 37
        Me.lblFechaIngresoExpLab.Text = "Fecha Ingreso :"
        '
        'dteFecIngresoExpLab
        '
        Me.dteFecIngresoExpLab.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dteFecIngresoExpLab.EditValue = Nothing
        Me.dteFecIngresoExpLab.Location = New System.Drawing.Point(713, 70)
        Me.dteFecIngresoExpLab.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dteFecIngresoExpLab.Name = "dteFecIngresoExpLab"
        Me.dteFecIngresoExpLab.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.dteFecIngresoExpLab.Properties.Appearance.Options.UseFont = True
        Me.dteFecIngresoExpLab.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.dteFecIngresoExpLab.Properties.AppearanceDropDown.Options.UseFont = True
        Me.dteFecIngresoExpLab.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteFecIngresoExpLab.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteFecIngresoExpLab.Size = New System.Drawing.Size(163, 24)
        Me.dteFecIngresoExpLab.TabIndex = 6
        '
        'txtEmpresaExpLab
        '
        Me.txtEmpresaExpLab.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtEmpresaExpLab.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtEmpresaExpLab.AltodelControl = 30
        Me.txtEmpresaExpLab.AnchoLabel = 125
        Me.txtEmpresaExpLab.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEmpresaExpLab.AutoSize = True
        Me.txtEmpresaExpLab.ColordeFondo = System.Drawing.Color.Transparent
        Me.txtEmpresaExpLab.EsObligatorio = False
        Me.txtEmpresaExpLab.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpresaExpLab.FormatoNumero = Nothing
        Me.txtEmpresaExpLab.Location = New System.Drawing.Point(2, 32)
        Me.txtEmpresaExpLab.Margin = New System.Windows.Forms.Padding(5)
        Me.txtEmpresaExpLab.MaximoAncho = 0
        Me.txtEmpresaExpLab.MensajedeAyuda = "Nombre de la empresa en la cual trabajó. (ENTER,TAB,ABJ)=Avanzar;(ARB,ESC)=Atras"
        Me.txtEmpresaExpLab.Name = "txtEmpresaExpLab"
        Me.txtEmpresaExpLab.Size = New System.Drawing.Size(574, 37)
        Me.txtEmpresaExpLab.SoloLectura = False
        Me.txtEmpresaExpLab.SoloNumeros = False
        Me.txtEmpresaExpLab.TabIndex = 1
        Me.txtEmpresaExpLab.TextodelControl = ""
        Me.txtEmpresaExpLab.TextoLabel = "Empresa :"
        Me.txtEmpresaExpLab.TieneErrorControl = False
        Me.txtEmpresaExpLab.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtEmpresaExpLab.TipodeLetra = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpresaExpLab.ValordelControl = Nothing
        Me.txtEmpresaExpLab.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtEmpresaExpLab.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtEmpresaExpLab.ValorPredeterminado = Nothing
        '
        'txtTelEmpExpLab
        '
        Me.txtTelEmpExpLab.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtTelEmpExpLab.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtTelEmpExpLab.AltodelControl = 30
        Me.txtTelEmpExpLab.AnchoLabel = 100
        Me.txtTelEmpExpLab.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTelEmpExpLab.AutoSize = True
        Me.txtTelEmpExpLab.ColordeFondo = System.Drawing.Color.Transparent
        Me.txtTelEmpExpLab.EsObligatorio = False
        Me.txtTelEmpExpLab.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelEmpExpLab.FormatoNumero = Nothing
        Me.txtTelEmpExpLab.Location = New System.Drawing.Point(593, 33)
        Me.txtTelEmpExpLab.Margin = New System.Windows.Forms.Padding(5)
        Me.txtTelEmpExpLab.MaximoAncho = 0
        Me.txtTelEmpExpLab.MensajedeAyuda = "Teléfonos de la empresa donde trabajó. (ENTER,TAB,ABJ)=Avanzar;(ARB,ESC)=Atras"
        Me.txtTelEmpExpLab.Name = "txtTelEmpExpLab"
        Me.txtTelEmpExpLab.Size = New System.Drawing.Size(287, 37)
        Me.txtTelEmpExpLab.SoloLectura = False
        Me.txtTelEmpExpLab.SoloNumeros = False
        Me.txtTelEmpExpLab.TabIndex = 5
        Me.txtTelEmpExpLab.TextodelControl = ""
        Me.txtTelEmpExpLab.TextoLabel = "Teléfono :"
        Me.txtTelEmpExpLab.TieneErrorControl = False
        Me.txtTelEmpExpLab.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtTelEmpExpLab.TipodeLetra = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelEmpExpLab.ValordelControl = Nothing
        Me.txtTelEmpExpLab.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTelEmpExpLab.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTelEmpExpLab.ValorPredeterminado = Nothing
        '
        'txtCargoExpLab
        '
        Me.txtCargoExpLab.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtCargoExpLab.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtCargoExpLab.AltodelControl = 30
        Me.txtCargoExpLab.AnchoLabel = 125
        Me.txtCargoExpLab.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCargoExpLab.AutoSize = True
        Me.txtCargoExpLab.ColordeFondo = System.Drawing.Color.Transparent
        Me.txtCargoExpLab.EsObligatorio = False
        Me.txtCargoExpLab.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCargoExpLab.FormatoNumero = Nothing
        Me.txtCargoExpLab.Location = New System.Drawing.Point(2, 65)
        Me.txtCargoExpLab.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCargoExpLab.MaximoAncho = 0
        Me.txtCargoExpLab.MensajedeAyuda = "Cargo que desempeño en la empresa. (ENTER,TAB,ABJ)=Avanzar;(ARB,ESC)=Atras"
        Me.txtCargoExpLab.Name = "txtCargoExpLab"
        Me.txtCargoExpLab.Size = New System.Drawing.Size(574, 37)
        Me.txtCargoExpLab.SoloLectura = False
        Me.txtCargoExpLab.SoloNumeros = False
        Me.txtCargoExpLab.TabIndex = 2
        Me.txtCargoExpLab.TextodelControl = ""
        Me.txtCargoExpLab.TextoLabel = "Cargo :"
        Me.txtCargoExpLab.TieneErrorControl = False
        Me.txtCargoExpLab.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtCargoExpLab.TipodeLetra = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCargoExpLab.ValordelControl = Nothing
        Me.txtCargoExpLab.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCargoExpLab.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCargoExpLab.ValorPredeterminado = Nothing
        '
        'txtJefeExplab
        '
        Me.txtJefeExplab.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtJefeExplab.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtJefeExplab.AltodelControl = 30
        Me.txtJefeExplab.AnchoLabel = 125
        Me.txtJefeExplab.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtJefeExplab.AutoSize = True
        Me.txtJefeExplab.ColordeFondo = System.Drawing.Color.Transparent
        Me.txtJefeExplab.EsObligatorio = False
        Me.txtJefeExplab.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJefeExplab.FormatoNumero = Nothing
        Me.txtJefeExplab.Location = New System.Drawing.Point(3, 132)
        Me.txtJefeExplab.Margin = New System.Windows.Forms.Padding(5)
        Me.txtJefeExplab.MaximoAncho = 0
        Me.txtJefeExplab.MensajedeAyuda = "Nombre del Jefe Inmedito que tuvo en la empresa. (ENTER,TAB,ABJ)=Avanzar;(ARB,ESC" &
    ")=Atras"
        Me.txtJefeExplab.Name = "txtJefeExplab"
        Me.txtJefeExplab.Size = New System.Drawing.Size(573, 37)
        Me.txtJefeExplab.SoloLectura = False
        Me.txtJefeExplab.SoloNumeros = False
        Me.txtJefeExplab.TabIndex = 4
        Me.txtJefeExplab.TextodelControl = ""
        Me.txtJefeExplab.TextoLabel = "Jefe Inmeidato :"
        Me.txtJefeExplab.TieneErrorControl = False
        Me.txtJefeExplab.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtJefeExplab.TipodeLetra = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJefeExplab.ValordelControl = Nothing
        Me.txtJefeExplab.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtJefeExplab.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtJefeExplab.ValorPredeterminado = Nothing
        '
        'txtDirEmpExpLab
        '
        Me.txtDirEmpExpLab.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtDirEmpExpLab.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtDirEmpExpLab.AltodelControl = 30
        Me.txtDirEmpExpLab.AnchoLabel = 125
        Me.txtDirEmpExpLab.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDirEmpExpLab.AutoSize = True
        Me.txtDirEmpExpLab.ColordeFondo = System.Drawing.Color.Transparent
        Me.txtDirEmpExpLab.EsObligatorio = False
        Me.txtDirEmpExpLab.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDirEmpExpLab.FormatoNumero = Nothing
        Me.txtDirEmpExpLab.Location = New System.Drawing.Point(3, 98)
        Me.txtDirEmpExpLab.Margin = New System.Windows.Forms.Padding(5)
        Me.txtDirEmpExpLab.MaximoAncho = 0
        Me.txtDirEmpExpLab.MensajedeAyuda = "Dirección de la empresa donde trabajó. (ENTER,TAB,ABJ)=Avanzar;(ARB,ESC)=Atras"
        Me.txtDirEmpExpLab.Name = "txtDirEmpExpLab"
        Me.txtDirEmpExpLab.Size = New System.Drawing.Size(573, 37)
        Me.txtDirEmpExpLab.SoloLectura = False
        Me.txtDirEmpExpLab.SoloNumeros = False
        Me.txtDirEmpExpLab.TabIndex = 3
        Me.txtDirEmpExpLab.TextodelControl = ""
        Me.txtDirEmpExpLab.TextoLabel = "Dirección :"
        Me.txtDirEmpExpLab.TieneErrorControl = False
        Me.txtDirEmpExpLab.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtDirEmpExpLab.TipodeLetra = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDirEmpExpLab.ValordelControl = Nothing
        Me.txtDirEmpExpLab.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDirEmpExpLab.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDirEmpExpLab.ValorPredeterminado = Nothing
        '
        'tpInfAcademica
        '
        Me.tpInfAcademica.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.tpInfAcademica.Appearance.Header.Options.UseFont = True
        Me.tpInfAcademica.Appearance.HeaderActive.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.tpInfAcademica.Appearance.HeaderActive.Options.UseFont = True
        Me.tpInfAcademica.Appearance.HeaderDisabled.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.tpInfAcademica.Appearance.HeaderDisabled.Options.UseFont = True
        Me.tpInfAcademica.Appearance.HeaderHotTracked.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.tpInfAcademica.Appearance.HeaderHotTracked.Options.UseFont = True
        Me.tpInfAcademica.Appearance.PageClient.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.tpInfAcademica.Appearance.PageClient.Options.UseFont = True
        Me.tpInfAcademica.Controls.Add(Me.gbxCertEstudios)
        Me.tpInfAcademica.Controls.Add(Me.gbxGrillaInfAcademica)
        Me.tpInfAcademica.Controls.Add(Me.gbxInfBasicaEstudios)
        Me.tpInfAcademica.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tpInfAcademica.Name = "tpInfAcademica"
        Me.tpInfAcademica.Size = New System.Drawing.Size(1090, 566)
        Me.tpInfAcademica.Text = "&Información Académica"
        '
        'gbxCertEstudios
        '
        Me.gbxCertEstudios.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxCertEstudios.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.gbxCertEstudios.AppearanceCaption.Options.UseFont = True
        Me.gbxCertEstudios.Controls.Add(Me.GalleryControlEstudios)
        Me.gbxCertEstudios.Location = New System.Drawing.Point(894, 10)
        Me.gbxCertEstudios.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbxCertEstudios.Name = "gbxCertEstudios"
        Me.gbxCertEstudios.Size = New System.Drawing.Size(184, 831)
        Me.gbxCertEstudios.TabIndex = 17
        Me.gbxCertEstudios.Text = "Certificados"
        '
        'GalleryControlEstudios
        '
        Me.GalleryControlEstudios.Controls.Add(Me.GalleryControlClient2)
        Me.GalleryControlEstudios.Dock = System.Windows.Forms.DockStyle.Fill
        '
        '
        '
        Me.GalleryControlEstudios.Gallery.ColumnCount = 1
        Me.GalleryControlEstudios.Location = New System.Drawing.Point(2, 28)
        Me.GalleryControlEstudios.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GalleryControlEstudios.Name = "GalleryControlEstudios"
        Me.GalleryControlEstudios.Size = New System.Drawing.Size(180, 801)
        Me.GalleryControlEstudios.TabIndex = 11
        Me.GalleryControlEstudios.Text = "GalleryControl1"
        '
        'GalleryControlClient2
        '
        Me.GalleryControlClient2.GalleryControl = Me.GalleryControlEstudios
        Me.GalleryControlClient2.Location = New System.Drawing.Point(2, 2)
        Me.GalleryControlClient2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GalleryControlClient2.Size = New System.Drawing.Size(155, 797)
        '
        'gbxGrillaInfAcademica
        '
        Me.gbxGrillaInfAcademica.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxGrillaInfAcademica.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.gbxGrillaInfAcademica.AppearanceCaption.Options.UseFont = True
        Me.gbxGrillaInfAcademica.Controls.Add(Me.gcEstudios)
        Me.gbxGrillaInfAcademica.Location = New System.Drawing.Point(10, 213)
        Me.gbxGrillaInfAcademica.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbxGrillaInfAcademica.Name = "gbxGrillaInfAcademica"
        Me.gbxGrillaInfAcademica.Size = New System.Drawing.Size(878, 628)
        Me.gbxGrillaInfAcademica.TabIndex = 16
        Me.gbxGrillaInfAcademica.Text = "Lista Información Académica"
        '
        'gcEstudios
        '
        Me.gcEstudios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcEstudios.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gcEstudios.Location = New System.Drawing.Point(2, 28)
        Me.gcEstudios.MainView = Me.gvEstudios
        Me.gcEstudios.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gcEstudios.Name = "gcEstudios"
        Me.gcEstudios.Size = New System.Drawing.Size(874, 598)
        Me.gcEstudios.TabIndex = 0
        Me.gcEstudios.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvEstudios})
        '
        'gvEstudios
        '
        Me.gvEstudios.DetailHeight = 431
        Me.gvEstudios.GridControl = Me.gcEstudios
        Me.gvEstudios.Name = "gvEstudios"
        '
        'gbxInfBasicaEstudios
        '
        Me.gbxInfBasicaEstudios.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxInfBasicaEstudios.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.gbxInfBasicaEstudios.AppearanceCaption.Options.UseFont = True
        Me.gbxInfBasicaEstudios.Controls.Add(Me.cbxTipoTiempo)
        Me.gbxInfBasicaEstudios.Controls.Add(Me.ndDuracion)
        Me.gbxInfBasicaEstudios.Controls.Add(Me.lblDuracion)
        Me.gbxInfBasicaEstudios.Controls.Add(Me.lblTipoEducacion)
        Me.gbxInfBasicaEstudios.Controls.Add(Me.lkeNivelEducativo)
        Me.gbxInfBasicaEstudios.Controls.Add(Me.grbTipoEducacion)
        Me.gbxInfBasicaEstudios.Controls.Add(Me.btnAddTitulo)
        Me.gbxInfBasicaEstudios.Controls.Add(Me.btnAddNivelEducativo)
        Me.gbxInfBasicaEstudios.Controls.Add(Me.lblTituloObtenido)
        Me.gbxInfBasicaEstudios.Controls.Add(Me.lkeTituloObtenido)
        Me.gbxInfBasicaEstudios.Controls.Add(Me.lblNivelEducativo)
        Me.gbxInfBasicaEstudios.Controls.Add(Me.gbxLugarObtTitulo)
        Me.gbxInfBasicaEstudios.Controls.Add(Me.txtInstitucionObtTitulo)
        Me.gbxInfBasicaEstudios.Controls.Add(Me.txtMatriculaProfesional)
        Me.gbxInfBasicaEstudios.Location = New System.Drawing.Point(10, 10)
        Me.gbxInfBasicaEstudios.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbxInfBasicaEstudios.Name = "gbxInfBasicaEstudios"
        Me.gbxInfBasicaEstudios.Size = New System.Drawing.Size(878, 197)
        Me.gbxInfBasicaEstudios.TabIndex = 15
        Me.gbxInfBasicaEstudios.Text = "Información Basica"
        '
        'cbxTipoTiempo
        '
        Me.cbxTipoTiempo.EditValue = "Horas"
        Me.cbxTipoTiempo.Location = New System.Drawing.Point(513, 161)
        Me.cbxTipoTiempo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbxTipoTiempo.MenuManager = Me.BarManagerMenu
        Me.cbxTipoTiempo.Name = "cbxTipoTiempo"
        Me.cbxTipoTiempo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.cbxTipoTiempo.Properties.Appearance.Options.UseFont = True
        Me.cbxTipoTiempo.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.cbxTipoTiempo.Properties.AppearanceDisabled.Options.UseFont = True
        Me.cbxTipoTiempo.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.cbxTipoTiempo.Properties.AppearanceDropDown.Options.UseFont = True
        Me.cbxTipoTiempo.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.cbxTipoTiempo.Properties.AppearanceFocused.Options.UseFont = True
        Me.cbxTipoTiempo.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.cbxTipoTiempo.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.cbxTipoTiempo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbxTipoTiempo.Properties.Items.AddRange(New Object() {"Horas", "Meses", "Años"})
        Me.cbxTipoTiempo.Size = New System.Drawing.Size(125, 24)
        Me.cbxTipoTiempo.TabIndex = 6
        '
        'ndDuracion
        '
        Me.ndDuracion.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ndDuracion.Location = New System.Drawing.Point(449, 162)
        Me.ndDuracion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ndDuracion.Name = "ndDuracion"
        Me.ndDuracion.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.ndDuracion.Properties.Appearance.Options.UseFont = True
        Me.ndDuracion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ndDuracion.Size = New System.Drawing.Size(57, 24)
        Me.ndDuracion.TabIndex = 5
        '
        'lblDuracion
        '
        Me.lblDuracion.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDuracion.Appearance.Options.UseFont = True
        Me.lblDuracion.Appearance.Options.UseTextOptions = True
        Me.lblDuracion.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblDuracion.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblDuracion.Location = New System.Drawing.Point(358, 159)
        Me.lblDuracion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblDuracion.Name = "lblDuracion"
        Me.lblDuracion.Padding = New System.Windows.Forms.Padding(2)
        Me.lblDuracion.Size = New System.Drawing.Size(84, 32)
        Me.lblDuracion.TabIndex = 72
        Me.lblDuracion.Text = "Duración :"
        '
        'lblTipoEducacion
        '
        Me.lblTipoEducacion.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lblTipoEducacion.Appearance.Options.UseFont = True
        Me.lblTipoEducacion.Appearance.Options.UseTextOptions = True
        Me.lblTipoEducacion.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblTipoEducacion.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblTipoEducacion.Location = New System.Drawing.Point(64, 26)
        Me.lblTipoEducacion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblTipoEducacion.Name = "lblTipoEducacion"
        Me.lblTipoEducacion.Padding = New System.Windows.Forms.Padding(2)
        Me.lblTipoEducacion.Size = New System.Drawing.Size(135, 32)
        Me.lblTipoEducacion.TabIndex = 71
        Me.lblTipoEducacion.Text = "Tipo de Educación :"
        '
        'lkeNivelEducativo
        '
        Me.lkeNivelEducativo.Location = New System.Drawing.Point(205, 60)
        Me.lkeNivelEducativo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lkeNivelEducativo.Name = "lkeNivelEducativo"
        Me.lkeNivelEducativo.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.lkeNivelEducativo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeNivelEducativo.Properties.Appearance.Options.UseFont = True
        Me.lkeNivelEducativo.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeNivelEducativo.Properties.AppearanceDisabled.Options.UseFont = True
        Me.lkeNivelEducativo.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeNivelEducativo.Properties.AppearanceDropDown.Options.UseFont = True
        Me.lkeNivelEducativo.Properties.AppearanceDropDownHeader.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeNivelEducativo.Properties.AppearanceDropDownHeader.Options.UseFont = True
        Me.lkeNivelEducativo.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeNivelEducativo.Properties.AppearanceFocused.Options.UseFont = True
        Me.lkeNivelEducativo.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeNivelEducativo.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.lkeNivelEducativo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkeNivelEducativo.Properties.CloseUpKey = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.Right)
        Me.lkeNivelEducativo.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "Codigo", 23, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Descripcion", 23, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.lkeNivelEducativo.Properties.NullText = "Seleccione..."
        Me.lkeNivelEducativo.Properties.ShowFooter = False
        Me.lkeNivelEducativo.Properties.ShowHeader = False
        Me.lkeNivelEducativo.Size = New System.Drawing.Size(386, 24)
        Me.lkeNivelEducativo.TabIndex = 1
        '
        'grbTipoEducacion
        '
        Me.grbTipoEducacion.EditValue = False
        Me.grbTipoEducacion.Location = New System.Drawing.Point(205, 28)
        Me.grbTipoEducacion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grbTipoEducacion.Name = "grbTipoEducacion"
        Me.grbTipoEducacion.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.grbTipoEducacion.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.grbTipoEducacion.Properties.Appearance.Options.UseBackColor = True
        Me.grbTipoEducacion.Properties.Appearance.Options.UseFont = True
        Me.grbTipoEducacion.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.grbTipoEducacion.Properties.Columns = 2
        Me.grbTipoEducacion.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.grbTipoEducacion.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "No Formal"), New DevExpress.XtraEditors.Controls.RadioGroupItem(True, "Formal")})
        Me.grbTipoEducacion.Size = New System.Drawing.Size(230, 23)
        Me.grbTipoEducacion.TabIndex = 70
        Me.grbTipoEducacion.TabStop = False
        '
        'btnAddTitulo
        '
        Me.btnAddTitulo.AllowFocus = False
        Me.btnAddTitulo.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnAddTitulo.Appearance.Options.UseFont = True
        Me.btnAddTitulo.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnAddTitulo.Location = New System.Drawing.Point(598, 91)
        Me.btnAddTitulo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAddTitulo.Name = "btnAddTitulo"
        Me.btnAddTitulo.Size = New System.Drawing.Size(40, 31)
        Me.btnAddTitulo.TabIndex = 69
        '
        'btnAddNivelEducativo
        '
        Me.btnAddNivelEducativo.AllowFocus = False
        Me.btnAddNivelEducativo.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnAddNivelEducativo.Appearance.Options.UseFont = True
        Me.btnAddNivelEducativo.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnAddNivelEducativo.Location = New System.Drawing.Point(598, 58)
        Me.btnAddNivelEducativo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAddNivelEducativo.Name = "btnAddNivelEducativo"
        Me.btnAddNivelEducativo.Size = New System.Drawing.Size(40, 31)
        Me.btnAddNivelEducativo.TabIndex = 68
        '
        'lblTituloObtenido
        '
        Me.lblTituloObtenido.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lblTituloObtenido.Appearance.Options.UseFont = True
        Me.lblTituloObtenido.Appearance.Options.UseTextOptions = True
        Me.lblTituloObtenido.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblTituloObtenido.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblTituloObtenido.Location = New System.Drawing.Point(27, 91)
        Me.lblTituloObtenido.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblTituloObtenido.Name = "lblTituloObtenido"
        Me.lblTituloObtenido.Padding = New System.Windows.Forms.Padding(2)
        Me.lblTituloObtenido.Size = New System.Drawing.Size(173, 32)
        Me.lblTituloObtenido.TabIndex = 27
        Me.lblTituloObtenido.Text = "Título Obtenido :"
        '
        'lkeTituloObtenido
        '
        Me.lkeTituloObtenido.Location = New System.Drawing.Point(205, 95)
        Me.lkeTituloObtenido.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lkeTituloObtenido.Name = "lkeTituloObtenido"
        Me.lkeTituloObtenido.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.lkeTituloObtenido.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeTituloObtenido.Properties.Appearance.Options.UseFont = True
        Me.lkeTituloObtenido.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeTituloObtenido.Properties.AppearanceDisabled.Options.UseFont = True
        Me.lkeTituloObtenido.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeTituloObtenido.Properties.AppearanceDropDown.Options.UseFont = True
        Me.lkeTituloObtenido.Properties.AppearanceDropDownHeader.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeTituloObtenido.Properties.AppearanceDropDownHeader.Options.UseFont = True
        Me.lkeTituloObtenido.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeTituloObtenido.Properties.AppearanceFocused.Options.UseFont = True
        Me.lkeTituloObtenido.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeTituloObtenido.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.lkeTituloObtenido.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkeTituloObtenido.Properties.CloseUpKey = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.Right)
        Me.lkeTituloObtenido.Properties.NullText = "Seleccione..."
        Me.lkeTituloObtenido.Properties.ShowFooter = False
        Me.lkeTituloObtenido.Properties.ShowHeader = False
        Me.lkeTituloObtenido.Size = New System.Drawing.Size(386, 24)
        Me.lkeTituloObtenido.TabIndex = 2
        '
        'lblNivelEducativo
        '
        Me.lblNivelEducativo.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lblNivelEducativo.Appearance.Options.UseFont = True
        Me.lblNivelEducativo.Appearance.Options.UseTextOptions = True
        Me.lblNivelEducativo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblNivelEducativo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblNivelEducativo.Location = New System.Drawing.Point(27, 57)
        Me.lblNivelEducativo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblNivelEducativo.Name = "lblNivelEducativo"
        Me.lblNivelEducativo.Padding = New System.Windows.Forms.Padding(2)
        Me.lblNivelEducativo.Size = New System.Drawing.Size(173, 32)
        Me.lblNivelEducativo.TabIndex = 25
        Me.lblNivelEducativo.Text = "Nivel Educativo :"
        '
        'gbxLugarObtTitulo
        '
        Me.gbxLugarObtTitulo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxLugarObtTitulo.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.gbxLugarObtTitulo.AppearanceCaption.Options.UseFont = True
        Me.gbxLugarObtTitulo.Controls.Add(Me.lkePaisObtTitulo)
        Me.gbxLugarObtTitulo.Controls.Add(Me.lblMuniObtTitulo)
        Me.gbxLugarObtTitulo.Controls.Add(Me.lkeMuniObtTitulo)
        Me.gbxLugarObtTitulo.Controls.Add(Me.lblPaisObtTitulo)
        Me.gbxLugarObtTitulo.Controls.Add(Me.lblDepObtTitulo)
        Me.gbxLugarObtTitulo.Controls.Add(Me.lkeDepObtTitulo)
        Me.gbxLugarObtTitulo.Controls.Add(Me.lblFechaGrado)
        Me.gbxLugarObtTitulo.Controls.Add(Me.dteFechaGrado)
        Me.gbxLugarObtTitulo.Location = New System.Drawing.Point(647, 33)
        Me.gbxLugarObtTitulo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbxLugarObtTitulo.Name = "gbxLugarObtTitulo"
        Me.gbxLugarObtTitulo.Padding = New System.Windows.Forms.Padding(6)
        Me.gbxLugarObtTitulo.Size = New System.Drawing.Size(225, 153)
        Me.gbxLugarObtTitulo.TabIndex = 80
        Me.gbxLugarObtTitulo.Text = "Lugar donde Obtuvo Título"
        '
        'lkePaisObtTitulo
        '
        Me.lkePaisObtTitulo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lkePaisObtTitulo.Location = New System.Drawing.Point(142, 32)
        Me.lkePaisObtTitulo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lkePaisObtTitulo.Name = "lkePaisObtTitulo"
        Me.lkePaisObtTitulo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkePaisObtTitulo.Properties.Appearance.Options.UseFont = True
        Me.lkePaisObtTitulo.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkePaisObtTitulo.Properties.AppearanceDisabled.Options.UseFont = True
        Me.lkePaisObtTitulo.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkePaisObtTitulo.Properties.AppearanceDropDown.Options.UseFont = True
        Me.lkePaisObtTitulo.Properties.AppearanceDropDownHeader.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkePaisObtTitulo.Properties.AppearanceDropDownHeader.Options.UseFont = True
        Me.lkePaisObtTitulo.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkePaisObtTitulo.Properties.AppearanceFocused.Options.UseFont = True
        Me.lkePaisObtTitulo.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkePaisObtTitulo.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.lkePaisObtTitulo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkePaisObtTitulo.Properties.CloseUpKey = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.Right)
        Me.lkePaisObtTitulo.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "Codigo", 23, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Descripcion", 23, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.lkePaisObtTitulo.Properties.NullText = "Seleccione..."
        Me.lkePaisObtTitulo.Size = New System.Drawing.Size(77, 24)
        Me.lkePaisObtTitulo.TabIndex = 7
        '
        'lblMuniObtTitulo
        '
        Me.lblMuniObtTitulo.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lblMuniObtTitulo.Appearance.Options.UseFont = True
        Me.lblMuniObtTitulo.Appearance.Options.UseTextOptions = True
        Me.lblMuniObtTitulo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblMuniObtTitulo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblMuniObtTitulo.Location = New System.Drawing.Point(12, 87)
        Me.lblMuniObtTitulo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblMuniObtTitulo.Name = "lblMuniObtTitulo"
        Me.lblMuniObtTitulo.Padding = New System.Windows.Forms.Padding(2)
        Me.lblMuniObtTitulo.Size = New System.Drawing.Size(124, 32)
        Me.lblMuniObtTitulo.TabIndex = 23
        Me.lblMuniObtTitulo.Text = "Municipio :"
        '
        'lkeMuniObtTitulo
        '
        Me.lkeMuniObtTitulo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lkeMuniObtTitulo.Location = New System.Drawing.Point(142, 91)
        Me.lkeMuniObtTitulo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lkeMuniObtTitulo.Name = "lkeMuniObtTitulo"
        Me.lkeMuniObtTitulo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeMuniObtTitulo.Properties.Appearance.Options.UseFont = True
        Me.lkeMuniObtTitulo.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeMuniObtTitulo.Properties.AppearanceDisabled.Options.UseFont = True
        Me.lkeMuniObtTitulo.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeMuniObtTitulo.Properties.AppearanceDropDown.Options.UseFont = True
        Me.lkeMuniObtTitulo.Properties.AppearanceDropDownHeader.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeMuniObtTitulo.Properties.AppearanceDropDownHeader.Options.UseFont = True
        Me.lkeMuniObtTitulo.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeMuniObtTitulo.Properties.AppearanceFocused.Options.UseFont = True
        Me.lkeMuniObtTitulo.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeMuniObtTitulo.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.lkeMuniObtTitulo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkeMuniObtTitulo.Properties.CloseUpKey = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.Right)
        Me.lkeMuniObtTitulo.Properties.NullText = "Seleccione..."
        Me.lkeMuniObtTitulo.Size = New System.Drawing.Size(77, 24)
        Me.lkeMuniObtTitulo.TabIndex = 9
        '
        'lblPaisObtTitulo
        '
        Me.lblPaisObtTitulo.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lblPaisObtTitulo.Appearance.Options.UseFont = True
        Me.lblPaisObtTitulo.Appearance.Options.UseTextOptions = True
        Me.lblPaisObtTitulo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblPaisObtTitulo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblPaisObtTitulo.Location = New System.Drawing.Point(12, 28)
        Me.lblPaisObtTitulo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblPaisObtTitulo.Name = "lblPaisObtTitulo"
        Me.lblPaisObtTitulo.Padding = New System.Windows.Forms.Padding(2)
        Me.lblPaisObtTitulo.Size = New System.Drawing.Size(125, 32)
        Me.lblPaisObtTitulo.TabIndex = 25
        Me.lblPaisObtTitulo.Text = "Pais :"
        '
        'lblDepObtTitulo
        '
        Me.lblDepObtTitulo.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lblDepObtTitulo.Appearance.Options.UseFont = True
        Me.lblDepObtTitulo.Appearance.Options.UseTextOptions = True
        Me.lblDepObtTitulo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblDepObtTitulo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblDepObtTitulo.Location = New System.Drawing.Point(7, 58)
        Me.lblDepObtTitulo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblDepObtTitulo.Name = "lblDepObtTitulo"
        Me.lblDepObtTitulo.Padding = New System.Windows.Forms.Padding(2)
        Me.lblDepObtTitulo.Size = New System.Drawing.Size(129, 32)
        Me.lblDepObtTitulo.TabIndex = 27
        Me.lblDepObtTitulo.Text = "Departamento :"
        '
        'lkeDepObtTitulo
        '
        Me.lkeDepObtTitulo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lkeDepObtTitulo.Location = New System.Drawing.Point(142, 62)
        Me.lkeDepObtTitulo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lkeDepObtTitulo.Name = "lkeDepObtTitulo"
        Me.lkeDepObtTitulo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeDepObtTitulo.Properties.Appearance.Options.UseFont = True
        Me.lkeDepObtTitulo.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeDepObtTitulo.Properties.AppearanceDisabled.Options.UseFont = True
        Me.lkeDepObtTitulo.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeDepObtTitulo.Properties.AppearanceDropDown.Options.UseFont = True
        Me.lkeDepObtTitulo.Properties.AppearanceDropDownHeader.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeDepObtTitulo.Properties.AppearanceDropDownHeader.Options.UseFont = True
        Me.lkeDepObtTitulo.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeDepObtTitulo.Properties.AppearanceFocused.Options.UseFont = True
        Me.lkeDepObtTitulo.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lkeDepObtTitulo.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.lkeDepObtTitulo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkeDepObtTitulo.Properties.CloseUpKey = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.Right)
        Me.lkeDepObtTitulo.Properties.NullText = "Seleccione..."
        Me.lkeDepObtTitulo.Size = New System.Drawing.Size(77, 24)
        Me.lkeDepObtTitulo.TabIndex = 8
        '
        'lblFechaGrado
        '
        Me.lblFechaGrado.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaGrado.Appearance.Options.UseFont = True
        Me.lblFechaGrado.Appearance.Options.UseTextOptions = True
        Me.lblFechaGrado.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblFechaGrado.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblFechaGrado.Location = New System.Drawing.Point(3, 118)
        Me.lblFechaGrado.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblFechaGrado.Name = "lblFechaGrado"
        Me.lblFechaGrado.Padding = New System.Windows.Forms.Padding(2)
        Me.lblFechaGrado.Size = New System.Drawing.Size(132, 32)
        Me.lblFechaGrado.TabIndex = 21
        Me.lblFechaGrado.Text = "Fecha de Grado :"
        '
        'dteFechaGrado
        '
        Me.dteFechaGrado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dteFechaGrado.EditValue = Nothing
        Me.dteFechaGrado.Location = New System.Drawing.Point(142, 122)
        Me.dteFechaGrado.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dteFechaGrado.Name = "dteFechaGrado"
        Me.dteFechaGrado.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.dteFechaGrado.Properties.Appearance.Options.UseFont = True
        Me.dteFechaGrado.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.dteFechaGrado.Properties.AppearanceDropDown.Options.UseFont = True
        Me.dteFechaGrado.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteFechaGrado.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteFechaGrado.Size = New System.Drawing.Size(77, 24)
        Me.dteFechaGrado.TabIndex = 10
        '
        'txtInstitucionObtTitulo
        '
        Me.txtInstitucionObtTitulo.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtInstitucionObtTitulo.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtInstitucionObtTitulo.AltodelControl = 30
        Me.txtInstitucionObtTitulo.AnchoLabel = 172
        Me.txtInstitucionObtTitulo.AutoSize = True
        Me.txtInstitucionObtTitulo.ColordeFondo = System.Drawing.Color.Transparent
        Me.txtInstitucionObtTitulo.EsObligatorio = False
        Me.txtInstitucionObtTitulo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInstitucionObtTitulo.FormatoNumero = Nothing
        Me.txtInstitucionObtTitulo.Location = New System.Drawing.Point(2, 124)
        Me.txtInstitucionObtTitulo.Margin = New System.Windows.Forms.Padding(5)
        Me.txtInstitucionObtTitulo.MaximoAncho = 0
        Me.txtInstitucionObtTitulo.MensajedeAyuda = "Nombre de la institución en la cual realizó los estudios. (ENTER,TAB,ABJ)=Avanzar" &
    ";(ARB,ESC)=Atras"
        Me.txtInstitucionObtTitulo.Name = "txtInstitucionObtTitulo"
        Me.txtInstitucionObtTitulo.Size = New System.Drawing.Size(640, 37)
        Me.txtInstitucionObtTitulo.SoloLectura = False
        Me.txtInstitucionObtTitulo.SoloNumeros = False
        Me.txtInstitucionObtTitulo.TabIndex = 3
        Me.txtInstitucionObtTitulo.TextodelControl = ""
        Me.txtInstitucionObtTitulo.TextoLabel = "Nombre de la Institución :"
        Me.txtInstitucionObtTitulo.TieneErrorControl = False
        Me.txtInstitucionObtTitulo.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtInstitucionObtTitulo.TipodeLetra = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtInstitucionObtTitulo.ValordelControl = Nothing
        Me.txtInstitucionObtTitulo.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtInstitucionObtTitulo.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtInstitucionObtTitulo.ValorPredeterminado = Nothing
        '
        'txtMatriculaProfesional
        '
        Me.txtMatriculaProfesional.AlineacionTexto = SamitCtlNet.AlinearTexto.Izquierda
        Me.txtMatriculaProfesional.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.txtMatriculaProfesional.AltodelControl = 30
        Me.txtMatriculaProfesional.AnchoLabel = 170
        Me.txtMatriculaProfesional.AutoSize = True
        Me.txtMatriculaProfesional.ColordeFondo = System.Drawing.Color.Transparent
        Me.txtMatriculaProfesional.EsObligatorio = False
        Me.txtMatriculaProfesional.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMatriculaProfesional.FormatoNumero = Nothing
        Me.txtMatriculaProfesional.Location = New System.Drawing.Point(3, 159)
        Me.txtMatriculaProfesional.Margin = New System.Windows.Forms.Padding(5)
        Me.txtMatriculaProfesional.MaximoAncho = 0
        Me.txtMatriculaProfesional.MensajedeAyuda = "Número de la matricula profesional, si el caso lo aplica. (ENTER,TAB,ABJ)=Avanzar" &
    ";(ARB,ESC)=Atras"
        Me.txtMatriculaProfesional.Name = "txtMatriculaProfesional"
        Me.txtMatriculaProfesional.Size = New System.Drawing.Size(348, 37)
        Me.txtMatriculaProfesional.SoloLectura = False
        Me.txtMatriculaProfesional.SoloNumeros = False
        Me.txtMatriculaProfesional.TabIndex = 4
        Me.txtMatriculaProfesional.TextodelControl = ""
        Me.txtMatriculaProfesional.TextoLabel = "Matricula Profesional :"
        Me.txtMatriculaProfesional.TieneErrorControl = False
        Me.txtMatriculaProfesional.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.txtMatriculaProfesional.TipodeLetra = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMatriculaProfesional.ValordelControl = Nothing
        Me.txtMatriculaProfesional.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtMatriculaProfesional.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtMatriculaProfesional.ValorPredeterminado = Nothing
        '
        'MenuGaleriaImagenes
        '
        Me.MenuGaleriaImagenes.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnQuitarImageGaleria)})
        Me.MenuGaleriaImagenes.Manager = Me.BarManagerMenu
        Me.MenuGaleriaImagenes.Name = "MenuGaleriaImagenes"
        '
        'btnImprimir
        '
        Me.btnImprimir.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnImprimir.Appearance.Options.UseFont = True
        Me.btnImprimir.Location = New System.Drawing.Point(6, 286)
        Me.btnImprimir.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(96, 57)
        Me.btnImprimir.TabIndex = 72
        Me.btnImprimir.Text = "Imprimir"
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Location = New System.Drawing.Point(6, 350)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(96, 57)
        Me.btnSalir.TabIndex = 73
        Me.btnSalir.Text = "Salir"
        '
        'btnEliminar
        '
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Location = New System.Drawing.Point(6, 222)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(96, 57)
        Me.btnEliminar.TabIndex = 71
        Me.btnEliminar.Text = "Eliminar"
        '
        'btnAmpliaImagenes
        '
        Me.btnAmpliaImagenes.Appearance.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.btnAmpliaImagenes.Appearance.Options.UseFont = True
        Me.btnAmpliaImagenes.Location = New System.Drawing.Point(6, 158)
        Me.btnAmpliaImagenes.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAmpliaImagenes.Name = "btnAmpliaImagenes"
        Me.btnAmpliaImagenes.Size = New System.Drawing.Size(96, 57)
        Me.btnAmpliaImagenes.TabIndex = 70
        Me.btnAmpliaImagenes.Text = "Ampliar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Imagenes"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnLimpiar.Appearance.Options.UseFont = True
        Me.btnLimpiar.Location = New System.Drawing.Point(6, 94)
        Me.btnLimpiar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(96, 57)
        Me.btnLimpiar.TabIndex = 68
        Me.btnLimpiar.Text = "Limpiar"
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Location = New System.Drawing.Point(6, 30)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(96, 57)
        Me.btnGuardar.TabIndex = 67
        Me.btnGuardar.Text = "Guardar"
        '
        'gbxOpciones
        '
        Me.gbxOpciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxOpciones.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.gbxOpciones.AppearanceCaption.Options.UseFont = True
        Me.gbxOpciones.AppearanceCaption.Options.UseTextOptions = True
        Me.gbxOpciones.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gbxOpciones.Controls.Add(Me.btnGuardar)
        Me.gbxOpciones.Controls.Add(Me.btnImprimir)
        Me.gbxOpciones.Controls.Add(Me.btnLimpiar)
        Me.gbxOpciones.Controls.Add(Me.btnSalir)
        Me.gbxOpciones.Controls.Add(Me.btnEliminar)
        Me.gbxOpciones.Controls.Add(Me.btnAmpliaImagenes)
        Me.gbxOpciones.Location = New System.Drawing.Point(1109, 15)
        Me.gbxOpciones.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbxOpciones.Name = "gbxOpciones"
        Me.gbxOpciones.Size = New System.Drawing.Size(111, 594)
        Me.gbxOpciones.TabIndex = 2
        Me.gbxOpciones.Text = "Opciones"
        '
        'FrmEmpleado
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1227, 624)
        Me.Controls.Add(Me.gbxOpciones)
        Me.Controls.Add(Me.tcEmpleados)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.IconOptions.Icon = CType(resources.GetObject("FrmEmpleado.IconOptions.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmEmpleado"
        Me.Text = "Empleados"
        CType(Me.tcEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tcEmpleados.ResumeLayout(False)
        Me.tpDatosBasicos.ResumeLayout(False)
        CType(Me.lcPrincipalDatosBasicos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lcPrincipalDatosBasicos.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.lkeClaseLibreta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtComentario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManagerMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcExpDocNacEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lcExpDocNacEmpleado.ResumeLayout(False)
        CType(Me.gbxLugarNacimiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxLugarNacimiento.ResumeLayout(False)
        CType(Me.lkePaisNacimiento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkeMuniNacimiento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkeDepNacimiento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFechaNacimiento.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFechaNacimiento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gbxExpDocumento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxExpDocumento.ResumeLayout(False)
        CType(Me.dteFechaExpDocumento.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFechaExpDocumento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkePaisExpDocumento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkeMuniExpDocumento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkeDepExpDocumento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcgExpDocNacEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciExpDocEmp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciLugarNacEmp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gbxLugarResidencia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxLugarResidencia.ResumeLayout(False)
        Me.gbxLugarResidencia.PerformLayout()
        CType(Me.lkePaisResidencia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkeMuniResidencia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkeDepResidencia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gbxImgFotoEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxImgFotoEmpleado.ResumeLayout(False)
        CType(Me.pcbFotografiaEmpleado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.txtDigitoV.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDocEmpleado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.lcDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lcDatos.ResumeLayout(False)
        CType(Me.ndPersonaAcargo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcgDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciTxtPnombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciTxtSnombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciTxtPapellido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciSapellido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciTxtTel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciTxtTel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciTxtCel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciNdPerAcargo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciLblPersonasAcargo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grTipoCuenta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcgPrincipalDatosBasicos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciNumDocDVbtnBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciDatosBasicosIzq, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciDatsoBasicosDer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpAfiliaciones.ResumeLayout(False)
        CType(Me.gbxImagenesAfiliacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxImagenesAfiliacion.ResumeLayout(False)
        CType(Me.GalleryControlAfiliaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GalleryControlAfiliaciones.ResumeLayout(False)
        CType(Me.gbxInfAfiliaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxInfAfiliaciones.ResumeLayout(False)
        Me.gbxInfAfiliaciones.PerformLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.txtCausaRetiroEntidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFechaRegistroEmpEntidad.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFechaRegistroEmpEntidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgbEmpRetiradoEntidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gbxGrillaAfiliaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxGrillaAfiliaciones.ResumeLayout(False)
        CType(Me.gcAfiliaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvAfilicaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpFamiliares.ResumeLayout(False)
        CType(Me.gbxImgFamiliar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxImgFamiliar.ResumeLayout(False)
        CType(Me.pcbImgFamiliar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gbxGrillaFamiliares, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxGrillaFamiliares.ResumeLayout(False)
        CType(Me.gcFamiliares, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvFamiliares, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gbxInfFamiliar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxInfFamiliar.ResumeLayout(False)
        Me.gbxInfFamiliar.PerformLayout()
        CType(Me.lkeParentescoFamiliar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkeTipoDocFamiliar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFecNacFamiliar.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFecNacFamiliar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gbxUbicacionEmpTrabajaEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxUbicacionEmpTrabajaEmpleado.ResumeLayout(False)
        CType(Me.lkePaisEmpTrabajaFamiliar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkeMuniEmpTrabajaFamiliar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkeDepEmpTrabajaFamiliar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpExpLaboral.ResumeLayout(False)
        CType(Me.gbxCertExpLab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxCertExpLab.ResumeLayout(False)
        CType(Me.GalleryControlExpLaboral, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GalleryControlExpLaboral.ResumeLayout(False)
        CType(Me.gbxGrillaExpLab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxGrillaExpLab.ResumeLayout(False)
        CType(Me.gcExpLaboral, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvExpLaboral, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gbxInfBasicaExpLab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxInfBasicaExpLab.ResumeLayout(False)
        Me.gbxInfBasicaExpLab.PerformLayout()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFecRetiroExpLab.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFecRetiroExpLab.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFecIngresoExpLab.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFecIngresoExpLab.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpInfAcademica.ResumeLayout(False)
        CType(Me.gbxCertEstudios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxCertEstudios.ResumeLayout(False)
        CType(Me.GalleryControlEstudios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GalleryControlEstudios.ResumeLayout(False)
        CType(Me.gbxGrillaInfAcademica, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxGrillaInfAcademica.ResumeLayout(False)
        CType(Me.gcEstudios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvEstudios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gbxInfBasicaEstudios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxInfBasicaEstudios.ResumeLayout(False)
        Me.gbxInfBasicaEstudios.PerformLayout()
        CType(Me.cbxTipoTiempo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ndDuracion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkeNivelEducativo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grbTipoEducacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkeTituloObtenido.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gbxLugarObtTitulo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxLugarObtTitulo.ResumeLayout(False)
        CType(Me.lkePaisObtTitulo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkeMuniObtTitulo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkeDepObtTitulo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFechaGrado.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFechaGrado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuGaleriaImagenes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gbxOpciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxOpciones.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tcEmpleados As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tpDatosBasicos As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tpExpLaboral As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tpAfiliaciones As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tpFamiliares As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tpInfAcademica As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtDigitoV As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dteFechaNacimiento As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lblFechaNac As DevExpress.XtraEditors.LabelControl
    Friend WithEvents pcbFotografiaEmpleado As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents gbxLugarResidencia As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lkePaisResidencia As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblMuniResidencia As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkeMuniResidencia As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lkeDepResidencia As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblPaisResidencia As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblDepResidencia As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gbxExpDocumento As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblFechaExpDoc As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dteFechaExpDocumento As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lkePaisExpDocumento As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblMuniExpDoc As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkeMuniExpDocumento As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblPaisExpDoc As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblDepExpDoc As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkeDepExpDocumento As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents gbxLugarNacimiento As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lkePaisNacimiento As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblMuniNac As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkeMuniNacimiento As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblPaisNac As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblDepNac As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkeDepNacimiento As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents ndPersonaAcargo As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents lblPersonasAcargo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnBuscarEmp As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblDigitoVer As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSegNombre As SamitCtlNet.SamitTexto
    Friend WithEvents txtEmail2 As SamitCtlNet.SamitTexto
    Friend WithEvents txtEmail1 As SamitCtlNet.SamitTexto
    Friend WithEvents txtTel2 As SamitCtlNet.SamitTexto
    Friend WithEvents txtTel1 As SamitCtlNet.SamitTexto
    Friend WithEvents txtWebPage As SamitCtlNet.SamitTexto
    Friend WithEvents txtCelular As SamitCtlNet.SamitTexto
    Friend WithEvents txtSegApell As SamitCtlNet.SamitTexto
    Friend WithEvents txtPrimerApell As SamitCtlNet.SamitTexto
    Friend WithEvents txtPrimerNombre As SamitCtlNet.SamitTexto
    Friend WithEvents txtDistritoMil As SamitCtlNet.SamitTexto
    Friend WithEvents txtNumLibreta As SamitCtlNet.SamitTexto
    Friend WithEvents txtNumLicencia As SamitCtlNet.SamitTexto
    Friend WithEvents txtDireccion As SamitCtlNet.SamitTexto
    Friend WithEvents txtBarrio As SamitCtlNet.SamitTexto
    Friend WithEvents lblDocEmpleado As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDocEmpleado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtJefeExplab As SamitCtlNet.SamitTexto
    Friend WithEvents txtDirEmpExpLab As SamitCtlNet.SamitTexto
    Friend WithEvents txtTelEmpExpLab As SamitCtlNet.SamitTexto
    Friend WithEvents txtCargoExpLab As SamitCtlNet.SamitTexto
    Friend WithEvents txtEmpresaExpLab As SamitCtlNet.SamitTexto
    Friend WithEvents gcExpLaboral As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvExpLaboral As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GalleryControlExpLaboral As DevExpress.XtraBars.Ribbon.GalleryControl
    Friend WithEvents GalleryControlClient1 As DevExpress.XtraBars.Ribbon.GalleryControlClient
    Friend WithEvents gbxCertExpLab As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gbxGrillaExpLab As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gbxInfBasicaExpLab As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblFechaRetiroExpLab As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dteFecRetiroExpLab As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lblFechaIngresoExpLab As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dteFecIngresoExpLab As DevExpress.XtraEditors.DateEdit
    Friend WithEvents SeparatorControl1 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents MenuGaleriaImagenes As DevExpress.XtraBars.PopupMenu
    Friend WithEvents btnQuitarImageGaleria As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarManagerMenu As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAmpliaImagenes As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnLimpiar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gbxCertEstudios As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GalleryControlEstudios As DevExpress.XtraBars.Ribbon.GalleryControl
    Friend WithEvents GalleryControlClient2 As DevExpress.XtraBars.Ribbon.GalleryControlClient
    Friend WithEvents gbxGrillaInfAcademica As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gcEstudios As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvEstudios As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gbxInfBasicaEstudios As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtMatriculaProfesional As SamitCtlNet.SamitTexto
    Friend WithEvents gbxLugarObtTitulo As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lkePaisObtTitulo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblMuniObtTitulo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkeMuniObtTitulo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblPaisObtTitulo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblDepObtTitulo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkeDepObtTitulo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblFechaGrado As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dteFechaGrado As DevExpress.XtraEditors.DateEdit
    Friend WithEvents btnAddTitulo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAddNivelEducativo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblTituloObtenido As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkeTituloObtenido As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblNivelEducativo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grbTipoEducacion As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents lkeNivelEducativo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtInstitucionObtTitulo As SamitCtlNet.SamitTexto
    Friend WithEvents cbxTipoTiempo As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents ndDuracion As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents lblDuracion As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblTipoEducacion As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gbxImgFotoEmpleado As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gbxImgFamiliar As DevExpress.XtraEditors.GroupControl
    Friend WithEvents pcbImgFamiliar As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents gbxGrillaFamiliares As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gcFamiliares As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvFamiliares As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gbxInfFamiliar As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lkeTipoDocFamiliar As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblParentescoFamiliar As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblTipoDocFamiliar As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gbxUbicacionEmpTrabajaEmpleado As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lkePaisEmpTrabajaFamiliar As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblMuniEmpTrabajaFamiliar As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkeMuniEmpTrabajaFamiliar As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblPaisEmpTrabajaFamiliar As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblDepEmpTrabajaFamiliar As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkeDepEmpTrabajaFamiliar As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblFecNacFamiliar As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dteFecNacFamiliar As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtDocFamiliar As SamitCtlNet.SamitTexto
    Friend WithEvents txtNombreFamiliar As SamitCtlNet.SamitTexto
    Friend WithEvents txtDirEmpTrabajaFamiliar As SamitCtlNet.SamitTexto
    Friend WithEvents txtTelsEmpTrabajaFamiliar As SamitCtlNet.SamitTexto
    Friend WithEvents txtCelFamiliar As SamitCtlNet.SamitTexto
    Friend WithEvents txtCargoFamiliar As SamitCtlNet.SamitTexto
    Friend WithEvents txtEmpresaTrabajaFamiliar As SamitCtlNet.SamitTexto
    Friend WithEvents txtOcupacionFamiliar As SamitCtlNet.SamitTexto
    Friend WithEvents lkeParentescoFamiliar As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents gbxGrillaAfiliaciones As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gcAfiliaciones As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvAfilicaciones As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gbxInfAfiliaciones As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtCausaRetiroEntidad As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents lblFechaRegistroEmpEntidad As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dteFechaRegistroEmpEntidad As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lblEmpRetiradoEntidad As DevExpress.XtraEditors.LabelControl
    Friend WithEvents rgbEmpRetiradoEntidad As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents btnImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtNumCuenta As SamitCtlNet.SamitTexto
    Friend WithEvents txtBanco As SamitCtlNet.SamitBusq
    Friend WithEvents grTipoCuenta As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents txtEstadoCivil As SamitCtlNet.SamitBusq
    Friend WithEvents txtProfesion As SamitCtlNet.SamitBusq
    Friend WithEvents txtGenero As SamitCtlNet.SamitBusq
    Friend WithEvents txtTipoDoc As SamitCtlNet.SamitBusq
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lcDatos As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents lcgDatos As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents lciTxtPnombre As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lciTxtSnombre As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lciTxtPapellido As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lciSapellido As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lciTxtTel1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lciTxtTel2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lciTxtCel As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lciNdPerAcargo As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lciLblPersonasAcargo As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtClaseLicencia As SamitCtlNet.SamitBusq
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lcPrincipalDatosBasicos As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents lcgPrincipalDatosBasicos As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents lciNumDocDVbtnBuscar As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lciDatosBasicosIzq As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lciDatsoBasicosDer As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents gbxOpciones As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gbxImagenesAfiliacion As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GalleryControlAfiliaciones As DevExpress.XtraBars.Ribbon.GalleryControl
    Friend WithEvents GalleryControlClient3 As DevExpress.XtraBars.Ribbon.GalleryControlClient
    Friend WithEvents lcExpDocNacEmpleado As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents lcgExpDocNacEmpleado As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents lciExpDocEmp As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lciLugarNacEmp As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lblComentarios As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtComentario As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents lblClaseLibreta As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkeClaseLibreta As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtEntidad As SamitCtlNet.SamitBusq
    Friend WithEvents txtTipoEntidad As SamitCtlNet.SamitBusq
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
End Class
