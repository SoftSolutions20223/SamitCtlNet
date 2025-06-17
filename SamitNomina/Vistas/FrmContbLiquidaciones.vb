Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Views.Grid
Imports SamitCtlNet
Imports SamitContab

Public Class FrmContbLiquidaciones

    Dim Año As String = ""
    Dim SecNomina As String = ""
    Dim SecLiquidacion As String = ""
    Dim SecLiquidacionContrato As String = ""
    Dim TipoLiquidacion As String = ""
    Dim DatosContabilizar As DataTable
    Dim ErroresValterc As New ClErrores
    Dim ErroresContab As New ClErrores
    Dim DocCruce As String = ""
    Dim lkEditCta As New RepositoryItemSearchLookUpEdit
    Dim lkEditNat As New RepositoryItemLookUpEdit
    Dim HDevExpre As New HelperDevExpress
    Dim HNomina As New HelperNomina

    Public Datos As New SamitCtlNet.SamitCtlNet
    Public Property PSecLiquidacion As String
        Get
            Return SecLiquidacion
        End Get
        Set(value As String)
            SecLiquidacion = value
        End Set
    End Property

    Public Property PTipoLiquida As String
        Get
            Return TipoLiquidacion
        End Get
        Set(value As String)
            TipoLiquidacion = value
        End Set
    End Property

    Public Property PSecNomina As String
        Get
            Return SecNomina
        End Get
        Set(value As String)
            SecNomina = value
        End Set
    End Property

    Public Property PAño As String
        Get
            Return Año
        End Get
        Set(value As String)
            Año = value
        End Set
    End Property

    Private Sub AcomodaForm()
        Try
            btnAceptar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Aceptar)
            btnCancelar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Cancelar)
            BtnExcell.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Excell_XlsX)
            btnAnular.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Anular)
            grbVista.SelectedIndex = 0
            gcConceptosCont.Visible = False
            If TipoLiquidacion <> "P" Then
                txtFormadePago.Visible = True
            Else
                txtFormadePago.Visible = False
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, " AcomodaForm")
        End Try
    End Sub

    Private Sub LimpiarTodosCampos()
        Try
            dteFecha.Text = ""
            txtOficina.ValordelControl = ""
            txtTipoComprobante.ValordelControl = ""
            txtCodComp.ValordelControl = ""
            gcConceptosCont.DataSource = Nothing
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, " AcomodaForm")
        End Try
    End Sub

    Private Sub FrmContbLiquidaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AcomodaForm()
        CreaGrillaTerceros()
        CreaGrilla()
        LlenaGrid()
        LlenaGridTerceros()
        AsignaScriptAcontroles()
        dteFecha.DateTime = Datos.Smt_FechaDeTrabajo
        Timer1.Enabled = True


    End Sub


    Private Sub CreaGrillaTerceros()
        Dim coloor As System.Drawing.Color = Color.White

        gvTerceros.OptionsView.ShowFooter = True
        gvTerceros.Columns.Clear()
        HDevExpre.CreaColumnasG(gvTerceros, "Tercero", "CC Tercero", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), True, False, 20, gcConceptosCont.Width,,,,,,,,,, False,,,,, True)
        HDevExpre.CreaColumnasG(gvTerceros, "NomTercero", "Tercero", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), True, False, 40, gcConceptosCont.Width,,,,,,,,,, False,,,,, True)
        HDevExpre.CreaColumnasG(gvTerceros, "DocumentoContable", "Doc Contable", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), True, False, 20, gcConceptosCont.Width,,,,,,,,,, False,,,,, True)
        HDevExpre.CreaColumnasG(gvTerceros, "EstadoCont", "Estado", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), True, False, 20, gcConceptosCont.Width,,,,,,,,,, False,,,,, True)
        gvTerceros.Appearance.HeaderPanel.Font = New Font("Trebuchet MS", 11.0!, FontStyle.Bold)
        gvTerceros.Appearance.ViewCaption.Options.UseTextOptions = True
        gvTerceros.OptionsFind.AllowFindPanel = True
        gvTerceros.OptionsMenu.EnableColumnMenu = True

        gvTerceros.OptionsFilter.AllowColumnMRUFilterList = True
        gvTerceros.OptionsFilter.ShowCustomFunctions = DevExpress.Utils.DefaultBoolean.Default
        gvTerceros.OptionsFilter.ColumnFilterPopupMode = DevExpress.XtraGrid.Columns.ColumnFilterPopupMode.Classic
        gvTerceros.IndicatorWidth = 50

    End Sub

    Private Sub CreaGrilla()
        Dim coloor As System.Drawing.Color = Color.White

        gvConceptos.OptionsView.ShowFooter = True
        gvConceptos.Columns.Clear()
        HDevExpre.CreaColumnasG(gvConceptos, "Oficina", "Oficina", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 80, gcConceptosCont.Width,,,,,,,,,, True)
        HDevExpre.CreaColumnasG(gvConceptos, "Tercero", "Tercero", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), True, False, 120, gcConceptosCont.Width,,,,,,,,,, True,,,,, True)
        HDevExpre.CreaColumnasG(gvConceptos, "Item", "# Item", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 80, gcConceptosCont.Width,,,,,,,,,, True)
        HDevExpre.CreaColumnasG(gvConceptos, "TerceroMov", "TerceroMov", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), True, False, 120, gcConceptosCont.Width,,,,,,,,,, True,,,,, True)
        HDevExpre.CreaColumnasG(gvConceptos, "Cuenta", "Cuenta", True, True, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 120, gcConceptosCont.Width,,,,,,,,,, True,,,,, True,,,, lkEditCta)
        HDevExpre.CreaColumnasG(gvConceptos, "Ccosto", "Ccosto", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 80, gcConceptosCont.Width,,,,,,,,,, True,,,,, True)
        HDevExpre.CreaColumnasG(gvConceptos, "TextoDetalle", "Detalle", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 250, gcConceptosCont.Width,,,,,,,,,, True)
        HDevExpre.CreaColumnasG(gvConceptos, "Nat", "Nat.(D/C)", True, True, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 80, gcConceptosCont.Width,,,,,,,,,, True,,,, lkEditNat)
        HDevExpre.CreaColumnasG(gvConceptos, "Valor", "Valor", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), True, True, 120, gcConceptosCont.Width,,,,,,,,,, True,,,,, True)
        HDevExpre.CreaColumnasG(gvConceptos, "ValorDB", "ValorDB", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), True, True, 120, gcConceptosCont.Width,,,,,,,,,, True,,,,, True)
        HDevExpre.CreaColumnasG(gvConceptos, "ValorCR", "ValorCR", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), True, True, 120, gcConceptosCont.Width,,,,,,,,,, True,,,,, True)
        HDevExpre.CreaColumnasG(gvConceptos, "Factura", "Factura", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 120, gcConceptosCont.Width,,,,,,,,,, True)
        HDevExpre.CreaColumnasG(gvConceptos, "Cuota", "Cuota", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), True, False, 80, gcConceptosCont.Width,,,,,,,,,, True)
        HDevExpre.CreaColumnasG(gvConceptos, "BaseRete", "BaseRete", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 120, gcConceptosCont.Width,,,,,,,,,, True)
        HDevExpre.CreaColumnasG(gvConceptos, "ConceptoRete", "ConceptoRete", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 120, gcConceptosCont.Width,,,,,,,,,, True)
        'SMT_MapeaGridTotales(gvConceptos, 9, DevExpress.Data.SummaryItemType.Sum, "")
        'SMT_MapeaGridTotales(gvConceptos, 10, DevExpress.Data.SummaryItemType.Sum, "")
        gvConceptos.Columns(8).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        gvConceptos.Columns(9).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        gvConceptos.Columns(10).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        gvConceptos.Appearance.HeaderPanel.Font = New Font("Trebuchet MS", 11.0!, FontStyle.Bold)
        gvConceptos.Appearance.ViewCaption.Options.UseTextOptions = True
        gvConceptos.OptionsFind.AllowFindPanel = True
        gvConceptos.OptionsMenu.EnableColumnMenu = True

        gvConceptos.OptionsFilter.AllowColumnMRUFilterList = True
        gvConceptos.OptionsFilter.ShowCustomFunctions = DevExpress.Utils.DefaultBoolean.Default
        gvConceptos.OptionsFilter.ColumnFilterPopupMode = DevExpress.XtraGrid.Columns.ColumnFilterPopupMode.Classic
        gvConceptos.IndicatorWidth = 50
        'Dim XX As ColumnView = gvConceptos.Columns(3).View
        'XX.ShowFilterPopup(gvConceptos.Columns(3))

    End Sub


    Public Sub LlenaGrid()
        On Error GoTo CtlErr
        Dim Sql As String = "", NombreBD As String = "E" + Datos.Seguridad.DatosDeLaEmpresa.NumEmpresa.ToString("000") + Year(Datos.Smt_FechaDeTrabajo).ToString("0000")
        If TipoLiquidacion = "P" Then
            Sql =
"
Select '' as UsuarioCrea, PF.FormaPago, NLC.Sec as SecLiquidacionContrato, CN.Orden, C.Oficina As Oficina, Case When CN.EsRetencion= 0 Then '' Else CAST(CCN.ConceptoR AS varchar) End As ConceptoRete,
Case When CN.EsRetencion= 0 Then '' Else CAST(NLCC.Valor AS varchar) End As BaseRete, '1' As Cuota,'' As Factura, E.Identificacion as Tercero,
E.Identificacion as TerceroMov,
C.CodContrato as Contrato, NLCC.NomConcepto as TextoDetalle,
Case when PF.MovsTercerosIngresos=1 then isnull(CCN.CuentaContable,'') else case when CN.Fondo<>0 and PF.MovsEntSeguridadSIngresos =1 and CN.Clasificacion=1 then isnull(Cuentas.CuentaC,'')+'+'+ CAST( Cuentas.Nit as varchar)
when CN.Fondo<>0 and PF.MovsEntPrestSIngresos =1 and CN.Clasificacion=2 then isnull(Cuentas.CuentaC,'')+'+'+ CAST( Cuentas.Nit as varchar)
when CN.Fondo<>0 and PF.MovsEntAportesParaIngresos =1 and CN.Clasificacion=3 then isnull(Cuentas.CuentaC,'')+'+'+ CAST( Cuentas.Nit as varchar)
when CN.Fondo<>0 and PF.MovsEntNominaIngresos =1 and CN.Clasificacion=4 then isnull(Cuentas.CuentaC,'')+'+'+ CAST( Cuentas.Nit as varchar)
else isnull(CCN.CuentaContable,'') end end as CuentaContable,
CAST(NLCC.Valor AS DECIMAL) as Valor, CCN.Naturaleza As NatCuenta 
From NominaLiquidadaConceptos NLCC INNER Join NominaLiquidadaContratos NLC ON NLCC.LiquidadaContrato = NLC.Sec INNER Join NominaLiquidada NL ON NLC.NominaLiquidada = NL.Sec 
INNER JOIN Contratos C ON NLC.Contrato = C.CodContrato INNER Join Empleados E ON C.Empleado = E.IdEmpleado INNER JOIN ConceptosNomina CN ON NLCC.SecConcepto = CN.Sec 
INNER JOIN ClasConceptosNomina CLCN ON CLCN.Sec = CN.Clasificacion
Left Join(Select ENT.CuentaPasivo As CuentaC, ET.Empleado As Empleado, ENT.TipoEnte As TipoEnte, ENT.Nit From EntesSSAP ENT INNER JOIN EntesTercero ET On ET.SecEntesSSAP = ENT.Sec 
INNER JOIN Empleados EM On ET.Empleado = EM.IdEmpleado WHERE ET.Retirado=0 ) As Cuentas ON Cuentas.Empleado = E.IdEmpleado And Cuentas.TipoEnte =CN.Fondo
INNER JOIN PerfilesCta PF ON C.PerfilCuentas=PF.Sec INNER Join Conceptos_PerfilCta CCN ON CCN.Concepto = CN.Sec and CCN.PerfilCta = PF.Sec
WHERE NL.Sec ='" + PSecLiquidacion + "' and NLCC.Valor > 0  and CN.Tipo = 1 
Union 
Select  '' as UsuarioCrea, PF.FormaPago, NLC.Sec as SecLiquidacionContrato, CN.Orden, C.Oficina As Oficina, Case When CN.EsRetencion= 0 Then '' Else CAST(CCN.ConceptoR AS varchar) End As ConceptoRete,
Case When CN.EsRetencion= 0 Then '' Else CAST(NLCC.Valor AS varchar) End As BaseRete, '1' As Cuota,'' As Factura, E.Identificacion as Tercero,E.Identificacion as TerceroMov,
C.CodContrato as Contrato, NLCC.NomConcepto as TextoDetalle,
Case when PF.MovsTercerosDeducciones=1 then isnull(CCN.CuentaContable,'') else case when CN.Fondo<>0 and PF.MovsEntSeguridadSDeducciones =1 and CN.Clasificacion=1 then isnull(Cuentas.CuentaC,'')+'+'+ CAST( Cuentas.Nit as varchar)
when CN.Fondo<>0 and PF.MovsEntPrestSDeducciones =1 and CN.Clasificacion=2 then isnull(Cuentas.CuentaC,'')+'+'+ CAST( Cuentas.Nit as varchar)
when CN.Fondo<>0 and PF.MovsEntAportesParaDeducciones =1 and CN.Clasificacion=3 then isnull(Cuentas.CuentaC,'')+'+'+ CAST( Cuentas.Nit as varchar)
when CN.Fondo<>0 and PF.MovsEntNominaDeducciones =1 and CN.Clasificacion=4 then isnull(Cuentas.CuentaC,'')+'+'+ CAST( Cuentas.Nit as varchar)
else isnull(CCN.CuentaContable,'') end end as CuentaContable,
CAST(NLCC.Valor AS DECIMAL) as Valor, CCN.Naturaleza As NatCuenta 
From NominaLiquidadaConceptos NLCC INNER Join NominaLiquidadaContratos NLC ON NLCC.LiquidadaContrato = NLC.Sec INNER Join NominaLiquidada NL ON NLC.NominaLiquidada = NL.Sec 
INNER JOIN Contratos C ON NLC.Contrato = C.CodContrato INNER Join Empleados E ON C.Empleado = E.IdEmpleado INNER JOIN ConceptosNomina CN ON NLCC.SecConcepto = CN.Sec 
INNER JOIN ClasConceptosNomina CLCN ON CLCN.Sec = CN.Clasificacion
Left Join(Select ENT.CuentaPasivo As CuentaC, ET.Empleado As Empleado, ENT.TipoEnte As TipoEnte, ENT.Nit From EntesSSAP ENT INNER JOIN EntesTercero ET On ET.SecEntesSSAP = ENT.Sec 
INNER JOIN Empleados EM On ET.Empleado = EM.IdEmpleado WHERE ET.Retirado=0 ) As Cuentas ON Cuentas.Empleado = E.IdEmpleado And Cuentas.TipoEnte =CN.Fondo
INNER JOIN PerfilesCta PF ON C.PerfilCuentas=PF.Sec INNER Join Conceptos_PerfilCta CCN ON CCN.Concepto = CN.Sec and CCN.PerfilCta = PF.Sec
WHERE NL.Sec ='" + PSecLiquidacion + "'  and CN.Tipo = 2
union
Select  '' as UsuarioCrea, PF.FormaPago, NLC.Sec as SecLiquidacionContrato, CN.Orden, C.Oficina As Oficina, Case When CN.EsRetencion= 0 Then '' Else CAST(CCN.ConceptoR AS varchar) End As ConceptoRete,
Case When CN.EsRetencion= 0 Then '' Else CAST(NLCC.Valor AS varchar) End As BaseRete, '1' As Cuota,'' As Factura, E.Identificacion as Tercero,E.Identificacion as TerceroMov,
C.CodContrato as Contrato, NLCC.NomConcepto as TextoDetalle,
Case when PF.MovsTercerosProvisiones=1 then isnull(CCN.CuentaContable,'') else case when CN.Fondo<>0 and PF.MovsEntSeguridadSProvisiones =1 and CN.Clasificacion=1 then isnull(Cuentas.CuentaC,'')+'+'+ CAST( Cuentas.Nit as varchar)
when CN.Fondo<>0 and PF.MovsEntPrestSProvisiones =1 and CN.Clasificacion=2 then isnull(Cuentas.CuentaC,'')+'+'+ CAST( Cuentas.Nit as varchar)
when CN.Fondo<>0 and PF.MovsEntAportesParaProvisiones =1 and CN.Clasificacion=3 then isnull(Cuentas.CuentaC,'')+'+'+ CAST( Cuentas.Nit as varchar)
when CN.Fondo<>0 and PF.MovsEntNominaProvisiones =1 and CN.Clasificacion=4 then isnull(Cuentas.CuentaC,'')+'+'+ CAST( Cuentas.Nit as varchar)
else isnull(CCN.CuentaContable,'') end end as CuentaContable,
CAST(NLCC.Valor AS DECIMAL) as Valor, CCN.Naturaleza As NatCuenta 
From NominaLiquidadaConceptos NLCC INNER Join NominaLiquidadaContratos NLC ON NLCC.LiquidadaContrato = NLC.Sec INNER Join NominaLiquidada NL ON NLC.NominaLiquidada = NL.Sec 
INNER JOIN Contratos C ON NLC.Contrato = C.CodContrato INNER Join Empleados E ON C.Empleado = E.IdEmpleado INNER JOIN ConceptosNomina CN ON NLCC.SecConcepto = CN.Sec 
INNER JOIN ClasConceptosNomina CLCN ON CLCN.Sec = CN.Clasificacion
Left Join(Select ENT.CuentaPasivo As CuentaC, ET.Empleado As Empleado, ENT.TipoEnte As TipoEnte, ENT.Nit From EntesSSAP ENT INNER JOIN EntesTercero ET On ET.SecEntesSSAP = ENT.Sec 
INNER JOIN Empleados EM On ET.Empleado = EM.IdEmpleado WHERE ET.Retirado=0 ) As Cuentas ON Cuentas.Empleado = E.IdEmpleado And Cuentas.TipoEnte =CN.Fondo
INNER JOIN PerfilesCta PF ON C.PerfilCuentas=PF.Sec INNER Join Conceptos_PerfilCta CCN ON CCN.Concepto = CN.Sec and CCN.PerfilCta = PF.Sec
WHERE NL.Sec ='" + PSecLiquidacion + "' and NLCC.Valor > 0  and CN.Tipo = 3
Union 
Select  '' as UsuarioCrea, PF.FormaPago, NLC.Sec as SecLiquidacionContrato, CN.Orden, C.Oficina As Oficina, Case When CN.EsRetencion= 0 Then '' Else CAST(CCN.ConceptoR AS varchar) End As ConceptoRete,
Case When CN.EsRetencion= 0 Then '' Else CAST(NLCC.Valor AS varchar) End As BaseRete, '1' As Cuota,'' As Factura, E.Identificacion as Tercero,E.Identificacion as TerceroMov,
C.CodContrato as Contrato, NLCC.NomConcepto as TextoDetalle,isnull(CCN.ContraPartida,'') as CuentaContable,NLCC.Valor as Valor, NTCuentas.NatCuenta As NatCuenta 
From NominaLiquidadaConceptos NLCC INNER Join NominaLiquidadaContratos NLC ON NLCC.LiquidadaContrato = NLC.Sec INNER Join NominaLiquidada NL ON NLC.NominaLiquidada = NL.Sec 
INNER JOIN Contratos C ON NLC.Contrato = C.CodContrato INNER Join Empleados E ON C.Empleado = E.IdEmpleado INNER JOIN ConceptosNomina CN ON NLCC.SecConcepto = CN.Sec 
INNER JOIN PerfilesCta PF ON C.PerfilCuentas=PF.Sec INNER Join Conceptos_PerfilCta CCN ON CCN.Concepto = CN.Sec and CCN.PerfilCta = PF.Sec
Left Join(Select Case NatCuenta WHEN '1' THEN 'D' WHEN '0' THEN 'C' End As NatCuenta,CodCuenta From E" + Datos.Seguridad.DatosDeLaEmpresa.NumEmpresa.ToString("000") + Year(Datos.Smt_FechaDeTrabajo).ToString + "..CT_PlandeCuentas  ) As NTCuentas ON NTCuentas.CodCuenta  COLLATE Modern_Spanish_CI_AS = CCN.ContraPartida COLLATE Modern_Spanish_CI_AS 
WHERE NL.Sec ='" + PSecLiquidacion + "' and NLCC.Valor > 0  and CN.Tipo = 3
Union 
Select '' as UsuarioCrea, PF.FormaPago, NLC.Sec as SecLiquidacionContrato, 1000 as Orden, C.Oficina As Oficina,'' As ConceptoRete,'' As BaseRete,NLCC.Cuota As Cuota, CCN.DocContable As Factura, E.Identificacion as Tercero,
E.Identificacion as TerceroMov,C.CodContrato as Contrato, NLCC.NomConcepto as TextoDetalle,CCN.CtaContable as CuentaContable,NLCC.Valor as Valor, NTCuentas.NatCuenta As NatCuenta 
From NominaLiquidadaConceptos NLCC INNER Join NominaLiquidadaContratos NLC On NLCC.LiquidadaContrato = NLC.Sec INNER Join NominaLiquidada NL ON NLC.NominaLiquidada = NL.Sec 
INNER JOIN Contratos C ON NLC.Contrato = C.CodContrato INNER Join Empleados E ON C.Empleado = E.IdEmpleado INNER JOIN ConceptosPersonales CN ON NLCC.SecConceptoP = CN.Sec 
INNER Join ConceptosP_Contratos CCN ON NLCC.SecConceptoP2 = CCN.Sec INNER JOIN PerfilesCta PF ON C.PerfilCuentas=PF.Sec  
Left Join(Select Case NatCuenta WHEN '1' THEN 'D' WHEN '0' THEN 'C' End As NatCuenta,CodCuenta From E" + Datos.Seguridad.DatosDeLaEmpresa.NumEmpresa.ToString("000") + Year(Datos.Smt_FechaDeTrabajo).ToString + "..CT_PlandeCuentas  ) As NTCuentas ON NTCuentas.CodCuenta  COLLATE Modern_Spanish_CI_AS = CCN.CtaContable COLLATE Modern_Spanish_CI_AS 
WHERE NL.Sec ='" + PSecLiquidacion + "' order by C.CodContrato desc,CN.Orden asc"

        ElseIf TipoLiquidacion = "S" Then
            Sql =
"Select '' as UsuarioCrea, '' as FormaPago, NLC.Sec as SecLiquidacionContrato, CN.Orden, C.Oficina As Oficina,'' As ConceptoRete,'' As BaseRete, '1' As Cuota,'' As Factura, E.Identificacion as Tercero,E.Identificacion as TerceroMov,C.CodContrato as Contrato, NLCC.NomConcepto as TextoDetalle," +
"CCN.CuentaContable as CuentaContable,NLCC.Valor as Valor, " +
"NTCuentas.NatCuenta As NatCuenta " +
"From NominaLiquidaSemestresConceptos NLCC INNER Join NominaLiquidaSemestresContratos NLC ON NLCC.LiquidaContrato = NLC.Sec " +
"INNER Join NominaLiquidaSemestres NL ON NLC.NominaLiquidaSemestres = NL.Sec INNER JOIN Contratos C ON NLC.Contrato = C.CodContrato " +
"INNER Join Empleados E ON C.Empleado = E.IdEmpleado INNER JOIN ConceptosNomina CN ON NLCC.SecConcepto = CN.Sec " +
"INNER Join ConfigProvisiones CCN ON CCN.Concepto = CN.Sec " +
"Left Join(Select Case NatCuenta WHEN '1' THEN 'D' WHEN '0' THEN 'C' End As NatCuenta,CodCuenta From E" + Datos.Seguridad.DatosDeLaEmpresa.NumEmpresa.ToString("000") + Year(Datos.Smt_FechaDeTrabajo).ToString + "..CT_PlandeCuentas  ) As NTCuentas ON NTCuentas.CodCuenta  COLLATE Modern_Spanish_CI_AS = CCN.CuentaContable COLLATE Modern_Spanish_CI_AS " +
"WHERE NL.Sec ='" + PSecLiquidacion + "' And CCN.Nomina ='" + PSecNomina + "' And CN.Fondo =0" +
"Union " +
"Select '' as UsuarioCrea, '' as FormaPago, NLC.Sec as SecLiquidacionContrato, CN.Orden, C.Oficina As Oficina,'' As ConceptoRete,'' As BaseRete,'1' As Cuota,'' As Factura, E.Identificacion As Tercero,Cuentas.Nit as TerceroMov,C.CodContrato as Contrato, NLCC.NomConcepto As TextoDetalle," +
"Cuentas.CuentaC as CuentaContable, NLCC.Valor As Valor," +
"NTCuentas.NatCuenta As NatCuenta " +
"From NominaLiquidaSemestresConceptos NLCC INNER Join NominaLiquidaSemestresContratos NLC ON NLCC.LiquidaContrato = NLC.Sec " +
"INNER Join NominaLiquidaSemestres NL ON NLC.NominaLiquidaSemestres = NL.Sec INNER JOIN Contratos C ON NLC.Contrato = C.CodContrato  " +
"INNER Join Empleados E ON C.Empleado = E.IdEmpleado INNER JOIN ConceptosNomina CN ON NLCC.SecConcepto = CN.Sec " +
"INNER Join ZenumTipoEntes ZTE ON CN.Fondo = ZTE.CodTipoEnte INNER JOIN SemestresLiquidacion P ON NL.Semestre =P.Sec " +
"Left Join(Select ENT.CuentaPasivo As CuentaC, ET.Empleado As Empleado, ENT.TipoEnte As TipoEnte, ENT.Nit From EntesSSAP ENT INNER JOIN EntesTercero ET On ET.SecEntesSSAP = ENT.Sec INNER JOIN Empleados EM On ET.Empleado = EM.IdEmpleado WHERE ET.Retirado=0 ) As Cuentas ON Cuentas.Empleado = E.IdEmpleado And Cuentas.TipoEnte =CN.Fondo  " +
"Left Join(Select Case NatCuenta WHEN '1' THEN 'D' WHEN '0' THEN 'C' End As NatCuenta,CodCuenta From E" + Datos.Seguridad.DatosDeLaEmpresa.NumEmpresa.ToString("000") + Year(Datos.Smt_FechaDeTrabajo).ToString + "..CT_PlandeCuentas  ) As NTCuentas ON NTCuentas.CodCuenta  COLLATE Modern_Spanish_CI_AS = Cuentas.CuentaC COLLATE Modern_Spanish_CI_AS " +
"WHERE NL.Sec ='" + SecLiquidacion + "' And P.Nomina ='" + PSecNomina + "' AND CN.Fondo <> 0 " +
"Union " +
"Select '' as UsuarioCrea, '' as FormaPago, NLC.Sec as SecLiquidacionContrato, 1000 as Orden, C.Oficina As Oficina,'' As ConceptoRete,'' As BaseRete,CCN.CuotaActual-1 As Cuota, CCN.DocContable As Factura, E.Identificacion as Tercero,E.Identificacion as TerceroMov,C.CodContrato as Contrato, NLCC.NomConcepto as TextoDetalle,CCN.CtaContable as CuentaContable,NLCC.Valor as Valor, " +
"NTCuentas.NatCuenta As NatCuenta From NominaLiquidaSemestresConceptos NLCC INNER Join NominaLiquidaSemestresContratos NLC On NLCC.LiquidaContrato = NLC.Sec " +
"INNER Join NominaLiquidaSemestres NL ON NLC.NominaLiquidaSemestres = NL.Sec INNER JOIN Contratos C ON NLC.Contrato = C.CodContrato " +
"INNER Join Empleados E ON C.Empleado = E.IdEmpleado INNER JOIN ConceptosPersonales CN ON NLCC.SecConceptoP = CN.Sec " +
"INNER Join ConceptosP_Contratos CCN ON NLCC.SecConceptoP2 = CCN.Sec  Left Join(Select Case NatCuenta WHEN '1' THEN 'D' WHEN '0' THEN 'C' End As NatCuenta,CodCuenta From E" + Datos.Seguridad.DatosDeLaEmpresa.NumEmpresa.ToString("000") + Year(Datos.Smt_FechaDeTrabajo).ToString + "..CT_PlandeCuentas  ) As NTCuentas ON NTCuentas.CodCuenta  COLLATE Modern_Spanish_CI_AS = CCN.CtaContable COLLATE Modern_Spanish_CI_AS " +
"WHERE NL.Sec ='" + SecLiquidacion + "' "


        ElseIf TipoLiquidacion = "E" Then

            Sql =
"Select '' as UsuarioCrea, '' as FormaPago, NLC.Sec as SecLiquidacionContrato, CN.Orden, C.Oficina As Oficina,'' As ConceptoRete,'' As BaseRete, '1' As Cuota,'' As Factura, E.Identificacion as Tercero,E.Identificacion as TerceroMov,C.CodContrato as Contrato, NLCC.NomConcepto as TextoDetalle," +
"CCN.CuentaContable as CuentaContable,NLCC.Valor as Valor, " +
"NTCuentas.NatCuenta As NatCuenta " +
"From NominaLiquidaExtraordinariaConceptos NLCC INNER Join NominaLiquidaExtraordinariaContratos NLC ON NLCC.LiquidaContrato = NLC.Sec " +
"INNER Join NominaLiquidaExtraordinaria NL ON NLC.NominaLiquidaExtraordinaria = NL.Sec INNER JOIN Contratos C ON NLC.Contrato = C.CodContrato " +
"INNER Join Empleados E ON C.Empleado = E.IdEmpleado INNER JOIN ConceptosNomina CN ON NLCC.SecConcepto = CN.Sec " +
"INNER Join ConfigConceptos CCN ON CCN.Concepto = CN.Sec " +
"Left Join(Select Case NatCuenta WHEN '1' THEN 'D' WHEN '0' THEN 'C' End As NatCuenta,CodCuenta From E" + Datos.Seguridad.DatosDeLaEmpresa.NumEmpresa.ToString("000") + Year(Datos.Smt_FechaDeTrabajo).ToString + "..CT_PlandeCuentas  ) As NTCuentas ON NTCuentas.CodCuenta  COLLATE Modern_Spanish_CI_AS = CCN.CuentaContable COLLATE Modern_Spanish_CI_AS " +
"WHERE NL.Sec ='" + PSecLiquidacion + "' And CCN.Nomina ='" + PSecNomina + "'  AND CN.Fondo = 0 " +
"Union " +
"Select '' as UsuarioCrea, '' as FormaPago, NLC.Sec as SecLiquidacionContrato, CN.Orden, C.Oficina As Oficina,'' As ConceptoRete,'' As BaseRete,'1' As Cuota,'' As Factura, E.Identificacion As Tercero,Cuentas.Nit as TerceroMov,C.CodContrato as Contrato, NLCC.NomConcepto As TextoDetalle," +
"Cuentas.CuentaC as CuentaContable, NLCC.Valor As Valor," +
"NTCuentas.NatCuenta As NatCuenta " +
"From NominaLiquidaExtraordinariaConceptos NLCC INNER Join NominaLiquidaExtraordinariaContratos NLC ON NLCC.LiquidaContrato = NLC.Sec " +
"INNER Join NominaLiquidaExtraordinaria NL ON NLC.NominaLiquidaExtraordinaria = NL.Sec INNER JOIN Contratos C ON NLC.Contrato = C.CodContrato  " +
"INNER Join Empleados E ON C.Empleado = E.IdEmpleado INNER JOIN ConceptosNomina CN ON NLCC.SecConcepto = CN.Sec " +
"INNER Join ZenumTipoEntes ZTE ON CN.Fondo = ZTE.CodTipoEnte " +
"Left Join(Select ENT.CuentaPasivo As CuentaC, ET.Empleado As Empleado, ENT.TipoEnte As TipoEnte, ENT.Nit From EntesSSAP ENT INNER JOIN EntesTercero ET On ET.SecEntesSSAP = ENT.Sec INNER JOIN Empleados EM On ET.Empleado = EM.IdEmpleado WHERE ET.Retirado=0 ) As Cuentas ON Cuentas.Empleado = E.IdEmpleado And Cuentas.TipoEnte =CN.Fondo  " +
"Left Join(Select Case NatCuenta WHEN '1' THEN 'D' WHEN '0' THEN 'C' End As NatCuenta,CodCuenta From E" + Datos.Seguridad.DatosDeLaEmpresa.NumEmpresa.ToString("000") + Year(Datos.Smt_FechaDeTrabajo).ToString + "..CT_PlandeCuentas  ) As NTCuentas ON NTCuentas.CodCuenta  COLLATE Modern_Spanish_CI_AS = Cuentas.CuentaC COLLATE Modern_Spanish_CI_AS " +
"WHERE NL.Sec ='" + SecLiquidacion + "' AND CN.Fondo <> 0 " +
"Union " +
"Select '' as UsuarioCrea, '' as FormaPago, NLC.Sec as SecLiquidacionContrato, 1000 as Orden, C.Oficina As Oficina,'' As ConceptoRete,'' As BaseRete,CCN.CuotaActual-1 As Cuota, CCN.DocContable As Factura, E.Identificacion as Tercero,E.Identificacion as TerceroMov,C.CodContrato as Contrato, NLCC.NomConcepto as TextoDetalle,CCN.CtaContable as CuentaContable,NLCC.Valor as Valor, " +
"NTCuentas.NatCuenta As NatCuenta From NominaLiquidaExtraordinariaConceptos NLCC INNER Join NominaLiquidaExtraordinariaContratos NLC On NLCC.LiquidaContrato = NLC.Sec " +
"INNER Join NominaLiquidaExtraordinaria NL ON NLC.NominaLiquidaExtraordinaria = NL.Sec INNER JOIN Contratos C ON NLC.Contrato = C.CodContrato " +
"INNER Join Empleados E ON C.Empleado = E.IdEmpleado INNER JOIN ConceptosPersonales CN ON NLCC.SecConceptoP = CN.Sec " +
"INNER Join ConceptosP_Contratos CCN ON NLCC.SecConceptoP2 = CCN.Sec  Left Join(Select Case NatCuenta WHEN '1' THEN 'D' WHEN '0' THEN 'C' End As NatCuenta,CodCuenta From E" + Datos.Seguridad.DatosDeLaEmpresa.NumEmpresa.ToString("000") + Year(Datos.Smt_FechaDeTrabajo).ToString + "..CT_PlandeCuentas  ) As NTCuentas ON NTCuentas.CodCuenta  COLLATE Modern_Spanish_CI_AS = CCN.CtaContable COLLATE Modern_Spanish_CI_AS " +
"WHERE NL.Sec ='" + SecLiquidacion + "' order by C.CodContrato desc,CN.Orden asc  "


        ElseIf TipoLiquidacion = "C" Then
            Sql =
"Select '' as UsuarioCrea, '' as FormaPago, NLC.Sec as SecLiquidacionContrato, CN.Orden, C.Oficina As Oficina,'' As ConceptoRete,'' As BaseRete, '1' As Cuota,'' As Factura, E.Identificacion as Tercero,E.Identificacion as TerceroMov,C.CodContrato as Contrato, NLCC.NomConcepto as TextoDetalle," +
"CCN.CuentaContable as CuentaContable,NLCC.Valor as Valor, " +
"NTCuentas.NatCuenta As NatCuenta " +
"From ContratosLiquidados_Conceptos NLCC INNER Join ContratosLiquidados_Contratos NLC ON NLCC.LiquidaContrato = NLC.Sec " +
"INNER Join ContratosLiquidados NL ON NLC.NominaLiquida = NL.Sec INNER JOIN Contratos C ON NLC.Contrato = C.CodContrato " +
"INNER Join Empleados E ON C.Empleado = E.IdEmpleado INNER JOIN ConceptosNomina CN ON NLCC.SecConcepto = CN.Sec " +
"INNER Join TiposContratos_ConceptosNomina CCN ON CCN.Concepto = CN.Sec " +
"Left Join(Select Case NatCuenta WHEN '1' THEN 'D' WHEN '0' THEN 'C' End As NatCuenta,CodCuenta From E" + Datos.Seguridad.DatosDeLaEmpresa.NumEmpresa.ToString("000") + Year(Datos.Smt_FechaDeTrabajo).ToString + "..CT_PlandeCuentas  ) As NTCuentas ON NTCuentas.CodCuenta  COLLATE Modern_Spanish_CI_AS = CCN.CuentaContable COLLATE Modern_Spanish_CI_AS " +
"WHERE NL.Sec ='" + PSecLiquidacion + "' order by C.CodContrato desc,CN.Orden asc  "
        End If

        Dim dt As DataTable = SMT_AbrirTabla(ObjetoApiNomina, Sql)
        For Each Fil As DataRow In dt.Rows
            If Fil("CuentaContable").ToString().Contains("+") Then
                Dim dts = Fil("CuentaContable").ToString().Split("+")
                Fil("CuentaContable") = dts(0)
                Fil("TerceroMov") = dts(1)
            End If
            Fil("UsuarioCrea") = Datos.Smt_Usuario
        Next

        dt.DefaultView.Sort = "Contrato,Orden,NatCuenta asc"

        CreaColumnas()
        Dim Diferencia As Decimal = 0, Tercero As Decimal = 0
        Dim Dv As DataView = New DataView(dt)
        DocCruce = "NOM" + Strings.Right("0000000" + PSecNomina, 3) + Strings.Right("0000000" + PSecLiquidacion, 7)

        'dt = Dv.Table
        Dim DtOrd As DataTable = Dv.ToTable
        For Incre As Integer = 0 To DtOrd.Rows.Count - 1
            Dim Fila As DataRow = DtOrd.Rows(Incre)
            If Tercero <> CDec(Fila("Tercero")) And Tercero <> 0 Then
                AdicionarContrapartida(Fila("Oficina").ToString, Diferencia, Tercero,, Fila("SecLiquidacionContrato").ToString, Fila("FormaPago").ToString)
                Tercero = CDec(Fila("Tercero"))
                Diferencia = 0
            Else
                Tercero = CDec(Fila("Tercero"))
            End If

            If Fila("NatCuenta").ToString = "D" Then
                Diferencia += CDec(Fila("Valor"))
            Else
                Diferencia -= CDec(Fila("Valor"))
            End If
            LlenaGridPrincipal(Fila)
            If Incre = DtOrd.Rows.Count - 1 Then
                AdicionarContrapartida(Fila("Oficina").ToString, Diferencia, Tercero,, Fila("SecLiquidacionContrato").ToString, Fila("FormaPago").ToString)
            End If
        Next
        'If Tercero <> CDec(Fila("Tercero")) And Tercero <> 0 Then
        '    AdicionarContrapartida(Diferencia, Tercero)
        'End If
        gcConceptosCont.DataSource = DatosContabilizar
        dt = Nothing
        Sql = "SELECT CodCuenta AS Codigo,CodCuenta+'-'+NomCuenta AS Descripcion " &
                                           " FROM CT_PlandeCuentas WHERE EsdeMovimiento=1 AND Estado='V'"
        dt = SMT_AbrirTabla(ObjetoApiNomina, Sql)

        If dt.Rows.Count > 0 Then

            lkEditCta.DataSource = dt
            lkEditCta.ValueMember = "Codigo"
            lkEditCta.DisplayMember = "Descripcion"
            'lkEdit2.PopulateColumns()
            'lkEdit2.Columns(0).Visible = False
        End If


        dt = New DataTable
        dt.Columns.Add("Codigo", GetType(String))
        dt.Columns.Add("Descripcion", GetType(String))

        dt.Rows.Add("C", "C")
        dt.Rows.Add("D", "D")
        dt.AcceptChanges()

        If dt.Rows.Count > 0 Then

            lkEditNat.DataSource = dt
            lkEditNat.ValueMember = "Codigo"
            lkEditNat.DisplayMember = "Descripcion"
        End If
        Exit Sub
CtlErr:
        MensajedeError("")
    End Sub


    Public Sub LlenaGridTerceros()
        On Error GoTo CtlErr
        Dim Sql As String = "", NombreBD As String = "E" + Datos.Seguridad.DatosDeLaEmpresa.NumEmpresa.ToString("000") + Year(Datos.Smt_FechaDeTrabajo).ToString("0000")
        If TipoLiquidacion = "P" Then
            Sql =
"Select  NLC.EstadoCont, PC.FormaPago, NLC.Doccontable, NLC.Sec as SecLiquidacionContrato, E.PNombre+' '+E.SNombre+' '+E.PApellido+' '+E.SApellido As NomTercero, C.Oficina As Oficina, " +
"E.Identificacion as Tercero,E.Identificacion as TerceroMov,C.CodContrato as Contrato, " +
" (select Doc_TipoComp + '-' + cast(Doc_IdComp as varchar(10)) + '-' + cast(doc_numdocumento as varchar(20)) from E" + Datos.Seguridad.DatosDeLaEmpresa.NumEmpresa.ToString("000") + Year(Datos.Smt_FechaDeTrabajo).ToString + "..CT_Documentos where doc_secuencial  =  NLC.DocContable ) as DocumentoContable " +
"From NominaLiquidadaContratos NLC " +
"INNER Join NominaLiquidada NL ON NLC.NominaLiquidada = NL.Sec INNER JOIN Contratos C ON NLC.Contrato = C.CodContrato " +
"INNER Join Empleados E ON C.Empleado = E.IdEmpleado Left JOIN PerfilesCta PC ON PC.Sec= C.PerfilCuentas " +
"WHERE NL.Sec ='" + PSecLiquidacion + "' order by C.CodContrato desc"

        ElseIf TipoLiquidacion = "S" Then
            Sql =
"Select NLC.EstadoCont, '' as FormaPago, NLC.Doccontable, NLC.Sec as SecLiquidacionContrato, E.PNombre+' '+E.SNombre+' '+E.PApellido+' '+E.SApellido As NomTercero, C.Oficina As Oficina, E.Identificacion as Tercero,E.Identificacion as TerceroMov,C.CodContrato as Contrato, " +
" (select Doc_TipoComp + '-' + cast(Doc_IdComp as varchar(10)) + '-' + cast(doc_numdocumento as varchar(20)) from E" + Datos.Seguridad.DatosDeLaEmpresa.NumEmpresa.ToString("000") + Year(Datos.Smt_FechaDeTrabajo).ToString + "..CT_Documentos where doc_secuencial  =  NLC.DocContable ) as DocumentoContable " +
"From NominaLiquidaSemestresContratos NLC " +
"INNER Join NominaLiquidaSemestres NL ON NLC.NominaLiquidaSemestres = NL.Sec INNER JOIN Contratos C ON NLC.Contrato = C.CodContrato " +
"INNER Join Empleados E ON C.Empleado = E.IdEmpleado " +
"WHERE NL.Sec ='" + PSecLiquidacion + "' order by C.CodContrato desc"


        ElseIf TipoLiquidacion = "E" Then

            Sql =
"Select NLC.EstadoCont, '' as FormaPago, NLC.Doccontable, NLC.Sec as SecLiquidacionContrato, E.PNombre+' '+E.SNombre+' '+E.PApellido+' '+E.SApellido As NomTercero, C.Oficina As Oficina, E.Identificacion as Tercero,E.Identificacion as TerceroMov,C.CodContrato as Contrato, " +
" (select Doc_TipoComp + '-' + cast(Doc_IdComp as varchar(10)) + '-' + cast(doc_numdocumento as varchar(20)) from E" + Datos.Seguridad.DatosDeLaEmpresa.NumEmpresa.ToString("000") + Year(Datos.Smt_FechaDeTrabajo).ToString + "..CT_Documentos where doc_secuencial  =  NLC.DocContable ) as DocumentoContable " +
"From NominaLiquidaExtraordinariaContratos NLC " +
"INNER Join NominaLiquidaExtraordinaria NL ON NLC.NominaLiquidaExtraordinaria = NL.Sec INNER JOIN Contratos C ON NLC.Contrato = C.CodContrato " +
"INNER Join Empleados E ON C.Empleado = E.IdEmpleado" +
"WHERE NL.Sec ='" + PSecLiquidacion + "' order by C.CodContrato desc"


        ElseIf TipoLiquidacion = "C" Then
            Sql =
"Select NLC.EstadoCont, '' as FormaPago, NLC.Doccontable, NLC.Sec as SecLiquidacionContrato, E.PNombre+' '+E.SNombre+' '+E.PApellido+' '+E.SApellido As NomTercero, C.Oficina As Oficina, E.Identificacion as Tercero,E.Identificacion as TerceroMov,C.CodContrato as Contrato, " +
" (select Doc_TipoComp + '-' + cast(Doc_IdComp as varchar(10)) + '-' + cast(doc_numdocumento as varchar(20)) from E" + Datos.Seguridad.DatosDeLaEmpresa.NumEmpresa.ToString("000") + Year(Datos.Smt_FechaDeTrabajo).ToString + "..CT_Documentos where doc_secuencial  =  NLC.DocContable ) as DocumentoContable " +
"From ContratosLiquidados_Contratos NLC " +
"INNER Join ContratosLiquidados NL ON NLC.NominaLiquida = NL.Sec INNER JOIN Contratos C ON NLC.Contrato = C.CodContrato " +
"INNER Join Empleados E ON C.Empleado = E.IdEmpleado" +
"WHERE NL.Sec ='" + PSecLiquidacion + "' order by C.CodContrato desc"
        End If

        Dim dt As DataTable = SMT_AbrirTabla(ObjetoApiNomina, Sql)
        gcTerceros.DataSource = dt
        Exit Sub
CtlErr:
        MensajedeError("")
    End Sub





    Private Sub AdicionarContrapartida(Oficina As String, Dif As Decimal, Tercero As Decimal, Optional Documento As String = "", Optional SecLiqCont As String = "", Optional FormaPag As String = "")
        Dim fila2 As DataRow = DatosContabilizar.NewRow()
        Dim ItemNum As Integer = DatosContabilizar.Rows.Count + 1
        fila2("Oficina") = Oficina.ToString
        fila2("Item") = ItemNum.ToString
        fila2("ConceptoRete") = ""
        fila2("BaseRete") = ""
        fila2("Cuota") = "1"
        fila2("Factura") = "NOM" + Strings.Right("0000000" + PSecNomina, 3) + Strings.Right("0000000" + SecLiqCont, 7)
        fila2("Tercero") = Tercero
        fila2("TerceroMov") = Tercero
        fila2("TextoDetalle") = "Contra Partida CxP Empleado"
        FormaPag = TraerCtaFormaPago(Convert.ToInt16(IIf(FormaPag = "", "0", FormaPag)))
        fila2("Cuenta") = FormaPag
        fila2("Valor") = Dif
        fila2("Nat") = "C"
        If fila2("Nat").ToString = "D" Then
            If Dif > 0 Then
                fila2("ValorDB") = Math.Abs(Dif)
                fila2("ValorCR") = 0
            Else
                fila2("ValorDB") = 0
                fila2("ValorCR") = Math.Abs(Dif)
            End If
        Else
            If Dif > 0 Then
                fila2("ValorCR") = Math.Abs(Dif)
                fila2("ValorDB") = 0
            Else
                fila2("ValorCR") = 0
                fila2("ValorDB") = Math.Abs(Dif)
            End If

        End If

        fila2("Ccosto") = "1"

        DatosContabilizar.Rows.Add(fila2)
        DatosContabilizar.AcceptChanges()
    End Sub
    Public Sub CreaColumnas()
        DatosContabilizar = New DataTable
        DatosContabilizar.Columns.Add("UsuarioCrea", GetType(String))
        DatosContabilizar.Columns.Add("SecLiquidacionContrato", GetType(String))
        DatosContabilizar.Columns.Add("Oficina", GetType(String))
        DatosContabilizar.Columns.Add("TipoComp", GetType(String))
        DatosContabilizar.Columns.Add("CodComp", GetType(String))
        DatosContabilizar.Columns.Add("NumeroDoc", GetType(String))
        DatosContabilizar.Columns.Add("Fecha", GetType(String))
        DatosContabilizar.Columns.Add("Tercero", GetType(Decimal))
        DatosContabilizar.Columns.Add("DetalleGeneral", GetType(String))
        DatosContabilizar.Columns.Add("NumCheque", GetType(String))
        DatosContabilizar.Columns.Add("Comentario", GetType(String))
        DatosContabilizar.Columns.Add("Item", GetType(String))
        DatosContabilizar.Columns.Add("Cuenta", GetType(String))
        DatosContabilizar.Columns.Add("TerceroMov", GetType(Decimal))
        DatosContabilizar.Columns.Add("Estab", GetType(String))
        DatosContabilizar.Columns.Add("Ccosto", GetType(String))
        DatosContabilizar.Columns.Add("TextoDetalle", GetType(String))
        DatosContabilizar.Columns.Add("Nat", GetType(String))
        DatosContabilizar.Columns.Add("Valor", GetType(Decimal))
        DatosContabilizar.Columns.Add("ValorDB", GetType(Decimal))
        DatosContabilizar.Columns.Add("ValorCR", GetType(Decimal))
        DatosContabilizar.Columns.Add("Factura", GetType(String))
        DatosContabilizar.Columns.Add("Cuota", GetType(Integer))
        DatosContabilizar.Columns.Add("FechaVence", GetType(String))
        DatosContabilizar.Columns.Add("BaseRete", GetType(String))
        DatosContabilizar.Columns.Add("ConceptoRete", GetType(String))
        DatosContabilizar.Columns.Add("Base IVA", GetType(String))
        DatosContabilizar.Columns.Add("Codigo tipo IVA", GetType(String))
        DatosContabilizar.Columns.Add("Activo", GetType(String))
        DatosContabilizar.Columns.Add("Vehículo", GetType(String))
        DatosContabilizar.Columns.Add("Codigo Control Personalizado", GetType(String))
    End Sub

    Private Sub AsignaScriptAcontroles()
        Try

            Dim Empresa As Integer = Datos.Seguridad.DatosDeLaEmpresa.NumEmpresa, NombreBD As String = "E" + Datos.Seguridad.DatosDeLaEmpresa.NumEmpresa.ToString("000") + Year(Datos.Smt_FechaDeTrabajo).ToString(0)
            txtOficina.ConsultaSQL = String.Format("Select NumOficina As Codigo, NomOficina As Descripcion FROM SEGURIDAD..Oficinas WHERE Estado='V' AND NumEmpresa={0}", Empresa.ToString)
            txtOficina.RefrescarDatos()
            If gvConceptos.RowCount > 0 Then
                txtOficina.ValordelControl = gvConceptos.GetRowCellValue(0, "Oficina").ToString
            End If
            'lblSecCom.Text = SMT_AbrirTabla(ObjetoApiNomina, "SELECT IDENT_CURRENT( 'E" + Datos.Seguridad.DatosDeLaEmpresa.NumEmpresa.ToString("000") + Year(Datos.Smt_FechaDeTrabajo).ToString + "..CT_Documentos' )+1  AS Codigo").Rows(0)(0).ToString
            'lblSecCom.Text = SMT_AbrirTabla(ObjetoApiNomina, "SELECT ").ToString

            txtTipoComprobante.ConsultaSQL = "SELECT IdTC AS Codigo,NomTC As Descripcion From E" + Datos.Seguridad.DatosDeLaEmpresa.NumEmpresa.ToString("000") + Year(Datos.Smt_FechaDeTrabajo).ToString + "..CT_ComTipo"
            txtFormadePago.ConsultaSQL = "Select Cod_Fp as Codigo,Nombre_FP as Descripcion from ct_FormaPAgo"
            txtFormadePago.RefrescarDatos()

            dteFecha.Focus()
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "AsignaScriptAcontroles")
        End Try
    End Sub

    Public Sub LlenaGridPrincipal(Fila As DataRow)
        Dim Diferencia As Decimal = 0
        Dim Centros As DataTable = SMT_AbrirTabla(ObjetoApiNomina, "Select CC.Nom_CentroCosto, CC.Cod_CentroCosto,C.Porcentaje From Contratos_CentroCostos C Inner Join CT_CentroCostos CC On C.CentroCosto = CC.Cod_CentroCosto Where C.Contrato =" + Fila("Contrato").ToString)
        If CDec(Fila("Valor")) > 0 Then
            If Centros.Rows.Count > 1 Then
                For incre As Integer = 0 To Centros.Rows.Count - 1
                    Dim fila2 As DataRow = DatosContabilizar.NewRow()
                    Dim Valor As Decimal = CDec(Fila("Valor")) * CDec(Centros.Rows(incre)("Porcentaje"))
                    Valor = Valor / 100
                    Dim ItemNum As Integer = DatosContabilizar.Rows.Count + 1
                    fila2("Oficina") = Fila("Oficina").ToString
                    fila2("Item") = ItemNum.ToString
                    fila2("Ccosto") = Centros.Rows(incre)("Cod_CentroCosto").ToString
                    fila2("ConceptoRete") = Fila("ConceptoRete").ToString
                    If Fila("BaseRete").ToString <> "" Then
                        Dim Valor2 As Decimal = CDec(Fila("BaseRete")) * CDec(Centros.Rows(incre)("Porcentaje"))
                        Valor2 = Valor2 / 100
                        fila2("BaseRete") = Valor2.ToString
                    Else
                        fila2("BaseRete") = Fila("BaseRete").ToString
                    End If
                    fila2("Cuota") = Fila("Cuota").ToString
                    fila2("Factura") = IIf(String.IsNullOrEmpty(Fila("Factura").ToString), "NOM" + Strings.Right("0000000" + PSecNomina, 3) + Strings.Right("0000000" + Fila("SecLiquidacionContrato").ToString, 7), Fila("Factura").ToString)
                    fila2("Tercero") = Fila("Tercero").ToString
                    fila2("TerceroMov") = CDec(Fila("TerceroMov"))
                    fila2("TextoDetalle") = Fila("TextoDetalle").ToString
                    fila2("Cuenta") = Fila("CuentaContable").ToString
                    fila2("Valor") = Valor.ToString
                    fila2("Nat") = Fila("NatCuenta").ToString
                    If Fila("NatCuenta").ToString = "D" Then
                        fila2("ValorDB") = Fila("Valor")
                        fila2("ValorCR") = 0
                        Diferencia += Convert.ToDecimal(Fila("Valor"))
                    Else
                        fila2("ValorCR") = Fila("Valor")
                        fila2("ValorDB") = 0
                        Diferencia -= Convert.ToDecimal(Fila("Valor"))
                    End If
                    DatosContabilizar.Rows.Add(fila2)
                    DatosContabilizar.AcceptChanges()
                Next
            Else
                Dim fila2 As DataRow = DatosContabilizar.NewRow()
                Dim ItemNum As Integer = DatosContabilizar.Rows.Count + 1
                fila2("Oficina") = Fila("Oficina").ToString
                fila2("Item") = ItemNum.ToString
                fila2("ConceptoRete") = Fila("ConceptoRete").ToString
                fila2("BaseRete") = Fila("BaseRete").ToString
                fila2("Cuota") = Fila("Cuota").ToString
                fila2("UsuarioCrea") = Fila("UsuarioCrea").ToString
                'fila2("Factura") = Fila("Factura").ToString
                fila2("Factura") = IIf(String.IsNullOrEmpty(Fila("Factura").ToString), "NOM" + Strings.Right("0000000" + PSecNomina, 3) + Strings.Right("0000000" + Fila("SecLiquidacionContrato").ToString, 7), Fila("Factura").ToString)
                fila2("Tercero") = Fila("Tercero")
                fila2("TerceroMov") = Fila("TerceroMov")
                fila2("TextoDetalle") = Fila("TextoDetalle").ToString
                fila2("Cuenta") = Fila("CuentaContable").ToString
                fila2("Valor") = Fila("Valor")
                fila2("Nat") = Fila("NatCuenta").ToString
                If Fila("NatCuenta").ToString = "D" Then
                    fila2("ValorDB") = Fila("Valor")
                    fila2("ValorCR") = 0
                    Diferencia += Convert.ToDecimal(Fila("Valor"))
                Else
                    fila2("ValorCR") = Fila("Valor")
                    fila2("ValorDB") = 0
                    Diferencia -= Convert.ToDecimal(Fila("Valor"))
                End If

                If Centros.Rows.Count > 0 Then
                    fila2("Ccosto") = Centros.Rows(0)("Cod_CentroCosto").ToString
                End If

                DatosContabilizar.Rows.Add(fila2)
                DatosContabilizar.AcceptChanges()
            End If
        End If

    End Sub

    Public Function ValidaFilas(Fila As DataRow) As Boolean

        If Fila("Cuenta").ToString = "" Then
            HDevExpre.MensagedeError("El Concepto " + Fila("TextoDetalle").ToString + " no tiene la cuenta configurada, no es posible continuar!..")
            Return False
        ElseIf Fila("Factura").ToString <> "" And Fila("Cuota").ToString = "" Then
            HDevExpre.MensagedeError("El Descuento " + Fila("TextoDetalle").ToString + " no tiene la cuota configurada, no es posible continuar!..")
            Return False
        ElseIf Fila("BaseRete").ToString <> "" And Fila("ConceptoRete").ToString = "0" And TipoLiquidacion = "P" Then
            HDevExpre.MensagedeError("El concepto " + Fila("TextoDetalle").ToString + " no tiene el concepto de retencion configurado, no es posible continuar!..")
            Return False
        End If

        Return True
    End Function
    Public Function ValidaFilasTb(Filas As DataTable) As ClErrores
        Dim MisErrores As New ClErrores
        For Each fila As DataRow In Filas.Rows
            If fila("Cuenta").ToString = "" Then
                MisErrores.Agregar_Error(fila("TextoDetalle").ToString, String.Format("El Concepto {0} Del Empleado {1}, no tiene la cuenta configurada, no es posible continuar!..", fila("TextoDetalle"), FormatNumber(fila!Tercero, 0)))
            ElseIf fila("Factura").ToString <> "" And fila("Cuota").ToString = "" Then
                MisErrores.Agregar_Error(fila("TextoDetalle").ToString, String.Format("El Descuento {0} no tiene la cuota configurada, no es posible continuar!..", fila("TextoDetalle")))
            ElseIf fila("BaseRete").ToString <> "" And fila("ConceptoRete").ToString = "0" And TipoLiquidacion = "P" Then
                MisErrores.Agregar_Error(fila("TextoDetalle").ToString, String.Format("El concepto {0} no tiene el concepto de retencion configurado, no es posible continuar!..", fila("TextoDetalle")))
            End If
        Next

        Return MisErrores
    End Function

    Public Function ValidaCampos() As Boolean
        If txtTipoComprobante.ValordelControl = "" Or txtTipoComprobante.DescripciondelControl = "No Se Encontraron Registros" Or txtTipoComprobante.DescripciondelControl = "" Then
            HDevExpre.MensagedeError("El campo Tipo Comp no puede estar vacío o contener valores invalidos!..")
            txtTipoComprobante.Focus()
            Return False
        ElseIf txtCodComp.ValordelControl = "" Or txtCodComp.DescripciondelControl = "No Se Encontraron Registros" Or txtCodComp.DescripciondelControl = "" Then
            HDevExpre.MensagedeError("El campo Cod Comp no puede estar vacío o contener valores invalidos!..")
            txtCodComp.Focus()
            Return False
        ElseIf dteFecha.Text = "" Then
            HDevExpre.MensagedeError("El campo Fecha no puede estar vacío!..")
            dteFecha.Focus()
            Return False
        ElseIf txtComentario.Text = "" Then
            HDevExpre.MensagedeError("El campo Comentario General no puede estar vacío!..")
            txtComentario.Focus()
            Return False
        End If
        Return True
    End Function

    Public Function RegEmpleados(connection1 As Object, Identificacion As String) As Boolean
        Try
            Dim str As String = String.Format("Select IdCliente From E{0}{1}..g_Clientes where Identificacion='{2}'", Datos.Seguridad.DatosDeLaEmpresa.NumEmpresa.ToString("000"), Year(Datos.Smt_FechaDeTrabajo).ToString, Identificacion)
            Dim dt As DataTable = SMT_AbrirTabla(connection1, str)
            If dt.Rows.Count > 0 Then
                Return True
            Else
                Dim sqlReg = "Insert into E" + Datos.Seguridad.DatosDeLaEmpresa.NumEmpresa.ToString("000") + Year(Datos.Smt_FechaDeTrabajo).ToString + "..g_Clientes " +
    " (IdCliente,TipoIdentificacion,Identificacion,Dv,PApellido,SApellido,PNombre,SNombre,FechaNacimiento,EstadoCivil,FechaIngreso,Comentario,Foto,Email,LugarExpDoc," +
    " MunicipioNacimiento,Genero,Direccion,Municipio,Barrio,Tel1,Tel2,NumCelular,WebPage,ActividadEco) " +
    " Select (Select Max(IdCliente)+1 From " + Datos.Smt_BDTrabajo + "..g_Clientes),(select Codigo from CAT_TiposId where TipoIdentificacion=E.TipoIdentificacion) as TipoIdentificacion,Identificacion,Dv,PApellido,SApellido,PNombre,SNombre,FechaNacimiento,EstadoCivil," +
    " FechaIngreso, Comentario, Foto, Email1, LugarExpDoc, MunicipioNacimiento, Genero, Direccion, Municipio, Barrio, Tel1, Tel2, NumCelular, WebPage, ActividadEco" +
    " From Empleados E Where Identificacion='" + Identificacion + "'"

                Dim Resul As Long = SMT_EjcutarComandoSqlBool(connection1, sqlReg)
                If Resul > 0 Then
                    Return True
                Else
                    Return False
                End If
            End If
        Catch ex As Exception
            ErroresValterc.Agregar_Error("Registro tercero", ex.Message)
            Return False
        End Try
    End Function
    Private Function TraerCtaFormaPago(Fpago As Integer) As String
        Dim Tb As DataTable, TxtSql As String = String.Format("select Cuenta_FP as Cuenta from ct_FormaPago WHERE estado_Fp = 'V' AND Cod_FP =" & Fpago.ToString)
        Try
            Tb = SMT_AbrirTabla(SMTConexMod, TxtSql)
            If Tb.Rows.Count = 1 Then
                Return Tb.Rows(0)("Cuenta").ToString
            Else
                Return ""
            End If
        Catch ex As Exception

        End Try
        Return ""
    End Function

    Public Sub desactivabtn()
        btnAceptar.Enabled = False
        btnCancelar.Enabled = False
        BtnExcell.Enabled = False
        btnAnular.Enabled = False
    End Sub

    Public Sub activabtn()
        btnAceptar.Enabled = True
        btnCancelar.Enabled = True
        BtnExcell.Enabled = True
        btnAnular.Enabled = True
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim DatosCP As DataTable = CType(gcConceptosCont.DataSource, DataTable), CtaFpago As String = ""
        Dim DatosC As DataTable = DatosCP.Copy()
        Dim DatosT As DataTable = CType(gcTerceros.DataSource, DataTable)
        desactivabtn()
        Dim Load As ClEspera = New ClEspera()
        Load.Mostrar("Contabilizando nomina!.", "")

        If DatosCP.Rows.Count > 0 Then
            'Using trans As New Transactions.TransactionScope
            'Using connection1 As New SqlClient.SqlConnection(CadConexionBdGeneral)
            'connection1.Open()
            SMT_EjcutarComandoSql(ObjetoApiNomina, "set dateformat dmy", 0)

            Try

                        For Incre As Integer = 0 To DatosCP.Rows.Count - 1
                            DatosCP.Rows(Incre)("TipoComp") = txtTipoComprobante.ValordelControl
                            DatosCP.Rows(Incre)("CodComp") = txtCodComp.ValordelControl
                            DatosCP.Rows(Incre)("NumeroDoc") = lblSecCom.Text
                            DatosCP.Rows(Incre)("Fecha") = dteFecha.Text
                            DatosCP.Rows(Incre)("DetalleGeneral") = txtComentario.Text
                    If Not RegEmpleados(ObjetoApiNomina, DatosCP.Rows(Incre)("Tercero").ToString) Then
                        ErroresValterc.Agregar_Error("Registro tercero", String.Format("Ha ocurrido un error al guardar el Tercero con identificacion {0}, no es posible continuar!..", DatosCP.Rows(Incre)("Tercero")))
                    End If
                Next
                'trans.Complete()
            Catch ex As Exception
                        ErroresValterc.Agregar_Error("Registro tercero", ex.Message)
                        'Load.Terminar()
                        'activabtn()
                        'Exit Sub
                    End Try
            'End Using
            'End Using
        Else
            HDevExpre.MensagedeError("No se han encontrado registros!..", "SAMIt SQL")
            Load.Terminar()
            activabtn()
            Exit Sub
        End If

        If ErroresValterc.NumeroDeErrores > 0 Then
            ErroresValterc.Presentar_Informe()
            Load.Terminar()
            activabtn()
            ErroresValterc.Reiniciar()
            Exit Sub
        End If

        Dim ErroresVal As ClErrores = ValidaFilasTb(DatosCP)
        VerificarInsertarTerceros()

        For Each FilaT As DataRow In DatosT.Rows
            If FilaT("EstadoCont").ToString <> "CONTABILIZADO" Then

                SecLiquidacionContrato = ""
                SecLiquidacionContrato = FilaT("SecLiquidacionContrato").ToString

                If txtTipoComprobante.ValordelControl = "" Or txtTipoComprobante.DescripciondelControl = "No Se Encontraron Registros" Or txtTipoComprobante.DescripciondelControl = "" Then
                    HDevExpre.MensagedeError("El campo Tipo Comp no puede estar vacío o contener valores invalidos!..")
                    txtTipoComprobante.Focus()
                    Load.Terminar()
                    activabtn()
                    Exit Sub
                ElseIf txtCodComp.ValordelControl = "" Or txtCodComp.DescripciondelControl = "No Se Encontraron Registros" Or txtCodComp.DescripciondelControl = "" Then
                    HDevExpre.MensagedeError("El campo Cod Comp no puede estar vacío o contener valores invalidos!..")
                    txtCodComp.Focus()
                    Load.Terminar()
                    activabtn()
                    Exit Sub
                ElseIf dteFecha.Text = "" Then
                    HDevExpre.MensagedeError("El campo Fecha no puede estar vacío!..")
                    dteFecha.Focus()
                    Load.Terminar()
                    activabtn()
                    Exit Sub
                ElseIf txtComentario.Text = "" Then
                    HDevExpre.MensagedeError("El campo Comentario General no puede estar vacío!..")
                    txtComentario.Focus()
                    Load.Terminar()
                    activabtn()
                    Exit Sub
                End If

                Dim NumDoc = ConsecutivoServidor(txtTipoComprobante.ValordelControl.ToString, Convert.ToByte(txtCodComp.ValordelControl)).ToString
                DatosC.Rows.Clear()
                For Each FilaCP As DataRow In DatosCP.Rows
                    If FilaT("Tercero").ToString = FilaCP("Tercero").ToString Then
                        Dim FilaAgg As DataRow = FilaCP
                        FilaAgg("NumeroDoc") = NumDoc
                        DatosC.ImportRow(FilaAgg)
                        DatosC.AcceptChanges()
                    End If
                Next

                If DatosC Is Nothing Then
                    HDevExpre.MensagedeError("No se han encontrado registros!..")
                    Load.Terminar()
                    activabtn()
                    Exit Sub
                Else
                    If TipoLiquidacion <> "P" Then
                        FilaT("FormaPago") = txtFormadePago.ValordelControl
                    End If
                    If FilaT("FormaPago").ToString = "" Then
                        HDevExpre.MensagedeError("Debe Configurar la Forma de Pago")
                        Load.Terminar()
                        activabtn()
                        Exit Sub
                    End If
                    CtaFpago = TraerCtaFormaPago(Convert.ToInt16(FilaT("FormaPago").ToString))
                    For Incre As Integer = 0 To DatosC.Rows.Count - 1

                        If CDec(DatosC.Rows(Incre)("ValorDB")) > 0 Then
                            DatosC.Rows(Incre)("Valor") = DatosC.Rows(Incre)("ValorDB")
                            DatosC.Rows(Incre)("Nat") = "D"
                        Else
                            DatosC.Rows(Incre)("Valor") = DatosC.Rows(Incre)("ValorCR")
                            DatosC.Rows(Incre)("Nat") = "C"
                        End If
                        If CtaFpago <> "" Then
                            If DatosC.Rows(Incre)("Cuenta").ToString = "FORMAPAGO" Then
                                DatosC.Rows(Incre)("Cuenta") = CtaFpago
                            End If
                        End If
                    Next
                End If



                Dim clase As ClContabilidad = New ClContabilidad

                Dim Contabiliza As SamitContab.ListaErrores = clase.SamitContabilizarTb(SMTServidor, Datos.Seguridad.DatosDeLaEmpresa.NumEmpresa, CInt(txtOficina.ValordelControl), CInt(PAño), DatosC)
                If Contabiliza Is Nothing Then
                    MsgBox("Se Presentaron Errores y no se proceso el Documento", MsgBoxStyle.Critical, "Mensaje de SAMIT SQL")
                ElseIf Contabiliza.SiTieneErrores Then

                    For Each Fila As DataRow In Contabiliza.TraerListaErrores.Rows
                        ErroresContab.Agregar_Error(Fila("campo").ToString, Fila("Texto").ToString, Convert.ToUInt64(Fila("Linea")))
                    Next
                    ErroresContab.NombredelProceso = "Contabilizar Documento de NOMINA"
                Else
                    For Each Fila As DataRow In Contabiliza.TraerListaErrores.Rows
                        Dim txtSQL As String = ""
                        If PTipoLiquida = "P" Then
                            txtSQL = String.Format("Update NominaLiquidadaContratos SET Contabilizada = 1, Doccontable = {1}, FormadePago = {2}, EstadoCont='CONTABILIZADO' WHERE Sec = {0}", SecLiquidacionContrato.ToString, Convert.ToUInt64(Fila("Linea")), FilaT("FormaPago").ToString)
                        ElseIf PTipoLiquida = "S" Then
                            txtSQL = String.Format("Update NominaLiquidaSemestresContratos SET Contabilizada = 1, Doccontable = {1}, FormadePago = {2}, EstadoCont='CONTABILIZADO' WHERE Sec = {0}", SecLiquidacionContrato.ToString, Convert.ToUInt64(Fila("Linea")), FilaT("FormaPago").ToString)
                        ElseIf PTipoLiquida = "E" Then
                            txtSQL = String.Format("Update NominaLiquidaExtraordinariaContratos SET Contabilizada = 1, Doccontable = {1}, FormadePago = {2}, EstadoCont='CONTABILIZADO' WHERE Sec = {0}", SecLiquidacionContrato.ToString, Convert.ToUInt64(Fila("Linea")), FilaT("FormaPago").ToString)
                        ElseIf PTipoLiquida = "C" Then
                            txtSQL = String.Format("Update ContratosLiquidados_Contratos SET Contabilizada = 1, Doccontable = {1}, FormadePago = {2}, EstadoCont='CONTABILIZADO' WHERE Sec = {0}", SecLiquidacionContrato.ToString, Convert.ToUInt64(Fila("Linea")), FilaT("FormaPago").ToString)
                        End If
                        SMT_EjcutarComandoSql(ObjetoApiNomina, txtSQL, 0)
                        'ErroresContab.Agregar_Error(Fila("campo").ToString, Fila("mensaje").ToString, Convert.ToUInt64(Fila("Linea")))
                    Next
                End If



                LlenaGridTerceros()
            End If
        Next


        Load.Terminar()
        MsgBox("Proceso terminado!")
        If ErroresContab.NumeroDeErrores > 0 Then
            ErroresContab.Presentar_Informe()
        End If
        If ErroresVal.NumeroDeErrores > 0 Then
            ErroresVal.Presentar_Informe()
        End If
        ErroresContab.Reiniciar()
        activabtn()
    End Sub
    Private Sub VerificarInsertarTerceros()

        Dim Tb As DataTable, TxtSQL As String = String.Format("select * from Empleados  where Identificacion not in (select identificacion from  G_Clientes)")
        Tb = SMT_AbrirTabla(ObjetoApiNomina, TxtSQL)
        If Tb.Rows.Count > 0 Then
            'Dim Tran As SqlTransaction
            'Tran = Conexion.BeginTransaction
            Try
                For Each RegTer As DataRow In Tb.Rows
                    TxtSQL = String.Format("insert into  g_Clientes(idcliente, Identificacion,TipoIdentificacion,dv,Papellido,Sapellido,Pnombre,SNombre,FEchaNacimiento,Direccion,Barrio,Tel1,Tel2,NumCelular) " &
                            "select (select max(idcliente)+1 from  g_clientes), Identificacion, (select codigo from CAT_TiposId  where CAT_TiposId.TipoIdentificacion =  empleados.TipoIdentificacion) ," &
                            "dv,Papellido,Sapellido,Pnombre,SNombre,FechaNacimiento,Direccion,Barrio,Tel1,Tel2,NumCelular " &
                            "from EMPLEADOS where Identificacion = {1}", RegTer("Identificacion"))
                    SMT_EjcutarComandoSql(ObjetoApiNomina, TxtSQL, 0)
                Next
                'Tran.Commit()
                Exit Sub
            Catch ex As Exception
                'Tran.Rollback()
            End Try
        End If


    End Sub
    Private Sub txtCodComp_Enter(sender As Object, e As EventArgs) Handles txtCodComp.Enter
        If txtTipoComprobante.ValordelControl = "" Then
            txtTipoComprobante.Focus()
        End If
    End Sub

    Private Sub txtTipoComprobante_Leave(sender As Object, e As EventArgs) Handles txtTipoComprobante.Leave
        txtCodComp.ConsultaSQL = String.Format("SELECT IdComp AS Codigo, DesComp As Descripcion From E{0}{1}..CT_Comprobantes Where TipoComp='{2}'",
                                               Datos.Seguridad.DatosDeLaEmpresa.NumEmpresa.ToString("000"), Year(Datos.Smt_FechaDeTrabajo).ToString, txtTipoComprobante.ValordelControl)
        txtCodComp.RefrescarDatos()
    End Sub

    Private Sub txtTipoComprobante_Enter(sender As Object, e As EventArgs) Handles txtTipoComprobante.Enter
        txtCodComp.ValordelControl = ""
    End Sub

    Private Sub txtComentario_Enter(sender As Object, e As EventArgs) Handles txtComentario.Enter
        HDevExpre.EntraControlDev(, lblComentarios, txtComentario)
    End Sub

    Private Sub txtComentario_Leave(sender As Object, e As EventArgs) Handles txtComentario.Leave
        HDevExpre.SaleControlDev(, lblComentarios, txtComentario)
    End Sub

    Private Sub txtComentario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtComentario.KeyPress
        HDevExpre.AvanzaConEnter(e)
    End Sub

    Private Sub dteFecha_Enter(sender As Object, e As EventArgs) Handles dteFecha.Enter
        HDevExpre.EntraControlDateEditDEV(dteFecha, lblFecha)
        FrmPrincipal.MensajeDeAyuda.Caption = "Digite la fecha de finalización del contrato. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
    End Sub

    Private Sub dteFecha_Leave(sender As Object, e As EventArgs) Handles dteFecha.Leave
        HDevExpre.SaleControlDateEditDEV(dteFecha, lblFecha)
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        LimpiarTodosCampos()
        Me.Close()
    End Sub

    Private Sub BtnExcell_Click(sender As Object, e As EventArgs) Handles BtnExcell.Click
        Dim Ruta As String = My.Computer.FileSystem.SpecialDirectories.Desktop + "\pruebaexcell.xlsx", Guardar As New SaveFileDialog
        Guardar.Filter = "XlsX Excel|*.Xlsx"
        Guardar.Title = "Guardar Archivo de Excel XlsX"
        Guardar.ShowDialog()
        If Guardar.FileName <> "" Then
            Ruta = Guardar.FileName
            gcConceptosCont.ExportToXlsx(Ruta)
            Process.Start(Ruta)
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If txtTipoComprobante.ValordelControl <> "" And txtCodComp.ValordelControl <> "" Then
            lblSecCom.Text = ConsecutivoServidor(txtTipoComprobante.ValordelControl.ToString, Convert.ToByte(txtCodComp.ValordelControl)).ToString
        Else
            lblSecCom.Text = "0"
        End If

    End Sub
    Public Function ConsecutivoServidor(Tipo As String, IdComp As Byte) As Long
        On Error GoTo ControlError
        Dim Tbl As New DataTable, TxtSQL As String, Consecutivo As Long

INICIA:
        TxtSQL = "Select Numsiguiente, NumAutomatica From CT_Comprobantes " &
                 "Where TipoComp='" & Tipo & "' And IdComp=" & IdComp
        Tbl = SMT_AbrirTabla(Datos.SmtConexionMod, TxtSQL)
        If Tbl.Rows.Count = 1 Then Consecutivo = CLng(Tbl.Rows(0)("NumSiguiente"))
VERIFICA:
        If Tbl.Rows.Count < 1 Then
            TxtSQL = "SELECT COUNT(Doc_Secuencial) as Total From Ct_Documentos Where " &
                     "Doc_TipoComp='" & Tipo & "' And Doc_IdComp=" & IdComp &
                     " and Doc_NumDocumento =" & Consecutivo.ToString
            Tbl = SMT_AbrirTabla(Datos.SmtConexionMod, TxtSQL)
            If CLng(Tbl.Rows(0)("Total")) > 0 Then
                TxtSQL = "Update Ct_Comprobantes Set NumSiguiente =NumSiguiente + 1 Where TipoComp='" & Tipo & "' And IdComp=" & IdComp.ToString
                SMT_EjcutarComandoSql(Datos.SmtConexionMod, TxtSQL, 0)

                GoTo INICIA
            End If
        End If

TERMINA:
        ConsecutivoServidor = Consecutivo
        Tbl.Dispose()
        Tbl = Nothing
        Exit Function
ControlError:

    End Function

    Private Sub gvConceptos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles gvConceptos.KeyPress
        Dim algo = ""
    End Sub

    Private Sub gvConceptos_KeyDown(sender As Object, e As KeyEventArgs) Handles gvConceptos.KeyDown
        If e.KeyCode = 46 Then
            If HDevExpre.MsgSamit(String.Format("Seguro que desea eliminar este dato?"), MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.OK Then
                Dim Tbla As DataTable = CType(gcConceptosCont.DataSource, DataTable)
                If Tbla.Rows.Count > 0 Then
                    Tbla.Rows.Remove(Tbla.Rows(gvConceptos.FocusedRowHandle))
                    gcConceptosCont.DataSource = Tbla
                End If
            End If
        End If
    End Sub

    Private Sub gvConceptos_CustomDrawRowIndicator(sender As Object, e As RowIndicatorCustomDrawEventArgs) Handles gvConceptos.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = (1 + e.RowHandle).ToString
        End If
    End Sub

    Private Sub grbVista_SelectedIndexChanged(sender As Object, e As EventArgs) Handles grbVista.SelectedIndexChanged
        If grbVista.SelectedIndex = 0 Then
            gcTerceros.Visible = True
            gcConceptosCont.Visible = False
        Else
            gcTerceros.Visible = False
            gcConceptosCont.Visible = True
        End If
    End Sub

    Private Sub btnAnular_Click(sender As Object, e As EventArgs) Handles btnAnular.Click
        If HDevExpre.MsgSamit("Seguro que desea anular los documentos de esta liquidación?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.OK Then
            desactivabtn()
            Dim Load As ClEspera = New ClEspera()
            Load.Mostrar("Anulando Documentos Contables!.", "")
            Dim dt As DataTable = CType(gcTerceros.DataSource, DataTable)
            Dim Cont As New SamitContab.ClContabilidad
            Dim rpta As Integer = 0
            Dim Mensaje As String = ""
            For Each Fila As DataRow In dt.Rows
                If Fila("DocContable").ToString <> "" And Fila("EstadoCont").ToString = "CONTABILIZADO" Then
                    SecLiquidacionContrato = ""
                    SecLiquidacionContrato = Fila("SecLiquidacionContrato").ToString
                    Cont.Anular_Documento_Contable(SMTServidor, Datos.Seguridad.DatosDeLaEmpresa.NumEmpresa, CInt(txtOficina.ValordelControl), CInt(PAño), CInt(Fila("DocContable")), rpta, Mensaje)
                    If Mensaje = "El documento ya Fue ANULADO" Or Mensaje = "Proceso OK" Then
                        Dim txtSQL As String = ""
                        If PTipoLiquida = "P" Then
                            txtSQL = String.Format("Update NominaLiquidadaContratos SET EstadoCont='ANULADO' WHERE Sec = {0}", SecLiquidacionContrato.ToString)
                        ElseIf PTipoLiquida = "S" Then
                            txtSQL = String.Format("Update NominaLiquidaSemestresContratos SET EstadoCont='ANULADO' WHERE Sec = {0}", SecLiquidacionContrato.ToString)
                        ElseIf PTipoLiquida = "E" Then
                            txtSQL = String.Format("Update NominaLiquidaExtraordinariaContratos SET EstadoCont='ANULADO' WHERE Sec = {0}", SecLiquidacionContrato.ToString)
                        ElseIf PTipoLiquida = "C" Then
                            txtSQL = String.Format("Update ContratosLiquidados_Contratos SET EstadoCont='ANULADO' WHERE Sec = {0}", SecLiquidacionContrato.ToString)
                        End If
                        SMT_EjcutarComandoSql(ObjetoApiNomina, txtSQL, 0)
                    End If
                End If
            Next
            Load.Terminar()
            LlenaGridTerceros()
            MsgBox("Proceso terminado!")
            activabtn()
        End If
    End Sub
End Class