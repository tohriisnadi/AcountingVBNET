Imports DevExpress.XtraGrid
Public Class FormDaftarBarang
    Public X As String
    Dim dataBarang As New ClassBarang
    Dim dataPemesanan As New ClassPemesanan
    Dim odataBarang As New DataTable

    Public KodeSuplier As String

    Sub loadData()
        odataBarang.Clear()
        odataBarang = dataBarang.selectBarang()
        BindingSource1.DataSource = odataBarang
    End Sub

    Private Sub FormDaftarBarang_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        loadData()
        Me.Show()
        txtKodeBarang.Focus()
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
            GridView1.Columns(0).Caption = "Kode Barang"
            GridView1.Columns(2).Caption = "Kategori"
            GridView1.Columns(3).Caption = "Nama Barang"
            GridView1.Columns(4).Caption = "Ukuran"
            GridView1.Columns(5).Caption = "Harga Sewa"
            GridView1.Columns(6).Caption = "Keterangan"

            For i = 0 To GridView1.Columns.Count - 1
                GridView1.Columns(i).BestFit()
            Next

            GridView1.Columns(5).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            GridView1.Columns(5).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
            GridView1.Columns(5).DisplayFormat.FormatString = "c"

        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try

    End Sub


    Sub isiData()
        Try
            If X = "1" Then
                dataPemesanan.AddDetilBarangSuplier(KodeSuplier, GridView1.GetFocusedDataRow.Item(0), Format(CLng(GridView1.GetFocusedDataRow().Item(5)), "###,###,##0"))
                FormAddPemesananBarang.LoadBarangBySuplier()
                Close()
            ElseIf X = "2" Then
                FormMutasi.txtKodeBarang.Text = GridView1.GetFocusedDataRow.Item(0)
                Close()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GridControl1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl1.DoubleClick
        isiData()
    End Sub

    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Enter Then
            isiData()
        ElseIf e.KeyCode = Keys.Back Then
            txtKodeBarang.Focus()
            txtKodeBarang.SelectAll()
        End If
    End Sub

    Private Sub GridControl1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl1.Load
        setGrid()
    End Sub

    Private Sub txtKodeBarang_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtKodeBarang.EditValueChanged
        Try
            GridView1.SetRowCellValue(GridControl.AutoFilterRowHandle, GridView1.Columns(2), txtKodeBarang.Text)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtKodeBarang_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtKodeBarang.KeyDown
        If e.KeyCode = Keys.Down Then
            GridControl1.Focus()

        End If
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

    End Sub
End Class