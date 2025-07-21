Option Strict Off
Imports SamitCtlNet
Imports SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL
Imports SamitCtlNet.SamitCtlNet
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraEditors
Imports SamitNominaLogic
Imports Newtonsoft.Json.Linq

Public Class FrmEmpleado
    Public grupoImgsExpLaboral As New GalleryItemGroup
    Public grupoImgsInfAcademica As New GalleryItemGroup
    Public grupoImgsAfiliaciones As New GalleryItemGroup
    Public dtImagenes As New DataTable
    Public ImpExpLaboral As Boolean
    Public ImpInfAcademica As Boolean
    Public ImpEduNoFormal As Boolean
    Public ImpInfFamiliares As Boolean
    Public ImpAfiliaciones As Boolean
    Public ImpDatosBasicos As Boolean
    Public Datos As New SamitCtlNet.SamitCtlNet

    Dim ActualizandoDatosBasicos As Boolean = False
    Dim ActualizandoExpLab As Boolean = False
    Dim ActualizandoAfiliaciones As Boolean = False
    Dim ActualizandoFamiliares As Boolean = False
    Dim ActualizandoEstudios As Boolean = False
    Dim VsecRegistroExpLab As String
    Dim TabPageSeleccionada As TabSeleccionado
    Dim ImagenSeleccionadaExpLaboral As GalleryItem
    Dim ImagenSeleccionadaAfiliacion As GalleryItem
    Dim ImagenSeleccionadaInfAcademica As GalleryItem
    Dim YaExisteFamiliar As Boolean = False
    Dim NumDocumento As String
    Dim Sec As String

    Dim CambioCedula As Boolean = False
    Dim FormularioAbierto As Boolean = False
    Dim HDevExpre As New HelperDevExpress
    Dim HNomina As New HelperNomina
    Dim HEmpleado As New HelperEmpleado
    Public Property P_FormularioAbierto() As Boolean
        Get
            Return FormularioAbierto
        End Get
        Set(value As Boolean)
            FormularioAbierto = value
        End Set
    End Property

    Public Property secRegistroExpLab() As String
        Get
            Return VsecRegistroExpLab
        End Get
        Set(value As String)
            VsecRegistroExpLab = value
        End Set
    End Property
    Dim VidEmpleado As String
    Public Property idEmpleado() As String
        Get
            Return VidEmpleado
        End Get
        Set(value As String)
            VidEmpleado = value
        End Set
    End Property
    Dim VsecRegInfAcademica As String
    Public Property secRegInfAcademica() As String
        Get
            Return VsecRegInfAcademica
        End Get
        Set(value As String)
            VsecRegInfAcademica = value
        End Set
    End Property
    Dim VSecRegFamiliar As String
    Public Property SecRegFamiliar() As String
        Get
            Return VSecRegFamiliar
        End Get
        Set(value As String)
            VSecRegFamiliar = value
        End Set
    End Property
    Dim VSecRegAfiliacion As String
    Public Property SecRegAfiliacion() As String
        Get
            Return VSecRegAfiliacion
        End Get
        Set(value As String)
            VSecRegAfiliacion = value
        End Set
    End Property
    Private Enum TabSeleccionado
        DatosBasicos = 0
        Afiliaciones = 1
        Familiares = 2
        ExpereienciaLaboral = 3
        InformacionAcademica = 4
    End Enum
    Private Sub FrmEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            AcomodaForm()
            LlenaTodosLkes()
            LlenaLkeNivelesEducativos()
            LlenaLkeParentescoFamiliares()
            LlenaLkeEntidadesAfiliar()
            CreaGrillaExpLaboral()
            CreaGrillaInfAcademica()
            CreaGrillaFamiliares()
            CreaGrillaAfiliaciones()
            AsignaMensajesAcontroles()
            AsignaSqlAcontroles()
            AsignarLimiteCharacteresControles()
            TabPageSeleccionada = TabSeleccionado.DatosBasicos
            btnAmpliaImagenes.Text = "Ver Todas"
            btnAmpliaImagenes.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Imagen)
            txtDocEmpleado.Focus()
            txtDocEmpleado.Select()

        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, " Load Empleados")
        End Try
    End Sub
    Private Sub FrmEmpleado_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        FormularioAbierto = False
    End Sub

#Region "EfectosControles TODOS"
    'cONTROLES DATOS BASICOS

    Private Sub tcEmpleados_SelectedPageChanged(sender As Object, e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles tcEmpleados.SelectedPageChanged
        Dim page As String = e.Page.Name
        btnAmpliaImagenes.Enabled = True
        btnAmpliaImagenes.Text = "Ampliar " + vbNewLine + "Imagenes"
        btnAmpliaImagenes.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.AmpliarImagenes)
        If page = "tpDatosBasicos" Then
            TabPageSeleccionada = TabSeleccionado.DatosBasicos
            btnAmpliaImagenes.Text = "Ver Todas"
            btnAmpliaImagenes.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Imagen)
            txtDocEmpleado.Focus()
        ElseIf page = "tpAfiliaciones" Then
            TabPageSeleccionada = TabSeleccionado.Afiliaciones
            btnAmpliaImagenes.Text = "Ampliar " + vbNewLine + "Certificados"
            txtTipoEntidad.Focus()
        ElseIf page = "tpFamiliares" Then
            TabPageSeleccionada = TabSeleccionado.Familiares
            btnAmpliaImagenes.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Imagen)
            btnAmpliaImagenes.Text = "Ver Todas"
            lkeTipoDocFamiliar.Focus()
        ElseIf page = "tpExpLaboral" Then
            TabPageSeleccionada = TabSeleccionado.ExpereienciaLaboral
            btnAmpliaImagenes.Text = "Ampliar " + vbNewLine + "Certificados"
            txtEmpresaExpLab.Focus()
        ElseIf page = "tpInfAcademica" Then
            TabPageSeleccionada = TabSeleccionado.InformacionAcademica
            btnAmpliaImagenes.Text = "Ampliar " + vbNewLine + "Certificados"
            lkeNivelEducativo.Focus()
        Else
            FrmPrincipal.rcPrincipal.SelectedPage = FrmPrincipal.PaginaInicio
        End If
    End Sub
    Private Sub txtDocEmpleado_EditValueChanged(sender As Object, e As EventArgs) Handles txtDocEmpleado.EditValueChanged
        'LimpiarCampos()
        CambioCedula = True
    End Sub
    Private Sub grTipoCuenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles grTipoCuenta.KeyPress
        HDevExpre.AvanzaConEnter(e)
    End Sub

    Private Sub txtDocEmpleado_Enter(sender As Object, e As EventArgs) Handles txtDocEmpleado.Enter
        HDevExpre.EntraControlDev(txtDocEmpleado, lblDocEmpleado)
        FrmPrincipal.MensajeDeAyuda.Caption = "Digite el Número de documento del empleado. (ENTER,ABJ)=Avanzar;(F5)=Buscar"
        CambioCedula = False
    End Sub
    Private Sub btnSalir_Leave(sender As Object, e As EventArgs) Handles btnSalir.Leave
        txtDocEmpleado.Focus()
    End Sub
    Private Sub txtDocEmpleado_Leave(sender As Object, e As EventArgs) Handles txtDocEmpleado.Leave
        HDevExpre.SaleControlDev(txtDocEmpleado, lblDocEmpleado)
        If txtDocEmpleado.Text <> "" And Not ActualizandoDatosBasicos Then

            CargarDatos(Convert.ToInt64(txtDocEmpleado.Text))
        End If


        FrmPrincipal.MensajeDeAyuda.Caption = ""
    End Sub

    Private Sub grTipoCuenta_Enter(sender As Object, e As EventArgs) Handles grTipoCuenta.Enter
        HDevExpre.EntraControlRadioGroup(grTipoCuenta, , grTipoCuenta.Font.Size)
        FrmPrincipal.MensajeDeAyuda.Caption = "Seleccione el tipo de cuenta del empleado. (ENTER,ABJ)=Avanzar;"
    End Sub

    Private Sub grTipoCuenta_Leave(sender As Object, e As EventArgs) Handles grTipoCuenta.Leave
        HDevExpre.SaleControlRadioGroup(grTipoCuenta, , grTipoCuenta.Font.Size)
        FrmPrincipal.MensajeDeAyuda.Caption = ""
    End Sub

    Private Sub txtDigitoV_Enter(sender As Object, e As EventArgs) Handles txtDigitoV.Enter
        HDevExpre.EntraControlDev(txtDigitoV, lblDigitoVer)
        FrmPrincipal.MensajeDeAyuda.Caption = "Digito de verificación del tercero/empleado"
    End Sub

    Private Sub txtDigitoV_Leave(sender As Object, e As EventArgs) Handles txtDigitoV.Leave
        HDevExpre.SaleControlDev(txtDigitoV, lblDigitoVer)
        FrmPrincipal.MensajeDeAyuda.Caption = ""
    End Sub

    Private Sub txtDocEmpleado_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDigitoV.KeyDown, dteFechaNacimiento.KeyDown, dteFechaExpDocumento.KeyDown, txtDocEmpleado.KeyDown
        HDevExpre.AvanzarAtrasControl(e)
        If e.KeyCode = Keys.F5 Then
            AbreBusqueda()
        End If
    End Sub
    Private Sub lkeTipoDoc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles lkePaisResidencia.KeyPress, lkePaisNacimiento.KeyPress, lkePaisExpDocumento.KeyPress, lkeMuniResidencia.KeyPress, lkeMuniNacimiento.KeyPress, lkeMuniExpDocumento.KeyPress, lkeDepResidencia.KeyPress, lkeDepNacimiento.KeyPress, lkeDepExpDocumento.KeyPress, dteFechaRegistroEmpEntidad.KeyPress, lkeClaseLibreta.KeyPress
        HDevExpre.AvanzaConEnter(e)
    End Sub

    Private Sub lkeTipoDoc_KeyDown(sender As Object, e As KeyEventArgs) Handles lkePaisResidencia.KeyDown, lkePaisNacimiento.KeyDown, lkePaisExpDocumento.KeyDown, lkeMuniResidencia.KeyDown, lkeMuniNacimiento.KeyDown, lkeMuniExpDocumento.KeyDown, lkeDepResidencia.KeyDown, lkeDepNacimiento.KeyDown, lkeDepExpDocumento.KeyDown, ndPersonaAcargo.KeyDown, ndDuracion.KeyDown
        If e.KeyCode = Keys.Escape Then
            e.Handled = True
            SendKeys.Send("+{TAB}")
        End If
    End Sub

    Private Sub lkeClaseLibreta_Enter(sender As Object, e As EventArgs) Handles lkeClaseLibreta.Enter
        HDevExpre.EntraControlLkeDEV(lkeClaseLibreta, lblClaseLibreta)
        FrmPrincipal.MensajeDeAyuda.Caption = "Seleccione la clase de libreta que tiene el empleado. (ENTER,ABJ)=Avanzar;(F5)=Buscar"
    End Sub

    Private Sub lkeClaseLibreta_Leave(sender As Object, e As EventArgs) Handles lkeClaseLibreta.Leave
        HDevExpre.SaleControlLkeDEV(lkeClaseLibreta, lblClaseLibreta)
        FrmPrincipal.MensajeDeAyuda.Caption = ""
    End Sub

    Private Sub ndPersonaAcargo_Enter(sender As Object, e As EventArgs) Handles ndPersonaAcargo.Enter
        HDevExpre.EntraControNumericDownDEV(ndPersonaAcargo, lblPersonasAcargo)
        FrmPrincipal.MensajeDeAyuda.Caption = "Indique las personas que se encuentran a su cargo. (ENTER)=Avanzar;(ESC)=Atras;(ARB,ABJ)=Navegar"
    End Sub

    Private Sub ndPersonaAcargo_Leave(sender As Object, e As EventArgs) Handles ndPersonaAcargo.Leave
        HDevExpre.SaleControlNumercDownDEV(ndPersonaAcargo, lblPersonasAcargo)
        FrmPrincipal.MensajeDeAyuda.Caption = ""
    End Sub



    Private Sub lkePaisNacimiento_Enter(sender As Object, e As EventArgs) Handles lkePaisNacimiento.Enter
        HDevExpre.EntraControlLkeDEV(lkePaisNacimiento, lblPaisNac)
        FrmPrincipal.MensajeDeAyuda.Caption = "Seleccione el pais de nacimiento del empleado. (ENTER)=Avanzar;(ESC)=Atras;(ESPACIO)=Desplegar;(ARB,ABJ)=Navegar"
    End Sub

    Private Sub lkePaisNacimiento_Leave(sender As Object, e As EventArgs) Handles lkePaisNacimiento.Leave
        HDevExpre.SaleControlLkeDEV(lkePaisNacimiento, lblPaisNac)
        FrmPrincipal.MensajeDeAyuda.Caption = ""
    End Sub

    Private Sub lkeDepNacimiento_Enter(sender As Object, e As EventArgs) Handles lkeDepNacimiento.Enter
        HDevExpre.EntraControlLkeDEV(lkeDepNacimiento, lblDepNac)
        FrmPrincipal.MensajeDeAyuda.Caption = "Seleccione el departamento de nacimiento del empleado. (ENTER)=Avanzar;(ESC)=Atras;(ESPACIO)=Desplegar;(ARB,ABJ)=Navegar"
    End Sub

    Private Sub lkeDepNacimiento_Leave(sender As Object, e As EventArgs) Handles lkeDepNacimiento.Leave
        HDevExpre.SaleControlLkeDEV(lkeDepNacimiento, lblDepNac)
        FrmPrincipal.MensajeDeAyuda.Caption = ""
    End Sub

    Private Sub lkeMuniNacimiento_Enter(sender As Object, e As EventArgs) Handles lkeMuniNacimiento.Enter
        HDevExpre.EntraControlLkeDEV(lkeMuniNacimiento, lblMuniNac)
        FrmPrincipal.MensajeDeAyuda.Caption = "Seleccione la Ciudad o Municipio de nacimiento del empleado. (ENTER)=Avanzar;(ESC)=Atras;(ESPACIO)=Desplegar;(ARB,ABJ)=Navegar"
    End Sub

    Private Sub lkeMuniNacimiento_Leave(sender As Object, e As EventArgs) Handles lkeMuniNacimiento.Leave
        HDevExpre.SaleControlLkeDEV(lkeMuniNacimiento, lblMuniNac)
    End Sub

    Private Sub dteFechaNacimiento_Enter(sender As Object, e As EventArgs) Handles dteFechaNacimiento.Enter
        HDevExpre.EntraControlDateEditDEV(dteFechaNacimiento, lblFechaNac)
        FrmPrincipal.MensajeDeAyuda.Caption = "Fecha de nacimiento del empleado. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras;(DER)=Desplegar"
    End Sub

    Private Sub dteFechaNacimiento_Leave(sender As Object, e As EventArgs) Handles dteFechaNacimiento.Leave
        HDevExpre.SaleControlDateEditDEV(dteFechaNacimiento, lblFechaNac)
        FrmPrincipal.MensajeDeAyuda.Caption = ""
    End Sub

    Private Sub lkePaisResidencia_Enter(sender As Object, e As EventArgs) Handles lkePaisResidencia.Enter
        HDevExpre.EntraControlLkeDEV(lkePaisResidencia, lblPaisResidencia)
        FrmPrincipal.MensajeDeAyuda.Caption = "Pais de residencia del empleado. (ENTER)=Avanzar;(ESC)=Atras;(ESPACIO)=Desplegar;(ARB,ABJ)=Navegar"
    End Sub

    Private Sub lkePaisResidencia_Leave(sender As Object, e As EventArgs) Handles lkePaisResidencia.Leave
        HDevExpre.SaleControlLkeDEV(lkePaisResidencia, lblPaisResidencia)
        FrmPrincipal.MensajeDeAyuda.Caption = ""
    End Sub

    Private Sub lkeDepResidencia_Enter(sender As Object, e As EventArgs) Handles lkeDepResidencia.Enter
        HDevExpre.EntraControlLkeDEV(lkeDepResidencia, lblDepResidencia)
        FrmPrincipal.MensajeDeAyuda.Caption = "Departamento de residencia del empleado. (ENTER)=Avanzar;(ESC)=Atras;(ESPACIO)=Desplegar;(ARB,ABJ)=Navegar"
    End Sub

    Private Sub lkeDepResidencia_Leave(sender As Object, e As EventArgs) Handles lkeDepResidencia.Leave
        HDevExpre.SaleControlLkeDEV(lkeDepResidencia, lblDepResidencia)
        FrmPrincipal.MensajeDeAyuda.Caption = ""
    End Sub

    Private Sub lkeMuniResidencia_Enter(sender As Object, e As EventArgs) Handles lkeMuniResidencia.Enter
        HDevExpre.EntraControlLkeDEV(lkeMuniResidencia, lblMuniResidencia)
        FrmPrincipal.MensajeDeAyuda.Caption = "Ciudad o Municipio de residencia del empleado. (ENTER)=Avanzar;(ESC)=Atras;(ESPACIO)=Desplegar;(ARB,ABJ)=Navegar"
    End Sub

    Private Sub lkeMuniResidencia_Leave(sender As Object, e As EventArgs) Handles lkeMuniResidencia.Leave
        HDevExpre.SaleControlLkeDEV(lkeMuniResidencia, lblMuniResidencia)
        FrmPrincipal.MensajeDeAyuda.Caption = ""
    End Sub

    Private Sub lkePaisExpDocumento_Enter(sender As Object, e As EventArgs) Handles lkePaisExpDocumento.Enter
        HDevExpre.EntraControlLkeDEV(lkePaisExpDocumento, lblPaisExpDoc)
        FrmPrincipal.MensajeDeAyuda.Caption = "Pais de expedición de documento del empleado. (ENTER)=Avanzar;(ESC)=Atras;(ESPACIO)=Desplegar;(ARB,ABJ)=Navegar"
    End Sub

    Private Sub lkePaisExpDocumento_Leave(sender As Object, e As EventArgs) Handles lkePaisExpDocumento.Leave
        HDevExpre.SaleControlLkeDEV(lkePaisExpDocumento, lblPaisExpDoc)
        FrmPrincipal.MensajeDeAyuda.Caption = ""
    End Sub

    Private Sub lkeDepExpDocumento_Enter(sender As Object, e As EventArgs) Handles lkeDepExpDocumento.Enter
        HDevExpre.EntraControlLkeDEV(lkeDepExpDocumento, lblDepExpDoc)
        FrmPrincipal.MensajeDeAyuda.Caption = "Departamento de expedición de documento del empleado. (ENTER)=Avanzar;(ESC)=Atras;(ESPACIO)=Desplegar;(ARB,ABJ)=Navegar"
    End Sub

    Private Sub lkeDepExpDocumento_Leave(sender As Object, e As EventArgs) Handles lkeDepExpDocumento.Leave
        HDevExpre.SaleControlLkeDEV(lkeDepExpDocumento, lblDepExpDoc)
        FrmPrincipal.MensajeDeAyuda.Caption = ""
    End Sub

    Private Sub lkeMuniExpDocumento_Enter(sender As Object, e As EventArgs) Handles lkeMuniExpDocumento.Enter
        HDevExpre.EntraControlLkeDEV(lkeMuniExpDocumento, lblMuniExpDoc)
        FrmPrincipal.MensajeDeAyuda.Caption = "Ciudad o Municipio de expedición de documento del empleado. (ENTER)=Avanzar;(ESC)=Atras;(ESPACIO)=Desplegar;(ARB,ABJ)=Navegar"
    End Sub

    Private Sub lkeMuniExpDocumento_Leave(sender As Object, e As EventArgs) Handles lkeMuniExpDocumento.Leave
        HDevExpre.SaleControlLkeDEV(lkeMuniExpDocumento, lblMuniExpDoc)
        FrmPrincipal.MensajeDeAyuda.Caption = ""
    End Sub

    Private Sub dteFechaExpDocumento_Enter(sender As Object, e As EventArgs) Handles dteFechaExpDocumento.Enter
        HDevExpre.EntraControlDateEditDEV(dteFechaExpDocumento, lblFechaExpDoc)
        FrmPrincipal.MensajeDeAyuda.Caption = "Seleccione la fecha de expedición del documento del empleado. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras;(DER)=Desplegar"
    End Sub
    Private Sub dteFechaExpDocumento_Leave(sender As Object, e As EventArgs) Handles dteFechaExpDocumento.Leave
        HDevExpre.SaleControlDateEditDEV(dteFechaExpDocumento, lblFechaExpDoc)
        FrmPrincipal.MensajeDeAyuda.Caption = ""
    End Sub


    Private Sub txtComentario_Enter(sender As Object, e As EventArgs) Handles txtComentario.Enter
        HDevExpre.EntraControlDev(, lblComentarios, txtComentario)
        FrmPrincipal.MensajeDeAyuda.Caption = "Agregue un comentario cualquiera acerca del empleado o del registro que ha realizado.(ENTER)=Avanzar;(ESC,ARB)=Atras"
    End Sub

    Private Sub txtComentario_Leave(sender As Object, e As EventArgs) Handles txtComentario.Leave
        HDevExpre.SaleControlDev(, lblComentarios, txtComentario)
        FrmPrincipal.MensajeDeAyuda.Caption = ""
    End Sub
    Private Sub txtComentario_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Down) Then
            btnGuardar.Select()
        End If
    End Sub

    Private Sub dteFecIngresoExpLab_Enter(sender As Object, e As EventArgs) Handles dteFecIngresoExpLab.Enter
        HDevExpre.EntraControlDateEditDEV(dteFecIngresoExpLab, lblFechaIngresoExpLab)
        FrmPrincipal.MensajeDeAyuda.Caption = "Fecha de inicio de labores en la empresa. (ENTER,TAB)=Avanzar;(ESC)=Atras;(DER)=Desplegar;(ARB,ABJ)=Navegar"
    End Sub

    Private Sub dteFecIngresoExpLab_Leave(sender As Object, e As EventArgs) Handles dteFecIngresoExpLab.Leave
        HDevExpre.SaleControlDateEditDEV(dteFecIngresoExpLab, lblFechaIngresoExpLab)
        FrmPrincipal.MensajeDeAyuda.Caption = ""
    End Sub

    Private Sub dteFecRetiroExpLab_Enter(sender As Object, e As EventArgs) Handles dteFecRetiroExpLab.Enter
        HDevExpre.EntraControlDateEditDEV(dteFecRetiroExpLab, lblFechaRetiroExpLab)
        FrmPrincipal.MensajeDeAyuda.Caption = "Fecha en la que finalizó labores en la empresa. (ENTER,TAB)=Avanzar;(ESC)=Atras;(DER)=Desplegar;(ARB,ABJ)=Navegar"
    End Sub

    Private Sub dteFecRetiroExpLab_Leave(sender As Object, e As EventArgs) Handles dteFecRetiroExpLab.Leave
        HDevExpre.SaleControlDateEditDEV(dteFecRetiroExpLab, lblFechaRetiroExpLab)
        FrmPrincipal.MensajeDeAyuda.Caption = ""
    End Sub
    Private Sub ndPersonaAcargo_EditValueChanged(sender As Object, e As EventArgs) Handles ndPersonaAcargo.EditValueChanged
        If ndPersonaAcargo.EditValue <= 0 Then
            ndPersonaAcargo.EditValue = 0
        End If
    End Sub


    'FIN CONTROLES BASICOS


    'CONTROLES AFILIACIONES
    Private Sub lkeEntidadAafiliar_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.F5 Then
            Dim i = CType(e, EventArgs)
            btnAggEntidad_Click(sender, e)
        End If
    End Sub

    Private Sub txtCausaRetiroEntidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCausaRetiroEntidad.KeyPress
        If e.KeyChar = ChrW(Keys.Tab) Then
            btnGuardar.Focus()
        End If
    End Sub

    Private Sub gbxGrillaAfiliaciones_SizeChanged(sender As Object, e As EventArgs) Handles gbxGrillaAfiliaciones.SizeChanged
        Try
            If gvAfilicaciones.Columns.Count = 0 Then Exit Sub
            'Distribuye los anchos de columnas en el gv de los productos de la receta
            gvAfilicaciones.Columns("FechaRegistro").Width = CInt((10 * (gbxGrillaAfiliaciones.Width - 20)) / 100)
            gvAfilicaciones.Columns("Retirado").Width = CInt((10 * (gbxGrillaAfiliaciones.Width - 20)) / 100)
            gvAfilicaciones.Columns("FechaRetiro").Width = CInt((10 * (gbxGrillaAfiliaciones.Width - 20)) / 100)
            gvAfilicaciones.Columns("CausadeRetiro").Width = CInt((34 * (gbxGrillaAfiliaciones.Width - 20)) / 100)
            gvAfilicaciones.Columns("NombreEntidad").Width = CInt((34 * (gbxGrillaAfiliaciones.Width - 20)) / 100)
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "FrmEmpleado_SizeChanged")
        End Try
    End Sub
    'FIN CONTROLES AFILIACIONES

    'CONTROLES INFORMACION ACADEMICA
    Private Sub lkeNivelEducativo_Enter(sender As Object, e As EventArgs) Handles lkeNivelEducativo.Enter
        HDevExpre.EntraControlLkeDEV(lkeNivelEducativo, lblNivelEducativo)
        FrmPrincipal.MensajeDeAyuda.Caption = "Seleccione el nivel educativo que desea agregar. (ENTER)=Avanzar;(ESC)=Atras;(ESPACIO)=Desplegar;(ARB,ABJ)=Navegar"
    End Sub

    Private Sub lkeNivelEducativo_Leave(sender As Object, e As EventArgs) Handles lkeNivelEducativo.Leave
        HDevExpre.SaleControlLkeDEV(lkeNivelEducativo, lblNivelEducativo)
        FrmPrincipal.MensajeDeAyuda.Caption = ""
    End Sub

    Private Sub lkeTituloObtenido_Enter(sender As Object, e As EventArgs) Handles lkeTituloObtenido.Enter
        HDevExpre.EntraControlLkeDEV(lkeTituloObtenido, lblTituloObtenido)
        FrmPrincipal.MensajeDeAyuda.Caption = "Seleccione el título obtenido. (ENTER)=Avanzar;(ESC)=Atras;(ESPACIO)=Desplegar;(ARB,ABJ)=Navegar"
    End Sub

    Private Sub lkeTituloObtenido_Leave(sender As Object, e As EventArgs) Handles lkeTituloObtenido.Leave
        HDevExpre.SaleControlLkeDEV(lkeTituloObtenido, lblTituloObtenido)
        FrmPrincipal.MensajeDeAyuda.Caption = ""
    End Sub

    Private Sub dteFechaGrado_Enter(sender As Object, e As EventArgs) Handles dteFechaGrado.Enter
        HDevExpre.EntraControlDateEditDEV(dteFechaGrado, lblFechaGrado)
        FrmPrincipal.MensajeDeAyuda.Caption = "Seleccione la fecha en la cual termino o se graduo del estudio realizado. (ENTER)=Avanzar;(ESC)=Atras;(DER)=Desplegar;(ARB,ABJ)=Navegar"
    End Sub

    Private Sub dteFechaGrado_Leave(sender As Object, e As EventArgs) Handles dteFechaGrado.Leave
        HDevExpre.SaleControlDateEditDEV(dteFechaGrado, lblFechaGrado)
        FrmPrincipal.MensajeDeAyuda.Caption = ""
    End Sub

    Private Sub lkePaisObtTitulo_Enter(sender As Object, e As EventArgs) Handles lkePaisObtTitulo.Enter
        HDevExpre.EntraControlLkeDEV(lkePaisObtTitulo, lblPaisObtTitulo)
        FrmPrincipal.MensajeDeAyuda.Caption = "Seleccione el pais en el cual obtuvo el título. (ENTER)=Avanzar;(ESC)=Atras;(ESPACIO)=Desplegar;(ARB,ABJ)=Navegar"
    End Sub

    Private Sub lkePaisObtTitulo_Leave(sender As Object, e As EventArgs) Handles lkePaisObtTitulo.Leave
        HDevExpre.SaleControlLkeDEV(lkePaisObtTitulo, lblPaisObtTitulo)
        FrmPrincipal.MensajeDeAyuda.Caption = ""
    End Sub

    Private Sub lkeDepObtTitulo_Enter(sender As Object, e As EventArgs) Handles lkeDepObtTitulo.Enter
        HDevExpre.EntraControlLkeDEV(lkeDepObtTitulo, lblDepObtTitulo)
        FrmPrincipal.MensajeDeAyuda.Caption = "Departamento en el cual obtuvo el titulo. (ENTER)=Avanzar;(ESC)=Atras;(ESPACIO)=Desplegar;(ARB,ABJ)=Navegar"
    End Sub

    Private Sub lkeDepObtTitulo_Leave(sender As Object, e As EventArgs) Handles lkeDepObtTitulo.Leave
        HDevExpre.SaleControlLkeDEV(lkeDepObtTitulo, lblDepObtTitulo)
        FrmPrincipal.MensajeDeAyuda.Caption = ""
    End Sub

    Private Sub lkeMuniObtTitulo_Enter(sender As Object, e As EventArgs) Handles lkeMuniObtTitulo.Enter
        HDevExpre.EntraControlLkeDEV(lkeMuniObtTitulo, lblMuniObtTitulo)
        FrmPrincipal.MensajeDeAyuda.Caption = "Ciudad o Municipio en el cual obtuvo el título. (ENTER)=Avanzar;(ESC)=Atras;(ESPACIO)=Desplegar;(ARB,ABJ)=Navegar"
    End Sub

    Private Sub lkeMuniObtTitulo_Leave(sender As Object, e As EventArgs) Handles lkeMuniObtTitulo.Leave
        HDevExpre.SaleControlLkeDEV(lkeMuniObtTitulo, lblMuniObtTitulo)
        FrmPrincipal.MensajeDeAyuda.Caption = ""
    End Sub

    Private Sub lkeNivelEducativo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles lkeTituloObtenido.KeyPress, lkePaisObtTitulo.KeyPress, lkeMuniObtTitulo.KeyPress, lkeDepObtTitulo.KeyPress, lkeNivelEducativo.KeyPress
        HDevExpre.AvanzaConEnter(e)
    End Sub

    Private Sub ndPersonaAcargo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ndPersonaAcargo.KeyPress
        HDevExpre.AvanzaConEnter(e)
    End Sub

    Private Sub ndDuracion_Enter(sender As Object, e As EventArgs) Handles ndDuracion.Enter
        HDevExpre.EntraControNumericDownDEV(ndDuracion, lblDuracion)
        FrmPrincipal.MensajeDeAyuda.Caption = "Duración del estudio realizado, Horas, Meses o Años, (ENTER,TAB)=Avanzar;(ESC)=Atras;(ARB,ABJ)=Navegar"
    End Sub

    Private Sub ndDuracion_Leave(sender As Object, e As EventArgs) Handles ndDuracion.Leave
        HDevExpre.SaleControlNumercDownDEV(ndDuracion, lblDuracion)
        FrmPrincipal.MensajeDeAyuda.Caption = ""
    End Sub

    Private Sub cbxTipoTiempo_Enter(sender As Object, e As EventArgs) Handles cbxTipoTiempo.Enter
        HDevExpre.EntraControlCbxDEV(cbxTipoTiempo, )
        FrmPrincipal.MensajeDeAyuda.Caption = "Seleccione el tipo de tiempo para mayor claridad. (ENTER,TAB)=Avanzar;(ESC)=Atras;(ARB,ABJ)=Navegar"
    End Sub

    Private Sub cbxTipoTiempo_Leave(sender As Object, e As EventArgs) Handles cbxTipoTiempo.Leave
        HDevExpre.SaleControlCbxDEV(cbxTipoTiempo, )
        FrmPrincipal.MensajeDeAyuda.Caption = ""
    End Sub

    Private Sub cbxTipoTiempo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxTipoTiempo.KeyPress
        HDevExpre.AvanzaConEnter(e)
        'If e.KeyChar = ChrW(Keys.Enter) Or e.KeyChar = ChrW(Keys.Right) Then
        '    lkePaisObtTitulo.Focus()
        'End If
    End Sub

    Private Sub ndDuracion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ndDuracion.KeyPress
        HDevExpre.AvanzaConEnter(e)
    End Sub

    Private Sub ndDuracion_EditValueChanged(sender As Object, e As EventArgs) Handles ndDuracion.EditValueChanged
        If ndDuracion.EditValue <= 0 Then
            ndDuracion.EditValue = 0
        End If
    End Sub

    'FIN CONTROLES INFORMACION ACADEMICA


    'INICIA CONTROLES FAMILIARES
    Private Sub lkeMuniEmpTrabajaFamiliar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles lkeMuniEmpTrabajaFamiliar.KeyPress
        Try

            If e.KeyChar = Convert.ToChar(Keys.Enter) Or e.KeyChar = Convert.ToChar(Keys.Tab) Then
                btnGuardar.Focus()
            End If
            If e.KeyChar = ChrW(Keys.Escape) Then
                lkeDepEmpTrabajaFamiliar.Focus()
            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Sub lkeTipoDocFamiliar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles lkeTipoDocFamiliar.KeyPress, lkePaisEmpTrabajaFamiliar.KeyPress, lkeDepEmpTrabajaFamiliar.KeyPress, dteFecNacFamiliar.KeyPress, lkeParentescoFamiliar.KeyPress
        Try
            HDevExpre.AvanzaConEnter(e)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub lkeTipoDocFamiliar_Enter(sender As Object, e As EventArgs) Handles lkeTipoDocFamiliar.Enter
        HDevExpre.EntraControlLkeDEV(lkeTipoDocFamiliar, lblTipoDocFamiliar)
        FrmPrincipal.MensajeDeAyuda.Caption = "Seleccione el tipo de documento del empleado. (ENTER,TAB)=Avanzar;(ESPACIO)=Desplegar,(ARB,ABJ)=Navegar"
    End Sub

    Private Sub lkeTipoDocFamiliar_Leave(sender As Object, e As EventArgs) Handles lkeTipoDocFamiliar.Leave
        HDevExpre.SaleControlLkeDEV(lkeTipoDocFamiliar, lblTipoDocFamiliar)
        FrmPrincipal.MensajeDeAyuda.Caption = ""
    End Sub

    Private Sub lkeParentescoFamiliar_Enter(sender As Object, e As EventArgs) Handles lkeParentescoFamiliar.Enter
        HDevExpre.EntraControlLkeDEV(lkeParentescoFamiliar, lblParentescoFamiliar)
        FrmPrincipal.MensajeDeAyuda.Caption = "Seleccione el parentesco que tiene con el empleado. (ENTER,TAB)=Avanzar;(ESPACIO)=Desplegar,(ARB,ABJ)=Navegar"
    End Sub

    Private Sub lkeParentescoFamiliar_Leave(sender As Object, e As EventArgs) Handles lkeParentescoFamiliar.Leave
        HDevExpre.SaleControlLkeDEV(lkeParentescoFamiliar, lblParentescoFamiliar)
        FrmPrincipal.MensajeDeAyuda.Caption = ""
    End Sub

    Private Sub dteFecNacFamiliar_Enter(sender As Object, e As EventArgs) Handles dteFecNacFamiliar.Enter
        HDevExpre.EntraControlDateEditDEV(dteFecNacFamiliar, lblFecNacFamiliar)
        FrmPrincipal.MensajeDeAyuda.Caption = "Seleccione la fecha de nacimiento del familiar. (ENTER,TAB)=Avanzar;(DER)=Desplegar,(ARB,ABJ)=Navegar"
    End Sub

    Private Sub dteFecNacFamiliar_Leave(sender As Object, e As EventArgs) Handles dteFecNacFamiliar.Leave
        HDevExpre.SaleControlDateEditDEV(dteFecNacFamiliar, lblFecNacFamiliar)
        FrmPrincipal.MensajeDeAyuda.Caption = ""
    End Sub

    Private Sub lkePaisEmpTrabajaFamiliar_Enter(sender As Object, e As EventArgs) Handles lkePaisEmpTrabajaFamiliar.Enter
        HDevExpre.EntraControlLkeDEV(lkePaisEmpTrabajaFamiliar, lblPaisEmpTrabajaFamiliar)
        FrmPrincipal.MensajeDeAyuda.Caption = "Seleccione el pais donde se encuentra ubicada la empresa en la que labora el familiar. (ENTER,TAB)=Avanzar;(ESPACIO)=Desplegar,(ARB,ABJ)=Navegar"
    End Sub

    Private Sub lkePaisEmpTrabajaFamiliar_Leave(sender As Object, e As EventArgs) Handles lkePaisEmpTrabajaFamiliar.Leave
        HDevExpre.SaleControlLkeDEV(lkePaisEmpTrabajaFamiliar, lblPaisEmpTrabajaFamiliar)
        FrmPrincipal.MensajeDeAyuda.Caption = ""
    End Sub

    Private Sub lkeDepEmpTrabajaFamiliar_Enter(sender As Object, e As EventArgs) Handles lkeDepEmpTrabajaFamiliar.Enter
        HDevExpre.EntraControlLkeDEV(lkeDepEmpTrabajaFamiliar, lblDepEmpTrabajaFamiliar)
        FrmPrincipal.MensajeDeAyuda.Caption = "Seleccione el Departamento donde se encuentra ubicada la empresa en la que labora el familiar. (ENTER,TAB)=Avanzar;(ESPACIO)=Desplegar,(ARB,ABJ)=Navegar"
    End Sub

    Private Sub lkeDepEmpTrabajaFamiliar_Leave(sender As Object, e As EventArgs) Handles lkeDepEmpTrabajaFamiliar.Leave
        HDevExpre.SaleControlLkeDEV(lkeDepEmpTrabajaFamiliar, lblDepEmpTrabajaFamiliar)
        FrmPrincipal.MensajeDeAyuda.Caption = ""
    End Sub

    Private Sub lkeMuniEmpTrabajaFamiliar_Enter(sender As Object, e As EventArgs) Handles lkeMuniEmpTrabajaFamiliar.Enter
        HDevExpre.EntraControlLkeDEV(lkeMuniEmpTrabajaFamiliar, lblMuniEmpTrabajaFamiliar)
        FrmPrincipal.MensajeDeAyuda.Caption = "Seleccione el Municipio donde se encuentra ubicada la empresa en la que labora el familiar. (ENTER,TAB)=Avanzar;(ESPACIO)=Desplegar,(ARB,ABJ)=Navegar"
    End Sub

    Private Sub lkeMuniEmpTrabajaFamiliar_Leave(sender As Object, e As EventArgs) Handles lkeMuniEmpTrabajaFamiliar.Leave
        HDevExpre.SaleControlLkeDEV(lkeMuniEmpTrabajaFamiliar, lblMuniEmpTrabajaFamiliar)
        FrmPrincipal.MensajeDeAyuda.Caption = ""
    End Sub

    Private Sub dteFechaGrado_KeyDown(sender As Object, e As KeyEventArgs) Handles dteFechaGrado.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnGuardar.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            e.Handled = True
            SendKeys.Send("+{TAB}")
        End If
    End Sub
    'FIN CONTROLLES FAMILIARES
#End Region
#Region "Funciones y Procedimientos Generales"
    Private Sub AsignaMensajesAcontroles()
        Try
            txtTipoDoc.MensajedeAyuda = "Seleccione el tipo de documento del empleado. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras, (F5,DER)=Buscar"
            txtGenero.MensajedeAyuda = "Seleccione el genero del empleado. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras, (F5,DER)=Buscar"
            txtProfesion.MensajedeAyuda = "Seleccione la profesión del empleado. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras, (F5,DER)=Buscar"
            txtEstadoCivil.MensajedeAyuda = "Seleccione el estado civil del empleado. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras, (F5,DER)=Buscar"
            txtBanco.MensajedeAyuda = "Seleccion el banco al cual pertenece el empleado. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras, (F5,DER)=Buscar"
            txtClaseLicencia.MensajedeAyuda = "Seleccion la clase de licencia del empleado. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras, (F5,DER)=Buscar"

            txtPrimerNombre.MensajedeAyuda = "Digite el primer nombre del empleado. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
            txtSegNombre.MensajedeAyuda = "Digite el segundo nombre del empleado. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
            txtPrimerApell.MensajedeAyuda = "Digite el primer apellido del empleado. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
            txtSegApell.MensajedeAyuda = "Digite el segundo apellido del empleado. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
            txtTel1.MensajedeAyuda = "Digite el teléfono fijo del empleado. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
            txtTel2.MensajedeAyuda = "Digite el teléfono fijo 2 del empleado. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
            txtCelular.MensajedeAyuda = "Digite el número de célular del empleado. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
            txtWebPage.MensajedeAyuda = "Digite el sitio web del empleado. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
            txtEmail1.MensajedeAyuda = "Digite el correo electrónico principal del empleado *Obligatorio. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
            txtEmail2.MensajedeAyuda = "Digite el correo electrónico secundario del empleado. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
            txtNumCuenta.MensajedeAyuda = "Digite el número de cuenta del empleado. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
            txtBarrio.MensajedeAyuda = "Digite el nombre del barrio en el que vive el empleado. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
            txtDireccion.MensajedeAyuda = "Digite la dirección de residencia del empleado. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
            txtNumLicencia.MensajedeAyuda = "Digite el número de licencia del empleado. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
            txtNumLibreta.MensajedeAyuda = "Digite el número de libreta del empleado. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
            txtDistritoMil.MensajedeAyuda = "Digite el nombre del distrito militar donde se expidió la libreta del empleado. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"

            txtTipoEntidad.MensajedeAyuda = "Seleccion el tipo de entidad a la cual desea afiliar el empleado. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras, (F5,DER)=Buscar"
            txtEntidad.MensajedeAyuda = "Seleccion la entidad a la cual desea afiliar el empleado. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras, (F5,DER)=Buscar"

        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "AsignaMensajesAcontroles")
        End Try
    End Sub

    Private Sub AsignaSqlAcontroles()
        Try
            Dim consultas() As String = {
                "Select TD.TipoIdentificacion As Codigo,TD.NomTipo As Descripcion FROM  CAT_TiposId TD WHERE TD.UsaEmpleados=1 ",
                "Select GN.idgenero As Codigo,GN.nomgenero As Descripcion FROM  CAT_Genero GN ",
                "Select PF.Sec As Codigo, PF.NomProfesion As Descripcion FROM  CAT_Profesiones PF WHERE PF.Vigente=1",
                "Select EC.Sec As Codigo, EC.NomEstado As Descripcion FROM  CAT_EstadoCivil EC WHERE  EC.Vigente=1",
                "Select Sec As Codigo, Nombre As Descripcion FROM  CAT_Bancos WHERE Vigente = 1",
                "Select idClase As Codigo, NomClase As Descripcion FROM  CAT_ClaseLicencia WHERE Vigente = 1",
                "Select CodTipoEnte As Codigo, NomTipoEnte As Descripcion FROM  ZenumTipoEntes"
}

            Dim Datos = SMT_GetDataset(ObjetoApiNomina, consultas)

            txtTipoDoc.DatosDefecto = Datos.Tables(0)
            txtGenero.DatosDefecto = Datos.Tables(1)
            txtProfesion.DatosDefecto = Datos.Tables(2)
            txtEstadoCivil.DatosDefecto = Datos.Tables(3)
            txtBanco.DatosDefecto = Datos.Tables(4)
            txtClaseLicencia.DatosDefecto = Datos.Tables(5)
            txtTipoEntidad.DatosDefecto = Datos.Tables(6)
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "AsignaSqlAcontroles")
        End Try
    End Sub

    Private Sub AsignarLimiteCharacteresControles()
        Try
            txtWebPage.MaximoAncho = 100
            txtEmail1.MaximoAncho = 50
            txtEmail2.MaximoAncho = 50
            txtNumCuenta.MaximoAncho = 80
            txtNumLicencia.MaximoAncho = 50
            txtNumLibreta.MaximoAncho = 20
            txtDistritoMil.MaximoAncho = 200
            txtBarrio.MaximoAncho = 50
            txtDireccion.MaximoAncho = 150
            txtComentario.Properties.MaxLength = 250
            'Afiliaciones
            txtCausaRetiroEntidad.Properties.MaxLength = 250
            'Familiares
            txtNombreFamiliar.MaximoAncho = 200
            txtCelFamiliar.MaximoAncho = 50
            txtOcupacionFamiliar.MaximoAncho = 50
            txtEmpresaTrabajaFamiliar.MaximoAncho = 50
            txtCargoFamiliar.MaximoAncho = 50
            txtTelsEmpTrabajaFamiliar.MaximoAncho = 50
            txtDirEmpTrabajaFamiliar.MaximoAncho = 50
            'Experiencia laboral
            txtEmpresaExpLab.MaximoAncho = 100
            txtCargoExpLab.MaximoAncho = 200
            txtDirEmpExpLab.MaximoAncho = 50
            txtJefeExplab.MaximoAncho = 50
            txtTelEmpExpLab.MaximoAncho = 20
            'Educación
            txtInstitucionObtTitulo.MaximoAncho = 100
            txtMatriculaProfesional.MaximoAncho = 15
        Catch ex As Exception

        End Try
    End Sub
    Private Sub AcomodaForm()
        Try
            tpDatosBasicos.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.DatosBasicosEmleados)
            tpAfiliaciones.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Afiliaciones)
            tpFamiliares.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Familiares)
            tpExpLaboral.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.ExperienciaLaboral)
            tpInfAcademica.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.InformacionAcademica)
            btnGuardar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Guardar)
            btnLimpiar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Limpiar)
            btnAmpliaImagenes.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.AmpliarImagenes)
            btnEliminar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.EliminarGris)
            btnSalir.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.SalirCuadroConX)
            btnAddNivelEducativo.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Agregar)
            btnAddTitulo.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Agregar)
            'btnAggEntidad.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Agregar)
            btnImprimir.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Imprimir)
            btnBuscarEmp.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Buscar)
            grbTipoEducacion.SelectedIndex = 1
            dteFechaGrado.DateTime = Datos.Smt_FechaDelServidor
            dteFechaExpDocumento.DateTime = Datos.Smt_FechaDelServidor
            dteFechaNacimiento.DateTime = Datos.Smt_FechaDelServidor
            dteFecIngresoExpLab.DateTime = Datos.Smt_FechaDelServidor
            dteFecRetiroExpLab.DateTime = Datos.Smt_FechaDelServidor
            dteFecNacFamiliar.DateTime = Datos.Smt_FechaDelServidor
            dteFechaRegistroEmpEntidad.DateTime = Datos.Smt_FechaDelServidor
            lkeClaseLibreta.Properties.NullText = "Seleccione..."

            'Formato Gallery Experiencia laboral
            GalleryControlExpLaboral.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.Squeeze
            GalleryControlExpLaboral.Gallery.ImageSize = New Size(120, 100)
            GalleryControlExpLaboral.Gallery.ShowItemText = True
            grupoImgsExpLaboral.CaptionAlignment = GalleryItemGroupCaptionAlignment.Center
            GalleryControlExpLaboral.Gallery.ItemCheckMode = Gallery.ItemCheckMode.SingleCheck
            GalleryControlExpLaboral.Gallery.Groups.Add(grupoImgsExpLaboral)

            'Formato Gallery Informacion Academica
            GalleryControlEstudios.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.Squeeze
            GalleryControlEstudios.Gallery.ImageSize = New Size(120, 100)
            GalleryControlEstudios.Gallery.ShowItemText = True
            grupoImgsInfAcademica.CaptionAlignment = GalleryItemGroupCaptionAlignment.Center
            GalleryControlEstudios.Gallery.ItemCheckMode = Gallery.ItemCheckMode.SingleCheck
            GalleryControlEstudios.Gallery.Groups.Add(grupoImgsInfAcademica)

            'Formato Gallery Afiliaciones
            GalleryControlAfiliaciones.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.Squeeze
            GalleryControlAfiliaciones.Gallery.ImageSize = New Size(120, 100)
            GalleryControlAfiliaciones.Gallery.ShowItemText = True
            grupoImgsAfiliaciones.CaptionAlignment = GalleryItemGroupCaptionAlignment.Center
            GalleryControlAfiliaciones.Gallery.ItemCheckMode = Gallery.ItemCheckMode.SingleCheck
            GalleryControlAfiliaciones.Gallery.Groups.Add(grupoImgsAfiliaciones)



        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, " AcomodaForm empleado")
        End Try
    End Sub
#End Region
#Region "Llena los LookUpEdit al iniciar"
    Private Sub LlenaTodosLkes()
        Try
            'Llena lkedit Tipos de documento
            Dim sql As String = "Select TD.TipoIdentificacion As Codigo,TD.NomTipo As Descripcion FROM CAT_TiposId TD WHERE TD.UsaEmpleados=1 "
            Dim dt As DataTable = SMT_AbrirTabla(ObjetoApiNomina, sql)
            If dt.Rows.Count > 0 Then
                'lkeTipoDoc.Properties.DataSource = dt
                'lkeTipoDoc.Properties.ValueMember = "Codigo"
                'lkeTipoDoc.Properties.DisplayMember = "Descripcion"
                'lkeTipoDoc.Properties.PopulateColumns()
                'lkeTipoDoc.Properties.Columns(0).Visible = False
                'lkeTipoDoc.ItemIndex = 0
                'Tipo de documeto Pestaña Familiares
                lkeTipoDocFamiliar.Properties.DataSource = dt
                lkeTipoDocFamiliar.Properties.ValueMember = "Codigo"
                lkeTipoDocFamiliar.Properties.DisplayMember = "Descripcion"
                'lkeTipoDocFamiliar.Properties.PopulateColumns()
                lkeTipoDocFamiliar.Properties.Columns(0).Visible = False
                lkeTipoDocFamiliar.ItemIndex = 0
                If dt.Rows.Count < 10 Then lkeTipoDocFamiliar.Properties.DropDownRows = dt.Rows.Count
            End If
            ''Llena Lkedit GenerolkeParentescoFamiliar
            'sql = "Select GN.idgenero As Codigo,GN.nomgenero As Descripcion FROM CAT_Genero GN "
            'dt = SMT_AbrirTabla(ObjetoApiNomina, sql)
            'If dt.Rows.Count > 0 Then
            '    lkeGenero.Properties.DataSource = dt
            '    lkeGenero.Properties.ValueMember = "Codigo"
            '    lkeGenero.Properties.DisplayMember = "Descripcion"
            '    lkeGenero.Properties.PopulateColumns()
            '    lkeGenero.Properties.Columns(0).Visible = False
            '    lkeGenero.ItemIndex = 0
            'End If
            ''Llena lkedit Profesión
            'sql = "Select PF.IdProfesion As Codigo, PF.NomProfesion As Descripcion FROM CAT_Profesiones PF WHERE PF.Vigente=1"
            'dt = SMT_AbrirTabla(ObjetoApiNomina, sql)
            'If dt.Rows.Count > 0 Then
            '    lkeProfesion.Properties.DataSource = dt
            '    lkeProfesion.Properties.ValueMember = "Codigo"
            '    lkeProfesion.Properties.DisplayMember = "Descripcion"
            '    lkeProfesion.Properties.PopulateColumns()
            '    lkeProfesion.Properties.Columns(0).Visible = False
            '    lkeProfesion.ItemIndex = 0
            'End If
            ''Llena lkedit Estado Civil
            'sql = "Select EC.IdEstado As Codigo, EC.NomEstado As Descripcion FROM CAT_EstadoCivil EC WHERE  EC.Vigente=1"
            'dt = SMT_AbrirTabla(ObjetoApiNomina, sql)
            'If dt.Rows.Count > 0 Then
            '    lkeEstCivil.Properties.DataSource = dt
            '    lkeEstCivil.Properties.ValueMember = "Codigo"
            '    lkeEstCivil.Properties.DisplayMember = "Descripcion"
            '    lkeEstCivil.Properties.PopulateColumns()
            '    lkeEstCivil.Properties.Columns(0).Visible = False
            '    lkeEstCivil.ItemIndex = 0
            'End If
            ''Llena lkedit Clase de Libreta militar
            sql = "Select CL.Sec As Codigo, CL.NomClaseLib As Descripcion FROM CAT_ClaseLibreta CL WHERE CL.Vigente=1"
            dt = SMT_AbrirTabla(ObjetoApiNomina, sql)
            If dt.Rows.Count > 0 Then
                lkeClaseLibreta.Properties.DataSource = dt
                lkeClaseLibreta.Properties.ValueMember = "Codigo"
                lkeClaseLibreta.Properties.DisplayMember = "Descripcion"
                lkeClaseLibreta.Properties.PopulateColumns()
                lkeClaseLibreta.Properties.Columns(0).Visible = False
                lkeClaseLibreta.ItemIndex = 0
                lkeClaseLibreta.Properties.DropDownRows = dt.Rows.Count
            End If
            'Llena Lkedit Pais de Nacimiento
            sql = "Select PS.Sec As Codigo, PS.NomPais As Descripcion FROM G_Pais PS"
            dt = SMT_AbrirTabla(ObjetoApiNomina, sql)
            Dim filas() As DataRow = dt.Select("Codigo = 169")
            If dt.Rows.Count > 0 Then
                lkePaisNacimiento.Properties.DataSource = dt
                lkePaisNacimiento.Properties.ValueMember = "Codigo"
                lkePaisNacimiento.Properties.DisplayMember = "Descripcion"
                lkePaisNacimiento.Properties.PopulateColumns()
                lkePaisNacimiento.Properties.Columns(0).Visible = False
                lkePaisNacimiento.EditValue = AsignarCampo(filas(0), "Codigo")
                If dt.Rows.Count < 10 Then lkePaisNacimiento.Properties.DropDownRows = dt.Rows.Count
                'Llena Lkedit Pais de Residencia
                lkePaisResidencia.Properties.DataSource = dt
                lkePaisResidencia.Properties.ValueMember = "Codigo"
                lkePaisResidencia.Properties.DisplayMember = "Descripcion"
                lkePaisResidencia.Properties.PopulateColumns()
                lkePaisResidencia.Properties.Columns(0).Visible = False
                lkePaisResidencia.EditValue = AsignarCampo(filas(0), "Codigo")
                If dt.Rows.Count < 10 Then lkePaisResidencia.Properties.DropDownRows = dt.Rows.Count
                'Llena Lkedit Pais de Expedicion de Documento
                lkePaisExpDocumento.Properties.DataSource = dt
                lkePaisExpDocumento.Properties.ValueMember = "Codigo"
                lkePaisExpDocumento.Properties.DisplayMember = "Descripcion"
                lkePaisExpDocumento.Properties.PopulateColumns()
                lkePaisExpDocumento.Properties.Columns(0).Visible = False
                lkePaisExpDocumento.EditValue = AsignarCampo(filas(0), "Codigo")
                If dt.Rows.Count < 10 Then lkePaisExpDocumento.Properties.DropDownRows = dt.Rows.Count
                'Llena Lkedit Pais de Obtuvo titulo
                lkePaisObtTitulo.Properties.DataSource = dt
                lkePaisObtTitulo.Properties.ValueMember = "Codigo"
                lkePaisObtTitulo.Properties.DisplayMember = "Descripcion"
                'lkePaisObtTitulo.Properties.PopulateColumns()
                lkePaisObtTitulo.Properties.Columns(0).Visible = False
                lkePaisObtTitulo.EditValue = AsignarCampo(filas(0), "Codigo")
                If dt.Rows.Count < 10 Then lkePaisObtTitulo.Properties.DropDownRows = dt.Rows.Count
                'Llena Lkedit Pais Empresa Labora el Familair
                lkePaisEmpTrabajaFamiliar.Properties.DataSource = dt
                lkePaisEmpTrabajaFamiliar.Properties.ValueMember = "Codigo"
                lkePaisEmpTrabajaFamiliar.Properties.DisplayMember = "Descripcion"
                'lkePaisObtTitulo.Properties.PopulateColumns()
                lkePaisEmpTrabajaFamiliar.Properties.Columns(0).Visible = False
                lkePaisEmpTrabajaFamiliar.EditValue = AsignarCampo(filas(0), "Codigo")
                If dt.Rows.Count < 10 Then lkePaisEmpTrabajaFamiliar.Properties.DropDownRows = dt.Rows.Count
            End If

        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "LlenaTodosLkes")
        End Try
    End Sub
#End Region
#Region "Llena los LookUpEdit de Departamento y Municipios Con eventos"
    Private Sub lkePaisNacimiento_EditValueChanged(sender As Object, e As EventArgs) Handles lkePaisNacimiento.EditValueChanged
        Dim sql As String = String.Format("Select DP.Sec As Codigo, DP.NomDpto As Descripcion FROM G_Departamento DP WHERE DP.Pais={0}",
                                          lkePaisNacimiento.EditValue)
        HDevExpre.LlenaLkeConDt(lkeDepNacimiento, sql, "Descripcion", "Codigo")
    End Sub

    Private Sub lkeDepNacimiento_EditValueChanged(sender As Object, e As EventArgs) Handles lkeDepNacimiento.EditValueChanged
        Dim sql As String = String.Format("Select MN.IdMunicipio As Codigo, MN.NombreMunicipio As Descripcion FROM G_Municipio MN WHERE MN.Departamento={0}", lkeDepNacimiento.EditValue)
        HDevExpre.LlenaLkeConDt(lkeMuniNacimiento, sql, "Descripcion", "Codigo")
    End Sub

    Private Sub lkePaisResidencia_EditValueChanged(sender As Object, e As EventArgs) Handles lkePaisResidencia.EditValueChanged
        Dim sql As String = String.Format("Select DP.Sec As Codigo, DP.NomDpto As Descripcion FROM G_Departamento DP WHERE DP.Pais={0}",
                                  lkePaisResidencia.EditValue)
        HDevExpre.LlenaLkeConDt(lkeDepResidencia, sql, "Descripcion", "Codigo")
    End Sub

    Private Sub lkeDepResidencia_EditValueChanged(sender As Object, e As EventArgs) Handles lkeDepResidencia.EditValueChanged
        Dim sql As String = String.Format("Select MN.IdMunicipio As Codigo, MN.NombreMunicipio As Descripcion FROM G_Municipio MN WHERE MN.Departamento={0}", lkeDepResidencia.EditValue)
        HDevExpre.LlenaLkeConDt(lkeMuniResidencia, sql, "Descripcion", "Codigo")
    End Sub

    Private Sub lkePaisExpDocumento_EditValueChanged(sender As Object, e As EventArgs) Handles lkePaisExpDocumento.EditValueChanged
        Dim sql As String = String.Format("Select DP.Sec As Codigo, DP.NomDpto As Descripcion FROM G_Departamento DP WHERE DP.Pais={0}",
                               lkePaisExpDocumento.EditValue)
        HDevExpre.LlenaLkeConDt(lkeDepExpDocumento, sql, "Descripcion", "Codigo")
    End Sub
    Private Sub lkeDepExpDocumento_EditValueChanged(sender As Object, e As EventArgs) Handles lkeDepExpDocumento.EditValueChanged
        Dim sql As String = String.Format("Select MN.IdMunicipio As Codigo, MN.NombreMunicipio As Descripcion FROM G_Municipio MN WHERE MN.Departamento={0}", lkeDepExpDocumento.EditValue)
        HDevExpre.LlenaLkeConDt(lkeMuniExpDocumento, sql, "Descripcion", "Codigo")
    End Sub

    Private Sub lkePaisEmpTrabajaFamiliar_EditValueChanged(sender As Object, e As EventArgs) Handles lkePaisEmpTrabajaFamiliar.EditValueChanged
        Dim sql As String = String.Format("Select DP.Sec As Codigo, DP.NomDpto As Descripcion FROM G_Departamento DP WHERE DP.Pais={0}",
                             lkePaisEmpTrabajaFamiliar.EditValue)
        HDevExpre.LlenaLkeConDt(lkeDepEmpTrabajaFamiliar, sql, "Descripcion", "Codigo")
    End Sub

    Private Sub lkeDepEmpTrabajaFamiliar_EditValueChanged(sender As Object, e As EventArgs) Handles lkeDepEmpTrabajaFamiliar.EditValueChanged
        Dim sql As String = String.Format("Select MN.IdMunicipio As Codigo, MN.NombreMunicipio As Descripcion FROM G_Municipio MN WHERE MN.Departamento={0}",
                                          lkeDepEmpTrabajaFamiliar.EditValue)
        HDevExpre.LlenaLkeConDt(lkeMuniEmpTrabajaFamiliar, sql, "Descripcion", "Codigo")
    End Sub

#End Region
#Region "Botones Principales"
    Private Sub btnCargarImagen_Click(sender As Object, e As EventArgs)
        Try
            Dim openFile As New OpenFileDialog
            Dim emp As New ServiceEmpleados()
            With openFile
                .Title = "Seleccione una Fotografía"
                .Filter = "Imagenes (*.jpg, *.bmp, *.gif, *.png) |*.jpg; *.bmp; *.gif; *.png"
                .ShowDialog()
            End With
            If TabPageSeleccionada = TabSeleccionado.DatosBasicos Then
                If openFile.FileName <> "" Then
                    Dim img As New Bitmap(openFile.FileName)
                    If ActualizandoDatosBasicos Then emp.GuardaImagenSola(img, Me.Sec, HEmpleado.TiposDeImagenes.Empleado, Me.Sec, True)
                    pcbFotografiaEmpleado.Image = img
                End If
            ElseIf TabPageSeleccionada = TabSeleccionado.Afiliaciones Then
                If openFile.FileName <> "" Then
                    Dim img As New Bitmap(openFile.FileName)
                    HEmpleado.CargarImagenAgaleria(GalleryControlAfiliaciones.Gallery.Groups.Item(0), img)
                End If
            ElseIf TabPageSeleccionada = TabSeleccionado.Familiares Then
                If openFile.FileName <> "" Then
                    Dim img As New Bitmap(openFile.FileName)
                    If ActualizandoFamiliares Then emp.GuardaImagenSola(img, Me.Sec, HEmpleado.TiposDeImagenes.Familiares, Me.SecRegFamiliar, True)
                    pcbImgFamiliar.Image = img
                End If
            ElseIf TabPageSeleccionada = TabSeleccionado.ExpereienciaLaboral Then
                If openFile.FileName <> "" Then
                    Dim img As New Bitmap(openFile.FileName)
                    HEmpleado.CargarImagenAgaleria(GalleryControlExpLaboral.Gallery.Groups.Item(0), img)
                End If
            ElseIf TabPageSeleccionada = TabSeleccionado.InformacionAcademica Then
                If openFile.FileName <> "" Then
                    Dim img As New Bitmap(openFile.FileName)
                    HEmpleado.CargarImagenAgaleria(GalleryControlEstudios.Gallery.Groups.Item(0), img)
                End If
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "btnCargarImagen_Click")
        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If TabPageSeleccionada = TabSeleccionado.DatosBasicos Then
            GuardaDatosBasicos()
        ElseIf TabPageSeleccionada = TabSeleccionado.Afiliaciones Then
            GuardaAfiliacion()
        ElseIf TabPageSeleccionada = TabSeleccionado.Familiares Then
            GuardaFamiliar()
        ElseIf TabPageSeleccionada = TabSeleccionado.ExpereienciaLaboral Then
            GuardaExpLaboral()
        ElseIf TabPageSeleccionada = TabSeleccionado.InformacionAcademica Then
            GuardaInfAcademica()
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        If TabPageSeleccionada = TabSeleccionado.DatosBasicos Then
            LimpiarCampos()
            txtDocEmpleado.Text = ""
        ElseIf TabPageSeleccionada = TabSeleccionado.Afiliaciones Then
            LimpiarCamposAfiliaciones()
        ElseIf TabPageSeleccionada = TabSeleccionado.Familiares Then
            LimpiarCamposFamiliares()
        ElseIf TabPageSeleccionada = TabSeleccionado.ExpereienciaLaboral Then
            LimpiarCamposExpLab()
        ElseIf TabPageSeleccionada = TabSeleccionado.InformacionAcademica Then
            LimpiarCamposInfAcademica()
        End If
    End Sub

    Private Sub btnQuitarImageGaleria_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnQuitarImageGaleria.ItemClick
        Try

            If TabPageSeleccionada = TabSeleccionado.DatosBasicos Then

            ElseIf TabPageSeleccionada = TabSeleccionado.Afiliaciones Then
                If HDevExpre.MsgSamit("Seguro que desea eliminar la imagen selccionada?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.OK Then
                    grupoImgsAfiliaciones.Items.Remove(ImagenSeleccionadaAfiliacion)
                End If
            ElseIf TabPageSeleccionada = TabSeleccionado.Familiares Then

            ElseIf TabPageSeleccionada = TabSeleccionado.ExpereienciaLaboral And ActualizandoExpLab Then
                grupoImgsExpLaboral.Items.Remove(ImagenSeleccionadaExpLaboral)
            ElseIf TabPageSeleccionada = TabSeleccionado.InformacionAcademica Then
                grupoImgsInfAcademica.Items.Remove(ImagenSeleccionadaInfAcademica)
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Function EliminarEmpleado(secEmpleado As String) As Boolean
        Try
            ' Crear el request
            Dim request As New EliminarEmpleadoRequest(CInt(secEmpleado))

            ' Ejecutar el procedimiento almacenado
            Dim resp = SMT_EjecutaProcedimientos(ObjetoApiNomina, "SP_EliminarEmpleado", request.ToJObject())

            ' IMPORTANTE: Reutilizamos la misma clase DynamicDeleteResponse
            Dim response = resp.ToObject(Of DynamicDeleteResponse)()

            ' Procesar respuesta
            If response.EsExitoso Then
                ' Log opcional
                Console.WriteLine($"Empleado eliminado: {response.RegistrosEliminados} registros afectados en total")
                Return True

            ElseIf response.EsAdvertencia Then
                ' El empleado no existe
                HDevExpre.MensagedeError(response.Mensaje)
                Return False

            Else ' Es Error
                ' Puede ser porque tiene contratos u otro error
                HDevExpre.MensagedeError(response.Mensaje)
                Return False
            End If

        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "EliminarEmpleado")
            Return False
        End Try
    End Function

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If TabPageSeleccionada = TabSeleccionado.DatosBasicos Then
                If ActualizandoDatosBasicos Then
                    If ExisteDato("Contratos", "Empleado ='" + Sec + "'", ObjetoApiNomina) Then
                        HDevExpre.MensagedeError("Este empleado ya tiene un contrato asignado y no puede ser eliminado!")
                    Else
                        If HDevExpre.MsgSamit("Seguro que desea eliminar este empleado?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.OK Then
                            If EliminarEmpleado(Sec) Then
                                LimpiarCampos()
                            Else
                                HDevExpre.MensagedeError("Error al eiminar el empleado!")
                            End If
                        End If

                    End If
                End If
            ElseIf TabPageSeleccionada = TabSeleccionado.Afiliaciones Then
                If ActualizandoAfiliaciones And SecRegAfiliacion <> "" Then
                    If HDevExpre.MsgSamit("Seguro que desea eliminar la Afiliación Seleccionada", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.OK Then
                        If Not EliminarAfiliacion(Me.SecRegAfiliacion) Then
                            HDevExpre.MensagedeError("Error al eliminar la Afiliación!")
                        Else
                            LimpiarCamposAfiliaciones()
                            LlenaGrillaAfiliaciones(Me.Sec)
                        End If
                    End If
                End If
            ElseIf TabPageSeleccionada = TabSeleccionado.Familiares Then
                If ActualizandoFamiliares And SecRegFamiliar <> "" Then
                    If HDevExpre.MsgSamit("Seguro que desea eliminar el familiar seleccionado?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.OK Then
                        If Not EliminaFamiliar(Me.SecRegFamiliar, Me.Sec) Then
                            HDevExpre.MensagedeError("Error a eliminar el registro")
                        Else
                            LimpiarCamposFamiliares()
                            LlenaGrillaFamiliares(Me.Sec)
                        End If
                    End If
                Else
                    HDevExpre.MensagedeError("Debe cargar un item para editar o eliminar!")
                End If
            ElseIf TabPageSeleccionada = TabSeleccionado.ExpereienciaLaboral Then
                If ActualizandoExpLab And secRegistroExpLab <> "" Then
                    If HDevExpre.MsgSamit("Seguro que desea eliminar la experiencia laboral seleccionada?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.OK Then
                        If Not EliminaExpLaboral(Me.secRegistroExpLab, Me.Sec) Then
                            HDevExpre.MensagedeError("Error a eliminar el registro")
                        Else
                            LimpiarCamposExpLab()
                            LlenaGrillaExpLaboral(Me.Sec)
                        End If
                    End If
                Else
                    HDevExpre.MensagedeError("Debe cargar un item para editar o eliminar!")
                End If
            ElseIf TabPageSeleccionada = TabSeleccionado.InformacionAcademica Then
                If ActualizandoEstudios And secRegInfAcademica <> "" Then
                    If HDevExpre.MsgSamit("Seguro que desea eliminar estudio realizado que ha secciono?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.OK Then
                        If Not EliminaInfAcademica(Me.secRegInfAcademica, Me.Sec) Then
                            HDevExpre.MensagedeError("Error a eliminar el registro")
                        Else
                            LimpiarCamposInfAcademica()
                            LlenaGrillaInfAcademica(Me.Sec)
                        End If
                    End If
                Else
                    HDevExpre.MensagedeError("Debe cargar un item para editar o eliminar!")
                End If
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "btnEliminar_Click")
        End Try
    End Sub
    Private Sub btnAmpliaImagenes_Click(sender As Object, e As EventArgs) Handles btnAmpliaImagenes.Click
        Try
            Dim dt As New DataTable
            Dim Filtro As String = ""
            Dim rows As DataRow()
            Dim fila As DataRow
            dt.Columns.Add("SecIngreso")
            dt.Columns.Add("Foto", GetType(Byte()))
            dt.Columns.Add("Predeterminada", GetType(Boolean))
            CargaImagenesEmpleado()
            If TabPageSeleccionada = TabSeleccionado.DatosBasicos Then
                If dtImagenes.Rows.Count > 0 Then
                    Filtro = String.Format("IdEmpleado={0} AND Tipo={1} AND SecTipo={2} ", Me.Sec,
                                             Convert.ToInt32(HEmpleado.TiposDeImagenes.Empleado),
                                             Me.Sec)
                    rows = dtImagenes.Select(Filtro, "")
                    For i = 0 To rows.Length - 1
                        fila = dt.NewRow
                        fila("SecIngreso") = rows(i)("SecIngreso")
                        fila("Foto") = rows(i)("Foto")
                        fila("Predeterminada") = rows(i)("Predeterminada")
                        dt.Rows.Add(fila)
                        dt.AcceptChanges()
                    Next
                    Dim frm As New FrmVerImagenes(HEmpleado.TiposDeImagenes.Empleado,
                                             Me.Sec,
                                             Me.Sec,
                                             dt)
                    frm.Text = "Imagenes cargadas al Familiar"
                    frm.TienePredeterinada = True
                    frm.ShowDialog()
                Else
                    HDevExpre.MensagedeError("Al parecer no hay imagenes para visualizar o no ha cargado ningun empleado!")
                End If
            ElseIf TabPageSeleccionada = TabSeleccionado.Familiares Then
                If Not IsNothing(pcbImgFamiliar.Image) And dtImagenes.Rows.Count > 0 Then
                    Filtro = String.Format("IdEmpleado={0} AND Tipo={1} AND SecTipo={2} ", Me.Sec,
                                             Convert.ToInt32(HEmpleado.TiposDeImagenes.Familiares),
                                             Me.SecRegFamiliar)
                    rows = dtImagenes.Select(Filtro, "")
                    For i = 0 To rows.Length - 1
                        fila = dt.NewRow
                        fila("SecIngreso") = rows(i)("SecIngreso")
                        fila("Foto") = rows(i)("Foto")
                        fila("Predeterminada") = rows(i)("Predeterminada")
                        dt.Rows.Add(fila)
                        dt.AcceptChanges()
                    Next
                    Dim frm As New FrmVerImagenes(HEmpleado.TiposDeImagenes.Familiares,
                                             Me.SecRegFamiliar,
                                             Me.Sec,
                                             dt)
                    frm.Text = "Imagenes cargadas al Familiar"
                    frm.TienePredeterinada = True
                    frm.ShowDialog()
                Else
                    HDevExpre.MensagedeError("Al parecer no hay imagenes para visualizar o no ha cargado ningun empleado!")
                End If
            ElseIf TabPageSeleccionada = TabSeleccionado.ExpereienciaLaboral Then
                If grupoImgsExpLaboral.Items.Count > 0 And dtImagenes.Rows.Count > 0 Then
                    Filtro = String.Format("IdEmpleado={0} AND Tipo={1} AND SecTipo={2} ", Me.Sec,
                                             Convert.ToInt32(HEmpleado.TiposDeImagenes.ExperienciaLaboral),
                                             Me.secRegistroExpLab)
                    rows = dtImagenes.Select(Filtro, "")
                    For i = 0 To rows.Length - 1
                        fila = dt.NewRow
                        fila("SecIngreso") = rows(i)("SecIngreso")
                        fila("Foto") = rows(i)("Foto")
                        fila("Predeterminada") = rows(i)("Predeterminada")
                        dt.Rows.Add(fila)
                        dt.AcceptChanges()
                    Next
                    Dim frm As New FrmVerImagenes(HEmpleado.TiposDeImagenes.ExperienciaLaboral,
                                             Me.secRegistroExpLab,
                                             Me.Sec,
                                             dt)
                    frm.Text = "Vista de Certificados Experiencia Laboral"
                    frm.TienePredeterinada = False
                    frm.ShowDialog()
                Else
                    HDevExpre.MensagedeError("Al parecer no hay imagenes para visualizar o no ha cargado ningun empleado!")
                End If
            ElseIf TabPageSeleccionada = TabSeleccionado.Afiliaciones Then
                If grupoImgsAfiliaciones.Items.Count > 0 And dtImagenes.Rows.Count > 0 Then
                    Filtro = String.Format("IdEmpleado={0} AND Tipo={1} AND SecTipo={2} ", Me.Sec,
                                             Convert.ToInt32(HEmpleado.TiposDeImagenes.Afiliaciones),
                                             Me.SecRegAfiliacion)
                    rows = dtImagenes.Select(Filtro, "")
                    For i = 0 To rows.Length - 1
                        fila = dt.NewRow
                        fila("SecIngreso") = rows(i)("SecIngreso")
                        fila("Foto") = rows(i)("Foto")
                        'fila("Predeterminada") = rows(i)("Predeterminada")
                        dt.Rows.Add(fila)
                        dt.AcceptChanges()
                    Next
                    Dim frm As New FrmVerImagenes(HEmpleado.TiposDeImagenes.Afiliaciones,
                                             Me.SecRegAfiliacion, Me.Sec, dt)
                    frm.Text = "Vista de Certificados afiliaciones del empleado."
                    frm.ShowDialog()
                Else
                    HDevExpre.MensagedeError("Al parecer no hay imagenes para visualizar o no ha cargado ningun empleado!")
                End If
            ElseIf TabPageSeleccionada = TabSeleccionado.InformacionAcademica Then
                If grupoImgsInfAcademica.Items.Count > 0 And dtImagenes.Rows.Count > 0 Then
                    Filtro = String.Format("IdEmpleado={0} AND Tipo={1} AND SecTipo={2} ", Me.Sec,
                                             Convert.ToInt32(HEmpleado.TiposDeImagenes.Estduios),
                                             Me.secRegInfAcademica)
                    rows = dtImagenes.Select(Filtro, "")
                    For i = 0 To rows.Length - 1
                        fila = dt.NewRow
                        fila("SecIngreso") = rows(i)("SecIngreso")
                        fila("Foto") = rows(i)("Foto")
                        dt.Rows.Add(fila)
                        dt.AcceptChanges()
                    Next
                    Dim frm As New FrmVerImagenes(HEmpleado.TiposDeImagenes.Estduios,
                                             Me.secRegInfAcademica,
                                             Me.Sec,
                                             dt)
                    frm.Text = "Vista de Certificados Estudiantiles"
                    frm.TienePredeterinada = False
                    frm.ShowDialog()
                Else
                    HDevExpre.MensagedeError("Al parecer no hay imagenes para visualizar o no ha cargado ningun empleado!")
                End If
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "btnAmpliaImagenes_Click")
        End Try
    End Sub
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Try

            If ActualizandoDatosBasicos Then
                Dim frm As New FrmOpcImpEmpleado
                Dim rows As DataRow()
                Dim dtEstudios As DataTable
                frm.ckbInfAcademica.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Eliminar)
                frm.ckbExpLaboral.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Eliminar)
                frm.ckbFamiliares.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Eliminar)
                frm.ckbAfiliaciones.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Eliminar)
                frm.ckbEducacionNoFormal.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Eliminar)
                frm.ckbDatosBasicos.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Eliminar)

                If gvAfilicaciones.RowCount = 0 Then frm.ckbAfiliaciones.Enabled = False
                If gvExpLaboral.RowCount = 0 Then frm.ckbExpLaboral.Enabled = False
                If gvFamiliares.RowCount = 0 Then frm.ckbFamiliares.Enabled = False
                If gvEstudios.RowCount > 0 Then
                    dtEstudios = CType(gcEstudios.DataSource, DataTable)
                    rows = dtEstudios.Select("EsFormal=False")
                    If rows.Length = 0 Then
                        frm.ckbEducacionNoFormal.Enabled = False
                    End If
                Else
                    frm.ckbEducacionNoFormal.Enabled = False
                    frm.ckbInfAcademica.Enabled = False
                End If

                If TabPageSeleccionada = TabSeleccionado.DatosBasicos Then
                    frm.ckbDatosBasicos.Checked = True
                ElseIf TabPageSeleccionada = TabSeleccionado.Afiliaciones Then
                    If gvAfilicaciones.RowCount > 0 Then frm.ckbAfiliaciones.Checked = True
                ElseIf TabPageSeleccionada = TabSeleccionado.ExpereienciaLaboral Then
                    If gvExpLaboral.RowCount > 0 Then frm.ckbExpLaboral.Checked = True
                ElseIf TabPageSeleccionada = TabSeleccionado.Familiares Then
                    If gvFamiliares.RowCount > 0 Then frm.ckbFamiliares.Checked = True
                ElseIf TabPageSeleccionada = TabSeleccionado.InformacionAcademica Then
                    If gvEstudios.RowCount > 0 Then
                        frm.ckbInfAcademica.Checked = True
                        dtEstudios = CType(gcEstudios.DataSource, DataTable)
                        rows = dtEstudios.Select("EsFormal=False")
                        If rows.Length = 0 Then
                            frm.ckbEducacionNoFormal.Enabled = False
                        Else
                            frm.ckbEducacionNoFormal.Checked = True
                        End If
                    End If
                End If
                frm.ShowDialog()
                If Not frm.Cancela Then
                    ImprimeDatosEmpleado(ImpDatosBasicos,
                                         ImpExpLaboral,
                                         ImpInfAcademica,
                                         ImpEduNoFormal,
                                         ImpInfFamiliares,
                                         ImpAfiliaciones)
                End If
            Else
                HDevExpre.MensagedeError("Al parecer no se ha cargado ningún empleado, lo sentimos!")
            End If

        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "btnImprimir_Click")
        End Try
    End Sub
#End Region
#Region "Funciones y Procedimientos --> Experiencia Laboral"

    Private Sub CreaGrillaExpLaboral()
        gvExpLaboral.Columns.Clear()
        HDevExpre.CreaColumnasG(gvExpLaboral, "SecIngreso", "SecIngreso", False, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 0, 0)
        HDevExpre.CreaColumnasG(gvExpLaboral, "Empresa", "Empresa", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 15, gbxGrillaExpLab.Width)
        HDevExpre.CreaColumnasG(gvExpLaboral, "Cargo", "Cargo", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 15, gbxGrillaExpLab.Width)
        HDevExpre.CreaColumnasG(gvExpLaboral, "FechaIngreso", "Fecha Inicio", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 15, gbxGrillaExpLab.Width)
        HDevExpre.CreaColumnasG(gvExpLaboral, "FechaRetiro", "Fecha de Retiro", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 15, gbxGrillaExpLab.Width)
        HDevExpre.CreaColumnasG(gvExpLaboral, "TelEmpresa", "Tel. Empresa", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 15, gbxGrillaExpLab.Width)
        HDevExpre.CreaColumnasG(gvExpLaboral, "Direccion", "Dirección", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 15, gbxGrillaExpLab.Width)
        HDevExpre.CreaColumnasG(gvExpLaboral, "JefeInmediato", "Jefe Inmediato", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 15, gbxGrillaExpLab.Width)

        gvExpLaboral.Appearance.HeaderPanel.Font = New Font("Trebuchet MS", 11.0!, FontStyle.Bold)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="codEmpleado">Secuencial en la tabla Empleado por la relación, NO Num documento</param>
    ''' <remarks></remarks>
    Public Sub LlenaGrillaExpLaboral(codEmpleado As String)
        Dim sql As String = String.Format("SELECT *, Sec as SecIngreso FROM Empleados_HistoriaLaboral EP WHERE EP.Empleado={0} ", codEmpleado)
        Dim dt As DataTable = SMT_AbrirTabla(ObjetoApiNomina, sql)
        gcExpLaboral.DataSource = dt
        sql = String.Format("SELECT * FROM Empleados_RegFot WHERE IdEmpleado={0} AND Tipo={1}", Me.Sec,
                            Convert.ToInt32(HEmpleado.TiposDeImagenes.ExperienciaLaboral))
        dt = SMT_AbrirTabla(ObjetoApiNomina, sql)
    End Sub

    Public Function ValidaCamposExpLaboral() As Boolean
        If txtEmpresaExpLab.ValordelControl = "" Then
            HDevExpre.MensagedeError("El campo empresa donde laboró no puede estar vacio!")
            txtEmpresaExpLab.Focus()
            Return False
        ElseIf Me.Sec = "" Then
            HDevExpre.MensagedeError("Lo sentimos!, al parecer no se ha cargado ningun empleado, es imposible seguir con el registro!")

            Return False
        ElseIf txtCargoExpLab.ValordelControl = "" Then
            HDevExpre.MensagedeError("El campo cargo que desempeñaba no puede estar vacio!")
            txtCargoExpLab.Focus()
            Return False
        ElseIf txtTelEmpExpLab.ValordelControl = "" Then
            HDevExpre.MensagedeError("El campo teléfono de la empresa no puede estar vacio!")
            txtTelEmpExpLab.Focus()
            Return False
        ElseIf txtDirEmpExpLab.ValordelControl = "" Then
            HDevExpre.MensagedeError("El campo dirrección de la empresa no puede estar vacio!")
            txtDirEmpExpLab.Focus()
            Return False
        ElseIf txtJefeExplab.ValordelControl = "" Then
            HDevExpre.MensagedeError("El campo Jefe inmediato no puede estar vacio!")
            txtJefeExplab.Focus()
            Return False
        ElseIf DateDiff(DateInterval.Year, dteFecIngresoExpLab.DateTime, Datos.Smt_FechaDelServidor) > 60 Then
            HDevExpre.MensagedeError("Fecha de ingreso no Válida, esta debe ser no mayor a 60 años segun la fecha actual!")
            dteFecIngresoExpLab.Focus()
            Return False
        ElseIf DateDiff(DateInterval.Year, dteFecRetiroExpLab.DateTime, Datos.Smt_FechaDelServidor) > 60 Then
            HDevExpre.MensagedeError("Fecha de retiro no Válida, esta debe ser no mayor a 60 años segun la fecha actual!")
            dteFecRetiroExpLab.Focus()
            Return False
        ElseIf DateDiff(DateInterval.Month, dteFecIngresoExpLab.DateTime, dteFecRetiroExpLab.DateTime) < 1 Then
            HDevExpre.MensagedeError("Al parecer la fecha de ingreso es menor o igual que la fecha de retiro, o le el rango de tiempo es menor a un mes!")
            dteFecIngresoExpLab.Focus()
            Return False
        ElseIf DateDiff(DateInterval.Day, dteFecRetiroExpLab.DateTime, Datos.Smt_FechaDelServidor) < 0 Then
            HDevExpre.MensagedeError("Al parecer la fecha de retiro es mayor o igual que la fecha actual!")
            dteFecRetiroExpLab.Focus()
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub GuardaExpLaboral()
        Try
            If Not ValidaCamposExpLaboral() Then
                Return
            End If

            ' 1) Mapear controles al modelo
            Dim hist As New Empleados_HistoriaLaboral() With {
                .Sec = Me.secRegistroExpLab,
            .Empleado = idEmpleado,
            .Empresa = txtEmpresaExpLab.ValordelControl,
            .Cargo = txtCargoExpLab.ValordelControl,
            .FechaIngreso = dteFecIngresoExpLab.DateTime,
            .FechaRetiro = dteFecRetiroExpLab.DateTime,
            .TelEmpresa = txtTelEmpExpLab.ValordelControl,
            .Direccion = txtDirEmpExpLab.ValordelControl,
            .JefeInmediato = txtJefeExplab.ValordelControl}
            ' No seteamos SecIngreso aquí: el servicio lo manejará (insert vs update)


            Dim svc As New ServiceEmpleados()
            Dim resp As DynamicUpsertResponseDto = svc.GuardaExperienciaLaboral(hist)
            If resp Is Nothing OrElse resp.ErrorCount > 0 Then
                HDevExpre.MensagedeError("Error al guardar experiencia laboral.")
                Return
            End If

            ' 2) Obtener el SecIngreso asignado
            Dim secTipo As Integer
            If Not ActualizandoExpLab Then
                ' El API debería devolverte el nuevo SecIngreso; 
                ' si no, lo consultas manualmente:
                Dim sql = $"SELECT MAX(SecIngreso) FROM Empleados_HistoriaLaboral WHERE Empleado={idEmpleado}"
                secTipo = CInt(SMT_AbrirTabla(ObjetoApiNomina, sql).Rows(0)(0))
            Else
                secTipo = CInt(gvExpLaboral.GetFocusedRowCellValue("SecIngreso"))
            End If

            'SMT_EjcutarComandoSql(ObjetoApiNomina, "Delete from Empleados_RegFot where IdEmpleado=" & idEmpleado & " and SecTipo=" & secTipo & " and tipo=" + CInt(HEmpleado.TiposDeImagenes.ExperienciaLaboral), 0)

            ' 3) Enviar imágenes asociadas
            If svc.GuardaImagenesEmpleado(grupoImgsExpLaboral, idEmpleado, HEmpleado.TiposDeImagenes.ExperienciaLaboral, secTipo, 0) Then
                HDevExpre.mensajeExitoso("Información guardada exitosamente.")
                LlenaGrillaExpLaboral(idEmpleado)
                CargaImagenesEmpleado()
                LimpiarCamposExpLab()
            Else
                HDevExpre.MensagedeError("Error guardando imágenes de experiencia laboral.")
            End If

        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "GuardaExpLaboral")
        End Try
    End Sub
    Private Sub CargarDatosExpLaboral()
        Try
            If gvExpLaboral.RowCount > 0 Then
                secRegistroExpLab = gvExpLaboral.GetFocusedRowCellValue("SecIngreso").ToString
                txtEmpresaExpLab.ValordelControl = gvExpLaboral.GetFocusedRowCellValue("Empresa").ToString
                txtCargoExpLab.ValordelControl = gvExpLaboral.GetFocusedRowCellValue("Cargo").ToString
                txtDirEmpExpLab.ValordelControl = gvExpLaboral.GetFocusedRowCellValue("Direccion").ToString
                txtJefeExplab.ValordelControl = gvExpLaboral.GetFocusedRowCellValue("JefeInmediato").ToString
                txtTelEmpExpLab.ValordelControl = gvExpLaboral.GetFocusedRowCellValue("TelEmpresa").ToString
                dteFecIngresoExpLab.DateTime = Convert.ToDateTime(gvExpLaboral.GetFocusedRowCellValue("FechaIngreso"))
                dteFecRetiroExpLab.DateTime = Convert.ToDateTime(gvExpLaboral.GetFocusedRowCellValue("FechaRetiro"))
                txtEmpresaExpLab.Focus()
                ActualizandoExpLab = True
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "CargarDatosExpLaboral")
        End Try
    End Sub
    Public Sub LimpiarCamposExpLab()
        txtEmpresaExpLab.ValordelControl = ""
        txtCargoExpLab.ValordelControl = ""
        txtTelEmpExpLab.ValordelControl = ""
        txtDirEmpExpLab.ValordelControl = ""
        txtJefeExplab.ValordelControl = ""
        dteFecIngresoExpLab.DateTime = Datos.Smt_FechaDeTrabajo
        dteFecRetiroExpLab.DateTime = Datos.Smt_FechaDeTrabajo
        grupoImgsExpLaboral.Items.Clear()
        ActualizandoExpLab = False
        secRegistroExpLab = ""
    End Sub


    Private Function EliminaExpLaboral(idRegExpLaboral As String, idEmp As String) As Boolean
        Try
            Dim request As New EliminarExperienciaLaboralRequest(CInt(idRegExpLaboral), CInt(idEmp))

            ' Ejecutar el procedimiento almacenado
            Dim resp = SMT_EjecutaProcedimientos(ObjetoApiNomina, "SP_EliminarExperienciaLaboral", request.ToJObject())

            ' IMPORTANTE: Reutilizamos la misma clase DynamicDeleteResponse
            Dim response = resp.ToObject(Of DynamicDeleteResponse)()

            ' Procesar respuesta
            If response.EsExitoso Then
                ' Log opcional
                Console.WriteLine($"Experiencia laboral eliminada: {response.RegistrosEliminados} registros afectados")
                Return True

            ElseIf response.EsAdvertencia Then
                ' El registro no existe, pero no es un error crítico
                HDevExpre.MensagedeError(response.Mensaje)
                Return False

            Else ' Es Error
                HDevExpre.msgError(Nothing, response.Mensaje, "EliminaExpLaboral")
                Return False
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "EliminaExpLaboral")
            Return False
        End Try
    End Function

    Private Sub gvExpLaboral_DoubleClick(sender As Object, e As EventArgs) Handles gvExpLaboral.DoubleClick
        Try
            CargarDatosExpLaboral()
            If dtImagenes.Rows.Count > 0 Then
                Dim StringFiltro As String = String.Format("IdEmpleado={0} AND Tipo={1} AND SecTipo={2} ", Me.Sec,
                                             Convert.ToInt32(HEmpleado.TiposDeImagenes.ExperienciaLaboral),
                                             gvExpLaboral.GetFocusedRowCellValue("SecIngreso"))
                MostrarImagenesEnGaleria(StringFiltro, grupoImgsExpLaboral)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dteFecIngresoExpLab_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dteFecIngresoExpLab.KeyPress
        HDevExpre.AvanzaConEnter(e)
    End Sub

    Private Sub dteFecRetiroExpLab_KeyDown(sender As Object, e As KeyEventArgs) Handles dteFecRetiroExpLab.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            btnGuardar.Focus()
        End If
    End Sub
    Private Sub GalleryControlExpLaboral_Gallery_ItemRightClick(sender As Object, e As GalleryItemClickEventArgs) Handles GalleryControlExpLaboral.Gallery.ItemRightClick
        Try
            ImagenSeleccionadaExpLaboral = e.Item
            MenuGaleriaImagenes.ShowPopup(Control.MousePosition)
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "GalleryControlExpLaboral_Gallery_ItemRightClick")
        End Try
    End Sub
    Private Sub GalleryControlAfiliaciones_Gallery_ItemRightClick(sender As Object, e As GalleryItemClickEventArgs) Handles GalleryControlAfiliaciones.Gallery.ItemRightClick
        Try
            ImagenSeleccionadaAfiliacion = e.Item
            MenuGaleriaImagenes.ShowPopup(Control.MousePosition)
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "GalleryControlExpLaboral_Gallery_ItemRightClick")
        End Try
    End Sub
    Private Sub GalleryControlEstudios_Gallery_ItemRightClick(sender As Object, e As GalleryItemClickEventArgs) Handles GalleryControlEstudios.Gallery.ItemRightClick
        Try
            ImagenSeleccionadaInfAcademica = e.Item
            MenuGaleriaImagenes.ShowPopup(Control.MousePosition)
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "GalleryControlEstudios_Gallery_ItemRightClick")
        End Try
    End Sub

    Private Sub gvExpLaboral_KeyPress(sender As Object, e As KeyPressEventArgs) Handles gvExpLaboral.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            CargarDatosExpLaboral()
            If dtImagenes.Rows.Count > 0 Then
                Dim StringFiltro As String = String.Format("IdEmpleado={0} AND Tipo={1} AND SecTipo={2} ", Me.Sec,
                                             Convert.ToInt32(HEmpleado.TiposDeImagenes.ExperienciaLaboral),
                                             gvExpLaboral.GetFocusedRowCellValue("SecIngreso"))
                MostrarImagenesEnGaleria(StringFiltro, grupoImgsExpLaboral)
            End If
        End If
    End Sub

#End Region
#Region "Funciones y Procedimientos --> Datos Básicos"

    Public Function ValidaCamposDatosBasicos() As Boolean
        If idEmpleado Is Nothing Then
            idEmpleado = "0"
        End If
        If txtDigitoV.Text = "No Contiene Nada" Then
            txtDigitoV.Text = ""
        End If

        Dim res As Boolean = False
        If txtDocEmpleado.Text = "" Then
            HDevExpre.MensagedeError("El campo Documento del empleado no puede estar vacío!..")
            txtDocEmpleado.Focus()
            res = False
        ElseIf txtTipoDoc.ValordelControl = "" Then
            HDevExpre.MensagedeError("Debe seleccionar el Tipo de documento!..")
            txtTipoDoc.Focus()
            res = False
        ElseIf Not ActualizandoDatosBasicos And ExisteDato("Empleados", String.Format("Identificacion={0}", txtDocEmpleado.Text), ObjetoApiNomina) Then
            HDevExpre.MensagedeError(String.Format("El sistema registra un empleado con el número de documento {0}, no se puede ingresar un documento repetido!", txtDocEmpleado.Text))
            txtDocEmpleado.Focus()
            res = False
        ElseIf ActualizandoDatosBasicos And ExisteDato("Empleados", String.Format("Identificacion={0} And IdEmpleado<>{1}", txtDocEmpleado.Text, idEmpleado), ObjetoApiNomina) Then
            HDevExpre.MensagedeError(String.Format("El sistema registra un empleado con el número de documento {0}, no se puede ingresar un documento repetido!", txtDocEmpleado.Text))
            txtDocEmpleado.Focus()
            res = False
        ElseIf txtPrimerNombre.ValordelControl = "" Then
            HDevExpre.MensagedeError("El campo primer nombre no puede estar vacío!..")
            txtPrimerNombre.Focus()
            res = False
        ElseIf txtPrimerApell.ValordelControl = "" Then
            HDevExpre.MensagedeError("El campo primer apellido no puede estar vacío!..")
            txtPrimerApell.Focus()
            res = False
        ElseIf txtGenero.ValordelControl = "" Then
            HDevExpre.MensagedeError("Debe seleccionar el Género!..")
            txtGenero.Focus()
            res = False
        ElseIf txtProfesion.ValordelControl = "" Then
            HDevExpre.MensagedeError("Debe seleccionar alguna Profesión!..")
            txtProfesion.Focus()
            res = False
        ElseIf txtEstadoCivil.ValordelControl = "" Then
            HDevExpre.MensagedeError("Debe seleccionar el Estado Civil!..")
            txtEstadoCivil.Focus()
            res = False
            'ElseIf txtTel1.ValordelControl = "" And txtTel2.Text = "" Then
            '   HDevExpre.MensagedeError("Debe agregar al menos un número de Teléfono!..")
            '    txtTel1.Focus()
            '    res = False
        ElseIf txtCelular.ValordelControl = "" And txtTel2.Text = "" Then
            HDevExpre.MensagedeError("Debe agregar al menos un número de celular!..")
            txtCelular.Focus()
            res = False
        ElseIf txtEmail1.ValordelControl = "" And txtEmail1.Text = "" Then
            HDevExpre.MensagedeError("Debe agregar al menos un correo electrónico!..")
            txtEmail1.Focus()
            res = False
        ElseIf lkeMuniResidencia.EditValue Is Nothing Then
            HDevExpre.MensagedeError("Debe seleccionar el minicipio de residencia!..")
            lkeMuniResidencia.Focus()
            res = False
        ElseIf lkeMuniResidencia.EditValue.ToString = "No Contiene Nada" Then
            HDevExpre.MensagedeError("Debe seleccionar el minicipio de residencia!..")
            lkeMuniResidencia.Focus()
            res = False
        ElseIf txtBarrio.ValordelControl = "" Then
            HDevExpre.MensagedeError("El campo barrio no puede estar vacío!..")
            txtBarrio.Focus()
            res = False
        ElseIf txtDireccion.ValordelControl = "" Then
            HDevExpre.MensagedeError("El campo dirección no puede estar vacío!..")
            txtDireccion.Focus()
            res = False
        ElseIf lkeMuniExpDocumento.EditValue Is Nothing Or lkeMuniExpDocumento.EditValue.ToString = "No Contiene Nada" Then
            HDevExpre.MensagedeError("Debe seleccionar el lugar de expedición de documento!..")
            lkeMuniExpDocumento.Focus()
            res = False
        ElseIf dteFechaExpDocumento.Text = "" Then
            HDevExpre.MensagedeError("Debe seleccionar la fecha de expedición de documento!..")
            dteFechaExpDocumento.Focus()
            res = False
        ElseIf DateDiff(DateInterval.Year, dteFechaExpDocumento.DateTime, Datos.Smt_FechaDelServidor) > 100 Then
            HDevExpre.MensagedeError("La fecha de expedicón del docuemnto no es válida, al parecer es inferior al año 1910!..")
            dteFechaExpDocumento.Focus()
            res = False
        ElseIf lkeMuniNacimiento.EditValue Is Nothing Or lkeMuniNacimiento.EditValue.ToString = "No Contiene Nada" Then
            HDevExpre.MensagedeError("Debe seleccionar el lugar de nacimiento del empleado!..")
            lkeMuniNacimiento.Focus()
            res = False
        ElseIf dteFechaNacimiento.Text = "" Then
            HDevExpre.MensagedeError("Debe seleccionar la fecha de nacimiento!..")
            dteFechaNacimiento.Focus()
            res = False
        ElseIf DateDiff(DateInterval.Year, dteFechaNacimiento.DateTime, Datos.Smt_FechaDelServidor) > 100 Then
            HDevExpre.MensagedeError("La fecha de nacimiento no es válida, al parecer es inferior al año 1910!..")
            dteFechaNacimiento.Focus()
            res = False
        ElseIf DateDiff(DateInterval.Year, dteFechaNacimiento.DateTime, Datos.Smt_FechaDelServidor) < 18 Then
            HDevExpre.MensagedeError("Por favor revise la fecha de nacimiento, al parecer la fecha no coinicide con la de un adulto!..")
            dteFechaNacimiento.Focus()
            res = False
        Else
            res = True
        End If
        Return res
    End Function
    Public Sub LimpiarCampos()
        'txtDocEmpleado.Text = ""
        txtDigitoV.Text = ""
        txtPrimerNombre.ValordelControl = ""
        txtSegNombre.ValordelControl = ""
        txtPrimerApell.ValordelControl = ""
        txtSegApell.ValordelControl = ""
        txtTipoDoc.ValordelControl = ""
        txtBanco.ValordelControl = ""
        txtTel1.ValordelControl = ""
        txtEmail1.ValordelControl = ""
        txtTel2.ValordelControl = ""
        txtEmail2.ValordelControl = ""
        txtNumLicencia.ValordelControl = ""
        txtClaseLicencia.ValordelControl = ""
        txtNumLibreta.ValordelControl = ""
        txtDistritoMil.ValordelControl = ""
        txtBarrio.ValordelControl = ""
        txtComentario.Text = ""
        txtCelular.ValordelControl = ""
        txtWebPage.ValordelControl = ""
        txtDireccion.ValordelControl = ""
        pcbFotografiaEmpleado.Image = Nothing
        ndPersonaAcargo.EditValue = 0

        dteFechaExpDocumento.EditValue = Datos.Smt_FechaDeTrabajo
        dteFechaNacimiento.EditValue = Datos.Smt_FechaDeTrabajo

        lkeClaseLibreta.ItemIndex = -1
        txtGenero.ValordelControl = ""
        txtProfesion.ValordelControl = ""
        txtEstadoCivil.ValordelControl = ""
        txtNumCuenta.ValordelControl = ""
        'txtClaseLibreta.TieneErrorControl = False
        txtGenero.TieneErrorControl = False
        txtProfesion.TieneErrorControl = False
        txtEstadoCivil.TieneErrorControl = False

        lkePaisNacimiento.ItemIndex = 44
        lkeDepNacimiento.ItemIndex = 0
        lkeMuniNacimiento.ItemIndex = 0
        lkePaisResidencia.ItemIndex = 44
        lkeDepResidencia.ItemIndex = 0
        lkeMuniResidencia.ItemIndex = 0
        lkePaisExpDocumento.ItemIndex = 44
        lkeDepExpDocumento.ItemIndex = 0
        lkeMuniExpDocumento.ItemIndex = 0
        ActualizandoDatosBasicos = False
        ActualizandoExpLab = False
        ActualizandoAfiliaciones = False
        ActualizandoFamiliares = False
        ActualizandoEstudios = False
        dtImagenes.Clear()
        'Limpia gv Expereincia laboral
        gcExpLaboral.DataSource = Nothing
        grupoImgsExpLaboral.Items.Clear()
        LimpiarCamposExpLab()
        'Limpia campos Informacion Academica
        gcEstudios.DataSource = Nothing
        grupoImgsInfAcademica.Items.Clear()
        LimpiarCamposInfAcademica()

        'Limpia campos Informacion Academica
        gcFamiliares.DataSource = Nothing
        LimpiarCamposFamiliares()

        'Limpia campos Afiliaciones
        gcAfiliaciones.DataSource = Nothing
        LimpiarCamposAfiliaciones()

        txtDocEmpleado.Select()
    End Sub
    Private Sub CargarDatos(CodEmpleado As Long)
        Try
            Dim sql As String = String.Format("SELECT * FROM Empleados WHERE Identificacion={0}", CodEmpleado)
            Dim dt As DataTable = SMT_AbrirTabla(ObjetoApiNomina, sql)
            If dt.Rows.Count = 0 Then
                'ConsultaBdPrincipal(CodEmpleado)
            Else
                LimpiarCampos()
                ConsultaBdNomina(dt)
            End If
            CambioCedula = False
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "  CargarDatosEmpleado")
        End Try
    End Sub
    Private Sub ConsultaBdPrincipal(CodEmpleado As String)
        Dim PaisNac, DepNac, PaisResi, DepResi, PaisExpDoc, DepExpDoc As String
        Dim Fila As DataRow
        Dim img As Image
        Dim dt As DataTable
        Dim Sql As String = ""
        Sql = String.Format("SELECT * FROM G_Clientes WHERE Identificacion={0}", CodEmpleado)
        dt = SMT_AbrirTabla(ObjetoApiNomina, Sql)
        If dt.Rows.Count = 0 Then Exit Sub
        If HDevExpre.MsgSamit("El Empleado se encuentra registrado en la Base de datos principal, desea cargar la información existente?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.OK Then
            Fila = dt.Rows(0)
            If Not IsDBNull(Fila("Foto")) And Not IsNothing(Fila("Foto")) Then
                img = SamitCtlNet.SamitCtlNet.ClSmtImagenes.SMT_Conv_Byte_A_Image(Fila("Foto"))
            Else : img = Nothing
            End If
            Sql = String.Format("SELECT MN.Departamento FROM G_Municipio MN WHERE MN.IdMunicipio={0}", Fila("MunicipioNacimiento"))
            dt = SMT_AbrirTabla(ObjetoApiNomina, Sql)
            If dt.Rows.Count > 0 Then
                DepNac = dt.Rows(0)(0).ToString
                Sql = String.Format("SELECT TOP 1 DP.Pais FROM G_Departamento DP WHERE DP.Sec={0}", DepNac)
                dt = SMT_AbrirTabla(ObjetoApiNomina, Sql)
                If dt.Rows.Count > 0 Then
                    PaisNac = dt.Rows(0)(0).ToString
                    lkePaisNacimiento.EditValue = PaisNac
                    lkeDepNacimiento.EditValue = DepNac
                End If
            Else
                lkePaisNacimiento.ItemIndex = 0
                lkeDepNacimiento.ItemIndex = 0
            End If
            Sql = String.Format("SELECT MN.Departamento FROM G_Municipio MN WHERE MN.IdMunicipio={0}", Fila("LugarExpDoc"))
            dt = SMT_AbrirTabla(ObjetoApiNomina, Sql)
            If dt.Rows.Count > 0 Then
                DepExpDoc = dt.Rows(0)(0).ToString
                Sql = String.Format("SELECT TOP 1 DP.Pais FROM G_Departamento DP WHERE DP.Sec={0}", DepExpDoc)
                dt = SMT_AbrirTabla(ObjetoApiNomina, Sql)
                If dt.Rows.Count > 0 Then
                    PaisExpDoc = dt.Rows(0)(0).ToString
                    lkePaisExpDocumento.EditValue = PaisExpDoc
                    lkeDepExpDocumento.EditValue = DepExpDoc
                End If
            Else
                lkePaisExpDocumento.ItemIndex = 0
                lkeDepExpDocumento.ItemIndex = 0
            End If
            Sql = String.Format("SELECT MN.Departamento FROM G_Municipio MN WHERE MN.IdMunicipio={0}", Fila("Municipio"))
            dt = SMT_AbrirTabla(ObjetoApiNomina, Sql)
            If dt.Rows.Count > 0 Then
                DepResi = dt.Rows(0)(0).ToString
                Sql = String.Format("SELECT TOP 1 DP.Pais FROM G_Departamento DP WHERE DP.Sec={0}", DepResi)
                dt = SMT_AbrirTabla(ObjetoApiNomina, Sql)
                If dt.Rows.Count > 0 Then
                    PaisResi = dt.Rows(0)(0).ToString
                    lkePaisResidencia.EditValue = PaisResi
                    lkeDepResidencia.EditValue = DepResi
                End If
            Else
                lkePaisResidencia.ItemIndex = 0
                lkeDepResidencia.ItemIndex = 0
            End If
            txtDigitoV.Text = AsignarCampo(Fila, "Dv")
            txtPrimerApell.ValordelControl = AsignarCampo(Fila, "PApellido")
            txtSegApell.ValordelControl = AsignarCampo(Fila, "SApellido")
            txtPrimerNombre.ValordelControl = AsignarCampo(Fila, "PNombre")
            txtSegNombre.ValordelControl = AsignarCampo(Fila, "SNombre")
            txtGenero.ValordelControl = AsignarCampo(Fila, "Genero")
            dteFechaNacimiento.DateTime = AsignarCampo(Fila, "FechaNacimiento")
            lkeMuniNacimiento.EditValue = AsignarCampo(Fila, "MunicipioNacimiento")
            lkeMuniExpDocumento.EditValue = AsignarCampo(Fila, "LugarExpDoc")
            txtDireccion.ValordelControl = AsignarCampo(Fila, "Direccion")
            txtBarrio.ValordelControl = AsignarCampo(Fila, "Barrio")
            lkeMuniResidencia.EditValue = AsignarCampo(Fila, "Municipio")
            txtEmail1.ValordelControl = AsignarCampo(Fila, "Email")
            txtProfesion.ValordelControl = AsignarCampo(Fila, "Profesion")
            txtEstadoCivil.ValordelControl = AsignarCampo(Fila, "EstadoCivil")
            txtTel1.ValordelControl = AsignarCampo(Fila, "Tel1")
            txtTel2.ValordelControl = AsignarCampo(Fila, "Tel2")
            txtCelular.ValordelControl = AsignarCampo(Fila, "NumCelular")
            txtWebPage.ValordelControl = AsignarCampo(Fila, "WebPage")

            pcbFotografiaEmpleado.Image = img
        End If
        ActualizandoDatosBasicos = False
    End Sub


    Private Sub ConsultaBdNomina(dt As DataTable)
        'Dim PaisNac, DepNac, PaisResi, DepResi, PaisExpDoc, DepExpDoc As String
        Dim Fila As DataRow = dt.Rows(0)
        Dim img As Image = Nothing
        Dim sql As String = String.Format("SELECT Foto FROM Empleados_RegFot WHERE IdEmpleado={0} AND Tipo={1} AND SecTipo={2} AND Predeterminada=1 ",
                                         Fila("Sec").ToString, 0, Fila("Sec").ToString)
        Dim dtFoto As DataTable = SMT_AbrirTabla(ObjetoApiNomina, sql)
        HDevExpre.Cargalke(Fila("MunicipioNacimiento").ToString, lkeDepNacimiento, lkePaisNacimiento)
        HDevExpre.Cargalke(Fila("LugarExpDoc").ToString, lkeDepExpDocumento, lkePaisExpDocumento)
        HDevExpre.Cargalke(Fila("Municipio").ToString, lkeDepResidencia, lkePaisResidencia)

        If dtFoto.Rows.Count > 0 Then
            If Not IsDBNull(dtFoto.Rows(0)("Foto")) And Not IsNothing(dtFoto.Rows(0)("Foto")) Then
                img = SamitCtlNet.SamitCtlNet.ClSmtImagenes.SMT_Conv_Byte_A_Image(dtFoto.Rows(0)("Foto"))
            Else : img = Nothing
            End If
        End If

        'txtBanco.RefrescarDatos()
        'txtTipoDoc.RefrescarDatos()
        ''txtClaseLibreta.RefrescarDatos()
        'txtClaseLicencia.RefrescarDatos()
        'txtTipoDoc.RefrescarDatos()
        'txtGenero.RefrescarDatos()
        'txtProfesion.RefrescarDatos()
        'txtEstadoCivil.RefrescarDatos()

        txtBanco.TieneErrorControl = False
        txtTipoDoc.TieneErrorControl = False
        'txtClaseLibreta.TieneErrorControl = False
        txtClaseLicencia.TieneErrorControl = False
        txtTipoDoc.TieneErrorControl = False
        txtGenero.TieneErrorControl = False
        txtProfesion.TieneErrorControl = False
        txtEstadoCivil.TieneErrorControl = False

        Sec = Fila("Sec").ToString
        idEmpleado = Fila("Sec").ToString
        txtTipoDoc.ValordelControl = AsignarCampo(Fila, "TipoIdentificacion")
        txtDigitoV.Text = AsignarCampo(Fila, "Dv")
        txtPrimerApell.ValordelControl = AsignarCampo(Fila, "PApellido")
        txtSegApell.ValordelControl = AsignarCampo(Fila, "SApellido")
        txtPrimerNombre.ValordelControl = AsignarCampo(Fila, "PNombre")
        txtSegNombre.ValordelControl = AsignarCampo(Fila, "SNombre")
        txtGenero.ValordelControl = AsignarCampo(Fila, "Genero")
        dteFechaNacimiento.DateTime = AsignarCampo(Fila, "FechaNacimiento")
        lkeMuniNacimiento.EditValue = AsignarCampo(Fila, "MunicipioNacimiento")
        dteFechaExpDocumento.DateTime = AsignarCampo(Fila, "FechaExpDoc")
        lkeMuniExpDocumento.EditValue = AsignarCampo(Fila, "LugarExpDoc")
        txtDireccion.ValordelControl = AsignarCampo(Fila, "Direccion")
        txtBarrio.ValordelControl = AsignarCampo(Fila, "Barrio")
        lkeMuniResidencia.EditValue = AsignarCampo(Fila, "Municipio")
        txtEmail1.ValordelControl = AsignarCampo(Fila, "Email1")
        txtEmail2.ValordelControl = AsignarCampo(Fila, "Email2")
        txtProfesion.ValordelControl = AsignarCampo(Fila, "Profesion")
        ndPersonaAcargo.Value = AsignarCampo(Fila, "PersonasaCargo")
        txtEstadoCivil.ValordelControl = AsignarCampo(Fila, "EstadoCivil")
        txtTel1.ValordelControl = AsignarCampo(Fila, "Tel1")
        txtTel2.ValordelControl = AsignarCampo(Fila, "Tel2")
        txtCelular.ValordelControl = AsignarCampo(Fila, "NumCelular")
        txtWebPage.ValordelControl = AsignarCampo(Fila, "WebPage")
        txtNumLicencia.ValordelControl = AsignarCampo(Fila, "LicConduccion")
        txtClaseLicencia.ValordelControl = AsignarCampo(Fila, "LicCategoria")
        'txtClaseLibreta.ValordelControl = AsignarCampo(Fila, "ClaseLib")
        lkeClaseLibreta.EditValue = AsignarCampo(Fila, "ClaseLib")
        txtNumLibreta.ValordelControl = AsignarCampo(Fila, "NumLib")
        txtDistritoMil.ValordelControl = AsignarCampo(Fila, "DistritoLib")
        txtComentario.Text = AsignarCampo(Fila, "Comentario")
        txtBanco.ValordelControl = AsignarCampo(Fila, "codBanco")
        txtNumCuenta.ValordelControl = AsignarCampo(Fila, "NumCuenta")
        rgbEmpRetiradoEntidad.SelectedIndex = rgbEmpRetiradoEntidad.SelectedIndex = If(
    TryCast(AsignarCampo(Fila, "TipoCuenta"), String) = "No Contiene Nada",
    0,
    CInt(AsignarCampo(Fila, "TipoCuenta"))
)
        pcbFotografiaEmpleado.Image = img
        NumDocumento = txtDocEmpleado.Text()
        LlenaGrillaExpLaboral(Fila("Sec").ToString)
        LlenaGrillaInfAcademica(Fila("Sec").ToString)
        LlenaGrillaFamiliares(Fila("Sec").ToString)
        LlenaGrillaAfiliaciones(Fila("Sec").ToString)
        'CargaImagenesEmpleado()
        ActualizandoDatosBasicos = True
    End Sub
    Private Function GuardaDatosBasicos() As Boolean
        Try
            ' --- 1. Inicializador corregido ---
            Dim emp As New Empleados() With {
            .Sec = Sec,
            .TipoIdentificacion = txtTipoDoc.ValordelControl,
            .Identificacion = CLng(If(ActualizandoDatosBasicos, NumDocumento, txtDocEmpleado.Text)),
            .Dv = txtDigitoV.Text,
            .PApellido = txtPrimerApell.ValordelControl,
            .SApellido = txtSegApell.ValordelControl,
            .PNombre = txtPrimerNombre.ValordelControl,
            .SNombre = txtSegNombre.ValordelControl,
            .Genero = txtGenero.ValordelControl,
            .MunicipioNacimiento = lkeMuniNacimiento.EditValue?.ToString(),
            .LugarExpDoc = lkeMuniExpDocumento.EditValue?.ToString(),
            .Direccion = txtDireccion.ValordelControl,
            .Barrio = txtBarrio.ValordelControl,
            .Municipio = lkeMuniResidencia.EditValue?.ToString(),
            .Email1 = txtEmail1.ValordelControl,
            .Email2 = txtEmail2.ValordelControl,
            .Profesion = If(String.IsNullOrWhiteSpace(txtProfesion.ValordelControl),
                                     CType(Nothing, Integer?),
                                     CInt(txtProfesion.ValordelControl)),
            .PersonasaCargo = If(ndPersonaAcargo.EditValue Is Nothing,
                                     CType(Nothing, Short?),
                                     CShort(ndPersonaAcargo.EditValue)),
            .EstadoCivil = If(String.IsNullOrWhiteSpace(txtEstadoCivil.ValordelControl),
                                     CType(Nothing, Byte?),
                                     Byte.Parse(txtEstadoCivil.ValordelControl)),
            .Tel1 = txtTel1.ValordelControl,
            .Tel2 = txtTel2.ValordelControl,
            .NumCelular = txtCelular.ValordelControl,
            .WebPage = txtWebPage.ValordelControl,
            .LicConduccion = txtNumLicencia.ValordelControl,
            .LicCategoria = txtClaseLicencia.ValordelControl,
            .ClaseLib = If(lkeClaseLibreta.EditValue Is Nothing,
                                     CType(Nothing, Short?),
                                     CShort(lkeClaseLibreta.EditValue)),
            .NumLib = txtNumLibreta.ValordelControl,
            .DistritoLib = txtDistritoMil.ValordelControl,
            .Comentario = txtComentario.Text,
            .codBanco = If(String.IsNullOrWhiteSpace(txtBanco.ValordelControl),
                                     CType(Nothing, Integer?),
                                     CInt(txtBanco.ValordelControl)),
            .NumCuenta = txtNumCuenta.ValordelControl,
            .TipoCuenta = CByte(grTipoCuenta.SelectedIndex),
            .FechaIngreso = Datos.Smt_FechaDeTrabajo,
            .FechaGen = Datos.Smt_FechaDelServidor,
            .FechaNacimiento = dteFechaNacimiento.EditValue,
            .FechaExpDoc = dteFechaExpDocumento.EditValue,
            .UsrGen = Datos.Smt_Usuario,
            .FechaMod = Datos.Smt_FechaDelServidor,
            .UsrMod = Datos.Smt_Usuario
        }  ' <— ¡Sin coma extra aquí!

            ' --- 2. Foto fuera del inicializador ---
            If pcbFotografiaEmpleado.Image IsNot Nothing Then
                Using ms As New IO.MemoryStream()
                    ' Guardamos la imagen en el MemoryStream en formato PNG
                    pcbFotografiaEmpleado.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png)
                    ' Convertimos el arreglo de bytes a Base64 y lo asignamos al string
                    emp.Foto = Convert.ToBase64String(ms.ToArray())
                End Using
            End If

            ' --- 3. Llamada al servicio y resto del flujo ---
            Dim svc As New ServiceEmpleados()
            If Not svc.ValidarCampos(emp) Then
                svc.ListaErrores.ForEach(Sub(e) HDevExpre.MensagedeError(e))
                Return False
            End If

            Dim resultado As DynamicUpsertResponseDto = svc.UpsertEmpleado(emp)
            If resultado IsNot Nothing AndAlso resultado.ErrorCount < 1 Then
                HDevExpre.mensajeExitoso("Empleado guardado correctamente.")
                Return True
            Else
                HDevExpre.MensagedeError("Error al guardar el empleado.")
                Return False
            End If

        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "GuardarEmpleado")
            Return False
        End Try
    End Function


    Public Sub CargaImagenesEmpleado()
        Dim dt As DataTable
        dt = SMT_AbrirTabla(ObjetoApiNomina, String.Format("SELECT * FROM Empleados_RegFot WHERE IdEmpleado={0}", Me.Sec))
        dtImagenes = dt
    End Sub


    Public Sub MostrarImagenesEnGaleria(Filtro As String, Galeria As GalleryItemGroup)
        Dim rows As DataRow()
        Dim img As Image
        Galeria.Items.Clear()
        If Filtro <> "" Then
            rows = dtImagenes.Select(Filtro, "")
            For i = 0 To rows.Length - 1
                img = SamitCtlNet.SamitCtlNet.ClSmtImagenes.SMT_Conv_Byte_A_Image(rows(i)("Foto"))
                Galeria.Items.Add(New GalleryItem(img, "Imagen " & i + 1, ""))
            Next
        End If
    End Sub
    Public Sub MostrarImageneEnPictureEdit(Filtro As String, pcb As PictureEdit)
        Dim rows As DataRow()
        Dim img As Image
        pcb.Image = Nothing
        If Filtro <> "" Then
            rows = dtImagenes.Select(Filtro, "")
            If rows.Length > 0 Then
                img = SamitCtlNet.SamitCtlNet.ClSmtImagenes.SMT_Conv_Byte_A_Image(rows(0)("Foto"))
                pcb.Image = img
            End If
        End If
    End Sub

    'Inicia impresión de datos del empleado
    Public Sub ImprimeDatosEmpleado(ImpDatosB As Boolean,
                                    ImpExpLab As Boolean,
                                    ImpInfAcade As Boolean,
                                    ImpEduNoForm As Boolean,
                                    ImpInfFamil As Boolean,
                                    ImpAfiliac As Boolean)
        Try
            Dim RPT As New RptEmpleado
            Dim Nombre As String = String.Format("{0} {1} {2} {3}",
                                                 txtPrimerNombre.ValordelControl, txtSegNombre.ValordelControl,
                                                 txtPrimerApell.ValordelControl, txtSegApell.ValordelControl)
            RPT.lblNitEmp.Text = String.Format("Nit: {0}-{1}    {2}", Datos.Seguridad.DatosDeLaEmpresa.Nit, Datos.Seguridad.DatosDeLaEmpresa.DV, Datos.Seguridad.DatosDeLaEmpresa.RegimenIva)
            If Datos.Seguridad.DatosDeLaEmpresa.TipodePersona = Clseguridad.TipoPersona.PersonaJuridica Then
                RPT.lblNomEmp.Text = Datos.Seguridad.DatosDeLaEmpresa.NombreEmpresa
                RPT.lblOficina.Text = Datos.Seguridad.DatosDeLaEmpresa.OficinaIngreso.NombreComercial
                RPT.LblDireccionEmpresa.Text = String.Format("{0} {1}", Datos.Seguridad.DatosDeLaEmpresa.Direccion.ToLowerInvariant,
                                                      IIf(Datos.Seguridad.DatosDeLaEmpresa.NumTelefonos <> "", " Tels:" & Datos.Seguridad.DatosDeLaEmpresa.NumTelefonos, ""))
            Else
                RPT.lblNomEmp.Text = Datos.Seguridad.DatosDeLaEmpresa.OficinaIngreso.NombreComercial
                RPT.lblOficina.Text = Datos.Seguridad.DatosDeLaEmpresa.NombreEmpresa
                Dim TxtTel As String = Datos.Seguridad.DatosDeLaEmpresa.OficinaIngreso.Telefono1.Trim &
                    IIf(Datos.Seguridad.DatosDeLaEmpresa.OficinaIngreso.Telefono2.Trim <> "", "-" & Datos.Seguridad.DatosDeLaEmpresa.OficinaIngreso.Telefono2.Trim, "")
                TxtTel = TxtTel.Trim
                RPT.LblDireccionEmpresa.Text = String.Format("{0} {1}", Datos.Seguridad.DatosDeLaEmpresa.OficinaIngreso.Direccion, IIf(TxtTel <> "", " Tel: " & TxtTel, ""))
            End If
            RPT.pcbImg.Image = Datos.Seguridad.LogoImprime
            RPT.lbreviso.Text = "Usuario: " + StrConv(Datos.Smt_Usuario, VbStrConv.ProperCase)
            RPT.lbpc.Text = Datos.Smt_NombreTerminal
            RPT.lbversionsamit.Text = String.Format("{0} V{1}", Application.ProductName, Application.ProductVersion)
            RPT.lblTituloInforme.Text = String.Format("Informe Empleado {0} | Documento {1}", StrConv(Nombre, VbStrConv.ProperCase), txtDocEmpleado.Text)
            If ImpDatosB Then
                If txtNumLibreta.ValordelControl <> "" Then
                    RPT.ckbNoLibreta.Checked = True
                ElseIf lkeClaseLibreta.EditValue = "1" Then 'QUEMADO PARA PRUEBAS XQ DEPRONTO CAMBIA EL CODIGO DE LA CLASE DE LIBRETA -- O NO!
                    RPT.ckbLibPrimera.Checked = True
                ElseIf lkeClaseLibreta.EditValue = "2" Then 'QUEMADO PARA PRUEBAS
                    RPT.ckbLibSegunda.Checked = True
                End If
                RPT.lblPApellido.Text = StrConv(txtPrimerApell.ValordelControl, VbStrConv.ProperCase)
                RPT.lblSApellido.Text = StrConv(txtSegApell.ValordelControl, VbStrConv.ProperCase)
                RPT.lblNombres.Text = String.Format("{0} {1}", StrConv(txtPrimerNombre.ValordelControl, VbStrConv.ProperCase, ), StrConv(txtSegNombre.ValordelControl, VbStrConv.ProperCase))
                RPT.lblTipoDoc.Text = StrConv(txtTipoDoc.DescripciondelControl, VbStrConv.Uppercase)
                RPT.lblNumDoc.Text = txtDocEmpleado.Text
                RPT.lblEstCivil.Text = StrConv(txtEstadoCivil.DescripciondelControl, VbStrConv.ProperCase)
                RPT.lblNumLibreta.Text = txtNumLibreta.ValordelControl
                RPT.lblDM.Text = StrConv(txtDistritoMil.ValordelControl, VbStrConv.ProperCase)
                RPT.lblCelular.Text = txtCelular.ValordelControl
                RPT.lblTelefonos.Text = String.Format("{0} - {1}", txtTel1.ValordelControl, txtTel2.ValordelControl)
                RPT.lblCorreo.Text = String.Format("{0} - {1}",
                                                   StrConv(IIf(txtEmail1.ValordelControl = "", "", txtEmail1.ValordelControl), VbStrConv.Lowercase),
                                                   StrConv(IIf(txtEmail2.ValordelControl = "", "", txtEmail2.ValordelControl), VbStrConv.Lowercase))
                RPT.lblFechaNac.Text = dteFechaNacimiento.DateTime.ToString("dd - MMM - yyyy")
                RPT.lblPaisNac.Text = StrConv(lkePaisNacimiento.Text, VbStrConv.ProperCase)
                RPT.lblDepNac.Text = StrConv(lkeDepNacimiento.Text, VbStrConv.ProperCase)
                RPT.lblMuniNac.Text = StrConv(lkeMuniNacimiento.Text, VbStrConv.ProperCase)
                RPT.LblDireccionEmpleado.Text = StrConv(txtDireccion.ValordelControl, VbStrConv.ProperCase)
                RPT.lblPaisResidencia.Text = StrConv(lkePaisResidencia.Text, VbStrConv.ProperCase)
                RPT.lblDepResidencia.Text = StrConv(lkeDepResidencia.Text, VbStrConv.ProperCase)
                RPT.lblMuniResidencia.Text = StrConv(lkeMuniResidencia.Text, VbStrConv.ProperCase)
                If txtGenero.ValordelControl = "M" Then
                    RPT.ckbMasculino.Checked = True
                ElseIf txtGenero.ValordelControl = "F" Then
                    RPT.ckbFemenino.Checked = True
                End If
            Else
                RPT.dbDatosBasicos.Visible = False
            End If

            If ImpInfAcade Then
                Dim dtEstudios As DataTable = CType(gcEstudios.DataSource, DataTable)
                Dim rows As DataRow() = dtEstudios.Select("EsFormal=True")
                For i = 0 To rows.Length - 1
                    Dim Nivel, Titulo, Institucion, MatProf, Duracion, FecTerm, Pais, Depto, Muni, IdMunicipio, IdDepto As String
                    Dim UbiTablaEnY, UbiLineaDerY, UbiLineaAbjY As Single
                    Dim fecTermina As Date = rows(i)("FechaGrado")
                    Nivel = rows(i)("NomNivel").ToString
                    Titulo = rows(i)("NomProfesion").ToString
                    Institucion = rows(i)("NombreInstitucion").ToString
                    MatProf = rows(i)("MatriculaProfesional").ToString
                    Duracion = rows(i)("DuracionFormat").ToString
                    FecTerm = fecTermina.ToString("dd - MMM - yyyy")
                    Muni = rows(i)("NombreMunicipio").ToString
                    IdMunicipio = rows(i)("IdMunicipio").ToString
                    Depto = HDevExpre.TraeDepartamentoConMunicipio(IdMunicipio, False)
                    IdDepto = HDevExpre.TraeDepartamentoConMunicipio(IdMunicipio, True)
                    Pais = HDevExpre.TraePaisConDepartamento(IdDepto, False)
                    UbiTablaEnY = 65 + (406.5 * i)
                    UbiLineaAbjY = 400 + (406.5 * i)
                    UbiLineaDerY = 78.58 + (406.5 * i)
                    HEmpleado.CreaImprimeInfAcademica(RPT,
                                                       UbiTablaEnY,
                                                       UbiLineaDerY,
                                                       UbiLineaAbjY,
                                                       Nivel,
                                                       Titulo,
                                                       Institucion,
                                                       MatProf,
                                                       Duracion,
                                                       FecTerm,
                                                       Pais,
                                                       Depto,
                                                       Muni)
                Next
            Else
                RPT.drInfAcademica.Visible = False
            End If
            If ImpEduNoForm Then
                Dim dtEduNoFormal As DataTable = CType(gcEstudios.DataSource, DataTable)
                Dim copyDt As DataTable = dtEduNoFormal.Clone
                Dim rows As DataRow() = dtEduNoFormal.Select("EsFormal=False")
                Dim fila As DataRow
                If rows.Length > 0 Then
                    For i = 0 To rows.Length - 1
                        fila = copyDt.NewRow
                        fila("NomNivel") = StrConv(rows(i)("NomNivel").ToString, VbStrConv.ProperCase)
                        fila("NomProfesion") = StrConv(rows(i)("NomProfesion").ToString, VbStrConv.ProperCase)
                        fila("NombreInstitucion") = StrConv(rows(i)("NombreInstitucion").ToString, VbStrConv.ProperCase)
                        fila("FechaGrado") = rows(i)("FechaGrado")
                        fila("DuracionFormat") = rows(i)("DuracionFormat").ToString
                        copyDt.Rows.Add(fila)
                        copyDt.AcceptChanges()
                    Next
                End If
                RPT.drEducacionNoformal.DataSource = copyDt
                RPT.lblNivelEF.DataBindings.Add("Text", copyDt, "NomNivel")
                RPT.lblDescripcionEF.DataBindings.Add("Text", copyDt, "NomProfesion")
                RPT.lblInstitucionEF.DataBindings.Add("Text", copyDt, "NombreInstitucion")
                RPT.lblFechaTermancionEF.DataBindings.Add("Text", copyDt, "FechaGrado", "{0:dd/MMM/yyyy}")
                RPT.lblDuracionEF.DataBindings.Add("Text", copyDt, "DuracionFormat")
            Else
                RPT.drEducacionNoformal.Visible = False
            End If

            If ImpExpLab Then
                Dim dtExpLaboral As DataTable = CType(gcExpLaboral.DataSource, DataTable)
                Dim Empresa, Cargo, FechaIni, FechaFin, Tels, Direccion, Jefe As String
                Dim UbiTbEnY, UbiLineaDerEnY, UbiLineaAbjEnY As Single
                Dim fi, ff As Date
                For i = 0 To dtExpLaboral.Rows.Count - 1
                    fi = dtExpLaboral.Rows(i)("FechaIngreso")
                    ff = dtExpLaboral.Rows(i)("FechaRetiro")
                    Empresa = StrConv(dtExpLaboral.Rows(i)("Empresa").ToString, VbStrConv.ProperCase)
                    Cargo = StrConv(dtExpLaboral.Rows(i)("Cargo").ToString, VbStrConv.ProperCase)
                    FechaIni = fi.ToString("dd - MMM - yyyy")
                    FechaFin = ff.ToString("dd - MMM - yyyy")
                    Tels = StrConv(dtExpLaboral.Rows(i)("TelEmpresa").ToString, VbStrConv.ProperCase)
                    Direccion = StrConv(dtExpLaboral.Rows(i)("Direccion").ToString, VbStrConv.ProperCase)
                    Jefe = StrConv(dtExpLaboral.Rows(i)("JefeInmediato").ToString, VbStrConv.ProperCase)

                    UbiTbEnY = 122 + (402.63 * i)
                    UbiLineaDerEnY = 135 + (402.63 * i)
                    UbiLineaAbjEnY = 457 + (402.63 * i)
                    HEmpleado.CreaImprimeExperienciaLaboral(RPT,
                                                             UbiTbEnY,
                                                             UbiLineaDerEnY,
                                                             UbiLineaAbjEnY,
                                                             Empresa,
                                                             Cargo,
                                                             FechaIni,
                                                             FechaFin,
                                                             Tels,
                                                             Direccion,
                                                             Jefe)
                Next
            Else
                RPT.drExpLaboral.Visible = False
            End If
            If ImpInfFamil Then
                Dim dtFamiliares As DataTable = CType(gcFamiliares.DataSource, DataTable)
                RPT.drFamiliares.DataSource = dtFamiliares
                RPT.lblTipoDocFM.DataBindings.Add("Text", dtFamiliares, "TipoIdentificacion")
                RPT.lblDocFamiliar.DataBindings.Add("Text", dtFamiliares, "Identificacion")
                RPT.lblNombreFamiliar.DataBindings.Add("Text", dtFamiliares, "Nombre")
                RPT.lblParentesco.DataBindings.Add("Text", dtFamiliares, "NomParentesco")
                RPT.lblFechaNacFamiliar.DataBindings.Add("Text", dtFamiliares, "FechaNacimiento", "{0:dd/MMM/yyyy}")
            Else
                RPT.drFamiliares.Visible = False
            End If

            If ImpAfiliac Then
                Dim dtAfiliaciones As DataTable = CType(gcAfiliaciones.DataSource, DataTable)
                RPT.drAfiliaciones.DataSource = dtAfiliaciones
                RPT.lblEntidad.DataBindings.Add("Text", dtAfiliaciones, "NombreEntidad")
                RPT.lblFecRegistroAF.DataBindings.Add("Text", dtAfiliaciones, "FechaRegistro")
                RPT.lblRetiradoAF.DataBindings.Add("Text", dtAfiliaciones, "Retirado")
                RPT.lblFecRetiroAF.DataBindings.Add("Text", dtAfiliaciones, "FechaRetiro")
                RPT.lblCausaRetiroAF.DataBindings.Add("Text", dtAfiliaciones, "CausadeRetiro")
            Else
                RPT.drAfiliaciones.Visible = False
            End If

            Dim frm As New FrmVistaPrevia(RPT)
            frm.ShowDialog()
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "ImprimeDatosEmpleado")
        End Try
    End Sub

    Private Sub btnBuscarEmp_Click(sender As Object, e As EventArgs) Handles btnBuscarEmp.Click
        LimpiarCampos()
        AbreBusqueda()
    End Sub
    Private Sub AbreBusqueda()
        Dim sql As String = "SELECT EP.Identificacion AS Codigo, RTRIM(LTRIM(RTRIM(LTRIM(PNombre)) + ' ' + " &
                           " RTRIM(LTRIM(SNombre)) + ' ' +  RTRIM(LTRIM(PApellido)) + ' ' + " &
                           " RTRIM(LTRIM(SApellido)))) As Descripcion FROM Empleados EP"
        Dim frm As New FrmBusqueda(sql, "Empleado", txtDocEmpleado, , "Documento", "Nombre Completo")
        Dim classResize As New ClaseResize
        If frm.P_FormularioAbierto Then
            frm.ShowDialog()
            frm.BringToFront()
        Else
            frm.P_FormularioAbierto = True
            classResize.Resizamodales(frm, 50, 70)
            classResize.ResizeForm(frm)
            frm.ShowDialog()
            frm.BringToFront()
        End If
    End Sub
    Private Sub txtDocEmpleado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDocEmpleado.KeyPress
        If e.KeyChar = ChrW(Keys.Escape) Then
            btnSalir.Focus()
            Exit Sub
        End If
        PremiteSoloNumeros(e)

    End Sub
#End Region
#Region "Funciones y Procedimientos --> Información Académica"
    Private Sub CreaGrillaInfAcademica()
        gvEstudios.Columns.Clear()
        HDevExpre.CreaColumnasG(gvEstudios, "SecIngreso", "SecIngreso", False, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 0, 0)
        HDevExpre.CreaColumnasG(gvEstudios, "Empleado", "Empleado", False, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 0, 0)
        HDevExpre.CreaColumnasG(gvEstudios, "IdNivel", "IdNivel", False, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 0, 0)
        HDevExpre.CreaColumnasG(gvEstudios, "TipoTiempo", "TipoTiempo", False, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 0, 0)
        HDevExpre.CreaColumnasG(gvEstudios, "Duracion", "Duracion", False, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 0, 0)
        HDevExpre.CreaColumnasG(gvEstudios, "IdProfesion", "IdProfesion", False, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 0, 0)
        HDevExpre.CreaColumnasG(gvEstudios, "IdMunicipio", "IdMunicipio", False, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 0, 0)
        HDevExpre.CreaColumnasG(gvEstudios, "EsFormal", "Edu. Formal", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 12, gbxGrillaInfAcademica.Width)
        HDevExpre.CreaColumnasG(gvEstudios, "NomNivel", "Nivel", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 12, gbxGrillaInfAcademica.Width)
        HDevExpre.CreaColumnasG(gvEstudios, "FechaGrado", "Fecha Obt. Título", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 12, gbxGrillaInfAcademica.Width)
        HDevExpre.CreaColumnasG(gvEstudios, "DuracionFormat", "Duración", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 12, gbxGrillaInfAcademica.Width)
        HDevExpre.CreaColumnasG(gvEstudios, "NomProfesion", "Título Obtenido", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 12, gbxGrillaInfAcademica.Width)
        HDevExpre.CreaColumnasG(gvEstudios, "NombreInstitucion", "Institución", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 12, gbxGrillaInfAcademica.Width)
        HDevExpre.CreaColumnasG(gvEstudios, "MatriculaProfesional", "Mat. Profresional", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 12, gbxGrillaInfAcademica.Width)
        HDevExpre.CreaColumnasG(gvEstudios, "NombreMunicipio", "Lugar Obt Título", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 12, gbxGrillaInfAcademica.Width)
        gvEstudios.Appearance.HeaderPanel.Font = New Font("Trebuchet MS", 11.0!, FontStyle.Bold)
        gvEstudios.Columns(2).ColumnEdit = gvEstudios.Columns(2).View.GridControl.RepositoryItems.Add("TextEdit")
        gvEstudios.Columns(2).DisplayFormat.Format = New FormatoBooleanGrilla("SI", "NO")
        gvEstudios.BeginSort()
        gvEstudios.SortInfo.Add(gvEstudios.Columns(2), DevExpress.Data.ColumnSortOrder.Descending)
        gvEstudios.EndSort()
    End Sub

    Private Sub LlenaGrillaInfAcademica(idEmp As String)
        Try
            Dim sql As String = String.Format("SELECT EE.Sec as SecIngreso,EE.Empleado,NE.Sec as IdNivel,NE.NomNivel,EE.FechaGrado,  " &
                                            " EE.TipoTiempo,EE.Duracion, PF.Sec as IdProfesion, PF.NomProfesion, EE.NombreInstitucion, ee.MatriculaProfesional," &
                                            " MN.IdMunicipio, MN.NombreMunicipio, NE.EsFormal" &
                                            " FROM Empleados_Educacion EE " &
                                            " INNER JOIN CAT_NivelEducativo NE ON NE.Sec=EE.NivelEstudio " &
                                            " INNER JOIN CAT_Profesiones PF ON PF.Sec= EE.IdTituloObtenido " &
                                            " INNER JOIN G_Municipio MN ON MN.IdMunicipio=EE.LugarTitulo " &
                                            " WHERE Empleado={0}", idEmp)
            Dim dt As DataTable = SMT_AbrirTabla(ObjetoApiNomina, sql)
            Dim CopyDt As New DataTable
            If dt.Rows.Count > 0 Then
                CopyDt = dt.Clone
                CopyDt.Columns.Add("DuracionFormat")
                Dim row As DataRow
                Dim sec As Integer = 0
                While True
                    If sec > dt.Rows.Count - 1 Then
                        Exit While
                    End If
                    row = CopyDt.NewRow
                    row("SecIngreso") = dt.Rows(sec)("SecIngreso")
                    row("Empleado") = dt.Rows(sec)("Empleado")
                    row("IdNivel") = dt.Rows(sec)("IdNivel")
                    row("NomNivel") = dt.Rows(sec)("NomNivel")
                    row("FechaGrado") = dt.Rows(sec)("FechaGrado")
                    row("TipoTiempo") = dt.Rows(sec)("TipoTiempo")
                    row("Duracion") = dt.Rows(sec)("Duracion")
                    row("IdProfesion") = dt.Rows(sec)("IdProfesion")
                    row("NomProfesion") = dt.Rows(sec)("NomProfesion")
                    row("NombreInstitucion") = dt.Rows(sec)("NombreInstitucion")
                    row("MatriculaProfesional") = dt.Rows(sec)("MatriculaProfesional")
                    row("IdMunicipio") = dt.Rows(sec)("IdMunicipio")
                    row("NombreMunicipio") = dt.Rows(sec)("NombreMunicipio")
                    row("EsFormal") = dt.Rows(sec)("EsFormal")

                    If dt.Rows(sec)("TipoTiempo") = 0 Then
                        If dt.Rows(sec)("Duracion") > 1 Then
                            row("DuracionFormat") = dt.Rows(sec)("Duracion").ToString + " Horas"
                        Else
                            row("DuracionFormat") = dt.Rows(sec)("Duracion").ToString + " Hora"
                        End If
                    ElseIf dt.Rows(sec)("TipoTiempo") = 1 Then
                        If dt.Rows(sec)("Duracion") > 1 Then
                            row("DuracionFormat") = dt.Rows(sec)("Duracion").ToString + " Meses"
                        Else
                            row("DuracionFormat") = dt.Rows(sec)("Duracion").ToString + " Mes"
                        End If
                    ElseIf dt.Rows(sec)("TipoTiempo") = 2 Then
                        If dt.Rows(sec)("Duracion") > 1 Then
                            row("DuracionFormat") = dt.Rows(sec)("Duracion").ToString + " Años"
                        Else
                            row("DuracionFormat") = dt.Rows(sec)("Duracion").ToString + " Año"
                        End If
                    End If
                    CopyDt.Rows.Add(row)
                    CopyDt.AcceptChanges()
                    sec += 1
                End While
            End If
            gcEstudios.DataSource = CopyDt

        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "LlenaGrillaInfAcademica")
        End Try
    End Sub

    Private Function EliminaInfAcademica(idRegInfAcademica As String, idEmp As String) As Boolean
        Try

            Dim request As New EliminarInformacionAcademicaRequest(CInt(idRegInfAcademica), CInt(idEmp))

            ' Ejecutar el procedimiento almacenado
            Dim resp = SMT_EjecutaProcedimientos(ObjetoApiNomina, "SP_EliminarInformacionAcademica", request.ToJObject())

            ' IMPORTANTE: Reutilizamos la misma clase DynamicDeleteResponse
            Dim response = resp.ToObject(Of DynamicDeleteResponse)()

            ' Procesar respuesta
            If response.EsExitoso Then
                ' Log opcional
                Console.WriteLine($"Información académica eliminada: {response.RegistrosEliminados} registros afectados")
                Return True

            ElseIf response.EsAdvertencia Then
                ' El registro no existe, pero no es un error crítico
                HDevExpre.MensagedeError(response.Mensaje)
                Return False

            Else ' Es Error
                HDevExpre.msgError(Nothing, response.Mensaje, "EliminaInfAcademica")
                Return False
            End If

        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "EliminaInfAcademica")
            Return False
        End Try
    End Function

    Private Sub LlenaLkeNivelesEducativos()
        Try
            Dim sql As String = String.Format("SELECT Sec AS Codigo,NomNivel AS Descripcion FROM CAT_NivelEducativo WHERE Vigente=1 AND EsFormal={0} ", grbTipoEducacion.SelectedIndex)
            Dim dt As DataTable = SMT_AbrirTabla(ObjetoApiNomina, sql)
            If dt.Rows.Count > 0 Then
                lkeNivelEducativo.Properties.DataSource = dt
                lkeNivelEducativo.Properties.ValueMember = "Codigo"
                lkeNivelEducativo.Properties.DisplayMember = "Descripcion"
                'lkeNivelEducativo.Properties.PopulateColumns()
                lkeNivelEducativo.Properties.Columns(0).Visible = False
                lkeNivelEducativo.ItemIndex = 0
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub lkeNivelEducativo_EditValueChanged(sender As Object, e As EventArgs) Handles lkeNivelEducativo.EditValueChanged
        Try
            Dim sql As String = String.Format("SELECT Sec AS Codigo,NomProfesion AS Descripcion FROM CAT_Profesiones WHERE IdNivelEducativo={0}", lkeNivelEducativo.EditValue.ToString)
            Dim dt As DataTable = SMT_AbrirTabla(ObjetoApiNomina, sql)
            If dt.Rows.Count > 0 Then
                lkeTituloObtenido.Properties.DataSource = dt
                lkeTituloObtenido.Properties.ValueMember = "Codigo"
                lkeTituloObtenido.Properties.DisplayMember = "Descripcion"
                lkeTituloObtenido.Properties.PopulateColumns()
                lkeTituloObtenido.Properties.Columns(0).Visible = False
                lkeTituloObtenido.ItemIndex = 0
                If dt.Rows.Count < 10 Then lkeTituloObtenido.Properties.DropDownRows = dt.Rows.Count
            Else
                'mensajeExitoso("No se registra ninguna profesión a ese nivel educativo, si desea puede agregarlo presionando clic en el boton +")
                lkeTituloObtenido.Properties.DataSource = Nothing
                lkeTituloObtenido.Properties.ValueMember = ""
                lkeTituloObtenido.Properties.DisplayMember = ""
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "lkeNivelEducativo_EditValueChanged")
        End Try
    End Sub

    Private Function ValidaCamposInfAcademica() As Boolean
        If lkeNivelEducativo.EditValue Is Nothing Then
            HDevExpre.MensagedeError("Debe seleccionar algún nivel educativo!")
            lkeNivelEducativo.Focus()
            Return False
        ElseIf Me.Sec = "" Then
            HDevExpre.MensagedeError("Lo sentimos!, al parecer no se ha cargado ningun empleado, es imposible seguir con el registro!")

            Return False
        ElseIf lkeTituloObtenido.EditValue Is Nothing Then
            HDevExpre.MensagedeError("Debe seleccionar el titulo obtenido!")
            lkeTituloObtenido.Focus()
            Return False
        ElseIf txtInstitucionObtTitulo.ValordelControl = "" Then
            HDevExpre.MensagedeError("El campo Institucion donde Obtuvo el titulo no puede estar vacio!")
            txtInstitucionObtTitulo.Focus()
            Return False
        ElseIf ndDuracion.EditValue <= 0 Then
            HDevExpre.MensagedeError("La duración del estudio no puede ser inferior a 1 [Horas,Meses o Años]")
            ndDuracion.Focus()
            Return False
        ElseIf lkeMuniObtTitulo.EditValue Is Nothing Then
            HDevExpre.MensagedeError("Indique el lugar donde Obtuvi el Titulo")
            lkeMuniObtTitulo.Focus()
            Return False
        ElseIf DateDiff(DateInterval.Hour, Datos.Smt_FechaDelServidor, dteFechaGrado.DateTime) >= 0 Then
            HDevExpre.MensagedeError("La fecha de Grado terminación no puede ser mayor a la fecha actual!")
            dteFechaGrado.Focus()
            Return False
        Else
            Return True
        End If
    End Function

    Private Enum TipoTiempo
        Horas = 0
        Meses = 1
        Años = 2
    End Enum

    Private Sub GuardaInfAcademica()
        Try
            ' 1) Validar campos de UI
            If Not ValidaCamposInfAcademica() Then
                Return
            End If
            If secRegInfAcademica = "" Then
                secRegInfAcademica = "0"
            End If
            ' 2) Mapear controles al modelo
            Dim edu As New Empleados_Educacion With {
            .Sec = CType(secRegInfAcademica, Integer),
            .Empleado = Me.Sec,
            .NivelEstudio = lkeNivelEducativo.EditValue?.ToString(),
            .FechaGrado = dteFechaGrado.DateTime,
            .Duracion = ndDuracion.EditValue.ToString(),
            .TipoTiempo = cbxTipoTiempo.SelectedIndex.ToString(),
            .IdTituloObtenido = lkeTituloObtenido.EditValue.ToString(),
            .NombreInstitucion = txtInstitucionObtTitulo.ValordelControl,
            .MatriculaProfesional = txtMatriculaProfesional.ValordelControl,
            .LugarTitulo = lkeMuniObtTitulo.EditValue.ToString()
        }

            ' 3) Llamar al servicio
            Dim svc As New ServiceEmpleados()
            Dim respuesta As DynamicUpsertResponseDto = svc.GuardaInfAcademica(edu)
            If respuesta Is Nothing OrElse respuesta.ErrorCount > 0 Then
                HDevExpre.MensagedeError("Error al guardar información académica.")
                Return
            End If

            ' 4) Determinar SecIngreso real
            Dim secTipo As Integer
            If Not ActualizandoEstudios Then
                Dim sql = $"SELECT MAX(Sec) FROM Empleados_Educacion WHERE Empleado={Me.Sec}"
                secTipo = CInt(SMT_AbrirTabla(ObjetoApiNomina, sql).Rows(0)(0))
            Else
                secTipo = secRegInfAcademica
            End If

            'SMT_EjcutarComandoSql(ObjetoApiNomina, "Delete from Empleados_RegFot where IdEmpleado=" & idEmpleado & " and SecTipo=" & secTipo & " and tipo=" & CInt(HEmpleado.TiposDeImagenes.Estduios), 0)

            ' 5) Guardar imágenes asociadas
            If svc.GuardaImagenesEmpleado(grupoImgsInfAcademica, Me.Sec, HEmpleado.TiposDeImagenes.Estduios, secTipo, 0) Then
                HDevExpre.mensajeExitoso("Información académica guardada correctamente.")
                LlenaGrillaInfAcademica(Me.Sec)
                CargaImagenesEmpleado()
                LimpiarCamposInfAcademica()
            Else
                HDevExpre.MensagedeError("Error al guardar imágenes de formación académica.")
            End If

        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "GuardaInfAcademica")
        End Try
    End Sub


    Private Sub LimpiarCamposInfAcademica()
        Try
            lkeNivelEducativo.ItemIndex = 0
            lkeTituloObtenido.ItemIndex = 0
            txtInstitucionObtTitulo.ValordelControl = ""
            txtMatriculaProfesional.ValordelControl = ""
            ndDuracion.EditValue = 0
            cbxTipoTiempo.SelectedIndex = 0
            lkePaisObtTitulo.ItemIndex = 0
            lkeDepObtTitulo.ItemIndex = 0
            lkeMuniObtTitulo.ItemIndex = 0
            dteFechaGrado.DateTime = Datos.Smt_FechaDelServidor
            ActualizandoEstudios = False
            Me.secRegInfAcademica = ""
            grupoImgsInfAcademica.Items.Clear()
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "LimpiarCamposInfAcademica")
        End Try
    End Sub

    Private Sub CargarDatosInfAcademica()
        Try
            If gvEstudios.RowCount > 0 Then
                Dim Formal As Boolean = False
                Dim IdNivelEdu As Short = Convert.ToInt16(gvEstudios.GetFocusedRowCellValue("IdNivel"))
                Dim IdTitulo As Short = Convert.ToInt16(gvEstudios.GetFocusedRowCellValue("IdProfesion"))
                secRegInfAcademica = gvEstudios.GetFocusedRowCellValue("SecIngreso")
                Formal = gvEstudios.GetFocusedRowCellValue("EsFormal")
                If Formal Then
                    grbTipoEducacion.SelectedIndex = 1
                Else
                    grbTipoEducacion.SelectedIndex = 0
                End If
                lkeNivelEducativo.EditValue = IdNivelEdu
                lkeTituloObtenido.EditValue = IdTitulo
                txtInstitucionObtTitulo.ValordelControl = gvEstudios.GetFocusedRowCellValue("NombreInstitucion")
                txtMatriculaProfesional.ValordelControl = gvEstudios.GetFocusedRowCellValue("MatriculaProfesional")
                ndDuracion.EditValue = gvEstudios.GetFocusedRowCellValue("Duracion")
                dteFechaGrado.DateTime = gvEstudios.GetFocusedRowCellValue("FechaGrado")
                cbxTipoTiempo.SelectedIndex = gvEstudios.GetFocusedRowCellValue("TipoTiempo")
                HDevExpre.Cargalke(gvEstudios.GetFocusedRowCellValue("IdMunicipio"), lkeDepObtTitulo, lkePaisObtTitulo)
                ActualizandoEstudios = True
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "CargarDatosInfAcademica")
        End Try
    End Sub

    Private Sub lkePaisObtTitulo_EditValueChanged(sender As Object, e As EventArgs) Handles lkePaisObtTitulo.EditValueChanged
        Dim sql As String = String.Format("SELECT DP.Sec AS Codigo, DP.NomDpto AS Descripcion FROM G_Departamento DP WHERE DP.Pais={0}",
                         lkePaisObtTitulo.EditValue)
        HDevExpre.LlenaLkeConDt(lkeDepObtTitulo, sql, "Descripcion", "Codigo")
    End Sub

    Private Sub lkeDepObtTitulo_EditValueChanged(sender As Object, e As EventArgs) Handles lkeDepObtTitulo.EditValueChanged
        Dim sql As String = String.Format("SELECT MN.IdMunicipio AS Codigo, MN.NombreMunicipio AS Descripcion FROM G_Municipio MN WHERE MN.Departamento={0}", lkeDepObtTitulo.EditValue)
        HDevExpre.LlenaLkeConDt(lkeMuniObtTitulo, sql, "Descripcion", "Codigo")
    End Sub


    Private Sub btnAddNivelEducativo_Click(sender As Object, e As EventArgs) Handles btnAddNivelEducativo.Click
        Try
            Dim classResize As New ClaseResize
            Dim Frm As New FrmAggNivelEducativo
            classResize.Resizamodales(Frm, 80, 70)
            Frm.ShowDialog()
            Frm.BringToFront()
            LlenaLkeNivelesEducativos()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAddTitulo_Click(sender As Object, e As EventArgs) Handles btnAddTitulo.Click
        Try
            Dim classResize As New ClaseResize
            Dim Frm As New FrmAggTituloProfesion
            classResize.Resizamodales(Frm, 80, 70)
            Frm.ShowDialog()
            Frm.BringToFront()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub gvEstudios_DoubleClick(sender As Object, e As EventArgs) Handles gvEstudios.DoubleClick
        Try
            CargarDatosInfAcademica()
            If dtImagenes.Rows.Count > 0 Then
                Dim StringFiltro As String = String.Format("IdEmpleado={0} AND Tipo={1} AND SecTipo={2} ", Me.Sec,
                                             Convert.ToInt32(HEmpleado.TiposDeImagenes.Estduios),
                                             gvEstudios.GetFocusedRowCellValue("SecIngreso"))
                MostrarImagenesEnGaleria(StringFiltro, grupoImgsInfAcademica)
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "gvEstudios_DoubleClick")
        End Try
    End Sub

    Private Sub grbTipoEducacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles grbTipoEducacion.SelectedIndexChanged
        LlenaLkeNivelesEducativos()
    End Sub
    Private Sub gvEstudios_KeyPress(sender As Object, e As KeyPressEventArgs) Handles gvEstudios.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            CargarDatosInfAcademica()
            If dtImagenes.Rows.Count > 0 Then
                Dim StringFiltro As String = String.Format("IdEmpleado={0} AND Tipo={1} AND SecTipo={2} ", Me.Sec,
                                             Convert.ToInt32(HEmpleado.TiposDeImagenes.Estduios),
                                             gvEstudios.GetFocusedRowCellValue("SecIngreso"))
                MostrarImagenesEnGaleria(StringFiltro, grupoImgsInfAcademica)
            End If
        End If
    End Sub

#End Region
#Region "Funciones y Procedimientos --> Familiares"
    Private Sub LlenaLkeParentescoFamiliares()
        Try
            Const sql As String = "SELECT PT.Sec AS Codigo, PT.NomParentesco AS Descripcion FROM CAT_Parentesco PT WHERE Estado=1"
            Dim dt As DataTable = SMT_AbrirTabla(ObjetoApiNomina, sql)
            If dt.Rows.Count > 0 Then
                With lkeParentescoFamiliar
                    .Properties.DataSource = dt
                    .Properties.DisplayMember = "Descripcion"
                    .Properties.ValueMember = "Codigo"
                    '.Properties.PopulateColumns()
                    .Properties.Columns(0).Visible = False
                    .ItemIndex = 0
                End With
                If dt.Rows.Count < 10 Then lkeParentescoFamiliar.Properties.DropDownRows = dt.Rows.Count
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "LlenaLkeParentescoFamiliares")
        End Try
    End Sub
    Private Sub CreaGrillaFamiliares()
        Try
            gvFamiliares.Columns.Clear()
            HDevExpre.CreaColumnasG(gvFamiliares, "SecIngreso", "SecIngreso", False, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 0, 0)
            HDevExpre.CreaColumnasG(gvFamiliares, "IdParentesco", "IdParentesco", False, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 0, 0)
            HDevExpre.CreaColumnasG(gvFamiliares, "Ciudad", "Ciudad", False, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 0, 0)
            HDevExpre.CreaColumnasG(gvFamiliares, "TipoIdentificacion", "Tipo Doc.", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 15, gbxGrillaFamiliares.Width)
            HDevExpre.CreaColumnasG(gvFamiliares, "Identificacion", "Num. Documento", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 15, gbxGrillaFamiliares.Width)
            HDevExpre.CreaColumnasG(gvFamiliares, "NomParentesco", "Parentesco", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 15, gbxGrillaFamiliares.Width)
            HDevExpre.CreaColumnasG(gvFamiliares, "Nombre", "Nombre Completo", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 15, gbxGrillaFamiliares.Width)
            HDevExpre.CreaColumnasG(gvFamiliares, "Celular", "Celular", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 15, gbxGrillaFamiliares.Width)
            HDevExpre.CreaColumnasG(gvFamiliares, "FechaNacimiento", "Fec. Nacimiento", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 15, gbxGrillaFamiliares.Width)
            HDevExpre.CreaColumnasG(gvFamiliares, "Ocupacion", "Ocupacion", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 15, gbxGrillaFamiliares.Width)
            HDevExpre.CreaColumnasG(gvFamiliares, "EmpresaWk", "Empresa Labora", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 15, gbxGrillaFamiliares.Width)
            HDevExpre.CreaColumnasG(gvFamiliares, "CargoActual", "Cargo", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 15, gbxGrillaFamiliares.Width)
            HDevExpre.CreaColumnasG(gvFamiliares, "Telefonos", "Telefonos", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 15, gbxGrillaFamiliares.Width)
            HDevExpre.CreaColumnasG(gvFamiliares, "Direccion", "Direccion", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 15, gbxGrillaFamiliares.Width)
            HDevExpre.CreaColumnasG(gvFamiliares, "NombreMunicipio", "Ciudad", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 15, gbxGrillaFamiliares.Width)
            gvFamiliares.Appearance.HeaderPanel.Font = New Font("Trebuchet MS", 11.0!, FontStyle.Bold)
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "CreaGrillaFamiliares")
        End Try
    End Sub
    Private Sub ConsultaFamiliar(NumDocFamiliar As String)
        Try
            If IsNothing(NumDocFamiliar) Or String.IsNullOrWhiteSpace(NumDocFamiliar) Then
                Exit Sub
            End If
            Dim sql As String = String.Format("SELECT * FROM Familiares WHERE Identificacion={0}", NumDocFamiliar)
            Dim dt As DataTable = SMT_AbrirTabla(ObjetoApiNomina, sql)
            If dt.Rows.Count > 0 Then
                ConsulrarFamiliarEnBDnomina(dt)
            Else
                'sql = String.Format("SELECT RTRIM(LTRIM(RTRIM(LTRIM(PNombre)) + ' ' +  " &
                '                    " RTRIM(LTRIM(SNombre)) + ' ' +  RTRIM(LTRIM(PApellido)) + ' ' + " &
                '                    " RTRIM(LTRIM(SApellido)))) As NomFamiliar, " &
                '                    " FechaNacimiento, NumCelular, EmpresaLab, TelEmpLab, CargoEmpLab" &
                '                    " FROM G_Clientes WHERE Identificacion ={0}", NumDocFamiliar)
                'dt = SMT_AbrirTabla(ObjetoApiNomina, sql)
                'If dt.Rows.Count > 0 Then
                '    ConsultarFamiliarEnBDprincipal(dt)
                'Else
                '    YaExisteFamiliar = False
                'End If
            End If

        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "ConsultaFamiliar")
        End Try
    End Sub
    Private Sub ConsultarFamiliarEnBDprincipal(dt As DataTable)
        Try
            Dim fila As DataRow = dt.Rows(0)
            txtNombreFamiliar.ValordelControl = AsignarCampo(fila, "NomFamiliar")
            dteFecNacFamiliar.DateTime = AsignarCampo(fila, "FechaNacimiento")
            txtCelFamiliar.ValordelControl = AsignarCampo(fila, "NumCelular")
            txtEmpresaTrabajaFamiliar.ValordelControl = AsignarCampo(fila, "EmpresaLab")
            txtTelsEmpTrabajaFamiliar.ValordelControl = AsignarCampo(fila, "TelEmpLab")
            txtCargoFamiliar.ValordelControl = AsignarCampo(fila, "CargoEmpLab")
            YaExisteFamiliar = False
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "ConsultarFamiliarEnBDprincipal")
        End Try
    End Sub
    Private Sub ConsulrarFamiliarEnBDnomina(dt As DataTable)
        Try
            Dim fila As DataRow = dt.Rows(0)
            lkeTipoDocFamiliar.EditValue = AsignarCampo(fila, "TipoIdentificacion")
            'lkeParentescoFamiliar.EditValue = AsignarCampo(fila, "IdParentesco")
            dteFecNacFamiliar.DateTime = AsignarCampo(fila, "FechaNacimiento")
            txtNombreFamiliar.ValordelControl = AsignarCampo(fila, "Nombre")
            txtCelFamiliar.ValordelControl = AsignarCampo(fila, "Celular")
            txtOcupacionFamiliar.ValordelControl = AsignarCampo(fila, "Ocupacion")
            txtEmpresaTrabajaFamiliar.ValordelControl = AsignarCampo(fila, "EmpresaWk")
            txtTelsEmpTrabajaFamiliar.ValordelControl = AsignarCampo(fila, "Telefonos")
            txtCargoFamiliar.ValordelControl = AsignarCampo(fila, "CargoActual")
            txtDirEmpTrabajaFamiliar.ValordelControl = AsignarCampo(fila, "Direccion")
            HDevExpre.Cargalke(fila("Ciudad"), lkeDepEmpTrabajaFamiliar, lkePaisEmpTrabajaFamiliar)
            YaExisteFamiliar = True
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "ConsultarFamiliarEnBDprincipal")
        End Try
    End Sub
    Private Sub LlenaGrillaFamiliares(idEmp As String)
        Try
            Dim row As DataRow
            Dim copyDt As DataTable
            Dim sql As String = String.Format("SELECT FM.Sec as SecIngreso,FM.TipoIdentificacion,FM.Identificacion, " &
                                            " RF.parentesco AS IdParentesco,PT.NomParentesco, FM.Nombre,FM.FechaNacimiento," &
                                            " FM.Ocupacion, FM.EmpresaWk, FM.CargoActual, FM.Telefonos," &
                                            " FM.Celular, FM.Direccion, FM.Ciudad, MN.NombreMunicipio" &
                                            " FROM RelFami RF " &
                                            " INNER JOIN Empleados EM ON RF.empleado=EM.Sec " &
                                            " INNER JOIN Familiares FM ON RF.familiar=FM.Sec " &
                                            " INNER JOIN CAT_Parentesco PT ON PT.Sec= RF.parentesco" &
                                            " INNER JOIN G_Municipio MN ON MN.IdMunicipio= FM.Ciudad" &
                                            " WHERE RF.Empleado={0}", idEmp)
            Dim dt As DataTable = SMT_AbrirTabla(ObjetoApiNomina, sql)
            copyDt = dt.Clone
            For i = 0 To dt.Rows.Count - 1
                row = copyDt.NewRow
                row("SecIngreso") = dt.Rows(i)("SecIngreso")
                row("TipoIdentificacion") = dt.Rows(i)("TipoIdentificacion")
                row("Identificacion") = dt.Rows(i)("Identificacion")
                row("IdParentesco") = dt.Rows(i)("IdParentesco")
                row("NomParentesco") = StrConv(dt.Rows(i)("NomParentesco").ToString, VbStrConv.ProperCase)
                row("Nombre") = StrConv(dt.Rows(i)("Nombre").ToString, VbStrConv.ProperCase)
                row("Celular") = dt.Rows(i)("Celular")
                row("FechaNacimiento") = dt.Rows(i)("FechaNacimiento")
                row("Ocupacion") = StrConv(dt.Rows(i)("Ocupacion").ToString, VbStrConv.ProperCase)
                row("EmpresaWk") = StrConv(dt.Rows(i)("EmpresaWk").ToString, VbStrConv.ProperCase)
                row("CargoActual") = StrConv(dt.Rows(i)("CargoActual").ToString, VbStrConv.ProperCase)
                row("Telefonos") = dt.Rows(i)("Telefonos")
                row("Direccion") = StrConv(dt.Rows(i)("Direccion").ToString, VbStrConv.ProperCase)
                row("Ciudad") = dt.Rows(i)("Ciudad")
                row("NombreMunicipio") = StrConv(dt.Rows(i)("NombreMunicipio").ToString, VbStrConv.ProperCase)
                copyDt.Rows.Add(row)
                copyDt.AcceptChanges()
            Next
            gcFamiliares.DataSource = copyDt
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "LlenaGrillaFamiliares")
        End Try
    End Sub
    Private Sub LimpiarCamposFamiliares()
        Try
            lkeTipoDocFamiliar.ItemIndex = 0
            txtDocFamiliar.ValordelControl = ""
            lkeParentescoFamiliar.ItemIndex = 0
            dteFecNacFamiliar.DateTime = Datos.Smt_FechaDelServidor
            txtNombreFamiliar.ValordelControl = ""
            txtCelFamiliar.ValordelControl = ""
            txtOcupacionFamiliar.ValordelControl = ""
            txtEmpresaTrabajaFamiliar.ValordelControl = ""
            txtCargoFamiliar.ValordelControl = ""
            txtTelsEmpTrabajaFamiliar.ValordelControl = ""
            txtDirEmpTrabajaFamiliar.ValordelControl = ""
            lkePaisEmpTrabajaFamiliar.ItemIndex = 0
            lkeDepEmpTrabajaFamiliar.ItemIndex = 0
            lkeMuniEmpTrabajaFamiliar.ItemIndex = 0
            pcbImgFamiliar.Image = Nothing
            SecRegFamiliar = ""
            ActualizandoFamiliares = False
            lkeTipoDocFamiliar.Focus()
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "LimpiarCamposFamiliares")
        End Try
    End Sub
    Private Function ValidaCamposFamiliar() As Boolean
        Try
            If lkeTipoDocFamiliar.EditValue Is Nothing Then
                HDevExpre.MensagedeError("Debe seleccionar un tipo de documento!")
                lkeTipoDocFamiliar.Focus()
                Return False
            ElseIf Me.Sec = "" Then
                HDevExpre.MensagedeError("Lo sentimos!, al parecer no se ha cargado ningun empleado, es imposible seguir con el registro!")

                Return False
            ElseIf txtDocFamiliar.ValordelControl = "" Then
                HDevExpre.MensagedeError("El numero de docuemto del familiar no puede estar vacío!")
                txtDocFamiliar.Focus()
                Return False
            ElseIf lkeParentescoFamiliar.EditValue Is Nothing Then
                HDevExpre.MensagedeError("Debe seleccionar el parentesco que tiene con el empleado")
                lkeParentescoFamiliar.Focus()
                Return False
            ElseIf dteFecNacFamiliar.Text = "" Then
                HDevExpre.MensagedeError("La fecha de nacimiento no puede estar Vacía!")
                dteFecNacFamiliar.Focus()
                Return False
            ElseIf DateDiff(DateInterval.Day, dteFecNacFamiliar.DateTime, Datos.Smt_FechaDelServidor) < 1 Then
                HDevExpre.MensagedeError("Lo sentimos, al parecer la fecha de nacimiento es menor a un día según la fecha Actual!")
                dteFecNacFamiliar.Focus()
                Return False
            ElseIf txtNombreFamiliar.ValordelControl = "" Then
                HDevExpre.MensagedeError("Nombre del familiar no puede estar vacío!")
                txtNombreFamiliar.Focus()
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "ValidaCamposFamiliar")
            Return False
        End Try
    End Function

    Private Sub GuardaFamiliar()
        Try
            If Not ValidaCamposFamiliar() Then Return

            ' ————————————————————————
            ' 1) Recoger valores tal cual tenías
            ' ————————————————————————
            Dim Ocupacion As String = IIf(txtOcupacionFamiliar.ValordelControl = "", "", txtOcupacionFamiliar.ValordelControl)
            Dim Emp As String = IIf(txtEmpresaTrabajaFamiliar.ValordelControl = "", "", txtEmpresaTrabajaFamiliar.ValordelControl)
            Dim Cargo As String = IIf(txtCargoFamiliar.ValordelControl = "", "", txtCargoFamiliar.ValordelControl)
            Dim telsEmp As String = IIf(txtTelsEmpTrabajaFamiliar.ValordelControl = "", "", txtTelsEmpTrabajaFamiliar.ValordelControl)
            Dim cel As String = IIf(txtCelFamiliar.ValordelControl = "", "", txtCelFamiliar.ValordelControl)
            Dim dirEmp As String = IIf(txtDirEmpTrabajaFamiliar.ValordelControl = "", "", txtDirEmpTrabajaFamiliar.ValordelControl)
            Dim muni As String = IIf(lkeMuniEmpTrabajaFamiliar.EditValue Is Nothing, "", lkeMuniEmpTrabajaFamiliar.EditValue.ToString())

            ' Instanciar el servicio
            Dim svc As New ServiceEmpleados()
            If Me.SecRegFamiliar = "" Then
                Me.SecRegFamiliar = "0"
            End If

            ' ————————————————————————
            ' 2) Crear y enviar el registro 'Familiares'
            ' ————————————————————————
            Dim fam As New Familiares With {
            .Sec = Me.SecRegFamiliar,
            .TipoIdentificacion = lkeTipoDocFamiliar.EditValue.ToString(),
            .Identificacion = txtDocFamiliar.ValordelControl,
            .Nombre = txtNombreFamiliar.ValordelControl,
            .FechaNacimiento = dteFecNacFamiliar.DateTime,
            .Ocupacion = Ocupacion,
            .EmpresaWk = Emp,
            .CargoActual = Cargo,
            .Telefonos = telsEmp,
            .Celular = cel,
            .Direccion = dirEmp,
            .Ciudad = muni
        }
            Dim resFam As DynamicUpsertResponseDto = svc.UpsertFamiliar(fam)
            If resFam Is Nothing OrElse resFam.ErrorCount > 0 Then
                HDevExpre.MensagedeError("Error al guardar datos de familiar.")
                Return
            End If

            ' ————————————————————————
            ' 3) Determinar SecIngreso real
            ' ————————————————————————
            Dim secFam As Integer
            If Not ActualizandoFamiliares Then
                Dim sql = $"SELECT MAX(Sec) FROM Familiares"
                secFam = CInt(SMT_AbrirTabla(ObjetoApiNomina, sql).Rows(0)(0))
            Else
                secFam = Me.SecRegFamiliar
            End If

            ' ————————————————————————
            ' 4) Crear y enviar la relación 'RelFami'

            ' ————————————————————————
            SMT_EjcutarComandoSql(ObjetoApiNomina, "Delete from RelFami where empleado=" & Me.Sec & " and familiar=" & secFam.ToString(), 0)
            Dim rel As New RelFami With {
            .Sec = Nothing,          ' o tu variable SecRel si ya la tienes
            .empleado = Me.Sec,
            .familiar = secFam,
            .parentesco = lkeParentescoFamiliar.EditValue.ToString()
        }
            Dim resRel As DynamicUpsertResponseDto = svc.UpsertRelFamiliar(rel)
            If resRel Is Nothing OrElse resRel.ErrorCount > 0 Then
                HDevExpre.MensagedeError("Error al guardar la relación empleado-familiar.")
                Return
            End If

            ' ————————————————————————
            ' 5) Guardar imagen si existe
            ' ————————————————————————
            If pcbImgFamiliar.Image IsNot Nothing Then
                svc.GuardaImagenSola(
                pcbImgFamiliar.Image,
                Me.Sec,
                HelperEmpleado.TiposDeImagenes.Familiares,
                secFam,
                True
            )
            End If

            ' ————————————————————————
            ' 6) Éxito y refresco de UI
            ' ————————————————————————
            HDevExpre.mensajeExitoso("Información guardada exitosmamente")
            LimpiarCamposFamiliares()
            LlenaGrillaFamiliares(Me.Sec)

        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "GuardaFamiliar")
        End Try
    End Sub


    Private Sub CargarDatosFamiliar()
        Try
            If gvFamiliares.RowCount > 0 Then
                Dim dt As DataTable
                Dim sql As String
                Dim Img As Image
                Dim Muni As String
                SecRegFamiliar = gvFamiliares.GetFocusedRowCellValue("SecIngreso")
                lkeTipoDocFamiliar.EditValue = gvFamiliares.GetFocusedRowCellValue("TipoIdentificacion")
                txtDocFamiliar.ValordelControl = gvFamiliares.GetFocusedRowCellValue("Identificacion")
                lkeParentescoFamiliar.EditValue = gvFamiliares.GetFocusedRowCellValue("IdParentesco")
                dteFecNacFamiliar.DateTime = gvFamiliares.GetFocusedRowCellValue("FechaNacimiento")
                txtNombreFamiliar.ValordelControl = gvFamiliares.GetFocusedRowCellValue("Nombre")
                txtCelFamiliar.ValordelControl = IIf(gvFamiliares.GetFocusedRowCellValue("Celular").ToString = "", "", gvFamiliares.GetFocusedRowCellValue("Celular").ToString)
                txtOcupacionFamiliar.ValordelControl = IIf(gvFamiliares.GetFocusedRowCellValue("Ocupacion").ToString = "", "", gvFamiliares.GetFocusedRowCellValue("Ocupacion").ToString)
                txtEmpresaTrabajaFamiliar.ValordelControl = IIf(gvFamiliares.GetFocusedRowCellValue("EmpresaWk").ToString = "", "", gvFamiliares.GetFocusedRowCellValue("EmpresaWk").ToString)
                txtCargoFamiliar.ValordelControl = IIf(gvFamiliares.GetFocusedRowCellValue("CargoActual").ToString = "", "", gvFamiliares.GetFocusedRowCellValue("CargoActual").ToString)
                txtTelsEmpTrabajaFamiliar.ValordelControl = IIf(gvFamiliares.GetFocusedRowCellValue("Telefonos").ToString = "", "", gvFamiliares.GetFocusedRowCellValue("Telefonos").ToString)
                txtDirEmpTrabajaFamiliar.ValordelControl = IIf(gvFamiliares.GetFocusedRowCellValue("Direccion").ToString = "", "", gvFamiliares.GetFocusedRowCellValue("Direccion").ToString)
                Muni = IIf(gvFamiliares.GetFocusedRowCellValue("Ciudad").ToString = "", "", gvFamiliares.GetFocusedRowCellValue("Ciudad"))
                HDevExpre.Cargalke(Muni, lkeDepEmpTrabajaFamiliar, lkePaisEmpTrabajaFamiliar)
                sql = String.Format("SELECT Foto FROM Empleados_RegFot EF WHERE EF.IdEmpleado={0} AND EF.Tipo={1} AND SecTipo={2} AND Predeterminada=1",
                                                 Me.Sec, Convert.ToInt32(HEmpleado.TiposDeImagenes.Familiares), Me.SecRegFamiliar)
                dt = SMT_AbrirTabla(ObjetoApiNomina, sql)
                If dt.Rows.Count > 0 Then
                    If Not IsDBNull(dt.Rows(0)(0)) Then
                        Img = SamitCtlNet.SamitCtlNet.ClSmtImagenes.SMT_Conv_Byte_A_Image(dt.Rows(0)(0))
                        pcbImgFamiliar.Image = Img
                    Else
                        pcbImgFamiliar.Image = Nothing
                    End If
                Else
                    pcbImgFamiliar.Image = Nothing
                End If
                lkeTipoDocFamiliar.Focus()
                ActualizandoFamiliares = True
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "CargarDatosFamiliar")
        End Try

    End Sub
    Private Function EliminaFamiliar(SecRegistro As String, IdEmp As String) As Boolean
        Try
            Dim request As New EliminarFamiliarRequest(CInt(SecRegistro), CInt(IdEmp))

            ' Ejecutar el procedimiento almacenado
            Dim resp = SMT_EjecutaProcedimientos(ObjetoApiNomina, "SP_EliminarFamiliar", request.ToJObject())

            ' IMPORTANTE: Reutilizamos la misma clase DynamicDeleteResponse
            Dim response = resp.ToObject(Of DynamicDeleteResponse)()

            ' Procesar respuesta
            If response.EsExitoso Then
                ' Log opcional
                Console.WriteLine($"Familiar eliminado: {response.RegistrosEliminados} registros afectados")
                Return True

            ElseIf response.EsAdvertencia Then
                ' El familiar no existe, pero no es un error crítico
                HDevExpre.MensagedeError(response.Mensaje)
                Return False

            Else ' Es Error
                HDevExpre.msgError(Nothing, response.Mensaje, "EliminaFamiliar")
                Return False
            End If

            Return True
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "EliminaExpLaboral")
            Return False
        End Try
    End Function
    Private Sub gvFamiliares_DoubleClick(sender As Object, e As EventArgs) Handles gvFamiliares.DoubleClick
        CargarDatosFamiliar()
    End Sub
    Private Sub gvFamiliares_KeyPress(sender As Object, e As KeyPressEventArgs) Handles gvFamiliares.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            CargarDatosFamiliar()
        End If
    End Sub
#End Region
#Region "Funciones y Procedimientos --> Afiliaciones"
    Private Sub LimpiarCamposAfiliaciones()
        Try
            txtEntidad.ValordelControl = ""
            dteFechaRegistroEmpEntidad.DateTime = Datos.Smt_FechaDelServidor
            rgbEmpRetiradoEntidad.SelectedIndex = 0
            txtCausaRetiroEntidad.Text = ""
            grupoImgsAfiliaciones.Items.Clear()
            txtEntidad.Enabled = True
            dteFechaRegistroEmpEntidad.ReadOnly = False
            rgbEmpRetiradoEntidad.ReadOnly = False
            txtCausaRetiroEntidad.ReadOnly = False
            ActualizandoAfiliaciones = False
            SecRegAfiliacion = ""
            txtTipoEntidad.Focus()
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "LimpiarCamposAfiliaciones")
        End Try
    End Sub
    Private Function ValidaCamposAfiliaciones() As Boolean
        Try
            If txtEntidad.ValordelControl = "" Then
                HDevExpre.MensagedeError("Debe seleccionar la entidad a la cual desea afiliar el empleado!")
                txtTipoEntidad.Focus()
                Return False
            ElseIf Me.Sec = "" Then
                HDevExpre.MensagedeError("Lo sentimos!, al parecer no se ha cargado ningun empleado, es imposible seguir con el registro!")

                Return False
            ElseIf DateDiff(DateInterval.Day, Datos.Smt_FechaDelServidor, dteFechaRegistroEmpEntidad.DateTime) > 0 Then
                HDevExpre.MensagedeError("Lo sentimos!, al parecer la fecha de registro es mayor a la fecha actual!")
                dteFechaRegistroEmpEntidad.Focus()
                Return False
            ElseIf rgbEmpRetiradoEntidad.SelectedIndex = 1 Then
                If txtCausaRetiroEntidad.Text = "" Then
                    HDevExpre.MensagedeError("Por favor indique el motivo de retiro de la entidad!")
                    txtCausaRetiroEntidad.Focus()
                    Return False
                Else
                    Return True
                End If
            Else
                Return True
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "ValidaCamposAfiliaciones")
            Return False
        End Try
    End Function
    Private Sub CreaGrillaAfiliaciones()
        gvAfilicaciones.Columns.Clear()
        HDevExpre.CreaColumnasG(gvAfilicaciones, "Sec", "Sec", False, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 0, 0)
        HDevExpre.CreaColumnasG(gvAfilicaciones, "Empleado", "Empleado", False, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 0, 0)
        HDevExpre.CreaColumnasG(gvAfilicaciones, "TipoEnte", "TipoEnte", False, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 0, 0)
        HDevExpre.CreaColumnasG(gvAfilicaciones, "SecEntesSSAP", "SecEntesSSAP", False, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 0, 0)
        HDevExpre.CreaColumnasG(gvAfilicaciones, "FechaRegistro", "Fec. Registro", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 20, gbxGrillaAfiliaciones.Width)
        HDevExpre.CreaColumnasG(gvAfilicaciones, "Retirado", "Retirado", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 20, gbxGrillaAfiliaciones.Width)
        HDevExpre.CreaColumnasG(gvAfilicaciones, "FechaRetiro", "Fec. Retiro", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 20, gbxGrillaAfiliaciones.Width)
        HDevExpre.CreaColumnasG(gvAfilicaciones, "CausadeRetiro", "Causa de Retiro", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 20, gbxGrillaAfiliaciones.Width)
        HDevExpre.CreaColumnasG(gvAfilicaciones, "NombreEntidad", "Nombre de la Entidad", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 20, gbxGrillaAfiliaciones.Width)
        gvAfilicaciones.Appearance.HeaderPanel.Font = New Font("Trebuchet MS", 11.0!, FontStyle.Bold)
        'gvAfilicaciones.Columns(3).ColumnEdit = gvEstudios.Columns(3).View.GridControl.RepositoryItems.Add("TextEdit")
        'gvAfilicaciones.Columns(3).DisplayFormat.Format = New FormatoBooleanGrilla("SI", "NO")
    End Sub
    Private Sub LlenaGrillaAfiliaciones(IdEmp As String)
        Try

            Dim sql As String = String.Format("SELECT ET.*,EN.TipoEnte, EN.NombreEntidad FROM EntesTercero ET " &
                                " INNER JOIN EntesSSAP EN ON EN.Sec=ET.SecEntesSSAP" &
                                " WHERE Empleado={0}", IdEmp)
            Dim dt As DataTable = SMT_AbrirTabla(ObjetoApiNomina, sql)
            Dim CopyDt As New DataTable
            Dim row As DataRow
            Dim FechaRetiro, Retirado As String
            Dim FechaRegistro As Date
            Dim sec As Integer = 0
            CopyDt.Columns.Add("Sec")
            CopyDt.Columns.Add("Empleado")
            CopyDt.Columns.Add("TipoEnte")
            CopyDt.Columns.Add("FechaRegistro")
            CopyDt.Columns.Add("Retirado", GetType(String))
            CopyDt.Columns.Add("FechaRetiro", GetType(String))
            CopyDt.Columns.Add("CausadeRetiro")
            CopyDt.Columns.Add("SecEntesSSAP")
            CopyDt.Columns.Add("NombreEntidad")
            While True
                If sec > dt.Rows.Count - 1 Then
                    Exit While
                End If
                row = CopyDt.NewRow
                If dt.Rows(sec)("FechaRetiro") = "#01/01/1900#" Then
                    FechaRetiro = ""
                Else
                    FechaRetiro = dt.Rows(sec)("FechaRetiro")
                End If
                If dt.Rows(sec)("Retirado") Then
                    Retirado = "SI"
                Else
                    Retirado = "NO"
                End If
                FechaRegistro = dt.Rows(sec)("FechaRegistro")
                row("Sec") = dt.Rows(sec)("Sec")
                row("Empleado") = dt.Rows(sec)("Empleado")
                row("TipoEnte") = dt.Rows(sec)("TipoEnte")
                row("FechaRegistro") = FechaRegistro.ToString("dd/MMM/yyyy")
                row("Retirado") = Retirado
                row("FechaRetiro") = FechaRetiro
                row("CausadeRetiro") = dt.Rows(sec)("CausadeRetiro")
                row("SecEntesSSAP") = dt.Rows(sec)("SecEntesSSAP")
                row("NombreEntidad") = StrConv(dt.Rows(sec)("NombreEntidad").ToString, VbStrConv.ProperCase)
                CopyDt.Rows.Add(row)
                CopyDt.AcceptChanges()
                sec += 1
            End While
            gcAfiliaciones.DataSource = CopyDt

        Catch ex As Exception

        End Try
    End Sub


    Private Sub GuardaAfiliacion()
        Try
            ' 1) Validaciones de UI
            If Not ValidaCamposAfiliaciones() Then
                Return
            End If

            ' 2) Determinar fecha de retiro y limpiar causa si es necesario
            Dim FechaRetiroDate As Date?
            If rgbEmpRetiradoEntidad.SelectedIndex = 0 Then
                FechaRetiroDate = New Date(1900, 1, 1)
                txtCausaRetiroEntidad.Text = ""
            Else
                FechaRetiroDate = Datos.Smt_FechaDelServidor
            End If

            ' 3) Comprobar duplicados en la grilla local
            Dim dt As DataTable = CType(gcAfiliaciones.DataSource, DataTable)
            Dim filas As DataRow() = dt.Select($"SecEntesSSAP = {txtEntidad.ValordelControl} AND Retirado = 'NO'")
            If filas.Length > 0 AndAlso Not ActualizandoAfiliaciones Then
                HDevExpre.MensagedeError("El empleado ya tiene asociada esta entidad y se encuentra activa!")
                Return
            End If


            ' 5) Construir modelo de afiliación
            Dim af As New EntesTercero With {
            .Sec = If(ActualizandoAfiliaciones, CType(Me.SecRegAfiliacion, Integer?), 0),
            .Empleado = Me.idEmpleado,
            .FechaRegistro = dteFechaRegistroEmpEntidad.DateTime,
            .FechaRetiro = FechaRetiroDate,
            .Retirado = rgbEmpRetiradoEntidad.SelectedIndex.ToString(),
            .CausadeRetiro = txtCausaRetiroEntidad.Text,
            .SecEntesSSAP = txtEntidad.ValordelControl
        }

            Dim svc As New ServiceEmpleados()
            Dim resp As DynamicUpsertResponseDto = svc.GuardaAfiliacion(af)
            If resp Is Nothing OrElse resp.ErrorCount > 0 Then
                HDevExpre.MensagedeError("Error al guardar la afiliación.")
                Return
            End If

            ' 6) Obtener el Sec real (si fue inserción)
            Dim secTipo As Integer
            If Not ActualizandoAfiliaciones Then
                secTipo = CInt(SMT_AbrirTabla(ObjetoApiNomina,
                        $"SELECT MAX(Sec) FROM EntesTercero WHERE Empleado={idEmpleado}"
                        ).Rows(0)(0))
            Else
                secTipo = Me.SecRegAfiliacion
            End If
            Dim sql = "Delete from Empleados_RegFot where IdEmpleado=" & idEmpleado &
                    " and SecTipo=" & secTipo &
                    " and tipo=" & CInt(HEmpleado.TiposDeImagenes.Afiliaciones)
            SMT_EjcutarComandoSql(ObjetoApiNomina, sql, 0)

            ' 7) Guardar imágenes de afiliación
            If svc.GuardaImagenesEmpleado(grupoImgsAfiliaciones,
                                      idEmpleado,
                                      HEmpleado.TiposDeImagenes.Afiliaciones,
                                      secTipo, 0) Then
                CargaImagenesEmpleado()
            End If

            ' 8) Refrescar UI
            LlenaGrillaAfiliaciones(Me.idEmpleado)
            LimpiarCamposAfiliaciones()
            HDevExpre.mensajeExitoso("Información de afiliación guardada exitosamente!")

        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "GuardaAfiliacion")
        End Try
    End Sub



    Private Sub CargarDatosAfiliacion()
        Try
            If gvAfilicaciones.RowCount > 0 Then
                Dim Retirado As String = gvAfilicaciones.GetFocusedRowCellValue("Retirado")
                Dim FechaRetiro As String = ""
                Dim SecEntidad As Integer = 0
                txtEntidad.Enabled = False
                If Retirado = "SI" Then
                    dteFechaRegistroEmpEntidad.ReadOnly = True
                    rgbEmpRetiradoEntidad.ReadOnly = True
                    txtCausaRetiroEntidad.ReadOnly = True
                Else
                    dteFechaRegistroEmpEntidad.ReadOnly = False
                    rgbEmpRetiradoEntidad.ReadOnly = False
                    txtCausaRetiroEntidad.ReadOnly = False
                End If
                rgbEmpRetiradoEntidad.SelectedIndex = 0
                If Not IsDBNull(gvAfilicaciones.GetFocusedRowCellValue("FechaRetiro")) Then
                    FechaRetiro = gvAfilicaciones.GetFocusedRowCellValue("FechaRetiro")
                End If
                SecEntidad = gvAfilicaciones.GetFocusedRowCellValue("SecEntesSSAP")
                SecRegAfiliacion = gvAfilicaciones.GetFocusedRowCellValue("Sec")
                txtTipoEntidad.ValordelControl = gvAfilicaciones.GetFocusedRowCellValue("TipoEnte")
                txtEntidad.ValordelControl = SecEntidad
                dteFechaRegistroEmpEntidad.DateTime = gvAfilicaciones.GetFocusedRowCellValue("FechaRegistro")

                If Retirado = "SI" Then rgbEmpRetiradoEntidad.SelectedIndex = 1

                txtCausaRetiroEntidad.Text = gvAfilicaciones.GetFocusedRowCellValue("CausadeRetiro")
                ActualizandoAfiliaciones = True
                txtTipoEntidad.Focus()
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "CargarDatosAfiliacion")
        End Try
    End Sub

    Private Function EliminarAfiliacion(idRegAfiliacion As String) As Boolean
        Try
            Dim request As New DynamicDeleteRequest With {
            .Tabla = "EntesTercero",
            .Codigo = CInt(idRegAfiliacion)
        }
            ' Ejecutar el procedimiento almacenado
            Dim resp = SMT_EjecutaProcedimientos(ObjetoApiNomina, "SP_DynamicDelete", request.ToJObject())
            Dim response = resp.ToObject(Of DynamicDeleteResponse)()

            ' Procesar respuesta
            If response.EsExitoso Then
                Return True

            ElseIf response.EsAdvertencia Then
                Return False

            Else ' Es Error
                Return False
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "EliminarAfiliacion")
            Return False
        End Try
    End Function

    Private Sub LlenaLkeEntidadesAfiliar()
        Try
            Const sql As String = "SELECT EN.Sec AS Codigo, EN.NombreEntidad AS Descripcion FROM EntesSSAP EN WHERE EN.Estado='A'"
            Dim dt As DataTable = SMT_AbrirTabla(ObjetoApiNomina, sql)
            If dt.Rows.Count > 0 Then
                'With lkeEntidadAafiliar
                '    .Properties.DataSource = dt
                '    .Properties.DisplayMember = "Descripcion"
                '    .Properties.ValueMember = "Codigo"
                '    '.Properties.PopulateColumns()
                '    .Properties.Columns(0).Visible = False
                '    .ItemIndex = 0
                '    .Properties.DropDownRows = dt.Rows.Count
                'End With
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "LlenaLkeEntidadesAfiliar")
        End Try
    End Sub

    Private Sub gvAfilicaciones_DoubleClick(sender As Object, e As EventArgs) Handles gvAfilicaciones.DoubleClick
        CargarDatosAfiliacion()
        If dtImagenes.Rows.Count > 0 Then
            Dim StringFiltro As String = String.Format("IdEmpleado={0} AND Tipo={1} AND SecTipo={2} ", Me.Sec,
                                         Convert.ToInt32(HEmpleado.TiposDeImagenes.Afiliaciones),
                                         gvAfilicaciones.GetFocusedRowCellValue("Sec"))
            MostrarImagenesEnGaleria(StringFiltro, grupoImgsAfiliaciones)
        End If
    End Sub

    Private Sub gvAfilicaciones_KeyPress(sender As Object, e As KeyPressEventArgs) Handles gvAfilicaciones.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            CargarDatosAfiliacion()
            If dtImagenes.Rows.Count > 0 Then
                Dim StringFiltro As String = String.Format("IdEmpleado={0} AND Tipo={1} AND SecTipo={2} ", Me.Sec,
                                       Convert.ToInt32(HEmpleado.TiposDeImagenes.Afiliaciones),
                                       gvAfilicaciones.GetFocusedRowCellValue("Sec"))
                MostrarImagenesEnGaleria(StringFiltro, grupoImgsAfiliaciones)
            End If
        End If
    End Sub



    Private Sub rgbEmpRetiradoEntidad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rgbEmpRetiradoEntidad.SelectedIndexChanged
        If rgbEmpRetiradoEntidad.SelectedIndex = 0 Then
            txtCausaRetiroEntidad.Enabled = False
        ElseIf rgbEmpRetiradoEntidad.SelectedIndex = 1 Then
            txtCausaRetiroEntidad.Enabled = True
        End If
    End Sub


    Private Sub dteFechaRegistroEmpEntidad_Enter(sender As Object, e As EventArgs) Handles dteFechaRegistroEmpEntidad.Enter
        HDevExpre.EntraControlDateEditDEV(dteFechaRegistroEmpEntidad, lblFechaRegistroEmpEntidad)
        FrmPrincipal.MensajeDeAyuda.Caption = "Fecha en la que se registra el empleado. (ENTER,TAB)= Avanzar"
    End Sub

    Private Sub dteFechaRegistroEmpEntidad_Leave(sender As Object, e As EventArgs) Handles dteFechaRegistroEmpEntidad.Leave
        HDevExpre.SaleControlDateEditDEV(dteFechaRegistroEmpEntidad, lblFechaRegistroEmpEntidad)
        FrmPrincipal.MensajeDeAyuda.Caption = ""
    End Sub

    Private Sub txtCausaRetiroEntidad_Enter(sender As Object, e As EventArgs) Handles txtCausaRetiroEntidad.Enter
        HDevExpre.EntraControlDev(, , txtCausaRetiroEntidad)
        FrmPrincipal.MensajeDeAyuda.Caption = "Causa por la cual se retira el empleado de la entidad. (ENTER,TAB)=Avanzar"
    End Sub

    Private Sub txtCausaRetiroEntidad_Leave(sender As Object, e As EventArgs) Handles txtCausaRetiroEntidad.Leave
        HDevExpre.SaleControlDev(, , txtCausaRetiroEntidad)
        FrmPrincipal.MensajeDeAyuda.Caption = ""
        btnGuardar.Focus()
    End Sub

    Private Sub btnAggEntidad_Click(sender As Object, e As EventArgs)
        Try
            Dim classResize As New ClaseResize
            If FrmAggEntidad.P_FormularioAbierto Then
                FrmAggEntidad.ShowDialog()
                FrmAggEntidad.BringToFront()
            Else
                FrmAggEntidad.P_FormularioAbierto = True
                classResize.Resizamodales(FrmAggEntidad, 50, 70)
                classResize.ResizeForm(FrmAggEntidad)
                FrmAggEntidad.ShowDialog()
                FrmAggEntidad.BringToFront()
            End If
            LlenaLkeEntidadesAfiliar()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtDocFamiliar_SaleControl(sender As Object, e As EventArgs) Handles txtDocFamiliar.SaleControl
        ConsultaFamiliar(txtDocFamiliar.ValordelControl)
    End Sub
#End Region


    Private Sub txtProfesion_PresionaTecla(sender As Object, e As KeyEventArgs) Handles txtProfesion.PresionaTecla
        Try
            If e.KeyCode = Keys.F5 Then
                txtProfesion.RefrescarDatos()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtTipoEntidad_Leave(sender As Object, e As EventArgs) Handles txtTipoEntidad.Leave
        Try
            If txtTipoEntidad.ValordelControl <> "" Then
                txtEntidad.ConsultaSQL = String.Format("SELECT EN.Sec AS Codigo, EN.NombreEntidad AS Descripcion FROM  EntesSSAP EN WHERE EN.Estado='A' AND TipoEnte ={0}",
                                                       txtTipoEntidad.ValordelControl)
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "txtTipoEntidad_Leave")
        End Try
    End Sub


    Private Sub rgbEmpRetiradoEntidad_Enter(sender As Object, e As EventArgs) Handles rgbEmpRetiradoEntidad.Enter
        HDevExpre.EntraControlRadioGroup(rgbEmpRetiradoEntidad, lblEmpRetiradoEntidad, rgbEmpRetiradoEntidad.Font.Size, lblEmpRetiradoEntidad.Font.Size)
        FrmPrincipal.MensajeDeAyuda.Caption = "Selecione si retira al empleado de la entidad a la cual esta afiliado. (ENTER,ABJ)=Avanzar;"
    End Sub
    Private Sub rgbEmpRetiradoEntidad_Leave(sender As Object, e As EventArgs) Handles rgbEmpRetiradoEntidad.Leave
        HDevExpre.SaleControlRadioGroup(rgbEmpRetiradoEntidad, lblEmpRetiradoEntidad, rgbEmpRetiradoEntidad.Font.Size, lblEmpRetiradoEntidad.Font.Size)
        FrmPrincipal.MensajeDeAyuda.Caption = ""
    End Sub

    Private Sub rgbEmpRetiradoEntidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rgbEmpRetiradoEntidad.KeyPress
        HDevExpre.AvanzaConEnter(e)
    End Sub
End Class
