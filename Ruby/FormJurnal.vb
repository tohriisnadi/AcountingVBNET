﻿Public Class FormJurnal
    Dim DataAkun As New ClassAkun
    Dim oDataTabelGrid As New DataTable
    Dim oDataTabelAkun As New DataTable
    Dim kodeAkun(1000) As String
    Dim oRow As DataRow
    Dim tanggal(3) As String
    Dim tangalGabung As String
    Dim TotalKredit, TotalDebet As Long



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
    Private Sub setColumn()
        Try
            oDataTabelGrid.Rows.Clear()
            oDataTabelGrid.Columns.Clear()
            oDataTabelGrid.Columns.Add(New DataColumn("No", GetType(Integer)))
            oDataTabelGrid.Columns.Add(New DataColumn("IdAKun", GetType(String)))
            oDataTabelGrid.Columns.Add(New DataColumn("Akun", GetType(String)))
            oDataTabelGrid.Columns.Add(New DataColumn("Debet", GetType(Long)))
            oDataTabelGrid.Columns.Add(New DataColumn("Kredit", GetType(Long)))
            BindingSource1.DataSource = oDataTabelGrid
        Catch ex As Exception

        End Try
    End Sub
    Private Sub addNewRow(ByVal IdAkun As String, ByVal Akun As String, ByVal Debet As Long, ByVal Kredit As Long)
        oRow = oDataTabelGrid.NewRow()
        oRow(0) = oDataTabelGrid.Rows.Count() + 1
        oRow(1) = IdAkun
        oRow(2) = Akun
        oRow(3) = Debet
        oRow(4) = Kredit
        oDataTabelGrid.Rows.Add(oRow)
    End Sub
    Private Sub setGrid()
        GridView1.OptionsBehavior.Editable = False
        GridView1.Columns(1).Visible = False
        GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        For i = 0 To GridView1.Columns.Count - 1
            GridView1.Columns(i).OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            GridView1.Columns(i).BestFit()
        Next
        GridView1.Columns(3).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        GridView1.Columns(3).DisplayFormat.FormatString = "c"
        GridView1.Columns(4).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        GridView1.Columns(4).DisplayFormat.FormatString = "c"

        GridView1.Columns(3).Summary.Clear()
        GridView1.Columns(3).Summary.Add(DevExpress.Data.SummaryItemType.Sum, "Debet", "{0:c2}")

        GridView1.Columns(4).Summary.Clear()
        GridView1.Columns(4).Summary.Add(DevExpress.Data.SummaryItemType.Sum, "Kredit", "{0:c2}")

    End Sub
    Private Sub UrutAngka()
        Dim i As Integer
        For i = 0 To oDataTabelGrid.Rows.Count() - 1
            oDataTabelGrid.Rows(i).Item(0) = i + 1
        Next
    End Sub
    Private Sub getTotal()
        Dim a As Integer
        TotalDebet = 0
        TotalKredit = 0
        For a = 0 To oDataTabelGrid.Rows.Count() - 1
            TotalDebet = TotalDebet + oDataTabelGrid.Rows(a).Item(3)
            TotalKredit = TotalKredit + oDataTabelGrid.Rows(a).Item(4)
        Next
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Close()

    End Sub

    Private Sub FormJurnal_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        clearField()
    End Sub
    Private Sub FormJurnal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Show()
        MaskedTextBox1.Text = Format(Date.Now, "dd/MM/yyyy")
        setColumn()
        loadDataAkun()
        MaskedTextBox1.Focus()
        MaskedTextBox1.SelectAll()
    End Sub
   
    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Delete Then
            If oDataTabelGrid.Rows.Count() > 0 Then
                oDataTabelGrid.Rows.RemoveAt(GridView1.GetFocusedDataSourceRowIndex())
                UrutAngka()
                cbAkun.Focus()
            End If
        End If
    End Sub
    Private Sub GridControl1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl1.Load
        Try
            setGrid()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txtKredit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtKredit.KeyDown
        Dim IdAkun() As String
        If e.KeyCode = Keys.Enter Then
            If txtKredit.Text <> "" And IsNumeric(txtKredit.Text) = True Then
                txtKredit.Text = Format(CLng(txtKredit.Text), "###,###,##0")
                IdAkun = cbAkun.Text.Split("-")

                If CInt(IdAkun(0)) < 0 Then
                    MsgBox("Silahkan pilih akun", MsgBoxStyle.Critical, "Peringatan")
                    cbAkun.Focus()
                ElseIf txtDebet.Text = "" Then
                    MsgBox("Debet masih kosong", MsgBoxStyle.Critical, "Peringatan")
                    txtDebet.Focus()
                ElseIf IsNumeric(txtDebet.Text) = False Then
                    MsgBox("Debet harus angka", MsgBoxStyle.Critical, "Peringatan")
                    txtDebet.Focus()
                ElseIf txtKredit.Text = "" Then
                    MsgBox("Kredit masih kosong", MsgBoxStyle.Critical, "Peringatan")
                    txtKredit.Focus()
                ElseIf IsNumeric(txtKredit.Text) = False Then
                    MsgBox("Kredit harus angka", MsgBoxStyle.Critical, "Peringatan")
                    txtKredit.Focus()
                

                Else
                    addNewRow(IdAkun(0), cbAkun.Text, txtDebet.Text, txtKredit.Text)
                    txtDebet.Text = ""
                    txtKredit.Text = ""
                    getTotal()
                    Try
                        setGrid()
                    Catch ex As Exception

                    End Try
                    cbAkun.Focus()
                End If
            End If
            
        End If
    End Sub

    Private Sub cbAkun_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbAkun.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtDebet.Focus()
        End If
    End Sub

    Private Sub txtDebet_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDebet.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtDebet.Text <> "" And IsNumeric(txtDebet.Text) = True Then
                txtDebet.Text = Format(CLng(txtDebet.Text), "###,###,##0")
                txtKredit.Focus()
            End If
        End If

    End Sub

    Private Sub txtTgl_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTgl.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtBuktiTransaksi.Focus()
        End If
    End Sub

    Private Sub txtBuktiTransaksi_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBuktiTransaksi.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtKeterangan.Focus()
        End If
    End Sub

    Private Sub txtKeterangan_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtKeterangan.KeyDown
        If e.KeyCode = Keys.Enter Then
            cbAkun.Focus()
        End If
    End Sub
    Dim DataJurnal As New ClassJurnal
    Sub clearField()
        txtKeterangan.Text = ""
        txtBuktiTransaksi.Text = ""
        txtDebet.Text = "0"
        txtKredit.Text = "0"
        txtTgl.Text = ""
        oDataTabelGrid.Clear()
        txtTgl.Focus()
    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If txtBuktiTransaksi.Text = "" Then
            MsgBox("Bukti transaksi masih kosong", MsgBoxStyle.Critical, "Peringatan")
            txtBuktiTransaksi.Focus()
        ElseIf txtKeterangan.Text = "" Then
            MsgBox("Keterangan transaksi masih kosong", MsgBoxStyle.Critical, "Peringatan")
            txtKeterangan.Focus()
        ElseIf oDataTabelGrid.Rows.Count() <= 0 Then
            MsgBox("List jurnal masih kosong", MsgBoxStyle.Critical, "Peringatan")
            cbAkun.Focus()
        ElseIf IsDate(tangalGabung) = False Then
            MsgBox("Format tanggal salah", MsgBoxStyle.Critical, "Peringatan")
            MaskedTextBox1.Focus()
        Else
            If TotalDebet <> TotalKredit Then
                MsgBox("Total debet dan total kredit masih belum sama", MsgBoxStyle.Critical, "Peringatan")
            Else
                DataJurnal.addMasterJurnal(tangalGabung, txtBuktiTransaksi.Text, txtKeterangan.Text, oDataTabelGrid)
                clearField()

                'Tempat simpan
            End If
        End If
    End Sub

    Private Sub MaskedTextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MaskedTextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Tanggal = MaskedTextBox1.Text.Split("/")
            tangalGabung = tanggal(1) & "/" & tanggal(0) & "/" & tanggal(2)
            txtBuktiTransaksi.Focus()
        End If
    End Sub

    Sub LoadJurnalIncome(ByVal odataReservasi As DataTable)
        Me.Show()
        MaskedTextBox1.Text = Format(Date.Now, "dd/MM/yyyy")
        setColumn()
        loadDataAkun()
        MaskedTextBox1.Focus()
        MaskedTextBox1.SelectAll()

        For i As Integer = 0 To odataReservasi.Rows.Count - 1
            If CLng(odataReservasi.Rows(i).Item(6)) > 0 Then
                addNewRow(oDataTabelAkun.Rows(0).Item(0), oDataTabelAkun.Rows(0).Item(5), odataReservasi.Rows(i).Item(6), odataReservasi.Rows(i).Item(5))
                addNewRow(oDataTabelAkun.Rows(9).Item(0), oDataTabelAkun.Rows(9).Item(5), odataReservasi.Rows(i).Item(5), odataReservasi.Rows(i).Item(6))
            ElseIf CLng(odataReservasi.Rows(i).Item(5)) > 0 Then
                addNewRow(oDataTabelAkun.Rows(1).Item(0), oDataTabelAkun.Rows(1).Item(5), odataReservasi.Rows(i).Item(6), odataReservasi.Rows(i).Item(5))
                addNewRow(oDataTabelAkun.Rows(9).Item(0), oDataTabelAkun.Rows(9).Item(5), odataReservasi.Rows(i).Item(5), odataReservasi.Rows(i).Item(6))
            End If
        Next
        setGrid()
    End Sub

End Class