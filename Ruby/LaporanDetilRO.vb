﻿Public Class LaporanDetilRO

    Private Sub LaporanDetilRO_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles Me.BeforePrint
        lbCompany.Text = ModKoneksi.Company
        lbAlamat.Text = ModKoneksi.Alamat
    End Sub
End Class