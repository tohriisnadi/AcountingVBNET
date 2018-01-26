<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSettingSistem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSettingSistem))
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.cbAkunTrans = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.cbAkunPiutang = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.cbAkunTransport = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cbAkunPerawatan = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cbAkunPengembangan = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txtPsPengembangan = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPsPerawatan = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPsTransport = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.btnExit = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbAkunTrans.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbAkunPiutang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.cbAkunTransport.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbAkunPerawatan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbAkunPengembangan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPsPengembangan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPsPerawatan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPsTransport.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureEdit1
        '
        Me.PictureEdit1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureEdit1.EditValue = CType(resources.GetObject("PictureEdit1.EditValue"), Object)
        Me.PictureEdit1.Location = New System.Drawing.Point(0, 0)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.PictureEdit1.Size = New System.Drawing.Size(636, 70)
        Me.PictureEdit1.TabIndex = 143
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(13, 81)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(135, 13)
        Me.LabelControl2.TabIndex = 150
        Me.LabelControl2.Text = "Akun Transaksi Persewaan"
        '
        'cbAkunTrans
        '
        Me.cbAkunTrans.Location = New System.Drawing.Point(167, 77)
        Me.cbAkunTrans.Name = "cbAkunTrans"
        Me.cbAkunTrans.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAkunTrans.Properties.Appearance.Options.UseFont = True
        Me.cbAkunTrans.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cbAkunTrans.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbAkunTrans.Size = New System.Drawing.Size(457, 22)
        Me.cbAkunTrans.TabIndex = 149
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(13, 118)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(70, 13)
        Me.LabelControl1.TabIndex = 152
        Me.LabelControl1.Text = "Akun Piutang"
        '
        'cbAkunPiutang
        '
        Me.cbAkunPiutang.Location = New System.Drawing.Point(167, 114)
        Me.cbAkunPiutang.Name = "cbAkunPiutang"
        Me.cbAkunPiutang.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAkunPiutang.Properties.Appearance.Options.UseFont = True
        Me.cbAkunPiutang.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cbAkunPiutang.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbAkunPiutang.Size = New System.Drawing.Size(457, 22)
        Me.cbAkunPiutang.TabIndex = 151
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.cbAkunTransport)
        Me.GroupControl1.Controls.Add(Me.cbAkunPerawatan)
        Me.GroupControl1.Controls.Add(Me.cbAkunPengembangan)
        Me.GroupControl1.Controls.Add(Me.txtPsPengembangan)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.LabelControl7)
        Me.GroupControl1.Controls.Add(Me.txtPsPerawatan)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.txtPsTransport)
        Me.GroupControl1.Controls.Add(Me.LabelControl10)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Location = New System.Drawing.Point(13, 153)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(612, 146)
        Me.GroupControl1.TabIndex = 202
        Me.GroupControl1.Text = "Komponen Biaya Pendapatan"
        '
        'cbAkunTransport
        '
        Me.cbAkunTransport.Location = New System.Drawing.Point(150, 29)
        Me.cbAkunTransport.Name = "cbAkunTransport"
        Me.cbAkunTransport.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAkunTransport.Properties.Appearance.Options.UseFont = True
        Me.cbAkunTransport.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cbAkunTransport.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbAkunTransport.Size = New System.Drawing.Size(260, 22)
        Me.cbAkunTransport.TabIndex = 176
        '
        'cbAkunPerawatan
        '
        Me.cbAkunPerawatan.Location = New System.Drawing.Point(150, 66)
        Me.cbAkunPerawatan.Name = "cbAkunPerawatan"
        Me.cbAkunPerawatan.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAkunPerawatan.Properties.Appearance.Options.UseFont = True
        Me.cbAkunPerawatan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cbAkunPerawatan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbAkunPerawatan.Size = New System.Drawing.Size(260, 22)
        Me.cbAkunPerawatan.TabIndex = 175
        '
        'cbAkunPengembangan
        '
        Me.cbAkunPengembangan.Location = New System.Drawing.Point(150, 103)
        Me.cbAkunPengembangan.Name = "cbAkunPengembangan"
        Me.cbAkunPengembangan.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAkunPengembangan.Properties.Appearance.Options.UseFont = True
        Me.cbAkunPengembangan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cbAkunPengembangan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbAkunPengembangan.Size = New System.Drawing.Size(260, 22)
        Me.cbAkunPengembangan.TabIndex = 174
        '
        'txtPsPengembangan
        '
        Me.txtPsPengembangan.Location = New System.Drawing.Point(494, 103)
        Me.txtPsPengembangan.Name = "txtPsPengembangan"
        Me.txtPsPengembangan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtPsPengembangan.Size = New System.Drawing.Size(101, 22)
        Me.txtPsPengembangan.TabIndex = 173
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.LabelControl6.Location = New System.Drawing.Point(432, 107)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(55, 13)
        Me.LabelControl6.TabIndex = 171
        Me.LabelControl6.Text = "Persentase"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.LabelControl7.Location = New System.Drawing.Point(14, 107)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(111, 13)
        Me.LabelControl7.TabIndex = 170
        Me.LabelControl7.Text = "Biaya Pengembangan"
        '
        'txtPsPerawatan
        '
        Me.txtPsPerawatan.Location = New System.Drawing.Point(494, 66)
        Me.txtPsPerawatan.Name = "txtPsPerawatan"
        Me.txtPsPerawatan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtPsPerawatan.Size = New System.Drawing.Size(101, 22)
        Me.txtPsPerawatan.TabIndex = 169
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.LabelControl4.Location = New System.Drawing.Point(432, 70)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(55, 13)
        Me.LabelControl4.TabIndex = 167
        Me.LabelControl4.Text = "Persentase"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.LabelControl5.Location = New System.Drawing.Point(14, 70)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(84, 13)
        Me.LabelControl5.TabIndex = 166
        Me.LabelControl5.Text = "Biaya Perawatan"
        '
        'txtPsTransport
        '
        Me.txtPsTransport.Location = New System.Drawing.Point(494, 29)
        Me.txtPsTransport.Name = "txtPsTransport"
        Me.txtPsTransport.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtPsTransport.Size = New System.Drawing.Size(101, 22)
        Me.txtPsTransport.TabIndex = 165
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.LabelControl10.Location = New System.Drawing.Point(432, 33)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(55, 13)
        Me.LabelControl10.TabIndex = 158
        Me.LabelControl10.Text = "Persentase"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.LabelControl3.Location = New System.Drawing.Point(14, 33)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(79, 13)
        Me.LabelControl3.TabIndex = 156
        Me.LabelControl3.Text = "Biaya Transport"
        '
        'btnExit
        '
        Me.btnExit.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Appearance.Options.UseFont = True
        Me.btnExit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnExit.Location = New System.Drawing.Point(547, 311)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(78, 25)
        Me.btnExit.TabIndex = 204
        Me.btnExit.Text = "Tutup"
        '
        'btnAdd
        '
        Me.btnAdd.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Appearance.Options.UseFont = True
        Me.btnAdd.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnAdd.Location = New System.Drawing.Point(456, 311)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(82, 25)
        Me.btnAdd.TabIndex = 203
        Me.btnAdd.Text = "Simpan"
        '
        'FormSettingSistem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 347)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.cbAkunPiutang)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.cbAkunTrans)
        Me.Controls.Add(Me.PictureEdit1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormSettingSistem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Setting Sistem"
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbAkunTrans.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbAkunPiutang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.cbAkunTransport.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbAkunPerawatan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbAkunPengembangan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPsPengembangan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPsPerawatan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPsTransport.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbAkunTrans As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbAkunPiutang As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtPsPengembangan As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPsPerawatan As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPsTransport As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbAkunTransport As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cbAkunPerawatan As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cbAkunPengembangan As DevExpress.XtraEditors.ComboBoxEdit
End Class
