<System.AttributeUsage(System.AttributeTargets.Property)>
Public Class SqlColumn
    Inherits System.Attribute

    ''' <summary>
    ''' Porpiedad autogenerada, no asignar
    ''' </summary>
    Public Property VariableName As String

    Public Property LlavePrimaria As Boolean
    Public Property Nombre As String
    Public Property TipoDato As SqlType
    ''' <summary>
    ''' - 1 Para MAX
    ''' - 0 Para no maneja largo
    ''' </summary>
    Public Property LargoColumna As Integer
    Public Property PrecisionColumna As Integer
    Public Property AceptaNull As Boolean = True
    Public Property ForaneaTabla As String
    Public Property ForaneaColumna As String
    Public Property Identity As Boolean
    Public Property IdentityInicio As Integer = 1
    Public Property IdentityAumento As Integer = 1
    Public Property ValorDefecto As String
    ''' <summary>
    ''' Indica si el valor por defecto es una expresion calculada, ejem: GETDATE() 
    ''' </summary>
    Public Property ValorDefectoIsExpression As Boolean

    Public Property SubConsulta As String
    Public Property ColumnaCalculada As String
    Public Property Unique As Boolean

    Public Property OmiteGuarda As Boolean

    Public Overrides Function ToString() As String
        Return "[" & Nombre & "] " & GetTipoColumna(False)
    End Function

    Public Function GetTipoColumna(alterColumna As Boolean) As String
        Dim campo = Me
        Dim tipoColumna As String = campo.TipoDato.ToString().ToUpper()

        If campo.LargoColumna > 0 Or campo.LargoColumna = -1 Then
            If campo.LargoColumna = -1 Then
                tipoColumna += " (MAX) "
            Else
                tipoColumna += "(" & campo.LargoColumna
                If campo.PrecisionColumna > 0 Then
                    tipoColumna += "," & campo.PrecisionColumna
                End If
                tipoColumna += ")"
            End If
        End If

        tipoColumna += " " & (If((campo.AceptaNull), "NULL", "NOT NULL"))

        If Not alterColumna Then
            'Parametros que son validos solo cuendo se agrega una columna nueva
            If campo.Identity Then
                tipoColumna += " IDENTITY "
            End If
            If Not IsNothing(campo.ValorDefecto) Then
                tipoColumna += " DEFAULT ('" & campo.ValorDefecto & "')"
            End If
        End If

        Return tipoColumna
    End Function

End Class

Public Enum SqlType
    BigInt = 0
    Binary = 1
    Bit = 2
    [Char] = 3
    DateTime = 4
    [Decimal] = 5
    Float = 6
    Image = 7
    Int = 8
    Money = 9
    NChar = 10
    NText = 11
    NVarChar = 12
    Real = 13
    UniqueIdentifier = 14
    SmallDateTime = 15
    SmallInt = 16
    SmallMoney = 17
    Text = 18
    Timestamp = 19
    TinyInt = 20
    VarBinary = 21
    VarChar = 22
    [Variant] = 23
    Xml = 25
    Udt = 29
    Structured = 30
    [Date] = 31
    Time = 32
    DateTime2 = 33
    DateTimeOffset = 34
    [Numeric] = 35
End Enum
