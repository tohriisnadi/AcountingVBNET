Public Class FormKasMasuk
    Dim DataAkun As New ClassAkun
    Dim tanggal(3) As String
    Dim tangalGabung As String
    Dim oDataTabelAkun As New DataTable
    Dim kodeAkun(1000) As String
    Public isKeluar As Boolean

    Private Sub FormKasMasuk_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        MaskedTextBox1.Text = Format(Date.Now, "dd/MM/yyyy")
        loadDataAkun()
        If isKeluar = False Then
            Text = "Kas Masuk"
        Else
            Text = "Kas Keluar"
        End If
    End Sub

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
    Private Sub MaskedTextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MaskedTextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            tanggal = MaskedTextBox1.Text.Split("/")

            tangalGabung = tanggal(1) & "/" & tanggal(0) & "/" & tanggal(2)
            txtBuktiTransaksi.Focus()

        End If
    End Sub

    Private Sub txtBuktiTransaksi_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuktiTransaksi.EditValueChanged

    End Sub

    Private Sub txtBuktiTransaksi_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBuktiTransaksi.KeyDown
        If e.KeyCode = Keys.Enter And txtBuktiTransaksi.Text <> "" Then
            cbAkun.Focus()
        End If
    End Sub

    Private Sub cbAkun_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbAkun.KeyDown
        If e.KeyCode = Keys.Enter And cbAkun.Text <> "" Then
            txtKredit.Focus()
        End If
    End Sub

    Private Sub txtKredit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKredit.EditValueChanged

    End Sub

    Private Sub txtKredit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtKredit.KeyDown
        If e.KeyCode = Keys.Enter And txtKredit.Text <> "" Then
            txtKeterangan.Focus()

        End If
    End Sub
    Dim DataJurnal As New ClassJurnal
    Sub setClear()
        MaskedTextBox1.Text = Format(Date.Now, "dd/MM/yyyy")
        txtBuktiTransaksi.Text = ""
        txtKeterangan.Text = ""
        txtKredit.Text = ""
        cbAkun.Text = ""
        MaskedTextBox1.Focus()
        MaskedTextBox1.SelectAll()
    End Sub
    Private Sub txtKeterangan_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtKeterangan.KeyDown
        Dim IdAkun() As String
        If e.KeyCode = Keys.Enter And txtKeterangan.Text <> "" Then
            If txtBuktiTransaksi.Text = "" Then
                MsgBox("BUkti transaksi masih kosong !", MsgBoxStyle.Critical, "Peringatan")
                txtBuktiTransaksi.SelectAll()
            ElseIf cbAkun.Text = "" Then
                MsgBox("Akun masih kosong !", MsgBoxStyle.Critical, "Peringatan")
                cbAkun.Focus()
                cbAkun.SelectAll()
            ElseIf IsDate(tangalGabung) = False Then
                MsgBox("Tanggal Salah !", MsgBoxStyle.Critical, "Peringatan")
                MaskedTextBox1.SelectAll()
            ElseIf IsNumeric(txtKredit.Text) = False Then
                MsgBox("Nominal harus angka", MsgBoxStyle.Critical, "Peringatan")
                txtKredit.Focus()
            Else
                If MsgBox("Yakin data akan diproses ?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
                    IdAkun = cbAkun.Text.Split("-")
                    If isKeluar = False Then
                        DataJurnal.addMasterJurnal2(tangalGabung, txtBuktiTransaksi.Text, txtKeterangan.Text, "1110", IdAkun(0), CLng(txtKredit.Text))
                    Else
                        DataJurnal.addMasterJurnal2(tangalGabung, txtBuktiTransaksi.Text, txtKeterangan.Text, IdAkun(0), "1110", CLng(txtKredit.Text))

                    End If
                    setClear()
                End If
            End If

        End If
    End Sub

    Private Sub txtKeterangan_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKeterangan.EditValueChanged

    End Sub
End Class