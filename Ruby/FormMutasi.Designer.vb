<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMutasi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMutasi))
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LOperator = New DevExpress.XtraEditors.LabelControl()
        Me.LTanggal = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.SleDepartemen = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btnAddDepartemen = New DevExpress.XtraEditors.SimpleButton()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txtKodeBarang = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNamaBarang = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.txtHarga = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSatuan = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.txtQty = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.txtStok = New DevExpress.XtraEditors.TextEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btnBatal = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCatatan = New DevExpress.XtraEditors.MemoEdit()
        Me.lbTotal = New DevExpress.XtraEditors.LabelControl()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SleDepartemen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKodeBarang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNamaBarang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHarga.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSatuan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStok.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtCatatan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureEdit1
        '
        Me.PictureEdit1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureEdit1.EditValue = CType(resources.GetObject("PictureEdit1.EditValue"), Object)
        Me.PictureEdit1.Location = New System.Drawing.Point(0, 0)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.PictureEdit1.Size = New System.Drawing.Size(1103, 53)
        Me.PictureEdit1.TabIndex = 152
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(13, 76)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(47, 17)
        Me.LabelControl2.TabIndex = 156
        Me.LabelControl2.Text = "Tanggal"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(13, 110)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(54, 17)
        Me.LabelControl1.TabIndex = 157
        Me.LabelControl1.Text = "Operator"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(100, 110)
        Me.LabelControl3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(3, 17)
        Me.LabelControl3.TabIndex = 159
        Me.LabelControl3.Text = ":"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(100, 76)
        Me.LabelControl4.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(3, 17)
        Me.LabelControl4.TabIndex = 158
        Me.LabelControl4.Text = ":"
        '
        'LOperator
        '
        Me.LOperator.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LOperator.Location = New System.Drawing.Point(114, 110)
        Me.LOperator.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LOperator.Name = "LOperator"
        Me.LOperator.Size = New System.Drawing.Size(68, 17)
        Me.LOperator.TabIndex = 161
        Me.LOperator.Text = "txtOperator"
        '
        'LTanggal
        '
        Me.LTanggal.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTanggal.Location = New System.Drawing.Point(114, 76)
        Me.LTanggal.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LTanggal.Name = "LTanggal"
        Me.LTanggal.Size = New System.Drawing.Size(61, 17)
        Me.LTanggal.TabIndex = 160
        Me.LTanggal.Text = "txtTanggal"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(13, 144)
        Me.LabelControl5.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(72, 17)
        Me.LabelControl5.TabIndex = 162
        Me.LabelControl5.Text = "Departemen"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Location = New System.Drawing.Point(100, 144)
        Me.LabelControl6.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(3, 17)
        Me.LabelControl6.TabIndex = 163
        Me.LabelControl6.Text = ":"
        '
        'SleDepartemen
        '
        Me.SleDepartemen.Location = New System.Drawing.Point(114, 140)
        Me.SleDepartemen.Name = "SleDepartemen"
        Me.SleDepartemen.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SleDepartemen.Properties.Appearance.Options.UseFont = True
        Me.SleDepartemen.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.SleDepartemen.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SleDepartemen.Properties.View = Me.SearchLookUpEdit1View
        Me.SleDepartemen.Size = New System.Drawing.Size(216, 26)
        Me.SleDepartemen.TabIndex = 330
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'btnAddDepartemen
        '
        Me.btnAddDepartemen.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddDepartemen.Appearance.Options.UseFont = True
        Me.btnAddDepartemen.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnAddDepartemen.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnAddDepartemen.Location = New System.Drawing.Point(348, 141)
        Me.btnAddDepartemen.Name = "btnAddDepartemen"
        Me.btnAddDepartemen.Size = New System.Drawing.Size(34, 25)
        Me.btnAddDepartemen.TabIndex = 331
        Me.btnAddDepartemen.Text = "+"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.BindingSource1
        Me.GridControl1.Location = New System.Drawing.Point(0, 259)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1099, 302)
        Me.GridControl1.TabIndex = 332
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView1.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.Row.Options.UseFont = True
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Location = New System.Drawing.Point(13, 191)
        Me.LabelControl7.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(76, 17)
        Me.LabelControl7.TabIndex = 334
        Me.LabelControl7.Text = "Kode Barang"
        '
        'txtKodeBarang
        '
        Me.txtKodeBarang.Location = New System.Drawing.Point(13, 210)
        Me.txtKodeBarang.Name = "txtKodeBarang"
        Me.txtKodeBarang.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.txtKodeBarang.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKodeBarang.Properties.Appearance.Options.UseBackColor = True
        Me.txtKodeBarang.Properties.Appearance.Options.UseFont = True
        Me.txtKodeBarang.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtKodeBarang.Size = New System.Drawing.Size(131, 26)
        Me.txtKodeBarang.TabIndex = 333
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Location = New System.Drawing.Point(158, 191)
        Me.LabelControl8.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(80, 17)
        Me.LabelControl8.TabIndex = 336
        Me.LabelControl8.Text = "Nama Barang"
        '
        'txtNamaBarang
        '
        Me.txtNamaBarang.Location = New System.Drawing.Point(158, 210)
        Me.txtNamaBarang.Name = "txtNamaBarang"
        Me.txtNamaBarang.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.txtNamaBarang.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaBarang.Properties.Appearance.Options.UseBackColor = True
        Me.txtNamaBarang.Properties.Appearance.Options.UseFont = True
        Me.txtNamaBarang.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtNamaBarang.Size = New System.Drawing.Size(236, 26)
        Me.txtNamaBarang.TabIndex = 335
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Location = New System.Drawing.Point(545, 191)
        Me.LabelControl9.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(36, 17)
        Me.LabelControl9.TabIndex = 340
        Me.LabelControl9.Text = "Harga"
        '
        'txtHarga
        '
        Me.txtHarga.Location = New System.Drawing.Point(545, 210)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.txtHarga.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHarga.Properties.Appearance.Options.UseBackColor = True
        Me.txtHarga.Properties.Appearance.Options.UseFont = True
        Me.txtHarga.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtHarga.Size = New System.Drawing.Size(149, 26)
        Me.txtHarga.TabIndex = 339
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Location = New System.Drawing.Point(400, 191)
        Me.LabelControl10.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(39, 17)
        Me.LabelControl10.TabIndex = 338
        Me.LabelControl10.Text = "Satuan"
        '
        'txtSatuan
        '
        Me.txtSatuan.Location = New System.Drawing.Point(400, 210)
        Me.txtSatuan.Name = "txtSatuan"
        Me.txtSatuan.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.txtSatuan.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSatuan.Properties.Appearance.Options.UseBackColor = True
        Me.txtSatuan.Properties.Appearance.Options.UseFont = True
        Me.txtSatuan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtSatuan.Size = New System.Drawing.Size(131, 26)
        Me.txtSatuan.TabIndex = 337
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl11.Location = New System.Drawing.Point(790, 187)
        Me.LabelControl11.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(20, 17)
        Me.LabelControl11.TabIndex = 344
        Me.LabelControl11.Text = "Qty"
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(790, 210)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.txtQty.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty.Properties.Appearance.Options.UseBackColor = True
        Me.txtQty.Properties.Appearance.Options.UseFont = True
        Me.txtQty.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtQty.Size = New System.Drawing.Size(84, 26)
        Me.txtQty.TabIndex = 343
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl12.Location = New System.Drawing.Point(700, 191)
        Me.LabelControl12.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(26, 17)
        Me.LabelControl12.TabIndex = 342
        Me.LabelControl12.Text = "Stok"
        '
        'txtStok
        '
        Me.txtStok.Location = New System.Drawing.Point(700, 210)
        Me.txtStok.Name = "txtStok"
        Me.txtStok.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.txtStok.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStok.Properties.Appearance.Options.UseBackColor = True
        Me.txtStok.Properties.Appearance.Options.UseFont = True
        Me.txtStok.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtStok.Size = New System.Drawing.Size(84, 26)
        Me.txtStok.TabIndex = 341
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btnBatal)
        Me.PanelControl1.Controls.Add(Me.btnAdd)
        Me.PanelControl1.Controls.Add(Me.LabelControl13)
        Me.PanelControl1.Controls.Add(Me.LabelControl14)
        Me.PanelControl1.Controls.Add(Me.txtCatatan)
        Me.PanelControl1.Location = New System.Drawing.Point(409, 242)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(331, 158)
        Me.PanelControl1.TabIndex = 345
        '
        'btnBatal
        '
        Me.btnBatal.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBatal.Appearance.Options.UseFont = True
        Me.btnBatal.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnBatal.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnBatal.Location = New System.Drawing.Point(228, 128)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(83, 25)
        Me.btnBatal.TabIndex = 225
        Me.btnBatal.Text = "Batal"
        '
        'btnAdd
        '
        Me.btnAdd.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Appearance.Options.UseFont = True
        Me.btnAdd.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnAdd.Location = New System.Drawing.Point(139, 128)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(83, 25)
        Me.btnAdd.TabIndex = 225
        Me.btnAdd.Text = "Simpan"
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl13.Location = New System.Drawing.Point(11, 8)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(77, 17)
        Me.LabelControl13.TabIndex = 224
        Me.LabelControl13.Text = "Keterangan :"
        '
        'LabelControl14
        '
        Me.LabelControl14.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl14.Location = New System.Drawing.Point(317, 27)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(5, 13)
        Me.LabelControl14.TabIndex = 224
        Me.LabelControl14.Text = "*"
        '
        'txtCatatan
        '
        Me.txtCatatan.Location = New System.Drawing.Point(10, 27)
        Me.txtCatatan.Name = "txtCatatan"
        Me.txtCatatan.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCatatan.Properties.Appearance.Options.UseFont = True
        Me.txtCatatan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtCatatan.Size = New System.Drawing.Size(301, 95)
        Me.txtCatatan.TabIndex = 0
        '
        'lbTotal
        '
        Me.lbTotal.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTotal.Location = New System.Drawing.Point(885, 76)
        Me.lbTotal.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.lbTotal.Name = "lbTotal"
        Me.lbTotal.Size = New System.Drawing.Size(29, 17)
        Me.lbTotal.TabIndex = 346
        Me.lbTotal.Text = "Total"
        Me.lbTotal.Visible = False
        '
        'FormMutasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1103, 591)
        Me.Controls.Add(Me.lbTotal)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.LabelControl11)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.LabelControl12)
        Me.Controls.Add(Me.txtStok)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.txtHarga)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.txtSatuan)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.txtNamaBarang)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.txtKodeBarang)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.btnAddDepartemen)
        Me.Controls.Add(Me.SleDepartemen)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.LOperator)
        Me.Controls.Add(Me.LTanggal)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.PictureEdit1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormMutasi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mutasi"
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SleDepartemen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKodeBarang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNamaBarang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHarga.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSatuan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStok.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txtCatatan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LOperator As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LTanggal As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SleDepartemen As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnAddDepartemen As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtKodeBarang As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNamaBarang As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtHarga As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSatuan As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtQty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtStok As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnBatal As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCatatan As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents lbTotal As DevExpress.XtraEditors.LabelControl
End Class
