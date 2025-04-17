Option Explicit On
Imports Microsoft.Win32
Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports System.Drawing
Imports SamitCtlNet.SamitCtlNet.ClSmtImagenes
Imports System.Threading
Public Class ClFunciones
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
    Public Enum TipoImpuestoRet
        Impuesto_Renta = 0
        Impuesto_Industria_y_Cio = 1
        Impuesto_Ventas_IVA = 2
        Impuesto_Timbre = 3
    End Enum
    Public Enum TipoConsultaCliente
        PorSecuencialDelCliente = 1
        PorNumeroDeIdentificacion = 2
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
    Public Structure DatosPaises
        Dim Codigo_Pais As String
        Dim Nombre_Pais As String
        Dim Codigo_Iso As String
    End Structure
    Public Structure DatosUsuario
        Dim Login As String
        Dim PWD As String
        Dim Numero As Integer
        Dim TranAuto() As Long
        Dim CodigodeSesion As Long
    End Structure
    Public Enum TamañoPagina
        Carta = 1
        Oficio = 2
        MediaCarta = 3
    End Enum

    Public Enum EnumNumeroCopiasImprime
        SoloOriginal = 0
        Copia1 = 1
        Copia2 = 2
    End Enum
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
    Public Enum ClasificacionesDelIva
        Entidad_Estatal = 0
        Gran_Contribuyente = 1
        Regimen_Comun = 2
        Regimen_Simplificado = 3
        Otras_Personas = 4
    End Enum
    Public Structure DatosTipoRetencion
        Dim Codigo As Byte
        Dim Nombre As String
        Dim TipoImpuestoRetiene As TipoImpuestoRet
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
    Public Structure DatosEstablecimiento
        Dim CodEstablecimiento As Integer
        Dim Nombre As String
        Dim Ciudad As String
        Dim Direccion As String
        Dim Telefonos As String
        Dim Celular As String
    End Structure
    Public Enum TipoFacDIAN
        SinDefinir = 0
        Computador = 1
        Papel = 2
        Pos = 3
    End Enum
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
        Dim Foto As Image
        Dim NombreEstablecimiento As String
        Dim Establecimientos() As DatosEstablecimiento
        Dim EstablecimientoSeleccionado As DatosEstablecimiento
        Dim RetencionesAplica() As DatosRetencionesxCliente

    End Structure
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
        Dim Alineacion As DevExpress.XtraPrinting.TextAlignment
        Dim MensajeLegal As String
        Dim FormatoFuenteMensajeLegal As System.Drawing.Font
        Dim AlineacionMensajeLegal As DevExpress.XtraPrinting.TextAlignment
        Dim CopiasImprime As EnumNumeroCopiasImprime
        Dim TextoOriginal As String
        Dim TextoCopia1 As String
        Dim TextoCopia2 As String
    End Structure

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
        Dim ImagenEncabezado As Image
        Dim ImagenDerecha As Image
        Dim ImagenMarcadeAgua As Image

    End Structure
    Public Sub LeerDatosComprobante(TipoComp As String, IdComprobante As Byte, ByRef Datos As DatosComprobante, Optional PorSecuencial As Boolean = False, _
                                Optional Secuencial As Integer = 0, Optional BdAno As String = "")
        Dim TxtSQL As String = "", Tbl As New DataTable, TblRes As New DataTable
        On Error Resume Next
        If BdAno = "" Then BdAno = "E" & Format(VgEmpresa, "000") & Format(Year(FechaW), "0000")
        If PorSecuencial = False Then
            TxtSQL = "Select *  From " & BdAno & "..CT_Comprobantes " & _
                    " INNER JOIN " & BdAno & "..CT_ComTipo On IdTc = TipoComp " & _
                     "WHERE TipoComp = '" & TipoComp & "' " & _
                     "AND IdComp =" & IdComprobante
        Else
            TxtSQL = "Select *  From " & BdAno & "..CT_Comprobantes " & _
                          " INNER JOIN " & BdAno & "..CT_ComTipo On IdTc = TipoComp " & _
                          " Where SecComp = " & Secuencial
        End If
        Tbl = SMT_AbrirRecordSet(SMTConexMod, TxtSQL)

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
            If Datos.NumFormato = TiposdeDocumentos.FacturasdeVenta Then
                If ExisteTabla(SMTConexMod, "CT_ComprobanteResDIAN") Then
                    Tbl.Dispose()
                    TxtSQL = "Select top 1 * from CT_ComprobanteResDIAN Where Comprobante = " & Datos.Seccomp & _
                             " AND Vigente = 1"
                    TblRes = SMT_AbrirRecordSet(SMTConexMod, TxtSQL)
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
            Datos.DatoFactura.Tercero.Nombre_Completo = NombreTercero((IIf(IsDBNull(Tbl.Rows(0)("TerceroP")), 0, Tbl.Rows(0)("TerceroP"))), 0)
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
            DatosTercero(Datos.DatoFactura.Tercero.Identificacion, TipoConsultaCliente.PorNumeroDeIdentificacion, Datos.DatoFactura.Tercero, True, False, False)

            Dim VrFuente As System.Drawing.Font
            Dim TipoLetra As String = LeerParaMMsgFactura(Tbl.Rows(0)("FormatoMensaje"), "FontName")
            Dim TamañoLetra As Single = Convert.ToSingle(LeerParaMMsgFactura(Tbl.Rows(0)("FormatoMensaje"), "FontSize"))
            Dim Negrita As FontStyle = IIf(LeerParaMMsgFactura(Tbl.Rows(0)("FormatoMensaje"), "FontBold") = "Verdadero", FontStyle.Bold, FontStyle.Regular)
            Dim Italica As FontStyle = IIf(LeerParaMMsgFactura(Tbl.Rows(0)("FormatoMensaje"), "FontItalic") = "Verdadero", FontStyle.Italic, FontStyle.Regular)


            If Tbl.Rows(0)("FormatoMensaje") = "" Or IsDBNull(Tbl.Rows(0)("FormatoMensaje")) Then
                VrFuente = New System.Drawing.Font("Arial", 10)
                Datos.DatoFactura.Alineacion = DevExpress.XtraPrinting.TextAlignment.MiddleJustify
            Else
                VrFuente = New System.Drawing.Font(TipoLetra, TamañoLetra, Negrita Or Italica)

                'VrFuente.Name = LeerParaMMsgFactura(Tbl.Rows(0)("FormatoMensaje"), "FontName")
                'VrFuente.Size = LeerParaMMsgFactura(Tbl.Rows(0)("FormatoMensaje"), "FontSize")
                'VrFuente.Bold = IIf((LeerParaMMsgFactura(Tbl.Rows(0)("FormatoMensaje"), "FontBold")) = "Verdadero", True, False)
                'VrFuente.Italic = IIf(LeerParaMMsgFactura(Tbl.Rows(0)("FormatoMensaje"), "FontItalic") = "Verdadero", True, False)
                'VrFuente.Strikethrough = False
                'VrFuente.Underline = False
                'Datos.DatoFactura.Alineacion = LeerParaMMsgFactura(Tbl.Rows(0)("FormatoMensaje"), "Alignment")
                Datos.DatoFactura.Alineacion = DevExpress.XtraPrinting.TextAlignment.MiddleJustify
            End If
            Datos.DatoFactura.FormatoFuenteMensaje = VrFuente
            VrFuente = Nothing
            If Tbl.Rows(0)("FormatoMensajeL") = "" Or IsDBNull(Tbl.Rows(0)("FormatoMensajeL")) Then
                VrFuente = New System.Drawing.Font("Arial", 10)
                Datos.DatoFactura.Alineacion = DevExpress.XtraPrinting.TextAlignment.MiddleJustify
            Else

                VrFuente = TraerTipodeLetra_FONT(LeerParaMMsgFactura(Tbl.Rows(0)("FormatoMensajeL"), "FontName"), LeerParaMMsgFactura(Tbl.Rows(0)("FormatoMensajeL"), "FontSize"), IIf((LeerParaMMsgFactura(Tbl.Rows(0)("FormatoMensajeL"), "FontBold")) = "Verdadero", True, False), IIf(LeerParaMMsgFactura(Tbl.Rows(0)("FormatoMensajeL"), "FontItalic") = "Verdadero", True, False))
                'VrFuente.Name = LeerParaMMsgFactura(Tbl.Rows(0)("FormatoMensajeL"), "FontName")
                'VrFuente.Size = LeerParaMMsgFactura(Tbl.Rows(0)("FormatoMensajeL"), "FontSize")
                'VrFuente.Bold = IIf((LeerParaMMsgFactura(Tbl.Rows(0)("FormatoMensajeL"), "FontBold")) = "Verdadero", True, False)
                'VrFuente.Italic = IIf(LeerParaMMsgFactura(Tbl.Rows(0)("FormatoMensajeL"), "FontItalic") = "Verdadero", True, False)
                'VrFuente.Strikethrough = False
                'VrFuente.Underline = False
                Datos.DatoFactura.AlineacionMensajeLegal = LeerParaMMsgFactura(Tbl.Rows(0)("FormatoMensajeL"), "Alignment")
            End If
            Datos.DatoFactura.FormatoFuenteMensajeLegal = VrFuente

            Datos.UsaImagenAdicionalDerechaEncabezado = (Tbl.Rows(0)("UsaLogoD"))
            Datos.UsaImagenComoEncabezado = (Tbl.Rows(0)("UsaLogoEncab"))
            Datos.UsaImagenMarcaDeAgua = (Tbl.Rows(0)("UsaMarcaAgua"))
            Datos.ImagenDerecha = SMT_Conv_Byte_A_Image(Tbl.Rows(0)("ImageLogoD"))
            Datos.ImagenEncabezado = SMT_Conv_Byte_A_Image(Tbl.Rows(0)("LogoEncab"))
            Datos.ImagenMarcadeAgua = SMT_Conv_Byte_A_Image(Tbl.Rows(0)("ImageMarcaAgua"))
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

            Datos.ImagenDerecha = Nothing
            Datos.ImagenEncabezado = Nothing
            Datos.ImagenMarcadeAgua = Nothing
            Datos.UsaImagenAdicionalDerechaEncabezado = False
            Datos.UsaImagenComoEncabezado = False
            Datos.UsaImagenMarcaDeAgua = False
            DatosTercero(Datos.DatoFactura.Tercero.Identificacion, TipoConsultaCliente.PorNumeroDeIdentificacion, Datos.DatoFactura.Tercero, True, False, False)
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
    Public Function DatosTercero(Vr_A_Buscar As String, TipoConsulta As TipoConsultaCliente, _
                            ByRef Datos As DatoCliente, Optional ModificaDatosRef As Boolean = False, _
                            Optional CargaEstablecimientos As Boolean = False, Optional CargaFoto As Boolean = False, _
                            Optional CargaConfiguracionRetenciones As Boolean = False, _
                            Optional CodEstablecimiento As Integer = 0) As String
        'On Error GoTo Err_NomTercero
        On Error Resume Next
        Dim TxtSQL As String, Tbl As New DataTable, RsC As New DataTable, X As Integer
        Dim Campos As String

        Campos = " IdCliente , TipoIdentificacion , Identificacion , Dv , PApellido , SApellido , PNombre , SNombre , " & _
                 "FechaNacimiento , Nacionalidad , Profesion , Actividad , EstadoCivil , isnull(FechaIngreso,getdate()) as FechaIngreso , TipoEmpresa , " & _
                 "RepresentanteLegal , Calificacion , Retencion , Comentario ," & _
                 IIf(CargaFoto, "Foto ,", " ") & _
                 "Afiliado , Email , DiasPago , Socio ," & _
                 "cliente , proveedor , empleado , VRCupoCredCli , VRCupoCredPro , DiasPagoProv , FechaVin , LugarExpDoc , " & _
                 "MunicipioNacimiento , Genero , TipoPersona , Direccion , Municipio , Barrio , Tel1 , Tel2 , NumCelular , " & _
                 "EmpresaLab , TelEmpLab , CargoEmpLab , WebPage , FechaConst , NomGerente , IdenGerente , ActividadEco ," & _
                 "ClasificacionIVA , ResponsableIVA , RetieneRenta , RetieneICA , RetieneIVA , AutoRetFte , NumResFte , " & _
                 "FechaResFte , AutoRetICA , DireccionDIAN , CedRef , NombreComercial, VendAsg, NoFacIVA, CobraAsig "
        DatosTercero = ""
        If SMTConexMod.State = 0 Then Exit Function
        If Vr_A_Buscar = 0 Then Exit Function
        If Not IsNumeric(Vr_A_Buscar) Then Exit Function
        TxtSQL = "Select " & Campos & " From G_Clientes "
        If TipoConsulta = TipoConsultaCliente.PorNumeroDeIdentificacion Then
            TxtSQL = TxtSQL & "Where Identificacion=" & Vr_A_Buscar
        Else
            TxtSQL = TxtSQL & "Where IdCliente=" & Vr_A_Buscar
        End If
        Tbl = SMT_AbrirRecordSet(SMTConexMod, TxtSQL)
        If Tbl.Rows.Count > 0 Then
            ReDim Datos.RetencionesAplica(5)
            If Not IsDBNull(Tbl.Rows(0)("Papellido")) Then DatosTercero = Tbl.Rows(0)("Papellido")
            If Not IsDBNull(Tbl.Rows(0)("Sapellido")) Then DatosTercero = DatosTercero & " " & Tbl.Rows(0)("Sapellido")
            If Not IsDBNull(Tbl.Rows(0)("Pnombre")) Then DatosTercero = DatosTercero & " " & Tbl.Rows(0)("Pnombre")
            If Not IsDBNull(Tbl.Rows(0)("SNombre")) Then DatosTercero = DatosTercero & " " & Tbl.Rows(0)("SNombre")
            If Not IsDBNull(Tbl.Rows(0)("NombreComercial")) Then
                DatosTercero = DatosTercero & " - " & Tbl.Rows(0)("NombreComercial")
                Datos.NombreComercial = (Tbl.Rows(0)("NombreComercial"))
            End If
            Datos.Identificacion = Tbl.Rows(0)("Identificacion")
            Datos.Nombre_Completo = Replace(Trim(DatosTercero), "  ", " ", 1, , vbTextCompare)
            Datos.Nombre_Completo = Replace(Datos.Nombre_Completo, "  ", " ", 1, , vbTextCompare)
            Datos.Foto = Nothing
            If CargaFoto Then
                If Not IsDBNull(Tbl.Rows(0)("Foto")) Then
                    Datos.Foto = SMT_Conv_Byte_A_Image(Tbl.Rows(0)("Foto"))
                End If
            End If
            Datos.Nombres = Replace(Trim((Tbl.Rows(0)("Pnombre")) & " " & (Tbl.Rows(0)("SNombre"))), "  ", " ", 1, , vbTextCompare)
            Datos.Apellidos = Replace(Trim((Tbl.Rows(0)("Papellido")) & " " & (Tbl.Rows(0)("Sapellido"))), "  ", " ", 1, , vbTextCompare)
            'DatosTercero = DatosTercero & " " & Tbl.Rows(0)("")Pnombre
            Datos.IdCliente = Tbl.Rows(0)("IdCliente")
            Datos.TipoPersona = IIf(IsDBNull(Tbl.Rows(0)("TipoPersona")), "N", Tbl.Rows(0)("TipoPersona"))
            If Not IsDBNull(Tbl.Rows(0)("DV")) Then Datos.DV = Tbl.Rows(0)("DV") Else Datos.DV = ""
            Datos.TipoId = (Tbl.Rows(0)("TipoIdentificacion"))
            Datos.Direccion = (Tbl.Rows(0)("Direccion"))
            Datos.Genero = (Tbl.Rows(0)("Genero"))
            Datos.FechaIngreso = (Tbl.Rows(0)("FechaIngreso"))
            Datos.FechaNace = (Tbl.Rows(0)("FechaNacimiento").ToString)
            Datos.Email = (Tbl.Rows(0)("Email"))
            Datos.PaginaWeb = (Tbl.Rows(0)("WebPage"))
            Leer_Datos_Municipio_En_Bd((Tbl.Rows(0)("Municipio")), Datos.MunicipioUbicacion)
            Datos.Barrio = (Tbl.Rows(0)("Barrio"))
            Datos.Telefonos = IIf(Tbl.Rows(0)("Tel1") <> "", Tbl.Rows(0)("Tel1") & IIf(Tbl.Rows(0)("Tel2") <> "", " - " & Tbl.Rows(0)("Tel2"), ""), "")
            Datos.Celular = (Tbl.Rows(0)("NumCelular"))
            Datos.Cliente_CupoCredito = (Tbl.Rows(0)("VRCupoCredCli"))
            Datos.Cliente_DiasPlazo = (Tbl.Rows(0)("DiasPago"))
            Datos.Cliente_VendedorAsignado = (Tbl.Rows(0)("vendasg"))
            Datos.Cliente_CobradorAsignado = (Tbl.Rows(0)("CobraAsig"))
            Datos.NoFacturarIVA = AsignarCampoNeT(Tbl.Rows(0)("NoFacIva"))
            Datos.Proveedor_CupoCredito = (Tbl.Rows(0)("VRCupoCredPro"))
            Datos.Proveedor_DiasPlazo = (Tbl.Rows(0)("DiasPagoProv"))
            Datos.Profesion = (Tbl.Rows(0)("Profesion"))
            If Tbl.Rows(0)("ClasificacionIva") = 0 Then
                Datos.ClasificacionIva = ClasificacionesDelIva.Entidad_Estatal
            ElseIf Tbl.Rows(0)("ClasificacionIva") = 1 Then
                Datos.ClasificacionIva = ClasificacionesDelIva.Gran_Contribuyente
            ElseIf Tbl.Rows(0)("ClasificacionIva") = 2 Then
                Datos.ClasificacionIva = ClasificacionesDelIva.Regimen_Comun
            ElseIf Tbl.Rows(0)("ClasificacionIva") = 3 Then
                Datos.ClasificacionIva = ClasificacionesDelIva.Regimen_Simplificado
            Else
                Datos.ClasificacionIva = ClasificacionesDelIva.Otras_Personas
            End If

            Datos.ResponsabledeIva = AsignarCampoNeT(Tbl.Rows(0)("ResponsableIva"))
            Datos.RetieneRenta = AsignarCampoNeT(Tbl.Rows(0)("RetieneRenta"))
            Datos.RetieneICA = AsignarCampoNeT(Tbl.Rows(0)("RetieneICA"))
            Datos.RetieneIVA = AsignarCampoNeT(Tbl.Rows(0)("RetieneIVA"))
            Datos.AutoRetieneRenta = AsignarCampoNeT(Tbl.Rows(0)("AutoRetFte"))
            Datos.AutoRetieneICA = AsignarCampoNeT(Tbl.Rows(0)("autoRetICA"))
            Datos.EsCliente = AsignarCampoNeT(Tbl.Rows(0)("cliente"))
            Datos.EsProveedor = AsignarCampoNeT(Tbl.Rows(0)("proveedor"))
            Datos.EsEmpleado = AsignarCampoNeT(Tbl.Rows(0)("empleado"))
            Datos.EsSocio = AsignarCampoNeT(Tbl.Rows(0)("Socio"))
            ReDim Datos.Establecimientos(0)
            CargaEstablecimientos = True
            If CargaEstablecimientos Then

                RsC = SMT_AbrirRecordSet(SMTConexMod, "Select * From G_ClientesEstab Where Cliente= " & Datos.Identificacion)
                If RsC.Rows.Count > 0 Then
                    ReDim Datos.Establecimientos(0 To RsC.Rows.Count)
                    X = 0
                    Do Until X = RsC.Rows.Count

                        Datos.Establecimientos(X).CodEstablecimiento = AsignarCampoNeT(RsC.Rows(X)("CodigoEst"))
                        Datos.Establecimientos(X).Nombre = (RsC.Rows(X)("Nombre").ToString)
                        Datos.Establecimientos(X).Direccion = (RsC.Rows(X)("Direccion").ToString)
                        Datos.Establecimientos(X).Ciudad = (RsC.Rows(X)("Ciudad").ToString)
                        Datos.Establecimientos(X).Telefonos = (RsC.Rows(X)("Telefonos").ToString)
                        Datos.Establecimientos(X).Celular = (RsC.Rows(X)("Celular").ToString)
                        If RsC.Rows(X)("CodigoEst") = CodEstablecimiento Then
                            Datos.EstablecimientoSeleccionado.CodEstablecimiento = AsignarCampoNeT(RsC.Rows(X)("CodigoEst"))
                            Datos.EstablecimientoSeleccionado.Nombre = RsC.Rows(X)("Nombre").ToString
                            Datos.EstablecimientoSeleccionado.Direccion = (RsC.Rows(X)("Direccion").ToString)
                            Datos.EstablecimientoSeleccionado.Ciudad = (RsC.Rows(X)("Ciudad").ToString)
                            Datos.EstablecimientoSeleccionado.Telefonos = (RsC.Rows(X)("Telefonos").ToString)
                            Datos.EstablecimientoSeleccionado.Celular = (RsC.Rows(X)("Celular").ToString)
                            Datos.NombreEstablecimiento = RsC.Rows(X)("Nombre").ToString
                            Datos.Nombre_Completo = Datos.Apellidos.ToString() & " " & Datos.Nombres.ToString & " - " & Datos.NombreEstablecimiento.ToString
                        End If
                        X = X + 1
                    Loop
                End If
                If Datos.NombreEstablecimiento = "" Then
                    Datos.NombreEstablecimiento = Datos.NombreComercial
                End If
                If Datos.EstablecimientoSeleccionado.CodEstablecimiento = 0 Then
                    'Datos.EstablecimientoSeleccionado.CodEstablecimiento = RsC.Rows(X)CodigoEst
                    Datos.EstablecimientoSeleccionado.Nombre = Datos.NombreComercial
                    Datos.EstablecimientoSeleccionado.Direccion = Datos.Direccion
                    Datos.EstablecimientoSeleccionado.Ciudad = Datos.MunicipioUbicacion.Nombre
                    Datos.EstablecimientoSeleccionado.Telefonos = Datos.Telefonos
                    Datos.EstablecimientoSeleccionado.Celular = Datos.Celular
                    Datos.NombreEstablecimiento = Datos.NombreComercial
                    Datos.Nombre_Completo = Datos.Apellidos & " " & Datos.Nombres & " - " & Datos.NombreEstablecimiento
                End If
                RsC = Nothing
            End If
            For X = 0 To 4
                Limpiar_Datos_Concepto_Retencion(Datos.RetencionesAplica(X).ConceptoRetencionProductos)
                Limpiar_Datos_Concepto_Retencion(Datos.RetencionesAplica(X).ConceptoRetencionServicios)
            Next
            If CargaConfiguracionRetenciones Then
                'RsC.Open("Select * From G_ClientesRET Where Tercero= " & Datos.Identificacion, ControlConexion.ConexionModulo, adOpenForwardOnly, adLockReadOnly)
                RsC = SMT_AbrirRecordSet(SMTConexMod, "Select * From G_ClientesRET Where Tercero= " & Datos.Identificacion)
                If RsC.Rows.Count > 0 Then
                    For Each Fila As DataRow In RsC.Rows
                        If Fila("Telefonos") <= 3 And Fila("TipoImpuesto") >= 0 Then
                            ExisteConceptoRetencion(Fila("ConceptoProductos"), Datos.RetencionesAplica(Fila("TipoImpuesto")).ConceptoRetencionProductos)
                            ExisteConceptoRetencion(Fila("ConceptoServicios"), Datos.RetencionesAplica(Fila("TipoImpuesto")).ConceptoRetencionServicios)
                        End If
                    Next Fila
                End If
                RsC.Dispose()
            End If
        Else
            If ModificaDatosRef Then
                Datos.Identificacion = 0
                Datos.Nombre_Completo = ""
                Datos.Foto = Nothing
                Datos.TipoPersona = ""
                Datos.DV = ""
                Datos.IdCliente = 0
                Datos.TipoId = 0
                Datos.TipoId = ""
                Datos.Direccion = ""
                Datos.Email = ""
                Datos.PaginaWeb = ""
                Limpiar_Datos_Municipio(Datos.MunicipioUbicacion)
                Datos.Barrio = ""
                Datos.Telefonos = ""
                Datos.Celular = ""
                Datos.Cliente_CupoCredito = 0
                Datos.Cliente_DiasPlazo = 0
                Datos.Proveedor_CupoCredito = 0
                Datos.Proveedor_DiasPlazo = 0
                Datos.ClasificacionIva = ClasificacionesDelIva.Otras_Personas
                Datos.ResponsabledeIva = False
                Datos.RetieneRenta = False
                Datos.RetieneICA = False
                Datos.RetieneIVA = False
                Datos.AutoRetieneRenta = False
                Datos.AutoRetieneICA = False
                Datos.EsCliente = False
                Datos.EsProveedor = False
                Datos.EsEmpleado = False
                Datos.EsSocio = False
                For X = 0 To 4
                    Limpiar_Datos_Concepto_Retencion(Datos.RetencionesAplica(X).ConceptoRetencionProductos)
                    Limpiar_Datos_Concepto_Retencion(Datos.RetencionesAplica(X).ConceptoRetencionServicios)
                Next

                ReDim Datos.Establecimientos(0)
            End If
        End If
        Tbl.Dispose()
        Tbl = Nothing

Exit_NomTercero:
        Exit Function
Err_NomTercero:
        MensajedeError()
        Resume Exit_NomTercero
    End Function
    Public Sub Leer_Datos_Municipio_En_Bd(CodigoMunicipio As String, ByRef VMunicipio As DatosMunicipios)
        Dim TB As New DataTable, SQL As String
        If CodigoMunicipio = "" Then
            Limpiar_Datos_Municipio(VMunicipio)
            Exit Sub
        End If
        SQL = "Select G_Pais.*,G_Departamento.*,G_Municipio.* FROM G_Pais " & _
                 "INNER JOIN (G_Departamento INNER JOIN G_Municipio ON G_Departamento.CodDpto = G_Municipio.Departamento) " & _
                 "ON G_Pais.CodPais = G_Departamento.Pais WHERE ((G_Municipio.IdMunicipio)='" & CodigoMunicipio & "')"
        TB = SMT_AbrirRecordSet(SMTConexMod, SQL)

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
    Public Function ExisteConceptoRetencion(CodConcepto As Integer, ByRef Datos As DatosConceptosRetención) As Boolean
        On Error GoTo Err_ExisteConceptoRetencion
        Dim TxtSQL As String, Tbl As New DataTable, Tbl2 As New DataTable
        TxtSQL = "Select * From CT_RetConceptos where CodConcepto = " & CodConcepto
        Tbl = SMT_AbrirRecordSet(SMTConex, TxtSQL)
        If Tbl.Rows.Count = 1 Then
            ExisteConceptoRetencion = True
            Datos.CodConcepto = CodConcepto
            Datos.SecConcepto = Tbl.Rows(0)("SecConcepto")
            Datos.NomConcepto = Tbl.Rows(0)("NomConcepto")
            Datos.TipoRet = Tbl.Rows(0)("TipoR")
            Datos.Redondea = Tbl.Rows(0)("Redondea")
            Datos.UnidadRedondeo = IIf(IsDBNull(Tbl.Rows(0)("UnidadRedondeo")), 0, Tbl.Rows(0)("UnidadRedondeo"))
            Datos.Estado = Tbl.Rows(0)("EstadoConcepto")
            Datos.Porcentaje = Tbl.Rows(0)("Porcentaje")

            Tbl2 = SMT_AbrirRecordSet(SMTConexMod, "Select * from CT_RetTipos Where CodigoTR=" & Datos.TipoRet)
            If Tbl2.Rows.Count = 1 Then
                Datos.TipoRetencion.Codigo = (Tbl2.Rows(0)("CodigoTR"))
                Datos.TipoRetencion.Nombre = (Tbl2.Rows(0)("NomTR"))
                Datos.TipoRetencion.TipoImpuestoRetiene = (Tbl2.Rows(0)("TipoImpuesto"))
            End If
        Else
            ExisteConceptoRetencion = False
            Limpiar_Datos_Concepto_Retencion(Datos)
        End If
        Tbl.Dispose()
        Tbl = Nothing
Exit_ExisteConceptoRetencion:
        Exit Function
Err_ExisteConceptoRetencion:
        MensajedeError()
        Resume Exit_ExisteConceptoRetencion
    End Function
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
    Public Function Establecer_Comprobante(ByRef ComprobanteContable As DatosComprobante, TipoComprobante As TiposdeDocumentos) As Boolean
        On Error GoTo ControlError
        Dim Jtipo As String = ""
        Dim JOfi As Byte = VgOficina
        Dim JId = CType(0, Byte)
        Establecer_Comprobante = False
        CargarComprobantes(Jtipo, JId, JOfi, False, TipoComprobante, "V", False)
        If Jtipo = "" And JId = 0 Then
            Exit Function
        End If
        LeerDatosComprobante(Jtipo, JId, ComprobanteContable)
        If ComprobanteContable.Descripcion <> "" And ComprobanteContable.Seccomp <> 0 Then
            Establecer_Comprobante = True
        Else
            Establecer_Comprobante = False
        End If
        Exit Function
ControlError:
        MensajedeError()
    End Function
    Public Sub CargarComprobantes(ByRef Tipo As String, ByRef IdComp As Byte, Oficina As Integer, _
                                  ByRef Todas_Las_Oficinas As Boolean, Optional NFormato As TiposdeDocumentos = Nothing, _
                                  Optional Estado As String = "", Optional ConsultaTodos As Boolean = False)
        On Error GoTo ControlError
        Dim Fquery As String = ""
        Dim Frm As New FrmBuscaComp

        If (NFormato) <> 0 Then
            Frm.FormatoAsignado = NFormato
        End If
        Frm.TipoComprobante = Tipo
        Frm.Oficina = Oficina
        Frm.Estado_Mostrar = Estado
        Frm.Todas_Las_Oficinas = Todas_Las_Oficinas
        Frm.Cargar_Comprobantes()
        If Frm.Total_Registros_Consultados > 0 Then
            Frm.ShowDialog()

            If Not Frm.Cancelo Then
                On Error Resume Next
                Tipo = Frm.TipoSeleccionado
                IdComp = Frm.IdComp_Seleccionado
                Err.Clear()
                On Error Resume Next
                Err.Clear()
            Else
                Tipo = ""
                IdComp = 0
            End If
        Else
            If NFormato = ClFunciones.TiposdeDocumentos.ComprobantesdePago Then
                Fquery = "No hay comprobantes de egreso parametrizados disponibles"
            ElseIf NFormato = ClFunciones.TiposdeDocumentos.RecibosdeCaja Then
                Fquery = "No hay recibos de caja parametrizados disponibles"
            ElseIf NFormato = ClFunciones.TiposdeDocumentos.FacturasdeVenta Then
                Fquery = "No hay facturas de venta parametrizadas disponibles"
            ElseIf NFormato = ClFunciones.TiposdeDocumentos.RegistrodeCompras Then
                Fquery = "No hay registros de compras parametrizados"
            Else
                Fquery = "No hay documentos tipo=" & Tipo & " parametrizados y disponibles"
            End If
            MsgBox(Fquery, vbCritical)
        End If
        Exit Sub
ControlError:
        MensajedeError()

    End Sub
    Public Shared Sub GenerarError(Mensaje As String, Optional Ubicacion As String = "")
        On Error Resume Next
        If Trim(Ubicacion) = "" Then
            Ubicacion = "Mensaje de SAMIT SQL"
        End If
        On Error GoTo 0
        'MsgBox Mensaje, vbExclamation, Ubicacion
        Err.Raise(10000, Ubicacion, Mensaje)

    End Sub
    Public Function ConsecutivoServidor(Tipo As String, IdComp As Byte) As Long
        On Error GoTo ControlError
        Dim Tbl As New DataTable, TxtSQL As String, Consecutivo As Long, R As Long
INICIA:
        TxtSQL = "Select Numsiguiente, NumAutomatica From CT_Comprobantes " & _
                 "Where TipoComp='" & Tipo & "' And IdComp=" & IdComp
        Tbl = SMT_AbrirRecordSet(SMTConexMod, TxtSQL)

        If Tbl.Rows.Count > 0 Then Consecutivo = Tbl(0)("NumSiguiente")
VERIFICA:
        Tbl.Dispose()

        TxtSQL = "SELECT COUNT(Doc_Secuencial) as Total From Ct_Documentos Where " & _
                 "Doc_TipoComp='" & Tipo & "' And Doc_IdComp=" & IdComp & _
                 " and Doc_NumDocumento =" & Consecutivo
        Tbl = SMT_AbrirRecordSet(SMTConexMod, TxtSQL)

        If Tbl.Rows.Count > 0 Then
            TxtSQL = "Update Ct_Comprobantes Set NumSiguiente =NumSiguiente + 1 " & _
                               "Where TipoComp='" & Tipo & "' And IdComp=" & IdComp
            SMT_EjcutarComandoSql(SMTConexMod, TxtSQL, R)
            GoTo INICIA
        End If
TERMINA:
        ConsecutivoServidor = Consecutivo
        Tbl.Dispose()
        Exit Function
ControlError:
        MensajedeError()
    End Function
    ''' <summary>
    ''' Devuelve el Valor de la Columna del Datarow enviado en el parametro Fila,
    ''' pero si es nulo Devuele un valor por defecto o un Valor Nothing,
    ''' Dependiendo del tipo del Campo de la Columna
    ''' </summary>
    ''' <param name="Fila">Es el DataRow que contiene el campo que vamos asignar a alguna variable u objeto</param>
    ''' <param name="NombreCampo">Es el Nombre del campo del DataRow el cual vamos asignar</param>
    ''' <returns>Retorna un Valor del Campo si no es NULO, per sies NULO devuelve un Valor por Defecto de acuerdo al Tipo del Campo</returns>
    ''' <remarks>Si es nulo Valida el Tipo del Campo de la Columna, 
    ''' Para Numerico Devuelve (0), Para Fecha Devuelve la de Hoy
    ''' Para Boolean devuelve False, Para un String devuelve (No Contiene Nada)
    ''' </remarks>
    Public Shared Function AsignarCampoRow(Fila As DataRow, NombreCampo As String) As Object
        On Error Resume Next
        If IsDBNull(Fila(NombreCampo)) Then
            If IsNumeric(Fila.Table.Columns("Login").DataType) Then
                AsignarCampoRow = 0
            ElseIf IsDate(Fila.Table.Columns("Login").DataType) Then
                AsignarCampoRow = Date.Now
            ElseIf (Fila.Table.Columns("Login").DataType) = GetType(System.Boolean) Then
                AsignarCampoRow = False
            ElseIf (Fila.Table.Columns("Login").DataType) = GetType(System.String) Then
                AsignarCampoRow = "No Contiene Nada"
            Else
                AsignarCampoRow = Nothing
            End If
            Exit Function
        End If
        AsignarCampoRow = Fila(NombreCampo)
    End Function
    Public Shared Function AsignarCampoNeT(CampoTabla As Object) As Object
        On Error GoTo ControlError
        If IsDBNull(CampoTabla) Then
            If IsNumeric(CampoTabla) Then
                AsignarCampoNeT = 0
            ElseIf IsDate(CampoTabla) Then
                AsignarCampoNeT = Date.Today
            ElseIf (CampoTabla.GetType) = GetType(System.Boolean) Then
                AsignarCampoNeT = False
            ElseIf (CampoTabla.GetType) = GetType(System.String) Then
                AsignarCampoNeT = "No Contiene Nada"
            Else
                AsignarCampoNeT = Nothing
            End If
        Else
            AsignarCampoNeT = CampoTabla
        End If
        Exit Function
ControlError:
        MensajedeError()
    End Function
    ''' <summary>
    ''' Permite Detener al Ejecucion Cierta Cantidad de Segundos, (es el Mismo Sleep del Vb6)
    ''' </summary>
    ''' <param name="Sec"></param>
    ''' <remarks></remarks>
    Public Sub SMT_Dormir(Segundos As Long)
        Thread.Sleep(Segundos)
    End Sub
End Class
