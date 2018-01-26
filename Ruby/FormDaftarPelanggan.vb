Imports DevExpress.XtraGrid
Public Class FormDaftarPelanggan
    Dim dataPelanggan As New ClassPelanggan
    Dim odataPelanggan As New DataTable
    Public X As String

    Sub loadData()
        odataPelanggan.Clear()
        odataPelanggan = dataPelanggan.selectPelanggan()
        BindingSource1.DataSource = odataPelanggan
    End Sub

    Private Sub FormDaftarPelanggan_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        loadData()
    End Sub

    Sub isiData()
        Try
            If X = "1" Then
                FormTransaksi.kodePelanggan = GridView1.GetFocusedDataRow().Item(0)
                FormTransaksi.txtKonsumen.Text = GridView1.GetFocusedDataRow().Item(1)
                Close()
            End If
        Catch ex As Exception

        End Try

    End Sub

    Sub setGrid()
        Try
            GridView1.OptionsBehavior.Editable = False
            GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
            GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus

            For i = 0 To GridView1.Columns.Count - 1
                GridView1.Columns(i).OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            Next

            GridView1.Columns(0).Caption = "Kode Pelanggan"
            GridView1.Columns(1).Caption = "Nama "
            GridView1.Columns(2).Caption = "Alamat"
            GridView1.Columns(3).Caption = "No Telepon"
            GridView1.Columns(4).Visible = False

            For i = 0 To GridView1.Columns.Count - 1
                GridView1.Columns(i).BestFit()
            Next
        Catch ex As Exception
            ' MsgBox(ex.Message)
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

    Private Sub txtKodeBarang_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKodeBarang.EditValueChanged
        Try
            GridView1.SetRowCellValue(GridControl.AutoFilterRowHandle, GridView1.Columns(1), txtKodeBarang.Text)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtKodeBarang_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtKodeBarang.KeyDown
        If e.KeyCode = Keys.Down Then
            GridControl1.Focus()
        End If
    End Sub

    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        FormAddPelanggan.x = "2"
        FormAddPelanggan.ShowDialog()
    End Sub
End Class