Imports System.Data.Odbc
Public Class ClassSuplier
    Dim Command As New OdbcCommand
    Dim oDataAdapter As New OdbcDataAdapter
    Dim dbTrans As OdbcTransaction

    Function selectDataSuplierByKode(ByVal kode As String)
        Dim oDataTabelSuplier As New DataTable
        ModKoneksi.BukaKoneksi()
        command.Connection = modKoneksi.Koneksi
        command.CommandType = CommandType.Text
        command.CommandText = "exec selectSuplierByKode '" & kode & "'"
        odataAdapter.SelectCommand = command
        odataAdapter.Fill(oDataTabelSuplier)
        modKoneksi.tutupKoneksi()
        Return oDataTabelSuplier
    End Function

    Function SelectdataSuplier()
        Dim oDataTabelSuplier As New DataTable
        ModKoneksi.BukaKoneksi()
        Command.Connection = ModKoneksi.Koneksi
        Command.CommandType = CommandType.Text
        Command.CommandText = "exec selectSuplier"
        oDataAdapter.SelectCommand = Command
        oDataAdapter.Fill(oDataTabelSuplier)
        ModKoneksi.TutupKoneksi()
        Return oDataTabelSuplier
    End Function

    Public Sub addSuplier(ByVal nama As String, ByVal Alamat As String, ByVal ContactPerson As String, ByVal noTelp As String)
        ModKoneksi.BukaKoneksi()
        dbTrans = ModKoneksi.Koneksi.BeginTransaction
        Command.Connection = ModKoneksi.Koneksi
        Command.Transaction = dbTrans
        Command.CommandType = CommandType.Text
        Command.CommandText = " exec addSuplier '" & nama & "','" & Alamat & "','" & ContactPerson & "','" & noTelp & "','" & ModKoneksi.kodeOperator & "','" & ModKoneksi.namaOperator & "','" & Guid.NewGuid.ToString & "'"
        Try
            Command.ExecuteNonQuery()
            dbTrans.Commit()
            MsgBox("Data Berhasil Disimpan", MsgBoxStyle.Information, "Informasi")
        Catch ex As Exception
            dbTrans.Rollback()
            MsgBox("Pesan Error : " + vbCrLf + ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        ModKoneksi.TutupKoneksi()
    End Sub

    Public Sub editSuplier(ByVal kodeSuplier As String, ByVal nama As String, ByVal Alamat As String, ByVal ContactPerson As String, ByVal noTelp As String)
        ModKoneksi.BukaKoneksi()
        dbTrans = ModKoneksi.Koneksi.BeginTransaction
        Command.Connection = ModKoneksi.Koneksi
        Command.Transaction = dbTrans
        Command.CommandType = CommandType.Text
        Command.CommandText = "exec editSuplier '" & kodeSuplier & "','" & nama & "','" & Alamat & "','" & ContactPerson & "','" & noTelp & "','" & ModKoneksi.kodeOperator & "','" & ModKoneksi.namaOperator & "','" & Guid.NewGuid.ToString & "'"
        Try
            Command.ExecuteNonQuery()
            dbTrans.Commit()
            MsgBox("Data Berhasil Diubah", MsgBoxStyle.Information, "Informasi")
        Catch ex As Exception
            dbTrans.Rollback()
            MsgBox("Pesan Error : " + vbCrLf + ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        ModKoneksi.TutupKoneksi()
    End Sub
    Public Sub nonAktifSuplier(ByVal kodeSuplier As String)
        ModKoneksi.BukaKoneksi()
        dbTrans = ModKoneksi.Koneksi.BeginTransaction
        Command.Connection = ModKoneksi.Koneksi
        Command.Transaction = dbTrans
        Command.CommandType = CommandType.Text
        Command.CommandText = "exec SetNonAktifSuplier '" & kodeSuplier & "'"
        Try
            Command.ExecuteNonQuery()
            dbTrans.Commit()
            MsgBox("Data Berhasil Dihapus", MsgBoxStyle.Information, "Informasi")
        Catch ex As Exception
            dbTrans.Rollback()
            MsgBox("Pesan Error : " + vbCrLf + ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        ModKoneksi.TutupKoneksi()
    End Sub


End Class
