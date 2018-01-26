Imports DevExpress.XtraCharts
Imports System.Drawing

Public Class frmMain
    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        FormDataPerusahaan.ShowDialog()
    End Sub

    Private Sub PictureBox2_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseHover
        LabelControl1.ForeColor = Color.Black
    End Sub


    Private Sub PictureBox2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseLeave
        LabelControl1.ForeColor = Color.Maroon
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        FormDataAkun.ShowDialog()
    End Sub

    Private Sub PictureBox3_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseHover
        LabelControl4.ForeColor = Color.Black
    End Sub

    Private Sub PictureBox3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseLeave
        LabelControl4.ForeColor = Color.Maroon
    End Sub

    Private Sub LabelControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelControl1.Click

    End Sub

    Private Sub LabelControl1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles LabelControl1.MouseHover
        LabelControl1.ForeColor = Color.Black
    End Sub


    Private Sub LabelControl1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles LabelControl1.MouseLeave
        LabelControl1.ForeColor = Color.Maroon
    End Sub

    Private Sub LabelControl4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelControl4.Click
        FormDataAkun.ShowDialog()
    End Sub

    Private Sub LabelControl4_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles LabelControl4.MouseHover
        LabelControl4.ForeColor = Color.Black
    End Sub

    Private Sub LabelControl4_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles LabelControl4.MouseLeave
        LabelControl4.ForeColor = Color.Maroon
    End Sub

    Private Sub PictureBox12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PictureBox25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox25.Click
        FormAddRekonsiliasiBank.ShowDialog()
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        FormDataSubklasifikasi.ShowDialog()
    End Sub

    Private Sub LabelControl10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelControl10.Click
        FormDataPelanggan.ShowDialog()
    End Sub

    Private Sub LabelControl14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FormDataBarang.ShowDialog()
    End Sub

    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FormDataBarang.ShowDialog()
    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        FormDataSuplier.ShowDialog()
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FormTransaksi.ShowDialog()
    End Sub

    Private Sub LabelControl6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FormTransaksi.ShowDialog()
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FormDaftarUmurPiutang.ShowDialog()

    End Sub

    Private Sub LabelControl8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FormDaftarUmurPiutang.ShowDialog()

    End Sub

    Private Sub PictureBox13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FormDaftarPiutangDagang.ShowDialog()
    End Sub

    Private Sub LabelControl24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FormDaftarPiutangDagang.ShowDialog()
    End Sub

    Private Sub LabelControl55_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelControl55.Click
        FormKasMasuk.isKeluar = False

        FormKasMasuk.ShowDialog()
    End Sub

    Private Sub PictureBox27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox27.Click
        FormKasMasuk.isKeluar = False

        FormKasMasuk.ShowDialog()
    End Sub

    Private Sub LabelControl53_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelControl53.Click
        FormKasMasuk.isKeluar = True

        FormKasMasuk.ShowDialog()
    End Sub

    Private Sub PictureBox26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox26.Click
        FormKasMasuk.isKeluar = True

        FormKasMasuk.ShowDialog()
    End Sub

    Private Sub LabelControl65_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelControl65.Click
        FormJurnal.ShowDialog()
    End Sub

    Private Sub PictureBox32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox32.Click
        FormJurnal.ShowDialog()
    End Sub

    Private Sub LabelControl67_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelControl67.Click
        FormBukuBesar.ShowDialog()
    End Sub

    Private Sub PictureBox33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox33.Click
        FormBukuBesar.ShowDialog()
    End Sub

    Private Sub PictureBox34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox34.Click
        Form1.ShowDialog()
    End Sub

    Private Sub LabelControl68_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelControl68.Click
        Form1.ShowDialog()
    End Sub

    Private Sub LabelControl33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub LabelControl71_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelControl71.Click
        FormLabaRugi.ShowDialog()

    End Sub

    Private Sub XtraTabPage6_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles XtraTabPage6.Paint

    End Sub

    Private Sub PictureBox35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox35.Click
        FormLabaRugi.ShowDialog()

    End Sub

    Private Sub PictureBox36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox36.Click
        FormJurnalPenyesuaian.ShowDialog()
    End Sub

    Private Sub LabelControl72_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelControl72.Click
        FormJurnalPenyesuaian.ShowDialog()
    End Sub

    Private Sub PictureBox38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox38.Click

    End Sub

    Private Sub LabelControl77_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelControl77.Click
        FormDaftarJenisBarang.ShowDialog()
    End Sub

    Private Sub PictureBox11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox11.Click
        FormOperator.ShowDialog()
    End Sub

    Private Sub PictureBox39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox39.Click
        FormDataPemesananBarang.ShowDialog()
    End Sub

    Private Sub PictureBox21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox21.Click
        FormDaftarPemesananBarang.ShowDialog()
    End Sub

    Private Sub PictureBox40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox40.Click
        FormDataPemerimaanBarang.ShowDialog()
    End Sub

    Private Sub PictureBox41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FormDaftarPenerimaanBarang.ShowDialog()
    End Sub

    Private Sub PictureBox42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FormMutasi.ShowDialog()
    End Sub

    Private Sub PictureBox30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox30.Click
        FormStokOpname.ShowDialog()
    End Sub

    Private Sub PictureBox14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox14.Click
        FormDaftarHutangDagang.ShowDialog()
    End Sub

    Private Sub LabelControl45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelControl45.Click
        FormDataBarang.ShowDialog()
    End Sub

    Private Sub LabelControl83_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelControl83.Click

    End Sub

    Private Sub PictureBox41_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox41.Click
        FormDataPemerimaanBarang.ShowDialog()
    End Sub

    Private Sub PictureBox10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox10.Click
        FormDataDepartemen.ShowDialog()
    End Sub

    Private Sub PictureBox42_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox42.Click
        FormMutasi.ShowDialog()
    End Sub

    Sub DatacharPembelian(ByVal odataPembelian As DataTable)
        Dim series1 As New Series("Kas Masuk", ViewType.Line)
        Dim series2 As New Series("Kas Keluar", ViewType.Line)
        Dim chartTitle1 As New ChartTitle()
        Dim diagram As XYDiagram = CType(ChartKas.Diagram, XYDiagram)

        ChartKas.Titles.Clear()
        ChartKas.Series.Clear()

        For i = 0 To odataPembelian.Rows.Count - 1
            series1.Points.Add(New SeriesPoint(odataPembelian.Rows(i).Item(0), odataPembelian.Rows(i).Item(1)))
        Next

        For j = 0 To odataPembelian.Rows.Count - 1
            series2.Points.Add(New SeriesPoint(odataPembelian.Rows(j).Item(0), odataPembelian.Rows(j).Item(2)))
        Next

        'series1.PointOptions.ValueNumericOptions.Format = NumericFormat.Number
        ' CType(series1.Label.PointOptions, PiePointOptions).PercentOptions.ValueAsPercent = False
        series1.PointOptions.ValueNumericOptions.Format = NumericFormat.Currency
        series1.Label.PointOptions.PointView = PointView.ArgumentAndValues
        series1.Label.PointOptions.ValueNumericOptions.Precision = 0
        series1.CrosshairLabelPattern = "{V:C}"

        series2.PointOptions.ValueNumericOptions.Format = NumericFormat.Currency
        series2.Label.PointOptions.PointView = PointView.ArgumentAndValues
        series2.Label.PointOptions.ValueNumericOptions.Precision = 0
        series2.CrosshairLabelPattern = "{V:C}"

        ChartKas.Legend.Visible = True


        ChartKas.Legend.Visible = True
        ChartKas.Series.Add(series1)
        ChartKas.Series.Add(series2)
        '  ChartControl1.Width = FormUtama.Width / 2 - 40
    End Sub

    Dim datachart As New ClassChart

    Sub loadChartKAS()
        Dim oDatapembelian As New DataTable
        oDatapembelian = datachart.selectKasMasuk
        DatacharPembelian(oDatapembelian)
    End Sub

    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        loadChartKAS()
        loadChartKasMK()
        loadChartPB()
        PanelControl1.Visible = False
    End Sub

    Private Sub PictureBox37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox37.Click
        FormNeracaLajurPeriode.ShowDialog()
    End Sub

    Private Sub PictureBox4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        FormNeraca.ShowDialog()
    End Sub

    Private Sub PictureBox5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        FormDetilJurnaleriode.ShowDialog()
    End Sub

    Private Sub PictureBox8_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click
        FormJurnalUmum.ShowDialog()
    End Sub

    Private Sub XtraTabPage4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles XtraTabPage4.Click
        PanelControl1.Visible = True

    End Sub

    Private Sub XtraTabPage1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles XtraTabPage1.Click
        PanelControl1.Visible = False
    End Sub

    Sub DatachartkasMK(ByVal OdataKasMK As DataTable)
        Dim series1 As New Series("Kas", ViewType.Pie)
        Dim chartTitle1 As New ChartTitle()
        Dim diagram As XYDiagram = CType(ChartKasMK.Diagram, XYDiagram)

        ChartKasMK.Titles.Clear()
        ChartKasMK.Series.Clear()
        Try
            For i = 0 To OdataKasMK.Rows.Count - 1
                series1.Points.Add(New SeriesPoint("Kas Masuk", OdataKasMK.Rows(i).Item(0)))
            Next
            For x = 0 To OdataKasMK.Rows.Count - 1
                series1.Points.Add(New SeriesPoint("Kas Keluar", OdataKasMK.Rows(x).Item(1)))
            Next
        Catch ex As Exception

        End Try
        
        'series1.PointOptions.ValueNumericOptions.Format = NumericFormat.Number
        CType(series1.Label.PointOptions, PiePointOptions).PercentOptions.ValueAsPercent = False
        series1.PointOptions.ValueNumericOptions.Format = NumericFormat.Currency
        series1.Label.PointOptions.PointView = PointView.ArgumentAndValues
        series1.Label.PointOptions.ValueNumericOptions.Precision = 0
        series1.CrosshairLabelPattern = "{V:C}"
        ChartKasMK.Legend.Visible = True

        ChartKasMK.Legend.Visible = False
        '  ChartControl1.Titles.Add(chartTitle1)
        ChartKasMK.Series.Add(series1)
        '  ChartControl1.Width = FormUtama.Width / 2 - 40
    End Sub
    Sub loadChartKasMK()
        Dim OdataKasMK As New DataTable
        OdataKasMK = datachart.selectKasForPie
        DatachartkasMK(OdataKasMK)
    End Sub

    Sub DatachartPB(ByVal pendapatan As Long, ByVal beban As Long)
        Dim series1 As New Series("Kas", ViewType.Pie)
        Dim chartTitle1 As New ChartTitle()
        Dim diagram As XYDiagram = CType(ChartPB.Diagram, XYDiagram)

        ChartPB.Titles.Clear()
        ChartPB.Series.Clear()

        series1.Points.Add(New SeriesPoint("Pendapatan", pendapatan.ToString))


        series1.Points.Add(New SeriesPoint("Biaya", beban.ToString))

        'series1.PointOptions.ValueNumericOptions.Format = NumericFormat.Number
        CType(series1.Label.PointOptions, PiePointOptions).PercentOptions.ValueAsPercent = False
        series1.PointOptions.ValueNumericOptions.Format = NumericFormat.Currency
        series1.Label.PointOptions.PointView = PointView.ArgumentAndValues
        series1.Label.PointOptions.ValueNumericOptions.Precision = 0
        series1.CrosshairLabelPattern = "{V:C}"
        ChartPB.Legend.Visible = True

        ChartPB.Legend.Visible = False
        '  ChartControl1.Titles.Add(chartTitle1)
        ChartPB.Series.Add(series1)
        '  ChartControl1.Width = FormUtama.Width / 2 - 40
    End Sub
    Sub loadChartPB()
        Dim oDataTransaksi As New DataTable
        oDataTransaksi = datachart.SelectPendapatan

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

        DatachartPB(totalPendapatan, totalBiaya)
    End Sub

    Private Sub PictureBox22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox22.Click
        FormIncomeAudit.ShowDialog()
    End Sub

    Private Sub PictureBox15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox15.Click
        FormDaftarUmurPiutang.ShowDialog()
    End Sub

    Private Sub PictureBox16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox16.Click
        FormDaftarUmurHutang.ShowDialog()
    End Sub

    Private Sub PictureBox13_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox13.Click
        FormDaftarPiutangDagang.ShowDialog()
    End Sub

    Private Sub LabelControl30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelControl30.Click

    End Sub

    Private Sub LabelControl28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelControl28.Click

    End Sub

    Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.Click
        FormDataBankdanRekening.ShowDialog()
    End Sub

    Private Sub PictureBox12_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox12.Click
        FormPerubahanModal.ShowDialog()
    End Sub
End Class