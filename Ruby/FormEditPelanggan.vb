Public Class FormEditPelanggan
    Public kodePelanggan As String
    Dim dataPelanggan As New ClassPelanggan

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If txtNama.Text = "" Then
            MsgBox("Nama pelanggan masih kosong!", MsgBoxStyle.Critical, "Peringatan")
            txtNama.Focus()
        Else
            dataPelanggan.editPelanggan(kodePelanggan, txtNama.Text, txtAlamat.Text, txtNoTelp.Text)
            FormDataPelanggan.loadData()
            Close()
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class