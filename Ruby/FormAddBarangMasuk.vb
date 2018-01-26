Public Class FormAddBarangMasuk

    Dim HargaDiskon As Double
    Dim HargaSetelahDiskon As Long

    Dim SubTotal As Long

    Sub Hitung()
        Dim harga As Long
        Dim Qty As Integer
        harga = CLng(txtHargaSetelah.Text)
        Qty = CLng(txtQtyTerima.Text)
        SubTotal = harga * Qty
    End Sub

    Private Sub txtDiskon_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDiskon.KeyDown
        If e.KeyCode = Keys.Enter Then
            HargaDiskon = (CLng(txtHargaBeli.Text)) * (CLng(txtDiskon.Text) / 100)
            HargaSetelahDiskon = (CLng(txtHargaBeli.Text)) - HargaDiskon
            txtHargaSetelah.Text = Format(CLng(HargaSetelahDiskon), "###,###,##0")
            txtQtyTerima.Focus()
        End If
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Hitung()
        FormAddPenerimaanBarang.SetNewRowPenerimaan(txtKodeBarang.Text, txtNamaBarang.Text, txtHargaBeli.Text, txtDiskon.Text, txtHargaSetelah.Text, txtQtyPesan.Text, txtSatuanPesan.Text, txtQtyTerima.Text, txtSatuanTerima.Text, SubTotal, txtKeterangan.Text)
        Close()
    End Sub

    Private Sub FormAddBarangMasuk_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtKodeBarang.Enabled = False
        txtNamaBarang.Enabled = False
        txtHargaBeli.Enabled = False
        txtQtyPesan.Enabled = False
        txtSatuanPesan.Enabled = False
        txtSatuanTerima.Enabled = False

        Show()
        txtDiskon.Focus()
    End Sub

    Private Sub txtQtyTerima_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtQtyTerima.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtKeterangan.Focus()
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class