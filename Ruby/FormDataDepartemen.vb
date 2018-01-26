Public Class FormDataDepartemen
    Dim DataDepartemen As New ClassDepartemen
    Dim OdataDepartemen As New DataTable


    Sub loadDepartemen()
        OdataDepartemen.Clear()
        OdataDepartemen = DataDepartemen.selectDataDepartemen
        BindingSource1.DataSource = OdataDepartemen
    End Sub

    Private Sub GridControl1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl1.Load
        Dim i As Integer
        GridView1.OptionsBehavior.Editable = False
        GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        For i = 0 To GridView1.Columns.Count - 1
            GridView1.Columns(i).OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            GridView1.Columns(i).BestFit()
        Next
    End Sub

    Private Sub FormDataDepartemen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        loadDepartemen()
    End Sub

    Private Sub GridControl1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GridControl1.MouseClick
        Try
            If e.Button <> Windows.Forms.MouseButtons.Right Then Return
            Dim cms = New ContextMenuStrip
            Dim item1 = cms.Items.Add("Baru")
            Dim item2 = cms.Items.Add("Edit Data")
            Dim item3 = cms.Items.Add("Non Aktifkan")
            Dim item4 = cms.Items.Add("Refresh")

            item1.Tag = 1
            item2.Tag = 2
            item3.Tag = 3
            item4.Tag = 4

            AddHandler item1.Click, AddressOf menuChoice
            AddHandler item2.Click, AddressOf menuChoice
            AddHandler item3.Click, AddressOf menuChoice
            AddHandler item4.Click, AddressOf menuChoice

            cms.Show(GridControl1, e.Location)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub menuChoice(ByVal sender As Object, ByVal e As EventArgs)
        Dim item = CType(sender, ToolStripMenuItem)
        Dim selection = CInt(item.Tag)
        If selection = "1" Then
            FormAddDepartemen.X = "2"
            FormAddDepartemen.ShowDialog()
        ElseIf selection = "2" Then
            FormAddDepartemen.X = "3"
            FormAddDepartemen.Kode = GridView1.GetFocusedDataRow().Item(0)
            FormAddDepartemen.txtDepartemen.Text = GridView1.GetFocusedDataRow().Item(1)
            FormAddDepartemen.txtKeterangan.Text = GridView1.GetFocusedDataRow().Item(2)
            FormAddDepartemen.ShowDialog()
        ElseIf selection = "3" Then
            DataDepartemen.NonAktifDepartemen(GridView1.GetFocusedDataRow().Item(0))
            loadDepartemen()
        ElseIf selection = "4" Then
            loadDepartemen()
        End If
    End Sub
End Class