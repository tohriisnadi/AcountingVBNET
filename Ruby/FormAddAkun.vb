Public Class FormAddAkun
    Dim dataAkun As New ClassAkun
    Dim odataKlas As New DataTable
    Dim dataKlas As New ClassSubKelasAkun
    Dim kodebaru(1000) As String
    Dim idKlas As String

    Private Sub loadKlasifikasi()
        Dim properties As DevExpress.XtraEditors.Repository.RepositoryItemComboBox = cbKlasifikasi.Properties
        Dim i As Integer

        properties.Items.Clear()
        odataKlas.Clear()
        odataKlas = dataKlas.selectSubKelasAkun()


        For i = 0 To odataKlas.Rows().Count() - 1
            kodebaru(i) = odataKlas.Rows(i).Item(0)
            properties.Items.Add(odataKlas.Rows(i).Item(2))
        Next
        properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If idKlas And cbKlasifikasi.Text = "" Then
            MsgBox("Sub Klasifikasi belum dipilih!", MsgBoxStyle.Critical, "Peringatan!")
            cbKlasifikasi.Focus()
        ElseIf txtNamaAkun.Text = "" Then
            MsgBox("Nama akun belum dimasukkan!", MsgBoxStyle.Critical, "Peringatan!")
            txtNamaAkun.Focus()
        Else
            dataAkun.addAkun(idKlas, txtNamaAkun.Text)

            clean()
            cbKlasifikasi.Focus()
        End If
    End Sub
    Sub clean()
        txtNamaAkun.Text = ""
        idKlas = ""
    End Sub

    Private Sub FormAddAkun_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        loadKlasifikasi()
    End Sub

    Private Sub cbKlasifikasi_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbKlasifikasi.SelectedIndexChanged
        idKlas = kodebaru(cbKlasifikasi.SelectedIndex())
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class