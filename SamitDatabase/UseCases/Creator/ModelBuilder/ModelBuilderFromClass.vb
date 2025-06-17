Imports System.Reflection
Imports SamitCoreApi

Public Class ModelBuilderFromClass
    Implements IModelBuilder

    ReadOnly AssemblyName As String

    Public Sub New()
        Dim appConfig As New AppConfigurationImpl()
        AssemblyName = appConfig.SqlDatabase
    End Sub

    Public Function GetDatabaseModel(Optional database As DatabasesSamit = Nothing, Optional tabla As SqlTable = Nothing) As List(Of SqlTable) Implements IModelBuilder.GetDatabaseModel
        Dim res As New List(Of SqlTable)

        Dim clases = Assembly.GetExecutingAssembly().GetTypes().Where(Function(t) t.[Namespace] = AssemblyName).ToList()
        Dim listaIgnorar = New List(Of Type)
        For Each clase In clases
            Dim clasesHeredadas = GetInheritedClasses(clase)
            If clasesHeredadas.Count > 0 Then
                listaIgnorar.AddRange(clasesHeredadas)
            End If
        Next
        For Each clase In clases
            Dim AttributeTabla = GetTableData(clase)
            If Not IsNothing(AttributeTabla) And Not listaIgnorar.Contains(clase) Then
                AttributeTabla.ListaColumnas = GetColumnsFromTable(clase, omitirTiposBinarios:=False)
                AttributeTabla.ListaIndices = GetIndexesFromTable(clase)
                res.Add(AttributeTabla)
            End If
        Next

        If Not IsNothing(database) And database <> DatabasesSamit.NoDefinido Then
            res = res.Where(Function(t) t.BaseDatos = database).ToList()
        End If

        Return res
    End Function

    Public Function GetTableData(table As Type) As SqlTable Implements IModelBuilder.GetTableData
        Dim attributeTable As SqlTable = CType(Attribute.GetCustomAttribute(table, GetType(SqlTable)), SqlTable)
        If IsNothing(attributeTable) Then Return Nothing

        Dim datos As SqlTable = attributeTable
        datos.ClassName = table.Name
        Return datos
    End Function

    Public Function GetColumnsFromTable(table As Type, Optional omitirTiposBinarios As Boolean = True, Optional incluirSubconsultas As Boolean = False) As List(Of SqlColumn) Implements IModelBuilder.GetColumnsFromTable
        Dim campos As New List(Of SqlColumn)()
        Dim propiedades = table.GetProperties()

        For Each item In propiedades
            Dim attributes = item.GetCustomAttributes()

            If attributes.Where(Function(a) a.[GetType]() = GetType(SqlColumn)).ToList().Count > 0 Then
                Dim campo As SqlColumn = CType(attributes.Where(Function(a) a.[GetType]() = GetType(SqlColumn)).ToList()(0), SqlColumn)
                campo.VariableName = item.Name
                Dim agregar = True
                If omitirTiposBinarios Then
                    If campo.TipoDato = SqlType.Image Or campo.TipoDato = SqlType.VarBinary Then
                        agregar = False
                        campo.ToString()
                    End If
                End If
                If Not incluirSubconsultas Then
                    If Not String.IsNullOrWhiteSpace(campo.SubConsulta) Then
                        agregar = False
                    End If
                End If

                If agregar Then
                    campos.Add(campo)
                End If
            End If
        Next

        Return campos
    End Function

    Public Function GetIndexesFromTable(table As Type) As List(Of SqlIndex) Implements IModelBuilder.GetIndexesFromTable
        Dim indices As New List(Of SqlIndex)()
        Dim sqlIndexTable = table.GetCustomAttributes(Of SqlIndex)

        For Each item In sqlIndexTable
            indices.Add(item)
        Next

        Return indices
    End Function


    Private Function GetInheritedClasses(ByVal MyType As Type) As List(Of Type)
        Return Assembly.GetAssembly(MyType).GetTypes().Where(Function(TheType) TheType.IsClass AndAlso Not TheType.IsAbstract AndAlso TheType.IsSubclassOf(MyType)).ToList()
    End Function

End Class
