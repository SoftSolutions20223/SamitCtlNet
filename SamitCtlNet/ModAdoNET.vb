Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports SamitCore
Imports Newtonsoft.Json.Linq

Public Module ModAdoNET
    Public ObjetoApiNomina As Api
    Public Function ExisteBd(ByVal Nombre_BD As String) As Boolean
        Dim TbSamit As DataTable
        Dim SQL As String
        ExisteBd = False
        SQL = "select * From master..sysdatabases WHERE name = '" & Nombre_BD & "'"
        TbSamit = SMT_AbrirTabla(SMTConex, SQL)

        If TbSamit.Rows.Count Then ExisteBd = True
        TbSamit.Dispose()
    End Function
    Public Function ExisteDato(Tabla As String, Cond As String, ByRef Conex As Object, Optional CampoYnoNull As String = "", Optional MostrarMensageError As Boolean = True) As Boolean
        ' Funcion que nos indica se existe Una Cuenta Contable

        Dim TxtSQL As String
        If Tabla <> "" Then
            If CampoYnoNull = "" Then

                TxtSQL = $"Select top 1 * From {Tabla} Where {Cond}"
            Else
                TxtSQL = $"Select top 1 {CampoYnoNull} From {Tabla} Where {Cond}"
            End If
        End If

        If TypeOf Conex Is SqlConnection Then

            Dim Tbl As DataTable
            Dim Campo As String, RetexisteDato As Boolean = False
            Dim Con As SqlConnection = New SqlConnection()
            If TypeOf Conex Is SqlConnection Then
                Con = CType(Conex, SqlConnection)
            End If

            RetexisteDato = False
            If Tabla <> "" Then
                If CampoYnoNull = "" Then

                    TxtSQL = $"Select top 1 * From {Tabla} Where {Cond}"
                    If TypeOf Conex Is SqlConnection Then
                        Tbl = SMT_AbrirRecordSet(Con, TxtSQL)
                    Else
                        'se especifica que hacer
                    End If
                    If Tbl.Rows.Count > 0 Then RetexisteDato = True
                Else
                    TxtSQL = $"Select top 1 {CampoYnoNull} From {Tabla} Where {Cond}"
                    If TypeOf Conex Is SqlConnection Then
                        Tbl = SMT_AbrirRecordSet(Con, TxtSQL)
                    Else
                        'se especifica que hacer
                    End If
                    If Tbl.Rows.Count > 0 Then
                        If IsNothing(Tbl.Rows(0)(0)) Then
                            RetexisteDato = False
                        Else
                            RetexisteDato = True
                        End If
                    End If
                End If
            Else
                TxtSQL = Cond
                If TypeOf Conex Is SqlConnection Then
                    Tbl = SMT_AbrirRecordSet(Con, TxtSQL)
                Else
                    'se especifica que hacer
                End If
                If Tbl.Rows.Count > 0 Then RetexisteDato = True
            End If
            Tbl.Dispose()
            Return RetexisteDato

            Tbl.Dispose()
            If MostrarMensageError Then MensajedeError()
            Return False

        ElseIf TypeOf Conex Is Api Then
            Try
                Dim MiApi As Api = CType(Conex, Api)
                Dim paramsDefinition = New With {
                    .sql = TxtSQL
                }
                Dim url = $"/Api/Parametros.asmx/SqlGet"
                Dim resApi = MiApi.ApiPOST(Of DataTable)(url, paramsDefinition)
                If Not IsNothing(resApi.ObjetoRes) Then
                    If resApi.ObjetoRes.Columns.Contains("NoContieneDatos") Then
                        resApi.ObjetoRes.Columns.Remove("NoContieneDatos")
                        resApi.ObjetoRes.Rows.Clear()
                    End If
                End If
                Dim existe As Boolean
                Dim tabl = resApi.ObjetoRes
                If Tabla <> "" Then
                    If CampoYnoNull = "" Then
                        If tabl.Rows.Count > 0 Then existe = True
                    Else
                        If tabl.Rows.Count > 0 Then
                            If IsNothing(tabl.Rows(0)(0)) Then
                                existe = False
                            Else
                                existe = True
                            End If
                        End If
                    End If
                Else
                    If tabl.Rows.Count > 0 Then existe = True
                End If
                Return existe
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Function
    Public Function SMT_AbrirRecordSetReader(ByVal Con As SqlConnection, ByVal SQL As String) As SqlDataReader
        Dim SMTCmd As New SqlCommand
        SMT_AbrirRecordSetReader = Nothing
        Try
            SMTCmd.Connection = Con
            SMTCmd.CommandText = SQL
            SMTCmd.CommandType = CommandType.Text
            SMT_AbrirRecordSetReader = SMTCmd.ExecuteReader
            Return SMT_AbrirRecordSetReader
            SMTCmd = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function
    Public Function SMT_AbrirRecordSet(ByVal Con As Object, ByVal SQL As String) As DataTable
        Dim SMTCmd As New SqlCommand, TB As New DataTable, Adaptador As SqlDataAdapter, Dr As SqlDataReader
        Try
            SMTCmd.Connection = Con
            SMTCmd.CommandText = SQL
            SMTCmd.CommandType = CommandType.Text
            Dr = SMTCmd.ExecuteReader
            TB.Load(Dr)
            SMTCmd.Dispose()
            Dr.Close()
        Catch ex As Exception
            MensajedeError(ex.Message)

        End Try
        Return TB
    End Function
    Public Sub ValidarConexionConServidor(CadenaConexion As String)
        Dim ConexPrueba As New SqlConnection
        Try
            HayConexionConSRV = True
            Using loConexion As New SqlConnection(CadenaConexion)
                loConexion.Open()
                HayConexionConSRV = True
            End Using
        Catch Exp As Exception
            HayConexionConSRV = False
        End Try
        Exit Sub
    End Sub

    Public Function SMT_AbrirTabla(ByVal Conex As Object, ByVal SQL As String) As DataTable
        Try

            If TypeOf Conex Is SqlConnection Then
                Dim Con As SqlConnection = CType(Conex, SqlConnection)
                Dim SMTCmd As New SqlCommand, TB As New DataTable, Adaptador As SqlDataAdapter
                SMTCmd.Connection = Con
                SMTCmd.CommandText = SQL
                SMTCmd.CommandType = CommandType.Text
                Adaptador = New SqlDataAdapter(SMTCmd)
                Adaptador.Fill(TB)
                Adaptador.Dispose()
                SMTCmd.Dispose()
                Return TB
            ElseIf TypeOf Conex Is Api Then
                Dim MiApi As Api = CType(Conex, Api)
                Dim paramsDefinition = New With {
                    .sql = SQL
                }
                Dim url = $"/Api/Parametros.asmx/SqlGet"
                Dim resApi As ApiResponseClient(Of DataTable)
                Dim Res As New DataTable
                Res = Nothing
                Dim contador = 0
                Do While IsNothing(Res) Or contador <= 3
                    contador = contador + 1
                    resApi = MiApi.ApiPOST(Of DataTable)(url, paramsDefinition)
                    If Not IsNothing(resApi.ObjetoRes) Then
                        If resApi.ObjetoRes.Columns.Contains("NoContieneDatos") Then
                            resApi.ObjetoRes.Columns.Remove("NoContieneDatos")
                            resApi.ObjetoRes.Rows.Clear()
                        End If
                        Exit Do
                    End If
                Loop

                Return resApi.ObjetoRes
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function SMT_GetDataset(ByVal Conex As Object, ByVal SQLQueries() As String) As DataSet
        Try
            If TypeOf Conex Is SqlConnection Then
                Dim Con As SqlConnection = CType(Conex, SqlConnection)
                Dim dataset As New DataSet()
                For i As Integer = 0 To SQLQueries.Length - 1
                    Dim SMTCmd As New SqlCommand
                    Dim TB As New DataTable($"Tabla{i}")
                    Dim Adaptador As SqlDataAdapter
                    SMTCmd.Connection = Con
                    SMTCmd.CommandText = SQLQueries(i)
                    SMTCmd.CommandType = CommandType.Text
                    Adaptador = New SqlDataAdapter(SMTCmd)
                    Adaptador.Fill(TB)
                    Adaptador.Dispose()
                    SMTCmd.Dispose()
                    dataset.Tables.Add(TB)
                Next
                Return dataset
            ElseIf TypeOf Conex Is Api Then
                Dim MiApi As Api = CType(Conex, Api)
                Dim paramsDefinition = New With {
                .sqlQueries = SQLQueries
            }
                Dim url = $"/Api/Parametros.asmx/SqlGetMultiple"
                Dim resApi As ApiResponseClient(Of DataSet)
                Dim ResDataSet As New DataSet
                Dim contador = 0

                Do While ResDataSet.Tables.Count = 0 AndAlso contador <= 3
                    contador = contador + 1
                    resApi = MiApi.ApiPOST(Of DataSet)(url, paramsDefinition)
                    If Not IsNothing(resApi.ObjetoRes) Then
                        ' Procesar cada tabla devuelta
                        For Each tabla As DataTable In resApi.ObjetoRes.Tables
                            ' Crear una copia de la tabla para poder agregarla al nuevo DataSet
                            Dim tablaCopia As DataTable = tabla.Copy()

                            If tablaCopia.Columns.Contains("NoContieneDatos") Then
                                tablaCopia.Columns.Remove("NoContieneDatos")
                                tablaCopia.Rows.Clear()
                            End If

                            ' Asignar nombre a la tabla si no tiene
                            If String.IsNullOrEmpty(tablaCopia.TableName) Then
                                tablaCopia.TableName = $"Tabla{ResDataSet.Tables.Count}"
                            End If

                            ResDataSet.Tables.Add(tablaCopia)
                        Next
                        Exit Do
                    End If
                Loop
                Return ResDataSet
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function SMT_EjecutaProcedimientos(ByVal Conex As Object, ByVal Procedimiento As String, ByVal Datos As JObject) As JObject
        Try
            If TypeOf Conex Is Api Then
                Dim MiApi As Api = CType(Conex, Api)
                Dim paramsDefinition = New With {
                    .Procedimiento = Procedimiento,
                    .Datos = Datos
                }
                Dim url = $"/Api/Parametros.asmx/SqlProcedures"
                Dim resApi = MiApi.ApiPOST(Of JObject)(url, paramsDefinition)
                Return resApi.ObjetoRes
            End If
            Return Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Sub SMT_EjcutarComandoSql(ByVal Conex As Object, ByVal TxtSQL As String, ByRef Retorno As Long)
        Try


            If TypeOf Conex Is SqlConnection Then
                Dim Con As SqlConnection = CType(Conex, SqlConnection)
                Dim Cmd As New SqlCommand
                Try
                    Cmd.Connection = Con
                    Cmd.CommandText = TxtSQL
                    Cmd.CommandType = CommandType.Text
                    Retorno = Cmd.ExecuteNonQuery()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            Else
                Dim MiApi As Api = CType(Conex, Api)
                Dim paramsDefinition = New With {
                    .sql = TxtSQL
                }
                Dim url = $"/Api/Parametros.asmx/SqlPost"
                Dim resApi As ApiResponseClient(Of DataTable)
                Dim Res As New DataTable
                Res = Nothing
                Dim contador = 0
                Do While IsNothing(Res) Or contador <= 3
                    contador = contador + 1
                    resApi = MiApi.ApiPOST(Of DataTable)(url, paramsDefinition)
                    If Not IsNothing(resApi.ObjetoRes) Then
                        If resApi.ObjetoRes.Columns.Contains("NoContieneDatos") Then
                            resApi.ObjetoRes.Columns.Remove("NoContieneDatos")
                            resApi.ObjetoRes.Rows.Clear()
                        End If
                        Exit Do
                    End If
                Loop
                If resApi.ObjetoRes.Rows.Count > 0 Then
                    If resApi.ObjetoRes.Rows(0)(0).ToString = "si" Then
                        Retorno = 1
                    Else
                        Retorno = 0
                    End If
                Else
                    Retorno = 0
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Function SMT_EjcutarComandoSqlBool(ByVal Conex As Object, ByVal TxtSQL As String) As Boolean

        If TypeOf Conex Is SqlConnection Then
            Dim Con As SqlConnection = CType(Conex, SqlConnection)
            Dim Cmd As New SqlCommand
            Dim retorno As Integer
            Try
                Cmd.Connection = Con
                Cmd.CommandText = TxtSQL
                Cmd.CommandType = CommandType.Text
                retorno = Cmd.ExecuteNonQuery()
                If retorno > 0 Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return False
            End Try
        Else
            Try


                Dim MiApi As Api = CType(Conex, Api)
                Dim paramsDefinition = New With {
                    .sql = TxtSQL
                }
                Dim url = $"/Api/Parametros.asmx/SqlPost"
                Dim resApi As ApiResponseClient(Of DataTable)
                Dim Res As New DataTable
                Res = Nothing
                Dim contador = 0
                Do While IsNothing(Res) Or contador <= 3
                    contador = contador + 1
                    resApi = MiApi.ApiPOST(Of DataTable)(url, paramsDefinition)
                    If Not IsNothing(resApi.ObjetoRes) Then
                        If resApi.ObjetoRes.Columns.Contains("NoContieneDatos") Then
                            resApi.ObjetoRes.Columns.Remove("NoContieneDatos")
                            resApi.ObjetoRes.Rows.Clear()
                        End If
                        Exit Do
                    End If
                Loop
                If resApi.ObjetoRes.Rows.Count > 0 Then
                    If resApi.ObjetoRes.Rows(0)(0).ToString = "si" Then
                        Return True
                    Else
                        Return False
                    End If
                Else
                    Return False
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End If
    End Function

    Public Sub Abrir_Conexion_A_Excell(ByVal Archivo As String)
        SmtConExcell = New System.Data.OleDb.OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Archivo & ";Extended Properties=Excel 8.0;")
        Exit Sub
    End Sub
    Public Function AsignarCampo(Fila As DataRow, Campo As String) As Object
        On Error GoTo ControlError
        Dim Valor = Fila(Campo)
        Dim Tipo = Fila.Table.Columns(Campo).DataType.Name
        If IsDBNull(Fila(Campo)) Then
            If IsNumeric(Fila.Table.Columns(Campo).DataType) Then
                AsignarCampo = 0
            ElseIf IsDate(Fila.Table.Columns(Campo).DataType) Then
                AsignarCampo = Date.Now
            ElseIf (Fila.Table.Columns(Campo).DataType) = GetType(System.Boolean) Then
                AsignarCampo = False
            ElseIf (Fila.Table.Columns(Campo).DataType) = GetType(System.String) Then
                AsignarCampo = "No Contiene Nada"
            Else
                AsignarCampo = Nothing
            End If
            Exit Function
        End If
        AsignarCampo = Fila(Campo)
        Exit Function
ControlError:
        MensajedeError()
    End Function

    Public Function ExisteTabla(ByRef ConeXion As SqlConnection, NombreTabla As String) As Boolean
        On Error GoTo Err_ExisteTabla
        Dim Tbl As New DataTable, TxtSQL As String
        TxtSQL = "Select Name From SysObjects Where Name = '" & NombreTabla & "' And Xtype = 'U'"
        Tbl = SMT_AbrirRecordSet(ConeXion, TxtSQL)
        If Tbl.Rows.Count <= 0 Then
            ExisteTabla = False
        Else
            ExisteTabla = True
        End If
        Exit Function
Err_ExisteTabla:
        MensajedeError()
    End Function
    Public Function TraerDatoSQL(SQL As String, ByVal Conex As Object, Columna As String) As Object
        On Error GoTo Err_TraerDatoSQL

        Dim MyRcs As DataTable
        TraerDatoSQL = ""
        If TypeOf Conex Is SqlConnection Then
            Dim Con As SqlConnection = CType(Conex, SqlConnection)
            MyRcs = SMT_AbrirRecordSet(Con, SQL)
            If MyRcs.Rows.Count <= 0 Then Exit Function
            If IsDBNull(MyRcs(0)(Columna).Value) Then
                If IsNumeric(MyRcs(0)(Columna)) Then
                    TraerDatoSQL = 0
                Else
                    TraerDatoSQL = ""
                End If
            ElseIf Not IsNumeric(MyRcs(0)(Columna)) Then
                TraerDatoSQL = MyRcs(0)(Columna)
            Else
                TraerDatoSQL = MyRcs(0)(Columna)
            End If
        Else
            'se especifica que hacer
        End If
Exit_TraerDatoSQL:
        Exit Function
Err_TraerDatoSQL:
        MensajedeError()
        Resume Exit_TraerDatoSQL
    End Function
    Public Function Agregar_Campo(ByRef Conexion As SqlConnection, Tabla As String, NombreCampo As String,
                TipodeDato As String, Optional PermiteNulos As Boolean = True, Optional ValorPorDefecto As String = "") As Integer
        On Error GoTo Err_AnchoCampoSql
        Dim Tbl As New DataTable, TxtSQL As String, R As Long = 0
        If Not ExisteCampo(Conexion, Tabla, NombreCampo) Then
            TxtSQL = "ALTER TABLE " & Tabla & " ADD " & NombreCampo & " " & TipodeDato
            If Not PermiteNulos Then
                TxtSQL = TxtSQL & " NOT NULL "
            End If
            If ValorPorDefecto <> "" Then
                TxtSQL = TxtSQL & " DEFAULT  (" & ValorPorDefecto & ")"
            End If
            SMT_EjcutarComandoSql(Conexion, TxtSQL, R)
        End If
        Return R
Exit_AnchoCampoSql:
        Exit Function
Err_AnchoCampoSql:
        MensajedeError()
        Resume Exit_AnchoCampoSql
    End Function
    Public Function ExisteCampo(ByRef Conex As SqlConnection, TablaOrigen As String, NombreCampo As String) As Boolean
        ' Funcion para Consultar el Ancho de un Campo en una tabla dada, de la conexion dada
        On Error GoTo Err_AnchoCampoSql
        Dim Tbl As New DataTable, TxtSQL As String
        TxtSQL = "select b.name, b.prec from sysobjects a, syscolumns b Where a.Id = b.Id and a.name= '" + TablaOrigen +
                 "' and b.name= '" + NombreCampo + "'"
        Tbl = SMT_AbrirTabla(Conex, TxtSQL)
        If Tbl.Rows.Count = 1 Then ExisteCampo = True Else ExisteCampo = False
        Tbl.Dispose()
Exit_AnchoCampoSql:
        Exit Function
Err_AnchoCampoSql:
        MensajedeError()
        Resume Exit_AnchoCampoSql
    End Function
    Public Function Quitar_Campo(ByRef Conexion As SqlConnection, Tabla As String, NombreCampo As String, Optional Restriccion1 As String = "", Optional Restriccion2 As String = "") As Integer
        On Error GoTo Err_Quitar_Campo
        Dim Tbl As New DataTable, TxtSQL As String, R As Long
        If ExisteCampo(Conexion, Tabla, NombreCampo) Then
            On Error Resume Next
            If Restriccion1 <> "" Then
                TxtSQL = "ALTER TABLE " & Tabla & " DROP CONSTRAINT " & Restriccion1
                SMT_EjcutarComandoSql(Conexion, TxtSQL, R)
            End If
            If Restriccion2 <> "" Then
                TxtSQL = "ALTER TABLE " & Tabla & " DROP CONSTRAINT " & Restriccion2
                SMT_EjcutarComandoSql(Conexion, TxtSQL, R)
            End If
            TxtSQL = "ALTER TABLE " & Tabla & " DROP COLUMN  " & NombreCampo
            SMT_EjcutarComandoSql(Conexion, TxtSQL, R)
        End If
Exit_Quitar_Campo:
        Return R
        Exit Function
Err_Quitar_Campo:
        MensajedeError("Quitando campo " & NombreCampo & " en la tabla " & Tabla)
        Resume Exit_Quitar_Campo
    End Function

    Public Function AnchoCampoSql(ByRef Conexion As Object, TablaOrigen As String, NombreCampo As String) As Integer
        ' Funcion para Consultar el Ancho de un Campo en una tabla dada, de la
        ' conexion dada
        On Error GoTo Err_AnchoCampoSql
        Dim TxtSQL = "select b.name, b.prec from sysobjects a, syscolumns b " &
                     "Where a.Id = b.Id and a.name= '" + TablaOrigen +
                     "' and b.name= '" + NombreCampo + "'"
        Dim R As Integer
        If TypeOf Conexion Is SqlConnection Then
            Dim Tbl As SqlDataReader

            Tbl = SMT_AbrirRecordSetReader(Conexion, TxtSQL)
            'Tbl.Open(TxtSQL, Conexion, adOpenForwardOnly, adLockReadOnly)
            'If Not Tbl.EOF Then AnchoCampoSql = CInt(Tbl!Prec)
            If Tbl.HasRows Then
                Tbl.Read()
                R = CInt(Tbl.Item("Prec"))
            End If
            Tbl.Close() : Tbl = Nothing
            Return R
        ElseIf TypeOf Conexion Is Api Then
            Dim MiApi As Api = CType(Conexion, Api)
            Dim paramsDefinition = New With {
                .sql = TxtSQL
            }
            Dim url = $"/Api/Parametros.asmx/SqlGet"
            Dim resApi = MiApi.ApiPOST(Of DataTable)(url, paramsDefinition)
            If Not IsNothing(resApi.ObjetoRes) Then
                If resApi.ObjetoRes.Columns.Contains("NoContieneDatos") Then
                    resApi.ObjetoRes.Columns.Remove("NoContieneDatos")
                    resApi.ObjetoRes.Rows.Clear()
                End If
            End If
            R = CInt(resApi.ObjetoRes.Rows(0)("Prec"))
            Return R
        End If

Exit_AnchoCampoSql:
        Exit Function
Err_AnchoCampoSql:
        MensajedeError()
        Resume Exit_AnchoCampoSql



    End Function
End Module
