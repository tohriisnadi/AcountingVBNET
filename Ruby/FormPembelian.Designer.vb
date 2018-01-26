<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPembelian
    Inherits System.Windows.Forms.Form

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPembelian))
        Me.Label21 = New System.Windows.Forms.Label()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtNota = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.btnDetil = New DevExpress.XtraEditors.SimpleButton()
        Me.txtHutang = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtLookUpSuplier = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNamaSuplier = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAlamatSuplier = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.PanelControl5 = New DevExpress.XtraEditors.PanelControl()
        Me.lbTot = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.txtTglNota = New System.Windows.Forms.MaskedTextBox()
        Me.txtNamaBarang = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.txtSatuan = New System.Windows.Forms.TextBox()
        Me.txtHargaBeli = New System.Windows.Forms.TextBox()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.txtHargaJual = New System.Windows.Forms.TextBox()
        Me.txtBarcode = New System.Windows.Forms.TextBox()
        Me.txtMargin = New System.Windows.Forms.TextBox()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtUangMuka = New System.Windows.Forms.TextBox()
        Me.txtJatuhTempo = New DevExpress.XtraEditors.DateEdit()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtSisa = New System.Windows.Forms.TextBox()
        Me.RadioGroup1 = New DevExpress.XtraEditors.RadioGroup()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl5.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.txtJatuhTempo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtJatuhTempo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(5, 45)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(164, 20)
        Me.Label21.TabIndex = 53
        Me.Label21.Text = "Tgl Nota (dd-mm-yyyy)"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.BindingSource1
        Me.GridControl1.Location = New System.Drawing.Point(12, 310)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1176, 433)
        Me.GridControl1.TabIndex = 49
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.Transparent
        Me.GridView1.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView1.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.Row.Options.UseFont = True
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsPrint.PrintPreview = True
        Me.GridView1.OptionsView.EnableAppearanceOddRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(110, 9)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(71, 20)
        Me.Label19.TabIndex = 9
        Me.Label19.Text = "No. Nota"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNota
        '
        Me.txtNota.Location = New System.Drawing.Point(188, 9)
        Me.txtNota.Name = "txtNota"
        Me.txtNota.Size = New System.Drawing.Size(206, 26)
        Me.txtNota.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 21.75!)
        Me.Label1.Location = New System.Drawing.Point(6, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(244, 35)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Pembelian Barang"
        '
        'PanelControl4
        '
        Me.PanelControl4.Controls.Add(Me.LabelControl1)
        Me.PanelControl4.Controls.Add(Me.btnDetil)
        Me.PanelControl4.Controls.Add(Me.txtHutang)
        Me.PanelControl4.Controls.Add(Me.Label22)
        Me.PanelControl4.Controls.Add(Me.txtLookUpSuplier)
        Me.PanelControl4.Controls.Add(Me.Label4)
        Me.PanelControl4.Controls.Add(Me.txtNamaSuplier)
        Me.PanelControl4.Controls.Add(Me.Label3)
        Me.PanelControl4.Controls.Add(Me.txtAlamatSuplier)
        Me.PanelControl4.Controls.Add(Me.Label2)
        Me.PanelControl4.Location = New System.Drawing.Point(426, 57)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(379, 176)
        Me.PanelControl4.TabIndex = 50
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(352, 15)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(23, 16)
        Me.LabelControl1.TabIndex = 49
        Me.LabelControl1.Text = "* F1"
        '
        'btnDetil
        '
        Me.btnDetil.Location = New System.Drawing.Point(308, 139)
        Me.btnDetil.Name = "btnDetil"
        Me.btnDetil.Size = New System.Drawing.Size(41, 27)
        Me.btnDetil.TabIndex = 48
        '
        'txtHutang
        '
        Me.txtHutang.Enabled = False
        Me.txtHutang.Location = New System.Drawing.Point(143, 139)
        Me.txtHutang.Name = "txtHutang"
        Me.txtHutang.Size = New System.Drawing.Size(159, 26)
        Me.txtHutang.TabIndex = 47
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(77, 142)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(62, 20)
        Me.Label22.TabIndex = 46
        Me.Label22.Text = "Hutang"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtLookUpSuplier
        '
        Me.txtLookUpSuplier.Location = New System.Drawing.Point(143, 9)
        Me.txtLookUpSuplier.Name = "txtLookUpSuplier"
        Me.txtLookUpSuplier.Size = New System.Drawing.Size(206, 26)
        Me.txtLookUpSuplier.TabIndex = 43
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(71, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 20)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Alamat"
        '
        'txtNamaSuplier
        '
        Me.txtNamaSuplier.Enabled = False
        Me.txtNamaSuplier.Location = New System.Drawing.Point(143, 42)
        Me.txtNamaSuplier.Name = "txtNamaSuplier"
        Me.txtNamaSuplier.Size = New System.Drawing.Size(206, 26)
        Me.txtNamaSuplier.TabIndex = 44
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 20)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Nama Suplier"
        '
        'txtAlamatSuplier
        '
        Me.txtAlamatSuplier.Enabled = False
        Me.txtAlamatSuplier.Location = New System.Drawing.Point(143, 75)
        Me.txtAlamatSuplier.Multiline = True
        Me.txtAlamatSuplier.Name = "txtAlamatSuplier"
        Me.txtAlamatSuplier.Size = New System.Drawing.Size(206, 58)
        Me.txtAlamatSuplier.TabIndex = 45
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 20)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Look Up Suplier"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(6, 57)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(63, 45)
        Me.Label20.TabIndex = 11
        Me.Label20.Text = "Rp"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PanelControl5
        '
        Me.PanelControl5.Controls.Add(Me.Label20)
        Me.PanelControl5.Controls.Add(Me.lbTot)
        Me.PanelControl5.Location = New System.Drawing.Point(811, 57)
        Me.PanelControl5.Name = "PanelControl5"
        Me.PanelControl5.Size = New System.Drawing.Size(377, 174)
        Me.PanelControl5.TabIndex = 51
        '
        'lbTot
        '
        Me.lbTot.AutoSize = True
        Me.lbTot.Font = New System.Drawing.Font("Tahoma", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTot.Location = New System.Drawing.Point(77, 57)
        Me.lbTot.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbTot.Name = "lbTot"
        Me.lbTot.Size = New System.Drawing.Size(40, 45)
        Me.lbTot.TabIndex = 11
        Me.lbTot.Text = "0"
        Me.lbTot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(525, 2)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 20)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Harga Beli"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(369, 2)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 20)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Satuan"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(462, 2)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 20)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Qty"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.txtTglNota)
        Me.PanelControl1.Controls.Add(Me.Label21)
        Me.PanelControl1.Controls.Add(Me.Label19)
        Me.PanelControl1.Controls.Add(Me.txtNota)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 57)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(408, 176)
        Me.PanelControl1.TabIndex = 46
        '
        'txtTglNota
        '
        Me.txtTglNota.Location = New System.Drawing.Point(188, 45)
        Me.txtTglNota.Mask = "00/00/0000"
        Me.txtTglNota.Name = "txtTglNota"
        Me.txtTglNota.Size = New System.Drawing.Size(206, 26)
        Me.txtTglNota.TabIndex = 55
        Me.txtTglNota.ValidatingType = GetType(Date)
        '
        'txtNamaBarang
        '
        Me.txtNamaBarang.Location = New System.Drawing.Point(5, 26)
        Me.txtNamaBarang.Name = "txtNamaBarang"
        Me.txtNamaBarang.Size = New System.Drawing.Size(302, 26)
        Me.txtNamaBarang.TabIndex = 37
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 2)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 20)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Nama Barang"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.LabelControl2)
        Me.PanelControl2.Controls.Add(Me.txtQty)
        Me.PanelControl2.Controls.Add(Me.Label9)
        Me.PanelControl2.Controls.Add(Me.Label8)
        Me.PanelControl2.Controls.Add(Me.Label7)
        Me.PanelControl2.Controls.Add(Me.txtNamaBarang)
        Me.PanelControl2.Controls.Add(Me.Label6)
        Me.PanelControl2.Controls.Add(Me.txtSatuan)
        Me.PanelControl2.Controls.Add(Me.txtHargaBeli)
        Me.PanelControl2.Location = New System.Drawing.Point(12, 239)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1176, 65)
        Me.PanelControl2.TabIndex = 47
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(313, 32)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(23, 16)
        Me.LabelControl2.TabIndex = 50
        Me.LabelControl2.Text = "* F1"
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(453, 26)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(63, 26)
        Me.txtQty.TabIndex = 49
        '
        'txtSatuan
        '
        Me.txtSatuan.Enabled = False
        Me.txtSatuan.Location = New System.Drawing.Point(352, 26)
        Me.txtSatuan.Name = "txtSatuan"
        Me.txtSatuan.Size = New System.Drawing.Size(95, 26)
        Me.txtSatuan.TabIndex = 40
        '
        'txtHargaBeli
        '
        Me.txtHargaBeli.Location = New System.Drawing.Point(522, 26)
        Me.txtHargaBeli.Name = "txtHargaBeli"
        Me.txtHargaBeli.Size = New System.Drawing.Size(169, 26)
        Me.txtHargaBeli.TabIndex = 43
        Me.txtHargaBeli.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(562, 21)
        Me.MaskedTextBox1.Mask = "00/00/0000"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(173, 26)
        Me.MaskedTextBox1.TabIndex = 56
        Me.MaskedTextBox1.ValidatingType = GetType(Date)
        Me.MaskedTextBox1.Visible = False
        '
        'txtHargaJual
        '
        Me.txtHargaJual.Location = New System.Drawing.Point(447, 21)
        Me.txtHargaJual.Name = "txtHargaJual"
        Me.txtHargaJual.Size = New System.Drawing.Size(109, 26)
        Me.txtHargaJual.TabIndex = 45
        Me.txtHargaJual.Visible = False
        '
        'txtBarcode
        '
        Me.txtBarcode.Location = New System.Drawing.Point(259, 21)
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.Size = New System.Drawing.Size(126, 26)
        Me.txtBarcode.TabIndex = 35
        Me.txtBarcode.Visible = False
        '
        'txtMargin
        '
        Me.txtMargin.Location = New System.Drawing.Point(391, 21)
        Me.txtMargin.Name = "txtMargin"
        Me.txtMargin.Size = New System.Drawing.Size(50, 26)
        Me.txtMargin.TabIndex = 44
        Me.txtMargin.Visible = False
        '
        'PanelControl3
        '
        Me.PanelControl3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PanelControl3.Appearance.BackColor = System.Drawing.Color.LightGray
        Me.PanelControl3.Appearance.Options.UseBackColor = True
        Me.PanelControl3.Controls.Add(Me.Label18)
        Me.PanelControl3.Controls.Add(Me.Label23)
        Me.PanelControl3.Controls.Add(Me.Label17)
        Me.PanelControl3.Controls.Add(Me.txtUangMuka)
        Me.PanelControl3.Controls.Add(Me.txtJatuhTempo)
        Me.PanelControl3.Controls.Add(Me.Label16)
        Me.PanelControl3.Controls.Add(Me.Label13)
        Me.PanelControl3.Controls.Add(Me.txtTotal)
        Me.PanelControl3.Controls.Add(Me.txtSisa)
        Me.PanelControl3.Controls.Add(Me.RadioGroup1)
        Me.PanelControl3.Location = New System.Drawing.Point(373, 325)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(390, 250)
        Me.PanelControl3.TabIndex = 52
        Me.PanelControl3.Visible = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(101, 195)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(40, 20)
        Me.Label18.TabIndex = 32
        Me.Label18.Text = "Sisa"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Label23.Location = New System.Drawing.Point(14, 117)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(127, 20)
        Me.Label23.TabIndex = 31
        Me.Label23.Text = "Tgl Jatuh Tempo"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(50, 155)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(91, 20)
        Me.Label17.TabIndex = 31
        Me.Label17.Text = "Uang Muka"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtUangMuka
        '
        Me.txtUangMuka.Location = New System.Drawing.Point(156, 152)
        Me.txtUangMuka.Name = "txtUangMuka"
        Me.txtUangMuka.Size = New System.Drawing.Size(199, 26)
        Me.txtUangMuka.TabIndex = 52
        Me.txtUangMuka.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtJatuhTempo
        '
        Me.txtJatuhTempo.EditValue = Nothing
        Me.txtJatuhTempo.Location = New System.Drawing.Point(156, 114)
        Me.txtJatuhTempo.Name = "txtJatuhTempo"
        Me.txtJatuhTempo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.txtJatuhTempo.Properties.Appearance.Options.UseFont = True
        Me.txtJatuhTempo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtJatuhTempo.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtJatuhTempo.Properties.CalendarTimeProperties.CloseUpKey = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4)
        Me.txtJatuhTempo.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.[Default]
        Me.txtJatuhTempo.Size = New System.Drawing.Size(199, 26)
        Me.txtJatuhTempo.TabIndex = 52
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(6, 70)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(136, 20)
        Me.Label16.TabIndex = 28
        Me.Label16.Text = "Cara Pembayaran"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(94, 26)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(48, 20)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "Total "
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(156, 23)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(199, 26)
        Me.txtTotal.TabIndex = 34
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSisa
        '
        Me.txtSisa.Location = New System.Drawing.Point(156, 192)
        Me.txtSisa.Name = "txtSisa"
        Me.txtSisa.Size = New System.Drawing.Size(199, 26)
        Me.txtSisa.TabIndex = 53
        Me.txtSisa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadioGroup1
        '
        Me.RadioGroup1.Location = New System.Drawing.Point(156, 70)
        Me.RadioGroup1.Name = "RadioGroup1"
        Me.RadioGroup1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.RadioGroup1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.RadioGroup1.Properties.Appearance.Options.UseBackColor = True
        Me.RadioGroup1.Properties.Appearance.Options.UseFont = True
        Me.RadioGroup1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RadioGroup1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Cash"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Kredit")})
        Me.RadioGroup1.Size = New System.Drawing.Size(199, 24)
        Me.RadioGroup1.TabIndex = 51
        '
        'FormPembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1195, 750)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PanelControl4)
        Me.Controls.Add(Me.PanelControl5)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.txtBarcode)
        Me.Controls.Add(Me.txtMargin)
        Me.Controls.Add(Me.txtHargaJual)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "FormPembelian"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pembelian Barang"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        Me.PanelControl4.PerformLayout()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl5.ResumeLayout(False)
        Me.PanelControl5.PerformLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.PanelControl3.PerformLayout()
        CType(Me.txtJatuhTempo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtJatuhTempo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtNota As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnDetil As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtHutang As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtLookUpSuplier As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNamaSuplier As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtAlamatSuplier As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents PanelControl5 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lbTot As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtNamaBarang As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtHargaJual As System.Windows.Forms.TextBox
    Friend WithEvents txtBarcode As System.Windows.Forms.TextBox
    Friend WithEvents txtSatuan As System.Windows.Forms.TextBox
    Friend WithEvents txtHargaBeli As System.Windows.Forms.TextBox
    Friend WithEvents txtMargin As System.Windows.Forms.TextBox
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtUangMuka As System.Windows.Forms.TextBox
    Friend WithEvents txtJatuhTempo As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtSisa As System.Windows.Forms.TextBox
    Friend WithEvents RadioGroup1 As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents txtTglNota As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBox1 As System.Windows.Forms.MaskedTextBox
End Class
