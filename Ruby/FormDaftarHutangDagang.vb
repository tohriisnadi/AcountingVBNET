Imports System.Data.Odbc
Imports DevExpress.XtraReports.UI
Public Class FormDaftarHutangDagang
    Dim odata As New DataTable
    Dim dataHutangDagang As New ClassHutangDagang

    Sub loadData()
        odata.Clear()
        odata = dataHutangDagang.SelectDaftarHutangDagang()
        BindingSource1.DataSource = odata
    End Sub

    Private Sub FormDaftarHutangDagang_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        loadData()
    End Sub

    Sub setGrid()
        Try
            GridView1.OptionsBehavior.Editable = False
            GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
            GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus

            For i = 0 To GridView1.Columns.Count - 1
                GridView1.Columns(i).OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            Next

            GridView1.Columns(0).Visible = False

            For i = 0 To GridView1.Columns.Count - 1
                GridView1.Columns(i).BestFit()
            Next

        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GridControl1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl1.Load
        setGrid()
    End Sub

    Sub cetakLaporan()
        Dim laporan As New LaporanDaftarHutangDagang
        Dim Tool As ReportPrintTool = New ReportPrintTool(laporan)
        Dim oDataSet As New DataSet
        Dim oDataAdapter As New OdbcDataAdapter
        Dim i As Integer
        Dim currentTime As System.DateTime = System.DateTime.Now


        If oDataSet.Tables.Count <> 0 Then
            oDataSet.Tables.Remove("Table1")
        End If

        oDataSet.Tables.Add(odata.Copy)

        laporan.DataSource = oDataSet
        laporan.DataAdapter = oDataAdapter
        laporan.DataMember = "Table1"

        laporan.lblDistributor.DataBindings.Add("Text", Nothing, "Distributor")
        laporan.lblNoFaktur.DataBindings.Add("Text", Nothing, "NoFaktur")
        laporan.lblTanggal.DataBindings.Add("Text", Nothing, "Tanggal")
        laporan.lblTanggalJatuhTempo.DataBindings.Add("Text", Nothing, "TanggalJatuhTempo")
        laporan.lblSisaWaktu.DataBindings.Add("Text", Nothing, "SisaWaktu")
        laporan.lblSisaHutang.DataBindings.Add("Text", Nothing, "SisaHutang")

        Tool.ShowPreview()
    End Sub

    Private Sub btnCetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCetak.Click
        cetakLaporan()
    End Sub
End Class