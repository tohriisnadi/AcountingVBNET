Imports System.Data.Odbc
Imports DevExpress.XtraReports.UI
Public Class FormLabaRugi
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
        Dim OdataUrutanAKun As New DataTable

        Dim Urutan(10) As String
        OdataUrutanAKun.Clear()
        OdataUrutanAKun = DataAKun.LoadUrutanAkun
        Urutan = OdataUrutanAKun.Rows(0).Item(0).ToString.Split("-")

        oDataTransaksi.Clear()
        oDataAkun.Clear()
        oDataAkun = DataAKun.selectAKunLabaRugi
        oDataTransaksi = DataJurnal.selectTransaksiLabaRugi

        Dim index As Integer
        Dim Total As Long

        Dim TotalRestauranSales As Long
        Dim TotalCost As Long
        Dim Sales As Long
        Dim Gp As Long
        Dim Tg As Long

        For i As Integer = 0 To oDataAkun.Rows.Count - 1
            If oDataAkun.Rows(i).Item(4) = "4" Then
                If getIndexAkun("4") = -1 Then
                    addRow(oDataAkun.Rows(i).Item(4), oDataAkun.Rows(i).Item(5), "", "", "")
                    Total = 0
                    For x = 0 To oDataTransaksi.Rows.Count - 1
                        If oDataTransaksi.Rows(x).Item(0) = oDataAkun.Rows(i).Item(0) Then
                            Total += oDataTransaksi.Rows(x).Item(1)
                        End If
                    Next
                    addRow(oDataAkun.Rows(i).Item(0), "       " & oDataAkun.Rows(i).Item(1), Format(Total, "###,###,##0"), "", "")
                ElseIf oDataAkun.Rows(i).Item(1) = oDataAkun.Rows(i).Item(3) Then
                    index = getIndexAkun(oDataAkun.Rows(i).Item(0))
                    If index = -1 Then
                        Total = 0
                        For x = 0 To oDataTransaksi.Rows.Count - 1
                            If oDataTransaksi.Rows(x).Item(0) = oDataAkun.Rows(i).Item(0) Then
                                Total += oDataTransaksi.Rows(x).Item(1)
                            End If
                        Next
                        addRow(oDataAkun.Rows(i).Item(0), "       " & oDataAkun.Rows(i).Item(1), Format(Total, "###,###,##0"), "", "")
                    End If
                ElseIf getIndexAkun("S40") = -1 Then
                    Total = 0
                    For x = 0 To oDataTransaksi.Rows.Count - 1
                        If Microsoft.VisualBasic.Left(oDataTransaksi.Rows(x).Item(0), 1) = 4 Then
                            Total += oDataTransaksi.Rows(x).Item(1)
                        End If
                    Next
                    addRow("S40", "  ", "", Format(Total, "###,###,##0"), "")
                    addRow("", "", "", "", "")
                    addRow(oDataAkun.Rows(i).Item(2), "       " & oDataAkun.Rows(i).Item(3), "", "", "")
                    Total = 0
                    For x = 0 To oDataTransaksi.Rows.Count - 1
                        If oDataTransaksi.Rows(x).Item(0) = oDataAkun.Rows(i).Item(0) Then
                            Total += oDataTransaksi.Rows(x).Item(1)
                        End If
                    Next
                    addRow(oDataAkun.Rows(i).Item(0), "              " & oDataAkun.Rows(i).Item(1), Format(Total, "###,###,##0"), "", "")
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

        For i As Integer = 0 To oDataAkun.Rows.Count - 1
            If oDataAkun.Rows(i).Item(4) = "5" Then
                If getIndexAkun("5") = -1 And getIndexAkun("S44") = -1 Then
                    Total = 0
                    For x = 0 To oDataTransaksi.Rows.Count - 1
                        If Microsoft.VisualBasic.Left(oDataTransaksi.Rows(x).Item(0), 2) = 44 Then
                            Total += oDataTransaksi.Rows(x).Item(1)
                        End If
                    Next
                    addRow("S44", "              Total Restaurant Sales", "", Format(Total, "###,###,##0"), "")
                    'addRow(oDataAkun.Rows(i).Item(4), oDataAkun.Rows(i).Item(5), "", "", "")
                    addRow(oDataAkun.Rows(i).Item(2), "       " & oDataAkun.Rows(i).Item(3), "", "", "")
                    Total = 0
                    For x = 0 To oDataTransaksi.Rows.Count - 1
                        If oDataTransaksi.Rows(x).Item(0) = oDataAkun.Rows(i).Item(0) Then
                            Total += oDataTransaksi.Rows(x).Item(1)
                        End If
                    Next
                    addRow(oDataAkun.Rows(i).Item(0), "              " & oDataAkun.Rows(i).Item(1), Format(Total, "###,###,##0"), "", "")
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

        For i As Integer = 0 To oDataAkun.Rows.Count - 1
            If oDataAkun.Rows(i).Item(4) = "8" Then
                If getIndexAkun("S5") = -1 Then
                    Total = 0
                    For x = 0 To oDataTransaksi.Rows.Count - 1
                        If Microsoft.VisualBasic.Left(oDataTransaksi.Rows(x).Item(0), 1) = 5 Then
                            Total += oDataTransaksi.Rows(x).Item(1)
                        End If
                    Next
                    addRow("S5", "              Total Restaurant Cost", "", Format(Total, "###,###,##0"), "")
                ElseIf getIndexAkun("8") = -1 And getIndexAkun("GP") = -1 Then
                    addRow("", "", "", "", "")
                    addRow("GP", "       Gross Profit F & B", "", "", "")
                    

                    TotalRestauranSales = oDataTabelUnbound.Rows(getIndexAkun("S44")).Item(3)
                    Sales = oDataTabelUnbound.Rows(getIndexAkun("S40")).Item(3)
                    TotalCost = oDataTabelUnbound.Rows(getIndexAkun("S5")).Item(3)
                    Gp = TotalRestauranSales - TotalCost

                    addRow("GP1", "              Gross Profit FB", "", Format(Gp, "###,###,##0"), "")
                    addRow("GP2", "              Other Income", "-", "", "")
                    addRow("", "", "", "", "")

                    Tg = (TotalRestauranSales + Sales) - TotalCost


                    addRow("S4", "Total Gross Profit & Other", "", Format(Tg, "###,###,##0"), "")
                    addRow("", "", "", "", "")
                    'addRow(oDataAkun.Rows(i).Item(4), oDataAkun.Rows(i).Item(5), "", "", "")
                    addRow(oDataAkun.Rows(i).Item(2), oDataAkun.Rows(i).Item(3), "", "", "")
                    Total = 0
                    For x = 0 To oDataTransaksi.Rows.Count - 1
                        If oDataTransaksi.Rows(x).Item(0) = oDataAkun.Rows(i).Item(0) Then
                            Total += oDataTransaksi.Rows(x).Item(1)
                        End If
                    Next
                    addRow(oDataAkun.Rows(i).Item(0), "              " & oDataAkun.Rows(i).Item(1), Format(Total, "###,###,##0"), "", "")
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

        For i As Integer = 0 To oDataAkun.Rows.Count - 1
            If oDataAkun.Rows(i).Item(4) = "6" Then
                If getIndexAkun("6") = -1 Then
                    Total = 0
                    For x = 0 To oDataTransaksi.Rows.Count - 1
                        If Microsoft.VisualBasic.Left(oDataTransaksi.Rows(x).Item(0), 1) = 8 Then
                            Total += oDataTransaksi.Rows(x).Item(1)
                        End If
                    Next
                    addRow("S8", "TOTAL OTHER SALES", "", Format(Total, "###,###,##0"), "")

                    addRow("", "", "", "", "")
                    addRow(oDataAkun.Rows(i).Item(4), oDataAkun.Rows(i).Item(5), "", "", "")
                    'addRow(oDataAkun.Rows(i).Item(2), oDataAkun.Rows(i).Item(3), "", "", "")
                    Total = 0
                    For x = 0 To oDataTransaksi.Rows.Count - 1
                        If oDataTransaksi.Rows(x).Item(0) = oDataAkun.Rows(i).Item(0) Then
                            Total += oDataTransaksi.Rows(x).Item(1)
                        End If
                    Next
                    addRow(oDataAkun.Rows(i).Item(0), "              " & oDataAkun.Rows(i).Item(1), Format(Total, "###,###,##0"), "", "")
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

        For i As Integer = 0 To oDataAkun.Rows.Count - 1
            If oDataAkun.Rows(i).Item(4) = "9" Then
                If getIndexAkun("9") = -1 Then
                    Total = 0
                    For x = 0 To oDataTransaksi.Rows.Count - 1
                        If Microsoft.VisualBasic.Left(oDataTransaksi.Rows(x).Item(0), 1) = 6 Then
                            Total += oDataTransaksi.Rows(x).Item(1)
                        End If
                    Next
                    addRow("S6", "TOTAL EXPENSES", "", Format(Total, "###,###,##0"), "")
                    addRow("", "", "", "", "")
                    addRow(oDataAkun.Rows(i).Item(4), oDataAkun.Rows(i).Item(5), "", "", "")
                    'addRow(oDataAkun.Rows(i).Item(2), oDataAkun.Rows(i).Item(3), "", "", "")
                    Total = 0
                    For x = 0 To oDataTransaksi.Rows.Count - 1
                        If oDataTransaksi.Rows(x).Item(0) = oDataAkun.Rows(i).Item(0) Then
                            Total += oDataTransaksi.Rows(x).Item(1)
                        End If
                    Next
                    addRow(oDataAkun.Rows(i).Item(0), "              " & oDataAkun.Rows(i).Item(1), Format(Total, "###,###,##0"), "", "")
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

        Total = 0
        For x = 0 To oDataTransaksi.Rows.Count - 1
            If Microsoft.VisualBasic.Left(oDataTransaksi.Rows(x).Item(0), 1) = 9 Then
                Total += oDataTransaksi.Rows(x).Item(1)
            End If
        Next
        addRow("S9", " GROSS OPERATING PROFIT", "", Format(Total, "###,###,##0"), "")

        Dim Lr As Long
        Dim Tgross As Long
        Dim TotalEXPENSES As Long
        TotalEXPENSES = oDataTabelUnbound.Rows(getIndexAkun("S6")).Item(3)
        Tgross = oDataTabelUnbound.Rows(getIndexAkun("S9")).Item(3)

        Lr = Tg - TotalEXPENSES - Tgross
        addRow("", "", "", "", "")
        addRow("PL", "Laba/Rugi", "", Format(Lr, "###,###,##0"), "")

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

    Sub setDataRow()
        Dim index As Integer
        Dim indexSUm As Integer
        Dim Total As Long
        Dim TotalRestauranSales As Long
        Dim TotalCost As Long
        Dim totalBeban As Long
        Dim labarugi As Long
        Dim totalbiayalain As Long

        Dim x As Integer
        oDataTransaksi.Clear()
        oDataAkun.Clear()
        oDataAkun = DataAKun.selectAKunLabaRugi
        oDataTransaksi = DataJurnal.selectTransaksiLabaRugi

        For i = 0 To oDataAkun.Rows.Count - 1
            index = getIndexAkun(oDataAkun.Rows(i).Item(4))

            If index = -1 Then
                If oDataAkun.Rows(i).Item(4) = "4" Then
                    If getIndexAkun("4") = -1 Then
                        addRow(oDataAkun.Rows(i).Item(4), oDataAkun.Rows(i).Item(5), "", "", "")
                        'addRow(oDataAkun.Rows(i).Item(2), "       " & oDataAkun.Rows(i).Item(3), "", "", "")
                        Total = 0
                        For x = 0 To oDataTransaksi.Rows.Count - 1
                            If oDataTransaksi.Rows(x).Item(0) = oDataAkun.Rows(i).Item(0) Then
                                Total += oDataTransaksi.Rows(x).Item(1)
                            End If
                        Next
                        addRow(oDataAkun.Rows(i).Item(0), "       " & oDataAkun.Rows(i).Item(1), Format(Total, "###,###,##0"), "", "")
                    Else
                        Total = 0
                        For x = 0 To oDataTransaksi.Rows.Count - 1
                            If oDataTransaksi.Rows(x).Item(0) = oDataAkun.Rows(i).Item(0) Then
                                Total += oDataTransaksi.Rows(x).Item(1)
                            End If
                        Next
                        addRow(oDataAkun.Rows(i).Item(0), "       " & oDataAkun.Rows(i).Item(1), Format(Total, "###,###,##0"), "", "")
                    End If
                ElseIf oDataAkun.Rows(i).Item(4) = "5" And getIndexAkun("S44") = -1 Then
                    Total = 0
                    For x = 0 To oDataTransaksi.Rows.Count - 1
                        If Microsoft.VisualBasic.Left(oDataTransaksi.Rows(x).Item(0), 1) = 4 Then
                            Total += oDataTransaksi.Rows(x).Item(1)
                        End If
                    Next
                    addRow("S44", "              Total Restaurant Sales", "", Format(Total, "###,###,##0"), "")
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
                ElseIf oDataAkun.Rows(i).Item(4) = "6" And getIndexAkun("S51") = -1 Then
                    Total = 0
                    For x = 0 To oDataTransaksi.Rows.Count - 1
                        If Microsoft.VisualBasic.Left(oDataTransaksi.Rows(x).Item(0), 1) = 5 Then
                            Total += oDataTransaksi.Rows(x).Item(1)
                        End If
                    Next
                    addRow("S5", "       Total Cost", "", Format(Total, "###,###,##0"), "")
                    addRow("", "", "", "", "")
                    TotalRestauranSales = oDataTabelUnbound.Rows(getIndexAkun("S44")).Item(3)
                    TotalCost = oDataTabelUnbound.Rows(getIndexAkun("S5")).Item(3)
                    addRow("GP", "       Gross Profit F & B", "", "", "")
                    addRow("GP", "              Gross Profit FBr", "", "", Format(TotalRestauranSales - TotalCost, "###,###,##0"))
                    addRow("GP", "              Other Income", "", "", "")
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
                ElseIf oDataAkun.Rows(i).Item(4) = "8" And getIndexAkun("S6") = -1 Then
                    Total = 0
                    For x = 0 To oDataTransaksi.Rows.Count - 1
                        If Microsoft.VisualBasic.Left(oDataTransaksi.Rows(x).Item(0), 1) = 6 Then
                            Total += oDataTransaksi.Rows(x).Item(1)
                        End If
                    Next
                    addRow("S6", "Total EXPENSES", "", Format(Total, "###,###,##0"), "")
                    addRow("", "", "", "", "")
                    'totalBeban = oDataTabelUnbound.Rows(getIndexAkun("S6")).Item(3)
                    ' addRow("OP", "Laba Pengoperasian", "", "", Format(TotalPendapatan - totalBiayaAtasPendapatan - totalBeban, "###,###,##0"))
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
                    'ElseIf oDataAkun.Rows(i).Item(4) = "9" And getIndexAkun("S8") = -1 Then
                    '    Total = 0
                    '    For x = 0 To oDataTransaksi.Rows.Count - 1
                    '        If Microsoft.VisualBasic.Left(oDataTransaksi.Rows(x).Item(0), 1) = 8 Then
                    '            Total += oDataTransaksi.Rows(x).Item(1)
                    '        End If
                    '    Next
                    '    addRow("S8", "Total Pendapatan Lain", "", Format(Total, "###,###,##0"), "")
                    '    addRow("", "", "", "", "")

                    '    addRow(oDataAkun.Rows(i).Item(4), oDataAkun.Rows(i).Item(5), "", "", "")
                    '    addRow(oDataAkun.Rows(i).Item(2), "       " & oDataAkun.Rows(i).Item(3), "", "", "")
                    '    Total = 0
                    '    For x = 0 To oDataTransaksi.Rows.Count - 1
                    '        If oDataTransaksi.Rows(x).Item(0) = oDataAkun.Rows(i).Item(0) Then
                    '            Total += oDataTransaksi.Rows(x).Item(1)
                    '        End If
                    '    Next
                    '    addRow(oDataAkun.Rows(i).Item(0), "              " & oDataAkun.Rows(i).Item(1), Format(Total, "###,###,##0"), "", "")
                Else
                End If
            Else
                If oDataAkun.Rows(i).Item(1) = oDataAkun.Rows(i).Item(3) Then
                    index = getIndexAkun(oDataAkun.Rows(i).Item(0))
                    If index = -1 Then
                        Total = 0
                        For x = 0 To oDataTransaksi.Rows.Count - 1
                            If oDataTransaksi.Rows(x).Item(0) = oDataAkun.Rows(i).Item(0) Then
                                Total += oDataTransaksi.Rows(x).Item(1)
                            End If
                        Next
                        addRow(oDataAkun.Rows(i).Item(0), "       " & oDataAkun.Rows(i).Item(1), Format(Total, "###,###,##0"), "", "")
                    End If
                ElseIf oDataAkun.Rows(i).Item(4) = "4" Then
                    If getIndexAkun("S4") = -1 Then
                        Total = 0
                        For x = 0 To oDataTransaksi.Rows.Count - 1
                            If Microsoft.VisualBasic.Left(oDataTransaksi.Rows(x).Item(0), 1) = 4 Then
                                Total += oDataTransaksi.Rows(x).Item(1)
                            End If
                        Next
                        addRow("S4", " ", "", Format(Total, "###,###,##0"), "")
                        addRow("", "", "", "", "")
                        addRow(oDataAkun.Rows(i).Item(2), "       " & oDataAkun.Rows(i).Item(3), "", "", "")
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
                Else
                    index = getIndexAkun(oDataAkun.Rows(i).Item(2))
                    If index = -1 Then
                        addRow(oDataAkun.Rows(i).Item(2), "       " & oDataAkun.Rows(i).Item(3), "", "", "")
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

               
            End If
        Next
        Total = 0
        For x = 0 To oDataTransaksi.Rows.Count - 1
            If Microsoft.VisualBasic.Left(oDataTransaksi.Rows(x).Item(0), 1) = 9 Then
                Total += oDataTransaksi.Rows(x).Item(1)
            End If
        Next
        
        addRow("S9", "Total Biaya Lain", "", Format(Total, "###,###,##0"), "")
        totalBiayaLain = oDataTabelUnbound.Rows(getIndexAkun("S9")).Item(3)
        labarugi = TotalRestauranSales - TotalCost - totalBeban - totalbiayalain
        addRow("", "", "", "", "")
        addRow("PL", "Laba/Rugi", "", Format(labarugi, "###,###,##0"), "")

        '  addRow("", "", "", "", "")

        BindingSource1.DataSource = oDataTabelUnbound
    End Sub
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
    Private Sub FormLabaRugi_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Show()
        setTabelUnbound()
        SetDataRowUnBound()
        setGrid()
    End Sub
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
    Private Sub GridControl1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl1.Load
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
            setDataRow()
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

        lap.lblAkun.DataBindings.Add("Text", Nothing, "Akun")
        lap.lblDebet.DataBindings.Add("Text", Nothing, "Nominal1")
        lap.lblKredit.DataBindings.Add("Text", Nothing, "Nominal2")

        Tool.ShowPreview()

    End Sub

End Class