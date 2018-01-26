Imports System.Data.Odbc
Imports DevExpress.XtraReports.UI
Public Class FormAddRekonsiliasiBank
    Dim SaldoKas As Integer
    Dim SaldoRekKoran As Integer
    Dim SelisihAwal As Double
    Dim tanggal1(2) As String
    Dim TanggalGabung1 As String
    Dim Tanggal2(3) As String
    Dim TanggalGabung2 As String
    Dim tanggal3(3) As String
    Dim TanggalGabung3 As String
    Dim oDataTabelUnboundTA As New DataTable
    Dim oDataTabelUnboundDIT As New DataTable
    Dim oDataTabelUnboundOC As New DataTable
    Dim oDataTabelUnboundForCetak As New DataTable
    Dim OrowCetak As DataRow
    Dim OrowTa As DataRow
    Dim OrowDIT As DataRow
    Dim OrowOc As DataRow



    Sub setTabelUnboundTA()
        Try
            oDataTabelUnboundTA.Rows.Clear()
            oDataTabelUnboundTA.Columns.Clear()
            oDataTabelUnboundTA.Clear()
            oDataTabelUnboundTA.Columns.Add(New DataColumn("Tanggal", GetType(String))) '0
            oDataTabelUnboundTA.Columns.Add(New DataColumn("Bukti Transaksi", GetType(String))) '1
            oDataTabelUnboundTA.Columns.Add(New DataColumn("Keterangan", GetType(String))) '2
            oDataTabelUnboundTA.Columns.Add(New DataColumn("Akun", GetType(String))) '3
            oDataTabelUnboundTA.Columns.Add(New DataColumn("Debet ", GetType(Long))) '4
            oDataTabelUnboundTA.Columns.Add(New DataColumn("Kredit ", GetType(Long))) '5
            BindingSource1.DataSource = oDataTabelUnboundTA
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Sub setTabelUnboundDIT()
        Try
            oDataTabelUnboundDIT.Rows.Clear()
            oDataTabelUnboundDIT.Columns.Clear()
            oDataTabelUnboundDIT.Clear()
            oDataTabelUnboundDIT.Columns.Add(New DataColumn("Tanggal", GetType(String))) '0
            oDataTabelUnboundDIT.Columns.Add(New DataColumn("Keterangan", GetType(String))) '1
            oDataTabelUnboundDIT.Columns.Add(New DataColumn("Nominal", GetType(Long))) '2
            BindingSource2.DataSource = oDataTabelUnboundDIT
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub setTabelUnboundDITForCetak()
        Try
            oDataTabelUnboundforcetak.Rows.Clear()
            oDataTabelUnboundForCetak.Columns.Clear()
            oDataTabelUnboundForCetak.Clear()
            oDataTabelUnboundForCetak.Columns.Add(New DataColumn("Judul", GetType(String))) '0
            oDataTabelUnboundForCetak.Columns.Add(New DataColumn("Tanggal", GetType(String))) '1
            oDataTabelUnboundForCetak.Columns.Add(New DataColumn("Jumlah", GetType(String))) '2
            oDataTabelUnboundForCetak.Columns.Add(New DataColumn("Subtotal", GetType(String))) '3
            'BindingSource2.DataSource = oDataTabelUnboundDIT
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub setTabelUnboundOC()
        Try
            oDataTabelUnboundOC.Rows.Clear()
            oDataTabelUnboundOC.Columns.Clear()
            oDataTabelUnboundOC.Clear()
            oDataTabelUnboundOC.Columns.Add(New DataColumn("Tanggal", GetType(String))) '0
            oDataTabelUnboundOC.Columns.Add(New DataColumn("Keterangan", GetType(String))) '1
            oDataTabelUnboundOC.Columns.Add(New DataColumn("Nominal", GetType(Long))) '2
            BindingSource3.DataSource = oDataTabelUnboundOC
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub addRowTA(ByVal tanggal As String, ByVal buktiTrx As String, ByVal keterangan As String, ByVal Akun As String, ByVal Debet As Long, ByVal Kredit As Long)
        OrowTa = oDataTabelUnboundTA.NewRow
        OrowTa(0) = tanggal
        OrowTa(1) = buktiTrx
        OrowTa(2) = keterangan
        OrowTa(3) = Akun
        OrowTa(4) = Debet
        OrowTa(5) = Kredit
        oDataTabelUnboundTA.Rows.Add(OrowTa)
        setGridTA()
    End Sub

    Sub addRowCetak(ByVal keterangan As String, ByVal tanggal As String, ByVal Jumlah As String, ByVal total As String)
        OrowCetak = oDataTabelUnboundForCetak.NewRow
        OrowCetak(0) = keterangan
        OrowCetak(1) = tanggal
        OrowCetak(2) = Jumlah
        OrowCetak(3) = total
        oDataTabelUnboundForCetak.Rows.Add(OrowCetak)
    End Sub

    Sub addRowDIT(ByVal Tanggal As String, ByVal Keterangan As String, ByVal nominal As Long)
        OrowDIT = oDataTabelUnboundDIT.NewRow
        OrowDIT(0) = Tanggal
        OrowDIT(1) = Keterangan
        OrowDIT(2) = nominal
        oDataTabelUnboundDIT.Rows.Add(OrowDIT)
        setGridDIT()
    End Sub

    Sub addRowOc(ByVal Tanggal As String, ByVal Keterangan As String, ByVal nominal As Long)
        OrowOc = oDataTabelUnboundOC.NewRow
        OrowOc(0) = Tanggal
        OrowOc(1) = Keterangan
        OrowOc(2) = nominal
        oDataTabelUnboundOC.Rows.Add(OrowOc)
        setGridOc()
    End Sub


    Private Sub setGridTA()
        Try
            GridView1.OptionsBehavior.Editable = False
            GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
            GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus

            For i = 0 To GridView1.Columns.Count - 1
                GridView1.Columns(i).BestFit()
            Next
            'GridView1.Columns(4).Summary.Clear()
            'GridView1.Columns(5).Summary.Clear()
            'GridView1.Columns(4).Summary.Add(DevExpress.Data.SummaryItemType.Sum, "Debet", "{0:c2}")
            'GridView1.Columns(4).Summary.Add(DevExpress.Data.SummaryItemType.Sum, "Kredit", "{0:c2}")
            GridView1.Columns(4).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
            GridView1.Columns(4).DisplayFormat.FormatString = "c"
            GridView1.Columns(5).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
            GridView1.Columns(5).DisplayFormat.FormatString = "c"
        Catch ex As Exception

        End Try
    End Sub

    Private Sub setGridDIT()
        Try
            GridView2.OptionsBehavior.Editable = False
            GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
            GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus

            For i = 0 To GridView2.Columns.Count - 1
                GridView2.Columns(i).BestFit()
            Next
            'GridView1.Columns(2).Summary.Clear()
            'GridView1.Columns(1).Summary.Add(DevExpress.Data.SummaryItemType.Sum, "Nominal", "{0:c2}")
            GridView2.Columns(2).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
            GridView2.Columns(2).DisplayFormat.FormatString = "c"
        Catch ex As Exception

        End Try
    End Sub

    Private Sub setGridOc()
        Try
            GridView3.OptionsBehavior.Editable = False
            GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
            GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus

            For i = 0 To GridView3.Columns.Count - 1
                GridView3.Columns(i).BestFit()
            Next
            'GridView1.Columns(2).Summary.Clear()
            'GridView1.Columns(1).Summary.Add(DevExpress.Data.SummaryItemType.Sum, "Nominal", "{0:c2}")
            GridView3.Columns(2).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
            GridView3.Columns(2).DisplayFormat.FormatString = "c"
        Catch ex As Exception

        End Try
    End Sub

    Sub UpdateSelisihTrxAuto()
        Dim i As Integer
        'LbSelisihSetTrxAuto.Text = 0

        For i = 0 To oDataTabelUnboundTA.Rows.Count - 1
            LbSelisihAwal.Text = CLng(LbSelisihAwal.Text) + oDataTabelUnboundTA.Rows(i).Item(4) - oDataTabelUnboundTA.Rows(i).Item(5)
        Next

        LbSelisihAwal.Text = Format(CDbl(LbSelisihAwal.Text), "###,###,##0.00")
    End Sub

    Sub UpdateSelisihDIT()
        Dim i As Integer
        For i = 0 To oDataTabelUnboundDIT.Rows.Count - 1
            LbSelisihSetTrxAuto.Text = CLng(LbSelisihSetTrxAuto.Text) - oDataTabelUnboundDIT.Rows(i).Item(2)
        Next
        LbSelisihSetTrxAuto.Text = Format(CDbl(LbSelisihSetTrxAuto.Text), "###,###,##0.00")
    End Sub

    Sub UpdateSelisihOc()
        Dim i As Integer
        For i = 0 To oDataTabelUnboundOC.Rows.Count - 1
            LbSelisihAkhir.Text = CLng(LbSelisihAkhir.Text) + oDataTabelUnboundOC.Rows(i).Item(2)
        Next
        LbSelisihAkhir.Text = Format(CDbl(LbSelisihAkhir.Text), "###,###,##0.00")
    End Sub


    Private Sub FormAddRekonsiliasiBank_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        setTabelUnboundTA()
        setTabelUnboundDIT()
        setTabelUnboundOC()
        setGridDIT()
        setGridTA()
        setGridOc()
        setTabelUnboundDITForCetak()


    End Sub

    Private Sub XtraTabControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XtraTabControl1.Click

    End Sub

    Private Sub BtnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNext.Click
        If CbBank.Text = "" Then
            MsgBox("Bank Belum Dipilih", MsgBoxStyle.Critical, "Peringatan")
        ElseIf TxtkasPerusahaan.Text = "" Then
            MsgBox("Kas Perusahaan Belum Terisi", MsgBoxStyle.Critical, "Peringatan")
        ElseIf TxtRekKoran.Text = "" Then
            MsgBox("Rekening Koran Belum Terisi", MsgBoxStyle.Critical, "Peringatan")
        Else
            SelisihAwal = CLng(TxtRekKoran.Text) - CLng(TxtkasPerusahaan.Text)
            LbSelisihAwal.Text = Format(CLng(SelisihAwal), "###,###,##0")
            XtraTabControl1.SelectedTabPageIndex = 1
            TxtTglTransAuto.Focus()
        End If

    End Sub

    Private Sub BtnSimpanTransAuto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpanTransAuto.Click
        If MsgBox("Apakah Ada Jurnal Yang Ingin Di Inputkan Lagi?", vbYesNo, "Peringatan") = vbNo Then
            UpdateSelisihTrxAuto()
        End If

    End Sub

    Private Sub BtnSimpanTransAuto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles BtnSimpanTransAuto.KeyDown

    End Sub

    Private Sub txtkredit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtkredit.KeyDown
        If e.KeyCode = Keys.Enter Then
            If TxtTglTransAuto.Text = "" Then
                MsgBox("Tanggal Belum Terisi", MsgBoxStyle.Critical, "Peringatan")
            ElseIf TxtBuktiTrxAuto.Text = "" Then
                MsgBox("Bukti Transaksi Belum Terisi", MsgBoxStyle.Critical, "Peringatan")
            ElseIf txtKetTrxAuto.Text = "" Then
                MsgBox("Keterangan Belum Terisi", MsgBoxStyle.Critical, "Peringatan")
            ElseIf cbakun.Text = "" Then
                MsgBox("Akun Belum Dipilih", MsgBoxStyle.Critical, "Peringatan")
            ElseIf txtdebet.Text = "" Then
                MsgBox("Nominal Debet Belum Terisi Belum Terisi", MsgBoxStyle.Critical, "Peringatan")
            ElseIf txtkredit.Text = "" Then
                MsgBox("Nominal Kredit Belum Terisi Belum Terisi", MsgBoxStyle.Critical, "Peringatan")
            Else
                tanggal1 = TxtTglTransAuto.Text.Split("/")
                TanggalGabung1 = tanggal1(1) & "/" & tanggal1(0) & "/" & tanggal1(2)
                addRowTA(TanggalGabung1, TxtBuktiTrxAuto.Text, txtKetTrxAuto.Text, cbakun.Text, txtdebet.Text, txtkredit.Text)
                setGridTA()
                txtdebet.Text = ""
                txtkredit.Text = ""
                cbakun.Focus()
            End If
        End If
    End Sub

    Private Sub TxtNominalDit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtNominalDit.KeyDown

        If e.KeyCode = Keys.Enter Then
            If TxtTglDit.Text = "" Then
                MsgBox("Tanggal Belum Terisi", MsgBoxStyle.Critical, "Peringatan")
            ElseIf TxtKetDit.Text = "" Then
                MsgBox("Keterangan Belum Terisi", MsgBoxStyle.Critical, "Peringatan")
            ElseIf TxtNominalDit.Text = "" Then
                MsgBox("Nominal Belum Terisi", MsgBoxStyle.Critical, "Peringatan")
            Else
                Tanggal2 = TxtTglDit.Text.Split("/")
                TanggalGabung2 = Tanggal2(1) & "/" & Tanggal2(0) & "/" & Tanggal2(2)
                addRowDIT(TanggalGabung2, TxtKetDit.Text, TxtNominalDit.Text)
                setGridDIT()
                UpdateSelisihDIT()
                TxtTglDit.Focus()
            End If
        End If
    End Sub

    Private Sub TxtTglTransAuto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtTglTransAuto.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtBuktiTrxAuto.Focus()
        End If
    End Sub

    Private Sub TxtBuktiTrxAuto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtBuktiTrxAuto.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtKetTrxAuto.Focus()
        End If
    End Sub

    Private Sub txtKetTrxAuto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtKetTrxAuto.KeyDown
        If e.KeyCode = Keys.Enter Then
            cbakun.Focus()
        End If
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnKembaliAwal.Click
        XtraTabControl1.SelectedTabPageIndex = 0
    End Sub

    Private Sub BtnNextTA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNextTA.Click
        XtraTabControl1.SelectedTabPageIndex = 2
        LbSelisihSetTrxAuto.Text = LbSelisihAwal.Text
    End Sub

    Private Sub BtnNextOC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNextOC.Click
        XtraTabControl1.SelectedTabPageIndex = 3
        LbSelisihAkhir.Text = LbSelisihSetTrxAuto.Text

    End Sub

    Private Sub TxtNominalCekBeredar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtNominalCekBeredar.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtTglCekBeredar.Text = "" Then
                MsgBox("Tanggal Belum Terisi", MsgBoxStyle.Critical, "Peringatan")
            ElseIf TxtKetCekBeredar.Text = "" Then
                MsgBox("Keterangan Belum Terisi", MsgBoxStyle.Critical, "Peringatan")
            ElseIf TxtNominalCekBeredar.Text = "" Then
                MsgBox("Nominal Belum Terisi", MsgBoxStyle.Critical, "Peringatan")
            Else
                tanggal3 = txtTglCekBeredar.Text.Split("/")
                TanggalGabung3 = tanggal3(1) & "/" & tanggal3(0) & "/" & tanggal3(2)
                addRowOc(TanggalGabung3, TxtKetCekBeredar.Text, TxtNominalCekBeredar.Text)
                setGridOc()
                UpdateSelisihOc()
                txtTglCekBeredar.Focus()
            End If
        End If
    End Sub

    Private Sub TxtSebelumnyaDIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSebelumnyaDIT.Click
        XtraTabControl1.SelectedTabPageIndex = 1
    End Sub

    Private Sub btnsebelumyaCekBeredar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsebelumyaCekBeredar.Click
        XtraTabControl1.SelectedTabPageIndex = 2
    End Sub

    'Private Sub cetakLaporan(ByVal odata As DataTable)
    '    Dim sum As Long
    '    Dim sum1 As Long
    '    '   Dim Report As New LaporanRekonsiliasiBank
    '    Dim Tool As ReportPrintTool = New ReportPrintTool(Report)
    '    Dim oDataSet As New DataSet
    '    Dim oDataAdapter As New OdbcDataAdapter
    '    Dim i As Integer

    '    sum = 0

    '    Try
    '        If oDataSet.Tables.Count <> 0 Then
    '            oDataSet.Tables.Remove("Table1")
    '        End If
    '        oDataSet.Tables.Add(odata.Copy)

    '        Report.DataSource = oDataSet
    '        Report.DataAdapter = oDataAdapter
    '        Report.DataMember = "Table1"

    '        'Report.lbSum.Text = FormatCurrency(sum, 2, 0, 0)


    '        '' Report.lbPrintBy.Text = ModKoneksi.namaOperator
    '        Report.LbTgl.Text = Date.Now.ToString("dd MM yyyy")
    '        'Report.lbFilterDate.Text = txttanggal.Text '("dd MM yyyy")
    '        'Report.lbFilterDate2.Text = txttanggal2.Text '("dd MM yyyy")

    '        Report.lbNamaBank.Text = CbBank.Text
    '        Report.TxtJudul.DataBindings.Add("Text", Nothing, "Judul")
    '        Report.TxtTanggal.DataBindings.Add("Text", Nothing, "Tanggal")
    '        Report.TxtJumlah.DataBindings.Add("Text", Nothing, "Jumlah")
    '        Report.TxtSubtotal.DataBindings.Add("Text", Nothing, "Subtotal")
    '        ' Report.lbTotalDIT.Text = FormatCurrency(sum, 2, 0, 0)

    '        Tool.ShowPreview()
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    Sub forCetak()
        Dim i As Integer
        Dim x As Integer
        Dim TotalDIT As Integer = 0
        Dim SubtotalSetelahDIT As Integer = 0
        Dim TotalOc As Integer = 0
        Dim selisihKasSetRekonsiliasi As Integer = 0

        addRowCetak("Saldo Akhir Buku kas Perusahaan", "", "", TxtkasPerusahaan.Text)
        addRowCetak("", "", "", "")
        addRowCetak("Dikurangi Setoran Dalam Perjalanan", "", "", "")
        addRowCetak("", "Tanggal", "Jumlah", "")
        For i = 0 To oDataTabelUnboundDIT.Rows.Count - 1
            addRowCetak("", oDataTabelUnboundDIT.Rows(i).Item(1), Format(oDataTabelUnboundDIT.Rows(i).Item(2), "###,###,##0"), "")
            TotalDIT += oDataTabelUnboundDIT.Rows(i).Item(2)
            SubtotalSetelahDIT = TotalDIT - CLng(LbSelisihAwal.Text)
        Next
        addRowCetak("", "Total Setoran Dalam Perjalanan", "", Format(TotalDIT, "###,###,##0"))
        addRowCetak("Subtotal", "", "", Format(SubtotalSetelahDIT, "###,###,##0"))
        addRowCetak("", "", "", "")
        addRowCetak("Ditambah Cek Beredar", "", "", "")
        addRowCetak("", "Nomor Cek", "Jumlah", "")
        For x = 0 To oDataTabelUnboundOC.Rows.Count - 1
            addRowCetak("", oDataTabelUnboundOC.Rows(x).Item(1), Format(oDataTabelUnboundOC.Rows(x).Item(2), "###,###,##0"), "")
            TotalOc += oDataTabelUnboundOC.Rows(x).Item(2)
        Next
        addRowCetak("Jumlah cek Beredar", "", "", Format(TotalOc, "###,###,##0"))
        addRowCetak("", "", "", "")
        selisihKasSetRekonsiliasi = CLng(TxtkasPerusahaan.Text) - TotalDIT + TotalOc
        addRowCetak("Saldo Akhir Buku Kas Setelah Rekonsiliasi", "", "", Format(selisihKasSetRekonsiliasi, "###,###,##0"))
        addRowCetak("Saldo Akhir" + " " + CbBank.Text + " " + "Setelah Rekonsiliasi", "", "", Format(CLng(TxtRekKoran.Text), "###,###,##0"))
        addRowCetak("Selisih", "", "", Format(CLng(LbSelisihAkhir.Text), "###,###,##0"))
    End Sub

    Private Sub BtnCetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCetak.Click
        forCetak()
        '   cetakLaporan(oDataTabelUnboundForCetak)
    End Sub

    Private Sub TxtTglDit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtTglDit.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtKetDit.Focus()
        End If
    End Sub

    Private Sub txtTglCekBeredar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTglCekBeredar.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtKetCekBeredar.Focus()
        End If
    End Sub

    Private Sub TxtKetDit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtKetDit.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtNominalDit.Focus()
        End If
    End Sub

    Private Sub TxtKetCekBeredar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtKetCekBeredar.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtNominalCekBeredar.Focus()
        End If
    End Sub
End Class