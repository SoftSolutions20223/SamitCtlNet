<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVerImagenes
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVerImagenes))
        Me.pcbImg = New DevExpress.XtraEditors.PictureEdit()
        Me.GaleriaFotos = New DevExpress.XtraBars.Ribbon.GalleryControl()
        Me.GalleryControlClient1 = New DevExpress.XtraBars.Ribbon.GalleryControlClient()
        Me.gbxOpciones = New System.Windows.Forms.GroupBox()
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.btnImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEliminaImg = New DevExpress.XtraEditors.SimpleButton()
        Me.ckbImgPredeterminada = New DevExpress.XtraEditors.CheckEdit()
        Me.SeparatorControl1 = New DevExpress.XtraEditors.SeparatorControl()
        CType(Me.pcbImg.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GaleriaFotos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GaleriaFotos.SuspendLayout()
        Me.gbxOpciones.SuspendLayout()
        CType(Me.ckbImgPredeterminada.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pcbImg
        '
        Me.pcbImg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pcbImg.Location = New System.Drawing.Point(12, 12)
        Me.pcbImg.Name = "pcbImg"
        Me.pcbImg.Properties.ReadOnly = True
        Me.pcbImg.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.pcbImg.Properties.ShowScrollBars = True
        Me.pcbImg.Properties.ShowZoomSubMenu = DevExpress.Utils.DefaultBoolean.[True]
        Me.pcbImg.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        Me.pcbImg.Size = New System.Drawing.Size(847, 413)
        Me.pcbImg.TabIndex = 25
        '
        'GaleriaFotos
        '
        Me.GaleriaFotos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GaleriaFotos.Controls.Add(Me.GalleryControlClient1)
        Me.GaleriaFotos.DesignGalleryGroupIndex = 0
        Me.GaleriaFotos.DesignGalleryItemIndex = 0
        '
        '
        '
        Me.GaleriaFotos.Location = New System.Drawing.Point(12, 432)
        Me.GaleriaFotos.Name = "GaleriaFotos"
        Me.GaleriaFotos.Size = New System.Drawing.Size(659, 134)
        Me.GaleriaFotos.TabIndex = 20
        Me.GaleriaFotos.Text = "GalleryControl1"
        '
        'GalleryControlClient1
        '
        Me.GalleryControlClient1.GalleryControl = Me.GaleriaFotos
        Me.GalleryControlClient1.Location = New System.Drawing.Point(2, 2)
        Me.GalleryControlClient1.Size = New System.Drawing.Size(639, 130)
        '
        'gbxOpciones
        '
        Me.gbxOpciones.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxOpciones.Controls.Add(Me.btnSalir)
        Me.gbxOpciones.Controls.Add(Me.btnImprimir)
        Me.gbxOpciones.Controls.Add(Me.btnEliminaImg)
        Me.gbxOpciones.Controls.Add(Me.ckbImgPredeterminada)
        Me.gbxOpciones.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.gbxOpciones.Location = New System.Drawing.Point(677, 426)
        Me.gbxOpciones.Name = "gbxOpciones"
        Me.gbxOpciones.Size = New System.Drawing.Size(182, 140)
        Me.gbxOpciones.TabIndex = 26
        Me.gbxOpciones.TabStop = False
        Me.gbxOpciones.Text = "Opciones"
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.btnSalir.Location = New System.Drawing.Point(6, 104)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(170, 29)
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.Text = "Salir"
        '
        'btnImprimir
        '
        Me.btnImprimir.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnImprimir.Appearance.Options.UseFont = True
        Me.btnImprimir.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.btnImprimir.Location = New System.Drawing.Point(6, 72)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(170, 29)
        Me.btnImprimir.TabIndex = 2
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.Visible = False
        '
        'btnEliminaImg
        '
        Me.btnEliminaImg.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnEliminaImg.Appearance.Options.UseFont = True
        Me.btnEliminaImg.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.btnEliminaImg.Location = New System.Drawing.Point(6, 40)
        Me.btnEliminaImg.Name = "btnEliminaImg"
        Me.btnEliminaImg.Size = New System.Drawing.Size(170, 29)
        Me.btnEliminaImg.TabIndex = 1
        Me.btnEliminaImg.Text = "Eliminar Imagen"
        '
        'ckbImgPredeterminada
        '
        Me.ckbImgPredeterminada.Location = New System.Drawing.Point(6, 18)
        Me.ckbImgPredeterminada.Name = "ckbImgPredeterminada"
        Me.ckbImgPredeterminada.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.ckbImgPredeterminada.Properties.Appearance.Options.UseFont = True
        Me.ckbImgPredeterminada.Properties.Caption = "Predeterminada"
        Me.ckbImgPredeterminada.Size = New System.Drawing.Size(170, 19)
        Me.ckbImgPredeterminada.TabIndex = 0
        '
        'SeparatorControl1
        '
        Me.SeparatorControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SeparatorControl1.Location = New System.Drawing.Point(12, 427)
        Me.SeparatorControl1.Name = "SeparatorControl1"
        Me.SeparatorControl1.Padding = New System.Windows.Forms.Padding(0)
        Me.SeparatorControl1.Size = New System.Drawing.Size(847, 3)
        Me.SeparatorControl1.TabIndex = 27
        '
        'FrmVerImagenes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 575)
        Me.Controls.Add(Me.SeparatorControl1)
        Me.Controls.Add(Me.gbxOpciones)
        Me.Controls.Add(Me.pcbImg)
        Me.Controls.Add(Me.GaleriaFotos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "FrmVerImagenes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Imagenes"
        CType(Me.pcbImg.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GaleriaFotos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GaleriaFotos.ResumeLayout(False)
        Me.gbxOpciones.ResumeLayout(False)
        CType(Me.ckbImgPredeterminada.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pcbImg As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents GaleriaFotos As DevExpress.XtraBars.Ribbon.GalleryControl
    Friend WithEvents GalleryControlClient1 As DevExpress.XtraBars.Ribbon.GalleryControlClient
    Friend WithEvents gbxOpciones As System.Windows.Forms.GroupBox
    Friend WithEvents btnEliminaImg As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ckbImgPredeterminada As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents btnImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SeparatorControl1 As DevExpress.XtraEditors.SeparatorControl
End Class
