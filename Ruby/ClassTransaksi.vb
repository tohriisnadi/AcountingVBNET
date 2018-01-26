Imports System.Data.Odbc
Public Class ClassTransaksi
    Dim Command As New OdbcCommand
    Dim oDataAdapter As New OdbcDataAdapter
    Dim dbTrans As OdbcTransaction

    Sub addTransaksiLain(ByVal kodeTxnFin As String, ByVal kodeDebet As String, ByVal kodeKredit As String, ByVal noBUktiTrans As String, ByVal nominal As String, ByVal keterangan As String)
        ModKoneksi.BukaKoneksi()
        dbTrans = ModKoneksi.Koneksi.BeginTransaction
        Command.Connection = ModKoneksi.Koneksi
        Command.Transaction = dbTrans
        Command.CommandType = CommandType.Text
        Command.CommandText = "exec addTransaksiLain '" & kodeTxnFin & "','" & kodeDebet & "','" & kodeKredit & "', '" & noBUktiTrans & "','" & nominal & "', '" & keterangan & "'  ,'" & ModKoneksi.kodeOperator & "','" & ModKoneksi.namaOperator & "','" & Guid.NewGuid.ToString & "'"
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
    Sub addTransaksi(ByVal noinvoice As String, ByVal tglKirim As String, ByVal tglPakai As String, ByVal tglAmbil As String, ByVal isLunas As String, ByVal tglJatuhTempo As String, ByVal totalsewa As Long, ByVal dp As Long, ByVal sisa As Long, ByVal biayaTransport As Long, ByVal grandtotal As Long, ByVal kodePelanggan As String, ByVal odata As DataTable)
        Dim i As Integer
        Dim Nonota As String
        Dim statusTrx As String

        ModKoneksi.BukaKoneksi()
        dbTrans = ModKoneksi.Koneksi.BeginTransaction
        Command.Connection = ModKoneksi.Koneksi
        Command.Transaction = dbTrans
        Command.CommandType = CommandType.StoredProcedure
        Command.CommandText = "{call addMasterTransaksi (?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)}"
        Try
            Command.Parameters.Add("@noInvoice", OdbcType.VarChar, 50, ParameterDirection.Input).Value = noinvoice
            Command.Parameters.Add("@tglKirim", OdbcType.VarChar, 10, ParameterDirection.Input).Value = tglKirim
            Command.Parameters.Add("@tglPakai", OdbcType.VarChar, 10, ParameterDirection.Input).Value = tglPakai
            Command.Parameters.Add("@tglAmbil", OdbcType.VarChar, 10, ParameterDirection.Input).Value = tglAmbil
            Command.Parameters.Add("@isLunas", OdbcType.VarChar, 1, ParameterDirection.Input).Value = isLunas
            Command.Parameters.Add("@tglJatuhTempo", OdbcType.VarChar, 10, ParameterDirection.Input).Value = tglJatuhTempo
            Command.Parameters.Add("@totalSewa", OdbcType.BigInt, 20, ParameterDirection.Input).Value = totalsewa
            Command.Parameters.Add("@dp", OdbcType.BigInt, 20, ParameterDirection.Input).Value = dp
            Command.Parameters.Add("@sisa", OdbcType.BigInt, 20, ParameterDirection.Input).Value = sisa
            Command.Parameters.Add("@biayaTransport", OdbcType.BigInt, 20, ParameterDirection.Input).Value = biayaTransport
            Command.Parameters.Add("@Grandtotal", OdbcType.BigInt, 20, ParameterDirection.Input).Value = grandtotal
            Command.Parameters.Add("@kodePelanggan", OdbcType.VarChar, 10, ParameterDirection.Input).Value = kodePelanggan
            Command.Parameters.Add("@kodeUser", OdbcType.VarChar, 10, ParameterDirection.Input).Value = ModKoneksi.kodeOperator
            Command.Parameters.Add("@namaUSer", OdbcType.VarChar, 50, ParameterDirection.Input).Value = ModKoneksi.namaOperator
            Command.Parameters.Add("@noTxn", OdbcType.VarChar, 50, ParameterDirection.Input).Value = Guid.NewGuid.ToString
            Command.Parameters.Add("@NoNOtanya", OdbcType.VarChar, 20)
            Command.Parameters("@NoNOtanya").Direction = ParameterDirection.Output

            Command.ExecuteNonQuery()

            Nonota = Command.Parameters("@NoNOtanya").Value
            Command.Parameters.Clear()

            Command.CommandType = CommandType.Text

            For i = 0 To odata.Rows.Count - 1
                Command.CommandText = "exec addDetilTransaksi '" & Guid.NewGuid.ToString & "','" & Nonota & "','" & odata.Rows(i).Item(0) & "','" & odata.Rows(i).Item(1) & "','" & odata.Rows(i).Item(2) & "','" & odata.Rows(i).Item(4) & "','" & odata.Rows(i).Item(3) & "','" & odata.Rows(i).Item(5) & "'"
                Command.ExecuteNonQuery()
            Next

            dbTrans.Commit()
            MsgBox("Data berhasil disimpan !", MsgBoxStyle.Information, "Informasi")
        Catch ex As Exception
            dbTrans.Rollback()
            MsgBox("Pesan Error : " + vbCrLf + ex.Message, MsgBoxStyle.Critical, "Error !")
            ' FormPenjualan.txtBarcode.Text = ex.Message

        End Try
        Command.Parameters.Clear()

        ModKoneksi.TutupKoneksi()
        ' Return NoNotax
    End Sub
End Class
