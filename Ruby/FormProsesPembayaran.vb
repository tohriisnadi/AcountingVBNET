Public Class FormProsesPembayaran
    Public total As Long
    Public kodePelanggan As String
    Dim TGL(), TGL2(), TGL3(), TGL4() As String
    Dim TGLGABUNG, TGLGABUNG2, TGLGABUNG3, TGLGABUNG4 As String
    Public Odata As New DataTable
    Private Sub FormProsesPembayaran_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtTotal.Text = Format(total, "###,###,##0")
        txtDisc.Text = "0"
        txtdiscNominal.Text = "0"
        txtNota.Text = ""
        cmbMetode.Text = ""
        txtTransport.Text = "0"
        txtDP.Text = "0"
        txtSisa.Text = "0"
        txtGrandtotal.Text = "0"
        MaskedTextBox1.Enabled = False
        MaskedTextBox1.Text = Format(Date.Now, "dd/MM/yyyy")
        tglKirim.Text = Format(Date.Now, "dd/MM/yyyy")
        tglAmbil.Text = Format(Date.Now, "dd/MM/yyyy")
        tglPakai.Text = Format(Date.Now, "dd/MM/yyyy")
        Show()
        txtNota.Focus()
    End Sub

    Private Sub txtTransport_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTransport.EditValueChanged

    End Sub

    Private Sub txtTransport_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTransport.KeyDown
        If e.KeyCode = Keys.Enter And IsNumeric(txtTransport.Text) = True Then
            txtTransport.Text = Format(CLng(txtTransport.Text), "###,###,##0")
            'txtGrandtotal.Text = Format(CLng(txtTotal.Text) + CLng(txtTransport.Text), "###,###,##0")
            txtDisc.Focus()
        End If
    End Sub


    Private Sub txtDisc_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDisc.EditValueChanged
        Dim nominal As Double
        Try
            If txtTotal.Text <> "0" And txtTotal.Text <> "" Then
                nominal = (CDbl(txtDisc.Text) / 100) * (CLng(txtTotal.Text) + CLng(txtTransport.Text))
                txtdiscNominal.Text = Format(nominal, "###,###,##0")
                txtGrandtotal.Text = Format(CLng(txtTotal.Text) - nominal + CLng(txtTransport.Text), "###,###,##0")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtdiscNominal_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdiscNominal.EditValueChanged
        Dim persen As Double
        Try
            If txtTotal.Text <> "0" And txtTotal.Text <> "" Then
                persen = CLng(txtdiscNominal.Text) / (CLng(txtTotal.Text) + CLng(txtTransport.Text)) * 100
                txtDisc.Text = persen
                txtGrandtotal.Text = Format(CLng(txtTotal.Text) + CLng(txtTransport.Text) - CLng(txtdiscNominal.Text), "###,###,##0")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtDisc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDisc.KeyDown
        Dim nominal As Double
        If e.KeyCode = Keys.Enter And IsNumeric(txtDisc.Text) = True Then
            nominal = (CDbl(txtDisc.Text) / 100) * (CLng(txtTotal.Text) + CLng(txtTransport.Text))
            txtdiscNominal.Text = Format(nominal, "###,###,##0")
            txtGrandtotal.Text = Format(CLng(txtTotal.Text) - nominal + CLng(txtTransport.Text), "###,###,##0")
            txtdiscNominal.Focus()
        End If
    End Sub

    Private Sub txtdiscNominal_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtdiscNominal.KeyDown
        Dim persen As Double

        If e.KeyCode = Keys.Enter And IsNumeric(txtdiscNominal.Text) = True Then
            persen = CLng(txtdiscNominal.Text) / (CLng(txtTotal.Text) + CLng(txtTransport.Text)) * 100
            txtDisc.Text = persen
            txtGrandtotal.Text = Format(CLng(txtTotal.Text) + CLng(txtTransport.Text) - CLng(txtdiscNominal.Text), "###,###,##0")
            cmbMetode.Focus()
        End If
    End Sub

    Private Sub cmbMetode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbMetode.KeyDown
        If e.KeyCode = Keys.Enter And cmbMetode.Text <> "" Then
            If cmbMetode.Text = "Tunai" Then
                simpan("1")
            ElseIf cmbMetode.Text = "Kredit" Then
                txtDP.Enabled = True
                ' txtTglJatuhTempo.Enabled = True
                MaskedTextBox1.Enabled = True
                txtDP.Focus()
            End If
        End If
    End Sub
    Sub simpan(ByVal isLunas As String)
        Dim DataTransaksi As New ClassTransaksi

        TGL = MaskedTextBox1.Text.Split("/")
        TGLGABUNG = TGL(1) & "/" & TGL(0) & "/" & TGL(2)

        TGL2 = tglKirim.Text.Split("/")
        TGLGABUNG2 = TGL2(1) & "/" & TGL2(0) & "/" & TGL2(2)

        TGL3 = tglPakai.Text.Split("/")
        TGLGABUNG3 = TGL3(1) & "/" & TGL3(0) & "/" & TGL3(2)

        TGL4 = tglAmbil.Text.Split("/")
        TGLGABUNG4 = TGL4(1) & "/" & TGL4(0) & "/" & TGL4(2)

        If IsDate(TGLGABUNG) = False Then
            MsgBox("Format tanggal jatuh tempo salah ", MsgBoxStyle.Critical, "Peringatan")
            MaskedTextBox1.Focus()
        ElseIf IsDate(TGLGABUNG2) = False Then
            MsgBox("Format tanggal Kirim salah ", MsgBoxStyle.Critical, "Peringatan")
            tglKirim.Focus()
        ElseIf IsDate(TGLGABUNG3) = False Then
            MsgBox("Format tanggal Pakai salah ", MsgBoxStyle.Critical, "Peringatan")
            tglPakai.Focus()
        ElseIf IsDate(TGLGABUNG4) = False Then
            MsgBox("Format tanggal Ambil salah ", MsgBoxStyle.Critical, "Peringatan")
            tglAmbil.Focus()
        Else
            DataTransaksi.addTransaksi(txtNota.Text, TGLGABUNG2, TGLGABUNG3, TGLGABUNG4, isLunas, TGLGABUNG, CLng(txtTotal.Text) - CLng(txtdiscNominal.Text), CLng(txtDP.Text), CLng(txtTotal.Text) - CLng(txtdiscNominal.Text) - CLng(txtDP.Text), CLng(txtTransport.Text), CLng(txtGrandtotal.Text), kodePelanggan, Odata)
            Close()
            FormTransaksi.setClearAll()
        End If
    End Sub

    Private Sub txtDP_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDP.EditValueChanged
        Try
            If txtGrandtotal.Text <> 0 And txtGrandtotal.Text <> "" Then
                txtSisa.Text = CInt(txtGrandtotal.Text) - CInt(txtDP.Text)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtDP_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDP.KeyDown
        If e.KeyCode = Keys.Enter And IsNumeric(txtDP.Text) = True Then
            MaskedTextBox1.Focus()
        End If
    End Sub

 

    Private Sub txtNota_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNota.KeyDown
        If e.KeyCode = Keys.Enter And txtNota.Text <> "" Then
            tglKirim.Focus()
        End If
    End Sub

    Private Sub txtSisa_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSisa.EditValueChanged

    End Sub

    Private Sub txtSisa_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSisa.KeyDown
        If e.KeyCode = Keys.Enter And txtSisa.Text <> "" Then
            MaskedTextBox1.Focus()
        End If
    End Sub

    Private Sub MaskedTextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MaskedTextBox1.KeyDown
        If e.KeyCode = Keys.Enter And MaskedTextBox1.Text = "" Then
            TGL = MaskedTextBox1.Text.Split("/")
            TGLGABUNG = TGL(1) & "/" & TGL(0) & "/" & TGL(2)
            If IsDate(TGLGABUNG) = True Then
                simpan("0")
            Else
                MsgBox("Format tanggal salah !", MsgBoxStyle.Critical, "Peringatan")
            End If

        End If
    End Sub

    Private Sub txtNota_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNota.EditValueChanged

    End Sub

    Private Sub tglKirim_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles tglKirim.MaskInputRejected

    End Sub

    Private Sub tglKirim_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tglKirim.KeyDown
        If e.KeyCode = Keys.Enter Then
            tglPakai.Focus()
        End If
    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles MaskedTextBox1.MaskInputRejected

    End Sub

    Private Sub tglPakai_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tglPakai.KeyDown
        If e.KeyCode = Keys.Enter Then
            tglAmbil.Focus()
        End If
    End Sub

    Private Sub tglAmbil_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tglAmbil.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtTransport.Focus()
        End If
    End Sub

    Private Sub cmbMetode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMetode.SelectedIndexChanged

    End Sub
End Class