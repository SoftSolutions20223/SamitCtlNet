Imports SamitCtlNet
Public Class FrmListaEmpleados

    Dim HDevExpre As New HelperDevExpress
    Dim HNomina As New HelperNomina

    Private Sub FrmListaEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CreaGrilla()
        btnBuscar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Buscar)
        btnImprimir.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Imprimir)
        btnExportar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.EliminarGris)
        btnSalir.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.SalirCuadroConX)
    End Sub

    Private Sub CreaGrilla()
        Try
            gvEmpleados.Columns.Clear()
            HDevExpre.CreaColumnasG(gvEmpleados, "IdEmpleado", "ID", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 150, 0, , , , , , , , , , True)
            HDevExpre.CreaColumnasG(gvEmpleados, "IdEmpleado", "ID", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 150, 0, , , , , , , , , , True)
            HDevExpre.CreaColumnasG(gvEmpleados, "TipoIdentificacion", "Tipo Identificación", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 150, 0, , , , , , , , , , True)
            HDevExpre.CreaColumnasG(gvEmpleados, "TipoIdentificacion", "Tipo Identificación", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 150, 0, , , , , , , , , , True)
            HDevExpre.CreaColumnasG(gvEmpleados, "Identificacion", "Identificación", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 150, 0, , , , , , , , , , True)
            HDevExpre.CreaColumnasG(gvEmpleados, "Identificacion", "Identificación", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 150, 0, , , , , , , , , , True)
            HDevExpre.CreaColumnasG(gvEmpleados, "Dv", "Dv", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 20, Me.Width - 100)
            HDevExpre.CreaColumnasG(gvEmpleados, "Dv", "Dv", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 20, Me.Width - 100)
            HDevExpre.CreaColumnasG(gvEmpleados, "PApellido", "P. Apellido", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 20, Me.Width - 100)
            HDevExpre.CreaColumnasG(gvEmpleados, "PApellido", "P. Apellido", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 20, Me.Width - 100)
            HDevExpre.CreaColumnasG(gvEmpleados, "SApellido", "S. Apellido", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 20, Me.Width - 100)
            HDevExpre.CreaColumnasG(gvEmpleados, "SApellido", "S. Apellido", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 20, Me.Width - 100)
            HDevExpre.CreaColumnasG(gvEmpleados, "PNombre", "P. Nombre", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 200, 0, , , , , , , , , , True)
            HDevExpre.CreaColumnasG(gvEmpleados, "PNombre", "P. Nombre", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 200, 0, , , , , , , , , , True)
            HDevExpre.CreaColumnasG(gvEmpleados, "SNombre", "S. Nombre", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 200, 0, , , , , , , , , , True)
            HDevExpre.CreaColumnasG(gvEmpleados, "SNombre", "S. Nombre", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 200, 0, , , , , , , , , , True)
            HDevExpre.CreaColumnasG(gvEmpleados, "Genero", "Genero", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 20, Me.Width - 100)
            HDevExpre.CreaColumnasG(gvEmpleados, "Genero", "Genero", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 20, Me.Width - 100)
            HDevExpre.CreaColumnasG(gvEmpleados, "FechaNacimiento", "Fecha Nacimiento", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 20, Me.Width - 100)
            HDevExpre.CreaColumnasG(gvEmpleados, "FechaNacimiento", "Fecha Nacimiento", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 20, Me.Width - 100)
            HDevExpre.CreaColumnasG(gvEmpleados, "FechaExpDoc", "Fecha Exp. Documento", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 20, Me.Width - 100)
            HDevExpre.CreaColumnasG(gvEmpleados, "FechaExpDoc", "Fecha Exp. Documento", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 20, Me.Width - 100)
            HDevExpre.CreaColumnasG(gvEmpleados, "Direccion", "Direccion", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 20, Me.Width - 100)
            HDevExpre.CreaColumnasG(gvEmpleados, "Direccion", "Direccion", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 20, Me.Width - 100)
            HDevExpre.CreaColumnasG(gvEmpleados, "Barrio", "Barrio", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 20, Me.Width - 100)
            HDevExpre.CreaColumnasG(gvEmpleados, "Barrio", "Barrio", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 20, Me.Width - 100)
            HDevExpre.CreaColumnasG(gvEmpleados, "Email1", "Email 1", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 20, Me.Width - 100)
            HDevExpre.CreaColumnasG(gvEmpleados, "Email1", "Email 1", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 20, Me.Width - 100)
            HDevExpre.CreaColumnasG(gvEmpleados, "Email2", "Email 2", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 20, Me.Width - 100)
            HDevExpre.CreaColumnasG(gvEmpleados, "Email2", "Email 2", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 20, Me.Width - 100)
            HDevExpre.CreaColumnasG(gvEmpleados, "PersonasaCargo", "Personas a Cargo", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 20, Me.Width - 100)
            HDevExpre.CreaColumnasG(gvEmpleados, "PersonasaCargo", "Personas a Cargo", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 20, Me.Width - 100)
            HDevExpre.CreaColumnasG(gvEmpleados, "EstadoCivil", "Estado Civil", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 20, Me.Width - 100)
            HDevExpre.CreaColumnasG(gvEmpleados, "EstadoCivil", "Estado Civil", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 20, Me.Width - 100)
            HDevExpre.CreaColumnasG(gvEmpleados, "Tel1", "Teléfono 1", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 20, Me.Width - 100)
            HDevExpre.CreaColumnasG(gvEmpleados, "Tel1", "Teléfono 1", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 20, Me.Width - 100)
            HDevExpre.CreaColumnasG(gvEmpleados, "Tel2", "Teléfono 2", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 20, Me.Width - 100)
            HDevExpre.CreaColumnasG(gvEmpleados, "Tel2", "Teléfono 2", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 20, Me.Width - 100)
            HDevExpre.CreaColumnasG(gvEmpleados, "NumCelular", "Celular", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 20, Me.Width - 100)
            HDevExpre.CreaColumnasG(gvEmpleados, "NumCelular", "Celular", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 20, Me.Width - 100)
            HDevExpre.CreaColumnasG(gvEmpleados, "WebPage", "Página Web", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 20, Me.Width - 100)
            HDevExpre.CreaColumnasG(gvEmpleados, "WebPage", "Página Web", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 20, Me.Width - 100)
            HDevExpre.CreaColumnasG(gvEmpleados, "LicCategoria", "Cat. Licencia", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 20, Me.Width - 100)
            HDevExpre.CreaColumnasG(gvEmpleados, "LicCategoria", "Cat. Licencia", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 20, Me.Width - 100)
            HDevExpre.CreaColumnasG(gvEmpleados, "ClaseLib", "Clase Libreta", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 20, Me.Width - 100)
            HDevExpre.CreaColumnasG(gvEmpleados, "ClaseLib", "Clase Libreta", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 20, Me.Width - 100)
            HDevExpre.CreaColumnasG(gvEmpleados, "NumLib", "Número Libreta", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 20, Me.Width - 100)
            HDevExpre.CreaColumnasG(gvEmpleados, "NumLib", "Número Libreta", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 20, Me.Width - 100)
            HDevExpre.CreaColumnasG(gvEmpleados, "DistritoLib", "Ditrito Militar", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 20, Me.Width - 100)
            HDevExpre.CreaColumnasG(gvEmpleados, "DistritoLib", "Ditrito Militar", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 20, Me.Width - 100)
            HDevExpre.CreaColumnasG(gvEmpleados, "Pensionado", "Pensionado", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 20, Me.Width - 100)
            HDevExpre.CreaColumnasG(gvEmpleados, "Pensionado", "Pensionado", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 20, Me.Width - 100)
            HDevExpre.CreaColumnasG(gvEmpleados, "Comentario", "Comentario", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 20, Me.Width - 100)
            HDevExpre.CreaColumnasG(gvEmpleados, "Comentario", "Comentario", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 20, Me.Width - 100)


            gvEmpleados.ViewCaption = "Listado de Empleados"
            gvEmpleados.OptionsView.ShowViewCaption = True
            gvEmpleados.Appearance.HeaderPanel.Font = New Font("Trebuchet MS", 11.0!, FontStyle.Bold)
            'gvEmpleados.Columns.Add(GrillaDevExpress.CrearColumna("Foto", "Foto"))
            'gvEmpleados.Columns.Add(GrillaDevExpress.CrearColumna("", ""))
            'gvEmpleados.Columns.Add(GrillaDevExpress.CrearColumna("", ""))
            'gvEmpleados.Columns.Add(GrillaDevExpress.CrearColumna("", ""))
            'gvEmpleados.Columns.Add(GrillaDevExpress.CrearColumna("", ""))
            'gvEmpleados.Columns.Add(GrillaDevExpress.CrearColumna("", ""))
            'gvEmpleados.Columns.Add(GrillaDevExpress.CrearColumna("", ""))
            'gvEmpleados.Columns.Add(GrillaDevExpress.CrearColumna("", ""))
            'gvEmpleados.Columns.Add(GrillaDevExpress.CrearColumna("", ""))
            'gvEmpleados.Columns.Add(GrillaDevExpress.CrearColumna("", ""))
            'gvEmpleados.Columns.Add(GrillaDevExpress.CrearColumna("", ""))
            'gvEmpleados.Columns.Add(GrillaDevExpress.CrearColumna("", ""))
            'gvEmpleados.Columns.Add(GrillaDevExpress.CrearColumna("", ""))
            'gvEmpleados.Columns.Add(GrillaDevExpress.CrearColumna("", ""))
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "CreaGrilla")
            HDevExpre.msgError(ex, ex.Message, "CreaGrilla")
        End Try
    End Sub

    Private Sub LlenaGrilla()
        Try
            Dim sql As String = String.Format("SELECT EM.Sec,EM.TipoIdentificacion,EM.Identificacion," +
            " EM.Dv,EM.PApellido,EM.SApellido,EM.PNombre,EM.SNombre,EM.Genero," +
            " EM.FechaNacimiento,EM.FechaExpDoc,EM.Direccion,EM.Barrio,EM.Email1," +
            " EM.Email2,EM.PersonasaCargo,EM.EstadoCivil,EM.Tel1,EM.Tel2,EM.NumCelular," +
            " EM.WebPage,EM.LicCategoria,EM.ClaseLib,EM.NumLib,EM.DistritoLib," +
            " EM.Pensionado,EM.Comentario FROM  Empleados EM")
            Dim dt As DataTable = SMT_AbrirTabla(ObjetoApiNomina, sql)
            gcEmpleados.DataSource = dt
            If dt.Rows.Count = 0 Then
                HDevExpre.mensajeExitoso("No se encontraron registros...")
                HDevExpre.mensajeExitoso("No se encontraron registros...")
                Exit Sub
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "LlenaGrilla")
            HDevExpre.msgError(ex, ex.Message, "LlenaGrilla")
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        LlenaGrilla()
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        gvEmpleados.ShowPrintPreview()
    End Sub

    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        Try
            If Me.gvEmpleados.RowCount = 0 Then
                HDevExpre.MensagedeError("Lo sentimos, la tabla se encuentra vacia. :|")
                HDevExpre.MensagedeError("Lo sentimos, la tabla se encuentra vacia. :|")
                Exit Sub
            Else
                'If Not Datos.Seguridad.TransaccionAutorizada(21025L) Then
                '   HDevExpre.MensagedeError("Lo sentimos, no cuenta con permisos suficientes para realizar esta acción.")
                '    Exit Sub
                'End If
                Dim saveFileDialog As SaveFileDialog = New SaveFileDialog() With {.Filter = "Excel (*.xlsx)|*.xlsx"}
                If saveFileDialog.ShowDialog() = DialogResult.OK Then
                    Dim fileName As String = saveFileDialog.FileName
                    Me.gvEmpleados.ExportToXlsx(fileName)
                    Process.Start(fileName)
                End If
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "btnExpExcel_Click")
            HDevExpre.msgError(ex, ex.Message, "btnExpExcel_Click")
        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnBuscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles btnSalir.KeyPress, btnImprimir.KeyPress, btnExportar.KeyPress, btnBuscar.KeyPress
        HDevExpre.AtrasConScape(e)
        HDevExpre.AtrasConScape(e)
    End Sub
End Class