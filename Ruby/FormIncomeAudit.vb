Public Class FormIncomeAudit
    Dim dataIA As New ClassIncomeAudit
    Dim OdataReservasi As New DataTable


    Private Sub btnProses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProses.Click
        OdataReservasi.Clear()
        OdataReservasi = dataIA.SelectReservasi(cbTanggal.Text)
        BindingSource1.DataSource = OdataReservasi
    End Sub

    Sub setGrid()
        Try
            GridView1.OptionsBehavior.Editable = False
            GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
            GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus

            For i = 0 To GridView1.Columns.Count - 1
                GridView1.Columns(i).OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            Next

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

    Private Sub FormIncomeAudit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cbTanggal.EditValue = Date.Now
    End Sub



    Private Sub btnJurnal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJurnal.Click
        FormJurnal.LoadJurnalIncome(OdataReservasi)
        FormJurnal.Show()
    End Sub
End Class