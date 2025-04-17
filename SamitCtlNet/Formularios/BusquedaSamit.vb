Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports System.Reflection
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Columns

Partial Public Class BusquedaSamit
    Inherits Form
    Private Datos As New DataTable()
    Dim _txtFiltro As String
    Dim _primerEntrada As Boolean
    Dim _primerEntradaLibre As Boolean = True
    Public Shared _Conexion As SqlConnection = Nothing
    Private Shared _consultaSQL As String
    Public Formulario As Control
    Public FilaDevuelta As DataRow
    Public Property ListaColumnas As List(Of GridColumn)
    Public Shared Event CambioId(ByVal sender As System.Object, e As BusquedaSamitEventArgs)
    Public ReadOnly Property HayUnsoloRegistro
        Get
            If Datos.Rows.Count = 1 Then
                Return True
            Else
                Return False
            End If
        End Get

    End Property

    Public Property DatosEnMemoria() As DataTable
        Get
            Return Datos
        End Get
        Set(ByVal value As DataTable)
            Datos = value
        End Set

    End Property

    Public Property ValorSeleccionado() As String
        Get
            Return m_ValorSeleccionado
        End Get
        Set(ByVal value As String)
            m_ValorSeleccionado = value
        End Set
    End Property
    Private m_ValorSeleccionado As String
    Private PorTipo As TipoBusqueda
    Public Property ValorAlternativoDevuelto() As String
        Get
            Return m_ValorAlternativoDevuelto
        End Get
        Set(ByVal value As String)
            m_ValorAlternativoDevuelto = value
        End Set
    End Property
    Private m_ValorAlternativoDevuelto As String

    Private FechaMenor As String
    Friend WithEvents dgwresultados As DevExpress.XtraGrid.GridControl
    Friend WithEvents VistaBusqueda As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents progreso As System.Windows.Forms.ToolStripProgressBar
    Private WithEvents btnAccion As System.Windows.Forms.Button
    Friend WithEvents pnlContenedor As System.Windows.Forms.Panel
    Friend WithEvents tiempo As System.Windows.Forms.Timer
    Private FechaMayor As String

    Public Sub New(ByVal TipodeBusqueda As TipoBusqueda, Optional ByVal fechamenor__1 As String = "", Optional ByVal fechamayor__2 As String = "",
                   Optional ByVal nombreFormulario As String = "", Optional ByVal nombreCompilado As String = "", Optional ByVal tituloVentana As String = "",
                   Optional ByVal nombreBoton As String = "", Optional ByVal TxtBusq As String = "", Optional ConsultaSQL As String = "",
                   Optional DatosPrecargados As DataTable = Nothing, Optional Conexion As SqlConnection = Nothing, Optional ListaColumns As List(Of GridColumn) = Nothing)
        InitializeComponent()

        Try

            _Conexion = Conexion
            Datos = DatosPrecargados
            PorTipo = TipodeBusqueda
            FechaMayor = fechamayor__2
            FechaMenor = fechamenor__1
            _consultaSQL = ConsultaSQL
            ListaColumnas = ListaColumns

            If nombreFormulario = "" Then
                btnAccion.Visible = False
                dgwresultados.Size = New Size(dgwresultados.Size.Width, dgwresultados.Size.Height + 26)
            Else
                btnAccion.Name = nombreFormulario
                btnAccion.Tag = nombreCompilado
                If nombreBoton.Trim().Equals("") Then
                    If PorTipo = TipoBusqueda.GrupoActivo Then
                        btnAccion.Text = "Registrar Nuevo Grupo de Activos"
                    End If
                Else
                    btnAccion.Text = nombreBoton
                End If
            End If
            If tituloVentana.Trim().Equals("") Then
                Me.Text = "Busqueda Rapida SAMIT SQL"
            Else
                Me.Text = tituloVentana
            End If
        Catch ex As Exception
        End Try
        _txtFiltro = TxtBusq
        _primerEntrada = True
        MostraDatos()
        AcomodarForm()
        'txbcampo.Text = _txtFiltro
    End Sub
    Public Sub New(ByVal TipodeBusqueda As TipoBusqueda, ByVal nombreFormulario As String, ByVal nombreCompilado As String, ByVal tituloVentana As String, ByVal nombreBoton As String, Optional ByVal TxtBusq As String = "")
        Me.New(TipodeBusqueda, "01/01/1900", "31/12/2050", nombreFormulario, nombreCompilado, tituloVentana, nombreBoton, TxtBusq)
    End Sub
    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub btn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAccion.Click
        Try
            Dim btn As Button = CType(sender, Button)
            If btn.Name = Nothing Then
                '
            Else
                Dim asm As Assembly = Assembly.LoadFrom(Application.StartupPath + "\" + btn.Tag.ToString())
                Dim formtype As Type = asm.[GetType](btn.Name.ToString())
                Dim f As Form = DirectCast(Activator.CreateInstance(formtype), Form)
                f.ShowDialog()
                MostraDatos()
            End If
        Catch ex As TargetInvocationException

        End Try
    End Sub

    Private Shared RecargarPendiente As Boolean = False
    Public Shared Sub RecargarDatos()
        RecargarPendiente = True
    End Sub

    Private Sub AcomodarForm()
        'btnAccion.Image = My.Resources._16x16.add
        'Grilla dev

        GrillaDevExpress.CrearGrilla(VistaBusqueda, False, False, "", False)
        'VistaBusqueda.DataSource = 
        VistaBusqueda.OptionsView.ColumnAutoWidth = True
        VistaBusqueda.BestFitColumns()
        Select Case PorTipo
            'La primer columna debe contener el codigo o identificacion es la que se va a tomar como ValorSeleccionado
            'La segunda columna debe ser un nombre o descripcion esta va a ser el ValorAlternativoDevuelto
            Case TipoBusqueda.PersonaEmpleado
                VistaBusqueda.Columns.Add(GrillaDevExpress.CrearColumna("Identificacion", "Documento", anchoColumna:=140, alineacion:=AlinearTexto.Derecha, formato:="n0", tipo:=DevExpress.Utils.FormatType.Numeric, autoAncho:=False))
                VistaBusqueda.Columns.Add(GrillaDevExpress.CrearColumna("nombre", "Nombre", autoAncho:=True))
                VistaBusqueda.Columns("nombre").BestFit()
                VistaBusqueda.Columns.Add(GrillaDevExpress.CrearColumna("numcelular", "Celular", anchoColumna:=130))
            Case TipoBusqueda.Persona
                VistaBusqueda.Columns.Add(GrillaDevExpress.CrearColumna("Identificacion", "Documento", anchoColumna:=140, alineacion:=AlinearTexto.Derecha, formato:="n0", tipo:=DevExpress.Utils.FormatType.Numeric, autoAncho:=False))
                VistaBusqueda.Columns.Add(GrillaDevExpress.CrearColumna("nombre", "Nombre", autoAncho:=True))
                VistaBusqueda.Columns("nombre").BestFit()
                VistaBusqueda.Columns.Add(GrillaDevExpress.CrearColumna("numcelular", "Celular", anchoColumna:=130))
            Case TipoBusqueda.Proveedores
                VistaBusqueda.Columns.Add(GrillaDevExpress.CrearColumna("Identificacion", "Documento", anchoColumna:=120, alineacion:=AlinearTexto.Derecha, formato:="n0", tipo:=DevExpress.Utils.FormatType.Numeric))
                VistaBusqueda.Columns.Add(GrillaDevExpress.CrearColumna("nombre", "Nombre", autoAncho:=True))
                'VistaBusqueda.Columns.Add(GrillaDevExpress.CrearColumna("email", "Correo", anchoColumna:=90))
                VistaBusqueda.Columns.Add(GrillaDevExpress.CrearColumna("numcelular", "Celular", anchoColumna:=130))
            Case TipoBusqueda.Productos
                VistaBusqueda.Columns.Add(GrillaDevExpress.CrearColumna("codigo", "Codigo", anchoColumna:=100, alineacion:=AlinearTexto.Derecha))
                VistaBusqueda.Columns.Add(GrillaDevExpress.CrearColumna("Nombre", "Nombre", autoAncho:=True))
                VistaBusqueda.Columns.Add(GrillaDevExpress.CrearColumna("Referencia", "Referencia"))
            Case TipoBusqueda.DocumentosInventario
                VistaBusqueda.Columns.Add(GrillaDevExpress.CrearColumna("NumFactura", "Codigo", anchoColumna:=50, alineacion:=AlinearTexto.Derecha))
                VistaBusqueda.Columns.Add(GrillaDevExpress.CrearColumna("Nombre", "Nombre", autoAncho:=True))
                VistaBusqueda.Columns.Add(GrillaDevExpress.CrearColumna("Tercero", "Doc Tercero", autoAncho:=True))
                VistaBusqueda.Columns.Add(GrillaDevExpress.CrearColumna("FechaDoc", "Fecha", "dd/M/yyyy"))
                VistaBusqueda.Columns.Add(GrillaDevExpress.CrearColumna("Valor", "Valor Factura", formato:="#,##0.00", anchoColumna:=120, alineacion:=AlinearTexto.Derecha))
            Case TipoBusqueda.Ubicaciones
                VistaBusqueda.Columns.Add(GrillaDevExpress.CrearColumna("CodUbicacion", "Codigo", anchoColumna:=100, alineacion:=AlinearTexto.Derecha))
                VistaBusqueda.Columns.Add(GrillaDevExpress.CrearColumna("NomUbPrin", "Nombre", autoAncho:=True))
                VistaBusqueda.Columns.Add(GrillaDevExpress.CrearColumna("Sucursal", "Sucursal", anchoColumna:=150))
            Case TipoBusqueda.UbicacionesEspecificas
                VistaBusqueda.Columns.Add(GrillaDevExpress.CrearColumna("Ub_Especifica", "Ubi. Especifica", anchoColumna:=150))
                VistaBusqueda.Columns.Add(GrillaDevExpress.CrearColumna("NomUbEsp", "Nombre", autoAncho:=True))
                VistaBusqueda.Columns.Add(GrillaDevExpress.CrearColumna("Ub_Principal", "Ubi. Principal", anchoColumna:=150))
                VistaBusqueda.Columns.Add(GrillaDevExpress.CrearColumna("EsAlmacen", "Almacen", anchoColumna:=100))
            Case TipoBusqueda.Cuentas, TipoBusqueda.CuentasdeCartera, TipoBusqueda.CuentasdeMovimiento, TipoBusqueda.CuentasdeProveedores
                VistaBusqueda.Columns.Add(GrillaDevExpress.CrearColumna("CodCuenta", "Codigo", anchoColumna:=100, alineacion:=AlinearTexto.Izquierda, autoAncho:=False))
                VistaBusqueda.Columns.Add(GrillaDevExpress.CrearColumna("NomCuenta", "Nombre", autoAncho:=True))


            Case TipoBusqueda.TipoActivo
                VistaBusqueda.Columns.Add(GrillaDevExpress.CrearColumna("Codigo", "Codigo", anchoColumna:=100, alineacion:=AlinearTexto.Derecha))
                VistaBusqueda.Columns.Add(GrillaDevExpress.CrearColumna("Nombre", "Nombre", autoAncho:=True))
                VistaBusqueda.Columns.Add(GrillaDevExpress.CrearColumna("VidaUtil", "Vida Util", anchoColumna:=70))
                VistaBusqueda.Columns.Add(GrillaDevExpress.CrearColumna("VidaUtilNIIF", "Vida Util (NIIF)", anchoColumna:=70))
                VistaBusqueda.Columns.Add(GrillaDevExpress.CrearColumna("Vigente", "Vigente"))
            Case TipoBusqueda.GrupoActivo
                VistaBusqueda.Columns.Add(GrillaDevExpress.CrearColumna("CodGrupo", "Codigo", anchoColumna:=100, alineacion:=AlinearTexto.Derecha))
                VistaBusqueda.Columns.Add(GrillaDevExpress.CrearColumna("Descripcion", "Nombre", autoAncho:=True))
                VistaBusqueda.Columns.Add(GrillaDevExpress.CrearColumna("Vigente", "Vigente"))
            Case TipoBusqueda.DocumentosContables
                VistaBusqueda.Columns.Add(GrillaDevExpress.CrearColumna("Doc_Secuencial", "Secuencial", anchoColumna:=75, visible:=False))
                VistaBusqueda.Columns.Add(GrillaDevExpress.CrearColumna("nombre", "Documento", anchoColumna:=110))
                VistaBusqueda.Columns.Add(GrillaDevExpress.CrearColumna("Doc_Tercero", "Tercero", autoAncho:=True))
                VistaBusqueda.Columns.Add(GrillaDevExpress.CrearColumna("Doc_Valor", "Valor", anchoColumna:=120, formato:="n2", tipo:=DevExpress.Utils.FormatType.Numeric, alineacion:=AlinearTexto.Derecha))
                VistaBusqueda.Columns.Add(GrillaDevExpress.CrearColumna("Doc_FechaDoc", "Fecha", alineacion:=AlinearTexto.Centro))
            Case TipoBusqueda.Oficinas
                VistaBusqueda.Columns.Add(GrillaDevExpress.CrearColumna("NumOficina", "Codigo", anchoColumna:=100, alineacion:=AlinearTexto.Derecha))
                VistaBusqueda.Columns.Add(GrillaDevExpress.CrearColumna("NomOficina", "Nombre", autoAncho:=True))
                VistaBusqueda.Columns.Add(GrillaDevExpress.CrearColumna("Direccion", "Direccion", anchoColumna:=170))
            Case TipoBusqueda.FormaAdquisicion
                VistaBusqueda.Columns.Add(GrillaDevExpress.CrearColumna("CodForma", "Codigo", anchoColumna:=100, alineacion:=AlinearTexto.Derecha))
                VistaBusqueda.Columns.Add(GrillaDevExpress.CrearColumna("NomForma", "Nombre", autoAncho:=True))
            Case TipoBusqueda.CentroCosto
                VistaBusqueda.Columns.Add(GrillaDevExpress.CrearColumna("Cod_CentroCosto", "Codigo", anchoColumna:=100, alineacion:=AlinearTexto.Derecha))
                VistaBusqueda.Columns.Add(GrillaDevExpress.CrearColumna("Nom_CentroCosto", "Nombre", autoAncho:=True))
                VistaBusqueda.Columns.Add(GrillaDevExpress.CrearColumna("Responsable", "Responsable", anchoColumna:=150))
            Case TipoBusqueda.FacturaActivo
                VistaBusqueda.Columns.Add(GrillaDevExpress.CrearColumna("CodFact", "Codigo", anchoColumna:=100, alineacion:=AlinearTexto.Derecha))
                VistaBusqueda.Columns.Add(GrillaDevExpress.CrearColumna("NumFact", "Numero", autoAncho:=True))
                VistaBusqueda.Columns.Add(GrillaDevExpress.CrearColumna("FechaFac", "Fecha Fac"))
                VistaBusqueda.Columns.Add(GrillaDevExpress.CrearColumna("Observaciones", "Observaciones", anchoColumna:=160))
            Case TipoBusqueda.Condicion
                VistaBusqueda.Columns.Add(GrillaDevExpress.CrearColumna("Codigo", "Codigo", anchoColumna:=100, alineacion:=AlinearTexto.Derecha))
                VistaBusqueda.Columns.Add(GrillaDevExpress.CrearColumna("Nombre", "Descripcion", autoAncho:=True))
            Case TipoBusqueda.Activo
                VistaBusqueda.Columns.Add(GrillaDevExpress.CrearColumna("CodACT", "Codigo", anchoColumna:=100, alineacion:=AlinearTexto.Derecha))
                VistaBusqueda.Columns.Add(GrillaDevExpress.CrearColumna("Nombre", "Descripcion", autoAncho:=True))
                VistaBusqueda.Columns.Add(GrillaDevExpress.CrearColumna("responsable", "Responsable", anchoColumna:=150))
            Case TipoBusqueda.Ninguna
                If Not IsNothing(ListaColumnas) Then
                    For Each column In ListaColumnas
                        VistaBusqueda.Columns.Add(column)
                    Next
                Else
                    If Not IsNothing(DatosEnMemoria) Then
                        If PorTipo = TipoBusqueda.Ninguna Then
                            'VistaBusqueda.OptionsView.ColumnAutoWidth = True
                            Dim indice As Integer = 0
                            For Each columna As DataColumn In Datos.Columns
                                indice += 1
                                Dim anchoColumna As Integer = 0
                                Dim autoancho As Boolean = False
                                If columna.DataType = Type.GetType("System.String") Then
                                    autoancho = True
                                Else
                                    autoancho = False
                                    anchoColumna = 60
                                End If

                                If columna.ColumnName = "Codigo" Then
                                    VistaBusqueda.Columns.Add(GrillaDevExpress.CrearColumna("Codigo", "Codigo", autoAncho:=True, alineacion:=AlinearTexto.Derecha))

                                Else
                                    VistaBusqueda.Columns.Add(GrillaDevExpress.CrearColumna(columna.ColumnName, "Descripcion", autoAncho:=False))
                                End If

                            Next
                            VistaBusqueda.Columns(0).BestFit()
                            VistaBusqueda.Columns(0).OptionsColumn.FixedWidth = True
                            'VistaBusqueda.Columns(1).BestFit()
                        End If
                    End If

                End If

        End Select

        AddHandler dgwresultados.KeyDown, AddressOf dgwresultados_KeyDown
        AddHandler VistaBusqueda.FocusedRowChanged, AddressOf cambioSeleccion

    End Sub

    Public Function ListarDatos(ByVal tipo As TipoBusqueda, Optional filtro As String = "") As DataTable
        Dim comando As String = DefineComando(tipo)
        Dim Tb As DataTable = Consultar(comando, _Conexion)

        Return Tb
    End Function
    Public Shared Function DefineComando(ByVal tipo As TipoBusqueda) As String
        Dim comando As String = ""
        Select Case tipo
            Case TipoBusqueda.PersonaEmpleado
                comando = "SELECT        Identificacion, RTRIM(LTRIM(RTRIM(LTRIM(PNombre)) + ' ' + RTRIM(LTRIM(SNombre)) + ' ' + RTRIM(LTRIM(PApellido)) + ' ' + RTRIM(LTRIM(SApellido)))) + CASE (isnull(NombreComercial, '')) 
                         WHEN '' THEN ' ' ELSE ' / ' + NombreComercial END AS nombre, CAST(0 AS varchar) AS estab, Email, CAST(NumCelular AS varchar) AS numcelular
                        FROM            G_Clientes  AS [ + ]  where empleado = 1
                        UNION
                        SELECT        CAST(cl.Identificacion AS varchar) AS Identificacion, cl.PNombre + ' ' + cl.SNombre + ' ' + cl.PApellido + ' ' + cl.SApellido + ' / ' + ce.Nombre AS nombre, CAST(ce.CodigoEst AS varchar) AS estab, cl.Email, 
                                                 CAST(cl.NumCelular AS varchar) AS numcelular
                        FROM            G_Clientes AS cl INNER JOIN
                         G_ClientesEstab AS ce ON cl.Identificacion = ce.Cliente where cl.empleado = 1"
            Case TipoBusqueda.Persona
                comando = "SELECT Identificacion  as   Identificacion, RTRIM(LTRIM(RTRIM(LTRIM(PNombre)) + ' ' + RTRIM(LTRIM(SNombre)) + ' ' + RTRIM(LTRIM(PApellido)) + ' ' + RTRIM(LTRIM(SApellido)))) + case(isnull(NombreComercial,'')) when '' then ' ' else ' / '+ NombreComercial end AS nombre, cast(0 as varchar) as estab, email, cast(numcelular as varchar) as numcelular from g_clientes " + "union   SELECT   cast(Identificacion as varchar) as  Identificacion, PNombre + ' ' + SNombre + ' ' + PApellido + ' ' + SApellido + ' / ' + ce.nombre as nombre, cast(codigoest as varchar) as estab, cl.email, cast(numcelular as varchar) as numcelular FROM g_clientes cl inner join G_ClientesEstab ce on cl.identificacion = ce.cliente"
                'comando = "SELECT     CAST(Identificacion AS varchar) AS Identificacion, RTRIM(LTRIM(RTRIM(LTRIM(PNombre)) + ' ' + RTRIM(LTRIM(SNombre)) + ' ' + RTRIM(LTRIM(PApellido))                       + ' ' + RTRIM(LTRIM(SApellido)))) + CASE (isnull(NombreComercial, '')) WHEN '' THEN ' ' ELSE ' / ' + NombreComercial END AS nombre, CAST(0 AS varchar) AS estab,                       Email, CAST(NumCelular AS varchar) AS numcelular, Barrio, Direccion, Tel1, Tel2 FROM         G_Clientes AS [ + ] UNION SELECT     CAST(cl.Identificacion AS varchar) AS Identificacion, cl.PNombre + ' ' + cl.SNombre + ' ' + cl.PApellido + ' ' + cl.SApellido + ' / ' + ce.Nombre AS nombre,  CAST(ce.CodigoEst AS varchar) AS estab, cl.Email, CAST(cl.NumCelular AS varchar) AS numcelular, cl.Barrio,  cl.Direccion, Tel1, Tel2 FROM         G_Clientes AS cl INNER JOIN                      G_ClientesEstab AS ce ON cl.Identificacion = ce.Cliente"
            Case TipoBusqueda.Proveedores
                comando = "SELECT   Identificacion as   Identificacion, RTRIM(LTRIM(RTRIM(LTRIM(PNombre)) + ' ' + RTRIM(LTRIM(SNombre)) + ' ' + RTRIM(LTRIM(PApellido)) + ' ' + RTRIM(LTRIM(SApellido)))) + case(isnull(NombreComercial,'')) when '' then ' ' else ' / '+ NombreComercial end AS nombre, cast(0 as varchar) as estab, email, cast(numcelular as varchar) as numcelular from g_clientes " + "union SELECT    cast(Identificacion as varchar) as  Identificacion, PNombre + ' ' + SNombre + ' ' + PApellido + ' ' + SApellido + ' / ' + ce.nombre as nombre, cast(codigoest as varchar) as estab, cl.email, cast(numcelular as varchar) as numcelular FROM g_clientes cl inner join G_ClientesEstab ce on cl.identificacion = ce.cliente WHERE     (proveedor = 1) "
            Case TipoBusqueda.Productos
                comando = "SELECT     codigo, Nombre, Referencia FROM         IN_Producto"
            Case TipoBusqueda.DocumentosInventario
            Case TipoBusqueda.Ubicaciones
                comando = "SELECT     CodUbicacion, NomUbPrin, CAST(Sucursal AS varchar) + '- ' + " &
                                            "(SELECT     NomOficina " &
                                            "FROM SEGURIDAD.dbo.Oficinas " &
                                                     " WHERE      (NumOficina = AC_ubicaciones.Sucursal) AND (NumEmpresa = '" & DatosEmp.NumEmpresa & "')) AS Sucursal " &
                            "FROM         AC_ubicaciones"
            Case TipoBusqueda.UbicacionesEspecificas
                comando = "SELECT    AC_UbEsp.Ub_Principal, AC_UbEsp.Ub_Especifica, (SELECT     NomUbPrin " &
                                            "FROM AC_ubicaciones " &
                                                       " WHERE      (CodUbicacion = AC_UbEsp.Ub_Principal)) AS Ub_PrincipalNom,  " &
                                                        "(SELECT     NomUbPrin " &
                                            "FROM AC_ubicaciones " &
                                                       " WHERE      (CodUbicacion = AC_UbEsp.Ub_Especifica)) AS Ub_EspecificaNom,  " &
                                                         "NomUbEsp, CASE (EsAlmacen)  " &
                                                  "WHEN 1 THEN 'Si' ELSE 'No' END AS EsAlmacen " &
                            "FROM         AC_UbEsp"
            Case TipoBusqueda.Cuentas
                comando = "SELECT     CodCuenta, NomCuenta FROM         CT_PlandeCuentas order by CodCuenta"
            Case TipoBusqueda.CuentasdeMovimiento
                comando = "SELECT     CodCuenta, NomCuenta FROM         CT_PlandeCuentas WHERE Esdemovimiento = 1  order by CodCuenta"
            Case TipoBusqueda.CuentasdeCartera
                comando = "SELECT     CodCuenta, NomCuenta FROM         CT_PlandeCuentas WHERE Esdemovimiento = 1  AND Detalla ='C' order by CodCuenta"
            Case TipoBusqueda.CuentasdeProveedores
                comando = "SELECT     CodCuenta, NomCuenta FROM         CT_PlandeCuentas WHERE Esdemovimiento = 1  AND Detalla ='P' order by CodCuenta"
            Case TipoBusqueda.TipoActivo
                comando = "SELECT     Codigo, Nombre, VidaUtil, VidaUtilNIIF, case (Vigente) when 1 then 'Si' else 'No' end as vigente FROM         AC_Tipos"
            Case TipoBusqueda.GrupoActivo
                comando = "SELECT     CodGrupo, Descripcion, Vigente FROM         AC_Grupos"
            Case TipoBusqueda.DocumentosContables
                comando = "SELECT     Doc_Secuencial, CAST(Doc_TipoComp AS varchar) + '-' + CAST(Doc_IdComp AS varchar) + '-' + CAST(Doc_NumDocumento AS varchar) AS nombre, " &
                                              "CAST(Doc_Tercero AS varchar) + ' - ' + " &
                        "(SELECT     PApellido + ' ' + SApellido + ' ' + PNombre + ' ' + SNombre AS Expr1 " &
                                        "FROM G_Clientes " &
                                                   " WHERE      (Identificacion = CT_Documentos.Doc_Tercero)) AS Doc_Tercero, Doc_Valor, Doc_FechaDoc " &
                                        "FROM CT_Documentos " &
                        "WHERE     (Doc_Anulado = 0) AND (Doc_Actualizado = 1) "
                '"WHERE     (Doc_Anulado = 0) AND (Doc_Actualizado = 1) and doc_secuencial = 157086 "
            Case TipoBusqueda.Oficinas
                comando = "SELECT   NumOficina, NomOficina, Estado, Direccion  FROM  Oficinas WHERE NumEmpresa = " & VgEmpresa
            Case TipoBusqueda.FormaAdquisicion
                comando = "SELECT     CodForma, NomForma FROM         AC_FormaAdq "
            Case TipoBusqueda.CentroCosto
                comando = "SELECT     Cod_CentroCosto, Nom_CentroCosto, Responsable FROM  CT_CentroCostos"
            Case TipoBusqueda.FacturaActivo
                comando = "SELECT     CodFact, NumFact, FechaFac, Proveedor, Observaciones, FechaContabilizacion, DocContab FROM AC_FacComp"
            Case TipoBusqueda.Condicion
                comando = "SELECT     Codigo, Nombre FROM         AC_Condicion"
            Case TipoBusqueda.Activo
                comando = "SELECT    CodACT, Nombre, Tipo, NumPlaca, Descripcion, Marca, Modelo, NumSerie, Referencia, Capacidad, Observaciones, Ccosto, UbActual, Condicion, responsable, " &
                "FormaAdquisicion, FacAdquisicion, FechaEntServicio, TieneGarantia, FecVenGar, DocIngreso, FechaIngreso, UsrCrea, Terminal, FechaCrea, UsrMod, FechaMod, " &
                "avaluosPdte, SegurosPolizasPdte, UbActualPrin FROM         AC_Catalogo "
            Case TipoBusqueda.Ninguna
                If IsNothing(_consultaSQL) Then
                Else
                    comando = _consultaSQL
                End If
        End Select
        Return comando
    End Function


    Private Sub MostraDatos()
        Dim Dv As DataView, Comando As String = ""
        If PorTipo <> TipoBusqueda.Ninguna Then
            _consultaSQL = BusquedaSamit.DefineComando(PorTipo)
        End If

        'Datos = SMT_AbrirRecordSet(SMTConexMod, _consultaSQL)
        If Datos.Rows.Count = 0 Then Exit Sub
        Dv = New DataView(Datos)
        Dv.Sort = Datos.Columns(0).ColumnName & " ASC"
        If _txtFiltro <> "" Then
            _txtFiltro = Datos.Columns(0).ColumnName & " like '%" & _txtFiltro & "%'"
            Dv.RowFilter = _txtFiltro
        End If



        If Dv.Count > 0 Then

            If PorTipo = TipoBusqueda.Ninguna Then
                VistaBusqueda.OptionsView.ColumnAutoWidth = True
                Dim indice As Integer = 0
                For Each columna As DataColumn In Datos.Columns
                    indice += 1
                    Dim anchoColumna As Integer = 0
                    Dim autoancho As Boolean = False
                    If columna.DataType = Type.GetType("System.String") Then
                        autoancho = True
                    Else
                        autoancho = False
                        anchoColumna = 60
                    End If
                    VistaBusqueda.Columns.Add(GrillaDevExpress.CrearColumna(columna.ColumnName, columna.ColumnName, visible:=(indice > 1), autoAncho:=autoancho, anchoColumna:=anchoColumna))
                Next
            End If

            'dgwresultados.DataSource = Datosq
            dgwresultados.DataSource = Dv
            lbnumeroregistros.Text = "Registros: " & Dv.Count
        Else
            lbcomentario.Text = "No hay resultados"
        End If


    End Sub
    Dim intervalos As Integer = 0
    Dim tiempomaximo As Integer
    Dim contador As Timer = New Timer With {.Interval = 500}
    Dim _filtro As String
    Dim registros As Decimal
    Private Sub Contado_tick()
        dgwresultados.DataSource = ProcesFiltrarDatos()
    End Sub
    Private Sub FiltrarDatos(ByVal filtro As String)
        _filtro = filtro
        If IsNothing(Datos) Then
            registros = 0
        Else
            registros = Datos.Rows.Count
        End If
        If registros > 10000 Then
            intervalos = 0
            tiempomaximo = 10
            contador.Enabled = True
        Else
            intervalos = 0
            tiempomaximo = 2
            contador.Enabled = True
        End If
    End Sub
    Private Function ProcesFiltrarDatos() As DataView
        Try
            txbcampo.Text = txbcampo.Text.Trim

            Dim dv As New DataView(Datos, Grilla.CrearFiltro(Datos, txbcampo.Text), "", DataViewRowState.CurrentRows)
            contador.Stop()
            'dv.RowFilter = Grilla.CrearFiltro(Datos, txbcampo.Text)
            lbnumeroregistros.Text = "Registros: " & FormatNumber(dv.Count, 0, TriState.True, TriState.False, TriState.True)
            Return dv

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try

    End Function
    Private Sub MostrarResultadoFiltro(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs)
        Try
            Dim dv As DataView = CType(e.Result, DataView)
            lbnumeroregistros.Text = "Registros: " & FormatNumber(dv.Count, 0, TriState.True, TriState.False, TriState.True)
            dgwresultados.DataSource = dv
        Catch ex As Exception
            ' MessageBox.Show(ex.Message)
        End Try

    End Sub
    Dim _teclaValida As Boolean

    Private Sub BusquedaSamit_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        _teclaValida = False
        contador.Stop()
        Select Case e.KeyData
            Case Keys.Back
                Dim valido As Boolean = True
                If txbcampo.Text.Trim.Length = 0 Then Exit Sub
                If Not IsNothing(Formulario) Then
                    If Formulario.Tag = True Then
                        valido = False
                    End If
                End If
                If valido Then
                    Try
                        If _primerEntradaLibre And _txtFiltro <> "" Then
                            txbcampo.Text = ""
                            _primerEntradaLibre = False
                        Else
                            txbcampo.Text = txbcampo.Text.Remove(txbcampo.Text.Length - 1, 1)
                        End If
                        _teclaValida = True
                    Catch
                    End Try
                End If
            Case Keys.Escape
                Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
                Me.Close()
            Case Keys.F11
                If Me.WindowState = FormWindowState.Maximized Then
                    Me.WindowState = FormWindowState.Normal
                Else
                    Me.WindowState = FormWindowState.Maximized
                End If

        End Select


    End Sub
    Private Sub BusquedaSamit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        Dim valido As Boolean = True
        If Not IsNothing(Formulario) Then
            If Formulario.Tag = True Then
                valido = False
            End If
        End If
        If valido Then

            Dim tecla As Char = e.KeyChar
            If Not tecla = ControlChars.Back Then
                Try
                    txbcampo.Text += tecla.ToString()
                    'FiltrarDatos(txbcampo.Text)
                Catch ex As Exception
                End Try
            End If

        End If
    End Sub

    Private Sub dgwresultados_DoubleClick(sender As Object, e As EventArgs) Handles dgwresultados.DoubleClick
        dgwresultados_KeyDown(sender, New System.Windows.Forms.KeyEventArgs(Keys.Enter))
    End Sub
    Private Sub dgwresultados_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles dgwresultados.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                e.SuppressKeyPress = True
                ValorAlternativoDevuelto = VistaBusqueda.GetFocusedDataRow()(1).ToString()
                ValorSeleccionado = VistaBusqueda.GetFocusedDataRow()(0).ToString()
                FilaDevuelta = VistaBusqueda.GetFocusedDataRow()
                Me.DialogResult = System.Windows.Forms.DialogResult.OK
                Me.Hide()
            Catch ex As Exception
            End Try

        End If
    End Sub

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BusquedaSamit))
        Me.statusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lbnumeroregistros = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbcomentario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.progreso = New System.Windows.Forms.ToolStripProgressBar()
        Me.txbcampo = New System.Windows.Forms.TextBox()
        Me.dgwresultados = New DevExpress.XtraGrid.GridControl()
        Me.VistaBusqueda = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btnAccion = New System.Windows.Forms.Button()
        Me.pnlContenedor = New System.Windows.Forms.Panel()
        Me.tiempo = New System.Windows.Forms.Timer(Me.components)
        Me.statusStrip1.SuspendLayout()
        CType(Me.dgwresultados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlContenedor.SuspendLayout()
        Me.SuspendLayout()
        '
        'statusStrip1
        '
        Me.statusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lbnumeroregistros, Me.lbcomentario, Me.progreso})
        Me.statusStrip1.Location = New System.Drawing.Point(0, 430)
        Me.statusStrip1.Name = "statusStrip1"
        Me.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.statusStrip1.Size = New System.Drawing.Size(816, 22)
        Me.statusStrip1.TabIndex = 3
        Me.statusStrip1.Text = "statusStrip1"
        '
        'lbnumeroregistros
        '
        Me.lbnumeroregistros.AutoSize = False
        Me.lbnumeroregistros.Name = "lbnumeroregistros"
        Me.lbnumeroregistros.Size = New System.Drawing.Size(448, 17)
        Me.lbnumeroregistros.Spring = True
        Me.lbnumeroregistros.Text = "..."
        Me.lbnumeroregistros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbcomentario
        '
        Me.lbcomentario.Name = "lbcomentario"
        Me.lbcomentario.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lbcomentario.Size = New System.Drawing.Size(353, 17)
        Me.lbcomentario.Text = "Digite el Criterio de busqueda, separado por espacios si son varios"
        '
        'progreso
        '
        Me.progreso.Maximum = 1
        Me.progreso.Name = "progreso"
        Me.progreso.Size = New System.Drawing.Size(100, 16)
        '
        'txbcampo
        '
        Me.txbcampo.Dock = System.Windows.Forms.DockStyle.Top
        Me.txbcampo.Enabled = False
        Me.txbcampo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbcampo.Location = New System.Drawing.Point(0, 0)
        Me.txbcampo.Name = "txbcampo"
        Me.txbcampo.ReadOnly = True
        Me.txbcampo.Size = New System.Drawing.Size(816, 26)
        Me.txbcampo.TabIndex = 2
        Me.txbcampo.TabStop = False
        '
        'dgwresultados
        '
        Me.dgwresultados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgwresultados.Location = New System.Drawing.Point(0, 26)
        Me.dgwresultados.MainView = Me.VistaBusqueda
        Me.dgwresultados.Name = "dgwresultados"
        Me.dgwresultados.Size = New System.Drawing.Size(816, 351)
        Me.dgwresultados.TabIndex = 21
        Me.dgwresultados.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VistaBusqueda})
        '
        'VistaBusqueda
        '
        Me.VistaBusqueda.GridControl = Me.dgwresultados
        Me.VistaBusqueda.Name = "VistaBusqueda"
        '
        'btnAccion
        '
        Me.btnAccion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAccion.FlatAppearance.BorderSize = 0
        Me.btnAccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAccion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAccion.Location = New System.Drawing.Point(223, 21)
        Me.btnAccion.Name = "btnAccion"
        Me.btnAccion.Size = New System.Drawing.Size(580, 20)
        Me.btnAccion.TabIndex = 20
        Me.btnAccion.Text = "Registrar"
        Me.btnAccion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAccion.UseVisualStyleBackColor = True
        '
        'pnlContenedor
        '
        Me.pnlContenedor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlContenedor.Controls.Add(Me.btnAccion)
        Me.pnlContenedor.Location = New System.Drawing.Point(1, 383)
        Me.pnlContenedor.Name = "pnlContenedor"
        Me.pnlContenedor.Size = New System.Drawing.Size(815, 44)
        Me.pnlContenedor.TabIndex = 22
        '
        'tiempo
        '
        Me.tiempo.Enabled = True
        Me.tiempo.Interval = 1000
        '
        'BusquedaSamit
        '
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(816, 452)
        Me.Controls.Add(Me.pnlContenedor)
        Me.Controls.Add(Me.dgwresultados)
        Me.Controls.Add(Me.statusStrip1)
        Me.Controls.Add(Me.txbcampo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BusquedaSamit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda SAMIT SQL"
        Me.statusStrip1.ResumeLayout(False)
        Me.statusStrip1.PerformLayout()
        CType(Me.dgwresultados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlContenedor.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Friend WithEvents txbcampo As System.Windows.Forms.TextBox
    Private statusStrip1 As System.Windows.Forms.StatusStrip
    Private lbnumeroregistros As System.Windows.Forms.ToolStripStatusLabel
    Private lbcomentario As System.Windows.Forms.ToolStripStatusLabel

    Private Sub BusquedaSamit_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down Or e.KeyCode = Keys.PageDown Or e.KeyCode = Keys.PageUp Then
            Exit Sub
        End If
        contador.Start()
    End Sub

    Private Sub BusquedaSamit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        progreso.Maximum = 3

        If Not IsNothing(Formulario) Then
            Me.Icon = My.Resources.SamitIcono16x16
            Me.ShowIcon = True
            dgwresultados.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right Or AnchorStyles.Bottom
            Me.Height -= pnlContenedor.Height
            dgwresultados.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
            Me.Height += Formulario.Height
            pnlContenedor.Dock = DockStyle.Fill
            pnlContenedor.Controls.Clear()
            pnlContenedor.Controls.Add(Formulario)
            Formulario.Dock = DockStyle.Fill
            btnAccion.Visible = False
            pnlContenedor.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
            dgwresultados.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right Or AnchorStyles.Bottom
        Else
            pnlContenedor.Visible = False
        End If

        AddHandler contador.Tick, AddressOf Contado_tick
    End Sub

    Private Sub tiempo_Tick(sender As Object, e As EventArgs) Handles tiempo.Tick

    End Sub

    Private Sub cambioSeleccion(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs)
        Dim eventos As BusquedaSamitEventArgs = New BusquedaSamitEventArgs()
        If VistaBusqueda.FocusedRowHandle <= 0 Then Exit Sub
        eventos.ID = VistaBusqueda.GetFocusedDataRow()(0).ToString()
        eventos.Texto = VistaBusqueda.GetFocusedDataRow()(1).ToString()
        RaiseEvent CambioId(Me, eventos)
    End Sub

    Private Sub txbcampo_TextChanged(sender As Object, e As EventArgs) Handles txbcampo.TextChanged
        contador.Start()
        progreso.Value = 1
    End Sub


    Public Shared Function Consultar(SQL As String, MiConex As SqlConnection) As DataTable
        Dim tabla As New DataTable()
        Try
            tabla = SMT_AbrirTabla(MiConex, SQL)
            Return tabla
        Catch e As Exception
            MensajedeError(e.Message)
            Return Nothing
        Finally
        End Try

    End Function


    Private Sub dgwresultados_Click(sender As Object, e As EventArgs) Handles dgwresultados.Click

    End Sub
End Class
Public Class BusquedaSamitEventArgs
    Inherits EventArgs
    Public Property ID As String
    Public Property Texto As String
End Class