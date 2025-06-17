Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Repository
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports ExcelDataReader
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.VisualBasic.Devices
Imports Microsoft.VisualBasic.MyServices
Imports Nomina.My
Imports SamitCtlNet
Imports SamitNomina.My
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports SamitNominaLogic
Imports System.IO
Imports System.Runtime.CompilerServices


Namespace Nomina
    <DesignerGenerated>
    Public Class FrmImportaEmpleados
        Inherits XtraForm
        Private components As System.ComponentModel.IContainer

        <AccessedThroughProperty("gcEmpleados")>
        Private _gcEmpleados As GridControl

        <AccessedThroughProperty("gvEmpleados")>
        Private _gvEmpleados As GridView

        <AccessedThroughProperty("GroupControl1")>
        Private _GroupControl1 As GroupControl

        <AccessedThroughProperty("btnImportar")>
        Private _btnImportar As SimpleButton

        <AccessedThroughProperty("btnGuardar")>
        Private _btnGuardar As SimpleButton

        <AccessedThroughProperty("btnSalir")>
        Private _btnSalir As SimpleButton

        <AccessedThroughProperty("OpenFileDialog1")>
        Private _OpenFileDialog1 As OpenFileDialog

        <AccessedThroughProperty("btnExportar")>
        Private _btnExportar As SimpleButton

        <AccessedThroughProperty("btnLimpiar")>
        Private _btnLimpiar As SimpleButton

        Private clEmpleado As ServiceEmpleados

        Private lkEditTipoDoc As RepositoryItemLookUpEdit

        Private lkEditBanco As RepositoryItemLookUpEdit

        Private lkEditTipoCuenta As RepositoryItemLookUpEdit

        Private lkEditGenero As RepositoryItemLookUpEdit

        Private lkEditProfesion As RepositoryItemLookUpEdit

        Private lkEditEstadoCivil As RepositoryItemLookUpEdit

        Private lkEditClaseLicencia As RepositoryItemLookUpEdit

        Private lkEditClaseLibreta As RepositoryItemLookUpEdit

        Dim HDevExpre As New HelperDevExpress
        Dim HNomina As New HelperNomina
        Friend Overridable Property btnExportar As SimpleButton
            Get
                Return Me._btnExportar
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(ByVal value As SimpleButton)
                Dim frmImportaEmpleado As FrmImportaEmpleados = Me
                Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf frmImportaEmpleado.btnExportar_Click)
                If (Me._btnExportar IsNot Nothing) Then
                    RemoveHandler Me._btnExportar.Click, eventHandler
                End If
                Me._btnExportar = value
                If (Me._btnExportar IsNot Nothing) Then
                    AddHandler Me._btnExportar.Click, eventHandler
                End If
            End Set
        End Property

        Friend Overridable Property btnGuardar As SimpleButton
            Get
                Return Me._btnGuardar
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(ByVal value As SimpleButton)
                Dim frmImportaEmpleado As FrmImportaEmpleados = Me
                Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf frmImportaEmpleado.btnGuardar_Click)
                If (Me._btnGuardar IsNot Nothing) Then
                    RemoveHandler Me._btnGuardar.Click, eventHandler
                End If
                Me._btnGuardar = value
                If (Me._btnGuardar IsNot Nothing) Then
                    AddHandler Me._btnGuardar.Click, eventHandler
                End If
            End Set
        End Property

        Friend Overridable Property btnImportar As SimpleButton
            Get
                Return Me._btnImportar
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(ByVal value As SimpleButton)
                Dim frmImportaEmpleado As FrmImportaEmpleados = Me
                Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf frmImportaEmpleado.btnImportar_Click)
                If (Me._btnImportar IsNot Nothing) Then
                    RemoveHandler Me._btnImportar.Click, eventHandler
                End If
                Me._btnImportar = value
                If (Me._btnImportar IsNot Nothing) Then
                    AddHandler Me._btnImportar.Click, eventHandler
                End If
            End Set
        End Property

        Friend Overridable Property btnLimpiar As SimpleButton
            Get
                Return Me._btnLimpiar
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(ByVal value As SimpleButton)
                Dim frmImportaEmpleado As FrmImportaEmpleados = Me
                Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf frmImportaEmpleado.btnLimpiar_Click)
                If (Me._btnLimpiar IsNot Nothing) Then
                    RemoveHandler Me._btnLimpiar.Click, eventHandler
                End If
                Me._btnLimpiar = value
                If (Me._btnLimpiar IsNot Nothing) Then
                    AddHandler Me._btnLimpiar.Click, eventHandler
                End If
            End Set
        End Property

        Friend Overridable Property btnSalir As SimpleButton
            Get
                Return Me._btnSalir
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(ByVal value As SimpleButton)
                Dim frmImportaEmpleado As FrmImportaEmpleados = Me
                Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf frmImportaEmpleado.btnSalir_Click)
                If (Me._btnSalir IsNot Nothing) Then
                    RemoveHandler Me._btnSalir.Click, eventHandler
                End If
                Me._btnSalir = value
                If (Me._btnSalir IsNot Nothing) Then
                    AddHandler Me._btnSalir.Click, eventHandler
                End If
            End Set
        End Property

        Friend Overridable Property gcEmpleados As GridControl
            Get
                Return Me._gcEmpleados
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(ByVal value As GridControl)
                Me._gcEmpleados = value
            End Set
        End Property

        Friend Overridable Property GroupControl1 As GroupControl
            Get
                Return Me._GroupControl1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(ByVal value As GroupControl)
                Me._GroupControl1 = value
            End Set
        End Property

        Friend Overridable Property gvEmpleados As GridView
            Get
                Return Me._gvEmpleados
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(ByVal value As GridView)
                Dim frmImportaEmpleado As FrmImportaEmpleados = Me
                Dim rowCellStyleEventHandler As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler = New DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(AddressOf frmImportaEmpleado.gvProductosFactura_RowCellStyle)
                Dim frmImportaEmpleado1 As FrmImportaEmpleados = Me
                Dim rowStyleEventHandler As DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler = New DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(AddressOf frmImportaEmpleado1.gvEmpleados_RowStyle)
                If (Me._gvEmpleados IsNot Nothing) Then
                    RemoveHandler Me._gvEmpleados.RowCellStyle, rowCellStyleEventHandler
                    RemoveHandler Me._gvEmpleados.RowStyle, rowStyleEventHandler
                End If
                Me._gvEmpleados = value
                If (Me._gvEmpleados IsNot Nothing) Then
                    AddHandler Me._gvEmpleados.RowCellStyle, rowCellStyleEventHandler
                    AddHandler Me._gvEmpleados.RowStyle, rowStyleEventHandler
                End If
            End Set
        End Property

        Friend Overridable Property OpenFileDialog1 As OpenFileDialog
            Get
                Return Me._OpenFileDialog1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(ByVal value As OpenFileDialog)
                Me._OpenFileDialog1 = value
            End Set
        End Property

        Public Sub New()
            MyBase.New()
            Dim frmImportaEmpleado As FrmImportaEmpleados = Me
            AddHandler MyBase.Load, New EventHandler(AddressOf frmImportaEmpleado.FrmImportaEmpleados_Load)
            Me.clEmpleado = New ServiceEmpleados()
            Me.lkEditTipoDoc = New RepositoryItemLookUpEdit()
            Me.lkEditBanco = New RepositoryItemLookUpEdit()
            Me.lkEditTipoCuenta = New RepositoryItemLookUpEdit()
            Me.lkEditGenero = New RepositoryItemLookUpEdit()
            Me.lkEditProfesion = New RepositoryItemLookUpEdit()
            Me.lkEditEstadoCivil = New RepositoryItemLookUpEdit()
            Me.lkEditClaseLicencia = New RepositoryItemLookUpEdit()
            Me.lkEditClaseLibreta = New RepositoryItemLookUpEdit()
            Me.InitializeComponent()
        End Sub

        Private Sub btnExportar_Click(ByVal sender As Object, ByVal e As EventArgs)
            If (Me.gvEmpleados.RowCount > 0) Then
                Dim fileName As String = String.Concat(MyProject.Computer.FileSystem.SpecialDirectories.Desktop, "\pruebaexcell.xlsx")
                Dim saveFileDialog As System.Windows.Forms.SaveFileDialog = New System.Windows.Forms.SaveFileDialog() With
                {
                    .Filter = "XlsX Excel|*.Xlsx",
                    .Title = "Guardar Archivo de Excel XlsX"
                }
                saveFileDialog.ShowDialog()
                If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(saveFileDialog.FileName, "", False) <> 0) Then
                    fileName = saveFileDialog.FileName
                    Me.gcEmpleados.ExportToXlsx(fileName)
                    Process.Start(fileName)
                End If
            End If
        End Sub

        Private Sub btnGuardar_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Me.gvEmpleados.RowCount <= 0 Then
                Interaction.MsgBox("No se han encontrado Empleados para importar", MsgBoxStyle.OkOnly, Nothing)
                Return
            End If

            Dim clEspera = New SamitCtlNet.ClEspera()
            clEspera.Mostrar("Importando Datos!.", "")

            Dim tabla As DataTable = DirectCast(Me.gcEmpleados.DataSource, DataTable).Copy()
            If tabla.Columns.Contains("Resultado") Then tabla.Columns.Remove("Resultado")
            tabla.Columns.Add("Resultado")

            Dim svc As New ServiceEmpleados()
            Dim total = tabla.Rows.Count

            For i As Integer = 0 To total - 1
                Dim row = tabla.Rows(i)
                Dim valid = Me.ValidaEmpleado(
            row("TipoIdentificacion").ToString(),
            row("Identificacion").ToString(),
            row("PNombre").ToString(),
            row("PApellido").ToString(),
            row("Genero").ToString(),
            row("Profesion").ToString(),
            row("EstadoCivil").ToString(),
            row("NumCelular").ToString(),
            row("Email1").ToString(),
            row("Municipio").ToString(),
            row("Barrio").ToString(),
            row("Direccion").ToString(),
            row("LugarExpDoc").ToString(),
            row("MunicipioNacimiento").ToString(),
            row("FechaExpDoc").ToString(),
            row("FechaNacimiento").ToString()
        )
                If valid <> "Ok" Then
                    row("Resultado") = valid
                    Continue For
                End If

                If ModAdoNET.ExisteDato("Empleados",
                 $"Identificacion ='{row("Identificacion")}'", ObjetoApiNomina) Then
                    row("Resultado") = "Este Empleado ya existe!."
                    Continue For
                End If

                Try
                    ' 1) Mapear DataRow a Empleados
                    Dim emp As New Empleados() With {
                .Sec = 0, ' Para insert, el servicio deberá asignar
                .TipoIdentificacion = row("TipoIdentificacion").ToString(),
                .Identificacion = CLng(row("Identificacion")),
                .Dv = row("Dv").ToString(),
                .PApellido = row("PApellido").ToString(),
                .SApellido = row("SApellido").ToString(),
                .PNombre = row("PNombre").ToString(),
                .SNombre = row("SNombre").ToString(),
                .Genero = row("Genero").ToString(),
                .MunicipioNacimiento = row("MunicipioNacimiento").ToString(),
                .LugarExpDoc = row("LugarExpDoc").ToString(),
                .Direccion = row("Direccion").ToString(),
                .Barrio = row("Barrio").ToString(),
                .Municipio = row("Municipio").ToString(),
                .Email1 = row("Email1").ToString(),
                .Email2 = row("Email2").ToString(),
                .Profesion = If(String.IsNullOrWhiteSpace(row("Profesion").ToString()),
                                           CType(Nothing, Integer?),
                                           CInt(row("Profesion"))),
                .PersonasaCargo = If(String.IsNullOrWhiteSpace(row("PersonasaCargo").ToString()),
                                           CType(Nothing, Short?),
                                           CShort(row("PersonasaCargo"))),
                .EstadoCivil = If(String.IsNullOrWhiteSpace(row("EstadoCivil").ToString()),
                                           CType(Nothing, Byte?),
                                           Byte.Parse(row("EstadoCivil"))),
                .Tel1 = row("Tel1").ToString(),
                .Tel2 = row("Tel2").ToString(),
                .NumCelular = row("NumCelular").ToString(),
                .WebPage = row("WebPage").ToString(),
                .LicConduccion = row("LicConduccion").ToString(),
                .LicCategoria = row("LicCategoria").ToString(),
                .ClaseLib = If(String.IsNullOrWhiteSpace(row("ClaseLib").ToString()),
                                        CType(Nothing, Short?),
                                        CShort(row("ClaseLib"))),
                .NumLib = row("NumLib").ToString(),
                .DistritoLib = row("DistritoLib").ToString(),
                .Comentario = row("Comentario").ToString(),
                .ActividadEco = row("ActividadEco").ToString(),
                .codBanco = If(String.IsNullOrWhiteSpace(row("codBanco").ToString()),
                                           CType(Nothing, Integer?),
                                           CInt(row("codBanco"))),
                .NumCuenta = row("NumCuenta").ToString(),
                .TipoCuenta = CShort(row("TipoCuenta").ToString()),
                .FechaIngreso = ObjetosNomina.Datos.Smt_FechaDeTrabajo,
                .FechaGen = ObjetosNomina.Datos.Smt_FechaDelServidor,
                .UsrGen = ObjetosNomina.Datos.Smt_Usuario,
                .FechaMod = ObjetosNomina.Datos.Smt_FechaDelServidor,
                .UsrMod = ObjetosNomina.Datos.Smt_Usuario
            }

                    ' 2) Llamar al servicio
                    Dim result = svc.UpsertEmpleado(emp)
                    If result Is Nothing OrElse result.ErrorCount > 0 Then
                        row("Resultado") = "Error al guardar!"
                    Else
                        row("Resultado") = "Ok"
                    End If

                Catch ex As Exception
                    row("Resultado") = ex.Message
                End Try
            Next

            clEspera.Terminar()
            Me.gcEmpleados.DataSource = tabla
            Interaction.MsgBox("Importación Finalizada!.", MsgBoxStyle.OkOnly, Nothing)
        End Sub


        Private Sub btnImportar_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.gcEmpleados.DataSource = Nothing
            Dim dataTable As System.Data.DataTable = Me.CargaExcel()
            If (Not Information.IsNothing(dataTable)) Then
                dataTable.Columns.Add("Resultado")
                Me.gcEmpleados.DataSource = dataTable
            End If
        End Sub

        Private Sub btnLimpiar_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.gcEmpleados.DataSource = Nothing
        End Sub

        Private Sub btnSalir_Click(ByVal sender As Object, ByVal e As EventArgs)
        End Sub

        Public Function CargaExcel() As System.Data.DataTable
            Dim dataTable As System.Data.DataTable
            Try
                Me.OpenFileDialog1.ShowDialog()
                Dim fileName As String = Me.OpenFileDialog1.FileName
                Dim item As System.Data.DataTable = New System.Data.DataTable()
                Using fileStream As System.IO.FileStream = File.Open(fileName, FileMode.Open, FileAccess.Read)
                    Using excelDataReader As IExcelDataReader = ExcelReaderFactory.CreateReader(fileStream, Nothing)
                        While excelDataReader.Read() OrElse excelDataReader.NextResult()
                        End While
                        Dim excelDataSetConfiguration As ExcelDataReader.ExcelDataSetConfiguration = New ExcelDataReader.ExcelDataSetConfiguration() With
                        {
                            .ConfigureDataTable = Function(__ As IExcelDataReader) New ExcelDataTableConfiguration() With
                            {
                                .UseHeaderRow = True
                            }
                        }
                        Dim dataSet As System.Data.DataSet = excelDataReader.AsDataSet(excelDataSetConfiguration)
                        item = dataSet.Tables("Hoja1")
                    End Using
                End Using
                dataTable = item
            Catch exception As System.Exception
                ProjectData.SetProjectError(exception)
                dataTable = Nothing
                ProjectData.ClearProjectError()
            End Try
            Return dataTable
        End Function

        Private Sub CargaLkEdit()
            Dim str As String = String.Concat("SELECT TD.TipoIdentificacion AS Codigo,TD.NomTipo AS Descripcion FROM  CAT_TiposId TD WHERE TD.UsaEmpleados=1")
            Dim dataTable As System.Data.DataTable = ModAdoNET.SMT_AbrirTabla(ObjetoApiNomina, str)
            If (dataTable.Rows.Count > 0) Then
                Me.lkEditTipoDoc.DataSource = dataTable
                Me.lkEditTipoDoc.ValueMember = "Codigo"
                Me.lkEditTipoDoc.DisplayMember = "Descripcion"
                Me.lkEditTipoDoc.PopulateColumns()
                Me.lkEditTipoDoc.Columns(0).Visible = False
            End If
            str = String.Concat("SELECT Sec AS Codigo, Nombre AS Descripcion FROM  CAT_Bancos WHERE Vigente = 1")
            dataTable = ModAdoNET.SMT_AbrirTabla(ObjetoApiNomina, str)
            If (dataTable.Rows.Count > 0) Then
                Me.lkEditBanco.DataSource = dataTable
                Me.lkEditBanco.ValueMember = "Codigo"
                Me.lkEditBanco.DisplayMember = "Descripcion"
                Me.lkEditBanco.PopulateColumns()
                Me.lkEditBanco.Columns(0).Visible = False
            End If
            str = String.Concat("SELECT GN.idgenero AS Codigo,GN.nomgenero AS Descripcion FROM  CAT_Genero GN ")
            dataTable = ModAdoNET.SMT_AbrirTabla(ObjetoApiNomina, str)
            If (dataTable.Rows.Count > 0) Then
                Me.lkEditGenero.DataSource = dataTable
                Me.lkEditGenero.ValueMember = "Codigo"
                Me.lkEditGenero.DisplayMember = "Descripcion"
                Me.lkEditGenero.PopulateColumns()
                Me.lkEditGenero.Columns(0).Visible = False
            End If
            str = String.Concat("SELECT PF.IdProfesion AS Codigo, PF.NomProfesion AS Descripcion FROM  CAT_Profesiones PF WHERE PF.Vigente=1")
            dataTable = ModAdoNET.SMT_AbrirTabla(ObjetoApiNomina, str)
            If (dataTable.Rows.Count > 0) Then
                Me.lkEditProfesion.DataSource = dataTable
                Me.lkEditProfesion.ValueMember = "Codigo"
                Me.lkEditProfesion.DisplayMember = "Descripcion"
                Me.lkEditProfesion.PopulateColumns()
                Me.lkEditProfesion.Columns(0).Visible = False
            End If
            str = String.Concat("SELECT EC.IdEstado AS Codigo, EC.NomEstado AS Descripcion FROM CAT_EstadoCivil EC WHERE  EC.Vigente=1")
            dataTable = ModAdoNET.SMT_AbrirTabla(ObjetoApiNomina, str)
            If (dataTable.Rows.Count > 0) Then
                Me.lkEditEstadoCivil.DataSource = dataTable
                Me.lkEditEstadoCivil.ValueMember = "Codigo"
                Me.lkEditEstadoCivil.DisplayMember = "Descripcion"
                Me.lkEditEstadoCivil.PopulateColumns()
                Me.lkEditEstadoCivil.Columns(0).Visible = False
            End If
            str = String.Concat("SELECT idClase AS Codigo, NomClase AS Descripcion FROM  CAT_ClaseLicencia WHERE Vigente = 1")
            dataTable = ModAdoNET.SMT_AbrirTabla(ObjetoApiNomina, str)
            If (dataTable.Rows.Count > 0) Then
                Me.lkEditClaseLicencia.DataSource = dataTable
                Me.lkEditClaseLicencia.ValueMember = "Codigo"
                Me.lkEditClaseLicencia.DisplayMember = "Descripcion"
                Me.lkEditClaseLicencia.PopulateColumns()
                Me.lkEditClaseLicencia.Columns(0).Visible = False
            End If
            str = String.Concat("SELECT CL.IdClase AS Codigo, CL.NomClaseLib AS Descripcion FROM  CAT_ClaseLibreta CL WHERE CL.Vigente=1")
            dataTable = ModAdoNET.SMT_AbrirTabla(ObjetoApiNomina, str)
            If (dataTable.Rows.Count > 0) Then
                Me.lkEditClaseLibreta.DataSource = dataTable
                Me.lkEditClaseLibreta.ValueMember = "Codigo"
                Me.lkEditClaseLibreta.DisplayMember = "Descripcion"
                Me.lkEditClaseLibreta.PopulateColumns()
                Me.lkEditClaseLibreta.Columns(0).Visible = False
            End If
            Dim dataTable1 As System.Data.DataTable = New System.Data.DataTable()
            dataTable1.Columns.Add("Codigo")
            dataTable1.Columns.Add("Descripcion")
            Dim rows As System.Data.DataRowCollection = dataTable1.Rows
            Dim objArray() As Object = {"0", "N/A"}
            rows.Add(objArray)
            Dim dataRowCollection As System.Data.DataRowCollection = dataTable1.Rows
            objArray = New Object() {"1", "Ahorro"}
            dataRowCollection.Add(objArray)
            Dim rows1 As System.Data.DataRowCollection = dataTable1.Rows
            objArray = New Object() {"2", "Corriente"}
            rows1.Add(objArray)
            Me.lkEditTipoCuenta.DataSource = dataTable1
            Me.lkEditTipoCuenta.ValueMember = "Codigo"
            Me.lkEditTipoCuenta.DisplayMember = "Descripcion"
            Me.lkEditTipoCuenta.PopulateColumns()
            Me.lkEditTipoCuenta.Columns(0).Visible = False
        End Sub

        Private Sub CreaGrilla()
            Dim color As System.Drawing.Color = New System.Drawing.Color()
            Try
                Me.gvEmpleados.Columns.Clear()
                HDevExpre.CreaColumnasG(Me.gvEmpleados, "TipoIdentificacion", "Tipo Identificación", True, True, "", System.Drawing.Color.FromArgb(204, 255, 204), False, False, 150.0!, 0!, HorzAlignment.Near, False, "", False, Nothing, False, "dd/MM/yyyy", "#,##0.####", "#,##0.##", True, System.Drawing.Color.Blue, System.Drawing.Color.White, True, Me.lkEditTipoDoc, True, False)
                HDevExpre.CreaColumnasG(Me.gvEmpleados, "Identificacion", "Identificación", True, True, "", System.Drawing.Color.FromArgb(204, 255, 204), False, False, 150.0!, 0!, HorzAlignment.Near, False, "", False, Nothing, False, "dd/MM/yyyy", "#,##0.####", "#,##0.##", True, color, color, False, Nothing, True, False)
                HDevExpre.CreaColumnasG(Me.gvEmpleados, "Dv", "Dv", True, True, "", System.Drawing.Color.FromArgb(204, 255, 204), False, False, 20.0!, CSng((Me.Width - 100)), HorzAlignment.Near, False, "", False, Nothing, False, "dd/MM/yyyy", "#,##0.####", "#,##0.##", False, color, color, False, Nothing, True, False)
                HDevExpre.CreaColumnasG(Me.gvEmpleados, "PApellido", "P. Apellido", True, True, "", System.Drawing.Color.FromArgb(204, 255, 204), False, False, 20.0!, CSng((Me.Width - 100)), HorzAlignment.Near, False, "", False, Nothing, False, "dd/MM/yyyy", "#,##0.####", "#,##0.##", False, color, color, False, Nothing, True, False)
                HDevExpre.CreaColumnasG(Me.gvEmpleados, "SApellido", "S. Apellido", True, True, "", System.Drawing.Color.FromArgb(204, 255, 204), False, False, 20.0!, CSng((Me.Width - 100)), HorzAlignment.Near, False, "", False, Nothing, False, "dd/MM/yyyy", "#,##0.####", "#,##0.##", False, color, color, False, Nothing, True, False)
                HDevExpre.CreaColumnasG(Me.gvEmpleados, "PNombre", "P. Nombre", True, True, "", System.Drawing.Color.FromArgb(204, 255, 204), False, False, 200.0!, 0!, HorzAlignment.Near, False, "", False, Nothing, False, "dd/MM/yyyy", "#,##0.####", "#,##0.##", True, color, color, False, Nothing, True, False)
                HDevExpre.CreaColumnasG(Me.gvEmpleados, "SNombre", "S. Nombre", True, True, "", System.Drawing.Color.FromArgb(204, 255, 204), False, False, 200.0!, 0!, HorzAlignment.Near, False, "", False, Nothing, False, "dd/MM/yyyy", "#,##0.####", "#,##0.##", True, color, color, False, Nothing, True, False)
                HDevExpre.CreaColumnasG(Me.gvEmpleados, "Genero", "Genero", True, True, "", System.Drawing.Color.FromArgb(204, 255, 204), False, False, 20.0!, CSng((Me.Width - 100)), HorzAlignment.Near, False, "", False, Nothing, False, "dd/MM/yyyy", "#,##0.####", "#,##0.##", False, color, color, False, Me.lkEditGenero, True, False)
                HDevExpre.CreaColumnasG(Me.gvEmpleados, "MunicipioNacimiento", "Municipio Nacimiento", True, True, "", System.Drawing.Color.FromArgb(204, 255, 204), False, False, 20.0!, CSng((Me.Width - 100)), HorzAlignment.Near, False, "", False, Nothing, False, "dd/MM/yyyy", "#,##0.####", "#,##0.##", False, color, color, False, Nothing, True, False)
                HDevExpre.CreaColumnasG(Me.gvEmpleados, "FechaNacimiento", "Fecha Nacimiento", True, True, "", System.Drawing.Color.FromArgb(204, 255, 204), False, False, 20.0!, CSng((Me.Width - 100)), HorzAlignment.Near, False, "", False, Nothing, False, "dd/MM/yyyy", "#,##0.####", "#,##0.##", False, color, color, False, Nothing, True, False)
                HDevExpre.CreaColumnasG(Me.gvEmpleados, "LugarExpDoc", "Lugar Exp. Documento", True, True, "", System.Drawing.Color.FromArgb(204, 255, 204), False, False, 20.0!, CSng((Me.Width - 100)), HorzAlignment.Near, False, "", False, Nothing, False, "dd/MM/yyyy", "#,##0.####", "#,##0.##", False, color, color, False, Nothing, True, False)
                HDevExpre.CreaColumnasG(Me.gvEmpleados, "FechaExpDoc", "Fecha Exp. Documento", True, True, "", System.Drawing.Color.FromArgb(204, 255, 204), False, False, 20.0!, CSng((Me.Width - 100)), HorzAlignment.Near, False, "", False, Nothing, False, "dd/MM/yyyy", "#,##0.####", "#,##0.##", False, color, color, False, Nothing, True, False)
                HDevExpre.CreaColumnasG(Me.gvEmpleados, "Municipio", "Municipio Residencia", True, True, "", System.Drawing.Color.FromArgb(204, 255, 204), False, False, 20.0!, CSng((Me.Width - 100)), HorzAlignment.Near, False, "", False, Nothing, False, "dd/MM/yyyy", "#,##0.####", "#,##0.##", False, color, color, False, Nothing, True, False)
                HDevExpre.CreaColumnasG(Me.gvEmpleados, "Direccion", "Direccion", True, True, "", System.Drawing.Color.FromArgb(204, 255, 204), False, False, 20.0!, CSng((Me.Width - 100)), HorzAlignment.Near, False, "", False, Nothing, False, "dd/MM/yyyy", "#,##0.####", "#,##0.##", False, color, color, False, Nothing, True, False)
                HDevExpre.CreaColumnasG(Me.gvEmpleados, "Barrio", "Barrio", True, True, "", System.Drawing.Color.FromArgb(204, 255, 204), False, False, 20.0!, CSng((Me.Width - 100)), HorzAlignment.Near, False, "", False, Nothing, False, "dd/MM/yyyy", "#,##0.####", "#,##0.##", False, color, color, False, Nothing, True, False)
                HDevExpre.CreaColumnasG(Me.gvEmpleados, "Email1", "Email 1", True, True, "", System.Drawing.Color.FromArgb(204, 255, 204), False, False, 20.0!, CSng((Me.Width - 100)), HorzAlignment.Near, False, "", False, Nothing, False, "dd/MM/yyyy", "#,##0.####", "#,##0.##", False, color, color, False, Nothing, True, False)
                HDevExpre.CreaColumnasG(Me.gvEmpleados, "Email2", "Email 2", True, True, "", System.Drawing.Color.FromArgb(204, 255, 204), False, False, 20.0!, CSng((Me.Width - 100)), HorzAlignment.Near, False, "", False, Nothing, False, "dd/MM/yyyy", "#,##0.####", "#,##0.##", False, color, color, False, Nothing, True, False)
                HDevExpre.CreaColumnasG(Me.gvEmpleados, "PersonasaCargo", "Personas a Cargo", True, True, "", System.Drawing.Color.FromArgb(204, 255, 204), False, False, 20.0!, CSng((Me.Width - 100)), HorzAlignment.Near, False, "", False, Nothing, False, "dd/MM/yyyy", "#,##0.####", "#,##0.##", False, color, color, False, Nothing, True, False)
                HDevExpre.CreaColumnasG(Me.gvEmpleados, "Profesion", "Profesion", True, True, "", System.Drawing.Color.FromArgb(204, 255, 204), False, False, 20.0!, CSng((Me.Width - 100)), HorzAlignment.Near, False, "", False, Nothing, False, "dd/MM/yyyy", "#,##0.####", "#,##0.##", False, color, color, False, Me.lkEditProfesion, True, False)
                HDevExpre.CreaColumnasG(Me.gvEmpleados, "EstadoCivil", "Estado Civil", True, True, "", System.Drawing.Color.FromArgb(204, 255, 204), False, False, 20.0!, CSng((Me.Width - 100)), HorzAlignment.Near, False, "", False, Nothing, False, "dd/MM/yyyy", "#,##0.####", "#,##0.##", False, color, color, False, Me.lkEditEstadoCivil, True, False)
                HDevExpre.CreaColumnasG(Me.gvEmpleados, "Tel1", "Teléfono 1", True, True, "", System.Drawing.Color.FromArgb(204, 255, 204), False, False, 20.0!, CSng((Me.Width - 100)), HorzAlignment.Near, False, "", False, Nothing, False, "dd/MM/yyyy", "#,##0.####", "#,##0.##", False, color, color, False, Nothing, True, False)
                HDevExpre.CreaColumnasG(Me.gvEmpleados, "Tel2", "Teléfono 2", True, True, "", System.Drawing.Color.FromArgb(204, 255, 204), False, False, 20.0!, CSng((Me.Width - 100)), HorzAlignment.Near, False, "", False, Nothing, False, "dd/MM/yyyy", "#,##0.####", "#,##0.##", False, color, color, False, Nothing, True, False)
                HDevExpre.CreaColumnasG(Me.gvEmpleados, "NumCelular", "Celular", True, True, "", System.Drawing.Color.FromArgb(204, 255, 204), False, False, 20.0!, CSng((Me.Width - 100)), HorzAlignment.Near, False, "", False, Nothing, False, "dd/MM/yyyy", "#,##0.####", "#,##0.##", False, color, color, False, Nothing, True, False)
                HDevExpre.CreaColumnasG(Me.gvEmpleados, "WebPage", "Página Web", True, True, "", System.Drawing.Color.FromArgb(204, 255, 204), False, False, 20.0!, CSng((Me.Width - 100)), HorzAlignment.Near, False, "", False, Nothing, False, "dd/MM/yyyy", "#,##0.####", "#,##0.##", False, color, color, False, Nothing, True, False)
                HDevExpre.CreaColumnasG(Me.gvEmpleados, "LicConduccion", "Lic. Conduccion", True, True, "", System.Drawing.Color.FromArgb(204, 255, 204), False, False, 20.0!, CSng((Me.Width - 100)), HorzAlignment.Near, False, "", False, Nothing, False, "dd/MM/yyyy", "#,##0.####", "#,##0.##", False, color, color, False, Nothing, True, False)
                HDevExpre.CreaColumnasG(Me.gvEmpleados, "LicCategoria", "Cat. Licencia", True, True, "", System.Drawing.Color.FromArgb(204, 255, 204), False, False, 20.0!, CSng((Me.Width - 100)), HorzAlignment.Near, False, "", False, Nothing, False, "dd/MM/yyyy", "#,##0.####", "#,##0.##", False, color, color, False, Me.lkEditClaseLicencia, True, False)
                HDevExpre.CreaColumnasG(Me.gvEmpleados, "ClaseLib", "Clase Libreta", True, True, "", System.Drawing.Color.FromArgb(204, 255, 204), False, False, 20.0!, CSng((Me.Width - 100)), HorzAlignment.Near, False, "", False, Nothing, False, "dd/MM/yyyy", "#,##0.####", "#,##0.##", False, color, color, False, Me.lkEditClaseLibreta, True, False)
                HDevExpre.CreaColumnasG(Me.gvEmpleados, "NumLib", "Número Libreta", True, True, "", System.Drawing.Color.FromArgb(204, 255, 204), False, False, 20.0!, CSng((Me.Width - 100)), HorzAlignment.Near, False, "", False, Nothing, False, "dd/MM/yyyy", "#,##0.####", "#,##0.##", False, color, color, False, Nothing, True, False)
                HDevExpre.CreaColumnasG(Me.gvEmpleados, "DistritoLib", "Ditrito Militar", True, True, "", System.Drawing.Color.FromArgb(204, 255, 204), False, False, 20.0!, CSng((Me.Width - 100)), HorzAlignment.Near, False, "", False, Nothing, False, "dd/MM/yyyy", "#,##0.####", "#,##0.##", False, color, color, False, Nothing, True, False)
                HDevExpre.CreaColumnasG(Me.gvEmpleados, "codBanco", "Banco", True, True, "", System.Drawing.Color.FromArgb(204, 255, 204), False, False, 20.0!, CSng((Me.Width - 100)), HorzAlignment.Near, False, "", False, Nothing, False, "dd/MM/yyyy", "#,##0.####", "#,##0.##", False, color, color, False, Me.lkEditBanco, True, False)
                HDevExpre.CreaColumnasG(Me.gvEmpleados, "NumCuenta", "Numero Cuenta", True, True, "", System.Drawing.Color.FromArgb(204, 255, 204), False, False, 20.0!, CSng((Me.Width - 100)), HorzAlignment.Near, False, "", False, Nothing, False, "dd/MM/yyyy", "#,##0.####", "#,##0.##", False, color, color, False, Nothing, True, False)
                HDevExpre.CreaColumnasG(Me.gvEmpleados, "TipoCuenta", "Tipo Cuenta", True, True, "", System.Drawing.Color.FromArgb(204, 255, 204), False, False, 20.0!, CSng((Me.Width - 100)), HorzAlignment.Near, False, "", False, Nothing, False, "dd/MM/yyyy", "#,##0.####", "#,##0.##", False, color, color, False, Me.lkEditTipoCuenta, True, False)
                HDevExpre.CreaColumnasG(Me.gvEmpleados, "Comentario", "Comentario", True, True, "", System.Drawing.Color.FromArgb(204, 255, 204), False, False, 20.0!, CSng((Me.Width - 100)), HorzAlignment.Near, False, "", False, Nothing, False, "dd/MM/yyyy", "#,##0.####", "#,##0.##", False, color, color, False, Nothing, True, False)
                HDevExpre.CreaColumnasG(Me.gvEmpleados, "Resultado", "Resultado", True, False, "", System.Drawing.Color.FromArgb(204, 255, 204), False, False, 20.0!, CSng((Me.Width - 100)), HorzAlignment.Near, False, "", False, Nothing, False, "dd/MM/yyyy", "#,##0.####", "#,##0.##", False, color, color, False, Nothing, True, False)
                Me.gvEmpleados.ViewCaption = "Listado de Empleados"
                Me.gvEmpleados.OptionsView.ShowViewCaption = True
                Me.gvEmpleados.Appearance.HeaderPanel.Font = New System.Drawing.Font("Trebuchet MS", 11.0!, FontStyle.Bold)
                Me.gvEmpleados.OptionsView.ShowAutoFilterRow = True
                Dim size As Single = Me.gvEmpleados.Appearance.FocusedRow.Font.Size
                size += 2.0!
                Dim fontFamily As System.Drawing.FontFamily = Me.gvEmpleados.Appearance.FocusedRow.Font.FontFamily
                Me.gvEmpleados.Appearance.FocusedRow.Font = New System.Drawing.Font(fontFamily, size, FontStyle.Bold)
                Me.gvEmpleados.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 11.7!, FontStyle.Regular)
            Catch exception1 As System.Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As System.Exception = exception1
                HDevExpre.msgError(exception, exception.Message, "CreaGrilla")
                ProjectData.ClearProjectError()
            End Try
        End Sub

        <DebuggerNonUserCode>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing AndAlso Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        Private Sub FrmImportaEmpleados_Load(ByVal sender As Object, ByVal e As EventArgs)
            Me.CargaLkEdit()
            Me.CreaGrilla()
        End Sub

        Private Sub gvEmpleados_RowStyle(ByVal sender As Object, ByVal e As RowStyleEventArgs)
            Try
                If (Me.gvEmpleados.RowCount > 0) Then
                    Dim gridView As DevExpress.XtraGrid.Views.Grid.GridView = DirectCast(sender, DevExpress.XtraGrid.Views.Grid.GridView)
                    If (e.RowHandle >= 0) Then
                        Dim str As String = gridView.GetRowCellValue(e.RowHandle, "Resultado").ToString()
                        If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "", False) = 0) Then
                            e.Appearance.BackColor = Color.FromArgb(0, 179, 153)
                            e.Appearance.ForeColor = Color.White
                        ElseIf (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Ok", False) <> 0) Then
                            e.Appearance.BackColor = Color.FromArgb(191, 35, 35)
                            e.Appearance.ForeColor = Color.White
                        Else
                            e.Appearance.BackColor = Color.FromArgb(33, 176, 40)
                            e.Appearance.ForeColor = Color.White
                        End If
                    End If
                End If
            Catch exception As System.Exception
                ProjectData.SetProjectError(exception)
                ProjectData.ClearProjectError()
            End Try
        End Sub

        Private Sub gvProductosFactura_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs)
            If (Me.gvEmpleados.FocusedRowHandle = e.RowHandle) Then
                e.Appearance.BackColor = Color.FromArgb(35, 50, 153)
                e.Appearance.ForeColor = Color.White
            ElseIf (Me.gvEmpleados.IsRowSelected(e.RowHandle)) Then
                e.Appearance.BackColor = Color.FromArgb(35, 50, 153)
            End If
        End Sub

        <DebuggerStepThrough>
        Private Sub InitializeComponent()
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmImportaEmpleados))
            gcEmpleados = New GridControl()

            Me.gvEmpleados = New GridView()
            Me.GroupControl1 = New GroupControl()
            Me.btnExportar = New SimpleButton()
            Me.btnLimpiar = New SimpleButton()
            Me.btnImportar = New SimpleButton()
            Me.btnGuardar = New SimpleButton()
            Me.btnSalir = New SimpleButton()
            Me.OpenFileDialog1 = New OpenFileDialog()
            DirectCast(Me.gcEmpleados, ISupportInitialize).BeginInit()
            DirectCast(Me.gvEmpleados, ISupportInitialize).BeginInit()
            DirectCast(Me.GroupControl1, ISupportInitialize).BeginInit()
            Me.GroupControl1.SuspendLayout()
            Me.SuspendLayout()
            Me.gcEmpleados.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
            Dim gridControl As GridControl = Me.gcEmpleados
            Dim point As System.Drawing.Point = New System.Drawing.Point(10, 9)
            gridControl.Location = point
            Me.gcEmpleados.MainView = Me.gvEmpleados
            Me.gcEmpleados.Name = "gcEmpleados"
            Dim gridControl1 As DevExpress.XtraGrid.GridControl = Me.gcEmpleados
            Dim size As System.Drawing.Size = New System.Drawing.Size(922, 521)
            gridControl1.Size = size
            Me.gcEmpleados.TabIndex = 15
            Me.gcEmpleados.TabStop = False
            Me.gcEmpleados.ViewCollection.AddRange(New BaseView() {Me.gvEmpleados})
            Me.gvEmpleados.GridControl = Me.gcEmpleados
            Me.gvEmpleados.Name = "gvEmpleados"
            Me.GroupControl1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
            Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.25!)
            Me.GroupControl1.AppearanceCaption.Options.UseFont = True
            Me.GroupControl1.BorderStyle = BorderStyles.Simple
            Me.GroupControl1.CaptionImagePadding = New System.Windows.Forms.Padding(0, 3, 3, 3)
            Me.GroupControl1.Controls.Add(Me.btnExportar)
            Me.GroupControl1.Controls.Add(Me.btnLimpiar)
            Me.GroupControl1.Controls.Add(Me.btnImportar)
            Me.GroupControl1.Controls.Add(Me.btnGuardar)
            Me.GroupControl1.Controls.Add(Me.btnSalir)
            Dim groupControl1 As DevExpress.XtraEditors.GroupControl = Me.GroupControl1
            point = New System.Drawing.Point(938, 9)
            groupControl1.Location = point
            Me.GroupControl1.Name = "GroupControl1"
            Dim groupControl As DevExpress.XtraEditors.GroupControl = Me.GroupControl1
            size = New System.Drawing.Size(88, 521)
            groupControl.Size = size
            Me.GroupControl1.TabIndex = 16
            Me.GroupControl1.TabStop = True
            Me.GroupControl1.Text = "Opciones"
            Me.btnExportar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            Me.btnExportar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
            Me.btnExportar.Appearance.Options.UseFont = True
            Dim simpleButton As DevExpress.XtraEditors.SimpleButton = Me.btnExportar
            point = New System.Drawing.Point(7, 132)
            simpleButton.Location = point
            Me.btnExportar.Name = "btnExportar"
            Dim simpleButton1 As DevExpress.XtraEditors.SimpleButton = Me.btnExportar
            size = New System.Drawing.Size(74, 55)
            simpleButton1.Size = size
            Me.btnExportar.TabIndex = 4
            Me.btnExportar.Text = "Exportar " & vbCrLf & "Resultado"
            Me.btnLimpiar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            Me.btnLimpiar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
            Me.btnLimpiar.Appearance.Options.UseFont = True
            Dim simpleButton2 As DevExpress.XtraEditors.SimpleButton = Me.btnLimpiar
            point = New System.Drawing.Point(7, 96)
            simpleButton2.Location = point
            Me.btnLimpiar.Name = "btnLimpiar"
            Dim simpleButton3 As DevExpress.XtraEditors.SimpleButton = Me.btnLimpiar
            size = New System.Drawing.Size(74, 30)
            simpleButton3.Size = size
            Me.btnLimpiar.TabIndex = 3
            Me.btnLimpiar.Text = "Limpiar"
            Me.btnImportar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            Me.btnImportar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
            Me.btnImportar.Appearance.Options.UseFont = True
            Dim simpleButton4 As DevExpress.XtraEditors.SimpleButton = Me.btnImportar
            point = New System.Drawing.Point(7, 24)
            simpleButton4.Location = point
            Me.btnImportar.Name = "btnImportar"
            Dim simpleButton5 As DevExpress.XtraEditors.SimpleButton = Me.btnImportar
            size = New System.Drawing.Size(74, 30)
            simpleButton5.Size = size
            Me.btnImportar.TabIndex = 1
            Me.btnImportar.Text = "Importar"
            Me.btnGuardar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
            Me.btnGuardar.Appearance.Options.UseFont = True
            Dim simpleButton6 As DevExpress.XtraEditors.SimpleButton = Me.btnGuardar
            point = New System.Drawing.Point(7, 60)
            simpleButton6.Location = point
            Me.btnGuardar.Name = "btnGuardar"
            Dim simpleButton7 As DevExpress.XtraEditors.SimpleButton = Me.btnGuardar
            size = New System.Drawing.Size(74, 30)
            simpleButton7.Size = size
            Me.btnGuardar.TabIndex = 2
            Me.btnGuardar.Text = "Guardar"
            Me.btnSalir.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
            Me.btnSalir.Appearance.Options.UseFont = True
            Dim simpleButton8 As DevExpress.XtraEditors.SimpleButton = Me.btnSalir
            point = New System.Drawing.Point(8, 194)
            simpleButton8.Location = point
            Me.btnSalir.Name = "btnSalir"
            Dim simpleButton9 As DevExpress.XtraEditors.SimpleButton = Me.btnSalir
            size = New System.Drawing.Size(74, 30)
            simpleButton9.Size = size
            Me.btnSalir.TabIndex = 5
            Me.btnSalir.Text = "Salir"
            Me.OpenFileDialog1.FileName = "OpenFileDialog1"
            Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            size = New System.Drawing.Size(1035, 539)
            Me.ClientSize = size
            Me.Controls.Add(Me.gcEmpleados)
            Me.Controls.Add(Me.GroupControl1)
            Me.Icon = DirectCast(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FrmImportaEmpleados"
            Me.Text = "Importar Empleados"
            DirectCast(Me.gcEmpleados, ISupportInitialize).EndInit()
            DirectCast(Me.gvEmpleados, ISupportInitialize).EndInit()
            DirectCast(Me.GroupControl1, ISupportInitialize).EndInit()
            Me.GroupControl1.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

        Public Function ValidaEmpleado(ByVal TipoDoc As String, ByVal Doc As String, ByVal PNombre As String, ByVal PApellido As String, ByVal Genero As String, ByVal Profesion As String, ByVal EstadoCivil As String, ByVal Celular As String, ByVal Correo As String, ByVal MunicipioResidencia As String, ByVal BarrioResidencia As String, ByVal DireccionResidencia As String, ByVal MunicipioExpe As String, ByVal MunicipioNacimiento As String, ByVal FechaExpe As String, ByVal FechaNacimiento As String) As String
            Dim dateTime As System.DateTime = Convert.ToDateTime(FechaExpe)
            Dim dateTime1 As System.DateTime = Convert.ToDateTime(FechaNacimiento)
            If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(TipoDoc, "", False) = 0) Then
                Return "El campo TipoDoc no puede estar vacío!.."
            End If
            If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Doc, "", False) = 0) Then
                Return "El campo Doc no puede estar vacío!.."
            End If
            If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(PNombre, "", False) = 0) Then
                Return "El campo primer nombre no puede estar vacío!.."
            End If
            If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(PApellido, "", False) = 0) Then
                Return "El campo primer apellido no puede estar vacío!.."
            End If
            If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Genero, "", False) = 0) Then
                Return "Debe seleccionar el Género!.."
            End If
            If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Profesion, "", False) = 0) Then
                Return "Debe seleccionar alguna Profesión!.."
            End If
            If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(EstadoCivil, "", False) = 0) Then
                Return "Debe seleccionar el Estado Civil!.."
            End If
            If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Celular, "", False) = 0) Then
                Return "Debe agregar al menos un número de celular!.."
            End If
            If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Correo, "", False) = 0) Then
                Return "Debe agregar al menos un correo electrónico!.."
            End If
            If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MunicipioResidencia, "", False) = 0) Then
                Return "Debe seleccionar el minicipio de residencia!.."
            End If
            If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(BarrioResidencia, "", False) = 0) Then
                Return "El campo barrio no puede estar vacío!.."
            End If
            If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(DireccionResidencia, "", False) = 0) Then
                Return "El campo dirección no puede estar vacío!.."
            End If
            If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MunicipioExpe, "", False) = 0) Then
                Return "Debe seleccionar el lugar de expedición de documento!.."
            End If
            If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(FechaExpe, "", False) = 0) Then
                Return "Debe seleccionar la fecha de expedición de documento!.."
            End If
            If (DateAndTime.DateDiff(DateInterval.Year, dateTime, ObjetosNomina.Datos.Smt_FechaDelServidor(), FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1) > CLng(100)) Then
                Return "La fecha de expedicón del docuemnto no es válida, al parecer es inferior al año 1910!.."
            End If
            If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MunicipioNacimiento, "", False) = 0) Then
                Return "Debe seleccionar el lugar de nacimiento del empleado!.."
            End If
            If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(FechaNacimiento, "", False) = 0) Then
                Return "Debe seleccionar la fecha de nacimiento!.."
            End If
            If (DateAndTime.DateDiff(DateInterval.Year, dateTime1, ObjetosNomina.Datos.Smt_FechaDelServidor(), FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1) > CLng(100)) Then
                Return "La fecha de nacimiento no es válida, al parecer es inferior al año 1910!.."
            End If
            If (DateAndTime.DateDiff(DateInterval.Year, dateTime1, ObjetosNomina.Datos.Smt_FechaDelServidor(), FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1) < CLng(18)) Then
                Return "Por favor revise la fecha de nacimiento, al parecer la fecha no coinicide con la de un adulto!.."
            End If
            Return "Ok"
        End Function
    End Class
End Namespace