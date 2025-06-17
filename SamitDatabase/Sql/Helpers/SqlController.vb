Imports System.Reflection
Imports System.Reflection.Emit
Imports Newtonsoft.Json
Imports SamitCoreApi

Public Class SqlController

    ReadOnly ModelBuilder As IModelBuilder

    Public Sub New()
        ModelBuilder = New ModelBuilderFromClass()
    End Sub

    Public Function GetResultJson(ByVal conexion As ConexionSQL,
                                     ByVal type As Type,
                                     ByVal Optional filter As String = Nothing,
                                     Optional omitirBinarios As Boolean = True,
                                     Optional usarJson As Boolean = True,
                                     Optional listaCampos As String = Nothing) As String

        Dim command As String = GetSelectJson(type, filter, omitirBinarios, usarJson, listaCampos:=listaCampos)
        Dim res As String = ""
        If usarJson Then
            res = conexion.SqlJson(command)
        Else
            Dim consulta = conexion.SqlQuery(command)
            If Not IsNothing(consulta) Then
                res = JsonConvert.SerializeObject(consulta, Newtonsoft.Json.Formatting.None, New JsonSerializerSettings With {.NullValueHandling = NullValueHandling.Ignore}).ToString()
            Else
                res = "[]"
            End If

        End If

        Return res
    End Function

    Public Function GetSelectJson(ByVal type As Type,
                                     ByVal Optional filter As String = Nothing,
                                     Optional omitirBinarios As Boolean = True,
                                     Optional usarJson As Boolean = True,
                                     Optional usarFrom As Boolean = True,
                                     Optional listaCampos As String = Nothing) As String

        Dim comando As String = "SELECT "
        Dim datosTabla As SqlTable = ModelBuilder.GetTableData(type)
        Dim campos As List(Of SqlColumn) = ModelBuilder.GetColumnsFromTable(type, incluirSubconsultas:=True, omitirTiposBinarios:=omitirBinarios)

        If Not String.IsNullOrWhiteSpace(listaCampos) Then
            Dim camposFinales As New List(Of SqlColumn)()
            Dim listaCamposSeparado As String() = listaCampos.Trim().Split(",")
            For Each campo In listaCamposSeparado
                Dim addCampo = campos.FirstOrDefault(Function(x) x.Nombre = campo)
                If addCampo IsNot Nothing Then
                    camposFinales.Add(addCampo)
                End If
            Next
            If camposFinales.Count > 0 Then
                campos = camposFinales
            End If
        End If

        For Each campo As SqlColumn In campos
            If Not String.IsNullOrWhiteSpace(campo.SubConsulta) Then
                comando += " " & campo.SubConsulta & " AS [" + campo.VariableName & "],"
            Else
                Dim columExp = " " & datosTabla.Nombre & "." + "[" + campo.Nombre & "]"
                If campo.TipoDato = SqlType.Int Then
                    columExp = " CAST(" & columExp & " AS INT)"
                End If
                comando += columExp & " AS [" + campo.VariableName & "],"
            End If
        Next

        If usarFrom Then
            comando = comando.TrimEnd(","c)
            comando += " FROM " & datosTabla.Nombre
        End If
        If Not String.IsNullOrWhiteSpace(filter) Then comando += " WHERE " & filter
        If usarJson Then
            comando += " FOR JSON PATH "
        End If
        Return comando
    End Function

    Public Sub AnexarFiltro(ByRef texto As String, filtro As String, Optional condicion As String = "AND")
        texto += If(Not String.IsNullOrWhiteSpace(texto), " " & condicion & " ", "") & filtro
    End Sub

End Class
