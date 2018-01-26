Imports System.Data.Odbc
Imports DevExpress.XtraReports.UI

Public Class FormBukuBesar
    Dim oDataTabelUnbound As New DataTable
    Dim odataSaldoMasalalu As New DataTable
    Dim odataAkun As New DataTable
    Dim dataAkun As New ClassAkun
    Dim dataBukuBesar As New ClassBukuBesar
    Dim kodebaru(1000) As String
    Dim kodeAkun As String
    Dim odata As New DataTable
    Dim oRow As DataRow

    Private Sub loadAkun()
        Dim properties As DevExpress.XtraEditors.Repository.RepositoryItemComboBox = cbAkun.Properties
        Dim i As Integer

        properties.Items.Clear()
        odataAkun.Clear()
        odataAkun = dataAkun.selectAkun("1", "0")

        For i = 0 To odataAkun.Rows().Count() - 1
            kodebaru(i) = odataAkun.Rows(i).Item(0)
            properties.Items.Add(odataAkun.Rows(i).Item(0) & " - " & odataAkun.Rows(i).Item(5))
        Next
        properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
    End Sub
    Private Sub FormBukuBesar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadAkun()
        setTabelUnbound()

    End Sub
    Sub loadSaldoMasaLalu()
        Dim saldoML As Long

        saldoML = dataBukuBesar.selectSaldoAkunMasaLalu(cbTglDari.Text, cbTglSampai.Text, kodeAkun)
        oDataTabelUnbound.Clear()

        oRow = oDataTabelUnbound.NewRow
        oRow(0) = cbTglDari.Text
        oRow(1) = ""
        oRow(2) = "Saldo Awal"
        oRow(3) = ""
        oRow(4) = ""
        oRow(5) = Format(CLng(saldoML), "###,###,##0")

        oDataTabelUnbound.Rows.Add(oRow)
        GridControl1.Refresh()
    End Sub
    Sub setTabelUnbound()
        Try
            oDataTabelUnbound.Rows.Clear()
            oDataTabelUnbound.Columns.Clear()
            oDataTabelUnbound.Clear()

            oDataTabelUnbound.Columns.Add(New DataColumn("Tanggal", GetType(String))) '0
            oDataTabelUnbound.Columns.Add(New DataColumn("No Bukti", GetType(String))) '1
            oDataTabelUnbound.Columns.Add(New DataColumn("Keterangan", GetType(String))) '2
            oDataTabelUnbound.Columns.Add(New DataColumn("Debet", GetType(String))) '3
            oDataTabelUnbound.Columns.Add(New DataColumn("Kredit", GetType(String))) '4
            oDataTabelUnbound.Columns.Add(New DataColumn("Saldo", GetType(String))) '5
            BindingSource1.DataSource = oDataTabelUnbound
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub IsiData()
        Dim lastRow As Integer
        Dim saldo As Long
        odata.Clear()
        odata = dataBukuBesar.selectBukuBesarbyAkun(cbTglDari.Text, cbTglSampai.Text, kodeAkun)

        For i = 0 To odata.Rows.Count() - 1
            lastRow = oDataTabelUnbound.Rows.Count - 1
            saldo = CLng(oDataTabelUnbound.Rows(lastRow).Item(5)) + CLng(odata.Rows(i).Item(5))
            oRow = oDataTabelUnbound.NewRow
            oRow(0) = odata.Rows(i).Item(0)
            oRow(1) = odata.Rows(i).Item(2)
            oRow(2) = odata.Rows(i).Item(1)
            oRow(3) = Format(CLng(odata.Rows(i).Item(3)), "###,###,##0")
            oRow(4) = Format(CLng(odata.Rows(i).Item(4)), "###,###,##0")
            oRow(5) = Format(saldo, "###,###,##0")

            oDataTabelUnbound.Rows.Add(oRow)
            GridControl1.Refresh()
        Next
    End Sub
    Sub loadSaldoAkhir()
        Dim pemotong As Long
        Dim saldoAkhir As Long
        pemotong = 0

        For i = 0 To odata.Rows.Count - 1
            pemotong = pemotong + odata.Rows(i).Item(5)
        Next

        saldoAkhir = oDataTabelUnbound.Rows(0).Item(5) + pemotong

        oRow = oDataTabelUnbound.NewRow
        oRow(0) = cbTglSampai.Text
        oRow(1) = ""
        oRow(2) = "Saldo Akhir"
        oRow(3) = ""
        oRow(4) = ""
        oRow(5) = Format(CLng(saldoAkhir), "###,###,##0")

        oDataTabelUnbound.Rows.Add(oRow)
        GridControl1.Refresh()
    End Sub
    Private Sub GridControl1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl1.Load
        setTabelUnbound()
        setGrid()
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
            GridView1.Columns(4).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            GridView1.Columns(4).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
            GridView1.Columns(4).DisplayFormat.FormatString = "c"
            GridView1.Columns(5).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            GridView1.Columns(5).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
            GridView1.Columns(5).DisplayFormat.FormatString = "c"

        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub cbAkun_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbAkun.SelectedIndexChanged
        kodeAkun = kodebaru(cbAkun.SelectedIndex())
    End Sub

    Private Sub btnCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCari.Click
        loadSaldoMasaLalu()
        IsiData()
        loadSaldoAkhir()
    End Sub

    Sub cetakLaporan(ByVal odata As DataTable)
        Dim laporan As New LaporanBukuBesar
        Dim Tool As ReportPrintTool = New ReportPrintTool(laporan)
        Dim oDataSet As New DataSet
        Dim oDataAdapter As New OdbcDataAdapter
        Dim i As Integer
        Dim totalD, TotalK As Long
        Dim currentTime As System.DateTime = System.DateTime.Now

        If oDataSet.Tables.Count <> 0 Then
            oDataSet.Tables.Remove("Table1")
        End If

        'For i = 0 To odata.Rows.Count - 1
        '    totalD = totalD + odata.Rows(i).Item(3)
        '    TotalK = TotalK + odata.Rows(i).Item(4)
        'Next

        oDataSet.Tables.Add(odata.Copy)

        laporan.DataSource = oDataSet
        laporan.DataAdapter = oDataAdapter
        laporan.DataMember = "Table1"


        laporan.lbTgl.DataBindings.Add("Text", Nothing, "Tanggal")
        laporan.lbNoBukti.DataBindings.Add("Text", Nothing, "No Bukti")
        laporan.lbKet.DataBindings.Add("Text", Nothing, "Keterangan")
        laporan.lbDebet.DataBindings.Add("Text", Nothing, "Debet", "{0:c2}")
        laporan.lbKredit.DataBindings.Add("Text", Nothing, "Kredit", "{0:c2}")
        laporan.lbSaldo.DataBindings.Add("Text", Nothing, "Saldo", "{0:c2}")

        laporan.lbAkun.Text = cbAkun.Text
        laporan.lbTglAwal.Text = cbTglDari.Text
        laporan.lbtglAkhir.Text = cbTglSampai.Text

        'laporan.lbTotalD.Text = FormatCurrency(totalD)
        'laporan.lbTotalK.Text = FormatCurrency(TotalK)

        Tool.ShowPreview()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        cetakLaporan(oDataTabelUnbound)
    End Sub
End Class