Public Class FormAddPelanggan
    Dim dataPelanggan As New ClassPelanggan
    Public x As String
    Private Sub txtNama_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNama.KeyDown
        If e.KeyCode = Keys.Enter And txtNama.Text <> "" Then
            txtAlamat.Focus()
        End If
    End Sub

    Private Sub txtNoTelp_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNoTelp.KeyDown
        If e.KeyCode = Keys.Enter And txtNoTelp.Text <> "" Then
            btnAdd.Focus()
        End If

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If txtNama.Text = "" Then
            MsgBox("Nama pelanggan masih kosong!", MsgBoxStyle.Critical, "Alert")
            txtNama.Focus()
        Else
            dataPelanggan.addPelanggan(txtNama.Text, txtAlamat.Text, txtNoTelp.Text)
            clear()
            FormDataPelanggan.loadData()
        End If
    End Sub

    Sub clear()
        txtNama.Text = ""
        txtNoTelp.Text = ""
        txtAlamat.Text = ""
    End Sub

    Private Sub btnAdd_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If txtNama.Text = "" Then
            MsgBox("Nama pelanggan masih kosong!", MsgBoxStyle.Critical, "Alert")
            txtNama.Focus()
        Else
            dataPelanggan.addPelanggan(txtNama.Text, txtAlamat.Text, txtNoTelp.Text)
            If x <> "2" Then
                FormDataPelanggan.loadData()
                txtNama.Focus()
            Else
                FormDaftarPelanggan.loadData()
                FormDaftarPelanggan.txtKodeBarang.Text = txtNama.Text

            End If
            clear()
            Close()
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class