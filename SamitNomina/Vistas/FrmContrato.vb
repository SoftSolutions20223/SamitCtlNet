Option Strict Off
Imports SamitCtlNet
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Columns
Imports System.Transactions
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports SamitNominaLogic

Public Class FrmContrato

    Public Datos As New SamitCtlNet.SamitCtlNet

    'Variables para validar actualizaciones
    Dim ActualizandoDatosBasicos As Boolean = False
    Dim ActualizandoCargosCon As Boolean = False
    Dim ActualizandoCentrosCostos As Boolean = False
    Dim SecCargoAc As String
    Dim HDevExpre As New HelperDevExpress
    Dim HNomina As New HelperNomina
    'Fin variables para validar actualizaciones

    'Propiedades

    Dim FormularioAbierto As Boolean = False
    Public Property P_FormularioAbierto() As Boolean
        Get
            Return FormularioAbierto
        End Get
        Set(value As Boolean)
            FormularioAbierto = value
        End Set
    End Property

    Dim VsecCargo As String
    Public Property SecCargoC() As String
        Get
            Return VsecCargo
        End Get
        Set(value As String)
            VsecCargo = value
        End Set
    End Property

    Dim VCodContrato As String
    Public Property CodContrato() As String
        Get
            Return VCodContrato
        End Get
        Set(value As String)
            VCodContrato = value
        End Set
    End Property

    Dim VSecCentroCosto As String
    Public Property SecCentroCosto() As String
        Get
            Return VSecCentroCosto
        End Get
        Set(value As String)
            VSecCentroCosto = value
        End Set
    End Property


    'Fin Propiedades

    Private Sub FrmContrato_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'Dim classResize As New ClaseResize
            'classResize.ResizeForm(Me)
            txtAsignaciones.Enabled = False
            AcomodaForm()
            CodContrato = ""
            LlenaGrillaCargosCon(CodContrato)
            LlenaGrillaCentrosCostos(CodContrato)
            AsignaScriptAcontroles()
            txtEmpleado.Select()
            AsignaMsgAcontroles()
            txtCodContrato.MaximoAncho = AnchoCampoSql(ObjetoApiNomina, "Contratos", "IdContrato")
            CreaGrillaContratos()
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, " Load Contrato")
        End Try
    End Sub

    Private Sub AcomodaForm()
        Try

            btnGuardar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Guardar)
            btnLimpiar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Limpiar)
            btnEliminar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.EliminarGris)
            btnSalir.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.SalirCuadroConX)
            btnAddTipoContrato.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Agregar)
            btnAddCentroCosto.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Agregar)
            btnAddDependencia.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Agregar)
            btnAggCargosContrato.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Agregar)
            btnAggCentroCosto.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Agregar)
            btnEliminarCargosContrato.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Eliminar)
            btnEliminarCentroCosto.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Eliminar)
            cbxTipoCodigo.SelectedIndex = 0
            txtCodContrato.Enabled = True
            dteFechaIniC.EditValue = Datos.Smt_FechaDelServidor
            dteFechaFinC.EditValue = Datos.Smt_FechaDelServidor
            dteFechaIniCc.EditValue = Datos.Smt_FechaDelServidor
            dteFechaFinCc.EditValue = Datos.Smt_FechaDelServidor

        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, " AcomodaForm Contrato")
        End Try
    End Sub

    Private Sub AsignaScriptAcontroles()
        Try
            txtEmpleado.ConsultaSQL = String.Format(" SELECT Identificacion AS Codigo,RTRIM(LTRIM(RTRIM(LTRIM(PNombre)) + ' ' + " +
            " RTRIM(LTRIM(SNombre)) + ' ' +  RTRIM(LTRIM(PApellido)) + ' ' + " +
            " RTRIM(LTRIM(SApellido)))) As Descripcion FROM  Empleados")

            txtTipoContrato.ConsultaSQL = String.Format("SELECT Sec AS Codigo,NomTipo As Descripcion FROM  CAT_TipoContratos")

            txtDependencia.ConsultaSQL = String.Format("SELECT Sec AS Codigo,NomDependencia As Descripcion FROM  Dependencias where Vigente = 1")

            txtCargos.ConsultaSQL = String.Format("SELECT Sec AS Codigo,Denominacion As Descripcion FROM  cargos")

            txtPlantillas.ConsultaSQL = String.Format("SELECT Sec AS Codigo,NomPlantilla As Descripcion FROM  Plantillas WHERE Vigente = 1")

            txtPerfilCta.ConsultaSQL = String.Format("SELECT Sec AS Codigo,NomPerfilCta As Descripcion FROM  PerfilesCta WHERE Vigente = 1")

            txtTipoTrabajador.ConsultaSQL = String.Format("Select '01' As Codigo, 'Dependiente' As Descripcion Union 
Select '02' As Codigo, 'Servicio domestico' As Descripcion Union 
Select '04' As Codigo, 'Madre comunitaria' As Descripcion Union 
Select '12' As Codigo, 'Aprendices del Sena en etapa lectiva' As Descripcion Union 
Select '18' As Codigo, 'Funcionarios públicos sin tope máximo de ibc' As Descripcion Union 
Select '19' As Codigo, 'Aprendices del SENA en etapa productiva' As Descripcion Union 
Select '21' As Codigo, 'Estudiantes de postgrado en salud' As Descripcion Union 
Select '22' As Codigo, 'Profesor de establecimiento particular' As Descripcion Union 
Select '23' As Codigo, 'Estudiantes aportes solo riesgos laborales' As Descripcion Union 
Select '30' As Codigo, 'Dependiente entidades o universidades públicas con régimen especial en salud' As Descripcion Union 
Select '31' As Codigo, 'Cooperados o pre cooperativas de trabajo asociado' As Descripcion Union 
Select '47' As Codigo, 'Trabajador dependiente de entidad beneficiaria del sistema general de participaciones ‐ aportes patronales' As Descripcion Union 
Select '51' As Codigo, 'Trabajador de tiempo parcial' As Descripcion Union 
Select '54' As Codigo, 'Pre pensionado de entidad en liquidación.' As Descripcion Union 
Select '56' As Codigo, 'Pre pensionado con aporte voluntario a salud' As Descripcion Union 
Select '58' As Codigo, 'Estudiantes de prácticas laborales en el sector público' As Descripcion ")


            Dim Empresa As Integer = Datos.Seguridad.DatosDeLaEmpresa.NumEmpresa
            txtOficina.DatosDefecto = ObjetosNomina.Oficinas
            txtCentroCostos.ConsultaSQL = String.Format("SELECT Sec AS Codigo,Nom_CentroCosto As Descripcion FROM  CT_CentroCostos WHERE Estado='1'")
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "AsignaScriptAcontroles")
        End Try
    End Sub

    Private Sub BloqueaOpciones(Contrato As String)
        Try
            Dim sql As String = "Select Consul.Sec,Consul.Tipo From( " +
                                                   "   Select NLC.Sec As Sec, 'P' As Tipo From NominaLiquidaContratos NLC INNER JOIN NominaLiquida NL ON NLC.NominaLiquida = NL.Sec Where NL.EsBorrador=1 And NLC.Contrato =" + Contrato + " Union " +
                                                     " Select NLC.Sec As Sec, 'E' As Tipo From NominaLiquidaExtraordinariaContratos NLC INNER JOIN NominaLiquidaExtraordinaria NL ON NLC.NominaLiquidaExtraordinaria = NL.Sec Where NL.EsBorrador=1 And NLC.Contrato =" + Contrato + " Union " +
                                                    "  Select NLC.Sec As Sec, 'C' As Tipo From ContratosLiquidados_Contratos NLC INNER JOIN ContratosLiquidados NL ON NLC.NominaLiquida = NL.Sec Where NL.EsBorrador=1 And NLC.Contrato =" + Contrato + " " +
") as Consul "
            Dim dt As DataTable = SMT_AbrirTabla(ObjetoApiNomina, sql)
            If dt.Rows.Count > 0 Then
                txtOficina.Enabled = False
                txtNominas.Enabled = False
                For incre As Integer = 0 To dt.Rows.Count - 1
                    If dt.Rows(incre)("Tipo").ToString = "P" Then
                        txtPlantillas.Enabled = False
                    ElseIf dt.Rows(incre)("Tipo").ToString = "C" Then
                        txtTipoContrato.Enabled = False
                    End If
                Next
                Timer1.Enabled = True
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "AsignaScriptAcontroles")
        End Try
    End Sub

    Private Sub DesbloqueaOpciones()
        Try
            Label1.Visible = False
            txtOficina.Enabled = True
            txtNominas.Enabled = True
            txtPlantillas.Enabled = True
            txtTipoContrato.Enabled = True
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "AsignaScriptAcontroles")
        End Try
    End Sub

    Private Sub AsignaMsgAcontroles()
        Try
            txtEmpleado.MensajedeAyuda = "Seleccione el empleado con el que desea trabajar. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras, (F5,DER)=Buscar"
            txtCodContrato.MensajedeAyuda = "Digite el código del contrato. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
            txtTipoContrato.MensajedeAyuda = "Seleccione el tipo de contrato. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras, (F5,DER)=Buscar"
            txtDependencia.MensajedeAyuda = "Seleccione la dependencia o area a la cual estará asociado el contrato. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras, (F5,DER)=Buscar"
            txtOficina.MensajedeAyuda = "Seleccione la oficina a la cual estará asociado el contrato. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras, (F5,DER)=Buscar"
            txtNominas.MensajedeAyuda = "Seleccione la nómina en la cual se liquidará este contrato. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras, (F5,DER)=Buscar"
            txtPlantillas.MensajedeAyuda = "Seleccione el perfil de conceptos que será usado en este contrato. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras, (F5,DER)=Buscar"
            txtPerfilCta.MensajedeAyuda = "Seleccione el perfil de cuentas que será usado en este contrato. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras, (F5,DER)=Buscar"
            txtAsignaciones.MensajedeAyuda = "Digite la asignación salarial que recibe el empleado mensulamente. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
            txtHorasMes.MensajedeAyuda = "Digite las horas que el empleado dedicará a sus labores mensualmente. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
            txtCargos.MensajedeAyuda = "Seleccione el cargo que desea agregar al contrato. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras, (F5,DER)=Buscar"
            txtCentroCostos.MensajedeAyuda = "Seleccione el centro de costo que desea agregar al contrato. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
            txtPorcentaje.MensajedeAyuda = "Digite el porcentaje que tendrá a cargo el centro de costos. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "AsignaMsgAcontroles")
        End Try
    End Sub


#Region "EfectosControles"
    'CONTROLES DATOS BASICOS

    Private Sub txtDocEmpleado_KeyDown(sender As Object, e As KeyEventArgs) Handles dteFechaIniC.KeyDown, dteFechaFinC.KeyDown
        HDevExpre.AvanzarAtrasControl(e)
    End Sub


    Private Sub txtDocEmpleado_Enter(sender As Object, e As EventArgs)
        FrmPrincipal.MensajeDeAyuda.Caption = "Digite el Número de documento del empleado. (ENTER,ABJ)=Avanzar;(F5)=Buscar"
    End Sub

    'FIN CONTROLES BASICOS

    'CONTROLES CARGOS DEL CONTRATO
    'FIN CONTROLES CARGOS DEL CONTRATO

    'INICIA CONTROLES CENTROS DE COSTO

    'FIN CONTROLES CENTROS DE COSTO
#End Region


#Region "Botones Principales"

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            ' 1) Validar fecha inicio
            If IsNothing(dteFechaIniC.EditValue) OrElse dteFechaIniC.Text = "" Then
                HDevExpre.MensagedeError("La fecha de inicio de contrato no puede estar vacía.")
                dteFechaIniC.Focus()
                Exit Sub
            End If

            ' 2) Validar centros de costo
            Dim dtCC As DataTable = DirectCast(gcCentrosCosto.DataSource, DataTable)
            If dtCC.Rows.Count = 0 Then
                HDevExpre.MensagedeError("Debe ingresar al menos un centro de costos")
                txtCentroCostos.Focus()
                Exit Sub
            End If

            Dim totalPct As Decimal = 0
            For i As Integer = 0 To dtCC.Rows.Count - 1
                totalPct += Convert.ToDecimal(dtCC.Rows(i)("Porcentaje"))
            Next

            If totalPct <> 0 AndAlso totalPct <> 100 Then
                HDevExpre.MensagedeError("La suma de porcentajes debe ser 0 o 100%")
                Exit Sub
            End If

            ' 3) Preparar datos usando las clases existentes
            Dim isUpdate = (CodContrato <> "")

            ' Crear el contrato principal usando la clase Contratos existente
            Dim contrato As New Contratos With {
            .Sec = If(isUpdate, CInt(CodContrato), 0),
            .Oficina = Short.Parse(txtOficina.ValordelControl),
            .CodContrato = Integer.Parse(txtCodContrato.ValordelControl),
            .TipoContrato = Short.Parse(txtTipoContrato.ValordelControl),
            .HorasMes = Short.Parse(IIf(txtHorasMes.ValordelControl = "", "0", txtHorasMes.ValordelControl)),
            .FechaInicio = dteFechaIniC.DateTime,
            .FechaFin = If(dteFechaFinC.Text <> "", CType(dteFechaFinC.DateTime, DateTime?), Nothing),
            .Dependencia = If(txtDependencia.ValordelControl <> "", Short.Parse(txtDependencia.ValordelControl), CType(Nothing, Short?)),
            .Plantilla = If(txtPlantillas.ValordelControl <> "", Integer.Parse(txtPlantillas.ValordelControl), CType(Nothing, Integer?)),
            .PerfilCuentas = If(txtPerfilCta.ValordelControl <> "", Integer.Parse(txtPerfilCta.ValordelControl), CType(Nothing, Integer?)),
            .Nomina = If(txtNominas.ValordelControl <> "", Integer.Parse(txtNominas.ValordelControl), CType(Nothing, Integer?)),
            .Asignacion = Decimal.Parse(txtAsignaciones.ValordelControl),
            .IdContrato = txtCodContrato.ValordelControl,
            .AsignacionCargo = cbxAsignacion.SelectedIndex.ToString(),
            .UsaAsginaCargo = (cbxAsignacion.SelectedIndex > 0),
            .TipoTrabajador = txtTipoTrabajador.ValordelControl,
            .SubTipoTrabajador = cbxSubTipoTrabajador.SelectedIndex.ToString(),
            .SalarioIntegral = cbxSalarioIntegral.SelectedIndex.ToString(),
            .Terminado = False,
            .Aprendiz = False
        }

            ' Crear el request principal
            Dim request As New UpsertContratoRequest With {
            .Contrato = contrato,
            .IdentificacionEmpleado = Long.Parse(txtEmpleado.ValordelControl), ' Asumiendo que es la identificación
            .Usuario = Datos.Smt_Usuario,
            .Terminal = Environment.MachineName
        }

            ' 4) Agregar centros de costo usando la clase Contratos_CentroCostos
            For i As Integer = 0 To dtCC.Rows.Count - 1
                Dim centroCosto As New Contratos_CentroCostos With {
                .CentroCosto = Short.Parse(dtCC.Rows(i)("CentroCosto").ToString()),
                .Porcentaje = Decimal.Parse(dtCC.Rows(i)("Porcentaje").ToString())
            }
                request.CentrosCosto.Add(centroCosto)
            Next

            ' 5) Agregar cargos del contrato usando la clase Contrato_Cargos
            Dim dtCargos As DataTable = DirectCast(gcCargosContratos.DataSource, DataTable)
            For i As Integer = 0 To dtCargos.Rows.Count - 1
                Dim row = dtCargos.Rows(i)
                Dim cargo As New Contrato_Cargos With {
                .Cargo = CInt(row("SecCargo")),
                .FechaInicio = CDate(row("FechaInicio")),
                .FechaFin = If(row("FechaFin") Is DBNull.Value, CType(Nothing, Date?), CDate(row("FechaFin"))),
                .UsrRegistra = Datos.Smt_Usuario,
                .FechaRegistro = Datos.Smt_FechaDelServidor,
                .TerminalRegistra = Environment.MachineName
            }
                request.Cargos.Add(cargo)
            Next

            ' 6) Ejecutar procedimiento almacenado

            Dim resp = SMT_EjecutaProcedimientos(ObjetoApiNomina, "SP_UpsertContrato", request.ToJObject())

            Dim response = resp.ToObject(Of UpsertContratoResponse)()

            ' 7) Procesar respuesta
            If response.EsExitoso Then
                ' Actualizar CodContrato si fue inserción
                If Not isUpdate AndAlso response.Contrato IsNot Nothing Then
                    CodContrato = response.Contrato.Sec.ToString()
                End If

                ' Mostrar mensaje de éxito
                HDevExpre.mensajeExitoso($"{response.Mensaje}")

                ' Refrescar UI
                LimpiarTodosCampos()
                LlenaGrillaCargosCon(CodContrato)
                LlenaGrillaCentrosCostos(CodContrato)
                txtEmpleado.Focus()

            Else
                ' Mostrar error
                HDevExpre.MensagedeError($"Error al guardar el contrato: {response.Mensaje}")

                ' Log adicional si hay código de error
                If response.CodigoError.HasValue Then
                    Console.WriteLine($"Código de error SQL: {response.CodigoError.Value}")
                End If
            End If

        Catch ex As Exception
            HDevExpre.MensagedeError($"Error inesperado: {ex.Message}")
            Console.WriteLine($"Stack trace: {ex.StackTrace}")
        End Try
    End Sub




    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

        LimpiarTodosCampos()
        txtEmpleado.Focus()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click


        'Using trans As New TransactionScope
        Try
            Dim sql As String = "Select Consul.Sec,Consul.Tipo From( " +
                                               "   Select NLC.Sec As Sec, 'P' As Tipo From NominaLiquidaContratos NLC INNER JOIN NominaLiquida NL ON NLC.NominaLiquida = NL.Sec Where NL.EsBorrador=1 And NLC.Contrato =" + CodContrato + " Union " +
                                                 " Select NLC.Sec As Sec, 'E' As Tipo From NominaLiquidaExtraordinariaContratos NLC INNER JOIN NominaLiquidaExtraordinaria NL ON NLC.NominaLiquidaExtraordinaria = NL.Sec Where NL.EsBorrador=1 And NLC.Contrato =" + CodContrato + " Union " +
                                                "  Select NLC.Sec As Sec, 'C' As Tipo From ContratosLiquidados_Contratos NLC INNER JOIN ContratosLiquidados NL ON NLC.NominaLiquida = NL.Sec Where NL.EsBorrador=1 And NLC.Contrato =" + CodContrato + " " +
") as Consul "
            Dim dt As DataTable = SMT_AbrirTabla(ObjetoApiNomina, sql)
            If dt.Rows.Count > 0 Then
                HDevExpre.MensagedeError("Este contrato tiene liquidaciones pendientes, no puede ser eliminado")
                Exit Sub
            End If

            sql = "Select Consul.Sec,Consul.Tipo From( " +
                                               "   Select NLC.Sec As Sec, 'P' As Tipo From NominaLiquidadaContratos NLC INNER JOIN NominaLiquidada NL ON NLC.NominaLiquidada = NL.Sec Where NLC.Contrato =" + CodContrato + " Union " +
                                                " Select NLC.Sec As Sec, 'S' As Tipo From NominaLiquidaSemestresContratos NLC INNER JOIN NominaLiquidaSemestres NL ON NLC.NominaLiquidaSemestres = NL.Sec Where NLC.Contrato =" + CodContrato + " Union " +
            " Select NLC.Sec As Sec, 'E' As Tipo From NominaLiquidaExtraordinariaContratos NLC INNER JOIN NominaLiquidaExtraordinaria NL ON NLC.NominaLiquidaExtraordinaria = NL.Sec Where NL.EsBorrador=0 And NLC.Contrato =" + CodContrato + " Union " +
                                                "  Select NLC.Sec As Sec, 'C' As Tipo From ContratosLiquidados_Contratos NLC INNER JOIN ContratosLiquidados NL ON NLC.NominaLiquida = NL.Sec Where NL.EsBorrador=0 And NLC.Contrato =" + CodContrato + " " +
") as Consul "
            dt = SMT_AbrirTabla(ObjetoApiNomina, sql)
            If dt.Rows.Count > 0 Then
                HDevExpre.MensagedeError("Este contrato ya tiene liquidaciones, no puede ser eliminado")
                Exit Sub
            End If

            If HDevExpre.MsgSamit("Seguro que desea este contrato con todos sus cargos y centros de costo?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.OK Then
                If ExisteDato("Contratos_CentroCostos", String.Format("Contrato='{0}'", CodContrato), ObjetoApiNomina) Then
                    sql = String.Format("DELETE FROM Contratos_CentroCostos WHERE Contrato={0}", CodContrato)
                    If Not SMT_EjcutarComandoSqlBool(ObjetoApiNomina, sql) > 0 Then
                        Exit Sub
                    End If
                End If

                If ExisteDato("Contrato_Cargos", String.Format("Contrato='{0}'", CodContrato), ObjetoApiNomina) Then
                    ModCargoActual(CodContrato)
                    sql = String.Format("DELETE FROM Contrato_Cargos WHERE Contrato={0}", CodContrato)
                    If Not SMT_EjcutarComandoSqlBool(ObjetoApiNomina, sql) > 0 Then
                        Exit Sub
                    End If
                End If

                sql = String.Format("DELETE FROM Contratos WHERE CodContrato={0}", CodContrato)
                If Not SMT_EjcutarComandoSqlBool(ObjetoApiNomina, sql) > 0 Then
                    Exit Sub
                End If

                HDevExpre.mensajeExitoso("Información eliminada exitosamente!")
                LimpiarTodosCampos()
                txtEmpleado.Focus()
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "btnEliminar_Click")
        End Try
        'End Using
    End Sub
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
#End Region

#Region "Funciones y Procedimientos --> Datos Básicos"
    Public Function ValidaCamposDatosBasicos() As Boolean
        If ActualizandoDatosBasicos Then
            Dim sql As String = "Select Consul.Sec,Consul.Tipo From( " +
                                       "   Select NLC.Sec As Sec, 'P' As Tipo From NominaLiquidaContratos NLC INNER JOIN NominaLiquida NL ON NLC.NominaLiquida = NL.Sec Where NL.EsBorrador=1 And NLC.Contrato =" + CodContrato + " Union " +
                                         " Select NLC.Sec As Sec, 'E' As Tipo From NominaLiquidaExtraordinariaContratos NLC INNER JOIN NominaLiquidaExtraordinaria NL ON NLC.NominaLiquidaExtraordinaria = NL.Sec Where NL.EsBorrador=1 And NLC.Contrato =" + CodContrato + " Union " +
                                        "  Select NLC.Sec As Sec, 'C' As Tipo From ContratosLiquidados_Contratos NLC INNER JOIN ContratosLiquidados NL ON NLC.NominaLiquida = NL.Sec Where NL.EsBorrador=1 And NLC.Contrato =" + CodContrato + " " +
") as Consul "
            Dim dt As New DataTable
            Dim Tbla As DataTable = CType(gcCargosContratos.DataSource, DataTable)
            dt = SMT_AbrirTabla(ObjetoApiNomina, sql)
            If dt.Rows.Count > 0 And Tbla.Rows.Count < 1 Then
                HDevExpre.MensagedeError("Este contrato debe tener al menos un cargo." & vbNewLine & "Este contrato liquidaciones pendientes!..")
                txtCargos.Focus()
                Return False
            ElseIf ExisteDato("Contratos", String.Format("IdContrato='{0}' And CodContrato<>'{1}'", txtCodContrato.ValordelControl, CodContrato), ObjetoApiNomina) Then
                HDevExpre.MensagedeError("Este codigo ya se encuentra registrado con otro contrato!..")
                Return False
            End If
        Else
            If cbxTipoCodigo.SelectedIndex = 0 Then
                If ExisteDato("Contratos", String.Format("IdContrato='{0}'", txtCodContrato.ValordelControl), ObjetoApiNomina) Then
                    HDevExpre.MensagedeError("Este codigo ya se encuentra registrado con otro contrato!..")
                    Return False
                End If
            End If
        End If
        If txtEmpleado.ValordelControl = "" Or txtEmpleado.DescripciondelControl = "No Se Encontraron Registros" Or txtEmpleado.DescripciondelControl = "" Then
            HDevExpre.MensagedeError("El campo Empleado no puede estar vacío o contener valores invalidos!..")
            txtEmpleado.Focus()
            Return False
        ElseIf txtTipoContrato.ValordelControl <> "" And txtTipoContrato.DescripciondelControl = "No Se Encontraron Registros" Or txtTipoContrato.ValordelControl <> "" And txtTipoContrato.DescripciondelControl = "" Then
            HDevExpre.MensagedeError("El campo Tipo contrato no puede contener valores invalidos!..")
            txtTipoContrato.Focus()
            Return False
        ElseIf txtTipoTrabajador.ValordelControl <> "" And txtTipoTrabajador.DescripciondelControl = "No Se Encontraron Registros" Or txtTipoTrabajador.ValordelControl <> "" And txtTipoTrabajador.DescripciondelControl = "" Then
            HDevExpre.MensagedeError("El campo Tipo trabajador no puede contener valores invalidos!..")
            txtTipoTrabajador.Focus()
            Return False
        ElseIf txtDependencia.ValordelControl <> "" And txtDependencia.DescripciondelControl = "No Se Encontraron Registros" Or txtDependencia.ValordelControl <> "" And txtDependencia.DescripciondelControl = "" Then
            HDevExpre.MensagedeError("El campo Dependencia no puede contener valores invalidos!..")
            txtDependencia.Focus()
            Return False
        ElseIf txtHorasMes.ValordelControl = "" Or txtHorasMes.ValordelControl = "0" Then
            HDevExpre.MensagedeError("El campo Horas Mes no puede estar vacio ni puede ser igual o menor que cero!..")
            txtHorasMes.Focus()
            Return False
        ElseIf txtOficina.ValordelControl = "" Or txtOficina.DescripciondelControl = "No Se Encontraron Registros" Or txtOficina.DescripciondelControl = "" Then
            HDevExpre.MensagedeError("El campo Oficina no puede estar vacío o contener valores invalidos!..")
            txtOficina.Focus()
            Return False
        ElseIf txtCodContrato.ValordelControl = "" Then
            HDevExpre.MensagedeError("El campo Codigo Contrato no puede estar vacío o contener valores invalidos!..")
            txtCodContrato.Focus()
            Return False
        ElseIf txtPlantillas.ValordelControl <> "" And txtPlantillas.DescripciondelControl = "No Se Encontraron Registros" Or txtPlantillas.ValordelControl <> "" And txtPlantillas.DescripciondelControl = "" Then
            HDevExpre.MensagedeError("El campo Perfil Conceptos no puede contener valores invalidos!..")
            txtPlantillas.Focus()
            Return False
        ElseIf txtPerfilCta.ValordelControl <> "" And txtPerfilCta.DescripciondelControl = "No Se Encontraron Registros" Or txtPerfilCta.ValordelControl <> "" And txtPerfilCta.DescripciondelControl = "" Then
            HDevExpre.MensagedeError("El campo Perfil cuentas no puede contener valores invalidos!..")
            txtPerfilCta.Focus()
            Return False
        ElseIf txtNominas.ValordelControl <> "" And txtNominas.DescripciondelControl = "No Se Encontraron Registros" Or txtNominas.ValordelControl <> "" And txtNominas.DescripciondelControl = "" Then
            HDevExpre.MensagedeError("El campo Nomina no puede contener valores invalidos!..")
            txtNominas.Focus()
            Return False
        ElseIf dteFechaFinC.DateTime < dteFechaIniC.DateTime And dteFechaFinC.Text <> "" Then
            HDevExpre.MensagedeError("La fecha de inicio del contrato no puede ser superior a la fecha de finalización!..")
            dteFechaFinC.Focus()
            Return False
        Else
            Return True
        End If
    End Function
    Public Sub LimpiarTodosCampos()
        'Limpia todos los campos de texto
        txtEmpleado.ValordelControl = ""
        txtPorcentaje.ValordelControl = ""
        txtDependencia.ValordelControl = ""
        txtTipoContrato.ValordelControl = ""
        txtTipoTrabajador.ValordelControl = ""
        txtOficina.ValordelControl = ""
        txtPlantillas.ValordelControl = ""
        txtPerfilCta.ValordelControl = ""
        txtCodContrato.ValordelControl = ""
        txtAsignaciones.ValordelControl = ""
        txtHorasMes.ValordelControl = ""
        txtNominas.ValordelControl = ""
        txtCargos.ValordelControl = ""
        txtCentroCostos.ValordelControl = ""
        cbxAsignacion.SelectedIndex = 0
        txtAsignaciones.Enabled = True
        'Limpia dte
        dteFechaIniC.Text = ""
        dteFechaFinC.Text = ""
        dteFechaIniCc.Text = ""
        dteFechaFinCc.Text = ""
        'Limpia variables para validar acutalizaciones
        ActualizandoDatosBasicos = False
        ActualizandoCargosCon = False
        ActualizandoCentrosCostos = False
        'Limpia propiedades
        CodContrato = ""
        SecCargoC = ""
        SecCentroCosto = ""
        'Limpia todas las grillas
        gcCentrosCosto.DataSource = Nothing
        gcCargosContratos.DataSource = Nothing
        gcContratos.DataSource = Nothing
        cbxTipoCodigo.SelectedIndex = 0
        cbxSubTipoTrabajador.SelectedIndex = 0
        cbxSalarioIntegral.SelectedIndex = 0
        LlenaGrillaCargosCon(CodContrato)
        LlenaGrillaCentrosCostos(CodContrato)
        Timer1.Enabled = False
        DesbloqueaOpciones()
    End Sub


    Private Sub LlenaGrillaContratos(Empleado As String)
        Try
            Dim sql As String = "SELECT C.*,RTRIM(LTRIM(RTRIM(LTRIM(E.PNombre)) + ' ' + " +
            " RTRIM(LTRIM(E.SNombre)) + ' ' +  RTRIM(LTRIM(E.PApellido)) + ' ' + " +
            " RTRIM(LTRIM(E.SApellido)))) As NomEmple,E.Identificacion As CcEmpleado,TC.NomTipo As NomTipoContrato, D.NomDependencia As NomDependencia,P.NomPlantilla As NomPlantilla,Cta.NomPerfilCta As NomPerfilCta,N.NomNomina As NomNomina " +
            " FROM Contratos C INNER JOIN Empleados E ON E.Sec = C.Empleado LEFT JOIN Dependencias D On C.Dependencia = D.Sec " +
            " LEFT JOIN CAT_TipoContratos TC On C.TipoContrato = TC.Sec LEFT JOIN Plantillas P on C.Plantilla = P.Sec LEFT JOIN Nominas N On C.Nomina = N.Sec LEFT JOIN PerfilesCta Cta on C.PerfilCuentas = Cta.Sec Where E.Identificacion='" + Empleado + "'"
            Dim CopyDt As New DataTable
            CopyDt = SMT_AbrirTabla(ObjetoApiNomina, sql)
            CopyDt.Columns.Add("NomOficina", GetType(String))
            Dim Empresa As Integer = Datos.Seguridad.DatosDeLaEmpresa.NumEmpresa
            sql = "SELECT NumOficina,NomOficina FROM Oficinas WHERE Estado='V' AND NumEmpresa=" &
                   Empresa.ToString
            Dim dt2 As DataTable = SMT_AbrirTabla(SMTConex, sql)
            If dt2.Rows.Count > 0 Then
                For incre As Integer = 0 To dt2.Rows.Count - 1
                    For incre2 As Integer = 0 To CopyDt.Rows.Count - 1
                        If CopyDt.Rows(incre2)("Oficina") = dt2.Rows(incre)("NumOficina") Then
                            CopyDt.Rows(incre2)("NomOficina") = dt2.Rows(incre)("NomOficina")
                        End If
                    Next
                Next
            End If
            gcContratos.DataSource = CopyDt
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "LlenaGrillaContratos")
        End Try
    End Sub

    Private Sub gvContratos_DoubleClick(sender As Object, e As EventArgs) Handles gvContratos.DoubleClick
        ConsultaContratos()
    End Sub

    Private Sub gvContratos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles gvContratos.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            ConsultaContratos()
        End If
    End Sub

    Private Sub ConsultaContratos()
        Try
            DesbloqueaOpciones()
            Timer1.Enabled = False
            Dim tabla As DataTable = CType(gcContratos.DataSource, DataTable)
            Dim Fila() As DataRow = tabla.Select("CodContrato =" + gvContratos.GetFocusedRowCellValue("CodContrato").ToString)
            txtTipoContrato.RefrescarDatos()
            txtTipoContrato.ValordelControl = Fila(0)("TipoContrato").ToString
            txtTipoTrabajador.ValordelControl = Fila(0)("TipoTrabajador").ToString
            dteFechaIniC.EditValue = CDate(Fila(0)("FechaInicio"))
            Dim fechafinal As String = Fila(0)("FechaFin").ToString
            If fechafinal = "" Then
                dteFechaFinC.Text = ""
            Else
                dteFechaFinC.EditValue = CDate(Fila(0)("FechaFin"))
            End If
            CodContrato = Fila(0)("CodContrato").ToString
            txtDependencia.RefrescarDatos()
            txtDependencia.ValordelControl = Fila(0)("Dependencia").ToString
            txtOficina.RefrescarDatos()
            txtOficina.ValordelControl = Fila(0)("Oficina").ToString
            txtPlantillas.RefrescarDatos()
            txtPlantillas.ValordelControl = ""
            txtPlantillas.ValordelControl = Fila(0)("Plantilla").ToString
            txtPerfilCta.RefrescarDatos()
            txtPerfilCta.ValordelControl = ""
            txtPerfilCta.ValordelControl = Fila(0)("PerfilCuentas").ToString
            txtCodContrato.ValordelControl = Fila(0)("IdContrato").ToString
            txtNominas.ConsultaSQL = String.Format("SELECT Sec AS Codigo,NomNomina As Descripcion FROM  Nominas Where Oficina=" + txtOficina.ValordelControl)
            txtNominas.RefrescarDatos()
            txtNominas.ValordelControl = Fila(0)("Nomina").ToString
            txtAsignaciones.ValordelControl = Fila(0)("Asignacion").ToString
            txtHorasMes.ValordelControl = Fila(0)("HorasMes").ToString
            LlenaGrillaCargosCon(CodContrato)
            LlenaGrillaCentrosCostos(CodContrato)
            If Fila(0)("UsaAsginaCargo") Then
                cbxAsignacion.SelectedIndex = 1
            Else
                cbxAsignacion.SelectedIndex = 0
            End If
            cbxSalarioIntegral.SelectedIndex = CInt(Fila(0)("SalarioIntegral").ToString)
            cbxSubTipoTrabajador.SelectedIndex = CInt(Fila(0)("SubTipoTrabajador").ToString)
            ActualizandoDatosBasicos = True
            BloqueaOpciones(gvContratos.GetFocusedRowCellValue("CodContrato").ToString)
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "")
        End Try
    End Sub

    Private Sub CreaGrillaContratos()
        gvContratos.Columns.Clear()
        HDevExpre.CreaColumnasG(gvContratos, "CodContrato", "Cod", False, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 0, 0)
        HDevExpre.CreaColumnasG(gvContratos, "IdContrato", "Codigo", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 100, 0, , , , , , , , , , True)
        HDevExpre.CreaColumnasG(gvContratos, "NomEmple", "Empleado", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 300, 0, , , , , , , , , , True)
        HDevExpre.CreaColumnasG(gvContratos, "NomTipoContrato", "Tipo Contrato", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 20, gbxInfBasicaContratos.Width)
        HDevExpre.CreaColumnasG(gvContratos, "NomDependencia", "Dependencia", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 20, gbxInfBasicaContratos.Width)
        HDevExpre.CreaColumnasG(gvContratos, "NomOficina", "Oficina", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 25, gbxInfBasicaContratos.Width)
        HDevExpre.CreaColumnasG(gvContratos, "NomPlantilla", "Perfil Conceptos", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 20, gbxInfBasicaContratos.Width)
        HDevExpre.CreaColumnasG(gvContratos, "NomPerfilCta", "Perfil Cuentas", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 20, gbxInfBasicaContratos.Width)
        HDevExpre.CreaColumnasG(gvContratos, "NomNomina", "Nomina", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 20, gbxInfBasicaContratos.Width)
        HDevExpre.CreaColumnasG(gvContratos, "Asignacion", "Asignacion", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 20, gbxInfBasicaContratos.Width)
        HDevExpre.CreaColumnasG(gvContratos, "HorasMes", "Horas Mes", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 20, gbxInfBasicaContratos.Width)
        HDevExpre.CreaColumnasG(gvContratos, "FechaInicio", "Fecha Inicio", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 20, gbxInfBasicaContratos.Width)
        HDevExpre.CreaColumnasG(gvContratos, "FechaFin", "Fecha Fin", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 20, gbxInfBasicaContratos.Width)
        gvContratos.Appearance.HeaderPanel.Font = New Font("Trebuchet MS", 11.0!, FontStyle.Bold)

    End Sub


    Private Sub CreaColumnasEditable(Grid As GridView, Nombre As String, Titulo As String, Visible As Boolean, Editar As Boolean, formula As String, colores As System.Drawing.Color, numerico As Boolean, Porcentaje_Width As Single, TamañoPadre As Single)
        Try
            Dim gc As New GridColumn
            With gc
                .FieldName = Nombre
                .Name = Nombre
                .Caption = Titulo
                If formula <> "" Then
                    .UnboundExpression = formula
                    .ShowUnboundExpressionMenu = True
                Else
                    .ShowUnboundExpressionMenu = False
                    .GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom
                End If
                If numerico = True Then
                    .UnboundType = DevExpress.Data.UnboundColumnType.Decimal
                    .DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    .DisplayFormat.FormatString = "c2"
                End If
                If Porcentaje_Width > 0 Then
                    .Width = CInt((Porcentaje_Width * (TamañoPadre - 20)) / 100)
                End If
                .AppearanceCell.Options.UseBackColor = True
                .AppearanceCell.BackColor = colores
                .OptionsColumn.AllowSize = True
                .OptionsColumn.AllowMove = True
                If Editar Then
                    .OptionsColumn.AllowEdit = True
                    .OptionsColumn.AllowFocus = True
                    .AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                Else
                    .OptionsColumn.AllowEdit = False
                    .OptionsColumn.AllowFocus = False
                    .AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
                End If
                .OptionsFilter.AllowFilter = False
                .Visible = Visible
                .AppearanceHeader.Options.UseTextOptions = True
                .AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                .AppearanceCell.Options.UseTextOptions = True

            End With
            Grid.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.CellFocus
            Grid.Columns.Add(gc)
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "CreaColumnas")
        End Try
    End Sub

    Public Function ModCargoActual(Contrato As String) As Boolean
        'Dim sql As String = "UPDATE Contratos SET CargoActual=@cargo Where CodContrato=" + Contrato
        'Dim cmd2 As SqlCommand = New SqlCommand(sql, ObjetoApiNomina)
        'cmd2.Parameters.AddWithValue("@cargo", System.DBNull.Value)
        'Dim cant2 As Single = cmd2.ExecuteNonQuery()
        'If cant2 > 0 Then
        '    Return True
        'Else
        '    Return False
        'End If
    End Function

#End Region
#Region "Funciones y Procedimientos --> Funciones del Cargo"

    Private Sub LimpiarCamposCargosContrato()
        Try
            txtCargos.ValordelControl = ""
            dteFechaIniCc.Text = ""
            dteFechaFinCc.Text = ""
            txtCargos.Focus()

        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "LimpiarCamposFunciones")
        End Try
    End Sub

    Private Sub CreaGrillaCargosCon()
        gvCargosContrato.Columns.Clear()
        HDevExpre.CreaColumnasG(gvCargosContrato, "Sec", "Sec", False, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 0, 0)
        HDevExpre.CreaColumnasG(gvCargosContrato, "SecCargo", "SecCargo", False, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 0, 0)
        HDevExpre.CreaColumnasG(gvCargosContrato, "Denominacion", "Cargo", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 40, gbxInfBasicaContratos.Width)
        HDevExpre.CreaColumnasG(gvCargosContrato, "FechaInicio", "Fecha Inicio", True, True, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 30, gbxInfBasicaContratos.Width)
        HDevExpre.CreaColumnasG(gvCargosContrato, "FechaFin", "Fecha Fin", True, True, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 30, gbxInfBasicaContratos.Width)
        gvCargosContrato.Appearance.HeaderPanel.Font = New Font("Trebuchet MS", 11.0!, FontStyle.Bold)

    End Sub

    Private Sub LlenaGrillaCargosCon(contrato As String)
        Try
            Dim sql As String = String.Format("SELECT CC.Sec,CC.Contrato,CC.Cargo As SecCargo,CC.FechaInicio,CC.FechaFin,C.Denominacion FROM Contrato_Cargos CC INNER JOIN Cargos C ON CC.Cargo = C.Sec WHERE Contrato='{0}'", contrato)
            Dim CopyDt As New DataTable
            CopyDt = SMT_AbrirTabla(ObjetoApiNomina, sql)
            For incre As Integer = 0 To CopyDt.Columns.Count - 1
                If CopyDt.Columns(incre).ColumnName = "FechaInicio" Or CopyDt.Columns(incre).ColumnName = "FechaFin" Then
                    CopyDt.Columns(incre).AllowDBNull = False
                End If
            Next
            gcCargosContratos.DataSource = CopyDt
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "LlenaGrillaCargosCon")
        End Try
    End Sub

    Private Function EliminarCargosCon(Sec_CargosCon As String) As Boolean
        Try
            Dim sql = String.Format("DELETE FROM Contrato_Cargos WHERE Sec={0}", Sec_CargosCon)
            If SMT_EjcutarComandoSqlBool(ObjetoApiNomina, sql) > 0 Then
                Return True
            Else : Return False
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "EliminarCargosCon")
            Return False
        End Try
    End Function

    Private Function ValidaCamposCargosContrato() As Boolean
        Dim Tbla As DataTable = CType(gcCargosContratos.DataSource, DataTable)
        If txtCargos.ValordelControl = "" Then
            HDevExpre.MensagedeError("El campo Cargos no puede estar vacío!..")
            txtCargos.Focus()
            Return False
        ElseIf dteFechaIniCc.Text = "" Then
            HDevExpre.MensagedeError("El campo Fecha Inicio no puede estar vacío!..")
            dteFechaIniCc.Focus()
            Return False
        ElseIf dteFechaFinCc.Text = "" Then
            HDevExpre.MensagedeError("El campo Fecha Fin no puede estar vacío!..")
            dteFechaFinCc.Focus()
            Return False
        ElseIf dteFechaFinCc.DateTime < dteFechaIniCc.DateTime Then
            HDevExpre.MensagedeError("La fecha de inicio no puede ser superior a la fecha de finalización!..")
            dteFechaFinCc.Focus()
            Return False
        ElseIf Tbla.Rows.Count > 0 Then
            For incre As Integer = 0 To Tbla.Rows.Count - 1
                If dteFechaIniCc.DateTime >= CDate(Tbla.Rows(incre)("FechaInicio")) And dteFechaIniCc.DateTime <= CDate(Tbla.Rows(incre)("FechaFin")) Or dteFechaFinCc.DateTime >= CDate(Tbla.Rows(incre)("FechaInicio")) And dteFechaFinCc.DateTime <= CDate(Tbla.Rows(incre)("FechaFin")) Or dteFechaIniCc.DateTime < CDate(Tbla.Rows(incre)("FechaInicio")) And dteFechaFinCc.DateTime > CDate(Tbla.Rows(incre)("FechaFin")) Then
                    HDevExpre.MensagedeError("Ya hay un cargo entre estas fechas!..")
                    dteFechaIniCc.Focus()
                    Return False
                End If
            Next
            Return True
        Else
            Return True
        End If
    End Function

#End Region

#Region "Funciones y Procedimientos --> Asignaciones del Cargo"
    Private Sub LimpiarCamposCentrosCosto()
        Try
            txtCentroCostos.ValordelControl = ""
            txtPorcentaje.ValordelControl = ""
            ActualizandoCentrosCostos = False
            SecCentroCosto = ""
            txtCentroCostos.Focus()
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "LimpiarCamposCentrosCosto")
        End Try
    End Sub

    Private Sub CreaGrillACentrosCostos()
        gvCentrosCosto.Columns.Clear()
        HDevExpre.CreaColumnasG(gvCentrosCosto, "Sec", "Sec", False, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 0, 0)
        HDevExpre.CreaColumnasG(gvCentrosCosto, "CentroCosto", "SecCentroCosto", False, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 0, 0)
        HDevExpre.CreaColumnasG(gvCentrosCosto, "Nomcentro", "Centro de Costo", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 40, gbxInfBasicaContratos.Width)
        HDevExpre.CreaColumnasG(gvCentrosCosto, "Porcentaje", "Porcentaje", True, True, "", Color.FromArgb(&HCC, &HFF, &HCC), True, False, 30, gbxInfBasicaContratos.Width)
        gvCentrosCosto.Appearance.HeaderPanel.Font = New Font("Trebuchet MS", 11.0!, FontStyle.Bold)

    End Sub

    Private Sub LlenaGrillaCentrosCostos(contrato As String)
        Try
            Dim sql As String = String.Format("SELECT CC.*,C.Nom_CentroCosto AS Nomcentro FROM Contratos_CentroCostos CC INNER JOIN CT_CentroCostos C ON CC.CentroCosto = C.Sec WHERE Contrato='{0}'", contrato)
            Dim CopyDt As New DataTable
            CopyDt = SMT_AbrirTabla(ObjetoApiNomina, sql)
            For incre As Integer = 0 To CopyDt.Columns.Count - 1
                If CopyDt.Columns(incre).ColumnName = "Porcentaje" Then
                    CopyDt.Columns(incre).AllowDBNull = False
                End If
            Next
            gcCentrosCosto.DataSource = CopyDt
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "LlenaGrillaCentrosCostos")
        End Try
    End Sub

    Private Function EliminarCentrosCostos(Sec_centroC As String) As Boolean
        Try
            Dim sql = String.Format("DELETE FROM Contratos_CentroCostos WHERE Sec={0}", Sec_centroC)
            If SMT_EjcutarComandoSqlBool(ObjetoApiNomina, sql) > 0 Then
                Return True
            Else : Return False
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "EliminarCentrosCostos")
            Return False
        End Try
    End Function

    Private Function ValidaCamposCentrosCosto() As Boolean
        If txtCentroCostos.ValordelControl Is Nothing Then
            HDevExpre.MensagedeError("Eñ campo Centro de costo no puede estar vacío!..")
            txtCentroCostos.Focus()
            Return False
        ElseIf txtPorcentaje.ValordelControl = "" Then
            HDevExpre.MensagedeError("El campo Porcentaje no puede estar vacío!..")
            txtPorcentaje.Focus()
            Return False
        Else
            Return True
        End If
    End Function

#End Region

    Private Sub btnAddTipoContrato_Click(sender As Object, e As EventArgs) Handles btnAddTipoContrato.Click
        Try
            Dim classResize As New ClaseResize
            Dim Frm As New FrmAggTipoContrato
            classResize.Resizamodales(Frm, 80, 70)
            Frm.ShowDialog()
            Frm.BringToFront()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAddCentroCosto_Click(sender As Object, e As EventArgs) Handles btnAddCentroCosto.Click
        Try
            Dim classResize As New ClaseResize
            Dim Frm As New FrmAggCentroCosto
            classResize.Resizamodales(Frm, 80, 70)
            Frm.ShowDialog()
            Frm.BringToFront()

        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "")
        End Try
    End Sub




    Private Sub btnAddDependencia_Click(sender As Object, e As EventArgs) Handles btnAddDependencia.Click
        Try
            Dim classResize As New ClaseResize
            Dim Frm As New FrmAggDependencia
            classResize.Resizamodales(Frm, 80, 70)
            Frm.ShowDialog()
            Frm.BringToFront()

        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "")
        End Try

    End Sub


    Private Sub CreaColumnas(Grid As GridView, Nombre As String, Titulo As String, Visible As Boolean, Porcentaje_Width As Single, TamañoPadre As Single, Editar As Boolean, numerico As Boolean)
        Dim gc As New GridColumn
        With gc
            .FieldName = Nombre
            .Name = Nombre
            .Caption = Titulo
            If numerico = True Then
                .UnboundType = DevExpress.Data.UnboundColumnType.Decimal
                .DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                .DisplayFormat.FormatString = "c2"
            End If
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

    Private Sub gbxInfBasicaContratos_SizeChanged(sender As Object, e As EventArgs) Handles gbxInfBasicaContratos.SizeChanged

    End Sub

    Private Sub gbxInfBasicaCargosContrato_SizeChanged(sender As Object, e As EventArgs) Handles gbxInfBasicaCargosContrato.SizeChanged
        CreaGrillaCargosCon()
    End Sub

    Private Sub gbxInfBasicaCentroC_SizeChanged(sender As Object, e As EventArgs) Handles gbxInfBasicaCentroC.SizeChanged
        CreaGrillACentrosCostos()
    End Sub
    Private Sub btnAggCargosContrato_Click(sender As Object, e As EventArgs) Handles btnAggCargosContrato.Click
        Try

            If ValidaCamposCargosContrato() Then
                Dim Tbla As DataTable = CType(gcCargosContratos.DataSource, DataTable)
                If Tbla.Rows.Count > 0 Then
                    For incre As Integer = 0 To Tbla.Rows.Count - 1
                        If CInt(Tbla.Rows(incre)("SecCargo").ToString) = CInt(txtCargos.ValordelControl) Then
                            HDevExpre.MensagedeError("Este Cargo ya se encuentra agregado..!")
                            Exit Sub
                        End If
                        Dim fechaFinExistente As DateTime = CDate(Tbla.Rows(incre)("FechaFin"))
                        Dim fechaIniExistente As DateTime = CDate(Tbla.Rows(incre)("FechaInicio"))
                        Dim fechaFinNew As DateTime = CDate(dteFechaFinCc.EditValue)
                        Dim fechaIniNew As DateTime = CDate(dteFechaIniCc.EditValue)

                        If DateDiff(DateInterval.Day, fechaFinExistente, fechaIniNew) > 0 Then

                        End If
                    Next
                End If
                Dim NuevaFila As DataRow = Tbla.NewRow()
                NuevaFila("Denominacion") = txtCargos.DescripciondelControl
                NuevaFila("SecCargo") = txtCargos.ValordelControl
                NuevaFila("FechaInicio") = dteFechaIniCc.EditValue
                NuevaFila("FechaFin") = dteFechaFinCc.EditValue
                NuevaFila("Contrato") = "0"
                Tbla.Rows.Add(NuevaFila)
                Tbla.AcceptChanges()
                gcCargosContratos.DataSource = Tbla
                Dim dt As DataTable
                Dim sql As String
                If gvCargosContrato.RowCount = 0 Then
                    txtAsignaciones.ValordelControl = "0"
                ElseIf gvCargosContrato.RowCount = 1 Then
                    sql = String.Format("SELECT Asignacion FROM Cargo_Asignaciones	" +
                    " WHERE Cargo = {0} AND FECHA=(SELECT MAX(FECHA) FROM Cargo_Asignaciones)",
                    gvCargosContrato.GetDataRow(0)("SecCargo"))
                    dt = SMT_AbrirTabla(ObjetoApiNomina, sql)
                    If dt.Rows.Count = 0 Then
                        HDevExpre.MensagedeError("No se registra asignación salarial para el ultimo cargo registrado.")
                        Exit Sub
                    End If
                    txtAsignaciones.ValordelControl = dt.Rows(0)("Asignacion").ToString
                Else
                    Tbla = CType(gcCargosContratos.DataSource, DataTable)
                    Dim maxDate As Object = Tbla.Compute("MAX(FechaInicio)", Nothing)
                    Dim fecha As Date = CDate(maxDate)
                    Dim fila() As DataRow = Tbla.Select("FechaInicio=" + fecha.ToShortDateString)
                    sql = String.Format("SELECT Asignacion FROM {1}..Cargo_Asignaciones	" +
                    " WHERE Cargo = {0} AND FECHA=(SELECT MAX(FECHA) FROM {1}..Cargo_Asignaciones)",
                    fila("SecCargo"))
                    dt = SMT_AbrirTabla(ObjetoApiNomina, sql)
                    If dt.Rows.Count = 0 Then
                        HDevExpre.MensagedeError("No se registra asignación salarial para el ultimo cargo registrado.")
                        Exit Sub
                    End If
                    txtAsignaciones.ValordelControl = dt.Rows(0)("Asignacion").ToString
                End If
                LimpiarCamposCargosContrato()
            End If

        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "btnAggCargosContrato_Click")
        End Try
    End Sub
    Private Sub btnAggCentroCosto_Click(sender As Object, e As EventArgs) Handles btnAggCentroCosto.Click
        Dim Tbla As DataTable = CType(gcCentrosCosto.DataSource, DataTable)
        If ValidaCamposCentrosCosto() Then
            If Tbla.Rows.Count > 0 Then
                For incre As Integer = 0 To Tbla.Rows.Count - 1
                    If CInt(Tbla.Rows(incre)("CentroCosto").ToString) = CInt(txtCentroCostos.ValordelControl) Then
                        HDevExpre.MensagedeError("Este centro de costo ya se encuentra agregado..!")
                        Exit Sub
                    End If
                Next
            End If

            Dim porcentajetotal As Decimal = 0
            For incre As Integer = 0 To Tbla.Rows.Count - 1
                porcentajetotal = porcentajetotal + Convert.ToDecimal(Tbla.Rows(incre)("Porcentaje").ToString)
            Next
            If porcentajetotal < 100 Then
                Dim NuevaFila As DataRow = Tbla.NewRow()

                NuevaFila("NomCentro") = txtCentroCostos.DescripciondelControl
                NuevaFila("CentroCosto") = txtCentroCostos.ValordelControl
                NuevaFila("Porcentaje") = txtPorcentaje.ValordelControl
                NuevaFila("Contrato") = "0"
                NuevaFila("Sec") = "0"
                Tbla.Rows.Add(NuevaFila)
                Tbla.AcceptChanges()
                gcCentrosCosto.DataSource = Tbla
                LimpiarCamposCentrosCosto()

            Else
                HDevExpre.MensagedeError("La suma total de los porcentajes de cada centro de costo a registrar, debe ser un total de 100%!")
            End If

        End If
    End Sub

    Private Sub txtEmpleado_Leave(sender As Object, e As EventArgs) Handles txtEmpleado.Leave
        If txtEmpleado.ValordelControl <> "" And txtEmpleado.DescripciondelControl <> "No Se Encontraron Registros" And txtEmpleado.DescripciondelControl <> "" Then
            LlenaGrillaContratos(txtEmpleado.ValordelControl)
        Else
            LimpiarTodosCampos()
        End If

    End Sub

    Private Sub EliminarCargosContrato_Click(sender As Object, e As EventArgs) Handles btnEliminarCargosContrato.Click
        Try
            Dim Tbla As DataTable = CType(gcCargosContratos.DataSource, DataTable)
            If Tbla.Rows.Count > 0 Then
                If HDevExpre.MsgSamit("Seguro que desea quitar el cargo seleccionado, de este contrato?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.OK Then
                    Tbla.Rows.Remove(Tbla.Rows(gvCargosContrato.FocusedRowHandle))
                    gcCargosContratos.DataSource = Tbla
                End If
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "EliminarCargosContrato_Click")
        End Try
    End Sub

    Private Sub btnEliminarCentroCosto_Click(sender As Object, e As EventArgs) Handles btnEliminarCentroCosto.Click
        Try
            Dim Tbla As DataTable = CType(gcCentrosCosto.DataSource, DataTable)
            If Tbla.Rows.Count > 0 Then
                If HDevExpre.MsgSamit("Seguro que desea quitar el centro de costo seleccionado, de este contrato?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.OK Then
                    Tbla.Rows.Remove(Tbla.Rows(gvCentrosCosto.FocusedRowHandle))
                    gcCentrosCosto.DataSource = Tbla
                End If
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "EliminarCargosContrato_Click")
        End Try
    End Sub

    Private Sub gvCargosContrato_ValidatingEditor(sender As Object, e As BaseContainerValidateEditorEventArgs) Handles gvCargosContrato.ValidatingEditor
        Try
            Dim tbla As DataTable = CType(gcCargosContratos.DataSource, DataTable)
            If Equals(gvCargosContrato.FocusedColumn, gvCargosContrato.Columns("FechaInicio")) Then
                Dim fechaini As DateTime = Convert.ToDateTime(e.Value)
                If fechaini > Convert.ToDateTime(gvCargosContrato.GetFocusedRowCellValue("FechaFin").ToString) Then
                    e.ErrorText = "La fecha de inicio no puede ser superior a la fecha de finalización!.."
                    e.Valid = False
                End If
            End If
            If Equals(gvCargosContrato.FocusedColumn, gvCargosContrato.Columns("FechaFin")) Then
                Dim fechafin As DateTime = Convert.ToDateTime(e.Value)
                If fechafin < Convert.ToDateTime(gvCargosContrato.GetFocusedRowCellValue("FechaInicio").ToString) Then
                    e.ErrorText = "La fecha de finalización no puede ser menor a la fecha de inicio!.."
                    e.Valid = False
                End If
            End If

            If Equals(gvCargosContrato.FocusedColumn, gvCargosContrato.Columns("FechaInicio")) Then
                If tbla.Rows.Count > 0 Then
                    Dim fecha As DateTime = Convert.ToDateTime(e.Value)
                    For incre As Integer = 0 To tbla.Rows.Count - 1
                        If tbla.Rows(incre)("Denominacion").ToString <> gvCargosContrato.GetFocusedRowCellValue("Denominacion").ToString Then
                            If fecha >= CDate(tbla.Rows(incre)("FechaInicio")) And fecha <= CDate(tbla.Rows(incre)("FechaFin")) Or fecha < CDate(tbla.Rows(incre)("FechaInicio")) And gvCargosContrato.GetFocusedRowCellValue("FechaFin") > CDate(tbla.Rows(incre)("FechaFin")) Then
                                e.ErrorText = "Ya hay un cargo entre estas fechas!.."
                                e.Valid = False
                            ElseIf CDate(gvCargosContrato.GetFocusedRowCellValue("FechaFin")) < CDate(tbla.Rows(incre)("FechaFin")) And fecha < CDate(tbla.Rows(incre)("FechaInicio")) And CDate(gvCargosContrato.GetFocusedRowCellValue("FechaFin")) > CDate(tbla.Rows(incre)("FechaInicio")) Then
                                e.ErrorText = "Ya hay un cargo entre estas fechas!.."
                                e.Valid = False
                            End If
                        End If
                    Next
                End If
            End If
            If Equals(gvCargosContrato.FocusedColumn, gvCargosContrato.Columns("FechaFin")) Then
                If tbla.Rows.Count > 0 Then
                    Dim fecha As DateTime = Convert.ToDateTime(e.Value)
                    For incre As Integer = 0 To tbla.Rows.Count - 1
                        If tbla.Rows(incre)("Denominacion").ToString <> gvCargosContrato.GetFocusedRowCellValue("Denominacion").ToString Then
                            If CDate(gvCargosContrato.GetFocusedRowCellValue("FechaInicio")) >= CDate(tbla.Rows(incre)("FechaInicio")) And CDate(gvCargosContrato.GetFocusedRowCellValue("FechaInicio")) <= CDate(tbla.Rows(incre)("FechaFin")) Or CDate(gvCargosContrato.GetFocusedRowCellValue("FechaInicio")) < CDate(tbla.Rows(incre)("FechaInicio")) And fecha > CDate(tbla.Rows(incre)("FechaFin")) Then
                                e.ErrorText = "Ya hay un cargo entre estas fechas!.."
                                e.Valid = False
                            ElseIf fecha < CDate(tbla.Rows(incre)("FechaFin")) And CDate(gvCargosContrato.GetFocusedRowCellValue("FechaInicio")) < CDate(tbla.Rows(incre)("FechaInicio")) And fecha > CDate(tbla.Rows(incre)("FechaInicio")) Then
                                e.ErrorText = "Ya hay un cargo entre estas fechas!.."
                                e.Valid = False
                            End If
                        End If
                    Next
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub dteFechaIniC_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dteFechaIniC.KeyPress, dteFechaFinC.KeyPress
        HDevExpre.AvanzaConEnter(e)
    End Sub

    Private Sub dteFechaIniC_Enter(sender As Object, e As EventArgs) Handles dteFechaIniC.Enter
        HDevExpre.EntraControlDateEditDEV(dteFechaIniC, lblFechaIniC)
        FrmPrincipal.MensajeDeAyuda.Caption = "Digite la fecha del inicio del contrato. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
    End Sub

    Private Sub dteFechaIniC_Leave(sender As Object, e As EventArgs) Handles dteFechaIniC.Leave
        HDevExpre.SaleControlDateEditDEV(dteFechaIniC, lblFechaIniC)
        FrmPrincipal.MensajeDeAyuda.Caption = ""
    End Sub

    Private Sub dteFechaFinC_Enter(sender As Object, e As EventArgs) Handles dteFechaFinC.Enter
        HDevExpre.EntraControlDateEditDEV(dteFechaFinC, lblFechaFinC)
        FrmPrincipal.MensajeDeAyuda.Caption = "Digite la fecha de finalización del contrato. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
    End Sub

    Private Sub dteFechaFinC_Leave(sender As Object, e As EventArgs) Handles dteFechaFinC.Leave
        HDevExpre.SaleControlDateEditDEV(dteFechaFinC, lblFechaFinC)
    End Sub

    Private Sub dteFechaIniCc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dteFechaIniCc.KeyPress, dteFechaFinCc.KeyPress
        HDevExpre.AvanzaConEnter(e)
    End Sub

    Private Sub dteFechaIniCc_Enter(sender As Object, e As EventArgs) Handles dteFechaIniCc.Enter
        HDevExpre.EntraControlDateEditDEV(dteFechaIniCc, lblFechaIniCc)
        FrmPrincipal.MensajeDeAyuda.Caption = "Seleccione la fecha desde cuando aplicará el cargo seleccionado. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
    End Sub

    Private Sub dteFechaIniCc_Leave(sender As Object, e As EventArgs) Handles dteFechaIniCc.Leave
        HDevExpre.SaleControlDateEditDEV(dteFechaIniCc, lblFechaIniCc)
        FrmPrincipal.MensajeDeAyuda.Caption = ""
    End Sub

    Private Sub dteFechaFinCc_Enter(sender As Object, e As EventArgs) Handles dteFechaFinCc.Enter
        HDevExpre.EntraControlDateEditDEV(dteFechaFinCc, lblFechaFinCc)
        FrmPrincipal.MensajeDeAyuda.Caption = "Seleccione la fecha hasta cuando aplicara el cargo seleccionado. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
    End Sub

    Private Sub dteFechaFinCc_Leave(sender As Object, e As EventArgs) Handles dteFechaFinCc.Leave
        HDevExpre.SaleControlDateEditDEV(dteFechaFinCc, lblFechaFinCc)
        'btnAggCargosContrato.Focus()
    End Sub

    Private Sub txtOficina_Leave(sender As Object, e As EventArgs) Handles txtOficina.Leave
        If txtOficina.ValordelControl <> "" And txtOficina.DescripciondelControl <> "No Se Encontraron Registros" And txtOficina.DescripciondelControl <> "" Then
            Dim valor As String = txtNominas.ValordelControl
            txtNominas.ValordelControl = ""
            txtNominas.ConsultaSQL = String.Format("SELECT Sec AS Codigo,NomNomina As Descripcion FROM  Nominas Where Oficina=" + txtOficina.ValordelControl)
            txtNominas.RefrescarDatos()
            txtNominas.ValordelControl = valor
        Else
            Dim valor As String = txtNominas.ValordelControl
            txtNominas.ValordelControl = ""
            txtNominas.ConsultaSQL = String.Format("SELECT SecNomina AS Codigo,NomNomina As Descripcion FROM  Nominas Where Oficina=0")
            txtNominas.RefrescarDatos()
            txtNominas.ValordelControl = valor
        End If
    End Sub

    Private Sub FrmContrato_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        FormularioAbierto = False
    End Sub

    Private Sub txtEmpleado_Enter(sender As Object, e As EventArgs) Handles txtEmpleado.Enter
        LimpiarTodosCampos()
    End Sub

    Private Sub FrmContrato_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If ActualizandoDatosBasicos Then
            If HDevExpre.MsgSamit("Se están modificando datos, Seguro que desea cerrar el formulario?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Cancel Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub txtPorcentaje_Leave(sender As Object, e As EventArgs) Handles txtPorcentaje.Leave
        'btnAggCentroCosto.Focus()
    End Sub

    Private Sub ckeUsaCodigo_Enter(sender As Object, e As EventArgs)
        'Try
        '    Dim ck As DevExpress.XtraEditors.CheckEdit = CType(sender, DevExpress.XtraEditors.CheckEdit)
        '    ck.Font = New Font(ck.Font.FontFamily, ck.Font.Size, FontStyle.Bold)
        '    ck.BorderStyle = BorderStyles.HotFlat
        '    ck.BackColor = Datos.ColordeFondoTxtFoco
        '    If Equals(ck, ckeUsaCodigo) Then
        '        FrmPrincipal.MensajeDeAyuda.Caption = "Seleccione si desea digitar el código del contrato de manera manual. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
        '    Else
        '        FrmPrincipal.MensajeDeAyuda.Caption = "Seleccione si desea generar el código del contrato de manera automática. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
        '    End If
        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub ckeUsaCodigo_KeyPress(sender As Object, e As KeyPressEventArgs)
        HDevExpre.AvanzaConEnter(e)
    End Sub

    Private Sub ckeUsaCodigo_Leave(sender As Object, e As EventArgs)
        Try
            Dim ck As DevExpress.XtraEditors.CheckEdit = CType(sender, DevExpress.XtraEditors.CheckEdit)
            ck.Font = New Font(ck.Font.FontFamily, ck.Font.Size, FontStyle.Regular)
            ck.BorderStyle = BorderStyles.Default
            ck.BackColor = Color.Transparent
            FrmPrincipal.MensajeDeAyuda.Caption = ""
        Catch ex As Exception

        End Try
    End Sub



    Private Sub grbAsignacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxAsignacion.SelectedIndexChanged
        If cbxAsignacion.SelectedIndex = 1 Then
            If gvCargosContrato.RowCount > 0 Then
                Dim dt As DataTable
                Dim sql As String
                txtAsignaciones.Enabled = False
                If gvCargosContrato.RowCount = 0 Then
                    txtAsignaciones.ValordelControl = "0"
                ElseIf gvCargosContrato.RowCount = 1 Then
                    sql = String.Format("SELECT Asignacion FROM {1}..Cargo_Asignaciones	" +
                    " WHERE Cargo = {0} AND FECHA=(SELECT MAX(FECHA) FROM {1}..Cargo_Asignaciones WHERE Cargo = {0})",
                    gvCargosContrato.GetDataRow(0)("SecCargo"))
                    dt = SMT_AbrirTabla(ObjetoApiNomina, sql)
                    If dt.Rows.Count = 0 Then
                        HDevExpre.MensagedeError("No se registra asignación salarial para el ultimo cargo registrado.")
                        cbxAsignacion.SelectedIndex = 0
                        Exit Sub
                    End If
                    txtAsignaciones.ValordelControl = dt.Rows(0)("Asignacion").ToString
                Else
                    dt = CType(gcCargosContratos.DataSource, DataTable)
                    Dim maxDate As Object = dt.Compute("MAX(FechaInicio)", Nothing)
                    Dim fecha As Date = CDate(maxDate)
                    Dim fila() As DataRow = dt.Select("FechaInicio=" + fecha.ToShortDateString)
                    sql = String.Format("SELECT Asignacion FROM {1}..Cargo_Asignaciones	" +
                    " WHERE Cargo = {0} AND FECHA=(SELECT MAX(FECHA) FROM {1}..Cargo_Asignaciones)",
                    fila("SecCargo"))
                    dt = SMT_AbrirTabla(ObjetoApiNomina, sql)
                    If dt.Rows.Count = 0 Then
                        HDevExpre.MensagedeError("No se registra asignación salarial para el ultimo cargo registrado.")
                        cbxAsignacion.SelectedIndex = 0
                        Exit Sub
                    End If
                    txtAsignaciones.ValordelControl = dt.Rows(0)("Asignacion").ToString
                End If
            Else
                HDevExpre.MensagedeError("Este Contrato no tiene cargos asignados, por favor asignar uno.")
                cbxAsignacion.SelectedIndex = 0
                txtAsignaciones.Enabled = True
                txtAsignaciones.Focus()
            End If
        Else
            cbxAsignacion.SelectedIndex = 0
            txtAsignaciones.Enabled = True
            txtAsignaciones.Focus()
        End If
    End Sub

    Private Sub gvCargosContrato_RowCountChanged(sender As Object, e As EventArgs) Handles gvCargosContrato.RowCountChanged
        Try

        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "gvCargosContrato_RowCountChanged")
        End Try
    End Sub

    Private Sub gvCentrosCosto_ValidatingEditor(sender As Object, e As BaseContainerValidateEditorEventArgs) Handles gvCentrosCosto.ValidatingEditor
        Try
            Dim sum As Decimal = 0
            If CDec(e.Value) > 100 Then
                e.Valid = False
                HDevExpre.MensagedeError("El porcentaje no puede ser mayor a 100%")
                Exit Sub
            End If
            For i = 0 To gvCentrosCosto.RowCount - 1
                Dim val As Decimal = CDec(gvCentrosCosto.GetDataRow(i)("Porcentaje"))
                If i = gvCentrosCosto.FocusedRowHandle Then
                    val = 0
                End If
                sum += val
            Next
            If (CDec(e.Value) + sum) > 100 Then
                HDevExpre.MensagedeError("La sumatoria de porcentajes es mayor que 100%, verifique e intente de nuevo.")
                e.Valid = False
                Exit Sub
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "gvCentrosCosto_ValidatingEditor")
        End Try
    End Sub



    Private Sub rgbTipoCodigo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxTipoCodigo.SelectedIndexChanged
        If cbxTipoCodigo.SelectedIndex = 0 Then
            txtCodContrato.Enabled = True
            txtCodContrato.ValordelControl = CodContrato
            txtCodContrato.Focus()
        Else
            txtCodContrato.ValordelControl = SMT_AbrirTabla(ObjetoApiNomina, "SELECT ISNULL( MAX (CodContrato),0)+1 AS Codigo FROM  Contratos").Rows(0)(0).ToString
            txtCodContrato.Enabled = False
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Label1.Visible Then
            Label1.Visible = False
        Else
            Label1.Visible = True
        End If
    End Sub

    Private Sub grbAsignacion_Enter(sender As Object, e As EventArgs) Handles cbxAsignacion.Enter
        HDevExpre.EntraControlCbxDEV(cbxAsignacion, lblAsignacion)
    End Sub

    Private Sub cbxAsignacion_Leave(sender As Object, e As EventArgs) Handles cbxAsignacion.Leave
        HDevExpre.SaleControlCbxDEV(cbxAsignacion, lblAsignacion)
    End Sub

    Private Sub cbxTipoCodigo_Enter(sender As Object, e As EventArgs) Handles cbxTipoCodigo.Enter
        HDevExpre.EntraControlCbxDEV(cbxTipoCodigo, lblUsaCodigo)
    End Sub
    Private Sub cbxTipoCodigo_Leave(sender As Object, e As EventArgs) Handles cbxTipoCodigo.Leave
        HDevExpre.SaleControlCbxDEV(cbxTipoCodigo, lblUsaCodigo)
    End Sub

    Private Sub cbxAsignacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxTipoCodigo.KeyPress, cbxAsignacion.KeyPress
        HDevExpre.AvanzaConEnter(e)
    End Sub

    Private Sub btnSalir_KeyPress(sender As Object, e As KeyPressEventArgs) Handles btnSalir.KeyPress, btnLimpiar.KeyPress, btnGuardar.KeyPress, btnEliminar.KeyPress, btnAggCentroCosto.KeyPress, btnAggCargosContrato.KeyPress
        HDevExpre.AtrasConScape(e)
    End Sub

    Private Sub BtnConsultaTerCC_Click(sender As Object, e As EventArgs) Handles BtnConsultaTerCC.Click
        Dim TerSinCC As New ClErrores, Sql As String = ""
        Sql = $"select con.codcontrato, con.empleado, emp.Identificacion as Identificacion, (emp.PNombre + ' ' + emp.SNombre + ' ' + emp.papellido + ' ' + emp.sapellido) as      NomnreEmpleado
                from Contratos con left join Empleados emp on emp.Sec = con.Empleado
                where CodContrato not in(select contrato from Contratos_CentroCostos)"
        Dim dt = SMT_AbrirTabla(ObjetoApiNomina, Sql)
        For Each fila In dt.Rows
            TerSinCC.Agregar_Error($"Contrato {fila!Codcontrato}", $"Empleado : '{fila!Identificacion}' No tiene Asignado centro de costos")
        Next
        TerSinCC.Presentar_Informe()
    End Sub
End Class
