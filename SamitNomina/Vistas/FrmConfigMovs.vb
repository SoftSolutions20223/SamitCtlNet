Imports DevExpress.XtraEditors.Controls
Imports SamitCtlNet
Imports SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL
Imports SamitCtlNet.SamitCtlNet
Public Class FrmConfigMovs
    Public SecPerfil As String
    Public TipoConcepto As String
    Public Datos As New SamitCtlNet.SamitCtlNet

    Private Sub AcomodaForm()
        ckeEmpleado.Checked = False
        ckeEntidad.Checked = False
        ckeSegSocial.Checked = False
        ckePrestSociales.Checked = False
        ckeAporParafiscales.Checked = False
        ckeNomina.Checked = False
        Dim dt As DataTable = SMT_AbrirTabla(ObjetoApiNomina, "Select * from PerfilesCta where Sec=" + SecPerfil)

        Dim fila As DataRow = dt.Rows(0)
        If TipoConcepto = "Ingresos" Then
            If fila("MovsTercerosIngresos") Then
                ckeEmpleado.Checked = True
            End If

            If fila("MovsEntidadesIngresos") Then
                ckeEntidad.Checked = True
                If fila("MovsEntSeguridadSIngresos") Then
                    ckeSegSocial.Checked = True
                End If

                If fila("MovsEntPrestSIngresos") Then
                    ckePrestSociales.Checked = True
                End If

                If fila("MovsEntAportesParaIngresos") Then
                    ckeAporParafiscales.Checked = True
                End If

                If fila("MovsEntNominaIngresos") Then
                    ckeNomina.Checked = True
                End If
            End If
        End If

        If TipoConcepto = "Deducciones" Then
            If fila("MovsTercerosDeducciones") Then
                ckeEmpleado.Checked = True
            End If

            If fila("MovsEntidadesDeducciones") Then
                ckeEntidad.Checked = True
                If fila("MovsEntSeguridadSDeducciones") Then
                    ckeSegSocial.Checked = True
                End If

                If fila("MovsEntPrestSDeducciones") Then
                    ckePrestSociales.Checked = True
                End If

                If fila("MovsEntAportesParaDeducciones") Then
                    ckeAporParafiscales.Checked = True
                End If

                If fila("MovsEntNominaDeducciones") Then
                    ckeNomina.Checked = True
                End If
            End If
        End If

        If TipoConcepto = "Provisiones" Then
            If fila("MovsTercerosProvisiones") Then
                ckeEmpleado.Checked = True
            End If

            If fila("MovsEntidadesProvisiones") Then
                ckeEntidad.Checked = True
                If fila("MovsEntSeguridadSProvisiones") Then
                    ckeSegSocial.Checked = True
                End If

                If fila("MovsEntPrestSProvisiones") Then
                    ckePrestSociales.Checked = True
                End If

                If fila("MovsEntAportesParaProvisiones") Then
                    ckeAporParafiscales.Checked = True
                End If

                If fila("MovsEntNominaProvisiones") Then
                    ckeNomina.Checked = True
                End If
            End If
        End If

    End Sub

    Private Sub cke_Enter(sender As Object, e As EventArgs) Handles ckeEmpleado.Enter, ckeEntidad.Enter, ckeSegSocial.Enter, ckePrestSociales.Enter, ckeAporParafiscales.Enter, ckeNomina.Enter
        Try
            Dim ck As DevExpress.XtraEditors.CheckEdit = CType(sender, DevExpress.XtraEditors.CheckEdit)
            ck.Font = New Font(ck.Font.FontFamily, ck.Font.Size, FontStyle.Bold)
            ck.BorderStyle = BorderStyles.HotFlat
            ck.BackColor = Datos.ColordeFondoTxtFoco
            FrmPrincipal.MensajeDeAyuda.Caption = "A que desea redondear el valor de este concepto?. (ENTER)=Avanzar;(ESC,ARB)=Atras"
            FrmPrincipal.MensajeDeAyuda.Refresh()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cke_Leave(sender As Object, e As EventArgs) Handles ckeEmpleado.Leave, ckeEntidad.Leave, ckeSegSocial.Leave, ckePrestSociales.Leave, ckeAporParafiscales.Leave, ckeNomina.Leave
        Try
            Dim ck As DevExpress.XtraEditors.CheckEdit = CType(sender, DevExpress.XtraEditors.CheckEdit)
            ck.Font = New Font(ck.Font.FontFamily, ck.Font.Size, FontStyle.Regular)
            ck.BorderStyle = BorderStyles.Default
            ck.BackColor = Color.Transparent
            FrmPrincipal.MensajeDeAyuda.Caption = ""
            FrmPrincipal.MensajeDeAyuda.Refresh()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LimpiarCampos()

        ckeEntidad.Checked = False
        ckeEmpleado.Checked = True
        SecPerfil = ""
        TipoConcepto = ""
        Me.Close()
    End Sub

    Private Sub ckeEmpleado_CheckedChanged(sender As Object, e As EventArgs) Handles ckeEmpleado.CheckedChanged
        If ckeEmpleado.Checked Then
            ckeEntidad.Checked = False
            ckeSegSocial.Checked = False
            ckePrestSociales.Checked = False
            ckeAporParafiscales.Checked = False
            ckeNomina.Checked = False


            ckeSegSocial.Enabled = False
            ckePrestSociales.Enabled = False
            ckeAporParafiscales.Enabled = False
            ckeNomina.Enabled = False
        Else
            ckeEntidad.Checked = True
        End If
    End Sub

    Private Sub FrmConfigMovs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AcomodaForm()
    End Sub

    Private Sub ckeEntidad_CheckedChanged(sender As Object, e As EventArgs) Handles ckeEntidad.CheckedChanged
        If ckeEntidad.Checked Then
            ckeEmpleado.Checked = False
            ckeSegSocial.Enabled = True
            ckePrestSociales.Enabled = True
            ckeAporParafiscales.Enabled = True
            ckeNomina.Enabled = True
        Else
            ckeEmpleado.Checked = True
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        LimpiarCampos()
    End Sub

    Private Sub ckeEmpleado_Click(sender As Object, e As EventArgs) Handles ckeEmpleado.Click
        'If Not ckeEmpleado.Checked Then
        '    ckeEntidad.Checked = True
        'End If
    End Sub

    Private Sub ckeEntidad_Click(sender As Object, e As EventArgs) Handles ckeEntidad.Click
        'If Not ckeEntidad.Checked Then
        '    ckeEmpleado.Checked = True
        'End If
    End Sub

    Private Function GuardaDatosPerfiles() As Boolean

        If ckeEntidad.Checked Then
            If ckeSegSocial.Checked = False And ckePrestSociales.Checked = False And ckeAporParafiscales.Checked = False And ckeNomina.Checked = False Then
                MsgBox("Tiene que seleccionar al menos una clasificacion de conceptos!")
                Return False
            End If
        End If
        Dim GenSql_tabPlantillas As New ClGeneraSqlDLL
        GenSql_tabPlantillas.PasoConexionTabla(ObjetoApiNomina, "PerfilesCta")

        If TipoConcepto = "Ingresos" Then
            GenSql_tabPlantillas.PasoValores("MovsTercerosIngresos", IIf(ckeEmpleado.Checked = True, "1", "0"), TipoDatoActualizaSQL.Cadena)
            GenSql_tabPlantillas.PasoValores("MovsEntidadesIngresos", IIf(ckeEntidad.Checked = True, "1", "0"), TipoDatoActualizaSQL.Cadena)
            GenSql_tabPlantillas.PasoValores("MovsEntSeguridadSIngresos", IIf(ckeSegSocial.Checked = True, "1", "0"), TipoDatoActualizaSQL.Cadena)
            GenSql_tabPlantillas.PasoValores("MovsEntPrestSIngresos", IIf(ckePrestSociales.Checked = True, "1", "0"), TipoDatoActualizaSQL.Cadena)
            GenSql_tabPlantillas.PasoValores("MovsEntAportesParaIngresos", IIf(ckeAporParafiscales.Checked = True, "1", "0"), TipoDatoActualizaSQL.Cadena)
            GenSql_tabPlantillas.PasoValores("MovsEntNominaIngresos", IIf(ckeNomina.Checked = True, "1", "0"), TipoDatoActualizaSQL.Cadena)
        ElseIf TipoConcepto = "Provisiones" Then
            GenSql_tabPlantillas.PasoValores("MovsTercerosProvisiones", IIf(ckeEmpleado.Checked = True, "1", "0"), TipoDatoActualizaSQL.Cadena)
            GenSql_tabPlantillas.PasoValores("MovsEntidadesProvisiones", IIf(ckeEntidad.Checked = True, "1", "0"), TipoDatoActualizaSQL.Cadena)
            GenSql_tabPlantillas.PasoValores("MovsEntSeguridadSProvisiones", IIf(ckeSegSocial.Checked = True, "1", "0"), TipoDatoActualizaSQL.Cadena)
            GenSql_tabPlantillas.PasoValores("MovsEntPrestSProvisiones", IIf(ckePrestSociales.Checked = True, "1", "0"), TipoDatoActualizaSQL.Cadena)
            GenSql_tabPlantillas.PasoValores("MovsEntAportesParaProvisiones", IIf(ckeAporParafiscales.Checked = True, "1", "0"), TipoDatoActualizaSQL.Cadena)
            GenSql_tabPlantillas.PasoValores("MovsEntNominaProvisiones", IIf(ckeNomina.Checked = True, "1", "0"), TipoDatoActualizaSQL.Cadena)
        ElseIf TipoConcepto = "Deducciones" Then
            GenSql_tabPlantillas.PasoValores("MovsTercerosDeducciones", IIf(ckeEmpleado.Checked = True, "1", "0"), TipoDatoActualizaSQL.Cadena)
            GenSql_tabPlantillas.PasoValores("MovsEntidadesDeducciones", IIf(ckeEntidad.Checked = True, "1", "0"), TipoDatoActualizaSQL.Cadena)
            GenSql_tabPlantillas.PasoValores("MovsEntSeguridadSDeducciones", IIf(ckeSegSocial.Checked = True, "1", "0"), TipoDatoActualizaSQL.Cadena)
            GenSql_tabPlantillas.PasoValores("MovsEntPrestSDeducciones", IIf(ckePrestSociales.Checked = True, "1", "0"), TipoDatoActualizaSQL.Cadena)
            GenSql_tabPlantillas.PasoValores("MovsEntAportesParaDeducciones", IIf(ckeAporParafiscales.Checked = True, "1", "0"), TipoDatoActualizaSQL.Cadena)
            GenSql_tabPlantillas.PasoValores("MovsEntNominaDeducciones", IIf(ckeNomina.Checked = True, "1", "0"), TipoDatoActualizaSQL.Cadena)
        End If
        If GenSql_tabPlantillas.EjecutarComandoNET(SQLGenera.Actualizacion, String.Format("Sec='{0}'", SecPerfil)) Then
            Return True
        Else : Return False
        End If
    End Function

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If GuardaDatosPerfiles() Then
            MsgBox("Datos guardados correctamente!")
            LimpiarCampos()
        Else
            MsgBox("No se han podido guardar los datos!")
        End If

    End Sub
End Class