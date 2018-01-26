Imports System.Data.Odbc
Public Class ClassBukuBesar
    Dim Command As New OdbcCommand
    Dim oDataAdapter As New OdbcDataAdapter
    Dim dbTrans As OdbcTransaction
    Dim IdGuide As String

    Function selectBukuBesarbyAkun(ByVal tgldari As Date, ByVal tglsampai As Date, ByVal kodeAkun As String)
        Dim oDataTabel As New DataTable
        oDataTabel.Clear()
        ModKoneksi.BukaKoneksi()
        Command.Connection = ModKoneksi.Koneksi
        Command.CommandType = CommandType.Text
        Command.CommandText = "exec selectBukuBesarbyAkun '" & tgldari & "','" & tglsampai & "', '" & kodeAkun & "'"
        oDataAdapter.SelectCommand = Command
        oDataAdapter.Fill(oDataTabel)
        ModKoneksi.TutupKoneksi()
        Return oDataTabel
    End Function

    Function selectSaldoAkunMasaLalu(ByVal tgldari As String, ByVal tglsampai As String, ByVal kodeAkun As String)

        Dim i As Integer
        Dim saldoAkun As String
        ModKoneksi.BukaKoneksi()
        dbTrans = ModKoneksi.Koneksi.BeginTransaction
        Command.Connection = ModKoneksi.Koneksi
        Command.Transaction = dbTrans
        Command.CommandType = CommandType.StoredProcedure
        Command.CommandText = "{call selectSaldoAkunMasaLalu (?,?,?,?)}"
        Try
            Command.Parameters.Add("@tgl1", OdbcType.VarChar, 50, ParameterDirection.Input).Value = tgldari
            Command.Parameters.Add("@tgl2", OdbcType.VarChar, 255, ParameterDirection.Input).Value = tglsampai
            Command.Parameters.Add("@kodeAkun", OdbcType.VarChar, 50, ParameterDirection.Input).Value = kodeAkun
            Command.Parameters.Add("@saldoAkun", OdbcType.BigInt, 20)
            Command.Parameters("@saldoAkun").Direction = ParameterDirection.Output

            Command.ExecuteNonQuery()
            saldoAkun = Command.Parameters("@saldoAkun").Value
            Command.Parameters.Clear()
            dbTrans.Commit()
        Catch ex As Exception
            dbTrans.Rollback()
            MsgBox("Pesan Error : " + vbCrLf + ex.Message + vbCrLf + "Data gagal disimpan ! ", MsgBoxStyle.Critical, "Error")
        End Try
        ModKoneksi.TutupKoneksi()
        Return saldoAkun

    End Function
End Class
