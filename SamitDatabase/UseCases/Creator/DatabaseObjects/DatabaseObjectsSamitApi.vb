'TODO: mover al proyecto SamitApi
Imports System.IO
Imports System.Reflection

Public Class DatabaseObjectsSamitApi
    Implements IDatabaseObjects

    Public Function GetDatabaseObjectsScripts(tipoBaseDatos As DatabasesSamit) As SqlScripts Implements IDatabaseObjects.GetDatabaseObjectsScripts
        Dim asem = Assembly.GetExecutingAssembly()
        Dim resourceName As String = ""

        If tipoBaseDatos = DatabasesSamit.Año Then
            resourceName = asem.GetManifestResourceNames().Single(Function(str) str.EndsWith("SqlScripts.xml"))
        End If

        If tipoBaseDatos = DatabasesSamit.Seguridad Then
            resourceName = asem.GetManifestResourceNames().Single(Function(str) str.EndsWith("SqlScriptsSeguridad.xml"))
        End If

        If tipoBaseDatos = DatabasesSamit.General Then
            resourceName = asem.GetManifestResourceNames().Single(Function(str) str.EndsWith("SqlScriptsGeneral.xml"))
        End If

        If tipoBaseDatos = DatabasesSamit.General Then
            resourceName = asem.GetManifestResourceNames().Single(Function(str) str.EndsWith("SqlScriptsGeneral.xml"))
        End If

        If Not String.IsNullOrWhiteSpace(resourceName) Then
            Using stream As Stream = asem.GetManifestResourceStream(resourceName)
                Using reader As StreamReader = New StreamReader(stream, System.Text.Encoding.UTF8, False)
                    Dim result As String = reader.ReadToEnd()

                    'TODO: descomentar al mover al SamitApi
                    'Dim serial = New Serializer()
                    'Dim scripts = serial.Deserialize(Of SqlScripts)(result)

                    'Return scripts
                End Using
            End Using
        End If

        Return Nothing
    End Function

End Class
