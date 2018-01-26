Public Class LaporanDetilTransferStok

    Private Sub LaporanDetilTransferStok_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles Me.BeforePrint
        lbCompany.Text = ModKoneksi.Company
        lbAlamat.Text = ModKoneksi.Alamat
    End Sub
End Class