Imports System.Data.Odbc
Imports DevExpress.XtraReports.UI

Public Class FormJurnalUmum
    Sub setView()
        'GridControl1.Width = 725
        'GridControl1.Height = 355
        '        GroupBox1.Top = GridControl1.Height + 10
        '       GroupBox1.Left = (FormUtama.Width / 2) - (GroupBox1.Width / 2)
    End Sub
    Sub loadCombo()
        ComboBoxEdit1.Properties.Items.Clear()
        ComboBoxEdit1.Properties.Items.Add("Januari")
        ComboBoxEdit1.Properties.Items.Add("Februari")
        ComboBoxEdit1.Properties.Items.Add("Maret")
        ComboBoxEdit1.Properties.Items.Add("April")
        ComboBoxEdit1.Properties.Items.Add("Mei")
        ComboBoxEdit1.Properties.Items.Add("Juni")
        ComboBoxEdit1.Properties.Items.Add("Juli")
        ComboBoxEdit1.Properties.Items.Add("Agustus")
        ComboBoxEdit1.Properties.Items.Add("September")
        ComboBoxEdit1.Properties.Items.Add("Oktober")
        ComboBoxEdit1.Properties.Items.Add("November")
        ComboBoxEdit1.Properties.Items.Add("Desember")

        Dim s As Integer
        ComboBoxEdit2.Properties.Items.Clear()
        For s = 2014 To 2030
            ComboBoxEdit2.Properties.Items.Add(s)

        Next

    End Sub

    Private Sub FormJurnalUmum_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        setTabelUnbound()
        setView()
        loadCombo()
    End Sub

    Dim oDataTabelUnbound As New DataTable
    Dim oRow As DataRow
    Dim TanggalAwal As String
    Private Function TanggalAda(ByVal key As String)
        Dim ketemu As Boolean = False
        Dim index As String = -1
        Dim i As Integer

        For i = 0 To oDataTabelUnbound.Rows.Count - 1
            If ketemu = False And oDataTabelUnbound.Rows(i).Item(0) = key Then
                ketemu = True
                index = i
                Exit For
            End If
        Next

        Return index
    End Function
    Sub addRow(ByVal tgl As String, ByVal SubAkun As String, ByVal Ket As String, ByVal Ref As String, ByVal Debit As Long, ByVal Kredit As Long)
        Dim index As Integer
        Dim tgltulis As String

        index = TanggalAda(tgl)
        If index = -1 Then
            tgltulis = tgl
        Else
            tgltulis = ""
        End If

        Try
            oRow = oDataTabelUnbound.NewRow
            oRow(0) = tgltulis
            If Debit <> 0 Then
                oRow(1) = SubAkun + "( " + Ket + " )"
            Else
                oRow(1) = "     " + SubAkun + "( " + Ket + " )"
            End If
            oRow(2) = Ref
            oRow(3) = Debit
            oRow(4) = Kredit
            oDataTabelUnbound.Rows.Add(oRow)

            GridControl1.Refresh()
            BindingSource1.DataSource = oDataTabelUnbound
            setGridPilih()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub setGridPilih()
        Try
            GridView1.Columns(0).Caption = "Tanggal"
            GridView1.Columns(1).Caption = "Keterangan"
            GridView1.Columns(2).Caption = "Ref"
            GridView1.Columns(3).Caption = "Debet"
            GridView1.Columns(4).Caption = "Kredit"

            GridView1.Columns(0).BestFit()
            GridView1.Columns(1).BestFit()
            GridView1.Columns(2).BestFit()
            GridView1.Columns(3).BestFit()
            GridView1.Columns(4).BestFit()

            GridView1.Columns(3).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
            GridView1.Columns(3).DisplayFormat.FormatString = "c"

            GridView1.Columns(4).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
            GridView1.Columns(4).DisplayFormat.FormatString = "c"

            GridView1.Columns(3).Summary.Clear()
            GridView1.Columns(3).Summary.Add(DevExpress.Data.SummaryItemType.Sum, "Debet", "{0:c2}")

            GridView1.Columns(4).Summary.Clear()
            GridView1.Columns(4).Summary.Add(DevExpress.Data.SummaryItemType.Sum, "Kredit", "{0:c2}")

            BindingSource1.DataSource = oDataTabelUnbound
        Catch ex As Exception

        End Try
    End Sub
    Sub setTabelUnbound()
        Try
            oDataTabelUnbound.Rows.Clear()
            oDataTabelUnbound.Columns.Clear()
            oDataTabelUnbound.Clear()

            oDataTabelUnbound.Columns.Add(New DataColumn("Tanggal", GetType(String))) '0
            oDataTabelUnbound.Columns.Add(New DataColumn("Keterangan", GetType(String))) '1
            oDataTabelUnbound.Columns.Add(New DataColumn("Ref", GetType(String))) '2
            oDataTabelUnbound.Columns.Add(New DataColumn("Debet", GetType(Long))) '3
            oDataTabelUnbound.Columns.Add(New DataColumn("Kredit", GetType(Long))) '4

            BindingSource1.DataSource = oDataTabelUnbound
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Dim oDataTabel As New DataTable
    Dim DataJurnal As New ClassJurnal

    Sub loadData(ByVal bulan As String, ByVal tahun As String)
        Dim i As Integer
        oDataTabel.Clear()
        oDataTabel = DataJurnal.SelectDataJurnalUmum(bulan, tahun)
        oDataTabelUnbound.Clear()
        For i = 0 To oDataTabel.Rows.Count - 1
            addRow(oDataTabel.Rows(i).Item(1), oDataTabel.Rows(i).Item(2), oDataTabel.Rows(i).Item(3), oDataTabel.Rows(i).Item(4), oDataTabel.Rows(i).Item(5), oDataTabel.Rows(i).Item(6))
        Next
    End Sub

    Private Sub btnCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCari.Click
        Dim bulan As String = ""
        If ComboBoxEdit1.SelectedIndex = 0 Then
            bulan = "01"
        ElseIf ComboBoxEdit1.SelectedIndex = 1 Then
            bulan = "02"
        ElseIf ComboBoxEdit1.SelectedIndex = 2 Then
            bulan = "03"
        ElseIf ComboBoxEdit1.SelectedIndex = 2 Then
            bulan = "04"
        ElseIf ComboBoxEdit1.SelectedIndex = 4 Then
            bulan = "05"
        ElseIf ComboBoxEdit1.SelectedIndex = 5 Then
            bulan = "06"
        ElseIf ComboBoxEdit1.SelectedIndex = 6 Then
            bulan = "07"
        ElseIf ComboBoxEdit1.SelectedIndex = 7 Then
            bulan = "08"
        ElseIf ComboBoxEdit1.SelectedIndex = 8 Then
            bulan = "09"
        ElseIf ComboBoxEdit1.SelectedIndex = 9 Then
            bulan = "10"
        ElseIf ComboBoxEdit1.SelectedIndex = 10 Then
            bulan = "11"
        ElseIf ComboBoxEdit1.SelectedIndex = 11 Then
            bulan = "12"
        End If

        loadData(bulan, ComboBoxEdit2.Text)
    End Sub

    Sub cetakLaporan(ByVal odata As DataTable)
        Dim laporan As New LaporanJurnalUmum
        Dim Tool As ReportPrintTool = New ReportPrintTool(laporan)
        Dim oDataSet As New DataSet
        Dim oDataAdapter As New OdbcDataAdapter
        Dim i As Integer
        Dim totalD, TotalK As Long
        Dim currentTime As System.DateTime = System.DateTime.Now

        If oDataSet.Tables.Count <> 0 Then
            oDataSet.Tables.Remove("Table1")
        End If

        For i = 0 To odata.Rows.Count - 1
            totalD = totalD + odata.Rows(i).Item(3)
            TotalK = TotalK + odata.Rows(i).Item(4)
        Next

        oDataSet.Tables.Add(odata.Copy)

        laporan.DataSource = oDataSet
        laporan.DataAdapter = oDataAdapter
        laporan.DataMember = "Table1"


        laporan.lbTgl.DataBindings.Add("Text", Nothing, "Tanggal")
        laporan.lbKeterangan.DataBindings.Add("Text", Nothing, "Keterangan")
        laporan.lbRef.DataBindings.Add("Text", Nothing, "Ref")
        laporan.lbDebet.DataBindings.Add("Text", Nothing, "Debet", "{0:c2}")
        laporan.lbKredit.DataBindings.Add("Text", Nothing, "Kredit", "{0:c2}")

        laporan.lbBulan.Text = ComboBoxEdit1.Text
        laporan.lbTahun.Text = ComboBoxEdit2.Text

        laporan.lbTotalD.Text = FormatCurrency(totalD)
        laporan.lbTotalK.Text = FormatCurrency(TotalK)

        Tool.ShowPreview()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        cetakLaporan(oDataTabelUnbound)
    End Sub
End Class