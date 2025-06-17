<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmEnviarDian
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MetododePago = New SamitCtlNet.SamitBusq()
        Me.lblFecha = New DevExpress.XtraEditors.LabelControl()
        Me.dteFecha = New DevExpress.XtraEditors.DateEdit()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.btnHabilitar = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnEliminar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEnviar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.gcEmpleados = New DevExpress.XtraGrid.GridControl()
        Me.gvEmpleados = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.lblfechaini = New DevExpress.XtraEditors.LabelControl()
        Me.BtnExcell = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.dteFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.gcEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetododePago
        '
        Me.MetododePago.AlineacionTexto = SamitCtlNet.AlinearTexto.Centro
        Me.MetododePago.AlineacionTitulo = SamitCtlNet.AlinearTexto.Derecha
        Me.MetododePago.AltodelControl = 30
        Me.MetododePago.AnchoLabel = 90
        Me.MetododePago.AnchoTxt = 50
        Me.MetododePago.AutoCargarDatos = True
        Me.MetododePago.AutoSize = True
        Me.MetododePago.BackColor = System.Drawing.Color.Transparent
        Me.MetododePago.ColorFondo = System.Drawing.Color.Transparent
        Me.MetododePago.CondicionValida = ""
        Me.MetododePago.Conexion = SamitCtlNet.ConexionSAMIT.ConexModulo
        Me.MetododePago.ConsultaSQL = Nothing
        Me.MetododePago.EsObligatorio = False
        Me.MetododePago.FormatoNumero = Nothing
        Me.MetododePago.Location = New System.Drawing.Point(266, 0)
        Me.MetododePago.MaximoAncho = 0
        Me.MetododePago.MensajedeAyuda = Nothing
        Me.MetododePago.Name = "MetododePago"
        Me.MetododePago.Size = New System.Drawing.Size(869, 30)
        Me.MetododePago.SoloLectura = False
        Me.MetododePago.SoloNumeros = True
        Me.MetododePago.TabIndex = 121
        Me.MetododePago.TextodelControl = ""
        Me.MetododePago.TextoLabel = "Metodo Pago :"
        Me.MetododePago.TieneErrorControl = False
        Me.MetododePago.TipoBusqueda = SamitCtlNet.ModGeneral.TipoBusqueda.Ninguna
        Me.MetododePago.TipodeDatos = SamitCtlNet.TipodeDato.Ninguno
        Me.MetododePago.TipodeLetra = New System.Drawing.Font("Arial", 9.0!)
        Me.MetododePago.ValordelControl = ""
        Me.MetododePago.ValorMaximo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.MetododePago.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.MetododePago.ValorPredeterminado = Nothing
        '
        'lblFecha
        '
        Me.lblFecha.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Appearance.Options.UseFont = True
        Me.lblFecha.Appearance.Options.UseTextOptions = True
        Me.lblFecha.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblFecha.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblFecha.Location = New System.Drawing.Point(4, 2)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Padding = New System.Windows.Forms.Padding(2)
        Me.lblFecha.Size = New System.Drawing.Size(90, 26)
        Me.lblFecha.TabIndex = 128
        Me.lblFecha.Text = "Fecha Pagos :"
        '
        'dteFecha
        '
        Me.dteFecha.EditValue = Nothing
        Me.dteFecha.Location = New System.Drawing.Point(107, 5)
        Me.dteFecha.Name = "dteFecha"
        Me.dteFecha.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.dteFecha.Properties.Appearance.Options.UseFont = True
        Me.dteFecha.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.dteFecha.Properties.AppearanceDropDown.Options.UseFont = True
        Me.dteFecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteFecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteFecha.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.dteFecha.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dteFecha.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.dteFecha.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dteFecha.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.dteFecha.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.dteFecha.Size = New System.Drawing.Size(131, 20)
        Me.dteFecha.TabIndex = 119
        Me.dteFecha.TabStop = False
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.GroupControl1.CaptionImageOptions.Padding = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.GroupControl1.Controls.Add(Me.BtnExcell)
        Me.GroupControl1.Controls.Add(Me.btnHabilitar)
        Me.GroupControl1.Controls.Add(Me.BtnEliminar)
        Me.GroupControl1.Controls.Add(Me.btnEnviar)
        Me.GroupControl1.Controls.Add(Me.btnCancelar)
        Me.GroupControl1.Location = New System.Drawing.Point(1141, 4)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(88, 565)
        Me.GroupControl1.TabIndex = 126
        Me.GroupControl1.Text = "Opciones"
        '
        'btnHabilitar
        '
        Me.btnHabilitar.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnHabilitar.Appearance.Options.UseFont = True
        Me.btnHabilitar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnHabilitar.Location = New System.Drawing.Point(5, 182)
        Me.btnHabilitar.Name = "btnHabilitar"
        Me.btnHabilitar.Size = New System.Drawing.Size(78, 45)
        Me.btnHabilitar.TabIndex = 9
        Me.btnHabilitar.Text = "Habilitar"
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.BtnEliminar.Appearance.Options.UseFont = True
        Me.BtnEliminar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnEliminar.Location = New System.Drawing.Point(5, 79)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(78, 45)
        Me.BtnEliminar.TabIndex = 8
        Me.BtnEliminar.Text = "Eliminar"
        '
        'btnEnviar
        '
        Me.btnEnviar.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnEnviar.Appearance.Options.UseFont = True
        Me.btnEnviar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnEnviar.Location = New System.Drawing.Point(5, 28)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(78, 45)
        Me.btnEnviar.TabIndex = 6
        Me.btnEnviar.Text = "Enviar"
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnCancelar.Appearance.Options.UseFont = True
        Me.btnCancelar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnCancelar.Location = New System.Drawing.Point(5, 131)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(78, 45)
        Me.btnCancelar.TabIndex = 7
        Me.btnCancelar.Text = "Cancelar"
        '
        'gcEmpleados
        '
        Me.gcEmpleados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcEmpleados.Location = New System.Drawing.Point(6, 67)
        Me.gcEmpleados.MainView = Me.gvEmpleados
        Me.gcEmpleados.Name = "gcEmpleados"
        Me.gcEmpleados.Size = New System.Drawing.Size(1129, 502)
        Me.gcEmpleados.TabIndex = 125
        Me.gcEmpleados.TabStop = False
        Me.gcEmpleados.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvEmpleados})
        '
        'gvEmpleados
        '
        Me.gvEmpleados.GridControl = Me.gcEmpleados
        Me.gvEmpleados.Name = "gvEmpleados"
        Me.gvEmpleados.OptionsView.ShowGroupPanel = False
        '
        'lblfechaini
        '
        Me.lblfechaini.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblfechaini.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfechaini.Appearance.Options.UseFont = True
        Me.lblfechaini.Appearance.Options.UseTextOptions = True
        Me.lblfechaini.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.lblfechaini.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblfechaini.Location = New System.Drawing.Point(8, 34)
        Me.lblfechaini.Name = "lblfechaini"
        Me.lblfechaini.Padding = New System.Windows.Forms.Padding(2)
        Me.lblfechaini.Size = New System.Drawing.Size(1127, 26)
        Me.lblfechaini.TabIndex = 129
        '
        'BtnExcell
        '
        Me.BtnExcell.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnExcell.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.BtnExcell.Appearance.Options.UseFont = True
        Me.BtnExcell.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnExcell.Location = New System.Drawing.Point(5, 234)
        Me.BtnExcell.Name = "BtnExcell"
        Me.BtnExcell.Size = New System.Drawing.Size(78, 45)
        Me.BtnExcell.TabIndex = 10
        Me.BtnExcell.Text = "Excell"
        '
        'FrmEnviarDian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1234, 572)
        Me.Controls.Add(Me.lblfechaini)
        Me.Controls.Add(Me.MetododePago)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.dteFecha)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.gcEmpleados)
        Me.IconOptions.Image = My.Resources.Icon_Sin_fondo16
        Me.Name = "FrmEnviarDian"
        Me.Text = "Enviar Nomina"
        CType(Me.dteFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.gcEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetododePago As SamitCtlNet.SamitBusq
    Friend WithEvents lblFecha As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dteFecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents BtnEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEnviar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gcEmpleados As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvEmpleados As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lblfechaini As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnHabilitar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnExcell As DevExpress.XtraEditors.SimpleButton
End Class
