Public Class FrmOpcImpEmpleado

    Dim HDevExpre As New HelperDevExpress
    Dim HNomina As New HelperNomina

    Public Cancela As Boolean = False
    Private Sub CerrarForm()
        ckbAfiliaciones.Checked = False
        ckbExpLaboral.Checked = False
        ckbFamiliares.Checked = False
        ckbInfAcademica.Checked = False
        ckbEducacionNoFormal.Checked = False
        ckbSelTodo.Checked = False
    End Sub

    Private Sub FrmOpcImpEmpleado_Load(sender As Object, e As EventArgs) Handles Me.Load
        btnConfirmar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Imprimir)
        btnSalir.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Eliminar)
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Cancela = True
        CerrarForm()
        Me.Close()
    End Sub

    Private Sub ckbSelTodo_CheckedChanged(sender As Object, e As EventArgs) Handles ckbSelTodo.CheckedChanged
        Try
            If ckbSelTodo.Checked Then
                If ckbAfiliaciones.Enabled Then ckbAfiliaciones.Checked = True
                If ckbEducacionNoFormal.Enabled Then ckbEducacionNoFormal.Checked = True
                If ckbExpLaboral.Enabled Then ckbExpLaboral.Checked = True
                If ckbFamiliares.Enabled Then ckbFamiliares.Checked = True
                If ckbInfAcademica.Enabled Then ckbInfAcademica.Checked = True
            Else
                ckbAfiliaciones.Checked = False
                ckbEducacionNoFormal.Checked = False
                ckbExpLaboral.Checked = False
                ckbFamiliares.Checked = False
                ckbInfAcademica.Checked = False
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "ckbSelTodo_CheckedChanged")
        End Try
    End Sub
    Private Sub ckbDatosBasicos_CheckedChanged(sender As Object, e As EventArgs) Handles ckbDatosBasicos.CheckedChanged
        If ckbDatosBasicos.Checked Then
            ckbDatosBasicos.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Aplicar)
        Else
            ckbDatosBasicos.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Eliminar)
        End If
    End Sub
    Private Sub ckbInfAcademica_CheckedChanged(sender As Object, e As EventArgs) Handles ckbInfAcademica.CheckedChanged
        If ckbInfAcademica.Checked Then
            ckbInfAcademica.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Aplicar)
        Else
            ckbInfAcademica.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Eliminar)
        End If
    End Sub

    Private Sub ckbEducacionNoFormal_CheckedChanged(sender As Object, e As EventArgs) Handles ckbEducacionNoFormal.CheckedChanged
        If ckbEducacionNoFormal.Checked Then
            ckbEducacionNoFormal.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Aplicar)
        Else
            ckbEducacionNoFormal.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Eliminar)
        End If
    End Sub

    Private Sub ckbExpLaboral_CheckedChanged(sender As Object, e As EventArgs) Handles ckbExpLaboral.CheckedChanged
        If ckbExpLaboral.Checked Then
            ckbExpLaboral.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Aplicar)
        Else
            ckbExpLaboral.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Eliminar)
        End If
    End Sub

    Private Sub ckbFamiliares_CheckedChanged(sender As Object, e As EventArgs) Handles ckbFamiliares.CheckedChanged
        If ckbFamiliares.Checked Then
            ckbFamiliares.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Aplicar)
        Else
            ckbFamiliares.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Eliminar)
        End If
    End Sub

    Private Sub ckbAfiliaciones_CheckedChanged(sender As Object, e As EventArgs) Handles ckbAfiliaciones.CheckedChanged
        If ckbAfiliaciones.Checked Then
            ckbAfiliaciones.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Aplicar)
        Else
            ckbAfiliaciones.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Eliminar)
        End If
    End Sub

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        Try
            If Not ckbAfiliaciones.Checked And Not ckbDatosBasicos.Checked And Not ckbEducacionNoFormal.Checked And Not ckbExpLaboral.Checked And Not ckbFamiliares.Checked And Not ckbInfAcademica.Checked Then
                HDevExpre.MensagedeError("Debe seleccionar al menos una opción para imprimir!")
                Exit Sub
            End If
            FrmEmpleado.ImpDatosBasicos = ckbDatosBasicos.Checked
            FrmEmpleado.ImpAfiliaciones = ckbAfiliaciones.Checked
            FrmEmpleado.ImpEduNoFormal = ckbEducacionNoFormal.Checked
            FrmEmpleado.ImpExpLaboral = ckbExpLaboral.Checked
            FrmEmpleado.ImpInfAcademica = ckbInfAcademica.Checked
            FrmEmpleado.ImpInfFamiliares = ckbFamiliares.Checked
            Cancela = False
            CerrarForm()
            Me.Close()
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "btnConfirmar_Click")
        End Try

    End Sub


    Private Sub ckbDatosBasicos_MouseEnter(sender As Object, e As EventArgs) Handles ckbDatosBasicos.MouseEnter
        FrmPrincipal.MensajeDeAyuda.Caption = "Imprimir los datos Básicos del empleado"
    End Sub

    Private Sub ckbDatosBasicos_MouseLeave(sender As Object, e As EventArgs) Handles ckbDatosBasicos.MouseLeave
        FrmPrincipal.MensajeDeAyuda.Caption = ""
    End Sub

    Private Sub ckbInfAcademica_MouseEnter(sender As Object, e As EventArgs) Handles ckbInfAcademica.MouseEnter
        FrmPrincipal.MensajeDeAyuda.Caption = "Imprimir la información Académica"
    End Sub

    Private Sub ckbInfAcademica_MouseLeave(sender As Object, e As EventArgs) Handles ckbInfAcademica.MouseLeave
        FrmPrincipal.MensajeDeAyuda.Caption = ""
    End Sub

    Private Sub ckbEducacionNoFormal_MouseEnter(sender As Object, e As EventArgs) Handles ckbEducacionNoFormal.MouseEnter
        FrmPrincipal.MensajeDeAyuda.Caption = "Imprimir Educación Básica"
    End Sub

    Private Sub ckbEducacionNoFormal_MouseLeave(sender As Object, e As EventArgs) Handles ckbEducacionNoFormal.MouseLeave
        FrmPrincipal.MensajeDeAyuda.Caption = ""
    End Sub

    Private Sub ckbExpLaboral_MouseEnter(sender As Object, e As EventArgs) Handles ckbExpLaboral.MouseEnter
        FrmPrincipal.MensajeDeAyuda.Caption = "Imprimir Experiencia Laboral"
    End Sub

    Private Sub ckbExpLaboral_MouseLeave(sender As Object, e As EventArgs) Handles ckbExpLaboral.MouseLeave
        FrmPrincipal.MensajeDeAyuda.Caption = ""
    End Sub

    Private Sub ckbFamiliares_MouseEnter(sender As Object, e As EventArgs) Handles ckbFamiliares.MouseEnter
        FrmPrincipal.MensajeDeAyuda.Caption = "Imprimir Datos de Familiares"
    End Sub

    Private Sub ckbFamiliares_MouseLeave(sender As Object, e As EventArgs) Handles ckbFamiliares.MouseLeave
        FrmPrincipal.MensajeDeAyuda.Caption = ""
    End Sub

    Private Sub ckbAfiliaciones_MouseEnter(sender As Object, e As EventArgs) Handles ckbAfiliaciones.MouseEnter
        FrmPrincipal.MensajeDeAyuda.Caption = "Imprimir datos de Afiliaciones"
    End Sub

    Private Sub ckbAfiliaciones_MouseLeave(sender As Object, e As EventArgs) Handles ckbAfiliaciones.MouseLeave
        FrmPrincipal.MensajeDeAyuda.Caption = ""
    End Sub

    Private Sub ckbSelTodo_MouseEnter(sender As Object, e As EventArgs) Handles ckbSelTodo.MouseEnter
        FrmPrincipal.MensajeDeAyuda.Caption = "Seleccionar Todo"
    End Sub

    Private Sub ckbSelTodo_MouseLeave(sender As Object, e As EventArgs) Handles ckbSelTodo.MouseLeave
        FrmPrincipal.MensajeDeAyuda.Caption = ""
    End Sub
End Class