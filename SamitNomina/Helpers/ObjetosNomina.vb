Imports DevExpress.Skins
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports SamitCore
Imports SamitNominaLogic
Imports System.IO
Imports SamitCtlNet


Public Class ObjetosNomina
    Private Sub New()  'constructor privado
    End Sub

    Private Shared _instancia As ObjetosNomina
    Dim HDevExpre As New HelperDevExpress
    Public Shared ReadOnly Property Instancia As ObjetosNomina
        Get
            If _instancia Is Nothing Then
                _instancia = New ObjetosNomina()
            End If
            Return _instancia
        End Get
    End Property


    Public Shared Datos As New SamitCtlNet.SamitCtlNet
    Public Shared DatosSeg As New SamitCtlNet.Clseguridad
    Public Shared UltimoSkin As String
    Public Shared NomUsu As String
    Public Shared NomTerminal As String
    Public Shared NumeroEmpresa As String
    Public Shared NombreBD As String
    Public Shared Oficinas As DataTable

    Public Shared MaxNivel As Byte
    Public Shared InicioConexionModulo As Boolean = False
    Public Shared Memo As New RepositoryItemMemoExEdit


    Public Shared Sub Desconectar()
        Datos = New SamitCtlNet.SamitCtlNet()
        InicioConexionModulo = False
        ObjetosNomina.NombreBD = ""
        ObjetosNomina.NomUsu = ""
        ObjetosNomina.NomTerminal = ""
        ObjetosNomina.NumeroEmpresa = ""
        ObjetosNomina.InicioConexionModulo = False
    End Sub



    Public Shared Sub Conectar(ByVal Token As ResponseToken)
        Try
            Datos.Smt_BDTrabajo = String.Format("E{0}{1}", ObjetosNomina.Datos.Seguridad.DatosDeLaEmpresa.NumEmpresa.ToString("000"), ObjetosNomina.Datos.Smt_FechaDeTrabajo.ToString("yyyy"))
            Datos.Smt_Usuario = Token.Usuario.Nombre
            Datos.Smt_FechaDeVentas = Token.FechaTrabajo
            Datos.Smt_FechaDelServidor = Token.FechaTrabajo
            Datos.Seguridad.DatosDeLaEmpresa = New SamitCtlNet.Clseguridad.DatosEmpresa With {
            .Ciudad = Token.Empresa.Ciudad,
            .Direccion = Token.Empresa.Direccion,
            .Nit = Token.Empresa.Nit,
            .DV = Token.Empresa.DigitoVerificacion,
            .RegimenIva = Token.Empresa.RegimenIva,
            .TipodePersona = CType(
    If(String.Equals(Token.Empresa.TipoPersona, "N", StringComparison.OrdinalIgnoreCase), 1, 2),
    SamitCtlNet.Clseguridad.TipoPersona),
            .NombreEmpresa = Token.Empresa.Nombre,
            .OficinaIngreso = New SamitCtlNet.Clseguridad.DatoOficina With {
            .Ciudad = Token.Oficina.Ciudad,
            .NombreComercial = Token.Oficina.NombreComercial,
            .Direccion = Token.Oficina.Direccion,
            .Telefono1 = Token.Oficina.Telefono1,
            .Telefono2 = Token.Oficina.Telefono2,
            .NumOficina = Token.Oficina.Codigo},
            .Logo = ByteArrayToImage(Token.Empresa.Logo),
            .NumEmpresa = Token.Empresa.Codigo
            }

            Datos.ColordeFondoTxtFoco = System.Drawing.ColorTranslator.FromHtml("#B9FFF9")
            InicioConexionModulo = True
            Datos.Smt_FechaDeTrabajo = Token.FechaTrabajo
            ObjetoApiNomina = ApiClient.Instance

        Catch ex As Exception

        End Try
    End Sub

    Public Shared Function ByteArrayToImage(bytes() As Byte) As Image
        If bytes Is Nothing OrElse bytes.Length = 0 Then
            Return Nothing
        End If

        Using ms As New MemoryStream(bytes)
            Return Image.FromStream(ms)
        End Using
    End Function
End Class
