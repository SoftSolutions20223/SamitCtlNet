Public Class ParamsData(Of T)
    Public Property Auth As ApiAutentication
    Public Property Data As T

    Public ReadOnly Property AuthSuccess
        Get
            Return Auth.Resultado.Estado = "OK"
        End Get
    End Property
End Class
