Imports System.Xml
Imports System.Globalization
Public Class FormPembelian
    Dim databBarangMasuk As New ClassBarangMasuk
    Dim lastWidth As Single = 1160
    Dim lastHeight As Single = 820
    Public odataTabelHutang As New DataTable
    Dim datasuplier As New ClassSuplier
    Dim databarang As New ClassBarang
    Dim oDataTabelUnBound As New DataTable
    Dim oRow As DataRow
    Dim hargaJualAwal As Long = -5
    Public apo As Integer
   
    Private Function BarangAda(ByVal key As String)
        Dim ketemu As Boolean = False
        Dim index As String = -1
        Dim i As Integer

        For i = 0 To oDataTabelUnBound.Rows.Count - 1
            If ketemu = False And oDataTabelUnBound.Rows(i).Item(0) = key Then
                ketemu = True
                index = i
                Exit For
            End If
        Next

        Return index
    End Function

    Public Sub newRow(ByVal barcode As String, ByVal namaBarang As String, ByVal satuan As String, ByVal qty As Long, ByVal hargaBeli As Long)
        Dim subTotal As Long
        Dim indexBarang As Integer

        indexBarang = BarangAda(barcode)
        If indexBarang = -1 Then
            subTotal = qty * hargaBeli
            oRow = oDataTabelUnBound.NewRow

            'oRow(0) = Barcode
            'oRow(1) = namaBarang
            'oRow(2) = satuan
            'oRow(3) = qty
            'oRow(4) = hargaBeli
            'oRow(5) = margin
            'oRow(6) = hargajual
            'oRow(7) = subTotal
            'oRow(8) = tglExp

            oRow(0) = barcode
            oRow(1) = namaBarang
            oRow(2) = satuan
            oRow(3) = qty
            oRow(4) = hargaBeli
            oRow(5) = subTotal

            oDataTabelUnBound.Rows.Add(oRow)

            GridView1.Columns(4).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
            GridView1.Columns(4).DisplayFormat.FormatString = "c"
            GridView1.Columns(5).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
            GridView1.Columns(5).DisplayFormat.FormatString = "c"
            GridView1.Columns(0).Visible = False
            GridControl1.Refresh()
        Else
            MsgBox("Barang Sudah Dimasukan Sebelumnya , " + vbCrLf + "Silakan Ubah pada Form Berikut")

            'menampilkan data ke form update pembelian 

            ' FormUpdate.txtBarcode.Text = oDataTabelUnBound.Rows(indexBarang).Item(0)
            'FormUpdate.txtNamaBarang.Text = oDataTabelUnBound.Rows(indexBarang).Item(1)
            'FormUpdate.txtSatuan.Text = oDataTabelUnBound.Rows(indexBarang).Item(2)
            'FormUpdate.txtQty.Text = oDataTabelUnBound.Rows(indexBarang).Item(3)
            'FormUpdate.txtHargaBeli.Text = oDataTabelUnBound.Rows(indexBarang).Item(4)
            'FormUpdate.txtMargin.Text = oDataTabelUnBound.Rows(indexBarang).Item(5)
            'FormUpdate.txtHargaJual.Text = oDataTabelUnBound.Rows(indexBarang).Item(6)
            'FormUpdate.MaskedTextBox1.Text = oDataTabelUnBound.Rows(indexBarang).Item(8)
            'bersihkan()
            'FormUpdate.ShowDialog()
            txtQty.Focus()

        End If

    End Sub


    Private Sub aturGrid()
        Dim dWidth As Single
        Dim dHeight As Single

        dWidth = Me.Width - lastWidth
        dHeight = Me.Height - lastHeight

        If dWidth >= 0 Then
            GridControl1.Width = GridControl1.Width + dWidth
            GridControl1.Height = GridControl1.Height + dHeight
        End If
    End Sub
    Function SudahDimasukanSebelumnya() As Boolean
        Dim oDataTabel As New DataTable
        
        oDataTabel = databBarangMasuk.selectDataPembelianByNota(txtNota.Text)
        If oDataTabel.Rows.Count <> 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub txtNota_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNota.KeyPress
        
        If e.KeyChar = ChrW(13) And txtNota.Text <> "" Then

            If SudahDimasukanSebelumnya() = True Then
                MsgBox("No. Nota Sudah Dimasukan Sebelumnya !", MsgBoxStyle.Critical, "Peringatan !")
                txtNota.Focus()
            Else
                txtTglNota.Focus()
            End If
            'txtTglNota.Focus()
        End If
    End Sub

    Private Sub txtTglNota_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = ChrW(13) And txtTglNota.Text <> "" Then
            txtLookUpSuplier.Focus()
        End If
    End Sub

    Private Sub txtLookUpSuplier_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtLookUpSuplier.KeyDown

        'menampilkan daftar suplier
        If e.KeyValue = Keys.F1 Then
            FormDaftarSuplier.x = 1
            FormDaftarSuplier.ShowDialog()

        ElseIf e.KeyValue = Keys.Enter And txtNamaSuplier.Text <> "" Then
            txtNamaBarang.Focus()
        End If
    End Sub

    Private Sub txtLookUpSuplier_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLookUpSuplier.KeyPress
        If e.KeyChar = ChrW(13) Then
            cekSuplier()
        End If
    End Sub

    Private Sub txtLookUpSuplier_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLookUpSuplier.LostFocus
        cekSuplier()
    End Sub

    Sub cekSuplier()
        Dim DataTabelSuplier As New DataTable
        Dim DataHutang As New ClassHutang
        Dim hutang As Long

        If txtLookUpSuplier.Text <> "" Then
            DataTabelSuplier = datasuplier.selectDataSuplierByKode(txtLookUpSuplier.Text)
            If DataTabelSuplier.Rows.Count = 0 Then
                MsgBox("Kode Data Suplier Tidak Ditemukan!", MsgBoxStyle.Critical, "Peringatan")
                txtLookUpSuplier.Text = ""
                txtNamaSuplier.Text = ""
                txtAlamatSuplier.Text = ""
                txtHutang.Text = ""
                odataTabelHutang.Clear()
                btnDetil.Enabled = False
                txtLookUpSuplier.Focus()

            Else
                txtLookUpSuplier.Text = DataTabelSuplier.Rows(0).Item(0)
                txtNamaSuplier.Text = DataTabelSuplier.Rows(0).Item(1)
                txtAlamatSuplier.Text = DataTabelSuplier.Rows(0).Item(2)
                ' hutang = DataHutang.dataHutang(DataTabelSuplier.Rows(0).Item(0))
                If hutang = 0 Then
                    btnDetil.Enabled = False
                Else
                    btnDetil.Enabled = True
                End If
                odataTabelHutang.Clear()
                txtHutang.Text = Format(hutang, "###,###,##0")
                ' odataTabelHutang = DataHutang.oDataTabelHutang
                '  FormDetailHutang.oddataTabelHutang = odataTabelHutang
                txtBarcode.Focus()

            End If
        End If
    End Sub

    Private Sub btnDetil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDetil.Click
        'FormDetailHutang.oddataTabelHutang = odataTabelHutang
        'FormDetailHutang.ShowDialog()

    End Sub

    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyValue = Keys.F3 Then

            Dim indexBarang As Integer

            indexBarang = BarangAda(GridView1.GetFocusedDataRow.Item(0))

            'Menampilkan data dari pembelian ke update data
            '   FormUpdate.txtBarcode.Text = oDataTabelUnBound.Rows(indexBarang).Item(0)
            '   FormUpdate.txtNamaBarang.Text = oDataTabelUnBound.Rows(indexBarang).Item(1)
            '  FormUpdate.txtSatuan.Text = oDataTabelUnBound.Rows(indexBarang).Item(2)
            ' FormUpdate.txtQty.Text = oDataTabelUnBound.Rows(indexBarang).Item(3)
            'FormUpdate.txtHargaBeli.Text = oDataTabelUnBound.Rows(indexBarang).Item(4)
            'FormUpdate.txtMargin.Text = oDataTabelUnBound.Rows(indexBarang).Item(5)
            'FormUpdate.txtHargaJual.Text = oDataTabelUnBound.Rows(indexBarang).Item(6)

            'bersihkan()
            'FormUpdate.ShowDialog()
            txtQty.Focus()

        ElseIf e.KeyValue = Keys.F2 Then
            txtBarcode.Focus()

            'Fungsi Menghapus data
        ElseIf e.KeyValue = Keys.Delete Then
            If (MsgBox("Anda Yakin Menghapus Data Pembelian " & GridView1.GetFocusedDataRow().Item(1) & "", MsgBoxStyle.YesNo, "KOnfirmasi")) = MsgBoxResult.Yes Then
                HapusPembelian()
                'Menampilkan GrendTotal
                grandTotal()

            End If

        End If


    End Sub

    Private Sub FormPembelian_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        bersihkan()

        oDataTabelUnBound.Columns.Clear()

    End Sub

    Private Sub FormPembelian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ciNewFormat As New CultureInfo(CultureInfo.CurrentCulture.ToString())
        ciNewFormat.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
        System.Threading.Thread.CurrentThread.CurrentCulture = ciNewFormat

        GridControl1.Width = 1109
        GridControl1.Height = 470
        aturGrid()
        setkolomDataTabel()

        BindingSource1.DataSource = oDataTabelUnBound
    End Sub

    Private Sub txtBarcode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBarcode.KeyDown
        If e.KeyValue = Keys.F1 Then
            '  FormDaftarBarang.kode = txtBarcode.Text
            FormDaftarBarang.x = 1
            FormDaftarBarang.ShowDialog()

        ElseIf e.KeyValue = Keys.F2 Then
            GridControl1.Focus()

        ElseIf e.KeyValue = Keys.F6 Then
            PanelControl3.Visible = True
            cash()
            RadioGroup1.Focus()

        ElseIf e.KeyValue = Keys.Escape Then
            PanelControl3.Visible = False
            txtBarcode.Focus()

        End If
    End Sub
    Sub batalBayar(ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyValue = Keys.Escape Then
            PanelControl3.Visible = False
            txtBarcode.Focus()
            RadioGroup1.SelectedIndex = 0

        End If
    End Sub
    Private Sub txtBarcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBarcode.KeyPress
        If e.KeyChar = ChrW(13) And txtBarcode.Text <> "" Then
            cekbarcode()
        End If
    End Sub

    Private Sub txtBarcode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBarcode.LostFocus
        'MsgBox(apo)
        'If apo <> 9 Then
        ' cekbarcode()
        'End If


    End Sub

    Sub reset()

    End Sub
    Sub cekbarcode()
        Dim DataTabelBarang As New DataTable

        If txtBarcode.Text <> "" Then
            '   DataTabelBarang = databarang.selectDataBarangByBarcode(txtBarcode.Text)

            If DataTabelBarang.Rows.Count = 0 Then

                txtNamaBarang.Text = ""
                txtSatuan.Text = ""
                txtQty.Text = ""
                txtHargaBeli.Text = ""
                txtMargin.Text = ""
                txtHargaJual.Text = ""
                txtBarcode.Focus()
                If (MsgBox("Kode Data Barang Tidak Ditemukan !" & vbCrLf & "Apakah Ingin Ditambahkan ?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes) Then
                    ' FormAddBarang.x = 1
                    'FormAddBarang.txtBarcode.Text = txtBarcode.Text
                    ' FormAddBarang.CheckEdit1.Checked = True

                    FormAddBarang.ShowDialog()
                Else
                    txtBarcode.Text = ""
                End If

            Else

                txtBarcode.Text = DataTabelBarang.Rows(0).Item(1)
                txtNamaBarang.Text = DataTabelBarang.Rows(0).Item(2)
                txtSatuan.Text = DataTabelBarang.Rows(0).Item(4)
                txtHargaBeli.Text = Format(CLng(DataTabelBarang.Rows(0).Item(5)), "###,###,##0")
                'txtMargin.Text = CLng(DataTabelBarang.Rows(0).Item(6))
                'txtHargaJual.Text = Format(CLng(DataTabelBarang.Rows(0).Item(7)), "###,###,##0")

                txtQty.Focus()


            End If
        End If
    End Sub

    Private Sub txtQty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQty.KeyPress
        If e.KeyChar = ChrW(13) And txtQty.Text <> "" Then
            If IsNumeric(txtQty.Text) = True Then
                txtHargaBeli.Focus()
            Else
                MsgBox("Pastikan anda memasukan angka dengan benar !", MsgBoxStyle.Critical, "Peringatan !")
                txtQty.Focus()

            End If

        End If
    End Sub
    Dim hargaJual As Long
    Private Sub txtHargaBeli_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtHargaBeli.KeyPress
        If e.KeyChar = ChrW(13) And txtHargaBeli.Text <> "" Then
            'Try
            Dim oDataTabelBarco As New DataTable
            If e.KeyChar = ChrW(13) Then
                'If IsDate(MaskedTextBox1.Text) = True Then
                If txtNota.Text = "" Then
                    MsgBox("Nota Masih Kosong !", MsgBoxStyle.Critical, "Peringatan")
                    txtNota.Focus()
                ElseIf IsDate(txtTglNota.Text) = False Then
                    MsgBox("Format tanggal salah !" & vbCrLf & "Format yang benar hari/bulan/tahun !", MsgBoxStyle.Critical, "Peringatan !")
                    txtTglNota.Focus()
                ElseIf txtTglNota.Text = "" Then
                    MsgBox("Tanggal Nota Masih Kosong !", MsgBoxStyle.Critical, "Peringatan")
                    txtTglNota.Focus()
                ElseIf txtLookUpSuplier.Text = "" Then
                    MsgBox("Data Suplier Masih Kosong !", MsgBoxStyle.Critical, "Peringatan")
                    txtLookUpSuplier.Focus()
                ElseIf txtQty.Text = "" Then
                    MsgBox("Qty Barang Masih Kosong !", MsgBoxStyle.Critical, "Peringatan")
                    txtQty.Focus()

                ElseIf txtHargaBeli.Text = "" Then
                    MsgBox("Harga Beli Barang Masih Kosong !", MsgBoxStyle.Critical, "Peringatan")
                    txtHargaBeli.Focus()
                Else
                    If SudahDimasukanSebelumnya() = True Then
                        MsgBox("No.Nota Sudah Pernah Dimasukan Sebelumnya !", MsgBoxStyle.Critical, "Peringatan !")
                        txtNota.Focus()
                    Else
                        newRow(txtBarcode.Text, txtNamaBarang.Text, txtSatuan.Text, txtQty.Text, txtHargaBeli.Text)
                        clear()
                        grandTotal()
                        txtNamaBarang.Focus()
                    End If
                End If
            End If
            'Catch ex As Exception
            'MsgBox("Program error !" & vbCrLf & "Pastikan anda memasukan angka dengan benar !" & vbCrLf & "Tekan OK untuk melanjutkan ...", MsgBoxStyle.Critical, "Peringatan !")
            'End Try
        End If
    End Sub

    Private Sub txtMargin_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMargin.KeyDown
        If e.KeyCode = Keys.Return Then

            If txtMargin.Text <> "" Then
                Try
                    txtHargaJual.Text = CLng(txtHargaBeli.Text) + (CLng(txtHargaBeli.Text) * CDbl(txtMargin.Text) / 100)
                Catch ex As Exception
                    MsgBox("Program error !" & vbCrLf & "Pastikan anda memasukan angka dengan benar !" & vbCrLf & "Tekan OK untuk melanjutkan ...", MsgBoxStyle.Critical, "Peringatan !")
                End Try
            End If
        End If

    End Sub

    Public Sub updateRow(ByVal barcode As String, ByVal namaBarang As String, ByVal satuan As String, ByVal Qty As Long, ByVal hargaBeli As Long, ByVal margin As Double, ByVal hargaJual As Long, ByVal tgl As String)
        Dim i As Integer
        Dim subTotal As Long
        i = BarangAda(barcode)
        subTotal = Qty * hargaBeli
        oDataTabelUnBound.Rows(i).Item(3) = Qty
        oDataTabelUnBound.Rows(i).Item(4) = hargaBeli
        oDataTabelUnBound.Rows(i).Item(5) = margin
        oDataTabelUnBound.Rows(i).Item(6) = hargaJual
        oDataTabelUnBound.Rows(i).Item(7) = subTotal
        oDataTabelUnBound.Rows(i).Item(8) = tgl

        GridControl1.Refresh()
        grandTotal()
    End Sub



    Private Sub txtMargin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMargin.KeyPress
        If e.KeyChar = ChrW(13) And txtMargin.Text <> "" Then
            Try
                txtHargaJual.Text = Format(CLng(txtHargaBeli.Text) + (CDbl(txtMargin.Text) / 100 * CLng(txtHargaBeli.Text)), "###,###,##0")
                txtHargaJual.Focus()

            Catch ex As Exception
                MsgBox("Program error !" & vbCrLf & "Pastikan anda memasukan angka dengan benar !" & vbCrLf & "Tekan OK untuk melanjutkan ...", MsgBoxStyle.Critical, "Peringatan !")
            End Try
        End If
    End Sub
    Sub setkolomDataTabel()
        'oDataTabelUnBound.Rows.Clear()
        'oDataTabelUnBound.Columns.Add(New DataColumn("Barcode", GetType(String))) '0
        'oDataTabelUnBound.Columns.Add(New DataColumn("Nama Barang", GetType(String))) '1
        'oDataTabelUnBound.Columns.Add(New DataColumn("Satuan", GetType(String))) '2
        'oDataTabelUnBound.Columns.Add(New DataColumn("Qty", GetType(Integer))) '3
        'oDataTabelUnBound.Columns.Add(New DataColumn("Harga Beli", GetType(Long))) '4
        'oDataTabelUnBound.Columns.Add(New DataColumn("Margin", GetType(Double))) '5
        'oDataTabelUnBound.Columns.Add(New DataColumn("Harga Jual", GetType(Long))) '6
        'oDataTabelUnBound.Columns.Add(New DataColumn("Sub Total", GetType(Long))) '7
        'oDataTabelUnBound.Columns.Add(New DataColumn("Tgl Kadaluwarsa", GetType(String))) '8

        oDataTabelUnBound.Columns.Add(New DataColumn("Barcode", GetType(String))) '0
        oDataTabelUnBound.Columns.Add(New DataColumn("Nama Barang", GetType(String))) '1
        oDataTabelUnBound.Columns.Add(New DataColumn("Satuan", GetType(String))) '2
        oDataTabelUnBound.Columns.Add(New DataColumn("Qty", GetType(Integer))) '3
        oDataTabelUnBound.Columns.Add(New DataColumn("Harga Beli", GetType(Long))) '4
        oDataTabelUnBound.Columns.Add(New DataColumn("Sub Total", GetType(Long))) '5
        
    End Sub

    Private Sub txtHargaJual_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtHargaJual.KeyDown


    End Sub
    'MEMBERSIHKAN UNTUK KOLOM BARANG
    Sub clear()
        txtBarcode.Text = ""
        txtNamaBarang.Text = ""
        txtSatuan.Text = ""
        txtQty.Text = ""
        txtHargaBeli.Text = ""
        txtMargin.Text = ""
        txtHargaJual.Text = ""
        MaskedTextBox1.Text = ""
        txtBarcode.Focus()
        hargaJualAwal = -5

    End Sub

    'MEMBERSIHKAN SEMUA DATA SETELAH TRANSAKSI
    Sub bersihkan()
        oDataTabelUnBound.Rows.Clear()
        txtNota.Text = ""
        txtTglNota.Text = ""
        txtLookUpSuplier.Text = ""
        txtNamaSuplier.Text = ""
        txtAlamatSuplier.Text = ""
        txtHutang.Text = ""
        lbTot.Text = "0"
        txtBarcode.Text = ""
        txtNamaBarang.Text = ""
        txtSatuan.Text = ""
        txtQty.Text = ""
        txtHargaBeli.Text = ""
        txtMargin.Text = ""
        txtHargaJual.Text = ""
        txtTotal.Text = ""
        txtJatuhTempo.Text = ""
        txtUangMuka.Text = ""
        txtSisa.Text = ""
        PanelControl3.Visible = False
        txtNota.Focus()

    End Sub
   

    Sub grandTotal()
        Dim z As Integer
        Dim GrandTotal As Long
        GrandTotal = 0
        For z = 0 To oDataTabelUnBound.Rows.Count - 1
            GrandTotal = GrandTotal + (oDataTabelUnBound.Rows(z).Item(4) * oDataTabelUnBound.Rows(z).Item(3))

        Next

        lbTot.Text = Format(GrandTotal, "###,###,##0")
        txtTotal.Text = Format(GrandTotal, "###,###,##0")

    End Sub

    Sub HapusPembelian()
        Dim x As Integer
        x = BarangAda(GridView1.GetFocusedDataRow.Item(0))
        oDataTabelUnBound.Rows(x).Delete()

    End Sub

    Private Sub RadioGroup1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles RadioGroup1.KeyDown
        batalBayar(e)
    End Sub

    Private Sub RadioGroup1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles RadioGroup1.KeyPress
        If e.KeyChar = ChrW(13) Then
            If RadioGroup1.SelectedIndex = 0 Then

                saveBarangLunas()
                bersihkan()


            Else

                txtJatuhTempo.Focus()

            End If
        End If
    End Sub


    Private Sub RadioGroup1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioGroup1.SelectedIndexChanged

        If RadioGroup1.SelectedIndex = 0 Then
            cash()


        ElseIf RadioGroup1.SelectedIndex = 1 Then
            Kredit()
            txtSisa.Text = Format(CLng(txtTotal.Text), "###,###,##0")

        End If
    End Sub

    Sub Kredit()
        txtJatuhTempo.Enabled = True
        txtUangMuka.Enabled = True
        txtSisa.Enabled = False
        txtUangMuka.Text = "0"
        txtSisa.Text = txtTotal.Text
        txtJatuhTempo.Focus()
        bersih()

    End Sub
    Sub cash()
        txtJatuhTempo.Enabled = False
        txtUangMuka.Enabled = False
        txtSisa.Enabled = False
        txtUangMuka.Text = "0"
        txtSisa.Text = "0"

        bersih()

    End Sub


    Private Sub txtJatuhTempo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtJatuhTempo.KeyDown
        batalBayar(e)

    End Sub

    Private Sub txtUangMuka_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUangMuka.KeyDown
        batalBayar(e)

    End Sub

    Private Sub txtSisa_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSisa.KeyDown

        batalBayar(e)

    End Sub

    Private Sub txtJatuhTempo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtJatuhTempo.KeyPress

        If e.KeyChar = ChrW(13) And txtJatuhTempo.Text <> "" Then
            txtUangMuka.Focus()
        End If

    End Sub

    Private Sub txtUangMuka_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUangMuka.KeyPress
        Dim harga As Long
        If e.KeyChar = ChrW(13) Then
            Try
                harga = txtUangMuka.Text
                txtUangMuka.Text = Format(harga, "###,###,##0")
                saveBarangKredit()
                bersihkan()

            Catch ex As Exception
                MsgBox("Program error !" & vbCrLf & vbCrLf & ex.Message & "Pastikan anda memasukan angka dengan benar !" & vbCrLf & "Tekan OK untuk melanjutkan ...", MsgBoxStyle.Critical, "Peringatan !")
            End Try

        End If
    End Sub

    Private Sub txtUangMuka_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUangMuka.TextChanged
        Dim harga As Long
        If txtTotal.Text <> "" Then

            Try
                If txtUangMuka.Text <> "" Then
                    harga = CStr(CLng(txtTotal.Text) - CLng(txtUangMuka.Text))
                    txtSisa.Text = Format(harga, "###,###,##0")
                Else
                    txtUangMuka.Text = "0"
                    txtSisa.Text = Format(CLng(txtTotal.Text), "###,###,##0")
                End If

            Catch ex As Exception
                MsgBox("Program error !" & vbCrLf & "Pastikan anda memasukan angka dengan benar !" & vbCrLf & "Tekan OK untuk melanjutkan ...", MsgBoxStyle.Critical, "Peringatan !")

            End Try
        End If

    End Sub

    Sub bersih()
        txtJatuhTempo.Text = ""
        txtUangMuka.Text = 0
        txtSisa.Text = 0

    End Sub
    Sub saveBarangLunas()
        Dim dt As String
        Try
            dt = CDate(txtJatuhTempo.Text).ToString("MM/dd/yyyy")
        Catch ex As Exception
            dt = ""
        End Try
        databBarangMasuk.AddBarangMasuk(txtNota.Text, CDate(txtTglNota.Text).ToString("MM/dd/yyyy"), txtLookUpSuplier.Text, txtTotal.Text, modKoneksi.kodeOperator, "1", "0", txtUangMuka.Text, dt, oDataTabelUnBound)
    End Sub
    Sub saveBarangKredit()
        databBarangMasuk.AddBarangMasuk(txtNota.Text, CDate(txtTglNota.Text).ToString("MM/dd/yyyy"), txtLookUpSuplier.Text, txtTotal.Text, modKoneksi.kodeOperator, "0", "0", txtUangMuka.Text, CDate(txtJatuhTempo.Text).ToString("MM/dd/yyyy"), oDataTabelUnBound)
    End Sub

    
    Private Sub txtMargin_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMargin.TextChanged

    End Sub

    Private Sub txtHargaJual_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtHargaJual.KeyPress


        If e.KeyChar = ChrW(13) And txtHargaJual.Text <> "" Then
            If IsNumeric(Format(txtHargaJual.Text, "")) = True Then
                If CLng(txtHargaJual.Text) = hargaJualAwal Then
                    'newRow(txtBarcode.Text, txtNamaBarang.Text, txtSatuan.Text, txtQty.Text, txtHargaBeli.Text, txtMargin.Text, txtHargaJual.Text, MaskedTextBox1.Text)
                    'clear()
                    'grandTotal()
                    MaskedTextBox1.Focus()
                Else
                    txtHargaJual.Text = Format(CLng(txtHargaJual.Text), "###,###,##0")
                    txtMargin.Text = (CLng(txtHargaJual.Text) - CLng(txtHargaBeli.Text)) / CLng(txtHargaBeli.Text) * 100
                    hargaJualAwal = txtHargaJual.Text
                End If
            Else
                MsgBox("Pastikan anda memasukan angka dengan benar !", MsgBoxStyle.Critical, "Peringatan !")
            End If
        End If
    End Sub

    Private Sub txtHargaJual_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHargaJual.TextChanged

    End Sub

    Private Sub txtNota_LocationChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNota.LocationChanged

    End Sub

    Private Sub txtNota_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNota.LostFocus


    End Sub

    Private Sub txtNota_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNota.TextChanged

    End Sub

    Private Sub txtTglNota_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTglNota.KeyPress
        If txtTglNota.Text <> "" And e.KeyChar = ChrW(13) Then
            If IsDate(txtTglNota.Text) = True Then
                txtLookUpSuplier.Focus()
            Else
                MsgBox("Format tanggal salah !" & vbCrLf & "Format yang benar hari/bulan/tahun !", MsgBoxStyle.Critical, "Peringatan !")
                txtTglNota.Focus()
            End If
        End If
    End Sub

    Private Sub txtBarcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBarcode.TextChanged

    End Sub

    Private Sub txtHargaBeli_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHargaBeli.TextChanged

    End Sub

    Private Sub txtQty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQty.TextChanged

    End Sub

    Private Sub MaskedTextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MaskedTextBox1.KeyPress

    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles MaskedTextBox1.MaskInputRejected

    End Sub

    Private Sub txtJatuhTempo_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtJatuhTempo.EditValueChanged

    End Sub

    Private Sub txtNamaBarang_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNamaBarang.KeyDown
        If e.KeyValue = Keys.F1 Then
            '  FormDaftarBarang.kode = txtBarcode.Text
            txtBarcode.Text = ""
            FormDaftarBarang.X = 2
            FormDaftarBarang.ShowDialog()

        ElseIf e.KeyValue = Keys.F2 Then
            GridControl1.Focus()

        ElseIf e.KeyValue = Keys.F6 Then
            PanelControl3.Visible = True
            cash()
            RadioGroup1.Focus()

        ElseIf e.KeyValue = Keys.Escape Then
            PanelControl3.Visible = False
            txtBarcode.Focus()

        ElseIf e.KeyValue = Keys.Enter And txtBarcode.Text <> "" Then
            txtQty.Focus()
        End If

    End Sub

    Private Sub txtNamaBarang_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNamaBarang.TextChanged

    End Sub

    Private Sub PanelControl2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PanelControl2.Paint

    End Sub

    Private Sub txtLookUpSuplier_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLookUpSuplier.TextChanged

    End Sub

    Private Sub txtTotal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTotal.TextChanged

    End Sub
End Class