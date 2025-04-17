Imports Microsoft.Win32
Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports System.Drawing

Public Class ClregistroSamit
    Public Property Servidor As String
        Get
            Servidor = GetSetting("SamitSQL", "Inicio", "Servidor", "")
        End Get
        Set(value As String)
            SaveSetting("SamitSQL", "Inicio", "Servidor", value)
        End Set
    End Property
    Public Property UsuarioIngresa As String
        Get
            UsuarioIngresa = GetSetting("SamitSQL", "Inicio", "Usuario", "")
        End Get
        Set(value As String)
            SaveSetting("SamitSQL", "Inicio", "Usuario", value)
        End Set
    End Property
    Public Property FechaUltimo_Ingreso As String
        Get
            FechaUltimo_Ingreso = GetSetting("SamitSQL", "Inicio", "FechaUltimoIngreso", Today)
        End Get
        Set(value As String)
            SaveSetting("SamitSQL", "Inicio", "FechaUltimoIngreso", value)
        End Set
    End Property
    Public Property Empresa_Ingreso As String
        Get
            Empresa_Ingreso = GetSetting("SamitSQL", "Inicio", "Empresa")
        End Get
        Set(value As String)
            SaveSetting("SamitSQL", "Inicio", "Empresa", value)
        End Set
    End Property
    Public Property Ruta_Informes As String
        Get
            Ruta_Informes = GetSetting("SamitSQL", "Inicio", "Path_Informes")
        End Get
        Set(value As String)
            SaveSetting("SamitSQL", "Inicio", "Path_Informes", value)
        End Set
    End Property

    Public Property Ruta_Ejectuables As String
        Get
            Ruta_Ejectuables = GetSetting("SamitSQL", "Inicio", "RutaEjecutables")
        End Get
        Set(value As String)
            SaveSetting("SamitSQL", "Inicio", "RutaEjecutables", value)
        End Set
    End Property

    Public Property Oficina_Ingreso As String
        Get
            Oficina_Ingreso = GetSetting("SamitSQL", "Inicio", "Oficina")
        End Get
        Set(value As String)
            SaveSetting("SamitSQL", "Inicio", "Oficina", value)
        End Set
    End Property
    Public Property Puerto_Pos As String
        Get
            Puerto_Pos = GetSetting("SamitSQL", "Inicio", "PuertoPos")
        End Get
        Set(value As String)
            SaveSetting("SamitSQL", "Inicio", "PuertoPos", value)
        End Set
    End Property
    Public Property Imprime_Logo As String
        Get
            Imprime_Logo = GetSetting("SamitSQL", "Inicio", "Imprime_Logo")
        End Get
        Set(value As String)
            SaveSetting("SamitSQL", "Inicio", "Imprime_Logo", value)
        End Set
    End Property

    Public Property Establecimiento_Predeterminado As String
        Get
            Establecimiento_Predeterminado = GetSetting("SamitSQL", "Inicio", "Establecimiento Predeterminado")
        End Get
        Set(value As String)
            SaveSetting("SamitSQL", "Inicio", "Establecimiento Predeterminado", value)
        End Set
    End Property

    Public Property ArcLog As String
        Get
            ArcLog = GetSetting("SamitSQL", "Inicio", "ArcLog")
        End Get
        Set(value As String)
            SaveSetting("SamitSQL", "Inicio", "ArcLog", value)
        End Set
    End Property

    Public Property ImpMatrixPunto As String
        Get
            ImpMatrixPunto = GetSetting("SamitSQL", "Inicio", "ImpMatrixPunto")
        End Get
        Set(value As String)
            SaveSetting("SamitSQL", "Inicio", "ImpMatrixPunto", value)
        End Set
    End Property

    Public Property PapelPosTermica As String
        Get
            PapelPosTermica = GetSetting("SamitSQL", "Punto de Venta", "PapelPosTermica")
        End Get
        Set(value As String)
            SaveSetting("SamitSQL", "Punto de Venta", "PapelPosTermica", value)
        End Set
    End Property

    Public Property ConfirmaImprimeFactura As String
        Get
            ConfirmaImprimeFactura = GetSetting("SamitSQL", "Punto de Venta", "ConfirmaImprimeFactura")
        End Get
        Set(value As String)
            SaveSetting("SamitSQL", "Punto de Venta", "ConfirmaImprimeFactura", value)
        End Set
    End Property

    Public Property PuertoDisplay As String
        Get
            PuertoDisplay = GetSetting("SamitSQL", "Punto de Venta", "PuertoDisplay")
        End Get
        Set(value As String)
            SaveSetting("SamitSQL", "Punto de Venta", "PuertoDisplay", value)
        End Set
    End Property

    Public Property CoincidenciaExactaBuscaProducto As String
        Get
            CoincidenciaExactaBuscaProducto = GetSetting("SamitSQL", "Punto de Venta", "CoincidenciaExactaBuscaProducto")
        End Get
        Set(value As String)
            SaveSetting("SamitSQL", "Punto de Venta", "CoincidenciaExactaBuscaProducto", value)
        End Set
    End Property

    Public Property ImprimeAutorizaciones As String
        Get
            ImprimeAutorizaciones = GetSetting("SamitSQL", "Punto de Venta", "ImprimeAutorizaciones")
        End Get
        Set(value As String)
            SaveSetting("SamitSQL", "Punto de Venta", "ImprimeAutorizaciones", value)
        End Set
    End Property

    Public Property PuertoBalanza As String
        Get
            PuertoBalanza = GetSetting("SamitSQL", "Punto de Venta", "PuertoBalanza")
        End Get
        Set(value As String)
            SaveSetting("SamitSQL", "Punto de Venta", "PuertoBalanza", value)
        End Set
    End Property

    Public Property TipoBalanza As String
        Get
            TipoBalanza = GetSetting("SamitSQL", "Punto de Venta", "TipoBalanza")
        End Get
        Set(value As String)
            SaveSetting("SamitSQL", "Punto de Venta", "TipoBalanza", value)
        End Set
    End Property

    Public Property ConfirmaCantProd As String
        Get
            ConfirmaCantProd = GetSetting("SamitSQL", "Punto de Venta", "ConfirmaCantProd")
        End Get
        Set(value As String)
            SaveSetting("SamitSQL", "Punto de Venta", "ConfirmaCantProd", value)
        End Set
    End Property

    Public Property Maximizado As String
        Get
            Maximizado = GetSetting("SamitSQL", "Punto de Venta", "Maximizado")
        End Get
        Set(value As String)
            SaveSetting("SamitSQL", "Punto de Venta", "Maximizado", value)
        End Set
    End Property

    Public Property Bodega As String
        Get
            Bodega = GetSetting("SamitSQL", "Punto de Venta", "Bodega")
        End Get
        Set(value As String)
            SaveSetting("SamitSQL", "Punto de Venta", "Bodega", value)
        End Set
    End Property

    Public Property Cajero As String
        Get
            Cajero = GetSetting("SamitSQL", "Punto de Venta", "Cajero")
        End Get
        Set(value As String)
            SaveSetting("SamitSQL", "Punto de Venta", "Cajero", value)
        End Set
    End Property

    Public Property CodigoCAJA As String
        Get
            CodigoCAJA = GetSetting("SamitSQL", "Punto de Venta", "CodigoCAJA")
        End Get
        Set(value As String)
            SaveSetting("SamitSQL", "Punto de Venta", "CodigoCAJA", value)
        End Set
    End Property

    Public Property ClientePredeterminado As String
        Get
            ClientePredeterminado = GetSetting("SamitSQL", "Punto de Venta", "ClientePredeterminado")
        End Get
        Set(value As String)
            SaveSetting("SamitSQL", "Punto de Venta", "ClientePredeterminado", value)
        End Set
    End Property

    Public Property NumComprobante As String
        Get
            NumComprobante = GetSetting("SamitSQL", "Punto de Venta", "#Comprobante")
        End Get
        Set(value As String)
            SaveSetting("SamitSQL", "Punto de Venta", "#Comprobante", value)
        End Set
    End Property

    Public Property NombrePosTermica As String
        Get
            NombrePosTermica = GetSetting("SamitSQL", "Punto de Venta", "NombrePosTermica")
        End Get
        Set(value As String)
            SaveSetting("SamitSQL", "Punto de Venta", "NombrePosTermica", value)
        End Set
    End Property

    Public Property ImpPosTermica As String
        Get
            ImpPosTermica = GetSetting("SamitSQL", "Punto de Venta", "ImpPosTermica")
        End Get
        Set(value As String)
            SaveSetting("SamitSQL", "Punto de Venta", "ImpPosTermica", value)
        End Set
    End Property

    Public Property TipoComprobante As String
        Get
            TipoComprobante = GetSetting("SamitSQL", "Punto de Venta", "TipoComprobante")
        End Get
        Set(value As String)
            SaveSetting("SamitSQL", "Punto de Venta", "TipoComprobante", value)
        End Set
    End Property

    Public Property ComprobanteDevolucion As String
        Get
            ComprobanteDevolucion = GetSetting("SamitSQL", "Punto de Venta", "ComprobanteDevolucion")
        End Get
        Set(value As String)
            SaveSetting("SamitSQL", "Punto de Venta", "ComprobanteDevolucion", value)
        End Set
    End Property

    Public Property NumComprobanteDevolucion As String
        Get
            NumComprobanteDevolucion = GetSetting("SamitSQL", "Punto de Venta", "NumComprobanteDevolucion")
        End Get
        Set(value As String)
            SaveSetting("SamitSQL", "Punto de Venta", "NumComprobanteDevolucion", value)
        End Set
    End Property

    Public Property PQ_VistaPrevia As String
        Get
            Try
                PQ_VistaPrevia = GetSetting("SamitSQL", "Parqueadero", "PQ_VistaPrevia", "0")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "PQ_VistaPrevia")
            End Try

        End Get
        Set(value As String)
            SaveSetting("SamitSQL", "Parqueadero", "PQ_VistaPrevia", value)
        End Set
    End Property
    Public Property PQ_TamañoPapel As String
        Get
            Try
                PQ_TamañoPapel = GetSetting("SamitSQL", "Parqueadero", "PQ_TamañoPapel", "0")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "PQ_TamañoPapel")
            End Try
        End Get
        Set(value As String)
            SaveSetting("SamitSQL", "Parqueadero", "PQ_TamañoPapel", value)
        End Set

    End Property
    Public Function Leer_Clave_Del_Registro(Section As String, Key As String, Optional VrDefault As String = "0") As String
        Leer_Clave_Del_Registro = GetSetting("SamitSQL", Section, Key)
    End Function
    Public Sub Guardar_Clave_Del_Registro(Section As String, Key As String, Valor As String)
        SaveSetting("SamitSQL", Section, Key, Valor)
    End Sub
    Public Sub Eliminar_Clave_Del_Registro(Section As String, Key As String)
        DeleteSetting("SamitSQL", Section, Key)
    End Sub
    Public Function Lista_Servidores_Samit() As List(Of String)
        Dim Servidores(,) As String, intSettings As Integer, Milista As New List(Of String)
        Try
            Servidores = GetAllSettings("SamitSQL", "Servers")
            Milista.Clear()
            If IsNothing(Servidores) Then
                Return Milista
                Exit Function
            End If

            For intSettings = LBound(Servidores, 1) To UBound(Servidores, 1)
                Milista.Add(Servidores(intSettings, 1))
            Next intSettings
            Return Milista
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return Milista
    End Function
    Public Class Inventario
        Shared Property ImpPosTermica As String
            Get
                ImpPosTermica = GetSetting("SamitSQL", "Inventario", "ImpPosTermica")
            End Get
            Set(value As String)
                SaveSetting("SamitSQL", "Inventario", "ImpPosTermica", value)
            End Set
        End Property
        Shared Property NombrePosTermica As String
            Get
                NombrePosTermica = GetSetting("SamitSQL", "Inventario", "NombrePosTermica")
            End Get
            Set(value As String)
                SaveSetting("SamitSQL", "Inventario", "NombrePosTermica", value)
            End Set
        End Property
    End Class
End Class
