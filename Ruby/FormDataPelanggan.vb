Public Class FormDataPelanggan
    Dim dataPelanggan As New ClassPelanggan
    Dim odataPelanggan As New DataTable

    Sub loadData()
        odataPelanggan.Clear()
        odataPelanggan = dataPelanggan.selectPelanggan()
        BindingSource1.DataSource = odataPelanggan
    End Sub

    Private Sub FormDataPelanggan_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        loadData()
    End Sub

    Sub setGrid()
        Try
            GridView1.OptionsBehavior.Editable = False
            GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
            GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus

            For i = 0 To GridView1.Columns.Count - 1
                GridView1.Columns(i).OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            Next

            GridView1.Columns(0).Caption = "Kode Pelanggan"
            GridView1.Columns(1).Caption = "Nama "
            GridView1.Columns(2).Caption = "Alamat"
            GridView1.Columns(3).Caption = "No Telepon"
            GridView1.Columns(4).Visible = False

            For i = 0 To GridView1.Columns.Count - 1
                GridView1.Columns(i).BestFit()
            Next
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
            Dim item1 = cms.Items.Add("Baru")
            Dim item2 = cms.Items.Add("Edit Data")
            Dim item3 = cms.Items.Add("Non Aktif")
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
            FormAddPelanggan.ShowDialog()
        ElseIf selection = "2" Then
            FormEditPelanggan.kodePelanggan = GridView1.GetFocusedDataRow().Item(0)
            FormEditPelanggan.txtNama.Text = GridView1.GetFocusedDataRow().Item(1)
            FormEditPelanggan.txtAlamat.Text = GridView1.GetFocusedDataRow().Item(2)
            FormEditPelanggan.txtNoTelp.Text = GridView1.GetFocusedDataRow().Item(3)
            FormEditPelanggan.ShowDialog()
        ElseIf selection = "3" Then
            If MsgBox("Non Aktifkan pelanggan ini?", vbYesNo, "Peringatan") = vbYes Then
                dataPelanggan.setNonAktifPelanggan(GridView1.GetFocusedDataRow().Item(0))
                loadData()
            End If
        ElseIf selection = "4" Then
            loadData()
        End If
    End Sub
End Class