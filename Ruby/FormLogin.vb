Public Class FormLogin
    Dim dataOperator As New ClassOperator
    Dim odataOperator As New DataTable

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        odataOperator.Clear()
        odataOperator = dataOperator.selectOperatorForlogin(txtKodeOP.Text, txtPasword1.Text)

        If odataOperator.Rows.Count() < 1 Then
            MsgBox("Login gagal!", MsgBoxStyle.Critical, "Informasi")
            txtPasword1.Focus()
        Else
            MsgBox("Login Sukses!", MsgBoxStyle.Information, "Informasi")
            txtKodeOP.Text = ""
            txtPasword1.Text = ""
            ModKoneksi.kodeOperator = odataOperator.Rows(0).Item(0)
            ModKoneksi.namaOperator = odataOperator.Rows(0).Item(1)
            frmMain.ShowDialog()
        End If
    End Sub

    Private Sub FormLogin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Show()
        txtKodeOP.Focus()
    End Sub

    Private Sub txtKodeOP_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtKodeOP.KeyDown
        If txtKodeOP.Text <> "" And e.KeyCode = Keys.Enter Then
            txtPasword1.Focus()
        End If
    End Sub

    Private Sub txtPasword1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPasword1.KeyDown
        If txtPasword1.Text <> "" And e.KeyCode = Keys.Enter Then
            btnAdd.Focus()
        End If
    End Sub
End Class