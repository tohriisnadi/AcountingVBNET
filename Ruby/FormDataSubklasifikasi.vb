Public Class FormDataSubklasifikasi
    Dim DataSubklas As New ClassSubKelasAkun
    Dim OdataSubKlas As New DataTable

    Sub LoadData()
        OdataSubKlas.Clear()
        OdataSubKlas = DataSubklas.selectSubKelasAkun
        BindingSource1.DataSource = OdataSubKlas
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
            GridView1.Columns(1).Visible = False
        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub FormDataSubklasifikasi_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LoadData()
    End Sub

    Private Sub GridControl1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl1.Load
        setGrid()
    End Sub

    Private Sub GridControl1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GridControl1.MouseClick
        Try
            If e.Button <> Windows.Forms.MouseButtons.Right Then Return
            Dim cms = New ContextMenuStrip
            Dim item1 = cms.Items.Add("Baru")
            Dim item2 = cms.Items.Add("Edit Data")
            Dim item3 = cms.Items.Add("Refresh")

            item1.Tag = 1
            item2.Tag = 2
            item3.Tag = 3

            AddHandler item1.Click, AddressOf menuChoice
            AddHandler item2.Click, AddressOf menuChoice
            AddHandler item3.Click, AddressOf menuChoice

            cms.Show(GridControl1, e.Location)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub menuChoice(ByVal sender As Object, ByVal e As EventArgs)
        Dim item = CType(sender, ToolStripMenuItem)
        Dim selection = CInt(item.Tag)
        If selection = "1" Then
            FormAddSubKlas.X = "1"
            FormAddSubKlas.ShowDialog()
        ElseIf selection = "2" Then
            FormAddSubKlas.X = "2"
            FormAddSubKlas.txtSubKlas.Text = GridView1.GetFocusedDataRow.Item(2)
            FormAddSubKlas.cbKlasifikasi.Enabled = False
            FormEditAkun.ShowDialog()
        ElseIf selection = "3" Then
            LoadData()
        End If
    End Sub
End Class