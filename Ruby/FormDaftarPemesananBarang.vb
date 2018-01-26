Imports System.Data.Odbc
Imports DevExpress.XtraReports.UI

Public Class FormDaftarPemesananBarang
    Dim dataPemesanan As New ClassPemesanan
    Dim odataPemesanan As New DataTable

    Dim tglAwal(3) As String
    Dim tglAkhir(3) As String
    Dim tanggalAwal As String
    Dim tanggalAkhir As String

    Sub ConvertTanggal()
        tglAwal = txtTglAwal.Text.Split("/")
        tglAkhir = txtTglAkhir.Text.Split("/")

        tanggalAwal = tglAwal(1) & "/" & tglAwal(0) & "/" & tglAwal(2)
        tanggalAkhir = tglAkhir(1) & "/" & tglAkhir(0) & "/" & tglAkhir(2)
    End Sub

    Sub loadData()
        odataPemesanan.Clear()
        odataPemesanan = dataPemesanan.selectDataPemesananByDate(tanggalAwal, tanggalAkhir)
        BindingSource1.DataSource = odataPemesanan
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


            GridView1.Columns(0).Caption = "Kode Pemesanan"
            GridView1.Columns(1).Caption = "Tanggal Order"
            GridView1.Columns(2).Caption = "Nama Suplier"
            GridView1.Columns(3).Caption = "Nama Operator"
            GridView1.Columns(4).Caption = "Keterangan"
            GridView1.Columns(5).Caption = "Total"

            GridView1.Columns(5).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            GridView1.Columns(5).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
            GridView1.Columns(5).DisplayFormat.FormatString = "c"

        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub GridControl1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl1.DoubleClick
        FormDetilPO.kodePO = GridView1.GetFocusedDataRow.Item(0)
        FormDetilPO.NamaSuplier = GridView1.GetFocusedDataRow.Item(2)
        FormDetilPO.ShowDialog()
    End Sub

    Private Sub GridControl1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl1.Load
        setGrid()
    End Sub

    Private Sub btnProses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProses.Click
        ConvertTanggal()
        loadData()
        setGrid()

        Hitung()
    End Sub

    Dim totalHarga As Long
    Sub Hitung()
        Dim harga As Long
        harga = 0
        totalHarga = 0
        For i As Integer = 0 To odataPemesanan.Rows.Count - 1
            harga = harga + odataPemesanan.Rows(i).Item(5)
        Next

        totalHarga = harga
        lbTotalHarga.Text = FormatCurrency(totalHarga)
    End Sub

    Private Sub FormDaftarPemesananBarang_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtTglAwal.Text = Format(Now, "dd/MM/yyyy")
        txtTglAkhir.Text = Format(Now, "dd/MM/yyyy")
    End Sub

    Sub cetakLaporan(ByVal odata As DataTable)
        Dim laporan As New LaporanDaftarPemesanan
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

        laporan.lbTanggal.DataBindings.Add("Text", Nothing, "TglPO")
        laporan.lbNamaSuplier.DataBindings.Add("Text", Nothing, "NamaSuplier")
        laporan.lbNamaOperator.DataBindings.Add("Text", Nothing, "Nama")
        laporan.lbKeterangan.DataBindings.Add("Text", Nothing, "keterangan")
        laporan.lbTotal.DataBindings.Add("Text", Nothing, "Total", "{0:c2}")

        laporan.lbSum.Text = FormatCurrency(totalOrder, 2, 0, 0)
        laporan.lbTglAwal.Text = tanggalAwal
        laporan.lbtglAkhir.Text = tanggalAkhir

        Tool.ShowPreview()
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        cetakLaporan(odataPemesanan)
    End Sub

    Private Sub txtTglAwal_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTglAwal.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtTglAkhir.Focus()
        End If
    End Sub

    Private Sub txtTglAkhir_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTglAkhir.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnProses.PerformClick()
        End If
    End Sub
End Class