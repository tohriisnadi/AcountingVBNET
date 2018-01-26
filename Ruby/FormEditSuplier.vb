Public Class FormEditSuplier
    Dim dataSuplier As New ClassSuplier

    Public KodeSuplier As String

    Sub clean()
        txtNama.Text = ""
        txtAlamat.Text = ""
        txtCP.Text = ""
        txtTelp.Text = ""
    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        dataSuplier.editSuplier(KodeSuplier, txtNama.Text, txtAlamat.Text, txtCP.Text, txtTelp.Text)
        FormDataSuplier.loadData()
        clean()
        Close()

    End Sub
End Class