Imports System.Data.Odbc
Public Class ClassSetting
    Dim Command As New OdbcCommand
    Dim oDataAdapter As New OdbcDataAdapter
    Dim dbTrans As OdbcTransaction

    Function selectSetting()
        Dim oDataTabel As New DataTable
        oDataTabel.Clear()
        ModKoneksi.BukaKoneksi()
        Command.Connection = ModKoneksi.Koneksi
        Command.CommandType = CommandType.Text
        Command.CommandText = "exec selectSetting "
        oDataAdapter.SelectCommand = Command
        oDataAdapter.Fill(oDataTabel)
        ModKoneksi.TutupKoneksi()
        Return oDataTabel
    End Function

    Sub editSetting(ByVal transaksi As String, ByVal piutang As String, ByVal transport As String, ByVal psTransport As String, ByVal perawatan As String, ByVal psPerawatan As String, ByVal pengembangan As String, ByVal psPengembangan As String)
        ModKoneksi.BukaKoneksi()
        dbTrans = ModKoneksi.Koneksi.BeginTransaction
        Command.Connection = ModKoneksi.Koneksi
        Command.Transaction = dbTrans
        Command.CommandType = CommandType.Text
        Command.CommandText = "exec editSetting '" & transaksi & "','" & piutang & "','" & transport & "', '" & psTransport & "','" & perawatan & "', '" & psPerawatan & "'  ,'" & pengembangan & "','" & psPengembangan & "'"
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
