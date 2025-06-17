Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class UpsertPlantillaRequest
    ' Datos de la plantilla principal
    Public Property Plantilla As Plantillas

    ' Datos adicionales para el procedimiento
    Public Property Usuario As String
    Public Property Terminal As String

    ' Listas relacionadas
    Public Property Conceptos As List(Of ConceptoPlantillaDto)
    Public Property ConceptosProvisiones As List(Of ConceptoProvisionPlantillaDto)

    Public Sub New()
        Plantilla = New Plantillas()
        Conceptos = New List(Of ConceptoPlantillaDto)()
        ConceptosProvisiones = New List(Of ConceptoProvisionPlantillaDto)()
        Terminal = Environment.MachineName
    End Sub

    ''' <summary>
    ''' Convierte a JObject para el procedimiento almacenado
    ''' </summary>
    Public Function ToJObject() As JObject
        Dim json As New JObject()

        ' Datos de la plantilla
        json("Sec") = If(Plantilla?.Sec, 0)
        json("NomPlantilla") = Plantilla?.NomPlantilla
        json("Vigente") = Plantilla?.Vigente
        json("ValorMaxDescontar") = Plantilla?.ValorMaxDescontar
        json("Usuario") = Usuario
        json("Terminal") = Terminal

        ' Array de conceptos
        Dim jConceptos As New JArray()
        For Each concepto In Conceptos
            Dim jCon As New JObject()
            jCon("Concepto") = concepto.Concepto
            jConceptos.Add(jCon)
        Next
        json("Conceptos") = jConceptos

        ' Array de conceptos de provisión
        Dim jConceptosProv As New JArray()
        For Each conceptoProv In ConceptosProvisiones
            Dim jConProv As New JObject()
            jConProv("Concepto") = conceptoProv.Concepto
            jConceptosProv.Add(jConProv)
        Next
        json("ConceptosProvisiones") = jConceptosProv

        Return json
    End Function

    ''' <summary>
    ''' Método auxiliar para obtener el JSON como string
    ''' </summary>
    Public Function ToJsonString() As String
        Return ToJObject().ToString(Formatting.None)
    End Function
End Class