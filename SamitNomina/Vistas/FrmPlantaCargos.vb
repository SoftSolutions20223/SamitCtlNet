﻿Imports Newtonsoft.Json.Linq
Imports SamitCtlNet
Imports SamitNominaLogic

Public Class FrmPlantaCargos
    Dim estaActualizando As Boolean = False
    Dim Datos As New SamitCtlNet.SamitCtlNet
    Dim secReg As Integer = 0
    Dim HDevExpre As New HelperDevExpress
    Dim HNomina As New HelperNomina
    Dim PlantaCargo As New PlantadeCargos
    Private Sub FrmPlantaCargos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnGuardar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Guardar)
        btnEliminar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Eliminar)
        btnSalir.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.SalirCuadroConX)
        btnLimpiar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Limpiar)
        txtOficina.DatosDefecto = ObjetosNomina.Oficinas
        txtCargos.ConsultaSQL = String.Format("SELECT Sec AS Codigo,Denominacion As Descripcion FROM cargos")
        CreaGrilla()
        LlenaGrilla()
        txtOficina.Focus()
    End Sub

    'CARGAR P´LANTA DE CARGOS
    'ELIMINAR

#Region "Funciones y procedimientos"
    Private Sub CreaGrilla()
        Try
            gvPlantaCargos.Columns.Clear()
            HDevExpre.CreaColumnasG(gvPlantaCargos, "Sec", "Sec", False, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 0, 0)
            HDevExpre.CreaColumnasG(gvPlantaCargos, "IdCargo", "IdCargo", False, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 0, 0)
            HDevExpre.CreaColumnasG(gvPlantaCargos, "IdOficina", "IdOficina", False, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 0, 0)
            HDevExpre.CreaColumnasG(gvPlantaCargos, "NomOficina", "Oficina", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 80, gcPlantaCargos.Width)
            HDevExpre.CreaColumnasG(gvPlantaCargos, "nomCargo", "Cargo", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 20, gcPlantaCargos.Width)
            HDevExpre.CreaColumnasG(gvPlantaCargos, "NumCargos", "Cantidad", True, False, "", Color.FromArgb(&HCC, &HFF, &HCC), False, False, 20, gcPlantaCargos.Width)
            gvPlantaCargos.Appearance.HeaderPanel.Font = New Font("Trebuchet MS", 11.0!, FontStyle.Bold)
            gvPlantaCargos.Columns(gvPlantaCargos.Columns.Count - 1).Summary.Add(DevExpress.Data.SummaryItemType.Count, "", "{0}  Registros")
            gvPlantaCargos.OptionsView.ShowFooter = True
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "CreaGrilla")
        End Try
    End Sub

    Private Sub gvPlantaCargos_DoubleClick(sender As Object, e As EventArgs) Handles gvPlantaCargos.DoubleClick
        Try
            Dim fila As String = HDevExpre.ValidaDobleClicSobreFila(gvPlantaCargos)
            If fila <> "" Then
                CargarDatos(CInt(fila))
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LlenaGrilla()
        Try
            Dim sql As String = "SELECT PC.Sec, PC.Oficina AS IdOficina, PC.Cargo AS IdCargo,  CG.Denominacion AS nomCargo, PC.NumCargos FROM PlantadeCargos PC INNER JOIN cargos CG ON PC.Cargo = CG.Sec "
            Dim dt As DataTable = SMT_AbrirTabla(ObjetoApiNomina, sql)
            dt.Columns.Add("NomOficina", GetType(String))
            If dt.Rows.Count > 0 Then
                For Each fila As DataRow In dt.Rows
                    For Each filaOfi As DataRow In ObjetosNomina.Oficinas.Rows
                        If fila("IdOficina").ToString() = filaOfi("Codigo").ToString() Then
                            fila("NomOficina") = filaOfi("Descripcion")
                        End If
                    Next
                Next
            End If
            gcPlantaCargos.DataSource = dt
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "LlenaGrilla")
        End Try
    End Sub

    Private Function GuardaRegistro(Sec As Integer, Oficina As Integer, Cargo As Integer, NumCargos As Integer) As Boolean
        Try
            PlantaCargo = New PlantadeCargos
            PlantaCargo.Oficina = Oficina
            PlantaCargo.Sec = Sec
            PlantaCargo.Cargo = Cargo
            PlantaCargo.NumCargos = NumCargos
            Dim RegPlantaCargo As New ServicePlantaCargos
            Dim registro As DynamicUpsertResponseDto
            If RegPlantaCargo.ValidarCampos(PlantaCargo) Then
                registro = RegPlantaCargo.UpsertPlantaCargos(PlantaCargo)
            End If
            If registro.ErrorCount < 1 Then
                Return True
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "GuardaRegistro")
            Return False
        End Try
    End Function

    Private Sub LimpiarCampos()
        Try
            txtOficina.ValordelControl = ""
            txtCargos.ValordelControl = ""
            secReg = 0
            ndCantidad.EditValue = 0
            estaActualizando = False
            txtOficina.Focus()
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "LimpiarCampos")
        End Try
    End Sub

    Private Sub CargarDatos(numFila As Integer)
        Try
            If numFila < 0 Then Exit Sub
            secReg = CInt(gvPlantaCargos.GetDataRow(numFila)("Sec").ToString())
            txtOficina.ValordelControl = gvPlantaCargos.GetDataRow(numFila)("IdOficina").ToString
            txtCargos.ValordelControl = gvPlantaCargos.GetDataRow(numFila)("IdCargo").ToString
            ndCantidad.EditValue = CInt(gvPlantaCargos.GetDataRow(numFila)("NumCargos"))
            estaActualizando = True
            txtOficina.Focus()
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "CargarDatos")
        End Try
    End Sub
    Private Sub EliminaRegisto(Ofinina As Integer, Cargo As Integer)
        Try
            If Not estaActualizando Or secReg = 0 Then
                HDevExpre.MensagedeError("No ha cargado ninguna entidad para ser eliminada.")
                Exit Sub
            End If
            If HDevExpre.MsgSamit("Seguro que desea eliminar el registro seleccionado?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.OK Then
                PlantaCargo = New PlantadeCargos
                PlantaCargo.Sec = secReg

                Dim RegPlantaCargo As New ServicePlantaCargos
                Dim registro As JArray
                registro = RegPlantaCargo.EliminarPlantaCargos(PlantaCargo)
                LlenaGrilla()
                LimpiarCampos()
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "EliminaRegisto")
        End Try
    End Sub

    Private Function ValidaCampos() As Boolean
        Try
            If txtOficina.ValordelControl = "" Then
                HDevExpre.MensagedeError("Debe seleccionar la oficina!")
                txtOficina.Focus()
                Return False
            ElseIf txtCargos.ValordelControl = "" Then
                HDevExpre.MensagedeError("Debe seleccionar el cargo!")
                txtCargos.Focus()
                Return False
            ElseIf CInt(ndCantidad.EditValue) = 0 Then
                HDevExpre.MensagedeError("Debe digitar la cantidad de cargos y debe ser mayor que 0!")
                ndCantidad.Focus()
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "ValidaCampos")
            Return False
        End Try
    End Function
#End Region

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If ValidaCampos() Then
            Dim sec As Integer = 0
            If estaActualizando Then sec = secReg
            If GuardaRegistro(sec, CInt(txtOficina.ValordelControl), CInt(txtCargos.ValordelControl), CInt(ndCantidad.EditValue)) Then
                If estaActualizando Then
                    HDevExpre.mensajeExitoso("Información actualizada correctamente.")
                Else : HDevExpre.mensajeExitoso("Información insertada correctamente.")
                End If
                LlenaGrilla()
                LimpiarCampos()
            End If
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarCampos()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub ndCantidad_Enter(sender As Object, e As EventArgs) Handles ndCantidad.Enter
        HDevExpre.EntraControNumericDownDEV(ndCantidad, lblCantidad)
    End Sub

    Private Sub ndCantidad_Leave(sender As Object, e As EventArgs) Handles ndCantidad.Leave
        HDevExpre.SaleControlNumercDownDEV(ndCantidad, lblCantidad)
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

    End Sub
End Class