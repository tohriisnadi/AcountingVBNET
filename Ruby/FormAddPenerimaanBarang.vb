Public Class FormAddPenerimaanBarang
    Dim dataPenerimaan As New ClassPenerimaan

    Dim oDataDetilPO As New DataTable

    Public KodePO As String
    Public kodeSUplier As String

    Sub LoadDataDetilPO()
        oDataDetilPO.Clear()
        oDataDetilPO = dataPenerimaan.SelectDEtilPObyKodePO(KodePO)
        BindingSource1.DataSource = oDataDetilPO
    End Sub

    Sub setGrid1()
        Try
            GridView1.OptionsBehavior.Editable = False
            GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
            GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus

            For i = 0 To GridView1.Columns.Count - 1
                GridView1.Columns(i).OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            Next

            For i = 0 To GridView1.Columns.Count - 1
                GridView1.Columns(i).BestFit()
            Next

            GridView1.Columns(0).Caption = "Kode Barang"
            GridView1.Columns(1).Caption = "Nama Barang"
            GridView1.Columns(2).Caption = "Satuan"
            GridView1.Columns(3).Caption = "Harga Beli"
            GridView1.Columns(4).Caption = "Qty"
            GridView1.Columns(5).Caption = "Sub Total"
            GridView1.Columns(6).Caption = "Keterangan"

            GridView1.Columns(3).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            GridView1.Columns(3).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
            GridView1.Columns(3).DisplayFormat.FormatString = "c"

            GridView1.Columns(5).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            GridView1.Columns(5).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
            GridView1.Columns(5).DisplayFormat.FormatString = "c"

        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub FormAddPenerimaanBarang_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LoadDataDetilPO()
        LoadDataPenerimaanBarang()
    End Sub

    Private Sub GridControl1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl1.DoubleClick
        FormAddBarangMasuk.txtKodeBarang.Text = GridView1.GetFocusedDataRow.Item(0)
        FormAddBarangMasuk.txtNamaBarang.Text = GridView1.GetFocusedDataRow.Item(1)
        FormAddBarangMasuk.txtHargaBeli.Text = Format(CLng(GridView1.GetFocusedDataRow.Item(3)), "###,###,##0")
        FormAddBarangMasuk.txtSatuanPesan.Text = GridView1.GetFocusedDataRow.Item(2)
        FormAddBarangMasuk.txtSatuanTerima.Text = GridView1.GetFocusedDataRow.Item(2)
        FormAddBarangMasuk.txtQtyPesan.Text = GridView1.GetFocusedDataRow.Item(4)
        FormAddBarangMasuk.ShowDialog()
    End Sub

    Private Sub GridControl1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl1.Load
        setGrid1()
    End Sub

    Dim odataPenerimaan As New DataTable
    Dim oRowDataPenerimaan As DataRow
    Dim Index As Integer

    Public Sub LoadDataPenerimaanBarang()
        ModKoneksi.BukaKoneksi()
        odataPenerimaan.Clear()
        SetTabelPenerimaan()
        ModKoneksi.TutupKoneksi()
    End Sub

    Private Sub SetTabelPenerimaan()
        odataPenerimaan.Rows.Clear()
        odataPenerimaan.Columns.Clear()
        odataPenerimaan.Columns.Add(New DataColumn("Kode Barang", GetType(String)))
        odataPenerimaan.Columns.Add(New DataColumn("Nama Barang", GetType(String)))
        odataPenerimaan.Columns.Add(New DataColumn("Harga Beli", GetType(Long)))
        odataPenerimaan.Columns.Add(New DataColumn("Diskon", GetType(String)))
        odataPenerimaan.Columns.Add(New DataColumn("Harga Setelah Diskon", GetType(Long)))
        odataPenerimaan.Columns.Add(New DataColumn("Qty Pesan", GetType(Integer)))
        odataPenerimaan.Columns.Add(New DataColumn("Satuan Pesan", GetType(String)))
        odataPenerimaan.Columns.Add(New DataColumn("Qty Terima", GetType(Integer)))
        odataPenerimaan.Columns.Add(New DataColumn("Satuan Terima", GetType(String)))
        odataPenerimaan.Columns.Add(New DataColumn("SubTotal", GetType(Long)))
        odataPenerimaan.Columns.Add(New DataColumn("Keterangan", GetType(String)))
        BindingSource2.DataSource = odataPenerimaan
        GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
    End Sub

    Sub SetNewRowPenerimaan(ByVal KodeBarang As String, ByVal namaBarang As String, ByVal HargaBeli As Long, ByVal Diskon As Integer, ByVal HargaStlahDiskon As Long, ByVal QtyPesan As Integer, ByVal SatuanPesan As String, ByVal QtyTerima As Integer, ByVal SatuanTerima As String, ByVal Subtotal As Long, ByVal Keterangan As String)
        Index = BarangAda(KodeBarang)
        If Index = -1 Then
            oRowDataPenerimaan = odataPenerimaan.NewRow
            oRowDataPenerimaan(0) = KodeBarang
            oRowDataPenerimaan(1) = namaBarang
            oRowDataPenerimaan(2) = HargaBeli
            oRowDataPenerimaan(3) = Diskon
            oRowDataPenerimaan(4) = HargaStlahDiskon
            oRowDataPenerimaan(5) = QtyPesan
            oRowDataPenerimaan(6) = SatuanPesan
            oRowDataPenerimaan(7) = QtyTerima
            oRowDataPenerimaan(8) = SatuanTerima
            oRowDataPenerimaan(9) = Subtotal
            oRowDataPenerimaan(10) = Keterangan
            odataPenerimaan.Rows.Add(oRowDataPenerimaan)
            BindingSource2.DataSource = odataPenerimaan
        End If
        setGrid2()
    End Sub

    Private Function BarangAda(ByVal key As String)
        Dim ketemu As Boolean = False
        Dim index As String = -1
        Dim i As Integer
        For i = 0 To odataPenerimaan.Rows.Count - 1
            If ketemu = False And odataPenerimaan.Rows(i).Item(0) = key Then
                ketemu = True
                index = i
                Exit For
            End If
        Next
        Return index
    End Function

    Private Sub btnRegisterBarang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegisterBarang.Click
        FormTotalPenerimaan.Odata = odataPenerimaan
        FormTotalPenerimaan.KodePO = KodePO
        FormTotalPenerimaan.KodeSuplier = kodeSUplier
        FormTotalPenerimaan.ShowDialog()
    End Sub
    Sub clean()
        oDataDetilPO.Clear()
        odataPenerimaan.Clear()
    End Sub

    Sub setGrid2()
        Try
            GridView2.OptionsBehavior.Editable = False
            GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
            GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus

            For i = 0 To GridView2.Columns.Count - 1
                GridView1.Columns(i).OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            Next

            For i = 0 To GridView2.Columns.Count - 1
                GridView1.Columns(i).BestFit()
            Next

            GridView2.Columns(2).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            GridView2.Columns(2).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
            GridView2.Columns(2).DisplayFormat.FormatString = "c"

            GridView2.Columns(3).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            GridView2.Columns(3).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
            GridView2.Columns(3).DisplayFormat.FormatString = "c"

            GridView2.Columns(4).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            GridView2.Columns(4).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
            GridView2.Columns(4).DisplayFormat.FormatString = "c"

            GridView2.Columns(9).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            GridView2.Columns(9).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
            GridView2.Columns(9).DisplayFormat.FormatString = "c"

        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try

    End Sub
End Class