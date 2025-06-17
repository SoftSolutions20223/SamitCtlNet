Public Class ResponseParametros
    Public Property Codigo As Integer
    Public Property Nombre As String
    Public Property Vigencia As DateTime
    Public Property Estado As Boolean

    Public Property Login As String
    Public Property Clave As String

    Public Property Empresas As List(Of ResponseParamEmpresa)
    Public Property FechaServidor As DateTime
    Public Property Modulos As List(Of Modulo)
End Class

Public Class ResponseParamEmpresa
    Public Property Codigo As Integer
    Public Property Nombre As String

    Public Property Oficinas As List(Of ResponseParamOficina)

    Public Property ParametrosGenerales As New EmpresaParametrosGeneral
End Class

Public Class ResponseParamOficina
    Public Property Codigo As Integer
    Public Property Nombre As String

    Public Property Roles As List(Of ResponseParamRol)
    Public Property FechaVentas As Date
End Class

Public Class ResponseParamRol
    Public Property Codigo As Integer
    Public Property Nombre As String

End Class

Public Class Modulo
    Public Property Modulo As Integer
    Public Property Nombre As String
End Class

Public Class EmpresaParametrosGeneral
    Public Property CodigoEmpresa As Integer
    Public Property CtrlFecVentasEmpresa As Boolean
    Public Property CtrlFecVentasFecServ As Boolean
    Public Property CtrlFecVentasFecTrabajo As Boolean

    Public Property FechaVentas As DateTime
End Class