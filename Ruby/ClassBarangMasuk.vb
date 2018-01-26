Imports System.Data.Odbc
Public Class ClassBarangMasuk
    Dim Command As New OdbcCommand
    Dim oDataAdapter As New OdbcDataAdapter
    Dim dbTrans As OdbcTransaction
    Sub AddBarangMasuk(ByVal noNota As String, ByVal tglNota As String, ByVal kodeSuplier As String, ByVal totalBeli As Long, ByVal kodeOperator As String, ByVal isLunas As String, ByVal isRetur As String, ByVal dp As Long, ByVal tglJatuhTempo As String, ByVal odataTabel As DataTable)
        Dim i As Integer
        modKoneksi.bukaKoneksi()
        DBTrans = modKoneksi.koneksi.BeginTransaction
        command.Connection = modKoneksi.Koneksi
        command.Transaction = DBTrans
        command.CommandType = CommandType.Text


        command.CommandText = " exec addMasterBarangMasuk '" & noNota & "','" & tglNota & "','" & kodeSuplier & "','" & totalBeli & "','" & kodeOperator & "','" & isLunas & "','" & isRetur & "','" & dp & "','" & tglJatuhTempo & "'"
        Try
            command.ExecuteNonQuery()
            For i = 0 To odataTabel.Rows.Count - 1
                Command.CommandText = " exec addBarangMasukdetil '" & Guid.NewGuid.ToString & "','" & noNota & "','" & odataTabel.Rows(i).Item(0) & "','" & odataTabel.Rows(i).Item(3) & "','" & odataTabel.Rows(i).Item(2) & "','" & odataTabel.Rows(i).Item(4) & "','','','" & odataTabel.Rows(i).Item(5) & "','0'"
                command.ExecuteNonQuery()
            Next

            DBTrans.Commit()
            '  MsgBox("Data Pembelian Disimpan", MsgBoxStyle.Information, "Informasi")
        Catch ex As Exception
            DBTrans.Rollback()
            MsgBox("Pesan Error : " + vbCrLf + ex.Message + vbCrLf + "Data gagal disimpan ! ", MsgBoxStyle.Critical, "Error")
        End Try
        modKoneksi.tutupKoneksi()

    End Sub

    Function selectDataPembelian(ByVal tgl1 As String, ByVal tgl2 As String, ByVal kodeOP As String)
        Dim oDataTabelPembelian As New DataTable

        modKoneksi.bukaKoneksi()
        Command.Connection = modKoneksi.Koneksi
        Command.CommandType = CommandType.Text
        Command.CommandText = "exec selectDataPembelian '" & tgl1 & "','" & tgl2 & "','" & kodeOP & "'"
        oDataAdapter.SelectCommand = Command
        oDataAdapter.Fill(oDataTabelPembelian)
        modKoneksi.tutupKoneksi()

        Return oDataTabelPembelian
    End Function

    Function selectDataPembelianByNota(ByVal nota As String)
        Dim oDataPembelianNota As New DataTable

        modKoneksi.bukaKoneksi()
        Command.Connection = modKoneksi.Koneksi
        Command.CommandType = CommandType.Text
        Command.CommandText = "exec selectDataBarangMasukByNota '" & nota & "'"
        oDataAdapter.SelectCommand = Command
        oDataAdapter.Fill(oDataPembelianNota)
        modKoneksi.tutupKoneksi()

        Return oDataPembelianNota
    End Function

    Function selectDetilDataPembelianByNota(ByVal nota As String)
        Dim oDataPembelianDetilNota As New DataTable

        modKoneksi.bukaKoneksi()
        Command.Connection = modKoneksi.Koneksi
        Command.CommandType = CommandType.Text
        Command.CommandText = "exec selectDetilDataBarangMasukByNota '" & nota & "'"
        oDataAdapter.SelectCommand = Command
        oDataAdapter.Fill(oDataPembelianDetilNota)
        modKoneksi.tutupKoneksi()

        Return oDataPembelianDetilNota
    End Function
    Function selectRekapPembelian(ByVal tgl1 As String, ByVal tgl2 As String)
        Dim oDataTabelPembelian As New DataTable

        modKoneksi.bukaKoneksi()
        Command.Connection = modKoneksi.Koneksi
        Command.CommandType = CommandType.Text
        Command.CommandText = "exec selectRekapanPembelian '" & tgl1 & "','" & tgl2 & "'"
        oDataAdapter.SelectCommand = Command
        oDataAdapter.Fill(oDataTabelPembelian)
        modKoneksi.tutupKoneksi()

        Return oDataTabelPembelian
    End Function
End Class
