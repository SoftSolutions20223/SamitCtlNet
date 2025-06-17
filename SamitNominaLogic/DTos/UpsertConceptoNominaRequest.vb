Public Class UpsertConceptoNominaRequest
    Public Property ConceptoNomina As ConceptosNomina
    Public Property Usuario As String
    Public Property Terminal As String

    Public Sub New()
        ConceptoNomina = New ConceptosNomina()
        Terminal = Environment.MachineName
    End Sub

    Public Function ToJObject() As Newtonsoft.Json.Linq.JObject
        Dim json As New Newtonsoft.Json.Linq.JObject()

        ' Datos del concepto
        json("Sec") = If(ConceptoNomina?.Sec, 0)
        json("NomConcepto") = ConceptoNomina?.NomConcepto
        json("Vigente") = ConceptoNomina?.Vigente
        json("Formula") = ConceptoNomina?.Formula
        json("Tipo") = ConceptoNomina?.Tipo
        json("PeriodosLiquida") = ConceptoNomina?.PeriodosLiquida
        json("Base") = ConceptoNomina?.Base
        json("Redondea") = ConceptoNomina?.Redondea
        json("Fondo") = ConceptoNomina?.Fondo
        json("Clasificacion") = ConceptoNomina?.Clasificacion
        json("EsRetencion") = ConceptoNomina?.EsRetencion
        json("EsPredeterminado") = ConceptoNomina?.EsPredeterminado
        json("CodDian") = ConceptoNomina?.CodDian
        json("Orden") = ConceptoNomina?.Orden
        json("Usuario") = Usuario
        json("Terminal") = Terminal

        Return json
    End Function
End Class
