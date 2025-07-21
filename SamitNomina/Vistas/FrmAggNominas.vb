Imports SamitCtlNet
Imports DevExpress.Utils
Imports System.ComponentModel
Imports DevExpress.XtraEditors.Controls
Imports SamitNominaLogic
Imports Newtonsoft.Json.Linq

Public Class FrmAggNominas
    Dim dt As DataTable
    Dim Conceptos As DataTable
    Dim Buscando As Boolean = False
    Dim Actualizando As Boolean = False
    Dim SecNomina As String = ""
    Dim secReg As Integer = 0
    Public Datos As New SamitCtlNet.SamitCtlNet

    Dim FormularioAbierto As Boolean = False
    Dim HDevExpre As New HelperDevExpress
    Dim HNomina As New HelperNomina
    Dim Nomina As New Nominas
    Public Property P_FormularioAbierto() As Boolean
        Get
            Return FormularioAbierto
        End Get
        Set(value As Boolean)
            FormularioAbierto = value
        End Set
    End Property

    Private Sub FrmAggTipoContrato_Load(sender As Object, e As EventArgs) Handles Me.Load
        AcomodaForm()
        txtNoBuscando()
        CreaGrilla()
        AsignaScriptAcontroles()
        LlenaGrillaNominas()
        txtNombreNomina.Focus()
        txtNombreNomina.MensajedeAyuda = "Digite el nombre de la nómina que desea agregar. (ENTER,TAB,ABJ)=Avanzar;(ARB,ESC)=Atras"
        txtOficina.MensajedeAyuda = "Seleccione la oficina que estará asociada a la nómina.(ENTER,TAB,ABJ)=Avanzar;(ARB,ESC)=Atras (F5,DER)=Buscar"
    End Sub

#Region "Eventos Controles"
    Private Sub txtBusqueda_EditValueChanged(sender As Object, e As EventArgs) Handles txtBusqueda.EditValueChanged
        Dim buscando As Boolean = Me.Buscando
        If buscando Then
            FiltrarDatos(txtBusqueda.Text)
        End If
    End Sub

    Private Sub AsignaScriptAcontroles()
        Try
            Dim Empresa As Integer = Datos.Seguridad.DatosDeLaEmpresa.NumEmpresa
            txtOficina.DatosDefecto = ObjetosNomina.Oficinas
            txtNominas.ConsultaSQL = String.Format("SELECT Sec AS Codigo,NomNomina As Descripcion FROM  Nominas")
            Dim Sql As String = "Select Sec From ConceptosNomina Where Vigente=1"
            Conceptos = SMT_AbrirTabla(ObjetoApiNomina, Sql)
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "AsignaScriptAcontroles")
        End Try
    End Sub

    Private Sub txtBusqueda_Enter(sender As Object, e As EventArgs) Handles txtBusqueda.Enter
        If Not Buscando Then
            txtBusqueda.Text = ""
            Buscando = True
            txtBuscando()
        End If
    End Sub

    Private Sub txtBusqueda_Leave(sender As Object, e As EventArgs) Handles txtBusqueda.Leave
        If txtBusqueda.Text = "" Then
            Buscando = False
            txtNoBuscando()
        End If
    End Sub


    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub


    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarCampos()
    End Sub

    Public Function ValidarCampos() As Boolean
        If txtNombreNomina.ValordelControl = "" Then
            HDevExpre.MensagedeError("El campo Nombre no puede estar vacío!..")
            txtNombreNomina.Focus()
            Return False
        ElseIf cke10dias.Checked = False And cke15dias.Checked = False And cke30dias.Checked = False Then
            HDevExpre.MensagedeError("Tiene que selecionar un periodo de liquidacion!..")
            cke10dias.Focus()
            Return False
        ElseIf dteFecha.Text = "" Then
            HDevExpre.MensagedeError("El campo fecha no puede estar vacío!..")
            dteFecha.Focus()
            Return False
        ElseIf txtOficina.ValordelControl = "" Then
            HDevExpre.MensagedeError("El campo Oficina no puede estar vacío!..")
            txtOficina.Focus()
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            ' 1) Primero validar campos
            If Not ValidarCampos() Then
                Exit Sub
            End If

            ' 2) Determinar forma de liquidación
            Dim formaLiquida As Short? = Nothing
            If cke10dias.Checked Then
                formaLiquida = 10
            ElseIf cke15dias.Checked Then
                formaLiquida = 15
            ElseIf cke30dias.Checked Then
                formaLiquida = 30
            End If

            ' 3) Determinar si es actualización
            Dim isUpdate = (Actualizando AndAlso secReg > 0)

            ' Crear la nómina principal usando la clase Nominas existente
            Dim nomina As New Nominas With {
            .Sec = If(isUpdate, secReg, 0),
            .NomNomina = txtNombreNomina.ValordelControl,
            .FormaLiquida = formaLiquida,
            .Fecha = If(String.IsNullOrEmpty(dteFecha.Text), Nothing, CDate(dteFecha.Text)),
            .Oficina = If(String.IsNullOrEmpty(txtOficina.ValordelControl), Nothing, CShort(txtOficina.ValordelControl))
        }

            ' Crear el request principal
            Dim request As New UpsertNominaRequest With {
            .Nomina = nomina,
            .Usuario = ObjetosNomina.Datos.Smt_Usuario,
            .Terminal = ObjetosNomina.Datos.Smt_NombreTerminal
        }

            ' 4) Ejecutar procedimiento almacenado
            Dim resp = SMT_EjecutaProcedimientos(ObjetoApiNomina, "SP_UpsertNomina", request.ToJObject())
            Dim response = resp.ToObject(Of UpsertNominaResponse)()

            ' 5) Procesar respuesta
            If response.EsExitoso Then
                ' Actualizar SecNomina con el valor devuelto
                SecNomina = response.Nomina.Sec

                ' Mostrar mensaje de éxito con información adicional
                Dim mensaje = "Información guardada exitosamente!"

                ' Agregar información sobre conceptos y provisiones creados
                'If response.Nomina.ConceptosNuevos > 0 OrElse response.Nomina.ProvisionesNuevas > 0 Then
                '    mensaje &= vbCrLf & vbCrLf
                '    If response.Nomina.ConceptosNuevos > 0 Then
                '        mensaje &= $"• Se configuraron {response.Nomina.ConceptosNuevos} conceptos nuevos" & vbCrLf
                '    End If
                '    If response.Nomina.ProvisionesNuevas > 0 Then
                '        mensaje &= $"• Se configuraron {response.Nomina.ProvisionesNuevas} provisiones nuevas" & vbCrLf
                '    End If
                '    mensaje &= vbCrLf & $"Total de conceptos configurados: {response.Nomina.TotalConceptosConfigurados}" & vbCrLf
                '    mensaje &= $"Total de provisiones configuradas: {response.Nomina.TotalProvisionesConfiguradas}"
                'End If

                HDevExpre.mensajeExitoso(mensaje)

                ' Refrescar UI
                LlenaGrillaNominas()
                LimpiarCampos()

                ' Resetear estado de actualización
                Actualizando = False
                secReg = 0

                ' Log de conceptos configurados (opcional, para debugging)
                If response.Nomina.ConceptosConfigurados?.Count > 0 Then
                    Console.WriteLine($"Últimos conceptos configurados:")
                    For Each concepto In response.Nomina.ConceptosConfigurados
                        Console.WriteLine($"  - {concepto.NomConcepto} (Sec: {concepto.Sec})")
                    Next
                End If

            Else
                ' Mostrar error
                HDevExpre.MensagedeError($"Error al guardar los datos: {response.Mensaje}")

                ' Log adicional si hay código de error
                If response.CodigoError.HasValue Then
                    Console.WriteLine($"Código de error SQL: {response.CodigoError.Value}")
                End If

                ' Si hay datos enviados en el error, mostrarlos en consola para debugging
                If response.DatosEnviados IsNot Nothing Then
                    Console.WriteLine($"Datos enviados: {Newtonsoft.Json.JsonConvert.SerializeObject(response.DatosEnviados)}")
                End If
            End If

        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "btnGuardar_Click/Nominas")
        End Try
    End Sub

    Private Sub gvNominas_DoubleClick(sender As Object, e As EventArgs) Handles gvNominas.DoubleClick
        CargarDatos()
    End Sub

    Private Sub gvNominas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles gvNominas.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            CargarDatos()
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            ' Validar que se haya seleccionado una nómina
            If Not Actualizando Or SecNomina = "" Then
                HDevExpre.MensagedeError("Debe seleccionar el item que desea editar o eliminar, selecciona con doble clic!")
                Exit Sub
            End If

            ' Confirmar la eliminación con el usuario
            If HDevExpre.MsgSamit(String.Format("Seguro que desea eliminar el item seleccionado [{0}]", txtNombreNomina.ValordelControl),
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.OK Then

                ' Crear el request para eliminar
                Dim request As New Newtonsoft.Json.Linq.JObject()
                request("Datos") = SecNomina

                ' Ejecutar procedimiento almacenado
                Dim resp = SMT_EjecutaProcedimientos(ObjetoApiNomina, "sp_EliminaNominas", request)
                Dim response = resp.ToObject(Of EliminarNominaResponse)()


                ' Procesar respuesta
                If response IsNot Nothing Then
                    If response.Resultado = 1 Then
                        ' Eliminación exitosa
                        LimpiarCampos()
                        LlenaGrillaNominas()
                        HDevExpre.mensajeExitoso(response.Mensaje)
                    Else
                        ' Error en la eliminación
                        HDevExpre.MensagedeError(response.Mensaje)
                    End If
                Else
                    HDevExpre.MensagedeError("Error al procesar la respuesta del servidor")
                End If

            End If

        Catch ex As Exception
            HDevExpre.MensagedeError("Error al eliminar la nómina: " & ex.Message)
        End Try
    End Sub

    Private Sub FrmAggNominas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = ChrW(Keys.Escape) Then
            Me.Close()
        End If
    End Sub

#End Region



#Region "Procedimientos y Funciones"
    Private Sub AcomodaForm()
        Try
            btnGuardar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Guardar)
            btnEliminar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Eliminar)
            btnSalir.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.SalirAtras)
            btnLimpiar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Limpiar)
            cke30dias.Checked = True

        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "AcomodaForm Agrega Nomina!")
        End Try
    End Sub
    Private Sub CreaGrilla()
        Try
            gvNominas.Columns.Clear()

            HDevExpre.CreaColumnasG(gvNominas, "SecNomina", "SecNomina", False, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 0, 0)
            HDevExpre.CreaColumnasG(gvNominas, "Oficina", "Oficina", False, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 0, 0)
            HDevExpre.CreaColumnasG(gvNominas, "NomNomina", "Nomina", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 30, gbxPrincipal.Width)
            HDevExpre.CreaColumnasG(gvNominas, "FormaLiquida", " Periodo de liquidacion", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 20, gbxPrincipal.Width)
            HDevExpre.CreaColumnasG(gvNominas, "Fecha", "Fecha", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 20, gbxPrincipal.Width)
            HDevExpre.CreaColumnasG(gvNominas, "NomOficina", "Oficina", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 30, gbxPrincipal.Width)
            gvNominas.OptionsView.ShowFooter = True
            gvNominas.Appearance.HeaderPanel.Font = New Font("Trebuchet MS", 11.0!, FontStyle.Bold)
            gvNominas.Columns(5).Summary.Add(DevExpress.Data.SummaryItemType.Count, "", "{0}  Registros")
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "Crea Grilla Nominas")
        End Try
    End Sub
    Private Sub LlenaGrillaNominas()
        Try
            Dim sql As String = "SELECT * FROM Nominas "
            dt = SMT_AbrirTabla(ObjetoApiNomina, sql)
            If dt.Rows.Count > 0 Then
                dt.Columns.Add("NomOficina", GetType(String))
                Dim dt2 As DataTable = ObjetosNomina.Oficinas
                If dt2.Rows.Count > 0 Then
                    For incre As Integer = 0 To dt2.Rows.Count - 1
                        For incre2 As Integer = 0 To dt.Rows.Count - 1
                            If CByte(dt.Rows(incre2)("Oficina")) = CByte(dt2.Rows(incre)("Codigo")) Then
                                dt.Rows(incre2)("NomOficina") = dt2.Rows(incre)("Descripcion")
                            End If
                        Next
                    Next
                End If
                gcNominas.DataSource = dt
            Else
                HDevExpre.mensajeExitoso("No se registra ninguna Nomina, podemos empezar ingresandolas!..")
                gcNominas.DataSource = Nothing
            End If

        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "LlenaGrillaNominas")
        End Try
    End Sub

    Private Sub txtNoBuscando()
        txtBusqueda.Text = "Digite cualquier parametro de Busqueda"
        txtBusqueda.Font = New Font("Trebuchet MS", 10.25F, FontStyle.Italic)
        txtBusqueda.BackColor = Color.LemonChiffon
        txtBusqueda.ForeColor = Color.Gray
        txtBusqueda.BorderStyle = BorderStyles.Simple
    End Sub
    Private Sub txtBuscando()
        txtBusqueda.Font = New Font("Trebuchet MS", 10.25F, FontStyle.Bold)
        txtBusqueda.BackColor = ColorTranslator.FromHtml("#B9FFF9")
        txtBusqueda.ForeColor = Color.DarkRed
    End Sub
    Private Sub FiltrarDatos(filtro As String)
        'Inicio de la tarea en segundo plano
        Dim SubTask As BackgroundWorker = New BackgroundWorker()
        AddHandler SubTask.DoWork, AddressOf ProcesFiltrarDatos
        AddHandler SubTask.RunWorkerCompleted, AddressOf MostrarResultadoFiltro
        SubTask.RunWorkerAsync(filtro)
        'Fin Tarea segundo plano
    End Sub
    Private Sub ProcesFiltrarDatos(sender As Object, e As DoWorkEventArgs)
        Dim dv As New DataView(dt)
        dv.RowFilter = Grilla.CrearFiltro(dt, e.Argument.ToString)
        e.Result = dv
    End Sub
    Private Sub MostrarResultadoFiltro(sender As Object, e As RunWorkerCompletedEventArgs)
        Dim dv As DataView = CType(e.Result, DataView)
        gcNominas.DataSource = dv
    End Sub

    Private Sub LimpiarCampos()
        SecNomina = ""
        Actualizando = False
        txtNombreNomina.ValordelControl = ""
        cke10dias.Checked = False
        cke15dias.Checked = False
        cke30dias.Checked = False
        secReg = 0
        dteFecha.Text = ""
        txtOficina.ValordelControl = ""
        Buscando = False
        txtNoBuscando()
        gcNominas.DataSource = dt
        txtNombreNomina.Focus()
    End Sub
    Private Function GuardaDatos(Sec As Integer, Sec_Nomina As String, NomNomina As String, FormaLiquida As String, Fecha As String, Oficina As String, EstaActualizando As Boolean) As Boolean
        Try
            Nomina = New Nominas
            Nomina.NomNomina = txtNombreNomina.ValordelControl
            Nomina.Sec = Sec
            Nomina.Oficina = txtOficina.ValordelControl
            Nomina.Fecha = dteFecha.Text
            Dim RegNomina As New ServiceNominas
            Dim registro As JArray
            If RegNomina.ValidarCampos(Nomina) Then
                registro = RegNomina.UpsertNomina(Nomina)
            End If
            If registro.Count > 0 Then
                Return True
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "Guardando Nominas")
            Return False
        End Try
    End Function
    Private Function GuardaConceptosNomina(SecConceptos As String, SecNomina As String, ConfiguraProvisiones As Boolean) As Boolean
        Dim GenSql As New SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL
        Dim SecConfig As String = ""
        If Not ConfiguraProvisiones Then
            GenSql.PasoConexionTabla(ObjetoApiNomina, "ConfigConceptos")
            SecConfig = SMT_AbrirTabla(ObjetoApiNomina, "SELECT ISNULL( MAX (Sec),0)+1 AS Codigo FROM  ConfigConceptos").Rows(0)(0).ToString
        Else
            GenSql.PasoConexionTabla(ObjetoApiNomina, "ConfigProvisiones")
            SecConfig = SMT_AbrirTabla(ObjetoApiNomina, "SELECT ISNULL( MAX (Sec),0)+1 AS Codigo FROM  ConfigProvisiones").Rows(0)(0).ToString
        End If
        GenSql.PasoValores("Nomina", SecNomina, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
        GenSql.PasoValores("Concepto", SecConceptos, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
        GenSql.PasoValores("Sec", SecConfig, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
        If GenSql.EjecutarComandoNET(SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.SQLGenera.Insercion, "") Then
            Return True
        Else : Return False
        End If
    End Function
    Private Sub CargarDatos()
        Try
            SecNomina = gvNominas.GetFocusedRowCellValue("Sec").ToString
            secReg = CInt(SecNomina)
            txtNombreNomina.ValordelControl = gvNominas.GetFocusedRowCellValue("NomNomina").ToString
            If gvNominas.GetFocusedRowCellValue("FormaLiquida").ToString = "10" Then
                cke10dias.Checked = True
                cke15dias.Checked = False
                cke30dias.Checked = False
            ElseIf gvNominas.GetFocusedRowCellValue("FormaLiquida").ToString = "15" Then
                cke10dias.Checked = False
                cke15dias.Checked = True
                cke30dias.Checked = False
            ElseIf gvNominas.GetFocusedRowCellValue("FormaLiquida").ToString = "30" Then
                cke30dias.Checked = True
                cke15dias.Checked = False
                cke10dias.Checked = False
            End If
            dteFecha.Text = gvNominas.GetFocusedRowCellValue("Fecha").ToString
            txtOficina.ValordelControl = gvNominas.GetFocusedRowCellValue("Oficina").ToString
            Actualizando = True
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "Cargar datos Nominas")
        End Try
    End Sub
    Private Sub EliminaNominas()
        If Not Actualizando Or secReg = 0 Then
            HDevExpre.MensagedeError("No ha cargado ninguna entidad para ser eliminada.")
            Exit Sub
        End If
        If HDevExpre.MsgSamit(String.Format("Seguro que desea eliminar el item seleccionado [{0}]", txtNombreNomina.ValordelControl), MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.OK Then
            Nomina = New Nominas
            Nomina.Sec = secReg

            Dim RegNomina As New ServiceNominas
            Dim registro As JArray
            registro = RegNomina.EliminarNomina(Nomina)
            LimpiarCampos()
            LlenaGrillaNominas()
        Else
            HDevExpre.MensagedeError("Error al eiminar la nomina!")
        End If

    End Sub
#End Region


    Private Sub FrmAggTipoContrato_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Buscando = False
        txtNoBuscando()
        LimpiarCampos()
    End Sub

    Private Sub cke10dias_CheckedChanged(sender As Object, e As EventArgs) Handles cke10dias.CheckedChanged
        If cke10dias.Checked Then
            cke15dias.Checked = False
            cke30dias.Checked = False
        ElseIf cke10dias.Checked = False And cke15dias.Checked = False And cke30dias.Checked = False Then
            cke10dias.Checked = True
        End If
    End Sub

    Private Sub cke15dias_CheckedChanged(sender As Object, e As EventArgs) Handles cke15dias.CheckedChanged
        If cke15dias.Checked Then
            cke10dias.Checked = False
            cke30dias.Checked = False
        ElseIf cke10dias.Checked = False And cke15dias.Checked = False And cke30dias.Checked = False Then
            cke15dias.Checked = True
        End If
    End Sub

    Private Sub cke30dias_CheckedChanged(sender As Object, e As EventArgs) Handles cke30dias.CheckedChanged
        If cke30dias.Checked Then
            cke15dias.Checked = False
            cke10dias.Checked = False
        ElseIf cke10dias.Checked = False And cke15dias.Checked = False And cke30dias.Checked = False Then
            cke30dias.Checked = True
        End If
    End Sub

    Private Sub cke10dias_Enter(sender As Object, e As EventArgs) Handles cke10dias.Enter, cke15dias.Enter, cke30dias.Enter
        Try
            Dim ck As DevExpress.XtraEditors.CheckEdit = CType(sender, DevExpress.XtraEditors.CheckEdit)
            ck.Font = New Font(ck.Font.FontFamily, ck.Font.Size, FontStyle.Bold)
            ck.BorderStyle = BorderStyles.HotFlat
            ck.BackColor = Datos.ColordeFondoTxtFoco
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cke10dias_Leave(sender As Object, e As EventArgs) Handles cke10dias.Leave, cke15dias.Leave, cke30dias.Leave
        Try
            Dim ck As DevExpress.XtraEditors.CheckEdit = CType(sender, DevExpress.XtraEditors.CheckEdit)
            ck.Font = New Font(ck.Font.FontFamily, ck.Font.Size, FontStyle.Regular)
            ck.BorderStyle = BorderStyles.Default
            ck.BackColor = Color.Transparent
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dteFecha_Enter(sender As Object, e As EventArgs) Handles dteFecha.Enter
        HDevExpre.EntraControlDateEditDEV(dteFecha, lblFecha)
        FrmPrincipal.MensajeDeAyuda.Caption = "Seleccione la fecha de cración de nómina. (ENTER,TAB)=Avanzar"
    End Sub

    Private Sub dteFecha_Leave(sender As Object, e As EventArgs) Handles dteFecha.Leave
        HDevExpre.SaleControlDateEditDEV(dteFecha, lblFecha)
        FrmPrincipal.MensajeDeAyuda.Caption = ""
    End Sub

    Private Sub cke10dias_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cke30dias.KeyPress, cke15dias.KeyPress, cke10dias.KeyPress, dteFecha.KeyPress
        HDevExpre.AvanzaConEnter(e)
    End Sub

    Private Sub btnSalir_KeyPress(sender As Object, e As KeyPressEventArgs) Handles btnSalir.KeyPress, btnLimpiar.KeyPress, btnGuardar.KeyPress, btnEliminar.KeyPress
        HDevExpre.AtrasConScape(e)
    End Sub

    Private Sub txtNominas_Leave(sender As Object, e As EventArgs) Handles txtNominas.Leave
        If txtNominas.ValordelControl = "" Then Exit Sub

        Try
            ' Crear el request para copiar la nómina
            Dim request As New Newtonsoft.Json.Linq.JObject()
            request("NomNomina") = txtNombreNomina.ValordelControl
            request("NominaPlantilla") = CInt(txtNominas.ValordelControl)
            request("Usuario") = ObjetosNomina.Datos.Smt_Usuario
            request("Terminal") = ObjetosNomina.Datos.Smt_NombreTerminal

            ' Ejecutar procedimiento almacenado
            Dim resp = SMT_EjecutaProcedimientos(ObjetoApiNomina, "SP_CopiarNominaDesdeNomina", request)
            Dim response = resp.ToObject(Of UpsertNominaResponse)()

            ' Procesar respuesta
            If response.EsExitoso Then
                ' Actualizar SecNomina con el valor devuelto
                SecNomina = response.Nomina.Sec

                ' Mostrar mensaje de éxito
                Dim mensaje = "Nómina copiada exitosamente!"

                'If response.Nomina.ConceptosNuevos > 0 OrElse response.Nomina.ProvisionesNuevas > 0 Then
                '    mensaje &= vbCrLf & vbCrLf
                '    mensaje &= $"• Se copiaron {response.Nomina.ConceptosNuevos} conceptos" & vbCrLf
                '    mensaje &= $"• Se copiaron {response.Nomina.ProvisionesNuevas} provisiones"
                'End If

                HDevExpre.mensajeExitoso(mensaje)

                ' Refrescar UI
                LlenaGrillaNominas()
                LimpiarCampos()
                txtNominas.ValordelControl = ""
            Else
                ' Mostrar error
                HDevExpre.MensagedeError($"Error al copiar la nómina: {response.Mensaje}")
            End If

        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "txtNominas_Leave/Nominas")
        End Try
    End Sub

    Private Sub btnCargarNomina_Click(sender As Object, e As EventArgs) Handles btnCargarNomina.Click
        If SecNomina <> "" Then
            HDevExpre.MensagedeError("No debe estar seleccionada ninguna nomina existente para continuar!")
            Exit Sub
        End If
        If Not IsNothing(txtNombreNomina.ValordelControl) Then
            If String.IsNullOrEmpty(txtNombreNomina.ValordelControl.Trim()) Then
                HDevExpre.MensagedeError("El campo Nombre no puede estar vacío!..")
                txtNombreNomina.Focus()
                Exit Sub
            End If
        End If

            txtNominas.Visible = True

        txtNominas.Focus()
        SendKeys.SendWait("{RIGHT}")

        txtNominas.Visible = False

    End Sub
End Class