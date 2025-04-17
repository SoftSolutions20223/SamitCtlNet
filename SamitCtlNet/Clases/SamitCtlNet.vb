Imports Microsoft.Win32
Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports System.Drawing

Public Class SamitCtlNet
    Public Seguridad As New Clseguridad
    Public RegistroSAMIT As New ClregistroSamit
    Public Funciones As New ClFunciones
    ''' <summary>
    ''' Conexion a Base de Datos de Control SAMIT SQL
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property SmtConexion As SqlConnection
        Get
            SmtConexion = SMTConex
        End Get
        Set(value As SqlConnection)
            SMTConex = value
        End Set
    End Property
    Public Property BarraMensajeAyuda As Object
        Get
            BarraMensajeAyuda = MiBarraEstado
        End Get
        Set(value As Object)
            MiBarraEstado = value
        End Set
    End Property
    ''' <summary>
    ''' Color de Fondo Cuando se Entra en un Control Txt
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ColordeFondoTxtFoco As Color
        Get
            ColordeFondoTxtFoco = ColorDeFondoEntraControl
        End Get
        Set(value As Color)
            ColorDeFondoEntraControl = value
        End Set
    End Property
    ''' <summary>
    ''' Conexion a Base de Datos del Módulo (Empresa + Año) SAMIT SQL
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property SmtConexionMod As SqlConnection
        Get
            SmtConexionMod = SMTConexMod
        End Get
        Set(value As SqlConnection)
            SMTConexMod = value


            If SMTConexMod.State = ConnectionState.Open Then Clseguridad.Traer_Datos_Empresa()
        End Set
    End Property
    ''' <summary>
    ''' Usuario o Login con el cual esta Conectado SAMIT SQL
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Smt_Usuario As String
        Get
            Smt_Usuario = SMTLogin
        End Get
        Set(value As String)
            SMTLogin = value
        End Set
    End Property
    ''' <summary>
    ''' Fecha que esta Manejando el Servidor al cual esta Conectado SAMIT SQL
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Smt_FechaDelServidor As DateTime
        Get
            Smt_FechaDelServidor = Traer_FechaDelServidor()
        End Get
        Set(value As DateTime)
            FechaSys = value
        End Set
    End Property
    ''' <summary>
    ''' Fecha de Facturación de la Oficina o Empresa a la Cual Se Conecta SAMIT SQL
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Smt_FechaDeVentas As Date
        Get
            Dim Tbl As DataTable, TxtSql As String
            Smt_FechaDeVentas = Now
            TxtSql = "Select FechaVentas from Oficinas Where NumEmpresa=" & VgEmpresa & " AND NumOficina = " & VgOficina
            Tbl = SMT_AbrirRecordSet(SMTConex, TxtSql)
            If Tbl.Rows.Count = 1 Then
                If IsDBNull(Tbl.Rows(0)("FechaVentas")) Then
                    Smt_FechaDeVentas = FechaSys.Date
                Else
                    Smt_FechaDeVentas = Tbl.Rows(0)("FechaVentas")
                End If
                Smt_FechaDeVentas = Smt_FechaDeVentas.Date
            End If

        End Get
        Set(value As Date)

        End Set
    End Property
    Public Property Smt_FechaDeTrabajo As Date
        Get
            Smt_FechaDeTrabajo = FechaW
        End Get
        Set(value As Date)
            FechaW = value
        End Set
    End Property
    ''' <summary>
    ''' Nombre de la Base de datos con la cual esta conectado el Usuario
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Smt_BDTrabajo As String
        Get
            BdTrabajo = "E" & Format(VgEmpresa, "000") & Format(Year(FechaW), "0000")
            Smt_BDTrabajo = BdTrabajo
        End Get
        Set(value As String)
            BdTrabajo = value
        End Set
    End Property
    ''' <summary>
    ''' Número del Modulo Samit al Cual se Conecta,
    ''' Valida los Usuariois Conectados al Módulo
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Smt_NumeroModulo As Integer
        Get
            Smt_NumeroModulo = NumerodeModulo
        End Get
        Set(value As Integer)
            NumerodeModulo = value
            VGNumModulo = NumerodeModulo
        End Set
    End Property
    ''' <summary>
    ''' Nombre del Servidor al cual esta conectado SAMIT SQL
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Smt_Servidor As String
        Get
            Smt_Servidor = SMTServidor
        End Get
        Set(value As String)
            SMTServidor = value
        End Set
    End Property
    ''' <summary>
    ''' Nombre del Computador o Terminal desde el Cual se Conecto a SAMIT SQL
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Smt_NombreTerminal As String
        Get
            Return NomTerminal()
        End Get
    End Property
    ''' <summary>
    ''' Nombre del Usuario de Windows desde el Cual se Conecto a SAMIT SQL
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Smt_UsuarioWindows As String
        Get
            Return UsuarioWindows()
        End Get
    End Property
    Public ReadOnly Property Smt_IP_Terminal As String
        Get
            Return IP_Terminal()
        End Get
    End Property
    ''' <summary>
    ''' Número del Usuario de SAMIT SQL
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Smt_NumUsuario As Integer
        Get
            Smt_NumUsuario = SMTNumUsuario
        End Get
    End Property
    Public Property SmtPasswdSeg As String
        Get
            SmtPasswdSeg = VGPaswdBD_Seg
        End Get
        Set(value As String)
            VGPaswdBD_Seg = value
        End Set
    End Property
    Public Property SmtPasswdModulo As String
        Get
            Return VGPaswdBD_Mod
        End Get
        Set(value As String)
            VGPaswdBD_Mod = value
        End Set
    End Property
    ''' <summary>
    ''' Cadena de Conexion de SAMIT SQL
    ''' Solo Lectura
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared ReadOnly Property CadenaConexionMod() As String
        Get
            CadenaConexionMod = SMTConexMod.ConnectionString
        End Get
    End Property
    ''' <summary>
    ''' Numero Empresa Ingresa a SAMIT SQL
    ''' Solo Lectura
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared ReadOnly Property SMTNumEmpresa() As Integer
        Get
            SMTNumEmpresa = DatosEmp.NumEmpresa
        End Get
    End Property
    ''' <summary>
    ''' Nombre Empresa Ingresa a SAMIT SQL
    ''' Solo Lectura
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared ReadOnly Property SMTNombreEmpresa() As String
        Get
            SMTNombreEmpresa = DatosEmp.NombreEmpresa
        End Get
    End Property
    ''' <summary>
    ''' Nombre oficina Ingresa a SAMIT SQL
    ''' Solo Lectura
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared ReadOnly Property SMTNombreOficina() As String
        Get
            SMTNombreOficina = DatosEmp.OficinaIngreso.NombreOficina
        End Get
    End Property
    ''' <summary>
    ''' Numero oficina Ingresa a SAMIT SQL
    ''' Solo Lectura
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared ReadOnly Property SMTNumOficina() As Integer
        Get
            SMTNumOficina = DatosEmp.OficinaIngreso.NumOficina
        End Get
    End Property

    Public Class ClSmtImagenes
        Public Enum MisImagenes
            Salir128
            Salir48
            Adicionar16x16
            Adicionar32x32
            Aceptar16x16
            Aceptar32x32
            ConectarPNG
            DesconectarPNG
            DocumentHoriz
            DocumentVert
            EncontrarLentes1
            EncontrarLentes2
            Ayuda
            ImportarJPG
            TeclaEscape
            Imprimir16x16
            Imprimir32x32
            Impresora
            ImprimirPrevio16x16
            ImprimirPrevio32x32
            ImprimirRapido16x16
            ImprimirRapido32x32
            ClienteInformacion16x16
            ClienteInformacion32x32
            Cliente16x16
            Cliente32x32
            Vendedor16x16
            Vendedor32x32
            Guardar_Disquete_16x16
            Guardar_Disquete_32x32
            ExportarExcel_16x16
            ExportarExcel_Xls_16x16
            ExportarExcel_Xls_32x32
            ExportarExcel_XlsX_16x16
            ExportarExcel_XlsX_32x32
            Cancelar_16x16
            Cancelar_32x32
        End Enum
        Public Shared Function SMT_TraerImagenArchivo() As Image
            Dim BImg As New OpenFileDialog
            BImg.Filter = "Imagenes JPG|*.jpg|Imagenes PNG|*.png"
            BImg.RestoreDirectory = True
            If BImg.ShowDialog = Windows.Forms.DialogResult.OK Then
                SMT_TraerImagenArchivo = Image.FromFile(BImg.FileName)
            Else
                SMT_TraerImagenArchivo = Nothing
            End If
        End Function
        Public Shared Function SMT_Conv_Byte_A_Image(CampoImg() As Byte) As Image
            On Error Resume Next
            If Not IsDBNull(CampoImg) Then
                SMT_Conv_Byte_A_Image = DevExpress.XtraEditors.Controls.ByteImageConverter.FromByteArray(CampoImg)
            Else
                SMT_Conv_Byte_A_Image = Nothing
            End If
        End Function
        Public Shared Function SMT_Conv_Image_A_Byte(ImagenConv As Image) As Byte()
            On Error Resume Next
            'Dim BImg As New OpenFileDialog
            'SMT_Conv_Image_A_Byte = DevExpress.XtraEditors.Controls.ByteImageConverter.FromByteArray(CampoImg)
            SMT_Conv_Image_A_Byte = DevExpress.XtraEditors.Controls.ByteImageConverter.ToByteArray(ImagenConv, System.Drawing.Imaging.ImageFormat.Bmp)

        End Function
        Public Shared Function TraerMisImagenes(LaImagen As MisImagenes) As Image
            Try
                Select Case LaImagen
                    Case MisImagenes.Salir128
                        Return My.Resources.Salir_128x
                    Case MisImagenes.Salir48
                        Return My.Resources.SALIR_48x
                    Case MisImagenes.Adicionar16x16
                        Return My.Resources.Add_16x16
                    Case MisImagenes.Adicionar32x32
                        Return My.Resources.Add_32x32
                    Case MisImagenes.Aceptar16x16
                        Return My.Resources.Apply_16x16
                    Case MisImagenes.Aceptar32x32
                        Return My.Resources.Apply_32x32
                    Case MisImagenes.ConectarPNG
                        Return My.Resources.connect
                    Case MisImagenes.DesconectarPNG
                        Return My.Resources.disconnect
                    Case MisImagenes.DocumentHoriz
                        Return My.Resources.document_image_hor
                    Case MisImagenes.DocumentVert
                        Return My.Resources.document_image_ver
                    Case MisImagenes.Ayuda
                        Return My.Resources.help

                    Case MisImagenes.ClienteInformacion16x16
                        Return My.Resources.BODetails_16x16
                    Case MisImagenes.ClienteInformacion32x32
                        Return My.Resources.BODetails_32x32
                    Case MisImagenes.Cliente16x16
                        Return My.Resources.BOCustomer_16x16
                    Case MisImagenes.Cliente32x32
                        Return My.Resources.BOCustomer_32x32
                    Case MisImagenes.Vendedor16x16
                        Return My.Resources.BOPosition2_16x16
                    Case MisImagenes.Vendedor32x32
                        Return My.Resources.BOPosition2_32x32
                    Case MisImagenes.Impresora
                        Return My.Resources.printer
                    Case MisImagenes.ImprimirPrevio16x16
                        Return My.Resources.PrintPreview_16x16
                    Case MisImagenes.ImprimirPrevio32x32
                        Return My.Resources.PrintPreview_32x32
                    Case MisImagenes.ImprimirRapido16x16
                        Return My.Resources.PrintQuick_16x16
                    Case MisImagenes.ImprimirRapido32x32
                        Return My.Resources.PrintQuick_32x32
                    Case MisImagenes.Imprimir16x16
                        Return My.Resources.Print_16x16
                    Case MisImagenes.Imprimir32x32
                        Return My.Resources.Print_32x32
                    Case MisImagenes.TeclaEscape
                        Return My.Resources.key_escape
                    Case MisImagenes.Guardar_Disquete_16x16
                        Return My.Resources.Save_16x16
                    Case MisImagenes.Guardar_Disquete_32x32
                        Return My.Resources.Save_32x32
                    Case MisImagenes.ExportarExcel_16x16
                        Return My.Resources.export_excel
                    Case MisImagenes.ExportarExcel_Xls_16x16
                        Return My.Resources.ExportToXLS_16x16
                    Case MisImagenes.ExportarExcel_Xls_32x32
                        Return My.Resources.ExportToXLS_32x32
                    Case MisImagenes.ExportarExcel_XlsX_16x16
                        Return My.Resources.ExportToXLSX_16x16
                    Case MisImagenes.ExportarExcel_XlsX_32x32
                        Return My.Resources.ExportToXLSX_32x32
                    Case MisImagenes.Cancelar_16x16
                        Return My.Resources.Cancel_16x16
                    Case MisImagenes.Cancelar_32x32
                        Return My.Resources.Cancel_32x32
                    Case Else
                        Return Nothing
                End Select

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error: Seleccionando Mis Imagenes")
                Return Nothing
            End Try



        End Function
        Public Shared Function IconoSAMIT() As Icon
            Return My.Resources.SamitIcono
        End Function



    End Class

    Public Class ClGeneraSqlDLL
        'Private Img As New ClSmtImagenes
        Dim _MiTran As SqlTransaction
        Public Enum SQLGenera
            Insercion = 0
            Actualizacion = 1
        End Enum
        Public Enum TipoDatoActualizaSQL
            Cadena = 0
            Numero = 1
            Fecha = 2
            Imagen = 3
            ArrBytes = 4
        End Enum
        Protected Structure ValoresActualiza
            Public Campo As String
            Public Valor As String
            Public Tipo As TipoDatoActualizaSQL
            Public Imagen As Image
            Public ArrBytes As Byte()
        End Structure
        Protected Structure ValoresCampo
            Public Campo As String
            Public Valor As String
        End Structure
        Private valores() As ValoresActualiza, CantParametros As Byte, VTipoSqlGenera As SQLGenera, SeleccionoTipo As Boolean
        Private VConexion As SqlConnection, VTabla As String, VCondicion As String, Retorno As Long
        Public Sub PasoValores(Campo As String, Valor As String, Tipo As TipoDatoActualizaSQL, Optional VarImagen As Object = Nothing)
            On Error GoTo CtlErr
            valores(CantParametros).Campo = Campo
            valores(CantParametros).Valor = Valor
            valores(CantParametros).Tipo = Tipo
            If Tipo = TipoDatoActualizaSQL.ArrBytes Then
                valores(CantParametros).ArrBytes = VarImagen
            ElseIf Tipo = TipoDatoActualizaSQL.Imagen Then
                valores(CantParametros).Imagen = VarImagen
            End If

            CantParametros = CantParametros + 1
            Exit Sub
CtlErr:
            MensajedeError()
        End Sub

        Public Sub PasoConexionTabla(Conex As SqlConnection, TablaActualiza As String, Optional Tran As SqlTransaction = Nothing)
            On Error GoTo CtlErr
            Dim R As Long
            _MiTran = Tran
            VTabla = TablaActualiza
            VConexion = Conex
            If Not VConexion.State = ConnectionState.Open Then
                Err.Raise(10000, "La Conexion esta Cerrada")
                Exit Sub
            End If
            If Not ExisteTabla(Conex, VTabla) Then
                MsgBox("No Existe la Tabla " & VTabla & " En esta Conexión")
                Exit Sub
            End If

            Exit Sub
CtlErr:
            MensajedeError("Pasando Conexion Tabla SAMIT SQL")
        End Sub

        Public Function EjecutarComandoSQL(TipoSqlGenera As SQLGenera, Condicion As String) As Boolean
            On Error GoTo CtlErr
            Dim R As Long
            EjecutarComandoSQL = False
            VTipoSqlGenera = TipoSqlGenera
            VCondicion = Condicion
            If VTipoSqlGenera = SQLGenera.Actualizacion And Trim(VCondicion) = "" Then
                MessageBox.Show("Para la Actualización se requiere una Condición, No se Ejecutara el Comando")
                Exit Function
            End If
            If ExisteTabla(VConexion, VTabla) Then
                SMT_EjcutarComandoSql(VConexion, GenerarSQL, R)
            Else
                MsgBox("No Existe la Tabla " & VTabla & " En esta Conexión")
                Exit Function
            End If
            CantParametros = 0
            EjecutarComandoSQL = True
            Exit Function
CtlErr:
            MensajedeError("Ejecutando Comando SQL")
        End Function
        Public Function EjecutarComandoNET(TipoSqlGenera As SQLGenera, Condicion As String) As Boolean
            On Error GoTo CtlErr
            Dim R As Long
            EjecutarComandoNET = False
            VTipoSqlGenera = TipoSqlGenera
            VCondicion = Condicion
            If VTipoSqlGenera = SQLGenera.Actualizacion And Trim(VCondicion) = "" Then
                MessageBox.Show("Para la Actualización se requiere una Condición, No se Ejecutara el Comando")
                Exit Function
            End If
            If ExisteTabla(VConexion, VTabla) Then
                GeneraNET()
            Else
                MsgBox("No Existe la Tabla " & VTabla & " En esta Conexión")
                Exit Function
            End If
            CantParametros = 0
            If Retorno <= 0 Then
                EjecutarComandoNET = False
            Else
                EjecutarComandoNET = True
            End If

            Exit Function
CtlErr:
            MensajedeError("Ejecutando Comando SQL")
        End Function
        Private Sub GeneraNET()
            Dim SQLCampos As String, SQLValores As String, X As Integer
            Dim Cmd As SqlCommand
            Dim TxtSql As String = ""
            Try
                If VTipoSqlGenera = SQLGenera.Insercion Then
                    SQLCampos = " ("
                    SQLValores = " Values ("
                    For X = 0 To CantParametros - 1
                        If X = 0 Then
                            SQLCampos = SQLCampos & valores(X).Campo
                            SQLValores = SQLValores & "@" & valores(X).Campo
                        Else
                            SQLCampos = SQLCampos & "," & valores(X).Campo
                            SQLValores = SQLValores & ",@" & valores(X).Campo
                        End If
                    Next X
                    SQLCampos = SQLCampos & ")"
                    SQLValores = SQLValores & ")"
                    TxtSql = " insert into " & VTabla & SQLCampos & SQLValores & VCondicion

                ElseIf VTipoSqlGenera = SQLGenera.Actualizacion Then ' Genera cuando es una actualizcion

                    SQLCampos = "Update " & VTabla & " SET "
                    SQLValores = " "
                    For X = 0 To CantParametros - 1
                        If X = 0 Then
                            SQLValores = SQLValores & valores(X).Campo & " = " & "@" & valores(X).Campo
                        Else
                            SQLValores = SQLValores & "," & valores(X).Campo & " = " & "@" & valores(X).Campo
                        End If
                    Next X
                    TxtSql = SQLCampos & SQLValores & " Where " & VCondicion
                End If
                Cmd = New SqlCommand(TxtSql, VConexion)

                'Adicionamos Parametros del Comando
                Dim Param As SqlParameter
                For X = 0 To CantParametros - 1

                    If valores(X).Tipo = TipoDatoActualizaSQL.Cadena Then
                        Param = New SqlParameter("@" & valores(X).Campo, SqlDbType.VarChar)
                        Param.Value = valores(X).Valor
                        Cmd.Parameters.Add(Param)
                    ElseIf valores(X).Tipo = TipoDatoActualizaSQL.Fecha Then
                        Param = New SqlParameter("@" & valores(X).Campo, SqlDbType.DateTime)
                        Param.Value = CType(valores(X).Valor, Date)
                        Cmd.Parameters.Add(Param)
                    ElseIf valores(X).Tipo = TipoDatoActualizaSQL.Numero Then
                        Param = New SqlParameter("@" & valores(X).Campo, SqlDbType.Money)
                        Param.Value = CType(valores(X).Valor, Decimal)
                        Cmd.Parameters.Add(Param)
                    ElseIf valores(X).Tipo = TipoDatoActualizaSQL.Imagen Then

                        Param = New SqlParameter("@" & valores(X).Campo, SqlDbType.Image)
                        If Not IsNothing(valores(X).Imagen) Then
                            Param.Value = ClSmtImagenes.SMT_Conv_Image_A_Byte(valores(X).Imagen)
                        Else
                            Param.Value = DBNull.Value
                        End If
                        Cmd.Parameters.Add(Param)
                    ElseIf valores(X).Tipo = TipoDatoActualizaSQL.ArrBytes Then

                        Param = New SqlParameter("@" & valores(X).Campo, SqlDbType.VarBinary)
                        If Not IsNothing(valores(X).ArrBytes) Then
                            Param.Value = valores(X).ArrBytes
                        Else
                            Param.Value = DBNull.Value
                        End If
                        Cmd.Parameters.Add(Param)

                    End If

                Next X
                Cmd.Transaction = _MiTran
                Retorno = Cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End Sub
        Private Function GenerarSQL() As String
            On Error GoTo CtlErr
            Dim SQLCampos As String, SQLValores As String, X As Byte
            GenerarSQL = ""
            If VTipoSqlGenera = SQLGenera.Insercion Then ' Genera Cuando es una insercion
                SQLCampos = " ("
                SQLValores = " Values ("
                For X = 0 To CantParametros - 1
                    If X = 0 Then
                        SQLCampos = SQLCampos & valores(X).Campo
                    Else
                        SQLCampos = SQLCampos & "," & valores(X).Campo
                    End If
                    If valores(X).Tipo = TipoDatoActualizaSQL.Cadena Then
                        If X = 0 Then
                            SQLValores = SQLValores & "'" & valores(X).Valor & "'"
                        Else
                            SQLValores = SQLValores & ",'" & valores(X).Valor & "'"
                        End If
                    ElseIf valores(X).Tipo = TipoDatoActualizaSQL.Fecha Then
                        If X = 0 Then
                            SQLValores = SQLValores & "'" & Format(valores(X).Valor, "dd/mm/yyyy hh:mm:ss") & "'"
                        Else
                            SQLValores = SQLValores & ",'" & Format(valores(X).Valor, "dd/mm/yyyy hh:mm:ss") & "'"
                        End If
                    ElseIf valores(X).Tipo = TipoDatoActualizaSQL.Numero Then
                        If X = 0 Then
                            SQLValores = SQLValores & valores(X).Valor
                        Else
                            SQLValores = SQLValores & "," & valores(X).Valor
                        End If
                    End If
                Next X
                SQLCampos = SQLCampos & ")"
                SQLValores = SQLValores & ")"
                GenerarSQL = " insert into " & VTabla & SQLCampos & SQLValores & VCondicion

            ElseIf VTipoSqlGenera = SQLGenera.Actualizacion Then ' Genera cuando es una actualizcion

                SQLCampos = "Update " & VTabla & " SET "
                SQLValores = " "
                For X = 0 To CantParametros - 1

                    If valores(X).Tipo = TipoDatoActualizaSQL.Cadena Then
                        If X = 0 Then
                            SQLValores = SQLValores & valores(X).Campo & " = " & "'" & valores(X).Valor & "'"
                        Else
                            SQLValores = SQLValores & "," & valores(X).Campo & " = " & "'" & valores(X).Valor & "'"
                        End If
                    ElseIf valores(X).Tipo = TipoDatoActualizaSQL.Fecha Then
                        If X = 0 Then
                            SQLValores = SQLValores & valores(X).Campo & " = " & "'" & Format(valores(X).Valor, "dd/mm/yyyy hh:mm:ss") & "'"
                        Else
                            SQLValores = SQLValores & "," & valores(X).Campo & " = " & "'" & Format(valores(X).Valor, "dd/mm/yyyy hh:mm:ss") & "'"
                        End If
                    ElseIf valores(X).Tipo = TipoDatoActualizaSQL.Numero Then
                        If X = 0 Then
                            SQLValores = SQLValores & valores(X).Campo & " = " & valores(X).Valor
                        Else
                            SQLValores = SQLValores & "," & valores(X).Campo & " = " & valores(X).Valor
                        End If
                    End If
                Next X
                GenerarSQL = SQLCampos & SQLValores & " Where " & VCondicion
            End If
            Return GenerarSQL
            Exit Function
CtlErr:
            MsgBox("Generando SQL " & IIf(VTipoSqlGenera = SQLGenera.Actualizacion, " de Actualización", " de Inserción"))
        End Function

        Public Sub New()
            On Error Resume Next
            ReDim valores(0 To 100)
            CantParametros = 0
        End Sub
    End Class
End Class
