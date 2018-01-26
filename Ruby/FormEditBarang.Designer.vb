<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEditBarang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEditBarang))
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.txtStok = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.txtStokMin = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.txtStokMaks = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.btnExit = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtHargaBeli = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSatuan = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.cbJenisBarang = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNamaBarang = New DevExpress.XtraEditors.TextEdit()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        CType(Me.txtStok.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStokMin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStokMaks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHargaBeli.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSatuan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbJenisBarang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNamaBarang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(387, 402)
        Me.LabelControl5.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(5, 17)
        Me.LabelControl5.TabIndex = 204
        Me.LabelControl5.Text = "*"
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Location = New System.Drawing.Point(387, 351)
        Me.LabelControl10.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(5, 17)
        Me.LabelControl10.TabIndex = 205
        Me.LabelControl10.Text = "*"
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl11.Location = New System.Drawing.Point(387, 300)
        Me.LabelControl11.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(5, 17)
        Me.LabelControl11.TabIndex = 206
        Me.LabelControl11.Text = "*"
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl12.Location = New System.Drawing.Point(13, 375)
        Me.LabelControl12.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(26, 17)
        Me.LabelControl12.TabIndex = 203
        Me.LabelControl12.Text = "Stok"
        '
        'txtStok
        '
        Me.txtStok.Location = New System.Drawing.Point(11, 398)
        Me.txtStok.Name = "txtStok"
        Me.txtStok.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.txtStok.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStok.Properties.Appearance.Options.UseBackColor = True
        Me.txtStok.Properties.Appearance.Options.UseFont = True
        Me.txtStok.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtStok.Size = New System.Drawing.Size(369, 26)
        Me.txtStok.TabIndex = 202
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl13.Location = New System.Drawing.Point(11, 328)
        Me.LabelControl13.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(75, 17)
        Me.LabelControl13.TabIndex = 201
        Me.LabelControl13.Text = "Stok Minimal"
        '
        'txtStokMin
        '
        Me.txtStokMin.Location = New System.Drawing.Point(11, 347)
        Me.txtStokMin.Name = "txtStokMin"
        Me.txtStokMin.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.txtStokMin.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStokMin.Properties.Appearance.Options.UseBackColor = True
        Me.txtStokMin.Properties.Appearance.Options.UseFont = True
        Me.txtStokMin.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtStokMin.Size = New System.Drawing.Size(369, 26)
        Me.txtStokMin.TabIndex = 200
        '
        'LabelControl14
        '
        Me.LabelControl14.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl14.Location = New System.Drawing.Point(11, 277)
        Me.LabelControl14.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(84, 17)
        Me.LabelControl14.TabIndex = 199
        Me.LabelControl14.Text = "Stok Maksimal"
        '
        'txtStokMaks
        '
        Me.txtStokMaks.Location = New System.Drawing.Point(11, 296)
        Me.txtStokMaks.Name = "txtStokMaks"
        Me.txtStokMaks.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.txtStokMaks.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStokMaks.Properties.Appearance.Options.UseBackColor = True
        Me.txtStokMaks.Properties.Appearance.Options.UseFont = True
        Me.txtStokMaks.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtStokMaks.Size = New System.Drawing.Size(369, 26)
        Me.txtStokMaks.TabIndex = 198
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Location = New System.Drawing.Point(388, 246)
        Me.LabelControl9.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(5, 17)
        Me.LabelControl9.TabIndex = 195
        Me.LabelControl9.Text = "*"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Location = New System.Drawing.Point(388, 195)
        Me.LabelControl8.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(5, 17)
        Me.LabelControl8.TabIndex = 196
        Me.LabelControl8.Text = "*"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Location = New System.Drawing.Point(388, 144)
        Me.LabelControl7.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(5, 17)
        Me.LabelControl7.TabIndex = 197
        Me.LabelControl7.Text = "*"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Location = New System.Drawing.Point(388, 93)
        Me.LabelControl6.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(5, 17)
        Me.LabelControl6.TabIndex = 194
        Me.LabelControl6.Text = "*"
        '
        'btnExit
        '
        Me.btnExit.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Appearance.Options.UseFont = True
        Me.btnExit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnExit.Location = New System.Drawing.Point(302, 442)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(78, 25)
        Me.btnExit.TabIndex = 193
        Me.btnExit.Text = "Tutup"
        '
        'btnAdd
        '
        Me.btnAdd.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Appearance.Options.UseFont = True
        Me.btnAdd.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnAdd.Location = New System.Drawing.Point(214, 442)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(82, 25)
        Me.btnAdd.TabIndex = 192
        Me.btnAdd.Text = "Simpan"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(12, 223)
        Me.LabelControl4.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(60, 17)
        Me.LabelControl4.TabIndex = 191
        Me.LabelControl4.Text = "Harga Beli"
        '
        'txtHargaBeli
        '
        Me.txtHargaBeli.Location = New System.Drawing.Point(12, 242)
        Me.txtHargaBeli.Name = "txtHargaBeli"
        Me.txtHargaBeli.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.txtHargaBeli.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHargaBeli.Properties.Appearance.Options.UseBackColor = True
        Me.txtHargaBeli.Properties.Appearance.Options.UseFont = True
        Me.txtHargaBeli.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtHargaBeli.Size = New System.Drawing.Size(369, 26)
        Me.txtHargaBeli.TabIndex = 190
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(12, 172)
        Me.LabelControl3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(39, 17)
        Me.LabelControl3.TabIndex = 189
        Me.LabelControl3.Text = "Satuan"
        '
        'txtSatuan
        '
        Me.txtSatuan.Location = New System.Drawing.Point(12, 191)
        Me.txtSatuan.Name = "txtSatuan"
        Me.txtSatuan.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.txtSatuan.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSatuan.Properties.Appearance.Options.UseBackColor = True
        Me.txtSatuan.Properties.Appearance.Options.UseFont = True
        Me.txtSatuan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtSatuan.Size = New System.Drawing.Size(369, 26)
        Me.txtSatuan.TabIndex = 188
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(12, 70)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(73, 17)
        Me.LabelControl2.TabIndex = 187
        Me.LabelControl2.Text = "Jenis Barang"
        '
        'cbJenisBarang
        '
        Me.cbJenisBarang.Location = New System.Drawing.Point(12, 89)
        Me.cbJenisBarang.Name = "cbJenisBarang"
        Me.cbJenisBarang.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbJenisBarang.Properties.Appearance.Options.UseFont = True
        Me.cbJenisBarang.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cbJenisBarang.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbJenisBarang.Size = New System.Drawing.Size(369, 26)
        Me.cbJenisBarang.TabIndex = 186
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(12, 121)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(80, 17)
        Me.LabelControl1.TabIndex = 185
        Me.LabelControl1.Text = "Nama Barang"
        '
        'txtNamaBarang
        '
        Me.txtNamaBarang.Location = New System.Drawing.Point(12, 140)
        Me.txtNamaBarang.Name = "txtNamaBarang"
        Me.txtNamaBarang.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.txtNamaBarang.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaBarang.Properties.Appearance.Options.UseBackColor = True
        Me.txtNamaBarang.Properties.Appearance.Options.UseFont = True
        Me.txtNamaBarang.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtNamaBarang.Size = New System.Drawing.Size(369, 26)
        Me.txtNamaBarang.TabIndex = 184
        '
        'PictureEdit1
        '
        Me.PictureEdit1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureEdit1.EditValue = CType(resources.GetObject("PictureEdit1.EditValue"), Object)
        Me.PictureEdit1.Location = New System.Drawing.Point(0, 0)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.PictureEdit1.Size = New System.Drawing.Size(411, 53)
        Me.PictureEdit1.TabIndex = 183
        '
        'FormEditBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 480)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.LabelControl11)
        Me.Controls.Add(Me.LabelControl12)
        Me.Controls.Add(Me.txtStok)
        Me.Controls.Add(Me.LabelControl13)
        Me.Controls.Add(Me.txtStokMin)
        Me.Controls.Add(Me.LabelControl14)
        Me.Controls.Add(Me.txtStokMaks)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.txtHargaBeli)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txtSatuan)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.cbJenisBarang)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtNamaBarang)
        Me.Controls.Add(Me.PictureEdit1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormEditBarang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ubah Data Barang"
        CType(Me.txtStok.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStokMin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStokMaks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHargaBeli.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSatuan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbJenisBarang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNamaBarang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtStok As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtStokMin As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtStokMaks As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtHargaBeli As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSatuan As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbJenisBarang As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNamaBarang As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
End Class
