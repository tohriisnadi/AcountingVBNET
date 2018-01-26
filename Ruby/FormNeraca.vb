Imports System.Data.Odbc
Imports DevExpress.XtraReports.UI

Public Class FormNeraca
    Dim DataAKun As New ClassAkun
    Dim DataJurnal As New ClassJurnal
    Dim oDataTabelUnbound As New DataTable
    Dim oDataTransaksi As New DataTable
    Dim oDataAkun As New DataTable
    Dim oRow As DataRow

    Sub setTabelUnbound()
        Try
            oDataTabelUnbound.Rows.Clear()
            oDataTabelUnbound.Columns.Clear()
            oDataTabelUnbound.Clear()
            oDataTabelUnbound.Columns.Add(New DataColumn("NoAkun", GetType(String))) '0
            oDataTabelUnbound.Columns.Add(New DataColumn("Akun", GetType(String))) '1
            oDataTabelUnbound.Columns.Add(New DataColumn("Nominal1", GetType(String))) '2
            oDataTabelUnbound.Columns.Add(New DataColumn("Nominal2", GetType(String))) '3
            oDataTabelUnbound.Columns.Add(New DataColumn("Nominal3", GetType(String))) '4
            BindingSource1.DataSource = oDataTabelUnbound
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub addRow(ByVal noakun As String, ByVal akun As String, ByVal nominal1 As String, ByVal nominal2 As String, ByVal nominal3 As String)
        oRow = oDataTabelUnbound.NewRow
        oRow(0) = noakun
        oRow(1) = akun
        oRow(2) = nominal1
        oRow(3) = nominal2
        oRow(4) = nominal3
        oDataTabelUnbound.Rows.Add(oRow)
    End Sub
    Sub SetDataRowUnBound()
        oDataTransaksi.Clear()
        oDataAkun.Clear()
        oDataAkun = DataAKun.selectAKunNeraca
        oDataTransaksi = DataJurnal.selectTransaksiNeraca

        Dim index As Integer
        Dim Total As Long


        For i = 0 To oDataAkun.Rows.Count - 1
            index = getIndexAkun(oDataAkun.Rows(i).Item(4))

            If index = -1 Then
                If oDataAkun.Rows(i).Item(4) = "2" And getIndexAkun("S1") = -1 Then
                    Total = 0
                    For x = 0 To oDataTransaksi.Rows.Count - 1
                        If Microsoft.VisualBasic.Left(oDataTransaksi.Rows(x).Item(0), 1) = 1 Then
                            Total += oDataTransaksi.Rows(x).Item(1)
                        End If
                    Next
                    addRow("S1", "Total Harta", "", Format(Total, "###,###,##0"), "")
                    addRow("", "", "", "", "")
                    addRow(oDataAkun.Rows(i).Item(4), oDataAkun.Rows(i).Item(5), "", "", "")
                    addRow(oDataAkun.Rows(i).Item(2), "       " & oDataAkun.Rows(i).Item(3), "", "", "")
                    Total = 0
                    For x = 0 To oDataTransaksi.Rows.Count - 1
                        If oDataTransaksi.Rows(x).Item(0) = oDataAkun.Rows(i).Item(0) Then
                            Total += oDataTransaksi.Rows(x).Item(1)
                        End If
                    Next
                    addRow(oDataAkun.Rows(i).Item(0), "              " & oDataAkun.Rows(i).Item(1), Format(Total, "###,###,##0"), "", "")
                ElseIf oDataAkun.Rows(i).Item(4) = "3" And getIndexAkun("S2") = -1 Then
                    Total = 0
                    For x = 0 To oDataTransaksi.Rows.Count - 1
                        If Microsoft.VisualBasic.Left(oDataTransaksi.Rows(x).Item(0), 1) = 2 Then
                            Total += oDataTransaksi.Rows(x).Item(1)
                        End If
                    Next
                    addRow("S2", "Total Kewajiban", "", Format(Total, "###,###,##0"), "")
                    addRow("", "", "", "", "")
                    
                    addRow(oDataAkun.Rows(i).Item(4), oDataAkun.Rows(i).Item(5), "", "", "")
                    addRow(oDataAkun.Rows(i).Item(2), "       " & oDataAkun.Rows(i).Item(3), "", "", "")
                    Total = 0
                    For x = 0 To oDataTransaksi.Rows.Count - 1
                        If oDataTransaksi.Rows(x).Item(0) = oDataAkun.Rows(i).Item(0) Then
                            Total += oDataTransaksi.Rows(x).Item(1)
                        End If
                    Next
                    addRow(oDataAkun.Rows(i).Item(0), "              " & oDataAkun.Rows(i).Item(1), Format(Total, "###,###,##0"), "", "")
                Else
                    addRow(oDataAkun.Rows(i).Item(4), oDataAkun.Rows(i).Item(5), "", "", "")
                    addRow(oDataAkun.Rows(i).Item(2), "       " & oDataAkun.Rows(i).Item(3), "", "", "")
                    Total = 0
                    For x = 0 To oDataTransaksi.Rows.Count - 1
                        If oDataTransaksi.Rows(x).Item(0) = oDataAkun.Rows(i).Item(0) Then
                            Total += oDataTransaksi.Rows(x).Item(1)
                        End If
                    Next
                    addRow(oDataAkun.Rows(i).Item(0), "              " & oDataAkun.Rows(i).Item(1), Format(Total, "###,###,##0"), "", "")

                End If
            Else
                index = getIndexAkun(oDataAkun.Rows(i).Item(2))
                If index = -1 Then
                    addRow(oDataAkun.Rows(i).Item(2), "       " & oDataAkun.Rows(i).Item(3), "", "", "")
                Else
                    index = getIndexAkun(oDataAkun.Rows(i).Item(0))
                    If index = -1 Then
                        Total = 0
                        For x = 0 To oDataTransaksi.Rows.Count - 1
                            If oDataTransaksi.Rows(x).Item(0) = oDataAkun.Rows(i).Item(0) Then
                                Total += oDataTransaksi.Rows(x).Item(1)
                            End If
                        Next
                        addRow(oDataAkun.Rows(i).Item(0), "              " & oDataAkun.Rows(i).Item(1), Format(Total, "###,###,##0"), "", "")
                    End If
                End If
            End If
        Next

    End Sub

    Private Function AkunAda(ByVal key As String)
        Dim ketemu As Boolean = False
        Dim index As String = -1
        Dim i As Integer

        For i = 0 To oDataAkun.Rows.Count - 1
            If ketemu = False And oDataAkun.Rows(i).Item(4) = key Then
                ketemu = True
                index = i
                Exit For
            End If
        Next

        Return index
    End Function

    Private Function getIndexAkun(ByVal key As String)
        Dim ketemu As Boolean = False
        Dim index As String = -1
        Dim i As Integer

        For i = 0 To oDataTabelUnbound.Rows.Count - 1
            If ketemu = False And oDataTabelUnbound.Rows(i).Item(0) = key Then
                ketemu = True
                index = i
                Exit For
            End If
        Next

        Return index
    End Function

    Sub setGrid()
        Try
            GridView1.OptionsBehavior.Editable = False
            GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
            GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus

            For i = 0 To GridView1.Columns.Count - 1
                ' GridView1.Columns(i).OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
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
            GridView1.Columns(4).Visible = False

        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub FormNeraca_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Show()
        setTabelUnbound()
        SetDataRowUnBound()
        setGrid()
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
            cetakLaporan()
        ElseIf selection = "2" Then
            SetDataRowUnBound()
        End If
    End Sub

    Sub cetakLaporan()

        Dim lap As New LaporanLabaRugi
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

        lap.heder.Text = "Laporan Neraca"

        lap.lblAkun.DataBindings.Add("Text", Nothing, "Akun")
        lap.lblDebet.DataBindings.Add("Text", Nothing, "Nominal1")
        lap.lblKredit.DataBindings.Add("Text", Nothing, "Nominal2")

        Tool.ShowPreview()

    End Sub
End Class