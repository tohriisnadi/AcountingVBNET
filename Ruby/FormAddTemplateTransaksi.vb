Public Class FormAddTemplateTransaksi
    Dim odataAkun As New DataTable
    Dim dataAkun As New ClassAkun
    Dim dataTemplate As New ClassTemplateAkun
    Dim kodebaru1(1000) As String
    Dim kodebaru2(1000) As String
    Dim debet As String
    Dim kredit As String

    Private Sub loadDebet()
        Dim properties As DevExpress.XtraEditors.Repository.RepositoryItemComboBox = cbDebet.Properties
        Dim i As Integer

        properties.Items.Clear()
        odataAkun.Clear()
        odataAkun = dataAkun.selectAkun("1", "0")

        For i = 0 To odataAkun.Rows().Count() - 1
            kodebaru1(i) = odataAkun.Rows(i).Item(0)
            properties.Items.Add(odataAkun.Rows(i).Item(5))
        Next
        properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
    End Sub

    Private Sub loadKredit()
        Dim properties As DevExpress.XtraEditors.Repository.RepositoryItemComboBox = cbKredit.Properties
        Dim i As Integer

        properties.Items.Clear()
        odataAkun.Clear()
        odataAkun = dataAkun.selectAkun("1", "0")

        For i = 0 To odataAkun.Rows().Count() - 1
            kodebaru2(i) = odataAkun.Rows(i).Item(0)
            properties.Items.Add(odataAkun.Rows(i).Item(5))
        Next
        properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
    End Sub

    Private Sub FormAddTemplateTransaksi_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        loadDebet()
        loadKredit()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If txtNamaTrans.Text = "" Then
            MsgBox("Nama template masih kosong!", MsgBoxStyle.Critical, "Peringatan")
            txtNamaTrans.Focus()
        ElseIf cbDebet.Text = "" Then
            MsgBox("Akun debet belum dipilih!", MsgBoxStyle.Critical, "Peringatan")
            cbDebet.Focus()
        ElseIf cbKredit.Text = "" Then
            MsgBox("Akun kredit belum dipilih!", MsgBoxStyle.Critical, "Peringatan")
            cbKredit.Focus()
        Else
            dataTemplate.addTemplateTransaksi(debet & kredit, txtNamaTrans.Text, debet, kredit, "-", "-")
            FormDataTamplate.LoadData()
            clear()
            txtNamaTrans.Focus()
        End If
        loadDebet()
        loadKredit()
      End Sub
    Sub clear()
        txtNamaTrans.Text = ""
        debet = ""
        kredit = ""
    End Sub

    
    Private Sub cbDebet_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbDebet.SelectedIndexChanged
        debet = kodebaru1(cbDebet.SelectedIndex())
    End Sub

    Private Sub cbKredit_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbKredit.SelectedIndexChanged
        kredit = kodebaru2(cbKredit.SelectedIndex())
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class