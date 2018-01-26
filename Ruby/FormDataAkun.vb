Public Class FormDataAkun
    Dim dataAkun As New ClassAkun
    Dim odataAkun As New DataTable
    Dim isAktif As String
    Dim isNoAktif As String

    Sub loadData()
        odataAkun.Clear()
        odataAkun = dataAkun.selectAkun(isAktif, isNoAktif)
        BindingSource1.DataSource = odataAkun
    End Sub

    Private Sub FormDataAkun_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        isAktif = "1"
        isNoAktif = "0"
        loadData()
        GridControl1.Height = Me.Height * 0.9
        setGrid()
    End Sub

    Sub setGrid()
        Try
            GridView1.OptionsBehavior.Editable = False
            GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
            GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus

            For i = 0 To GridView1.Columns.Count - 1
                GridView1.Columns(i).OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            Next

            GridView1.Columns(1).Visible = False
            GridView1.Columns(3).Visible = False
            GridView1.Columns(6).Visible = False
            GridView1.Columns(0).Caption = "Kode Akun"
            GridView1.Columns(2).Caption = "Klasifikasi"
            GridView1.Columns(4).Caption = "Subklasifikasi"
            GridView1.Columns(5).Caption = "Akun"
            
            For i = 0 To GridView1.Columns.Count - 1
                GridView1.Columns(i).BestFit()
            Next
        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub GridControl1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl1.Load
        setGrid()
        GridControl1.Height = Me.Height * 0.9
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        loadData()
    End Sub

    Private Sub CheckAktif_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckAktif.CheckedChanged
        If CheckAktif.Checked = True Then
            isAktif = "1"
        Else
            isAktif = "0"
        End If
    End Sub

    Private Sub CheckNoAktif_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckNoAktif.CheckedChanged
        If CheckNoAktif.Checked = True Then
            isNoAktif = "1"
        Else
            isNoAktif = "0"
        End If
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
            FormAddAkun.ShowDialog()
        ElseIf selection = "2" Then
            FormEditAkun.idAkun = GridView1.GetFocusedDataRow().Item(0)
            FormEditAkun.cbKlasifikasi.Text = GridView1.GetFocusedDataRow().Item(4)
            FormEditAkun.txtNamaAkun.Text = GridView1.GetFocusedDataRow().Item(5)
            FormEditAkun.ShowDialog()
        ElseIf selection = "3" Then
            loadData()
        End If
    End Sub

End Class