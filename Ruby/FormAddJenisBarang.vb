Public Class FormAddJenisBarang
    Dim dataJenisBarang As New ClassJenisBarang

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        dataJenisBarang.addJenisBarang(txtJenisBarang.Text)
        txtJenisBarang.Text = ""
        FormDaftarJenisBarang.loadData()
    End Sub
End Class