Imports DevExpress.XtraReports.UI
Imports SamitCtlNet

Public Class ClaseImprimir
    Dim HDevExpre As New HelperDevExpress
    Dim HNomina As New HelperNomina
    Public Sub ImprimeXperiodoDetalle(sql As String, codPeriodo As Integer, desPeriodo As String, codNomina As Integer, desNomina As String, EsBorrador As Boolean, DescripcionLiquida As String)
        Try
            Dim dt As DataTable = SMT_AbrirTabla(ObjetoApiNomina, sql)
            If dt.Rows.Count <= 0 Then
                HDevExpre.MensagedeError("Lo sentimos, no se han encontrado conceptos para este contrato!..")
            Else
                Dim RPT As New RptNominasXperiodoDetalle
                Dim tel1 = "", tel2 = "", tels As String = ""
                RPT.lblNitEmp.Text = String.Format("Nit: {0}-{1}    {2}", ObjetosNomina.Datos.Seguridad.DatosDeLaEmpresa.Nit, ObjetosNomina.Datos.Seguridad.DatosDeLaEmpresa.DV, ObjetosNomina.Datos.Seguridad.DatosDeLaEmpresa.RegimenIva)
                If ObjetosNomina.Datos.Seguridad.DatosDeLaEmpresa.TipodePersona = Clseguridad.TipoPersona.PersonaJuridica Then
                    RPT.lblNomEmp.Text = ObjetosNomina.Datos.Seguridad.DatosDeLaEmpresa.NombreEmpresa
                    RPT.lblOficina.Text = ObjetosNomina.Datos.Seguridad.DatosDeLaEmpresa.OficinaIngreso.NombreComercial
                    RPT.LblDireccionEmpresa.Text = ObjetosNomina.Datos.Seguridad.DatosDeLaEmpresa.OficinaIngreso.Direccion
                Else
                    RPT.lblNomEmp.Text = ObjetosNomina.Datos.Seguridad.DatosDeLaEmpresa.OficinaIngreso.NombreComercial
                    RPT.lblOficina.Text = ObjetosNomina.Datos.Seguridad.DatosDeLaEmpresa.NombreEmpresa
                    If ObjetosNomina.Datos.Seguridad.DatosDeLaEmpresa.OficinaIngreso.Telefono1.Trim <> "" Then
                        tel1 = ObjetosNomina.Datos.Seguridad.DatosDeLaEmpresa.OficinaIngreso.Telefono1.Trim
                    End If
                    If ObjetosNomina.Datos.Seguridad.DatosDeLaEmpresa.OficinaIngreso.Telefono2.Trim <> "" Then
                        tel2 = String.Format("- {0}", ObjetosNomina.Datos.Seguridad.DatosDeLaEmpresa.OficinaIngreso.Telefono2.Trim)
                    End If
                    tels = String.Format("{0} {1}", tel1, tel2)
                    RPT.LblDireccionEmpresa.Text = ObjetosNomina.Datos.Seguridad.DatosDeLaEmpresa.OficinaIngreso.Direccion + " | Tels : " + tels
                End If

                Dim dtFinal As DataTable = New DataTable
                dtFinal.Columns.Add("Identificacion", GetType(String))
                dtFinal.Columns.Add("Nombres", GetType(String))
                dtFinal.Columns.Add("IdContrato", GetType(String))
                dtFinal.Columns.Add("SecConcep", GetType(Integer))
                dtFinal.Columns.Add("NomConcepto", GetType(String))
                dtFinal.Columns.Add("Fondos", GetType(Decimal))
                dtFinal.Columns.Add("Provisiones", GetType(Decimal))
                dtFinal.Columns.Add("Ingresos", GetType(Decimal))
                dtFinal.Columns.Add("Deducciones", GetType(Decimal))
                dtFinal.Columns.Add("Descuentos", GetType(Decimal))
                For Each fila As DataRow In dt.Rows
                    Dim f As DataRow = dtFinal.NewRow
                    Select Case fila("NomTipo").ToString
                        Case Is = "Ingresos"
                            f("Identificacion") = fila("Identificacion")
                            f("Nombres") = fila("Nombres")
                            f("IdContrato") = fila("IdContrato")
                            f("SecConcep") = fila("SecConcep")
                            f("NomConcepto") = fila("NomConcepto")
                            f("Ingresos") = fila("Valor")
                            f("Deducciones") = 0
                            f("Descuentos") = 0
                            dtFinal.Rows.Add(f)
                            dtFinal.AcceptChanges()
                        Case Is = "Deducciones"
                            f("Identificacion") = fila("Identificacion")
                            f("Nombres") = fila("Nombres")
                            f("IdContrato") = fila("IdContrato")
                            f("SecConcep") = fila("SecConcep")
                            f("NomConcepto") = fila("NomConcepto")
                            f("Ingresos") = 0
                            f("Deducciones") = fila("Valor")
                            f("Descuentos") = 0
                            dtFinal.Rows.Add(f)
                            dtFinal.AcceptChanges()
                        Case Is = "Descuento"
                            f("Identificacion") = fila("Identificacion")
                            f("Nombres") = fila("Nombres")
                            f("IdContrato") = fila("IdContrato")
                            f("SecConcep") = fila("SecConcep")
                            f("NomConcepto") = fila("NomConcepto")
                            f("Ingresos") = 0
                            f("Deducciones") = 0
                            f("Descuentos") = fila("Valor")
                            dtFinal.Rows.Add(f)
                            dtFinal.AcceptChanges()
                    End Select
                Next

                RPT.lblTitulo.Text = DescripcionLiquida
                If EsBorrador Then RPT.lblTituloFijo.Text += " 'BORRADOR...'"
                RPT.pcbImg.Image = ObjetosNomina.Datos.Seguridad.LogoImprime
                RPT.lblUsuario.Text = "Usuario: " + StrConv(ObjetosNomina.Datos.Smt_Usuario, VbStrConv.ProperCase)
                RPT.lblpc.Text = ObjetosNomina.Datos.Smt_NombreTerminal
                RPT.lblversionsamit.Text = String.Format("{0} V{1}", Application.ProductName, Application.ProductVersion)

                RPT.drDatosInforme.DataSource = dtFinal

                Dim groupField1 As New GroupField("Identificacion")
                RPT.ghAgrupadorXtercero.GroupFields.Add(groupField1)
                'Dim groupField2 As New GroupField("SecConcep")
                'RPT.ghAgrupadorXconcepto.GroupFields.Add(groupField2)

                RPT.lblnombre1.DataBindings.Add("Text", dtFinal, "Nombres")
                'RPT.lblGroupDescripcion.DataBindings.Add("Text", dtFinal, "NomConcepto")
                'RPT.lbltCant1.Text = String.Format("Total por {0} :", tagrupa1)
                RPT.lblTotalDeducciones.DataBindings.Add("Text", dtFinal, "Identificacion")
                RPT.lblTotlaIngresos.Summary.Running = SummaryRunning.Group
                RPT.lblTotlaIngresos.DataBindings.Add("Text", dtFinal, "Ingresos")
                RPT.lblTotlaIngresos.Summary.Func = SummaryFunc.Sum
                RPT.lblTotlaIngresos.Summary.FormatString = "{0:c2}"
                RPT.lblTotalDeducciones.Summary.Running = SummaryRunning.Group
                RPT.lblTotalDeducciones.DataBindings.Add("Text", dtFinal, "Deducciones")
                RPT.lblTotalDeducciones.Summary.Func = SummaryFunc.Sum
                RPT.lblTotalDeducciones.Summary.FormatString = "- {0:c2}"

                RPT.LblTotalDecuentos.Summary.Running = SummaryRunning.Group
                RPT.LblTotalDecuentos.DataBindings.Add("Text", dtFinal, "Descuentos")
                RPT.LblTotalDecuentos.Summary.Func = SummaryFunc.Sum
                RPT.LblTotalDecuentos.Summary.FormatString = "- {0:c2}"


                'RPT.lblNetoPagar.Summary.Running = SummaryRunning.Group
                'RPT.lblNetoPagar.DataBindings.Add("Text", dtFinal, "[Ingresos]-[Deducciones]", "{0:c2}")
                ''RPT.lblNetoPagar.Summary.Func = SummaryFunc.
                'RPT.lblNetoPagar.Summary.FormatString = "{0:c2}"

                RPT.lblConcepto.DataBindings.Add("Text", dtFinal, "SecConcep")
                RPT.lblDescripConcept.DataBindings.Add("Text", dtFinal, "NomConcepto")
                RPT.lblNumContra.DataBindings.Add("Text", dtFinal, "IdContrato")
                RPT.lblIngresos.DataBindings.Add("Text", dtFinal, "Ingresos", "{0:c2}")
                RPT.lblDeducciones.DataBindings.Add("Text", dtFinal, "Deducciones", "{0:c2}")
                RPT.LblDescuentos.DataBindings.Add("Text", dtFinal, "Descuentos", "{0:c2}")

                Dim sumIngresos, sumDeducciones, sumDescuentos As Object
                sumIngresos = CType(dtFinal.Compute("Sum(Ingresos)", ""), Double)
                sumDeducciones = CType(dtFinal.Compute("Sum(Deducciones)", ""), Double)
                sumDescuentos = CType(dtFinal.Compute("Sum(Descuentos)", ""), Double)

                RPT.lblSumTotalIngresos.Text = CDbl(sumIngresos).ToString("c2")
                RPT.lblSumTotalDeducciones.Text = "-" & CDbl(sumDeducciones).ToString("c2")
                RPT.lblSumTotalDescuentos.Text = "-" & CDbl(sumDescuentos).ToString("c2")

                RPT.lblSumTotalPagar.Text = (CDbl(sumIngresos) - CDbl(sumDeducciones) - CDbl(sumDescuentos)).ToString("c2")

                Dim llamar As New SamitCtlNet.FrmImpresion() With {
               .TamañoPapel = ClFunciones.TamañoPagina.Carta,
               .EsHorizontal = False,
               .Copias = 2
             }
                Dim res As DialogResult = llamar.ShowDialog()

                Dim tamaño As System.Drawing.Printing.PaperKind = System.Drawing.Printing.PaperKind.[Custom]
                If llamar.TamañoPapel = ClFunciones.TamañoPagina.MediaCarta Then
                    tamaño = System.Drawing.Printing.PaperKind.Custom
                    llamar.EsHorizontal = False
                ElseIf llamar.TamañoPapel = ClFunciones.TamañoPagina.Carta Then
                    tamaño = System.Drawing.Printing.PaperKind.Letter
                ElseIf llamar.TamañoPapel = ClFunciones.TamañoPagina.Oficio Then
                    tamaño = System.Drawing.Printing.PaperKind.Legal
                End If


                If Not (res = DialogResult.Cancel) Then
                    Dim imprime As Boolean = False
                    Dim vistaPrevia As Boolean = False
                    If res = DialogResult.OK Then
                        imprime = True
                    ElseIf res = DialogResult.Yes Then
                        vistaPrevia = True
                    End If
                    RPT.PaperKind = tamaño
                    RPT.Landscape = llamar.EsHorizontal
                    If EsBorrador Then
                        Dim tamFuente As Single = 75
                        If tamaño = Printing.PaperKind.A4 Then
                            tamFuente = 150
                        End If
                        RPT.Watermark.Text = "BORRADOR"
                        RPT.Watermark.TextDirection = DevExpress.XtraPrinting.Drawing.DirectionMode.ForwardDiagonal
                        RPT.Watermark.Font = New Font(RPT.Watermark.Font.FontFamily, tamFuente)
                        RPT.Watermark.ForeColor = Color.Gray
                        RPT.Watermark.TextTransparency = 150
                        RPT.Watermark.ShowBehind = False
                    End If

                    If imprime Then
                        RPT.ShowPrintMarginsWarning = False
                        RPT.ShowPrintStatusDialog = False
                        RPT.PrinterName = llamar.NombreImpresora
                        RPT.AssignPrintTool(New DevExpress.XtraReports.UI.ReportPrintTool(RPT))
                        RPT.CreateDocument()
                        RPT.Print()
                        Exit Sub
                    End If
                    Dim frm As New FrmVistaPrevia(RPT)
                    If vistaPrevia Then frm.ShowDialog()
                End If
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "ImprimeXperiodo")
        End Try
    End Sub

    Public Sub ImprimeXperiodo(sql As String, codPeriodo As Integer, desPeriodo As String, codNomina As Integer, desNomina As String, EsBorrador As Boolean, DescripcionLiquida As String)
        Try
            Dim dt As DataTable = SMT_AbrirTabla(ObjetoApiNomina, sql)
            If dt.Rows.Count <= 0 Then
                HDevExpre.MensagedeError("Lo sentimos, no se han encontrado contratos!..")
            Else
                Dim dtFinal As DataTable = New DataTable
                dtFinal.Columns.Add("Identificacion", GetType(String))
                dtFinal.Columns.Add("IdContrato", GetType(String))
                dtFinal.Columns.Add("Nombres")
                dtFinal.Columns.Add("TotalIngresos", GetType(Decimal))
                dtFinal.Columns.Add("TotalDeducciones", GetType(Decimal))
                dtFinal.Columns.Add("TotalDescuentosNomina", GetType(Decimal))
                dtFinal.Columns.Add("TotalProvisiones", GetType(Decimal))
                dtFinal.Columns.Add("NetoApagar", GetType(Decimal))
                For Each fila As DataRow In dt.Rows
                    Dim f As DataRow = dtFinal.NewRow
                    f("Identificacion") = fila("Identificacion").ToString
                    f("IdContrato") = fila("IdContrato")
                    f("Nombres") = fila("Nombres").ToString + vbCrLf + fila("Banco").ToString
                    f("TotalIngresos") = fila("TotalIngresos")
                    f("TotalDeducciones") = fila("TotalDeducciones")
                    f("TotalDescuentosNomina") = fila("TotalDescuentosNomina")
                    f("TotalProvisiones") = fila("TotalProvisiones")
                    f("NetoApagar") = fila("NetoApagar")
                    dtFinal.Rows.Add(f)
                    dtFinal.AcceptChanges()
                Next

                Dim RPT As New RptNominasXperiodo
                Dim tel1 = "", tel2 = "", tels As String = ""
                RPT.lblNitEmp.Text = String.Format("Nit: {0}-{1}    {2}", ObjetosNomina.Datos.Seguridad.DatosDeLaEmpresa.Nit, ObjetosNomina.Datos.Seguridad.DatosDeLaEmpresa.DV, ObjetosNomina.Datos.Seguridad.DatosDeLaEmpresa.RegimenIva)
                If ObjetosNomina.Datos.Seguridad.DatosDeLaEmpresa.TipodePersona = Clseguridad.TipoPersona.PersonaJuridica Then
                    RPT.lblNomEmp.Text = ObjetosNomina.Datos.Seguridad.DatosDeLaEmpresa.NombreEmpresa
                    RPT.lblOficina.Text = ObjetosNomina.Datos.Seguridad.DatosDeLaEmpresa.OficinaIngreso.NombreComercial
                    RPT.LblDireccionEmpresa.Text = ObjetosNomina.Datos.Seguridad.DatosDeLaEmpresa.OficinaIngreso.Direccion
                Else
                    RPT.lblNomEmp.Text = ObjetosNomina.Datos.Seguridad.DatosDeLaEmpresa.OficinaIngreso.NombreComercial
                    RPT.lblOficina.Text = ObjetosNomina.Datos.Seguridad.DatosDeLaEmpresa.NombreEmpresa
                    If ObjetosNomina.Datos.Seguridad.DatosDeLaEmpresa.OficinaIngreso.Telefono1.Trim <> "" Then
                        tel1 = ObjetosNomina.Datos.Seguridad.DatosDeLaEmpresa.OficinaIngreso.Telefono1.Trim
                    End If
                    If ObjetosNomina.Datos.Seguridad.DatosDeLaEmpresa.OficinaIngreso.Telefono2.Trim <> "" Then
                        tel2 = String.Format("- {0}", ObjetosNomina.Datos.Seguridad.DatosDeLaEmpresa.OficinaIngreso.Telefono2.Trim)
                    End If
                    tels = String.Format("{0} {1}", tel1, tel2)
                    RPT.LblDireccionEmpresa.Text = ObjetosNomina.Datos.Seguridad.DatosDeLaEmpresa.OficinaIngreso.Direccion + " | Tels : " + tels
                End If

                RPT.lblTitulo.Text = DescripcionLiquida
                If EsBorrador Then RPT.lblTituloFijo.Text += " 'BORRADOR...'"
                RPT.pcbImg.Image = ObjetosNomina.Datos.Seguridad.LogoImprime
                RPT.lblUsuario.Text = "Usuario: " + StrConv(ObjetosNomina.Datos.Smt_Usuario, VbStrConv.ProperCase)
                RPT.lblpc.Text = ObjetosNomina.Datos.Smt_NombreTerminal
                RPT.lblversionsamit.Text = String.Format("{0} V{1}", Application.ProductName, Application.ProductVersion)

                RPT.DataSource = dtFinal
                RPT.lblNumContra.DataBindings.Add("Text", Nothing, "IdContrato")
                RPT.lblDocEmp.DataBindings.Add("Text", Nothing, "Identificacion", "{0:n0}")
                RPT.lblNombres.DataBindings.Add("Text", Nothing, "Nombres")
                'RPT.lblFondos.DataBindings.Add("Text", Nothing, "Fondos", "{0:c2}")
                'RPT.lblIngresos.DataBindings.Add("Text", Nothing, "TotalProvisiones", "{0:c2}")
                RPT.lblIngresos.DataBindings.Add("Text", Nothing, "TotalIngresos", "{0:c2}")
                RPT.lblDeducciones.DataBindings.Add("Text", Nothing, "TotalDeducciones", "{0:c2}")
                RPT.lblDescuentos.DataBindings.Add("Text", Nothing, "TotalDescuentosNomina", "{0:c2}")
                RPT.lblNetoApagar.DataBindings.Add("Text", Nothing, "NetoApagar", "{0:c2}")

                Dim sumIngresos, sumDeducciones, sumDescuentos, sumProv As Object
                sumIngresos = CType(dtFinal.Compute("Sum(TotalIngresos)", ""), Double)
                sumDeducciones = CType(dtFinal.Compute("Sum(TotalDeducciones)", ""), Double)
                sumDescuentos = CType(dtFinal.Compute("Sum(TotalDescuentosNomina)", ""), Double)
                'sumFondos = CType(dt.Compute("Sum(Fondos)", ""), Double)
                sumProv = CType(dtFinal.Compute("Sum(NetoApagar)", ""), Double)

                RPT.lblTotalIngresos.Text = CDbl(sumIngresos).ToString("c2")
                RPT.lblTotalDeducciones.Text = CDbl(sumDeducciones).ToString("c2")
                RPT.lblTotalDescuentos.Text = CDbl(sumDescuentos).ToString("c2")
                RPT.lblSumNetoPagar.Text = CDbl(sumProv).ToString("c2")
                Dim llamar As New SamitCtlNet.FrmImpresion() With {
               .TamañoPapel = ClFunciones.TamañoPagina.Carta,
               .EsHorizontal = False,
               .Copias = 2
             }
                Dim res As DialogResult = llamar.ShowDialog()

                Dim tamaño As System.Drawing.Printing.PaperKind = System.Drawing.Printing.PaperKind.[Custom]
                If llamar.TamañoPapel = ClFunciones.TamañoPagina.MediaCarta Then
                    tamaño = System.Drawing.Printing.PaperKind.Custom
                    llamar.EsHorizontal = False
                ElseIf llamar.TamañoPapel = ClFunciones.TamañoPagina.Carta Then
                    tamaño = System.Drawing.Printing.PaperKind.Letter
                ElseIf llamar.TamañoPapel = ClFunciones.TamañoPagina.Oficio Then
                    tamaño = System.Drawing.Printing.PaperKind.Legal
                End If

                If Not (res = DialogResult.Cancel) Then
                    Dim imprime As Boolean = False
                    Dim vistaPrevia As Boolean = False
                    If res = DialogResult.OK Then
                        imprime = True
                    ElseIf res = DialogResult.Yes Then
                        vistaPrevia = True
                    End If
                    RPT.PaperKind = tamaño
                    RPT.Landscape = llamar.EsHorizontal
                    If EsBorrador Then
                        Dim tamFuente As Single = 75
                        If tamaño = Printing.PaperKind.A4 Then
                            tamFuente = 150
                        End If
                        RPT.Watermark.Text = "BORRADOR"
                        RPT.Watermark.TextDirection = DevExpress.XtraPrinting.Drawing.DirectionMode.ForwardDiagonal
                        RPT.Watermark.Font = New Font(RPT.Watermark.Font.FontFamily, tamFuente)
                        RPT.Watermark.ForeColor = Color.Gray
                        RPT.Watermark.TextTransparency = 150
                        RPT.Watermark.ShowBehind = False
                    End If
                    If imprime Then
                        RPT.ShowPrintMarginsWarning = False
                        RPT.ShowPrintStatusDialog = False
                        RPT.PrinterName = llamar.NombreImpresora
                        RPT.AssignPrintTool(New DevExpress.XtraReports.UI.ReportPrintTool(RPT))
                        RPT.CreateDocument()
                        RPT.Print()
                        Exit Sub
                    End If
                    Dim frm As New FrmVistaPrevia(RPT)
                    If vistaPrevia Then frm.ShowDialog()
                End If
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "ImprimeXperiodo")
        End Try
    End Sub

    Public Sub ImprimeTotalesXperiodoDetalle(sql As String, codPeriodo As Integer, desPeriodo As String, codNomina As Integer, desNomina As String, EsBorrador As Boolean, DescripcionLiquida As String)
        Try
            Dim dt As DataTable = SMT_AbrirTabla(ObjetoApiNomina, sql)
            If dt.Rows.Count = 0 Then
                HDevExpre.MensagedeError("Lo sentimos, no se han encontrado conceptos!")
                Exit Sub
            End If
            Dim RPT As New RptTotalesXperiodo
            Dim tel1 = "", tel2 = "", tels As String = ""
            RPT.lblNitEmp.Text = String.Format("Nit: {0}-{1}    {2}", ObjetosNomina.Datos.Seguridad.DatosDeLaEmpresa.Nit, ObjetosNomina.Datos.Seguridad.DatosDeLaEmpresa.DV, ObjetosNomina.Datos.Seguridad.DatosDeLaEmpresa.RegimenIva)
            If ObjetosNomina.Datos.Seguridad.DatosDeLaEmpresa.TipodePersona = Clseguridad.TipoPersona.PersonaJuridica Then
                RPT.lblNomEmp.Text = ObjetosNomina.Datos.Seguridad.DatosDeLaEmpresa.NombreEmpresa
                RPT.lblOficina.Text = ObjetosNomina.Datos.Seguridad.DatosDeLaEmpresa.OficinaIngreso.NombreComercial
                RPT.LblDireccionEmpresa.Text = ObjetosNomina.Datos.Seguridad.DatosDeLaEmpresa.OficinaIngreso.Direccion
            Else
                RPT.lblNomEmp.Text = ObjetosNomina.Datos.Seguridad.DatosDeLaEmpresa.OficinaIngreso.NombreComercial
                RPT.lblOficina.Text = ObjetosNomina.Datos.Seguridad.DatosDeLaEmpresa.NombreEmpresa
                If ObjetosNomina.Datos.Seguridad.DatosDeLaEmpresa.OficinaIngreso.Telefono1.Trim <> "" Then
                    tel1 = ObjetosNomina.Datos.Seguridad.DatosDeLaEmpresa.OficinaIngreso.Telefono1.Trim
                End If
                If ObjetosNomina.Datos.Seguridad.DatosDeLaEmpresa.OficinaIngreso.Telefono2.Trim <> "" Then
                    tel2 = String.Format("- {0}", ObjetosNomina.Datos.Seguridad.DatosDeLaEmpresa.OficinaIngreso.Telefono2.Trim)
                End If
                tels = String.Format("{0} {1}", tel1, tel2)
                RPT.LblDireccionEmpresa.Text = ObjetosNomina.Datos.Seguridad.DatosDeLaEmpresa.OficinaIngreso.Direccion + " | Tels : " + tels
            End If
            RPT.pcbImg.Image = ObjetosNomina.Datos.Seguridad.LogoImprime
            RPT.lblUsuario.Text = "Usuario: " + StrConv(ObjetosNomina.Datos.Smt_Usuario, VbStrConv.ProperCase)
            RPT.lblpc.Text = ObjetosNomina.Datos.Smt_NombreTerminal
            RPT.lblversionsamit.Text = String.Format("{0} V{1}", Application.ProductName, Application.ProductVersion)
            RPT.lblTitulo.Text = DescripcionLiquida
            If EsBorrador Then RPT.lblTituloFijo.Text += " 'BORRADOR...'"
            RPT.drDatosInforme.DataSource = dt

            Dim groupField1 As New GroupField("NomTipo")
            RPT.ghAgrupadoXTipoConcepto.GroupFields.Add(groupField1)
            'Dim groupField2 As New GroupField("NomConcepto")
            'RPT.ghAgrupadoXTipoConcepto.GroupFields.Add(groupField2)


            RPT.lblnombre1.DataBindings.Add("Text", dt, "NomTipo")
            'RPT.lblGroupDesConcepto.DataBindings.Add("Text", dt, "NomConcepto")

            RPT.lblTotalPagar.Summary.Running = SummaryRunning.Group
            RPT.lblTotalPagar.DataBindings.Add("Text", dt, "Valor")
            RPT.lblTotalPagar.Summary.Func = SummaryFunc.Sum
            RPT.lblTotalPagar.Summary.FormatString = "{0:c2}"

            RPT.lblNumConcepto.DataBindings.Add("Text", dt, "SecConcep")
            RPT.lblNomConcep.DataBindings.Add("Text", dt, "NomConcepto")
            'RPT.lblBase.DataBindings.Add("Text", dt, "Base", "{0:n0}")
            RPT.lblBase.DataBindings.Add("Text", dt, "Base", "{0:c2}")
            RPT.lblTotal.DataBindings.Add("Text", dt, "Valor", "{0:c2}")

            Dim llamar As New SamitCtlNet.FrmImpresion() With {
          .TamañoPapel = ClFunciones.TamañoPagina.Carta,
          .EsHorizontal = False,
          .Copias = 2
        }
            Dim res As DialogResult = llamar.ShowDialog()

            Dim tamaño As System.Drawing.Printing.PaperKind = System.Drawing.Printing.PaperKind.[Custom]
            If llamar.TamañoPapel = ClFunciones.TamañoPagina.MediaCarta Then
                tamaño = System.Drawing.Printing.PaperKind.Custom
                llamar.EsHorizontal = False
            ElseIf llamar.TamañoPapel = ClFunciones.TamañoPagina.Carta Then
                tamaño = System.Drawing.Printing.PaperKind.Letter
            ElseIf llamar.TamañoPapel = ClFunciones.TamañoPagina.Oficio Then
                tamaño = System.Drawing.Printing.PaperKind.Legal
            End If

            If Not (res = DialogResult.Cancel) Then
                Dim imprime As Boolean = False
                Dim vistaPrevia As Boolean = False
                If res = DialogResult.OK Then
                    imprime = True
                ElseIf res = DialogResult.Yes Then
                    vistaPrevia = True
                End If
                RPT.PaperKind = tamaño
                RPT.Landscape = llamar.EsHorizontal
                If EsBorrador Then
                    Dim tamFuente As Single = 75
                    If tamaño = Printing.PaperKind.A4 Then
                        tamFuente = 150
                    End If
                    RPT.Watermark.Text = "BORRADOR"
                    RPT.Watermark.TextDirection = DevExpress.XtraPrinting.Drawing.DirectionMode.ForwardDiagonal
                    RPT.Watermark.Font = New Font(RPT.Watermark.Font.FontFamily, tamFuente)
                    RPT.Watermark.ForeColor = Color.Gray
                    RPT.Watermark.TextTransparency = 150
                    RPT.Watermark.ShowBehind = False
                End If
                If imprime Then
                    RPT.ShowPrintMarginsWarning = False
                    RPT.ShowPrintStatusDialog = False
                    RPT.PrinterName = llamar.NombreImpresora
                    RPT.AssignPrintTool(New DevExpress.XtraReports.UI.ReportPrintTool(RPT))
                    RPT.CreateDocument()
                    RPT.Print()
                    Exit Sub
                End If
                Dim frm As New FrmVistaPrevia(RPT)
                If vistaPrevia Then frm.ShowDialog()
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "ImprimeTotalesXperiodoDetalle")
        End Try
    End Sub

    Public Sub ImprimeTotalesXConceptos(sql As String, codPeriodo As Integer, desPeriodo As String, codNomina As Integer, desNomina As String, EsBorrador As Boolean, DescripcionLiquida As String)
        Try
            Dim dt As DataTable = SMT_AbrirTabla(ObjetoApiNomina, sql)
            If dt.Rows.Count = 0 Then
                HDevExpre.MensagedeError("Lo sentimos, error al consultar, por favor vuelva a intentarlo!")
                Exit Sub
            End If
            Dim RPT As New RptDetallesConceptos
            Dim tel1 = "", tel2 = "", tels As String = ""
            RPT.lblNitEmp.Text = String.Format("Nit: {0}-{1}    {2}", ObjetosNomina.Datos.Seguridad.DatosDeLaEmpresa.Nit, ObjetosNomina.Datos.Seguridad.DatosDeLaEmpresa.DV, ObjetosNomina.Datos.Seguridad.DatosDeLaEmpresa.RegimenIva)
            If ObjetosNomina.Datos.Seguridad.DatosDeLaEmpresa.TipodePersona = Clseguridad.TipoPersona.PersonaJuridica Then
                RPT.lblNomEmp.Text = ObjetosNomina.Datos.Seguridad.DatosDeLaEmpresa.NombreEmpresa
                RPT.lblOficina.Text = ObjetosNomina.Datos.Seguridad.DatosDeLaEmpresa.OficinaIngreso.NombreComercial
                RPT.LblDireccionEmpresa.Text = ObjetosNomina.Datos.Seguridad.DatosDeLaEmpresa.OficinaIngreso.Direccion
            Else
                RPT.lblNomEmp.Text = ObjetosNomina.Datos.Seguridad.DatosDeLaEmpresa.OficinaIngreso.NombreComercial
                RPT.lblOficina.Text = ObjetosNomina.Datos.Seguridad.DatosDeLaEmpresa.NombreEmpresa
                If ObjetosNomina.Datos.Seguridad.DatosDeLaEmpresa.OficinaIngreso.Telefono1.Trim <> "" Then
                    tel1 = ObjetosNomina.Datos.Seguridad.DatosDeLaEmpresa.OficinaIngreso.Telefono1.Trim
                End If
                If ObjetosNomina.Datos.Seguridad.DatosDeLaEmpresa.OficinaIngreso.Telefono2.Trim <> "" Then
                    tel2 = String.Format("- {0}", ObjetosNomina.Datos.Seguridad.DatosDeLaEmpresa.OficinaIngreso.Telefono2.Trim)
                End If
                tels = String.Format("{0} {1}", tel1, tel2)
                RPT.LblDireccionEmpresa.Text = ObjetosNomina.Datos.Seguridad.DatosDeLaEmpresa.OficinaIngreso.Direccion + " | Tels : " + tels
            End If
            RPT.pcbImg.Image = ObjetosNomina.Datos.Seguridad.LogoImprime
            RPT.lblUsuario.Text = "Usuario: " + StrConv(ObjetosNomina.Datos.Smt_Usuario, VbStrConv.ProperCase)
            RPT.lblpc.Text = ObjetosNomina.Datos.Smt_NombreTerminal
            RPT.lblversionsamit.Text = String.Format("{0} V{1}", Application.ProductName, Application.ProductVersion)
            RPT.lblTitulo.Text = DescripcionLiquida
            If EsBorrador Then RPT.lblTituloFijo.Text += " 'BORRADOR...'"
            RPT.drDatosInforme.DataSource = dt

            Dim groupField1 As New GroupField("NomConcepto")
            RPT.ghAgrupadoXTipoConcepto.GroupFields.Add(groupField1)
            'Dim groupField2 As New GroupField("NomConcepto")
            'RPT.ghAgrupadoXTipoConcepto.GroupFields.Add(groupField2)


            RPT.lblnombre1.DataBindings.Add("Text", dt, "NomConcepto")
            'RPT.lblGroupDesConcepto.DataBindings.Add("Text", dt, "NomConcepto")

            RPT.lblTotalPagar.Summary.Running = SummaryRunning.Group
            RPT.lblTotalPagar.DataBindings.Add("Text", dt, "Valor")
            RPT.lblTotalPagar.Summary.Func = SummaryFunc.Sum
            RPT.lblTotalPagar.Summary.FormatString = "{0:c2}"

            RPT.lblNumContrato.DataBindings.Add("Text", dt, "IdContrato")
            RPT.lblNombres.DataBindings.Add("Text", dt, "Nombres")
            'RPT.lblBase.DataBindings.Add("Text", dt, "Base", "{0:n0}")
            RPT.lblBase.DataBindings.Add("Text", dt, "Base", "{0:c2}")
            RPT.lblTotal.DataBindings.Add("Text", dt, "Valor", "{0:c2}")

            Dim llamar As New SamitCtlNet.FrmImpresion() With {
          .TamañoPapel = ClFunciones.TamañoPagina.Carta,
          .EsHorizontal = False,
          .Copias = 2
        }
            Dim res As DialogResult = llamar.ShowDialog()

            Dim tamaño As System.Drawing.Printing.PaperKind = System.Drawing.Printing.PaperKind.[Custom]
            If llamar.TamañoPapel = ClFunciones.TamañoPagina.MediaCarta Then
                tamaño = System.Drawing.Printing.PaperKind.Custom
                llamar.EsHorizontal = False
            ElseIf llamar.TamañoPapel = ClFunciones.TamañoPagina.Carta Then
                tamaño = System.Drawing.Printing.PaperKind.Letter
            ElseIf llamar.TamañoPapel = ClFunciones.TamañoPagina.Oficio Then
                tamaño = System.Drawing.Printing.PaperKind.Legal
            End If

            If Not (res = DialogResult.Cancel) Then
                Dim imprime As Boolean = False
                Dim vistaPrevia As Boolean = False
                If res = DialogResult.OK Then
                    imprime = True
                ElseIf res = DialogResult.Yes Then
                    vistaPrevia = True
                End If
                RPT.PaperKind = tamaño
                RPT.Landscape = llamar.EsHorizontal
                If EsBorrador Then
                    Dim tamFuente As Single = 75
                    If tamaño = Printing.PaperKind.A4 Then
                        tamFuente = 150
                    End If
                    RPT.Watermark.Text = "BORRADOR"
                    RPT.Watermark.TextDirection = DevExpress.XtraPrinting.Drawing.DirectionMode.ForwardDiagonal
                    RPT.Watermark.Font = New Font(RPT.Watermark.Font.FontFamily, tamFuente)
                    RPT.Watermark.ForeColor = Color.Gray
                    RPT.Watermark.TextTransparency = 150
                    RPT.Watermark.ShowBehind = False
                End If
                If imprime Then
                    RPT.ShowPrintMarginsWarning = False
                    RPT.ShowPrintStatusDialog = False
                    RPT.PrinterName = llamar.NombreImpresora
                    RPT.AssignPrintTool(New DevExpress.XtraReports.UI.ReportPrintTool(RPT))
                    RPT.CreateDocument()
                    RPT.Print()
                    Exit Sub
                End If
                Dim frm As New FrmVistaPrevia(RPT)
                If vistaPrevia Then frm.ShowDialog()
            End If
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "ImprimeTotalesXperiodoDetalle")
        End Try
    End Sub

End Class
