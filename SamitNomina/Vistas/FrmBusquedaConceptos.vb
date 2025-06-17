Public Class FrmBusquedaConceptos
    Dim Formu As String
    Dim HDevExpre As New HelperDevExpress
    Dim HNomina As New HelperNomina
    Public Property Fomulario() As String
        Get
            Return Formu
        End Get
        Set(value As String)
            Formu = value
        End Set
    End Property
    Private Sub FrmBusquedaConceptos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNomina.Select()
        AsignaScriptAcontroles()
        AcomodaForm()
    End Sub
    Private Sub AsignaScriptAcontroles()
        Try
            txtConcepto.ConsultaSQL = String.Format("SELECT Sec AS Codigo,NomConcepto As Descripcion FROM  ConceptosNomina")
            txtConcepto.RefrescarDatos()
            txtNomina.ConsultaSQL = String.Format("SELECT SecNomina AS Codigo,NomNomina As Descripcion FROM  Nominas ")
            txtNomina.RefrescarDatos()
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "AsignaScriptAcontroles")
        End Try
    End Sub

    Private Sub AcomodaForm()
        Try
            btnAceptar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Aceptar)
            btnCancelar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Cancelar)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim sql As String = ""
        If txtNomina.ValordelControl <> "" And txtNomina.DescripciondelControl <> "No Se Encontraron Registros" And txtNomina.DescripciondelControl <> "" And txtConcepto.ValordelControl <> "" And txtConcepto.DescripciondelControl <> "No Se Encontraron Registros" And txtConcepto.DescripciondelControl <> "" Then
            sql = "Where CC.Concepto=" + txtConcepto.ValordelControl + " And CC.Nomina=" + txtNomina.ValordelControl
        ElseIf txtNomina.ValordelControl <> "" And txtNomina.DescripciondelControl <> "No Se Encontraron Registros" And txtNomina.DescripciondelControl <> "" Then
            sql = "Where CC.Nomina=" + txtNomina.ValordelControl
        ElseIf txtConcepto.ValordelControl <> "" And txtConcepto.DescripciondelControl <> "No Se Encontraron Registros" And txtConcepto.DescripciondelControl <> "" Then
            sql = "Where CC.Concepto=" + txtConcepto.ValordelControl
        Else
            HDevExpre.MensagedeError("Parametros de busqueda incorrectos!..")
            Exit Sub
        End If
        If Formu = "FrmConfigConceptos" Then
            FrmConfigConceptos.LimpiarCampos()
            FrmConfigConceptos.LlenaGrillaConfigConceptos(sql)
            FrmConfigConceptos.P_Consulto = True
        ElseIf Formu = "FrmConfigConceptosPro" Then
            FrmConfigConceptosPro.LimpiarCampos()
            FrmConfigConceptosPro.LlenaGrillaConfigConceptos(sql)
            FrmConfigConceptosPro.P_Consulto = True
        End If
        txtNomina.ValordelControl = ""
        txtConcepto.ValordelControl = ""
        MyBase.Close()
    End Sub

    Private Sub txtCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        txtNomina.ValordelControl = ""
        txtConcepto.ValordelControl = ""
        MyBase.Close()
    End Sub

    Private Sub FrmBusquedaConceptos_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Formu = ""
    End Sub
End Class