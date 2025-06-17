Public Class Database

    Public Shared Function ExisteBaseDatos(nombreBaseDatos As String, servidor As String) As Boolean
        Dim comando As String = "select * From master..sysdatabases WHERE (name = '" & nombreBaseDatos & "')"
        Dim conexion = New ConexionSQL(servidor, "master")

        Dim tabla As DataTable = conexion.SqlQuery(comando)
        conexion.CerrarConexion()

        If tabla.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Shared Function ExisteBaseDatos(ByRef Conexion As ConexionSQL, NombreBaseDatos As String) As Boolean
        Try
            Dim comandoValidaDB = "SELECT name FROM master.dbo.sysdatabases WHERE ('[' + name + ']' = '" & NombreBaseDatos & "' OR name = '" & NombreBaseDatos & "')"
            Dim Tbl = Conexion.SqlQuery(comandoValidaDB)
            If Tbl.Rows.Count <= 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Shared Function CalcularPesoBaseDatos(nombreBaseDatos As String, servidor As String) As Decimal
        Dim comando As String = "SELECT X.peso FROM
                                (SELECT sys.databases.name as nombre, CONVERT(VARCHAR,SUM(size)*8/1024) AS peso
                                FROM sys.databases   
                                JOIN sys.master_files ON sys.databases.database_id=sys.master_files.database_id  
                                GROUP BY sys.databases.name) AS X
                                WHERE X.nombre = '" & nombreBaseDatos & "'"
        Dim conex = New ConexionSQL(servidor, "master")
        Dim tabla As DataTable = conex.SqlQuery(comando)
        conex.CerrarConexion()
        If tabla.Rows.Count > 0 Then
            Return tabla.Rows(0)("peso")
        Else
            Return 0
        End If
    End Function

    Public Shared Function ExisteTabla(conex As ConexionSQL, nombreTabla As String) As Boolean
        Dim comando As String = "SELECT * FROM sysobjects WHERE (xtype = 'U') AND (name = '" & nombreTabla & "')"
        Dim tabla As DataTable = conex.SqlQuery(comando)

        If tabla.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Shared Function ExisteColumna(conex As ConexionSQL, nombreTabla As String, nombreColumna As String) As Boolean
        Dim comando As String = "SELECT * FROM sysobjects a, syscolumns b WHERE (a.Id = b.Id) AND (a.name = '" & nombreTabla & "') AND (b.name = '" & nombreColumna & "')"
        Dim tabla As DataTable = conex.SqlQuery(comando)

        If tabla.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Shared Function TraerFechaDelServidor(servidor As String) As Date
        Dim comando As String = "SELECT 'FechaSys' = getdate()"
        Dim conex = New ConexionSQL(servidor, "master")
        Dim tabla As DataTable = conex.SqlQuery(comando)

        Return tabla(0)("Fechasys")
    End Function

    Public Shared Function TraerSecuencialActual(Conexion As ConexionSQL, Tabla As String, CampoSecuencial As String) As Integer
        Dim TxtSql = "Select isnull(Max(" & CampoSecuencial & "),0) as Ultimo From " & Tabla
        Dim res = Conexion.SqlQuery(TxtSql)
        If res.Rows.Count = 1 Then
            Return res.Rows(0)(0)
        Else
            Return 0
        End If
    End Function

    Public Shared Function TraerSecuencialSiguiente(Conexion As ConexionSQL, Tabla As String, CampoSecuencial As String) As Integer
        Dim actual = TraerSecuencialActual(Conexion, Tabla, CampoSecuencial)
        Dim siguiente = actual + 1
        Return siguiente
    End Function

End Class
