Public Class FormInputTransaksiLain
    Public kodeTemplate As String
    Public kodeDebet As String
    Public kodeKredit As String
    Dim dataTransaksi As New ClassTransaksi

    Private Sub txtNamaTrans_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNamaTrans.KeyDown
        If e.KeyCode = Keys.F1 Then
            FormDaftarTemplateTransaksi.x = 1
            FormDaftarTemplateTransaksi.ShowDialog()
        ElseIf e.KeyCode = Keys.Enter And kodeTemplate <> "" Then
            txtNoTransaksi.Focus()
        End If
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If txtNamaTrans.Text = "" And kodeTemplate = "" Then
            MsgBox("Template transaksi belum dipilih!", MsgBoxStyle.Critical, "Peringatan")
            txtNamaTrans.Focus()
        
        ElseIf txtNoTransaksi.Text = "" Then
            MsgBox("No Bukti transaksi masih kosong!", MsgBoxStyle.Critical, "Peringatan")
            txtNoTransaksi.Focus()
        ElseIf txtNominal.Text = "" Then
            MsgBox("Nominal belum dimasukkan!", MsgBoxStyle.Critical, "Peringatan")
            txtNominal.Focus()
        Else
            dataTransaksi.addTransaksiLain(kodeTemplate, kodeDebet, kodeKredit, txtNoTransaksi.Text, txtNominal.Text, txtKeterangan.Text)
            clean()
        End If

    End Sub
    Sub clean()
        txtNamaTrans.Text = ""
        txtNominal.Text = ""
        cbDebet.Text = ""
        cbKredit.Text = ""
        txtKeterangan.Text = ""
        txtNoTransaksi.Text = ""
    End Sub
    Private Sub txtNoTransaksi_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNoTransaksi.KeyDown
        If e.KeyCode = Keys.Enter And txtNoTransaksi.Text <> "" Then
            txtKeterangan.Focus()
        End If
    End Sub

    Private Sub txtNominal_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNominal.KeyDown
        If e.KeyCode = Keys.Enter And txtNominal.Text <> "" Then
            txtNominal.Text = Format(CInt(txtNominal.Text), "###,###,##0")
            btnAdd.Focus()
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class