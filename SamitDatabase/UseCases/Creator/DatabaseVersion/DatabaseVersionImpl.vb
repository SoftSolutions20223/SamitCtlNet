Imports SamitHelpers

Public Class DatabaseVersionImpl
    Implements IDatabaseVersion

    ReadOnly ModelBuilder As IModelBuilder

    Public Sub New()
        ModelBuilder = New ModelBuilderFromClass()
    End Sub

    Public Sub CrearTablaVersiones(servidorSql As String) Implements IDatabaseVersion.CrearTablaVersiones
        Dim conexMaster = New ConexionSQL(servidorSql, "master")
        If Not Database.ExisteBaseDatos("DatabaseVersiones", servidorSql) Then
            Dim comandoTablaVersiones = "CREATE TABLE DatabaseVersiones (Nombre VARCHAR(200), Version INT);"
            conexMaster.SqlQuerySingle(comandoTablaVersiones)
        End If
        conexMaster.CerrarConexion()
    End Sub

    Public Sub LimpiarTablaVersiones(servidorSql As String, baseDatos As String) Implements IDatabaseVersion.LimpiarTablaVersiones
        CrearTablaVersiones(servidorSql)
        Dim conexMaster = New ConexionSQL(servidorSql, "master")
        Dim comando = "DELETE DatabaseVersiones WHERE (Nombre LIKE '" & baseDatos & "%')"
        conexMaster.SqlQuerySingle(comando)
        conexMaster.CerrarConexion()
    End Sub

    Public Sub GuardarVersionBaseDatos(servidorSql As String, nombreBaseDatos As String, nuevaVersion As Integer, Optional nombreTabla As String = Nothing) Implements IDatabaseVersion.GuardarVersionBaseDatos
        CrearTablaVersiones(servidorSql)
        Dim conexMaster = New ConexionSQL(servidorSql, "master")
        Dim nombreParam = nombreBaseDatos
        If Not String.IsNullOrWhiteSpace(nombreTabla) Then
            nombreParam += "." & nombreTabla
        End If
        Dim comando = "SELECT COUNT(*) FROM DatabaseVersiones WHERE (Nombre = '" & nombreParam & "')"
        Dim tabla = conexMaster.SqlQuery(comando)
        If Not IsNothing(tabla) Then
            If tabla.Rows.Count > 0 Then
                Dim cant = tabla.Rows(0)(0)
                Dim comandoGuarda = ""
                If cant = 0 Then
                    comandoGuarda = "INSERT INTO DatabaseVersiones (Nombre, Version) VALUES ('" & nombreParam & "', " & nuevaVersion & ")"
                Else
                    comandoGuarda = "UPDATE DatabaseVersiones SET Version = " & nuevaVersion & " WHERE (Nombre = '" & nombreParam & "')"
                End If
                conexMaster.SqlQuerySingle(comandoGuarda)
            End If
        End If
        conexMaster.CerrarConexion()
    End Sub

    Public Function GetListaVersiones(servidorSql As String, baseDatos As String) As List(Of DatabaseVersion) Implements IDatabaseVersion.GetListaVersiones
        CrearTablaVersiones(servidorSql)
        Dim conexMaster = New ConexionSQL(servidorSql, "master")
        Dim comando = "SELECT Nombre, Version FROM DatabaseVersiones WHERE (Nombre LIKE '" & baseDatos & "%')"
        Dim tabla = conexMaster.SqlQuery(comando)
        conexMaster.CerrarConexion()
        Dim lista = tabla.ToLIst(Of DatabaseVersion)
        Return lista
    End Function

    Public Sub GuardarVersionTodasTablas(servidor As String, tipo As DatabasesSamit, nombreDB As String) Implements IDatabaseVersion.GuardarVersionTodasTablas
        Dim ListaTablas = ModelBuilder.GetDatabaseModel(tipo)

        Dim cantActualizo = 0
        For Each tabla In ListaTablas
            GuardarVersionBaseDatos(servidor, nombreDB, tabla.Version, tabla.Nombre)
        Next
    End Sub

End Class
