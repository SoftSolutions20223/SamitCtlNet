Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Transactions
Imports System.Xml
Imports System.Xml.Serialization

Public Class ClContabilidad
    'Public Class ListaErrores
    '    Public Linea As UInteger
    '    Public Campo As String
    '    Public TxtError As String
    'End Class
    
    Public Enum DocOrigenContab
        Contab = 0
        Inventario = 1
        Nomina = 2
    End Enum
    Public Structure DatosCuenta
        Dim CodCuenta As String
        Dim NomCuenta As String
        Dim Detalla As Boolean
        Dim EsporPagar As Boolean
        Dim EsPorCobrar As Boolean
        Dim EsdeTercero As Boolean
        Dim EsdeRetencion As Boolean
        Dim EsdeIVA As Boolean
        Dim EsdeMovimiento As Boolean
        Dim ControlaActivos As Boolean
        Dim ControlPersonal As Boolean
        Dim TipoCP As String
        Dim ManejaCC As Boolean
        Dim ExisteCta As Boolean
    End Structure

    Private DatosValidados() As TipoDatoValida
    Private ListaCuentas As List(Of DatosCuenta) = New List(Of DatosCuenta)
    Public Function SamitContabilizarTxt(SERVIDOR As String, Empresa As Integer, Oficina As Integer, Año As Integer, TextoImporta As String, Optional Passwd As String = "2121121512") As String
        Dim Archivo As String() = TextoImporta.Split(vbCrLf)
        Dim Linea As String(), NumLinea As UInteger = 0, Mitb As DataTable = TraerTablaMov()
        Dim part As String, Ds As New DataSet("GRUPO_ERRORES")
        Dim MisErr As New ListaErrores

        Try
            If Archivo.GetUpperBound(0) <= 1 Then Err.Raise(50000, "SAMIT SQL", "Archivo no existe o no contiene lineas de documentos")
            'Conex.ConnectionString = "server=" + SERVIDOR + ";database=" + MisDatos.NomBD + ";uid=sa;password=2121121512;"
            'ConexGen.ConnectionString = "server=" + SERVIDOR + ";database=" + MisDatos.NomBDGen + ";uid=sa;password=2121121512;"
            'Conex.Open()
            'ConexGen.Open()
            'MisDatos.ConexLocal = Conex
            'MisDatos.ConexSeg = ConexGen
            For Each part In Archivo
                Dim Fila As DataRow = Mitb.NewRow
                Linea = part.Split(",")
                NumLinea += 1
                ValidaLinea(Linea, NumLinea, Fila, MisErr)
                If Not IsDBNull(Fila(1)) Then Mitb.Rows.Add(Fila)
            Next
            If Not MisErr.SiTieneErrores Then
                Dim ErrContab As ListaErrores
                ErrContab = SamitContabilizarTb(SERVIDOR, Empresa, Oficina, Año, Mitb, Passwd)
                If Not ErrContab.SiTieneErrores Then
                    Return "OK"
                End If
                Ds.Tables.Add(ErrContab.TraerListaErrores)
                Ds.Tables(0).TableName = "Mis_Errores"
                Return Ds.GetXml()
            End If

            Return "ERROR Validando Archivo a Importar"
            'Return "ERROR Validando Archivo a Importar"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return "ERROR NO SE QUE PASO !!!!"
    End Function
    Public Function SamitContabilizarTb(SERVIDOR As String, Empresa As Integer, Oficina As Integer, Año As Integer, Tb As DataTable,
                                        Optional GeneraConsecutivo As Boolean = False, Optional DocOrigen As DocOrigenContab = DocOrigenContab.Contab, Optional Passwd As String = "2121121512") As ListaErrores
        Dim MisErr As New ListaErrores
        Try
            ReDim DatosValidados(0)
            Dim Dv As New DataView(Tb)
            Dv.Sort = " TipoComp Asc, CodComp Asc, NumeroDoc Asc"
            Tb = Dv.ToTable
            'Using Mitran As TransactionScope = New TransactionScope
            Try
                MisDatos.FechaHora = Now
                MisDatos.Empresa = Empresa
                MisDatos.NomBD = String.Format("E{0}{1}", Empresa.ToString("000"), Año.ToString("0000"))
                MisDatos.NomBDGen = "SEGURIDAD"
                MisDatos.ConexLocal = New Conexion(MisDatos.NomBD, SERVIDOR, Passwd)
                MisDatos.ConexSeg = New Conexion(MisDatos.NomBDGen, SERVIDOR, Passwd)
                'MisDatos.ConexLocal.ConnectionString = "server=" + SERVIDOR + ";database=" + MisDatos.NomBD + ";uid=sa;password=2121121512;"
                'MisDatos.ConexSeg.ConnectionString = "server=" + SERVIDOR + ";database=" + MisDatos.NomBDGen + ";uid=sa;password=2121121512;"
                'MisDatos.ConexLocal.Open()
                'MisDatos.ConexSeg.Open()
            Catch ex As Exception

                MisErr.AdicionaError(True, 0, ex.Source, ex.Message)
                Return MisErr
                Exit Function
            End Try
            MisDatos.ConexLocal.IniciarTrasanccion()
            MisDatos.ConexSeg.IniciarTrasanccion()
            If Not ValidaDatos(Tb, MisErr) Then
                Return MisErr
            End If

            If Not MisErr.SiTieneErrores Then
                If Not VerificarDescuadre(Tb, MisErr) Then
                    Return MisErr
                End If
                If Not MisErr.SiTieneErrores Then
                    If Not Guardar_Comprobante(Tb, MisErr, GeneraConsecutivo) Then
                        Err.Raise(50002, "SAMIT SQL", "Se Presentaron Errores Guardando Comprobante Contable")
                    End If
                Else
                    Err.Raise(50002, "SAMIT SQL", "Se Presentaron Errores Verificando Descuadre")
                End If

            Else
                Err.Raise(50001, "SAMIT SQL", "Se Presentaron Errores en la Validación")
            End If
            MisDatos.ConexLocal.CompletarTransaccion()
            MisDatos.ConexSeg.CompletarTransaccion()
            MisDatos.ConexLocal.conection.Close()
            MisDatos.ConexSeg.conection.Close()
            'MisDatos.ConexLocal.Close()
            'MisDatos.ConexSeg.Close()
            Return MisErr
        Catch ex As Exception
            MisErr.AdicionaError(True, 0, Err.Source, Err.Description)
            MisDatos.ConexLocal.ReversarTransaccion()
            MisDatos.ConexSeg.ReversarTransaccion()
            MisDatos.ConexLocal.conection.Close()
            MisDatos.ConexSeg.conection.Close()
            'MsgBox(ex.Message, vbCritical, ex.Source)
            Return MisErr
        End Try
    End Function
    Public Function SamitContabilizarRuta(SERVIDOR As String, Empresa As Integer, Oficina As Integer, Año As Integer, RutaArchivo As String, Optional Passwd As String = "2121121512") As String
        Try
            Dim Archivo As String = File.ReadAllText(RutaArchivo)
            If Archivo.Length > 100 Then
                Return SamitContabilizarTxt(SERVIDOR, Empresa, Oficina, Año, Archivo, Passwd)
            Else
                Return "ERROR Leyendo Archivo"
            End If
        Catch ex As Exception
            Return "ERROR " + vbTab + ex.Message
        End Try

    End Function
    Private Function VerificarDescuadre(Tb As DataTable, ByRef MiErrores As ListaErrores) As Boolean
        Dim Tipo As String = "", Cod As Integer = 0, Doc As Long = 0, Debitos As Double = 0, Creditos As Double = 0, Cantidad As ULong = 0
        Dim Cont As UInteger = 0
        For Each Fila As DataRow In Tb.Rows
            Cont += 1
            If Not (Fila("TipoComp") = Tipo And Fila("CodComp") = Cod And Fila("NumeroDoc") = Doc) Then
                If IsDate(Fila("Fecha")) Then
                    If Convert.ToDateTime(Fila("Fecha")).Year.ToString <> MisDatos.ConexLocal.conection.Database.Substring(4, 4) Then
                        MiErrores.AdicionaError(True, Cont, "Fecha Documento", String.Format("La Fecha {0} no corresponde con la BD de Conexion {1}", Fila("Fecha"), MisDatos.ConexLocal.conection.Database))
                    End If
                End If
                If Not TipoComprobanteEsdeContabilidad(Fila("TipoComp")) Then
                    MiErrores.AdicionaError(True, Cont, "Tipo de Comprobante", String.Format("Comprobante {0} No es de Contabilidad", Fila("TipoComp")))
                End If
                If Not ExisteComprobante(Fila("TipoComp"), Fila("Codcomp")) Then
                    MiErrores.AdicionaError(True, Cont, "Tipo de Comprobante", String.Format("Comprobante {0}-{1} No Existe o no esta Vigente", Fila("TipoComp"), Fila("CodComp")))
                End If
                If ExisteDatoValida(DatoValida.NumeroDocumento, Fila("TipoComp"), Fila("CodComp").ToString, Fila("NumeroDoc").ToString) Then
                    MiErrores.AdicionaError(True, Cont, "Numero de Documento", String.Format("El Número del Documento: {0}-{1}-{2} Ya Existe", Fila("TipoComp"), Fila("CodComp"), Fila("NumeroDoc")))
                End If
                If Not ExisteDatoValida(DatoValida.Oficina, Fila("Oficina")) Then
                    MiErrores.AdicionaError(True, Cont, "Oficina Documento", String.Format("La Oficina del Documento: {0} No Existe", Fila("Oficina")))
                End If
                Cantidad = Cantidad + 1
                Debitos = 0
                Creditos = 0
                Tipo = Fila("TipoComp")
                Cod = Fila("CodComp")
                Doc = Fila("NumeroDoc")
            End If
            If Fila("Nat").ToString.ToUpper = "D" Then
                Debitos = Debitos + Fila("Valor")
            Else
                Creditos = Creditos + Fila("Valor")
            End If

        Next
        If Debitos <> Creditos Then
            MiErrores.AdicionaError(True, Cont, "Descuadre", String.Format("Doc: {0}-{1}-{2}  Val Deb: {3} Val Cred: {4}", Tipo, Cod, Doc, Debitos, Creditos))
        End If
        If MiErrores.SiTieneErrores Then
            Return False
        Else
            Return True
        End If
    End Function
    Private Function TraerTablaMov() As DataTable
        Dim Tb As New DataTable
        Tb.Columns.Add("Oficina", GetType(Int16))
        Tb.Columns.Add("TipoComp", GetType(String))
        Tb.Columns.Add("CodComp", GetType(Int16))
        Tb.Columns.Add("NumeroDoc", GetType(Int16))
        Tb.Columns.Add("Fecha", GetType(Date))
        Tb.Columns.Add("Tercero", GetType(ULong))
        Tb.Columns.Add("DetalleGeneral", GetType(String))
        Tb.Columns.Add("NumCheque", GetType(String))
        Tb.Columns.Add("Comentario", GetType(String))
        Tb.Columns.Add("Item", GetType(Int16))
        Tb.Columns.Add("Cuenta", GetType(String))
        Tb.Columns.Add("TerceroMov", GetType(ULong))
        Tb.Columns.Add("Estab", GetType(Int16))
        Tb.Columns.Add("Ccosto", GetType(Int16))
        Tb.Columns.Add("TextoDetalle", GetType(String))
        Tb.Columns.Add("Nat", GetType(String))
        Tb.Columns.Add("Valor", GetType(Double))
        Tb.Columns.Add("Factura", GetType(String))
        Tb.Columns.Add("Cuota", GetType(Int16))
        Tb.Columns.Add("FechaVence", GetType(Date))
        Tb.Columns.Add("BaseRet", GetType(Double))
        Tb.Columns.Add("ConceptoRet", GetType(Int16))
        Tb.Columns.Add("BaseIva", GetType(Double))
        Tb.Columns.Add("CodigoTipoIva", GetType(Int16))
        Tb.Columns.Add("Activo", GetType(String))
        Tb.Columns.Add("Vehiculo", GetType(String))
        Tb.Columns.Add("CtrlPersonal", GetType(String))

        Return Tb


    End Function
    Private Sub ValidaLinea(Linea As String(), NumLinea As UInteger, ByRef Fila As DataRow, ByRef MiErrores As ListaErrores, Optional Tran As SqlTransaction = Nothing)
        Dim MiError As ListaErrores
        For I As Integer = 0 To Linea.GetUpperBound(0)
            Linea(I) = Linea(I).Trim.Replace(Chr(34), "").Replace(",", "")
        Next
        If Linea(0).Trim <> "" Then 'valido que tenga algo en el primer campo
            'Fila("Sec") = NumLinea
            Fila("Oficina") = 0
            If IsNumeric(Linea(0)) Then 'Oficina
                Fila("Oficina") = Convert.ToInt16(Linea(0).Trim)
            End If
            Fila("TipoComp") = Linea(1).Trim

            If IsNumeric(Linea(2)) Then
                Fila("CodComp") = Convert.ToInt16(Linea(2).Trim)
            End If
            If IsNumeric(Linea(3)) Then
                Fila("NumeroDoc") = Convert.ToInt16(Linea(3).Trim)
            End If
            If IsDate(Linea(4)) Then
                Fila("Fecha") = Linea(4).Trim
            Else
                MiErrores.AdicionaError(True, NumLinea, "Fecha Documento", Linea(4) + " Fecha No Valida")
            End If
            If IsNumeric(Linea(5)) Then
                Fila("Tercero") = Convert.ToUInt64(Linea(5).Trim)
            Else
                MiErrores.AdicionaError(True, NumLinea, "Tercero", Linea(5) + " Tercero del documento no Valido")
            End If
            Fila("DetalleGeneral") = Linea(6).Trim
            Fila("NumCheque") = Linea(7).Trim
            Fila("Comentario") = Linea(8).Trim
            If IsNumeric(Linea(9)) Then Fila("Item") = Linea(9).Trim
            Fila("Cuenta") = ""
            If Linea(10).Trim <> "" Then
                Fila("Cuenta") = Linea(10).Trim
            Else
                MiErrores.AdicionaError(True, NumLinea, "Cuenta", Linea(10) + " Número de Cuenta no puede estar vacia")
            End If
            If IsNumeric(Linea(11)) Then
                Fila("Terceromov") = Convert.ToUInt64(Linea(11).Trim)
            Else
                MiErrores.AdicionaError(True, NumLinea, "TerceroMov", Linea(11) + " Tercero del Movimiento no Valido")
            End If
            If IsNumeric(Linea(12)) Then
                Fila("Estab") = Convert.ToInt16(Linea(12).Trim)
            Else
                Fila("Estab") = 0
            End If
            If IsNumeric(Linea(13)) Then Fila("CCosto") = Linea(13).Trim
            Fila("TextoDetalle") = Linea(14).Trim
            Fila("Nat") = Linea(15).Trim
            If IsNumeric(Linea(16)) Then
                Fila("Valor") = Convert.ToDouble(Linea(16).Trim)
            Else
                MiErrores.AdicionaError(True, NumLinea, "Valor", Linea(16) + " El Valor del Movimiento tiene que ser un Numero Mayor a Cero")
            End If
            Fila("Factura") = Linea(17).Trim
            Fila("Cuota") = 1
            If IsNumeric(Linea(18)) Then Fila("Cuota") = Convert.ToInt16(Linea(18).Trim)
            If IsDate(Linea(19)) Then
                Fila("FechaVence") = Linea(19).Trim
            End If
            Fila("BaseRet") = 0
            Fila("BaseIva") = 0
            If IsNumeric(Linea(20)) Then Fila("BaseRet") = Convert.ToDouble(Linea(20))
            If IsNumeric(Linea(21)) Then Fila("ConceptoRet") = Linea(21)
            If IsNumeric(Linea(22)) Then Fila("BaseIva") = Convert.ToDouble(Linea(22))
            If IsNumeric(Linea(23)) Then Fila("CodigoTipoIva") = Linea(23)
            Fila("Activo") = Linea(24).Trim
            Fila("Vehiculo") = Linea(25).Trim
            Fila("CtrlPersonal") = Linea(26).Trim

        End If
        MiError = Nothing

    End Sub
    Private Function ValidaDatos(Tb As DataTable, ByRef MiErrores As ListaErrores) As Boolean
        On Error Resume Next
        Dim MiError As ListaErrores, NumLinea As ULong = 0
        For Each Fila As DataRow In Tb.Rows
            NumLinea += 1
            If Not ExisteDatoValida(DatoValida.Tercero, Fila("Tercero")) Then
                MiErrores.AdicionaError(True, NumLinea, "Tercero Documento", String.Format("Tercero del Documento: {0} No Existe", Fila("Tercero")))
            End If
            If Fila("Valor") <= 0 Then
                MiErrores.AdicionaError(True, NumLinea, "Valor del Movimiento", String.Format("El Valor {0} del Movimiento, NO PUEDE SER MENOR O IGUAL A CERO", Fila("Valor")))
            End If
            If Fila("Cuenta") <> "" Then
                Dim Cta As DatosCuenta
                Cta = DatosdelaCuenta(Fila("Cuenta"))
                If Cta.ExisteCta Then
                    If Cta.CodCuenta.Trim <> "" Then
                        If Not Cta.EsdeMovimiento Then
                            MiErrores.AdicionaError(True, NumLinea, "Cuenta", "La Cuenta NO es de Movimiento")
                        End If
                    End If
                    If Cta.EsdeTercero Then
                        If Not ExisteDatoValida(DatoValida.Tercero, Fila("TerceroMov")) Then
                            MiErrores.AdicionaError(True, NumLinea, "Tercero Movimiento", "No Existe el Tercero del Movimiento " + Fila("TerceroMov").ToString)
                        End If
                    End If
                    If Cta.Detalla Then
                        If Fila("Factura") = "" Then
                            MiErrores.AdicionaError(True, NumLinea, "Doc Cruce", "Cuenta detalla debe ingresar un documento")
                        End If
                        If Fila("Cuota") <= 0 Then
                            MiErrores.AdicionaError(True, NumLinea, "Cuota", "Cuenta detalla Debe terner una cuota mayor a cero (0), Valor: " + Fila("Cuota").ToString)
                        End If
                    End If
                    If Cta.ManejaCC Then
                        If Not ExisteDatoValida(DatoValida.CentrodeCosto, Fila("Ccosto")) Then
                            MiErrores.AdicionaError(True, NumLinea, "Centro de Costo", "Cuenta es de centro de costos, Debe Ingresar un centro de costos, Cc: " + Fila("Ccosto").ToString)
                        End If
                    End If
                    If Cta.EsdeRetencion Then
                        If Not ExisteDatoValida(DatoValida.ConceptoRete, Fila("ConceptoRet")) Then
                            MiErrores.AdicionaError(True, NumLinea, "Retención en la Fuente", "Cuenta es de retencion, Debe Ingresar un concepto de retención, Concep Ret: " + Fila("ConceptoRet").ToString)
                        End If
                    End If
                    If Cta.EsdeIVA Then
                        If Not ExisteDatoValida(DatoValida.CodIva, Fila("CodigoTipoIva")) Then
                            MiErrores.AdicionaError(True, NumLinea, "Cuenta de Impuestos", "Cuenta es de IVA, Debe Ingresar un tipo de Impuesto Valido, Codigo: " + Fila("CodigoTipoIva").ToString)
                        End If
                    End If
                    If Cta.ControlPersonal Then
                        If Fila("CtrlPersonal") = "" Then
                            MiErrores.AdicionaError(True, NumLinea, "Control Personalizado", "Debe Indicar el Control Personalizado")
                        Else
                            If ExisteDatoValida(DatoValida.CodigoControlPersonalizado, Fila("CtrlPersonal")) Then
                                If TipoControl_ControlPE(Fila("CtrlPersonal")) <> Convert.ToInt16(Cta.TipoCP) Then
                                    MiErrores.AdicionaError(True, NumLinea, "Control Personalizado", "EL Codigo del Control no corresponde al tipo del control asignado a la cuenta contable")
                                End If
                            Else
                                MiErrores.AdicionaError(True, NumLinea, "Control Personalizado", "No Existe el codigo del control  asignado a la Cuenta Contable")
                            End If
                        End If
                    End If
                    If Cta.ControlaActivos Then
                        If Fila("Activo") = "" Then
                            MiErrores.AdicionaError(True, NumLinea, "Cuenta Controla Activos", "Debe Ingresar un Codigo de Activo Valido")
                        Else
                            If Not ExisteActivo(Fila("Activo"), "") Then
                                MiErrores.AdicionaError(True, NumLinea, "Cuenta Controla Activos", "El Codigo del aCtivo no es Valido : " + Fila("Activo"))
                            Else
                                If Not LaCuentaEsValidaParaElActivo(Fila("Activo"), Fila("CodCuenta")) Then
                                    MiErrores.AdicionaError(True, NumLinea, "Cuenta Controla Activos", "La cuenta no es Valida para el Activo : Activo: " + Fila("Activo") + " Cuenta: " + Fila("Cuenta"))
                                End If
                            End If
                        End If
                    End If
                    If Not (Fila("Nat") = "D" Or Fila("Nat") = "C") Then
                        MiErrores.AdicionaError(True, NumLinea, "Naturaleza Movimiento", "La Naturaleza del Movimiento solo puede ser (D) o (C), y Es : " + Fila("Nat").ToString)
                    End If
                Else

                    MiErrores.AdicionaError(True, NumLinea, "Cuenta Contable", "La cuenta no Existe : Cuenta: " + Fila("Cuenta"))
                End If
            End If
        Next
        If MiErrores.SiTieneErrores Then
            Return False
        Else
            Return True
        End If

    End Function


    Private Function IndiceDatoValidado(Tipo As DatoValida, Valor As String, Valor2 As String, Valor3 As String) As Long
        Dim X As Long
        For X = 1 To UBound(DatosValidados)
            If Tipo = DatoValida.CodigoComprobante Then
                If DatosValidados(X).TipoDatoqueValido = Tipo Then
                    If DatosValidados(X).Valor = Valor And DatosValidados(X).Valor2 = Valor2 Then
                        IndiceDatoValidado = X
                        Exit For
                    End If
                End If
            ElseIf Tipo = DatoValida.NumeroDocumento Then
                If DatosValidados(X).TipoDatoqueValido = Tipo Then
                    If DatosValidados(X).Valor = Valor And DatosValidados(X).Valor2 = Valor2 And DatosValidados(X).Valor3 = Valor3 Then
                        IndiceDatoValidado = X
                        Exit For
                    End If
                End If
            Else
                If DatosValidados(X).TipoDatoqueValido = Tipo Then
                    If DatosValidados(X).Valor = Valor Then
                        IndiceDatoValidado = X
                        Exit For
                    End If
                End If
            End If
        Next X
        Return IndiceDatoValidado
    End Function

    Private Function ExisteComprobante(Tipo As String, IdComp As Byte) As Boolean
        Dim Cond As String = "Estado = 'V' and TipoComp='" + Tipo + "' AND IdComp=" + IdComp.ToString

        Try
            If ExisteDato("Ct_Comprobantes", Cond, MisDatos.ConexLocal) Then Return True
        Catch ex As Exception

        End Try
        Return False
    End Function
    Private Function Guardar_Comprobante(Mov As DataTable, ByRef MiErrores As ListaErrores, GeneraConsecutivo As Boolean) As Boolean
        Dim Tipo As String = "", Cod As Byte = 0, Num As Long = 0, Item As Integer = 0, CreoDocumento As Boolean = False, NumDoc As ULong = 0
        Dim Debitos As Double = 0, Creditos As Double = 0, ComandosSQL As New List(Of String)
        Dim TxtSQL As String = "", InicioTran As Boolean = False
        Dim Cmd As SqlCommand = MisDatos.ConexLocal.conection.CreateCommand, Comp As New DatosComprobante, SecDocumento As ULong
        Dim Respuesta As Integer = 0, Mensaje As String = ""
        Try
        InicioTran = True
            Cmd.Transaction = MisDatos.ConexLocal.Tran
            For Each Fila As DataRow In Mov.Rows
                If Not (Tipo = Fila("TipoComp") And Cod = Fila("CodComp")) Then
                    Tipo = Fila("TipoComp")
                    Cod = Fila("CodComp")
                    If GeneraConsecutivo Then
                        NumDoc = ConsecutivoServidor(Tipo, Cod)
                    Else
                        NumDoc = Fila("NumeroDoc")
                    End If
                    Item = 0
                    LeerDatosComprobante(Tipo, Cod, Comp)
                End If
                If Not (Tipo = Fila("TipoComp") And Cod = Fila("CodComp") And NumDoc = Fila("NumeroDoc")) Then
                    If GeneraConsecutivo Then
                        NumDoc = ConsecutivoServidor(Tipo, Cod)
                    Else
                        NumDoc = Fila("NumeroDoc")
                    End If


                    If CreoDocumento Then
                        If ComandosSQL.Count > 0 Then
                            Dim TextoEjecuta As String = ""
                            For Each Txt As String In ComandosSQL ' Armo texto con todos los insert de los movimientos del documento
                                TextoEjecuta += Txt + ";"
                            Next
                            ComandosSQL.Clear()
                            Cmd.CommandText = TextoEjecuta
                            Cmd.ExecuteNonQuery() ' inserto los movimientos del documento
                        End If
                        Actualizar_Documento(SecDocumento, Respuesta, Mensaje) 'Actualizo el documento
                        If Respuesta <> 10 Then Throw New System.Exception("Se Presento un Error Actualizado Documento: " + Mensaje)
                        MiErrores.AdicionaError(False, SecDocumento, "Actualizo Documento", String.Format("Se Actualizo Documento {0}-{1}-{2}", Tipo, Cod, NumDoc))
                        TxtSQL = String.Format("update ct_documentos set Doc_Valor= {0} ,Doc_TotalMovimientos = {1} WHERE Doc_Secuencial = {2}", Debitos, Item, SecDocumento)
                        MisDatos.ConexLocal.SMT_EjcutarComandoSql(TxtSQL)
                        TxtSQL = "Update CT_Comprobantes set NumSiguiente = NumSiguiente + 1 Where TipoComp='" & Tipo & "' AND IdComp=" & Cod
                        MisDatos.ConexLocal.SMT_EjcutarComandoSql(TxtSQL)
                        Item = 0
                        Debitos = 0
                        Creditos = 0
                        CreoDocumento = False
                    End If
                End If
                If Not CreoDocumento Then
                    Cmd.CommandText = SQL_Crear_Documento(NumDoc, Fila, Comp)
                    If Cmd.ExecuteNonQuery() > 0 Then
                        SecDocumento = Secuencial_Documento(Tipo, Cod, NumDoc)
                        CreoDocumento = True
                    End If
                End If
                Item = Item + 1
                If Fila("Nat").ToString.ToUpper = "D" Then
                    Debitos += Fila("Valor")

                ElseIf Fila("Nat").ToString.ToUpper = "C" Then
                    Creditos += Fila("Valor")
                End If
                ComandosSQL.Add(SQL_Crear_Movtos_Local(Fila, SecDocumento, Item))
            Next
            If CreoDocumento Then
                If ComandosSQL.Count > 0 Then
                    Dim TextoEjecuta As String = ""
                    For Each Txt As String In ComandosSQL ' Armo texto con todos los insert de los movimientos del documento
                        TextoEjecuta += Txt + ";"
                    Next
                    ComandosSQL.Clear()
                    TextoEjecuta = TextoEjecuta.Trim
                    Cmd.CommandText = TextoEjecuta
                    Cmd.ExecuteNonQuery() ' inserto los movimientos del documento
                End If
                Actualizar_Documento(SecDocumento, Respuesta, Mensaje) 'Actualizo el documento
                If Respuesta <> 10 Then Throw New System.Exception("Se Presento un Error Actualizado Documento: " + Mensaje)
                MiErrores.AdicionaError(False, SecDocumento, "Actualizo Documento", String.Format("Se Actualizo Documento {0}-{1}-{2}", Tipo, Cod, NumDoc))
                TxtSQL = String.Format("update ct_documentos set Doc_Valor= {0} ,Doc_TotalMovimientos = {1} WHERE Doc_Secuencial = {2}", Debitos, Item, SecDocumento)
                MisDatos.ConexLocal.SMT_EjcutarComandoSql(TxtSQL)
                TxtSQL = "Update CT_Comprobantes set NumSiguiente = NumSiguiente + 1 Where TipoComp='" & Tipo & "' AND IdComp=" & Cod
                MisDatos.ConexLocal.SMT_EjcutarComandoSql(TxtSQL)
            End If
            Return True
        Catch ex As Exception
            MiErrores.AdicionaError(False, 0, ex.Source, ex.Message)
            Return False
        End Try
    End Function

    Private Sub Actualizar_Documento(SecDocumento As ULong, ByRef Respta As Integer, ByRef Mensaje As String)
        Dim Cmd As New SqlCommand("SP_CNT_ActualizarDocumentos", MisDatos.ConexLocal.conection)
        Try
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Parameters.Add("@SEcuencial", SqlDbType.Int).Value = SecDocumento
            Cmd.Parameters.Add("@F", SqlDbType.Int).Value = 1 'Parametro Actualiza DOC
            Cmd.Parameters.Add("@Resultado", SqlDbType.TinyInt)
            Cmd.Parameters("@Resultado").Direction = ParameterDirection.Output
            Cmd.Parameters.Add("@TextMsg", SqlDbType.VarChar, 200)
            Cmd.Parameters("@TextMsg").Direction = ParameterDirection.Output
            Cmd.Transaction = MisDatos.ConexLocal.Tran
            Cmd.ExecuteNonQuery()
            Respta = Cmd.Parameters("@Resultado").Value
            Mensaje = Cmd.Parameters("@TextMsg").Value
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try



    End Sub
    Public Sub Anular_Documento_Contable(SERVIDOR As String, Empresa As Integer, Oficina As Integer, Año As Integer, SecDocumento As ULong, ByRef Respta As Integer, ByRef Mensaje As String, Optional Passwd As String = "2121121512")
        Try
            MisDatos.FechaHora = Now
            MisDatos.Empresa = Empresa
            MisDatos.NomBD = String.Format("E{0}{1}", Empresa.ToString("000"), Año.ToString("0000"))
            MisDatos.NomBDGen = "SEGURIDAD"
            MisDatos.ConexLocal = New Conexion(MisDatos.NomBD, SERVIDOR, Passwd)
            MisDatos.ConexSeg = New Conexion(MisDatos.NomBDGen, SERVIDOR, Passwd)
            'MisDatos.ConexLocal.ConnectionString = "server=" + SERVIDOR + ";database=" + MisDatos.NomBD + ";uid=sa;password=2121121512;"
            'MisDatos.ConexSeg.ConnectionString = "server=" + SERVIDOR + ";database=" + MisDatos.NomBDGen + ";uid=sa;password=2121121512;"
            'MisDatos.ConexLocal.Open()
            'MisDatos.ConexSeg.Open()
        Catch ex As Exception
            Mensaje = "No se ha podido conectar con el servidor! (" + ex.Message + ")"
            Exit Sub
        End Try

        Dim Cmd As New SqlCommand("Sp_Cnt_ProcesarDocumentos", MisDatos.ConexLocal.conection)
        Try
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Parameters.Add("@SEcuencial", SqlDbType.Int).Value = SecDocumento
            Cmd.Parameters.Add("@Accion", SqlDbType.Int).Value = 1 'Parametro Anula DOC
            Cmd.Parameters.Add("@Respuesta", SqlDbType.TinyInt)
            Cmd.Parameters("@Respuesta").Direction = ParameterDirection.Output
            Cmd.Parameters.Add("@TextMsg", SqlDbType.VarChar, 200)
            Cmd.Parameters("@TextMsg").Direction = ParameterDirection.Output
            Cmd.ExecuteNonQuery()
            Respta = Cmd.Parameters("@Respuesta").Value
            Mensaje = Cmd.Parameters("@TextMsg").Value
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try



    End Sub

    Private Function SQL_Crear_Documento(NumDoc As ULong, Fila As DataRow, Com As DatosComprobante) As String
        Dim SQLcampos As String = "", SQLValues As String = "", TxtSql As String = ""
        SQLcampos = "(Doc_Oficina, Doc_TipoComp,Doc_IdComp, Doc_NumDocumento, Doc_FechaDoc, "
        If (Com.ReqTercer Or Fila("Tercero") > 0) Then SQLcampos = SQLcampos & " Doc_Tercero, "
        SQLcampos = SQLcampos & "Doc_Detalle, Doc_Valor, Doc_TotalMovimientos, Doc_Comentario, Doc_NumCheque, " & _
                    "Doc_Usuario, Doc_Terminal, Doc_GenVehi, Doc_FechaSistema,Doc_GenInv, " & _
                    "Doc_SesionCrea,Doc_EsdeCierre,Doc_CCpred,Doc_ModoNIIF )"

        SQLValues = "(" & Fila("Oficina") & ",'" & Fila("TipoComp") & "'," & Fila("CodComp") & "," & _
                     NumDoc.ToString & ",'" & Fila("Fecha") & "', "
        If (Com.ReqTercer Or Fila("Tercero") > 0) Then SQLValues += Fila("Tercero") & ", "
        SQLValues = SQLValues & "'" & Fila("DetalleGeneral") & "',0,0,'" & Fila("Comentario") & "','" & Fila("NumCheque") & "','" &
                     Fila("UsuarioCrea") & "','" & My.Computer.Name & "',0,GETDATE(),0,0,0,0," & Com.ModoNIIF & ")"

        TxtSql = "INSERT INTO CT_Documentos " & SQLcampos & " VALUES " & SQLValues
        Return TxtSql
    End Function
    Private Function Secuencial_Documento(Tipo As String, NumComprobante As Byte, NumeroDucumento As Long) As Long
        On Error Resume Next
        Dim TxtSQL As String, Tb As DataTable, Dato As ULong
        TxtSQL = "Select Doc_Secuencial From Ct_Documentos Where Doc_TipoComp='" & Tipo & _
                 "' AND Doc_IdComp=" & NumComprobante & _
                 " And Doc_NumDocumento =" & NumeroDucumento
        Tb = SMT_AbrirTabla(MisDatos.ConexLocal, TxtSQL)
        Dato = Tb(0)(0)
        Tb.Dispose()
        Return Dato
    End Function

    Private Function SQL_Crear_Movtos_Local(Fila As DataRow, SecDocumento As ULong, Item As ULong) As String
        'On Error Resume Next
        Dim SQLcampos As String = "", SQLValues As String = "", TxtSql As String = ""
        Dim Cta As DatosCuenta

        Cta = DatosdelaCuenta(Fila("Cuenta"))

        With Cta
            SQLcampos = "(Mov_Documento,Mov_Item,Mov_Cuenta,"
            SQLValues = "(" & SecDocumento & "," & Item & ",'" & .CodCuenta & "',"

            If .EsdeTercero Then
                SQLcampos = SQLcampos & "Mov_Tercero,"
                SQLValues = SQLValues & Fila("TerceroMov") & ","
                If Not IsDBNull(Fila("Estab")) Then
                    SQLcampos = SQLcampos & "Mov_TerEstab,"
                    SQLValues = SQLValues & Fila("Estab").ToString & ","
                End If
            End If
            If .Detalla Then
                SQLcampos = SQLcampos & "Mov_DocDetalle,Mov_Cuota,Mov_FecVcto, "
                SQLValues = SQLValues & "'" & Fila("Factura").ToString & "'," & Fila("Cuota") & ",'" & Fila("FechaVence").ToString & "',"
            End If
            If .ManejaCC Then
                SQLcampos = SQLcampos & "Mov_CentroCosto, "
                SQLValues = SQLValues & Fila("Ccosto").ToString & ","
            End If
            If .EsdeRetencion Then
                SQLcampos = SQLcampos & "Mov_Concepto,Mov_Base, "
                SQLValues = SQLValues & Fila("ConceptoRete") & "," & Fila("BaseRete") & ","
            End If
            If .EsdeIVA Then
                SQLcampos = SQLcampos & "Mov_TipoIva,Mov_Base, "
                SQLValues = SQLValues & Fila("CodigoTipoIva") & "," & Fila("BaseIva") & ","
            End If
            If .ControlaActivos Then
                If .ControlaActivos Then
                    SQLcampos = SQLcampos & "Mov_Activo, "
                    SQLValues = SQLValues & "'" & Fila("Activo") & "',"
                End If
            End If
            If .ControlPersonal Then
                SQLcampos = SQLcampos & "Mov_ControlE, "
                SQLValues = SQLValues & "'" & Fila("ControlPE") & "',"
            End If

            SQLcampos = SQLcampos & "Mov_Detalle,Mov_DC,Mov_Valor"
            SQLValues = SQLValues & "'" & Fila("TextoDetalle") & "','" & Fila("Nat") & "'," & Fila("Valor").ToString
            SQLcampos = SQLcampos & ")"
            SQLValues = SQLValues & ")"
            TxtSql = "INSERT INTO CT_Movimientos " & SQLcampos & " VALUES " & SQLValues
        End With
        Return TxtSql
    End Function
    Public Function DatosdelaCuenta(Cuenta As String, Optional Tran As SqlTransaction = Nothing) As DatosCuenta
        'On Error Resume Next
        Dim tb As DataTable, SQL As String = "Select * from ct_plandecuentas where Estado = 'V' AND Codcuenta = '" + Cuenta + "'"
        Dim Cta As New DatosCuenta
        If Not ListaCuentas.Exists(Function(i) i.CodCuenta = Cuenta) Then
            Try
                tb = SMT_AbrirTabla(MisDatos.ConexLocal, SQL)
                If tb.Rows.Count = 1 Then
                    Dim F As DataRow
                    Cta.ExisteCta = True
                    F = tb(0)
                    Cta.CodCuenta = F("CodCuenta")
                    Cta.NomCuenta = F("NomCuenta")
                    Cta.EsdeMovimiento = F("EsdeMovimiento")
                    If F("TerCuenta") = "N" Then
                        Cta.EsdeTercero = False
                    End If
                    If F("TerCuenta") = "S" Then
                        Cta.EsdeTercero = True
                    End If
                    If F("TerCuenta") = "R" Then
                        Cta.EsdeTercero = True
                        Cta.EsdeRetencion = True
                    End If
                    If F("TerCuenta") = "I" Then
                        Cta.EsdeTercero = True
                        Cta.EsdeIVA = True
                    End If
                    Cta.ManejaCC = F("ManejaCC")
                    Cta.Detalla = False
                    If F("Detalla") <> "N" Then
                        Cta.Detalla = True
                        If F("Detalla") = "P" Then
                            Cta.EsporPagar = True
                        Else
                            Cta.EsPorCobrar = True
                        End If
                    End If
                    Cta.ControlPersonal = IIf(IsDBNull(F("UtilizaCP")), False, F("UtilizaCP"))
                    Cta.TipoCP = IIf(IsDBNull(F("TipoCP")), False, F!TipoCp)
                    Cta.ControlaActivos = False
                    If ExisteTabla(MisDatos.ConexLocal, "AC_Grupos") Then
                        SQL = " CtaVrHis ='" & Cuenta & "' OR CtaPVal ='" & Cuenta & "' OR CtaVal ='" & Cuenta & "' OR CtaProv ='" & Cuenta & "'"
                        If ExisteDato("AC_Grupos", SQL, MisDatos.ConexLocal) Then Cta.ControlaActivos = True
                    End If
                    ListaCuentas.Add(Cta)
                Else
                    Cta.ExisteCta = False
                End If
            Catch ex As Exception

            End Try

        Else
            Try
                Cta = ListaCuentas.Find(Function(i) i.CodCuenta = Cuenta)
            Catch ex As Exception

            End Try

        End If
        Return Cta
    End Function
    Private Function ExisteDatoValida(Tipo As DatoValida, Valor As String, Optional Valor2 As String = "", Optional Valor3 As String = "") As Boolean
        On Error GoTo ControlError
        Dim ConsultoBD As Boolean, IndiceValidado As Long, VrExiste As Boolean, ValoresValidos As Boolean
        IndiceValidado = IndiceDatoValidado(Tipo, Valor, Valor2, Valor3)
        If Not MisDatos.ConexLocal.conection.State = ConnectionState.Open Then Return False
        If IndiceValidado > 0 Then ConsultoBD = True
        If Not ConsultoBD Then

            If Tipo = DatoValida.CentrodeCosto Or Tipo = DatoValida.Tercero Or Tipo = DatoValida.CodIva Or Tipo = DatoValida.ConceptoRete Or Tipo = DatoValida.Oficina Or Tipo = DatoValida.TipoComprobante Or Tipo = DatoValida.CodigoControlPersonalizado Then
                If String.IsNullOrEmpty(Valor) Then ValoresValidos = False Else ValoresValidos = True
            ElseIf Tipo = DatoValida.CodigoComprobante Then
                If (String.IsNullOrEmpty(Valor) Or Valor = "" Or String.IsNullOrEmpty(Valor2) Or Valor2 = "") Then ValoresValidos = False Else ValoresValidos = True
            ElseIf Tipo = DatoValida.NumeroDocumento Then
                If (String.IsNullOrEmpty(Valor) Or Valor = "" Or String.IsNullOrEmpty(Valor2) Or Valor2 = "" Or String.IsNullOrEmpty(Valor3) Or Valor3 = "") Then ValoresValidos = False Else ValoresValidos = True
                ValoresValidos = True
            End If
            If ValoresValidos Then
                If Tipo = DatoValida.CentrodeCosto Then
                    VrExiste = ExisteDato("CT_CentroCostos", "Cod_CentroCosto=" & Valor, MisDatos.ConexLocal)
                ElseIf Tipo = DatoValida.TipoComprobante Then
                    VrExiste = ExisteDato("CT_ComTipo", "IdTC='" & Valor & "'", MisDatos.ConexLocal)
                ElseIf Tipo = DatoValida.CodigoComprobante Then
                    'VrExiste = ExisteDato("CT_Comprobantes", "TipoComp='" & Valor2 & "' AND IdComp=" & Valor, conex)
                    If IsNumeric(Valor) Then
                        If CInt(Valor) <= 255 Then
                            'VrExiste = ExisteComprobanteImporta(Valor2, CByte(Valor))
                            VrExiste = ExisteComprobante(Valor2, CByte(Valor))
                        End If
                    Else
                        VrExiste = False
                    End If
                ElseIf Tipo = DatoValida.CodIva Then
                    VrExiste = ExisteDato("IN_TipoIva", "CodIva=" & Valor, MisDatos.ConexLocal)
                ElseIf Tipo = DatoValida.ConceptoRete Then
                    VrExiste = ExisteDato("CT_RetConceptos", "CodConcepto=" & Valor, MisDatos.ConexLocal)
                ElseIf Tipo = DatoValida.NumeroDocumento Then
                    VrExiste = ExisteDato("CT_Documentos", "Doc_TipoComp='" & Valor & "' AND Doc_IdComp=" & Valor2 & " AND Doc_NumDocumento=" & Valor3, MisDatos.ConexLocal)
                ElseIf Tipo = DatoValida.Oficina Then
                    VrExiste = ExisteDato("Oficinas", "NumEmpresa=" & MisDatos.Empresa & " and NumOficina=" & Valor, MisDatos.ConexSeg)
                ElseIf Tipo = DatoValida.Tercero Then
                    VrExiste = ExisteDato("G_Clientes", "Identificacion=" & Valor, MisDatos.ConexLocal)
                ElseIf Tipo = DatoValida.EstablecimientoTercero Then

                ElseIf Tipo = DatoValida.CodigoControlPersonalizado Then
                    VrExiste = ExisteDato("CT_CP_Control", "CodControl='" & Valor & "'", MisDatos.ConexLocal)
                End If
            End If
            ReDim Preserve DatosValidados(UBound(DatosValidados) + 1)
            DatosValidados(UBound(DatosValidados)).Existe = VrExiste
            DatosValidados(UBound(DatosValidados)).TipoDatoqueValido = Tipo
            DatosValidados(UBound(DatosValidados)).Valor = Valor
            DatosValidados(UBound(DatosValidados)).Valor2 = Valor2
            DatosValidados(UBound(DatosValidados)).Valor3 = Valor3
            IndiceValidado = UBound(DatosValidados)
        End If
        ExisteDatoValida = DatosValidados(IndiceValidado).Existe
        Exit Function
ControlError:
    End Function
    Private Function TraerErrores(MiErrores As List(Of ListaErrores)) As DataTable
        Dim Tb As New DataTable
        MiErrores.OrderBy(Function(x) x.Linea)
        Tb.Columns.Add("EsError", GetType(Boolean))
        Tb.Columns.Add("Linea", GetType(ULong))
        Tb.Columns.Add("Campo", GetType(String))
        Tb.Columns.Add("Mensaje", GetType(String))
        For Each Dato As ListaErrores In MiErrores
            Dim R As DataRow = Tb.NewRow
            R("Eserror") = Dato.EsError
            R("Linea") = Dato.Linea
            R("Campo") = Dato.Campo
            R("Mensaje") = Dato.TxtError
            Tb.Rows.Add(R)
        Next

        Return Tb
    End Function
    Public Function ConsecutivoServidor(Tipo As String, IdComp As Byte) As Long
        On Error GoTo ControlError
        Dim Tbl As DataTable, TxtSQL As String, Consecutivo As Long

INICIA:
        TxtSQL = "Select Numsiguiente, NumAutomatica From CT_Comprobantes " & _
                 "Where TipoComp='" & Tipo & "' And IdComp=" & IdComp
        Tbl = MisDatos.ConexLocal.SMT_AbrirTabla(TxtSQL)

        If Tbl.Rows.Count = 1 Then Consecutivo = Tbl(0)("NumSiguiente")
VERIFICA:
        If Tbl.Rows.Count < 1 Then
            TxtSQL = "SELECT COUNT(Doc_Secuencial) as Total From Ct_Documentos Where " & _
                     "Doc_TipoComp='" & Tipo & "' And Doc_IdComp=" & IdComp & _
                     " and Doc_NumDocumento =" & Consecutivo.ToString
            Tbl = MisDatos.ConexLocal.SMT_AbrirTabla(TxtSQL)
            If Tbl(0)("Total") > 0 Then
                TxtSQL = "Update Ct_Comprobantes Set NumSiguiente =NumSiguiente + 1 Where TipoComp='" & Tipo & "' And IdComp=" & IdComp.ToString
                MisDatos.ConexLocal.SMT_EjcutarComandoSql(TxtSQL)

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
End Class
