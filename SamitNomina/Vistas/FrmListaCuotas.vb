Imports SamitCtlNet
Public Class FrmListaCuotas

    Dim SrtConsulta As String
    Dim HDevExpre As New HelperDevExpress
    Dim HNomina As New HelperNomina
    Public Property PStrConsulta As String
        Get
            Return SrtConsulta
        End Get
        Set(value As String)
            SrtConsulta = value
        End Set
    End Property


    Private Sub CreaGrilla()
        Dim coloor As System.Drawing.Color = Color.White
        gvListaC.Columns.Clear()
        HDevExpre.CreaColumnasG(gvListaC, "TipoLiquidacion", "Tipo Liquidacion", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 30, gcListaC.Width)
        HDevExpre.CreaColumnasG(gvListaC, "Codigo", "Codigo Liquidacion", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 30, gcListaC.Width)
        HDevExpre.CreaColumnasG(gvListaC, "NumCuota", "Cuota", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 30, gcListaC.Width)
        gvListaC.Appearance.HeaderPanel.Font = New Font("Trebuchet MS", 11.0!, FontStyle.Bold)
        gvListaC.Appearance.ViewCaption.Options.UseTextOptions = True
    End Sub

    Private Sub FrmListaCuotas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CreaGrilla()
        Dim dt As DataTable = SMT_AbrirTabla(ObjetoApiNomina, SrtConsulta)
        gcListaC.DataSource = dt
    End Sub

    Private Sub gcListaC_Click(sender As Object, e As EventArgs) Handles gcListaC.Click

    End Sub
End Class