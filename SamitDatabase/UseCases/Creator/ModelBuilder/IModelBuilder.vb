Public Interface IModelBuilder

    Function GetDatabaseModel(Optional database As DatabasesSamit = Nothing, Optional tabla As SqlTable = Nothing) As List(Of SqlTable)
    Function GetTableData(table As Type) As SqlTable
    Function GetColumnsFromTable(table As Type, Optional omitirTiposBinarios As Boolean = True, Optional incluirSubconsultas As Boolean = False) As List(Of SqlColumn)
    Function GetIndexesFromTable(table As Type) As List(Of SqlIndex)

End Interface
