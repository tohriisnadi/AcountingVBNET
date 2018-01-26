<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAddTemplateTransaksi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAddTemplateTransaksi))
        Me.btnExit = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.cbDebet = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.cbKredit = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txtNamaTrans = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbDebet.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbKredit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNamaTrans.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Appearance.Options.UseFont = True
        Me.btnExit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnExit.Location = New System.Drawing.Point(325, 234)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(78, 25)
        Me.btnExit.TabIndex = 152
        Me.btnExit.Text = "Tutup"
        '
        'btnAdd
        '
        Me.btnAdd.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Appearance.Options.UseFont = True
        Me.btnAdd.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnAdd.Location = New System.Drawing.Point(237, 234)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(82, 25)
        Me.btnAdd.TabIndex = 151
        Me.btnAdd.Text = "Simpan"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.LabelControl1.Location = New System.Drawing.Point(13, 69)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(93, 17)
        Me.LabelControl1.TabIndex = 150
        Me.LabelControl1.Text = "Nama Transaksi"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.LabelControl2.Location = New System.Drawing.Point(13, 120)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(67, 17)
        Me.LabelControl2.TabIndex = 148
        Me.LabelControl2.Text = "Akun Debet"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureEdit1.EditValue = CType(resources.GetObject("PictureEdit1.EditValue"), Object)
        Me.PictureEdit1.Location = New System.Drawing.Point(0, 0)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.PictureEdit1.Size = New System.Drawing.Size(432, 50)
        Me.PictureEdit1.TabIndex = 147
        '
        'cbDebet
        '
        Me.cbDebet.Location = New System.Drawing.Point(13, 139)
        Me.cbDebet.Name = "cbDebet"
        Me.cbDebet.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.cbDebet.Properties.Appearance.Options.UseFont = True
        Me.cbDebet.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cbDebet.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbDebet.Size = New System.Drawing.Size(390, 26)
        Me.cbDebet.TabIndex = 146
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.LabelControl3.Location = New System.Drawing.Point(13, 171)
        Me.LabelControl3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(67, 17)
        Me.LabelControl3.TabIndex = 154
        Me.LabelControl3.Text = "Akun Kredit"
        '
        'cbKredit
        '
        Me.cbKredit.Location = New System.Drawing.Point(13, 190)
        Me.cbKredit.Name = "cbKredit"
        Me.cbKredit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.cbKredit.Properties.Appearance.Options.UseFont = True
        Me.cbKredit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cbKredit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbKredit.Size = New System.Drawing.Size(390, 26)
        Me.cbKredit.TabIndex = 153
        '
        'txtNamaTrans
        '
        Me.txtNamaTrans.Location = New System.Drawing.Point(13, 88)
        Me.txtNamaTrans.Name = "txtNamaTrans"
        Me.txtNamaTrans.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.txtNamaTrans.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtNamaTrans.Properties.Appearance.Options.UseBackColor = True
        Me.txtNamaTrans.Properties.Appearance.Options.UseFont = True
        Me.txtNamaTrans.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtNamaTrans.Size = New System.Drawing.Size(390, 26)
        Me.txtNamaTrans.TabIndex = 149
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(410, 92)
        Me.LabelControl4.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(5, 13)
        Me.LabelControl4.TabIndex = 150
        Me.LabelControl4.Text = "*"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(410, 146)
        Me.LabelControl5.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(5, 13)
        Me.LabelControl5.TabIndex = 150
        Me.LabelControl5.Text = "*"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Location = New System.Drawing.Point(410, 197)
        Me.LabelControl6.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(5, 13)
        Me.LabelControl6.TabIndex = 150
        Me.LabelControl6.Text = "*"
        '
        'FormAddTemplateTransaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 276)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.cbKredit)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Controls.Add(Me.cbDebet)
        Me.Controls.Add(Me.txtNamaTrans)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormAddTemplateTransaksi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tambah Template Transaksi"
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbDebet.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbKredit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNamaTrans.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents cbDebet As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbKredit As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtNamaTrans As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
End Class
