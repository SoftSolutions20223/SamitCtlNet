Imports Newtonsoft.Json
Imports SamitNomina
Imports SamitCtlNet
Imports Kiai.Nomina.Modelo
Imports Kiai.Nomina
Imports System.Threading

Public Class HelperNomina
    Dim HDevExpre As New HelperDevExpress


    Public Enum EnumTipoEntes
        Fondos_de_Pensiones = 1
        Empresas_Salud = 2
        Riesgos_Profesionales = 3
        Cajas_Compensacion = 4
    End Enum

    Public Enum TipoDeLiquidacionImprime
        Ordinaria = 0 'Liquidacion de nomina regular
        Extraordinaria = 1 'Liquidación de cualquier concepto en cualquier momento, eje: liquidación de vacaciones
        Semestre = 2 'Liquidación de prestaciones sociales semetralmente
        LiquidaContratos = 3 'Liquidación de contratos.
    End Enum

    Public Enum EnumTipoCuentasBancarias
        NoAplica = 0
        Ahorro = 1
        Corriente = 2
    End Enum

    Public Async Function EnviarNomina(dtosGenerales As DataRow, dtosConceptos As DataTable, dtosVariables As DataTable, liquidacion As String, FinalizaContrato As Boolean, MetodoPago As String, fechaPagos As Date, dtempresa As DataTable) As Task(Of String)
        Try

            Dim Sql = "SELECT VG.CodDian, VG.NomVariable AS Nombre,MAX(VGD.Fecha) AS Fecha,VG.Sec AS Variable " &
                  "FROM DetallesVariablesGenerales VGD INNER JOIN " &
                  "VariablesGenerales VG ON VGD.Variable = vG.Sec " &
                  "group by VG.NomVariable,VG.CodDian,VG.Sec"
            Dim VariablesG = SMT_AbrirTabla(ObjetoApiNomina, Sql)
            VariablesG.Columns.Add("Valor", GetType(Decimal))
            For incre As Integer = 0 To VariablesG.Rows.Count - 1
                Dim fecha As String = CDate(VariablesG.Rows(incre)("Fecha").ToString).ToString("dd/MM/yyyy")
                Sql = "SELECT VG.NomVariable AS Nombre,VGD.Valor AS Valor " &
                        "FROM DetallesVariablesGenerales VGD " &
                        "INNER JOIN VariablesGenerales VG ON VGD.Variable = vG.Sec " &
                        "WHERE Variable ='" + VariablesG.Rows(incre)("Variable").ToString + "' AND VGD.Fecha = '" + fecha + "'"
                Dim Detalle = SMT_AbrirTabla(ObjetoApiNomina, Sql)
                VariablesG.Rows(incre)("Valor") = Detalle.Rows(0)("Valor")
            Next


            Dim NominaElectronica
            Try
                NominaElectronica = New KiaiNomina("900395252", "tufactura.co@softwareestrategico.com", dtempresa.Rows(0)("SuscriptorNom").ToString)
            Catch ex As Exception
                Return "No se ha podido iniciar sesion, verifique el codigo de suscriptor!.."
            End Try

            Dim Nomina As NominaElectronica = New NominaElectronica
            Dim FechaActual = DateTime.Now
            Dim dtMunicipio = SMT_AbrirTabla(ObjetoApiNomina, "select D.Pais,M.Departamento from G_Municipio M INNER JOIN G_Departamento D ON D.CodDpto = M.Departamento WHERE M.IdMunicipio=" + dtosGenerales("Municipio").ToString)
            Nomina.Trabajador = New Trabajador()
            Nomina.Trabajador.CodigoTrabajador = dtosGenerales("CodContrato").ToString
            Nomina.Trabajador.LugarTrabajoDepartamentoEstado = dtMunicipio.Rows(0)("Departamento").ToString
            Nomina.Trabajador.LugarTrabajoMunicipioCiudad = dtosGenerales("Municipio").ToString
            Nomina.Trabajador.LugarTrabajoDireccion = ObjetosNomina.Datos.Seguridad.DatosDeLaEmpresa.Direccion
            Nomina.Trabajador.LugarTrabajoPais = "CO"
            Nomina.Trabajador.TipoTrabajador = dtosGenerales("TipoTrabajador").ToString
            Nomina.Trabajador.TipoDocumento = dtosGenerales("TipoCodIden").ToString
            Nomina.Trabajador.NumeroDocumento = dtosGenerales("Identificacion").ToString
            Nomina.Trabajador.TipoContrato = dtosGenerales("CodTipoContrato").ToString
            Nomina.Trabajador.Sueldo = dtosGenerales("Asignacion")
            Nomina.Trabajador.SubTipoTrabajado = IIf(dtosGenerales("SubTipoTrabajador").ToString = "0", "00", "01")
            Nomina.Trabajador.SalarioIntegral = IIf(dtosGenerales("SalarioIntegral").ToString = "0", False, True)
            Nomina.Trabajador.PrimerNombre = dtosGenerales("PNombre")
            Nomina.Trabajador.OtrosNombres = dtosGenerales("SNombre")
            Nomina.Trabajador.PrimerApellido = dtosGenerales("PApellido")
            Nomina.Trabajador.SegundoApellido = dtosGenerales("SApellido")
            Nomina.LugarGeneracionXML.MunicipioCiudad = dtosGenerales("Municipio").ToString
            Nomina.ProveedorXML.SoftwareID = dtempresa.Rows(0)("SoftwareIdNom").ToString
            Nomina.NumeroSecuenciaXML.CodigoTrabajador = dtosGenerales("CodContrato")
            Nomina.NumeroSecuenciaXML.Prefijo = "NI"
            Nomina.NumeroSecuenciaXML.Consecutivo = CInt(dtosGenerales("LiquidaContrato").ToString)
            Nomina.NumeroSecuenciaXML.Numero = "NI" + dtosGenerales("LiquidaContrato").ToString
            Nomina.FechasPagos.Add(fechaPagos)
            Nomina.Redondeo = 1
            Nomina.Periodos.FechaGen = fechaPagos
            Nomina.Periodos.FechaIngreso = CDate(dtosGenerales("FechaIniCont"))
            If FinalizaContrato Then
                Nomina.Periodos.FechaRetiro = CDate("FechaFinCont")
            End If
            Nomina.Periodos.TiempoLaborado = DateDiff(DateInterval.Day, CDate(dtosGenerales("FechaIniCont")), FechaActual) + 1
            Nomina.Periodos.FechaLiquidacionInicio = CDate(dtosGenerales("FechaIniP"))
            Nomina.Periodos.FechaLiquidacionFin = CDate(dtosGenerales("FechaFinP"))
            Nomina.InformacionGeneral.Ambiente = CInt(dtempresa.Rows(0)("AmbienteNom").ToString)
            Nomina.InformacionGeneral.FechaGen = FechaActual.ToString("yyyy-MM-dd")
            Nomina.InformacionGeneral.HoraGen = FechaActual.ToString("HH:mm:ss")
            Nomina.InformacionGeneral.Notas = dtosGenerales("Comentario")
            Nomina.InformacionGeneral.TipoMoneda = "COP"
            Nomina.InformacionGeneral.TipoXML = "102"


            Dim CodPeriodo = ""
            If dtosGenerales("FormaLiquida").ToString = "7" Then
                CodPeriodo = "1"
            ElseIf dtosGenerales("FormaLiquida").ToString = "10" Then
                CodPeriodo = "2"
            ElseIf dtosGenerales("FormaLiquida").ToString = "14" Then
                CodPeriodo = "3"
            ElseIf dtosGenerales("FormaLiquida").ToString = "15" Then
                CodPeriodo = "4"
            ElseIf dtosGenerales("FormaLiquida").ToString = "30" Then
                CodPeriodo = "5"
            Else
                CodPeriodo = "6"
            End If
            Nomina.InformacionGeneral.PeriodoNomina = CodPeriodo
            Nomina.InformacionGeneral.TRM = 1
            Nomina.InformacionGeneral.Version = "V1.0: Documento Soporte de Pago de Nómina Electrónica"
            Nomina.Pago.Banco = dtosGenerales("Banco")
            Nomina.Pago.Forma = "1"
            Nomina.Pago.Metodo = MetodoPago
            Nomina.Pago.TipoCuenta = dtosGenerales("TipoCuenta")
            Nomina.Pago.NumeroCuenta = dtosGenerales("NumCuenta")
            Nomina.ComprobanteTotal = dtosGenerales("Total")
            Nomina.DevengadosTotal = dtosGenerales("Devengado")
            Nomina.DeduccionesTotal = dtosGenerales("Deducido")
            Dim bono = New BonoEPCTV
            Dim compensa = New Compensaciones
            For Each Rconceptos As DataRow In dtosConceptos.Rows
                If Rconceptos("CodDian").ToString <> "" Then
                    If CDec(Rconceptos("Valor")) > 0 Then
                        Try
                            If Rconceptos("CodDian") = "NIE194" Then
                                Nomina.Devengados.Anticipos.Add(CDec(Rconceptos("Valor")))
                            End If
                            If Rconceptos("CodDian") = "NIE157" Then
                                Nomina.Devengados.ApoyoSost = Rconceptos("Valor")
                            End If
                            If Rconceptos("CodDian") = "NIE142" Then
                                Nomina.Devengados.Auxilios.AuxilioNS = Rconceptos("Valor")
                            End If
                            If Rconceptos("CodDian") = "NIE141" Then
                                Nomina.Devengados.Auxilios.AuxilioS = Rconceptos("Valor")
                            End If
                            If Rconceptos("CodDian") = "NIE070" Then
                                If dtosVariables.Select("CodDian='NIE069'").Count <= 0 Then
                                    Return "No se ha configurado el codigo de 'CANTIDAD DIAS TRABAJADOS'"
                                End If
                                Dim cantidad = dtosVariables.Select("CodDian='NIE069'")
                                Nomina.Devengados.Basico.DiasTrabajados = CInt(cantidad(0)("Cantidad"))
                                Nomina.Devengados.Basico.SueldoTrabajado = Rconceptos("Valor")
                            End If
                            If Rconceptos("CodDian") = "NIE140" Then
                                Nomina.Devengados.Bonificaciones.BonificacionNS = Rconceptos("Valor")
                            End If
                            If Rconceptos("CodDian") = "NIE139" Then
                                Nomina.Devengados.Bonificaciones.BonificacionS = Rconceptos("Valor")
                            End If
                            If Rconceptos("CodDian") = "NIE159" Then
                                Nomina.Devengados.BonifRetiro = Rconceptos("Valor")
                            End If
                            If Rconceptos("CodDian") = "NIE154" Then
                                bono.PagoAlimentacionNS = bono.PagoAlimentacionNS + Rconceptos("Valor")
                            End If
                            If Rconceptos("CodDian") = "NIE153" Then
                                bono.PagoAlimentacionS = bono.PagoAlimentacionS + Rconceptos("Valor")
                            End If
                            If Rconceptos("CodDian") = "NIE152" Then
                                bono.PagoNS = bono.PagoNS + Rconceptos("Valor")
                            End If
                            If Rconceptos("CodDian") = "NIE151" Then
                                bono.PagoS = bono.PagoS + Rconceptos("Valor")
                            End If
                            If Rconceptos("CodDian") = "NIE120" Then
                                Nomina.Devengados.Cesantias.Pago = Rconceptos("Valor")
                                If VariablesG.Select("CodDian='NIE121'").Count <= 0 Then
                                    Return "No se ha configurado el codigo de 'PORCENTAJE CESANTIAS'"
                                End If
                                Dim cantidad = VariablesG.Select("CodDian='NIE121'")
                                Nomina.Devengados.Cesantias.Porcentaje = cantidad(0)("Valor")
                            End If
                            If Rconceptos("CodDian") = "NIE122" Then
                                Nomina.Devengados.Cesantias.PagoIntereses = Rconceptos("Valor")
                            End If
                            If Rconceptos("CodDian") = "NIE155" Then
                                Nomina.Devengados.Comisiones.Add(Rconceptos("Valor"))
                            End If
                            If Rconceptos("CodDian") = "NIE150" Then
                                compensa.CompensacionE = compensa.CompensacionE + Rconceptos("Valor")
                            End If
                            If Rconceptos("CodDian") = "NIE149" Then
                                compensa.CompensacionO = compensa.CompensacionO + Rconceptos("Valor")
                            End If
                            If Rconceptos("CodDian") = "NIE156" Then
                                Nomina.Devengados.Dotacion = Rconceptos("Valor")
                            End If
                            If Rconceptos("CodDian") = "NIE078" Then
                                If VariablesG.Select("CodDian='NIE077'").Count <= 0 Then
                                    Return "No se ha configurado el codigo de 'PORCENTAJE HORAS EXTRAS DIURNAS'"
                                End If
                                If dtosVariables.Select("CodDian='NIE076'").Count <= 0 Then
                                    Return "No se ha configurado el codigo de 'CANTIDAD HORAS EXTRAS DIURNAS'"
                                End If
                                Dim porcentaje = VariablesG.Select("CodDian='NIE077'")
                                Dim FilaVarP = dtosVariables.Select("CodDian='NIE076'")
                                Dim detalles = SMT_AbrirTabla(ObjetoApiNomina, "Select NLDP.* from NominaLiquidaDescripVarPer NLDP INNER JOIN NominaLiquidadaVariables NLC ON NLC.Sec= NLDP.CodVarP INNER JOIN VariablesPersonales C On C.Sec=NLC.Variable INNER JOIN NominaLiquidadaContratos NLCT ON NLC.SecLiquidadaContrato=NLCT.Sec INNER JOIN Contratos CT ON NLCT.Contrato = CT.CodContrato INNER JOIN NominaLiquidada NL ON NLCT.NominaLiquidada = NL.Sec INNER JOIN PeriodosLiquidacion PL ON PL.Sec = NL.Periodo INNER JOIN Nominas NO ON PL.Nomina = NO.SecNomina Where CT.CodContrato=" + dtosGenerales("CodContrato").ToString + " And C.Sec=" + FilaVarP(0)("Sec").ToString)
                                Dim valhora = CDec(Rconceptos("Valor")) / CDec(FilaVarP(0)("Cantidad"))
                                For Each i As DataRow In detalles.Rows
                                    Dim hed As New HED
                                    hed.Cantidad = i("Cantidad")
                                    hed.HoraInicio = i("FechaHoraInicio")
                                    hed.HoraFin = i("FechaHoraFin")
                                    hed.Id = i("Sec")
                                    hed.Pago = valhora * CDec(i("Cantidad"))
                                    hed.Porcentaje = CDec(porcentaje(0)("Valor"))
                                    Nomina.Devengados.HorasExtras.HED.Add(hed)
                                Next
                            End If

                            If Rconceptos("CodDian") = "NIE093" Then
                                If VariablesG.Select("CodDian='NIE092'").Count <= 0 Then
                                    Return "No se ha configurado el codigo de 'PORCENTAJE HORAS EXTRAS DIURNAS DOMINICAL/FESTIVO'"
                                End If
                                If dtosVariables.Select("CodDian='NIE091'").Count <= 0 Then



                                    Return "No se ha configurado el codigo de 'CANTIDAD HORAS EXTRAS DIURNAS DOMINICAL/FESTIVO'"
                                End If
                                Dim porcentaje = VariablesG.Select("CodDian='NIE092'")
                                Dim FilaVarP = dtosVariables.Select("CodDian='NIE091'")
                                Dim detalles = SMT_AbrirTabla(ObjetoApiNomina, "Select NLDP.* from NominaLiquidaDescripVarPer NLDP INNER JOIN NominaLiquidadaVariables NLC ON NLC.Sec= NLDP.CodVarP INNER JOIN VariablesPersonales C On C.Sec=NLC.Variable INNER JOIN NominaLiquidadaContratos NLCT ON NLC.SecLiquidadaContrato=NLCT.Sec INNER JOIN Contratos CT ON NLCT.Contrato = CT.CodContrato INNER JOIN NominaLiquidada NL ON NLCT.NominaLiquidada = NL.Sec INNER JOIN PeriodosLiquidacion PL ON PL.Sec = NL.Periodo INNER JOIN Nominas NO ON PL.Nomina = NO.SecNomina Where CT.CodContrato=" + dtosGenerales("CodContrato").ToString + " And C.Sec=" + FilaVarP(0)("Sec").ToString)
                                Dim valhora = CDec(Rconceptos("Valor")) / CDec(FilaVarP(0)("Cantidad"))
                                For Each i As DataRow In detalles.Rows
                                    Dim heddf As New HEDDF
                                    heddf.Cantidad = i("Cantidad")
                                    heddf.HoraInicio = i("FechaHoraInicio")
                                    heddf.HoraFin = i("FechaHoraFin")
                                    heddf.Id = i("Sec")
                                    heddf.Pago = valhora * CDec(i("Cantidad"))
                                    heddf.Porcentaje = CDec(porcentaje(0)("Valor"))
                                    Nomina.Devengados.HorasExtras.HEDDF.Add(heddf)
                                Next
                            End If

                            If Rconceptos("CodDian") = "NIE083" Then
                                If VariablesG.Select("CodDian='NIE082'").Count <= 0 Then
                                    Return "No se ha configurado el codigo de 'PORCENTAJE HORAS EXTRAS NOCTURNAS'"
                                End If
                                If dtosVariables.Select("CodDian='NIE081'").Count <= 0 Then
                                    Return "No se ha configurado el codigo de 'CANTIDAD HORAS EXTRAS NOCTURNAS'"
                                End If
                                Dim porcentaje = VariablesG.Select("CodDian='NIE082'")
                                Dim FilaVarP = dtosVariables.Select("CodDian='NIE081'")
                                Dim detalles = SMT_AbrirTabla(ObjetoApiNomina, "Select NLDP.* from NominaLiquidaDescripVarPer NLDP INNER JOIN NominaLiquidadaVariables NLC ON NLC.Sec= NLDP.CodVarP INNER JOIN VariablesPersonales C On C.Sec=NLC.Variable INNER JOIN NominaLiquidadaContratos NLCT ON NLC.SecLiquidadaContrato=NLCT.Sec INNER JOIN Contratos CT ON NLCT.Contrato = CT.CodContrato INNER JOIN NominaLiquidada NL ON NLCT.NominaLiquidada = NL.Sec INNER JOIN PeriodosLiquidacion PL ON PL.Sec = NL.Periodo INNER JOIN Nominas NO ON PL.Nomina = NO.SecNomina Where CT.CodContrato=" + dtosGenerales("CodContrato").ToString + " And C.Sec=" + FilaVarP(0)("Sec").ToString)
                                Dim valhora = CDec(Rconceptos("Valor")) / CDec(FilaVarP(0)("Cantidad"))
                                For Each i As DataRow In detalles.Rows
                                    Dim hen As New HEN
                                    hen.Cantidad = i("Cantidad")
                                    hen.HoraInicio = i("FechaHoraInicio")
                                    hen.HoraFin = i("FechaHoraFin")
                                    hen.Id = i("Sec")
                                    hen.Pago = valhora * CDec(i("Cantidad"))
                                    hen.Porcentaje = CDec(porcentaje(0)("Valor"))
                                    Nomina.Devengados.HorasExtras.HEN.Add(hen)
                                Next
                            End If

                            If Rconceptos("CodDian") = "NIE103" Then
                                If VariablesG.Select("CodDian='NIE102'").Count <= 0 Then
                                    Return "No se ha configurado el codigo de 'PORCENTAJE HORAS EXTRAS NOCTURNAS DOMINICAL/FESTIVO'"
                                End If
                                If dtosVariables.Select("CodDian='NIE101'").Count <= 0 Then
                                    Return "No se ha configurado el codigo de 'CANTIDAD HORAS EXTRAS NOCTURNAS DOMINICAL/FESTIVO'"
                                End If
                                Dim porcentaje = VariablesG.Select("CodDian='NIE102'")
                                Dim FilaVarP = dtosVariables.Select("CodDian='NIE101'")
                                Dim detalles = SMT_AbrirTabla(ObjetoApiNomina, "Select NLDP.* from NominaLiquidaDescripVarPer NLDP INNER JOIN NominaLiquidadaVariables NLC ON NLC.Sec= NLDP.CodVarP INNER JOIN VariablesPersonales C On C.Sec=NLC.Variable INNER JOIN NominaLiquidadaContratos NLCT ON NLC.SecLiquidadaContrato=NLCT.Sec INNER JOIN Contratos CT ON NLCT.Contrato = CT.CodContrato INNER JOIN NominaLiquidada NL ON NLCT.NominaLiquidada = NL.Sec INNER JOIN PeriodosLiquidacion PL ON PL.Sec = NL.Periodo INNER JOIN Nominas NO ON PL.Nomina = NO.SecNomina Where CT.CodContrato=" + dtosGenerales("CodContrato").ToString + " And C.Sec=" + FilaVarP(0)("Sec").ToString)
                                Dim valhora = CDec(Rconceptos("Valor")) / CDec(FilaVarP(0)("Cantidad"))

                                For Each i As DataRow In detalles.Rows
                                    Dim hendf As New HENDF
                                    hendf.Cantidad = i("Cantidad")
                                    hendf.HoraInicio = i("FechaHoraInicio")
                                    hendf.HoraFin = i("FechaHoraFin")
                                    hendf.Id = i("Sec")
                                    hendf.Pago = valhora * CDec(i("Cantidad"))
                                    hendf.Porcentaje = CDec(porcentaje(0)("Valor"))
                                    Nomina.Devengados.HorasExtras.HENDF.Add(hendf)
                                Next
                            End If

                            If Rconceptos("CodDian") = "NIE098" Then
                                If VariablesG.Select("CodDian='NIE097'").Count <= 0 Then
                                    Return "No se ha configurado el codigo de 'PORCENTAJE HORAS RECARGO DIURNO DOMINICAL/FESTIVO'"
                                End If
                                If dtosVariables.Select("CodDian='NIE096'").Count <= 0 Then
                                    Return "No se ha configurado el codigo de 'CANTIDAD HORAS RECARGO DIURNO DOMINICAL/FESTIVO'"
                                End If
                                Dim porcentaje = VariablesG.Select("CodDian='NIE097'")
                                Dim FilaVarP = dtosVariables.Select("CodDian='NIE096'")
                                Dim detalles = SMT_AbrirTabla(ObjetoApiNomina, "Select NLDP.* from NominaLiquidaDescripVarPer NLDP INNER JOIN NominaLiquidadaVariables NLC ON NLC.Sec= NLDP.CodVarP INNER JOIN VariablesPersonales C On C.Sec=NLC.Variable INNER JOIN NominaLiquidadaContratos NLCT ON NLC.SecLiquidadaContrato=NLCT.Sec INNER JOIN Contratos CT ON NLCT.Contrato = CT.CodContrato INNER JOIN NominaLiquidada NL ON NLCT.NominaLiquidada = NL.Sec INNER JOIN PeriodosLiquidacion PL ON PL.Sec = NL.Periodo INNER JOIN Nominas NO ON PL.Nomina = NO.SecNomina Where CT.CodContrato=" + dtosGenerales("CodContrato").ToString + " And C.Sec=" + FilaVarP(0)("Sec").ToString)
                                Dim valhora = CDec(Rconceptos("Valor")) / CDec(FilaVarP(0)("Cantidad"))

                                For Each i As DataRow In detalles.Rows
                                    Dim hrddf As New HRDDF
                                    hrddf.Cantidad = i("Cantidad")
                                    hrddf.HoraInicio = i("FechaHoraInicio")
                                    hrddf.HoraFin = i("FechaHoraFin")
                                    hrddf.Id = i("Sec")
                                    hrddf.Pago = valhora * CDec(i("Cantidad"))
                                    hrddf.Porcentaje = CDec(porcentaje(0)("Valor"))
                                    Nomina.Devengados.HorasExtras.HRDDF.Add(hrddf)
                                Next
                            End If
                            If Rconceptos("CodDian") = "NIE088" Then

                                If VariablesG.Select("CodDian='NIE087'").Count <= 0 Then
                                    Return "No se ha configurado el codigo de 'PORCENTAJE HORAS RECARGO NOCTURNO'"
                                End If
                                If dtosVariables.Select("CodDian='NIE086'").Count <= 0 Then
                                    Return "No se ha configurado el codigo de 'CANTIDAD HORAS RECARGO NOCTURNO'"
                                End If
                                Dim porcentaje = VariablesG.Select("CodDian='NIE087'")
                                Dim FilaVarP = dtosVariables.Select("CodDian='NIE086'")
                                Dim detalles = SMT_AbrirTabla(ObjetoApiNomina, "Select NLDP.* from NominaLiquidaDescripVarPer NLDP INNER JOIN NominaLiquidadaVariables NLC ON NLC.Sec= NLDP.CodVarP INNER JOIN VariablesPersonales C On C.Sec=NLC.Variable INNER JOIN NominaLiquidadaContratos NLCT ON NLC.SecLiquidadaContrato=NLCT.Sec INNER JOIN Contratos CT ON NLCT.Contrato = CT.CodContrato INNER JOIN NominaLiquidada NL ON NLCT.NominaLiquidada = NL.Sec INNER JOIN PeriodosLiquidacion PL ON PL.Sec = NL.Periodo INNER JOIN Nominas NO ON PL.Nomina = NO.SecNomina Where CT.CodContrato=" + dtosGenerales("CodContrato").ToString + " And C.Sec=" + FilaVarP(0)("Sec").ToString)
                                Dim valhora = CDec(Rconceptos("Valor")) / CDec(FilaVarP(0)("Cantidad"))

                                For Each i As DataRow In detalles.Rows
                                    Dim hrn As New HRN
                                    hrn.Cantidad = i("Cantidad")
                                    hrn.HoraInicio = i("FechaHoraInicio")
                                    hrn.HoraFin = i("FechaHoraFin")
                                    hrn.Id = i("Sec")
                                    hrn.Pago = valhora * CDec(i("Cantidad"))
                                    hrn.Porcentaje = CDec(porcentaje(0)("Valor"))
                                    Nomina.Devengados.HorasExtras.HRN.Add(hrn)
                                Next
                            End If
                            If Rconceptos("CodDian") = "NIE108" Then

                                If VariablesG.Select("CodDian='NIE107'").Count <= 0 Then
                                    Return "No se ha configurado el codigo de 'PORCENTAJE HORAS RECARGO NOCTURNO DOMINICAL/FESTIVO'"
                                End If
                                If dtosVariables.Select("CodDian='NIE106'").Count <= 0 Then
                                    Return "No se ha configurado el codigo de 'CANTIDAD HORAS RECARGO NOCTURNO DOMINICAL/FESTIVO'"
                                End If
                                Dim porcentaje = VariablesG.Select("CodDian='NIE107'")
                                Dim FilaVarP = dtosVariables.Select("CodDian='NIE106'")
                                Dim detalles = SMT_AbrirTabla(ObjetoApiNomina, "Select NLDP.* from NominaLiquidaDescripVarPer NLDP INNER JOIN NominaLiquidadaVariables NLC ON NLC.Sec= NLDP.CodVarP INNER JOIN VariablesPersonales C On C.Sec=NLC.Variable INNER JOIN NominaLiquidadaContratos NLCT ON NLC.SecLiquidadaContrato=NLCT.Sec INNER JOIN Contratos CT ON NLCT.Contrato = CT.CodContrato INNER JOIN NominaLiquidada NL ON NLCT.NominaLiquidada = NL.Sec INNER JOIN PeriodosLiquidacion PL ON PL.Sec = NL.Periodo INNER JOIN Nominas NO ON PL.Nomina = NO.SecNomina Where CT.CodContrato=" + dtosGenerales("CodContrato").ToString + " And C.Sec=" + FilaVarP(0)("Sec").ToString)
                                Dim valhora = CDec(Rconceptos("Valor")) / CDec(FilaVarP(0)("Cantidad"))

                                For Each i As DataRow In detalles.Rows
                                    Dim hrndf As New HRNDF
                                    hrndf.Cantidad = i("Cantidad")
                                    hrndf.HoraInicio = i("FechaHoraInicio")
                                    hrndf.HoraFin = i("FechaHoraFin")
                                    hrndf.Id = i("Sec")
                                    hrndf.Pago = valhora * CDec(i("Cantidad"))
                                    hrndf.Porcentaje = CDec(porcentaje(0)("Valor"))
                                    Nomina.Devengados.HorasExtras.HRNDF.Add(hrndf)
                                Next
                            End If
                            'If Rconceptos("CodDian") = "NIEHUELGAL" Then
                            '    Dim huelgasL As New HuelgasLegale
                            '    huelgasL.Cantidad = Rconceptos("")
                            '    huelgasL.FechaInicio = Rconceptos("")
                            '    huelgasL.FechaFIn = Rconceptos("")
                            '    Nomina.Devengados.HuelgasLegales.Add(huelgasL)
                            'End If
                            If Rconceptos("CodDian") = "NIE127" Then
                                If dtosVariables.Select("CodDian='NIE125'").Count <= 0 Then
                                    Return "No se ha configurado el codigo de 'CANTIDAD DIAS DE INCAPACIDAD'"
                                End If
                                Dim FilaVarP = dtosVariables.Select("CodDian='NIE125'")
                                Dim detalles = SMT_AbrirTabla(ObjetoApiNomina, "Select NLDP.* from NominaLiquidaDescripVarPer NLDP INNER JOIN NominaLiquidadaVariables NLC ON NLC.Sec= NLDP.CodVarP INNER JOIN VariablesPersonales C On C.Sec=NLC.Variable INNER JOIN NominaLiquidadaContratos NLCT ON NLC.SecLiquidadaContrato=NLCT.Sec INNER JOIN Contratos CT ON NLCT.Contrato = CT.CodContrato INNER JOIN NominaLiquidada NL ON NLCT.NominaLiquidada = NL.Sec INNER JOIN PeriodosLiquidacion PL ON PL.Sec = NL.Periodo INNER JOIN Nominas NO ON PL.Nomina = NO.SecNomina Where CT.CodContrato=" + dtosGenerales("CodContrato").ToString + " And C.Sec=" + FilaVarP(0)("Sec").ToString)
                                Dim valdias = CDec(Rconceptos("Valor")) / CDec(FilaVarP(0)("Cantidad"))
                                For Each i As DataRow In detalles.Rows
                                    Dim incapacidad As New Incapacidade
                                    incapacidad.Cantidad = i("Cantidad")
                                    incapacidad.FechaInicio = i("FechaHoraInicio")
                                    incapacidad.FechaFin = i("FechaHoraFin")
                                    incapacidad.Pago = valdias * CDec(i("Cantidad"))
                                    incapacidad.Tipo = i("TipoDesc")
                                    Nomina.Devengados.Incapacidades.Add(incapacidad)
                                Next
                            End If
                            If Rconceptos("CodDian") = "NIE160" Then
                                Nomina.Devengados.Indemnizacion = Rconceptos("Valor")
                            End If
                            If Rconceptos("CodDian") = "NIE131" Then

                                If dtosVariables.Select("CodDian='NIE130'").Count <= 0 Then
                                    Return "No se ha configurado el codigo de 'CANTIDAD DIAS DE LICENCIA MATERNIDAD O PATERNIDAD'"
                                End If
                                Dim FilaVarP = dtosVariables.Select("CodDian='NIE130'")
                                Dim detalles = SMT_AbrirTabla(ObjetoApiNomina, "Select NLDP.* from NominaLiquidaDescripVarPer NLDP INNER JOIN NominaLiquidadaVariables NLC ON NLC.Sec= NLDP.CodVarP INNER JOIN VariablesPersonales C On C.Sec=NLC.Variable INNER JOIN NominaLiquidadaContratos NLCT ON NLC.SecLiquidadaContrato=NLCT.Sec INNER JOIN Contratos CT ON NLCT.Contrato = CT.CodContrato INNER JOIN NominaLiquidada NL ON NLCT.NominaLiquidada = NL.Sec INNER JOIN PeriodosLiquidacion PL ON PL.Sec = NL.Periodo INNER JOIN Nominas NO ON PL.Nomina = NO.SecNomina Where CT.CodContrato=" + dtosGenerales("CodContrato").ToString + " And C.Sec=" + FilaVarP(0)("Sec").ToString)
                                Dim valdias = CDec(Rconceptos("Valor")) / CDec(FilaVarP(0)("Cantidad"))
                                For Each i As DataRow In detalles.Rows
                                    Dim LicenciaMp As New LicenciaMP
                                    LicenciaMp.Cantidad = i("Cantidad")
                                    LicenciaMp.FechaInicio = i("FechaHoraInicio")
                                    LicenciaMp.FechaFin = i("FechaHoraFin")
                                    LicenciaMp.Pago = valdias * CDec(i("Cantidad"))
                                    Nomina.Devengados.Licencias.LicenciaMP.Add(LicenciaMp)
                                Next
                            End If
                            'If Rconceptos("CodDian") = "" Then
                            '    Dim LicenciaNr As New LicenciaNR
                            '    LicenciaNr.Cantidad = Rconceptos("")
                            '    LicenciaNr.FechaInicio = Rconceptos("")
                            '    LicenciaNr.FechaFin = Rconceptos("")
                            '    Nomina.Devengados.Licencias.LicenciaNR.Add(LicenciaNr)
                            'End If
                            If Rconceptos("CodDian") = "NIE135" Then

                                If dtosVariables.Select("CodDian='NIE134'").Count <= 0 Then
                                    Return "No se ha configurado el codigo de 'CANTIDAD DIAS DE LICENCIA REMUNERADA'"
                                End If
                                Dim FilaVarP = dtosVariables.Select("CodDian='NIE134'")
                                Dim detalles = SMT_AbrirTabla(ObjetoApiNomina, "Select NLDP.* from NominaLiquidaDescripVarPer NLDP INNER JOIN NominaLiquidadaVariables NLC ON NLC.Sec= NLDP.CodVarP INNER JOIN VariablesPersonales C On C.Sec=NLC.Variable INNER JOIN NominaLiquidadaContratos NLCT ON NLC.SecLiquidadaContrato=NLCT.Sec INNER JOIN Contratos CT ON NLCT.Contrato = CT.CodContrato INNER JOIN NominaLiquidada NL ON NLCT.NominaLiquidada = NL.Sec INNER JOIN PeriodosLiquidacion PL ON PL.Sec = NL.Periodo INNER JOIN Nominas NO ON PL.Nomina = NO.SecNomina Where CT.CodContrato=" + dtosGenerales("CodContrato").ToString + " And C.Sec=" + FilaVarP(0)("Sec").ToString)
                                Dim valdias = CDec(Rconceptos("Valor")) / CDec(FilaVarP(0)("Cantidad"))
                                For Each i As DataRow In detalles.Rows
                                    Dim Licenciar As New LicenciaR
                                    Licenciar.Cantidad = i("Cantidad")
                                    Licenciar.FechaInicio = i("FechaHoraInicio")
                                    Licenciar.FechaFin = i("FechaHoraFin")
                                    Licenciar.Pago = valdias * CDec(i("Cantidad"))
                                    Nomina.Devengados.Licencias.LicenciaR.Add(Licenciar)
                                Next
                            End If
                            If Rconceptos("CodDian") = "NIE148" Then
                                Dim otroConcepto As New OtrosConcepto
                                otroConcepto.ConceptoNS = Rconceptos("Valor")
                                otroConcepto.DescripcionConcepto = Rconceptos("NomConcepto")
                                Nomina.Devengados.OtrosConceptos.Add(otroConcepto)
                            End If
                            If Rconceptos("CodDian") = "NIE147" Then
                                Dim otroConcepto As New OtrosConcepto
                                otroConcepto.ConceptoS = Rconceptos("Valor")
                                otroConcepto.DescripcionConcepto = Rconceptos("NomConcepto")
                                Nomina.Devengados.OtrosConceptos.Add(otroConcepto)
                            End If
                            If Rconceptos("CodDian") = "NIE193" Then
                                Nomina.Devengados.PagosTerceros.Add(Rconceptos("Valor"))
                            End If
                            If Rconceptos("CodDian") = "NIE118" Then
                                If dtosVariables.Select("CodDian='NIE117'").Count <= 0 Then
                                    Return "No se ha configurado el codigo de 'CANTIDAD DIAS PRIMAS'"
                                End If
                                Dim cantidad = dtosVariables.Select("CodDian='NIE117'")
                                Nomina.Devengados.Primas.Cantidad = CInt(cantidad(0)("Cantidad"))
                                Nomina.Devengados.Primas.Pago = Rconceptos("Valor")
                            End If
                            If Rconceptos("CodDian") = "NIE119" Then
                                Nomina.Devengados.Primas.PagoNS = Rconceptos("Valor")
                            End If
                            If Rconceptos("CodDian") = "NIE201" Then
                                Nomina.Devengados.Reintegro = Rconceptos("Valor")
                            End If
                            If Rconceptos("CodDian") = "NIE158" Then
                                Nomina.Devengados.Teletrabajo = Rconceptos("Valor")
                            End If
                            If Rconceptos("CodDian") = "NIE071" Then
                                Nomina.Devengados.Transporte.AuxilioTransporte = Rconceptos("Valor")
                            End If
                            If Rconceptos("CodDian") = "NIE073" Then
                                Nomina.Devengados.Transporte.ViaticoManuAlojNS = Rconceptos("Valor")
                            End If

                            If Rconceptos("CodDian") = "NIE072" Then
                                Nomina.Devengados.Transporte.ViaticoManuAlojS = Rconceptos("Valor")
                            End If
                            If Rconceptos("CodDian") = "NIE112" Then

                                If dtosVariables.Select("CodDian='NIE111'").Count <= 0 Then
                                    Return "No se ha configurado el codigo de 'CANTIDAD DIAS DE VACACIONES'"
                                End If
                                Dim FilaVarP = dtosVariables.Select("CodDian='NIE111'")
                                Dim detalles = SMT_AbrirTabla(ObjetoApiNomina, "Select NLDP.* from NominaLiquidaDescripVarPer NLDP INNER JOIN NominaLiquidadaVariables NLC ON NLC.Sec= NLDP.CodVarP INNER JOIN VariablesPersonales C On C.Sec=NLC.Variable INNER JOIN NominaLiquidadaContratos NLCT ON NLC.SecLiquidadaContrato=NLCT.Sec INNER JOIN Contratos CT ON NLCT.Contrato = CT.CodContrato INNER JOIN NominaLiquidada NL ON NLCT.NominaLiquidada = NL.Sec INNER JOIN PeriodosLiquidacion PL ON PL.Sec = NL.Periodo INNER JOIN Nominas NO ON PL.Nomina = NO.SecNomina Where CT.CodContrato=" + dtosGenerales("CodContrato").ToString + " And C.Sec=" + FilaVarP(0)("Sec").ToString)
                                Dim valdias = CDec(Rconceptos("Valor")) / CDec(FilaVarP(0)("Cantidad"))
                                For Each i As DataRow In detalles.Rows
                                    Dim vacaciones As New VacacionesComune
                                    vacaciones.Cantidad = i("Cantidad")
                                    vacaciones.FechaInicio = i("FechaHoraInicio")
                                    vacaciones.FechaFin = i("FechaHoraFin")
                                    vacaciones.Pago = valdias * CDec(i("Cantidad"))
                                    Nomina.Devengados.Vacaciones.VacacionesComunes.Add(vacaciones)
                                Next
                            End If
                            If Rconceptos("CodDian") = "NIE116" Then
                                If dtosVariables.Select("CodDian='NIE115'").Count <= 0 Then
                                    Return "No se ha configurado el codigo de 'CANTIDAD DIAS VACACIONES COMPENSADAS'"
                                End If
                                Dim cantidad = dtosVariables.Select("CodDian='NIE115'")
                                Dim vacaciones As New VacacionesCompensada
                                vacaciones.Cantidad = CInt(cantidad(0)("Cantidad"))
                                vacaciones.Pago = Rconceptos("Valor")
                                Nomina.Devengados.Vacaciones.VacacionesCompensadas.Add(vacaciones)
                            End If
                            If Rconceptos("CodDian") = "NIE179" Then
                                Nomina.Deducciones.AFC = Rconceptos("Valor")
                            End If
                            If Rconceptos("CodDian") = "NIE196" Then
                                Nomina.Deducciones.Anticipos.Add(Rconceptos("Valor"))
                            End If
                            If Rconceptos("CodDian") = "NIE180" Then
                                Nomina.Deducciones.Cooperativa = Rconceptos("Valor")
                            End If
                            If Rconceptos("CodDian") = "NIE185" Then
                                Nomina.Deducciones.Deuda = Rconceptos("Valor")
                            End If
                            If Rconceptos("CodDian") = "NIE183" Then
                                Nomina.Deducciones.Educacion = Rconceptos("Valor")
                            End If
                            If Rconceptos("CodDian") = "NIE181" Then
                                Nomina.Deducciones.EmbargoFiscal = Rconceptos("Valor")
                            End If
                            If Rconceptos("CodDian") = "NIE166" Then
                                If VariablesG.Select("CodDian='NIE164'").Count <= 0 Then
                                    Return "No se ha configurado el codigo de 'PORCENTAJE PENSION EMPLEADO'"
                                End If
                                Dim porcentaje = VariablesG.Select("CodDian='NIE164'")
                                Nomina.Deducciones.FondoPension.Deduccion = Rconceptos("Valor")
                                Nomina.Deducciones.FondoPension.Porcentaje = porcentaje(0)("Valor")
                            End If
                            If Rconceptos("CodDian") = "NIE168" Then
                                If VariablesG.Select("CodDian='NIE167'").Count <= 0 Then
                                    Return "No se ha configurado el codigo de 'PORCENTAJE FONDO DE SEGURIDAD PENSIONAL'"
                                End If
                                Dim porcentaje = VariablesG.Select("CodDian='NIE167'")
                                Nomina.Deducciones.FondoSP.DeduccionSP = Rconceptos("Valor")
                                Nomina.Deducciones.FondoSP.Porcentaje = porcentaje(0)("Valor")
                            End If
                            If Rconceptos("CodDian") = "NIE170" Then
                                If VariablesG.Select("CodDian='NIE169'").Count <= 0 Then
                                    Return "No se ha configurado el codigo de 'PORCENTAJE FONDO DE SUBSISTENCIA'"
                                End If
                                Dim porcentaje = VariablesG.Select("CodDian='NIE169'")
                                Nomina.Deducciones.FondoSP.DeduccionSub = Rconceptos("Valor")
                                Nomina.Deducciones.FondoSP.PorcentajeSub = porcentaje(0)("Valor")
                            End If
                            If Rconceptos("CodDian") = "NIE176" Then
                                Dim lbranza As New Libranza
                                lbranza.Deduccion = Rconceptos("Valor")
                                lbranza.Descripcion = Rconceptos("NomConcepto")
                                Nomina.Deducciones.Libranzas.Add(lbranza)
                            End If
                            If Rconceptos("CodDian") = "NIE197" Then
                                Nomina.Deducciones.OtrasDeducciones.Add(Rconceptos("Valor"))
                            End If
                            If Rconceptos("CodDian") = "NIE195" Then
                                Nomina.Deducciones.PagosTerceros.Add(Rconceptos("Valor"))
                            End If
                            If Rconceptos("CodDian") = "NIE198" Then
                                Nomina.Deducciones.PensionVoluntaria = Rconceptos("Valor")
                            End If
                            If Rconceptos("CodDian") = "NIE182" Then
                                Nomina.Deducciones.PlanComplementarios = Rconceptos("Valor")
                            End If
                            If Rconceptos("CodDian") = "NIE184" Then
                                Nomina.Deducciones.Reintegro = Rconceptos("Valor")
                            End If
                            If Rconceptos("CodDian") = "NIE177" Then
                                Nomina.Deducciones.RetencionFuente = Rconceptos("Valor")
                            End If
                            If Rconceptos("CodDian") = "NIE163" Then
                                If VariablesG.Select("CodDian='NIE161'").Count <= 0 Then
                                    Return "No se ha configurado el codigo de 'PORCENTAJE SALUD EMPLEADO'"
                                End If
                                Dim porcentaje = VariablesG.Select("CodDian='NIE161'")
                                Nomina.Deducciones.Salud.Deduccion = Rconceptos("Valor")
                                Nomina.Deducciones.Salud.Porcentaje = porcentaje(0)("Valor")
                            End If
                            If Rconceptos("CodDian") = "NIE174" Then
                                Dim sancion As New Sancione
                                sancion.SancionPriv = Rconceptos("Valor")
                                Nomina.Deducciones.Sanciones.Add(sancion)
                            End If

                            If Rconceptos("CodDian") = "NIE173" Then
                                Dim sancion As New Sancione
                                sancion.SancionPublic = Rconceptos("Valor")
                                Nomina.Deducciones.Sanciones.Add(sancion)
                            End If
                            If Rconceptos("CodDian") = "NIE172" Then
                                If VariablesG.Select("CodDian='NIE171'").Count <= 0 Then
                                    Return "No se ha configurado el codigo de 'PORCENTAJE APORTES DEL SINDICATO'"
                                End If
                                Dim porcentaje = VariablesG.Select("CodDian='NIE171'")
                                Dim sindi As New Sindicato
                                sindi.Deduccion = Rconceptos("Valor")
                                sindi.Porcentaje = porcentaje(0)("Valor")
                                Nomina.Deducciones.Sindicatos.Add(sindi)
                            End If
                        Catch ex As Exception
                            Return "Se ha encontrado un error en el concepto (" + Rconceptos("NomConcepto").ToString + ") " + ex.Message
                        End Try
                    End If
                Else
                    Return "No se ha configurado el codigo de (" + Rconceptos("NomConcepto").ToString + ")"
                End If
            Next
            If bono.PagoAlimentacionNS <> 0 And bono.PagoAlimentacionNS <> Nothing Or bono.PagoAlimentacionS <> 0 And bono.PagoAlimentacionS <> Nothing Or bono.PagoNS <> 0 And bono.PagoNS <> Nothing Or bono.PagoS <> 0 And bono.PagoS <> Nothing Then
                Nomina.Devengados.BonoEPCTVs.Add(bono)
            End If
            If compensa.CompensacionE <> 0 And compensa.CompensacionE <> Nothing Or compensa.CompensacionO <> 0 And compensa.CompensacionO <> Nothing Then
                Nomina.Devengados.Compensaciones.Add(compensa)
            End If
            Dim json = JsonConvert.SerializeObject(Nomina)
            'File.WriteAllText($"{My.Application.Info.DirectoryPath}\json{Nomina.Trabajador.CodigoTrabajador}.txt", json)
            Dim res As RespuestaEmisionDocumentos, Respondio As Boolean = False
            res = Await NominaElectronica.Emitir(Nomina)

            For i As Integer = 0 To 300
                If IsNothing(res.Control.CufeCude) And CInt(dtempresa.Rows(0)("AmbienteNom").ToString) <> 3 Then
                    If res.Envio.Mensaje.Contains("procesado anteriormente") Or res.Validaciones.Descripcion.Contains("Documento con errores") Then
                        Exit For
                    End If
                    Thread.Sleep(500)
                Else
                    Respondio = True
                    Exit For
                End If
            Next
            If Respondio Then
                dtosGenerales("Cufe") = res.Control.CufeCude
                dtosGenerales("DoceId") = res.Validaciones.DoceId
            Else
                Dim procesadoantes = False
                If Not IsNothing(res.Envio.Mensaje) Then
                    If res.Envio.Mensaje.Contains("procesado anteriormente") Then
                        Dim cufee = Split(res.Envio.Mensaje, "CUNE")
                        dtosGenerales("Cufe") = Trim(cufee(1))
                        dtosGenerales("DoceId") = res.Validaciones.DoceId
                        procesadoantes = True
                    End If
                End If
                If Not procesadoantes Then
                    If IsNothing(res.Control.CufeCude) And CInt(dtempresa.Rows(0)("AmbienteNom").ToString) <> 3 Then
                        If Not IsNothing(res.Validaciones.Detalle) Then
                            If res.Validaciones.Detalle.Count > 0 Then
                                Return res.Validaciones.Descripcion + vbCrLf + IIf(IsNothing(res.Validaciones.Detalle(0).Validacion.ToString), "", res.Validaciones.Detalle(0).Validacion.ToString)
                            Else
                                Return res.Validaciones.Descripcion
                            End If
                        End If
                    End If
                    Return "SIN RESPUESTA DIAN"
                Else
                    Return "Procesado Correctamente."
                End If
            End If

            Return res.Envio.Mensaje
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Public Async Function EliminarNominaDian(dtosGenerales As DataRow, dtempresa As DataTable) As Task(Of String)
        Dim NominaElectronica As New KiaiNomina("900395252", "tufactura.co@softwareestrategico.com", dtempresa.Rows(0)("SuscriptorNom").ToString)
        Dim Nomina As NominaElectronica = New NominaElectronica
        Dim res = Await NominaElectronica.Eliminar(dtosGenerales("Cufe").ToString, CInt(dtosGenerales("LiquidaContrato").ToString), "NE")
        Return res.Validaciones.mensaje
    End Function

    Public Function ValidaNombresR(Nombre As String) As Boolean

        Dim sql As String = "Select Consul.Nombre From( " +
        " Select NomBase As Nombre From  BasesConceptos" +
        " Union Select NomConcepto As Nombre From ConceptosNomina" +
        " Union Select NomVariable As Nombre From VariablesGenerales" +
        " Union Select NomVariable As Nombre From VariablesPersonales" +
        " Union Select NomConcepto As Nombre From ConceptosPersonales" +
        " Union Select 'HorasMes' As Nombre " +
        " Union Select 'Asignacion' As Nombre " +
        " Union Select 'RentaExenta' As Nombre " +
        " Union Select 'DescuentosPorNomina' As Nombre " +
        " Union Select 'SalarioPromedioPeriodo' As Nombre " +
        " Union Select 'SalarioPromedioMensualAnual' As Nombre " +
        " Union Select 'SalarioPromedioMensualSemestral' As Nombre " +
        " Union Select 'NetoAPagar' As Nombre " +
        " Union Select 'TotalPagadoMes' As Nombre " +
        " Union Select 'TotalIngresos' As Nombre  " +
        " Union Select 'TotalDeducciones' As Nombre  " +
        " ) as Consul Where Consul.Nombre ='" + Nombre + "'"
        Dim dt As DataTable = SMT_AbrirTabla(ObjetoApiNomina, sql)
        If dt.Rows.Count > 0 Then
            Return False
        End If

        Return True
    End Function

    Public Sub ModNomFormulas(NomVariable As String, NuevoNomVariable As String)
        SMT_EjcutarComandoSql(ObjetoApiNomina, String.Format("UPDATE ConfigConceptos SET Formula = REPLACE(SUBSTRING(Formula, 1, DATALENGTH(Formula)),'[" + NomVariable + "]', '[" + NuevoNomVariable + "]')"), 0)
        SMT_EjcutarComandoSql(ObjetoApiNomina, String.Format("UPDATE ConceptosPersonales SET ValMaxDescuento = REPLACE(SUBSTRING(ValMaxDescuento, 1, DATALENGTH(ValMaxDescuento)),'[" + NomVariable + "]', '[" + NuevoNomVariable + "]')"), 0)
        SMT_EjcutarComandoSql(ObjetoApiNomina, String.Format("UPDATE BasesConceptos SET Formula = REPLACE(SUBSTRING(Formula, 1, DATALENGTH(Formula)),'[" + NomVariable + "]', '[" + NuevoNomVariable + "]')"), 0)
        SMT_EjcutarComandoSql(ObjetoApiNomina, String.Format("UPDATE Plantillas SET ValorMaxDescontar = REPLACE(SUBSTRING(ValorMaxDescontar, 1, DATALENGTH(ValorMaxDescontar)),'[" + NomVariable + "]', '[" + NuevoNomVariable + "]')"), 0)
        SMT_EjcutarComandoSql(ObjetoApiNomina, String.Format("UPDATE TiposContratos_ConceptosNomina SET Formula = REPLACE(SUBSTRING(Formula, 1, DATALENGTH(Formula)),'[" + NomVariable + "]', '[" + NuevoNomVariable + "]')"), 0)
        SMT_EjcutarComandoSql(ObjetoApiNomina, String.Format("UPDATE ConfigProvisiones SET Formula = REPLACE(SUBSTRING(Formula, 1, DATALENGTH(Formula)),'[" + NomVariable + "]', '[" + NuevoNomVariable + "]')"), 0)
        SMT_EjcutarComandoSql(ObjetoApiNomina, String.Format("UPDATE TiposContratos_ConceptosNomina SET BaseCalculo ='" + NuevoNomVariable + "' Where BaseCalculo='" + NomVariable + "'"), 0)
        SMT_EjcutarComandoSql(ObjetoApiNomina, String.Format("UPDATE ConceptosNomina SET Base = '" + NuevoNomVariable + "' Where Base='" + NomVariable + "'"), 0)
    End Sub

    Public Function ValidaEnFormulas(NomVariable As String) As Boolean
        Dim sql As String = "Select STUFF((SELECT ','+ Formula FROM ConfigConceptos  FOR XML PATH('')),1,1,'') As ConfigConceptos, STUFF((SELECT ','+ ValMaxDescuento FROM ConceptosPersonales  FOR XML PATH('')),1,1,'') As ConceptosPersonales,
STUFF((SELECT ','+ Formula FROM BasesConceptos  FOR XML PATH('')),1,1,'') As BasesConceptos, STUFF((SELECT ','+ ValorMaxDescontar FROM Plantillas  FOR XML PATH('')),1,1,'') As Planillas,
STUFF((SELECT ','+ Formula FROM TiposContratos_ConceptosNomina  FOR XML PATH('')),1,1,'') As LiquidaContratos, STUFF((SELECT ','+ Formula FROM ConfigProvisiones  FOR XML PATH('')),1,1,'') As PrestacionesSociales"
        Dim dt As DataTable = SMT_AbrirTabla(ObjetoApiNomina, sql)

        sql = "Select * from TiposContratos_ConceptosNomina Where BaseCalculo='" + NomVariable + "'"
        Dim dt2 As DataTable = SMT_AbrirTabla(ObjetoApiNomina, sql)

        sql = "Select * from ConceptosNomina Where Base='" + NomVariable + "'"
        Dim dt3 As DataTable = SMT_AbrirTabla(ObjetoApiNomina, sql)

        If dt.Rows(0)(0).ToString.Contains("[" + NomVariable + "]") Then
            HDevExpre.MensagedeError("Lo sentimos, este dato pertenece a una formula en la configuracion de conceptos de nomina, no puede ser eliminado!..")
            Return False
        ElseIf dt.Rows(0)(1).ToString.Contains("[" + NomVariable + "]") Then
            HDevExpre.MensagedeError("Lo sentimos, este dato pertenece a una formula en la configuracion de conceptos personales, no puede ser eliminado!..")
            Return False
        ElseIf dt.Rows(0)(2).ToString.Contains("[" + NomVariable + "]") Then
            HDevExpre.MensagedeError("Lo sentimos, este dato pertenece a una formula de una base, no puede ser eliminado!..")
            Return False
        ElseIf dt.Rows(0)(3).ToString.Contains("[" + NomVariable + "]") Then
            HDevExpre.MensagedeError("Lo sentimos, este dato pertenece a la formula de un perfil de conceptos, no puede ser eliminado!..")
            Return False
        ElseIf dt.Rows(0)(4).ToString.Contains("[" + NomVariable + "]") Then
            HDevExpre.MensagedeError("Lo sentimos, este dato pertenece a una formula en la configuracion de liquidacion de contratos, no puede ser eliminado!..")
            Return False
        ElseIf dt.Rows(0)(5).ToString.Contains("[" + NomVariable + "]") Then
            HDevExpre.MensagedeError("Lo sentimos, este dato pertenece a una formula en la configuracion de prestaciones sociales y mas, no puede ser eliminado!..")
            Return False
        ElseIf dt2.Rows.Count > 0 Then
            HDevExpre.MensagedeError("Lo sentimos, este dato pertenece a una base de liquidacion de contratos, no puede ser eliminado!..")
            Return False
        ElseIf dt3.Rows.Count > 0 Then
            HDevExpre.MensagedeError("Lo sentimos, este dato pertenece a una base de liquidacion de un concepto de nomina, no puede ser eliminado!..")
            Return False
        Else
            Return True
        End If
    End Function

End Class
