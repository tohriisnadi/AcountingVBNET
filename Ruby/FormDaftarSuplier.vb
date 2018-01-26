Public Class FormDaftarSuplier
    Public x As Integer
    Public katakuncisuplier As String
    Dim oDataTabelsuplier As New DataTable
    Dim DataSuplier As New ClassSuplier
    Dim DataHutang As New ClassHutang

    Public Sub loadData()
        oDataTabelsuplier.Clear()
        ' oDataTabelsuplier = DataSuplier.dataSuplier
        BindingSource1.DataSource = oDataTabelsuplier
    End Sub

    Private Sub GridControl1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl1.DoubleClick
        setKodeSuplier()
    End Sub

    Private Sub GridControl1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles GridControl1.KeyPress
        If e.KeyChar = ChrW(13) Then
            setKodeSuplier()
        End If
    End Sub

    Private Sub GridControl1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl1.Load
        Dim i As Integer

        For i = 0 To GridView1.Columns.Count - 1
            GridView1.Columns(i).OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Next
        GridView1.Columns(0).Caption = "Kode Suplier"
        GridView1.Columns(1).Caption = "Nama Suplier"
        GridView1.Columns(2).Caption = "Alamat"
        GridView1.Columns(3).Caption = "No Telp"
        GridView1.Columns(4).Caption = "No Faximile"
        GridView1.Columns(5).Caption = "E-mail"
    End Sub

    Private Sub FormDaftarSuplier_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        GridView1.ApplyFindFilter("")
    End Sub

    Private Sub FormDaftarSuplier_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' oDataTabelsuplier = DataSuplier.dataSuplier
        BindingSource1.DataSource = oDataTabelsuplier
        BindingSource1.MoveFirst()
    End Sub

    Sub setKodeSuplier()
        Dim hutang As Long

        If x = 1 Then
            FormPembelian.txtLookUpSuplier.Text = GridView1.GetFocusedDataRow.Item(0)
            FormPembelian.txtNamaSuplier.Text = GridView1.GetFocusedDataRow.Item(1)
            FormPembelian.txtAlamatSuplier.Text = GridView1.GetFocusedDataRow.Item(2)
            '  hutang = DataHutang.dataHutang(GridView1.GetFocusedDataRow.Item(0))
            FormPembelian.txtHutang.Text = Format(hutang, "###,###,##0")
            If hutang = 0 Then
                FormPembelian.btnDetil.Enabled = False
            Else
                FormPembelian.btnDetil.Enabled = True
            End If
            FormPembelian.odataTabelHutang.Clear()
            ' FormDetailHutang.BindingSource1.DataSource = DataHutang.oDataTabelHutang
        ElseIf x = 2 Then
            '  FormReturBarang.txtLookUpSup.Text = GridView1.GetFocusedDataRow.Item(0)
            ' FormReturBarang.txtNamaSup.Text = GridView1.GetFocusedDataRow.Item(1)
            ' FormReturBarang.txtAlamatSup.Text = GridView1.GetFocusedDataRow.Item(2)
            'FormReturBarang.kodesup = GridView1.GetFocusedDataRow.Item(0)
        ElseIf x = 3 Then
            '  FormDataHutang.TxtNama.Text = GridView1.GetFocusedDataRow.Item(1)

            '  FormDataHutang.KodeSupli = GridView1.GetFocusedDataRow.Item(0)
        End If
        Close()
    End Sub


    Private Sub GridControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridControl1.Click

    End Sub

    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyValue = Keys.Escape Then
            Close()

        End If
    End Sub
End Class