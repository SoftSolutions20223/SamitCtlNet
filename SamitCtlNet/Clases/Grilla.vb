Imports System.Windows.Forms

Public Class Grilla
    Public Shared Function CrearGrilla(soloLectura As Boolean, multiSeleccion As Boolean, Optional plantilla As DataGridView = Nothing, Optional bordes As BorderStyle = BorderStyle.FixedSingle) As DataGridView
        Dim grilla As New DataGridView()
        If Not (plantilla Is Nothing) Then
            grilla = plantilla
        End If
        grilla.AutoGenerateColumns = False
        grilla.BorderStyle = bordes
        grilla.AllowUserToAddRows = False
        grilla.AllowUserToDeleteRows = False
        grilla.AllowUserToResizeRows = False
        grilla.BackgroundColor = System.Drawing.Color.White
        grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        grilla.MultiSelect = multiSeleccion
        grilla.[ReadOnly] = soloLectura
        grilla.RowHeadersVisible = False
        grilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Return grilla
    End Function
    Public Shared Function CrearColumna(nombreColumna As String, tituloColumna As String, Optional formato As String = Nothing, Optional Alineacion As DataGridViewContentAlignment = DataGridViewContentAlignment.MiddleLeft, Optional anchoColumna As Integer = 100, Optional soloLectura As Boolean = True, _
        Optional visible As Boolean = True, Optional tipoAncho As DataGridViewAutoSizeColumnMode = DataGridViewAutoSizeColumnMode.None) As DataGridViewColumn
        Dim columna As New DataGridViewColumn(New DataGridViewTextBoxCell()) With {
             .Name = nombreColumna,
             .DataPropertyName = nombreColumna,
             .HeaderText = tituloColumna,
             .Width = anchoColumna,
             .[ReadOnly] = soloLectura,
             .Visible = visible,
             .AutoSizeMode = tipoAncho
        }
        Dim estilo As DataGridViewCellStyle = New DataGridViewCellStyle()
        estilo.Format = formato
        estilo.Alignment = Alineacion
        columna.DefaultCellStyle = estilo
        Return columna
    End Function

    Public Shared Function CrearColumnaBoton(nombreColumna As String, tituloColumna As String, Optional textoBoton As String = "", Optional formato As String = Nothing, Optional Alineacion As DataGridViewContentAlignment = DataGridViewContentAlignment.MiddleLeft, Optional anchoColumna As Integer = 100, _
        Optional soloLectura As Boolean = True, Optional visible As Boolean = True, Optional tipoAncho As DataGridViewAutoSizeColumnMode = DataGridViewAutoSizeColumnMode.None) As DataGridViewButtonColumn
        Dim columna As New DataGridViewButtonColumn() With {
            .Name = nombreColumna,
            .DataPropertyName = nombreColumna,
            .HeaderText = tituloColumna,
            .Width = anchoColumna,
            .[ReadOnly] = soloLectura,
            .Visible = visible,
            .AutoSizeMode = tipoAncho,
            .DefaultCellStyle = New DataGridViewCellStyle() With {
                 .NullValue = textoBoton
            }
        }
        columna.DefaultCellStyle = New DataGridViewCellStyle() With {
             .Alignment = Alineacion
        }
        If formato IsNot Nothing Then
            columna.DefaultCellStyle = New DataGridViewCellStyle() With {
                 .Format = formato
            }
        End If
        Return columna
    End Function
    Public Shared Function CrearFiltro(tabla As DataTable, ByRef texto As String) As String
        If IsNothing(tabla) Then
            Return ""
        Else
            If texto.Length = 0 Then texto = ""
            If tabla.Rows.Count > 0 Then
                'texto = texto.Replace(" "c, ";"c)
                'Dim cadenas As String() = texto.Split(";"c)
                Dim cadenas As String() = texto.Split(" ")
                Dim filtro As String = ""
                For i As Integer = 0 To cadenas.Length - 1
                    If cadenas(i).Trim() <> "" Then
                        If i > 0 Then
                            filtro += " and "
                        End If
                        filtro += " ( "
                        For o As Integer = 0 To tabla.Columns.Count - 1
                            If tabla.Columns(o).DataType = Type.GetType("System.String") Then
                                filtro += " [" + tabla.Columns(o).ColumnName + "] like '%" + cadenas(i) + "%' "
                            Else
                                filtro += " CONVERT([" + tabla.Columns(o).ColumnName + "], System.String) like '%" + cadenas(i) + "%' "
                            End If
                            If o < tabla.Columns.Count - 1 Then
                                filtro += " or "
                            End If
                        Next
                        filtro += " ) "
                    End If
                Next
                Return filtro
            Else
                Return ""
            End If
        End If
    End Function
End Class
