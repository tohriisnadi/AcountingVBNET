Public Class FormAddPembayaranPiutang
    Public NoTrx As String
    Dim bayar As Long
    Dim sisa As Long
    Dim dataPiutang As New ClassPiutang

    Private Sub LabelControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelControl1.Click

    End Sub
    Private Sub DateEdit2_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTglJatuhTempo.EditValueChanged

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If txtNominal.Text = "" Or IsNumeric(txtNominal.Text) = False Then
            MsgBox("Nominal salah!", MsgBoxStyle.Critical, "Peringatan")
            txtNominal.Focus()
        Else
            Try
                sisa = CLng(txtTotal.Text) - (CLng(txtNominal.Text) + CLng(txtBayar.Text))
                bayar = CLng(txtBayar.Text)
                bayar = bayar + CLng(txtNominal.Text)
            Catch ex As Exception

            End Try
            dataPiutang.updatePiutang(NoTrx, sisa, bayar, CLng(txtNominal.Text))
            FormDataPiutang.loadData()
            txtNominal.Text = ""
            Close()
        End If
    End Sub

    Private Sub txtNominal_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNominal.KeyDown
        
        If e.KeyCode = Keys.Enter And txtNominal.Text <> "" Then
            If IsNumeric(txtNominal.Text) = False Then
                MsgBox("Nominal salah!", MsgBoxStyle.Critical, "Peringatan")
            Else
                txtNominal.Text = Format(CLng(txtNominal.Text), "###,###,##0")
                btnAdd.Focus()
            End If
        End If

    End Sub
End Class