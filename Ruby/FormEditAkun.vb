Public Class FormEditAkun
    Public idAkun As String
    Public idKlas As String
    Dim odataKlas As New DataTable
    Dim dataKlas As New ClassSubKelasAkun
    Dim dataAkun As New ClassAkun

    Public IdSub(5000) As String

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If txtNamaAkun.Text = "" Then
            MsgBox("Nama akun masih kosong!", MsgBoxStyle.Critical, "Peringatan")
            txtNamaAkun.Focus()
        Else
            dataAkun.editAkun(idAkun, txtNamaAkun.Text)
            FormDataAkun.loadData()
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Sub loadSubKlasifikasi()
        odataKlas.Clear()
        odataKlas = dataKlas.selectSubKelasAkun
        For i As Integer = 0 To odataKlas.Rows.Count - 1
            IdSub(i) = odataKlas.Rows(i).Item(0)
            cbKlasifikasi.Properties.Items.Add(odataKlas.Rows(i).Item(2))
        Next
    End Sub

    Private Sub FormEditAkun_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        loadSubKlasifikasi()
        'btnAdd.Enabled = False
    End Sub

    Private Sub cbKlasifikasi_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbKlasifikasi.SelectedIndexChanged
        ' btnAdd.Enabled = True
    End Sub
End Class