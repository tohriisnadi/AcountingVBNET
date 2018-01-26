Public Class FormDataPerusahaan

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        ModKoneksi.Company = txtNamaPerusahaan.Text
        ModKoneksi.Alamat = TxtAlamat.Text
    End Sub

    Private Sub FormDataPerusahaan_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtNamaPerusahaan.Text = ModKoneksi.Company
        TxtAlamat.Text = ModKoneksi.Alamat
    End Sub
End Class