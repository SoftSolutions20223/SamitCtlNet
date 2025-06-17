Imports System.Data
Imports System.Data.SqlClient
Imports System.Text

Public Class Conexion
    Public Shared host As String = "samitcloud.ddns.net\SAMITDEV" '"ROZAPE\SQLSERVER2017"'
    Public db As String = ""
    Public Shared user As String = "sa"
    Public Shared pass As String = "2121121512"
    Public Shared cantConsultas As Integer = 0
    Public ReadOnly Property Cadena As String
        Get
            Return "Data Source=" & host & "; Database=" & db & "; User ID=" & user & "; Password=" & pass & ";" & "Connection Timeout=30"
        End Get
    End Property
    Public ReadOnly Property EstadoConexion As System.Data.ConnectionState
        Get
            Return Con.State
        End Get
    End Property
    Public Con As SqlConnection
    Public Tran As SqlTransaction = Nothing
    Public Sub New(database As String, Servidor As String, Passwd As String)
        db = database
        pass = Passwd
        If Not String.IsNullOrEmpty(Servidor) Then host = Servidor
        Dim SQL As String = "set dateformat dmy;"
        Con = New SqlConnection(Cadena)
        Con.Open()
        Dim Comando As SqlCommand = Con.CreateCommand
        Comando.CommandText = SQL
        Comando.ExecuteNonQuery()
    End Sub
    Public Sub CompletarTransaccion()
        Tran.Commit()
        Con.Close()
        Con.Dispose()
    End Sub
    Public Sub ReversarTransaccion()
        Try
            Tran.Rollback()
        Catch ex As Exception

        End Try
        Con.Close()
        Con.Dispose()
    End Sub
    Public Sub IniciarTrasanccion()
        Tran = Con.BeginTransaction
    End Sub
    Public Function conection() As SqlConnection
        Return Con
    End Function
    Public Function SMT_AbrirTabla(ByVal SQL As String) As DataTable
        Dim SMTCmd As New SqlCommand, TB As New DataTable, Adaptador As SqlDataAdapter
        Try
            SMTCmd.Connection = Con
            SMTCmd.CommandText = SQL
            SMTCmd.CommandType = CommandType.Text
            'SMTCmd.Transaction = Transaccion
            SMTCmd.Transaction = Tran
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
    Public Function SMT_AbrirTablaReader(ByVal SQL As String) As SqlDataReader
        Dim SMTCmd As New SqlCommand, Rs As SqlDataReader
        Try
            SMTCmd.Connection = Con
            SMTCmd.CommandText = SQL
            SMTCmd.CommandType = CommandType.Text
            SMTCmd.Transaction = Tran
            Rs = SMTCmd.ExecuteReader
            SMTCmd.Dispose()
            SMTCmd = Nothing
            Return Rs

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Nothing
    End Function
    Public Function SMT_EjcutarComandoSql(ByVal TxtSQL As String) As Long
        Dim Cmd As New SqlCommand
        Try
            Cmd.Connection = Con
            Cmd.CommandText = TxtSQL
            Cmd.CommandType = CommandType.Text
            Cmd.Transaction = Tran
            SMT_EjcutarComandoSql = Cmd.ExecuteNonQuery()
        Catch ex As Exception
            SMT_EjcutarComandoSql = 0
        End Try
        Return SMT_EjcutarComandoSql
    End Function
    Public Function SqlJson(ByVal comando As String) As String
        Dim cmd = New SqlCommand("set dateformat dmy;" + comando, Con)
        Dim jsonResult = New StringBuilder()
        Dim reader = cmd.ExecuteReader()

        If Not reader.HasRows Then
            jsonResult.Append("[]")
        Else
            While reader.Read()
                jsonResult.Append(reader.GetValue(0).ToString())
            End While
        End If

        Return jsonResult.ToString()
    End Function

    Public Function SqlQuery(ByVal SQL As String, Optional close As Boolean = False) As DataTable
        cantConsultas += 1
        Dim comando As SqlCommand = New SqlCommand(SQL, Con, Tran)
        Dim Datas As SqlDataAdapter = New SqlDataAdapter(comando)
        Dim tabla As DataTable = New DataTable()

        Try
            Datas.Fill(tabla)
        Catch __unusedException1__ As Exception
            Return Nothing
        Finally
            If close Then
                Con.Close()
            End If
            comando.Dispose()
        End Try

        Return tabla
    End Function

    Public Function SqlQuerySingle(ByVal SQL As String) As String
        'SQL = "set dateformat dmy; " & SQL
        Dim comando As SqlCommand = New SqlCommand(SQL)
        comando.Connection = Con
        comando.Transaction = Tran
        Dim val As String = "no"
        Try

            Dim fill_afec As Integer = comando.ExecuteNonQuery()

            If fill_afec > 0 Then
                val = "si"
            End If

        Catch a As System.Exception
            Return a.Message.ToString()
        Finally
            comando.Dispose()
        End Try

        Return val
    End Function

    Public Function SqlQueryReturnId(ByVal SQL As String, ByVal AgregaRetunId As Boolean) As Integer
        SQL = "set dateformat dmy; " & SQL
        If AgregaRetunId Then SQL += "; (select cast (scope_identity() as int));"
        Dim comando As SqlCommand = New SqlCommand(SQL)
        comando.Connection = Con
        Dim idRegistro As Integer = 0

        Try
            Try
                idRegistro = Convert.ToInt32(comando.ExecuteScalar())
            Catch __unusedException1__ As System.Exception
                idRegistro = 0
            End Try

        Catch __unusedException1__ As Exception
        Finally
            comando.Dispose()
        End Try

        Return idRegistro
    End Function

    Public Function SqlQueryTrans(ByVal SQL As List(Of String)) As String
        Dim fill_afec As Integer = 0
        Dim consul_Rel As Integer = 0
        Dim command As SqlCommand = Con.CreateCommand()
        command.Transaction = Tran

        Try

            For i As Integer = 0 To SQL.Count - 1
                SQL(i) = "set dateformat dmy; " & SQL(i) & ";"
                command.CommandText = SQL(i).ToString()
                fill_afec = command.ExecuteNonQuery()
                If fill_afec > 0 Then consul_Rel = consul_Rel + 1
            Next

            If consul_Rel = SQL.Count Then
                Return "si"
            Else
                Throw New System.Exception("Se Presento Un Error, ROZAPE")
            End If

        Catch a As Exception
            Return a.Message.ToString()
        Finally
            command.Dispose()
        End Try

        Return fill_afec.ToString()
    End Function
End Class

