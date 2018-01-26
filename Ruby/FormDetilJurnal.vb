Public Class FormDetilJurnal
    Dim dataJurnal As New ClassJurnal

    Dim OdataMasterJurnal As New DataTable
    Dim OdataDetilJurnal As New DataTable

    Sub LoadMasterJurnal(ByVal tglAwal As String, ByVal tglAkhir As String)
        OdataMasterJurnal.Clear()
        OdataMasterJurnal = dataJurnal.SelectMasterJurnalByDate(tglAwal, tglAkhir)
        BindingSource1.DataSource = OdataMasterJurnal
    End Sub

    Sub LoadUlang()

    End Sub

    Sub setGrid()
        Try
            GridView1.OptionsBehavior.Editable = False
            GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
            GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus

            For i = 0 To GridView1.Columns.Count - 1
                GridView1.Columns(i).OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
                GridView1.Columns(i).BestFit()
            Next
            GridView1.Columns(0).Visible = False
        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GridControl1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl1.DoubleClick
        Try
            OdataDetilJurnal.Clear()
            OdataDetilJurnal = dataJurnal.SelectDetilByKdMaster(GridView1.GetFocusedDataRow.Item(0))
            BindingSource2.DataSource = OdataDetilJurnal
        Catch ex As Exception
            MsgBox("Terjadi Kesalahan" + vbCrLf + ex.Message, MsgBoxStyle.Critical + vbOKOnly, "Error")
        End Try
        
    End Sub

    Private Sub GridControl1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl1.Load
        setGrid()
    End Sub

    Sub setGrid2()
        Try
            GridView2.OptionsBehavior.Editable = False
            GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
            GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus

            For i = 0 To GridView2.Columns.Count - 1
                GridView2.Columns(i).OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
                GridView2.Columns(i).BestFit()
            Next
            GridView2.Columns(0).Visible = True
        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GridControl2_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl2.Load
        setGrid2()
    End Sub

    Private Sub GridControl1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GridControl1.MouseClick
        Try
            If e.Button <> Windows.Forms.MouseButtons.Right Then Return
            Dim cms = New ContextMenuStrip
            Dim item1 = cms.Items.Add("Koreksi")
            'Dim item2 = cms.Items.Add("Edit Data")
            'Dim item3 = cms.Items.Add("Refresh")

            item1.Tag = 1
            'item2.Tag = 2
            'item3.Tag = 3

            AddHandler item1.Click, AddressOf menuChoice
            'AddHandler item2.Click, AddressOf menuChoice
            'AddHandler item3.Click, AddressOf menuChoice

            cms.Show(GridControl1, e.Location)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub menuChoice(ByVal sender As Object, ByVal e As EventArgs)
        Dim item = CType(sender, ToolStripMenuItem)
        Dim selection = CInt(item.Tag)
        If selection = "1" Then
            FormJurnalKoreksi.KdJurnal = GridView1.GetFocusedDataRow.Item(0)
            FormJurnalKoreksi.MaskedTextBox1.Text = GridView1.GetFocusedDataRow.Item(2)
            FormJurnalKoreksi.txtKeterangan.Text = GridView1.GetFocusedDataRow.Item(1)
            FormJurnalKoreksi.setColumn()
            For i As Integer = 0 To OdataDetilJurnal.Rows.Count - 1
                FormJurnalKoreksi.addNewRow(OdataDetilJurnal.Rows(i).Item(0), OdataDetilJurnal.Rows(i).Item(1), OdataDetilJurnal.Rows(i).Item(2), OdataDetilJurnal.Rows(i).Item(3))
                FormJurnalKoreksi.getTotal()

            Next

            FormJurnalKoreksi.ShowDialog()
        End If
    End Sub


End Class