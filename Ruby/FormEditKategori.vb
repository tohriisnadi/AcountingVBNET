Public Class FormEditKategori
    Public kodekategori As String
    Dim dataKategori As New ClassKategori

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If txtKategori.Text = "" Then
            MsgBox("Kategori masih kosong!", MsgBoxStyle.Critical, "Peringatan")
            txtKategori.Focus()
        Else
            dataKategori.editKategoriBarang(kodekategori, txtKategori.Text)
            FormDataKategori.loadData()
            Close()
        End If
    End Sub

    Private Sub txtKategori_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtKategori.KeyDown
        If e.KeyCode = Keys.Enter And txtKategori.Text <> "" Then
            btnAdd.Focus()
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class