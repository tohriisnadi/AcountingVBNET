Imports System.Data.Odbc
Imports DevExpress.XtraReports.UI

Public Class FormDetilRO
    Dim dataPenerimaan As New ClassPenerimaan
    Dim OdataDetilRO As New DataTable

    Public kodeRo As String

    Sub LoadDetilRO()
        OdataDetilRO.Clear()
        OdataDetilRO = dataPenerimaan.selectDetilRO(kodeRo)
        BindingSource1.DataSource = OdataDetilRO
    End Sub

    Sub setGrid()
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
            GridView1.Columns(3).Caption = "Harga"
            GridView1.Columns(4).Caption = "Qty"
            GridView1.Columns(5).Caption = "Subtotal"

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

    Private Sub GridControl1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl1.Load
        setGrid()
    End Sub

    Private Sub FormDetilRO_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LoadDetilRO()
        setGrid()
    End Sub

    Sub cetakLaporan(ByVal odata As DataTable)
        Dim laporan As New LaporanDetilRO
        Dim Tool As ReportPrintTool = New ReportPrintTool(laporan)
        Dim oDataSet As New DataSet
        Dim oDataAdapter As New OdbcDataAdapter
        Dim i As Integer
        Dim totalOrder As Long
        Dim currentTime As System.DateTime = System.DateTime.Now


        If oDataSet.Tables.Count <> 0 Then
            oDataSet.Tables.Remove("Table1")
        End If

        For i = 0 To odata.Rows.Count - 1
            totalOrder = totalOrder + odata.Rows(i).Item(5)
        Next

        oDataSet.Tables.Add(odata.Copy)

        laporan.DataSource = oDataSet
        laporan.DataAdapter = oDataAdapter
        laporan.DataMember = "Table1"

        laporan.lbNamaBarang.DataBindings.Add("Text", Nothing, "namaBarang")
        laporan.lbQty.DataBindings.Add("Text", Nothing, "qtyTerima")
        laporan.lbSatuan.DataBindings.Add("Text", Nothing, "Satuan")
        laporan.lbHarga.DataBindings.Add("Text", Nothing, "HargaSetelahDiskon", "{0:c2}")
        laporan.lbJumlah.DataBindings.Add("Text", Nothing, "Subtotal", "{0:c2}")

        laporan.lbTotal.Text = FormatCurrency(totalOrder, 2, 0, 0)
        Tool.ShowPreview()
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        cetakLaporan(OdataDetilRO)
    End Sub
End Class