Public Class FormNeracaAwal
    Dim odataTabel As New DataTable
    Dim odataAkun As New DataTable
    Dim dataAkun As New ClassAkun
    Dim oRow As DataRow
    Dim status As Integer

    Sub loadTabel()

        odataTabel.Columns.Clear()
        odataTabel.Rows.Clear()
        odataTabel.Columns.Add(New DataColumn("No Akun", GetType(String)))
        odataTabel.Columns.Add(New DataColumn("Akun", GetType(String)))
        odataTabel.Columns.Add(New DataColumn("Saldo", GetType(String)))

        BindingSource1.DataSource = odataTabel
    End Sub

    Sub setGrid()
        Try
            For i = 0 To GridView1.Columns.Count - 1
                GridView1.Columns(i).OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            Next

            GridView1.Columns(0).Caption = "No Akun"

            For i = 0 To GridView1.Columns.Count - 1
                GridView1.Columns(i).BestFit()
            Next


        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub FormNeracaAwal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        status = 1
        loadTabel()
        loadData()
    End Sub

    Private Sub GridControl1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl1.Load
        setGrid()
    End Sub

    Sub loadData()
        odataAkun.Clear()
        odataAkun = dataAkun.selectAkun("1", "0")
        
        odataTabel.Clear()
        For i = 0 To odataAkun.Rows.Count() - 1
            oRow = odataTabel.NewRow
            oRow(0) = odataAkun.Rows(i).Item(0)
            oRow(1) = odataAkun.Rows(i).Item(5)
            oRow(2) = Format(CInt(odataAkun.Rows(i).Item(6)), "###,###,##0")

            odataTabel.Rows.Add(oRow)
            GridControl1.Refresh()
        Next
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If odataTabel.Rows().Count() < 1 Then
            MsgBox("Terjadi kesalahan!", MsgBoxStyle.Information, "Informasi")
        ElseIf odataTabel.Rows().Count() > 0 Then
            For i = 0 To odataTabel.Rows.Count - 1
                If IsNumeric(odataTabel.Rows(i).Item(2)) = False Then
                    status = 0
                    Exit For
                End If
            Next
        End If
        cek()
    End Sub

    Sub cek()
        If status = 0 Then
            MsgBox("Saldo salah!", MsgBoxStyle.Critical, "Peringatan")
            status = 1
        ElseIf status = 1 Then
            dataAkun.addNeracaAwal(odataTabel)
            Close()
        End If
    End Sub
End Class