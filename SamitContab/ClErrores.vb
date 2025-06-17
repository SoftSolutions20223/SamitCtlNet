Public Class ListaErrores
    Public EsError As Boolean
    Public Linea As UInteger
    Public Campo As String
    Public TxtError As String
    'Public Class ListaErrores
    '    Public Linea As UInteger
    '    Public Campo As String
    '    Public TxtError As String
    'End Class
    Dim Tb As DataTable, Secuencia As ULong
    Public Sub New()
        Secuencia = 0
        Iniciar_Tabla()
    End Sub
    Public Function TraerListaErrores() As DataTable
        Return Tb
    End Function
    Public Sub AdicionaError(Eserror As Boolean, Linea As ULong, Campo As String, MensajeError As String)
        If Eserror Then TieneErrores = True
        Dim Fila As DataRow = Tb.NewRow
        Secuencia = Secuencia + 1
        Fila("Secuencia") = Secuencia
        Fila("Campo") = Campo
        Fila("Texto") = MensajeError
        Fila("Linea") = Linea
        Tb.Rows.Add(Fila)
    End Sub
    Private TieneErrores As Boolean
    Public ReadOnly Property SiTieneErrores() As Boolean
        Get
            Return TieneErrores
        End Get

    End Property
    Private Sub Iniciar_Tabla()
        Tb = New DataTable
        Tb.Columns.Add("Secuencia", GetType(ULong))
        Tb.Columns.Add("Campo", GetType(String))
        Tb.Columns.Add("Texto", GetType(String))
        Tb.Columns.Add("Linea", GetType(ULong))
    End Sub

End Class
