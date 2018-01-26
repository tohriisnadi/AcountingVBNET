Public Class FormJurnalPenyesuaian

    Dim dataAkun As New ClassAkun
    Dim odataKlas As New DataTable
    Dim dataKlas As New ClassAkun
    Dim kodebaru(1000) As String
    Dim idKlas As String
    Dim datajurnalentri As New ClassJurnal
    Dim odatatabeljurnal As New DataTable
    Dim oDataTabelUnbound As New DataTable
    Dim oRow As DataRow
    Dim tanggal(3) As String
    Dim tangalGabung As String
    Dim tanggal2(3) As String

    Private Sub setColumnUnbound()
        Try
            oDataTabelUnbound.Rows.Clear()
            oDataTabelUnbound.Columns.Clear()
            oDataTabelUnbound.Clear()
            oDataTabelUnbound.Columns.Add(New DataColumn("Akun", GetType(String))) '0
            oDataTabelUnbound.Columns.Add(New DataColumn("Debet", GetType(Long))) '1
            oDataTabelUnbound.Columns.Add(New DataColumn("Kredit", GetType(Long))) '2
            BindingSource1.DataSource = oDataTabelUnbound
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Sub addRow(ByVal Akun As String, ByVal Debet As Long, ByVal Kredit As Long)
        oRow = oDataTabelUnbound.NewRow
        oRow(0) = Akun
        oRow(1) = Debet
        oRow(2) = Kredit
        oDataTabelUnbound.Rows.Add(oRow)
        setGrid()
        'Catch ex As Exception
        'MsgBox(ex.Message)
        'End Try
    End Sub

    Private Sub setGrid()
        Try
            GridView1.OptionsBehavior.Editable = False
            GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
            GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus

            For i = 0 To GridView1.Columns.Count - 1
                GridView1.Columns(i).BestFit()
            Next
            GridView1.Columns(1).Summary.Clear()
            GridView1.Columns(2).Summary.Clear()
            GridView1.Columns(1).Summary.Add(DevExpress.Data.SummaryItemType.Sum, "Debet", "{0:c2}")
            GridView1.Columns(2).Summary.Add(DevExpress.Data.SummaryItemType.Sum, "Kredit", "{0:c2}")

            GridView1.Columns(1).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
            GridView1.Columns(1).DisplayFormat.FormatString = "c"

            GridView1.Columns(2).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
            GridView1.Columns(2).DisplayFormat.FormatString = "c"
            BindingSource1.DataSource = oDataTabelUnbound
        Catch ex As Exception

        End Try
    End Sub

    Dim akunSimpan(2) As String
    Private Sub loadAkun()
        Dim properties As DevExpress.XtraEditors.Repository.RepositoryItemComboBox = cbakun.Properties
        Dim i As Integer

        properties.Items.Clear()
        odataKlas.Clear()
        odataKlas = dataKlas.selectAkun(1, 0)


        For i = 0 To odataKlas.Rows().Count() - 1
            kodebaru(i) = odataKlas.Rows(i).Item(0)
            properties.Items.Add(odataKlas.Rows(i).Item(0) & "-" & odataKlas.Rows(i).Item(5))
        Next
        properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        'cbakun.MenuManager.ShowPopupMenu(SearchDirectionHint.Down, AcceptButton.DialogResult, AccessibleDescription.Length)
    End Sub

    Private Sub btnsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsimpan.Click
        Dim debet As Long
        Dim kredit As Long
        Dim i As Integer
        debet = 0
        kredit = 0
        tanggal = txttanggal.Text.Split("/")
        tangalGabung = tanggal(1) & "/" & tanggal(0) & "/" & tanggal(2)

        For i = 0 To oDataTabelUnbound.Rows.Count() - 1
            debet = debet + CLng(oDataTabelUnbound.Rows(i).Item(1))
            kredit = kredit + CLng(oDataTabelUnbound.Rows(i).Item(2))
        Next
        If debet < kredit Or debet > kredit Or kredit < debet Or kredit > debet Then
            MsgBox("Jurnal Tidak Balence, Silahkan Cek Kembali!", MsgBoxStyle.Critical, "Peringatan")

        ElseIf IsDate(tangalGabung) = False Then
            MsgBox("Tanggal salah !", MsgBoxStyle.Critical, "Peringatan")
        ElseIf debet = kredit And IsDate(tangalGabung) = True Then
            datajurnalentri.addJurnaPenyesuaian(tangalGabung, "-", txtketerangan.Text, oDataTabelUnbound)
            fullclear()
        Else
            MsgBox("Kesalahan Proses Input !", MsgBoxStyle.Critical, "Peringatan")

            'akunSimpan = cbakun.Text.Split("-")
            'MsgBox(akunSimpan(0))
            'MsgBox(akunSimpan(1))

        End If
    End Sub

    Sub fullclear()
        txtbuktitransaksi.Text = ""
        txtdebet.Text = "0"
        txtkredit.Text = "0"
        txtketerangan.Text = ""
        oDataTabelUnbound.Clear()
        txtbuktitransaksi.Focus()
    End Sub
    Sub clear()
        txtdebet.Text = "0"
        txtkredit.Text = "0"
    End Sub

    Private Sub txttanggal_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txttanggal.KeyDown
        If e.KeyCode = Keys.Enter Then
            tanggal = txttanggal.Text.Split("/")
            tangalGabung = tanggal(1) & "/" & tanggal(0) & "/" & tanggal(2)
            txtbuktitransaksi.Focus()


        End If
    End Sub

    Private Sub cbakun_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbakun.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtdebet.Focus()
        ElseIf e.KeyCode = Keys.S Then
            Dim debet As Long
            Dim kredit As Long
            Dim i As Integer
            debet = 0
            kredit = 0
            For i = 0 To oDataTabelUnbound.Rows.Count() - 1
                debet = debet + CLng(oDataTabelUnbound.Rows(i).Item(1))
                kredit = kredit + CLng(oDataTabelUnbound.Rows(i).Item(2))

            Next
            If debet < kredit Or debet > kredit Or kredit < debet Or kredit > debet Then
                MsgBox("Jurnal Tidak Balance, Silahkan Cek Kembali!", MsgBoxStyle.Critical, "Peringatan")

            ElseIf IsDate(tangalGabung) = False Then
                MsgBox("Tanggal salah !", MsgBoxStyle.Critical, "Peringatan")
            ElseIf debet = kredit And IsDate(tangalGabung) = True Then
                datajurnalentri.addJurnaPenyesuaian(tangalGabung, "-", txtketerangan.Text, oDataTabelUnbound)
                clear()
                oDataTabelUnbound.Clear()
            Else
                MsgBox("Kesalahan Proses Input !", MsgBoxStyle.Critical, "Peringatan")

                'akunSimpan = cbakun.Text.Split("-")
                'MsgBox(akunSimpan(0))
                'MsgBox(akunSimpan(1))
            End If
        End If
    End Sub

    Private Sub FormJurnalPenyesuaian_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        loadAkun()
        setGrid()
        setColumnUnbound()
        txttanggal.Text = Format(Date.Now, "dd/MM/yyyy")
        txttanggal.Focus()
        txttanggal.SelectAll()
    End Sub

    Private Sub txtkredit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtkredit.KeyDown
        If e.KeyCode = Keys.Enter Then
            addRow(cbakun.Text, txtdebet.Text, txtkredit.Text)
            setGrid()
            cbakun.Focus()
            clear()

        End If

    End Sub

    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.OemMinus Then
            GridView1.GetFocusedDataRow.Delete()

        End If
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Close()
    End Sub
End Class