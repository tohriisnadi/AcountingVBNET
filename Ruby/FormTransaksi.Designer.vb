<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTransaksi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTransaksi))
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtKonsumen = New DevExpress.XtraEditors.TextEdit()
        Me.lbOperator = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.lbTanggal = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtHarga = New DevExpress.XtraEditors.TextEdit()
        Me.txtNamaBarang = New DevExpress.XtraEditors.TextEdit()
        Me.txtUkuran = New DevExpress.XtraEditors.TextEdit()
        Me.txtKodeBarang = New DevExpress.XtraEditors.TextEdit()
        Me.lbTotal = New System.Windows.Forms.Label()
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.PanelGrid = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtQty = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureEdit2 = New DevExpress.XtraEditors.PictureEdit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKonsumen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHarga.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNamaBarang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUkuran.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKodeBarang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelGrid.SuspendLayout()
        CType(Me.txtQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.BackColor = System.Drawing.Color.White
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(319, 81)
        Me.LabelControl4.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(15, 20)
        Me.LabelControl4.TabIndex = 274
        Me.LabelControl4.Text = "F1"
        '
        'GridView2
        '
        Me.GridView2.Appearance.FocusedRow.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView2.Appearance.FocusedRow.Options.UseFont = True
        Me.GridView2.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView2.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView2.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView2.Appearance.Row.Options.UseFont = True
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView2.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsView.ShowFooter = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'GridControl2
        '
        Me.GridControl2.DataSource = Me.BindingSource1
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.Location = New System.Drawing.Point(2, 2)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(919, 297)
        Me.GridControl2.TabIndex = 225
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'txtKonsumen
        '
        Me.txtKonsumen.EditValue = ""
        Me.txtKonsumen.Location = New System.Drawing.Point(111, 77)
        Me.txtKonsumen.Name = "txtKonsumen"
        Me.txtKonsumen.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.txtKonsumen.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKonsumen.Properties.Appearance.Options.UseBackColor = True
        Me.txtKonsumen.Properties.Appearance.Options.UseFont = True
        Me.txtKonsumen.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtKonsumen.Size = New System.Drawing.Size(201, 30)
        Me.txtKonsumen.TabIndex = 273
        '
        'lbOperator
        '
        Me.lbOperator.Appearance.BackColor = System.Drawing.Color.White
        Me.lbOperator.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbOperator.Location = New System.Drawing.Point(111, 111)
        Me.lbOperator.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.lbOperator.Name = "lbOperator"
        Me.lbOperator.Size = New System.Drawing.Size(41, 20)
        Me.lbOperator.TabIndex = 271
        Me.lbOperator.Text = "Wiwik"
        '
        'LabelControl18
        '
        Me.LabelControl18.Appearance.BackColor = System.Drawing.Color.White
        Me.LabelControl18.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl18.Location = New System.Drawing.Point(96, 111)
        Me.LabelControl18.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(3, 20)
        Me.LabelControl18.TabIndex = 270
        Me.LabelControl18.Text = ":"
        '
        'LabelControl17
        '
        Me.LabelControl17.Appearance.BackColor = System.Drawing.Color.White
        Me.LabelControl17.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl17.Location = New System.Drawing.Point(13, 111)
        Me.LabelControl17.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(60, 20)
        Me.LabelControl17.TabIndex = 269
        Me.LabelControl17.Text = "Operator"
        '
        'lbTanggal
        '
        Me.lbTanggal.Appearance.BackColor = System.Drawing.Color.White
        Me.lbTanggal.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTanggal.Location = New System.Drawing.Point(110, 51)
        Me.lbTanggal.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.lbTanggal.Name = "lbTanggal"
        Me.lbTanggal.Size = New System.Drawing.Size(108, 20)
        Me.lbTanggal.TabIndex = 268
        Me.lbTanggal.Text = "28 Agustus 2014"
        '
        'LabelControl15
        '
        Me.LabelControl15.Appearance.BackColor = System.Drawing.Color.White
        Me.LabelControl15.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl15.Location = New System.Drawing.Point(96, 51)
        Me.LabelControl15.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(3, 20)
        Me.LabelControl15.TabIndex = 267
        Me.LabelControl15.Text = ":"
        '
        'LabelControl14
        '
        Me.LabelControl14.Appearance.BackColor = System.Drawing.Color.White
        Me.LabelControl14.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl14.Location = New System.Drawing.Point(13, 51)
        Me.LabelControl14.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(54, 20)
        Me.LabelControl14.TabIndex = 266
        Me.LabelControl14.Text = "Tanggal"
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.BackColor = System.Drawing.Color.White
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl11.Location = New System.Drawing.Point(96, 82)
        Me.LabelControl11.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(3, 20)
        Me.LabelControl11.TabIndex = 265
        Me.LabelControl11.Text = ":"
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.BackColor = System.Drawing.Color.White
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl13.Appearance.ForeColor = System.Drawing.Color.RoyalBlue
        Me.LabelControl13.Location = New System.Drawing.Point(13, 82)
        Me.LabelControl13.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(75, 20)
        Me.LabelControl13.TabIndex = 264
        Me.LabelControl13.Text = "Konsumen"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(279, 147)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(91, 20)
        Me.LabelControl1.TabIndex = 259
        Me.LabelControl1.Text = "Nama Barang"
        '
        'txtHarga
        '
        Me.txtHarga.Location = New System.Drawing.Point(788, 171)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.txtHarga.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHarga.Properties.Appearance.Options.UseBackColor = True
        Me.txtHarga.Properties.Appearance.Options.UseFont = True
        Me.txtHarga.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtHarga.Properties.Mask.EditMask = "n0"
        Me.txtHarga.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtHarga.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtHarga.Size = New System.Drawing.Size(146, 30)
        Me.txtHarga.TabIndex = 257
        '
        'txtNamaBarang
        '
        Me.txtNamaBarang.Enabled = False
        Me.txtNamaBarang.Location = New System.Drawing.Point(279, 171)
        Me.txtNamaBarang.Name = "txtNamaBarang"
        Me.txtNamaBarang.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.txtNamaBarang.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaBarang.Properties.Appearance.Options.UseBackColor = True
        Me.txtNamaBarang.Properties.Appearance.Options.UseFont = True
        Me.txtNamaBarang.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtNamaBarang.Size = New System.Drawing.Size(268, 30)
        Me.txtNamaBarang.TabIndex = 256
        '
        'txtUkuran
        '
        Me.txtUkuran.EditValue = ""
        Me.txtUkuran.Enabled = False
        Me.txtUkuran.Location = New System.Drawing.Point(552, 171)
        Me.txtUkuran.Name = "txtUkuran"
        Me.txtUkuran.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.txtUkuran.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUkuran.Properties.Appearance.Options.UseBackColor = True
        Me.txtUkuran.Properties.Appearance.Options.UseFont = True
        Me.txtUkuran.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtUkuran.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtUkuran.Size = New System.Drawing.Size(143, 30)
        Me.txtUkuran.TabIndex = 255
        '
        'txtKodeBarang
        '
        Me.txtKodeBarang.Location = New System.Drawing.Point(15, 171)
        Me.txtKodeBarang.Name = "txtKodeBarang"
        Me.txtKodeBarang.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.txtKodeBarang.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKodeBarang.Properties.Appearance.Options.UseBackColor = True
        Me.txtKodeBarang.Properties.Appearance.Options.UseFont = True
        Me.txtKodeBarang.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtKodeBarang.Size = New System.Drawing.Size(229, 30)
        Me.txtKodeBarang.TabIndex = 254
        '
        'lbTotal
        '
        Me.lbTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbTotal.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbTotal.Font = New System.Drawing.Font("Segoe UI", 33.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTotal.Location = New System.Drawing.Point(491, 61)
        Me.lbTotal.Name = "lbTotal"
        Me.lbTotal.Size = New System.Drawing.Size(490, 60)
        Me.lbTotal.TabIndex = 272
        Me.lbTotal.Text = "0"
        Me.lbTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelControl21
        '
        Me.LabelControl21.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl21.Location = New System.Drawing.Point(16, 147)
        Me.LabelControl21.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(86, 20)
        Me.LabelControl21.TabIndex = 258
        Me.LabelControl21.Text = "Kode Barang"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureEdit1.EditValue = CType(resources.GetObject("PictureEdit1.EditValue"), Object)
        Me.PictureEdit1.Location = New System.Drawing.Point(0, 0)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Size = New System.Drawing.Size(993, 142)
        Me.PictureEdit1.TabIndex = 253
        '
        'PanelGrid
        '
        Me.PanelGrid.Controls.Add(Me.GridControl2)
        Me.PanelGrid.Location = New System.Drawing.Point(13, 207)
        Me.PanelGrid.Name = "PanelGrid"
        Me.PanelGrid.Size = New System.Drawing.Size(923, 301)
        Me.PanelGrid.TabIndex = 263
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(552, 147)
        Me.LabelControl3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(46, 20)
        Me.LabelControl3.TabIndex = 261
        Me.LabelControl3.Text = "Ukuran"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(788, 145)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(84, 20)
        Me.LabelControl2.TabIndex = 260
        Me.LabelControl2.Text = "Harga  Sewa"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(251, 176)
        Me.LabelControl5.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(15, 20)
        Me.LabelControl5.TabIndex = 275
        Me.LabelControl5.Text = "F1"
        '
        'txtQty
        '
        Me.txtQty.EditValue = "1"
        Me.txtQty.Location = New System.Drawing.Point(701, 172)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.txtQty.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty.Properties.Appearance.Options.UseBackColor = True
        Me.txtQty.Properties.Appearance.Options.UseFont = True
        Me.txtQty.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtQty.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtQty.Size = New System.Drawing.Size(81, 30)
        Me.txtQty.TabIndex = 276
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Location = New System.Drawing.Point(701, 146)
        Me.LabelControl6.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(23, 20)
        Me.LabelControl6.TabIndex = 277
        Me.LabelControl6.Text = "Qty"
        '
        'PictureEdit2
        '
        Me.PictureEdit2.EditValue = CType(resources.GetObject("PictureEdit2.EditValue"), Object)
        Me.PictureEdit2.Location = New System.Drawing.Point(12, 3)
        Me.PictureEdit2.Name = "PictureEdit2"
        Me.PictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.PictureEdit2.Size = New System.Drawing.Size(104, 39)
        Me.PictureEdit2.TabIndex = 278
        '
        'FormTransaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(993, 573)
        Me.Controls.Add(Me.PictureEdit2)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.txtKonsumen)
        Me.Controls.Add(Me.lbOperator)
        Me.Controls.Add(Me.LabelControl18)
        Me.Controls.Add(Me.LabelControl17)
        Me.Controls.Add(Me.lbTanggal)
        Me.Controls.Add(Me.LabelControl15)
        Me.Controls.Add(Me.LabelControl14)
        Me.Controls.Add(Me.LabelControl11)
        Me.Controls.Add(Me.LabelControl13)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtHarga)
        Me.Controls.Add(Me.txtNamaBarang)
        Me.Controls.Add(Me.txtUkuran)
        Me.Controls.Add(Me.txtKodeBarang)
        Me.Controls.Add(Me.lbTotal)
        Me.Controls.Add(Me.LabelControl21)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Controls.Add(Me.PanelGrid)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormTransaksi"
        Me.Text = "FormTransaksi"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKonsumen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHarga.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNamaBarang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUkuran.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKodeBarang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelGrid.ResumeLayout(False)
        CType(Me.txtQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents txtKonsumen As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbOperator As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbTanggal As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtHarga As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNamaBarang As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtUkuran As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtKodeBarang As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbTotal As System.Windows.Forms.Label
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents PanelGrid As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtQty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureEdit2 As DevExpress.XtraEditors.PictureEdit
End Class
