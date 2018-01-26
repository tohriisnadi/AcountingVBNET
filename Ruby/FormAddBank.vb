Public Class FormAddBank
    Dim dataAkun As New ClassAkun
    Dim dataBank As New ClassBank
    Dim oDataTabelAkun As New DataTable

    Dim KodeAKun(5000) As String

    Private Sub loadDataAkun()
        Dim properties As DevExpress.XtraEditors.Repository.RepositoryItemComboBox = cbAkun.Properties
        Dim i As Integer
        Dim acs As New AutoCompleteStringCollection
        oDataTabelAkun.Clear()
        properties.Items.Clear()
        oDataTabelAkun = DataAkun.selectAkun(1, 0)
        For i = 0 To oDataTabelAkun.Rows().Count() - 1
            acs.Add(oDataTabelAkun.Rows(i).Item(0) & "-" & oDataTabelAkun.Rows(i).Item(5))
            properties.Items.Add(oDataTabelAkun.Rows(i).Item(0) & "-" & oDataTabelAkun.Rows(i).Item(5))
            kodeAkun(i) = oDataTabelAkun.Rows(i).Item(0)
        Next
        cbAkun.SelectedIndex = 0
        cbAkun.MaskBox.AutoCompleteMode = AutoCompleteMode.Suggest
        cbAkun.MaskBox.AutoCompleteSource = AutoCompleteSource.CustomSource
        cbAkun.MaskBox.AutoCompleteCustomSource = acs
    End Sub

    Private Sub FormAddBank_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        loadDataAkun()
    End Sub

    Sub clean()
        loadDataAkun()
        txtNamaBank.Text = ""
        txtNorek.Text = ""
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            dataBank.AddBank(KodeAKun(cbAkun.SelectedIndex), txtNamaBank.Text, txtNorek.Text)
            clean()
            FormDataAkun.loadData()
        Catch ex As Exception

        End Try
    End Sub
End Class