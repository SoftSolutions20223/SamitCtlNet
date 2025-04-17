Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports SamitCtlNet.Clseguridad
Imports System.Drawing
Imports System.ComponentModel
Imports SamitCtlNet.SamitCtlNet.ClSmtImagenes
Imports DevExpress.XtraEditors
Public Module ModGeneral
    Public Enum TipoBusqueda
        ''' <summary>No se realiza ninguna consulta (test).</summary>
        Ninguna = 0
        ''' <summary>Consulta de personas.</summary>
        Persona = 1
        ''' <summary>Consulta de productos.</summary>
        Productos = 2
        ''' <summary>Consulta de documentos de Inventario.</summary>
        DocumentosInventario = 3
        ''' <summary>Consulta de ubicaciones.</summary>
        Ubicaciones = 4
        ''' <summary>Consulta de cuentas.</summary>
        Cuentas = 5
        ''' <summary>Consulta de Tipo Activos.</summary>
        TipoActivo = 6
        ''' <summary>Consulta de Grupo Activos.</summary>
        GrupoActivo = 7
        ''' <summary>Consulta de documentos de Contabilidad.</summary>
        DocumentosContables = 8
        ''' <summary>Consulta de documentos de Contabilidad.</summary>
        Oficinas = 9
        ''' <summary>Consulta de ubicaciones especificas.</summary>
        UbicacionesEspecificas = 10
        ''' <summary>Consulta de Formas de Adquicicion.</summary>
        FormaAdquisicion = 11
        ''' <summary>Consulta de Proveedores.</summary>
        Proveedores = 12
        ''' <summary>Consulta de Centro de Costos.</summary>
        CentroCosto = 13
        ''' <summary>Consulta de Facturas de activos</summary>
        FacturaActivo = 14
        ''' <summary>Consulta de Condiciones de activos</summary>
        Condicion = 15
        ''' <summary>Consulta de Condiciones de activos</summary>
        Activo = 16
        CuentasdeMovimiento = 17
        CuentasdeCartera = 18
        CuentasdeProveedores = 19
        ''' <summary>Consulta de personas solo Empleados.</summary>
        PersonaEmpleado = 20
    End Enum
    Friend Enum TipoUsuairo
        Administrador = 1
        Comun = 2
        Invitado = 3
    End Enum
    Friend Structure DatosUsuario
        Dim Login As String
        Dim PWD As String
        Dim Numero As Integer
        Dim Tipo As TipoUsuairo
        Dim RolIngreso As Integer
        Dim TranAuto() As Long
        Dim CodigodeSesion As Long
    End Structure
    Friend GUsuario As DatosUsuario
    Friend GTransacciones() As DatosTransacciones
    Friend GTransacccionesEnServidor() As DatosTransacciones
    Public NumerodeModulo As Integer = 0
    Friend Dll As New SamitCtlNet
    Friend FrmConex As New FrmControlConex
    Friend DatosEmp As DatosEmpresa
    Friend FechaW As Date
    Friend FechaB As Date
    Friend FechaSys As Date
    Friend BdTrabajo As String = ""
    Friend VgOficina As Integer
    Friend VgEmpresa As Integer
    Friend VgNombreTerminalUsuario As String
    Friend VgLoginUsuario As String
    Friend VgUsuarioWindows As String
    Friend VgNumeroRolIngreso As Integer
    Friend VgNombreRolIngreso As String
    Public LaConexionEstaActiva As Boolean
    Public MiBarraEstado As Object
    Public ColorDeFondoEntraControl As Color = Color.Black
    Public HayConexionConSRV As Boolean


    Public Enum TipoConsulta
        Cuentas = 1
        terceros = 2
    End Enum
    Public Enum FormaBusqueda
        Buscar_Codigo = 0
        Buscar_Nombre = 1
    End Enum
    Public Enum Estado_Cuentas
        Vigente = 1
        Bloqueada = 2
        Inactiva = 3
        Todos_los_Estados = 4
        Todos_Excepto_Bloqueadas = 5
    End Enum
    Public Enum Caracteristicas_Cuentas
        PorCobrar = 1
        PorPagar = 2
        DeRetencion = 3
        DeAjustesPorInflacion = 4
        Todas_Las_Caracteristicas = 5
        DeTerceros = 6
        DeCapital = 7
        DeDisponible = 8
        TodasExceptoAjustesXInflación = 9
        DeBancos = 10
        DeMovimiento = 11
        DeManejoCentroCOSTOS = 12
        DeIVA = 13
    End Enum
    Public Enum Tipo_Imagen_Boton
        Salir = 0
        InformeFinanciero = 1
        BuscarArchivo = 2
        Cheque1 = 3
        Cheque2 = 4
        Ayuda = 5
        CaraPersona = 6
        Guardar = 7
        Eliminar = 8
        Imprimir = 9
        Salir2 = 10
        Limpiar = 11
        Ver1 = 12
        Ver2 = 13
        Seleccionar = 14
        Pagar = 15
        Calculadora1 = 16
        Calculadora2 = 17
        Magic = 18
        Editar = 19
        Indicador_Financiero = 20
        IconoReporte = 21
        ImagenesYColores = 22
        Cargar = 23
        Diagrama = 24
        Directorios_Subgrupos = 25
        Mano = 26
        Deshacer = 27
        Gafas = 28
        camara = 29
        Exportar_Excel_1 = 30
        Exportar_Excel_2 = 31
        Exportar_PDF = 32
        Equis = 33
        Cancelar = 34
        Continuar = 35
        Exportar_Excel_3 = 36
        SignoMas = 37
    End Enum
    Public Enum TipoDatoBusqueda
        Departamentos = 0
        Municipios = 1
        Paises = 2
        Tipo_Documento = 3
        Genero = 4
        ActividadesEconomicas = 5
        Usuarios = 6
        FormasPago = 7
        Vendedores = 8
        Establecimientos = 9
    End Enum

    Public Structure Datos_Calculo_Digito
        Dim Factor As Integer
        Dim Digito_Nit As Integer
    End Structure
    Public Sub PremiteSoloNumeros(e As KeyPressEventArgs)
        'Prueba de Comentario
        If Not (Char.IsNumber(e.KeyChar)) AndAlso (e.KeyChar <> Convert.ToChar(Keys.Back)) Then
            e.Handled = True
        End If

    End Sub
    Public Sub PremiteSoloNumerosConPunto(e As KeyPressEventArgs)
        If Not (Char.IsNumber(e.KeyChar)) AndAlso (e.KeyChar <> Convert.ToChar(Keys.Back)) AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If

    End Sub

    Public Function Existe_EN_BD_Transaccion(Transaccion As Long, Optional ConsultaEnMemoria As Boolean = True, Optional ByRef PosicionTransaccion As Long = 0) As Boolean
        On Error GoTo Err_Existe_EN_BD_Transaccion
        Dim TblTran As DataTable, TxtSQL As String, X As Long

        Existe_EN_BD_Transaccion = False
        If Not ConsultaEnMemoria Then
            TxtSQL = "Select NumTransaccion From Transacciones Where NumTransaccion=" & Transaccion
            TblTran = SMT_AbrirTabla(SMTConex, TxtSQL)
            If TblTran.Rows.Count = 1 Then Existe_EN_BD_Transaccion = True
        Else
            For X = 0 To UBound(GTransacccionesEnServidor)
                If GTransacccionesEnServidor(X).Codigo = Transaccion Then
                    Existe_EN_BD_Transaccion = True
                    PosicionTransaccion = X

                    Exit For
                End If
            Next X
        End If
        Exit Function
Exit_Existe_EN_BD_Transaccion:
        TblTran = Nothing
        Exit Function
Err_Existe_EN_BD_Transaccion:
        MensajedeError("Consultando existencia de una Transacción")
        Resume Exit_Existe_EN_BD_Transaccion
    End Function
    Public Sub MensajedeError(Optional Ubicacion As String = "")
        Dim Texto As String
        If Ubicacion <> "" Then
            Texto = "Ubicación              :  " & Ubicacion & "  " & (Chr(13))
        Else
            Texto = ""
        End If
        If Err.Number <> 0 Then
            '"Numero de Error   :  " & Err.Number & "  " & (Chr(13))
            XtraMessageBox.Show("Mensaje del Sistema." & (Chr(10) + Chr(13)) & Chr(10) & _
                Texto & _
                "Descripción           :  " & Err.Description & "  " & (Chr(13)) & _
                "Origen                  :  " & Err.Source & "  " & _
                (Chr(13)), "Mensaje SAMIT ", MessageBoxButtons.OK)
        End If
        Err.Clear()
        Cursor.Current = Cursors.WaitCursor

    End Sub
    Public Function Convert_BIT(Valor As Boolean) As Integer
        Convert_BIT = IIf(Valor = True, 1, 0)
    End Function
    Public Function Traer_FechaDelServidor() As DateTime
        On Error GoTo Err_Traer_FechaDelServidor
        Dim Tbl As DataTable, Dr As DataRow
        Traer_FechaDelServidor = Now

        Tbl = SMT_AbrirRecordSet(SMTConex, "select 'FechaSys' = getdate()")
        If Tbl.Rows.Count = 1 Then
            Dr = Tbl.Rows(0)
            FechaSys = FormatDateTime(Dr("FechaSys"), DateFormat.GeneralDate)
            'FechaSys = Traer_FechaDelServidor
            Return FechaSys
        End If
        Tbl.Clear()
        Tbl.Dispose()

        Exit Function
Err_Traer_FechaDelServidor:
    End Function
    Public Function Calculo_Digito_Verificacion(Nit As Decimal) As Byte
        Dim X As Byte, Matrix() As Datos_Calculo_Digito = Nothing
        Dim TextoNit As String, LargoNit As Byte, Total1 As Decimal, X1 As Decimal, Total2 As Decimal
        ReDim Matrix(15)
        Matrix(1).Factor = 3
        Matrix(2).Factor = 7
        Matrix(3).Factor = 13
        Matrix(4).Factor = 17
        Matrix(5).Factor = 19
        Matrix(6).Factor = 23
        Matrix(7).Factor = 29
        Matrix(8).Factor = 37
        Matrix(9).Factor = 41
        Matrix(10).Factor = 43
        Matrix(11).Factor = 47
        Matrix(12).Factor = 53
        Matrix(13).Factor = 59
        Matrix(14).Factor = 67
        Matrix(15).Factor = 71
        TextoNit = Trim(Format(Nit, "0"))
        LargoNit = Len(TextoNit)
        If LargoNit > 15 Then LargoNit = 15
        For X = 1 To LargoNit
            Matrix(X).Digito_Nit = Mid(TextoNit, (LargoNit - X + 1), 1)
        Next X
        For X = (LargoNit + 1) To 15
            Matrix(X).Digito_Nit = 0
        Next X
        For X = 1 To 15
            Total1 = Total1 + (Matrix(X).Digito_Nit * Matrix(X).Factor)
        Next X
        Total2 = (Int(Total1 / 11) * 11)
        X1 = Total1 - Total2
        If X1 = 0 Or X1 = 1 Then
            Calculo_Digito_Verificacion = CByte(Math.Abs(X1))
        Else
            Calculo_Digito_Verificacion = CByte(Math.Abs(Total1 - Total2 - 11))
        End If
    End Function
    Public Function TraerSecuencialGeneral(Tabla As String, NombreTabla As String, Campo As String) As ULong
        On Error GoTo ControlError
        ' Este procedimiento ejecuta el manejo de secuenciales sobre la BD de Control para el manejo de secuenciales por empresa
        'Tabla: es el nombre como debe de quedar en la tabla de secuenciales
        'NombreTabla: es el nombre fisico de la tabla por si no esta en secuenciales generar el registro
        'Campo: es el campo que va a manejar el secuencial
        Dim TB As New DataTable, Da As New SqlDataAdapter
        Dim SQL As String, Valor As Long, R As ULong, Dr As DataRow

        TraerSecuencialGeneral = 0
        SQL = "select * from G_Secuenciales where empresa = " & DatosEmp.NumEmpresa & " and NombreTabla = '" + Tabla + "'"
        Da = New SqlDataAdapter(SQL, SMTConex)
        Da.Fill(TB)
        If TB.Rows.Count > 0 Then
            Dr = TB.Rows(0)
            TraerSecuencialGeneral = Dr("Siguiente")
            SQL = "update G_Secuenciales SET Siguiente =" & (TraerSecuencialGeneral + 1).ToString & " Where NombreTabla ='" + Tabla + "'"
            SMT_EjcutarComandoSql(SMTConex, SQL, R)
        Else
            SQL = "Select isnull(max(" & Campo & "),0) + 1 as valor from " & NombreTabla
            Da = New SqlDataAdapter(SQL, SMTConexMod)
            Da.Fill(TB)
            If TB.Rows.Count = 0 Then
                Valor = 0
                TraerSecuencialGeneral = Valor
                Exit Function
            Else
                Valor = TB.Rows(0)("Valor")
            End If
            SQL = "insert into g_secuenciales (nombretabla,descripcion,siguiente,empresa) values ('" & Tabla & "','" & Tabla & "'," & Valor & " + 1, " & DatosEmp.NumEmpresa & ")"
            SMT_EjcutarComandoSql(SMTConex, SQL, R)
            TraerSecuencialGeneral = Valor

            Exit Function
        End If

        TB.Dispose()
        Da.Dispose()
        Return TraerSecuencialGeneral
        Exit Function
ControlError:
        MensajedeError("Traer Secuencial")
    End Function

    Public Function Nombre_Plan_Contable(Plan As Integer) As String
        On Error GoTo Err_Nombre_Plan_Contable
        Dim SQL As String, TB As DataTable, Dr As DataRow
        Nombre_Plan_Contable = ""
        SQL = "Select NombrePlan From Planes Where CodPlan =" & Plan
        TB = SMT_AbrirRecordSet(SMTConex, SQL)


        If TB.Rows.Count > 0 Then
            Dr = TB.Rows(0)
            'If Not IsNull(TB!nombreplan) Then
            If Not Dr.IsNull("nombreplan") Then
                Nombre_Plan_Contable = Dr("nombreplan")
            End If
        End If
        TB.Clear()
        Exit Function
Err_Nombre_Plan_Contable:
        MensajedeError()
    End Function

    Public Function NomTerminal() As String
        On Error GoTo Salir
        NomTerminal = System.Net.Dns.GetHostName()
Salir:
        Exit Function
    End Function
    Public Sub Cargar_OpcInicio()
        On Error GoTo CtlErr
        Dim FrmInicio As New FrmOpcInicio
        FrmInicio.Show()
        Exit Sub
CtlErr:
        MensajedeError("Cargar_OpcInicio")
    End Sub
    Public Function UsuarioWindows() As String
        UsuarioWindows = Environment.UserName
    End Function
    Public Function NombreTercero(Identificación As Decimal, Optional Establecimiento As Integer = 0) As String
        NombreTercero = NombreTer(Identificación, Establecimiento)
    End Function
    Private Function NombreTer(Identificación As Decimal, Optional Establecimiento As Integer = 0) As String
        On Error GoTo Err_NombreTercero
        Dim TxtSQL As String = "", Tbl As New DataTable
        NombreTer = ""
        If Not IsNumeric(Identificación) Then Exit Function
        If Establecimiento = 0 Then
            TxtSQL = "Select Replace(LTRIM(RTRIM((isnull(Papellido,'') + ' ' + isnull(Sapellido,'') + ' ' +  " & _
                         "isnull(Pnombre, '') + ' ' + isnull(Snombre,'')))),'  ',' ') + " & _
                         " (case isnull(NombreComercial,'') when '' then '' else ' - '  + upper(NombreComercial) end) as Nombre  From G_Clientes " & _
                         " Where Identificacion=" & Identificación
        ElseIf Establecimiento > 0 Then
            TxtSQL = "Select Replace(LTRIM(RTRIM((isnull(Papellido,'') + ' ' + isnull(Sapellido,'') + ' ' + " & _
                    " isnull(Pnombre, '') + ' ' + isnull(Snombre,'')))),'  ',' ') + " & _
                    " (case isnull(NombreComercial,'') when '' then '' else ' - '  + upper(G_ClientesEstab.Nombre) end) as Nombre " & _
                    " From G_Clientes  left join G_ClientesEstab on Identificacion = G_ClientesEstab.Cliente " & _
                    " Where Identificacion=" & Identificación & " and CosigoEst = " & Establecimiento
        End If
        Tbl = SMT_AbrirRecordSet(SMTConexMod, TxtSQL)

        If Tbl.Rows.Count = 1 Then
            If Not IsDBNull(Tbl(0)("Nombre")) Then
                NombreTer = Tbl(0)("Nombre")
            Else
                NombreTer = ""
            End If
        End If
        NombreTer = Replace(Trim(NombreTer), "  ", " ")
        Tbl.Dispose()
        Tbl = Nothing
Exit_NombreTercero:
        Exit Function
Err_NombreTercero:
        MensajedeError()
        Resume Exit_NombreTercero
    End Function
    Public Function IP_Terminal() As String
        On Error GoTo salir
        IP_Terminal = System.Net.Dns.GetHostByName(NomTerminal).AddressList(0).ToString()
        Exit Function
salir:

    End Function

    Public Function TraerTipodeLetra_FONT(TipoLetra As String, TamañoLetra As Single, Negrita As Boolean, Italica As Boolean) As Font
        Dim Negra As FontStyle, Ital As FontStyle
        Negra = IIf(Negrita, FontStyle.Bold, FontStyle.Regular)
        Ital = IIf(Italica, FontStyle.Italic, FontStyle.Regular)

        'TraerTipodeLetra_FONT = New System.Drawing.Font(TipoLetra, TamañoLetra, IIf(Negrita, FontStyle.Bold, FontStyle.Regular) Or IIf(Italica, FontStyle.Italic, FontStyle.Regular))
        TraerTipodeLetra_FONT = New System.Drawing.Font(TipoLetra, TamañoLetra, Negra Or Ital)
    End Function
    Public Function LeerParaMMsgFactura(Texto As String, Parametro As String) As String
        On Error Resume Next
        Dim PosIni As Long, Ancho As Long, PosFin As Long
        PosIni = InStr(1, Texto, Parametro, vbTextCompare) + Len(Parametro) + 1
        PosFin = InStr(PosIni, Texto, ";", vbTextCompare)
        If PosFin = 0 Then PosFin = Len(Texto) + 1
        Ancho = PosFin - (PosIni)
        LeerParaMMsgFactura = Mid(Texto, PosIni, Ancho)
    End Function
    Public Function LaTransaccion_Es_Autorizada(Numero_de_Transaccion As Long) As Boolean
        Dim X As Long
        For X = 0 To UBound(GUsuario.TranAuto)
            If GUsuario.TranAuto(X) = Numero_de_Transaccion Then
                LaTransaccion_Es_Autorizada = True
                Exit For
            End If
        Next X
        Return LaTransaccion_Es_Autorizada
    End Function
    Sub ControlTeclas(ByRef KeyCode As Integer)
        Select Case KeyCode
            Case 13, 40 : SendKeys.Send("{TAB}")
            Case 38 : SendKeys.Send("+{TAB}")
                'Case vbKeyBack: SendKeys "{BACKSPACE}"
        End Select
    End Sub
    Sub EntraBoton(ByRef Boton As Button)
        Boton.Font = TraerTipodeLetra_FONT(Boton.Font.Name, Boton.Font.Size, True, False)
    End Sub
    Sub SaleBoton(ByRef Boton As Button)
        Boton.Font = TraerTipodeLetra_FONT(Boton.Font.Name, Boton.Font.Size, False, False)
    End Sub
    Public Function Autoriza_La_Transaccion(ByVal Transaccion As Long) As Boolean
        On Error Resume Next
        If Not LaTransaccion_Es_Autorizada(Transaccion) Then
            MsgBox("! Transaccion no Autorizada ¡ " & Chr(10) + Chr(13) + Chr(13) & _
                       "Codigo: " & Transaccion & Chr(10) & Chr(13) & _
                       "Descripción: " & Descripcion_Transaccion(Transaccion), vbCritical, "Samit SQL. Control de Seguridad")
        Else
            Autoriza_La_Transaccion = True
        End If
        Return Autoriza_La_Transaccion
    End Function
    Public Function Descripcion_Transaccion(Transaccion As Long) As String
        On Error GoTo Err_Descripcion_Transaccion
        Dim TblTran As New DataTable, TxtSQL As String
        Descripcion_Transaccion = ""
        TxtSQL = "Select Descripcion From Transacciones Where NumTransaccion=" & Transaccion
        TblTran = SMT_AbrirTabla(SMTConexMod, TxtSQL)
        If TblTran.Rows.Count = 1 Then Descripcion_Transaccion = TblTran(0)("Descripcion")
Exit_Descripcion_Transaccion:
        TblTran = Nothing
        Exit Function
Err_Descripcion_Transaccion:
        MensajedeError("Consultando existencia de una Transacción")
        Resume Exit_Descripcion_Transaccion
    End Function
    Public Sub MapeaLookUpEdit_A_Table(Combo As DevExpress.XtraEditors.LookUpEdit, Tabla As DataTable, CampoValor As String, CampoMuestra As String, _
                                     Optional AnchoPopUp As Integer = 0, Optional TipoLetra As System.Drawing.Font = Nothing, Optional ColorLetra As System.Drawing.Color = Nothing)
        Combo.Properties.DataSource = Tabla
        Combo.Properties.DisplayMember = CampoMuestra
        Combo.Properties.ValueMember = CampoValor
        Combo.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Style3D

        Combo.Properties.ForceInitialize()
        Combo.Properties.BestFit()
        'Combo.ItemIndex = 0
        Combo.Properties.NullText = "No Seleccionado"
        Combo.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True
        Combo.Properties.PopulateColumns()
        If AnchoPopUp <> 0 Then Combo.Properties.PopupWidth = AnchoPopUp
        Combo.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter
        If Not IsNothing(ColorLetra) Then
            Combo.ForeColor = ColorLetra
            Combo.Properties.AppearanceDropDown.ForeColor = ColorLetra
        End If
        If Not IsNothing(TipoLetra) Then
            Combo.Font = TipoLetra
            Combo.Properties.AppearanceDropDown.Font = TipoLetra
        End If
    End Sub
    Public Sub MapealookUpEdit_Columna(Combo As DevExpress.XtraEditors.LookUpEdit, NumCol As Integer, Ancho As Integer, Titulo As String, _
                                      Optional Visible As Boolean = True)
        Dim Col As DevExpress.XtraEditors.Controls.LookUpColumnInfo
        Col = Combo.Properties.Columns(NumCol)
        Col.Caption = Titulo
        If Ancho > 0 Then Col.Width = Ancho
        Col.Visible = Visible

    End Sub
End Module
