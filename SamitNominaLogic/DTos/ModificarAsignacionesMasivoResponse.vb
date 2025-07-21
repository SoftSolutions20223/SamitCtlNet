Public Class ModificarAsignacionesMasivoResponse
    Public Property Estado As String
    Public Property Mensaje As String
    Public Property TipoModificacion As Integer
    Public Property TotalProcesados As Integer
    Public Property TotalExitosos As Integer
    Public Property TotalErrores As Integer
    Public Property ContratosActualizadosPorCargo As Integer
    Public Property FechaHora As DateTime
    Public Property Detalles As List(Of DetalleModificacion)

    ' Constructor
    Public Sub New()
        Detalles = New List(Of DetalleModificacion)()
    End Sub

    ' Propiedades calculadas
    Public ReadOnly Property EsExitoso As Boolean
        Get
            Return Estado = "SUCCESS"
        End Get
    End Property

    Public ReadOnly Property EsError As Boolean
        Get
            Return Estado = "ERROR"
        End Get
    End Property
End Class

' Detalle de cada modificación
Public Class DetalleModificacion
    Public Property IdContrato As String
    Public Property SecCargo As Integer?
    Public Property Asignacion As Decimal
    Public Property Fecha As DateTime?
    Public Property Estado As String
    Public Property Mensaje As String
End Class