Public Class FormAddSuplier
    Dim dataSuplier As New ClassSuplier

    Sub clean()
        txtNama.Text = ""
        txtAlamat.Text = ""
        txtCP.Text = ""
        txtTelp.Text = ""
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If txtNama.Text = "" Then
            MsgBox("Nama Suplier masih kosong!", MsgBoxStyle.Critical, "Peringatan")
            txtNama.Focus()
        ElseIf txtAlamat.Text = "" Then
            MsgBox("Alamat Suplier masih kosong!", MsgBoxStyle.Critical, "Peringatan")
            txtAlamat.Focus()
        ElseIf txtCP.Text = "" Then
            MsgBox("Contact Person Suplier masih kosong!", MsgBoxStyle.Critical, "Peringatan")
            txtCP.Focus()
        ElseIf txtTelp.Text = "" Then
            MsgBox("NO Telpon Suplier masih kosong!", MsgBoxStyle.Critical, "Peringatan")
            txtTelp.Focus()
        Else
            dataSuplier.addSuplier(txtNama.Text, txtAlamat.Text, txtCP.Text, txtTelp.Text)
            FormDataSuplier.loadData()
        End If
        clean()
    End Sub
End Class