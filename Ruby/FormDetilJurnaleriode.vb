Public Class FormDetilJurnaleriode

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        FormDetilJurnal.LoadMasterJurnal(cbTglDari.EditValue, cbTglSampai.EditValue)
        FormDetilJurnal.ShowDialog()
        Me.Close()
    End Sub
End Class