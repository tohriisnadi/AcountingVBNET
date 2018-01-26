Public Class FormDataBarang
    Dim dataBarang As New ClassBarang
    Dim odataBarang As New DataTable

    Sub loadData()
        odataBarang.Clear()
        odataBarang = dataBarang.selectBarang()
        BindingSource1.DataSource = odataBarang
        setGrid()
    End Sub

    Private Sub FormDataBarang_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        loadData()
    End Sub

    Sub setGrid()
        Try
            GridView1.OptionsBehavior.Editable = False
            GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
            GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus

            For i = 0 To GridView1.Columns.Count - 1
                GridView1.Columns(i).OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            Next
            GridView1.Columns(0).Caption = "Kode Barang"
            GridView1.Columns(1).Visible = True
            GridView1.Columns(2).Caption = "Jenis Barang"
            GridView1.Columns(3).Caption = "Nama Barang"
            GridView1.Columns(4).Caption = "Satuan"
            GridView1.Columns(5).Caption = "Harga Beli"
            GridView1.Columns(6).Caption = "Stok Maks"
            GridView1.Columns(7).Caption = "Stok Min"
            GridView1.Columns(8).Caption = "Stok"

            For i = 0 To GridView1.Columns.Count - 1
                GridView1.Columns(i).BestFit()
            Next

            GridView1.Columns(5).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
            GridView1.Columns(5).DisplayFormat.FormatString = "c"
            GridView1.Columns(5).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub GridControl1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl1.Load
        setGrid()
    End Sub

    Private Sub GridControl1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GridControl1.MouseClick
        Try
            If e.Button <> Windows.Forms.MouseButtons.Right Then Return
            Dim cms = New ContextMenuStrip
            Dim item1 = cms.Items.Add("Baru")
            Dim item2 = cms.Items.Add("Edit Data")
            Dim item3 = cms.Items.Add("Non Aktif")
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
            FormAddBarang.ShowDialog()
        ElseIf selection = "2" Then
            FormEditBarang.kodeBarang = GridView1.GetFocusedDataRow().Item(0)
            FormEditBarang.KodeJenis = GridView1.GetFocusedDataRow().Item(1)
            FormEditBarang.cbJenisBarang.Text = GridView1.GetFocusedDataRow().Item(2)
            FormEditBarang.txtNamaBarang.Text = GridView1.GetFocusedDataRow().Item(3)
            FormEditBarang.txtSatuan.Text = GridView1.GetFocusedDataRow().Item(4)
            FormEditBarang.txtHargaBeli.Text = Format(CLng(GridView1.GetFocusedDataRow().Item(5)), "###,###,##0")
            FormEditBarang.txtStokMaks.Text = GridView1.GetFocusedDataRow().Item(6)
            FormEditBarang.txtStokMin.Text = GridView1.GetFocusedDataRow().Item(7)
            ' FormEditBarang.txtStok.Text = GridView1.GetFocusedDataRow().Item(8)
            FormEditBarang.ShowDialog()
        ElseIf selection = "3" Then
            If MsgBox("Non Aktifkan barang ini?", vbYesNo, "Peringatan") = vbYes Then
                dataBarang.setNonAktifBarang(GridView1.GetFocusedDataRow().Item(0))
                loadData()
            End If
        ElseIf selection = "4" Then
            loadData()
        End If
    End Sub

    Private Sub GridControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridControl1.Click

    End Sub
End Class