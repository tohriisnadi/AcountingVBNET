Public Class FormAddBarang
    Dim kodebaru(1000) As String
    Dim odataJenisBarang As New DataTable

    Dim kodeJenisBarang As String
    Dim dataBarang As New ClassBarang

    Dim datajenisBarang As New ClassJenisBarang
    Dim X As String

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

    Private Sub FormAddBarang_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        clear()
    End Sub

    Private Sub FormAddBarang_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        loadJenisBarang()
    End Sub

    Private Sub cbJenisBarang_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbJenisBarang.KeyDown
        If e.KeyCode = Keys.Enter And kodeJenisBarang <> "" Then
            txtNamaBarang.Focus()
        End If
    End Sub

    Private Sub txtNamaBarang_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNamaBarang.KeyDown
        If e.KeyCode = Keys.Enter And txtNamaBarang.Text <> "" Then
            txtSatuan.Focus()
        End If
    End Sub

    Private Sub txtUkuran_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSatuan.KeyDown
        If e.KeyCode = Keys.Enter And txtSatuan.Text <> "" Then
            txtHargaBeli.Focus()
        End If
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If cbJenisBarang.Text = "" Or kodeJenisBarang = "" Then
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
            dataBarang.addBarang(kodeJenisBarang, txtNamaBarang.Text, txtSatuan.Text, txtHargaBeli.Text, txtStokMaks.Text, txtStokMin.Text)
            clear()
            If X = 1 Then
                FormDaftarBarang.loadData()
            End If
            FormDataBarang.loadData()
            
        End If
    End Sub

    Sub clear()
        ' kodeKategori = ""
        txtNamaBarang.Text = ""
        txtSatuan.Text = ""
        txtHargaBeli.Text = ""
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub cbJenisBarang_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbJenisBarang.SelectedIndexChanged
        kodeJenisBarang = kodebaru(cbJenisBarang.SelectedIndex)
    End Sub
End Class