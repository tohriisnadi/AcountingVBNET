Public Class FormDataBankdanRekening
    Dim dataBank As New ClassBank
    Dim odatabank As New DataTable


    Sub LoadData()
        odatabank.Clear()
        odatabank = dataBank.selectDataBank
        BindingSource1.DataSource = odatabank
    End Sub

    Private Sub FormDataBankdanRekening_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LoadData()
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
            FormAddBank.ShowDialog()
        ElseIf selection = "2" Then
            'FormEditAkun.idAkun = GridView1.GetFocusedDataRow().Item(0)
            'FormEditAkun.cbKlasifikasi.Text = GridView1.GetFocusedDataRow().Item(4)
            'FormEditAkun.txtNamaAkun.Text = GridView1.GetFocusedDataRow().Item(5)
            'FormEditAkun.ShowDialog()
        ElseIf selection = "3" Then
            loadData()
        End If
    End Sub
End Class