<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTotalPenerimaan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTotalPenerimaan))
        Me.RadioGroup1 = New DevExpress.XtraEditors.RadioGroup()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.txtKeterangan = New DevExpress.XtraEditors.TextEdit()
        Me.btnExit = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTglNota = New System.Windows.Forms.MaskedTextBox()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTotalPenerimaan = New DevExpress.XtraEditors.TextEdit()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKeterangan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtTotalPenerimaan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadioGroup1
        '
        Me.RadioGroup1.Location = New System.Drawing.Point(131, 104)
        Me.RadioGroup1.Name = "RadioGroup1"
        Me.RadioGroup1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("Tunai", "Tunai"), New DevExpress.XtraEditors.Controls.RadioGroupItem("Kredit", "Kredit")})
        Me.RadioGroup1.Size = New System.Drawing.Size(277, 61)
        Me.RadioGroup1.TabIndex = 332
        '
        'PictureEdit1
        '
        Me.PictureEdit1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureEdit1.EditValue = CType(resources.GetObject("PictureEdit1.EditValue"), Object)
        Me.PictureEdit1.Location = New System.Drawing.Point(0, 0)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.PictureEdit1.Size = New System.Drawing.Size(428, 66)
        Me.PictureEdit1.TabIndex = 196
        '
        'txtKeterangan
        '
        Me.txtKeterangan.Location = New System.Drawing.Point(131, 183)
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.txtKeterangan.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKeterangan.Properties.Appearance.Options.UseBackColor = True
        Me.txtKeterangan.Properties.Appearance.Options.UseFont = True
        Me.txtKeterangan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtKeterangan.Size = New System.Drawing.Size(277, 26)
        Me.txtKeterangan.TabIndex = 331
        '
        'btnExit
        '
        Me.btnExit.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Appearance.Options.UseFont = True
        Me.btnExit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnExit.Location = New System.Drawing.Point(350, 313)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(78, 25)
        Me.btnExit.TabIndex = 199
        Me.btnExit.Text = "Tutup"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(15, 187)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(67, 17)
        Me.LabelControl1.TabIndex = 330
        Me.LabelControl1.Text = "Keterangan"
        '
        'txtTglNota
        '
        Me.txtTglNota.AllowDrop = True
        Me.txtTglNota.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTglNota.Location = New System.Drawing.Point(131, 58)
        Me.txtTglNota.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTglNota.Mask = "00/00/0000"
        Me.txtTglNota.Name = "txtTglNota"
        Me.txtTglNota.Size = New System.Drawing.Size(277, 25)
        Me.txtTglNota.TabIndex = 329
        Me.txtTglNota.ValidatingType = GetType(Date)
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl13.Location = New System.Drawing.Point(15, 104)
        Me.LabelControl13.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(72, 17)
        Me.LabelControl13.TabIndex = 193
        Me.LabelControl13.Text = "Pembayaran"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.RadioGroup1)
        Me.PanelControl1.Controls.Add(Me.txtKeterangan)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.txtTglNota)
        Me.PanelControl1.Controls.Add(Me.LabelControl13)
        Me.PanelControl1.Controls.Add(Me.LabelControl14)
        Me.PanelControl1.Controls.Add(Me.LabelControl4)
        Me.PanelControl1.Controls.Add(Me.txtTotalPenerimaan)
        Me.PanelControl1.Location = New System.Drawing.Point(10, 74)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(420, 233)
        Me.PanelControl1.TabIndex = 197
        '
        'LabelControl14
        '
        Me.LabelControl14.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl14.Location = New System.Drawing.Point(15, 61)
        Me.LabelControl14.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(80, 17)
        Me.LabelControl14.TabIndex = 191
        Me.LabelControl14.Text = "Tanggal Nota"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(15, 16)
        Me.LabelControl4.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(101, 17)
        Me.LabelControl4.TabIndex = 189
        Me.LabelControl4.Text = "Total Penerimaan"
        '
        'txtTotalPenerimaan
        '
        Me.txtTotalPenerimaan.Location = New System.Drawing.Point(131, 12)
        Me.txtTotalPenerimaan.Name = "txtTotalPenerimaan"
        Me.txtTotalPenerimaan.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.txtTotalPenerimaan.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalPenerimaan.Properties.Appearance.Options.UseBackColor = True
        Me.txtTotalPenerimaan.Properties.Appearance.Options.UseFont = True
        Me.txtTotalPenerimaan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtTotalPenerimaan.Size = New System.Drawing.Size(277, 26)
        Me.txtTotalPenerimaan.TabIndex = 188
        '
        'btnAdd
        '
        Me.btnAdd.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Appearance.Options.UseFont = True
        Me.btnAdd.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnAdd.Location = New System.Drawing.Point(249, 313)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(82, 25)
        Me.btnAdd.TabIndex = 198
        Me.btnAdd.Text = "Simpan"
        '
        'FormTotalPenerimaan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 341)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.btnAdd)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormTotalPenerimaan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Total Penerimaan"
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKeterangan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txtTotalPenerimaan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadioGroup1 As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents txtKeterangan As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTglNota As System.Windows.Forms.MaskedTextBox
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTotalPenerimaan As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
End Class
