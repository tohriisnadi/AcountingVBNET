Imports System.Data.Odbc
Public Class ClassHutang
    Dim Command As New OdbcCommand
    Dim oDataAdapter As New OdbcDataAdapter
    Dim dbTrans As OdbcTransaction

    Function selectSisaHutang()
        Dim oDataTabel As New DataTable
        oDataTabel.Clear()
        ModKoneksi.BukaKoneksi()
        Command.Connection = ModKoneksi.Koneksi
        Command.CommandType = CommandType.Text
        Command.CommandText = "exec selectSisaHutang "
        oDataAdapter.SelectCommand = Command
        oDataAdapter.Fill(oDataTabel)
        ModKoneksi.TutupKoneksi()
        Return oDataTabel
    End Function


    Sub AddpembayaranHutang(ByVal NoFaktur As String, ByVal Nominal As Long, ByVal buktiTrx As String)
        ModKoneksi.BukaKoneksi()
        dbTrans = ModKoneksi.Koneksi.BeginTransaction
        Command.Connection = ModKoneksi.Koneksi
        Command.Transaction = dbTrans
        Command.CommandType = CommandType.Text
        Command.CommandText = "exec addPembayaranHutang '" & NoFaktur & "','" & Guid.NewGuid.ToString & "', '" & Nominal & "', '" & ModKoneksi.kodeOperator & "','" & buktiTrx & "'"
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
