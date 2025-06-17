Public Class CargoResponseDto
    Public Property Sec As Integer
    Public Property CodCargo As String
    Public Property Denominacion As String
    Public Property Descripcion As String
    Public Property Funciones As List(Of CargoFuncionResponseDto)
    Public Property Asignaciones As List(Of CargoAsignacionResponseDto)
    Public Property AsignacionActual As Decimal
    Public Property ContratosAfectados As Integer
End Class
