Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports System.Reflection
Imports System.Runtime.CompilerServices

Public Module TableToClass

    <Extension()>
    Public Function ToObject(Of T As New)(ByVal dataRow As DataRow) As T
        Dim item As T = New T()

        For Each column As DataColumn In dataRow.Table.Columns
            Dim [property] As PropertyInfo = GetProperty(GetType(T), column.ColumnName)

            If [property] IsNot Nothing AndAlso dataRow(column) IsNot DBNull.Value AndAlso dataRow(column).ToString() IsNot "NULL" AndAlso Not String.IsNullOrWhiteSpace(dataRow(column).ToString()) Then
                If [property].CanWrite Then
                    [property].SetValue(item, ChangeType(dataRow(column), [property].PropertyType), Nothing)
                End If
            End If
        Next

        Return item
    End Function

    <Extension()>
    Public Function ToLIst(Of T As New)(ByVal dataTable As DataTable) As List(Of T)
        Dim lista = New List(Of T)

        If dataTable Is Nothing Then
            Return lista
        End If

        For Each fila As DataRow In dataTable.Rows
            Dim objeto As T = fila.ToObject(Of T)
            lista.Add(objeto)
        Next

        Return lista
    End Function

    Private Function GetProperty(ByVal type As Type, ByVal attributeName As String) As PropertyInfo
        Dim [property] As PropertyInfo = type.GetProperty(attributeName)

        If [property] IsNot Nothing Then
            Return [property]
        End If

        Return type.GetProperties().Where(Function(p) p.IsDefined(GetType(DisplayAttribute), False) AndAlso p.GetCustomAttributes(GetType(DisplayAttribute), False).Cast(Of DisplayAttribute)().Single().Name = attributeName).FirstOrDefault()
    End Function

    Public Function ChangeType(ByVal value As Object, ByVal type As Type) As Object
        If type.IsGenericType AndAlso type.GetGenericTypeDefinition().Equals(GetType(Nullable(Of))) Then

            If value Is Nothing Then
                Return Nothing
            End If

            Return Convert.ChangeType(value, Nullable.GetUnderlyingType(type))
        End If

        Return Convert.ChangeType(value, type)
    End Function

    <Extension()>
    Public Function ToDataTable(Of T)(ByVal data As IList(Of T)) As DataTable
        Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(GetType(T))
        Dim table As DataTable = New DataTable()

        For Each prop As PropertyDescriptor In properties
            table.Columns.Add(prop.Name, If(Nullable.GetUnderlyingType(prop.PropertyType), prop.PropertyType))
        Next

        For Each item As T In data
            Dim row As DataRow = table.NewRow()

            For Each prop As PropertyDescriptor In properties
                row(prop.Name) = If(prop.GetValue(item), DBNull.Value)
            Next

            table.Rows.Add(row)
        Next

        Return table
    End Function

End Module
