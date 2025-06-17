Imports Newtonsoft.Json

Public Class ModelBuilderFromSqlEngine
    Implements IModelBuilder

    ReadOnly Conexion As ConexionSQL

    Public Sub New(_conexion As ConexionSQL)
        Conexion = _conexion
    End Sub

    Public Function GetDatabaseModel(Optional database As DatabasesSamit = DatabasesSamit.NoDefinido, Optional tabla As SqlTable = Nothing) As List(Of SqlTable) Implements IModelBuilder.GetDatabaseModel
        Return GetListaTablasBaseDatos(tabla:=tabla)
    End Function

    Public Function GetTableData(table As Type) As SqlTable Implements IModelBuilder.GetTableData
        Dim attributeTable As SqlTable = CType(Attribute.GetCustomAttribute(table, GetType(SqlTable)), SqlTable)
        If IsNothing(attributeTable) Then Return Nothing
        Dim sqlTable As SqlTable = attributeTable

        Dim lista = GetListaTablasBaseDatos(tabla:=sqlTable)
        If IsNothing(lista) Then Return Nothing
        If lista.Count = 0 Then Return Nothing

        Return lista.First()
    End Function

    Public Function GetColumnsFromTable(table As Type, Optional omitirTiposBinarios As Boolean = True, Optional incluirSubconsultas As Boolean = False) As List(Of SqlColumn) Implements IModelBuilder.GetColumnsFromTable
        Dim sqlTable = GetTableData(table:=table)
        Return sqlTable.ListaColumnas
    End Function

    Public Function GetIndexesFromTable(table As Type) As List(Of SqlIndex) Implements IModelBuilder.GetIndexesFromTable
        Dim sqlTable = GetTableData(table:=table)
        Return sqlTable.ListaIndices
    End Function

    Private Function GetListaTablasBaseDatos(Optional tabla As SqlTable = Nothing) As List(Of SqlTable)
        Dim res As New List(Of SqlTable)
        Dim filtro = ""
        If Not IsNothing(tabla) Then
            filtro = " WHERE (TABLE_NAME = '" & tabla.Nombre & "') "
        End If
        Dim comando =
                    "
                SELECT 
	                Nombre AS Nombre,
	                (
		                SELECT 
			                ColumnName AS Nombre,
			                CAST(IIF(PrimariaSQL > 0, 1, 0) AS BIT) AS LlavePrimaria, 
			                ColumnType AS TipoDato,
			                IIF(LargoSQL <> 0, IIF(ColumnType = 12, LargoSQL/2, LargoSQL), NULL) AS LargoColumna, 
			                IIF(PrecisionSQL <> 0, PrecisionSQL, NULL) AS PrecisionColumna,  
			                CAST(IIF(NullSQL = 1, 1, 0) AS BIT) AS AceptaNull, 
			                IIF(ForaneaTablaSQL is not null, ForaneaTablaSQL, NULL) AS ForaneaTabla, 
			                IIF(ForaneaColumnaSQL is not null, ForaneaColumnaSQL, NULL) AS ForaneaColumna,
			                CAST(IIF(IdentitySQL = 1, 1, 0) AS BIT) AS [Identity],
			                IIF(IdentitySQL = 1, CAST(SeedSQL AS INT), NULL) AS IdentityInicio,
			                IIF(IdentitySQL = 1, CAST(IncreSQL AS INT), NULL) AS IdentityAumento,
			                IIF(TieneDefaultSQL = 1, DefaultSQL, NULL) AS ValorDefecto
		                FROM
		                (
			                select 
				                replace(col.name, ' ', '_') ColumnName,
				                col.column_id ColumnId,
				                case typ.name 
					                when 'bigint' then 0
					                when 'binary' then 1
					                when 'bit' then 2
					                when 'char' then 3
					                when 'date' then 31
					                when 'datetime' then 4
					                when 'datetime2' then 33
					                when 'datetimeoffset' then 34
					                when 'decimal' then 5
					                when 'float' then 6
					                when 'image' then 7
					                when 'int' then 8
					                when 'money' then 9
					                when 'nchar' then 10
					                when 'ntext' then 11
					                when 'numeric' then 35
					                when 'nvarchar' then 12
					                when 'real' then 13
					                when 'smalldatetime' then 15
					                when 'smallint' then 16
					                when 'smallmoney' then 17
					                when 'text' then 18
					                when 'time' then 32
					                when 'timestamp' then 19
					                when 'tinyint' then 20
					                when 'uniqueidentifier' then 14
					                when 'varbinary' then 21
					                when 'varchar' then 22
					                else 22
				                end ColumnType,
				                case 
					                when col.is_nullable = 1 and typ.name in 
						                ('bigint', 'bit', 'date', 'datetime', 'datetime2', 'datetimeoffset', 'decimal', 
						                'float', 'Int', 'money', 'numeric', 'real', 'smalldatetime', 'smallint', 
						                'smallmoney', 'time', 'tinyint', 'uniqueidentifier') 
					                then '' 
					                else '' 
				                end NullableSign,
				                UPPER(LEFT(typ.name, 1)) + LOWER(SUBSTRING( typ.name, 2, LEN( typ.name))) AS TipoSQL,
				                col.is_nullable AS NullSQL,
				                col.is_identity AS IdentitySQL,
				                cast(id.seed_value as varchar) AS SeedSQL,
				                cast(id.increment_value as varchar) AS IncreSQL,
				                col.default_object_id AS TieneDefaultSQL,
				                d.definition AS DefaultSQL,
				                IIF(col.system_type_id in (106, 108), col.precision, IIF(col.max_length <> typ.max_length, col.max_length, 0)) AS LargoSQL,
				                IIF(col.system_type_id in (106, 108), col.scale, IIF(col.precision <> typ.precision, col.precision, 0)) AS PrecisionSQL,
				                (SELECT  COUNT(*) FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS AS C
				                JOIN INFORMATION_SCHEMA.KEY_COLUMN_USAGE AS K ON C.TABLE_NAME = K.TABLE_NAME AND C.CONSTRAINT_CATALOG = K.CONSTRAINT_CATALOG AND 
				                C.CONSTRAINT_SCHEMA = K.CONSTRAINT_SCHEMA AND C.CONSTRAINT_NAME = K.CONSTRAINT_NAME
				                WHERE   C.CONSTRAINT_TYPE = 'PRIMARY KEY' AND C.TABLE_NAME = Tabla.Nombre AND K.COLUMN_NAME = col.name) as PrimariaSQL,
				                (SELECT TOP(1) KCU2.TABLE_NAME FROM INFORMATION_SCHEMA.REFERENTIAL_CONSTRAINTS RC
				                JOIN INFORMATION_SCHEMA.KEY_COLUMN_USAGE KCU1 ON KCU1.CONSTRAINT_CATALOG = RC.CONSTRAINT_CATALOG AND KCU1.CONSTRAINT_SCHEMA = RC.CONSTRAINT_SCHEMA AND KCU1.CONSTRAINT_NAME = RC.CONSTRAINT_NAME
				                JOIN INFORMATION_SCHEMA.KEY_COLUMN_USAGE KCU2 ON KCU2.CONSTRAINT_CATALOG = RC.UNIQUE_CONSTRAINT_CATALOG AND KCU2.CONSTRAINT_SCHEMA = RC.UNIQUE_CONSTRAINT_SCHEMA AND 
				                KCU2.CONSTRAINT_NAME = RC.UNIQUE_CONSTRAINT_NAME AND KCU2.ORDINAL_POSITION = KCU1.ORDINAL_POSITION 
				                Where KCU1.TABLE_NAME = Tabla.Nombre and KCU1.COLUMN_NAME = col.name) as ForaneaTablaSQL,
				                (SELECT TOP(1) KCU2.COLUMN_NAME FROM INFORMATION_SCHEMA.REFERENTIAL_CONSTRAINTS RC
				                JOIN INFORMATION_SCHEMA.KEY_COLUMN_USAGE KCU1 ON KCU1.CONSTRAINT_CATALOG = RC.CONSTRAINT_CATALOG AND KCU1.CONSTRAINT_SCHEMA = RC.CONSTRAINT_SCHEMA AND KCU1.CONSTRAINT_NAME = RC.CONSTRAINT_NAME
				                JOIN INFORMATION_SCHEMA.KEY_COLUMN_USAGE KCU2 ON KCU2.CONSTRAINT_CATALOG = RC.UNIQUE_CONSTRAINT_CATALOG AND KCU2.CONSTRAINT_SCHEMA = RC.UNIQUE_CONSTRAINT_SCHEMA AND 
				                KCU2.CONSTRAINT_NAME = RC.UNIQUE_CONSTRAINT_NAME AND KCU2.ORDINAL_POSITION = KCU1.ORDINAL_POSITION 
				                Where KCU1.TABLE_NAME = Tabla.Nombre and KCU1.COLUMN_NAME = col.name) as ForaneaColumnaSQL
			                from sys.columns col
				                join sys.types typ on
					                col.system_type_id = typ.system_type_id AND col.user_type_id = typ.user_type_id
				                left join sys.identity_columns id on object_id(Tabla.Nombre) = id.object_id 
				                left join sys.default_constraints d on col.default_object_id=d.object_id 
			                where col.object_id = object_id(Tabla.Nombre)
		                ) t
		                order by ColumnId
		                FOR JSON PATH
	                ) AS ListaColumnas
                FROM
                (
	                SELECT TABLE_NAME AS Nombre
	                FROM INFORMATION_SCHEMA.COLUMNS
                    " & filtro & "
	                GROUP BY TABLE_NAME
                ) AS Tabla
                FOR JSON PATH
            "
        Dim jsonTablas = Conexion.SqlJson(comando)
        res = JsonConvert.DeserializeObject(Of List(Of SqlTable))(jsonTablas)
        Return res
    End Function
End Class
