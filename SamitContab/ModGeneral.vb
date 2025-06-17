Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing

Module ModGeneral
    Enum DatoValida
        Oficina = 1
        TipoComprobante = 2
        CodigoComprobante = 3
        NumeroDocumento = 4
        Tercero = 5
        CentrodeCosto = 6
        ConceptoRete = 7
        CodIva = 8
        EstablecimientoTercero = 9
        QueExistalaCxP_CxC_Si_va_a_abonar = 10
        CodigoControlPersonalizado = 11
    End Enum
    Public Structure TipoDatoValida
        Dim TipoDatoqueValido As DatoValida
        Dim Valor As String
        Dim Valor2 As String
        Dim Valor3 As String
        Dim Existe As Boolean
    End Structure
    Public MisDatos As DatosGenerales
    Private DatosValidados() As TipoDatoValida
    Public Structure DatosGenerales
        Dim Empresa As Integer
        Dim NomBD As String
        Dim NomBDGen As String
        Dim ConexLocal As Conexion
        Dim ConexSeg As Conexion
        Dim FechaHora As DateTime
    End Structure

    Public Structure DatoCliente
        Dim IdCliente As Long
        Dim Identificacion As Decimal
        Dim DV As String
        Dim Nombre_Completo As String
        Dim NombreComercial As String
        Dim Apellidos As String
        Dim Nombres As String
        Dim TipoPersona As String
        Dim TipoId As String
        Dim Genero As String
        Dim FechaIngreso As Date
        Dim FechaNace As String
        Dim Direccion As String
        Dim Email As String
        Dim PaginaWeb As String
        Dim MunicipioUbicacion As DatosMunicipios
        Dim Barrio As String
        Dim Telefonos As String
        Dim Celular As String
        Dim Profesion As String
        Dim Cliente_CupoCredito As Decimal
        Dim Cliente_DiasPlazo As Long
        Dim Cliente_VendedorAsignado As Long
        Dim Cliente_CobradorAsignado As Long
        Dim NoFacturarIVA As Boolean
        Dim Proveedor_CupoCredito As Decimal
        Dim Proveedor_DiasPlazo As Long
        Dim ClasificacionIva As ClasificacionesDelIva
        Dim ResponsabledeIva As Boolean
        Dim RetieneRenta As Boolean
        Dim RetieneICA As Boolean
        Dim RetieneIVA As Boolean
        Dim AutoRetieneRenta As Boolean
        Dim AutoRetieneICA As Boolean
        Dim EsCliente As Boolean
        Dim EsProveedor As Boolean
        Dim EsEmpleado As Boolean
        Dim EsSocio As Boolean
        'Dim Foto As image
        Dim NombreEstablecimiento As String
        Dim Establecimientos() As DatosEstablecimiento
        Dim EstablecimientoSeleccionado As DatosEstablecimiento
        Dim RetencionesAplica() As DatosRetencionesxCliente

    End Structure
    Public Structure DatosEstablecimiento
        Dim CodEstablecimiento As Integer
        Dim Nombre As String
        Dim Ciudad As String
        Dim Direccion As String
        Dim Telefonos As String
        Dim Celular As String
    End Structure
    Public Structure DatosPaises
        Dim Codigo_Pais As String
        Dim Nombre_Pais As String
        Dim Codigo_Iso As String
    End Structure
    Public Structure DatosDepartamentos
        Dim Pais_Dpto As DatosPaises
        Dim Cod_Dpto As String
        Dim Nombre_Depto As String
    End Structure
    Public Structure DatosMunicipios
        Dim Departamento As DatosDepartamentos
        Dim KeyMunicipio As String
        Dim Codigo As String
        Dim Nombre As String
    End Structure
    Public Enum TipoFacDIAN
        SinDefinir = 0
        Computador = 1
        Papel = 2
        Pos = 3
    End Enum
    Public Enum ClasificacionesDelIva
        Entidad_Estatal = 0
        Gran_Contribuyente = 1
        Regimen_Comun = 2
        Regimen_Simplificado = 3
        Otras_Pers
    End Enum

    Public Structure DatosResulucion
        Dim NumResolucion As String
        Dim FechaResolucion As String
        Dim PreFijo As String
        Dim TipoFac As TipoFacDIAN
        Dim NumDesde As Long
        Dim NumHasta As Long
        Dim AvisaCambioResolucion As Boolean
        Dim NumDiasAvisa As Long
        Dim NumFacturasAvisa As Long
        Dim ResolucionSec As Integer
    End Structure
    Public Enum TiposdeDocumentos
        RecibosdeCaja = 1
        ComprobantesdePago = 2
        NotasdeContabilidad = 3
        NotasCredito = 4
        NotasDebito = 5
        FacturasdeVenta = 6
        RegistrodeCompras = 7
        NotasdeTraslado = 8
        Aforos = 9
        Remisiones = 10
        ConversionProductos = 11
        EnsambleProductos = 12
        DevolucionenVentas = 13
        DevolucionenCompras = 14
        NotaAjusteInventarios = 15
        Cotizaciones = 16
        NotaAjusteProduccion = 17
        OrdenesdeCompra = 18
        PedidodeClientes = 19
        DespachosdeBodega = 20
    End Enum
    Public Structure DatosTipoComprobante
        Dim Id_Tipo As String
        Dim NombreTipo As String
        Dim NumFormato As TiposdeDocumentos
        Dim Estado As String
    End Structure
    Public Structure DatosComprobante
        Dim TipoComprobante As DatosTipoComprobante
        Dim Seccomp As Integer
        Dim SecDocumento As Long
        Dim Oficina As Byte
        Dim Num_Documento As Byte
        Dim Num_Siguiente As Long
        Dim NumAutomatica As Boolean
        Dim NumeroCopias As Byte
        Dim ReqComent As Boolean
        Dim ReqTercer As Boolean
        Dim ReqCheque As Boolean
        Dim NumItems As Integer
        Dim NumFormato As TiposdeDocumentos
        Dim Estado As String
        Dim Descripcion As String
        Dim Titulo As String
        Dim Cuenta As String
        Dim CambiaCuenta As Boolean
        Dim DatoFactura As ParametroFactura
        Dim FormatoCheque As Integer
        Dim FormatoFechaCheque As Integer
        Dim ParametroImpresion As Configuracion_Pagina
        Dim UsaImagenComoEncabezado As Boolean
        Dim UsaImagenAdicionalDerechaEncabezado As Boolean
        Dim UsaImagenMarcaDeAgua As Boolean
        Dim ModoNIIF As Integer
        'Dim ImagenEncabezado As Image
        'Dim ImagenDerecha As Image
        'Dim ImagenMarcadeAgua As Image

    End Structure
    Public Structure ParametroFactura
        Dim FacTuraPos As Boolean
        Dim ModeloPOS As Byte
        Dim ModeloEstandar As Byte
        Dim RellenaZeros As Boolean
        Dim RedondeaIVA As Boolean
        Dim FPagoPred As Integer
        Dim Tercero As DatoCliente
        Dim ResolucionDian As DatosResulucion
        Dim Mensaje As String
        Dim FormatoFuenteMensaje As System.Drawing.Font
        Dim Alineacion As String
        Dim MensajeLegal As String
        Dim FormatoFuenteMensajeLegal As System.Drawing.Font
        Dim AlineacionMensajeLegal As String
        Dim CopiasImprime As EnumNumeroCopiasImprime
        Dim TextoOriginal As String
        Dim TextoCopia1 As String
        Dim TextoCopia2 As String
    End Structure
    Public Enum EnumNumeroCopiasImprime
        SoloOriginal = 0
        Copia1 = 1
        Copia2 = 2
    End Enum
    Public Structure DatosTipoRetencion
        Dim Codigo As Byte
        Dim Nombre As String
        Dim TipoImpuestoRetiene As TipoImpuestoRet
    End Structure
    Public Enum TamañoPagina
        Carta = 1
        Oficio = 2
        MediaCarta = 3
    End Enum
    Public Enum TipoImpuestoRet
        Impuesto_Renta = 0
        Impuesto_Industria_y_Cio = 1
        Impuesto_Ventas_IVA = 2
        Impuesto_Timbre = 3
    End Enum
    Public Structure Configuracion_Pagina
        Dim ImprimeLogo As Boolean
        Dim Tamaño As TamañoPagina
        Dim MargenIzquierdo As Integer
        Dim MargenDerecho As Integer
        Dim MargenSuperior As Integer
        Dim MargenInferior As Integer
        Dim ImprimeRPX As Boolean
        Dim ArchivoRPX As String
    End Structure
    Public Structure DatosConceptosRetención
        Dim SecConcepto As Integer
        Dim TipoRet As Byte
        Dim CodConcepto As Integer
        Dim NomConcepto As String
        Dim Porcentaje As Decimal
        Dim Redondea As Boolean
        Dim UnidadRedondeo As Integer
        Dim Estado As String
        Dim TipoRetencion As DatosTipoRetencion
    End Structure
    Public Structure DatosRetencionesxCliente
        Dim ConceptoRetencionProductos As DatosConceptosRetención
        Dim ConceptoRetencionServicios As DatosConceptosRetención
    End Structure
    Public Function SMT_AbrirTabla(ByVal Con As Conexion, ByVal SQL As String) As DataTable
        Dim SMTCmd As New SqlCommand, TB As New DataTable, Adaptador As SqlDataAdapter
        Try
            SMTCmd.Connection = Con.conection
            SMTCmd.CommandText = SQL
            SMTCmd.CommandType = CommandType.Text
            'SMTCmd.Transaction = Transaccion
            SMTCmd.Transaction = Con.Tran
            Adaptador = New SqlDataAdapter(SMTCmd)
            Adaptador.Fill(TB)
            Adaptador.Dispose()
            SMTCmd.Dispose()
        Catch ex As Exception
            TB = Nothing
        End Try
        SMTCmd.Dispose()

        Return TB
    End Function
    Public Function LaCuentaEsValidaParaElActivo(CodigoActivo As String, Cuenta As String) As Boolean
        On Error GoTo ControlError
        Dim TB As DataTable, SQL As String
        SQL = " SELECT CodACT, CodGrupo,CtaVrHis,CtaPVal,CtaGPVal,CtaVal,CtaProv From AC_Grupos " & _
              " INNER JOIN AC_Tipos ON AC_Tipos.GrupoCon = AC_Grupos.CodGrupo " & _
              " INNER JOIN AC_Catalogo ON AC_Catalogo.Tipo = AC_Tipos.Codigo " & _
              " WHERE AC_Catalogo.CodACT='" & CodigoActivo & "'"
        TB = SMT_AbrirTabla(MisDatos.ConexLocal, SQL)
        If TB.Rows.Count = 1 Then
            If TB(0)("CodAct") = CodigoActivo Then
                If TB(0)("CtaVrHis") = Cuenta Or TB(0)("CtaPVal") = Cuenta Or TB(0)("CtaGPVal") = Cuenta Or TB(0)("CtaVal") = Cuenta Or TB(0)("CtaProv") = Cuenta Then
                    Return True
                End If
            End If
        End If
        TB.Dispose()
        Return False
        Exit Function
ControlError:
    End Function
    Public Function ExisteActivo(CodigoActivo As String, Optional ByRef NombreActivo As String = "") As Boolean
        On Error Resume Next
        Dim TB As DataTable, SQL As String
        SQL = "Select CodACT, Nombre From AC_Catalogo Where CodACT='" & CodigoActivo & "'"
        TB = SMT_AbrirTabla(MisDatos.ConexLocal, SQL)
        If TB.Rows.Count = 1 Then
            If TB(0)("CodAct") = CodigoActivo Then
                Return True
            End If
        End If
        TB.Dispose()
        Return False

    End Function
    Public Function TipoControl_ControlPE(CodControl As String, Optional ByRef ExisteControl As Boolean = False) As Integer
        Dim SQL As String, Cmd As SqlCommand

        SQL = "SELECT isnull(TipoControl ,0) From CT_CP_Control Where CodControl='" & CodControl & "'"
        Cmd = New SqlCommand(SQL, MisDatos.ConexLocal.conection)
        Return Convert.ToInt32(Cmd.ExecuteScalar())
        Cmd.Dispose()
    End Function
    Public Function TipoComprobanteEsdeContabilidad(TipoComp As String) As Boolean
        On Error Resume Next
        Dim Tipo As Integer
        Tipo = CInt(TraerDatoSQL("select NumFormato from ct_comtipo WHERE idTC ='" + TipoComp + "'", MisDatos.ConexLocal))
        If Tipo = 1 Or Tipo = 2 Or Tipo = 3 Or Tipo = 4 Or Tipo = 5 Then
            Return True
        End If
        Return False
    End Function
    Public Function ExisteDato(Tabla As String, Cond As String, MiConex As Conexion) As Boolean
        On Error GoTo Err_ExisteDato
        Dim Tbl As DataTable, TxtSQL As String, Campo As String, SitioOperador As Integer
        If MiConex.EstadoConexion = ConnectionState.Closed Then Return False

        ' SitioOperador = InStr(1, Cond, "=", vbTextCompare)
        SitioOperador = Cond.IndexOf("=")
        If SitioOperador = 0 Then SitioOperador = Cond.IndexOf("<")
        If SitioOperador = 0 Then SitioOperador = Cond.IndexOf(">")
        If SitioOperador <= 0 Then Return False
        Campo = Strings.Left(Cond, SitioOperador).Trim
        'Campo = Cond.Substring(0, SitioOperador).Trim
        TxtSQL = "Select " & Campo & " From " & Tabla & " Where " & Cond
        Tbl = MiConex.SMT_AbrirTabla(TxtSQL)
        If IsNothing(Tbl) Then Return False
        If Tbl.Rows.Count > 0 Then Return True
        Tbl = Nothing
        Return False
        Exit Function
Err_ExisteDato:
        Return False
    End Function
    ''' <summary>
    ''' Traer un dato de una consulta sql
    ''' Solo trae el primer campo
    ''' </summary>
    ''' <param name="SQL">String del sql</param>
    ''' <param name="Conex">Conexion de tipo sqlconnection</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function TraerDatoSQL(SQL As String, Conex As Conexion) As String
        On Error GoTo Err_TraerDatoSQL
        Dim Rs As SqlDataReader

        Rs = Conex.SMT_AbrirTablaReader(SQL)
        If Not Rs.HasRows Then Return ""
        If Rs.Read() Then
            TraerDatoSQL = Rs(0).ToString
            Rs.Close()
            Rs = Nothing
            Return TraerDatoSQL
        End If
        Rs.Close()
        Rs = Nothing
        Return ""
Exit_TraerDatoSQL:
        Exit Function
Err_TraerDatoSQL:
        Resume Exit_TraerDatoSQL
    End Function
    Public Function SMT_AbrirTablaReader(ByVal Con As Conexion, ByVal SQL As String) As SqlDataReader
        Dim SMTCmd As New SqlCommand, Rs As SqlDataReader
        Try
            SMTCmd.Connection = Con.conection
            SMTCmd.CommandText = SQL
            SMTCmd.CommandType = CommandType.Text
            SMTCmd.Transaction = Con.Tran
            Rs = SMTCmd.ExecuteReader
            SMTCmd.Dispose()
            SMTCmd = Nothing
            Return Rs

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Nothing
    End Function
    Public Function ExisteTabla(ByRef Conexion As Conexion, NombreTabla As String) As Boolean
        On Error GoTo Err_ExisteTabla
        Dim Tbl As DataTable, TxtSQL As String
        TxtSQL = "Select Name From SysObjects Where Name = '" & NombreTabla & "' And Xtype = 'U'"
        Tbl = SMT_AbrirTabla(Conexion, TxtSQL)
        If Tbl.Rows.Count <= 0 Then Return False Else Return True
        Exit Function
Err_ExisteTabla:
        Return False
    End Function
    Public Sub LeerDatosComprobante(TipoComp As String, IdComprobante As Byte, ByRef Datos As DatosComprobante, Optional PorSecuencial As Boolean = False, _
                                    Optional Secuencial As Integer = 0, Optional BdAno As String = "", Optional Tran As SqlTransaction = Nothing)
        Dim TxtSQL As String = "", Tbl As New DataTable, TblRes As New DataTable
        On Error Resume Next
        If PorSecuencial = False Then
            TxtSQL = "Select *  From CT_Comprobantes " & _
                    " INNER JOIN CT_ComTipo On IdTc = TipoComp " & _
                     "WHERE TipoComp = '" & TipoComp & "' " & _
                     "AND IdComp =" & IdComprobante
        Else
            TxtSQL = "Select *  From CT_Comprobantes " & _
                          " INNER JOIN CT_ComTipo On IdTc = TipoComp " & _
                          " Where SecComp = " & Secuencial
        End If
        Tbl = MisDatos.ConexLocal.SMT_AbrirTabla(TxtSQL)

        If Tbl.Rows.Count = 1 Then

            Datos.TipoComprobante.Estado = Tbl.Rows(0)("EstadoTC")
            Datos.TipoComprobante.Id_Tipo = Tbl.Rows(0)("IdTc")
            Datos.TipoComprobante.NombreTipo = Tbl.Rows(0)("NomTc")
            Datos.TipoComprobante.NumFormato = Tbl.Rows(0)("NumFormato")
            Datos.Seccomp = Tbl.Rows(0)("Seccomp")
            Datos.Oficina = Tbl.Rows(0)("OfiComp")
            Datos.Num_Documento = Tbl.Rows(0)("IdComp")
            Datos.Num_Siguiente = Tbl.Rows(0)("NumSiguiente")
            Datos.NumAutomatica = Tbl.Rows(0)("NumAutomatica")
            Datos.NumeroCopias = Tbl.Rows(0)("NumCopias")
            Datos.NumFormato = (Tbl.Rows(0)("NumFormato"))
            Datos.NumItems = Tbl.Rows(0)("NumItems")
            Datos.ReqComent = Tbl.Rows(0)("RequiereComentario")
            Datos.ReqTercer = Tbl.Rows(0)("RequiereTercero")
            Datos.ReqCheque = Tbl.Rows(0)("RequiereCheque")
            Datos.FormatoCheque = IIf(IsDBNull(Tbl.Rows(0)("FormatoCheque")), 0, Tbl.Rows(0)("FormatoCheque") - 1)
            Datos.FormatoFechaCheque = IIf(IsDBNull(Tbl.Rows(0)("FormatoFechaCheque")), 0, Tbl.Rows(0)("FormatoFechaCheque") - 1)
            Datos.Estado = Tbl.Rows(0)("Estado").ToString
            Datos.Titulo = Tbl.Rows(0)("Titulo")
            Datos.Cuenta = IIf(IsDBNull(Tbl.Rows(0)("Cuenta")), "", Tbl.Rows(0)("Cuenta"))
            Datos.Descripcion = CStr(Tbl.Rows(0)("DesComp"))
            Datos.CambiaCuenta = CBool(IIf(IsDBNull(Tbl.Rows(0)("CambiaCuenta")), False, Tbl.Rows(0)("CambiaCuenta")))
            Datos.ModoNIIF = Tbl.Rows(0)("ManejoNiif")
            If Datos.NumFormato = TiposdeDocumentos.FacturasdeVenta Then
                If ExisteTabla(MisDatos.ConexLocal, "CT_ComprobanteResDIAN") Then
                    Tbl.Dispose()
                    TxtSQL = "Select top 1 * from CT_ComprobanteResDIAN Where Comprobante = " & Datos.Seccomp & _
                             " AND Vigente = 1"
                    TblRes = MisDatos.ConexLocal.SMT_AbrirTabla(TxtSQL)
                    If TblRes.Rows.Count > 0 Then
                        Datos.DatoFactura.ResolucionDian.NumResolucion = CStr(IIf(IsDBNull(TblRes.Rows(0)("Resolucion").ToString), "", TblRes.Rows(0)("Resolucion").ToString))
                        Datos.DatoFactura.ResolucionDian.FechaResolucion = IIf(IsDBNull(TblRes.Rows(0)("FechaRes")), "", TblRes.Rows(0)("FechaRes"))
                        Datos.DatoFactura.ResolucionDian.PreFijo = CStr(IIf(IsDBNull(TblRes.Rows(0)("PreFijo")), "", TblRes.Rows(0)("PreFijo")))
                        Datos.DatoFactura.ResolucionDian.TipoFac = IIf(IsDBNull(TblRes.Rows(0)("TipoFac")), TipoFacDIAN.SinDefinir, TblRes.Rows(0)("TipoFac"))
                        Datos.DatoFactura.ResolucionDian.NumDesde = IIf(IsDBNull(TblRes.Rows(0)("NumDesde")), 0, TblRes.Rows(0)("NumDesde"))
                        Datos.DatoFactura.ResolucionDian.NumHasta = IIf(IsDBNull(TblRes.Rows(0)("NumHasta")), 0, TblRes.Rows(0)("NumHasta"))
                        Datos.DatoFactura.ResolucionDian.AvisaCambioResolucion = IIf(IsDBNull(TblRes.Rows(0)("AVTermRes")), 0, TblRes.Rows(0)("AVTermRes"))
                        Datos.DatoFactura.ResolucionDian.NumDiasAvisa = IIf(IsDBNull(TblRes.Rows(0)("DiasAV")), 0, TblRes.Rows(0)("DiasAV"))
                        Datos.DatoFactura.ResolucionDian.NumFacturasAvisa = IIf(IsDBNull(TblRes.Rows(0)("FacAV")), 0, TblRes.Rows(0)("FacAV"))
                        Datos.DatoFactura.ResolucionDian.ResolucionSec = IIf(IsDBNull(TblRes.Rows(0)("Secuencia")), 0, TblRes.Rows(0)("Secuencia"))
                    Else
                        Datos.DatoFactura.ResolucionDian.NumResolucion = IIf(IsDBNull(Tbl.Rows(0)("Resolucion")), "", Tbl.Rows(0)("Resolucion"))
                        Datos.DatoFactura.ResolucionDian.FechaResolucion = IIf(IsDBNull(Tbl.Rows(0)("FechaRes")), "", Tbl.Rows(0)("FechaRes"))
                        Datos.DatoFactura.ResolucionDian.PreFijo = IIf(IsDBNull(Tbl.Rows(0)("PreFijo")), "", Tbl.Rows(0)("PreFijo"))
                        Datos.DatoFactura.ResolucionDian.TipoFac = IIf(IsDBNull(Tbl.Rows(0)("TipoFac")), TipoFacDIAN.SinDefinir, Tbl.Rows(0)("TipoFac"))
                        Datos.DatoFactura.ResolucionDian.NumDesde = IIf(IsDBNull(Tbl.Rows(0)("NumDesde")), 0, Tbl.Rows(0)("NumDesde"))
                        Datos.DatoFactura.ResolucionDian.NumHasta = IIf(IsDBNull(Tbl.Rows(0)("NumHasta")), 0, Tbl.Rows(0)("NumHasta"))
                        Datos.DatoFactura.ResolucionDian.AvisaCambioResolucion = IIf(IsDBNull(Tbl.Rows(0)("AVTermRes")), 0, Tbl.Rows(0)("AVTermRes"))
                        Datos.DatoFactura.ResolucionDian.NumDiasAvisa = IIf(IsDBNull(Tbl.Rows(0)("DiasAV")), 0, Tbl.Rows(0)("DiasAV"))
                        Datos.DatoFactura.ResolucionDian.NumFacturasAvisa = IIf(IsDBNull(Tbl.Rows(0)("FacAV")), 0, Tbl.Rows(0)("FacAV"))
                        Datos.DatoFactura.ResolucionDian.ResolucionSec = 0
                    End If
                Else
                    Datos.DatoFactura.ResolucionDian.NumResolucion = IIf(IsDBNull(Tbl.Rows(0)("Resolucion")), "", Tbl.Rows(0)("Resolucion"))
                    Datos.DatoFactura.ResolucionDian.FechaResolucion = IIf(IsDBNull(Tbl.Rows(0)("FechaRes")), "", Tbl.Rows(0)("FechaRes"))
                    Datos.DatoFactura.ResolucionDian.PreFijo = IIf(IsDBNull(Tbl.Rows(0)("PreFijo")), "", Tbl.Rows(0)("PreFijo"))
                    Datos.DatoFactura.ResolucionDian.TipoFac = IIf(IsDBNull(Tbl.Rows(0)("TipoFac")), TipoFacDIAN.SinDefinir, Tbl.Rows(0)("TipoFac"))
                    Datos.DatoFactura.ResolucionDian.NumDesde = IIf(IsDBNull(Tbl.Rows(0)("NumDesde")), 0, Tbl.Rows(0)("NumDesde"))
                    Datos.DatoFactura.ResolucionDian.NumHasta = IIf(IsDBNull(Tbl.Rows(0)("NumHasta")), 0, Tbl.Rows(0)("NumHasta"))
                    Datos.DatoFactura.ResolucionDian.AvisaCambioResolucion = IIf(IsDBNull(Tbl.Rows(0)("AVTermRes")), 0, Tbl.Rows(0)("AVTermRes"))
                    Datos.DatoFactura.ResolucionDian.NumDiasAvisa = IIf(IsDBNull(Tbl.Rows(0)("DiasAV")), 0, Tbl.Rows(0)("DiasAV"))
                    Datos.DatoFactura.ResolucionDian.NumFacturasAvisa = IIf(IsDBNull(Tbl.Rows(0)("FacAV")), 0, Tbl.Rows(0)("FacAV"))
                    Datos.DatoFactura.ResolucionDian.ResolucionSec = 0
                End If
                TblRes.Dispose()
                TblRes = Nothing
            End If

            Datos.DatoFactura.FacTuraPos = IIf(IsDBNull(Tbl.Rows(0)("FraPos")), 0, Tbl.Rows(0)("FraPos"))
            Datos.DatoFactura.ModeloPOS = IIf(IsDBNull(Tbl.Rows(0)("ModeloFraPos")), 0, Tbl.Rows(0)("ModeloFraPos"))
            Datos.DatoFactura.ModeloEstandar = IIf(IsDBNull(Tbl.Rows(0)("ModeloFraStd")), 0, Tbl.Rows(0)("ModeloFraStd"))
            Datos.DatoFactura.RedondeaIVA = IIf(IsDBNull(Tbl.Rows(0)("RedondeaIVA")), False, Tbl.Rows(0)("RedondeaIVA"))
            Datos.DatoFactura.RellenaZeros = IIf(IsDBNull(Tbl.Rows(0)("RellenaZeros")), False, Tbl.Rows(0)("RellenaZeros"))
            Datos.DatoFactura.FPagoPred = IIf(IsDBNull(Tbl.Rows(0)("FpagoP")), 0, Tbl.Rows(0)("FpagoP"))
            Datos.DatoFactura.Tercero.Identificacion = IIf(IsDBNull(Tbl.Rows(0)("TerceroP")), 0, Tbl.Rows(0)("TerceroP"))
            Datos.DatoFactura.Mensaje = IIf(IsDBNull(Tbl.Rows(0)("Mensaje")), "", Tbl.Rows(0)("Mensaje"))
            Datos.DatoFactura.MensajeLegal = (Tbl.Rows(0)("MensajeLegal"))
            Datos.DatoFactura.CopiasImprime = (Tbl.Rows(0)("NumImp"))
            Datos.DatoFactura.TextoOriginal = (Tbl.Rows(0)("TextoOrg"))
            Datos.DatoFactura.TextoCopia1 = (Tbl.Rows(0)("TextoC1"))
            Datos.DatoFactura.TextoCopia2 = (Tbl.Rows(0)("TextoC2"))
            Datos.ParametroImpresion.ImprimeRPX = IIf(IsDBNull(Tbl.Rows(0)("ImpRPX")), False, Tbl.Rows(0)("ImpRPX"))
            Datos.ParametroImpresion.ImprimeLogo = IIf(IsDBNull(Tbl.Rows(0)("ImprimeLogo")), False, Tbl.Rows(0)("ImprimeLogo"))
            Datos.ParametroImpresion.ArchivoRPX = IIf(IsDBNull(Tbl.Rows(0)("ArcRPX")), "", Tbl.Rows(0)("ArcRPX"))
            Datos.ParametroImpresion.MargenDerecho = IIf(IsDBNull(Tbl.Rows(0)("MargenDerecho")), 100, Tbl.Rows(0)("MargenDerecho"))
            Datos.ParametroImpresion.MargenInferior = IIf(IsDBNull(Tbl.Rows(0)("MargenInferior")), 100, Tbl.Rows(0)("MargenInferior"))
            Datos.ParametroImpresion.MargenIzquierdo = IIf(IsDBNull(Tbl.Rows(0)("MargenIzquierdo")), 100, Tbl.Rows(0)("MargenIzquierdo"))
            Datos.ParametroImpresion.MargenSuperior = IIf(IsDBNull(Tbl.Rows(0)("MargenSuperior")), 100, Tbl.Rows(0)("MargenSuperior"))
            Datos.ParametroImpresion.Tamaño = IIf(IsDBNull(Tbl.Rows(0)("TamañoPagina")), 1, Tbl.Rows(0)("TamañoPagina"))

            Dim VrFuente As New System.Drawing.Font("Arial", FontStyle.Regular)
            Dim TipoLetra As String = LeerParaMMsgFactura(Tbl.Rows(0)("FormatoMensaje"), "FontName")
            Dim TamañoLetra As Single = Convert.ToSingle(LeerParaMMsgFactura(Tbl.Rows(0)("FormatoMensaje"), "FontSize"))
            Dim Negrita As FontStyle = IIf(LeerParaMMsgFactura(Tbl.Rows(0)("FormatoMensaje"), "FontBold") = "Verdadero", FontStyle.Bold, FontStyle.Regular)
            Dim Italica As FontStyle = IIf(LeerParaMMsgFactura(Tbl.Rows(0)("FormatoMensaje"), "FontItalic") = "Verdadero", FontStyle.Italic, FontStyle.Regular)


            Datos.DatoFactura.FormatoFuenteMensaje = VrFuente
            VrFuente = Nothing

            Datos.UsaImagenAdicionalDerechaEncabezado = (Tbl.Rows(0)("UsaLogoD"))
            Datos.UsaImagenComoEncabezado = (Tbl.Rows(0)("UsaLogoEncab"))
            Datos.UsaImagenMarcaDeAgua = (Tbl.Rows(0)("UsaMarcaAgua"))

        Else
            Datos.TipoComprobante.Estado = ""
            Datos.TipoComprobante.Id_Tipo = ""
            Datos.TipoComprobante.NombreTipo = ""
            Datos.TipoComprobante.NumFormato = 0
            Datos.Seccomp = 0
            Datos.Oficina = 0
            Datos.Num_Documento = 0
            Datos.Num_Siguiente = 0
            Datos.NumAutomatica = False
            Datos.NumeroCopias = 1
            Datos.NumFormato = 0
            Datos.NumItems = 0
            Datos.ReqCheque = False
            Datos.FormatoCheque = ""
            Datos.FormatoFechaCheque = ""
            Datos.ReqComent = True
            Datos.ReqTercer = True
            Datos.Estado = ""
            Datos.CambiaCuenta = False
            Datos.Descripcion = ""
            Datos.DatoFactura.Mensaje = ""
            Datos.DatoFactura.ResolucionDian.NumResolucion = ""
            Datos.DatoFactura.ResolucionDian.FechaResolucion = Now.Date
            Datos.DatoFactura.ResolucionDian.PreFijo = ""
            Datos.DatoFactura.ResolucionDian.TipoFac = 1
            Datos.DatoFactura.ResolucionDian.NumDesde = 0
            Datos.DatoFactura.ResolucionDian.NumHasta = 0
            Datos.DatoFactura.FacTuraPos = 0
            Datos.DatoFactura.ModeloPOS = 0
            Datos.DatoFactura.RedondeaIVA = False
            Datos.DatoFactura.RellenaZeros = False
            Datos.DatoFactura.FPagoPred = 0
            Datos.DatoFactura.Tercero.Identificacion = 0
            Datos.DatoFactura.MensajeLegal = ""
            Datos.DatoFactura.FormatoFuenteMensaje = New System.Drawing.Font("Arial", 10)

            Datos.UsaImagenAdicionalDerechaEncabezado = False
            Datos.UsaImagenComoEncabezado = False
            Datos.UsaImagenMarcaDeAgua = False
            Datos.ParametroImpresion.ImprimeRPX = False
            Datos.ParametroImpresion.ImprimeLogo = False
            Datos.ParametroImpresion.ArchivoRPX = ""
            Datos.ParametroImpresion.MargenDerecho = 100
            Datos.ParametroImpresion.MargenInferior = 100
            Datos.ParametroImpresion.MargenIzquierdo = 100
            Datos.ParametroImpresion.MargenSuperior = 100
            Datos.DatoFactura.ResolucionDian.AvisaCambioResolucion = False
            Datos.DatoFactura.ResolucionDian.NumDiasAvisa = 0
            Datos.DatoFactura.ResolucionDian.NumFacturasAvisa = 0
            Datos.DatoFactura.ModeloEstandar = 0
            Datos.DatoFactura.CopiasImprime = EnumNumeroCopiasImprime.SoloOriginal
            Datos.DatoFactura.TextoOriginal = ""
            Datos.DatoFactura.TextoCopia1 = ""
            Datos.DatoFactura.TextoCopia2 = ""
        End If
        Tbl.Dispose() : Tbl = Nothing
    End Sub

    Public Sub Limpiar_Datos_Concepto_Retencion(ByRef Datos As DatosConceptosRetención)
        Datos.CodConcepto = 0
        Datos.SecConcepto = 0
        Datos.NomConcepto = ""
        Datos.Redondea = False
        Datos.UnidadRedondeo = 0
        Datos.TipoRet = 0
        Datos.Estado = ""
        Datos.TipoRetencion.Codigo = 0
        Datos.TipoRetencion.Nombre = ""
        Datos.TipoRetencion.TipoImpuestoRetiene = TipoImpuestoRet.Impuesto_Renta
    End Sub
    Public Sub Leer_Datos_Municipio_En_Bd(CodigoMunicipio As String, ByRef VMunicipio As DatosMunicipios)
        Dim TB As New DataTable, SQL As String
        If CodigoMunicipio = "" Then
            Limpiar_Datos_Municipio(VMunicipio)
            Exit Sub
        End If
        SQL = "Select G_Pais.*,G_Departamento.*,G_Municipio.* FROM G_Pais " & _
                 "INNER JOIN (G_Departamento INNER JOIN G_Municipio ON G_Departamento.CodDpto = G_Municipio.Departamento) " & _
                 "ON G_Pais.CodPais = G_Departamento.Pais WHERE ((G_Municipio.IdMunicipio)='" & CodigoMunicipio & "')"
        TB = SMT_AbrirTabla(MisDatos.ConexLocal, SQL)

        If TB.Rows.Count <= 0 Then
            Limpiar_Datos_Municipio(VMunicipio)
            If CodigoMunicipio <> "" Then MsgBox("Municipio Inexiste", vbCritical, "Samit SQL")
            Exit Sub
        Else
            VMunicipio.KeyMunicipio = TB.Rows(0)("IdMunicipio")
            VMunicipio.Codigo = TB.Rows(0)("CodMunicipio")
            VMunicipio.Nombre = TB.Rows(0)("NombreMunicipio")
            VMunicipio.Departamento.Cod_Dpto = TB.Rows(0)("CodDpto")
            VMunicipio.Departamento.Nombre_Depto = TB.Rows(0)("NomDpto")
            VMunicipio.Departamento.Pais_Dpto.Codigo_Pais = TB.Rows(0)("CodPais")
            VMunicipio.Departamento.Pais_Dpto.Nombre_Pais = TB.Rows(0)("NomPais")
            VMunicipio.Departamento.Pais_Dpto.Codigo_Iso = TB.Rows(0)("CodIso")
        End If
    End Sub
    Public Sub Limpiar_Datos_Municipio(ByRef VMunicipio As DatosMunicipios)
        VMunicipio.KeyMunicipio = ""
        VMunicipio.Codigo = ""
        VMunicipio.Nombre = ""
        VMunicipio.Departamento.Cod_Dpto = ""
        VMunicipio.Departamento.Nombre_Depto = ""
        VMunicipio.Departamento.Pais_Dpto.Codigo_Pais = ""
        VMunicipio.Departamento.Pais_Dpto.Nombre_Pais = ""
        VMunicipio.Departamento.Pais_Dpto.Codigo_Iso = ""
    End Sub

    Public Function LeerParaMMsgFactura(Texto As String, Parametro As String) As String
        On Error Resume Next
        Dim PosIni As Long, Ancho As Long, PosFin As Long
        PosIni = InStr(1, Texto, Parametro, vbTextCompare) + Len(Parametro) + 1
        PosFin = InStr(PosIni, Texto, ";", vbTextCompare)
        If PosFin = 0 Then PosFin = Len(Texto) + 1
        Ancho = PosFin - (PosIni)
        LeerParaMMsgFactura = Mid(Texto, PosIni, Ancho)
    End Function
End Module
