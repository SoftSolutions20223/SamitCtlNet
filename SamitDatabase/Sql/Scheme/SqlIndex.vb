<System.AttributeUsage(System.AttributeTargets.Class, AllowMultiple:=True)>
Public Class SqlIndex
    Inherits System.Attribute

    Public Nombre As String
    Public TipoIndex As IndexType = IndexType.NonClustered
    ''' <summary>
    ''' Representación en formato de texto de las columnas del índice.
    ''' La forma básica es el nombre de la columna, por ejemplo: "ColumnaA"
    ''' Se pueden definir parámetros personalizados para la columna separándolos con el carácter "|":
    ''' 1. Tipo de orden:
    '''    - ASC: Orden ascendente.
    '''    - DESC: Orden descendente.
    '''    Ejemplo: "ColumnaA|ASC", "ColumnaB|DESC".
    '''    Si no se define, por defecto es ASC.
    ''' </summary>
    Public Columnas As String()
    ''' <summary>
    ''' Representación en formato de texto de las columnas del INCLUDE en el índice.
    ''' Se define solo con el nombre de la columna, por ejemplo: "ColumnaA"
    ''' Todas las columnas especificadas en esta propiedad se incluirán en la cláusula INCLUDE del índice.
    ''' Si no se especifican columnas para el INCLUDE, se omitirá la cláusula INCLUDE en la definición del índice.
    ''' </summary>
    Public ColumnasInclude As String()
    Public Unique As Boolean = False

End Class

Public Enum IndexType
    Clustered = 0
    NonClustered = 1
End Enum