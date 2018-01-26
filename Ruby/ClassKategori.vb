Imports System.Data.Odbc
Public Class ClassKategori
    Dim Command As New OdbcCommand
    Dim oDataAdapter As New OdbcDataAdapter
    Dim dbTrans As OdbcTransaction
    Function selectKategori()
        Dim oDataTabel As New DataTable
        oDataTabel.Clear()
        ModKoneksi.BukaKoneksi()
        Command.Connection = ModKoneksi.Koneksi
        Command.CommandType = CommandType.Text
        Command.CommandText = "exec selectKategori "
        oDataAdapter.SelectCommand = Command
        oDataAdapter.Fill(oDataTabel)
        ModKoneksi.TutupKoneksi()
        Return oDataTabel
    End Function
    Sub addKategori(ByVal Kategori As String)
        ModKoneksi.BukaKoneksi()
        dbTrans = ModKoneksi.Koneksi.BeginTransaction
        Command.Connection = ModKoneksi.Koneksi
        Command.Transaction = dbTrans
        Command.CommandType = CommandType.Text
        Command.CommandText = "exec addKategoriBarang '" & Kategori & "','" & ModKoneksi.kodeOperator & "','" & ModKoneksi.namaOperator & "','" & Guid.NewGuid.ToString & "'"
        Try
            Command.ExecuteNonQuery()
            dbTrans.Commit()
            MsgBox("Data berhasil disimpan", MsgBoxStyle.Information, "Informasi")
        Catch ex As Exception
            dbTrans.Rollback()
            MsgBox("Data gagal disimpan" + vbCrLf + "Pesan Error : " + vbCrLf + ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        ModKoneksi.TutupKoneksi()
    End Sub

    Sub editKategoriBarang(ByVal kodeKategori As String, ByVal Kategori As String)
        ModKoneksi.BukaKoneksi()
        dbTrans = ModKoneksi.Koneksi.BeginTransaction
        Command.Connection = ModKoneksi.Koneksi
        Command.Transaction = dbTrans
        Command.CommandType = CommandType.Text
        Command.CommandText = "exec editKategoriBarang '" & kodeKategori & "','" & Kategori & "','" & ModKoneksi.kodeOperator & "','" & ModKoneksi.namaOperator & "','" & Guid.NewGuid.ToString & "'"
        Try
            Command.ExecuteNonQuery()
            dbTrans.Commit()
            MsgBox("Data berhasil disimpan", MsgBoxStyle.Information, "Informasi")
        Catch ex As Exception
            dbTrans.Rollback()
            MsgBox("Data gagal disimpan" + vbCrLf + "Pesan Error : " + vbCrLf + ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        ModKoneksi.TutupKoneksi()
    End Sub

    Sub setNonAktifKategoriBarang(ByVal kodeKategori As String)
        ModKoneksi.BukaKoneksi()
        dbTrans = ModKoneksi.Koneksi.BeginTransaction
        Command.Connection = ModKoneksi.Koneksi
        Command.Transaction = dbTrans
        Command.CommandType = CommandType.Text
        Command.CommandText = "exec setNonAktifKategoriBarang '" & kodeKategori & "','" & ModKoneksi.kodeOperator & "','" & ModKoneksi.namaOperator & "','" & Guid.NewGuid.ToString & "'"
        Try
            Command.ExecuteNonQuery()
            dbTrans.Commit()
            MsgBox("Data berhasil disimpan", MsgBoxStyle.Information, "Informasi")
        Catch ex As Exception
            dbTrans.Rollback()
            MsgBox("Data gagal disimpan" + vbCrLf + "Pesan Error : " + vbCrLf + ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        ModKoneksi.TutupKoneksi()
    End Sub
End Class
