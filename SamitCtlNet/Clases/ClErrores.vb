Imports System.Data.SqlClient
Imports DevExpress.XtraReports

Public Class ClErrores
    Dim Tb As DataTable, Secuencia As ULong = 0, NomProceso As String = ""

    Public Sub New()
        Iniciar_Tabla()
    End Sub
    Private Sub Iniciar_Tabla()
        Tb = New DataTable
        Tb.Columns.Add("Secuencia", GetType(ULong))
        Tb.Columns.Add("Ref", GetType(String))
        Tb.Columns.Add("Texto", GetType(String))
        Tb.Columns.Add("Linea", GetType(ULong))
    End Sub
    Public Sub Agregar_Error(Referencia As String, TextoError As String, Optional Linea As ULong = 0)
        Dim Fila As DataRow = Tb.NewRow
        Secuencia = Secuencia + 1
        Fila("Secuencia") = Secuencia
        Fila("Ref") = Referencia
        Fila("Texto") = TextoError
        Fila("Linea") = Linea
        Tb.Rows.Add(Fila)

    End Sub
    Public Sub Reiniciar()
        On Error Resume Next
        Secuencia = 0
        Iniciar_Tabla()
    End Sub

    Private _NombredelProceso As String
    Public Property NombredelProceso() As String
        Get
            Return _NombredelProceso
        End Get
        Set(ByVal value As String)
            _NombredelProceso = value
        End Set
    End Property

    Public ReadOnly Property NumeroDeErrores() As ULong
        Get
            Return Secuencia
        End Get
    End Property
    Public Sub Presentar_Informe()
        Dim Rpt As New RptErrores
        Dim Visor As New FrmVisor

        Rpt.NombreEmpresa.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Rpt.NombreEmpresa.Font = TraerTipodeLetra_FONT("Arial", 14, True, False)
        Rpt.NombreEmpresa.Text = DatosEmp.NombreEmpresa
        Rpt.Nit.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Rpt.Nit.Text = "Nit :" + DatosEmp.Nit.ToString("N0") + DatosEmp.DV.ToString
        Rpt.ProcesoNombre.Text = _NombredelProceso
        Rpt.DataSource = Tb
        Rpt.Sec.DataBindings.Add("Text", Nothing, "Secuencia")
        Rpt.Referencia.DataBindings.Add("Text", Nothing, "Ref")
        Rpt.DescError.DataBindings.Add("Text", Nothing, "Texto")
        Rpt.Linea.DataBindings.Add("Text", Nothing, "Linea")
        Rpt.LblUsuario.Text = SMTLogin
        Rpt.LblTerminal.Text = System.Net.Dns.GetHostName()
        Rpt.LogoImg.Image = DatosEmp.Logo
        Visor.VisorSamit.DocumentSource = Rpt
        Visor.VisorSamit.ShowPageMargins = False
        Visor.WindowState = Windows.Forms.FormWindowState.Maximized
        Visor.Show()
        Reiniciar()
    End Sub
End Class
