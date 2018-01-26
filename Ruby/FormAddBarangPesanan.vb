Public Class FormAddBarangPesanan
    Public X As String

    Private Sub FormAddBarangPesanan_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtKodeBarang.Enabled = False
        txtNamaBarang.Enabled = False
        txtSatuan.Enabled = False
        txtHarga.Enabled = False
        Show()
        txtQty.Focus()
    End Sub

    Dim SubTotal As Long

    Sub Hitung(ByVal harga As Long, ByVal qty As Integer)
        SubTotal = harga * qty
    End Sub

    Sub clean()
        txtKodeBarang.Text = ""
        txtNamaBarang.Text = ""
        txtHarga.Text = ""
        txtSatuan.Text = ""
        txtQty.Text = ""
        txtKeterangan.Text = ""
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Hitung(txtHarga.Text, txtQty.Text)

        If X = "1" Then
            FormAddPemesananBarang.SetNewRowDataPemesanan(txtKodeBarang.Text, txtNamaBarang.Text, txtSatuan.Text, txtHarga.Text, txtQty.Text, SubTotal, txtKeterangan.Text)
        ElseIf X = "2" Then
            FormAddPemesananBarang.EditRowPemesanan(txtKodeBarang.Text, txtQty.Text, SubTotal, txtKeterangan.Text)
        End If

        FormAddPemesananBarang.Show()
        clean()
        Me.Close()
    End Sub

    Private Sub txtQty_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtQty.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtKeterangan.Focus()
        End If
    End Sub

    Private Sub txtHarga_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtHarga.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtHarga.Text = Format(CLng(txtHarga.Text), "###,###,##0")
        End If
    End Sub
End Class