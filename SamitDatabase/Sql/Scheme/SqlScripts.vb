Public Class SqlScripts

    Public Property Funciones As List(Of SqlScript)
    Public Property Procedimientos As List(Of SqlScript)
    Public Property Vistas As List(Of SqlScript)
    Public Property Desencadenadores As List(Of SqlScript)

End Class

Public Class SqlScript

    Public Property Nombre As String
    Public Property Tipo As String
    Public Property Descripcion As String
    Public Property Version As Integer

    Public Property Data As String

End Class