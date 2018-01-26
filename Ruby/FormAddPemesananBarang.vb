Imports System.Data.Odbc
Imports DevExpress.XtraReports.UI

Public Class FormAddPemesananBarang
    Dim dataPemesanan As New ClassPemesanan
    Dim odataPemesanan As New DataTable
    Dim OrowDataPemesanan As DataRow

    Dim odataBarang As New DataTable
    Dim odataSuplier As New DataTable

    Dim index As Integer

    Public kodePO As String
    Public KodeSuplier As String
    Public X As String


    Public Sub loadDataSuplier()
        odataSuplier.Clear()
        odataSuplier = dataPemesanan.SelectSuplier
        SearchLookUpEdit1.Properties.DataSource = odataSuplier
        SearchLookUpEdit1.Properties.DisplayMember = "NamaSuplier"
        SearchLookUpEdit1.Properties.ValueMember = "KodeSuplier"
    End Sub

    Sub LoadBarangBySuplier()
        odataBarang.Clear()
        odataBarang = dataPemesanan.SelectBarangBySuplier(KodeSuplier)
        BSDataBarang.DataSource = odataBarang
        setGrid1()
    End Sub

    Sub setGrid1()
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
            GridView1.Columns(4).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            GridView1.Columns(4).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
            GridView1.Columns(4).DisplayFormat.FormatString = "c"

            GridView1.Columns(5).Visible = False
        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FormAddPemesananBarang_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        loadDataSuplier()

        txtTglKirim.Text = Format(Date.Now, "dd/MM/yyyy")
        If X = "1" Then
            LoadDataPemesanan()
        ElseIf X = "2" Then
            LoadDataPemesanan()
            LoadDetilPO()
        End If
    End Sub

    Private Sub btnRegisterBarang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegisterBarang.Click
        FormDaftarBarang.X = "1"
        FormDaftarBarang.KodeSuplier = KodeSuplier
        FormDaftarBarang.ShowDialog()
    End Sub

    Private Sub GridControl1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl1.DoubleClick
        FormAddBarangPesanan.X = "1"
        FormAddBarangPesanan.txtKodeBarang.Text = GridView1.GetFocusedDataRow.Item(1)
        FormAddBarangPesanan.txtNamaBarang.Text = GridView1.GetFocusedDataRow.Item(2)
        FormAddBarangPesanan.txtSatuan.Text = GridView1.GetFocusedDataRow.Item(3)
        FormAddBarangPesanan.txtHarga.Text = FormatNumber(GridView1.GetFocusedDataRow.Item(4))
        'Format(CLng(GridView1.GetFocusedDataRow.Item(4)), "###,###,##0")
        FormAddBarangPesanan.ShowDialog()
    End Sub


    Private Sub GridControl2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl2.DoubleClick
        FormAddBarangPesanan.X = "2"
        FormAddBarangPesanan.txtKodeBarang.Text = GridView2.GetFocusedDataRow.Item(0)
        FormAddBarangPesanan.txtNamaBarang.Text = GridView2.GetFocusedDataRow.Item(1)
        FormAddBarangPesanan.txtSatuan.Text = GridView2.GetFocusedDataRow.Item(2)
        FormAddBarangPesanan.txtHarga.Text = FormatNumber(GridView2.GetFocusedDataRow.Item(3))
        FormAddBarangPesanan.txtQty.Text = GridView2.GetFocusedDataRow.Item(4)
        FormAddBarangPesanan.txtKeterangan.Text = GridView2.GetFocusedDataRow.Item(6)
        'Format(CLng(GridView1.GetFocusedDataRow.Item(4)), "###,###,##0")
        FormAddBarangPesanan.ShowDialog()
    End Sub

    Private Sub GridControl1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl1.Load
        setGrid1()
    End Sub

    Public Sub LoadDataPemesanan()
        ModKoneksi.BukaKoneksi()
        odataPemesanan.Clear()
        SetTabelPemesanan()
        ModKoneksi.TutupKoneksi()
    End Sub

    Sub SetTabelPemesanan()
        odataPemesanan.Rows.Clear()
        odataPemesanan.Columns.Clear()
        odataPemesanan.Columns.Add(New DataColumn("Kode Barang", GetType(String)))
        odataPemesanan.Columns.Add(New DataColumn("Nama Barang", GetType(String)))
        odataPemesanan.Columns.Add(New DataColumn("Satuan", GetType(String)))
        odataPemesanan.Columns.Add(New DataColumn("Harga", GetType(Long)))
        odataPemesanan.Columns.Add(New DataColumn("Qty", GetType(Integer)))
        odataPemesanan.Columns.Add(New DataColumn("Subtotal", GetType(Long)))
        odataPemesanan.Columns.Add(New DataColumn("Keterangan", GetType(String)))
        odataPemesanan.Columns.Add(New DataColumn("Nomer", GetType(String)))
        BSBarangPesanan.DataSource = odataPemesanan
        GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
    End Sub

    Private Function BarangAda(ByVal key As String)
        Dim ketemu As Boolean = False
        Dim index As String = -1
        Dim i As Integer
        For i = 0 To odataPemesanan.Rows.Count - 1
            If ketemu = False And odataPemesanan.Rows(i).Item(0) = key Then
                ketemu = True
                index = i
                Exit For
            End If
        Next
        Return index
    End Function

    Sub SetNewRowDataPemesanan(ByVal KodeBarang As String, ByVal NamaBarang As String, ByVal Satuan As String, ByVal Harga As Long, ByVal Qty As Integer, ByVal SubTotal As Long, ByVal Ket As String)
        Dim jml As Integer

        jml = odataPemesanan.Rows.Count + 1

        index = BarangAda(KodeBarang)
        If index = -1 Then
            OrowDataPemesanan = odataPemesanan.NewRow
            OrowDataPemesanan(0) = KodeBarang
            OrowDataPemesanan(1) = NamaBarang
            OrowDataPemesanan(2) = Satuan
            OrowDataPemesanan(3) = Harga
            OrowDataPemesanan(4) = Qty
            OrowDataPemesanan(5) = SubTotal
            OrowDataPemesanan(6) = Ket
            OrowDataPemesanan(7) = jml
            odataPemesanan.Rows.Add(OrowDataPemesanan)
            BSBarangPesanan.DataSource = odataPemesanan
        Else
            GridControl2.Refresh()
            MsgBox("Barang Sudah ada", MsgBoxStyle.Critical, "Informasi")
        End If

        Hitung()
        setGrid2()
    End Sub

    Sub EditRowPemesanan(ByVal KodeBarang As String, ByVal Qty As Integer, ByVal SubTotal As Long, ByVal Ket As String)
        index = BarangAda(KodeBarang)

        odataPemesanan.Rows(index).Item(4) = Qty
        odataPemesanan.Rows(index).Item(5) = SubTotal
        odataPemesanan.Rows(index).Item(6) = Ket

        Hitung()
        setGrid2()
    End Sub

    Sub setGrid2()
        Try
            GridView2.OptionsBehavior.Editable = False
            GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
            GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus

            For i = 0 To GridView2.Columns.Count - 1
                GridView2.Columns(i).OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            Next

            For i = 0 To GridView2.Columns.Count - 1
                GridView2.Columns(i).BestFit()
            Next
            GridView2.Columns(3).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            GridView2.Columns(3).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
            GridView2.Columns(3).DisplayFormat.FormatString = "c"

            GridView2.Columns(5).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            GridView2.Columns(5).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
            GridView2.Columns(5).DisplayFormat.FormatString = "c"

            GridView2.Columns(7).Visible = False

        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub GridControl2_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl2.Load
        setGrid2()
    End Sub

    Dim total As Long
    Sub Hitung()
        Dim Subtotal, Stotal As Long
        Subtotal = 0
        Stotal = 0
        For i As Integer = 0 To odataPemesanan.Rows.Count - 1
            Subtotal = odataPemesanan.Rows(i).Item(5)
            Stotal = Subtotal + Subtotal
        Next
        total = Stotal
    End Sub
    Private Sub btnKredit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKredit.Click
        If X = "1" Then
            dataPemesanan.AddPemesananBarang(KodeSuplier, tangalGabung, txtKeterangan.Text, total, odataPemesanan)
            cetakLaporan(odataPemesanan)
            clean()
        ElseIf X = "2" Then
            dataPemesanan.EditPemesananBarang(kodePO, KodeSuplier, tangalGabung, txtKeterangan.Text, total, odataPemesanan)
            cetakLaporan(odataPemesanan)
            clean()
            Close()
        End If
    End Sub

    Dim tanggal(3) As String
    Public tangalGabung As String

    Private Sub txtTglKirim_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTglKirim.Click
        tanggal = txtTglKirim.Text.Split("/")
        tangalGabung = tanggal(1) & "/" & tanggal(0) & "/" & tanggal(2)
    End Sub

    Private Sub txtTglKirim_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTglKirim.KeyDown
        If e.KeyCode = Keys.Enter Then
            tanggal = txtTglKirim.Text.Split("/")
            tangalGabung = tanggal(1) & "/" & tanggal(0) & "/" & tanggal(2)
            txtKeterangan.Focus()
        End If
    End Sub

    Sub clean()
        loadDataSuplier()
        LoadBarangBySuplier()
        LoadDataPemesanan()
        txtTglKirim.Text = Format(Date.Now, "dd/MM/yyyy")
        txtKeterangan.Text = ""
    End Sub


    Private Sub SearchLookUpEdit1_EditValueChanged1(ByVal sender As Object, ByVal e As System.EventArgs) Handles SearchLookUpEdit1.EditValueChanged
        Try
            txtNamaSuplier.Text = SearchLookUpEdit1View.GetFocusedDataRow(1).ToString
            KodeSuplier = SearchLookUpEdit1View.GetFocusedDataRow(0).ToString
            LoadBarangBySuplier()
            txtTglKirim.Focus()
        Catch ex As Exception

        End Try
    End Sub

    Sub cetakLaporan(ByVal odata As DataTable)
        Dim laporan As New LaporanDetilPO
        Dim Tool As ReportPrintTool = New ReportPrintTool(laporan)
        Dim oDataSet As New DataSet
        Dim oDataAdapter As New OdbcDataAdapter
        Dim i As Integer
        Dim totalOrder As Long
        Dim currentTime As System.DateTime = System.DateTime.Now


        If oDataSet.Tables.Count <> 0 Then
            oDataSet.Tables.Remove("Table1")
        End If

        For i = 0 To odata.Rows.Count - 1
            totalOrder = totalOrder + odata.Rows(i).Item(5)
        Next

        oDataSet.Tables.Add(odata.Copy)

        laporan.DataSource = oDataSet
        laporan.DataAdapter = oDataAdapter
        laporan.DataMember = "Table1"

        laporan.lbNo.DataBindings.Add("Text", Nothing, "Nomer")
        laporan.lbNamaBarang.DataBindings.Add("Text", Nothing, "Nama Barang")
        laporan.lbQty.DataBindings.Add("Text", Nothing, "Qty")
        laporan.lbSatuan.DataBindings.Add("Text", Nothing, "Satuan")
        laporan.lbHarga.DataBindings.Add("Text", Nothing, "Harga", "{0:c2}")
        laporan.lbJumlah.DataBindings.Add("Text", Nothing, "Subtotal", "{0:c2}")

        laporan.lbTotal.Text = FormatCurrency(totalOrder, 2, 0, 0)

        Tool.ShowPreview()
    End Sub

    Dim odataDetilPO As New DataTable

    Sub LoadDetilPO()
        odataDetilPO.Clear()
        odataDetilPO = dataPemesanan.selectDetilPO(kodePO)

        For i As Integer = 0 To odataDetilPO.Rows.Count - 1
            SetNewRowDataPemesanan(odataDetilPO.Rows(i).Item(0), odataDetilPO.Rows(i).Item(1), odataDetilPO.Rows(i).Item(2), odataDetilPO.Rows(i).Item(3), odataDetilPO.Rows(i).Item(4), odataDetilPO.Rows(i).Item(5), odataDetilPO.Rows(i).Item(6))
        Next
    End Sub

    Private Sub txtNamaSuplier_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNamaSuplier.KeyDown
        If e.KeyCode = Keys.Enter Then

        End If
    End Sub

    Private Sub btnLangsung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLangsung.Click

    End Sub
End Class