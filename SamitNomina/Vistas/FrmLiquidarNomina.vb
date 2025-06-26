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
Imports DevExpress.Utils
Imports SamitNominaLogic
Imports Newtonsoft.Json.Linq

Public Class FrmLiquidarNomina

    Public Memo As New RepositoryItemMemoExEdit
    Public Datos As New SamitCtlNet.SamitCtlNet
    Dim clImprimir As ClaseImprimir
    Dim SecNominaLiquida As String = ""
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
    Dim Año As String
    Dim SecPeriodo As String
    Dim NumPeriodo As String
    Dim NumPeriodoNom As String
    Dim NumMes As String
    Dim CodNomina As String
    Dim SecContratoLiquida As String
    Dim FormularioAbierto As Boolean = False
    Dim EstaLiquidando As Boolean = False
    Dim PasaValor As Boolean = True
    Dim BasaLiquidaAntigua As Boolean = False
    Dim CreoGrillaHorizontal = False
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
        txtAño.ValordelControl = Year(ObjetosNomina.Datos.Smt_FechaDelServidor).ToString
        AsignaScriptAcontroles()
        Memo.SuppressMouseEventOnOuterMouseClick = True
        AcomodaForm()
        ConsultaDatos()
        txtOficina.Select()
        AsignaMsgAcontroles()
    End Sub

    Private Sub AcomodaForm()
        Try
            btnBuscar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Buscar)
            btnBorradores.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Editar)
            'btnGuardaBorrador.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.GuardaBorrador)
            btnLiquidar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.LiquidaNomina)
            btnLimpiar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Limpiar)
            btnSalir.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.SalirCuadroConX)
            menuImprimir.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Imprimir)
            btnEliminarBorrador.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.EliminarGris)
            BtnExcell.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Excell_XlsX)
            btnEliminarBorrador.Enabled = False
            Dim classResize As New ClaseResize
            classResize.Resizagrid(gvLiquidaNomina)
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, " AcomodaForm Contrato")
        End Try
    End Sub
    Private Sub AsignaMsgAcontroles()
        Try
            txtAño.MensajedeAyuda = "Digite el año sobre el cual desea trabajar la nómina. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras"
            txtOficina.MensajedeAyuda = "Seleccione la oficina sobre la cual desea trabajar.(ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras, (F5,DER)=Buscar"
            txtNominas.MensajedeAyuda = "Seleccion el nómina sobre la cual desea trabajar. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras, (F5,DER)=Buscar"
            txtPeriodos.MensajedeAyuda = "Seleccione el periodo sobre el cual desea trabajar. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras, (F5,DER)=Buscar"
            'txtDependencia.MensajedeAyuda = "Seleccione la dependencia o area sobre la cual desea trabajar. (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras, (F5,DER)=Buscar"
            'txtCargos.MensajedeAyuda = "Seleccione el cargo sobre el cual desea trabajar.  (ENTER,ABJ)=Avanzar;(ESC,ARB)=Atras, (F5,DER)=Buscar"
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "AsignaMsgAcontroles")
        End Try
    End Sub

    Private Sub AsignaScriptAcontroles()
        Try

            Dim consultas() As String = {
    "select NomVariable as Nombre,ValorMaximo as ValorMaximo,ValorDefecto As ValorDefecto,Sec as Sec, EsPredeterminado, vigente from VariablesPersonales WHERE EsPredeterminado = 1 OR (vigente = 1 AND EsPredeterminado = 0)",
    "select NomBase as Nombre,Formula from BasesConceptos",
    "select CN.NomConcepto as Nombre,CCN.Formula,CN.Base,CN.Redondea,CCN.Nomina from ConceptosNomina CN INNER JOIN ConfigConceptos CCN ON CCN.Concepto = CN.Sec",
    "select NomConcepto as Nombre,ValMaxDescuento As Formula from ConceptosPersonales",
    "select NomPlantilla as Nombre,ValorMaxDescontar as Formula from Plantillas",
    "WITH VariablesConFechaMax AS ( SELECT VG.Sec AS Variable,VG.NomVariable AS Nombre,VGD.Fecha,VGD.Valor,ROW_NUMBER() OVER (PARTITION BY VG.Sec ORDER BY VGD.Fecha DESC) AS rn FROM DetallesVariablesGenerales VGD INNER JOIN VariablesGenerales VG ON VGD.Variable = VG.Sec) SELECT Variable, Nombre, Fecha, Valor FROM VariablesConFechaMax WHERE rn = 1"
}
            txtOficina.DatosDefecto = ObjetosNomina.Oficinas

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
                           " INNER JOIN Nominas N ON P.Nomina = N.Sec Where NL.EsBorrador = 1 "
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
        DatatableReturn.Columns.Add("Formula", GetType(String))
        DatatableReturn.Columns.Add("Tipo", GetType(String))
        DatatableReturn.Columns.Add("Sec", GetType(String))
        DatatableReturn.Columns.Add("PeriodosLiquida", GetType(String))
        DatatableReturn.Columns.Add("Plantilla", GetType(String))
        DatatableReturn.Columns.Add("Base", GetType(String))
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
            'Conceptos
            '        sql = "select CN.NomConcepto as Nombre, CCN.Formula as Formula,TC.NomTipo as Tipo,CN.Sec as Sec,CCN.PeriodosLiquida,P.NomPlantilla as Plantilla,CN.Base as Base " +
            '" FROM ConceptosNomina CN INNER JOIN TiposConceptosNomina TC ON TC.Sec = CN.Tipo " +
            '" INNER JOIN ConfigConceptos CCN ON CCN.Concepto = CN.Sec " +
            '" INNER JOIN ConceptosPlantillas CP ON CP.Concepto = CN.Sec INNER JOIN Plantillas P ON CP.Plantilla = P.SecPlantilla" +
            '" INNER JOIN Contratos C ON C.Plantilla = P.SecPlantilla Where TC.Vigente= 1 AND CCN.Nomina =" + CodNomina + " And C.CodContrato = " + CodContrato
            '        ConceptosPlantillas = SMT_AbrirTabla(ObjetoApiNomina, sql)


            '        sql = "Select CP.Sec as SecDescuento,CP.DescontarPeriodo As DescontarPeriodo,CP.TotalDescontar as TotalDescontar, " +
            '" CP.TotalDescontado As TotalDescontado,C.NomConcepto As NomConcepto, " +
            '" C.PeriodosLiquida As PeriodosLiquida,C.Sec as SecConcepto, " +
            '" C.ValMaxDescuento As ValMaxDescuento,CC.Nom As Clasificacion from ConceptosP_Contratos CP " +
            '" INNER JOIN ConceptosPersonales C ON CP.Concepto = C.Sec " +
            ' " INNER JOIN ClasConceptosPersonales CC ON C.Clasificacion = CC.Sec Where CP.Contrato =" + CodContrato + " And CP.Vigente = 1 And CP.AplicaLiquidaPeriodos = 1 order by cc.NivelP asc"

            'ConceptosAtadosAlContrato = SMT_AbrirTabla(ObjetoApiNomina, sql)
            ConceptosAtadosAlContrato = xmladatatableConceptos(ConceptsContrato)
            ConceptosAtadosAlContrato.Columns.Add("SeLiquida", GetType(String))

            If ConceptosPlantillas.Rows.Count > 0 Then

                PlantillaContra = ConceptosPlantillas.Rows(0)("Plantilla").ToString
                For incre As Integer = 0 To ConceptosPlantillas.Rows.Count - 1
                    If ConceptosPlantillas.Rows(incre)("Tipo").ToString = "Ingresos" Or ConceptosPlantillas.Rows(incre)("Tipo").ToString = "Deducciones" Then
                        Dim value As String = ConceptosPlantillas.Rows(incre)("PeriodosLiquida").ToString
                        Dim SeLiquida As Boolean = False
                        Dim delimitador As Char = ","c
                        Dim PeriodosL() As String = value.Split(delimitador)
                        Dim PeriodoLiq = ""
                        If value.Length > 1 Then

                        Else
                            PeriodoLiq = value
                        End If

                        For inc As Integer = 0 To PeriodosL.Length - 1
                            If PeriodosL(inc) = NumPeriodo Or PeriodoLiq = NumPeriodo Then
                                SeLiquida = True
                            End If
                        Next
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
                                fila("Formula") = ConceptosPlantillas.Rows(incre)("Formula").ToString
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
            vgIngresosDeducciones.RecordWidth = CInt((50 * (vgIngresosDeducciones.Width)) / 100 - 5)
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
            'TiposConceptos(Categorias)

            'If ConceptosAtadosAlContrato.Rows.Count > 0 Then
            '    Dim Clasificacion As New EditorRow
            '    For incre As Integer = 0 To ConceptosAtadosAlContrato.Rows.Count - 1
            '        Clasificacion = TryCast(vgDescPorNomina.GetRowByCaption(ConceptosAtadosAlContrato.Rows(incre)("Clasificacion").ToString), EditorRow)
            '        If Clasificacion Is Nothing Then
            '            CreaFilas(vgDescPorNomina, ConceptosAtadosAlContrato.Rows(incre)("Clasificacion").ToString, ConceptosAtadosAlContrato.Rows(incre)("Clasificacion").ToString, True, True, "0", True, False, Nothing)
            '        End If
            '    Next
            'End If
            'CreaFilas(vgDescPorNomina, "Total De Descuentos Por Nomina", "Total De Descuentos Por Nomina", True, True, "0", True, False, Nothing)
            'If ConceptosAtadosAlContrato.Rows.Count > 0 Then
            '    Dim Clasificacion As New EditorRow
            '    For incre As Integer = 0 To ConceptosAtadosAlContrato.Rows.Count - 1
            '        Clasificacion = TryCast(vgDescPorNomina.GetRowByCaption(ConceptosAtadosAlContrato.Rows(incre)("Clasificacion").ToString), EditorRow)
            '        If Clasificacion Is Nothing Then
            '        Else
            '            Dim categoria As EditorRow = TryCast(vgDescPorNomina.GetRowByCaption("Total De Descuentos Por Nomina"), EditorRow)
            '            Dim Formu As String = categoria.Properties.UnboundExpression
            '            Formu = Formu + " + " + "[" + ConceptosAtadosAlContrato.Rows(incre)("Clasificacion").ToString + "]"
            '            categoria.Properties.UnboundExpression = Formu
            '        End If
            '    Next
            'End If

            If ConceptosAtadosAlContrato.Rows.Count > 0 Then
                For incre As Integer = 0 To ConceptosAtadosAlContrato.Rows.Count - 1
                    Dim value As String = ConceptosAtadosAlContrato.Rows(incre)("PeriodosLiquida").ToString
                    Dim SeLiquida As Boolean = False
                    Dim delimitador As Char = ","c
                    Dim PeriodosL() As String = value.Split(delimitador)
                    Dim PeriodoLiq = ""
                    If value.Length > 1 Then
                    Else
                        PeriodoLiq = value
                    End If
                    For inc As Integer = 0 To PeriodosL.Length - 1
                        If PeriodosL(inc) = NumPeriodo Or PeriodoLiq = NumPeriodo Then
                            SeLiquida = True
                        End If
                    Next
                    If SeLiquida Then
                        'llena tabla de conceptos a liquidar
                        Dim fila As DataRow = ConceptosAtadosAlContratoLiquida.NewRow()
                        fila("Nombre") = ConceptosAtadosAlContrato.Rows(incre)("NomConcepto").ToString
                        fila("Formula") = ConceptosAtadosAlContrato.Rows(incre)("ValMaxDescuento").ToString
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

                    'If ValFalta < ValDesc Then
                    '    If ValFalta > ValMax Then
                    '       HDevExpre.MensagedeError("El valor del descuento " + ConceptosAtadosAlContrato.Rows(incre)("NomConcepto").ToString + " (" + ValFalta.ToString("c2") + ") es mayor al maximo que se le puede aplicar (" + ValMax.ToString("c2") + ")!..")
                    '        Exit Sub
                    '    End If
                    'Else
                    '    If ValDesc > ValMax Then
                    '       HDevExpre.MensagedeError("El valor del descuento " + ConceptosAtadosAlContrato.Rows(incre)("NomConcepto").ToString + " (" + ValDesc.ToString("c2") + ") es mayor al maximo que se le puede aplicar (" + ValMax.ToString("c2") + ")!..")
                    '        Exit Sub
                    '    End If
                    'End If

                Next

                Dim Saldo As Decimal = 0

                If ActualizaNovedades Then
                    If gvLiquidaNomina.GetRowCellValue(CInt(IndexRow), PlantillaContra) Is Nothing Then
                        Saldo = 0
                    Else
                        Saldo = CDec(gvLiquidaNomina.GetRowCellValue(CInt(IndexRow), PlantillaContra).ToString)
                    End If
                Else
                    If gvLiquidaNomina.GetRowCellValue(gvLiquidaNomina.FocusedRowHandle, PlantillaContra) Is Nothing Then
                        Saldo = 0
                    Else
                        Saldo = CDec(gvLiquidaNomina.GetRowCellValue(gvLiquidaNomina.FocusedRowHandle, PlantillaContra).ToString)
                    End If
                End If

                For incre As Integer = 0 To ConceptosAtadosAlContrato.Rows.Count - 1

                    Dim categoria As EditorRow = TryCast(vgDescPorNomina.GetRowByCaption(ConceptosAtadosAlContrato.Rows(incre)("Clasificacion").ToString), EditorRow)
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


            'If ConceptosAtadosAlContrato.Rows.Count > 0 Then

            '    For incre As Integer = 0 To ConceptosAtadosAlContrato.Rows.Count - 1
            '        If ConceptosAtadosAlContrato.Rows(incre)("SeLiquida").ToString = "Si" Then
            '            Dim categoria As EditorRow = TryCast(vgDescPorNomina.GetRowByCaption(ConceptosAtadosAlContrato.Rows(incre)("Clasificacion").ToString), EditorRow)
            '            Dim Formu As String = categoria.Properties.UnboundExpression
            '            Formu = Formu + " + " + "[" + ConceptosAtadosAlContrato.Rows(incre)("NomConcepto").ToString + "]"
            '            categoria.Properties.UnboundExpression = Formu
            '            CreaFilas(vgDescPorNomina, ConceptosAtadosAlContrato.Rows(incre)("NomConcepto").ToString, ConceptosAtadosAlContrato.Rows(incre)("NomConcepto").ToString, True, True, "", True, True, categoria)
            '            filas.Columns.Add(ConceptosAtadosAlContrato.Rows(incre)("NomConcepto").ToString, GetType(Decimal))
            '            Dim TotalDescontar, TotalDescontado, DescontarPeriodo, Falta As Decimal
            '            TotalDescontar = CDec(ConceptosAtadosAlContrato.Rows(incre)("TotalDescontar"))
            '            TotalDescontado = CDec(ConceptosAtadosAlContrato.Rows(incre)("TotalDescontado"))
            '            DescontarPeriodo = CDec(ConceptosAtadosAlContrato.Rows(incre)("DescontarPeriodo"))
            '            Falta = TotalDescontar - TotalDescontado
            '            If Falta > 0 Then
            '                If Falta > DescontarPeriodo Then
            '                    NuevaFila(ConceptosAtadosAlContrato.Rows(incre)("NomConcepto").ToString) = ConceptosAtadosAlContrato.Rows(incre)("DescontarPeriodo")
            '                ElseIf DescontarPeriodo >= Falta Then
            '                    NuevaFila(ConceptosAtadosAlContrato.Rows(incre)("NomConcepto").ToString) = Falta
            '                End If
            '            Else
            '                NuevaFila(ConceptosAtadosAlContrato.Rows(incre)("NomConcepto").ToString) = "0"
            '            End If
            '        End If
            '    Next
            'End If
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
                        Dim SeLiquida As Boolean = False
                        Dim delimitador As Char = ","c
                        Dim PeriodosL() As String = value.Split(delimitador)
                        Dim PeriodoLiq = ""
                        If value.Length > 1 Then

                        Else
                            PeriodoLiq = value
                        End If

                        For inc As Integer = 0 To PeriodosL.Length - 1
                            If PeriodosL(inc) = NumPeriodo Or PeriodoLiq = NumPeriodo Then
                                SeLiquida = True
                            End If
                        Next
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
                                fila("Formula") = ConceptosPlantillas.Rows(incre)("Formula").ToString
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
        CreaColumnas(gvLiquidaNomina, "IdentificacionEmple", "Identificación Empleado", True, False, "", coloor, False, 15, gcLiquidaNomina.Width, False, True, Formato_tipo:=FormatType.Numeric, FormatoString:="n0")
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


    Private Sub ConsultaDatos()
        If txtOficina.ValordelControl <> "" And txtOficina.DescripciondelControl <> "No Se Encontraron Registros" And txtOficina.DescripciondelControl <> "" And txtNominas.ValordelControl <> "" And txtNominas.DescripciondelControl <> "No Se Encontraron Registros" And txtNominas.DescripciondelControl <> "" And txtPeriodos.ValordelControl <> "" And txtPeriodos.DescripciondelControl <> "No Se Encontraron Registros" And txtPeriodos.DescripciondelControl <> "" And txtAño.ValordelControl <> "" Then


            Try
                PasaValor = False
                Dim NumSemestre As String
                If CInt(NumMes) > 6 Then
                    NumSemestre = "2"
                Else
                    NumSemestre = "1"
                End If

                ' Construir todas las consultas SQL
                Dim consultas() As String = {
    "SELECT CN.NomConcepto as Nombre, CCN.Formula, CN.Base, CN.Redondea " +
    "FROM ConceptosNomina CN " +
    "INNER JOIN ConfigConceptos CCN ON CCN.Concepto = CN.Sec " +
    "WHERE CCN.Nomina = " + CodNomina,
    "SELECT Sec AS Codigo FROM NominaLiquida WHERE Periodo = " + SecPeriodo,
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
    "        SELECT CN2.NomConcepto as Nombre, CCN2.Formula, TC2.NomTipo as Tipo, " +
    "               CN2.Sec, CCN2.PeriodosLiquida, P2.NomPlantilla as PlantillaEmpl, CN2.Base " +
    "        FROM ConceptosNomina CN2 " +
    "        INNER JOIN TiposConceptosNomina TC2 ON TC2.Sec = CN2.Tipo " +
    "        INNER JOIN ConfigConceptos CCN2 ON CCN2.Concepto = CN2.Sec " +
    "        INNER JOIN ConceptosPlantillas CP2 ON CP2.Concepto = CN2.Sec " +
    "        INNER JOIN Plantillas P2 ON CP2.Plantilla = P2.Sec " +
    "        WHERE TC2.Vigente = 1 " +
    "            AND CCN2.Nomina = " + CodNomina + " " +
    "            AND P2.Sec = CB.Plantilla " +
    "        FOR XML PATH('Fila') " +
    "    ), 'NoPlantilla') AS PlantillaEmpl, " +
    "    ISNULL(( " +
    "        SELECT CP.Sec as SecDescuento, CP.DescontarPeriodo, CP.TotalDescontar, " +
    "               CP.TotalDescontado, C.NomConcepto, C.PeriodosLiquida, " +
    "               C.Sec as SecConcepto, C.ValMaxDescuento, CC.Nom AS Clasificacion " +
    "        FROM ConceptosP_Contratos CP " +
    "        INNER JOIN ConceptosPersonales C ON CP.Concepto = C.Sec " +
    "        INNER JOIN ClasConceptosPersonales CC ON C.Clasificacion = CC.Sec " +
    "        WHERE CP.Contrato = CB.CodContrato " +
    "            AND CP.Vigente = 1 " +
    "            AND CP.AplicaLiquidaPeriodos = 1 " +
    "        ORDER BY CC.NivelP ASC " +
    "        FOR XML PATH('Fila') " +
    "    ), 'NoConceptos') AS ConceptosContratos " +
    "FROM NominaLiquidaVariables NLV " +
    "INNER JOIN NominaLiquidaContratos NLC ON NLV.SecLiquidaContrato = NLC.Sec " +
    "INNER JOIN VariablesPersonales V ON NLV.Variable = V.Sec " +
    "INNER JOIN ContratosBase CB ON NLC.Contrato = CB.CodContrato " +
    "LEFT JOIN ValoresExentos VEX ON VEX.Contrato = CB.CodContrato " +
    "LEFT JOIN Contrato_Cargos CC ON CB.CargoActual = CC.Cargo And CB.CodContrato=CC.Contrato  " +
    "INNER JOIN Cargos CA ON CC.Cargo = CA.Sec " +
    "INNER JOIN NominaLiquida NL ON NLC.NominaLiquida = NL.Sec " +
    "WHERE NL.Periodo = " + SecPeriodo,
    "SELECT NLDC.Contrato, SUM(NLDC.Total) as TotalPagadoAlMes " +
    "FROM NominaLiquidadaContratos NLDC WITH (NOLOCK) " +
    "INNER JOIN NominaLiquidada NLD WITH (NOLOCK) ON NLDC.NominaLiquidada = NLD.Sec " +
    "INNER JOIN PeriodosLiquidacion PDL WITH (NOLOCK) ON NLD.Periodo = PDL.Sec " +
    "WHERE NLD.Estado <> 'A' " +
    "    AND PDL.Año = " + Año + " " +
    "    AND PDL.NumMes = " + NumMes + " " +
    "    AND PDL.Nomina = " + CodNomina + " " +
    "GROUP BY NLDC.Contrato",
    "WITH PromediosMensuales AS ( " +
    "    SELECT " +
    "        NLC.Contrato, " +
    "        P.NumMes, " +
    "        SUM(NLC.TotalIngresos) as IngresosMes " +
    "    FROM NominaLiquidadaContratos NLC WITH (NOLOCK) " +
    "    INNER JOIN NominaLiquidada NL WITH (NOLOCK) ON NLC.NominaLiquidada = NL.Sec " +
    "    INNER JOIN PeriodosLiquidacion P WITH (NOLOCK) ON NL.Periodo = P.Sec " +
    "    WHERE NL.Estado <> 'A' " +
    "        AND P.Semestre = " + NumSemestre + " " +
    "        AND P.Año = " + Año + " " +
    "    GROUP BY NLC.Contrato, P.NumMes " +
    ") " +
    "SELECT Contrato, AVG(IngresosMes) as PromedioSemestral " +
    "FROM PromediosMensuales " +
    "GROUP BY Contrato",
    "WITH PromediosAnuales AS ( " +
    "    SELECT " +
    "        NLC.Contrato, " +
    "        P.NumMes, " +
    "        SUM(NLC.TotalIngresos) as IngresosMes " +
    "    FROM NominaLiquidadaContratos NLC WITH (NOLOCK) " +
    "    INNER JOIN NominaLiquidada NL WITH (NOLOCK) ON NLC.NominaLiquidada = NL.Sec " +
    "    INNER JOIN PeriodosLiquidacion P WITH (NOLOCK) ON NL.Periodo = P.Sec " +
    "    WHERE NL.Estado <> 'A' " +
    "        AND P.Año = " + Año + " " +
    "    GROUP BY NLC.Contrato, P.NumMes " +
    ") " +
    "SELECT Contrato, AVG(IngresosMes) as promedioanual " +
    "FROM PromediosAnuales " +
    "GROUP BY Contrato"
}

                ' Ejecutar todas las consultas de una vez
                Dim dsResultados As DataSet = SMT_GetDataset(ObjetoApiNomina, consultas)

                ' Asignar los resultados
                Conceptos = dsResultados.Tables(0)

                If dsResultados.Tables(1).Rows.Count > 0 Then
                    SecNominaLiquida = dsResultados.Tables(1).Rows(0)(0).ToString
                End If

                Dim dt As DataTable = dsResultados.Tables(2)
                Dim AcomuladosMes As DataTable = dsResultados.Tables(3)
                Dim PromedioMensualSemestral As DataTable = dsResultados.Tables(4)
                Dim PromedioMensualAnual As DataTable = dsResultados.Tables(5)

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
                            fila("NomNomina") = txtNominas.DescripciondelControl
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

                            If AcomuladosMes.Rows.Count > 0 Then
                                For i As Integer = 0 To AcomuladosMes.Rows.Count - 1
                                    If AcomuladosMes.Rows(i)("Contrato").ToString = dt.Rows(incre)("CodContrato").ToString Then
                                        ValorAcomulado = CDec(AcomuladosMes.Rows(i)("TotalPagadoAlMes"))
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
                            fila("NominaLiquidaContrato") = dt.Rows(incre)("NominaLiquidaContrato").ToString
                            fila("NomNomina") = txtNominas.DescripciondelControl
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

                            For i As Integer = 0 To AcomuladosMes.Rows.Count - 1
                                If AcomuladosMes.Rows(i)("Contrato").ToString = dt.Rows(incre)("CodContrato").ToString Then
                                    ValorAcomulado = CDec(AcomuladosMes.Rows(i)("TotalPagadoAlMes"))
                                    Exit For
                                End If
                            Next

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
                    btnEliminarBorrador.Enabled = True
                    PasaValor = True
                Else
                    consulta.Rows.Clear()
                    gcLiquidaNomina.DataSource = consulta
                    gvLiquidaNomina.SelectRow(0)
                    btnEliminarBorrador.Enabled = False
                    PasaValor = True
                End If
            Catch ex As Exception
            End Try
        Else
            Dim consulta As DataTable = CType(gcLiquidaNomina.DataSource, DataTable)
            If Not IsNothing(consulta) Then
                consulta.Rows.Clear()
                btnEliminarBorrador.Enabled = False
                gcLiquidaNomina.DataSource = consulta
                PasarValores()
                SecNominaLiquida = ""
                PasaValor = True
            End If
        End If
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

    Private Sub CreaColumnas(Grid As GridView, Nombre As String, Titulo As String, Visible As Boolean, Editar As Boolean, formula As String, colores As System.Drawing.Color, numerico As Boolean, Porcentaje_Width As Single, TamañoPadre As Single, EsMemo As Boolean, Optional isfixed As Boolean = False,
                             Optional Formato_tipo As FormatType = Nothing, Optional FormatoString As String = "")
        Dim gc As New GridColumn
        With gc
            .FieldName = Nombre
            .Name = Nombre
            .Caption = Titulo
            If Not IsNothing(Formato_tipo) Then
                gc.DisplayFormat.FormatType = Formato_tipo
                If FormatoString <> "" Then
                    gc.DisplayFormat.FormatString = FormatoString
                End If
            End If

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
                For incre As Integer = 0 To CamposCalculados.Rows.Count - 1
                    If CamposCalculados.Rows(incre)("Formula").ToString() <> "" Then


                        Dim Valor As String = gvLiquidaNomina.GetRowCellValue(0, CamposCalculados.Rows(incre)("Nombre").ToString()).ToString
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
                    End If
                Next
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

    Public Sub txtNominas_Leave(sender As Object, e As EventArgs) Handles txtNominas.Leave
        If txtNominas.ValordelControl <> "" And txtNominas.DescripciondelControl <> "No Se Encontraron Registros" And txtNominas.DescripciondelControl <> "" Then
            txtPeriodos.ValordelControl = ""
            txtPeriodos.ConsultaSQL = String.Format("SELECT CodPeriodo AS Codigo,Descripcion As Descripcion FROM  PeriodosLiquidacion where año ='{0}' And Nomina='{1}' And Estado<>'L'", txtAño.ValordelControl, txtNominas.ValordelControl)

            txtPeriodos.RefrescarDatos()
        End If
    End Sub

    Public Sub txtAño_Leave(sender As Object, e As EventArgs) Handles txtAño.Leave
        Dim valor As String = txtPeriodos.ValordelControl
        txtPeriodos.ValordelControl = ""
        txtPeriodos.ConsultaSQL = String.Format("SELECT CodPeriodo AS Codigo,Descripcion As Descripcion FROM  PeriodosLiquidacion where año ='{0}' And Nomina='{1}' And Estado<>'L'", txtAño.ValordelControl, txtNominas.ValordelControl)
        txtPeriodos.RefrescarDatos()
        txtPeriodos.ValordelControl = valor

        Dim valortxtaño As String = txtAño.ValordelControl
        txtPeriodos.ValordelControl = ""
        If valortxtaño.Length < 4 Then
            txtAño.Focus()
        End If
    End Sub

    Public Sub txtOficina_Leave(sender As Object, e As EventArgs) Handles txtOficina.Leave
        If txtOficina.ValordelControl <> "" And txtOficina.DescripciondelControl <> "No Se Encontraron Registros" And txtOficina.DescripciondelControl <> "" Then
            txtNominas.ValordelControl = ""
            txtNominas.ConsultaSQL = String.Format("SELECT Sec AS Codigo,NomNomina As Descripcion FROM  Nominas Where Oficina=" + txtOficina.ValordelControl)
            txtNominas.RefrescarDatos()

            txtPeriodos.ValordelControl = ""
            txtPeriodos.ConsultaSQL = String.Format("SELECT Sec AS Codigo,Descripcion As Descripcion FROM  PeriodosLiquidacion where año ='{1}' And Estado<>'L'", txtAño.ValordelControl, txtNominas.ValordelControl)
            txtPeriodos.RefrescarDatos()

        End If
    End Sub

    Private Sub GuardarConceptos()
        Dim wait As New ClEspera
        wait.Mostrar()
        wait.Descripcion = "Completando liquidación..."
        Try
            ' Crear el request
            Dim request As New CompletarLiquidacionRequest With {
            .SecNominaLiquida = CInt(SecNominaLiquida),
            .SecPeriodo = CInt(SecPeriodo),
            .EsLiquidacionDefinitiva = EstaLiquidando,
            .Usuario = ObjetosNomina.Datos.Smt_Usuario
        }

            ' Obtener datos del grid
            Dim dt As DataTable = CType(gcLiquidaNomina.DataSource, DataTable)

            ' Procesar cada contrato
            For incre As Integer = 0 To dt.Rows.Count - 1

                Dim contratoDto As New ContratoCompletarLiquidacionDto With {
                .SecNominaLiquidaContrato = CInt(dt.Rows(incre)("NominaLiquidaContrato")),
                .CodContrato = CInt(dt.Rows(incre)("CodContrato")),
                .HorasMes = CInt(dt.Rows(incre)("HorasMes")),
                .CargoActual = CInt(dt.Rows(incre)("CargoActual")),
                .Asignacion = CDec(dt.Rows(incre)("Asignacion"))
            }

                ' Procesar Conceptos ID (Ingresos/Deducciones)
                If ConceptosContrato.Rows.Count > 0 Then
                    For i As Integer = 0 To ConceptosContrato.Rows.Count - 1
                        Dim Fila As EditorRow
                        If ConceptosContrato.Rows(i)("Tipo").ToString = "Deducciones" Then
                            Fila = TryCast(vgIngresosDeducciones.GetRowByCaption("Deducciones"), EditorRow).ChildRows(ConceptosContrato.Rows(i)("Nombre").ToString)
                        Else
                            Fila = TryCast(vgIngresosDeducciones.GetRowByCaption(ConceptosContrato.Rows(i)("Nombre").ToString), EditorRow)
                        End If

                        Dim valor As Decimal = CDec(Fila.Properties.Value)
                        Dim basev As Decimal = 0

                        If gvLiquidaNomina.GetRowCellValue(incre, ConceptosContrato.Rows(i)("Base").ToString) IsNot Nothing Then
                            basev = CDec(gvLiquidaNomina.GetRowCellValue(incre, ConceptosContrato.Rows(i)("Base").ToString))
                        End If

                        Dim conceptoDto As New ConceptoLiquidacionDto With {
                        .NomConcepto = ConceptosContrato.Rows(i)("Nombre").ToString(),
                        .Valor = valor,
                        .Base = basev,
                        .NomBase = ConceptosContrato.Rows(i)("Base").ToString(),
                        .SecConcepto = CInt(ConceptosContrato.Rows(i)("Sec"))
                    }

                        contratoDto.ConceptosID.Add(conceptoDto)
                    Next
                End If

                ' Procesar Conceptos DPN (Descuentos por Nómina)
                If ConceptosAtadosAlContratoLiquida.Rows.Count > 0 Then
                    For i As Integer = 0 To ConceptosAtadosAlContratoLiquida.Rows.Count - 1
                        Dim Fila As EditorRow = TryCast(vgDescPorNomina.GetRowByCaption(ConceptosAtadosAlContratoLiquida.Rows(i)("Nombre").ToString), EditorRow)
                        Dim valor As Decimal = CDec(Fila.Properties.Value)

                        Dim conceptoDto As New ConceptoLiquidacionDto With {
                        .NomConcepto = ConceptosAtadosAlContratoLiquida.Rows(i)("Nombre").ToString(),
                        .Valor = valor,
                        .Base = 0,
                        .NomBase = "",
                        .SecConceptoP = CInt(ConceptosAtadosAlContratoLiquida.Rows(i)("SecConcepto")),
                        .SecConceptoP2 = CInt(ConceptosAtadosAlContratoLiquida.Rows(i)("SecDescuento"))
                    }

                        If EstaLiquidando Then
                            ' Calcular cuota si es liquidación definitiva
                            Dim sql As String = "SELECT COUNT(*) + 1 FROM NominaLiquidadaConceptos WHERE SecConceptoP2 = " + conceptoDto.SecConceptoP2.ToString()
                            Dim dtCuota As DataTable = SMT_AbrirTabla(ObjetoApiNomina, sql)
                            If dtCuota.Rows.Count > 0 Then
                                conceptoDto.Cuota = CInt(dtCuota.Rows(0)(0))
                            End If
                        End If

                        contratoDto.ConceptosDPN.Add(conceptoDto)
                    Next
                End If

                ' Calcular totales del VGrid
                Dim categoriaID As EditorRow = TryCast(vgIngresosDeducciones.GetRowByCaption("Total"), EditorRow)
                Dim categoriaIng As EditorRow = TryCast(vgIngresosDeducciones.GetRowByCaption("Ingresos"), EditorRow)
                Dim categoriadeduc As EditorRow = TryCast(vgIngresosDeducciones.GetRowByCaption("Deducciones"), EditorRow)
                Dim categoriaP As EditorRow = TryCast(vgProviciones.GetRowByCaption("Provisiones"), EditorRow)
                Dim categoriaDPN As EditorRow = TryCast(vgDescPorNomina.GetRowByCaption("Total De Descuentos Por Nomina"), EditorRow)

                contratoDto.Total = If(categoriaID Is Nothing, 0, CDec(categoriaID.Properties.Value))
                contratoDto.TotalIngresos = If(categoriaIng Is Nothing, 0, CDec(categoriaIng.Properties.Value))
                contratoDto.TotalDeducciones = If(categoriadeduc Is Nothing, 0, Math.Abs(CDec(categoriadeduc.Properties.Value)))
                contratoDto.TotalProvisiones = If(categoriaP Is Nothing, 0, CDec(categoriaP.Properties.Value))
                contratoDto.TotalDescuentosNomina = If(categoriaDPN Is Nothing, 0, CDec(categoriaDPN.Properties.Value))

                request.Contratos.Add(contratoDto)
            Next

            ' Ejecutar procedimiento almacenado
            Dim resp = SMT_EjecutaProcedimientos(ObjetoApiNomina, "SP_CompletarLiquidacionNomina", request.ToJObject())
            Dim response = resp.ToObject(Of CompletarLiquidacionResponse)()

            wait.Terminar()

            If response.EsExitoso Then
                HDevExpre.mensajeExitoso($"Liquidación completada exitosamente. Se procesaron {response.ContratosProcesados} contratos.")

                If EstaLiquidando Then
                    Me.Close()
                End If
            Else
                HDevExpre.MensagedeError($"Error al completar la liquidación: {response.Mensaje}")
            End If

        Catch ex As Exception
            wait.Terminar()
            HDevExpre.msgError(ex, ex.Message, "GuardarConceptos")
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
                            If ExisteDato("NominaLiquidaConceptos", String.Format("LiquidaContrato='{0}' And SecConcepto='{1}' ", gvLiquidaNomina.GetRowCellValue(e.RowHandle, "NominaLiquidaContrato").ToString, SecConcepto), ObjetoApiNomina) Then
                                ActualizaNovedades = True
                                If GuardaNominaLiquidaConceptos(ObjetoApiNomina, gvLiquidaNomina.GetRowCellValue(e.RowHandle, "NominaLiquidaContrato").ToString, Val.ToString, NomConcepto,
                                                                    SecConcepto, "", ValBase.ToString, BaseConcepto, False, "") Then
                                End If
                            Else
                                ActualizaNovedades = False
                                If GuardaNominaLiquidaConceptos(ObjetoApiNomina, gvLiquidaNomina.GetRowCellValue(e.RowHandle, "NominaLiquidaContrato").ToString, Val.ToString, NomConcepto,
                                                                    SecConcepto, "", ValBase.ToString, BaseConcepto, False, "") Then
                                End If
                            End If
                            ActualizaNovedades = ActlzAnt
                        Next


                        Val = gvLiquidaNomina.GetRowCellValue(e.RowHandle, NomColumn).ToString
                        ActlzAnt = ActualizaNovedades
                        If ExisteDato("NominaLiquidaVariables", String.Format("SecLiquidaContrato='{0}' And Variable='{1}' ", SecContrato, SecVar), ObjetoApiNomina) Then
                            ActualizaNovedades = True
                            If GuardaNominaLiquidaVariables(ObjetoApiNomina, SecContrato, Val, SecVar) Then
                            End If
                        Else
                            ActualizaNovedades = False
                            If GuardaNominaLiquidaVariables(ObjetoApiNomina, SecContrato, Val, SecVar) Then
                            End If
                        End If
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
        'Limpia todos los campos de texto
        'txtDependencia.ValordelControl = ""
        txtOficina.ValordelControl = ""
        txtNominas.ValordelControl = ""
        'txtCargos.ValordelControl = ""
        txtPeriodos.ValordelControl = ""
        SecNominaLiquida = ""
        SecPeriodo = ""
        NumPeriodo = ""
        NumMes = ""
        CodNomina = ""
        btnEliminarBorrador.Enabled = False
        EstaLiquidando = False
        ActualizaNovedades = False
        CreoGrillaHorizontal = False
        'Limpia todas las grillas
        Dim dt As DataTable = CType(gcLiquidaNomina.DataSource, DataTable)
        dt.Rows.Clear()
        gvLiquidaNomina.Columns.Clear()
        gcLiquidaNomina.DataSource = dt
        CreagrillaVerticalID(Conexion, "0", "", "")
        CreagrillaVerticalP()
        CreagrillaVerticalDPN()
        txtOficina.Focus()
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
                'If CamposCalculados.Rows(incre)("Tipo").ToString = "BC" Then
                '    MensagedeError(String.Format("Se ha encontrado un error.{0}En la formula: {1}{0}De la base del concepto: {2}, por favor verificar!..", vbNewLine, CamposCalculados.Rows(incre)("Formula"), Nombre.Substring(2, Nombre.Length - 2)))
                '    Return False
                'End If
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
                If Not ExisteDato("NominaLiquidada", String.Format("Periodo='{0}' And Estado<>'A' ", SecPeriodo), ObjetoApiNomina) Then
                    If GuardaNominaLiquida(ObjetoApiNomina) Then
                        Dim asdf As DataTable = SMT_AbrirTabla(ObjetoApiNomina, "SELECT Sec AS Codigo FROM NominaLiquidada Where Estado<>'A' And Periodo =" + SecPeriodo)
                        SecNominaLiquida = SMT_AbrirTabla(ObjetoApiNomina, "SELECT Sec AS Codigo FROM NominaLiquidada Where Estado<>'A' And Periodo =" + SecPeriodo).Rows(0)(0).ToString
                    Else
                        HDevExpre.MensagedeError("Ha ocurrido un error al liquidar la nomina..!")
                        Return False
                    End If
                Else
                    HDevExpre.MensagedeError("Este periodo ya ha sido liquidado..!")
                End If
            End If

            For incre As Integer = 0 To dt.Rows.Count - 1
                If ExisteDato("Contratos", "Terminado=1 And CodContrato=" + dt.Rows(incre)("CodContrato").ToString, ObjetoApiNomina) Then
                    incre = incre + 1
                    If incre > dt.Rows.Count - 1 Then
                        Exit For
                    End If
                End If
                IndexRow = incre.ToString

                CreagrillaVerticalID(ObjetoApiNomina, dt.Rows(incre)("CodContrato").ToString, dt.Rows(incre)("PlantillaEmpl").ToString, dt.Rows(incre)("ConceptosContratos").ToString)
                CreagrillaVerticalP()
                PasarValores()
                CreagrillaVerticalDPN()

                Dim categoriaID As EditorRow = TryCast(vgIngresosDeducciones.GetRowByCaption("Total"), EditorRow)
                Dim categoriaIng As EditorRow = TryCast(vgIngresosDeducciones.GetRowByCaption("Ingresos"), EditorRow)
                Dim categoriadeduc As EditorRow = TryCast(vgIngresosDeducciones.GetRowByCaption("Deducciones"), EditorRow)
                Dim categoriaP As EditorRow = TryCast(vgProviciones.GetRowByCaption("Provisiones"), EditorRow)
                Dim categoriaDPN As EditorRow = TryCast(vgDescPorNomina.GetRowByCaption("Total De Descuentos Por Nomina"), EditorRow)
                Dim totalID As Decimal = 0
                Dim totalIng As Decimal = 0
                Dim totaldeduc As Decimal = 0
                Dim totalP As Decimal = 0
                Dim totalDPN As Decimal = 0
                Dim totalcID As String = "0"
                Dim totalcP As String = "0"
                Dim totalcIng As String = "0"
                Dim totalcdeduc As String = "0"
                Dim totalcDPN As String = "0"

                If categoriaID Is Nothing Then

                Else
                    totalID = CDec(categoriaID.Properties.Value)
                    totalcID = totalID.ToString
                End If
                If categoriaP Is Nothing Then

                Else
                    totalP = CDec(categoriaP.Properties.Value)
                    totalcP = totalP.ToString
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

                If GuardaNominaLiquidaContratos(ObjetoApiNomina, dt.Rows(incre)("CodContrato").ToString, SecNominaLiquida, totalcID, dt.Rows(incre)("HorasMes").ToString, dt.Rows(incre)("CargoActual").ToString,
                                                dt.Rows(incre)("Asignacion").ToString, totalcP, totalcIng, totaldeduc.ToString, dt.Rows(incre)("Comentario").ToString, totalcDPN) Then
                    Dim TabConceptos As String = ""
                    Dim TabVariables As String = ""
                    Dim DetallesVar As String = ""
                    Dim CampoTabConceptos As String = ""
                    Dim CampoTabVariables As String = ""

                    If EstaLiquidando Then
                        SecContratoLiquida = SMT_AbrirTabla(ObjetoApiNomina, "SELECT Sec AS Codigo FROM NominaLiquidadaContratos Where NominaLiquidada =" + SecNominaLiquida + " And Contrato=" + dt.Rows(incre)("CodContrato").ToString).Rows(0)(0).ToString
                        TabConceptos = "NominaLiquidadaConceptos"
                        TabVariables = "NominaLiquidadaVariables"
                        DetallesVar = "NominaLiquidaDescripVarPer"
                        CampoTabConceptos = "LiquidadaContrato"
                        CampoTabVariables = "SecLiquidadaContrato"

                    Else
                        SecContratoLiquida = dt.Rows(incre)("NominaLiquidaContrato").ToString
                        TabConceptos = "NominaLiquidaConceptos"
                        TabVariables = "NominaLiquidaVariables"
                        DetallesVar = "DescripVarPer"
                        CampoTabConceptos = "LiquidaContrato"
                        CampoTabVariables = "SecLiquidaContrato"
                    End If

                    'Registra Conceptos de Nomina
                    If ConceptosContrato.Rows.Count > 0 Then
                        For i As Integer = 0 To ConceptosContrato.Rows.Count - 1
                            Dim Fila As New EditorRow
                            If ConceptosContrato.Rows(i)("Tipo").ToString = "Provisiones" Then
                                Fila = TryCast(vgProviciones.GetRowByCaption(ConceptosContrato.Rows(i)("Nombre").ToString), EditorRow)
                            Else
                                Fila = TryCast(vgIngresosDeducciones.GetRowByCaption(ConceptosContrato.Rows(i)("Nombre").ToString), EditorRow)
                            End If
                            Dim valor As Decimal = CDec(Fila.Properties.Value)
                            Dim valorc2 As String = valor.ToString
                            Dim Basev As Decimal = 0
                            If gvLiquidaNomina.GetRowCellValue(incre, ConceptosContrato.Rows(i)("Base").ToString) Is Nothing Then
                                Basev = 0
                            Else
                                Basev = CDec(gvLiquidaNomina.GetRowCellValue(incre, ConceptosContrato.Rows(i)("Base").ToString).ToString)
                            End If
                            If ExisteDato(TabConceptos, String.Format(CampoTabConceptos + "='{0}' And SecConcepto='{1}' ", dt.Rows(incre)("NominaLiquidaContrato").ToString, ConceptosContrato.Rows(i)("Sec").ToString), ObjetoApiNomina) Then
                                If GuardaNominaLiquidaConceptos(ObjetoApiNomina, SecContratoLiquida, valorc2, ConceptosContrato.Rows(i)("Nombre").ToString,
                                                                ConceptosContrato.Rows(i)("Sec").ToString, "", Basev.ToString, ConceptosContrato.Rows(i)("Base").ToString, False, "") Then
                                Else
                                    Return False
                                End If
                            Else
                                ActualizaNovedades = False
                                If GuardaNominaLiquidaConceptos(ObjetoApiNomina, SecContratoLiquida, valorc2, ConceptosContrato.Rows(i)("Nombre").ToString,
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

                        For i As Integer = 0 To ConceptosAtadosAlContratoLiquida.Rows.Count - 1
                            Dim Fila As New EditorRow
                            Fila = TryCast(vgDescPorNomina.GetRowByCaption(ConceptosAtadosAlContratoLiquida.Rows(i)("Nombre").ToString), EditorRow)
                            Dim valor As Decimal = CDec(Fila.Properties.Value)
                            Dim valorc As String = valor.ToString


                            If Not ExisteDato(TabConceptos, String.Format(CampoTabConceptos + "='{0}' And SecConceptoP='{1}' ", SecContratoLiquida, ConceptosAtadosAlContratoLiquida.Rows(i)("SecConcepto").ToString), ObjetoApiNomina) Then
                                ActualizaNovedades = False
                            Else
                                ActualizaNovedades = True
                            End If
                            Dim Cuota As Integer = 0
                            Cuota = CInt(SMT_AbrirTabla(ObjetoApiNomina, "Select Isnull(CuotaActual,0) Cuota From ConceptosP_Contratos where Sec=" + ConceptosAtadosAlContratoLiquida.Rows(i)("SecDescuento").ToString).Rows(0)(0).ToString)
                            If GuardaNominaLiquidaConceptos(ObjetoApiNomina, SecContratoLiquida, valorc, ConceptosAtadosAlContratoLiquida.Rows(i)("Nombre").ToString,
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

                                    If ModificaDescuentosPorNomina(ObjetoApiNomina, ConceptosAtadosAlContratoLiquida.Rows(i)("SecDescuento").ToString, TotalDescontado.ToString, Vigente, Cuota.ToString) Then

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
                        Dim valor As Decimal = CDec(dt.Rows(incre)(ColumnasVP.Rows(i)("Nombre").ToString).ToString)
                        Dim valorc2 As String = valor.ToString
                        If ExisteDato(TabVariables, String.Format(CampoTabVariables + "='{0}' And Variable='{1}' ", SecContratoLiquida, ColumnasVP.Rows(i)("Sec").ToString), ObjetoApiNomina) Then
                            If GuardaNominaLiquidaVariables(ObjetoApiNomina, SecContratoLiquida, valorc2, ColumnasVP.Rows(i)("Sec").ToString) Then
                            Else
                                Return False
                            End If
                        Else
                            ActualizaNovedades = False
                            If GuardaNominaLiquidaVariables(ObjetoApiNomina, SecContratoLiquida, valorc2, ColumnasVP.Rows(i)("Sec").ToString) Then
                                ActualizaNovedades = True
                                If EstaLiquidando Then
                                    Dim SecVar As String = SMT_AbrirTabla(ObjetoApiNomina, "select sec from NominaLiquidadaVariables where SecLiquidadaContrato='" + SecContratoLiquida + "' And Variable='" + ColumnasVP.Rows(i)("Sec").ToString + "'").Rows(0)(0).ToString
                                    Dim SecVarAnt As String = SMT_AbrirTabla(ObjetoApiNomina, "select sec from NominaLiquidaVariables where SecLiquidaContrato='" + dt.Rows(incre)("NominaLiquidaContrato").ToString + "' And Variable='" + ColumnasVP.Rows(i)("Sec").ToString + "'").Rows(0)(0).ToString

                                    Dim dtDetalles As DataTable = SMT_AbrirTabla(ObjetoApiNomina, "select * from DescripVarPer Where CodVarP='" + SecVarAnt + "'")
                                    If dtDetalles.Rows.Count > 0 Then
                                        For increvar As Integer = 0 To dtDetalles.Rows.Count - 1
                                            If Not GuardaNominaLiquidaDetallesVar(Convert.ToDateTime(dtDetalles.Rows(increvar)("FechaHoraInicio")), Convert.ToDateTime(dtDetalles.Rows(increvar)("FechaHoraFin")), dtDetalles.Rows(increvar)("Cantidad").ToString, SecVar, dtDetalles.Rows(increvar)("TipoDesc").ToString) Then
                                                Return False
                                            End If
                                        Next
                                    End If
                                End If
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

    Private Sub btnGuardaBorrador_Click(sender As Object, e As EventArgs)
        'Using trans As New Transactions.TransactionScope
        'Using ObjetoApiNomina As New SqlClient.SqlConnection(CadConexionBdGeneral)
        'ObjetoApiNomina.Open()
        SMT_EjcutarComandoSql(ObjetoApiNomina, "set dateformat dmy", 0)
        Dim wait As New ClEspera
        Try
            If ValidaCampos() Then
                wait.Mostrar()
                wait.Descripcion = "Guardando Datos..."
                If GuardaBorrador(ObjetoApiNomina) Then
                    wait.Terminar()
                    HDevExpre.mensajeExitoso("Información guardada exitosamente!..")
                    'trans.Complete()
                Else
                    HDevExpre.MensagedeError("Ha ocurrido un error al guardar el borrador!..")
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            wait.Terminar()
            Exit Sub
        End Try
        'End Using
        'End Using
    End Sub

    Public Function EliminarBorrador() As Boolean
        Try
            ' Obtener el SecNominaLiquida
            Dim dt As DataTable = SMT_AbrirTabla(ObjetoApiNomina,
            "SELECT Sec AS Codigo FROM NominaLiquida WHERE Periodo = " + SecPeriodo)

            If dt.Rows.Count = 0 Then
                HDevExpre.MensagedeError("No se encontró el borrador a eliminar")
                Return False
            End If

            SecNominaLiquida = dt.Rows(0)(0).ToString()

            ' Crear el request
            Dim request As New EliminarBorradorNominaRequest With {
            .SecNominaLiquida = CInt(SecNominaLiquida),
            .Usuario = ObjetosNomina.Datos.Smt_Usuario,
            .Terminal = ObjetosNomina.Datos.Smt_NombreTerminal
        }

            ' Ejecutar procedimiento almacenado
            Dim resp = SMT_EjecutaProcedimientos(ObjetoApiNomina, "SP_EliminarBorradorNomina", request.ToJObject())
            Dim response = resp.ToObject(Of EliminarBorradorNominaResponse)()

            ' Procesar respuesta
            If response.EsExitoso Then
                Return True
            Else
                ' Log del error si es necesario
                Console.WriteLine($"Error al eliminar borrador: {response.Mensaje}")
                If response.CodigoError.HasValue Then
                    Console.WriteLine($"Código de error SQL: {response.CodigoError.Value}")
                End If
                Return False
            End If

        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "EliminarBorrador")
            Return False
        End Try
    End Function

    Private Sub btnLiquidar_Click(sender As Object, e As EventArgs) Handles btnLiquidar.Click
        'Using trans As New Transactions.TransactionScope(TransactionScopeOption.Required,
        'New System.TimeSpan(0, 15, 0))
        'Using ObjetoApiNomina As New SqlClient.SqlConnection(CadConexionBdGeneral)
        'ObjetoApiNomina.Open()
        SMT_EjcutarComandoSql(ObjetoApiNomina, "set dateformat dmy", 0)
        Dim wait As New ClEspera
        Try
            If ValidaCampos() Then
                If HDevExpre.MsgSamit("Seguro que desea liquidar este periodo?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.OK Then
                    wait.Mostrar()
                    wait.Descripcion = "Guardando Datos..."
                    EstaLiquidando = True
                    If GuardaBorrador(ObjetoApiNomina) Then
                        If EliminarBorrador() Then
                            wait.Terminar()
                            LimpiarTodosCampos(ObjetoApiNomina)
                            HDevExpre.mensajeExitoso("Información guardada exitosamente!")
                        Else
                            wait.Terminar()
                            HDevExpre.MensagedeError("Error al liquidar la nomina..!")
                            Exit Sub
                        End If
                    Else
                        wait.Terminar()
                        HDevExpre.MensagedeError("Error al liquidar la nomina..!")
                        Exit Sub
                    End If
                End If
            End If
        Catch ex As Exception
            HDevExpre.MensagedeError(ex.Message)
            wait.Terminar()
            Exit Sub
        End Try
        'trans.Complete()
        'End Using
        'End Using
    End Sub
    Public Function ValidaCampos() As Boolean
        Dim res As Boolean = False
        Dim Tbla As DataTable = CType(gcLiquidaNomina.DataSource, DataTable)
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


    Public Function GuardaNominaLiquida(Conexion As Object) As Boolean
        Dim GenSql As New SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL
        Dim GenSql2 As New SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL
        Dim Tab As String = ""
        If EstaLiquidando Then
            GenSql2.PasoConexionTabla(Conexion, "PeriodosLiquidacion")
            GenSql.PasoConexionTabla(Conexion, "NominaLiquidada")
            GenSql2.PasoValores("Estado", "L", SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            GenSql.PasoValores("Estado", "L", SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            GenSql.PasoValores("Contabilizada", "0", SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            Tab = "NominaLiquidada"
        Else
            GenSql.PasoConexionTabla(Conexion, "NominaLiquida")
            Tab = "NominaLiquida"
            GenSql.PasoValores("EsBorrador", "1", SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
        End If
        GenSql.PasoValores("Periodo", SecPeriodo, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
        GenSql.PasoValores("OfiNomina", txtOficina.ValordelControl, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
        GenSql.PasoValores("OfiRegistra", Datos.Seguridad.DatosDeLaEmpresa.NumEmpresa.ToString, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
        GenSql.PasoValores("UsuCrea", Datos.Smt_Usuario, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
        GenSql.PasoValores("FechaCrea", Datos.Smt_FechaDelServidor.ToString("dd/MM/yyyy hh:MM:ss"), SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
        GenSql.PasoValores("TerminalCrea", Datos.Smt_Usuario, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
        GenSql.PasoValores("FechaSys", Datos.Smt_FechaDelServidor.ToString("dd/MM/yyyy hh:MM:ss"), SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
        Dim Sec = SMT_AbrirTabla(ObjetoApiNomina, "SELECT ISNULL( MAX (Sec),0)+1 AS Codigo FROM " + Tab).Rows(0)(0).ToString
        GenSql.PasoValores("Sec", Sec, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Numero)
        If GenSql.EjecutarComandoNET(SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.SQLGenera.Insercion, "") Then

        Else : Return False
        End If
        If EstaLiquidando Then
            If GenSql2.EjecutarComandoNET(SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.SQLGenera.Actualizacion, String.Format("Sec={0}", SecPeriodo)) Then
                Return True
            Else : Return False
            End If
        Else
            Return True
        End If
    End Function

    Private Function GuardaNominaLiquidaDetallesVar(fechaini As DateTime, fechafin As DateTime, cantidad As String, CodVar As String, TipoDes As String) As Boolean
        Try
            Dim GenSql As New SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL
            GenSql.PasoConexionTabla(ObjetoApiNomina, "NominaLiquidaDescripVarPer")
            GenSql.PasoValores("FechaHoraInicio", fechaini.ToString("dd/MM/yyyy HH:mm:ss"), SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            GenSql.PasoValores("FechaHoraFin", fechafin.ToString("dd/MM/yyyy HH:mm:ss"), SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            GenSql.PasoValores("Cantidad", cantidad, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            GenSql.PasoValores("CodVarP", CodVar, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            GenSql.PasoValores("TipoDesc", TipoDes, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            Dim SecDetalles = SMT_AbrirTabla(ObjetoApiNomina, "SELECT ISNULL( MAX (Sec),0)+1 AS Codigo FROM  NominaLiquidaDescripVarPer").Rows(0)(0).ToString
            GenSql.PasoValores("Sec", SecDetalles, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            If GenSql.EjecutarComandoNET(SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.SQLGenera.Insercion, "") Then
                Return True
            Else : Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function GuardaNominaLiquidaContratos(Conexion As Object, Contrato As String, NominaLiquida As String, Total As String, HorasMes As String,
                                               CargoActual As String, Asignacion As String, TotalProviciones As String, TotalIngresos As String,
                                               TotalDeducciones As String, Comentario As String, TotalDescuentosNomina As String) As Boolean
        Dim GenSql As New SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL
        Dim Tab As String = ""
        If EstaLiquidando Then
            GenSql.PasoConexionTabla(Conexion, "NominaLiquidadaContratos")
            GenSql.PasoValores("NominaLiquidada", NominaLiquida, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            Tab = "NominaLiquidadaContratos"
        Else
            GenSql.PasoConexionTabla(Conexion, "NominaLiquidaContratos")
            GenSql.PasoValores("NominaLiquida", NominaLiquida, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            Tab = "NominaLiquidaContratos"
        End If
        GenSql.PasoValores("Contrato", Contrato, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
        GenSql.PasoValores("Total", Total, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
        GenSql.PasoValores("TotalProvisiones", TotalProviciones, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
        GenSql.PasoValores("TotalFondos", "0", SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
        GenSql.PasoValores("TotalIngresos", TotalIngresos, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
        GenSql.PasoValores("TotalDeducciones", TotalDeducciones, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
        GenSql.PasoValores("TotalDescuentosNomina", TotalDescuentosNomina, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
        GenSql.PasoValores("HorasMes", HorasMes, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
        GenSql.PasoValores("CargoActual", CargoActual, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
        GenSql.PasoValores("Comentario", Comentario, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
        GenSql.PasoValores("Asignacion", Asignacion, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
        If ActualizaNovedades And Not EstaLiquidando Then
            If GenSql.EjecutarComandoNET(SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.SQLGenera.Actualizacion, String.Format("NominaLiquida={0} And Contrato={1}", NominaLiquida, Contrato)) Then
                Return True
            Else : Return False
            End If
        Else
            Dim Sec = SMT_AbrirTabla(ObjetoApiNomina, "SELECT ISNULL( MAX (Sec),0)+1 AS Codigo FROM  " + Tab).Rows(0)(0).ToString
            GenSql.PasoValores("Sec", Sec, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            If GenSql.EjecutarComandoNET(SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.SQLGenera.Insercion, "") Then
                Return True
            Else : Return False
            End If
        End If
    End Function

    Public Function GuardaNominaLiquidaConceptos(Conexion As Object, LiquidaContrato As String, Valor As String, NomConcepto As String, SecConcepto As String, SecDescuento As String, Base As String, NomBase As String, EsDescuento As Boolean, Cuota As String) As Boolean
        Dim GenSql As New SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL
        Dim Tab As String = ""
        Dim TipoConcepto = ""
        If EstaLiquidando Then
            GenSql.PasoConexionTabla(Conexion, "NominaLiquidadaConceptos")
            GenSql.PasoValores("LiquidadaContrato", LiquidaContrato, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            Tab = "NominaLiquidadaConceptos"
        Else
            GenSql.PasoConexionTabla(Conexion, "NominaLiquidaConceptos")
            GenSql.PasoValores("LiquidaContrato", LiquidaContrato, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            Tab = "NominaLiquidaConceptos"
        End If

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

        If ActualizaNovedades And Not EstaLiquidando Then
            If GenSql.EjecutarComandoNET(SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.SQLGenera.Actualizacion, String.Format("LiquidaContrato={0} And {1}={2} ", LiquidaContrato, TipoConcepto, SecConcepto)) Then
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

    Public Function GuardaNominaLiquidaVariables(Conexion As Object, LiquidaContrato As String, Cantidad As String, Variable As String) As Boolean
        Dim GenSql As New SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL

        Dim Tab As String = ""
        If EstaLiquidando Then
            GenSql.PasoConexionTabla(Conexion, "NominaLiquidadaVariables")
            GenSql.PasoValores("SecLiquidadaContrato", LiquidaContrato, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            Tab = "NominaLiquidadaVariables"
        Else
            GenSql.PasoConexionTabla(Conexion, "NominaLiquidaVariables")
            GenSql.PasoValores("SecLiquidaContrato", LiquidaContrato, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
            Tab = "NominaLiquidaVariables"
        End If
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

    Public Function ModificaDescuentosPorNomina(Conexion As Object, SecDescuento As String, TotalDescontado As String, Vigente As String, Cuota As String) As Boolean
        Dim GenSql As New SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL
        Dim Cuo As Integer = CInt(Cuota) + 1
        GenSql.PasoConexionTabla(Conexion, "ConceptosP_Contratos")
        GenSql.PasoValores("Sec", SecDescuento, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
        GenSql.PasoValores("TotalDescontado", TotalDescontado, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
        GenSql.PasoValores("Vigente", Vigente, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
        GenSql.PasoValores("CuotaActual", Cuo.ToString, SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.TipoDatoActualizaSQL.Cadena)
        If GenSql.EjecutarComandoNET(SamitCtlNet.SamitCtlNet.ClGeneraSqlDLL.SQLGenera.Actualizacion, String.Format("Sec={0} ", SecDescuento)) Then
            Return True
        Else : Return False
        End If
    End Function

    Private Sub FrmLiquidarNomina_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        FormularioAbierto = False
    End Sub

    Private Sub btnBorradores_Click(sender As Object, e As EventArgs) Handles btnBorradores.Click
        If ExisteDato("NominaLiquida", String.Format("EsBorrador='{0}'", "1"), ObjetoApiNomina) Then
            AbreBusqueda()
        Else
            HDevExpre.MensagedeError("No se han encontrado Borradores!..")
        End If
    End Sub


    'Public Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
    '    EstaLiquidando = False
    '    Dim NumPeriodoNom As String = ""
    '    Dim wait As New ClEspera
    '    wait.Mostrar()
    '    wait.Descripcion = "Buscando..."
    '    'Using trans As New Transactions.TransactionScope(TransactionScopeOption.Required,
    '    'New System.TimeSpan(0, 15, 0))
    '    SMT_EjcutarComandoSql(ObjetoApiNomina, "set dateformat dmy", 0)
    '        If txtPeriodos.ValordelControl = "" Or txtPeriodos.DescripciondelControl = "No Se Encontraron Registros" Or txtPeriodos.DescripciondelControl = "" Then
    '            HDevExpre.MensagedeError("El campo Periodo no puede estar vacio, ni contener valores invalidos!..")
    '            SecPeriodo = ""
    '            wait.Terminar()
    '            Exit Sub
    '        Else
    '            SecPeriodo = SMT_AbrirTabla(ObjetoApiNomina, "SELECT Sec FROM PeriodosLiquidacion where CodPeriodo=" + txtPeriodos.ValordelControl).Rows(0)(0).ToString
    '            NumPeriodo = SMT_AbrirTabla(ObjetoApiNomina, "SELECT PeriodoMes AS Codigo FROM PeriodosLiquidacion Where Sec =" + SecPeriodo).Rows(0)(0).ToString
    '            NumPeriodoNom = SMT_AbrirTabla(ObjetoApiNomina, "SELECT NumPeriodoNom AS Codigo FROM PeriodosLiquidacion Where Sec =" + SecPeriodo).Rows(0)(0).ToString
    '            NumMes = SMT_AbrirTabla(ObjetoApiNomina, "SELECT NumMes AS Codigo FROM PeriodosLiquidacion Where Sec =" + SecPeriodo).Rows(0)(0).ToString
    '            Año = txtAño.ValordelControl
    '            CodNomina = txtNominas.ValordelControl
    '            If ExisteDato("PeriodosLiquidacion", String.Format("Sec='{0}' And Estado='L'", SecPeriodo), ObjetoApiNomina) Then
    '                HDevExpre.MensagedeError("Este periodo ya ha sido liquidado!..")
    '                wait.Terminar()
    '                Exit Sub
    '            Else
    '                Dim Fecha As String = CDate(SMT_AbrirTabla(ObjetoApiNomina, "SELECT FechaInicio FROM PeriodosLiquidacion where sec=" + SecPeriodo).Rows(0)(0).ToString).ToString("dd/MM/yyyy")
    '                Dim sql As String = "Select * from PeriodosLiquidacion where sec < " + SecPeriodo + " and FechaFin < '" + Fecha + "' and Estado = 'P' And Año = '" + Año + "' And Nomina='" + txtNominas.ValordelControl + "'"
    '                Dim dt As DataTable = SMT_AbrirTabla(ObjetoApiNomina, sql)
    '                If dt.Rows.Count > 0 Then
    '                    HDevExpre.MensagedeError("Hay Periodos anteriores que aún no se han liquidado!..")
    '                    wait.Terminar()
    '                    Exit Sub
    '                Else
    '                    If ExisteDato("NominaLiquida", String.Format("Periodo='{0}' And EsBorrador = 1", SecPeriodo), ObjetoApiNomina) And Not ExisteDato("NominaLiquidada", String.Format("Periodo='{0}' And Estado<>'A'", SecPeriodo), ObjetoApiNomina) Then
    '                        SecNominaLiquida = SMT_AbrirTabla(ObjetoApiNomina, "SELECT Sec AS Codigo FROM NominaLiquida Where EsBorrador = 1 And Periodo =" + SecPeriodo).Rows(0)(0).ToString
    '                        sql = " Select C.Asignacion AS Asignacion,C.CodContrato AS CodContrato,C.HorasMes AS HorasMes,C.CargoActual AS CargoActual, " +
    '                                    " CC.Cargo As Cargo from Contratos C INNER JOIN Contrato_Cargos CC ON C.CargoActual = CC.SecCargos where C.Nomina =" + txtNominas.ValordelControl + " And C.Plantilla <> '' And C.Terminado=0"


    '                        dt = SMT_AbrirTabla(ObjetoApiNomina, sql)
    '                        If dt.Rows.Count > 0 Then
    '                            Dim encontro As Boolean = False
    '                            If dt.Rows.Count > 0 Then
    '                                For incre As Integer = 0 To dt.Rows.Count - 1
    '                                    encontro = False
    '                                    Dim ConsulEmple As DataTable = SMT_AbrirTabla(ObjetoApiNomina, "SELECT CN.Sec AS Codigo FROM NominaLiquidaContratos CN Inner join NominaLiquida NL on CN.NominaLiquida = NL.Sec Where CN.Contrato=" + dt.Rows(incre)("CodContrato").ToString + " And NL.Periodo =" + SecPeriodo)
    '                                    If ConsulEmple.Rows.Count > 0 Then
    '                                        encontro = True
    '                                    End If

    '                                    If Not encontro Then

    '                                        If GuardaNominaLiquidaContratos(ObjetoApiNomina, dt.Rows(incre)("CodContrato").ToString, SecNominaLiquida, "0", dt.Rows(incre)("HorasMes").ToString,
    '                                                                                dt.Rows(incre)("CargoActual").ToString, dt.Rows(incre)("Asignacion").ToString, "0", "0", "0", "", "0") Then
    '                                            If ColumnasVP.Rows.Count > 0 Then
    '                                                For i As Integer = 0 To ColumnasVP.Rows.Count - 1
    '                                                    Dim Sentenciasql As String = "SELECT CN.Sec AS Codigo FROM NominaLiquidaContratos CN Inner join NominaLiquida NL on CN.NominaLiquida = NL.Sec Where CN.Contrato=" + dt.Rows(incre)("CodContrato").ToString + " And NL.Periodo =" + SecPeriodo
    '                                                    Dim SecNomLiquidaCont As String = "", Mitb As DataTable = SMT_AbrirTabla(ObjetoApiNomina, Sentenciasql)
    '                                                    SecNomLiquidaCont = Mitb.Rows(0)(0).ToString

    '                                                    If GuardaNominaLiquidaVariables(ObjetoApiNomina, SecNomLiquidaCont, ColumnasVP.Rows(i)("ValorDefecto").ToString, ColumnasVP.Rows(i)("Sec").ToString) Then
    '                                                    Else
    '                                                        wait.Terminar()
    '                                                        Exit Sub
    '                                                    End If
    '                                                Next
    '                                            End If
    '                                            encontro = False
    '                                        Else
    '                                            wait.Terminar()
    '                                            Exit Sub
    '                                        End If
    '                                    Else
    '                                        If ColumnasVP.Rows.Count > 0 Then
    '                                            For i As Integer = 0 To ColumnasVP.Rows.Count - 1
    '                                                Dim SecNomLiquidaCont As String = "", Mitb As DataTable = SMT_AbrirTabla(ObjetoApiNomina, "SELECT CN.Sec AS Codigo FROM NominaLiquidaContratos CN Inner join NominaLiquida NL on CN.NominaLiquida = NL.Sec Where CN.Contrato=" + dt.Rows(incre)("CodContrato").ToString + " And NL.Periodo =" + SecPeriodo)
    '                                                SecNomLiquidaCont = Mitb.Rows(0)(0).ToString
    '                                                If Not ExisteDato("NominaLiquidaVariables", String.Format("SecLiquidaContrato='{0}' And Variable='{1}' ", SecNomLiquidaCont, ColumnasVP.Rows(i)("Sec").ToString), ObjetoApiNomina) Then
    '                                                    If GuardaNominaLiquidaVariables(ObjetoApiNomina, SecNomLiquidaCont, ColumnasVP.Rows(i)("ValorDefecto").ToString, ColumnasVP.Rows(i)("Sec").ToString) Then
    '                                                    Else
    '                                                        wait.Terminar()
    '                                                        Exit Sub
    '                                                    End If
    '                                                End If
    '                                            Next
    '                                        End If
    '                                    End If
    '                                Next
    '                            Else
    '                                For incre As Integer = 0 To dt.Rows.Count - 1
    '                                    If GuardaNominaLiquidaContratos(ObjetoApiNomina, dt.Rows(incre)("CodContrato").ToString, SecNominaLiquida, "0", dt.Rows(incre)("HorasMes").ToString,
    '                                                                            dt.Rows(incre)("CargoActual").ToString, dt.Rows(incre)("Asignacion").ToString, "0", "0", "0", "", "0") Then
    '                                        If ColumnasVP.Rows.Count > 0 Then
    '                                            For i As Integer = 0 To ColumnasVP.Rows.Count - 1
    '                                                Dim SecNomLiquidaCont As String = "", Mitb As DataTable = SMT_AbrirTabla(ObjetoApiNomina, "SELECT CN.Sec AS Codigo FROM NominaLiquidaContratos CN Inner join NominaLiquida NL on CN.NominaLiquida = NL.Sec Where CN.Contrato=" + dt.Rows(incre)("CodContrato").ToString + " And NL.Periodo =" + SecPeriodo)
    '                                                SecNomLiquidaCont = Mitb.Rows(0)(0).ToString
    '                                                If GuardaNominaLiquidaVariables(ObjetoApiNomina, SecNomLiquidaCont, "0", ColumnasVP.Rows(i)("Sec").ToString) Then
    '                                                Else
    '                                                    wait.Terminar()
    '                                                    Exit Sub
    '                                                End If
    '                                            Next
    '                                        End If
    '                                    Else
    '                                        wait.Terminar()
    '                                        Exit Sub
    '                                    End If
    '                                Next
    '                            End If
    '                        Else
    '                            HDevExpre.MensagedeError("No se han encontrato Empleados para esta nomina!..")
    '                        End If
    '                    ElseIf ExisteDato("NominaLiquidada", String.Format("Periodo='{0}' And Estado<>'A' ", SecPeriodo), ObjetoApiNomina) Then
    '                        HDevExpre.MensagedeError("Este periodo ya ha sido liquidado!..")
    '                        wait.Terminar()
    '                        Exit Sub
    '                    Else
    '                        wait.Terminar()
    '                        If HDevExpre.MsgSamit("Desea partir con los datos del ultimo periodo liquidado?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
    '                            BasaLiquidaAntigua = True
    '                            wait.Mostrar()
    '                            wait.Descripcion = "Importando Nomina..."
    '                        Else
    '                            BasaLiquidaAntigua = False
    '                            wait.Mostrar()
    '                            wait.Descripcion = "Creando Nomina..."
    '                        End If
    '                        If GuardaNominaLiquida(ObjetoApiNomina) Then
    '                            sql = " Select C.Asignacion AS Asignacion,C.CodContrato AS CodContrato,C.HorasMes AS HorasMes,C.CargoActual AS CargoActual, " +
    '                                    " CC.Cargo As Cargo from Contratos C INNER JOIN Contrato_Cargos CC ON C.CargoActual = CC.SecCargos where C.Nomina =" + txtNominas.ValordelControl + " And C.Plantilla <> '' And C.Terminado=0"

    '                            dt = SMT_AbrirTabla(ObjetoApiNomina, sql)
    '                            If dt.Rows.Count > 0 Then
    '                                For incre As Integer = 0 To dt.Rows.Count - 1
    '                                    Dim dt2 As DataTable = SMT_AbrirTabla(ObjetoApiNomina, "SELECT ISNULL( MAX (Sec),0) AS Codigo FROM NominaLiquida Where Periodo =" + SecPeriodo)
    '                                    If GuardaNominaLiquidaContratos(ObjetoApiNomina, dt.Rows(incre)("CodContrato").ToString, dt2.Rows(0)(0).ToString, "0",
    '                                                                            dt.Rows(incre)("HorasMes").ToString, dt.Rows(incre)("CargoActual").ToString,
    '                                                                            dt.Rows(incre)("Asignacion").ToString, "0", "0", "0", "", "0") Then
    '                                        If ColumnasVP.Rows.Count > 0 Then
    '                                            Dim SecNomLiquidaCont As String = "", Mitb As DataTable = SMT_AbrirTabla(ObjetoApiNomina, "SELECT CN.Sec AS Codigo FROM NominaLiquidaContratos CN Inner join NominaLiquida NL on CN.NominaLiquida = NL.Sec Where CN.Contrato=" + dt.Rows(incre)("CodContrato").ToString + " And NL.Periodo =" + SecPeriodo)
    '                                            SecNomLiquidaCont = Mitb.Rows(0)(0).ToString
    '                                            Dim dtLiquidaAntigua As DataTable = New DataTable
    '                                            Dim dtVarLiquidaAntigua As DataTable = New DataTable

    '                                            If BasaLiquidaAntigua Then
    '                                                dtLiquidaAntigua = SMT_AbrirTabla(ObjetoApiNomina, "Select Nl.Sec From NominaLiquidada NL Inner Join PeriodosLiquidacion PL on NL.Periodo = PL.Sec WHERE NL.Estado='L' And PL.NumPeriodoNom=" + NumPeriodoNom + "-1 And PL.Nomina=" + CodNomina + " And PL.Año=" + Año)
    '                                                If dtLiquidaAntigua.Rows.Count > 0 Then
    '                                                    dtVarLiquidaAntigua = SMT_AbrirTabla(ObjetoApiNomina, "select NLV.Cantidad,NLV.Variable, NLC.Contrato from NominaLiquidadaVariables NLV Inner Join NominaLiquidadaContratos NLC ON NLV.SecLiquidadaContrato = NLC.Sec Where NLC.Contrato=" + dt.Rows(incre)("CodContrato").ToString + " And NLC.NominaLiquidada=" + dtLiquidaAntigua.Rows(0)(0).ToString)
    '                                                End If
    '                                            End If

    '                                            For i As Integer = 0 To ColumnasVP.Rows.Count - 1
    '                                                If BasaLiquidaAntigua Then
    '                                                    If CInt(NumPeriodoNom) > 1 Then
    '                                                        If dtLiquidaAntigua.Rows.Count > 0 Then
    '                                                            If dtVarLiquidaAntigua.Rows.Count > 0 Then
    '                                                                Dim encontro As Boolean = False
    '                                                                For i2 As Integer = 0 To dtVarLiquidaAntigua.Rows.Count - 1
    '                                                                    If ColumnasVP.Rows(i)("Sec").ToString = dtVarLiquidaAntigua.Rows(i2)("Variable").ToString Then
    '                                                                        If GuardaNominaLiquidaVariables(ObjetoApiNomina, SecNomLiquidaCont, dtVarLiquidaAntigua.Rows(i2)("Cantidad").ToString, ColumnasVP.Rows(i)("Sec").ToString) Then
    '                                                                            encontro = True
    '                                                                        Else
    '                                                                            wait.Terminar()
    '                                                                            Exit Sub
    '                                                                        End If
    '                                                                    End If
    '                                                                Next
    '                                                                If Not encontro Then
    '                                                                    If GuardaNominaLiquidaVariables(ObjetoApiNomina, SecNomLiquidaCont, ColumnasVP.Rows(i)("ValorDefecto").ToString, ColumnasVP.Rows(i)("Sec").ToString) Then
    '                                                                    Else
    '                                                                        wait.Terminar()
    '                                                                        Exit Sub
    '                                                                    End If
    '                                                                End If
    '                                                            Else
    '                                                                If GuardaNominaLiquidaVariables(ObjetoApiNomina, SecNomLiquidaCont, ColumnasVP.Rows(i)("ValorDefecto").ToString, ColumnasVP.Rows(i)("Sec").ToString) Then
    '                                                                Else
    '                                                                    wait.Terminar()
    '                                                                    Exit Sub
    '                                                                End If
    '                                                            End If
    '                                                        Else
    '                                                            If GuardaNominaLiquidaVariables(ObjetoApiNomina, SecNomLiquidaCont, ColumnasVP.Rows(i)("ValorDefecto").ToString, ColumnasVP.Rows(i)("Sec").ToString) Then
    '                                                            Else
    '                                                                wait.Terminar()
    '                                                                Exit Sub
    '                                                            End If
    '                                                        End If
    '                                                    Else
    '                                                        If GuardaNominaLiquidaVariables(ObjetoApiNomina, SecNomLiquidaCont, ColumnasVP.Rows(i)("ValorDefecto").ToString, ColumnasVP.Rows(i)("Sec").ToString) Then
    '                                                        Else
    '                                                            wait.Terminar()
    '                                                            Exit Sub
    '                                                        End If
    '                                                    End If
    '                                                Else
    '                                                    If GuardaNominaLiquidaVariables(ObjetoApiNomina, SecNomLiquidaCont, ColumnasVP.Rows(i)("ValorDefecto").ToString, ColumnasVP.Rows(i)("Sec").ToString) Then
    '                                                    Else
    '                                                        wait.Terminar()
    '                                                        Exit Sub
    '                                                    End If
    '                                                End If
    '                                            Next
    '                                        End If
    '                                    Else
    '                                        wait.Terminar()
    '                                        Exit Sub
    '                                    End If
    '                                Next
    '                            Else
    '                                HDevExpre.MensagedeError("No se han encontrato Empleados para esta nomina!..")
    '                            End If
    '                        Else
    '                            wait.Terminar()
    '                            Exit Sub
    '                        End If
    '                    End If
    '                End If
    '            End If
    '        End If
    '        ConsultaDatos(ObjetoApiNomina)
    '        If gvLiquidaNomina.RowCount > 0 Then
    '            Dim dtos = CType(gcLiquidaNomina.DataSource, DataTable)
    '            CreagrillaVerticalID(ObjetoApiNomina, gvLiquidaNomina.GetFocusedRowCellValue("CodContrato").ToString, gvLiquidaNomina.GetFocusedRowCellValue("PlantillaEmpl").ToString, gvLiquidaNomina.GetFocusedRowCellValue("ConceptosContratos").ToString)
    '        End If
    '        CreagrillaVerticalP()
    '        PasarValores()
    '        CreagrillaVerticalDPN()
    '    'trans.Complete()
    '    'End Using
    '    wait.Terminar()
    'End Sub


    Public Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        EstaLiquidando = False
        Dim wait As New ClEspera
        wait.Mostrar()
        wait.Descripcion = "Buscando..."

        SMT_EjcutarComandoSql(ObjetoApiNomina, "set dateformat dmy", 0)

        Try
            If txtPeriodos.ValordelControl = "" Or txtPeriodos.DescripciondelControl = "No Se Encontraron Registros" Or txtPeriodos.DescripciondelControl = "" Then
                HDevExpre.MensagedeError("El campo Periodo no puede estar vacio, ni contener valores invalidos!..")
                SecPeriodo = ""
                wait.Terminar()
                Exit Sub
            End If

            ' OPTIMIZACIÓN: Todas las consultas iniciales en una sola llamada
            Dim sqlConsultaInicial = New String() {
            "SELECT p.Sec, p.PeriodoMes, p.NumPeriodoNom, p.NumMes, p.Estado, p.FechaInicio, p.Nomina " &
            "FROM PeriodosLiquidacion p WHERE p.CodPeriodo = " & txtPeriodos.ValordelControl,
            "SELECT COUNT(*) as PeriodosAnteriores FROM PeriodosLiquidacion p1 " &
            "WHERE EXISTS (SELECT 1 FROM PeriodosLiquidacion p2 WHERE p2.CodPeriodo = " & txtPeriodos.ValordelControl & " " &
            "AND p1.Sec < p2.Sec AND p1.Estado = 'P' AND p1.Año = " & txtAño.ValordelControl & " " &
            "AND p1.Nomina = " & txtNominas.ValordelControl & " AND p1.FechaFin < p2.FechaInicio)",
            "SELECT " &
            "CASE WHEN EXISTS(SELECT 1 FROM NominaLiquidada nl JOIN PeriodosLiquidacion p ON nl.Periodo = p.Sec " &
            "WHERE p.CodPeriodo = " & txtPeriodos.ValordelControl & " AND nl.Estado <> 'A') THEN 'LIQUIDADO' " &
            "WHEN EXISTS(SELECT 1 FROM NominaLiquida nl JOIN PeriodosLiquidacion p ON nl.Periodo = p.Sec " &
            "WHERE p.CodPeriodo = " & txtPeriodos.ValordelControl & " AND nl.EsBorrador = 1) THEN 'BORRADOR' " &
            "ELSE 'NO_EXISTE' END AS EstadoNomina, " &
            "ISNULL((SELECT nl.Sec FROM NominaLiquida nl JOIN PeriodosLiquidacion p ON nl.Periodo = p.Sec " &
            "WHERE p.CodPeriodo = " & txtPeriodos.ValordelControl & " AND nl.EsBorrador = 1), 0) AS SecNominaLiquida",
            "SELECT c.CodContrato, c.HorasMes, c.CargoActual, c.Asignacion " &
            "FROM Contratos c " &
            "INNER JOIN Contrato_Cargos cc ON c.CargoActual = cc.Cargo And c.Sec=cc.Contrato " &
            "WHERE c.Nomina = " & txtNominas.ValordelControl & " " &
            "AND c.Plantilla IS NOT NULL AND c.Plantilla <> '' AND c.Terminado = 0",
            "SELECT Sec, ValorDefecto, NomVariable, EsPredeterminado " &
            "FROM VariablesPersonales " &
            "WHERE EsPredeterminado = 1 OR (Vigente = 1 AND EsPredeterminado = 0)",
            "select CN.NomConcepto as Nombre,CCN.Formula,CN.Base,CN.Redondea,CCN.Nomina from ConceptosNomina CN INNER JOIN ConfigConceptos CCN ON CCN.Concepto = CN.Sec WHERE CCN.Nomina = " & txtNominas.ValordelControl & ""
        }

            ' Una sola llamada para obtener todos los datos iniciales
            Dim dsInicial = SMT_GetDataset(ObjetoApiNomina, sqlConsultaInicial)

            ' Procesar resultados
            Dim dtPeriodo = dsInicial.Tables(0)
            Dim dtPeriodosAnteriores = dsInicial.Tables(1)
            Dim dtEstadoNomina = dsInicial.Tables(2)
            Dim dtContratos = dsInicial.Tables(3)
            Dim dtVariables = dsInicial.Tables(4)
            Conceptos = dsInicial.Tables(5)

            ' Validar periodo
            If dtPeriodo.Rows.Count = 0 Then
                HDevExpre.MensagedeError("No se encontró el periodo seleccionado")
                wait.Terminar()
                Exit Sub
            End If

            ' Asignar variables globales
            Dim filaPeriodo = dtPeriodo.Rows(0)
            SecPeriodo = filaPeriodo("Sec").ToString()
            NumPeriodo = filaPeriodo("PeriodoMes").ToString()
            NumPeriodoNom = filaPeriodo("NumPeriodoNom").ToString()
            NumMes = filaPeriodo("NumMes").ToString()
            Año = txtAño.ValordelControl
            CodNomina = txtNominas.ValordelControl

            ' Validar si ya está liquidado
            If filaPeriodo("Estado").ToString() = "L" Then
                HDevExpre.MensagedeError("Este periodo ya ha sido liquidado!..")
                wait.Terminar()
                Exit Sub
            End If

            ' Validar periodos anteriores
            If CInt(dtPeriodosAnteriores.Rows(0)("PeriodosAnteriores")) > 0 Then
                HDevExpre.MensagedeError("Hay Periodos anteriores que aún no se han liquidado!..")
                wait.Terminar()
                Exit Sub
            End If

            ' Verificar estado de la nómina
            Dim estadoNomina = dtEstadoNomina.Rows(0)("EstadoNomina").ToString()

            If estadoNomina = "LIQUIDADO" Then
                HDevExpre.MensagedeError("Este periodo ya ha sido liquidado!..")
                wait.Terminar()
                Exit Sub
            ElseIf estadoNomina = "BORRADOR" Then
                ' Si existe borrador, solo cargar datos
                SecNominaLiquida = dtEstadoNomina.Rows(0)("SecNominaLiquida").ToString()
                'ConsultaDatos()
                'wait.Terminar()
                'Exit Sub
            End If

            ' Validar contratos
            If dtContratos.Rows.Count = 0 Then
                HDevExpre.MensagedeError("No se han encontrado empleados para esta nómina!")
                wait.Terminar()
                Exit Sub
            End If

            ' Si no existe, crear nueva liquidación

            wait.Terminar()

            Dim basarEnAnterior = False
            If SecNominaLiquida <> "" And SecNominaLiquida <> "0" Then
                wait.Mostrar()
                wait.Descripcion = "Buscando Nómina..."
            Else
                If HDevExpre.MsgSamit("¿Desea partir con los datos del último periodo liquidado?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    basarEnAnterior = True
                    wait.Mostrar()
                    wait.Descripcion = "Importando Nómina..."
                Else
                    wait.Mostrar()
                    wait.Descripcion = "Creando Nómina..."
                End If
            End If


            ' Crear request para el procedimiento almacenado
            Dim request As New UpsertLiquidacionNominaRequest With {
            .Periodo = CInt(SecPeriodo),
            .OfiNomina = CInt(txtOficina.ValordelControl),
            .OfiRegistra = CInt(ObjetosNomina.Datos.Seguridad.DatosDeLaEmpresa.NumEmpresa),
            .Nomina = CInt(CodNomina),
            .Año = CInt(Año),
            .NumPeriodo = CInt(NumPeriodo),
            .NumMes = CInt(NumMes),
            .BasarEnPeriodoAnterior = basarEnAnterior,
            .Usuario = ObjetosNomina.Datos.Smt_Usuario,
            .Terminal = ObjetosNomina.Datos.Smt_NombreTerminal,
            .FechaSys = ObjetosNomina.Datos.Smt_FechaDelServidor
        }

            ' Agregar contratos
            For Each row As DataRow In dtContratos.Rows
                request.Contratos.Add(New ContratoLiquidacionDto With {
                .CodContrato = CInt(row("CodContrato")),
                .HorasMes = CInt(row("HorasMes")),
                .CargoActual = CInt(row("CargoActual")),
                .Asignacion = CDec(row("Asignacion"))
            })
            Next

            ' Agregar variables
            For Each row As DataRow In dtVariables.Rows
                request.VariablesDefecto.Add(New VariableDefectoDto With {
                .SecVariable = CInt(row("Sec")),
                .ValorDefecto = CDec(If(IsDBNull(row("ValorDefecto")), 0, row("ValorDefecto")))
            })
            Next

            Dim json = request.ToJObject().ToString()
            json = json.Replace("Año", "Anio")
            Dim jObject As JObject = JObject.Parse(json)

            ' Ejecutar procedimiento almacenado
            Dim resp = SMT_EjecutaProcedimientos(ObjetoApiNomina, "SP_UpsertLiquidacionNomina", jObject)
            Dim response = resp.ToObject(Of UpsertLiquidacionNominaResponse)()

            If response.EsExitoso Then
                SecNominaLiquida = response.SecNominaLiquida.ToString()

                ' Cargar datos
                ConsultaDatos()

                If gvLiquidaNomina.RowCount > 0 Then
                    Dim dtos = CType(gcLiquidaNomina.DataSource, DataTable)
                    CreagrillaVerticalID(ObjetoApiNomina, gvLiquidaNomina.GetFocusedRowCellValue("CodContrato").ToString(),
                                   gvLiquidaNomina.GetFocusedRowCellValue("PlantillaEmpl").ToString(),
                                   gvLiquidaNomina.GetFocusedRowCellValue("ConceptosContratos").ToString())
                End If

                CreagrillaVerticalP()
                PasarValores()
                CreagrillaVerticalDPN()

                wait.Terminar()

                Dim mensaje = $"Liquidación creada exitosamente. " &
                         $"Contratos: {response.ContratosCreados} nuevos, {response.ContratosActualizados} actualizados. " &
                         $"Variables creadas: {response.VariablesCreadas}"

                HDevExpre.mensajeExitoso(mensaje)
            Else
                wait.Terminar()
                HDevExpre.MensagedeError($"Error al crear la liquidación: {response.Mensaje}")
            End If

        Catch ex As Exception
            wait.Terminar()
            HDevExpre.msgError(ex, ex.Message, "btnBuscar_Click")
        End Try
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

    Private Sub txtPeriodos_EntraControl(sender As Object, e As EventArgs) Handles txtPeriodos.EntraControl
        If txtNominas.ValordelControl = "" Or txtNominas.DescripciondelControl = "No Se Encontraron Registros" Or txtNominas.DescripciondelControl = "" Then
            txtNominas.Focus()
        Else
            txtPeriodos.ConsultaSQL = String.Format("SELECT CodPeriodo AS Codigo,Descripcion As Descripcion FROM  PeriodosLiquidacion where año ='{0}' And Nomina='{1}' And Estado<>'L'", txtAño.ValordelControl, txtNominas.ValordelControl)
            txtPeriodos.RefrescarDatos()
        End If
    End Sub

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

    Private Sub btnEliminarBorrador_Click(sender As Object, e As EventArgs) Handles btnEliminarBorrador.Click
        If HDevExpre.MsgSamit("Seguro que desea eliminar este borrador?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.OK Then

            Dim wait As New ClEspera
            wait.Mostrar()
            wait.Descripcion = "Eliminando Datos..."
            If EliminarBorrador() Then
                LimpiarTodosCampos(ObjetoApiNomina)
                wait.Terminar()
                HDevExpre.mensajeExitoso("El Borrador ha sido eliminado correctamente!..")
            Else
                Exit Sub
                wait.Terminar()
            End If
        End If
    End Sub

    Private Sub btnImpDetallado_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnImpDetallado.ItemClick
        Try
            If gvLiquidaNomina.RowCount = 0 Then Exit Sub
            'SQL PARA NOMINAS EN BORRADOR
            GuardarConceptos()
            Dim sql As String = String.Format("SELECT EM.Identificacion,CAST(CAST(EM.Identificacion AS VARCHAR) +' | '+ RTRIM(LTRIM(RTRIM(LTRIM(EM.PNombre)) + ' ' + " +
              " RTRIM(LTRIM(EM.SNombre)) + ' ' +  RTRIM(LTRIM(EM.PApellido)) + ' ' + RTRIM(LTRIM(EM.SApellido)))) AS VARCHAR) AS Nombres, " +
              " CP.Sec AS SecConcep,CP.NomConcepto, NLC.Valor, CP.Tipo, TP.NomTipo,CT.IdContrato" +
              " FROM NominaLiquidaConceptos NLC" +
              " INNER JOIN NominaLiquidaContratos NCT ON NLC.LiquidaContrato = NCT.Sec" +
              " INNER JOIN NominaLiquida NL ON NCT.NominaLiquida = NL.Sec" +
              " INNER JOIN Contratos CT ON NCT.Contrato = CT.CodContrato" +
              " INNER JOIN ConceptosNomina CP ON NLC.SecConcepto = CP.Sec" +
              " INNER JOIN TiposConceptosNomina TP ON CP.Tipo = TP.Sec" +
              " INNER JOIN Empleados EM ON CT.Empleado = EM.IdEmpleado" +
              " WHERE NL.Periodo = {0} AND NLC.Valor > 0 ORDER BY Identificacion", Me.SecPeriodo)
            clImprimir.ImprimeXperiodoDetalle(sql, CInt(Me.SecPeriodo), txtPeriodos.DescripciondelControl, CInt(txtNominas.ValordelControl), txtNominas.DescripciondelControl, True, "Borrador.." + txtPeriodos.DescripciondelControl)
            'End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnImpBasica_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnImpBasica.ItemClick
        Try
            If gvLiquidaNomina.RowCount = 0 Then Exit Sub
            GuardarConceptos()
            Dim sql As String = "SELECT EM.Identificacion, CT.IdContrato,RTRIM(LTRIM(RTRIM(LTRIM(EM.PNombre)) + ' ' +  " +
            " RTRIM(LTRIM(EM.SNombre)) + ' ' +  RTRIM(LTRIM(EM.PApellido)) + ' ' +  RTRIM(LTRIM(EM.SApellido)))) As Nombres, " +
            " ISNULL(EM.NumCuenta,'Sin # Cuenta definido')+' | '+ISNULL(BC.Nombre,' Sin Banco Definido') As Banco," +
            " NCT.TotalIngresos,NCT.TotalDeducciones,NCT.TotalProvisiones,NCT.TotalDescuentosNomina, (NCT.TotalIngresos - NCT.TotalDeducciones - NCT.TotalDescuentosNomina) AS NetoApagar" +
            " FROM NominaLiquidaContratos NCT" +
            " INNER JOIN NominaLiquida NL ON NCT.NominaLiquida = NL.Sec" +
            " INNER JOIN Contratos CT ON NCT.Contrato = CT.CodContrato" +
            " INNER JOIN Empleados EM ON CT.Empleado = EM.IdEmpleado " +
            " LEFT JOIN CAT_Bancos BC ON EM.codBanco = BC.Sec " +
            " WHERE NL.Periodo =" & Me.SecPeriodo
            clImprimir.ImprimeXperiodo(sql, CInt(Me.SecPeriodo),
                                       txtPeriodos.DescripciondelControl,
                                       CInt(txtNominas.ValordelControl), txtNominas.DescripciondelControl, True, "Borrador..")

        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "btnImpBasica_ItemClick")
        End Try
    End Sub

    Private Sub btnImpTotalesXperiodo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnImpTotalesXperiodo.ItemClick
        Try
            If gvLiquidaNomina.RowCount = 0 Then Exit Sub
            GuardarConceptos()
            Dim sql As String = String.Format("SELECT CP.Sec AS SecConcep,CP.NomConcepto, " +
            " SUM(NLC.Base) AS Base,NLC.NomBase,CP.Tipo,TP.NomTipo,SUM(NLC.Valor) AS Valor " +
            " FROM NominaLiquidaConceptos NLC " +
            " INNER JOIN NominaLiquidaContratos NCT ON NLC.LiquidaContrato = NCT.Sec " +
            " INNER JOIN NominaLiquida NL ON NCT.NominaLiquida = NL.Sec " +
            " INNER JOIN ConceptosNomina CP ON NLC.SecConcepto = CP.Sec " +
            " INNER JOIN TiposConceptosNomina TP ON CP.Tipo = TP.Sec WHERE NL.Periodo = {0} " +
            " GROUP BY CP.Sec,CP.NomConcepto,CP.Tipo,TP.NomTipo,NLC.NomBase HAVING SUM(NLC.Valor)>0", Me.SecPeriodo)
            clImprimir.ImprimeTotalesXperiodoDetalle(sql, CInt(Me.SecPeriodo), txtPeriodos.DescripciondelControl,
                                                     CInt(txtNominas.ValordelControl), txtNominas.DescripciondelControl, True, "Borrador.." + txtPeriodos.DescripciondelControl)

        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "btnImpTotalesXperiodo_ItemClick")
        End Try
    End Sub

    Private Sub menuImprimir_KeyPress(sender As Object, e As KeyPressEventArgs) Handles menuImprimir.KeyPress, btnSalir.KeyPress, btnLiquidar.KeyPress, btnLimpiar.KeyPress, btnEliminarBorrador.KeyPress, btnBuscar.KeyPress, btnBorradores.KeyPress
        HDevExpre.AtrasConScape(e)
    End Sub

    Private Sub gvLiquidaNomina_ShowingEditor(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles gvLiquidaNomina.ShowingEditor
        If gvLiquidaNomina.FocusedColumn.Name <> "Comentario" Then
            Dim dtVP = SMT_AbrirTabla(ObjetoApiNomina, "Select CodDian,Sec From VariablesPersonales Where NomVariable='" + gvLiquidaNomina.FocusedColumn.Name + "'")
            Dim CodDian As String = If(dtVP.Rows.Count > 0, dtVP.Rows(0)(0).ToString, "")
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
        Dim Ruta As String = My.Computer.FileSystem.SpecialDirectories.Desktop + "\" + txtPeriodos.DescripciondelControl + ".xlsx", Guardar As New SaveFileDialog
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