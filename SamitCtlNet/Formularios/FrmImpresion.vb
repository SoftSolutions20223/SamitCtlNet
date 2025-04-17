Imports System.Drawing.Printing
Imports System.Windows.Forms

Public Class FrmImpresion

    Public NombreImpresora As String
    Public TamañoPapel As ClFunciones.TamañoPagina
    Public EsHorizontal As Boolean
    Public Copias As Integer

    Private Sub FrmImpresion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim aImpresoras(PrinterSettings.InstalledPrinters.Count - 1) As String
        Dim instance As New PrinterSettings
        Dim indice As Integer
        Me.Icon = My.Resources.SamitIcono
        For i As Integer = 0 To PrinterSettings.InstalledPrinters.Count - 1
            aImpresoras(i) = PrinterSettings.InstalledPrinters.Item(i)
            If instance.PrinterName = aImpresoras(i) Then
                lvimpresoras.Items.Add(aImpresoras(i), 1)
                indice = i
            Else
                lvimpresoras.Items.Add(aImpresoras(i), 0)
            End If
        Next

        lvimpresoras.Items(indice).Focused = True
        lvimpresoras.Items(indice).Selected = True

        lvpapeles.Items.Add("Carta", "page_white_text.png")
        lvpapeles.Items.Add("Media Carta", "page_white_text_width.png")
        lvpapeles.Items.Add("Oficio", "page_white_legal.png")


        lvorientacion.Items.Add("Vertical", "document_image_ver.png")
        lvorientacion.Items.Add("Horizontal", "document_image_hor.png")

        Select Case TamañoPapel
            Case ClFunciones.TamañoPagina.Carta
                lvpapeles.Items(0).Focused = True
                lvpapeles.Items(0).Selected = True
            Case ClFunciones.TamañoPagina.MediaCarta
                lvpapeles.Items(1).Focused = True
                lvpapeles.Items(1).Selected = True
            Case ClFunciones.TamañoPagina.Oficio
                lvpapeles.Items(2).Focused = True
                lvpapeles.Items(2).Selected = True
        End Select

        If EsHorizontal Then
            lvorientacion.Items(1).Focused = True
            lvorientacion.Items(1).Selected = True
        Else
            lvorientacion.Items(0).Focused = True
            lvorientacion.Items(0).Selected = True
        End If

        NumericUpDown1.Value = Copias
        btnimprimir.Focus()
    End Sub

    Private Sub lvimpresoras_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvimpresoras.SelectedIndexChanged
        For Each item As ListViewItem In lvimpresoras.Items
            If item.Selected = True Then
                item.ForeColor = Drawing.Color.Blue
            Else
                item.ForeColor = Drawing.Color.Black
            End If
        Next
    End Sub

    Private Sub lvpapeles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvpapeles.SelectedIndexChanged
        For Each item As ListViewItem In lvpapeles.Items
            If item.Selected = True Then
                item.ForeColor = Drawing.Color.Blue
            Else
                item.ForeColor = Drawing.Color.Black
            End If
        Next
    End Sub

    Private Sub lvorientacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvorientacion.SelectedIndexChanged
        For Each item As ListViewItem In lvorientacion.Items
            If item.Selected = True Then
                item.ForeColor = Drawing.Color.Blue
            Else
                item.ForeColor = Drawing.Color.Black
            End If
        Next
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        asignar()
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnimprimir_Click(sender As Object, e As EventArgs) Handles btnimprimir.Click
        asignar()
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnver_Click(sender As Object, e As EventArgs) Handles btnver.Click
        asignar()
        Me.DialogResult = Windows.Forms.DialogResult.Yes
        Me.Close()
    End Sub

    Private Sub asignar()
        If lvpapeles.SelectedItems(0).Text = "Carta" Then
            TamañoPapel = ClFunciones.TamañoPagina.Carta
        ElseIf lvpapeles.SelectedItems(0).Text = "Media Carta" Then
            TamañoPapel = ClFunciones.TamañoPagina.MediaCarta
        ElseIf lvpapeles.SelectedItems(0).Text = "Oficio" Then
            TamañoPapel = ClFunciones.TamañoPagina.Oficio
        End If

        If lvorientacion.SelectedItems(0).Text = "Horizontal" Then
            EsHorizontal = True
        Else
            EsHorizontal = False
        End If

        NombreImpresora = lvimpresoras.SelectedItems(0).Text

        Copias = NumericUpDown1.Value
    End Sub
    Private Sub FrmImpresion_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyData = Keys.F5 Then
            btnver_Click(Nothing, Nothing)
        ElseIf e.KeyData = Keys.F4 Then
            btnimprimir_Click(Nothing, Nothing)
        End If
    End Sub
End Class