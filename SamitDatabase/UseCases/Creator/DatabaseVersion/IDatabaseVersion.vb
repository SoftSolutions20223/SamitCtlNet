Public Interface IDatabaseVersion
    Sub CrearTablaVersiones(servidorSql As String)
    Function GetListaVersiones(servidorSql As String, baseDatos As String) As List(Of DatabaseVersion)
    Sub LimpiarTablaVersiones(servidorSql As String, baseDatos As String)
    Sub GuardarVersionBaseDatos(servidorSql As String, nombreBaseDatos As String, nuevaVersion As Integer, Optional nombreTabla As String = Nothing)
    Sub GuardarVersionTodasTablas(servidor As String, tipo As DatabasesSamit, nombreDB As String)
End Interface
