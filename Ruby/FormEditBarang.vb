Public Class FormEditBarang
    Public kodeBarang As String
    Dim kodebaru(1000) As String
    Dim odataKategori As New DataTable
    Dim dataKategori As New ClassKategori
    ' Public kodeKategori As String

    Public KodeJenis As String

    Dim dataBarang As New ClassBarang
    Dim dataJenisBarang As New ClassJenisBarang
    Dim odataJenisBarang As New DataTable

    Private Sub loadJenisBarang()
        Dim properties As DevExpress.XtraEditors.Repository.RepositoryItemComboBox = cbJenisBarang.Properties
        Dim i As Integer

        properties.Items.Clear()
        odataJenisBarang.Clear()
        odataJenisBarang = datajenisBarang.selectJenisBarang
        For i = 0 To odataJenisBarang.Rows().Count() - 1
            kodebaru(i) = odataJenisBarang.Rows(i).Item(0)
            properties.Items.Add(odataJenisBarang.Rows(i).Item(1))
        Next
        properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        cbJenisBarang.SelectedIndex = 0
    End Sub

    Private Sub FormEditBarang_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        loadJenisBarang()
    End Sub

    Private Sub btnAdd_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If cbJenisBarang.Text = "" Or KodeJenis = "" Then
            MsgBox("Kategori belum dipilih!", MsgBoxStyle.Critical, "Peringatan")
            cbJenisBarang.Focus()
        ElseIf txtNamaBarang.Text = "" Then
            MsgBox("Nama barang masih kosong!", MsgBoxStyle.Critical, "Peringatan")
            txtNamaBarang.Focus()
        ElseIf txtSatuan.Text = "" Then
            MsgBox("Ukuran masih kosong!", MsgBoxStyle.Critical, "Peringatan")
            txtSatuan.Focus()
        ElseIf txtHargaBeli.Text = "" Then
            MsgBox("Harga masih kosong!", MsgBoxStyle.Critical, "Peringatan")
            txtHargaBeli.Focus()
        Else
            dataBarang.editBarang(kodeBarang, KodeJenis, txtNamaBarang.Text, txtSatuan.Text, txtHargaBeli.Text, txtStokMaks.Text, txtStokMin.Text, txtStok.Text)
            FormDataBarang.loadData()
            Close()
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub txtHargaBeli_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtHargaBeli.KeyDown
        If e.KeyCode = Keys.Enter And txtHargaBeli.Text <> "" And IsNumeric(txtHargaBeli.Text) = True Then
            txtHargaBeli.Text = Format(CLng(txtHargaBeli.Text), "###,###,##0")
            txtStokMaks.Focus()
        End If
    End Sub

    Private Sub cbJenisBarang_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbJenisBarang.KeyDown
        If e.KeyCode = Keys.Enter And KodeJenis <> "" Then
            txtNamaBarang.Focus()
        End If
    End Sub

    Private Sub cbJenisBarang_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbJenisBarang.SelectedIndexChanged
        KodeJenis = kodebaru(cbJenisBarang.SelectedIndex())
    End Sub

    Private Sub txtNamaBarang_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNamaBarang.KeyDown
        If e.KeyCode = Keys.Enter And txtNamaBarang.Text <> "" Then
            txtSatuan.Focus()
        End If
    End Sub

    Private Sub txtSatuan_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSatuan.KeyDown
        If e.KeyCode = Keys.Enter And txtSatuan.Text <> "" Then
            txtHargaBeli.Focus()
        End If
    End Sub
End Class