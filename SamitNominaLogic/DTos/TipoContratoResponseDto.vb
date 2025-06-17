Public Class TipoContratoResponseDto
    Public Property Sec As Integer
    Public Property CodTipo As Integer
    Public Property NomTipo As String
    Public Property ConceptosAsociados As Integer
    Public Property TotalConceptosRelacionados As Integer
    Public Property ConceptosNomina As List(Of ConceptoNominaRelacionadoDto)

    Public Sub New()
        ConceptosNomina = New List(Of ConceptoNominaRelacionadoDto)()
    End Sub

    ' Método para convertir a la clase del modelo
    Public Function ToTipoContrato() As CAT_TipoContratos
        Return New CAT_TipoContratos With {
            .Sec = Sec,
            .NomTipo = NomTipo
        }
    End Function
End Class
