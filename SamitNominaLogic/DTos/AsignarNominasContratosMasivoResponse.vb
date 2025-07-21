Public Class AsignarNominasContratosMasivoResponse
    Public Property Estado As String
    Public Property Mensaje As String
    Public Property TotalProcesados As Integer
    Public Property TotalExitosos As Integer
    Public Property TotalErrores As Integer
    Public Property FechaHora As DateTime
    Public Property Detalles As List(Of DetalleAsignacion)

    ' Constructor
    Public Sub New()
        Detalles = New List(Of DetalleAsignacion)()
    End Sub

    ' Propiedades calculadas
    Public ReadOnly Property EsExitoso As Boolean
        Get
            Return Estado = "SUCCESS"
        End Get
    End Property

    Public ReadOnly Property EsParcial As Boolean
        Get
            Return Estado = "PARTIAL"
        End Get
    End Property

    Public ReadOnly Property EsError As Boolean
        Get
            Return Estado = "ERROR"
        End Get
    End Property
End Class

' Clase para el detalle de cada asignación
Public Class DetalleAsignacion
    Public Property IdContrato As String
    Public Property SecNomina As Integer
    Public Property Estado As String
    Public Property Mensaje As String
End Class