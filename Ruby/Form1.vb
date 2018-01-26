Imports System.Data.Odbc
Imports DevExpress.XtraReports.UI
Public Class Form1
    Dim DataAKun As New ClassAkun
    Dim DataJurnal As New ClassJurnal
    Dim oDataTabelUnbound As New DataTable
    Dim oDataMutasiHariIni As New DataTable
    Dim oDataAkun As New DataTable
    Dim oRow As DataRow
    Public Sub newRow()

        Dim indexAkun As Integer
        Dim i As Integer
        Dim NoAkun As String
        Dim AKun As String
        Dim SaldoAwalD As Long
        Dim SaldoAwalK As Long
        Dim MutasiHariIniD As Long
        Dim MutasiHariIniK As Long
        Dim SaldoAkhirD As Long
        Dim SaldoAkhirK As Long
        Dim selisihSaldoAkhirDanMutasi As Long
        Dim SaldoMutasi As Long
        oDataAkun.Clear()
        oDataAkun = DataAKun.selectSaldo
        oDataMutasiHariIni = DataJurnal.selectMutasiHariIni

        For i = 0 To oDataAkun.Rows.Count - 1
            NoAkun = oDataAkun.Rows(i).Item(0)
            AKun = oDataAkun.Rows(i).Item(2)

            If oDataAkun.Rows(i).Item(4) > 0 Then
                SaldoAkhirD = oDataAkun.Rows(i).Item(1)
                SaldoAkhirK = 0
            ElseIf oDataAkun.Rows(i).Item(4) < 0 Then
                SaldoAkhirD = 0
                SaldoAkhirK = Math.Abs(oDataAkun.Rows(i).Item(1))
            Else
                SaldoAkhirD = 0
                SaldoAkhirK = 0
            End If

            indexAkun = getIndexAkun(oDataAkun.Rows(i).Item(0))
            If indexAkun = -1 Then
                SaldoMutasi = 0
            Else
                SaldoMutasi = CLng(oDataMutasiHariIni.Rows(indexAkun).Item(1))
            End If
            If SaldoMutasi > 0 Then
                MutasiHariIniD = SaldoMutasi
                MutasiHariIniK = 0
            ElseIf SaldoMutasi < 0 Then
                MutasiHariIniD = 0
                MutasiHariIniK = Math.Abs(oDataMutasiHariIni.Rows(indexAkun).Item(1))
            Else
                MutasiHariIniD = 0
                MutasiHariIniK = 0
            End If

            selisihSaldoAkhirDanMutasi = CLng(oDataAkun.Rows(i).Item(4)) - SaldoMutasi
            If selisihSaldoAkhirDanMutasi > 0 Then
                SaldoAwalD = selisihSaldoAkhirDanMutasi
                SaldoAwalK = 0
            ElseIf selisihSaldoAkhirDanMutasi < 0 Then
                SaldoAwalD = 0
                SaldoAwalK = Math.Abs(selisihSaldoAkhirDanMutasi)
            Else
                SaldoAwalD = 0
                SaldoAwalK = 0
            End If

            oRow = oDataTabelUnbound.NewRow
            oRow(0) = NoAkun
            oRow(1) = AKun
            oRow(2) = Format(CLng(SaldoAwalD), "###,###,##0")
            oRow(3) = Format(CLng(SaldoAwalK), "###,###,##0")
            oRow(4) = Format(CLng(MutasiHariIniD), "###,###,##0")
            oRow(5) = Format(CLng(MutasiHariIniK), "###,###,##0")
            oRow(6) = Format(CLng(SaldoAkhirD), "###,###,##0")
            oRow(7) = Format(CLng(SaldoAkhirK), "###,###,##0")
            oDataTabelUnbound.Rows.Add(oRow)
        Next

    End Sub
    Private Function getIndexAkun(ByVal key As String)
        Dim ketemu As Boolean = False
        Dim index As String = -1
        Dim i As Integer

        For i = 0 To oDataMutasiHariIni.Rows.Count - 1
            If ketemu = False And oDataMutasiHariIni.Rows(i).Item(0) = key Then
                ketemu = True
                index = i
                Exit For
            End If
        Next

        Return index
    End Function
    Sub LoadData()
        setTabelUnbound()
        oDataTabelUnbound.Clear()
        oRow = oDataTabelUnbound.NewRow
        oRow(0) = "No Akun"
        oRow(1) = "Akun"
        oRow(2) = "Saldo Awal"
        oRow(3) = "Saldo Awal"
        oRow(4) = "Mutasi Hari Ini"
        oRow(5) = "Mutasi Hari Ini"
        oRow(6) = "Saldo Akhir"
        oRow(7) = "Saldo Akhir"

        oDataTabelUnbound.Rows.Add(oRow)

        oRow = oDataTabelUnbound.NewRow
        oRow(0) = "No Akun"
        oRow(1) = "Akun"
        oRow(2) = "Debet"
        oRow(3) = "Kredit"
        oRow(4) = "Debet"
        oRow(5) = "Kredit"
        oRow(6) = "Debet"
        oRow(7) = "Kredit"
        oDataTabelUnbound.Rows.Add(oRow)
        newRow()
        addRowTotal()

    End Sub
    Sub setTabelUnbound()
        Try
            oDataTabelUnbound.Rows.Clear()
            oDataTabelUnbound.Columns.Clear()
            oDataTabelUnbound.Clear()
            oDataTabelUnbound.Columns.Add(New DataColumn("NoAkun", GetType(String))) '0
            oDataTabelUnbound.Columns.Add(New DataColumn("Akun", GetType(String))) '1
            oDataTabelUnbound.Columns.Add(New DataColumn("SaldoAwalD", GetType(String))) '2
            oDataTabelUnbound.Columns.Add(New DataColumn("SaldoAwalK", GetType(String))) '3
            oDataTabelUnbound.Columns.Add(New DataColumn("MutasiHariIniD", GetType(String))) '4
            oDataTabelUnbound.Columns.Add(New DataColumn("MutasiHariIniK", GetType(String))) '5
            oDataTabelUnbound.Columns.Add(New DataColumn("SaldoAkhirD", GetType(String))) '6
            oDataTabelUnbound.Columns.Add(New DataColumn("SaldoAkhirK", GetType(String))) '7
            BindingSource1.DataSource = oDataTabelUnbound
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Show()
        LoadData()
        _Helper = New MyCellMergeHelper(GridView1)
        _Helper.AddMergedCell(0, 2, 3, "Saldo Awal")
        _Helper.AddMergedCell(0, 4, 5, "Mutasi Hari Ini")
        _Helper.AddMergedCell(0, 6, 7, "Saldo Akhir")
        _Helper.AddMergedCell(oDataTabelUnbound.Rows.Count - 1, 0, 1, "Total")

    End Sub
    Private _Helper As MyCellMergeHelper

    Private Sub GridView1_CellMerge(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.CellMergeEventArgs) Handles GridView1.CellMerge
        Dim RowNoAkun1 As Integer
        Dim RowNOAkun2 As Integer
        Dim RowAkun1 As Integer
        Dim RowAkun2 As Integer


        RowNoAkun1 = GridView1.GetDataSourceRowIndex(e.RowHandle1)
        RowNOAkun2 = GridView1.GetDataSourceRowIndex(e.RowHandle2)

        If (e.Column.FieldName = "NoAkun") Then
            If oDataTabelUnbound.Rows(RowNoAkun1).Item(0) = oDataTabelUnbound.Rows(RowNOAkun2).Item(0) Then
                e.Merge = True
            Else
                e.Merge = False
            End If
        End If

        If (e.Column.FieldName = "Akun") Then
            If oDataTabelUnbound.Rows(RowNoAkun1).Item(1) = oDataTabelUnbound.Rows(RowNOAkun2).Item(1) Then
                e.Merge = True
            Else
                e.Merge = False
            End If
        End If

        e.Handled = True
    End Sub
    Sub addRowTotal()
        Dim totalSaldoAwalD As Long
        Dim totalSaldoAwalK As Long
        Dim totalMutasiD As Long
        Dim totalMutasiK As Long
        Dim totalSaldoAkhirD As Long
        Dim totalSaldoAKhirK As Long
        Dim i As Integer
        totalSaldoAwalD = 0
        totalSaldoAwalK = 0
        totalMutasiD = 0
        totalMutasiK = 0
        totalSaldoAkhirD = 0
        totalSaldoAKhirK = 0

        For i = 2 To oDataTabelUnbound.Rows.Count - 1
            totalSaldoAwalD += oDataTabelUnbound.Rows(i).Item(2)
            totalSaldoAwalK += oDataTabelUnbound.Rows(i).Item(3)
            totalMutasiD += oDataTabelUnbound.Rows(i).Item(4)
            totalMutasiK += oDataTabelUnbound.Rows(i).Item(5)
            totalSaldoAkhirD += oDataTabelUnbound.Rows(i).Item(6)
            totalSaldoAKhirK += oDataTabelUnbound.Rows(i).Item(7)

        Next
        oRow = oDataTabelUnbound.NewRow
        oRow(0) = "Total"
        oRow(1) = ""
        oRow(2) = Format(totalSaldoAwalD, "###,###,##0")
        oRow(3) = Format(totalSaldoAwalK, "###,###,##0")
        oRow(4) = Format(totalMutasiD, "###,###,##0")
        oRow(5) = Format(totalMutasiK, "###,###,##0")
        oRow(6) = Format(totalSaldoAkhirD, "###,###,##0")
        oRow(7) = Format(totalSaldoAKhirK, "###,###,##0")
        oDataTabelUnbound.Rows.Add(oRow)

        Dim a As New DataTable

        a = oDataTabelUnbound
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GridView1_RowCellDefaultAlignment(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowCellAlignmentEventArgs) Handles GridView1.RowCellDefaultAlignment
        'If e.Column.FieldName = "Category" Then
        'If e.RowHandle = 4 Or e.RowHandle = 5 Then
        'e.HorzAlignment = DevExpress.Utils.HorzAlignment.Far
        'End If
        'End If

        If e.RowHandle = 0 Or e.RowHandle = 1 Then
            e.HorzAlignment = DevExpress.Utils.HorzAlignment.Center

        End If

        If Not e.Column.FieldName Is "NoAkun" And Not e.Column.FieldName Is "Akun" Then
            If e.RowHandle > 1 Then
                e.HorzAlignment = DevExpress.Utils.HorzAlignment.Far
            End If
        End If
    End Sub

    Private Sub GridControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridControl1.Click

    End Sub

    Private Sub GridControl1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl1.DoubleClick

    End Sub

    Sub ForCetak()
        oDataTabelUnbound.Clear()
        setTabelUnbound()
        newRow()
        addRowTotal()
    End Sub

    Private Sub GridControl1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GridControl1.MouseClick
        Try
            If e.Button <> Windows.Forms.MouseButtons.Right Then Return
            Dim cms = New ContextMenuStrip
            Dim item1 = cms.Items.Add("Cetak")
            Dim item2 = cms.Items.Add("Refresh")

            item1.Tag = 1
            item2.Tag = 2

            AddHandler item1.Click, AddressOf menuChoice
            AddHandler item2.Click, AddressOf menuChoice

            cms.Show(GridControl1, e.Location)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub menuChoice(ByVal sender As Object, ByVal e As EventArgs)
        Dim item = CType(sender, ToolStripMenuItem)
        Dim selection = CInt(item.Tag)
        If selection = "1" Then
            ForCetak()
            cetakLaporan()
            LoadData()
        ElseIf selection = "2" Then
            LoadData()
        End If
    End Sub

    Sub cetakLaporan()

        Dim lap As New LaporanNeracaSaldo
        Dim Tool As ReportPrintTool = New ReportPrintTool(lap)
        Dim oDataSet As New DataSet
        Dim oDataAdapter As New OdbcDataAdapter
        Dim i As Integer


        If oDataSet.Tables.Count <> 0 Then
            oDataSet.Tables.Remove("Table1")
        End If

        oDataSet.Tables.Add(oDataTabelUnbound.Copy)

        lap.DataSource = oDataSet
        lap.DataAdapter = oDataAdapter
        lap.DataMember = "Table1"

        lap.lblNoAkun.DataBindings.Add("Text", Nothing, "NoAkun")
        lap.lblAkun.DataBindings.Add("Text", Nothing, "Akun")
        lap.lblSADebet.DataBindings.Add("Text", Nothing, "SaldoAwalD")
        lap.lblSAKredit.DataBindings.Add("Text", Nothing, "SaldoAwalK")
        lap.lblMutasiDebet.DataBindings.Add("Text", Nothing, "MutasiHariIniD")
        lap.lblMutasiKredit.DataBindings.Add("Text", Nothing, "MutasiHariIniK")
        lap.lblAkhirDebet.DataBindings.Add("Text", Nothing, "SaldoAkhirD")
        lap.lblAkhirKredit.DataBindings.Add("Text", Nothing, "SaldoAkhirK")
        
        Tool.ShowPreview()

    End Sub

End Class
