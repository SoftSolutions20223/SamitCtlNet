Imports SamitCtlNet
Imports DevExpress.XtraVerticalGrid
Imports DevExpress.XtraVerticalGrid.Rows
Imports DevExpress.XtraReports.UI
Imports System.Data
Imports SamitNomina.HelperNomina

Public Class FrmImpNominas
    Dim SecPeriodo As Integer = 0
    Dim Conceptos As New DataTable
    Dim FormularioAbierto As Boolean = False
    Dim TituloLiquida As String
    Dim HDevExpre As New HelperDevExpress
    Dim HNomina As New HelperNomina
    Dim FechaLiquida As String
    Public CodNomina As String
    Public Datos = ObjetosNomina.Datos
    Public Property SecConsulta As Integer
    Public Property TipoConsultaXimprimir As TipoDeLiquidacionImprime
    Public Property SecNomina As Integer
    Public Property DesNomina As String

    Public Sub New(parSecConsulta As Integer, parTipoConsultaXimprimir As TipoDeLiquidacionImprime, parSecNomina As Integer, parDesNomina As String, DescripcionLiquida As String, FechaL As String)
        InitializeComponent()
        TituloLiquida = DescripcionLiquida
        FechaLiquida = FechaL
        Me.SecConsulta = parSecConsulta
        Me.TipoConsultaXimprimir = parTipoConsultaXimprimir
        Me.SecNomina = parSecNomina
        Me.DesNomina = parDesNomina
    End Sub

    Public Property P_FormularioAbierto() As Boolean
        Get
            Return FormularioAbierto
        End Get
        Set(value As Boolean)
            FormularioAbierto = value
        End Set
    End Property
    Private Sub FrmImpNominas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnSalir.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.SalirCuadroConX)
        SimpleButton1.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Liquidaciones)


        CreaGrillaXnomina()


        CreaGrillaXperiodo()
        Consultar()
        Try
            CreagrillaVerticalID(gvRes.GetFocusedRowCellValue("CodContrato").ToString, Me.SecPeriodo,
                                 CInt(gvRes.GetFocusedRowCellValue("IdEmpleado")))
        Catch ex As Exception

        End Try
    End Sub




    Private Sub rgMostrarPor_SelectedIndexChanged(sender As Object, e As EventArgs)
        Try

            gcRes.DataSource = Nothing
            vgIngresosDeducciones.DataSource = Nothing
            gvRes.Columns.Clear()
            vgIngresosDeducciones.Rows.Clear()

        Catch ex As Exception

        End Try
    End Sub


    Private Sub rgMostrarPor_KeyPress(sender As Object, e As KeyPressEventArgs)
        HDevExpre.AvanzaConEnter(e)
    End Sub



    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs)
        gvRes.Columns.Clear()


        CreaGrillaXperiodo()
        vgIngresosDeducciones.Rows.Clear()
        Consultar()

    End Sub

    Private Sub ConsultaXnomina(secNomina As Integer)
        Try
            Dim sql As String = "SELECT PL.Sec AS Codigo, PL.Descripcion FROM NominaLiquidada NL" +
                                " INNER JOIN PeriodosLiquidacion PL ON NL.Periodo = PL.Sec" +
                                " WHERE PL.Nomina = " & secNomina
            Dim dt As DataTable = SMT_AbrirTabla(ObjetoApiNomina, sql)
            gcRes.DataSource = dt
            If dt.Rows.Count = 0 Then HDevExpre.MensagedeError("No se encontraton registros..")
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "ConsultaXnomina")
        End Try
    End Sub
    Private Sub CreaGrillaXnomina()
        Try
            gvRes.Columns.Clear()

            HDevExpre.CreaColumnasG(gvRes, "Codigo", "ID. Periodo", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 25, Me.Width)
            HDevExpre.CreaColumnasG(gvRes, "Descripcion", "Descripción", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 73, Me.Width)
            gvRes.Appearance.HeaderPanel.Font = New Font("Trebuchet MS", 11.0!, FontStyle.Bold)
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "CreaGrillaXnomina")
        End Try
    End Sub

    Private Sub CreaGrillaXperiodo()
        Try
            gvRes.Columns.Clear()

            HDevExpre.CreaColumnasG(gvRes, "IdEmpleado", "ID. Empleado", True, False, "", Color.Aqua, False, False, 18, vgIngresosDeducciones.Width)
            HDevExpre.CreaColumnasG(gvRes, "CodContrato", "CodContrato", False, False, "", Color.Aqua, False, False, 0, 0)
            HDevExpre.CreaColumnasG(gvRes, "Identificacion", "Identificación", True, False, "", Color.Aqua, False, False, 20, vgIngresosDeducciones.Width)
            HDevExpre.CreaColumnasG(gvRes, "Nombres", "Nombres", True, False, "", Color.Aqua, False, False, 60, vgIngresosDeducciones.Width)
            HDevExpre.CreaColumnasG(gvRes, "NomTipoCont", "NomTipoCont", False, False, "", Color.Aqua, False, False, 0, 0)
            HDevExpre.CreaColumnasG(gvRes, "CargoActual", "CargoActual", False, False, "", Color.Aqua, False, False, 0, 0)
            HDevExpre.CreaColumnasG(gvRes, "NomCargo", "NomCargo", False, False, "", Color.Aqua, False, False, 0, 0)
            HDevExpre.CreaColumnasG(gvRes, "FechaInCont", "FechaInCont", False, False, "", Color.Aqua, False, False, 0, 0)
            HDevExpre.CreaColumnasG(gvRes, "codBanco", "codBanco", False, False, "", Color.Aqua, False, False, 0, 0)
            HDevExpre.CreaColumnasG(gvRes, "NumCuenta", "NumCuenta", False, False, "", Color.Aqua, False, False, 0, 0)
            gvRes.Appearance.HeaderPanel.Font = New Font("Trebuchet MS", 11.0!, FontStyle.Bold)
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "CreaGrillaXperiodo")
        End Try
    End Sub
    Private Sub Consultar()
        Try
            Dim sql As String = ""
            Select Case TipoConsultaXimprimir
                Case TipoDeLiquidacionImprime.Ordinaria
                    sql = "SELECT EM.Sec as IdEmpleado, CT.CodContrato,EM.Identificacion, RTRIM(LTRIM(RTRIM(LTRIM(EM.PNombre)) + ' ' +  " +
                        " RTRIM(LTRIM(EM.SNombre)) + ' ' +  RTRIM(LTRIM(EM.PApellido)) + ' ' +  RTRIM(LTRIM(EM.SApellido)))) As Nombres," +
                        " EM.codBanco, EM.NumCuenta," +
                        " TC.NomTipo AS NomTipoCont,CT.CargoActual,CG.Denominacion AS NomCargo, CT.FechaInicio AS FechaIniCont" +
                        " FROM NominaLiquidadaContratos NLC " +
                        " INNER JOIN NominaLiquidada NL ON NLC.NominaLiquidada = NL.Sec " +
                        " INNER JOIN Contratos CT ON NLC.Contrato = CT.CodContrato " +
                        " INNER JOIN Empleados EM ON CT.Empleado = EM.Sec " +
                        " INNER JOIN CAT_TipoContratos TC ON CT.TipoContrato = TC.Sec" +
                        " INNER JOIN Contrato_Cargos CC ON CT.CodContrato = CC.Contrato" +
                        " INNER JOIN cargos CG ON CC.Cargo = CG.Sec" +
                        " WHERE NL.Sec = " & SecConsulta
                Case TipoDeLiquidacionImprime.Extraordinaria
                    sql = "SELECT     EM.Sec as IdEmpleado, CT.CodContrato, EM.Identificacion, " +
                        " RTRIM(LTRIM(RTRIM(LTRIM(EM.PNombre)) + ' ' + RTRIM(LTRIM(EM.SNombre)) + ' ' + " +
                        " RTRIM(LTRIM(EM.PApellido))+ ' ' + RTRIM(LTRIM(EM.SApellido)))) AS Nombres, " +
                        " EM.codBanco, EM.NumCuenta, TC.NomTipo AS NomTipoCont, CT.CargoActual, " +
                        " CG.Denominacion AS NomCargo, CT.FechaInicio AS FechaIniCont" +
                        " FROM NominaLiquidaExtraordinariaContratos AS NLC " +
                        " INNER JOIN NominaLiquidaExtraordinaria AS NL ON NLC.NominaLiquidaExtraordinaria = NL.Sec " +
                        " INNER JOIN Contratos AS CT ON NLC.Contrato = CT.CodContrato " +
                        " INNER JOIN Empleados AS EM ON CT.Empleado = EM.Sec " +
                        " INNER JOIN CAT_TipoContratos AS TC ON CT.TipoContrato = TC.Sec " +
                        " INNER JOIN Contrato_Cargos AS CC ON CT.CodContrato = CC.Contrato " +
                        " INNER JOIN cargos AS CG ON CC.Cargo = CG.Sec" +
                        " WHERE NL.Sec = " & SecConsulta
                Case TipoDeLiquidacionImprime.Semestre
                    sql = "SELECT     EM.Sec as IdEmpleado, CT.CodContrato, EM.Identificacion, " +
                        " RTRIM(LTRIM(RTRIM(LTRIM(EM.PNombre)) + ' ' + RTRIM(LTRIM(EM.SNombre)) + ' ' + " +
                        " RTRIM(LTRIM(EM.PApellido))+ ' ' + RTRIM(LTRIM(EM.SApellido)))) AS Nombres, " +
                        " EM.codBanco, EM.NumCuenta, TC.NomTipo AS NomTipoCont, CT.CargoActual, CG.Denominacion AS NomCargo, " +
                        " CT.FechaInicio AS FechaIniCont" +
                        " FROM NominaLiquidaSemestresContratos AS NLC " +
                        " INNER JOIN NominaLiquidaSemestres AS NL ON NLC.NominaLiquidaSemestres = NL.Sec " +
                        " INNER JOIN Contratos AS CT ON NLC.Contrato = CT.CodContrato " +
                        " INNER JOIN Empleados AS EM ON CT.Empleado = EM.Sec " +
                        " INNER JOIN CAT_TipoContratos AS TC ON CT.TipoContrato = TC.Sec " +
                        " INNER JOIN Contrato_Cargos AS CC ON CT.CodContrato = CC.Contrato " +
                        " INNER JOIN cargos AS CG ON CC.Cargo = CG.Sec" +
                        " WHERE NL.Sec = " & SecConsulta
                Case TipoDeLiquidacionImprime.LiquidaContratos
                    sql = "SELECT     EM.Sec as IdEmpleado, CT.CodContrato, EM.Identificacion, " +
                        " RTRIM(LTRIM(RTRIM(LTRIM(EM.PNombre)) + ' ' + RTRIM(LTRIM(EM.SNombre)) + ' ' + " +
                        " RTRIM(LTRIM(EM.PApellido))+ ' ' + RTRIM(LTRIM(EM.SApellido)))) AS Nombres, " +
                        " EM.codBanco, EM.NumCuenta, TC.NomTipo AS NomTipoCont, CT.CargoActual, CG.Denominacion AS NomCargo, " +
                        " CT.FechaInicio AS FechaIniCont" +
                        " FROM ContratosLiquidados_Contratos AS NLC " +
                        " INNER JOIN ContratosLiquidados  NL ON NLC.NominaLiquida = NL.Sec " +
                        " INNER JOIN Contratos AS CT ON NLC.Contrato = CT.CodContrato " +
                        " INNER JOIN Empleados AS EM ON CT.Empleado = EM.Sec " +
                        " INNER JOIN CAT_TipoContratos AS TC ON CT.TipoContrato = TC.Sec " +
                        " INNER JOIN Contrato_Cargos AS CC ON CT.CodContrato = CC.Contrato " +
                        " INNER JOIN cargos AS CG ON CC.Cargo = CG.Sec" +
                        " WHERE NL.Sec = " & SecConsulta
                Case Else

            End Select

            Dim dt As DataTable = SMT_AbrirTabla(ObjetoApiNomina, sql)
            If dt.Rows.Count = 0 Then
                HDevExpre.mensajeExitoso("No se encontraron regostros...")
                'txtPeriodo.Focus()
                Exit Sub
            End If
            gcRes.DataSource = dt
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "ConsultaXperiodo")
        End Try

    End Sub


    Private Sub CreagrillaVerticalID(CodContrato As String, codPeriodo As Integer, idEmp As Integer)
        vgIngresosDeducciones.Rows.Clear()
        vgIngresosDeducciones.OptionsBehavior.Editable = False
        vgIngresosDeducciones.OptionsBehavior.ResizeHeaderPanel = False
        vgIngresosDeducciones.OptionsBehavior.ResizeRowHeaders = False
        vgIngresosDeducciones.RowHeaderWidth = CInt((50 * (vgIngresosDeducciones.Width)) / 100)
        vgIngresosDeducciones.RecordWidth = CInt((50 * (vgIngresosDeducciones.Width)) / 100)
        Dim scrollvisible As Boolean = vgIngresosDeducciones.ScrollVisibility
        If scrollvisible Then
            vgIngresosDeducciones.RecordWidth = CInt((55 * (vgIngresosDeducciones.Width)) / 100 - 20)
        End If

        Try
            Dim sql = ""
            Dim filas As New DataTable
            Dim NuevaFila As DataRow = filas.NewRow()
            Dim Columnas As New DataTable
            Dim Valores As New DataTable
            Dim Formula As String = ""

            Select Case TipoConsultaXimprimir
                Case TipoDeLiquidacionImprime.Ordinaria
                    GoTo NominaNormal
                Case TipoDeLiquidacionImprime.Extraordinaria
                    GoTo LiquidacionExtraordinaria
                Case TipoDeLiquidacionImprime.LiquidaContratos
                    GoTo LiquidacionDeContrato
                Case TipoDeLiquidacionImprime.Semestre
                    GoTo LiquidacionSemestral
                Case Else
            End Select

NominaNormal:
            sql = String.Format("SELECT CN.NomConcepto AS Nombre, CN.Formula AS Formula,TC.NomTipo AS Tipo,CN.Sec AS Sec   " +
            " FROM ConceptosNomina CN  " +
            " INNER JOIN NominaLiquidadaConceptos CP ON CP.SecConcepto = CN.Sec  " +
            " INNER JOIN TiposConceptosNomina TC ON TC.Sec = CN.Tipo  " +
            " INNER JOIN NominaLiquidadaContratos P ON CP.LiquidadaContrato = P.Sec" +
            " Where P.Contrato = {0}" +
            " UNION" +
            " SELECT CN.NomConcepto AS Nombre, '' AS Formula,'Descuentos' AS Tipo,CN.Sec AS Sec   " +
            " FROM ConceptosPersonales CN  " +
            " INNER JOIN ConceptosP_Contratos CP ON CP.Concepto = CN.Sec  " +
            " INNER JOIN Contratos C ON C.CodContrato = CP.Contrato  " +
            " WHERE  C.CodContrato ={0}", CodContrato)
            Columnas = SMT_AbrirTabla(ObjetoApiNomina, sql) 'Consulta las columnas
            'Crea script para los valores
            sql = String.Format("SELECT CP.Sec AS SecConcep,CP.NomConcepto, NLC.Valor, CP.Tipo, TP.NomTipo  " +
            " FROM NominaLiquidadaConceptos NLC " +
            " INNER JOIN NominaLiquidadaContratos NCT ON NLC.LiquidadaContrato = NCT.Sec " +
            " INNER JOIN NominaLiquidada NL ON NCT.NominaLiquidada = NL.Sec " +
            " INNER JOIN Contratos CT ON NCT.Contrato = CT.CodContrato " +
            " INNER JOIN ConceptosNomina CP ON NLC.SecConcepto = CP.Sec " +
            " INNER JOIN TiposConceptosNomina TP ON CP.Tipo = TP.Sec " +
            " WHERE NL.Sec = {0} And CT.Empleado = {1} And CT.CodContrato = {2}" +
            " UNION" +
            " SELECT CP.Sec AS SecConcep,CP.NomConcepto, NLC.Valor, '0' AS Tipo, 'Descuentos' AS NomTipo  " +
            " FROM NominaLiquidadaConceptos NLC " +
            " INNER JOIN NominaLiquidadaContratos NCT ON NLC.LiquidadaContrato = NCT.Sec " +
            " INNER JOIN NominaLiquidada NL ON NCT.NominaLiquidada = NL.Sec " +
            " INNER JOIN Contratos CT ON NCT.Contrato = CT.CodContrato " +
            " INNER JOIN ConceptosPersonales CP ON NLC.SecConceptoP = CP.Sec " +
            " WHERE NL.Sec = {0} And CT.Empleado = {1} AND CT.CodContrato = {2}", SecConsulta, idEmp, CodContrato)
            GoTo SiguientePaso
LiquidacionExtraordinaria:
            'sql = String.Format("SELECT CN.NomConcepto AS Nombre, CN.Formula, TC.NomTipo AS Tipo, CN.Sec " +
            '" FROM ConceptosNomina AS CN " +
            '" INNER JOIN NominaLiquidaExtraordinariaConceptos AS CP ON CP.SecConcepto = CN.Sec " +
            '" INNER JOIN TiposConceptosNomina AS TC ON TC.Sec = CN.Tipo " +
            '" INNER JOIN NominaLiquidaExtraordinariaContratos AS P ON CP.LiquidaContrato = P.Sec" +
            '" WHERE P.Contrato = {0}" +
            '" UNION" +
            '" SELECT CN.NomConcepto AS Nombre, '' AS Formula, 'Descuentos' AS Tipo, CN.Sec" +
            '" FROM ConceptosPersonales AS CN " +
            '" INNER JOIN ConceptosP_Contratos AS CP ON CP.Concepto = CN.Sec " +
            '" INNER JOIN Contratos AS C ON C.CodContrato = CP.Contrato" +
            '" WHERE C.CodContrato = {0}", CodContrato)
            'Columnas = SMT_AbrirTabla(ObjetoApiNomina, sql) 'Consulta las columnas
            sql = String.Format("SELECT CP.Sec AS SecConcep, CP.NomConcepto, NLC.Valor, CP.Tipo, CAST(CASE WHEN TP.NomTipo='Provisiones' THEN 'Ingresos' ELSE TP.NomTipo END AS VARCHAR) AS NomTipo " +
            " FROM NominaLiquidaExtraordinariaConceptos AS NLC " +
            " INNER JOIN NominaLiquidaExtraordinariaContratos AS NCT ON NLC.LiquidaContrato = NCT.Sec " +
            " INNER JOIN NominaLiquidaExtraordinaria AS NL ON NCT.NominaLiquidaExtraordinaria = NL.Sec " +
            " INNER JOIN Contratos AS CT ON NCT.Contrato = CT.CodContrato " +
            " INNER JOIN ConceptosNomina AS CP ON NLC.SecConcepto = CP.Sec " +
            " INNER JOIN TiposConceptosNomina AS TP ON CP.Tipo = TP.Sec" +
            " WHERE (NL.Sec = {0}) AND (CT.Empleado = {1}) AND (CT.CodContrato = {2})" +
            " UNION" +
            " SELECT CP.Sec AS SecConcep, CP.NomConcepto, NLC.Valor, '0' AS Tipo, 'Descuentos' AS NomTipo" +
            " FROM NominaLiquidaExtraordinariaConceptos AS NLC " +
            " INNER JOIN NominaLiquidaExtraordinariaContratos AS NCT ON NLC.LiquidaContrato = NCT.Sec " +
            " INNER JOIN NominaLiquidaExtraordinaria AS NL ON NCT.NominaLiquidaExtraordinaria = NL.Sec " +
            " INNER JOIN Contratos AS CT ON NCT.Contrato = CT.CodContrato " +
            " INNER JOIN ConceptosPersonales AS CP ON NLC.SecConceptoP = CP.Sec" +
            " WHERE (NL.Sec = {0}) AND (CT.Empleado = {1}) AND (CT.CodContrato = {2})", SecConsulta, idEmp, CodContrato)
            GoTo SiguientePaso
LiquidacionSemestral:
            'sql = String.Format("SELECT CN.NomConcepto AS Nombre, CN.Formula, TC.NomTipo AS Tipo, CN.Sec " +
            '" FROM ConceptosNomina AS CN " +
            '" INNER JOIN NominaLiquidaSemestresConceptos AS CP ON CP.SecConcepto = CN.Sec " +
            '" INNER JOIN TiposConceptosNomina AS TC ON TC.Sec = CN.Tipo " +
            '" INNER JOIN NominaLiquidaSemestresContratos AS P ON CP.LiquidaContrato = P.Sec" +
            '" WHERE P.Contrato = {0}" +
            '" UNION" +
            '" SELECT CN.NomConcepto AS Nombre, '' AS Formula, 'Descuentos' AS Tipo, CN.Sec" +
            '" FROM ConceptosPersonales AS CN " +
            '" INNER JOIN ConceptosP_Contratos AS CP ON CP.Concepto = CN.Sec " +
            '" INNER JOIN Contratos AS C ON C.CodContrato = CP.Contrato" +
            '" WHERE C.CodContrato = {0}", CodContrato)
            'Columnas = SMT_AbrirTabla(ObjetoApiNomina, sql) 'Consulta las columnas
            sql = String.Format("SELECT CP.Sec AS SecConcep, CP.NomConcepto, NLC.Valor, CP.Tipo, CAST(CASE WHEN TP.NomTipo='Provisiones' THEN 'Ingresos' ELSE TP.NomTipo END AS VARCHAR) AS NomTipo" +
            " FROM NominaLiquidaSemestresConceptos AS NLC " +
            " INNER JOIN NominaLiquidaSemestresContratos AS NCT ON NLC.LiquidaContrato = NCT.Sec " +
            " INNER JOIN NominaLiquidaSemestres AS NL ON NCT.NominaLiquidaSemestres = NL.Sec " +
            " INNER JOIN Contratos AS CT ON NCT.Contrato = CT.CodContrato " +
            " INNER JOIN ConceptosNomina AS CP ON NLC.SecConcepto = CP.Sec " +
            " INNER JOIN TiposConceptosNomina AS TP ON CP.Tipo = TP.Sec" +
            " WHERE (NL.Sec = {0}) AND (CT.Empleado = {1}) AND (CT.CodContrato = {2})" +
            " UNION" +
            " SELECT CP.Sec AS SecConcep, CP.NomConcepto, NLC.Valor, '0' AS Tipo, 'Descuentos' AS NomTipo" +
            " FROM NominaLiquidaSemestresConceptos AS NLC " +
            " INNER JOIN NominaLiquidaSemestresContratos AS NCT ON NLC.LiquidaContrato = NCT.Sec " +
            " INNER JOIN NominaLiquidaSemestres AS NL ON NCT.NominaLiquidaSemestres = NL.Sec " +
            " INNER JOIN Contratos AS CT ON NCT.Contrato = CT.CodContrato " +
            " INNER JOIN ConceptosPersonales AS CP ON NLC.SecConceptoP = CP.Sec" +
            " WHERE (NL.Sec = {0}) AND (CT.Empleado = {1}) AND (CT.CodContrato = {2})", SecConsulta, idEmp, CodContrato)
            GoTo SiguientePaso
LiquidacionDeContrato:
            'sql = String.Format("SELECT CN.NomConcepto AS Nombre, CN.Formula, TC.NomTipo AS Tipo, CN.Sec " +
            '" FROM ConceptosNomina AS CN " +
            '" INNER JOIN ContratosLiquidados_Conceptos AS CP ON CP.SecConcepto = CN.Sec " +
            '" INNER JOIN TiposConceptosNomina AS TC ON TC.Sec = CN.Tipo " +
            '" INNER JOIN ContratosLiquidados_Contratos AS P ON CP.LiquidaContrato = P.Sec" +
            '" WHERE P.Contrato = {0}" +
            '" UNION" +
            '" SELECT CN.NomConcepto AS Nombre, '' AS Formula, 'Descuentos' AS Tipo, CN.Sec" +
            '" FROM ConceptosPersonales AS CN " +
            '" INNER JOIN ConceptosP_Contratos AS CP ON CP.Concepto = CN.Sec " +
            '" INNER JOIN Contratos AS C ON C.CodContrato = CP.Contrato" +
            '" WHERE C.CodContrato = {0}", CodContrato)
            'Columnas = SMT_AbrirTabla(ObjetoApiNomina, sql) 'Consulta las columnas
            sql = String.Format("SELECT CP.Sec AS SecConcep, CP.NomConcepto, NLC.Valor, CP.Tipo, CAST(CASE WHEN TP.NomTipo='Provisiones' THEN 'Ingresos' ELSE TP.NomTipo END AS VARCHAR) AS NomTipo " +
            " FROM ContratosLiquidados_Conceptos AS NLC " +
            " INNER JOIN ContratosLiquidados_Contratos AS NCT ON NLC.LiquidaContrato = NCT.Sec " +
            " INNER JOIN ContratosLiquidados AS NL ON NCT.NominaLiquida = NL.Sec " +
            " INNER JOIN Contratos AS CT ON NCT.Contrato = CT.CodContrato " +
            " INNER JOIN ConceptosNomina AS CP ON NLC.SecConcepto = CP.Sec " +
            " INNER JOIN TiposConceptosNomina AS TP ON CP.Tipo = TP.Sec" +
            " WHERE (NL.Sec = {0}) AND (CT.Empleado = {1}) AND (CT.CodContrato = {2})", SecConsulta, idEmp, CodContrato)
            GoTo SiguientePaso
SiguientePaso:
            Valores = SMT_AbrirTabla(ObjetoApiNomina, sql)
            Dim f As DataTable = Valores.DefaultView.ToTable(True, "NomTipo")
            If f.Rows.Count > 0 Then

                For incre As Integer = 0 To f.Rows.Count - 1
                    If f.Rows(incre)("NomTipo").ToString = "Ingresos" Then
                        CreaFilas(vgIngresosDeducciones, f.Rows(incre)("NomTipo").ToString, f.Rows(incre)("NomTipo").ToString, True, True, "0", True, False, Nothing)
                    End If
                Next
                For incre As Integer = 0 To f.Rows.Count - 1
                    If f.Rows(incre)("NomTipo").ToString = "Deducciones" Then
                        CreaFilas(vgIngresosDeducciones, f.Rows(incre)("NomTipo").ToString, f.Rows(incre)("NomTipo").ToString, True, True, "0", True, False, Nothing)
                    End If
                Next
                For incre As Integer = 0 To f.Rows.Count - 1
                    If f.Rows(incre)("NomTipo").ToString = "Descuentos" Then
                        CreaFilas(vgIngresosDeducciones, f.Rows(incre)("NomTipo").ToString, f.Rows(incre)("NomTipo").ToString, True, True, "0", True, False, Nothing)
                    End If
                Next
                For incre As Integer = 0 To f.Rows.Count - 1
                    If f.Rows(incre)("NomTipo").ToString = "Provisiones" Then
                        CreaFilas(vgIngresosDeducciones, f.Rows(incre)("NomTipo").ToString, f.Rows(incre)("NomTipo").ToString, True, True, "0", True, False, Nothing)
                    End If
                Next

                Dim filaValida As EditorRow = TryCast(vgIngresosDeducciones.GetRowByCaption("Ingresos"), EditorRow)
                If Not IsNothing(filaValida) Then Formula = "[Ingresos]"
                filaValida = TryCast(vgIngresosDeducciones.GetRowByCaption("Deducciones"), EditorRow)
                If Not IsNothing(filaValida) Then
                    If Formula <> "" Then Formula += "-[Deducciones]" Else Formula = "[Deducciones]"
                End If
                filaValida = TryCast(vgIngresosDeducciones.GetRowByCaption("Descuentos"), EditorRow)
                If Not IsNothing(filaValida) Then
                    If Formula <> "" Then Formula += "-[Descuentos]" Else Formula = "[Descuentos]"
                End If
                CreaFilas(vgIngresosDeducciones, "Total", "NETO A PAGAR ...", True, True, Formula, True, False, Nothing)
                vgIngresosDeducciones.Rows("Total").Appearance.Font = New Font("Segoe UI", 11, FontStyle.Bold)
            End If

            Conceptos = Valores
            If Valores.Rows.Count > 0 Then
                For incre As Integer = 0 To Valores.Rows.Count - 1
                    Dim categoria As EditorRow = TryCast(vgIngresosDeducciones.GetRowByCaption(Valores.Rows(incre)("NomTipo").ToString), EditorRow)
                    Dim Formu As String = categoria.Properties.UnboundExpression

                    Formu = Formu + " + " + "[" + Valores.Rows(incre)("NomConcepto").ToString + "]"

                    categoria.Properties.UnboundExpression = Formu
                    categoria.Appearance.Font = New Font("Segoe UI", 11, FontStyle.Bold)
                    CreaFilas(vgIngresosDeducciones, Valores.Rows(incre)("NomConcepto").ToString, Valores.Rows(incre)("NomConcepto").ToString,
                              True, True, "", True, True, categoria)
                    filas.Columns.Add(Valores.Rows(incre)("NomConcepto").ToString, GetType(Decimal))
                    Dim ConcepEncontrado As Boolean = False
                    For i = 0 To Valores.Rows.Count - 1
                        If CInt(Valores.Rows(i)("SecConcep")) = CInt(Valores.Rows(incre)("SecConcep")) AndAlso Valores.Rows(i)("NomTipo").ToString = Valores.Rows(incre)("NomTipo").ToString Then
                            'AQUI HAY UN PROBLEMA, SE TROCAN LOS CONCEPTOS PERSONALES POR SECUENCIAL
                            NuevaFila(Valores.Rows(i)("NomConcepto").ToString) = Valores.Rows(i)("Valor").ToString
                            ConcepEncontrado = True
                            Exit For
                        End If
                    Next
                    If Not ConcepEncontrado Then
                        NuevaFila(Valores.Rows(incre)("NomConcepto").ToString) = "0"
                    End If
                    categoria.Properties.UnboundExpression = Formu
                Next

            End If
            filas.Rows.Add(NuevaFila)
            filas.AcceptChanges()
            vgIngresosDeducciones.DataSource = filas

            Dim classResize As New ClaseResize
            classResize.ResizaVgridCatgorias(vgIngresosDeducciones)
            vgIngresosDeducciones.RowHeaderWidth = 200
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "CreagrillaVerticalID")
        End Try
    End Sub

    Private Sub CreaFilas(Grid As VGridControl, Nombre As String, Titulo As String,
                          Visible As Boolean, Editar As Boolean, formula As String,
                          numerico As Boolean, FilaHija As Boolean, filact As EditorRow)
        Try
            Dim Fila As New EditorRow
            With Fila
                .Name = Nombre
                .Properties.Caption = Titulo
                .Properties.FieldName = Nombre
                If Not Visible Then
                    .Visible = False
                Else
                    .Properties.ShowUnboundExpressionMenu = True
                    .Properties.Format.FormatString = "c2"
                    .Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric
                    .Properties.UnboundType = DevExpress.Data.UnboundColumnType.Decimal
                    .Properties.UnboundExpression = formula
                End If
            End With

            If FilaHija Then
                filact.ChildRows.Add(Fila)
                Dim classResize As New ClaseResize
                classResize.ResizaVgridRows(Fila)

            Else

                Grid.Rows.Add(Fila)
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "CreaFilas")
        End Try
    End Sub

    Private Sub txtOficina_Leave(sender As Object, e As EventArgs)
        'If txtOficina.ValordelControl <> "" Then
        '    txtNomina.ConsultaSQL = String.Format("SELECT SecNomina AS Codigo,NomNomina AS Descripcion FROM  Nominas NM" +
        '                            " LEFT JOIN  PeriodosLiquidacion PL ON NM.SecNomina = PL.Nomina " +
        '                            " WHERE PL.Estado = 'L' AND NM.Oficina = {1} GROUP BY SecNomina, NomNomina ", NombreBdNomina, txtOficina.ValordelControl)
        '    txtNomina.RefrescarDatos()
        '    txtNomina.TieneErrorControl = False
        '    txtPeriodo.TieneErrorControl = False
        'End If
    End Sub

    Private Sub gvRes_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvRes.FocusedRowChanged
        Try
            CreagrillaVerticalID(gvRes.GetFocusedRowCellValue("CodContrato").ToString, Me.SecPeriodo,
                                 CInt(gvRes.GetFocusedRowCellValue("IdEmpleado")))
        Catch ex As Exception

        End Try
    End Sub

    Private Sub gvRes_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gvRes.RowClick
        Try
            CreagrillaVerticalID(gvRes.GetFocusedRowCellValue("CodContrato").ToString, Me.SecPeriodo,
                                 CInt(gvRes.GetFocusedRowCellValue("IdEmpleado")))
        Catch ex As Exception

        End Try
    End Sub




    Private Sub ImprimeXempleado(CodContrato As String, codPeriodo As Integer, idEmp As Integer, docTer As String, nomTer As String,
                                     nomTipoContrato As String, nomCargo As String, fechaIniContrato As String, codBanco As Integer, NumCuenta As String)
        Try
            Dim dtEntidades As DataTable
            Dim nomEPS As String = "No Registra"
            Dim nomAfp As String = "No Registra"
            Dim nomArp As String = "No Registra"
            Dim nomCaja As String = "No Registra"
            Dim nomBanco As String = "No Registra"
            Dim fechaPeriodo As String = ""
            'INICIA CONSULTA DE INGRESOS Y DEDUCCIONES

            Dim sql As String = String.Format("SELECT CP.Sec AS SecConcep,CP.NomConcepto, NLC.Valor, CP.Tipo, TP.NomTipo, PL.FechaInicio, PL.FechaFin, " +
            " NLC.NomBase, NLC.Base" +
            " FROM NominaLiquidadaConceptos NLC " +
            " INNER JOIN NominaLiquidadaContratos NCT ON NLC.LiquidadaContrato = NCT.Sec " +
            " INNER JOIN NominaLiquidada NL ON NCT.NominaLiquidada = NL.Sec " +
            " INNER JOIN Contratos CT ON NCT.Contrato = CT.CodContrato " +
            " INNER JOIN ConceptosNomina CP ON NLC.SecConcepto = CP.Sec " +
            " INNER JOIN TiposConceptosNomina TP ON CP.Tipo = TP.Sec " +
            " INNER JOIN PeriodosLiquidacion PL ON NL.Periodo = PL.Sec" +
            " WHERE NL.Sec = {0} And CT.Empleado = {1} And CT.CodContrato = {2} And NLC.Valor > 0" +
            " UNION" +
            " SELECT CPL.Sec AS SecConcep,CPL.NomConcepto, NLC.Valor, '0' AS Tipo, 'Descuentos' AS NomTipo, PL.FechaInicio, PL.FechaFin, " +
            " NLC.NomBase, NLC.Base" +
            " FROM NominaLiquidadaConceptos NLC " +
            " INNER JOIN NominaLiquidadaContratos NCT ON NLC.LiquidadaContrato = NCT.Sec " +
            " INNER JOIN NominaLiquidada NL ON NCT.NominaLiquidada = NL.Sec " +
            " INNER JOIN Contratos CT ON NCT.Contrato = CT.CodContrato " +
            " INNER JOIN PeriodosLiquidacion PL ON NL.Periodo = PL.Sec" +
            " INNER JOIN ConceptosPersonales CPL ON NLC.SecConceptoP = CPL.Sec" +
            " WHERE NL.Sec = {0} And CT.Empleado = {1} AND CT.CodContrato = {2} AND NLC.Valor > 0", SecConsulta, idEmp, CodContrato)

            If TipoConsultaXimprimir = TipoDeLiquidacionImprime.Extraordinaria Then
                sql = String.Format("SELECT CP.Sec AS SecConcep, CP.NomConcepto, NLC.Valor, CP.Tipo, " +
                " CAST(CASE WHEN TP.NomTipo = 'Provisiones' THEN 'Ingresos' ELSE TP.NomTipo END AS VARCHAR) AS NomTipo," +
                " PL.FechaInicio, PL.FechaFin, NLC.NomBase, NLC.Base" +
                " FROM NominaLiquidaExtraordinariaConceptos AS NLC " +
                " INNER JOIN NominaLiquidaExtraordinariaContratos AS NCT ON NLC.LiquidaContrato = NCT.Sec " +
                " INNER JOIN NominaLiquidaExtraordinaria AS NL ON NCT.NominaLiquidaExtraordinaria = NL.Sec " +
                " INNER JOIN Contratos AS CT ON NCT.Contrato = CT.CodContrato " +
                " INNER JOIN ConceptosNomina AS CP ON NLC.SecConcepto = CP.Sec " +
                " INNER JOIN TiposConceptosNomina AS TP ON CP.Tipo = TP.Sec " +
                " INNER JOIN PeriodosLiquidacion AS PL ON NL.Sec = PL.Sec" +
                " WHERE (NL.Sec = {0}) AND (CT.Empleado = {1}) AND (CT.CodContrato = {2}) AND (NLC.Valor > 0)" +
                " UNION   " +
                " SELECT CPL.Sec AS SecConcep, CPL.NomConcepto, NLC.Valor, '0' AS Tipo, 'Descuentos' AS NomTipo, PL.FechaInicio, PL.FechaFin, NLC.NomBase, NLC.Base" +
                " FROM NominaLiquidaExtraordinariaConceptos AS NLC " +
                " INNER JOIN NominaLiquidaExtraordinariaContratos AS NCT ON NLC.LiquidaContrato = NCT.Sec " +
                " INNER JOIN NominaLiquidaExtraordinaria AS NL ON NCT.NominaLiquidaExtraordinaria = NL.Sec " +
                " INNER JOIN Contratos AS CT ON NCT.Contrato = CT.CodContrato " +
                " INNER JOIN PeriodosLiquidacion AS PL ON NL.Sec = PL.Sec " +
                " INNER JOIN ConceptosPersonales AS CPL ON NLC.SecConceptoP = CPL.Sec" +
                " WHERE (NL.Sec = {0}) AND (CT.Empleado = {1}) AND (CT.CodContrato = {2}) AND (NLC.Valor > 0)", SecConsulta, idEmp, CodContrato)
            ElseIf TipoConsultaXimprimir = TipoDeLiquidacionImprime.Semestre Then
                sql = String.Format("SELECT CP.Sec AS SecConcep, CP.NomConcepto, NLC.Valor, CP.Tipo, " +
                " CAST(CASE WHEN TP.NomTipo = 'Provisiones' THEN 'Ingresos' ELSE TP.NomTipo END AS VARCHAR) AS NomTipo, " +
                " PL.FechaInicio, PL.FechaFin, NLC.NomBase, NLC.Base" +
                " FROM NominaLiquidaSemestresConceptos AS NLC " +
                " INNER JOIN NominaLiquidaSemestresContratos AS NCT ON NLC.LiquidaContrato = NCT.Sec " +
                " INNER JOIN NominaLiquidaSemestres AS NL ON NCT.NominaLiquidaSemestres = NL.Sec " +
                " INNER JOIN Contratos AS CT ON NCT.Contrato = CT.CodContrato " +
                " INNER JOIN ConceptosNomina AS CP ON NLC.SecConcepto = CP.Sec " +
                " INNER JOIN TiposConceptosNomina AS TP ON CP.Tipo = TP.Sec " +
                " INNER JOIN PeriodosLiquidacion AS PL ON NL.Sec = PL.Sec" +
                " WHERE (NL.Sec = {0}) AND (CT.Empleado = {1}) AND (CT.CodContrato = {2}) AND (NLC.Valor > 0)" +
                " UNION" +
                " SELECT CPL.Sec AS SecConcep, CPL.NomConcepto, NLC.Valor, '0' AS Tipo, 'Descuentos' AS NomTipo, PL.FechaInicio, PL.FechaFin, NLC.NomBase, NLC.Base" +
                " FROM NominaLiquidaSemestresConceptos AS NLC " +
                " INNER JOIN NominaLiquidaSemestresContratos AS NCT ON NLC.LiquidaContrato = NCT.Sec " +
                " INNER JOIN NominaLiquidaSemestres AS NL ON NCT.NominaLiquidaSemestres = NL.Sec " +
                " INNER JOIN Contratos AS CT ON NCT.Contrato = CT.CodContrato " +
                " INNER JOIN PeriodosLiquidacion AS PL ON NL.Sec = PL.Sec " +
                " INNER JOIN ConceptosPersonales AS CPL ON NLC.SecConceptoP = CPL.Sec" +
                " WHERE (NL.Sec = {0}) AND (CT.Empleado = {1}) AND (CT.CodContrato = {2}) AND (NLC.Valor > 0)", SecConsulta, idEmp, CodContrato)
            ElseIf TipoConsultaXimprimir = TipoDeLiquidacionImprime.LiquidaContratos Then
                sql = String.Format("SELECT CP.Sec AS SecConcep, CP.NomConcepto, NLC.Valor, CP.Tipo, " +
                " CAST(CASE WHEN TP.NomTipo = 'Provisiones' THEN 'Ingresos' ELSE TP.NomTipo END AS VARCHAR) AS NomTipo, " +
                " PL.FechaInicio, PL.FechaFin, NLC.NomBase, NLC.Base" +
                " FROM ContratosLiquidados_Conceptos AS NLC " +
                " INNER JOIN ContratosLiquidados_Contratos AS NCT ON NLC.LiquidaContrato = NCT.Sec " +
                " INNER JOIN ContratosLiquidados AS NL ON NCT.NominaLiquida = NL.Sec " +
                " INNER JOIN Contratos AS CT ON NCT.Contrato = CT.CodContrato " +
                " INNER JOIN ConceptosNomina AS CP ON NLC.SecConcepto = CP.Sec " +
                " INNER JOIN TiposConceptosNomina AS TP ON CP.Tipo = TP.Sec " +
                " INNER JOIN PeriodosLiquidacion AS PL ON NL.Sec = PL.Sec" +
                " WHERE (NL.Sec = {0}) AND (CT.Empleado = {1}) AND (CT.CodContrato = {2}) AND (NLC.Valor > 0)", SecConsulta, idEmp, CodContrato)
            End If
            Dim consultas() As String = {sql,
                String.Format("SELECT ES.NombreEntidad,ES.TipoEnte FROM Empleados EM" +
            " INNER JOIN EntesTercero ET ON EM.Sec = ET.Empleado" +
            " INNER JOIN EntesSSAP ES ON ET.SecEntesSSAP = ES.Sec" +
            " WHERE ET.Empleado={0} AND ET.Retirado = 0", idEmp)}
            Dim DatosC = SMT_GetDataset(ObjetoApiNomina, consultas)
            Dim dt As DataTable = DatosC.Tables(0)
            If dt.Rows.Count = 0 Then
                HDevExpre.MensagedeError("Lo sentimos, ha ocurrido un error al cargar la información, por favor vuelva a intentarlo.")
                Exit Sub
            End If
            fechaPeriodo = "" + CDate(dt.Rows(0)("FechaInicio")).ToString("MMMM dd' de 'yyyy ") + " y " + CDate(dt.Rows(0)("FechaFin")).ToString("MMMM dd' de 'yyyy ")
            Dim dtFinal As DataTable = New DataTable
            dtFinal.Columns.Add("SecConcep", GetType(Integer))
            dtFinal.Columns.Add("NomConcepto", GetType(String))
            dtFinal.Columns.Add("NomBase", GetType(String))
            dtFinal.Columns.Add("Base", GetType(Decimal))
            dtFinal.Columns.Add("Descuentos", GetType(Decimal))
            dtFinal.Columns.Add("Ingresos", GetType(Decimal))
            dtFinal.Columns.Add("Deducciones", GetType(Decimal))
            For Each fila As DataRow In dt.Rows
                Dim f As DataRow = dtFinal.NewRow
                Select Case fila("NomTipo").ToString
                    Case Is = "Ingresos"
                        f("SecConcep") = fila("SecConcep")
                        f("NomConcepto") = fila("NomConcepto")
                        f("NomBase") = fila("NomBase")
                        f("Base") = fila("Base")
                        f("Ingresos") = fila("Valor")
                        f("Descuentos") = 0
                        f("Deducciones") = 0
                        dtFinal.Rows.Add(f)
                        dtFinal.AcceptChanges()
                    Case Is = "Deducciones"
                        f("SecConcep") = fila("SecConcep")
                        f("NomConcepto") = fila("NomConcepto")
                        f("NomBase") = fila("NomBase")
                        f("Base") = fila("Base")
                        f("Ingresos") = 0
                        f("Deducciones") = fila("Valor")
                        f("Descuentos") = 0
                        dtFinal.Rows.Add(f)
                        dtFinal.AcceptChanges()
                    Case Is = "Descuentos"
                        f("SecConcep") = fila("SecConcep")
                        f("NomConcepto") = fila("NomConcepto")
                        f("NomBase") = fila("NomBase")
                        f("Base") = fila("Base")
                        f("Ingresos") = 0
                        f("Deducciones") = 0
                        f("Descuentos") = fila("Valor")
                        dtFinal.Rows.Add(f)
                        dtFinal.AcceptChanges()
                End Select
            Next
            Dim RPT As New RptDesprendibleNomina

            Dim tel1 = "", tel2 = "", tels As String = ""
            RPT.lblNitEmp.Text = String.Format("Nit: {0}-{1}    {2}", Datos.Seguridad.DatosDeLaEmpresa.Nit, Datos.Seguridad.DatosDeLaEmpresa.DV, Datos.Seguridad.DatosDeLaEmpresa.RegimenIva)
            If Datos.Seguridad.DatosDeLaEmpresa.TipodePersona = Clseguridad.TipoPersona.PersonaJuridica Then
                RPT.lblNomEmp.Text = Datos.Seguridad.DatosDeLaEmpresa.NombreEmpresa
                RPT.lblOficina.Text = Datos.Seguridad.DatosDeLaEmpresa.OficinaIngreso.NombreComercial
                RPT.LblDireccionEmpresa.Text = Datos.Seguridad.DatosDeLaEmpresa.OficinaIngreso.Direccion
            Else
                RPT.lblNomEmp.Text = Datos.Seguridad.DatosDeLaEmpresa.OficinaIngreso.NombreComercial
                RPT.lblOficina.Text = Datos.Seguridad.DatosDeLaEmpresa.NombreEmpresa
                If Datos.Seguridad.DatosDeLaEmpresa.OficinaIngreso.Telefono1.Trim <> "" Then
                    tel1 = Datos.Seguridad.DatosDeLaEmpresa.OficinaIngreso.Telefono1.Trim
                End If
                If Datos.Seguridad.DatosDeLaEmpresa.OficinaIngreso.Telefono2.Trim <> "" Then
                    tel2 = String.Format("- {0}", Datos.Seguridad.DatosDeLaEmpresa.OficinaIngreso.Telefono2.Trim)
                End If
                tels = String.Format("{0} {1}", tel1, tel2)
                RPT.LblDireccionEmpresa.Text = Datos.Seguridad.DatosDeLaEmpresa.OficinaIngreso.Direccion + " | Tels : " + tels
            End If
            RPT.pcbImg.Image = Datos.Seguridad.LogoImprime
            RPT.lblUsuario.Text = "Usuario: " + StrConv(Datos.Smt_Usuario, VbStrConv.ProperCase)
            RPT.lblpc.Text = Datos.Smt_NombreTerminal
            RPT.lblversionsamit.Text = String.Format("{0} V{1}", Application.ProductName, Application.ProductVersion)


            RPT.lblIdentificacion.Text = docTer
            RPT.lblNombres.Text = nomTer
            RPT.lblTipoContrato.Text = nomTipoContrato
            RPT.lblCargo.Text = nomCargo
            RPT.lblFechaPeriodo.Text = TituloLiquida
            RPT.lblFecha.Text = FechaLiquida

            RPT.DataSource = dtFinal
            RPT.lblConcepto.DataBindings.Add("Text", Nothing, "SecConcep")
            RPT.lblDescripConcept.DataBindings.Add("Text", Nothing, "NomConcepto")
            RPT.lblNomBase.DataBindings.Add("Text", Nothing, "NomBase")
            RPT.lblBases.DataBindings.Add("Text", Nothing, "Base", "{0:c2}")
            RPT.lblDeducciones.DataBindings.Add("Text", Nothing, "Deducciones", "{0:c2}")
            RPT.lblDescuentos.DataBindings.Add("Text", Nothing, "Descuentos", "{0:c2}")
            RPT.lblIngresos.DataBindings.Add("Text", Nothing, "Ingresos", "{0:c2}")

            Dim sumIngresos, sumDeducciones, sumDescuentos As Object
            sumIngresos = CType(dtFinal.Compute("Sum(Ingresos)", ""), Double)
            sumDeducciones = CType(dtFinal.Compute("Sum(Deducciones)", ""), Double)
            sumDescuentos = CType(dtFinal.Compute("Sum(Descuentos)", ""), Double)

            RPT.lblTotlaIngresos.Text = CDbl(sumIngresos).ToString("c2")
            RPT.lblTotalDeducciones.Text = "-" & CDbl(sumDeducciones).ToString("c2")
            RPT.lblTotalDescuentos.Text = "-" & CDbl(sumDescuentos).ToString("c2")
            RPT.lblNetoPagar.Text = (CDbl(sumIngresos) - (CDbl(sumDeducciones) + CDbl(sumDescuentos))).ToString("c2")
            RPT.lblSueldo.Text = RPT.lblNetoPagar.Text
            'INICIA CONSULTA DE ENTIDADES
            sql = String.Format("SELECT ES.NombreEntidad,ES.TipoEnte FROM Empleados EM" +
            " INNER JOIN EntesTercero ET ON EM.Sec = ET.Empleado" +
            " INNER JOIN EntesSSAP ES ON ET.SecEntesSSAP = ES.Sec" +
            " WHERE ET.Empleado={0} AND ET.Retirado = 0", idEmp)
            dtEntidades = DatosC.Tables(1)
            For i = 0 To dtEntidades.Rows.Count - 1
                Select Case CType(dtEntidades.Rows(i)("TipoEnte"), EnumTipoEntes)
                    Case Is = EnumTipoEntes.Cajas_Compensacion
                        nomCaja = dtEntidades.Rows(i)("NombreEntidad").ToString
                    Case Is = EnumTipoEntes.Empresas_Salud
                        nomEPS = dtEntidades.Rows(i)("NombreEntidad").ToString
                    Case Is = EnumTipoEntes.Fondos_de_Pensiones
                        nomAfp = dtEntidades.Rows(i)("NombreEntidad").ToString
                    Case Is = EnumTipoEntes.Riesgos_Profesionales
                        nomArp = dtEntidades.Rows(i)("NombreEntidad").ToString
                    Case Else
                        HDevExpre.MensagedeError("No se ha encontrado uno de los tipos de entidades en los cuales se encuentra registrado el empleado.")
                End Select
            Next
            dtEntidades = SMT_AbrirTabla(ObjetoApiNomina, "SELECT * FROM CAT_Bancos WHERE Sec=" & codBanco)
            If dtEntidades.Rows.Count > 0 Then nomBanco = dtEntidades.Rows(0)("Nombre").ToString
            RPT.lblEps.Text = nomEPS
            RPT.lblAfp.Text = nomAfp
            RPT.lblArp.Text = nomArp
            RPT.lblCaja.Text = nomCaja
            RPT.lblBanco.Text = NumCuenta + " | " + nomBanco

            Dim llamar As New SamitCtlNet.FrmImpresion() With {
              .TamañoPapel = ClFunciones.TamañoPagina.Carta,
              .EsHorizontal = False,
              .Copias = 2
            }
            Dim res As DialogResult = llamar.ShowDialog()

            Dim tamaño As System.Drawing.Printing.PaperKind = System.Drawing.Printing.PaperKind.[Custom]
            If llamar.TamañoPapel = ClFunciones.TamañoPagina.MediaCarta Then
                tamaño = System.Drawing.Printing.PaperKind.Custom
                llamar.EsHorizontal = False
            ElseIf llamar.TamañoPapel = ClFunciones.TamañoPagina.Carta Then
                tamaño = System.Drawing.Printing.PaperKind.Letter
            ElseIf llamar.TamañoPapel = ClFunciones.TamañoPagina.Oficio Then
                tamaño = System.Drawing.Printing.PaperKind.Legal
            End If

            If Not (res = DialogResult.Cancel) Then
                Dim imprime As Boolean = False
                Dim vistaPrevia As Boolean = False
                If res = DialogResult.OK Then
                    imprime = True
                ElseIf res = DialogResult.Yes Then
                    vistaPrevia = True
                End If
                RPT.PaperKind = tamaño
                RPT.Landscape = llamar.EsHorizontal
                If imprime Then
                    RPT.ShowPrintMarginsWarning = False
                    RPT.ShowPrintStatusDialog = False
                    RPT.PrinterName = llamar.NombreImpresora
                    RPT.AssignPrintTool(New DevExpress.XtraReports.UI.ReportPrintTool(RPT))
                    RPT.CreateDocument()
                    RPT.Print()
                    Exit Sub
                End If
                Dim frm As New FrmVistaPrevia(RPT)
                If vistaPrevia Then frm.ShowDialog()
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "Error al imprimir Desprendible :/")
        End Try
    End Sub

    Private Sub btnImpDesprendible_ItemClick(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Try
            If gvRes.RowCount = 0 Then Exit Sub
            Dim IdEmpleado As Integer = CInt(gvRes.GetFocusedRowCellValue("IdEmpleado"))
            Dim Identificacion As String = IIf(IsDBNull(gvRes.GetFocusedRowCellValue("Identificacion")), "", gvRes.GetFocusedRowCellValue("Identificacion").ToString).ToString
            Dim Nombres As String = IIf(IsDBNull(gvRes.GetFocusedRowCellValue("Nombres")), "", gvRes.GetFocusedRowCellValue("Nombres").ToString).ToString
            Dim NomTipoCont As String = IIf(IsDBNull(gvRes.GetFocusedRowCellValue("NomTipoCont")), "", gvRes.GetFocusedRowCellValue("NomTipoCont").ToString).ToString
            Dim CodContrato As String = IIf(IsDBNull(gvRes.GetFocusedRowCellValue("CodContrato")), "", gvRes.GetFocusedRowCellValue("CodContrato").ToString).ToString
            Dim NomCargo As String = IIf(IsDBNull(gvRes.GetFocusedRowCellValue("NomCargo")), "", gvRes.GetFocusedRowCellValue("NomCargo").ToString).ToString
            Dim FechaIniCont As String = CDate(IIf(IsDBNull(gvRes.GetFocusedRowCellValue("FechaIniCont")), "", CDate(gvRes.GetFocusedRowCellValue("FechaIniCont")).ToString("d"))).ToString("d")
            Dim codBanco As Integer = 0
            If Not IsDBNull(gvRes.GetFocusedRowCellValue("codBanco")) Then
                codBanco = CInt(gvRes.GetFocusedRowCellValue("codBanco"))
            End If
            Dim NumCuenta As String = IIf(IsDBNull(gvRes.GetFocusedRowCellValue("NumCuenta")), "", gvRes.GetFocusedRowCellValue("NumCuenta").ToString).ToString
            ImprimeXempleado(CodContrato, Me.SecPeriodo, IdEmpleado, Identificacion,
                             Nombres, NomTipoCont, NomCargo, FechaIniCont, codBanco, NumCuenta)
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "btnImpDesprendible_ItemClick")
        End Try
    End Sub




    Private Sub FrmImpNominas_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        Try
            If gvRes.Columns.Count = 0 Then Exit Sub

        Catch ex As Exception

        End Try
    End Sub

    Private Sub vgIngresosDeducciones_CustomDrawRowHeaderCell(sender As Object, e As DevExpress.XtraVerticalGrid.Events.CustomDrawRowHeaderCellEventArgs) Handles vgIngresosDeducciones.CustomDrawRowHeaderCell
        Try

            If Equals(e.Row, vgIngresosDeducciones.Rows("Total")) Then
                e.Appearance.Font = New Font(e.Appearance.Font.FontFamily, 11, FontStyle.Bold)
            End If
            If Equals(e.Row, vgIngresosDeducciones.Rows("Ingresos")) Then
                e.Appearance.Font = New Font(e.Appearance.Font.FontFamily, 11, FontStyle.Bold)
            End If
            If Equals(e.Row, vgIngresosDeducciones.Rows("Deducciones")) Then
                e.Appearance.Font = New Font(e.Appearance.Font.FontFamily, 11, FontStyle.Bold)
            End If
            If Equals(e.Row, vgIngresosDeducciones.Rows("Descuentos")) Then
                e.Appearance.Font = New Font(e.Appearance.Font.FontFamily, 11, FontStyle.Bold)
            End If
            If Equals(e.Row, vgIngresosDeducciones.Rows("Fondos")) Then
                e.Appearance.Font = New Font(e.Appearance.Font.FontFamily, 11, FontStyle.Bold)
            End If
            If Equals(e.Row, vgIngresosDeducciones.Rows("Provisiones")) Then
                e.Appearance.Font = New Font(e.Appearance.Font.FontFamily, 11, FontStyle.Bold)
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtPeriodo_Leave(sender As Object, e As EventArgs)
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If HDevExpre.EstaCargadoFormulario("FrmConsultaPeriodosL") Then Exit Sub
        FrmConsultaPeriodosL.SecNominaLiquida = SecConsulta.ToString
        FrmConsultaPeriodosL.CodNomina = CodNomina
        FrmConsultaPeriodosL.IconOptions.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Liquidaciones)
        FrmConsultaPeriodosL.ShowIcon = True
        FrmConsultaPeriodosL.NomLiquida = TituloLiquida
        FrmConsultaPeriodosL.MdiParent = FrmPrincipal
        FrmConsultaPeriodosL.Show()
    End Sub

    Private Sub gcRes_Click(sender As Object, e As EventArgs) Handles gcRes.Click

    End Sub
End Class
