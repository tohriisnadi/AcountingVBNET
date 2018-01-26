Public Class FormSettingSistem
    Dim kodebaru1(1000) As String
    Dim kodebaru2(1000) As String
    Dim kodebaru3(1000) As String
    Dim kodebaru4(1000) As String
    Dim kodebaru5(1000) As String
    Dim odataAkun As New DataTable
    Dim dataAkun As New ClassAkun
    Public kodeAkunTransaksi As String
    Public kodeAkunPiutang As String
    Public kodeAkunTransport As String
    Public kodeAkunPengembangan As String
    Public kodeAkunPerawatan As String
    Dim dataSetting As New ClassSetting
    Dim odataSetting As New DataTable

    Sub loadData()
        Try
            odataSetting.Clear()
            odataSetting = dataSetting.selectSetting()

            cbAkunTrans.Text = odataSetting.Rows(0).Item(1)
            cbAkunPiutang.Text = odataSetting.Rows(0).Item(2)
            cbAkunTransport.Text = odataSetting.Rows(0).Item(3)
            cbAkunPerawatan.Text = odataSetting.Rows(0).Item(4)
            cbAkunPengembangan.Text = odataSetting.Rows(0).Item(5)
            kodeAkunTransaksi = odataSetting.Rows(0).Item(6)
            kodeAkunPiutang = odataSetting.Rows(0).Item(7)
            kodeAkunTransport = odataSetting.Rows(0).Item(8)
            kodeAkunPerawatan = odataSetting.Rows(0).Item(10)
            kodeAkunPengembangan = odataSetting.Rows(0).Item(12)
            txtPsTransport.Text = odataSetting.Rows(0).Item(9)
            txtPsPerawatan.Text = odataSetting.Rows(0).Item(11)
            txtPsPengembangan.Text = odataSetting.Rows(0).Item(13)

        Catch ex As Exception

        End Try

    End Sub
    Private Sub loadAKunTransaksi()
        Dim properties As DevExpress.XtraEditors.Repository.RepositoryItemComboBox = cbAkunTrans.Properties
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

    Private Sub loadAKunPiutang()
        Dim properties As DevExpress.XtraEditors.Repository.RepositoryItemComboBox = cbAkunPiutang.Properties
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

    Private Sub loadAKunTransport()
        Dim properties As DevExpress.XtraEditors.Repository.RepositoryItemComboBox = cbAkunTransport.Properties
        Dim i As Integer

        properties.Items.Clear()
        odataAkun.Clear()
        odataAkun = dataAkun.selectAkun("1", "0")

        For i = 0 To odataAkun.Rows().Count() - 1
            kodebaru3(i) = odataAkun.Rows(i).Item(0)
            properties.Items.Add(odataAkun.Rows(i).Item(5))
        Next
        properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
    End Sub

    Private Sub loadAKunPerawatan()
        Dim properties As DevExpress.XtraEditors.Repository.RepositoryItemComboBox = cbAkunPerawatan.Properties
        Dim i As Integer

        properties.Items.Clear()
        odataAkun.Clear()
        odataAkun = dataAkun.selectAkun("1", "0")

        For i = 0 To odataAkun.Rows().Count() - 1
            kodebaru4(i) = odataAkun.Rows(i).Item(0)
            properties.Items.Add(odataAkun.Rows(i).Item(5))
        Next
        properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
    End Sub

    Private Sub loadAKunPengembangan()
        Dim properties As DevExpress.XtraEditors.Repository.RepositoryItemComboBox = cbAkunPengembangan.Properties
        Dim i As Integer

        properties.Items.Clear()
        odataAkun.Clear()
        odataAkun = dataAkun.selectAkun("1", "0")

        For i = 0 To odataAkun.Rows().Count() - 1
            kodebaru5(i) = odataAkun.Rows(i).Item(0)
            properties.Items.Add(odataAkun.Rows(i).Item(5))
        Next
        properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
    End Sub


    Private Sub FormSettingSistem_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        loadData()
        loadAKunPengembangan()
        loadAKunPerawatan()
        loadAKunPiutang()
        loadAKunTransaksi()
        loadAKunTransport()
    End Sub

    Private Sub cbAkunTrans_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbAkunTrans.SelectedIndexChanged
        kodeAkunTransaksi = kodebaru1(cbAkunTrans.SelectedIndex())
    End Sub

    Private Sub cbAkunPiutang_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbAkunPiutang.SelectedIndexChanged
        kodeAkunPiutang = kodebaru2(cbAkunPiutang.SelectedIndex())
    End Sub

    Private Sub cbAkunTransport_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbAkunTransport.SelectedIndexChanged
        kodeAkunTransport = kodebaru3(cbAkunTransport.SelectedIndex())
    End Sub

    Private Sub cbAkunPerawatan_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbAkunPerawatan.SelectedIndexChanged
        kodeAkunPerawatan = kodebaru4(cbAkunPerawatan.SelectedIndex())
    End Sub

    Private Sub cbAkunPengembangan_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbAkunPengembangan.SelectedIndexChanged
        kodeAkunPengembangan = kodebaru5(cbAkunPengembangan.SelectedIndex())
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If txtPsPengembangan.Text = "" Or IsNumeric(txtPsPengembangan.Text) = False Then
            MsgBox("Persentase pengembangan masih salah!", MsgBoxStyle.Critical, "Peringatan")
            txtPsPengembangan.Focus()
        ElseIf txtPsPerawatan.Text = "" Or IsNumeric(txtPsPerawatan.Text) = False Then
            MsgBox("Persentase perawatan masih salah!", MsgBoxStyle.Critical, "Peringatan")
            txtPsPerawatan.Focus()
        ElseIf txtPsTransport.Text = "" Or IsNumeric(txtPsTransport.Text) = False Then
            MsgBox("Persentase transport masih salah!", MsgBoxStyle.Critical, "Peringatan")
            txtPsTransport.Focus()
        Else
            dataSetting.editSetting(kodeAkunTransaksi, kodeAkunPiutang, kodeAkunTransport, txtPsTransport.Text, kodeAkunPerawatan, txtPsPerawatan.Text, kodeAkunPengembangan, txtPsPengembangan.Text)
            Close()
        End If

    End Sub
End Class