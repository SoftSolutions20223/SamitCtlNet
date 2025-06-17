Public Class PlantillaResponseDto
    Public Property Sec As Integer
    Public Property NomPlantilla As String
    Public Property Vigente As String
    Public Property ValorMaxDescontar As String
    Public Property Conceptos As List(Of ConceptoPlantillaDto)
    Public Property ConceptosProvisiones As List(Of ConceptoProvisionPlantillaDto)
    Public Property ContratosAfectados As Integer

    Public Sub New()
        Conceptos = New List(Of ConceptoPlantillaDto)()
        ConceptosProvisiones = New List(Of ConceptoProvisionPlantillaDto)()
    End Sub
End Class
