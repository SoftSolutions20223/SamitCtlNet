Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns
Imports SamitCtlNet
Imports DevExpress.XtraEditors.Controls
Imports System.Transactions
Imports DevExpress.XtraGrid
Imports DevExpress.XtraEditors
Imports DevExpress.XtraVerticalGrid
Imports DevExpress.XtraVerticalGrid.Rows
Imports System.Data.SqlClient
Imports SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL
Imports SamitNominaWebService

Public Class FrmAggNovedades

    Public Datos As New SamitCtlNet.SamitCtlNet
    Dim ActualizaNovedades As Boolean = False
    Dim SecPeriodo As String
    Dim FormularioAbierto As Boolean = False
    Dim SecNominaLiquida As String = ""
    Dim secReg As Integer = 0
    Dim ColumnasVP As New DataTable
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

    Private Sub AcomodaForm()
        Try
            btnBuscar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Buscar)
            btnBorradores.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Editar)
            btnGuardar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Guardar)
            btnLimpiar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Limpiar)
            btnSalir.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.SalirCuadroConX)
            btnEliminarBorrador.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.EliminarGris)
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, " AcomodaForm Contrato")
        End Try
    End Sub

    Private Sub AsignaScriptAcontroles()
        Try

            txtDependencia.ConsultaSQL = String.Format("SELECT Sec AS Codigo,NomDependencia As Descripcion FROM  Dependencias where Vigente = 1")

            txtCargos.ConsultaSQL = String.Format("SELECT SecCargo AS Codigo,Denominacion As Descripcion FROM  cargos")

            Dim Empresa As Integer = Datos.Seguridad.DatosDeLaEmpresa.NumEmpresa
            txtOficina.ConsultaSQL = String.Format("SELECT NumOficina AS Codigo,NomOficina As Descripcion FROM SEGURIDAD..Oficinas WHERE Estado='V' AND NumEmpresa={0}", Empresa.ToString)

            Dim Sql As String = "select NomVariable as Nombre,ValorMaximo as ValorMaximo,Sec as Sec from VariablesPersonales"
            ColumnasVP = SMT_AbrirTabla(ObjetoApiNomina, Sql)

        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "AsignaScriptAcontroles")
        End Try
    End Sub

    Private Sub AbreBusqueda()
        Dim sql As String = "Select NL.Sec As Codigo,N.NomNomina +'   '+P.Descripcion As Descripcion From NominaLiquida NL INNER JOIN PeriodosLiquidacion P ON NL.Periodo = P.Sec " &
                           " INNER JOIN Nominas N ON P.Nomina = N.SecNomina Where NL.EsBorrador = 1 "
        Dim frm As New FrmBusqueda(sql, "Borradores", , , "Codigo", "Descripcion", "Novedades")
        Dim classResize As New ClaseResize
        If frm.P_FormularioAbierto Then
            frm.ShowDialog()
            frm.BringToFront()
        Else
            frm.P_FormularioAbierto = True
            classResize.Resizamodales(frm, 55, 70)
            classResize.ResizeForm(frm)
            frm.ShowDialog()
            frm.BringToFront()
        End If
        If gvNovedades.RowCount > 0 Then
            gcNovedades.Focus()
        End If
    End Sub

    Private Sub CreaColumnas(Grid As GridView, Nombre As String, Titulo As String, Visible As Boolean, Editar As Boolean, formula As String, colores As System.Drawing.Color, numerico As Boolean, Porcentaje_Width As Single, TamañoPadre As Single)
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
    End Sub


    Public Sub LimpiarTodosCampos()
        'Limpia todos los campos de texto
        txtDependencia.ValordelControl = ""
        txtOficina.ValordelControl = ""
        txtNominas.ValordelControl = ""
        txtCargos.ValordelControl = ""
        txtPeriodos.ValordelControl = ""
        'Limpia todas las grillas
        gcNovedades.DataSource = Nothing

        Creagrillahorizontal()
        txtOficina.Focus()
    End Sub
    Private Sub ConsultaDatos()
        If txtOficina.ValordelControl <> "" And txtOficina.DescripciondelControl <> "No Se Encontraron Registros" And txtOficina.DescripciondelControl <> "" And txtNominas.ValordelControl <> "" And txtNominas.DescripciondelControl <> "No Se Encontraron Registros" And txtNominas.DescripciondelControl <> "" And txtPeriodos.ValordelControl <> "" And txtPeriodos.DescripciondelControl <> "No Se Encontraron Registros" And txtPeriodos.DescripciondelControl <> "" And txtAño.ValordelControl <> "" Then
            Try
                Dim consulta As DataTable = CType(gcNovedades.DataSource, DataTable)
                consulta.Rows.Clear()
                Dim sql As String = " Select E.Identificacion as IdentificacionEmple, RTRIM(LTRIM(RTRIM(LTRIM(E.PNombre)) + ' ' + " +
                " RTRIM(LTRIM(E.SNombre)) + ' ' +  RTRIM(LTRIM(E.PApellido)) + ' ' + RTRIM(LTRIM(E.SApellido)))) As NomEmple," +
                " C.CodContrato as CodContrato, C.IdContrato as IdContrato,CC.Cargo as Cargo,V.NomVariable as Variable,NLV.Cantidad as Cantidad,CA.Denominacion AS NomCargo,NLC.Sec as NominaLiquidaContrato,C.HorasMes as HorasMes,C.Asignacion as Asignacion,C.CargoActual as CargoActual,NL.Sec as NominaLiquida From NominaLiquidaVariables NLV  " +
                " INNER JOIN NominaLiquidaContratos NLC ON NLV.SecLiquidaContrato = NLC.Sec INNER JOIN VariablesPersonales V ON NLV.Variable = V.Sec " +
                " INNER JOIN Contratos C ON NLC.Contrato = C.CodContrato INNER JOIN Empleados E ON C.Empleado = E.IdEmpleado " +
                " INNER JOIN Contrato_Cargos CC ON C.CargoActual = CC.SecCargos INNER JOIN Cargos CA ON CC.Cargo = CA.SecCargo  INNER JOIN NominaLiquida NL ON NLC.NominaLiquida= NL.Sec WHERE NL.Periodo=" + SecPeriodo

                If txtOficina.ValordelControl <> "" And txtOficina.DescripciondelControl <> "No Se Encontraron Registros" And txtOficina.DescripciondelControl <> "" Or txtNominas.ValordelControl <> "" And txtNominas.DescripciondelControl <> "No Se Encontraron Registros" And txtNominas.DescripciondelControl <> "" Or txtDependencia.ValordelControl <> "" And txtDependencia.DescripciondelControl <> "No Se Encontraron Registros" And txtDependencia.DescripciondelControl <> "" Or txtCargos.ValordelControl <> "" And txtCargos.DescripciondelControl <> "No Se Encontraron Registros" And txtCargos.DescripciondelControl <> "" Then

                    If txtDependencia.ValordelControl <> "" And txtDependencia.DescripciondelControl <> "No Se Encontraron Registros" And txtDependencia.DescripciondelControl <> "" Then
                        sql = sql + " And C.Dependencia=" + txtDependencia.ValordelControl
                    End If

                    If txtCargos.ValordelControl <> "" And txtCargos.DescripciondelControl <> "No Se Encontraron Registros" And txtCargos.DescripciondelControl <> "" Then
                        sql = sql + " And CC.Cargo=" + txtCargos.ValordelControl
                    End If
                End If
                SecNominaLiquida = SMT_AbrirTabla(ObjetoApiNomina, "SELECT Sec AS Codigo FROM NominaLiquida Where Periodo =" + SecPeriodo).Rows(0)(0).ToString
                Dim dt As DataTable = SMT_AbrirTabla(ObjetoApiNomina, sql)
                Dim NumEmp As Integer = 0
                If dt.Rows.Count > 0 Then
                    For incre As Integer = 0 To dt.Rows.Count - 1
                        If incre = 0 Then
                            Dim fila As DataRow = consulta.NewRow()
                            fila("CodContrato") = dt.Rows(incre)("CodContrato").ToString
                            fila("IdContrato") = dt.Rows(incre)("IdContrato").ToString
                            fila("IdentificacionEmple") = dt.Rows(incre)("IdentificacionEmple").ToString
                            fila("NomEmple") = dt.Rows(incre)("NomEmple").ToString
                            fila("NominaLiquidaContrato") = dt.Rows(incre)("NominaLiquidaContrato").ToString
                            fila("NomNomina") = txtNominas.DescripciondelControl
                            fila("HorasMes") = dt.Rows(incre)("HorasMes").ToString
                            fila("Asignacion") = dt.Rows(incre)("Asignacion").ToString
                            fila("CargoActual") = dt.Rows(incre)("CargoActual").ToString
                            consulta.Rows.Add(fila)
                            consulta.AcceptChanges()
                            Dim cantidad As String = dt.Rows(incre)("Cantidad").ToString
                            If cantidad = "" Then
                                consulta.Rows(incre)(dt.Rows(incre)("Variable").ToString) = "0"
                            Else
                                consulta.Rows(incre)(dt.Rows(incre)("Variable").ToString) = dt.Rows(incre)("Cantidad").ToString
                            End If


                        ElseIf dt.Rows(incre)("CodContrato").ToString <> dt.Rows(incre - 1)("CodContrato").ToString Then
                            Dim fila As DataRow = consulta.NewRow()
                            fila("CodContrato") = dt.Rows(incre)("CodContrato").ToString
                            fila("IdContrato") = dt.Rows(incre)("IdContrato").ToString
                            fila("IdentificacionEmple") = dt.Rows(incre)("IdentificacionEmple").ToString
                            fila("NomEmple") = dt.Rows(incre)("NomEmple").ToString
                            fila("NominaLiquidaContrato") = dt.Rows(incre)("NominaLiquidaContrato").ToString
                            fila("NomNomina") = txtNominas.DescripciondelControl
                            fila("HorasMes") = dt.Rows(incre)("HorasMes").ToString
                            fila("Asignacion") = dt.Rows(incre)("Asignacion").ToString
                            fila("CargoActual") = dt.Rows(incre)("CargoActual").ToString
                            consulta.Rows.Add(fila)
                            consulta.AcceptChanges()
                            NumEmp = NumEmp + 1
                            Dim cantidad As String = dt.Rows(incre)("Cantidad").ToString
                            If cantidad = "" Then
                                consulta.Rows(NumEmp)(dt.Rows(incre)("Variable").ToString) = "0"
                            Else
                                consulta.Rows(NumEmp)(dt.Rows(incre)("Variable").ToString) = dt.Rows(incre)("Cantidad").ToString
                            End If


                        ElseIf dt.Rows(incre)("CodContrato").ToString = dt.Rows(incre - 1)("CodContrato").ToString Then
                            Dim cantidad As String = dt.Rows(incre)("Cantidad").ToString
                            If cantidad = "" Then
                                consulta.Rows(NumEmp)(dt.Rows(incre)("Variable").ToString) = "0"
                            Else
                                consulta.Rows(NumEmp)(dt.Rows(incre)("Variable").ToString) = dt.Rows(incre)("Cantidad").ToString
                            End If
                            gcNovedades.DataSource = consulta
                        End If
                    Next

                    gcNovedades.DataSource = consulta
                    gcNovedades.Focus()
                Else
                    consulta.Rows.Clear()
                    gcNovedades.DataSource = consulta
                End If
            Catch ex As Exception
            End Try
        Else
            Dim consulta As DataTable = CType(gcNovedades.DataSource, DataTable)
            consulta.Rows.Clear()
            gcNovedades.DataSource = consulta
            SecNominaLiquida = ""
        End If
    End Sub
    Private Sub Creagrillahorizontal()
        gvNovedades.Columns.Clear()
        Dim sql As String = ""
        Dim filas As New DataTable
        Dim NuevaFila As DataRow = filas.NewRow()
        Dim dt As DataTable = SMT_AbrirTabla(ObjetoApiNomina, sql)
        Dim coloor As System.Drawing.Color = Color.FromArgb(&HCC, &HFF, &HCC)
        CreaColumnas(gvNovedades, "NomNomina", "Nomina", True, False, "", coloor, False, 3, gcNovedades.Width)
        dt.Columns.Add("NomNomina", GetType(String))
        CreaColumnas(gvNovedades, "IdContrato", "Contrato", True, False, "", coloor, False, 3, gcNovedades.Width)
        dt.Columns.Add("IdContrato", GetType(String))
        CreaColumnas(gvNovedades, "CodContrato", "Contrato", False, False, "", coloor, False, 3, gcNovedades.Width)
        dt.Columns.Add("CodContrato", GetType(String))
        CreaColumnas(gvNovedades, "IdentificacionEmple", "Identificación Empleado", True, False, "", coloor, False, 4, gcNovedades.Width)
        dt.Columns.Add("IdentificacionEmple", GetType(String))
        CreaColumnas(gvNovedades, "NomEmple", "Nombre Empleado", True, False, "", coloor, False, 5, gcNovedades.Width)
        dt.Columns.Add("NomEmple", GetType(String))
        dt.Columns.Add("NominaLiquidaContrato", GetType(String))
        dt.Columns.Add("HorasMes", GetType(Decimal))
        dt.Columns.Add("Asignacion", GetType(Decimal))
        dt.Columns.Add("CargoActual", GetType(String))
        If ColumnasVP.Rows.Count > 0 Then
            For incre As Integer = 0 To ColumnasVP.Rows.Count - 1
                Dim sasf As System.Drawing.Color = Color.FromArgb(&HFF, &HE3, &HDB)
                dt.Columns.Add(ColumnasVP.Rows(incre)("Nombre").ToString, GetType(Decimal))
                CreaColumnas(gvNovedades, ColumnasVP.Rows(incre)("Nombre").ToString, ColumnasVP.Rows(incre)("Nombre").ToString, True, True, "", sasf, True, 0, gcNovedades.Width)
                For I As Integer = 0 To dt.Columns.Count - 1
                    If dt.Columns(I).ColumnName.ToString = ColumnasVP.Rows(incre)("Nombre").ToString Then
                    End If
                Next
            Next
        End If

        Try
            gcNovedades.DataSource = dt
        Catch ex As Exception
            Dim asfds As String = ex.Data.ToString
        End Try
    End Sub
    Private Sub AsignaMsgAcontroles()
        Try
            txtAño.MensajedeAyuda = "Digite el año sobre el cual desea trabajar la nómina. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
            txtOficina.MensajedeAyuda = "Seleccione la oficina sobre la cual desea trabajar.(ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras, (F5,DER)=Buscar"
            txtNominas.MensajedeAyuda = "Seleccion el nómina sobre la cual desea trabajar. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras, (F5,DER)=Buscar"
            txtPeriodos.MensajedeAyuda = "Seleccione el periodo sobre el cual desea trabajar. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras, (F5,DER)=Buscar"
            txtDependencia.MensajedeAyuda = "Seleccione la dependencia o area sobre la cual desea trabajar. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras, (F5,DER)=Buscar"
            txtCargos.MensajedeAyuda = "Seleccione el cargo sobre el cual desea trabajar.  (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras, (F5,DER)=Buscar"
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "AsignaMsgAcontroles")
        End Try
    End Sub

    Private Sub FrmAggNovedades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtAño.ValordelControl = Year(Traer_FechaDelServidor()).ToString
        AsignaScriptAcontroles()
        AcomodaForm()
        Creagrillahorizontal()
        Dim classResize As New ClaseResize
        classResize.Resizagrid(gvNovedades)
        txtOficina.Select()
        AsignaMsgAcontroles()
    End Sub


    Public Sub txtAño_Leave(sender As Object, e As EventArgs) Handles txtAño.Leave
        Dim valor As String = txtPeriodos.ValordelControl
        txtPeriodos.ValordelControl = ""
        txtPeriodos.ConsultaSQL = String.Format("SELECT CodPeriodo AS Codigo,Descripcion As Descripcion FROM  PeriodosLiquidacion where año ='{1}' And Nomina='{2}' And Estado<>'L'", txtAño.ValordelControl, txtNominas.ValordelControl)
        txtPeriodos.RefrescarDatos()
        txtPeriodos.ValordelControl = valor

        Dim valortxtaño As String = txtAño.ValordelControl
        txtPeriodos.ValordelControl = ""
        If valortxtaño.Length < 4 Then
            txtAño.Focus()
        End If
    End Sub



    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarTodosCampos()
    End Sub
    Public Function GuardaNominaLiquida() As Boolean
        Dim GenSql As New SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL
        GenSql.PasoConexionTabla(ObjetoApiNomina, "NominaLiquida")
        GenSql.PasoValores("Periodo", SecPeriodo, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
        GenSql.PasoValores("OfiNomina", txtOficina.ValordelControl, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
        GenSql.PasoValores("EsBorrador", "1", SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
        GenSql.PasoValores("OfiRegistra", Datos.Seguridad.DatosDeLaEmpresa.NumEmpresa.ToString, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
        GenSql.PasoValores("UsuCrea", Datos.Smt_Usuario, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
        GenSql.PasoValores("FechaCrea", Datos.Smt_FechaDelServidor.ToString("dd/MM/yyyy hh:MM:ss"), SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
        GenSql.PasoValores("TerminalCrea", Datos.Smt_Usuario, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
        GenSql.PasoValores("FechaSys", Datos.Smt_FechaDelServidor.ToString("dd/MM/yyyy hh:MM:ss"), SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
        Dim Sec = SMT_AbrirTabla(ObjetoApiNomina, "SELECT ISNULL( MAX (Sec),0)+1 AS Codigo FROM  NominaLiquida").Rows(0)(0).ToString
        GenSql.PasoValores("Sec", Sec, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
        If GenSql.EjecutarComandoNET(SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.SQLGenera.Insercion, "") Then
            Return True
        Else : Return False
        End If
    End Function

    Public Function GuardaNominaLiquidaContratos(Contrato As String, NominaLiquida As String, Total As String, HorasMes As String, CargoActual As String, Asignacion As String) As Boolean
        Dim GenSql As New SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL
        GenSql.PasoConexionTabla(ObjetoApiNomina, "NominaLiquidaContratos")
        GenSql.PasoValores("Contrato", Contrato, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
        GenSql.PasoValores("NominaLiquida", NominaLiquida, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
        GenSql.PasoValores("Total", Total, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
        GenSql.PasoValores("HorasMes", HorasMes, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
        GenSql.PasoValores("CargoActual", CargoActual, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
        GenSql.PasoValores("Asignacion", Asignacion, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
        Dim Sec = SMT_AbrirTabla(ObjetoApiNomina, "SELECT ISNULL( MAX (Sec),0)+1 AS Codigo FROM  NominaLiquidaContratos").Rows(0)(0).ToString
        GenSql.PasoValores("Sec", Sec, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
        If GenSql.EjecutarComandoNET(SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.SQLGenera.Insercion, "") Then
            Return True
        Else : Return False
        End If
    End Function

    Public Function GuardaNominaLiquidaContratos(Contrato As String, NominaLiquida As String, Total As String, HorasMes As String, CargoActual As String, Asignacion As String, TotalProviciones As String, TotalFondos As String, TotalIngresos As String, TotalDeducciones As String) As Boolean
        Dim GenSql As New SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL
        GenSql.PasoConexionTabla(ObjetoApiNomina, "NominaLiquidaContratos")
        GenSql.PasoValores("Contrato", Contrato, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
        GenSql.PasoValores("NominaLiquida", NominaLiquida, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
        GenSql.PasoValores("Total", Total, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
        GenSql.PasoValores("TotalProvisiones", TotalProviciones, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
        GenSql.PasoValores("TotalFondos", TotalFondos, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
        GenSql.PasoValores("TotalIngresos", TotalIngresos, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
        GenSql.PasoValores("TotalDeducciones", TotalDeducciones, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
        GenSql.PasoValores("HorasMes", HorasMes, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
        GenSql.PasoValores("CargoActual", CargoActual, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
        GenSql.PasoValores("Asignacion", Asignacion, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
        Dim Sec = SMT_AbrirTabla(ObjetoApiNomina, "SELECT ISNULL( MAX (Sec),0)+1 AS Codigo FROM  NominaLiquidaContratos").Rows(0)(0).ToString
        GenSql.PasoValores("Sec", Sec, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
        If GenSql.EjecutarComandoNET(SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.SQLGenera.Insercion, "") Then
            Return True
        Else : Return False
        End If
    End Function

    Public Function GuardaNominaLiquidaVariables(LiquidaContrato As String, Cantidad As String, Variable As String) As Boolean
        Dim GenSql As New SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL
        GenSql.PasoConexionTabla(ObjetoApiNomina, "NominaLiquidaVariables")
        GenSql.PasoValores("SecLiquidaContrato", LiquidaContrato, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
        GenSql.PasoValores("Cantidad", Cantidad, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
        GenSql.PasoValores("Variable", Variable, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
        If ActualizaNovedades Then
            If GenSql.EjecutarComandoNET(SQLGenera.Actualizacion, String.Format("SecLiquidaContrato={0} And Variable={1}", LiquidaContrato, Variable)) Then
                Return True
            Else : Return False
            End If
        Else
            Dim Sec = SMT_AbrirTabla(ObjetoApiNomina, "SELECT ISNULL( MAX (Sec),0)+1 AS Codigo FROM  NominaLiquidaVariables").Rows(0)(0).ToString
            GenSql.PasoValores("Sec", Sec, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            If GenSql.EjecutarComandoNET(SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.SQLGenera.Insercion, "") Then
                Return True
            Else : Return False
            End If
        End If
    End Function

    Public Function ValidarCampos() As Boolean
        Dim res As Boolean = False
        Dim Tbla As DataTable = CType(gcNovedades.DataSource, DataTable)
        If txtPeriodos.ValordelControl = "" Then
            HDevExpre.MensagedeError("El campo Periodo no puede estar vacío!..")
            txtPeriodos.Focus()
            res = False
        ElseIf Not Tbla.Rows.Count > 0 Then
            HDevExpre.MensagedeError("No se han encontrado empleados!..")
            txtOficina.Focus()
            res = False
        Else
            res = True

        End If
        Return res
    End Function

    Public Function GuardaNovedades() As Boolean
        Dim res As Boolean = False
        ActualizaNovedades = True
        Dim Tbla As DataTable = CType(gcNovedades.DataSource, DataTable)
        If Tbla.Rows.Count > 0 Then
            For incre As Integer = 0 To Tbla.Rows.Count - 1
                For i As Integer = 0 To ColumnasVP.Rows.Count - 1
                    If ExisteDato("NominaLiquidaVariables", String.Format("SecLiquidaContrato='{0}' And Variable='{1}' ", Tbla.Rows(incre)("NominaLiquidaContrato").ToString, ColumnasVP.Rows(i)("Sec").ToString), ObjetoApiNomina) Then
                        If GuardaNominaLiquidaVariables(Tbla.Rows(incre)("NominaLiquidaContrato").ToString, Tbla.Rows(incre)(ColumnasVP.Rows(i)("Nombre").ToString).ToString, ColumnasVP.Rows(i)("Sec").ToString) Then
                        Else
                            Return False
                        End If
                    Else
                        ActualizaNovedades = False
                        If GuardaNominaLiquidaVariables(Tbla.Rows(incre)("NominaLiquidaContrato").ToString, Tbla.Rows(incre)(ColumnasVP.Rows(i)("Nombre").ToString).ToString, ColumnasVP.Rows(i)("Sec").ToString) Then
                            ActualizaNovedades = True
                        Else
                            Return False
                        End If
                    End If
                Next
            Next
        End If
        ActualizaNovedades = False
        ConsultaDatos()
        Return res
    End Function

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim wait As New ClEspera
        Try
            If ValidarCampos() Then
                wait.Mostrar()
                wait.Descripcion = "Guardando Datos..."
                GuardaNovedades()
                wait.Terminar()
                HDevExpre.mensajeExitoso("Información guardada exitosamente!")
            End If
        Catch ex As Exception
            wait.Terminar()
        End Try
    End Sub

    Private Sub FrmAggNovedades_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        FormularioAbierto = False
    End Sub

    Private Sub btnBorradores_Click(sender As Object, e As EventArgs) Handles btnBorradores.Click
        If ExisteDato("NominaLiquida", String.Format("EsBorrador='{0}'", "1"), ObjetoApiNomina) Then
            AbreBusqueda()
        Else
            HDevExpre.MensagedeError("No se han encontrado Borradores!..")
        End If
    End Sub

    Public Sub txtOficina_Leave(sender As Object, e As EventArgs) Handles txtOficina.Leave
        If txtOficina.ValordelControl <> "" And txtOficina.DescripciondelControl <> "No Se Encontraron Registros" And txtOficina.DescripciondelControl <> "" Then
            txtNominas.ValordelControl = ""
            txtNominas.ConsultaSQL = String.Format("SELECT SecNomina AS Codigo,NomNomina As Descripcion FROM  Nominas Where Oficina=" + txtOficina.ValordelControl)
            txtNominas.RefrescarDatos()

            txtPeriodos.ValordelControl = ""
            txtPeriodos.ConsultaSQL = String.Format("SELECT CodPeriodo AS Codigo,Descripcion As Descripcion FROM  PeriodosLiquidacion where año ='{1}' And Estado<>'L'", "0000")
            txtPeriodos.RefrescarDatos()

        End If
    End Sub

    Public Sub txtNominas_Leave(sender As Object, e As EventArgs) Handles txtNominas.Leave
        If txtNominas.ValordelControl <> "" And txtNominas.DescripciondelControl <> "No Se Encontraron Registros" And txtNominas.DescripciondelControl <> "" Then
            txtPeriodos.ValordelControl = ""
            txtPeriodos.ConsultaSQL = String.Format("SELECT CodPeriodo AS Codigo,Descripcion As Descripcion FROM  PeriodosLiquidacion where año ='{1}' And Nomina='{2}' And Estado<>'L'", txtAño.ValordelControl, txtNominas.ValordelControl)
            txtPeriodos.RefrescarDatos()
        End If
    End Sub

    Public Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If txtPeriodos.ValordelControl = "" Or txtPeriodos.DescripciondelControl = "No Se Encontraron Registros" Or txtPeriodos.DescripciondelControl = "" Then
            HDevExpre.MensagedeError("El campo Periodo no puede estar vacio, ni contener valores invalidos!..")
            SecPeriodo = ""
        Else
            SecPeriodo = SMT_AbrirTabla(ObjetoApiNomina, "SELECT Sec FROM PeriodosLiquidacion where CodPeriodo=" + txtPeriodos.ValordelControl).Rows(0)(0).ToString
            If ExisteDato("PeriodosLiquidacion", String.Format("Sec='{0}' And Estado='L'", SecPeriodo), ObjetoApiNomina) Then
                HDevExpre.MensagedeError("Este periodo ya ha sido liquidado!..")
                Exit Sub
            Else
                Dim Fecha As String = CDate(SMT_AbrirTabla(ObjetoApiNomina, "SELECT FechaInicio FROM PeriodosLiquidacion where sec=" + SecPeriodo).Rows(0)(0).ToString).ToString("dd/MM/yyyy")
                Dim sql As String = "Select * from PeriodosLiquidacion where sec < " + SecPeriodo + " and FechaFin < '" + Fecha + "' and Estado = 'P' And Año = '" + txtAño.ValordelControl + "' And Nomina='" + txtNominas.ValordelControl + "'"
                Dim dt As DataTable = SMT_AbrirTabla(ObjetoApiNomina, sql)
                If dt.Rows.Count > 0 Then
                    HDevExpre.MensagedeError("Hay Periodos anteriores que aún no se han liquidado!..")
                    Exit Sub
                Else
                    If ExisteDato("NominaLiquida", String.Format("Periodo='{0}' And EsBorrador = 1", SecPeriodo), ObjetoApiNomina) And Not ExisteDato("NominaLiquidada", String.Format("Periodo='{0}' And Estado<>'A'", SecPeriodo), ObjetoApiNomina) Then
                        ConsultaDatos()
                        sql = " Select C.Asignacion AS Asignacion,C.CodContrato AS CodContrato,C.HorasMes AS HorasMes,C.CargoActual AS CargoActual, " +
                            " CC.Cargo As Cargo from Contratos C INNER JOIN Contrato_Cargos CC ON C.CargoActual = CC.SecCargos where C.Nomina =" + txtNominas.ValordelControl + " And C.Plantilla <> '' And Terminado=0"

                        If txtOficina.ValordelControl <> "" And txtOficina.DescripciondelControl <> "No Se Encontraron Registros" And txtOficina.DescripciondelControl <> "" Or txtNominas.ValordelControl <> "" And txtNominas.DescripciondelControl <> "No Se Encontraron Registros" And txtNominas.DescripciondelControl <> "" Or txtDependencia.ValordelControl <> "" And txtDependencia.DescripciondelControl <> "No Se Encontraron Registros" And txtDependencia.DescripciondelControl <> "" Or txtCargos.ValordelControl <> "" And txtCargos.DescripciondelControl <> "No Se Encontraron Registros" And txtCargos.DescripciondelControl <> "" Then

                            If txtDependencia.ValordelControl <> "" And txtDependencia.DescripciondelControl <> "No Se Encontraron Registros" And txtDependencia.DescripciondelControl <> "" Then
                                sql = sql + " And C.Dependencia=" + txtDependencia.ValordelControl
                            End If

                            If txtCargos.ValordelControl <> "" And txtCargos.DescripciondelControl <> "No Se Encontraron Registros" And txtCargos.DescripciondelControl <> "" Then
                                sql = sql + " And CC.Cargo=" + txtCargos.ValordelControl
                            End If
                        End If

                        dt = SMT_AbrirTabla(ObjetoApiNomina, sql)
                        If dt.Rows.Count > 0 Then
                            Dim encontro As Boolean = False
                            Dim tabla As DataTable = CType(gcNovedades.DataSource, DataTable)
                            If dt.Rows.Count > 0 Then

                                For incre As Integer = 0 To dt.Rows.Count - 1
                                    encontro = False
                                    Dim ConsulEmple As DataTable = SMT_AbrirTabla(ObjetoApiNomina, "SELECT CN.Sec AS Codigo FROM NominaLiquidaContratos CN Inner join NominaLiquida NL on CN.NominaLiquida = NL.Sec Where CN.Contrato=" + dt.Rows(incre)("CodContrato").ToString + " And NL.Periodo =" + SecPeriodo)
                                    If ConsulEmple.Rows.Count > 0 Then
                                        encontro = True
                                    End If
                                    'For i As Integer = 0 To tabla.Rows.Count - 1
                                    '    If dt.Rows(incre)("CodContrato").ToString = tabla.Rows(i)("CodContrato").ToString Then

                                    '    End If
                                    'Next
                                    If Not encontro Then

                                        If GuardaNominaLiquidaContratos(dt.Rows(incre)("CodContrato").ToString, SecNominaLiquida, "0", dt.Rows(incre)("HorasMes").ToString, dt.Rows(incre)("CargoActual").ToString, dt.Rows(incre)("Asignacion").ToString, "0", "0", "0", "0") Then
                                            If ColumnasVP.Rows.Count > 0 Then
                                                For i As Integer = 0 To ColumnasVP.Rows.Count - 1
                                                    Dim SecNomLiquidaCont As String = "", Mitb As DataTable = SMT_AbrirTabla(ObjetoApiNomina, "SELECT CN.Sec AS Codigo FROM NominaLiquidaContratos CN Inner join NominaLiquida NL on CN.NominaLiquida = NL.Sec Where CN.Contrato=" + dt.Rows(incre)("CodContrato").ToString + " And NL.Periodo =" + SecPeriodo)
                                                    SecNomLiquidaCont = Mitb.Rows(0)(0).ToString

                                                    If GuardaNominaLiquidaVariables(SecNomLiquidaCont, "0", ColumnasVP.Rows(i)("Sec").ToString) Then
                                                    Else
                                                        Exit Sub
                                                    End If
                                                Next
                                            End If
                                            encontro = False
                                        Else
                                            Exit Sub
                                        End If
                                    Else
                                        If ColumnasVP.Rows.Count > 0 Then
                                            For i As Integer = 0 To ColumnasVP.Rows.Count - 1
                                                Dim SecNomLiquidaCont As String = "", Mitb As DataTable = SMT_AbrirTabla(ObjetoApiNomina, "SELECT CN.Sec AS Codigo FROM NominaLiquidaContratos CN Inner join NominaLiquida NL on CN.NominaLiquida = NL.Sec Where CN.Contrato=" + dt.Rows(incre)("CodContrato").ToString + " And NL.Periodo =" + SecPeriodo)
                                                SecNomLiquidaCont = Mitb.Rows(0)(0).ToString
                                                If Not ExisteDato("NominaLiquidaVariables", String.Format("SecLiquidaContrato='{0}' And Variable='{1}' ", SecNomLiquidaCont, ColumnasVP.Rows(i)("Sec").ToString), ObjetoApiNomina) Then
                                                    If GuardaNominaLiquidaVariables(SecNomLiquidaCont, "0", ColumnasVP.Rows(i)("Sec").ToString) Then
                                                    Else
                                                        Exit Sub
                                                    End If
                                                End If
                                            Next
                                        End If
                                    End If
                                Next
                            Else
                                For incre As Integer = 0 To dt.Rows.Count - 1
                                    If GuardaNominaLiquidaContratos(dt.Rows(incre)("CodContrato").ToString, SecNominaLiquida, "0", dt.Rows(incre)("HorasMes").ToString, dt.Rows(incre)("CargoActual").ToString, dt.Rows(incre)("Asignacion").ToString, "0", "0", "0", "0") Then
                                        If ColumnasVP.Rows.Count > 0 Then
                                            For i As Integer = 0 To ColumnasVP.Rows.Count - 1
                                                Dim SecNomLiquidaCont As String = "", Mitb As DataTable = SMT_AbrirTabla(ObjetoApiNomina, "SELECT CN.Sec AS Codigo FROM NominaLiquidaContratos CN Inner join NominaLiquida NL on CN.NominaLiquida = NL.Sec Where CN.Contrato=" + dt.Rows(incre)("CodContrato").ToString + " And NL.Periodo =" + SecPeriodo)
                                                SecNomLiquidaCont = Mitb.Rows(0)(0).ToString
                                                If GuardaNominaLiquidaVariables(SecNomLiquidaCont, "0", ColumnasVP.Rows(i)("Sec").ToString) Then
                                                Else
                                                    Exit Sub
                                                End If
                                            Next
                                        End If
                                    Else
                                        Exit Sub
                                    End If
                                Next
                            End If
                        Else
                            Exit Sub
                            HDevExpre.MensagedeError("No se han encontrato Empleados para esta nomina!..")
                        End If

                    ElseIf ExisteDato("NominaLiquidada", String.Format("Periodo='{0}' And Estado<>'A' ", SecPeriodo), ObjetoApiNomina) Then
                        HDevExpre.MensagedeError("Este periodo ya ha sido liquidado!..")
                        Exit Sub
                    Else
                        If GuardaNominaLiquida() Then
                            sql = " Select C.Asignacion AS Asignacion,C.CodContrato AS CodContrato,C.HorasMes AS HorasMes,C.CargoActual AS CargoActual, " +
                            " CC.Cargo As Cargo from Contratos C INNER JOIN Contrato_Cargos CC ON C.CargoActual = CC.SecCargos where C.Nomina =" + txtNominas.ValordelControl + " And C.Plantilla <> '' And Terminado=0"

                            dt = SMT_AbrirTabla(ObjetoApiNomina, sql)
                            If dt.Rows.Count > 0 Then
                                For incre As Integer = 0 To dt.Rows.Count - 1
                                    If GuardaNominaLiquidaContratos(dt.Rows(incre)("CodContrato").ToString, SMT_AbrirTabla(ObjetoApiNomina, "SELECT ISNULL( MAX (Sec),0) AS Codigo FROM NominaLiquida Where Periodo =" + SecPeriodo).Rows(0)(0).ToString, "0", dt.Rows(incre)("HorasMes").ToString, dt.Rows(incre)("CargoActual").ToString, dt.Rows(incre)("Asignacion").ToString, "0", "0", "0", "0") Then
                                        If ColumnasVP.Rows.Count > 0 Then
                                            Dim SecNomLiquidaCont As String = "", Mitb As DataTable = SMT_AbrirTabla(ObjetoApiNomina, "SELECT CN.Sec AS Codigo FROM NominaLiquidaContratos CN Inner join NominaLiquida NL on CN.NominaLiquida = NL.Sec Where CN.Contrato=" + dt.Rows(incre)("CodContrato").ToString + " And NL.Periodo =" + SecPeriodo)
                                            SecNomLiquidaCont = Mitb.Rows(0)(0).ToString
                                            For i As Integer = 0 To ColumnasVP.Rows.Count - 1
                                                If GuardaNominaLiquidaVariables(SecNomLiquidaCont, "0", ColumnasVP.Rows(i)("Sec").ToString) Then
                                                Else
                                                    Exit Sub
                                                End If
                                            Next
                                        End If
                                    Else
                                        Exit Sub
                                    End If
                                Next
                            Else
                                HDevExpre.MensagedeError("No se han encontrato Empleados para esta nomina!..")
                            End If
                        Else
                            Exit Sub
                        End If
                    End If
                End If
            End If
        End If
        ConsultaDatos()
    End Sub

    Private Sub gvNovedades_ValidatingEditor(sender As Object, e As BaseContainerValidateEditorEventArgs) Handles gvNovedades.ValidatingEditor
        Dim valormaximo As Decimal = 0
        For incre As Integer = 0 To ColumnasVP.Rows.Count - 1
            If gvNovedades.FocusedColumn.Name = ColumnasVP.Rows(incre)("Nombre").ToString Then
                If ColumnasVP.Rows(incre)("ValorMaximo").ToString <> "" Then
                    valormaximo = CDec(ColumnasVP.Rows(incre)("ValorMaximo").ToString)
                End If
            End If
        Next
        If gvNovedades.FocusedColumn.Name <> "Comentario" Then
            Dim cadena As String = e.Value.ToString
            Dim Caracter As Char = Nothing
            If cadena <> "" Then
                For incre As Integer = 0 To cadena.Length - 1
                    Caracter = CChar(cadena.Substring(incre, 1))
                    If Not IsNumeric(Caracter) And Asc(Caracter) <> 46 Then
                        e.Value = 0
                        Exit For
                        Exit Sub
                    End If
                Next
                Dim valor As Decimal = CDec(e.Value)
                If valor > valormaximo Then
                    e.Value = 0
                    Exit Sub
                End If
            Else
                e.Value = 0
                Exit Sub
            End If
        End If
    End Sub

    Private Sub txtPeriodos_EntraControl(sender As Object, e As EventArgs) Handles txtPeriodos.EntraControl
        If txtNominas.ValordelControl = "" Or txtNominas.DescripciondelControl = "No Se Encontraron Registros" Or txtNominas.DescripciondelControl = "" Then
            txtNominas.Focus()
        Else
            txtPeriodos.ConsultaSQL = String.Format("SELECT CodPeriodo AS Codigo,Descripcion As Descripcion FROM  PeriodosLiquidacion where año ='{1}' And Nomina='{2}' And Estado<>'L'", txtAño.ValordelControl, txtNominas.ValordelControl)
            txtPeriodos.RefrescarDatos()
        End If
    End Sub

    Public Function EliminarBorrador() As Boolean
        SecNominaLiquida = SMT_AbrirTabla(ObjetoApiNomina, "SELECT Sec AS Codigo FROM NominaLiquida Where Periodo =" + SecPeriodo).Rows(0)(0).ToString
        Dim sql As String = "Select NLV.Sec From NominaLiquidaVariables NLV INNER JOIN NominaLiquidaContratos NLC  ON NLV.SecLiquidaContrato = NLC.Sec WHERE NLC.NominaLiquida=" + SecNominaLiquida
        Dim dt As DataTable = SMT_AbrirTabla(ObjetoApiNomina, sql)
        If dt.Rows.Count > 0 Then
            If SMT_EjcutarComandoSqlBool(ObjetoApiNomina, String.Format("Delete NominaLiquidaVariables From NominaLiquidaVariables NLV INNER JOIN NominaLiquidaContratos NLC  ON NLV.SecLiquidaContrato = NLC.Sec WHERE NLC.NominaLiquida={0}", SecNominaLiquida)) > 0 Then

            Else
                Return False
            End If
        End If

        sql = "Select NLCC.Sec From NominaLiquidaConceptos NLCC INNER JOIN NominaLiquidaContratos NLC  ON NLCC.LiquidaContrato = NLC.Sec WHERE NLC.NominaLiquida=" + SecNominaLiquida
        dt = SMT_AbrirTabla(ObjetoApiNomina, sql)
        If dt.Rows.Count > 0 Then
            If SMT_EjcutarComandoSqlBool(ObjetoApiNomina, String.Format("Delete NominaLiquidaConceptos From NominaLiquidaConceptos NLCC INNER JOIN NominaLiquidaContratos NLC  ON NLCC.LiquidaContrato = NLC.Sec WHERE NLC.NominaLiquida={0}", SecNominaLiquida)) > 0 Then

            Else
                Return False
            End If
        End If

        sql = "Select Sec From NominaLiquidaContratos  WHERE NominaLiquida=" + SecNominaLiquida
        dt = SMT_AbrirTabla(ObjetoApiNomina, sql)
        If dt.Rows.Count > 0 Then
            If SMT_EjcutarComandoSqlBool(ObjetoApiNomina, String.Format("Delete From NominaLiquidaContratos  WHERE NominaLiquida={0}", SecNominaLiquida)) > 0 Then

            Else
                Return False
            End If
        End If

        If SMT_EjcutarComandoSqlBool(ObjetoApiNomina, String.Format("Delete From NominaLiquida Where Sec={0}", SecNominaLiquida)) > 0 Then
        Else
            Return False
        End If
        Return True
    End Function

    Private Sub btnEliminarBorrador_Click(sender As Object, e As EventArgs) Handles btnEliminarBorrador.Click
        If HDevExpre.MsgSamit("Seguro que desea eliminar este borrador?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.OK Then
            Dim wait As New ClEspera
            wait.Mostrar()
            wait.Descripcion = "Guardando Datos..."
            If EliminarBorrador() Then
                LimpiarTodosCampos()
                wait.Terminar()
            Else
                wait.Terminar()
            End If
        End If
    End Sub

    Private Sub btnEliminarBorrador_KeyPress(sender As Object, e As KeyPressEventArgs) Handles btnSalir.KeyPress, btnLimpiar.KeyPress, btnGuardar.KeyPress, btnEliminarBorrador.KeyPress, btnBuscar.KeyPress, btnBorradores.KeyPress
        HDevExpre.AtrasConScape(e)
    End Sub

    Private Sub txtDependencia_Load(sender As Object, e As EventArgs) Handles txtDependencia.Load

    End Sub
End Class