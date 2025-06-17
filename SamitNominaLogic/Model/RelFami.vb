Imports System.ComponentModel.DataAnnotations

Public Class RelFami
    Public Property Sec As Integer

    <Required>
    Public Property empleado As Integer

    <Required>
    Public Property familiar As Integer

    Public Property parentesco As Byte?

End Class