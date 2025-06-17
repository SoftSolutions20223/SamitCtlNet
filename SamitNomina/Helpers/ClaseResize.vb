Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraTab
Imports DevExpress.XtraVerticalGrid
Imports DevExpress.XtraVerticalGrid.Rows
Imports SamitCtlNet

Public Class ClaseResize

    Dim HeightDiseño As Single = 720
    Dim WidthDiseño As Single = 1200
    Dim Fuente As Single = 9.25
    Dim Diferencia As Single
    Dim Fuentegeneral As Font
    Dim AnchoFuenteG As Decimal
    Private Shared Function GetHeights() As Single
        Dim desktopSize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize
        Dim heights As Single = desktopSize.Height
        Return heights
    End Function

    Private Shared Function GetWiths() As Single
        Dim desktopSize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize
        Dim widths As Single = desktopSize.Width
        Return widths
    End Function

    Public Sub ResizeForm(ObjForm As Form)
        'Dim heights As Single = GetHeights()
        'If heights > HeightDiseño Then
        '    Dim Dife As Single = heights - HeightDiseño
        '    Diferencia = Dife
        '    For Each c As Control In ObjForm.Controls
        '        VerificaControl(c)
        '        If c.HasChildren Then
        '            ResizeControlStoreSamit(c)
        '        Else
        '            Fuente = c.Font.Size
        '            If TypeName(c) = "SamitBusq" Or TypeName(c) = "SamitTexto" Then
        '                VerificaFontControl(c)
        '            End If
        '        End If
        '    Next
        '    ObjForm.Font = New Font("Tahoma", Fuente + (Diferencia / 235), System.Drawing.FontStyle.Regular)

        '    For Each c As Control In ObjForm.Controls
        '        If c.HasChildren Then
        '            RecorreHijos(c)
        '        Else
        '            RecorreHijos(c)
        '        End If
        '    Next
        'End If
    End Sub

    Private Sub VerificaControl(Control As Control)
        If TypeName(Control) = "XtraTabControl" Then
            Dim cosa As XtraTabControl = TryCast(Control, XtraTabControl)
            Fuente = cosa.AppearancePage.Header.Font.Size
            cosa.AppearancePage.Header.Font = New Font("Tahoma", Fuente + (Diferencia / 200), System.Drawing.FontStyle.Regular)
            Control.Font = cosa.AppearancePage.Header.Font
        End If

        If TypeName(Control) = "GroupControl" Then
            Dim cosa As GroupControl = TryCast(Control, GroupControl)
            Fuente = cosa.AppearanceCaption.Font.Size
            cosa.AppearanceCaption.Font = New Font("Tahoma", Fuente + (Diferencia / 160), System.Drawing.FontStyle.Bold)
            Control.Font = cosa.AppearanceCaption.Font
        End If

    End Sub
    Public Sub Resizamodales(ObjForm As Form, Porcentaje_Width As Single, Porcentaje_Height As Single)
        Dim heights As Single = Convert.ToInt32(GetHeights())
        Dim widts As Single = Convert.ToInt32(GetWiths())
        heights = (Porcentaje_Height * (heights - 20)) / 100
        widts = (Porcentaje_Width * (widts - 20)) / 100
        ObjForm.MaximumSize = New System.Drawing.Size(CInt(widts), CInt(heights))
        ObjForm.MinimumSize = New System.Drawing.Size(CInt(widts), CInt(heights))
        ObjForm.StartPosition = FormStartPosition.CenterScreen
    End Sub

    Public Sub VerificaFontControl(Control As Control)
        Control.Font = New Font("Tahoma", Fuente + (Diferencia / 235), System.Drawing.FontStyle.Regular)
        If TypeName(Control) = "SamitTexto" Then
            Dim cosa As SamitTexto = TryCast(Control, SamitTexto)
            Dim tamaño As Single = 0
            cosa.TipodeLetra = New Font("Tahoma", Fuente + (Diferencia / 235), System.Drawing.FontStyle.Regular)
            tamaño = cosa.AnchoLabel
            cosa.AnchoLabel = CInt(tamaño + (Diferencia / 10))
            cosa.Width = CInt(cosa.Width - (Diferencia / 10))
            Fuentegeneral = cosa.TipodeLetra
            AnchoFuenteG = cosa.AnchoLabel
        End If

        If TypeName(Control) = "SamitBusq" Then
            Dim cosa As SamitBusq = TryCast(Control, SamitBusq)
            Dim tamaño As Single = 0
            cosa.TipodeLetra = New Font("Tahoma", Fuente + (Diferencia / 235), System.Drawing.FontStyle.Regular)
            tamaño = cosa.AnchoLabel
            cosa.AnchoLabel = CInt(tamaño + (Diferencia / 10))
            cosa.Width = CInt(cosa.Width - (Diferencia / 10))
            Fuentegeneral = cosa.TipodeLetra
            AnchoFuenteG = cosa.AnchoLabel
        End If
    End Sub


    Public Sub Resizagrid(Contr As GridView)
        Dim Fuente_header As Single = Contr.Appearance.HeaderPanel.Font.Size
        Dim Fuente_Group As Single = Contr.Appearance.GroupPanel.Font.Size
        Dim Dife As Single = GetHeights() - HeightDiseño
        Diferencia = Dife
        Contr.Appearance.HeaderPanel.Font = New Font("Trebuchet MS", Fuente_header + (Diferencia / 200), System.Drawing.FontStyle.Bold)
        Contr.Appearance.Row.Font = New Font("Tahoma", Fuente_header + (Diferencia / 160), System.Drawing.FontStyle.Regular)
    End Sub
    Public Sub ResizaVgridCatgorias(Contr As VGridControl)
        Dim Fuente_header As Single = Contr.Font.Size
        Dim Dife As Single = GetHeights() - HeightDiseño
        Diferencia = Dife
        Contr.Appearance.RowHeaderPanel.Font = New Font("Trebuchet MS", Fuente_header + (Diferencia / 200), System.Drawing.FontStyle.Bold)
        Contr.Appearance.RecordValue.Font = New Font("Trebuchet MS", Fuente_header + (Diferencia / 200), System.Drawing.FontStyle.Bold)
    End Sub
    Public Sub ResizaVgridRows(Contr As EditorRow)
        Dim Fuente_header As Single = Contr.Appearance.Font.Size
        Dim Dife As Single = GetHeights() - HeightDiseño
        Diferencia = Dife
        Contr.Appearance.Font = New Font("Tahoma", Fuente_header + (Diferencia / 160), System.Drawing.FontStyle.Regular)
    End Sub
    Private Sub ResizeControlStoreSamit(objCtl As Control)
        If objCtl.HasChildren Then
            For Each cChildren As Control In objCtl.Controls
                If cChildren.HasChildren Then
                    ResizeControlStoreSamit(cChildren)
                Else
                    VerificaControl(cChildren)
                    Fuente = cChildren.Font.Size
                    If TypeName(cChildren) = "SamitBusq" Or TypeName(cChildren) = "SamitTexto" Then
                        VerificaFontControl(cChildren)
                    End If
                End If
            Next
            VerificaControl(objCtl)
            Fuente = objCtl.Font.Size
            If TypeName(objCtl) = "SamitBusq" Or TypeName(objCtl) = "SamitTexto" Then
                If TypeName(objCtl) = "SamitBusq" Or TypeName(objCtl) = "SamitTexto" Then
                    VerificaFontControl(objCtl)
                End If
            End If
        Else
            VerificaControl(objCtl)
            Fuente = objCtl.Font.Size
            If TypeName(objCtl) = "SamitBusq" Or TypeName(objCtl) = "SamitTexto" Then
                If TypeName(objCtl) = "SamitBusq" Or TypeName(objCtl) = "SamitTexto" Then
                    VerificaFontControl(objCtl)
                End If
            End If
        End If
    End Sub

    Private Sub RecorreHijos(objCtl As Control)
        If objCtl.HasChildren Then
            For Each cChildren As Control In objCtl.Controls
                If cChildren.HasChildren Then
                    RecorreHijos(cChildren)
                Else
                    Fuente = cChildren.Font.Size
                    If TypeName(cChildren) = "LabelControl" Then
                        Dim cosa As LabelControl = TryCast(cChildren, LabelControl)
                        cosa.Font = Fuentegeneral
                        cosa.Width = CInt(AnchoFuenteG)
                    End If
                End If
            Next
            Fuente = objCtl.Font.Size
            If TypeName(objCtl) = "LabelControl" Then
                Dim cosa As LabelControl = TryCast(objCtl, LabelControl)
                cosa.Font = Fuentegeneral
                cosa.Width = CInt(AnchoFuenteG)
            End If
        Else
            Fuente = objCtl.Font.Size
            If TypeName(objCtl) = "LabelControl" Then
                Dim cosa As LabelControl = TryCast(objCtl, LabelControl)
                cosa.Font = Fuentegeneral
                cosa.Width = CInt(AnchoFuenteG)
            End If
        End If
    End Sub
End Class
