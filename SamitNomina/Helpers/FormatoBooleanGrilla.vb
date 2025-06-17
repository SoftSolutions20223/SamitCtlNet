Public Class FormatoBooleanGrilla
    Implements IFormatProvider, ICustomFormatter
    Dim trueString, falseString As String

    Public Sub New(ByVal trueString As String, ByVal falseString As String)
        Me.trueString = trueString
        Me.falseString = falseString
    End Sub

    Public Function GetFormat(ByVal type As System.Type) As Object _
    Implements IFormatProvider.GetFormat
        Return Me
    End Function

    Public Function Format(ByVal formatString As String, ByVal arg As Object,
    ByVal formatProvider As IFormatProvider) As String Implements ICustomFormatter.Format
        Dim formatValue As Boolean = Convert.ToBoolean(arg)
        If (formatValue) Then
            Return trueString
        Else
            Return falseString
        End If
    End Function
End Class
