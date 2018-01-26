Public Class FormDataTamplate
    Dim odataTemplate As New DataTable
    Dim dataTemplate As New ClassTemplateAkun

    Sub LoadData()
        odataTemplate.Clear()
        odataTemplate = dataTemplate.selectTemplateTransaksi()
        BindingSource1.DataSource = odataTemplate
    End Sub

    Private Sub FormDataTamplate_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
            FormAddTemplateTransaksi.ShowDialog()
        ElseIf selection = "2" Then
            FormEditAkun.idAkun = GridView1.GetFocusedDataRow().Item(0)
            FormEditAkun.txtNamaAkun.Text = GridView1.GetFocusedDataRow().Item(5)
            FormEditAkun.ShowDialog()
        End If
    End Sub

    Sub setGrid()
        Try
            GridView1.OptionsBehavior.Editable = False
            GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
            GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus

            For i = 0 To GridView1.Columns.Count - 1
                GridView1.Columns(i).OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            Next

            GridView1.Columns(0).Caption = "Kode Template"
            GridView1.Columns(1).Caption = "Nama "
            GridView1.Columns(2).Caption = "Debet"
            GridView1.Columns(3).Caption = "Kredit"
            GridView1.Columns(4).Caption = "Tipe"
            GridView1.Columns(5).Caption = "Input Manual"

            For i = 0 To GridView1.Columns.Count - 1
                GridView1.Columns(i).BestFit()
            Next
        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try

    End Sub

End Class