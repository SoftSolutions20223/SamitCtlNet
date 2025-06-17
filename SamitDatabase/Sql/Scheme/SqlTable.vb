<System.AttributeUsage(System.AttributeTargets.Class)>
Public Class SqlTable
    Inherits System.Attribute

    Public Nombre As String
    Public Esquema As String = "dbo"
    Public BaseDatos As DatabasesSamit
    Public Version As Integer

    Public ListaColumnas As New List(Of SqlColumn)
    Public ListaIndices As New List(Of SqlIndex)

    Public ClassName As String

    Public Overrides Function ToString() As String
        Return "[" & Esquema & "].[" & Nombre & "] - (DB: " & BaseDatos.ToString() & ")"
    End Function

End Class
