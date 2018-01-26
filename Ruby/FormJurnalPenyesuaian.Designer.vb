<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormJurnalPenyesuaian
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormJurnalPenyesuaian))
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Me.txttanggal = New System.Windows.Forms.MaskedTextBox()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txtkredit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtdebet = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.cbakun = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtbuktitransaksi = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtketerangan = New DevExpress.XtraEditors.MemoEdit()
        Me.btnsimpan = New DevExpress.XtraEditors.SimpleButton()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        CType(Me.txtkredit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdebet.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbakun.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtbuktitransaksi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtketerangan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txttanggal
        '
        Me.txttanggal.AllowDrop = True
        Me.txttanggal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txttanggal.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttanggal.Location = New System.Drawing.Point(5, 85)
        Me.txttanggal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txttanggal.Mask = "00/00/0000"
        Me.txttanggal.Name = "txttanggal"
        Me.txttanggal.Size = New System.Drawing.Size(371, 25)
        Me.txttanggal.TabIndex = 1
        Me.txttanggal.ValidatingType = GetType(Date)
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Location = New System.Drawing.Point(5, 118)
        Me.LabelControl6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(75, 17)
        Me.LabelControl6.TabIndex = 218
        Me.LabelControl6.Text = "Keterangan  "
        '
        'txtkredit
        '
        Me.txtkredit.EditValue = "0"
        Me.txtkredit.EnterMoveNextControl = True
        Me.txtkredit.Location = New System.Drawing.Point(259, 218)
        Me.txtkredit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtkredit.Name = "txtkredit"
        Me.txtkredit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkredit.Properties.Appearance.Options.UseFont = True
        Me.txtkredit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtkredit.Properties.Mask.EditMask = "n0"
        Me.txtkredit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtkredit.Size = New System.Drawing.Size(117, 26)
        Me.txtkredit.TabIndex = 5
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(259, 193)
        Me.LabelControl5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(39, 17)
        Me.LabelControl5.TabIndex = 215
        Me.LabelControl5.Text = "Kredit "
        '
        'txtdebet
        '
        Me.txtdebet.EditValue = "0"
        Me.txtdebet.EnterMoveNextControl = True
        Me.txtdebet.Location = New System.Drawing.Point(143, 218)
        Me.txtdebet.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtdebet.Name = "txtdebet"
        Me.txtdebet.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdebet.Properties.Appearance.Options.UseFont = True
        Me.txtdebet.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtdebet.Properties.Mask.EditMask = "n0"
        Me.txtdebet.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtdebet.Size = New System.Drawing.Size(110, 26)
        Me.txtdebet.TabIndex = 4
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(143, 193)
        Me.LabelControl4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(39, 17)
        Me.LabelControl4.TabIndex = 213
        Me.LabelControl4.Text = "Debet "
        '
        'cbakun
        '
        Me.cbakun.EnterMoveNextControl = True
        Me.cbakun.Location = New System.Drawing.Point(5, 218)
        Me.cbakun.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbakun.Name = "cbakun"
        Me.cbakun.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbakun.Properties.Appearance.Options.UseFont = True
        Me.cbakun.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cbakun.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbakun.Size = New System.Drawing.Size(132, 26)
        Me.cbakun.TabIndex = 3
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(5, 193)
        Me.LabelControl3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(32, 17)
        Me.LabelControl3.TabIndex = 211
        Me.LabelControl3.Text = "Akun "
        '
        'txtbuktitransaksi
        '
        Me.txtbuktitransaksi.AllowDrop = True
        Me.txtbuktitransaksi.EnterMoveNextControl = True
        Me.txtbuktitransaksi.Location = New System.Drawing.Point(440, 38)
        Me.txtbuktitransaksi.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtbuktitransaksi.Name = "txtbuktitransaksi"
        Me.txtbuktitransaksi.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txtbuktitransaksi.Properties.Appearance.Options.UseFont = True
        Me.txtbuktitransaksi.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtbuktitransaksi.Size = New System.Drawing.Size(58, 24)
        Me.txtbuktitransaksi.TabIndex = 2
        Me.txtbuktitransaksi.Visible = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(5, 60)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(51, 17)
        Me.LabelControl1.TabIndex = 208
        Me.LabelControl1.Text = "Tanggal "
        '
        'txtketerangan
        '
        Me.txtketerangan.AllowDrop = True
        Me.txtketerangan.EnterMoveNextControl = True
        Me.txtketerangan.Location = New System.Drawing.Point(5, 143)
        Me.txtketerangan.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtketerangan.Name = "txtketerangan"
        Me.txtketerangan.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtketerangan.Properties.Appearance.Options.UseFont = True
        Me.txtketerangan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtketerangan.Size = New System.Drawing.Size(371, 42)
        Me.txtketerangan.TabIndex = 2
        '
        'btnsimpan
        '
        Me.btnsimpan.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsimpan.Appearance.Options.UseFont = True
        Me.btnsimpan.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnsimpan.Image = CType(resources.GetObject("btnsimpan.Image"), System.Drawing.Image)
        Me.btnsimpan.Location = New System.Drawing.Point(206, 556)
        Me.btnsimpan.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(82, 25)
        Me.btnsimpan.TabIndex = 6
        Me.btnsimpan.Text = "Simpan"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.BindingSource1
        Me.GridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        GridLevelNode1.RelationName = "Level1"
        Me.GridControl1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GridControl1.Location = New System.Drawing.Point(5, 264)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(371, 284)
        Me.GridControl1.TabIndex = 220
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.FocusedRow.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.FocusedRow.Options.UseFont = True
        Me.GridView1.Appearance.FooterPanel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.FooterPanel.Options.UseFont = True
        Me.GridView1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView1.Appearance.Row.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.Row.Options.UseFont = True
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(294, 556)
        Me.SimpleButton1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(82, 25)
        Me.SimpleButton1.TabIndex = 223
        Me.SimpleButton1.Text = "Keluar"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureEdit1.EditValue = CType(resources.GetObject("PictureEdit1.EditValue"), Object)
        Me.PictureEdit1.Location = New System.Drawing.Point(0, 0)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.PictureEdit1.Size = New System.Drawing.Size(382, 53)
        Me.PictureEdit1.TabIndex = 224
        '
        'FormJurnalPenyesuaian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 589)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.txttanggal)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.txtkredit)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.txtdebet)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.cbakun)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txtbuktitransaksi)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtketerangan)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormJurnalPenyesuaian"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Jurnal Penyesuaian"
        CType(Me.txtkredit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdebet.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbakun.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtbuktitransaksi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtketerangan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txttanggal As System.Windows.Forms.MaskedTextBox
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtkredit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtdebet As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbakun As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtbuktitransaksi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtketerangan As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents btnsimpan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
End Class
