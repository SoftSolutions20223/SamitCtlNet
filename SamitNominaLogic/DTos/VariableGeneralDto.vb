Public Class VariableGeneralDto
    Public Property Sec As Integer

    Public Property NomVariable As String

    Public Property CodDian As String

    Public Property Vigente As String

    Public Property EsPredeterminado As Boolean

    Public Property Detalles As List(Of DetalleVariableGeneralDto)

    Public Property DetallesInsertados As Integer

    Public Property DetallesEliminados As Integer

    Public Property FormulasActualizadas As Integer

    Public Property NombreAnterior As String
End Class
