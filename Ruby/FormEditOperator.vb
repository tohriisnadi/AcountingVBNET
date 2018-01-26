Public Class FormEditOperator
    Public kodeOperator As String
    Dim dataOperator As New ClassOperator

    Private Sub txtNama_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNama.KeyDown
        If txtNama.Text <> "" And e.KeyCode = Keys.Enter Then
            txtPasword1.Focus()
        End If
    End Sub

    Private Sub txtPasword1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPasword1.KeyDown
        If txtPasword1.Text <> "" And e.KeyCode = Keys.Enter Then
            txtPasword2.Focus()
        End If
    End Sub

    Private Sub txtPasword2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPasword2.KeyDown
        If e.KeyCode = Keys.Enter And txtPasword2.Text = txtPasword1.Text Then
            btnAdd.Focus()
        ElseIf e.KeyCode = Keys.Enter And txtPasword1.Text <> txtPasword2.Text Then
            MsgBox("Password dan Konfirmasi password tidak sama!", MsgBoxStyle.Critical, "Peringatan!")
            txtPasword2.Focus()
        End If
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If txtNama.Text = "" Then
            MsgBox("Nama masih kosong!", MsgBoxStyle.Critical, "Peringatan!")
            txtNama.Focus()
        ElseIf txtPasword1.Text = "" Then
            MsgBox("Password masih kosong!", MsgBoxStyle.Critical, "Peringatan")
            txtPasword1.Focus()
        ElseIf txtPasword2.Text = "" Then
            MsgBox("Konfirmasi password masih kosong!", MsgBoxStyle.Critical, "Peringatan")
            txtPasword2.Focus()
        ElseIf txtPasword1.Text <> txtPasword2.Text Then
            MsgBox("Password dan Konfirmasi password belum sama!", MsgBoxStyle.Critical, "Peringatan")
            txtPasword2.Focus()
        Else
            dataOperator.editOperator(kodeOperator, txtNama.Text, txtPasword1.Text)
            FormOperator.loadData()
            Close()
        End If
    End Sub

    Sub clear()
        txtNama.Text = ""
        txtPasword1.Text = ""
        txtPasword2.Text = ""
    End Sub

    Private Sub btnAdd_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If txtNama.Text = "" Then
            MsgBox("Nama masih kosong!", MsgBoxStyle.Critical, "Peringatan!")
            txtNama.Focus()
        ElseIf txtPasword1.Text = "" Then
            MsgBox("Password masih kosong!", MsgBoxStyle.Critical, "Peringatan")
            txtPasword1.Focus()
        ElseIf txtPasword2.Text = "" Then
            MsgBox("Konfirmasi password masih kosong!", MsgBoxStyle.Critical, "Peringatan")
            txtPasword2.Focus()
        ElseIf txtPasword1.Text <> txtPasword2.Text Then
            MsgBox("Password dan Konformasi password belum sama!", MsgBoxStyle.Critical, "Peringatan")
            txtPasword2.Focus()
        Else
            dataOperator.editOperator(kodeOperator, txtNama.Text, txtPasword1.Text)
            FormOperator.loadData()
            Close()
        End If
    End Sub

    Private Sub FormEditOperator_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Show()
        txtNama.Focus()
    End Sub
End Class