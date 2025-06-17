Imports System.Data.SqlClient
Imports System.Text
Imports SamitCoreApi

Public Class ConexionSQL

    Public Shared Property AppConfigurationSource As IAppConfiguration = New AppConfigurationImpl()
    Public Shared Property EnableLogs As Boolean = False

    Private Server As String
    Private Database As String
    Private User As String
    Private Pass As String

    Public ReadOnly Property Cadena As String
        Get
            Return "Data Source=" & Server & "; Database=" & Database & "; User ID=" & User & "; Password=" & Pass & ";" '& "Connection Timeout=30"
        End Get
    End Property

    Public Con As SqlConnection
    Public Tran As SqlTransaction

    Public Sub New(servidor As String, baseDeDatos As String, usuario As String, contraseña As String)
        If IsNothing(servidor) Then
            servidor = AppConfigurationSource.SqlDefaultServer
        End If
        If IsNothing(baseDeDatos) Then
            baseDeDatos = AppConfigurationSource.SqlDatabase
        End If
        If IsNothing(usuario) Then
            usuario = AppConfigurationSource.SqlUser
        End If
        If IsNothing(contraseña) Then
            contraseña = AppConfigurationSource.SqlPass
        End If

        Server = servidor
        Database = baseDeDatos
        User = usuario
        Pass = contraseña

        Dim SQL As String = "set dateformat dmy;"
        Con = New SqlConnection(Cadena)
        Con.Open()
        Dim Comando As SqlCommand = Con.CreateCommand
        Comando.CommandText = SQL
        Comando.ExecuteNonQuery()
    End Sub

    Public Sub New(servidor As String, baseDeDatos As String)
        Me.New(servidor, baseDeDatos, Nothing, Nothing)
    End Sub

    Public Sub New()
        Me.New(Nothing, Nothing, Nothing, Nothing)
    End Sub

    Public Sub CambiarBaseDatos(nuevaBaseDeDatos As String)
        If EnableLogs Then Debug.WriteLine($"CambiarBaseDatos: {nuevaBaseDeDatos}")
        Con.ChangeDatabase(nuevaBaseDeDatos)
    End Sub

    Public Sub CerrarConexion()
        Con.Close()
        Con.Dispose()
    End Sub

    Public Sub CompletarTransaccion()
        If EnableLogs Then Debug.WriteLine($"CompletarTransaccion")
        Tran.Commit()
    End Sub

    Public Sub ReversarTransaccion()
        If EnableLogs Then Debug.WriteLine($"ReversarTransaccion")
        Try
            Tran.Rollback()
        Catch ex As Exception

        End Try
    End Sub

    Public Sub IniciarTrasanccion()
        If EnableLogs Then Debug.WriteLine($"IniciarTrasanccion")
        Tran = Con.BeginTransaction(IsolationLevel.ReadCommitted)
    End Sub

    Public Function conection() As SqlConnection
        Return Con
    End Function

    Public Function SqlJson(ByVal comando As String) As String
        If EnableLogs Then Debug.WriteLine($"SqlJson")
        Dim cmd = New SqlCommand("set dateformat dmy;" + comando, Con, Tran)
        Dim jsonResult = New StringBuilder()
        Dim reader = cmd.ExecuteReader()

        If Not reader.HasRows Then
            jsonResult.Append("[]")
        Else
            While reader.Read()
                jsonResult.Append(reader.GetValue(0).ToString())
            End While
        End If

        reader.Close()
        Return jsonResult.ToString()
    End Function

    Public Function SqlJsonComand(ByVal comando As SqlCommand) As String
        comando.Connection = Con
        Dim jsonResult As New StringBuilder()
        Dim commandString As String = comando.CommandText

        For Each param As SqlParameter In comando.Parameters
            Dim paramValue As String = If(param.Value?.ToString(), "NULL")
            commandString = commandString.Replace(param.ParameterName, paramValue)
        Next

        Try
            Dim reader = comando.ExecuteReader()

            If Not reader.HasRows Then
                jsonResult.Append("[]")
            Else
                While reader.Read()
                    jsonResult.Append(reader.GetValue(0).ToString())
                End While
            End If

        Catch e As Exception
            jsonResult.Append("[{""msg"":" & e.Message & "}]")

        Finally
            comando.Dispose()
        End Try

        Return jsonResult.ToString()
    End Function

    Public Function SqlQuery(ByVal SQL As String) As DataTable
        If EnableLogs Then Debug.WriteLine($"SqlQuery")
        Dim comando As SqlCommand = New SqlCommand(SQL, Con, Tran)
        Dim Datas As SqlDataAdapter = New SqlDataAdapter(comando)
        Dim tabla As DataTable = New DataTable()

        Try
            Datas.Fill(tabla)
        Catch __unusedException1__ As Exception
            Return Nothing
        Finally
            comando.Dispose()
        End Try

        Return tabla
    End Function

    Public Function SqlQuerySingle(ByVal SQL As String, Optional incluirDMY As Boolean = True, Optional tiempoEspera As Integer? = Nothing) As String
        If EnableLogs Then Debug.WriteLine($"SqlQuerySingle: {SQL}")
        If incluirDMY Then
            SQL = "set dateformat dmy; " & SQL
        End If
        Dim comando As SqlCommand = New SqlCommand(SQL)
        comando.Connection = Con
        comando.Transaction = Tran
        If Not IsNothing(tiempoEspera) Then comando.CommandTimeout = tiempoEspera
        Dim val As String = "no"
        Try

            Dim fill_afec As Integer = comando.ExecuteNonQuery()

            If fill_afec <> 0 Then
                val = "si"
            End If

        Catch a As System.Exception
            Return a.Message.ToString()
        Finally
            comando.Dispose()
        End Try

        Return val
    End Function

    Public Function SqlQuerySingleRows(ByVal SQL As String) As Integer
        If EnableLogs Then Debug.WriteLine($"SqlQuerySingleRows: {SQL}")
        'SQL = "set dateformat dmy; " & SQL
        Dim comando As SqlCommand = New SqlCommand(SQL)
        comando.Connection = Con
        comando.Transaction = Tran
        Dim val As Integer = 0
        Try
            Dim fill_afec As Integer = comando.ExecuteNonQuery()
            val = fill_afec
        Catch a As System.Exception
            val = 0
        Finally
            comando.Dispose()
        End Try

        Return val
    End Function

    Public Function SqlQueryReturnId(ByVal SQL As String, ByVal AgregaRetunId As Boolean) As Integer
        If EnableLogs Then Debug.WriteLine($"SqlQueryReturnId")
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

    'Public Function SetSqlBulkCopyData(Token As TokenData, conexion As ConexionSQL, nombreTabla As String, DataTable As DataTable, columnasTable As Dictionary(Of String, String), Optional consultaVerificacion As String = "") As ApiResponse
    '    Dim res As New ApiResponse
    '    Try
    '        Dim connectionString As String = conexion.Cadena

    '        Using connection As New SqlConnection(connectionString)
    '            connection.Open()

    '            ' Iniciar una transacción
    '            Using transaction As SqlTransaction = connection.BeginTransaction()
    '                Try
    '                    ' Usar SqlBulkCopy para insertar todos los registros
    '                    BulkInsert(connection, transaction, nombreTabla, DataTable, columnasTable)
    '                    transaction.Commit()

    '                    If Not String.IsNullOrWhiteSpace(consultaVerificacion) AndAlso consultaVerificacion IsNot Nothing Then
    '                        ' Obtener el nombre de la tabla
    '                        Dim TablanombreSQL = conexion.SqlQuery(consultaVerificacion)(0)(0)
    '                        res.Estado = "OK"
    '                        res.ObjetoRes = Catalogo.GetCatalogo(Token, TablanombreSQL, False, Nothing)
    '                    Else
    '                        res.Estado = "OK"
    '                    End If
    '                Catch ex As Exception
    '                    ' En caso de error, revertir la transacción
    '                    transaction.Rollback()
    '                    res.Estado = "ERROR"
    '                    res.AgregarDetalle("Error al insertar datos en la base de datos: " & ex.Message)
    '                End Try
    '            End Using
    '        End Using
    '    Catch ex As Exception
    '        res.Estado = "ERROR"
    '        res.AgregarDetalle("INTERNO: " & ex.Message)
    '    End Try

    '    Return res
    'End Function

    Sub BulkInsert(connection As SqlConnection, transaction As SqlTransaction, destinationTableName As String, dataTable As DataTable, columnMappings As Dictionary(Of String, String))
        Using bulkCopy As New SqlBulkCopy(connection, SqlBulkCopyOptions.Default, transaction)
            bulkCopy.DestinationTableName = destinationTableName
            For Each mapping As KeyValuePair(Of String, String) In columnMappings
                bulkCopy.ColumnMappings.Add(mapping.Key, mapping.Value)
            Next
            bulkCopy.WriteToServer(dataTable)
        End Using
    End Sub

End Class