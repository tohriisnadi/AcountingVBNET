Public Class FormDataPemerimaanBarang
    Dim dataPenerimaan As New ClassPenerimaan
    Dim odataPenerimaan As New DataTable

    Sub loadData()
        odataPenerimaan.Clear()
        odataPenerimaan = dataPenerimaan.selectDataPO
        BindingSource1.DataSource = odataPenerimaan
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

            GridView1.Columns(0).Caption = "Kode PO"
            GridView1.Columns(1).Caption = "Tanggal PO"
            GridView1.Columns(2).Visible = False
            GridView1.Columns(3).Caption = "Nama Suplier"
            GridView1.Columns(4).Caption = "Operator"
            GridView1.Columns(5).Caption = "Keterangan"
            GridView1.Columns(6).Caption = "Total"


            GridView1.Columns(6).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            GridView1.Columns(6).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
            GridView1.Columns(6).DisplayFormat.FormatString = "c"

        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub GridControl1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl1.DoubleClick
        FormAddPenerimaanBarang.KodePO = GridView1.GetFocusedDataRow.Item(0)
        FormAddPenerimaanBarang.kodeSUplier = GridView1.GetFocusedDataRow.Item(2)
        FormAddPenerimaanBarang.ShowDialog()
    End Sub

    Private Sub GridControl1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl1.Load
        setGrid()
    End Sub

    Private Sub FormDataPemerimaanBarang_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        loadData()
    End Sub
End Class