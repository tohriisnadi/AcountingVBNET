Public Class FormEditJenisBarang
    Dim dataJenisBarang As New ClassJenisBarang

    Public Kode As String

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            dataJenisBarang.EditJenisBarang(Kode, txtJenisBarang.Text)
            FormDaftarJenisBarang.loadData()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class