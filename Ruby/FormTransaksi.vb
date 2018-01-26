Imports DevExpress.XtraGrid
Public Class FormTransaksi
    Dim WForm As Single = 951
    Dim HForm As Single = 611
    Dim WFormRe, HFormRe, SWidth, SHeight As Single
    Public kodePelanggan As String
    Dim odataTabel As New DataTable
    Dim oRow As DataRow

    Sub loadTabel()
        odataTabel.Columns.Clear()
        odataTabel.Rows.Clear()
        odataTabel.Columns.Add(New DataColumn("Kode Barang", GetType(String)))
        odataTabel.Columns.Add(New DataColumn("Nama Barang", GetType(String)))
        odataTabel.Columns.Add(New DataColumn("Ukuran", GetType(String)))
        odataTabel.Columns.Add(New DataColumn("Qty", GetType(Long)))
        odataTabel.Columns.Add(New DataColumn("Harga Sewa", GetType(Long)))
        odataTabel.Columns.Add(New DataColumn("Subtotal", GetType(Long)))
        BindingSource1.DataSource = odataTabel
    End Sub
    Private Function BarangAda(ByVal key As String)
        Dim ketemu As Boolean = False
        Dim index As String = -1
        Dim i As Integer

        For i = 0 To odataTabel.Rows.Count - 1
            If ketemu = False And odataTabel.Rows(i).Item(0) = key Then
                ketemu = True
                index = i
                Exit For
            End If
        Next

        Return index
    End Function

    Public Sub newRow(ByVal kodeBarang As String, ByVal NamaBarang As String, ByVal ukuran As String, ByVal qty As Long, ByVal harga As Long)
        Dim subTotal As Long
        Dim indexBarang As Integer
        Dim pengali As Long
        Dim odata As New DataTable
        odata.Clear()
        'odata = dataBarang.selectKonversiStokbyBarcodeNSatuan(IdBarang, satuan)
        'konversi stok 


        indexBarang = BarangAda(kodeBarang)
        If indexBarang = -1 Then
            subTotal = qty * harga
            oRow = odataTabel.NewRow
            oRow(0) = kodeBarang
            oRow(1) = NamaBarang
            oRow(2) = ukuran
            oRow(3) = qty
            oRow(4) = harga

            oRow(5) = subTotal

            odataTabel.Rows.Add(oRow)


            GridControl2.Refresh()
        Else
            UpdateRow(kodeBarang, indexBarang, qty)
        End If
        cekTotal()
    End Sub
    Sub setGrid()
        Try
            GridView2.OptionsBehavior.Editable = False
            GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
            GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus

            For i = 0 To GridView2.Columns.Count - 1
                GridView2.Columns(i).OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            Next

            GridView2.Columns(0).Caption = "Kode Barang"
            GridView2.Columns(1).Caption = "Nama Barang"
            GridView2.Columns(2).Caption = "Ukuran"
            GridView2.Columns(3).Caption = "Qty"
            GridView2.Columns(4).Caption = "Harga Sewa"
            GridView2.Columns(5).Caption = "Sub Total"


            For i = 0 To GridView2.Columns.Count - 1
                GridView2.Columns(i).BestFit()
            Next

            GridView2.Columns(4).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            GridView2.Columns(4).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
            GridView2.Columns(4).DisplayFormat.FormatString = "c"
            GridView2.Columns(5).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            GridView2.Columns(5).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
            GridView2.Columns(5).DisplayFormat.FormatString = "c"

        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub UpdateRow(ByVal IdBarang As String, ByVal index As String, ByVal Qty As Long)
        Dim Subtotal As Double

        odataTabel.Rows(index).Item(3) = CInt(odataTabel.Rows(index).Item(3)) + Qty
        Subtotal = (CInt(odataTabel.Rows(index).Item(3)) * CLng(odataTabel.Rows(index).Item(4)))
        odataTabel.Rows(index).Item(5) = Subtotal
        cekTotal()
        GridControl2.Refresh()

    End Sub

    Private Sub txtKonsumen_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtKonsumen.KeyDown
        If e.KeyCode = Keys.F1 Then
            FormDaftarPelanggan.X = "1"
            FormDaftarPelanggan.ShowDialog()
        ElseIf txtKonsumen.Text <> "" And e.KeyCode = Keys.Enter Then
            txtKodeBarang.Focus()
        End If
    End Sub
    Sub cekTotal()
        Dim i As Integer
        lbTotal.Text = 0

        For i = 0 To odataTabel.Rows.Count - 1
            lbTotal.Text = odataTabel.Rows(i).Item(5) + CInt(lbTotal.Text)
        Next

        lbTotal.Text = Format(CDbl(lbTotal.Text), "###,###,##0.00")
    End Sub
    Private Sub txtKodeBarang_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtKodeBarang.KeyDown
        If e.KeyCode = Keys.F1 Then
            '  FormDaftarBarang.GridView1.SetRowCellValue(GridControl.AutoFilterRowHandle, GridView2.Columns(1), txtKodeBarang.Text)
            FormDaftarBarang.X = "1"
            FormDaftarBarang.ShowDialog()
        ElseIf e.KeyCode = Keys.Enter And txtKodeBarang.Text <> "" Then
            Dim dataBarang As New ClassBarang
            Dim odataBarang As New DataTable

            odataBarang.Clear()
            odataBarang = dataBarang.selectBarangbyKode(txtKodeBarang.Text)

            If odataBarang.Rows.Count = 0 Then
                MsgBox("Barang dengan tidak ditemukan!", MsgBoxStyle.Information, "Pemberitahuan")
            Else
                Try
                    txtKodeBarang.Text = odataBarang.Rows(0).Item(0)
                    txtNamaBarang.Text = odataBarang.Rows(0).Item(3)
                    txtUkuran.Text = odataBarang.Rows(0).Item(4)
                    txtHarga.Text = Format(odataBarang.Rows(0).Item(5), "###,###,##0")
                    txtQty.Focus()
                Catch ex As Exception

                End Try
            End If
        ElseIf e.KeyCode = Keys.Enter And txtKodeBarang.Text = "" And odataTabel.Rows().Count() > 0 Then
            FormProsesPembayaran.kodePelanggan = kodePelanggan
            FormProsesPembayaran.total = CInt(lbTotal.Text)
            FormProsesPembayaran.ShowDialog()
        ElseIf e.KeyCode = Keys.Down Then
            GridControl2.Focus()

        End If
    End Sub

    Private Sub FormTransaksi_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        loadTabel()
        lbTanggal.Text = Date.Today.ToString("dd/MM/yyyy")
        lbOperator.Text = ModKoneksi.namaOperator
        txtKonsumen.Focus()
    End Sub

    Private Sub FormTransaksi_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
        WFormRe = Me.Width
        HFormRe = Me.Height

        'Resize width
        If WFormRe > WForm Then
            SWidth = WFormRe - WForm
            PanelGrid.Width = PanelGrid.Width + SWidth
            WForm = WFormRe
        ElseIf WFormRe < WForm Then
            SWidth = WForm - WFormRe
            PanelGrid.Width = PanelGrid.Width - SWidth
            WForm = WFormRe
        End If

        'Resize height
        If HFormRe > HForm Then
            SHeight = HFormRe - HForm
            PanelGrid.Height = PanelGrid.Height + SHeight
            HForm = HFormRe
        ElseIf HFormRe < HForm Then
            SHeight = HForm - HFormRe
            PanelGrid.Height = PanelGrid.Height - SHeight
            HForm = HFormRe
        End If
    End Sub

    Private Sub txtKodeBarang_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKodeBarang.EditValueChanged

    End Sub

    Private Sub txtQty_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQty.EditValueChanged

    End Sub
    Public Sub setClearAll()
        kodePelanggan = ""
        txtKonsumen.Text = ""
        clear()
        odataTabel.Clear()
        GridControl2.Refresh()
        txtKonsumen.Focus()
        txtKonsumen.SelectAll()
        cekTotal()
    End Sub
    Private Sub txtQty_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtQty.KeyDown
        If e.KeyCode = Keys.Enter And txtQty.Text <> "" Then
            txtHarga.Focus()
        End If
    End Sub

    Private Sub txtHarga_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHarga.EditValueChanged

    End Sub

    Private Sub txtHarga_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtHarga.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtKodeBarang.Text = "" Then
                MsgBox("Barang masih kosong!", MsgBoxStyle.Critical, "Pemberitahuan")
                txtKodeBarang.Focus()
            ElseIf txtQty.Text = "" Or IsNumeric(txtQty.Text) = False Then
                MsgBox("Qty masih salah!", MsgBoxStyle.Critical, "Pemberitahuan")
                txtQty.Focus()
            ElseIf txtHarga.Text = "" Or IsNumeric(txtQty.Text) = False Then
                MsgBox("Harga sewa masih salah!", MsgBoxStyle.Critical, "Pemberitahuan")
                txtQty.Focus()
            Else
                newRow(txtKodeBarang.Text, txtNamaBarang.Text, txtUkuran.Text, txtQty.Text, txtHarga.Text)
                clear()
                txtKodeBarang.Focus()
                setGrid()
            End If
        End If
    End Sub
    Sub clear()
        txtKodeBarang.Text = ""
        txtNamaBarang.Text = ""
        txtUkuran.Text = ""
        txtQty.Text = ""
        txtHarga.Text = ""
    End Sub

    Private Sub GridControl2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl2.KeyDown
        If e.KeyCode = Keys.OemMinus And Keys.Subtract Then
            Dim indexBarang As String
            Try
                indexBarang = BarangAda(GridView2.GetFocusedDataRow.Item(0))
                If GridView2.GetFocusedDataRow.Item(3) > 1 Then
                    UpdateRow(GridView2.GetFocusedDataRow.Item(0), indexBarang, -1)
                Else
                    odataTabel.Rows.RemoveAt(indexBarang)
                    GridControl2.Refresh()
                    setGrid()
                    cekTotal()
                End If
            Catch ex As Exception

            End Try
        ElseIf e.KeyCode = Keys.Enter Then
            txtKodeBarang.Focus()

        End If
    End Sub

    Private Sub GridControl2_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl2.Load
        setGrid()
    End Sub

    Private Sub GridControl2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridControl2.Click

    End Sub
End Class