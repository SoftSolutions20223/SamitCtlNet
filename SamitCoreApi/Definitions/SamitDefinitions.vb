Public Module SamitDefinitions

    Public Function GetNombreBaseDatosSeguridad() As String
        Return "SEGURIDAD"
    End Function

    Private Function GetEmpresaPrefix(empresa As Integer) As String
        Dim empresaCod = empresa.ToString().PadLeft(3, "0")
        Return $"E{empresaCod}"
    End Function

    Public Function GetNombreBaseDatosAño(empresa As Integer, año As Integer) As String
        Dim empresaPrefix = GetEmpresaPrefix(empresa)
        Dim añoSuflix = año.ToString().PadLeft(4, "0")
        Return $"{empresaPrefix}{añoSuflix}"
    End Function

    Public Function GetNombreBaseDatosGeneral(empresa As Integer) As String
        Dim empresaPrefix = GetEmpresaPrefix(empresa)
        Return $"{empresaPrefix}GENERAL"
    End Function

    Public Function GetNombreBaseDatosNomina(empresa As Integer) As String
        Dim empresaPrefix = GetEmpresaPrefix(empresa)
        Return $"{empresaPrefix}NOMINA"
    End Function

    Public Function GetNombreBaseDatosNominaFull(empresa As Integer) As String
        Dim empresaPrefix = GetEmpresaPrefix(empresa)
        Return $"{empresaPrefix}NOMINAFULL"
    End Function

    Public Function GetNombreBaseDatosPedidos(empresa As Integer) As String
        Dim empresaPrefix = GetEmpresaPrefix(empresa)
        Return $"{empresaPrefix}PEDIDOS"
    End Function

End Module
