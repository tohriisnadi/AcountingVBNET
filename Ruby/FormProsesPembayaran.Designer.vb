<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProsesPembayaran
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormProsesPembayaran))
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTotal = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTransport = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtdiscNominal = New DevExpress.XtraEditors.TextEdit()
        Me.txtDisc = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.cmbMetode = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDP = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSisa = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txtGrandtotal = New DevExpress.XtraEditors.TextEdit()
        Me.txtNota = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.tglKirim = New System.Windows.Forms.MaskedTextBox()
        Me.tglPakai = New System.Windows.Forms.MaskedTextBox()
        Me.tglAmbil = New System.Windows.Forms.MaskedTextBox()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTransport.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdiscNominal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDisc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbMetode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSisa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGrandtotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNota.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureEdit1
        '
        Me.PictureEdit1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureEdit1.EditValue = CType(resources.GetObject("PictureEdit1.EditValue"), Object)
        Me.PictureEdit1.Location = New System.Drawing.Point(0, 0)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.PictureEdit1.Size = New System.Drawing.Size(568, 53)
        Me.PictureEdit1.TabIndex = 141
        '
        'LabelControl21
        '
        Me.LabelControl21.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl21.Location = New System.Drawing.Point(21, 214)
        Me.LabelControl21.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(66, 20)
        Me.LabelControl21.TabIndex = 192
        Me.LabelControl21.Text = "Total (Rp)"
        '
        'txtTotal
        '
        Me.txtTotal.EditValue = "0"
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(21, 240)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.txtTotal.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Properties.Appearance.Options.UseBackColor = True
        Me.txtTotal.Properties.Appearance.Options.UseFont = True
        Me.txtTotal.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotal.Properties.AppearanceFocused.Options.UseTextOptions = True
        Me.txtTotal.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtTotal.Properties.Mask.EditMask = "n0"
        Me.txtTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTotal.Size = New System.Drawing.Size(252, 30)
        Me.txtTotal.TabIndex = 191
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(21, 275)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(135, 20)
        Me.LabelControl1.TabIndex = 194
        Me.LabelControl1.Text = "Biaya Transport (Rp)"
        '
        'txtTransport
        '
        Me.txtTransport.EditValue = "0"
        Me.txtTransport.Location = New System.Drawing.Point(21, 301)
        Me.txtTransport.Name = "txtTransport"
        Me.txtTransport.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.txtTransport.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransport.Properties.Appearance.Options.UseBackColor = True
        Me.txtTransport.Properties.Appearance.Options.UseFont = True
        Me.txtTransport.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTransport.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTransport.Properties.AppearanceFocused.Options.UseTextOptions = True
        Me.txtTransport.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTransport.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtTransport.Properties.Mask.EditMask = "n0"
        Me.txtTransport.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTransport.Size = New System.Drawing.Size(251, 30)
        Me.txtTransport.TabIndex = 193
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(88, 337)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(121, 20)
        Me.LabelControl2.TabIndex = 198
        Me.LabelControl2.Text = "Nominal Disc (Rp)"
        '
        'txtdiscNominal
        '
        Me.txtdiscNominal.EditValue = "0"
        Me.txtdiscNominal.Location = New System.Drawing.Point(88, 363)
        Me.txtdiscNominal.Name = "txtdiscNominal"
        Me.txtdiscNominal.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.txtdiscNominal.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdiscNominal.Properties.Appearance.Options.UseBackColor = True
        Me.txtdiscNominal.Properties.Appearance.Options.UseFont = True
        Me.txtdiscNominal.Properties.Appearance.Options.UseTextOptions = True
        Me.txtdiscNominal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtdiscNominal.Properties.AppearanceFocused.Options.UseTextOptions = True
        Me.txtdiscNominal.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtdiscNominal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtdiscNominal.Properties.Mask.EditMask = "n0"
        Me.txtdiscNominal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtdiscNominal.Size = New System.Drawing.Size(185, 30)
        Me.txtdiscNominal.TabIndex = 197
        '
        'txtDisc
        '
        Me.txtDisc.EditValue = "0"
        Me.txtDisc.Location = New System.Drawing.Point(21, 363)
        Me.txtDisc.Name = "txtDisc"
        Me.txtDisc.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.txtDisc.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDisc.Properties.Appearance.Options.UseBackColor = True
        Me.txtDisc.Properties.Appearance.Options.UseFont = True
        Me.txtDisc.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDisc.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtDisc.Properties.AppearanceFocused.Options.UseTextOptions = True
        Me.txtDisc.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtDisc.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtDisc.Size = New System.Drawing.Size(61, 30)
        Me.txtDisc.TabIndex = 196
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(21, 337)
        Me.LabelControl3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(54, 20)
        Me.LabelControl3.TabIndex = 195
        Me.LabelControl3.Text = "Disc (%)"
        '
        'cmbMetode
        '
        Me.cmbMetode.Location = New System.Drawing.Point(9, 31)
        Me.cmbMetode.Name = "cmbMetode"
        Me.cmbMetode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMetode.Properties.Appearance.Options.UseFont = True
        Me.cmbMetode.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmbMetode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbMetode.Properties.Items.AddRange(New Object() {"Tunai", "Kredit"})
        Me.cmbMetode.Size = New System.Drawing.Size(250, 30)
        Me.cmbMetode.TabIndex = 209
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(9, 5)
        Me.LabelControl4.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(52, 20)
        Me.LabelControl4.TabIndex = 210
        Me.LabelControl4.Text = "Metode"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(11, 66)
        Me.LabelControl5.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(51, 20)
        Me.LabelControl5.TabIndex = 212
        Me.LabelControl5.Text = "DP (Rp)"
        '
        'txtDP
        '
        Me.txtDP.EditValue = "0"
        Me.txtDP.Enabled = False
        Me.txtDP.Location = New System.Drawing.Point(9, 92)
        Me.txtDP.Name = "txtDP"
        Me.txtDP.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.txtDP.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDP.Properties.Appearance.Options.UseBackColor = True
        Me.txtDP.Properties.Appearance.Options.UseFont = True
        Me.txtDP.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDP.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtDP.Properties.AppearanceFocused.Options.UseTextOptions = True
        Me.txtDP.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtDP.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtDP.Properties.Mask.EditMask = "n0"
        Me.txtDP.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtDP.Size = New System.Drawing.Size(248, 30)
        Me.txtDP.TabIndex = 211
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Location = New System.Drawing.Point(11, 128)
        Me.LabelControl6.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(58, 20)
        Me.LabelControl6.TabIndex = 214
        Me.LabelControl6.Text = "Sisa (Rp)"
        '
        'txtSisa
        '
        Me.txtSisa.EditValue = "0"
        Me.txtSisa.Enabled = False
        Me.txtSisa.Location = New System.Drawing.Point(9, 154)
        Me.txtSisa.Name = "txtSisa"
        Me.txtSisa.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.txtSisa.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSisa.Properties.Appearance.Options.UseBackColor = True
        Me.txtSisa.Properties.Appearance.Options.UseFont = True
        Me.txtSisa.Properties.Appearance.Options.UseTextOptions = True
        Me.txtSisa.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtSisa.Properties.AppearanceFocused.Options.UseTextOptions = True
        Me.txtSisa.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtSisa.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtSisa.Properties.Mask.EditMask = "n0"
        Me.txtSisa.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtSisa.Size = New System.Drawing.Size(250, 30)
        Me.txtSisa.TabIndex = 213
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Location = New System.Drawing.Point(11, 190)
        Me.LabelControl7.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(143, 20)
        Me.LabelControl7.TabIndex = 215
        Me.LabelControl7.Text = "Tanggal Jatuh Tempo"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Location = New System.Drawing.Point(21, 398)
        Me.LabelControl8.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(71, 20)
        Me.LabelControl8.TabIndex = 217
        Me.LabelControl8.Text = "Grandtotal"
        '
        'txtGrandtotal
        '
        Me.txtGrandtotal.EditValue = "0"
        Me.txtGrandtotal.Enabled = False
        Me.txtGrandtotal.Location = New System.Drawing.Point(21, 425)
        Me.txtGrandtotal.Name = "txtGrandtotal"
        Me.txtGrandtotal.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.txtGrandtotal.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGrandtotal.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.txtGrandtotal.Properties.Appearance.Options.UseBackColor = True
        Me.txtGrandtotal.Properties.Appearance.Options.UseFont = True
        Me.txtGrandtotal.Properties.Appearance.Options.UseForeColor = True
        Me.txtGrandtotal.Properties.Appearance.Options.UseTextOptions = True
        Me.txtGrandtotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtGrandtotal.Properties.AppearanceFocused.Options.UseTextOptions = True
        Me.txtGrandtotal.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtGrandtotal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtGrandtotal.Properties.Mask.EditMask = "n0"
        Me.txtGrandtotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtGrandtotal.Size = New System.Drawing.Size(250, 30)
        Me.txtGrandtotal.TabIndex = 218
        '
        'txtNota
        '
        Me.txtNota.EditValue = ""
        Me.txtNota.Location = New System.Drawing.Point(20, 92)
        Me.txtNota.Name = "txtNota"
        Me.txtNota.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.txtNota.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNota.Properties.Appearance.Options.UseBackColor = True
        Me.txtNota.Properties.Appearance.Options.UseFont = True
        Me.txtNota.Properties.Appearance.Options.UseTextOptions = True
        Me.txtNota.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtNota.Properties.AppearanceFocused.Options.UseTextOptions = True
        Me.txtNota.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtNota.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtNota.Size = New System.Drawing.Size(251, 30)
        Me.txtNota.TabIndex = 191
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Location = New System.Drawing.Point(20, 66)
        Me.LabelControl9.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(60, 20)
        Me.LabelControl9.TabIndex = 192
        Me.LabelControl9.Text = "No. Nota"
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskedTextBox1.Location = New System.Drawing.Point(9, 216)
        Me.MaskedTextBox1.Mask = "00/00/0000"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(250, 29)
        Me.MaskedTextBox1.TabIndex = 219
        Me.MaskedTextBox1.ValidatingType = GetType(Date)
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Location = New System.Drawing.Point(18, 128)
        Me.LabelControl10.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(106, 20)
        Me.LabelControl10.TabIndex = 215
        Me.LabelControl10.Text = "Dikirim Tanggal"
        '
        'tglKirim
        '
        Me.tglKirim.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tglKirim.Location = New System.Drawing.Point(20, 154)
        Me.tglKirim.Mask = "00/00/0000"
        Me.tglKirim.Name = "tglKirim"
        Me.tglKirim.Size = New System.Drawing.Size(250, 29)
        Me.tglKirim.TabIndex = 219
        Me.tglKirim.ValidatingType = GetType(Date)
        '
        'tglPakai
        '
        Me.tglPakai.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tglPakai.Location = New System.Drawing.Point(295, 93)
        Me.tglPakai.Mask = "00/00/0000"
        Me.tglPakai.Name = "tglPakai"
        Me.tglPakai.Size = New System.Drawing.Size(250, 29)
        Me.tglPakai.TabIndex = 219
        Me.tglPakai.ValidatingType = GetType(Date)
        '
        'tglAmbil
        '
        Me.tglAmbil.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tglAmbil.Location = New System.Drawing.Point(295, 154)
        Me.tglAmbil.Mask = "00/00/0000"
        Me.tglAmbil.Name = "tglAmbil"
        Me.tglAmbil.Size = New System.Drawing.Size(250, 29)
        Me.tglAmbil.TabIndex = 219
        Me.tglAmbil.ValidatingType = GetType(Date)
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl11.Location = New System.Drawing.Point(293, 67)
        Me.LabelControl11.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(109, 20)
        Me.LabelControl11.TabIndex = 215
        Me.LabelControl11.Text = "Dipakai Tanggal"
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl12.Location = New System.Drawing.Point(293, 128)
        Me.LabelControl12.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(111, 20)
        Me.LabelControl12.TabIndex = 215
        Me.LabelControl12.Text = "Diambil Tanggal"
        '
        'PanelControl1
        '
        Me.PanelControl1.Location = New System.Drawing.Point(12, 59)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(546, 135)
        Me.PanelControl1.TabIndex = 220
        '
        'PanelControl2
        '
        Me.PanelControl2.Location = New System.Drawing.Point(12, 209)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(270, 261)
        Me.PanelControl2.TabIndex = 221
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.cmbMetode)
        Me.PanelControl3.Controls.Add(Me.LabelControl4)
        Me.PanelControl3.Controls.Add(Me.txtDP)
        Me.PanelControl3.Controls.Add(Me.MaskedTextBox1)
        Me.PanelControl3.Controls.Add(Me.LabelControl5)
        Me.PanelControl3.Controls.Add(Me.txtSisa)
        Me.PanelControl3.Controls.Add(Me.LabelControl6)
        Me.PanelControl3.Controls.Add(Me.LabelControl7)
        Me.PanelControl3.Location = New System.Drawing.Point(288, 209)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(270, 261)
        Me.PanelControl3.TabIndex = 221
        '
        'FormProsesPembayaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 482)
        Me.Controls.Add(Me.tglAmbil)
        Me.Controls.Add(Me.tglPakai)
        Me.Controls.Add(Me.tglKirim)
        Me.Controls.Add(Me.txtGrandtotal)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.LabelControl12)
        Me.Controls.Add(Me.LabelControl11)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtdiscNominal)
        Me.Controls.Add(Me.txtDisc)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtTransport)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.txtNota)
        Me.Controls.Add(Me.LabelControl21)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormProsesPembayaran"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pembayaran"
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTransport.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdiscNominal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDisc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbMetode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSisa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGrandtotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNota.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.PanelControl3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTransport As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtdiscNominal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDisc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbMetode As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDP As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSisa As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtGrandtotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNota As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents MaskedTextBox1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tglKirim As System.Windows.Forms.MaskedTextBox
    Friend WithEvents tglPakai As System.Windows.Forms.MaskedTextBox
    Friend WithEvents tglAmbil As System.Windows.Forms.MaskedTextBox
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
End Class
