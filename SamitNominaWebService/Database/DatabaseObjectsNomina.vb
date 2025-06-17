Imports System.IO
Imports System.Reflection
Imports SamitDatabase

Public Class DatabaseObjectsNomina
    Implements IDatabaseObjects

    Public Function GetDatabaseObjectsScripts(tipoBaseDatos As DatabasesSamit) As SqlScripts Implements IDatabaseObjects.GetDatabaseObjectsScripts
        Dim asem = Assembly.GetExecutingAssembly()
        Dim resourceName As String = ""

        If tipoBaseDatos = DatabasesSamit.NominaFull Then
            resourceName = asem.GetManifestResourceNames().Single(Function(str) str.EndsWith("SqlScriptsNomina.xml"))
        End If

        If Not String.IsNullOrWhiteSpace(resourceName) Then
            Using stream As Stream = asem.GetManifestResourceStream(resourceName)
                Using reader As StreamReader = New StreamReader(stream, System.Text.Encoding.UTF8, False)
                    Dim result As String = reader.ReadToEnd()

                    Dim serial = New XmlSerializerHelper()
                    Dim scripts = serial.Deserialize(Of SqlScripts)(result)

                    Return scripts
                End Using
            End Using
        End If

        Return Nothing
    End Function

End Class
