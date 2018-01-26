'Imports System.Data.Odbc
'Imports DevExpress.XtraReports.UI
'Public Class FormPenjualanBarangPerDistributor
'    'Dim Datadist As New ClassDistributor
'    'Dim DataBarangKeluar As New ClassBarangKeluar
'    'Dim oDataBarangdist As New DataTable
'    Dim oDatadist As New DataTable



'    Dim kodeDist(1000) As String
'    Sub loadDistributor()
'        Dim i As Integer
'        oDatadist.Clear()
'        oDatadist = Datadist.selectDistributor
'        cmbDist.Properties.Items.Clear()
'        For i = 0 To oDatadist.Rows.Count - 1
'            kodeDist(i) = oDatadist.Rows(i).Item(0)
'            cmbDist.Properties.Items.Add(oDatadist.Rows(i).Item(1))
'        Next
'    End Sub
'    Dim oDataTabelDistributor As New DataTable
'    Dim DataDistibutor As New ClassDistributor

'    Sub setDataDistributor()
'        Try
'            oDataTabelDistributor.Clear()
'            oDataTabelDistributor = DataDistibutor.selectDistributor
'            SearchLookUpEdit1.Properties.DataSource = oDataTabelDistributor
'            SearchLookUpEdit1.Properties.DisplayMember = "Distributor"
'            SearchLookUpEdit1.Properties.ValueMember = "IdDistributor"

'            SearchLookUpEdit1View.Columns(2).Visible = False
'            SearchLookUpEdit1View.Columns(3).Visible = False
'            SearchLookUpEdit1View.Columns(4).Visible = False
'            SearchLookUpEdit1View.Columns(5).Visible = False
'            SearchLookUpEdit1View.Columns(6).Visible = False
'            SearchLookUpEdit1View.Columns(7).Visible = False
'            SearchLookUpEdit1View.Columns(8).Visible = False
'            SearchLookUpEdit1View.Columns(9).Visible = False
'            SearchLookUpEdit1View.Columns(10).Visible = False
'            SearchLookUpEdit1View.Columns(11).Visible = False
'            SearchLookUpEdit1View.Columns(12).Visible = False
'        Catch ex As Exception
'            'MsgBox(ex.Message)
'        End Try
'    End Sub
'    Sub loadData(ByVal tgl1 As String, ByVal tgl2 As String, ByVal dist As String)
'        Try
'            oDataBarangdist.Clear()
'            oDataBarangdist = DataBarangKeluar.SelectPenjualanPerdistributor(tgl1, tgl2, kodeDist(cmbDist.SelectedIndex))
'            BindingSource1.DataSource = oDataBarangdist
'            setGRID()

'        Catch ex As Exception

'        End Try

'    End Sub

'    Sub setGRID()
'        Try
'            GridView1.OptionsBehavior.Editable = False
'            GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
'            GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus

'            For i = 0 To GridView1.Columns.Count - 1
'                GridView1.Columns(i).OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
'            Next
'            GridView1.Columns(0).Caption = "Tanggal"
'            GridView1.Columns(1).Caption = "Jenis Barang"
'            GridView1.Columns(2).Caption = "Barcode"
'            GridView1.Columns(3).Caption = "Nama Barang"
'            GridView1.Columns(4).Caption = "Satuan"
'            GridView1.Columns(5).Caption = "Total"
'            GridView1.Columns(6).Caption = "Harga Jual"
'            GridView1.Columns(7).Caption = "Sub Total"

'            GridView1.Columns(6).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
'            GridView1.Columns(6).DisplayFormat.FormatString = "c"
'            GridView1.Columns(7).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
'            GridView1.Columns(7).DisplayFormat.FormatString = "c"

'            GridView1.Columns(0).BestFit()
'            GridView1.Columns(0).Visible = False
'            GridView1.Columns(1).BestFit()
'            GridView1.Columns(2).BestFit()
'            GridView1.Columns(3).BestFit()
'            GridView1.Columns(4).BestFit()
'            GridView1.Columns(5).BestFit()
'            GridView1.Columns(6).BestFit()
'            GridView1.Columns(7).BestFit()


'            GridView1.Columns(7).Summary.Clear()
'            GridView1.Columns(7).Summary.Add(DevExpress.Data.SummaryItemType.Sum, "SubTotal", "{0:c2}")

'        Catch ex As Exception
'            MsgBox(ex.Message, MsgBoxStyle.Critical, "Peringatan ")
'        End Try
'    End Sub



'    Private Sub FormPenjualanBarangPerDistributor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
'        GridControl1.Height = Me.Height * 0.86
'        loadDistributor()
'        setTabelCetak()
'        setDataDistributor()
'        Show()
'        txttgl.Text = Format(Date.Now, "dd/MM/yyyy")
'        txttgl2.Text = Format(Date.Now, "dd/MM/yyyy")
'        txttgl.Focus()

'    End Sub
'    Dim tanggal(3) As String
'    Dim tangalgabung As String
'    Dim tanggal2(3) As String
'    Dim tangalgabung2 As String
'    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAdd.Click



'        tanggal = txttgl.Text.Split("/")
'        tangalgabung = tanggal(1) & "/" & tanggal(0) & "/" & tanggal(2)

'        tanggal2 = txttgl2.Text.Split("/")
'        tangalgabung2 = tanggal2(1) & "/" & tanggal2(0) & "/" & tanggal2(2)

'        If IsDate(tangalgabung) = False Then
'            MsgBox("Format tanggal salah", MsgBoxStyle.Critical, "Peringatan")
'        ElseIf IsDate(tangalgabung2) = False Then
'            MsgBox("Format tanggal salah", MsgBoxStyle.Critical, "Peringatan")

'        Else
'            loadData(tangalgabung, tangalgabung2, cmbDist.Text)
'            setGRID()

'        End If
'    End Sub

'    Private Sub cmbDist_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbDist.KeyDown
'        e.SuppressKeyPress = True
'    End Sub
'    Dim oDataTabelCetak As New DataTable
'    Dim oRowCetak As DataRow

'    Sub setTabelCetak()
'        Try
'            oDataTabelCetak.Rows.Clear()
'            oDataTabelCetak.Columns.Clear()
'            oDataTabelCetak.Clear()

'            oDataTabelCetak.Columns.Add(New DataColumn("Tanggal", GetType(String))) '0
'            oDataTabelCetak.Columns.Add(New DataColumn("Jenis", GetType(String))) '1
'            oDataTabelCetak.Columns.Add(New DataColumn("barcode", GetType(String))) '2
'            oDataTabelCetak.Columns.Add(New DataColumn("NamaBarang", GetType(String))) '3
'            oDataTabelCetak.Columns.Add(New DataColumn("Satuan", GetType(String))) '4
'            oDataTabelCetak.Columns.Add(New DataColumn("total", GetType(Long))) '5
'            oDataTabelCetak.Columns.Add(New DataColumn("HargaJual", GetType(Long))) '6
'            oDataTabelCetak.Columns.Add(New DataColumn("SubTotal", GetType(Long))) '7

'        Catch ex As Exception
'            'MsgBox(ex.Message)
'        End Try
'    End Sub

'    Sub TransferData(ByVal Tanggal As String, ByVal JenisBarang As String, ByVal barcode As String, ByVal namaBArang As String, ByVal satuan As String, ByVal total As Long, ByVal hargaJual As Long, ByVal subtotal As Long)
'        oRowCetak = oDataTabelCetak.NewRow
'        oRowCetak(0) = Tanggal
'        oRowCetak(1) = JenisBarang
'        oRowCetak(2) = barcode
'        oRowCetak(3) = namaBArang
'        oRowCetak(4) = satuan
'        oRowCetak(5) = total
'        oRowCetak(6) = hargaJual
'        oRowCetak(7) = subtotal

'        oDataTabelCetak.Rows.Add(oRowCetak)
'    End Sub

'    Private Sub cetakLaporan(ByVal odata As DataTable, ByVal distributor As String)
'        Dim sum As Long

'        Dim Report As New ReportPenjualanPerDist
'        Dim Tool As ReportPrintTool = New ReportPrintTool(Report)
'        Dim oDataSet As New DataSet
'        Dim oDataAdapter As New OdbcDataAdapter
'        Dim i As Integer

'        sum = 0

'        Try
'            For i = 0 To odata.Rows.Count - 1
'                sum += odata.Rows(i).Item(7)
'            Next

'            If oDataSet.Tables.Count <> 0 Then
'                oDataSet.Tables.Remove("Table1")
'            End If
'            oDataSet.Tables.Add(odata.Copy)

'            Report.DataSource = oDataSet
'            Report.DataAdapter = oDataAdapter
'            Report.DataMember = "Table1"

'            Report.lbSUm.Text = FormatCurrency(sum, 2, 0, 0)

'            Report.lbPrintBy.Text = ModKoneksi.namaOperator
'            Report.lbPrintDate.Text = Date.Now.ToString("dd MM yyyy")
'            Report.lbDistributor.Text = distributor

'            Report.lbFilterDate.Text = CDate(tangalgabung).ToString("dd/MM/yyyy")
'            Report.lbFilterDate2.Text = CDate(tangalgabung2).ToString("dd/MM/yyyy")

'            Report.lbTanggal.DataBindings.Add("Text", Nothing, "Tanggal")
'            Report.lbJenisBarang.DataBindings.Add("Text", Nothing, "Jenis")
'            Report.lbBarcode.DataBindings.Add("Text", Nothing, "barcode")
'            Report.lbBarang.DataBindings.Add("Text", Nothing, "NamaBarang")
'            Report.lbSatuan.DataBindings.Add("Text", Nothing, "Satuan")
'            Report.lbQty.DataBindings.Add("Text", Nothing, "total")
'            Report.lbHargaJual.DataBindings.Add("Text", Nothing, "HargaJual", "{0:c2}")
'            Report.lbSubtotal.DataBindings.Add("Text", Nothing, "SubTotal", "{0:c2}")


'            Tool.ShowPreview()
'        Catch ex As Exception
'            MsgBox(ex.Message)
'        End Try

'    End Sub


'    Private Sub FormPenjualanBarangPerDistributor_ResizeEnd(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ResizeEnd
'        GridControl1.Height = Me.Height * 0.86
'    End Sub

'    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
'        Dim i As Integer
'        oDataTabelCetak.Clear()

'        For i = 0 To oDataBarangdist.Rows.Count - 1
'            TransferData(GridView1.GetDataRow(i).Item(0), GridView1.GetDataRow(i).Item(1), GridView1.GetDataRow(i).Item(2), GridView1.GetDataRow(i).Item(3), GridView1.GetDataRow(i).Item(4), GridView1.GetDataRow(i).Item(5), GridView1.GetDataRow(i).Item(6), GridView1.GetDataRow(i).Item(7))
'        Next

'        cetakLaporan(oDataTabelCetak, cmbDist.Text)
'    End Sub

'    Private Sub SearchLookUpEdit1_ControlAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.ControlEventArgs) Handles SearchLookUpEdit1.ControlAdded

'    End Sub

'    Private Sub SearchLookUpEdit1View_CustomDrawFilterPanel(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomDrawObjectEventArgs) Handles SearchLookUpEdit1View.CustomDrawFilterPanel
'        Try
'            SearchLookUpEdit1View.Columns(2).Visible = False
'            SearchLookUpEdit1View.Columns(3).Visible = False
'            SearchLookUpEdit1View.Columns(4).Visible = False
'            SearchLookUpEdit1View.Columns(5).Visible = False
'            SearchLookUpEdit1View.Columns(6).Visible = False
'            SearchLookUpEdit1View.Columns(7).Visible = False
'            SearchLookUpEdit1View.Columns(8).Visible = False
'            SearchLookUpEdit1View.Columns(9).Visible = False
'            SearchLookUpEdit1View.Columns(10).Visible = False
'            SearchLookUpEdit1View.Columns(11).Visible = False
'            SearchLookUpEdit1View.Columns(12).Visible = False

'        Catch ex As Exception

'        End Try
'    End Sub

'    Private Sub SearchLookUpEdit1View_CustomRowFilter(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowFilterEventArgs) Handles SearchLookUpEdit1View.CustomRowFilter
'        Try
'            SearchLookUpEdit1View.Columns(2).Visible = False
'            SearchLookUpEdit1View.Columns(3).Visible = False
'            SearchLookUpEdit1View.Columns(4).Visible = False
'            SearchLookUpEdit1View.Columns(5).Visible = False
'            SearchLookUpEdit1View.Columns(6).Visible = False
'            SearchLookUpEdit1View.Columns(7).Visible = False
'            SearchLookUpEdit1View.Columns(8).Visible = False
'            SearchLookUpEdit1View.Columns(9).Visible = False
'            SearchLookUpEdit1View.Columns(10).Visible = False
'            SearchLookUpEdit1View.Columns(11).Visible = False
'            SearchLookUpEdit1View.Columns(12).Visible = False

'        Catch ex As Exception

'        End Try


'    End Sub

'    Private Sub txttgl_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txttgl.KeyDown
'        If e.KeyCode = Keys.Enter Then
'            txttgl2.Focus()

'        End If
'    End Sub

'    Private Sub txttgl_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles txttgl.MaskInputRejected

'    End Sub

'    Private Sub txttgl2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txttgl2.KeyDown
'        If e.KeyCode = Keys.Enter Then
'            SearchLookUpEdit1.Focus()

'        End If
'    End Sub

'    Private Sub SearchLookUpEdit1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles SearchLookUpEdit1.KeyDown
'        If e.KeyCode = Keys.Enter Then
'            btnAdd.Focus()
'        End If
'    End Sub
'End Class