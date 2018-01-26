Public Class FormDaftarUmurPiutang
    Dim oDataTabelUnbound As New DataTable
    Dim odataPiutang As New DataTable
    Dim dataPiutang As New ClassPiutang
    Dim oRow As DataRow

    Sub setTabelUnbound()
        'Try
        oDataTabelUnbound.Rows.Clear()
        oDataTabelUnbound.Columns.Clear()
        oDataTabelUnbound.Clear()

        oDataTabelUnbound.Columns.Add(New DataColumn("Pelanggan", GetType(String))) '0
        oDataTabelUnbound.Columns.Add(New DataColumn("30", GetType(String))) '1
        oDataTabelUnbound.Columns.Add(New DataColumn("60", GetType(String))) '2
        oDataTabelUnbound.Columns.Add(New DataColumn(">90", GetType(String))) '3
        oDataTabelUnbound.Columns.Add(New DataColumn("KodePelanggan", GetType(String))) '4
        BindingSource1.DataSource = oDataTabelUnbound
        'Catch ex As Exception
        'MsgBox(ex.Message)
        'End Try
    End Sub
    Sub setData()
    End Sub

    Sub IsiData()
        odataPiutang.Clear()
        odataPiutang = dataPiutang.selectSisaPiutang()
        oDataTabelUnbound.Clear()
        For i = 0 To odataPiutang.Rows.Count() - 1
            oRow = oDataTabelUnbound.NewRow
            oRow(0) = odataPiutang.Rows(i).Item(1)
            oRow(4) = odataPiutang.Rows(i).Item(0)
            If CInt(odataPiutang.Rows(i).Item(3)) <= 30 Then
                oRow(1) = odataPiutang.Rows(i).Item(3)
                oRow(2) = 0
                oRow(3) = 0
            ElseIf CInt(odataPiutang.Rows(i).Item(3)) > 30 And CInt(odataPiutang.Rows(i).Item(3)) <= 60 Then
                oRow(1) = 0
                oRow(2) = odataPiutang.Rows(i).Item(3)
                oRow(3) = 0
            Else
                oRow(1) = 0
                oRow(2) = 0
                oRow(3) = odataPiutang.Rows(i).Item(3)
            End If

            oDataTabelUnbound.Rows.Add(oRow)
            GridControl1.Refresh()
        Next
    End Sub

    Private Sub FormDaftarUmurPiutang_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        setTabelUnbound()
        setData()
        IsiData()
    End Sub
End Class