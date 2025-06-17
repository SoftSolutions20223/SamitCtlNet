Imports Newtonsoft.Json.Linq
Imports SamitCtlNet
Imports SamitNominaLogic

Public Class FrmGenPeriodosLiquidacion

    Public Datos As New SamitCtlNet.SamitCtlNet
    Dim FormularioAbierto As Boolean = False
    Dim dtPeriodos As DataTable = New DataTable
    Dim Nomi As String = ""
    Dim HDevExpre As New HelperDevExpress
    Dim HNomina As New HelperNomina
    Dim PeriodoLiquidacion As New SemestresLiquidacion
    Public Property P_FormularioAbierto() As Boolean
        Get
            Return FormularioAbierto
        End Get
        Set(value As Boolean)
            FormularioAbierto = value
        End Set
    End Property

    Private Sub FrmGenPeriodosLiquidacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CreaGrilla()
        txtNomina.ConsultaSQL = String.Format("SELECT Sec AS Codigo,NomNomina As Descripcion FROM  Nominas")
        ArmarTabla()
        AcomodaForm()
        dteFechaDesde.Properties.EditFormat.FormatString = "dd/MMM/yyyy"
        dteFechaDesde.EditValue = Datos.Smt_FechaDeTrabajo
        txtNomina.Focus()
        txtNomina.Select()
        txtNomina.MensajedeAyuda = "Seleccione la nómina a la cual desea generar los periodos de liquidación. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras, (F5,DER)=Buscar)"
    End Sub
    Private Sub AcomodaForm()
        Try
            btnGuardar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Guardar)
            btnLimpiar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Limpiar)
            btnSalir.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.SalirAtras)
            btnGenerar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.GenerarPeriodos)
            dteFechaDesde.Text = Datos.Smt_FechaDelServidor.ToString()

        Catch ex As Exception
        End Try
    End Sub
    Private Sub ArmarTabla()
        Try
            dtPeriodos.Columns.Add("CodPeriodo", GetType(Integer))
            dtPeriodos.Columns.Add("PeriodoMes", GetType(Integer))
            dtPeriodos.Columns.Add("NumPeriodoNom", GetType(Integer))
            dtPeriodos.Columns.Add("NumMes", GetType(Integer))
            dtPeriodos.Columns.Add("Semestre", GetType(Integer))
            dtPeriodos.Columns.Add("Descripcion", GetType(String))
            dtPeriodos.Columns.Add("FechaInicio", GetType(DateTime))
            dtPeriodos.Columns.Add("FechaFin", GetType(DateTime))
            dtPeriodos.Columns.Add("Estado", GetType(Char))
            dtPeriodos.Columns.Add("Nomina", GetType(Integer))
            dtPeriodos.Columns.Add("Año", GetType(UShort))
        Catch ex As Exception
        End Try
    End Sub
    Private Sub CreaGrilla()
        Try
            gvPeriodos.Columns.Clear()
            HDevExpre.CreaColumnasG(gvPeriodos, "Sec", "Sec", False, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 0, 0)
            HDevExpre.CreaColumnasG(gvPeriodos, "PeriodoMes", "PeriodoMes", False, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 0, 0)

            HDevExpre.CreaColumnasG(gvPeriodos, "NumPeriodoNom", "NumPeriodoNom", False, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 0, 0)
            HDevExpre.CreaColumnasG(gvPeriodos, "NumMes", "NumMes", False, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 0, 0)
            HDevExpre.CreaColumnasG(gvPeriodos, "CodPeriodo", "CodPeriodo", False, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 0, 0)
            HDevExpre.CreaColumnasG(gvPeriodos, "Nomina", "Nomina", False, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 0, 0)
            HDevExpre.CreaColumnasG(gvPeriodos, "Descripcion", "Descripcion", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 30, gbxPrincipal.Width)
            HDevExpre.CreaColumnasG(gvPeriodos, "Semestre", "Semestre", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 20, gbxPrincipal.Width)
            HDevExpre.CreaColumnasG(gvPeriodos, "FechaInicio", "Fecha Inicio", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 15, gbxPrincipal.Width)
            HDevExpre.CreaColumnasG(gvPeriodos, "FechaFin", "Fecha Fin", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 15, gbxPrincipal.Width)
            HDevExpre.CreaColumnasG(gvPeriodos, "Estado", "Estado", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 10, gbxPrincipal.Width)
            HDevExpre.CreaColumnasG(gvPeriodos, "Año", "Año", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 10, gbxPrincipal.Width)

            gvPeriodos.OptionsView.ShowFooter = True
            gvPeriodos.Appearance.HeaderPanel.Font = New Font("Trebuchet MS", 11.0!, FontStyle.Bold)
            gvPeriodos.Columns(6).Summary.Add(DevExpress.Data.SummaryItemType.Count, "", "{0}")
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "Crea Grilla NominasLiquida")
        End Try
    End Sub
    Dim dtDatosNomina As New DataTable
    Private Sub txtNomina_SaleControl(sender As Object, e As EventArgs) Handles txtNomina.Leave
        Try
            dtPeriodos.Rows.Clear()
            gcPeriodos.DataSource = dtPeriodos
            If txtNomina.ValordelControl <> "" Then
                Dim dt As DataTable = SMT_AbrirTabla(ObjetoApiNomina, "SELECT * FROM Nominas WHERE Sec=" + txtNomina.ValordelControl)
                If dt.Rows.Count > 0 Then
                    dtDatosNomina = dt
                End If
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "txtNomina_SaleControl")
        End Try
    End Sub


    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        Try
            If Not ValidaCampos() Then Exit Sub
            If Not IsNothing(dtPeriodos) Then dtPeriodos.Rows.Clear()
            If Not ValidaPeriodoLiquidado(CInt(txtNomina.ValordelControl), CUShort(CDate(dteFechaDesde.EditValue).Year)) Then
                gcPeriodos.DataSource = dtPeriodos
                Exit Sub
            End If
            Dim diasFormaLiquida As UShort = CUShort(dtDatosNomina.Rows(0)("FormaLiquida"))
            Dim fechaInicial As DateTime = dteFechaDesde.DateTime
            Dim count As UShort = diasFormaLiquida
            Dim Descripcion As String = ""
            Dim fechaDesde As DateTime = fechaInicial
            Dim fechaHasta As DateTime = fechaInicial.AddDays(diasFormaLiquida)
            Dim PeriodoMes As Integer = 0
            Dim NumMes As Integer = 1
            Dim NumPeriodoNom As Integer = 0
            Dim diasRestantes As Long = DateDiff(DateInterval.Day, CDate(dteFechaDesde.EditValue), CDate("31/12/" & CDate(dteFechaDesde.EditValue).Year)) + 1
            While True
                If diasFormaLiquida > diasRestantes Then
                    Exit While
                End If
                If diasFormaLiquida > count Then
                    fechaDesde = fechaHasta.AddDays(1)
                    fechaHasta = fechaInicial.AddDays(diasFormaLiquida + 1)
                End If
                PeriodoMes = PeriodoMes + 1
                NumPeriodoNom = NumPeriodoNom + 1
                Descripcion = String.Format("Periodo " + NumPeriodoNom.ToString() + " ({0:dd/MM/yyyy} - {1:dd/MM/yyyy})", fechaDesde, fechaHasta)
                If CUShort(dtDatosNomina.Rows(0)("FormaLiquida")) = 10 Then
                    If PeriodoMes < 3 Then
                        If CUShort(CDate(fechaDesde).Month) < 7 Then
                            CreaPeriodo(Descripcion, fechaDesde, fechaHasta, "P"c, CInt(txtNomina.ValordelControl), CUShort(CDate(dteFechaDesde.EditValue).Year), PeriodoMes, NumPeriodoNom, NumMes, 1)
                        Else
                            CreaPeriodo(Descripcion, fechaDesde, fechaHasta, "P"c, CInt(txtNomina.ValordelControl), CUShort(CDate(dteFechaDesde.EditValue).Year), PeriodoMes, NumPeriodoNom, NumMes, 2)
                        End If

                    Else
                        If CUShort(CDate(fechaDesde).Month) < 7 Then
                            CreaPeriodo(Descripcion, fechaDesde, fechaHasta, "P"c, CInt(txtNomina.ValordelControl), CUShort(CDate(dteFechaDesde.EditValue).Year), PeriodoMes, NumPeriodoNom, NumMes, 1)
                        Else
                            CreaPeriodo(Descripcion, fechaDesde, fechaHasta, "P"c, CInt(txtNomina.ValordelControl), CUShort(CDate(dteFechaDesde.EditValue).Year), PeriodoMes, NumPeriodoNom, NumMes, 2)
                        End If
                        PeriodoMes = 0
                        NumMes = NumMes + 1
                    End If
                End If
                If CUShort(dtDatosNomina.Rows(0)("FormaLiquida")) = 15 Then
                    If PeriodoMes < 2 Then
                        If CUShort(CDate(fechaDesde).Month) < 7 Then
                            CreaPeriodo(Descripcion, fechaDesde, fechaHasta, "P"c, CInt(txtNomina.ValordelControl), CUShort(CDate(dteFechaDesde.EditValue).Year), PeriodoMes, NumPeriodoNom, NumMes, 1)
                        Else
                            CreaPeriodo(Descripcion, fechaDesde, fechaHasta, "P"c, CInt(txtNomina.ValordelControl), CUShort(CDate(dteFechaDesde.EditValue).Year), PeriodoMes, NumPeriodoNom, NumMes, 2)
                        End If

                    Else
                        If CUShort(CDate(fechaDesde).Month) < 7 Then
                            CreaPeriodo(Descripcion, fechaDesde, fechaHasta, "P"c, CInt(txtNomina.ValordelControl), CUShort(CDate(dteFechaDesde.EditValue).Year), PeriodoMes, NumPeriodoNom, NumMes, 1)
                        Else
                            CreaPeriodo(Descripcion, fechaDesde, fechaHasta, "P"c, CInt(txtNomina.ValordelControl), CUShort(CDate(dteFechaDesde.EditValue).Year), PeriodoMes, NumPeriodoNom, NumMes, 2)
                        End If

                        PeriodoMes = 0
                        NumMes = NumMes + 1
                    End If
                End If
                If CUShort(dtDatosNomina.Rows(0)("FormaLiquida")) = 30 Then
                    If CUShort(CDate(fechaDesde).Month) < 7 Then
                        CreaPeriodo(Descripcion, fechaDesde, fechaHasta, "P"c, CInt(txtNomina.ValordelControl), CUShort(CDate(dteFechaDesde.EditValue).Year), 1, NumPeriodoNom, NumMes, 1)
                    Else
                        CreaPeriodo(Descripcion, fechaDesde, fechaHasta, "P"c, CInt(txtNomina.ValordelControl), CUShort(CDate(dteFechaDesde.EditValue).Year), 1, NumPeriodoNom, NumMes, 2)
                    End If
                    NumMes = NumMes + 1
                End If
                diasFormaLiquida += count
            End While
            gcPeriodos.DataSource = dtPeriodos
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "btnGenerar_Click")
        End Try
    End Sub
    Private Function ValidaCampos() As Boolean
        Try
            If txtNomina.ValordelControl = "" Then
                HDevExpre.MensagedeError("Por favor seleccione una nómina.")
                txtNomina.Focus()
                Return False
            ElseIf dteFechaDesde.Text = "" Then
                HDevExpre.MensagedeError("El campo año no puede estar vacío!")
                dteFechaDesde.Focus()
                Return False
                'ElseIf Not IsNumeric(dteAño.Text) Then
                '   HDevExpre.MensagedeError("Debe digitar un dato numerico.")
                '    dteAño.Focus()
                '    Exit Sub
            ElseIf dtDatosNomina.Rows.Count = 0 Then
                HDevExpre.MensagedeError("No se cargaron correctamente los datos de la nómina, intentelo nuevamente!")
                txtNomina.Focus()
                Return False
            Else : Return True
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "ValidaCampos")
            Return False
        End Try
    End Function
    Private Function ValidaPeriodoLiquidado(codNomina As Integer, año As UShort) As Boolean
        Try
            Dim sql As String = String.Format("SELECT * FROM PeriodosLiquidacion WHERE Nomina={0} AND Año={1} AND Estado='L'", codNomina, año)
            Dim dt As DataTable = SMT_AbrirTabla(ObjetoApiNomina, sql)
            If dt.Rows.Count > 0 Then
                HDevExpre.MensagedeError(String.Format("Imposible generar los peridodos del año {0}, los periodos ya fueron generados y cuentan con {1} en estado 'Liquidado'.", año, dt.Rows.Count))
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "ValidaPeriodoLiquidado")
            Return False
        End Try
    End Function
    Private Sub CreaPeriodo(Descripcion As String, FechaInicio As DateTime, FechaFin As DateTime, Estado As Char, Nomina As Integer, Año As UShort, PeriodoMes As Integer, NumPeriodoNom As Integer, NumMes As Integer, Semestre As Integer)
        Try
            Dim Codigo = txtNomina.ValordelControl + Año.ToString + NumPeriodoNom.ToString
            Dim fila As DataRow = dtPeriodos.NewRow
            fila("Descripcion") = Descripcion
            fila("FechaInicio") = FechaInicio
            fila("FechaFin") = FechaFin
            fila("Estado") = Estado
            fila("Nomina") = Nomina
            fila("Año") = Año
            fila("PeriodoMes") = PeriodoMes
            fila("Semestre") = Semestre
            fila("NumPeriodoNom") = NumPeriodoNom
            fila("NumMes") = NumMes
            fila("CodPeriodo") = CInt(Codigo)
            dtPeriodos.Rows.Add(fila)
            dtPeriodos.AcceptChanges()
            Nomi = Nomina.ToString()
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "CreaPeriodo")
        End Try
    End Sub

    Private Function InsertaPeriodo(Sec As Integer, Descripcion As String, FechaInicio As DateTime, FechaFin As DateTime, Estado As Char, Nomina As Integer, Año As UShort, PeriodoMes As Integer, NumPeriodoNom As Integer, CodPeriodo As Integer, NumMes As Integer, Semestre As Integer) As Boolean
        Try
            Dim GenSql As New SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL
            'Dim dt As DataTable = SMT_AbrirTabla(ObjetoApiNomina, "SELECT ISNULL(MAX(Sec+1),1) AS Codigo FROM PeriodosLiquidacion")
            'If dt.Rows.Count = 0 Then Return False
            'Dim Sec As Integer = CInt(dt.Rows(0)(0))
            GenSql.PasoConexionTabla(ObjetoApiNomina, "PeriodosLiquidacion")
            GenSql.PasoValores("Sec", Sec.ToString, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            GenSql.PasoValores("Descripcion", Descripcion, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            GenSql.PasoValores("FechaInicio", FechaInicio.ToString("dd/MM/yyyy"), SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            GenSql.PasoValores("FechaFin", FechaFin.ToString("dd/MM/yyyy"), SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            GenSql.PasoValores("Estado", Estado.ToString, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            GenSql.PasoValores("Nomina", Nomina.ToString, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            GenSql.PasoValores("Año", Año.ToString, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            GenSql.PasoValores("PeriodoMes", PeriodoMes.ToString, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            GenSql.PasoValores("NumPeriodoNom", NumPeriodoNom.ToString, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            GenSql.PasoValores("CodPeriodo", CodPeriodo.ToString, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            GenSql.PasoValores("NumMes", NumMes.ToString, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            GenSql.PasoValores("Semestre", Semestre.ToString, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            If GenSql.EjecutarComandoNET(SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.SQLGenera.Insercion, "") Then Return True Else Return False
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub FrmGenPeriodosLiquidacion_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        txtNomina.ValordelControl = ""
        dteFechaDesde.Text = ObjetosNomina.DatosSeg.FechadelServidor.ToString
        dtPeriodos.Rows.Clear()
        dtPeriodos.Columns.Clear()
        Nomi = ""
    End Sub

    Private Sub dteAño_Enter(sender As Object, e As EventArgs) Handles dteFechaDesde.Enter
        HDevExpre.EntraControlDateEditDEV(dteFechaDesde, lblAño)
        FrmPrincipal.MensajeDeAyuda.Caption = "Digite la fecha desde cuando desea iniciar la creación de los periodos. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
    End Sub

    Private Sub dteAño_Leave(sender As Object, e As EventArgs) Handles dteFechaDesde.Leave
        HDevExpre.SaleControlDateEditDEV(dteFechaDesde, lblAño)
        FrmPrincipal.MensajeDeAyuda.Caption = ""
    End Sub

    Private Sub dteAño_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dteFechaDesde.KeyPress
        HDevExpre.AvanzaConEnter(e)
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Try
            dtPeriodos.Rows.Clear()
            txtNomina.ValordelControl = ""
            dteFechaDesde.EditValue = Datos.Smt_FechaDeTrabajo
            gcPeriodos.DataSource = dtPeriodos
            Nomi = ""
            txtNomina.Focus()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnGuardarPeriodos_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            ' Validar que hay datos
            If dtPeriodos.Rows.Count = 0 Then
                HDevExpre.MensagedeError("No hay periodos para guardar.")
                Exit Sub
            End If

            ' Obtener datos principales
            Dim nomina As Integer = CInt(dtPeriodos.Rows(0)("Nomina"))
            Dim año As Short = CShort(dtPeriodos.Rows(0)("Año"))
            Dim reemplazarExistentes As Boolean = False

            ' Verificar si ya existen periodos
            Dim sql As String = String.Format("SELECT * FROM PeriodosLiquidacion WHERE Nomina = {0} AND Año = {1}", nomina, año)
            Dim dtExistentes As DataTable = SMT_AbrirTabla(ObjetoApiNomina, sql)

            If dtExistentes.Rows.Count > 0 Then
                If HDevExpre.MsgSamit(String.Format("La nómina ya cuenta con periodos para el año {0}, ¿desea que sean reemplazados?", año),
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.Cancel Then
                    Exit Sub
                End If
                reemplazarExistentes = True
            End If

            ' Confirmar guardado
            If HDevExpre.MsgSamit("¿Seguro que desea guardar los periodos generados?",
                              MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.Cancel Then
                Exit Sub
            End If

            ' Crear el request
            Dim request As New UpsertPeriodoLiquidacionRequest With {
            .Nomina = nomina,
            .Año = año,
            .ReemplazarExistentes = reemplazarExistentes,
            .Usuario = ObjetosNomina.Datos.Smt_Usuario,
            .Terminal = ObjetosNomina.Datos.Smt_NombreTerminal
        }

            ' Agregar periodos desde el DataTable
            For Each fila As DataRow In dtPeriodos.Rows
                Dim periodo As New PeriodosLiquidacion With {
                .Sec = 0, ' Se calculará en el SP
                .Descripcion = fila("Descripcion").ToString(),
                .FechaInicio = CDate(fila("FechaInicio")),
                .FechaFin = CDate(fila("FechaFin")),
                .Estado = fila("Estado").ToString(),
                .Nomina = nomina,
                .Año = año,
                .PeriodoMes = CInt(fila("PeriodoMes")),
                .NumPeriodoNom = CInt(fila("NumPeriodoNom")),
                .CodPeriodo = CInt(fila("CodPeriodo")),
                .NumMes = CInt(fila("NumMes")),
                .Semestre = CInt(fila("Semestre"))
            }
                request.Periodos.Add(periodo)
            Next

            ' Agregar semestres
            ' Semestre 1
            Dim fechaInicioSem1 As Date = New Date(año, 1, 1)
            Dim fechaFinSem1 As Date = New Date(año, 6, 30)
            Dim estadoSem1 As String = If(CDate(dteFechaDesde.EditValue).Month < 7, "P", "L")

            request.Semestres.Add(New SemestresLiquidacion With {
            .Sec = 0,
            .Semestre = 1,
            .Año = año,
            .FechaInicio = fechaInicioSem1,
            .FechaFin = fechaFinSem1,
            .Estado = estadoSem1,
            .Nomina = nomina
        })

            ' Semestre 2
            Dim fechaInicioSem2 As Date = New Date(año, 7, 1)
            Dim fechaFinSem2 As Date = New Date(año, 12, 31)

            request.Semestres.Add(New SemestresLiquidacion With {
            .Sec = 0,
            .Semestre = 2,
            .Año = año,
            .FechaInicio = fechaInicioSem2,
            .FechaFin = fechaFinSem2,
            .Estado = "P",
            .Nomina = nomina
        })

            Dim json = request.ToJObject().ToString()
            json = json.Replace("Año", "Anio")
            Dim jObject As JObject = JObject.Parse(json)

            ' Ejecutar procedimiento almacenado
            Dim resp = SMT_EjecutaProcedimientos(ObjetoApiNomina, "SP_UpsertPeriodoLiquidacion", jObject)
            Dim response = resp.ToObject(Of UpsertPeriodoLiquidacionResponse)()

            ' Procesar respuesta
            If response.EsExitoso Then
                ' Mensaje de éxito
                Dim mensaje As String = response.Mensaje
                If response.TotalPeriodos > 0 Then
                    mensaje &= $" Se guardaron {response.TotalPeriodos} periodos"
                    If response.TotalSemestres > 0 Then
                        mensaje &= $" y {response.TotalSemestres} semestres"
                    End If
                    mensaje &= " exitosamente."
                End If

                HDevExpre.mensajeExitoso(mensaje)

                ' Refrescar la interfaz (ajustar según tu implementación)
                ' Por ejemplo:
                ' LimpiarCampos()
                ' CargarPeriodosExistentes()

            Else
                ' Mostrar error
                HDevExpre.MensagedeError($"Error al guardar los periodos: {response.Mensaje}")

                ' Log adicional si hay código de error
                If response.CodigoError.HasValue Then
                    Console.WriteLine($"Código de error SQL: {response.CodigoError.Value}")
                End If
            End If

        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "btnGuardarPeriodos_Click")
        End Try
    End Sub

    Private Function InsertaSemestre(Nomina As String, Año As String, Semestre As String, Estado As String, Existe As Boolean, FechaInicio As String, FechaFin As String) As Boolean
        Try
            Dim GenSql As New SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL
            GenSql.PasoConexionTabla(ObjetoApiNomina, "SemestresLiquidacion")
            GenSql.PasoValores("Año", Año.ToString, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            GenSql.PasoValores("Semestre", Semestre, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            GenSql.PasoValores("Estado", Estado, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            GenSql.PasoValores("FechaInicio", FechaInicio, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            GenSql.PasoValores("FechaFin", FechaFin, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            GenSql.PasoValores("Nomina", Nomina, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            If Existe Then
                If GenSql.EjecutarComandoNET(SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.SQLGenera.Actualizacion, String.Format("Año={0} And Semestre={1}", Año, Semestre)) Then
                    Return True
                Else : Return False
                End If
            Else
                Dim Sec = SMT_AbrirTabla(ObjetoApiNomina, "SELECT ISNULL( MAX (Sec),0)+1 AS Codigo FROM SemestresLiquidacion").Rows(0)(0).ToString
                GenSql.PasoValores("Sec", Sec, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
                If GenSql.EjecutarComandoNET(SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.SQLGenera.Insercion, "") Then Return True Else Return False
            End If

        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub btnSalir_KeyPress(sender As Object, e As KeyPressEventArgs) Handles btnSalir.KeyPress, btnLimpiar.KeyPress, btnGuardar.KeyPress, btnGenerar.KeyPress
        HDevExpre.AtrasConScape(e)
    End Sub
End Class