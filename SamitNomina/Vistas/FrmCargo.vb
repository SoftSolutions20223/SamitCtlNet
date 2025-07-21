Option Strict Off
Imports SamitCtlNet
Imports System.ComponentModel
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Columns
Imports System.Transactions
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid
Imports DevExpress.XtraEditors
Imports System.Data.SqlClient
Imports SamitNominaLogic

Public Class FrmCargo
    'Private Const INT_Constant As Integer = 1

    Dim clCargo As New ServiceCargos
    Dim Buscando As Boolean = False
    Dim dtos As DataTable
    'Dim gcAsignacionesG As GridControl
    'Dim dteAsignacionesG As DateEdit
    'Dim gvAsignacionesG As GridView
    'Variables para validar actualizaciones
    Dim ActualizandoDatosBasicos As Boolean = False
    Dim ActualizandoAsignaciones As Boolean = False
    'Fin variables para validar actualizaciones

    'Propiedades

    Dim FormularioAbierto As Boolean = False
    Dim HDevExpre As New HelperDevExpress
    Dim HNomina As New HelperNomina
    Public Property P_FormularioAbierto() As Boolean
        Get
            Return FormularioAbierto
        End Get
        Set(value As Boolean)
            FormularioAbierto = value
        End Set
    End Property

    Dim VSecCargo As String
    Public Property Sec_Cargo() As String
        Get
            Return VSecCargo
        End Get
        Set(value As String)
            VSecCargo = value
        End Set
    End Property

    Dim VCodCargo As String
    Public Property Cod_Cargo() As String
        Get
            Return VCodCargo
        End Get
        Set(value As String)
            VCodCargo = value
        End Set
    End Property

    Dim VFecha_A As String
    Public Property Fecha_A() As String
        Get
            Return VFecha_A
        End Get
        Set(value As String)
            VFecha_A = value
        End Set
    End Property
    'Fin Propiedades


    Private Sub AcomodaForm()
        Try
            btnGuardar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Guardar)
            btnLimpiar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Limpiar)
            btnEliminar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.EliminarGris)
            btnSalir.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.SalirCuadroConX)
            btnAggFunciones.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.NuevoRegistro)
            btnAggAsignacion.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.AgregarItem)
            btnAggFunc.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.AgregarItem)
            EliminarAsig.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.EliminarItem)
            EliminarFun.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.EliminarItem)

            btnAggFunciones.SuperTip = HDevExpre.SMT_AsignaSupertToolTip("Crear una nueva función.")
            btnAggAsignacion.SuperTip = HDevExpre.SMT_AsignaSupertToolTip("Agregar la asignación al cargo.")
            btnAggFunc.SuperTip = HDevExpre.SMT_AsignaSupertToolTip("Agrear la función al cargo.")
            EliminarAsig.SuperTip = HDevExpre.SMT_AsignaSupertToolTip("Eliminar asignación del cargo.")
            EliminarFun.SuperTip = HDevExpre.SMT_AsignaSupertToolTip("Eliminar la función del cargo.")
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, " AcomodaForm Cargo")
        End Try
    End Sub

    Private Sub AsignaMsgAcontroles()
        Try
            txtCodCargoC.MensajedeAyuda = "Codigo del cargo. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
            txtDenominacion.MensajedeAyuda = "Digite la denominación del cargo que desea registrar o actualizar. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
            txtFunciones.MensajedeAyuda = "Seleccione la función que desea agregar al cargo. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras, (F5,DER)=Buscar"
            txtAsignaciones.MensajedeAyuda = "Digite la asignación salarial que desea agregar al cargo. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "AsignaMsgAcontroles")
        End Try
    End Sub

    Private Sub FrmCargo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            AcomodaForm()
            Sec_Cargo = "0"
            LlenaGrillaFuncionesCargo(Cod_Cargo)
            LlenaGrillaAsignacionesCargo(Sec_Cargo)
            txtNoBuscando()
            AsignaScriptAcontroles()
            txtCodCargoC.Select()
            AsignaMsgAcontroles()
            txtCodCargoC.MaximoAncho = AnchoCampoSql(ObjetoApiNomina, "Cargos", "CodCargo")
            txtDenominacion.MaximoAncho = AnchoCampoSql(ObjetoApiNomina, "Cargos", "Denominacion")
            txtDescripCargo.Properties.MaxLength = AnchoCampoSql(ObjetoApiNomina, "Cargos", "Descripcion")

        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, " Load Cargos")
        End Try
    End Sub



#Region "EfectosControles"
    'CONTROLES DATOS BASICOS

    Private Sub txtCodCargoC_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodCargoC.KeyDown
        HDevExpre.AvanzarAtrasControl(e)
    End Sub
    Private Sub TlpCargos_SizeChanged(sender As Object, e As EventArgs) Handles TlpCargos.SizeChanged
        CreaGrillaCargos()
        CreaGrillaFuncionesCargo()
        CreaGrillAsignacionesCargo()
        If gvCargos.RowCount = 0 Then
            LlenaGrillaCargos()
        End If
    End Sub

    Private Sub txtDescripCargo_Enter(sender As Object, e As EventArgs) Handles txtDescripCargo.Enter
        HDevExpre.EntraControlDev(, lblDescripCargo, txtDescripCargo)
        FrmPrincipal.MensajeDeAyuda.Caption = "Descripción del cargo a registrar o actualizar. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
    End Sub

    Private Sub txtDescripCargo_Leave(sender As Object, e As EventArgs) Handles txtDescripCargo.Leave
        HDevExpre.SaleControlDev(, lblDescripCargo, txtDescripCargo)
    End Sub
    Private Sub txtDescripCargo_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Down) Then
            btnGuardar.Focus()
        End If
    End Sub


    'FIN CONTROLES BASICOS

    'CONTROLES FUNCIONES DEL CARGO
    'FIN CONTROLES FUNCIONES DEL CARGO

    'INICIA CONTROLES ASIGNACIONES DEL CARGO
    Private Sub txtAsignaciones_Enter(sender As Object, e As EventArgs) Handles txtAsignaciones.Enter
        FrmPrincipal.MensajeDeAyuda.Caption = "Digite la asignación salarial que tendra el cargo por una determinada fecha. (ENTER,ABJ)=Avanzar;"
    End Sub
    'FIN CONTROLES ASIGNACIONES DEL CARGO
#End Region


#Region "Botones Principales"
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            ' 1) Primero guardar datos básicos (esto debe validar internamente)
            If Not ValidaCamposDatosBasicos() Then
                Exit Sub
            End If

            ' 2) Obtener los datos del cargo que se acaba de guardar/actualizar
            Dim isUpdate = (Sec_Cargo > 0)

            ' Crear el cargo principal usando la clase cargos existente
            Dim cargo As New Cargos With {
            .Sec = Sec_Cargo,
            .CodCargo = txtCodCargoC.ValordelControl,
            .Denominacion = txtDenominacion.ValordelControl,
            .Descripcion = txtDescripCargo.Text
        }

            ' Crear el request principal
            Dim request As New UpsertCargoRequest With {
            .Cargo = cargo,
            .Usuario = ObjetosNomina.Datos.Smt_Usuario,
            .Terminal = ObjetosNomina.Datos.Smt_NombreTerminal
        }

            ' 3) Agregar funciones del cargo
            Dim dtFunciones As DataTable = DirectCast(gcFunciones.DataSource, DataTable)
            If dtFunciones IsNot Nothing AndAlso dtFunciones.Rows.Count > 0 Then
                For i As Integer = 0 To dtFunciones.Rows.Count - 1
                    Dim funcion As New CargoFuncionDto With {
                    .CodFuncion = CInt(dtFunciones.Rows(i)("CodFuncion").ToString())
                }
                    request.Funciones.Add(funcion)
                Next
            End If

            ' 4) Agregar asignaciones del cargo
            Dim dtAsignaciones As DataTable = DirectCast(gcAsignaciones.DataSource, DataTable)
            If dtAsignaciones IsNot Nothing AndAlso dtAsignaciones.Rows.Count > 0 Then
                For i As Integer = 0 To dtAsignaciones.Rows.Count - 1
                    Dim asignacion As New CargoAsignacionDto With {
                    .Fecha = CDate(dtAsignaciones.Rows(i)("Fecha")),
                    .Asignacion = CDec(dtAsignaciones.Rows(i)("Asignacion"))
                }
                    request.Asignaciones.Add(asignacion)
                Next
            End If

            ' 5) Ejecutar procedimiento almacenado
            ActualizandoDatosBasicos = True

            Dim resp = SMT_EjecutaProcedimientos(ObjetoApiNomina, "SP_UpsertCargo", request.ToJObject())

            Dim response = resp.ToObject(Of UpsertCargoResponse)()

            ' 6) Procesar respuesta
            If response.EsExitoso Then
                ActualizandoDatosBasicos = False

                ' Mostrar mensaje de éxito con información adicional
                Dim mensaje = "Datos guardados exitosamente!.."
                If response.Cargo?.ContratosAfectados > 0 Then
                    mensaje &= $" Se actualizaron {response.Cargo.ContratosAfectados} contratos con la nueva asignación."
                End If

                HDevExpre.mensajeExitoso(mensaje)

                ' Refrescar UI (siguiendo el patrón original)
                LimpiarTodosCampos()
                LlenaGrillaCargos()
                LlenaGrillaAsignacionesCargo(Sec_Cargo)
                LlenaGrillaFuncionesCargo(Me.Cod_Cargo)

            Else
                ActualizandoDatosBasicos = False

                ' Mostrar error
                HDevExpre.MensagedeError($"Error al guardar el cargo: {response.Mensaje}")

                ' Log adicional si hay código de error
                If response.CodigoError.HasValue Then
                    Console.WriteLine($"Código de error SQL: {response.CodigoError.Value}")
                End If
            End If

        Catch ex As Exception
            ActualizandoDatosBasicos = False
            HDevExpre.msgError(ex, ex.Message, "btnGuardar_Click/Cargos")
        End Try
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarTodosCampos()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If ActualizandoDatosBasicos Then
                If HDevExpre.MsgSamit("Seguro que desea eliminar este cargo con todas sus funciones y asignaciones?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.OK Then
                    ' Crear el request usando EliminarCargoRequest
                    Dim request As New EliminarCargoRequest(CInt(Sec_Cargo))

                    ' Ejecutar el procedimiento almacenado
                    Dim resp = SMT_EjecutaProcedimientos(ObjetoApiNomina, "SP_EliminarCargo", request.ToJObject())
                    Dim response = resp.ToObject(Of DynamicDeleteResponse)()

                    ' Procesar respuesta
                    If response.EsExitoso Then
                        ' Éxito - limpiar y recargar
                        LimpiarTodosCampos()
                        LlenaGrillaCargos()
                        LlenaGrillaAsignacionesCargo(Sec_Cargo)
                        LlenaGrillaFuncionesCargo(Me.Cod_Cargo)
                        HDevExpre.mensajeExitoso("Datos eliminados exitosamente!..")

                    ElseIf response.EsAdvertencia Then
                        ' Advertencia (no existe o no seleccionado)
                        MensajedeError(response.Mensaje)

                    Else ' Es Error
                        ' Error (asociado a contratos u otro problema)
                        MensajedeError(response.Mensaje)
                    End If
                End If
            Else
                MensajedeError("Seleccione el Cargo a eliminar")
            End If

        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "btnEliminar_Click")
        End Try
    End Sub
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
#End Region

#Region "Funciones y Procedimientos --> Datos Básicos"
    Public Function ValidaCamposDatosBasicos() As Boolean
        Dim res As Boolean = False
        If txtCodCargoC.ValordelControl = "" Then
            HDevExpre.MensagedeError("El campo Codigo del cargo no puede estar vacío!..")
            txtCodCargoC.Focus()
            res = False
        ElseIf Not ActualizandoDatosBasicos And ExisteDato("cargos", String.Format("CodCargo='{0}'", txtCodCargoC.ValordelControl), ObjetoApiNomina) Then
            HDevExpre.MensagedeError(String.Format("El sistema registra un cargo con el codigo {0}, no se puede ingresar un codigo repetido!", txtCodCargoC.Text))
            txtCodCargoC.Focus()
            res = False
        ElseIf txtDenominacion.ValordelControl = "" Then
            HDevExpre.MensagedeError("El campo denominación no puede estar vacío!..")
            txtDenominacion.Focus()
            res = False
        ElseIf txtDescripCargo.Text = "" Then
            HDevExpre.MensagedeError("El campo descripción no puede estar vacío!..")
            txtDescripCargo.Focus()
            res = False
        Else
            res = True
        End If
        Return res
    End Function
    Public Sub LimpiarTodosCampos()
        'Limpia todos los campos de texto
        txtCodCargoC.ValordelControl = ""
        txtDenominacion.ValordelControl = ""
        txtDescripCargo.Text = ""
        dteFecha.Text = ""
        txtFunciones.ValordelControl = ""
        txtAsignaciones.ValordelControl = ""
        txtBusqueda.Text = ""
        txtNoBuscando()
        'Limpia variables para validar acutalizaciones
        ActualizandoDatosBasicos = False
        ActualizandoAsignaciones = False
        'Limpia propiedades
        Sec_Cargo = "0"
        Cod_Cargo = ""
        Fecha_A = ""
        'Limpia lkes
        'Limpia todas las grillas
        gcAsignaciones.DataSource = Nothing
        gcFunciones.DataSource = Nothing
        LlenaGrillaFuncionesCargo(Cod_Cargo)
        LlenaGrillaAsignacionesCargo(Sec_Cargo)
        txtCodCargoC.Focus()
    End Sub
    Private Sub CargarDatos(Cargo As String)
        Try
            Dim sql As String = String.Format("SELECT * FROM cargos WHERE CodCargo='{0}'", Cargo)
            Dim dt As DataTable = SMT_AbrirTabla(ObjetoApiNomina, sql)

            Dim Fila As DataRow = dt.Rows(0)

            txtCodCargoC.ValordelControl = Fila("CodCargo").ToString
            Sec_Cargo = Fila("Sec").ToString
            Cod_Cargo = Fila("CodCargo").ToString
            txtDenominacion.ValordelControl = Fila("Denominacion").ToString
            txtDescripCargo.Text = Fila("Descripcion").ToString

            LlenaGrillaFuncionesCargo(Fila("CodCargo").ToString)
            LlenaGrillaAsignacionesCargo(Fila("Sec").ToString)
            ActualizandoDatosBasicos = True
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "  CargarDatosCargos")
        End Try
    End Sub

    Private Sub LlenaGrillaCargos()
        Try
            Dim sql As String = "SELECT CodCargo,Descripcion,Denominacion,Sec FROM cargos"
            Dim dt As DataTable = SMT_AbrirTabla(ObjetoApiNomina, sql)
            Dim CopyDt As New DataTable
            CopyDt = SMT_AbrirTabla(ObjetoApiNomina, sql)
            gcCargos.DataSource = CopyDt
            dtos = CopyDt
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "LlenaGrillaCargos")
        End Try
    End Sub

    Private Sub gvCargos_DoubleClick(sender As Object, e As EventArgs) Handles gvCargos.DoubleClick
        CargarDatos(gvCargos.GetFocusedRowCellValue("CodCargo").ToString)
    End Sub

    Private Sub gvCargos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles gvCargos.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            CargarDatos(gvCargos.GetFocusedRowCellValue("CodCargo").ToString)
        End If
    End Sub

    Private Sub CreaColumnas(Grid As GridView, Nombre As String, Titulo As String, Visible As Boolean, Porcentaje_Width As Single, TamañoPadre As Single, Editar As Boolean)
        Dim gc As New GridColumn
        With gc
            .FieldName = Nombre
            .Name = Nombre
            .Caption = Titulo
            .UnboundType = DevExpress.Data.UnboundColumnType.String
            .OptionsColumn.AllowSize = True
            .OptionsColumn.AllowMove = True
            .OptionsColumn.AllowEdit = Editar
            .OptionsColumn.AllowFocus = True
            .OptionsFilter.AllowFilter = False
            .Visible = Visible
            .Width = (Porcentaje_Width * (TamañoPadre - 20)) / 100
            .AppearanceHeader.Options.UseTextOptions = True
            .AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        End With
        Grid.OptionsSelection.EnableAppearanceFocusedCell = False
        Grid.OptionsSelection.EnableAppearanceFocusedRow = True
        Grid.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
        Grid.Appearance.FocusedRow.Font = New Font("Tahoma", Grid.Appearance.Row.Font.Size, System.Drawing.FontStyle.Bold)
        Grid.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Grid.Columns.Add(gc)

    End Sub
    Private Sub CreaGrillaCargos()
        gvCargos.Columns.Clear()
        HDevExpre.CreaColumnasG(gvCargos, "CodCargo", "Codigo", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 10, gbxCargo.Width)
        HDevExpre.CreaColumnasG(gvCargos, "Denominacion", "Denominación", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 30, gbxCargo.Width)
        HDevExpre.CreaColumnasG(gvCargos, "Descripcion", "Descripción", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 60, gbxCargo.Width)
        gvCargos.Appearance.HeaderPanel.Font = New Font("Trebuchet MS", 11.0!, FontStyle.Bold)
        Dim classResize As New ClaseResize

    End Sub

    Private Function GuardaDatosBasicos() As Boolean


        Try
            ' Mapea controles al modelo Cargos
            Dim cargo As New Cargos With {
            .Sec = If(ActualizandoDatosBasicos, Me.Sec_Cargo, 0),
            .CodCargo = txtCodCargoC.ValordelControl,
            .Denominacion = txtDenominacion.ValordelControl,
            .Descripcion = txtDescripCargo.Text
        }

            ' Llama al service
            Dim resp = New ServiceCargos().UpsertCargo(cargo)
            Return (resp IsNot Nothing AndAlso resp.Count > 0)

        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "GuardaDatosBasicos")
            Return False
        End Try
    End Function

    Private Function GuardaFunciones(SecCargo As String, detalleF As String) As Boolean
        Try
            ' Mapea controles al modelo Cargo_Funciones
            Dim func As New Cargo_Funciones With {
            .Sec = 0,
            .Cargo = CInt(SecCargo),
            .CodFuncion = CInt(detalleF)
        }

            ' Llama al service
            Dim resp = New ServiceCargos().UpsertFuncionCargo(func)
            Return (resp IsNot Nothing AndAlso resp.Count > 0)

        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "GuardaFunciones")
            Return False
        End Try
    End Function

    Private Function GuardaAsignaciones(Seccargo As String, Fecha As String, Asigna As String) As Boolean
        Try
            ' Parsea la fecha y mapea al modelo Cargo_Asignaciones
            Dim dtFecha = Date.ParseExact(Fecha, "dd/MM/yyyy", Globalization.CultureInfo.InvariantCulture)
            Dim asign As New Cargo_Asignaciones With {
            .Sec = 0,
            .Fecha = dtFecha,
            .Cargo = CInt(Seccargo),
            .Asignacion = If(String.IsNullOrWhiteSpace(Asigna), CType(Nothing, Decimal?), Decimal.Parse(Asigna))
        }

            ' Llama al service
            Dim resp = New ServiceCargos().UpsertAsignacionCargo(asign)
            Return (resp IsNot Nothing AndAlso resp.Count > 0)

        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "GuardaAsignaciones")
            Return False
        End Try
    End Function


#End Region
#Region "Funciones y Procedimientos --> Funciones del Cargo"

    Private Sub LimpiarCamposFunciones()
        Try
            txtFunciones.ValordelControl = ""
            txtFunciones.Focus()
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "LimpiarCamposFunciones")
        End Try
    End Sub

    Private Sub CreaGrillaFuncionesCargo()
        gvFuncionesCargo.Columns.Clear()
        HDevExpre.CreaColumnasG(gvFuncionesCargo, "CodFuncion", "Codigo", False, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 0, 0)
        HDevExpre.CreaColumnasG(gvFuncionesCargo, "DetalleFuncion", "Detalle", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 100, gbxFunciones.Width)
        gvFuncionesCargo.Appearance.HeaderPanel.Font = New Font("Trebuchet MS", 11.0!, FontStyle.Bold)
        Dim classResize As New ClaseResize

    End Sub

    Private Sub LlenaGrillaFuncionesCargo(IdCargo As String)
        Try
            Dim sql As String = String.Format("SELECT CF.*,F.DetalleFuncion FROM Cargo_Funciones CF INNER JOIN cargos C ON C.Sec = CF.Cargo INNER JOIN Funciones F ON F.SEC = CF.CodFuncion" &
                                             " WHERE C.CodCargo='{0}'", IdCargo)
            Dim dt As DataTable = SMT_AbrirTabla(ObjetoApiNomina, sql)
            gcFunciones.DataSource = dt
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "LlenaGrillaFuncionesCargo")
        End Try
    End Sub

    Private Function EliminarFuncion(IdFuncion As String, IdCargo As String) As Boolean
        Try
            Dim sql = String.Format("DELETE FROM Cargo_Funciones WHERE Cargo={0} AND CodFuncion={1}", IdCargo, IdFuncion)
            If SMT_EjcutarComandoSqlBool(ObjetoApiNomina, sql) > 0 Then
                Return True
            Else : Return False
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "EliminarFuncion")
            Return False
        End Try
    End Function

    Private Function ValidaCamposFuncionesCargos() As Boolean
        If txtFunciones.ValordelControl = "" Or txtFunciones.DescripciondelControl = "No Se Encontraron Registros" Or txtFunciones.DescripciondelControl = "" Then
            HDevExpre.MensagedeError("El campo funciones no puede estar vacio!..")
            txtFunciones.Focus()
            Return False
        Else
            Return True
        End If
    End Function
#End Region


#Region "Funciones y Procedimientos --> Asignaciones del Cargo"
    Private Sub LimpiarCamposAsignaciones()
        Try
            dteFecha.Text = ""
            txtAsignaciones.ValordelControl = ""
            ActualizandoAsignaciones = False
            Fecha_A = ""
            dteFecha.Focus()
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "LimpiarCamposAsignaciones")
        End Try
    End Sub

    Private Sub CreaGrillAsignacionesCargo()
        gvAsignacionesCargo.Columns.Clear()
        HDevExpre.CreaColumnasG(gvAsignacionesCargo, "Fecha", "Fecha", True, True, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 50, gbxAsignaciones.Width)
        HDevExpre.CreaColumnasG(gvAsignacionesCargo, "Asignacion", "Asignacion", True, True, "", Color.FromArgb(&HCC, &HFF, &HCC), True, False, 50, gbxAsignaciones.Width)
        gvAsignacionesCargo.Appearance.HeaderPanel.Font = New Font("Trebuchet MS", 11.0!, FontStyle.Bold)
        For incre As Integer = 0 To gvAsignacionesCargo.Columns.Count - 1
            If gvAsignacionesCargo.Columns(incre).Name = "Asignacion" Then
                gvAsignacionesCargo.Columns(incre).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                gvAsignacionesCargo.Columns(incre).DisplayFormat.FormatString = "c2"
            End If
        Next
        Dim classResize As New ClaseResize

    End Sub

    Private Sub LlenaGrillaAsignacionesCargo(IdCargo As String)
        Try
            Dim sql As String = "SELECT * FROM Cargo_Asignaciones WHERE Cargo =" + IdCargo
            Dim CopyDt As New DataTable
            CopyDt = SMT_AbrirTabla(ObjetoApiNomina, sql)

            gcAsignaciones.DataSource = CopyDt


        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "LlenaGrillaAsignacionesCargo")
        End Try
    End Sub

    Private Function EliminarAsignacion(Fecha As String, IdCargo As String) As Boolean
        Try
            Dim sql = String.Format("DELETE FROM Cargo_Asignaciones WHERE Cargo={0} AND Fecha='{1}'", IdCargo, Fecha)
            If SMT_EjcutarComandoSqlBool(ObjetoApiNomina, sql) > 0 Then
                Return True
            Else : Return False
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "EliminarAsignacion")
            Return False
        End Try
    End Function

    Private Function ValidaCamposAsignacionesCargo() As Boolean
        SMT_EjcutarComandoSql(ObjetoApiNomina, "SET DATEFORMAT DMY;", 0)
        If dteFecha.Text = "" Then
            HDevExpre.MensagedeError("El Campo Fecha no puede estar vacío!..")
            dteFecha.Focus()
            Return False
        ElseIf txtAsignaciones.ValordelControl = "" Then
            HDevExpre.MensagedeError("El Campo Asignación no puede estar vacío!..")
            txtAsignaciones.Focus()
            Return False
        ElseIf Not ActualizandoAsignaciones And ExisteDato("Cargo_Asignaciones", String.Format("Fecha='{0:dd/MM/yyyy 00:00:00}' AND Cargo='{1}'", dteFecha.Text, Sec_Cargo), ObjetoApiNomina) Then
            HDevExpre.MensagedeError("El sistema registra una asignación para esta fecha, no se puede ingresar mas de una asignación para un misma fecha!")
            txtCodCargoC.Focus()
            Return False

        Else
            Return True
        End If
    End Function


    Private Sub CargarAsignacionesCargo()
        Try
            If gvAsignacionesCargo.RowCount > 0 Then
                txtAsignaciones.ValordelControl = gvAsignacionesCargo.GetFocusedRowCellValue("Asignacion")
                dteFecha.Text = gvAsignacionesCargo.GetFocusedRowCellValue("Fecha")
                Fecha_A = gvAsignacionesCargo.GetFocusedRowCellValue("Fecha")
                ActualizandoAsignaciones = True
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "CargarAsignacionesCargo")
        End Try
    End Sub

#End Region


    Private Sub txtBusqueda_EditValueChanged(sender As Object, e As EventArgs) Handles txtBusqueda.EditValueChanged
        Dim buscando As Boolean = Me.Buscando
        If buscando Then
            FiltrarDatos(txtBusqueda.Text)
        End If
    End Sub

    Private Sub txtBusqueda_Enter(sender As Object, e As EventArgs) Handles txtBusqueda.Enter
        If Not Buscando Then
            txtBusqueda.Text = ""
            Buscando = True
            HDevExpre.EntraControlDev(txtBusqueda, , )
        End If
    End Sub

    Private Sub txtBusqueda_Leave(sender As Object, e As EventArgs) Handles txtBusqueda.Leave
        If txtBusqueda.Text = "" Then
            Buscando = False
            txtNoBuscando()
        End If
    End Sub

    Private Sub txtNoBuscando()
        txtBusqueda.Text = "Digite cualquier parametro de Busqueda"
        txtBusqueda.Font = New Font("Trebuchet MS", 10.25F, FontStyle.Italic)
        txtBusqueda.BackColor = Color.LemonChiffon
        txtBusqueda.ForeColor = Color.Gray
        txtBusqueda.BorderStyle = BorderStyles.Simple
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
        Dim dv As New DataView(dtos)
        dv.RowFilter = Grilla.CrearFiltro(dtos, e.Argument.ToString)
        e.Result = dv
    End Sub
    Private Sub MostrarResultadoFiltro(sender As Object, e As RunWorkerCompletedEventArgs)
        Dim dv As DataView = CType(e.Result, DataView)
        gcCargos.DataSource = dv
    End Sub

    Private Sub AsignaScriptAcontroles()
        Try

            txtFunciones.ConsultaSQL = String.Format("SELECT Sec AS Codigo,DetalleFuncion As Descripcion FROM Funciones")
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "AsignaScriptAcontroles")
        End Try
    End Sub

    Private Sub btnAggFunciones_Click(sender As Object, e As EventArgs) Handles btnAggFunciones.Click
        Dim classResize As New ClaseResize
        Dim Frm As New FrmAggFunciones
        classResize.Resizamodales(Frm, 80, 70)
        Frm.ShowDialog()
        Frm.BringToFront()
    End Sub


    Private Sub EliminarFun_Click(sender As Object, e As EventArgs) Handles EliminarFun.Click
        Try
            Dim Tbla As DataTable = CType(gcFunciones.DataSource, DataTable)
            If Tbla.Rows.Count > 0 Then
                Tbla.Rows.Remove(Tbla.Rows(gvFuncionesCargo.FocusedRowHandle))
                gcFunciones.DataSource = Tbla
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "EliminarFun_Click")
        End Try
    End Sub

    Private Sub btnGuardarAsig_Click(sender As Object, e As EventArgs)
        If Not ActualizandoDatosBasicos Then
            HDevExpre.MensagedeError("El Cargo en el cual desea registrar las asignaciones aun no se encuentra registrado!")
        Else
            If ActualizandoAsignaciones Then
                Dim Registro As Boolean
                Registro = GuardaAsignaciones(Sec_Cargo, String.Format("{0:dd/MM/yyyy}", dteFecha.Text), txtAsignaciones.ValordelControl)
                If Registro Then
                    HDevExpre.mensajeExitoso("Datos guardados exitosamente!..")
                    LimpiarCamposAsignaciones()
                    LlenaGrillaAsignacionesCargo(Me.Sec_Cargo)
                End If
            Else
                Dim Tbla As DataTable = CType(gcAsignaciones.DataSource, DataTable)
                Dim Registro As Boolean = False
                If Tbla.Rows.Count > 0 Then
                    For incre As Integer = 0 To Tbla.Rows.Count - 1
                        If Not ExisteDato("Cargo_Asignaciones", String.Format("Fecha='{0:dd/MM/yyyy}' AND Cargo='{1}' AND Asignacion='{2}'", Tbla.Rows(incre)("Fecha"), Sec_Cargo, Tbla.Rows(incre)("Asignacion")), ObjetoApiNomina) Then
                            Registro = GuardaAsignaciones(Sec_Cargo, String.Format("{0:dd/MM/yyyy}", Tbla.Rows(incre)("Fecha")), Tbla.Rows(incre)("Asignacion").ToString)
                        End If
                    Next
                Else
                    HDevExpre.MensagedeError("Primero debe cargar las asignaciones a registrar!")
                End If
                If Registro Then
                    HDevExpre.mensajeExitoso("Datos guardados exitosamente!..")
                    LimpiarCamposAsignaciones()
                    LlenaGrillaAsignacionesCargo(Me.Cod_Cargo)
                End If
            End If
        End If
    End Sub

    Private Sub EliminarAsig_Click(sender As Object, e As EventArgs) Handles EliminarAsig.Click
        Dim Tbla As DataTable = CType(gcAsignaciones.DataSource, DataTable)
        If Tbla.Rows.Count > 0 Then
            Tbla.Rows.Remove(Tbla.Rows(gvAsignacionesCargo.FocusedRowHandle))
            gcAsignaciones.DataSource = Tbla
        End If
    End Sub

    Private Sub FrmCargo_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        FormularioAbierto = False
    End Sub

    Private Sub FrmCargo_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If ActualizandoDatosBasicos Then
            If HDevExpre.MsgSamit("Se están modificando datos, Seguro que desea cerrar el formulario?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Cancel Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub txtFunciones_Leave(sender As Object, e As EventArgs) Handles txtFunciones.Leave
        'btnAggFunc.Focus()
    End Sub

    Private Sub txtAsignaciones_Leave(sender As Object, e As EventArgs) Handles txtAsignaciones.Leave
        'btnAggAsignacion.Focus()
    End Sub

    Private Sub btnAggFunc_Click(sender As Object, e As EventArgs) Handles btnAggFunc.Click
        If ValidaCamposFuncionesCargos() Then
            If IsNothing(gcFunciones.DataSource) Then
                Dim tb As New DataTable
                tb.Columns.Add()
            End If
            Dim Tbla As DataTable = CType(gcFunciones.DataSource, DataTable)
            If Tbla.Rows.Count > 0 Then

                For incre As Integer = 0 To Tbla.Rows.Count - 1
                    If CInt(Tbla.Rows(incre)("CodFuncion")) = CInt(Convert.ToInt32(txtFunciones.ValordelControl)) Then
                        HDevExpre.MensagedeError("Esta Función ya se encuentra agregada..!")
                        Exit Sub
                    End If
                Next
            End If
            Dim NuevaFila As DataRow = Tbla.NewRow()
            NuevaFila("DetalleFuncion") = txtFunciones.DescripciondelControl
            NuevaFila("CodFuncion") = txtFunciones.ValordelControl
            Tbla.Rows.Add(NuevaFila)
            Tbla.AcceptChanges()
            gcFunciones.DataSource = Tbla
            LimpiarCamposFunciones()
        End If
    End Sub

    Private Sub btnAggAsignacion_Click(sender As Object, e As EventArgs) Handles btnAggAsignacion.Click
        If ValidaCamposAsignacionesCargo() Then
            Dim Tbla As DataTable = CType(gcAsignaciones.DataSource, DataTable)
            If Tbla.Rows.Count > 0 Then

                For incre As Integer = 0 To Tbla.Rows.Count - 1
                    If Tbla.Rows(incre)("Fecha") = dteFecha.Text And Tbla.Rows(incre)("Asignacion") = txtAsignaciones.ValordelControl Then
                        HDevExpre.MensagedeError("Esta Asignación ya se encuentra agregada..!")
                        Exit Sub

                    ElseIf Tbla.Rows(incre)("Fecha") = dteFecha.Text And Tbla.Rows(incre)("Cargo") = Sec_Cargo Then
                        HDevExpre.MensagedeError("Ya se encuentra agregada una Asignación para esta misma fecha..!")
                    End If
                Next
            End If
            Dim NuevaFila As DataRow = Tbla.NewRow()
            NuevaFila("Fecha") = dteFecha.Text
            NuevaFila("Asignacion") = txtAsignaciones.ValordelControl
            NuevaFila("Cargo") = Sec_Cargo
            Tbla.Rows.Add(NuevaFila)
            Tbla.AcceptChanges()
            gcAsignaciones.DataSource = Tbla
            LimpiarCamposAsignaciones()
        End If
    End Sub

    Private Sub dteFecha_Enter(sender As Object, e As EventArgs) Handles dteFecha.Enter
        HDevExpre.EntraControlDateEditDEV(dteFecha, lblFecha)
        FrmPrincipal.MensajeDeAyuda.Caption = "Seleccione la fecha desde que aplicara el salario. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
    End Sub

    Private Sub dteFecha_Leave(sender As Object, e As EventArgs) Handles dteFecha.Leave
        HDevExpre.SaleControlDateEditDEV(dteFecha, lblFecha)
        FrmPrincipal.MensajeDeAyuda.Caption = ""
    End Sub

    Private Sub txtFunciones_PresionaTecla(sender As Object, e As KeyEventArgs) Handles txtFunciones.PresionaTecla
        Try
            If e.KeyCode = Keys.F5 Then
                txtFunciones.RefrescarDatos()
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "txtFunciones_PresionaTecla")
        End Try
    End Sub

    Private Sub dteFecha_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dteFecha.KeyPress
        HDevExpre.AvanzaConEnter(e)
    End Sub

    Private Sub btnSalir_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescripCargo.KeyPress, btnSalir.KeyPress, btnLimpiar.KeyPress, btnGuardar.KeyPress, btnEliminar.KeyPress, btnAggFunciones.KeyPress, btnAggFunc.KeyPress, btnAggAsignacion.KeyPress
        HDevExpre.AtrasConScape(e)
    End Sub
End Class