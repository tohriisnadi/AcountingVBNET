Imports System.Data.Odbc
Imports DevExpress.XtraReports.UI

Public Class FormPerubahanModal
    Dim DataJurnal As New ClassJurnal
    Dim DataChart As New ClassChart

    Dim oDataTabelUnbound As New DataTable
    Dim oDataTransaksi As New DataTable
    Dim oDataAkun As New DataTable
    Dim oRow As DataRow

    Sub setTabelUnbound()
        Try
            oDataTabelUnbound.Rows.Clear()
            oDataTabelUnbound.Columns.Clear()
            oDataTabelUnbound.Clear()
            oDataTabelUnbound.Columns.Add(New DataColumn("Nama", GetType(String))) '0
            oDataTabelUnbound.Columns.Add(New DataColumn("Nominal1", GetType(String))) '1
            oDataTabelUnbound.Columns.Add(New DataColumn("Nominal2", GetType(String))) '2
            BindingSource1.DataSource = oDataTabelUnbound
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub addRow(ByVal nama As String, ByVal Nominal1 As String, ByVal nominal2 As String)
        oRow = oDataTabelUnbound.NewRow
        oRow(0) = nama
        oRow(1) = Nominal1
        oRow(2) = nominal2
        oDataTabelUnbound.Rows.Add(oRow)
    End Sub

    Sub IsiData()
        oDataTransaksi.Clear()
        oDataTransaksi = DataJurnal.selectTransaksiLabaRugi
        Dim Modal As Long
        Dim Prive As Long
        Dim LR As Long
        Dim MOdalAkhir As Long

        Dim OdataModal As New DataTable
        Dim odataPrive As New DataTable

        OdataModal.Clear()
        odataPrive.Clear()

        OdataModal = DataChart.SelectModal
        odataPrive = DataChart.SelectPrive


        Modal = OdataModal.Rows(0).Item(0)
        Prive = odataPrive.Rows(0).Item(0)

        '-----------------------------------------------------------------------------------------
        Dim Pendapatan As Long
        Dim PendapatanLain As Long
        Dim Biaya As Long
        Dim biayaLain As Long
        Dim Biaya3 As Long

        Dim totalPendapatan As Long
        Dim totalBiaya As Long

        Dim Total As Long

        Total = 0
        For x = 0 To oDataTransaksi.Rows.Count - 1
            If Microsoft.VisualBasic.Left(oDataTransaksi.Rows(x).Item(0), 1) = 4 Then
                Total += oDataTransaksi.Rows(x).Item(1)
            End If
        Next
        Pendapatan = Total

        Total = 0
        For x = 0 To oDataTransaksi.Rows.Count - 1
            If Microsoft.VisualBasic.Left(oDataTransaksi.Rows(x).Item(0), 1) = 5 Then
                Total += oDataTransaksi.Rows(x).Item(1)
            End If
        Next
        Biaya = Total


        Total = 0
        For x = 0 To oDataTransaksi.Rows.Count - 1
            If Microsoft.VisualBasic.Left(oDataTransaksi.Rows(x).Item(0), 1) = 6 Then
                Total += oDataTransaksi.Rows(x).Item(1)
            End If
        Next
        biayaLain = Total


        Total = 0
        For x = 0 To oDataTransaksi.Rows.Count - 1
            If Microsoft.VisualBasic.Left(oDataTransaksi.Rows(x).Item(0), 1) = 8 Then
                Total += oDataTransaksi.Rows(x).Item(1)
            End If
        Next
        PendapatanLain = Total

        Total = 0
        For x = 0 To oDataTransaksi.Rows.Count - 1
            If Microsoft.VisualBasic.Left(oDataTransaksi.Rows(x).Item(0), 1) = 9 Then
                Total += oDataTransaksi.Rows(x).Item(1)
            End If
        Next
        Biaya3 = Total

        totalPendapatan = Pendapatan + PendapatanLain
        totalBiaya = Biaya + Biaya3 + biayaLain

        LR = totalPendapatan - totalBiaya

        '--------------------------------------------------------------------------------------------------------
        MOdalAkhir = Modal - Prive + LR

        addRow("Modal Awal", " ", Format(Modal, "###,###,##0"))
        addRow("", "", "")
        addRow("Prive", Format(Prive, "###,###,##0"), "")
        addRow("Laba / Rugi ", Format(LR, "###,###,##0"), "")
        addRow("", "", "")
        addRow("Modal AKhir ", "", Format(MOdalAkhir, "###,###,##0"))

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

            GridView1.Columns(2).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            GridView1.Columns(3).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            GridView1.Columns(4).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far

            ' GridView1.Columns(4).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
            'GridView1.Columns(4).DisplayFormat.FormatString = "c"
            'GridView1.Columns(5).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            'GridView1.Columns(5).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
            'GridView1.Columns(5).DisplayFormat.FormatString = "c"
            GridView1.Columns(0).Visible = False
            ' GridView1.Columns(4).Visible = False

        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub FormPerubahanModal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        setTabelUnbound()
        IsiData()
    End Sub

    Private Sub GridControl1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl1.Load
        setGrid()
    End Sub


    Sub cetakLaporan(ByVal odata As DataTable)
        Dim laporan As New LaporanPerubahanModal
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

        laporan.lbNama.DataBindings.Add("Text", Nothing, "Nama")
        laporan.lbN1.DataBindings.Add("Text", Nothing, "Nominal1", "{0:c2}")
        laporan.lbN2.DataBindings.Add("Text", Nothing, "Nominal2", "{0:c2}")

        Tool.ShowPreview()
    End Sub

    Private Sub btnCetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCetak.Click
        cetakLaporan(oDataTabelUnbound)
    End Sub
End Class