Imports Kiai.Nomina
Imports Newtonsoft.Json
Imports SamitCtlNet
Public Class FrmEnviarDian
    Public SecConsulta As String = ""
    Public Descrip As String = ""
    Public dtcodigos As New DataTable

    Dim HNomina As New HelperNomina
    Dim HDevExpre As New HelperDevExpress
    Private Sub FrmEnviarDian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Empresa As Integer = ObjetosNomina.Datos.Seguridad.DatosDeLaEmpresa.NumEmpresa, NombreBD As String = "E" + ObjetosNomina.Datos.Seguridad.DatosDeLaEmpresa.NumEmpresa.ToString("000") + Year(ObjetosNomina.Datos.Smt_FechaDeTrabajo).ToString()
        MetododePago.ConsultaSQL = "Select 	'1'	 As Codigo, 	'Instrumento no definido'	 As Descripcion	 Union
Select 	'2'	 As Codigo, 	'Crédito ACH'	 As Descripcion	 Union
Select 	'3'	 As Codigo, 	'Débito ACH'	 As Descripcion	 Union
Select 	'4'	 As Codigo, 	'Reversión débito de demanda ACH'	 As Descripcion	 Union
Select 	'5'	 As Codigo, 	'Reversión crédito de demanda ACH'	 As Descripcion	 Union
Select 	'6'	 As Codigo, 	'Crédito de demanda ACH'	 As Descripcion	 Union
Select 	'7'	 As Codigo, 	'Débito de demanda ACH'	 As Descripcion	 Union
Select 	'8'	 As Codigo, 	'Mantener'	 As Descripcion	 Union
Select 	'9'	 As Codigo, 	'Clearing Nacional o Regional'	 As Descripcion	 Union
Select 	'10'	 As Codigo, 	'Efectivo'	 As Descripcion	 Union
Select 	'11'	 As Codigo, 	'Reversión Crédito Ahorro'	 As Descripcion	 Union
Select 	'12'	 As Codigo, 	'Reversión Débito Ahorro'	 As Descripcion	 Union
Select 	'13'	 As Codigo, 	'Crédito Ahorro'	 As Descripcion	 Union
Select 	'14'	 As Codigo, 	'Débito Ahorro'	 As Descripcion	 Union
Select 	'15'	 As Codigo, 	'Bookentry Crédito'	 As Descripcion	 Union
Select 	'16'	 As Codigo, 	'Bookentry Débito'	 As Descripcion	 Union
Select 	'17'	 As Codigo, 	'Concentración de la demanda en efectivo / Desembolso Crédito (CCD)'	 As Descripcion	 Union
Select 	'18'	 As Codigo, 	'Concentración de la demanda en efectivo / Desembolso (CCD) débito'	 As Descripcion	 Union
Select 	'19'	 As Codigo, 	'Crédito Pago negocio corporativo (CTP)'	 As Descripcion	 Union
Select 	'20'	 As Codigo, 	'Cheque'	 As Descripcion	 Union
Select 	'21'	 As Codigo, 	'Proyecto bancario'	 As Descripcion	 Union
Select 	'22'	 As Codigo, 	'Proyecto bancario certificado'	 As Descripcion	 Union
Select 	'23'	 As Codigo, 	'Cheque bancario'	 As Descripcion	 Union
Select 	'24'	 As Codigo, 	'Nota cambiaria esperando aceptación'	 As Descripcion	 Union
Select 	'25'	 As Codigo, 	'Cheque certificado'	 As Descripcion	 Union
Select 	'26'	 As Codigo, 	'Cheque Local'	 As Descripcion	 Union
Select 	'27'	 As Codigo, 	'Débito Pago Negocio Corporativo (CTP)'	 As Descripcion	 Union
Select 	'28'	 As Codigo, 	'Crédito Negocio Intercambio Corporativo (CTX)'	 As Descripcion	 Union
Select 	'29'	 As Codigo, 	'Débito Negocio Intercambio Corporativo (CTX)'	 As Descripcion	 Union
Select 	'30'	 As Codigo, 	'Transferencia Crédito'	 As Descripcion	 Union
Select 	'31'	 As Codigo, 	'Transferencia Débito'	 As Descripcion	 Union
Select 	'32'	 As Codigo, 	'Concentración Efectivo / Desembolso Crédito plus (CCD+)'	 As Descripcion	 Union
Select 	'33'	 As Codigo, 	'Concentración Efectivo / Desembolso Débito plus (CCD+)'	 As Descripcion	 Union
Select 	'34'	 As Codigo, 	'Pago y depósito pre acordado (PPD)'	 As Descripcion	 Union
Select 	'35'	 As Codigo, 	'Concentración efectivo ahorros / Desembolso Crédito (CCD)'	 As Descripcion	 Union
Select 	'36'	 As Codigo, 	'Concentración efectivo ahorros / Desembolso Crédito (CCD)'	 As Descripcion	 Union
Select 	'37'	 As Codigo, 	'Pago Negocio Corporativo Ahorros Crédito (CTP)'	 As Descripcion	 Union
Select 	'38'	 As Codigo, 	'Pago Negocio Corporativo Ahorros Débito (CTP)'	 As Descripcion	 Union
Select 	'39'	 As Codigo, 	'Crédito Negocio Intercambio Corporativo (CTX)'	 As Descripcion	 Union
Select 	'40'	 As Codigo, 	'Débito Negocio Intercambio Corporativo (CTX)'	 As Descripcion	 Union
Select 	'41'	 As Codigo, 	'Concentración efectivo/Desembolso Crédito plus (CCD+)'	 As Descripcion	 Union
Select 	'42'	 As Codigo, 	'Consignación bancaria'	 As Descripcion	 Union
Select 	'43'	 As Codigo, 	'Concentración efectivo / Desembolso Débitoplus (CCD+)'	 As Descripcion	 Union
Select 	'44'	 As Codigo, 	'Nota cambiaria'	 As Descripcion	 Union
Select 	'45'	 As Codigo, 	'Transferencia Crédito Bancario'	 As Descripcion	 Union
Select 	'46'	 As Codigo, 	'Transferencia Débito Interbancario'	 As Descripcion	 Union
Select 	'47'	 As Codigo, 	'Transferencia Débito Bancaria'	 As Descripcion	 Union
Select 	'48'	 As Codigo, 	'Tarjeta Crédito'	 As Descripcion	 Union
Select 	'49'	 As Codigo, 	'Tarjeta Débito'	 As Descripcion	 Union
Select 	'50'	 As Codigo, 	'Postgiro'	 As Descripcion	 Union
Select 	'51'	 As Codigo, 	'Telex estándar bancario francés'	 As Descripcion	 Union
Select 	'52'	 As Codigo, 	'Pago comercial urgente'	 As Descripcion	 Union
Select 	'53'	 As Codigo, 	'Pago Tesorería Urgente'	 As Descripcion	 Union
Select 	'60'	 As Codigo, 	'Nota promisoria'	 As Descripcion	 Union
Select 	'61'	 As Codigo, 	'Nota promisoria firmada por el acreedor'	 As Descripcion	 Union
Select 	'62'	 As Codigo, 	'Nota promisoria firmada por el acreedor, avalada por el banco'	 As Descripcion	 Union
Select 	'63'	 As Codigo, 	'Nota promisoria firmada por el acreedor, avalada por un tercero'	 As Descripcion	 Union
Select 	'64'	 As Codigo, 	'Nota promisoria firmada por el banco'	 As Descripcion	 Union
Select 	'65'	 As Codigo, 	'Nota promisoria firmada por un banco avalada por otro banco'	 As Descripcion	 Union
Select 	'66'	 As Codigo, 	'Nota promisoria firmada'	 As Descripcion	 Union
Select 	'67'	 As Codigo, 	'Nota promisoria firmada por un tercero avalada por un banco'	 As Descripcion	 Union
Select 	'70'	 As Codigo, 	'Retiro de nota por el por el acreedor'	 As Descripcion	 Union
Select 	'71'	 As Codigo, 	'Bonos'	 As Descripcion	 Union
Select 	'72'	 As Codigo, 	'Vales'	 As Descripcion	 Union
Select 	'74'	 As Codigo, 	'Retiro de nota por el por el acreedor sobre un banco'	 As Descripcion	 Union
Select 	'75'	 As Codigo, 	'Retiro de nota por el acreedor, avalada por otro banco'	 As Descripcion	 Union
Select 	'76'	 As Codigo, 	'Retiro de nota por el acreedor, sobre un banco avalada por un tercero'	 As Descripcion	 Union
Select 	'77'	 As Codigo, 	'Retiro de una nota por el acreedor sobre un tercero'	 As Descripcion	 Union
Select 	'78'	 As Codigo, 	'Retiro de una nota por el acreedor sobre un tercero avalada por un banco'	 As Descripcion	 Union
Select 	'91'	 As Codigo, 	'Nota bancaria transferible'	 As Descripcion	 Union
Select 	'92'	 As Codigo, 	'Cheque local trasferible'	 As Descripcion	 Union
Select 	'93'	 As Codigo, 	'Giro referenciado'	 As Descripcion	 Union
Select 	'94'	 As Codigo, 	'Giro urgente'	 As Descripcion	 Union
Select 	'95'	 As Codigo, 	'Giro formato abierto'	 As Descripcion	 Union
Select 	'96'	 As Codigo, 	'Método de pago solicitado no usado'	 As Descripcion	 Union
Select 	'97'	 As Codigo, 	'Clearing entre partners'	 As Descripcion	 Union
Select 	'98'	 As Codigo, 	'Cuentas de Ahorro de Tramite Simplificado (CATS)(Nequi, Daviplata, etc)'	 As Descripcion	 Union
Select 	'ZZZ'	 As Codigo, 	'Acuerdo mutuo'	 As Descripcion	
"
        MetododePago.RefrescarDatos()
        dtcodigos.Columns.Add("Codigo", GetType(String))
        dtcodigos.Rows.Add("NIE194")
        dtcodigos.Rows.Add("NIE157")
        dtcodigos.Rows.Add("NIE142")
        dtcodigos.Rows.Add("NIE141")
        dtcodigos.Rows.Add("NIE070")
        dtcodigos.Rows.Add("NIE140")
        dtcodigos.Rows.Add("NIE139")
        dtcodigos.Rows.Add("NIE159")
        dtcodigos.Rows.Add("NIE154")
        dtcodigos.Rows.Add("NIE153")
        dtcodigos.Rows.Add("NIE151")
        dtcodigos.Rows.Add("NIE152")
        dtcodigos.Rows.Add("NIE120")
        dtcodigos.Rows.Add("NIE122")
        dtcodigos.Rows.Add("NIE155")
        dtcodigos.Rows.Add("NIE150")
        dtcodigos.Rows.Add("NIE149")
        dtcodigos.Rows.Add("NIE156")
        dtcodigos.Rows.Add("NIE078")
        dtcodigos.Rows.Add("NIE093")
        dtcodigos.Rows.Add("NIE083")
        dtcodigos.Rows.Add("NIE103")
        dtcodigos.Rows.Add("NIE098")
        dtcodigos.Rows.Add("NIE088")
        dtcodigos.Rows.Add("NIE108")
        dtcodigos.Rows.Add("NIE127")
        dtcodigos.Rows.Add("NIE160")
        dtcodigos.Rows.Add("NIE131")
        dtcodigos.Rows.Add("NIE135")
        dtcodigos.Rows.Add("NIE148")
        dtcodigos.Rows.Add("NIE147")
        dtcodigos.Rows.Add("NIE193")
        dtcodigos.Rows.Add("NIE118")
        dtcodigos.Rows.Add("NIE119")
        dtcodigos.Rows.Add("NIE201")
        dtcodigos.Rows.Add("NIE158")
        dtcodigos.Rows.Add("NIE071")
        dtcodigos.Rows.Add("NIE073")
        dtcodigos.Rows.Add("NIE072")
        dtcodigos.Rows.Add("NIE112")
        dtcodigos.Rows.Add("NIE116")
        dtcodigos.Rows.Add("NIE179")
        dtcodigos.Rows.Add("NIE196")
        dtcodigos.Rows.Add("NIE180")
        dtcodigos.Rows.Add("NIE185")
        dtcodigos.Rows.Add("NIE183")
        dtcodigos.Rows.Add("NIE181")
        dtcodigos.Rows.Add("NIE166")
        dtcodigos.Rows.Add("NIE168")
        dtcodigos.Rows.Add("NIE170")
        dtcodigos.Rows.Add("NIE176")
        dtcodigos.Rows.Add("NIE197")
        dtcodigos.Rows.Add("NIE195")
        dtcodigos.Rows.Add("NIE198")
        dtcodigos.Rows.Add("NIE182")
        dtcodigos.Rows.Add("NIE184")
        dtcodigos.Rows.Add("NIE177")
        dtcodigos.Rows.Add("NIE163")
        dtcodigos.Rows.Add("NIE174")
        dtcodigos.Rows.Add("NIE173")
        dtcodigos.Rows.Add("NIE172")

        dteFecha.DateTime = ObjetosNomina.Datos.Smt_FechaDeTrabajo
        btnEnviar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Guardar)
        BtnEliminar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Eliminar)
        btnCancelar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.SalirAtras)
        btnHabilitar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Aceptar)
        BtnExcell.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Excell_XlsX)
        CreaGrillaXperiodo()
        LlenaGrillaXperiodo()
        lblfechaini.Text = Descrip
    End Sub

    Private Sub CreaGrillaXperiodo()
        Try
            gvEmpleados.Columns.Clear()
            HDevExpre.CreaColumnasG(gvEmpleados, "LiquidaContrato", "Cod Liquidacion", True, False, "", Color.Aqua, False, False, 7, gcEmpleados.Width,,,,,,,,,,,,,,,,, True)
            HDevExpre.CreaColumnasG(gvEmpleados, "IdEmpleado", "ID. Empleado", True, False, "", Color.Aqua, False, False, 7, gcEmpleados.Width,,,,,,,,,,,,,,,,, True)
            HDevExpre.CreaColumnasG(gvEmpleados, "CodContrato", "CodContrato", False, False, "", Color.Aqua, False, False, 7, gcEmpleados.Width)
            HDevExpre.CreaColumnasG(gvEmpleados, "Identificacion", "Identificación", True, False, "", Color.Aqua, False, False, 10, gcEmpleados.Width,,,,,,,,,,,,,,,,, True)
            HDevExpre.CreaColumnasG(gvEmpleados, "TipoIdentificacion", "Tipo Identificacion", True, False, "", Color.Aqua, False, False, 10, gcEmpleados.Width,,,,,,,,,,,,,,,,, True)
            HDevExpre.CreaColumnasG(gvEmpleados, "Nombres", "Nombres", True, False, "", Color.Aqua, False, False, 15, gcEmpleados.Width,,,,,,,,,,,,,,,,, True)
            HDevExpre.CreaColumnasG(gvEmpleados, "TipoContrato", "Tipo Contrato", True, False, "", Color.Aqua, False, False, 10, gcEmpleados.Width)
            HDevExpre.CreaColumnasG(gvEmpleados, "FechaIniCont", "Fecha Inicio", True, False, "", Color.Aqua, False, False, 10, gcEmpleados.Width,,,,,, True)
            HDevExpre.CreaColumnasG(gvEmpleados, "Asignacion", "Asignacion", True, False, "", Color.Aqua, True, True, 10, gcEmpleados.Width)
            HDevExpre.CreaColumnasG(gvEmpleados, "Devengado", "Devengado", True, False, "", Color.Aqua, True, True, 10, gcEmpleados.Width)
            HDevExpre.CreaColumnasG(gvEmpleados, "Deducido", "Deducido", True, False, "", Color.Aqua, True, True, 10, gcEmpleados.Width)
            HDevExpre.CreaColumnasG(gvEmpleados, "Total", "Total", True, False, "", Color.Aqua, True, True, 10, gcEmpleados.Width)
            HDevExpre.CreaColumnasG(gvEmpleados, "Banco", "Banco", True, False, "", Color.Aqua, False, False, 10, gcEmpleados.Width)
            HDevExpre.CreaColumnasG(gvEmpleados, "NumCuenta", "NumCuenta", True, False, "", Color.Aqua, False, False, 10, gcEmpleados.Width)
            HDevExpre.CreaColumnasG(gvEmpleados, "TipoCuenta", "Tipo Cuenta", True, False, "", Color.Aqua, False, False, 10, gcEmpleados.Width)
            HDevExpre.CreaColumnasG(gvEmpleados, "Estado", "Resultado", True, False, "", Color.Aqua, False, False, 10, gcEmpleados.Width)
            HDevExpre.CreaColumnasG(gvEmpleados, "Cufe", "Cufe", True, False, "", Color.Aqua, False, False, 10, gcEmpleados.Width)
            HDevExpre.CreaColumnasG(gvEmpleados, "DoceId", "DoceId", True, False, "", Color.Aqua, False, False, 10, gcEmpleados.Width)
            gvEmpleados.Appearance.HeaderPanel.Font = New Font("Trebuchet MS", 11.0!, FontStyle.Bold)
            gvEmpleados.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto
            gvEmpleados.OptionsView.ColumnAutoWidth = False
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "CreaGrillaXperiodo")
        End Try
    End Sub
    Private Sub LlenaGrillaXperiodo()
        Dim Sql = "SELECT NLC.DoceId,NLC.Cufe,NLC.Estado,'' As Resultado,CT.TipoTrabajador,CT.SalarioIntegral,CT.SubTipoTrabajador,EM.Municipio,EM.IdEmpleado, CT.CodContrato,EM.Identificacion,TI.NomTipo as TipoIdentificacion,TI.Codigo as TipoCodIden, RTRIM(LTRIM(RTRIM(LTRIM(EM.PNombre)) + ' ' +  " +
                        " RTRIM(LTRIM(EM.SNombre)) + ' ' +  RTRIM(LTRIM(EM.PApellido)) + ' ' +  RTRIM(LTRIM(EM.SApellido)))) As Nombres,EM.PNombre,EM.SNombre,EM.PApellido,EM.SApellido," +
                        " EM.codBanco, EM.NumCuenta,CT.Asignacion,NLC.Comentario,NLC.Sec as LiquidaContrato,TC.NomTipo As TipoContrato,TC.CodTipo As CodTipoContrato,B.Nombre As Banco,PL.FechaInicio As FechaIniP,PL.FechaFin As FechaFinP,PL.Nomina,Pl.NumMes,NO.FormaLiquida, PL.Año," +
                        " CT.CargoActual,CG.Denominacion AS NomCargo, CT.FechaInicio AS FechaIniCont,Case when EM.TipoCuenta=1 then 'Ahorro' when  EM.TipoCuenta=2 then 'Corriente' when EM.TipoCuenta=3 then 'Nomina' else 'N/A' End as TipoCuenta, " +
                        " NLC.TotalIngresos As Devengado, NLC.TotalDeducciones + NLC.TotalDescuentosNomina As Deducido,NLC.TotalIngresos - (NLC.TotalDeducciones + NLC.TotalDescuentosNomina) As Total" +
                        " FROM NominaLiquidadaContratos NLC " +
                        " INNER JOIN NominaLiquidada NL ON NLC.NominaLiquidada = NL.Sec " +
                        " INNER JOIN Contratos CT ON NLC.Contrato = CT.CodContrato " +
                        " INNER JOIN Empleados EM ON CT.Empleado = EM.IdEmpleado " +
                        " LEFT JOIN CAT_Bancos B ON B.Sec = EM.codBanco " +
                        " LEFT JOIN CAT_TiposId TI ON TI.TipoIdentificacion = EM.TipoIdentificacion " +
                        " INNER JOIN CAT_TipoContratos TC ON CT.TipoContrato = TC.CodTipo" +
                        " INNER JOIN Contrato_Cargos CC ON CT.CodContrato = CC.Contrato" +
                        " INNER JOIN cargos CG ON CC.Cargo = CG.SecCargo" +
                        " INNER JOIN PeriodosLiquidacion PL ON PL.Sec = NL.Periodo" +
                        " INNER JOIN Nominas NO ON PL.Nomina = NO.SecNomina " +
                        " WHERE NL.Estado='L' And NL.Sec = " & SecConsulta
        Dim dt As DataTable = SMT_AbrirTabla(ObjetoApiNomina, Sql)
        If dt.Rows.Count = 0 Then
            HDevExpre.mensajeExitoso("No se encontraron registros...")
            'txtPeriodo.Focus()
            Exit Sub
        End If

        Sql = "Select Sum(NLC.TotalIngresos) as Devengado, Sum(NLC.TotalDeducciones) + Sum(NLC.TotalDescuentosNomina) As Deducido,Sum(NLC.TotalIngresos) - (Sum(NLC.TotalDeducciones) + Sum(NLC.TotalDescuentosNomina)) As Total,CT.CodContrato 
FROM NominaLiquidadaContratos NLC  INNER JOIN NominaLiquidada NL ON NLC.NominaLiquidada = NL.Sec  INNER JOIN Contratos CT ON NLC.Contrato = CT.CodContrato  
INNER JOIN Empleados EM ON CT.Empleado = EM.IdEmpleado  LEFT JOIN CAT_Bancos B ON B.Sec = EM.codBanco  LEFT JOIN CAT_TiposId TI ON TI.TipoIdentificacion = EM.TipoIdentificacion  
INNER JOIN CAT_TipoContratos TC ON CT.TipoContrato = TC.CodTipo INNER JOIN Contrato_Cargos CC ON CT.CodContrato = CC.Contrato INNER JOIN cargos CG ON CC.Cargo = CG.SecCargo 
INNER JOIN PeriodosLiquidacion PL ON PL.Sec = NL.Periodo INNER JOIN Nominas NO ON PL.Nomina = NO.SecNomina  WHERE  NL.Estado='L' And PL.Año =" + dt.Rows(0)("Año").ToString + " AND PL.NumMes=" + dt.Rows(0)("NumMes").ToString + " And Pl.Nomina=" + dt.Rows(0)("Nomina").ToString + " group by CT.CodContrato"
        Dim dtValoresAgrupados As DataTable = SMT_AbrirTabla(ObjetoApiNomina, Sql)
        For Each fila As DataRow In dt.Rows
            Dim FilaVal = dtValoresAgrupados.Select("CodContrato='" + fila("CodContrato").ToString + "'")
            fila("Devengado") = FilaVal(0)("Devengado")
            fila("Deducido") = FilaVal(0)("Deducido")
            fila("Total") = FilaVal(0)("Total")
        Next

        gcEmpleados.DataSource = dt
    End Sub

    Private Async Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        Try
            btnEnviar.Enabled = False
            BtnEliminar.Enabled = False
            btnCancelar.Enabled = False
            btnHabilitar.Enabled = False

            If gvEmpleados.RowCount > 0 Then
                If MetododePago.ValordelControl <> "" Then
                    Dim dtempresa = SMT_AbrirTabla(SMTConex, "USE SEGURIDAD SELECT * FROM Empresa_FE where NumEmpresa=" + ObjetosNomina.Datos.Seguridad.DatosDeLaEmpresa.NumEmpresa.ToString)
                    If dtempresa.Rows.Count <= 0 Then
                        HDevExpre.MensagedeError("No se ha configurado los datos de la empresa, para el envio de nomina electronica!..")
                        btnEnviar.Enabled = True
                        BtnEliminar.Enabled = True
                        btnCancelar.Enabled = True
                        btnHabilitar.Enabled = True
                        Exit Sub
                    End If
                    If CInt(dtempresa.Rows(0)("AmbienteNom").ToString) = 2 Then
                        HDevExpre.MensagedeError("Esta opcion no se encuentra disponible para habilitacion!..")
                        btnEnviar.Enabled = True
                        BtnEliminar.Enabled = True
                        btnCancelar.Enabled = True
                        btnHabilitar.Enabled = True
                        Exit Sub
                    End If
                    Dim dttrabajador = CType(gcEmpleados.DataSource, DataTable)
                    Dim Load As ClEspera = New ClEspera()
                    Dim count As Integer = 0
                    Load.Mostrar("Enviando Datos!.", "")
                    For Each fila As DataRow In dttrabajador.Rows
                        If CInt(dtempresa.Rows(0)("AmbienteNom").ToString) = 2 And count > 3 Then
                            Exit For
                        End If
                        If fila("Cufe").ToString <> "" Then

                        Else

                            Dim sql = "Select Sum(NLC.Valor) As Valor,C.CodDian,C.Sec,C.NomConcepto from NominaLiquidadaConceptos NLC INNER JOIN ConceptosNomina C On C.Sec=NLC.SecConcepto INNER JOIN NominaLiquidadaContratos NLCT ON NLC.LiquidadaContrato=NLCT.Sec INNER JOIN Contratos CT ON NLCT.Contrato = CT.CodContrato INNER JOIN NominaLiquidada NL ON NLCT.NominaLiquidada = NL.Sec INNER JOIN PeriodosLiquidacion PL ON PL.Sec = NL.Periodo INNER JOIN Nominas NO ON PL.Nomina = NO.SecNomina where  NL.Estado='L' And NLCT.Contrato=" + fila("CodContrato").ToString + " And C.Tipo <> 3 And PL.NumMes=" + fila("NumMes").ToString + " And Pl.Nomina=" + fila("Nomina").ToString + " group by CT.CodContrato,C.CodDian,C.Sec,C.NomConcepto " +
                        " Union
Select Sum(NLC.Valor),C.CodDian,C.Sec,C.NomConcepto from NominaLiquidadaConceptos NLC INNER JOIN ConceptosPersonales C On C.Sec=NLC.SecConceptoP2 INNER JOIN NominaLiquidadaContratos NLCT ON NLC.LiquidadaContrato=NLCT.Sec INNER JOIN Contratos CT ON NLCT.Contrato = CT.CodContrato INNER JOIN NominaLiquidada NL ON NLCT.NominaLiquidada = NL.Sec INNER JOIN PeriodosLiquidacion PL ON PL.Sec = NL.Periodo INNER JOIN Nominas NO ON PL.Nomina = NO.SecNomina where  NL.Estado='L' And NLCT.Contrato=" + fila("CodContrato").ToString + " And PL.NumMes=" + fila("NumMes").ToString + " And Pl.Nomina=" + fila("Nomina").ToString + " group by CT.CodContrato,C.CodDian,C.Sec,C.NomConcepto "
                            Dim conceptos = SMT_AbrirTabla(ObjetoApiNomina, sql)
                            Dim Variables = SMT_AbrirTabla(ObjetoApiNomina, "Select Sum(NLC.Cantidad) As Cantidad,C.CodDian,C.Sec from NominaLiquidadaVariables NLC INNER JOIN VariablesPersonales C On C.Sec=NLC.Variable INNER JOIN NominaLiquidadaContratos NLCT ON NLC.SecLiquidadaContrato=NLCT.Sec INNER JOIN Contratos CT ON NLCT.Contrato = CT.CodContrato INNER JOIN NominaLiquidada NL ON NLCT.NominaLiquidada = NL.Sec INNER JOIN PeriodosLiquidacion PL ON PL.Sec = NL.Periodo INNER JOIN Nominas NO ON PL.Nomina = NO.SecNomina where  NL.Estado='L' And NLCT.Contrato=" + fila("CodContrato").ToString + " And PL.NumMes=" + fila("NumMes").ToString + " And Pl.Nomina=" + fila("Nomina").ToString + " group by CT.CodContrato,C.CodDian,C.Sec")
                            Dim Cod As Boolean = False
                            For Each codfila As DataRow In conceptos.Rows
                                If codfila("CodDian").ToString = "" Then
                                    Load.Terminar()
                                    HDevExpre.MensagedeError("Empleado: " + fila("Identificacion").ToString + "-" + fila("Nombres").ToString + "\n" + "No se ha configurado el codigo de '" + codfila("NomConcepto").ToString + "'")
                                    btnEnviar.Enabled = True
                                    BtnEliminar.Enabled = True
                                    btnCancelar.Enabled = True
                                    btnHabilitar.Enabled = True
                                    Exit Sub
                                End If
                                If dtcodigos.Select("Codigo='" + codfila("CodDian").ToString + "'").Count <= 0 Then
                                    Load.Terminar()
                                    HDevExpre.MensagedeError("Empleado: " + fila("Identificacion").ToString + "-" + fila("Nombres").ToString + "\n" + "No se ha configurado correctamente el codigo de '" + codfila("NomConcepto").ToString + "'")
                                    btnEnviar.Enabled = True
                                    BtnEliminar.Enabled = True
                                    btnCancelar.Enabled = True
                                    btnHabilitar.Enabled = True
                                    Exit Sub
                                End If
                            Next
                            Dim res = Await HNomina.EnviarNomina(fila, conceptos, Variables, SecConsulta, False, MetododePago.ValordelControl, CDate(dteFecha.DateTime), dtempresa)
                            fila("Estado") = res.Replace("'", "")
                            SMT_EjcutarComandoSql(ObjetoApiNomina, "Update NominaLiquidadaContratos set Cufe='" + fila("Cufe").ToString + "',Estado='" + fila("Estado").ToString + "',DoceId='" + fila("DoceId").ToString + "' where Sec=" + fila("LiquidaContrato").ToString, 0)
                            If res.Contains("No se ha configurado") Then
                                HDevExpre.MensagedeError("Empleado: " + fila("Identificacion").ToString + "-" + fila("Nombres").ToString + "\n" + res)
                                Exit For
                            ElseIf res.Contains("DBNull") Then
                                HDevExpre.MensagedeError("Por favor verificar los datos del empleado!.")
                                Exit For
                            End If
                        End If
                        count = count + 1
                    Next
                    Load.Terminar()
                    HDevExpre.mensajeExitoso("Proceso terminado!..")
                Else
                    HDevExpre.MensagedeError("Lo sentimos, debe seleccionar un metodo de pago!..")
                End If
            Else
                HDevExpre.MensagedeError("Lo sentimos, no se han encontrado registros!..")
            End If
            btnEnviar.Enabled = True
            BtnEliminar.Enabled = True
            btnCancelar.Enabled = True
            btnHabilitar.Enabled = True
        Catch ex As Exception
            btnEnviar.Enabled = True
            BtnEliminar.Enabled = True
            btnCancelar.Enabled = True
            btnHabilitar.Enabled = True
        End Try
    End Sub

    Private Async Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Try
            btnEnviar.Enabled = False
            BtnEliminar.Enabled = False
            btnCancelar.Enabled = False
            btnHabilitar.Enabled = False

            If HDevExpre.MsgSamit(String.Format("Seguro que desea eliminar esta nomina de la Dian?"), MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.OK Then
                Dim dtempresa = SMT_AbrirTabla(SMTConex, "USE SEGURIDAD SELECT * FROM Empresa_FE where NumEmpresa=" + ObjetosNomina.Datos.Seguridad.DatosDeLaEmpresa.NumEmpresa.ToString)
                If dtempresa.Rows.Count <= 0 Then
                    HDevExpre.MensagedeError("No se ha configurado los datos de la empresa, para el envio de nomina electronica!..")
                    btnEnviar.Enabled = True
                    BtnEliminar.Enabled = True
                    btnCancelar.Enabled = True
                    btnHabilitar.Enabled = True
                    Exit Sub
                End If
                Dim count As Integer = 0
                If gvEmpleados.RowCount > 0 Then
                    Dim dttrabajador = CType(gcEmpleados.DataSource, DataTable)
                    Dim Load As ClEspera = New ClEspera()
                    Load.Mostrar("Enviando Datos!.", "")
                    For Each fila As DataRow In dttrabajador.Rows
                        If CInt(dtempresa.Rows(0)("AmbienteNom").ToString) = 2 And count > 3 Then
                            Exit For
                        End If
                        If fila("Estado").ToString = "OK" Then

                        Else
                            Dim res = Await HNomina.EliminarNominaDian(fila, dtempresa)
                            fila("Estado") = res
                            SMT_EjcutarComandoSql(ObjetoApiNomina, "Update NominaLiquidadaContratos set Estado='" + fila("Estado").ToString + "' where Sec=" + fila("LiquidaContrato").ToString, 0)
                        End If
                        count = count + 1
                    Next
                    Load.Terminar()
                    HDevExpre.mensajeExitoso("Proceso terminado!..")
                Else
                    HDevExpre.MensagedeError("Lo sentimos, no se han encontrado registros!..")
                End If
            End If
        Catch ex As Exception
            btnEnviar.Enabled = True
            BtnEliminar.Enabled = True
            btnCancelar.Enabled = True
            btnHabilitar.Enabled = True
            HDevExpre.mensajeExitoso("Proceso terminado!.." + ex.Message)
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Public Async Function HabilitarNomina(dtempresa As DataTable) As Task(Of String)
        Try
            Dim NominaElectronica
            Try
                NominaElectronica = New KiaiNomina("900395252", "tufactura.co@softwareestrategico.com", dtempresa.Rows(0)("SuscriptorNom").ToString)
            Catch ex As Exception
                Return "No se ha podido iniciar sesion, verifique el codigo de suscriptor!.."
            End Try

            Dim Resul = Await NominaElectronica.HabilitarEmpleador()
            Dim json = JsonConvert.SerializeObject(Resul)
            If json.Contains("se encuentra Aceptado.") Then
                Return "Se ha habilitado correctamente el empleador"
            ElseIf json.Contains("Error al procesar batch. ZipKey") Then
                Return "Hay errores en el set de pruebas, es necesario eliminarlo y crearlo nuevamente"
            Else
                Return "Aun no se encuentra habilitado el empleador"
            End If
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Private Async Sub btnHabilitar_Click(sender As Object, e As EventArgs) Handles btnHabilitar.Click
        btnEnviar.Enabled = False
        BtnEliminar.Enabled = False
        btnCancelar.Enabled = False
        btnHabilitar.Enabled = False
        Dim Load As ClEspera = New ClEspera()
        Load.Mostrar("Enviando Datos!.", "")
        Try
            Dim dtempresa = SMT_AbrirTabla(SMTConex, "USE SEGURIDAD SELECT * FROM Empresa_FE where NumEmpresa=" + ObjetosNomina.Datos.Seguridad.DatosDeLaEmpresa.NumEmpresa.ToString)
            If dtempresa.Rows.Count > 0 Then
                If CInt(IIf(dtempresa.Rows(0)("AmbienteNom").ToString = "", "0", dtempresa.Rows(0)("AmbienteNom").ToString)) = 2 Then

                    Dim res = Await HabilitarNomina(dtempresa)
                    If res = "Se ha habilitado correctamente el empleador" Then
                        HDevExpre.mensajeExitoso(res)
                    Else
                        HDevExpre.MensagedeError(res)
                    End If
                Else
                    HDevExpre.MensagedeError("La empresa no se encuentra en ambiente de habilitacion!..")
                End If
            Else
                HDevExpre.MensagedeError("No se ha configurado los datos de la empresa, para el envio de nomina electronica!..")
            End If
            btnEnviar.Enabled = True
            BtnEliminar.Enabled = True
            btnCancelar.Enabled = True
            btnHabilitar.Enabled = True
            Load.Terminar()
        Catch ex As Exception
            btnEnviar.Enabled = True
            BtnEliminar.Enabled = True
            btnCancelar.Enabled = True
            btnHabilitar.Enabled = True
            Load.Terminar()
            HDevExpre.mensajeExitoso("Proceso terminado!.." + ex.Message)
        End Try
    End Sub

    Private Sub BtnExcell_Click(sender As Object, e As EventArgs) Handles BtnExcell.Click
        Dim Ruta As String = My.Computer.FileSystem.SpecialDirectories.Desktop + "\pruebaexcell.xlsx", Guardar As New SaveFileDialog
        Guardar.Filter = "XlsX Excel|*.Xlsx"
        Guardar.Title = "Guardar Archivo de Excel XlsX"
        Guardar.ShowDialog()
        If Guardar.FileName <> "" Then
            Ruta = Guardar.FileName
            gcEmpleados.ExportToXlsx(Ruta)
            Process.Start(Ruta)
        End If
    End Sub
End Class