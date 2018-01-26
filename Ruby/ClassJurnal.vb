Imports System.Data.Odbc
Public Class ClassJurnal
    Dim Command As New OdbcCommand
    Dim oDataAdapter As New OdbcDataAdapter
    Dim dbTrans As OdbcTransaction
    Sub addJurnaPenyesuaian(ByVal tanggal As Date, ByVal nobukti As String, ByVal keterangan As String, ByVal odatatabel As DataTable)
        Dim akun(1) As String
        Dim i As Integer
        Dim x As Integer

        Dim nomaster As String
        ModKoneksi.bukaKoneksi()
        dbTrans = ModKoneksi.Koneksi.BeginTransaction
        Command.Connection = ModKoneksi.Koneksi
        Command.Transaction = dbTrans
        Command.CommandType = CommandType.StoredProcedure
        Command.CommandText = "{call addMasterJurnalForPenyesuaian (?,?,?,?,?,?,?)}"
        Try
            Command.Parameters.Add("@tgl", OdbcType.DateTime, 50, ParameterDirection.Input).Value = tanggal
            Command.Parameters.Add("@noBUktiTrans", OdbcType.VarChar, 50, ParameterDirection.Input).Value = nobukti
            Command.Parameters.Add("@keterangan", OdbcType.VarChar, 50, ParameterDirection.Input).Value = keterangan
            Command.Parameters.Add("@kodeUser", OdbcType.VarChar, 50, ParameterDirection.Input).Value = ModKoneksi.kodeOperator
            Command.Parameters.Add("@namaUser", OdbcType.VarChar, 30, ParameterDirection.Input).Value = ModKoneksi.namaOperator
            Command.Parameters.Add("@Notxn", OdbcType.VarChar, 50, ParameterDirection.Input).Value = Guid.NewGuid.ToString
            Command.Parameters.Add("@noMaster", OdbcType.VarChar, 50)
            Command.Parameters("@noMaster").Direction = ParameterDirection.Output

            Command.ExecuteNonQuery()
            nomaster = Command.Parameters("@noMaster").Value
            Command.Parameters.Clear()

            For i = 0 To odatatabel.Rows.Count - 1
                akun = odatatabel.Rows(i).Item(0).split("-")

                Command.CommandText = " exec addDetilJurnal '" & nomaster & "','" & akun(0) & "','" & odatatabel.Rows(i).Item(1) & "','" & odatatabel.Rows(i).Item(2) & "','" & tanggal & "','" & Guid.NewGuid.ToString & "'"

                '   Command.CommandText = " exec addDetilJurnal '" & nomaster & "','" & Guid.NewGuid.ToString & "','" & tanggal & "','" & akun(0) & "','" & odatatabel.Rows(i).Item(1) & "','" & odatatabel.Rows(i).Item(2) & "'"
                Command.ExecuteNonQuery()
            Next

            dbTrans.Commit()
            MsgBox("Data berhasil disimpan ", MsgBoxStyle.Information, "Informasi ")
        Catch ex As Exception
            dbTrans.Rollback()
            MsgBox("Pesan Error : " + vbCrLf + ex.Message + vbCrLf + "Data gagal disimpan ! ", MsgBoxStyle.Critical, "Error")
        End Try
        ModKoneksi.tutupKoneksi()
    End Sub
    Function selectMutasiHariIni()
        Dim oDataTabel As New DataTable
        oDataTabel.Clear()
        ModKoneksi.BukaKoneksi()
        Command.Connection = ModKoneksi.Koneksi
        Command.CommandType = CommandType.Text
        Command.CommandText = "exec selectMutasiHariIni"
        oDataAdapter.SelectCommand = Command
        oDataAdapter.Fill(oDataTabel)
        ModKoneksi.TutupKoneksi()
        Return oDataTabel
    End Function
    Function selectTransaksiLabaRugi()
        Dim oDataTabel As New DataTable
        oDataTabel.Clear()
        ModKoneksi.BukaKoneksi()
        Command.Connection = ModKoneksi.Koneksi
        Command.CommandType = CommandType.Text
        Command.CommandText = "exec selectTransaksiLabaRugi"
        oDataAdapter.SelectCommand = Command
        oDataAdapter.Fill(oDataTabel)
        ModKoneksi.TutupKoneksi()
        Return oDataTabel
    End Function
    Function selectTransaksiNeraca()
        Dim oDataTabel As New DataTable
        oDataTabel.Clear()
        ModKoneksi.BukaKoneksi()
        Command.Connection = ModKoneksi.Koneksi
        Command.CommandType = CommandType.Text
        Command.CommandText = "exec selectTransaksiNeraca"
        oDataAdapter.SelectCommand = Command
        oDataAdapter.Fill(oDataTabel)
        ModKoneksi.TutupKoneksi()
        Return oDataTabel
    End Function
    Function addMasterJurnal2(ByVal tgl As String, ByVal noBuktiTrx As String, ByVal keterangan As String, ByVal akunDebet As String, ByVal akunKredit As String, ByVal nominal As Long)
        Dim i As Integer
        Dim noMaster As String
        ModKoneksi.BukaKoneksi()
        dbTrans = ModKoneksi.Koneksi.BeginTransaction
        Command.Connection = ModKoneksi.Koneksi
        Command.Transaction = dbTrans
        Command.CommandType = CommandType.StoredProcedure
        'Command.CommandText = "exec AddMasterReceivingOrder '" & nonota & "','" & noPO & "','" & remark & "','" & ModKoneksi.kodeOperator & "','" & ModKoneksi.namaOperator & "','" & Guid.NewGuid.ToString & "'"
        Command.CommandText = "{call addMasterJurnal (?,?,?,?,?,?,?)}"
        Try
            Command.Parameters.Add("@tgl", OdbcType.VarChar, 20, ParameterDirection.Input).Value = tgl
            Command.Parameters.Add("@noBUktiTrans", OdbcType.VarChar, 255, ParameterDirection.Input).Value = noBuktiTrx
            Command.Parameters.Add("@keterangan", OdbcType.VarChar, 200, ParameterDirection.Input).Value = keterangan
            Command.Parameters.Add("@kodeUser", OdbcType.VarChar, 20, ParameterDirection.Input).Value = ModKoneksi.kodeOperator
            Command.Parameters.Add("@namaUSer", OdbcType.VarChar, 50, ParameterDirection.Input).Value = ModKoneksi.namaOperator
            Command.Parameters.Add("@noTxn", OdbcType.VarChar, 50, ParameterDirection.Input).Value = Guid.NewGuid.ToString
            Command.Parameters.Add("@noMaster", OdbcType.VarChar, 20)
            Command.Parameters("@noMaster").Direction = ParameterDirection.Output

            Command.ExecuteNonQuery()
            noMaster = Command.Parameters("@noMaster").Value
            Command.Parameters.Clear()


            Command.CommandText = " exec addDetilJurnal '" & noMaster & "','" & akunDebet & "','" & nominal & "','0','" & tgl & "','" & Guid.NewGuid.ToString & "'"
            Command.ExecuteNonQuery()

            Command.CommandText = " exec addDetilJurnal '" & noMaster & "','" & akunKredit & "','0','" & nominal & "','" & tgl & "','" & Guid.NewGuid.ToString & "'"
            Command.ExecuteNonQuery()

            dbTrans.Commit()
            MsgBox("Data berhasil disimpan ", MsgBoxStyle.Information, "Informasi")
        Catch ex As Exception
            dbTrans.Rollback()
            MsgBox("Pesan Error : " + vbCrLf + ex.Message + vbCrLf + "Data gagal disimpan ! ", MsgBoxStyle.Critical, "Error")
        End Try
        ModKoneksi.TutupKoneksi()
        Return noMaster
    End Function
    Function addMasterJurnal(ByVal tgl As String, ByVal noBuktiTrx As String, ByVal keterangan As String, ByVal odataTabel As DataTable)
        Dim i As Integer
        Dim noMaster As String
        ModKoneksi.BukaKoneksi()
        dbTrans = ModKoneksi.Koneksi.BeginTransaction
        Command.Connection = ModKoneksi.Koneksi
        Command.Transaction = dbTrans
        Command.CommandType = CommandType.StoredProcedure
        'Command.CommandText = "exec AddMasterReceivingOrder '" & nonota & "','" & noPO & "','" & remark & "','" & ModKoneksi.kodeOperator & "','" & ModKoneksi.namaOperator & "','" & Guid.NewGuid.ToString & "'"
        Command.CommandText = "{call addMasterJurnal (?,?,?,?,?,?,?)}"
        Try
            Command.Parameters.Add("@tgl", OdbcType.VarChar, 20, ParameterDirection.Input).Value = tgl
            Command.Parameters.Add("@noBUktiTrans", OdbcType.VarChar, 255, ParameterDirection.Input).Value = noBuktiTrx
            Command.Parameters.Add("@keterangan", OdbcType.VarChar, 200, ParameterDirection.Input).Value = keterangan
            Command.Parameters.Add("@kodeUser", OdbcType.VarChar, 20, ParameterDirection.Input).Value = ModKoneksi.kodeOperator
            Command.Parameters.Add("@namaUSer", OdbcType.VarChar, 50, ParameterDirection.Input).Value = ModKoneksi.namaOperator
            Command.Parameters.Add("@noTxn", OdbcType.VarChar, 50, ParameterDirection.Input).Value = Guid.NewGuid.ToString
            Command.Parameters.Add("@noMaster", OdbcType.VarChar, 20)
            Command.Parameters("@noMaster").Direction = ParameterDirection.Output

            Command.ExecuteNonQuery()
            noMaster = Command.Parameters("@noMaster").Value
            Command.Parameters.Clear()


            For i = 0 To odataTabel.Rows.Count - 1
                Command.CommandText = " exec addDetilJurnal '" & noMaster & "','" & odataTabel.Rows(i).Item(1) & "','" & odataTabel.Rows(i).Item(3) & "','" & odataTabel.Rows(i).Item(4) & "','" & tgl & "','" & Guid.NewGuid.ToString & "'"
                Command.ExecuteNonQuery()
            Next

            dbTrans.Commit()
            MsgBox("Data berhasil disimpan ", MsgBoxStyle.Information, "Informasi")
        Catch ex As Exception
            dbTrans.Rollback()
            MsgBox("Pesan Error : " + vbCrLf + ex.Message + vbCrLf + "Data gagal disimpan ! ", MsgBoxStyle.Critical, "Error")
        End Try
        ModKoneksi.TutupKoneksi()
        Return noMaster
    End Function

    Function selectMutasibyBulan(ByVal bulan As String, ByVal tahun As String)
        Dim oDataTabel As New DataTable
        oDataTabel.Clear()
        ModKoneksi.bukaKoneksi()
        Command.Connection = ModKoneksi.Koneksi
        Command.CommandType = CommandType.Text
        Command.CommandText = "exec selectMutasibyBulan '" & bulan & "','" & tahun & "'"
        oDataAdapter.SelectCommand = Command
        oDataAdapter.Fill(oDataTabel)
        ModKoneksi.tutupKoneksi()
        Return oDataTabel
    End Function

    Function SelectMasterJurnalByDate(ByVal tglAwal As String, ByVal tglAkhir As String)
        Dim oDataTabel As New DataTable
        oDataTabel.Clear()
        ModKoneksi.BukaKoneksi()
        Command.Connection = ModKoneksi.Koneksi
        Command.CommandType = CommandType.Text
        Command.CommandText = "exec selectMasterJurnal '" & tglAwal & "','" & tglAkhir & "'"
        oDataAdapter.SelectCommand = Command
        oDataAdapter.Fill(oDataTabel)
        ModKoneksi.TutupKoneksi()
        Return oDataTabel
    End Function

    Function SelectDetilByKdMaster(ByVal kdMaster As String)
        Dim oDataTabel As New DataTable
        oDataTabel.Clear()
        ModKoneksi.BukaKoneksi()
        Command.Connection = ModKoneksi.Koneksi
        Command.CommandType = CommandType.Text
        Command.CommandText = "exec SelectDetilJurnalByIdMaster '" & kdMaster & "'"
        oDataAdapter.SelectCommand = Command
        oDataAdapter.Fill(oDataTabel)
        ModKoneksi.TutupKoneksi()
        Return oDataTabel
    End Function

    Sub KoreksiJurnal(ByVal kdJurnal As String, ByVal tanggal As Date, ByVal nobukti As String, ByVal keterangan As String, ByVal odatatabel As DataTable)
        ModKoneksi.BukaKoneksi()
        dbTrans = ModKoneksi.Koneksi.BeginTransaction
        Command.Connection = ModKoneksi.Koneksi
        Command.Transaction = dbTrans
        Try
            Command.CommandType = CommandType.Text
            Command.CommandText = "exec KoreksiJurnal '" & kdJurnal & "','" & tanggal & "','" & nobukti & "','" & keterangan & "','" & ModKoneksi.kodeOperator & "','" & ModKoneksi.namaOperator & "','" & Guid.NewGuid.ToString & "'"
            Command.ExecuteNonQuery()
            Command.Parameters.Clear()

            For i = 0 To odatatabel.Rows.Count - 1
                Command.CommandText = " exec addDetilJurnal '" & kdJurnal & "','" & odatatabel.Rows(i).Item(1) & "','" & odatatabel.Rows(i).Item(3) & "','" & odatatabel.Rows(i).Item(4) & "','" & tanggal & "','" & Guid.NewGuid.ToString & "'"
                Command.ExecuteNonQuery()
            Next

            dbTrans.Commit()
            MsgBox("Data berhasil disimpan", MsgBoxStyle.Information, "Informasi")
        Catch ex As Exception
            dbTrans.Rollback()
            MsgBox("Data gagal disimpan" + vbCrLf + "Pesan Error : " + vbCrLf + ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        ModKoneksi.TutupKoneksi()
    End Sub

    Function SelectDataJurnalUmum(ByVal bulan As String, ByVal tahun As String)
        Dim oDataTabel As New DataTable
        oDataTabel.Clear()
        ModKoneksi.BukaKoneksi()
        Command.Connection = ModKoneksi.Koneksi
        Command.CommandType = CommandType.Text
        Command.CommandText = "exec SelectDataJurnalUmum '" & bulan & "', '" & tahun & "'"
        oDataAdapter.SelectCommand = Command
        oDataAdapter.Fill(oDataTabel)
        ModKoneksi.TutupKoneksi()
        Return oDataTabel
    End Function
End Class
