Option Explicit On
Imports System.IO
Imports System.Runtime.CompilerServices
Imports DevExpress.XtraEditors.Repository
Imports ExcelDataReader
Imports SamitCtlNet
Imports SamitNominaLogic

Public Class FrmImportarTerceros
    Dim lkEditTipoDoc As New RepositoryItemLookUpEdit
    Dim dtTipoDoc As New DataTable
    Dim lkEditGenero As New RepositoryItemLookUpEdit
    Dim dtGenero As New DataTable
    Dim lkEditProfesion As New RepositoryItemLookUpEdit
    Dim dtProfesion As New DataTable
    Dim lkEditEstadoCivil As New RepositoryItemLookUpEdit
    Dim dtEstadoCivil As New DataTable
    Dim lkEditClaseLicencia As New RepositoryItemLookUpEdit
    Dim dtClaseLicencia As New DataTable
    Dim lkEditClaseLibreta As New RepositoryItemLookUpEdit
    Dim dtClaseLibreta As New DataTable
    Dim lkEditBanco As New RepositoryItemLookUpEdit
    Dim dtBanco As New DataTable
    Dim lkEditTipoCuenta As New RepositoryItemLookUpEdit
    Dim dtTipoCuenta As New DataTable
    Dim lkEditMunicipioNacimiento As New RepositoryItemLookUpEdit
    Dim lkEditLugarExpDoc As New RepositoryItemLookUpEdit
    Dim lkEditMunicipio As New RepositoryItemLookUpEdit
    Dim dtMunicipios As New DataTable
    Dim HDevExpre As New HelperDevExpress
    Dim HNomina As New HelperNomina

    Public Datos As New SamitCtlNet.SamitCtlNet
    Private Sub FrmImportarTerceros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CreaGrilla()
        CargaLkEdit()
        btnLimpiar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Limpiar)
        btnImportar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Excell_XlsX)
        btnSalir.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.SalirCuadroConX)
        btnGuardar.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.Guardar)
        btnPlantilla.Image = HDevExpre.Imagen_boton16X16(HDevExpre.ImagenesSamit16X16.ExcelSave)
    End Sub

    Private Sub CreaGrilla()
        Try
            gvEmpleados.Columns.Clear()
            Dim color As System.Drawing.Color = Color.FromArgb(&HCC, &HFF, &HCC)
            HDevExpre.CreaColumnasG(gvEmpleados, "TipoIdentificacion", "Tipo Identificación", True, True, "", Color.FromArgb(204, 255, 204), False, False, 150.0F, 0F, DevExpress.Utils.HorzAlignment.Near, False, "", False, Nothing, False, "dd/MM/yyyy", "#,##0.####", "#,##0.##", True, Color.Blue, Color.White, True, lkEditTipoDoc, True, False)
            HDevExpre.CreaColumnasG(gvEmpleados, "Identificacion", "Identificación", True, True, "", Color.FromArgb(204, 255, 204), False, False, 150.0F, 0F, DevExpress.Utils.HorzAlignment.Near, False, "", False, Nothing, False, "dd/MM/yyyy", "#,##0.####", "#,##0.##", True, , , False, Nothing, True, False)
            HDevExpre.CreaColumnasG(gvEmpleados, "Dv", "Dv", True, True, "", Color.FromArgb(204, 255, 204), False, False, 20.0F, gcEmpleados.Width - 100, DevExpress.Utils.HorzAlignment.Near, False, "", False, Nothing, False, "dd/MM/yyyy", "#,##0.####", "#,##0.##", False, color, color, False, Nothing, True, False)
            HDevExpre.CreaColumnasG(gvEmpleados, "Papellido", "P. Apellido", True, True, "", Color.FromArgb(204, 255, 204), False, False, 20.0F, gcEmpleados.Width - 100, DevExpress.Utils.HorzAlignment.Near, False, "", False, Nothing, False, "dd/MM/yyyy", "#,##0.####", "#,##0.##", False, color, color, False, Nothing, True, False)
            HDevExpre.CreaColumnasG(gvEmpleados, "Sapellido", "S. Apellido", True, True, "", Color.FromArgb(204, 255, 204), False, False, 20.0F, gcEmpleados.Width - 100, DevExpress.Utils.HorzAlignment.Near, False, "", False, Nothing, False, "dd/MM/yyyy", "#,##0.####", "#,##0.##", False, color, color, False, Nothing, True, False)
            HDevExpre.CreaColumnasG(gvEmpleados, "Pnombre", "P. Nombre", True, True, "", Color.FromArgb(204, 255, 204), False, False, 200.0F, 0F, DevExpress.Utils.HorzAlignment.Near, False, "", False, Nothing, False, "dd/MM/yyyy", "#,##0.####", "#,##0.##", True, color, color, False, Nothing, True, False)
            HDevExpre.CreaColumnasG(gvEmpleados, "Snombre", "S. Nombre", True, True, "", Color.FromArgb(204, 255, 204), False, False, 200.0F, 0F, DevExpress.Utils.HorzAlignment.Near, False, "", False, Nothing, False, "dd/MM/yyyy", "#,##0.####", "#,##0.##", True, color, color, False, Nothing, True, False)
            HDevExpre.CreaColumnasG(gvEmpleados, "Genero", "Genero", True, True, "", Color.FromArgb(204, 255, 204), False, False, 20.0F, gcEmpleados.Width - 100, DevExpress.Utils.HorzAlignment.Near, False, "", False, Nothing, False, "dd/MM/yyyy", "#,##0.####", "#,##0.##", False, color, color, False, lkEditGenero, True, False)
            HDevExpre.CreaColumnasG(gvEmpleados, "MunicipioNacimiento", "Municipio Nacimiento", True, True, "", Color.FromArgb(204, 255, 204), False, False, 20.0F, gcEmpleados.Width - 100, DevExpress.Utils.HorzAlignment.Near, False, "", False, Nothing, False, "dd/MM/yyyy", "#,##0.####", "#,##0.##", False, color, color, False, lkEditMunicipioNacimiento, True, False)
            HDevExpre.CreaColumnasG(gvEmpleados, "FechaNacimiento", "Fecha Nacimiento", True, True, "", Color.FromArgb(204, 255, 204), False, False, 20.0F, gcEmpleados.Width - 100, DevExpress.Utils.HorzAlignment.Near, False, "", False, Nothing, False, "dd/MM/yyyy", "#,##0.####", "#,##0.##", False, color, color, False, Nothing, True, False)
            HDevExpre.CreaColumnasG(gvEmpleados, "LugarExpDoc", "Lugar Exp. Documento", True, True, "", Color.FromArgb(204, 255, 204), False, False, 20.0F, gcEmpleados.Width - 100, DevExpress.Utils.HorzAlignment.Near, False, "", False, Nothing, False, "dd/MM/yyyy", "#,##0.####", "#,##0.##", False, color, color, False, lkEditLugarExpDoc, True, False)
            HDevExpre.CreaColumnasG(gvEmpleados, "FechaExpDoc", "Fecha Exp. Documento", True, True, "", Color.FromArgb(204, 255, 204), False, False, 20.0F, gcEmpleados.Width - 100, DevExpress.Utils.HorzAlignment.Near, False, "", False, Nothing, False, "dd/MM/yyyy", "#,##0.####", "#,##0.##", False, color, color, False, Nothing, True, False)
            HDevExpre.CreaColumnasG(gvEmpleados, "MunicipioResidencia", "Municipio Residencia", True, True, "", Color.FromArgb(204, 255, 204), False, False, 20.0F, gcEmpleados.Width - 100, DevExpress.Utils.HorzAlignment.Near, False, "", False, Nothing, False, "dd/MM/yyyy", "#,##0.####", "#,##0.##", False, color, color, False, lkEditMunicipio, True, False)
            HDevExpre.CreaColumnasG(gvEmpleados, "Direccion", "Direccion", True, True, "", Color.FromArgb(204, 255, 204), False, False, 20.0F, gcEmpleados.Width - 100, DevExpress.Utils.HorzAlignment.Near, False, "", False, Nothing, False, "dd/MM/yyyy", "#,##0.####", "#,##0.##", False, color, color, False, Nothing, True, False)
            HDevExpre.CreaColumnasG(gvEmpleados, "Barrio", "Barrio", True, True, "", Color.FromArgb(204, 255, 204), False, False, 20.0F, gcEmpleados.Width - 100, DevExpress.Utils.HorzAlignment.Near, False, "", False, Nothing, False, "dd/MM/yyyy", "#,##0.####", "#,##0.##", False, color, color, False, Nothing, True, False)
            HDevExpre.CreaColumnasG(gvEmpleados, "Email1", "Email 1", True, True, "", Color.FromArgb(204, 255, 204), False, False, 20.0F, gcEmpleados.Width - 100, DevExpress.Utils.HorzAlignment.Near, False, "", False, Nothing, False, "dd/MM/yyyy", "#,##0.####", "#,##0.##", False, color, color, False, Nothing, True, False)
            HDevExpre.CreaColumnasG(gvEmpleados, "Email2", "Email 2", True, True, "", Color.FromArgb(204, 255, 204), False, False, 20.0F, gcEmpleados.Width - 100, DevExpress.Utils.HorzAlignment.Near, False, "", False, Nothing, False, "dd/MM/yyyy", "#,##0.####", "#,##0.##", False, color, color, False, Nothing, True, False)
            HDevExpre.CreaColumnasG(gvEmpleados, "PersonasaCargo", "Personas a Cargo", True, True, "", Color.FromArgb(204, 255, 204), False, False, 20.0F, gcEmpleados.Width - 100, DevExpress.Utils.HorzAlignment.Near, False, "", False, Nothing, False, "dd/MM/yyyy", "#,##0.####", "#,##0.##", False, color, color, False, Nothing, True, False)
            HDevExpre.CreaColumnasG(gvEmpleados, "Profesion", "Profesion", True, True, "", Color.FromArgb(204, 255, 204), False, False, 20.0F, gcEmpleados.Width - 100, DevExpress.Utils.HorzAlignment.Near, False, "", False, Nothing, False, "dd/MM/yyyy", "#,##0.####", "#,##0.##", False, color, color, False, lkEditProfesion, True, False)
            HDevExpre.CreaColumnasG(gvEmpleados, "EstadoCivil", "Estado Civil", True, True, "", Color.FromArgb(204, 255, 204), False, False, 20.0F, gcEmpleados.Width - 100, DevExpress.Utils.HorzAlignment.Near, False, "", False, Nothing, False, "dd/MM/yyyy", "#,##0.####", "#,##0.##", False, color, color, False, lkEditEstadoCivil, True, False)
            HDevExpre.CreaColumnasG(gvEmpleados, "Tel1", "Teléfono 1", True, True, "", Color.FromArgb(204, 255, 204), False, False, 20.0F, gcEmpleados.Width - 100, DevExpress.Utils.HorzAlignment.Near, False, "", False, Nothing, False, "dd/MM/yyyy", "#,##0.####", "#,##0.##", False, color, color, False, Nothing, True, False)
            HDevExpre.CreaColumnasG(gvEmpleados, "Tel2", "Teléfono 2", True, True, "", Color.FromArgb(204, 255, 204), False, False, 20.0F, gcEmpleados.Width - 100, DevExpress.Utils.HorzAlignment.Near, False, "", False, Nothing, False, "dd/MM/yyyy", "#,##0.####", "#,##0.##", False, color, color, False, Nothing, True, False)
            HDevExpre.CreaColumnasG(gvEmpleados, "NumCelular", "Celular", True, True, "", Color.FromArgb(204, 255, 204), False, False, 20.0F, gcEmpleados.Width - 100, DevExpress.Utils.HorzAlignment.Near, False, "", False, Nothing, False, "dd/MM/yyyy", "#,##0.####", "#,##0.##", False, color, color, False, Nothing, True, False)
            HDevExpre.CreaColumnasG(gvEmpleados, "WebPage", "Página Web", True, True, "", Color.FromArgb(204, 255, 204), False, False, 20.0F, gcEmpleados.Width - 100, DevExpress.Utils.HorzAlignment.Near, False, "", False, Nothing, False, "dd/MM/yyyy", "#,##0.####", "#,##0.##", False, color, color, False, Nothing, True, False)
            HDevExpre.CreaColumnasG(gvEmpleados, "LicConduccion", "Lic. Conduccion", True, True, "", Color.FromArgb(204, 255, 204), False, False, 20.0F, gcEmpleados.Width - 100, DevExpress.Utils.HorzAlignment.Near, False, "", False, Nothing, False, "dd/MM/yyyy", "#,##0.####", "#,##0.##", False, color, color, False, Nothing, True, False)
            HDevExpre.CreaColumnasG(gvEmpleados, "LicCategoria", "Cat. Licencia", True, True, "", Color.FromArgb(204, 255, 204), False, False, 20.0F, gcEmpleados.Width - 100, DevExpress.Utils.HorzAlignment.Near, False, "", False, Nothing, False, "dd/MM/yyyy", "#,##0.####", "#,##0.##", False, color, color, False, lkEditClaseLicencia, True, False)
            HDevExpre.CreaColumnasG(gvEmpleados, "ClaseLib", "Clase Libreta", True, True, "", Color.FromArgb(204, 255, 204), False, False, 20.0F, gcEmpleados.Width - 100, DevExpress.Utils.HorzAlignment.Near, False, "", False, Nothing, False, "dd/MM/yyyy", "#,##0.####", "#,##0.##", False, color, color, False, lkEditClaseLibreta, True, False)
            HDevExpre.CreaColumnasG(gvEmpleados, "NumLib", "Número Libreta", True, True, "", Color.FromArgb(204, 255, 204), False, False, 20.0F, gcEmpleados.Width - 100, DevExpress.Utils.HorzAlignment.Near, False, "", False, Nothing, False, "dd/MM/yyyy", "#,##0.####", "#,##0.##", False, color, color, False, Nothing, True, False)
            HDevExpre.CreaColumnasG(gvEmpleados, "DistritoLib", "Ditrito Militar", True, True, "", Color.FromArgb(204, 255, 204), False, False, 20.0F, gcEmpleados.Width - 100, DevExpress.Utils.HorzAlignment.Near, False, "", False, Nothing, False, "dd/MM/yyyy", "#,##0.####", "#,##0.##", False, color, color, False, Nothing, True, False)
            HDevExpre.CreaColumnasG(gvEmpleados, "codBanco", "Banco", True, True, "", Color.FromArgb(204, 255, 204), False, False, 20.0F, gcEmpleados.Width - 100, DevExpress.Utils.HorzAlignment.Near, False, "", False, Nothing, False, "dd/MM/yyyy", "#,##0.####", "#,##0.##", False, color, color, False, lkEditBanco, True, False)
            HDevExpre.CreaColumnasG(gvEmpleados, "NumCuenta", "Numero Cuenta", True, True, "", Color.FromArgb(204, 255, 204), False, False, 20.0F, gcEmpleados.Width - 100, DevExpress.Utils.HorzAlignment.Near, False, "", False, Nothing, False, "dd/MM/yyyy", "#,##0.####", "#,##0.##", False, color, color, False, Nothing, True, False)
            HDevExpre.CreaColumnasG(gvEmpleados, "TipoCuenta", "Tipo Cuenta", True, True, "", Color.FromArgb(204, 255, 204), False, False, 20.0F, gcEmpleados.Width - 100, DevExpress.Utils.HorzAlignment.Near, False, "", False, Nothing, False, "dd/MM/yyyy", "#,##0.####", "#,##0.##", False, color, color, False, lkEditTipoCuenta, True, False)
            HDevExpre.CreaColumnasG(gvEmpleados, "Comentario", "Comentario", True, True, "", Color.FromArgb(204, 255, 204), False, False, 20.0F, gcEmpleados.Width - 100, DevExpress.Utils.HorzAlignment.Near, False, "", False, Nothing, False, "dd/MM/yyyy", "#,##0.####", "#,##0.##", False, color, color, False, Nothing, True, False)
            HDevExpre.CreaColumnasG(gvEmpleados, "Resultado", "Resultado", True, False, "", Color.FromArgb(204, 255, 204), False, False, 20.0F, gcEmpleados.Width - 100, DevExpress.Utils.HorzAlignment.Near, False, "", False, Nothing, False, "dd/MM/yyyy", "#,##0.####", "#,##0.##", False, color, color, False, Nothing, True, False)
            gvEmpleados.OptionsView.ShowFooter = True
            gvEmpleados.Appearance.HeaderPanel.Font = New Font("Trebuchet MS", 11.0!, FontStyle.Bold)
            gvEmpleados.Columns(1).Summary.Add(DevExpress.Data.SummaryItemType.Count, "", "{0}")
        Catch ex As Exception
            HDevExpre.msgError(ex, ex.Message, "Crea Grilla")
        End Try
    End Sub

    Private Sub CargaLkEdit()
        Dim str As String = String.Concat("SELECT TD.TipoIdentificacion AS Codigo,TD.NomTipo AS Descripcion FROM ", "..CAT_TiposId TD WHERE TD.UsaEmpleados=1")
        dtTipoDoc = SMT_AbrirTabla(ObjetoApiNomina, str)
        If (dtTipoDoc.Rows.Count > 0) Then
            Me.lkEditTipoDoc.DataSource = dtTipoDoc
            Me.lkEditTipoDoc.ValueMember = "Codigo"
            Me.lkEditTipoDoc.DisplayMember = "Descripcion"
            Me.lkEditTipoDoc.PopulateColumns()
            Me.lkEditTipoDoc.Columns(0).Visible = False
        End If
        str = String.Concat("SELECT Sec AS Codigo, Nombre AS Descripcion FROM ", "..CAT_Bancos WHERE Vigente = 1")
        dtBanco = SMT_AbrirTabla(ObjetoApiNomina, str)
        If (dtBanco.Rows.Count > 0) Then
            Me.lkEditBanco.DataSource = dtBanco
            Me.lkEditBanco.ValueMember = "Codigo"
            Me.lkEditBanco.DisplayMember = "Descripcion"
            Me.lkEditBanco.PopulateColumns()
            Me.lkEditBanco.Columns(0).Visible = False
        End If
        str = String.Concat("SELECT GN.idgenero AS Codigo,GN.nomgenero AS Descripcion FROM ", "..CAT_Genero GN ")
        dtGenero = SMT_AbrirTabla(ObjetoApiNomina, str)
        If (dtGenero.Rows.Count > 0) Then
            Me.lkEditGenero.DataSource = dtGenero
            Me.lkEditGenero.ValueMember = "Codigo"
            Me.lkEditGenero.DisplayMember = "Descripcion"
            Me.lkEditGenero.PopulateColumns()
            Me.lkEditGenero.Columns(0).Visible = False
        End If
        str = String.Concat("SELECT PF.IdProfesion AS Codigo, PF.NomProfesion AS Descripcion FROM ", "..CAT_Profesiones PF WHERE PF.Vigente=1")
        dtProfesion = SMT_AbrirTabla(ObjetoApiNomina, str)
        If (dtProfesion.Rows.Count > 0) Then
            Me.lkEditProfesion.DataSource = dtProfesion
            Me.lkEditProfesion.ValueMember = "Codigo"
            Me.lkEditProfesion.DisplayMember = "Descripcion"
            Me.lkEditProfesion.PopulateColumns()
            Me.lkEditProfesion.Columns(0).Visible = False
        End If
        str = String.Concat("SELECT EC.IdEstado AS Codigo, EC.NomEstado AS Descripcion FROM ", "..CAT_EstadoCivil EC WHERE  EC.Vigente=1")
        dtEstadoCivil = SMT_AbrirTabla(ObjetoApiNomina, str)
        If (dtEstadoCivil.Rows.Count > 0) Then
            Me.lkEditEstadoCivil.DataSource = dtEstadoCivil
            Me.lkEditEstadoCivil.ValueMember = "Codigo"
            Me.lkEditEstadoCivil.DisplayMember = "Descripcion"
            Me.lkEditEstadoCivil.PopulateColumns()
            Me.lkEditEstadoCivil.Columns(0).Visible = False
        End If
        str = String.Concat("SELECT idClase AS Codigo, NomClase AS Descripcion FROM ", "..CAT_ClaseLicencia WHERE Vigente = 1")
        dtClaseLicencia = SMT_AbrirTabla(ObjetoApiNomina, str)
        If (dtClaseLicencia.Rows.Count > 0) Then
            Me.lkEditClaseLicencia.DataSource = dtClaseLicencia
            Me.lkEditClaseLicencia.ValueMember = "Codigo"
            Me.lkEditClaseLicencia.DisplayMember = "Descripcion"
            Me.lkEditClaseLicencia.PopulateColumns()
            Me.lkEditClaseLicencia.Columns(0).Visible = False
        End If
        str = String.Concat("SELECT CL.IdClase AS Codigo, CL.NomClaseLib AS Descripcion FROM ", "..CAT_ClaseLibreta CL WHERE CL.Vigente=1")
        dtClaseLibreta = SMT_AbrirTabla(ObjetoApiNomina, str)
        If (dtClaseLibreta.Rows.Count > 0) Then
            Me.lkEditClaseLibreta.DataSource = dtClaseLibreta
            Me.lkEditClaseLibreta.ValueMember = "Codigo"
            Me.lkEditClaseLibreta.DisplayMember = "Descripcion"
            Me.lkEditClaseLibreta.PopulateColumns()
            Me.lkEditClaseLibreta.Columns(0).Visible = False
        End If
        str = String.Format("SELECT DP.IdMunicipio AS Codigo, DP.NombreMunicipio AS Descripcion FROM G_Municipio DP ")
        dtMunicipios = SMT_AbrirTabla(ObjetoApiNomina, str)
        If (dtMunicipios.Rows.Count > 0) Then
            Me.lkEditMunicipio.DataSource = dtMunicipios
            Me.lkEditMunicipio.ValueMember = "Codigo"
            Me.lkEditMunicipio.DisplayMember = "Descripcion"
            Me.lkEditMunicipio.PopulateColumns()
            Me.lkEditMunicipio.Columns(0).Visible = False


            Me.lkEditLugarExpDoc.DataSource = dtMunicipios
            Me.lkEditLugarExpDoc.ValueMember = "Codigo"
            Me.lkEditLugarExpDoc.DisplayMember = "Descripcion"
            Me.lkEditLugarExpDoc.PopulateColumns()
            Me.lkEditLugarExpDoc.Columns(0).Visible = False


            Me.lkEditMunicipioNacimiento.DataSource = dtMunicipios
            Me.lkEditMunicipioNacimiento.ValueMember = "Codigo"
            Me.lkEditMunicipioNacimiento.DisplayMember = "Descripcion"
            Me.lkEditMunicipioNacimiento.PopulateColumns()
            Me.lkEditMunicipioNacimiento.Columns(0).Visible = False
        End If

        dtTipoCuenta.Columns.Add("Codigo")
        dtTipoCuenta.Columns.Add("Descripcion")
        Dim rows As DataRowCollection = dtTipoCuenta.Rows
        Dim objArray() As Object = {"0", "N/A"}
        rows.Add(objArray)
        Dim dataRowCollection As DataRowCollection = dtTipoCuenta.Rows
        objArray = New Object() {"1", "Ahorro"}
        dataRowCollection.Add(objArray)
        Dim rows1 As DataRowCollection = dtTipoCuenta.Rows
        objArray = New Object() {"2", "Corriente"}
        rows1.Add(objArray)
        Dim rows2 As DataRowCollection = dtTipoCuenta.Rows
        objArray = New Object() {"3", "Nomina"}
        rows2.Add(objArray)
        Me.lkEditTipoCuenta.DataSource = dtTipoCuenta
        Me.lkEditTipoCuenta.ValueMember = "Codigo"
        Me.lkEditTipoCuenta.DisplayMember = "Descripcion"
        Me.lkEditTipoCuenta.PopulateColumns()
        Me.lkEditTipoCuenta.Columns(0).Visible = False
    End Sub

    Public Function CargaExcel() As DataTable
        Try
            OpenFileDialog1.ShowDialog()
            Dim fileName As String = OpenFileDialog1.FileName

            Using fileStream As FileStream = File.Open(fileName, FileMode.Open, FileAccess.Read)
                Dim val As IExcelDataReader = ExcelReaderFactory.CreateReader(CType(fileStream, Stream), CType(Nothing, ExcelReaderConfiguration))
                Dim result As New DataSet


                While (CType(val, IDataReader)).Read() OrElse (CType(val, IDataReader)).NextResult()
                End While
                result = val.AsDataSet(New ExcelDataSetConfiguration() With {
                        .UseColumnDataType = True,
                        .FilterSheet = Function(tableReader, sheetIndex) True,
                        .ConfigureDataTable = Function(tableReader) New ExcelDataTableConfiguration() With {
                        .EmptyColumnNamePrefix = "Column",
                        .UseHeaderRow = False,
                        .ReadHeaderRow = Function(rowReader)
                                             rowReader.Read()
                                         End Function,
                        .FilterRow = Function(rowReader) True,
                        .FilterColumn = Function(rowReader, columnIndex) True
                        }
                        })
                Return result.Tables("Terceros")

            End Using
        Catch ex As Exception
            HDevExpre.MensagedeError(ex.Message)
            Return Nothing
        End Try
    End Function

    Private Sub btnImportar_Click(sender As Object, e As EventArgs) Handles btnImportar.Click
        gcEmpleados.DataSource = Nothing
        Dim dt As DataTable = CargaExcel()

        If Not IsNothing(dt) Then
            dt.Columns(0).ColumnName = dt.Rows(0)(0).ToString
            dt.Columns(1).ColumnName = dt.Rows(0)(1).ToString
            dt.Columns(2).ColumnName = dt.Rows(0)(2).ToString
            dt.Columns(3).ColumnName = dt.Rows(0)(3).ToString
            dt.Columns(4).ColumnName = dt.Rows(0)(4).ToString
            dt.Columns(5).ColumnName = dt.Rows(0)(5).ToString
            dt.Columns(6).ColumnName = dt.Rows(0)(6).ToString
            dt.Columns(7).ColumnName = dt.Rows(0)(7).ToString
            dt.Columns(8).ColumnName = dt.Rows(0)(8).ToString
            dt.Columns(9).ColumnName = dt.Rows(0)(9).ToString
            dt.Columns(10).ColumnName = dt.Rows(0)(10).ToString
            dt.Columns(11).ColumnName = dt.Rows(0)(11).ToString
            dt.Columns(12).ColumnName = dt.Rows(0)(12).ToString
            dt.Columns(13).ColumnName = dt.Rows(0)(13).ToString
            dt.Columns(14).ColumnName = dt.Rows(0)(14).ToString
            dt.Columns(15).ColumnName = dt.Rows(0)(15).ToString
            dt.Columns(16).ColumnName = dt.Rows(0)(16).ToString
            dt.Columns(17).ColumnName = dt.Rows(0)(17).ToString
            dt.Columns(18).ColumnName = dt.Rows(0)(18).ToString
            dt.Columns(19).ColumnName = dt.Rows(0)(19).ToString
            dt.Columns(20).ColumnName = dt.Rows(0)(20).ToString
            dt.Columns(21).ColumnName = dt.Rows(0)(21).ToString
            dt.Columns(22).ColumnName = dt.Rows(0)(22).ToString
            dt.Columns(23).ColumnName = dt.Rows(0)(23).ToString
            dt.Columns(24).ColumnName = dt.Rows(0)(24).ToString
            dt.Columns(25).ColumnName = dt.Rows(0)(25).ToString
            dt.Columns(26).ColumnName = dt.Rows(0)(26).ToString
            dt.Columns(27).ColumnName = dt.Rows(0)(27).ToString
            dt.Columns(28).ColumnName = dt.Rows(0)(28).ToString
            dt.Columns(29).ColumnName = dt.Rows(0)(29).ToString
            dt.Columns(30).ColumnName = dt.Rows(0)(30).ToString
            dt.Columns(31).ColumnName = dt.Rows(0)(31).ToString
            dt.Columns(32).ColumnName = dt.Rows(0)(32).ToString
            dt.Columns.Add("Resultado")
            dt.Rows.Remove(dt.Rows(0))
            If dt.Rows.Count > 0 Then
                For Each i As DataRow In dt.Rows
                    If i("TipoIdentificacion").ToString.Trim <> "" Then
                        For Each ii As DataRow In dtTipoDoc.Rows
                            If i("TipoIdentificacion").ToString.Trim = ii("Descripcion").ToString.Trim Then
                                i("TipoIdentificacion") = ii("Codigo").ToString.Trim
                                Exit For
                            End If
                        Next
                    End If

                    If i("Genero").ToString.Trim <> "" Then
                        For Each ii As DataRow In dtGenero.Rows
                            If i("Genero").ToString.Trim = ii("Descripcion").ToString.Trim Then
                                i("Genero") = ii("Codigo").ToString.Trim
                                Exit For
                            End If
                        Next
                    End If

                    If i("MunicipioNacimiento").ToString.Trim <> "" Then
                        Dim dtstr = Split(i("MunicipioNacimiento").ToString.Trim, " - ")
                        i("MunicipioNacimiento") = dtstr(1)
                    End If

                    If i("LugarExpDoc").ToString.Trim <> "" Then
                        Dim dtstr = Split(i("LugarExpDoc").ToString.Trim, " - ")
                        i("LugarExpDoc") = dtstr(1)
                    End If

                    If i("MunicipioResidencia").ToString.Trim <> "" Then
                        Dim dtstr = Split(i("MunicipioResidencia").ToString.Trim, " - ")
                        i("MunicipioResidencia") = dtstr(1)
                    End If

                    If i("Profesion").ToString.Trim <> "" Then
                        For Each ii As DataRow In dtProfesion.Rows
                            If i("Profesion").ToString.Trim = ii("Descripcion").ToString.Trim Then
                                i("Profesion") = ii("Codigo").ToString.Trim
                                Exit For
                            End If
                        Next
                    End If

                    If i("EstadoCivil").ToString.Trim <> "" Then
                        For Each ii As DataRow In dtEstadoCivil.Rows
                            If i("EstadoCivil").ToString.Trim = ii("Descripcion").ToString.Trim Then
                                i("EstadoCivil") = ii("Codigo").ToString.Trim
                                Exit For
                            End If
                        Next
                    End If

                    If i("LicCategoria").ToString.Trim <> "" Then
                        For Each ii As DataRow In dtClaseLicencia.Rows
                            If i("LicCategoria").ToString.Trim = ii("Descripcion").ToString.Trim Then
                                i("LicCategoria") = ii("Codigo").ToString.Trim
                                Exit For
                            End If
                        Next
                    End If

                    If i("ClaseLib").ToString.Trim <> "" Then
                        For Each ii As DataRow In dtClaseLibreta.Rows
                            If i("ClaseLib").ToString.Trim = ii("Descripcion").ToString.Trim Then
                                i("ClaseLib") = ii("Codigo").ToString.Trim
                                Exit For
                            End If
                        Next
                    End If

                    If i("codBanco").ToString.Trim <> "" Then
                        For Each ii As DataRow In dtBanco.Rows
                            If i("codBanco").ToString.Trim = ii("Descripcion").ToString.Trim Then
                                i("codBanco") = ii("Codigo").ToString.Trim
                                Exit For
                            End If
                        Next
                    End If

                    If i("TipoCuenta").ToString.Trim <> "" Then
                        For Each ii As DataRow In dtTipoCuenta.Rows
                            If i("TipoCuenta").ToString.Trim = ii("Descripcion").ToString.Trim Then
                                i("TipoCuenta") = ii("Codigo").ToString.Trim
                                Exit For
                            End If
                        Next
                    End If
                Next
            End If

            gcEmpleados.DataSource = dt
        End If
    End Sub

    Public Function ValidaEmpleado(ByVal TipoDoc As String, ByVal Doc As String, ByVal PNombre As String, ByVal PApellido As String, ByVal Genero As String, ByVal Profesion As String, ByVal EstadoCivil As String, ByVal Celular As String, ByVal Correo As String, ByVal MunicipioResidencia As String, ByVal BarrioResidencia As String, ByVal DireccionResidencia As String, ByVal MunicipioExpe As String, ByVal MunicipioNacimiento As String, ByVal FechaExpe As String, ByVal FechaNacimiento As String) As List(Of String)
        Dim MsgError As New List(Of String)

        Try
            Dim dateTime As Date = CDate(FechaExpe)
            Dim dateTime1 As Date = CDate(FechaNacimiento)
            Dim existedoc = SMT_AbrirTabla(ObjetoApiNomina, "Select * from Empleados where Identificacion='" + Doc + "'")

            If existedoc.Rows.Count > 0 Then
                MsgError.Add("Este tercero ya se encuentra registrado!..")
            End If
            If (TipoDoc = "") Then
                MsgError.Add("El campo TipoDoc no puede estar vacío!..")
            End If
            If (Doc = "") Then
                MsgError.Add("El campo Doc no puede estar vacío!..")
            End If
            If (PNombre = "") Then
                MsgError.Add("El campo primer nombre no puede estar vacío!..")
            End If
            If (PApellido = "") Then
                MsgError.Add("El campo primer apellido no puede estar vacío!..")
            End If
            If (Genero = "") Then
                MsgError.Add("Debe seleccionar el Género!..")
            End If
            If (EstadoCivil = "") Then
                MsgError.Add("Debe seleccionar el Estado Civil!..")
            End If
            If (Celular = "") Then
                MsgError.Add("Debe agregar al menos un número de celular!..")
            End If
            If (MunicipioResidencia = "") Then
                MsgError.Add("Debe seleccionar el minicipio de residencia!..")
            End If
            If (BarrioResidencia = "") Then
                MsgError.Add("El campo barrio no puede estar vacío!..")
            End If
            If (DireccionResidencia = "") Then
                MsgError.Add("El campo dirección no puede estar vacío!..")
            End If
            If (MunicipioExpe = "") Then
                MsgError.Add("Debe seleccionar el lugar de expedición de documento!..")
            End If
            If (Profesion <> "") Then
                If Not ExisteDato("Cat_Profesiones", $"NomProfesion= '{Profesion}'", ObjetoApiNomina, MostrarMensageError:=False) Then
                    MsgError.Add($"La Profesión '{Profesion}', no Existe en el Catalogo de Profesiones")
                End If
            End If
            If (FechaExpe = "") Then
                MsgError.Add("Debe seleccionar la fecha de expedición de documento!..")
            End If
            If (DateAndTime.DateDiff(DateInterval.Year, dateTime, Datos.Smt_FechaDelServidor(), FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1) > CLng(100)) Then
                MsgError.Add("La fecha de expedicón del docuemnto no es válida, al parecer es inferior al año 1910!..")
            End If
            If (MunicipioNacimiento = "") Then
                MsgError.Add("Debe seleccionar el lugar de nacimiento del empleado!..")
            End If
            If (FechaNacimiento = "") Then
                MsgError.Add("Debe seleccionar la fecha de nacimiento!..")
            End If
            If (DateAndTime.DateDiff(DateInterval.Year, dateTime1, Datos.Smt_FechaDelServidor(), FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1) > CLng(100)) Then
                MsgError.Add("La fecha de nacimiento no es válida, al parecer es inferior al año 1910!..")
            End If
            If (DateAndTime.DateDiff(DateInterval.Year, dateTime1, Datos.Smt_FechaDelServidor(), FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1) < CLng(18)) Then
                MsgError.Add("Por favor revise la fecha de nacimiento, al parecer la fecha no coinicide con la de un adulto!..")
            End If

        Catch ex As Exception
            MsgError.Add(Err.Description)
        End Try
        Return MsgError
    End Function

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If gvEmpleados.RowCount <= 0 Then
            HDevExpre.MensagedeError("No se han encontrado Empleados para importar!..")
            Return
        End If

        Dim Load As New ClEspera()
        Load.Mostrar("Importando Datos!.", "")

        Dim dt As DataTable = DirectCast(gcEmpleados.DataSource, DataTable).Copy()
        If dt.Columns.Contains("Resultado") Then dt.Columns.Remove("Resultado")
        dt.Columns.Add("Resultado")

        Dim svc As New ServiceEmpleados()
        For Each row As DataRow In dt.Rows
            Dim errores = ValidaEmpleado(
            row("TipoIdentificacion").ToString(),
            row("Identificacion").ToString(),
            row("PNombre").ToString(),
            row("PApellido").ToString(),
            row("Genero").ToString(),
            row("Profesion").ToString(),
            row("EstadoCivil").ToString(),
            row("NumCelular").ToString(),
            row("Email1").ToString(),
            row("MunicipioResidencia").ToString(),
            row("Barrio").ToString(),
            row("Direccion").ToString(),
            row("LugarExpDoc").ToString(),
            row("MunicipioNacimiento").ToString(),
            row("FechaExpDoc").ToString(),
            row("FechaNacimiento").ToString()
        )
            If errores.Count > 0 Then
                row("Resultado") = String.Join(";", errores)
                Continue For
            End If

            Try
                Dim emp As New Empleados() With {
                .Sec = 0,
                .TipoIdentificacion = row("TipoIdentificacion").ToString(),
                .Identificacion = CLng(row("Identificacion")),
                .Dv = row("Dv").ToString(),
                .PApellido = row("PApellido").ToString(),
                .SApellido = row("SApellido").ToString(),
                .PNombre = row("PNombre").ToString(),
                .SNombre = row("SNombre").ToString(),
                .Genero = row("Genero").ToString(),
                .FechaNacimiento = CDate(row("FechaNacimiento")),
                .MunicipioNacimiento = row("MunicipioNacimiento").ToString(),
                .FechaExpDoc = CDate(row("FechaExpDoc")),
                .LugarExpDoc = row("LugarExpDoc").ToString(),
                .Direccion = row("Direccion").ToString(),
                .Barrio = row("Barrio").ToString(),
                .Municipio = row("MunicipioResidencia").ToString(),
                .Email1 = row("Email1").ToString(),
                .Email2 = row("Email2").ToString(),
                .Profesion = If(String.IsNullOrWhiteSpace(row("Profesion").ToString()), CType(Nothing, Integer?), CInt(row("Profesion"))),
                .PersonasaCargo = If(String.IsNullOrWhiteSpace(row("PersonasaCargo").ToString()), CType(Nothing, Short?), CShort(row("PersonasaCargo"))),
                .EstadoCivil = If(String.IsNullOrWhiteSpace(row("EstadoCivil").ToString()), CType(Nothing, Byte?), CByte(row("EstadoCivil"))),
                .Tel1 = row("Tel1").ToString(),
                .Tel2 = row("Tel2").ToString(),
                .NumCelular = row("NumCelular").ToString(),
                .WebPage = row("WebPage").ToString(),
                .LicConduccion = row("LicConduccion").ToString(),
                .LicCategoria = row("LicCategoria").ToString(),
                .ClaseLib = If(String.IsNullOrWhiteSpace(row("ClaseLib").ToString()), CType(Nothing, Short?), CShort(row("ClaseLib"))),
                .NumLib = row("NumLib").ToString(),
                .DistritoLib = row("DistritoLib").ToString(),
                .Comentario = row("Comentario").ToString(),
                .ActividadEco = row("ActividadEco").ToString(),
                .codBanco = If(String.IsNullOrWhiteSpace(row("codBanco").ToString()), CType(Nothing, Integer?), CInt(row("codBanco"))),
                .NumCuenta = row("NumCuenta").ToString(),
                .TipoCuenta = CShort(row("TipoCuenta").ToString()),
                .FechaIngreso = Datos.Smt_FechaDeTrabajo,
                .FechaGen = Datos.Smt_FechaDelServidor,
                .UsrGen = Datos.Smt_Usuario,
                .FechaMod = Datos.Smt_FechaDelServidor,
                .UsrMod = Datos.Smt_Usuario
            }

                Dim result = svc.UpsertEmpleado(emp)
                row("Resultado") = If(result IsNot Nothing AndAlso result.ErrorCount < 1, "Ok", "Error al guardar!")

            Catch ex As Exception
                row("Resultado") = ex.Message
            End Try
        Next

        Load.Terminar()
        gcEmpleados.DataSource = dt
        HDevExpre.mensajeExitoso("La importación ha finalizado!..")
    End Sub


    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        gcEmpleados.DataSource = Nothing
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub FrmImportarTerceros_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If gvEmpleados.RowCount > 0 Then
            If HDevExpre.MsgSamit("Se están modificando datos, Seguro que desea cerrar el formulario?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Cancel Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub btnPlantilla_Click(sender As Object, e As EventArgs) Handles btnPlantilla.Click
        Try
            Dim Archivo As Byte() = My.Resources.PlantillaTerceros
            SaveFileDialog1.Filter = "|xlsx"
            SaveFileDialog1.InitialDirectory = "C:\Users\" + SystemInformation.UserName + "\Downloads\"
            SaveFileDialog1.FileName = "PlantillaTerceros.xlsx"
            SaveFileDialog1.ShowDialog()
            File.WriteAllBytes(SaveFileDialog1.FileName, Archivo)
            HDevExpre.mensajeExitoso("Archivo creado correctamente!..")
        Catch ex As Exception
            HDevExpre.MensagedeError(ex.Message)
        End Try

    End Sub
End Class