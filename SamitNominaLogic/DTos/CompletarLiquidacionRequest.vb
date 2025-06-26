Imports Newtonsoft.Json.Linq

Public Class CompletarLiquidacionRequest
    Public Property SecNominaLiquida As Integer
    Public Property SecPeriodo As Integer
    Public Property EsLiquidacionDefinitiva As Boolean
    Public Property Usuario As String
    Public Property Terminal As String
    Public Property FechaHora As DateTime
    Public Property Contratos As List(Of ContratoCompletarLiquidacionDto)

    Public Sub New()
        Contratos = New List(Of ContratoCompletarLiquidacionDto)()
        Terminal = Environment.MachineName
        FechaHora = DateTime.Now
    End Sub

    Public Function ToJObject() As JObject
        Dim json As New JObject()

        json("SecNominaLiquida") = SecNominaLiquida
        json("SecPeriodo") = SecPeriodo
        json("EsLiquidacionDefinitiva") = EsLiquidacionDefinitiva
        json("Usuario") = Usuario
        json("Terminal") = Terminal
        json("FechaHora") = FechaHora.ToString("yyyy-MM-dd HH:mm:ss")

        Dim jContratos As New JArray()
        For Each contrato In Contratos
            Dim jContrato As New JObject()

            ' Datos básicos del contrato
            jContrato("SecNominaLiquidaContrato") = contrato.SecNominaLiquidaContrato
            jContrato("CodContrato") = contrato.CodContrato
            jContrato("Total") = contrato.Total
            jContrato("TotalIngresos") = contrato.TotalIngresos
            jContrato("TotalDeducciones") = contrato.TotalDeducciones
            jContrato("TotalProvisiones") = contrato.TotalProvisiones
            jContrato("TotalDescuentosNomina") = contrato.TotalDescuentosNomina
            jContrato("TotalFondos") = contrato.TotalFondos
            jContrato("Comentario") = contrato.Comentario
            jContrato("HorasMes") = contrato.HorasMes
            jContrato("CargoActual") = contrato.CargoActual
            jContrato("Asignacion") = contrato.Asignacion

            ' Conceptos ID
            Dim jConceptosID As New JArray()
            For Each concepto In contrato.ConceptosID
                Dim jConcepto As New JObject()
                jConcepto("NomConcepto") = concepto.NomConcepto
                jConcepto("Valor") = concepto.Valor
                jConcepto("Base") = concepto.Base
                jConcepto("NomBase") = concepto.NomBase
                jConcepto("SecConcepto") = concepto.SecConcepto
                jConcepto("SecConceptoP") = concepto.SecConceptoP
                jConcepto("SecConceptoP2") = concepto.SecConceptoP2
                jConcepto("Cuota") = concepto.Cuota
                jConceptosID.Add(jConcepto)
            Next
            jContrato("ConceptosID") = jConceptosID

            ' Conceptos P
            Dim jConceptosP As New JArray()
            For Each concepto In contrato.ConceptosP
                Dim jConcepto As New JObject()
                jConcepto("NomConcepto") = concepto.NomConcepto
                jConcepto("Valor") = concepto.Valor
                jConcepto("Base") = concepto.Base
                jConcepto("NomBase") = concepto.NomBase
                jConcepto("SecConcepto") = concepto.SecConcepto
                jConceptosP.Add(jConcepto)
            Next
            jContrato("ConceptosP") = jConceptosP

            ' Conceptos DPN
            Dim jConceptosDPN As New JArray()
            For Each concepto In contrato.ConceptosDPN
                Dim jConcepto As New JObject()
                jConcepto("NomConcepto") = concepto.NomConcepto
                jConcepto("Valor") = concepto.Valor
                jConcepto("Base") = concepto.Base
                jConcepto("NomBase") = concepto.NomBase
                jConcepto("SecConceptoP") = concepto.SecConceptoP
                jConcepto("SecConceptoP2") = concepto.SecConceptoP2
                jConcepto("Cuota") = concepto.Cuota
                jConceptosDPN.Add(jConcepto)
            Next
            jContrato("ConceptosDPN") = jConceptosDPN

            jContratos.Add(jContrato)
        Next
        json("Contratos") = jContratos

        Return json
    End Function
End Class