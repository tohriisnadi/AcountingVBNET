Public Class FormTotalPenerimaan
    Dim dataPenerimaan As New ClassPenerimaan
    Public Odata As DataTable

    Dim StatusBayar As String = ""

    Public KodePO As String
    Public KodeSuplier As String

    Dim Total1 As Long
    Dim Total2 As Long
    Dim Diskon As Long

    Dim tgl(3) As String
    Dim tanggalGabung As String

    Sub ConvertTanggal()
        tgl = txtTglNota.Text.Split("/")

        tanggalGabung = tgl(1) & "/" & tgl(0) & "/" & tgl(2)
    End Sub


    Sub Hitung()
        Dim STotal1, STotal2, SDiskon As Long
        Total1 = 0
        Total2 = 0
        Diskon = 0
        STotal1 = 0
        STotal2 = 0
        SDiskon = 0
        For i As Integer = 0 To Odata.Rows.Count - 1
            STotal1 = STotal1 + Odata.Rows(i).Item(2)
            STotal2 = STotal2 + Odata.Rows(i).Item(4)
            SDiskon = SDiskon + Odata.Rows(i).Item(3)
        Next

        Total1 = STotal1
        Total2 = STotal2
        Diskon = SDiskon
        txtTotalPenerimaan.Text = Format(CLng(Total2), "###,###,##0")
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If RadioGroup1.SelectedIndex = 0 Then
            StatusBayar = "1"
        ElseIf RadioGroup1.SelectedIndex = 1 Then
            StatusBayar = "0"
            FormDetailPembayaranHutang.txtTotal.Text = Total2

        End If

        ConvertTanggal()
        dataPenerimaan.AddPenerimaanBarang(KodePO, KodeSuplier, tanggalGabung, StatusBayar, Total1, Diskon, Total2, txtKeterangan.Text, Odata)
        Clean()
        FormAddPenerimaanBarang.clean()
        Me.Close()
        FormAddPenerimaanBarang.Close()
        FormDataPemerimaanBarang.loadData()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub FormTotalPenerimaan_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Hitung()
        txtTglNota.Text = Format(Now, "dd/MM/yyyy")
        RadioGroup1.SelectedIndex = 0
        txtTotalPenerimaan.Enabled = False
        Show()
        txtTglNota.Focus()
    End Sub

    Private Sub Clean()
        txtTotalPenerimaan.Text = ""
        txtTglNota.Text = Format(Now, "dd/MM/yyyy")
        txtKeterangan.Text = ""
    End Sub

    Private Sub txtTglNota_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTglNota.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtKeterangan.Focus()
        End If
    End Sub
End Class