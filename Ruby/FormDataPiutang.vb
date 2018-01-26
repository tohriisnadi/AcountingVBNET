Public Class FormDataPiutang
    Dim dataPiutang As New ClassPiutang
    Dim odataPiutang As New DataTable

    Sub loadData()
        odataPiutang.Clear()
        odataPiutang = dataPiutang.selectDataPiutang()
        BindingSource1.DataSource = odataPiutang
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
            GridView1.Columns(1).Caption = "No Nota"
            GridView1.Columns(3).Caption = "Pelanggan"
            GridView1.Columns(4).Caption = "Tanggal Nota"
            GridView1.Columns(5).Caption = "Tanggal Jatuh Tempo"
            GridView1.Columns(6).Caption = "Total"
            GridView1.Columns(7).Caption = "DP"
            GridView1.Columns(8).Caption = "Bayar"
            GridView1.Columns(9).Caption = "Sisa"
            GridView1.Columns(2).Visible = False

            For i = 0 To GridView1.Columns.Count - 1
                GridView1.Columns(i).BestFit()
            Next

            GridView1.Columns(6).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            GridView1.Columns(6).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
            GridView1.Columns(6).DisplayFormat.FormatString = "c"
            GridView1.Columns(7).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            GridView1.Columns(7).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
            GridView1.Columns(7).DisplayFormat.FormatString = "c"
            GridView1.Columns(8).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            GridView1.Columns(8).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
            GridView1.Columns(8).DisplayFormat.FormatString = "c"
            GridView1.Columns(9).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            GridView1.Columns(9).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
            GridView1.Columns(9).DisplayFormat.FormatString = "c"
        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub FormDataPiutang_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        loadData()
        setGrid()
    End Sub

    Private Sub GridControl1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl1.Load
        setGrid()
    End Sub

    Private Sub GridControl1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GridControl1.MouseClick
        Try
            If e.Button <> Windows.Forms.MouseButtons.Right Then Return
            Dim cms = New ContextMenuStrip
            Dim item1 = cms.Items.Add("Bayar")
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
            Try
                FormAddPembayaranPiutang.NoTrx = GridView1.GetFocusedDataRow().Item(0)
                FormAddPembayaranPiutang.txtNoNota.Text = GridView1.GetFocusedDataRow().Item(1)
                FormAddPembayaranPiutang.txtTglNota.Text = GridView1.GetFocusedDataRow().Item(4)
                FormAddPembayaranPiutang.txtTglJatuhTempo.Text = GridView1.GetFocusedDataRow().Item(5)
                FormAddPembayaranPiutang.txtTotal.Text = Format(GridView1.GetFocusedDataRow().Item(6), "###,###,##0")
                FormAddPembayaranPiutang.txtDP.Text = Format(GridView1.GetFocusedDataRow().Item(7), "###,###,##0")
                FormAddPembayaranPiutang.txtBayar.Text = Format(GridView1.GetFocusedDataRow().Item(8), "###,###,##0")
                FormAddPembayaranPiutang.txtSisa.Text = Format(GridView1.GetFocusedDataRow().Item(9), "###,###,##0")
                FormAddPembayaranPiutang.ShowDialog()
            Catch ex As Exception

            End Try
        ElseIf selection = "2" Then
            loadData()
        End If
    End Sub
End Class