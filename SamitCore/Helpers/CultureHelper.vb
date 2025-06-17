Imports System.Globalization
Imports System.Threading

Public Module CultureHelper

    Public Sub SetCulture()
        Dim ci As CultureInfo = GetCulture_esCo()
        Thread.CurrentThread.CurrentCulture = ci
        Thread.CurrentThread.CurrentUICulture = ci
        CultureInfo.DefaultThreadCurrentCulture = ci
        CultureInfo.DefaultThreadCurrentUICulture = ci
        Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = "."
        Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = "."
        Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = ","
        Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = ","
    End Sub

    Public Function GetCulture_esCo() As CultureInfo
        Dim ci As CultureInfo = New CultureInfo("es-CO", False)
        Return ci
    End Function

End Module
