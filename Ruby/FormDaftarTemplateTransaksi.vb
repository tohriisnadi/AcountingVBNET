Public Class FormDaftarTemplateTransaksi
    Dim dataTemplate As New ClassTemplateAkun
    Dim odataTemplate As New DataTable
    Public X As String

    Sub LoadData()
        odataTemplate.Clear()
        odataTemplate = dataTemplate.selectTxnList()
        BindingSource1.DataSource = odataTemplate
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
            GridView1.Columns(3).Caption = "Debet"
            GridView1.Columns(5).Caption = "Kredit"
            GridView1.Columns(2).Visible = False
            GridView1.Columns(4).Visible = False
            GridView1.Columns(6).Visible = False
            GridView1.Columns(7).Visible = False

            For i = 0 To GridView1.Columns.Count - 1
                GridView1.Columns(i).BestFit()
            Next
        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub GridControl1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl1.DoubleClick
        isiDAta()
    End Sub

    Sub isiDAta()
        Try
            If X = "1" Then
                FormInputTransaksiLain.kodeTemplate = GridView1.GetFocusedDataRow().Item(0)
                FormInputTransaksiLain.txtNamaTrans.Text = GridView1.GetFocusedDataRow().Item(1)
                FormInputTransaksiLain.kodeDebet = GridView1.GetFocusedDataRow().Item(2)
                FormInputTransaksiLain.cbDebet.Text = GridView1.GetFocusedDataRow().Item(3)
                FormInputTransaksiLain.kodeKredit = GridView1.GetFocusedDataRow().Item(4)
                FormInputTransaksiLain.cbKredit.Text = GridView1.GetFocusedDataRow().Item(5)
                Close()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Enter Then
            isiDAta()
        End If
    End Sub

    Private Sub GridControl1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl1.Load
        Try
            setGrid()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub FormDaftarTemplateTransaksi_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LoadData()
    End Sub

    Private Sub GridControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridControl1.Click

    End Sub
End Class