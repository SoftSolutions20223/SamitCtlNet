Public Class SqlDatabase
    Inherits System.Attribute

    Public Nombre As String
    Public TipoBaseDatos As DatabasesSamit

End Class

Public Enum DatabasesSamit
    SamitClientes = -1
    NoDefinido = 0
    Seguridad = 1
    Año = 2
    General = 3
    Nomina = 4
    Exogena = 5
    Pedidos = 6
    NominaFull = 7
End Enum