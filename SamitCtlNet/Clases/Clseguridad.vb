Option Explicit On
Imports Microsoft.Win32
Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports System.Drawing
Imports SamitCtlNet.SamitCtlNet
Imports SamitCtlNet.SamitCtlNet.ClSmtImagenes
Imports DevExpress.XtraBars.Ribbon
Imports System.Net.Mime.MediaTypeNames.Application
Public Class Clseguridad
    Public Shared CodError As Integer
    Dim Reloj As New Timer
    Dim IniciosinMostrar As Boolean

    Private Enum TipoBD
        Jet = 1
        MSDE = 2
        SQLSERVER = 3
        MySQL = 4
    End Enum
    Public Shared NombreModulo As String
    Public ExisteEmpresa As Boolean
    Public ExisteOficina As Boolean
    Public PresionoAceptar As Boolean
    Public Intentos As Integer
    Public SeleccionoRol As Boolean
    Public SeleccionoCatalogo As Boolean
    Public GbArcIni As String
    Public Shared Texto_del_Error As String
    Private RegistroUsuario As Boolean


    Public Structure DatosTransacciones
        Public Codigo As Long
        Public Descripcion As String
        Public Comentario As String
        Public Referencia As String
        Public NombreMenu1 As String
        Public NombreMenu2 As String
        Public NombreMenu3 As String
    End Structure
    Public Enum AccionMenu
        Habilitar_Menu = 0
        Deshabilitar_Menu = 1
        Esconder_menu = 2
        Mostrar_Menu = 3
    End Enum
    Public Enum TipoPersona
        PersonaNatural = 1
        PersonaJuridica = 2
    End Enum

    Public Enum Accion_Sql
        Seleccionar_Registro = 0
        Insertar_Registros = 1
        Modificar_Registros = 2
        Eliminar_Registros = 3
    End Enum
    Public Structure DatoSignatarios
        Public Nombre As String
        Public Identificacion As Double
        Public TarjetaProfesional As String
        Public Lugar_Expedicion_Identificacion As String
        Public Cargo As String
    End Structure
    Public Structure DatoOficina
        Dim NumOficina As Integer
        Dim NombreOficina As String
        Dim Estado As String
        Dim Ciudad As String
        Dim Direccion As String
        Dim Telefono1 As String
        Dim Telefono2 As String
        Dim Fax As String
        Dim NombreResponsable As String
        Dim IdResponsable As Double
        Dim FechaApertura As Date
        Dim UsaLogoEmpresa As Boolean
        Dim LogoOficina As Image
        Dim NombreComercial As String
        Dim DetalleComercial As String
    End Structure

    Public Structure CuentasEmpresa
        Dim CuentaUtilidad As String
        Dim CuentaPerdida As String
        Dim CuentaTrasladoInventario As String
        Dim CuentaTrasladoEfectivo As String
        Dim CuentaTrasladoOtrosActivos As String
        Dim CuentaTrasladoPasivos As String
        Dim CuentaTrasladoPatrimonio As String
    End Structure
    Public Structure DatosEmpresa
        Dim NumEmpresa As Integer
        Dim NombreEmpresa As String
        Dim Sigla As String
        Dim ExisteEmpresa As Boolean
        Dim Estado As String
        Dim Nit As Double
        Dim OficinaIngreso As DatoOficina
        Dim TipoId As String
        Dim DV As Integer
        Dim FechaInicioOperaciones As Date
        Dim AñoUltimaOperacion As Integer
        Dim FechaCreacion As Date
        Dim FechaBloqueo As Date
        Dim FechadeVentas As Date
        Dim FechaBloqueoInventario As Date
        Dim FechaBloqueoVehiculos As Date
        Dim PaginaWeb As String
        Dim CorreoElectronico As String
        Dim Direccion As String
        Dim Ciudad As String
        Dim Telefono1 As String
        Dim Telefono2 As String
        Dim Telefono3 As String
        Dim NumTelefonos As String
        Dim Fax As String
        Dim NombreMoneda As String
        Dim NombreCentavos As String
        Dim MuestraCentavosenLetras As Boolean
        Dim Texto_de_ComplementoMonedas As String
        Dim Eslogan As String
        Dim Formato_Moneda As String
        Dim Gerente As DatoSignatarios
        Dim Contador As DatoSignatarios
        Dim TieneRevisorFiscal As Boolean
        Dim RevisorFiscal As DatoSignatarios
        Dim Numero_de_Escritura_Constitucion As String
        Dim Fecha_Escritura_Constitucion As String
        Dim Numero_de_Registro As String
        Dim Logo As Image
        Dim Plan_Asignado As Integer
        Dim Plan_Asignado_Nombre As String
        Dim RegimenIva As String
        Dim NumerodeOficinas As Integer
        Dim TipodePersona As TipoPersona
        Dim EsGranContribuyente As Boolean
        Dim EsAgenteRetenedor As Boolean
        Dim EsAutorreTenedor As Boolean
        Dim Actividad_Economica As String
        Dim ClasificacionIva As Integer
        Dim ResponsableIva As Boolean
        Dim RetieneRenta As Boolean
        Dim RetieneIVA As Boolean
        Dim RetieneICA As Boolean
        Dim AutoRetRenta As Boolean
        Dim autoRetICA As Boolean
        Dim PorcentajeCompresionFotos As Long
        Dim MarcaReteFuente() As Boolean
        Dim MarcaReteIVA() As Boolean
        Dim MarcaReteICA() As Boolean
        Dim Cuentas As CuentasEmpresa
        Dim FuentePredeterminada As String
        Dim DatosDianFE As DatosDIANFE
    End Structure
    Public Structure DatosDIANFE
        Dim Habilitada As Boolean
        Dim FehaHabilita As Date
        Dim UrlDIAN As String
        Dim SoftwareID As String
        Dim SoftwareIdSha384 As String
        Dim PassWordAmbienteSha256 As String
        Dim CertificadoDigitalRuta As String
        Dim PasswordCetificadoDigital As String
        Dim PlatillaFE As String
        Dim PlatillaNC As String
    End Structure
    Public Shared InicioConexion_Control As Boolean
    Public Shared InicioConexion_Empresa As Boolean
    Public GPaswdBD_Seg As String
    Public GRutaBD_Seg As String
    Public GPaswdBD_Mod As String
    Public GRutaBD_Mod As String
    Public GRutaBD_Aux As String
    'Public BarraEstado As Panel

    Public ReadOnly Property HayConexionConServidor
        Get
            HayConexionConServidor = HayConexionConSRV
        End Get

    End Property
    Public Property NumModulo
        Get
            NumModulo = NumerodeModulo

        End Get
        Set(value)
            NumerodeModulo = value
        End Set
    End Property
    Public Property FechadeTrabajo
        Get
            FechadeTrabajo = FechaW
        End Get
        Set(value)
            FechaW = value
        End Set
    End Property

    Public Property FechadelServidor As Date
        Get
            FechadelServidor = Traer_FechaDelServidor()
        End Get

        Set(value As Date)

        End Set
    End Property
    Public ReadOnly Property LogoImprime As Image
        Get
            If DatosEmp.OficinaIngreso.UsaLogoEmpresa = True Then
                LogoImprime = DatosEmp.Logo
            Else
                If IsNothing(DatosEmp.OficinaIngreso.LogoOficina) Then
                    LogoImprime = DatosEmp.Logo
                Else
                    LogoImprime = DatosEmp.OficinaIngreso.LogoOficina
                End If
            End If
        End Get

    End Property
    Public Property DatosDeLaEmpresa As DatosEmpresa
        Get
            DatosDeLaEmpresa = DatosEmp
        End Get
        Set(value As DatosEmpresa)

        End Set
    End Property

    Public Shared Function Traer_FechaDelServidor() As Date
        On Error GoTo Err_Traer_FechaDelServidor
        Dim Tbl As DataTable, SQL As String
        SQL = "select 'FechaSys' = getdate()"
        Tbl = SMT_AbrirTabla(SMTConex, SQL)
        Traer_FechaDelServidor = Tbl(0)("Fechasys")
        FechaSys = Traer_FechaDelServidor
Err_Traer_FechaDelServidor:
    End Function
    Public Sub IniciaValidarConexion()
        Reloj.Interval = 10000
        AddHandler Reloj.Tick, AddressOf Reloj_tick
        Reloj.Start()
    End Sub

    Public Shared Sub Traer_Datos_Empresa()
        'On Error Resume Next
        Dim Tabla As DataTable, Tbl As DataRow, X As Integer, TxtSql As String, TblDian As DataTable

        If SMTConex.State = ConnectionState.Open Then
            TxtSql = "Select * from Empresas Where NumEmpresa = " & RegistroSamit.Empresa_Ingreso

            'Tbl.Open("Select * from Empresas Where NumEmpresa = " & empresa, SMTConex, adOpenForwardOnly, adLockReadOnly)
            Tabla = SMT_AbrirRecordSet(SMTConex, TxtSql)
            If ExisteTabla(SMTConex, "Empresa_FE") Then
                TxtSql = "Select * from Empresa_FE Where NumEmpresa = " & RegistroSamit.Empresa_Ingreso
                TblDian = SMT_AbrirRecordSet(SMTConex, TxtSql)
            End If
            ReDim DatosEmp.MarcaReteFuente(5)
            ReDim DatosEmp.MarcaReteICA(5)
            ReDim DatosEmp.MarcaReteIVA(5)
            For X = 1 To 5
                DatosEmp.MarcaReteFuente(X) = False
                DatosEmp.MarcaReteICA(X) = False
                DatosEmp.MarcaReteIVA(X) = False
            Next X

            Tbl = Tabla.Rows.Item(0)
            If Tabla.Rows.Count = 1 Then
                Tbl = Tabla(0)
                DatosEmp.ExisteEmpresa = True
                DatosEmp.NumEmpresa = Tbl("NumEmpresa")
                DatosEmp.NombreEmpresa = Tbl("NomEmpresa")
                DatosEmp.TipoId = IIf(Tbl("TipoId") Is DBNull.Value, "", Tbl("TipoId"))
                DatosEmp.Nit = Tbl("Nit")
                DatosEmp.DV = IIf(Tbl("DV") Is DBNull.Value, Calculo_Digito_Verificacion(Tbl("Nit")), Tbl("DV"))
                DatosEmp.Sigla = IIf(Tbl("Sigla") Is DBNull.Value, "", Tbl("Sigla"))
                DatosEmp.Eslogan = IIf(IsDBNull(Tbl("Eslogan")), "", Tbl("Eslogan"))
                DatosEmp.PaginaWeb = IIf(IsDBNull(Tbl("PaginaWeb")), "", Tbl("PaginaWeb"))
                DatosEmp.CorreoElectronico = IIf(IsDBNull(Tbl("Email")), "", Tbl("Email"))
                DatosEmp.Direccion = IIf(IsDBNull(Tbl("Direccion")), "", Tbl("Direccion"))
                DatosEmp.Ciudad = IIf(IsDBNull(Tbl("Ciudad")), "", Tbl("Ciudad"))
                DatosEmp.Telefono1 = IIf(IsDBNull(Tbl("Telefono1")), "", Tbl("Telefono1"))
                DatosEmp.Telefono2 = IIf(IsDBNull(Tbl("Telefono2")), "", Tbl("Telefono2"))
                DatosEmp.Telefono3 = IIf(IsDBNull(Tbl("Telefono3")), "", Tbl("Telefono3"))
                DatosEmp.Fax = IIf(IsDBNull(Tbl("NumFax")), "", Tbl("NumFax"))
                DatosEmp.NombreMoneda = IIf(IsDBNull(Tbl("NombreMoneda")), "PESOS", Tbl("NombreMoneda"))
                DatosEmp.NombreCentavos = IIf(IsDBNull(Tbl("NombreCentavos")), "Centavos", Tbl("NombreCentavos"))
                DatosEmp.MuestraCentavosenLetras = IIf(IsDBNull(Tbl("CentavosenLetras")), 0, Tbl("CentavosenLetras"))
                DatosEmp.Texto_de_ComplementoMonedas = IIf(IsDBNull(Tbl("ComplementoMoneda")), "MCTE", Tbl("ComplementoMoneda"))
                DatosEmp.Formato_Moneda = IIf(IsDBNull(Tbl("FormatoMoneda")), "", Tbl("FormatoMoneda"))
                DatosEmp.Gerente.Identificacion = IIf(IsDBNull(Tbl("IdGerente")), 0, Tbl("IdGerente"))
                DatosEmp.Gerente.Nombre = IIf(IsDBNull(Tbl("NomGerente")), "", Tbl("NomGerente"))
                DatosEmp.Gerente.Lugar_Expedicion_Identificacion = IIf(IsDBNull(Tbl("LugarExpGerente")), "", Tbl("LugarExpGerente"))
                DatosEmp.Gerente.Cargo = IIf(IsDBNull(Tbl("CargoGerente")), "", Tbl("CargoGerente"))
                DatosEmp.Contador.Identificacion = IIf(IsDBNull(Tbl("IdContador")), 0, Tbl("IdContador"))
                DatosEmp.Contador.Nombre = IIf(IsDBNull(Tbl("NomContador")), "", Tbl("NomContador"))
                DatosEmp.Contador.Lugar_Expedicion_Identificacion = IIf(IsDBNull(Tbl("LugarExpContador")), "", Tbl("LugarExpContador"))
                DatosEmp.Contador.TarjetaProfesional = IIf(IsDBNull(Tbl("TpContador")), "", Tbl("TpContador"))
                DatosEmp.Contador.Cargo = IIf(IsDBNull(Tbl("CargoContador")), "", Tbl("CargoContador"))
                DatosEmp.TieneRevisorFiscal = IIf(IsDBNull(Tbl("rf")), False, Tbl("rf"))
                DatosEmp.RevisorFiscal.Identificacion = IIf(IsDBNull(Tbl("IdRF")), 0, Tbl("IdRF"))
                DatosEmp.RevisorFiscal.Nombre = IIf(IsDBNull(Tbl("NomRF")), "", Tbl("NomRF"))
                DatosEmp.RevisorFiscal.Lugar_Expedicion_Identificacion = IIf(IsDBNull(Tbl("LugarExpRf")), "", Tbl("LugarExpRf"))
                DatosEmp.RevisorFiscal.TarjetaProfesional = IIf(IsDBNull(Tbl("TpRF")), "", Tbl("TpRF"))
                DatosEmp.RevisorFiscal.Cargo = IIf(IsDBNull(Tbl("CargoRevisor")), "", Tbl("CargoRevisor"))

                DatosEmp.Numero_de_Escritura_Constitucion = IIf(IsDBNull(Tbl("NumEscritura")), "", Tbl("NumEscritura"))
                If Not IsDBNull(Tbl("FechaEscritura")) Then DatosEmp.Fecha_Escritura_Constitucion = Tbl("FechaEscritura")
                DatosEmp.Numero_de_Registro = IIf(IsDBNull(Tbl("NumRegistro")), "", Tbl("NumRegistro"))
                If Not IsDBNull(Tbl("PlanAsignado")) Then
                    DatosEmp.Plan_Asignado = Tbl("PlanAsignado")
                    DatosEmp.Plan_Asignado_Nombre = Nombre_Plan_Contable(Tbl("PlanAsignado"))
                Else
                    DatosEmp.Plan_Asignado = 0
                    DatosEmp.Plan_Asignado_Nombre = ""
                End If

                'DatosEmp.FechaBloqueo = IIf(IsdbNull(Tbl("FechaBloqueo), DatosEmp.Fecha_Escritura_Constitucion, Tbl("FechaBloqueo)
                If IsDBNull(Tbl("FechaBloqueo")) Then
                    MsgBox("Debe Ingresar la Fecha de Bloqueo del Sistema", vbCritical)
                    If Trim(DatosEmp.Fecha_Escritura_Constitucion) = "" Then
                        MsgBox("Debe Ingresar la Fecha de Constitucion de la Empresa", vbCritical)
                    Else
                        DatosEmp.FechaBloqueo = DatosEmp.Fecha_Escritura_Constitucion
                    End If
                End If
                DatosEmp.FechaBloqueoInventario = IIf(IsDBNull(Tbl("FechaBloqInv")), DatosEmp.FechaBloqueo, Tbl("FechaBloqInv"))
                DatosEmp.FechaBloqueoVehiculos = IIf(IsDBNull(Tbl("FechaBloqVeh")), DatosEmp.Fecha_Escritura_Constitucion, Tbl("FechaBloqVeh"))
                DatosEmp.FechadeVentas = IIf(IsDBNull(Tbl("FechaVentas")), 0, Tbl("FechaVentas"))
                DatosEmp.FuentePredeterminada = IIf(IsDBNull(Tbl("FuenteDefault")), "Arial", Tbl("FuenteDefault"))
                'Parametros de Impuestos
                DatosEmp.EsGranContribuyente = False
                DatosEmp.ClasificacionIva = IIf(IsDBNull(Tbl("ClasificacionIva")), 4, IIf(Tbl("ClasificacionIva") > 4, 4, Tbl("ClasificacionIva")))
                If DatosEmp.ClasificacionIva = 0 Then
                    DatosEmp.RegimenIva = "Entidad Estatal"
                ElseIf DatosEmp.ClasificacionIva = 1 Then
                    DatosEmp.RegimenIva = "Gran Contribuyente"
                    DatosEmp.EsGranContribuyente = True
                ElseIf DatosEmp.ClasificacionIva = 2 Then
                    DatosEmp.RegimenIva = "Régimen Común"
                ElseIf DatosEmp.ClasificacionIva = 3 Then
                    DatosEmp.RegimenIva = "Régimen Simplificado"
                Else
                    DatosEmp.RegimenIva = "Otras Personas"
                    DatosEmp.ClasificacionIva = 4
                End If

                DatosEmp.TipodePersona = IIf(UCase(Tbl("TipoPersona")) = "N", 1, 2)
                DatosEmp.Actividad_Economica = IIf(IsDBNull(Tbl("ActividadEco")), "", (Tbl("ActividadEco")))
                DatosEmp.ResponsableIva = IIf(IsDBNull(Tbl("ResponsableIva")), False, (Tbl("ResponsableIva")))
                DatosEmp.RetieneRenta = IIf(IsDBNull(Tbl("RetieneRenta")), False, (Tbl("RetieneRenta")))
                DatosEmp.EsAgenteRetenedor = DatosEmp.RetieneRenta
                DatosEmp.RetieneICA = IIf(IsDBNull(Tbl("RetieneICA")), False, (Tbl("RetieneICA")))
                DatosEmp.RetieneIVA = IIf(IsDBNull(Tbl("RetieneIVA")), False, (Tbl("RetieneIVA")))
                DatosEmp.AutoRetRenta = IIf(IsDBNull(Tbl("AutoRetFte")), False, (Tbl("AutoRetFte")))
                DatosEmp.EsAutorreTenedor = DatosEmp.AutoRetRenta
                DatosEmp.autoRetICA = IIf(IsDBNull(Tbl("autoRetICA")), False, (Tbl("autoRetICA")))

                DatosEmp.MarcaReteFuente(1) = Convert_BIT(Mid(IIf(IsDBNull(Tbl("MarcaReteFTE")), "00000", Tbl("MarcaReteFTE")), 1, 1))
                DatosEmp.MarcaReteFuente(2) = Convert_BIT(Mid(IIf(IsDBNull(Tbl("MarcaReteFTE")), "00000", Tbl("MarcaReteFTE")), 2, 1))
                DatosEmp.MarcaReteFuente(3) = Convert_BIT(Mid(IIf(IsDBNull(Tbl("MarcaReteFTE")), "00000", Tbl("MarcaReteFTE")), 3, 1))
                DatosEmp.MarcaReteFuente(4) = Convert_BIT(Mid(IIf(IsDBNull(Tbl("MarcaReteFTE")), "00000", Tbl("MarcaReteFTE")), 4, 1))
                DatosEmp.MarcaReteFuente(5) = Convert_BIT(Mid(IIf(IsDBNull(Tbl("MarcaReteFTE")), "00000", Tbl("MarcaReteFTE")), 5, 1))

                DatosEmp.MarcaReteICA(1) = Convert_BIT(Mid(IIf(IsDBNull(Tbl("MarcaReteICA")), "00000", Tbl("MarcaReteICA")), 1, 1))
                DatosEmp.MarcaReteICA(2) = Convert_BIT(Mid(IIf(IsDBNull(Tbl("MarcaReteICA")), "00000", Tbl("MarcaReteICA")), 2, 1))
                DatosEmp.MarcaReteICA(3) = Convert_BIT(Mid(IIf(IsDBNull(Tbl("MarcaReteICA")), "00000", Tbl("MarcaReteICA")), 3, 1))
                DatosEmp.MarcaReteICA(4) = Convert_BIT(Mid(IIf(IsDBNull(Tbl("MarcaReteICA")), "00000", Tbl("MarcaReteICA")), 4, 1))
                DatosEmp.MarcaReteICA(5) = Convert_BIT(Mid(IIf(IsDBNull(Tbl("MarcaReteICA")), "00000", Tbl("MarcaReteICA")), 5, 1))

                DatosEmp.MarcaReteIVA(1) = Convert_BIT(Mid(IIf(IsDBNull(Tbl("MarcaReteIVA")), "00000", Tbl("MarcaReteIVA")), 1, 1))
                DatosEmp.MarcaReteIVA(2) = Convert_BIT(Mid(IIf(IsDBNull(Tbl("MarcaReteIVA")), "00000", Tbl("MarcaReteIVA")), 2, 1))
                DatosEmp.MarcaReteIVA(3) = Convert_BIT(Mid(IIf(IsDBNull(Tbl("MarcaReteIVA")), "00000", Tbl("MarcaReteIVA")), 3, 1))
                DatosEmp.MarcaReteIVA(4) = Convert_BIT(Mid(IIf(IsDBNull(Tbl("MarcaReteIVA")), "00000", Tbl("MarcaReteIVA")), 4, 1))
                DatosEmp.MarcaReteIVA(5) = Convert_BIT(Mid(IIf(IsDBNull(Tbl("MarcaReteIVA")), "00000", Tbl("MarcaReteIVA")), 5, 1))


                DatosEmp.Cuentas.CuentaPerdida = AsignarCampo(Tbl, "CtaPerdida")
                DatosEmp.Cuentas.CuentaUtilidad = AsignarCampo(Tbl, ("CtaUtilidad"))


                If Not IsDBNull(Tbl("Pcompresion")) Then
                    If Tbl("Pcompresion") > 100 Then
                        DatosEmp.PorcentajeCompresionFotos = 90
                    ElseIf Tbl("Pcompresion") <= 10 Then
                        DatosEmp.PorcentajeCompresionFotos = 10
                    Else
                        DatosEmp.PorcentajeCompresionFotos = Tbl("Pcompresion")
                    End If
                Else
                    DatosEmp.PorcentajeCompresionFotos = 50
                End If

                LeerFechasBloqueo()

                If Not IsDBNull(Tbl("Logo")) Then DatosEmp.Logo = SMT_Conv_Byte_A_Image(Tbl("Logo"))


                Tabla.Clear()
                TxtSql = "Select * From Oficinas Where NumEmpresa=" & RegistroSamit.Empresa_Ingreso & " and NumOficina=" & RegistroSamit.Oficina_Ingreso
                Tabla = SMT_AbrirRecordSet(SMTConex, TxtSql)

                If Tabla.Rows.Count > 0 Then
                    Tbl = Tabla(0)
                    DatosEmp.OficinaIngreso.NumOficina = RegistroSamit.Oficina_Ingreso
                    DatosEmp.OficinaIngreso.NombreOficina = IIf(IsDBNull(Tbl("NomOficina")), "", Tbl("NomOficina"))
                    DatosEmp.OficinaIngreso.Estado = IIf(IsDBNull(Tbl("Estado")), "", Tbl("Estado"))
                    DatosEmp.OficinaIngreso.Ciudad = IIf(IsDBNull(Tbl("Ciudad")), "", Tbl("Ciudad"))
                    DatosEmp.OficinaIngreso.Direccion = IIf(IsDBNull(Tbl("Direccion")), "", Tbl("Direccion"))
                    DatosEmp.OficinaIngreso.Telefono1 = IIf(IsDBNull(Tbl("Telefono1")), "", Tbl("Telefono1"))
                    DatosEmp.OficinaIngreso.Telefono2 = IIf(IsDBNull(Tbl("Telefono2")), "", Tbl("Telefono2"))
                    DatosEmp.OficinaIngreso.Fax = IIf(IsDBNull(Tbl("NumFax")), "", Tbl("NumFax"))
                    DatosEmp.OficinaIngreso.NombreResponsable = ""
                    DatosEmp.OficinaIngreso.IdResponsable = IIf(IsDBNull(Tbl("IdResponsable")), 0, Tbl("IdResponsable"))
                    DatosEmp.OficinaIngreso.FechaApertura = IIf(IsDBNull(Tbl("FechaApertura")), 0, Tbl("FechaApertura"))
                    DatosEmp.OficinaIngreso.UsaLogoEmpresa = IIf(IsDBNull(Tbl("UsaLogoEmpresa")), False, Tbl("UsaLogoEmpresa"))
                    If Not IsDBNull(Tbl("LogoOficina")) Then DatosEmp.OficinaIngreso.LogoOficina = SMT_Conv_Byte_A_Image(Tbl("LogoOficina"))
                    DatosEmp.OficinaIngreso.NombreComercial = IIf(IsDBNull(Tbl("NombreComercial")), False, Tbl("NombreComercial"))
                    DatosEmp.OficinaIngreso.DetalleComercial = IIf(IsDBNull(Tbl("DetalleComercial")), False, Tbl("DetalleComercial"))
                Else
                    DatosEmp.OficinaIngreso.NumOficina = RegistroSamit.Oficina_Ingreso
                    DatosEmp.OficinaIngreso.NombreOficina = ""
                    DatosEmp.OficinaIngreso.Estado = ""
                    DatosEmp.OficinaIngreso.Ciudad = ""
                    DatosEmp.OficinaIngreso.Direccion = ""
                    DatosEmp.OficinaIngreso.Telefono1 = ""
                    DatosEmp.OficinaIngreso.Telefono2 = ""
                    DatosEmp.OficinaIngreso.Fax = ""
                    DatosEmp.OficinaIngreso.NombreResponsable = ""
                    DatosEmp.OficinaIngreso.IdResponsable = 0
                    DatosEmp.OficinaIngreso.UsaLogoEmpresa = False
                    DatosEmp.OficinaIngreso.LogoOficina = Nothing
                    DatosEmp.OficinaIngreso.NombreComercial = ""
                End If
                If TblDian.Rows.Count = 1 Then
                    Dim Fila As DataRow = TblDian.Rows(0)
                    If Fila("Habilitada") Then
                        DatosEmp.DatosDianFE.Habilitada = True
                        DatosEmp.DatosDianFE.FehaHabilita = Fila("FechaHabilitacion")
                        DatosEmp.DatosDianFE.UrlDIAN = Fila("UrlDian")
                        DatosEmp.DatosDianFE.SoftwareID = Fila("SoftwareID")
                        DatosEmp.DatosDianFE.SoftwareIdSha384 = Fila("SoftwareIDSha384")
                        DatosEmp.DatosDianFE.PassWordAmbienteSha256 = Fila("PasswdAmbSha256")
                        DatosEmp.DatosDianFE.CertificadoDigitalRuta = Fila("CertificadoDigital")
                        DatosEmp.DatosDianFE.PasswordCetificadoDigital = Fila("PasswdCertificadoDigital")
                        DatosEmp.DatosDianFE.PlatillaFE = Fila("PlantillaFE")
                        DatosEmp.DatosDianFE.PlatillaNC = Fila("PlantillaNC")
                    Else
                        DatosEmp.DatosDianFE.Habilitada = False
                    End If
                End If


            Else
                DatosEmp.ExisteEmpresa = False
                DatosEmp.NumEmpresa = 0
                DatosEmp.NombreEmpresa = ""
                DatosEmp.TipoId = ""
                DatosEmp.Nit = 0
                DatosEmp.DV = 0
                DatosEmp.Sigla = ""
                DatosEmp.Eslogan = ""
                DatosEmp.RegimenIva = ""
                DatosEmp.PaginaWeb = ""
                DatosEmp.CorreoElectronico = ""
                DatosEmp.Direccion = ""
                DatosEmp.Ciudad = ""
                DatosEmp.Telefono1 = ""
                DatosEmp.Telefono2 = ""
                DatosEmp.Telefono3 = ""
                DatosEmp.Fax = ""
                DatosEmp.NombreMoneda = ""
                DatosEmp.NombreCentavos = ""
                DatosEmp.MuestraCentavosenLetras = ""
                DatosEmp.Texto_de_ComplementoMonedas = ""
                DatosEmp.Formato_Moneda = ""
                DatosEmp.Gerente.Identificacion = 0
                DatosEmp.Gerente.Nombre = ""
                DatosEmp.Gerente.Lugar_Expedicion_Identificacion = ""
                DatosEmp.Gerente.Cargo = ""
                DatosEmp.Contador.Identificacion = 0
                DatosEmp.Contador.Nombre = ""
                DatosEmp.Contador.Lugar_Expedicion_Identificacion = ""
                DatosEmp.Contador.TarjetaProfesional = ""
                DatosEmp.Contador.Cargo = ""
                DatosEmp.TieneRevisorFiscal = False
                DatosEmp.RevisorFiscal.Identificacion = 0
                DatosEmp.RevisorFiscal.Nombre = ""
                DatosEmp.RevisorFiscal.Lugar_Expedicion_Identificacion = ""
                DatosEmp.RevisorFiscal.TarjetaProfesional = ""
                DatosEmp.RevisorFiscal.Cargo = ""
                DatosEmp.Numero_de_Escritura_Constitucion = ""
                DatosEmp.Fecha_Escritura_Constitucion = Nothing
                DatosEmp.Numero_de_Registro = ""
                DatosEmp.Plan_Asignado = 0
                DatosEmp.Plan_Asignado_Nombre = ""
                DatosEmp.FechaBloqueo = Nothing
                DatosEmp.FechaBloqueoInventario = Nothing
                DatosEmp.FechaBloqueoVehiculos = Nothing
                DatosEmp.TipodePersona = TipoPersona.PersonaJuridica
                DatosEmp.EsGranContribuyente = False
                DatosEmp.EsAgenteRetenedor = False
                DatosEmp.EsAutorreTenedor = False
                DatosEmp.PorcentajeCompresionFotos = 50
                DatosEmp.ClasificacionIva = 4
                DatosEmp.RegimenIva = ""
                DatosEmp.Actividad_Economica = ""
                DatosEmp.ResponsableIva = False
                DatosEmp.RetieneRenta = False
                DatosEmp.EsAgenteRetenedor = False
                DatosEmp.RetieneICA = False
                DatosEmp.RetieneIVA = False
                DatosEmp.AutoRetRenta = False
                DatosEmp.EsAutorreTenedor = False
                DatosEmp.autoRetICA = False
                DatosEmp.Cuentas.CuentaPerdida = ""
                DatosEmp.Cuentas.CuentaTrasladoEfectivo = ""
                DatosEmp.Cuentas.CuentaTrasladoInventario = ""
                DatosEmp.Cuentas.CuentaTrasladoOtrosActivos = ""
                DatosEmp.Cuentas.CuentaTrasladoPasivos = ""
                DatosEmp.Cuentas.CuentaTrasladoPatrimonio = ""
                DatosEmp.Cuentas.CuentaUtilidad = ""
            End If
            Tabla.Clear()

        End If

Exit_Traer_Datos_Empresa:
        Exit Sub
Err_Traer_Datos_Empresa:
        MensajedeError("Cargando datos de la Empresa")
        Resume Exit_Traer_Datos_Empresa
    End Sub
    Public Shared Sub LeerFechasBloqueo()
        On Error GoTo Salir
        Dim T As DataTable, TxtSQL As String
        TxtSQL = "Select FechaInicioOp, AñoUltimaOp,FechaBloqueo,FechaBloqInv,FechaBloqVeh From " _
                 & "Empresas Where NumEmpresa=" & RegistroSamit.Empresa_Ingreso
        T = SMT_AbrirRecordSet(SMTConex, TxtSQL)
        'T.Open(TxtSQL, ControlConexion.ConexionSeguridad, adOpenForwardOnly, adLockReadOnly)
        If T.Rows.Count > 0 Then

            DatosEmp.FechaInicioOperaciones = CDate(T(0)("FechaInicioOp"))
            If Not IsDate(T(0)("FechaBloqueo")) Then
                FechaB = DatosEmp.FechaInicioOperaciones
            Else
                FechaB = T(0)("FechaBloqueo")
            End If
            If Not IsDate(T(0)("FechaBloqInv")) Then
                DatosEmp.FechaBloqueoInventario = FechaB
                Cambiar_FechaBloqueoInventario(FechaB)
            Else
                DatosEmp.FechaBloqueoInventario = T(0)("FechaBloqInv")
            End If
            If Not IsDate(T(0)("FechaBloqVeh")) Then
                DatosEmp.FechaBloqueoVehiculos = FechaB
                Cambiar_FechaBloqueoVehiculos(FechaB)
            Else
                DatosEmp.FechaBloqueoVehiculos = T(0)("FechaBloqVeh")
            End If
            If DatosEmp.FechaBloqueoInventario < FechaB Then
                Cambiar_FechaBloqueoInventario(FechaB)
            End If
            If DatosEmp.FechaBloqueoVehiculos < FechaB Then
                Cambiar_FechaBloqueoVehiculos(FechaB)
            End If
            If DatosEmp.FechadeVentas <= FechaB Then
                Cambiar_FechadeVentas(DateAdd(DateInterval.Day, 1, FechaB))
            End If
            If DatosEmp.FechadeVentas <= DatosEmp.FechaBloqueoInventario Then
                Cambiar_FechadeVentas(DateAdd(DateInterval.Day, 1, DatosEmp.FechaBloqueoInventario))
            End If
        End If
        T.Dispose()
Salir:
    End Sub
    Public Shared Sub Cambiar_FechaBloqueoInventario(ByVal NuevaFecha As Date)
        Dim RegAfectados As Long, Txt As String
        Txt = "Update empresas set FechaBloqInv='" & NuevaFecha &
                              "' Where NumEmpresa=" & RegistroSamit.Empresa_Ingreso
        If SMTConex.State = ConnectionState.Closed Then Exit Sub
        If IsDate(NuevaFecha) Then
            SMT_EjcutarComandoSql(SMTConex, Txt, RegAfectados)
            If RegAfectados > 0 Then DatosEmp.FechaBloqueoInventario = NuevaFecha
        End If

    End Sub
    Public Shared Sub Cambiar_FechaBloqueoVehiculos(ByVal NuevaFecha As Date)
        Dim Txt As String, RegAfectados As Long
        Txt = "Update empresas set FechaBloqVeh='" & NuevaFecha &
                              "' Where NumEmpresa=" & RegistroSamit.Empresa_Ingreso
        If SMTConex.State = ConnectionState.Closed Then Exit Sub
        If IsDate(NuevaFecha) Then
            SMT_EjcutarComandoSql(SMTConex, Txt, RegAfectados)
            If RegAfectados > 0 Then DatosEmp.FechaBloqueoVehiculos = NuevaFecha
        End If

    End Sub
    Public Shared Sub Cambiar_FechadeVentas(ByVal NuevaFecha As Date)
        Dim Txt As String, RegAfectados As Long
        Txt = "Update empresas set FechaVentas='" & NuevaFecha &
                              "' Where NumEmpresa=" & RegistroSamit.Empresa_Ingreso
        If SMTConex.State = ConnectionState.Closed Then Exit Sub
        If IsDate(NuevaFecha) Then
            SMT_EjcutarComandoSql(SMTConex, Txt, RegAfectados)
            If RegAfectados > 0 Then DatosEmp.FechadeVentas = NuevaFecha
        End If
    End Sub
    Public Sub Agrega_Transaccion(VCodigo As Long, VDescripcion As String, VComentario As String, _
                              VReferencia As String, VMenu1 As String, Optional VMenu2 As String = "", Optional VMenu3 As String = "")
        Dim X As Long, Item As New DatosTransacciones

        For X = 0 To UBound(GTransacciones)

            If GTransacciones(X).Codigo = VCodigo Then
                Beep()
                MsgBox("! Transacción Repetida ¡" & Chr(10) + Chr(13) & _
                       "Código      : " & GTransacciones(X).Codigo & Chr(10) + Chr(13) & _
                       "Descripción : " & GTransacciones(X).Descripcion, vbCritical, "Revise Programador")
                Exit Sub
            End If
        Next X

        If UBound(GTransacciones) = 0 And GTransacciones(0).Codigo = 0 Then X = 0 Else X = UBound(GTransacciones) + 1
        ReDim Preserve GTransacciones(X)
        'Item.Codigo = VCodigo
        'Item.Descripcion = VDescripcion
        'Item.Comentario = VComentario
        'Item.Referencia = VReferencia
        'Item.NombreMenu1 = VMenu1
        'Item.NombreMenu2 = VMenu2
        'Item.NombreMenu3 = VMenu3
        'GTransacciones.Add(Item)
        GTransacciones(X).Codigo = VCodigo
        GTransacciones(X).Descripcion = VDescripcion
        GTransacciones(X).Comentario = VComentario
        GTransacciones(X).Referencia = VReferencia
        GTransacciones(X).NombreMenu1 = VMenu1
        GTransacciones(X).NombreMenu2 = VMenu2
        GTransacciones(X).NombreMenu3 = VMenu3

        Verifica_Transaccion(X)


    End Sub
    Public Function Autoriza_Transaccion(ByVal Transaccion As Long) As Boolean
        On Error Resume Next
        If LaConexionEstaActiva Then
            Autoriza_Transaccion = Autoriza_La_Transaccion(Transaccion)
        End If
        Return Autoriza_Transaccion
    End Function
    Public Function TransaccionAutorizada(Numero_de_Transaccion As Long) As Boolean
        On Error Resume Next
        If LaConexionEstaActiva Then
            TransaccionAutorizada = LaTransaccion_Es_Autorizada(Numero_de_Transaccion)
        End If
        Return TransaccionAutorizada
    End Function
    Private Sub Verifica_Transaccion(Indice As Long)
        On Error GoTo Err_Verifica_Transaccion
        Dim TxtSQL As String, Datos As String, Campos As String, X As Long, Retorno As Long = 0

        Campos = "(NumTransaccion,NumProducto,Descripcion,Comentario,Referencia)"

        If GTransacciones(Indice).Codigo <> 0 Then
            If Not Existe_EN_BD_Transaccion(GTransacciones(Indice).Codigo, True, X) Then
                Datos = "(" & GTransacciones(Indice).Codigo & "," & NumModulo & ",'" & GTransacciones(Indice).Descripcion & "','" & _
                              GTransacciones(Indice).Comentario & "','" & GTransacciones(Indice).Referencia & "')"
                'ControlConexion.ConexionSeguridad.Execute "INSERT INTO Transacciones " & Campos & "  Values " & Datos
                SMT_EjcutarComandoSql(SMTConex, "INSERT INTO Transacciones " & Campos & "  Values " & Datos, Retorno)

            Else
                If X > 0 Then
                    If GTransacciones(Indice).Comentario <> GTransacccionesEnServidor(X).Comentario Or _
                       GTransacciones(Indice).Descripcion <> GTransacccionesEnServidor(X).Descripcion Or _
                       GTransacciones(Indice).Referencia <> GTransacccionesEnServidor(X).Referencia Then
                        TxtSQL = "UPDATE Transacciones Set Comentario='" & GTransacciones(Indice).Comentario & "', " & _
                                "Descripcion='" & GTransacciones(Indice).Descripcion & "',Referencia='" & GTransacciones(Indice).Referencia & "' " & _
                                "WHERE NumTransaccion =" & GTransacciones(Indice).Codigo & " " & _
                                "AND (Comentario <> '" & GTransacciones(Indice).Comentario & "' OR " & _
                                "Descripcion <> '" & GTransacciones(Indice).Descripcion & "' OR " & _
                                "Referencia<>'" & GTransacciones(Indice).Referencia & "')"
                        'ControlConexion.ConexionSeguridad.Execute TxtSQL
                        SMT_EjcutarComandoSql(SMTConex, TxtSQL, Retorno)
                    End If
                End If
            End If
        End If

Exit_Verifica_Transaccion:
        Exit Sub
Err_Verifica_Transaccion:
        MensajedeError("Verificando Transacciones del Modulo")
        Resume Exit_Verifica_Transaccion
    End Sub
    Public Sub Procesar_Menus_Segun_Las_Transacciones_Autorizadas(ByRef ForMDI_de_Moduo As Object)
        On Error GoTo Err_Procesar_Menus_Autorizados
        Dim X As Long

        For X = 0 To GTransacciones.Count
            ManejoMenu(AccionMenu.Deshabilitar_Menu, GTransacciones(X).NombreMenu1, ForMDI_de_Moduo)
            ManejoMenu(AccionMenu.Deshabilitar_Menu, GTransacciones(X).NombreMenu2, ForMDI_de_Moduo)
            ManejoMenu(AccionMenu.Deshabilitar_Menu, GTransacciones(X).NombreMenu3, ForMDI_de_Moduo)
        Next X

        For X = 0 To GTransacciones.Count
            If Autoriza_Transaccion(GTransacciones(X).Codigo) Then
                ManejoMenu(AccionMenu.Habilitar_Menu, GTransacciones(X).NombreMenu1, ForMDI_de_Moduo)
                ManejoMenu(AccionMenu.Habilitar_Menu, GTransacciones(X).NombreMenu2, ForMDI_de_Moduo)
                ManejoMenu(AccionMenu.Habilitar_Menu, GTransacciones(X).NombreMenu3, ForMDI_de_Moduo)
            End If
        Next X

Exit_Procesar_Menus_Autorizados:
        Exit Sub
Err_Procesar_Menus_Autorizados:
        MensajedeError("Procesando Menus de la Aplicación")
        Resume Exit_Procesar_Menus_Autorizados
    End Sub
    Private Sub ManejoMenu(Accion As AccionMenu, NomMenu As String, ByRef FormularioMDI As Form)
        On Error Resume Next
        Dim Ctrl As Control, Encontro As Boolean, Nombre As String, Indice As String

        If NomMenu = "" Then Exit Sub
        'While InStr(1, NomMenu, Chr(13), vbTextCompare) > 1
        '    NomMenu = Left(NomMenu, InStr(1, NomMenu, Chr(13), vbTextCompare) - 1)
        'End While
        'Indice = InStr(1, NomMenu, "(", vbTextCompare)
        'Encontro = False
        'If Indice <> 0 Then
        '    Nombre = Mid(NomMenu, 1, Indice - 1)
        '    Indice = Mid(NomMenu, Indice + 1, InStr(1, NomMenu, ")", vbTextCompare) - Indice - 1)
        '    For Each Ctrl In FormularioMDI.Controls
        '        If UCase(Ctrl.Name) = UCase(Nombre) Then
        '            If Ctrl.Index = CInt(Indice) Then Encontro = True : Exit For
        '        End If
        '    Next Ctrl
        'Else
        'End If
        For Each Ctrl In FormularioMDI.Controls
            If UCase(Ctrl.Name) = UCase(NomMenu) Then Encontro = True : Exit For
        Next Ctrl

        If Not Encontro Then Exit Sub
        If Accion = AccionMenu.Deshabilitar_Menu Then Ctrl.Enabled = False
        If Accion = AccionMenu.Esconder_menu Then Ctrl.Visible = False
        If Accion = AccionMenu.Habilitar_Menu Then Ctrl.Enabled = True
        If Accion = AccionMenu.Mostrar_Menu Then Ctrl.Visible = True
    End Sub
    Private Sub ManejoMenuRibbonForm(Accion As AccionMenu, NombreControl As String, ByRef FormularioMDI As RibbonForm)
        On Error Resume Next
        Dim Ctrl As Control, Encontro As Boolean, Nombre As String, Indice As String

        If NombreControl = "" Then Exit Sub
        'While InStr(1, NomMenu, Chr(13), vbTextCompare) > 1
        '    NomMenu = Left(NomMenu, InStr(1, NomMenu, Chr(13), vbTextCompare) - 1)
        'End While
        'Indice = InStr(1, NomMenu, "(", vbTextCompare)
        'Encontro = False
        'If Indice <> 0 Then
        '    Nombre = Mid(NomMenu, 1, Indice - 1)
        '    Indice = Mid(NomMenu, Indice + 1, InStr(1, NomMenu, ")", vbTextCompare) - Indice - 1)
        '    For Each Ctrl In FormularioMDI.Controls
        '        If UCase(Ctrl.Name) = UCase(Nombre) Then
        '            If Ctrl.Index = CInt(Indice) Then Encontro = True : Exit For
        '        End If
        '    Next Ctrl
        'Else
        'End If
        For Each Ctrl In FormularioMDI.Controls
            If UCase(Ctrl.Name) = UCase(NombreControl) Then Encontro = True : Exit For
        Next Ctrl

        If Not Encontro Then Exit Sub
        If Accion = AccionMenu.Deshabilitar_Menu Then Ctrl.Enabled = False
        If Accion = AccionMenu.Esconder_menu Then Ctrl.Visible = False
        If Accion = AccionMenu.Habilitar_Menu Then Ctrl.Enabled = True
        If Accion = AccionMenu.Mostrar_Menu Then Ctrl.Visible = True
    End Sub
    Public Function PudoIngresar(Optional MiServidor As String = "", Optional MiBD As String = "", Optional MiFechaTrabajo As Date = Nothing, _
                                Optional MiFechasys As DateTime = Nothing, Optional MiUsu As String = "", Optional MiRol As Integer = 0) As Boolean
        On Error GoTo CtlErr
        Dim Login As New LoginForm1, RolEmpresa As New FrmRolEmpresa, SQL As String, Espera As New ClEspera, Retorno As Long
        PudoIngresar = False
        RegistroUsuario = False
        ReDim GTransacciones(0)
        If MiServidor.Trim = "" Then
            Login.ShowDialog()
        Else
            IniciosinMostrar = True
            CadConex = "Data Source=" & MiServidor & ";Initial Catalog=" & VGRutaBD_Seg & " ;user id = sa; password = " & VGPaswdBD_Seg & ";Connection Timeout=3"
            SMTConex.ConnectionString = CadConex
            SMTConex.Open()
        End If

        If SMTConex.State > 0 Then
            If MiServidor.Trim <> "" Then
                SMTServidor = MiServidor
                If Not IniciosinMostrar Then Espera.Mostrar("", "Iniciando Conexion de Módulo")
                CadConex = "Data Source=" & MiServidor & ";Initial Catalog=" & MiBD & " ;user id = sa; password = " & VGPaswdBD_Mod & ";Connection Timeout=3"
                If SMTConexMod.State = ConnectionState.Closed Then
                    SMTConexMod.ConnectionString = CadConex
                    SMTConexMod.Open()
                End If
                If SMTConexMod.State > 0 Then
                    SMT_EjcutarComandoSql(SMTConexMod, "SET dateformat dmy", Retorno) 'Cambio Formato de Facha a dia mes año en la conexion
                    PudoIngresar = True
                    InicioConexion_Empresa = True
                    GUsuario.RolIngreso = MiRol
                    FechadeTrabajo = MiFechaTrabajo
                    FechadelServidor = MiFechasys
                    SMTLogin = MiUsu
                Else
                    PudoIngresar = False
                    SMTConex.Close()
                End If
                If Not IniciosinMostrar Then Espera.Terminar()
            Else
                Cargar_Transacciones_del_Servidor()
                If SMTConexMod.State = ConnectionState.Open Then SMTConexMod.Close()
                InicioConexion_Control = True
                RolEmpresa.ShowDialog()
                Cargar_Transacciones_Rol()
                If SMTConexMod.State > 0 Then
                    SMT_EjcutarComandoSql(SMTConexMod, "SET dateformat dmy", Retorno) 'Cambio Formato de Facha a dia mes año en la conexion
                    'SQL = "Update Productos Set UsuariosConectados=isnull(UsuariosConectados,0) + 1 WHERE NumProducto = " & NumModulo.ToString
                    'SMT_EjcutarComandoSQL(SMTConex, SQL, VGRetorno)
                    PudoIngresar = True
                    InicioConexion_Empresa = True
                    GUsuario.RolIngreso = VgNumeroRolIngreso
                    SQL = "Update Usuarios Set Registrado=1,FechaHoraIngreso=Getdate(),Terminal='" + VgNombreTerminalUsuario + "', NumIngresos=(ISNULL(NumIngresos,0) + 1) Where Login ='" + VgLoginUsuario + "'"
                    SMT_EjcutarComandoSql(SMTConex, SQL, VGRetorno)

                    SQL = "Insert Into SesionXUsuario (Usuario,Rol,Terminal,FechaIngreso,FechaReporte,FechaSalida,Modulo," & _
                     "UsuarioWindows,Terminada,IdProCtrl) Values(" & GUsuario.Numero & "," & VgNumeroRolIngreso & ",'" & VgNombreTerminalUsuario & "',Getdate(),Getdate()," & _
                     "null," & NumerodeModulo & ",'" & VgUsuarioWindows & "',0,@@SPID)"
                    SMT_EjcutarComandoSql(SMTConex, SQL, VGRetorno)
                    RegistroUsuario = True
                    Determinar_Codigo_de_Sesion()
                Else
                    SMTConex.Close()
                End If
            End If
        End If
        Exit Function
CtlErr:
        'MensajedeError()
        If Not IniciosinMostrar Then Espera.Terminar()
    End Function
    Public Sub Determinar_Codigo_de_Sesion()
        Dim TxtSQL As String, TB As New DataTable
        TxtSQL = "Select CodIngreso From SesionxUsuario Where Usuario=" & GUsuario.Numero & _
                 " and Terminal='" & VgNombreTerminalUsuario & "' and Modulo = " & NumerodeModulo & _
                 " and UsuarioWindows ='" & VgUsuarioWindows & "' and Terminada=0 and " & _
                 " (DATEDIFF(second, FechaReporte, getdate())) <=10"
        'TB.Open(TxtSQL, ControlConexion.ConexionSeguridad, adOpenForwardOnly, adLockReadOnly)
        TB = SMT_AbrirRecordSet(SMTConex, TxtSQL)
        If TB.Rows.Count = 1 Then GUsuario.CodigodeSesion = TB(0)("CodIngreso")
        TB.Dispose()
    End Sub
    Public Function DebeActualizarVersionDeProgramaModulo(AppMajor As Long, AppMinor As Long, AppRevision As Long) As Boolean
        On Error Resume Next
        Dim SQL As String, Rs As New DataTable, Major As Long, Minor As Long, Revision As Long, Resto As String
        SQL = "Select * from Empver Where Empresa = " & VgEmpresa & " and año = " & Year(FechaW) & " and prod = " & NumerodeModulo
        'Rs.Open(SQL, ControlConexion.ConexionSeguridad, adOpenForwardOnly, adLockReadOnly)
        Rs = SMT_AbrirRecordSet(SMTConex, SQL)

        If Rs.Rows.Count > 0 Then
            Resto = Rs(0)("ver")
            Major = CLng(Left(Rs(0)("ver"), InStr(1, Resto, ".") - 1))
            Resto = Right(Resto, Len(Resto) - InStr(1, Resto, "."))
            Minor = CLng(Left(Resto, InStr(1, Resto, ".") - 1))
            Resto = CLng(Right(Resto, Len(Resto) - InStr(1, Resto, ".")))
            Revision = Resto
            If AppMajor > Major Then
                Return True
                Exit Function
            End If
            If AppMinor > Minor Then
                Return True
                Exit Function
            End If
            If AppRevision > Revision Then
                Return True
                Exit Function
            End If
        Else
            SQL = "insert into EmpVer (empresa,año,prod,ver) values (" & _
                  VgEmpresa & "," & Year(FechaW) & "," & NumerodeModulo & ",'" & AppMajor & "." & AppMinor & "." & AppRevision & "')"
            'ControlConexion.ConexionSeguridad.Execute SQL
            SMT_EjcutarComandoSql(SMTConex, SQL, VGRetorno)

            Return True
        End If
    End Function

    Public Shared Function Puede_Ingresar_al_Sistema() As Boolean
        On Error GoTo Err_Puede_Ingresar_al_Sistema
        Dim Tbl As New DataTable, TxtSQL As String
        Puede_Ingresar_al_Sistema = False
        'Verificar_Conexiones()
        ValidarConexionConServidor(CadConex)
        If Not HayConexionConSRV Then Return False
        If Not InicioConexion_Control Then Exit Function

        TxtSQL = "Select * From Usuarios where Login ='" & GUsuario.Login & "'"
        Tbl = SMT_AbrirRecordSet(SMTConex, TxtSQL)
        If Tbl.Rows.Count <= 0 Then CodError = 2 : GoTo Verificacion_Fallida 'No existe el usuario
        Dim Fila As DataRow
        Fila = Tbl.Rows(0)
        If Fila("Estado").ToString.ToUpper <> "V" Then CodError = 3 : GoTo Verificacion_Fallida 'El usuario no esta vigente
        If Fila("Clave") <> GUsuario.PWD Then CodError = 4 : GoTo Verificacion_Fallida 'La Clave es incorrecta
        GUsuario.Numero = Fila("NumUsuario")
        Traer_FechaDelServidor()
        If Not IsDBNull(Fila("FechaVigencia")) Then
            If Fila("FechaVigencia") <= FechaSys Then
                CodError = 8 : GoTo Verificacion_Fallida
            End If
        Else
            CodError = 8 : GoTo Verificacion_Fallida
        End If

        Tbl.Dispose()
        'If YaOcupoUsuariosLicencia(VGNumModulo) Then CodError = 11 : GoTo Verificacion_Fallida 'Ocupo las licencias del modulo

        If El_Usuario_Ya_Esta_Registrado(GUsuario.Numero) Then
            GoTo Verificacion_Fallida 'El usuario ya se registro o esta registrado en otro equipo.
        End If

        TxtSQL = "Select CodIngreso From SesionxUsuario where terminal ='" & VgNombreTerminalUsuario & _
                 "' And Usuario <> " & GUsuario.Numero & " and Terminada = 0 and UsuarioWindows='" & VgUsuarioWindows & "' "
        Tbl = SMT_AbrirRecordSet(SMTConex, TxtSQL)
        'Tbl.Open(TxtSQL, ControlConexion.ConexionSeguridad, adOpenDynamic, adLockOptimistic)
        If Tbl.Rows.Count > 0 Then CodError = 6 : GoTo Verificacion_Fallida
        Tbl.Dispose()
        LaConexionEstaActiva = True
        Puede_Ingresar_al_Sistema = True

Exit_Puede_Ingresar_al_Sistema:
        Tbl = Nothing
        Exit Function
Err_Puede_Ingresar_al_Sistema:
        MensajedeError("Validando ingreso al sistema..")
        Resume Exit_Puede_Ingresar_al_Sistema
Verificacion_Fallida:
        If Tbl.Rows.Count <> 0 Then Tbl.Dispose()
        MsgBox(TextoError(CodError), vbInformation, "Error en Ingreso al Sistema")
        CodError = 0
        GoTo Exit_Puede_Ingresar_al_Sistema
    End Function
    Public Shared Function El_Usuario_Ya_Esta_Registrado(CodigoUsuario As Integer) As Boolean
        On Error GoTo Err_El_Usuario_Ya_Esta_Registrado
        Dim TB As New DataTable, TxtSQL As String, Procesados As Long, FechaServidor As Date
        SMT_EjcutarComandoSql(SMTConex, "Update SesionxUsuario Set FechaSalida = FechaReporte, Terminada = 1 " & _
                           "Where (DATEDIFF(second, FechaReporte, getdate())) > 11 and Terminada = 0", Procesados)
        'Marca como terminadas las sesiones que lleven mas de 11 Segundos sin reportarse.
        SMT_EjcutarComandoSql(SMTConex, "Update Usuarios Set Registrado = 0 Where (Select Count(Usuario) From SesionxUsuario " & _
                           "Where Terminada=0 and Usuario = NumUsuario )=0 ", Procesados)
        'Marca Como no registrado al usuario que no tenga Sesiones Activas.
        TxtSQL = "Select * From SesionxUsuario Where Usuario=" & CodigoUsuario & " and Terminada=0 "
        TB = SMT_AbrirRecordSet(SMTConex, TxtSQL)
        FechaServidor = Traer_FechaDelServidor()
        If TB.Rows.Count <= 0 Then
            El_Usuario_Ya_Esta_Registrado = False
        Else
            For Each Fila As DataRow In TB.Rows
                CodError = 0
                If Fila("Terminal").ToString.Trim <> VgNombreTerminalUsuario Then          'Ya esta conectado en otra terminal.
                    CodError = 5 : Texto_del_Error = Fila("Terminal")
                    Exit For
                Else
                    'Aqui se Valida que se hubiera abierto ya sesion en el mismo modulo
                End If
                If DateDiff("s", Fila("FechaReporte"), FechaServidor) >= 12 Then
                    SMT_EjcutarComandoSql(SMTConex, "Update SesionxUsuario Set FechaSalida = FechaReporte, Terminada = 1 where CodIngreso=" & Fila("CodIngreso"), Procesados)
                End If
            Next
        End If
        If CodError = 0 Then
            CodError = 100
            El_Usuario_Ya_Esta_Registrado = False
        Else
            El_Usuario_Ya_Esta_Registrado = True
        End If

        TB.Dispose()
        Return El_Usuario_Ya_Esta_Registrado
Exit_El_Usuario_Ya_Esta_Registrado:
        TB = Nothing
        Exit Function
Err_El_Usuario_Ya_Esta_Registrado:
        MensajedeError("Verificando si el usuario esta registrado..")
        Resume Exit_El_Usuario_Ya_Esta_Registrado
    End Function
    Private Shared Function TextoError(Codigo As Integer) As String
        'If IsNull(GUsuario) Then GUsuario = ""
        Select Case Codigo
            Case 1
                TextoError = "Ha intentado Conectarse tres (3) o más Veces sin Exito"
            Case 2
                TextoError = "Usuario " & GUsuario.Login & " Inexistente."
            Case 3
                TextoError = "Usuario " & GUsuario.Login & " no Vigente."
            Case 4
                TextoError = "Clave Invalida "
            Case 5
                TextoError = "Usuario " + GUsuario.Login + " ya registrado en otra Terminal: " & Texto_del_Error
            Case 6
                TextoError = "Ya hay un usuario registrado en la terminal " + VgNombreTerminalUsuario + "."
            Case 7
                TextoError = "No ha Ingresado la ruta de la Base de Datos"
            Case 8
                TextoError = "El plazo de ingreso del usuario " + GUsuario.Login + " ya caduco. "
            Case 9
                TextoError = "Ya tiene una sesión iniciada del modulo " & NombreModulo & " en este computador."
            Case 10
                TextoError = ""
            Case 11
                TextoError = "Ya Agoto las Licencias del Producto o no Existe"
            Case Else
                TextoError = "Numero de Error no Controlado : " & Codigo.ToString
        End Select
    End Function
    Public Shared Function YaOcupoUsuariosLicencia(modulo As Integer) As Boolean
        On Error Resume Next
        Dim Tb As DataTable
        YaOcupoUsuariosLicencia = True
        Tb = SMT_AbrirRecordSet(SMTConex, "select count(*) as conectados, (select numusuarios from productos where numproducto = " & modulo.ToString & ") as numusuarios from sesionxusuario where terminada = 0 and  modulo = " & modulo.ToString)
        If Tb.Rows.Count > 0 Then
            If Tb(0)("numusuarios") > Tb(0)("conectados") Then
                YaOcupoUsuariosLicencia = False
            End If
        End If
    End Function
    Public Sub TerminarConexion()
        On Error GoTo Err_TerminarConexion
        Dim Tbl As New DataTable, Tbl2 As New DataTable
        LaConexionEstaActiva = False
        If RegistroUsuario Then
            If SMTConex.State <> 0 Then

                SMT_EjcutarComandoSql(SMTConex, "Update Usuarios Set Registrado=0 Where Login ='" & GUsuario.Login & "'", VGRetorno)
                SMT_EjcutarComandoSql(SMTConex, "Update Productos Set UsuariosConectados=isnull(UsuariosConectados,0) - 1 Where NumProducto=" & NumModulo.ToString, VGRetorno)
                SMT_EjcutarComandoSql(SMTConex, "Update SesionxUsuario Set FechaSalida=Getdate(),Terminada=1 Where CodIngreso =" & GUsuario.CodigodeSesion.ToString, VGRetorno)
            End If
        End If
        GUsuario.CodigodeSesion = 0
        If SMTConex.State = ConnectionState.Open Then SMTConex.Close()
        If SMTConexMod.State = ConnectionState.Open Then SMTConexMod.Close()
        Tbl = Nothing
        'If ActivaEventosConexiones Then
        '    ObjetoImageEstadoConsulta.Picture = ControlConexion.ImagenesServidor.ListImages(1).Picture
        '    ObjetoImageEstadoConsulta.Refresh()
        'End If
        RegistroUsuario = False
        InicioConexion_Control = False
        InicioConexion_Empresa = False

        ReDim GUsuario.TranAuto(0)
Exit_TerminarConexion:
        Exit Sub
Err_TerminarConexion:
        MensajedeError()
        Resume Exit_TerminarConexion
    End Sub
    Private Sub Verificar_Conexiones()
        On Error GoTo ControlError
        Dim ConexPrueba As New SqlConnection, MensajedeConexion As String
        If SMTConex.State = 0 Then
            ConexPrueba.ConnectionString = Cad_Conexion("master", GPaswdBD_Seg)
            ConexPrueba.Open()

            If ConexPrueba.State <= 0 Then
                MensajedeConexion = "No se pudo establecer Conexión con el servidor de datos.."
                GoTo Ingreso_Fallido
            End If
            ConexPrueba.Close()
            ConexPrueba = Nothing
            SMTConex.ConnectionString = Cad_Conexion(GRutaBD_Seg, GPaswdBD_Seg)
            SMTConex.Open()
            If SMTConex.State = 0 Then
                MensajedeConexion = "No se encontro la base de datos de Control ." & Chr(13) & Chr(10) & "Avise al administrador del sistema"
                GoTo Ingreso_Fallido
            Else
                InicioConexion_Control = True
                LaConexionEstaActiva = True
            End If
        End If
        Exit Sub
ControlError:
        MensajedeError()
        Exit Sub
Ingreso_Fallido:
        MsgBox(MensajedeConexion, vbCritical, "Error de Conexión")
        LaConexionEstaActiva = False
    End Sub


    Public Function Cad_Conexion(Ruta As String, Paswd As String) As String
        On Error GoTo Fin_Funcion
        'MSdataShape

        Cad_Conexion = "Provider=MSdataShape.1;Persist Security Info=False;" _
        + "User ID=sa;PWD=" + Paswd + ";Initial Catalog=" + Ruta _
        + ";Data Source=" + SMTServidor + ";Connect Timeout=5;Data Provider=SQLOLEDB.1;Encrypt=yes;Trusted_Connection=not"

Fin_Funcion:
    End Function
    Public Sub Cargar_Transacciones_Rol()
        On Error GoTo Err_Cargar_Transacciones
        Dim TxtSQL As String, X As Long = 0, Tbl As DataTable
        TxtSQL = "Select NumTransaccion From roltransaccion Where NumeroRol = " & GUsuario.RolIngreso
        'Tbl.Open(TxtSQL, ControlConexion.ConexionSeguridad, adOpenForwardOnly, adLockReadOnly)
        Tbl = SMT_AbrirTabla(SMTConex, TxtSQL)
        If Tbl.Rows.Count > 0 Then
            ReDim GUsuario.TranAuto(Tbl.Rows.Count - 1)
            For Each Fila As DataRow In Tbl.Rows
                GUsuario.TranAuto(X) = CLng(Fila("NumTransaccion"))
                X += 1
            Next
        Else
            ReDim GUsuario.TranAuto(0)
        End If
        Tbl.Dispose()
        Tbl = Nothing
Exit_Cargar_Transacciones:
        Exit Sub
Err_Cargar_Transacciones:
        MensajedeError("Cargando Transacciones")
        Resume Exit_Cargar_Transacciones
    End Sub
    Public Sub Cargar_Transacciones_del_Servidor()
        On Error GoTo ControlError
        Dim TB As DataTable, X As Long = 0
        TB = SMT_AbrirTabla(SMTConex, "Select * From Transacciones")
        'GTransacccionesEnServidor.Initialize()
        ReDim GTransacccionesEnServidor(0)
        If TB.Rows.Count > 0 Then
            ReDim GTransacccionesEnServidor(TB.Rows.Count - 1)
            For Each Fila As DataRow In TB.Rows

                GTransacccionesEnServidor(X).Codigo = AsignarCampo(Fila, "NumTransaccion")
                GTransacccionesEnServidor(X).Comentario = AsignarCampo(Fila, "Comentario")
                GTransacccionesEnServidor(X).Descripcion = AsignarCampo(Fila, "Descripcion")
                GTransacccionesEnServidor(X).Referencia = AsignarCampo(Fila, "Referencia")
                X = X + 1
            Next

        End If
        TB.Dispose()
        Exit Sub
ControlError:
        MensajedeError("Cargando todas las transacciones")
    End Sub
    Public Function ActualizarCodigodeVersionDeModuloEnBD(AppMajor As Long, AppMinor As Long, AppRevision As Long) As Boolean
        On Error Resume Next
        Dim SQL As String = "", Retorno As ULong = 0
        SQL = "update EmpVer SET " & _
              " Ver = '" & AppMajor & "." & AppMinor & "." & AppRevision & "' " & _
              " Where Empresa = " & VgEmpresa & " and año = " & Year(FechaW) & " and prod = " & NumerodeModulo
        SMT_EjcutarComandoSql(SMTConex, SQL, Retorno)
        If Retorno > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Sub Reloj_tick()
        ValidarConexionConServidor(CadConex)
    End Sub
End Class
