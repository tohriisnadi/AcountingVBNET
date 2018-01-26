Imports System.Data.Odbc
Imports DevExpress.XtraReports.UI

Public Class FormMutasi
    Dim dataDepartemen As New ClassDepartemen
    Dim DataStore As New ClassStore
    Dim dataBarang As New ClassBarang

    Dim oDataDepartemen As New DataTable
    Dim OdataBarang As New DataTable

    Sub LoadDepartemen()
        oDataDepartemen.Clear()
        oDataDepartemen = dataDepartemen.selectDataDepartemen
        SleDepartemen.Properties.DataSource = oDataDepartemen
        SleDepartemen.Properties.DisplayMember = "Departemen"
        SleDepartemen.Properties.ValueMember = "kodeDepartemen"
    End Sub


    Private Sub FormMutasi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LTanggal.Text = Format(Date.Now, "dd/MM/yyyy")
        LOperator.Text = ModKoneksi.namaOperator

        txtNamaBarang.Enabled = False
        txtHarga.Enabled = False
        txtSatuan.Enabled = False
        txtStok.Enabled = False
        LoadDepartemen()
        LoadDataMutasi()

        PanelControl1.Visible = False
    End Sub

    Private Sub btnLangsung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddDepartemen.Click
        FormAddDepartemen.X = "1"
        FormAddDepartemen.ShowDialog()
    End Sub

    Private Sub txtKodeBarang_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtKodeBarang.KeyDown
        If e.KeyCode = Keys.F1 Then
            FormDaftarBarang.X = "2"
            FormDaftarBarang.ShowDialog()
        ElseIf e.KeyCode = Keys.Enter Then
            If txtKodeBarang.Text = "" And OdataMutasi.Rows.Count <> 0 Then
                PanelControl1.Visible = True
                txtCatatan.Focus()
            Else
                OdataBarang.Clear()
                OdataBarang = dataBarang.selectBarangbyKode(txtKodeBarang.Text)
                If OdataBarang.Rows.Count <> 0 Then
                    txtNamaBarang.Text = OdataBarang.Rows(0).Item(3)
                    txtSatuan.Text = OdataBarang.Rows(0).Item(4)
                    txtHarga.Text = Format(CLng(OdataBarang.Rows(0).Item(5)), "###,###,##0")
                    txtStok.Text = OdataBarang.Rows(0).Item(6)
                    txtQty.Focus()
                Else
                    MsgBox("Barang Tidak Ditemukan", MsgBoxStyle.Information + vbOKOnly, "Informasi")
                    CleanBarang()
                End If
            End If
        End If
    End Sub
    Sub CleanBarang()
        txtKodeBarang.Text = ""
        txtNamaBarang.Text = ""
        txtSatuan.Text = ""
        txtHarga.Text = ""
        txtStok.Text = ""
        txtQty.Text = ""

        txtKodeBarang.Focus()
    End Sub
    Private Sub SleDepartemen_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles SleDepartemen.EditValueChanged
        txtKodeBarang.Focus()
    End Sub

    Dim OdataMutasi As New DataTable
    Dim OrowMutasi As DataRow
    Dim index As Integer

    Public Sub LoadDataMutasi()
        ModKoneksi.BukaKoneksi()
        OdataMutasi.Clear()
        SetTabelmutasi()
        ModKoneksi.TutupKoneksi()
    End Sub

    Sub SetTabelmutasi()
        OdataMutasi.Rows.Clear()
        OdataMutasi.Columns.Clear()
        OdataMutasi.Columns.Add(New DataColumn("Kode Barang", GetType(String)))
        OdataMutasi.Columns.Add(New DataColumn("Nama Barang", GetType(String)))
        OdataMutasi.Columns.Add(New DataColumn("Satuan", GetType(String)))
        OdataMutasi.Columns.Add(New DataColumn("Harga", GetType(Long)))
        OdataMutasi.Columns.Add(New DataColumn("Qty", GetType(Integer)))
        OdataMutasi.Columns.Add(New DataColumn("SubTotal", GetType(Integer)))
        OdataMutasi.Columns.Add(New DataColumn("Stok", GetType(Integer)))
        OdataMutasi.Columns.Add(New DataColumn("Nomer", GetType(Integer)))
        BindingSource1.DataSource = OdataMutasi
        GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
    End Sub

    Private Function BarangAda(ByVal key As String)
        Dim ketemu As Boolean = False
        Dim index As String = -1
        Dim i As Integer
        For i = 0 To OdataMutasi.Rows.Count - 1
            If ketemu = False And OdataMutasi.Rows(i).Item(0) = key Then
                ketemu = True
                index = i
                Exit For
            End If
        Next
        Return index
    End Function

    Sub SetNewRowMutasi()
        Dim jml As Integer
        Dim SubTotal As Long
        SubTotal = 0
        SubTotal = CLng(txtHarga.Text) * CLng(txtQty.Text)
        jml = OdataMutasi.Rows.Count + 1

        index = BarangAda(txtKodeBarang.Text)
        If index = -1 Then
            OrowMutasi = OdataMutasi.NewRow
            OrowMutasi(0) = txtKodeBarang.Text
            OrowMutasi(1) = txtNamaBarang.Text
            OrowMutasi(2) = txtSatuan.Text
            OrowMutasi(3) = CLng(txtHarga.Text)
            OrowMutasi(4) = txtQty.Text
            OrowMutasi(5) = CLng(SubTotal)
            OrowMutasi(6) = txtStok.Text
            OrowMutasi(7) = jml
            OdataMutasi.Rows.Add(OrowMutasi)
            BindingSource1.DataSource = OdataMutasi
        Else
            GridControl1.Refresh()
            MsgBox("Barang Sudah ada", MsgBoxStyle.Critical, "Informasi")
        End If
        setGrid()
        Hitung()
    End Sub
    Dim total As Long

    Sub Hitung()
        Dim Subtotal, Stotal As Long
        Subtotal = 0
        Stotal = 0
        total = 0
        For i As Integer = 0 To OdataMutasi.Rows.Count - 1
            Subtotal = OdataMutasi.Rows(i).Item(5)
            Stotal = Subtotal + Subtotal
        Next
        total = Stotal
        lbTotal.Text = total
    End Sub

    Sub setGrid()
        Try
            GridView1.OptionsBehavior.Editable = False
            GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
            GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus

            For i = 0 To GridView1.Columns.Count - 1
                GridView1.Columns(i).OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            Next

            For i = 0 To GridView1.Columns.Count - 1
                GridView1.Columns(i).BestFit()
            Next
            GridView1.Columns(3).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            GridView1.Columns(3).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
            GridView1.Columns(3).DisplayFormat.FormatString = "c"
            GridView1.Columns(5).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            GridView1.Columns(5).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
            GridView1.Columns(5).DisplayFormat.FormatString = "c"

            GridView1.Columns(7).Visible = False
        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtQty_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtQty.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtKodeBarang.Text = "" Then
                MsgBox("Barang Belum di Pilih", MsgBoxStyle.Information + vbOKOnly, "Informasi")
            ElseIf txtQty.Text = "" Then
                MsgBox("Qty Masih Kosong", MsgBoxStyle.Information + vbOKOnly, "Informasi")
            Else
                SetNewRowMutasi()
                CleanBarang()
            End If
        End If
    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        PanelControl1.Visible = False
        CleanBarang()
    End Sub

    Sub Clean()
        CleanBarang()
        LoadDataMutasi()
        LoadDepartemen()
        PanelControl1.Visible = False
        SleDepartemen.Focus()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        ' MsgBox(SearchLookUpEdit1View.GetFocusedDataRow(0).ToString)
        DataStore.AddStore(txtCatatan.Text, total, SearchLookUpEdit1View.GetFocusedDataRow(0).ToString, OdataMutasi)
        cetakLaporan(OdataMutasi)
        Clean()
    End Sub

    Sub cetakLaporan(ByVal odata As DataTable)
        Dim laporan As New LaporanDetilTransferStok
        Dim Tool As ReportPrintTool = New ReportPrintTool(laporan)
        Dim oDataSet As New DataSet
        Dim oDataAdapter As New OdbcDataAdapter
        Dim i As Integer
        Dim total As Long
        Dim currentTime As System.DateTime = System.DateTime.Now

        If oDataSet.Tables.Count <> 0 Then
            oDataSet.Tables.Remove("Table1")
        End If

        For i = 0 To odata.Rows.Count - 1
            total = total + odata.Rows(i).Item(5)
        Next

        oDataSet.Tables.Add(odata.Copy)

        laporan.DataSource = oDataSet
        laporan.DataAdapter = oDataAdapter
        laporan.DataMember = "Table1"


        laporan.lbKodeBarang.DataBindings.Add("Text", Nothing, "Kode Barang")
        laporan.lbNamaBarang.DataBindings.Add("Text", Nothing, "Nama Barang")
        laporan.lbQty.DataBindings.Add("Text", Nothing, "Qty")
        laporan.LbSatuan1.DataBindings.Add("Text", Nothing, "Satuan")
        laporan.lbStok.DataBindings.Add("Text", Nothing, "Stok Riil")
        laporan.lbSatuan2.DataBindings.Add("Text", Nothing, "Satuan")
        laporan.lbHarga.DataBindings.Add("Text", Nothing, "Harga", "{0:c2}")
        laporan.lbJumlah.DataBindings.Add("Text", Nothing, "SubTotal")

        laporan.lbTotal.Text = total
        laporan.lbJmlBarang.Text = odata.Rows.Count

        Tool.ShowPreview()
    End Sub
End Class