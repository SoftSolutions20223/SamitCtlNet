Public Class NominaResponseDto
    Public Property Sec As Integer
    Public Property NomNomina As String
    Public Property FormaLiquida As Short?
    Public Property Fecha As Date?
    Public Property Oficina As Short?
    Public Property TotalConceptosConfigurados As Integer
    Public Property ConceptosNuevos As Integer
    Public Property TotalProvisionesConfiguradas As Integer
    Public Property ProvisionesNuevas As Integer
    Public Property ConceptosConfigurados As List(Of ConceptoConfiguradoDto)
    Public Property ProvisionesConfiguradas As List(Of ProvisionConfiguradaDto)

    Public Sub New()
        ConceptosConfigurados = New List(Of ConceptoConfiguradoDto)()
        ProvisionesConfiguradas = New List(Of ProvisionConfiguradaDto)()
    End Sub

    ' Método para convertir a la clase del modelo
    Public Function ToNomina() As Nominas
        Return New Nominas With {
            .Sec = Sec,
            .NomNomina = NomNomina,
            .FormaLiquida = FormaLiquida,
            .Fecha = Fecha,
            .Oficina = Oficina
        }
    End Function
End Class