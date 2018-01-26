Imports System.Data.Odbc
Imports DevExpress.XtraReports.UI
Public Class FormStokOpname
    Dim dataBarang As New ClassBarang
    Dim dataStokOpname As New ClassStokOpname
    Dim OdataBarang As New DataTable

    Dim odataStokOpname As New DataTable
    Dim OrowDataSO As DataRow

    Dim Index As Integer
    Sub LoadDataBarang()
        OdataBarang.Clear()
        OdataBarang = dataBarang.selectBarang
        BindingSource1.DataSource = OdataBarang
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

            GridView1.Columns(1).Visible = False
            GridView1.Columns(2).Visible = False
            GridView1.Columns(6).Visible = False
            GridView1.Columns(7).Visible = False

            GridView1.Columns(0).Caption = "Kode Barang"
            GridView1.Columns(3).Caption = "Nama Barang"
            GridView1.Columns(4).Caption = "Satuan"
            GridView1.Columns(5).Caption = "Harga Beli"
            GridView1.Columns(8).Caption = "Stok"

            GridView1.Columns(5).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            GridView1.Columns(5).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
            GridView1.Columns(5).DisplayFormat.FormatString = "c"

        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub FormStokOpname_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LoadDataBarang()
        LoadDataSO()
    End Sub

    Private Sub GridControl1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl1.DoubleClick
        SetNewRowStokOpname()
    End Sub

    Private Sub GridControl1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl1.Load
        setGrid1()
    End Sub

    Public Sub LoadDataSO()
        ModKoneksi.BukaKoneksi()
        odataStokOpname.Clear()
        SetTabelSO()
        ModKoneksi.TutupKoneksi()
    End Sub

    Sub SetTabelSO()
        odataStokOpname.Rows.Clear()
        odataStokOpname.Columns.Clear()
        odataStokOpname.Columns.Add(New DataColumn("Kode Barang", GetType(String)))
        odataStokOpname.Columns.Add(New DataColumn("Nama Barang", GetType(String)))
        odataStokOpname.Columns.Add(New DataColumn("Satuan", GetType(String)))
        odataStokOpname.Columns.Add(New DataColumn("Stok Sistem", GetType(Integer)))
        odataStokOpname.Columns.Add(New DataColumn("Harga", GetType(Long)))
        odataStokOpname.Columns.Add(New DataColumn("Stok Riil", GetType(String)))
        BindingSource2.DataSource = odataStokOpname
        GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
    End Sub

    Private Function BarangAda(ByVal key As String)
        Dim ketemu As Boolean = False
        Dim index As String = -1
        Dim i As Integer
        For i = 0 To odataStokOpname.Rows.Count - 1
            If ketemu = False And odataStokOpname.Rows(i).Item(0) = key Then
                ketemu = True
                index = i
                Exit For
            End If
        Next
        Return index
    End Function

    Sub SetNewRowStokOpname()
        Index = BarangAda(GridView1.GetFocusedDataRow.Item(0))

        If Index = -1 Then
            OrowDataSO = odataStokOpname.NewRow
            OrowDataSO(0) = GridView1.GetFocusedDataRow.Item(0)
            OrowDataSO(1) = GridView1.GetFocusedDataRow.Item(3)
            OrowDataSO(2) = GridView1.GetFocusedDataRow.Item(4)
            OrowDataSO(3) = GridView1.GetFocusedDataRow.Item(8)
            OrowDataSO(4) = GridView1.GetFocusedDataRow.Item(5)
            OrowDataSO(5) = ""
            odataStokOpname.Rows.Add(OrowDataSO)
            BindingSource2.DataSource = odataStokOpname
        Else
            MsgBox("Barang Sudah ada", MsgBoxStyle.Information + vbOKOnly, "Informasi")
        End If
        setGrid2()
    End Sub

    Sub setGrid2()
        Try
            GridView2.OptionsBehavior.Editable = True
            GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
            GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus

            For i = 0 To GridView2.Columns.Count - 1
                GridView2.Columns(i).OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            Next

            For i = 0 To GridView2.Columns.Count - 1
                GridView2.Columns(i).BestFit()
            Next

            ' GridView2.Columns(3).Visible = False

            GridView2.Columns(4).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            GridView2.Columns(4).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
            GridView2.Columns(4).DisplayFormat.FormatString = "c"

        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        dataStokOpname.AddStokOpname(odataStokOpname)
        Clean()
    End Sub

    Sub Clean()
        LoadDataBarang()
        LoadDataSO()
    End Sub

    Sub cetakLaporan(ByVal odata As DataTable)
        Dim laporan As New laporanDetilHistoryStokOpname
        Dim Tool As ReportPrintTool = New ReportPrintTool(laporan)
        Dim oDataSet As New DataSet
        Dim oDataAdapter As New OdbcDataAdapter
        Dim i As Integer
        Dim currentTime As System.DateTime = System.DateTime.Now

        If oDataSet.Tables.Count <> 0 Then
            oDataSet.Tables.Remove("Table1")
        End If

        'For i = 0 To odata.Rows.Count - 1
        '    totalOrder = totalOrder + odata.Rows(i).Item(6)
        'Next

        oDataSet.Tables.Add(odata.Copy)

        laporan.DataSource = oDataSet
        laporan.DataAdapter = oDataAdapter
        laporan.DataMember = "Table1"

        laporan.lbNamaBarang.DataBindings.Add("Text", Nothing, "Nama Barang")
        laporan.lbSatuan.DataBindings.Add("Text", Nothing, "Satuan")
        laporan.lbHarga.DataBindings.Add("Text", Nothing, "Harga", "{0:c2}")
        laporan.lbStokRiil.DataBindings.Add("Text", Nothing, "Stok Riil")

        Tool.ShowPreview()
    End Sub

    Private Sub btnCetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCetak.Click
        cetakLaporan(odataStokOpname)
    End Sub
End Class