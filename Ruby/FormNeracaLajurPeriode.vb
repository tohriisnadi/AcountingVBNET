Public Class FormNeracaLajurPeriode

    Dim Bulan As String = ""

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If cbBulan.SelectedIndex = 0 Then
            Bulan = "01"
        ElseIf cbBulan.SelectedIndex = 1 Then
            Bulan = "02"
        ElseIf cbBulan.SelectedIndex = 2 Then
            Bulan = "03"
        ElseIf cbBulan.SelectedIndex = 2 Then
            Bulan = "04"
        ElseIf cbBulan.SelectedIndex = 4 Then
            Bulan = "05"
        ElseIf cbBulan.SelectedIndex = 5 Then
            Bulan = "06"
        ElseIf cbBulan.SelectedIndex = 6 Then
            Bulan = "07"
        ElseIf cbBulan.SelectedIndex = 7 Then
            Bulan = "08"
        ElseIf cbBulan.SelectedIndex = 8 Then
            Bulan = "09"
        ElseIf cbBulan.SelectedIndex = 9 Then
            Bulan = "10"
        ElseIf cbBulan.SelectedIndex = 10 Then
            Bulan = "11"
        ElseIf cbBulan.SelectedIndex = 11 Then
            Bulan = "12"
        End If

        FormNeracaLajur.bulan = Bulan
        FormNeracaLajur.tahun = cbTahun.Text
        FormNeracaLajur.ShowDialog()
        Me.Close()
    End Sub
End Class