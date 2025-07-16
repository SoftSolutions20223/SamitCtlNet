Imports System.Data.SqlClient
Imports Newtonsoft.Json.Linq
Imports SamitCoreApi
Imports SamitDatabase

Public Class ServiceParametros
    Public Function UpsertParametros(token As TokenData, Datos As JArray, Tabla As String, Optional conexion As ConexionSQL = Nothing) As JObject
        Dim cerrarConexion = False
        If IsNothing(conexion) Then
            conexion = New ConexionSQL(token.Servidor, token.BaseDatosNominaFull)
            cerrarConexion = True
        End If

        Dim command As New SqlCommand("DynamicUpsertJson ")
        Dim StrDatos = Datos.ToString()
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@json", Datos.ToString())
        command.Parameters.AddWithValue("@tabla", Tabla)

        Dim result = conexion.SqlJsonComand(command)

        If cerrarConexion Then
            conexion.CerrarConexion()
        End If

        Return JObject.Parse(result)
    End Function

    Public Function CallProcedures(token As TokenData, Datos As JObject, Procedimiento As String, Optional conexion As ConexionSQL = Nothing) As JObject
        Dim cerrarConexion = False
        If IsNothing(conexion) Then
            conexion = New ConexionSQL(token.Servidor, token.BaseDatosNominaFull)
            cerrarConexion = True
        End If

        Dim command As New SqlCommand(Procedimiento)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@Datos", Datos.ToString())

        Dim result = conexion.SqlJsonComand(command)

        If cerrarConexion Then
            conexion.CerrarConexion()
        End If

        Return JObject.Parse(result)
    End Function

    Public Function CallDatasets(token As TokenData, consultas() As String, Optional conexion As ConexionSQL = Nothing) As DataSet
        Dim cerrarConexion = False
        If IsNothing(conexion) Then
            conexion = New ConexionSQL(token.Servidor, token.BaseDatosNominaFull)
            cerrarConexion = True
        End If

        Dim HFuncionesSql As New FuncionesSql

        Dim result = HFuncionesSql.SqlConsultaMultiple(consultas, conexion.Con)

        If cerrarConexion Then
            conexion.CerrarConexion()
        End If

        Return result
    End Function

End Class
