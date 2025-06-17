Imports Newtonsoft.Json.Linq

Public Class UpsertLiquidacionNominaRequest
    ' Datos principales
    Public Property Periodo As Integer
    Public Property OfiNomina As Integer
    Public Property OfiRegistra As Integer
    Public Property Nomina As Integer
    Public Property Año As Integer
    Public Property NumPeriodo As Integer
    Public Property NumMes As Integer
    Public Property BasarEnPeriodoAnterior As Boolean

    ' Datos de control
    Public Property Usuario As String
    Public Property Terminal As String
    Public Property FechaSys As DateTime

    ' Listas de contratos y variables
    Public Property Contratos As List(Of ContratoLiquidacionDto)
    Public Property VariablesDefecto As List(Of VariableDefectoDto)

    Public Sub New()
        Contratos = New List(Of ContratoLiquidacionDto)()
        VariablesDefecto = New List(Of VariableDefectoDto)()
        Terminal = Environment.MachineName
        FechaSys = DateTime.Now
    End Sub

    Public Function ToJObject() As JObject
        Dim json As New JObject()

        ' Datos principales
        json("Periodo") = Periodo
        json("OfiNomina") = OfiNomina
        json("OfiRegistra") = OfiRegistra
        json("Nomina") = Nomina
        json("Año") = Año
        json("NumPeriodo") = NumPeriodo
        json("NumMes") = NumMes
        json("BasarEnPeriodoAnterior") = BasarEnPeriodoAnterior
        json("Usuario") = Usuario
        json("Terminal") = Terminal
        json("FechaSys") = FechaSys.ToString("yyyy-MM-dd HH:mm:ss")

        ' Array de contratos
        Dim jContratos As New JArray()
        For Each contrato In Contratos
            Dim jContrato As New JObject()
            jContrato("CodContrato") = contrato.CodContrato
            jContrato("HorasMes") = contrato.HorasMes
            jContrato("CargoActual") = contrato.CargoActual
            jContrato("Asignacion") = contrato.Asignacion
            jContratos.Add(jContrato)
        Next
        json("Contratos") = jContratos

        ' Array de variables por defecto
        Dim jVariables As New JArray()
        For Each variable In VariablesDefecto
            Dim jVar As New JObject()
            jVar("SecVariable") = variable.SecVariable
            jVar("ValorDefecto") = variable.ValorDefecto
            jVariables.Add(jVar)
        Next
        json("VariablesDefecto") = jVariables

        Return json
    End Function
End Class
