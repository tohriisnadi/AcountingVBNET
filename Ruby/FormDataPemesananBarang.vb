Public Class FormDataPemesananBarang
    Dim dataPemesanan As New ClassPemesanan
    Dim odataPemesanan As New DataTable

    Sub loadData()
        odataPemesanan.Clear()
        odataPemesanan = dataPemesanan.selectDataPemesanan
        BindingSource1.DataSource = odataPemesanan
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
            GridView1.Columns(1).Visible = False
            GridView1.Columns(6).Visible = False
            GridView1.Columns(7).Visible = False
            GridView1.Columns(0).Caption = "Kode Pemesanan"
            GridView1.Columns(2).Caption = "Nama Suplier"
            GridView1.Columns(3).Caption = "Tanggal Pemesanan"
            GridView1.Columns(4).Caption = "Tanggal Kirim"
            GridView1.Columns(5).Caption = "Keterangan"
            GridView1.Columns(8).Caption = "Nama Operator"
            GridView1.Columns(9).Caption = "Total Pembayaran"

            For i = 0 To GridView1.Columns.Count - 1
                GridView1.Columns(i).BestFit()
            Next
            'GridView1.Columns(9).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            GridView1.Columns(9).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            GridView1.Columns(9).DisplayFormat.FormatString = "#.00"

        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub GridControl1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl1.Load
        setGrid()
    End Sub

    Private Sub FormDataPemesananBarang_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        loadData()
    End Sub

    Private Sub GridControl1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GridControl1.MouseClick
        Try
            If e.Button <> Windows.Forms.MouseButtons.Right Then Return
            Dim cms = New ContextMenuStrip
            Dim item1 = cms.Items.Add("Baru")
            Dim item2 = cms.Items.Add("Edit Data Pesanan")
            Dim item3 = cms.Items.Add("Lihat Detil Pemesanan")
            Dim item4 = cms.Items.Add("Refresh")

            item1.Tag = 1
            item2.Tag = 2
            item3.Tag = 3
            item4.Tag = 4

            AddHandler item1.Click, AddressOf menuChoice
            AddHandler item2.Click, AddressOf menuChoice
            AddHandler item3.Click, AddressOf menuChoice
            AddHandler item4.Click, AddressOf menuChoice

            cms.Show(GridControl1, e.Location)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub menuChoice(ByVal sender As Object, ByVal e As EventArgs)
        Dim item = CType(sender, ToolStripMenuItem)
        Dim selection = CInt(item.Tag)
        If selection = "1" Then
            FormAddPemesananBarang.X = "1"
            FormAddPemesananBarang.ShowDialog()
        ElseIf selection = "2" Then
            FormAddPemesananBarang.X = "2"
            FormAddPemesananBarang.kodePO = GridView1.GetFocusedDataRow.Item(0)
            FormAddPemesananBarang.KodeSuplier = GridView1.GetFocusedDataRow.Item(1)
            FormAddPemesananBarang.tangalGabung = GridView1.GetFocusedDataRow.Item(4)
            FormAddPemesananBarang.SearchLookUpEdit1.SelectedText = GridView1.GetFocusedDataRow.Item(1)
            FormAddPemesananBarang.txtNamaSuplier.Text = GridView1.GetFocusedDataRow.Item(2)
            FormAddPemesananBarang.txtTglKirim.Text = GridView1.GetFocusedDataRow.Item(4)
            FormAddPemesananBarang.txtKeterangan.Text = GridView1.GetFocusedDataRow.Item(5)
            FormAddPemesananBarang.txtNamaSuplier.Enabled = False
            FormAddPemesananBarang.SearchLookUpEdit1.Enabled = False
            FormAddPemesananBarang.LoadBarangBySuplier()
            FormAddPemesananBarang.ShowDialog()
        ElseIf selection = "3" Then

        ElseIf selection = "4" Then
            'If MsgBox("Non Aktifkan barang ini?", vbYesNo, "Peringatan") = vbYes Then
            '    dataBarang.setNonAktifBarang(GridView1.GetFocusedDataRow().Item(0))
            loadData()
            'End If
        End If
    End Sub
End Class