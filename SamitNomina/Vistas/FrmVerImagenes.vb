Imports DevExpress.XtraBars.Ribbon
Imports SamitCtlNet

Public Class FrmVerImagenes
    Dim HDevExpre As New HelperDevExpress
    Dim HNomina As New HelperNomina
    Dim tipoImg As HelperEmpleado.TiposDeImagenes
    Dim secuTipo As String
    Dim idEmpl As String
    Dim VsecImagen As Integer
    Dim ImagenSeleccionada As GalleryItem
    Dim dtImgs As DataTable
    Public Property secImagen() As Integer
        Get
            Return VsecImagen
        End Get
        Set(value As Integer)
            VsecImagen = value
        End Set
    End Property
    Dim VtienePredeterminada As Boolean
    Public Property TienePredeterinada As Boolean
        Get
            Return VtienePredeterminada
        End Get
        Set(value As Boolean)
            VtienePredeterminada = value
        End Set
    End Property
    Public Sub New(TipoImgs As HelperEmpleado.TiposDeImagenes, SecTipo As String, IdEmp As String, dtImagenes As DataTable)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        Try
            Dim GrupoImagenes As New GalleryItemGroup
            GaleriaFotos.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.Squeeze
            GaleriaFotos.Gallery.ImageSize = New Size(80, 80)
            GaleriaFotos.Gallery.ShowItemText = False
            GrupoImagenes.CaptionAlignment = GalleryItemGroupCaptionAlignment.Left
            GaleriaFotos.Gallery.ItemCheckMode = Gallery.ItemCheckMode.SingleCheck
            GaleriaFotos.Gallery.Groups.Add(GrupoImagenes)
            btnEliminaImg.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Eliminar)
            btnImprimir.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Imprimir)
            btnSalir.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.SalirAtras)
            For i = 0 To dtImagenes.Rows.Count - 1
                Dim img As Image = SamitCtlNet.SamitCtlNet.ClSmtImagenes.SMT_Conv_Byte_A_Image(CType(dtImagenes.Rows(i)("Foto"), Byte()))
                GrupoImagenes.Items.Add(New GalleryItem(img, dtImagenes.Rows(i)("SecIngreso").ToString, ""))
            Next
            tipoImg = TipoImgs
            secuTipo = SecTipo
            idEmpl = IdEmp
            dtImgs = dtImagenes
            ckbImgPredeterminada.Visible = False
            If TipoImgs = HelperEmpleado.TiposDeImagenes.Empleado Then
                ckbImgPredeterminada.Visible = True
            ElseIf TipoImgs = HelperEmpleado.TiposDeImagenes.Familiares Then
                ckbImgPredeterminada.Visible = True
            End If
            ckbImgPredeterminada.Checked = False

        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "Inicializa FrmVerImagenes")
        End Try
    End Sub


    Private Sub GaleriaFotos_Gallery_ItemClick(sender As Object, e As GalleryItemClickEventArgs) Handles GaleriaFotos.Gallery.ItemClick
        Try
            Dim Filtro As String
            Dim filas As DataRow()
            '   Dim dt As DataTable = dtImgs.Clone
            ImagenSeleccionada = e.Item
            pcbImg.Image = e.Item.Image
            secImagen = Convert.ToInt32(e.Item.Caption)
            If TienePredeterinada Then
                Filtro = "SecIngreso='" + e.Item.Caption + "'"

                filas = dtImgs.Select(Filtro)
                If filas.Length > 0 Then

                    For Each fila As DataRow In filas
                        Dim predet As Boolean = Convert.ToBoolean(fila("Predeterminada"))
                        If predet Then ckbImgPredeterminada.Checked = True Else ckbImgPredeterminada.Checked = False
                        Exit Sub
                    Next
                End If
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "GaleriaFotos_Gallery_ItemClick")
        End Try
    End Sub

    Private Sub btnEliminaImg_Click(sender As Object, e As EventArgs) Handles btnEliminaImg.Click
        If Not pcbImg.Image Is Nothing Then
            If HDevExpre.MsgSamit("La imagen sera Eliminada de manera permanente, Desea continuar?...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.OK Then
                If Not EliminaImagen() Then
                    HDevExpre.MensagedeError("Lo sentimos, ha ocurido un error al eliminar la Fotografía o Certificado!")
                Else
                    GaleriaFotos.Gallery.Groups(0).Items.Remove(ImagenSeleccionada)
                    pcbImg.Image = Nothing
                    ImagenSeleccionada = Nothing
                End If

            End If
        Else
            HDevExpre.MensagedeError("Debe Cargar una imagen para poder continuar...")
        End If
    End Sub
    Private Sub ValidaSiEsPredeterinada(Chequeado As Boolean)
        Try
            If Chequeado Then
                Dim Filtro As String
                Dim rows As DataRow()
                Dim sql As String = String.Format("UPDATE Empleados_RegFot  SET Predeterminada=0 WHERE IdEmpleado={0} AND Tipo={1} AND SecTipo={2} AND Predeterminada=1",
                                                  idEmpl, Convert.ToInt32(tipoImg), secuTipo)
                SMT_EjcutarComandoSqlBool(ObjetoApiNomina, sql)
                sql = String.Format("UPDATE Empleados_RegFot  SET Predeterminada=1 WHERE SecIngreso={0}", secImagen)
                SMT_EjcutarComandoSql(ObjetoApiNomina, sql, 0)
                Filtro = "Predeterminada=True"
                rows = dtImgs.Select(Filtro, "")
                For Each fila As DataRow In rows
                    fila("Predeterminada") = False
                    Exit For
                Next
                Filtro = String.Format("SecIngreso='{0}'", secImagen)
                rows = dtImgs.Select(Filtro, "")
                For Each fila As DataRow In rows
                    fila("Predeterminada") = True
                    Exit For
                Next
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "ckbImgPredeterminada_CheckedChanged")
        End Try
    End Sub
    Private Function EliminaImagen() As Boolean
        Try
            Dim sql As String = String.Format("DELETE  FROM Empleados_RegFot WHERE IdEmpleado={0} AND Tipo={1} AND SecTipo={2} AND SecIngreso={3}", idEmpl, Convert.ToInt32(tipoImg), secuTipo, secImagen)
            If SMT_EjcutarComandoSqlBool(ObjetoApiNomina, sql) = 0 Then
                Return False
                Exit Function
            Else : Return True
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "EliminaImagen")
            Return False
        End Try
    End Function

    Private Sub FrmVerImagenes_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        FrmEmpleado.CargaImagenesEmpleado()
        If tipoImg = 0 Then 'Empleado = 0
            If FrmEmpleado.dtImagenes.Rows.Count > 0 Then
                Dim StringFiltro As String = String.Format("IdEmpleado={0} AND Tipo={1} AND SecTipo={2} AND Predeterminada=True", FrmEmpleado.idEmpleado,
                                       Convert.ToInt32(HelperEmpleado.TiposDeImagenes.Empleado),
                                       FrmEmpleado.idEmpleado)
                FrmEmpleado.MostrarImageneEnPictureEdit(StringFiltro, FrmEmpleado.pcbFotografiaEmpleado)
            End If
        ElseIf tipoImg = 1 Then 'Familiares = 1
            If FrmEmpleado.dtImagenes.Rows.Count > 0 Then
                Dim StringFiltro As String = String.Format("IdEmpleado={0} AND Tipo={1} AND SecTipo={2} AND Predeterminada=True", FrmEmpleado.idEmpleado,
                                       Convert.ToInt32(HelperEmpleado.TiposDeImagenes.Familiares),
                                      FrmEmpleado.gvFamiliares.GetFocusedRowCellValue("SecIngreso"))
                FrmEmpleado.MostrarImageneEnPictureEdit(StringFiltro, FrmEmpleado.pcbImgFamiliar)
            End If
        ElseIf tipoImg = 2 Then 'Estudios = 2
            If FrmEmpleado.dtImagenes.Rows.Count > 0 Then
                Dim StringFiltro As String = String.Format("IdEmpleado={0} AND Tipo={1} AND SecTipo={2} ", FrmEmpleado.idEmpleado,
                                       Convert.ToInt32(HelperEmpleado.TiposDeImagenes.Estduios),
                                      FrmEmpleado.gvEstudios.GetFocusedRowCellValue("SecIngreso"))
                FrmEmpleado.MostrarImagenesEnGaleria(StringFiltro, FrmEmpleado.grupoImgsInfAcademica)
            End If
        ElseIf tipoImg = 3 Then 'Experiencia Laboral = 3
            If FrmEmpleado.dtImagenes.Rows.Count > 0 Then
                Dim StringFiltro As String = String.Format("IdEmpleado={0} AND Tipo={1} AND SecTipo={2} ", FrmEmpleado.idEmpleado,
                                       Convert.ToInt32(HelperEmpleado.TiposDeImagenes.ExperienciaLaboral),
                                      FrmEmpleado.gvExpLaboral.GetFocusedRowCellValue("SecIngreso"))
                FrmEmpleado.MostrarImagenesEnGaleria(StringFiltro, FrmEmpleado.grupoImgsExpLaboral)
            End If
        End If

    End Sub


    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub



    Private Sub ckbImgPredeterminada_CheckStateChanged(sender As Object, e As EventArgs) Handles ckbImgPredeterminada.CheckStateChanged
        ValidaSiEsPredeterinada(ckbImgPredeterminada.Checked)
    End Sub


    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click

    End Sub
End Class