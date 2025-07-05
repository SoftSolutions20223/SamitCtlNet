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
Imports System.IO

Public Class FrmConsultaPeriodosL
    Public SecNominaLiquida As String = ""
    Dim IndexRow As String = ""
    Dim PlantillaContra As String = ""
    Dim ActualizaNovedades As Boolean = False
    Dim ColumnasVP As New DataTable
    Dim ColumnasVG As New DataTable
    Dim Conceptos As New DataTable
    Dim ConceptosPersonales As New DataTable
    Dim ConceptosPlantillas As New DataTable
    Dim Bases As New DataTable
    Dim ConceptosContrato As New DataTable
    Dim ConceptosAtadosAlContrato As New DataTable
    Dim ConceptosAtadosAlContratoLiquida As New DataTable
    Dim CamposCalculados As New DataTable
    Dim ValoresMaximosaDescontar As New DataTable
    Public CodNomina As String
    Dim SecContratoLiquida As String
    Dim FormularioAbierto As Boolean = False
    Dim EstaLiquidando As Boolean = False
    Dim PasaValor As Boolean = True
    Public Memo As New RepositoryItemMemoExEdit
    Public NomLiquida As String = ""
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

    Private Sub FrmCalcularNomina_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AsignaScriptAcontroles()
        Memo.SuppressMouseEventOnOuterMouseClick = True
        AcomodaForm()
        ConsultaDatos(ObjetoApiNomina)
        If gvLiquidaNomina.RowCount > 0 Then
            Dim dtos = CType(gcLiquidaNomina.DataSource, DataTable)
            CreagrillaVerticalID(ObjetoApiNomina, gvLiquidaNomina.GetFocusedRowCellValue("CodContrato").ToString, gvLiquidaNomina.GetFocusedRowCellValue("PlantillaEmpl").ToString, gvLiquidaNomina.GetFocusedRowCellValue("ConceptosContratos").ToString)
        End If
        CreagrillaVerticalP()
        PasarValores()
        CreagrillaVerticalDPN()
    End Sub

    Private Sub AcomodaForm()
        Try
            btnSalir.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.SalirCuadroConX)
            BtnExcell.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Excell_XlsX)
            Dim classResize As New ClaseResize
            classResize.Resizagrid(gvLiquidaNomina)
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, " AcomodaForm Contrato")
        End Try
    End Sub


    Private Sub AsignaScriptAcontroles()
        Try

            'txtDependencia.ConsultaSQL = String.Format("SELECT Sec AS Codigo,NomDependencia As Descripcion FROM  Dependencias where Vigente = 1")

            'txtCargos.ConsultaSQL = String.Format("SELECT SecCargo AS Codigo,Denominacion As Descripcion FROM  cargos")
            Dim consultas() As String = {
    "select NomVariable as Nombre,ValorMaximo as ValorMaximo,ValorDefecto As ValorDefecto,Sec as Sec, EsPredeterminado, vigente from VariablesPersonales WHERE EsPredeterminado = 1 OR (vigente = 1 AND EsPredeterminado = 0)",
    "select NomBase as Nombre,Formula from BasesConceptos",
    "select CN.NomConcepto as Nombre,CCN.Formula,CN.Base,CN.Redondea,CCN.Nomina from ConceptosNomina CN INNER JOIN ConfigConceptos CCN ON CCN.Concepto = CN.Sec",
    "select NomConcepto as Nombre,ValMaxDescuento As Formula from ConceptosPersonales",
    "select NomPlantilla as Nombre,ValorMaxDescontar as Formula from Plantillas",
    "WITH VariablesConFechaMax AS ( SELECT VG.Sec AS Variable,VG.NomVariable AS Nombre,VGD.Fecha,VGD.Valor,ROW_NUMBER() OVER (PARTITION BY VG.Sec ORDER BY VGD.Fecha DESC) AS rn FROM DetallesVariablesGenerales VGD INNER JOIN VariablesGenerales VG ON VGD.Variable = VG.Sec) SELECT Variable, Nombre, Fecha, Valor FROM VariablesConFechaMax WHERE rn = 1"
}
            Dim Datos = SMT_GetDataset(ObjetoApiNomina, consultas)
            ColumnasVP = Datos.Tables(0)
            Bases = Datos.Tables(1)
            Conceptos = Datos.Tables(2)
            ConceptosPersonales = Datos.Tables(3)
            ValoresMaximosaDescontar = Datos.Tables(4)
            ColumnasVG = Datos.Tables(5)

            ConceptosContrato.Columns.Add("Nombre", GetType(String))
            ConceptosContrato.Columns.Add("Formula", GetType(String))
            ConceptosContrato.Columns.Add("Tipo", GetType(String))
            ConceptosContrato.Columns.Add("Base", GetType(String))
            ConceptosContrato.Columns.Add("Sec", GetType(String))
            ConceptosAtadosAlContratoLiquida.Columns.Add("Nombre", GetType(String))
            ConceptosAtadosAlContratoLiquida.Columns.Add("Formula", GetType(String))
            ConceptosAtadosAlContratoLiquida.Columns.Add("Tipo", GetType(String))
            ConceptosAtadosAlContratoLiquida.Columns.Add("SecDescuento", GetType(String))
            ConceptosAtadosAlContratoLiquida.Columns.Add("SecConcepto", GetType(String))
            CamposCalculados.Columns.Add("Nombre", GetType(String))
            CamposCalculados.Columns.Add("Tipo", GetType(String))
            CamposCalculados.Columns.Add("Formula", GetType(String))
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "AsignaScriptAcontroles")
        End Try
    End Sub

    Private Sub AbreBusqueda()
        Dim sql As String = "Select NL.Sec As Codigo,N.NomNomina +'   '+P.Descripcion As Descripcion From NominaLiquida NL INNER JOIN PeriodosLiquidacion P ON NL.Periodo = P.Sec " &
                           " INNER JOIN Nominas N ON P.Nomina = N.SecNomina Where NL.EsBorrador = 1 "
        Dim frm As New FrmBusqueda(sql, "Borradores", , , "Codigo", "Descripcion", "LiquidarNomina")
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

    Private Function ObtieneTextoEntrePalabras(Val As String, PalabraIni As String, PalabraFin As String) As String
        Dim nIndexStart As Integer = Val.IndexOf(PalabraIni)
        Dim nIndexEnd As Integer = Val.IndexOf(PalabraFin)
        If nIndexStart > -1 AndAlso nIndexEnd > -1 Then
            Dim res As String = Strings.Mid(Val, nIndexStart + PalabraIni.Length + 1, nIndexEnd + 1 - nIndexStart - PalabraFin.Length)
            Return res
        Else
            Return ""
        End If
    End Function

    Private Function xmladatatablePlantillas(xmlString As String) As DataTable
        xmlString = xmlString.Replace("</Fila>", "")
        Dim Filas = Split(xmlString, "<Fila>")
        Dim DatatableReturn As New DataTable
        DatatableReturn.Columns.Add("Nombre", GetType(String))
        DatatableReturn.Columns.Add("Formula", GetType(Decimal))
        DatatableReturn.Columns.Add("Tipo", GetType(String))
        DatatableReturn.Columns.Add("Sec", GetType(String))
        DatatableReturn.Columns.Add("PeriodosLiquida", GetType(String))
        DatatableReturn.Columns.Add("Plantilla", GetType(String))
        DatatableReturn.Columns.Add("Base", GetType(Decimal))
        For Each Fila As String In Filas
            If Fila <> "" Then
                Dim Nommbre = ObtieneTextoEntrePalabras(Fila, "<Nombre>", "</Nombre>")
                Dim Formula = ObtieneTextoEntrePalabras(Fila, "<Formula>", "</Formula>")
                Dim Tipo = ObtieneTextoEntrePalabras(Fila, "<Tipo>", "</Tipo>")
                Dim Sec = ObtieneTextoEntrePalabras(Fila, "<Sec>", "</Sec>")
                Dim PeriodosLiquida = ObtieneTextoEntrePalabras(Fila, "<PeriodosLiquida>", "</PeriodosLiquida>")
                Dim Plantilla = ObtieneTextoEntrePalabras(Fila, "<PlantillaEmpl>", "</PlantillaEmpl>")
                Dim Base = ObtieneTextoEntrePalabras(Fila, "<Base>", "</Base>")
                Dim Row As DataRow = DatatableReturn.NewRow()
                Row("Nombre") = Nommbre
                Row("Formula") = Formula
                Row("Tipo") = Tipo
                Row("Sec") = Sec
                Row("PeriodosLiquida") = PeriodosLiquida
                Row("Plantilla") = Plantilla
                Row("Base") = Base
                DatatableReturn.Rows.Add(Row)
                DatatableReturn.AcceptChanges()
            End If
        Next
        Return DatatableReturn
    End Function

    Private Function xmladatatableConceptos(xmlString As String) As DataTable
        xmlString = xmlString.Replace("</Fila>", "")
        Dim Filas = Split(xmlString, "<Fila>")
        Dim DatatableReturn As New DataTable
        DatatableReturn.Columns.Add("SecDescuento", GetType(String))
        DatatableReturn.Columns.Add("DescontarPeriodo", GetType(String))
        DatatableReturn.Columns.Add("TotalDescontar", GetType(String))
        DatatableReturn.Columns.Add("TotalDescontado", GetType(String))
        DatatableReturn.Columns.Add("NomConcepto", GetType(String))
        DatatableReturn.Columns.Add("PeriodosLiquida", GetType(String))
        DatatableReturn.Columns.Add("SecConcepto", GetType(String))
        DatatableReturn.Columns.Add("ValMaxDescuento", GetType(String))
        DatatableReturn.Columns.Add("Clasificacion", GetType(String))
        For Each Fila As String In Filas
            If Fila <> "" And Fila <> "NoConceptos" Then
                Dim SecDescuento = ObtieneTextoEntrePalabras(Fila, "<SecDescuento>", "</SecDescuento>")
                Dim DescontarPeriodo = ObtieneTextoEntrePalabras(Fila, "<DescontarPeriodo>", "</DescontarPeriodo>")
                Dim TotalDescontar = ObtieneTextoEntrePalabras(Fila, "<TotalDescontar>", "</TotalDescontar>")
                Dim TotalDescontado = ObtieneTextoEntrePalabras(Fila, "<TotalDescontado>", "</TotalDescontado>")
                Dim NomConcepto = ObtieneTextoEntrePalabras(Fila, "<NomConcepto>", "</NomConcepto>")
                Dim PeriodosLiquida = ObtieneTextoEntrePalabras(Fila, "<PeriodosLiquida>", "</PeriodosLiquida>")
                Dim SecConcepto = ObtieneTextoEntrePalabras(Fila, "<SecConcepto>", "</SecConcepto>")
                Dim ValMaxDescuento = ObtieneTextoEntrePalabras(Fila, "<ValMaxDescuento>", "</ValMaxDescuento>")
                Dim Clasificacion = ObtieneTextoEntrePalabras(Fila, "<Clasificacion>", "</Clasificacion>")
                Dim Row As DataRow = DatatableReturn.NewRow()
                Row("SecDescuento") = SecDescuento
                Row("DescontarPeriodo") = DescontarPeriodo
                Row("TotalDescontar") = TotalDescontar
                Row("TotalDescontado") = TotalDescontado
                Row("NomConcepto") = NomConcepto
                Row("PeriodosLiquida") = PeriodosLiquida
                Row("SecConcepto") = SecConcepto
                Row("ValMaxDescuento") = ValMaxDescuento
                Row("Clasificacion") = Clasificacion
                DatatableReturn.Rows.Add(Row)
                DatatableReturn.AcceptChanges()
            End If
        Next
        Return DatatableReturn
    End Function




    Private Sub CreagrillaVerticalID(Conexion As Object, CodContrato As String, ConceptsPlantilla As String, ConceptsContrato As String)
        vgIngresosDeducciones.Rows.Clear()
        ConceptosContrato.Rows.Clear()
        Try
            Dim sql = ""
            Dim filas As New DataTable
            Dim NuevaFila As DataRow = filas.NewRow()
            CreaFilas(vgIngresosDeducciones, "Ingresos", "Ingresos", True, True, "0", True, False, Nothing)
            CreaFilas(vgIngresosDeducciones, "Deducciones", "Deducciones", True, True, "0", True, False, Nothing)
            CreaFilas(vgIngresosDeducciones, "Total", "Total", True, True, "[Ingresos] - [Deducciones]", True, False, Nothing)
            ConceptosPlantillas = xmladatatablePlantillas(ConceptsPlantilla)

            ConceptosAtadosAlContrato = xmladatatableConceptos(ConceptsContrato)
            ConceptosAtadosAlContrato.Columns.Add("SeLiquida", GetType(String))

            If ConceptosPlantillas.Rows.Count > 0 Then

                PlantillaContra = ConceptosPlantillas.Rows(0)("Plantilla").ToString
                For incre As Integer = 0 To ConceptosPlantillas.Rows.Count - 1
                    If ConceptosPlantillas.Rows(incre)("Tipo").ToString = "Ingresos" Or ConceptosPlantillas.Rows(incre)("Tipo").ToString = "Deducciones" Then
                        Dim value As String = ConceptosPlantillas.Rows(incre)("PeriodosLiquida").ToString
                        Dim SeLiquida As Boolean = True
                        Dim delimitador As Char = ","c
                        Dim PeriodosL() As String = value.Split(delimitador)
                        Dim PeriodoLiq = ""
                        If value.Length > 1 Then

                        Else
                            PeriodoLiq = value
                        End If


                        SeLiquida = True


                        If SeLiquida Then
                            Dim categoria As EditorRow = TryCast(vgIngresosDeducciones.GetRowByCaption(ConceptosPlantillas.Rows(incre)("Tipo").ToString), EditorRow)
                            Dim exitConcep As Boolean = False
                            If ConceptosContrato.Rows.Count > 0 Then
                                For inc As Integer = 0 To ConceptosContrato.Rows.Count - 1
                                    If ConceptosContrato.Rows(inc)("Sec").ToString = ConceptosPlantillas.Rows(incre)("Sec").ToString Then
                                        exitConcep = True
                                        Exit For
                                    End If
                                Next
                            Else
                                exitConcep = False
                            End If
                            If Not exitConcep Then
                                Dim fila As DataRow = ConceptosContrato.NewRow()
                                fila("Nombre") = ConceptosPlantillas.Rows(incre)("Nombre").ToString
                                fila("Formula") = ""
                                fila("Tipo") = ConceptosPlantillas.Rows(incre)("Tipo").ToString
                                fila("Base") = ConceptosPlantillas.Rows(incre)("Base").ToString
                                fila("Sec") = ConceptosPlantillas.Rows(incre)("Sec").ToString
                                ConceptosContrato.Rows.Add(fila)
                                ConceptosContrato.AcceptChanges()
                            End If
                            exitConcep = False
                            Dim Formu As String = categoria.Properties.UnboundExpression
                            Formu = Formu + " + " + "[" + ConceptosPlantillas.Rows(incre)("Nombre").ToString + "]"
                            categoria.Properties.UnboundExpression = Formu
                            CreaFilas(vgIngresosDeducciones, ConceptosPlantillas.Rows(incre)("Nombre").ToString, ConceptosPlantillas.Rows(incre)("Nombre").ToString, True, True, "", True, True, categoria)
                            filas.Columns.Add(ConceptosPlantillas.Rows(incre)("Nombre").ToString, GetType(Decimal))
                            NuevaFila(ConceptosPlantillas.Rows(incre)("Nombre").ToString) = 0
                        End If
                    End If
                Next

            End If

            filas.Rows.Add(NuevaFila)
            filas.AcceptChanges()
            vgIngresosDeducciones.DataSource = filas

            Dim classResize As New ClaseResize
            classResize.ResizaVgridCatgorias(vgIngresosDeducciones)
            vgIngresosDeducciones.RowHeaderWidth = CInt((50 * (vgIngresosDeducciones.Width)) / 100)
            vgIngresosDeducciones.RecordWidth = CInt((50 * (vgIngresosDeducciones.Width)) / 100)
            Dim scrollvisible As Boolean = vgIngresosDeducciones.ScrollVisibility
            If scrollvisible Then
                vgIngresosDeducciones.RecordWidth = CInt((50 * (vgIngresosDeducciones.Width)) / 100 - 22)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CreagrillaVerticalDPN()
        vgDescPorNomina.Rows.Clear()
        ConceptosAtadosAlContratoLiquida.Rows.Clear()
        Try

            Dim filas As New DataTable
            Dim NuevaFila As DataRow = filas.NewRow()


            If ConceptosAtadosAlContrato.Rows.Count > 0 Then
                For incre As Integer = 0 To ConceptosAtadosAlContrato.Rows.Count - 1
                    Dim value As String = ConceptosAtadosAlContrato.Rows(incre)("PeriodosLiquida").ToString
                    Dim SeLiquida As Boolean = True
                    Dim delimitador As Char = ","c
                    Dim PeriodosL() As String = value.Split(delimitador)
                    Dim PeriodoLiq = ""


                    SeLiquida = True

                    If SeLiquida Then
                        'llena tabla de conceptos a liquidar
                        Dim fila As DataRow = ConceptosAtadosAlContratoLiquida.NewRow()
                        fila("Nombre") = ConceptosAtadosAlContrato.Rows(incre)("NomConcepto").ToString
                        fila("Formula") = ""
                        fila("Tipo") = "DPN"
                        fila("SecDescuento") = ConceptosAtadosAlContrato.Rows(incre)("SecDescuento").ToString
                        fila("SecConcepto") = ConceptosAtadosAlContrato.Rows(incre)("SecConcepto").ToString
                        ConceptosAtadosAlContrato.Rows(incre)("SeLiquida") = "Si"
                        ConceptosAtadosAlContratoLiquida.Rows.Add(fila)
                        ConceptosAtadosAlContratoLiquida.AcceptChanges()
                        '---------------------------------
                    Else
                        ConceptosAtadosAlContrato.Rows(incre)("SecConcepto") = "No"
                    End If
                Next

            End If

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

                Next

                For incre As Integer = 0 To ConceptosAtadosAlContrato.Rows.Count - 1
                    If ConceptosAtadosAlContrato.Rows.Count > 1 Then
                        Dim nueva = ""
                    End If
                    Dim categoria As EditorRow = TryCast(vgDescPorNomina.GetRowByCaption(ConceptosAtadosAlContrato.Rows(incre)("Clasificacion").ToString), EditorRow)
                    Dim Formu As String = categoria.Properties.UnboundExpression
                    Formu = Formu + " + " + "[" + ConceptosAtadosAlContrato.Rows(incre)("NomConcepto").ToString + ConceptosAtadosAlContrato.Rows(incre)("SecDescuento").ToString + "]"
                    categoria.Properties.UnboundExpression = Formu
                    CreaFilas(vgDescPorNomina, ConceptosAtadosAlContrato.Rows(incre)("NomConcepto").ToString + ConceptosAtadosAlContrato.Rows(incre)("SecDescuento").ToString, ConceptosAtadosAlContrato.Rows(incre)("NomConcepto").ToString, True, True, "", True, True, categoria)
                    filas.Columns.Add(ConceptosAtadosAlContrato.Rows(incre)("NomConcepto").ToString + ConceptosAtadosAlContrato.Rows(incre)("SecDescuento").ToString, GetType(Decimal))
                    NuevaFila(ConceptosAtadosAlContrato.Rows(incre)("NomConcepto").ToString + ConceptosAtadosAlContrato.Rows(incre)("SecDescuento").ToString) = ConceptosAtadosAlContrato.Rows(incre)("DescontarPeriodo")
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

    Private Sub CreagrillaVerticalP()
        vgProviciones.Rows.Clear()
        Try

            Dim filas As New DataTable
            Dim NuevaFila As DataRow = filas.NewRow()
            'TiposConceptos(Categorias)
            CreaFilas(vgProviciones, "Provisiones", "Provisiones", True, True, "0", True, False, Nothing)


            If ConceptosPlantillas.Rows.Count > 0 Then
                For incre As Integer = 0 To ConceptosPlantillas.Rows.Count - 1

                    If ConceptosPlantillas.Rows(incre)("Tipo").ToString = "Provisiones" Then
                        Dim value As String = ConceptosPlantillas.Rows(incre)("PeriodosLiquida").ToString
                        Dim SeLiquida As Boolean = True
                        Dim delimitador As Char = ","c
                        Dim PeriodosL() As String = value.Split(delimitador)
                        Dim PeriodoLiq = ""
                        If value.Length > 1 Then

                        Else
                            PeriodoLiq = value
                        End If


                        SeLiquida = True

                        If SeLiquida Then
                            Dim categoria As EditorRow = TryCast(vgProviciones.GetRowByCaption(ConceptosPlantillas.Rows(incre)("Tipo").ToString), EditorRow)
                            Dim exitConcep As Boolean = False
                            If ConceptosContrato.Rows.Count > 0 Then
                                For inc As Integer = 0 To ConceptosContrato.Rows.Count - 1
                                    If ConceptosContrato.Rows(inc)("Sec").ToString = ConceptosPlantillas.Rows(incre)("Sec").ToString Then
                                        exitConcep = True
                                        Exit For
                                    End If
                                Next
                            Else
                                exitConcep = False
                            End If
                            If Not exitConcep Then
                                Dim fila As DataRow = ConceptosContrato.NewRow()
                                fila("Nombre") = ConceptosPlantillas.Rows(incre)("Nombre").ToString
                                fila("Formula") = ""
                                fila("Tipo") = ConceptosPlantillas.Rows(incre)("Tipo").ToString
                                fila("Base") = ConceptosPlantillas.Rows(incre)("Base").ToString
                                fila("Sec") = ConceptosPlantillas.Rows(incre)("Sec").ToString
                                ConceptosContrato.Rows.Add(fila)
                                ConceptosContrato.AcceptChanges()
                            End If
                            exitConcep = False
                            Dim Formu As String = categoria.Properties.UnboundExpression
                            Formu = Formu + " + " + "[" + ConceptosPlantillas.Rows(incre)("Nombre").ToString + "]"
                            categoria.Properties.UnboundExpression = Formu
                            CreaFilas(vgProviciones, ConceptosPlantillas.Rows(incre)("Nombre").ToString, ConceptosPlantillas.Rows(incre)("Nombre").ToString, True, True, ConceptosPlantillas.Rows(incre)("Formula").ToString, True, True, categoria)
                            filas.Columns.Add(ConceptosPlantillas.Rows(incre)("Nombre").ToString, GetType(Decimal))
                            NuevaFila(ConceptosPlantillas.Rows(incre)("Nombre").ToString) = 0
                        End If
                    End If
                Next

            End If
            filas.Rows.Add(NuevaFila)
            filas.AcceptChanges()
            vgProviciones.DataSource = filas
            Dim classResize As New ClaseResize
            classResize.ResizaVgridCatgorias(vgProviciones)
            vgProviciones.RowHeaderWidth = CInt((50 * (vgProviciones.Width)) / 100)
            vgProviciones.RecordWidth = CInt((50 * (vgProviciones.Width)) / 100 - 5)
        Catch ex As Exception

        End Try
    End Sub


    Private Sub Creagrillahorizontal()
        gvLiquidaNomina.Columns.Clear()
        Dim sql As String = ""
        Dim filas As New DataTable
        Dim NuevaFila As DataRow = filas.NewRow()
        Dim dt As New DataTable
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
        CreaColumnas(gvLiquidaNomina, "Comentario", "Comentario", True, True, "", coloor, False, 5, gcLiquidaNomina.Width, True)
        dt.Columns.Add("Comentario", GetType(String))
        CreaColumnas(gvLiquidaNomina, "Asignacion", "Asignacion", True, False, "", coloor, True, 8, gcLiquidaNomina.Width, False)
        dt.Columns.Add("NominaLiquidaContrato", GetType(String))
        dt.Columns.Add("HorasMes", GetType(Decimal))
        dt.Columns.Add("Asignacion", GetType(Decimal))
        dt.Columns.Add("RentaExenta", GetType(Decimal))
        dt.Columns.Add("TotalPagadoMes", GetType(Decimal))
        dt.Columns.Add("DescuentosPorNomina", GetType(Decimal))
        dt.Columns.Add("SalarioPromedioMensualAnual", GetType(Decimal))
        dt.Columns.Add("SalarioPromedioMensualSemestral", GetType(Decimal))
        dt.Columns.Add("NetoAPagar", GetType(Decimal))
        dt.Columns.Add("TotalIngresos", GetType(Decimal))
        dt.Columns.Add("TotalDeducciones", GetType(Decimal))
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
        CreaColumnas(gvLiquidaNomina, "SalarioPromedioMensualAnual", "SalarioPromedioMensualAnual", False, False, "", coloor, True, 0, 0, False)
        CreaColumnas(gvLiquidaNomina, "SalarioPromedioMensualSemestral", "SalarioPromedioMensualSemestral", False, False, "", coloor, True, 0, 0, False)
        CreaColumnas(gvLiquidaNomina, "TotalPagadoMes", "TotalPagadoMes", False, False, "", coloor, True, 0, 0, False)
        CreaColumnas(gvLiquidaNomina, "NetoAPagar", "NetoAPagar", False, False, "", coloor, True, 0, 0, False)
        CreaColumnas(gvLiquidaNomina, "TotalIngresos", "TotalIngresos", False, False, "", coloor, True, 0, 0, False)
        CreaColumnas(gvLiquidaNomina, "TotalDeducciones", "TotalDeducciones", False, False, "", coloor, True, 0, 0, False)
        CreaColumnas(gvLiquidaNomina, "DescuentosPorNomina", "DescuentosPorNomina", False, False, "", coloor, True, 0, 0, False)
        CreaColumnas(gvLiquidaNomina, "PlantillaEmpl", "PlantillaEmpl", False, False, "", coloor, False, 0, 0, False)
        dt.Columns.Add("PlantillaEmpl", GetType(String))
        CreaColumnas(gvLiquidaNomina, "ConceptosContratos", "ConceptosContratos", False, False, "", coloor, False, 0, 0, False)
        dt.Columns.Add("ConceptosContratos", GetType(String))
        If ColumnasVP.Rows.Count > 0 Then
            Dim sasf As System.Drawing.Color = Color.FromArgb(&HFF, &HE3, &HDB)
            For incre As Integer = 0 To ColumnasVP.Rows.Count - 1
                dt.Columns.Add(ColumnasVP.Rows(incre)("Nombre").ToString, GetType(Decimal))
                CreaColumnas(gvLiquidaNomina, ColumnasVP.Rows(incre)("Nombre").ToString, ColumnasVP.Rows(incre)("Nombre").ToString, True, True, "", sasf, True, 20, gcLiquidaNomina.Width, False)
                'For I As Integer = 0 To dt.Columns.Count - 1
                '    '    If dt.Columns(I).ColumnName.ToString = ColumnasVP.Rows(incre)("Nombre").ToString Then

                '    '    End If
                '    'Next
                'Next
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

        If Conceptos.Rows.Count > 0 Then
            For incre As Integer = 0 To Conceptos.Rows.Count - 1
                Dim sasf As System.Drawing.Color = Color.FromArgb(&HB1, &HF3, &HDA)
                CreaColumnas(gvLiquidaNomina, Conceptos.Rows(incre)("Nombre").ToString, Conceptos.Rows(incre)("Nombre").ToString, True, False, Conceptos.Rows(incre)("Formula").ToString, sasf, True, 0, 0, False)
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

        If Conceptos.Rows.Count > 0 Then
            For incre As Integer = 0 To Conceptos.Rows.Count - 1
                Dim sasf As System.Drawing.Color = Color.FromArgb(&HB1, &HF3, &HDA)
                CreaColumnas(gvLiquidaNomina, "B-" + Conceptos.Rows(incre)("Nombre").ToString, "B-" + Conceptos.Rows(incre)("Nombre").ToString, False, False, Conceptos.Rows(incre)("Base").ToString, sasf, True, 0, 0, False)
                Dim fila As DataRow = CamposCalculados.NewRow()
                fila("Nombre") = "B-" + Conceptos.Rows(incre)("Nombre").ToString
                fila("Tipo") = "BC"
                fila("Formula") = Conceptos.Rows(incre)("Base").ToString
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
            PasaValor = False
            Dim sql = ""

            Dim consultasLiquidadas() As String = {
    "SELECT CN.NomConcepto as Nombre, CCN.Formula, CN.Base, CN.Redondea " +
    "FROM ConceptosNomina CN " +
    "INNER JOIN ConfigConceptos CCN ON CCN.Concepto = CN.Sec " +
    "WHERE CCN.Nomina = " + CodNomina,
    "SELECT Sec AS Codigo FROM NominaLiquidada WHERE Sec = " + SecNominaLiquida,
    "WITH ContratosBase AS ( " +
    "    SELECT " +
    "        CON.CodContrato, " +
    "        CON.IdContrato, " +
    "        CON.HorasMes, " +
    "        CON.Asignacion, " +
    "        CON.CargoActual, " +
    "        CON.Terminado, " +
    "        CON.Plantilla, " +
    "        E.Sec AS SecEmpleado, " +
    "        E.Identificacion AS IdentificacionEmple, " +
    "        RTRIM(LTRIM(CONCAT(E.PNombre, ' ', E.SNombre, ' ', E.PApellido, ' ', E.SApellido))) AS NomEmple " +
    "    FROM Contratos CON " +
    "    INNER JOIN Empleados E ON CON.Empleado = E.Sec " +
    "    WHERE CON.Terminado = 0 " +
    "), " +
    "ValoresExentos AS ( " +
    "    SELECT Contrato, SUM(Valor) as Valor " +
    "    FROM Asig_ValoresExentos " +
    "    WHERE Vigente = 1 " +
    "    GROUP BY Contrato " +
    ") " +
    "SELECT " +
    "    CB.IdentificacionEmple, " +
    "    CB.NomEmple, " +
    "    CB.CodContrato, " +
    "    CB.IdContrato, " +
    "    CC.Cargo, " +
    "    V.NomVariable AS Variable, " +
    "    NLV.Cantidad, " +
    "    CA.Denominacion AS NomCargo, " +
    "    NLC.Sec AS NominaLiquidaContrato, " +
    "    NLC.Comentario, " +
    "    CB.HorasMes, " +
    "    CB.Asignacion, " +
    "    CB.CargoActual, " +
    "    NL.Sec AS NominaLiquida, " +
    "    ISNULL(VEX.Valor, 0) AS RentaExenta, " +
    "    ISNULL(( " +
    "        SELECT CN2.NomConcepto as Nombre, NLCP2.Valor as Formula, TC2.NomTipo as Tipo, " +
    "               CN2.Sec, '1' as PeriodosLiquida, NLCP2.Base as Base " +
    "        FROM NominaLiquidadaConceptos NLCP2 " +
    "        INNER JOIN ConceptosNomina CN2 ON NLCP2.SecConcepto = CN2.Sec " +
    "        INNER JOIN TiposConceptosNomina TC2 ON TC2.Sec = CN2.Tipo " +
    "        INNER JOIN NominaLiquidadaContratos NLCT2 ON NLCT2.Sec = NLCP2.LiquidadaContrato " +
    "        INNER JOIN NominaLiquidada NL2 ON NLCT2.NominaLiquidada = NL2.Sec " +
    "        WHERE NL2.Sec = " + SecNominaLiquida + " " +
    "            AND NLCT2.Contrato = CB.CodContrato " +
    "        FOR XML PATH('Fila') " +
    "    ), 'NoPlantilla') AS PlantillaEmpl, " +
    "    ISNULL(( " +
    "        SELECT CP.Sec as SecDescuento, NLCP2.Valor AS DescontarPeriodo, CP.TotalDescontar, " +
    "               CP.TotalDescontado, C.NomConcepto, C.PeriodosLiquida, " +
    "               C.Sec as SecConcepto, C.ValMaxDescuento, CC.Nom AS Clasificacion " +
    "        FROM NominaLiquidadaConceptos NLCP2 " +
    "        INNER JOIN ConceptosP_Contratos CP ON NLCP2.SecConceptoP = CP.Sec " +
    "        INNER JOIN ConceptosPersonales C ON CP.Concepto = C.Sec " +
    "        INNER JOIN NominaLiquidadaContratos NLCT2 ON NLCT2.Sec = NLCP2.LiquidadaContrato " +
    "        INNER JOIN NominaLiquidada NL2 ON NLCT2.NominaLiquidada = NL2.Sec " +
    "        INNER JOIN ClasConceptosPersonales CC ON C.Clasificacion = CC.Sec " +
    "        WHERE NL2.Sec = " + SecNominaLiquida + " " +
    "            AND NLCT2.Contrato = CB.CodContrato " +
    "        ORDER BY CC.NivelP ASC " +
    "        FOR XML PATH('Fila') " +
    "    ), 'NoConceptos') AS ConceptosContratos " +
    "FROM NominaLiquidadaVariables NLV " +
    "INNER JOIN NominaLiquidadaContratos NLC ON NLV.SecLiquidadaContrato = NLC.Sec " +
    "INNER JOIN VariablesPersonales V ON NLV.Variable = V.Sec " +
    "INNER JOIN ContratosBase CB ON NLC.Contrato = CB.CodContrato " +
    "LEFT JOIN ValoresExentos VEX ON VEX.Contrato = CB.CodContrato " +
    "LEFT JOIN Contrato_Cargos CC ON CB.CargoActual = CC.Cargo AND CB.CodContrato = CC.Contrato " +
    "INNER JOIN Cargos CA ON CC.Cargo = CA.Sec " +
    "INNER JOIN NominaLiquidada NL ON NLC.NominaLiquidada = NL.Sec " +
    "WHERE NL.Sec = " + SecNominaLiquida
}

            Dim datos = SMT_GetDataset(ObjetoApiNomina, consultasLiquidadas)

            Conceptos = datos.Tables(0)


            Dim dt As DataTable = datos.Tables(2)

            Dim consulta As DataTable = Nothing
            Creagrillahorizontal()

            If gcLiquidaNomina.DataSource IsNot Nothing Then
                If TypeOf gcLiquidaNomina.DataSource Is DataTable Then
                    Dim dtOriginal As DataTable = DirectCast(gcLiquidaNomina.DataSource, DataTable)
                    ' Clone() copia solo la estructura (columnas, constraints, etc.) sin las filas
                    consulta = dtOriginal.Clone()
                End If
            End If


            If Not IsNothing(consulta) Then consulta.Rows.Clear()

            Dim NumEmp As Integer = 0
            Dim Promedio_M_A = ""
            Dim Promedio_M_S = ""
            Dim ValorAcomulado As Decimal = 0
            If dt.Rows.Count > 0 Then
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
                        fila("NominaLiquidaContrato") = dt.Rows(incre)("NominaLiquidaContrato").ToString
                        fila("NomNomina") = CodNomina
                        fila("HorasMes") = dt.Rows(incre)("HorasMes").ToString
                        fila("Asignacion") = dt.Rows(incre)("Asignacion").ToString
                        fila("CargoActual") = dt.Rows(incre)("CargoActual").ToString
                        fila("Comentario") = dt.Rows(incre)("Comentario").ToString
                        fila("PlantillaEmpl") = dt.Rows(incre)("PlantillaEmpl").ToString
                        fila("ConceptosContratos") = dt.Rows(incre)("ConceptosContratos").ToString
                        If dt.Rows(incre)("RentaExenta").ToString <> "" Then
                            fila("RentaExenta") = dt.Rows(incre)("RentaExenta").ToString
                        Else
                            fila("RentaExenta") = 0
                        End If

                        If Promedio_M_S <> "" Then
                            fila("SalarioPromedioMensualSemestral") = Promedio_M_S
                        Else
                            fila("SalarioPromedioMensualSemestral") = dt.Rows(incre)("Asignacion").ToString
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
                        fila("NominaLiquidaContrato") = dt.Rows(incre)("NominaLiquidaContrato").ToString
                        fila("NomNomina") = CodNomina
                        fila("HorasMes") = dt.Rows(incre)("HorasMes").ToString
                        fila("Asignacion") = dt.Rows(incre)("Asignacion").ToString
                        fila("CargoActual") = dt.Rows(incre)("CargoActual").ToString
                        fila("Comentario") = dt.Rows(incre)("Comentario").ToString
                        fila("PlantillaEmpl") = dt.Rows(incre)("PlantillaEmpl").ToString
                        fila("ConceptosContratos") = dt.Rows(incre)("ConceptosContratos").ToString
                        If dt.Rows(incre)("RentaExenta").ToString <> "" Then
                            fila("RentaExenta") = dt.Rows(incre)("RentaExenta").ToString
                        Else
                            fila("RentaExenta") = 0
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
                gcLiquidaNomina.DataSource = consulta
                gcLiquidaNomina.Focus()
                PasaValor = True

                For Each dtfila As DataRow In consulta.Rows
                    Dim dtconceptos = xmladatatablePlantillas(dtfila("PlantillaEmpl"))
                    For incre As Integer = 0 To consulta.Columns.Count - 1
                        For incre2 As Integer = 0 To dtconceptos.Rows.Count - 1
                            If consulta.Columns(incre).ColumnName = dtconceptos.Rows(incre2)("Nombre").ToString Then
                                dtfila(consulta.Columns(incre).ColumnName) = dtconceptos.Rows(incre2)("Formula")
                            End If
                        Next
                    Next
                Next

                For Each dtfila As DataRow In consulta.Rows
                    Dim dtconceptos = xmladatatableConceptos(dtfila("ConceptosContratos"))
                    For incre As Integer = 0 To consulta.Columns.Count - 1
                        For incre2 As Integer = 0 To dtconceptos.Rows.Count - 1
                            If consulta.Columns(incre).ColumnName = dtconceptos.Rows(incre2)("NomConcepto").ToString Then
                                dtfila(consulta.Columns(incre).ColumnName) = dtconceptos.Rows(incre2)("DescontarPeriodo")
                            End If
                        Next
                    Next
                Next
            Else
                consulta.Rows.Clear()
                gcLiquidaNomina.DataSource = consulta
                gvLiquidaNomina.SelectRow(0)
                PasaValor = True
            End If
        Catch ex As Exception
        End Try
    End Sub

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
            .OptionsColumn.AllowMove = False
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
                Dim dtID As DataTable = CType(vgIngresosDeducciones.DataSource, DataTable)
                Dim dtP As DataTable = CType(vgProviciones.DataSource, DataTable)
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

                    If dtP.Rows.Count > 0 Then
                        If ActualizaNovedades Then
                            For i As Integer = 0 To dtP.Columns.Count - 1
                                Dim EsDescuento As Boolean = False
                                If gvLiquidaNomina.GetRowCellValue(CInt(IndexRow), dtP.Columns(i).Caption.ToString) Is Nothing Then
                                    dtP.Rows(0)(dtP.Columns(i).Caption.ToString) = "0"
                                Else
                                    For incree As Integer = 0 To ConceptosAtadosAlContratoLiquida.Rows.Count - 1
                                        If ConceptosAtadosAlContratoLiquida.Rows(incree)("Nombre").ToString = dtP.Columns(i).Caption.ToString Then
                                            EsDescuento = True
                                        End If
                                    Next
                                    If Not EsDescuento Then
                                        Dim Valor As Decimal = CDec(gvLiquidaNomina.GetRowCellValue(CInt(IndexRow), dtP.Columns(i).Caption.ToString).ToString)
                                        If Valor = 0 Then
                                            dtP.Rows(0)(dtP.Columns(i).Caption.ToString) = "0"
                                        Else
                                            Dim CodConcepto As String = ""
                                            For e As Integer = 0 To ConceptosContrato.Rows.Count - 1
                                                If ConceptosContrato.Rows(e)("Nombre").ToString = dtP.Columns(i).Caption.ToString Then
                                                    CodConcepto = ConceptosContrato.Rows(e)("Sec").ToString
                                                End If
                                            Next
                                            dtP.Rows(0)(dtP.Columns(i).Caption.ToString) = Valor
                                        End If
                                    End If
                                End If
                            Next

                        Else
                            For i As Integer = 0 To dtP.Columns.Count - 1
                                Dim EsDescuento As Boolean = False
                                If gvLiquidaNomina.GetFocusedRowCellValue(dtP.Columns(i).Caption.ToString) Is Nothing Then
                                    dtP.Rows(0)(dtP.Columns(i).Caption.ToString) = "0"
                                Else
                                    For incre As Integer = 0 To ConceptosAtadosAlContratoLiquida.Rows.Count - 1
                                        If ConceptosAtadosAlContratoLiquida.Rows(incre)("Nombre").ToString = dtP.Columns(i).Caption.ToString Then
                                            EsDescuento = True
                                        End If
                                    Next
                                    If Not EsDescuento Then
                                        Dim Valor As Decimal = CDec(gvLiquidaNomina.GetFocusedRowCellValue(dtP.Columns(i).Caption.ToString))
                                        If Valor = 0 Then
                                            dtP.Rows(0)(dtP.Columns(i).Caption.ToString) = "0"
                                        Else
                                            Dim CodConcepto As String = ""
                                            For incre As Integer = 0 To ConceptosContrato.Rows.Count - 1
                                                If ConceptosContrato.Rows(incre)("Nombre").ToString = dtP.Columns(i).Caption.ToString Then
                                                    CodConcepto = ConceptosContrato.Rows(incre)("Sec").ToString
                                                End If
                                            Next
                                            dtP.Rows(0)(dtP.Columns(i).Caption.ToString) = Valor
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
        Dim NomColumn = e.Column.ToString

        Dim tblah As DataTable = CType(gcLiquidaNomina.DataSource, DataTable)
        If tblah Is Nothing Then
        Else
            If tblah.Rows.Count > 0 Then
                If NomColumn <> "" And Not EstaLiquidando Then
                    Dim EsConcepto As Boolean = False
                    Dim PlantillaConceptos = xmladatatablePlantillas(gvLiquidaNomina.GetRowCellValue(e.RowHandle, "PlantillaEmpl").ToString)
                    Dim EsVariable As Boolean = False
                    Dim SecVar As String = ""
                    Dim SecConcepto As String = ""
                    Dim NomConcepto As String = ""
                    Dim BaseConcepto As String = ""
                    Dim ValBase As Decimal = 0
                    For i As Integer = 0 To ColumnasVP.Rows.Count - 1
                        If ColumnasVP.Rows(i)("Nombre").ToString = NomColumn Then
                            EsVariable = True
                            SecVar = ColumnasVP.Rows(i)("Sec").ToString
                            Exit For
                        End If
                    Next
                    Dim SecContrato = gvLiquidaNomina.GetRowCellValue(e.RowHandle, "NominaLiquidaContrato").ToString

                    If EsVariable Then
                        Dim Val = "0"
                        Dim ActlzAnt As Boolean
                        For i As Integer = 0 To PlantillaConceptos.Rows.Count - 1

                            SecConcepto = PlantillaConceptos.Rows(i)("Sec").ToString
                            NomConcepto = PlantillaConceptos.Rows(i)("Nombre").ToString
                            BaseConcepto = PlantillaConceptos.Rows(i)("Base").ToString
                            ValBase = CDec(IIf(IsNothing(gvLiquidaNomina.GetRowCellValue(e.RowHandle, "Base")), 0, gvLiquidaNomina.GetRowCellValue(e.RowHandle, "Base")))
                            Val = CDec(IIf(IsNothing(gvLiquidaNomina.GetRowCellValue(e.RowHandle, PlantillaConceptos.Rows(i)("Nombre").ToString)), 0, gvLiquidaNomina.GetRowCellValue(e.RowHandle, PlantillaConceptos.Rows(i)("Nombre").ToString))).ToString
                            ActlzAnt = ActualizaNovedades
                            ActualizaNovedades = ActlzAnt
                        Next


                        Val = gvLiquidaNomina.GetRowCellValue(e.RowHandle, NomColumn).ToString
                        ActlzAnt = ActualizaNovedades
                        ActualizaNovedades = ActlzAnt
                    End If
                End If
                If Not ActualizaNovedades Then
                    If PasaValor Then
                        CreagrillaVerticalID(ObjetoApiNomina, gvLiquidaNomina.GetFocusedRowCellValue("CodContrato").ToString, gvLiquidaNomina.GetFocusedRowCellValue("PlantillaEmpl").ToString, gvLiquidaNomina.GetFocusedRowCellValue("ConceptosContratos").ToString)
                        CreagrillaVerticalP()
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
                    CreagrillaVerticalID(ObjetoApiNomina, gvLiquidaNomina.GetFocusedRowCellValue("CodContrato").ToString, gvLiquidaNomina.GetFocusedRowCellValue("PlantillaEmpl").ToString, gvLiquidaNomina.GetFocusedRowCellValue("ConceptosContratos").ToString)
                    CreagrillaVerticalP()
                    PasarValores()
                    CreagrillaVerticalDPN()
                End If
            End If
        End If
    End Sub

    Public Sub LimpiarTodosCampos(Conexion As Object)

        SecNominaLiquida = ""
        CodNomina = ""
        EstaLiquidando = False
        ActualizaNovedades = False
        'Limpia todas las grillas
        Dim dt As DataTable = CType(gcLiquidaNomina.DataSource, DataTable)
        dt.Rows.Clear()
        gcLiquidaNomina.DataSource = dt
        CreagrillaVerticalID(Conexion, "0", "", "")
        CreagrillaVerticalP()
        CreagrillaVerticalDPN()
    End Sub
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs)
        LimpiarTodosCampos(ObjetoApiNomina)
    End Sub


    Private Sub FrmLiquidarNomina_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        FormularioAbierto = False
    End Sub



    Private Sub gvLiquidaNomina_ValidatingEditor(sender As Object, e As BaseContainerValidateEditorEventArgs) Handles gvLiquidaNomina.ValidatingEditor
        Dim valormaximo As Decimal = 0
        For incre As Integer = 0 To ColumnasVP.Rows.Count - 1
            If gvLiquidaNomina.FocusedColumn.Name = ColumnasVP.Rows(incre)("Nombre").ToString Then
                If ColumnasVP.Rows(incre)("ValorMaximo").ToString <> "" Then
                    valormaximo = CDec(ColumnasVP.Rows(incre)("ValorMaximo").ToString)
                End If
            End If
        Next
        If gvLiquidaNomina.FocusedColumn.Name <> "Comentario" Then
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
                    e.ErrorText = "El valor que esta tratando de ingresar es superior a " + valormaximo.ToString("C2")
                    e.Valid = False
                End If
            Else
                e.Value = 0
                Exit Sub
            End If
        End If
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

    Private Sub menuImprimir_KeyPress(sender As Object, e As KeyPressEventArgs) Handles btnSalir.KeyPress
        HDevExpre.AtrasConScape(e)
    End Sub

    Private Sub gvLiquidaNomina_ShowingEditor(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles gvLiquidaNomina.ShowingEditor
        If gvLiquidaNomina.FocusedColumn.Name <> "Comentario" Then
            Dim dtVP = SMT_AbrirTabla(ObjetoApiNomina, "Select CodDian,Sec From VariablesPersonales Where NomVariable='" + gvLiquidaNomina.FocusedColumn.Name + "'")
            Dim CodDian As String = IIf(dtVP.Rows.Count > 0, dtVP.Rows(0)(0).ToString, "")
            If CodDian = "NIE076" Or CodDian = "NIE081" Or CodDian = "NIE091" Or CodDian = "NIE101" Or CodDian = "NIE086" Or CodDian = "NIE096" Or CodDian = "NIE106" Then
                Dim SecContrato = gvLiquidaNomina.GetRowCellValue(gvLiquidaNomina.FocusedRowHandle, "NominaLiquidaContrato").ToString
                If ExisteDato("NominaLiquidaVariables", String.Format("SecLiquidaContrato='{0}' And Variable='{1}' ", SecContrato, dtVP.Rows(0)(1).ToString), ObjetoApiNomina) Then
                    Dim classResize As New ClaseResize
                    classResize.Resizamodales(FrmAggDesDetallesVar, 50, 70)

                    Try
                        FrmAggDesDetallesVar.Tipo = "HoraFecha"
                        FrmAggDesDetallesVar.CantHoras = 0
                        FrmAggDesDetallesVar.CodVar = SMT_AbrirTabla(ObjetoApiNomina, $"select sec from NominaLiquidaVariables where SecLiquidaContrato='{SecContrato}' And Variable='{dtVP.Rows(0)(1).ToString} '").Rows(0)(0).ToString
                        FrmAggDesDetallesVar.TextCaption = gvLiquidaNomina.FocusedColumn.Name
                        FrmAggDesDetallesVar.ShowDialog()
                        FrmAggDesDetallesVar.BringToFront()
                        gvLiquidaNomina.SetRowCellValue(gvLiquidaNomina.FocusedRowHandle, gvLiquidaNomina.FocusedColumn.Name, CInt(FrmAggDesDetallesVar.CantHoras))
                        e.Cancel = True
                    Catch ex As Exception

                    End Try
                End If

            ElseIf CodDian = "NIE125" Then
                Dim SecContrato = gvLiquidaNomina.GetRowCellValue(gvLiquidaNomina.FocusedRowHandle, "NominaLiquidaContrato").ToString
                If ExisteDato("NominaLiquidaVariables", String.Format("SecLiquidaContrato='{0}' And Variable='{1}' ", SecContrato, dtVP.Rows(0)(1).ToString), ObjetoApiNomina) Then
                    Dim classResize As New ClaseResize
                    classResize.Resizamodales(FrmAggDesDetallesVar, 50, 70)

                    Try
                        FrmAggDesDetallesVar.Tipo = "Incapacidad"
                        FrmAggDesDetallesVar.CantHoras = 0
                        FrmAggDesDetallesVar.CodVar = SMT_AbrirTabla(ObjetoApiNomina, $"select sec from NominaLiquidaVariables where SecLiquidaContrato='{SecContrato}' And Variable='{dtVP.Rows(0)(1).ToString} '").Rows(0)(0).ToString
                        FrmAggDesDetallesVar.TextCaption = gvLiquidaNomina.FocusedColumn.Name
                        FrmAggDesDetallesVar.ShowDialog()
                        FrmAggDesDetallesVar.BringToFront()
                        gvLiquidaNomina.SetRowCellValue(gvLiquidaNomina.FocusedRowHandle, gvLiquidaNomina.FocusedColumn.Name, CInt(FrmAggDesDetallesVar.CantHoras))
                        e.Cancel = True
                    Catch ex As Exception

                    End Try
                End If
            ElseIf CodDian = "NIE130" Or CodDian = "NIE134" Or CodDian = "NIE111" Then
                Dim SecContrato = gvLiquidaNomina.GetRowCellValue(gvLiquidaNomina.FocusedRowHandle, "NominaLiquidaContrato").ToString
                If ExisteDato("NominaLiquidaVariables", String.Format("SecLiquidaContrato='{0}' And Variable='{1}' ", SecContrato, dtVP.Rows(0)(1).ToString), ObjetoApiNomina) Then
                    Dim classResize As New ClaseResize
                    classResize.Resizamodales(FrmAggDesDetallesVar, 50, 70)

                    Try
                        FrmAggDesDetallesVar.Tipo = "Otra"
                        FrmAggDesDetallesVar.CantHoras = 0
                        FrmAggDesDetallesVar.CodVar = SMT_AbrirTabla(ObjetoApiNomina, $"select sec from NominaLiquidaVariables where SecLiquidaContrato='{SecContrato}' And Variable='{dtVP.Rows(0)(1).ToString} '").Rows(0)(0).ToString
                        FrmAggDesDetallesVar.TextCaption = gvLiquidaNomina.FocusedColumn.Name
                        FrmAggDesDetallesVar.ShowDialog()
                        FrmAggDesDetallesVar.BringToFront()
                        gvLiquidaNomina.SetRowCellValue(gvLiquidaNomina.FocusedRowHandle, gvLiquidaNomina.FocusedColumn.Name, CInt(FrmAggDesDetallesVar.CantHoras))
                        e.Cancel = True
                    Catch ex As Exception

                    End Try
                End If
            End If
        End If
    End Sub

    Private Sub BtnExcell_Click(sender As Object, e As EventArgs) Handles BtnExcell.Click
        Dim Ruta As String = My.Computer.FileSystem.SpecialDirectories.Desktop + "\" + NomLiquida + ".xlsx", Guardar As New SaveFileDialog
        Guardar.Filter = "XlsX Excel|*.Xlsx"
        Guardar.Title = "Guardar Archivo de Excel XlsX"
        Guardar.ShowDialog()
        If Guardar.FileName <> "" Then
            Ruta = Guardar.FileName
            gcLiquidaNomina.ExportToXlsx(Ruta)
            Process.Start(Ruta)
        End If

    End Sub
End Class