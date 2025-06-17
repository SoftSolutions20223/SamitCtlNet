Option Strict Off
Imports System.ComponentModel
Imports System.Text
Imports DevExpress.Utils
Imports SamitCtlNet
Imports DevExpress.LookAndFeel
Imports DevExpress.XtraEditors
Imports DevExpress.XtraBars


Partial Public Class FrmPrincipal
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm
    Dim HDevExpre As New HelperDevExpress
    Dim HNomina As New HelperNomina
    Dim TipBtnConexion As New SuperToolTipSetupArgs
    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()
    End Sub
    Public Sub New()
        InitializeComponent()
        ObjetosNomina.UltimoSkin = ObjetosNomina.Datos.RegistroSAMIT.Leer_Clave_Del_Registro("Administrador", "Skin", "")
        UserLookAndFeel.Default.SkinName = ObjetosNomina.UltimoSkin
    End Sub

    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AcomodaForm()
        AsignaSuperTipAcontroles()
        Me.AutoScaleDimensions = New System.Drawing.SizeF(100.0F, 110.0F)
        Me.PerformAutoScale()
        InHabilitaBotones()

        'AddHandler Datos.SmtConexionMod.StateChange, AddressOf ConnectionOnStateChange
    End Sub
    Private Sub ConnectionOnStateChange(sender As Object, e As StateChangeEventArgs)

        HDevExpre.MensagedeError(
         String.Format("El estado original de la conexión era: {0},{1}y su estado actual es: {2}",
                       e.OriginalState, Environment.NewLine, e.CurrentState))

    End Sub
    Private Sub FrmPrincipal_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        ObjetosNomina.UltimoSkin = UserLookAndFeel.Default.SkinName
        ObjetosNomina.Datos.RegistroSAMIT.Guardar_Clave_Del_Registro("Administrador", "Skin", ObjetosNomina.UltimoSkin)
    End Sub
    Private Sub FrmPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Not HDevExpre.MsgSamit("La aplicación cerrara por completo, Desea continuar?...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.OK Then
            e.Cancel = True
        End If
    End Sub
    Private Sub btnConexion_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnConexion.ItemClick
        Conectar(btnConexion.Caption)
    End Sub
    Public Sub Desconectar()
        Try
            ObjetosNomina.Datos.Seguridad.TerminarConexion()
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "Desconectar")
        End Try
    End Sub
    Private Sub AcomodaForm()
        Try
            'PONE TIPO DE LETRA A TODOS LOS BarButtonItem
            Try
                For i = 0 To rcPrincipal.Items.Count - 1
                    Dim ctrl As BarItem = rcPrincipal.Items.Item(i)
                    If ctrl.GetType = GetType(DevExpress.XtraBars.BarButtonItem) Or ctrl.GetType = GetType(DevExpress.XtraBars.BarSubItem) Then
                        ctrl.ItemAppearance.Disabled.Font = New System.Drawing.Font("Tahoma", 9.25!)
                        ctrl.ItemAppearance.Disabled.Options.UseFont = True
                        ctrl.ItemAppearance.Hovered.Font = New System.Drawing.Font("Tahoma", 9.25!)
                        ctrl.ItemAppearance.Hovered.Options.UseFont = True
                        ctrl.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.25!)
                        ctrl.ItemAppearance.Normal.Options.UseFont = True
                        ctrl.ItemAppearance.Pressed.Font = New System.Drawing.Font("Tahoma", 9.25!)
                        ctrl.ItemAppearance.Pressed.Options.UseFont = True
                    End If
                Next
                rcPrincipal.Manager.ShowScreenTipsInMenus = True


            Catch ex As Exception
                HDevExpre.msgError(ex, ex.Message, "Cargue")
                Exit Try
            End Try

            'Img 16X16
            'menuOpciones.Glyph = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Opciones)
            'menuEmpleados.Glyph = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Empleados)
            btnConexionMenu.Glyph = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Conectar)
            btnCambiaFecha.Glyph = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.CambiaFecha)
            btnCambiaClave.Glyph = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.CambiaClave)
            btnCambiaFechaMenu.Glyph = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.CambiaFecha)
            btnCambiaClaveMenu.Glyph = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.CambiaClave)
            btnNuevoEmpMenu.Glyph = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.OpcionesEmpleados)
            btnNuevoEmpleado.Glyph = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.AgregarRound)
            BarButtonItem2.Glyph = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Lista)
            btnAggContratos.Glyph = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.AgregarRound)
            btnAsigValoresExentos.Glyph = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Excento)
            btnAsigDescuentos.Glyph = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Descuento)
            btnAsigNominas.Glyph = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.CargosContrato)
            btnModAsignaSalariales.Glyph = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.EditaPersona)
            BarSubItem5.Glyph = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.ConceptosNomina)
            BarButtonItem47.Glyph = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.ConceptosPersonales)
            BarButtonItem38.Glyph = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.AgregarRound)
            BarSubItem7.Glyph = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.PerfilConceptos)
            btnPerfilConceptos.Glyph = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.AgregarRound)
            btnAsigValorMaximo.Glyph = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Dinero)
            BarButtonItem48.Glyph = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.ImportaEmpleado)
            BarSubItem8.Glyph = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.GeneraPeriodos)
            BarButtonItem45.Glyph = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.GenerarPeriodos)
            BarButtonItem46.Glyph = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.BuscarPeriodos)
            btnSubLiquidacionPeriodos.Glyph = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Liquidaciones)
            btnSubLiquidacionPrestaciones.Glyph = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Liquidaciones)
            btnLiquidacionExtraordinaria.Glyph = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Liquidaciones)
            btnSubLiquidaContratos.Glyph = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Liquidaciones)
            btnLiquidarPeriodo.Glyph = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.LiquidarContrato)
            bntLiquidarPrestaciones.Glyph = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.LiquidarContrato)
            btnLiquidarContratos.Glyph = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.LiquidarContrato)
            btnConfigurarLiquidaPeriodos.Glyph = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.FormulasLiquidaciones)
            btnConfigLiquidaPrestaciones.Glyph = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.FormulasLiquidaciones)
            btnConfigNomina.Glyph = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.ConfigLiquidaciones)
            btnConfigLiquidacion.Glyph = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.ConfigLiquidaciones)
            btnConsultarLiquidacion.Glyph = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Lupa)
            BarSubItem2.Glyph = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.TabsCatalogo)
            BarButtonItem21.Glyph = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.TabsCatalogo)
            BarButtonItem22.Glyph = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.TabsCatalogo)
            BarButtonItem23.Glyph = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.TabsCatalogo)
            BarButtonItem24.Glyph = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.TabsCatalogo)
            BarButtonItem25.Glyph = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.TabsCatalogo)
            BarButtonItem26.Glyph = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.TabsCatalogo)
            BarButtonItem27.Glyph = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.TabsCatalogo)
            BarButtonItem28.Glyph = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.TabsCatalogo)
            BarButtonItem14.Glyph = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Bancos)
            BarButtonItem15.Glyph = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Entidades)
            BarSubItem3.Glyph = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.DatosBasicosEmleados)
            BarButtonItem31.Glyph = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.AgregarRound)
            BarButtonItem32.Glyph = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Afiliaciones)
            BarButtonItem44.Glyph = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.PCargos)
            BarButtonItem17.Glyph = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.TipoContra)
            BarButtonItem18.Glyph = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Dependencias)
            BarButtonItem19.Glyph = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Dependencias)
            BarButtonItem29.Glyph = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Formulas)
            BarSubItem4.Glyph = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Formulas)
            BarButtonItem34.Glyph = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.FormulasLiquidaciones)
            BarButtonItem35.Glyph = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.FormulasLiquidaciones)
            BarButtonItem39.Glyph = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.ConceptosNomina)
            BarButtonItem43.Glyph = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.CargosContrato)
            BarButtonItem12.Glyph = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Excento)



            'Img 32X32
            btnConexion.Glyph = HDevExpre.Imagen_boton32X32(HDevExpre.ImagenesSamit32X32.Conectar)
            menuEmpleado.Glyph = HDevExpre.Imagen_boton32X32(HDevExpre.ImagenesSamit32X32.Empleados2)
            btnContratos.Glyph = HDevExpre.Imagen_boton32X32(HDevExpre.ImagenesSamit32X32.Contratos2)
            bsiConceptos.Glyph = HDevExpre.Imagen_boton32X32(HDevExpre.ImagenesSamit32X32.Conceptos)
            bsiLiquidaciones.Glyph = HDevExpre.Imagen_boton32X32(HDevExpre.ImagenesSamit32X32.Liquidar)
            btnConfiguracion.Glyph = HDevExpre.Imagen_boton32X32(HDevExpre.ImagenesSamit32X32.Configurar)
            btnNominas.Glyph = HDevExpre.Imagen_boton32X32(HDevExpre.ImagenesSamit32X32.AsignarNominas)
            'menuOpcNomina.Glyph = Imagen_boton32X32(ImagenesSamit32X32.OpcionesNomina)
            'btnNovedades.Glyph = Imagen_boton32X32(ImagenesSamit32X32.Novedades)
            'btnLiquidar.Glyph = Imagen_boton32X32(ImagenesSamit32X32.Liquidar)
            btnSalir.Glyph = HDevExpre.Imagen_boton32X32(HDevExpre.ImagenesSamit32X32.Salir)
            'btnImpNom.Glyph = Imagen_boton32X32(ImagenesSamit32X32.Imprimir)
            'btnPlantaCargos.Glyph = Imagen_boton32X32(ImagenesSamit32X32.PlantaCargos)
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "AcomodaForm")
        End Try
    End Sub

    Private Sub AsignaSuperTipAcontroles()
        Try
            Dim Mensaje As String = ""
            menuEmpleado.SuperTip = HDevExpre.SMT_AsignaSupertToolTip("Creación del trabajador que desempeña algún cargo o servicio bajo órdenes de una empresa o particular.")
            btnContratos.SuperTip = HDevExpre.SMT_AsignaSupertToolTip("Acuerdo de voluntades, las cuales se aceptan obligaciones y derechos sobre alguna función específica.")
            bsiConceptos.SuperTip = HDevExpre.SMT_AsignaSupertToolTip("Elementos que se liquidan mensualmente o quincenal en una nomina y se deben pagar, deducir o provisionar al trabajador.")
            btnNominas.SuperTip = HDevExpre.SMT_AsignaSupertToolTip("Pagos mensuales o quincenales que las empresas deben realizar a los trabajadores que tienen vinculados mediante contrato de trabajo.")
            bsiLiquidaciones.SuperTip = HDevExpre.SMT_AsignaSupertToolTip("Dinero que en concepto de paga, recibe regularmente una persona de la empresa o entidad para la que trabaja.")
            Mensaje = "Permite Agregar, Modificar o Eliminar Nóminas, estas sirven para agrupar contratos que se liquidan de la manera similar y en los mismos periodos"
            btnAggNominas.SuperTip = HDevExpre.SMT_AsignaSupertToolTip(Mensaje, "Agrear Nominas a la Empresa")
            BarButtonItem2.SuperTip = HDevExpre.SMT_AsignaSupertToolTip("Lista de empleados con toda su configuración para exportarla a Excel.")
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "AsignaSqlAcontroles")
        End Try
    End Sub

    Private Sub HabilitaBotones()
        btnCambiaClave.Enabled = True
        btnCambiaFecha.Enabled = True
        rpgEmpleados.Enabled = True
        rpgContratos.Enabled = True
        rpgConceptos.Enabled = True
        rpgLiquidaciones.Enabled = True
        rpgConfig.Enabled = True
        rpgNomina.Enabled = True
        'menuEmpleados.Enabled = True
        btnCambiaClaveMenu.Enabled = True
        btnCambiaFechaMenu.Enabled = True
        'btnPlantaCargos.Enabled = True
    End Sub

    Private Sub InHabilitaBotones()
        btnCambiaClave.Enabled = False
        btnCambiaFecha.Enabled = False
        rpgEmpleados.Enabled = False
        rpgContratos.Enabled = False
        rpgConceptos.Enabled = False
        rpgLiquidaciones.Enabled = False
        rpgConfig.Enabled = False
        rpgNomina.Enabled = False
        'menuEmpleados.Enabled = False
        btnCambiaClaveMenu.Enabled = False
        btnCambiaFechaMenu.Enabled = False
        'btnPlantaCargos.Enabled = False
    End Sub
    Public Sub ValidaMdiParent()
        On Error GoTo MsgError
        'If Me.MdiChildren.Length = 0 Then
        '    TabManagerPrincipal.MdiParent = Nothing
        'Else
        '    TabManagerPrincipal.MdiParent = Me
        'End If
        Exit Sub
MsgError:
        MensajedeError("ValidaMdiParent")
    End Sub
    Private Sub btnNuevoEmp_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNuevoEmpleado.ItemClick
        Dim wait As New ClEspera
        If HDevExpre.EstaCargadoFormulario("FrmEmpleado") Then Exit Sub
        Dim Frm As New FrmEmpleado
        Try
            wait.Mostrar()
            wait.Descripcion = "Cargando datos..."
            Frm.MdiParent = Me
            Frm.Show()
            wait.Terminar()
            ' FrmEmpleado.MdiParent = Me
            'FrmEmpleado.Show()
            'FrmEmpleado.BringToFront()
            'ValidaMdiParent()
            'Dim classResize As New ClaseResize

            'If FrmEmpleado.P_FormularioAbierto Then
            '    FrmEmpleado.MdiParent = Me
            '    FrmEmpleado.Show()
            '    FrmEmpleado.BringToFront()
            '    ValidaMdiParent()
            'Else
            '    FrmEmpleado.MdiParent = Me
            '    FrmEmpleado.P_FormularioAbierto = True
            '    classResize.ResizeForm(FrmEmpleado)
            '    FrmEmpleado.Show()
            '    FrmEmpleado.BringToFront()
            '    ValidaMdiParent()
            'End If

        Catch ex As Exception
            wait.Terminar()
        End Try

    End Sub
    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        FrmListaEmpleados.MdiParent = Me
        FrmListaEmpleados.Show()
        FrmListaEmpleados.BringToFront()
        ValidaMdiParent()
    End Sub

    Private Sub btnNuevoEmpMenu_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNuevoEmpMenu.ItemClick
        FrmEmpleado.MdiParent = Me
        FrmEmpleado.Show()
        FrmEmpleado.BringToFront()
        ValidaMdiParent()
    End Sub

    Private Sub btnConexionMenu_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnConexionMenu.ItemClick
        Conectar(btnConexionMenu.Caption)
    End Sub
    Private Sub Conectar(Conectado As String)
        Try
            TipBtnConexion.Title.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.IconSamit)
            TipBtnConexion.Title.Text = "Mensaje SAMIT Sql"
            ObjetosNomina.Datos.Smt_NumeroModulo = 25
            If Conectado = "Conectar" Then
                'Datos.SmtPasswdSeg = "NRAMJDZP-ij@1207"
                'Datos.SmtPasswdModulo = "NRAMJDZP-ij@1207"
                'MsgBox(My.Application.Info.Version.Build & vbCrLf & My.Application.Info.Version.Revision)

                FrmLogin.ShowDialog()
                FrmLogin.BringToFront()

                If ObjetosNomina.InicioConexionModulo Then
                    NumEmpresa.Caption = ObjetosNomina.Datos.Seguridad.DatosDeLaEmpresa.NumEmpresa.ToString
                    NumOficina.Caption = ObjetosNomina.Datos.Seguridad.DatosDeLaEmpresa.OficinaIngreso.NumOficina.ToString
                    FechaTrabajo.Caption = ObjetosNomina.Datos.Smt_FechaDeTrabajo.ToString("dd/MM/yyyy")
                    btnConexion.Caption = "Desconectar"
                    btnConexionMenu.Caption = "Desconectar"
                    btnConexion.Glyph = HDevExpre.Imagen_boton32X32(HDevExpre.ImagenesSamit32X32.Desconectar)
                    btnConexionMenu.Glyph = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Desconectar)
                    ObjetosNomina.Datos.BarraMensajeAyuda = MensajeDeAyuda
                    HabilitaBotones()
                    TipBtnConexion.Contents.Text = "Terminar Conexión"
                    btnConexion.SuperTip.Setup(TipBtnConexion)
                Else

                End If
            ElseIf Conectado = "Desconectar" Then
                If HDevExpre.MsgSamit("¿Esta seguro que desea Desconactarse?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, "Salir del Sistema") = DialogResult.Yes Then
                    For i = 0 To Me.MdiChildren.Length - 1
                        Dim forma As Form = DirectCast(Me.MdiChildren(Me.MdiChildren.Length - 1), Form)
                        forma.Close()
                    Next
                    Desconectar()
                    btnConexion.Caption = "Conectar"
                    btnConexionMenu.Caption = "Conectar"
                    NumEmpresa.Caption = "Mensaje de ayuda."
                    NumOficina.Caption = "0"
                    FechaTrabajo.Caption = "dd/MM/yyyy"
                    btnConexion.Glyph = HDevExpre.Imagen_boton32X32(HDevExpre.ImagenesSamit32X32.Conectar)
                    btnConexionMenu.Glyph = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Conectar)
                    TipBtnConexion.Contents.Text = "Iniciar Conexión"
                    btnConexion.SuperTip.Setup(TipBtnConexion)
                    ObjetosNomina.UltimoSkin = UserLookAndFeel.Default.SkinName
                    ObjetosNomina.Desconectar()
                    InHabilitaBotones()

                Else

                End If
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnNuevoCon_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        Try
            Dim classResize As New ClaseResize
            If FrmContrato.P_FormularioAbierto Then
                FrmContrato.MdiParent = Me
                FrmContrato.Show()
                FrmContrato.BringToFront()
                ValidaMdiParent()
            Else
                FrmContrato.MdiParent = Me
                FrmContrato.P_FormularioAbierto = True
                classResize.ResizeForm(FrmContrato)
                FrmContrato.Show()
                FrmContrato.BringToFront()
                ValidaMdiParent()
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "")
        End Try
    End Sub

    Private Sub btnNuevoCargo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        Try
            Dim classResize As New ClaseResize
            If FrmCargo.P_FormularioAbierto Then
                FrmCargo.MdiParent = Me
                FrmCargo.Show()
                FrmCargo.BringToFront()
                ValidaMdiParent()
            Else
                FrmCargo.MdiParent = Me
                FrmCargo.P_FormularioAbierto = True
                classResize.ResizeForm(FrmCargo)
                FrmCargo.Show()
                FrmCargo.BringToFront()
                ValidaMdiParent()
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "")
        End Try
    End Sub

    Private Sub BbtnNovedades_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        Try
            Dim classResize As New ClaseResize
            If FrmAggNovedades.P_FormularioAbierto Then
                FrmAggNovedades.MdiParent = Me
                FrmAggNovedades.Show()
                FrmAggNovedades.BringToFront()
                ValidaMdiParent()
            Else
                FrmAggNovedades.MdiParent = Me
                FrmAggNovedades.P_FormularioAbierto = True
                classResize.ResizeForm(FrmAggNovedades)
                FrmAggNovedades.Show()
                FrmAggNovedades.BringToFront()
                ValidaMdiParent()
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "")
        End Try
    End Sub

    Private Sub btnValGenerales_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnValGenerales.ItemClick
        Dim classResize As New ClaseResize
        If FrmAggVariablesGenerales.P_FormularioAbierto Then
            FrmAggVariablesGenerales.ShowDialog()
            FrmAggVariablesGenerales.BringToFront()
        Else
            FrmAggVariablesGenerales.P_FormularioAbierto = True
            classResize.Resizamodales(FrmAggVariablesGenerales, 70, 70)
            classResize.ResizeForm(FrmAggVariablesGenerales)
            FrmAggVariablesGenerales.ShowDialog()
            FrmAggVariablesGenerales.BringToFront()
        End If

    End Sub

    Private Sub btnValPersonales_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnValPersonales.ItemClick
        Dim classResize As New ClaseResize
        If FrmAggVariablesPersonales.P_FormularioAbierto Then
            FrmAggVariablesPersonales.ShowDialog()
            FrmAggVariablesPersonales.BringToFront()
        Else
            FrmAggVariablesPersonales.P_FormularioAbierto = True
            classResize.Resizamodales(FrmAggVariablesPersonales, 50, 70)
            classResize.ResizeForm(FrmAggVariablesPersonales)
            FrmAggVariablesPersonales.ShowDialog()
            FrmAggVariablesPersonales.BringToFront()
        End If
    End Sub

    'Private Sub btnBases_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBases.ItemClick
    '    Dim classResize As New ClaseResize
    '    If FrmAggBases.P_FormularioAbierto Then
    '        FrmAggBases.ShowDialog()
    '        FrmAggBases.BringToFront()
    '    Else
    '        FrmAggBases.P_FormularioAbierto = True
    '        classResize.Resizamodales(FrmAggBases)
    '        classResize.ResizeForm(FrmAggBases)
    '        FrmAggBases.ShowDialog()
    '        FrmAggBases.BringToFront()
    '    End If
    'End Sub

    Private Sub btnConceptos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnConceptos.ItemClick
        Dim classResize As New ClaseResize
        If FrmAggConceptosNomina.P_FormularioAbierto Then
            FrmAggConceptosNomina.ShowDialog()
            FrmAggConceptosNomina.BringToFront()
        Else
            FrmAggConceptosNomina.P_FormularioAbierto = True
            classResize.Resizamodales(FrmAggConceptosNomina, 70, 80)
            'classResize.VerificaTabControl(FrmAggConceptosNomina)
            classResize.ResizeForm(FrmAggConceptosNomina)
            FrmAggConceptosNomina.ShowDialog()
            FrmAggConceptosNomina.BringToFront()
        End If
    End Sub

    Private Sub btnTipoConceptos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnTipoConceptos.ItemClick
        Dim classResize As New ClaseResize
        If FrmAggClasConceptosNomina.P_FormularioAbierto Then
            FrmAggClasConceptosNomina.ShowDialog()
            FrmAggClasConceptosNomina.BringToFront()
        Else
            FrmAggClasConceptosNomina.P_FormularioAbierto = True
            classResize.Resizamodales(FrmAggClasConceptosNomina, 50, 70)
            classResize.ResizeForm(FrmAggClasConceptosNomina)
            FrmAggClasConceptosNomina.ShowDialog()
            FrmAggClasConceptosNomina.BringToFront()
        End If
    End Sub

    Private Sub btnPlantillas_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPlantillas.ItemClick
        Dim classResize As New ClaseResize
        If FrmAggPlantillas.P_FormularioAbierto Then
            FrmAggPlantillas.ShowDialog()
            FrmAggPlantillas.BringToFront()
        Else
            FrmAggPlantillas.P_FormularioAbierto = True
            classResize.Resizamodales(FrmAggPlantillas, 80, 70)
            classResize.ResizeForm(FrmAggPlantillas)
            FrmAggPlantillas.ShowDialog()
            FrmAggPlantillas.BringToFront()
        End If
    End Sub

    Private Sub btnAsigNominas_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim classResize As New ClaseResize
        If FrmNominasContratos.P_FormularioAbierto Then
            FrmNominasContratos.ShowDialog()
            FrmNominasContratos.BringToFront()
        Else
            FrmNominasContratos.P_FormularioAbierto = True
            classResize.Resizamodales(FrmNominasContratos, 50, 70)
            classResize.ResizeForm(FrmNominasContratos)
            FrmNominasContratos.ShowDialog()
            FrmNominasContratos.BringToFront()
        End If
    End Sub

    Private Sub btnLiquidar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        Try
            Dim classResize As New ClaseResize
            If FrmLiquidarNomina.P_FormularioAbierto Then
                FrmLiquidarNomina.MdiParent = Me
                FrmLiquidarNomina.Show()
                FrmLiquidarNomina.BringToFront()
                ValidaMdiParent()
            Else
                FrmLiquidarNomina.MdiParent = Me
                FrmLiquidarNomina.P_FormularioAbierto = True
                classResize.ResizeForm(FrmLiquidarNomina)
                FrmLiquidarNomina.Show()
                FrmLiquidarNomina.BringToFront()
                ValidaMdiParent()
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "")
        End Try
    End Sub

    Private Sub btnPeriodos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPeriodos.ItemClick
        Dim classResize As New ClaseResize
        If FrmPeriodosLiquidacion.P_FormularioAbierto Then
            FrmPeriodosLiquidacion.ShowDialog()
            FrmPeriodosLiquidacion.BringToFront()
        Else
            FrmPeriodosLiquidacion.P_FormularioAbierto = True
            classResize.Resizamodales(FrmPeriodosLiquidacion, 50, 70)
            classResize.ResizeForm(FrmPeriodosLiquidacion)
            FrmPeriodosLiquidacion.ShowDialog()
            FrmPeriodosLiquidacion.BringToFront()
        End If
    End Sub

    Private Sub btnSalir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSalir.ItemClick
        Try
            If TabManagerPrincipal.Pages.Count > 0 Then
                Dim frm As XtraForm = CType(TabManagerPrincipal.SelectedPage.MdiChild, XtraForm)
                frm.Close()
            Else
                Me.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnTiposContratos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnTiposContratos.ItemClick
        Try
            Dim classResize As New ClaseResize
            If FrmAggTipoContrato.P_FormularioAbierto Then
                FrmAggTipoContrato.ShowDialog()
                FrmAggTipoContrato.BringToFront()
            Else
                FrmAggTipoContrato.P_FormularioAbierto = True
                classResize.Resizamodales(FrmAggTipoContrato, 50, 70)
                classResize.ResizeForm(FrmAggTipoContrato)
                FrmAggTipoContrato.ShowDialog()
                FrmAggTipoContrato.BringToFront()
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "btnTiposContratos_ItemClick")
        End Try
    End Sub

    Private Sub btnCentroCostos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCentroCostos.ItemClick
        Try

            Dim classResize As New ClaseResize
            If FrmAggCentroCosto.P_FormularioAbierto Then
                FrmAggCentroCosto.ShowDialog()
                FrmAggCentroCosto.BringToFront()
            Else
                FrmAggCentroCosto.P_FormularioAbierto = True
                classResize.Resizamodales(FrmAggCentroCosto, 50, 70)
                classResize.ResizeForm(FrmAggCentroCosto)
                FrmAggCentroCosto.ShowDialog()
                FrmAggCentroCosto.BringToFront()
            End If

        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "btnCentroCostos_ItemClick")
        End Try
    End Sub

    Private Sub btnDependencias_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDependencias.ItemClick
        Try
            Dim classResize As New ClaseResize
            If FrmAggDependencia.P_FormularioAbierto Then
                FrmAggDependencia.ShowDialog()
                FrmAggDependencia.BringToFront()
            Else
                FrmAggDependencia.P_FormularioAbierto = True
                classResize.Resizamodales(FrmAggDependencia, 50, 70)
                classResize.ResizeForm(FrmAggDependencia)
                FrmAggDependencia.ShowDialog()
                FrmAggDependencia.BringToFront()
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "")
        End Try

    End Sub

    Private Sub btnGenPeriodos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGenPeriodos.ItemClick
        Try
            Dim classResize As New ClaseResize
            If FrmGenPeriodosLiquidacion.P_FormularioAbierto Then
                FrmGenPeriodosLiquidacion.ShowDialog()
                FrmGenPeriodosLiquidacion.BringToFront()
            Else
                FrmGenPeriodosLiquidacion.P_FormularioAbierto = True
                classResize.Resizamodales(FrmGenPeriodosLiquidacion, 60, 70)
                classResize.ResizeForm(FrmGenPeriodosLiquidacion)
                FrmGenPeriodosLiquidacion.ShowDialog()
                FrmGenPeriodosLiquidacion.BringToFront()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnImpNom_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)

    End Sub

    Private Sub btnNuevaNomina_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNuevaNomina.ItemClick
        Dim classResize As New ClaseResize
        If FrmAggNominas.P_FormularioAbierto Then
            FrmAggNominas.ShowDialog()
            FrmAggNominas.BringToFront()
        Else
            FrmAggNominas.P_FormularioAbierto = True
            classResize.Resizamodales(FrmAggNominas, 60, 70)
            classResize.ResizeForm(FrmAggNominas)
            FrmAggNominas.ShowDialog()
            FrmAggNominas.BringToFront()
        End If
    End Sub

    Private Sub btnEntidades_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEntidades.ItemClick
        Dim classResize As New ClaseResize
        If FrmAggEntidad.P_FormularioAbierto Then
            FrmAggEntidad.ShowDialog()
            FrmAggEntidad.BringToFront()
        Else
            FrmAggEntidad.P_FormularioAbierto = True
            classResize.Resizamodales(FrmAggEntidad, 60, 60)
            classResize.ResizeForm(FrmAggEntidad)
            FrmAggEntidad.ShowDialog()
            FrmAggEntidad.BringToFront()
        End If
    End Sub

    'Private Sub btnBancos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBancos.ItemClick
    '    Dim classResize As New ClaseResize
    '    If FrmAggBanco.P_FormularioAbierto Then
    '        FrmAggBanco.ShowDialog()
    '        FrmAggBanco.BringToFront()
    '    Else
    '        FrmAggBanco.P_FormularioAbierto = True
    '        classResize.Resizamodales(FrmAggBanco, 60, 70)
    '        classResize.ResizeForm(FrmAggBanco)
    '        FrmAggBanco.ShowDialog()
    '        FrmAggBanco.BringToFront()
    '    End If
    'End Sub

    Private Sub btaggbases_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btaggbases.ItemClick
        Dim classResize As New ClaseResize
        If FrmAggBases.P_FormularioAbierto Then
            FrmAggBases.ShowDialog()
            FrmAggBases.BringToFront()
        Else
            FrmAggBases.P_FormularioAbierto = True
            classResize.Resizamodales(FrmAggBases, 50, 70)
            classResize.ResizeForm(FrmAggBases)
            FrmAggBases.ShowDialog()
            FrmAggBases.BringToFront()
        End If
    End Sub

    Private Sub FrmPrincipal_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Try
            If e.KeyCode = Keys.F2 Then
                Conectar(btnConexion.Caption)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnProfesiones_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnProfesiones.ItemClick
        FrmAggTituloProfesion.ShowDialog()
    End Sub

    Private Sub btnNivelEducativo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNivelEducativo.ItemClick
        FrmAggNivelEducativo.ShowDialog()
    End Sub

    Private Sub btnClaseLicencia_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnClaseLicencia.ItemClick
        FrmCatLicenciaConduccion.ShowDialog()
    End Sub

    Private Sub btnEstadoCivil_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEstadoCivil.ItemClick
        FrmEstadoCivil.ShowDialog()
    End Sub

    Private Sub btnParentezco_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnParentezco.ItemClick
        FrmParentesco.ShowDialog()
    End Sub
    Private Sub btnPaises_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPaises.ItemClick
        FrmPais.ShowDialog()
    End Sub

    Private Sub btnDepartamentos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDepartamentos.ItemClick
        FrmDepartamento.ShowDialog()
    End Sub

    Private Sub btnMunicipios_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnMunicipios.ItemClick
        FrmMunicipios.ShowDialog()
    End Sub

    Private Sub btnTiposId_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnTiposId.ItemClick
        FrmTipoDoc.ShowDialog()
    End Sub

    Private Sub TabManagerPrincipal_PageRemoved(sender As Object, e As DevExpress.XtraTabbedMdi.MdiTabPageEventArgs) Handles TabManagerPrincipal.PageRemoved
        ValidaMdiParent()
    End Sub

    Private Sub btnConceptosPersonales_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnConceptosPersonales.ItemClick
        Dim classResize As New ClaseResize
        If FrmAggConceptosContratos.P_FormularioAbierto Then
            FrmAggConceptosContratos.ShowDialog()
            FrmAggConceptosContratos.BringToFront()
        Else
            FrmAggConceptosContratos.P_FormularioAbierto = True
            classResize.Resizamodales(FrmAggConceptosContratos, 70, 80)
            classResize.ResizeForm(FrmAggConceptosContratos)
            FrmAggConceptosContratos.ShowDialog()
            FrmAggConceptosContratos.BringToFront()
        End If
    End Sub

    Private Sub btnClasConceptosNomina_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnClasConceptosNomina.ItemClick
        Dim classResize As New ClaseResize
        If FrmAggClasConceptosNomina.P_FormularioAbierto Then
            FrmAggClasConceptosNomina.ShowDialog()
            FrmAggClasConceptosNomina.BringToFront()
        Else
            FrmAggClasConceptosNomina.P_FormularioAbierto = True
            classResize.Resizamodales(FrmAggClasConceptosNomina, 50, 60)
            classResize.ResizeForm(FrmAggClasConceptosNomina)
            FrmAggClasConceptosNomina.ShowDialog()
            FrmAggClasConceptosNomina.BringToFront()
        End If
    End Sub

    Private Sub btnClasConceptosPersonales_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnClasConceptosPersonales.ItemClick
        Dim classResize As New ClaseResize
        If FrmAggClasConceptosPersonales.P_FormularioAbierto Then
            FrmAggClasConceptosPersonales.ShowDialog()
            FrmAggClasConceptosPersonales.BringToFront()
        Else
            FrmAggClasConceptosPersonales.P_FormularioAbierto = True
            classResize.Resizamodales(FrmAggClasConceptosPersonales, 50, 60)
            classResize.ResizeForm(FrmAggClasConceptosPersonales)
            FrmAggClasConceptosPersonales.ShowDialog()
            FrmAggClasConceptosPersonales.BringToFront()
        End If
    End Sub

    Private Sub btnDescuentosNomina_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDescuentosNomina.ItemClick
        Dim classResize As New ClaseResize
        If FrmAggDescuentosNomina.P_FormularioAbierto Then
            FrmAggDescuentosNomina.ShowDialog()
            FrmAggDescuentosNomina.BringToFront()
        Else
            FrmAggDescuentosNomina.P_FormularioAbierto = True
            classResize.Resizamodales(FrmAggDescuentosNomina, 70, 60)
            classResize.ResizeForm(FrmAggDescuentosNomina)
            FrmAggDescuentosNomina.ShowDialog()
            FrmAggDescuentosNomina.BringToFront()
        End If
    End Sub

    Private Sub btnAggValExentos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAggValExentos.ItemClick
        Dim classResize As New ClaseResize
        If FrmAsig_ValExentos.P_FormularioAbierto Then
            FrmAsig_ValExentos.ShowDialog()
            FrmAsig_ValExentos.BringToFront()
        Else
            FrmAsig_ValExentos.P_FormularioAbierto = True
            classResize.Resizamodales(FrmAsig_ValExentos, 70, 60)
            classResize.ResizeForm(FrmAsig_ValExentos)
            FrmAsig_ValExentos.ShowDialog()
            FrmAsig_ValExentos.BringToFront()
        End If
    End Sub

    Private Sub btnValMaxDescuento_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnValMaxDescuento.ItemClick
        Dim classResize As New ClaseResize
        If FrmAggValorMaxDesc.P_FormularioAbierto Then
            FrmAggValorMaxDesc.ShowDialog()
            FrmAggValorMaxDesc.BringToFront()
        Else
            FrmAggValorMaxDesc.P_FormularioAbierto = True
            classResize.Resizamodales(FrmAggValorMaxDesc, 70, 60)
            classResize.ResizeForm(FrmAggValorMaxDesc)
            FrmAggValorMaxDesc.ShowDialog()
            FrmAggValorMaxDesc.BringToFront()
        End If
    End Sub

    Private Sub btnModAsignaciones_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnModAsignaciones.ItemClick
        Try

            Dim classResize As New ClaseResize
            If FrmModAsinaciones.P_FormularioAbierto Then
                FrmModAsinaciones.ShowDialog()
                FrmModAsinaciones.BringToFront()
            Else
                FrmModAsinaciones.P_FormularioAbierto = True
                classResize.Resizamodales(FrmModAsinaciones, 70, 60)
                classResize.ResizeForm(FrmModAsinaciones)
                FrmModAsinaciones.ShowDialog()
                FrmModAsinaciones.BringToFront()
            End If

        Catch ex As Exception

        End Try
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Dim Espera As New ClEspera

        'Try
        '    If InicioConexionModulo Then
        '        If LaConexionEstaActiva Then

        '        Else
        '            Timer1.Enabled = False
        '            IfHDevExpre.MsgSamit("Se ha perdido la Conexion con el Servidor." + vbCrLf +
        '                        "Revise el estado del servidor y/o la Red antes de intentar conectarse." + vbCrLf + vbCrLf +
        '                        "¿Desea Intentar conectarse nuevamente..?", vbQuestion + vbYesNo, "Error en Conexión con el Servidor ") =System.Windows.Forms.DialogResult.OK Then
        '                Espera.Mostrar()
        '                Espera.Descripcion = "Restableciendo conexión..."
        '                SMTConexMod = Nothing
        '                SMTConexMod.Open()
        '                Espera.Terminar()
        '                If SMTConexMod.State > 0 Then

        '                Else
        '                   HDevExpre.MensagedeError("No fue posible reconectar con el servidor")
        '                End If
        '            Else
        '                Timer1.Enabled = False
        '            End If
        '        End If
        '    End If
        '    Espera.Terminar()
        'Catch ex As Exception
        '    Espera.Terminar()
        '   HDevExpre.msgError(ex, ex.Message, "Reconectando con servidor")
        'End Try
    End Sub

    Private Sub btnPlantaCargos_ItemClick(sender As Object, e As ItemClickEventArgs)
        FrmPlantaCargos.ShowDialog()
        FrmPlantaCargos.BringToFront()
    End Sub

    Private Sub btcConfigConceptos_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btcConfigConceptos.ItemClick
        FrmConfigConceptos.ShowDialog()
        FrmConfigConceptos.BringToFront()
    End Sub

    Private Sub btnConfigNominas_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnConfigNominas.ItemClick
        FrmConfigNomina.ShowDialog()
        FrmConfigNomina.BringToFront()
    End Sub

    Private Sub btcConfigTipoContratos_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btcConfigTipoContratos.ItemClick
        FrmConfigTiposContratos.ShowDialog()
        FrmConfigTiposContratos.BringToFront()
    End Sub

    Private Sub btnConfigPrestacionesS_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnConfigPrestacionesS.ItemClick
        FrmConfigConceptosPro.ShowDialog()
        FrmConfigConceptosPro.BringToFront()
    End Sub

    Private Sub btnLiquidarProvisiones_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnLiquidarProvisiones.ItemClick
        FrmLiquidarPrestacionesSocialesyOtros.MdiParent = Me
        FrmLiquidarPrestacionesSocialesyOtros.Show()
        FrmLiquidarPrestacionesSocialesyOtros.BringToFront()
        ValidaMdiParent()
    End Sub

    Private Sub btnLiquidacionExtraor_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnLiquidacionExtraor.ItemClick
        FrmLiquidacionExtraordinaria.MdiParent = Me
        FrmLiquidacionExtraordinaria.Show()
        FrmLiquidacionExtraordinaria.BringToFront()
        ValidaMdiParent()
    End Sub

    Private Sub btnLiquidarContrato_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnLiquidarContrato.ItemClick
        FrmLiquidarContratos.MdiParent = Me
        FrmLiquidarContratos.Show()
        FrmLiquidarContratos.BringToFront()
        ValidaMdiParent()
    End Sub

    Private Sub btnAggContratos_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnAggContratos.ItemClick
        Dim classResize As New ClaseResize
        FrmContrato.MdiParent = Me
        FrmContrato.Show()
        FrmContrato.BringToFront()
        ValidaMdiParent()
    End Sub

    Private Sub btnAsigValoresExentos_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnAsigValoresExentos.ItemClick
        If HDevExpre.EstaCargadoFormulario("FrmAsig_ValExentos") Then Exit Sub

        FrmAsig_ValExentos.MdiParent = Me
        FrmAsig_ValExentos.Show()

    End Sub

    Private Sub btnAsigDescuentos_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnAsigDescuentos.ItemClick
        If HDevExpre.EstaCargadoFormulario("FrmAggDescuentosNomina") Then Exit Sub

        FrmAggDescuentosNomina.MdiParent = Me
        FrmAggDescuentosNomina.Show()

        'Dim classResize As New ClaseResize
        'If FrmAggDescuentosNomina.P_FormularioAbierto Then
        '    FrmAggDescuentosNomina.ShowDialog()
        '    FrmAggDescuentosNomina.BringToFront()
        'Else
        '    FrmAggDescuentosNomina.P_FormularioAbierto = True
        '    classResize.Resizamodales(FrmAggDescuentosNomina, 80, 70)
        '    classResize.ResizeForm(FrmAggDescuentosNomina)
        '    FrmAggDescuentosNomina.ShowDialog()
        '    FrmAggDescuentosNomina.BringToFront()
        'End If
    End Sub

    Private Sub btnAsigNominas_ItemClick_1(sender As Object, e As ItemClickEventArgs) Handles btnAsigNominas.ItemClick
        If HDevExpre.EstaCargadoFormulario("FrmNominasContratos") Then Exit Sub

        FrmNominasContratos.MdiParent = Me
        FrmNominasContratos.Show()

        'Dim classResize As New ClaseResize
        'If FrmNominasContratos.P_FormularioAbierto Then
        '    FrmNominasContratos.ShowDialog()
        '    FrmNominasContratos.BringToFront()
        'Else
        '    FrmNominasContratos.P_FormularioAbierto = True
        '    classResize.Resizamodales(FrmNominasContratos, 50, 70)
        '    classResize.ResizeForm(FrmNominasContratos)
        '    FrmNominasContratos.ShowDialog()
        '    FrmNominasContratos.BringToFront()
        'End If
    End Sub

    Private Sub btnModAsignaSalariales_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnModAsignaSalariales.ItemClick
        If HDevExpre.EstaCargadoFormulario("FrmModAsinaciones") Then Exit Sub

        FrmModAsinaciones.MdiParent = Me
        FrmModAsinaciones.Show()

        'Dim classResize As New ClaseResize
        'If FrmModAsinaciones.P_FormularioAbierto Then
        '    FrmModAsinaciones.ShowDialog()
        '    FrmModAsinaciones.BringToFront()
        'Else
        '    FrmModAsinaciones.P_FormularioAbierto = True
        '    classResize.Resizamodales(FrmModAsinaciones, 70, 60)
        '    classResize.ResizeForm(FrmModAsinaciones)
        '    FrmModAsinaciones.ShowDialog()
        '    FrmModAsinaciones.BringToFront()
        'End If
    End Sub

    Private Sub bntTiposContratos_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bntTiposContratos.ItemClick
        Try
            Dim classResize As New ClaseResize
            If FrmAggTipoContrato.P_FormularioAbierto Then
                FrmAggTipoContrato.ShowDialog()
                FrmAggTipoContrato.BringToFront()
            Else
                FrmAggTipoContrato.P_FormularioAbierto = True
                classResize.Resizamodales(FrmAggTipoContrato, 50, 70)
                classResize.ResizeForm(FrmAggTipoContrato)
                FrmAggTipoContrato.ShowDialog()
                FrmAggTipoContrato.BringToFront()
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "btnTiposContratos_ItemClick")
        End Try
    End Sub

    Private Sub bntDependencia_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bntDependencia.ItemClick
        Try
            Dim classResize As New ClaseResize
            If FrmAggDependencia.P_FormularioAbierto Then
                FrmAggDependencia.ShowDialog()
                FrmAggDependencia.BringToFront()
            Else
                FrmAggDependencia.P_FormularioAbierto = True
                classResize.Resizamodales(FrmAggDependencia, 50, 70)
                classResize.ResizeForm(FrmAggDependencia)
                FrmAggDependencia.ShowDialog()
                FrmAggDependencia.BringToFront()
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "")
        End Try
    End Sub

    Private Sub btnCentrosCostos_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnCentrosCostos.ItemClick
        Try
            Dim classResize As New ClaseResize
            If FrmAggCentroCosto.P_FormularioAbierto Then
                FrmAggCentroCosto.ShowDialog()
                FrmAggCentroCosto.BringToFront()
            Else
                FrmAggCentroCosto.P_FormularioAbierto = True
                classResize.Resizamodales(FrmAggCentroCosto, 50, 70)
                classResize.ResizeForm(FrmAggCentroCosto)
                FrmAggCentroCosto.ShowDialog()
                FrmAggCentroCosto.BringToFront()
            End If

        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "btnCentroCostos_ItemClick")
        End Try
    End Sub

    Private Sub btnAggCargo_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnAggCargo.ItemClick


        If HDevExpre.EstaCargadoFormulario("FrmCargo") Then Exit Sub

        FrmCargo.MdiParent = Me
        FrmCargo.Show()
        ''Try

        ''    Dim classResize As New ClaseResize
        ''    If FrmCargo.P_FormularioAbierto Then
        ''        FrmCargo.MdiParent = Me
        ''        FrmCargo.Show()
        ''        FrmCargo.BringToFront()
        ''        ValidaMdiParent()
        ''    Else
        ''        FrmCargo.MdiParent = Me
        ''        FrmCargo.P_FormularioAbierto = True
        ''        classResize.ResizeForm(FrmCargo)
        ''        FrmCargo.Show()
        ''        FrmCargo.BringToFront()
        ''        ValidaMdiParent()
        ''    End If
        ''Catch ex As Exception
        ''   HDevExpre.msgError(ex, ex.Message, "")
        ''End Try
    End Sub

    Private Sub btnFunciones_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnFunciones.ItemClick
        Dim classResize As New ClaseResize
        If FrmAggFunciones.P_FormularioAbierto Then
            FrmAggFunciones.ShowDialog()
            FrmAggFunciones.BringToFront()
        Else
            FrmAggFunciones.P_FormularioAbierto = True
            classResize.Resizamodales(FrmAggFunciones, 50, 70)
            classResize.ResizeForm(FrmAggFunciones)
            FrmAggFunciones.ShowDialog()
            FrmAggFunciones.BringToFront()
        End If
    End Sub

    Private Sub btnAggNominas_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnAggNominas.ItemClick
        If HDevExpre.EstaCargadoFormulario("FrmAggNominas") Then Exit Sub

        FrmAggNominas.MdiParent = Me
        FrmAggNominas.Show()
        'Dim classResize As New ClaseResize
        'If FrmAggNominas.P_FormularioAbierto Then
        '    FrmAggNominas.ShowDialog()
        '    FrmAggNominas.BringToFront()
        'Else
        '    FrmAggNominas.P_FormularioAbierto = True
        '    classResize.Resizamodales(FrmAggNominas, 60, 70)
        '    classResize.ResizeForm(FrmAggNominas)
        '    FrmAggNominas.ShowDialog()
        '    FrmAggNominas.BringToFront()
        'End If
    End Sub

    Private Sub btnConfigNomina_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnConfigNomina.ItemClick
        If HDevExpre.EstaCargadoFormulario("FrmPerfilesCta") Then Exit Sub

        FrmPerfilesCta.MdiParent = Me
        FrmPerfilesCta.Show()

    End Sub

    Private Sub btnValoresPersonales_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnValoresPersonales.ItemClick
        Dim classResize As New ClaseResize
        If FrmAggVariablesPersonales.P_FormularioAbierto Then
            FrmAggVariablesPersonales.ShowDialog()
            FrmAggVariablesPersonales.BringToFront()
        Else
            FrmAggVariablesPersonales.P_FormularioAbierto = True
            classResize.Resizamodales(FrmAggVariablesPersonales, 50, 70)
            classResize.ResizeForm(FrmAggVariablesPersonales)
            FrmAggVariablesPersonales.ShowDialog()
            FrmAggVariablesPersonales.BringToFront()
        End If
    End Sub

    Private Sub btnValoresGenerales_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnValoresGenerales.ItemClick
        Dim classResize As New ClaseResize
        If FrmAggVariablesGenerales.P_FormularioAbierto Then
            FrmAggVariablesGenerales.ShowDialog()
            FrmAggVariablesGenerales.BringToFront()
        Else
            FrmAggVariablesGenerales.P_FormularioAbierto = True
            classResize.Resizamodales(FrmAggVariablesGenerales, 70, 70)
            classResize.ResizeForm(FrmAggVariablesGenerales)
            FrmAggVariablesGenerales.ShowDialog()
            FrmAggVariablesGenerales.BringToFront()
        End If
    End Sub

    Private Sub btnAggBases_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnAggBases.ItemClick
        If HDevExpre.EstaCargadoFormulario("FrmAggBases") Then Exit Sub

        FrmAggBases.MdiParent = Me
        FrmAggBases.Show()
        'Dim classResize As New ClaseResize
        'If FrmAggBases.P_FormularioAbierto Then
        '    FrmAggBases.ShowDialog()
        '    FrmAggBases.BringToFront()
        'Else
        '    FrmAggBases.P_FormularioAbierto = True
        '    classResize.Resizamodales(FrmAggBases, 50, 70)
        '    classResize.ResizeForm(FrmAggBases)
        '    FrmAggBases.ShowDialog()
        '    FrmAggBases.BringToFront()
        'End If
    End Sub

    Private Sub btnConceptosNomina_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnConceptosNomina.ItemClick
        Dim classResize As New ClaseResize
        If FrmAggConceptosNomina.P_FormularioAbierto Then
            FrmAggConceptosNomina.ShowDialog()
            FrmAggConceptosNomina.BringToFront()
        Else
            FrmAggConceptosNomina.P_FormularioAbierto = True
            classResize.Resizamodales(FrmAggConceptosNomina, 70, 80)
            'classResize.VerificaTabControl(FrmAggConceptosNomina)
            classResize.ResizeForm(FrmAggConceptosNomina)
            FrmAggConceptosNomina.ShowDialog()
            FrmAggConceptosNomina.BringToFront()
        End If
    End Sub

    Private Sub btnClasiConcepNom_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnClasiConcepNom.ItemClick
        Dim classResize As New ClaseResize
        If FrmAggClasConceptosNomina.P_FormularioAbierto Then
            FrmAggClasConceptosNomina.ShowDialog()
            FrmAggClasConceptosNomina.BringToFront()
        Else
            FrmAggClasConceptosNomina.P_FormularioAbierto = True
            classResize.Resizamodales(FrmAggClasConceptosNomina, 50, 70)
            classResize.ResizeForm(FrmAggClasConceptosNomina)
            FrmAggClasConceptosNomina.ShowDialog()
            FrmAggClasConceptosNomina.BringToFront()
        End If
    End Sub

    Private Sub btnConceptosPersona_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnConceptosPersona.ItemClick
        Dim classResize As New ClaseResize
        If FrmAggConceptosContratos.P_FormularioAbierto Then
            FrmAggConceptosContratos.ShowDialog()
            FrmAggConceptosContratos.BringToFront()
        Else
            FrmAggConceptosContratos.P_FormularioAbierto = True
            classResize.Resizamodales(FrmAggConceptosContratos, 50, 60)
            classResize.ResizeForm(FrmAggConceptosContratos)
            FrmAggConceptosContratos.ShowDialog()
            FrmAggConceptosContratos.BringToFront()
        End If
    End Sub

    Private Sub btnClasiConcepPersonales_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnClasiConcepPersonales.ItemClick
        Dim classResize As New ClaseResize
        If FrmAggClasConceptosPersonales.P_FormularioAbierto Then
            FrmAggClasConceptosPersonales.ShowDialog()
            FrmAggClasConceptosPersonales.BringToFront()
        Else
            FrmAggClasConceptosPersonales.P_FormularioAbierto = True
            classResize.Resizamodales(FrmAggClasConceptosPersonales, 50, 60)
            classResize.ResizeForm(FrmAggClasConceptosPersonales)
            FrmAggClasConceptosPersonales.ShowDialog()
            FrmAggClasConceptosPersonales.BringToFront()
        End If
    End Sub

    Private Sub btnPerfilConceptos_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnPerfilConceptos.ItemClick

        If HDevExpre.EstaCargadoFormulario("FrmAggPlantillas") Then Exit Sub

        FrmAggPlantillas.MdiParent = Me
        FrmAggPlantillas.Show()
        'Dim classResize As New ClaseResize
        'If FrmAggPlantillas.P_FormularioAbierto Then
        '    FrmAggPlantillas.ShowDialog()
        '    FrmAggPlantillas.BringToFront()
        'Else
        '    FrmAggPlantillas.P_FormularioAbierto = True
        '    classResize.Resizamodales(FrmAggPlantillas, 80, 70)
        '    classResize.ResizeForm(FrmAggPlantillas)
        '    FrmAggPlantillas.ShowDialog()
        '    FrmAggPlantillas.BringToFront()
        'End If
    End Sub

    Private Sub btnAsigValorMaximo_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnAsigValorMaximo.ItemClick

        If HDevExpre.EstaCargadoFormulario("FrmAggValorMaxDesc") Then Exit Sub

        FrmAggValorMaxDesc.MdiParent = Me
        FrmAggValorMaxDesc.Show()
        'Dim classResize As New ClaseResize
        'If FrmAggValorMaxDesc.P_FormularioAbierto Then
        '    FrmAggValorMaxDesc.ShowDialog()
        '    FrmAggValorMaxDesc.BringToFront()
        'Else
        '    FrmAggValorMaxDesc.P_FormularioAbierto = True
        '    classResize.Resizamodales(FrmAggValorMaxDesc, 70, 60)
        '    classResize.ResizeForm(FrmAggValorMaxDesc)
        '    FrmAggValorMaxDesc.ShowDialog()
        '    FrmAggValorMaxDesc.BringToFront()
        'End If
    End Sub

    Private Sub btnNovedades_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnNovedades.ItemClick
        Try
            Dim classResize As New ClaseResize
            If FrmAggNovedades.P_FormularioAbierto Then
                FrmAggNovedades.MdiParent = Me
                FrmAggNovedades.Show()
                FrmAggNovedades.BringToFront()
                ValidaMdiParent()
            Else
                FrmAggNovedades.MdiParent = Me
                FrmAggNovedades.P_FormularioAbierto = True
                classResize.ResizeForm(FrmAggNovedades)
                FrmAggNovedades.Show()
                FrmAggNovedades.BringToFront()
                ValidaMdiParent()
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "")
        End Try
    End Sub

    Private Sub btnLiquidarPeriodo_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnLiquidarPeriodo.ItemClick
        Try
            Dim classResize As New ClaseResize
            If FrmLiquidarNomina.P_FormularioAbierto Then
                FrmLiquidarNomina.MdiParent = Me
                FrmLiquidarNomina.Show()
                FrmLiquidarNomina.BringToFront()
                ValidaMdiParent()
            Else
                FrmLiquidarNomina.MdiParent = Me
                FrmLiquidarNomina.P_FormularioAbierto = True
                classResize.ResizeForm(FrmLiquidarNomina)
                FrmLiquidarNomina.Show()
                FrmLiquidarNomina.BringToFront()
                ValidaMdiParent()
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "")
        End Try
    End Sub

    Private Sub btnConfigurarLiquidaPeriodos_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnConfigurarLiquidaPeriodos.ItemClick
        If HDevExpre.EstaCargadoFormulario("FrmConfigConceptos") Then Exit Sub
        FrmConfigConceptos.MdiParent = Me
        FrmConfigConceptos.Show()
    End Sub

    Private Sub bntLiquidarPrestaciones_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bntLiquidarPrestaciones.ItemClick
        FrmLiquidarPrestacionesSocialesyOtros.MdiParent = Me
        FrmLiquidarPrestacionesSocialesyOtros.Show()
        FrmLiquidarPrestacionesSocialesyOtros.BringToFront()
        ValidaMdiParent()
    End Sub

    Private Sub btnConfigLiquidaPrestaciones_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnConfigLiquidaPrestaciones.ItemClick
        If HDevExpre.EstaCargadoFormulario("FrmConfigConceptosPro") Then Exit Sub
        FrmConfigConceptosPro.MdiParent = Me
        FrmConfigConceptosPro.Show()
    End Sub

    Private Sub btnLiquidacionExtraordinaria_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnLiquidacionExtraordinaria.ItemClick
        FrmLiquidacionExtraordinaria.MdiParent = Me
        FrmLiquidacionExtraordinaria.Show()
        FrmLiquidacionExtraordinaria.BringToFront()
        ValidaMdiParent()
    End Sub

    Private Sub btnLiquidarContratos_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnLiquidarContratos.ItemClick
        FrmLiquidarContratos.MdiParent = Me
        FrmLiquidarContratos.Show()
        FrmLiquidarContratos.BringToFront()
        ValidaMdiParent()
    End Sub

    Private Sub btnConfigLiquidacion_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnConfigLiquidacion.ItemClick
        If HDevExpre.EstaCargadoFormulario("FrmConfigTiposContratos") Then Exit Sub

        FrmConfigTiposContratos.MdiParent = Me
        FrmConfigTiposContratos.Show()
    End Sub

    Private Sub btnConsultarLiquidacion_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnConsultarLiquidacion.ItemClick
        FrmConsultaLiquidaciones.MdiParent = Me
        FrmConsultaLiquidaciones.Show()
        FrmConsultaLiquidaciones.BringToFront()
        ValidaMdiParent()
    End Sub

    Private Sub btnBancos_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnBancos.ItemClick
        FrmAggBanco.MdiParent = Me
        FrmAggBanco.Show()
    End Sub

    Private Sub BarButtonItem12_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem12.ItemClick
        'If EstaCargadoFormulario("FrmAggValExentos") Then Exit Sub

        'FrmAggValExentos.MdiParent = Me
        'FrmAggValExentos.Show()

        Dim classResize As New ClaseResize

        classResize.Resizamodales(FrmAggValExentos, 80, 70)
        FrmAggValExentos.ShowDialog()
        FrmAggValExentos.BringToFront()

    End Sub

    Private Sub CofigConcepNomina_ItemClick(sender As Object, e As ItemClickEventArgs) Handles CofigConcepNomina.ItemClick
        FrmConfigConceptos.ShowDialog()
        FrmConfigConceptos.BringToFront()
    End Sub

    Private Sub b_ItemClick(sender As Object, e As ItemClickEventArgs) Handles b.ItemClick

    End Sub

    Private Sub BarButtonItem31_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem31.ItemClick
        If HDevExpre.EstaCargadoFormulario("FrmCargo") Then Exit Sub

        FrmCargo.MdiParent = Me
        FrmCargo.Show()
    End Sub

    Private Sub BarButtonItem32_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem32.ItemClick
        Dim classResize As New ClaseResize

        classResize.Resizamodales(FrmAggFunciones, 80, 70)
        FrmAggFunciones.ShowDialog()
        FrmAggFunciones.BringToFront()
    End Sub

    Private Sub BarButtonItem21_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem21.ItemClick
        Dim classResize As New ClaseResize

        classResize.Resizamodales(FrmAggNivelEducativo, 80, 70)
        FrmAggNivelEducativo.ShowDialog()
        FrmAggNivelEducativo.BringToFront()
    End Sub

    Private Sub BarButtonItem22_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem22.ItemClick
        Dim classResize As New ClaseResize

        classResize.Resizamodales(FrmAggTituloProfesion, 80, 70)
        FrmAggTituloProfesion.ShowDialog()
        FrmAggTituloProfesion.BringToFront()
    End Sub

    Private Sub BarButtonItem23_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem23.ItemClick
        Dim classResize As New ClaseResize

        classResize.Resizamodales(FrmCatLicenciaConduccion, 80, 70)
        FrmCatLicenciaConduccion.ShowDialog()
        FrmCatLicenciaConduccion.BringToFront()
    End Sub

    Private Sub BarButtonItem24_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem24.ItemClick
        Dim classResize As New ClaseResize

        classResize.Resizamodales(FrmEstadoCivil, 80, 70)
        FrmEstadoCivil.ShowDialog()
        FrmEstadoCivil.BringToFront()
    End Sub

    Private Sub BarButtonItem25_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem25.ItemClick
        Dim classResize As New ClaseResize

        classResize.Resizamodales(FrmParentesco, 80, 70)
        FrmParentesco.ShowDialog()
        FrmParentesco.BringToFront()
    End Sub

    Private Sub BarButtonItem26_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem26.ItemClick
        Dim classResize As New ClaseResize

        classResize.Resizamodales(FrmDepartamento, 80, 70)
        FrmDepartamento.ShowDialog()
        FrmDepartamento.BringToFront()
    End Sub

    Private Sub BarButtonItem27_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem27.ItemClick
        Dim classResize As New ClaseResize

        classResize.Resizamodales(FrmPais, 80, 70)
        FrmPais.ShowDialog()
        FrmPais.BringToFront()
    End Sub

    Private Sub BarButtonItem28_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem28.ItemClick
        Dim classResize As New ClaseResize

        classResize.Resizamodales(FrmTipoDoc, 80, 70)
        FrmTipoDoc.ShowDialog()
        FrmTipoDoc.BringToFront()
    End Sub

    Private Sub BarButtonItem14_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem14.ItemClick
        Dim classResize As New ClaseResize

        classResize.Resizamodales(FrmAggBanco, 80, 70)
        FrmAggBanco.ShowDialog()
        FrmAggBanco.BringToFront()
    End Sub

    Private Sub BarButtonItem15_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem15.ItemClick
        If HDevExpre.EstaCargadoFormulario("FrmAggEntidad") Then Exit Sub

        FrmAggEntidad.MdiParent = Me
        FrmAggEntidad.Show()
    End Sub

    Private Sub BarButtonItem17_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem17.ItemClick
        Dim classResize As New ClaseResize

        classResize.Resizamodales(FrmAggTipoContrato, 80, 70)
        FrmAggTipoContrato.ShowDialog()
        FrmAggTipoContrato.BringToFront()
    End Sub

    Private Sub BarButtonItem18_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem18.ItemClick
        Dim classResize As New ClaseResize

        classResize.Resizamodales(FrmAggDependencia, 80, 70)
        FrmAggDependencia.ShowDialog()
        FrmAggDependencia.BringToFront()
    End Sub

    Private Sub BarButtonItem19_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem19.ItemClick
        If HDevExpre.EstaCargadoFormulario("FrmAggCentroCosto") Then Exit Sub

        FrmAggCentroCosto.MdiParent = Me
        FrmAggCentroCosto.Show()
    End Sub

    Private Sub BarButtonItem29_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem29.ItemClick
        If HDevExpre.EstaCargadoFormulario("FrmAggBases") Then Exit Sub

        FrmAggBases.MdiParent = Me
        FrmAggBases.Show()
    End Sub

    Private Sub BarButtonItem34_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem34.ItemClick
        If HDevExpre.EstaCargadoFormulario("FrmAggVariablesGenerales") Then Exit Sub

        FrmAggVariablesGenerales.MdiParent = Me
        FrmAggVariablesGenerales.Show()
    End Sub

    Private Sub BarButtonItem35_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem35.ItemClick
        If HDevExpre.EstaCargadoFormulario("FrmAggVariablesPersonales") Then Exit Sub

        FrmAggVariablesPersonales.MdiParent = Me
        FrmAggVariablesPersonales.Show()
    End Sub

    Private Sub BarButtonItem44_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem44.ItemClick
        If HDevExpre.EstaCargadoFormulario("FrmPlantaCargos") Then Exit Sub

        FrmPlantaCargos.MdiParent = Me
        FrmPlantaCargos.Show()
    End Sub

    Private Sub BarButtonItem39_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem39.ItemClick
        Dim classResize As New ClaseResize

        classResize.Resizamodales(FrmAggClasConceptosNomina, 80, 70)
        FrmAggClasConceptosNomina.ShowDialog()
        FrmAggClasConceptosNomina.BringToFront()
    End Sub

    Private Sub BarButtonItem38_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem38.ItemClick
        If HDevExpre.EstaCargadoFormulario("FrmAggConceptosNomina") Then Exit Sub

        FrmAggConceptosNomina.MdiParent = Me
        FrmAggConceptosNomina.Show()
    End Sub

    Private Sub BarButtonItem43_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem43.ItemClick
        Dim classResize As New ClaseResize

        classResize.Resizamodales(FrmAggClasConceptosPersonales, 90, 80)
        FrmAggClasConceptosPersonales.ShowDialog()
        FrmAggClasConceptosPersonales.BringToFront()
    End Sub

    Private Sub BarButtonItem47_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem47.ItemClick
        If HDevExpre.EstaCargadoFormulario("FrmAggConceptosContratos") Then Exit Sub

        FrmAggConceptosContratos.MdiParent = Me
        FrmAggConceptosContratos.Show()
    End Sub

    Private Sub BarButtonItem45_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem45.ItemClick
        If HDevExpre.EstaCargadoFormulario("FrmGenPeriodosLiquidacion") Then Exit Sub

        FrmGenPeriodosLiquidacion.MdiParent = Me
        FrmGenPeriodosLiquidacion.Show()
    End Sub

    Private Sub BarButtonItem46_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem46.ItemClick
        If HDevExpre.EstaCargadoFormulario("FrmPeriodosLiquidacion") Then Exit Sub

        FrmPeriodosLiquidacion.MdiParent = Me
        FrmPeriodosLiquidacion.Show()
    End Sub

    Private Sub BarButtonItem48_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem48.ItemClick
        If HDevExpre.EstaCargadoFormulario("FrmImportarTerceros") Then Exit Sub

        FrmImportarTerceros.MdiParent = Me
        FrmImportarTerceros.Show()
    End Sub
End Class
