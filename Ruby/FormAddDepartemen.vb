Public Class FormAddDepartemen
    Dim dataDepartemen As New ClassDepartemen

    Public X As String = ""
    Public Kode As String = ""


    Sub Clean()
        txtDepartemen.Text = ""
        txtKeterangan.Text = ""
    End Sub

    Private Sub FormAddDepartemen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Show()
        txtDepartemen.Focus()
    End Sub

    Private Sub txtDepartemen_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDepartemen.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtKeterangan.Focus()
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If X = "1" Then
            dataDepartemen.addDepartemen(txtDepartemen.Text, txtKeterangan.Text)
            FormMutasi.LoadDepartemen()
            Clean()
        ElseIf X = "2" Then
            dataDepartemen.addDepartemen(txtDepartemen.Text, txtKeterangan.Text)
            FormDataDepartemen.loadDepartemen()
            Clean()
        ElseIf X = "3" Then
            dataDepartemen.EditDepartemen(Kode, txtDepartemen.Text, txtKeterangan.Text)
            FormDataDepartemen.loadDepartemen()
            Clean()
            Close()
        End If
    End Sub
End Class