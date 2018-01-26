Public Class FormAddSubKlas
    Dim dataSubKlas As New ClassSubKelasAkun

    Dim odataKlas As New DataTable

    Dim KodeKlas(5000) As String
    Public X As String = ""
    Sub clean()
        txtSubKlas.Text = ""
        LoadKlas()
        txtSubKlas.Focus()
    End Sub
    Sub LoadKlas()
        odataKlas.Clear()
        odataKlas = dataSubKlas.selectKlas
        For i As Integer = 0 To odataKlas.Rows.Count - 1
            KodeKlas(i) = odataKlas.Rows(i).Item(0)
            cbKlasifikasi.Properties.Items.Add(odataKlas.Rows(i).Item(1))
        Next
    End Sub

    Private Sub FormAddSubKlas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LoadKlas()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            If X = "1" Then
                dataSubKlas.addSubKlas(KodeKlas(cbKlasifikasi.SelectedIndex), txtSubKlas.Text)
                clean()
            End If
           
        Catch ex As Exception

        End Try

    End Sub
End Class