﻿Imports SamitCore
Imports SamitNominaLogic

Namespace My
    ' Los siguientes eventos están disponibles para MyApplication:
    ' Inicio: Se genera cuando se inicia la aplicación, antes de que se cree el formulario de inicio.
    ' Apagado: Se genera después de haberse cerrado todos los formularios de aplicación.  Este evento no se genera si la aplicación termina de forma anómala.
    ' UnhandledException: Se genera si la aplicación encuentra una excepción no controlada.
    ' StartupNextInstance: Se genera cuando se inicia una aplicación de instancia única y dicha aplicación está ya activa. 
    ' NetworkAvailabilityChanged: Se genera cuando se conecta o desconecta la conexión de red.
    Partial Friend Class MyApplication

        Private Sub MyApplication_Startup(ByVal sender As Object, ByVal e As ApplicationServices.StartupEventArgs) Handles Me.Startup
            Try
                Dim server As String = ConfigReader.GetConfigValue("Server", "")
                ApiClient.Instance = New Api(server, 0)
                ApiClient.Instance.BaseUrl = server
            Catch ex As Exception
                MessageBox.Show("Error during startup: " & ex.Message)
                e.Cancel = True  ' This will prevent the application from starting
            End Try
        End Sub

    End Class
End Namespace
