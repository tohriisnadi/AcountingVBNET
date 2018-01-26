Public Class FormDaftarUmurHutang
    Dim oDataTabelUnbound As New DataTable
    Dim odataHutang As New DataTable
    Dim dataHutang As New ClassHutang
    Dim oRow As DataRow

    Sub setTabelUnbound()
        Try
            oDataTabelUnbound.Rows.Clear()
            oDataTabelUnbound.Columns.Clear()
            oDataTabelUnbound.Clear()

            oDataTabelUnbound.Columns.Add(New DataColumn("Pelanggan", GetType(String))) '0
            oDataTabelUnbound.Columns.Add(New DataColumn("30", GetType(String))) '1
            oDataTabelUnbound.Columns.Add(New DataColumn("60", GetType(String))) '2
            oDataTabelUnbound.Columns.Add(New DataColumn(">90", GetType(String))) '3
            oDataTabelUnbound.Columns.Add(New DataColumn("KodePelanggan", GetType(String))) '4
            BindingSource1.DataSource = oDataTabelUnbound
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub setGrid()
        Try
            GridView1.OptionsBehavior.Editable = False
            GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
            GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus

            For i = 0 To GridView1.Columns.Count - 1
                GridView1.Columns(i).OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            Next

            GridView1.Columns(4).Visible = False

            For i = 0 To GridView1.Columns.Count - 1
                GridView1.Columns(i).BestFit()
            Next

        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try
    End Sub
    Private Function BarangAda(ByVal key As String)
        Dim ketemu As Boolean = False
        Dim index As String = -1
        Dim i As Integer

        For i = 0 To oDataTabelUnbound.Rows.Count - 1
            If ketemu = False And oDataTabelUnbound.Rows(i).Item(4) = key Then
                ketemu = True
                index = i
                Exit For
            End If
        Next

        Return index
    End Function
    Private Sub UpdateRow(ByVal KodePelanggan As String, ByVal index As String, ByVal SisaWaktu As Long)
        Dim jumlahWaktu As Long

        jumlahWaktu = CLng(oDataTabelUnbound.Rows(index).Item(3) + SisaWaktu)

        If jumlahWaktu <= 30 Then
            oRow(1) = jumlahWaktu
            oRow(2) = 0
            oRow(3) = 0
        ElseIf jumlahWaktu > 30 And jumlahWaktu <= 60 Then
            oRow(1) = 0
            oRow(2) = jumlahWaktu
            oRow(3) = 0
        Else
            oRow(1) = 0
            oRow(2) = 0
            oRow(3) = jumlahWaktu
        End If
        GridControl1.Refresh()

    End Sub
    Sub IsiData()
        Dim indexBarang As Integer

        odataHutang.Clear()
        odataHutang = dataHutang.selectSisaHutang()
        oDataTabelUnbound.Clear()

        For i = 0 To odataHutang.Rows.Count() - 1
            indexBarang = BarangAda(odataHutang.Rows(i).Item(0))
            If indexBarang = -1 Then

                oRow = oDataTabelUnbound.NewRow
                oRow(0) = odataHutang.Rows(i).Item(1)
                oRow(4) = odataHutang.Rows(i).Item(0)
                If CInt(odataHutang.Rows(i).Item(3)) <= 30 Then
                    oRow(1) = odataHutang.Rows(i).Item(3)
                    oRow(2) = 0
                    oRow(3) = 0
                ElseIf CInt(odataHutang.Rows(i).Item(3)) > 30 And CInt(odataHutang.Rows(i).Item(3)) <= 60 Then
                    oRow(1) = 0
                    oRow(2) = odataHutang.Rows(i).Item(3)
                    oRow(3) = 0
                Else
                    oRow(1) = 0
                    oRow(2) = 0
                    oRow(3) = odataHutang.Rows(i).Item(3)
                End If

                oDataTabelUnbound.Rows.Add(oRow)
                GridControl1.Refresh()
            Else
                UpdateRow(odataHutang.Rows(i).Item(0), indexBarang, odataHutang.Rows(i).Item(2))
            End If

        Next

    End Sub

    Private Sub GridControl1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl1.Load
        setGrid()
    End Sub

    Private Sub FormDaftarUmurHutang_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        setTabelUnbound()
        IsiData()
    End Sub
End Class