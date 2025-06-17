Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns
Imports SamitCtlNet
Imports DevExpress.XtraEditors.Controls
Imports System.Transactions
Imports DevExpress.XtraGrid
Imports DevExpress.XtraEditors
Imports DevExpress.XtraVerticalGrid
Imports DevExpress.XtraVerticalGrid.Rows
Imports DevExpress.XtraEditors.Repository

Public Class FrmLiquidacionExtraordinaria

    Public Datos As New SamitCtlNet.SamitCtlNet
    Dim SecNominaLiquida As String = ""
    Dim TipoNomina As String = ""
    Dim contratos As String = ""
    Dim CadenaConceptos As String = ""
    Dim Año As String = ""
    Dim NumSemestre As String = ""
    Dim NumMes As String = ""
    Dim CodNomina As String = ""
    Dim CodOficina As String = ""
    Dim SecContratoLiquida As String = ""
    Dim IndexRow As String = ""
    Dim ColumnasVP As New DataTable
    Dim ColumnasVPCopias As New DataTable
    Dim ContratosALiquidar As New DataTable
    Dim ColumnasVG As New DataTable
    Dim Conceptos As New DataTable
    Dim ConceptosPersonales As New DataTable
    Dim Bases As New DataTable
    Dim ConceptosContrato As New DataTable
    Dim ConceptosAtadosAlContrato As New DataTable
    Dim ConceptosAtadosAlContratoLiquida As New DataTable
    Dim CamposCalculados As New DataTable
    Dim ValoresMaximosaDescontar As New DataTable
    Dim FormularioAbierto As Boolean = False
    Dim EstaLiquidando As Boolean = False
    Dim PasaValor As Boolean = True
    Dim ActualizaNovedades As Boolean = False
    Dim Fecha As New DateTime
    Dim Memo As New RepositoryItemMemoExEdit
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
    Public Property P_Fecha() As DateTime
        Get
            Return Fecha
        End Get
        Set(value As DateTime)
            Fecha = value
        End Set
    End Property
    Public Property P_Nomina() As String
        Get
            Return CodNomina
        End Get
        Set(value As String)
            CodNomina = value
        End Set
    End Property
    Public Property P_Oficina() As String
        Get
            Return CodOficina
        End Get
        Set(value As String)
            CodOficina = value
        End Set
    End Property

    Private Sub FrmCalcularNomina_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AsignaScriptAcontroles()
        Memo.SuppressMouseEventOnOuterMouseClick = True
        AcomodaForm()
        Creagrillahorizontal()
    End Sub

    Private Sub AcomodaForm()
        Try
            btnBuscar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Buscar)
            btnLiquidar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.LiquidaNomina)
            btnLimpiar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Limpiar)
            btnSalir.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.SalirCuadroConX)
            btnNuevaLiquidacion.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Agregar)
            btnEliminar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.EliminarGris)
            Dim classResize As New ClaseResize
            classResize.Resizagrid(gvLiquidaNomina)
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, " AcomodaForm Contrato")
        End Try
    End Sub

    Private Sub AsignaScriptAcontroles()
        Try

            Dim Sql As String = "select NomVariable as Nombre,ValorMaximo as ValorMaximo,Sec as Sec from VariablesPersonales"
            ColumnasVP = SMT_AbrirTabla(ObjetoApiNomina, Sql)
            Sql = "select NomBase as Nombre,Formula from BasesConceptos"
            Bases = SMT_AbrirTabla(ObjetoApiNomina, Sql)
            Sql = "select CN.NomConcepto as Nombre,CCN.Formula,CN.Base,CN.Redondea from ConceptosNomina CN INNER JOIN ConfigConceptos CCN ON CCN.Concepto = CN.Sec"
            Conceptos = SMT_AbrirTabla(ObjetoApiNomina, Sql)
            Sql = "select NomConcepto as Nombre,ValMaxDescuento As Formula from ConceptosPersonales"
            ConceptosPersonales = SMT_AbrirTabla(ObjetoApiNomina, Sql)
            Sql = "select NomPlantilla as Nombre,ValorMaxDescontar as Formula from Plantillas"
            ValoresMaximosaDescontar = SMT_AbrirTabla(ObjetoApiNomina, Sql)
            Sql = "SELECT VG.NomVariable AS Nombre,MAX(VGD.Fecha) AS Fecha,VG.Sec AS Variable " &
                  "FROM DetallesVariablesGenerales VGD INNER JOIN " &
                  "VariablesGenerales VG ON VGD.Variable = vG.Sec " &
                  "group by VG.NomVariable,VG.Sec"
            ColumnasVG = SMT_AbrirTabla(ObjetoApiNomina, Sql)
            ColumnasVG.Columns.Add("Valor", GetType(Decimal))
            Dim ArmaColumnas As DataTable
            For incre As Integer = 0 To ColumnasVG.Rows.Count - 1
                Dim fecha As String = CDate(ColumnasVG.Rows(incre)("Fecha").ToString).ToString("dd/MM/yyyy")
                Sql = "SELECT VG.NomVariable AS Nombre,VGD.Valor AS Valor " &
                    "FROM DetallesVariablesGenerales VGD " &
                    "INNER JOIN VariablesGenerales VG ON VGD.Variable = vG.Sec " &
                    "WHERE Variable ='" + ColumnasVG.Rows(incre)("Variable").ToString + "' AND VGD.Fecha = '" + fecha + "'"
                ArmaColumnas = SMT_AbrirTabla(ObjetoApiNomina, Sql)
                ColumnasVG.Rows(incre)("Valor") = ArmaColumnas.Rows(0)("Valor")
            Next
            ConceptosAtadosAlContratoLiquida.Columns.Add("Nombre", GetType(String))
            ConceptosAtadosAlContratoLiquida.Columns.Add("Formula", GetType(String))
            ConceptosAtadosAlContratoLiquida.Columns.Add("Tipo", GetType(String))
            ConceptosAtadosAlContratoLiquida.Columns.Add("SecDescuento", GetType(String))
            ConceptosAtadosAlContratoLiquida.Columns.Add("SecConcepto", GetType(String))
            CamposCalculados.Columns.Add("Nombre", GetType(String))
            CamposCalculados.Columns.Add("Tipo", GetType(String))
            CamposCalculados.Columns.Add("Formula", GetType(String))

            If ColumnasVP.Rows.Count > 0 Then
                ColumnasVPCopias.Columns.Clear()
                ColumnasVPCopias.Rows.Clear()
                Dim sasf As System.Drawing.Color = Color.FromArgb(&HFF, &HE3, &HDB)
                For incre As Integer = 0 To ColumnasVP.Rows.Count - 1
                    ColumnasVPCopias.Columns.Add(ColumnasVP.Rows(incre)("Nombre").ToString, GetType(Decimal))
                Next
                Dim fila As DataRow = ColumnasVPCopias.NewRow()
                ColumnasVPCopias.Rows.Add(fila)
                ColumnasVPCopias.AcceptChanges()
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "AsignaScriptAcontroles")
        End Try
    End Sub

    Public Sub ObtieneConceptos(Tabla As DataTable)
        ConceptosContrato = Tabla
    End Sub

    Private Sub CreagrillaVerticalID(Conexion As Object, CodContrato As String)
        vgIngresosDeducciones.Rows.Clear()
        Try
            Dim sql = ""
            Dim filas As New DataTable
            Dim NuevaFila As DataRow = filas.NewRow()
            CreaFilas(vgIngresosDeducciones, "Ingresos", "Ingresos", True, True, "0", True, False, Nothing)
            CreaFilas(vgIngresosDeducciones, "Deducciones", "Deducciones", True, True, "0", True, False, Nothing)
            CreaFilas(vgIngresosDeducciones, "Total", "Total", True, True, "[Ingresos] - [Deducciones]", True, False, Nothing)
            'Conceptos

            sql = "Select CP.Sec as SecDescuento,CP.DescontarPeriodo As DescontarPeriodo,CP.TotalDescontar as TotalDescontar, " +
    " CP.TotalDescontado As TotalDescontado,C.NomConcepto As NomConcepto, " +
    " C.PeriodosLiquida As PeriodosLiquida,C.Sec as SecConcepto, " +
    " C.ValMaxDescuento As ValMaxDescuento,CC.Nom As Clasificacion from ConceptosP_Contratos CP " +
    " INNER JOIN ConceptosPersonales C ON CP.Concepto = C.Sec " +
    " INNER JOIN ClasConceptosPersonales CC ON C.Clasificacion = CC.Sec Where CP.Contrato =" + CodContrato + " And CP.Vigente = 1 And CP.AplicaLiquidaExtraordinarias = 1 order by cc.NivelP asc"
            ConceptosAtadosAlContrato = SMT_AbrirTabla(ObjetoApiNomina, sql)
            If ConceptosContrato.Rows.Count > 0 Then
                For incre As Integer = 0 To ConceptosContrato.Rows.Count - 1
                    If ConceptosContrato.Rows(incre)("Tipo").ToString = "Ingresos" Or ConceptosContrato.Rows(incre)("Tipo").ToString = "Deducciones" Then
                        Dim categoria As EditorRow = TryCast(vgIngresosDeducciones.GetRowByCaption(ConceptosContrato.Rows(incre)("Tipo").ToString), EditorRow)
                        Dim Formu As String = categoria.Properties.UnboundExpression
                        Formu = Formu + " + " + "[" + ConceptosContrato.Rows(incre)("Nombre").ToString + "]"
                        categoria.Properties.UnboundExpression = Formu
                        CreaFilas(vgIngresosDeducciones, ConceptosContrato.Rows(incre)("Nombre").ToString, ConceptosContrato.Rows(incre)("Nombre").ToString, True, True, "", True, True, categoria)
                        filas.Columns.Add(ConceptosContrato.Rows(incre)("Nombre").ToString, GetType(Decimal))
                        NuevaFila(ConceptosContrato.Rows(incre)("Nombre").ToString) = 0
                    End If
                Next

            End If

            'If ConceptosAtadosAlContrato.Rows.Count > 0 Then
            '    ConceptosAtadosAlContratoLiquida.Rows.Clear()
            '    For incre As Integer = 0 To ConceptosAtadosAlContrato.Rows.Count - 1

            '        Dim categoria As EditorRow = TryCast(vgIngresosDeducciones.GetRowByCaption("Deducciones"), EditorRow)
            '        'llena tabla de conceptos a liquidar
            '        Dim fila As DataRow = ConceptosAtadosAlContratoLiquida.NewRow()
            '        fila("Nombre") = ConceptosAtadosAlContrato.Rows(incre)("NomConcepto").ToString
            '        fila("Formula") = ConceptosAtadosAlContrato.Rows(incre)("ValMaxDescuento").ToString
            '        fila("Tipo") = "DPN"
            '        fila("SecDescuento") = ConceptosAtadosAlContrato.Rows(incre)("SecDescuento").ToString
            '        fila("SecConcepto") = ConceptosAtadosAlContrato.Rows(incre)("SecConcepto").ToString
            '        ConceptosAtadosAlContratoLiquida.Rows.Add(fila)
            '        ConceptosAtadosAlContratoLiquida.AcceptChanges()
            '        '---------------------------------
            '        Dim Formu As String = categoria.Properties.UnboundExpression
            '        Formu = Formu + " + " + "[" + ConceptosAtadosAlContrato.Rows(incre)("NomConcepto").ToString + "]"
            '        categoria.Properties.UnboundExpression = Formu
            '        CreaFilas(vgIngresosDeducciones, ConceptosAtadosAlContrato.Rows(incre)("NomConcepto").ToString, ConceptosAtadosAlContrato.Rows(incre)("NomConcepto").ToString, True, True, "", True, True, categoria)
            '        filas.Columns.Add(ConceptosAtadosAlContrato.Rows(incre)("NomConcepto").ToString, GetType(Decimal))
            '        Dim TotalDescontar, TotalDescontado, DescontarPeriodo, Falta As Decimal
            '        TotalDescontar = CDec(ConceptosAtadosAlContrato.Rows(incre)("TotalDescontar"))
            '        TotalDescontado = CDec(ConceptosAtadosAlContrato.Rows(incre)("TotalDescontado"))
            '        DescontarPeriodo = CDec(ConceptosAtadosAlContrato.Rows(incre)("DescontarPeriodo"))
            '        Falta = TotalDescontar - TotalDescontado
            '        If Falta > 0 Then
            '            If Falta > DescontarPeriodo Then
            '                NuevaFila(ConceptosAtadosAlContrato.Rows(incre)("NomConcepto").ToString) = ConceptosAtadosAlContrato.Rows(incre)("DescontarPeriodo")
            '            ElseIf DescontarPeriodo >= Falta Then
            '                NuevaFila(ConceptosAtadosAlContrato.Rows(incre)("NomConcepto").ToString) = Falta
            '            End If
            '        Else
            '            NuevaFila(ConceptosAtadosAlContrato.Rows(incre)("NomConcepto").ToString) = "0"
            '        End If
            '    Next
            'Else
            '    ConceptosAtadosAlContratoLiquida.Rows.Clear()
            'End If

            filas.Rows.Add(NuevaFila)
            filas.AcceptChanges()
            vgIngresosDeducciones.DataSource = filas
            Dim classResize As New ClaseResize
            classResize.ResizaVgridCatgorias(vgIngresosDeducciones)
            vgIngresosDeducciones.RowHeaderWidth = CInt((50 * (vgIngresosDeducciones.Width)) / 100)
            vgIngresosDeducciones.RecordWidth = CInt((50 * (vgIngresosDeducciones.Width)) / 100 - 5)
        Catch ex As Exception
        End Try
    End Sub

    Public Function ValidaFormulaDescuentos(Formula As String, Clasificacion As String) As Boolean
        Dim NoDepende As Boolean = False
        Dim value As String = Formula
        Dim valueConsulta As String = ""
        Dim Columna As String = ""
        Dim ColumnaConsulta As String = ""
        Dim Inicio As Integer = 0
        Dim Fin As Integer = 0
        Dim dt As New DataTable
        For incre As Integer = 0 To value.Length - 1
            If value.Substring(incre, 1) = "[" Then
                Inicio = incre
            End If
            If value.Substring(incre, 1) = "]" Then
                Fin = incre
                Columna = value.Substring(Inicio + 1, Fin - Inicio - 1)
                If Columna = Clasificacion Then
                    Return False
                End If
            End If
        Next
        Return True
    End Function

    Private Sub CreagrillaVerticalDPN()
        vgDescPorNomina.Rows.Clear()
        ConceptosAtadosAlContratoLiquida.Rows.Clear()
        Try

            Dim filas As New DataTable
            Dim NuevaFila As DataRow = filas.NewRow()
            'TiposConceptos(Categorias)

            If ConceptosAtadosAlContrato.Rows.Count > 0 Then
                Dim Clasificacion As New EditorRow
                For incre As Integer = 0 To ConceptosAtadosAlContrato.Rows.Count - 1
                    Clasificacion = TryCast(vgDescPorNomina.GetRowByCaption(ConceptosAtadosAlContrato.Rows(incre)("Clasificacion").ToString), EditorRow)
                    If Clasificacion Is Nothing Then
                        CreaFilas(vgDescPorNomina, ConceptosAtadosAlContrato.Rows(incre)("Clasificacion").ToString, ConceptosAtadosAlContrato.Rows(incre)("Clasificacion").ToString, True, True, "0", True, False, Nothing)
                    End If
                Next
            End If
            CreaFilas(vgDescPorNomina, "Total De Descuentos Por Nomina", "Total De Descuentos Por Nomina", True, True, "0", True, False, Nothing)
            If ConceptosAtadosAlContrato.Rows.Count > 0 Then
                Dim Clasificacion As New EditorRow
                For incre As Integer = 0 To ConceptosAtadosAlContrato.Rows.Count - 1
                    Clasificacion = TryCast(vgDescPorNomina.GetRowByCaption(ConceptosAtadosAlContrato.Rows(incre)("Clasificacion").ToString), EditorRow)
                    If Clasificacion Is Nothing Then
                    Else
                        Dim categoria As EditorRow = TryCast(vgDescPorNomina.GetRowByCaption("Total De Descuentos Por Nomina"), EditorRow)
                        Dim Formu As String = categoria.Properties.UnboundExpression
                        If ValidaFormulaDescuentos(Formu, ConceptosAtadosAlContrato.Rows(incre)("Clasificacion").ToString) Then
                            Formu = Formu + " + " + "[" + ConceptosAtadosAlContrato.Rows(incre)("Clasificacion").ToString + "]"
                        Else
                            Formu = Formu
                        End If

                        categoria.Properties.UnboundExpression = Formu
                    End If
                Next
            End If

            Dim classResize As New ClaseResize
            classResize.ResizaVgridCatgorias(vgDescPorNomina)
            vgDescPorNomina.RowHeaderWidth = CInt((50 * (vgDescPorNomina.Width)) / 100)
            vgDescPorNomina.RecordWidth = CInt((50 * (vgDescPorNomina.Width)) / 100 - 5)

            If ConceptosAtadosAlContrato.Rows.Count > 0 Then
                Dim ValMax As Decimal = 0
                For incre As Integer = 0 To ConceptosAtadosAlContrato.Rows.Count - 1
                    Dim ValFalta As Decimal = CDec(ConceptosAtadosAlContrato.Rows(incre)("TotalDescontar")) - CDec(ConceptosAtadosAlContrato.Rows(incre)("TotalDescontado"))
                    Dim ValDesc As Decimal = CDec(ConceptosAtadosAlContrato.Rows(incre)("DescontarPeriodo"))
                    If ActualizaNovedades Then
                        If gvLiquidaNomina.GetRowCellValue(CInt(IndexRow), ConceptosAtadosAlContrato.Rows(incre)("NomConcepto").ToString) Is Nothing Then
                            ValMax = 0
                        Else
                            ValMax = CDec(gvLiquidaNomina.GetRowCellValue(CInt(IndexRow), ConceptosAtadosAlContrato.Rows(incre)("NomConcepto").ToString).ToString)
                        End If
                    Else
                        If gvLiquidaNomina.GetRowCellValue(gvLiquidaNomina.FocusedRowHandle, ConceptosAtadosAlContrato.Rows(incre)("NomConcepto").ToString) Is Nothing Then
                            ValMax = 0
                        Else
                            ValMax = CDec(gvLiquidaNomina.GetRowCellValue(gvLiquidaNomina.FocusedRowHandle, ConceptosAtadosAlContrato.Rows(incre)("NomConcepto").ToString).ToString)
                        End If
                    End If

                    'If ValFalta < ValDesc Then
                    '            If ValFalta > ValMax Then
                    '               HDevExpre.MensagedeError("El valor del descuento " + ConceptosAtadosAlContrato.Rows(incre)("NomConcepto").ToString + " (" + ValFalta.ToString("c2") + ") es mayor al maximo que se le puede aplicar (" + ValMax.ToString("c2") + ")!..")
                    '                Exit Sub
                    '            End If
                    'Else
                    '            If ValDesc > ValMax Then
                    '               HDevExpre.MensagedeError("El valor del descuento " + ConceptosAtadosAlContrato.Rows(incre)("NomConcepto").ToString + " (" + ValDesc.ToString("c2") + ") es mayor al maximo que se le puede aplicar (" + ValMax.ToString("c2") + ")!..")
                    '                Exit Sub
                    '            End If
                    'End If

                Next

                Dim Saldo As Decimal = 0

                If ActualizaNovedades Then
                    If gvLiquidaNomina.GetRowCellValue(CInt(IndexRow), gvLiquidaNomina.GetRowCellValue(CInt(IndexRow), "Plantilla").ToString) Is Nothing Then
                        Saldo = 0
                    Else
                        Saldo = CDec(gvLiquidaNomina.GetRowCellValue(CInt(IndexRow), gvLiquidaNomina.GetRowCellValue(CInt(IndexRow), "Plantilla").ToString).ToString)
                    End If
                Else
                    If gvLiquidaNomina.GetRowCellValue(gvLiquidaNomina.FocusedRowHandle, gvLiquidaNomina.GetFocusedRowCellValue("Plantilla").ToString) Is Nothing Then
                        Saldo = 0
                    Else
                        Saldo = CDec(gvLiquidaNomina.GetRowCellValue(gvLiquidaNomina.FocusedRowHandle, gvLiquidaNomina.GetFocusedRowCellValue("Plantilla").ToString).ToString)
                    End If
                End If

                ConceptosAtadosAlContratoLiquida.Rows.Clear()
                For incre As Integer = 0 To ConceptosAtadosAlContrato.Rows.Count - 1

                    Dim categoria As EditorRow = TryCast(vgDescPorNomina.GetRowByCaption(ConceptosAtadosAlContrato.Rows(incre)("Clasificacion").ToString), EditorRow)
                    'llena tabla de conceptos a liquidar
                    Dim fila As DataRow = ConceptosAtadosAlContratoLiquida.NewRow()
                    fila("Nombre") = ConceptosAtadosAlContrato.Rows(incre)("NomConcepto").ToString
                    fila("Formula") = ConceptosAtadosAlContrato.Rows(incre)("ValMaxDescuento").ToString
                    fila("Tipo") = "DPN"
                    fila("SecDescuento") = ConceptosAtadosAlContrato.Rows(incre)("SecDescuento").ToString
                    fila("SecConcepto") = ConceptosAtadosAlContrato.Rows(incre)("SecConcepto").ToString
                    ConceptosAtadosAlContratoLiquida.Rows.Add(fila)
                    ConceptosAtadosAlContratoLiquida.AcceptChanges()
                    '---------------------------------
                    Dim Formu As String = categoria.Properties.UnboundExpression
                    Formu = Formu + " + " + "[" + ConceptosAtadosAlContrato.Rows(incre)("NomConcepto").ToString + "]"
                    categoria.Properties.UnboundExpression = Formu
                    CreaFilas(vgDescPorNomina, ConceptosAtadosAlContrato.Rows(incre)("NomConcepto").ToString, ConceptosAtadosAlContrato.Rows(incre)("NomConcepto").ToString, True, True, "", True, True, categoria)
                    filas.Columns.Add(ConceptosAtadosAlContrato.Rows(incre)("NomConcepto").ToString, GetType(Decimal))
                    Dim TotalDescontar, TotalDescontado, DescontarPeriodo, Falta As Decimal
                    TotalDescontar = CDec(ConceptosAtadosAlContrato.Rows(incre)("TotalDescontar"))
                    TotalDescontado = CDec(ConceptosAtadosAlContrato.Rows(incre)("TotalDescontado"))
                    DescontarPeriodo = CDec(ConceptosAtadosAlContrato.Rows(incre)("DescontarPeriodo"))
                    Falta = TotalDescontar - TotalDescontado
                    If Saldo > 0 Then

                        If Falta > 0 Then
                            If Falta > DescontarPeriodo Then
                                If DescontarPeriodo < Saldo Then
                                    NuevaFila(ConceptosAtadosAlContrato.Rows(incre)("NomConcepto").ToString) = ConceptosAtadosAlContrato.Rows(incre)("DescontarPeriodo")
                                    Saldo = Saldo - CDec(ConceptosAtadosAlContrato.Rows(incre)("DescontarPeriodo"))
                                Else
                                    NuevaFila(ConceptosAtadosAlContrato.Rows(incre)("NomConcepto").ToString) = Saldo
                                    Saldo = Saldo - Saldo
                                End If
                            ElseIf DescontarPeriodo >= Falta Then
                                If Falta < Saldo Then
                                    NuevaFila(ConceptosAtadosAlContrato.Rows(incre)("NomConcepto").ToString) = Falta
                                    Saldo = Saldo - Falta
                                Else
                                    NuevaFila(ConceptosAtadosAlContrato.Rows(incre)("NomConcepto").ToString) = Saldo
                                    Saldo = Saldo - Saldo
                                End If
                            End If
                        Else
                            NuevaFila(ConceptosAtadosAlContrato.Rows(incre)("NomConcepto").ToString) = "0"
                        End If
                    Else
                        NuevaFila(ConceptosAtadosAlContrato.Rows(incre)("NomConcepto").ToString) = "0"
                    End If
                Next
            Else
                ConceptosAtadosAlContratoLiquida.Rows.Clear()
            End If
            filas.Rows.Add(NuevaFila)
            filas.AcceptChanges()
            vgDescPorNomina.DataSource = filas

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Creagrillahorizontal()
        gvLiquidaNomina.Columns.Clear()
        Dim sql As String = ""
        Dim filas As New DataTable
        Dim NuevaFila As DataRow = filas.NewRow()
        Dim dt As DataTable = SMT_AbrirTabla(ObjetoApiNomina, sql)
        Dim coloor As System.Drawing.Color = Color.FromArgb(&HCC, &HFF, &HCC)
        CreaColumnas(gvLiquidaNomina, "NomNomina", "Nomina", False, False, "", coloor, False, 8, gcLiquidaNomina.Width, False)
        dt.Columns.Add("NomNomina", GetType(String))
        CreaColumnas(gvLiquidaNomina, "IdContrato", "Contrato", True, False, "", coloor, False, 4, gcLiquidaNomina.Width, False)
        dt.Columns.Add("IdContrato", GetType(String))
        CreaColumnas(gvLiquidaNomina, "CodContrato", "Contrato", False, False, "", coloor, False, 4, gcLiquidaNomina.Width, False)
        dt.Columns.Add("CodContrato", GetType(String))
        CreaColumnas(gvLiquidaNomina, "IdentificacionEmple", "Identificación Empleado", True, False, "", coloor, False, 15, gcLiquidaNomina.Width, False, True)
        dt.Columns.Add("IdentificacionEmple", GetType(String))
        CreaColumnas(gvLiquidaNomina, "NomEmple", "Nombre Empleado", True, False, "", coloor, False, 15, gcLiquidaNomina.Width, False, True)
        dt.Columns.Add("NomEmple", GetType(String))
        CreaColumnas(gvLiquidaNomina, "Asignacion", "Asignacion", True, False, "", coloor, True, 8, gcLiquidaNomina.Width, False)
        dt.Columns.Add("NominaLiquidaContrato", GetType(String))
        dt.Columns.Add("HorasMes", GetType(Decimal))
        dt.Columns.Add("Asignacion", GetType(Decimal))
        dt.Columns.Add("RentaExenta", GetType(Decimal))
        dt.Columns.Add("DescuentosPorNomina", GetType(Decimal))
        dt.Columns.Add("SalarioPromedioPeriodo", GetType(Decimal))
        dt.Columns.Add("SalarioPromedioMensualAnual", GetType(Decimal))
        dt.Columns.Add("SalarioPromedioMensualSemestral", GetType(Decimal))
        dt.Columns.Add("NetoAPagar", GetType(Decimal))
        dt.Columns.Add("TotalIngresos", GetType(Decimal))
        dt.Columns.Add("TotalDeducciones", GetType(Decimal))
        dt.Columns.Add("Plantilla", GetType(String))
        dt.Columns.Add("TotalPagadoMes", GetType(Decimal))
        dt.Columns.Add("CargoActual", GetType(String))
        If ColumnasVG.Rows.Count > 0 Then
            For incre As Integer = 0 To ColumnasVG.Rows.Count - 1
                Dim sasf As System.Drawing.Color = Color.FromArgb(&HB1, &HF3, &HDA)
                dt.Columns.Add(ColumnasVG.Rows(incre)("Nombre").ToString, GetType(Decimal))
                CreaColumnas(gvLiquidaNomina, ColumnasVG.Rows(incre)("Nombre").ToString, ColumnasVG.Rows(incre)("Nombre").ToString, False, False, "", sasf, True, 0, 0, False)
            Next
        End If

        CreaColumnas(gvLiquidaNomina, "HorasMes", "HorasMes", False, False, "", coloor, True, 0, 0, False)
        CreaColumnas(gvLiquidaNomina, "RentaExenta", "RentaExenta", False, False, "", coloor, True, 0, 0, False)
        CreaColumnas(gvLiquidaNomina, "DescuentosPorNomina", "DescuentosPorNomina", False, False, "", coloor, True, 0, 0, False)
        CreaColumnas(gvLiquidaNomina, "SalarioPromedioPeriodo", "SalarioPromedioPeriodo", False, False, "", coloor, True, 0, 0, False)
        CreaColumnas(gvLiquidaNomina, "SalarioPromedioMensualAnual", "SalarioPromedioMensualAnual", False, False, "", coloor, True, 0, 0, False)
        CreaColumnas(gvLiquidaNomina, "SalarioPromedioMensualSemestral", "SalarioPromedioMensualSemestral", False, False, "", coloor, True, 0, 0, False)
        CreaColumnas(gvLiquidaNomina, "NetoAPagar", "NetoAPagar", False, False, "", coloor, True, 0, 0, False)
        CreaColumnas(gvLiquidaNomina, "TotalIngresos", "TotalIngresos", False, False, "", coloor, True, 0, 0, False)
        CreaColumnas(gvLiquidaNomina, "TotalDeducciones", "TotalDeducciones", False, False, "", coloor, True, 0, 0, False)
        CreaColumnas(gvLiquidaNomina, "TotalPagadoMes", "TotalPagadoMes", False, False, "", coloor, True, 0, 0, False)
        If ColumnasVP.Rows.Count > 0 Then
            Dim sasf As System.Drawing.Color = Color.FromArgb(&HFF, &HE3, &HDB)
            For incre As Integer = 0 To ColumnasVP.Rows.Count - 1
                dt.Columns.Add(ColumnasVP.Rows(incre)("Nombre").ToString, GetType(Decimal))
                CreaColumnas(gvLiquidaNomina, ColumnasVP.Rows(incre)("Nombre").ToString, ColumnasVP.Rows(incre)("Nombre").ToString, True, True, "", sasf, True, 20, gcLiquidaNomina.Width, False)
            Next

        End If

        If Bases.Rows.Count > 0 Then
            For incre As Integer = 0 To Bases.Rows.Count - 1
                Dim sasf As System.Drawing.Color = Color.FromArgb(&HB1, &HF3, &HDA)
                CreaColumnas(gvLiquidaNomina, Bases.Rows(incre)("Nombre").ToString, Bases.Rows(incre)("Nombre").ToString, False, False, Bases.Rows(incre)("Formula").ToString, sasf, True, 0, 0, False)
                Dim fila As DataRow = CamposCalculados.NewRow()
                fila("Nombre") = Bases.Rows(incre)("Nombre").ToString
                fila("Tipo") = "B"
                fila("Formula") = Bases.Rows(incre)("Formula").ToString
                CamposCalculados.Rows.Add(fila)
                CamposCalculados.AcceptChanges()
            Next
        End If

        If Conceptos.Rows.Count > 0 Then
            For incre As Integer = 0 To Conceptos.Rows.Count - 1
                Dim sasf As System.Drawing.Color = Color.FromArgb(&HB1, &HF3, &HDA)
                CreaColumnas(gvLiquidaNomina, Conceptos.Rows(incre)("Nombre").ToString, Conceptos.Rows(incre)("Nombre").ToString, False, False, Conceptos.Rows(incre)("Formula").ToString, sasf, True, 0, 0, False)
                Dim fila As DataRow = CamposCalculados.NewRow()
                fila("Nombre") = Conceptos.Rows(incre)("Nombre").ToString
                fila("Tipo") = "C"
                fila("Formula") = Conceptos.Rows(incre)("Formula").ToString
                CamposCalculados.Rows.Add(fila)
                CamposCalculados.AcceptChanges()
            Next
        End If

        If ConceptosPersonales.Rows.Count > 0 Then
            For incre As Integer = 0 To ConceptosPersonales.Rows.Count - 1
                Dim sasf As System.Drawing.Color = Color.FromArgb(&HB1, &HF3, &HDA)
                CreaColumnas(gvLiquidaNomina, ConceptosPersonales.Rows(incre)("Nombre").ToString, ConceptosPersonales.Rows(incre)("Nombre").ToString, False, False, ConceptosPersonales.Rows(incre)("Formula").ToString, sasf, True, 0, 0, False)
                Dim fila As DataRow = CamposCalculados.NewRow()
                fila("Nombre") = ConceptosPersonales.Rows(incre)("Nombre").ToString
                fila("Tipo") = "CP"
                fila("Formula") = ConceptosPersonales.Rows(incre)("Formula").ToString
                CamposCalculados.Rows.Add(fila)
                CamposCalculados.AcceptChanges()
            Next
        End If

        If ValoresMaximosaDescontar.Rows.Count > 0 Then
            For incre As Integer = 0 To ValoresMaximosaDescontar.Rows.Count - 1
                Dim sasf As System.Drawing.Color = Color.FromArgb(&HB1, &HF3, &HDA)
                CreaColumnas(gvLiquidaNomina, ValoresMaximosaDescontar.Rows(incre)("Nombre").ToString, ValoresMaximosaDescontar.Rows(incre)("Nombre").ToString, False, False, ValoresMaximosaDescontar.Rows(incre)("Formula").ToString, sasf, True, 0, 0, False)
                Dim fila As DataRow = CamposCalculados.NewRow()
                fila("Nombre") = ValoresMaximosaDescontar.Rows(incre)("Nombre").ToString
                fila("Tipo") = "DPN"
                fila("Formula") = ValoresMaximosaDescontar.Rows(incre)("Formula").ToString
                CamposCalculados.Rows.Add(fila)
                CamposCalculados.AcceptChanges()
            Next
        End If

        Try
            gcLiquidaNomina.DataSource = dt
        Catch ex As Exception
        End Try
    End Sub


    Private Sub ConsultaDatos(Conexion As Object)
        Try
            Dim sql As String = "Select C.NomConcepto AS Nombre,C.Sec As Sec,CL.Nom As Clasificacion,CC.Formula,Case TCN.NomTipo WHEN 'Provisiones' then 'Ingresos' when 'Ingresos' then 'Ingresos' when 'Deducciones' then 'Deducciones' end As Tipo,C.Base As Base,C.Redondea As Redondea " +
" From ConceptosNomina C Inner join ClasConceptosNomina CL ON C.Clasificacion = CL.Sec " +
"Inner join ConfigConceptos CC ON C.Sec = CC.Concepto Inner Join TiposConceptosNomina TCN ON C.Tipo = TCN.Sec Where cc.Nomina =" + CodNomina
            Conceptos = SMT_AbrirTabla(ObjetoApiNomina, sql)
            ConceptosContrato = Conceptos.Copy
            ConceptosContrato.Clear()
            CadenaConceptos = SMT_AbrirTabla(ObjetoApiNomina, "SELECT Conceptos AS Conceptos FROM NominaLiquidaExtraordinaria Where sec=" + SecNominaLiquida).Rows(0)(0).ToString

            Dim delimitador As Char = ","c
            Dim ConceptosLiqui() As String = CadenaConceptos.Split(delimitador)
            For i As Integer = 0 To ConceptosLiqui.Length - 1
                For incre As Integer = 0 To Conceptos.Rows.Count - 1
                    If ConceptosLiqui(i) = Conceptos.Rows(incre)("Nombre").ToString Then
                        ConceptosContrato.ImportRow(Conceptos.Rows(incre))
                        Exit For
                    End If
                Next
            Next
            Dim ContratoPlan As String = ""
            Dim consulta As DataTable = CType(gcLiquidaNomina.DataSource, DataTable)
            Creagrillahorizontal()
            consulta.Rows.Clear()
            If ContratosALiquidar.Rows.Count > 0 Then
                contratos = "Where "
                ContratoPlan = "Where "
                For incre As Integer = 0 To ContratosALiquidar.Rows.Count - 1
                    If incre = 0 Then
                        contratos = contratos + " NL.Estado <>'A' And NLC.Contrato=" + ContratosALiquidar.Rows(incre)("CodContrato").ToString
                        ContratoPlan = ContratoPlan + " C.CodContrato=" + ContratosALiquidar.Rows(incre)("CodContrato").ToString
                    Else
                        contratos = contratos + " Or NL.Estado <>'A' And NLC.Contrato=" + ContratosALiquidar.Rows(incre)("CodContrato").ToString
                        ContratoPlan = ContratoPlan + " Or C.CodContrato=" + ContratosALiquidar.Rows(incre)("CodContrato").ToString
                    End If
                Next
            End If
            sql = "Select E.Identificacion as IdentificacionEmple, RTRIM(LTRIM(RTRIM(LTRIM(E.PNombre)) + ' ' +  RTRIM(LTRIM(E.SNombre)) + ' ' +  RTRIM(LTRIM(E.PApellido)) + ' ' + RTRIM(LTRIM(E.SApellido)))) As NomEmple, C.CodContrato as CodContrato, C.IdContrato as IdContrato,CC.Cargo as Cargo,V.NomVariable as Variable, SUM(NLV.Cantidad) as Cantidad, NLC.Comentario As Comentario,AVG(NLC.TotalIngresos) SalarioPromedioPeriodo, C.HorasMes as HorasMes,C.Asignacion as Asignacion, C.CargoActual as CargoActual,VEX.Valor as RentaExenta From NominaLiquidadaVariables NLV   INNER JOIN NominaLiquidadaContratos NLC ON NLV.SecLiquidadaContrato = NLC.Sec INNER JOIN VariablesPersonales V ON NLV.Variable = V.Sec  INNER JOIN Contratos C ON NLC.Contrato = C.CodContrato  Left JOIN (select Contrato, sum(Valor)as Valor from Asig_ValoresExentos Where Vigente =1 group by Contrato) As VEX ON VEX.Contrato = c.CodContrato INNER JOIN Empleados E ON C.Empleado = E.IdEmpleado  INNER JOIN Contrato_Cargos CC ON C.CargoActual = CC.SecCargos INNER JOIN Cargos CA ON CC.Cargo = CA.SecCargo  INNER JOIN NominaLiquidada NL ON NLC.NominaLiquidada= NL.Sec INNER JOIN PeriodosLiquidacion PL ON PL.Sec = NL.Periodo  " + contratos + " Group by E.Identificacion,E.PNombre,E.SNombre,E.PApellido,E.SApellido, C.CodContrato,C.IdContrato,CC.Cargo,V.NomVariable,NLC.Comentario,C.HorasMes, C.Asignacion, VEX.Valor, C.CargoActual"
            '                " Select E.Identificacion as IdentificacionEmple, RTRIM(LTRIM(RTRIM(LTRIM(E.PNombre)) + ' ' +  " +
            '"RTRIM(LTRIM(E.SNombre)) + ' ' +  RTRIM(LTRIM(E.PApellido)) + ' ' + RTRIM(LTRIM(E.SApellido)))) As NomEmple, " +
            '"C.CodContrato as CodContrato, C.IdContrato as IdContrato,CC.Cargo as Cargo,V.NomVariable as Variable, " +
            '"SUM(NLV.Cantidad) as Cantidad, NLC.Comentario As Comentario,AVG(NLC.TotalIngresos) SalarioPromedioPeriodo, " +
            '"C.HorasMes as HorasMes,C.Asignacion as Asignacion, C.ValorExento as RentaExenta,C.CargoActual as CargoActual " +
            '"From NominaLiquidadaVariables NLV   INNER JOIN NominaLiquidadaContratos NLC ON NLV.SecLiquidadaContrato = NLC.Sec " +
            '"INNER JOIN VariablesPersonales V ON NLV.Variable = V.Sec  INNER JOIN Contratos C ON NLC.Contrato = C.CodContrato " +
            '"INNER JOIN Empleados E ON C.Empleado = E.IdEmpleado  INNER JOIN Contrato_Cargos CC ON C.CargoActual = CC.SecCargos " +
            '"INNER JOIN Cargos CA ON CC.Cargo = CA.SecCargo  INNER JOIN NominaLiquidada NL ON NLC.NominaLiquidada= NL.Sec " +
            '"INNER JOIN PeriodosLiquidacion PL ON PL.Sec = NL.Periodo  " + contratos +
            '" Group by E.Identificacion,E.PNombre,E.SNombre,E.PApellido,E.SApellido, C.CodContrato,C.IdContrato,CC.Cargo,V.NomVariable,NLC.Comentario,C.HorasMes, C.Asignacion, C.ValorExento, C.CargoActual"
            Dim dt As DataTable = SMT_AbrirTabla(ObjetoApiNomina, sql)

            sql = " Select Consul.Contrato, AVG(Consul.promedioanual)as PromedioSemestral From( " +
" Select NLC.Contrato As Contrato,Sum(NLC.TotalIngresos) promedioanual From NominaLiquidadaContratos NLC " +
" INNER JOIN NominaLiquidada NL ON NLC.NominaLiquidada = NL.Sec INNER JOIN PeriodosLiquidacion P ON NL.Periodo = P.Sec " +
" INNER JOIN Contratos C ON NLC.Contrato = C.CodContrato " +
" Where NL.Estado <>'A' And P.Semestre=" + NumSemestre + " AND P.Año =" + Año + " GROUP BY NLC.Contrato,P.NumMes) As Consul Group by Consul.Contrato "
            Dim PromedioMensualSemestral As DataTable = SMT_AbrirTabla(ObjetoApiNomina, sql)


            sql = "Select NLDC.Contrato as Contrato,SUM(NLDC.Total) as TotalPagadoAlMes From NominaLiquidadaContratos NLDC " +
" INNER JOIN NominaLiquidada NLD ON NLDC.NominaLiquidada = NLD.Sec " +
" INNER JOIN PeriodosLiquidacion PDL ON NLD.Periodo = PDL.Sec " +
" WHERE NLD.Estado <>'A' AND PDL.Año = " + Año + " And PDL.NumMes =" + NumMes + " And PDL.Nomina = " + CodNomina +
" Group by NLDC.Contrato "
            Dim AcomuladosMes As DataTable = SMT_AbrirTabla(ObjetoApiNomina, sql)


            sql = " Select Consul.Contrato, AVG(Consul.promedioanual)as promedioanual From( " +
" Select NLC.Contrato As Contrato,Sum(NLC.TotalIngresos) promedioanual From NominaLiquidadaContratos NLC " +
" INNER JOIN NominaLiquidada NL ON NLC.NominaLiquidada = NL.Sec INNER JOIN PeriodosLiquidacion P ON NL.Periodo = P.Sec " +
" INNER JOIN Contratos C ON NLC.Contrato = C.CodContrato " +
" Where NL.Estado <>'A' And P.Año =" + Año + " GROUP BY NLC.Contrato,P.NumMes) As Consul Group by Consul.Contrato "
            Dim PromedioMensualAnual As DataTable = SMT_AbrirTabla(ObjetoApiNomina, sql)


            sql = "Select P.NomPlantilla As Plantilla, C.IdContrato As Contrato From Contratos C INNER JOIN Plantillas P ON C.Plantilla = P.SecPlantilla " + ContratoPlan
            Dim PlantillasContratos As DataTable = SMT_AbrirTabla(ObjetoApiNomina, sql)


            sql = " Select Sec,Contrato From NominaLiquidaExtraordinariaContratos WHERE NominaLiquidaExtraordinaria =" + SecNominaLiquida
            Dim NominaLiquidaContratosT As DataTable = SMT_AbrirTabla(ObjetoApiNomina, sql)

            Dim NumEmp As Integer = 0
            Dim ValorAcomulado As Decimal = 0
            Dim Promedio_M_A = ""
            Dim Promedio_M_S = ""
            If dt.Rows.Count > 0 Then

                For incre As Integer = 0 To PlantillasContratos.Rows.Count - 1
                    If PlantillasContratos.Rows(incre)("Plantilla").ToString = "" Then
                        HDevExpre.MensagedeError("El Contrato " + PlantillasContratos.Rows(incre)("Contrato").ToString + " no tiene ningun perfil de conceptos asociado..!")
                        Exit Sub
                    End If
                Next

                For incre As Integer = 0 To dt.Rows.Count - 1
                    ValorAcomulado = 0
                    Promedio_M_A = ""
                    Promedio_M_S = ""
                    If incre = 0 Then
                        Dim fila As DataRow = consulta.NewRow()
                        fila("CodContrato") = dt.Rows(incre)("CodContrato").ToString
                        fila("IdContrato") = dt.Rows(incre)("IdContrato").ToString
                        fila("IdentificacionEmple") = dt.Rows(incre)("IdentificacionEmple").ToString
                        fila("NomEmple") = dt.Rows(incre)("NomEmple").ToString
                        fila("NomNomina") = CodNomina
                        fila("HorasMes") = dt.Rows(incre)("HorasMes").ToString
                        fila("Asignacion") = dt.Rows(incre)("Asignacion").ToString
                        fila("CargoActual") = dt.Rows(incre)("CargoActual").ToString
                        fila("NetoAPagar") = 0
                        fila("SalarioPromedioPeriodo") = dt.Rows(incre)("SalarioPromedioPeriodo").ToString
                        If dt.Rows(incre)("RentaExenta").ToString <> "" Then
                            fila("RentaExenta") = dt.Rows(incre)("RentaExenta").ToString
                        Else
                            fila("RentaExenta") = 0
                        End If

                        If AcomuladosMes.Rows.Count > 0 Then
                            For i As Integer = 0 To AcomuladosMes.Rows.Count - 1
                                If AcomuladosMes.Rows(i)("Contrato").ToString = dt.Rows(incre)("CodContrato").ToString Then
                                    ValorAcomulado = CDec(AcomuladosMes.Rows(i)("TotalPagadoAlMes"))
                                    Exit For
                                End If
                            Next
                        End If

                        If PlantillasContratos.Rows.Count > 0 Then
                            For i As Integer = 0 To PlantillasContratos.Rows.Count - 1
                                If PlantillasContratos.Rows(i)("Contrato").ToString = dt.Rows(incre)("IdContrato").ToString Then
                                    fila("Plantilla") = PlantillasContratos.Rows(i)("Plantilla")
                                    Exit For
                                End If
                            Next
                        End If


                        If PromedioMensualSemestral.Rows.Count > 0 Then
                            For i As Integer = 0 To PromedioMensualSemestral.Rows.Count - 1
                                If PromedioMensualSemestral.Rows(i)("Contrato").ToString = dt.Rows(incre)("CodContrato").ToString Then
                                    Promedio_M_S = PromedioMensualSemestral.Rows(i)("PromedioSemestral").ToString
                                End If
                            Next
                        End If
                        If Promedio_M_S <> "" Then
                            fila("SalarioPromedioMensualSemestral") = Promedio_M_S
                        Else
                            fila("SalarioPromedioMensualSemestral") = dt.Rows(incre)("Asignacion").ToString
                        End If

                        If PromedioMensualAnual.Rows.Count > 0 Then
                            For i As Integer = 0 To PromedioMensualAnual.Rows.Count - 1
                                If PromedioMensualAnual.Rows(i)("Contrato").ToString = dt.Rows(incre)("CodContrato").ToString Then
                                    Promedio_M_A = PromedioMensualAnual.Rows(i)("promedioanual").ToString
                                End If
                            Next
                        End If

                        If Promedio_M_A <> "" Then
                            fila("SalarioPromedioMensualAnual") = Promedio_M_A
                        Else
                            fila("SalarioPromedioMensualAnual") = dt.Rows(incre)("Asignacion").ToString
                        End If
                        fila("TotalPagadoMes") = ValorAcomulado
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
                        fila("NomNomina") = CodNomina
                        fila("HorasMes") = dt.Rows(incre)("HorasMes").ToString
                        fila("Asignacion") = dt.Rows(incre)("Asignacion").ToString
                        fila("NetoAPagar") = 0
                        fila("CargoActual") = dt.Rows(incre)("CargoActual").ToString
                        fila("SalarioPromedioPeriodo") = dt.Rows(incre)("SalarioPromedioPeriodo").ToString
                        If dt.Rows(incre)("RentaExenta").ToString <> "" Then
                            fila("RentaExenta") = dt.Rows(incre)("RentaExenta").ToString
                        Else
                            fila("RentaExenta") = 0
                        End If

                        For i As Integer = 0 To AcomuladosMes.Rows.Count - 1
                            If AcomuladosMes.Rows(i)("Contrato").ToString = dt.Rows(incre)("CodContrato").ToString Then
                                ValorAcomulado = CDec(AcomuladosMes.Rows(i)("TotalPagadoAlMes"))
                                Exit For
                            End If
                        Next

                        If PlantillasContratos.Rows.Count > 0 Then
                            For i As Integer = 0 To PlantillasContratos.Rows.Count - 1
                                If PlantillasContratos.Rows(i)("Contrato").ToString = dt.Rows(incre)("IdContrato").ToString Then
                                    fila("Plantilla") = PlantillasContratos.Rows(i)("Plantilla")
                                    Exit For
                                End If
                            Next
                        End If

                        If PromedioMensualSemestral.Rows.Count > 0 Then
                            For i As Integer = 0 To PromedioMensualSemestral.Rows.Count - 1
                                If PromedioMensualSemestral.Rows(i)("Contrato").ToString = dt.Rows(incre)("CodContrato").ToString Then
                                    Promedio_M_S = PromedioMensualSemestral.Rows(i)("PromedioSemestral").ToString
                                End If
                            Next
                        End If
                        If Promedio_M_S <> "" Then
                            fila("SalarioPromedioMensualSemestral") = Promedio_M_S
                        Else
                            fila("SalarioPromedioMensualSemestral") = dt.Rows(incre)("Asignacion").ToString
                        End If

                        If PromedioMensualAnual.Rows.Count > 0 Then
                            For i As Integer = 0 To PromedioMensualAnual.Rows.Count - 1
                                If PromedioMensualAnual.Rows(i)("Contrato").ToString = dt.Rows(incre)("CodContrato").ToString Then
                                    Promedio_M_A = PromedioMensualAnual.Rows(i)("promedioanual").ToString
                                End If
                            Next
                        End If

                        If Promedio_M_A <> "" Then
                            fila("SalarioPromedioMensualAnual") = Promedio_M_A
                        Else
                            fila("SalarioPromedioMensualAnual") = dt.Rows(incre)("Asignacion").ToString
                        End If

                        fila("TotalPagadoMes") = ValorAcomulado
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
                        gcLiquidaNomina.DataSource = consulta
                    End If
                Next

                For i As Integer = 0 To ColumnasVG.Rows.Count - 1
                    For incre As Integer = 0 To consulta.Rows.Count - 1
                        Dim cantidad As String = ColumnasVG.Rows(i)("Valor").ToString
                        If cantidad = "" Then
                            consulta.Rows(incre)(ColumnasVG.Rows(i)("Nombre").ToString) = "0"
                        Else
                            consulta.Rows(incre)(ColumnasVG.Rows(i)("Nombre").ToString) = cantidad
                        End If
                    Next
                Next

                For i As Integer = 0 To consulta.Rows.Count - 1
                    Dim cantidad As String = consulta.Rows(i)("TotalPagadoMes").ToString
                    If cantidad = "" Then
                        consulta.Rows(i)("TotalPagadoMes") = "0"
                    Else
                        consulta.Rows(i)("TotalPagadoMes") = cantidad
                    End If
                Next

                For i As Integer = 0 To NominaLiquidaContratosT.Rows.Count - 1
                    For incre As Integer = 0 To consulta.Rows.Count - 1
                        If consulta.Rows(incre)("CodContrato").ToString = NominaLiquidaContratosT.Rows(i)("Contrato").ToString Then
                            consulta.Rows(incre)("NominaLiquidaContrato") = NominaLiquidaContratosT.Rows(i)("Sec").ToString
                        End If
                    Next
                Next

                gcLiquidaNomina.DataSource = consulta
                gcLiquidaNomina.Focus()
            Else

                sql = "Select E.Identificacion as IdentificacionEmple, RTRIM(LTRIM(RTRIM(LTRIM(E.PNombre)) + ' ' +   RTRIM(LTRIM(E.SNombre)) + ' ' +  RTRIM(LTRIM(E.PApellido)) + ' ' + RTRIM(LTRIM(E.SApellido)))) As NomEmple, C.CodContrato as CodContrato, C.IdContrato as IdContrato,CC.Cargo as Cargo,'Variable' as Variable, 0 as Cantidad, 0 SalarioPromedioPeriodo, C.HorasMes as HorasMes,C.Asignacion as Asignacion, C.CargoActual as CargoActual,VEX.Valor as RentaExenta From Contratos C INNER JOIN Empleados E ON C.Empleado = E.IdEmpleado  INNER JOIN Contrato_Cargos CC ON C.CargoActual = CC.SecCargos INNER JOIN Cargos CA ON CC.Cargo = CA.SecCargo " + ContratoPlan + " Left JOIN (select Contrato, sum(Valor)as Valor from Asig_ValoresExentos Where Vigente =1 group by Contrato) As VEX ON VEX.Contrato = c.CodContrato Group by E.Identificacion,E.PNombre,E.SNombre,E.PApellido,E.SApellido, C.CodContrato,C.IdContrato,CC.Cargo,C.HorasMes, C.Asignacion, VEX.Valor, C.CargoActual"

                '                    "Select E.Identificacion as IdentificacionEmple, RTRIM(LTRIM(RTRIM(LTRIM(E.PNombre)) + ' ' +  " +
                '            " RTRIM(LTRIM(E.SNombre)) + ' ' +  RTRIM(LTRIM(E.PApellido)) + ' ' + RTRIM(LTRIM(E.SApellido)))) As NomEmple, " +
                '"C.CodContrato as CodContrato, C.IdContrato as IdContrato,CC.Cargo as Cargo,'Variable' as Variable, " +
                '"0 as Cantidad, 0 SalarioPromedioPeriodo, " +
                '"C.HorasMes as HorasMes,C.Asignacion as Asignacion, C.ValorExento as RentaExenta,C.CargoActual as CargoActual " +
                '"From Contratos C INNER JOIN Empleados E " +
                '"ON C.Empleado = E.IdEmpleado  INNER JOIN Contrato_Cargos CC ON C.CargoActual = CC.SecCargos INNER JOIN Cargos CA " +
                '"ON CC.Cargo = CA.SecCargo " + ContratoPlan +
                '"Group by E.Identificacion,E.PNombre,E.SNombre,E.PApellido,E.SApellido, C.CodContrato,C.IdContrato,CC.Cargo,C.HorasMes, C.Asignacion, C.ValorExento, C.CargoActual"
                dt = SMT_AbrirTabla(ObjetoApiNomina, sql)

                If dt.Rows.Count > 0 Then
                    If dt.Rows.Count = 1 Then
                        Dim fila As DataRow = consulta.NewRow()
                        fila("CodContrato") = dt.Rows(0)("CodContrato").ToString
                        fila("IdContrato") = dt.Rows(0)("IdContrato").ToString
                        fila("IdentificacionEmple") = dt.Rows(0)("IdentificacionEmple").ToString
                        fila("NomEmple") = dt.Rows(0)("NomEmple").ToString
                        fila("NomNomina") = CodNomina
                        fila("HorasMes") = dt.Rows(0)("HorasMes").ToString
                        fila("Asignacion") = dt.Rows(0)("Asignacion").ToString
                        fila("CargoActual") = dt.Rows(0)("CargoActual").ToString
                        fila("NetoAPagar") = 0
                        fila("SalarioPromedioPeriodo") = dt.Rows(0)("Asignacion").ToString
                        If dt.Rows(0)("RentaExenta").ToString <> "" Then
                            fila("RentaExenta") = dt.Rows(0)("RentaExenta").ToString
                        Else
                            fila("RentaExenta") = 0
                        End If

                        If AcomuladosMes.Rows.Count > 0 Then
                            For i As Integer = 0 To AcomuladosMes.Rows.Count - 1
                                If AcomuladosMes.Rows(i)("Contrato").ToString = dt.Rows(0)("CodContrato").ToString Then
                                    ValorAcomulado = CDec(AcomuladosMes.Rows(i)("TotalPagadoAlMes"))
                                    Exit For
                                End If
                            Next
                        End If

                        If PlantillasContratos.Rows.Count > 0 Then
                            For i As Integer = 0 To PlantillasContratos.Rows.Count - 1
                                If PlantillasContratos.Rows(i)("Contrato").ToString = dt.Rows(0)("IdContrato").ToString Then
                                    fila("Plantilla") = PlantillasContratos.Rows(i)("Plantilla")
                                    Exit For
                                End If
                            Next
                        End If

                        If PromedioMensualSemestral.Rows.Count > 0 Then
                            For i As Integer = 0 To PromedioMensualSemestral.Rows.Count - 1
                                If PromedioMensualSemestral.Rows(i)("Contrato").ToString = dt.Rows(0)("CodContrato").ToString Then
                                    Promedio_M_S = PromedioMensualSemestral.Rows(i)("PromedioSemestral").ToString
                                End If
                            Next
                        End If
                        If Promedio_M_S <> "" Then
                            fila("SalarioPromedioMensualSemestral") = Promedio_M_S
                        Else
                            fila("SalarioPromedioMensualSemestral") = dt.Rows(0)("Asignacion").ToString
                        End If

                        If PromedioMensualAnual.Rows.Count > 0 Then
                            For i As Integer = 0 To PromedioMensualAnual.Rows.Count - 1
                                If PromedioMensualAnual.Rows(i)("Contrato").ToString = dt.Rows(0)("CodContrato").ToString Then
                                    Promedio_M_A = PromedioMensualAnual.Rows(i)("promedioanual").ToString
                                End If
                            Next
                        End If

                        If Promedio_M_A <> "" Then
                            fila("SalarioPromedioMensualAnual") = Promedio_M_A
                        Else
                            fila("SalarioPromedioMensualAnual") = dt.Rows(0)("Asignacion").ToString
                        End If
                        fila("TotalPagadoMes") = ValorAcomulado
                        consulta.Rows.Add(fila)
                        consulta.AcceptChanges()

                        For i As Integer = 0 To ColumnasVG.Rows.Count - 1
                            For incre As Integer = 0 To consulta.Rows.Count - 1
                                Dim cantidad As String = ColumnasVG.Rows(i)("Valor").ToString
                                If cantidad = "" Then
                                    consulta.Rows(incre)(ColumnasVG.Rows(i)("Nombre").ToString) = "0"
                                Else
                                    consulta.Rows(incre)(ColumnasVG.Rows(i)("Nombre").ToString) = cantidad
                                End If
                            Next
                        Next

                        For i As Integer = 0 To consulta.Rows.Count - 1
                            Dim cantidad As String = consulta.Rows(i)("TotalPagadoMes").ToString
                            If cantidad = "" Then
                                consulta.Rows(i)("TotalPagadoMes") = "0"
                            Else
                                consulta.Rows(i)("TotalPagadoMes") = cantidad
                            End If
                        Next

                        For i As Integer = 0 To NominaLiquidaContratosT.Rows.Count - 1
                            For incre As Integer = 0 To consulta.Rows.Count - 1
                                If consulta.Rows(incre)("CodContrato").ToString = NominaLiquidaContratosT.Rows(i)("Contrato").ToString Then
                                    consulta.Rows(incre)("NominaLiquidaContrato") = NominaLiquidaContratosT.Rows(i)("Sec").ToString
                                End If
                            Next
                        Next
                    Else
                        For incre As Integer = 0 To dt.Rows.Count - 1
                            Dim fila As DataRow = consulta.NewRow()
                            fila("CodContrato") = dt.Rows(incre)("CodContrato").ToString
                            fila("IdContrato") = dt.Rows(incre)("IdContrato").ToString
                            fila("IdentificacionEmple") = dt.Rows(incre)("IdentificacionEmple").ToString
                            fila("NomEmple") = dt.Rows(incre)("NomEmple").ToString
                            fila("NomNomina") = CodNomina
                            fila("HorasMes") = dt.Rows(incre)("HorasMes").ToString
                            fila("Asignacion") = dt.Rows(incre)("Asignacion").ToString
                            fila("CargoActual") = dt.Rows(incre)("CargoActual").ToString
                            fila("NetoAPagar") = 0
                            fila("SalarioPromedioPeriodo") = dt.Rows(incre)("Asignacion").ToString
                            If dt.Rows(0)("RentaExenta").ToString <> "" Then
                                fila("RentaExenta") = dt.Rows(incre)("RentaExenta").ToString
                            Else
                                fila("RentaExenta") = 0
                            End If

                            If AcomuladosMes.Rows.Count > 0 Then
                                For i As Integer = 0 To AcomuladosMes.Rows.Count - 1
                                    If AcomuladosMes.Rows(i)("Contrato").ToString = dt.Rows(incre)("CodContrato").ToString Then
                                        ValorAcomulado = CDec(AcomuladosMes.Rows(i)("TotalPagadoAlMes"))
                                        Exit For
                                    End If
                                Next
                            End If

                            If PlantillasContratos.Rows.Count > 0 Then
                                For i As Integer = 0 To PlantillasContratos.Rows.Count - 1
                                    If PlantillasContratos.Rows(i)("Contrato").ToString = dt.Rows(incre)("IdContrato").ToString Then
                                        fila("Plantilla") = PlantillasContratos.Rows(i)("Plantilla")
                                        Exit For
                                    End If
                                Next
                            End If


                            If PromedioMensualSemestral.Rows.Count > 0 Then
                                For i As Integer = 0 To PromedioMensualSemestral.Rows.Count - 1
                                    If PromedioMensualSemestral.Rows(i)("Contrato").ToString = dt.Rows(incre)("CodContrato").ToString Then
                                        Promedio_M_S = PromedioMensualSemestral.Rows(i)("PromedioSemestral").ToString
                                    End If
                                Next
                            End If
                            If Promedio_M_S <> "" Then
                                fila("SalarioPromedioMensualSemestral") = Promedio_M_S
                            Else
                                fila("SalarioPromedioMensualSemestral") = dt.Rows(incre)("Asignacion").ToString
                            End If

                            If PromedioMensualAnual.Rows.Count > 0 Then
                                For i As Integer = 0 To PromedioMensualAnual.Rows.Count - 1
                                    If PromedioMensualAnual.Rows(i)("Contrato").ToString = dt.Rows(incre)("CodContrato").ToString Then
                                        Promedio_M_A = PromedioMensualAnual.Rows(i)("promedioanual").ToString
                                    End If
                                Next
                            End If

                            If Promedio_M_A <> "" Then
                                fila("SalarioPromedioMensualAnual") = Promedio_M_A
                            Else
                                fila("SalarioPromedioMensualAnual") = dt.Rows(incre)("Asignacion").ToString
                            End If
                            fila("TotalPagadoMes") = ValorAcomulado
                            consulta.Rows.Add(fila)
                            consulta.AcceptChanges()

                            For i As Integer = 0 To ColumnasVG.Rows.Count - 1
                                For incre2 As Integer = 0 To consulta.Rows.Count - 1
                                    Dim cantidad As String = ColumnasVG.Rows(i)("Valor").ToString
                                    If cantidad = "" Then
                                        consulta.Rows(incre2)(ColumnasVG.Rows(i)("Nombre").ToString) = "0"
                                    Else
                                        consulta.Rows(incre2)(ColumnasVG.Rows(i)("Nombre").ToString) = cantidad
                                    End If
                                Next
                            Next

                            For i As Integer = 0 To consulta.Rows.Count - 1
                                Dim cantidad As String = consulta.Rows(i)("TotalPagadoMes").ToString
                                If cantidad = "" Then
                                    consulta.Rows(i)("TotalPagadoMes") = "0"
                                Else
                                    consulta.Rows(i)("TotalPagadoMes") = cantidad
                                End If
                            Next

                            For i As Integer = 0 To NominaLiquidaContratosT.Rows.Count - 1
                                For incre2 As Integer = 0 To consulta.Rows.Count - 1
                                    If consulta.Rows(incre2)("CodContrato").ToString = NominaLiquidaContratosT.Rows(i)("Contrato").ToString Then
                                        consulta.Rows(incre2)("NominaLiquidaContrato") = NominaLiquidaContratosT.Rows(i)("Sec").ToString
                                    End If
                                Next
                            Next
                        Next
                    End If
                    gcLiquidaNomina.DataSource = consulta
                    gcLiquidaNomina.Focus()
                Else
                    consulta.Rows.Clear()
                    gcLiquidaNomina.DataSource = consulta
                    gvLiquidaNomina.SelectRow(0)
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Function CalcularDescuentos(DescontarPeriodo As Decimal, TotalDescontar As Decimal, TotalDescontado As Decimal) As Decimal
        Dim Falta As Decimal = 0
        Falta = TotalDescontar - TotalDescontado
        If Falta > 0 Then
            If Falta > DescontarPeriodo Then
                Return DescontarPeriodo
            ElseIf DescontarPeriodo >= Falta Then
                Return Falta
            Else
                Return 0
            End If
        Else
            Return 0
        End If

    End Function
    Private Sub CreaFilas(Grid As VGridControl, Nombre As String, Titulo As String, Visible As Boolean, Editar As Boolean, formula As String, numerico As Boolean, FilaHija As Boolean, filact As EditorRow)
        Dim Fila As New EditorRow
        Grid.OptionsSelectionAndFocus.EnableAppearanceFocusedRow = True
        Grid.OptionsView.ShowFocusedFrame = True
        Grid.OptionsBehavior.Editable = False
        With Fila
            .Name = Nombre
            .Properties.Caption = Titulo
            .Properties.FieldName = Nombre
            .OptionsRow.AllowFocus = True
            .OptionsRow.AllowMove = False
            If Not Visible Then
                .Visible = False
            Else
                .Properties.ShowUnboundExpressionMenu = True
                .Properties.Format.FormatString = "c2"
                .Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric
                .Properties.UnboundType = DevExpress.Data.UnboundColumnType.Decimal
                .Properties.UnboundExpression = formula
                .Properties.ShowUnboundExpressionMenu = True
            End If
        End With

        If FilaHija Then
            filact.ChildRows.Add(Fila)
            Dim classResize As New ClaseResize
            classResize.ResizaVgridRows(Fila)
        Else
            Grid.Rows.Add(Fila)
        End If

    End Sub

    Private Sub CreaColumnas(Grid As GridView, Nombre As String, Titulo As String, Visible As Boolean, Editar As Boolean, formula As String, colores As System.Drawing.Color, numerico As Boolean, Porcentaje_Width As Single, TamañoPadre As Single, EsMemo As Boolean, Optional isfixed As Boolean = False)
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
            If isfixed Then
                .Fixed = Columns.FixedStyle.Left
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
            If EsMemo Then
                .ColumnEdit = Memo
            End If
            .OptionsFilter.AllowFilter = False
            .Visible = Visible
            .AppearanceHeader.Options.UseTextOptions = True
            .AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            .AppearanceCell.Options.UseTextOptions = True
        End With
        Grid.OptionsCustomization.AllowSort = False
        Grid.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.CellFocus
        Grid.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto
        Grid.OptionsView.ColumnAutoWidth = False
        Grid.Columns.Add(gc)
    End Sub

    Private Sub PasarValores()
        Try
            Dim TablaGeneral As DataTable = CType(gcLiquidaNomina.DataSource, DataTable)
            If TablaGeneral.Rows.Count > 0 Then
                For incre As Integer = 0 To CamposCalculados.Rows.Count - 1
                    Dim Valor As String = gvLiquidaNomina.GetRowCellValue(0, CamposCalculados.Rows(incre)("Nombre").ToString).ToString
                    Dim Nombre As String = CamposCalculados.Rows(incre)("Nombre").ToString

                    If Valor = "#Err" Then
                        If CamposCalculados.Rows(incre)("Tipo").ToString = "B" Then
                            HDevExpre.MensagedeError("Se ha encontrado un error." & vbNewLine & "En la formula: " + CamposCalculados.Rows(incre)("Formula").ToString & vbNewLine & "De la base: " + Nombre + ", por favor verificar!..")
                            Exit Sub
                        End If

                        If CamposCalculados.Rows(incre)("Tipo").ToString = "C" Then
                            HDevExpre.MensagedeError("Se ha encontrado un error." & vbNewLine & "En la formula: " + CamposCalculados.Rows(incre)("Formula").ToString & vbNewLine & "Del concepto: " + Nombre + ", por favor verificar!..")
                            Exit Sub
                        End If

                        If CamposCalculados.Rows(incre)("Tipo").ToString = "CP" Then
                            HDevExpre.MensagedeError("Se ha encontrado un error." & vbNewLine & "En la formula: " + CamposCalculados.Rows(incre)("Formula").ToString & vbNewLine & "Del concepto personal: " + Nombre + ", por favor verificar!..")
                            Exit Sub
                        End If

                        'If CamposCalculados.Rows(incre)("Tipo").ToString = "BC" Then
                        '   HDevExpre.MensagedeError("Se ha encontrado un error." & vbNewLine & "En la formula: " + CamposCalculados.Rows(incre)("Formula").ToString & vbNewLine & "De la base del concepto: " + Nombre.Substring(2, Nombre.Length - 2) + ", por favor verificar!..")
                        '    Exit Sub
                        'End If

                        If CamposCalculados.Rows(incre)("Tipo").ToString = "DPN" Then
                            HDevExpre.MensagedeError("Se ha encontrado un error." & vbNewLine & "En la formula: " + CamposCalculados.Rows(incre)("Formula").ToString & vbNewLine & "Del perfil de conceptos: " + Nombre.Substring(2, Nombre.Length - 2) + ", por favor verificar!..")
                            Exit Sub
                        End If

                    End If
                Next
                Dim dtID As DataTable = CType(vgIngresosDeducciones.DataSource, DataTable)
                If dtID Is Nothing Then
                Else
                    If dtID.Rows.Count > 0 Then
                        If ActualizaNovedades Then
                            For i As Integer = 0 To dtID.Columns.Count - 1
                                Dim EsDescuento As Boolean = False
                                If gvLiquidaNomina.GetRowCellValue(CInt(IndexRow), dtID.Columns(i).Caption.ToString) Is Nothing Then
                                    dtID.Rows(0)(dtID.Columns(i).Caption.ToString) = "0"
                                Else
                                    For incree As Integer = 0 To ConceptosAtadosAlContratoLiquida.Rows.Count - 1
                                        If ConceptosAtadosAlContratoLiquida.Rows(incree)("Nombre").ToString = dtID.Columns(i).Caption.ToString Then
                                            EsDescuento = True
                                        End If
                                    Next
                                    If Not EsDescuento Then
                                        Dim Valor As Decimal = CDec(gvLiquidaNomina.GetRowCellValue(CInt(IndexRow), dtID.Columns(i).Caption.ToString).ToString)
                                        If Valor = 0 Then
                                            dtID.Rows(0)(dtID.Columns(i).Caption.ToString) = "0"
                                        Else
                                            Dim CodConcepto As String = ""
                                            For e As Integer = 0 To ConceptosContrato.Rows.Count - 1
                                                If ConceptosContrato.Rows(e)("Nombre").ToString = dtID.Columns(i).Caption.ToString Then
                                                    CodConcepto = ConceptosContrato.Rows(e)("Sec").ToString
                                                End If
                                            Next
                                            dtID.Rows(0)(dtID.Columns(i).Caption.ToString) = Valor
                                        End If
                                    End If
                                End If
                            Next

                        Else
                            For i As Integer = 0 To dtID.Columns.Count - 1
                                Dim EsDescuento As Boolean = False
                                If gvLiquidaNomina.GetFocusedRowCellValue(dtID.Columns(i).Caption.ToString) Is Nothing Then
                                    dtID.Rows(0)(dtID.Columns(i).Caption.ToString) = "0"
                                Else
                                    For incre As Integer = 0 To ConceptosAtadosAlContratoLiquida.Rows.Count - 1
                                        If ConceptosAtadosAlContratoLiquida.Rows(incre)("Nombre").ToString = dtID.Columns(i).Caption.ToString Then
                                            EsDescuento = True
                                        End If
                                    Next
                                    If Not EsDescuento Then
                                        Dim Valor As Decimal = CDec(gvLiquidaNomina.GetFocusedRowCellValue(dtID.Columns(i).Caption.ToString))
                                        If Valor = 0 Then
                                            dtID.Rows(0)(dtID.Columns(i).Caption.ToString) = "0"
                                        Else
                                            Dim CodConcepto As String = ""
                                            For incre As Integer = 0 To ConceptosContrato.Rows.Count - 1
                                                If ConceptosContrato.Rows(incre)("Nombre").ToString = dtID.Columns(i).Caption.ToString Then
                                                    CodConcepto = ConceptosContrato.Rows(incre)("Sec").ToString
                                                End If
                                            Next
                                            dtID.Rows(0)(dtID.Columns(i).Caption.ToString) = Valor
                                        End If
                                    End If
                                End If
                            Next
                        End If
                    End If
                End If
                PasaValor = False
                Dim Total As EditorRow = TryCast(vgIngresosDeducciones.GetRowByCaption("Total"), EditorRow)
                Dim Ingresos As EditorRow = TryCast(vgIngresosDeducciones.GetRowByCaption("Ingresos"), EditorRow)
                Dim Deducciones As EditorRow = TryCast(vgIngresosDeducciones.GetRowByCaption("Deducciones"), EditorRow)
                gvLiquidaNomina.SetRowCellValue(gvLiquidaNomina.FocusedRowHandle, "NetoAPagar", CInt(Total.Properties.Value))

                gvLiquidaNomina.SetRowCellValue(gvLiquidaNomina.FocusedRowHandle, "TotalIngresos", CInt(Ingresos.Properties.Value))

                gvLiquidaNomina.SetRowCellValue(gvLiquidaNomina.FocusedRowHandle, "TotalDeducciones", CInt(Deducciones.Properties.Value))
                PasaValor = True

            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub GridView1_CellValueChanged(sender As Object, e As Views.Base.CellValueChangedEventArgs) Handles gvLiquidaNomina.CellValueChanged

        Dim tblah As DataTable = CType(gcLiquidaNomina.DataSource, DataTable)
        If tblah Is Nothing Then
        Else
            If tblah.Rows.Count > 0 Then
                If Not ActualizaNovedades Then
                    If PasaValor Then
                        CreagrillaVerticalID(ObjetoApiNomina, gvLiquidaNomina.GetFocusedRowCellValue("CodContrato").ToString)
                        PasarValores()
                        CreagrillaVerticalDPN()
                    End If
                End If
            End If
        End If
        If vgDescPorNomina.GetCellValue(vgDescPorNomina.Rows.GetRowByFieldName(e.Column.Name.ToString), 0) Is Nothing Then
        Else
            vgDescPorNomina.SetCellValue(vgDescPorNomina.Rows.GetRowByFieldName(e.Column.Name.ToString), 0, e.Value)
        End If
    End Sub

    Private Sub GridView1_FocusedRowChanged(sender As Object, e As Views.Base.FocusedRowChangedEventArgs) Handles gvLiquidaNomina.FocusedRowChanged
        Dim tblah As DataTable = CType(gcLiquidaNomina.DataSource, DataTable)
        If tblah Is Nothing Then
        Else
            If tblah.Rows.Count > 0 Then
                If PasaValor Then
                    CreagrillaVerticalID(ObjetoApiNomina, gvLiquidaNomina.GetFocusedRowCellValue("CodContrato").ToString)
                    PasarValores()
                    CreagrillaVerticalDPN()
                End If
            End If
        End If
    End Sub

    Public Sub LimpiarTodosCampos(Conexion As Object)
        'Limpia todos los campos de texto
        CodNomina = ""
        CodOficina = ""
        SecNominaLiquida = ""
        CodNomina = ""
        contratos = ""
        EstaLiquidando = False
        ActualizaNovedades = False
        'Limpia todas las grillas
        Dim dt As DataTable = CType(gcLiquidaNomina.DataSource, DataTable)
        dt.Rows.Clear()
        ConceptosContrato.Rows.Clear()
        gcLiquidaNomina.DataSource = dt
        CreagrillaVerticalID(Conexion, "0")
    End Sub
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarTodosCampos(ObjetoApiNomina)
    End Sub
    Public Function GuardaBorrador(ObjetoApiNomina As Object) As Boolean
        For incre As Integer = 0 To CamposCalculados.Rows.Count - 1
            Dim Valor As String = gvLiquidaNomina.GetRowCellValue(0, CamposCalculados.Rows(incre)("Nombre").ToString).ToString
            Dim Nombre As String = CamposCalculados.Rows(incre)("Nombre").ToString
            If Valor = "#Err" Then
                If CamposCalculados.Rows(incre)("Tipo").ToString = "B" Then
                    HDevExpre.MensagedeError("Se ha encontrado un error." & vbNewLine & "En la formula: " + CamposCalculados.Rows(incre)("Formula").ToString & vbNewLine & "De la base: " + Nombre + ", por favor verificar!..")
                    Return False
                End If
                If CamposCalculados.Rows(incre)("Tipo").ToString = "C" Then
                    HDevExpre.MensagedeError("Se ha encontrado un error." & vbNewLine & "En la formula: " + CamposCalculados.Rows(incre)("Formula").ToString & vbNewLine & "Del concepto: " + Nombre + ", por favor verificar!..")
                    Return False
                End If
                If CamposCalculados.Rows(incre)("Tipo").ToString = "CP" Then
                    HDevExpre.MensagedeError("Se ha encontrado un error." & vbNewLine & "En la formula: " + CamposCalculados.Rows(incre)("Formula").ToString & vbNewLine & "Del concepto personal: " + Nombre + ", por favor verificar!..")
                    Return False
                End If
                If CamposCalculados.Rows(incre)("Tipo").ToString = "DPN" Then
                    HDevExpre.MensagedeError("Se ha encontrado un error." & vbNewLine & "En la formula: " + CamposCalculados.Rows(incre)("Formula").ToString & vbNewLine & "Del perfil de conceptos: " + Nombre.Substring(2, Nombre.Length - 2) + ", por favor verificar!..")
                    Return False
                End If
            End If
        Next
        ActualizaNovedades = True
        Dim dt As DataTable = CType(gcLiquidaNomina.DataSource, DataTable)
        If dt.Rows.Count > 0 Then

            If EstaLiquidando Then
                If Not ExisteDato("NominaLiquidaExtraordinaria", String.Format("Sec='{0}' And EsBorrador=0", SecNominaLiquida), ObjetoApiNomina) Then
                    If GuardaNominaLiquidaExtraordinaria(ObjetoApiNomina, "", "") Then
                    Else
                        Return False
                    End If
                Else
                    HDevExpre.MensagedeError("Esta liquidacion ya ha sido liquidada..!")
                    Return False
                End If
            End If

            For incre As Integer = 0 To dt.Rows.Count - 1
                IndexRow = incre.ToString
                CreagrillaVerticalID(ObjetoApiNomina, dt.Rows(incre)("CodContrato").ToString)
                PasarValores()
                CreagrillaVerticalDPN()

                Dim categoriaID As EditorRow = TryCast(vgIngresosDeducciones.GetRowByCaption("Total"), EditorRow)
                Dim categoriaIng As EditorRow = TryCast(vgIngresosDeducciones.GetRowByCaption("Ingresos"), EditorRow)
                Dim categoriadeduc As EditorRow = TryCast(vgIngresosDeducciones.GetRowByCaption("Deducciones"), EditorRow)
                Dim categoriaDPN As EditorRow = TryCast(vgDescPorNomina.GetRowByCaption("Total De Descuentos Por Nomina"), EditorRow)
                Dim totalID As Decimal = 0
                Dim totalIng As Decimal = 0
                Dim totaldeduc As Decimal = 0
                Dim totalDPN As Decimal = 0
                Dim totalcID As String = "0"
                Dim totalcIng As String = "0"
                Dim totalcdeduc As String = "0"
                Dim totalcDPN As String = "0"
                If categoriaID Is Nothing Then

                Else
                    'categoriaID.Properties.RowHandle
                    totalID = CDec(categoriaID.Properties.Value)
                    totalcID = totalID.ToString
                End If

                If categoriaIng Is Nothing Then

                Else
                    totalIng = CDec(categoriaIng.Properties.Value)
                    totalcIng = totalIng.ToString
                End If

                If categoriadeduc Is Nothing Then

                Else
                    totaldeduc = CDec(categoriadeduc.Properties.Value)
                    totalcdeduc = totaldeduc.ToString
                    If totaldeduc < 0 Then
                        HDevExpre.MensagedeError("El total de las deducciones no puede ser superior al total de los ingresos!..  (Error en el contrato numero " + dt.Rows(incre)("CodContrato").ToString + ")")
                        Return False
                    End If
                End If

                If categoriaDPN Is Nothing Then

                Else
                    totalDPN = CDec(categoriaDPN.Properties.Value)
                    totalcDPN = totalDPN.ToString
                End If

                If ConceptosAtadosAlContratoLiquida.Rows.Count > 0 Then
                    totalID = totalID - totalDPN
                    totalcID = totalID.ToString
                End If

                If totaldeduc > totalIng Then
                    HDevExpre.MensagedeError("El total de las deducciones no puede ser superior al total de los ingresos!..  (Error en el contrato numero " + dt.Rows(incre)("CodContrato").ToString + ")")
                    Return False
                End If
                If GuardaNominaLiquidaExtraordinariaContratos(ObjetoApiNomina, dt.Rows(incre)("CodContrato").ToString, SecNominaLiquida, totalcID, dt.Rows(incre)("CargoActual").ToString,
                                                 totalcIng, totaldeduc.ToString, totalDPN.ToString) Then
                    Dim TabConceptos As String = ""
                    Dim TabVariables As String = ""
                    Dim CampoTabConceptos As String = ""
                    Dim CampoTabVariables As String = ""
                    SecContratoLiquida = dt.Rows(incre)("NominaLiquidaContrato").ToString
                    TabConceptos = "NominaLiquidaExtraordinariaConceptos"
                    CampoTabConceptos = "LiquidaContrato"
                    CampoTabVariables = "SecLiquidaContrato"
                    TabVariables = "NominaLiquidaExtraordinariaVariables"

                    'Registra Conceptos de Nomina
                    If ConceptosContrato.Rows.Count > 0 Then
                        For i As Integer = 0 To ConceptosContrato.Rows.Count - 1
                            Dim Fila As New EditorRow
                            Fila = TryCast(vgIngresosDeducciones.GetRowByCaption(ConceptosContrato.Rows(i)("Nombre").ToString), EditorRow)
                            Dim valor As Decimal = CDec(Fila.Properties.Value)
                            Dim valorc2 As String = valor.ToString
                            Dim Basev As Decimal = 0
                            If gvLiquidaNomina.GetRowCellValue(incre, ConceptosContrato.Rows(i)("Base").ToString) Is Nothing Then
                                Basev = 0
                            Else
                                If gvLiquidaNomina.GetRowCellValue(incre, ConceptosContrato.Rows(i)("Base").ToString).ToString = "" Then
                                    Basev = 0
                                Else
                                    Basev = CDec(gvLiquidaNomina.GetRowCellValue(incre, ConceptosContrato.Rows(i)("Base").ToString).ToString)
                                End If
                            End If
                            If ExisteDato(TabConceptos, String.Format(CampoTabConceptos + "='{0}' And SecConcepto='{1}' ", dt.Rows(incre)("NominaLiquidaContrato").ToString, ConceptosContrato.Rows(i)("Sec").ToString), ObjetoApiNomina) Then
                                If GuardaNominaLiquidaExtraordinariaConceptos(ObjetoApiNomina, SecContratoLiquida, valorc2, ConceptosContrato.Rows(i)("Nombre").ToString,
                                                            ConceptosContrato.Rows(i)("Sec").ToString, "", Basev.ToString, ConceptosContrato.Rows(i)("Base").ToString, False, "") Then
                                Else
                                    Return False
                                End If
                            Else
                                ActualizaNovedades = False
                                If GuardaNominaLiquidaExtraordinariaConceptos(ObjetoApiNomina, SecContratoLiquida, valorc2, ConceptosContrato.Rows(i)("Nombre").ToString,
                                                            ConceptosContrato.Rows(i)("Sec").ToString, "", Basev.ToString, ConceptosContrato.Rows(i)("Base").ToString, False, "") Then
                                    ActualizaNovedades = True
                                Else
                                    Return False
                                End If
                            End If
                        Next
                    End If
                    'Registra Conceptos Atados al Contrato
                    If ConceptosAtadosAlContratoLiquida.Rows.Count > 0 Then
                        'estoy guardando conceptos personales
                        For i As Integer = 0 To ConceptosAtadosAlContratoLiquida.Rows.Count - 1
                            Dim Fila As New EditorRow
                            Fila = TryCast(vgDescPorNomina.GetRowByCaption(ConceptosAtadosAlContratoLiquida.Rows(i)("Nombre").ToString), EditorRow)
                            Dim valor As Decimal = CDec(Fila.Properties.Value)
                            Dim valorc As String = valor.ToString


                            If Not ExisteDato(TabConceptos, String.Format(CampoTabConceptos + "='{0}' And SecConceptoP='{1}' ", dt.Rows(incre)("NominaLiquidaContrato").ToString, ConceptosAtadosAlContratoLiquida.Rows(i)("SecConcepto").ToString), ObjetoApiNomina) Then
                                ActualizaNovedades = False
                            Else
                                ActualizaNovedades = True
                            End If

                            Dim Cuota As Integer = 0
                            Cuota = CInt(SMT_AbrirTabla(ObjetoApiNomina, "Select Isnull(CuotaActual,0) Cuota From ConceptosP_Contratos where Sec=" + ConceptosAtadosAlContratoLiquida.Rows(i)("SecDescuento").ToString).Rows(0)(0).ToString)
                            If GuardaNominaLiquidaExtraordinariaConceptos(ObjetoApiNomina, SecContratoLiquida, valorc, ConceptosAtadosAlContratoLiquida.Rows(i)("Nombre").ToString,
                                                        ConceptosAtadosAlContratoLiquida.Rows(i)("SecConcepto").ToString, ConceptosAtadosAlContratoLiquida.Rows(i)("SecDescuento").ToString, totalcID, "B-" + ConceptosAtadosAlContratoLiquida.Rows(i)("Nombre").ToString, True, Cuota.ToString) Then
                                If EstaLiquidando Then
                                    Dim TotalDescontado As Decimal = 0
                                    Dim TotalDescontar As Decimal = 0
                                    Dim Vigente As String = "0"
                                    For incremento As Integer = 0 To ConceptosAtadosAlContrato.Rows.Count - 1
                                        If ConceptosAtadosAlContrato.Rows(incremento)("SecDescuento").ToString = ConceptosAtadosAlContratoLiquida.Rows(i)("SecDescuento").ToString Then
                                            TotalDescontado = CDec(ConceptosAtadosAlContrato.Rows(incremento)("TotalDescontado"))
                                            TotalDescontar = CDec(ConceptosAtadosAlContrato.Rows(incremento)("TotalDescontar"))
                                        End If
                                    Next
                                    TotalDescontado = TotalDescontado + valor
                                    If TotalDescontado >= TotalDescontar Then
                                        Vigente = "0"
                                    Else
                                        Vigente = "1"
                                    End If

                                    If ModificaDescuentosPorNomina(ObjetoApiNomina, ConceptosAtadosAlContratoLiquida.Rows(i)("SecDescuento").ToString, TotalDescontado.ToString, Vigente, Cuota) Then

                                    Else
                                        Return False
                                    End If
                                End If
                                ActualizaNovedades = True
                            Else
                                Return False
                            End If
                        Next
                    End If
                    'Registra Variables
                    For i As Integer = 0 To ColumnasVP.Rows.Count - 1
                        Dim valor As Decimal = 0
                        Dim valorc2 As String = ""
                        If dt.Rows(incre)(ColumnasVP.Rows(i)("Nombre").ToString).ToString = "" Then
                            valor = 0
                        Else
                            valor = CDec(dt.Rows(incre)(ColumnasVP.Rows(i)("Nombre").ToString).ToString)
                        End If
                        valorc2 = valor.ToString()
                        If ExisteDato(TabVariables, String.Format(CampoTabVariables + "='{0}' And Variable='{1}' ", SecContratoLiquida, ColumnasVP.Rows(i)("Sec").ToString), ObjetoApiNomina) Then
                            If GuardaNominaLiquidaVariables(ObjetoApiNomina, SecContratoLiquida, valorc2, ColumnasVP.Rows(i)("Sec").ToString) Then
                            Else
                                Return False
                            End If
                        Else
                            ActualizaNovedades = False
                            If GuardaNominaLiquidaVariables(ObjetoApiNomina, SecContratoLiquida, valorc2, ColumnasVP.Rows(i)("Sec").ToString) Then
                                ActualizaNovedades = True
                            Else
                                Return False
                            End If
                        End If
                    Next
                Else
                    Return False
                End If
            Next
        End If
        ActualizaNovedades = False
        gvLiquidaNomina.SelectRow(0)
        Return True
    End Function

    Private Sub btnLiquidar_Click(sender As Object, e As EventArgs) Handles btnLiquidar.Click
        'Using trans As New Transactions.TransactionScope
        'Using ObjetoApiNomina As New SqlClient.SqlConnection(CadConexionBdGeneral)
        'ObjetoApiNomina.Open()
        SMT_EjcutarComandoSql(ObjetoApiNomina, "set dateformat dmy", 0)
        Dim wait As New ClEspera
        Try
            If ValidaCampos() Then
                If HDevExpre.MsgSamit("Seguro que desea liquidar esta Liquidacion Extraordinaria?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.OK Then
                    wait.Mostrar()
                    wait.Descripcion = "Guardando Datos..."
                    EstaLiquidando = True
                    If GuardaBorrador(ObjetoApiNomina) Then
                        wait.Terminar()
                        HDevExpre.mensajeExitoso("Información guardada exitosamente!..")
                        LimpiarTodosCampos(ObjetoApiNomina)
                        EstaLiquidando = False
                        'trans.Complete()
                    Else
                        wait.Terminar()
                        HDevExpre.MensagedeError("Error al liquidar..!")
                        PasaValor = True
                        Exit Sub
                    End If
                End If
            End If
        Catch ex As Exception
            HDevExpre.MensagedeError("Error al liquidar..!")
            wait.Terminar()
            Exit Sub
        End Try
        'End Using
        'End Using
    End Sub
    Public Function ValidaCampos() As Boolean
        Dim res As Boolean = False
        Dim Tbla As DataTable = CType(gcLiquidaNomina.DataSource, DataTable)
        If Not Tbla.Rows.Count > 0 Then
            HDevExpre.MensagedeError("No se han encontrado empleados!..")
            res = False
        Else
            res = True

        End If
        Return res
    End Function


    Public Function GuardaNominaLiquidaExtraordinaria(Conexion As Object, parametros As String, ConceptosL As String) As Boolean
        Dim GenSql As New SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL

        Dim Tab As String = ""
        If EstaLiquidando Then
            GenSql.PasoConexionTabla(Conexion, "NominaLiquidaExtraordinaria")
            GenSql.PasoValores("FechaMod", Datos.Smt_FechaDelServidor.ToString("dd/MM/yyyy hh:MM:ss"), SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            GenSql.PasoValores("TerminalMod", Datos.Smt_NombreTerminal, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            GenSql.PasoValores("UsuMod", Datos.Smt_Usuario, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            GenSql.PasoValores("EsBorrador", "0", SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            GenSql.PasoValores("Estado", "L", SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            Tab = "NominaLiquidaExtraordinaria"

            If GenSql.EjecutarComandoNET(SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.SQLGenera.Actualizacion, String.Format("Sec={0}", SecNominaLiquida)) Then
                Return True
            Else : Return False
            End If
        Else
            GenSql.PasoConexionTabla(Conexion, "NominaLiquidaExtraordinaria")
            Tab = "NominaLiquidaExtraordinaria"
            GenSql.PasoValores("OfiNomina", CodOficina, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            GenSql.PasoValores("EsBorrador", "1", SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            GenSql.PasoValores("OfiRegistra", Datos.Seguridad.DatosDeLaEmpresa.NumEmpresa.ToString, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            GenSql.PasoValores("UsuCrea", Datos.Smt_Usuario, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            GenSql.PasoValores("FechaCrea", Fecha.ToString("dd/MM/yyyy hh:MM:ss"), SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            GenSql.PasoValores("TerminalCrea", Datos.Smt_NombreTerminal, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            GenSql.PasoValores("FechaSys", Datos.Smt_FechaDelServidor.ToString("dd/MM/yyyy hh:MM:ss"), SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            GenSql.PasoValores("ParametrosB", parametros, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            GenSql.PasoValores("Conceptos", ConceptosL, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            GenSql.PasoValores("Nomina", CodNomina, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            GenSql.PasoValores("Estado", "P", SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            GenSql.PasoValores("Contabilizada", "0", SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            Dim Sec = SMT_AbrirTabla(ObjetoApiNomina, "SELECT ISNULL( MAX (Sec),0)+1 AS Codigo FROM " + Tab).Rows(0)(0).ToString
            GenSql.PasoValores("Sec", Sec, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            If GenSql.EjecutarComandoNET(SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.SQLGenera.Insercion, "") Then
                SecNominaLiquida = Sec
                Return True
            Else : Return False
            End If
        End If
    End Function

    Public Function GuardaNominaLiquidaVariables(Conexion As Object, LiquidaContrato As String, Cantidad As String, Variable As String) As Boolean
        Dim GenSql As New SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL
        Dim Tab As String = ""
        GenSql.PasoConexionTabla(Conexion, "NominaLiquidaExtraordinariaVariables")
        GenSql.PasoValores("SecLiquidaContrato", LiquidaContrato, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
        Tab = "NominaLiquidaExtraordinariaVariables"
        GenSql.PasoValores("Cantidad", Cantidad, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
        GenSql.PasoValores("Variable", Variable, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)

        If ActualizaNovedades And Not EstaLiquidando Then
            If GenSql.EjecutarComandoNET(SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.SQLGenera.Actualizacion, String.Format("SecLiquidaContrato={0} And Variable={1}", LiquidaContrato, Variable)) Then
                Return True
            Else : Return False
            End If
        Else
            Dim Sec = SMT_AbrirTabla(ObjetoApiNomina, "SELECT ISNULL( MAX (Sec),0)+1 AS Codigo FROM " + Tab).Rows(0)(0).ToString
            GenSql.PasoValores("Sec", Sec, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            If GenSql.EjecutarComandoNET(SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.SQLGenera.Insercion, "") Then
                Return True
            Else : Return False
            End If
        End If
    End Function

    Public Function GuardaNominaLiquidaExtraordinariaContratos(Conexion As Object, Contrato As String, NominaLiquidaExtraordinaria As String, Total As String,
                                               CargoActual As String, TotalIngresos As String, TotalDeducciones As String, TotalDescuentos As String) As Boolean
        Dim GenSql As New SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL
        Dim Tab As String = "NominaLiquidaExtraordinariaContratos"
        GenSql.PasoConexionTabla(Conexion, "NominaLiquidaExtraordinariaContratos")
        GenSql.PasoValores("Contrato", Contrato, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
        GenSql.PasoValores("Total", Total, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
        GenSql.PasoValores("NominaLiquidaExtraordinaria", NominaLiquidaExtraordinaria, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
        GenSql.PasoValores("TotalIngresos", TotalIngresos, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
        GenSql.PasoValores("TotalDeducciones", TotalDeducciones, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
        GenSql.PasoValores("TotalDescuentosNomina", TotalDescuentos, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
        GenSql.PasoValores("CargoActual", CargoActual, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
        Dim Sec = SMT_AbrirTabla(ObjetoApiNomina, "SELECT ISNULL( MAX (Sec),0)+1 AS Codigo FROM  " + Tab).Rows(0)(0).ToString
        If EstaLiquidando Then
            If GenSql.EjecutarComandoNET(SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.SQLGenera.Actualizacion, String.Format("NominaLiquidaExtraordinaria={0} And Contrato={1}", NominaLiquidaExtraordinaria, Contrato)) Then
                Return True
            Else : Return False
            End If
        Else
            GenSql.PasoValores("Sec", Sec, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            If GenSql.EjecutarComandoNET(SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.SQLGenera.Insercion, "") Then
                Return True
            Else : Return False
            End If
        End If
    End Function

    Public Function GuardaNominaLiquidaExtraordinariaConceptos(Conexion As Object, LiquidaContrato As String, Valor As String, NomConcepto As String, SecConcepto As String, SecDescuento As String, Base As String, NomBase As String, EsDescuento As Boolean, Cuota As String) As Boolean
        Dim GenSql As New SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL
        Dim Tab As String = ""
        Dim TipoConcepto = ""
        GenSql.PasoConexionTabla(Conexion, "NominaLiquidaExtraordinariaConceptos")
        GenSql.PasoValores("LiquidaContrato", LiquidaContrato, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
        Tab = "NominaLiquidaExtraordinariaConceptos"

        If EsDescuento Then
            GenSql.PasoValores("SecConceptoP", SecConcepto, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            GenSql.PasoValores("SecConceptoP2", SecDescuento, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            If EstaLiquidando Then
                GenSql.PasoValores("Cuota", Cuota, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            End If
            TipoConcepto = "SecConceptoP"
        Else
            GenSql.PasoValores("SecConcepto", SecConcepto, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            TipoConcepto = "SecConcepto"
        End If
        GenSql.PasoValores("Valor", Valor, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
        GenSql.PasoValores("Base", Base, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
        GenSql.PasoValores("NomConcepto", NomConcepto, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
        GenSql.PasoValores("NomBase", NomBase, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
        Dim Sec = SMT_AbrirTabla(ObjetoApiNomina, "SELECT ISNULL( MAX (Sec),0)+1 AS Codigo FROM " + Tab).Rows(0)(0).ToString
        GenSql.PasoValores("Sec", Sec, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
        If GenSql.EjecutarComandoNET(SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.SQLGenera.Insercion, "") Then
            Return True
        Else : Return False
        End If
    End Function

    Public Function ModificaDescuentosPorNomina(Conexion As Object, SecDescuento As String, TotalDescontado As String, Vigente As String, Cuota As String) As Boolean
        Dim GenSql As New SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL
        Dim Cuo As Integer = CInt(Cuota) + 1
        GenSql.PasoConexionTabla(Conexion, "ConceptosP_Contratos")
        GenSql.PasoValores("Sec", SecDescuento, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
        GenSql.PasoValores("CuotaActual", Cuo.ToString, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
        GenSql.PasoValores("TotalDescontado", TotalDescontado, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
        GenSql.PasoValores("Vigente", Vigente, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
        If GenSql.EjecutarComandoNET(SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.SQLGenera.Actualizacion, String.Format("Sec={0} ", SecDescuento)) Then
            Return True
        Else : Return False
        End If
    End Function

    Private Sub FrmLiquidarNomina_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        FormularioAbierto = False
    End Sub

    Public Sub ConsultarLiquidacion(Secliquida As String, sql As String)
        Dim wait As New ClEspera
        wait.Mostrar()
        wait.Descripcion = "Buscando..."
        EstaLiquidando = False
        PasaValor = False
        'Using trans As New Transactions.TransactionScope
        'Using ObjetoApiNomina As New SqlClient.SqlConnection(CadConexionBdGeneral)
        'ObjetoApiNomina.Open()
        SMT_EjcutarComandoSql(ObjetoApiNomina, "set dateformat dmy", 0)
        Dim dt As New DataTable

        If ExisteDato("NominaLiquidaExtraordinaria", String.Format("Sec='{0}' ", Secliquida), ObjetoApiNomina) Then
            dt = SMT_AbrirTabla(ObjetoApiNomina, " Select FechaCrea From NominaLiquidaExtraordinaria WHERE Sec =" + Secliquida)
            If dt.Rows.Count = 0 Then
                HDevExpre.MensagedeError("Error cargando la fecha de creación de la nómina.")
                wait.Terminar()
                Exit Sub
            End If
            Fecha = CDate(dt.Rows(0)(0))
            Año = CUShort(CDate(Fecha).Year).ToString
            NumMes = CUShort(CDate(Fecha).Month).ToString
            If CInt(NumMes) > 6 Then
                NumSemestre = "2"
            Else
                NumSemestre = "1"
            End If
            SecNominaLiquida = Secliquida
            CodNomina = SMT_AbrirTabla(ObjetoApiNomina, " Select TOP 1 C.Nomina From NominaLiquidaExtraordinariaContratos NLC Inner Join NominaLiquidaExtraordinaria NL ON NLC.NominaLiquidaExtraordinaria = NL.Sec Inner Join Contratos C ON NLC.Contrato = C.CodContrato WHERE NL.Sec =" + Secliquida).Rows(0)(0).ToString
            ConsultaDatos(ObjetoApiNomina)
            Dim parametros = SMT_AbrirTabla(ObjetoApiNomina, "SELECT ParametrosB AS parametros FROM NominaLiquidaExtraordinaria Where sec=" + Secliquida).Rows(0)(0).ToString
            sql = " Select Asignacion,CodContrato,HorasMes,CargoActual from Contratos C INNER JOIN Contrato_Cargos CC ON C.CargoActual = CC.SecCargos where" + parametros
            dt = SMT_AbrirTabla(ObjetoApiNomina, sql)
            ContratosALiquidar = dt
            If dt.Rows.Count > 0 Then
                Dim encontro As Boolean = False
                Dim tabla As DataTable = CType(gcLiquidaNomina.DataSource, DataTable)
                If dt.Rows.Count > 0 Then
                    For incre As Integer = 0 To dt.Rows.Count - 1
                        encontro = False
                        Dim ConsulEmple As DataTable = SMT_AbrirTabla(ObjetoApiNomina, "SELECT CN.Sec AS Codigo FROM NominaLiquidaExtraordinariaContratos CN Inner join NominaLiquidaExtraordinaria NL on CN.NominaLiquidaExtraordinaria = NL.Sec Where CN.Contrato=" + dt.Rows(incre)("CodContrato").ToString + " And NL.Sec =" + Secliquida)
                        If ConsulEmple.Rows.Count > 0 Then
                            encontro = True
                        End If

                        If Not encontro Then

                            If GuardaNominaLiquidaExtraordinariaContratos(ObjetoApiNomina, dt.Rows(incre)("CodContrato").ToString, Secliquida, "0",
                                                                    dt.Rows(incre)("CargoActual").ToString, "0", "0", "0") Then
                                encontro = False
                            Else
                                PasaValor = True
                                PasarValores()
                                wait.Terminar()
                                Exit Sub
                            End If
                        End If
                    Next
                Else
                    For incre As Integer = 0 To dt.Rows.Count - 1
                        If GuardaNominaLiquidaExtraordinariaContratos(ObjetoApiNomina, dt.Rows(incre)("CodContrato").ToString, Secliquida, "0",
                                                                dt.Rows(incre)("CargoActual").ToString, "0", "0", "0") Then
                        Else
                            PasaValor = True
                            PasarValores()
                            wait.Terminar()
                            Exit Sub
                        End If
                    Next
                End If
            Else
                HDevExpre.MensagedeError("No se han encontrato Empleados para esta nomina!..")
                PasaValor = True
                PasarValores()
                wait.Terminar()
                Exit Sub
            End If
        Else
            Año = CUShort(CDate(Fecha).Year).ToString
            NumMes = CUShort(CDate(Fecha).Month).ToString
            If CInt(NumMes) > 6 Then
                NumSemestre = "2"
            Else
                NumSemestre = "1"
            End If
            Dim parametros As String = sql
            Dim ConceptosL As String = ""
            For incre As Integer = 0 To ConceptosContrato.Rows.Count - 1
                If incre < ConceptosContrato.Rows.Count - 1 Then
                    ConceptosL = ConceptosL + ConceptosContrato.Rows(incre)("Nombre").ToString + ","

                Else
                    ConceptosL = ConceptosL + ConceptosContrato.Rows(incre)("Nombre").ToString
                End If
            Next

            If GuardaNominaLiquidaExtraordinaria(ObjetoApiNomina, parametros, ConceptosL) Then
                sql = " Select Asignacion,CodContrato,HorasMes,CargoActual from Contratos C INNER JOIN Contrato_Cargos CC ON C.CargoActual = CC.SecCargos where " + sql
                dt = SMT_AbrirTabla(ObjetoApiNomina, sql)
                ContratosALiquidar = dt
                If dt.Rows.Count > 0 Then
                    For incre As Integer = 0 To dt.Rows.Count - 1
                        If GuardaNominaLiquidaExtraordinariaContratos(ObjetoApiNomina, dt.Rows(incre)("CodContrato").ToString, SecNominaLiquida, "0",
                                                                dt.Rows(incre)("CargoActual").ToString, "0", "0", "0") Then

                        Else
                            PasaValor = True
                            PasarValores()
                            wait.Terminar()
                            Exit Sub
                        End If
                    Next
                Else
                    HDevExpre.MensagedeError("No se han encontrato Empleados para esta nomina!..")
                    PasaValor = True
                    PasarValores()
                    wait.Terminar()
                    Exit Sub
                End If
            Else
                PasaValor = True
                PasarValores()
                wait.Terminar()
                Exit Sub
            End If
        End If
        ConsultaDatos(ObjetoApiNomina)
        'trans.Complete()
        'End Using
        'End Using
        PasaValor = True
        If gvLiquidaNomina.RowCount > 0 Then
            CreagrillaVerticalID(ObjetoApiNomina, gvLiquidaNomina.GetFocusedRowCellValue("CodContrato").ToString)
            PasarValores()
            CreagrillaVerticalDPN()
        End If
        wait.Terminar()
    End Sub

    Private Sub AbreBusqueda()
        Dim sql As String = "Select NL.Sec As Codigo,convert(date ,NL.FechaCrea) As Descripcion From NominaLiquidaExtraordinaria NL " &
                           " Where NL.EsBorrador = 1 "
        Dim frm As New FrmBusqueda(sql, "Liquidaciones Pendientes", , , "Codigo", "Fecha", "LiquidarNominaExtraordinaria")
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
        If gvLiquidaNomina.RowCount > 0 Then
            gcLiquidaNomina.Focus()
        End If
    End Sub

    Private Sub gvLiquidaNomina_ValidatingEditor(sender As Object, e As BaseContainerValidateEditorEventArgs) Handles gvLiquidaNomina.ValidatingEditor
        'Dim valormaximo As Decimal = 0
        'For incre As Integer = 0 To ColumnasVP.Rows.Count - 1
        '    If gvLiquidaNomina.FocusedColumn.Name = ColumnasVP.Rows(incre)("Nombre").ToString Then
        '        If ColumnasVP.Rows(incre)("ValorMaximo").ToString <> "" Then
        '            valormaximo = CDec(ColumnasVP.Rows(incre)("ValorMaximo").ToString)
        '        End If
        '    End If
        'Next
        'If gvLiquidaNomina.FocusedColumn.Name <> "Comentario" Then
        '    Dim cadena As String = e.Value.ToString
        '    Dim Caracter As Char = Nothing
        '    If cadena <> "" Then
        '        For incre As Integer = 0 To cadena.Length - 1
        '            Caracter = CChar(cadena.Substring(incre, 1))
        '            If Not IsNumeric(Caracter) And Asc(Caracter) <> 46 Then
        '                e.Value = 0
        '                Exit For
        '                Exit Sub
        '            End If
        '        Next
        '        Dim valor As Decimal = CDec(e.Value)
        '        If valor > valormaximo Then
        '            e.ErrorText = "El valor que esta tratando de ingresar es superior a " + valormaximo.ToString("C2")
        '            e.Valid = False
        '        End If
        '    Else
        '        e.Value = 0
        '        Exit Sub
        '    End If
        'End If
    End Sub

    Public Function Redondear(Valor As Decimal, NumerodeDecimales As Integer, Denominador_a_Redondear As Decimal) As Decimal
        Dim Residuo As Decimal, ValorEntero As Decimal, ValorCompleto As Decimal, ParteDecimal As Double
        If Denominador_a_Redondear <= 0 Then Denominador_a_Redondear = 1
        If NumerodeDecimales <= 0 Then NumerodeDecimales = 0
        ValorEntero = Fix(Valor / Denominador_a_Redondear)
        ValorCompleto = Valor / Denominador_a_Redondear
        Residuo = Fix((ValorCompleto - ValorEntero) * 100)
        If NumerodeDecimales = 0 Or Denominador_a_Redondear <> 1 Then
            If Residuo > 50 Then
                Redondear = (ValorEntero * Denominador_a_Redondear) + (1 * Denominador_a_Redondear)
            Else
                Redondear = ValorEntero * Denominador_a_Redondear
            End If
        Else
            Redondear = ValorEntero
        End If
        If NumerodeDecimales > 0 And Denominador_a_Redondear = 1 Then
            Residuo = CDec((Residuo / 100) * (10 ^ NumerodeDecimales))
            ValorEntero = Fix(Residuo / Denominador_a_Redondear)
            ValorCompleto = Residuo / Denominador_a_Redondear
            Residuo = (ValorCompleto - ValorEntero) * 100
            If Residuo > 50 Then
                ParteDecimal = ((ValorEntero * Denominador_a_Redondear) + (1 * Denominador_a_Redondear) / 100)
            Else
                ParteDecimal = (ValorEntero * Denominador_a_Redondear / 100)
            End If
        End If

        Redondear = CDec(Redondear + ParteDecimal)
    End Function

    Private Sub gvLiquidaNomina_CustomUnboundColumnData(sender As Object, e As Views.Base.CustomColumnDataEventArgs) Handles gvLiquidaNomina.CustomUnboundColumnData
        Dim nomcol As String = e.Column.ToString
        Dim cadena As String = ""
        If e.Value Is Nothing Then
        Else
            cadena = e.Value.ToString
        End If
        If e.Value Is Nothing Then
            e.Value = 0
        ElseIf cadena = "#Err" Then
        Else
            Dim Val As Decimal = CDec(e.Value)
            Dim unidadRedondeo As Integer = 0
            For incre As Integer = 0 To Conceptos.Rows.Count - 1
                If nomcol = Conceptos.Rows(incre)("Nombre").ToString Then
                    unidadRedondeo = CInt(Conceptos.Rows(incre)("Redondea"))
                    Val = Redondear(Val, 0, unidadRedondeo)
                    Exit For
                End If
            Next
            e.Value = Val

            'If vgDescPorNomina.GetCellValue(vgDescPorNomina.Rows.GetRowByFieldName(nomcol), 0) Is Nothing Then
            'Else
            '    Dim dtID As DataTable = CType(vgIngresosDeducciones.DataSource, DataTable)
            '    dtID.Rows(0)(nomcol) = e.Value.ToString
            'End If
        End If
    End Sub

    Private Sub btnNuevaLiquidacion_Click(sender As Object, e As EventArgs) Handles btnNuevaLiquidacion.Click
        FrmConsultaLiquidaExtraordinarias.Fomulario = "LiquidacionExtraordinaria"
        FrmConsultaLiquidaExtraordinarias.ShowDialog()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If ExisteDato("NominaLiquidaExtraordinaria", String.Format("EsBorrador='{0}'", "1"), ObjetoApiNomina) Then
            AbreBusqueda()
        Else
            HDevExpre.MensagedeError("No se han encontrado Borradores!..")
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If SecNominaLiquida <> "" Then
            If HDevExpre.MsgSamit("Seguro que desea eliminar esta liquidacion?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.OK Then
                'Using trans As New Transactions.TransactionScope
                'Using ObjetoApiNomina As New SqlClient.SqlConnection(CadConexionBdGeneral)
                'ObjetoApiNomina.Open()
                SMT_EjcutarComandoSql(ObjetoApiNomina, "set dateformat dmy", 0)
                        Dim wait As New ClEspera
                        wait.Mostrar()
                        wait.Descripcion = "Eliminando Datos..."
                        If EliminarBorrador(ObjetoApiNomina) Then
                            LimpiarTodosCampos(ObjetoApiNomina)
                            wait.Terminar()
                    'trans.Complete()
                    HDevExpre.mensajeExitoso("La liquidacion ha sido eliminada correctamente!..")
                        Else
                            Exit Sub
                            wait.Terminar()
                        End If
                'End Using
                'End Using
            End If
        End If
    End Sub

    Public Function EliminarBorrador(Conexion As Object) As Boolean

        SecNominaLiquida = SMT_AbrirTabla(ObjetoApiNomina, "SELECT Sec AS Codigo FROM NominaLiquidaExtraordinaria Where Sec =" + SecNominaLiquida).Rows(0)(0).ToString
        Dim sql As String = "Select NLV.Sec From NominaLiquidaExtraordinariaVariables NLV INNER JOIN NominaLiquidaExtraordinariaContratos NLC  ON NLV.SecLiquidaContrato = NLC.Sec WHERE NLC.NominaLiquidaExtraordinaria=" + SecNominaLiquida
        Dim dt As DataTable = SMT_AbrirTabla(ObjetoApiNomina, sql)
        If dt.Rows.Count > 0 Then
            If SMT_EjcutarComandoSqlBool(ObjetoApiNomina, String.Format("Delete NominaLiquidaExtraordinariaVariables From NominaLiquidaExtraordinariaVariables NLV INNER JOIN NominaLiquidaExtraordinariaContratos NLC  ON NLV.SecLiquidaContrato = NLC.Sec WHERE NLC.NominaLiquidaExtraordinaria={0}", SecNominaLiquida)) > 0 Then

            Else
                Return False
            End If
        End If

        sql = "Select NLCC.Sec From NominaLiquidaExtraordinariaConceptos NLCC INNER JOIN NominaLiquidaExtraordinariaContratos NLC  ON NLCC.LiquidaContrato = NLC.Sec WHERE NLC.NominaLiquidaExtraordinaria=" + SecNominaLiquida
        dt = SMT_AbrirTabla(ObjetoApiNomina, sql)
        If dt.Rows.Count > 0 Then
            If SMT_EjcutarComandoSqlBool(ObjetoApiNomina, String.Format("Delete NominaLiquidaExtraordinariaConceptos From NominaLiquidaExtraordinariaConceptos NLCC INNER JOIN NominaLiquidaExtraordinariaContratos NLC  ON NLCC.LiquidaContrato = NLC.Sec WHERE NLC.NominaLiquidaExtraordinaria={0}", SecNominaLiquida)) > 0 Then

            Else
                Return False
            End If
        End If

        sql = "Select Sec From NominaLiquidaExtraordinariaContratos  WHERE NominaLiquidaExtraordinaria=" + SecNominaLiquida
        dt = SMT_AbrirTabla(ObjetoApiNomina, sql)
        If dt.Rows.Count > 0 Then
            If SMT_EjcutarComandoSqlBool(ObjetoApiNomina, String.Format("Delete From NominaLiquidaExtraordinariaContratos  WHERE NominaLiquidaExtraordinaria={0}", SecNominaLiquida)) > 0 Then

            Else
                Return False
            End If
        End If

        If SMT_EjcutarComandoSqlBool(ObjetoApiNomina, String.Format("Delete From NominaLiquidaExtraordinaria Where Sec={0}", SecNominaLiquida)) > 0 Then
        Else
            Return False
        End If
        Return True
    End Function

    Private Sub btnEliminar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles btnSalir.KeyPress, btnNuevaLiquidacion.KeyPress, btnLiquidar.KeyPress, btnLimpiar.KeyPress, btnEliminar.KeyPress, btnBuscar.KeyPress
        HDevExpre.AtrasConScape(e)
    End Sub

End Class